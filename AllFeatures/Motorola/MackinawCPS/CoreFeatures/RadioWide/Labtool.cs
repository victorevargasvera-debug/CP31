using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Features.Converters;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000178 RID: 376
	[global::System.Serializable]
	public class Labtool : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06003678 RID: 13944 RVA: 0x0033FF9C File Offset: 0x0033E19C
		public Labtool(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06003679 RID: 13945 RVA: 0x0033FFB8 File Offset: 0x0033E1B8
		protected Labtool(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600367A RID: 13946 RVA: 0x0033FFD0 File Offset: 0x0033E1D0
		public override void Init()
		{
			int a_ = 13;
			short num = (short)1019557394;
			short num2 = num;
			num = (short)1242576402;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1584267264;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)455213056;
			if (num != 0)
			{
			}
			num = (short)1270153217;
			if (num != 0)
			{
			}
			this.radWideLabtoolArchiveReadPasswordEnable_A7462 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧ꯩ黫跭飯鯱苳鏵꫷鿹鷻髽僿持眃甅缇攉縋樍唏簑甓琕琗缙䌛弝ᜟᘡሣᐥ", a_), global::CommonResources.AcgResources.ID_ARCHIVEREADPASSWORDENABLE);
			this.radWideLabtoolArchiveReadPasswordEnable_A7462.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolArchiveReadPasswordEnable_A7462.DataTransferOrder = -1;
			this.radWideLabtoolControlHeadConfiguration_A7722 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧ꧩ菫胭蓯胱鯳髵냷鿹鷻髽䏿洁樃怅愇洉礋簍焏昑紓礕瘗䔙崛⤝ᜟအᘣ", a_), global::CommonResources.AcgResources.ID_CONTROLHEADCONFIGURATION);
			this.radWideLabtoolControlHeadConfiguration_A7722.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolControlHeadSelection_A7723 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧ꧩ菫胭蓯胱鯳髵냷鿹鷻髽叿朁栃挅欇縉攋愍縏䴑唓ℕ⼗⠙⼛", a_), global::CommonResources.AcgResources.ID_CONTROLHEADSELECTION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideLabtoolControlHeadSelection_A7723LovStrs);
			this.radWideLabtoolControlHeadSelection_A7723.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolDisplayContrastConfiguration_A7873 = new global::AcpBusinessLayer.AcpSimpleRangeField(69, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧껩藫鷭胯黱闳迵믷闹鋻諽狿持眃爅䬇攉戋栍礏甑愓搕礗渙甛焝丟紡攣ᄥဧᴩἫ", a_), global::CommonResources.AcgResources.ID_DISPLAYCONTRASTCONFIGURATION, 0, 255, null, null, 0, 1);
			this.radWideLabtoolDisplayContrastConfiguration_A7873.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolDisplayContrastConfiguration_A7873.ShowHexValue = true;
			this.radWideLabtoolFatalError_A8015 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧곩跫髭釯黱뇳蓵諷闹軻ꇽ䇿㨁㐃㜅㴇", a_), global::CommonResources.AcgResources.ID_FATALERROR);
			this.radWideLabtoolFatalError_A8015.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolFatalError_A8015.DataTransferOrder = -1;
			this.radWideLabtoolFlipDisplayOption_A8140 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧곩胫蟭胯뛱鷳藵裷雹鷻蟽俿爁瀃漅朇搉匋伍⠏⌑–☕", a_), global::CommonResources.AcgResources.ID_FLIPDISPLAYOPTION);
			this.radWideLabtoolFlipDisplayOption_A8140.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolFlipDisplayOption_A8140.DataTransferOrder = -1;
			this.radWideLabtoolFreeRevolvingRotary_A8147 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧곩黫语闯ꃱ釳胵韷雹諻韽滿攁嘃椅簇欉縋眍伏匑Ⱃ✕Ⱇⴙ", a_), global::CommonResources.AcgResources.ID_FREEREVOLVINGROTARY);
			this.radWideLabtoolFreeRevolvingRotary_A8147.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolFreeRevolvingRotary_A8147.DataTransferOrder = -1;
			this.radWideLabtoolKeypadType_A8372 = new global::AcpBusinessLayer.AcpListField(3, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧ꇩ觫韭胯鏱郳ꋵ臷諹駻ꇽ䇿㨁㜃ㄅ㨇", a_), global::CommonResources.AcgResources.ID_KEYPADTYPE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideLabtoolKeypadType_A8372LovStrs);
			this.radWideLabtoolKeypadType_A8372.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolKeypadType_A8372.DataTransferOrder = -1;
			this.radWideLabtoolRadioPassword_A8837 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧룩跫諭駯鷱ꓳ韵请觹读釽狿昁嬃䜅〇㈉㼋㤍", a_), global::CommonResources.AcgResources.ID_READWRITEPASSWORD, 32);
			this.radWideLabtoolRadioPassword_A8837.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolRadioPassword_A8837.DataTransferOrder = -1;
			this.radWideLabtoolRadioReadPasswordEnable_A8869 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧룩跫諭駯鷱꛳鏵駷黹곻鿽珿焁猃椅稇渉䤋怍焏瀑砓猕䜗嬙␛☝ᘟᬡ", a_), global::CommonResources.AcgResources.ID_RADIOREADPASSWORDENABLE);
			this.radWideLabtoolRadioReadPasswordEnable_A8869.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolRadioReadPasswordEnable_A8869.DataTransferOrder = -1;
			this.radWideLabtoolRadioWritePasswordEnable_A8889 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧룩跫諭駯鷱ꏳ蓵釷軹駻껽懿焁眃焅朇砉栋䬍縏猑瘓稕紗䔙崛☝᠟ᨡᴣ", a_), global::CommonResources.AcgResources.ID_RADIOWRITEPASSWORDENABLE);
			this.radWideLabtoolRadioWritePasswordEnable_A8889.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolRadioWritePasswordEnable_A8889.DataTransferOrder = -1;
			this.radWideLabtoolReadWriteVoiceFiles_A8893 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧룩觫迭铯ꗱ蛳鿵賷鿹꫻釽槿愁愃䀅愇昉椋納伏匑Ⱃ⸕℗⤙", a_), global::CommonResources.AcgResources.ID_READWRITEVOICEFILES);
			this.radWideLabtoolReadWriteVoiceFiles_A8893.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolReadWriteVoiceFiles_A8893.DataTransferOrder = -1;
			this.radWideLabtoolSirenPaFatalError_A9141 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧맩藫鳭闯鳱ꓳ韵뻷鯹裻鿽泿䜁瘃琅朇砉匋伍⤏⌑–✕", a_), global::CommonResources.AcgResources.ID_SIRENPAFATALERROR);
			this.radWideLabtoolSirenPaFatalError_A9141.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolSirenPaOnly_A9142 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧맩藫鳭闯鳱ꓳ韵럷铹郻蟽忿䌁㴃㜅㰇㠉", a_), global::CommonResources.AcgResources.ID_SIRENPAONLY);
			this.radWideLabtoolSirenPaOnly_A9142.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolSirenPaSystemLookup_A9143 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧맩藫鳭闯鳱ꓳ韵꯷菹迻諽旿漁䠃椅朇愉礋縍伏匑ⴓ✕Ⱇ⤙", a_), global::CommonResources.AcgResources.ID_SIRENPASYSTEMLOOKUP);
			this.radWideLabtoolSirenPaSystemLookup_A9143.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.trunkingRadioInhibited_A19483 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髍ꋏꟑ뫓뷕뇗듙믛賝臟蛡跣觥ꇧ蓩蓫蟭鋯鯱胳鏵鳷ꗹ뷻쿽㧿㘁㰃㔅", a_), global::CommonResources.AcgResources.ID_TRUNKINGRADIOINHIBITED);
			this.trunkingRadioInhibited_A19483.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.trunkingRadioInhibited_A19483.DataTransferOrder = -1;
			this.radWideLabtoolZoneSelectorOnSwitch_A19550 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧냩菫胭闯ꇱ釳髵鷷駹裻釽狿䴁樃唅缇按砋洍砏䴑唓✕℗⼙⤛⸝", a_), global::CommonResources.AcgResources.ID_ZONESELECTORONSWITCH);
			this.radWideLabtoolZoneSelectorOnSwitch_A19550.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolZoneSelectorOnSwitch_A19550.DataTransferOrder = -1;
			this.radWideLabtoolChannelSelectorOnSwitch_A19551 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧ꧩ蓫迭黯鳱釳髵꯷鿹郻鯽揿瘁欃琅䜇搉弋礍礏昑眓縕䜗嬙ⴛ✝ᔟᜡᔣ", a_), global::CommonResources.AcgResources.ID_CHANNELSELECTORONSWITCH);
			this.radWideLabtoolChannelSelectorOnSwitch_A19551.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolChannelSelectorOnSwitch_A19551.DataTransferOrder = -1;
			this.radWideLabtoolSmartLowBatteryThreshold_A20201 = new global::AcpBusinessLayer.AcpRangeField<int, string>(10, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧맩臫迭苯蛱룳駵迷룹鷻諽瓿朁瘃缅將戉縋欍挏稑笓稕簗䔙崛Ⱍဟအᐣᜥ", a_), global::CommonResources.AcgResources.ID_SMARTLOWBATTERYTHRESHOLD, 0, 255, 1);
			this.radWideLabtoolSmartLowBatteryThreshold_A20201.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolSmartLowBatteryThreshold_A20201.DataTransferOrder = -1;
			this.radWideLabtoolSmartLowBatteryThreshold_A20201.ShowHexValue = false;
			this.radWideLabtoolEarlyWarningBatteryThreshold_A23977 = new global::AcpBusinessLayer.AcpSimpleRangeField(15, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧꿩跫鳭鳯诱ꏳ韵諷铹闻都柿䀁攃爅簇漉縋眍䐏稑易猕欗爙猛爝䐟紡攣ᐥᬧጩᬫ᤭", a_), global::CommonResources.AcgResources.ID_EARLYWARNINGBATTERYTHRESHOLD, 0, 255, null, null, 0, 1);
			this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.DataTransferOrder = -1;
			this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.ShowHexValue = false;
			this.radWideLabtoolConsoletteModelEnable_A7713 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧ꧩ菫胭華鷱飳鏵賷軹駻돽濿昁愃樅䴇搉洋氍簏眑䬓圕⼗ⴙⴛⴝ", a_), global::CommonResources.AcgResources.ID_CONSOLETTEMODEL);
			this.radWideLabtoolConsoletteModelEnable_A7713.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolConsoletteModelEnable_A7713.DataTransferOrder = -1;
			this.radWideLabtoolDisplayType_A7887 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadWideLabtoolDisplayType_A7887LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadWideLabtoolDisplayType_A7887LovStrs), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧껩藫鷭胯黱闳迵곷菹賻鯽忿䌁㌃㸅〇㴉", a_), global::CommonResources.AcgResources.ID_DISPLAYTYPE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideLabtoolDisplayType_A7887LovStrs);
			this.radWideLabtoolDisplayType_A7887.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolDisplayType_A7887.DataTransferOrder = -1;
			this.radWideLabtoolDynamicZoneCable_A41258 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧껩闫胭釯鿱鷳闵ꋷ闹鋻鯽䏿持昃樅洇唉䴋㨍ℏ‑ℓ⸕", a_), global::CommonResources.AcgResources.ID_DYNAMICZONECAPABLE);
			this.radWideLabtoolDynamicZoneCable_A41258.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolDynamicZoneCable_A41258.DataTransferOrder = -1;
			this.radWideLabtoolSirenAndLightsKeypadEnable_A41413 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧맩藫鳭闯鳱뗳飵鳷뛹闻駽棿瘁眃䴅洇猉簋漍琏圑稓眕稗瘙礛䄝感ᘡᔣሥᤧᤩ", a_), global::CommonResources.AcgResources.ID_SIRENANDLIGHTSKEYPADENABLE);
			this.radWideLabtoolSirenAndLightsKeypadEnable_A41413.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolSirenAndLightsKeypadEnable_A41413.DataTransferOrder = -1;
			this.radWideEmergencyRxTxAlertToneSet_A41508 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙駛돝藟郡菣菥蛧觩闫볭裯꛱賳럵铷鿹軻諽哿洁樃挅嬇漉砋儍儏☑┓⌕⠗∙", a_), global::CommonResources.AcgResources.ID_EMERGENCYRXTXALERTTONESET, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideEmergencyRxTxAlertToneSet_A41508LovStrs);
			this.radWideEmergencyRxTxAlertToneSet_A41508.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideEmergencyRxTxAlertToneSet_A41508.DataTransferOrder = -1;
			this.radWideRadioKilled_A41559 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙軛뿝蓟诡诣귥臧蛩胫语铯귱뗳싵짷쿹짻쟽", a_), global::CommonResources.AcgResources.ID_RADIOKILLED);
			this.radWideRadioKilled_A41559.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideRadioKilled_A41559.DataTransferOrder = -1;
			this.radWideLabtoolEncryptPassword_A41695 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧꿩苫跭苯诱蓳苵ꣷ鯹迻跽矿洁瘃戅圇䬉㠋㼍☏⬑ℓ", a_), global::CommonResources.AcgResources.ID_ENCRYPTPASSWORD);
			this.radWideLabtoolEncryptPassword_A41695.IgnoreOnCompare = true;
			this.radWideLabtoolEncryptPassword_A41695.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolEncryptPassword_A41695.DataTransferOrder = -1;
			this.radWideLabtoolEncryptedPINPassword_A41702 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("ﳍ鋏韕ꇟ\udae1탣탥\udde7\udae9\udbebꫭ짯쯱쟳쟵죷쯹룻쯽㏿㘁㄃䔅䴇伉㼋伍刏儑刓匕ⴗⰙ⠛☝戟挡ᴣဥᴧ氩ᐫ漭įб申Ե紷簹缻紽爿сɃ畅硇祉ੋ్楏ᝑᅓᕕ浗桙湛楝⑟婡≣剥內卩孫⽭㕯㝱䑳䕵㥷乹䥻䵽땿늁늃쎅캇즉릋", a_), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧꿩苫跭苯诱蓳苵鷷黹곻럽仿刁攃甅笇紉挋簍琏䴑唓∕⤗ⴙⰛⰝ", a_), global::CommonResources.AcgResources.ID_ENCRYPTEDPINPASSWORD, 96);
			this.radWideLabtoolEncryptedPINPassword_A41702.IgnoreOnCompare = true;
			this.radWideLabtoolEncryptedPINPassword_A41702.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolEncryptedPINPassword_A41702.DataTransferOrder = -1;
			this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧뿩胫髭苯鏱룳駵迷꫹鏻觽旿瀁圃椅搇渉攋欍戏弑甓甕嬗笙氛缝䈟両䄣礥椧ḩᴫ᤭įȱ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSULTRALOWPOWER);
			this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710.DataTransferOrder = -1;
			this.radWideLabtoolEmergencyRevertCapable_A41918 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧꿩臫语苯闱釳飵鯷菹껻鯽盿朁瘃爅䬇欉簋漍爏縑焓䤕夗⸙ⴛ✝ᄟᨡ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSMULTIPLEEMERGENCYREVERTCAPABLE);
			this.radWideLabtoolEmergencyRevertCapable_A41918.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolEmergencyRevertCapable_A41918.DataTransferOrder = -1;
			this.radWideLabtoolAudibleBeaconRoutingCapable_A41974 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧ꯩ駫諭駯郱飳鏵뫷鿹鷻鷽濿氁嘃椅紇縉攋怍眏儑甓昕礗砙瀛笝缟挡ဣᜥᄧᴩᠫ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSAUDIBLEEMERGENCYBEACONROUTINGCAPABLE);
			this.radWideLabtoolAudibleBeaconRoutingCapable_A41974.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolAudibleBeaconRoutingCapable_A41974.DataTransferOrder = -1;
			this.manDownPersonalityConfigurableCapable_42082 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("菍뇏병郓맕꿗듙賛믝鋟釡诣裥觧蛩藫髭觯뇱鯳飵黷鏹鯻诽狿持昃樅洇䤉洋縍焏瀑砓猕䜗⸙⸛⸝᠟အ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSMANDOWNEMERGENCYPROFILECONFIGURABILITY);
			this.manDownPersonalityConfigurableCapable_42082.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.manDownPersonalityConfigurableCapable_42082.DataTransferOrder = -1;
			this.toneEmergencyConfigurableCapable_42083 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髍뿏병뇓鏕뗗뿙껛망藟賡蟣鿥ꯧ藩苫裭駯闱至蓵駷飹郻鯽䏿持球朅樇昉椋儍␏‑␓⸕⬗", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSEMERGENCYTONECONFIGURABILITY);
			this.toneEmergencyConfigurableCapable_42083.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.toneEmergencyConfigurableCapable_42083.DataTransferOrder = -1;
			this.radWideLabtoolAPX6000P25Radio_A42121 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧ꯩ볫뛭웯싱쓳웵ꣷ죹짻곽懿昁洃椅圇䬉㠋㰍ℏ‑┓", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSAPX6000P25RADIO);
			this.radWideLabtoolAPX6000P25Radio_A42121.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolAPX6000P25Radio_A42121.DataTransferOrder = -1;
			this.radWideLabtoolSuppressEmergencyCallCapability_A42143 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧맩駫黭胯胱釳藵请뿹釻鯽狿攁愃栅欇猉伋漍簏縑圓眕栗笙縛眝䰟䬡倣弥眧欩ᠫᰭįرܳ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSDISABLEEMERGENCYCALLINDICATIONSCAPABLE);
			this.radWideLabtoolSuppressEmergencyCallCapability_A42143.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolSuppressEmergencyCallCapability_A42143.DataTransferOrder = -1;
			this.radWideLabtoolMaritimeRadioSoftware_A42191 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧꟩跫鳭駯蛱鷳鯵鷷꣹鷻髽槿洁圃椅渇縉笋漍戏眑䬓圕Ⱇ⠙ⴛ✝ᄟ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSMARITIMERADIOSOFTWARE);
			this.radWideLabtoolMaritimeRadioSoftware_A42191.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolMaritimeRadioSoftware_A42191.DataTransferOrder = -1;
			this.radWideLabtoolMFKEmergencyAccess_A42216 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧꟩ꫫꗭ뗯鿱釳蓵鿷鿹鋻鷽秿䌁會攅洇礉缋儍儏☑☓␕⤗Ⱉ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSMFKEMERGENCYACCESS);
			this.radWideLabtoolMFKEmergencyAccess_A42216.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolMFKEmergencyAccess_A42216.DataTransferOrder = -1;
			this.emergencyHotAuxMicConfigurability_A42301 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("词뷏럑ꛓ뇕뷗듙뿛꟝꣟跡郣꟥鷧鋩ꇫ蟭鏯뇱鯳飵黷鏹鯻诽狿持昃漅搇按砋眍伏匑–␕⬗⨙ⴛ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSEMERGENCYHOTAUXMICCONFIGURABILITY);
			this.emergencyHotAuxMicConfigurability_A42301.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.emergencyHotAuxMicConfigurability_A42301.DataTransferOrder = -1;
			this.tPSCapable_A42312 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髍胏臑韓럕꣗믙뻛닝藟뷡ꗣ틥\udae7\ud9e9\uddeb\udced", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSAUDIBLEEMERGENCYBEACONCAPABLEFORMOBILE);
			this.tPSCapable_A42312.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.tPSCapable_A42312.DataTransferOrder = -1;
			this.pASSAlarmFilterCapable_A42387 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("黍量臑蟓韕듗믙껛돝ꛟ诡裣鋥跧飩꿫迭胯鏱雳髵鷷ꗹ뷻쫽㋿㄁㰃ㄅ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSPASSALARMFILTERCAPABLE);
			this.pASSAlarmFilterCapable_A42387.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.pASSAlarmFilterCapable_A42387.DataTransferOrder = -1;
			this.radWideLabtoolAPXDualKnobs_A42537 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧ꯩ볫뛭듯蟱闳髵돷铹鏻鳽珿崁䔃㈅㨇㼉㼋㤍", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSAPX2KNOBCONTROL);
			this.radWideLabtoolAPXDualKnobs_A42537.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolAPXDualKnobs_A42537.DataTransferOrder = -1;
			this.radWideLabtoolAudioEnhancement_A42736 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧ꯩ駫諭駯鷱뇳飵郷鯹鋻鷽旿漁愃栅簇唉䴋㨍∏┑✓―", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSAUDIOENHANCEMENT);
			this.radWideLabtoolAudioEnhancement_A42736.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolAudioEnhancement_A42736.DataTransferOrder = -1;
			this.radWideLabtoolDynamicZoneScanCapability_42749 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧껩闫胭釯鿱鷳闵ꋷ闹鋻鯽叿愁攃栅䬇欉簋漍爏笑砓缕気挙䌛⨝ሟᔡဣἥ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSDYNAMICZONESCANCAPABILITY);
			this.radWideLabtoolDynamicZoneScanCapability_42749.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolDynamicZoneScanCapability_42749.DataTransferOrder = -1;
			this.radioWideDVRSTrunkingStatusCapability_A42772 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑뷓맕迗동룛믝ꓟ듡뛣뗥볧飩駫胭鯯鯱髳釵꯷軹鷻諽痿焁䜃朅砇欉渋服簏笑怓漕䜗嬙⠛Ⱍᜟᔡᘣ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSDVRSTRUNKINGSTATUSCAPABILITY);
			this.radioWideDVRSTrunkingStatusCapability_A42772.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radioWideDVRSTrunkingStatusCapability_A42772.DataTransferOrder = -1;
			this.radioWideMOSCADACE3000Capability_A42772 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑뷓맕迗동룛믝귟귡럣ꗥꧧ껩귫귭뗯쇱쓳웵죷맹鷻軽懿态洃樅愇縉甋儍儏☑☓ℕ⼗⠙", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSMOSCADACE3600CAPABLE);
			this.radioWideMOSCADACE3000Capability_A42772.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radioWideMOSCADACE3000Capability_A42772.DataTransferOrder = -1;
			this.radioWideReqFWVersion_A42872 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑뷓맕迗동룛믝닟蟡闣ꃥ뿧볩觫鳭華鯱鯳飵ꟷ믹죻쳽㣿㔁㘃", a_), global::CommonResources.AcgResources.ID_REQUIREDFIRMWAREVERSION, 10);
			this.radioWideReqFWVersion_A42872.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radioWideReqFWVersion_A42872.DataTransferOrder = -1;
			this.radWideLabtoolPAAlertCapability_A42944 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧뫩귫꿭鳯韱蛳苵믷鯹賻鿽拿欁栃漅簇猉匋伍␏‑ⴓ∕Ⱇ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSPERSONNELACCOUNTABILITYALERTCAPABLE);
			this.radWideLabtoolPAAlertCapability_A42944.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolPAAlertCapability_A42944.DataTransferOrder = -1;
			this.radWideLabtoolUserSelectablePLEnhancement_43031 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧뿩鿫语苯ꇱ釳髵鷷駹裻鿽拿渁愃嘅䐇伉戋昍焏簑眓猕甗缙爛樝缟ᘡᜣᘥᬧᬩ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSUSERSELECTABLEPLENHANCEMENT);
			this.radWideLabtoolUserSelectablePLEnhancement_43031.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolUserSelectablePLEnhancement_43031.DataTransferOrder = -1;
			this.radWideLabtoolConsolidatedActionEnhancement_A43036 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧ꧩ菫胭華鷱飳鿵鳷鯹裻鯽擿䌁會爅愇攉戋䬍縏稑甓砕笗缙焛笝丟嘡笣朥ᰧᤩᰫᴭد", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSCONSOLIDATEDACTIONSENHANCEMENT);
			this.radWideLabtoolConsolidatedActionEnhancement_A43036.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolConsolidatedActionEnhancement_A43036.DataTransferOrder = -1;
			this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧ꛩ藫菭駯蛱釳鋵뇷꧹꿻럽䓿吁嘃唅䜇稉椋簍焏昑紓礕瘗夙紛渝䄟䀡䠣䌥眧ḩἫḭЯܱ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSLIMITEDISSIDVRSOPERATIONCAPABLE);
			this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045.DataTransferOrder = -1;
			this.radWideLabtoolActiveMicForBTPTTCapable_43053 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧ꯩ迫髭駯蓱釳믵釷駹뫻釽狿䀁倃嘅將帉伋漍怏猑瘓稕紗䔙⠛ⴝဟᜡᜣ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSACTIVEMICFORBLUETOOTHPTTCAPABLE);
			this.radWideLabtoolActiveMicForBTPTTCapable_43053.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolActiveMicForBTPTTCapable_43053.DataTransferOrder = -1;
			this.radWideLabtoolAPXSingletoneCapable_43080 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧ꯩ볫뛭ꏯ鯱髳釵铷鿹裻釽滿朁䜃朅砇欉渋戍甏䴑–┕⠗∙Ⱋ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSAPXSINGLETONECAPABLE);
			this.radWideLabtoolAPXSingletoneCapable_43080.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolAPXSingletoneCapable_43080.DataTransferOrder = -1;
			this.radWideLabtoolEnhancedARS_A43084 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧꿩苫蛭釯鳱音鏵鳷믹껻귽忿䌁〃㔅㠇㈉㠋", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSENHANCEDARS);
			this.radWideLabtoolEnhancedARS_A43084.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolEnhancedARS_A43084.DataTransferOrder = -1;
			this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧꿩臫语苯闱釳飵鯷菹뿻鿽泿渁䬃栅搇猉笋服搏稑尓礕気圙甛紝挟䌡吣䜥䨧䘩䤫焭焯رܳܵื࠹", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSEMERGENCYCALLONLYWITHHOTMICCAPABLE);
			this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.DataTransferOrder = -1;
			this.radioWideLabtoolZoneCloneCapable_43238 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑뷓맕迗동룛믝곟菡蛣鋥蟧藩胫듭鿯鳱釳뗵铷闹鋻鯽䏿持球朅樇昉椋儍␏ℑ☓┕‗", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSZONECLONECAPABLE);
			this.radioWideLabtoolZoneCloneCapable_43238.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radioWideLabtoolZoneCloneCapable_43238.DataTransferOrder = -1;
			this.radioWideLabtoolEmergencyCallTermination_43348 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑뷓맕迗동룛믝곟菡蛣鋥蟧藩胫꯭鷯韱蛳釵鷷铹鿻蟽䏿持栃樅將漉縋挍礏簑甓戕焗甙爛䄝ᐟᄡᜣሥဧ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSEMERGENCYCALLTERMINATION);
			this.radioWideLabtoolEmergencyCallTermination_43348.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radioWideLabtoolEmergencyCallTermination_43348.DataTransferOrder = -1;
			this.radWideLabtoolDisableEncryption_43371 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧껩藫鷭釯郱飳鏵뷷铹鿻賽秿爁瀃漅朇搉匋㨍⌏ℑ⌓✕", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSDISABLEENCRYPTION);
			this.radWideLabtoolDisableEncryption_43371.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolDisableEncryption_43371.DataTransferOrder = -1;
			this.radWideLabtoolIntelligentPriorityScanCapable_43411 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧ꏩ苫髭闯黱飳鿵鿷鿹鋻諽僿瀁洃椅稇按砋眍䌏焑甓砕嬗笙氛缝䈟両䄣礥ᰧᤩᠫἭį", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSINTELLIGENTPRIORITYSCANCAPABLE);
			this.radWideLabtoolIntelligentPriorityScanCapable_43411.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolIntelligentPriorityScanCapable_43411.DataTransferOrder = -1;
			this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑뷓맕迗동룛믝곟菡蛣鋥蟧藩胫ꫭ駯臱闳铵铷鿹꯻韽滿昁䨃椅愇礉椋對甏瘑愓甕気猙猛瀝氟䜡刣䌥䐧氩䌫尭焯儱圳匵䬷䤹医䰽⤿❁㝃᥅籇祉祋積桏", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSDISABLEWINDNOISEREDUCTIONLEVELFORACCESSORIES);
			this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.DataTransferOrder = -1;
			this.mARVELL_DNP_43591 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("菍量胑苓鏕铗雙菛髝껟닡믣틥\udbe7\udfe9헫\udfed", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSWIFINOTSUPPORTEDBYHARDWARE);
			this.mARVELL_DNP_43591.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.tEN_DIGIT_RL_PSWD_capable_43711 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髍闏鳑诓鋕釗鷙闛諝뿟냡꣣맥룧맩믫ꫭ꿯釱闳蛵駷飹郻鯽忿㘁㜃ㄅ㤇㬉", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSRADIOLOCKPASSWORDEXTENSIONCAPABLE);
			this.tEN_DIGIT_RL_PSWD_capable_43711.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.tEN_DIGIT_RL_PSWD_capable_43711.DataTransferOrder = -1;
			this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort = new global::AcpBusinessLayer.AcpSimpleRangeField(49682, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧ꧩ觫鳭蓯뿱鏳鯵賷럹鏻諽濿瀁欃樅椇変挋戍攏昑紓礕瘗椙䰛唝椟爡䬣吥尧", a_), global::CommonResources.AcgResources.ID_CERTMGMTMOTOROLASOLUTIONSPKIPORT, 0, 65535, null, null, 0, 1);
			this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.DataTransferOrder = -1;
			this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.ShowHexValue = false;
			this.radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("꫍뗏ꓑ뷓뗕뷗맙맛곝铟迡菣该鳧쓩臫臭蓯臱鯳髵裷釹闻탽揿洁椃", a_), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧ꧩ觫鳭蓯뿱鏳鯵賷럹鏻諽濿瀁欃樅椇変挋戍攏昑紓礕瘗椙䰛唝椟模䬣唥尧䐩䴫䌭唯", a_), global::CommonResources.AcgResources.ID_CERTMGMTMOTOROLASOLUTIONSPKIHOSTNAME, 64);
			this.radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname.DataTransferOrder = -1;
			this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧껩觫飭駯釱釳믵鿷韹裻귽旿持椃樅洇礉缋嬍怏瘑甓戕紗䠙焛丝匟䤡洣䈥", a_), global::CommonResources.AcgResources.ID_DEVICEMGMTSEAMLESSUPDATERMPSKID, 0, 65535, null, null, 0, 1);
			this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.DataTransferOrder = -1;
			this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.ShowHexValue = false;
			this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("ﻍ\ud9dfꏡꛣꗥ곧꿩ꫫ\udeed쇯샱쟳싵췷쳹쯻웽㧿䌁䘃䔅䰇伉䨋㸍ℏ‑✓∕ⴗⰙ⬛☝᤟挡昣攥氧漩樫ḭį1ܳȵഷహ଻ؽ礿́كՅేཉੋ", a_), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧껩觫飭駯釱釳믵鿷韹裻귽旿持椃樅洇礉缋嬍怏瘑甓戕紗䠙焛丝匟䤡", a_), global::CommonResources.AcgResources.ID_DEVICEMGMTSEAMLESSUPDATERMPSK, 64);
			this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk.DataTransferOrder = -1;
			this.radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("꿍ꃏ믑䀘ꓕ맗뻙뗛뇝菟蟡諣鋥髧诩胫샭鷯鷱胳駵諷闹郻鿽珿洁栃猅簇按挋怍挏㰑眓礕甗", a_), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧껩觫飭駯釱釳믵鿷韹裻귽旿持椃樅洇礉缋嬍怏瘑甓戕紗崙紛樝䔟唡䔣弥性䔩弫娭帯匱夳匵", a_), global::CommonResources.AcgResources.ID_DEVICEMGMTSEAMLESSUPDATEGATEWAYHOSTNAME, 64);
			this.radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname.DataTransferOrder = -1;
			this.radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("ﻍ탟틡퓣훥\ud8e7\udae9\udceb\udeed샯싱쓳웵죷쫹쳻컽ヿ㈁㐃㘅㠇㨉㰋", a_), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧껩觫飭駯釱釳믵鿷韹裻믽滿瘁愃琅砇砉攋納甏䔑紓瀕焗夙猛稝䔟刡䠣匥伧挩䠫", a_), global::CommonResources.AcgResources.ID_DEVICEMGMTENTERPRISEWIFICODEPLUGID, 32);
			this.radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId.DataTransferOrder = -1;
			this.radWideLabtoolRCLastJobSetUUID = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("ﻍ탟틡퓣훥\ud8e7\udae9\udceb\udeed샯싱쓳웵죷쫹쳻컽ヿ㈁㐃㘅㠇㨉㰋", a_), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧룩꿫ꋭ釯臱胳복韷飹꿻鯽瓿圁儃伅䰇", a_), global::CommonResources.AcgResources.ID_RC_LASTJOBSET_UUID, 32);
			this.radWideLabtoolRCLastJobSetUUID.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolRCLastJobSetUUID.DataTransferOrder = -1;
			this.radWideLabtoolSeamlessUpdateOutOfBoxExperience = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧맩觫迭鷯黱釳藵请꿹賻髽懿瘁愃䤅紇縉䌋栍刏紑氓匕怗標礛氝䤟䜡䨣䔥䴧", a_), global::CommonResources.AcgResources.ID_RADWIDELABTOOLSEAMLESSUPDATEOUTOFBOXEXPERIENCE);
			this.radWideLabtoolSeamlessUpdateOutOfBoxExperience.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolSeamlessUpdateOutOfBoxExperience.DataTransferOrder = -1;
			this.h();
			this.f();
			this.g();
			this.e();
			this.d();
			this.c();
			this.b();
			this.a();
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苍뇏냑ꃓ맕럗뛙", a_);
			base.Id = 10093;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 7;
		}

		// Token: 0x0600367B RID: 13947 RVA: 0x003410C0 File Offset: 0x0033F2C0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 0;
			short num = (short)1410203856;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釀苂雄铆裈ꟊ곌뷎볐闒볔믖귘뻚꿜鳞胠鏢蓤藦藨軪달껮연쇲웴쿶컸", a_)))
					{
						num = (short)1660026902;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3186;
				case 1:
					this.radWideLabtoolFatalError_A8015 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚鯜뻞闠苢觤ꋦ鯨駪苬鷮껰닲췴쟶죸컺", a_), global::CommonResources.AcgResources.ID_FATALERROR);
					this.radWideLabtoolFatalError_A8015.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolFatalError_A8015.DataTransferOrder = -1;
					num = (short)250937352;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚远뻞藠諢諤뗦賨諪觬뿮郰胲蛴胶雸觺駼뫾漀戂朄欆氈吊䰌㜎⤐┒Ⱄ", a_)))
					{
						num = (short)1274544284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FEB;
				case 3:
					goto IL_29C1;
				case 4:
					goto IL_3281;
				case 5:
					this.radWideLabtoolSuppressEmergencyCallCapability_A42143 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚軜꫞釠鏢韤苦髨飪꣬苮铰臲鋴鋶韸飺蓼볾怀漂椄䐆栈笊氌洎砐缒簔挖怘䐚尜⬞ጠሢᄤᐦ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSDISABLEEMERGENCYCALLINDICATIONSCAPABLE);
					this.radWideLabtoolSuppressEmergencyCallCapability_A42143.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolSuppressEmergencyCallCapability_A42143.DataTransferOrder = -1;
					num = (short)1645412538;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_2865;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚軜뛞鏠蛢诤럦裨귪賬鯮郰鿲냴藶诸铺迼ꃾ䀀㨂㐄㌆㠈", a_)))
					{
						num = (short)996540618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1307;
				case 8:
					goto IL_1086;
				case 9:
					goto IL_AE4;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚黜냞迠郢諤详賨鿪駬諮볰鳲釴鋶闸뻺鏼黾挀漂怄堆䠈㰊㨌㸎∐", a_)))
					{
						num = (short)76349540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D93;
				case 11:
					goto IL_1669;
				case 12:
					goto IL_236B;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ껆ꛈ鳊꓌ꯎ듐鿒듔뗖귘듚닜돞믠賢诤苦ꫨ蟪苬臮铰냲铴蟶飸駺釼髾帀㜂㘄㔆㨈㌊", a_)))
					{
						num = (short)33358046;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2280;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藀闂韄铆鯈꫊ꏌ꣎듐雒귔ꏖ蛘퇠\udae2", a_)))
					{
						num = (short)1339424936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D24;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚鳜귞苠询賤釦賨맪裬軮闰ꏲ铴蓶諸賺鋼跾攀䘂欄昆欈朊栌倎倐␒℔№⬘", a_)))
					{
						num = (short)660340830;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F15;
				case 16:
					this.radWideLabtoolMaritimeRadioSoftware_A42191 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚郜뻞鏠諢釤軦蓨軪뿬軮闰髲髴ꓶ雸鷺觼裾怀焂怄堆䠈㼊㼌㸎⠐−", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSMARITIMERADIOSOFTWARE);
					this.radWideLabtoolMaritimeRadioSoftware_A42191.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolMaritimeRadioSoftware_A42191.DataTransferOrder = -1;
					num = (short)3080308;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_23B7;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胀꿂꧄꣆뻈鯊黌髎苐뛒뛔ꋖꯘ뻚苜틠\udbe2헤\udee6", a_)))
					{
						num = (short)617873454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_249F;
				case 19:
					goto IL_190A;
				case 20:
					this.radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("杻﯊﷌ￎ퇠폢헤ퟦ\ud9e8\udbea\uddec\udfee쇰쏲열쟶째쯺췼쿾", a_), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚駜뫞韠諢蛤苦ꓨ質胬鯮듰鷲致鋶诸诺迼雾爀昂刄渆漈戊丌怎甐瘒攔笖氘簚吜笞", a_), global::CommonResources.AcgResources.ID_DEVICEMGMTENTERPRISEWIFICODEPLUGID, 32);
					this.radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId.DataTransferOrder = -1;
					num = (short)82116774;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					goto IL_1FEC;
				case 22:
					this.pASSAlarmFilterCapable_A42387 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("釀苂雄铆裈ꟊ곌뷎볐闒볔믖귘뻚꿜鳞胠鏢蓤藦藨軪달껮연쇲웴쿶컸", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSPASSALARMFILTERCAPABLE);
					this.pASSAlarmFilterCapable_A42387.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.pASSAlarmFilterCapable_A42387.DataTransferOrder = -1;
					num = (short)202113209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					this.radWideLabtoolAPXSingletoneCapable_43080 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚鳜连맠냢賤触軨蟪裬鯮黰鷲郴듶飸诺鳼鷾洀昂娄㌆㨈㬊㔌㼎", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSAPXSINGLETONECAPABLE);
					this.radWideLabtoolAPXSingletoneCapable_43080.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolAPXSingletoneCapable_43080.DataTransferOrder = -1;
					num = (short)1943863437;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					this.trunkingRadioInhibited_A19483 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闀뇂냄꧆ꋈꋊꏌ꣎菐닒뇔뻖뛘鋚돜럞裠臢賤鏦賨迪달껮샰쫲쇴쿶쫸", a_), global::CommonResources.AcgResources.ID_TRUNKINGRADIOINHIBITED);
					this.trunkingRadioInhibited_A19483.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.trunkingRadioInhibited_A19483.DataTransferOrder = -1;
					num = (short)1663107081;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					this.radWideLabtoolRCLastJobSetUUID = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("杻﯊﷌ￎ퇠폢헤ퟦ\ud9e8\udbea\uddec\udfee쇰쏲열쟶째쯺췼쿾", a_), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚远鳞균苢雤鏦ꏨ蓪迬볮铰蟲ꃴꋶ냸뿺", a_), global::CommonResources.AcgResources.ID_RC_LASTJOBSET_UUID, 32);
					this.radWideLabtoolRCLastJobSetUUID.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolRCLastJobSetUUID.DataTransferOrder = -1;
					num = (short)540082269;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("﷈ﻊ﯌铔闖高鿚飜駞퇠틢ퟤ퓦\udde8\udeea\udbec\ud8ee짰쫲듴뗶뫸뿺룼맾㄀㈂㜄㐆㴈㸊㬌㠎⤐⨒吔唖娘弚堜夞ᄠሢᜤᐦᴨḪᬬᠮरਲ琴甶稸缺砼社", a_), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚駜뫞韠諢蛤苦ꓨ質胬鯮ꋰ雲铴髶闸黺軼賾吀猂愄昆紈渊弌戎䄐怒縔", a_), global::CommonResources.AcgResources.ID_DEVICEMGMTSEAMLESSUPDATERMPSK, 64);
					this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk.DataTransferOrder = -1;
					num = (short)21430332;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚鯜뻞闠苢觤ꋦ鯨駪苬鷮껰닲췴쟶죸컺", a_)))
					{
						num = (short)970653697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1086;
				case 28:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚鳜뇞胠迢諤胦뻨苪觬諮돰鋲鯴鏶뷸髺觼黾儀䀂䰄䔆怈缊刌㬎┐⬒ⴔ∖", a_)))
					{
						num = (short)73203760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_342F;
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚軜꫞釠鏢韤苦髨飪꣬苮铰臲鋴鋶韸飺蓼볾怀漂椄䐆栈笊氌洎砐缒簔挖怘䐚尜⬞ጠሢᄤᐦ", a_)))
					{
						num = (short)1324023813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DC2;
				case 30:
					goto IL_2AB1;
				case 31:
					this.c();
					num = (short)1371144294;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					this.radWideLabtoolFlipDisplayOption_A8140 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚鯜돞裠鏢ꇤ軦髨鯪臬軮裰볲藴菶郸铺鏼ꃾ䀀㬂㐄㌆㤈", a_), global::CommonResources.AcgResources.ID_FLIPDISPLAYOPTION);
					this.radWideLabtoolFlipDisplayOption_A8140.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolFlipDisplayOption_A8140.DataTransferOrder = -1;
					num = (short)173735955;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
					this.toneEmergencyConfigurableCapable_42083 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闀곂ꯄꋆ賈ꛊ꣌뷎뛐뛒믔듖ꃘ飚닜뇞蟠諢苤鋦鯨諪迬菮铰냲铴蟶飸駺釼髾帀㜂㜄㜆ㄈ㠊", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSEMERGENCYTONECONFIGURABILITY);
					this.toneEmergencyConfigurableCapable_42083.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.toneEmergencyConfigurableCapable_42083.DataTransferOrder = -1;
					num = (short)621871212;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚駜뛞鋠鏢觤蛦部뿪铬鿮铰곲듴샶쇸쏺쫼", a_)))
					{
						num = (short)1254424720;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_21E6;
				case 35:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚飜뇞苠釢鳤韦鷨믪賬鳮苰蓲髴藶鷸ꓺ볼쯾\u3000㔂㰄㈆", a_)))
					{
						num = (short)517996673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E2D;
				case 36:
					goto IL_14D9;
				case 37:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚蟜냞迠蛢뛤苦藨軪軬鯮黰臲뫴駶꫸賺铼课戀欂娄䘆㠈㈊㠌㨎ℐ", a_)))
					{
						num = (short)1670643815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8B8;
				case 38:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚鳜连맠헢헤ퟦ\ud9e8믪\udfec\udaeeꏰ鋲釴黶雸ꓺ볼쯾㌀㈂㜄㘆", a_)))
					{
						num = (short)1906638912;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2FA7;
				case 39:
					this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚補돞闠釢蓤ꯦ蛨鳪뷬胮蛰雲蟴ꓶ雸韺駼雾搀焂䠄昆樈䠊氌缎瀐焒礔爖䘘娚⤜⸞ᘠሢᔤ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSULTRALOWPOWER);
					this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710.DataTransferOrder = -1;
					num = (short)415367258;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 40:
					goto IL_94E;
				case 41:
					goto IL_24EC;
				case 42:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌諎볐뛒꟔냖볘뗚뻜ꛞ돠鯢뇤鿦꣨蟪裬鷮藰ꟲ髴駶鳸꣺飼课帀䈂㄄㘆㰈㬊㔌", a_)))
					{
						num = (short)1150746851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D8C;
				case 43:
					this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚駜뫞韠諢蛤苦ꓨ質胬鯮ꋰ雲铴髶闸黺軼賾吀猂愄昆紈渊弌戎䄐怒縔帖紘", a_), global::CommonResources.AcgResources.ID_DEVICEMGMTSEAMLESSUPDATERMPSKID, 0, 65535, null, null, 0, 1);
					this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.DataTransferOrder = -1;
					this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.ShowHexValue = false;
					num = (short)490537092;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 44:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚雜뫞飠鏢蓤菦뷨鋪鷬諮껰닲췴쓶컸짺", a_)))
					{
						num = (short)1036910660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A2A;
				case 45:
					this.radWideLabtoolDisableEncryption_43371 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚駜뛞鋠苢蟤详賨껪菬賮菰諲藴菶郸铺鏼ꃾ㔀。㘄〆㠈", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSDISABLEENCRYPTION);
					this.radWideLabtoolDisableEncryption_43371.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolDisableEncryption_43371.DataTransferOrder = -1;
					num = (short)176095268;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 46:
					this.g();
					num = (short)624951515;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 47:
					goto IL_FEB;
				case 48:
					this.a();
					num = (short)2123104312;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 49:
					this.radWideLabtoolDisplayContrastConfiguration_A7873 = new global::AcpBusinessLayer.AcpSimpleRangeField(69, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚駜뛞鋠鏢觤蛦部꣪苬臮藰臲铴蓶跸룺鋼釾最樂戄爆笈樊礌明縐紒䨔嘖⸘⌚⨜Ⱎ", a_), global::CommonResources.AcgResources.ID_DISPLAYCONTRASTCONFIGURATION, null, null, 0, 1);
					this.radWideLabtoolDisplayContrastConfiguration_A7873.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolDisplayContrastConfiguration_A7873.ShowHexValue = true;
					num = (short)565706758;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 50:
					goto IL_2234;
				case 51:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚鳜볞闠諢鏤苦ꓨ苪軬ꧮ黰臲럴ꏶ꧸꿺ꧼ볾怀猂搄攆攈渊刌㬎∐⌒—␖", a_)))
					{
						num = (short)1001717983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B3B;
				case 52:
					goto IL_21E6;
				case 53:
					goto IL_32CE;
				case 54:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚軜닞胠釢釤ꯦ蛨鳪꿬軮藰蟲郴藶胸꿺闼跾搀瀂洄栆攈漊刌与⌐⌒✔✖⠘", a_)))
					{
						num = (short)980811959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C4E;
				case 55:
					num = (short)1057947663;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 56:
					goto IL_280A;
				case 57:
					goto IL_2D24;
				case 58:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚鳜꫞藠諢諤ꋦ蟨菪賬臮鋰雲飴鋶韸迺ꋼ뻾㔀㄂㈄㐆㼈", a_)))
					{
						num = (short)836042866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_32CE;
				case 59:
					goto IL_1B3B;
				case 60:
					goto IL_11B7;
				case 61:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚駜ꛞ迠苢裤軦諨뇪苬臮铰냲铴闶闸黺ꋼ뻾㔀㈂㜄㈆ㄈ", a_)))
					{
						num = (short)2076377248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2037;
				case 62:
					this.manDownPersonalityConfigurableCapable_42082 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("賀ꋂꯄ菆ꛈ볊ꏌ鿎듐ꇒꛔ룖럘뫚뇜뛞闠髢ꛤ裦蟨跪蓬裮蓰臲铴闶闸黺뻼黾焀戂朄欆氈吊㤌㴎ℐ⬒✔", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSMANDOWNEMERGENCYPROFILECONFIGURABILITY);
					this.manDownPersonalityConfigurableCapable_42082.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.manDownPersonalityConfigurableCapable_42082.DataTransferOrder = -1;
					num = (short)1371275390;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 63:
					goto IL_22CE;
				case 64:
					this.radWideLabtoolAPX6000P25Radio_A42121 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚鳜连맠헢헤ퟦ\ud9e8믪\udfec\udaeeꏰ鋲釴黶雸ꓺ볼쯾㌀㈂㜄㘆", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSAPX6000P25RADIO);
					this.radWideLabtoolAPX6000P25Radio_A42121.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolAPX6000P25Radio_A42121.DataTransferOrder = -1;
					num = (short)1410924618;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 65:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚飜닞蓠釢苤苦蟨裪铬곮郰鿲駴룶韸韺蓼裾栀眂洄伆昈缊䀌明爐倒琔朖砘礚焜稞縠戢ᄤᐦᠨᴪἬ", a_)))
					{
						num = (short)659161198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_236B;
				case 66:
					goto IL_2D93;
				case 67:
					goto IL_16B5;
				case 68:
					this.radWideLabtoolKeypadType_A8372 = new global::AcpBusinessLayer.AcpListField(3, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚雜뫞飠鏢蓤菦뷨鋪鷬諮껰닲췴쓶컸짺", a_), global::CommonResources.AcgResources.ID_KEYPADTYPE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideLabtoolKeypadType_A8372LovStrs);
					this.radWideLabtoolKeypadType_A8372.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolKeypadType_A8372.DataTransferOrder = -1;
					num = (short)478216276;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 69:
					goto IL_30DD;
				case 70:
					goto IL_111B;
				case 71:
					goto IL_1EB8;
				case 72:
					this.radWideLabtoolSirenPaSystemLookup_A9143 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚軜뛞鏠蛢诤럦裨룪铬鳮藰雲飴믶雸铺雼諾焀専䐄㸆㠈㼊㸌", a_), global::CommonResources.AcgResources.ID_SIRENPASYSTEMLOOKUP);
					this.radWideLabtoolSirenPaSystemLookup_A9143.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					num = (short)534839468;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 73:
					this.radWideLabtoolEncryptedPINPassword_A41702 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("臂裈ﻊﻎ鋒ꗠ\udae2\udce4퓦\ud8e8\udbea\udcec꯮쓰샲쇴싶뫸뻺룼쳾䀀䄂䘄䄆䰈㸊㬌㬎⤐儒吔⸖⼘⸚嬜✞怠ሢጤ昦ᨨ渪欬氮爰Ĳ猴然ਸ଺฼社̀穂DɆੈ繊罌絎晐ᝒ浔ᅖ浘扚摜桞⁠♢⁤坦婨⩪奬婮䉰䙲䕴䅶㱸㵺㹼䩾", a_), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚飜뇞苠釢鳤韦鷨軪觬뿮룰뷲ꗴ零諸裺諼郾猀朂娄䘆㴈㨊㨌㼎⌐", a_), global::CommonResources.AcgResources.ID_ENCRYPTEDPINPASSWORD, 96);
					this.radWideLabtoolEncryptedPINPassword_A41702.IgnoreOnCompare = true;
					this.radWideLabtoolEncryptedPINPassword_A41702.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolEncryptedPINPassword_A41702.DataTransferOrder = -1;
					num = (short)709754930;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 74:
					goto IL_2FA7;
				case 75:
					goto IL_C4E;
				case 76:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚補곞蓠釢뛤苦藨軪軬鯮郰釲駴鋶꧸럺룼釾椀戂欄搆氈昊栌愎攐䰒℔␖⤘⠚Ⱌ", a_)))
					{
						num = (short)208666789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_22CE;
				case 77:
					this.radWideLabtoolAudibleBeaconRoutingCapable_A41974 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚鳜꫞藠諢蟤详賨ꧪ裬軮鋰鳲鯴ꗶ雸軺觼雾漀搂䘄昆礈樊漌挎琐䰒吔⌖⠘√⨜⬞", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSAUDIBLEEMERGENCYBEACONROUTINGCAPABLE);
					this.radWideLabtoolAudibleBeaconRoutingCapable_A41974.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolAudibleBeaconRoutingCapable_A41974.DataTransferOrder = -1;
					num = (short)479527073;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 78:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ껆ꛈ鳊꓌ꯎ듐黒體蓖高髚駜點ꋠꛢ훤ퟦ\ud9e8\udbea껬軮臰鋲韴黶闸鋺觼蛾帀䈂㄄㔆㸈㰊㼌", a_)))
					{
						num = (short)1702887541;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17A5;
				case 79:
					goto IL_815;
				case 80:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚飜뇞苠釢鳤韦鷨軪觬뿮룰뷲ꗴ零諸裺諼郾猀朂娄䘆㴈㨊㨌㼎⌐", a_)))
					{
						num = (short)959316041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2234;
				case 81:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚軜뛞鏠蛢诤럦裨룪铬鳮藰雲飴믶雸铺雼諾焀専䐄㸆㠈㼊㸌", a_)))
					{
						num = (short)1833435208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AFF;
				case 82:
					this.radWideLabtoolSeamlessUpdateOutOfBoxExperience = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚軜뫞胠転觤苦髨飪룬鿮闰鋲致鋶뛸軺觼냾最䄂樄缆䰈猊紌樎挐稒瀔礖稘縚", a_), global::CommonResources.AcgResources.ID_RADWIDELABTOOLSEAMLESSUPDATEOUTOFBOXEXPERIENCE);
					this.radWideLabtoolSeamlessUpdateOutOfBoxExperience.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolSeamlessUpdateOutOfBoxExperience.DataTransferOrder = -1;
					goto IL_12EA;
				case 83:
					this.radWideLabtoolPAAlertCapability_A42944 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚跜點ꃠ迢胤闦鷨꣪賬鿮郰釲鳴鯶郸迺蓼ꃾ䀀㜂㜄㸆㴈㼊", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSPERSONNELACCOUNTABILITYALERTCAPABLE);
					this.radWideLabtoolPAAlertCapability_A42944.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolPAAlertCapability_A42944.DataTransferOrder = -1;
					num = (short)1797718033;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 84:
					goto IL_1A2A;
				case 85:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚铜뇞闠蛢觤详胨質裬臮藰ꏲ蟴黶雸觺铼课砀倂昄昆月䠊氌缎瀐焒礔爖䘘⼚⸜⬞ဠሢ", a_)))
					{
						num = (short)1228406961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2452;
				case 86:
					goto IL_1039;
				case 87:
					this.emergencyHotAuxMicConfigurability_A42301 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蓀껂ꃄ뗆껈껊ꏌ곎꣐鯒뫔ꏖ飘껚ꗜ鋞裠胢ꛤ裦蟨跪蓬裮蓰臲铴闶郸韺铼课砀専䐄㌆㬈㠊㴌㸎", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSEMERGENCYHOTAUXMICCONFIGURABILITY);
					this.emergencyHotAuxMicConfigurability_A42301.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.emergencyHotAuxMicConfigurability_A42301.DataTransferOrder = -1;
					num = (short)1374683263;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 88:
					goto IL_1201;
				case 89:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚黜뫞鏠韢꣤胦蓨鿪ꃬ胮藰鳲蟴飶闸髺껼郾洀瘂焄渆昈攊縌弎娐娒䔔砖欘漚", a_)))
					{
						num = (short)309198939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_94E;
				case 90:
					goto IL_15C5;
				case 91:
					this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort = new global::AcpBusinessLayer.AcpSimpleRangeField(49682, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚黜뫞鏠韢꣤胦蓨鿪ꃬ胮藰鳲蟴飶闸髺껼郾洀瘂焄渆昈攊縌弎娐娒䔔砖欘漚", a_), global::CommonResources.AcgResources.ID_CERTMGMTMOTOROLASOLUTIONSPKIPORT, 0, 65535, null, null, 0, 1);
					this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.DataTransferOrder = -1;
					this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.ShowHexValue = false;
					num = (short)1054212136;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 92:
					this.radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("ꃀ돂계믈꫊꧌ꛎ뻐냒냔맖귘꧚볜돞쿠転諤鏦蛨駪苬菮郰胲髴鯶賸迺铼郾漀瀂⬄搆昈昊", a_), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚駜뫞韠諢蛤苦ꓨ質胬鯮ꋰ雲铴髶闸黺軼賾吀猂愄昆紈渊䨌渎攐瘒戔瘖怘匚爜氞唠䴢䐤䨦䰨", a_), global::CommonResources.AcgResources.ID_DEVICEMGMTSEAMLESSUPDATEGATEWAYHOSTNAME, 64);
					this.radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname.DataTransferOrder = -1;
					num = (short)2124480623;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 93:
					goto IL_2FF6;
				case 94:
					this.radWideLabtoolArchiveReadPasswordEnable_A7462 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚鳜귞苠询賤釦賨맪裬軮闰ꏲ铴蓶諸賺鋼跾攀䘂欄昆欈朊栌倎倐␒℔№⬘", a_), global::CommonResources.AcgResources.ID_ARCHIVEREADPASSWORDENABLE);
					this.radWideLabtoolArchiveReadPasswordEnable_A7462.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolArchiveReadPasswordEnable_A7462.DataTransferOrder = -1;
					num = (short)1016660120;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 95:
					this.radWideLabtoolRadioWritePasswordEnable_A8889 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚远뻞藠諢諤냦鯨苪駬諮ꇰ鋲蛴蓶軸铺迼鯾䐀洂搄攆攈渊刌与⤐⬒ⴔ⸖", a_), global::CommonResources.AcgResources.ID_RADIOWRITEPASSWORDENABLE);
					this.radWideLabtoolRadioWritePasswordEnable_A8889.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolRadioWritePasswordEnable_A8889.DataTransferOrder = -1;
					num = (short)1213792446;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 96:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ껆ꛈ鳊꓌ꯎ듐韒菔藖諘迚꿜꫞迠裢賤触軨룪駬軮藰蛲蛴듶飸诺鳼鷾栀漂氄猆瀈吊䰌㬎⌐␒∔┖", a_)))
					{
						num = (short)956235874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D74;
				case 97:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚駜뫞韠諢蛤苦ꓨ質胬鯮ꋰ雲铴髶闸黺軼賾吀猂愄昆紈渊弌戎䄐怒縔", a_)))
					{
						num = (short)2024079386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11B7;
				case 98:
					this.radioWideDVRSTrunkingStatusCapability_A42772 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ껆ꛈ鳊꓌ꯎ듐韒菔藖諘迚꿜꫞迠裢賤触軨룪駬軮藰蛲蛴듶飸诺鳼鷾栀漂氄猆瀈吊䰌㬎⌐␒∔┖", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSDVRSTRUNKINGSTATUSCAPABILITY);
					this.radioWideDVRSTrunkingStatusCapability_A42772.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radioWideDVRSTrunkingStatusCapability_A42772.DataTransferOrder = -1;
					num = (short)288620653;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 99:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賀苂韄釆賈蟊臌郎闐鷒藔裖탠", a_)))
					{
						num = (short)434831588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_29C1;
				case 100:
					this.radWideLabtoolConsoletteModelEnable_A7713 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚黜냞迠郢諤详賨鿪駬諮볰鳲釴鋶闸뻺鏼黾挀漂怄堆䠈㰊㨌㸎∐", a_), global::CommonResources.AcgResources.ID_CONSOLETTEMODEL);
					this.radWideLabtoolConsoletteModelEnable_A7713.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolConsoletteModelEnable_A7713.DataTransferOrder = -1;
					num = (short)747176002;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 101:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀蛂评飆跈苊諌蛎藐賒蟔鯖蛘诚軜裞ꗠ볢蛤蛦駨諪迬菮铰곲쇴쓶컸쫺쳼", a_)))
					{
						num = (short)286130298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_231D;
				case 102:
					goto IL_740;
				case 103:
					this.radWideLabtoolZoneSelectorOnSwitch_A19550 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚蟜냞迠蛢뛤苦藨軪軬鯮黰臲뫴駶꫸賺铼课戀欂娄䘆㠈㈊㠌㨎ℐ", a_), global::CommonResources.AcgResources.ID_ZONESELECTORONSWITCH);
					this.radWideLabtoolZoneSelectorOnSwitch_A19550.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolZoneSelectorOnSwitch_A19550.DataTransferOrder = -1;
					num = (short)728760535;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 104:
					goto IL_231D;
				case 105:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚远鳞균苢雤鏦ꏨ蓪迬볮铰蟲ꃴꋶ냸뿺", a_)))
					{
						num = (short)202637337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2FF6;
				case 106:
					goto IL_6F3;
				case 107:
					goto IL_274A;
				case 108:
					goto IL_78D;
				case 109:
					goto IL_1D74;
				case 110:
					this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚飜닞蓠釢苤苦蟨裪铬곮郰鿲駴룶韸韺蓼裾栀眂洄伆昈缊䀌明爐倒琔朖砘礚焜稞縠戢ᄤᐦᠨᴪἬ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSEMERGENCYCALLONLYWITHHOTMICCAPABLE);
					this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.DataTransferOrder = -1;
					num = (short)552206348;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 111:
					goto IL_1F50;
				case 112:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ껆ꛈ鳊꓌ꯎ듐臒냔ꛖ鿘賚诜뫞鏠郢賤裦蟨듪곬\udbee쏰쯲싴엶", a_)))
					{
						num = (short)1152778437;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_111B;
				case 113:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚軜뛞鏠蛢诤ꛦ蟨迪ꇬ蛮雰鯲致蓶닸黺蓼迾怀朂䀄椆栈椊愌樎丐划℔☖ⴘ⨚⸜", a_)))
					{
						num = (short)1369702573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_274A;
				case 114:
					this.radWideLabtoolAudioEnhancement_A42736 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚鳜꫞藠諢諤ꋦ蟨菪賬臮鋰雲飴鋶韸迺ꋼ뻾㔀㄂㈄㐆㼈", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSAUDIOENHANCEMENT);
					this.radWideLabtoolAudioEnhancement_A42736.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolAudioEnhancement_A42736.DataTransferOrder = -1;
					num = (short)158597173;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 115:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚黜냞迠韢韤裦藨ꏪ裬軮闰ꃲ郴鯶鳸飺觼雾渀洂娄䘆㸈㰊㼌㰎", a_)))
					{
						num = (short)1001390290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_24EC;
				case 116:
					goto IL_1702;
				case 117:
					this.radioWideMOSCADACE3000Capability_A42772 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ껆ꛈ鳊꓌ꯎ듐黒體蓖高髚駜點ꋠꛢ훤ퟦ\ud9e8\udbea껬軮臰鋲韴黶闸鋺觼蛾帀䈂㄄㔆㸈㰊㼌", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSMOSCADACE3600CAPABLE);
					this.radioWideMOSCADACE3000Capability_A42772.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radioWideMOSCADACE3000Capability_A42772.DataTransferOrder = -1;
					num = (short)1265303719;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 118:
					num = (short)1797259476;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 119:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚飜뻞鏠迢鳤냦裨駪菬蛮鿰铲럴零跸迺飼跾砀圂洄甆氈砊攌怎紐眒䨔嘖⬘⠚␜⠞ᘠ", a_)))
					{
						num = (short)1423179916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_30DD;
				case 120:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚駜ꛞ迠苢裤軦諨뇪苬臮铰ꃲ雴零韸룺鳼迾怀愂氄欆怈缊琌倎┐ℒ∔⌖‘", a_)))
					{
						num = (short)1877082255;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_440;
				case 121:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚駜뫞韠諢蛤苦ꓨ質胬鯮ꋰ雲铴髶闸黺軼賾吀猂愄昆紈渊弌戎䄐怒縔帖紘", a_)))
					{
						num = (short)1810366507;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B32;
				case 122:
					this.tEN_DIGIT_RL_PSWD_capable_43711 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闀蛂评飆跈苊諌蛎藐賒蟔鯖蛘诚軜裞ꗠ볢蛤蛦駨諪迬菮铰곲쇴쓶컸쫺쳼", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSRADIOLOCKPASSWORDEXTENSIONCAPABLE);
					this.tEN_DIGIT_RL_PSWD_capable_43711.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.tEN_DIGIT_RL_PSWD_capable_43711.DataTransferOrder = -1;
					num = (short)1378812008;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 123:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚駜뛞鋠鏢觤蛦部꣪苬臮藰臲铴蓶跸룺鋼釾最樂戄爆笈樊礌明縐紒䨔嘖⸘⌚⨜Ⱎ", a_)))
					{
						num = (short)315293745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2865;
				case 124:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚鳜鯞뇠ꓢ蓤鏦胨藪諬뿮닰뫲럴黶跸ꓺ짼쯾㤀㈂㘄", a_)))
					{
						num = (short)1944125471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_740;
				case 125:
					goto IL_2E56;
				case 126:
					goto IL_157A;
				case 127:
					goto IL_2607;
				case 128:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓀껂ꃄ뗆껈껊ꏌ곎꣐鯒뫔ꏖ飘껚ꗜ鋞裠胢ꛤ裦蟨跪蓬裮蓰臲铴闶郸韺铼课砀専䐄㌆㬈㠊㴌㸎", a_)))
					{
						num = (short)1989083223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2607;
				case 129:
					this.radWideLabtoolEncryptPassword_A41695 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚飜뇞苠釢鳤韦鷨믪賬鳮苰蓲髴藶鷸ꓺ볼쯾\u3000㔂㰄㈆", a_), global::CommonResources.AcgResources.ID_ENCRYPTPASSWORD);
					this.radWideLabtoolEncryptPassword_A41695.IgnoreOnCompare = true;
					this.radWideLabtoolEncryptPassword_A41695.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolEncryptPassword_A41695.DataTransferOrder = -1;
					num = (short)752484548;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 130:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚駜뫞韠諢蛤苦ꓨ質胬鯮ꋰ雲铴髶闸黺軼賾吀猂愄昆紈渊䨌渎攐瘒戔瘖怘匚爜氞唠䴢䐤䨦䰨", a_)))
					{
						num = (short)561905756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F50;
				case 131:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚黜냞迠韢韤裦藨ꏪ裬軮闰냲髴駶鿸鋺髼諾猀戂焄渆昈攊刌与☐␒✔┖", a_)))
					{
						num = (short)1903493290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19DC;
				case 132:
					goto IL_B32;
				case 133:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚远뫞胠蟢다闦胨鿪裬맮黰髲雴鋶뿸鋺釼髾爀専䐄㼆ㄈ㈊㸌", a_)))
					{
						num = (short)288489630;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F04;
				case 134:
				{
					num = (short)1987051520;
					short num3 = num;
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚鯜귞蓠蛢럤苦鿨蓪臬駮飰鷲鋴ꗶ雸迺鳼跾砀専䐄㼆㠈㼊㨌", a_)))
					{
						num = (short)1105395938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3090;
				}
				case 135:
					this.radWideLabtoolEnhancedARS_A43084 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚飜뇞觠苢诤蓦賨迪곬뷮ꋰ곲듴쏶쫸쯺염쯾", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSENHANCEDARS);
					this.radWideLabtoolEnhancedARS_A43084.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolEnhancedARS_A43084.DataTransferOrder = -1;
					num = (short)1020854466;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 136:
					goto IL_1F04;
				case 137:
					this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚釜뛞賠諢釤苦跨ꋪ뻬볮룰럲ꏴꗶ꫸듺跼髾猀戂焄渆昈攊丌渎愐爒眔笖簘䐚⤜Ⱎᄠᜢဤ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSLIMITEDISSIDVRSOPERATIONCAPABLE);
					this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045.DataTransferOrder = -1;
					num = (short)751108244;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 138:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚远뻞藠諢諤럦裨飪黬飮黰臲釴ꣶ룸쏺염쳾㘀", a_)))
					{
						num = (short)1794441355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1464;
				case 139:
					this.radWideLabtoolRadioPassword_A8837 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚远뻞藠諢諤럦裨飪黬飮黰臲釴ꣶ룸쏺염쳾㘀", a_), global::CommonResources.AcgResources.ID_READWRITEPASSWORD, 32);
					this.radWideLabtoolRadioPassword_A8837.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolRadioPassword_A8837.DataTransferOrder = -1;
					num = (short)1450639589;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 140:
					this.radWideLabtoolEarlyWarningBatteryThreshold_A23977 = new global::AcpBusinessLayer.AcpSimpleRangeField(15, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚飜뻞鏠迢鳤냦裨駪菬蛮鿰铲럴零跸迺飼跾砀圂洄甆氈砊攌怎紐眒䨔嘖⬘⠚␜⠞ᘠ", a_), global::CommonResources.AcgResources.ID_EARLYWARNINGBATTERYTHRESHOLD, null, null, 0, 1);
					this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.DataTransferOrder = -1;
					this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.ShowHexValue = false;
					num = (short)1857945669;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 141:
					goto IL_2405;
				case 142:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚軜뫞胠転觤苦髨飪룬鿮闰鋲致鋶뛸軺觼냾最䄂樄缆䰈猊紌樎挐稒瀔礖稘縚", a_)))
					{
						num = (short)594739282;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6F3;
				case 143:
					this.radWideLabtoolDynamicZoneScanCapability_42749 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚駜ꛞ迠苢裤軦諨뇪苬臮铰ꃲ雴零韸룺鳼迾怀愂氄欆怈缊琌倎┐ℒ∔⌖‘", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSDYNAMICZONESCANCAPABILITY);
					this.radWideLabtoolDynamicZoneScanCapability_42749.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolDynamicZoneScanCapability_42749.DataTransferOrder = -1;
					num = (short)1585840339;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 144:
					this.radWideLabtoolDisplayType_A7887 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadWideLabtoolDisplayType_A7887LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadWideLabtoolDisplayType_A7887LovStrs), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚駜뛞鋠鏢觤蛦部뿪铬鿮铰곲듴샶쇸쏺쫼", a_), global::CommonResources.AcgResources.ID_DISPLAYTYPE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideLabtoolDisplayType_A7887LovStrs);
					this.radWideLabtoolDisplayType_A7887.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolDisplayType_A7887.DataTransferOrder = -1;
					num = (short)821559348;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 145:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚黜뫞鏠韢꣤胦蓨鿪ꃬ胮藰鳲蟴飶闸髺껼郾洀瘂焄渆昈攊縌弎娐娒崔砖樘漚猜縞䰠䘢", a_)))
					{
						num = (short)347144399;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E56;
				case 146:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚鳜꫞藠諢蟤详賨ꧪ裬軮鋰鳲鯴ꗶ雸軺觼雾漀搂䘄昆礈樊漌挎琐䰒吔⌖⠘√⨜⬞", a_)))
					{
						num = (short)658243661;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2653;
				case 147:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚鳜连맠냢賤触軨蟪裬鯮黰鷲郴듶飸诺鳼鷾洀昂娄㌆㨈㬊㔌㼎", a_)))
					{
						num = (short)395378711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2405;
				case 148:
					goto IL_1F9E;
				case 149:
					this.f();
					num = (short)410779678;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 150:
					this.radWideLabtoolSirenPaOnly_A9142 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚軜뛞鏠蛢诤럦裨ꓪ菬菮裰곲듴컶죸쿺쿼", a_), global::CommonResources.AcgResources.ID_SIRENPAONLY);
					this.radWideLabtoolSirenPaOnly_A9142.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					num = (short)195952719;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 151:
					this.radWideLabtoolEmergencyRevertCapable_A41918 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚飜닞蓠釢苤苦蟨裪铬뷮铰藲郴藶跸룺鳼迾怀愂椄戆嘈䨊㤌㸎⠐−ⴔ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSMULTIPLEEMERGENCYREVERTCAPABLE);
					this.radWideLabtoolEmergencyRevertCapable_A41918.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolEmergencyRevertCapable_A41918.DataTransferOrder = -1;
					num = (short)180879523;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 152:
					goto IL_F15;
				case 153:
					this.b();
					num = (short)712179716;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 154:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚駜뫞韠諢蛤苦ꓨ質胬鯮듰鷲致鋶诸诺迼雾爀昂刄渆漈戊丌怎甐瘒攔笖氘簚吜笞", a_)))
					{
						num = (short)1921187860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E7B;
				case 155:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚郜뻞鏠諢釤軦蓨軪뿬軮闰髲髴ꓶ雸鷺觼裾怀焂怄堆䠈㼊㼌㸎⠐−", a_)))
					{
						num = (short)2056388624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1702;
				case 156:
					num = (short)620560385;
					if (num != 0)
					{
					}
					this.radWideLabtoolRadioReadPasswordEnable_A8869 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚远뻞藠諢諤뗦賨諪觬뿮郰胲蛴胶雸觺駼뫾漀戂朄欆氈吊䰌㜎⤐┒Ⱄ", a_), global::CommonResources.AcgResources.ID_RADIOREADPASSWORDENABLE);
					this.radWideLabtoolRadioReadPasswordEnable_A8869.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolRadioReadPasswordEnable_A8869.DataTransferOrder = -1;
					num = (short)158072879;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 157:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂냄꧆ꋈꋊꏌ꣎菐닒뇔뻖뛘鋚돜럞裠臢賤鏦賨迪달껮샰쫲쇴쿶쫸", a_)))
					{
						num = (short)187957272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AE4;
				case 158:
					this.radWideLabtoolReadWriteVoiceFiles_A8893 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚远뫞胠蟢다闦胨鿪裬맮黰髲雴鋶뿸鋺釼髾爀専䐄㼆ㄈ㈊㸌", a_), global::CommonResources.AcgResources.ID_READWRITEVOICEFILES);
					this.radWideLabtoolReadWriteVoiceFiles_A8893.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolReadWriteVoiceFiles_A8893.DataTransferOrder = -1;
					num = (short)29229192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 159:
					goto IL_2280;
				case 160:
					this.radWideLabtoolDynamicZoneCable_A41258 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚駜ꛞ迠苢裤軦諨뇪苬臮铰냲铴闶闸黺ꋼ뻾㔀㈂㜄㈆ㄈ", a_), global::CommonResources.AcgResources.ID_DYNAMICZONECAPABLE);
					this.radWideLabtoolDynamicZoneCable_A41258.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolDynamicZoneCable_A41258.DataTransferOrder = -1;
					num = (short)439222446;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 161:
					goto IL_2653;
				case 162:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚鯜돞裠鏢ꇤ軦髨鯪臬軮裰볲藴菶郸铺鏼ꃾ䀀㬂㐄㌆㤈", a_)))
					{
						num = (short)1177092128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_190A;
				case 163:
					goto IL_9ED;
				case 164:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚軜꫞釠鏢諤闦鷨ꓪ\udeec곮黰鷲致藶雸韺뗼髾怀朂唄䐆䀈䤊搌笎丐✒℔⼖℘⼚", a_)))
					{
						num = (short)1537999001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3281;
				case 165:
					this.radWideLabtoolUserSelectablePLEnhancement_43031 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚補곞蓠釢뛤苦藨軪軬鯮郰釲駴鋶꧸럺룼釾椀戂欄搆氈昊栌愎攐䰒℔␖⤘⠚Ⱌ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSUSERSELECTABLEPLENHANCEMENT);
					this.radWideLabtoolUserSelectablePLEnhancement_43031.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolUserSelectablePLEnhancement_43031.DataTransferOrder = -1;
					num = (short)449118271;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 166:
					goto IL_E7B;
				case 167:
					goto IL_17A5;
				case 168:
					this.e();
					num = (short)1176895545;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 169:
					this.radWideLabtoolMFKEmergencyAccess_A42216 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚郜駞ꫠꛢ裤苦鯨質裬臮鋰諲듴银髸黺軼賾帀䈂㄄㔆㬈㨊㬌", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSMFKEMERGENCYACCESS);
					this.radWideLabtoolMFKEmergencyAccess_A42216.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolMFKEmergencyAccess_A42216.DataTransferOrder = -1;
					num = (short)870187079;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 170:
					this.radWideLabtoolControlHeadConfiguration_A7722 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚黜냞迠韢韤裦藨ꏪ裬軮闰냲髴駶鿸鋺髼諾猀戂焄渆昈攊刌与☐␒✔┖", a_), global::CommonResources.AcgResources.ID_CONTROLHEADCONFIGURATION);
					this.radWideLabtoolControlHeadConfiguration_A7722.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					num = (short)7274675;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 171:
					this.h();
					num = (short)672727107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 172:
					goto IL_2AFF;
				case 173:
					this.radWideLabtoolSirenAndLightsKeypadEnable_A41413 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚軜뛞鏠蛢诤ꛦ蟨迪ꇬ蛮雰鯲致蓶닸黺蓼迾怀朂䀄椆栈椊愌樎丐划℔☖ⴘ⨚⸜", a_), global::CommonResources.AcgResources.ID_SIRENANDLIGHTSKEYPADENABLE);
					this.radWideLabtoolSirenAndLightsKeypadEnable_A41413.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolSirenAndLightsKeypadEnable_A41413.DataTransferOrder = -1;
					num = (short)1507065963;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 174:
					goto IL_2037;
				case 175:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚鳜连맠꟢郤蛦藨ꃪ菬胮鏰胲ꫴ뛶췸짺주쳾㘀", a_)))
					{
						num = (short)1911161035;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1669;
				case 176:
					this.radWideLabtoolChannelSelectorOnSwitch_A19551 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚黜럞胠跢诤苦藨룪裬菮铰郲致飶诸듺鏼곾瘀樂焄搆愈吊䰌㸎⠐☒—☖", a_), global::CommonResources.AcgResources.ID_CHANNELSELECTORONSWITCH);
					this.radWideLabtoolChannelSelectorOnSwitch_A19551.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolChannelSelectorOnSwitch_A19551.DataTransferOrder = -1;
					num = (short)1131086008;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 177:
					this.radWideLabtoolIntelligentPriorityScanCapable_43411 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚铜뇞闠蛢觤详胨質裬臮藰ꏲ蟴黶雸觺铼课砀倂昄昆月䠊氌缎瀐焒礔爖䘘⼚⸜⬞ဠሢ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSINTELLIGENTPRIORITYSCANCAPABLE);
					this.radWideLabtoolIntelligentPriorityScanCapable_43411.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolIntelligentPriorityScanCapable_43411.DataTransferOrder = -1;
					num = (short)1060241613;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 178:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚黜냞迠郢諤详胨迪賬鯮铰韲듴银跸鋺鋼釾䐀洂洄昆月栊栌戎琐紒愔䠖堘⼚⸜⼞ሠᔢ", a_)))
					{
						num = (short)1836515559;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FEC;
				case 179:
					goto IL_19DC;
				case 180:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚軜뛞鏠蛢诤럦裨ꓪ菬菮裰곲듴컶죸쿺쿼", a_)))
					{
						num = (short)1060438166;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_815;
				case 181:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("铀胂规蓆ꛈꗊ만껎닐꟒ꛔ鯖냘뛚드ꯞ胠韢賤裦蟨껪菬蟮郰鷲雴鋶铸黺鏼课帀㜂㘄㼆㠈㨊", a_)))
					{
						num = (short)1031798933;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AB1;
				case 182:
					goto IL_3090;
				case 183:
					this.radWideLabtoolSmartLowBatteryThreshold_A20201 = new global::AcpBusinessLayer.AcpRangeField<int, string>(10, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚軜닞胠釢釤ꯦ蛨鳪꿬軮藰蟲郴藶胸꿺闼跾搀瀂洄栆攈漊刌与⌐⌒✔✖⠘", a_), global::CommonResources.AcgResources.ID_SMARTLOWBATTERYTHRESHOLD);
					this.radWideLabtoolSmartLowBatteryThreshold_A20201.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolSmartLowBatteryThreshold_A20201.DataTransferOrder = -1;
					this.radWideLabtoolSmartLowBatteryThreshold_A20201.ShowHexValue = false;
					num = (short)702087243;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 184:
					goto IL_1169;
				case 185:
					goto IL_3186;
				case 186:
					goto IL_1DC2;
				case 187:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀鏂雄蓆꣈믊곌귎뷐뛒諔雖폠", a_)))
					{
						num = (short)771424448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A63;
				case 188:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚飜닞蓠釢苤苦蟨裪铬뷮铰藲郴藶跸룺鳼迾怀愂椄戆嘈䨊㤌㸎⠐−ⴔ", a_)))
					{
						num = (short)1937506455;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9ED;
				case 189:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚釜뛞賠諢釤苦跨ꋪ뻬볮룰럲ꏴꗶ꫸듺跼髾猀戂焄渆昈攊丌渎愐爒眔笖簘䐚⤜Ⱎᄠᜢဤ", a_)))
					{
						num = (short)1612578953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F9E;
				case 190:
					goto IL_EC9;
				case 191:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚郜駞ꫠꛢ裤苦鯨質裬臮鋰諲듴银髸黺軼賾帀䈂㄄㔆㬈㨊㬌", a_)))
					{
						num = (short)1364263081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1EB8;
				case 192:
					this.tPSCapable_A42312 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闀鏂雄蓆꣈믊곌귎뷐뛒諔雖폠", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSAUDIBLEEMERGENCYBEACONCAPABLEFORMOBILE);
					this.tPSCapable_A42312.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.tPSCapable_A42312.DataTransferOrder = -1;
					num = (short)1422000334;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 193:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚跜點ꃠ迢胤闦鷨꣪賬鿮郰釲鳴鯶郸迺蓼ꃾ䀀㜂㜄㸆㴈㼊", a_)))
					{
						num = (short)998965331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_23B7;
				case 194:
					goto IL_3F3;
				case 195:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚補돞闠釢蓤ꯦ蛨鳪뷬胮蛰雲蟴ꓶ雸韺駼雾搀焂䠄昆樈䠊氌缎瀐焒礔爖䘘娚⤜⸞ᘠሢᔤ", a_)))
					{
						num = (short)953810983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15C5;
				case 196:
					goto IL_E2D;
				case 197:
					this.radioWideReqFWVersion_A42872 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ껆ꛈ鳊꓌ꯎ듐臒냔ꛖ鿘賚诜뫞鏠郢賤裦蟨듪곬\udbee쏰쯲싴엶", a_), global::CommonResources.AcgResources.ID_REQUIREDFIRMWAREVERSION, 10);
					this.radioWideReqFWVersion_A42872.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radioWideReqFWVersion_A42872.DataTransferOrder = -1;
					num = (short)914358342;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 198:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚飜뇞觠苢诤蓦賨迪곬뷮ꋰ곲듴쏶쫸쯺염쯾", a_)))
					{
						num = (short)1753415815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3F3;
				case 199:
					goto IL_D8C;
				case 200:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀곂ꯄꋆ賈ꛊ꣌뷎뛐뛒믔듖ꃘ飚닜뇞蟠諢苤鋦鯨諪迬菮铰냲铴蟶飸駺釼髾帀㜂㜄㜆ㄈ㠊", a_)))
					{
						num = (short)2111897633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_78D;
				case 201:
					goto IL_1BDD;
				case 202:
					this.radWideLabtoolSirenPaFatalError_A9141 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚軜뛞鏠蛢诤럦裨귪賬鯮郰鿲냴藶诸铺迼ꃾ䀀㨂㐄㌆㠈", a_), global::CommonResources.AcgResources.ID_SIRENPAFATALERROR);
					this.radWideLabtoolSirenPaFatalError_A9141.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					num = (short)1808072913;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 203:
					this.radWideLabtoolAPXDualKnobs_A42537 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚鳜连맠꟢郤蛦藨ꃪ菬胮鏰胲ꫴ뛶췸짺주쳾㘀", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSAPX2KNOBCONTROL);
					this.radWideLabtoolAPXDualKnobs_A42537.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolAPXDualKnobs_A42537.DataTransferOrder = -1;
					num = (short)789446667;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 204:
					this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ껆ꛈ鳊꓌ꯎ듐鿒듔뗖귘듚닜돞ꗠ諢雤蛦诨蟪裬룮飰鷲釴맶雸鋺軼髾匀昂愄爆樈缊搌怎缐弒瀔愖簘眚嬜瀞匠戢䘤䐦䰨堪帬䀮䌰娲倴䐶昸༺฼ਾ畀筂", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSDISABLEWINDNOISEREDUCTIONLEVELFORACCESSORIES);
					this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.DataTransferOrder = -1;
					num = (short)1999503446;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 205:
					goto IL_2452;
				case 206:
					goto IL_2A63;
				case 207:
					this.radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("ꗀꛂ도껆꫈껊껌꫎ꏐ꟒룔냖듘꿚닞軠韢雤裦藨鯪蛬蛮\udff0郲髴髶", a_), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚黜뫞鏠韢꣤胦蓨鿪ꃬ胮藰鳲蟴飶闸髺껼郾洀瘂焄渆昈攊縌弎娐娒崔砖樘漚猜縞䰠䘢", a_), global::CommonResources.AcgResources.ID_CERTMGMTMOTOROLASOLUTIONSPKIHOSTNAME, 64);
					this.radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname.DataTransferOrder = -1;
					num = (short)1683685501;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 208:
					switch (0)
					{
					case 0:
						goto IL_3CD;
					}
					continue;
				case 209:
					goto IL_1307;
				case 210:
					this.radWideLabtoolControlHeadSelection_A7723 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚黜냞迠韢韤裦藨ꏪ裬軮闰ꃲ郴鯶鳸飺觼雾渀洂娄䘆㸈㰊㼌㰎", a_), global::CommonResources.AcgResources.ID_CONTROLHEADSELECTION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideLabtoolControlHeadSelection_A7723LovStrs);
					this.radWideLabtoolControlHeadSelection_A7723.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					num = (short)345374761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 211:
					goto IL_440;
				case 212:
					if (producerFields != null)
					{
						num = (short)377946167;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_342F;
				case 213:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌鷎냐럒볔룖鋘닚뇜돞蓠蟢뫤ꛦ\udde8\udaea\ud8ec\udaee죰", a_)))
					{
						num = (short)252903638;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BDD;
				case 214:
					this.radWideRadioKilled_A41559 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌鷎냐럒볔룖鋘닚뇜돞蓠蟢뫤ꛦ\udde8\udaea\ud8ec\udaee죰", a_), global::CommonResources.AcgResources.ID_RADIOKILLED);
					this.radWideRadioKilled_A41559.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideRadioKilled_A41559.DataTransferOrder = -1;
					num = (short)1876426953;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 215:
					goto IL_8B8;
				case 216:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ껆ꛈ鳊꓌ꯎ듐鿒듔뗖귘듚닜돞ꗠ諢雤蛦诨蟪裬룮飰鷲釴맶雸鋺軼髾匀昂愄爆樈缊搌怎缐弒瀔愖簘眚嬜瀞匠戢䘤䐦䰨堪帬䀮䌰娲倴䐶昸༺฼ਾ畀筂", a_)))
					{
						num = (short)968884428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1039;
				case 217:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賀ꋂꯄ菆ꛈ볊ꏌ鿎듐ꇒꛔ룖럘뫚뇜뛞闠髢ꛤ裦蟨跪蓬裮蓰臲铴闶闸黺뻼黾焀戂朄欆氈吊㤌㴎ℐ⬒✔", a_)))
					{
						num = (short)1482489918;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_157A;
				case 218:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ껆ꛈ鳊꓌ꯎ듐鿒듔뗖귘듚닜돞ꓠ転胤闦軨軪菬賮裰냲铴鯶闸꿺飼跾氀樂欄昆紈戊戌愎丐✒☔␖ⴘ⌚", a_)))
					{
						num = (short)1918828774;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1201;
				case 219:
				{
					num = (short)422327683;
					short num4 = num;
					num = (short)841102723;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12EA;
					default:
						num = (short)347078656;
						if (num != 0)
						{
						}
						goto IL_249F;
					}
					break;
				}
				case 220:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ껆ꛈ鳊꓌ꯎ듐鿒듔뗖귘듚닜돞ꓠ鯢釤苦蟨迪裬诮ꇰ뿲ꇴ飶韸黺껼髾甀専㄄㐆㸈㴊㐌", a_)))
					{
						num = (short)968687787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16B5;
				case 221:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚远뻞藠諢諤냦鯨苪駬諮ꇰ鋲蛴蓶軸铺迼鯾䐀洂搄攆攈渊刌与⤐⬒ⴔ⸖", a_)))
					{
						num = (short)1310785631;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EC9;
				case 222:
					this.radioWideLabtoolZoneCloneCapable_43238 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ껆ꛈ鳊꓌ꯎ듐鿒듔뗖귘듚닜돞믠賢诤苦ꫨ蟪苬臮铰냲铴蟶飸駺釼髾帀㜂㘄㔆㨈㌊", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSZONECLONECAPABLE);
					this.radioWideLabtoolZoneCloneCapable_43238.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radioWideLabtoolZoneCloneCapable_43238.DataTransferOrder = -1;
					num = (short)1998979231;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 223:
					this.radWideLabtoolActiveMicForBTPTTCapable_43053 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚鳜볞闠諢鏤苦ꓨ苪軬ꧮ黰臲럴ꏶ꧸꿺ꧼ볾怀猂搄攆攈渊刌㬎∐⌒—␖", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSACTIVEMICFORBLUETOOTHPTTCAPABLE);
					this.radWideLabtoolActiveMicForBTPTTCapable_43053.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolActiveMicForBTPTTCapable_43053.DataTransferOrder = -1;
					num = (short)109641787;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 224:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚駜뛞鋠苢蟤详賨껪菬賮菰諲藴菶郸铺鏼ꃾ㔀。㘄〆㠈", a_)))
					{
						num = (short)10158125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14D9;
				case 225:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚黜럞胠跢诤苦藨룪裬菮铰郲致飶诸듺鏼곾瘀樂焄搆愈吊䰌㸎⠐☒—☖", a_)))
					{
						num = (short)339673264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1169;
				case 226:
					this.radWideLabtoolFreeRevolvingRotary_A8147 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚鯜귞蓠蛢럤苦鿨蓪臬駮飰鷲鋴ꗶ雸迺鳼跾砀専䐄㼆㠈㼊㨌", a_), global::CommonResources.AcgResources.ID_FREEREVOLVINGROTARY);
					this.radWideLabtoolFreeRevolvingRotary_A8147.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolFreeRevolvingRotary_A8147.DataTransferOrder = -1;
					num = (short)626131126;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 227:
					this.radWideEmergencyRxTxAlertToneSet_A41508 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌諎볐뛒꟔냖볘뗚뻜ꛞ돠鯢뇤鿦꣨蟪裬鷮藰ꟲ髴駶鳸꣺飼课帀䈂㄄㘆㰈㬊㔌", a_), global::CommonResources.AcgResources.ID_EMERGENCYRXTXALERTTONESET, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideEmergencyRxTxAlertToneSet_A41508LovStrs);
					this.radWideEmergencyRxTxAlertToneSet_A41508.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideEmergencyRxTxAlertToneSet_A41508.DataTransferOrder = -1;
					num = (short)1574240455;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 228:
					this.mARVELL_DNP_43591 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("賀苂韄釆賈蟊臌郎闐鷒藔裖탠", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSWIFINOTSUPPORTEDBYHARDWARE);
					this.mARVELL_DNP_43591.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					num = (short)1165885443;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 229:
					goto IL_1464;
				case 230:
					this.radioWideLabtoolEmergencyCallTermination_43348 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ껆ꛈ鳊꓌ꯎ듐鿒듔뗖귘듚닜돞ꓠ転胤闦軨軪菬賮裰냲铴鯶闸꿺飼跾氀樂欄昆紈戊戌愎丐✒☔␖ⴘ⌚", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSEMERGENCYCALLTERMINATION);
					this.radioWideLabtoolEmergencyCallTermination_43348.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radioWideLabtoolEmergencyCallTermination_43348.DataTransferOrder = -1;
					num = (short)1156513880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 231:
					this.radWideLabtoolConsolidatedActionEnhancement_A43036 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚黜냞迠郢諤详胨迪賬鯮铰韲듴银跸鋺鋼釾䐀洂洄昆月栊栌戎琐紒愔䠖堘⼚⸜⼞ሠᔢ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSCONSOLIDATEDACTIONSENHANCEMENT);
					this.radWideLabtoolConsolidatedActionEnhancement_A43036.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolConsolidatedActionEnhancement_A43036.DataTransferOrder = -1;
					num = (short)1890779157;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3CD:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)623116406;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_3F3:
				num = (short)651755585;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_440:
				num = (short)1316421728;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6F3:
				num = (short)1162936425;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_740:
				num = (short)609812644;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_78D:
				num = (short)15597606;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_815:
				num = (short)1343881297;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8B8:
				num = (short)1115816161;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_94E:
				num = (short)1736769681;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9ED:
				num = (short)1714225298;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AE4:
				num = (short)531300389;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B32:
				num = (short)292749409;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C4E:
				num = (short)1254686839;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D8C:
				num = (short)1167196373;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E2D:
				num = (short)345702480;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E7B:
				num = (short)1887830158;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EC9:
				num = (short)474742917;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F15:
				num = (short)2028011651;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_FEB:
				num = (short)1906966749;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1039:
				num = (short)1651834969;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1086:
				num = (short)1489895586;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_111B:
				num = (short)779747521;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1169:
				num = (short)1556873270;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_11B7:
				num = (short)1440678018;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1201:
				num = (short)877723872;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_12EA:
				num = (short)1785331818;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1307:
				num = (short)1755775156;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1464:
				num = (short)584974338;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_14D9:
				num = (short)1545732181;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_157A:
				num = (short)1176830152;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_15C5:
				num = (short)1065418940;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1669:
				num = (short)1470824506;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_16B5:
				num = (short)1939603474;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1702:
				num = (short)1225523391;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_17A5:
				num = (short)1289093232;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_190A:
				num = (short)1847853190;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_19DC:
				num = (short)1953497203;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1A2A:
				num = (short)1980629130;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B3B:
				num = (short)112984211;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1BDD:
				num = (short)405274659;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D74:
				num = (short)415170638;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1DC2:
				num = (short)1538523291;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1EB8:
				num = (short)152830080;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F04:
				num = (short)1421344775;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F50:
				num = (short)1574764698;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F9E:
				num = (short)1825046579;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1FEC:
				num = (short)1669333181;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2037:
				num = (short)1274609777;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_21E6:
				num = (short)135069757;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2234:
				num = (short)1611464899;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2280:
				num = (short)298057946;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_22CE:
				num = (short)37093554;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_231D:
				num = (short)8388828;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_236B:
				num = (short)1092681741;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_23B7:
				num = (short)1597243468;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2405:
				num = (short)1400963270;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2452:
				num = (short)273613016;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_249F:
				num = (short)1972961461;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_24EC:
				num = (short)1441661051;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2607:
				num = (short)1451753659;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2653:
				num = (short)1412890841;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_274A:
				num = (short)590807082;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2865:
				num = (short)1836056603;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_29C1:
				num = (short)441909349;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2A63:
				num = (short)785252352;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2AB1:
				num = (short)478216206;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2AFF:
				num = (short)2117730461;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2D24:
				num = (short)1977876604;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2D93:
				num = (short)1144848418;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E56:
				num = (short)1775108217;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2FA7:
				num = (short)135462941;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2FF6:
				num = (short)922812515;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3090:
				num = (short)34275372;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_30DD:
				num = (short)843972618;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3186:
				num = (short)125436079;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3281:
				num = (short)452329500;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_32CE:
				num = (short)80674936;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_280A:
			IL_342F:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("跀ꋂꟄ돆ꛈ꓊ꇌ", a_);
			base.Id = 10093;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 7;
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x00344530 File Offset: 0x00342730
		private void h()
		{
			int a_ = 14;
			short num = (short)1854930944;
			short num2 = num;
			num = (short)1082509506;
			short num3 = num;
			num = (short)1202768066;
			switch (num3 == num)
			{
			}
			num = (short)879820801;
			if (num != 0)
			{
			}
			num = (short)960036864;
			if (num != 0)
			{
			}
			this.radioWideLabtoolExtendedPLToneSet_43769 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖軘닚맜뫞균苢蟤鏦蛨蓪臬ꫮ觰蟲郴駶鷸黺駼꿾䴀圂樄椆氈堊栌笎丐✒☔‖⼘√", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSEXTENDEDPLTONESET);
			this.radioWideLabtoolExtendedPLToneSet_43769.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radioWideLabtoolExtendedPLToneSet_43769.DataTransferOrder = -1;
		}

		// Token: 0x0600367D RID: 13949 RVA: 0x0034461C File Offset: 0x0034281C
		private void g()
		{
			int a_ = 0;
			short num = (short)1001193472;
			short num2 = num;
			num = (short)471145715;
			short num3 = num;
			num = (short)1393171699;
			switch (num3 == num)
			{
			}
			num = (short)762642433;
			if (num != 0)
			{
			}
			num = (short)1305542656;
			if (num != 0)
			{
			}
			this.allowPSUSecure_43809 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胀꿂꧄꣆뻈鯊黌髎苐뛒뛔ꋖꯘ뻚苜틠\udbe2헤\udee6", a_), global::CommonResources.AcgResources.ID_ALLOWPSUSECURE);
			this.allowPSUSecure_43809.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.allowPSUSecure_43809.DataTransferOrder = -1;
		}

		// Token: 0x0600367E RID: 13950 RVA: 0x00344708 File Offset: 0x00342908
		private void f()
		{
			int a_ = 5;
			short num = (short)1900412928;
			short num2 = num;
			num = (short)899568180;
			short num3 = num;
			num = (short)4805172;
			switch (num3 == num)
			{
			}
			num = (short)743964672;
			if (num != 0)
			{
			}
			num = (short)1826947073;
			if (num != 0)
			{
			}
			this.uCLContactsLimitationEnhancement_43811 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏅诇蛉迋ꇍ뻏ꛑ뗓뗕곗꧙郛럝跟诡郣蟥鳧菩菫胭뗯鳱鳳韵雷駹駻鏽旿氁瀃夅㰇㤉㐋㼍ℏ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSUCLCONTACTSLIMITATIONENHANCEMENT);
			this.uCLContactsLimitationEnhancement_43811.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.uCLContactsLimitationEnhancement_43811.DataTransferOrder = -1;
		}

		// Token: 0x0600367F RID: 13951 RVA: 0x003447F4 File Offset: 0x003429F4
		private void e()
		{
			int a_ = 18;
			short num = (short)1455620096;
			short num2 = num;
			num = (short)897952243;
			short num3 = num;
			num = (short)1201711603;
			switch (num3 == num)
			{
			}
			num = (short)1347878912;
			if (num != 0)
			{
			}
			num = (short)593756161;
			if (num != 0)
			{
			}
			this.dVRSRangeExt_44809 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("韒菔藖諘觚볜뇞蛠蛢ꃤ鿦鷨듪\ud9ec\udbee짰쏲쳴", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSDVRSRANGEEXT);
			this.dVRSRangeExt_44809.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dVRSRangeExt_44809.DataTransferOrder = -1;
		}

		// Token: 0x06003680 RID: 13952 RVA: 0x003448E0 File Offset: 0x00342AE0
		private void d()
		{
			int a_ = 7;
			short num = (short)1459290112;
			short num2 = num;
			num = (short)1921505079;
			short num3 = num;
			num = (short)1957484343;
			switch (num3 == num)
			{
			}
			num = (short)1472790529;
			if (num != 0)
			{
			}
			num = (short)417726464;
			if (num != 0)
			{
			}
			this.radWideLabtoolIndirectPTTAudioRoutingPCI_44817 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓髕맗룙꣛뇝迟軡귣裥賧菩黫语鏯蛱ꓳꋵ곷믹觻髽槿洁嘃椅紇縉攋怍眏䈑圓引䜗⸙⠛☝ᄟᔡ", a_), global::CommonResources.AcgResources.ID_PRODUCTCAPABILITYINDICATORSDINDIRECTPTTAUDIOROUTINGPCI);
			this.radWideLabtoolIndirectPTTAudioRoutingPCI_44817.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolIndirectPTTAudioRoutingPCI_44817.DataTransferOrder = -1;
		}

		// Token: 0x06003681 RID: 13953 RVA: 0x003449C8 File Offset: 0x00342BC8
		private void c()
		{
			int a_ = 5;
			short num = (short)1781530624;
			short num2 = num;
			num = (short)345261923;
			short num3 = num;
			num = (short)358238051;
			switch (num3 == num)
			{
			}
			num = (short)56819713;
			if (num != 0)
			{
			}
			num = (short)16842752;
			if (num != 0)
			{
			}
			this.radwideLabtoolADPGatingPCIBit = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉鯋ꟍ듏럑飓럕뫗껙돛뇝賟ꏡꃣ뛥꿧诩飫蟭黯闱ꓳ뗵뇷룹闻諽忿㘁〃㸅㤇㤉", a_), global::CommonResources.AcgResources.ID_RADWIDELABTOOLADPGATINGPCIBIT);
			this.radwideLabtoolADPGatingPCIBit.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radwideLabtoolADPGatingPCIBit.DataTransferOrder = -1;
		}

		// Token: 0x06003682 RID: 13954 RVA: 0x00344AB4 File Offset: 0x00342CB4
		private void b()
		{
			int a_ = 16;
			short num = (short)1109458944;
			short num2 = num;
			num = (short)607187896;
			short num3 = num;
			num = (short)644346808;
			switch (num3 == num)
			{
			}
			num = (short)210567169;
			if (num != 0)
			{
			}
			num = (short)1305411584;
			if (num != 0)
			{
			}
			this.radWideLabtoolSupportO3ControlHeadPCIBit = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("菐닒뇔胖냘뿚룜鏞胠臢釤裦蛨蟪뻬髮臰菲髴藶跸듺컼볾渀洂焄甆昈朊䔌樎瀐眒䔔吖倘多琜欞縠ᜢᄤἦᄨἪ", a_), global::CommonResources.AcgResources.ID_SUPPORTO3CHPCI);
			this.radWideLabtoolSupportO3ControlHeadPCIBit.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolSupportO3ControlHeadPCIBit.DataTransferOrder = -1;
		}

		// Token: 0x06003683 RID: 13955 RVA: 0x00344BA0 File Offset: 0x00342DA0
		private void a()
		{
			int a_ = 9;
			short num = (short)1902575616;
			short num2 = num;
			num = (short)1391424039;
			short num3 = num;
			num = (short)500396583;
			switch (num3 == num)
			{
			}
			num = (short)461373441;
			if (num != 0)
			{
			}
			num = (short)1692860416;
			if (num != 0)
			{
			}
			this.radWideLabtoolAnalogWideBandDataPCIBit_44885 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕铗믙뻛ꫝ迟跡裣꟥蛧诩胫臭韯ꗱ鷳鋵鷷룹鷻都擿䘁攃爅椇娉伋䜍刏笑怓䤕Ⱇ⸙␛☝ᔟ", a_), global::CommonResources.AcgResources.ID_ANALOGWIDEBANDDATAPCI);
			this.radWideLabtoolAnalogWideBandDataPCIBit_44885.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolAnalogWideBandDataPCIBit_44885.DataTransferOrder = -1;
		}

		// Token: 0x06003684 RID: 13956 RVA: 0x00344C8C File Offset: 0x00342E8C
		public override void PopulateReferences()
		{
			short num = (short)45350912;
			short num2 = num;
			num = (short)1408434177;
			if (num != 0)
			{
			}
			num = (short)1809156749;
			short num3 = num;
			num = (short)967543437;
			switch (num3 == num)
			{
			}
			num = (short)1189543936;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003685 RID: 13957 RVA: 0x00344D34 File Offset: 0x00342F34
		public override void DropReferences()
		{
			short num = (short)1075707904;
			short num2 = num;
			num = (short)647511997;
			short num3 = num;
			num = (short)1951023037;
			switch (num3 == num)
			{
			}
			num = (short)840040449;
			if (num != 0)
			{
			}
			num = (short)120782848;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003686 RID: 13958 RVA: 0x00344DDC File Offset: 0x00342FDC
		public override void SetConstraints()
		{
			short num = (short)1802567680;
			short num2 = num;
			num = (short)386894706;
			short num3 = num;
			num = (short)607357810;
			switch (num3 == num)
			{
			}
			num = (short)60358657;
			if (num != 0)
			{
			}
			num = (short)1994850304;
			if (num != 0)
			{
			}
			this.radWideLabtoolArchiveReadPasswordEnable_A7462.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolRadioPassword_A8837.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolRadioReadPasswordEnable_A8869.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolRadioWritePasswordEnable_A8889.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolSmartLowBatteryThreshold_A20201.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsSmartLowBatteryThreshold);
			this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsEarlyWarningBatteryThreshold);
			this.radWideLabtoolDynamicZoneCable_A41258.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolSirenAndLightsKeypadEnable_A41413.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolEncryptPassword_A41695.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolEmergencyRevertCapable_A41918.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolAudibleBeaconRoutingCapable_A41974.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.manDownPersonalityConfigurableCapable_42082.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.toneEmergencyConfigurableCapable_42083.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolAPX6000P25Radio_A42121.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolSuppressEmergencyCallCapability_A42143.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolMaritimeRadioSoftware_A42191.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolMFKEmergencyAccess_A42216.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.emergencyHotAuxMicConfigurability_A42301.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.tPSCapable_A42312.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.pASSAlarmFilterCapable_A42387.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolAPXDualKnobs_A42537.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolAudioEnhancement_A42736.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolDynamicZoneScanCapability_42749.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radioWideDVRSTrunkingStatusCapability_A42772.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radioWideMOSCADACE3000Capability_A42772.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolPAAlertCapability_A42944.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolUserSelectablePLEnhancement_43031.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolConsolidatedActionEnhancement_A43036.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolActiveMicForBTPTTCapable_43053.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolAPXSingletoneCapable_43080.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolEnhancedARS_A43084.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radioWideLabtoolZoneCloneCapable_43238.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radioWideLabtoolEmergencyCallTermination_43348.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolDisableEncryption_43371.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolIntelligentPriorityScanCapable_43411.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.mARVELL_DNP_43591.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.tEN_DIGIT_RL_PSWD_capable_43711.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.RadioWideLabtoolExtendedPLToneSet_43769.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.allowPSUSecure_43809.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.UCLContactsLimitationEnhancement_43811.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.dVRSRangeExt_44809.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolIndirectPTTAudioRoutingPCI_44817.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radwideLabtoolADPGatingPCIBit.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolSupportO3ControlHeadPCIBit.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideLabtoolSeamlessUpdateOutOfBoxExperience.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x06003687 RID: 13959 RVA: 0x003452EC File Offset: 0x003434EC
		public override void SetupDependencies()
		{
			short num = (short)1890844672;
			short num2 = num;
			num = (short)410661144;
			short num3 = num;
			num = (short)438120728;
			switch (num3 == num)
			{
			}
			num = (short)2081947649;
			if (num != 0)
			{
			}
			num = (short)43843584;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			radioWide.AlertTones.RadWideAdvancedSmartLowBatteryAlert_A9165.AddDependentObject(this.radWideLabtoolSmartLowBatteryThreshold_A20201);
			radioWide.AlertTones.RadWideAdvancedSmartLowBatteryAlert_A9165.AddDependentObject(this.radWideLabtoolEarlyWarningBatteryThreshold_A23977);
		}

		// Token: 0x17001B99 RID: 7065
		// (get) Token: 0x06003688 RID: 13960 RVA: 0x003453CC File Offset: 0x003435CC
		public bool HasDiffs
		{
			get
			{
				short num = (short)428867584;
				short num2 = num;
				num = (short)601441302;
				short num3 = num;
				num = (short)100811798;
				switch (num3 == num)
				{
				}
				num = (short)1583284225;
				if (num != 0)
				{
				}
				num = (short)1161363456;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17001B9A RID: 7066
		// (get) Token: 0x06003689 RID: 13961 RVA: 0x0034547C File Offset: 0x0034367C
		// (set) Token: 0x0600368A RID: 13962 RVA: 0x00345534 File Offset: 0x00343734
		public bool RadWideLabtoolArchiveReadPasswordEnable_A7462Value
		{
			get
			{
				short num = (short)621871104;
				short num2 = num;
				num = (short)183422989;
				short num3 = num;
				num = (short)1894830093;
				switch (num3 == num)
				{
				}
				num = (short)499187713;
				if (num != 0)
				{
				}
				num = (short)530644992;
				if (num != 0)
				{
				}
				return this.radWideLabtoolArchiveReadPasswordEnable_A7462.Value;
			}
			set
			{
				short num = (short)1024655360;
				short num2 = num;
				num = (short)712865660;
				short num3 = num;
				num = (short)1696102268;
				switch (num3 == num)
				{
				}
				num = (short)1372127233;
				if (num != 0)
				{
				}
				num = (short)1790509056;
				if (num != 0)
				{
				}
				this.radWideLabtoolArchiveReadPasswordEnable_A7462.Value = value;
			}
		}

		// Token: 0x17001B9B RID: 7067
		// (get) Token: 0x0600368B RID: 13963 RVA: 0x003455E8 File Offset: 0x003437E8
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolArchiveReadPasswordEnable_A7462
		{
			get
			{
				short num = (short)1114832896;
				short num2 = num;
				num = (short)1857428279;
				short num3 = num;
				num = (short)406985527;
				switch (num3 == num)
				{
				}
				num = (short)976617472;
				if (num != 0)
				{
				}
				num = (short)1137901569;
				if (num != 0)
				{
				}
				return this.radWideLabtoolArchiveReadPasswordEnable_A7462;
			}
		}

		// Token: 0x17001B9C RID: 7068
		// (get) Token: 0x0600368C RID: 13964 RVA: 0x00345698 File Offset: 0x00343898
		// (set) Token: 0x0600368D RID: 13965 RVA: 0x00345750 File Offset: 0x00343950
		public bool RadWideLabtoolArchiveReadPasswordEnable_A7462_UIValue
		{
			get
			{
				short num = (short)882114560;
				short num2 = num;
				num = (short)418316289;
				if (num != 0)
				{
				}
				num = (short)958718469;
				short num3 = num;
				num = (short)1001251333;
				switch (num3 == num)
				{
				}
				num = (short)965017600;
				if (num != 0)
				{
				}
				return this.radWideLabtoolArchiveReadPasswordEnable_A7462.Value;
			}
			set
			{
				short num = (short)112918528;
				short num2 = num;
				num = (short)514197601;
				short num3 = num;
				num = (short)1969948769;
				switch (num3 == num)
				{
				}
				num = (short)902758400;
				if (num != 0)
				{
				}
				num = (short)2021392385;
				if (num != 0)
				{
				}
				this.radWideLabtoolArchiveReadPasswordEnable_A7462.Value = value;
			}
		}

		// Token: 0x17001B9D RID: 7069
		// (get) Token: 0x0600368E RID: 13966 RVA: 0x00345808 File Offset: 0x00343A08
		// (set) Token: 0x0600368F RID: 13967 RVA: 0x003458C0 File Offset: 0x00343AC0
		public bool RadWideLabtoolArchiveReadPasswordEnable_A7462_Applicable
		{
			get
			{
				short num = (short)1832779776;
				short num2 = num;
				num = (short)1492458565;
				short num3 = num;
				num = (short)1651645509;
				switch (num3 == num)
				{
				}
				num = (short)1250099201;
				if (num != 0)
				{
				}
				num = (short)653524992;
				if (num != 0)
				{
				}
				return this.radWideLabtoolArchiveReadPasswordEnable_A7462.Applicable;
			}
			set
			{
				short num = (short)543752192;
				short num2 = num;
				num = (short)442761217;
				if (num != 0)
				{
				}
				num = (short)1138026179;
				short num3 = num;
				num = (short)805562051;
				switch (num3 == num)
				{
				}
				num = (short)2131886080;
				if (num != 0)
				{
				}
				this.radWideLabtoolArchiveReadPasswordEnable_A7462.Applicable = value;
			}
		}

		// Token: 0x17001B9E RID: 7070
		// (get) Token: 0x06003690 RID: 13968 RVA: 0x00345974 File Offset: 0x00343B74
		// (set) Token: 0x06003691 RID: 13969 RVA: 0x00345A28 File Offset: 0x00343C28
		public bool RadWideLabtoolArchiveReadPasswordEnable_A7462_Valid
		{
			get
			{
				short num = (short)2029715456;
				short num2 = num;
				num = (short)2126060957;
				short num3 = num;
				num = (short)801971613;
				switch (num3 == num)
				{
				}
				num = (short)1190526976;
				if (num != 0)
				{
				}
				num = (short)1037828097;
				if (num != 0)
				{
				}
				return this.radWideLabtoolArchiveReadPasswordEnable_A7462.Valid;
			}
			set
			{
				short num = (short)1013907456;
				short num2 = num;
				num = (short)956540685;
				short num3 = num;
				num = (short)1457432333;
				switch (num3 == num)
				{
				}
				num = (short)867565569;
				if (num != 0)
				{
				}
				num = (short)1888681984;
				if (num != 0)
				{
				}
				this.radWideLabtoolArchiveReadPasswordEnable_A7462.Valid = value;
			}
		}

		// Token: 0x17001B9F RID: 7071
		// (get) Token: 0x06003692 RID: 13970 RVA: 0x00345AE0 File Offset: 0x00343CE0
		// (set) Token: 0x06003693 RID: 13971 RVA: 0x00345B98 File Offset: 0x00343D98
		public bool RadWideLabtoolArchiveReadPasswordEnable_A7462_Visible
		{
			get
			{
				short num = (short)1378484224;
				short num2 = num;
				num = (short)1522588241;
				short num3 = num;
				num = (short)737925713;
				switch (num3 == num)
				{
				}
				num = (short)1562968065;
				if (num != 0)
				{
				}
				num = (short)1147928576;
				if (num != 0)
				{
				}
				return this.radWideLabtoolArchiveReadPasswordEnable_A7462.Visible;
			}
			set
			{
				short num = (short)839254016;
				short num2 = num;
				num = (short)1432748033;
				if (num != 0)
				{
				}
				num = (short)1437274891;
				short num3 = num;
				num = (short)1234440971;
				switch (num3 == num)
				{
				}
				num = (short)1635450880;
				if (num != 0)
				{
				}
				this.radWideLabtoolArchiveReadPasswordEnable_A7462.Visible = value;
			}
		}

		// Token: 0x17001BA0 RID: 7072
		// (get) Token: 0x06003694 RID: 13972 RVA: 0x00345C50 File Offset: 0x00343E50
		// (set) Token: 0x06003695 RID: 13973 RVA: 0x00345D08 File Offset: 0x00343F08
		public bool RadWideLabtoolArchiveReadPasswordEnable_A7462_Editable
		{
			get
			{
				short num = (short)1994457088;
				short num2 = num;
				num = (short)1718808826;
				short num3 = num;
				num = (short)2080370938;
				switch (num3 == num)
				{
				}
				num = (short)1812856833;
				if (num != 0)
				{
				}
				num = (short)928579584;
				if (num != 0)
				{
				}
				return this.radWideLabtoolArchiveReadPasswordEnable_A7462.Editable;
			}
			set
			{
				short num = (short)375783424;
				short num2 = num;
				num = (short)577969522;
				short num3 = num;
				num = (short)1733172594;
				switch (num3 == num)
				{
				}
				num = (short)1958412289;
				if (num != 0)
				{
				}
				num = (short)532414464;
				if (num != 0)
				{
				}
				this.radWideLabtoolArchiveReadPasswordEnable_A7462.Editable = value;
			}
		}

		// Token: 0x17001BA1 RID: 7073
		// (get) Token: 0x06003696 RID: 13974 RVA: 0x00345DC0 File Offset: 0x00343FC0
		internal string RadWideLabtoolArchiveReadPasswordEnable_A7462_UILabel
		{
			get
			{
				short num = (short)526778368;
				short num2 = num;
				num = (short)277968185;
				short num3 = num;
				num = (short)146502969;
				switch (num3 == num)
				{
				}
				num = (short)1232863233;
				if (num != 0)
				{
				}
				num = (short)525860864;
				if (num != 0)
				{
				}
				return this.radWideLabtoolArchiveReadPasswordEnable_A7462.UIName;
			}
		}

		// Token: 0x17001BA2 RID: 7074
		// (get) Token: 0x06003697 RID: 13975 RVA: 0x00345E74 File Offset: 0x00344074
		// (set) Token: 0x06003698 RID: 13976 RVA: 0x00345F28 File Offset: 0x00344128
		internal bool RadWideLabtoolArchiveReadPasswordEnable_A7462_HiddenStatic
		{
			get
			{
				short num = (short)734199808;
				short num2 = num;
				num = (short)581304321;
				if (num != 0)
				{
				}
				num = (short)1064977013;
				short num3 = num;
				num = (short)336085621;
				switch (num3 == num)
				{
				}
				num = (short)2064449536;
				if (num != 0)
				{
				}
				return this.radWideLabtoolArchiveReadPasswordEnable_A7462.HiddenStatic;
			}
			set
			{
				short num = (short)443705530;
				short num2 = num;
				num = (short)1158899898;
				switch (num2 == num)
				{
				}
				num = (short)2024538112;
				short num3 = num;
				num = (short)69140481;
				if (num != 0)
				{
				}
				num = (short)1860960256;
				if (num != 0)
				{
				}
				this.radWideLabtoolArchiveReadPasswordEnable_A7462.HiddenStatic = value;
			}
		}

		// Token: 0x17001BA3 RID: 7075
		// (get) Token: 0x06003699 RID: 13977 RVA: 0x00345FE0 File Offset: 0x003441E0
		// (set) Token: 0x0600369A RID: 13978 RVA: 0x00346098 File Offset: 0x00344298
		internal bool RadWideLabtoolArchiveReadPasswordEnable_A7462_HiddenDynamic
		{
			get
			{
				short num = (short)1770491075;
				short num2 = num;
				num = (short)525241539;
				switch (num2 == num)
				{
				}
				num = (short)1959067648;
				short num3 = num;
				num = (short)1389821953;
				if (num != 0)
				{
				}
				num = (short)376438784;
				if (num != 0)
				{
				}
				return this.radWideLabtoolArchiveReadPasswordEnable_A7462.HiddenDynamic;
			}
			set
			{
				short num = (short)458767651;
				short num2 = num;
				num = (short)1013005603;
				switch (num2 == num)
				{
				}
				num = (short)1623523328;
				short num3 = num;
				num = (short)649920513;
				if (num != 0)
				{
				}
				num = (short)582549504;
				if (num != 0)
				{
				}
				this.radWideLabtoolArchiveReadPasswordEnable_A7462.HiddenDynamic = value;
			}
		}

		// Token: 0x17001BA4 RID: 7076
		// (get) Token: 0x0600369B RID: 13979 RVA: 0x0034614C File Offset: 0x0034434C
		public bool RadWideLabtoolArchiveReadPasswordEnable_A7462_HasDiffs
		{
			get
			{
				short num = (short)1118688744;
				short num2 = num;
				num = (short)1734596072;
				switch (num2 == num)
				{
				}
				num = (short)1289551872;
				short num3 = num;
				num = (short)1515585536;
				if (num != 0)
				{
				}
				num = (short)1589837825;
				if (num != 0)
				{
				}
				return this.radWideLabtoolArchiveReadPasswordEnable_A7462._HasDiffs;
			}
		}

		// Token: 0x17001BA5 RID: 7077
		// (get) Token: 0x0600369C RID: 13980 RVA: 0x00346200 File Offset: 0x00344400
		// (set) Token: 0x0600369D RID: 13981 RVA: 0x003462B0 File Offset: 0x003444B0
		public bool RadWideLabtoolControlHeadConfiguration_A7722Value
		{
			get
			{
				short num = (short)1719305779;
				short num2 = num;
				num = (short)14845491;
				switch (num2 == num)
				{
				}
				num = (short)310181888;
				short num3 = num;
				num = (short)133693441;
				if (num != 0)
				{
				}
				num = (short)1658060800;
				if (num != 0)
				{
				}
				return this.radWideLabtoolControlHeadConfiguration_A7722.Value;
			}
			set
			{
				short num = (short)515122721;
				short num2 = num;
				num = (short)112141857;
				switch (num2 == num)
				{
				}
				num = (short)360513536;
				short num3 = num;
				num = (short)1516306433;
				if (num != 0)
				{
				}
				num = (short)500629504;
				if (num != 0)
				{
				}
				this.radWideLabtoolControlHeadConfiguration_A7722.Value = value;
			}
		}

		// Token: 0x17001BA6 RID: 7078
		// (get) Token: 0x0600369E RID: 13982 RVA: 0x00346368 File Offset: 0x00344568
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolControlHeadConfiguration_A7722
		{
			get
			{
				short num = (short)1855107323;
				short num2 = num;
				num = (short)112308475;
				switch (num2 == num)
				{
				}
				num = (short)789315584;
				short num3 = num;
				num = (short)545783809;
				if (num != 0)
				{
				}
				num = (short)321060864;
				if (num != 0)
				{
				}
				return this.radWideLabtoolControlHeadConfiguration_A7722;
			}
		}

		// Token: 0x17001BA7 RID: 7079
		// (get) Token: 0x0600369F RID: 13983 RVA: 0x00346418 File Offset: 0x00344618
		// (set) Token: 0x060036A0 RID: 13984 RVA: 0x003464D0 File Offset: 0x003446D0
		public bool RadWideLabtoolControlHeadConfiguration_A7722_UIValue
		{
			get
			{
				short num = (short)63459634;
				short num2 = num;
				num = (short)1127895346;
				switch (num2 == num)
				{
				}
				num = (short)221315072;
				short num3 = num;
				num = (short)794492928;
				if (num != 0)
				{
				}
				num = (short)1976958977;
				if (num != 0)
				{
				}
				return this.radWideLabtoolControlHeadConfiguration_A7722.Value;
			}
			set
			{
				short num = (short)636132085;
				short num2 = num;
				num = (short)1089051381;
				switch (num2 == num)
				{
				}
				num = (short)2084765696;
				short num3 = num;
				num = (short)851443712;
				if (num != 0)
				{
				}
				num = (short)1838481409;
				if (num != 0)
				{
				}
				this.radWideLabtoolControlHeadConfiguration_A7722.Value = value;
			}
		}

		// Token: 0x17001BA8 RID: 7080
		// (get) Token: 0x060036A1 RID: 13985 RVA: 0x00346588 File Offset: 0x00344788
		// (set) Token: 0x060036A2 RID: 13986 RVA: 0x0034663C File Offset: 0x0034483C
		public bool RadWideLabtoolControlHeadConfiguration_A7722_Applicable
		{
			get
			{
				short num = (short)354754085;
				short num2 = num;
				num = (short)163913253;
				switch (num2 == num)
				{
				}
				num = (short)935002112;
				short num3 = num;
				num = (short)627703808;
				if (num != 0)
				{
				}
				num = (short)984350721;
				if (num != 0)
				{
				}
				return this.radWideLabtoolControlHeadConfiguration_A7722.Applicable;
			}
			set
			{
				short num = (short)845110625;
				short num2 = num;
				num = (short)1766350177;
				switch (num2 == num)
				{
				}
				num = (short)1093009408;
				short num3 = num;
				num = (short)76480513;
				if (num != 0)
				{
				}
				num = (short)1274937344;
				if (num != 0)
				{
				}
				this.radWideLabtoolControlHeadConfiguration_A7722.Applicable = value;
			}
		}

		// Token: 0x17001BA9 RID: 7081
		// (get) Token: 0x060036A3 RID: 13987 RVA: 0x003466F0 File Offset: 0x003448F0
		// (set) Token: 0x060036A4 RID: 13988 RVA: 0x003467A4 File Offset: 0x003449A4
		public bool RadWideLabtoolControlHeadConfiguration_A7722_Valid
		{
			get
			{
				short num = (short)1929104501;
				short num2 = num;
				num = (short)295160949;
				switch (num2 == num)
				{
				}
				num = (short)2010775552;
				short num3 = num;
				num = (short)469368832;
				if (num != 0)
				{
				}
				num = (short)1016266753;
				if (num != 0)
				{
				}
				return this.radWideLabtoolControlHeadConfiguration_A7722.Valid;
			}
			set
			{
				short num = (short)953675328;
				short num2 = num;
				num = (short)694349376;
				switch (num2 == num)
				{
				}
				num = (short)1131806720;
				short num3 = num;
				num = (short)1957429248;
				if (num != 0)
				{
				}
				num = (short)1134166017;
				if (num != 0)
				{
				}
				this.radWideLabtoolControlHeadConfiguration_A7722.Valid = value;
			}
		}

		// Token: 0x17001BAA RID: 7082
		// (get) Token: 0x060036A5 RID: 13989 RVA: 0x0034685C File Offset: 0x00344A5C
		// (set) Token: 0x060036A6 RID: 13990 RVA: 0x00346910 File Offset: 0x00344B10
		public bool RadWideLabtoolControlHeadConfiguration_A7722_Visible
		{
			get
			{
				short num = (short)1244573655;
				short num2 = num;
				num = (short)128102359;
				switch (num2 == num)
				{
				}
				num = (short)1227358208;
				short num3 = num;
				num = (short)1283457025;
				if (num != 0)
				{
				}
				num = (short)1802305536;
				if (num != 0)
				{
				}
				return this.radWideLabtoolControlHeadConfiguration_A7722.Visible;
			}
			set
			{
				short num = (short)1652177860;
				short num2 = num;
				num = (short)1102003140;
				switch (num2 == num)
				{
				}
				num = (short)1317208064;
				short num3 = num;
				num = (short)779943936;
				if (num != 0)
				{
				}
				num = (short)359464961;
				if (num != 0)
				{
				}
				this.radWideLabtoolControlHeadConfiguration_A7722.Visible = value;
			}
		}

		// Token: 0x17001BAB RID: 7083
		// (get) Token: 0x060036A7 RID: 13991 RVA: 0x003469C4 File Offset: 0x00344BC4
		// (set) Token: 0x060036A8 RID: 13992 RVA: 0x00346A78 File Offset: 0x00344C78
		public bool RadWideLabtoolControlHeadConfiguration_A7722_Editable
		{
			get
			{
				short num = (short)1797062657;
				if (num != 0)
				{
				}
				num = (short)1786752037;
				short num2 = num;
				num = (short)970501157;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1668939776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1393491968;
				if (num != 0)
				{
				}
				return this.radWideLabtoolControlHeadConfiguration_A7722.Editable;
			}
			set
			{
				short num = (short)918292925;
				short num2 = num;
				num = (short)1277888957;
				switch (num2 == num)
				{
				}
				num = (short)906690560;
				short num3 = num;
				num = (short)2096103424;
				if (num != 0)
				{
				}
				num = (short)1574764545;
				if (num != 0)
				{
				}
				this.radWideLabtoolControlHeadConfiguration_A7722.Editable = value;
			}
		}

		// Token: 0x17001BAC RID: 7084
		// (get) Token: 0x060036A9 RID: 13993 RVA: 0x00346B2C File Offset: 0x00344D2C
		internal string RadWideLabtoolControlHeadConfiguration_A7722_UILabel
		{
			get
			{
				short num = (short)1009195391;
				short num2 = num;
				num = (short)824514943;
				switch (num2 == num)
				{
				}
				num = (short)2121400320;
				short num3 = num;
				num = (short)1854537728;
				if (num != 0)
				{
				}
				num = (short)641466369;
				if (num != 0)
				{
				}
				return this.radWideLabtoolControlHeadConfiguration_A7722.UIName;
			}
		}

		// Token: 0x17001BAD RID: 7085
		// (get) Token: 0x060036AA RID: 13994 RVA: 0x00346BE0 File Offset: 0x00344DE0
		// (set) Token: 0x060036AB RID: 13995 RVA: 0x00346C98 File Offset: 0x00344E98
		internal bool RadWideLabtoolControlHeadConfiguration_A7722_HiddenStatic
		{
			get
			{
				short num = (short)2027348127;
				short num2 = num;
				num = (short)416800927;
				switch (num2 == num)
				{
				}
				num = (short)1233715200;
				short num3 = num;
				num = (short)1618280448;
				if (num != 0)
				{
				}
				num = (short)1448214529;
				if (num != 0)
				{
				}
				return this.radWideLabtoolControlHeadConfiguration_A7722.HiddenStatic;
			}
			set
			{
				short num = (short)696903287;
				short num2 = num;
				num = (short)1272571511;
				switch (num2 == num)
				{
				}
				num = (short)1396047872;
				short num3 = num;
				num = (short)209584128;
				if (num != 0)
				{
				}
				num = (short)1276051457;
				if (num != 0)
				{
				}
				this.radWideLabtoolControlHeadConfiguration_A7722.HiddenStatic = value;
			}
		}

		// Token: 0x17001BAE RID: 7086
		// (get) Token: 0x060036AC RID: 13996 RVA: 0x00346D50 File Offset: 0x00344F50
		// (set) Token: 0x060036AD RID: 13997 RVA: 0x00346E08 File Offset: 0x00345008
		internal bool RadWideLabtoolControlHeadConfiguration_A7722_HiddenDynamic
		{
			get
			{
				short num = (short)1696121412;
				short num2 = num;
				num = (short)1851966020;
				switch (num2 == num)
				{
				}
				num = (short)2114453504;
				short num3 = num;
				num = (short)178716673;
				if (num != 0)
				{
				}
				num = (short)1845166080;
				if (num != 0)
				{
				}
				return this.radWideLabtoolControlHeadConfiguration_A7722.HiddenDynamic;
			}
			set
			{
				short num = (short)756189500;
				short num2 = num;
				num = (short)1194166588;
				switch (num2 == num)
				{
				}
				num = (short)1842937856;
				short num3 = num;
				num = (short)1714356225;
				if (num != 0)
				{
				}
				num = (short)1359413248;
				if (num != 0)
				{
				}
				this.radWideLabtoolControlHeadConfiguration_A7722.HiddenDynamic = value;
			}
		}

		// Token: 0x17001BAF RID: 7087
		// (get) Token: 0x060036AE RID: 13998 RVA: 0x00346EC0 File Offset: 0x003450C0
		public bool RadWideLabtoolControlHeadConfiguration_A7722_HasDiffs
		{
			get
			{
				short num = (short)373481702;
				short num2 = num;
				num = (short)1868488934;
				switch (num2 == num)
				{
				}
				num = (short)425787392;
				short num3 = num;
				num = (short)366018561;
				if (num != 0)
				{
				}
				num = (short)1359413248;
				if (num != 0)
				{
				}
				return this.radWideLabtoolControlHeadConfiguration_A7722._HasDiffs;
			}
		}

		// Token: 0x17001BB0 RID: 7088
		// (get) Token: 0x060036AF RID: 13999 RVA: 0x00346F74 File Offset: 0x00345174
		// (set) Token: 0x060036B0 RID: 14000 RVA: 0x00347028 File Offset: 0x00345228
		public int RadWideLabtoolControlHeadSelection_A7723Value
		{
			get
			{
				short num = (short)1888902910;
				short num2 = num;
				num = (short)1019961086;
				switch (num2 == num)
				{
				}
				num = (short)1917386752;
				short num3 = num;
				num = (short)1796145153;
				if (num != 0)
				{
				}
				num = (short)763101184;
				if (num != 0)
				{
				}
				return this.radWideLabtoolControlHeadSelection_A7723.Value;
			}
			set
			{
				short num = (short)867212539;
				short num2 = num;
				num = (short)694066427;
				switch (num2 == num)
				{
				}
				num = (short)1116733440;
				short num3 = num;
				num = (short)1253638145;
				if (num != 0)
				{
				}
				num = (short)1041629184;
				if (num != 0)
				{
				}
				this.radWideLabtoolControlHeadSelection_A7723.Value = value;
			}
		}

		// Token: 0x17001BB1 RID: 7089
		// (get) Token: 0x060036B1 RID: 14001 RVA: 0x003470DC File Offset: 0x003452DC
		// (set) Token: 0x060036B2 RID: 14002 RVA: 0x00347194 File Offset: 0x00345394
		public string RadWideLabtoolControlHeadSelection_A7723_UIValue
		{
			get
			{
				short num = (short)1788038991;
				short num2 = num;
				num = (short)95899471;
				switch (num2 == num)
				{
				}
				num = (short)1186791424;
				short num3 = num;
				num = (short)348389376;
				if (num != 0)
				{
				}
				num = (short)1549533185;
				if (num != 0)
				{
				}
				return this.radWideLabtoolControlHeadSelection_A7723.UIValue;
			}
			set
			{
				short num = (short)1896421350;
				short num2 = num;
				num = (short)1426069478;
				switch (num2 == num)
				{
				}
				num = (short)1787428864;
				short num3 = num;
				num = (short)910163969;
				if (num != 0)
				{
				}
				num = (short)939065344;
				if (num != 0)
				{
				}
				this.radWideLabtoolControlHeadSelection_A7723.UIValue = value;
			}
		}

		// Token: 0x17001BB2 RID: 7090
		// (get) Token: 0x060036B3 RID: 14003 RVA: 0x00347248 File Offset: 0x00345448
		public global::AcpBusinessLayer.AcpListField RadWideLabtoolControlHeadSelection_A7723
		{
			get
			{
				short num = (short)1246437812;
				short num2 = num;
				num = (short)1954816436;
				switch (num2 == num)
				{
				}
				num = (short)2048393216;
				short num3 = num;
				num = (short)2111700992;
				if (num != 0)
				{
				}
				num = (short)1168441345;
				if (num != 0)
				{
				}
				return this.radWideLabtoolControlHeadSelection_A7723;
			}
		}

		// Token: 0x17001BB3 RID: 7091
		// (get) Token: 0x060036B4 RID: 14004 RVA: 0x003472F8 File Offset: 0x003454F8
		// (set) Token: 0x060036B5 RID: 14005 RVA: 0x003473AC File Offset: 0x003455AC
		public bool RadWideLabtoolControlHeadSelection_A7723_Applicable
		{
			get
			{
				short num = (short)859456162;
				short num2 = num;
				num = (short)257704610;
				switch (num2 == num)
				{
				}
				num = (short)1914634240;
				short num3 = num;
				num = (short)971046912;
				if (num != 0)
				{
				}
				num = (short)84934657;
				if (num != 0)
				{
				}
				return this.radWideLabtoolControlHeadSelection_A7723.Applicable;
			}
			set
			{
				short num = (short)489832233;
				short num2 = num;
				num = (short)230375209;
				switch (num2 == num)
				{
				}
				num = (short)314441728;
				short num3 = num;
				num = (short)1259143168;
				if (num != 0)
				{
				}
				num = (short)912523265;
				if (num != 0)
				{
				}
				this.radWideLabtoolControlHeadSelection_A7723.Applicable = value;
			}
		}

		// Token: 0x17001BB4 RID: 7092
		// (get) Token: 0x060036B6 RID: 14006 RVA: 0x00347460 File Offset: 0x00345660
		// (set) Token: 0x060036B7 RID: 14007 RVA: 0x00347514 File Offset: 0x00345714
		public bool RadWideLabtoolControlHeadSelection_A7723_Valid
		{
			get
			{
				short num = (short)1311947001;
				short num2 = num;
				num = (short)99399929;
				switch (num2 == num)
				{
				}
				num = (short)1731592192;
				short num3 = num;
				num = (short)1512505345;
				if (num != 0)
				{
				}
				num = (short)382205952;
				if (num != 0)
				{
				}
				return this.radWideLabtoolControlHeadSelection_A7723.Valid;
			}
			set
			{
				short num = (short)2080815556;
				short num2 = num;
				num = (short)1252309444;
				switch (num2 == num)
				{
				}
				num = (short)1124990976;
				short num3 = num;
				num = (short)1158217728;
				if (num != 0)
				{
				}
				num = (short)33161217;
				if (num != 0)
				{
				}
				this.radWideLabtoolControlHeadSelection_A7723.Valid = value;
			}
		}

		// Token: 0x17001BB5 RID: 7093
		// (get) Token: 0x060036B8 RID: 14008 RVA: 0x003475C8 File Offset: 0x003457C8
		// (set) Token: 0x060036B9 RID: 14009 RVA: 0x0034767C File Offset: 0x0034587C
		public bool RadWideLabtoolControlHeadSelection_A7723_Visible
		{
			get
			{
				short num = (short)1408029225;
				short num2 = num;
				num = (short)1344524841;
				switch (num2 == num)
				{
				}
				num = (short)61997056;
				short num3 = num;
				num = (short)2031617;
				if (num != 0)
				{
				}
				num = (short)1484324864;
				if (num != 0)
				{
				}
				return this.radWideLabtoolControlHeadSelection_A7723.Visible;
			}
			set
			{
				short num = (short)1892856130;
				short num2 = num;
				num = (short)2116202818;
				switch (num2 == num)
				{
				}
				num = (short)624099328;
				short num3 = num;
				num = (short)746717185;
				if (num != 0)
				{
				}
				num = (short)1749549056;
				if (num != 0)
				{
				}
				this.radWideLabtoolControlHeadSelection_A7723.Visible = value;
			}
		}

		// Token: 0x17001BB6 RID: 7094
		// (get) Token: 0x060036BA RID: 14010 RVA: 0x00347730 File Offset: 0x00345930
		// (set) Token: 0x060036BB RID: 14011 RVA: 0x003477E0 File Offset: 0x003459E0
		public bool RadWideLabtoolControlHeadSelection_A7723_Editable
		{
			get
			{
				short num = (short)872024428;
				short num2 = num;
				num = (short)296290668;
				switch (num2 == num)
				{
				}
				num = (short)169476096;
				short num3 = num;
				num = (short)994574337;
				if (num != 0)
				{
				}
				num = (short)1326186496;
				if (num != 0)
				{
				}
				return this.radWideLabtoolControlHeadSelection_A7723.Editable;
			}
			set
			{
				short num = (short)742522314;
				short num2 = num;
				num = (short)1595538890;
				switch (num2 == num)
				{
				}
				num = (short)802750464;
				short num3 = num;
				num = (short)1529741312;
				if (num != 0)
				{
				}
				num = (short)1283325953;
				if (num != 0)
				{
				}
				this.radWideLabtoolControlHeadSelection_A7723.Editable = value;
			}
		}

		// Token: 0x17001BB7 RID: 7095
		// (get) Token: 0x060036BC RID: 14012 RVA: 0x00347894 File Offset: 0x00345A94
		internal string RadWideLabtoolControlHeadSelection_A7723_UILabel
		{
			get
			{
				short num = (short)568328857;
				short num2 = num;
				num = (short)88539801;
				switch (num2 == num)
				{
				}
				num = (short)214237184;
				short num3 = num;
				num = (short)585367552;
				if (num != 0)
				{
				}
				num = (short)281804801;
				if (num != 0)
				{
				}
				return this.radWideLabtoolControlHeadSelection_A7723.UIName;
			}
		}

		// Token: 0x17001BB8 RID: 7096
		// (get) Token: 0x060036BD RID: 14013 RVA: 0x0034794C File Offset: 0x00345B4C
		// (set) Token: 0x060036BE RID: 14014 RVA: 0x00347A00 File Offset: 0x00345C00
		internal bool RadWideLabtoolControlHeadSelection_A7723_HiddenStatic
		{
			get
			{
				short num = (short)1328854409;
				short num2 = num;
				num = (short)257406345;
				switch (num2 == num)
				{
				}
				num = (short)347537408;
				short num3 = num;
				num = (short)1458241537;
				if (num != 0)
				{
				}
				num = (short)166133760;
				if (num != 0)
				{
				}
				return this.radWideLabtoolControlHeadSelection_A7723.HiddenStatic;
			}
			set
			{
				short num = (short)605465316;
				short num2 = num;
				num = (short)648194788;
				switch (num2 == num)
				{
				}
				num = (short)1753350144;
				short num3 = num;
				num = (short)348585984;
				if (num != 0)
				{
				}
				num = (short)1459945473;
				if (num != 0)
				{
				}
				this.radWideLabtoolControlHeadSelection_A7723.HiddenStatic = value;
			}
		}

		// Token: 0x17001BB9 RID: 7097
		// (get) Token: 0x060036BF RID: 14015 RVA: 0x00347AB4 File Offset: 0x00345CB4
		// (set) Token: 0x060036C0 RID: 14016 RVA: 0x00347B68 File Offset: 0x00345D68
		internal bool RadWideLabtoolControlHeadSelection_A7723_HiddenDynamic
		{
			get
			{
				short num = (short)1522605557;
				short num2 = num;
				num = (short)1804475893;
				switch (num2 == num)
				{
				}
				num = (short)2089222144;
				short num3 = num;
				num = (short)429064192;
				if (num != 0)
				{
				}
				num = (short)769916929;
				if (num != 0)
				{
				}
				return this.radWideLabtoolControlHeadSelection_A7723.HiddenDynamic;
			}
			set
			{
				short num = (short)1280843538;
				short num2 = num;
				num = (short)880877330;
				switch (num2 == num)
				{
				}
				num = (short)102039552;
				short num3 = num;
				num = (short)171376641;
				if (num != 0)
				{
				}
				num = (short)1621360640;
				if (num != 0)
				{
				}
				this.radWideLabtoolControlHeadSelection_A7723.HiddenDynamic = value;
			}
		}

		// Token: 0x17001BBA RID: 7098
		// (get) Token: 0x060036C1 RID: 14017 RVA: 0x00347C1C File Offset: 0x00345E1C
		public bool RadWideLabtoolControlHeadSelection_A7723_HasDiffs
		{
			get
			{
				short num = (short)1511663178;
				short num2 = num;
				num = (short)1700603466;
				switch (num2 == num)
				{
				}
				num = (short)898564096;
				short num3 = num;
				num = (short)1469841408;
				if (num != 0)
				{
				}
				num = (short)1269432321;
				if (num != 0)
				{
				}
				return this.radWideLabtoolControlHeadSelection_A7723._HasDiffs;
			}
		}

		// Token: 0x17001BBB RID: 7099
		// (get) Token: 0x060036C2 RID: 14018 RVA: 0x00347CD4 File Offset: 0x00345ED4
		// (set) Token: 0x060036C3 RID: 14019 RVA: 0x00347D8C File Offset: 0x00345F8C
		public int RadWideLabtoolDisplayContrastConfiguration_A7873Value
		{
			get
			{
				short num = (short)1600094274;
				short num2 = num;
				num = (short)710770754;
				switch (num2 == num)
				{
				}
				num = (short)1276510208;
				short num3 = num;
				num = (short)2116354049;
				if (num != 0)
				{
				}
				num = (short)537526272;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayContrastConfiguration_A7873.Value;
			}
			set
			{
				short num = (short)294503392;
				short num2 = num;
				num = (short)74171360;
				switch (num2 == num)
				{
				}
				num = (short)259653632;
				short num3 = num;
				num = (short)642711553;
				if (num != 0)
				{
				}
				num = (short)1729298432;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisplayContrastConfiguration_A7873.Value = value;
			}
		}

		// Token: 0x17001BBC RID: 7100
		// (get) Token: 0x060036C4 RID: 14020 RVA: 0x00347E44 File Offset: 0x00346044
		public global::AcpBusinessLayer.AcpSimpleRangeField RadWideLabtoolDisplayContrastConfiguration_A7873
		{
			get
			{
				short num = (short)1520151296;
				short num2 = num;
				num = (short)1528343296;
				switch (num2 == num)
				{
				}
				num = (short)990052352;
				short num3 = num;
				num = (short)1806565377;
				if (num != 0)
				{
				}
				num = (short)533135360;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayContrastConfiguration_A7873;
			}
		}

		// Token: 0x17001BBD RID: 7101
		// (get) Token: 0x060036C5 RID: 14021 RVA: 0x00347EF8 File Offset: 0x003460F8
		// (set) Token: 0x060036C6 RID: 14022 RVA: 0x00347FAC File Offset: 0x003461AC
		public string RadWideLabtoolDisplayContrastConfiguration_A7873_UIValue
		{
			get
			{
				short num = (short)127422416;
				short num2 = num;
				num = (short)1448038352;
				switch (num2 == num)
				{
				}
				num = (short)2043740160;
				short num3 = num;
				num = (short)208142337;
				if (num != 0)
				{
				}
				num = (short)316407808;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayContrastConfiguration_A7873.UIValue;
			}
			set
			{
				short num = (short)1973354497;
				if (num != 0)
				{
				}
				num = (short)439089282;
				short num2 = num;
				num = (short)1061419138;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1494745088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)349569024;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisplayContrastConfiguration_A7873.UIValue = value;
			}
		}

		// Token: 0x17001BBE RID: 7102
		// (get) Token: 0x060036C7 RID: 14023 RVA: 0x00348064 File Offset: 0x00346264
		// (set) Token: 0x060036C8 RID: 14024 RVA: 0x00348118 File Offset: 0x00346318
		public string RadWideLabtoolDisplayContrastConfiguration_A7873_HexUIValue
		{
			get
			{
				short num = (short)1219784133;
				short num2 = num;
				num = (short)1544711621;
				switch (num2 == num)
				{
				}
				num = (short)380960768;
				short num3 = num;
				num = (short)128253953;
				if (num != 0)
				{
				}
				num = (short)2085158912;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayContrastConfiguration_A7873.HexUIValue;
			}
			set
			{
				short num = (short)1502243657;
				short num2 = num;
				num = (short)1024355145;
				switch (num2 == num)
				{
				}
				num = (short)363986944;
				short num3 = num;
				num = (short)1171914752;
				if (num != 0)
				{
				}
				num = (short)895877121;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisplayContrastConfiguration_A7873.HexUIValue = value;
			}
		}

		// Token: 0x17001BBF RID: 7103
		// (get) Token: 0x060036C9 RID: 14025 RVA: 0x003481CC File Offset: 0x003463CC
		// (set) Token: 0x060036CA RID: 14026 RVA: 0x00348284 File Offset: 0x00346484
		internal int RadWideLabtoolDisplayContrastConfiguration_A7873Min
		{
			get
			{
				short num = (short)1175793196;
				short num2 = num;
				num = (short)648293932;
				switch (num2 == num)
				{
				}
				num = (short)653262848;
				short num3 = num;
				num = (short)1424031745;
				if (num != 0)
				{
				}
				num = (short)633733120;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayContrastConfiguration_A7873.Min;
			}
			set
			{
				short num = (short)1244397569;
				if (num != 0)
				{
				}
				num = (short)330107214;
				short num2 = num;
				num = (short)529598798;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1321205760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1172832256;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisplayContrastConfiguration_A7873.Min = value;
			}
		}

		// Token: 0x17001BC0 RID: 7104
		// (get) Token: 0x060036CB RID: 14027 RVA: 0x00348338 File Offset: 0x00346538
		// (set) Token: 0x060036CC RID: 14028 RVA: 0x003483EC File Offset: 0x003465EC
		internal int RadWideLabtoolDisplayContrastConfiguration_A7873Max
		{
			get
			{
				short num = (short)206493563;
				short num2 = num;
				num = (short)1696716667;
				switch (num2 == num)
				{
				}
				num = (short)153288704;
				short num3 = num;
				num = (short)1955725313;
				if (num != 0)
				{
				}
				num = (short)1593901056;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayContrastConfiguration_A7873.Max;
			}
			set
			{
				short num = (short)171392210;
				short num2 = num;
				num = (short)1876704466;
				switch (num2 == num)
				{
				}
				num = (short)1625096192;
				short num3 = num;
				num = (short)1100939264;
				if (num != 0)
				{
				}
				num = (short)255524865;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisplayContrastConfiguration_A7873.Max = value;
			}
		}

		// Token: 0x17001BC1 RID: 7105
		// (get) Token: 0x060036CD RID: 14029 RVA: 0x003484A0 File Offset: 0x003466A0
		// (set) Token: 0x060036CE RID: 14030 RVA: 0x00348554 File Offset: 0x00346754
		internal int RadWideLabtoolDisplayContrastConfiguration_A7873Step
		{
			get
			{
				short num = (short)606244545;
				short num2 = num;
				num = (short)998149825;
				switch (num2 == num)
				{
				}
				num = (short)1174929408;
				short num3 = num;
				num = (short)383975425;
				if (num != 0)
				{
				}
				num = (short)4587520;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayContrastConfiguration_A7873.StepSize;
			}
			set
			{
				short num = (short)1084653616;
				short num2 = num;
				num = (short)1940488240;
				switch (num2 == num)
				{
				}
				num = (short)1964244992;
				short num3 = num;
				num = (short)410058752;
				if (num != 0)
				{
				}
				num = (short)40239105;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisplayContrastConfiguration_A7873.StepSize = value;
			}
		}

		// Token: 0x17001BC2 RID: 7106
		// (get) Token: 0x060036CF RID: 14031 RVA: 0x00348608 File Offset: 0x00346808
		// (set) Token: 0x060036D0 RID: 14032 RVA: 0x003486C0 File Offset: 0x003468C0
		public bool RadWideLabtoolDisplayContrastConfiguration_A7873_Applicable
		{
			get
			{
				short num = (short)287629182;
				short num2 = num;
				num = (short)423026558;
				switch (num2 == num)
				{
				}
				num = (short)1370292224;
				short num3 = num;
				num = (short)15466496;
				if (num != 0)
				{
				}
				num = (short)1402732545;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayContrastConfiguration_A7873.Applicable;
			}
			set
			{
				short num = (short)1561526273;
				if (num != 0)
				{
				}
				num = (short)341355484;
				short num2 = num;
				num = (short)1075489756;
				switch (num2 == num)
				{
				default:
				{
					num = (short)113573888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)945160192;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisplayContrastConfiguration_A7873.Applicable = value;
			}
		}

		// Token: 0x17001BC3 RID: 7107
		// (get) Token: 0x060036D1 RID: 14033 RVA: 0x00348774 File Offset: 0x00346974
		// (set) Token: 0x060036D2 RID: 14034 RVA: 0x0034882C File Offset: 0x00346A2C
		public bool RadWideLabtoolDisplayContrastConfiguration_A7873_Valid
		{
			get
			{
				short num = (short)346676773;
				short num2 = num;
				num = (short)1740824101;
				switch (num2 == num)
				{
				}
				num = (short)866779136;
				short num3 = num;
				num = (short)459276289;
				if (num != 0)
				{
				}
				num = (short)1885077504;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayContrastConfiguration_A7873.Valid;
			}
			set
			{
				short num = (short)1497905388;
				short num2 = num;
				num = (short)791951596;
				switch (num2 == num)
				{
				}
				num = (short)1892417536;
				short num3 = num;
				num = (short)1589248001;
				if (num != 0)
				{
				}
				num = (short)1755578368;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisplayContrastConfiguration_A7873.Valid = value;
			}
		}

		// Token: 0x17001BC4 RID: 7108
		// (get) Token: 0x060036D3 RID: 14035 RVA: 0x003488E0 File Offset: 0x00346AE0
		// (set) Token: 0x060036D4 RID: 14036 RVA: 0x00348994 File Offset: 0x00346B94
		public bool RadWideLabtoolDisplayContrastConfiguration_A7873_Visible
		{
			get
			{
				short num = (short)1645295332;
				short num2 = num;
				num = (short)1132934884;
				switch (num2 == num)
				{
				}
				num = (short)1457127424;
				short num3 = num;
				num = (short)1170210817;
				if (num != 0)
				{
				}
				num = (short)822607872;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayContrastConfiguration_A7873.Visible;
			}
			set
			{
				short num = (short)720834106;
				short num2 = num;
				num = (short)1247219258;
				switch (num2 == num)
				{
				}
				num = (short)1492910080;
				short num3 = num;
				num = (short)1041432576;
				if (num != 0)
				{
				}
				num = (short)716832769;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisplayContrastConfiguration_A7873.Visible = value;
			}
		}

		// Token: 0x17001BC5 RID: 7109
		// (get) Token: 0x060036D5 RID: 14037 RVA: 0x00348A44 File Offset: 0x00346C44
		// (set) Token: 0x060036D6 RID: 14038 RVA: 0x00348AF8 File Offset: 0x00346CF8
		public bool RadWideLabtoolDisplayContrastConfiguration_A7873_Editable
		{
			get
			{
				short num = (short)1210683206;
				short num2 = num;
				num = (short)193367878;
				switch (num2 == num)
				{
				}
				num = (short)945094656;
				short num3 = num;
				num = (short)452526080;
				if (num != 0)
				{
				}
				num = (short)1512308737;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayContrastConfiguration_A7873.Editable;
			}
			set
			{
				short num = (short)1831079567;
				short num2 = num;
				num = (short)892407439;
				switch (num2 == num)
				{
				}
				num = (short)1893466112;
				short num3 = num;
				num = (short)1974009856;
				if (num != 0)
				{
				}
				num = (short)1096744961;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisplayContrastConfiguration_A7873.Editable = value;
			}
		}

		// Token: 0x17001BC6 RID: 7110
		// (get) Token: 0x060036D7 RID: 14039 RVA: 0x00348BB0 File Offset: 0x00346DB0
		internal string RadWideLabtoolDisplayContrastConfiguration_A7873_UILabel
		{
			get
			{
				short num = (short)1924094924;
				short num2 = num;
				num = (short)291199948;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1016266752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1778712576;
				if (num != 0)
				{
				}
				num = (short)542703617;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayContrastConfiguration_A7873.UIName;
			}
		}

		// Token: 0x17001BC7 RID: 7111
		// (get) Token: 0x060036D8 RID: 14040 RVA: 0x00348C64 File Offset: 0x00346E64
		// (set) Token: 0x060036D9 RID: 14041 RVA: 0x00348D18 File Offset: 0x00346F18
		internal bool RadWideLabtoolDisplayContrastConfiguration_A7873_HiddenStatic
		{
			get
			{
				short num = (short)1775068460;
				short num2 = num;
				num = (short)515269932;
				switch (num2 == num)
				{
				default:
				{
					num = (short)752943104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1549533185;
				if (num != 0)
				{
				}
				num = (short)2044592128;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayContrastConfiguration_A7873.HiddenStatic;
			}
			set
			{
				short num = (short)1855562653;
				short num2 = num;
				num = (short)1592632221;
				switch (num2 == num)
				{
				default:
				{
					num = (short)358612992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1438253057;
				if (num != 0)
				{
				}
				num = (short)687800320;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisplayContrastConfiguration_A7873.HiddenStatic = value;
			}
		}

		// Token: 0x17001BC8 RID: 7112
		// (get) Token: 0x060036DA RID: 14042 RVA: 0x00348DD0 File Offset: 0x00346FD0
		// (set) Token: 0x060036DB RID: 14043 RVA: 0x00348E88 File Offset: 0x00347088
		internal bool RadWideLabtoolDisplayContrastConfiguration_A7873_HiddenDynamic
		{
			get
			{
				short num = (short)1562507851;
				short num2 = num;
				num = (short)213187147;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1849622528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1496973313;
				if (num != 0)
				{
				}
				num = (short)1335951360;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayContrastConfiguration_A7873.HiddenDynamic;
			}
			set
			{
				short num = (short)1938439421;
				short num2 = num;
				num = (short)1274690813;
				switch (num2 == num)
				{
				default:
				{
					num = (short)850722816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1852112897;
				if (num != 0)
				{
				}
				num = (short)156958720;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisplayContrastConfiguration_A7873.HiddenDynamic = value;
			}
		}

		// Token: 0x17001BC9 RID: 7113
		// (get) Token: 0x060036DC RID: 14044 RVA: 0x00348F40 File Offset: 0x00347140
		public bool RadWideLabtoolDisplayContrastConfiguration_A7873_HasDiffs
		{
			get
			{
				short num = (short)1864564737;
				if (num != 0)
				{
				}
				num = (short)1365770240;
				short num2 = num;
				num = (short)1428072042;
				short num3 = num;
				num = (short)157132394;
				switch (num3 == num)
				{
				}
				num = (short)1874001920;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayContrastConfiguration_A7873._HasDiffs;
			}
		}

		// Token: 0x17001BCA RID: 7114
		// (get) Token: 0x060036DD RID: 14045 RVA: 0x00348FF4 File Offset: 0x003471F4
		// (set) Token: 0x060036DE RID: 14046 RVA: 0x003490A8 File Offset: 0x003472A8
		public bool RadWideLabtoolFatalError_A8015Value
		{
			get
			{
				short num = (short)1954938881;
				if (num != 0)
				{
				}
				num = (short)1358036992;
				short num2 = num;
				num = (short)427769337;
				short num3 = num;
				num = (short)278347257;
				switch (num3 == num)
				{
				}
				num = (short)1600782336;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFatalError_A8015.Value;
			}
			set
			{
				short num = (short)750911489;
				if (num != 0)
				{
				}
				num = (short)1940586496;
				short num2 = num;
				num = (short)448768395;
				short num3 = num;
				num = (short)1338550667;
				switch (num3 == num)
				{
				}
				num = (short)1431437312;
				if (num != 0)
				{
				}
				this.radWideLabtoolFatalError_A8015.Value = value;
			}
		}

		// Token: 0x17001BCB RID: 7115
		// (get) Token: 0x060036DF RID: 14047 RVA: 0x00349160 File Offset: 0x00347360
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolFatalError_A8015
		{
			get
			{
				short num = (short)1571968051;
				short num2 = num;
				num = (short)663639091;
				switch (num2 == num)
				{
				default:
				{
					num = (short)837222400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)866779137;
				if (num != 0)
				{
				}
				num = (short)924385280;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFatalError_A8015;
			}
		}

		// Token: 0x17001BCC RID: 7116
		// (get) Token: 0x060036E0 RID: 14048 RVA: 0x0034920C File Offset: 0x0034740C
		// (set) Token: 0x060036E1 RID: 14049 RVA: 0x003492C4 File Offset: 0x003474C4
		public bool RadWideLabtoolFatalError_A8015_UIValue
		{
			get
			{
				short num = (short)1094741658;
				short num2 = num;
				num = (short)1148546714;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2011758592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1609629696;
				if (num != 0)
				{
				}
				num = (short)2002190337;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFatalError_A8015.Value;
			}
			set
			{
				short num = (short)1523237546;
				short num2 = num;
				num = (short)1546896042;
				switch (num2 == num)
				{
				default:
				{
					num = (short)663420928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)678625280;
				if (num != 0)
				{
				}
				num = (short)1427701761;
				if (num != 0)
				{
				}
				this.radWideLabtoolFatalError_A8015.Value = value;
			}
		}

		// Token: 0x17001BCD RID: 7117
		// (get) Token: 0x060036E2 RID: 14050 RVA: 0x0034937C File Offset: 0x0034757C
		// (set) Token: 0x060036E3 RID: 14051 RVA: 0x00349434 File Offset: 0x00347634
		public bool RadWideLabtoolFatalError_A8015_Applicable
		{
			get
			{
				short num = (short)1083244545;
				if (num != 0)
				{
				}
				num = (short)54525952;
				short num2 = num;
				num = (short)2012727141;
				short num3 = num;
				num = (short)680314725;
				switch (num3 == num)
				{
				}
				num = (short)103088128;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFatalError_A8015.Applicable;
			}
			set
			{
				short num = (short)201432058;
				short num2 = num;
				num = (short)848927738;
				switch (num2 == num)
				{
				default:
				{
					num = (short)852164608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1950547969;
				if (num != 0)
				{
				}
				num = (short)1917714432;
				if (num != 0)
				{
				}
				this.radWideLabtoolFatalError_A8015.Applicable = value;
			}
		}

		// Token: 0x17001BCE RID: 7118
		// (get) Token: 0x060036E4 RID: 14052 RVA: 0x003494EC File Offset: 0x003476EC
		// (set) Token: 0x060036E5 RID: 14053 RVA: 0x003495A0 File Offset: 0x003477A0
		public bool RadWideLabtoolFatalError_A8015_Valid
		{
			get
			{
				short num = (short)915736825;
				short num2 = num;
				num = (short)1810172153;
				switch (num2 == num)
				{
				default:
				{
					num = (short)481755136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1242628097;
				if (num != 0)
				{
				}
				num = (short)1817509888;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFatalError_A8015.Valid;
			}
			set
			{
				short num = (short)36765697;
				if (num != 0)
				{
				}
				num = (short)1431437312;
				short num2 = num;
				num = (short)1723014405;
				short num3 = num;
				num = (short)381689093;
				switch (num3 == num)
				{
				}
				num = (short)1909915648;
				if (num != 0)
				{
				}
				this.radWideLabtoolFatalError_A8015.Valid = value;
			}
		}

		// Token: 0x17001BCF RID: 7119
		// (get) Token: 0x060036E6 RID: 14054 RVA: 0x00349654 File Offset: 0x00347854
		// (set) Token: 0x060036E7 RID: 14055 RVA: 0x00349708 File Offset: 0x00347908
		public bool RadWideLabtoolFatalError_A8015_Visible
		{
			get
			{
				short num = (short)1691071486;
				short num2 = num;
				num = (short)558150654;
				switch (num2 == num)
				{
				default:
				{
					num = (short)632029184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1282080768;
				if (num != 0)
				{
				}
				num = (short)1638662145;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFatalError_A8015.Visible;
			}
			set
			{
				short num = (short)1225805099;
				short num2 = num;
				num = (short)581193003;
				switch (num2 == num)
				{
				default:
				{
					num = (short)17235968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)173211648;
				if (num != 0)
				{
				}
				num = (short)611844097;
				if (num != 0)
				{
				}
				this.radWideLabtoolFatalError_A8015.Visible = value;
			}
		}

		// Token: 0x17001BD0 RID: 7120
		// (get) Token: 0x060036E8 RID: 14056 RVA: 0x003497C0 File Offset: 0x003479C0
		// (set) Token: 0x060036E9 RID: 14057 RVA: 0x00349874 File Offset: 0x00347A74
		public bool RadWideLabtoolFatalError_A8015_Editable
		{
			get
			{
				short num = (short)1292326605;
				short num2 = num;
				num = (short)1785747149;
				switch (num2 == num)
				{
				default:
				{
					num = (short)677576704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1665990656;
				if (num != 0)
				{
				}
				num = (short)1102774273;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFatalError_A8015.Editable;
			}
			set
			{
				short num = (short)2033560096;
				short num2 = num;
				num = (short)495036960;
				switch (num2 == num)
				{
				default:
				{
					num = (short)923402240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)650772480;
				if (num != 0)
				{
				}
				num = (short)1046806529;
				if (num != 0)
				{
				}
				this.radWideLabtoolFatalError_A8015.Editable = value;
			}
		}

		// Token: 0x17001BD1 RID: 7121
		// (get) Token: 0x060036EA RID: 14058 RVA: 0x0034992C File Offset: 0x00347B2C
		internal string RadWideLabtoolFatalError_A8015_UILabel
		{
			get
			{
				short num = (short)2003351147;
				short num2 = num;
				num = (short)358856299;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1358626816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1605173249;
				if (num != 0)
				{
				}
				num = (short)1701511168;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFatalError_A8015.UIName;
			}
		}

		// Token: 0x17001BD2 RID: 7122
		// (get) Token: 0x060036EB RID: 14059 RVA: 0x003499E0 File Offset: 0x00347BE0
		// (set) Token: 0x060036EC RID: 14060 RVA: 0x00349A94 File Offset: 0x00347C94
		internal bool RadWideLabtoolFatalError_A8015_HiddenStatic
		{
			get
			{
				short num = (short)687543414;
				short num2 = num;
				num = (short)185799798;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1926365184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1581776896;
				if (num != 0)
				{
				}
				num = (short)2132934657;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFatalError_A8015.HiddenStatic;
			}
			set
			{
				short num = (short)1158624730;
				short num2 = num;
				num = (short)1538536922;
				switch (num2 == num)
				{
				default:
				{
					num = (short)557252608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)152895488;
				if (num != 0)
				{
				}
				num = (short)224788481;
				if (num != 0)
				{
				}
				this.radWideLabtoolFatalError_A8015.HiddenStatic = value;
			}
		}

		// Token: 0x17001BD3 RID: 7123
		// (get) Token: 0x060036ED RID: 14061 RVA: 0x00349B4C File Offset: 0x00347D4C
		// (set) Token: 0x060036EE RID: 14062 RVA: 0x00349C04 File Offset: 0x00347E04
		internal bool RadWideLabtoolFatalError_A8015_HiddenDynamic
		{
			get
			{
				short num = (short)803070333;
				short num2 = num;
				num = (short)582607229;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2030895104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1918631937;
				if (num != 0)
				{
				}
				num = (short)950403072;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFatalError_A8015.HiddenDynamic;
			}
			set
			{
				short num = (short)1856797937;
				short num2 = num;
				num = (short)633699569;
				switch (num2 == num)
				{
				default:
				{
					num = (short)813891584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)316801024;
				if (num != 0)
				{
				}
				num = (short)1337917441;
				if (num != 0)
				{
				}
				this.radWideLabtoolFatalError_A8015.HiddenDynamic = value;
			}
		}

		// Token: 0x17001BD4 RID: 7124
		// (get) Token: 0x060036EF RID: 14063 RVA: 0x00349CBC File Offset: 0x00347EBC
		public bool RadWideLabtoolFatalError_A8015_HasDiffs
		{
			get
			{
				short num = (short)1920008193;
				if (num != 0)
				{
				}
				num = (short)2015559680;
				short num2 = num;
				num = (short)411845479;
				short num3 = num;
				num = (short)844710759;
				switch (num3 == num)
				{
				}
				num = (short)833093632;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFatalError_A8015._HasDiffs;
			}
		}

		// Token: 0x17001BD5 RID: 7125
		// (get) Token: 0x060036F0 RID: 14064 RVA: 0x00349D70 File Offset: 0x00347F70
		// (set) Token: 0x060036F1 RID: 14065 RVA: 0x00349E24 File Offset: 0x00348024
		public bool RadWideLabtoolFlipDisplayOption_A8140Value
		{
			get
			{
				short num = (short)1850421521;
				short num2 = num;
				num = (short)4534545;
				switch (num2 == num)
				{
				default:
				{
					num = (short)161415168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1416691713;
				if (num != 0)
				{
				}
				num = (short)140836864;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFlipDisplayOption_A8140.Value;
			}
			set
			{
				short num = (short)267069934;
				short num2 = num;
				num = (short)1092102638;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1446576128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1646592001;
				if (num != 0)
				{
				}
				num = (short)590348288;
				if (num != 0)
				{
				}
				this.radWideLabtoolFlipDisplayOption_A8140.Value = value;
			}
		}

		// Token: 0x17001BD6 RID: 7126
		// (get) Token: 0x060036F2 RID: 14066 RVA: 0x00349EDC File Offset: 0x003480DC
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolFlipDisplayOption_A8140
		{
			get
			{
				short num = (short)1323258349;
				short num2 = num;
				num = (short)289624557;
				switch (num2 == num)
				{
				default:
				{
					num = (short)617611264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1386938368;
				if (num != 0)
				{
				}
				num = (short)1415970817;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFlipDisplayOption_A8140;
			}
		}

		// Token: 0x17001BD7 RID: 7127
		// (get) Token: 0x060036F3 RID: 14067 RVA: 0x00349F8C File Offset: 0x0034818C
		// (set) Token: 0x060036F4 RID: 14068 RVA: 0x0034A040 File Offset: 0x00348240
		public bool RadWideLabtoolFlipDisplayOption_A8140_UIValue
		{
			get
			{
				short num = (short)846341235;
				short num2 = num;
				num = (short)359801971;
				switch (num2 == num)
				{
				default:
				{
					num = (short)24576000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)730529792;
				if (num != 0)
				{
				}
				num = (short)1305673729;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFlipDisplayOption_A8140.Value;
			}
			set
			{
				short num = (short)441188353;
				if (num != 0)
				{
				}
				num = (short)577830912;
				short num2 = num;
				num = (short)2019064988;
				short num3 = num;
				num = (short)1235844252;
				switch (num3 == num)
				{
				}
				num = (short)2114060288;
				if (num != 0)
				{
				}
				this.radWideLabtoolFlipDisplayOption_A8140.Value = value;
			}
		}

		// Token: 0x17001BD8 RID: 7128
		// (get) Token: 0x060036F5 RID: 14069 RVA: 0x0034A0F8 File Offset: 0x003482F8
		// (set) Token: 0x060036F6 RID: 14070 RVA: 0x0034A1B0 File Offset: 0x003483B0
		public bool RadWideLabtoolFlipDisplayOption_A8140_Applicable
		{
			get
			{
				short num = (short)1496413183;
				short num2 = num;
				num = (short)2098033663;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1894318080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1410072577;
				if (num != 0)
				{
				}
				num = (short)1718943744;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFlipDisplayOption_A8140.Applicable;
			}
			set
			{
				short num = (short)1910902714;
				short num2 = num;
				num = (short)1538789306;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1433796608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1814364160;
				if (num != 0)
				{
				}
				num = (short)1746731009;
				if (num != 0)
				{
				}
				this.radWideLabtoolFlipDisplayOption_A8140.Applicable = value;
			}
		}

		// Token: 0x17001BD9 RID: 7129
		// (get) Token: 0x060036F7 RID: 14071 RVA: 0x0034A268 File Offset: 0x00348468
		// (set) Token: 0x060036F8 RID: 14072 RVA: 0x0034A31C File Offset: 0x0034851C
		public bool RadWideLabtoolFlipDisplayOption_A8140_Valid
		{
			get
			{
				short num = (short)1086754763;
				short num2 = num;
				num = (short)1006407627;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1475739648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)501219328;
				if (num != 0)
				{
				}
				num = (short)211222529;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFlipDisplayOption_A8140.Valid;
			}
			set
			{
				short num = (short)1953431553;
				if (num != 0)
				{
				}
				num = (short)274989056;
				short num2 = num;
				num = (short)607655866;
				short num3 = num;
				num = (short)1520703418;
				switch (num3 == num)
				{
				}
				num = (short)312934400;
				if (num != 0)
				{
				}
				this.radWideLabtoolFlipDisplayOption_A8140.Valid = value;
			}
		}

		// Token: 0x17001BDA RID: 7130
		// (get) Token: 0x060036F9 RID: 14073 RVA: 0x0034A3D0 File Offset: 0x003485D0
		// (set) Token: 0x060036FA RID: 14074 RVA: 0x0034A484 File Offset: 0x00348684
		public bool RadWideLabtoolFlipDisplayOption_A8140_Visible
		{
			get
			{
				short num = (short)1783047286;
				short num2 = num;
				num = (short)741745782;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1574633472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1438187521;
				if (num != 0)
				{
				}
				num = (short)1276968960;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFlipDisplayOption_A8140.Visible;
			}
			set
			{
				short num = (short)2036948659;
				short num2 = num;
				num = (short)1790140083;
				switch (num2 == num)
				{
				default:
				{
					num = (short)440270848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1007616000;
				if (num != 0)
				{
				}
				num = (short)333971457;
				if (num != 0)
				{
				}
				this.radWideLabtoolFlipDisplayOption_A8140.Visible = value;
			}
		}

		// Token: 0x17001BDB RID: 7131
		// (get) Token: 0x060036FB RID: 14075 RVA: 0x0034A538 File Offset: 0x00348738
		// (set) Token: 0x060036FC RID: 14076 RVA: 0x0034A5EC File Offset: 0x003487EC
		public bool RadWideLabtoolFlipDisplayOption_A8140_Editable
		{
			get
			{
				short num = (short)1331627874;
				short num2 = num;
				num = (short)1774716770;
				switch (num2 == num)
				{
				default:
				{
					num = (short)304545792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)396034048;
				if (num != 0)
				{
				}
				num = (short)24576001;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFlipDisplayOption_A8140.Editable;
			}
			set
			{
				short num = (short)289953156;
				short num2 = num;
				num = (short)1503876484;
				switch (num2 == num)
				{
				default:
				{
					num = (short)372703232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2293761;
				if (num != 0)
				{
				}
				num = (short)1500905472;
				if (num != 0)
				{
				}
				this.radWideLabtoolFlipDisplayOption_A8140.Editable = value;
			}
		}

		// Token: 0x17001BDC RID: 7132
		// (get) Token: 0x060036FD RID: 14077 RVA: 0x0034A6A4 File Offset: 0x003488A4
		internal string RadWideLabtoolFlipDisplayOption_A8140_UILabel
		{
			get
			{
				short num = (short)1260043140;
				short num2 = num;
				num = (short)1118419844;
				switch (num2 == num)
				{
				default:
				{
					num = (short)646447104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)231735297;
				if (num != 0)
				{
				}
				num = (short)696713216;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFlipDisplayOption_A8140.UIName;
			}
		}

		// Token: 0x17001BDD RID: 7133
		// (get) Token: 0x060036FE RID: 14078 RVA: 0x0034A75C File Offset: 0x0034895C
		// (set) Token: 0x060036FF RID: 14079 RVA: 0x0034A814 File Offset: 0x00348A14
		internal bool RadWideLabtoolFlipDisplayOption_A8140_HiddenStatic
		{
			get
			{
				short num = (short)555861851;
				short num2 = num;
				num = (short)477480795;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1314717696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)28835841;
				if (num != 0)
				{
				}
				num = (short)97910784;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFlipDisplayOption_A8140.HiddenStatic;
			}
			set
			{
				short num = (short)1428172111;
				short num2 = num;
				num = (short)1164848463;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1895235584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1495924737;
				if (num != 0)
				{
				}
				num = (short)2051735552;
				if (num != 0)
				{
				}
				this.radWideLabtoolFlipDisplayOption_A8140.HiddenStatic = value;
			}
		}

		// Token: 0x17001BDE RID: 7134
		// (get) Token: 0x06003700 RID: 14080 RVA: 0x0034A8CC File Offset: 0x00348ACC
		// (set) Token: 0x06003701 RID: 14081 RVA: 0x0034A980 File Offset: 0x00348B80
		internal bool RadWideLabtoolFlipDisplayOption_A8140_HiddenDynamic
		{
			get
			{
				short num = (short)1994653697;
				if (num != 0)
				{
				}
				num = (short)290324480;
				short num2 = num;
				num = (short)1628734624;
				short num3 = num;
				num = (short)2009695392;
				switch (num3 == num)
				{
				}
				num = (short)417726464;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFlipDisplayOption_A8140.HiddenDynamic;
			}
			set
			{
				short num = (short)779728154;
				short num2 = num;
				num = (short)481539354;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1309802496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)863830017;
				if (num != 0)
				{
				}
				num = (short)197394432;
				if (num != 0)
				{
				}
				this.radWideLabtoolFlipDisplayOption_A8140.HiddenDynamic = value;
			}
		}

		// Token: 0x17001BDF RID: 7135
		// (get) Token: 0x06003702 RID: 14082 RVA: 0x0034AA34 File Offset: 0x00348C34
		public bool RadWideLabtoolFlipDisplayOption_A8140_HasDiffs
		{
			get
			{
				short num = (short)504981728;
				short num2 = num;
				num = (short)1701079264;
				switch (num2 == num)
				{
				}
				num = (short)1941504001;
				if (num != 0)
				{
				}
				num = (short)663224320;
				short num3 = num;
				num = (short)1566375936;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFlipDisplayOption_A8140._HasDiffs;
			}
		}

		// Token: 0x17001BE0 RID: 7136
		// (get) Token: 0x06003703 RID: 14083 RVA: 0x0034AAE8 File Offset: 0x00348CE8
		// (set) Token: 0x06003704 RID: 14084 RVA: 0x0034AB9C File Offset: 0x00348D9C
		public bool RadWideLabtoolFreeRevolvingRotary_A8147Value
		{
			get
			{
				short num = (short)1707112999;
				short num2 = num;
				num = (short)1413839399;
				switch (num2 == num)
				{
				}
				num = (short)813629440;
				if (num != 0)
				{
				}
				num = (short)1153499136;
				short num3 = num;
				num = (short)217120769;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFreeRevolvingRotary_A8147.Value;
			}
			set
			{
				short num = (short)582403932;
				short num2 = num;
				num = (short)368363356;
				switch (num2 == num)
				{
				}
				num = (short)690880513;
				if (num != 0)
				{
				}
				num = (short)1390542848;
				short num3 = num;
				num = (short)761397248;
				if (num != 0)
				{
				}
				this.radWideLabtoolFreeRevolvingRotary_A8147.Value = value;
			}
		}

		// Token: 0x17001BE1 RID: 7137
		// (get) Token: 0x06003705 RID: 14085 RVA: 0x0034AC50 File Offset: 0x00348E50
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolFreeRevolvingRotary_A8147
		{
			get
			{
				short num = (short)1026024502;
				short num2 = num;
				num = (short)1919804470;
				switch (num2 == num)
				{
				}
				num = (short)2067333121;
				if (num != 0)
				{
				}
				num = (short)2121531392;
				short num3 = num;
				num = (short)114229248;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFreeRevolvingRotary_A8147;
			}
		}

		// Token: 0x17001BE2 RID: 7138
		// (get) Token: 0x06003706 RID: 14086 RVA: 0x0034AD00 File Offset: 0x00348F00
		// (set) Token: 0x06003707 RID: 14087 RVA: 0x0034ADB4 File Offset: 0x00348FB4
		public bool RadWideLabtoolFreeRevolvingRotary_A8147_UIValue
		{
			get
			{
				short num = (short)1442043524;
				short num2 = num;
				num = (short)1689179780;
				switch (num2 == num)
				{
				}
				num = (short)77725697;
				if (num != 0)
				{
				}
				num = (short)1925382144;
				short num3 = num;
				num = (short)1693188096;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFreeRevolvingRotary_A8147.Value;
			}
			set
			{
				short num = (short)1362821121;
				if (num != 0)
				{
				}
				num = (short)1039240918;
				short num2 = num;
				num = (short)683183830;
				switch (num2 == num)
				{
				}
				num = (short)628621312;
				short num3 = num;
				num = (short)1973551104;
				if (num != 0)
				{
				}
				this.radWideLabtoolFreeRevolvingRotary_A8147.Value = value;
			}
		}

		// Token: 0x17001BE3 RID: 7139
		// (get) Token: 0x06003708 RID: 14088 RVA: 0x0034AE6C File Offset: 0x0034906C
		// (set) Token: 0x06003709 RID: 14089 RVA: 0x0034AF24 File Offset: 0x00349124
		public bool RadWideLabtoolFreeRevolvingRotary_A8147_Applicable
		{
			get
			{
				short num = (short)310848039;
				short num2 = num;
				num = (short)1938303527;
				switch (num2 == num)
				{
				}
				num = (short)897581057;
				if (num != 0)
				{
				}
				num = (short)1274150912;
				short num3 = num;
				num = (short)365101056;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFreeRevolvingRotary_A8147.Applicable;
			}
			set
			{
				short num = (short)327216065;
				short num2 = num;
				num = (short)1773661121;
				switch (num2 == num)
				{
				}
				num = (short)523960321;
				if (num != 0)
				{
				}
				num = (short)2063728640;
				short num3 = num;
				num = (short)402587648;
				if (num != 0)
				{
				}
				this.radWideLabtoolFreeRevolvingRotary_A8147.Applicable = value;
			}
		}

		// Token: 0x17001BE4 RID: 7140
		// (get) Token: 0x0600370A RID: 14090 RVA: 0x0034AFD8 File Offset: 0x003491D8
		// (set) Token: 0x0600370B RID: 14091 RVA: 0x0034B08C File Offset: 0x0034928C
		public bool RadWideLabtoolFreeRevolvingRotary_A8147_Valid
		{
			get
			{
				short num = (short)1819402263;
				short num2 = num;
				num = (short)928374807;
				switch (num2 == num)
				{
				}
				num = (short)2041839616;
				if (num != 0)
				{
				}
				num = (short)914227200;
				short num3 = num;
				num = (short)508755969;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFreeRevolvingRotary_A8147.Valid;
			}
			set
			{
				short num = (short)287113217;
				if (num != 0)
				{
				}
				num = (short)1131504665;
				short num2 = num;
				num = (short)852976665;
				switch (num2 == num)
				{
				}
				num = (short)1993408512;
				short num3 = num;
				num = (short)225837056;
				if (num != 0)
				{
				}
				this.radWideLabtoolFreeRevolvingRotary_A8147.Valid = value;
			}
		}

		// Token: 0x17001BE5 RID: 7141
		// (get) Token: 0x0600370C RID: 14092 RVA: 0x0034B144 File Offset: 0x00349344
		// (set) Token: 0x0600370D RID: 14093 RVA: 0x0034B1F8 File Offset: 0x003493F8
		public bool RadWideLabtoolFreeRevolvingRotary_A8147_Visible
		{
			get
			{
				short num = (short)45406427;
				short num2 = num;
				num = (short)872995035;
				switch (num2 == num)
				{
				}
				num = (short)720306177;
				if (num != 0)
				{
				}
				num = (short)1014038528;
				short num3 = num;
				num = (short)722534400;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFreeRevolvingRotary_A8147.Visible;
			}
			set
			{
				short num = (short)260964353;
				if (num != 0)
				{
				}
				num = (short)558955033;
				short num2 = num;
				num = (short)462092825;
				switch (num2 == num)
				{
				}
				num = (short)1719009280;
				short num3 = num;
				num = (short)1687355392;
				if (num != 0)
				{
				}
				this.radWideLabtoolFreeRevolvingRotary_A8147.Visible = value;
			}
		}

		// Token: 0x17001BE6 RID: 7142
		// (get) Token: 0x0600370E RID: 14094 RVA: 0x0034B2B4 File Offset: 0x003494B4
		// (set) Token: 0x0600370F RID: 14095 RVA: 0x0034B364 File Offset: 0x00349564
		public bool RadWideLabtoolFreeRevolvingRotary_A8147_Editable
		{
			get
			{
				short num = (short)84672513;
				if (num != 0)
				{
				}
				num = (short)1532175857;
				short num2 = num;
				num = (short)62268913;
				switch (num2 == num)
				{
				}
				num = (short)1060306944;
				short num3 = num;
				num = (short)740687872;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFreeRevolvingRotary_A8147.Editable;
			}
			set
			{
				short num = (short)573046785;
				if (num != 0)
				{
				}
				num = (short)127042478;
				short num2 = num;
				num = (short)2007270318;
				switch (num2 == num)
				{
				}
				num = (short)83165184;
				short num3 = num;
				num = (short)1315897344;
				if (num != 0)
				{
				}
				this.radWideLabtoolFreeRevolvingRotary_A8147.Editable = value;
			}
		}

		// Token: 0x17001BE7 RID: 7143
		// (get) Token: 0x06003710 RID: 14096 RVA: 0x0034B41C File Offset: 0x0034961C
		internal string RadWideLabtoolFreeRevolvingRotary_A8147_UILabel
		{
			get
			{
				short num = (short)1763321515;
				short num2 = num;
				num = (short)1587422891;
				switch (num2 == num)
				{
				}
				num = (short)529596417;
				if (num != 0)
				{
				}
				num = (short)289734656;
				short num3 = num;
				num = (short)636485632;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFreeRevolvingRotary_A8147.UIName;
			}
		}

		// Token: 0x17001BE8 RID: 7144
		// (get) Token: 0x06003711 RID: 14097 RVA: 0x0034B4D0 File Offset: 0x003496D0
		// (set) Token: 0x06003712 RID: 14098 RVA: 0x0034B584 File Offset: 0x00349784
		internal bool RadWideLabtoolFreeRevolvingRotary_A8147_HiddenStatic
		{
			get
			{
				short num = (short)1389016803;
				short num2 = num;
				num = (short)2075047651;
				switch (num2 == num)
				{
				}
				num = (short)302448641;
				if (num != 0)
				{
				}
				num = (short)879099904;
				short num3 = num;
				num = (short)579600384;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFreeRevolvingRotary_A8147.HiddenStatic;
			}
			set
			{
				short num = (short)106957803;
				short num2 = num;
				num = (short)517671915;
				switch (num2 == num)
				{
				}
				num = (short)713097216;
				if (num != 0)
				{
				}
				num = (short)1594687488;
				short num3 = num;
				num = (short)1524301825;
				if (num != 0)
				{
				}
				this.radWideLabtoolFreeRevolvingRotary_A8147.HiddenStatic = value;
			}
		}

		// Token: 0x17001BE9 RID: 7145
		// (get) Token: 0x06003713 RID: 14099 RVA: 0x0034B638 File Offset: 0x00349838
		// (set) Token: 0x06003714 RID: 14100 RVA: 0x0034B6F0 File Offset: 0x003498F0
		internal bool RadWideLabtoolFreeRevolvingRotary_A8147_HiddenDynamic
		{
			get
			{
				short num = (short)1434483836;
				short num2 = num;
				num = (short)238255228;
				switch (num2 == num)
				{
				}
				num = (short)532742144;
				if (num != 0)
				{
				}
				num = (short)1811742720;
				short num3 = num;
				num = (short)14548993;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFreeRevolvingRotary_A8147.HiddenDynamic;
			}
			set
			{
				short num = (short)222227468;
				short num2 = num;
				num = (short)1815997452;
				switch (num2 == num)
				{
				}
				num = (short)1710227457;
				if (num != 0)
				{
				}
				num = (short)1340801024;
				short num3 = num;
				num = (short)318308352;
				if (num != 0)
				{
				}
				this.radWideLabtoolFreeRevolvingRotary_A8147.HiddenDynamic = value;
			}
		}

		// Token: 0x17001BEA RID: 7146
		// (get) Token: 0x06003715 RID: 14101 RVA: 0x0034B7A4 File Offset: 0x003499A4
		public bool RadWideLabtoolFreeRevolvingRotary_A8147_HasDiffs
		{
			get
			{
				short num = (short)933070104;
				short num2 = num;
				num = (short)1215071512;
				switch (num2 == num)
				{
				}
				num = (short)1951662081;
				if (num != 0)
				{
				}
				num = (short)1440415744;
				short num3 = num;
				num = (short)865927168;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFreeRevolvingRotary_A8147._HasDiffs;
			}
		}

		// Token: 0x17001BEB RID: 7147
		// (get) Token: 0x06003716 RID: 14102 RVA: 0x0034B85C File Offset: 0x00349A5C
		// (set) Token: 0x06003717 RID: 14103 RVA: 0x0034B910 File Offset: 0x00349B10
		public int RadWideLabtoolKeypadType_A8372Value
		{
			get
			{
				short num = (short)1954666390;
				short num2 = num;
				num = (short)1446631318;
				switch (num2 == num)
				{
				}
				num = (short)631767041;
				if (num != 0)
				{
				}
				num = (short)1899692032;
				short num3 = num;
				num = (short)1547567104;
				if (num != 0)
				{
				}
				return this.radWideLabtoolKeypadType_A8372.Value;
			}
			set
			{
				short num = (short)265943706;
				short num2 = num;
				num = (short)838793882;
				switch (num2 == num)
				{
				}
				num = (short)740163585;
				if (num != 0)
				{
				}
				num = (short)533987328;
				short num3 = num;
				num = (short)1807089664;
				if (num != 0)
				{
				}
				this.radWideLabtoolKeypadType_A8372.Value = value;
			}
		}

		// Token: 0x17001BEC RID: 7148
		// (get) Token: 0x06003718 RID: 14104 RVA: 0x0034B9C8 File Offset: 0x00349BC8
		// (set) Token: 0x06003719 RID: 14105 RVA: 0x0034BA7C File Offset: 0x00349C7C
		public string RadWideLabtoolKeypadType_A8372_UIValue
		{
			get
			{
				short num = (short)827392001;
				if (num != 0)
				{
				}
				num = (short)1515565808;
				short num2 = num;
				num = (short)1487319792;
				switch (num2 == num)
				{
				}
				num = (short)1631322112;
				short num3 = num;
				num = (short)295501824;
				if (num != 0)
				{
				}
				return this.radWideLabtoolKeypadType_A8372.UIValue;
			}
			set
			{
				short num = (short)911081473;
				if (num != 0)
				{
				}
				num = (short)1810184089;
				short num2 = num;
				num = (short)90257305;
				switch (num2 == num)
				{
				}
				num = (short)1474035712;
				short num3 = num;
				num = (short)1569718272;
				if (num != 0)
				{
				}
				this.radWideLabtoolKeypadType_A8372.UIValue = value;
			}
		}

		// Token: 0x17001BED RID: 7149
		// (get) Token: 0x0600371A RID: 14106 RVA: 0x0034BB34 File Offset: 0x00349D34
		public global::AcpBusinessLayer.AcpListField RadWideLabtoolKeypadType_A8372
		{
			get
			{
				short num = (short)1113228351;
				short num2 = num;
				num = (short)2022278207;
				switch (num2 == num)
				{
				}
				num = (short)711524353;
				if (num != 0)
				{
				}
				num = (short)1923416064;
				short num3 = num;
				num = (short)74907648;
				if (num != 0)
				{
				}
				return this.radWideLabtoolKeypadType_A8372;
			}
		}

		// Token: 0x17001BEE RID: 7150
		// (get) Token: 0x0600371B RID: 14107 RVA: 0x0034BBE4 File Offset: 0x00349DE4
		// (set) Token: 0x0600371C RID: 14108 RVA: 0x0034BC9C File Offset: 0x00349E9C
		public bool RadWideLabtoolKeypadType_A8372_Applicable
		{
			get
			{
				short num = (short)887415939;
				short num2 = num;
				num = (short)1722147971;
				switch (num2 == num)
				{
				}
				num = (short)1153564672;
				if (num != 0)
				{
				}
				num = (short)342425600;
				short num3 = num;
				num = (short)962854913;
				if (num != 0)
				{
				}
				return this.radWideLabtoolKeypadType_A8372.Applicable;
			}
			set
			{
				short num = (short)73269249;
				if (num != 0)
				{
				}
				num = (short)337624658;
				short num2 = num;
				num = (short)1022934610;
				switch (num2 == num)
				{
				}
				num = (short)1909981184;
				short num3 = num;
				num = (short)562757632;
				if (num != 0)
				{
				}
				this.radWideLabtoolKeypadType_A8372.Applicable = value;
			}
		}

		// Token: 0x17001BEF RID: 7151
		// (get) Token: 0x0600371D RID: 14109 RVA: 0x0034BD54 File Offset: 0x00349F54
		// (set) Token: 0x0600371E RID: 14110 RVA: 0x0034BE08 File Offset: 0x0034A008
		public bool RadWideLabtoolKeypadType_A8372_Valid
		{
			get
			{
				short num = (short)907914395;
				short num2 = num;
				num = (short)2028973211;
				switch (num2 == num)
				{
				}
				num = (short)1169096704;
				if (num != 0)
				{
				}
				num = (short)285212672;
				short num3 = num;
				num = (short)1010171905;
				if (num != 0)
				{
				}
				return this.radWideLabtoolKeypadType_A8372.Valid;
			}
			set
			{
				short num = (short)556398502;
				short num2 = num;
				num = (short)153089958;
				switch (num2 == num)
				{
				}
				num = (short)684326913;
				if (num != 0)
				{
				}
				num = (short)737411072;
				short num3 = num;
				num = (short)44433408;
				if (num != 0)
				{
				}
				this.radWideLabtoolKeypadType_A8372.Valid = value;
			}
		}

		// Token: 0x17001BF0 RID: 7152
		// (get) Token: 0x0600371F RID: 14111 RVA: 0x0034BEC0 File Offset: 0x0034A0C0
		// (set) Token: 0x06003720 RID: 14112 RVA: 0x0034BF74 File Offset: 0x0034A174
		public bool RadWideLabtoolKeypadType_A8372_Visible
		{
			get
			{
				short num = (short)1297612801;
				if (num != 0)
				{
				}
				num = (short)581081928;
				short num2 = num;
				num = (short)559913800;
				switch (num2 == num)
				{
				}
				num = (short)491126784;
				short num3 = num;
				num = (short)54132736;
				if (num != 0)
				{
				}
				return this.radWideLabtoolKeypadType_A8372.Visible;
			}
			set
			{
				short num = (short)1791025861;
				short num2 = num;
				num = (short)605283013;
				switch (num2 == num)
				{
				}
				num = (short)1859256321;
				if (num != 0)
				{
				}
				num = (short)893648896;
				short num3 = num;
				num = (short)2135818240;
				if (num != 0)
				{
				}
				this.radWideLabtoolKeypadType_A8372.Visible = value;
			}
		}

		// Token: 0x17001BF1 RID: 7153
		// (get) Token: 0x06003721 RID: 14113 RVA: 0x0034C028 File Offset: 0x0034A228
		// (set) Token: 0x06003722 RID: 14114 RVA: 0x0034C0DC File Offset: 0x0034A2DC
		public bool RadWideLabtoolKeypadType_A8372_Editable
		{
			get
			{
				short num = (short)232491292;
				short num2 = num;
				num = (short)690456860;
				switch (num2 == num)
				{
				}
				num = (short)1781530625;
				if (num != 0)
				{
				}
				num = (short)533790720;
				short num3 = num;
				num = (short)368115712;
				if (num != 0)
				{
				}
				return this.radWideLabtoolKeypadType_A8372.Editable;
			}
			set
			{
				short num = (short)1752862678;
				short num2 = num;
				num = (short)1085444054;
				switch (num2 == num)
				{
				}
				num = (short)2146041857;
				if (num != 0)
				{
				}
				num = (short)465436672;
				short num3 = num;
				num = (short)1157234688;
				if (num != 0)
				{
				}
				this.radWideLabtoolKeypadType_A8372.Editable = value;
			}
		}

		// Token: 0x17001BF2 RID: 7154
		// (get) Token: 0x06003723 RID: 14115 RVA: 0x0034C190 File Offset: 0x0034A390
		internal string RadWideLabtoolKeypadType_A8372_UILabel
		{
			get
			{
				short num = (short)772047039;
				short num2 = num;
				num = (short)211648703;
				switch (num2 == num)
				{
				}
				num = (short)1882193921;
				if (num != 0)
				{
				}
				num = (short)1251213312;
				short num3 = num;
				num = (short)1453391872;
				if (num != 0)
				{
				}
				return this.radWideLabtoolKeypadType_A8372.UIName;
			}
		}

		// Token: 0x17001BF3 RID: 7155
		// (get) Token: 0x06003724 RID: 14116 RVA: 0x0034C244 File Offset: 0x0034A444
		// (set) Token: 0x06003725 RID: 14117 RVA: 0x0034C2F8 File Offset: 0x0034A4F8
		internal bool RadWideLabtoolKeypadType_A8372_HiddenStatic
		{
			get
			{
				short num = (short)1608939677;
				short num2 = num;
				num = (short)1244100765;
				switch (num2 == num)
				{
				}
				num = (short)1345978369;
				if (num != 0)
				{
				}
				num = (short)375390208;
				short num3 = num;
				num = (short)1898250240;
				if (num != 0)
				{
				}
				return this.radWideLabtoolKeypadType_A8372.HiddenStatic;
			}
			set
			{
				short num = (short)1983381505;
				if (num != 0)
				{
				}
				num = (short)601293514;
				short num2 = num;
				num = (short)1316160202;
				switch (num2 == num)
				{
				}
				num = (short)1431961600;
				short num3 = num;
				num = (short)1955266560;
				if (num != 0)
				{
				}
				this.radWideLabtoolKeypadType_A8372.HiddenStatic = value;
			}
		}

		// Token: 0x17001BF4 RID: 7156
		// (get) Token: 0x06003726 RID: 14118 RVA: 0x0034C3AC File Offset: 0x0034A5AC
		// (set) Token: 0x06003727 RID: 14119 RVA: 0x0034C460 File Offset: 0x0034A660
		internal bool RadWideLabtoolKeypadType_A8372_HiddenDynamic
		{
			get
			{
				short num = (short)1704164363;
				short num2 = num;
				num = (short)25590795;
				switch (num2 == num)
				{
				}
				num = (short)2038497281;
				if (num != 0)
				{
				}
				num = (short)1842151424;
				short num3 = num;
				num = (short)790691840;
				if (num != 0)
				{
				}
				return this.radWideLabtoolKeypadType_A8372.HiddenDynamic;
			}
			set
			{
				short num = (short)1653427419;
				short num2 = num;
				num = (short)407063771;
				switch (num2 == num)
				{
				}
				num = (short)702283777;
				if (num != 0)
				{
				}
				num = (short)1123549184;
				short num3 = num;
				num = (short)2002714624;
				if (num != 0)
				{
				}
				this.radWideLabtoolKeypadType_A8372.HiddenDynamic = value;
			}
		}

		// Token: 0x17001BF5 RID: 7157
		// (get) Token: 0x06003728 RID: 14120 RVA: 0x0034C518 File Offset: 0x0034A718
		public bool RadWideLabtoolKeypadType_A8372_HasDiffs
		{
			get
			{
				short num = (short)1073959785;
				short num2 = num;
				num = (short)814437225;
				switch (num2 == num)
				{
				}
				num = (short)1300758529;
				if (num != 0)
				{
				}
				num = (short)141819904;
				short num3 = num;
				num = (short)1994129408;
				if (num != 0)
				{
				}
				return this.radWideLabtoolKeypadType_A8372._HasDiffs;
			}
		}

		// Token: 0x17001BF6 RID: 7158
		// (get) Token: 0x06003729 RID: 14121 RVA: 0x0034C5CC File Offset: 0x0034A7CC
		// (set) Token: 0x0600372A RID: 14122 RVA: 0x0034C680 File Offset: 0x0034A880
		public string RadWideLabtoolRadioPassword_A8837Value
		{
			get
			{
				short num = (short)319013654;
				short num2 = num;
				num = (short)830980886;
				switch (num2 == num)
				{
				}
				num = (short)2046754817;
				if (num != 0)
				{
				}
				num = (short)544604160;
				short num3 = num;
				num = (short)1290862592;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioPassword_A8837.Value;
			}
			set
			{
				short num = (short)2055141964;
				short num2 = num;
				num = (short)100727372;
				switch (num2 == num)
				{
				}
				num = (short)1142620161;
				if (num != 0)
				{
				}
				num = (short)1670774784;
				short num3 = num;
				num = (short)1439891456;
				if (num != 0)
				{
				}
				this.radWideLabtoolRadioPassword_A8837.Value = value;
			}
		}

		// Token: 0x17001BF7 RID: 7159
		// (get) Token: 0x0600372B RID: 14123 RVA: 0x0034C738 File Offset: 0x0034A938
		public global::AcpBusinessLayer.AcpField<string> RadWideLabtoolRadioPassword_A8837
		{
			get
			{
				short num = (short)1025478875;
				short num2 = num;
				num = (short)944738523;
				switch (num2 == num)
				{
				}
				num = (short)1739456513;
				if (num != 0)
				{
				}
				num = (short)1487339520;
				short num3 = num;
				num = (short)25034752;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioPassword_A8837;
			}
		}

		// Token: 0x17001BF8 RID: 7160
		// (get) Token: 0x0600372C RID: 14124 RVA: 0x0034C7E8 File Offset: 0x0034A9E8
		// (set) Token: 0x0600372D RID: 14125 RVA: 0x0034C89C File Offset: 0x0034AA9C
		public string RadWideLabtoolRadioPassword_A8837_UIValue
		{
			get
			{
				short num = (short)340956136;
				short num2 = num;
				num = (short)1531876328;
				switch (num2 == num)
				{
				}
				num = (short)657457153;
				if (num != 0)
				{
				}
				num = (short)1646723072;
				short num3 = num;
				num = (short)104726528;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioPassword_A8837.Value;
			}
			set
			{
				short num = (short)361343904;
				short num2 = num;
				num = (short)129936288;
				switch (num2 == num)
				{
				}
				num = (short)766443520;
				if (num != 0)
				{
				}
				num = (short)1403584512;
				short num3 = num;
				num = (short)651493377;
				if (num != 0)
				{
				}
				this.radWideLabtoolRadioPassword_A8837.Value = value;
			}
		}

		// Token: 0x17001BF9 RID: 7161
		// (get) Token: 0x0600372E RID: 14126 RVA: 0x0034C950 File Offset: 0x0034AB50
		// (set) Token: 0x0600372F RID: 14127 RVA: 0x0034CA04 File Offset: 0x0034AC04
		public bool RadWideLabtoolRadioPassword_A8837_Applicable
		{
			get
			{
				short num = (short)1747171056;
				short num2 = num;
				num = (short)169260784;
				switch (num2 == num)
				{
				}
				num = (short)1463025665;
				if (num != 0)
				{
				}
				num = (short)1592131584;
				short num3 = num;
				num = (short)1789919232;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioPassword_A8837.Applicable;
			}
			set
			{
				short num = (short)277487009;
				short num2 = num;
				num = (short)782245281;
				switch (num2 == num)
				{
				}
				num = (short)302710784;
				if (num != 0)
				{
				}
				num = (short)1011679232;
				short num3 = num;
				num = (short)1122107393;
				if (num != 0)
				{
				}
				this.radWideLabtoolRadioPassword_A8837.Applicable = value;
			}
		}

		// Token: 0x17001BFA RID: 7162
		// (get) Token: 0x06003730 RID: 14128 RVA: 0x0034CABC File Offset: 0x0034ACBC
		// (set) Token: 0x06003731 RID: 14129 RVA: 0x0034CB74 File Offset: 0x0034AD74
		public bool RadWideLabtoolRadioPassword_A8837_Valid
		{
			get
			{
				short num = (short)2007498372;
				short num2 = num;
				num = (short)47054468;
				switch (num2 == num)
				{
				}
				num = (short)1896742913;
				if (num != 0)
				{
				}
				num = (short)1160249344;
				short num3 = num;
				num = (short)736690176;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioPassword_A8837.Valid;
			}
			set
			{
				short num = (short)828758789;
				short num2 = num;
				num = (short)1113971461;
				switch (num2 == num)
				{
				}
				num = (short)593166336;
				if (num != 0)
				{
				}
				num = (short)2089484288;
				short num3 = num;
				num = (short)1423835137;
				if (num != 0)
				{
				}
				this.radWideLabtoolRadioPassword_A8837.Valid = value;
			}
		}

		// Token: 0x17001BFB RID: 7163
		// (get) Token: 0x06003732 RID: 14130 RVA: 0x0034CC2C File Offset: 0x0034AE2C
		// (set) Token: 0x06003733 RID: 14131 RVA: 0x0034CCDC File Offset: 0x0034AEDC
		public bool RadWideLabtoolRadioPassword_A8837_Visible
		{
			get
			{
				short num = (short)781115575;
				short num2 = num;
				num = (short)962715831;
				switch (num2 == num)
				{
				}
				num = (short)862846977;
				if (num != 0)
				{
				}
				num = (short)859111424;
				short num3 = num;
				num = (short)1994653696;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioPassword_A8837.Visible;
			}
			set
			{
				short num = (short)907870209;
				if (num != 0)
				{
				}
				num = (short)2107416224;
				short num2 = num;
				num = (short)413965984;
				switch (num2 == num)
				{
				}
				num = (short)327155712;
				short num3 = num;
				num = (short)1919680512;
				if (num != 0)
				{
				}
				this.radWideLabtoolRadioPassword_A8837.Visible = value;
			}
		}

		// Token: 0x17001BFC RID: 7164
		// (get) Token: 0x06003734 RID: 14132 RVA: 0x0034CD94 File Offset: 0x0034AF94
		// (set) Token: 0x06003735 RID: 14133 RVA: 0x0034CE48 File Offset: 0x0034B048
		public bool RadWideLabtoolRadioPassword_A8837_Editable
		{
			get
			{
				short num = (short)649834392;
				short num2 = num;
				num = (short)1984278424;
				switch (num2 == num)
				{
				}
				num = (short)585170944;
				if (num != 0)
				{
				}
				num = (short)904462336;
				short num3 = num;
				num = (short)948436993;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioPassword_A8837.Editable;
			}
			set
			{
				short num = (short)1886669534;
				short num2 = num;
				num = (short)997018334;
				switch (num2 == num)
				{
				}
				num = (short)57999361;
				if (num != 0)
				{
				}
				num = (short)1577844736;
				short num3 = num;
				num = (short)284753920;
				if (num != 0)
				{
				}
				this.radWideLabtoolRadioPassword_A8837.Editable = value;
			}
		}

		// Token: 0x17001BFD RID: 7165
		// (get) Token: 0x06003736 RID: 14134 RVA: 0x0034CEFC File Offset: 0x0034B0FC
		internal string RadWideLabtoolRadioPassword_A8837_UILabel
		{
			get
			{
				short num = (short)703742275;
				short num2 = num;
				num = (short)191447363;
				switch (num2 == num)
				{
				}
				num = (short)605814785;
				if (num != 0)
				{
				}
				num = (short)1250820096;
				short num3 = num;
				num = (short)532348928;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioPassword_A8837.UIName;
			}
		}

		// Token: 0x17001BFE RID: 7166
		// (get) Token: 0x06003737 RID: 14135 RVA: 0x0034CFB0 File Offset: 0x0034B1B0
		// (set) Token: 0x06003738 RID: 14136 RVA: 0x0034D064 File Offset: 0x0034B264
		internal bool RadWideLabtoolRadioPassword_A8837_HiddenStatic
		{
			get
			{
				short num = (short)1630535559;
				short num2 = num;
				num = (short)611450759;
				switch (num2 == num)
				{
				}
				num = (short)364576768;
				if (num != 0)
				{
				}
				num = (short)1347944448;
				short num3 = num;
				num = (short)862912513;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioPassword_A8837.HiddenStatic;
			}
			set
			{
				short num = (short)1459543428;
				short num2 = num;
				num = (short)831053188;
				switch (num2 == num)
				{
				}
				num = (short)499318785;
				if (num != 0)
				{
				}
				num = (short)1065549824;
				short num3 = num;
				num = (short)341114880;
				if (num != 0)
				{
				}
				this.radWideLabtoolRadioPassword_A8837.HiddenStatic = value;
			}
		}

		// Token: 0x17001BFF RID: 7167
		// (get) Token: 0x06003739 RID: 14137 RVA: 0x0034D11C File Offset: 0x0034B31C
		// (set) Token: 0x0600373A RID: 14138 RVA: 0x0034D1D0 File Offset: 0x0034B3D0
		internal bool RadWideLabtoolRadioPassword_A8837_HiddenDynamic
		{
			get
			{
				short num = (short)956788293;
				short num2 = num;
				num = (short)1595895365;
				switch (num2 == num)
				{
				}
				num = (short)1481965568;
				if (num != 0)
				{
				}
				num = (short)501481472;
				short num3 = num;
				num = (short)1117585409;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioPassword_A8837.HiddenDynamic;
			}
			set
			{
				short num = (short)1201981239;
				short num2 = num;
				num = (short)121292599;
				switch (num2 == num)
				{
				}
				num = (short)1660223488;
				if (num != 0)
				{
				}
				num = (short)841351168;
				short num3 = num;
				num = (short)2073624577;
				if (num != 0)
				{
				}
				this.radWideLabtoolRadioPassword_A8837.HiddenDynamic = value;
			}
		}

		// Token: 0x17001C00 RID: 7168
		// (get) Token: 0x0600373B RID: 14139 RVA: 0x0034D284 File Offset: 0x0034B484
		public bool RadWideLabtoolRadioPassword_A8837_HasDiffs
		{
			get
			{
				short num = (short)713723842;
				short num2 = num;
				num = (short)831229890;
				switch (num2 == num)
				{
				}
				num = (short)1469448192;
				short num3 = num;
				num = (short)1360855041;
				if (num != 0)
				{
				}
				num = (short)1667366912;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioPassword_A8837._HasDiffs;
			}
		}

		// Token: 0x17001C01 RID: 7169
		// (get) Token: 0x0600373C RID: 14140 RVA: 0x0034D338 File Offset: 0x0034B538
		// (set) Token: 0x0600373D RID: 14141 RVA: 0x0034D3EC File Offset: 0x0034B5EC
		public bool RadWideLabtoolRadioReadPasswordEnable_A8869Value
		{
			get
			{
				short num = (short)381943809;
				if (num != 0)
				{
				}
				num = (short)1976197111;
				short num2 = num;
				num = (short)1946443767;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1247674368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)790167552;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioReadPasswordEnable_A8869.Value;
			}
			set
			{
				short num = (short)482734592;
				short num2 = num;
				num = (short)896004608;
				switch (num2 == num)
				{
				}
				num = (short)98041856;
				short num3 = num;
				num = (short)64421888;
				if (num != 0)
				{
				}
				num = (short)366804993;
				if (num != 0)
				{
				}
				this.radWideLabtoolRadioReadPasswordEnable_A8869.Value = value;
			}
		}

		// Token: 0x17001C02 RID: 7170
		// (get) Token: 0x0600373E RID: 14142 RVA: 0x0034D4A0 File Offset: 0x0034B6A0
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolRadioReadPasswordEnable_A8869
		{
			get
			{
				short num = (short)434819204;
				short num2 = num;
				num = (short)1792331908;
				switch (num2 == num)
				{
				}
				num = (short)1875574784;
				short num3 = num;
				num = (short)338558976;
				if (num != 0)
				{
				}
				num = (short)1083703297;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioReadPasswordEnable_A8869;
			}
		}

		// Token: 0x17001C03 RID: 7171
		// (get) Token: 0x0600373F RID: 14143 RVA: 0x0034D554 File Offset: 0x0034B754
		// (set) Token: 0x06003740 RID: 14144 RVA: 0x0034D608 File Offset: 0x0034B808
		public bool RadWideLabtoolRadioReadPasswordEnable_A8869_UIValue
		{
			get
			{
				short num = (short)125336972;
				short num2 = num;
				num = (short)1707048332;
				switch (num2 == num)
				{
				}
				num = (short)782565376;
				short num3 = num;
				num = (short)1413349377;
				if (num != 0)
				{
				}
				num = (short)799145984;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioReadPasswordEnable_A8869.Value;
			}
			set
			{
				short num = (short)2066677761;
				if (num != 0)
				{
				}
				num = (short)2001728538;
				short num2 = num;
				num = (short)2070803482;
				switch (num2 == num)
				{
				default:
				{
					num = (short)894238720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)304414720;
				if (num != 0)
				{
				}
				this.radWideLabtoolRadioReadPasswordEnable_A8869.Value = value;
			}
		}

		// Token: 0x17001C04 RID: 7172
		// (get) Token: 0x06003741 RID: 14145 RVA: 0x0034D6BC File Offset: 0x0034B8BC
		// (set) Token: 0x06003742 RID: 14146 RVA: 0x0034D774 File Offset: 0x0034B974
		public bool RadWideLabtoolRadioReadPasswordEnable_A8869_Applicable
		{
			get
			{
				short num = (short)1439777998;
				short num2 = num;
				num = (short)788481230;
				switch (num2 == num)
				{
				}
				num = (short)808714240;
				short num3 = num;
				num = (short)996016128;
				if (num != 0)
				{
				}
				num = (short)146145281;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioReadPasswordEnable_A8869.Applicable;
			}
			set
			{
				short num = (short)1871282516;
				short num2 = num;
				num = (short)1722122580;
				switch (num2 == num)
				{
				}
				num = (short)497811456;
				short num3 = num;
				num = (short)1835204608;
				if (num != 0)
				{
				}
				num = (short)695009281;
				if (num != 0)
				{
				}
				this.radWideLabtoolRadioReadPasswordEnable_A8869.Applicable = value;
			}
		}

		// Token: 0x17001C05 RID: 7173
		// (get) Token: 0x06003743 RID: 14147 RVA: 0x0034D82C File Offset: 0x0034BA2C
		// (set) Token: 0x06003744 RID: 14148 RVA: 0x0034D8E0 File Offset: 0x0034BAE0
		public bool RadWideLabtoolRadioReadPasswordEnable_A8869_Valid
		{
			get
			{
				short num = (short)741736449;
				if (num != 0)
				{
				}
				num = (short)1355829182;
				short num2 = num;
				num = (short)1498959806;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1172176896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1338507264;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioReadPasswordEnable_A8869.Valid;
			}
			set
			{
				short num = (short)1241410115;
				short num2 = num;
				num = (short)1070557763;
				switch (num2 == num)
				{
				}
				num = (short)50921472;
				short num3 = num;
				num = (short)769392641;
				if (num != 0)
				{
				}
				num = (short)200015872;
				if (num != 0)
				{
				}
				this.radWideLabtoolRadioReadPasswordEnable_A8869.Valid = value;
			}
		}

		// Token: 0x17001C06 RID: 7174
		// (get) Token: 0x06003745 RID: 14149 RVA: 0x0034D998 File Offset: 0x0034BB98
		// (set) Token: 0x06003746 RID: 14150 RVA: 0x0034DA50 File Offset: 0x0034BC50
		public bool RadWideLabtoolRadioReadPasswordEnable_A8869_Visible
		{
			get
			{
				short num = (short)1581753650;
				short num2 = num;
				num = (short)903652658;
				switch (num2 == num)
				{
				}
				num = (short)954335232;
				short num3 = num;
				num = (short)1749549056;
				if (num != 0)
				{
				}
				num = (short)1749417985;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioReadPasswordEnable_A8869.Visible;
			}
			set
			{
				short num = (short)1215499025;
				short num2 = num;
				num = (short)440666897;
				switch (num2 == num)
				{
				}
				num = (short)925761536;
				short num3 = num;
				num = (short)1301676033;
				if (num != 0)
				{
				}
				num = (short)127991808;
				if (num != 0)
				{
				}
				this.radWideLabtoolRadioReadPasswordEnable_A8869.Visible = value;
			}
		}

		// Token: 0x17001C07 RID: 7175
		// (get) Token: 0x06003747 RID: 14151 RVA: 0x0034DB04 File Offset: 0x0034BD04
		// (set) Token: 0x06003748 RID: 14152 RVA: 0x0034DBB8 File Offset: 0x0034BDB8
		public bool RadWideLabtoolRadioReadPasswordEnable_A8869_Editable
		{
			get
			{
				short num = (short)232334305;
				short num2 = num;
				num = (short)1414013921;
				switch (num2 == num)
				{
				}
				num = (short)875495424;
				short num3 = num;
				num = (short)2065956865;
				if (num != 0)
				{
				}
				num = (short)373686272;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioReadPasswordEnable_A8869.Editable;
			}
			set
			{
				short num = (short)974797528;
				short num2 = num;
				num = (short)1498626776;
				switch (num2 == num)
				{
				}
				num = (short)1971781632;
				short num3 = num;
				num = (short)1532690432;
				if (num != 0)
				{
				}
				num = (short)1905786881;
				if (num != 0)
				{
				}
				this.radWideLabtoolRadioReadPasswordEnable_A8869.Editable = value;
			}
		}

		// Token: 0x17001C08 RID: 7176
		// (get) Token: 0x06003749 RID: 14153 RVA: 0x0034DC6C File Offset: 0x0034BE6C
		internal string RadWideLabtoolRadioReadPasswordEnable_A8869_UILabel
		{
			get
			{
				short num = (short)267435792;
				short num2 = num;
				num = (short)1252179728;
				switch (num2 == num)
				{
				}
				num = (short)1729953792;
				short num3 = num;
				num = (short)1101791233;
				if (num != 0)
				{
				}
				num = (short)1240727552;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioReadPasswordEnable_A8869.UIName;
			}
		}

		// Token: 0x17001C09 RID: 7177
		// (get) Token: 0x0600374A RID: 14154 RVA: 0x0034DD20 File Offset: 0x0034BF20
		// (set) Token: 0x0600374B RID: 14155 RVA: 0x0034DDD8 File Offset: 0x0034BFD8
		internal bool RadWideLabtoolRadioReadPasswordEnable_A8869_HiddenStatic
		{
			get
			{
				short num = (short)165685522;
				short num2 = num;
				num = (short)1399531794;
				switch (num2 == num)
				{
				}
				num = (short)923992064;
				short num3 = num;
				num = (short)2066284545;
				if (num != 0)
				{
				}
				num = (short)1376649216;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioReadPasswordEnable_A8869.HiddenStatic;
			}
			set
			{
				short num = (short)1006381301;
				short num2 = num;
				num = (short)475998453;
				switch (num2 == num)
				{
				}
				num = (short)958267392;
				short num3 = num;
				num = (short)371851265;
				if (num != 0)
				{
				}
				num = (short)1620901888;
				if (num != 0)
				{
				}
				this.radWideLabtoolRadioReadPasswordEnable_A8869.HiddenStatic = value;
			}
		}

		// Token: 0x17001C0A RID: 7178
		// (get) Token: 0x0600374C RID: 14156 RVA: 0x0034DE90 File Offset: 0x0034C090
		// (set) Token: 0x0600374D RID: 14157 RVA: 0x0034DF44 File Offset: 0x0034C144
		internal bool RadWideLabtoolRadioReadPasswordEnable_A8869_HiddenDynamic
		{
			get
			{
				short num = (short)802226177;
				if (num != 0)
				{
				}
				num = (short)2131593932;
				short num2 = num;
				num = (short)862292684;
				switch (num2 == num)
				{
				default:
				{
					num = (short)194445312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)801964032;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioReadPasswordEnable_A8869.HiddenDynamic;
			}
			set
			{
				short num = (short)1981040314;
				short num2 = num;
				num = (short)548095674;
				switch (num2 == num)
				{
				}
				num = (short)2026242048;
				short num3 = num;
				num = (short)2139291648;
				if (num != 0)
				{
				}
				num = (short)1638465537;
				if (num != 0)
				{
				}
				this.radWideLabtoolRadioReadPasswordEnable_A8869.HiddenDynamic = value;
			}
		}

		// Token: 0x17001C0B RID: 7179
		// (get) Token: 0x0600374E RID: 14158 RVA: 0x0034DFFC File Offset: 0x0034C1FC
		public bool RadWideLabtoolRadioReadPasswordEnable_A8869_HasDiffs
		{
			get
			{
				short num = (short)215967410;
				short num2 = num;
				num = (short)1646487218;
				switch (num2 == num)
				{
				}
				num = (short)2034958336;
				short num3 = num;
				num = (short)977731585;
				if (num != 0)
				{
				}
				num = (short)1402404864;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioReadPasswordEnable_A8869._HasDiffs;
			}
		}

		// Token: 0x17001C0C RID: 7180
		// (get) Token: 0x0600374F RID: 14159 RVA: 0x0034E0B0 File Offset: 0x0034C2B0
		// (set) Token: 0x06003750 RID: 14160 RVA: 0x0034E164 File Offset: 0x0034C364
		public bool RadWideLabtoolRadioWritePasswordEnable_A8889Value
		{
			get
			{
				short num = (short)1638401871;
				short num2 = num;
				num = (short)1840318287;
				switch (num2 == num)
				{
				}
				num = (short)1226571776;
				short num3 = num;
				num = (short)1634140161;
				if (num != 0)
				{
				}
				num = (short)1232666624;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioWritePasswordEnable_A8889.Value;
			}
			set
			{
				short num = (short)696877225;
				short num2 = num;
				num = (short)304447657;
				switch (num2 == num)
				{
				}
				num = (short)1022558208;
				short num3 = num;
				num = (short)1036845057;
				if (num != 0)
				{
				}
				num = (short)1535049728;
				if (num != 0)
				{
				}
				this.radWideLabtoolRadioWritePasswordEnable_A8889.Value = value;
			}
		}

		// Token: 0x17001C0D RID: 7181
		// (get) Token: 0x06003751 RID: 14161 RVA: 0x0034E21C File Offset: 0x0034C41C
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolRadioWritePasswordEnable_A8889
		{
			get
			{
				short num = (short)1090348702;
				short num2 = num;
				num = (short)1010132638;
				switch (num2 == num)
				{
				}
				num = (short)882835456;
				short num3 = num;
				num = (short)2107310081;
				if (num != 0)
				{
				}
				num = (short)920059904;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioWritePasswordEnable_A8889;
			}
		}

		// Token: 0x17001C0E RID: 7182
		// (get) Token: 0x06003752 RID: 14162 RVA: 0x0034E2CC File Offset: 0x0034C4CC
		// (set) Token: 0x06003753 RID: 14163 RVA: 0x0034E380 File Offset: 0x0034C580
		public bool RadWideLabtoolRadioWritePasswordEnable_A8889_UIValue
		{
			get
			{
				short num = (short)2030560767;
				short num2 = num;
				num = (short)1230104063;
				switch (num2 == num)
				{
				}
				num = (short)469565440;
				short num3 = num;
				num = (short)632684545;
				if (num != 0)
				{
				}
				num = (short)688455680;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioWritePasswordEnable_A8889.Value;
			}
			set
			{
				short num = (short)1075766092;
				short num2 = num;
				num = (short)1395909452;
				switch (num2 == num)
				{
				}
				num = (short)1543831552;
				short num3 = num;
				num = (short)1982529537;
				if (num != 0)
				{
				}
				num = (short)1295515648;
				if (num != 0)
				{
				}
				this.radWideLabtoolRadioWritePasswordEnable_A8889.Value = value;
			}
		}

		// Token: 0x17001C0F RID: 7183
		// (get) Token: 0x06003754 RID: 14164 RVA: 0x0034E434 File Offset: 0x0034C634
		// (set) Token: 0x06003755 RID: 14165 RVA: 0x0034E4E4 File Offset: 0x0034C6E4
		public bool RadWideLabtoolRadioWritePasswordEnable_A8889_Applicable
		{
			get
			{
				short num = (short)1021889507;
				short num2 = num;
				num = (short)1200606179;
				switch (num2 == num)
				{
				}
				num = (short)2042363904;
				short num3 = num;
				num = (short)1349910529;
				if (num != 0)
				{
				}
				num = (short)14483456;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioWritePasswordEnable_A8889.Applicable;
			}
			set
			{
				short num = (short)438851845;
				short num2 = num;
				num = (short)1155094789;
				switch (num2 == num)
				{
				}
				num = (short)1155465216;
				short num3 = num;
				num = (short)36634625;
				if (num != 0)
				{
				}
				num = (short)322699264;
				if (num != 0)
				{
				}
				this.radWideLabtoolRadioWritePasswordEnable_A8889.Applicable = value;
			}
		}

		// Token: 0x17001C10 RID: 7184
		// (get) Token: 0x06003756 RID: 14166 RVA: 0x0034E598 File Offset: 0x0034C798
		// (set) Token: 0x06003757 RID: 14167 RVA: 0x0034E650 File Offset: 0x0034C850
		public bool RadWideLabtoolRadioWritePasswordEnable_A8889_Valid
		{
			get
			{
				short num = (short)380431279;
				short num2 = num;
				num = (short)986835887;
				switch (num2 == num)
				{
				}
				num = (short)969146368;
				short num3 = num;
				num = (short)2002714625;
				if (num != 0)
				{
				}
				num = (short)64880640;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioWritePasswordEnable_A8889.Valid;
			}
			set
			{
				short num = (short)1841731559;
				short num2 = num;
				num = (short)314939367;
				switch (num2 == num)
				{
				}
				num = (short)1606942720;
				short num3 = num;
				num = (short)165740544;
				if (num != 0)
				{
				}
				num = (short)846266369;
				if (num != 0)
				{
				}
				this.radWideLabtoolRadioWritePasswordEnable_A8889.Valid = value;
			}
		}

		// Token: 0x17001C11 RID: 7185
		// (get) Token: 0x06003758 RID: 14168 RVA: 0x0034E704 File Offset: 0x0034C904
		// (set) Token: 0x06003759 RID: 14169 RVA: 0x0034E7B8 File Offset: 0x0034C9B8
		public bool RadWideLabtoolRadioWritePasswordEnable_A8889_Visible
		{
			get
			{
				short num = (short)990922713;
				short num2 = num;
				num = (short)373770201;
				switch (num2 == num)
				{
				}
				num = (short)784007168;
				short num3 = num;
				num = (short)2058289153;
				if (num != 0)
				{
				}
				num = (short)76349440;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioWritePasswordEnable_A8889.Visible;
			}
			set
			{
				short num = (short)1817415758;
				short num2 = num;
				num = (short)1568706638;
				switch (num2 == num)
				{
				}
				num = (short)382468096;
				short num3 = num;
				num = (short)40370176;
				if (num != 0)
				{
				}
				num = (short)2019033089;
				if (num != 0)
				{
				}
				this.radWideLabtoolRadioWritePasswordEnable_A8889.Visible = value;
			}
		}

		// Token: 0x17001C12 RID: 7186
		// (get) Token: 0x0600375A RID: 14170 RVA: 0x0034E86C File Offset: 0x0034CA6C
		// (set) Token: 0x0600375B RID: 14171 RVA: 0x0034E920 File Offset: 0x0034CB20
		public bool RadWideLabtoolRadioWritePasswordEnable_A8889_Editable
		{
			get
			{
				short num = (short)189702971;
				short num2 = num;
				num = (short)335389499;
				switch (num2 == num)
				{
				}
				num = (short)231735296;
				short num3 = num;
				num = (short)1336868864;
				if (num != 0)
				{
				}
				num = (short)1261305857;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioWritePasswordEnable_A8889.Editable;
			}
			set
			{
				short num = (short)375982679;
				short num2 = num;
				num = (short)767887959;
				switch (num2 == num)
				{
				}
				num = (short)158400512;
				short num3 = num;
				num = (short)1895170048;
				if (num != 0)
				{
				}
				num = (short)1200750593;
				if (num != 0)
				{
				}
				this.radWideLabtoolRadioWritePasswordEnable_A8889.Editable = value;
			}
		}

		// Token: 0x17001C13 RID: 7187
		// (get) Token: 0x0600375C RID: 14172 RVA: 0x0034E9D4 File Offset: 0x0034CBD4
		internal string RadWideLabtoolRadioWritePasswordEnable_A8889_UILabel
		{
			get
			{
				short num = (short)645938066;
				short num2 = num;
				num = (short)1837775762;
				switch (num2 == num)
				{
				}
				num = (short)667615232;
				short num3 = num;
				num = (short)1176961025;
				if (num != 0)
				{
				}
				num = (short)8650752;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioWritePasswordEnable_A8889.UIName;
			}
		}

		// Token: 0x17001C14 RID: 7188
		// (get) Token: 0x0600375D RID: 14173 RVA: 0x0034EA88 File Offset: 0x0034CC88
		// (set) Token: 0x0600375E RID: 14174 RVA: 0x0034EB3C File Offset: 0x0034CD3C
		internal bool RadWideLabtoolRadioWritePasswordEnable_A8889_HiddenStatic
		{
			get
			{
				short num = (short)898493512;
				short num2 = num;
				num = (short)847047752;
				switch (num2 == num)
				{
				}
				num = (short)993656832;
				short num3 = num;
				num = (short)1241579520;
				if (num != 0)
				{
				}
				num = (short)132448257;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioWritePasswordEnable_A8889.HiddenStatic;
			}
			set
			{
				short num = (short)182321153;
				if (num != 0)
				{
				}
				num = (short)1681976548;
				short num2 = num;
				num = (short)2133060836;
				switch (num2 == num)
				{
				default:
				{
					num = (short)325844992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)467664896;
				if (num != 0)
				{
				}
				this.radWideLabtoolRadioWritePasswordEnable_A8889.HiddenStatic = value;
			}
		}

		// Token: 0x17001C15 RID: 7189
		// (get) Token: 0x0600375F RID: 14175 RVA: 0x0034EBF4 File Offset: 0x0034CDF4
		// (set) Token: 0x06003760 RID: 14176 RVA: 0x0034ECA8 File Offset: 0x0034CEA8
		internal bool RadWideLabtoolRadioWritePasswordEnable_A8889_HiddenDynamic
		{
			get
			{
				short num = (short)1336435049;
				short num2 = num;
				num = (short)1214734697;
				switch (num2 == num)
				{
				}
				num = (short)340525056;
				short num3 = num;
				num = (short)1613889537;
				if (num != 0)
				{
				}
				num = (short)1725890560;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioWritePasswordEnable_A8889.HiddenDynamic;
			}
			set
			{
				short num = (short)1546973841;
				short num2 = num;
				num = (short)1676997265;
				switch (num2 == num)
				{
				}
				num = (short)2105868288;
				short num3 = num;
				num = (short)1920598016;
				if (num != 0)
				{
				}
				num = (short)1819869185;
				if (num != 0)
				{
				}
				this.radWideLabtoolRadioWritePasswordEnable_A8889.HiddenDynamic = value;
			}
		}

		// Token: 0x17001C16 RID: 7190
		// (get) Token: 0x06003761 RID: 14177 RVA: 0x0034ED64 File Offset: 0x0034CF64
		public bool RadWideLabtoolRadioWritePasswordEnable_A8889_HasDiffs
		{
			get
			{
				short num = (short)722631871;
				short num2 = num;
				num = (short)1287552191;
				switch (num2 == num)
				{
				}
				num = (short)523698176;
				short num3 = num;
				num = (short)865927169;
				if (num != 0)
				{
				}
				num = (short)584974336;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRadioWritePasswordEnable_A8889._HasDiffs;
			}
		}

		// Token: 0x17001C17 RID: 7191
		// (get) Token: 0x06003762 RID: 14178 RVA: 0x0034EE14 File Offset: 0x0034D014
		// (set) Token: 0x06003763 RID: 14179 RVA: 0x0034EEC8 File Offset: 0x0034D0C8
		public bool RadWideLabtoolReadWriteVoiceFiles_A8893Value
		{
			get
			{
				short num = (short)160734401;
				short num2 = num;
				num = (short)1659346113;
				switch (num2 == num)
				{
				}
				num = (short)923795456;
				short num3 = num;
				num = (short)1039597569;
				if (num != 0)
				{
				}
				num = (short)569049088;
				if (num != 0)
				{
				}
				return this.radWideLabtoolReadWriteVoiceFiles_A8893.Value;
			}
			set
			{
				short num = (short)298929945;
				short num2 = num;
				num = (short)1990020889;
				switch (num2 == num)
				{
				}
				num = (short)1951662080;
				short num3 = num;
				num = (short)1461714945;
				if (num != 0)
				{
				}
				num = (short)992477184;
				if (num != 0)
				{
				}
				this.radWideLabtoolReadWriteVoiceFiles_A8893.Value = value;
			}
		}

		// Token: 0x17001C18 RID: 7192
		// (get) Token: 0x06003764 RID: 14180 RVA: 0x0034EF7C File Offset: 0x0034D17C
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolReadWriteVoiceFiles_A8893
		{
			get
			{
				short num = (short)1779302401;
				if (num != 0)
				{
				}
				num = (short)973351500;
				short num2 = num;
				num = (short)607726156;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1851260928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)46268416;
				if (num != 0)
				{
				}
				return this.radWideLabtoolReadWriteVoiceFiles_A8893;
			}
		}

		// Token: 0x17001C19 RID: 7193
		// (get) Token: 0x06003765 RID: 14181 RVA: 0x0034F02C File Offset: 0x0034D22C
		// (set) Token: 0x06003766 RID: 14182 RVA: 0x0034F0E4 File Offset: 0x0034D2E4
		public bool RadWideLabtoolReadWriteVoiceFiles_A8893_UIValue
		{
			get
			{
				short num = (short)873228081;
				short num2 = num;
				num = (short)702965553;
				switch (num2 == num)
				{
				}
				num = (short)38731776;
				short num3 = num;
				num = (short)119734273;
				if (num != 0)
				{
				}
				num = (short)2041708544;
				if (num != 0)
				{
				}
				return this.radWideLabtoolReadWriteVoiceFiles_A8893.Value;
			}
			set
			{
				short num = (short)1652339549;
				short num2 = num;
				num = (short)1085256541;
				switch (num2 == num)
				{
				}
				num = (short)129695744;
				short num3 = num;
				num = (short)666238977;
				if (num != 0)
				{
				}
				num = (short)216858624;
				if (num != 0)
				{
				}
				this.radWideLabtoolReadWriteVoiceFiles_A8893.Value = value;
			}
		}

		// Token: 0x17001C1A RID: 7194
		// (get) Token: 0x06003767 RID: 14183 RVA: 0x0034F19C File Offset: 0x0034D39C
		// (set) Token: 0x06003768 RID: 14184 RVA: 0x0034F254 File Offset: 0x0034D454
		public bool RadWideLabtoolReadWriteVoiceFiles_A8893_Applicable
		{
			get
			{
				short num = (short)2058049874;
				short num2 = num;
				num = (short)809458002;
				switch (num2 == num)
				{
				}
				num = (short)1379401728;
				short num3 = num;
				num = (short)682360833;
				if (num != 0)
				{
				}
				num = (short)1934032896;
				if (num != 0)
				{
				}
				return this.radWideLabtoolReadWriteVoiceFiles_A8893.Applicable;
			}
			set
			{
				short num = (short)2133643252;
				short num2 = num;
				num = (short)396546036;
				switch (num2 == num)
				{
				}
				num = (short)1485176832;
				short num3 = num;
				num = (short)760217601;
				if (num != 0)
				{
				}
				num = (short)1065287680;
				if (num != 0)
				{
				}
				this.radWideLabtoolReadWriteVoiceFiles_A8893.Applicable = value;
			}
		}

		// Token: 0x17001C1B RID: 7195
		// (get) Token: 0x06003769 RID: 14185 RVA: 0x0034F308 File Offset: 0x0034D508
		// (set) Token: 0x0600376A RID: 14186 RVA: 0x0034F3BC File Offset: 0x0034D5BC
		public bool RadWideLabtoolReadWriteVoiceFiles_A8893_Valid
		{
			get
			{
				short num = (short)1724824790;
				short num2 = num;
				num = (short)556186838;
				switch (num2 == num)
				{
				}
				num = (short)60882944;
				short num3 = num;
				num = (short)1209794560;
				if (num != 0)
				{
				}
				num = (short)1385365505;
				if (num != 0)
				{
				}
				return this.radWideLabtoolReadWriteVoiceFiles_A8893.Valid;
			}
			set
			{
				short num = (short)1004470273;
				if (num != 0)
				{
				}
				num = (short)666264520;
				short num2 = num;
				num = (short)509961160;
				switch (num2 == num)
				{
				default:
				{
					num = (short)985989120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)866713600;
				if (num != 0)
				{
				}
				this.radWideLabtoolReadWriteVoiceFiles_A8893.Valid = value;
			}
		}

		// Token: 0x17001C1C RID: 7196
		// (get) Token: 0x0600376B RID: 14187 RVA: 0x0034F470 File Offset: 0x0034D670
		// (set) Token: 0x0600376C RID: 14188 RVA: 0x0034F524 File Offset: 0x0034D724
		public bool RadWideLabtoolReadWriteVoiceFiles_A8893_Visible
		{
			get
			{
				short num = (short)889188488;
				short num2 = num;
				num = (short)1368977544;
				switch (num2 == num)
				{
				}
				num = (short)306380800;
				short num3 = num;
				num = (short)1697710081;
				if (num != 0)
				{
				}
				num = (short)1572077568;
				if (num != 0)
				{
				}
				return this.radWideLabtoolReadWriteVoiceFiles_A8893.Visible;
			}
			set
			{
				short num = (short)2100044235;
				short num2 = num;
				num = (short)192553419;
				switch (num2 == num)
				{
				}
				num = (short)534839296;
				short num3 = num;
				num = (short)2000814081;
				if (num != 0)
				{
				}
				num = (short)128188416;
				if (num != 0)
				{
				}
				this.radWideLabtoolReadWriteVoiceFiles_A8893.Visible = value;
			}
		}

		// Token: 0x17001C1D RID: 7197
		// (get) Token: 0x0600376D RID: 14189 RVA: 0x0034F5DC File Offset: 0x0034D7DC
		// (set) Token: 0x0600376E RID: 14190 RVA: 0x0034F68C File Offset: 0x0034D88C
		public bool RadWideLabtoolReadWriteVoiceFiles_A8893_Editable
		{
			get
			{
				short num = (short)175380557;
				short num2 = num;
				num = (short)1821907021;
				switch (num2 == num)
				{
				}
				num = (short)1801519104;
				short num3 = num;
				num = (short)518127617;
				if (num != 0)
				{
				}
				num = (short)1892548608;
				if (num != 0)
				{
				}
				return this.radWideLabtoolReadWriteVoiceFiles_A8893.Editable;
			}
			set
			{
				short num = (short)254899387;
				short num2 = num;
				num = (short)1690203323;
				switch (num2 == num)
				{
				}
				num = (short)1947664384;
				short num3 = num;
				num = (short)228786177;
				if (num != 0)
				{
				}
				num = (short)1963458560;
				if (num != 0)
				{
				}
				this.radWideLabtoolReadWriteVoiceFiles_A8893.Editable = value;
			}
		}

		// Token: 0x17001C1E RID: 7198
		// (get) Token: 0x0600376F RID: 14191 RVA: 0x0034F740 File Offset: 0x0034D940
		internal string RadWideLabtoolReadWriteVoiceFiles_A8893_UILabel
		{
			get
			{
				short num = (short)46307017;
				short num2 = num;
				num = (short)121673417;
				switch (num2 == num)
				{
				}
				num = (short)699662336;
				short num3 = num;
				num = (short)969015297;
				if (num != 0)
				{
				}
				num = (short)855244800;
				if (num != 0)
				{
				}
				return this.radWideLabtoolReadWriteVoiceFiles_A8893.UIName;
			}
		}

		// Token: 0x17001C1F RID: 7199
		// (get) Token: 0x06003770 RID: 14192 RVA: 0x0034F7F4 File Offset: 0x0034D9F4
		// (set) Token: 0x06003771 RID: 14193 RVA: 0x0034F8A8 File Offset: 0x0034DAA8
		internal bool RadWideLabtoolReadWriteVoiceFiles_A8893_HiddenStatic
		{
			get
			{
				short num = (short)823461779;
				short num2 = num;
				num = (short)920651667;
				switch (num2 == num)
				{
				}
				num = (short)243990528;
				short num3 = num;
				num = (short)1121255425;
				if (num != 0)
				{
				}
				num = (short)1484390400;
				if (num != 0)
				{
				}
				return this.radWideLabtoolReadWriteVoiceFiles_A8893.HiddenStatic;
			}
			set
			{
				short num = (short)1750450151;
				short num2 = num;
				num = (short)1376305127;
				switch (num2 == num)
				{
				}
				num = (short)1137180672;
				short num3 = num;
				num = (short)994770945;
				if (num != 0)
				{
				}
				num = (short)362020864;
				if (num != 0)
				{
				}
				this.radWideLabtoolReadWriteVoiceFiles_A8893.HiddenStatic = value;
			}
		}

		// Token: 0x17001C20 RID: 7200
		// (get) Token: 0x06003772 RID: 14194 RVA: 0x0034F95C File Offset: 0x0034DB5C
		// (set) Token: 0x06003773 RID: 14195 RVA: 0x0034FA14 File Offset: 0x0034DC14
		internal bool RadWideLabtoolReadWriteVoiceFiles_A8893_HiddenDynamic
		{
			get
			{
				short num = (short)484970265;
				short num2 = num;
				num = (short)114560793;
				switch (num2 == num)
				{
				}
				num = (short)1498021888;
				short num3 = num;
				num = (short)1040121856;
				if (num != 0)
				{
				}
				num = (short)1415970817;
				if (num != 0)
				{
				}
				return this.radWideLabtoolReadWriteVoiceFiles_A8893.HiddenDynamic;
			}
			set
			{
				short num = (short)451410264;
				short num2 = num;
				num = (short)1165293912;
				switch (num2 == num)
				{
				}
				num = (short)1685389312;
				short num3 = num;
				num = (short)1638334464;
				if (num != 0)
				{
				}
				num = (short)1468923905;
				if (num != 0)
				{
				}
				this.radWideLabtoolReadWriteVoiceFiles_A8893.HiddenDynamic = value;
			}
		}

		// Token: 0x17001C21 RID: 7201
		// (get) Token: 0x06003774 RID: 14196 RVA: 0x0034FAC8 File Offset: 0x0034DCC8
		public bool RadWideLabtoolReadWriteVoiceFiles_A8893_HasDiffs
		{
			get
			{
				short num = (short)385092609;
				short num2 = num;
				num = (short)1598753793;
				switch (num2 == num)
				{
				}
				num = (short)647102464;
				short num3 = num;
				num = (short)2018050049;
				if (num != 0)
				{
				}
				num = (short)671875072;
				if (num != 0)
				{
				}
				return this.radWideLabtoolReadWriteVoiceFiles_A8893._HasDiffs;
			}
		}

		// Token: 0x17001C22 RID: 7202
		// (get) Token: 0x06003775 RID: 14197 RVA: 0x0034FB7C File Offset: 0x0034DD7C
		// (set) Token: 0x06003776 RID: 14198 RVA: 0x0034FC30 File Offset: 0x0034DE30
		public bool RadWideLabtoolSirenPaFatalError_A9141Value
		{
			get
			{
				short num = (short)2035805496;
				short num2 = num;
				num = (short)2082860344;
				switch (num2 == num)
				{
				}
				num = (short)584253440;
				short num3 = num;
				num = (short)1361641473;
				if (num != 0)
				{
				}
				num = (short)857669632;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSirenPaFatalError_A9141.Value;
			}
			set
			{
				short num = (short)1944387585;
				if (num != 0)
				{
				}
				num = (short)1752871336;
				short num2 = num;
				num = (short)1642181032;
				switch (num2 == num)
				{
				default:
				{
					num = (short)722468864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1394409472;
				if (num != 0)
				{
				}
				this.radWideLabtoolSirenPaFatalError_A9141.Value = value;
			}
		}

		// Token: 0x17001C23 RID: 7203
		// (get) Token: 0x06003777 RID: 14199 RVA: 0x0034FCE4 File Offset: 0x0034DEE4
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolSirenPaFatalError_A9141
		{
			get
			{
				short num = (short)926325524;
				short num2 = num;
				num = (short)992123668;
				switch (num2 == num)
				{
				}
				num = (short)1747582976;
				short num3 = num;
				num = (short)2060255233;
				if (num != 0)
				{
				}
				num = (short)389021696;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSirenPaFatalError_A9141;
			}
		}

		// Token: 0x17001C24 RID: 7204
		// (get) Token: 0x06003778 RID: 14200 RVA: 0x0034FD94 File Offset: 0x0034DF94
		// (set) Token: 0x06003779 RID: 14201 RVA: 0x0034FE4C File Offset: 0x0034E04C
		public bool RadWideLabtoolSirenPaFatalError_A9141_UIValue
		{
			get
			{
				short num = (short)451434782;
				short num2 = num;
				num = (short)1562204446;
				switch (num2 == num)
				{
				}
				num = (short)1905786880;
				short num3 = num;
				num = (short)1881735169;
				if (num != 0)
				{
				}
				num = (short)454295552;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSirenPaFatalError_A9141.Value;
			}
			set
			{
				short num = (short)1950804332;
				short num2 = num;
				num = (short)102230380;
				switch (num2 == num)
				{
				}
				num = (short)630652928;
				short num3 = num;
				num = (short)468844544;
				if (num != 0)
				{
				}
				num = (short)1557397505;
				if (num != 0)
				{
				}
				this.radWideLabtoolSirenPaFatalError_A9141.Value = value;
			}
		}

		// Token: 0x17001C25 RID: 7205
		// (get) Token: 0x0600377A RID: 14202 RVA: 0x0034FF00 File Offset: 0x0034E100
		// (set) Token: 0x0600377B RID: 14203 RVA: 0x0034FFB4 File Offset: 0x0034E1B4
		public bool RadWideLabtoolSirenPaFatalError_A9141_Applicable
		{
			get
			{
				short num = (short)57280485;
				short num2 = num;
				num = (short)1761282021;
				switch (num2 == num)
				{
				}
				num = (short)1860435968;
				short num3 = num;
				num = (short)1660157952;
				if (num != 0)
				{
				}
				num = (short)389480449;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSirenPaFatalError_A9141.Applicable;
			}
			set
			{
				short num = (short)421321204;
				short num2 = num;
				num = (short)1298258420;
				switch (num2 == num)
				{
				}
				num = (short)815792128;
				short num3 = num;
				num = (short)1516175361;
				if (num != 0)
				{
				}
				num = (short)1062076416;
				if (num != 0)
				{
				}
				this.radWideLabtoolSirenPaFatalError_A9141.Applicable = value;
			}
		}

		// Token: 0x17001C26 RID: 7206
		// (get) Token: 0x0600377C RID: 14204 RVA: 0x0035006C File Offset: 0x0034E26C
		// (set) Token: 0x0600377D RID: 14205 RVA: 0x00350124 File Offset: 0x0034E324
		public bool RadWideLabtoolSirenPaFatalError_A9141_Valid
		{
			get
			{
				short num = (short)2114257398;
				short num2 = num;
				num = (short)863175158;
				switch (num2 == num)
				{
				}
				num = (short)98107392;
				short num3 = num;
				num = (short)1545273344;
				if (num != 0)
				{
				}
				num = (short)1132789761;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSirenPaFatalError_A9141.Valid;
			}
			set
			{
				short num = (short)1069547705;
				short num2 = num;
				num = (short)1257832633;
				switch (num2 == num)
				{
				}
				num = (short)1734082560;
				short num3 = num;
				num = (short)1246822400;
				if (num != 0)
				{
				}
				num = (short)751960065;
				if (num != 0)
				{
				}
				this.radWideLabtoolSirenPaFatalError_A9141.Valid = value;
			}
		}

		// Token: 0x17001C27 RID: 7207
		// (get) Token: 0x0600377E RID: 14206 RVA: 0x003501DC File Offset: 0x0034E3DC
		// (set) Token: 0x0600377F RID: 14207 RVA: 0x00350290 File Offset: 0x0034E490
		public bool RadWideLabtoolSirenPaFatalError_A9141_Visible
		{
			get
			{
				short num = (short)317063169;
				if (num != 0)
				{
				}
				num = (short)1039788110;
				short num2 = num;
				num = (short)2064115790;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1005125632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1609498624;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSirenPaFatalError_A9141.Visible;
			}
			set
			{
				short num = (short)2140098192;
				short num2 = num;
				num = (short)1662013072;
				switch (num2 == num)
				{
				}
				num = (short)507969536;
				short num3 = num;
				num = (short)1551630337;
				if (num != 0)
				{
				}
				num = (short)1263927296;
				if (num != 0)
				{
				}
				this.radWideLabtoolSirenPaFatalError_A9141.Visible = value;
			}
		}

		// Token: 0x17001C28 RID: 7208
		// (get) Token: 0x06003780 RID: 14208 RVA: 0x00350344 File Offset: 0x0034E544
		// (set) Token: 0x06003781 RID: 14209 RVA: 0x003503F8 File Offset: 0x0034E5F8
		public bool RadWideLabtoolSirenPaFatalError_A9141_Editable
		{
			get
			{
				short num = (short)2038157868;
				short num2 = num;
				num = (short)1402130988;
				switch (num2 == num)
				{
				}
				num = (short)1913651200;
				short num3 = num;
				num = (short)1255866369;
				if (num != 0)
				{
				}
				num = (short)787939328;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSirenPaFatalError_A9141.Editable;
			}
			set
			{
				short num = (short)1815070633;
				short num2 = num;
				num = (short)714786729;
				switch (num2 == num)
				{
				}
				num = (short)61079552;
				short num3 = num;
				num = (short)802947073;
				if (num != 0)
				{
				}
				num = (short)1129578496;
				if (num != 0)
				{
				}
				this.radWideLabtoolSirenPaFatalError_A9141.Editable = value;
			}
		}

		// Token: 0x17001C29 RID: 7209
		// (get) Token: 0x06003782 RID: 14210 RVA: 0x003504AC File Offset: 0x0034E6AC
		internal string RadWideLabtoolSirenPaFatalError_A9141_UILabel
		{
			get
			{
				short num = (short)498349667;
				short num2 = num;
				num = (short)803157603;
				switch (num2 == num)
				{
				}
				num = (short)944635904;
				short num3 = num;
				num = (short)2064318464;
				if (num != 0)
				{
				}
				num = (short)397934593;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSirenPaFatalError_A9141.UIName;
			}
		}

		// Token: 0x17001C2A RID: 7210
		// (get) Token: 0x06003783 RID: 14211 RVA: 0x00350560 File Offset: 0x0034E760
		// (set) Token: 0x06003784 RID: 14212 RVA: 0x00350610 File Offset: 0x0034E810
		internal bool RadWideLabtoolSirenPaFatalError_A9141_HiddenStatic
		{
			get
			{
				short num = (short)433458700;
				short num2 = num;
				num = (short)1187450380;
				switch (num2 == num)
				{
				}
				num = (short)409665536;
				short num3 = num;
				num = (short)2129002497;
				if (num != 0)
				{
				}
				num = (short)1064566784;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSirenPaFatalError_A9141.HiddenStatic;
			}
			set
			{
				short num = (short)331786745;
				short num2 = num;
				num = (short)1883089401;
				switch (num2 == num)
				{
				}
				num = (short)1228210176;
				short num3 = num;
				num = (short)1684209665;
				if (num != 0)
				{
				}
				num = (short)1644822528;
				if (num != 0)
				{
				}
				this.radWideLabtoolSirenPaFatalError_A9141.HiddenStatic = value;
			}
		}

		// Token: 0x17001C2B RID: 7211
		// (get) Token: 0x06003785 RID: 14213 RVA: 0x003506C4 File Offset: 0x0034E8C4
		// (set) Token: 0x06003786 RID: 14214 RVA: 0x00350774 File Offset: 0x0034E974
		internal bool RadWideLabtoolSirenPaFatalError_A9141_HiddenDynamic
		{
			get
			{
				short num = (short)676272024;
				short num2 = num;
				num = (short)1794250648;
				switch (num2 == num)
				{
				}
				num = (short)283967488;
				short num3 = num;
				num = (short)71630848;
				if (num != 0)
				{
				}
				num = (short)402587649;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSirenPaFatalError_A9141.HiddenDynamic;
			}
			set
			{
				short num = (short)1300159747;
				short num2 = num;
				num = (short)1918557443;
				switch (num2 == num)
				{
				}
				num = (short)1864892416;
				short num3 = num;
				num = (short)1857683457;
				if (num != 0)
				{
				}
				num = (short)1768947712;
				if (num != 0)
				{
				}
				this.radWideLabtoolSirenPaFatalError_A9141.HiddenDynamic = value;
			}
		}

		// Token: 0x17001C2C RID: 7212
		// (get) Token: 0x06003787 RID: 14215 RVA: 0x0035082C File Offset: 0x0034EA2C
		public bool RadWideLabtoolSirenPaFatalError_A9141_HasDiffs
		{
			get
			{
				short num = (short)645405047;
				short num2 = num;
				num = (short)946411895;
				switch (num2 == num)
				{
				}
				num = (short)612892672;
				short num3 = num;
				num = (short)452067329;
				if (num != 0)
				{
				}
				num = (short)397410304;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSirenPaFatalError_A9141._HasDiffs;
			}
		}

		// Token: 0x17001C2D RID: 7213
		// (get) Token: 0x06003788 RID: 14216 RVA: 0x003508E0 File Offset: 0x0034EAE0
		// (set) Token: 0x06003789 RID: 14217 RVA: 0x00350998 File Offset: 0x0034EB98
		public bool RadWideLabtoolSirenPaOnly_A9142Value
		{
			get
			{
				short num = (short)1824240448;
				short num2 = num;
				num = (short)1557246784;
				switch (num2 == num)
				{
				}
				num = (short)684785664;
				short num3 = num;
				num = (short)1387266048;
				if (num != 0)
				{
				}
				num = (short)1828061185;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSirenPaOnly_A9142.Value;
			}
			set
			{
				short num = (short)492634113;
				if (num != 0)
				{
				}
				num = (short)535268524;
				short num2 = num;
				num = (short)1051364524;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1835139072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1758265344;
				if (num != 0)
				{
				}
				this.radWideLabtoolSirenPaOnly_A9142.Value = value;
			}
		}

		// Token: 0x17001C2E RID: 7214
		// (get) Token: 0x0600378A RID: 14218 RVA: 0x00350A4C File Offset: 0x0034EC4C
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolSirenPaOnly_A9142
		{
			get
			{
				short num = (short)1859064664;
				short num2 = num;
				num = (short)174789464;
				switch (num2 == num)
				{
				}
				num = (short)2096234496;
				short num3 = num;
				num = (short)486211584;
				if (num != 0)
				{
				}
				num = (short)2094071809;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSirenPaOnly_A9142;
			}
		}

		// Token: 0x17001C2F RID: 7215
		// (get) Token: 0x0600378B RID: 14219 RVA: 0x00350AFC File Offset: 0x0034ECFC
		// (set) Token: 0x0600378C RID: 14220 RVA: 0x00350BB0 File Offset: 0x0034EDB0
		public bool RadWideLabtoolSirenPaOnly_A9142_UIValue
		{
			get
			{
				short num = (short)1001983756;
				short num2 = num;
				num = (short)1672941324;
				switch (num2 == num)
				{
				}
				num = (short)1325727744;
				short num3 = num;
				num = (short)421134337;
				if (num != 0)
				{
				}
				num = (short)408813568;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSirenPaOnly_A9142.Value;
			}
			set
			{
				short num = (short)947582269;
				short num2 = num;
				num = (short)2092299581;
				switch (num2 == num)
				{
				}
				num = (short)1265696768;
				short num3 = num;
				num = (short)1483472897;
				if (num != 0)
				{
				}
				num = (short)1116733440;
				if (num != 0)
				{
				}
				this.radWideLabtoolSirenPaOnly_A9142.Value = value;
			}
		}

		// Token: 0x17001C30 RID: 7216
		// (get) Token: 0x0600378D RID: 14221 RVA: 0x00350C68 File Offset: 0x0034EE68
		// (set) Token: 0x0600378E RID: 14222 RVA: 0x00350D1C File Offset: 0x0034EF1C
		public bool RadWideLabtoolSirenPaOnly_A9142_Applicable
		{
			get
			{
				short num = (short)935657473;
				if (num != 0)
				{
				}
				num = (short)271776551;
				short num2 = num;
				num = (short)325778215;
				switch (num2 == num)
				{
				}
				num = (short)832765952;
				if (num != 0)
				{
				}
				num = (short)1482883072;
				short num3 = num;
				return this.radWideLabtoolSirenPaOnly_A9142.Applicable;
			}
			set
			{
				short num = (short)1866364443;
				short num2 = num;
				num = (short)1506833947;
				switch (num2 == num)
				{
				}
				num = (short)313786369;
				if (num != 0)
				{
				}
				num = (short)1958346752;
				if (num != 0)
				{
				}
				num = (short)1342504960;
				short num3 = num;
				this.radWideLabtoolSirenPaOnly_A9142.Applicable = value;
			}
		}

		// Token: 0x17001C31 RID: 7217
		// (get) Token: 0x0600378F RID: 14223 RVA: 0x00350DD0 File Offset: 0x0034EFD0
		// (set) Token: 0x06003790 RID: 14224 RVA: 0x00350E84 File Offset: 0x0034F084
		public bool RadWideLabtoolSirenPaOnly_A9142_Valid
		{
			get
			{
				short num = (short)1956065163;
				short num2 = num;
				num = (short)1104162699;
				switch (num2 == num)
				{
				}
				num = (short)1236926465;
				if (num != 0)
				{
				}
				num = (short)190316544;
				if (num != 0)
				{
				}
				num = (short)1995833344;
				short num3 = num;
				return this.radWideLabtoolSirenPaOnly_A9142.Valid;
			}
			set
			{
				short num = (short)1029970834;
				short num2 = num;
				num = (short)1359092626;
				switch (num2 == num)
				{
				}
				num = (short)1662648321;
				if (num != 0)
				{
				}
				num = (short)1975648256;
				if (num != 0)
				{
				}
				num = (short)1529937920;
				short num3 = num;
				this.radWideLabtoolSirenPaOnly_A9142.Valid = value;
			}
		}

		// Token: 0x17001C32 RID: 7218
		// (get) Token: 0x06003791 RID: 14225 RVA: 0x00350F38 File Offset: 0x0034F138
		// (set) Token: 0x06003792 RID: 14226 RVA: 0x00350FEC File Offset: 0x0034F1EC
		public bool RadWideLabtoolSirenPaOnly_A9142_Visible
		{
			get
			{
				short num = (short)1846545521;
				short num2 = num;
				num = (short)1558973553;
				switch (num2 == num)
				{
				}
				num = (short)2139095041;
				if (num != 0)
				{
				}
				num = (short)1914568704;
				if (num != 0)
				{
				}
				num = (short)1834549248;
				short num3 = num;
				return this.radWideLabtoolSirenPaOnly_A9142.Visible;
			}
			set
			{
				short num = (short)1348993732;
				short num2 = num;
				num = (short)1869415108;
				switch (num2 == num)
				{
				}
				num = (short)1648820225;
				if (num != 0)
				{
				}
				num = (short)1699479552;
				if (num != 0)
				{
				}
				num = (short)125501440;
				short num3 = num;
				this.radWideLabtoolSirenPaOnly_A9142.Visible = value;
			}
		}

		// Token: 0x17001C33 RID: 7219
		// (get) Token: 0x06003793 RID: 14227 RVA: 0x003510A4 File Offset: 0x0034F2A4
		// (set) Token: 0x06003794 RID: 14228 RVA: 0x00351158 File Offset: 0x0034F358
		public bool RadWideLabtoolSirenPaOnly_A9142_Editable
		{
			get
			{
				short num = (short)1149435905;
				if (num != 0)
				{
				}
				num = (short)832928682;
				short num2 = num;
				num = (short)1909226410;
				switch (num2 == num)
				{
				}
				num = (short)1434910720;
				if (num != 0)
				{
				}
				num = (short)296288256;
				short num3 = num;
				return this.radWideLabtoolSirenPaOnly_A9142.Editable;
			}
			set
			{
				short num = (short)143252783;
				short num2 = num;
				num = (short)1702485295;
				switch (num2 == num)
				{
				}
				num = (short)1646264320;
				if (num != 0)
				{
				}
				num = (short)770244609;
				if (num != 0)
				{
				}
				num = (short)227934208;
				short num3 = num;
				this.radWideLabtoolSirenPaOnly_A9142.Editable = value;
			}
		}

		// Token: 0x17001C34 RID: 7220
		// (get) Token: 0x06003795 RID: 14229 RVA: 0x0035120C File Offset: 0x0034F40C
		internal string RadWideLabtoolSirenPaOnly_A9142_UILabel
		{
			get
			{
				short num = (short)2073621387;
				short num2 = num;
				num = (short)102101899;
				switch (num2 == num)
				{
				}
				num = (short)597819393;
				if (num != 0)
				{
				}
				num = (short)529858560;
				if (num != 0)
				{
				}
				num = (short)1944453120;
				short num3 = num;
				return this.radWideLabtoolSirenPaOnly_A9142.UIName;
			}
		}

		// Token: 0x17001C35 RID: 7221
		// (get) Token: 0x06003796 RID: 14230 RVA: 0x003512C0 File Offset: 0x0034F4C0
		// (set) Token: 0x06003797 RID: 14231 RVA: 0x00351374 File Offset: 0x0034F574
		internal bool RadWideLabtoolSirenPaOnly_A9142_HiddenStatic
		{
			get
			{
				short num = (short)777999719;
				short num2 = num;
				num = (short)1879070055;
				switch (num2 == num)
				{
				}
				num = (short)903020545;
				if (num != 0)
				{
				}
				num = (short)1120927744;
				if (num != 0)
				{
				}
				num = (short)2125922304;
				short num3 = num;
				return this.radWideLabtoolSirenPaOnly_A9142.HiddenStatic;
			}
			set
			{
				short num = (short)454230017;
				if (num != 0)
				{
				}
				num = (short)1246627161;
				short num2 = num;
				num = (short)97060185;
				switch (num2 == num)
				{
				}
				num = (short)1155989504;
				if (num != 0)
				{
				}
				num = (short)1399914496;
				short num3 = num;
				this.radWideLabtoolSirenPaOnly_A9142.HiddenStatic = value;
			}
		}

		// Token: 0x17001C36 RID: 7222
		// (get) Token: 0x06003798 RID: 14232 RVA: 0x00351428 File Offset: 0x0034F628
		// (set) Token: 0x06003799 RID: 14233 RVA: 0x003514E0 File Offset: 0x0034F6E0
		internal bool RadWideLabtoolSirenPaOnly_A9142_HiddenDynamic
		{
			get
			{
				short num = (short)1779747606;
				short num2 = num;
				num = (short)82365206;
				switch (num2 == num)
				{
				}
				num = (short)1008795649;
				if (num != 0)
				{
				}
				num = (short)1060110336;
				if (num != 0)
				{
				}
				num = (short)98238464;
				short num3 = num;
				return this.radWideLabtoolSirenPaOnly_A9142.HiddenDynamic;
			}
			set
			{
				short num = (short)1655046572;
				short num2 = num;
				num = (short)79298988;
				switch (num2 == num)
				{
				}
				num = (short)957939712;
				if (num != 0)
				{
				}
				num = (short)1011744769;
				if (num != 0)
				{
				}
				num = (short)1211301888;
				short num3 = num;
				this.radWideLabtoolSirenPaOnly_A9142.HiddenDynamic = value;
			}
		}

		// Token: 0x17001C37 RID: 7223
		// (get) Token: 0x0600379A RID: 14234 RVA: 0x00351598 File Offset: 0x0034F798
		public bool RadWideLabtoolSirenPaOnly_A9142_HasDiffs
		{
			get
			{
				short num = (short)1043461626;
				short num2 = num;
				num = (short)1616836090;
				switch (num2 == num)
				{
				}
				num = (short)1294925824;
				if (num != 0)
				{
				}
				num = (short)200474625;
				if (num != 0)
				{
				}
				num = (short)620429312;
				short num3 = num;
				return this.radWideLabtoolSirenPaOnly_A9142._HasDiffs;
			}
		}

		// Token: 0x17001C38 RID: 7224
		// (get) Token: 0x0600379B RID: 14235 RVA: 0x0035164C File Offset: 0x0034F84C
		// (set) Token: 0x0600379C RID: 14236 RVA: 0x00351700 File Offset: 0x0034F900
		public bool RadWideLabtoolSirenPaSystemLookup_A9143Value
		{
			get
			{
				short num = (short)1883176961;
				if (num != 0)
				{
				}
				num = (short)865091807;
				short num2 = num;
				num = (short)2121482463;
				switch (num2 == num)
				{
				}
				num = (short)1516371968;
				if (num != 0)
				{
				}
				num = (short)151715840;
				short num3 = num;
				return this.radWideLabtoolSirenPaSystemLookup_A9143.Value;
			}
			set
			{
				short num = (short)1810521932;
				short num2 = num;
				num = (short)299130700;
				switch (num2 == num)
				{
				}
				num = (short)970326017;
				if (num != 0)
				{
				}
				num = (short)202833920;
				if (num != 0)
				{
				}
				num = (short)390266880;
				short num3 = num;
				this.radWideLabtoolSirenPaSystemLookup_A9143.Value = value;
			}
		}

		// Token: 0x17001C39 RID: 7225
		// (get) Token: 0x0600379D RID: 14237 RVA: 0x003517B4 File Offset: 0x0034F9B4
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolSirenPaSystemLookup_A9143
		{
			get
			{
				short num = (short)1047910761;
				short num2 = num;
				num = (short)951703913;
				switch (num2 == num)
				{
				}
				num = (short)1041432577;
				if (num != 0)
				{
				}
				num = (short)500301824;
				if (num != 0)
				{
				}
				num = (short)1640103936;
				short num3 = num;
				return this.radWideLabtoolSirenPaSystemLookup_A9143;
			}
		}

		// Token: 0x17001C3A RID: 7226
		// (get) Token: 0x0600379E RID: 14238 RVA: 0x00351864 File Offset: 0x0034FA64
		// (set) Token: 0x0600379F RID: 14239 RVA: 0x00351918 File Offset: 0x0034FB18
		public bool RadWideLabtoolSirenPaSystemLookup_A9143_UIValue
		{
			get
			{
				short num = (short)1189304155;
				short num2 = num;
				num = (short)1106270043;
				switch (num2 == num)
				{
				}
				num = (short)147980289;
				if (num != 0)
				{
				}
				num = (short)2024865792;
				if (num != 0)
				{
				}
				num = (short)1142620160;
				short num3 = num;
				return this.radWideLabtoolSirenPaSystemLookup_A9143.Value;
			}
			set
			{
				short num = (short)1170657082;
				short num2 = num;
				num = (short)2065944378;
				switch (num2 == num)
				{
				}
				num = (short)138280961;
				if (num != 0)
				{
				}
				num = (short)1009123328;
				if (num != 0)
				{
				}
				num = (short)827260928;
				short num3 = num;
				this.radWideLabtoolSirenPaSystemLookup_A9143.Value = value;
			}
		}

		// Token: 0x17001C3B RID: 7227
		// (get) Token: 0x060037A0 RID: 14240 RVA: 0x003519CC File Offset: 0x0034FBCC
		// (set) Token: 0x060037A1 RID: 14241 RVA: 0x00351A84 File Offset: 0x0034FC84
		public bool RadWideLabtoolSirenPaSystemLookup_A9143_Applicable
		{
			get
			{
				short num = (short)290903176;
				short num2 = num;
				num = (short)1453642888;
				switch (num2 == num)
				{
				}
				num = (short)362217472;
				if (num != 0)
				{
				}
				num = (short)728170497;
				if (num != 0)
				{
				}
				num = (short)45219840;
				short num3 = num;
				return this.radWideLabtoolSirenPaSystemLookup_A9143.Applicable;
			}
			set
			{
				short num = (short)749016375;
				short num2 = num;
				num = (short)2118980919;
				switch (num2 == num)
				{
				}
				num = (short)1130102784;
				if (num != 0)
				{
				}
				num = (short)2116616193;
				if (num != 0)
				{
				}
				num = (short)398721024;
				short num3 = num;
				this.radWideLabtoolSirenPaSystemLookup_A9143.Applicable = value;
			}
		}

		// Token: 0x17001C3C RID: 7228
		// (get) Token: 0x060037A2 RID: 14242 RVA: 0x00351B3C File Offset: 0x0034FD3C
		// (set) Token: 0x060037A3 RID: 14243 RVA: 0x00351BF0 File Offset: 0x0034FDF0
		public bool RadWideLabtoolSirenPaSystemLookup_A9143_Valid
		{
			get
			{
				short num = (short)1447370331;
				short num2 = num;
				num = (short)1567759963;
				switch (num2 == num)
				{
				}
				num = (short)562429953;
				if (num != 0)
				{
				}
				num = (short)1301610496;
				if (num != 0)
				{
				}
				num = (short)1128660992;
				short num3 = num;
				return this.radWideLabtoolSirenPaSystemLookup_A9143.Valid;
			}
			set
			{
				short num = (short)496851490;
				short num2 = num;
				num = (short)1448368674;
				switch (num2 == num)
				{
				}
				num = (short)17956865;
				if (num != 0)
				{
				}
				num = (short)1695350784;
				if (num != 0)
				{
				}
				num = (short)545325056;
				short num3 = num;
				this.radWideLabtoolSirenPaSystemLookup_A9143.Valid = value;
			}
		}

		// Token: 0x17001C3D RID: 7229
		// (get) Token: 0x060037A4 RID: 14244 RVA: 0x00351CA8 File Offset: 0x0034FEA8
		// (set) Token: 0x060037A5 RID: 14245 RVA: 0x00351D5C File Offset: 0x0034FF5C
		public bool RadWideLabtoolSirenPaSystemLookup_A9143_Visible
		{
			get
			{
				short num = (short)1169875433;
				short num2 = num;
				num = (short)110092777;
				switch (num2 == num)
				{
				}
				num = (short)1955135488;
				if (num != 0)
				{
				}
				num = (short)380567553;
				if (num != 0)
				{
				}
				num = (short)541786112;
				short num3 = num;
				return this.radWideLabtoolSirenPaSystemLookup_A9143.Visible;
			}
			set
			{
				short num = (short)1197434543;
				short num2 = num;
				num = (short)610952879;
				switch (num2 == num)
				{
				}
				num = (short)1076756481;
				if (num != 0)
				{
				}
				num = (short)1050738688;
				if (num != 0)
				{
				}
				num = (short)2079719424;
				short num3 = num;
				this.radWideLabtoolSirenPaSystemLookup_A9143.Visible = value;
			}
		}

		// Token: 0x17001C3E RID: 7230
		// (get) Token: 0x060037A6 RID: 14246 RVA: 0x00351E10 File Offset: 0x00350010
		// (set) Token: 0x060037A7 RID: 14247 RVA: 0x00351EC4 File Offset: 0x003500C4
		public bool RadWideLabtoolSirenPaSystemLookup_A9143_Editable
		{
			get
			{
				short num = (short)1295515649;
				if (num != 0)
				{
				}
				num = (short)761064656;
				short num2 = num;
				num = (short)576646352;
				switch (num2 == num)
				{
				}
				num = (short)1383071744;
				if (num != 0)
				{
				}
				num = (short)22937600;
				short num3 = num;
				return this.radWideLabtoolSirenPaSystemLookup_A9143.Editable;
			}
			set
			{
				short num = (short)1187180538;
				short num2 = num;
				num = (short)1761275898;
				switch (num2 == num)
				{
				}
				num = (short)150405121;
				if (num != 0)
				{
				}
				num = (short)830668800;
				if (num != 0)
				{
				}
				num = (short)821559296;
				short num3 = num;
				this.radWideLabtoolSirenPaSystemLookup_A9143.Editable = value;
			}
		}

		// Token: 0x17001C3F RID: 7231
		// (get) Token: 0x060037A8 RID: 14248 RVA: 0x00351F7C File Offset: 0x0035017C
		internal string RadWideLabtoolSirenPaSystemLookup_A9143_UILabel
		{
			get
			{
				short num = (short)1079312385;
				if (num != 0)
				{
				}
				num = (short)556720868;
				short num2 = num;
				num = (short)1808655076;
				switch (num2 == num)
				{
				}
				num = (short)1223426048;
				if (num != 0)
				{
				}
				num = (short)1109065728;
				short num3 = num;
				return this.radWideLabtoolSirenPaSystemLookup_A9143.UIName;
			}
		}

		// Token: 0x17001C40 RID: 7232
		// (get) Token: 0x060037A9 RID: 14249 RVA: 0x00352030 File Offset: 0x00350230
		// (set) Token: 0x060037AA RID: 14250 RVA: 0x003520E4 File Offset: 0x003502E4
		internal bool RadWideLabtoolSirenPaSystemLookup_A9143_HiddenStatic
		{
			get
			{
				short num = (short)1373500833;
				short num2 = num;
				num = (short)1690695073;
				switch (num2 == num)
				{
				}
				num = (short)386465793;
				if (num != 0)
				{
				}
				num = (short)1341456384;
				if (num != 0)
				{
				}
				num = (short)2043412480;
				short num3 = num;
				return this.radWideLabtoolSirenPaSystemLookup_A9143.HiddenStatic;
			}
			set
			{
				short num = (short)102760449;
				if (num != 0)
				{
				}
				num = (short)62015000;
				short num2 = num;
				num = (short)500647448;
				switch (num2 == num)
				{
				}
				num = (short)832438272;
				if (num != 0)
				{
				}
				num = (short)225771520;
				short num3 = num;
				this.radWideLabtoolSirenPaSystemLookup_A9143.HiddenStatic = value;
			}
		}

		// Token: 0x17001C41 RID: 7233
		// (get) Token: 0x060037AB RID: 14251 RVA: 0x00352198 File Offset: 0x00350398
		// (set) Token: 0x060037AC RID: 14252 RVA: 0x00352250 File Offset: 0x00350450
		internal bool RadWideLabtoolSirenPaSystemLookup_A9143_HiddenDynamic
		{
			get
			{
				short num = (short)899317589;
				short num2 = num;
				num = (short)423133013;
				switch (num2 == num)
				{
				}
				num = (short)1713831937;
				if (num != 0)
				{
				}
				num = (short)781320192;
				if (num != 0)
				{
				}
				num = (short)1396834304;
				short num3 = num;
				return this.radWideLabtoolSirenPaSystemLookup_A9143.HiddenDynamic;
			}
			set
			{
				short num = (short)13621727;
				short num2 = num;
				num = (short)1013373407;
				switch (num2 == num)
				{
				}
				num = (short)1566572544;
				if (num != 0)
				{
				}
				num = (short)1602027521;
				if (num != 0)
				{
				}
				num = (short)1504313344;
				short num3 = num;
				this.radWideLabtoolSirenPaSystemLookup_A9143.HiddenDynamic = value;
			}
		}

		// Token: 0x17001C42 RID: 7234
		// (get) Token: 0x060037AD RID: 14253 RVA: 0x00352304 File Offset: 0x00350504
		public bool RadWideLabtoolSirenPaSystemLookup_A9143_HasDiffs
		{
			get
			{
				short num = (short)1380819612;
				short num2 = num;
				num = (short)1801167516;
				switch (num2 == num)
				{
				}
				num = (short)633143297;
				if (num != 0)
				{
				}
				num = (short)1804009472;
				if (num != 0)
				{
				}
				num = (short)799604736;
				short num3 = num;
				return this.radWideLabtoolSirenPaSystemLookup_A9143._HasDiffs;
			}
		}

		// Token: 0x17001C43 RID: 7235
		// (get) Token: 0x060037AE RID: 14254 RVA: 0x003523B8 File Offset: 0x003505B8
		// (set) Token: 0x060037AF RID: 14255 RVA: 0x00352470 File Offset: 0x00350670
		public bool TrunkingRadioInhibited_A19483Value
		{
			get
			{
				short num = (short)1362339286;
				short num2 = num;
				num = (short)1216456150;
				switch (num2 == num)
				{
				}
				num = (short)998178817;
				if (num != 0)
				{
				}
				num = (short)1234894848;
				if (num != 0)
				{
				}
				num = (short)1496055808;
				short num3 = num;
				return this.trunkingRadioInhibited_A19483.Value;
			}
			set
			{
				short num = (short)984767991;
				short num2 = num;
				num = (short)1725193719;
				switch (num2 == num)
				{
				}
				num = (short)356712449;
				if (num != 0)
				{
				}
				num = (short)1053491200;
				if (num != 0)
				{
				}
				num = (short)1111556096;
				short num3 = num;
				this.trunkingRadioInhibited_A19483.Value = value;
			}
		}

		// Token: 0x17001C44 RID: 7236
		// (get) Token: 0x060037B0 RID: 14256 RVA: 0x00352524 File Offset: 0x00350724
		public global::AcpBusinessLayer.AcpField<bool> TrunkingRadioInhibited_A19483
		{
			get
			{
				short num = (short)1956148049;
				short num2 = num;
				num = (short)736654161;
				switch (num2 == num)
				{
				}
				num = (short)316342273;
				if (num != 0)
				{
				}
				num = (short)1419575296;
				if (num != 0)
				{
				}
				num = (short)755367936;
				short num3 = num;
				return this.trunkingRadioInhibited_A19483;
			}
		}

		// Token: 0x17001C45 RID: 7237
		// (get) Token: 0x060037B1 RID: 14257 RVA: 0x003525D4 File Offset: 0x003507D4
		// (set) Token: 0x060037B2 RID: 14258 RVA: 0x00352688 File Offset: 0x00350888
		public bool TrunkingRadioInhibited_A19483_UIValue
		{
			get
			{
				short num = (short)756537433;
				short num2 = num;
				num = (short)1361500249;
				switch (num2 == num)
				{
				}
				num = (short)1221984257;
				if (num != 0)
				{
				}
				num = (short)2017722368;
				if (num != 0)
				{
				}
				num = (short)1886453760;
				short num3 = num;
				return this.trunkingRadioInhibited_A19483.Value;
			}
			set
			{
				short num = (short)2112749569;
				if (num != 0)
				{
				}
				num = (short)2050604641;
				short num2 = num;
				num = (short)2074066529;
				switch (num2 == num)
				{
				}
				num = (short)930021376;
				if (num != 0)
				{
				}
				num = (short)975634432;
				short num3 = num;
				this.trunkingRadioInhibited_A19483.Value = value;
			}
		}

		// Token: 0x17001C46 RID: 7238
		// (get) Token: 0x060037B3 RID: 14259 RVA: 0x0035273C File Offset: 0x0035093C
		// (set) Token: 0x060037B4 RID: 14260 RVA: 0x003527F0 File Offset: 0x003509F0
		public bool TrunkingRadioInhibited_A19483_Applicable
		{
			get
			{
				short num = (short)828503429;
				short num2 = num;
				num = (short)873592197;
				switch (num2 == num)
				{
				}
				num = (short)1491206145;
				if (num != 0)
				{
				}
				num = (short)1655373824;
				if (num != 0)
				{
				}
				num = (short)337903616;
				short num3 = num;
				return this.trunkingRadioInhibited_A19483.Applicable;
			}
			set
			{
				short num = (short)787938805;
				short num2 = num;
				num = (short)338558453;
				switch (num2 == num)
				{
				}
				num = (short)225509377;
				if (num != 0)
				{
				}
				num = (short)264962048;
				if (num != 0)
				{
				}
				num = (short)1543766016;
				short num3 = num;
				this.trunkingRadioInhibited_A19483.Applicable = value;
			}
		}

		// Token: 0x17001C47 RID: 7239
		// (get) Token: 0x060037B5 RID: 14261 RVA: 0x003528A8 File Offset: 0x00350AA8
		// (set) Token: 0x060037B6 RID: 14262 RVA: 0x0035295C File Offset: 0x00350B5C
		public bool TrunkingRadioInhibited_A19483_Valid
		{
			get
			{
				short num = (short)1821376513;
				if (num != 0)
				{
				}
				num = (short)1250782371;
				short num2 = num;
				num = (short)1931701411;
				switch (num2 == num)
				{
				}
				num = (short)1468792832;
				if (num != 0)
				{
				}
				num = (short)771686400;
				short num3 = num;
				return this.trunkingRadioInhibited_A19483.Valid;
			}
			set
			{
				short num = (short)1469084000;
				short num2 = num;
				num = (short)722825568;
				switch (num2 == num)
				{
				}
				num = (short)112394241;
				if (num != 0)
				{
				}
				num = (short)1448083456;
				if (num != 0)
				{
				}
				num = (short)445775872;
				short num3 = num;
				this.trunkingRadioInhibited_A19483.Valid = value;
			}
		}

		// Token: 0x17001C48 RID: 7240
		// (get) Token: 0x060037B7 RID: 14263 RVA: 0x00352A14 File Offset: 0x00350C14
		// (set) Token: 0x060037B8 RID: 14264 RVA: 0x00352AC8 File Offset: 0x00350CC8
		public bool TrunkingRadioInhibited_A19483_Visible
		{
			get
			{
				short num = (short)75497473;
				if (num != 0)
				{
				}
				num = (short)1690951329;
				short num2 = num;
				num = (short)1900863137;
				switch (num2 == num)
				{
				}
				num = (short)1624834048;
				if (num != 0)
				{
				}
				num = (short)1058603008;
				short num3 = num;
				return this.trunkingRadioInhibited_A19483.Visible;
			}
			set
			{
				short num = (short)480932417;
				short num2 = num;
				num = (short)1057190465;
				switch (num2 == num)
				{
				}
				num = (short)1777467393;
				if (num != 0)
				{
				}
				num = (short)1168900096;
				if (num != 0)
				{
				}
				num = (short)1866727424;
				short num3 = num;
				this.trunkingRadioInhibited_A19483.Visible = value;
			}
		}

		// Token: 0x17001C49 RID: 7241
		// (get) Token: 0x060037B9 RID: 14265 RVA: 0x00352B7C File Offset: 0x00350D7C
		// (set) Token: 0x060037BA RID: 14266 RVA: 0x00352C34 File Offset: 0x00350E34
		public bool TrunkingRadioInhibited_A19483_Editable
		{
			get
			{
				short num = (short)2010722570;
				short num2 = num;
				num = (short)1155215626;
				switch (num2 == num)
				{
				}
				num = (short)533725184;
				if (num != 0)
				{
				}
				num = (short)1271136257;
				if (num != 0)
				{
				}
				num = (short)317456384;
				short num3 = num;
				return this.trunkingRadioInhibited_A19483.Editable;
			}
			set
			{
				short num = (short)1168458485;
				short num2 = num;
				num = (short)1401701109;
				switch (num2 == num)
				{
				}
				num = (short)1124073472;
				if (num != 0)
				{
				}
				num = (short)1584791553;
				if (num != 0)
				{
				}
				num = (short)142213120;
				short num3 = num;
				this.trunkingRadioInhibited_A19483.Editable = value;
			}
		}

		// Token: 0x17001C4A RID: 7242
		// (get) Token: 0x060037BB RID: 14267 RVA: 0x00352CEC File Offset: 0x00350EEC
		internal string TrunkingRadioInhibited_A19483_UILabel
		{
			get
			{
				short num = (short)1007265868;
				short num2 = num;
				num = (short)1742055500;
				switch (num2 == num)
				{
				}
				num = (short)1524432897;
				if (num != 0)
				{
				}
				num = (short)73662464;
				if (num != 0)
				{
				}
				num = (short)825425920;
				short num3 = num;
				return this.trunkingRadioInhibited_A19483.UIName;
			}
		}

		// Token: 0x17001C4B RID: 7243
		// (get) Token: 0x060037BC RID: 14268 RVA: 0x00352DA0 File Offset: 0x00350FA0
		// (set) Token: 0x060037BD RID: 14269 RVA: 0x00352E58 File Offset: 0x00351058
		internal bool TrunkingRadioInhibited_A19483_HiddenStatic
		{
			get
			{
				short num = (short)532947357;
				short num2 = num;
				num = (short)1518739869;
				switch (num2 == num)
				{
				}
				num = (short)1770913792;
				if (num != 0)
				{
				}
				num = (short)1324548097;
				if (num != 0)
				{
				}
				num = (short)789250048;
				short num3 = num;
				return this.trunkingRadioInhibited_A19483.HiddenStatic;
			}
			set
			{
				short num = (short)1799003171;
				short num2 = num;
				num = (short)409508899;
				switch (num2 == num)
				{
				}
				num = (short)1922301953;
				if (num != 0)
				{
				}
				num = (short)394395648;
				if (num != 0)
				{
				}
				num = (short)569573376;
				short num3 = num;
				this.trunkingRadioInhibited_A19483.HiddenStatic = value;
			}
		}

		// Token: 0x17001C4C RID: 7244
		// (get) Token: 0x060037BE RID: 14270 RVA: 0x00352F0C File Offset: 0x0035110C
		// (set) Token: 0x060037BF RID: 14271 RVA: 0x00352FC0 File Offset: 0x003511C0
		internal bool TrunkingRadioInhibited_A19483_HiddenDynamic
		{
			get
			{
				short num = (short)2094381611;
				short num2 = num;
				num = (short)464501291;
				switch (num2 == num)
				{
				}
				num = (short)166133760;
				if (num != 0)
				{
				}
				num = (short)1382416385;
				if (num != 0)
				{
				}
				num = (short)1065811968;
				short num3 = num;
				return this.trunkingRadioInhibited_A19483.HiddenDynamic;
			}
			set
			{
				short num = (short)826137047;
				short num2 = num;
				num = (short)404740567;
				switch (num2 == num)
				{
				}
				num = (short)122880001;
				if (num != 0)
				{
				}
				num = (short)904658944;
				if (num != 0)
				{
				}
				num = (short)1398931456;
				short num3 = num;
				this.trunkingRadioInhibited_A19483.HiddenDynamic = value;
			}
		}

		// Token: 0x17001C4D RID: 7245
		// (get) Token: 0x060037C0 RID: 14272 RVA: 0x00353074 File Offset: 0x00351274
		public bool TrunkingRadioInhibited_A19483_HasDiffs
		{
			get
			{
				short num = (short)1574974800;
				short num2 = num;
				num = (short)871642448;
				switch (num2 == num)
				{
				}
				num = (short)868941825;
				if (num != 0)
				{
				}
				num = (short)866058240;
				if (num != 0)
				{
				}
				num = (short)1940848640;
				short num3 = num;
				return this.trunkingRadioInhibited_A19483._HasDiffs;
			}
		}

		// Token: 0x17001C4E RID: 7246
		// (get) Token: 0x060037C1 RID: 14273 RVA: 0x0035312C File Offset: 0x0035132C
		// (set) Token: 0x060037C2 RID: 14274 RVA: 0x003531E0 File Offset: 0x003513E0
		public bool RadWideLabtoolZoneSelectorOnSwitch_A19550Value
		{
			get
			{
				short num = (short)183649309;
				short num2 = num;
				num = (short)1341604893;
				switch (num2 == num)
				{
				}
				num = (short)4259841;
				if (num != 0)
				{
				}
				num = (short)1196425216;
				short num3 = num;
				num = (short)298188800;
				if (num != 0)
				{
				}
				return this.radWideLabtoolZoneSelectorOnSwitch_A19550.Value;
			}
			set
			{
				short num = (short)294599300;
				short num2 = num;
				num = (short)2076129924;
				switch (num2 == num)
				{
				}
				num = (short)822214656;
				if (num != 0)
				{
				}
				num = (short)1629224960;
				short num3 = num;
				num = (short)1663762433;
				if (num != 0)
				{
				}
				this.radWideLabtoolZoneSelectorOnSwitch_A19550.Value = value;
			}
		}

		// Token: 0x17001C4F RID: 7247
		// (get) Token: 0x060037C3 RID: 14275 RVA: 0x00353298 File Offset: 0x00351498
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolZoneSelectorOnSwitch_A19550
		{
			get
			{
				short num = (short)1363927046;
				short num2 = num;
				num = (short)1544871942;
				switch (num2 == num)
				{
				}
				num = (short)1701314561;
				if (num != 0)
				{
				}
				num = (short)1031143424;
				short num3 = num;
				num = (short)18087936;
				if (num != 0)
				{
				}
				return this.radWideLabtoolZoneSelectorOnSwitch_A19550;
			}
		}

		// Token: 0x17001C50 RID: 7248
		// (get) Token: 0x060037C4 RID: 14276 RVA: 0x00353348 File Offset: 0x00351548
		// (set) Token: 0x060037C5 RID: 14277 RVA: 0x003533FC File Offset: 0x003515FC
		public bool RadWideLabtoolZoneSelectorOnSwitch_A19550_UIValue
		{
			get
			{
				short num = (short)1527307468;
				short num2 = num;
				num = (short)291298508;
				switch (num2 == num)
				{
				}
				num = (short)834076673;
				if (num != 0)
				{
				}
				num = (short)1497956352;
				short num3 = num;
				num = (short)1975386112;
				if (num != 0)
				{
				}
				return this.radWideLabtoolZoneSelectorOnSwitch_A19550.Value;
			}
			set
			{
				short num = (short)569311233;
				if (num != 0)
				{
				}
				num = (short)1751981049;
				short num2 = num;
				num = (short)1701649401;
				switch (num2 == num)
				{
				}
				num = (short)315162624;
				short num3 = num;
				num = (short)825163776;
				if (num != 0)
				{
				}
				this.radWideLabtoolZoneSelectorOnSwitch_A19550.Value = value;
			}
		}

		// Token: 0x17001C51 RID: 7249
		// (get) Token: 0x060037C6 RID: 14278 RVA: 0x003534B0 File Offset: 0x003516B0
		// (set) Token: 0x060037C7 RID: 14279 RVA: 0x00353564 File Offset: 0x00351764
		public bool RadWideLabtoolZoneSelectorOnSwitch_A19550_Applicable
		{
			get
			{
				short num = (short)1433030050;
				short num2 = num;
				num = (short)1628261794;
				switch (num2 == num)
				{
				}
				num = (short)221511680;
				if (num != 0)
				{
				}
				num = (short)1034878976;
				short num3 = num;
				num = (short)374407169;
				if (num != 0)
				{
				}
				return this.radWideLabtoolZoneSelectorOnSwitch_A19550.Applicable;
			}
			set
			{
				short num = (short)761004033;
				if (num != 0)
				{
				}
				num = (short)1193915619;
				short num2 = num;
				num = (short)1872147683;
				switch (num2 == num)
				{
				}
				num = (short)1582366720;
				short num3 = num;
				num = (short)1740242944;
				if (num != 0)
				{
				}
				this.radWideLabtoolZoneSelectorOnSwitch_A19550.Applicable = value;
			}
		}

		// Token: 0x17001C52 RID: 7250
		// (get) Token: 0x060037C8 RID: 14280 RVA: 0x00353618 File Offset: 0x00351818
		// (set) Token: 0x060037C9 RID: 14281 RVA: 0x003536CC File Offset: 0x003518CC
		public bool RadWideLabtoolZoneSelectorOnSwitch_A19550_Valid
		{
			get
			{
				short num = (short)860168096;
				short num2 = num;
				num = (short)442048416;
				switch (num2 == num)
				{
				}
				num = (short)12976129;
				if (num != 0)
				{
				}
				num = (short)857341952;
				short num3 = num;
				num = (short)60489728;
				if (num != 0)
				{
				}
				return this.radWideLabtoolZoneSelectorOnSwitch_A19550.Valid;
			}
			set
			{
				short num = (short)37360330;
				short num2 = num;
				num = (short)473436874;
				switch (num2 == num)
				{
				}
				num = (short)515047425;
				if (num != 0)
				{
				}
				num = (short)570294272;
				short num3 = num;
				num = (short)74579968;
				if (num != 0)
				{
				}
				this.radWideLabtoolZoneSelectorOnSwitch_A19550.Valid = value;
			}
		}

		// Token: 0x17001C53 RID: 7251
		// (get) Token: 0x060037CA RID: 14282 RVA: 0x00353780 File Offset: 0x00351980
		// (set) Token: 0x060037CB RID: 14283 RVA: 0x00353834 File Offset: 0x00351A34
		public bool RadWideLabtoolZoneSelectorOnSwitch_A19550_Visible
		{
			get
			{
				short num = (short)832805062;
				short num2 = num;
				num = (short)1095604422;
				switch (num2 == num)
				{
				}
				num = (short)1747320832;
				if (num != 0)
				{
				}
				num = (short)593952768;
				short num3 = num;
				num = (short)446758913;
				if (num != 0)
				{
				}
				return this.radWideLabtoolZoneSelectorOnSwitch_A19550.Visible;
			}
			set
			{
				short num = (short)522190849;
				if (num != 0)
				{
				}
				num = (short)1225648014;
				short num2 = num;
				num = (short)1570891662;
				switch (num2 == num)
				{
				}
				num = (short)2022506496;
				short num3 = num;
				num = (short)823263232;
				if (num != 0)
				{
				}
				this.radWideLabtoolZoneSelectorOnSwitch_A19550.Visible = value;
			}
		}

		// Token: 0x17001C54 RID: 7252
		// (get) Token: 0x060037CC RID: 14284 RVA: 0x003538E8 File Offset: 0x00351AE8
		// (set) Token: 0x060037CD RID: 14285 RVA: 0x003539A0 File Offset: 0x00351BA0
		public bool RadWideLabtoolZoneSelectorOnSwitch_A19550_Editable
		{
			get
			{
				short num = (short)1299426675;
				short num2 = num;
				num = (short)1276685683;
				switch (num2 == num)
				{
				}
				num = (short)673513473;
				if (num != 0)
				{
				}
				num = (short)604241920;
				short num3 = num;
				num = (short)166985728;
				if (num != 0)
				{
				}
				return this.radWideLabtoolZoneSelectorOnSwitch_A19550.Editable;
			}
			set
			{
				short num = (short)2009060882;
				short num2 = num;
				num = (short)203675154;
				switch (num2 == num)
				{
				}
				num = (short)654770177;
				if (num != 0)
				{
				}
				num = (short)311361536;
				short num3 = num;
				num = (short)2123497472;
				if (num != 0)
				{
				}
				this.radWideLabtoolZoneSelectorOnSwitch_A19550.Editable = value;
			}
		}

		// Token: 0x17001C55 RID: 7253
		// (get) Token: 0x060037CE RID: 14286 RVA: 0x00353A54 File Offset: 0x00351C54
		internal string RadWideLabtoolZoneSelectorOnSwitch_A19550_UILabel
		{
			get
			{
				short num = (short)1595681657;
				short num2 = num;
				num = (short)725429113;
				switch (num2 == num)
				{
				}
				num = (short)346488833;
				if (num != 0)
				{
				}
				num = (short)810221568;
				short num3 = num;
				num = (short)2010710016;
				if (num != 0)
				{
				}
				return this.radWideLabtoolZoneSelectorOnSwitch_A19550.UIName;
			}
		}

		// Token: 0x17001C56 RID: 7254
		// (get) Token: 0x060037CF RID: 14287 RVA: 0x00353B08 File Offset: 0x00351D08
		// (set) Token: 0x060037D0 RID: 14288 RVA: 0x00353BBC File Offset: 0x00351DBC
		internal bool RadWideLabtoolZoneSelectorOnSwitch_A19550_HiddenStatic
		{
			get
			{
				short num = (short)241379450;
				short num2 = num;
				num = (short)1302145146;
				switch (num2 == num)
				{
				}
				num = (short)2082930689;
				if (num != 0)
				{
				}
				num = (short)1626603520;
				short num3 = num;
				num = (short)1434910720;
				if (num != 0)
				{
				}
				return this.radWideLabtoolZoneSelectorOnSwitch_A19550.HiddenStatic;
			}
			set
			{
				short num = (short)218258390;
				short num2 = num;
				num = (short)1296128982;
				switch (num2 == num)
				{
				}
				num = (short)272171008;
				if (num != 0)
				{
				}
				num = (short)122224640;
				short num3 = num;
				num = (short)321716225;
				if (num != 0)
				{
				}
				this.radWideLabtoolZoneSelectorOnSwitch_A19550.HiddenStatic = value;
			}
		}

		// Token: 0x17001C57 RID: 7255
		// (get) Token: 0x060037D1 RID: 14289 RVA: 0x00353C70 File Offset: 0x00351E70
		// (set) Token: 0x060037D2 RID: 14290 RVA: 0x00353D24 File Offset: 0x00351F24
		internal bool RadWideLabtoolZoneSelectorOnSwitch_A19550_HiddenDynamic
		{
			get
			{
				short num = (short)977442819;
				short num2 = num;
				num = (short)438409219;
				switch (num2 == num)
				{
				}
				num = (short)1377894401;
				if (num != 0)
				{
				}
				num = (short)150470656;
				short num3 = num;
				num = (short)649986048;
				if (num != 0)
				{
				}
				return this.radWideLabtoolZoneSelectorOnSwitch_A19550.HiddenDynamic;
			}
			set
			{
				short num = (short)941673870;
				short num2 = num;
				num = (short)1658441102;
				switch (num2 == num)
				{
				}
				num = (short)83034112;
				if (num != 0)
				{
				}
				num = (short)1382023168;
				short num3 = num;
				num = (short)62717953;
				if (num != 0)
				{
				}
				this.radWideLabtoolZoneSelectorOnSwitch_A19550.HiddenDynamic = value;
			}
		}

		// Token: 0x17001C58 RID: 7256
		// (get) Token: 0x060037D3 RID: 14291 RVA: 0x00353DDC File Offset: 0x00351FDC
		public bool RadWideLabtoolZoneSelectorOnSwitch_A19550_HasDiffs
		{
			get
			{
				short num = (short)1648689153;
				if (num != 0)
				{
				}
				num = (short)807503602;
				short num2 = num;
				num = (short)1988200178;
				switch (num2 == num)
				{
				}
				num = (short)945815552;
				short num3 = num;
				num = (short)1813250048;
				if (num != 0)
				{
				}
				return this.radWideLabtoolZoneSelectorOnSwitch_A19550._HasDiffs;
			}
		}

		// Token: 0x17001C59 RID: 7257
		// (get) Token: 0x060037D4 RID: 14292 RVA: 0x00353E90 File Offset: 0x00352090
		// (set) Token: 0x060037D5 RID: 14293 RVA: 0x00353F44 File Offset: 0x00352144
		public bool RadWideLabtoolChannelSelectorOnSwitch_A19551Value
		{
			get
			{
				short num = (short)78053377;
				if (num != 0)
				{
				}
				num = (short)2025200391;
				short num2 = num;
				num = (short)748886791;
				switch (num2 == num)
				{
				}
				num = (short)1101070336;
				short num3 = num;
				num = (short)125108224;
				if (num != 0)
				{
				}
				return this.radWideLabtoolChannelSelectorOnSwitch_A19551.Value;
			}
			set
			{
				short num = (short)1149985238;
				short num2 = num;
				num = (short)623993302;
				switch (num2 == num)
				{
				}
				num = (short)1784086529;
				if (num != 0)
				{
				}
				num = (short)1978138624;
				short num3 = num;
				num = (short)59965440;
				if (num != 0)
				{
				}
				this.radWideLabtoolChannelSelectorOnSwitch_A19551.Value = value;
			}
		}

		// Token: 0x17001C5A RID: 7258
		// (get) Token: 0x060037D6 RID: 14294 RVA: 0x00353FF8 File Offset: 0x003521F8
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolChannelSelectorOnSwitch_A19551
		{
			get
			{
				short num = (short)518979585;
				if (num != 0)
				{
				}
				num = (short)220778821;
				short num2 = num;
				num = (short)1644745029;
				switch (num2 == num)
				{
				}
				num = (short)2080505856;
				short num3 = num;
				num = (short)1253900288;
				if (num != 0)
				{
				}
				return this.radWideLabtoolChannelSelectorOnSwitch_A19551;
			}
		}

		// Token: 0x17001C5B RID: 7259
		// (get) Token: 0x060037D7 RID: 14295 RVA: 0x003540A4 File Offset: 0x003522A4
		// (set) Token: 0x060037D8 RID: 14296 RVA: 0x0035415C File Offset: 0x0035235C
		public bool RadWideLabtoolChannelSelectorOnSwitch_A19551_UIValue
		{
			get
			{
				short num = (short)760768484;
				short num2 = num;
				num = (short)1036543972;
				switch (num2 == num)
				{
				}
				num = (short)1883308032;
				if (num != 0)
				{
				}
				num = (short)1539833856;
				short num3 = num;
				num = (short)974127105;
				if (num != 0)
				{
				}
				return this.radWideLabtoolChannelSelectorOnSwitch_A19551.Value;
			}
			set
			{
				short num = (short)856728534;
				short num2 = num;
				num = (short)176333782;
				switch (num2 == num)
				{
				}
				num = (short)1097007105;
				if (num != 0)
				{
				}
				num = (short)191889408;
				short num3 = num;
				num = (short)1118568448;
				if (num != 0)
				{
				}
				this.radWideLabtoolChannelSelectorOnSwitch_A19551.Value = value;
			}
		}

		// Token: 0x17001C5C RID: 7260
		// (get) Token: 0x060037D9 RID: 14297 RVA: 0x00354214 File Offset: 0x00352414
		// (set) Token: 0x060037DA RID: 14298 RVA: 0x003542CC File Offset: 0x003524CC
		public bool RadWideLabtoolChannelSelectorOnSwitch_A19551_Applicable
		{
			get
			{
				short num = (short)1361919930;
				short num2 = num;
				num = (short)993279930;
				switch (num2 == num)
				{
				}
				num = (short)1733689345;
				if (num != 0)
				{
				}
				num = (short)1279000576;
				short num3 = num;
				num = (short)317915136;
				if (num != 0)
				{
				}
				return this.radWideLabtoolChannelSelectorOnSwitch_A19551.Applicable;
			}
			set
			{
				short num = (short)459532256;
				short num2 = num;
				num = (short)1956964320;
				switch (num2 == num)
				{
				}
				num = (short)162136065;
				if (num != 0)
				{
				}
				num = (short)1474887680;
				short num3 = num;
				num = (short)1009713152;
				if (num != 0)
				{
				}
				this.radWideLabtoolChannelSelectorOnSwitch_A19551.Applicable = value;
			}
		}

		// Token: 0x17001C5D RID: 7261
		// (get) Token: 0x060037DB RID: 14299 RVA: 0x00354380 File Offset: 0x00352580
		// (set) Token: 0x060037DC RID: 14300 RVA: 0x00354434 File Offset: 0x00352634
		public bool RadWideLabtoolChannelSelectorOnSwitch_A19551_Valid
		{
			get
			{
				short num = (short)1921954015;
				short num2 = num;
				num = (short)1352839391;
				switch (num2 == num)
				{
				}
				num = (short)1376518144;
				if (num != 0)
				{
				}
				num = (short)477560832;
				short num3 = num;
				num = (short)1633812481;
				if (num != 0)
				{
				}
				return this.radWideLabtoolChannelSelectorOnSwitch_A19551.Valid;
			}
			set
			{
				short num = (short)884876218;
				short num2 = num;
				num = (short)396239802;
				switch (num2 == num)
				{
				}
				num = (short)1994063873;
				if (num != 0)
				{
				}
				num = (short)434241536;
				short num3 = num;
				num = (short)1810432000;
				if (num != 0)
				{
				}
				this.radWideLabtoolChannelSelectorOnSwitch_A19551.Valid = value;
			}
		}

		// Token: 0x17001C5E RID: 7262
		// (get) Token: 0x060037DD RID: 14301 RVA: 0x003544EC File Offset: 0x003526EC
		// (set) Token: 0x060037DE RID: 14302 RVA: 0x003545A4 File Offset: 0x003527A4
		public bool RadWideLabtoolChannelSelectorOnSwitch_A19551_Visible
		{
			get
			{
				short num = (short)1187660932;
				short num2 = num;
				num = (short)551830660;
				switch (num2 == num)
				{
				}
				num = (short)309985281;
				if (num != 0)
				{
				}
				num = (short)919928832;
				short num3 = num;
				num = (short)783941632;
				if (num != 0)
				{
				}
				return this.radWideLabtoolChannelSelectorOnSwitch_A19551.Visible;
			}
			set
			{
				short num = (short)1772015196;
				short num2 = num;
				num = (short)583913052;
				switch (num2 == num)
				{
				}
				num = (short)62062592;
				if (num != 0)
				{
				}
				num = (short)336265216;
				short num3 = num;
				num = (short)625999873;
				if (num != 0)
				{
				}
				this.radWideLabtoolChannelSelectorOnSwitch_A19551.Visible = value;
			}
		}

		// Token: 0x17001C5F RID: 7263
		// (get) Token: 0x060037DF RID: 14303 RVA: 0x00354658 File Offset: 0x00352858
		// (set) Token: 0x060037E0 RID: 14304 RVA: 0x0035470C File Offset: 0x0035290C
		public bool RadWideLabtoolChannelSelectorOnSwitch_A19551_Editable
		{
			get
			{
				short num = (short)1653098176;
				short num2 = num;
				num = (short)1910392512;
				switch (num2 == num)
				{
				}
				num = (short)294584320;
				if (num != 0)
				{
				}
				num = (short)216858624;
				short num3 = num;
				num = (short)1096155137;
				if (num != 0)
				{
				}
				return this.radWideLabtoolChannelSelectorOnSwitch_A19551.Editable;
			}
			set
			{
				short num = (short)1419459445;
				short num2 = num;
				num = (short)1821719413;
				switch (num2 == num)
				{
				}
				num = (short)186449920;
				if (num != 0)
				{
				}
				num = (short)127401984;
				short num3 = num;
				num = (short)1839267841;
				if (num != 0)
				{
				}
				this.radWideLabtoolChannelSelectorOnSwitch_A19551.Editable = value;
			}
		}

		// Token: 0x17001C60 RID: 7264
		// (get) Token: 0x060037E1 RID: 14305 RVA: 0x003547C4 File Offset: 0x003529C4
		internal string RadWideLabtoolChannelSelectorOnSwitch_A19551_UILabel
		{
			get
			{
				short num = (short)510946369;
				short num2 = num;
				num = (short)192310337;
				switch (num2 == num)
				{
				}
				num = (short)187957249;
				if (num != 0)
				{
				}
				num = (short)8716288;
				short num3 = num;
				num = (short)974520320;
				if (num != 0)
				{
				}
				return this.radWideLabtoolChannelSelectorOnSwitch_A19551.UIName;
			}
		}

		// Token: 0x17001C61 RID: 7265
		// (get) Token: 0x060037E2 RID: 14306 RVA: 0x00354878 File Offset: 0x00352A78
		// (set) Token: 0x060037E3 RID: 14307 RVA: 0x00354930 File Offset: 0x00352B30
		internal bool RadWideLabtoolChannelSelectorOnSwitch_A19551_HiddenStatic
		{
			get
			{
				short num = (short)2074692100;
				short num2 = num;
				num = (short)1206274564;
				switch (num2 == num)
				{
				}
				num = (short)225968128;
				if (num != 0)
				{
				}
				num = (short)1052573697;
				if (num != 0)
				{
				}
				num = (short)1472462848;
				short num3 = num;
				return this.radWideLabtoolChannelSelectorOnSwitch_A19551.HiddenStatic;
			}
			set
			{
				short num = (short)114922945;
				short num2 = num;
				num = (short)1381930433;
				switch (num2 == num)
				{
				}
				num = (short)1879310337;
				if (num != 0)
				{
				}
				num = (short)1074331648;
				if (num != 0)
				{
				}
				num = (short)2043215872;
				short num3 = num;
				this.radWideLabtoolChannelSelectorOnSwitch_A19551.HiddenStatic = value;
			}
		}

		// Token: 0x17001C62 RID: 7266
		// (get) Token: 0x060037E4 RID: 14308 RVA: 0x003549E8 File Offset: 0x00352BE8
		// (set) Token: 0x060037E5 RID: 14309 RVA: 0x00354A9C File Offset: 0x00352C9C
		internal bool RadWideLabtoolChannelSelectorOnSwitch_A19551_HiddenDynamic
		{
			get
			{
				short num = (short)1889232919;
				short num2 = num;
				num = (short)1371629591;
				switch (num2 == num)
				{
				}
				num = (short)1317470209;
				if (num != 0)
				{
				}
				num = (short)1863385088;
				if (num != 0)
				{
				}
				num = (short)1147994112;
				short num3 = num;
				return this.radWideLabtoolChannelSelectorOnSwitch_A19551.HiddenDynamic;
			}
			set
			{
				short num = (short)86230480;
				short num2 = num;
				num = (short)1446036944;
				switch (num2 == num)
				{
				}
				num = (short)71368705;
				if (num != 0)
				{
				}
				num = (short)571015168;
				if (num != 0)
				{
				}
				num = (short)1445199872;
				short num3 = num;
				this.radWideLabtoolChannelSelectorOnSwitch_A19551.HiddenDynamic = value;
			}
		}

		// Token: 0x17001C63 RID: 7267
		// (get) Token: 0x060037E6 RID: 14310 RVA: 0x00354B54 File Offset: 0x00352D54
		public bool RadWideLabtoolChannelSelectorOnSwitch_A19551_HasDiffs
		{
			get
			{
				short num = (short)565313537;
				if (num != 0)
				{
				}
				num = (short)1956217131;
				short num2 = num;
				num = (short)369721643;
				switch (num2 == num)
				{
				}
				num = (short)1607925760;
				if (num != 0)
				{
				}
				num = (short)14155776;
				short num3 = num;
				return this.radWideLabtoolChannelSelectorOnSwitch_A19551._HasDiffs;
			}
		}

		// Token: 0x17001C64 RID: 7268
		// (get) Token: 0x060037E7 RID: 14311 RVA: 0x00354C08 File Offset: 0x00352E08
		// (set) Token: 0x060037E8 RID: 14312 RVA: 0x00354CBC File Offset: 0x00352EBC
		public int RadWideLabtoolSmartLowBatteryThreshold_A20201Value
		{
			get
			{
				short num = (short)311056215;
				short num2 = num;
				num = (short)661870423;
				switch (num2 == num)
				{
				}
				num = (short)1507262465;
				if (num != 0)
				{
				}
				num = (short)1809252352;
				if (num != 0)
				{
				}
				num = (short)1278672896;
				short num3 = num;
				return this.radWideLabtoolSmartLowBatteryThreshold_A20201.Value;
			}
			set
			{
				short num = (short)859867831;
				short num2 = num;
				num = (short)1020627639;
				switch (num2 == num)
				{
				}
				num = (short)1164443649;
				if (num != 0)
				{
				}
				num = (short)1617231872;
				if (num != 0)
				{
				}
				num = (short)1690042368;
				short num3 = num;
				this.radWideLabtoolSmartLowBatteryThreshold_A20201.Value = value;
			}
		}

		// Token: 0x17001C65 RID: 7269
		// (get) Token: 0x060037E9 RID: 14313 RVA: 0x00354D74 File Offset: 0x00352F74
		public global::AcpBusinessLayer.AcpRangeField<int, string> RadWideLabtoolSmartLowBatteryThreshold_A20201
		{
			get
			{
				short num = (short)1976174974;
				short num2 = num;
				num = (short)2142767486;
				switch (num2 == num)
				{
				}
				num = (short)2001928192;
				if (num != 0)
				{
				}
				num = (short)1090322433;
				if (num != 0)
				{
				}
				num = (short)103612416;
				short num3 = num;
				return this.radWideLabtoolSmartLowBatteryThreshold_A20201;
			}
		}

		// Token: 0x17001C66 RID: 7270
		// (get) Token: 0x060037EA RID: 14314 RVA: 0x00354E24 File Offset: 0x00353024
		// (set) Token: 0x060037EB RID: 14315 RVA: 0x00354ED8 File Offset: 0x003530D8
		public string RadWideLabtoolSmartLowBatteryThreshold_A20201_UIValue
		{
			get
			{
				short num = (short)325965284;
				short num2 = num;
				num = (short)924571108;
				switch (num2 == num)
				{
				}
				num = (short)2048917504;
				if (num != 0)
				{
				}
				num = (short)1687355393;
				if (num != 0)
				{
				}
				num = (short)45613056;
				short num3 = num;
				return this.radWideLabtoolSmartLowBatteryThreshold_A20201.UIValue;
			}
			set
			{
				short num = (short)1483079681;
				if (num != 0)
				{
				}
				num = (short)537389866;
				short num2 = num;
				num = (short)975629098;
				switch (num2 == num)
				{
				}
				num = (short)1067581440;
				if (num != 0)
				{
				}
				num = (short)1908539392;
				short num3 = num;
				this.radWideLabtoolSmartLowBatteryThreshold_A20201.UIValue = value;
			}
		}

		// Token: 0x17001C67 RID: 7271
		// (get) Token: 0x060037EC RID: 14316 RVA: 0x00354F90 File Offset: 0x00353190
		// (set) Token: 0x060037ED RID: 14317 RVA: 0x00355044 File Offset: 0x00353244
		internal int RadWideLabtoolSmartLowBatteryThreshold_A20201Min
		{
			get
			{
				short num = (short)1073599453;
				short num2 = num;
				num = (short)905171933;
				switch (num2 == num)
				{
				}
				num = (short)1394016257;
				if (num != 0)
				{
				}
				num = (short)1664811008;
				if (num != 0)
				{
				}
				num = (short)1518993408;
				short num3 = num;
				return this.radWideLabtoolSmartLowBatteryThreshold_A20201.Min;
			}
			set
			{
				short num = (short)832735698;
				short num2 = num;
				num = (short)418351570;
				switch (num2 == num)
				{
				}
				num = (short)1549991937;
				if (num != 0)
				{
				}
				num = (short)1357774848;
				if (num != 0)
				{
				}
				num = (short)1456996352;
				short num3 = num;
				this.radWideLabtoolSmartLowBatteryThreshold_A20201.Min = value;
			}
		}

		// Token: 0x17001C68 RID: 7272
		// (get) Token: 0x060037EE RID: 14318 RVA: 0x003550FC File Offset: 0x003532FC
		// (set) Token: 0x060037EF RID: 14319 RVA: 0x003551B4 File Offset: 0x003533B4
		internal int RadWideLabtoolSmartLowBatteryThreshold_A20201Max
		{
			get
			{
				short num = (short)1136931117;
				short num2 = num;
				num = (short)1401303341;
				switch (num2 == num)
				{
				}
				num = (short)667156481;
				if (num != 0)
				{
				}
				num = (short)1163067392;
				if (num != 0)
				{
				}
				num = (short)729546752;
				short num3 = num;
				return this.radWideLabtoolSmartLowBatteryThreshold_A20201.Max;
			}
			set
			{
				short num = (short)803602433;
				if (num != 0)
				{
				}
				num = (short)387161135;
				short num2 = num;
				num = (short)790993967;
				switch (num2 == num)
				{
				}
				num = (short)1306918912;
				if (num != 0)
				{
				}
				num = (short)55902208;
				short num3 = num;
				this.radWideLabtoolSmartLowBatteryThreshold_A20201.Max = value;
			}
		}

		// Token: 0x17001C69 RID: 7273
		// (get) Token: 0x060037F0 RID: 14320 RVA: 0x00355268 File Offset: 0x00353468
		// (set) Token: 0x060037F1 RID: 14321 RVA: 0x0035531C File Offset: 0x0035351C
		internal int RadWideLabtoolSmartLowBatteryThreshold_A20201Step
		{
			get
			{
				short num = (short)368051600;
				short num2 = num;
				num = (short)282920336;
				switch (num2 == num)
				{
				}
				num = (short)116195329;
				if (num != 0)
				{
				}
				num = (short)840237056;
				if (num != 0)
				{
				}
				num = (short)16121856;
				short num3 = num;
				return this.radWideLabtoolSmartLowBatteryThreshold_A20201.StepSize;
			}
			set
			{
				short num = (short)1289099898;
				short num2 = num;
				num = (short)840440442;
				switch (num2 == num)
				{
				}
				num = (short)1309016065;
				if (num != 0)
				{
				}
				num = (short)1829371904;
				if (num != 0)
				{
				}
				num = (short)725811200;
				short num3 = num;
				this.radWideLabtoolSmartLowBatteryThreshold_A20201.StepSize = value;
			}
		}

		// Token: 0x17001C6A RID: 7274
		// (get) Token: 0x060037F2 RID: 14322 RVA: 0x003553D4 File Offset: 0x003535D4
		// (set) Token: 0x060037F3 RID: 14323 RVA: 0x00355488 File Offset: 0x00353688
		public bool RadWideLabtoolSmartLowBatteryThreshold_A20201_Applicable
		{
			get
			{
				short num = (short)788941942;
				short num2 = num;
				num = (short)348081270;
				switch (num2 == num)
				{
				}
				num = (short)2108030977;
				if (num != 0)
				{
				}
				num = (short)723058688;
				if (num != 0)
				{
				}
				num = (short)161742848;
				short num3 = num;
				return this.radWideLabtoolSmartLowBatteryThreshold_A20201.Applicable;
			}
			set
			{
				short num = (short)5212570;
				short num2 = num;
				num = (short)1691584922;
				switch (num2 == num)
				{
				}
				num = (short)2139095041;
				if (num != 0)
				{
				}
				num = (short)1685258240;
				if (num != 0)
				{
				}
				num = (short)150667264;
				short num3 = num;
				this.radWideLabtoolSmartLowBatteryThreshold_A20201.Applicable = value;
			}
		}

		// Token: 0x17001C6B RID: 7275
		// (get) Token: 0x060037F4 RID: 14324 RVA: 0x00355540 File Offset: 0x00353740
		// (set) Token: 0x060037F5 RID: 14325 RVA: 0x003555F4 File Offset: 0x003537F4
		public bool RadWideLabtoolSmartLowBatteryThreshold_A20201_Valid
		{
			get
			{
				short num = (short)1853083285;
				short num2 = num;
				num = (short)1242680981;
				switch (num2 == num)
				{
				}
				num = (short)145162241;
				if (num != 0)
				{
				}
				num = (short)1025310720;
				if (num != 0)
				{
				}
				num = (short)851902464;
				short num3 = num;
				return this.radWideLabtoolSmartLowBatteryThreshold_A20201.Valid;
			}
			set
			{
				short num = (short)254686008;
				short num2 = num;
				num = (short)1855730488;
				switch (num2 == num)
				{
				}
				num = (short)625410048;
				if (num != 0)
				{
				}
				num = (short)214892545;
				if (num != 0)
				{
				}
				num = (short)45678592;
				short num3 = num;
				this.radWideLabtoolSmartLowBatteryThreshold_A20201.Valid = value;
			}
		}

		// Token: 0x17001C6C RID: 7276
		// (get) Token: 0x060037F6 RID: 14326 RVA: 0x003556A8 File Offset: 0x003538A8
		// (set) Token: 0x060037F7 RID: 14327 RVA: 0x0035575C File Offset: 0x0035395C
		public bool RadWideLabtoolSmartLowBatteryThreshold_A20201_Visible
		{
			get
			{
				short num = (short)1275182799;
				short num2 = num;
				num = (short)1025949391;
				switch (num2 == num)
				{
				}
				num = (short)1123942401;
				if (num != 0)
				{
				}
				num = (short)592445440;
				if (num != 0)
				{
				}
				num = (short)1463549952;
				short num3 = num;
				return this.radWideLabtoolSmartLowBatteryThreshold_A20201.Visible;
			}
			set
			{
				short num = (short)624885761;
				if (num != 0)
				{
				}
				num = (short)439276410;
				short num2 = num;
				num = (short)1432277882;
				switch (num2 == num)
				{
				}
				num = (short)1154416640;
				if (num != 0)
				{
				}
				num = (short)1613561856;
				short num3 = num;
				this.radWideLabtoolSmartLowBatteryThreshold_A20201.Visible = value;
			}
		}

		// Token: 0x17001C6D RID: 7277
		// (get) Token: 0x060037F8 RID: 14328 RVA: 0x00355810 File Offset: 0x00353A10
		// (set) Token: 0x060037F9 RID: 14329 RVA: 0x003558C8 File Offset: 0x00353AC8
		public bool RadWideLabtoolSmartLowBatteryThreshold_A20201_Editable
		{
			get
			{
				short num = (short)1476555480;
				short num2 = num;
				num = (short)899838680;
				switch (num2 == num)
				{
				}
				num = (short)696647681;
				if (num != 0)
				{
				}
				num = (short)2038956032;
				if (num != 0)
				{
				}
				num = (short)871104512;
				short num3 = num;
				return this.radWideLabtoolSmartLowBatteryThreshold_A20201.Editable;
			}
			set
			{
				short num = (short)1950744577;
				if (num != 0)
				{
				}
				num = (short)152687264;
				short num2 = num;
				num = (short)345690784;
				switch (num2 == num)
				{
				}
				num = (short)1267597312;
				if (num != 0)
				{
				}
				num = (short)217645056;
				short num3 = num;
				this.radWideLabtoolSmartLowBatteryThreshold_A20201.Editable = value;
			}
		}

		// Token: 0x17001C6E RID: 7278
		// (get) Token: 0x060037FA RID: 14330 RVA: 0x0035597C File Offset: 0x00353B7C
		internal string RadWideLabtoolSmartLowBatteryThreshold_A20201_UILabel
		{
			get
			{
				short num = (short)852442159;
				short num2 = num;
				num = (short)2143894575;
				switch (num2 == num)
				{
				}
				num = (short)1992228864;
				if (num != 0)
				{
				}
				num = (short)2077949953;
				if (num != 0)
				{
				}
				num = (short)886374400;
				short num3 = num;
				return this.radWideLabtoolSmartLowBatteryThreshold_A20201.UIName;
			}
		}

		// Token: 0x17001C6F RID: 7279
		// (get) Token: 0x060037FB RID: 14331 RVA: 0x00355A34 File Offset: 0x00353C34
		// (set) Token: 0x060037FC RID: 14332 RVA: 0x00355AE8 File Offset: 0x00353CE8
		internal bool RadWideLabtoolSmartLowBatteryThreshold_A20201_HiddenStatic
		{
			get
			{
				short num = (short)1991810321;
				short num2 = num;
				num = (short)1419091217;
				switch (num2 == num)
				{
				}
				num = (short)800915456;
				if (num != 0)
				{
				}
				num = (short)967180289;
				if (num != 0)
				{
				}
				num = (short)2144206848;
				short num3 = num;
				return this.radWideLabtoolSmartLowBatteryThreshold_A20201.HiddenStatic;
			}
			set
			{
				short num = (short)1247818777;
				short num2 = num;
				num = (short)1617769497;
				switch (num2 == num)
				{
				}
				num = (short)668598272;
				if (num != 0)
				{
				}
				num = (short)2095382529;
				if (num != 0)
				{
				}
				num = (short)1098711040;
				short num3 = num;
				this.radWideLabtoolSmartLowBatteryThreshold_A20201.HiddenStatic = value;
			}
		}

		// Token: 0x17001C70 RID: 7280
		// (get) Token: 0x060037FD RID: 14333 RVA: 0x00355B9C File Offset: 0x00353D9C
		// (set) Token: 0x060037FE RID: 14334 RVA: 0x00355C50 File Offset: 0x00353E50
		internal bool RadWideLabtoolSmartLowBatteryThreshold_A20201_HiddenDynamic
		{
			get
			{
				short num = (short)1720949955;
				short num2 = num;
				num = (short)1970773187;
				switch (num2 == num)
				{
				}
				num = (short)1986592768;
				if (num != 0)
				{
				}
				num = (short)1134231553;
				if (num != 0)
				{
				}
				num = (short)792264704;
				short num3 = num;
				return this.radWideLabtoolSmartLowBatteryThreshold_A20201.HiddenDynamic;
			}
			set
			{
				short num = (short)218206505;
				short num2 = num;
				num = (short)822513961;
				switch (num2 == num)
				{
				}
				num = (short)1874198529;
				if (num != 0)
				{
				}
				num = (short)2078670848;
				if (num != 0)
				{
				}
				num = (short)1064501248;
				short num3 = num;
				this.radWideLabtoolSmartLowBatteryThreshold_A20201.HiddenDynamic = value;
			}
		}

		// Token: 0x17001C71 RID: 7281
		// (get) Token: 0x060037FF RID: 14335 RVA: 0x00355D08 File Offset: 0x00353F08
		public bool RadWideLabtoolSmartLowBatteryThreshold_A20201_HasDiffs
		{
			get
			{
				short num = (short)785570588;
				short num2 = num;
				num = (short)601086748;
				switch (num2 == num)
				{
				}
				num = (short)115474433;
				if (num != 0)
				{
				}
				num = (short)758382592;
				if (num != 0)
				{
				}
				num = (short)351141888;
				short num3 = num;
				return this.radWideLabtoolSmartLowBatteryThreshold_A20201._HasDiffs;
			}
		}

		// Token: 0x17001C72 RID: 7282
		// (get) Token: 0x06003800 RID: 14336 RVA: 0x00355DBC File Offset: 0x00353FBC
		// (set) Token: 0x06003801 RID: 14337 RVA: 0x00355E70 File Offset: 0x00354070
		public int RadWideLabtoolEarlyWarningBatteryThreshold_A23977Value
		{
			get
			{
				short num = (short)966607981;
				short num2 = num;
				num = (short)1671971949;
				switch (num2 == num)
				{
				}
				num = (short)2079522816;
				if (num != 0)
				{
				}
				num = (short)1844510721;
				if (num != 0)
				{
				}
				num = (short)583532544;
				short num3 = num;
				return this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.Value;
			}
			set
			{
				short num = (short)1645105669;
				short num2 = num;
				num = (short)1670730245;
				switch (num2 == num)
				{
				}
				num = (short)1955528704;
				if (num != 0)
				{
				}
				num = (short)1358430209;
				if (num != 0)
				{
				}
				num = (short)401801216;
				short num3 = num;
				this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.Value = value;
			}
		}

		// Token: 0x17001C73 RID: 7283
		// (get) Token: 0x06003802 RID: 14338 RVA: 0x00355F28 File Offset: 0x00354128
		public global::AcpBusinessLayer.AcpSimpleRangeField RadWideLabtoolEarlyWarningBatteryThreshold_A23977
		{
			get
			{
				short num = (short)138914840;
				short num2 = num;
				num = (short)1560259608;
				switch (num2 == num)
				{
				}
				num = (short)449314817;
				if (num != 0)
				{
				}
				num = (short)205062144;
				if (num != 0)
				{
				}
				num = (short)1544421376;
				short num3 = num;
				return this.radWideLabtoolEarlyWarningBatteryThreshold_A23977;
			}
		}

		// Token: 0x17001C74 RID: 7284
		// (get) Token: 0x06003803 RID: 14339 RVA: 0x00355FD4 File Offset: 0x003541D4
		// (set) Token: 0x06003804 RID: 14340 RVA: 0x00356088 File Offset: 0x00354288
		public string RadWideLabtoolEarlyWarningBatteryThreshold_A23977_UIValue
		{
			get
			{
				short num = (short)593379634;
				short num2 = num;
				num = (short)116736306;
				switch (num2 == num)
				{
				}
				num = (short)1264648192;
				if (num != 0)
				{
				}
				num = (short)402980865;
				if (num != 0)
				{
				}
				num = (short)1789853696;
				short num3 = num;
				return this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.UIValue;
			}
			set
			{
				short num = (short)381455374;
				short num2 = num;
				num = (short)1451920398;
				switch (num2 == num)
				{
				}
				num = (short)542638081;
				if (num != 0)
				{
				}
				num = (short)379125760;
				if (num != 0)
				{
				}
				num = (short)1954807808;
				short num3 = num;
				this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.UIValue = value;
			}
		}

		// Token: 0x17001C75 RID: 7285
		// (get) Token: 0x06003805 RID: 14341 RVA: 0x0035613C File Offset: 0x0035433C
		// (set) Token: 0x06003806 RID: 14342 RVA: 0x003561F0 File Offset: 0x003543F0
		internal int RadWideLabtoolEarlyWarningBatteryThreshold_A23977Min
		{
			get
			{
				short num = (short)1692177848;
				short num2 = num;
				num = (short)1599378872;
				switch (num2 == num)
				{
				}
				num = (short)2132803584;
				if (num != 0)
				{
				}
				num = (short)243662849;
				if (num != 0)
				{
				}
				num = (short)1286144000;
				short num3 = num;
				return this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.Min;
			}
			set
			{
				short num = (short)1731575907;
				short num2 = num;
				num = (short)496156771;
				switch (num2 == num)
				{
				}
				num = (short)97452033;
				if (num != 0)
				{
				}
				num = (short)1707278336;
				if (num != 0)
				{
				}
				num = (short)953417728;
				short num3 = num;
				this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.Min = value;
			}
		}

		// Token: 0x17001C76 RID: 7286
		// (get) Token: 0x06003807 RID: 14343 RVA: 0x003562A8 File Offset: 0x003544A8
		// (set) Token: 0x06003808 RID: 14344 RVA: 0x0035635C File Offset: 0x0035455C
		internal int RadWideLabtoolEarlyWarningBatteryThreshold_A23977Max
		{
			get
			{
				short num = (short)1197932545;
				if (num != 0)
				{
				}
				num = (short)1307874822;
				short num2 = num;
				num = (short)2049218054;
				switch (num2 == num)
				{
				}
				num = (short)1629421568;
				if (num != 0)
				{
				}
				num = (short)479854592;
				short num3 = num;
				return this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.Max;
			}
			set
			{
				short num = (short)106174168;
				short num2 = num;
				num = (short)1990334168;
				switch (num2 == num)
				{
				}
				num = (short)751632385;
				if (num != 0)
				{
				}
				num = (short)1399521280;
				if (num != 0)
				{
				}
				num = (short)436011008;
				short num3 = num;
				this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.Max = value;
			}
		}

		// Token: 0x17001C77 RID: 7287
		// (get) Token: 0x06003809 RID: 14345 RVA: 0x00356414 File Offset: 0x00354614
		// (set) Token: 0x0600380A RID: 14346 RVA: 0x003564C4 File Offset: 0x003546C4
		internal int RadWideLabtoolEarlyWarningBatteryThreshold_A23977Step
		{
			get
			{
				short num = (short)115635766;
				short num2 = num;
				num = (short)1284863542;
				switch (num2 == num)
				{
				}
				num = (short)973471745;
				if (num != 0)
				{
				}
				num = (short)1209532416;
				if (num != 0)
				{
				}
				num = (short)1034027008;
				short num3 = num;
				return this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.StepSize;
			}
			set
			{
				short num = (short)2119302203;
				short num2 = num;
				num = (short)1286995003;
				switch (num2 == num)
				{
				}
				num = (short)378994689;
				if (num != 0)
				{
				}
				num = (short)1209925632;
				if (num != 0)
				{
				}
				num = (short)1856438272;
				short num3 = num;
				this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.StepSize = value;
			}
		}

		// Token: 0x17001C78 RID: 7288
		// (get) Token: 0x0600380B RID: 14347 RVA: 0x0035657C File Offset: 0x0035477C
		// (set) Token: 0x0600380C RID: 14348 RVA: 0x00356630 File Offset: 0x00354830
		public bool RadWideLabtoolEarlyWarningBatteryThreshold_A23977_Applicable
		{
			get
			{
				short num = (short)1434980745;
				short num2 = num;
				num = (short)1012339081;
				switch (num2 == num)
				{
				}
				num = (short)1994326017;
				if (num != 0)
				{
				}
				num = (short)1340145664;
				if (num != 0)
				{
				}
				num = (short)698875904;
				short num3 = num;
				return this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.Applicable;
			}
			set
			{
				short num = (short)2077002737;
				short num2 = num;
				num = (short)758090737;
				switch (num2 == num)
				{
				}
				num = (short)37748737;
				if (num != 0)
				{
				}
				num = (short)1805451264;
				if (num != 0)
				{
				}
				num = (short)1703215104;
				short num3 = num;
				this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.Applicable = value;
			}
		}

		// Token: 0x17001C79 RID: 7289
		// (get) Token: 0x0600380D RID: 14349 RVA: 0x003566E8 File Offset: 0x003548E8
		// (set) Token: 0x0600380E RID: 14350 RVA: 0x0035679C File Offset: 0x0035499C
		public bool RadWideLabtoolEarlyWarningBatteryThreshold_A23977_Valid
		{
			get
			{
				short num = (short)451215361;
				if (num != 0)
				{
				}
				num = (short)1416095258;
				short num2 = num;
				num = (short)392816154;
				switch (num2 == num)
				{
				}
				num = (short)1685651456;
				if (num != 0)
				{
				}
				num = (short)1726087168;
				short num3 = num;
				return this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.Valid;
			}
			set
			{
				short num = (short)1103729670;
				short num2 = num;
				num = (short)1942590470;
				switch (num2 == num)
				{
				}
				num = (short)673644545;
				if (num != 0)
				{
				}
				num = (short)1824456704;
				if (num != 0)
				{
				}
				num = (short)1962934272;
				short num3 = num;
				this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.Valid = value;
			}
		}

		// Token: 0x17001C7A RID: 7290
		// (get) Token: 0x0600380F RID: 14351 RVA: 0x00356854 File Offset: 0x00354A54
		// (set) Token: 0x06003810 RID: 14352 RVA: 0x00356908 File Offset: 0x00354B08
		public bool RadWideLabtoolEarlyWarningBatteryThreshold_A23977_Visible
		{
			get
			{
				short num = (short)1117913089;
				if (num != 0)
				{
				}
				num = (short)1437145604;
				short num2 = num;
				num = (short)621877764;
				switch (num2 == num)
				{
				}
				num = (short)1224802304;
				if (num != 0)
				{
				}
				num = (short)1552351232;
				short num3 = num;
				return this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.Visible;
			}
			set
			{
				short num = (short)1787629196;
				short num2 = num;
				num = (short)1459752588;
				switch (num2 == num)
				{
				}
				num = (short)307429376;
				if (num != 0)
				{
				}
				num = (short)1729363969;
				if (num != 0)
				{
				}
				num = (short)2013396992;
				short num3 = num;
				this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.Visible = value;
			}
		}

		// Token: 0x17001C7B RID: 7291
		// (get) Token: 0x06003811 RID: 14353 RVA: 0x003569C0 File Offset: 0x00354BC0
		// (set) Token: 0x06003812 RID: 14354 RVA: 0x00356A74 File Offset: 0x00354C74
		public bool RadWideLabtoolEarlyWarningBatteryThreshold_A23977_Editable
		{
			get
			{
				short num = (short)2001816497;
				short num2 = num;
				num = (short)120802225;
				switch (num2 == num)
				{
				}
				num = (short)1859256321;
				if (num != 0)
				{
				}
				num = (short)1828913152;
				if (num != 0)
				{
				}
				num = (short)611516416;
				short num3 = num;
				return this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.Editable;
			}
			set
			{
				short num = (short)372026190;
				short num2 = num;
				num = (short)121940814;
				switch (num2 == num)
				{
				}
				num = (short)1020461057;
				if (num != 0)
				{
				}
				num = (short)1461256192;
				if (num != 0)
				{
				}
				num = (short)246415360;
				short num3 = num;
				this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.Editable = value;
			}
		}

		// Token: 0x17001C7C RID: 7292
		// (get) Token: 0x06003813 RID: 14355 RVA: 0x00356B2C File Offset: 0x00354D2C
		internal string RadWideLabtoolEarlyWarningBatteryThreshold_A23977_UILabel
		{
			get
			{
				short num = (short)1192167743;
				short num2 = num;
				num = (short)210831679;
				switch (num2 == num)
				{
				}
				num = (short)1871773696;
				if (num != 0)
				{
				}
				num = (short)1757282305;
				if (num != 0)
				{
				}
				num = (short)1340342272;
				short num3 = num;
				return this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.UIName;
			}
		}

		// Token: 0x17001C7D RID: 7293
		// (get) Token: 0x06003814 RID: 14356 RVA: 0x00356BE4 File Offset: 0x00354DE4
		// (set) Token: 0x06003815 RID: 14357 RVA: 0x00356C98 File Offset: 0x00354E98
		internal bool RadWideLabtoolEarlyWarningBatteryThreshold_A23977_HiddenStatic
		{
			get
			{
				short num = (short)473497601;
				if (num != 0)
				{
				}
				num = (short)1620310029;
				short num2 = num;
				num = (short)621803533;
				switch (num2 == num)
				{
				}
				num = (short)1949958144;
				if (num != 0)
				{
				}
				num = (short)2029518848;
				short num3 = num;
				return this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.HiddenStatic;
			}
			set
			{
				short num = (short)781272258;
				short num2 = num;
				num = (short)1429488834;
				switch (num2 == num)
				{
				}
				num = (short)985595904;
				short num3 = num;
				num = (short)758775809;
				if (num != 0)
				{
				}
				num = (short)1965228032;
				if (num != 0)
				{
				}
				this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.HiddenStatic = value;
			}
		}

		// Token: 0x17001C7E RID: 7294
		// (get) Token: 0x06003816 RID: 14358 RVA: 0x00356D4C File Offset: 0x00354F4C
		// (set) Token: 0x06003817 RID: 14359 RVA: 0x00356E00 File Offset: 0x00355000
		internal bool RadWideLabtoolEarlyWarningBatteryThreshold_A23977_HiddenDynamic
		{
			get
			{
				short num = (short)1070954538;
				short num2 = num;
				num = (short)1166964778;
				switch (num2 == num)
				{
				}
				num = (short)1169293312;
				short num3 = num;
				num = (short)1981874177;
				if (num != 0)
				{
				}
				num = (short)1011875840;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.HiddenDynamic;
			}
			set
			{
				short num = (short)605554748;
				short num2 = num;
				num = (short)732432444;
				switch (num2 == num)
				{
				}
				num = (short)593625088;
				short num3 = num;
				num = (short)1521156096;
				if (num != 0)
				{
				}
				num = (short)202506241;
				if (num != 0)
				{
				}
				this.radWideLabtoolEarlyWarningBatteryThreshold_A23977.HiddenDynamic = value;
			}
		}

		// Token: 0x17001C7F RID: 7295
		// (get) Token: 0x06003818 RID: 14360 RVA: 0x00356EB8 File Offset: 0x003550B8
		public bool RadWideLabtoolEarlyWarningBatteryThreshold_A23977_HasDiffs
		{
			get
			{
				short num = (short)38579569;
				short num2 = num;
				num = (short)977841521;
				switch (num2 == num)
				{
				}
				num = (short)1019478016;
				short num3 = num;
				num = (short)1959133185;
				if (num != 0)
				{
				}
				num = (short)1099825152;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEarlyWarningBatteryThreshold_A23977._HasDiffs;
			}
		}

		// Token: 0x17001C80 RID: 7296
		// (get) Token: 0x06003819 RID: 14361 RVA: 0x00356F6C File Offset: 0x0035516C
		// (set) Token: 0x0600381A RID: 14362 RVA: 0x00357024 File Offset: 0x00355224
		public bool RadWideLabtoolConsoletteModelEnable_A7713Value
		{
			get
			{
				short num = (short)17528457;
				short num2 = num;
				num = (short)915764873;
				switch (num2 == num)
				{
				}
				num = (short)1523646464;
				short num3 = num;
				num = (short)1237057536;
				if (num != 0)
				{
				}
				num = (short)24313857;
				if (num != 0)
				{
				}
				return this.radWideLabtoolConsoletteModelEnable_A7713.Value;
			}
			set
			{
				short num = (short)1726021633;
				if (num != 0)
				{
				}
				num = (short)73081577;
				short num2 = num;
				num = (short)381690601;
				switch (num2 == num)
				{
				default:
				{
					num = (short)154664960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)25821184;
				if (num != 0)
				{
				}
				this.radWideLabtoolConsoletteModelEnable_A7713.Value = value;
			}
		}

		// Token: 0x17001C81 RID: 7297
		// (get) Token: 0x0600381B RID: 14363 RVA: 0x003570DC File Offset: 0x003552DC
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolConsoletteModelEnable_A7713
		{
			get
			{
				short num = (short)969184630;
				short num2 = num;
				num = (short)674534774;
				switch (num2 == num)
				{
				}
				num = (short)1059192832;
				short num3 = num;
				num = (short)2067398657;
				if (num != 0)
				{
				}
				num = (short)1441333248;
				if (num != 0)
				{
				}
				return this.radWideLabtoolConsoletteModelEnable_A7713;
			}
		}

		// Token: 0x17001C82 RID: 7298
		// (get) Token: 0x0600381C RID: 14364 RVA: 0x00357190 File Offset: 0x00355390
		// (set) Token: 0x0600381D RID: 14365 RVA: 0x00357244 File Offset: 0x00355444
		public bool RadWideLabtoolConsoletteModelEnable_A7713_UIValue
		{
			get
			{
				short num = (short)1981516193;
				short num2 = num;
				num = (short)1785170337;
				switch (num2 == num)
				{
				}
				num = (short)467927040;
				short num3 = num;
				num = (short)251199489;
				if (num != 0)
				{
				}
				num = (short)388366336;
				if (num != 0)
				{
				}
				return this.radWideLabtoolConsoletteModelEnable_A7713.Value;
			}
			set
			{
				short num = (short)104129561;
				short num2 = num;
				num = (short)235267097;
				switch (num2 == num)
				{
				}
				num = (short)1285750784;
				short num3 = num;
				num = (short)2008809473;
				if (num != 0)
				{
				}
				num = (short)1639710720;
				if (num != 0)
				{
				}
				this.radWideLabtoolConsoletteModelEnable_A7713.Value = value;
			}
		}

		// Token: 0x17001C83 RID: 7299
		// (get) Token: 0x0600381E RID: 14366 RVA: 0x003572FC File Offset: 0x003554FC
		// (set) Token: 0x0600381F RID: 14367 RVA: 0x003573B0 File Offset: 0x003555B0
		public bool RadWideLabtoolConsoletteModelEnable_A7713_Applicable
		{
			get
			{
				short num = (short)673653566;
				short num2 = num;
				num = (short)801973054;
				switch (num2 == num)
				{
				}
				num = (short)2067070976;
				short num3 = num;
				num = (short)717422593;
				if (num != 0)
				{
				}
				num = (short)412876800;
				if (num != 0)
				{
				}
				return this.radWideLabtoolConsoletteModelEnable_A7713.Applicable;
			}
			set
			{
				short num = (short)1198321140;
				short num2 = num;
				num = (short)541650420;
				switch (num2 == num)
				{
				}
				num = (short)1890516992;
				short num3 = num;
				num = (short)32964608;
				if (num != 0)
				{
				}
				num = (short)619642881;
				if (num != 0)
				{
				}
				this.radWideLabtoolConsoletteModelEnable_A7713.Applicable = value;
			}
		}

		// Token: 0x17001C84 RID: 7300
		// (get) Token: 0x06003820 RID: 14368 RVA: 0x00357464 File Offset: 0x00355664
		// (set) Token: 0x06003821 RID: 14369 RVA: 0x00357518 File Offset: 0x00355718
		public bool RadWideLabtoolConsoletteModelEnable_A7713_Valid
		{
			get
			{
				short num = (short)659126356;
				short num2 = num;
				num = (short)1629583444;
				switch (num2 == num)
				{
				}
				num = (short)1571160064;
				short num3 = num;
				num = (short)560398337;
				if (num != 0)
				{
				}
				num = (short)1912274944;
				if (num != 0)
				{
				}
				return this.radWideLabtoolConsoletteModelEnable_A7713.Valid;
			}
			set
			{
				short num = (short)1284045511;
				short num2 = num;
				num = (short)1048050375;
				switch (num2 == num)
				{
				}
				num = (short)383385600;
				short num3 = num;
				num = (short)756613121;
				if (num != 0)
				{
				}
				num = (short)1061093376;
				if (num != 0)
				{
				}
				this.radWideLabtoolConsoletteModelEnable_A7713.Valid = value;
			}
		}

		// Token: 0x17001C85 RID: 7301
		// (get) Token: 0x06003822 RID: 14370 RVA: 0x003575D0 File Offset: 0x003557D0
		// (set) Token: 0x06003823 RID: 14371 RVA: 0x00357688 File Offset: 0x00355888
		public bool RadWideLabtoolConsoletteModelEnable_A7713_Visible
		{
			get
			{
				short num = (short)630367932;
				short num2 = num;
				num = (short)1592436412;
				switch (num2 == num)
				{
				}
				num = (short)457375744;
				short num3 = num;
				num = (short)1727594497;
				if (num != 0)
				{
				}
				num = (short)409731072;
				if (num != 0)
				{
				}
				return this.radWideLabtoolConsoletteModelEnable_A7713.Visible;
			}
			set
			{
				short num = (short)1578861016;
				short num2 = num;
				num = (short)1230209496;
				switch (num2 == num)
				{
				}
				num = (short)1077215232;
				short num3 = num;
				num = (short)2119106561;
				if (num != 0)
				{
				}
				num = (short)1284243456;
				if (num != 0)
				{
				}
				this.radWideLabtoolConsoletteModelEnable_A7713.Visible = value;
			}
		}

		// Token: 0x17001C86 RID: 7302
		// (get) Token: 0x06003824 RID: 14372 RVA: 0x00357740 File Offset: 0x00355940
		// (set) Token: 0x06003825 RID: 14373 RVA: 0x003577F4 File Offset: 0x003559F4
		public bool RadWideLabtoolConsoletteModelEnable_A7713_Editable
		{
			get
			{
				short num = (short)200802305;
				if (num != 0)
				{
				}
				num = (short)1867046329;
				short num2 = num;
				num = (short)99605945;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2096168960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)379060224;
				if (num != 0)
				{
				}
				return this.radWideLabtoolConsoletteModelEnable_A7713.Editable;
			}
			set
			{
				short num = (short)936439803;
				short num2 = num;
				num = (short)726527995;
				switch (num2 == num)
				{
				}
				num = (short)2129395712;
				short num3 = num;
				num = (short)139657216;
				if (num != 0)
				{
				}
				num = (short)87162881;
				if (num != 0)
				{
				}
				this.radWideLabtoolConsoletteModelEnable_A7713.Editable = value;
			}
		}

		// Token: 0x17001C87 RID: 7303
		// (get) Token: 0x06003826 RID: 14374 RVA: 0x003578AC File Offset: 0x00355AAC
		internal string RadWideLabtoolConsoletteModelEnable_A7713_UILabel
		{
			get
			{
				short num = (short)2073038880;
				short num2 = num;
				num = (short)946016288;
				switch (num2 == num)
				{
				}
				num = (short)483786752;
				short num3 = num;
				num = (short)386400257;
				if (num != 0)
				{
				}
				num = (short)70385664;
				if (num != 0)
				{
				}
				return this.radWideLabtoolConsoletteModelEnable_A7713.UIName;
			}
		}

		// Token: 0x17001C88 RID: 7304
		// (get) Token: 0x06003827 RID: 14375 RVA: 0x00357964 File Offset: 0x00355B64
		// (set) Token: 0x06003828 RID: 14376 RVA: 0x00357A18 File Offset: 0x00355C18
		internal bool RadWideLabtoolConsoletteModelEnable_A7713_HiddenStatic
		{
			get
			{
				short num = (short)985952216;
				short num2 = num;
				num = (short)1503621080;
				switch (num2 == num)
				{
				}
				num = (short)573112320;
				short num3 = num;
				num = (short)1009254400;
				if (num != 0)
				{
				}
				num = (short)760217601;
				if (num != 0)
				{
				}
				return this.radWideLabtoolConsoletteModelEnable_A7713.HiddenStatic;
			}
			set
			{
				short num = (short)1958566422;
				short num2 = num;
				num = (short)1544378902;
				switch (num2 == num)
				{
				}
				num = (short)1760362496;
				short num3 = num;
				num = (short)2073821184;
				if (num != 0)
				{
				}
				num = (short)1353056257;
				if (num != 0)
				{
				}
				this.radWideLabtoolConsoletteModelEnable_A7713.HiddenStatic = value;
			}
		}

		// Token: 0x17001C89 RID: 7305
		// (get) Token: 0x06003829 RID: 14377 RVA: 0x00357AD0 File Offset: 0x00355CD0
		// (set) Token: 0x0600382A RID: 14378 RVA: 0x00357B84 File Offset: 0x00355D84
		internal bool RadWideLabtoolConsoletteModelEnable_A7713_HiddenDynamic
		{
			get
			{
				short num = (short)1015002736;
				short num2 = num;
				num = (short)1183233648;
				switch (num2 == num)
				{
				}
				num = (short)1000144896;
				short num3 = num;
				num = (short)968818689;
				if (num != 0)
				{
				}
				num = (short)1124859904;
				if (num != 0)
				{
				}
				return this.radWideLabtoolConsoletteModelEnable_A7713.HiddenDynamic;
			}
			set
			{
				short num = (short)880964289;
				short num2 = num;
				num = (short)1178038977;
				switch (num2 == num)
				{
				}
				num = (short)632553472;
				short num3 = num;
				num = (short)2027683840;
				if (num != 0)
				{
				}
				num = (short)1241841665;
				if (num != 0)
				{
				}
				this.radWideLabtoolConsoletteModelEnable_A7713.HiddenDynamic = value;
			}
		}

		// Token: 0x17001C8A RID: 7306
		// (get) Token: 0x0600382B RID: 14379 RVA: 0x00357C38 File Offset: 0x00355E38
		public bool RadWideLabtoolConsoletteModelEnable_A7713_HasDiffs
		{
			get
			{
				short num = (short)532502623;
				short num2 = num;
				num = (short)577198175;
				switch (num2 == num)
				{
				}
				num = (short)1911554048;
				short num3 = num;
				num = (short)1469251584;
				if (num != 0)
				{
				}
				num = (short)1715011585;
				if (num != 0)
				{
				}
				return this.radWideLabtoolConsoletteModelEnable_A7713._HasDiffs;
			}
		}

		// Token: 0x17001C8B RID: 7307
		// (get) Token: 0x0600382C RID: 14380 RVA: 0x00357CF0 File Offset: 0x00355EF0
		// (set) Token: 0x0600382D RID: 14381 RVA: 0x00357DA4 File Offset: 0x00355FA4
		public int RadWideLabtoolDisplayType_A7887Value
		{
			get
			{
				short num = (short)1204500221;
				short num2 = num;
				num = (short)1082078973;
				switch (num2 == num)
				{
				}
				num = (short)743768064;
				short num3 = num;
				num = (short)678625281;
				if (num != 0)
				{
				}
				num = (short)1868562432;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayType_A7887.Value;
			}
			set
			{
				short num = (short)920890693;
				short num2 = num;
				num = (short)953789765;
				switch (num2 == num)
				{
				}
				num = (short)2061369344;
				short num3 = num;
				num = (short)1891762177;
				if (num != 0)
				{
				}
				num = (short)263847936;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisplayType_A7887.Value = value;
			}
		}

		// Token: 0x17001C8C RID: 7308
		// (get) Token: 0x0600382E RID: 14382 RVA: 0x00357E5C File Offset: 0x0035605C
		// (set) Token: 0x0600382F RID: 14383 RVA: 0x00357F10 File Offset: 0x00356110
		public string RadWideLabtoolDisplayType_A7887_UIValue
		{
			get
			{
				short num = (short)1713391496;
				short num2 = num;
				num = (short)248268680;
				switch (num2 == num)
				{
				}
				num = (short)887095296;
				short num3 = num;
				num = (short)2120220673;
				if (num != 0)
				{
				}
				num = (short)655032320;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayType_A7887.UIValue;
			}
			set
			{
				short num = (short)1145539773;
				short num2 = num;
				num = (short)931564733;
				switch (num2 == num)
				{
				}
				num = (short)944242688;
				short num3 = num;
				num = (short)209977345;
				if (num != 0)
				{
				}
				num = (short)588578816;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisplayType_A7887.UIValue = value;
			}
		}

		// Token: 0x17001C8D RID: 7309
		// (get) Token: 0x06003830 RID: 14384 RVA: 0x00357FC4 File Offset: 0x003561C4
		public global::AcpBusinessLayer.AcpListField RadWideLabtoolDisplayType_A7887
		{
			get
			{
				short num = (short)234634906;
				short num2 = num;
				num = (short)89407130;
				switch (num2 == num)
				{
				}
				num = (short)1914634240;
				short num3 = num;
				num = (short)657588225;
				if (num != 0)
				{
				}
				num = (short)1452015616;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayType_A7887;
			}
		}

		// Token: 0x17001C8E RID: 7310
		// (get) Token: 0x06003831 RID: 14385 RVA: 0x00358074 File Offset: 0x00356274
		// (set) Token: 0x06003832 RID: 14386 RVA: 0x00358128 File Offset: 0x00356328
		public bool RadWideLabtoolDisplayType_A7887_Applicable
		{
			get
			{
				short num = (short)2082873898;
				short num2 = num;
				num = (short)2031231530;
				switch (num2 == num)
				{
				}
				num = (short)169345024;
				short num3 = num;
				num = (short)2030895104;
				if (num != 0)
				{
				}
				num = (short)1120665601;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayType_A7887.Applicable;
			}
			set
			{
				short num = (short)92573316;
				short num2 = num;
				num = (short)71011972;
				switch (num2 == num)
				{
				}
				num = (short)1199308800;
				short num3 = num;
				num = (short)1718026240;
				if (num != 0)
				{
				}
				num = (short)530382849;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisplayType_A7887.Applicable = value;
			}
		}

		// Token: 0x17001C8F RID: 7311
		// (get) Token: 0x06003833 RID: 14387 RVA: 0x003581DC File Offset: 0x003563DC
		// (set) Token: 0x06003834 RID: 14388 RVA: 0x00358294 File Offset: 0x00356494
		public bool RadWideLabtoolDisplayType_A7887_Valid
		{
			get
			{
				short num = (short)975366247;
				short num2 = num;
				num = (short)1110698087;
				switch (num2 == num)
				{
				}
				num = (short)2146172928;
				short num3 = num;
				num = (short)1227554817;
				if (num != 0)
				{
				}
				num = (short)283377664;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayType_A7887.Valid;
			}
			set
			{
				short num = (short)1523708276;
				short num2 = num;
				num = (short)1755836788;
				switch (num2 == num)
				{
				}
				num = (short)2060058624;
				short num3 = num;
				num = (short)966721537;
				if (num != 0)
				{
				}
				num = (short)1375535104;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisplayType_A7887.Valid = value;
			}
		}

		// Token: 0x17001C90 RID: 7312
		// (get) Token: 0x06003835 RID: 14389 RVA: 0x00358348 File Offset: 0x00356548
		// (set) Token: 0x06003836 RID: 14390 RVA: 0x00358400 File Offset: 0x00356600
		public bool RadWideLabtoolDisplayType_A7887_Visible
		{
			get
			{
				short num = (short)7702505;
				short num2 = num;
				num = (short)74876905;
				switch (num2 == num)
				{
				}
				num = (short)670171136;
				short num3 = num;
				num = (short)1127874560;
				if (num != 0)
				{
				}
				num = (short)1185218561;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayType_A7887.Visible;
			}
			set
			{
				short num = (short)965665550;
				short num2 = num;
				num = (short)606921486;
				switch (num2 == num)
				{
				}
				num = (short)1459224576;
				short num3 = num;
				num = (short)497811457;
				if (num != 0)
				{
				}
				num = (short)1461846016;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisplayType_A7887.Visible = value;
			}
		}

		// Token: 0x17001C91 RID: 7313
		// (get) Token: 0x06003837 RID: 14391 RVA: 0x003584B8 File Offset: 0x003566B8
		// (set) Token: 0x06003838 RID: 14392 RVA: 0x0035856C File Offset: 0x0035676C
		public bool RadWideLabtoolDisplayType_A7887_Editable
		{
			get
			{
				short num = (short)122748843;
				short num2 = num;
				num = (short)38666155;
				switch (num2 == num)
				{
				}
				num = (short)1521418240;
				short num3 = num;
				num = (short)1694629889;
				if (num != 0)
				{
				}
				num = (short)1367998464;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayType_A7887.Editable;
			}
			set
			{
				short num = (short)712694234;
				short num2 = num;
				num = (short)1778637274;
				switch (num2 == num)
				{
				}
				num = (short)252837888;
				short num3 = num;
				num = (short)1113980929;
				if (num != 0)
				{
				}
				num = (short)622198784;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisplayType_A7887.Editable = value;
			}
		}

		// Token: 0x17001C92 RID: 7314
		// (get) Token: 0x06003839 RID: 14393 RVA: 0x00358620 File Offset: 0x00356820
		internal string RadWideLabtoolDisplayType_A7887_UILabel
		{
			get
			{
				short num = (short)872850395;
				short num2 = num;
				num = (short)1137746907;
				switch (num2 == num)
				{
				}
				num = (short)396820480;
				short num3 = num;
				num = (short)455344129;
				if (num != 0)
				{
				}
				num = (short)343605248;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayType_A7887.UIName;
			}
		}

		// Token: 0x17001C93 RID: 7315
		// (get) Token: 0x0600383A RID: 14394 RVA: 0x003586D8 File Offset: 0x003568D8
		// (set) Token: 0x0600383B RID: 14395 RVA: 0x00358788 File Offset: 0x00356988
		internal bool RadWideLabtoolDisplayType_A7887_HiddenStatic
		{
			get
			{
				short num = (short)485987264;
				short num2 = num;
				num = (short)1468306368;
				switch (num2 == num)
				{
				}
				num = (short)1803878400;
				short num3 = num;
				num = (short)2088304640;
				if (num != 0)
				{
				}
				num = (short)1550516225;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayType_A7887.HiddenStatic;
			}
			set
			{
				short num = (short)150148484;
				short num2 = num;
				num = (short)1662850436;
				switch (num2 == num)
				{
				}
				num = (short)2041446400;
				short num3 = num;
				num = (short)805502977;
				if (num != 0)
				{
				}
				num = (short)954990592;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisplayType_A7887.HiddenStatic = value;
			}
		}

		// Token: 0x17001C94 RID: 7316
		// (get) Token: 0x0600383C RID: 14396 RVA: 0x0035883C File Offset: 0x00356A3C
		// (set) Token: 0x0600383D RID: 14397 RVA: 0x003588F0 File Offset: 0x00356AF0
		internal bool RadWideLabtoolDisplayType_A7887_HiddenDynamic
		{
			get
			{
				short num = (short)410612430;
				short num2 = num;
				num = (short)1448637134;
				switch (num2 == num)
				{
				}
				num = (short)577372160;
				short num3 = num;
				num = (short)2058420224;
				if (num != 0)
				{
				}
				num = (short)767885313;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayType_A7887.HiddenDynamic;
			}
			set
			{
				short num = (short)417671916;
				short num2 = num;
				num = (short)844901100;
				switch (num2 == num)
				{
				}
				num = (short)1180106752;
				short num3 = num;
				num = (short)2061041665;
				if (num != 0)
				{
				}
				num = (short)859045888;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisplayType_A7887.HiddenDynamic = value;
			}
		}

		// Token: 0x17001C95 RID: 7317
		// (get) Token: 0x0600383E RID: 14398 RVA: 0x003589A4 File Offset: 0x00356BA4
		public bool RadWideLabtoolDisplayType_A7887_HasDiffs
		{
			get
			{
				short num = (short)615779428;
				short num2 = num;
				num = (short)151391332;
				switch (num2 == num)
				{
				}
				num = (short)1603010560;
				short num3 = num;
				num = (short)1772748801;
				if (num != 0)
				{
				}
				num = (short)1721696256;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisplayType_A7887._HasDiffs;
			}
		}

		// Token: 0x17001C96 RID: 7318
		// (get) Token: 0x0600383F RID: 14399 RVA: 0x00358A58 File Offset: 0x00356C58
		// (set) Token: 0x06003840 RID: 14400 RVA: 0x00358B0C File Offset: 0x00356D0C
		public bool RadWideLabtoolDynamicZoneCable_A41258Value
		{
			get
			{
				short num = (short)665465534;
				short num2 = num;
				num = (short)1908814526;
				switch (num2 == num)
				{
				}
				num = (short)451608576;
				short num3 = num;
				num = (short)1333198849;
				if (num != 0)
				{
				}
				num = (short)1867710464;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDynamicZoneCable_A41258.Value;
			}
			set
			{
				short num = (short)717225985;
				if (num != 0)
				{
				}
				num = (short)1331516152;
				short num2 = num;
				num = (short)854807288;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1105592320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)312016896;
				if (num != 0)
				{
				}
				this.radWideLabtoolDynamicZoneCable_A41258.Value = value;
			}
		}

		// Token: 0x17001C97 RID: 7319
		// (get) Token: 0x06003841 RID: 14401 RVA: 0x00358BC4 File Offset: 0x00356DC4
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolDynamicZoneCable_A41258
		{
			get
			{
				short num = (short)467209799;
				short num2 = num;
				num = (short)1764429383;
				switch (num2 == num)
				{
				}
				num = (short)30343168;
				short num3 = num;
				num = (short)1036976129;
				if (num != 0)
				{
				}
				num = (short)1393754112;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDynamicZoneCable_A41258;
			}
		}

		// Token: 0x17001C98 RID: 7320
		// (get) Token: 0x06003842 RID: 14402 RVA: 0x00358C74 File Offset: 0x00356E74
		// (set) Token: 0x06003843 RID: 14403 RVA: 0x00358D28 File Offset: 0x00356F28
		public bool RadWideLabtoolDynamicZoneCable_A41258_UIValue
		{
			get
			{
				short num = (short)2040240436;
				short num2 = num;
				num = (short)1812175156;
				switch (num2 == num)
				{
				}
				num = (short)1687158784;
				short num3 = num;
				num = (short)1307770880;
				if (num != 0)
				{
				}
				num = (short)188284929;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDynamicZoneCable_A41258.Value;
			}
			set
			{
				short num = (short)1391591425;
				if (num != 0)
				{
				}
				num = (short)1573818665;
				short num2 = num;
				num = (short)37327145;
				switch (num2 == num)
				{
				default:
				{
					num = (short)165150720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)638189568;
				if (num != 0)
				{
				}
				this.radWideLabtoolDynamicZoneCable_A41258.Value = value;
			}
		}

		// Token: 0x17001C99 RID: 7321
		// (get) Token: 0x06003844 RID: 14404 RVA: 0x00358DDC File Offset: 0x00356FDC
		// (set) Token: 0x06003845 RID: 14405 RVA: 0x00358E90 File Offset: 0x00357090
		public bool RadWideLabtoolDynamicZoneCable_A41258_Applicable
		{
			get
			{
				short num = (short)568541021;
				short num2 = num;
				num = (short)645742429;
				switch (num2 == num)
				{
				}
				num = (short)1397555200;
				short num3 = num;
				num = (short)449576960;
				if (num != 0)
				{
				}
				num = (short)1956052993;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDynamicZoneCable_A41258.Applicable;
			}
			set
			{
				short num = (short)1548358190;
				short num2 = num;
				num = (short)496964142;
				switch (num2 == num)
				{
				}
				num = (short)691994624;
				short num3 = num;
				num = (short)1576402945;
				if (num != 0)
				{
				}
				num = (short)1298989056;
				if (num != 0)
				{
				}
				this.radWideLabtoolDynamicZoneCable_A41258.Applicable = value;
			}
		}

		// Token: 0x17001C9A RID: 7322
		// (get) Token: 0x06003846 RID: 14406 RVA: 0x00358F48 File Offset: 0x00357148
		// (set) Token: 0x06003847 RID: 14407 RVA: 0x00358FFC File Offset: 0x003571FC
		public bool RadWideLabtoolDynamicZoneCable_A41258_Valid
		{
			get
			{
				short num = (short)1422277706;
				short num2 = num;
				num = (short)1345797194;
				switch (num2 == num)
				{
				}
				num = (short)598147072;
				short num3 = num;
				num = (short)450691072;
				if (num != 0)
				{
				}
				num = (short)608305153;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDynamicZoneCable_A41258.Valid;
			}
			set
			{
				short num = (short)1267597313;
				if (num != 0)
				{
				}
				num = (short)1025384081;
				short num2 = num;
				num = (short)154607249;
				switch (num2 == num)
				{
				default:
				{
					num = (short)948109312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)985726976;
				if (num != 0)
				{
				}
				this.radWideLabtoolDynamicZoneCable_A41258.Valid = value;
			}
		}

		// Token: 0x17001C9B RID: 7323
		// (get) Token: 0x06003848 RID: 14408 RVA: 0x003590B0 File Offset: 0x003572B0
		// (set) Token: 0x06003849 RID: 14409 RVA: 0x00359164 File Offset: 0x00357364
		public bool RadWideLabtoolDynamicZoneCable_A41258_Visible
		{
			get
			{
				short num = (short)2032745360;
				short num2 = num;
				num = (short)570375056;
				switch (num2 == num)
				{
				}
				num = (short)1783627776;
				short num3 = num;
				num = (short)27852801;
				if (num != 0)
				{
				}
				num = (short)560070656;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDynamicZoneCable_A41258.Visible;
			}
			set
			{
				short num = (short)1044462454;
				short num2 = num;
				num = (short)1766865782;
				switch (num2 == num)
				{
				}
				num = (short)399769600;
				short num3 = num;
				num = (short)1300168705;
				if (num != 0)
				{
				}
				num = (short)1989017600;
				if (num != 0)
				{
				}
				this.radWideLabtoolDynamicZoneCable_A41258.Visible = value;
			}
		}

		// Token: 0x17001C9C RID: 7324
		// (get) Token: 0x0600384A RID: 14410 RVA: 0x00359218 File Offset: 0x00357418
		// (set) Token: 0x0600384B RID: 14411 RVA: 0x003592D0 File Offset: 0x003574D0
		public bool RadWideLabtoolDynamicZoneCable_A41258_Editable
		{
			get
			{
				short num = (short)1773645608;
				short num2 = num;
				num = (short)260878120;
				switch (num2 == num)
				{
				}
				num = (short)855113728;
				short num3 = num;
				num = (short)667615232;
				if (num != 0)
				{
				}
				num = (short)864419841;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDynamicZoneCable_A41258.Editable;
			}
			set
			{
				short num = (short)1291141533;
				short num2 = num;
				num = (short)562512285;
				switch (num2 == num)
				{
				}
				num = (short)244449280;
				short num3 = num;
				num = (short)1574174721;
				if (num != 0)
				{
				}
				num = (short)1114636288;
				if (num != 0)
				{
				}
				this.radWideLabtoolDynamicZoneCable_A41258.Editable = value;
			}
		}

		// Token: 0x17001C9D RID: 7325
		// (get) Token: 0x0600384C RID: 14412 RVA: 0x00359388 File Offset: 0x00357588
		internal string RadWideLabtoolDynamicZoneCable_A41258_UILabel
		{
			get
			{
				short num = (short)2050675200;
				short num2 = num;
				num = (short)959173120;
				switch (num2 == num)
				{
				}
				num = (short)1237647360;
				short num3 = num;
				num = (short)1399980033;
				if (num != 0)
				{
				}
				num = (short)869466112;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDynamicZoneCable_A41258.UIName;
			}
		}

		// Token: 0x17001C9E RID: 7326
		// (get) Token: 0x0600384D RID: 14413 RVA: 0x0035943C File Offset: 0x0035763C
		// (set) Token: 0x0600384E RID: 14414 RVA: 0x003594F0 File Offset: 0x003576F0
		internal bool RadWideLabtoolDynamicZoneCable_A41258_HiddenStatic
		{
			get
			{
				short num = (short)1067327435;
				short num2 = num;
				num = (short)1487413195;
				switch (num2 == num)
				{
				}
				num = (short)2135097344;
				short num3 = num;
				num = (short)1640169473;
				if (num != 0)
				{
				}
				num = (short)977338368;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDynamicZoneCable_A41258.HiddenStatic;
			}
			set
			{
				short num = (short)877711679;
				short num2 = num;
				num = (short)1174917439;
				switch (num2 == num)
				{
				}
				num = (short)1594556416;
				short num3 = num;
				num = (short)1978204161;
				if (num != 0)
				{
				}
				num = (short)1319239680;
				if (num != 0)
				{
				}
				this.radWideLabtoolDynamicZoneCable_A41258.HiddenStatic = value;
			}
		}

		// Token: 0x17001C9F RID: 7327
		// (get) Token: 0x0600384F RID: 14415 RVA: 0x003595A8 File Offset: 0x003577A8
		// (set) Token: 0x06003850 RID: 14416 RVA: 0x0035965C File Offset: 0x0035785C
		internal bool RadWideLabtoolDynamicZoneCable_A41258_HiddenDynamic
		{
			get
			{
				short num = (short)1244463147;
				short num2 = num;
				num = (short)514523179;
				switch (num2 == num)
				{
				}
				num = (short)1294729216;
				short num3 = num;
				num = (short)1834680320;
				if (num != 0)
				{
				}
				num = (short)21757953;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDynamicZoneCable_A41258.HiddenDynamic;
			}
			set
			{
				short num = (short)1889545985;
				short num2 = num;
				num = (short)854732545;
				switch (num2 == num)
				{
				}
				num = (short)2052259840;
				short num3 = num;
				num = (short)1132396545;
				if (num != 0)
				{
				}
				num = (short)473825280;
				if (num != 0)
				{
				}
				this.radWideLabtoolDynamicZoneCable_A41258.HiddenDynamic = value;
			}
		}

		// Token: 0x17001CA0 RID: 7328
		// (get) Token: 0x06003851 RID: 14417 RVA: 0x00359714 File Offset: 0x00357914
		public bool RadWideLabtoolDynamicZoneCable_A41258_HasDiffs
		{
			get
			{
				short num = (short)1501861419;
				short num2 = num;
				num = (short)308581931;
				switch (num2 == num)
				{
				}
				num = (short)1199374336;
				short num3 = num;
				num = (short)1399848960;
				if (num != 0)
				{
				}
				num = (short)585826305;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDynamicZoneCable_A41258._HasDiffs;
			}
		}

		// Token: 0x17001CA1 RID: 7329
		// (get) Token: 0x06003852 RID: 14418 RVA: 0x003597CC File Offset: 0x003579CC
		// (set) Token: 0x06003853 RID: 14419 RVA: 0x00359884 File Offset: 0x00357A84
		public bool RadWideLabtoolSirenAndLightsKeypadEnable_A41413Value
		{
			get
			{
				short num = (short)1160009436;
				short num2 = num;
				num = (short)1257527004;
				switch (num2 == num)
				{
				}
				num = (short)267517952;
				short num3 = num;
				num = (short)158662656;
				if (num != 0)
				{
				}
				num = (short)758841345;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSirenAndLightsKeypadEnable_A41413.Value;
			}
			set
			{
				short num = (short)1452697462;
				short num2 = num;
				num = (short)970352502;
				switch (num2 == num)
				{
				}
				num = (short)78446592;
				short num3 = num;
				num = (short)1148190720;
				if (num != 0)
				{
				}
				num = (short)33554433;
				if (num != 0)
				{
				}
				this.radWideLabtoolSirenAndLightsKeypadEnable_A41413.Value = value;
			}
		}

		// Token: 0x17001CA2 RID: 7330
		// (get) Token: 0x06003854 RID: 14420 RVA: 0x00359938 File Offset: 0x00357B38
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolSirenAndLightsKeypadEnable_A41413
		{
			get
			{
				short num = (short)409949589;
				short num2 = num;
				num = (short)803952021;
				switch (num2 == num)
				{
				}
				num = (short)1906835456;
				short num3 = num;
				num = (short)303497217;
				if (num != 0)
				{
				}
				num = (short)1718747136;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSirenAndLightsKeypadEnable_A41413;
			}
		}

		// Token: 0x17001CA3 RID: 7331
		// (get) Token: 0x06003855 RID: 14421 RVA: 0x003599E8 File Offset: 0x00357BE8
		// (set) Token: 0x06003856 RID: 14422 RVA: 0x00359A98 File Offset: 0x00357C98
		public bool RadWideLabtoolSirenAndLightsKeypadEnable_A41413_UIValue
		{
			get
			{
				short num = (short)941243094;
				short num2 = num;
				num = (short)1135098582;
				switch (num2 == num)
				{
				}
				num = (short)808255488;
				short num3 = num;
				num = (short)1918631936;
				if (num != 0)
				{
				}
				num = (short)505806849;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSirenAndLightsKeypadEnable_A41413.Value;
			}
			set
			{
				short num = (short)400621569;
				if (num != 0)
				{
				}
				num = (short)1186856063;
				short num2 = num;
				num = (short)858979455;
				switch (num2 == num)
				{
				default:
				{
					num = (short)81526784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)314638336;
				if (num != 0)
				{
				}
				this.radWideLabtoolSirenAndLightsKeypadEnable_A41413.Value = value;
			}
		}

		// Token: 0x17001CA4 RID: 7332
		// (get) Token: 0x06003857 RID: 14423 RVA: 0x00359B4C File Offset: 0x00357D4C
		// (set) Token: 0x06003858 RID: 14424 RVA: 0x00359C04 File Offset: 0x00357E04
		public bool RadWideLabtoolSirenAndLightsKeypadEnable_A41413_Applicable
		{
			get
			{
				short num = (short)769519723;
				short num2 = num;
				num = (short)418902123;
				switch (num2 == num)
				{
				}
				num = (short)100597760;
				short num3 = num;
				num = (short)1098776577;
				if (num != 0)
				{
				}
				num = (short)193855488;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSirenAndLightsKeypadEnable_A41413.Applicable;
			}
			set
			{
				short num = (short)1966544824;
				short num2 = num;
				num = (short)946476984;
				switch (num2 == num)
				{
				}
				num = (short)882966528;
				short num3 = num;
				num = (short)966066177;
				if (num != 0)
				{
				}
				num = (short)981270528;
				if (num != 0)
				{
				}
				this.radWideLabtoolSirenAndLightsKeypadEnable_A41413.Applicable = value;
			}
		}

		// Token: 0x17001CA5 RID: 7333
		// (get) Token: 0x06003859 RID: 14425 RVA: 0x00359CBC File Offset: 0x00357EBC
		// (set) Token: 0x0600385A RID: 14426 RVA: 0x00359D70 File Offset: 0x00357F70
		public bool RadWideLabtoolSirenAndLightsKeypadEnable_A41413_Valid
		{
			get
			{
				short num = (short)512075537;
				short num2 = num;
				num = (short)1806280465;
				switch (num2 == num)
				{
				}
				num = (short)2092498944;
				short num3 = num;
				num = (short)1524367360;
				if (num != 0)
				{
				}
				num = (short)1123024897;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSirenAndLightsKeypadEnable_A41413.Valid;
			}
			set
			{
				short num = (short)1495312381;
				short num2 = num;
				num = (short)1581033469;
				switch (num2 == num)
				{
				}
				num = (short)218759168;
				short num3 = num;
				num = (short)1720778753;
				if (num != 0)
				{
				}
				num = (short)208535552;
				if (num != 0)
				{
				}
				this.radWideLabtoolSirenAndLightsKeypadEnable_A41413.Valid = value;
			}
		}

		// Token: 0x17001CA6 RID: 7334
		// (get) Token: 0x0600385B RID: 14427 RVA: 0x00359E24 File Offset: 0x00358024
		// (set) Token: 0x0600385C RID: 14428 RVA: 0x00359EDC File Offset: 0x003580DC
		public bool RadWideLabtoolSirenAndLightsKeypadEnable_A41413_Visible
		{
			get
			{
				short num = (short)2079078878;
				short num2 = num;
				num = (short)1531984350;
				switch (num2 == num)
				{
				}
				num = (short)798687232;
				short num3 = num;
				num = (short)110166016;
				if (num != 0)
				{
				}
				num = (short)148504577;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSirenAndLightsKeypadEnable_A41413.Visible;
			}
			set
			{
				short num = (short)1943732225;
				if (num != 0)
				{
				}
				num = (short)523131962;
				short num2 = num;
				num = (short)482499642;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1088749568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1714028544;
				if (num != 0)
				{
				}
				this.radWideLabtoolSirenAndLightsKeypadEnable_A41413.Visible = value;
			}
		}

		// Token: 0x17001CA7 RID: 7335
		// (get) Token: 0x0600385D RID: 14429 RVA: 0x00359F90 File Offset: 0x00358190
		// (set) Token: 0x0600385E RID: 14430 RVA: 0x0035A044 File Offset: 0x00358244
		public bool RadWideLabtoolSirenAndLightsKeypadEnable_A41413_Editable
		{
			get
			{
				short num = (short)283310748;
				short num2 = num;
				num = (short)485096092;
				switch (num2 == num)
				{
				}
				num = (short)817037312;
				short num3 = num;
				num = (short)1356005377;
				if (num != 0)
				{
				}
				num = (short)486211584;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSirenAndLightsKeypadEnable_A41413.Editable;
			}
			set
			{
				short num = (short)1819279361;
				if (num != 0)
				{
				}
				num = (short)575733001;
				short num2 = num;
				num = (short)1842543881;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1237385216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)92012544;
				if (num != 0)
				{
				}
				this.radWideLabtoolSirenAndLightsKeypadEnable_A41413.Editable = value;
			}
		}

		// Token: 0x17001CA8 RID: 7336
		// (get) Token: 0x0600385F RID: 14431 RVA: 0x0035A0F8 File Offset: 0x003582F8
		internal string RadWideLabtoolSirenAndLightsKeypadEnable_A41413_UILabel
		{
			get
			{
				short num = (short)1458188074;
				short num2 = num;
				num = (short)1102524202;
				switch (num2 == num)
				{
				}
				num = (short)656015360;
				short num3 = num;
				num = (short)762707969;
				if (num != 0)
				{
				}
				num = (short)1673265152;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSirenAndLightsKeypadEnable_A41413.UIName;
			}
		}

		// Token: 0x17001CA9 RID: 7337
		// (get) Token: 0x06003860 RID: 14432 RVA: 0x0035A1AC File Offset: 0x003583AC
		// (set) Token: 0x06003861 RID: 14433 RVA: 0x0035A260 File Offset: 0x00358460
		internal bool RadWideLabtoolSirenAndLightsKeypadEnable_A41413_HiddenStatic
		{
			get
			{
				short num = (short)1072015883;
				short num2 = num;
				num = (short)2106763787;
				switch (num2 == num)
				{
				}
				num = (short)2015756288;
				short num3 = num;
				num = (short)1857224705;
				if (num != 0)
				{
				}
				num = (short)618397696;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSirenAndLightsKeypadEnable_A41413.HiddenStatic;
			}
			set
			{
				short num = (short)1393180674;
				short num2 = num;
				num = (short)841564162;
				switch (num2 == num)
				{
				}
				num = (short)1424752640;
				short num3 = num;
				num = (short)1534328833;
				if (num != 0)
				{
				}
				num = (short)1871577088;
				if (num != 0)
				{
				}
				this.radWideLabtoolSirenAndLightsKeypadEnable_A41413.HiddenStatic = value;
			}
		}

		// Token: 0x17001CAA RID: 7338
		// (get) Token: 0x06003862 RID: 14434 RVA: 0x0035A314 File Offset: 0x00358514
		// (set) Token: 0x06003863 RID: 14435 RVA: 0x0035A3C8 File Offset: 0x003585C8
		internal bool RadWideLabtoolSirenAndLightsKeypadEnable_A41413_HiddenDynamic
		{
			get
			{
				short num = (short)1786119527;
				short num2 = num;
				num = (short)456000871;
				switch (num2 == num)
				{
				}
				num = (short)1145634816;
				short num3 = num;
				num = (short)1883766784;
				if (num != 0)
				{
				}
				num = (short)255066113;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSirenAndLightsKeypadEnable_A41413.HiddenDynamic;
			}
			set
			{
				short num = (short)800925877;
				short num2 = num;
				num = (short)1652959413;
				switch (num2 == num)
				{
				}
				num = (short)180813824;
				short num3 = num;
				num = (short)1432748032;
				if (num != 0)
				{
				}
				num = (short)92602369;
				if (num != 0)
				{
				}
				this.radWideLabtoolSirenAndLightsKeypadEnable_A41413.HiddenDynamic = value;
			}
		}

		// Token: 0x17001CAB RID: 7339
		// (get) Token: 0x06003864 RID: 14436 RVA: 0x0035A47C File Offset: 0x0035867C
		public bool RadWideLabtoolSirenAndLightsKeypadEnable_A41413_HasDiffs
		{
			get
			{
				short num = (short)1848972304;
				short num2 = num;
				num = (short)1894650896;
				switch (num2 == num)
				{
				}
				num = (short)282263552;
				short num3 = num;
				num = (short)925368321;
				if (num != 0)
				{
				}
				num = (short)1767964672;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSirenAndLightsKeypadEnable_A41413._HasDiffs;
			}
		}

		// Token: 0x17001CAC RID: 7340
		// (get) Token: 0x06003865 RID: 14437 RVA: 0x0035A530 File Offset: 0x00358730
		// (set) Token: 0x06003866 RID: 14438 RVA: 0x0035A5E4 File Offset: 0x003587E4
		public int RadWideEmergencyRxTxAlertToneSet_A41508Value
		{
			get
			{
				short num = (short)1932310111;
				short num2 = num;
				num = (short)1757394527;
				switch (num2 == num)
				{
				}
				num = (short)81657856;
				short num3 = num;
				num = (short)1425866753;
				if (num != 0)
				{
				}
				num = (short)1952317440;
				if (num != 0)
				{
				}
				return this.radWideEmergencyRxTxAlertToneSet_A41508.Value;
			}
			set
			{
				short num = (short)905858399;
				short num2 = num;
				num = (short)1231506783;
				switch (num2 == num)
				{
				}
				num = (short)1181155328;
				short num3 = num;
				num = (short)1650262017;
				if (num != 0)
				{
				}
				num = (short)1575223296;
				if (num != 0)
				{
				}
				this.radWideEmergencyRxTxAlertToneSet_A41508.Value = value;
			}
		}

		// Token: 0x17001CAD RID: 7341
		// (get) Token: 0x06003867 RID: 14439 RVA: 0x0035A69C File Offset: 0x0035889C
		// (set) Token: 0x06003868 RID: 14440 RVA: 0x0035A750 File Offset: 0x00358950
		public string RadWideEmergencyRxTxAlertToneSet_A41508_UIValue
		{
			get
			{
				short num = (short)57933825;
				if (num != 0)
				{
				}
				num = (short)195767403;
				short num2 = num;
				num = (short)190917739;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1504247808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1395392512;
				if (num != 0)
				{
				}
				return this.radWideEmergencyRxTxAlertToneSet_A41508.UIValue;
			}
			set
			{
				short num = (short)1828513248;
				short num2 = num;
				num = (short)1123608032;
				switch (num2 == num)
				{
				default:
				{
					num = (short)708771840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1758461952;
				if (num != 0)
				{
				}
				num = (short)728694785;
				if (num != 0)
				{
				}
				this.radWideEmergencyRxTxAlertToneSet_A41508.UIValue = value;
			}
		}

		// Token: 0x17001CAE RID: 7342
		// (get) Token: 0x06003869 RID: 14441 RVA: 0x0035A804 File Offset: 0x00358A04
		public global::AcpBusinessLayer.AcpListField RadWideEmergencyRxTxAlertToneSet_A41508
		{
			get
			{
				short num = (short)1848930291;
				short num2 = num;
				num = (short)1941204979;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2056847360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1834745856;
				if (num != 0)
				{
				}
				num = (short)1920598017;
				if (num != 0)
				{
				}
				return this.radWideEmergencyRxTxAlertToneSet_A41508;
			}
		}

		// Token: 0x17001CAF RID: 7343
		// (get) Token: 0x0600386A RID: 14442 RVA: 0x0035A8B4 File Offset: 0x00358AB4
		// (set) Token: 0x0600386B RID: 14443 RVA: 0x0035A968 File Offset: 0x00358B68
		public bool RadWideEmergencyRxTxAlertToneSet_A41508_Applicable
		{
			get
			{
				short num = (short)395029719;
				short num2 = num;
				num = (short)88321239;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1806237696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1250230272;
				if (num != 0)
				{
				}
				num = (short)252903425;
				if (num != 0)
				{
				}
				return this.radWideEmergencyRxTxAlertToneSet_A41508.Applicable;
			}
			set
			{
				short num = (short)1781183998;
				short num2 = num;
				num = (short)102151678;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2059206656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1715339265;
				if (num != 0)
				{
				}
				num = (short)1376059392;
				if (num != 0)
				{
				}
				this.radWideEmergencyRxTxAlertToneSet_A41508.Applicable = value;
			}
		}

		// Token: 0x17001CB0 RID: 7344
		// (get) Token: 0x0600386C RID: 14444 RVA: 0x0035AA20 File Offset: 0x00358C20
		// (set) Token: 0x0600386D RID: 14445 RVA: 0x0035AAD8 File Offset: 0x00358CD8
		public bool RadWideEmergencyRxTxAlertToneSet_A41508_Valid
		{
			get
			{
				short num = (short)1217190080;
				short num2 = num;
				num = (short)1493752000;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2016215040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2069823488;
				if (num != 0)
				{
				}
				num = (short)714735617;
				if (num != 0)
				{
				}
				return this.radWideEmergencyRxTxAlertToneSet_A41508.Valid;
			}
			set
			{
				short num = (short)1624809840;
				short num2 = num;
				num = (short)1833869680;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1193607168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)811204609;
				if (num != 0)
				{
				}
				num = (short)1962475520;
				if (num != 0)
				{
				}
				this.radWideEmergencyRxTxAlertToneSet_A41508.Valid = value;
			}
		}

		// Token: 0x17001CB1 RID: 7345
		// (get) Token: 0x0600386E RID: 14446 RVA: 0x0035AB90 File Offset: 0x00358D90
		// (set) Token: 0x0600386F RID: 14447 RVA: 0x0035AC44 File Offset: 0x00358E44
		public bool RadWideEmergencyRxTxAlertToneSet_A41508_Visible
		{
			get
			{
				short num = (short)1105145259;
				short num2 = num;
				num = (short)360787371;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1716256768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)378077184;
				if (num != 0)
				{
				}
				num = (short)157351937;
				if (num != 0)
				{
				}
				return this.radWideEmergencyRxTxAlertToneSet_A41508.Visible;
			}
			set
			{
				short num = (short)14137870;
				short num2 = num;
				num = (short)556644878;
				switch (num2 == num)
				{
				default:
				{
					num = (short)940638208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1336606720;
				if (num != 0)
				{
				}
				num = (short)1525743617;
				if (num != 0)
				{
				}
				this.radWideEmergencyRxTxAlertToneSet_A41508.Visible = value;
			}
		}

		// Token: 0x17001CB2 RID: 7346
		// (get) Token: 0x06003870 RID: 14448 RVA: 0x0035ACF8 File Offset: 0x00358EF8
		// (set) Token: 0x06003871 RID: 14449 RVA: 0x0035ADA8 File Offset: 0x00358FA8
		public bool RadWideEmergencyRxTxAlertToneSet_A41508_Editable
		{
			get
			{
				short num = (short)385929883;
				short num2 = num;
				num = (short)1498337947;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2093875200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)991821824;
				if (num != 0)
				{
				}
				num = (short)1666646017;
				if (num != 0)
				{
				}
				return this.radWideEmergencyRxTxAlertToneSet_A41508.Editable;
			}
			set
			{
				short num = (short)886870932;
				short num2 = num;
				num = (short)1650430868;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2132803584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)810549248;
				if (num != 0)
				{
				}
				num = (short)1609302017;
				if (num != 0)
				{
				}
				this.radWideEmergencyRxTxAlertToneSet_A41508.Editable = value;
			}
		}

		// Token: 0x17001CB3 RID: 7347
		// (get) Token: 0x06003872 RID: 14450 RVA: 0x0035AE5C File Offset: 0x0035905C
		internal string RadWideEmergencyRxTxAlertToneSet_A41508_UILabel
		{
			get
			{
				short num = (short)876340867;
				short num2 = num;
				num = (short)2065294979;
				switch (num2 == num)
				{
				default:
				{
					num = (short)412090368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1720975361;
				if (num != 0)
				{
				}
				num = (short)429457408;
				if (num != 0)
				{
				}
				return this.radWideEmergencyRxTxAlertToneSet_A41508.UIName;
			}
		}

		// Token: 0x17001CB4 RID: 7348
		// (get) Token: 0x06003873 RID: 14451 RVA: 0x0035AF10 File Offset: 0x00359110
		// (set) Token: 0x06003874 RID: 14452 RVA: 0x0035AFC4 File Offset: 0x003591C4
		internal bool RadWideEmergencyRxTxAlertToneSet_A41508_HiddenStatic
		{
			get
			{
				short num = (short)395509761;
				if (num != 0)
				{
				}
				num = (short)1649737728;
				short num2 = num;
				num = (short)13491363;
				short num3 = num;
				num = (short)410377379;
				switch (num3 == num)
				{
				}
				num = (short)7602176;
				if (num != 0)
				{
				}
				return this.radWideEmergencyRxTxAlertToneSet_A41508.HiddenStatic;
			}
			set
			{
				short num = (short)1229902863;
				short num2 = num;
				num = (short)1464259599;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1158807552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)500891649;
				if (num != 0)
				{
				}
				num = (short)1227948032;
				if (num != 0)
				{
				}
				this.radWideEmergencyRxTxAlertToneSet_A41508.HiddenStatic = value;
			}
		}

		// Token: 0x17001CB5 RID: 7349
		// (get) Token: 0x06003875 RID: 14453 RVA: 0x0035B078 File Offset: 0x00359278
		// (set) Token: 0x06003876 RID: 14454 RVA: 0x0035B130 File Offset: 0x00359330
		internal bool RadWideEmergencyRxTxAlertToneSet_A41508_HiddenDynamic
		{
			get
			{
				short num = (short)1084794094;
				short num2 = num;
				num = (short)1882498286;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1932460032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1125908481;
				if (num != 0)
				{
				}
				num = (short)417464320;
				if (num != 0)
				{
				}
				return this.radWideEmergencyRxTxAlertToneSet_A41508.HiddenDynamic;
			}
			set
			{
				short num = (short)1233706281;
				short num2 = num;
				num = (short)1748229417;
				switch (num2 == num)
				{
				default:
				{
					num = (short)711131136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1687879680;
				if (num != 0)
				{
				}
				num = (short)2124152833;
				if (num != 0)
				{
				}
				this.radWideEmergencyRxTxAlertToneSet_A41508.HiddenDynamic = value;
			}
		}

		// Token: 0x17001CB6 RID: 7350
		// (get) Token: 0x06003877 RID: 14455 RVA: 0x0035B1E4 File Offset: 0x003593E4
		public bool RadWideEmergencyRxTxAlertToneSet_A41508_HasDiffs
		{
			get
			{
				short num = (short)1391656961;
				if (num != 0)
				{
				}
				num = (short)2007367680;
				short num2 = num;
				num = (short)203823137;
				short num3 = num;
				num = (short)1471617057;
				switch (num3 == num)
				{
				}
				num = (short)303431680;
				if (num != 0)
				{
				}
				return this.radWideEmergencyRxTxAlertToneSet_A41508._HasDiffs;
			}
		}

		// Token: 0x17001CB7 RID: 7351
		// (get) Token: 0x06003878 RID: 14456 RVA: 0x0035B298 File Offset: 0x00359498
		// (set) Token: 0x06003879 RID: 14457 RVA: 0x0035B350 File Offset: 0x00359550
		public bool RadWideRadioKilled_A41559Value
		{
			get
			{
				short num = (short)745148871;
				short num2 = num;
				num = (short)447353287;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1037959168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1658126337;
				if (num != 0)
				{
				}
				num = (short)1347026944;
				if (num != 0)
				{
				}
				return this.radWideRadioKilled_A41559.Value;
			}
			set
			{
				short num = (short)1125820617;
				short num2 = num;
				num = (short)172992713;
				switch (num2 == num)
				{
				default:
				{
					num = (short)877002752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)395182081;
				if (num != 0)
				{
				}
				num = (short)968228864;
				if (num != 0)
				{
				}
				this.radWideRadioKilled_A41559.Value = value;
			}
		}

		// Token: 0x17001CB8 RID: 7352
		// (get) Token: 0x0600387A RID: 14458 RVA: 0x0035B404 File Offset: 0x00359604
		public global::AcpBusinessLayer.AcpField<bool> RadWideRadioKilled_A41559
		{
			get
			{
				short num = (short)425359728;
				short num2 = num;
				num = (short)1826257264;
				switch (num2 == num)
				{
				default:
				{
					num = (short)913833984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1423310849;
				if (num != 0)
				{
				}
				num = (short)1374552064;
				if (num != 0)
				{
				}
				return this.radWideRadioKilled_A41559;
			}
		}

		// Token: 0x17001CB9 RID: 7353
		// (get) Token: 0x0600387B RID: 14459 RVA: 0x0035B4B4 File Offset: 0x003596B4
		// (set) Token: 0x0600387C RID: 14460 RVA: 0x0035B56C File Offset: 0x0035976C
		public bool RadWideRadioKilled_A41559_UIValue
		{
			get
			{
				short num = (short)1455265868;
				short num2 = num;
				num = (short)377264204;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1532887040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1943797760;
				if (num != 0)
				{
				}
				num = (short)401276929;
				if (num != 0)
				{
				}
				return this.radWideRadioKilled_A41559.Value;
			}
			set
			{
				short num = (short)40266288;
				short num2 = num;
				num = (short)948726320;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1616183296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1418854400;
				if (num != 0)
				{
				}
				num = (short)172425217;
				if (num != 0)
				{
				}
				this.radWideRadioKilled_A41559.Value = value;
			}
		}

		// Token: 0x17001CBA RID: 7354
		// (get) Token: 0x0600387D RID: 14461 RVA: 0x0035B620 File Offset: 0x00359820
		// (set) Token: 0x0600387E RID: 14462 RVA: 0x0035B6D4 File Offset: 0x003598D4
		public bool RadWideRadioKilled_A41559_Applicable
		{
			get
			{
				short num = (short)1503264769;
				if (num != 0)
				{
				}
				num = (short)1957494784;
				short num2 = num;
				num = (short)2010448492;
				short num3 = num;
				num = (short)1804010092;
				switch (num3 == num)
				{
				}
				num = (short)1653342208;
				if (num != 0)
				{
				}
				return this.radWideRadioKilled_A41559.Applicable;
			}
			set
			{
				short num = (short)666681942;
				short num2 = num;
				num = (short)1874969174;
				switch (num2 == num)
				{
				default:
				{
					num = (short)591593472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1955135488;
				if (num != 0)
				{
				}
				num = (short)678166529;
				if (num != 0)
				{
				}
				this.radWideRadioKilled_A41559.Applicable = value;
			}
		}

		// Token: 0x17001CBB RID: 7355
		// (get) Token: 0x0600387F RID: 14463 RVA: 0x0035B788 File Offset: 0x00359988
		// (set) Token: 0x06003880 RID: 14464 RVA: 0x0035B83C File Offset: 0x00359A3C
		public bool RadWideRadioKilled_A41559_Valid
		{
			get
			{
				short num = (short)961954035;
				short num2 = num;
				num = (short)843858163;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1605107712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)953942017;
				if (num != 0)
				{
				}
				num = (short)190644224;
				if (num != 0)
				{
				}
				return this.radWideRadioKilled_A41559.Valid;
			}
			set
			{
				short num = (short)805322348;
				short num2 = num;
				num = (short)1854094956;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1861287936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1492713473;
				if (num != 0)
				{
				}
				num = (short)1515192320;
				if (num != 0)
				{
				}
				this.radWideRadioKilled_A41559.Valid = value;
			}
		}

		// Token: 0x17001CBC RID: 7356
		// (get) Token: 0x06003881 RID: 14465 RVA: 0x0035B8F4 File Offset: 0x00359AF4
		// (set) Token: 0x06003882 RID: 14466 RVA: 0x0035B9A8 File Offset: 0x00359BA8
		public bool RadWideRadioKilled_A41559_Visible
		{
			get
			{
				short num = (short)543981566;
				short num2 = num;
				num = (short)1752662014;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1679687680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1724383233;
				if (num != 0)
				{
				}
				num = (short)1905983488;
				if (num != 0)
				{
				}
				return this.radWideRadioKilled_A41559.Visible;
			}
			set
			{
				short num = (short)562927506;
				short num2 = num;
				num = (short)418617234;
				switch (num2 == num)
				{
				default:
				{
					num = (short)114163712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1398996993;
				if (num != 0)
				{
				}
				num = (short)208863232;
				if (num != 0)
				{
				}
				this.radWideRadioKilled_A41559.Visible = value;
			}
		}

		// Token: 0x17001CBD RID: 7357
		// (get) Token: 0x06003883 RID: 14467 RVA: 0x0035BA5C File Offset: 0x00359C5C
		// (set) Token: 0x06003884 RID: 14468 RVA: 0x0035BB10 File Offset: 0x00359D10
		public bool RadWideRadioKilled_A41559_Editable
		{
			get
			{
				short num = (short)589730301;
				short num2 = num;
				num = (short)1915064829;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2093154304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)240582656;
				if (num != 0)
				{
				}
				num = (short)826605569;
				if (num != 0)
				{
				}
				return this.radWideRadioKilled_A41559.Editable;
			}
			set
			{
				short num = (short)1251940964;
				short num2 = num;
				num = (short)986847844;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1556086784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1349976064;
				if (num != 0)
				{
				}
				num = (short)1420230657;
				if (num != 0)
				{
				}
				this.radWideRadioKilled_A41559.Editable = value;
			}
		}

		// Token: 0x17001CBE RID: 7358
		// (get) Token: 0x06003885 RID: 14469 RVA: 0x0035BBC4 File Offset: 0x00359DC4
		internal string RadWideRadioKilled_A41559_UILabel
		{
			get
			{
				short num = (short)1393207433;
				short num2 = num;
				num = (short)506701961;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1178730496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2018705409;
				if (num != 0)
				{
				}
				num = (short)1412038656;
				if (num != 0)
				{
				}
				return this.radWideRadioKilled_A41559.UIName;
			}
		}

		// Token: 0x17001CBF RID: 7359
		// (get) Token: 0x06003886 RID: 14470 RVA: 0x0035BC7C File Offset: 0x00359E7C
		// (set) Token: 0x06003887 RID: 14471 RVA: 0x0035BD30 File Offset: 0x00359F30
		internal bool RadWideRadioKilled_A41559_HiddenStatic
		{
			get
			{
				short num = (short)1851124762;
				short num2 = num;
				num = (short)1196026906;
				switch (num2 == num)
				{
				default:
				{
					num = (short)321060864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1143406593;
				if (num != 0)
				{
				}
				num = (short)424476672;
				if (num != 0)
				{
				}
				return this.radWideRadioKilled_A41559.HiddenStatic;
			}
			set
			{
				short num = (short)1952676001;
				short num2 = num;
				num = (short)628783265;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1367998464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)448069633;
				if (num != 0)
				{
				}
				num = (short)992477184;
				if (num != 0)
				{
				}
				this.radWideRadioKilled_A41559.HiddenStatic = value;
			}
		}

		// Token: 0x17001CC0 RID: 7360
		// (get) Token: 0x06003888 RID: 14472 RVA: 0x0035BDE4 File Offset: 0x00359FE4
		// (set) Token: 0x06003889 RID: 14473 RVA: 0x0035BE9C File Offset: 0x0035A09C
		internal bool RadWideRadioKilled_A41559_HiddenDynamic
		{
			get
			{
				short num = (short)964100097;
				if (num != 0)
				{
				}
				num = (short)1375666176;
				short num2 = num;
				num = (short)1026705611;
				short num3 = num;
				num = (short)1200572619;
				switch (num3 == num)
				{
				}
				num = (short)1805385728;
				if (num != 0)
				{
				}
				return this.radWideRadioKilled_A41559.HiddenDynamic;
			}
			set
			{
				short num = (short)629484145;
				short num2 = num;
				num = (short)1896426097;
				switch (num2 == num)
				{
				default:
				{
					num = (short)710279168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1293549568;
				if (num != 0)
				{
				}
				num = (short)1507590145;
				if (num != 0)
				{
				}
				this.radWideRadioKilled_A41559.HiddenDynamic = value;
			}
		}

		// Token: 0x17001CC1 RID: 7361
		// (get) Token: 0x0600388A RID: 14474 RVA: 0x0035BF50 File Offset: 0x0035A150
		public bool RadWideRadioKilled_A41559_HasDiffs
		{
			get
			{
				short num = (short)409108886;
				short num2 = num;
				num = (short)462586262;
				switch (num2 == num)
				{
				default:
				{
					num = (short)391315456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)89391104;
				if (num != 0)
				{
				}
				num = (short)638451713;
				if (num != 0)
				{
				}
				return this.radWideRadioKilled_A41559._HasDiffs;
			}
		}

		// Token: 0x17001CC2 RID: 7362
		// (get) Token: 0x0600388B RID: 14475 RVA: 0x0035C000 File Offset: 0x0035A200
		// (set) Token: 0x0600388C RID: 14476 RVA: 0x0035C0B4 File Offset: 0x0035A2B4
		public bool RadWideLabtoolEncryptPassword_A41695Value
		{
			get
			{
				short num = (short)1888019874;
				short num2 = num;
				num = (short)2045240738;
				switch (num2 == num)
				{
				default:
				{
					num = (short)355074048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)29753345;
				if (num != 0)
				{
				}
				num = (short)1944977408;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEncryptPassword_A41695.Value;
			}
			set
			{
				short num = (short)831651841;
				if (num != 0)
				{
				}
				num = (short)50200576;
				short num2 = num;
				num = (short)1671794174;
				short num3 = num;
				num = (short)284069374;
				switch (num3 == num)
				{
				}
				num = (short)2024931328;
				if (num != 0)
				{
				}
				this.radWideLabtoolEncryptPassword_A41695.Value = value;
			}
		}

		// Token: 0x17001CC3 RID: 7363
		// (get) Token: 0x0600388D RID: 14477 RVA: 0x0035C16C File Offset: 0x0035A36C
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolEncryptPassword_A41695
		{
			get
			{
				short num = (short)970475137;
				short num2 = num;
				num = (short)856770177;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1340604416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1329725440;
				if (num != 0)
				{
				}
				num = (short)826736641;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEncryptPassword_A41695;
			}
		}

		// Token: 0x17001CC4 RID: 7364
		// (get) Token: 0x0600388E RID: 14478 RVA: 0x0035C21C File Offset: 0x0035A41C
		// (set) Token: 0x0600388F RID: 14479 RVA: 0x0035C2D0 File Offset: 0x0035A4D0
		public bool RadWideLabtoolEncryptPassword_A41695_UIValue
		{
			get
			{
				short num = (short)2094012330;
				short num2 = num;
				num = (short)301537194;
				switch (num2 == num)
				{
				default:
				{
					num = (short)616431616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)988676097;
				if (num != 0)
				{
				}
				num = (short)1349844992;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEncryptPassword_A41695.Value;
			}
			set
			{
				short num = (short)1988064839;
				short num2 = num;
				num = (short)1030125127;
				switch (num2 == num)
				{
				default:
				{
					num = (short)815202304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1375928321;
				if (num != 0)
				{
				}
				num = (short)206700544;
				if (num != 0)
				{
				}
				this.radWideLabtoolEncryptPassword_A41695.Value = value;
			}
		}

		// Token: 0x17001CC5 RID: 7365
		// (get) Token: 0x06003890 RID: 14480 RVA: 0x0035C388 File Offset: 0x0035A588
		// (set) Token: 0x06003891 RID: 14481 RVA: 0x0035C43C File Offset: 0x0035A63C
		public bool RadWideLabtoolEncryptPassword_A41695_Applicable
		{
			get
			{
				short num = (short)1446607205;
				short num2 = num;
				num = (short)1927117157;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2147352576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1876754432;
				if (num != 0)
				{
				}
				num = (short)1643708417;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEncryptPassword_A41695.Applicable;
			}
			set
			{
				short num = (short)762637806;
				short num2 = num;
				num = (short)247524846;
				switch (num2 == num)
				{
				default:
				{
					num = (short)810811392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)212140033;
				if (num != 0)
				{
				}
				num = (short)772210688;
				if (num != 0)
				{
				}
				this.radWideLabtoolEncryptPassword_A41695.Applicable = value;
			}
		}

		// Token: 0x17001CC6 RID: 7366
		// (get) Token: 0x06003892 RID: 14482 RVA: 0x0035C4F0 File Offset: 0x0035A6F0
		// (set) Token: 0x06003893 RID: 14483 RVA: 0x0035C5A4 File Offset: 0x0035A7A4
		public bool RadWideLabtoolEncryptPassword_A41695_Valid
		{
			get
			{
				short num = (short)1361379329;
				if (num != 0)
				{
				}
				num = (short)1023148032;
				short num2 = num;
				num = (short)1753573186;
				short num3 = num;
				num = (short)1520723778;
				switch (num3 == num)
				{
				}
				num = (short)162398208;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEncryptPassword_A41695.Valid;
			}
			set
			{
				short num = (short)1146276006;
				short num2 = num;
				num = (short)829999270;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1954545664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2136276993;
				if (num != 0)
				{
				}
				num = (short)2129657856;
				if (num != 0)
				{
				}
				this.radWideLabtoolEncryptPassword_A41695.Valid = value;
			}
		}

		// Token: 0x17001CC7 RID: 7367
		// (get) Token: 0x06003894 RID: 14484 RVA: 0x0035C658 File Offset: 0x0035A858
		// (set) Token: 0x06003895 RID: 14485 RVA: 0x0035C70C File Offset: 0x0035A90C
		public bool RadWideLabtoolEncryptPassword_A41695_Visible
		{
			get
			{
				short num = (short)229119001;
				short num2 = num;
				num = (short)982324249;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1845035008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1251737600;
				if (num != 0)
				{
				}
				num = (short)616235009;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEncryptPassword_A41695.Visible;
			}
			set
			{
				short num = (short)1090986086;
				short num2 = num;
				num = (short)1027940454;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1266352128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2110652416;
				if (num != 0)
				{
				}
				num = (short)773521409;
				if (num != 0)
				{
				}
				this.radWideLabtoolEncryptPassword_A41695.Visible = value;
			}
		}

		// Token: 0x17001CC8 RID: 7368
		// (get) Token: 0x06003896 RID: 14486 RVA: 0x0035C7C0 File Offset: 0x0035A9C0
		// (set) Token: 0x06003897 RID: 14487 RVA: 0x0035C878 File Offset: 0x0035AA78
		public bool RadWideLabtoolEncryptPassword_A41695_Editable
		{
			get
			{
				short num = (short)2041666330;
				short num2 = num;
				num = (short)2104646426;
				switch (num2 == num)
				{
				default:
				{
					num = (short)118751232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1302855681;
				if (num != 0)
				{
				}
				num = (short)1548091392;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEncryptPassword_A41695.Editable;
			}
			set
			{
				short num = (short)1493894428;
				short num2 = num;
				num = (short)2082211100;
				switch (num2 == num)
				{
				default:
				{
					num = (short)9240576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1069219841;
				if (num != 0)
				{
				}
				num = (short)1916600320;
				if (num != 0)
				{
				}
				this.radWideLabtoolEncryptPassword_A41695.Editable = value;
			}
		}

		// Token: 0x17001CC9 RID: 7369
		// (get) Token: 0x06003898 RID: 14488 RVA: 0x0035C930 File Offset: 0x0035AB30
		internal string RadWideLabtoolEncryptPassword_A41695_UILabel
		{
			get
			{
				short num = (short)1066951385;
				short num2 = num;
				num = (short)185819865;
				switch (num2 == num)
				{
				default:
				{
					num = (short)425918464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)867237888;
				if (num != 0)
				{
				}
				num = (short)174456833;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEncryptPassword_A41695.UIName;
			}
		}

		// Token: 0x17001CCA RID: 7370
		// (get) Token: 0x06003899 RID: 14489 RVA: 0x0035C9E8 File Offset: 0x0035ABE8
		// (set) Token: 0x0600389A RID: 14490 RVA: 0x0035CA9C File Offset: 0x0035AC9C
		internal bool RadWideLabtoolEncryptPassword_A41695_HiddenStatic
		{
			get
			{
				short num = (short)671018309;
				short num2 = num;
				num = (short)195816773;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1875968000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)308412417;
				if (num != 0)
				{
				}
				num = (short)198901760;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEncryptPassword_A41695.HiddenStatic;
			}
			set
			{
				short num = (short)646649582;
				short num2 = num;
				num = (short)1499862766;
				switch (num2 == num)
				{
				default:
				{
					num = (short)142802944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1886912513;
				if (num != 0)
				{
				}
				num = (short)789446656;
				if (num != 0)
				{
				}
				this.radWideLabtoolEncryptPassword_A41695.HiddenStatic = value;
			}
		}

		// Token: 0x17001CCB RID: 7371
		// (get) Token: 0x0600389B RID: 14491 RVA: 0x0035CB58 File Offset: 0x0035AD58
		// (set) Token: 0x0600389C RID: 14492 RVA: 0x0035CC0C File Offset: 0x0035AE0C
		internal bool RadWideLabtoolEncryptPassword_A41695_HiddenDynamic
		{
			get
			{
				short num = (short)1194459137;
				if (num != 0)
				{
				}
				num = (short)463011840;
				short num2 = num;
				num = (short)1905683271;
				short num3 = num;
				num = (short)1780509511;
				switch (num3 == num)
				{
				}
				num = (short)1856241664;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEncryptPassword_A41695.HiddenDynamic;
			}
			set
			{
				short num = (short)2035170542;
				short num2 = num;
				num = (short)1667906798;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1057947648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2136801281;
				if (num != 0)
				{
				}
				num = (short)1412235264;
				if (num != 0)
				{
				}
				this.radWideLabtoolEncryptPassword_A41695.HiddenDynamic = value;
			}
		}

		// Token: 0x17001CCC RID: 7372
		// (get) Token: 0x0600389D RID: 14493 RVA: 0x0035CCC4 File Offset: 0x0035AEC4
		public bool RadWideLabtoolEncryptPassword_A41695_HasDiffs
		{
			get
			{
				short num = (short)1992144147;
				short num2 = num;
				num = (short)886945043;
				switch (num2 == num)
				{
				default:
				{
					num = (short)60293120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)141492224;
				if (num != 0)
				{
				}
				num = (short)398000129;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEncryptPassword_A41695._HasDiffs;
			}
		}

		// Token: 0x17001CCD RID: 7373
		// (get) Token: 0x0600389E RID: 14494 RVA: 0x0035CD78 File Offset: 0x0035AF78
		// (set) Token: 0x0600389F RID: 14495 RVA: 0x0035CE2C File Offset: 0x0035B02C
		public string RadWideLabtoolEncryptedPINPassword_A41702Value
		{
			get
			{
				short num = (short)2140586554;
				short num2 = num;
				num = (short)593805882;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1388445696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1786904577;
				if (num != 0)
				{
				}
				num = (short)1137180672;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEncryptedPINPassword_A41702.Value;
			}
			set
			{
				short num = (short)723910656;
				short num2 = num;
				num = (short)353362803;
				short num3 = num;
				num = (short)1002103667;
				switch (num3 == num)
				{
				}
				num = (short)1741094912;
				if (num != 0)
				{
				}
				num = (short)1852506113;
				if (num != 0)
				{
				}
				this.radWideLabtoolEncryptedPINPassword_A41702.Value = value;
			}
		}

		// Token: 0x17001CCE RID: 7374
		// (get) Token: 0x060038A0 RID: 14496 RVA: 0x0035CEE4 File Offset: 0x0035B0E4
		public global::AcpBusinessLayer.AcpField<string> RadWideLabtoolEncryptedPINPassword_A41702
		{
			get
			{
				short num = (short)499253248;
				short num2 = num;
				num = (short)1365552540;
				short num3 = num;
				num = (short)1869786524;
				switch (num3 == num)
				{
				}
				num = (short)568197120;
				if (num != 0)
				{
				}
				num = (short)1084817409;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEncryptedPINPassword_A41702;
			}
		}

		// Token: 0x17001CCF RID: 7375
		// (get) Token: 0x060038A1 RID: 14497 RVA: 0x0035CF94 File Offset: 0x0035B194
		// (set) Token: 0x060038A2 RID: 14498 RVA: 0x0035D048 File Offset: 0x0035B248
		public string RadWideLabtoolEncryptedPINPassword_A41702_UIValue
		{
			get
			{
				short num = (short)1731264512;
				short num2 = num;
				num = (short)605383651;
				short num3 = num;
				num = (short)1961061347;
				switch (num3 == num)
				{
				}
				num = (short)1815019521;
				if (num != 0)
				{
				}
				num = (short)718929920;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEncryptedPINPassword_A41702.Value;
			}
			set
			{
				short num = (short)298385408;
				short num2 = num;
				num = (short)1618507665;
				short num3 = num;
				num = (short)1113880465;
				switch (num3 == num)
				{
				}
				num = (short)1536098304;
				if (num != 0)
				{
				}
				num = (short)992804865;
				if (num != 0)
				{
				}
				this.radWideLabtoolEncryptedPINPassword_A41702.Value = value;
			}
		}

		// Token: 0x17001CD0 RID: 7376
		// (get) Token: 0x060038A3 RID: 14499 RVA: 0x0035D0FC File Offset: 0x0035B2FC
		// (set) Token: 0x060038A4 RID: 14500 RVA: 0x0035D1B0 File Offset: 0x0035B3B0
		public bool RadWideLabtoolEncryptedPINPassword_A41702_Applicable
		{
			get
			{
				short num = (short)2007957504;
				short num2 = num;
				num = (short)1201821890;
				short num3 = num;
				num = (short)1773033666;
				switch (num3 == num)
				{
				}
				num = (short)2106982401;
				if (num != 0)
				{
				}
				num = (short)178061312;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEncryptedPINPassword_A41702.Applicable;
			}
			set
			{
				short num = (short)774897664;
				short num2 = num;
				num = (short)512163841;
				if (num != 0)
				{
				}
				num = (short)757205470;
				short num3 = num;
				num = (short)1379666398;
				switch (num3 == num)
				{
				}
				num = (short)1885863936;
				if (num != 0)
				{
				}
				this.radWideLabtoolEncryptedPINPassword_A41702.Applicable = value;
			}
		}

		// Token: 0x17001CD1 RID: 7377
		// (get) Token: 0x060038A5 RID: 14501 RVA: 0x0035D264 File Offset: 0x0035B464
		// (set) Token: 0x060038A6 RID: 14502 RVA: 0x0035D318 File Offset: 0x0035B518
		public bool RadWideLabtoolEncryptedPINPassword_A41702_Valid
		{
			get
			{
				short num = (short)1548025856;
				short num2 = num;
				num = (short)288791470;
				short num3 = num;
				num = (short)1748409262;
				switch (num3 == num)
				{
				}
				num = (short)694747137;
				if (num != 0)
				{
				}
				num = (short)1020395520;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEncryptedPINPassword_A41702.Valid;
			}
			set
			{
				short num = (short)2104426496;
				short num2 = num;
				num = (short)124821418;
				short num3 = num;
				num = (short)481992618;
				switch (num3 == num)
				{
				}
				num = (short)2075721729;
				if (num != 0)
				{
				}
				num = (short)438501376;
				if (num != 0)
				{
				}
				this.radWideLabtoolEncryptedPINPassword_A41702.Valid = value;
			}
		}

		// Token: 0x17001CD2 RID: 7378
		// (get) Token: 0x060038A7 RID: 14503 RVA: 0x0035D3CC File Offset: 0x0035B5CC
		// (set) Token: 0x060038A8 RID: 14504 RVA: 0x0035D480 File Offset: 0x0035B680
		public bool RadWideLabtoolEncryptedPINPassword_A41702_Visible
		{
			get
			{
				short num = (short)1310064640;
				short num2 = num;
				num = (short)246819346;
				short num3 = num;
				num = (short)1066805778;
				switch (num3 == num)
				{
				}
				num = (short)336920577;
				if (num != 0)
				{
				}
				num = (short)101384192;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEncryptedPINPassword_A41702.Visible;
			}
			set
			{
				short num = (short)1176436736;
				short num2 = num;
				num = (short)329033593;
				short num3 = num;
				num = (short)833726329;
				switch (num3 == num)
				{
				}
				num = (short)1142030337;
				if (num != 0)
				{
				}
				num = (short)1423966208;
				if (num != 0)
				{
				}
				this.radWideLabtoolEncryptedPINPassword_A41702.Visible = value;
			}
		}

		// Token: 0x17001CD3 RID: 7379
		// (get) Token: 0x060038A9 RID: 14505 RVA: 0x0035D534 File Offset: 0x0035B734
		// (set) Token: 0x060038AA RID: 14506 RVA: 0x0035D5E8 File Offset: 0x0035B7E8
		public bool RadWideLabtoolEncryptedPINPassword_A41702_Editable
		{
			get
			{
				short num = (short)216268800;
				short num2 = num;
				num = (short)330657249;
				short num3 = num;
				num = (short)1555262945;
				switch (num3 == num)
				{
				}
				num = (short)2140405760;
				if (num != 0)
				{
				}
				num = (short)720568321;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEncryptedPINPassword_A41702.Editable;
			}
			set
			{
				short num = (short)1448804352;
				short num2 = num;
				num = (short)408851415;
				short num3 = num;
				num = (short)508007383;
				switch (num3 == num)
				{
				}
				num = (short)219086848;
				if (num != 0)
				{
				}
				num = (short)94633985;
				if (num != 0)
				{
				}
				this.radWideLabtoolEncryptedPINPassword_A41702.Editable = value;
			}
		}

		// Token: 0x17001CD4 RID: 7380
		// (get) Token: 0x060038AB RID: 14507 RVA: 0x0035D69C File Offset: 0x0035B89C
		internal string RadWideLabtoolEncryptedPINPassword_A41702_UILabel
		{
			get
			{
				short num = (short)1186332672;
				short num2 = num;
				num = (short)186624414;
				short num3 = num;
				num = (short)1199024542;
				switch (num3 == num)
				{
				}
				num = (short)1056112641;
				if (num != 0)
				{
				}
				num = (short)455999488;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEncryptedPINPassword_A41702.UIName;
			}
		}

		// Token: 0x17001CD5 RID: 7381
		// (get) Token: 0x060038AC RID: 14508 RVA: 0x0035D750 File Offset: 0x0035B950
		// (set) Token: 0x060038AD RID: 14509 RVA: 0x0035D804 File Offset: 0x0035BA04
		internal bool RadWideLabtoolEncryptedPINPassword_A41702_HiddenStatic
		{
			get
			{
				short num = (short)1114112;
				short num2 = num;
				num = (short)735519576;
				short num3 = num;
				num = (short)1896686424;
				switch (num3 == num)
				{
				}
				num = (short)1982398465;
				if (num != 0)
				{
				}
				num = (short)635437056;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEncryptedPINPassword_A41702.HiddenStatic;
			}
			set
			{
				short num = (short)136052736;
				short num2 = num;
				num = (short)132315015;
				short num3 = num;
				num = (short)68155271;
				switch (num3 == num)
				{
				}
				num = (short)362151937;
				if (num != 0)
				{
				}
				num = (short)1262682112;
				if (num != 0)
				{
				}
				this.radWideLabtoolEncryptedPINPassword_A41702.HiddenStatic = value;
			}
		}

		// Token: 0x17001CD6 RID: 7382
		// (get) Token: 0x060038AE RID: 14510 RVA: 0x0035D8B8 File Offset: 0x0035BAB8
		// (set) Token: 0x060038AF RID: 14511 RVA: 0x0035D968 File Offset: 0x0035BB68
		internal bool RadWideLabtoolEncryptedPINPassword_A41702_HiddenDynamic
		{
			get
			{
				short num = (short)1603469312;
				short num2 = num;
				num = (short)2043150337;
				if (num != 0)
				{
				}
				num = (short)2044365346;
				short num3 = num;
				num = (short)2135067170;
				switch (num3 == num)
				{
				}
				num = (short)1801519104;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEncryptedPINPassword_A41702.HiddenDynamic;
			}
			set
			{
				short num = (short)1585512448;
				short num2 = num;
				num = (short)923781958;
				short num3 = num;
				num = (short)806800198;
				switch (num3 == num)
				{
				}
				num = (short)359596032;
				if (num != 0)
				{
				}
				num = (short)304414721;
				if (num != 0)
				{
				}
				this.radWideLabtoolEncryptedPINPassword_A41702.HiddenDynamic = value;
			}
		}

		// Token: 0x17001CD7 RID: 7383
		// (get) Token: 0x060038B0 RID: 14512 RVA: 0x0035DA1C File Offset: 0x0035BC1C
		public bool RadWideLabtoolEncryptedPINPassword_A41702_HasDiffs
		{
			get
			{
				short num = (short)1951596544;
				short num2 = num;
				num = (short)1380946207;
				short num3 = num;
				num = (short)1763414303;
				switch (num3 == num)
				{
				}
				num = (short)896925697;
				if (num != 0)
				{
				}
				num = (short)2003959808;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEncryptedPINPassword_A41702._HasDiffs;
			}
		}

		// Token: 0x17001CD8 RID: 7384
		// (get) Token: 0x060038B1 RID: 14513 RVA: 0x0035DACC File Offset: 0x0035BCCC
		// (set) Token: 0x060038B2 RID: 14514 RVA: 0x0035DB80 File Offset: 0x0035BD80
		public bool RadWideLabtoolUltraLowPowerSoldierMacCapable_A41710Value
		{
			get
			{
				short num = (short)59965440;
				short num2 = num;
				num = (short)2037186561;
				if (num != 0)
				{
				}
				num = (short)1386480424;
				short num3 = num;
				num = (short)1729954600;
				switch (num3 == num)
				{
				}
				num = (short)800587776;
				if (num != 0)
				{
				}
				return this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710.Value;
			}
			set
			{
				short num = (short)1146486784;
				short num2 = num;
				num = (short)1457594087;
				short num3 = num;
				num = (short)400039655;
				switch (num3 == num)
				{
				}
				num = (short)483328000;
				if (num != 0)
				{
				}
				num = (short)1537802241;
				if (num != 0)
				{
				}
				this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710.Value = value;
			}
		}

		// Token: 0x17001CD9 RID: 7385
		// (get) Token: 0x060038B3 RID: 14515 RVA: 0x0035DC38 File Offset: 0x0035BE38
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolUltraLowPowerSoldierMacCapable_A41710
		{
			get
			{
				short num = (short)1846542336;
				short num2 = num;
				num = (short)1610350593;
				if (num != 0)
				{
				}
				num = (short)1852013633;
				short num3 = num;
				num = (short)727743553;
				switch (num3 == num)
				{
				}
				num = (short)817954816;
				if (num != 0)
				{
				}
				return this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710;
			}
		}

		// Token: 0x17001CDA RID: 7386
		// (get) Token: 0x060038B4 RID: 14516 RVA: 0x0035DCEC File Offset: 0x0035BEEC
		// (set) Token: 0x060038B5 RID: 14517 RVA: 0x0035DDA0 File Offset: 0x0035BFA0
		public bool RadWideLabtoolUltraLowPowerSoldierMacCapable_A41710_UIValue
		{
			get
			{
				short num = (short)28311552;
				short num2 = num;
				num = (short)2057280298;
				short num3 = num;
				num = (short)2117770026;
				switch (num3 == num)
				{
				}
				num = (short)717946880;
				if (num != 0)
				{
				}
				num = (short)506920961;
				if (num != 0)
				{
				}
				return this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710.Value;
			}
			set
			{
				short num = (short)556072960;
				short num2 = num;
				num = (short)659421616;
				short num3 = num;
				num = (short)2126117296;
				switch (num3 == num)
				{
				}
				num = (short)1013841921;
				if (num != 0)
				{
				}
				num = (short)1146486784;
				if (num != 0)
				{
				}
				this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710.Value = value;
			}
		}

		// Token: 0x17001CDB RID: 7387
		// (get) Token: 0x060038B6 RID: 14518 RVA: 0x0035DE58 File Offset: 0x0035C058
		// (set) Token: 0x060038B7 RID: 14519 RVA: 0x0035DF0C File Offset: 0x0035C10C
		public bool RadWideLabtoolUltraLowPowerSoldierMacCapable_A41710_Applicable
		{
			get
			{
				short num = (short)142540800;
				short num2 = num;
				num = (short)197536986;
				short num3 = num;
				num = (short)1992895706;
				switch (num3 == num)
				{
				}
				num = (short)1531904001;
				if (num != 0)
				{
				}
				num = (short)1074003968;
				if (num != 0)
				{
				}
				return this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710.Applicable;
			}
			set
			{
				short num = (short)1953300480;
				short num2 = num;
				num = (short)2066292229;
				short num3 = num;
				num = (short)1605312005;
				switch (num3 == num)
				{
				}
				num = (short)1990524929;
				if (num != 0)
				{
				}
				num = (short)1517879296;
				if (num != 0)
				{
				}
				this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710.Applicable = value;
			}
		}

		// Token: 0x17001CDC RID: 7388
		// (get) Token: 0x060038B8 RID: 14520 RVA: 0x0035DFC0 File Offset: 0x0035C1C0
		// (set) Token: 0x060038B9 RID: 14521 RVA: 0x0035E074 File Offset: 0x0035C274
		public bool RadWideLabtoolUltraLowPowerSoldierMacCapable_A41710_Valid
		{
			get
			{
				short num = (short)53805056;
				short num2 = num;
				num = (short)655828195;
				short num3 = num;
				num = (short)1563108579;
				switch (num3 == num)
				{
				}
				num = (short)1782579200;
				if (num != 0)
				{
				}
				num = (short)358416385;
				if (num != 0)
				{
				}
				return this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710.Valid;
			}
			set
			{
				short num = (short)397279232;
				short num2 = num;
				num = (short)1355846262;
				short num3 = num;
				num = (short)496996982;
				switch (num3 == num)
				{
				}
				num = (short)780664833;
				if (num != 0)
				{
				}
				num = (short)1933639680;
				if (num != 0)
				{
				}
				this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710.Valid = value;
			}
		}

		// Token: 0x17001CDD RID: 7389
		// (get) Token: 0x060038BA RID: 14522 RVA: 0x0035E12C File Offset: 0x0035C32C
		// (set) Token: 0x060038BB RID: 14523 RVA: 0x0035E1E4 File Offset: 0x0035C3E4
		public bool RadWideLabtoolUltraLowPowerSoldierMacCapable_A41710_Visible
		{
			get
			{
				short num = (short)1832452096;
				short num2 = num;
				num = (short)828452643;
				short num3 = num;
				num = (short)1734291235;
				switch (num3 == num)
				{
				}
				num = (short)220987392;
				if (num != 0)
				{
				}
				num = (short)1118437377;
				if (num != 0)
				{
				}
				return this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710.Visible;
			}
			set
			{
				short num = (short)1444020224;
				short num2 = num;
				num = (short)871235585;
				if (num != 0)
				{
				}
				num = (short)1754148126;
				short num3 = num;
				num = (short)980430110;
				switch (num3 == num)
				{
				}
				num = (short)804061184;
				if (num != 0)
				{
				}
				this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710.Visible = value;
			}
		}

		// Token: 0x17001CDE RID: 7390
		// (get) Token: 0x060038BC RID: 14524 RVA: 0x0035E298 File Offset: 0x0035C498
		// (set) Token: 0x060038BD RID: 14525 RVA: 0x0035E34C File Offset: 0x0035C54C
		public bool RadWideLabtoolUltraLowPowerSoldierMacCapable_A41710_Editable
		{
			get
			{
				short num = (short)759627776;
				short num2 = num;
				num = (short)285708699;
				short num3 = num;
				num = (short)209162651;
				switch (num3 == num)
				{
				}
				num = (short)569573377;
				if (num != 0)
				{
				}
				num = (short)1479213056;
				if (num != 0)
				{
				}
				return this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710.Editable;
			}
			set
			{
				short num = (short)825556992;
				short num2 = num;
				num = (short)86933715;
				short num3 = num;
				num = (short)1112113363;
				switch (num3 == num)
				{
				}
				num = (short)153812993;
				if (num != 0)
				{
				}
				num = (short)215220224;
				if (num != 0)
				{
				}
				this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710.Editable = value;
			}
		}

		// Token: 0x17001CDF RID: 7391
		// (get) Token: 0x060038BE RID: 14526 RVA: 0x0035E404 File Offset: 0x0035C604
		internal string RadWideLabtoolUltraLowPowerSoldierMacCapable_A41710_UILabel
		{
			get
			{
				short num = (short)1007747072;
				short num2 = num;
				num = (short)1792228275;
				short num3 = num;
				num = (short)550386611;
				switch (num3 == num)
				{
				}
				num = (short)1525022721;
				if (num != 0)
				{
				}
				num = (short)1651113984;
				if (num != 0)
				{
				}
				return this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710.UIName;
			}
		}

		// Token: 0x17001CE0 RID: 7392
		// (get) Token: 0x060038BF RID: 14527 RVA: 0x0035E4BC File Offset: 0x0035C6BC
		// (set) Token: 0x060038C0 RID: 14528 RVA: 0x0035E570 File Offset: 0x0035C770
		internal bool RadWideLabtoolUltraLowPowerSoldierMacCapable_A41710_HiddenStatic
		{
			get
			{
				short num = (short)1203109888;
				short num2 = num;
				num = (short)408392632;
				short num3 = num;
				num = (short)1524536248;
				switch (num3 == num)
				{
				}
				num = (short)176357377;
				if (num != 0)
				{
				}
				num = (short)1896415232;
				if (num != 0)
				{
				}
				return this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710.HiddenStatic;
			}
			set
			{
				short num = (short)1190068224;
				short num2 = num;
				num = (short)65562678;
				short num3 = num;
				num = (short)829843510;
				switch (num3 == num)
				{
				}
				num = (short)586547201;
				if (num != 0)
				{
				}
				num = (short)1511325696;
				if (num != 0)
				{
				}
				this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710.HiddenStatic = value;
			}
		}

		// Token: 0x17001CE1 RID: 7393
		// (get) Token: 0x060038C1 RID: 14529 RVA: 0x0035E624 File Offset: 0x0035C824
		// (set) Token: 0x060038C2 RID: 14530 RVA: 0x0035E6DC File Offset: 0x0035C8DC
		internal bool RadWideLabtoolUltraLowPowerSoldierMacCapable_A41710_HiddenDynamic
		{
			get
			{
				short num = (short)453312512;
				short num2 = num;
				num = (short)450560001;
				if (num != 0)
				{
				}
				num = (short)1356766754;
				short num3 = num;
				num = (short)1197514274;
				switch (num3 == num)
				{
				}
				num = (short)1389756416;
				if (num != 0)
				{
				}
				return this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710.HiddenDynamic;
			}
			set
			{
				short num = (short)283770880;
				short num2 = num;
				num = (short)190330885;
				short num3 = num;
				num = (short)1474574341;
				switch (num3 == num)
				{
				}
				num = (short)1679818753;
				if (num != 0)
				{
				}
				num = (short)1069481984;
				if (num != 0)
				{
				}
				this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710.HiddenDynamic = value;
			}
		}

		// Token: 0x17001CE2 RID: 7394
		// (get) Token: 0x060038C3 RID: 14531 RVA: 0x0035E790 File Offset: 0x0035C990
		public bool RadWideLabtoolUltraLowPowerSoldierMacCapable_A41710_HasDiffs
		{
			get
			{
				short num = (short)1300692992;
				short num2 = num;
				num = (short)436609563;
				short num3 = num;
				num = (short)203563547;
				switch (num3 == num)
				{
				}
				num = (short)458096641;
				if (num != 0)
				{
				}
				num = (short)1672282112;
				if (num != 0)
				{
				}
				return this.radWideLabtoolUltraLowPowerSoldierMacCapable_A41710._HasDiffs;
			}
		}

		// Token: 0x17001CE3 RID: 7395
		// (get) Token: 0x060038C4 RID: 14532 RVA: 0x0035E848 File Offset: 0x0035CA48
		// (set) Token: 0x060038C5 RID: 14533 RVA: 0x0035E8FC File Offset: 0x0035CAFC
		public bool RadWideLabtoolEmergencyRevertCapable_A41918Value
		{
			get
			{
				short num = (short)1894842368;
				short num2 = num;
				num = (short)1927925487;
				short num3 = num;
				num = (short)598265583;
				switch (num3 == num)
				{
				}
				num = (short)1643642880;
				if (num != 0)
				{
				}
				num = (short)70647809;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEmergencyRevertCapable_A41918.Value;
			}
			set
			{
				short num = (short)2091778048;
				short num2 = num;
				num = (short)1948516353;
				if (num != 0)
				{
				}
				num = (short)1504493287;
				short num3 = num;
				num = (short)723173095;
				switch (num3 == num)
				{
				}
				num = (short)1110179840;
				if (num != 0)
				{
				}
				this.radWideLabtoolEmergencyRevertCapable_A41918.Value = value;
			}
		}

		// Token: 0x17001CE4 RID: 7396
		// (get) Token: 0x060038C6 RID: 14534 RVA: 0x0035E9B0 File Offset: 0x0035CBB0
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolEmergencyRevertCapable_A41918
		{
			get
			{
				short num = (short)1502871552;
				short num2 = num;
				num = (short)719416425;
				short num3 = num;
				num = (short)1801284713;
				switch (num3 == num)
				{
				}
				num = (short)1303248897;
				if (num != 0)
				{
				}
				num = (short)1033043968;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEmergencyRevertCapable_A41918;
			}
		}

		// Token: 0x17001CE5 RID: 7397
		// (get) Token: 0x060038C7 RID: 14535 RVA: 0x0035EA60 File Offset: 0x0035CC60
		// (set) Token: 0x060038C8 RID: 14536 RVA: 0x0035EB14 File Offset: 0x0035CD14
		public bool RadWideLabtoolEmergencyRevertCapable_A41918_UIValue
		{
			get
			{
				short num = (short)1110114304;
				short num2 = num;
				num = (short)154000823;
				short num3 = num;
				num = (short)1618337207;
				switch (num3 == num)
				{
				}
				num = (short)682557440;
				if (num != 0)
				{
				}
				num = (short)238157825;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEmergencyRevertCapable_A41918.Value;
			}
			set
			{
				short num = (short)985530368;
				short num2 = num;
				num = (short)703352388;
				short num3 = num;
				num = (short)1554337348;
				switch (num3 == num)
				{
				}
				num = (short)1930166273;
				if (num != 0)
				{
				}
				num = (short)1350238208;
				if (num != 0)
				{
				}
				this.radWideLabtoolEmergencyRevertCapable_A41918.Value = value;
			}
		}

		// Token: 0x17001CE6 RID: 7398
		// (get) Token: 0x060038C9 RID: 14537 RVA: 0x0035EBCC File Offset: 0x0035CDCC
		// (set) Token: 0x060038CA RID: 14538 RVA: 0x0035EC80 File Offset: 0x0035CE80
		public bool RadWideLabtoolEmergencyRevertCapable_A41918_Applicable
		{
			get
			{
				short num = (short)351207424;
				short num2 = num;
				num = (short)2011512112;
				short num3 = num;
				num = (short)683687216;
				switch (num3 == num)
				{
				}
				num = (short)992477184;
				if (num != 0)
				{
				}
				num = (short)1780482049;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEmergencyRevertCapable_A41918.Applicable;
			}
			set
			{
				short num = (short)948371456;
				short num2 = num;
				num = (short)450953217;
				if (num != 0)
				{
				}
				num = (short)1487872300;
				short num3 = num;
				num = (short)1850548524;
				switch (num3 == num)
				{
				}
				num = (short)1206124544;
				if (num != 0)
				{
				}
				this.radWideLabtoolEmergencyRevertCapable_A41918.Applicable = value;
			}
		}

		// Token: 0x17001CE7 RID: 7399
		// (get) Token: 0x060038CB RID: 14539 RVA: 0x0035ED38 File Offset: 0x0035CF38
		// (set) Token: 0x060038CC RID: 14540 RVA: 0x0035EDEC File Offset: 0x0035CFEC
		public bool RadWideLabtoolEmergencyRevertCapable_A41918_Valid
		{
			get
			{
				short num = (short)920256512;
				short num2 = num;
				num = (short)720306177;
				if (num != 0)
				{
				}
				num = (short)1269933624;
				short num3 = num;
				num = (short)786212408;
				switch (num3 == num)
				{
				}
				num = (short)362938368;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEmergencyRevertCapable_A41918.Valid;
			}
			set
			{
				short num = (short)916062208;
				short num2 = num;
				num = (short)267190273;
				if (num != 0)
				{
				}
				num = (short)2120191119;
				short num3 = num;
				num = (short)1112312975;
				switch (num3 == num)
				{
				}
				num = (short)503644160;
				if (num != 0)
				{
				}
				this.radWideLabtoolEmergencyRevertCapable_A41918.Valid = value;
			}
		}

		// Token: 0x17001CE8 RID: 7400
		// (get) Token: 0x060038CD RID: 14541 RVA: 0x0035EEA4 File Offset: 0x0035D0A4
		// (set) Token: 0x060038CE RID: 14542 RVA: 0x0035EF58 File Offset: 0x0035D158
		public bool RadWideLabtoolEmergencyRevertCapable_A41918_Visible
		{
			get
			{
				short num = (short)1356312956;
				short num2 = num;
				num = (short)324645244;
				switch (num2 == num)
				{
				}
				num = (short)2139881472;
				if (num != 0)
				{
				}
				num = (short)541196288;
				short num3 = num;
				num = (short)717160449;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEmergencyRevertCapable_A41918.Visible;
			}
			set
			{
				short num = (short)686023108;
				short num2 = num;
				num = (short)1310646724;
				switch (num2 == num)
				{
				}
				num = (short)775946240;
				if (num != 0)
				{
				}
				num = (short)1960378368;
				short num3 = num;
				num = (short)1149632513;
				if (num != 0)
				{
				}
				this.radWideLabtoolEmergencyRevertCapable_A41918.Visible = value;
			}
		}

		// Token: 0x17001CE9 RID: 7401
		// (get) Token: 0x060038CF RID: 14543 RVA: 0x0035F010 File Offset: 0x0035D210
		// (set) Token: 0x060038D0 RID: 14544 RVA: 0x0035F0C8 File Offset: 0x0035D2C8
		public bool RadWideLabtoolEmergencyRevertCapable_A41918_Editable
		{
			get
			{
				short num = (short)1797811025;
				short num2 = num;
				num = (short)1014197073;
				switch (num2 == num)
				{
				}
				num = (short)879362049;
				if (num != 0)
				{
				}
				num = (short)553254912;
				short num3 = num;
				num = (short)659357696;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEmergencyRevertCapable_A41918.Editable;
			}
			set
			{
				short num = (short)147350307;
				short num2 = num;
				num = (short)1874879267;
				switch (num2 == num)
				{
				}
				num = (short)1634926593;
				if (num != 0)
				{
				}
				num = (short)737476608;
				short num3 = num;
				num = (short)1294598144;
				if (num != 0)
				{
				}
				this.radWideLabtoolEmergencyRevertCapable_A41918.Editable = value;
			}
		}

		// Token: 0x17001CEA RID: 7402
		// (get) Token: 0x060038D1 RID: 14545 RVA: 0x0035F180 File Offset: 0x0035D380
		internal string RadWideLabtoolEmergencyRevertCapable_A41918_UILabel
		{
			get
			{
				short num = (short)419842983;
				short num2 = num;
				num = (short)518998951;
				switch (num2 == num)
				{
				}
				num = (short)1218248705;
				if (num != 0)
				{
				}
				num = (short)1943535616;
				short num3 = num;
				num = (short)984612864;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEmergencyRevertCapable_A41918.UIName;
			}
		}

		// Token: 0x17001CEB RID: 7403
		// (get) Token: 0x060038D2 RID: 14546 RVA: 0x0035F234 File Offset: 0x0035D434
		// (set) Token: 0x060038D3 RID: 14547 RVA: 0x0035F2E4 File Offset: 0x0035D4E4
		internal bool RadWideLabtoolEmergencyRevertCapable_A41918_HiddenStatic
		{
			get
			{
				short num = (short)83614247;
				short num2 = num;
				num = (short)1780603431;
				switch (num2 == num)
				{
				}
				num = (short)2052325377;
				if (num != 0)
				{
				}
				num = (short)508297216;
				short num3 = num;
				num = (short)1688993792;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEmergencyRevertCapable_A41918.HiddenStatic;
			}
			set
			{
				short num = (short)1520959489;
				if (num != 0)
				{
				}
				num = (short)1236351429;
				short num2 = num;
				num = (short)1066285509;
				switch (num2 == num)
				{
				}
				num = (short)768344064;
				short num3 = num;
				num = (short)97714176;
				if (num != 0)
				{
				}
				this.radWideLabtoolEmergencyRevertCapable_A41918.HiddenStatic = value;
			}
		}

		// Token: 0x17001CEC RID: 7404
		// (get) Token: 0x060038D4 RID: 14548 RVA: 0x0035F39C File Offset: 0x0035D59C
		// (set) Token: 0x060038D5 RID: 14549 RVA: 0x0035F450 File Offset: 0x0035D650
		internal bool RadWideLabtoolEmergencyRevertCapable_A41918_HiddenDynamic
		{
			get
			{
				short num = (short)338007596;
				short num2 = num;
				num = (short)1895470636;
				switch (num2 == num)
				{
				}
				num = (short)1365442560;
				if (num != 0)
				{
				}
				num = (short)1918500864;
				short num3 = num;
				num = (short)1357053953;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEmergencyRevertCapable_A41918.HiddenDynamic;
			}
			set
			{
				short num = (short)1212612609;
				if (num != 0)
				{
				}
				num = (short)1851737592;
				short num2 = num;
				num = (short)2147042808;
				switch (num2 == num)
				{
				}
				num = (short)1303445504;
				short num3 = num;
				num = (short)1189085184;
				if (num != 0)
				{
				}
				this.radWideLabtoolEmergencyRevertCapable_A41918.HiddenDynamic = value;
			}
		}

		// Token: 0x17001CED RID: 7405
		// (get) Token: 0x060038D6 RID: 14550 RVA: 0x0035F504 File Offset: 0x0035D704
		public bool RadWideLabtoolEmergencyRevertCapable_A41918_HasDiffs
		{
			get
			{
				short num = (short)114706505;
				short num2 = num;
				num = (short)1178093641;
				switch (num2 == num)
				{
				}
				num = (short)1539571712;
				if (num != 0)
				{
				}
				num = (short)975437824;
				short num3 = num;
				num = (short)330104833;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEmergencyRevertCapable_A41918._HasDiffs;
			}
		}

		// Token: 0x17001CEE RID: 7406
		// (get) Token: 0x060038D7 RID: 14551 RVA: 0x0035F5B8 File Offset: 0x0035D7B8
		// (set) Token: 0x060038D8 RID: 14552 RVA: 0x0035F670 File Offset: 0x0035D870
		public bool RadWideLabtoolAudibleBeaconRoutingCapable_A41974Value
		{
			get
			{
				short num = (short)1633530860;
				short num2 = num;
				num = (short)1523758060;
				switch (num2 == num)
				{
				}
				num = (short)619315201;
				if (num != 0)
				{
				}
				num = (short)1848770560;
				short num3 = num;
				num = (short)1983643648;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAudibleBeaconRoutingCapable_A41974.Value;
			}
			set
			{
				short num = (short)294469385;
				short num2 = num;
				num = (short)2020949769;
				switch (num2 == num)
				{
				}
				num = (short)603193344;
				if (num != 0)
				{
				}
				num = (short)1052114944;
				short num3 = num;
				num = (short)1738342401;
				if (num != 0)
				{
				}
				this.radWideLabtoolAudibleBeaconRoutingCapable_A41974.Value = value;
			}
		}

		// Token: 0x17001CEF RID: 7407
		// (get) Token: 0x060038D9 RID: 14553 RVA: 0x0035F728 File Offset: 0x0035D928
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolAudibleBeaconRoutingCapable_A41974
		{
			get
			{
				short num = (short)1244420492;
				short num2 = num;
				num = (short)1499879820;
				switch (num2 == num)
				{
				}
				num = (short)2127626241;
				if (num != 0)
				{
				}
				num = (short)136839168;
				short num3 = num;
				num = (short)672333824;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAudibleBeaconRoutingCapable_A41974;
			}
		}

		// Token: 0x17001CF0 RID: 7408
		// (get) Token: 0x060038DA RID: 14554 RVA: 0x0035F7D8 File Offset: 0x0035D9D8
		// (set) Token: 0x060038DB RID: 14555 RVA: 0x0035F88C File Offset: 0x0035DA8C
		public bool RadWideLabtoolAudibleBeaconRoutingCapable_A41974_UIValue
		{
			get
			{
				short num = (short)1114780639;
				short num2 = num;
				num = (short)1247622111;
				switch (num2 == num)
				{
				}
				num = (short)1101529089;
				if (num != 0)
				{
				}
				num = (short)1648754688;
				short num3 = num;
				num = (short)243793920;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAudibleBeaconRoutingCapable_A41974.Value;
			}
			set
			{
				short num = (short)1260746600;
				short num2 = num;
				num = (short)1545631592;
				switch (num2 == num)
				{
				}
				num = (short)2135818241;
				if (num != 0)
				{
				}
				num = (short)788791296;
				short num3 = num;
				num = (short)730071040;
				if (num != 0)
				{
				}
				this.radWideLabtoolAudibleBeaconRoutingCapable_A41974.Value = value;
			}
		}

		// Token: 0x17001CF1 RID: 7409
		// (get) Token: 0x060038DC RID: 14556 RVA: 0x0035F940 File Offset: 0x0035DB40
		// (set) Token: 0x060038DD RID: 14557 RVA: 0x0035F9F4 File Offset: 0x0035DBF4
		public bool RadWideLabtoolAudibleBeaconRoutingCapable_A41974_Applicable
		{
			get
			{
				short num = (short)209939594;
				short num2 = num;
				num = (short)936602762;
				switch (num2 == num)
				{
				}
				num = (short)1246560257;
				if (num != 0)
				{
				}
				num = (short)335216640;
				short num3 = num;
				num = (short)1358495744;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAudibleBeaconRoutingCapable_A41974.Applicable;
			}
			set
			{
				short num = (short)119501451;
				short num2 = num;
				num = (short)595358347;
				switch (num2 == num)
				{
				}
				num = (short)796196865;
				if (num != 0)
				{
				}
				num = (short)544276480;
				short num3 = num;
				num = (short)1130233856;
				if (num != 0)
				{
				}
				this.radWideLabtoolAudibleBeaconRoutingCapable_A41974.Applicable = value;
			}
		}

		// Token: 0x17001CF2 RID: 7410
		// (get) Token: 0x060038DE RID: 14558 RVA: 0x0035FAA8 File Offset: 0x0035DCA8
		// (set) Token: 0x060038DF RID: 14559 RVA: 0x0035FB5C File Offset: 0x0035DD5C
		public bool RadWideLabtoolAudibleBeaconRoutingCapable_A41974_Valid
		{
			get
			{
				short num = (short)808556662;
				short num2 = num;
				num = (short)1156094070;
				switch (num2 == num)
				{
				}
				num = (short)222953472;
				if (num != 0)
				{
				}
				num = (short)1865613312;
				short num3 = num;
				num = (short)855048193;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAudibleBeaconRoutingCapable_A41974.Valid;
			}
			set
			{
				short num = (short)939599525;
				short num2 = num;
				num = (short)427959973;
				switch (num2 == num)
				{
				}
				num = (short)1639972864;
				if (num != 0)
				{
				}
				num = (short)398589952;
				short num3 = num;
				num = (short)1220804609;
				if (num != 0)
				{
				}
				this.radWideLabtoolAudibleBeaconRoutingCapable_A41974.Valid = value;
			}
		}

		// Token: 0x17001CF3 RID: 7411
		// (get) Token: 0x060038E0 RID: 14560 RVA: 0x0035FC10 File Offset: 0x0035DE10
		// (set) Token: 0x060038E1 RID: 14561 RVA: 0x0035FCC4 File Offset: 0x0035DEC4
		public bool RadWideLabtoolAudibleBeaconRoutingCapable_A41974_Visible
		{
			get
			{
				short num = (short)1363685933;
				short num2 = num;
				num = (short)1971204653;
				switch (num2 == num)
				{
				}
				num = (short)1467940865;
				if (num != 0)
				{
				}
				num = (short)800980992;
				short num3 = num;
				num = (short)950796288;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAudibleBeaconRoutingCapable_A41974.Visible;
			}
			set
			{
				short num = (short)751304734;
				short num2 = num;
				num = (short)1361772574;
				switch (num2 == num)
				{
				}
				num = (short)2004484097;
				if (num != 0)
				{
				}
				num = (short)1437138944;
				short num3 = num;
				num = (short)865861632;
				if (num != 0)
				{
				}
				this.radWideLabtoolAudibleBeaconRoutingCapable_A41974.Visible = value;
			}
		}

		// Token: 0x17001CF4 RID: 7412
		// (get) Token: 0x060038E2 RID: 14562 RVA: 0x0035FD7C File Offset: 0x0035DF7C
		// (set) Token: 0x060038E3 RID: 14563 RVA: 0x0035FE30 File Offset: 0x0035E030
		public bool RadWideLabtoolAudibleBeaconRoutingCapable_A41974_Editable
		{
			get
			{
				short num = (short)1994801511;
				short num2 = num;
				num = (short)1918845287;
				switch (num2 == num)
				{
				}
				num = (short)868483072;
				if (num != 0)
				{
				}
				num = (short)1990393856;
				short num3 = num;
				num = (short)1379926017;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAudibleBeaconRoutingCapable_A41974.Editable;
			}
			set
			{
				short num = (short)1108837685;
				short num2 = num;
				num = (short)957187381;
				switch (num2 == num)
				{
				}
				num = (short)534773761;
				if (num != 0)
				{
				}
				num = (short)1798569984;
				short num3 = num;
				num = (short)405536768;
				if (num != 0)
				{
				}
				this.radWideLabtoolAudibleBeaconRoutingCapable_A41974.Editable = value;
			}
		}

		// Token: 0x17001CF5 RID: 7413
		// (get) Token: 0x060038E4 RID: 14564 RVA: 0x0035FEE8 File Offset: 0x0035E0E8
		internal string RadWideLabtoolAudibleBeaconRoutingCapable_A41974_UILabel
		{
			get
			{
				short num = (short)464437121;
				short num2 = num;
				num = (short)1574027137;
				switch (num2 == num)
				{
				}
				num = (short)1188102144;
				if (num != 0)
				{
				}
				num = (short)1391198208;
				short num3 = num;
				num = (short)2061697025;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAudibleBeaconRoutingCapable_A41974.UIName;
			}
		}

		// Token: 0x17001CF6 RID: 7414
		// (get) Token: 0x060038E5 RID: 14565 RVA: 0x0035FF9C File Offset: 0x0035E19C
		// (set) Token: 0x060038E6 RID: 14566 RVA: 0x00360050 File Offset: 0x0035E250
		internal bool RadWideLabtoolAudibleBeaconRoutingCapable_A41974_HiddenStatic
		{
			get
			{
				short num = (short)1180854279;
				short num2 = num;
				num = (short)866805767;
				switch (num2 == num)
				{
				}
				num = (short)707788801;
				if (num != 0)
				{
				}
				num = (short)200146944;
				short num3 = num;
				num = (short)1866399744;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAudibleBeaconRoutingCapable_A41974.HiddenStatic;
			}
			set
			{
				short num = (short)796459009;
				if (num != 0)
				{
				}
				num = (short)1870593111;
				short num2 = num;
				num = (short)1467350103;
				switch (num2 == num)
				{
				}
				num = (short)429719552;
				short num3 = num;
				num = (short)1295384576;
				if (num != 0)
				{
				}
				this.radWideLabtoolAudibleBeaconRoutingCapable_A41974.HiddenStatic = value;
			}
		}

		// Token: 0x17001CF7 RID: 7415
		// (get) Token: 0x060038E7 RID: 14567 RVA: 0x00360104 File Offset: 0x0035E304
		// (set) Token: 0x060038E8 RID: 14568 RVA: 0x003601B8 File Offset: 0x0035E3B8
		internal bool RadWideLabtoolAudibleBeaconRoutingCapable_A41974_HiddenDynamic
		{
			get
			{
				short num = (short)1270075960;
				short num2 = num;
				num = (short)436916792;
				switch (num2 == num)
				{
				}
				num = (short)1374814209;
				if (num != 0)
				{
				}
				num = (short)122814464;
				short num3 = num;
				num = (short)1390215168;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAudibleBeaconRoutingCapable_A41974.HiddenDynamic;
			}
			set
			{
				short num = (short)1478661823;
				short num2 = num;
				num = (short)663525055;
				switch (num2 == num)
				{
				}
				num = (short)1799356416;
				if (num != 0)
				{
				}
				num = (short)238354432;
				short num3 = num;
				num = (short)927203329;
				if (num != 0)
				{
				}
				this.radWideLabtoolAudibleBeaconRoutingCapable_A41974.HiddenDynamic = value;
			}
		}

		// Token: 0x17001CF8 RID: 7416
		// (get) Token: 0x060038E9 RID: 14569 RVA: 0x0036026C File Offset: 0x0035E46C
		public bool RadWideLabtoolAudibleBeaconRoutingCapable_A41974_HasDiffs
		{
			get
			{
				short num = (short)1536753665;
				if (num != 0)
				{
				}
				num = (short)1601126704;
				short num2 = num;
				num = (short)1672036656;
				switch (num2 == num)
				{
				}
				num = (short)1158610944;
				short num3 = num;
				num = (short)948371456;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAudibleBeaconRoutingCapable_A41974._HasDiffs;
			}
		}

		// Token: 0x17001CF9 RID: 7417
		// (get) Token: 0x060038EA RID: 14570 RVA: 0x00360320 File Offset: 0x0035E520
		// (set) Token: 0x060038EB RID: 14571 RVA: 0x003603D4 File Offset: 0x0035E5D4
		public bool ManDownPersonalityConfigurableCapable_42082Value
		{
			get
			{
				short num = (short)87371261;
				short num2 = num;
				num = (short)1282878973;
				switch (num2 == num)
				{
				}
				num = (short)1943732225;
				if (num != 0)
				{
				}
				num = (short)574488576;
				short num3 = num;
				num = (short)1745354752;
				if (num != 0)
				{
				}
				return this.manDownPersonalityConfigurableCapable_42082.Value;
			}
			set
			{
				short num = (short)451477505;
				if (num != 0)
				{
				}
				num = (short)996498938;
				short num2 = num;
				num = (short)1609391610;
				switch (num2 == num)
				{
				}
				num = (short)1005780992;
				short num3 = num;
				num = (short)787939328;
				if (num != 0)
				{
				}
				this.manDownPersonalityConfigurableCapable_42082.Value = value;
			}
		}

		// Token: 0x17001CFA RID: 7418
		// (get) Token: 0x060038EC RID: 14572 RVA: 0x00360488 File Offset: 0x0035E688
		public global::AcpBusinessLayer.AcpField<bool> ManDownPersonalityConfigurableCapable_42082
		{
			get
			{
				short num = (short)1968167043;
				short num2 = num;
				num = (short)689952899;
				switch (num2 == num)
				{
				}
				num = (short)863109121;
				if (num != 0)
				{
				}
				num = (short)318439424;
				short num3 = num;
				num = (short)1256194048;
				if (num != 0)
				{
				}
				return this.manDownPersonalityConfigurableCapable_42082;
			}
		}

		// Token: 0x17001CFB RID: 7419
		// (get) Token: 0x060038ED RID: 14573 RVA: 0x00360534 File Offset: 0x0035E734
		// (set) Token: 0x060038EE RID: 14574 RVA: 0x003605E8 File Offset: 0x0035E7E8
		public bool ManDownPersonalityConfigurableCapable_42082_UIValue
		{
			get
			{
				short num = (short)439518882;
				short num2 = num;
				num = (short)1288668834;
				switch (num2 == num)
				{
				}
				num = (short)1075970049;
				if (num != 0)
				{
				}
				num = (short)535756800;
				short num3 = num;
				num = (short)422772736;
				if (num != 0)
				{
				}
				return this.manDownPersonalityConfigurableCapable_42082.Value;
			}
			set
			{
				short num = (short)420974966;
				short num2 = num;
				num = (short)948408694;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1700921344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)150536193;
				if (num != 0)
				{
				}
				num = (short)1025376256;
				if (num != 0)
				{
				}
				this.manDownPersonalityConfigurableCapable_42082.Value = value;
			}
		}

		// Token: 0x17001CFC RID: 7420
		// (get) Token: 0x060038EF RID: 14575 RVA: 0x0036069C File Offset: 0x0035E89C
		// (set) Token: 0x060038F0 RID: 14576 RVA: 0x00360750 File Offset: 0x0035E950
		public bool ManDownPersonalityConfigurableCapable_42082_Applicable
		{
			get
			{
				short num = (short)128778241;
				if (num != 0)
				{
				}
				num = (short)1245708288;
				short num2 = num;
				num = (short)30110567;
				short num3 = num;
				num = (short)1149006695;
				switch (num3 == num)
				{
				}
				num = (short)1378549760;
				if (num != 0)
				{
				}
				return this.manDownPersonalityConfigurableCapable_42082.Applicable;
			}
			set
			{
				short num = (short)1085190321;
				short num2 = num;
				num = (short)1608757425;
				switch (num2 == num)
				{
				default:
				{
					num = (short)954138624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1275265025;
				if (num != 0)
				{
				}
				num = (short)1551826944;
				if (num != 0)
				{
				}
				this.manDownPersonalityConfigurableCapable_42082.Applicable = value;
			}
		}

		// Token: 0x17001CFD RID: 7421
		// (get) Token: 0x060038F1 RID: 14577 RVA: 0x00360808 File Offset: 0x0035EA08
		// (set) Token: 0x060038F2 RID: 14578 RVA: 0x003608BC File Offset: 0x0035EABC
		public bool ManDownPersonalityConfigurableCapable_42082_Valid
		{
			get
			{
				short num = (short)335791058;
				short num2 = num;
				num = (short)217564114;
				switch (num2 == num)
				{
				default:
				{
					num = (short)492830720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1071185921;
				if (num != 0)
				{
				}
				num = (short)1315504128;
				if (num != 0)
				{
				}
				return this.manDownPersonalityConfigurableCapable_42082.Valid;
			}
			set
			{
				short num = (short)1077201403;
				short num2 = num;
				num = (short)1735903739;
				switch (num2 == num)
				{
				default:
				{
					num = (short)401604608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1899757569;
				if (num != 0)
				{
				}
				num = (short)351535104;
				if (num != 0)
				{
				}
				this.manDownPersonalityConfigurableCapable_42082.Valid = value;
			}
		}

		// Token: 0x17001CFE RID: 7422
		// (get) Token: 0x060038F3 RID: 14579 RVA: 0x00360970 File Offset: 0x0035EB70
		// (set) Token: 0x060038F4 RID: 14580 RVA: 0x00360A24 File Offset: 0x0035EC24
		public bool ManDownPersonalityConfigurableCapable_42082_Visible
		{
			get
			{
				short num = (short)1675249140;
				short num2 = num;
				num = (short)769672692;
				switch (num2 == num)
				{
				default:
				{
					num = (short)168558592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1039794177;
				if (num != 0)
				{
				}
				num = (short)562823168;
				if (num != 0)
				{
				}
				return this.manDownPersonalityConfigurableCapable_42082.Visible;
			}
			set
			{
				short num = (short)989177516;
				short num2 = num;
				num = (short)2088478380;
				switch (num2 == num)
				{
				default:
				{
					num = (short)958070784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1418854400;
				if (num != 0)
				{
				}
				num = (short)364314625;
				if (num != 0)
				{
				}
				this.manDownPersonalityConfigurableCapable_42082.Visible = value;
			}
		}

		// Token: 0x17001CFF RID: 7423
		// (get) Token: 0x060038F5 RID: 14581 RVA: 0x00360AD8 File Offset: 0x0035ECD8
		// (set) Token: 0x060038F6 RID: 14582 RVA: 0x00360B8C File Offset: 0x0035ED8C
		public bool ManDownPersonalityConfigurableCapable_42082_Editable
		{
			get
			{
				short num = (short)1519518189;
				short num2 = num;
				num = (short)677052909;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1076953088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)950206465;
				if (num != 0)
				{
				}
				num = (short)611057664;
				if (num != 0)
				{
				}
				return this.manDownPersonalityConfigurableCapable_42082.Editable;
			}
			set
			{
				short num = (short)1629945228;
				short num2 = num;
				num = (short)1615134092;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1460862976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)721092609;
				if (num != 0)
				{
				}
				num = (short)693633024;
				if (num != 0)
				{
				}
				this.manDownPersonalityConfigurableCapable_42082.Editable = value;
			}
		}

		// Token: 0x17001D00 RID: 7424
		// (get) Token: 0x060038F7 RID: 14583 RVA: 0x00360C40 File Offset: 0x0035EE40
		internal string ManDownPersonalityConfigurableCapable_42082_UILabel
		{
			get
			{
				short num = (short)889528893;
				short num2 = num;
				num = (short)1873748541;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1900544000;
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
				num = (short)1791098880;
				if (num != 0)
				{
				}
				return this.manDownPersonalityConfigurableCapable_42082.UIName;
			}
		}

		// Token: 0x17001D01 RID: 7425
		// (get) Token: 0x060038F8 RID: 14584 RVA: 0x00360CF4 File Offset: 0x0035EEF4
		// (set) Token: 0x060038F9 RID: 14585 RVA: 0x00360DA8 File Offset: 0x0035EFA8
		internal bool ManDownPersonalityConfigurableCapable_42082_HiddenStatic
		{
			get
			{
				short num = (short)443176408;
				short num2 = num;
				num = (short)251614680;
				switch (num2 == num)
				{
				default:
				{
					num = (short)734003200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1303183361;
				if (num != 0)
				{
				}
				num = (short)1457913856;
				if (num != 0)
				{
				}
				return this.manDownPersonalityConfigurableCapable_42082.HiddenStatic;
			}
			set
			{
				short num = (short)1158513689;
				short num2 = num;
				num = (short)1087276057;
				switch (num2 == num)
				{
				default:
				{
					num = (short)930676736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)653131777;
				if (num != 0)
				{
				}
				num = (short)1716715520;
				if (num != 0)
				{
				}
				this.manDownPersonalityConfigurableCapable_42082.HiddenStatic = value;
			}
		}

		// Token: 0x17001D02 RID: 7426
		// (get) Token: 0x060038FA RID: 14586 RVA: 0x00360E60 File Offset: 0x0035F060
		// (set) Token: 0x060038FB RID: 14587 RVA: 0x00360F14 File Offset: 0x0035F114
		internal bool ManDownPersonalityConfigurableCapable_42082_HiddenDynamic
		{
			get
			{
				short num = (short)87614225;
				short num2 = num;
				num = (short)568845073;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1461256192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2042232832;
				if (num != 0)
				{
				}
				num = (short)174194689;
				if (num != 0)
				{
				}
				return this.manDownPersonalityConfigurableCapable_42082.HiddenDynamic;
			}
			set
			{
				short num = (short)1021343075;
				short num2 = num;
				num = (short)306083171;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1847787520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1122107393;
				if (num != 0)
				{
				}
				num = (short)1768423424;
				if (num != 0)
				{
				}
				this.manDownPersonalityConfigurableCapable_42082.HiddenDynamic = value;
			}
		}

		// Token: 0x17001D03 RID: 7427
		// (get) Token: 0x060038FC RID: 14588 RVA: 0x00360FCC File Offset: 0x0035F1CC
		public bool ManDownPersonalityConfigurableCapable_42082_HasDiffs
		{
			get
			{
				short num = (short)421825288;
				short num2 = num;
				num = (short)1396149000;
				switch (num2 == num)
				{
				default:
				{
					num = (short)496369664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)819986433;
				if (num != 0)
				{
				}
				num = (short)699269120;
				if (num != 0)
				{
				}
				return this.manDownPersonalityConfigurableCapable_42082._HasDiffs;
			}
		}

		// Token: 0x17001D04 RID: 7428
		// (get) Token: 0x060038FD RID: 14589 RVA: 0x00361080 File Offset: 0x0035F280
		// (set) Token: 0x060038FE RID: 14590 RVA: 0x00361134 File Offset: 0x0035F334
		public bool ToneEmergencyConfigurableCapable_42083Value
		{
			get
			{
				short num = (short)1443362049;
				short num2 = num;
				num = (short)1313797377;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1686503424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)171114497;
				if (num != 0)
				{
				}
				num = (short)1562968064;
				if (num != 0)
				{
				}
				return this.toneEmergencyConfigurableCapable_42083.Value;
			}
			set
			{
				short num = (short)715288876;
				short num2 = num;
				num = (short)988442924;
				switch (num2 == num)
				{
				default:
				{
					num = (short)377946112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)319225857;
				if (num != 0)
				{
				}
				num = (short)1561657344;
				if (num != 0)
				{
				}
				this.toneEmergencyConfigurableCapable_42083.Value = value;
			}
		}

		// Token: 0x17001D05 RID: 7429
		// (get) Token: 0x060038FF RID: 14591 RVA: 0x003611E8 File Offset: 0x0035F3E8
		public global::AcpBusinessLayer.AcpField<bool> ToneEmergencyConfigurableCapable_42083
		{
			get
			{
				short num = (short)759552953;
				short num2 = num;
				num = (short)679926713;
				switch (num2 == num)
				{
				default:
				{
					num = (short)487129088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)427884545;
				if (num != 0)
				{
				}
				num = (short)1164247040;
				if (num != 0)
				{
				}
				return this.toneEmergencyConfigurableCapable_42083;
			}
		}

		// Token: 0x17001D06 RID: 7430
		// (get) Token: 0x06003900 RID: 14592 RVA: 0x00361298 File Offset: 0x0035F498
		// (set) Token: 0x06003901 RID: 14593 RVA: 0x0036134C File Offset: 0x0035F54C
		public bool ToneEmergencyConfigurableCapable_42083_UIValue
		{
			get
			{
				short num = (short)176947201;
				if (num != 0)
				{
				}
				num = (short)967835648;
				short num2 = num;
				num = (short)1085449401;
				short num3 = num;
				num = (short)139764921;
				switch (num3 == num)
				{
				}
				num = (short)182321152;
				if (num != 0)
				{
				}
				return this.toneEmergencyConfigurableCapable_42083.Value;
			}
			set
			{
				short num = (short)1069873798;
				short num2 = num;
				num = (short)458750598;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1231486976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1232207873;
				if (num != 0)
				{
				}
				num = (short)1446510592;
				if (num != 0)
				{
				}
				this.toneEmergencyConfigurableCapable_42083.Value = value;
			}
		}

		// Token: 0x17001D07 RID: 7431
		// (get) Token: 0x06003902 RID: 14594 RVA: 0x00361404 File Offset: 0x0035F604
		// (set) Token: 0x06003903 RID: 14595 RVA: 0x003614B8 File Offset: 0x0035F6B8
		public bool ToneEmergencyConfigurableCapable_42083_Applicable
		{
			get
			{
				short num = (short)1956672522;
				short num2 = num;
				num = (short)1714254858;
				switch (num2 == num)
				{
				default:
				{
					num = (short)178454528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2105081857;
				if (num != 0)
				{
				}
				num = (short)16908288;
				if (num != 0)
				{
				}
				return this.toneEmergencyConfigurableCapable_42083.Applicable;
			}
			set
			{
				short num = (short)743541872;
				short num2 = num;
				num = (short)1754696816;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2016411648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)585564161;
				if (num != 0)
				{
				}
				num = (short)932184064;
				if (num != 0)
				{
				}
				this.toneEmergencyConfigurableCapable_42083.Applicable = value;
			}
		}

		// Token: 0x17001D08 RID: 7432
		// (get) Token: 0x06003904 RID: 14596 RVA: 0x0036156C File Offset: 0x0035F76C
		// (set) Token: 0x06003905 RID: 14597 RVA: 0x00361624 File Offset: 0x0035F824
		public bool ToneEmergencyConfigurableCapable_42083_Valid
		{
			get
			{
				short num = (short)1556836372;
				short num2 = num;
				num = (short)49180692;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1287979008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1722351617;
				if (num != 0)
				{
				}
				num = (short)135266304;
				if (num != 0)
				{
				}
				return this.toneEmergencyConfigurableCapable_42083.Valid;
			}
			set
			{
				short num = (short)2107726990;
				short num2 = num;
				num = (short)1588550798;
				switch (num2 == num)
				{
				default:
				{
					num = (short)587923456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)164102145;
				if (num != 0)
				{
				}
				num = (short)1939275776;
				if (num != 0)
				{
				}
				this.toneEmergencyConfigurableCapable_42083.Valid = value;
			}
		}

		// Token: 0x17001D09 RID: 7433
		// (get) Token: 0x06003906 RID: 14598 RVA: 0x003616D8 File Offset: 0x0035F8D8
		// (set) Token: 0x06003907 RID: 14599 RVA: 0x0036178C File Offset: 0x0035F98C
		public bool ToneEmergencyConfigurableCapable_42083_Visible
		{
			get
			{
				short num = (short)1456450511;
				short num2 = num;
				num = (short)1692249039;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1584726016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)536346625;
				if (num != 0)
				{
				}
				num = (short)1284636672;
				if (num != 0)
				{
				}
				return this.toneEmergencyConfigurableCapable_42083.Visible;
			}
			set
			{
				short num = (short)1829044225;
				if (num != 0)
				{
				}
				num = (short)159907840;
				short num2 = num;
				num = (short)336132891;
				short num3 = num;
				num = (short)426834715;
				switch (num3 == num)
				{
				}
				num = (short)483983360;
				if (num != 0)
				{
				}
				this.toneEmergencyConfigurableCapable_42083.Visible = value;
			}
		}

		// Token: 0x17001D0A RID: 7434
		// (get) Token: 0x06003908 RID: 14600 RVA: 0x00361844 File Offset: 0x0035FA44
		// (set) Token: 0x06003909 RID: 14601 RVA: 0x003618F8 File Offset: 0x0035FAF8
		public bool ToneEmergencyConfigurableCapable_42083_Editable
		{
			get
			{
				short num = (short)1253527376;
				short num2 = num;
				num = (short)964513616;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1757085696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)871104513;
				if (num != 0)
				{
				}
				num = (short)190382080;
				if (num != 0)
				{
				}
				return this.toneEmergencyConfigurableCapable_42083.Editable;
			}
			set
			{
				short num = (short)1733036014;
				short num2 = num;
				num = (short)1687291886;
				switch (num2 == num)
				{
				default:
				{
					num = (short)31981568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)335282176;
				if (num != 0)
				{
				}
				num = (short)1380319233;
				if (num != 0)
				{
				}
				this.toneEmergencyConfigurableCapable_42083.Editable = value;
			}
		}

		// Token: 0x17001D0B RID: 7435
		// (get) Token: 0x0600390A RID: 14602 RVA: 0x003619B0 File Offset: 0x0035FBB0
		internal string ToneEmergencyConfigurableCapable_42083_UILabel
		{
			get
			{
				short num = (short)1977393926;
				short num2 = num;
				num = (short)1523622662;
				switch (num2 == num)
				{
				default:
				{
					num = (short)241631232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1915617281;
				if (num != 0)
				{
				}
				num = (short)201392128;
				if (num != 0)
				{
				}
				return this.toneEmergencyConfigurableCapable_42083.UIName;
			}
		}

		// Token: 0x17001D0C RID: 7436
		// (get) Token: 0x0600390B RID: 14603 RVA: 0x00361A64 File Offset: 0x0035FC64
		// (set) Token: 0x0600390C RID: 14604 RVA: 0x00361B18 File Offset: 0x0035FD18
		internal bool ToneEmergencyConfigurableCapable_42083_HiddenStatic
		{
			get
			{
				short num = (short)494884092;
				short num2 = num;
				num = (short)1291080956;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1511522304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1400504321;
				if (num != 0)
				{
				}
				num = (short)1089077248;
				if (num != 0)
				{
				}
				return this.toneEmergencyConfigurableCapable_42083.HiddenStatic;
			}
			set
			{
				short num = (short)1279727611;
				short num2 = num;
				num = (short)712513531;
				switch (num2 == num)
				{
				default:
				{
					num = (short)258211840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)591462401;
				if (num != 0)
				{
				}
				num = (short)397213696;
				if (num != 0)
				{
				}
				this.toneEmergencyConfigurableCapable_42083.HiddenStatic = value;
			}
		}

		// Token: 0x17001D0D RID: 7437
		// (get) Token: 0x0600390D RID: 14605 RVA: 0x00361BCC File Offset: 0x0035FDCC
		// (set) Token: 0x0600390E RID: 14606 RVA: 0x00361C84 File Offset: 0x0035FE84
		internal bool ToneEmergencyConfigurableCapable_42083_HiddenDynamic
		{
			get
			{
				short num = (short)243067471;
				short num2 = num;
				num = (short)1674897999;
				switch (num2 == num)
				{
				default:
				{
					num = (short)469696512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)212860928;
				if (num != 0)
				{
				}
				num = (short)1700790273;
				if (num != 0)
				{
				}
				return this.toneEmergencyConfigurableCapable_42083.HiddenDynamic;
			}
			set
			{
				short num = (short)1129962344;
				short num2 = num;
				num = (short)1613028200;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1171849216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1871970304;
				if (num != 0)
				{
				}
				num = (short)840761345;
				if (num != 0)
				{
				}
				this.toneEmergencyConfigurableCapable_42083.HiddenDynamic = value;
			}
		}

		// Token: 0x17001D0E RID: 7438
		// (get) Token: 0x0600390F RID: 14607 RVA: 0x00361D3C File Offset: 0x0035FF3C
		public bool ToneEmergencyConfigurableCapable_42083_HasDiffs
		{
			get
			{
				short num = (short)497858663;
				short num2 = num;
				num = (short)1778038887;
				switch (num2 == num)
				{
				default:
				{
					num = (short)722337792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1979187201;
				if (num != 0)
				{
				}
				num = (short)777388032;
				if (num != 0)
				{
				}
				return this.toneEmergencyConfigurableCapable_42083._HasDiffs;
			}
		}

		// Token: 0x17001D0F RID: 7439
		// (get) Token: 0x06003910 RID: 14608 RVA: 0x00361DF0 File Offset: 0x0035FFF0
		// (set) Token: 0x06003911 RID: 14609 RVA: 0x00361EA8 File Offset: 0x003600A8
		public bool RadWideLabtoolAPX6000P25Radio_A42121Value
		{
			get
			{
				short num = (short)563333141;
				short num2 = num;
				num = (short)887277589;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1974861824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1661206529;
				if (num != 0)
				{
				}
				num = (short)1688010752;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAPX6000P25Radio_A42121.Value;
			}
			set
			{
				short num = (short)1670430840;
				short num2 = num;
				num = (short)1885913208;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1913978880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)396427265;
				if (num != 0)
				{
				}
				num = (short)282525696;
				if (num != 0)
				{
				}
				this.radWideLabtoolAPX6000P25Radio_A42121.Value = value;
			}
		}

		// Token: 0x17001D10 RID: 7440
		// (get) Token: 0x06003912 RID: 14610 RVA: 0x00361F60 File Offset: 0x00360160
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolAPX6000P25Radio_A42121
		{
			get
			{
				short num = (short)1422050998;
				short num2 = num;
				num = (short)815842998;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1598423040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1402077184;
				if (num != 0)
				{
				}
				num = (short)1623719937;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAPX6000P25Radio_A42121;
			}
		}

		// Token: 0x17001D11 RID: 7441
		// (get) Token: 0x06003913 RID: 14611 RVA: 0x00362010 File Offset: 0x00360210
		// (set) Token: 0x06003914 RID: 14612 RVA: 0x003620C8 File Offset: 0x003602C8
		public bool RadWideLabtoolAPX6000P25Radio_A42121_UIValue
		{
			get
			{
				short num = (short)1510320312;
				short num2 = num;
				num = (short)125937848;
				switch (num2 == num)
				{
				default:
				{
					num = (short)325517312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1927479297;
				if (num != 0)
				{
				}
				num = (short)204603392;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAPX6000P25Radio_A42121.Value;
			}
			set
			{
				short num = (short)365209743;
				short num2 = num;
				num = (short)1983883407;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1474756608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1440022529;
				if (num != 0)
				{
				}
				num = (short)1770127360;
				if (num != 0)
				{
				}
				this.radWideLabtoolAPX6000P25Radio_A42121.Value = value;
			}
		}

		// Token: 0x17001D12 RID: 7442
		// (get) Token: 0x06003915 RID: 14613 RVA: 0x0036217C File Offset: 0x0036037C
		// (set) Token: 0x06003916 RID: 14614 RVA: 0x00362238 File Offset: 0x00360438
		public bool RadWideLabtoolAPX6000P25Radio_A42121_Applicable
		{
			get
			{
				short num = (short)1899582082;
				short num2 = num;
				num = (short)1583501954;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1046413312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1783365633;
				if (num != 0)
				{
				}
				num = (short)1834680320;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAPX6000P25Radio_A42121.Applicable;
			}
			set
			{
				short num = (short)1763540985;
				short num2 = num;
				num = (short)1960935417;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1833828352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2141257728;
				if (num != 0)
				{
				}
				num = (short)2059272193;
				if (num != 0)
				{
				}
				this.radWideLabtoolAPX6000P25Radio_A42121.Applicable = value;
			}
		}

		// Token: 0x17001D13 RID: 7443
		// (get) Token: 0x06003917 RID: 14615 RVA: 0x003622EC File Offset: 0x003604EC
		// (set) Token: 0x06003918 RID: 14616 RVA: 0x003623A0 File Offset: 0x003605A0
		public bool RadWideLabtoolAPX6000P25Radio_A42121_Valid
		{
			get
			{
				short num = (short)1225863232;
				short num2 = num;
				num = (short)826683456;
				switch (num2 == num)
				{
				default:
				{
					num = (short)585039872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)714276865;
				if (num != 0)
				{
				}
				num = (short)41418752;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAPX6000P25Radio_A42121.Valid;
			}
			set
			{
				short num = (short)669843457;
				if (num != 0)
				{
				}
				num = (short)2053832704;
				short num2 = num;
				num = (short)1392444050;
				short num3 = num;
				num = (short)2025980562;
				switch (num3 == num)
				{
				}
				num = (short)1322582016;
				if (num != 0)
				{
				}
				this.radWideLabtoolAPX6000P25Radio_A42121.Valid = value;
			}
		}

		// Token: 0x17001D14 RID: 7444
		// (get) Token: 0x06003919 RID: 14617 RVA: 0x00362458 File Offset: 0x00360658
		// (set) Token: 0x0600391A RID: 14618 RVA: 0x0036250C File Offset: 0x0036070C
		public bool RadWideLabtoolAPX6000P25Radio_A42121_Visible
		{
			get
			{
				short num = (short)1780358954;
				short num2 = num;
				num = (short)1795563306;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1703739392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)912719873;
				if (num != 0)
				{
				}
				num = (short)1130430464;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAPX6000P25Radio_A42121.Visible;
			}
			set
			{
				short num = (short)344207197;
				short num2 = num;
				num = (short)876097373;
				switch (num2 == num)
				{
				default:
				{
					num = (short)802684928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1450246145;
				if (num != 0)
				{
				}
				num = (short)1118699520;
				if (num != 0)
				{
				}
				this.radWideLabtoolAPX6000P25Radio_A42121.Visible = value;
			}
		}

		// Token: 0x17001D15 RID: 7445
		// (get) Token: 0x0600391B RID: 14619 RVA: 0x003625C0 File Offset: 0x003607C0
		// (set) Token: 0x0600391C RID: 14620 RVA: 0x00362674 File Offset: 0x00360874
		public bool RadWideLabtoolAPX6000P25Radio_A42121_Editable
		{
			get
			{
				short num = (short)1957641064;
				short num2 = num;
				num = (short)1782266728;
				switch (num2 == num)
				{
				default:
				{
					num = (short)66256896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)520880129;
				if (num != 0)
				{
				}
				num = (short)426967040;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAPX6000P25Radio_A42121.Editable;
			}
			set
			{
				short num = (short)3572981;
				short num2 = num;
				num = (short)549094645;
				switch (num2 == num)
				{
				default:
				{
					num = (short)625213440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)826605568;
				if (num != 0)
				{
				}
				num = (short)2050621441;
				if (num != 0)
				{
				}
				this.radWideLabtoolAPX6000P25Radio_A42121.Editable = value;
			}
		}

		// Token: 0x17001D16 RID: 7446
		// (get) Token: 0x0600391D RID: 14621 RVA: 0x00362728 File Offset: 0x00360928
		internal string RadWideLabtoolAPX6000P25Radio_A42121_UILabel
		{
			get
			{
				short num = (short)518948596;
				short num2 = num;
				num = (short)1152943860;
				switch (num2 == num)
				{
				default:
				{
					num = (short)953090048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1057161216;
				if (num != 0)
				{
				}
				num = (short)1369309185;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAPX6000P25Radio_A42121.UIName;
			}
		}

		// Token: 0x17001D17 RID: 7447
		// (get) Token: 0x0600391E RID: 14622 RVA: 0x003627D8 File Offset: 0x003609D8
		// (set) Token: 0x0600391F RID: 14623 RVA: 0x00362890 File Offset: 0x00360A90
		internal bool RadWideLabtoolAPX6000P25Radio_A42121_HiddenStatic
		{
			get
			{
				short num = (short)2146322224;
				short num2 = num;
				num = (short)1999062832;
				switch (num2 == num)
				{
				}
				num = (short)426967041;
				if (num != 0)
				{
				}
				num = (short)538902528;
				if (num != 0)
				{
				}
				num = (short)1829765120;
				short num3 = num;
				return this.radWideLabtoolAPX6000P25Radio_A42121.HiddenStatic;
			}
			set
			{
				short num = (short)2042077629;
				short num2 = num;
				num = (short)1524670909;
				switch (num2 == num)
				{
				}
				num = (short)1638727681;
				if (num != 0)
				{
				}
				num = (short)1305018368;
				if (num != 0)
				{
				}
				num = (short)488964096;
				short num3 = num;
				this.radWideLabtoolAPX6000P25Radio_A42121.HiddenStatic = value;
			}
		}

		// Token: 0x17001D18 RID: 7448
		// (get) Token: 0x06003920 RID: 14624 RVA: 0x00362944 File Offset: 0x00360B44
		// (set) Token: 0x06003921 RID: 14625 RVA: 0x003629FC File Offset: 0x00360BFC
		internal bool RadWideLabtoolAPX6000P25Radio_A42121_HiddenDynamic
		{
			get
			{
				short num = (short)1056559107;
				short num2 = num;
				num = (short)1645727747;
				switch (num2 == num)
				{
				}
				num = (short)401801217;
				if (num != 0)
				{
				}
				num = (short)1368326144;
				if (num != 0)
				{
				}
				num = (short)1442906112;
				short num3 = num;
				return this.radWideLabtoolAPX6000P25Radio_A42121.HiddenDynamic;
			}
			set
			{
				short num = (short)1190744644;
				short num2 = num;
				num = (short)602952260;
				switch (num2 == num)
				{
				}
				num = (short)488964097;
				if (num != 0)
				{
				}
				num = (short)325124096;
				if (num != 0)
				{
				}
				num = (short)1587019776;
				short num3 = num;
				this.radWideLabtoolAPX6000P25Radio_A42121.HiddenDynamic = value;
			}
		}

		// Token: 0x17001D19 RID: 7449
		// (get) Token: 0x06003922 RID: 14626 RVA: 0x00362AB0 File Offset: 0x00360CB0
		public bool RadWideLabtoolAPX6000P25Radio_A42121_HasDiffs
		{
			get
			{
				short num = (short)744816641;
				if (num != 0)
				{
				}
				num = (short)1517730112;
				short num2 = num;
				num = (short)1455864128;
				switch (num2 == num)
				{
				}
				num = (short)741736448;
				if (num != 0)
				{
				}
				num = (short)632684544;
				short num3 = num;
				return this.radWideLabtoolAPX6000P25Radio_A42121._HasDiffs;
			}
		}

		// Token: 0x17001D1A RID: 7450
		// (get) Token: 0x06003923 RID: 14627 RVA: 0x00362B64 File Offset: 0x00360D64
		// (set) Token: 0x06003924 RID: 14628 RVA: 0x00362C18 File Offset: 0x00360E18
		public bool RadWideLabtoolSuppressEmergencyCallCapability_A42143Value
		{
			get
			{
				short num = (short)315350525;
				short num2 = num;
				num = (short)1742921213;
				switch (num2 == num)
				{
				}
				num = (short)1998192641;
				if (num != 0)
				{
				}
				num = (short)1425735680;
				if (num != 0)
				{
				}
				num = (short)459472896;
				short num3 = num;
				return this.radWideLabtoolSuppressEmergencyCallCapability_A42143.Value;
			}
			set
			{
				short num = (short)470815384;
				short num2 = num;
				num = (short)1757024920;
				switch (num2 == num)
				{
				}
				num = (short)1781792768;
				if (num != 0)
				{
				}
				num = (short)1194393601;
				if (num != 0)
				{
				}
				num = (short)453443584;
				short num3 = num;
				this.radWideLabtoolSuppressEmergencyCallCapability_A42143.Value = value;
			}
		}

		// Token: 0x17001D1B RID: 7451
		// (get) Token: 0x06003925 RID: 14629 RVA: 0x00362CCC File Offset: 0x00360ECC
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolSuppressEmergencyCallCapability_A42143
		{
			get
			{
				short num = (short)1546781957;
				short num2 = num;
				num = (short)1719600389;
				switch (num2 == num)
				{
				}
				num = (short)2092040192;
				if (num != 0)
				{
				}
				num = (short)1439039489;
				if (num != 0)
				{
				}
				num = (short)1250689024;
				short num3 = num;
				return this.radWideLabtoolSuppressEmergencyCallCapability_A42143;
			}
		}

		// Token: 0x17001D1C RID: 7452
		// (get) Token: 0x06003926 RID: 14630 RVA: 0x00362D7C File Offset: 0x00360F7C
		// (set) Token: 0x06003927 RID: 14631 RVA: 0x00362E34 File Offset: 0x00361034
		public bool RadWideLabtoolSuppressEmergencyCallCapability_A42143_UIValue
		{
			get
			{
				short num = (short)269091666;
				short num2 = num;
				num = (short)976094034;
				switch (num2 == num)
				{
				}
				num = (short)592576512;
				if (num != 0)
				{
				}
				num = (short)1805320193;
				if (num != 0)
				{
				}
				num = (short)1432092672;
				short num3 = num;
				return this.radWideLabtoolSuppressEmergencyCallCapability_A42143.Value;
			}
			set
			{
				short num = (short)1974424611;
				short num2 = num;
				num = (short)2022790179;
				switch (num2 == num)
				{
				}
				num = (short)1350238209;
				if (num != 0)
				{
				}
				num = (short)272171008;
				if (num != 0)
				{
				}
				num = (short)1841823744;
				short num3 = num;
				this.radWideLabtoolSuppressEmergencyCallCapability_A42143.Value = value;
			}
		}

		// Token: 0x17001D1D RID: 7453
		// (get) Token: 0x06003928 RID: 14632 RVA: 0x00362EE8 File Offset: 0x003610E8
		// (set) Token: 0x06003929 RID: 14633 RVA: 0x00362FA0 File Offset: 0x003611A0
		public bool RadWideLabtoolSuppressEmergencyCallCapability_A42143_Applicable
		{
			get
			{
				short num = (short)1417025538;
				short num2 = num;
				num = (short)1058019330;
				switch (num2 == num)
				{
				}
				num = (short)375259136;
				if (num != 0)
				{
				}
				num = (short)1127350273;
				if (num != 0)
				{
				}
				num = (short)1869479936;
				short num3 = num;
				return this.radWideLabtoolSuppressEmergencyCallCapability_A42143.Applicable;
			}
			set
			{
				short num = (short)770887392;
				short num2 = num;
				num = (short)1421135584;
				switch (num2 == num)
				{
				}
				num = (short)1372258305;
				if (num != 0)
				{
				}
				num = (short)1572798464;
				if (num != 0)
				{
				}
				num = (short)494927872;
				short num3 = num;
				this.radWideLabtoolSuppressEmergencyCallCapability_A42143.Applicable = value;
			}
		}

		// Token: 0x17001D1E RID: 7454
		// (get) Token: 0x0600392A RID: 14634 RVA: 0x00363058 File Offset: 0x00361258
		// (set) Token: 0x0600392B RID: 14635 RVA: 0x0036310C File Offset: 0x0036130C
		public bool RadWideLabtoolSuppressEmergencyCallCapability_A42143_Valid
		{
			get
			{
				short num = (short)883359745;
				if (num != 0)
				{
				}
				num = (short)350025379;
				short num2 = num;
				num = (short)1740109475;
				switch (num2 == num)
				{
				}
				num = (short)405536768;
				if (num != 0)
				{
				}
				num = (short)1841823744;
				short num3 = num;
				return this.radWideLabtoolSuppressEmergencyCallCapability_A42143.Valid;
			}
			set
			{
				short num = (short)1482202813;
				short num2 = num;
				num = (short)547135165;
				switch (num2 == num)
				{
				}
				num = (short)685768705;
				if (num != 0)
				{
				}
				num = (short)27459584;
				if (num != 0)
				{
				}
				num = (short)307822592;
				short num3 = num;
				this.radWideLabtoolSuppressEmergencyCallCapability_A42143.Valid = value;
			}
		}

		// Token: 0x17001D1F RID: 7455
		// (get) Token: 0x0600392C RID: 14636 RVA: 0x003631C4 File Offset: 0x003613C4
		// (set) Token: 0x0600392D RID: 14637 RVA: 0x00363278 File Offset: 0x00361478
		public bool RadWideLabtoolSuppressEmergencyCallCapability_A42143_Visible
		{
			get
			{
				short num = (short)1450508289;
				if (num != 0)
				{
				}
				num = (short)1856921319;
				short num2 = num;
				num = (short)458710759;
				switch (num2 == num)
				{
				}
				num = (short)1332674560;
				if (num != 0)
				{
				}
				num = (short)520749056;
				short num3 = num;
				return this.radWideLabtoolSuppressEmergencyCallCapability_A42143.Visible;
			}
			set
			{
				short num = (short)631089296;
				short num2 = num;
				num = (short)1607182480;
				switch (num2 == num)
				{
				}
				num = (short)1910571008;
				if (num != 0)
				{
				}
				num = (short)626720769;
				if (num != 0)
				{
				}
				num = (short)1436221440;
				short num3 = num;
				this.radWideLabtoolSuppressEmergencyCallCapability_A42143.Visible = value;
			}
		}

		// Token: 0x17001D20 RID: 7456
		// (get) Token: 0x0600392E RID: 14638 RVA: 0x00363330 File Offset: 0x00361530
		// (set) Token: 0x0600392F RID: 14639 RVA: 0x003633E4 File Offset: 0x003615E4
		public bool RadWideLabtoolSuppressEmergencyCallCapability_A42143_Editable
		{
			get
			{
				short num = (short)1820983297;
				if (num != 0)
				{
				}
				num = (short)1262291522;
				short num2 = num;
				num = (short)261229122;
				switch (num2 == num)
				{
				}
				num = (short)1806172160;
				if (num != 0)
				{
				}
				num = (short)1568735232;
				short num3 = num;
				return this.radWideLabtoolSuppressEmergencyCallCapability_A42143.Editable;
			}
			set
			{
				short num = (short)1303473033;
				short num2 = num;
				num = (short)484993929;
				switch (num2 == num)
				{
				}
				num = (short)1480327169;
				if (num != 0)
				{
				}
				num = (short)990248960;
				if (num != 0)
				{
				}
				num = (short)807796736;
				short num3 = num;
				this.radWideLabtoolSuppressEmergencyCallCapability_A42143.Editable = value;
			}
		}

		// Token: 0x17001D21 RID: 7457
		// (get) Token: 0x06003930 RID: 14640 RVA: 0x00363498 File Offset: 0x00361698
		internal string RadWideLabtoolSuppressEmergencyCallCapability_A42143_UILabel
		{
			get
			{
				short num = (short)784181425;
				short num2 = num;
				num = (short)482453681;
				switch (num2 == num)
				{
				}
				num = (short)680853505;
				if (num != 0)
				{
				}
				num = (short)1125318656;
				if (num != 0)
				{
				}
				num = (short)347668480;
				short num3 = num;
				return this.radWideLabtoolSuppressEmergencyCallCapability_A42143.UIName;
			}
		}

		// Token: 0x17001D22 RID: 7458
		// (get) Token: 0x06003931 RID: 14641 RVA: 0x0036354C File Offset: 0x0036174C
		// (set) Token: 0x06003932 RID: 14642 RVA: 0x00363604 File Offset: 0x00361804
		internal bool RadWideLabtoolSuppressEmergencyCallCapability_A42143_HiddenStatic
		{
			get
			{
				short num = (short)1386949290;
				short num2 = num;
				num = (short)824257194;
				switch (num2 == num)
				{
				}
				num = (short)774897665;
				if (num != 0)
				{
				}
				num = (short)1224343552;
				if (num != 0)
				{
				}
				num = (short)789708800;
				short num3 = num;
				return this.radWideLabtoolSuppressEmergencyCallCapability_A42143.HiddenStatic;
			}
			set
			{
				short num = (short)1129950541;
				short num2 = num;
				num = (short)34188621;
				switch (num2 == num)
				{
				default:
				{
					num = (short)191365120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1885667328;
				if (num != 0)
				{
				}
				num = (short)216268801;
				if (num != 0)
				{
				}
				this.radWideLabtoolSuppressEmergencyCallCapability_A42143.HiddenStatic = value;
			}
		}

		// Token: 0x17001D23 RID: 7459
		// (get) Token: 0x06003933 RID: 14643 RVA: 0x003636BC File Offset: 0x003618BC
		// (set) Token: 0x06003934 RID: 14644 RVA: 0x00363770 File Offset: 0x00361970
		internal bool RadWideLabtoolSuppressEmergencyCallCapability_A42143_HiddenDynamic
		{
			get
			{
				short num = (short)1596443280;
				short num2 = num;
				num = (short)1136904848;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1111162880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)662634496;
				if (num != 0)
				{
				}
				num = (short)387710977;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSuppressEmergencyCallCapability_A42143.HiddenDynamic;
			}
			set
			{
				short num = (short)1747201611;
				short num2 = num;
				num = (short)2067082827;
				switch (num2 == num)
				{
				default:
				{
					num = (short)741212160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)406323201;
				if (num != 0)
				{
				}
				num = (short)1756889088;
				if (num != 0)
				{
				}
				this.radWideLabtoolSuppressEmergencyCallCapability_A42143.HiddenDynamic = value;
			}
		}

		// Token: 0x17001D24 RID: 7460
		// (get) Token: 0x06003935 RID: 14645 RVA: 0x00363824 File Offset: 0x00361A24
		public bool RadWideLabtoolSuppressEmergencyCallCapability_A42143_HasDiffs
		{
			get
			{
				short num = (short)746899572;
				short num2 = num;
				num = (short)314165364;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1900478464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)546177024;
				if (num != 0)
				{
				}
				num = (short)57868289;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSuppressEmergencyCallCapability_A42143._HasDiffs;
			}
		}

		// Token: 0x17001D25 RID: 7461
		// (get) Token: 0x06003936 RID: 14646 RVA: 0x003638D8 File Offset: 0x00361AD8
		// (set) Token: 0x06003937 RID: 14647 RVA: 0x00363990 File Offset: 0x00361B90
		public bool RadWideLabtoolMaritimeRadioSoftware_A42191Value
		{
			get
			{
				short num = (short)267989801;
				short num2 = num;
				num = (short)1522873129;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2141061120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)769130497;
				if (num != 0)
				{
				}
				num = (short)2118647808;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMaritimeRadioSoftware_A42191.Value;
			}
			set
			{
				short num = (short)719934007;
				short num2 = num;
				num = (short)2116768311;
				switch (num2 == num)
				{
				default:
				{
					num = (short)413925376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1580269569;
				if (num != 0)
				{
				}
				num = (short)462159872;
				if (num != 0)
				{
				}
				this.radWideLabtoolMaritimeRadioSoftware_A42191.Value = value;
			}
		}

		// Token: 0x17001D26 RID: 7462
		// (get) Token: 0x06003938 RID: 14648 RVA: 0x00363A44 File Offset: 0x00361C44
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolMaritimeRadioSoftware_A42191
		{
			get
			{
				short num = (short)74480269;
				short num2 = num;
				num = (short)746158733;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1084489728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1375928321;
				if (num != 0)
				{
				}
				num = (short)1693646848;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMaritimeRadioSoftware_A42191;
			}
		}

		// Token: 0x17001D27 RID: 7463
		// (get) Token: 0x06003939 RID: 14649 RVA: 0x00363AF4 File Offset: 0x00361CF4
		// (set) Token: 0x0600393A RID: 14650 RVA: 0x00363BA8 File Offset: 0x00361DA8
		public bool RadWideLabtoolMaritimeRadioSoftware_A42191_UIValue
		{
			get
			{
				short num = (short)1749631946;
				short num2 = num;
				num = (short)1081230282;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1363869696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2090926081;
				if (num != 0)
				{
				}
				num = (short)677117952;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMaritimeRadioSoftware_A42191.Value;
			}
			set
			{
				short num = (short)1974307294;
				short num2 = num;
				num = (short)1092389342;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1478885376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1864761345;
				if (num != 0)
				{
				}
				num = (short)1876951040;
				if (num != 0)
				{
				}
				this.radWideLabtoolMaritimeRadioSoftware_A42191.Value = value;
			}
		}

		// Token: 0x17001D28 RID: 7464
		// (get) Token: 0x0600393B RID: 14651 RVA: 0x00363C5C File Offset: 0x00361E5C
		// (set) Token: 0x0600393C RID: 14652 RVA: 0x00363D10 File Offset: 0x00361F10
		public bool RadWideLabtoolMaritimeRadioSoftware_A42191_Applicable
		{
			get
			{
				short num = (short)772100330;
				short num2 = num;
				num = (short)1974358250;
				switch (num2 == num)
				{
				default:
				{
					num = (short)888340480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2138243072;
				if (num != 0)
				{
				}
				num = (short)1006436353;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMaritimeRadioSoftware_A42191.Applicable;
			}
			set
			{
				short num = (short)303705393;
				short num2 = num;
				num = (short)1680616753;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1068171264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1676279808;
				if (num != 0)
				{
				}
				num = (short)130744321;
				if (num != 0)
				{
				}
				this.radWideLabtoolMaritimeRadioSoftware_A42191.Applicable = value;
			}
		}

		// Token: 0x17001D29 RID: 7465
		// (get) Token: 0x0600393D RID: 14653 RVA: 0x00363DC4 File Offset: 0x00361FC4
		// (set) Token: 0x0600393E RID: 14654 RVA: 0x00363E78 File Offset: 0x00362078
		public bool RadWideLabtoolMaritimeRadioSoftware_A42191_Valid
		{
			get
			{
				short num = (short)800063489;
				if (num != 0)
				{
				}
				num = (short)116064256;
				short num2 = num;
				num = (short)725119079;
				short num3 = num;
				num = (short)227111015;
				switch (num3 == num)
				{
				}
				num = (short)802553856;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMaritimeRadioSoftware_A42191.Valid;
			}
			set
			{
				short num = (short)751466021;
				short num2 = num;
				num = (short)1848473125;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1065484288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)379781121;
				if (num != 0)
				{
				}
				num = (short)424673280;
				if (num != 0)
				{
				}
				this.radWideLabtoolMaritimeRadioSoftware_A42191.Valid = value;
			}
		}

		// Token: 0x17001D2A RID: 7466
		// (get) Token: 0x0600393F RID: 14655 RVA: 0x00363F2C File Offset: 0x0036212C
		// (set) Token: 0x06003940 RID: 14656 RVA: 0x00363FDC File Offset: 0x003621DC
		public bool RadWideLabtoolMaritimeRadioSoftware_A42191_Visible
		{
			get
			{
				short num = (short)677365852;
				short num2 = num;
				num = (short)1594607708;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1852178432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1776746496;
				if (num != 0)
				{
				}
				num = (short)1587609601;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMaritimeRadioSoftware_A42191.Visible;
			}
			set
			{
				short num = (short)502120638;
				short num2 = num;
				num = (short)1675346110;
				switch (num2 == num)
				{
				default:
				{
					num = (short)278921216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)374538241;
				if (num != 0)
				{
				}
				num = (short)1293942784;
				if (num != 0)
				{
				}
				this.radWideLabtoolMaritimeRadioSoftware_A42191.Visible = value;
			}
		}

		// Token: 0x17001D2B RID: 7467
		// (get) Token: 0x06003941 RID: 14657 RVA: 0x00364094 File Offset: 0x00362294
		// (set) Token: 0x06003942 RID: 14658 RVA: 0x0036414C File Offset: 0x0036234C
		public bool RadWideLabtoolMaritimeRadioSoftware_A42191_Editable
		{
			get
			{
				short num = (short)849018881;
				if (num != 0)
				{
				}
				num = (short)1937178624;
				short num2 = num;
				num = (short)1916404040;
				short num3 = num;
				num = (short)438370632;
				switch (num3 == num)
				{
				}
				num = (short)1663434752;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMaritimeRadioSoftware_A42191.Editable;
			}
			set
			{
				short num = (short)829981944;
				short num2 = num;
				num = (short)887457016;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1090322432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1819475969;
				if (num != 0)
				{
				}
				num = (short)1713242112;
				if (num != 0)
				{
				}
				this.radWideLabtoolMaritimeRadioSoftware_A42191.Editable = value;
			}
		}

		// Token: 0x17001D2C RID: 7468
		// (get) Token: 0x06003943 RID: 14659 RVA: 0x00364200 File Offset: 0x00362400
		internal string RadWideLabtoolMaritimeRadioSoftware_A42191_UILabel
		{
			get
			{
				short num = (short)395101623;
				short num2 = num;
				num = (short)1533855159;
				switch (num2 == num)
				{
				default:
				{
					num = (short)314245120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)349569025;
				if (num != 0)
				{
				}
				num = (short)232849408;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMaritimeRadioSoftware_A42191.UIName;
			}
		}

		// Token: 0x17001D2D RID: 7469
		// (get) Token: 0x06003944 RID: 14660 RVA: 0x003642B4 File Offset: 0x003624B4
		// (set) Token: 0x06003945 RID: 14661 RVA: 0x00364370 File Offset: 0x00362570
		internal bool RadWideLabtoolMaritimeRadioSoftware_A42191_HiddenStatic
		{
			get
			{
				short num = (short)2104635662;
				short num2 = num;
				num = (short)1632710926;
				switch (num2 == num)
				{
				default:
				{
					num = (short)582221824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)333709312;
				if (num != 0)
				{
				}
				num = (short)1431044097;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMaritimeRadioSoftware_A42191.HiddenStatic;
			}
			set
			{
				short num = (short)792460651;
				short num2 = num;
				num = (short)586546539;
				switch (num2 == num)
				{
				default:
				{
					num = (short)323878912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)144113665;
				if (num != 0)
				{
				}
				num = (short)199426048;
				if (num != 0)
				{
				}
				this.radWideLabtoolMaritimeRadioSoftware_A42191.HiddenStatic = value;
			}
		}

		// Token: 0x17001D2E RID: 7470
		// (get) Token: 0x06003946 RID: 14662 RVA: 0x00364428 File Offset: 0x00362628
		// (set) Token: 0x06003947 RID: 14663 RVA: 0x003644DC File Offset: 0x003626DC
		internal bool RadWideLabtoolMaritimeRadioSoftware_A42191_HiddenDynamic
		{
			get
			{
				short num = (short)1614718415;
				short num2 = num;
				num = (short)1034266063;
				switch (num2 == num)
				{
				default:
				{
					num = (short)265879552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)670826497;
				if (num != 0)
				{
				}
				num = (short)553123840;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMaritimeRadioSoftware_A42191.HiddenDynamic;
			}
			set
			{
				short num = (short)590201615;
				short num2 = num;
				num = (short)110543631;
				switch (num2 == num)
				{
				default:
				{
					num = (short)664469504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1688993793;
				if (num != 0)
				{
				}
				num = (short)1677328384;
				if (num != 0)
				{
				}
				this.radWideLabtoolMaritimeRadioSoftware_A42191.HiddenDynamic = value;
			}
		}

		// Token: 0x17001D2F RID: 7471
		// (get) Token: 0x06003948 RID: 14664 RVA: 0x00364594 File Offset: 0x00362794
		public bool RadWideLabtoolMaritimeRadioSoftware_A42191_HasDiffs
		{
			get
			{
				short num = (short)1301003557;
				short num2 = num;
				num = (short)1445903653;
				switch (num2 == num)
				{
				default:
				{
					num = (short)602800128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2004746241;
				if (num != 0)
				{
				}
				num = (short)979435520;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMaritimeRadioSoftware_A42191._HasDiffs;
			}
		}

		// Token: 0x17001D30 RID: 7472
		// (get) Token: 0x06003949 RID: 14665 RVA: 0x0036464C File Offset: 0x0036284C
		// (set) Token: 0x0600394A RID: 14666 RVA: 0x00364704 File Offset: 0x00362904
		public bool RadWideLabtoolMFKEmergencyAccess_A42216Value
		{
			get
			{
				short num = (short)1938977426;
				short num2 = num;
				num = (short)1738240658;
				switch (num2 == num)
				{
				default:
				{
					num = (short)975568896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2008416256;
				if (num != 0)
				{
				}
				num = (short)243531777;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMFKEmergencyAccess_A42216.Value;
			}
			set
			{
				short num = (short)421236917;
				short num2 = num;
				num = (short)720277685;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1006436352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)647495681;
				if (num != 0)
				{
				}
				num = (short)657915904;
				if (num != 0)
				{
				}
				this.radWideLabtoolMFKEmergencyAccess_A42216.Value = value;
			}
		}

		// Token: 0x17001D31 RID: 7473
		// (get) Token: 0x0600394B RID: 14667 RVA: 0x003647BC File Offset: 0x003629BC
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolMFKEmergencyAccess_A42216
		{
			get
			{
				short num = (short)2021644719;
				short num2 = num;
				num = (short)817617327;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1526726656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1203896321;
				if (num != 0)
				{
				}
				num = (short)1041891328;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMFKEmergencyAccess_A42216;
			}
		}

		// Token: 0x17001D32 RID: 7474
		// (get) Token: 0x0600394C RID: 14668 RVA: 0x00364868 File Offset: 0x00362A68
		// (set) Token: 0x0600394D RID: 14669 RVA: 0x0036491C File Offset: 0x00362B1C
		public bool RadWideLabtoolMFKEmergencyAccess_A42216_UIValue
		{
			get
			{
				short num = (short)1265064926;
				short num2 = num;
				num = (short)955800542;
				switch (num2 == num)
				{
				default:
				{
					num = (short)328335360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1019412481;
				if (num != 0)
				{
				}
				num = (short)1250754560;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMFKEmergencyAccess_A42216.Value;
			}
			set
			{
				short num = (short)86696251;
				short num2 = num;
				num = (short)1004331323;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1921253376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)403374081;
				if (num != 0)
				{
				}
				num = (short)810680320;
				if (num != 0)
				{
				}
				this.radWideLabtoolMFKEmergencyAccess_A42216.Value = value;
			}
		}

		// Token: 0x17001D33 RID: 7475
		// (get) Token: 0x0600394E RID: 14670 RVA: 0x003649D0 File Offset: 0x00362BD0
		// (set) Token: 0x0600394F RID: 14671 RVA: 0x00364A84 File Offset: 0x00362C84
		public bool RadWideLabtoolMFKEmergencyAccess_A42216_Applicable
		{
			get
			{
				short num = (short)1656815617;
				if (num != 0)
				{
				}
				num = (short)1476853760;
				short num2 = num;
				num = (short)1729941848;
				short num3 = num;
				num = (short)684511576;
				switch (num3 == num)
				{
				}
				num = (short)822607872;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMFKEmergencyAccess_A42216.Applicable;
			}
			set
			{
				short num = (short)880105986;
				short num2 = num;
				num = (short)593779202;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1141047296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1259077633;
				if (num != 0)
				{
				}
				num = (short)964231168;
				if (num != 0)
				{
				}
				this.radWideLabtoolMFKEmergencyAccess_A42216.Applicable = value;
			}
		}

		// Token: 0x17001D34 RID: 7476
		// (get) Token: 0x06003950 RID: 14672 RVA: 0x00364B3C File Offset: 0x00362D3C
		// (set) Token: 0x06003951 RID: 14673 RVA: 0x00364BF4 File Offset: 0x00362DF4
		public bool RadWideLabtoolMFKEmergencyAccess_A42216_Valid
		{
			get
			{
				short num = (short)425984001;
				if (num != 0)
				{
				}
				num = (short)1375338496;
				short num2 = num;
				num = (short)1824658664;
				short num3 = num;
				num = (short)1369052392;
				switch (num3 == num)
				{
				}
				num = (short)1372717056;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMFKEmergencyAccess_A42216.Valid;
			}
			set
			{
				short num = (short)906493953;
				if (num != 0)
				{
				}
				num = (short)333643776;
				short num2 = num;
				num = (short)716817363;
				short num3 = num;
				num = (short)349815763;
				switch (num3 == num)
				{
				}
				num = (short)502202368;
				if (num != 0)
				{
				}
				this.radWideLabtoolMFKEmergencyAccess_A42216.Valid = value;
			}
		}

		// Token: 0x17001D35 RID: 7477
		// (get) Token: 0x06003952 RID: 14674 RVA: 0x00364CAC File Offset: 0x00362EAC
		// (set) Token: 0x06003953 RID: 14675 RVA: 0x00364D60 File Offset: 0x00362F60
		public bool RadWideLabtoolMFKEmergencyAccess_A42216_Visible
		{
			get
			{
				short num = (short)1217499831;
				short num2 = num;
				num = (short)527536823;
				switch (num2 == num)
				{
				}
				num = (short)671285249;
				if (num != 0)
				{
				}
				num = (short)656146432;
				if (num != 0)
				{
				}
				num = (short)1433993216;
				short num3 = num;
				return this.radWideLabtoolMFKEmergencyAccess_A42216.Visible;
			}
			set
			{
				short num = (short)435378763;
				short num2 = num;
				num = (short)1130256971;
				switch (num2 == num)
				{
				}
				num = (short)1839857665;
				if (num != 0)
				{
				}
				num = (short)1707081728;
				if (num != 0)
				{
				}
				num = (short)1482686464;
				short num3 = num;
				this.radWideLabtoolMFKEmergencyAccess_A42216.Visible = value;
			}
		}

		// Token: 0x17001D36 RID: 7478
		// (get) Token: 0x06003954 RID: 14676 RVA: 0x00364E18 File Offset: 0x00363018
		// (set) Token: 0x06003955 RID: 14677 RVA: 0x00364ECC File Offset: 0x003630CC
		public bool RadWideLabtoolMFKEmergencyAccess_A42216_Editable
		{
			get
			{
				short num = (short)664459686;
				short num2 = num;
				num = (short)1823005094;
				switch (num2 == num)
				{
				}
				num = (short)199884800;
				if (num != 0)
				{
				}
				num = (short)940244993;
				if (num != 0)
				{
				}
				num = (short)1845035008;
				short num3 = num;
				return this.radWideLabtoolMFKEmergencyAccess_A42216.Editable;
			}
			set
			{
				short num = (short)1232567455;
				short num2 = num;
				num = (short)680623263;
				switch (num2 == num)
				{
				}
				num = (short)439418881;
				if (num != 0)
				{
				}
				num = (short)1664024576;
				if (num != 0)
				{
				}
				num = (short)1915289600;
				short num3 = num;
				this.radWideLabtoolMFKEmergencyAccess_A42216.Editable = value;
			}
		}

		// Token: 0x17001D37 RID: 7479
		// (get) Token: 0x06003956 RID: 14678 RVA: 0x00364F80 File Offset: 0x00363180
		internal string RadWideLabtoolMFKEmergencyAccess_A42216_UILabel
		{
			get
			{
				short num = (short)1105687410;
				short num2 = num;
				num = (short)1164800882;
				switch (num2 == num)
				{
				}
				num = (short)1383202817;
				if (num != 0)
				{
				}
				num = (short)168820736;
				if (num != 0)
				{
				}
				num = (short)18874368;
				short num3 = num;
				return this.radWideLabtoolMFKEmergencyAccess_A42216.UIName;
			}
		}

		// Token: 0x17001D38 RID: 7480
		// (get) Token: 0x06003957 RID: 14679 RVA: 0x00365034 File Offset: 0x00363234
		// (set) Token: 0x06003958 RID: 14680 RVA: 0x003650F0 File Offset: 0x003632F0
		internal bool RadWideLabtoolMFKEmergencyAccess_A42216_HiddenStatic
		{
			get
			{
				short num = (short)1738344334;
				short num2 = num;
				num = (short)208603022;
				switch (num2 == num)
				{
				}
				num = (short)1388314625;
				if (num != 0)
				{
				}
				num = (short)20054016;
				if (num != 0)
				{
				}
				num = (short)217186304;
				short num3 = num;
				return this.radWideLabtoolMFKEmergencyAccess_A42216.HiddenStatic;
			}
			set
			{
				short num = (short)1597841178;
				short num2 = num;
				num = (short)1811095322;
				switch (num2 == num)
				{
				}
				num = (short)1608843265;
				if (num != 0)
				{
				}
				num = (short)42926080;
				if (num != 0)
				{
				}
				num = (short)1837039616;
				short num3 = num;
				this.radWideLabtoolMFKEmergencyAccess_A42216.HiddenStatic = value;
			}
		}

		// Token: 0x17001D39 RID: 7481
		// (get) Token: 0x06003959 RID: 14681 RVA: 0x003651A4 File Offset: 0x003633A4
		// (set) Token: 0x0600395A RID: 14682 RVA: 0x0036525C File Offset: 0x0036345C
		internal bool RadWideLabtoolMFKEmergencyAccess_A42216_HiddenDynamic
		{
			get
			{
				short num = (short)821061385;
				short num2 = num;
				num = (short)1658808073;
				switch (num2 == num)
				{
				}
				num = (short)1057423361;
				if (num != 0)
				{
				}
				num = (short)1301413888;
				if (num != 0)
				{
				}
				num = (short)1809711104;
				short num3 = num;
				return this.radWideLabtoolMFKEmergencyAccess_A42216.HiddenDynamic;
			}
			set
			{
				short num = (short)1631085423;
				short num2 = num;
				num = (short)1254908783;
				switch (num2 == num)
				{
				}
				num = (short)91095040;
				if (num != 0)
				{
				}
				num = (short)367394817;
				if (num != 0)
				{
				}
				num = (short)1215823872;
				short num3 = num;
				this.radWideLabtoolMFKEmergencyAccess_A42216.HiddenDynamic = value;
			}
		}

		// Token: 0x17001D3A RID: 7482
		// (get) Token: 0x0600395B RID: 14683 RVA: 0x00365314 File Offset: 0x00363514
		public bool RadWideLabtoolMFKEmergencyAccess_A42216_HasDiffs
		{
			get
			{
				short num = (short)1395314381;
				short num2 = num;
				num = (short)402509517;
				switch (num2 == num)
				{
				}
				num = (short)1064108033;
				if (num != 0)
				{
				}
				num = (short)1618935808;
				if (num != 0)
				{
				}
				num = (short)1601503232;
				short num3 = num;
				return this.radWideLabtoolMFKEmergencyAccess_A42216._HasDiffs;
			}
		}

		// Token: 0x17001D3B RID: 7483
		// (get) Token: 0x0600395C RID: 14684 RVA: 0x003653C8 File Offset: 0x003635C8
		// (set) Token: 0x0600395D RID: 14685 RVA: 0x00365480 File Offset: 0x00363680
		public bool EmergencyHotAuxMicConfigurability_A42301Value
		{
			get
			{
				short num = (short)1579514663;
				short num2 = num;
				num = (short)1877900071;
				switch (num2 == num)
				{
				}
				num = (short)102957057;
				if (num != 0)
				{
				}
				num = (short)189399040;
				if (num != 0)
				{
				}
				num = (short)1015349248;
				short num3 = num;
				return this.emergencyHotAuxMicConfigurability_A42301.Value;
			}
			set
			{
				short num = (short)2089202280;
				short num2 = num;
				num = (short)416789096;
				switch (num2 == num)
				{
				}
				num = (short)460128256;
				if (num != 0)
				{
				}
				num = (short)547225601;
				if (num != 0)
				{
				}
				num = (short)133562368;
				short num3 = num;
				this.emergencyHotAuxMicConfigurability_A42301.Value = value;
			}
		}

		// Token: 0x17001D3C RID: 7484
		// (get) Token: 0x0600395E RID: 14686 RVA: 0x00365538 File Offset: 0x00363738
		public global::AcpBusinessLayer.AcpField<bool> EmergencyHotAuxMicConfigurability_A42301
		{
			get
			{
				short num = (short)309208818;
				short num2 = num;
				num = (short)879961842;
				switch (num2 == num)
				{
				}
				num = (short)2045313025;
				if (num != 0)
				{
				}
				num = (short)1188233216;
				if (num != 0)
				{
				}
				num = (short)189726720;
				short num3 = num;
				return this.emergencyHotAuxMicConfigurability_A42301;
			}
		}

		// Token: 0x17001D3D RID: 7485
		// (get) Token: 0x0600395F RID: 14687 RVA: 0x003655E4 File Offset: 0x003637E4
		// (set) Token: 0x06003960 RID: 14688 RVA: 0x00365698 File Offset: 0x00363898
		public bool EmergencyHotAuxMicConfigurability_A42301_UIValue
		{
			get
			{
				short num = (short)384739227;
				short num2 = num;
				num = (short)1167828891;
				switch (num2 == num)
				{
				}
				num = (short)179503104;
				if (num != 0)
				{
				}
				num = (short)2057043969;
				if (num != 0)
				{
				}
				num = (short)1659764736;
				short num3 = num;
				return this.emergencyHotAuxMicConfigurability_A42301.Value;
			}
			set
			{
				short num = (short)2128150529;
				if (num != 0)
				{
				}
				num = (short)915757242;
				short num2 = num;
				num = (short)1763989690;
				switch (num2 == num)
				{
				}
				num = (short)1349255168;
				if (num != 0)
				{
				}
				num = (short)1328087040;
				short num3 = num;
				this.emergencyHotAuxMicConfigurability_A42301.Value = value;
			}
		}

		// Token: 0x17001D3E RID: 7486
		// (get) Token: 0x06003961 RID: 14689 RVA: 0x0036574C File Offset: 0x0036394C
		// (set) Token: 0x06003962 RID: 14690 RVA: 0x00365804 File Offset: 0x00363A04
		public bool EmergencyHotAuxMicConfigurability_A42301_Applicable
		{
			get
			{
				short num = (short)674311751;
				short num2 = num;
				num = (short)397094471;
				switch (num2 == num)
				{
				}
				num = (short)1065484289;
				if (num != 0)
				{
				}
				num = (short)264568832;
				if (num != 0)
				{
				}
				num = (short)1013972992;
				short num3 = num;
				return this.emergencyHotAuxMicConfigurability_A42301.Applicable;
			}
			set
			{
				short num = (short)1805245950;
				short num2 = num;
				num = (short)532405758;
				switch (num2 == num)
				{
				}
				num = (short)1997209601;
				if (num != 0)
				{
				}
				num = (short)1472266240;
				if (num != 0)
				{
				}
				num = (short)384172032;
				short num3 = num;
				this.emergencyHotAuxMicConfigurability_A42301.Applicable = value;
			}
		}

		// Token: 0x17001D3F RID: 7487
		// (get) Token: 0x06003963 RID: 14691 RVA: 0x003658B8 File Offset: 0x00363AB8
		// (set) Token: 0x06003964 RID: 14692 RVA: 0x00365970 File Offset: 0x00363B70
		public bool EmergencyHotAuxMicConfigurability_A42301_Valid
		{
			get
			{
				short num = (short)242745345;
				if (num != 0)
				{
				}
				num = (short)574840222;
				short num2 = num;
				num = (short)1875598750;
				switch (num2 == num)
				{
				}
				num = (short)302514176;
				if (num != 0)
				{
				}
				num = (short)709296128;
				short num3 = num;
				return this.emergencyHotAuxMicConfigurability_A42301.Valid;
			}
			set
			{
				short num = (short)391717783;
				short num2 = num;
				num = (short)456074135;
				switch (num2 == num)
				{
				}
				num = (short)1491795969;
				if (num != 0)
				{
				}
				num = (short)1844445184;
				if (num != 0)
				{
				}
				num = (short)1683095552;
				short num3 = num;
				this.emergencyHotAuxMicConfigurability_A42301.Valid = value;
			}
		}

		// Token: 0x17001D40 RID: 7488
		// (get) Token: 0x06003965 RID: 14693 RVA: 0x00365A24 File Offset: 0x00363C24
		// (set) Token: 0x06003966 RID: 14694 RVA: 0x00365AD8 File Offset: 0x00363CD8
		public bool EmergencyHotAuxMicConfigurability_A42301_Visible
		{
			get
			{
				short num = (short)1694647434;
				short num2 = num;
				num = (short)558318730;
				switch (num2 == num)
				{
				}
				num = (short)721158144;
				if (num != 0)
				{
				}
				num = (short)1439432705;
				if (num != 0)
				{
				}
				num = (short)1199243264;
				short num3 = num;
				return this.emergencyHotAuxMicConfigurability_A42301.Visible;
			}
			set
			{
				short num = (short)1564162682;
				short num2 = num;
				num = (short)826817146;
				switch (num2 == num)
				{
				}
				num = (short)2080702465;
				if (num != 0)
				{
				}
				num = (short)810090496;
				if (num != 0)
				{
				}
				num = (short)1887567872;
				short num3 = num;
				this.emergencyHotAuxMicConfigurability_A42301.Visible = value;
			}
		}

		// Token: 0x17001D41 RID: 7489
		// (get) Token: 0x06003967 RID: 14695 RVA: 0x00365B8C File Offset: 0x00363D8C
		// (set) Token: 0x06003968 RID: 14696 RVA: 0x00365C40 File Offset: 0x00363E40
		public bool EmergencyHotAuxMicConfigurability_A42301_Editable
		{
			get
			{
				short num = (short)83995462;
				short num2 = num;
				num = (short)1739959110;
				switch (num2 == num)
				{
				}
				num = (short)1296433152;
				if (num != 0)
				{
				}
				num = (short)542638081;
				if (num != 0)
				{
				}
				num = (short)1588264960;
				short num3 = num;
				return this.emergencyHotAuxMicConfigurability_A42301.Editable;
			}
			set
			{
				short num = (short)1510180058;
				short num2 = num;
				num = (short)1958773978;
				switch (num2 == num)
				{
				}
				num = (short)588447745;
				if (num != 0)
				{
				}
				num = (short)1076363264;
				if (num != 0)
				{
				}
				num = (short)1390477312;
				short num3 = num;
				this.emergencyHotAuxMicConfigurability_A42301.Editable = value;
			}
		}

		// Token: 0x17001D42 RID: 7490
		// (get) Token: 0x06003969 RID: 14697 RVA: 0x00365CF8 File Offset: 0x00363EF8
		internal string EmergencyHotAuxMicConfigurability_A42301_UILabel
		{
			get
			{
				short num = (short)463989309;
				short num2 = num;
				num = (short)819259965;
				switch (num2 == num)
				{
				}
				num = (short)1995309057;
				if (num != 0)
				{
				}
				num = (short)1524498432;
				if (num != 0)
				{
				}
				num = (short)15007744;
				short num3 = num;
				return this.emergencyHotAuxMicConfigurability_A42301.UIName;
			}
		}

		// Token: 0x17001D43 RID: 7491
		// (get) Token: 0x0600396A RID: 14698 RVA: 0x00365DAC File Offset: 0x00363FAC
		// (set) Token: 0x0600396B RID: 14699 RVA: 0x00365E60 File Offset: 0x00364060
		internal bool EmergencyHotAuxMicConfigurability_A42301_HiddenStatic
		{
			get
			{
				short num = (short)823790954;
				short num2 = num;
				num = (short)1485573482;
				switch (num2 == num)
				{
				}
				num = (short)1249378305;
				if (num != 0)
				{
				}
				num = (short)1501036544;
				if (num != 0)
				{
				}
				num = (short)207028224;
				short num3 = num;
				return this.emergencyHotAuxMicConfigurability_A42301.HiddenStatic;
			}
			set
			{
				short num = (short)1993194424;
				short num2 = num;
				num = (short)55294904;
				switch (num2 == num)
				{
				}
				num = (short)1930493952;
				if (num != 0)
				{
				}
				num = (short)278003713;
				if (num != 0)
				{
				}
				num = (short)660537344;
				short num3 = num;
				this.emergencyHotAuxMicConfigurability_A42301.HiddenStatic = value;
			}
		}

		// Token: 0x17001D44 RID: 7492
		// (get) Token: 0x0600396C RID: 14700 RVA: 0x00365F14 File Offset: 0x00364114
		// (set) Token: 0x0600396D RID: 14701 RVA: 0x00365FC4 File Offset: 0x003641C4
		internal bool EmergencyHotAuxMicConfigurability_A42301_HiddenDynamic
		{
			get
			{
				short num = (short)1544042430;
				short num2 = num;
				num = (short)778385342;
				switch (num2 == num)
				{
				}
				num = (short)1938685953;
				if (num != 0)
				{
				}
				num = (short)461373440;
				if (num != 0)
				{
				}
				num = (short)541589504;
				short num3 = num;
				return this.emergencyHotAuxMicConfigurability_A42301.HiddenDynamic;
			}
			set
			{
				short num = (short)1202280826;
				short num2 = num;
				num = (short)823875962;
				switch (num2 == num)
				{
				}
				num = (short)536936449;
				if (num != 0)
				{
				}
				num = (short)2019360768;
				if (num != 0)
				{
				}
				num = (short)901447680;
				short num3 = num;
				this.emergencyHotAuxMicConfigurability_A42301.HiddenDynamic = value;
			}
		}

		// Token: 0x17001D45 RID: 7493
		// (get) Token: 0x0600396E RID: 14702 RVA: 0x00366078 File Offset: 0x00364278
		public bool EmergencyHotAuxMicConfigurability_A42301_HasDiffs
		{
			get
			{
				short num = (short)1185216088;
				short num2 = num;
				num = (short)614790744;
				switch (num2 == num)
				{
				}
				num = (short)2070544385;
				if (num != 0)
				{
				}
				num = (short)276692992;
				if (num != 0)
				{
				}
				num = (short)2004484096;
				short num3 = num;
				return this.emergencyHotAuxMicConfigurability_A42301._HasDiffs;
			}
		}

		// Token: 0x17001D46 RID: 7494
		// (get) Token: 0x0600396F RID: 14703 RVA: 0x0036612C File Offset: 0x0036432C
		// (set) Token: 0x06003970 RID: 14704 RVA: 0x003661E0 File Offset: 0x003643E0
		public bool TPSCapable_A42312Value
		{
			get
			{
				short num = (short)240949586;
				short num2 = num;
				num = (short)280992082;
				switch (num2 == num)
				{
				}
				num = (short)8388609;
				if (num != 0)
				{
				}
				num = (short)876281856;
				if (num != 0)
				{
				}
				num = (short)1182793728;
				short num3 = num;
				return this.tPSCapable_A42312.Value;
			}
			set
			{
				short num = (short)1570009713;
				short num2 = num;
				num = (short)1315598961;
				switch (num2 == num)
				{
				}
				num = (short)591462401;
				if (num != 0)
				{
				}
				num = (short)1892024320;
				if (num != 0)
				{
				}
				num = (short)985268224;
				short num3 = num;
				this.tPSCapable_A42312.Value = value;
			}
		}

		// Token: 0x17001D47 RID: 7495
		// (get) Token: 0x06003971 RID: 14705 RVA: 0x00366298 File Offset: 0x00364498
		public global::AcpBusinessLayer.AcpField<bool> TPSCapable_A42312
		{
			get
			{
				short num = (short)833695708;
				short num2 = num;
				num = (short)1912221660;
				switch (num2 == num)
				{
				}
				num = (short)1654718465;
				if (num != 0)
				{
				}
				num = (short)951975936;
				if (num != 0)
				{
				}
				num = (short)666042368;
				short num3 = num;
				return this.tPSCapable_A42312;
			}
		}

		// Token: 0x17001D48 RID: 7496
		// (get) Token: 0x06003972 RID: 14706 RVA: 0x00366348 File Offset: 0x00364548
		// (set) Token: 0x06003973 RID: 14707 RVA: 0x003663FC File Offset: 0x003645FC
		public bool TPSCapable_A42312_UIValue
		{
			get
			{
				short num = (short)678444033;
				short num2 = num;
				num = (short)1899641857;
				switch (num2 == num)
				{
				}
				num = (short)1929838592;
				if (num != 0)
				{
				}
				num = (short)366870529;
				if (num != 0)
				{
				}
				num = (short)1032388608;
				short num3 = num;
				return this.tPSCapable_A42312.Value;
			}
			set
			{
				short num = (short)1851353437;
				short num2 = num;
				num = (short)436693341;
				switch (num2 == num)
				{
				}
				num = (short)2013659136;
				if (num != 0)
				{
				}
				num = (short)65404929;
				if (num != 0)
				{
				}
				num = (short)1298792448;
				short num3 = num;
				this.tPSCapable_A42312.Value = value;
			}
		}

		// Token: 0x17001D49 RID: 7497
		// (get) Token: 0x06003974 RID: 14708 RVA: 0x003664B8 File Offset: 0x003646B8
		// (set) Token: 0x06003975 RID: 14709 RVA: 0x00366568 File Offset: 0x00364768
		public bool TPSCapable_A42312_Applicable
		{
			get
			{
				short num = (short)648404400;
				short num2 = num;
				num = (short)886169008;
				switch (num2 == num)
				{
				}
				num = (short)2138243072;
				if (num != 0)
				{
				}
				num = (short)1078198273;
				if (num != 0)
				{
				}
				num = (short)943587328;
				short num3 = num;
				return this.tPSCapable_A42312.Applicable;
			}
			set
			{
				short num = (short)1963130881;
				if (num != 0)
				{
				}
				num = (short)1410866138;
				short num2 = num;
				num = (short)195369946;
				switch (num2 == num)
				{
				}
				num = (short)1042677760;
				if (num != 0)
				{
				}
				num = (short)2024079360;
				short num3 = num;
				this.tPSCapable_A42312.Applicable = value;
			}
		}

		// Token: 0x17001D4A RID: 7498
		// (get) Token: 0x06003976 RID: 14710 RVA: 0x00366620 File Offset: 0x00364820
		// (set) Token: 0x06003977 RID: 14711 RVA: 0x003666D4 File Offset: 0x003648D4
		public bool TPSCapable_A42312_Valid
		{
			get
			{
				short num = (short)1332539061;
				short num2 = num;
				num = (short)548662965;
				switch (num2 == num)
				{
				}
				num = (short)1806565376;
				if (num != 0)
				{
				}
				num = (short)490340353;
				if (num != 0)
				{
				}
				num = (short)1483669504;
				short num3 = num;
				return this.tPSCapable_A42312.Valid;
			}
			set
			{
				short num = (short)1949713439;
				short num2 = num;
				num = (short)379339807;
				switch (num2 == num)
				{
				}
				num = (short)392888321;
				if (num != 0)
				{
				}
				num = (short)372441088;
				if (num != 0)
				{
				}
				num = (short)1686044672;
				short num3 = num;
				this.tPSCapable_A42312.Valid = value;
			}
		}

		// Token: 0x17001D4B RID: 7499
		// (get) Token: 0x06003978 RID: 14712 RVA: 0x00366788 File Offset: 0x00364988
		// (set) Token: 0x06003979 RID: 14713 RVA: 0x0036683C File Offset: 0x00364A3C
		public bool TPSCapable_A42312_Visible
		{
			get
			{
				short num = (short)382701014;
				short num2 = num;
				num = (short)2062388694;
				switch (num2 == num)
				{
				}
				num = (short)1849163777;
				if (num != 0)
				{
				}
				num = (short)680198144;
				if (num != 0)
				{
				}
				num = (short)637796352;
				short num3 = num;
				return this.tPSCapable_A42312.Visible;
			}
			set
			{
				short num = (short)1634827625;
				short num2 = num;
				num = (short)542735721;
				switch (num2 == num)
				{
				}
				num = (short)1683095553;
				if (num != 0)
				{
				}
				num = (short)2146500608;
				if (num != 0)
				{
				}
				num = (short)349700096;
				short num3 = num;
				this.tPSCapable_A42312.Visible = value;
			}
		}

		// Token: 0x17001D4C RID: 7500
		// (get) Token: 0x0600397A RID: 14714 RVA: 0x003668F0 File Offset: 0x00364AF0
		// (set) Token: 0x0600397B RID: 14715 RVA: 0x003669A4 File Offset: 0x00364BA4
		public bool TPSCapable_A42312_Editable
		{
			get
			{
				short num = (short)950118044;
				short num2 = num;
				num = (short)1096525468;
				switch (num2 == num)
				{
				}
				num = (short)994312192;
				if (num != 0)
				{
				}
				num = (short)1316028417;
				if (num != 0)
				{
				}
				num = (short)70189056;
				short num3 = num;
				return this.tPSCapable_A42312.Editable;
			}
			set
			{
				short num = (short)1017563653;
				short num2 = num;
				num = (short)960416261;
				switch (num2 == num)
				{
				}
				num = (short)721551361;
				if (num != 0)
				{
				}
				num = (short)803340288;
				if (num != 0)
				{
				}
				num = (short)2009268224;
				short num3 = num;
				this.tPSCapable_A42312.Editable = value;
			}
		}

		// Token: 0x17001D4D RID: 7501
		// (get) Token: 0x0600397C RID: 14716 RVA: 0x00366A58 File Offset: 0x00364C58
		internal string TPSCapable_A42312_UILabel
		{
			get
			{
				short num = (short)613718523;
				short num2 = num;
				num = (short)35297787;
				switch (num2 == num)
				{
				}
				num = (short)942669825;
				if (num != 0)
				{
				}
				num = (short)2014904320;
				if (num != 0)
				{
				}
				num = (short)544014336;
				short num3 = num;
				return this.tPSCapable_A42312.UIName;
			}
		}

		// Token: 0x17001D4E RID: 7502
		// (get) Token: 0x0600397D RID: 14717 RVA: 0x00366B10 File Offset: 0x00364D10
		// (set) Token: 0x0600397E RID: 14718 RVA: 0x00366BC4 File Offset: 0x00364DC4
		internal bool TPSCapable_A42312_HiddenStatic
		{
			get
			{
				short num = (short)18470657;
				short num2 = num;
				num = (short)66901761;
				switch (num2 == num)
				{
				}
				num = (short)812908545;
				if (num != 0)
				{
				}
				num = (short)594214912;
				if (num != 0)
				{
				}
				num = (short)1857880064;
				short num3 = num;
				return this.tPSCapable_A42312.HiddenStatic;
			}
			set
			{
				short num = (short)233719784;
				short num2 = num;
				num = (short)1742358504;
				switch (num2 == num)
				{
				}
				num = (short)654901248;
				if (num != 0)
				{
				}
				num = (short)38666241;
				if (num != 0)
				{
				}
				num = (short)1485176832;
				short num3 = num;
				this.tPSCapable_A42312.HiddenStatic = value;
			}
		}

		// Token: 0x17001D4F RID: 7503
		// (get) Token: 0x0600397F RID: 14719 RVA: 0x00366C78 File Offset: 0x00364E78
		// (set) Token: 0x06003980 RID: 14720 RVA: 0x00366D30 File Offset: 0x00364F30
		internal bool TPSCapable_A42312_HiddenDynamic
		{
			get
			{
				short num = (short)1715145405;
				short num2 = num;
				num = (short)1020398269;
				switch (num2 == num)
				{
				}
				num = (short)73465856;
				if (num != 0)
				{
				}
				num = (short)1844445185;
				if (num != 0)
				{
				}
				num = (short)667222016;
				short num3 = num;
				return this.tPSCapable_A42312.HiddenDynamic;
			}
			set
			{
				short num = (short)1964854176;
				short num2 = num;
				num = (short)1394101152;
				switch (num2 == num)
				{
				}
				num = (short)1551040513;
				if (num != 0)
				{
				}
				num = (short)1001455616;
				if (num != 0)
				{
				}
				num = (short)1034616832;
				short num3 = num;
				this.tPSCapable_A42312.HiddenDynamic = value;
			}
		}

		// Token: 0x17001D50 RID: 7504
		// (get) Token: 0x06003981 RID: 14721 RVA: 0x00366DE4 File Offset: 0x00364FE4
		public bool TPSCapable_A42312_HasDiffs
		{
			get
			{
				short num = (short)1022159130;
				short num2 = num;
				num = (short)1016588570;
				switch (num2 == num)
				{
				}
				num = (short)1422065664;
				if (num != 0)
				{
				}
				num = (short)770506753;
				if (num != 0)
				{
				}
				num = (short)177078272;
				short num3 = num;
				return this.tPSCapable_A42312._HasDiffs;
			}
		}

		// Token: 0x17001D51 RID: 7505
		// (get) Token: 0x06003982 RID: 14722 RVA: 0x00366E98 File Offset: 0x00365098
		// (set) Token: 0x06003983 RID: 14723 RVA: 0x00366F4C File Offset: 0x0036514C
		public bool PASSAlarmFilterCapable_A42387Value
		{
			get
			{
				short num = (short)1799782645;
				short num2 = num;
				num = (short)1479180533;
				switch (num2 == num)
				{
				}
				num = (short)1000931329;
				if (num != 0)
				{
				}
				num = (short)1569849344;
				if (num != 0)
				{
				}
				num = (short)1300037632;
				short num3 = num;
				return this.pASSAlarmFilterCapable_A42387.Value;
			}
			set
			{
				short num = (short)1906704385;
				if (num != 0)
				{
				}
				num = (short)1182870934;
				short num2 = num;
				num = (short)858598806;
				switch (num2 == num)
				{
				}
				num = (short)77266944;
				if (num != 0)
				{
				}
				num = (short)201392128;
				short num3 = num;
				this.pASSAlarmFilterCapable_A42387.Value = value;
			}
		}

		// Token: 0x17001D52 RID: 7506
		// (get) Token: 0x06003984 RID: 14724 RVA: 0x00367004 File Offset: 0x00365204
		public global::AcpBusinessLayer.AcpField<bool> PASSAlarmFilterCapable_A42387
		{
			get
			{
				short num = (short)977011516;
				short num2 = num;
				num = (short)1134494524;
				switch (num2 == num)
				{
				}
				num = (short)1600651265;
				if (num != 0)
				{
				}
				num = (short)1813118976;
				if (num != 0)
				{
				}
				num = (short)2044329984;
				short num3 = num;
				return this.pASSAlarmFilterCapable_A42387;
			}
		}

		// Token: 0x17001D53 RID: 7507
		// (get) Token: 0x06003985 RID: 14725 RVA: 0x003670B4 File Offset: 0x003652B4
		// (set) Token: 0x06003986 RID: 14726 RVA: 0x0036716C File Offset: 0x0036536C
		public bool PASSAlarmFilterCapable_A42387_UIValue
		{
			get
			{
				short num = (short)675938305;
				if (num != 0)
				{
				}
				num = (short)1461613497;
				short num2 = num;
				num = (short)473002937;
				switch (num2 == num)
				{
				}
				num = (short)580321280;
				if (num != 0)
				{
				}
				num = (short)1882324992;
				short num3 = num;
				return this.pASSAlarmFilterCapable_A42387.Value;
			}
			set
			{
				short num = (short)1330460266;
				short num2 = num;
				num = (short)2031040106;
				switch (num2 == num)
				{
				}
				num = (short)1958805505;
				if (num != 0)
				{
				}
				num = (short)2046754816;
				if (num != 0)
				{
				}
				num = (short)1746141184;
				short num3 = num;
				this.pASSAlarmFilterCapable_A42387.Value = value;
			}
		}

		// Token: 0x17001D54 RID: 7508
		// (get) Token: 0x06003987 RID: 14727 RVA: 0x00367224 File Offset: 0x00365424
		// (set) Token: 0x06003988 RID: 14728 RVA: 0x003672D4 File Offset: 0x003654D4
		public bool PASSAlarmFilterCapable_A42387_Applicable
		{
			get
			{
				short num = (short)725864541;
				short num2 = num;
				num = (short)583585885;
				switch (num2 == num)
				{
				}
				num = (short)756416513;
				if (num != 0)
				{
				}
				num = (short)1162739712;
				if (num != 0)
				{
				}
				num = (short)1833697280;
				short num3 = num;
				return this.pASSAlarmFilterCapable_A42387.Applicable;
			}
			set
			{
				short num = (short)1041008984;
				short num2 = num;
				num = (short)1363773784;
				switch (num2 == num)
				{
				}
				num = (short)1457061889;
				if (num != 0)
				{
				}
				num = (short)2122055680;
				if (num != 0)
				{
				}
				num = (short)925761536;
				short num3 = num;
				this.pASSAlarmFilterCapable_A42387.Applicable = value;
			}
		}

		// Token: 0x17001D55 RID: 7509
		// (get) Token: 0x06003989 RID: 14729 RVA: 0x0036738C File Offset: 0x0036558C
		// (set) Token: 0x0600398A RID: 14730 RVA: 0x00367440 File Offset: 0x00365640
		public bool PASSAlarmFilterCapable_A42387_Valid
		{
			get
			{
				short num = (short)1178855281;
				short num2 = num;
				num = (short)1874519921;
				switch (num2 == num)
				{
				}
				num = (short)1498873857;
				if (num != 0)
				{
				}
				num = (short)271515648;
				if (num != 0)
				{
				}
				num = (short)471597056;
				short num3 = num;
				return this.pASSAlarmFilterCapable_A42387.Valid;
			}
			set
			{
				short num = (short)600233329;
				short num2 = num;
				num = (short)135976305;
				switch (num2 == num)
				{
				}
				num = (short)2100363264;
				if (num != 0)
				{
				}
				num = (short)710541313;
				if (num != 0)
				{
				}
				num = (short)1013579776;
				short num3 = num;
				this.pASSAlarmFilterCapable_A42387.Valid = value;
			}
		}

		// Token: 0x17001D56 RID: 7510
		// (get) Token: 0x0600398B RID: 14731 RVA: 0x003674F8 File Offset: 0x003656F8
		// (set) Token: 0x0600398C RID: 14732 RVA: 0x003675A8 File Offset: 0x003657A8
		public bool PASSAlarmFilterCapable_A42387_Visible
		{
			get
			{
				short num = (short)400551785;
				short num2 = num;
				num = (short)768601961;
				switch (num2 == num)
				{
				}
				num = (short)1933312001;
				if (num != 0)
				{
				}
				num = (short)117440512;
				if (num != 0)
				{
				}
				num = (short)1638662144;
				short num3 = num;
				return this.pASSAlarmFilterCapable_A42387.Visible;
			}
			set
			{
				short num = (short)1343582005;
				short num2 = num;
				num = (short)1827368757;
				switch (num2 == num)
				{
				}
				num = (short)52428801;
				if (num != 0)
				{
				}
				num = (short)1600258048;
				if (num != 0)
				{
				}
				num = (short)445251584;
				short num3 = num;
				this.pASSAlarmFilterCapable_A42387.Visible = value;
			}
		}

		// Token: 0x17001D57 RID: 7511
		// (get) Token: 0x0600398D RID: 14733 RVA: 0x0036765C File Offset: 0x0036585C
		// (set) Token: 0x0600398E RID: 14734 RVA: 0x00367710 File Offset: 0x00365910
		public bool PASSAlarmFilterCapable_A42387_Editable
		{
			get
			{
				short num = (short)1832761273;
				short num2 = num;
				num = (short)268679097;
				switch (num2 == num)
				{
				}
				num = (short)1351483393;
				if (num != 0)
				{
				}
				num = (short)85458944;
				if (num != 0)
				{
				}
				num = (short)782696448;
				short num3 = num;
				return this.pASSAlarmFilterCapable_A42387.Editable;
			}
			set
			{
				short num = (short)1878839247;
				short num2 = num;
				num = (short)1678233551;
				switch (num2 == num)
				{
				}
				num = (short)910753793;
				if (num != 0)
				{
				}
				num = (short)533725184;
				if (num != 0)
				{
				}
				num = (short)658964480;
				short num3 = num;
				this.pASSAlarmFilterCapable_A42387.Editable = value;
			}
		}

		// Token: 0x17001D58 RID: 7512
		// (get) Token: 0x0600398F RID: 14735 RVA: 0x003677C8 File Offset: 0x003659C8
		internal string PASSAlarmFilterCapable_A42387_UILabel
		{
			get
			{
				short num = (short)1634649503;
				short num2 = num;
				num = (short)166970783;
				switch (num2 == num)
				{
				}
				num = (short)562757633;
				if (num != 0)
				{
				}
				num = (short)392232960;
				if (num != 0)
				{
				}
				num = (short)2130837504;
				short num3 = num;
				return this.pASSAlarmFilterCapable_A42387.UIName;
			}
		}

		// Token: 0x17001D59 RID: 7513
		// (get) Token: 0x06003990 RID: 14736 RVA: 0x0036787C File Offset: 0x00365A7C
		// (set) Token: 0x06003991 RID: 14737 RVA: 0x00367934 File Offset: 0x00365B34
		internal bool PASSAlarmFilterCapable_A42387_HiddenStatic
		{
			get
			{
				short num = (short)101478576;
				short num2 = num;
				num = (short)734097584;
				switch (num2 == num)
				{
				}
				num = (short)162070528;
				if (num != 0)
				{
				}
				num = (short)1905000449;
				if (num != 0)
				{
				}
				num = (short)1009254400;
				short num3 = num;
				return this.pASSAlarmFilterCapable_A42387.HiddenStatic;
			}
			set
			{
				short num = (short)1640745500;
				short num2 = num;
				num = (short)1201064476;
				switch (num2 == num)
				{
				}
				num = (short)1367736321;
				if (num != 0)
				{
				}
				num = (short)1897201664;
				if (num != 0)
				{
				}
				num = (short)1471414272;
				short num3 = num;
				this.pASSAlarmFilterCapable_A42387.HiddenStatic = value;
			}
		}

		// Token: 0x17001D5A RID: 7514
		// (get) Token: 0x06003992 RID: 14738 RVA: 0x003679E8 File Offset: 0x00365BE8
		// (set) Token: 0x06003993 RID: 14739 RVA: 0x00367A9C File Offset: 0x00365C9C
		internal bool PASSAlarmFilterCapable_A42387_HiddenDynamic
		{
			get
			{
				short num = (short)1084251228;
				short num2 = num;
				num = (short)1527209052;
				switch (num2 == num)
				{
				}
				num = (short)962396161;
				if (num != 0)
				{
				}
				num = (short)398327808;
				if (num != 0)
				{
				}
				num = (short)1668022272;
				short num3 = num;
				return this.pASSAlarmFilterCapable_A42387.HiddenDynamic;
			}
			set
			{
				short num = (short)1384401739;
				short num2 = num;
				num = (short)1139034955;
				switch (num2 == num)
				{
				}
				num = (short)1932722177;
				if (num != 0)
				{
				}
				num = (short)622788608;
				if (num != 0)
				{
				}
				num = (short)1668087808;
				short num3 = num;
				this.pASSAlarmFilterCapable_A42387.HiddenDynamic = value;
			}
		}

		// Token: 0x17001D5B RID: 7515
		// (get) Token: 0x06003994 RID: 14740 RVA: 0x00367B54 File Offset: 0x00365D54
		public bool PASSAlarmFilterCapable_A42387_HasDiffs
		{
			get
			{
				short num = (short)1994946150;
				short num2 = num;
				num = (short)1175615078;
				switch (num2 == num)
				{
				}
				num = (short)1764556800;
				if (num != 0)
				{
				}
				num = (short)1710882817;
				if (num != 0)
				{
				}
				num = (short)705953792;
				short num3 = num;
				return this.pASSAlarmFilterCapable_A42387._HasDiffs;
			}
		}

		// Token: 0x17001D5C RID: 7516
		// (get) Token: 0x06003995 RID: 14741 RVA: 0x00367C08 File Offset: 0x00365E08
		// (set) Token: 0x06003996 RID: 14742 RVA: 0x00367CBC File Offset: 0x00365EBC
		public bool RadWideLabtoolAPXDualKnobs_A42537Value
		{
			get
			{
				short num = (short)1663221140;
				short num2 = num;
				num = (short)1416215956;
				switch (num2 == num)
				{
				}
				num = (short)1188364289;
				if (num != 0)
				{
				}
				num = (short)1993342976;
				if (num != 0)
				{
				}
				num = (short)993787904;
				short num3 = num;
				return this.radWideLabtoolAPXDualKnobs_A42537.Value;
			}
			set
			{
				short num = (short)1409993195;
				short num2 = num;
				num = (short)1239599595;
				switch (num2 == num)
				{
				}
				num = (short)222167040;
				if (num != 0)
				{
				}
				num = (short)63504385;
				if (num != 0)
				{
				}
				num = (short)1696399360;
				short num3 = num;
				this.radWideLabtoolAPXDualKnobs_A42537.Value = value;
			}
		}

		// Token: 0x17001D5D RID: 7517
		// (get) Token: 0x06003997 RID: 14743 RVA: 0x00367D70 File Offset: 0x00365F70
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolAPXDualKnobs_A42537
		{
			get
			{
				short num = (short)53411841;
				if (num != 0)
				{
				}
				num = (short)1759395040;
				short num2 = num;
				num = (short)1213742304;
				switch (num2 == num)
				{
				}
				num = (short)1345585152;
				if (num != 0)
				{
				}
				num = (short)1590951936;
				short num3 = num;
				return this.radWideLabtoolAPXDualKnobs_A42537;
			}
		}

		// Token: 0x17001D5E RID: 7518
		// (get) Token: 0x06003998 RID: 14744 RVA: 0x00367E20 File Offset: 0x00366020
		// (set) Token: 0x06003999 RID: 14745 RVA: 0x00367ED4 File Offset: 0x003660D4
		public bool RadWideLabtoolAPXDualKnobs_A42537_UIValue
		{
			get
			{
				short num = (short)1416249234;
				short num2 = num;
				num = (short)109395858;
				switch (num2 == num)
				{
				}
				num = (short)556204033;
				if (num != 0)
				{
				}
				num = (short)1698496512;
				if (num != 0)
				{
				}
				num = (short)766902272;
				short num3 = num;
				return this.radWideLabtoolAPXDualKnobs_A42537.Value;
			}
			set
			{
				short num = (short)2032533505;
				if (num != 0)
				{
				}
				num = (short)1395366367;
				short num2 = num;
				num = (short)735746527;
				switch (num2 == num)
				{
				}
				num = (short)494469120;
				if (num != 0)
				{
				}
				num = (short)1298726912;
				short num3 = num;
				this.radWideLabtoolAPXDualKnobs_A42537.Value = value;
			}
		}

		// Token: 0x17001D5F RID: 7519
		// (get) Token: 0x0600399A RID: 14746 RVA: 0x00367F88 File Offset: 0x00366188
		// (set) Token: 0x0600399B RID: 14747 RVA: 0x00368040 File Offset: 0x00366240
		public bool RadWideLabtoolAPXDualKnobs_A42537_Applicable
		{
			get
			{
				short num = (short)197119944;
				short num2 = num;
				num = (short)991481800;
				switch (num2 == num)
				{
				}
				num = (short)1306787841;
				if (num != 0)
				{
				}
				num = (short)1585840128;
				if (num != 0)
				{
				}
				num = (short)1755906048;
				short num3 = num;
				return this.radWideLabtoolAPXDualKnobs_A42537.Applicable;
			}
			set
			{
				short num = (short)365690881;
				if (num != 0)
				{
				}
				num = (short)357082669;
				short num2 = num;
				num = (short)220898861;
				switch (num2 == num)
				{
				}
				num = (short)591724544;
				if (num != 0)
				{
				}
				num = (short)19202048;
				short num3 = num;
				this.radWideLabtoolAPXDualKnobs_A42537.Applicable = value;
			}
		}

		// Token: 0x17001D60 RID: 7520
		// (get) Token: 0x0600399C RID: 14748 RVA: 0x003680F8 File Offset: 0x003662F8
		// (set) Token: 0x0600399D RID: 14749 RVA: 0x003681AC File Offset: 0x003663AC
		public bool RadWideLabtoolAPXDualKnobs_A42537_Valid
		{
			get
			{
				short num = (short)206962689;
				if (num != 0)
				{
				}
				num = (short)325230061;
				short num2 = num;
				num = (short)778804717;
				switch (num2 == num)
				{
				}
				num = (short)1547436032;
				if (num != 0)
				{
				}
				num = (short)1561001984;
				short num3 = num;
				return this.radWideLabtoolAPXDualKnobs_A42537.Valid;
			}
			set
			{
				short num = (short)1318846465;
				if (num != 0)
				{
				}
				num = (short)991326325;
				short num2 = num;
				num = (short)1010135157;
				switch (num2 == num)
				{
				}
				num = (short)1558970368;
				if (num != 0)
				{
				}
				num = (short)562233344;
				short num3 = num;
				this.radWideLabtoolAPXDualKnobs_A42537.Valid = value;
			}
		}

		// Token: 0x17001D61 RID: 7521
		// (get) Token: 0x0600399E RID: 14750 RVA: 0x00368260 File Offset: 0x00366460
		// (set) Token: 0x0600399F RID: 14751 RVA: 0x00368314 File Offset: 0x00366514
		public bool RadWideLabtoolAPXDualKnobs_A42537_Visible
		{
			get
			{
				short num = (short)454365514;
				short num2 = num;
				num = (short)403378506;
				switch (num2 == num)
				{
				}
				num = (short)1266745345;
				if (num != 0)
				{
				}
				num = (short)1568538624;
				if (num != 0)
				{
				}
				num = (short)65863680;
				short num3 = num;
				return this.radWideLabtoolAPXDualKnobs_A42537.Visible;
			}
			set
			{
				short num = (short)1325510105;
				short num2 = num;
				num = (short)493661657;
				switch (num2 == num)
				{
				}
				num = (short)512229377;
				if (num != 0)
				{
				}
				num = (short)50003968;
				if (num != 0)
				{
				}
				num = (short)1673134080;
				short num3 = num;
				this.radWideLabtoolAPXDualKnobs_A42537.Visible = value;
			}
		}

		// Token: 0x17001D62 RID: 7522
		// (get) Token: 0x060039A0 RID: 14752 RVA: 0x003683CC File Offset: 0x003665CC
		// (set) Token: 0x060039A1 RID: 14753 RVA: 0x00368480 File Offset: 0x00366680
		public bool RadWideLabtoolAPXDualKnobs_A42537_Editable
		{
			get
			{
				short num = (short)682992213;
				short num2 = num;
				num = (short)1945870933;
				switch (num2 == num)
				{
				}
				num = (short)431030272;
				if (num != 0)
				{
				}
				num = (short)1396506625;
				if (num != 0)
				{
				}
				num = (short)1825701888;
				short num3 = num;
				return this.radWideLabtoolAPXDualKnobs_A42537.Editable;
			}
			set
			{
				short num = (short)805110445;
				short num2 = num;
				num = (short)1803748013;
				switch (num2 == num)
				{
				}
				num = (short)1181483009;
				if (num != 0)
				{
				}
				num = (short)989134848;
				if (num != 0)
				{
				}
				num = (short)1479868416;
				short num3 = num;
				this.radWideLabtoolAPXDualKnobs_A42537.Editable = value;
			}
		}

		// Token: 0x17001D63 RID: 7523
		// (get) Token: 0x060039A2 RID: 14754 RVA: 0x00368534 File Offset: 0x00366734
		internal string RadWideLabtoolAPXDualKnobs_A42537_UILabel
		{
			get
			{
				short num = (short)919236632;
				short num2 = num;
				num = (short)1395290136;
				switch (num2 == num)
				{
				}
				num = (short)1761083393;
				if (num != 0)
				{
				}
				num = (short)1441005568;
				if (num != 0)
				{
				}
				num = (short)307494912;
				short num3 = num;
				return this.radWideLabtoolAPXDualKnobs_A42537.UIName;
			}
		}

		// Token: 0x17001D64 RID: 7524
		// (get) Token: 0x060039A3 RID: 14755 RVA: 0x003685E8 File Offset: 0x003667E8
		// (set) Token: 0x060039A4 RID: 14756 RVA: 0x0036869C File Offset: 0x0036689C
		internal bool RadWideLabtoolAPXDualKnobs_A42537_HiddenStatic
		{
			get
			{
				short num = (short)1901416100;
				short num2 = num;
				num = (short)1492340388;
				switch (num2 == num)
				{
				}
				num = (short)677183489;
				if (num != 0)
				{
				}
				num = (short)1136852992;
				if (num != 0)
				{
				}
				num = (short)1636499456;
				short num3 = num;
				return this.radWideLabtoolAPXDualKnobs_A42537.HiddenStatic;
			}
			set
			{
				short num = (short)1196490753;
				if (num != 0)
				{
				}
				num = (short)1920522373;
				short num2 = num;
				num = (short)741398661;
				switch (num2 == num)
				{
				}
				num = (short)679739392;
				if (num != 0)
				{
				}
				num = (short)1752629248;
				short num3 = num;
				this.radWideLabtoolAPXDualKnobs_A42537.HiddenStatic = value;
			}
		}

		// Token: 0x17001D65 RID: 7525
		// (get) Token: 0x060039A5 RID: 14757 RVA: 0x00368750 File Offset: 0x00366950
		// (set) Token: 0x060039A6 RID: 14758 RVA: 0x00368804 File Offset: 0x00366A04
		internal bool RadWideLabtoolAPXDualKnobs_A42537_HiddenDynamic
		{
			get
			{
				short num = (short)158910658;
				short num2 = num;
				num = (short)1297860802;
				switch (num2 == num)
				{
				}
				num = (short)600309761;
				if (num != 0)
				{
				}
				num = (short)1343422464;
				if (num != 0)
				{
				}
				num = (short)1020002304;
				short num3 = num;
				return this.radWideLabtoolAPXDualKnobs_A42537.HiddenDynamic;
			}
			set
			{
				short num = (short)1214092822;
				short num2 = num;
				num = (short)1816106518;
				switch (num2 == num)
				{
				}
				num = (short)471465985;
				if (num != 0)
				{
				}
				num = (short)437780480;
				if (num != 0)
				{
				}
				num = (short)149028864;
				short num3 = num;
				this.radWideLabtoolAPXDualKnobs_A42537.HiddenDynamic = value;
			}
		}

		// Token: 0x17001D66 RID: 7526
		// (get) Token: 0x060039A7 RID: 14759 RVA: 0x003688B8 File Offset: 0x00366AB8
		public bool RadWideLabtoolAPXDualKnobs_A42537_HasDiffs
		{
			get
			{
				short num = (short)1588133560;
				short num2 = num;
				num = (short)1807548088;
				switch (num2 == num)
				{
				}
				num = (short)693108737;
				if (num != 0)
				{
				}
				num = (short)969998336;
				if (num != 0)
				{
				}
				num = (short)620363776;
				short num3 = num;
				return this.radWideLabtoolAPXDualKnobs_A42537._HasDiffs;
			}
		}

		// Token: 0x17001D67 RID: 7527
		// (get) Token: 0x060039A8 RID: 14760 RVA: 0x0036896C File Offset: 0x00366B6C
		// (set) Token: 0x060039A9 RID: 14761 RVA: 0x00368A20 File Offset: 0x00366C20
		public bool RadWideLabtoolAudioEnhancement_A42736Value
		{
			get
			{
				short num = (short)591591793;
				short num2 = num;
				num = (short)2146630001;
				switch (num2 == num)
				{
				}
				num = (short)1530593281;
				if (num != 0)
				{
				}
				num = (short)1084686336;
				if (num != 0)
				{
				}
				num = (short)1649999872;
				short num3 = num;
				return this.radWideLabtoolAudioEnhancement_A42736.Value;
			}
			set
			{
				short num = (short)525953956;
				short num2 = num;
				num = (short)2101963684;
				switch (num2 == num)
				{
				}
				num = (short)423231489;
				if (num != 0)
				{
				}
				num = (short)1612185600;
				if (num != 0)
				{
				}
				num = (short)1279918080;
				short num3 = num;
				this.radWideLabtoolAudioEnhancement_A42736.Value = value;
			}
		}

		// Token: 0x17001D68 RID: 7528
		// (get) Token: 0x060039AA RID: 14762 RVA: 0x00368AD4 File Offset: 0x00366CD4
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolAudioEnhancement_A42736
		{
			get
			{
				short num = (short)1652809732;
				short num2 = num;
				num = (short)39051268;
				switch (num2 == num)
				{
				}
				num = (short)1166278657;
				if (num != 0)
				{
				}
				num = (short)1504903168;
				if (num != 0)
				{
				}
				num = (short)11337728;
				short num3 = num;
				return this.radWideLabtoolAudioEnhancement_A42736;
			}
		}

		// Token: 0x17001D69 RID: 7529
		// (get) Token: 0x060039AB RID: 14763 RVA: 0x00368B80 File Offset: 0x00366D80
		// (set) Token: 0x060039AC RID: 14764 RVA: 0x00368C34 File Offset: 0x00366E34
		public bool RadWideLabtoolAudioEnhancement_A42736_UIValue
		{
			get
			{
				short num = (short)1567094334;
				short num2 = num;
				num = (short)1250096702;
				switch (num2 == num)
				{
				}
				num = (short)1254555649;
				if (num != 0)
				{
				}
				num = (short)536084480;
				if (num != 0)
				{
				}
				num = (short)1555824640;
				short num3 = num;
				return this.radWideLabtoolAudioEnhancement_A42736.Value;
			}
			set
			{
				short num = (short)1494548481;
				if (num != 0)
				{
				}
				num = (short)108938856;
				short num2 = num;
				num = (short)1707689576;
				switch (num2 == num)
				{
				}
				num = (short)127729664;
				if (num != 0)
				{
				}
				num = (short)745472000;
				short num3 = num;
				this.radWideLabtoolAudioEnhancement_A42736.Value = value;
			}
		}

		// Token: 0x17001D6A RID: 7530
		// (get) Token: 0x060039AD RID: 14765 RVA: 0x00368CE8 File Offset: 0x00366EE8
		// (set) Token: 0x060039AE RID: 14766 RVA: 0x00368D98 File Offset: 0x00366F98
		public bool RadWideLabtoolAudioEnhancement_A42736_Applicable
		{
			get
			{
				short num = (short)1487077196;
				short num2 = num;
				num = (short)1775763276;
				switch (num2 == num)
				{
				}
				num = (short)788660225;
				if (num != 0)
				{
				}
				num = (short)1242890240;
				if (num != 0)
				{
				}
				num = (short)971505664;
				short num3 = num;
				return this.radWideLabtoolAudioEnhancement_A42736.Applicable;
			}
			set
			{
				short num = (short)1322112233;
				short num2 = num;
				num = (short)1433588969;
				switch (num2 == num)
				{
				}
				num = (short)1256718337;
				if (num != 0)
				{
				}
				num = (short)1194328064;
				if (num != 0)
				{
				}
				num = (short)1254883328;
				short num3 = num;
				this.radWideLabtoolAudioEnhancement_A42736.Applicable = value;
			}
		}

		// Token: 0x17001D6B RID: 7531
		// (get) Token: 0x060039AF RID: 14767 RVA: 0x00368E4C File Offset: 0x0036704C
		// (set) Token: 0x060039B0 RID: 14768 RVA: 0x00368F00 File Offset: 0x00367100
		public bool RadWideLabtoolAudioEnhancement_A42736_Valid
		{
			get
			{
				short num = (short)976224257;
				if (num != 0)
				{
				}
				num = (short)1852691996;
				short num2 = num;
				num = (short)1231869468;
				switch (num2 == num)
				{
				}
				num = (short)861601792;
				if (num != 0)
				{
				}
				num = (short)1424556032;
				short num3 = num;
				return this.radWideLabtoolAudioEnhancement_A42736.Valid;
			}
			set
			{
				short num = (short)804826522;
				short num2 = num;
				num = (short)1344581018;
				switch (num2 == num)
				{
				}
				num = (short)1528561665;
				if (num != 0)
				{
				}
				num = (short)1513226240;
				if (num != 0)
				{
				}
				num = (short)2096300032;
				short num3 = num;
				this.radWideLabtoolAudioEnhancement_A42736.Valid = value;
			}
		}

		// Token: 0x17001D6C RID: 7532
		// (get) Token: 0x060039B1 RID: 14769 RVA: 0x00368FB8 File Offset: 0x003671B8
		// (set) Token: 0x060039B2 RID: 14770 RVA: 0x00369070 File Offset: 0x00367270
		public bool RadWideLabtoolAudioEnhancement_A42736_Visible
		{
			get
			{
				short num = (short)887415036;
				short num2 = num;
				num = (short)802480380;
				switch (num2 == num)
				{
				}
				num = (short)1477967873;
				if (num != 0)
				{
				}
				num = (short)1049886720;
				if (num != 0)
				{
				}
				num = (short)393740288;
				short num3 = num;
				return this.radWideLabtoolAudioEnhancement_A42736.Visible;
			}
			set
			{
				short num = (short)484727125;
				short num2 = num;
				num = (short)559896917;
				switch (num2 == num)
				{
				}
				num = (short)143785985;
				if (num != 0)
				{
				}
				num = (short)418250752;
				if (num != 0)
				{
				}
				num = (short)2057699328;
				short num3 = num;
				this.radWideLabtoolAudioEnhancement_A42736.Visible = value;
			}
		}

		// Token: 0x17001D6D RID: 7533
		// (get) Token: 0x060039B3 RID: 14771 RVA: 0x00369128 File Offset: 0x00367328
		// (set) Token: 0x060039B4 RID: 14772 RVA: 0x003691DC File Offset: 0x003673DC
		public bool RadWideLabtoolAudioEnhancement_A42736_Editable
		{
			get
			{
				short num = (short)913690590;
				short num2 = num;
				num = (short)545312734;
				switch (num2 == num)
				{
				}
				num = (short)964362241;
				if (num != 0)
				{
				}
				num = (short)603324416;
				if (num != 0)
				{
				}
				num = (short)1704525824;
				short num3 = num;
				return this.radWideLabtoolAudioEnhancement_A42736.Editable;
			}
			set
			{
				short num = (short)1284340389;
				short num2 = num;
				num = (short)1323137701;
				switch (num2 == num)
				{
				}
				num = (short)1818034177;
				if (num != 0)
				{
				}
				num = (short)673120256;
				if (num != 0)
				{
				}
				num = (short)1361641472;
				short num3 = num;
				this.radWideLabtoolAudioEnhancement_A42736.Editable = value;
			}
		}

		// Token: 0x17001D6E RID: 7534
		// (get) Token: 0x060039B5 RID: 14773 RVA: 0x00369290 File Offset: 0x00367490
		internal string RadWideLabtoolAudioEnhancement_A42736_UILabel
		{
			get
			{
				short num = (short)1358101661;
				short num2 = num;
				num = (short)827653277;
				switch (num2 == num)
				{
				}
				num = (short)1849163777;
				if (num != 0)
				{
				}
				num = (short)144441344;
				if (num != 0)
				{
				}
				num = (short)116195328;
				short num3 = num;
				return this.radWideLabtoolAudioEnhancement_A42736.UIName;
			}
		}

		// Token: 0x17001D6F RID: 7535
		// (get) Token: 0x060039B6 RID: 14774 RVA: 0x00369344 File Offset: 0x00367544
		// (set) Token: 0x060039B7 RID: 14775 RVA: 0x003693F8 File Offset: 0x003675F8
		internal bool RadWideLabtoolAudioEnhancement_A42736_HiddenStatic
		{
			get
			{
				short num = (short)1097045078;
				short num2 = num;
				num = (short)298554454;
				switch (num2 == num)
				{
				}
				num = (short)2125266944;
				if (num != 0)
				{
				}
				num = (short)2034368513;
				if (num != 0)
				{
				}
				num = (short)1100021760;
				short num3 = num;
				return this.radWideLabtoolAudioEnhancement_A42736.HiddenStatic;
			}
			set
			{
				short num = (short)2100268555;
				short num2 = num;
				num = (short)1626377739;
				switch (num2 == num)
				{
				}
				num = (short)1396506624;
				short num3 = num;
				num = (short)1406009345;
				if (num != 0)
				{
				}
				num = (short)1316159488;
				if (num != 0)
				{
				}
				this.radWideLabtoolAudioEnhancement_A42736.HiddenStatic = value;
			}
		}

		// Token: 0x17001D70 RID: 7536
		// (get) Token: 0x060039B8 RID: 14776 RVA: 0x003694B0 File Offset: 0x003676B0
		// (set) Token: 0x060039B9 RID: 14777 RVA: 0x00369564 File Offset: 0x00367764
		internal bool RadWideLabtoolAudioEnhancement_A42736_HiddenDynamic
		{
			get
			{
				short num = (short)1068040193;
				if (num != 0)
				{
				}
				num = (short)272703279;
				short num2 = num;
				num = (short)1107042095;
				switch (num2 == num)
				{
				default:
				{
					num = (short)558563328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)762511360;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAudioEnhancement_A42736.HiddenDynamic;
			}
			set
			{
				short num = (short)37176340;
				short num2 = num;
				num = (short)2110800916;
				switch (num2 == num)
				{
				}
				num = (short)2136801280;
				short num3 = num;
				num = (short)772800513;
				if (num != 0)
				{
				}
				num = (short)862453760;
				if (num != 0)
				{
				}
				this.radWideLabtoolAudioEnhancement_A42736.HiddenDynamic = value;
			}
		}

		// Token: 0x17001D71 RID: 7537
		// (get) Token: 0x060039BA RID: 14778 RVA: 0x0036961C File Offset: 0x0036781C
		public bool RadWideLabtoolAudioEnhancement_A42736_HasDiffs
		{
			get
			{
				short num = (short)521924100;
				short num2 = num;
				num = (short)2010639876;
				switch (num2 == num)
				{
				}
				num = (short)690946048;
				short num3 = num;
				num = (short)1575223297;
				if (num != 0)
				{
				}
				num = (short)2071724032;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAudioEnhancement_A42736._HasDiffs;
			}
		}

		// Token: 0x17001D72 RID: 7538
		// (get) Token: 0x060039BB RID: 14779 RVA: 0x003696D4 File Offset: 0x003678D4
		// (set) Token: 0x060039BC RID: 14780 RVA: 0x00369788 File Offset: 0x00367988
		public bool RadWideLabtoolDynamicZoneScanCapability_42749Value
		{
			get
			{
				short num = (short)1974140929;
				if (num != 0)
				{
				}
				num = (short)344025436;
				short num2 = num;
				num = (short)180447580;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2018902016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1000210432;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDynamicZoneScanCapability_42749.Value;
			}
			set
			{
				short num = (short)45786096;
				short num2 = num;
				num = (short)1597285360;
				switch (num2 == num)
				{
				}
				num = (short)634191872;
				short num3 = num;
				num = (short)604831745;
				if (num != 0)
				{
				}
				num = (short)327417856;
				if (num != 0)
				{
				}
				this.radWideLabtoolDynamicZoneScanCapability_42749.Value = value;
			}
		}

		// Token: 0x17001D73 RID: 7539
		// (get) Token: 0x060039BD RID: 14781 RVA: 0x00369840 File Offset: 0x00367A40
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolDynamicZoneScanCapability_42749
		{
			get
			{
				short num = (short)1414434877;
				short num2 = num;
				num = (short)175345725;
				switch (num2 == num)
				{
				}
				num = (short)1415970816;
				short num3 = num;
				num = (short)1208942593;
				if (num != 0)
				{
				}
				num = (short)2029518848;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDynamicZoneScanCapability_42749;
			}
		}

		// Token: 0x17001D74 RID: 7540
		// (get) Token: 0x060039BE RID: 14782 RVA: 0x003698F0 File Offset: 0x00367AF0
		// (set) Token: 0x060039BF RID: 14783 RVA: 0x003699A4 File Offset: 0x00367BA4
		public bool RadWideLabtoolDynamicZoneScanCapability_42749_UIValue
		{
			get
			{
				short num = (short)2133602927;
				short num2 = num;
				num = (short)2037789295;
				switch (num2 == num)
				{
				}
				num = (short)831455232;
				short num3 = num;
				num = (short)1176043521;
				if (num != 0)
				{
				}
				num = (short)1150812160;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDynamicZoneScanCapability_42749.Value;
			}
			set
			{
				short num = (short)994449635;
				short num2 = num;
				num = (short)1902319843;
				switch (num2 == num)
				{
				}
				num = (short)725286912;
				short num3 = num;
				num = (short)1536032769;
				if (num != 0)
				{
				}
				num = (short)1646198784;
				if (num != 0)
				{
				}
				this.radWideLabtoolDynamicZoneScanCapability_42749.Value = value;
			}
		}

		// Token: 0x17001D75 RID: 7541
		// (get) Token: 0x060039C0 RID: 14784 RVA: 0x00369A58 File Offset: 0x00367C58
		// (set) Token: 0x060039C1 RID: 14785 RVA: 0x00369B10 File Offset: 0x00367D10
		public bool RadWideLabtoolDynamicZoneScanCapability_42749_Applicable
		{
			get
			{
				short num = (short)985191974;
				short num2 = num;
				num = (short)1400559142;
				switch (num2 == num)
				{
				}
				num = (short)495779840;
				short num3 = num;
				num = (short)1752170497;
				if (num != 0)
				{
				}
				num = (short)1204158464;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDynamicZoneScanCapability_42749.Applicable;
			}
			set
			{
				short num = (short)1758472088;
				short num2 = num;
				num = (short)2064328600;
				switch (num2 == num)
				{
				}
				num = (short)1277558784;
				short num3 = num;
				num = (short)1312096257;
				if (num != 0)
				{
				}
				num = (short)1883897856;
				if (num != 0)
				{
				}
				this.radWideLabtoolDynamicZoneScanCapability_42749.Applicable = value;
			}
		}

		// Token: 0x17001D76 RID: 7542
		// (get) Token: 0x060039C2 RID: 14786 RVA: 0x00369BC4 File Offset: 0x00367DC4
		// (set) Token: 0x060039C3 RID: 14787 RVA: 0x00369C74 File Offset: 0x00367E74
		public bool RadWideLabtoolDynamicZoneScanCapability_42749_Valid
		{
			get
			{
				short num = (short)1272794387;
				short num2 = num;
				num = (short)562515219;
				switch (num2 == num)
				{
				}
				num = (short)2128150528;
				short num3 = num;
				num = (short)1449459713;
				if (num != 0)
				{
				}
				num = (short)1115160576;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDynamicZoneScanCapability_42749.Valid;
			}
			set
			{
				short num = (short)740453511;
				short num2 = num;
				num = (short)487877767;
				switch (num2 == num)
				{
				}
				num = (short)397803520;
				short num3 = num;
				num = (short)80871424;
				if (num != 0)
				{
				}
				num = (short)564461569;
				if (num != 0)
				{
				}
				this.radWideLabtoolDynamicZoneScanCapability_42749.Valid = value;
			}
		}

		// Token: 0x17001D77 RID: 7543
		// (get) Token: 0x060039C4 RID: 14788 RVA: 0x00369D2C File Offset: 0x00367F2C
		// (set) Token: 0x060039C5 RID: 14789 RVA: 0x00369DE0 File Offset: 0x00367FE0
		public bool RadWideLabtoolDynamicZoneScanCapability_42749_Visible
		{
			get
			{
				short num = (short)1010302977;
				if (num != 0)
				{
				}
				num = (short)740181921;
				short num2 = num;
				num = (short)1094862753;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1708720128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)456982528;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDynamicZoneScanCapability_42749.Visible;
			}
			set
			{
				short num = (short)1411285291;
				short num2 = num;
				num = (short)1845330219;
				switch (num2 == num)
				{
				}
				num = (short)337510400;
				short num3 = num;
				num = (short)258080768;
				if (num != 0)
				{
				}
				num = (short)386727937;
				if (num != 0)
				{
				}
				this.radWideLabtoolDynamicZoneScanCapability_42749.Visible = value;
			}
		}

		// Token: 0x17001D78 RID: 7544
		// (get) Token: 0x060039C6 RID: 14790 RVA: 0x00369E94 File Offset: 0x00368094
		// (set) Token: 0x060039C7 RID: 14791 RVA: 0x00369F4C File Offset: 0x0036814C
		public bool RadWideLabtoolDynamicZoneScanCapability_42749_Editable
		{
			get
			{
				short num = (short)714014721;
				if (num != 0)
				{
				}
				num = (short)345107738;
				short num2 = num;
				num = (short)1367141658;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1843593216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)991756288;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDynamicZoneScanCapability_42749.Editable;
			}
			set
			{
				short num = (short)1937680366;
				short num2 = num;
				num = (short)410494958;
				switch (num2 == num)
				{
				}
				num = (short)1833631744;
				short num3 = num;
				num = (short)1253900288;
				if (num != 0)
				{
				}
				num = (short)875167745;
				if (num != 0)
				{
				}
				this.radWideLabtoolDynamicZoneScanCapability_42749.Editable = value;
			}
		}

		// Token: 0x17001D79 RID: 7545
		// (get) Token: 0x060039C8 RID: 14792 RVA: 0x0036A000 File Offset: 0x00368200
		internal string RadWideLabtoolDynamicZoneScanCapability_42749_UILabel
		{
			get
			{
				short num = (short)2091922438;
				short num2 = num;
				num = (short)1636185094;
				switch (num2 == num)
				{
				}
				num = (short)1357119488;
				short num3 = num;
				num = (short)2058747904;
				if (num != 0)
				{
				}
				num = (short)1172766721;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDynamicZoneScanCapability_42749.UIName;
			}
		}

		// Token: 0x17001D7A RID: 7546
		// (get) Token: 0x060039C9 RID: 14793 RVA: 0x0036A0B8 File Offset: 0x003682B8
		// (set) Token: 0x060039CA RID: 14794 RVA: 0x0036A170 File Offset: 0x00368370
		internal bool RadWideLabtoolDynamicZoneScanCapability_42749_HiddenStatic
		{
			get
			{
				short num = (short)305135617;
				if (num != 0)
				{
				}
				num = (short)1466260899;
				short num2 = num;
				num = (short)1243962787;
				switch (num2 == num)
				{
				default:
				{
					num = (short)260112384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1756954624;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDynamicZoneScanCapability_42749.HiddenStatic;
			}
			set
			{
				short num = (short)1769689561;
				short num2 = num;
				num = (short)1351111129;
				switch (num2 == num)
				{
				}
				num = (short)86114304;
				short num3 = num;
				num = (short)1643380736;
				if (num != 0)
				{
				}
				num = (short)655361;
				if (num != 0)
				{
				}
				this.radWideLabtoolDynamicZoneScanCapability_42749.HiddenStatic = value;
			}
		}

		// Token: 0x17001D7B RID: 7547
		// (get) Token: 0x060039CB RID: 14795 RVA: 0x0036A224 File Offset: 0x00368424
		// (set) Token: 0x060039CC RID: 14796 RVA: 0x0036A2DC File Offset: 0x003684DC
		internal bool RadWideLabtoolDynamicZoneScanCapability_42749_HiddenDynamic
		{
			get
			{
				short num = (short)909249218;
				short num2 = num;
				num = (short)1040911042;
				switch (num2 == num)
				{
				}
				num = (short)299630592;
				short num3 = num;
				num = (short)172687361;
				if (num != 0)
				{
				}
				num = (short)1390804992;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDynamicZoneScanCapability_42749.HiddenDynamic;
			}
			set
			{
				short num = (short)1174723983;
				short num2 = num;
				num = (short)688381327;
				switch (num2 == num)
				{
				}
				num = (short)2073559040;
				short num3 = num;
				num = (short)1160511488;
				if (num != 0)
				{
				}
				num = (short)728956929;
				if (num != 0)
				{
				}
				this.radWideLabtoolDynamicZoneScanCapability_42749.HiddenDynamic = value;
			}
		}

		// Token: 0x17001D7C RID: 7548
		// (get) Token: 0x060039CD RID: 14797 RVA: 0x0036A394 File Offset: 0x00368594
		public bool RadWideLabtoolDynamicZoneScanCapability_42749_HasDiffs
		{
			get
			{
				short num = (short)2105791404;
				short num2 = num;
				num = (short)1534186412;
				switch (num2 == num)
				{
				}
				num = (short)1149108224;
				short num3 = num;
				num = (short)1154809857;
				if (num != 0)
				{
				}
				num = (short)1431175168;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDynamicZoneScanCapability_42749._HasDiffs;
			}
		}

		// Token: 0x17001D7D RID: 7549
		// (get) Token: 0x060039CE RID: 14798 RVA: 0x0036A448 File Offset: 0x00368648
		// (set) Token: 0x060039CF RID: 14799 RVA: 0x0036A500 File Offset: 0x00368700
		public bool RadioWideDVRSTrunkingStatusCapability_A42772Value
		{
			get
			{
				short num = (short)314766967;
				short num2 = num;
				num = (short)2038560375;
				switch (num2 == num)
				{
				}
				num = (short)332791808;
				short num3 = num;
				num = (short)327221248;
				if (num != 0)
				{
				}
				num = (short)1022689281;
				if (num != 0)
				{
				}
				return this.radioWideDVRSTrunkingStatusCapability_A42772.Value;
			}
			set
			{
				short num = (short)1695105093;
				short num2 = num;
				num = (short)106446917;
				switch (num2 == num)
				{
				}
				num = (short)1561198592;
				short num3 = num;
				num = (short)1764556800;
				if (num != 0)
				{
				}
				num = (short)113508353;
				if (num != 0)
				{
				}
				this.radioWideDVRSTrunkingStatusCapability_A42772.Value = value;
			}
		}

		// Token: 0x17001D7E RID: 7550
		// (get) Token: 0x060039D0 RID: 14800 RVA: 0x0036A5B8 File Offset: 0x003687B8
		public global::AcpBusinessLayer.AcpField<bool> RadioWideDVRSTrunkingStatusCapability_A42772
		{
			get
			{
				short num = (short)1616626934;
				short num2 = num;
				num = (short)884262134;
				switch (num2 == num)
				{
				}
				num = (short)30932992;
				short num3 = num;
				num = (short)1281949696;
				if (num != 0)
				{
				}
				num = (short)1341587457;
				if (num != 0)
				{
				}
				return this.radioWideDVRSTrunkingStatusCapability_A42772;
			}
		}

		// Token: 0x17001D7F RID: 7551
		// (get) Token: 0x060039D1 RID: 14801 RVA: 0x0036A668 File Offset: 0x00368868
		// (set) Token: 0x060039D2 RID: 14802 RVA: 0x0036A71C File Offset: 0x0036891C
		public bool RadioWideDVRSTrunkingStatusCapability_A42772_UIValue
		{
			get
			{
				short num = (short)1800272299;
				short num2 = num;
				num = (short)163051947;
				switch (num2 == num)
				{
				}
				num = (short)1920794624;
				short num3 = num;
				num = (short)842399745;
				if (num != 0)
				{
				}
				num = (short)1782775808;
				if (num != 0)
				{
				}
				return this.radioWideDVRSTrunkingStatusCapability_A42772.Value;
			}
			set
			{
				short num = (short)680327315;
				short num2 = num;
				num = (short)589363347;
				switch (num2 == num)
				{
				}
				num = (short)2012872704;
				short num3 = num;
				num = (short)126287872;
				if (num != 0)
				{
				}
				num = (short)367525889;
				if (num != 0)
				{
				}
				this.radioWideDVRSTrunkingStatusCapability_A42772.Value = value;
			}
		}

		// Token: 0x17001D80 RID: 7552
		// (get) Token: 0x060039D3 RID: 14803 RVA: 0x0036A7D0 File Offset: 0x003689D0
		// (set) Token: 0x060039D4 RID: 14804 RVA: 0x0036A884 File Offset: 0x00368A84
		public bool RadioWideDVRSTrunkingStatusCapability_A42772_Applicable
		{
			get
			{
				short num = (short)136559856;
				short num2 = num;
				num = (short)74366192;
				switch (num2 == num)
				{
				}
				num = (short)1222639616;
				short num3 = num;
				num = (short)1732509697;
				if (num != 0)
				{
				}
				num = (short)1794703360;
				if (num != 0)
				{
				}
				return this.radioWideDVRSTrunkingStatusCapability_A42772.Applicable;
			}
			set
			{
				short num = (short)1948522271;
				short num2 = num;
				num = (short)668604191;
				switch (num2 == num)
				{
				}
				num = (short)802553856;
				short num3 = num;
				num = (short)1224867841;
				if (num != 0)
				{
				}
				num = (short)1883963392;
				if (num != 0)
				{
				}
				this.radioWideDVRSTrunkingStatusCapability_A42772.Applicable = value;
			}
		}

		// Token: 0x17001D81 RID: 7553
		// (get) Token: 0x060039D5 RID: 14805 RVA: 0x0036A93C File Offset: 0x00368B3C
		// (set) Token: 0x060039D6 RID: 14806 RVA: 0x0036A9F0 File Offset: 0x00368BF0
		public bool RadioWideDVRSTrunkingStatusCapability_A42772_Valid
		{
			get
			{
				short num = (short)847397227;
				short num2 = num;
				num = (short)1957773675;
				switch (num2 == num)
				{
				}
				num = (short)1439367168;
				short num3 = num;
				num = (short)301858816;
				if (num != 0)
				{
				}
				num = (short)478674945;
				if (num != 0)
				{
				}
				return this.radioWideDVRSTrunkingStatusCapability_A42772.Valid;
			}
			set
			{
				short num = (short)772879155;
				short num2 = num;
				num = (short)1518678835;
				switch (num2 == num)
				{
				}
				num = (short)242679808;
				short num3 = num;
				num = (short)2007171073;
				if (num != 0)
				{
				}
				num = (short)1973157888;
				if (num != 0)
				{
				}
				this.radioWideDVRSTrunkingStatusCapability_A42772.Valid = value;
			}
		}

		// Token: 0x17001D82 RID: 7554
		// (get) Token: 0x060039D7 RID: 14807 RVA: 0x0036AAA4 File Offset: 0x00368CA4
		// (set) Token: 0x060039D8 RID: 14808 RVA: 0x0036AB58 File Offset: 0x00368D58
		public bool RadioWideDVRSTrunkingStatusCapability_A42772_Visible
		{
			get
			{
				short num = (short)646948279;
				short num2 = num;
				num = (short)321234359;
				switch (num2 == num)
				{
				}
				num = (short)918880256;
				short num3 = num;
				num = (short)399769601;
				if (num != 0)
				{
				}
				num = (short)1140916224;
				if (num != 0)
				{
				}
				return this.radioWideDVRSTrunkingStatusCapability_A42772.Visible;
			}
			set
			{
				short num = (short)938241622;
				short num2 = num;
				num = (short)464940630;
				switch (num2 == num)
				{
				}
				num = (short)694681600;
				short num3 = num;
				num = (short)2016346113;
				if (num != 0)
				{
				}
				num = (short)42860544;
				if (num != 0)
				{
				}
				this.radioWideDVRSTrunkingStatusCapability_A42772.Visible = value;
			}
		}

		// Token: 0x17001D83 RID: 7555
		// (get) Token: 0x060039D9 RID: 14809 RVA: 0x0036AC0C File Offset: 0x00368E0C
		// (set) Token: 0x060039DA RID: 14810 RVA: 0x0036ACC0 File Offset: 0x00368EC0
		public bool RadioWideDVRSTrunkingStatusCapability_A42772_Editable
		{
			get
			{
				short num = (short)1783292428;
				short num2 = num;
				num = (short)705815052;
				switch (num2 == num)
				{
				}
				num = (short)2118385664;
				short num3 = num;
				num = (short)363528193;
				if (num != 0)
				{
				}
				num = (short)1723400192;
				if (num != 0)
				{
				}
				return this.radioWideDVRSTrunkingStatusCapability_A42772.Editable;
			}
			set
			{
				short num = (short)837300085;
				short num2 = num;
				num = (short)1032990581;
				switch (num2 == num)
				{
				}
				num = (short)348389376;
				short num3 = num;
				num = (short)1947467777;
				if (num != 0)
				{
				}
				num = (short)337641472;
				if (num != 0)
				{
				}
				this.radioWideDVRSTrunkingStatusCapability_A42772.Editable = value;
			}
		}

		// Token: 0x17001D84 RID: 7556
		// (get) Token: 0x060039DB RID: 14811 RVA: 0x0036AD78 File Offset: 0x00368F78
		internal string RadioWideDVRSTrunkingStatusCapability_A42772_UILabel
		{
			get
			{
				short num = (short)876254320;
				short num2 = num;
				num = (short)1859097712;
				switch (num2 == num)
				{
				}
				num = (short)1482227712;
				if (num != 0)
				{
				}
				num = (short)1258225665;
				if (num != 0)
				{
				}
				num = (short)2005663744;
				short num3 = num;
				return this.radioWideDVRSTrunkingStatusCapability_A42772.UIName;
			}
		}

		// Token: 0x17001D85 RID: 7557
		// (get) Token: 0x060039DC RID: 14812 RVA: 0x0036AE2C File Offset: 0x0036902C
		// (set) Token: 0x060039DD RID: 14813 RVA: 0x0036AEE4 File Offset: 0x003690E4
		internal bool RadioWideDVRSTrunkingStatusCapability_A42772_HiddenStatic
		{
			get
			{
				short num = (short)1805769405;
				short num2 = num;
				num = (short)1913051837;
				switch (num2 == num)
				{
				}
				num = (short)956760065;
				if (num != 0)
				{
				}
				num = (short)1629224960;
				if (num != 0)
				{
				}
				num = (short)1049821184;
				short num3 = num;
				return this.radioWideDVRSTrunkingStatusCapability_A42772.HiddenStatic;
			}
			set
			{
				short num = (short)451095737;
				short num2 = num;
				num = (short)1610427577;
				switch (num2 == num)
				{
				}
				num = (short)558104577;
				if (num != 0)
				{
				}
				num = (short)1594163200;
				if (num != 0)
				{
				}
				num = (short)1984888832;
				short num3 = num;
				this.radioWideDVRSTrunkingStatusCapability_A42772.HiddenStatic = value;
			}
		}

		// Token: 0x17001D86 RID: 7558
		// (get) Token: 0x060039DE RID: 14814 RVA: 0x0036AF98 File Offset: 0x00369198
		// (set) Token: 0x060039DF RID: 14815 RVA: 0x0036B04C File Offset: 0x0036924C
		internal bool RadioWideDVRSTrunkingStatusCapability_A42772_HiddenDynamic
		{
			get
			{
				short num = (short)1405704903;
				short num2 = num;
				num = (short)1168530119;
				switch (num2 == num)
				{
				}
				num = (short)166723585;
				if (num != 0)
				{
				}
				num = (short)684326912;
				if (num != 0)
				{
				}
				num = (short)649199616;
				short num3 = num;
				return this.radioWideDVRSTrunkingStatusCapability_A42772.HiddenDynamic;
			}
			set
			{
				short num = (short)2016477185;
				if (num != 0)
				{
				}
				num = (short)1438935348;
				short num2 = num;
				num = (short)529033524;
				switch (num2 == num)
				{
				}
				num = (short)714801152;
				if (num != 0)
				{
				}
				num = (short)1706295296;
				short num3 = num;
				this.radioWideDVRSTrunkingStatusCapability_A42772.HiddenDynamic = value;
			}
		}

		// Token: 0x17001D87 RID: 7559
		// (get) Token: 0x060039E0 RID: 14816 RVA: 0x0036B100 File Offset: 0x00369300
		public bool RadioWideDVRSTrunkingStatusCapability_A42772_HasDiffs
		{
			get
			{
				short num = (short)2091858228;
				short num2 = num;
				num = (short)224934196;
				switch (num2 == num)
				{
				}
				num = (short)309395457;
				if (num != 0)
				{
				}
				num = (short)1586167808;
				if (num != 0)
				{
				}
				num = (short)1386217472;
				short num3 = num;
				return this.radioWideDVRSTrunkingStatusCapability_A42772._HasDiffs;
			}
		}

		// Token: 0x17001D88 RID: 7560
		// (get) Token: 0x060039E1 RID: 14817 RVA: 0x0036B1B4 File Offset: 0x003693B4
		// (set) Token: 0x060039E2 RID: 14818 RVA: 0x0036B26C File Offset: 0x0036946C
		public bool RadioWideMOSCADACE3000Capability_A42772Value
		{
			get
			{
				short num = (short)1926823937;
				if (num != 0)
				{
				}
				num = (short)356697889;
				short num2 = num;
				num = (short)950585121;
				switch (num2 == num)
				{
				}
				num = (short)1642463232;
				if (num != 0)
				{
				}
				num = (short)416481280;
				short num3 = num;
				return this.radioWideMOSCADACE3000Capability_A42772.Value;
			}
			set
			{
				short num = (short)610738200;
				short num2 = num;
				num = (short)363667480;
				switch (num2 == num)
				{
				}
				num = (short)978780161;
				if (num != 0)
				{
				}
				num = (short)507641856;
				if (num != 0)
				{
				}
				num = (short)487587840;
				short num3 = num;
				this.radioWideMOSCADACE3000Capability_A42772.Value = value;
			}
		}

		// Token: 0x17001D89 RID: 7561
		// (get) Token: 0x060039E3 RID: 14819 RVA: 0x0036B320 File Offset: 0x00369520
		public global::AcpBusinessLayer.AcpField<bool> RadioWideMOSCADACE3000Capability_A42772
		{
			get
			{
				short num = (short)1615404752;
				short num2 = num;
				num = (short)1130110672;
				switch (num2 == num)
				{
				}
				num = (short)1337196544;
				if (num != 0)
				{
				}
				num = (short)1310851073;
				if (num != 0)
				{
				}
				num = (short)945553408;
				short num3 = num;
				return this.radioWideMOSCADACE3000Capability_A42772;
			}
		}

		// Token: 0x17001D8A RID: 7562
		// (get) Token: 0x060039E4 RID: 14820 RVA: 0x0036B3D4 File Offset: 0x003695D4
		// (set) Token: 0x060039E5 RID: 14821 RVA: 0x0036B484 File Offset: 0x00369684
		public bool RadioWideMOSCADACE3000Capability_A42772_UIValue
		{
			get
			{
				short num = (short)374256184;
				short num2 = num;
				num = (short)605794872;
				switch (num2 == num)
				{
				}
				num = (short)1951989760;
				if (num != 0)
				{
				}
				num = (short)2054356993;
				if (num != 0)
				{
				}
				num = (short)2056978432;
				short num3 = num;
				return this.radioWideMOSCADACE3000Capability_A42772.Value;
			}
			set
			{
				short num = (short)1667000417;
				short num2 = num;
				num = (short)962291809;
				switch (num2 == num)
				{
				}
				num = (short)1335885825;
				if (num != 0)
				{
				}
				num = (short)324075520;
				if (num != 0)
				{
				}
				num = (short)350093312;
				short num3 = num;
				this.radioWideMOSCADACE3000Capability_A42772.Value = value;
			}
		}

		// Token: 0x17001D8B RID: 7563
		// (get) Token: 0x060039E6 RID: 14822 RVA: 0x0036B53C File Offset: 0x0036973C
		// (set) Token: 0x060039E7 RID: 14823 RVA: 0x0036B5F0 File Offset: 0x003697F0
		public bool RadioWideMOSCADACE3000Capability_A42772_Applicable
		{
			get
			{
				short num = (short)1408667259;
				short num2 = num;
				num = (short)761433723;
				switch (num2 == num)
				{
				}
				num = (short)623509504;
				if (num != 0)
				{
				}
				num = (short)1399586817;
				if (num != 0)
				{
				}
				num = (short)484573184;
				short num3 = num;
				return this.radioWideMOSCADACE3000Capability_A42772.Applicable;
			}
			set
			{
				short num = (short)651832430;
				short num2 = num;
				num = (short)552545390;
				switch (num2 == num)
				{
				}
				num = (short)443678721;
				if (num != 0)
				{
				}
				num = (short)1549664256;
				if (num != 0)
				{
				}
				num = (short)1683881984;
				short num3 = num;
				this.radioWideMOSCADACE3000Capability_A42772.Applicable = value;
			}
		}

		// Token: 0x17001D8C RID: 7564
		// (get) Token: 0x060039E8 RID: 14824 RVA: 0x0036B6A8 File Offset: 0x003698A8
		// (set) Token: 0x060039E9 RID: 14825 RVA: 0x0036B75C File Offset: 0x0036995C
		public bool RadioWideMOSCADACE3000Capability_A42772_Valid
		{
			get
			{
				short num = (short)551089122;
				short num2 = num;
				num = (short)1381626850;
				switch (num2 == num)
				{
				}
				num = (short)1754005505;
				if (num != 0)
				{
				}
				num = (short)1620574208;
				if (num != 0)
				{
				}
				num = (short)783024128;
				short num3 = num;
				return this.radioWideMOSCADACE3000Capability_A42772.Valid;
			}
			set
			{
				short num = (short)1235333479;
				short num2 = num;
				num = (short)118600039;
				switch (num2 == num)
				{
				}
				num = (short)565706752;
				if (num != 0)
				{
				}
				num = (short)728825857;
				if (num != 0)
				{
				}
				num = (short)696320000;
				short num3 = num;
				this.radioWideMOSCADACE3000Capability_A42772.Valid = value;
			}
		}

		// Token: 0x17001D8D RID: 7565
		// (get) Token: 0x060039EA RID: 14826 RVA: 0x0036B814 File Offset: 0x00369A14
		// (set) Token: 0x060039EB RID: 14827 RVA: 0x0036B8C8 File Offset: 0x00369AC8
		public bool RadioWideMOSCADACE3000Capability_A42772_Visible
		{
			get
			{
				short num = (short)621779928;
				short num2 = num;
				num = (short)1033280472;
				switch (num2 == num)
				{
				}
				num = (short)1655767041;
				if (num != 0)
				{
				}
				num = (short)1308819456;
				if (num != 0)
				{
				}
				num = (short)1410465792;
				short num3 = num;
				return this.radioWideMOSCADACE3000Capability_A42772.Visible;
			}
			set
			{
				short num = (short)777329921;
				short num2 = num;
				num = (short)1575099649;
				switch (num2 == num)
				{
				}
				num = (short)1007943681;
				if (num != 0)
				{
				}
				num = (short)578879488;
				if (num != 0)
				{
				}
				num = (short)1624375296;
				short num3 = num;
				this.radioWideMOSCADACE3000Capability_A42772.Visible = value;
			}
		}

		// Token: 0x17001D8E RID: 7566
		// (get) Token: 0x060039EC RID: 14828 RVA: 0x0036B980 File Offset: 0x00369B80
		// (set) Token: 0x060039ED RID: 14829 RVA: 0x0036BA38 File Offset: 0x00369C38
		public bool RadioWideMOSCADACE3000Capability_A42772_Editable
		{
			get
			{
				short num = (short)1580706499;
				short num2 = num;
				num = (short)692497091;
				switch (num2 == num)
				{
				}
				num = (short)2133852161;
				if (num != 0)
				{
				}
				num = (short)793051136;
				if (num != 0)
				{
				}
				num = (short)129040384;
				short num3 = num;
				return this.radioWideMOSCADACE3000Capability_A42772.Editable;
			}
			set
			{
				short num = (short)148998548;
				short num2 = num;
				num = (short)366446996;
				switch (num2 == num)
				{
				}
				num = (short)1239482369;
				if (num != 0)
				{
				}
				num = (short)1170997248;
				if (num != 0)
				{
				}
				num = (short)2081095680;
				short num3 = num;
				this.radioWideMOSCADACE3000Capability_A42772.Editable = value;
			}
		}

		// Token: 0x17001D8F RID: 7567
		// (get) Token: 0x060039EE RID: 14830 RVA: 0x0036BAF0 File Offset: 0x00369CF0
		internal string RadioWideMOSCADACE3000Capability_A42772_UILabel
		{
			get
			{
				short num = (short)894414971;
				short num2 = num;
				num = (short)1083420795;
				switch (num2 == num)
				{
				}
				num = (short)1501954049;
				if (num != 0)
				{
				}
				num = (short)1297547264;
				if (num != 0)
				{
				}
				num = (short)649854976;
				short num3 = num;
				return this.radioWideMOSCADACE3000Capability_A42772.UIName;
			}
		}

		// Token: 0x17001D90 RID: 7568
		// (get) Token: 0x060039EF RID: 14831 RVA: 0x0036BBA4 File Offset: 0x00369DA4
		// (set) Token: 0x060039F0 RID: 14832 RVA: 0x0036BC58 File Offset: 0x00369E58
		internal bool RadioWideMOSCADACE3000Capability_A42772_HiddenStatic
		{
			get
			{
				short num = (short)1177701250;
				short num2 = num;
				num = (short)299256706;
				switch (num2 == num)
				{
				}
				num = (short)1355087872;
				if (num != 0)
				{
				}
				num = (short)429785089;
				if (num != 0)
				{
				}
				num = (short)959905792;
				short num3 = num;
				return this.radioWideMOSCADACE3000Capability_A42772.HiddenStatic;
			}
			set
			{
				short num = (short)415190429;
				short num2 = num;
				num = (short)734481821;
				switch (num2 == num)
				{
				}
				num = (short)833486849;
				if (num != 0)
				{
				}
				num = (short)755302400;
				if (num != 0)
				{
				}
				num = (short)1461452800;
				short num3 = num;
				this.radioWideMOSCADACE3000Capability_A42772.HiddenStatic = value;
			}
		}

		// Token: 0x17001D91 RID: 7569
		// (get) Token: 0x060039F1 RID: 14833 RVA: 0x0036BD10 File Offset: 0x00369F10
		// (set) Token: 0x060039F2 RID: 14834 RVA: 0x0036BDC4 File Offset: 0x00369FC4
		internal bool RadioWideMOSCADACE3000Capability_A42772_HiddenDynamic
		{
			get
			{
				short num = (short)1779674558;
				short num2 = num;
				num = (short)1661578686;
				switch (num2 == num)
				{
				}
				num = (short)1419378688;
				if (num != 0)
				{
				}
				num = (short)841547777;
				if (num != 0)
				{
				}
				num = (short)535625728;
				short num3 = num;
				return this.radioWideMOSCADACE3000Capability_A42772.HiddenDynamic;
			}
			set
			{
				short num = (short)610051174;
				short num2 = num;
				num = (short)1325048934;
				switch (num2 == num)
				{
				}
				num = (short)2041577473;
				if (num != 0)
				{
				}
				num = (short)870055936;
				if (num != 0)
				{
				}
				num = (short)240189440;
				short num3 = num;
				this.radioWideMOSCADACE3000Capability_A42772.HiddenDynamic = value;
			}
		}

		// Token: 0x17001D92 RID: 7570
		// (get) Token: 0x060039F3 RID: 14835 RVA: 0x0036BE7C File Offset: 0x0036A07C
		public bool RadioWideMOSCADACE3000Capability_A42772_HasDiffs
		{
			get
			{
				short num = (short)1850911300;
				short num2 = num;
				num = (short)707701316;
				switch (num2 == num)
				{
				}
				num = (short)1003880449;
				if (num != 0)
				{
				}
				num = (short)242614272;
				if (num != 0)
				{
				}
				num = (short)694288384;
				short num3 = num;
				return this.radioWideMOSCADACE3000Capability_A42772._HasDiffs;
			}
		}

		// Token: 0x17001D93 RID: 7571
		// (get) Token: 0x060039F4 RID: 14836 RVA: 0x0036BF30 File Offset: 0x0036A130
		// (set) Token: 0x060039F5 RID: 14837 RVA: 0x0036BFE4 File Offset: 0x0036A1E4
		public string RadioWideReqFWVersion_A42872Value
		{
			get
			{
				short num = (short)1598592937;
				short num2 = num;
				num = (short)685807529;
				switch (num2 == num)
				{
				}
				num = (short)1578237952;
				if (num != 0)
				{
				}
				num = (short)2086797313;
				if (num != 0)
				{
				}
				num = (short)249954304;
				short num3 = num;
				return this.radioWideReqFWVersion_A42872.Value;
			}
			set
			{
				short num = (short)616789374;
				short num2 = num;
				num = (short)1200911742;
				switch (num2 == num)
				{
				}
				num = (short)95748096;
				if (num != 0)
				{
				}
				num = (short)37879809;
				if (num != 0)
				{
				}
				num = (short)1850998784;
				short num3 = num;
				this.radioWideReqFWVersion_A42872.Value = value;
			}
		}

		// Token: 0x17001D94 RID: 7572
		// (get) Token: 0x060039F6 RID: 14838 RVA: 0x0036C098 File Offset: 0x0036A298
		public global::AcpBusinessLayer.AcpField<string> RadioWideReqFWVersion_A42872
		{
			get
			{
				short num = (short)993264067;
				short num2 = num;
				num = (short)1487143363;
				switch (num2 == num)
				{
				}
				num = (short)1844772864;
				if (num != 0)
				{
				}
				num = (short)1116405761;
				if (num != 0)
				{
				}
				num = (short)1413349376;
				short num3 = num;
				return this.radioWideReqFWVersion_A42872;
			}
		}

		// Token: 0x17001D95 RID: 7573
		// (get) Token: 0x060039F7 RID: 14839 RVA: 0x0036C148 File Offset: 0x0036A348
		// (set) Token: 0x060039F8 RID: 14840 RVA: 0x0036C1FC File Offset: 0x0036A3FC
		public string RadioWideReqFWVersion_A42872_UIValue
		{
			get
			{
				short num = (short)1603179707;
				short num2 = num;
				num = (short)172004539;
				switch (num2 == num)
				{
				}
				num = (short)2013134849;
				if (num != 0)
				{
				}
				num = (short)29949952;
				if (num != 0)
				{
				}
				num = (short)190054400;
				short num3 = num;
				return this.radioWideReqFWVersion_A42872.Value;
			}
			set
			{
				short num = (short)1769473;
				if (num != 0)
				{
				}
				num = (short)1616311396;
				short num2 = num;
				num = (short)1678963812;
				switch (num2 == num)
				{
				}
				num = (short)700514304;
				if (num != 0)
				{
				}
				num = (short)2137587712;
				short num3 = num;
				this.radioWideReqFWVersion_A42872.Value = value;
			}
		}

		// Token: 0x17001D96 RID: 7574
		// (get) Token: 0x060039F9 RID: 14841 RVA: 0x0036C2B0 File Offset: 0x0036A4B0
		// (set) Token: 0x060039FA RID: 14842 RVA: 0x0036C368 File Offset: 0x0036A568
		public bool RadioWideReqFWVersion_A42872_Applicable
		{
			get
			{
				short num = (short)757245788;
				short num2 = num;
				num = (short)1948100444;
				switch (num2 == num)
				{
				}
				num = (short)704708609;
				if (num != 0)
				{
				}
				num = (short)985399296;
				if (num != 0)
				{
				}
				num = (short)1911816192;
				short num3 = num;
				return this.radioWideReqFWVersion_A42872.Applicable;
			}
			set
			{
				short num = (short)1964310065;
				short num2 = num;
				num = (short)158268977;
				switch (num2 == num)
				{
				}
				num = (short)765526017;
				if (num != 0)
				{
				}
				num = (short)1875116032;
				if (num != 0)
				{
				}
				num = (short)900202496;
				short num3 = num;
				this.radioWideReqFWVersion_A42872.Applicable = value;
			}
		}

		// Token: 0x17001D97 RID: 7575
		// (get) Token: 0x060039FB RID: 14843 RVA: 0x0036C420 File Offset: 0x0036A620
		// (set) Token: 0x060039FC RID: 14844 RVA: 0x0036C4D8 File Offset: 0x0036A6D8
		public bool RadioWideReqFWVersion_A42872_Valid
		{
			get
			{
				short num = (short)1042113940;
				short num2 = num;
				num = (short)1584620948;
				switch (num2 == num)
				{
				}
				num = (short)361496576;
				if (num != 0)
				{
				}
				num = (short)1933246465;
				if (num != 0)
				{
				}
				num = (short)1581187072;
				short num3 = num;
				return this.radioWideReqFWVersion_A42872.Valid;
			}
			set
			{
				short num = (short)2011976117;
				short num2 = num;
				num = (short)361255349;
				switch (num2 == num)
				{
				}
				num = (short)479789057;
				if (num != 0)
				{
				}
				num = (short)1061748736;
				if (num != 0)
				{
				}
				num = (short)1123876864;
				short num3 = num;
				this.radioWideReqFWVersion_A42872.Valid = value;
			}
		}

		// Token: 0x17001D98 RID: 7576
		// (get) Token: 0x060039FD RID: 14845 RVA: 0x0036C590 File Offset: 0x0036A790
		// (set) Token: 0x060039FE RID: 14846 RVA: 0x0036C644 File Offset: 0x0036A844
		public bool RadioWideReqFWVersion_A42872_Visible
		{
			get
			{
				short num = (short)239271937;
				if (num != 0)
				{
				}
				num = (short)1197758634;
				short num2 = num;
				num = (short)1635145898;
				switch (num2 == num)
				{
				}
				num = (short)1562902528;
				if (num != 0)
				{
				}
				num = (short)519569408;
				short num3 = num;
				return this.radioWideReqFWVersion_A42872.Visible;
			}
			set
			{
				short num = (short)812698928;
				short num2 = num;
				num = (short)835570992;
				switch (num2 == num)
				{
				}
				num = (short)1006764033;
				if (num != 0)
				{
				}
				num = (short)76414976;
				if (num != 0)
				{
				}
				num = (short)883884032;
				short num3 = num;
				this.radioWideReqFWVersion_A42872.Visible = value;
			}
		}

		// Token: 0x17001D99 RID: 7577
		// (get) Token: 0x060039FF RID: 14847 RVA: 0x0036C6F8 File Offset: 0x0036A8F8
		// (set) Token: 0x06003A00 RID: 14848 RVA: 0x0036C7AC File Offset: 0x0036A9AC
		public bool RadioWideReqFWVersion_A42872_Editable
		{
			get
			{
				short num = (short)792201036;
				short num2 = num;
				num = (short)1589118796;
				switch (num2 == num)
				{
				}
				num = (short)465502209;
				if (num != 0)
				{
				}
				num = (short)714801152;
				if (num != 0)
				{
				}
				num = (short)821297152;
				short num3 = num;
				return this.radioWideReqFWVersion_A42872.Editable;
			}
			set
			{
				short num = (short)2080113372;
				short num2 = num;
				num = (short)941949660;
				switch (num2 == num)
				{
				}
				num = (short)953679873;
				if (num != 0)
				{
				}
				num = (short)1358757888;
				if (num != 0)
				{
				}
				num = (short)1190068224;
				short num3 = num;
				this.radioWideReqFWVersion_A42872.Editable = value;
			}
		}

		// Token: 0x17001D9A RID: 7578
		// (get) Token: 0x06003A01 RID: 14849 RVA: 0x0036C860 File Offset: 0x0036AA60
		internal string RadioWideReqFWVersion_A42872_UILabel
		{
			get
			{
				short num = (short)787015844;
				short num2 = num;
				num = (short)878045348;
				switch (num2 == num)
				{
				}
				num = (short)547553280;
				if (num != 0)
				{
				}
				num = (short)2068709377;
				if (num != 0)
				{
				}
				num = (short)588251136;
				short num3 = num;
				return this.radioWideReqFWVersion_A42872.UIName;
			}
		}

		// Token: 0x17001D9B RID: 7579
		// (get) Token: 0x06003A02 RID: 14850 RVA: 0x0036C914 File Offset: 0x0036AB14
		// (set) Token: 0x06003A03 RID: 14851 RVA: 0x0036C9C8 File Offset: 0x0036ABC8
		internal bool RadioWideReqFWVersion_A42872_HiddenStatic
		{
			get
			{
				short num = (short)474009997;
				short num2 = num;
				num = (short)1344655757;
				switch (num2 == num)
				{
				}
				num = (short)1701838849;
				if (num != 0)
				{
				}
				num = (short)2070347776;
				if (num != 0)
				{
				}
				num = (short)1183514624;
				short num3 = num;
				return this.radioWideReqFWVersion_A42872.HiddenStatic;
			}
			set
			{
				short num = (short)1438455406;
				short num2 = num;
				num = (short)2104301166;
				switch (num2 == num)
				{
				}
				num = (short)2111569920;
				if (num != 0)
				{
				}
				num = (short)1270349825;
				if (num != 0)
				{
				}
				num = (short)237174784;
				short num3 = num;
				this.radioWideReqFWVersion_A42872.HiddenStatic = value;
			}
		}

		// Token: 0x17001D9C RID: 7580
		// (get) Token: 0x06003A04 RID: 14852 RVA: 0x0036CA80 File Offset: 0x0036AC80
		// (set) Token: 0x06003A05 RID: 14853 RVA: 0x0036CB30 File Offset: 0x0036AD30
		internal bool RadioWideReqFWVersion_A42872_HiddenDynamic
		{
			get
			{
				short num = (short)278115220;
				short num2 = num;
				num = (short)120828820;
				switch (num2 == num)
				{
				}
				num = (short)152043521;
				if (num != 0)
				{
				}
				num = (short)1276575744;
				if (num != 0)
				{
				}
				num = (short)1611399168;
				short num3 = num;
				return this.radioWideReqFWVersion_A42872.HiddenDynamic;
			}
			set
			{
				short num = (short)1047713702;
				short num2 = num;
				num = (short)1501419430;
				switch (num2 == num)
				{
				}
				num = (short)998834177;
				if (num != 0)
				{
				}
				num = (short)32112640;
				if (num != 0)
				{
				}
				num = (short)1015873536;
				short num3 = num;
				this.radioWideReqFWVersion_A42872.HiddenDynamic = value;
			}
		}

		// Token: 0x17001D9D RID: 7581
		// (get) Token: 0x06003A06 RID: 14854 RVA: 0x0036CBE4 File Offset: 0x0036ADE4
		public bool RadioWideReqFWVersion_A42872_HasDiffs
		{
			get
			{
				short num = (short)1837534733;
				short num2 = num;
				num = (short)1486982669;
				switch (num2 == num)
				{
				}
				num = (short)194904064;
				if (num != 0)
				{
				}
				num = (short)754974721;
				if (num != 0)
				{
				}
				num = (short)1178927104;
				short num3 = num;
				return this.radioWideReqFWVersion_A42872._HasDiffs;
			}
		}

		// Token: 0x17001D9E RID: 7582
		// (get) Token: 0x06003A07 RID: 14855 RVA: 0x0036CC98 File Offset: 0x0036AE98
		// (set) Token: 0x06003A08 RID: 14856 RVA: 0x0036CD4C File Offset: 0x0036AF4C
		public bool RadWideLabtoolPAAlertCapability_A42944Value
		{
			get
			{
				short num = (short)719281300;
				short num2 = num;
				num = (short)1322736788;
				switch (num2 == num)
				{
				}
				num = (short)585695233;
				if (num != 0)
				{
				}
				num = (short)902496256;
				if (num != 0)
				{
				}
				num = (short)582811648;
				short num3 = num;
				return this.radWideLabtoolPAAlertCapability_A42944.Value;
			}
			set
			{
				short num = (short)1034644272;
				short num2 = num;
				num = (short)264530736;
				switch (num2 == num)
				{
				}
				num = (short)1881997313;
				if (num != 0)
				{
				}
				num = (short)1887502336;
				if (num != 0)
				{
				}
				num = (short)395771904;
				short num3 = num;
				this.radWideLabtoolPAAlertCapability_A42944.Value = value;
			}
		}

		// Token: 0x17001D9F RID: 7583
		// (get) Token: 0x06003A09 RID: 14857 RVA: 0x0036CE00 File Offset: 0x0036B000
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolPAAlertCapability_A42944
		{
			get
			{
				short num = (short)538627108;
				short num2 = num;
				num = (short)868666404;
				switch (num2 == num)
				{
				}
				num = (short)1733689345;
				if (num != 0)
				{
				}
				num = (short)1643642880;
				if (num != 0)
				{
				}
				num = (short)38273024;
				short num3 = num;
				return this.radWideLabtoolPAAlertCapability_A42944;
			}
		}

		// Token: 0x17001DA0 RID: 7584
		// (get) Token: 0x06003A0A RID: 14858 RVA: 0x0036CEB0 File Offset: 0x0036B0B0
		// (set) Token: 0x06003A0B RID: 14859 RVA: 0x0036CF68 File Offset: 0x0036B168
		public bool RadWideLabtoolPAAlertCapability_A42944_UIValue
		{
			get
			{
				short num = (short)1320601870;
				short num2 = num;
				num = (short)2018691342;
				switch (num2 == num)
				{
				}
				num = (short)157679616;
				if (num != 0)
				{
				}
				num = (short)1368653825;
				if (num != 0)
				{
				}
				num = (short)559349760;
				short num3 = num;
				return this.radWideLabtoolPAAlertCapability_A42944.Value;
			}
			set
			{
				short num = (short)892167608;
				short num2 = num;
				num = (short)753821112;
				switch (num2 == num)
				{
				}
				num = (short)1801060352;
				if (num != 0)
				{
				}
				num = (short)31719425;
				if (num != 0)
				{
				}
				num = (short)1900281856;
				short num3 = num;
				this.radWideLabtoolPAAlertCapability_A42944.Value = value;
			}
		}

		// Token: 0x17001DA1 RID: 7585
		// (get) Token: 0x06003A0C RID: 14860 RVA: 0x0036D020 File Offset: 0x0036B220
		// (set) Token: 0x06003A0D RID: 14861 RVA: 0x0036D0D4 File Offset: 0x0036B2D4
		public bool RadWideLabtoolPAAlertCapability_A42944_Applicable
		{
			get
			{
				short num = (short)819504530;
				short num2 = num;
				num = (short)632858002;
				switch (num2 == num)
				{
				}
				num = (short)778502145;
				if (num != 0)
				{
				}
				num = (short)794296320;
				if (num != 0)
				{
				}
				num = (short)849805312;
				short num3 = num;
				return this.radWideLabtoolPAAlertCapability_A42944.Applicable;
			}
			set
			{
				short num = (short)899022849;
				if (num != 0)
				{
				}
				num = (short)1261573681;
				short num2 = num;
				num = (short)2083264049;
				switch (num2 == num)
				{
				}
				num = (short)1324875776;
				if (num != 0)
				{
				}
				num = (short)1872035840;
				short num3 = num;
				this.radWideLabtoolPAAlertCapability_A42944.Applicable = value;
			}
		}

		// Token: 0x17001DA2 RID: 7586
		// (get) Token: 0x06003A0E RID: 14862 RVA: 0x0036D18C File Offset: 0x0036B38C
		// (set) Token: 0x06003A0F RID: 14863 RVA: 0x0036D23C File Offset: 0x0036B43C
		public bool RadWideLabtoolPAAlertCapability_A42944_Valid
		{
			get
			{
				short num = (short)1013250803;
				short num2 = num;
				num = (short)314112755;
				switch (num2 == num)
				{
				}
				num = (short)1724252161;
				if (num != 0)
				{
				}
				num = (short)1494548480;
				if (num != 0)
				{
				}
				num = (short)1125842944;
				short num3 = num;
				return this.radWideLabtoolPAAlertCapability_A42944.Valid;
			}
			set
			{
				short num = (short)380960769;
				if (num != 0)
				{
				}
				num = (short)795468994;
				short num2 = num;
				num = (short)816768194;
				switch (num2 == num)
				{
				}
				num = (short)1431371776;
				if (num != 0)
				{
				}
				num = (short)817889280;
				short num3 = num;
				this.radWideLabtoolPAAlertCapability_A42944.Valid = value;
			}
		}

		// Token: 0x17001DA3 RID: 7587
		// (get) Token: 0x06003A10 RID: 14864 RVA: 0x0036D2F0 File Offset: 0x0036B4F0
		// (set) Token: 0x06003A11 RID: 14865 RVA: 0x0036D3A8 File Offset: 0x0036B5A8
		public bool RadWideLabtoolPAAlertCapability_A42944_Visible
		{
			get
			{
				short num = (short)1370882049;
				if (num != 0)
				{
				}
				num = (short)848179600;
				short num2 = num;
				num = (short)493302160;
				switch (num2 == num)
				{
				}
				num = (short)431751168;
				if (num != 0)
				{
				}
				num = (short)1774583808;
				short num3 = num;
				return this.radWideLabtoolPAAlertCapability_A42944.Visible;
			}
			set
			{
				short num = (short)197387250;
				short num2 = num;
				num = (short)1849484274;
				switch (num2 == num)
				{
				}
				num = (short)2033647617;
				if (num != 0)
				{
				}
				num = (short)675348480;
				if (num != 0)
				{
				}
				num = (short)848822272;
				short num3 = num;
				this.radWideLabtoolPAAlertCapability_A42944.Visible = value;
			}
		}

		// Token: 0x17001DA4 RID: 7588
		// (get) Token: 0x06003A12 RID: 14866 RVA: 0x0036D45C File Offset: 0x0036B65C
		// (set) Token: 0x06003A13 RID: 14867 RVA: 0x0036D510 File Offset: 0x0036B710
		public bool RadWideLabtoolPAAlertCapability_A42944_Editable
		{
			get
			{
				short num = (short)750995154;
				short num2 = num;
				num = (short)445859538;
				switch (num2 == num)
				{
				}
				num = (short)214499328;
				if (num != 0)
				{
				}
				num = (short)82051073;
				if (num != 0)
				{
				}
				num = (short)1112080384;
				short num3 = num;
				return this.radWideLabtoolPAAlertCapability_A42944.Editable;
			}
			set
			{
				short num = (short)518597886;
				short num2 = num;
				num = (short)2047225086;
				switch (num2 == num)
				{
				}
				num = (short)600047616;
				if (num != 0)
				{
				}
				num = (short)1287454721;
				if (num != 0)
				{
				}
				num = (short)1976827904;
				short num3 = num;
				this.radWideLabtoolPAAlertCapability_A42944.Editable = value;
			}
		}

		// Token: 0x17001DA5 RID: 7589
		// (get) Token: 0x06003A14 RID: 14868 RVA: 0x0036D5C8 File Offset: 0x0036B7C8
		internal string RadWideLabtoolPAAlertCapability_A42944_UILabel
		{
			get
			{
				short num = (short)870156371;
				short num2 = num;
				num = (short)146376787;
				switch (num2 == num)
				{
				}
				num = (short)2007236609;
				if (num != 0)
				{
				}
				num = (short)975372288;
				if (num != 0)
				{
				}
				num = (short)142868480;
				short num3 = num;
				return this.radWideLabtoolPAAlertCapability_A42944.UIName;
			}
		}

		// Token: 0x17001DA6 RID: 7590
		// (get) Token: 0x06003A15 RID: 14869 RVA: 0x0036D67C File Offset: 0x0036B87C
		// (set) Token: 0x06003A16 RID: 14870 RVA: 0x0036D730 File Offset: 0x0036B930
		internal bool RadWideLabtoolPAAlertCapability_A42944_HiddenStatic
		{
			get
			{
				short num = (short)1495969922;
				short num2 = num;
				num = (short)1628549250;
				switch (num2 == num)
				{
				}
				num = (short)535166977;
				if (num != 0)
				{
				}
				num = (short)1926430720;
				if (num != 0)
				{
				}
				num = (short)392560640;
				short num3 = num;
				return this.radWideLabtoolPAAlertCapability_A42944.HiddenStatic;
			}
			set
			{
				short num = (short)1788858762;
				short num2 = num;
				num = (short)1944506762;
				switch (num2 == num)
				{
				}
				num = (short)41549825;
				if (num != 0)
				{
				}
				num = (short)541065216;
				if (num != 0)
				{
				}
				num = (short)422707200;
				short num3 = num;
				this.radWideLabtoolPAAlertCapability_A42944.HiddenStatic = value;
			}
		}

		// Token: 0x17001DA7 RID: 7591
		// (get) Token: 0x06003A17 RID: 14871 RVA: 0x0036D7E4 File Offset: 0x0036B9E4
		// (set) Token: 0x06003A18 RID: 14872 RVA: 0x0036D898 File Offset: 0x0036BA98
		internal bool RadWideLabtoolPAAlertCapability_A42944_HiddenDynamic
		{
			get
			{
				short num = (short)848413621;
				short num2 = num;
				num = (short)1602143157;
				switch (num2 == num)
				{
				}
				num = (short)505151489;
				if (num != 0)
				{
				}
				num = (short)948633600;
				if (num != 0)
				{
				}
				num = (short)1732902912;
				short num3 = num;
				return this.radWideLabtoolPAAlertCapability_A42944.HiddenDynamic;
			}
			set
			{
				short num = (short)137741662;
				short num2 = num;
				num = (short)147375454;
				switch (num2 == num)
				{
				}
				num = (short)1897136129;
				if (num != 0)
				{
				}
				num = (short)1269301248;
				if (num != 0)
				{
				}
				num = (short)2022506496;
				short num3 = num;
				this.radWideLabtoolPAAlertCapability_A42944.HiddenDynamic = value;
			}
		}

		// Token: 0x17001DA8 RID: 7592
		// (get) Token: 0x06003A19 RID: 14873 RVA: 0x0036D950 File Offset: 0x0036BB50
		public bool RadWideLabtoolPAAlertCapability_A42944_HasDiffs
		{
			get
			{
				short num = (short)1858600961;
				if (num != 0)
				{
				}
				num = (short)2046266204;
				short num2 = num;
				num = (short)2065861468;
				switch (num2 == num)
				{
				}
				num = (short)286064640;
				if (num != 0)
				{
				}
				num = (short)2076639232;
				short num3 = num;
				return this.radWideLabtoolPAAlertCapability_A42944._HasDiffs;
			}
		}

		// Token: 0x17001DA9 RID: 7593
		// (get) Token: 0x06003A1A RID: 14874 RVA: 0x0036DA08 File Offset: 0x0036BC08
		// (set) Token: 0x06003A1B RID: 14875 RVA: 0x0036DAC0 File Offset: 0x0036BCC0
		public bool RadWideLabtoolUserSelectablePLEnhancement_43031Value
		{
			get
			{
				short num = (short)192686700;
				short num2 = num;
				num = (short)1743137388;
				switch (num2 == num)
				{
				}
				num = (short)793051136;
				if (num != 0)
				{
				}
				num = (short)751763457;
				if (num != 0)
				{
				}
				num = (short)2038366208;
				short num3 = num;
				return this.radWideLabtoolUserSelectablePLEnhancement_43031.Value;
			}
			set
			{
				short num = (short)2037189340;
				short num2 = num;
				num = (short)215878364;
				switch (num2 == num)
				{
				}
				num = (short)1940455425;
				if (num != 0)
				{
				}
				num = (short)1807482880;
				if (num != 0)
				{
				}
				num = (short)635240448;
				short num3 = num;
				this.radWideLabtoolUserSelectablePLEnhancement_43031.Value = value;
			}
		}

		// Token: 0x17001DAA RID: 7594
		// (get) Token: 0x06003A1C RID: 14876 RVA: 0x0036DB74 File Offset: 0x0036BD74
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolUserSelectablePLEnhancement_43031
		{
			get
			{
				short num = (short)774635521;
				if (num != 0)
				{
				}
				num = (short)664955440;
				short num2 = num;
				num = (short)1379756592;
				switch (num2 == num)
				{
				}
				num = (short)1394081792;
				if (num != 0)
				{
				}
				num = (short)1162870784;
				short num3 = num;
				return this.radWideLabtoolUserSelectablePLEnhancement_43031;
			}
		}

		// Token: 0x17001DAB RID: 7595
		// (get) Token: 0x06003A1D RID: 14877 RVA: 0x0036DC24 File Offset: 0x0036BE24
		// (set) Token: 0x06003A1E RID: 14878 RVA: 0x0036DCD8 File Offset: 0x0036BED8
		public bool RadWideLabtoolUserSelectablePLEnhancement_43031_UIValue
		{
			get
			{
				short num = (short)1388445697;
				if (num != 0)
				{
				}
				num = (short)1185360102;
				short num2 = num;
				num = (short)1388587238;
				switch (num2 == num)
				{
				}
				num = (short)2125004800;
				if (num != 0)
				{
				}
				num = (short)1883111424;
				short num3 = num;
				return this.radWideLabtoolUserSelectablePLEnhancement_43031.Value;
			}
			set
			{
				short num = (short)82696889;
				short num2 = num;
				num = (short)1972886201;
				switch (num2 == num)
				{
				}
				num = (short)257622017;
				if (num != 0)
				{
				}
				num = (short)1926889472;
				if (num != 0)
				{
				}
				num = (short)1301151744;
				short num3 = num;
				this.radWideLabtoolUserSelectablePLEnhancement_43031.Value = value;
			}
		}

		// Token: 0x17001DAC RID: 7596
		// (get) Token: 0x06003A1F RID: 14879 RVA: 0x0036DD8C File Offset: 0x0036BF8C
		// (set) Token: 0x06003A20 RID: 14880 RVA: 0x0036DE40 File Offset: 0x0036C040
		public bool RadWideLabtoolUserSelectablePLEnhancement_43031_Applicable
		{
			get
			{
				short num = (short)1317837624;
				short num2 = num;
				num = (short)178690872;
				switch (num2 == num)
				{
				}
				num = (short)1148583937;
				if (num != 0)
				{
				}
				num = (short)1548877824;
				if (num != 0)
				{
				}
				num = (short)459669504;
				short num3 = num;
				return this.radWideLabtoolUserSelectablePLEnhancement_43031.Applicable;
			}
			set
			{
				short num = (short)458351670;
				short num2 = num;
				num = (short)590275638;
				switch (num2 == num)
				{
				}
				num = (short)203948033;
				if (num != 0)
				{
				}
				num = (short)711983104;
				if (num != 0)
				{
				}
				num = (short)1416953856;
				short num3 = num;
				this.radWideLabtoolUserSelectablePLEnhancement_43031.Applicable = value;
			}
		}

		// Token: 0x17001DAD RID: 7597
		// (get) Token: 0x06003A21 RID: 14881 RVA: 0x0036DEF8 File Offset: 0x0036C0F8
		// (set) Token: 0x06003A22 RID: 14882 RVA: 0x0036DFA8 File Offset: 0x0036C1A8
		public bool RadWideLabtoolUserSelectablePLEnhancement_43031_Valid
		{
			get
			{
				short num = (short)524615681;
				if (num != 0)
				{
				}
				num = (short)631739531;
				short num2 = num;
				num = (short)433558667;
				switch (num2 == num)
				{
				}
				num = (short)314638336;
				if (num != 0)
				{
				}
				num = (short)1864105984;
				short num3 = num;
				return this.radWideLabtoolUserSelectablePLEnhancement_43031.Valid;
			}
			set
			{
				short num = (short)1252203045;
				short num2 = num;
				num = (short)1040849445;
				switch (num2 == num)
				{
				}
				num = (short)2131427329;
				if (num != 0)
				{
				}
				num = (short)1170538496;
				if (num != 0)
				{
				}
				num = (short)986906624;
				short num3 = num;
				this.radWideLabtoolUserSelectablePLEnhancement_43031.Valid = value;
			}
		}

		// Token: 0x17001DAE RID: 7598
		// (get) Token: 0x06003A23 RID: 14883 RVA: 0x0036E060 File Offset: 0x0036C260
		// (set) Token: 0x06003A24 RID: 14884 RVA: 0x0036E118 File Offset: 0x0036C318
		public bool RadWideLabtoolUserSelectablePLEnhancement_43031_Visible
		{
			get
			{
				short num = (short)1961280031;
				short num2 = num;
				num = (short)476561951;
				switch (num2 == num)
				{
				}
				num = (short)919994368;
				if (num != 0)
				{
				}
				num = (short)1828061185;
				if (num != 0)
				{
				}
				num = (short)582877184;
				short num3 = num;
				return this.radWideLabtoolUserSelectablePLEnhancement_43031.Visible;
			}
			set
			{
				short num = (short)908769286;
				short num2 = num;
				num = (short)40613894;
				switch (num2 == num)
				{
				}
				num = (short)1638006785;
				if (num != 0)
				{
				}
				num = (short)491847680;
				if (num != 0)
				{
				}
				num = (short)1498546176;
				short num3 = num;
				this.radWideLabtoolUserSelectablePLEnhancement_43031.Visible = value;
			}
		}

		// Token: 0x17001DAF RID: 7599
		// (get) Token: 0x06003A25 RID: 14885 RVA: 0x0036E1CC File Offset: 0x0036C3CC
		// (set) Token: 0x06003A26 RID: 14886 RVA: 0x0036E284 File Offset: 0x0036C484
		public bool RadWideLabtoolUserSelectablePLEnhancement_43031_Editable
		{
			get
			{
				short num = (short)1545116173;
				short num2 = num;
				num = (short)227777037;
				switch (num2 == num)
				{
				}
				num = (short)862912513;
				if (num != 0)
				{
				}
				num = (short)796917760;
				if (num != 0)
				{
				}
				num = (short)1253310464;
				short num3 = num;
				return this.radWideLabtoolUserSelectablePLEnhancement_43031.Editable;
			}
			set
			{
				short num = (short)1246074862;
				short num2 = num;
				num = (short)1948817390;
				switch (num2 == num)
				{
				}
				num = (short)419758081;
				if (num != 0)
				{
				}
				num = (short)1311703040;
				if (num != 0)
				{
				}
				num = (short)997064704;
				short num3 = num;
				this.radWideLabtoolUserSelectablePLEnhancement_43031.Editable = value;
			}
		}

		// Token: 0x17001DB0 RID: 7600
		// (get) Token: 0x06003A27 RID: 14887 RVA: 0x0036E33C File Offset: 0x0036C53C
		internal string RadWideLabtoolUserSelectablePLEnhancement_43031_UILabel
		{
			get
			{
				short num = (short)1809675767;
				short num2 = num;
				num = (short)735278583;
				switch (num2 == num)
				{
				}
				num = (short)2145517568;
				if (num != 0)
				{
				}
				num = (short)2037186561;
				if (num != 0)
				{
				}
				num = (short)1073610752;
				short num3 = num;
				return this.radWideLabtoolUserSelectablePLEnhancement_43031.UIName;
			}
		}

		// Token: 0x17001DB1 RID: 7601
		// (get) Token: 0x06003A28 RID: 14888 RVA: 0x0036E3F0 File Offset: 0x0036C5F0
		// (set) Token: 0x06003A29 RID: 14889 RVA: 0x0036E4A4 File Offset: 0x0036C6A4
		internal bool RadWideLabtoolUserSelectablePLEnhancement_43031_HiddenStatic
		{
			get
			{
				short num = (short)496443313;
				short num2 = num;
				num = (short)945692593;
				switch (num2 == num)
				{
				}
				num = (short)1123680256;
				if (num != 0)
				{
				}
				num = (short)1750138881;
				if (num != 0)
				{
				}
				num = (short)1277100032;
				short num3 = num;
				return this.radWideLabtoolUserSelectablePLEnhancement_43031.HiddenStatic;
			}
			set
			{
				short num = (short)1350911954;
				short num2 = num;
				num = (short)999835602;
				switch (num2 == num)
				{
				}
				num = (short)1191378945;
				if (num != 0)
				{
				}
				num = (short)718012416;
				if (num != 0)
				{
				}
				num = (short)1639383040;
				short num3 = num;
				this.radWideLabtoolUserSelectablePLEnhancement_43031.HiddenStatic = value;
			}
		}

		// Token: 0x17001DB2 RID: 7602
		// (get) Token: 0x06003A2A RID: 14890 RVA: 0x0036E55C File Offset: 0x0036C75C
		// (set) Token: 0x06003A2B RID: 14891 RVA: 0x0036E614 File Offset: 0x0036C814
		internal bool RadWideLabtoolUserSelectablePLEnhancement_43031_HiddenDynamic
		{
			get
			{
				short num = (short)176111380;
				short num2 = num;
				num = (short)1015562004;
				switch (num2 == num)
				{
				}
				num = (short)356974592;
				if (num != 0)
				{
				}
				num = (short)154009601;
				if (num != 0)
				{
				}
				num = (short)1249378304;
				short num3 = num;
				return this.radWideLabtoolUserSelectablePLEnhancement_43031.HiddenDynamic;
			}
			set
			{
				short num = (short)1927334789;
				short num2 = num;
				num = (short)1513606021;
				switch (num2 == num)
				{
				}
				num = (short)1718550529;
				if (num != 0)
				{
				}
				num = (short)461701120;
				if (num != 0)
				{
				}
				num = (short)446693376;
				short num3 = num;
				this.radWideLabtoolUserSelectablePLEnhancement_43031.HiddenDynamic = value;
			}
		}

		// Token: 0x17001DB3 RID: 7603
		// (get) Token: 0x06003A2C RID: 14892 RVA: 0x0036E6CC File Offset: 0x0036C8CC
		public bool RadWideLabtoolUserSelectablePLEnhancement_43031_HasDiffs
		{
			get
			{
				short num = (short)286960751;
				short num2 = num;
				num = (short)708226159;
				switch (num2 == num)
				{
				}
				num = (short)2085879808;
				if (num != 0)
				{
				}
				num = (short)597950465;
				if (num != 0)
				{
				}
				num = (short)596180992;
				short num3 = num;
				return this.radWideLabtoolUserSelectablePLEnhancement_43031._HasDiffs;
			}
		}

		// Token: 0x17001DB4 RID: 7604
		// (get) Token: 0x06003A2D RID: 14893 RVA: 0x0036E780 File Offset: 0x0036C980
		// (set) Token: 0x06003A2E RID: 14894 RVA: 0x0036E838 File Offset: 0x0036CA38
		public bool RadWideLabtoolConsolidatedActionEnhancement_A43036Value
		{
			get
			{
				short num = (short)539754497;
				if (num != 0)
				{
				}
				num = (short)695507978;
				short num2 = num;
				num = (short)1507105802;
				switch (num2 == num)
				{
				}
				num = (short)2123628544;
				if (num != 0)
				{
				}
				num = (short)289669120;
				short num3 = num;
				return this.radWideLabtoolConsolidatedActionEnhancement_A43036.Value;
			}
			set
			{
				short num = (short)975171368;
				short num2 = num;
				num = (short)1254420264;
				switch (num2 == num)
				{
				}
				num = (short)82706433;
				if (num != 0)
				{
				}
				num = (short)417136640;
				if (num != 0)
				{
				}
				num = (short)807600128;
				short num3 = num;
				this.radWideLabtoolConsolidatedActionEnhancement_A43036.Value = value;
			}
		}

		// Token: 0x17001DB5 RID: 7605
		// (get) Token: 0x06003A2F RID: 14895 RVA: 0x0036E8F0 File Offset: 0x0036CAF0
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolConsolidatedActionEnhancement_A43036
		{
			get
			{
				short num = (short)944168498;
				short num2 = num;
				num = (short)1259200050;
				switch (num2 == num)
				{
				}
				num = (short)1160708096;
				if (num != 0)
				{
				}
				num = (short)1935212545;
				if (num != 0)
				{
				}
				num = (short)598671360;
				short num3 = num;
				return this.radWideLabtoolConsolidatedActionEnhancement_A43036;
			}
		}

		// Token: 0x17001DB6 RID: 7606
		// (get) Token: 0x06003A30 RID: 14896 RVA: 0x0036E9A4 File Offset: 0x0036CBA4
		// (set) Token: 0x06003A31 RID: 14897 RVA: 0x0036EA5C File Offset: 0x0036CC5C
		public bool RadWideLabtoolConsolidatedActionEnhancement_A43036_UIValue
		{
			get
			{
				short num = (short)1481092200;
				short num2 = num;
				num = (short)1899801704;
				switch (num2 == num)
				{
				}
				num = (short)998572032;
				if (num != 0)
				{
				}
				num = (short)669188097;
				if (num != 0)
				{
				}
				num = (short)1984954368;
				short num3 = num;
				return this.radWideLabtoolConsolidatedActionEnhancement_A43036.Value;
			}
			set
			{
				short num = (short)2050627950;
				short num2 = num;
				num = (short)1842682222;
				switch (num2 == num)
				{
				}
				num = (short)1802043393;
				if (num != 0)
				{
				}
				num = (short)1522794496;
				if (num != 0)
				{
				}
				num = (short)853016576;
				short num3 = num;
				this.radWideLabtoolConsolidatedActionEnhancement_A43036.Value = value;
			}
		}

		// Token: 0x17001DB7 RID: 7607
		// (get) Token: 0x06003A32 RID: 14898 RVA: 0x0036EB10 File Offset: 0x0036CD10
		// (set) Token: 0x06003A33 RID: 14899 RVA: 0x0036EBC4 File Offset: 0x0036CDC4
		public bool RadWideLabtoolConsolidatedActionEnhancement_A43036_Applicable
		{
			get
			{
				short num = (short)627651588;
				short num2 = num;
				num = (short)88617988;
				switch (num2 == num)
				{
				}
				num = (short)1225326592;
				if (num != 0)
				{
				}
				num = (short)1314258945;
				if (num != 0)
				{
				}
				num = (short)1574961152;
				short num3 = num;
				return this.radWideLabtoolConsolidatedActionEnhancement_A43036.Applicable;
			}
			set
			{
				short num = (short)1931767234;
				short num2 = num;
				num = (short)408710594;
				switch (num2 == num)
				{
				}
				num = (short)5767169;
				if (num != 0)
				{
				}
				num = (short)587988992;
				if (num != 0)
				{
				}
				num = (short)672006144;
				short num3 = num;
				this.radWideLabtoolConsolidatedActionEnhancement_A43036.Applicable = value;
			}
		}

		// Token: 0x17001DB8 RID: 7608
		// (get) Token: 0x06003A34 RID: 14900 RVA: 0x0036EC7C File Offset: 0x0036CE7C
		// (set) Token: 0x06003A35 RID: 14901 RVA: 0x0036ED30 File Offset: 0x0036CF30
		public bool RadWideLabtoolConsolidatedActionEnhancement_A43036_Valid
		{
			get
			{
				short num = (short)1602097623;
				short num2 = num;
				num = (short)665719255;
				switch (num2 == num)
				{
				}
				num = (short)898695169;
				if (num != 0)
				{
				}
				num = (short)1774190592;
				if (num != 0)
				{
				}
				num = (short)1157365760;
				short num3 = num;
				return this.radWideLabtoolConsolidatedActionEnhancement_A43036.Valid;
			}
			set
			{
				short num = (short)1808375858;
				short num2 = num;
				num = (short)843358258;
				switch (num2 == num)
				{
				}
				num = (short)1976762369;
				if (num != 0)
				{
				}
				num = (short)1863188480;
				if (num != 0)
				{
				}
				num = (short)1143013376;
				short num3 = num;
				this.radWideLabtoolConsolidatedActionEnhancement_A43036.Valid = value;
			}
		}

		// Token: 0x17001DB9 RID: 7609
		// (get) Token: 0x06003A36 RID: 14902 RVA: 0x0036EDE4 File Offset: 0x0036CFE4
		// (set) Token: 0x06003A37 RID: 14903 RVA: 0x0036EE98 File Offset: 0x0036D098
		public bool RadWideLabtoolConsolidatedActionEnhancement_A43036_Visible
		{
			get
			{
				short num = (short)2033876729;
				short num2 = num;
				num = (short)1204387577;
				switch (num2 == num)
				{
				}
				num = (short)1562574849;
				if (num != 0)
				{
				}
				num = (short)843579392;
				if (num != 0)
				{
				}
				num = (short)1521156096;
				short num3 = num;
				return this.radWideLabtoolConsolidatedActionEnhancement_A43036.Visible;
			}
			set
			{
				short num = (short)1790464601;
				short num2 = num;
				num = (short)1189302873;
				switch (num2 == num)
				{
				}
				num = (short)1390542849;
				if (num != 0)
				{
				}
				num = (short)433651712;
				if (num != 0)
				{
				}
				num = (short)806813696;
				short num3 = num;
				this.radWideLabtoolConsolidatedActionEnhancement_A43036.Visible = value;
			}
		}

		// Token: 0x17001DBA RID: 7610
		// (get) Token: 0x06003A38 RID: 14904 RVA: 0x0036EF50 File Offset: 0x0036D150
		// (set) Token: 0x06003A39 RID: 14905 RVA: 0x0036F004 File Offset: 0x0036D204
		public bool RadWideLabtoolConsolidatedActionEnhancement_A43036_Editable
		{
			get
			{
				short num = (short)449517337;
				short num2 = num;
				num = (short)1793791769;
				switch (num2 == num)
				{
				}
				num = (short)2145124353;
				if (num != 0)
				{
				}
				num = (short)1314717696;
				if (num != 0)
				{
				}
				num = (short)1875312640;
				short num3 = num;
				return this.radWideLabtoolConsolidatedActionEnhancement_A43036.Editable;
			}
			set
			{
				short num = (short)460590551;
				short num2 = num;
				num = (short)286199255;
				switch (num2 == num)
				{
				}
				num = (short)1282605056;
				if (num != 0)
				{
				}
				num = (short)380960769;
				if (num != 0)
				{
				}
				num = (short)513277952;
				short num3 = num;
				this.radWideLabtoolConsolidatedActionEnhancement_A43036.Editable = value;
			}
		}

		// Token: 0x17001DBB RID: 7611
		// (get) Token: 0x06003A3A RID: 14906 RVA: 0x0036F0B8 File Offset: 0x0036D2B8
		internal string RadWideLabtoolConsolidatedActionEnhancement_A43036_UILabel
		{
			get
			{
				short num = (short)1502040336;
				short num2 = num;
				num = (short)719278352;
				switch (num2 == num)
				{
				}
				num = (short)1872166912;
				if (num != 0)
				{
				}
				num = (short)630915073;
				if (num != 0)
				{
				}
				num = (short)999620608;
				short num3 = num;
				return this.radWideLabtoolConsolidatedActionEnhancement_A43036.UIName;
			}
		}

		// Token: 0x17001DBC RID: 7612
		// (get) Token: 0x06003A3B RID: 14907 RVA: 0x0036F16C File Offset: 0x0036D36C
		// (set) Token: 0x06003A3C RID: 14908 RVA: 0x0036F220 File Offset: 0x0036D420
		internal bool RadWideLabtoolConsolidatedActionEnhancement_A43036_HiddenStatic
		{
			get
			{
				short num = (short)1745299511;
				short num2 = num;
				num = (short)456796215;
				switch (num2 == num)
				{
				}
				num = (short)1841889281;
				if (num != 0)
				{
				}
				num = (short)1671102464;
				if (num != 0)
				{
				}
				num = (short)1713373184;
				short num3 = num;
				return this.radWideLabtoolConsolidatedActionEnhancement_A43036.HiddenStatic;
			}
			set
			{
				short num = (short)1448717625;
				short num2 = num;
				num = (short)650816825;
				switch (num2 == num)
				{
				}
				num = (short)1989541889;
				if (num != 0)
				{
				}
				num = (short)72417280;
				if (num != 0)
				{
				}
				num = (short)470876160;
				short num3 = num;
				this.radWideLabtoolConsolidatedActionEnhancement_A43036.HiddenStatic = value;
			}
		}

		// Token: 0x17001DBD RID: 7613
		// (get) Token: 0x06003A3D RID: 14909 RVA: 0x0036F2D8 File Offset: 0x0036D4D8
		// (set) Token: 0x06003A3E RID: 14910 RVA: 0x0036F38C File Offset: 0x0036D58C
		internal bool RadWideLabtoolConsolidatedActionEnhancement_A43036_HiddenDynamic
		{
			get
			{
				short num = (short)895058737;
				short num2 = num;
				num = (short)1019183921;
				switch (num2 == num)
				{
				}
				num = (short)1598947329;
				if (num != 0)
				{
				}
				num = (short)1097924608;
				if (num != 0)
				{
				}
				num = (short)445841408;
				short num3 = num;
				return this.radWideLabtoolConsolidatedActionEnhancement_A43036.HiddenDynamic;
			}
			set
			{
				short num = (short)659485283;
				short num2 = num;
				num = (short)1853157987;
				switch (num2 == num)
				{
				}
				num = (short)92798977;
				if (num != 0)
				{
				}
				num = (short)1315962880;
				if (num != 0)
				{
				}
				num = (short)2060124160;
				short num3 = num;
				this.radWideLabtoolConsolidatedActionEnhancement_A43036.HiddenDynamic = value;
			}
		}

		// Token: 0x17001DBE RID: 7614
		// (get) Token: 0x06003A3F RID: 14911 RVA: 0x0036F440 File Offset: 0x0036D640
		public bool RadWideLabtoolConsolidatedActionEnhancement_A43036_HasDiffs
		{
			get
			{
				short num = (short)375276106;
				short num2 = num;
				num = (short)1114325578;
				switch (num2 == num)
				{
				}
				num = (short)1650458625;
				if (num != 0)
				{
				}
				num = (short)971636736;
				if (num != 0)
				{
				}
				num = (short)1658978304;
				short num3 = num;
				return this.radWideLabtoolConsolidatedActionEnhancement_A43036._HasDiffs;
			}
		}

		// Token: 0x17001DBF RID: 7615
		// (get) Token: 0x06003A40 RID: 14912 RVA: 0x0036F4F4 File Offset: 0x0036D6F4
		// (set) Token: 0x06003A41 RID: 14913 RVA: 0x0036F5A8 File Offset: 0x0036D7A8
		public bool RadWideLabtoolLimitedISSIDVRSOperationCapable_43045Value
		{
			get
			{
				short num = (short)1593438570;
				short num2 = num;
				num = (short)1640231274;
				switch (num2 == num)
				{
				}
				num = (short)1515061248;
				if (num != 0)
				{
				}
				num = (short)2085748737;
				if (num != 0)
				{
				}
				num = (short)1665204224;
				short num3 = num;
				return this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045.Value;
			}
			set
			{
				short num = (short)1400778198;
				short num2 = num;
				num = (short)1998204374;
				switch (num2 == num)
				{
				}
				num = (short)1817903104;
				short num3 = num;
				num = (short)288948225;
				if (num != 0)
				{
				}
				num = (short)2055536640;
				if (num != 0)
				{
				}
				this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045.Value = value;
			}
		}

		// Token: 0x17001DC0 RID: 7616
		// (get) Token: 0x06003A42 RID: 14914 RVA: 0x0036F65C File Offset: 0x0036D85C
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolLimitedISSIDVRSOperationCapable_43045
		{
			get
			{
				short num = (short)1020363138;
				short num2 = num;
				num = (short)235307394;
				switch (num2 == num)
				{
				}
				num = (short)185729024;
				short num3 = num;
				num = (short)277676033;
				if (num != 0)
				{
				}
				num = (short)420282368;
				if (num != 0)
				{
				}
				return this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045;
			}
		}

		// Token: 0x17001DC1 RID: 7617
		// (get) Token: 0x06003A43 RID: 14915 RVA: 0x0036F70C File Offset: 0x0036D90C
		// (set) Token: 0x06003A44 RID: 14916 RVA: 0x0036F7C0 File Offset: 0x0036D9C0
		public bool RadWideLabtoolLimitedISSIDVRSOperationCapable_43045_UIValue
		{
			get
			{
				short num = (short)1144127489;
				if (num != 0)
				{
				}
				num = (short)653070599;
				short num2 = num;
				num = (short)103354631;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1369440256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1961558016;
				if (num != 0)
				{
				}
				return this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045.Value;
			}
			set
			{
				short num = (short)1369766924;
				short num2 = num;
				num = (short)179174412;
				switch (num2 == num)
				{
				}
				num = (short)216072192;
				short num3 = num;
				num = (short)1826291713;
				if (num != 0)
				{
				}
				num = (short)1664942080;
				if (num != 0)
				{
				}
				this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045.Value = value;
			}
		}

		// Token: 0x17001DC2 RID: 7618
		// (get) Token: 0x06003A45 RID: 14917 RVA: 0x0036F874 File Offset: 0x0036DA74
		// (set) Token: 0x06003A46 RID: 14918 RVA: 0x0036F928 File Offset: 0x0036DB28
		public bool RadWideLabtoolLimitedISSIDVRSOperationCapable_43045_Applicable
		{
			get
			{
				short num = (short)1277114580;
				short num2 = num;
				num = (short)535640276;
				switch (num2 == num)
				{
				}
				num = (short)1069350912;
				short num3 = num;
				num = (short)1899167745;
				if (num != 0)
				{
				}
				num = (short)1913257984;
				if (num != 0)
				{
				}
				return this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045.Applicable;
			}
			set
			{
				short num = (short)143076539;
				short num2 = num;
				num = (short)1068510395;
				switch (num2 == num)
				{
				}
				num = (short)2142961664;
				short num3 = num;
				num = (short)991952896;
				if (num != 0)
				{
				}
				num = (short)231997441;
				if (num != 0)
				{
				}
				this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045.Applicable = value;
			}
		}

		// Token: 0x17001DC3 RID: 7619
		// (get) Token: 0x06003A47 RID: 14919 RVA: 0x0036F9DC File Offset: 0x0036DBDC
		// (set) Token: 0x06003A48 RID: 14920 RVA: 0x0036FA90 File Offset: 0x0036DC90
		public bool RadWideLabtoolLimitedISSIDVRSOperationCapable_43045_Valid
		{
			get
			{
				short num = (short)1895798659;
				short num2 = num;
				num = (short)137729923;
				switch (num2 == num)
				{
				}
				num = (short)822345728;
				short num3 = num;
				num = (short)863502336;
				if (num != 0)
				{
				}
				num = (short)355401729;
				if (num != 0)
				{
				}
				return this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045.Valid;
			}
			set
			{
				short num = (short)1618804737;
				if (num != 0)
				{
				}
				num = (short)1850297348;
				short num2 = num;
				num = (short)2048609284;
				switch (num2 == num)
				{
				default:
				{
					num = (short)704380928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)519372800;
				if (num != 0)
				{
				}
				this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045.Valid = value;
			}
		}

		// Token: 0x17001DC4 RID: 7620
		// (get) Token: 0x06003A49 RID: 14921 RVA: 0x0036FB44 File Offset: 0x0036DD44
		// (set) Token: 0x06003A4A RID: 14922 RVA: 0x0036FBF8 File Offset: 0x0036DDF8
		public bool RadWideLabtoolLimitedISSIDVRSOperationCapable_43045_Visible
		{
			get
			{
				short num = (short)897175771;
				short num2 = num;
				num = (short)414109915;
				switch (num2 == num)
				{
				}
				num = (short)1707343872;
				short num3 = num;
				num = (short)2031878144;
				if (num != 0)
				{
				}
				num = (short)1245446145;
				if (num != 0)
				{
				}
				return this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045.Visible;
			}
			set
			{
				short num = (short)913706316;
				short num2 = num;
				num = (short)2072644940;
				switch (num2 == num)
				{
				}
				num = (short)2122055680;
				short num3 = num;
				num = (short)27852800;
				if (num != 0)
				{
				}
				num = (short)860160001;
				if (num != 0)
				{
				}
				this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045.Visible = value;
			}
		}

		// Token: 0x17001DC5 RID: 7621
		// (get) Token: 0x06003A4B RID: 14923 RVA: 0x0036FCAC File Offset: 0x0036DEAC
		// (set) Token: 0x06003A4C RID: 14924 RVA: 0x0036FD60 File Offset: 0x0036DF60
		public bool RadWideLabtoolLimitedISSIDVRSOperationCapable_43045_Editable
		{
			get
			{
				short num = (short)2032222337;
				short num2 = num;
				num = (short)781795457;
				switch (num2 == num)
				{
				}
				num = (short)1696595968;
				short num3 = num;
				num = (short)96796673;
				if (num != 0)
				{
				}
				num = (short)194117632;
				if (num != 0)
				{
				}
				return this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045.Editable;
			}
			set
			{
				short num = (short)2090299758;
				short num2 = num;
				num = (short)1080062318;
				switch (num2 == num)
				{
				}
				num = (short)978255872;
				short num3 = num;
				num = (short)404619265;
				if (num != 0)
				{
				}
				num = (short)39649280;
				if (num != 0)
				{
				}
				this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045.Editable = value;
			}
		}

		// Token: 0x17001DC6 RID: 7622
		// (get) Token: 0x06003A4D RID: 14925 RVA: 0x0036FE14 File Offset: 0x0036E014
		internal string RadWideLabtoolLimitedISSIDVRSOperationCapable_43045_UILabel
		{
			get
			{
				short num = (short)1024786433;
				if (num != 0)
				{
				}
				num = (short)1154418181;
				short num2 = num;
				num = (short)814548485;
				switch (num2 == num)
				{
				default:
				{
					num = (short)817823744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)624885760;
				if (num != 0)
				{
				}
				return this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045.UIName;
			}
		}

		// Token: 0x17001DC7 RID: 7623
		// (get) Token: 0x06003A4E RID: 14926 RVA: 0x0036FEC8 File Offset: 0x0036E0C8
		// (set) Token: 0x06003A4F RID: 14927 RVA: 0x0036FF7C File Offset: 0x0036E17C
		internal bool RadWideLabtoolLimitedISSIDVRSOperationCapable_43045_HiddenStatic
		{
			get
			{
				short num = (short)1692931909;
				short num2 = num;
				num = (short)907351877;
				switch (num2 == num)
				{
				}
				num = (short)1099366400;
				short num3 = num;
				num = (short)1610153985;
				if (num != 0)
				{
				}
				num = (short)723189760;
				if (num != 0)
				{
				}
				return this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045.HiddenStatic;
			}
			set
			{
				short num = (short)257949697;
				if (num != 0)
				{
				}
				num = (short)266873171;
				short num2 = num;
				num = (short)650848595;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1108148224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1750663168;
				if (num != 0)
				{
				}
				this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045.HiddenStatic = value;
			}
		}

		// Token: 0x17001DC8 RID: 7624
		// (get) Token: 0x06003A50 RID: 14928 RVA: 0x00370034 File Offset: 0x0036E234
		// (set) Token: 0x06003A51 RID: 14929 RVA: 0x003700E8 File Offset: 0x0036E2E8
		internal bool RadWideLabtoolLimitedISSIDVRSOperationCapable_43045_HiddenDynamic
		{
			get
			{
				short num = (short)562469939;
				short num2 = num;
				num = (short)1109105715;
				switch (num2 == num)
				{
				}
				num = (short)1692139520;
				short num3 = num;
				num = (short)30343168;
				if (num != 0)
				{
				}
				num = (short)1097465857;
				if (num != 0)
				{
				}
				return this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045.HiddenDynamic;
			}
			set
			{
				short num = (short)1723878458;
				short num2 = num;
				num = (short)1567968314;
				switch (num2 == num)
				{
				}
				num = (short)1924792320;
				short num3 = num;
				num = (short)866713600;
				if (num != 0)
				{
				}
				num = (short)1169948673;
				if (num != 0)
				{
				}
				this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045.HiddenDynamic = value;
			}
		}

		// Token: 0x17001DC9 RID: 7625
		// (get) Token: 0x06003A52 RID: 14930 RVA: 0x003701A0 File Offset: 0x0036E3A0
		public bool RadWideLabtoolLimitedISSIDVRSOperationCapable_43045_HasDiffs
		{
			get
			{
				short num = (short)2016239220;
				short num2 = num;
				num = (short)921656948;
				switch (num2 == num)
				{
				}
				num = (short)1888026624;
				short num3 = num;
				num = (short)940834816;
				if (num != 0)
				{
				}
				num = (short)2006515713;
				if (num != 0)
				{
				}
				return this.radWideLabtoolLimitedISSIDVRSOperationCapable_43045._HasDiffs;
			}
		}

		// Token: 0x17001DCA RID: 7626
		// (get) Token: 0x06003A53 RID: 14931 RVA: 0x00370254 File Offset: 0x0036E454
		// (set) Token: 0x06003A54 RID: 14932 RVA: 0x00370308 File Offset: 0x0036E508
		public bool RadWideLabtoolActiveMicForBTPTTCapable_43053Value
		{
			get
			{
				short num = (short)748441793;
				short num2 = num;
				num = (short)1803833537;
				switch (num2 == num)
				{
				}
				num = (short)1174142976;
				short num3 = num;
				num = (short)388890624;
				if (num != 0)
				{
				}
				num = (short)1115947009;
				if (num != 0)
				{
				}
				return this.radWideLabtoolActiveMicForBTPTTCapable_43053.Value;
			}
			set
			{
				short num = (short)1356922881;
				if (num != 0)
				{
				}
				num = (short)1937175778;
				short num2 = num;
				num = (short)1769075938;
				switch (num2 == num)
				{
				default:
				{
					num = (short)921829376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1392771072;
				if (num != 0)
				{
				}
				this.radWideLabtoolActiveMicForBTPTTCapable_43053.Value = value;
			}
		}

		// Token: 0x17001DCB RID: 7627
		// (get) Token: 0x06003A55 RID: 14933 RVA: 0x003703BC File Offset: 0x0036E5BC
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolActiveMicForBTPTTCapable_43053
		{
			get
			{
				short num = (short)157052150;
				short num2 = num;
				num = (short)1469686;
				switch (num2 == num)
				{
				}
				num = (short)1170735104;
				short num3 = num;
				num = (short)1047396353;
				if (num != 0)
				{
				}
				num = (short)1414135808;
				if (num != 0)
				{
				}
				return this.radWideLabtoolActiveMicForBTPTTCapable_43053;
			}
		}

		// Token: 0x17001DCC RID: 7628
		// (get) Token: 0x06003A56 RID: 14934 RVA: 0x0037046C File Offset: 0x0036E66C
		// (set) Token: 0x06003A57 RID: 14935 RVA: 0x00370524 File Offset: 0x0036E724
		public bool RadWideLabtoolActiveMicForBTPTTCapable_43053_UIValue
		{
			get
			{
				short num = (short)969146369;
				if (num != 0)
				{
				}
				num = (short)739608928;
				short num2 = num;
				num = (short)1717799264;
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
				num = (short)811335680;
				if (num != 0)
				{
				}
				return this.radWideLabtoolActiveMicForBTPTTCapable_43053.Value;
			}
			set
			{
				short num = (short)1723352068;
				short num2 = num;
				num = (short)1185301508;
				switch (num2 == num)
				{
				}
				num = (short)742129664;
				short num3 = num;
				num = (short)738918401;
				if (num != 0)
				{
				}
				num = (short)703201280;
				if (num != 0)
				{
				}
				this.radWideLabtoolActiveMicForBTPTTCapable_43053.Value = value;
			}
		}

		// Token: 0x17001DCD RID: 7629
		// (get) Token: 0x06003A58 RID: 14936 RVA: 0x003705DC File Offset: 0x0036E7DC
		// (set) Token: 0x06003A59 RID: 14937 RVA: 0x00370694 File Offset: 0x0036E894
		public bool RadWideLabtoolActiveMicForBTPTTCapable_43053_Applicable
		{
			get
			{
				short num = (short)733418898;
				short num2 = num;
				num = (short)1347098002;
				switch (num2 == num)
				{
				}
				num = (short)1390542848;
				short num3 = num;
				num = (short)1549926400;
				if (num != 0)
				{
				}
				num = (short)1132855297;
				if (num != 0)
				{
				}
				return this.radWideLabtoolActiveMicForBTPTTCapable_43053.Applicable;
			}
			set
			{
				short num = (short)276299777;
				if (num != 0)
				{
				}
				num = (short)502712268;
				short num2 = num;
				num = (short)2086979532;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1488322560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)96862208;
				if (num != 0)
				{
				}
				this.radWideLabtoolActiveMicForBTPTTCapable_43053.Applicable = value;
			}
		}

		// Token: 0x17001DCE RID: 7630
		// (get) Token: 0x06003A5A RID: 14938 RVA: 0x0037074C File Offset: 0x0036E94C
		// (set) Token: 0x06003A5B RID: 14939 RVA: 0x00370800 File Offset: 0x0036EA00
		public bool RadWideLabtoolActiveMicForBTPTTCapable_43053_Valid
		{
			get
			{
				short num = (short)697477893;
				short num2 = num;
				num = (short)636594949;
				switch (num2 == num)
				{
				}
				num = (short)1464991744;
				short num3 = num;
				num = (short)204406785;
				if (num != 0)
				{
				}
				num = (short)290127872;
				if (num != 0)
				{
				}
				return this.radWideLabtoolActiveMicForBTPTTCapable_43053.Valid;
			}
			set
			{
				short num = (short)136620590;
				short num2 = num;
				num = (short)435661358;
				switch (num2 == num)
				{
				}
				num = (short)1516634112;
				short num3 = num;
				num = (short)217776129;
				if (num != 0)
				{
				}
				num = (short)351272960;
				if (num != 0)
				{
				}
				this.radWideLabtoolActiveMicForBTPTTCapable_43053.Valid = value;
			}
		}

		// Token: 0x17001DCF RID: 7631
		// (get) Token: 0x06003A5C RID: 14940 RVA: 0x003708B4 File Offset: 0x0036EAB4
		// (set) Token: 0x06003A5D RID: 14941 RVA: 0x00370968 File Offset: 0x0036EB68
		public bool RadWideLabtoolActiveMicForBTPTTCapable_43053_Visible
		{
			get
			{
				short num = (short)1624918269;
				short num2 = num;
				num = (short)641812733;
				switch (num2 == num)
				{
				}
				num = (short)650641408;
				short num3 = num;
				num = (short)1696595969;
				if (num != 0)
				{
				}
				num = (short)1000800256;
				if (num != 0)
				{
				}
				return this.radWideLabtoolActiveMicForBTPTTCapable_43053.Visible;
			}
			set
			{
				short num = (short)389640118;
				short num2 = num;
				num = (short)854749110;
				switch (num2 == num)
				{
				}
				num = (short)1628504064;
				short num3 = num;
				num = (short)1750859776;
				if (num != 0)
				{
				}
				num = (short)491651073;
				if (num != 0)
				{
				}
				this.radWideLabtoolActiveMicForBTPTTCapable_43053.Visible = value;
			}
		}

		// Token: 0x17001DD0 RID: 7632
		// (get) Token: 0x06003A5E RID: 14942 RVA: 0x00370A1C File Offset: 0x0036EC1C
		// (set) Token: 0x06003A5F RID: 14943 RVA: 0x00370AD4 File Offset: 0x0036ECD4
		public bool RadWideLabtoolActiveMicForBTPTTCapable_43053_Editable
		{
			get
			{
				short num = (short)1647495357;
				short num2 = num;
				num = (short)393791677;
				switch (num2 == num)
				{
				}
				num = (short)1464664064;
				short num3 = num;
				num = (short)1976500225;
				if (num != 0)
				{
				}
				num = (short)1820393472;
				if (num != 0)
				{
				}
				return this.radWideLabtoolActiveMicForBTPTTCapable_43053.Editable;
			}
			set
			{
				short num = (short)79404160;
				short num2 = num;
				num = (short)316185728;
				switch (num2 == num)
				{
				}
				num = (short)173867008;
				short num3 = num;
				num = (short)1146290177;
				if (num != 0)
				{
				}
				num = (short)1436614656;
				if (num != 0)
				{
				}
				this.radWideLabtoolActiveMicForBTPTTCapable_43053.Editable = value;
			}
		}

		// Token: 0x17001DD1 RID: 7633
		// (get) Token: 0x06003A60 RID: 14944 RVA: 0x00370B88 File Offset: 0x0036ED88
		internal string RadWideLabtoolActiveMicForBTPTTCapable_43053_UILabel
		{
			get
			{
				short num = (short)467075073;
				if (num != 0)
				{
				}
				num = (short)1498305902;
				short num2 = num;
				num = (short)2009748846;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1597702144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)281870336;
				if (num != 0)
				{
				}
				return this.radWideLabtoolActiveMicForBTPTTCapable_43053.UIName;
			}
		}

		// Token: 0x17001DD2 RID: 7634
		// (get) Token: 0x06003A61 RID: 14945 RVA: 0x00370C3C File Offset: 0x0036EE3C
		// (set) Token: 0x06003A62 RID: 14946 RVA: 0x00370CF0 File Offset: 0x0036EEF0
		internal bool RadWideLabtoolActiveMicForBTPTTCapable_43053_HiddenStatic
		{
			get
			{
				short num = (short)1399061705;
				short num2 = num;
				num = (short)211483849;
				switch (num2 == num)
				{
				}
				num = (short)1508704256;
				short num3 = num;
				num = (short)1294336001;
				if (num != 0)
				{
				}
				num = (short)1089077248;
				if (num != 0)
				{
				}
				return this.radWideLabtoolActiveMicForBTPTTCapable_43053.HiddenStatic;
			}
			set
			{
				short num = (short)1071241754;
				short num2 = num;
				num = (short)902158874;
				switch (num2 == num)
				{
				}
				num = (short)1002700800;
				short num3 = num;
				num = (short)1563885569;
				if (num != 0)
				{
				}
				num = (short)936443904;
				if (num != 0)
				{
				}
				this.radWideLabtoolActiveMicForBTPTTCapable_43053.HiddenStatic = value;
			}
		}

		// Token: 0x17001DD3 RID: 7635
		// (get) Token: 0x06003A63 RID: 14947 RVA: 0x00370DA4 File Offset: 0x0036EFA4
		// (set) Token: 0x06003A64 RID: 14948 RVA: 0x00370E5C File Offset: 0x0036F05C
		internal bool RadWideLabtoolActiveMicForBTPTTCapable_43053_HiddenDynamic
		{
			get
			{
				short num = (short)1929150105;
				short num2 = num;
				num = (short)865959577;
				switch (num2 == num)
				{
				}
				num = (short)1788149760;
				short num3 = num;
				num = (short)1664155649;
				if (num != 0)
				{
				}
				num = (short)2008809472;
				if (num != 0)
				{
				}
				return this.radWideLabtoolActiveMicForBTPTTCapable_43053.HiddenDynamic;
			}
			set
			{
				short num = (short)1342839432;
				short num2 = num;
				num = (short)1910774408;
				switch (num2 == num)
				{
				}
				num = (short)618528768;
				short num3 = num;
				num = (short)155516928;
				if (num != 0)
				{
				}
				num = (short)412942337;
				if (num != 0)
				{
				}
				this.radWideLabtoolActiveMicForBTPTTCapable_43053.HiddenDynamic = value;
			}
		}

		// Token: 0x17001DD4 RID: 7636
		// (get) Token: 0x06003A65 RID: 14949 RVA: 0x00370F10 File Offset: 0x0036F110
		public bool RadWideLabtoolActiveMicForBTPTTCapable_43053_HasDiffs
		{
			get
			{
				short num = (short)679673857;
				if (num != 0)
				{
				}
				num = (short)526900769;
				short num2 = num;
				num = (short)551738913;
				switch (num2 == num)
				{
				default:
				{
					num = (short)758317056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)432996352;
				if (num != 0)
				{
				}
				return this.radWideLabtoolActiveMicForBTPTTCapable_43053._HasDiffs;
			}
		}

		// Token: 0x17001DD5 RID: 7637
		// (get) Token: 0x06003A66 RID: 14950 RVA: 0x00370FC4 File Offset: 0x0036F1C4
		// (set) Token: 0x06003A67 RID: 14951 RVA: 0x00371078 File Offset: 0x0036F278
		public bool RadWideLabtoolAPXSingletoneCapable_43080Value
		{
			get
			{
				short num = (short)816701990;
				short num2 = num;
				num = (short)1282007590;
				switch (num2 == num)
				{
				}
				num = (short)947257344;
				short num3 = num;
				num = (short)1122631681;
				if (num != 0)
				{
				}
				num = (short)1265041408;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAPXSingletoneCapable_43080.Value;
			}
			set
			{
				short num = (short)1621193619;
				short num2 = num;
				num = (short)378106771;
				switch (num2 == num)
				{
				}
				num = (short)1513291776;
				short num3 = num;
				num = (short)1286406145;
				if (num != 0)
				{
				}
				num = (short)1505492992;
				if (num != 0)
				{
				}
				this.radWideLabtoolAPXSingletoneCapable_43080.Value = value;
			}
		}

		// Token: 0x17001DD6 RID: 7638
		// (get) Token: 0x06003A68 RID: 14952 RVA: 0x00371130 File Offset: 0x0036F330
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolAPXSingletoneCapable_43080
		{
			get
			{
				short num = (short)744226816;
				short num2 = num;
				num = (short)29355187;
				short num3 = num;
				num = (short)1553525939;
				switch (num3 == num)
				{
				}
				num = (short)1802174465;
				if (num != 0)
				{
				}
				num = (short)1150681088;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAPXSingletoneCapable_43080;
			}
		}

		// Token: 0x17001DD7 RID: 7639
		// (get) Token: 0x06003A69 RID: 14953 RVA: 0x003711E4 File Offset: 0x0036F3E4
		// (set) Token: 0x06003A6A RID: 14954 RVA: 0x00371298 File Offset: 0x0036F498
		public bool RadWideLabtoolAPXSingletoneCapable_43080_UIValue
		{
			get
			{
				short num = (short)1233584128;
				short num2 = num;
				num = (short)1976605824;
				short num3 = num;
				num = (short)802921600;
				switch (num3 == num)
				{
				}
				num = (short)863436801;
				if (num != 0)
				{
				}
				num = (short)1574895616;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAPXSingletoneCapable_43080.Value;
			}
			set
			{
				short num = (short)2049441792;
				short num2 = num;
				num = (short)1449140670;
				short num3 = num;
				num = (short)1844715966;
				switch (num3 == num)
				{
				}
				num = (short)1288306689;
				if (num != 0)
				{
				}
				num = (short)1703542784;
				if (num != 0)
				{
				}
				this.radWideLabtoolAPXSingletoneCapable_43080.Value = value;
			}
		}

		// Token: 0x17001DD8 RID: 7640
		// (get) Token: 0x06003A6B RID: 14955 RVA: 0x0037134C File Offset: 0x0036F54C
		// (set) Token: 0x06003A6C RID: 14956 RVA: 0x00371400 File Offset: 0x0036F600
		public bool RadWideLabtoolAPXSingletoneCapable_43080_Applicable
		{
			get
			{
				short num = (short)1703739392;
				short num2 = num;
				num = (short)1880244475;
				short num3 = num;
				num = (short)1971208443;
				switch (num3 == num)
				{
				}
				num = (short)212271105;
				if (num != 0)
				{
				}
				num = (short)1196556288;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAPXSingletoneCapable_43080.Applicable;
			}
			set
			{
				short num = (short)471007232;
				short num2 = num;
				num = (short)896242405;
				short num3 = num;
				num = (short)1357484773;
				switch (num3 == num)
				{
				}
				num = (short)284426241;
				if (num != 0)
				{
				}
				num = (short)81199104;
				if (num != 0)
				{
				}
				this.radWideLabtoolAPXSingletoneCapable_43080.Applicable = value;
			}
		}

		// Token: 0x17001DD9 RID: 7641
		// (get) Token: 0x06003A6D RID: 14957 RVA: 0x003714B4 File Offset: 0x0036F6B4
		// (set) Token: 0x06003A6E RID: 14958 RVA: 0x00371568 File Offset: 0x0036F768
		public bool RadWideLabtoolAPXSingletoneCapable_43080_Valid
		{
			get
			{
				short num = (short)1012662272;
				short num2 = num;
				num = (short)685260407;
				short num3 = num;
				num = (short)1260797559;
				switch (num3 == num)
				{
				}
				num = (short)1161887745;
				if (num != 0)
				{
				}
				num = (short)1057095680;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAPXSingletoneCapable_43080.Valid;
			}
			set
			{
				short num = (short)1682964480;
				short num2 = num;
				num = (short)1228595434;
				short num3 = num;
				num = (short)1545789674;
				switch (num3 == num)
				{
				}
				num = (short)1478426625;
				if (num != 0)
				{
				}
				num = (short)454950912;
				if (num != 0)
				{
				}
				this.radWideLabtoolAPXSingletoneCapable_43080.Valid = value;
			}
		}

		// Token: 0x17001DDA RID: 7642
		// (get) Token: 0x06003A6F RID: 14959 RVA: 0x00371620 File Offset: 0x0036F820
		// (set) Token: 0x06003A70 RID: 14960 RVA: 0x003716D8 File Offset: 0x0036F8D8
		public bool RadWideLabtoolAPXSingletoneCapable_43080_Visible
		{
			get
			{
				short num = (short)575733760;
				short num2 = num;
				num = (short)2137264404;
				short num3 = num;
				num = (short)1917194516;
				switch (num3 == num)
				{
				}
				num = (short)1062273025;
				if (num != 0)
				{
				}
				num = (short)3407872;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAPXSingletoneCapable_43080.Visible;
			}
			set
			{
				short num = (short)1692073984;
				short num2 = num;
				num = (short)2091054737;
				short num3 = num;
				num = (short)1697445521;
				switch (num3 == num)
				{
				}
				num = (short)1693515777;
				if (num != 0)
				{
				}
				num = (short)25100288;
				if (num != 0)
				{
				}
				this.radWideLabtoolAPXSingletoneCapable_43080.Visible = value;
			}
		}

		// Token: 0x17001DDB RID: 7643
		// (get) Token: 0x06003A71 RID: 14961 RVA: 0x00371790 File Offset: 0x0036F990
		// (set) Token: 0x06003A72 RID: 14962 RVA: 0x00371844 File Offset: 0x0036FA44
		public bool RadWideLabtoolAPXSingletoneCapable_43080_Editable
		{
			get
			{
				short num = (short)2096300032;
				short num2 = num;
				num = (short)85862332;
				short num3 = num;
				num = (short)82126780;
				switch (num3 == num)
				{
				}
				num = (short)1256849409;
				if (num != 0)
				{
				}
				num = (short)662110208;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAPXSingletoneCapable_43080.Editable;
			}
			set
			{
				short num = (short)541917184;
				short num2 = num;
				num = (short)1231457284;
				short num3 = num;
				num = (short)164334596;
				switch (num3 == num)
				{
				}
				num = (short)617676801;
				if (num != 0)
				{
				}
				num = (short)529465344;
				if (num != 0)
				{
				}
				this.radWideLabtoolAPXSingletoneCapable_43080.Editable = value;
			}
		}

		// Token: 0x17001DDC RID: 7644
		// (get) Token: 0x06003A73 RID: 14963 RVA: 0x003718F8 File Offset: 0x0036FAF8
		internal string RadWideLabtoolAPXSingletoneCapable_43080_UILabel
		{
			get
			{
				short num = (short)1220345856;
				short num2 = num;
				num = (short)2033803519;
				short num3 = num;
				num = (short)148463871;
				switch (num3 == num)
				{
				}
				num = (short)782172161;
				if (num != 0)
				{
				}
				num = (short)229507072;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAPXSingletoneCapable_43080.UIName;
			}
		}

		// Token: 0x17001DDD RID: 7645
		// (get) Token: 0x06003A74 RID: 14964 RVA: 0x003719B0 File Offset: 0x0036FBB0
		// (set) Token: 0x06003A75 RID: 14965 RVA: 0x00371A64 File Offset: 0x0036FC64
		internal bool RadWideLabtoolAPXSingletoneCapable_43080_HiddenStatic
		{
			get
			{
				short num = (short)1753612288;
				short num2 = num;
				num = (short)1529226428;
				short num3 = num;
				num = (short)1862345916;
				switch (num3 == num)
				{
				}
				num = (short)84082689;
				if (num != 0)
				{
				}
				num = (short)40632320;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAPXSingletoneCapable_43080.HiddenStatic;
			}
			set
			{
				short num = (short)506789888;
				short num2 = num;
				num = (short)471048610;
				short num3 = num;
				num = (short)1404936610;
				switch (num3 == num)
				{
				}
				num = (short)48562177;
				if (num != 0)
				{
				}
				num = (short)204603392;
				if (num != 0)
				{
				}
				this.radWideLabtoolAPXSingletoneCapable_43080.HiddenStatic = value;
			}
		}

		// Token: 0x17001DDE RID: 7646
		// (get) Token: 0x06003A76 RID: 14966 RVA: 0x00371B18 File Offset: 0x0036FD18
		// (set) Token: 0x06003A77 RID: 14967 RVA: 0x00371BCC File Offset: 0x0036FDCC
		internal bool RadWideLabtoolAPXSingletoneCapable_43080_HiddenDynamic
		{
			get
			{
				short num = (short)1880555520;
				short num2 = num;
				num = (short)1521896808;
				short num3 = num;
				num = (short)233065832;
				switch (num3 == num)
				{
				}
				num = (short)1874526209;
				if (num != 0)
				{
				}
				num = (short)186449920;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAPXSingletoneCapable_43080.HiddenDynamic;
			}
			set
			{
				short num = (short)2006253568;
				short num2 = num;
				num = (short)1916765299;
				short num3 = num;
				num = (short)1361544307;
				switch (num3 == num)
				{
				}
				num = (short)1705705473;
				if (num != 0)
				{
				}
				num = (short)1146945536;
				if (num != 0)
				{
				}
				this.radWideLabtoolAPXSingletoneCapable_43080.HiddenDynamic = value;
			}
		}

		// Token: 0x17001DDF RID: 7647
		// (get) Token: 0x06003A78 RID: 14968 RVA: 0x00371C84 File Offset: 0x0036FE84
		public bool RadWideLabtoolAPXSingletoneCapable_43080_HasDiffs
		{
			get
			{
				short num = (short)738131968;
				short num2 = num;
				num = (short)2106565749;
				short num3 = num;
				num = (short)793945205;
				switch (num3 == num)
				{
				}
				num = (short)1541996545;
				if (num != 0)
				{
				}
				num = (short)1331101696;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAPXSingletoneCapable_43080._HasDiffs;
			}
		}

		// Token: 0x17001DE0 RID: 7648
		// (get) Token: 0x06003A79 RID: 14969 RVA: 0x00371D38 File Offset: 0x0036FF38
		// (set) Token: 0x06003A7A RID: 14970 RVA: 0x00371DF0 File Offset: 0x0036FFF0
		public bool RadWideLabtoolEnhancedARS_A43084Value
		{
			get
			{
				short num = (short)1281622016;
				short num2 = num;
				num = (short)1899380093;
				short num3 = num;
				num = (short)1505181053;
				switch (num3 == num)
				{
				}
				num = (short)1779171328;
				if (num != 0)
				{
				}
				num = (short)1659305985;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEnhancedARS_A43084.Value;
			}
			set
			{
				short num = (short)360513536;
				short num2 = num;
				num = (short)976550772;
				short num3 = num;
				num = (short)1515584372;
				switch (num3 == num)
				{
				}
				num = (short)1489764353;
				if (num != 0)
				{
				}
				num = (short)1109065728;
				if (num != 0)
				{
				}
				this.radWideLabtoolEnhancedARS_A43084.Value = value;
			}
		}

		// Token: 0x17001DE1 RID: 7649
		// (get) Token: 0x06003A7B RID: 14971 RVA: 0x00371EA8 File Offset: 0x003700A8
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolEnhancedARS_A43084
		{
			get
			{
				short num = (short)1814495232;
				short num2 = num;
				num = (short)394802240;
				short num3 = num;
				num = (short)549532736;
				switch (num3 == num)
				{
				}
				num = (short)1111883777;
				if (num != 0)
				{
				}
				num = (short)1599143936;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEnhancedARS_A43084;
			}
		}

		// Token: 0x17001DE2 RID: 7650
		// (get) Token: 0x06003A7C RID: 14972 RVA: 0x00371F58 File Offset: 0x00370158
		// (set) Token: 0x06003A7D RID: 14973 RVA: 0x00372014 File Offset: 0x00370214
		public bool RadWideLabtoolEnhancedARS_A43084_UIValue
		{
			get
			{
				short num = (short)1635909632;
				short num2 = num;
				num = (short)1272155599;
				short num3 = num;
				num = (short)956337615;
				switch (num3 == num)
				{
				}
				num = (short)245104641;
				if (num != 0)
				{
				}
				num = (short)1937506304;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEnhancedARS_A43084.Value;
			}
			set
			{
				short num = (short)1542455296;
				short num2 = num;
				num = (short)1419215501;
				short num3 = num;
				num = (short)2119271053;
				switch (num3 == num)
				{
				}
				num = (short)2016673793;
				if (num != 0)
				{
				}
				num = (short)346357760;
				if (num != 0)
				{
				}
				this.radWideLabtoolEnhancedARS_A43084.Value = value;
			}
		}

		// Token: 0x17001DE3 RID: 7651
		// (get) Token: 0x06003A7E RID: 14974 RVA: 0x003720CC File Offset: 0x003702CC
		// (set) Token: 0x06003A7F RID: 14975 RVA: 0x00372180 File Offset: 0x00370380
		public bool RadWideLabtoolEnhancedARS_A43084_Applicable
		{
			get
			{
				short num = (short)1297416192;
				short num2 = num;
				num = (short)2056932998;
				short num3 = num;
				num = (short)1014713990;
				switch (num3 == num)
				{
				}
				num = (short)929890305;
				if (num != 0)
				{
				}
				num = (short)2118385664;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEnhancedARS_A43084.Applicable;
			}
			set
			{
				short num = (short)1727463424;
				short num2 = num;
				num = (short)1611258957;
				short num3 = num;
				num = (short)1788664909;
				switch (num3 == num)
				{
				}
				num = (short)1822294017;
				if (num != 0)
				{
				}
				num = (short)1720188928;
				if (num != 0)
				{
				}
				this.radWideLabtoolEnhancedARS_A43084.Applicable = value;
			}
		}

		// Token: 0x17001DE4 RID: 7652
		// (get) Token: 0x06003A80 RID: 14976 RVA: 0x00372234 File Offset: 0x00370434
		// (set) Token: 0x06003A81 RID: 14977 RVA: 0x003722EC File Offset: 0x003704EC
		public bool RadWideLabtoolEnhancedARS_A43084_Valid
		{
			get
			{
				short num = (short)1403846656;
				short num2 = num;
				num = (short)1940981790;
				short num3 = num;
				num = (short)501745694;
				switch (num3 == num)
				{
				}
				num = (short)1198391297;
				if (num != 0)
				{
				}
				num = (short)1316945920;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEnhancedARS_A43084.Valid;
			}
			set
			{
				short num = (short)477102080;
				short num2 = num;
				num = (short)468123649;
				if (num != 0)
				{
				}
				num = (short)438530252;
				short num3 = num;
				num = (short)589656268;
				switch (num3 == num)
				{
				}
				num = (short)183631872;
				if (num != 0)
				{
				}
				this.radWideLabtoolEnhancedARS_A43084.Valid = value;
			}
		}

		// Token: 0x17001DE5 RID: 7653
		// (get) Token: 0x06003A82 RID: 14978 RVA: 0x0037239C File Offset: 0x0037059C
		// (set) Token: 0x06003A83 RID: 14979 RVA: 0x00372450 File Offset: 0x00370650
		public bool RadWideLabtoolEnhancedARS_A43084_Visible
		{
			get
			{
				short num = (short)331284480;
				short num2 = num;
				num = (short)141224723;
				short num3 = num;
				num = (short)934472467;
				switch (num3 == num)
				{
				}
				num = (short)1049034753;
				if (num != 0)
				{
				}
				num = (short)892993536;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEnhancedARS_A43084.Visible;
			}
			set
			{
				short num = (short)1807941632;
				short num2 = num;
				num = (short)2097116325;
				short num3 = num;
				num = (short)363623589;
				switch (num3 == num)
				{
				}
				num = (short)1078132736;
				if (num != 0)
				{
				}
				num = (short)559808513;
				if (num != 0)
				{
				}
				this.radWideLabtoolEnhancedARS_A43084.Visible = value;
			}
		}

		// Token: 0x17001DE6 RID: 7654
		// (get) Token: 0x06003A84 RID: 14980 RVA: 0x00372508 File Offset: 0x00370708
		// (set) Token: 0x06003A85 RID: 14981 RVA: 0x003725BC File Offset: 0x003707BC
		public bool RadWideLabtoolEnhancedARS_A43084_Editable
		{
			get
			{
				short num = (short)615710720;
				short num2 = num;
				num = (short)1096559594;
				short num3 = num;
				num = (short)292891626;
				switch (num3 == num)
				{
				}
				num = (short)719126529;
				if (num != 0)
				{
				}
				num = (short)811991040;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEnhancedARS_A43084.Editable;
			}
			set
			{
				short num = (short)1695940608;
				short num2 = num;
				num = (short)424280065;
				if (num != 0)
				{
				}
				num = (short)641112236;
				short num3 = num;
				num = (short)941201580;
				switch (num3 == num)
				{
				}
				num = (short)1621164032;
				if (num != 0)
				{
				}
				this.radWideLabtoolEnhancedARS_A43084.Editable = value;
			}
		}

		// Token: 0x17001DE7 RID: 7655
		// (get) Token: 0x06003A86 RID: 14982 RVA: 0x00372670 File Offset: 0x00370870
		internal string RadWideLabtoolEnhancedARS_A43084_UILabel
		{
			get
			{
				short num = (short)603979776;
				short num2 = num;
				num = (short)1473052673;
				if (num != 0)
				{
				}
				num = (short)539233995;
				short num3 = num;
				num = (short)1273827019;
				switch (num3 == num)
				{
				}
				num = (short)1719009280;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEnhancedARS_A43084.UIName;
			}
		}

		// Token: 0x17001DE8 RID: 7656
		// (get) Token: 0x06003A87 RID: 14983 RVA: 0x00372728 File Offset: 0x00370928
		// (set) Token: 0x06003A88 RID: 14984 RVA: 0x003727DC File Offset: 0x003709DC
		internal bool RadWideLabtoolEnhancedARS_A43084_HiddenStatic
		{
			get
			{
				short num = (short)667484160;
				short num2 = num;
				num = (short)797687314;
				short num3 = num;
				num = (short)264879634;
				switch (num3 == num)
				{
				}
				num = (short)414121984;
				if (num != 0)
				{
				}
				num = (short)535166977;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEnhancedARS_A43084.HiddenStatic;
			}
			set
			{
				short num = (short)101580800;
				short num2 = num;
				num = (short)1097755156;
				short num3 = num;
				num = (short)164522516;
				switch (num3 == num)
				{
				}
				num = (short)414646273;
				if (num != 0)
				{
				}
				num = (short)428605440;
				if (num != 0)
				{
				}
				this.radWideLabtoolEnhancedARS_A43084.HiddenStatic = value;
			}
		}

		// Token: 0x17001DE9 RID: 7657
		// (get) Token: 0x06003A89 RID: 14985 RVA: 0x00372890 File Offset: 0x00370A90
		// (set) Token: 0x06003A8A RID: 14986 RVA: 0x00372944 File Offset: 0x00370B44
		internal bool RadWideLabtoolEnhancedARS_A43084_HiddenDynamic
		{
			get
			{
				short num = (short)564920320;
				short num2 = num;
				num = (short)544664288;
				short num3 = num;
				num = (short)1462758112;
				switch (num3 == num)
				{
				}
				num = (short)980811777;
				if (num != 0)
				{
				}
				num = (short)1932787712;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEnhancedARS_A43084.HiddenDynamic;
			}
			set
			{
				short num = (short)790757376;
				short num2 = num;
				num = (short)1960076302;
				short num3 = num;
				num = (short)1576690702;
				switch (num3 == num)
				{
				}
				num = (short)1830027265;
				if (num != 0)
				{
				}
				num = (short)342294528;
				if (num != 0)
				{
				}
				this.radWideLabtoolEnhancedARS_A43084.HiddenDynamic = value;
			}
		}

		// Token: 0x17001DEA RID: 7658
		// (get) Token: 0x06003A8B RID: 14987 RVA: 0x003729FC File Offset: 0x00370BFC
		public bool RadWideLabtoolEnhancedARS_A43084_HasDiffs
		{
			get
			{
				short num = (short)42729472;
				short num2 = num;
				num = (short)940071009;
				short num3 = num;
				num = (short)1825265761;
				switch (num3 == num)
				{
				}
				num = (short)636616704;
				if (num != 0)
				{
				}
				num = (short)854065153;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEnhancedARS_A43084._HasDiffs;
			}
		}

		// Token: 0x17001DEB RID: 7659
		// (get) Token: 0x06003A8C RID: 14988 RVA: 0x00372AB0 File Offset: 0x00370CB0
		// (set) Token: 0x06003A8D RID: 14989 RVA: 0x00372B64 File Offset: 0x00370D64
		public bool RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162Value
		{
			get
			{
				short num = (short)2054225920;
				short num2 = num;
				num = (short)1583762232;
				short num3 = num;
				num = (short)1915243320;
				switch (num3 == num)
				{
				}
				num = (short)254083072;
				if (num != 0)
				{
				}
				num = (short)2048262145;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.Value;
			}
			set
			{
				short num = (short)1045823488;
				short num2 = num;
				num = (short)1026836581;
				short num3 = num;
				num = (short)1678985317;
				switch (num3 == num)
				{
				}
				num = (short)1285816321;
				if (num != 0)
				{
				}
				num = (short)932970496;
				if (num != 0)
				{
				}
				this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.Value = value;
			}
		}

		// Token: 0x17001DEC RID: 7660
		// (get) Token: 0x06003A8E RID: 14990 RVA: 0x00372C1C File Offset: 0x00370E1C
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162
		{
			get
			{
				short num = (short)2107113472;
				short num2 = num;
				num = (short)971354398;
				short num3 = num;
				num = (short)1448980766;
				switch (num3 == num)
				{
				}
				num = (short)1485045761;
				if (num != 0)
				{
				}
				num = (short)1168769024;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162;
			}
		}

		// Token: 0x17001DED RID: 7661
		// (get) Token: 0x06003A8F RID: 14991 RVA: 0x00372CD0 File Offset: 0x00370ED0
		// (set) Token: 0x06003A90 RID: 14992 RVA: 0x00372D84 File Offset: 0x00370F84
		public bool RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162_UIValue
		{
			get
			{
				short num = (short)1563951104;
				short num2 = num;
				num = (short)365494273;
				if (num != 0)
				{
				}
				num = (short)29153050;
				short num3 = num;
				num = (short)1547360026;
				switch (num3 == num)
				{
				}
				num = (short)801701888;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.Value;
			}
			set
			{
				short num = (short)690225152;
				short num2 = num;
				num = (short)703456993;
				short num3 = num;
				num = (short)1588848353;
				switch (num3 == num)
				{
				}
				num = (short)793313280;
				if (num != 0)
				{
				}
				num = (short)1856110593;
				if (num != 0)
				{
				}
				this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.Value = value;
			}
		}

		// Token: 0x17001DEE RID: 7662
		// (get) Token: 0x06003A91 RID: 14993 RVA: 0x00372E3C File Offset: 0x0037103C
		// (set) Token: 0x06003A92 RID: 14994 RVA: 0x00372EF0 File Offset: 0x003710F0
		public bool RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162_Applicable
		{
			get
			{
				short num = (short)211943424;
				short num2 = num;
				num = (short)959879664;
				short num3 = num;
				num = (short)2024839664;
				switch (num3 == num)
				{
				}
				num = (short)1928069120;
				if (num != 0)
				{
				}
				num = (short)1374814209;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.Applicable;
			}
			set
			{
				short num = (short)1156055040;
				short num2 = num;
				num = (short)666370049;
				if (num != 0)
				{
				}
				num = (short)927576988;
				short num3 = num;
				num = (short)2138157980;
				switch (num3 == num)
				{
				}
				num = (short)1250951168;
				if (num != 0)
				{
				}
				this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.Applicable = value;
			}
		}

		// Token: 0x17001DEF RID: 7663
		// (get) Token: 0x06003A93 RID: 14995 RVA: 0x00372FA4 File Offset: 0x003711A4
		// (set) Token: 0x06003A94 RID: 14996 RVA: 0x0037305C File Offset: 0x0037125C
		public bool RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162_Valid
		{
			get
			{
				short num = (short)1678835712;
				short num2 = num;
				num = (short)232464704;
				short num3 = num;
				num = (short)550641984;
				switch (num3 == num)
				{
				}
				num = (short)1395589120;
				if (num != 0)
				{
				}
				num = (short)1531117569;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.Valid;
			}
			set
			{
				short num = (short)867958784;
				short num2 = num;
				num = (short)756605874;
				short num3 = num;
				num = (short)192603058;
				switch (num3 == num)
				{
				}
				num = (short)120193025;
				if (num != 0)
				{
				}
				num = (short)211812352;
				if (num != 0)
				{
				}
				this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.Valid = value;
			}
		}

		// Token: 0x17001DF0 RID: 7664
		// (get) Token: 0x06003A95 RID: 14997 RVA: 0x00373110 File Offset: 0x00371310
		// (set) Token: 0x06003A96 RID: 14998 RVA: 0x003731C8 File Offset: 0x003713C8
		public bool RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162_Visible
		{
			get
			{
				short num = (short)1726480384;
				short num2 = num;
				num = (short)2107467709;
				short num3 = num;
				num = (short)1501194173;
				switch (num3 == num)
				{
				}
				num = (short)1828716544;
				if (num != 0)
				{
				}
				num = (short)182648833;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.Visible;
			}
			set
			{
				short num = (short)1922957312;
				short num2 = num;
				num = (short)779777987;
				short num3 = num;
				num = (short)1240823747;
				switch (num3 == num)
				{
				}
				num = (short)1994522625;
				if (num != 0)
				{
				}
				num = (short)1810694144;
				if (num != 0)
				{
				}
				this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.Visible = value;
			}
		}

		// Token: 0x17001DF1 RID: 7665
		// (get) Token: 0x06003A97 RID: 14999 RVA: 0x0037327C File Offset: 0x0037147C
		// (set) Token: 0x06003A98 RID: 15000 RVA: 0x00373334 File Offset: 0x00371534
		public bool RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162_Editable
		{
			get
			{
				short num = (short)1074724864;
				short num2 = num;
				num = (short)226997196;
				short num3 = num;
				num = (short)1342944204;
				switch (num3 == num)
				{
				}
				num = (short)771555329;
				if (num != 0)
				{
				}
				num = (short)1471938560;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.Editable;
			}
			set
			{
				short num = (short)1102184448;
				short num2 = num;
				num = (short)1307312129;
				if (num != 0)
				{
				}
				num = (short)1535422304;
				short num3 = num;
				num = (short)1486663520;
				switch (num3 == num)
				{
				}
				num = (short)1575288832;
				if (num != 0)
				{
				}
				this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.Editable = value;
			}
		}

		// Token: 0x17001DF2 RID: 7666
		// (get) Token: 0x06003A99 RID: 15001 RVA: 0x003733E8 File Offset: 0x003715E8
		internal string RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162_UILabel
		{
			get
			{
				short num = (short)94699520;
				short num2 = num;
				num = (short)1450005926;
				short num3 = num;
				num = (short)269047206;
				switch (num3 == num)
				{
				}
				num = (short)35127296;
				if (num != 0)
				{
				}
				num = (short)1035010049;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.UIName;
			}
		}

		// Token: 0x17001DF3 RID: 7667
		// (get) Token: 0x06003A9A RID: 15002 RVA: 0x0037349C File Offset: 0x0037169C
		// (set) Token: 0x06003A9B RID: 15003 RVA: 0x00373550 File Offset: 0x00371750
		internal bool RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162_HiddenStatic
		{
			get
			{
				short num = (short)324206592;
				short num2 = num;
				num = (short)1626669057;
				if (num != 0)
				{
				}
				num = (short)499440163;
				short num3 = num;
				num = (short)388553251;
				switch (num3 == num)
				{
				}
				num = (short)923205632;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.HiddenStatic;
			}
			set
			{
				short num = (short)1588330496;
				short num2 = num;
				num = (short)1425595658;
				short num3 = num;
				num = (short)296803594;
				switch (num3 == num)
				{
				}
				num = (short)1072627712;
				if (num != 0)
				{
				}
				num = (short)990969857;
				if (num != 0)
				{
				}
				this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.HiddenStatic = value;
			}
		}

		// Token: 0x17001DF4 RID: 7668
		// (get) Token: 0x06003A9C RID: 15004 RVA: 0x00373608 File Offset: 0x00371808
		// (set) Token: 0x06003A9D RID: 15005 RVA: 0x003736BC File Offset: 0x003718BC
		internal bool RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162_HiddenDynamic
		{
			get
			{
				short num = (short)64815104;
				short num2 = num;
				num = (short)1658839724;
				short num3 = num;
				num = (short)39445164;
				switch (num3 == num)
				{
				}
				num = (short)608305152;
				if (num != 0)
				{
				}
				num = (short)718929921;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.HiddenDynamic;
			}
			set
			{
				short num = (short)91815936;
				short num2 = num;
				num = (short)1042284545;
				if (num != 0)
				{
				}
				num = (short)1357491686;
				short num3 = num;
				num = (short)259108326;
				switch (num3 == num)
				{
				}
				num = (short)19333120;
				if (num != 0)
				{
				}
				this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.HiddenDynamic = value;
			}
		}

		// Token: 0x17001DF5 RID: 7669
		// (get) Token: 0x06003A9E RID: 15006 RVA: 0x00373770 File Offset: 0x00371970
		public bool RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162_HasDiffs
		{
			get
			{
				short num = (short)1044578304;
				short num2 = num;
				num = (short)19595265;
				if (num != 0)
				{
				}
				num = (short)975300036;
				short num3 = num;
				num = (short)358278596;
				switch (num3 == num)
				{
				}
				num = (short)912523264;
				if (num != 0)
				{
				}
				return this.radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162._HasDiffs;
			}
		}

		// Token: 0x17001DF6 RID: 7670
		// (get) Token: 0x06003A9F RID: 15007 RVA: 0x00373824 File Offset: 0x00371A24
		// (set) Token: 0x06003AA0 RID: 15008 RVA: 0x003738DC File Offset: 0x00371ADC
		public bool RadioWideLabtoolZoneCloneCapable_43238Value
		{
			get
			{
				short num = (short)636092416;
				short num2 = num;
				num = (short)653421093;
				short num3 = num;
				num = (short)1377331749;
				switch (num3 == num)
				{
				}
				num = (short)2014904320;
				if (num != 0)
				{
				}
				num = (short)1089339393;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolZoneCloneCapable_43238.Value;
			}
			set
			{
				short num = (short)546459130;
				short num2 = num;
				num = (short)758074874;
				switch (num2 == num)
				{
				}
				num = (short)1460076544;
				if (num != 0)
				{
				}
				num = (short)1038548993;
				if (num != 0)
				{
				}
				num = (short)1801781248;
				short num3 = num;
				this.radioWideLabtoolZoneCloneCapable_43238.Value = value;
			}
		}

		// Token: 0x17001DF7 RID: 7671
		// (get) Token: 0x06003AA1 RID: 15009 RVA: 0x00373994 File Offset: 0x00371B94
		public global::AcpBusinessLayer.AcpField<bool> RadioWideLabtoolZoneCloneCapable_43238
		{
			get
			{
				short num = (short)1937506305;
				if (num != 0)
				{
				}
				num = (short)156976497;
				short num2 = num;
				num = (short)1972061553;
				switch (num2 == num)
				{
				}
				num = (short)99876864;
				if (num != 0)
				{
				}
				num = (short)2109865984;
				short num3 = num;
				return this.radioWideLabtoolZoneCloneCapable_43238;
			}
		}

		// Token: 0x17001DF8 RID: 7672
		// (get) Token: 0x06003AA2 RID: 15010 RVA: 0x00373A44 File Offset: 0x00371C44
		// (set) Token: 0x06003AA3 RID: 15011 RVA: 0x00373AF8 File Offset: 0x00371CF8
		public bool RadioWideLabtoolZoneCloneCapable_43238_UIValue
		{
			get
			{
				short num = (short)1878603996;
				short num2 = num;
				num = (short)253180124;
				switch (num2 == num)
				{
				}
				num = (short)288555009;
				if (num != 0)
				{
				}
				num = (short)819920896;
				if (num != 0)
				{
				}
				num = (short)1348599808;
				short num3 = num;
				return this.radioWideLabtoolZoneCloneCapable_43238.Value;
			}
			set
			{
				short num = (short)1114317336;
				short num2 = num;
				num = (short)613884440;
				switch (num2 == num)
				{
				}
				num = (short)24248321;
				if (num != 0)
				{
				}
				num = (short)994312192;
				if (num != 0)
				{
				}
				num = (short)1550647296;
				short num3 = num;
				this.radioWideLabtoolZoneCloneCapable_43238.Value = value;
			}
		}

		// Token: 0x17001DF9 RID: 7673
		// (get) Token: 0x06003AA4 RID: 15012 RVA: 0x00373BB0 File Offset: 0x00371DB0
		// (set) Token: 0x06003AA5 RID: 15013 RVA: 0x00373C64 File Offset: 0x00371E64
		public bool RadioWideLabtoolZoneCloneCapable_43238_Applicable
		{
			get
			{
				short num = (short)64705380;
				short num2 = num;
				num = (short)1640125284;
				switch (num2 == num)
				{
				}
				num = (short)1174405121;
				if (num != 0)
				{
				}
				num = (short)487456768;
				if (num != 0)
				{
				}
				num = (short)419037184;
				short num3 = num;
				return this.radioWideLabtoolZoneCloneCapable_43238.Applicable;
			}
			set
			{
				short num = (short)430009413;
				short num2 = num;
				num = (short)64252997;
				switch (num2 == num)
				{
				}
				num = (short)1312096257;
				if (num != 0)
				{
				}
				num = (short)1816002560;
				if (num != 0)
				{
				}
				num = (short)746061824;
				short num3 = num;
				this.radioWideLabtoolZoneCloneCapable_43238.Applicable = value;
			}
		}

		// Token: 0x17001DFA RID: 7674
		// (get) Token: 0x06003AA6 RID: 15014 RVA: 0x00373D1C File Offset: 0x00371F1C
		// (set) Token: 0x06003AA7 RID: 15015 RVA: 0x00373DD0 File Offset: 0x00371FD0
		public bool RadioWideLabtoolZoneCloneCapable_43238_Valid
		{
			get
			{
				short num = (short)554296617;
				short num2 = num;
				num = (short)169731369;
				switch (num2 == num)
				{
				}
				num = (short)1884880896;
				if (num != 0)
				{
				}
				num = (short)1153499137;
				if (num != 0)
				{
				}
				num = (short)540016640;
				short num3 = num;
				return this.radioWideLabtoolZoneCloneCapable_43238.Valid;
			}
			set
			{
				short num = (short)208821733;
				short num2 = num;
				num = (short)668294629;
				switch (num2 == num)
				{
				}
				num = (short)1142554625;
				if (num != 0)
				{
				}
				num = (short)626196480;
				if (num != 0)
				{
				}
				num = (short)1116995584;
				short num3 = num;
				this.radioWideLabtoolZoneCloneCapable_43238.Valid = value;
			}
		}

		// Token: 0x17001DFB RID: 7675
		// (get) Token: 0x06003AA8 RID: 15016 RVA: 0x00373E84 File Offset: 0x00372084
		// (set) Token: 0x06003AA9 RID: 15017 RVA: 0x00373F38 File Offset: 0x00372138
		public bool RadioWideLabtoolZoneCloneCapable_43238_Visible
		{
			get
			{
				short num = (short)1236343025;
				short num2 = num;
				num = (short)1130174705;
				switch (num2 == num)
				{
				}
				num = (short)731185153;
				if (num != 0)
				{
				}
				num = (short)50790400;
				if (num != 0)
				{
				}
				num = (short)281739264;
				short num3 = num;
				return this.radioWideLabtoolZoneCloneCapable_43238.Visible;
			}
			set
			{
				short num = (short)1594215922;
				short num2 = num;
				num = (short)470339058;
				switch (num2 == num)
				{
				}
				num = (short)717357057;
				if (num != 0)
				{
				}
				num = (short)1724841984;
				if (num != 0)
				{
				}
				num = (short)495058944;
				short num3 = num;
				this.radioWideLabtoolZoneCloneCapable_43238.Visible = value;
			}
		}

		// Token: 0x17001DFC RID: 7676
		// (get) Token: 0x06003AAA RID: 15018 RVA: 0x00373FEC File Offset: 0x003721EC
		// (set) Token: 0x06003AAB RID: 15019 RVA: 0x003740A0 File Offset: 0x003722A0
		public bool RadioWideLabtoolZoneCloneCapable_43238_Editable
		{
			get
			{
				short num = (short)1844705003;
				short num2 = num;
				num = (short)2114057963;
				switch (num2 == num)
				{
				}
				num = (short)144179201;
				if (num != 0)
				{
				}
				num = (short)953286656;
				if (num != 0)
				{
				}
				num = (short)368246784;
				short num3 = num;
				return this.radioWideLabtoolZoneCloneCapable_43238.Editable;
			}
			set
			{
				short num = (short)167393756;
				short num2 = num;
				num = (short)1790982620;
				switch (num2 == num)
				{
				}
				num = (short)902430720;
				if (num != 0)
				{
				}
				num = (short)898695169;
				if (num != 0)
				{
				}
				num = (short)1204420608;
				short num3 = num;
				this.radioWideLabtoolZoneCloneCapable_43238.Editable = value;
			}
		}

		// Token: 0x17001DFD RID: 7677
		// (get) Token: 0x06003AAC RID: 15020 RVA: 0x00374154 File Offset: 0x00372354
		internal string RadioWideLabtoolZoneCloneCapable_43238_UILabel
		{
			get
			{
				short num = (short)1498824083;
				short num2 = num;
				num = (short)584793491;
				switch (num2 == num)
				{
				}
				num = (short)496238592;
				if (num != 0)
				{
				}
				num = (short)558563328;
				short num3 = num;
				num = (short)1133117441;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolZoneCloneCapable_43238.UIName;
			}
		}

		// Token: 0x17001DFE RID: 7678
		// (get) Token: 0x06003AAD RID: 15021 RVA: 0x00374208 File Offset: 0x00372408
		// (set) Token: 0x06003AAE RID: 15022 RVA: 0x003742BC File Offset: 0x003724BC
		internal bool RadioWideLabtoolZoneCloneCapable_43238_HiddenStatic
		{
			get
			{
				short num = (short)2090398983;
				short num2 = num;
				num = (short)197719303;
				switch (num2 == num)
				{
				}
				num = (short)2021130241;
				if (num != 0)
				{
				}
				num = (short)1696595968;
				short num3 = num;
				num = (short)1091371008;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolZoneCloneCapable_43238.HiddenStatic;
			}
			set
			{
				short num = (short)831011131;
				short num2 = num;
				num = (short)759576891;
				switch (num2 == num)
				{
				}
				num = (short)634716161;
				if (num != 0)
				{
				}
				num = (short)1807417344;
				short num3 = num;
				num = (short)963575808;
				if (num != 0)
				{
				}
				this.radioWideLabtoolZoneCloneCapable_43238.HiddenStatic = value;
			}
		}

		// Token: 0x17001DFF RID: 7679
		// (get) Token: 0x06003AAF RID: 15023 RVA: 0x00374370 File Offset: 0x00372570
		// (set) Token: 0x06003AB0 RID: 15024 RVA: 0x00374424 File Offset: 0x00372624
		internal bool RadioWideLabtoolZoneCloneCapable_43238_HiddenDynamic
		{
			get
			{
				short num = (short)194599951;
				short num2 = num;
				num = (short)709516303;
				switch (num2 == num)
				{
				}
				num = (short)101318656;
				if (num != 0)
				{
				}
				num = (short)502595584;
				short num3 = num;
				num = (short)368771073;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolZoneCloneCapable_43238.HiddenDynamic;
			}
			set
			{
				short num = (short)1550683231;
				short num2 = num;
				num = (short)776178783;
				switch (num2 == num)
				{
				}
				num = (short)423952385;
				if (num != 0)
				{
				}
				num = (short)296353792;
				short num3 = num;
				num = (short)356581376;
				if (num != 0)
				{
				}
				this.radioWideLabtoolZoneCloneCapable_43238.HiddenDynamic = value;
			}
		}

		// Token: 0x17001E00 RID: 7680
		// (get) Token: 0x06003AB1 RID: 15025 RVA: 0x003744D8 File Offset: 0x003726D8
		public bool RadioWideLabtoolZoneCloneCapable_43238_HasDiffs
		{
			get
			{
				short num = (short)1962615897;
				short num2 = num;
				num = (short)1591157849;
				switch (num2 == num)
				{
				}
				num = (short)1158414337;
				if (num != 0)
				{
				}
				num = (short)839909376;
				short num3 = num;
				num = (short)859963392;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolZoneCloneCapable_43238._HasDiffs;
			}
		}

		// Token: 0x17001E01 RID: 7681
		// (get) Token: 0x06003AB2 RID: 15026 RVA: 0x0037458C File Offset: 0x0037278C
		// (set) Token: 0x06003AB3 RID: 15027 RVA: 0x00374640 File Offset: 0x00372840
		public bool RadioWideLabtoolEmergencyCallTermination_43348Value
		{
			get
			{
				short num = (short)771312990;
				short num2 = num;
				num = (short)1223707998;
				switch (num2 == num)
				{
				}
				num = (short)705822721;
				if (num != 0)
				{
				}
				num = (short)2031353856;
				short num3 = num;
				num = (short)484835328;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolEmergencyCallTermination_43348.Value;
			}
			set
			{
				short num = (short)900264926;
				short num2 = num;
				num = (short)326366174;
				switch (num2 == num)
				{
				}
				num = (short)973733889;
				if (num != 0)
				{
				}
				num = (short)1642135552;
				short num3 = num;
				num = (short)2113273856;
				if (num != 0)
				{
				}
				this.radioWideLabtoolEmergencyCallTermination_43348.Value = value;
			}
		}

		// Token: 0x17001E02 RID: 7682
		// (get) Token: 0x06003AB4 RID: 15028 RVA: 0x003746F4 File Offset: 0x003728F4
		public global::AcpBusinessLayer.AcpField<bool> RadioWideLabtoolEmergencyCallTermination_43348
		{
			get
			{
				short num = (short)1035521776;
				short num2 = num;
				num = (short)443666160;
				switch (num2 == num)
				{
				}
				num = (short)255459329;
				if (num != 0)
				{
				}
				num = (short)1830748160;
				short num3 = num;
				num = (short)1753546752;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolEmergencyCallTermination_43348;
			}
		}

		// Token: 0x17001E03 RID: 7683
		// (get) Token: 0x06003AB5 RID: 15029 RVA: 0x003747A4 File Offset: 0x003729A4
		// (set) Token: 0x06003AB6 RID: 15030 RVA: 0x00374858 File Offset: 0x00372A58
		public bool RadioWideLabtoolEmergencyCallTermination_43348_UIValue
		{
			get
			{
				short num = (short)458960197;
				short num2 = num;
				num = (short)37432645;
				switch (num2 == num)
				{
				}
				num = (short)2109669377;
				if (num != 0)
				{
				}
				num = (short)1982332928;
				short num3 = num;
				num = (short)407371776;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolEmergencyCallTermination_43348.Value;
			}
			set
			{
				short num = (short)1104740353;
				if (num != 0)
				{
				}
				num = (short)2035284122;
				short num2 = num;
				num = (short)1265694874;
				switch (num2 == num)
				{
				}
				num = (short)427360256;
				short num3 = num;
				num = (short)690618368;
				if (num != 0)
				{
				}
				this.radioWideLabtoolEmergencyCallTermination_43348.Value = value;
			}
		}

		// Token: 0x17001E04 RID: 7684
		// (get) Token: 0x06003AB7 RID: 15031 RVA: 0x0037490C File Offset: 0x00372B0C
		// (set) Token: 0x06003AB8 RID: 15032 RVA: 0x003749C4 File Offset: 0x00372BC4
		public bool RadioWideLabtoolEmergencyCallTermination_43348_Applicable
		{
			get
			{
				short num = (short)1057071201;
				short num2 = num;
				num = (short)667394145;
				switch (num2 == num)
				{
				}
				num = (short)1220083713;
				if (num != 0)
				{
				}
				num = (short)300744704;
				short num3 = num;
				num = (short)577044480;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolEmergencyCallTermination_43348.Applicable;
			}
			set
			{
				short num = (short)1708259593;
				short num2 = num;
				num = (short)748288265;
				switch (num2 == num)
				{
				}
				num = (short)2109407232;
				if (num != 0)
				{
				}
				num = (short)143261696;
				short num3 = num;
				num = (short)1213595649;
				if (num != 0)
				{
				}
				this.radioWideLabtoolEmergencyCallTermination_43348.Applicable = value;
			}
		}

		// Token: 0x17001E05 RID: 7685
		// (get) Token: 0x06003AB9 RID: 15033 RVA: 0x00374A78 File Offset: 0x00372C78
		// (set) Token: 0x06003ABA RID: 15034 RVA: 0x00374B2C File Offset: 0x00372D2C
		public bool RadioWideLabtoolEmergencyCallTermination_43348_Valid
		{
			get
			{
				short num = (short)1124007937;
				if (num != 0)
				{
				}
				num = (short)1206531910;
				short num2 = num;
				num = (short)417150790;
				switch (num2 == num)
				{
				}
				num = (short)922353664;
				short num3 = num;
				num = (short)2130182144;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolEmergencyCallTermination_43348.Valid;
			}
			set
			{
				short num = (short)1173931332;
				short num2 = num;
				num = (short)1800652100;
				switch (num2 == num)
				{
				}
				num = (short)1195180032;
				if (num != 0)
				{
				}
				num = (short)1964376064;
				short num3 = num;
				num = (short)1840185345;
				if (num != 0)
				{
				}
				this.radioWideLabtoolEmergencyCallTermination_43348.Valid = value;
			}
		}

		// Token: 0x17001E06 RID: 7686
		// (get) Token: 0x06003ABB RID: 15035 RVA: 0x00374BE0 File Offset: 0x00372DE0
		// (set) Token: 0x06003ABC RID: 15036 RVA: 0x00374C94 File Offset: 0x00372E94
		public bool RadioWideLabtoolEmergencyCallTermination_43348_Visible
		{
			get
			{
				short num = (short)282187332;
				short num2 = num;
				num = (short)763549252;
				switch (num2 == num)
				{
				}
				num = (short)1584070657;
				if (num != 0)
				{
				}
				num = (short)2057699328;
				short num3 = num;
				num = (short)1534722048;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolEmergencyCallTermination_43348.Visible;
			}
			set
			{
				short num = (short)1825619592;
				short num2 = num;
				num = (short)1171635848;
				switch (num2 == num)
				{
				}
				num = (short)357695488;
				if (num != 0)
				{
				}
				num = (short)1755185152;
				short num3 = num;
				num = (short)2071003137;
				if (num != 0)
				{
				}
				this.radioWideLabtoolEmergencyCallTermination_43348.Visible = value;
			}
		}

		// Token: 0x17001E07 RID: 7687
		// (get) Token: 0x06003ABD RID: 15037 RVA: 0x00374D4C File Offset: 0x00372F4C
		// (set) Token: 0x06003ABE RID: 15038 RVA: 0x00374E04 File Offset: 0x00373004
		public bool RadioWideLabtoolEmergencyCallTermination_43348_Editable
		{
			get
			{
				short num = (short)780546496;
				short num2 = num;
				num = (short)1118253504;
				switch (num2 == num)
				{
				}
				num = (short)832700417;
				if (num != 0)
				{
				}
				num = (short)1916928000;
				short num3 = num;
				num = (short)1831534592;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolEmergencyCallTermination_43348.Editable;
			}
			set
			{
				short num = (short)960158565;
				short num2 = num;
				num = (short)1794956133;
				switch (num2 == num)
				{
				}
				num = (short)1933508609;
				if (num != 0)
				{
				}
				num = (short)2020343808;
				short num3 = num;
				num = (short)280100864;
				if (num != 0)
				{
				}
				this.radioWideLabtoolEmergencyCallTermination_43348.Editable = value;
			}
		}

		// Token: 0x17001E08 RID: 7688
		// (get) Token: 0x06003ABF RID: 15039 RVA: 0x00374EBC File Offset: 0x003730BC
		internal string RadioWideLabtoolEmergencyCallTermination_43348_UILabel
		{
			get
			{
				short num = (short)1785642030;
				short num2 = num;
				num = (short)1199815726;
				switch (num2 == num)
				{
				}
				num = (short)1235877889;
				if (num != 0)
				{
				}
				num = (short)963706880;
				short num3 = num;
				num = (short)2129723392;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolEmergencyCallTermination_43348.UIName;
			}
		}

		// Token: 0x17001E09 RID: 7689
		// (get) Token: 0x06003AC0 RID: 15040 RVA: 0x00374F74 File Offset: 0x00373174
		// (set) Token: 0x06003AC1 RID: 15041 RVA: 0x00375028 File Offset: 0x00373228
		internal bool RadioWideLabtoolEmergencyCallTermination_43348_HiddenStatic
		{
			get
			{
				short num = (short)1275856156;
				short num2 = num;
				num = (short)574883100;
				switch (num2 == num)
				{
				}
				num = (short)1088225281;
				if (num != 0)
				{
				}
				num = (short)10813440;
				short num3 = num;
				num = (short)409010176;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolEmergencyCallTermination_43348.HiddenStatic;
			}
			set
			{
				short num = (short)822540776;
				short num2 = num;
				num = (short)1349253608;
				switch (num2 == num)
				{
				}
				num = (short)554565632;
				if (num != 0)
				{
				}
				num = (short)574357504;
				short num3 = num;
				num = (short)715653121;
				if (num != 0)
				{
				}
				this.radioWideLabtoolEmergencyCallTermination_43348.HiddenStatic = value;
			}
		}

		// Token: 0x17001E0A RID: 7690
		// (get) Token: 0x06003AC2 RID: 15042 RVA: 0x003750DC File Offset: 0x003732DC
		// (set) Token: 0x06003AC3 RID: 15043 RVA: 0x0037518C File Offset: 0x0037338C
		internal bool RadioWideLabtoolEmergencyCallTermination_43348_HiddenDynamic
		{
			get
			{
				short num = (short)940313191;
				short num2 = num;
				num = (short)199494247;
				switch (num2 == num)
				{
				}
				num = (short)609353728;
				if (num != 0)
				{
				}
				num = (short)1387528192;
				short num3 = num;
				num = (short)1661730817;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolEmergencyCallTermination_43348.HiddenDynamic;
			}
			set
			{
				short num = (short)261359046;
				short num2 = num;
				num = (short)555812294;
				switch (num2 == num)
				{
				}
				num = (short)1081868288;
				if (num != 0)
				{
				}
				num = (short)596967424;
				short num3 = num;
				num = (short)1331494913;
				if (num != 0)
				{
				}
				this.radioWideLabtoolEmergencyCallTermination_43348.HiddenDynamic = value;
			}
		}

		// Token: 0x17001E0B RID: 7691
		// (get) Token: 0x06003AC4 RID: 15044 RVA: 0x00375244 File Offset: 0x00373444
		public bool RadioWideLabtoolEmergencyCallTermination_43348_HasDiffs
		{
			get
			{
				short num = (short)1452871561;
				short num2 = num;
				num = (short)1568345993;
				switch (num2 == num)
				{
				}
				num = (short)1616183297;
				if (num != 0)
				{
				}
				num = (short)1354039296;
				short num3 = num;
				num = (short)1479213056;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolEmergencyCallTermination_43348._HasDiffs;
			}
		}

		// Token: 0x17001E0C RID: 7692
		// (get) Token: 0x06003AC5 RID: 15045 RVA: 0x003752F8 File Offset: 0x003734F8
		// (set) Token: 0x06003AC6 RID: 15046 RVA: 0x003753B0 File Offset: 0x003735B0
		public bool RadWideLabtoolDisableEncryption_43371Value
		{
			get
			{
				short num = (short)850759430;
				short num2 = num;
				num = (short)108564230;
				switch (num2 == num)
				{
				}
				num = (short)219807744;
				if (num != 0)
				{
				}
				num = (short)811270144;
				short num3 = num;
				num = (short)1128005633;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisableEncryption_43371.Value;
			}
			set
			{
				short num = (short)102269878;
				short num2 = num;
				num = (short)297436086;
				switch (num2 == num)
				{
				}
				num = (short)1309409280;
				if (num != 0)
				{
				}
				num = (short)290783232;
				short num3 = num;
				num = (short)809893889;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisableEncryption_43371.Value = value;
			}
		}

		// Token: 0x17001E0D RID: 7693
		// (get) Token: 0x06003AC7 RID: 15047 RVA: 0x00375468 File Offset: 0x00373668
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolDisableEncryption_43371
		{
			get
			{
				short num = (short)759069340;
				short num2 = num;
				num = (short)581204636;
				switch (num2 == num)
				{
				}
				num = (short)822214657;
				if (num != 0)
				{
				}
				num = (short)2133393408;
				short num3 = num;
				num = (short)1484128256;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisableEncryption_43371;
			}
		}

		// Token: 0x17001E0E RID: 7694
		// (get) Token: 0x06003AC8 RID: 15048 RVA: 0x00375518 File Offset: 0x00373718
		// (set) Token: 0x06003AC9 RID: 15049 RVA: 0x003755CC File Offset: 0x003737CC
		public bool RadWideLabtoolDisableEncryption_43371_UIValue
		{
			get
			{
				short num = (short)507445249;
				if (num != 0)
				{
				}
				num = (short)1005106375;
				short num2 = num;
				num = (short)642364615;
				switch (num2 == num)
				{
				}
				num = (short)1854799872;
				short num3 = num;
				num = (short)1303314432;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisableEncryption_43371.Value;
			}
			set
			{
				short num = (short)779376055;
				short num2 = num;
				num = (short)328226231;
				switch (num2 == num)
				{
				}
				num = (short)1997340672;
				if (num != 0)
				{
				}
				num = (short)384565248;
				short num3 = num;
				num = (short)428081153;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisableEncryption_43371.Value = value;
			}
		}

		// Token: 0x17001E0F RID: 7695
		// (get) Token: 0x06003ACA RID: 15050 RVA: 0x00375680 File Offset: 0x00373880
		// (set) Token: 0x06003ACB RID: 15051 RVA: 0x00375734 File Offset: 0x00373934
		public bool RadWideLabtoolDisableEncryption_43371_Applicable
		{
			get
			{
				short num = (short)1310132303;
				short num2 = num;
				num = (short)1842219087;
				switch (num2 == num)
				{
				}
				num = (short)1017708545;
				if (num != 0)
				{
				}
				num = (short)747044864;
				short num3 = num;
				num = (short)71303168;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisableEncryption_43371.Applicable;
			}
			set
			{
				short num = (short)1862538688;
				short num2 = num;
				num = (short)333845952;
				switch (num2 == num)
				{
				}
				num = (short)919863297;
				if (num != 0)
				{
				}
				num = (short)305856512;
				short num3 = num;
				num = (short)893845504;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisableEncryption_43371.Applicable = value;
			}
		}

		// Token: 0x17001E10 RID: 7696
		// (get) Token: 0x06003ACC RID: 15052 RVA: 0x003757E8 File Offset: 0x003739E8
		// (set) Token: 0x06003ACD RID: 15053 RVA: 0x0037589C File Offset: 0x00373A9C
		public bool RadWideLabtoolDisableEncryption_43371_Valid
		{
			get
			{
				short num = (short)1174434002;
				short num2 = num;
				num = (short)1700557010;
				switch (num2 == num)
				{
				}
				num = (short)836239361;
				if (num != 0)
				{
				}
				num = (short)758841344;
				short num3 = num;
				num = (short)1385758720;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisableEncryption_43371.Valid;
			}
			set
			{
				short num = (short)938425831;
				short num2 = num;
				num = (short)884948455;
				switch (num2 == num)
				{
				}
				num = (short)1502740481;
				if (num != 0)
				{
				}
				num = (short)1368588288;
				short num3 = num;
				num = (short)1692336128;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisableEncryption_43371.Valid = value;
			}
		}

		// Token: 0x17001E11 RID: 7697
		// (get) Token: 0x06003ACE RID: 15054 RVA: 0x00375954 File Offset: 0x00373B54
		// (set) Token: 0x06003ACF RID: 15055 RVA: 0x00375A08 File Offset: 0x00373C08
		public bool RadWideLabtoolDisableEncryption_43371_Visible
		{
			get
			{
				short num = (short)1360557624;
				short num2 = num;
				num = (short)1987999288;
				switch (num2 == num)
				{
				}
				num = (short)1819475969;
				if (num != 0)
				{
				}
				num = (short)227475456;
				short num3 = num;
				num = (short)1827995648;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisableEncryption_43371.Visible;
			}
			set
			{
				short num = (short)252426841;
				short num2 = num;
				num = (short)567851609;
				switch (num2 == num)
				{
				}
				num = (short)980025345;
				if (num != 0)
				{
				}
				num = (short)906887168;
				short num3 = num;
				num = (short)395444224;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisableEncryption_43371.Visible = value;
			}
		}

		// Token: 0x17001E12 RID: 7698
		// (get) Token: 0x06003AD0 RID: 15056 RVA: 0x00375ABC File Offset: 0x00373CBC
		// (set) Token: 0x06003AD1 RID: 15057 RVA: 0x00375B70 File Offset: 0x00373D70
		public bool RadWideLabtoolDisableEncryption_43371_Editable
		{
			get
			{
				short num = (short)280566891;
				short num2 = num;
				num = (short)818355307;
				switch (num2 == num)
				{
				}
				num = (short)1460011009;
				if (num != 0)
				{
				}
				num = (short)246874112;
				short num3 = num;
				num = (short)989396992;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisableEncryption_43371.Editable;
			}
			set
			{
				short num = (short)956595731;
				short num2 = num;
				num = (short)161840659;
				switch (num2 == num)
				{
				}
				num = (short)553451521;
				if (num != 0)
				{
				}
				num = (short)2129985536;
				short num3 = num;
				num = (short)1834287104;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisableEncryption_43371.Editable = value;
			}
		}

		// Token: 0x17001E13 RID: 7699
		// (get) Token: 0x06003AD2 RID: 15058 RVA: 0x00375C24 File Offset: 0x00373E24
		internal string RadWideLabtoolDisableEncryption_43371_UILabel
		{
			get
			{
				short num = (short)776032427;
				short num2 = num;
				num = (short)649089195;
				switch (num2 == num)
				{
				}
				num = (short)535494657;
				if (num != 0)
				{
				}
				num = (short)588054528;
				short num3 = num;
				num = (short)2083782656;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisableEncryption_43371.UIName;
			}
		}

		// Token: 0x17001E14 RID: 7700
		// (get) Token: 0x06003AD3 RID: 15059 RVA: 0x00375CD8 File Offset: 0x00373ED8
		// (set) Token: 0x06003AD4 RID: 15060 RVA: 0x00375D90 File Offset: 0x00373F90
		internal bool RadWideLabtoolDisableEncryption_43371_HiddenStatic
		{
			get
			{
				short num = (short)1526251090;
				short num2 = num;
				num = (short)1002421842;
				switch (num2 == num)
				{
				}
				num = (short)1525022721;
				if (num != 0)
				{
				}
				num = (short)2122579968;
				short num3 = num;
				num = (short)231866368;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisableEncryption_43371.HiddenStatic;
			}
			set
			{
				short num = (short)444620935;
				short num2 = num;
				num = (short)1490641031;
				switch (num2 == num)
				{
				}
				num = (short)1142685697;
				if (num != 0)
				{
				}
				num = (short)417923072;
				short num3 = num;
				num = (short)1844772864;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisableEncryption_43371.HiddenStatic = value;
			}
		}

		// Token: 0x17001E15 RID: 7701
		// (get) Token: 0x06003AD5 RID: 15061 RVA: 0x00375E4C File Offset: 0x0037404C
		// (set) Token: 0x06003AD6 RID: 15062 RVA: 0x00375F00 File Offset: 0x00374100
		internal bool RadWideLabtoolDisableEncryption_43371_HiddenDynamic
		{
			get
			{
				short num = (short)852357605;
				short num2 = num;
				num = (short)1190654437;
				switch (num2 == num)
				{
				}
				num = (short)92667904;
				if (num != 0)
				{
				}
				num = (short)1580793856;
				short num3 = num;
				num = (short)1616314369;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisableEncryption_43371.HiddenDynamic;
			}
			set
			{
				short num = (short)1359649588;
				short num2 = num;
				num = (short)188783412;
				switch (num2 == num)
				{
				}
				num = (short)585760769;
				if (num != 0)
				{
				}
				num = (short)888602624;
				short num3 = num;
				num = (short)569180160;
				if (num != 0)
				{
				}
				this.radWideLabtoolDisableEncryption_43371.HiddenDynamic = value;
			}
		}

		// Token: 0x17001E16 RID: 7702
		// (get) Token: 0x06003AD7 RID: 15063 RVA: 0x00375FB8 File Offset: 0x003741B8
		public bool RadWideLabtoolDisableEncryption_43371_HasDiffs
		{
			get
			{
				short num = (short)1705451700;
				short num2 = num;
				num = (short)419373236;
				switch (num2 == num)
				{
				}
				num = (short)105906177;
				if (num != 0)
				{
				}
				num = (short)914227200;
				short num3 = num;
				num = (short)831324160;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDisableEncryption_43371._HasDiffs;
			}
		}

		// Token: 0x17001E17 RID: 7703
		// (get) Token: 0x06003AD8 RID: 15064 RVA: 0x0037606C File Offset: 0x0037426C
		// (set) Token: 0x06003AD9 RID: 15065 RVA: 0x00376124 File Offset: 0x00374324
		public bool RadWideLabtoolIntelligentPriorityScanCapable_43411Value
		{
			get
			{
				short num = (short)1010584791;
				short num2 = num;
				num = (short)1857375447;
				switch (num2 == num)
				{
				}
				num = (short)1234173952;
				if (num != 0)
				{
				}
				num = (short)82771968;
				short num3 = num;
				num = (short)1563688961;
				if (num != 0)
				{
				}
				return this.radWideLabtoolIntelligentPriorityScanCapable_43411.Value;
			}
			set
			{
				short num = (short)895326331;
				short num2 = num;
				num = (short)896899195;
				switch (num2 == num)
				{
				}
				num = (short)652673025;
				if (num != 0)
				{
				}
				num = (short)448790528;
				short num3 = num;
				num = (short)1667563520;
				if (num != 0)
				{
				}
				this.radWideLabtoolIntelligentPriorityScanCapable_43411.Value = value;
			}
		}

		// Token: 0x17001E18 RID: 7704
		// (get) Token: 0x06003ADA RID: 15066 RVA: 0x003761DC File Offset: 0x003743DC
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolIntelligentPriorityScanCapable_43411
		{
			get
			{
				short num = (short)531573007;
				short num2 = num;
				num = (short)1263216911;
				switch (num2 == num)
				{
				}
				num = (short)1009975297;
				if (num != 0)
				{
				}
				num = (short)1768226816;
				short num3 = num;
				num = (short)279707648;
				if (num != 0)
				{
				}
				return this.radWideLabtoolIntelligentPriorityScanCapable_43411;
			}
		}

		// Token: 0x17001E19 RID: 7705
		// (get) Token: 0x06003ADB RID: 15067 RVA: 0x00376288 File Offset: 0x00374488
		// (set) Token: 0x06003ADC RID: 15068 RVA: 0x0037633C File Offset: 0x0037453C
		public bool RadWideLabtoolIntelligentPriorityScanCapable_43411_UIValue
		{
			get
			{
				short num = (short)1434721310;
				short num2 = num;
				num = (short)1401691166;
				switch (num2 == num)
				{
				}
				num = (short)859242497;
				if (num != 0)
				{
				}
				num = (short)1114832896;
				short num3 = num;
				num = (short)349437952;
				if (num != 0)
				{
				}
				return this.radWideLabtoolIntelligentPriorityScanCapable_43411.Value;
			}
			set
			{
				short num = (short)1382917888;
				short num2 = num;
				num = (short)514369280;
				switch (num2 == num)
				{
				}
				num = (short)444989441;
				if (num != 0)
				{
				}
				num = (short)793378816;
				short num3 = num;
				num = (short)256704512;
				if (num != 0)
				{
				}
				this.radWideLabtoolIntelligentPriorityScanCapable_43411.Value = value;
			}
		}

		// Token: 0x17001E1A RID: 7706
		// (get) Token: 0x06003ADD RID: 15069 RVA: 0x003763F0 File Offset: 0x003745F0
		// (set) Token: 0x06003ADE RID: 15070 RVA: 0x003764A4 File Offset: 0x003746A4
		public bool RadWideLabtoolIntelligentPriorityScanCapable_43411_Applicable
		{
			get
			{
				short num = (short)1759514341;
				short num2 = num;
				num = (short)758648549;
				switch (num2 == num)
				{
				}
				num = (short)1602617345;
				if (num != 0)
				{
				}
				num = (short)711655424;
				short num3 = num;
				num = (short)454361088;
				if (num != 0)
				{
				}
				return this.radWideLabtoolIntelligentPriorityScanCapable_43411.Applicable;
			}
			set
			{
				short num = (short)1345167196;
				short num2 = num;
				num = (short)252616540;
				switch (num2 == num)
				{
				}
				num = (short)1667301377;
				if (num != 0)
				{
				}
				num = (short)155123712;
				short num3 = num;
				num = (short)722337792;
				if (num != 0)
				{
				}
				this.radWideLabtoolIntelligentPriorityScanCapable_43411.Applicable = value;
			}
		}

		// Token: 0x17001E1B RID: 7707
		// (get) Token: 0x06003ADF RID: 15071 RVA: 0x00376558 File Offset: 0x00374758
		// (set) Token: 0x06003AE0 RID: 15072 RVA: 0x00376610 File Offset: 0x00374810
		public bool RadWideLabtoolIntelligentPriorityScanCapable_43411_Valid
		{
			get
			{
				short num = (short)1949099824;
				short num2 = num;
				num = (short)456451888;
				switch (num2 == num)
				{
				}
				num = (short)730923009;
				if (num != 0)
				{
				}
				num = (short)1632894976;
				short num3 = num;
				num = (short)2071855104;
				if (num != 0)
				{
				}
				return this.radWideLabtoolIntelligentPriorityScanCapable_43411.Valid;
			}
			set
			{
				short num = (short)1539175052;
				short num2 = num;
				num = (short)1825501836;
				switch (num2 == num)
				{
				}
				num = (short)351404033;
				if (num != 0)
				{
				}
				num = (short)1571618816;
				short num3 = num;
				num = (short)815792128;
				if (num != 0)
				{
				}
				this.radWideLabtoolIntelligentPriorityScanCapable_43411.Valid = value;
			}
		}

		// Token: 0x17001E1C RID: 7708
		// (get) Token: 0x06003AE1 RID: 15073 RVA: 0x003766C4 File Offset: 0x003748C4
		// (set) Token: 0x06003AE2 RID: 15074 RVA: 0x00376778 File Offset: 0x00374978
		public bool RadWideLabtoolIntelligentPriorityScanCapable_43411_Visible
		{
			get
			{
				short num = (short)2006727357;
				short num2 = num;
				num = (short)1647262397;
				switch (num2 == num)
				{
				}
				num = (short)1436418049;
				if (num != 0)
				{
				}
				num = (short)466223104;
				short num3 = num;
				num = (short)607649792;
				if (num != 0)
				{
				}
				return this.radWideLabtoolIntelligentPriorityScanCapable_43411.Visible;
			}
			set
			{
				short num = (short)1909077183;
				short num2 = num;
				num = (short)775238847;
				switch (num2 == num)
				{
				}
				num = (short)1297874945;
				if (num != 0)
				{
				}
				num = (short)317063168;
				short num3 = num;
				num = (short)1785856000;
				if (num != 0)
				{
				}
				this.radWideLabtoolIntelligentPriorityScanCapable_43411.Visible = value;
			}
		}

		// Token: 0x17001E1D RID: 7709
		// (get) Token: 0x06003AE3 RID: 15075 RVA: 0x00376830 File Offset: 0x00374A30
		// (set) Token: 0x06003AE4 RID: 15076 RVA: 0x003768E4 File Offset: 0x00374AE4
		public bool RadWideLabtoolIntelligentPriorityScanCapable_43411_Editable
		{
			get
			{
				short num = (short)347996161;
				if (num != 0)
				{
				}
				num = (short)1126515626;
				short num2 = num;
				num = (short)565003178;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1507196928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1324482560;
				if (num != 0)
				{
				}
				return this.radWideLabtoolIntelligentPriorityScanCapable_43411.Editable;
			}
			set
			{
				short num = (short)1994713759;
				short num2 = num;
				num = (short)1107421855;
				switch (num2 == num)
				{
				}
				num = (short)1871773696;
				short num3 = num;
				num = (short)904331265;
				if (num != 0)
				{
				}
				num = (short)968163328;
				if (num != 0)
				{
				}
				this.radWideLabtoolIntelligentPriorityScanCapable_43411.Editable = value;
			}
		}

		// Token: 0x17001E1E RID: 7710
		// (get) Token: 0x06003AE5 RID: 15077 RVA: 0x00376998 File Offset: 0x00374B98
		internal string RadWideLabtoolIntelligentPriorityScanCapable_43411_UILabel
		{
			get
			{
				short num = (short)1177170804;
				short num2 = num;
				num = (short)591213428;
				switch (num2 == num)
				{
				}
				num = (short)281280512;
				short num3 = num;
				num = (short)1655898113;
				if (num != 0)
				{
				}
				num = (short)1025572864;
				if (num != 0)
				{
				}
				return this.radWideLabtoolIntelligentPriorityScanCapable_43411.UIName;
			}
		}

		// Token: 0x17001E1F RID: 7711
		// (get) Token: 0x06003AE6 RID: 15078 RVA: 0x00376A4C File Offset: 0x00374C4C
		// (set) Token: 0x06003AE7 RID: 15079 RVA: 0x00376B00 File Offset: 0x00374D00
		internal bool RadWideLabtoolIntelligentPriorityScanCapable_43411_HiddenStatic
		{
			get
			{
				short num = (short)1912949894;
				short num2 = num;
				num = (short)19811462;
				switch (num2 == num)
				{
				}
				num = (short)1884618752;
				short num3 = num;
				num = (short)1174470657;
				if (num != 0)
				{
				}
				num = (short)951058432;
				if (num != 0)
				{
				}
				return this.radWideLabtoolIntelligentPriorityScanCapable_43411.HiddenStatic;
			}
			set
			{
				short num = (short)1997208920;
				short num2 = num;
				num = (short)1276116312;
				switch (num2 == num)
				{
				}
				num = (short)242679808;
				short num3 = num;
				num = (short)1701642241;
				if (num != 0)
				{
				}
				num = (short)75628544;
				if (num != 0)
				{
				}
				this.radWideLabtoolIntelligentPriorityScanCapable_43411.HiddenStatic = value;
			}
		}

		// Token: 0x17001E20 RID: 7712
		// (get) Token: 0x06003AE8 RID: 15080 RVA: 0x00376BB4 File Offset: 0x00374DB4
		// (set) Token: 0x06003AE9 RID: 15081 RVA: 0x00376C68 File Offset: 0x00374E68
		internal bool RadWideLabtoolIntelligentPriorityScanCapable_43411_HiddenDynamic
		{
			get
			{
				short num = (short)1949212835;
				short num2 = num;
				num = (short)150642851;
				switch (num2 == num)
				{
				}
				num = (short)1528889344;
				short num3 = num;
				num = (short)511508481;
				if (num != 0)
				{
				}
				num = (short)453312512;
				if (num != 0)
				{
				}
				return this.radWideLabtoolIntelligentPriorityScanCapable_43411.HiddenDynamic;
			}
			set
			{
				short num = (short)1825100481;
				short num2 = num;
				num = (short)1860752065;
				switch (num2 == num)
				{
				}
				num = (short)1914044416;
				short num3 = num;
				num = (short)2018836480;
				if (num != 0)
				{
				}
				num = (short)1457127425;
				if (num != 0)
				{
				}
				this.radWideLabtoolIntelligentPriorityScanCapable_43411.HiddenDynamic = value;
			}
		}

		// Token: 0x17001E21 RID: 7713
		// (get) Token: 0x06003AEA RID: 15082 RVA: 0x00376D20 File Offset: 0x00374F20
		public bool RadWideLabtoolIntelligentPriorityScanCapable_43411_HasDiffs
		{
			get
			{
				short num = (short)2131558401;
				if (num != 0)
				{
				}
				num = (short)589053718;
				short num2 = num;
				num = (short)2041593622;
				switch (num2 == num)
				{
				default:
				{
					num = (short)642514944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2057437184;
				if (num != 0)
				{
				}
				return this.radWideLabtoolIntelligentPriorityScanCapable_43411._HasDiffs;
			}
		}

		// Token: 0x17001E22 RID: 7714
		// (get) Token: 0x06003AEB RID: 15083 RVA: 0x00376DD4 File Offset: 0x00374FD4
		// (set) Token: 0x06003AEC RID: 15084 RVA: 0x00376E88 File Offset: 0x00375088
		public bool RadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548Value
		{
			get
			{
				short num = (short)1543993657;
				short num2 = num;
				num = (short)1226602809;
				switch (num2 == num)
				{
				}
				num = (short)1837694976;
				short num3 = num;
				num = (short)2059534337;
				if (num != 0)
				{
				}
				num = (short)4784128;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.Value;
			}
			set
			{
				short num = (short)844834038;
				short num2 = num;
				num = (short)1586767094;
				switch (num2 == num)
				{
				}
				num = (short)100466688;
				short num3 = num;
				num = (short)93585409;
				if (num != 0)
				{
				}
				num = (short)73728000;
				if (num != 0)
				{
				}
				this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.Value = value;
			}
		}

		// Token: 0x17001E23 RID: 7715
		// (get) Token: 0x06003AED RID: 15085 RVA: 0x00376F40 File Offset: 0x00375140
		public global::AcpBusinessLayer.AcpField<bool> RadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548
		{
			get
			{
				short num = (short)1653334745;
				short num2 = num;
				num = (short)1863377625;
				switch (num2 == num)
				{
				}
				num = (short)81264640;
				short num3 = num;
				num = (short)117374977;
				if (num != 0)
				{
				}
				num = (short)1826684928;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548;
			}
		}

		// Token: 0x17001E24 RID: 7716
		// (get) Token: 0x06003AEE RID: 15086 RVA: 0x00376FEC File Offset: 0x003751EC
		// (set) Token: 0x06003AEF RID: 15087 RVA: 0x003770A0 File Offset: 0x003752A0
		public bool RadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548_UIValue
		{
			get
			{
				short num = (short)1584922625;
				if (num != 0)
				{
				}
				num = (short)706490254;
				short num2 = num;
				num = (short)1906913166;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1408237568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)244252672;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.Value;
			}
			set
			{
				short num = (short)1652472610;
				short num2 = num;
				num = (short)1349761826;
				switch (num2 == num)
				{
				}
				num = (short)1790377984;
				short num3 = num;
				num = (short)78512129;
				if (num != 0)
				{
				}
				num = (short)194183168;
				if (num != 0)
				{
				}
				this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.Value = value;
			}
		}

		// Token: 0x17001E25 RID: 7717
		// (get) Token: 0x06003AF0 RID: 15088 RVA: 0x00377154 File Offset: 0x00375354
		// (set) Token: 0x06003AF1 RID: 15089 RVA: 0x00377208 File Offset: 0x00375408
		public bool RadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548_Applicable
		{
			get
			{
				short num = (short)270778637;
				short num2 = num;
				num = (short)479707405;
				switch (num2 == num)
				{
				}
				num = (short)778960896;
				short num3 = num;
				num = (short)271646721;
				if (num != 0)
				{
				}
				num = (short)150405120;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.Applicable;
			}
			set
			{
				short num = (short)101449729;
				if (num != 0)
				{
				}
				num = (short)2014841579;
				short num2 = num;
				num = (short)1099827947;
				switch (num2 == num)
				{
				default:
				{
					num = (short)601554944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2127757312;
				if (num != 0)
				{
				}
				this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.Applicable = value;
			}
		}

		// Token: 0x17001E26 RID: 7718
		// (get) Token: 0x06003AF2 RID: 15090 RVA: 0x003772BC File Offset: 0x003754BC
		// (set) Token: 0x06003AF3 RID: 15091 RVA: 0x00377370 File Offset: 0x00375570
		public bool RadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548_Valid
		{
			get
			{
				short num = (short)2110765529;
				short num2 = num;
				num = (short)2126232025;
				switch (num2 == num)
				{
				}
				num = (short)1851064320;
				short num3 = num;
				num = (short)2031747073;
				if (num != 0)
				{
				}
				num = (short)288751616;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.Valid;
			}
			set
			{
				short num = (short)1260339316;
				short num2 = num;
				num = (short)1294483572;
				switch (num2 == num)
				{
				}
				num = (short)769392640;
				short num3 = num;
				num = (short)690880513;
				if (num != 0)
				{
				}
				num = (short)846987264;
				if (num != 0)
				{
				}
				this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.Valid = value;
			}
		}

		// Token: 0x17001E27 RID: 7719
		// (get) Token: 0x06003AF4 RID: 15092 RVA: 0x00377428 File Offset: 0x00375628
		// (set) Token: 0x06003AF5 RID: 15093 RVA: 0x003774DC File Offset: 0x003756DC
		public bool RadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548_Visible
		{
			get
			{
				short num = (short)102424853;
				short num2 = num;
				num = (short)324722965;
				switch (num2 == num)
				{
				}
				num = (short)1312358400;
				short num3 = num;
				num = (short)113704960;
				if (num != 0)
				{
				}
				num = (short)872349697;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.Visible;
			}
			set
			{
				short num = (short)230235410;
				short num2 = num;
				num = (short)1681595666;
				switch (num2 == num)
				{
				}
				num = (short)2090401792;
				short num3 = num;
				num = (short)597164033;
				if (num != 0)
				{
				}
				num = (short)1628962816;
				if (num != 0)
				{
				}
				this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.Visible = value;
			}
		}

		// Token: 0x17001E28 RID: 7720
		// (get) Token: 0x06003AF6 RID: 15094 RVA: 0x00377594 File Offset: 0x00375794
		// (set) Token: 0x06003AF7 RID: 15095 RVA: 0x00377644 File Offset: 0x00375844
		public bool RadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548_Editable
		{
			get
			{
				short num = (short)1446992806;
				short num2 = num;
				num = (short)1714248614;
				switch (num2 == num)
				{
				}
				num = (short)60555264;
				short num3 = num;
				num = (short)770244608;
				if (num != 0)
				{
				}
				num = (short)1006108673;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.Editable;
			}
			set
			{
				short num = (short)1872630582;
				short num2 = num;
				num = (short)1373311798;
				switch (num2 == num)
				{
				}
				num = (short)174784512;
				short num3 = num;
				num = (short)1763377153;
				if (num != 0)
				{
				}
				num = (short)756154368;
				if (num != 0)
				{
				}
				this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.Editable = value;
			}
		}

		// Token: 0x17001E29 RID: 7721
		// (get) Token: 0x06003AF8 RID: 15096 RVA: 0x003776F8 File Offset: 0x003758F8
		internal string RadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548_UILabel
		{
			get
			{
				short num = (short)927620788;
				short num2 = num;
				num = (short)75849396;
				switch (num2 == num)
				{
				}
				num = (short)2084438016;
				short num3 = num;
				num = (short)1982070785;
				if (num != 0)
				{
				}
				num = (short)730923008;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.UIName;
			}
		}

		// Token: 0x17001E2A RID: 7722
		// (get) Token: 0x06003AF9 RID: 15097 RVA: 0x003777AC File Offset: 0x003759AC
		// (set) Token: 0x06003AFA RID: 15098 RVA: 0x00377864 File Offset: 0x00375A64
		internal bool RadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548_HiddenStatic
		{
			get
			{
				short num = (short)105638323;
				short num2 = num;
				num = (short)1005316531;
				switch (num2 == num)
				{
				}
				num = (short)617086976;
				short num3 = num;
				num = (short)290848769;
				if (num != 0)
				{
				}
				num = (short)198705152;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.HiddenStatic;
			}
			set
			{
				short num = (short)212402177;
				if (num != 0)
				{
				}
				num = (short)1677244655;
				short num2 = num;
				num = (short)1574418671;
				switch (num2 == num)
				{
				default:
				{
					num = (short)739311616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1500053504;
				if (num != 0)
				{
				}
				this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.HiddenStatic = value;
			}
		}

		// Token: 0x17001E2B RID: 7723
		// (get) Token: 0x06003AFB RID: 15099 RVA: 0x00377918 File Offset: 0x00375B18
		// (set) Token: 0x06003AFC RID: 15100 RVA: 0x003779D0 File Offset: 0x00375BD0
		internal bool RadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548_HiddenDynamic
		{
			get
			{
				short num = (short)282883853;
				short num2 = num;
				num = (short)1692366605;
				switch (num2 == num)
				{
				}
				num = (short)9371648;
				short num3 = num;
				num = (short)1291452416;
				if (num != 0)
				{
				}
				num = (short)2098790401;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.HiddenDynamic;
			}
			set
			{
				short num = (short)809723382;
				short num2 = num;
				num = (short)1164469750;
				switch (num2 == num)
				{
				}
				num = (short)645595136;
				short num3 = num;
				num = (short)690159617;
				if (num != 0)
				{
				}
				num = (short)1292173312;
				if (num != 0)
				{
				}
				this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.HiddenDynamic = value;
			}
		}

		// Token: 0x17001E2C RID: 7724
		// (get) Token: 0x06003AFD RID: 15101 RVA: 0x00377A88 File Offset: 0x00375C88
		public bool RadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548_HasDiffs
		{
			get
			{
				short num = (short)296970136;
				short num2 = num;
				num = (short)1698916248;
				switch (num2 == num)
				{
				}
				num = (short)1468530688;
				short num3 = num;
				num = (short)1937833984;
				if (num != 0)
				{
				}
				num = (short)904331265;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548._HasDiffs;
			}
		}

		// Token: 0x17001E2D RID: 7725
		// (get) Token: 0x06003AFE RID: 15102 RVA: 0x00377B40 File Offset: 0x00375D40
		// (set) Token: 0x06003AFF RID: 15103 RVA: 0x00377BF4 File Offset: 0x00375DF4
		public bool MARVELL_DNP_43591Value
		{
			get
			{
				short num = (short)599315356;
				short num2 = num;
				num = (short)1318507420;
				switch (num2 == num)
				{
				}
				num = (short)159645696;
				short num3 = num;
				num = (short)2052128769;
				if (num != 0)
				{
				}
				num = (short)1007353856;
				if (num != 0)
				{
				}
				return this.mARVELL_DNP_43591.Value;
			}
			set
			{
				short num = (short)2038408674;
				short num2 = num;
				num = (short)661956066;
				switch (num2 == num)
				{
				}
				num = (short)2020147200;
				short num3 = num;
				num = (short)839188480;
				if (num != 0)
				{
				}
				num = (short)1360789505;
				if (num != 0)
				{
				}
				this.mARVELL_DNP_43591.Value = value;
			}
		}

		// Token: 0x17001E2E RID: 7726
		// (get) Token: 0x06003B00 RID: 15104 RVA: 0x00377CAC File Offset: 0x00375EAC
		public global::AcpBusinessLayer.AcpField<bool> MARVELL_DNP_43591
		{
			get
			{
				short num = (short)1928312410;
				short num2 = num;
				num = (short)1586607706;
				switch (num2 == num)
				{
				}
				num = (short)1061093376;
				short num3 = num;
				num = (short)745603073;
				if (num != 0)
				{
				}
				num = (short)345833472;
				if (num != 0)
				{
				}
				return this.mARVELL_DNP_43591;
			}
		}

		// Token: 0x17001E2F RID: 7727
		// (get) Token: 0x06003B01 RID: 15105 RVA: 0x00377D5C File Offset: 0x00375F5C
		// (set) Token: 0x06003B02 RID: 15106 RVA: 0x00377E10 File Offset: 0x00376010
		public bool MARVELL_DNP_43591_UIValue
		{
			get
			{
				short num = (short)827334942;
				short num2 = num;
				num = (short)2057707806;
				switch (num2 == num)
				{
				}
				num = (short)756154368;
				short num3 = num;
				num = (short)1704263680;
				if (num != 0)
				{
				}
				num = (short)1899167745;
				if (num != 0)
				{
				}
				return this.mARVELL_DNP_43591.Value;
			}
			set
			{
				short num = (short)1139015681;
				if (num != 0)
				{
				}
				num = (short)1713382195;
				short num2 = num;
				num = (short)992355123;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1059389440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)847642624;
				if (num != 0)
				{
				}
				this.mARVELL_DNP_43591.Value = value;
			}
		}

		// Token: 0x17001E30 RID: 7728
		// (get) Token: 0x06003B03 RID: 15107 RVA: 0x00377EC8 File Offset: 0x003760C8
		// (set) Token: 0x06003B04 RID: 15108 RVA: 0x00377F80 File Offset: 0x00376180
		public bool MARVELL_DNP_43591_Applicable
		{
			get
			{
				short num = (short)2102015508;
				short num2 = num;
				num = (short)1068971540;
				switch (num2 == num)
				{
				}
				num = (short)526123008;
				short num3 = num;
				num = (short)153616385;
				if (num != 0)
				{
				}
				num = (short)1189543936;
				if (num != 0)
				{
				}
				return this.mARVELL_DNP_43591.Applicable;
			}
			set
			{
				short num = (short)320407847;
				short num2 = num;
				num = (short)387778855;
				switch (num2 == num)
				{
				}
				num = (short)1852571648;
				short num3 = num;
				num = (short)341114880;
				if (num != 0)
				{
				}
				num = (short)1287585793;
				if (num != 0)
				{
				}
				this.mARVELL_DNP_43591.Applicable = value;
			}
		}

		// Token: 0x17001E31 RID: 7729
		// (get) Token: 0x06003B05 RID: 15109 RVA: 0x00378034 File Offset: 0x00376234
		// (set) Token: 0x06003B06 RID: 15110 RVA: 0x003780E8 File Offset: 0x003762E8
		public bool MARVELL_DNP_43591_Valid
		{
			get
			{
				short num = (short)965816974;
				short num2 = num;
				num = (short)5714574;
				switch (num2 == num)
				{
				}
				num = (short)156631040;
				short num3 = num;
				num = (short)123076609;
				if (num != 0)
				{
				}
				num = (short)225771520;
				if (num != 0)
				{
				}
				return this.mARVELL_DNP_43591.Valid;
			}
			set
			{
				short num = (short)936169402;
				short num2 = num;
				num = (short)561369018;
				switch (num2 == num)
				{
				}
				num = (short)1754660864;
				short num3 = num;
				num = (short)549715969;
				if (num != 0)
				{
				}
				num = (short)1563885568;
				if (num != 0)
				{
				}
				this.mARVELL_DNP_43591.Valid = value;
			}
		}

		// Token: 0x17001E32 RID: 7730
		// (get) Token: 0x06003B07 RID: 15111 RVA: 0x003781A0 File Offset: 0x003763A0
		// (set) Token: 0x06003B08 RID: 15112 RVA: 0x00378254 File Offset: 0x00376454
		public bool MARVELL_DNP_43591_Visible
		{
			get
			{
				short num = (short)1667164406;
				short num2 = num;
				num = (short)1866787062;
				switch (num2 == num)
				{
				}
				num = (short)702742528;
				short num3 = num;
				num = (short)2104819712;
				if (num != 0)
				{
				}
				num = (short)578879489;
				if (num != 0)
				{
				}
				return this.mARVELL_DNP_43591.Visible;
			}
			set
			{
				short num = (short)1176502273;
				if (num != 0)
				{
				}
				num = (short)1060438016;
				short num2 = num;
				num = (short)1129591181;
				short num3 = num;
				num = (short)269955469;
				switch (num3 == num)
				{
				}
				num = (short)924057600;
				if (num != 0)
				{
				}
				this.mARVELL_DNP_43591.Visible = value;
			}
		}

		// Token: 0x17001E33 RID: 7731
		// (get) Token: 0x06003B09 RID: 15113 RVA: 0x00378308 File Offset: 0x00376508
		// (set) Token: 0x06003B0A RID: 15114 RVA: 0x003783BC File Offset: 0x003765BC
		public bool MARVELL_DNP_43591_Editable
		{
			get
			{
				short num = (short)1403933522;
				short num2 = num;
				num = (short)574247762;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1626734592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)422248448;
				if (num != 0)
				{
				}
				num = (short)1834221569;
				if (num != 0)
				{
				}
				return this.mARVELL_DNP_43591.Editable;
			}
			set
			{
				short num = (short)304749999;
				short num2 = num;
				num = (short)352787887;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1654652928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1250623489;
				if (num != 0)
				{
				}
				num = (short)250937344;
				if (num != 0)
				{
				}
				this.mARVELL_DNP_43591.Editable = value;
			}
		}

		// Token: 0x17001E34 RID: 7732
		// (get) Token: 0x06003B0B RID: 15115 RVA: 0x00378474 File Offset: 0x00376674
		internal string MARVELL_DNP_43591_UILabel
		{
			get
			{
				short num = (short)1659211206;
				short num2 = num;
				num = (short)1000967622;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1335951360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)740294657;
				if (num != 0)
				{
				}
				num = (short)1626669056;
				if (num != 0)
				{
				}
				return this.mARVELL_DNP_43591.UIName;
			}
		}

		// Token: 0x17001E35 RID: 7733
		// (get) Token: 0x06003B0C RID: 15116 RVA: 0x0037852C File Offset: 0x0037672C
		// (set) Token: 0x06003B0D RID: 15117 RVA: 0x003785E0 File Offset: 0x003767E0
		internal bool MARVELL_DNP_43591_HiddenStatic
		{
			get
			{
				short num = (short)912831182;
				short num2 = num;
				num = (short)1326494414;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1591345152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)789643264;
				if (num != 0)
				{
				}
				num = (short)1000472577;
				if (num != 0)
				{
				}
				return this.mARVELL_DNP_43591.HiddenStatic;
			}
			set
			{
				short num = (short)67248635;
				short num2 = num;
				num = (short)213459451;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1509687296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1176174592;
				if (num != 0)
				{
				}
				num = (short)84082689;
				if (num != 0)
				{
				}
				this.mARVELL_DNP_43591.HiddenStatic = value;
			}
		}

		// Token: 0x17001E36 RID: 7734
		// (get) Token: 0x06003B0E RID: 15118 RVA: 0x00378698 File Offset: 0x00376898
		// (set) Token: 0x06003B0F RID: 15119 RVA: 0x0037874C File Offset: 0x0037694C
		internal bool MARVELL_DNP_43591_HiddenDynamic
		{
			get
			{
				short num = (short)2014378941;
				short num2 = num;
				num = (short)287898557;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1024786432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1719271425;
				if (num != 0)
				{
				}
				num = (short)1237712896;
				if (num != 0)
				{
				}
				return this.mARVELL_DNP_43591.HiddenDynamic;
			}
			set
			{
				short num = (short)1216834045;
				short num2 = num;
				num = (short)645753341;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1662779392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1997340673;
				if (num != 0)
				{
				}
				num = (short)1099628544;
				if (num != 0)
				{
				}
				this.mARVELL_DNP_43591.HiddenDynamic = value;
			}
		}

		// Token: 0x17001E37 RID: 7735
		// (get) Token: 0x06003B10 RID: 15120 RVA: 0x00378804 File Offset: 0x00376A04
		public bool MARVELL_DNP_43591_HasDiffs
		{
			get
			{
				short num = (short)232941804;
				short num2 = num;
				num = (short)983066860;
				switch (num2 == num)
				{
				default:
				{
					num = (short)847904768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)645267457;
				if (num != 0)
				{
				}
				num = (short)1599078400;
				if (num != 0)
				{
				}
				return this.mARVELL_DNP_43591._HasDiffs;
			}
		}

		// Token: 0x17001E38 RID: 7736
		// (get) Token: 0x06003B11 RID: 15121 RVA: 0x003788B8 File Offset: 0x00376AB8
		// (set) Token: 0x06003B12 RID: 15122 RVA: 0x00378970 File Offset: 0x00376B70
		public bool TEN_DIGIT_RL_PSWD_capable_43711Value
		{
			get
			{
				short num = (short)875298817;
				if (num != 0)
				{
				}
				num = (short)2062811136;
				short num2 = num;
				num = (short)1039101421;
				short num3 = num;
				num = (short)406351341;
				switch (num3 == num)
				{
				}
				num = (short)1871970304;
				if (num != 0)
				{
				}
				return this.tEN_DIGIT_RL_PSWD_capable_43711.Value;
			}
			set
			{
				short num = (short)2113100560;
				short num2 = num;
				num = (short)1921407760;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1469251584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1490944000;
				if (num != 0)
				{
				}
				num = (short)2130509825;
				if (num != 0)
				{
				}
				this.tEN_DIGIT_RL_PSWD_capable_43711.Value = value;
			}
		}

		// Token: 0x17001E39 RID: 7737
		// (get) Token: 0x06003B13 RID: 15123 RVA: 0x00378A24 File Offset: 0x00376C24
		public global::AcpBusinessLayer.AcpField<bool> TEN_DIGIT_RL_PSWD_capable_43711
		{
			get
			{
				short num = (short)998415381;
				short num2 = num;
				num = (short)1718852629;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1185480704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)989003777;
				if (num != 0)
				{
				}
				num = (short)1712652288;
				if (num != 0)
				{
				}
				return this.tEN_DIGIT_RL_PSWD_capable_43711;
			}
		}

		// Token: 0x17001E3A RID: 7738
		// (get) Token: 0x06003B14 RID: 15124 RVA: 0x00378AD4 File Offset: 0x00376CD4
		// (set) Token: 0x06003B15 RID: 15125 RVA: 0x00378B88 File Offset: 0x00376D88
		public bool TEN_DIGIT_RL_PSWD_capable_43711_UIValue
		{
			get
			{
				short num = (short)910163969;
				if (num != 0)
				{
				}
				num = (short)11534336;
				short num2 = num;
				num = (short)908612875;
				short num3 = num;
				num = (short)221730059;
				switch (num3 == num)
				{
				}
				num = (short)545783808;
				if (num != 0)
				{
				}
				return this.tEN_DIGIT_RL_PSWD_capable_43711.Value;
			}
			set
			{
				short num = (short)1535401703;
				short num2 = num;
				num = (short)768958183;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1357578240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1598357505;
				if (num != 0)
				{
				}
				num = (short)592576512;
				if (num != 0)
				{
				}
				this.tEN_DIGIT_RL_PSWD_capable_43711.Value = value;
			}
		}

		// Token: 0x17001E3B RID: 7739
		// (get) Token: 0x06003B16 RID: 15126 RVA: 0x00378C3C File Offset: 0x00376E3C
		// (set) Token: 0x06003B17 RID: 15127 RVA: 0x00378CEC File Offset: 0x00376EEC
		public bool TEN_DIGIT_RL_PSWD_capable_43711_Applicable
		{
			get
			{
				short num = (short)1876428315;
				short num2 = num;
				num = (short)547948059;
				switch (num2 == num)
				{
				default:
				{
					num = (short)862978048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)28180481;
				if (num != 0)
				{
				}
				num = (short)1589706752;
				if (num != 0)
				{
				}
				return this.tEN_DIGIT_RL_PSWD_capable_43711.Applicable;
			}
			set
			{
				short num = (short)549311866;
				short num2 = num;
				num = (short)126014842;
				switch (num2 == num)
				{
				default:
				{
					num = (short)331087872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)794034176;
				if (num != 0)
				{
				}
				num = (short)19529729;
				if (num != 0)
				{
				}
				this.tEN_DIGIT_RL_PSWD_capable_43711.Applicable = value;
			}
		}

		// Token: 0x17001E3C RID: 7740
		// (get) Token: 0x06003B18 RID: 15128 RVA: 0x00378D9C File Offset: 0x00376F9C
		// (set) Token: 0x06003B19 RID: 15129 RVA: 0x00378E50 File Offset: 0x00377050
		public bool TEN_DIGIT_RL_PSWD_capable_43711_Valid
		{
			get
			{
				short num = (short)477617943;
				short num2 = num;
				num = (short)243588887;
				switch (num2 == num)
				{
				default:
				{
					num = (short)246808576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)592052225;
				if (num != 0)
				{
				}
				num = (short)1938096128;
				if (num != 0)
				{
				}
				return this.tEN_DIGIT_RL_PSWD_capable_43711.Valid;
			}
			set
			{
				short num = (short)1237328265;
				short num2 = num;
				num = (short)1965171081;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2004090880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1409155073;
				if (num != 0)
				{
				}
				num = (short)804257792;
				if (num != 0)
				{
				}
				this.tEN_DIGIT_RL_PSWD_capable_43711.Valid = value;
			}
		}

		// Token: 0x17001E3D RID: 7741
		// (get) Token: 0x06003B1A RID: 15130 RVA: 0x00378F08 File Offset: 0x00377108
		// (set) Token: 0x06003B1B RID: 15131 RVA: 0x00378FBC File Offset: 0x003771BC
		public bool TEN_DIGIT_RL_PSWD_capable_43711_Visible
		{
			get
			{
				short num = (short)1013900534;
				short num2 = num;
				num = (short)342418678;
				switch (num2 == num)
				{
				default:
				{
					num = (short)193593344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1665073153;
				if (num != 0)
				{
				}
				num = (short)265879552;
				if (num != 0)
				{
				}
				return this.tEN_DIGIT_RL_PSWD_capable_43711.Visible;
			}
			set
			{
				short num = (short)206372865;
				if (num != 0)
				{
				}
				num = (short)1073020928;
				short num2 = num;
				num = (short)511443180;
				short num3 = num;
				num = (short)375718124;
				switch (num3 == num)
				{
				}
				num = (short)1409875968;
				if (num != 0)
				{
				}
				this.tEN_DIGIT_RL_PSWD_capable_43711.Visible = value;
			}
		}

		// Token: 0x17001E3E RID: 7742
		// (get) Token: 0x06003B1C RID: 15132 RVA: 0x00379070 File Offset: 0x00377270
		// (set) Token: 0x06003B1D RID: 15133 RVA: 0x00379124 File Offset: 0x00377324
		public bool TEN_DIGIT_RL_PSWD_capable_43711_Editable
		{
			get
			{
				short num = (short)1327463045;
				short num2 = num;
				num = (short)1033861765;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1806172160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)714735617;
				if (num != 0)
				{
				}
				num = (short)99614720;
				if (num != 0)
				{
				}
				return this.tEN_DIGIT_RL_PSWD_capable_43711.Editable;
			}
			set
			{
				short num = (short)192861561;
				short num2 = num;
				num = (short)2125583737;
				switch (num2 == num)
				{
				default:
				{
					num = (short)566427648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1946288129;
				if (num != 0)
				{
				}
				num = (short)418971648;
				if (num != 0)
				{
				}
				this.tEN_DIGIT_RL_PSWD_capable_43711.Editable = value;
			}
		}

		// Token: 0x17001E3F RID: 7743
		// (get) Token: 0x06003B1E RID: 15134 RVA: 0x003791D8 File Offset: 0x003773D8
		internal string TEN_DIGIT_RL_PSWD_capable_43711_UILabel
		{
			get
			{
				short num = (short)2000787298;
				short num2 = num;
				num = (short)140089186;
				switch (num2 == num)
				{
				default:
				{
					num = (short)448397312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2140536833;
				if (num != 0)
				{
				}
				num = (short)1494089728;
				if (num != 0)
				{
				}
				return this.tEN_DIGIT_RL_PSWD_capable_43711.UIName;
			}
		}

		// Token: 0x17001E40 RID: 7744
		// (get) Token: 0x06003B1F RID: 15135 RVA: 0x0037928C File Offset: 0x0037748C
		// (set) Token: 0x06003B20 RID: 15136 RVA: 0x00379340 File Offset: 0x00377540
		internal bool TEN_DIGIT_RL_PSWD_capable_43711_HiddenStatic
		{
			get
			{
				short num = (short)659241227;
				short num2 = num;
				num = (short)1560295691;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1684799488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2001141761;
				if (num != 0)
				{
				}
				num = (short)596901888;
				if (num != 0)
				{
				}
				return this.tEN_DIGIT_RL_PSWD_capable_43711.HiddenStatic;
			}
			set
			{
				short num = (short)1041956645;
				short num2 = num;
				num = (short)143982373;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2024996864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1765867521;
				if (num != 0)
				{
				}
				num = (short)15532032;
				if (num != 0)
				{
				}
				this.tEN_DIGIT_RL_PSWD_capable_43711.HiddenStatic = value;
			}
		}

		// Token: 0x17001E41 RID: 7745
		// (get) Token: 0x06003B21 RID: 15137 RVA: 0x003793F4 File Offset: 0x003775F4
		// (set) Token: 0x06003B22 RID: 15138 RVA: 0x003794A8 File Offset: 0x003776A8
		internal bool TEN_DIGIT_RL_PSWD_capable_43711_HiddenDynamic
		{
			get
			{
				short num = (short)1031969076;
				short num2 = num;
				num = (short)544512308;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1089798144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2036924417;
				if (num != 0)
				{
				}
				num = (short)1750728704;
				if (num != 0)
				{
				}
				return this.tEN_DIGIT_RL_PSWD_capable_43711.HiddenDynamic;
			}
			set
			{
				short num = (short)2077097985;
				if (num != 0)
				{
				}
				num = (short)866516992;
				short num2 = num;
				num = (short)1409598175;
				short num3 = num;
				num = (short)1352778463;
				switch (num3 == num)
				{
				}
				num = (short)1028063232;
				if (num != 0)
				{
				}
				this.tEN_DIGIT_RL_PSWD_capable_43711.HiddenDynamic = value;
			}
		}

		// Token: 0x17001E42 RID: 7746
		// (get) Token: 0x06003B23 RID: 15139 RVA: 0x0037955C File Offset: 0x0037775C
		public bool TEN_DIGIT_RL_PSWD_capable_43711_HasDiffs
		{
			get
			{
				short num = (short)333644759;
				short num2 = num;
				num = (short)89195479;
				switch (num2 == num)
				{
				default:
				{
					num = (short)884736000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)388562945;
				if (num != 0)
				{
				}
				num = (short)1555234816;
				if (num != 0)
				{
				}
				return this.tEN_DIGIT_RL_PSWD_capable_43711._HasDiffs;
			}
		}

		// Token: 0x17001E43 RID: 7747
		// (get) Token: 0x06003B24 RID: 15140 RVA: 0x00379614 File Offset: 0x00377814
		// (set) Token: 0x06003B25 RID: 15141 RVA: 0x003796C8 File Offset: 0x003778C8
		public bool RadioWideLabtoolExtendedPLToneSet_43769Value
		{
			get
			{
				short num = (short)889241509;
				short num2 = num;
				num = (short)587055013;
				switch (num2 == num)
				{
				default:
				{
					num = (short)897646592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1816133633;
				if (num != 0)
				{
				}
				num = (short)1094123520;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolExtendedPLToneSet_43769.Value;
			}
			set
			{
				short num = (short)1147271546;
				short num2 = num;
				num = (short)642316666;
				switch (num2 == num)
				{
				default:
				{
					num = (short)424411136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1337524224;
				if (num != 0)
				{
				}
				num = (short)1471021057;
				if (num != 0)
				{
				}
				this.radioWideLabtoolExtendedPLToneSet_43769.Value = value;
			}
		}

		// Token: 0x17001E44 RID: 7748
		// (get) Token: 0x06003B26 RID: 15142 RVA: 0x0037977C File Offset: 0x0037797C
		public global::AcpBusinessLayer.AcpField<bool> RadioWideLabtoolExtendedPLToneSet_43769
		{
			get
			{
				short num = (short)1472180730;
				short num2 = num;
				num = (short)1327739386;
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
				num = (short)735576065;
				if (num != 0)
				{
				}
				num = (short)1842479104;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolExtendedPLToneSet_43769;
			}
		}

		// Token: 0x17001E45 RID: 7749
		// (get) Token: 0x06003B27 RID: 15143 RVA: 0x00379828 File Offset: 0x00377A28
		// (set) Token: 0x06003B28 RID: 15144 RVA: 0x003798DC File Offset: 0x00377ADC
		public bool RadioWideLabtoolExtendedPLToneSet_43769_UIValue
		{
			get
			{
				short num = (short)945065599;
				short num2 = num;
				num = (short)1710788223;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1278869504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)602996736;
				if (num != 0)
				{
				}
				num = (short)1512177665;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolExtendedPLToneSet_43769.Value;
			}
			set
			{
				short num = (short)2071804720;
				short num2 = num;
				num = (short)1710635824;
				switch (num2 == num)
				{
				default:
				{
					num = (short)925958144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1869283328;
				if (num != 0)
				{
				}
				num = (short)432996353;
				if (num != 0)
				{
				}
				this.radioWideLabtoolExtendedPLToneSet_43769.Value = value;
			}
		}

		// Token: 0x17001E46 RID: 7750
		// (get) Token: 0x06003B29 RID: 15145 RVA: 0x00379990 File Offset: 0x00377B90
		// (set) Token: 0x06003B2A RID: 15146 RVA: 0x00379A44 File Offset: 0x00377C44
		public bool RadioWideLabtoolExtendedPLToneSet_43769_Applicable
		{
			get
			{
				short num = (short)1078710498;
				short num2 = num;
				num = (short)239653090;
				switch (num2 == num)
				{
				default:
				{
					num = (short)609878016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1938423809;
				if (num != 0)
				{
				}
				num = (short)1634795520;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolExtendedPLToneSet_43769.Applicable;
			}
			set
			{
				short num = (short)269225703;
				short num2 = num;
				num = (short)2089422567;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1294401536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1151729665;
				if (num != 0)
				{
				}
				num = (short)594345984;
				if (num != 0)
				{
				}
				this.radioWideLabtoolExtendedPLToneSet_43769.Applicable = value;
			}
		}

		// Token: 0x17001E47 RID: 7751
		// (get) Token: 0x06003B2B RID: 15147 RVA: 0x00379AFC File Offset: 0x00377CFC
		// (set) Token: 0x06003B2C RID: 15148 RVA: 0x00379BB4 File Offset: 0x00377DB4
		public bool RadioWideLabtoolExtendedPLToneSet_43769_Valid
		{
			get
			{
				short num = (short)1730121155;
				short num2 = num;
				num = (short)73108931;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1835401216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)488767488;
				if (num != 0)
				{
				}
				num = (short)1740505089;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolExtendedPLToneSet_43769.Valid;
			}
			set
			{
				short num = (short)1080819555;
				short num2 = num;
				num = (short)593362787;
				switch (num2 == num)
				{
				default:
				{
					num = (short)287178752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)173867009;
				if (num != 0)
				{
				}
				num = (short)1122566144;
				if (num != 0)
				{
				}
				this.radioWideLabtoolExtendedPLToneSet_43769.Valid = value;
			}
		}

		// Token: 0x17001E48 RID: 7752
		// (get) Token: 0x06003B2D RID: 15149 RVA: 0x00379C6C File Offset: 0x00377E6C
		// (set) Token: 0x06003B2E RID: 15150 RVA: 0x00379D20 File Offset: 0x00377F20
		public bool RadioWideLabtoolExtendedPLToneSet_43769_Visible
		{
			get
			{
				short num = (short)1596640736;
				short num2 = num;
				num = (short)1230687712;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2113011712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1759969281;
				if (num != 0)
				{
				}
				num = (short)1079115776;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolExtendedPLToneSet_43769.Visible;
			}
			set
			{
				short num = (short)1472421991;
				short num2 = num;
				num = (short)1123770471;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1847721984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1509097472;
				if (num != 0)
				{
				}
				num = (short)603914241;
				if (num != 0)
				{
				}
				this.radioWideLabtoolExtendedPLToneSet_43769.Visible = value;
			}
		}

		// Token: 0x17001E49 RID: 7753
		// (get) Token: 0x06003B2F RID: 15151 RVA: 0x00379DD4 File Offset: 0x00377FD4
		// (set) Token: 0x06003B30 RID: 15152 RVA: 0x00379E8C File Offset: 0x0037808C
		public bool RadioWideLabtoolExtendedPLToneSet_43769_Editable
		{
			get
			{
				short num = (short)676609208;
				short num2 = num;
				num = (short)832781496;
				switch (num2 == num)
				{
				default:
				{
					num = (short)941096960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)647692289;
				if (num != 0)
				{
				}
				num = (short)1166802944;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolExtendedPLToneSet_43769.Editable;
			}
			set
			{
				short num = (short)213642741;
				short num2 = num;
				num = (short)367848949;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1480523776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)478478336;
				if (num != 0)
				{
				}
				num = (short)204865537;
				if (num != 0)
				{
				}
				this.radioWideLabtoolExtendedPLToneSet_43769.Editable = value;
			}
		}

		// Token: 0x17001E4A RID: 7754
		// (get) Token: 0x06003B31 RID: 15153 RVA: 0x00379F40 File Offset: 0x00378140
		internal string RadioWideLabtoolExtendedPLToneSet_43769_UILabel
		{
			get
			{
				short num = (short)2049593074;
				short num2 = num;
				num = (short)810110706;
				switch (num2 == num)
				{
				default:
				{
					num = (short)460128256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1053884417;
				if (num != 0)
				{
				}
				num = (short)939130880;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolExtendedPLToneSet_43769.UIName;
			}
		}

		// Token: 0x17001E4B RID: 7755
		// (get) Token: 0x06003B32 RID: 15154 RVA: 0x00379FF8 File Offset: 0x003781F8
		// (set) Token: 0x06003B33 RID: 15155 RVA: 0x0037A0AC File Offset: 0x003782AC
		internal bool RadioWideLabtoolExtendedPLToneSet_43769_HiddenStatic
		{
			get
			{
				short num = (short)1345060865;
				if (num != 0)
				{
				}
				num = (short)1735917568;
				short num2 = num;
				num = (short)946343457;
				short num3 = num;
				num = (short)650317345;
				switch (num3 == num)
				{
				}
				num = (short)645922816;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolExtendedPLToneSet_43769.HiddenStatic;
			}
			set
			{
				short num = (short)602865665;
				if (num != 0)
				{
				}
				num = (short)1859190784;
				short num2 = num;
				num = (short)1412626440;
				short num3 = num;
				num = (short)280557576;
				switch (num3 == num)
				{
				}
				num = (short)1750007808;
				if (num != 0)
				{
				}
				this.radioWideLabtoolExtendedPLToneSet_43769.HiddenStatic = value;
			}
		}

		// Token: 0x17001E4C RID: 7756
		// (get) Token: 0x06003B34 RID: 15156 RVA: 0x0037A160 File Offset: 0x00378360
		// (set) Token: 0x06003B35 RID: 15157 RVA: 0x0037A210 File Offset: 0x00378410
		internal bool RadioWideLabtoolExtendedPLToneSet_43769_HiddenDynamic
		{
			get
			{
				short num = (short)1575747585;
				if (num != 0)
				{
				}
				num = (short)1913716736;
				short num2 = num;
				num = (short)585829511;
				short num3 = num;
				num = (short)1466829959;
				switch (num3 == num)
				{
				}
				num = (short)1410138112;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolExtendedPLToneSet_43769.HiddenDynamic;
			}
			set
			{
				short num = (short)1516255110;
				short num2 = num;
				num = (short)39139206;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1279131648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1407909888;
				if (num != 0)
				{
				}
				num = (short)551485441;
				if (num != 0)
				{
				}
				this.radioWideLabtoolExtendedPLToneSet_43769.HiddenDynamic = value;
			}
		}

		// Token: 0x17001E4D RID: 7757
		// (get) Token: 0x06003B36 RID: 15158 RVA: 0x0037A2C8 File Offset: 0x003784C8
		public bool RadioWideLabtoolExtendedPLToneSet_43769_HasDiffs
		{
			get
			{
				short num = (short)1999786198;
				short num2 = num;
				num = (short)71717078;
				switch (num2 == num)
				{
				default:
				{
					num = (short)888995840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)28049408;
				if (num != 0)
				{
				}
				num = (short)1400569857;
				if (num != 0)
				{
				}
				return this.radioWideLabtoolExtendedPLToneSet_43769._HasDiffs;
			}
		}

		// Token: 0x17001E4E RID: 7758
		// (get) Token: 0x06003B37 RID: 15159 RVA: 0x0037A37C File Offset: 0x0037857C
		// (set) Token: 0x06003B38 RID: 15160 RVA: 0x0037A430 File Offset: 0x00378630
		public bool AllowPSUSecure_43809Value
		{
			get
			{
				short num = (short)877877106;
				short num2 = num;
				num = (short)1654740850;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1465188352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)528744448;
				if (num != 0)
				{
				}
				num = (short)1005322241;
				if (num != 0)
				{
				}
				return this.allowPSUSecure_43809.Value;
			}
			set
			{
				short num = (short)1874132993;
				if (num != 0)
				{
				}
				num = (short)2081168131;
				short num2 = num;
				num = (short)628955907;
				switch (num2 == num)
				{
				}
				num = (short)1748959232;
				short num3 = num;
				num = (short)1037828096;
				if (num != 0)
				{
				}
				this.allowPSUSecure_43809.Value = value;
			}
		}

		// Token: 0x17001E4F RID: 7759
		// (get) Token: 0x06003B39 RID: 15161 RVA: 0x0037A4E8 File Offset: 0x003786E8
		public global::AcpBusinessLayer.AcpField<bool> AllowPSUSecure_43809
		{
			get
			{
				short num = (short)483085753;
				short num2 = num;
				num = (short)652561849;
				switch (num2 == num)
				{
				}
				num = (short)28966913;
				if (num != 0)
				{
				}
				num = (short)191758336;
				short num3 = num;
				num = (short)1831075840;
				if (num != 0)
				{
				}
				return this.allowPSUSecure_43809;
			}
		}

		// Token: 0x17001E50 RID: 7760
		// (get) Token: 0x06003B3A RID: 15162 RVA: 0x0037A598 File Offset: 0x00378798
		// (set) Token: 0x06003B3B RID: 15163 RVA: 0x0037A64C File Offset: 0x0037884C
		public bool AllowPSUSecure_43809_UIValue
		{
			get
			{
				short num = (short)317871869;
				short num2 = num;
				num = (short)1016813309;
				switch (num2 == num)
				{
				}
				num = (short)1419902976;
				if (num != 0)
				{
				}
				num = (short)943259648;
				short num3 = num;
				num = (short)1639448577;
				if (num != 0)
				{
				}
				return this.allowPSUSecure_43809.Value;
			}
			set
			{
				short num = (short)783345566;
				short num2 = num;
				num = (short)1297606558;
				switch (num2 == num)
				{
				}
				num = (short)369623041;
				if (num != 0)
				{
				}
				num = (short)1421672448;
				short num3 = num;
				num = (short)265814016;
				if (num != 0)
				{
				}
				this.allowPSUSecure_43809.Value = value;
			}
		}

		// Token: 0x17001E51 RID: 7761
		// (get) Token: 0x06003B3C RID: 15164 RVA: 0x0037A700 File Offset: 0x00378900
		// (set) Token: 0x06003B3D RID: 15165 RVA: 0x0037A7B4 File Offset: 0x003789B4
		public bool AllowPSUSecure_43809_Applicable
		{
			get
			{
				short num = (short)304172439;
				short num2 = num;
				num = (short)1464749463;
				switch (num2 == num)
				{
				}
				num = (short)777191424;
				if (num != 0)
				{
				}
				num = (short)2058092544;
				short num3 = num;
				num = (short)1476526081;
				if (num != 0)
				{
				}
				return this.allowPSUSecure_43809.Applicable;
			}
			set
			{
				short num = (short)1574227662;
				short num2 = num;
				num = (short)13094606;
				switch (num2 == num)
				{
				}
				num = (short)112132097;
				if (num != 0)
				{
				}
				num = (short)2138177536;
				short num3 = num;
				num = (short)195297280;
				if (num != 0)
				{
				}
				this.allowPSUSecure_43809.Applicable = value;
			}
		}

		// Token: 0x17001E52 RID: 7762
		// (get) Token: 0x06003B3E RID: 15166 RVA: 0x0037A868 File Offset: 0x00378A68
		// (set) Token: 0x06003B3F RID: 15167 RVA: 0x0037A91C File Offset: 0x00378B1C
		public bool AllowPSUSecure_43809_Valid
		{
			get
			{
				short num = (short)946499185;
				short num2 = num;
				num = (short)1286041201;
				switch (num2 == num)
				{
				}
				num = (short)916783105;
				if (num != 0)
				{
				}
				num = (short)1765343232;
				short num3 = num;
				num = (short)1604517888;
				if (num != 0)
				{
				}
				return this.allowPSUSecure_43809.Valid;
			}
			set
			{
				short num = (short)1560042516;
				short num2 = num;
				num = (short)735861780;
				switch (num2 == num)
				{
				}
				num = (short)358350849;
				if (num != 0)
				{
				}
				num = (short)618070016;
				short num3 = num;
				num = (short)1562247168;
				if (num != 0)
				{
				}
				this.allowPSUSecure_43809.Valid = value;
			}
		}

		// Token: 0x17001E53 RID: 7763
		// (get) Token: 0x06003B40 RID: 15168 RVA: 0x0037A9D4 File Offset: 0x00378BD4
		// (set) Token: 0x06003B41 RID: 15169 RVA: 0x0037AA88 File Offset: 0x00378C88
		public bool AllowPSUSecure_43809_Visible
		{
			get
			{
				short num = (short)763739119;
				short num2 = num;
				num = (short)766753775;
				switch (num2 == num)
				{
				}
				num = (short)487260161;
				if (num != 0)
				{
				}
				num = (short)559284224;
				short num3 = num;
				num = (short)590217216;
				if (num != 0)
				{
				}
				return this.allowPSUSecure_43809.Visible;
			}
			set
			{
				short num = (short)647357603;
				short num2 = num;
				num = (short)1032512675;
				switch (num2 == num)
				{
				}
				num = (short)116719617;
				if (num != 0)
				{
				}
				num = (short)105185280;
				short num3 = num;
				num = (short)518979584;
				if (num != 0)
				{
				}
				this.allowPSUSecure_43809.Visible = value;
			}
		}

		// Token: 0x17001E54 RID: 7764
		// (get) Token: 0x06003B42 RID: 15170 RVA: 0x0037AB40 File Offset: 0x00378D40
		// (set) Token: 0x06003B43 RID: 15171 RVA: 0x0037ABF4 File Offset: 0x00378DF4
		public bool AllowPSUSecure_43809_Editable
		{
			get
			{
				short num = (short)1057722016;
				short num2 = num;
				num = (short)1159237280;
				switch (num2 == num)
				{
				}
				num = (short)563544064;
				if (num != 0)
				{
				}
				num = (short)997326848;
				short num3 = num;
				num = (short)8388609;
				if (num != 0)
				{
				}
				return this.allowPSUSecure_43809.Editable;
			}
			set
			{
				short num = (short)493689242;
				short num2 = num;
				num = (short)66263450;
				switch (num2 == num)
				{
				}
				num = (short)2007367681;
				if (num != 0)
				{
				}
				num = (short)881655808;
				short num3 = num;
				num = (short)1869545472;
				if (num != 0)
				{
				}
				this.allowPSUSecure_43809.Editable = value;
			}
		}

		// Token: 0x17001E55 RID: 7765
		// (get) Token: 0x06003B44 RID: 15172 RVA: 0x0037ACAC File Offset: 0x00378EAC
		internal string AllowPSUSecure_43809_UILabel
		{
			get
			{
				short num = (short)1026449180;
				short num2 = num;
				num = (short)1618566940;
				switch (num2 == num)
				{
				}
				num = (short)532545536;
				if (num != 0)
				{
				}
				num = (short)1248198656;
				short num3 = num;
				num = (short)1157431297;
				if (num != 0)
				{
				}
				return this.allowPSUSecure_43809.UIName;
			}
		}

		// Token: 0x17001E56 RID: 7766
		// (get) Token: 0x06003B45 RID: 15173 RVA: 0x0037AD68 File Offset: 0x00378F68
		// (set) Token: 0x06003B46 RID: 15174 RVA: 0x0037AE1C File Offset: 0x0037901C
		internal bool AllowPSUSecure_43809_HiddenStatic
		{
			get
			{
				short num = (short)2080178177;
				if (num != 0)
				{
				}
				num = (short)1636300774;
				short num2 = num;
				num = (short)1467545574;
				switch (num2 == num)
				{
				}
				num = (short)374079488;
				short num3 = num;
				num = (short)699793408;
				if (num != 0)
				{
				}
				return this.allowPSUSecure_43809.HiddenStatic;
			}
			set
			{
				short num = (short)784968279;
				short num2 = num;
				num = (short)1363192407;
				switch (num2 == num)
				{
				}
				num = (short)580648960;
				if (num != 0)
				{
				}
				num = (short)561512448;
				short num3 = num;
				num = (short)944177153;
				if (num != 0)
				{
				}
				this.allowPSUSecure_43809.HiddenStatic = value;
			}
		}

		// Token: 0x17001E57 RID: 7767
		// (get) Token: 0x06003B47 RID: 15175 RVA: 0x0037AED4 File Offset: 0x003790D4
		// (set) Token: 0x06003B48 RID: 15176 RVA: 0x0037AF88 File Offset: 0x00379188
		internal bool AllowPSUSecure_43809_HiddenDynamic
		{
			get
			{
				short num = (short)1887793010;
				short num2 = num;
				num = (short)966553458;
				switch (num2 == num)
				{
				}
				num = (short)356646912;
				if (num != 0)
				{
				}
				num = (short)1037107200;
				short num3 = num;
				num = (short)1656750081;
				if (num != 0)
				{
				}
				return this.allowPSUSecure_43809.HiddenDynamic;
			}
			set
			{
				short num = (short)1752284146;
				short num2 = num;
				num = (short)1305852914;
				switch (num2 == num)
				{
				}
				num = (short)445841409;
				if (num != 0)
				{
				}
				num = (short)69468160;
				short num3 = num;
				num = (short)1110245376;
				if (num != 0)
				{
				}
				this.allowPSUSecure_43809.HiddenDynamic = value;
			}
		}

		// Token: 0x17001E58 RID: 7768
		// (get) Token: 0x06003B49 RID: 15177 RVA: 0x0037B03C File Offset: 0x0037923C
		public bool AllowPSUSecure_43809_HasDiffs
		{
			get
			{
				short num = (short)421448848;
				short num2 = num;
				num = (short)1958530192;
				switch (num2 == num)
				{
				}
				num = (short)50266112;
				if (num != 0)
				{
				}
				num = (short)779026432;
				short num3 = num;
				num = (short)737673217;
				if (num != 0)
				{
				}
				return this.allowPSUSecure_43809._HasDiffs;
			}
		}

		// Token: 0x17001E59 RID: 7769
		// (get) Token: 0x06003B4A RID: 15178 RVA: 0x0037B0F0 File Offset: 0x003792F0
		// (set) Token: 0x06003B4B RID: 15179 RVA: 0x0037B1A4 File Offset: 0x003793A4
		public bool UCLContactsLimitationEnhancement_43811Value
		{
			get
			{
				short num = (short)1815896292;
				short num2 = num;
				num = (short)1678467300;
				switch (num2 == num)
				{
				}
				num = (short)1689714689;
				if (num != 0)
				{
				}
				num = (short)69795840;
				short num3 = num;
				num = (short)574226432;
				if (num != 0)
				{
				}
				return this.uCLContactsLimitationEnhancement_43811.Value;
			}
			set
			{
				short num = (short)1808696360;
				short num2 = num;
				num = (short)1635812392;
				switch (num2 == num)
				{
				}
				num = (short)1932394497;
				if (num != 0)
				{
				}
				num = (short)1342504960;
				short num3 = num;
				num = (short)44040192;
				if (num != 0)
				{
				}
				this.uCLContactsLimitationEnhancement_43811.Value = value;
			}
		}

		// Token: 0x17001E5A RID: 7770
		// (get) Token: 0x06003B4C RID: 15180 RVA: 0x0037B25C File Offset: 0x0037945C
		public global::AcpBusinessLayer.AcpField<bool> UCLContactsLimitationEnhancement_43811
		{
			get
			{
				short num = (short)1751928832;
				short num2 = num;
				num = (short)164253696;
				switch (num2 == num)
				{
				}
				num = (short)1487339520;
				if (num != 0)
				{
				}
				num = (short)1575354368;
				short num3 = num;
				num = (short)12713985;
				if (num != 0)
				{
				}
				return this.uCLContactsLimitationEnhancement_43811;
			}
		}

		// Token: 0x17001E5B RID: 7771
		// (get) Token: 0x06003B4D RID: 15181 RVA: 0x0037B30C File Offset: 0x0037950C
		// (set) Token: 0x06003B4E RID: 15182 RVA: 0x0037B3C4 File Offset: 0x003795C4
		public bool UCLContactsLimitationEnhancement_43811_UIValue
		{
			get
			{
				short num = (short)2132375640;
				short num2 = num;
				num = (short)1724348504;
				switch (num2 == num)
				{
				}
				num = (short)845283328;
				if (num != 0)
				{
				}
				num = (short)1548943360;
				short num3 = num;
				num = (short)469827585;
				if (num != 0)
				{
				}
				return this.uCLContactsLimitationEnhancement_43811.Value;
			}
			set
			{
				short num = (short)490984983;
				short num2 = num;
				num = (short)875615767;
				switch (num2 == num)
				{
				}
				num = (short)1749352449;
				if (num != 0)
				{
				}
				num = (short)50331648;
				short num3 = num;
				num = (short)1499594752;
				if (num != 0)
				{
				}
				this.uCLContactsLimitationEnhancement_43811.Value = value;
			}
		}

		// Token: 0x17001E5C RID: 7772
		// (get) Token: 0x06003B4F RID: 15183 RVA: 0x0037B47C File Offset: 0x0037967C
		// (set) Token: 0x06003B50 RID: 15184 RVA: 0x0037B534 File Offset: 0x00379734
		public bool UCLContactsLimitationEnhancement_43811_Applicable
		{
			get
			{
				short num = (short)502534454;
				short num2 = num;
				num = (short)1128141110;
				switch (num2 == num)
				{
				}
				num = (short)1392967681;
				if (num != 0)
				{
				}
				num = (short)1921712128;
				short num3 = num;
				num = (short)698810368;
				if (num != 0)
				{
				}
				return this.uCLContactsLimitationEnhancement_43811.Applicable;
			}
			set
			{
				short num = (short)1293009185;
				short num2 = num;
				num = (short)1977073953;
				switch (num2 == num)
				{
				}
				num = (short)1509883904;
				if (num != 0)
				{
				}
				num = (short)253165568;
				short num3 = num;
				num = (short)1350959105;
				if (num != 0)
				{
				}
				this.uCLContactsLimitationEnhancement_43811.Applicable = value;
			}
		}

		// Token: 0x17001E5D RID: 7773
		// (get) Token: 0x06003B51 RID: 15185 RVA: 0x0037B5EC File Offset: 0x003797EC
		// (set) Token: 0x06003B52 RID: 15186 RVA: 0x0037B6A0 File Offset: 0x003798A0
		public bool UCLContactsLimitationEnhancement_43811_Valid
		{
			get
			{
				short num = (short)454862909;
				short num2 = num;
				num = (short)864331837;
				switch (num2 == num)
				{
				}
				num = (short)2079260673;
				if (num != 0)
				{
				}
				num = (short)282263552;
				short num3 = num;
				num = (short)168755200;
				if (num != 0)
				{
				}
				return this.uCLContactsLimitationEnhancement_43811.Valid;
			}
			set
			{
				short num = (short)239337473;
				if (num != 0)
				{
				}
				num = (short)1279726326;
				short num2 = num;
				num = (short)2102924022;
				switch (num2 == num)
				{
				}
				num = (short)612106240;
				short num3 = num;
				num = (short)313262080;
				if (num != 0)
				{
				}
				this.uCLContactsLimitationEnhancement_43811.Valid = value;
			}
		}

		// Token: 0x17001E5E RID: 7774
		// (get) Token: 0x06003B53 RID: 15187 RVA: 0x0037B758 File Offset: 0x00379958
		// (set) Token: 0x06003B54 RID: 15188 RVA: 0x0037B810 File Offset: 0x00379A10
		public bool UCLContactsLimitationEnhancement_43811_Visible
		{
			get
			{
				short num = (short)1242704786;
				short num2 = num;
				num = (short)1017260946;
				switch (num2 == num)
				{
				}
				num = (short)1481572352;
				if (num != 0)
				{
				}
				num = (short)1821179904;
				short num3 = num;
				num = (short)20185089;
				if (num != 0)
				{
				}
				return this.uCLContactsLimitationEnhancement_43811.Visible;
			}
			set
			{
				short num = (short)28034904;
				short num2 = num;
				num = (short)1985005400;
				switch (num2 == num)
				{
				}
				num = (short)263323649;
				if (num != 0)
				{
				}
				num = (short)985202688;
				short num3 = num;
				num = (short)1113784320;
				if (num != 0)
				{
				}
				this.uCLContactsLimitationEnhancement_43811.Visible = value;
			}
		}

		// Token: 0x17001E5F RID: 7775
		// (get) Token: 0x06003B55 RID: 15189 RVA: 0x0037B8C4 File Offset: 0x00379AC4
		// (set) Token: 0x06003B56 RID: 15190 RVA: 0x0037B978 File Offset: 0x00379B78
		public bool UCLContactsLimitationEnhancement_43811_Editable
		{
			get
			{
				short num = (short)1502846809;
				short num2 = num;
				num = (short)372023129;
				switch (num2 == num)
				{
				}
				num = (short)500105217;
				if (num != 0)
				{
				}
				num = (short)1939537920;
				short num3 = num;
				num = (short)1024327680;
				if (num != 0)
				{
				}
				return this.uCLContactsLimitationEnhancement_43811.Editable;
			}
			set
			{
				short num = (short)509422723;
				short num2 = num;
				num = (short)1679371395;
				switch (num2 == num)
				{
				}
				num = (short)799670273;
				if (num != 0)
				{
				}
				num = (short)1925775360;
				short num3 = num;
				num = (short)2002386944;
				if (num != 0)
				{
				}
				this.uCLContactsLimitationEnhancement_43811.Editable = value;
			}
		}

		// Token: 0x17001E60 RID: 7776
		// (get) Token: 0x06003B57 RID: 15191 RVA: 0x0037BA2C File Offset: 0x00379C2C
		internal string UCLContactsLimitationEnhancement_43811_UILabel
		{
			get
			{
				short num = (short)1459734430;
				short num2 = num;
				num = (short)1824507806;
				switch (num2 == num)
				{
				}
				num = (short)1154613248;
				if (num != 0)
				{
				}
				num = (short)1517355008;
				short num3 = num;
				num = (short)1918566401;
				if (num != 0)
				{
				}
				return this.uCLContactsLimitationEnhancement_43811.UIName;
			}
		}

		// Token: 0x17001E61 RID: 7777
		// (get) Token: 0x06003B58 RID: 15192 RVA: 0x0037BAE0 File Offset: 0x00379CE0
		// (set) Token: 0x06003B59 RID: 15193 RVA: 0x0037BB94 File Offset: 0x00379D94
		internal bool UCLContactsLimitationEnhancement_43811_HiddenStatic
		{
			get
			{
				short num = (short)1923696734;
				short num2 = num;
				num = (short)483805278;
				switch (num2 == num)
				{
				}
				num = (short)897187841;
				if (num != 0)
				{
				}
				num = (short)1984757760;
				short num3 = num;
				num = (short)1140719616;
				if (num != 0)
				{
				}
				return this.uCLContactsLimitationEnhancement_43811.HiddenStatic;
			}
			set
			{
				short num = (short)1887529836;
				short num2 = num;
				num = (short)307719020;
				switch (num2 == num)
				{
				}
				num = (short)1573847041;
				if (num != 0)
				{
				}
				num = (short)1235288064;
				short num3 = num;
				num = (short)2022113280;
				if (num != 0)
				{
				}
				this.uCLContactsLimitationEnhancement_43811.HiddenStatic = value;
			}
		}

		// Token: 0x17001E62 RID: 7778
		// (get) Token: 0x06003B5A RID: 15194 RVA: 0x0037BC4C File Offset: 0x00379E4C
		// (set) Token: 0x06003B5B RID: 15195 RVA: 0x0037BD00 File Offset: 0x00379F00
		internal bool UCLContactsLimitationEnhancement_43811_HiddenDynamic
		{
			get
			{
				short num = (short)2058086612;
				short num2 = num;
				num = (short)877324500;
				switch (num2 == num)
				{
				}
				num = (short)1691353089;
				if (num != 0)
				{
				}
				num = (short)264306688;
				short num3 = num;
				num = (short)1285488640;
				if (num != 0)
				{
				}
				return this.uCLContactsLimitationEnhancement_43811.HiddenDynamic;
			}
			set
			{
				short num = (short)1037762561;
				if (num != 0)
				{
				}
				num = (short)404189676;
				short num2 = num;
				num = (short)565866988;
				switch (num2 == num)
				{
				}
				num = (short)1133445120;
				short num3 = num;
				num = (short)767229952;
				if (num != 0)
				{
				}
				this.uCLContactsLimitationEnhancement_43811.HiddenDynamic = value;
			}
		}

		// Token: 0x17001E63 RID: 7779
		// (get) Token: 0x06003B5C RID: 15196 RVA: 0x0037BDB8 File Offset: 0x00379FB8
		public bool UCLContactsLimitationEnhancement_43811_HasDiffs
		{
			get
			{
				short num = (short)219086849;
				if (num != 0)
				{
				}
				num = (short)739811964;
				short num2 = num;
				num = (short)257073788;
				switch (num2 == num)
				{
				}
				num = (short)646447104;
				short num3 = num;
				num = (short)2106851328;
				if (num != 0)
				{
				}
				return this.uCLContactsLimitationEnhancement_43811._HasDiffs;
			}
		}

		// Token: 0x17001E64 RID: 7780
		// (get) Token: 0x06003B5D RID: 15197 RVA: 0x0037BE6C File Offset: 0x0037A06C
		// (set) Token: 0x06003B5E RID: 15198 RVA: 0x0037BF20 File Offset: 0x0037A120
		public bool DVRSRangeExt_44809Value
		{
			get
			{
				short num = (short)1125042780;
				short num2 = num;
				num = (short)1921239644;
				switch (num2 == num)
				{
				}
				num = (short)2129068033;
				if (num != 0)
				{
				}
				num = (short)890765312;
				short num3 = num;
				num = (short)343670784;
				if (num != 0)
				{
				}
				return this.dVRSRangeExt_44809.Value;
			}
			set
			{
				short num = (short)838533121;
				if (num != 0)
				{
				}
				num = (short)1953448167;
				short num2 = num;
				num = (short)2085765351;
				switch (num2 == num)
				{
				}
				num = (short)450363392;
				short num3 = num;
				num = (short)261947392;
				if (num != 0)
				{
				}
				this.dVRSRangeExt_44809.Value = value;
			}
		}

		// Token: 0x17001E65 RID: 7781
		// (get) Token: 0x06003B5F RID: 15199 RVA: 0x0037BFD4 File Offset: 0x0037A1D4
		public global::AcpBusinessLayer.AcpField<bool> DVRSRangeExt_44809
		{
			get
			{
				short num = (short)303524962;
				short num2 = num;
				num = (short)115305570;
				switch (num2 == num)
				{
				}
				num = (short)957743105;
				if (num != 0)
				{
				}
				num = (short)1344471040;
				short num3 = num;
				num = (short)158203904;
				if (num != 0)
				{
				}
				return this.dVRSRangeExt_44809;
			}
		}

		// Token: 0x17001E66 RID: 7782
		// (get) Token: 0x06003B60 RID: 15200 RVA: 0x0037C088 File Offset: 0x0037A288
		// (set) Token: 0x06003B61 RID: 15201 RVA: 0x0037C13C File Offset: 0x0037A33C
		public bool DVRSRangeExt_44809_UIValue
		{
			get
			{
				short num = (short)543384177;
				short num2 = num;
				num = (short)795501169;
				switch (num2 == num)
				{
				}
				num = (short)989790209;
				if (num != 0)
				{
				}
				num = (short)692781056;
				short num3 = num;
				num = (short)1525022720;
				if (num != 0)
				{
				}
				return this.dVRSRangeExt_44809.Value;
			}
			set
			{
				short num = (short)656388819;
				short num2 = num;
				num = (short)1551020755;
				switch (num2 == num)
				{
				}
				num = (short)614137857;
				if (num != 0)
				{
				}
				num = (short)923205632;
				short num3 = num;
				num = (short)1227096064;
				if (num != 0)
				{
				}
				this.dVRSRangeExt_44809.Value = value;
			}
		}

		// Token: 0x17001E67 RID: 7783
		// (get) Token: 0x06003B62 RID: 15202 RVA: 0x0037C1F0 File Offset: 0x0037A3F0
		// (set) Token: 0x06003B63 RID: 15203 RVA: 0x0037C2A8 File Offset: 0x0037A4A8
		public bool DVRSRangeExt_44809_Applicable
		{
			get
			{
				short num = (short)1276170707;
				short num2 = num;
				num = (short)1161023955;
				switch (num2 == num)
				{
				}
				num = (short)1450049537;
				if (num != 0)
				{
				}
				num = (short)647364608;
				short num3 = num;
				num = (short)1008467968;
				if (num != 0)
				{
				}
				return this.dVRSRangeExt_44809.Applicable;
			}
			set
			{
				short num = (short)1311054527;
				short num2 = num;
				num = (short)11934399;
				switch (num2 == num)
				{
				}
				num = (short)881786881;
				if (num != 0)
				{
				}
				num = (short)1063845888;
				short num3 = num;
				num = (short)1831206912;
				if (num != 0)
				{
				}
				this.dVRSRangeExt_44809.Applicable = value;
			}
		}

		// Token: 0x17001E68 RID: 7784
		// (get) Token: 0x06003B64 RID: 15204 RVA: 0x0037C35C File Offset: 0x0037A55C
		// (set) Token: 0x06003B65 RID: 15205 RVA: 0x0037C40C File Offset: 0x0037A60C
		public bool DVRSRangeExt_44809_Valid
		{
			get
			{
				short num = (short)1149189951;
				short num2 = num;
				num = (short)386416447;
				switch (num2 == num)
				{
				}
				num = (short)541720577;
				if (num != 0)
				{
				}
				num = (short)484704256;
				short num3 = num;
				num = (short)646512640;
				if (num != 0)
				{
				}
				return this.dVRSRangeExt_44809.Valid;
			}
			set
			{
				short num = (short)327829197;
				short num2 = num;
				num = (short)1203783373;
				switch (num2 == num)
				{
				}
				num = (short)1682178049;
				if (num != 0)
				{
				}
				num = (short)1303904256;
				short num3 = num;
				num = (short)1399390208;
				if (num != 0)
				{
				}
				this.dVRSRangeExt_44809.Valid = value;
			}
		}

		// Token: 0x17001E69 RID: 7785
		// (get) Token: 0x06003B66 RID: 15206 RVA: 0x0037C4C0 File Offset: 0x0037A6C0
		// (set) Token: 0x06003B67 RID: 15207 RVA: 0x0037C578 File Offset: 0x0037A778
		public bool DVRSRangeExt_44809_Visible
		{
			get
			{
				short num = (short)172481948;
				short num2 = num;
				num = (short)1451744668;
				switch (num2 == num)
				{
				}
				num = (short)702611457;
				if (num != 0)
				{
				}
				num = (short)806813696;
				short num3 = num;
				num = (short)442630144;
				if (num != 0)
				{
				}
				return this.dVRSRangeExt_44809.Visible;
			}
			set
			{
				short num = (short)296941071;
				short num2 = num;
				num = (short)680326671;
				switch (num2 == num)
				{
				}
				num = (short)127795200;
				if (num != 0)
				{
				}
				num = (short)2068971520;
				short num3 = num;
				num = (short)5636097;
				if (num != 0)
				{
				}
				this.dVRSRangeExt_44809.Visible = value;
			}
		}

		// Token: 0x17001E6A RID: 7786
		// (get) Token: 0x06003B68 RID: 15208 RVA: 0x0037C62C File Offset: 0x0037A82C
		// (set) Token: 0x06003B69 RID: 15209 RVA: 0x0037C6E4 File Offset: 0x0037A8E4
		public bool DVRSRangeExt_44809_Editable
		{
			get
			{
				short num = (short)73311386;
				short num2 = num;
				num = (short)215131290;
				switch (num2 == num)
				{
				}
				num = (short)520683520;
				if (num != 0)
				{
				}
				num = (short)1564409856;
				short num3 = num;
				num = (short)1454899201;
				if (num != 0)
				{
				}
				return this.dVRSRangeExt_44809.Editable;
			}
			set
			{
				short num = (short)632331950;
				short num2 = num;
				num = (short)1420336814;
				switch (num2 == num)
				{
				}
				num = (short)115605505;
				if (num != 0)
				{
				}
				num = (short)572850176;
				short num3 = num;
				num = (short)140443648;
				if (num != 0)
				{
				}
				this.dVRSRangeExt_44809.Editable = value;
			}
		}

		// Token: 0x17001E6B RID: 7787
		// (get) Token: 0x06003B6A RID: 15210 RVA: 0x0037C798 File Offset: 0x0037A998
		internal string DVRSRangeExt_44809_UILabel
		{
			get
			{
				short num = (short)2130590742;
				short num2 = num;
				num = (short)2000894998;
				switch (num2 == num)
				{
				}
				num = (short)194117633;
				if (num != 0)
				{
				}
				num = (short)1106378752;
				short num3 = num;
				num = (short)1238106112;
				if (num != 0)
				{
				}
				return this.dVRSRangeExt_44809.UIName;
			}
		}

		// Token: 0x17001E6C RID: 7788
		// (get) Token: 0x06003B6B RID: 15211 RVA: 0x0037C84C File Offset: 0x0037AA4C
		// (set) Token: 0x06003B6C RID: 15212 RVA: 0x0037C904 File Offset: 0x0037AB04
		internal bool DVRSRangeExt_44809_HiddenStatic
		{
			get
			{
				short num = (short)817446902;
				short num2 = num;
				num = (short)680673270;
				switch (num2 == num)
				{
				}
				num = (short)2058289153;
				if (num != 0)
				{
				}
				num = (short)947453952;
				short num3 = num;
				num = (short)1795751936;
				if (num != 0)
				{
				}
				return this.dVRSRangeExt_44809.HiddenStatic;
			}
			set
			{
				short num = (short)767284898;
				short num2 = num;
				num = (short)2050479778;
				switch (num2 == num)
				{
				}
				num = (short)2064121857;
				if (num != 0)
				{
				}
				num = (short)1826095104;
				short num3 = num;
				num = (short)1107689472;
				if (num != 0)
				{
				}
				this.dVRSRangeExt_44809.HiddenStatic = value;
			}
		}

		// Token: 0x17001E6D RID: 7789
		// (get) Token: 0x06003B6D RID: 15213 RVA: 0x0037C9BC File Offset: 0x0037ABBC
		// (set) Token: 0x06003B6E RID: 15214 RVA: 0x0037CA70 File Offset: 0x0037AC70
		internal bool DVRSRangeExt_44809_HiddenDynamic
		{
			get
			{
				short num = (short)382520493;
				short num2 = num;
				num = (short)279760045;
				switch (num2 == num)
				{
				}
				num = (short)2123825153;
				if (num != 0)
				{
				}
				num = (short)1579417600;
				if (num != 0)
				{
				}
				num = (short)1544814592;
				short num3 = num;
				return this.dVRSRangeExt_44809.HiddenDynamic;
			}
			set
			{
				short num = (short)2029717362;
				short num2 = num;
				num = (short)1135019890;
				switch (num2 == num)
				{
				}
				num = (short)1095237632;
				if (num != 0)
				{
				}
				num = (short)1763770369;
				if (num != 0)
				{
				}
				num = (short)1149894656;
				short num3 = num;
				this.dVRSRangeExt_44809.HiddenDynamic = value;
			}
		}

		// Token: 0x17001E6E RID: 7790
		// (get) Token: 0x06003B6F RID: 15215 RVA: 0x0037CB24 File Offset: 0x0037AD24
		public bool DVRSRangeExt_44809_HasDiffs
		{
			get
			{
				short num = (short)836543147;
				short num2 = num;
				num = (short)1470735019;
				switch (num2 == num)
				{
				}
				num = (short)476053505;
				if (num != 0)
				{
				}
				num = (short)1902379008;
				if (num != 0)
				{
				}
				num = (short)1967390720;
				short num3 = num;
				return this.dVRSRangeExt_44809._HasDiffs;
			}
		}

		// Token: 0x17001E6F RID: 7791
		// (get) Token: 0x06003B70 RID: 15216 RVA: 0x0037CBDC File Offset: 0x0037ADDC
		// (set) Token: 0x06003B71 RID: 15217 RVA: 0x0037CC90 File Offset: 0x0037AE90
		public bool RadWideLabtoolIndirectPTTAudioRoutingPCI_44817Value
		{
			get
			{
				short num = (short)565475234;
				short num2 = num;
				num = (short)141391778;
				switch (num2 == num)
				{
				}
				num = (short)1910964224;
				if (num != 0)
				{
				}
				num = (short)779681793;
				if (num != 0)
				{
				}
				num = (short)962461696;
				short num3 = num;
				return this.radWideLabtoolIndirectPTTAudioRoutingPCI_44817.Value;
			}
			set
			{
				short num = (short)1279018438;
				short num2 = num;
				num = (short)887178694;
				switch (num2 == num)
				{
				}
				num = (short)383451137;
				if (num != 0)
				{
				}
				num = (short)738852864;
				if (num != 0)
				{
				}
				num = (short)1967259648;
				short num3 = num;
				this.radWideLabtoolIndirectPTTAudioRoutingPCI_44817.Value = value;
			}
		}

		// Token: 0x17001E70 RID: 7792
		// (get) Token: 0x06003B72 RID: 15218 RVA: 0x0037CD48 File Offset: 0x0037AF48
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolIndirectPTTAudioRoutingPCI_44817
		{
			get
			{
				short num = (short)138815100;
				short num2 = num;
				num = (short)1460348540;
				switch (num2 == num)
				{
				}
				num = (short)1288372225;
				if (num != 0)
				{
				}
				num = (short)885850112;
				if (num != 0)
				{
				}
				num = (short)1711538176;
				short num3 = num;
				return this.radWideLabtoolIndirectPTTAudioRoutingPCI_44817;
			}
		}

		// Token: 0x17001E71 RID: 7793
		// (get) Token: 0x06003B73 RID: 15219 RVA: 0x0037CDF8 File Offset: 0x0037AFF8
		// (set) Token: 0x06003B74 RID: 15220 RVA: 0x0037CEB0 File Offset: 0x0037B0B0
		public bool RadWideLabtoolIndirectPTTAudioRoutingPCI_44817_UIValue
		{
			get
			{
				short num = (short)1681368410;
				short num2 = num;
				num = (short)1678288218;
				switch (num2 == num)
				{
				}
				num = (short)529072129;
				if (num != 0)
				{
				}
				num = (short)1973944320;
				if (num != 0)
				{
				}
				num = (short)1587478528;
				short num3 = num;
				return this.radWideLabtoolIndirectPTTAudioRoutingPCI_44817.Value;
			}
			set
			{
				short num = (short)588037079;
				short num2 = num;
				num = (short)347061207;
				switch (num2 == num)
				{
				}
				num = (short)620953601;
				if (num != 0)
				{
				}
				num = (short)1786773504;
				if (num != 0)
				{
				}
				num = (short)24772608;
				short num3 = num;
				this.radWideLabtoolIndirectPTTAudioRoutingPCI_44817.Value = value;
			}
		}

		// Token: 0x17001E72 RID: 7794
		// (get) Token: 0x06003B75 RID: 15221 RVA: 0x0037CF68 File Offset: 0x0037B168
		// (set) Token: 0x06003B76 RID: 15222 RVA: 0x0037D01C File Offset: 0x0037B21C
		public bool RadWideLabtoolIndirectPTTAudioRoutingPCI_44817_Applicable
		{
			get
			{
				short num = (short)915161822;
				short num2 = num;
				num = (short)1673478878;
				switch (num2 == num)
				{
				}
				num = (short)731840513;
				if (num != 0)
				{
				}
				num = (short)2054291456;
				if (num != 0)
				{
				}
				num = (short)794755072;
				short num3 = num;
				return this.radWideLabtoolIndirectPTTAudioRoutingPCI_44817.Applicable;
			}
			set
			{
				short num = (short)913637377;
				if (num != 0)
				{
				}
				num = (short)1454544059;
				short num2 = num;
				num = (short)763401403;
				switch (num2 == num)
				{
				}
				num = (short)1006501888;
				if (num != 0)
				{
				}
				num = (short)1553072128;
				short num3 = num;
				this.radWideLabtoolIndirectPTTAudioRoutingPCI_44817.Applicable = value;
			}
		}

		// Token: 0x17001E73 RID: 7795
		// (get) Token: 0x06003B77 RID: 15223 RVA: 0x0037D0CC File Offset: 0x0037B2CC
		// (set) Token: 0x06003B78 RID: 15224 RVA: 0x0037D180 File Offset: 0x0037B380
		public bool RadWideLabtoolIndirectPTTAudioRoutingPCI_44817_Valid
		{
			get
			{
				short num = (short)45678593;
				if (num != 0)
				{
				}
				num = (short)1946033302;
				short num2 = num;
				num = (short)160242838;
				switch (num2 == num)
				{
				}
				num = (short)1985347584;
				if (num != 0)
				{
				}
				num = (short)403374080;
				short num3 = num;
				return this.radWideLabtoolIndirectPTTAudioRoutingPCI_44817.Valid;
			}
			set
			{
				short num = (short)566343712;
				short num2 = num;
				num = (short)1222228000;
				switch (num2 == num)
				{
				}
				num = (short)2011103233;
				if (num != 0)
				{
				}
				num = (short)1568931840;
				if (num != 0)
				{
				}
				num = (short)61538304;
				short num3 = num;
				this.radWideLabtoolIndirectPTTAudioRoutingPCI_44817.Valid = value;
			}
		}

		// Token: 0x17001E74 RID: 7796
		// (get) Token: 0x06003B79 RID: 15225 RVA: 0x0037D234 File Offset: 0x0037B434
		// (set) Token: 0x06003B7A RID: 15226 RVA: 0x0037D2E8 File Offset: 0x0037B4E8
		public bool RadWideLabtoolIndirectPTTAudioRoutingPCI_44817_Visible
		{
			get
			{
				short num = (short)1662451713;
				if (num != 0)
				{
				}
				num = (short)1535690497;
				short num2 = num;
				num = (short)859358977;
				switch (num2 == num)
				{
				}
				num = (short)1480261632;
				if (num != 0)
				{
				}
				num = (short)2064121856;
				short num3 = num;
				return this.radWideLabtoolIndirectPTTAudioRoutingPCI_44817.Visible;
			}
			set
			{
				short num = (short)1581371708;
				short num2 = num;
				num = (short)1525076284;
				switch (num2 == num)
				{
				}
				num = (short)1111621632;
				if (num != 0)
				{
				}
				num = (short)1353449473;
				if (num != 0)
				{
				}
				num = (short)1111490560;
				short num3 = num;
				this.radWideLabtoolIndirectPTTAudioRoutingPCI_44817.Visible = value;
			}
		}

		// Token: 0x17001E75 RID: 7797
		// (get) Token: 0x06003B7B RID: 15227 RVA: 0x0037D39C File Offset: 0x0037B59C
		// (set) Token: 0x06003B7C RID: 15228 RVA: 0x0037D450 File Offset: 0x0037B650
		public bool RadWideLabtoolIndirectPTTAudioRoutingPCI_44817_Editable
		{
			get
			{
				short num = (short)130347951;
				short num2 = num;
				num = (short)1319957423;
				switch (num2 == num)
				{
				}
				num = (short)48168961;
				if (num != 0)
				{
				}
				num = (short)979435520;
				if (num != 0)
				{
				}
				num = (short)2037383168;
				short num3 = num;
				return this.radWideLabtoolIndirectPTTAudioRoutingPCI_44817.Editable;
			}
			set
			{
				short num = (short)878776082;
				short num2 = num;
				num = (short)1130762002;
				switch (num2 == num)
				{
				}
				num = (short)1914961920;
				if (num != 0)
				{
				}
				num = (short)1324220417;
				if (num != 0)
				{
				}
				num = (short)1084227584;
				short num3 = num;
				this.radWideLabtoolIndirectPTTAudioRoutingPCI_44817.Editable = value;
			}
		}

		// Token: 0x17001E76 RID: 7798
		// (get) Token: 0x06003B7D RID: 15229 RVA: 0x0037D508 File Offset: 0x0037B708
		internal string RadWideLabtoolIndirectPTTAudioRoutingPCI_44817_UILabel
		{
			get
			{
				short num = (short)569981035;
				short num2 = num;
				num = (short)594491499;
				switch (num2 == num)
				{
				}
				num = (short)349372416;
				if (num != 0)
				{
				}
				num = (short)483459073;
				if (num != 0)
				{
				}
				num = (short)557580288;
				short num3 = num;
				return this.radWideLabtoolIndirectPTTAudioRoutingPCI_44817.UIName;
			}
		}

		// Token: 0x17001E77 RID: 7799
		// (get) Token: 0x06003B7E RID: 15230 RVA: 0x0037D5BC File Offset: 0x0037B7BC
		// (set) Token: 0x06003B7F RID: 15231 RVA: 0x0037D674 File Offset: 0x0037B874
		internal bool RadWideLabtoolIndirectPTTAudioRoutingPCI_44817_HiddenStatic
		{
			get
			{
				short num = (short)1344457973;
				short num2 = num;
				num = (short)54054133;
				switch (num2 == num)
				{
				}
				num = (short)351993857;
				if (num != 0)
				{
				}
				num = (short)2035875840;
				if (num != 0)
				{
				}
				num = (short)1965490176;
				short num3 = num;
				return this.radWideLabtoolIndirectPTTAudioRoutingPCI_44817.HiddenStatic;
			}
			set
			{
				short num = (short)195293589;
				short num2 = num;
				num = (short)1399320981;
				switch (num2 == num)
				{
				}
				num = (short)2142568449;
				if (num != 0)
				{
				}
				num = (short)1202520064;
				if (num != 0)
				{
				}
				num = (short)948436992;
				short num3 = num;
				this.radWideLabtoolIndirectPTTAudioRoutingPCI_44817.HiddenStatic = value;
			}
		}

		// Token: 0x17001E78 RID: 7800
		// (get) Token: 0x06003B80 RID: 15232 RVA: 0x0037D728 File Offset: 0x0037B928
		// (set) Token: 0x06003B81 RID: 15233 RVA: 0x0037D7DC File Offset: 0x0037B9DC
		internal bool RadWideLabtoolIndirectPTTAudioRoutingPCI_44817_HiddenDynamic
		{
			get
			{
				short num = (short)1518898089;
				short num2 = num;
				num = (short)168790953;
				switch (num2 == num)
				{
				}
				num = (short)2092892160;
				if (num != 0)
				{
				}
				num = (short)198770689;
				if (num != 0)
				{
				}
				num = (short)903806976;
				short num3 = num;
				return this.radWideLabtoolIndirectPTTAudioRoutingPCI_44817.HiddenDynamic;
			}
			set
			{
				short num = (short)1569846402;
				short num2 = num;
				num = (short)839251074;
				switch (num2 == num)
				{
				}
				num = (short)1893466112;
				if (num != 0)
				{
				}
				num = (short)938016769;
				if (num != 0)
				{
				}
				num = (short)183762944;
				short num3 = num;
				this.radWideLabtoolIndirectPTTAudioRoutingPCI_44817.HiddenDynamic = value;
			}
		}

		// Token: 0x17001E79 RID: 7801
		// (get) Token: 0x06003B82 RID: 15234 RVA: 0x0037D890 File Offset: 0x0037BA90
		public bool RadWideLabtoolIndirectPTTAudioRoutingPCI_44817_HasDiffs
		{
			get
			{
				short num = (short)712843703;
				short num2 = num;
				num = (short)123412919;
				switch (num2 == num)
				{
				}
				num = (short)1622474753;
				if (num != 0)
				{
				}
				num = (short)388694016;
				if (num != 0)
				{
				}
				num = (short)1129250816;
				short num3 = num;
				return this.radWideLabtoolIndirectPTTAudioRoutingPCI_44817._HasDiffs;
			}
		}

		// Token: 0x17001E7A RID: 7802
		// (get) Token: 0x06003B83 RID: 15235 RVA: 0x0037D944 File Offset: 0x0037BB44
		// (set) Token: 0x06003B84 RID: 15236 RVA: 0x0037D9F8 File Offset: 0x0037BBF8
		public int RadWideLabtoolCertMgmtMotorolaSolutionsPKIPortValue
		{
			get
			{
				short num = (short)513776941;
				short num2 = num;
				num = (short)1747885357;
				switch (num2 == num)
				{
				}
				num = (short)1581121537;
				if (num != 0)
				{
				}
				num = (short)1287520256;
				if (num != 0)
				{
				}
				num = (short)1570832384;
				short num3 = num;
				return this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.Value;
			}
			set
			{
				short num = (short)2019206789;
				short num2 = num;
				num = (short)1792779909;
				switch (num2 == num)
				{
				}
				num = (short)1611464705;
				if (num != 0)
				{
				}
				num = (short)394133504;
				if (num != 0)
				{
				}
				num = (short)1161035776;
				short num3 = num;
				this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.Value = value;
			}
		}

		// Token: 0x17001E7B RID: 7803
		// (get) Token: 0x06003B85 RID: 15237 RVA: 0x0037DAB0 File Offset: 0x0037BCB0
		// (set) Token: 0x06003B86 RID: 15238 RVA: 0x0037DB64 File Offset: 0x0037BD64
		public int RadWideLabtoolCertMgmtMotorolaSolutionsPKIPort_UIValue
		{
			get
			{
				short num = (short)8043351;
				short num2 = num;
				num = (short)1030732631;
				switch (num2 == num)
				{
				}
				num = (short)316735489;
				if (num != 0)
				{
				}
				num = (short)1867841536;
				if (num != 0)
				{
				}
				num = (short)1604255744;
				short num3 = num;
				return this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.Value;
			}
			set
			{
				short num = (short)169398775;
				short num2 = num;
				num = (short)270455287;
				switch (num2 == num)
				{
				}
				num = (short)1346043904;
				if (num != 0)
				{
				}
				num = (short)679936001;
				if (num != 0)
				{
				}
				num = (short)1129185280;
				short num3 = num;
				this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.Value = value;
			}
		}

		// Token: 0x17001E7C RID: 7804
		// (get) Token: 0x06003B87 RID: 15239 RVA: 0x0037DC1C File Offset: 0x0037BE1C
		public global::AcpBusinessLayer.AcpSimpleRangeField RadWideLabtoolCertMgmtMotorolaSolutionsPKIPort
		{
			get
			{
				short num = (short)1988131411;
				short num2 = num;
				num = (short)490633811;
				switch (num2 == num)
				{
				}
				num = (short)2054029313;
				if (num != 0)
				{
				}
				num = (short)200998912;
				if (num != 0)
				{
				}
				num = (short)1117782016;
				short num3 = num;
				return this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort;
			}
		}

		// Token: 0x17001E7D RID: 7805
		// (get) Token: 0x06003B88 RID: 15240 RVA: 0x0037DCCC File Offset: 0x0037BECC
		// (set) Token: 0x06003B89 RID: 15241 RVA: 0x0037DD80 File Offset: 0x0037BF80
		internal int RadWideLabtoolCertMgmtMotorolaSolutionsPKIPortMin
		{
			get
			{
				short num = (short)1960823456;
				short num2 = num;
				num = (short)1589365408;
				switch (num2 == num)
				{
				}
				num = (short)1276772352;
				if (num != 0)
				{
				}
				num = (short)1158676481;
				if (num != 0)
				{
				}
				num = (short)979763200;
				short num3 = num;
				return this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.Min;
			}
			set
			{
				short num = (short)1799560423;
				short num2 = num;
				num = (short)910957799;
				switch (num2 == num)
				{
				}
				num = (short)1382219777;
				if (num != 0)
				{
				}
				num = (short)855769088;
				if (num != 0)
				{
				}
				num = (short)1903820800;
				short num3 = num;
				this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.Min = value;
			}
		}

		// Token: 0x17001E7E RID: 7806
		// (get) Token: 0x06003B8A RID: 15242 RVA: 0x0037DE34 File Offset: 0x0037C034
		// (set) Token: 0x06003B8B RID: 15243 RVA: 0x0037DEE8 File Offset: 0x0037C0E8
		internal int RadWideLabtoolCertMgmtMotorolaSolutionsPKIPortMax
		{
			get
			{
				short num = (short)552009729;
				if (num != 0)
				{
				}
				num = (short)2003994360;
				short num2 = num;
				num = (short)683312888;
				switch (num2 == num)
				{
				}
				num = (short)1565655040;
				if (num != 0)
				{
				}
				num = (short)1277820928;
				short num3 = num;
				return this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.Max;
			}
			set
			{
				short num = (short)276234241;
				if (num != 0)
				{
				}
				num = (short)299575465;
				short num2 = num;
				num = (short)65808553;
				switch (num2 == num)
				{
				}
				num = (short)1778712576;
				if (num != 0)
				{
				}
				num = (short)702611456;
				short num3 = num;
				this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.Max = value;
			}
		}

		// Token: 0x17001E7F RID: 7807
		// (get) Token: 0x06003B8C RID: 15244 RVA: 0x0037DFA0 File Offset: 0x0037C1A0
		// (set) Token: 0x06003B8D RID: 15245 RVA: 0x0037E054 File Offset: 0x0037C254
		internal int RadWideLabtoolCertMgmtMotorolaSolutionsPKIPortStep
		{
			get
			{
				short num = (short)221602627;
				short num2 = num;
				num = (short)332096323;
				switch (num2 == num)
				{
				}
				num = (short)1223622657;
				if (num != 0)
				{
				}
				num = (short)1402470400;
				if (num != 0)
				{
				}
				num = (short)1203634176;
				short num3 = num;
				return this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.StepSize;
			}
			set
			{
				short num = (short)509537420;
				short num2 = num;
				num = (short)1183116428;
				switch (num2 == num)
				{
				}
				num = (short)1195573249;
				if (num != 0)
				{
				}
				num = (short)1798176768;
				if (num != 0)
				{
				}
				num = (short)1613037568;
				short num3 = num;
				this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.StepSize = value;
			}
		}

		// Token: 0x17001E80 RID: 7808
		// (get) Token: 0x06003B8E RID: 15246 RVA: 0x0037E10C File Offset: 0x0037C30C
		// (set) Token: 0x06003B8F RID: 15247 RVA: 0x0037E1C0 File Offset: 0x0037C3C0
		public bool RadWideLabtoolCertMgmtMotorolaSolutionsPKIPort_Applicable
		{
			get
			{
				short num = (short)1153036540;
				short num2 = num;
				num = (short)105050364;
				switch (num2 == num)
				{
				}
				num = (short)1967652865;
				if (num != 0)
				{
				}
				num = (short)1353908224;
				if (num != 0)
				{
				}
				num = (short)1280442368;
				short num3 = num;
				return this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.Applicable;
			}
			set
			{
				short num = (short)300448688;
				short num2 = num;
				num = (short)1103788976;
				switch (num2 == num)
				{
				default:
				{
					num = (short)66060288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1133182977;
				if (num != 0)
				{
				}
				num = (short)1175781376;
				if (num != 0)
				{
				}
				this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.Applicable = value;
			}
		}

		// Token: 0x17001E81 RID: 7809
		// (get) Token: 0x06003B90 RID: 15248 RVA: 0x0037E274 File Offset: 0x0037C474
		// (set) Token: 0x06003B91 RID: 15249 RVA: 0x0037E324 File Offset: 0x0037C524
		public bool RadWideLabtoolCertMgmtMotorolaSolutionsPKIPort_Valid
		{
			get
			{
				short num = (short)180184058;
				short num2 = num;
				num = (short)738223098;
				switch (num2 == num)
				{
				default:
				{
					num = (short)476708864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1396572161;
				if (num != 0)
				{
				}
				num = (short)1697775616;
				if (num != 0)
				{
				}
				return this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.Valid;
			}
			set
			{
				short num = (short)170655745;
				if (num != 0)
				{
				}
				num = (short)2118123520;
				short num2 = num;
				num = (short)320489000;
				short num3 = num;
				num = (short)1767065128;
				switch (num3 == num)
				{
				}
				num = (short)1390936064;
				if (num != 0)
				{
				}
				this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.Valid = value;
			}
		}

		// Token: 0x17001E82 RID: 7810
		// (get) Token: 0x06003B92 RID: 15250 RVA: 0x0037E3DC File Offset: 0x0037C5DC
		// (set) Token: 0x06003B93 RID: 15251 RVA: 0x0037E490 File Offset: 0x0037C690
		public bool RadWideLabtoolCertMgmtMotorolaSolutionsPKIPort_Visible
		{
			get
			{
				short num = (short)1569193985;
				if (num != 0)
				{
				}
				num = (short)1357578240;
				short num2 = num;
				num = (short)1646066249;
				short num3 = num;
				num = (short)1770519113;
				switch (num3 == num)
				{
				}
				num = (short)1198391296;
				if (num != 0)
				{
				}
				return this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.Visible;
			}
			set
			{
				short num = (short)739597494;
				short num2 = num;
				num = (short)405691574;
				switch (num2 == num)
				{
				default:
				{
					num = (short)304218112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)26476545;
				if (num != 0)
				{
				}
				num = (short)989003776;
				if (num != 0)
				{
				}
				this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.Visible = value;
			}
		}

		// Token: 0x17001E83 RID: 7811
		// (get) Token: 0x06003B94 RID: 15252 RVA: 0x0037E544 File Offset: 0x0037C744
		// (set) Token: 0x06003B95 RID: 15253 RVA: 0x0037E5F8 File Offset: 0x0037C7F8
		public bool RadWideLabtoolCertMgmtMotorolaSolutionsPKIPort_Editable
		{
			get
			{
				short num = (short)1370923999;
				short num2 = num;
				num = (short)610771935;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1827143680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2058944512;
				if (num != 0)
				{
				}
				num = (short)236781569;
				if (num != 0)
				{
				}
				return this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.Editable;
			}
			set
			{
				short num = (short)1713019788;
				short num2 = num;
				num = (short)1165663116;
				switch (num2 == num)
				{
				default:
				{
					num = (short)288751616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1545863169;
				if (num != 0)
				{
				}
				num = (short)1708654592;
				if (num != 0)
				{
				}
				this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.Editable = value;
			}
		}

		// Token: 0x17001E84 RID: 7812
		// (get) Token: 0x06003B96 RID: 15254 RVA: 0x0037E6AC File Offset: 0x0037C8AC
		internal string RadWideLabtoolCertMgmtMotorolaSolutionsPKIPort_UILabel
		{
			get
			{
				short num = (short)2107682955;
				short num2 = num;
				num = (short)1469755531;
				switch (num2 == num)
				{
				default:
				{
					num = (short)251002880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)190447617;
				if (num != 0)
				{
				}
				num = (short)1779367936;
				if (num != 0)
				{
				}
				return this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.UIName;
			}
		}

		// Token: 0x17001E85 RID: 7813
		// (get) Token: 0x06003B97 RID: 15255 RVA: 0x0037E764 File Offset: 0x0037C964
		// (set) Token: 0x06003B98 RID: 15256 RVA: 0x0037E818 File Offset: 0x0037CA18
		internal bool RadWideLabtoolCertMgmtMotorolaSolutionsPKIPort_HiddenStatic
		{
			get
			{
				short num = (short)1762926483;
				short num2 = num;
				num = (short)536551315;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1107492864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)430899200;
				if (num != 0)
				{
				}
				num = (short)1346371585;
				if (num != 0)
				{
				}
				return this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.HiddenStatic;
			}
			set
			{
				short num = (short)2110128129;
				if (num != 0)
				{
				}
				num = (short)195166208;
				short num2 = num;
				num = (short)376446487;
				short num3 = num;
				num = (short)823860759;
				switch (num3 == num)
				{
				}
				num = (short)324730880;
				if (num != 0)
				{
				}
				this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.HiddenStatic = value;
			}
		}

		// Token: 0x17001E86 RID: 7814
		// (get) Token: 0x06003B99 RID: 15257 RVA: 0x0037E8D0 File Offset: 0x0037CAD0
		// (set) Token: 0x06003B9A RID: 15258 RVA: 0x0037E984 File Offset: 0x0037CB84
		internal bool RadWideLabtoolCertMgmtMotorolaSolutionsPKIPort_HiddenDynamic
		{
			get
			{
				short num = (short)484291900;
				short num2 = num;
				num = (short)1414837564;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1223098368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2060648449;
				if (num != 0)
				{
				}
				num = (short)139984896;
				if (num != 0)
				{
				}
				return this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.HiddenDynamic;
			}
			set
			{
				short num = (short)544891551;
				short num2 = num;
				num = (short)1496081055;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1000210432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)536805377;
				if (num != 0)
				{
				}
				num = (short)1870200832;
				if (num != 0)
				{
				}
				this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort.HiddenDynamic = value;
			}
		}

		// Token: 0x17001E87 RID: 7815
		// (get) Token: 0x06003B9B RID: 15259 RVA: 0x0037EA3C File Offset: 0x0037CC3C
		public bool RadWideLabtoolCertMgmtMotorolaSolutionsPKIPort_HasDiffs
		{
			get
			{
				short num = (short)1785397249;
				if (num != 0)
				{
				}
				num = (short)1480458240;
				short num2 = num;
				num = (short)957839421;
				short num3 = num;
				num = (short)1303738429;
				switch (num3 == num)
				{
				}
				num = (short)789315584;
				if (num != 0)
				{
				}
				return this.radWideLabtoolCertMgmtMotorolaSolutionsPKIPort._HasDiffs;
			}
		}

		// Token: 0x17001E88 RID: 7816
		// (get) Token: 0x06003B9C RID: 15260 RVA: 0x0037EAF0 File Offset: 0x0037CCF0
		// (set) Token: 0x06003B9D RID: 15261 RVA: 0x0037EBA4 File Offset: 0x0037CDA4
		public string RadWideLabtoolCertMgmtMotorolaSolutionsPKIHostnameValue
		{
			get
			{
				short num = (short)206206352;
				short num2 = num;
				num = (short)515995024;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1872297984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1192755201;
				if (num != 0)
				{
				}
				num = (short)1337851904;
				if (num != 0)
				{
				}
				return this.radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname.Value;
			}
			set
			{
				short num = (short)584706541;
				short num2 = num;
				num = (short)743893485;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1323696128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)288096256;
				if (num != 0)
				{
				}
				num = (short)691404801;
				if (num != 0)
				{
				}
				this.radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname.Value = value;
			}
		}

		// Token: 0x17001E89 RID: 7817
		// (get) Token: 0x06003B9E RID: 15262 RVA: 0x0037EC5C File Offset: 0x0037CE5C
		// (set) Token: 0x06003B9F RID: 15263 RVA: 0x0037ED10 File Offset: 0x0037CF10
		public string RadWideLabtoolCertMgmtMotorolaSolutionsPKIHostname_UIValue
		{
			get
			{
				short num = (short)630390785;
				if (num != 0)
				{
				}
				num = (short)313720832;
				short num2 = num;
				num = (short)778954493;
				short num3 = num;
				num = (short)336062205;
				switch (num3 == num)
				{
				}
				num = (short)1873543168;
				if (num != 0)
				{
				}
				return this.radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname.Value;
			}
			set
			{
				short num = (short)530803758;
				short num2 = num;
				num = (short)2074766382;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1217200128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)717357056;
				if (num != 0)
				{
				}
				num = (short)1418592257;
				if (num != 0)
				{
				}
				this.radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname.Value = value;
			}
		}

		// Token: 0x17001E8A RID: 7818
		// (get) Token: 0x06003BA0 RID: 15264 RVA: 0x0037EDC4 File Offset: 0x0037CFC4
		public global::AcpBusinessLayer.AcpStringField RadWideLabtoolCertMgmtMotorolaSolutionsPKIHostname
		{
			get
			{
				short num = (short)22991289;
				short num2 = num;
				num = (short)1372639673;
				switch (num2 == num)
				{
				default:
				{
					num = (short)270991360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)310181889;
				if (num != 0)
				{
				}
				num = (short)2051932160;
				if (num != 0)
				{
				}
				return this.radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname;
			}
		}

		// Token: 0x17001E8B RID: 7819
		// (get) Token: 0x06003BA1 RID: 15265 RVA: 0x0037EE74 File Offset: 0x0037D074
		// (set) Token: 0x06003BA2 RID: 15266 RVA: 0x0037EF28 File Offset: 0x0037D128
		public bool RadWideLabtoolCertMgmtMotorolaSolutionsPKIHostname_Applicable
		{
			get
			{
				short num = (short)1508854400;
				short num2 = num;
				num = (short)1134840448;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2146828288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)602734593;
				if (num != 0)
				{
				}
				num = (short)1578893312;
				if (num != 0)
				{
				}
				return this.radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname.Applicable;
			}
			set
			{
				short num = (short)2083894349;
				short num2 = num;
				num = (short)1245033549;
				switch (num2 == num)
				{
				default:
				{
					num = (short)199360512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)51773441;
				if (num != 0)
				{
				}
				num = (short)1451622400;
				if (num != 0)
				{
				}
				this.radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname.Applicable = value;
			}
		}

		// Token: 0x17001E8C RID: 7820
		// (get) Token: 0x06003BA3 RID: 15267 RVA: 0x0037EFDC File Offset: 0x0037D1DC
		// (set) Token: 0x06003BA4 RID: 15268 RVA: 0x0037F090 File Offset: 0x0037D290
		public bool RadWideLabtoolCertMgmtMotorolaSolutionsPKIHostname_Valid
		{
			get
			{
				short num = (short)1214308895;
				short num2 = num;
				num = (short)1146020383;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1008140288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1599471617;
				if (num != 0)
				{
				}
				num = (short)352714752;
				if (num != 0)
				{
				}
				return this.radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname.Valid;
			}
			set
			{
				short num = (short)484092662;
				short num2 = num;
				num = (short)306293494;
				switch (num2 == num)
				{
				default:
				{
					num = (short)956301312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)63504384;
				if (num != 0)
				{
				}
				num = (short)1152647169;
				if (num != 0)
				{
				}
				this.radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname.Valid = value;
			}
		}

		// Token: 0x17001E8D RID: 7821
		// (get) Token: 0x06003BA5 RID: 15269 RVA: 0x0037F148 File Offset: 0x0037D348
		// (set) Token: 0x06003BA6 RID: 15270 RVA: 0x0037F200 File Offset: 0x0037D400
		public bool RadWideLabtoolCertMgmtMotorolaSolutionsPKIHostname_Visible
		{
			get
			{
				short num = (short)395799109;
				short num2 = num;
				num = (short)573991493;
				switch (num2 == num)
				{
				default:
				{
					num = (short)366215168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)144244737;
				if (num != 0)
				{
				}
				num = (short)1731592192;
				if (num != 0)
				{
				}
				return this.radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname.Visible;
			}
			set
			{
				short num = (short)1531444262;
				short num2 = num;
				num = (short)401669158;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1428946944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1799487488;
				if (num != 0)
				{
				}
				num = (short)1638268929;
				if (num != 0)
				{
				}
				this.radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname.Visible = value;
			}
		}

		// Token: 0x17001E8E RID: 7822
		// (get) Token: 0x06003BA7 RID: 15271 RVA: 0x0037F2B4 File Offset: 0x0037D4B4
		// (set) Token: 0x06003BA8 RID: 15272 RVA: 0x0037F36C File Offset: 0x0037D56C
		public bool RadWideLabtoolCertMgmtMotorolaSolutionsPKIHostname_Editable
		{
			get
			{
				short num = (short)302758986;
				short num2 = num;
				num = (short)1415560266;
				switch (num2 == num)
				{
				default:
				{
					num = (short)679542784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)743505921;
				if (num != 0)
				{
				}
				num = (short)446365696;
				if (num != 0)
				{
				}
				return this.radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname.Editable;
			}
			set
			{
				short num = (short)1853649871;
				short num2 = num;
				num = (short)1814000591;
				switch (num2 == num)
				{
				default:
				{
					num = (short)605945856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1641676801;
				if (num != 0)
				{
				}
				num = (short)1301020672;
				if (num != 0)
				{
				}
				this.radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname.Editable = value;
			}
		}

		// Token: 0x17001E8F RID: 7823
		// (get) Token: 0x06003BA9 RID: 15273 RVA: 0x0037F424 File Offset: 0x0037D624
		internal string RadWideLabtoolCertMgmtMotorolaSolutionsPKIHostname_UILabel
		{
			get
			{
				short num = (short)989572136;
				short num2 = num;
				num = (short)154446888;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1530724352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1082589184;
				if (num != 0)
				{
				}
				num = (short)117374977;
				if (num != 0)
				{
				}
				return this.radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname.UIName;
			}
		}

		// Token: 0x17001E90 RID: 7824
		// (get) Token: 0x06003BAA RID: 15274 RVA: 0x0037F4D8 File Offset: 0x0037D6D8
		// (set) Token: 0x06003BAB RID: 15275 RVA: 0x0037F588 File Offset: 0x0037D788
		internal bool RadWideLabtoolCertMgmtMotorolaSolutionsPKIHostname_HiddenStatic
		{
			get
			{
				short num = (short)446945978;
				short num2 = num;
				num = (short)703978170;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1611726848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1118044160;
				if (num != 0)
				{
				}
				num = (short)1736376321;
				if (num != 0)
				{
				}
				return this.radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname.HiddenStatic;
			}
			set
			{
				short num = (short)178757359;
				short num2 = num;
				num = (short)1672716015;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1412235264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1713569792;
				if (num != 0)
				{
				}
				num = (short)1907490817;
				if (num != 0)
				{
				}
				this.radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname.HiddenStatic = value;
			}
		}

		// Token: 0x17001E91 RID: 7825
		// (get) Token: 0x06003BAC RID: 15276 RVA: 0x0037F640 File Offset: 0x0037D840
		// (set) Token: 0x06003BAD RID: 15277 RVA: 0x0037F6F0 File Offset: 0x0037D8F0
		internal bool RadWideLabtoolCertMgmtMotorolaSolutionsPKIHostname_HiddenDynamic
		{
			get
			{
				short num = (short)265927653;
				short num2 = num;
				num = (short)394050533;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1175453696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1337982977;
				if (num != 0)
				{
				}
				num = (short)2102984704;
				if (num != 0)
				{
				}
				return this.radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname.HiddenDynamic;
			}
			set
			{
				short num = (short)210763777;
				if (num != 0)
				{
				}
				num = (short)897777664;
				short num2 = num;
				num = (short)1748790290;
				short num3 = num;
				num = (short)1072393234;
				switch (num3 == num)
				{
				}
				num = (short)912392192;
				if (num != 0)
				{
				}
				this.radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname.HiddenDynamic = value;
			}
		}

		// Token: 0x17001E92 RID: 7826
		// (get) Token: 0x06003BAE RID: 15278 RVA: 0x0037F7A8 File Offset: 0x0037D9A8
		public bool RadWideLabtoolCertMgmtMotorolaSolutionsPKIHostname_HasDiffs
		{
			get
			{
				short num = (short)1639102803;
				short num2 = num;
				num = (short)651278675;
				switch (num2 == num)
				{
				default:
				{
					num = (short)703004672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1194983425;
				if (num != 0)
				{
				}
				num = (short)1579876352;
				if (num != 0)
				{
				}
				return this.radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname._HasDiffs;
			}
		}

		// Token: 0x17001E93 RID: 7827
		// (get) Token: 0x06003BAF RID: 15279 RVA: 0x0037F85C File Offset: 0x0037DA5C
		// (set) Token: 0x06003BB0 RID: 15280 RVA: 0x0037F910 File Offset: 0x0037DB10
		public int RadWideLabtoolDeviceMgmtSeamlessUpdateRmPskIdValue
		{
			get
			{
				short num = (short)1522060179;
				short num2 = num;
				num = (short)1045875603;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1015545856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)689307648;
				if (num != 0)
				{
				}
				num = (short)119668737;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.Value;
			}
			set
			{
				short num = (short)157210116;
				short num2 = num;
				num = (short)1650054660;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1769865216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1281032192;
				if (num != 0)
				{
				}
				num = (short)1407778817;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.Value = value;
			}
		}

		// Token: 0x17001E94 RID: 7828
		// (get) Token: 0x06003BB1 RID: 15281 RVA: 0x0037F9C4 File Offset: 0x0037DBC4
		// (set) Token: 0x06003BB2 RID: 15282 RVA: 0x0037FA7C File Offset: 0x0037DC7C
		public int RadWideLabtoolDeviceMgmtSeamlessUpdateRmPskId_UIValue
		{
			get
			{
				short num = (short)1925535115;
				short num2 = num;
				num = (short)1381324171;
				switch (num2 == num)
				{
				default:
				{
					num = (short)516096000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)756482048;
				if (num != 0)
				{
				}
				num = (short)1153171457;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.Value;
			}
			set
			{
				short num = (short)1312985012;
				short num2 = num;
				num = (short)83857332;
				switch (num2 == num)
				{
				default:
				{
					num = (short)94371840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1655177217;
				if (num != 0)
				{
				}
				num = (short)1414594560;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.Value = value;
			}
		}

		// Token: 0x17001E95 RID: 7829
		// (get) Token: 0x06003BB3 RID: 15283 RVA: 0x0037FB30 File Offset: 0x0037DD30
		public global::AcpBusinessLayer.AcpSimpleRangeField RadWideLabtoolDeviceMgmtSeamlessUpdateRmPskId
		{
			get
			{
				short num = (short)865061097;
				short num2 = num;
				num = (short)200394985;
				switch (num2 == num)
				{
				default:
				{
					num = (short)561315840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1646788608;
				if (num != 0)
				{
				}
				num = (short)1974468609;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId;
			}
		}

		// Token: 0x17001E96 RID: 7830
		// (get) Token: 0x06003BB4 RID: 15284 RVA: 0x0037FBDC File Offset: 0x0037DDDC
		// (set) Token: 0x06003BB5 RID: 15285 RVA: 0x0037FC8C File Offset: 0x0037DE8C
		internal int RadWideLabtoolDeviceMgmtSeamlessUpdateRmPskIdMin
		{
			get
			{
				short num = (short)1382694434;
				short num2 = num;
				num = (short)1122713122;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1892286464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)214171648;
				if (num != 0)
				{
				}
				num = (short)1217658881;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.Min;
			}
			set
			{
				short num = (short)1257533503;
				short num2 = num;
				num = (short)1176334399;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1153040384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)267321345;
				if (num != 0)
				{
				}
				num = (short)981139456;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.Min = value;
			}
		}

		// Token: 0x17001E97 RID: 7831
		// (get) Token: 0x06003BB6 RID: 15286 RVA: 0x0037FD44 File Offset: 0x0037DF44
		// (set) Token: 0x06003BB7 RID: 15287 RVA: 0x0037FDFC File Offset: 0x0037DFFC
		internal int RadWideLabtoolDeviceMgmtSeamlessUpdateRmPskIdMax
		{
			get
			{
				short num = (short)1467567542;
				short num2 = num;
				num = (short)668093878;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1786642432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1222967297;
				if (num != 0)
				{
				}
				num = (short)2081292288;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.Max;
			}
			set
			{
				short num = (short)1349971996;
				short num2 = num;
				num = (short)236843036;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1921187840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1394212865;
				if (num != 0)
				{
				}
				num = (short)1913454592;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.Max = value;
			}
		}

		// Token: 0x17001E98 RID: 7832
		// (get) Token: 0x06003BB8 RID: 15288 RVA: 0x0037FEB4 File Offset: 0x0037E0B4
		// (set) Token: 0x06003BB9 RID: 15289 RVA: 0x0037FF68 File Offset: 0x0037E168
		internal int RadWideLabtoolDeviceMgmtSeamlessUpdateRmPskIdStep
		{
			get
			{
				short num = (short)1797735414;
				short num2 = num;
				num = (short)161694710;
				switch (num2 == num)
				{
				default:
				{
					num = (short)779681792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2016346113;
				if (num != 0)
				{
				}
				num = (short)937689088;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.StepSize;
			}
			set
			{
				short num = (short)1683489315;
				short num2 = num;
				num = (short)477037091;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1152450560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)892862465;
				if (num != 0)
				{
				}
				num = (short)1165295616;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.StepSize = value;
			}
		}

		// Token: 0x17001E99 RID: 7833
		// (get) Token: 0x06003BBA RID: 15290 RVA: 0x0038001C File Offset: 0x0037E21C
		// (set) Token: 0x06003BBB RID: 15291 RVA: 0x003800D0 File Offset: 0x0037E2D0
		public bool RadWideLabtoolDeviceMgmtSeamlessUpdateRmPskId_Applicable
		{
			get
			{
				short num = (short)385646357;
				short num2 = num;
				num = (short)1201700629;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1896808448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1183121409;
				if (num != 0)
				{
				}
				num = (short)524877824;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.Applicable;
			}
			set
			{
				short num = (short)199553352;
				short num2 = num;
				num = (short)1687679304;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1624309760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1786052608;
				if (num != 0)
				{
				}
				num = (short)1066270721;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.Applicable = value;
			}
		}

		// Token: 0x17001E9A RID: 7834
		// (get) Token: 0x06003BBC RID: 15292 RVA: 0x0038018C File Offset: 0x0037E38C
		// (set) Token: 0x06003BBD RID: 15293 RVA: 0x00380240 File Offset: 0x0037E440
		public bool RadWideLabtoolDeviceMgmtSeamlessUpdateRmPskId_Valid
		{
			get
			{
				short num = (short)1630666753;
				if (num != 0)
				{
				}
				num = (short)966459392;
				short num2 = num;
				num = (short)1707628728;
				short num3 = num;
				num = (short)876566712;
				switch (num3 == num)
				{
				}
				num = (short)1180762112;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.Valid;
			}
			set
			{
				short num = (short)760568249;
				short num2 = num;
				num = (short)172644793;
				switch (num2 == num)
				{
				default:
				{
					num = (short)963641344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1397817344;
				if (num != 0)
				{
				}
				num = (short)813629441;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.Valid = value;
			}
		}

		// Token: 0x17001E9B RID: 7835
		// (get) Token: 0x06003BBE RID: 15294 RVA: 0x003802F8 File Offset: 0x0037E4F8
		// (set) Token: 0x06003BBF RID: 15295 RVA: 0x003803B0 File Offset: 0x0037E5B0
		public bool RadWideLabtoolDeviceMgmtSeamlessUpdateRmPskId_Visible
		{
			get
			{
				short num = (short)899678209;
				if (num != 0)
				{
				}
				num = (short)1158414336;
				short num2 = num;
				num = (short)2014708930;
				short num3 = num;
				num = (short)1038156994;
				switch (num3 == num)
				{
				}
				num = (short)1670512640;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.Visible;
			}
			set
			{
				short num = (short)1378541747;
				short num2 = num;
				num = (short)56615091;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1469513728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1632043008;
				if (num != 0)
				{
				}
				num = (short)229703681;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.Visible = value;
			}
		}

		// Token: 0x17001E9C RID: 7836
		// (get) Token: 0x06003BC0 RID: 15296 RVA: 0x0038046C File Offset: 0x0037E66C
		// (set) Token: 0x06003BC1 RID: 15297 RVA: 0x00380520 File Offset: 0x0037E720
		public bool RadWideLabtoolDeviceMgmtSeamlessUpdateRmPskId_Editable
		{
			get
			{
				short num = (short)1123497450;
				short num2 = num;
				num = (short)157890026;
				switch (num2 == num)
				{
				default:
				{
					num = (short)947257344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)274595841;
				if (num != 0)
				{
				}
				num = (short)421330944;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.Editable;
			}
			set
			{
				short num = (short)1762590721;
				if (num != 0)
				{
				}
				num = (short)1810497536;
				short num2 = num;
				num = (short)1987844810;
				short num3 = num;
				num = (short)1630345930;
				switch (num3 == num)
				{
				}
				num = (short)220200960;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.Editable = value;
			}
		}

		// Token: 0x17001E9D RID: 7837
		// (get) Token: 0x06003BC2 RID: 15298 RVA: 0x003805D8 File Offset: 0x0037E7D8
		internal string RadWideLabtoolDeviceMgmtSeamlessUpdateRmPskId_UILabel
		{
			get
			{
				short num = (short)1898862319;
				short num2 = num;
				num = (short)2065323759;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1566769152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1694892033;
				if (num != 0)
				{
				}
				num = (short)470417408;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.UIName;
			}
		}

		// Token: 0x17001E9E RID: 7838
		// (get) Token: 0x06003BC3 RID: 15299 RVA: 0x0038068C File Offset: 0x0037E88C
		// (set) Token: 0x06003BC4 RID: 15300 RVA: 0x00380740 File Offset: 0x0037E940
		internal bool RadWideLabtoolDeviceMgmtSeamlessUpdateRmPskId_HiddenStatic
		{
			get
			{
				short num = (short)2143033538;
				short num2 = num;
				num = (short)900077762;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1933312000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1764818945;
				if (num != 0)
				{
				}
				num = (short)55902208;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.HiddenStatic;
			}
			set
			{
				short num = (short)1869690943;
				short num2 = num;
				num = (short)1038235711;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1802829824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)500367360;
				if (num != 0)
				{
				}
				num = (short)1599209473;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.HiddenStatic = value;
			}
		}

		// Token: 0x17001E9F RID: 7839
		// (get) Token: 0x06003BC5 RID: 15301 RVA: 0x003807F8 File Offset: 0x0037E9F8
		// (set) Token: 0x06003BC6 RID: 15302 RVA: 0x003808A8 File Offset: 0x0037EAA8
		internal bool RadWideLabtoolDeviceMgmtSeamlessUpdateRmPskId_HiddenDynamic
		{
			get
			{
				short num = (short)901513216;
				short num2 = num;
				num = (short)216600284;
				short num3 = num;
				num = (short)2035289820;
				switch (num3 == num)
				{
				}
				num = (short)893517824;
				if (num != 0)
				{
				}
				num = (short)750256129;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.HiddenDynamic;
			}
			set
			{
				short num = (short)1554972672;
				short num2 = num;
				num = (short)1911541946;
				short num3 = num;
				num = (short)573100218;
				switch (num3 == num)
				{
				}
				num = (short)1237975041;
				if (num != 0)
				{
				}
				num = (short)777125888;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.HiddenDynamic = value;
			}
		}

		// Token: 0x17001EA0 RID: 7840
		// (get) Token: 0x06003BC7 RID: 15303 RVA: 0x0038095C File Offset: 0x0037EB5C
		public bool RadWideLabtoolDeviceMgmtSeamlessUpdateRmPskId_HasDiffs
		{
			get
			{
				short num = (short)112394240;
				short num2 = num;
				num = (short)2139879861;
				short num3 = num;
				num = (short)1268185525;
				switch (num3 == num)
				{
				}
				num = (short)26542081;
				if (num != 0)
				{
				}
				num = (short)321519616;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId._HasDiffs;
			}
		}

		// Token: 0x17001EA1 RID: 7841
		// (get) Token: 0x06003BC8 RID: 15304 RVA: 0x00380A14 File Offset: 0x0037EC14
		// (set) Token: 0x06003BC9 RID: 15305 RVA: 0x00380AC4 File Offset: 0x0037ECC4
		public string RadWideLabtoolDeviceMgmtSeamlessUpdateRmPskValue
		{
			get
			{
				short num = (short)1329790976;
				short num2 = num;
				num = (short)979632129;
				if (num != 0)
				{
				}
				num = (short)239880706;
				short num3 = num;
				num = (short)720914946;
				switch (num3 == num)
				{
				}
				num = (short)1007288320;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk.Value;
			}
			set
			{
				short num = (short)1363410944;
				short num2 = num;
				num = (short)1562590718;
				short num3 = num;
				num = (short)268320254;
				switch (num3 == num)
				{
				}
				num = (short)1267793920;
				if (num != 0)
				{
				}
				num = (short)1572012033;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk.Value = value;
			}
		}

		// Token: 0x17001EA2 RID: 7842
		// (get) Token: 0x06003BCA RID: 15306 RVA: 0x00380B7C File Offset: 0x0037ED7C
		// (set) Token: 0x06003BCB RID: 15307 RVA: 0x00380C30 File Offset: 0x0037EE30
		public string RadWideLabtoolDeviceMgmtSeamlessUpdateRmPsk_UIValue
		{
			get
			{
				short num = (short)1514668032;
				short num2 = num;
				num = (short)712960231;
				short num3 = num;
				num = (short)1391454439;
				switch (num3 == num)
				{
				}
				num = (short)1617756160;
				if (num != 0)
				{
				}
				num = (short)615645185;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk.Value;
			}
			set
			{
				short num = (short)1851064320;
				short num2 = num;
				num = (short)1695283126;
				short num3 = num;
				num = (short)1955723190;
				switch (num3 == num)
				{
				}
				num = (short)893845504;
				if (num != 0)
				{
				}
				num = (short)958595073;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk.Value = value;
			}
		}

		// Token: 0x17001EA3 RID: 7843
		// (get) Token: 0x06003BCC RID: 15308 RVA: 0x00380CE8 File Offset: 0x0037EEE8
		public global::AcpBusinessLayer.AcpStringField RadWideLabtoolDeviceMgmtSeamlessUpdateRmPsk
		{
			get
			{
				short num = (short)140771328;
				short num2 = num;
				num = (short)162971858;
				short num3 = num;
				num = (short)1043448018;
				switch (num3 == num)
				{
				}
				num = (short)814219265;
				if (num != 0)
				{
				}
				num = (short)1374093312;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk;
			}
		}

		// Token: 0x17001EA4 RID: 7844
		// (get) Token: 0x06003BCD RID: 15309 RVA: 0x00380D94 File Offset: 0x0037EF94
		// (set) Token: 0x06003BCE RID: 15310 RVA: 0x00380E48 File Offset: 0x0037F048
		public bool RadWideLabtoolDeviceMgmtSeamlessUpdateRmPsk_Applicable
		{
			get
			{
				short num = (short)946208768;
				short num2 = num;
				num = (short)813437339;
				short num3 = num;
				num = (short)1058279835;
				switch (num3 == num)
				{
				}
				num = (short)1572405249;
				if (num != 0)
				{
				}
				num = (short)2063663104;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk.Applicable;
			}
			set
			{
				short num = (short)1386020864;
				short num2 = num;
				num = (short)234054574;
				short num3 = num;
				num = (short)778003374;
				switch (num3 == num)
				{
				}
				num = (short)1668612097;
				if (num != 0)
				{
				}
				num = (short)147259392;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk.Applicable = value;
			}
		}

		// Token: 0x17001EA5 RID: 7845
		// (get) Token: 0x06003BCF RID: 15311 RVA: 0x00380EFC File Offset: 0x0037F0FC
		// (set) Token: 0x06003BD0 RID: 15312 RVA: 0x00380FB0 File Offset: 0x0037F1B0
		public bool RadWideLabtoolDeviceMgmtSeamlessUpdateRmPsk_Valid
		{
			get
			{
				short num = (short)1721237504;
				short num2 = num;
				num = (short)202244097;
				if (num != 0)
				{
				}
				num = (short)502051332;
				short num3 = num;
				num = (short)2042475012;
				switch (num3 == num)
				{
				}
				num = (short)568918016;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk.Valid;
			}
			set
			{
				short num = (short)435814400;
				short num2 = num;
				num = (short)2033253353;
				short num3 = num;
				num = (short)1921514473;
				switch (num3 == num)
				{
				}
				num = (short)532873216;
				if (num != 0)
				{
				}
				num = (short)2124349441;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk.Valid = value;
			}
		}

		// Token: 0x17001EA6 RID: 7846
		// (get) Token: 0x06003BD1 RID: 15313 RVA: 0x00381068 File Offset: 0x0037F268
		// (set) Token: 0x06003BD2 RID: 15314 RVA: 0x0038111C File Offset: 0x0037F31C
		public bool RadWideLabtoolDeviceMgmtSeamlessUpdateRmPsk_Visible
		{
			get
			{
				short num = (short)807010304;
				short num2 = num;
				num = (short)1348048651;
				short num3 = num;
				num = (short)143562507;
				switch (num3 == num)
				{
				}
				num = (short)1143209985;
				if (num != 0)
				{
				}
				num = (short)1503133696;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk.Visible;
			}
			set
			{
				short num = (short)1415643136;
				short num2 = num;
				num = (short)1774690872;
				short num3 = num;
				num = (short)1955504696;
				switch (num3 == num)
				{
				}
				num = (short)1859649537;
				if (num != 0)
				{
				}
				num = (short)399769600;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk.Visible = value;
			}
		}

		// Token: 0x17001EA7 RID: 7847
		// (get) Token: 0x06003BD3 RID: 15315 RVA: 0x003811D0 File Offset: 0x0037F3D0
		// (set) Token: 0x06003BD4 RID: 15316 RVA: 0x00381288 File Offset: 0x0037F488
		public bool RadWideLabtoolDeviceMgmtSeamlessUpdateRmPsk_Editable
		{
			get
			{
				short num = (short)143458304;
				short num2 = num;
				num = (short)2082414596;
				short num3 = num;
				num = (short)1984241668;
				switch (num3 == num)
				{
				}
				num = (short)2114846721;
				if (num != 0)
				{
				}
				num = (short)1344339968;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk.Editable;
			}
			set
			{
				short num = (short)1925971968;
				short num2 = num;
				num = (short)493902392;
				short num3 = num;
				num = (short)675371576;
				switch (num3 == num)
				{
				}
				num = (short)89653249;
				if (num != 0)
				{
				}
				num = (short)498139136;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk.Editable = value;
			}
		}

		// Token: 0x17001EA8 RID: 7848
		// (get) Token: 0x06003BD5 RID: 15317 RVA: 0x0038133C File Offset: 0x0037F53C
		internal string RadWideLabtoolDeviceMgmtSeamlessUpdateRmPsk_UILabel
		{
			get
			{
				short num = (short)914948096;
				short num2 = num;
				num = (short)227089939;
				short num3 = num;
				num = (short)159456787;
				switch (num3 == num)
				{
				}
				num = (short)1130692609;
				if (num != 0)
				{
				}
				num = (short)1035534336;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk.UIName;
			}
		}

		// Token: 0x17001EA9 RID: 7849
		// (get) Token: 0x06003BD6 RID: 15318 RVA: 0x003813F4 File Offset: 0x0037F5F4
		// (set) Token: 0x06003BD7 RID: 15319 RVA: 0x003814AC File Offset: 0x0037F6AC
		internal bool RadWideLabtoolDeviceMgmtSeamlessUpdateRmPsk_HiddenStatic
		{
			get
			{
				short num = (short)1591869440;
				short num2 = num;
				num = (short)1588985857;
				if (num != 0)
				{
				}
				num = (short)1322855948;
				short num3 = num;
				num = (short)737685004;
				switch (num3 == num)
				{
				}
				num = (short)237961216;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk.HiddenStatic;
			}
			set
			{
				short num = (short)1573453824;
				short num2 = num;
				num = (short)1451057530;
				short num3 = num;
				num = (short)668295546;
				switch (num3 == num)
				{
				}
				num = (short)1238302721;
				if (num != 0)
				{
				}
				num = (short)814546944;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk.HiddenStatic = value;
			}
		}

		// Token: 0x17001EAA RID: 7850
		// (get) Token: 0x06003BD8 RID: 15320 RVA: 0x00381564 File Offset: 0x0037F764
		// (set) Token: 0x06003BD9 RID: 15321 RVA: 0x00381618 File Offset: 0x0037F818
		internal bool RadWideLabtoolDeviceMgmtSeamlessUpdateRmPsk_HiddenDynamic
		{
			get
			{
				short num = (short)1944911872;
				short num2 = num;
				num = (short)221838538;
				short num3 = num;
				num = (short)2119498954;
				switch (num3 == num)
				{
				}
				num = (short)1618214913;
				if (num != 0)
				{
				}
				num = (short)344522752;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk.HiddenDynamic;
			}
			set
			{
				short num = (short)1712586752;
				short num2 = num;
				num = (short)1058144257;
				if (num != 0)
				{
				}
				num = (short)62964784;
				short num3 = num;
				num = (short)1948042288;
				switch (num3 == num)
				{
				}
				num = (short)1535770624;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk.HiddenDynamic = value;
			}
		}

		// Token: 0x17001EAB RID: 7851
		// (get) Token: 0x06003BDA RID: 15322 RVA: 0x003816D0 File Offset: 0x0037F8D0
		public bool RadWideLabtoolDeviceMgmtSeamlessUpdateRmPsk_HasDiffs
		{
			get
			{
				short num = (short)801243136;
				short num2 = num;
				num = (short)220438056;
				short num3 = num;
				num = (short)1372036648;
				switch (num3 == num)
				{
				}
				num = (short)1090650112;
				if (num != 0)
				{
				}
				num = (short)1610153985;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk._HasDiffs;
			}
		}

		// Token: 0x17001EAC RID: 7852
		// (get) Token: 0x06003BDB RID: 15323 RVA: 0x00381784 File Offset: 0x0037F984
		// (set) Token: 0x06003BDC RID: 15324 RVA: 0x00381838 File Offset: 0x0037FA38
		public string RadWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostnameValue
		{
			get
			{
				short num = (short)1763901440;
				short num2 = num;
				num = (short)1928308946;
				short num3 = num;
				num = (short)508537042;
				switch (num3 == num)
				{
				}
				num = (short)879362049;
				if (num != 0)
				{
				}
				num = (short)1464926208;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname.Value;
			}
			set
			{
				short num = (short)1687814144;
				short num2 = num;
				num = (short)612428591;
				short num3 = num;
				num = (short)152103727;
				switch (num3 == num)
				{
				}
				num = (short)1783169025;
				if (num != 0)
				{
				}
				num = (short)1750728704;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname.Value = value;
			}
		}

		// Token: 0x17001EAD RID: 7853
		// (get) Token: 0x06003BDD RID: 15325 RVA: 0x003818EC File Offset: 0x0037FAEC
		// (set) Token: 0x06003BDE RID: 15326 RVA: 0x003819A0 File Offset: 0x0037FBA0
		public string RadWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname_UIValue
		{
			get
			{
				short num = (short)73596928;
				short num2 = num;
				num = (short)60030977;
				if (num != 0)
				{
				}
				num = (short)1710885598;
				short num3 = num;
				num = (short)2015496926;
				switch (num3 == num)
				{
				}
				num = (short)1226637312;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname.Value;
			}
			set
			{
				short num = (short)840892416;
				short num2 = num;
				num = (short)1394041746;
				short num3 = num;
				num = (short)1316643730;
				switch (num3 == num)
				{
				}
				num = (short)1842872321;
				if (num != 0)
				{
				}
				num = (short)561250304;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname.Value = value;
			}
		}

		// Token: 0x17001EAE RID: 7854
		// (get) Token: 0x06003BDF RID: 15327 RVA: 0x00381A58 File Offset: 0x0037FC58
		public global::AcpBusinessLayer.AcpStringField RadWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname
		{
			get
			{
				short num = (short)431947776;
				short num2 = num;
				num = (short)1298930197;
				short num3 = num;
				num = (short)870193685;
				switch (num3 == num)
				{
				}
				num = (short)1435697153;
				if (num != 0)
				{
				}
				num = (short)1810169856;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname;
			}
		}

		// Token: 0x17001EAF RID: 7855
		// (get) Token: 0x06003BE0 RID: 15328 RVA: 0x00381B08 File Offset: 0x0037FD08
		// (set) Token: 0x06003BE1 RID: 15329 RVA: 0x00381BBC File Offset: 0x0037FDBC
		public bool RadWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname_Applicable
		{
			get
			{
				short num = (short)1698234368;
				short num2 = num;
				num = (short)503949157;
				short num3 = num;
				num = (short)1220978533;
				switch (num3 == num)
				{
				}
				num = (short)999030784;
				if (num != 0)
				{
				}
				num = (short)349110273;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname.Applicable;
			}
			set
			{
				short num = (short)1619394560;
				short num2 = num;
				num = (short)708311558;
				short num3 = num;
				num = (short)1973746182;
				switch (num3 == num)
				{
				}
				num = (short)348389376;
				if (num != 0)
				{
				}
				num = (short)23134209;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname.Applicable = value;
			}
		}

		// Token: 0x17001EB0 RID: 7856
		// (get) Token: 0x06003BE2 RID: 15330 RVA: 0x00381C74 File Offset: 0x0037FE74
		// (set) Token: 0x06003BE3 RID: 15331 RVA: 0x00381D28 File Offset: 0x0037FF28
		public bool RadWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname_Valid
		{
			get
			{
				short num = (short)449576960;
				short num2 = num;
				num = (short)1374578949;
				short num3 = num;
				num = (short)412576005;
				switch (num3 == num)
				{
				}
				num = (short)1108475905;
				if (num != 0)
				{
				}
				num = (short)794296320;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname.Valid;
			}
			set
			{
				short num = (short)819527680;
				short num2 = num;
				num = (short)1103536410;
				short num3 = num;
				num = (short)1493410074;
				switch (num3 == num)
				{
				}
				num = (short)1379729409;
				if (num != 0)
				{
				}
				num = (short)1461190656;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname.Valid = value;
			}
		}

		// Token: 0x17001EB1 RID: 7857
		// (get) Token: 0x06003BE4 RID: 15332 RVA: 0x00381DDC File Offset: 0x0037FFDC
		// (set) Token: 0x06003BE5 RID: 15333 RVA: 0x00381E90 File Offset: 0x00380090
		public bool RadWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname_Visible
		{
			get
			{
				short num = (short)1524105216;
				short num2 = num;
				num = (short)115021090;
				short num3 = num;
				num = (short)981144866;
				switch (num3 == num)
				{
				}
				num = (short)918880257;
				if (num != 0)
				{
				}
				num = (short)105512960;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname.Visible;
			}
			set
			{
				short num = (short)1850474496;
				short num2 = num;
				num = (short)2069274768;
				short num3 = num;
				num = (short)1712824464;
				switch (num3 == num)
				{
				}
				num = (short)1377959937;
				if (num != 0)
				{
				}
				num = (short)20840448;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname.Visible = value;
			}
		}

		// Token: 0x17001EB2 RID: 7858
		// (get) Token: 0x06003BE6 RID: 15334 RVA: 0x00381F44 File Offset: 0x00380144
		// (set) Token: 0x06003BE7 RID: 15335 RVA: 0x00381FF8 File Offset: 0x003801F8
		public bool RadWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname_Editable
		{
			get
			{
				short num = (short)26542080;
				short num2 = num;
				num = (short)1108644692;
				short num3 = num;
				num = (short)368153428;
				switch (num3 == num)
				{
				}
				num = (short)2005860352;
				if (num != 0)
				{
				}
				num = (short)1869414401;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname.Editable;
			}
			set
			{
				short num = (short)1595998208;
				short num2 = num;
				num = (short)1697185793;
				if (num != 0)
				{
				}
				num = (short)254330664;
				short num3 = num;
				num = (short)487704360;
				switch (num3 == num)
				{
				}
				num = (short)1725169664;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname.Editable = value;
			}
		}

		// Token: 0x17001EB3 RID: 7859
		// (get) Token: 0x06003BE8 RID: 15336 RVA: 0x003820AC File Offset: 0x003802AC
		internal string RadWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname_UILabel
		{
			get
			{
				short num = (short)502071296;
				short num2 = num;
				num = (short)704087249;
				short num3 = num;
				num = (short)1778615505;
				switch (num3 == num)
				{
				}
				num = (short)712179713;
				if (num != 0)
				{
				}
				num = (short)991494144;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname.UIName;
			}
		}

		// Token: 0x17001EB4 RID: 7860
		// (get) Token: 0x06003BE9 RID: 15337 RVA: 0x00382160 File Offset: 0x00380360
		// (set) Token: 0x06003BEA RID: 15338 RVA: 0x00382218 File Offset: 0x00380418
		internal bool RadWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname_HiddenStatic
		{
			get
			{
				short num = (short)1348861952;
				short num2 = num;
				num = (short)121438209;
				if (num != 0)
				{
				}
				num = (short)2003604991;
				short num3 = num;
				num = (short)1187157503;
				switch (num3 == num)
				{
				}
				num = (short)1674903552;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname.HiddenStatic;
			}
			set
			{
				short num = (short)993394688;
				short num2 = num;
				num = (short)919699175;
				short num3 = num;
				num = (short)2007334631;
				switch (num3 == num)
				{
				}
				num = (short)365953024;
				if (num != 0)
				{
				}
				num = (short)364969985;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname.HiddenStatic = value;
			}
		}

		// Token: 0x17001EB5 RID: 7861
		// (get) Token: 0x06003BEB RID: 15339 RVA: 0x003822D0 File Offset: 0x003804D0
		// (set) Token: 0x06003BEC RID: 15340 RVA: 0x00382388 File Offset: 0x00380588
		internal bool RadWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname_HiddenDynamic
		{
			get
			{
				short num = (short)1589510144;
				short num2 = num;
				num = (short)1339621377;
				if (num != 0)
				{
				}
				num = (short)219676707;
				short num3 = num;
				num = (short)629473315;
				switch (num3 == num)
				{
				}
				num = (short)1188954112;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname.HiddenDynamic;
			}
			set
			{
				short num = (short)252182528;
				short num2 = num;
				num = (short)547850071;
				short num3 = num;
				num = (short)830506839;
				switch (num3 == num)
				{
				}
				num = (short)359858177;
				if (num != 0)
				{
				}
				num = (short)2115764224;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname.HiddenDynamic = value;
			}
		}

		// Token: 0x17001EB6 RID: 7862
		// (get) Token: 0x06003BED RID: 15341 RVA: 0x0038243C File Offset: 0x0038063C
		public bool RadWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname_HasDiffs
		{
			get
			{
				short num = (short)1303052288;
				short num2 = num;
				num = (short)1518949887;
				short num3 = num;
				num = (short)1309103615;
				switch (num3 == num)
				{
				}
				num = (short)1054736385;
				if (num != 0)
				{
				}
				num = (short)1979973632;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname._HasDiffs;
			}
		}

		// Token: 0x17001EB7 RID: 7863
		// (get) Token: 0x06003BEE RID: 15342 RVA: 0x003824F4 File Offset: 0x003806F4
		// (set) Token: 0x06003BEF RID: 15343 RVA: 0x003825A8 File Offset: 0x003807A8
		public string RadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugIdValue
		{
			get
			{
				short num = (short)1708654592;
				short num2 = num;
				num = (short)1434333001;
				short num3 = num;
				num = (short)623849289;
				switch (num3 == num)
				{
				}
				num = (short)178323456;
				if (num != 0)
				{
				}
				num = (short)1828847617;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId.Value;
			}
			set
			{
				short num = (short)991035392;
				short num2 = num;
				num = (short)174666331;
				short num3 = num;
				num = (short)93205083;
				switch (num3 == num)
				{
				}
				num = (short)673906689;
				if (num != 0)
				{
				}
				num = (short)249430016;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId.Value = value;
			}
		}

		// Token: 0x17001EB8 RID: 7864
		// (get) Token: 0x06003BF0 RID: 15344 RVA: 0x0038265C File Offset: 0x0038085C
		// (set) Token: 0x06003BF1 RID: 15345 RVA: 0x00382710 File Offset: 0x00380910
		public string RadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId_UIValue
		{
			get
			{
				short num = (short)1382875136;
				short num2 = num;
				num = (short)1483906677;
				short num3 = num;
				num = (short)1864015477;
				switch (num3 == num)
				{
				}
				num = (short)1377501185;
				if (num != 0)
				{
				}
				num = (short)1608122368;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId.Value;
			}
			set
			{
				short num = (short)217645056;
				short num2 = num;
				num = (short)727698704;
				short num3 = num;
				num = (short)395365648;
				switch (num3 == num)
				{
				}
				num = (short)1306132481;
				if (num != 0)
				{
				}
				num = (short)2004156416;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId.Value = value;
			}
		}

		// Token: 0x17001EB9 RID: 7865
		// (get) Token: 0x06003BF2 RID: 15346 RVA: 0x003827C8 File Offset: 0x003809C8
		public global::AcpBusinessLayer.AcpStringField RadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId
		{
			get
			{
				short num = (short)2101739520;
				short num2 = num;
				num = (short)99155969;
				if (num != 0)
				{
				}
				num = (short)2125854046;
				short num3 = num;
				num = (short)1770452318;
				switch (num3 == num)
				{
				}
				num = (short)350683136;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId;
			}
		}

		// Token: 0x17001EBA RID: 7866
		// (get) Token: 0x06003BF3 RID: 15347 RVA: 0x00382878 File Offset: 0x00380A78
		// (set) Token: 0x06003BF4 RID: 15348 RVA: 0x0038292C File Offset: 0x00380B2C
		public bool RadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId_Applicable
		{
			get
			{
				short num = (short)1224671232;
				short num2 = num;
				num = (short)1052492204;
				short num3 = num;
				num = (short)385728940;
				switch (num3 == num)
				{
				}
				num = (short)1655767041;
				if (num != 0)
				{
				}
				num = (short)1928527872;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId.Applicable;
			}
			set
			{
				short num = (short)639238144;
				short num2 = num;
				num = (short)1041020800;
				short num3 = num;
				num = (short)1768011648;
				switch (num3 == num)
				{
				}
				num = (short)212205569;
				if (num != 0)
				{
				}
				num = (short)1895759872;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId.Applicable = value;
			}
		}

		// Token: 0x17001EBB RID: 7867
		// (get) Token: 0x06003BF5 RID: 15349 RVA: 0x003829E4 File Offset: 0x00380BE4
		// (set) Token: 0x06003BF6 RID: 15350 RVA: 0x00382A98 File Offset: 0x00380C98
		public bool RadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId_Valid
		{
			get
			{
				short num = (short)235012096;
				short num2 = num;
				num = (short)949544126;
				short num3 = num;
				num = (short)194569406;
				switch (num3 == num)
				{
				}
				num = (short)65601537;
				if (num != 0)
				{
				}
				num = (short)719388672;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId.Valid;
			}
			set
			{
				short num = (short)1567096832;
				short num2 = num;
				num = (short)1959036538;
				short num3 = num;
				num = (short)1892845178;
				switch (num3 == num)
				{
				}
				num = (short)303104001;
				if (num != 0)
				{
				}
				num = (short)1390280704;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId.Valid = value;
			}
		}

		// Token: 0x17001EBC RID: 7868
		// (get) Token: 0x06003BF7 RID: 15351 RVA: 0x00382B4C File Offset: 0x00380D4C
		// (set) Token: 0x06003BF8 RID: 15352 RVA: 0x00382C04 File Offset: 0x00380E04
		public bool RadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId_Visible
		{
			get
			{
				short num = (short)1930035200;
				short num2 = num;
				num = (short)1127546881;
				if (num != 0)
				{
				}
				num = (short)684660694;
				short num3 = num;
				num = (short)901191638;
				switch (num3 == num)
				{
				}
				num = (short)1213530112;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId.Visible;
			}
			set
			{
				short num = (short)2065301504;
				short num2 = num;
				num = (short)2144731137;
				if (num != 0)
				{
				}
				num = (short)748416190;
				short num3 = num;
				num = (short)1608641726;
				switch (num3 == num)
				{
				}
				num = (short)796196864;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId.Visible = value;
			}
		}

		// Token: 0x17001EBD RID: 7869
		// (get) Token: 0x06003BF9 RID: 15353 RVA: 0x00382CBC File Offset: 0x00380EBC
		// (set) Token: 0x06003BFA RID: 15354 RVA: 0x00382D74 File Offset: 0x00380F74
		public bool RadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId_Editable
		{
			get
			{
				short num = (short)1598488576;
				short num2 = num;
				num = (short)1368520053;
				short num3 = num;
				num = (short)1576793461;
				switch (num3 == num)
				{
				}
				num = (short)1450704896;
				if (num != 0)
				{
				}
				num = (short)1107623937;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId.Editable;
			}
			set
			{
				short num = (short)1841627136;
				short num2 = num;
				num = (short)557915128;
				short num3 = num;
				num = (short)382934008;
				switch (num3 == num)
				{
				}
				num = (short)967835648;
				if (num != 0)
				{
				}
				num = (short)736100353;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId.Editable = value;
			}
		}

		// Token: 0x17001EBE RID: 7870
		// (get) Token: 0x06003BFB RID: 15355 RVA: 0x00382E28 File Offset: 0x00381028
		internal string RadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId_UILabel
		{
			get
			{
				short num = (short)2043346944;
				short num2 = num;
				num = (short)1097954318;
				short num3 = num;
				num = (short)1741648910;
				switch (num3 == num)
				{
				}
				num = (short)59047936;
				if (num != 0)
				{
				}
				num = (short)208011265;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId.UIName;
			}
		}

		// Token: 0x17001EBF RID: 7871
		// (get) Token: 0x06003BFC RID: 15356 RVA: 0x00382EDC File Offset: 0x003810DC
		// (set) Token: 0x06003BFD RID: 15357 RVA: 0x00382F90 File Offset: 0x00381190
		internal bool RadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId_HiddenStatic
		{
			get
			{
				short num = (short)1163067392;
				short num2 = num;
				num = (short)484143283;
				short num3 = num;
				num = (short)1908306099;
				switch (num3 == num)
				{
				}
				num = (short)824311808;
				if (num != 0)
				{
				}
				num = (short)329580545;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId.HiddenStatic;
			}
			set
			{
				short num = (short)106233856;
				short num2 = num;
				num = (short)1077018625;
				if (num != 0)
				{
				}
				num = (short)689186791;
				short num3 = num;
				num = (short)1054681063;
				switch (num3 == num)
				{
				}
				num = (short)1611792384;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId.HiddenStatic = value;
			}
		}

		// Token: 0x17001EC0 RID: 7872
		// (get) Token: 0x06003BFE RID: 15358 RVA: 0x00383044 File Offset: 0x00381244
		// (set) Token: 0x06003BFF RID: 15359 RVA: 0x003830FC File Offset: 0x003812FC
		internal bool RadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId_HiddenDynamic
		{
			get
			{
				short num = (short)1446313984;
				short num2 = num;
				num = (short)1228607109;
				short num3 = num;
				num = (short)1235226245;
				switch (num3 == num)
				{
				}
				num = (short)337313793;
				if (num != 0)
				{
				}
				num = (short)1269891072;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId.HiddenDynamic;
			}
			set
			{
				short num = (short)2143813632;
				short num2 = num;
				num = (short)880672769;
				if (num != 0)
				{
				}
				num = (short)181354276;
				short num3 = num;
				num = (short)1736458020;
				switch (num3 == num)
				{
				}
				num = (short)1185677312;
				if (num != 0)
				{
				}
				this.radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId.HiddenDynamic = value;
			}
		}

		// Token: 0x17001EC1 RID: 7873
		// (get) Token: 0x06003C00 RID: 15360 RVA: 0x003831B0 File Offset: 0x003813B0
		public bool RadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId_HasDiffs
		{
			get
			{
				short num = (short)904134656;
				short num2 = num;
				num = (short)882104940;
				short num3 = num;
				num = (short)213965420;
				switch (num3 == num)
				{
				}
				num = (short)480313345;
				if (num != 0)
				{
				}
				num = (short)1624965120;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId._HasDiffs;
			}
		}

		// Token: 0x17001EC2 RID: 7874
		// (get) Token: 0x06003C01 RID: 15361 RVA: 0x00383268 File Offset: 0x00381468
		// (set) Token: 0x06003C02 RID: 15362 RVA: 0x0038331C File Offset: 0x0038151C
		public bool RadWideLabtoolSeamlessUpdateOutOfBoxExperienceValue
		{
			get
			{
				short num = (short)626982912;
				short num2 = num;
				num = (short)524472017;
				short num3 = num;
				num = (short)2002570961;
				switch (num3 == num)
				{
				}
				num = (short)1274544129;
				if (num != 0)
				{
				}
				num = (short)332333056;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSeamlessUpdateOutOfBoxExperience.Value;
			}
			set
			{
				short num = (short)1682374656;
				short num2 = num;
				num = (short)1406337025;
				if (num != 0)
				{
				}
				num = (short)2019774544;
				short num3 = num;
				num = (short)435179600;
				switch (num3 == num)
				{
				}
				num = (short)1875378176;
				if (num != 0)
				{
				}
				this.radWideLabtoolSeamlessUpdateOutOfBoxExperience.Value = value;
			}
		}

		// Token: 0x17001EC3 RID: 7875
		// (get) Token: 0x06003C03 RID: 15363 RVA: 0x003833D4 File Offset: 0x003815D4
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolSeamlessUpdateOutOfBoxExperience
		{
			get
			{
				short num = (short)521011200;
				short num2 = num;
				num = (short)1333118667;
				short num3 = num;
				num = (short)956024523;
				switch (num3 == num)
				{
				}
				num = (short)336330753;
				if (num != 0)
				{
				}
				num = (short)1032912896;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSeamlessUpdateOutOfBoxExperience;
			}
		}

		// Token: 0x17001EC4 RID: 7876
		// (get) Token: 0x06003C04 RID: 15364 RVA: 0x00383484 File Offset: 0x00381684
		// (set) Token: 0x06003C05 RID: 15365 RVA: 0x00383538 File Offset: 0x00381738
		public bool RadWideLabtoolSeamlessUpdateOutOfBoxExperience_UIValue
		{
			get
			{
				short num = (short)1389953024;
				short num2 = num;
				num = (short)1084598421;
				short num3 = num;
				num = (short)1771808917;
				switch (num3 == num)
				{
				}
				num = (short)199294976;
				if (num != 0)
				{
				}
				num = (short)800784385;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSeamlessUpdateOutOfBoxExperience.Value;
			}
			set
			{
				short num = (short)98369536;
				short num2 = num;
				num = (short)1940767379;
				short num3 = num;
				num = (short)817939091;
				switch (num3 == num)
				{
				}
				num = (short)958005248;
				if (num != 0)
				{
				}
				num = (short)1878786049;
				if (num != 0)
				{
				}
				this.radWideLabtoolSeamlessUpdateOutOfBoxExperience.Value = value;
			}
		}

		// Token: 0x17001EC5 RID: 7877
		// (get) Token: 0x06003C06 RID: 15366 RVA: 0x003835EC File Offset: 0x003817EC
		// (set) Token: 0x06003C07 RID: 15367 RVA: 0x003836A0 File Offset: 0x003818A0
		public bool RadWideLabtoolSeamlessUpdateOutOfBoxExperience_Applicable
		{
			get
			{
				short num = (short)487718912;
				short num2 = num;
				num = (short)89496802;
				short num3 = num;
				num = (short)1750506722;
				switch (num3 == num)
				{
				}
				num = (short)2005336065;
				if (num != 0)
				{
				}
				num = (short)683999232;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSeamlessUpdateOutOfBoxExperience.Applicable;
			}
			set
			{
				short num = (short)1029111808;
				short num2 = num;
				num = (short)1964923737;
				short num3 = num;
				num = (short)1754225497;
				switch (num3 == num)
				{
				}
				num = (short)1656422401;
				if (num != 0)
				{
				}
				num = (short)513474560;
				if (num != 0)
				{
				}
				this.radWideLabtoolSeamlessUpdateOutOfBoxExperience.Applicable = value;
			}
		}

		// Token: 0x17001EC6 RID: 7878
		// (get) Token: 0x06003C08 RID: 15368 RVA: 0x00383754 File Offset: 0x00381954
		// (set) Token: 0x06003C09 RID: 15369 RVA: 0x00383808 File Offset: 0x00381A08
		public bool RadWideLabtoolSeamlessUpdateOutOfBoxExperience_Valid
		{
			get
			{
				short num = (short)1923022848;
				short num2 = num;
				num = (short)33817527;
				short num3 = num;
				num = (short)1377698743;
				switch (num3 == num)
				{
				}
				num = (short)811270144;
				if (num != 0)
				{
				}
				num = (short)878641153;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSeamlessUpdateOutOfBoxExperience.Valid;
			}
			set
			{
				short num = (short)1672413184;
				short num2 = num;
				num = (short)1933695760;
				short num3 = num;
				num = (short)1501485840;
				switch (num3 == num)
				{
				}
				num = (short)600965121;
				if (num != 0)
				{
				}
				num = (short)804061184;
				if (num != 0)
				{
				}
				this.radWideLabtoolSeamlessUpdateOutOfBoxExperience.Valid = value;
			}
		}

		// Token: 0x17001EC7 RID: 7879
		// (get) Token: 0x06003C0A RID: 15370 RVA: 0x003838C0 File Offset: 0x00381AC0
		// (set) Token: 0x06003C0B RID: 15371 RVA: 0x00383978 File Offset: 0x00381B78
		public bool RadWideLabtoolSeamlessUpdateOutOfBoxExperience_Visible
		{
			get
			{
				short num = (short)1501298688;
				short num2 = num;
				num = (short)586455858;
				short num3 = num;
				num = (short)8100658;
				switch (num3 == num)
				{
				}
				num = (short)1615396865;
				if (num != 0)
				{
				}
				num = (short)461307904;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSeamlessUpdateOutOfBoxExperience.Visible;
			}
			set
			{
				short num = (short)1792212992;
				short num2 = num;
				num = (short)851035192;
				short num3 = num;
				num = (short)630375480;
				switch (num3 == num)
				{
				}
				num = (short)1474625537;
				if (num != 0)
				{
				}
				num = (short)1617100800;
				if (num != 0)
				{
				}
				this.radWideLabtoolSeamlessUpdateOutOfBoxExperience.Visible = value;
			}
		}

		// Token: 0x17001EC8 RID: 7880
		// (get) Token: 0x06003C0C RID: 15372 RVA: 0x00383A30 File Offset: 0x00381C30
		// (set) Token: 0x06003C0D RID: 15373 RVA: 0x00383AE4 File Offset: 0x00381CE4
		public bool RadWideLabtoolSeamlessUpdateOutOfBoxExperience_Editable
		{
			get
			{
				short num = (short)19333120;
				short num2 = num;
				num = (short)1749917484;
				short num3 = num;
				num = (short)1141088044;
				switch (num3 == num)
				{
				}
				num = (short)1735196673;
				if (num != 0)
				{
				}
				num = (short)1914437632;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSeamlessUpdateOutOfBoxExperience.Editable;
			}
			set
			{
				short num = (short)1972961280;
				short num2 = num;
				num = (short)1224879592;
				short num3 = num;
				num = (short)23932392;
				switch (num3 == num)
				{
				}
				num = (short)639369216;
				if (num != 0)
				{
				}
				num = (short)116326401;
				if (num != 0)
				{
				}
				this.radWideLabtoolSeamlessUpdateOutOfBoxExperience.Editable = value;
			}
		}

		// Token: 0x17001EC9 RID: 7881
		// (get) Token: 0x06003C0E RID: 15374 RVA: 0x00383B9C File Offset: 0x00381D9C
		internal string RadWideLabtoolSeamlessUpdateOutOfBoxExperience_UILabel
		{
			get
			{
				short num = (short)1250557952;
				short num2 = num;
				num = (short)1198184994;
				short num3 = num;
				num = (short)1753602594;
				switch (num3 == num)
				{
				}
				num = (short)1409024001;
				if (num != 0)
				{
				}
				num = (short)1130102784;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSeamlessUpdateOutOfBoxExperience.UIName;
			}
		}

		// Token: 0x17001ECA RID: 7882
		// (get) Token: 0x06003C0F RID: 15375 RVA: 0x00383C54 File Offset: 0x00381E54
		// (set) Token: 0x06003C10 RID: 15376 RVA: 0x00383D08 File Offset: 0x00381F08
		internal bool RadWideLabtoolSeamlessUpdateOutOfBoxExperience_HiddenStatic
		{
			get
			{
				short num = (short)1537409024;
				short num2 = num;
				num = (short)538158795;
				short num3 = num;
				num = (short)2072553163;
				switch (num3 == num)
				{
				}
				num = (short)47054848;
				if (num != 0)
				{
				}
				num = (short)918290433;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSeamlessUpdateOutOfBoxExperience.HiddenStatic;
			}
			set
			{
				short num = (short)963837952;
				short num2 = num;
				num = (short)7378150;
				short num3 = num;
				num = (short)1189188838;
				switch (num3 == num)
				{
				}
				num = (short)142737409;
				if (num != 0)
				{
				}
				num = (short)828309504;
				if (num != 0)
				{
				}
				this.radWideLabtoolSeamlessUpdateOutOfBoxExperience.HiddenStatic = value;
			}
		}

		// Token: 0x17001ECB RID: 7883
		// (get) Token: 0x06003C11 RID: 15377 RVA: 0x00383DBC File Offset: 0x00381FBC
		// (set) Token: 0x06003C12 RID: 15378 RVA: 0x00383E70 File Offset: 0x00382070
		internal bool RadWideLabtoolSeamlessUpdateOutOfBoxExperience_HiddenDynamic
		{
			get
			{
				short num = (short)1054801920;
				short num2 = num;
				num = (short)76770253;
				short num3 = num;
				num = (short)1771334605;
				switch (num3 == num)
				{
				}
				num = (short)1097203712;
				if (num != 0)
				{
				}
				num = (short)35258369;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSeamlessUpdateOutOfBoxExperience.HiddenDynamic;
			}
			set
			{
				short num = (short)2024079360;
				short num2 = num;
				num = (short)363006557;
				short num3 = num;
				num = (short)846858845;
				switch (num3 == num)
				{
				}
				num = (short)183304192;
				if (num != 0)
				{
				}
				num = (short)2069823489;
				if (num != 0)
				{
				}
				this.radWideLabtoolSeamlessUpdateOutOfBoxExperience.HiddenDynamic = value;
			}
		}

		// Token: 0x17001ECC RID: 7884
		// (get) Token: 0x06003C13 RID: 15379 RVA: 0x00383F2C File Offset: 0x0038212C
		public bool RadWideLabtoolSeamlessUpdateOutOfBoxExperience_HasDiffs
		{
			get
			{
				short num = (short)845938688;
				short num2 = num;
				num = (short)805830657;
				if (num != 0)
				{
				}
				num = (short)854597150;
				short num3 = num;
				num = (short)269098526;
				switch (num3 == num)
				{
				}
				num = (short)1420951552;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSeamlessUpdateOutOfBoxExperience._HasDiffs;
			}
		}

		// Token: 0x17001ECD RID: 7885
		// (get) Token: 0x06003C14 RID: 15380 RVA: 0x00383FE0 File Offset: 0x003821E0
		// (set) Token: 0x06003C15 RID: 15381 RVA: 0x00384094 File Offset: 0x00382294
		public string RadWideLabtoolRCLastJobSetUUIDValue
		{
			get
			{
				short num = (short)2097807360;
				short num2 = num;
				num = (short)2013009279;
				short num3 = num;
				num = (short)608572799;
				switch (num3 == num)
				{
				}
				num = (short)1078525952;
				if (num != 0)
				{
				}
				num = (short)1976762369;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRCLastJobSetUUID.Value;
			}
			set
			{
				short num = (short)25296896;
				short num2 = num;
				num = (short)1861525989;
				short num3 = num;
				num = (short)415670757;
				switch (num3 == num)
				{
				}
				num = (short)1412235264;
				if (num != 0)
				{
				}
				num = (short)1462304769;
				if (num != 0)
				{
				}
				this.radWideLabtoolRCLastJobSetUUID.Value = value;
			}
		}

		// Token: 0x17001ECE RID: 7886
		// (get) Token: 0x06003C16 RID: 15382 RVA: 0x00384148 File Offset: 0x00382348
		// (set) Token: 0x06003C17 RID: 15383 RVA: 0x003841FC File Offset: 0x003823FC
		public string RadWideLabtoolRCLastJobSetUUID_UIValue
		{
			get
			{
				short num = (short)193200128;
				short num2 = num;
				num = (short)256270996;
				short num3 = num;
				num = (short)1277780628;
				switch (num3 == num)
				{
				}
				num = (short)1253965825;
				if (num != 0)
				{
				}
				num = (short)275185664;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRCLastJobSetUUID.Value;
			}
			set
			{
				short num = (short)79020711;
				short num2 = num;
				num = (short)726188711;
				switch (num2 == num)
				{
				default:
				{
					num = (short)808779776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)776863745;
				if (num != 0)
				{
				}
				num = (short)1804009472;
				if (num != 0)
				{
				}
				this.radWideLabtoolRCLastJobSetUUID.Value = value;
			}
		}

		// Token: 0x17001ECF RID: 7887
		// (get) Token: 0x06003C18 RID: 15384 RVA: 0x003842B0 File Offset: 0x003824B0
		public global::AcpBusinessLayer.AcpStringField RadWideLabtoolRCLastJobSetUUID
		{
			get
			{
				short num = (short)24343436;
				short num2 = num;
				num = (short)717255564;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1762525184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)919994369;
				if (num != 0)
				{
				}
				num = (short)458555392;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRCLastJobSetUUID;
			}
		}

		// Token: 0x17001ED0 RID: 7888
		// (get) Token: 0x06003C19 RID: 15385 RVA: 0x00384360 File Offset: 0x00382560
		// (set) Token: 0x06003C1A RID: 15386 RVA: 0x00384418 File Offset: 0x00382618
		public bool RadWideLabtoolRCLastJobSetUUID_Applicable
		{
			get
			{
				short num = (short)328683822;
				short num2 = num;
				num = (short)1391022382;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1868169216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1502085121;
				if (num != 0)
				{
				}
				num = (short)305332224;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRCLastJobSetUUID.Applicable;
			}
			set
			{
				short num = (short)1760539740;
				short num2 = num;
				num = (short)94549084;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1571094528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)756219905;
				if (num != 0)
				{
				}
				num = (short)562233344;
				if (num != 0)
				{
				}
				this.radWideLabtoolRCLastJobSetUUID.Applicable = value;
			}
		}

		// Token: 0x17001ED1 RID: 7889
		// (get) Token: 0x06003C1B RID: 15387 RVA: 0x003844CC File Offset: 0x003826CC
		// (set) Token: 0x06003C1C RID: 15388 RVA: 0x00384580 File Offset: 0x00382780
		public bool RadWideLabtoolRCLastJobSetUUID_Valid
		{
			get
			{
				short num = (short)577380269;
				short num2 = num;
				num = (short)2118459309;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1121124352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)113246208;
				if (num != 0)
				{
				}
				num = (short)1420099585;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRCLastJobSetUUID.Valid;
			}
			set
			{
				short num = (short)1958511767;
				short num2 = num;
				num = (short)387024023;
				switch (num2 == num)
				{
				default:
				{
					num = (short)842137600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)497090561;
				if (num != 0)
				{
				}
				num = (short)2031353856;
				if (num != 0)
				{
				}
				this.radWideLabtoolRCLastJobSetUUID.Valid = value;
			}
		}

		// Token: 0x17001ED2 RID: 7890
		// (get) Token: 0x06003C1D RID: 15389 RVA: 0x00384634 File Offset: 0x00382834
		// (set) Token: 0x06003C1E RID: 15390 RVA: 0x003846E8 File Offset: 0x003828E8
		public bool RadWideLabtoolRCLastJobSetUUID_Visible
		{
			get
			{
				short num = (short)1003487233;
				if (num != 0)
				{
				}
				num = (short)919404544;
				short num2 = num;
				num = (short)718675781;
				short num3 = num;
				num = (short)1506549573;
				switch (num3 == num)
				{
				}
				num = (short)815398912;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRCLastJobSetUUID.Visible;
			}
			set
			{
				short num = (short)1970427508;
				short num2 = num;
				num = (short)1719031412;
				switch (num2 == num)
				{
				default:
				{
					num = (short)749862912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)398721025;
				if (num != 0)
				{
				}
				num = (short)724828160;
				if (num != 0)
				{
				}
				this.radWideLabtoolRCLastJobSetUUID.Visible = value;
			}
		}

		// Token: 0x17001ED3 RID: 7891
		// (get) Token: 0x06003C1F RID: 15391 RVA: 0x0038479C File Offset: 0x0038299C
		// (set) Token: 0x06003C20 RID: 15392 RVA: 0x00384854 File Offset: 0x00382A54
		public bool RadWideLabtoolRCLastJobSetUUID_Editable
		{
			get
			{
				short num = (short)194075882;
				short num2 = num;
				num = (short)944200938;
				switch (num2 == num)
				{
				default:
				{
					num = (short)153288704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)847446017;
				if (num != 0)
				{
				}
				num = (short)1326383104;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRCLastJobSetUUID.Editable;
			}
			set
			{
				short num = (short)453216121;
				short num2 = num;
				num = (short)1149470585;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1629093888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)838270977;
				if (num != 0)
				{
				}
				num = (short)1454571520;
				if (num != 0)
				{
				}
				this.radWideLabtoolRCLastJobSetUUID.Editable = value;
			}
		}

		// Token: 0x17001ED4 RID: 7892
		// (get) Token: 0x06003C21 RID: 15393 RVA: 0x00384908 File Offset: 0x00382B08
		internal string RadWideLabtoolRCLastJobSetUUID_UILabel
		{
			get
			{
				short num = (short)488652738;
				short num2 = num;
				num = (short)997736386;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2131558400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)956301312;
				if (num != 0)
				{
				}
				num = (short)1980432385;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRCLastJobSetUUID.UIName;
			}
		}

		// Token: 0x17001ED5 RID: 7893
		// (get) Token: 0x06003C22 RID: 15394 RVA: 0x003849BC File Offset: 0x00382BBC
		// (set) Token: 0x06003C23 RID: 15395 RVA: 0x00384A70 File Offset: 0x00382C70
		internal bool RadWideLabtoolRCLastJobSetUUID_HiddenStatic
		{
			get
			{
				short num = (short)1167664566;
				short num2 = num;
				num = (short)913974710;
				switch (num2 == num)
				{
				default:
				{
					num = (short)498204672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1071710209;
				if (num != 0)
				{
				}
				num = (short)475267072;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRCLastJobSetUUID.HiddenStatic;
			}
			set
			{
				short num = (short)1907669125;
				short num2 = num;
				num = (short)2101917829;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1788477440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1698299904;
				if (num != 0)
				{
				}
				num = (short)660078593;
				if (num != 0)
				{
				}
				this.radWideLabtoolRCLastJobSetUUID.HiddenStatic = value;
			}
		}

		// Token: 0x17001ED6 RID: 7894
		// (get) Token: 0x06003C24 RID: 15396 RVA: 0x00384B2C File Offset: 0x00382D2C
		// (set) Token: 0x06003C25 RID: 15397 RVA: 0x00384BE4 File Offset: 0x00382DE4
		internal bool RadWideLabtoolRCLastJobSetUUID_HiddenDynamic
		{
			get
			{
				short num = (short)1664091566;
				short num2 = num;
				num = (short)619906478;
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
				num = (short)1867907073;
				if (num != 0)
				{
				}
				num = (short)136052736;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRCLastJobSetUUID.HiddenDynamic;
			}
			set
			{
				short num = (short)292382845;
				short num2 = num;
				num = (short)30107773;
				switch (num2 == num)
				{
				default:
				{
					num = (short)937951232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)547225601;
				if (num != 0)
				{
				}
				num = (short)858456064;
				if (num != 0)
				{
				}
				this.radWideLabtoolRCLastJobSetUUID.HiddenDynamic = value;
			}
		}

		// Token: 0x17001ED7 RID: 7895
		// (get) Token: 0x06003C26 RID: 15398 RVA: 0x00384C98 File Offset: 0x00382E98
		public bool RadWideLabtoolRCLastJobSetUUID_HasDiffs
		{
			get
			{
				short num = (short)396396997;
				short num2 = num;
				num = (short)1536133573;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1379794944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1024655361;
				if (num != 0)
				{
				}
				num = (short)151584768;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRCLastJobSetUUID._HasDiffs;
			}
		}

		// Token: 0x17001ED8 RID: 7896
		// (get) Token: 0x06003C27 RID: 15399 RVA: 0x00384D50 File Offset: 0x00382F50
		// (set) Token: 0x06003C28 RID: 15400 RVA: 0x00384E08 File Offset: 0x00383008
		public bool RadWideLabtoolADPGatingPCIBit_Value
		{
			get
			{
				short num = (short)1820187618;
				short num2 = num;
				num = (short)1435491298;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1117585408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)309657601;
				if (num != 0)
				{
				}
				num = (short)1948450816;
				if (num != 0)
				{
				}
				return this.radwideLabtoolADPGatingPCIBit.Value;
			}
			set
			{
				short num = (short)1012793345;
				if (num != 0)
				{
				}
				num = (short)2018836480;
				short num2 = num;
				num = (short)2011377710;
				short num3 = num;
				num = (short)376516654;
				switch (num3 == num)
				{
				}
				num = (short)88473600;
				if (num != 0)
				{
				}
				this.radwideLabtoolADPGatingPCIBit.Value = value;
			}
		}

		// Token: 0x17001ED9 RID: 7897
		// (get) Token: 0x06003C29 RID: 15401 RVA: 0x00384EC0 File Offset: 0x003830C0
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolADPGatingPCIBit_44813
		{
			get
			{
				short num = (short)463968773;
				short num2 = num;
				num = (short)1125489157;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1721630720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1621819393;
				if (num != 0)
				{
				}
				num = (short)392364032;
				if (num != 0)
				{
				}
				return this.radwideLabtoolADPGatingPCIBit;
			}
		}

		// Token: 0x17001EDA RID: 7898
		// (get) Token: 0x06003C2A RID: 15402 RVA: 0x00384F6C File Offset: 0x0038316C
		// (set) Token: 0x06003C2B RID: 15403 RVA: 0x00385028 File Offset: 0x00383228
		public bool RadWideLabtoolADPGatingPCIBit_UIValue
		{
			get
			{
				short num = (short)1659289077;
				short num2 = num;
				num = (short)1144045045;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2066612224;
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
				num = (short)491782144;
				if (num != 0)
				{
				}
				return this.radwideLabtoolADPGatingPCIBit.Value;
			}
			set
			{
				short num = (short)255908976;
				short num2 = num;
				num = (short)1250483312;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2048393216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1944780801;
				if (num != 0)
				{
				}
				num = (short)1823145984;
				if (num != 0)
				{
				}
				this.radwideLabtoolADPGatingPCIBit.Value = value;
			}
		}

		// Token: 0x17001EDB RID: 7899
		// (get) Token: 0x06003C2C RID: 15404 RVA: 0x003850E0 File Offset: 0x003832E0
		// (set) Token: 0x06003C2D RID: 15405 RVA: 0x00385194 File Offset: 0x00383394
		public bool RadWideLabtoolADPGatingPCIBit_Applicable
		{
			get
			{
				short num = (short)1373915531;
				short num2 = num;
				num = (short)965298571;
				switch (num2 == num)
				{
				default:
				{
					num = (short)393871360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)908525569;
				if (num != 0)
				{
				}
				num = (short)1406926848;
				if (num != 0)
				{
				}
				return this.radwideLabtoolADPGatingPCIBit.Applicable;
			}
			set
			{
				short num = (short)1574355521;
				short num2 = num;
				num = (short)287359553;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1242628096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)14024704;
				if (num != 0)
				{
				}
				num = (short)915210241;
				if (num != 0)
				{
				}
				this.radwideLabtoolADPGatingPCIBit.Applicable = value;
			}
		}

		// Token: 0x17001EDC RID: 7900
		// (get) Token: 0x06003C2E RID: 15406 RVA: 0x00385248 File Offset: 0x00383448
		// (set) Token: 0x06003C2F RID: 15407 RVA: 0x003852FC File Offset: 0x003834FC
		public bool RadWideLabtoolADPGatingPCIBit_Valid
		{
			get
			{
				short num = (short)432371882;
				short num2 = num;
				num = (short)1392801962;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1187708928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2017787905;
				if (num != 0)
				{
				}
				num = (short)1144848384;
				if (num != 0)
				{
				}
				return this.radwideLabtoolADPGatingPCIBit.Valid;
			}
			set
			{
				short num = (short)2055077889;
				if (num != 0)
				{
				}
				num = (short)1344208896;
				short num2 = num;
				num = (short)209305301;
				short num3 = num;
				num = (short)38059733;
				switch (num3 == num)
				{
				}
				num = (short)1357316096;
				if (num != 0)
				{
				}
				this.radwideLabtoolADPGatingPCIBit.Valid = value;
			}
		}

		// Token: 0x17001EDD RID: 7901
		// (get) Token: 0x06003C30 RID: 15408 RVA: 0x003853B0 File Offset: 0x003835B0
		// (set) Token: 0x06003C31 RID: 15409 RVA: 0x00385464 File Offset: 0x00383664
		public bool RadWideLabtoolADPGatingPCIBit_Visible
		{
			get
			{
				short num = (short)1162419026;
				short num2 = num;
				num = (short)1488395090;
				switch (num2 == num)
				{
				default:
				{
					num = (short)441188352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)908001281;
				if (num != 0)
				{
				}
				num = (short)846004224;
				if (num != 0)
				{
				}
				return this.radwideLabtoolADPGatingPCIBit.Visible;
			}
			set
			{
				short num = (short)1685258241;
				if (num != 0)
				{
				}
				num = (short)199753728;
				short num2 = num;
				num = (short)1230468397;
				short num3 = num;
				num = (short)1957197101;
				switch (num3 == num)
				{
				}
				num = (short)1375076352;
				if (num != 0)
				{
				}
				this.radwideLabtoolADPGatingPCIBit.Visible = value;
			}
		}

		// Token: 0x17001EDE RID: 7902
		// (get) Token: 0x06003C32 RID: 15410 RVA: 0x0038551C File Offset: 0x0038371C
		// (set) Token: 0x06003C33 RID: 15411 RVA: 0x003855D0 File Offset: 0x003837D0
		public bool RadWideLabtoolADPGatingPCIBit_Editable
		{
			get
			{
				short num = (short)2043731751;
				short num2 = num;
				num = (short)1131863847;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1735720960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1386348545;
				if (num != 0)
				{
				}
				num = (short)82051072;
				if (num != 0)
				{
				}
				return this.radwideLabtoolADPGatingPCIBit.Editable;
			}
			set
			{
				short num = (short)519241729;
				if (num != 0)
				{
				}
				num = (short)484573184;
				short num2 = num;
				num = (short)2026570982;
				short num3 = num;
				num = (short)1144325350;
				switch (num3 == num)
				{
				}
				num = (short)1680408576;
				if (num != 0)
				{
				}
				this.radwideLabtoolADPGatingPCIBit.Editable = value;
			}
		}

		// Token: 0x17001EDF RID: 7903
		// (get) Token: 0x06003C34 RID: 15412 RVA: 0x00385688 File Offset: 0x00383888
		internal string RadWideLabtoolADPGatingPCIBit_UILabel
		{
			get
			{
				short num = (short)1752891393;
				if (num != 0)
				{
				}
				num = (short)18153472;
				short num2 = num;
				num = (short)341843338;
				short num3 = num;
				num = (short)1552752010;
				switch (num3 == num)
				{
				}
				num = (short)1247870976;
				if (num != 0)
				{
				}
				return this.radwideLabtoolADPGatingPCIBit.UIName;
			}
		}

		// Token: 0x17001EE0 RID: 7904
		// (get) Token: 0x06003C35 RID: 15413 RVA: 0x00385740 File Offset: 0x00383940
		// (set) Token: 0x06003C36 RID: 15414 RVA: 0x003857F4 File Offset: 0x003839F4
		internal bool RadWideLabtoolADPGatingPCIBit_HiddenStatic
		{
			get
			{
				short num = (short)1812328550;
				short num2 = num;
				num = (short)1286991974;
				switch (num2 == num)
				{
				default:
				{
					num = (short)144113664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1177223169;
				if (num != 0)
				{
				}
				num = (short)1819934720;
				if (num != 0)
				{
				}
				return this.radwideLabtoolADPGatingPCIBit.HiddenStatic;
			}
			set
			{
				short num = (short)2027225089;
				if (num != 0)
				{
				}
				num = (short)1284833280;
				short num2 = num;
				num = (short)1558260132;
				short num3 = num;
				num = (short)1520052644;
				switch (num3 == num)
				{
				}
				num = (short)2062680064;
				if (num != 0)
				{
				}
				this.radwideLabtoolADPGatingPCIBit.HiddenStatic = value;
			}
		}

		// Token: 0x17001EE1 RID: 7905
		// (get) Token: 0x06003C37 RID: 15415 RVA: 0x003858A8 File Offset: 0x00383AA8
		// (set) Token: 0x06003C38 RID: 15416 RVA: 0x0038595C File Offset: 0x00383B5C
		internal bool RadWideLabtoolADPGatingPCIBit_HiddenDynamic
		{
			get
			{
				short num = (short)1639921799;
				short num2 = num;
				num = (short)1951414407;
				switch (num2 == num)
				{
				default:
				{
					num = (short)837550080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)472383488;
				if (num != 0)
				{
				}
				num = (short)1556283393;
				if (num != 0)
				{
				}
				return this.radwideLabtoolADPGatingPCIBit.HiddenDynamic;
			}
			set
			{
				short num = (short)1241776129;
				if (num != 0)
				{
				}
				num = (short)188153856;
				short num2 = num;
				num = (short)1355050045;
				short num3 = num;
				num = (short)889941053;
				switch (num3 == num)
				{
				}
				num = (short)394592256;
				if (num != 0)
				{
				}
				this.radwideLabtoolADPGatingPCIBit.HiddenDynamic = value;
			}
		}

		// Token: 0x17001EE2 RID: 7906
		// (get) Token: 0x06003C39 RID: 15417 RVA: 0x00385A14 File Offset: 0x00383C14
		public bool RadWideLabtoolADPGatingPCIBit_HasDiffs
		{
			get
			{
				short num = (short)1616350632;
				short num2 = num;
				num = (short)1948749224;
				switch (num2 == num)
				{
				default:
				{
					num = (short)673382400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)752156673;
				if (num != 0)
				{
				}
				num = (short)585760768;
				if (num != 0)
				{
				}
				return this.radwideLabtoolADPGatingPCIBit._HasDiffs;
			}
		}

		// Token: 0x17001EE3 RID: 7907
		// (get) Token: 0x06003C3A RID: 15418 RVA: 0x00385AC8 File Offset: 0x00383CC8
		// (set) Token: 0x06003C3B RID: 15419 RVA: 0x00385B7C File Offset: 0x00383D7C
		public bool RadWideLabtoolSupportO3ControlHeadPCIBit_Value
		{
			get
			{
				short num = (short)454447935;
				short num2 = num;
				num = (short)454775615;
				switch (num2 == num)
				{
				default:
				{
					num = (short)469499904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1030881280;
				if (num != 0)
				{
				}
				num = (short)2090729473;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSupportO3ControlHeadPCIBit.Value;
			}
			set
			{
				short num = (short)1792737281;
				if (num != 0)
				{
				}
				num = (short)270204928;
				short num2 = num;
				num = (short)791631719;
				short num3 = num;
				num = (short)1030969191;
				switch (num3 == num)
				{
				}
				num = (short)1377697792;
				if (num != 0)
				{
				}
				this.radWideLabtoolSupportO3ControlHeadPCIBit.Value = value;
			}
		}

		// Token: 0x17001EE4 RID: 7908
		// (get) Token: 0x06003C3C RID: 15420 RVA: 0x00385C34 File Offset: 0x00383E34
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolSupportO3ControlHeadPCIBit_44884
		{
			get
			{
				short num = (short)1060376118;
				short num2 = num;
				num = (short)1664159286;
				switch (num2 == num)
				{
				default:
				{
					num = (short)786628608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)444399617;
				if (num != 0)
				{
				}
				num = (short)179961856;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSupportO3ControlHeadPCIBit;
			}
		}

		// Token: 0x17001EE5 RID: 7909
		// (get) Token: 0x06003C3D RID: 15421 RVA: 0x00385CE4 File Offset: 0x00383EE4
		// (set) Token: 0x06003C3E RID: 15422 RVA: 0x00385D98 File Offset: 0x00383F98
		public bool RadWideLabtoolSupportO3ControlHeadPCIBit_UIValue
		{
			get
			{
				short num = (short)1010728245;
				short num2 = num;
				num = (short)1162050869;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1119289344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2036072449;
				if (num != 0)
				{
				}
				num = (short)1609564160;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSupportO3ControlHeadPCIBit.Value;
			}
			set
			{
				short num = (short)321181377;
				short num2 = num;
				num = (short)331273921;
				switch (num2 == num)
				{
				default:
				{
					num = (short)61734912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1274544129;
				if (num != 0)
				{
				}
				num = (short)462487552;
				if (num != 0)
				{
				}
				this.radWideLabtoolSupportO3ControlHeadPCIBit.Value = value;
			}
		}

		// Token: 0x17001EE6 RID: 7910
		// (get) Token: 0x06003C3F RID: 15423 RVA: 0x00385E50 File Offset: 0x00384050
		// (set) Token: 0x06003C40 RID: 15424 RVA: 0x00385F04 File Offset: 0x00384104
		public bool RadWideLabtoolSupportO3ControlHeadPCIBit_Applicable
		{
			get
			{
				short num = (short)465036401;
				short num2 = num;
				num = (short)1673716849;
				switch (num2 == num)
				{
				default:
				{
					num = (short)763822080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1367080960;
				if (num != 0)
				{
				}
				num = (short)1625620481;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSupportO3ControlHeadPCIBit.Applicable;
			}
			set
			{
				short num = (short)620691457;
				if (num != 0)
				{
				}
				num = (short)1054539776;
				short num2 = num;
				num = (short)797148316;
				short num3 = num;
				num = (short)739280028;
				switch (num3 == num)
				{
				}
				num = (short)1858600960;
				if (num != 0)
				{
				}
				this.radWideLabtoolSupportO3ControlHeadPCIBit.Applicable = value;
			}
		}

		// Token: 0x17001EE7 RID: 7911
		// (get) Token: 0x06003C41 RID: 15425 RVA: 0x00385FB8 File Offset: 0x003841B8
		// (set) Token: 0x06003C42 RID: 15426 RVA: 0x00386070 File Offset: 0x00384270
		public bool RadWideLabtoolSupportO3ControlHeadPCIBit_Valid
		{
			get
			{
				short num = (short)2025799240;
				short num2 = num;
				num = (short)1776827976;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1036976128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)216727552;
				if (num != 0)
				{
				}
				num = (short)530776065;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSupportO3ControlHeadPCIBit.Valid;
			}
			set
			{
				short num = (short)1237597375;
				short num2 = num;
				num = (short)1729379519;
				switch (num2 == num)
				{
				default:
				{
					num = (short)523763712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1228996608;
				if (num != 0)
				{
				}
				num = (short)24641537;
				if (num != 0)
				{
				}
				this.radWideLabtoolSupportO3ControlHeadPCIBit.Valid = value;
			}
		}

		// Token: 0x17001EE8 RID: 7912
		// (get) Token: 0x06003C43 RID: 15427 RVA: 0x00386124 File Offset: 0x00384324
		// (set) Token: 0x06003C44 RID: 15428 RVA: 0x003861D8 File Offset: 0x003843D8
		public bool RadWideLabtoolSupportO3ControlHeadPCIBit_Visible
		{
			get
			{
				short num = (short)563699561;
				short num2 = num;
				num = (short)1747804009;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1168834560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1541603329;
				if (num != 0)
				{
				}
				num = (short)1301872640;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSupportO3ControlHeadPCIBit.Visible;
			}
			set
			{
				short num = (short)1986725938;
				short num2 = num;
				num = (short)1988233266;
				switch (num2 == num)
				{
				default:
				{
					num = (short)445382656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)660602881;
				if (num != 0)
				{
				}
				num = (short)639959040;
				if (num != 0)
				{
				}
				this.radWideLabtoolSupportO3ControlHeadPCIBit.Visible = value;
			}
		}

		// Token: 0x17001EE9 RID: 7913
		// (get) Token: 0x06003C45 RID: 15429 RVA: 0x0038628C File Offset: 0x0038448C
		// (set) Token: 0x06003C46 RID: 15430 RVA: 0x00386340 File Offset: 0x00384540
		public bool RadWideLabtoolSupportO3ControlHeadPCIBit_Editable
		{
			get
			{
				short num = (short)1483481500;
				short num2 = num;
				num = (short)20980124;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1438646272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1519910913;
				if (num != 0)
				{
				}
				num = (short)1653080064;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSupportO3ControlHeadPCIBit.Editable;
			}
			set
			{
				short num = (short)1691328796;
				short num2 = num;
				num = (short)1464443164;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1214513152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)174784513;
				if (num != 0)
				{
				}
				num = (short)268959744;
				if (num != 0)
				{
				}
				this.radWideLabtoolSupportO3ControlHeadPCIBit.Editable = value;
			}
		}

		// Token: 0x17001EEA RID: 7914
		// (get) Token: 0x06003C47 RID: 15431 RVA: 0x003863F8 File Offset: 0x003845F8
		internal string RadWideLabtoolSupportO3ControlHeadPCIBit_UILabel
		{
			get
			{
				short num = (short)292564073;
				short num2 = num;
				num = (short)1257647209;
				switch (num2 == num)
				{
				default:
				{
					num = (short)650182656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2016477184;
				if (num != 0)
				{
				}
				num = (short)685965313;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSupportO3ControlHeadPCIBit.UIName;
			}
		}

		// Token: 0x17001EEB RID: 7915
		// (get) Token: 0x06003C48 RID: 15432 RVA: 0x003864AC File Offset: 0x003846AC
		// (set) Token: 0x06003C49 RID: 15433 RVA: 0x00386560 File Offset: 0x00384760
		internal bool RadWideLabtoolSupportO3ControlHeadPCIBit_HiddenStatic
		{
			get
			{
				short num = (short)1692852743;
				short num2 = num;
				num = (short)1305534983;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1071644672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2036596737;
				if (num != 0)
				{
				}
				num = (short)1407516672;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSupportO3ControlHeadPCIBit.HiddenStatic;
			}
			set
			{
				short num = (short)1543974522;
				short num2 = num;
				num = (short)445132410;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1870331904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1193672705;
				if (num != 0)
				{
				}
				num = (short)788398080;
				if (num != 0)
				{
				}
				this.radWideLabtoolSupportO3ControlHeadPCIBit.HiddenStatic = value;
			}
		}

		// Token: 0x17001EEC RID: 7916
		// (get) Token: 0x06003C4A RID: 15434 RVA: 0x00386614 File Offset: 0x00384814
		// (set) Token: 0x06003C4B RID: 15435 RVA: 0x003866C8 File Offset: 0x003848C8
		internal bool RadWideLabtoolSupportO3ControlHeadPCIBit_HiddenDynamic
		{
			get
			{
				short num = (short)558165488;
				short num2 = num;
				num = (short)1449258480;
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
				num = (short)1868431360;
				if (num != 0)
				{
				}
				num = (short)727973889;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSupportO3ControlHeadPCIBit.HiddenDynamic;
			}
			set
			{
				short num = (short)175537018;
				short num2 = num;
				num = (short)52329338;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1482817536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1400504321;
				if (num != 0)
				{
				}
				num = (short)1947074560;
				if (num != 0)
				{
				}
				this.radWideLabtoolSupportO3ControlHeadPCIBit.HiddenDynamic = value;
			}
		}

		// Token: 0x17001EED RID: 7917
		// (get) Token: 0x06003C4C RID: 15436 RVA: 0x00386780 File Offset: 0x00384980
		public bool RadWideLabtoolSupportO3ControlHeadPCIBit_HasDiffs
		{
			get
			{
				short num = (short)351141889;
				if (num != 0)
				{
				}
				num = (short)663617536;
				short num2 = num;
				num = (short)1025762288;
				short num3 = num;
				num = (short)1602085872;
				switch (num3 == num)
				{
				}
				num = (short)832045056;
				if (num != 0)
				{
				}
				return this.radWideLabtoolSupportO3ControlHeadPCIBit._HasDiffs;
			}
		}

		// Token: 0x17001EEE RID: 7918
		// (get) Token: 0x06003C4D RID: 15437 RVA: 0x00386838 File Offset: 0x00384A38
		// (set) Token: 0x06003C4E RID: 15438 RVA: 0x003868F0 File Offset: 0x00384AF0
		public bool RadWideLabtoolAnalogWideBandDataPCIBit_44885_Value
		{
			get
			{
				short num = (short)2115633152;
				short num2 = num;
				num = (short)369919524;
				short num3 = num;
				num = (short)1709409828;
				switch (num3 == num)
				{
				}
				num = (short)1022099456;
				if (num != 0)
				{
				}
				num = (short)1811546113;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAnalogWideBandDataPCIBit_44885.Value;
			}
			set
			{
				short num = (short)728432640;
				short num2 = num;
				num = (short)1916303644;
				short num3 = num;
				num = (short)707033372;
				switch (num3 == num)
				{
				}
				num = (short)1683947521;
				if (num != 0)
				{
				}
				num = (short)166002688;
				if (num != 0)
				{
				}
				this.radWideLabtoolAnalogWideBandDataPCIBit_44885.Value = value;
			}
		}

		// Token: 0x17001EEF RID: 7919
		// (get) Token: 0x06003C4F RID: 15439 RVA: 0x003869A8 File Offset: 0x00384BA8
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolAnalogWideBandDataPCIBit_44885
		{
			get
			{
				short num = (short)1553793024;
				short num2 = num;
				num = (short)1635955018;
				short num3 = num;
				num = (short)306295114;
				switch (num3 == num)
				{
				}
				num = (short)1930231808;
				if (num != 0)
				{
				}
				num = (short)43712513;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAnalogWideBandDataPCIBit_44885;
			}
		}

		// Token: 0x17001EF0 RID: 7920
		// (get) Token: 0x06003C50 RID: 15440 RVA: 0x00386A58 File Offset: 0x00384C58
		// (set) Token: 0x06003C51 RID: 15441 RVA: 0x00386B0C File Offset: 0x00384D0C
		public bool RadWideLabtoolAnalogWideBandDataPCIBit_44885_UIValue
		{
			get
			{
				short num = (short)1965490176;
				short num2 = num;
				num = (short)570687489;
				if (num != 0)
				{
				}
				num = (short)1076615299;
				short num3 = num;
				num = (short)1871829123;
				switch (num3 == num)
				{
				}
				num = (short)363331584;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAnalogWideBandDataPCIBit_44885.Value;
			}
			set
			{
				short num = (short)1935933440;
				short num2 = num;
				num = (short)879359367;
				short num3 = num;
				num = (short)877458823;
				switch (num3 == num)
				{
				}
				num = (short)1086849025;
				if (num != 0)
				{
				}
				num = (short)185729024;
				if (num != 0)
				{
				}
				this.radWideLabtoolAnalogWideBandDataPCIBit_44885.Value = value;
			}
		}

		// Token: 0x17001EF1 RID: 7921
		// (get) Token: 0x06003C52 RID: 15442 RVA: 0x00386BC4 File Offset: 0x00384DC4
		// (set) Token: 0x06003C53 RID: 15443 RVA: 0x00386C78 File Offset: 0x00384E78
		public bool RadWideLabtoolAnalogWideBandDataPCIBit_44885_Applicable
		{
			get
			{
				short num = (short)1763115008;
				short num2 = num;
				num = (short)1965950042;
				short num3 = num;
				num = (short)298976346;
				switch (num3 == num)
				{
				}
				num = (short)2109079553;
				if (num != 0)
				{
				}
				num = (short)1628307456;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAnalogWideBandDataPCIBit_44885.Applicable;
			}
			set
			{
				short num = (short)104464384;
				short num2 = num;
				num = (short)215486314;
				short num3 = num;
				num = (short)1139150698;
				switch (num3 == num)
				{
				}
				num = (short)1850015745;
				if (num != 0)
				{
				}
				num = (short)819462144;
				if (num != 0)
				{
				}
				this.radWideLabtoolAnalogWideBandDataPCIBit_44885.Applicable = value;
			}
		}

		// Token: 0x17001EF2 RID: 7922
		// (get) Token: 0x06003C54 RID: 15444 RVA: 0x00386D2C File Offset: 0x00384F2C
		// (set) Token: 0x06003C55 RID: 15445 RVA: 0x00386DE0 File Offset: 0x00384FE0
		public bool RadWideLabtoolAnalogWideBandDataPCIBit_44885_Valid
		{
			get
			{
				short num = (short)1646264320;
				short num2 = num;
				num = (short)703283230;
				short num3 = num;
				num = (short)1761755166;
				switch (num3 == num)
				{
				}
				num = (short)572325889;
				if (num != 0)
				{
				}
				num = (short)806486016;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAnalogWideBandDataPCIBit_44885.Valid;
			}
			set
			{
				short num = (short)1427308544;
				short num2 = num;
				num = (short)328749453;
				short num3 = num;
				num = (short)637292941;
				switch (num3 == num)
				{
				}
				num = (short)2057830401;
				if (num != 0)
				{
				}
				num = (short)1574371328;
				if (num != 0)
				{
				}
				this.radWideLabtoolAnalogWideBandDataPCIBit_44885.Valid = value;
			}
		}

		// Token: 0x17001EF3 RID: 7923
		// (get) Token: 0x06003C56 RID: 15446 RVA: 0x00386E98 File Offset: 0x00385098
		// (set) Token: 0x06003C57 RID: 15447 RVA: 0x00386F50 File Offset: 0x00385150
		public bool RadWideLabtoolAnalogWideBandDataPCIBit_44885_Visible
		{
			get
			{
				short num = (short)1333657600;
				short num2 = num;
				num = (short)1562787680;
				short num3 = num;
				num = (short)1202470752;
				switch (num3 == num)
				{
				}
				num = (short)265486337;
				if (num != 0)
				{
				}
				num = (short)1590886400;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAnalogWideBandDataPCIBit_44885.Visible;
			}
			set
			{
				short num = (short)701431808;
				short num2 = num;
				num = (short)1820983297;
				if (num != 0)
				{
				}
				num = (short)1009817362;
				short num3 = num;
				num = (short)1269405458;
				switch (num3 == num)
				{
				}
				num = (short)31260672;
				if (num != 0)
				{
				}
				this.radWideLabtoolAnalogWideBandDataPCIBit_44885.Visible = value;
			}
		}

		// Token: 0x17001EF4 RID: 7924
		// (get) Token: 0x06003C58 RID: 15448 RVA: 0x00387008 File Offset: 0x00385208
		// (set) Token: 0x06003C59 RID: 15449 RVA: 0x003870BC File Offset: 0x003852BC
		public bool RadWideLabtoolAnalogWideBandDataPCIBit_44885_Editable
		{
			get
			{
				short num = (short)1964703744;
				short num2 = num;
				num = (short)498079262;
				short num3 = num;
				num = (short)1434392094;
				switch (num3 == num)
				{
				}
				num = (short)1863778305;
				if (num != 0)
				{
				}
				num = (short)1313538048;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAnalogWideBandDataPCIBit_44885.Editable;
			}
			set
			{
				short num = (short)500957184;
				short num2 = num;
				num = (short)1259728174;
				short num3 = num;
				num = (short)976088366;
				switch (num3 == num)
				{
				}
				num = (short)429719552;
				if (num != 0)
				{
				}
				num = (short)949551105;
				if (num != 0)
				{
				}
				this.radWideLabtoolAnalogWideBandDataPCIBit_44885.Editable = value;
			}
		}

		// Token: 0x17001EF5 RID: 7925
		// (get) Token: 0x06003C5A RID: 15450 RVA: 0x00387174 File Offset: 0x00385374
		internal string RadWideLabtoolAnalogWideBandDataPCIBit_44885_UILabel
		{
			get
			{
				short num = (short)1169883136;
				short num2 = num;
				num = (short)1169312840;
				short num3 = num;
				num = (short)1413368904;
				switch (num3 == num)
				{
				}
				num = (short)1052311552;
				if (num != 0)
				{
				}
				num = (short)11272193;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAnalogWideBandDataPCIBit_44885.UIName;
			}
		}

		// Token: 0x17001EF6 RID: 7926
		// (get) Token: 0x06003C5B RID: 15451 RVA: 0x0038722C File Offset: 0x0038542C
		// (set) Token: 0x06003C5C RID: 15452 RVA: 0x003872E0 File Offset: 0x003854E0
		internal bool RadWideLabtoolAnalogWideBandDataPCIBit_44885_HiddenStatic
		{
			get
			{
				short num = (short)1362100224;
				short num2 = num;
				num = (short)1552578565;
				short num3 = num;
				num = (short)1187149829;
				switch (num3 == num)
				{
				}
				num = (short)746323969;
				if (num != 0)
				{
				}
				num = (short)703987712;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAnalogWideBandDataPCIBit_44885.HiddenStatic;
			}
			set
			{
				short num = (short)946536448;
				short num2 = num;
				num = (short)523834686;
				short num3 = num;
				num = (short)1108219198;
				switch (num3 == num)
				{
				}
				num = (short)1466368001;
				if (num != 0)
				{
				}
				num = (short)1117585408;
				if (num != 0)
				{
				}
				this.radWideLabtoolAnalogWideBandDataPCIBit_44885.HiddenStatic = value;
			}
		}

		// Token: 0x17001EF7 RID: 7927
		// (get) Token: 0x06003C5D RID: 15453 RVA: 0x00387398 File Offset: 0x00385598
		// (set) Token: 0x06003C5E RID: 15454 RVA: 0x00387450 File Offset: 0x00385650
		internal bool RadWideLabtoolAnalogWideBandDataPCIBit_44885_HiddenDynamic
		{
			get
			{
				short num = (short)407896064;
				short num2 = num;
				num = (short)88879710;
				short num3 = num;
				num = (short)544158302;
				switch (num3 == num)
				{
				}
				num = (short)1891958785;
				if (num != 0)
				{
				}
				num = (short)1091108864;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAnalogWideBandDataPCIBit_44885.HiddenDynamic;
			}
			set
			{
				short num = (short)470548480;
				short num2 = num;
				num = (short)919719340;
				short num3 = num;
				num = (short)166972844;
				switch (num3 == num)
				{
				}
				num = (short)283115520;
				if (num != 0)
				{
				}
				num = (short)73924609;
				if (num != 0)
				{
				}
				this.radWideLabtoolAnalogWideBandDataPCIBit_44885.HiddenDynamic = value;
			}
		}

		// Token: 0x17001EF8 RID: 7928
		// (get) Token: 0x06003C5F RID: 15455 RVA: 0x00387504 File Offset: 0x00385704
		public bool RadWideLabtoolAnalogWideBandDataPCIBit_44885_HasDiffs
		{
			get
			{
				short num = (short)325451776;
				short num2 = num;
				num = (short)1536799481;
				short num3 = num;
				num = (short)240366329;
				switch (num3 == num)
				{
				}
				num = (short)316276737;
				if (num != 0)
				{
				}
				num = (short)196542464;
				if (num != 0)
				{
				}
				return this.radWideLabtoolAnalogWideBandDataPCIBit_44885._HasDiffs;
			}
		}

		// Token: 0x06003C60 RID: 15456 RVA: 0x003875B8 File Offset: 0x003857B8
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
					if (base.ParentRecset != null)
					{
						num2 = (short)1479409666;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1578500100;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					num2 = (short)1198391297;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_12A;
				case 4:
					goto IL_168;
				}
				goto IL_24;
			}
			IL_12A:
			return result;
			IL_168:
			result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
			goto IL_111;
			IL_24:
			num2 = (short)1243595587;
			short num3 = num2;
			num2 = (short)1383777091;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_111:
				num2 = (short)1630928899;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			case 1:
				break;
			default:
			{
				num2 = (short)1348206592;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)2030370816;
			if (num2 != 0)
			{
			}
			num2 = (short)1213923329;
			if (num2 != 0)
			{
			}
			result = null;
			num2 = (short)1422589952;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040011BE RID: 4542
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolArchiveReadPasswordEnable_A7462;

		// Token: 0x040011BF RID: 4543
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolControlHeadConfiguration_A7722;

		// Token: 0x040011C0 RID: 4544
		private global::AcpBusinessLayer.AcpListField radWideLabtoolControlHeadSelection_A7723;

		// Token: 0x040011C1 RID: 4545
		private global::AcpBusinessLayer.AcpSimpleRangeField radWideLabtoolDisplayContrastConfiguration_A7873;

		// Token: 0x040011C2 RID: 4546
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolFatalError_A8015;

		// Token: 0x040011C3 RID: 4547
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolFlipDisplayOption_A8140;

		// Token: 0x040011C4 RID: 4548
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolFreeRevolvingRotary_A8147;

		// Token: 0x040011C5 RID: 4549
		private global::AcpBusinessLayer.AcpListField radWideLabtoolKeypadType_A8372;

		// Token: 0x040011C6 RID: 4550
		private global::AcpBusinessLayer.AcpField<string> radWideLabtoolRadioPassword_A8837;

		// Token: 0x040011C7 RID: 4551
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolRadioReadPasswordEnable_A8869;

		// Token: 0x040011C8 RID: 4552
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolRadioWritePasswordEnable_A8889;

		// Token: 0x040011C9 RID: 4553
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolReadWriteVoiceFiles_A8893;

		// Token: 0x040011CA RID: 4554
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolSirenPaFatalError_A9141;

		// Token: 0x040011CB RID: 4555
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolSirenPaOnly_A9142;

		// Token: 0x040011CC RID: 4556
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolSirenPaSystemLookup_A9143;

		// Token: 0x040011CD RID: 4557
		private global::AcpBusinessLayer.AcpField<bool> trunkingRadioInhibited_A19483;

		// Token: 0x040011CE RID: 4558
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolZoneSelectorOnSwitch_A19550;

		// Token: 0x040011CF RID: 4559
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolChannelSelectorOnSwitch_A19551;

		// Token: 0x040011D0 RID: 4560
		private global::AcpBusinessLayer.AcpRangeField<int, string> radWideLabtoolSmartLowBatteryThreshold_A20201;

		// Token: 0x040011D1 RID: 4561
		private global::AcpBusinessLayer.AcpSimpleRangeField radWideLabtoolEarlyWarningBatteryThreshold_A23977;

		// Token: 0x040011D2 RID: 4562
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolConsoletteModelEnable_A7713;

		// Token: 0x040011D3 RID: 4563
		private global::AcpBusinessLayer.AcpListField radWideLabtoolDisplayType_A7887;

		// Token: 0x040011D4 RID: 4564
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolDynamicZoneCable_A41258;

		// Token: 0x040011D5 RID: 4565
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolSirenAndLightsKeypadEnable_A41413;

		// Token: 0x040011D6 RID: 4566
		private global::AcpBusinessLayer.AcpListField radWideEmergencyRxTxAlertToneSet_A41508;

		// Token: 0x040011D7 RID: 4567
		private global::AcpBusinessLayer.AcpField<bool> radWideRadioKilled_A41559;

		// Token: 0x040011D8 RID: 4568
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolEncryptPassword_A41695;

		// Token: 0x040011D9 RID: 4569
		private global::AcpBusinessLayer.AcpField<string> radWideLabtoolEncryptedPINPassword_A41702;

		// Token: 0x040011DA RID: 4570
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolUltraLowPowerSoldierMacCapable_A41710;

		// Token: 0x040011DB RID: 4571
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolEmergencyRevertCapable_A41918;

		// Token: 0x040011DC RID: 4572
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolAudibleBeaconRoutingCapable_A41974;

		// Token: 0x040011DD RID: 4573
		private global::AcpBusinessLayer.AcpField<bool> manDownPersonalityConfigurableCapable_42082;

		// Token: 0x040011DE RID: 4574
		private global::AcpBusinessLayer.AcpField<bool> toneEmergencyConfigurableCapable_42083;

		// Token: 0x040011DF RID: 4575
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolAPX6000P25Radio_A42121;

		// Token: 0x040011E0 RID: 4576
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolSuppressEmergencyCallCapability_A42143;

		// Token: 0x040011E1 RID: 4577
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolMaritimeRadioSoftware_A42191;

		// Token: 0x040011E2 RID: 4578
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolMFKEmergencyAccess_A42216;

		// Token: 0x040011E3 RID: 4579
		private global::AcpBusinessLayer.AcpField<bool> emergencyHotAuxMicConfigurability_A42301;

		// Token: 0x040011E4 RID: 4580
		private global::AcpBusinessLayer.AcpField<bool> tPSCapable_A42312;

		// Token: 0x040011E5 RID: 4581
		private global::AcpBusinessLayer.AcpField<bool> pASSAlarmFilterCapable_A42387;

		// Token: 0x040011E6 RID: 4582
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolAPXDualKnobs_A42537;

		// Token: 0x040011E7 RID: 4583
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolAudioEnhancement_A42736;

		// Token: 0x040011E8 RID: 4584
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolDynamicZoneScanCapability_42749;

		// Token: 0x040011E9 RID: 4585
		private global::AcpBusinessLayer.AcpField<bool> radioWideDVRSTrunkingStatusCapability_A42772;

		// Token: 0x040011EA RID: 4586
		private global::AcpBusinessLayer.AcpField<bool> radioWideMOSCADACE3000Capability_A42772;

		// Token: 0x040011EB RID: 4587
		private global::AcpBusinessLayer.AcpField<string> radioWideReqFWVersion_A42872;

		// Token: 0x040011EC RID: 4588
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolPAAlertCapability_A42944;

		// Token: 0x040011ED RID: 4589
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolUserSelectablePLEnhancement_43031;

		// Token: 0x040011EE RID: 4590
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolConsolidatedActionEnhancement_A43036;

		// Token: 0x040011EF RID: 4591
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolLimitedISSIDVRSOperationCapable_43045;

		// Token: 0x040011F0 RID: 4592
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolActiveMicForBTPTTCapable_43053;

		// Token: 0x040011F1 RID: 4593
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolAPXSingletoneCapable_43080;

		// Token: 0x040011F2 RID: 4594
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolEnhancedARS_A43084;

		// Token: 0x040011F3 RID: 4595
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162;

		// Token: 0x040011F4 RID: 4596
		private global::AcpBusinessLayer.AcpField<bool> radioWideLabtoolZoneCloneCapable_43238;

		// Token: 0x040011F5 RID: 4597
		private global::AcpBusinessLayer.AcpField<bool> radioWideLabtoolEmergencyCallTermination_43348;

		// Token: 0x040011F6 RID: 4598
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolDisableEncryption_43371;

		// Token: 0x040011F7 RID: 4599
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolIntelligentPriorityScanCapable_43411;

		// Token: 0x040011F8 RID: 4600
		private global::AcpBusinessLayer.AcpField<bool> radioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548;

		// Token: 0x040011F9 RID: 4601
		private global::AcpBusinessLayer.AcpField<bool> mARVELL_DNP_43591;

		// Token: 0x040011FA RID: 4602
		private global::AcpBusinessLayer.AcpField<bool> tEN_DIGIT_RL_PSWD_capable_43711;

		// Token: 0x040011FB RID: 4603
		private global::AcpBusinessLayer.AcpField<bool> radioWideLabtoolExtendedPLToneSet_43769;

		// Token: 0x040011FC RID: 4604
		private global::AcpBusinessLayer.AcpField<bool> allowPSUSecure_43809;

		// Token: 0x040011FD RID: 4605
		private global::AcpBusinessLayer.AcpField<bool> uCLContactsLimitationEnhancement_43811;

		// Token: 0x040011FE RID: 4606
		private global::AcpBusinessLayer.AcpField<bool> dVRSRangeExt_44809;

		// Token: 0x040011FF RID: 4607
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolIndirectPTTAudioRoutingPCI_44817;

		// Token: 0x04001200 RID: 4608
		private global::AcpBusinessLayer.AcpSimpleRangeField radWideLabtoolCertMgmtMotorolaSolutionsPKIPort;

		// Token: 0x04001201 RID: 4609
		private global::AcpBusinessLayer.AcpStringField radWideLabtoolCertMgmtMotorolaSolutionsPKIHostname;

		// Token: 0x04001202 RID: 4610
		private global::AcpBusinessLayer.AcpSimpleRangeField radWideLabtoolDeviceMgmtSeamlessUpdateRmPskId;

		// Token: 0x04001203 RID: 4611
		private global::AcpBusinessLayer.AcpStringField radWideLabtoolDeviceMgmtSeamlessUpdateRmPsk;

		// Token: 0x04001204 RID: 4612
		private global::AcpBusinessLayer.AcpStringField radWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname;

		// Token: 0x04001205 RID: 4613
		private global::AcpBusinessLayer.AcpStringField radWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId;

		// Token: 0x04001206 RID: 4614
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolSeamlessUpdateOutOfBoxExperience;

		// Token: 0x04001207 RID: 4615
		private global::AcpBusinessLayer.AcpStringField radWideLabtoolRCLastJobSetUUID;

		// Token: 0x04001208 RID: 4616
		private global::AcpBusinessLayer.AcpField<bool> radwideLabtoolADPGatingPCIBit;

		// Token: 0x04001209 RID: 4617
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolSupportO3ControlHeadPCIBit;

		// Token: 0x0400120A RID: 4618
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolAnalogWideBandDataPCIBit_44885;
	}
}
