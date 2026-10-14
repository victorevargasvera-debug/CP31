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
	// Token: 0x02000122 RID: 290
	[global::System.Serializable]
	public class AlertTones : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06002A90 RID: 10896 RVA: 0x00297A3C File Offset: 0x00295C3C
		public AlertTones(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x00297A58 File Offset: 0x00295C58
		protected AlertTones(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x00297A70 File Offset: 0x00295C70
		public override void Init()
		{
			int a_ = 1;
			short num = (short)1289760697;
			short num2 = num;
			num = (short)1390358457;
			switch (num2 == num)
			{
			}
			num = (short)1465384960;
			if (num != 0)
			{
			}
			num = (short)1151991808;
			short num3 = num;
			num = (short)1431961601;
			if (num != 0)
			{
			}
			this.radProfAlertTonesAlertTones_A7428 = new global::AcpBusinessLayer.AcpFieldX<bool, bool>(false, new global::Features.Converters.UnpackAndPackAndInvertBooleanField(), this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ飇룉ꏋ꣍量뻑뇓ꓕ곗軙돛냝藟釡ꗣ諥跧飩飫뫭鿯鳱釳藵ꟷ믹쯻쫽㋿㨁", a_), global::CommonResources.AcgResources.ID_ALERTTONES);
			this.radProfAlertTonesAlertTones_A7428.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radProfAlertTonesAlertTones_A7428.DataTransferOrder = 3;
			this.radProfAlertTonesCallAlertToneAutoReset_A7596 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ飇룉ꏋ꣍量뻑뇓ꓕ곗軙돛냝藟釡꟣蟥蓧蛩귫苭闯胱胳ꋵ韷铹駻뿽痿瘁欃吅洇礉椋稍伏匑⌓⌕℗Ⱉ", a_), global::CommonResources.AcgResources.ID_CALLALERTTONEAUTORESET);
			this.radProfAlertTonesCallAlertToneAutoReset_A7596.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radProfAlertTonesCallAlertToneAutoReset_A7596.DataTransferOrder = 18;
			this.radProfAlertTonesLED_A8428 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ飇룉ꏋ꣍量뻑뇓ꓕ곗軙돛냝藟釡꣣ꏥ곧뗩귫훭쓯샱쳳", a_), global::CommonResources.AcgResources.ID_LOWBATTERYLED);
			this.radProfAlertTonesLED_A8428.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radProfAlertTonesLED_A8428.DataTransferOrder = 27;
			this.radProfAlertTonesMuteTonesOperation_A8562 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadProfAlertTonesMuteTonesOperation_A8562LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadProfAlertTonesMuteTonesOperation_A8562LovStrs), this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ飇룉ꏋ꣍量뻑뇓ꓕ곗軙돛냝藟釡ꧣ鏥鳧迩룫臭黯韱蟳맵裷鿹軻鿽瓿欁欃栅圇䬉㐋㬍☏‑", a_), global::CommonResources.AcgResources.ID_MUTETONESOPERATION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadProfAlertTonesMuteTonesOperation_A8562LovStrs);
			this.radProfAlertTonesMuteTonesOperation_A8562.IgnoreOnCompare = true;
			this.radProfAlertTonesMuteTonesOperation_A8562.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radProfAlertTonesMuteTonesOperation_A8562.DataTransferOrder = 29;
			this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ飇룉ꏋ꣍量뻑뇓ꓕ곗軙돛냝藟釡듣觥鿧迩黫믭胯ꇱ釳髵黷껹駻跽瓿䌁栃挅稇縉堋愍縏眑䬓圕‗ⴙⴛ☝", a_), global::CommonResources.AcgResources.ID_POWERUPSELFTESTALERTTONE);
			this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718.DataTransferOrder = 90;
			this.radProfAlertTonesRotaryAlert_A8983 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ飇룉ꏋ꣍量뻑뇓ꓕ곗軙돛냝藟釡뛣觥鳧诩黫韭뇯黱釳蓵賷ꗹ뷻웽㧿㨁㜃", a_), global::CommonResources.AcgResources.ID_ROTARYALERT, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadProfAlertTonesRotaryAlert_A8983LovStrs);
			this.radProfAlertTonesRotaryAlert_A8983.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radProfAlertTonesRotaryAlert_A8983.DataTransferOrder = 35;
			this.radProfAlertTonesStandbyChirpsec_A9179 = new global::AcpBusinessLayer.AcpSimpleRangeField(2, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ飇룉ꏋ꣍量뻑뇓ꓕ곗軙돛냝藟釡럣鋥觧蓩裫賭觯뇱鳳鿵諷諹迻鯽揿崁䔃㼅㤇㴉㔋", a_), global::CommonResources.AcgResources.ID_LOWBATTERYSTANDBYCHIRPSEC, 0, 31, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 30);
			this.radProfAlertTonesStandbyChirpsec_A9179.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radProfAlertTonesStandbyChirpsec_A9179.DataTransferOrder = 93;
			this.radProfAlertTonesStandbyChirpsec_A9179.ShowHexValue = false;
			this.radWideAlertTonesTxChirp_A9523 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ量뻑뇓ꓕ곗軙돛냝藟釡냣黥ꯧ苩藫鳭胯귱뗳쿵췷죹쿻", a_), global::CommonResources.AcgResources.ID_LOWBATTERYTXCHIRP);
			this.radWideAlertTonesTxChirp_A9523.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideAlertTonesTxChirp_A9523.DataTransferOrder = 41;
			this.radWideAlertTonesVolumeAdjustToneOffset_A9656 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ量뻑뇓ꓕ곗軙돛냝藟釡닣觥蓧鿩臫语뇯雱黳菵请軹ꣻ釽滿朁䬃怅渇礉椋稍伏匑ⴓ―ⴗⰙ", a_), global::CommonResources.AcgResources.ID_VOLUMEADJUSTTONEOFFSET);
			this.radWideAlertTonesVolumeAdjustToneOffset_A9656.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideAlertTonesVolumeAdjustToneOffset_A9656.DataTransferOrder = 97;
			this.radWideAlertTonesZeroLevelAudioMute_A9689 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ量뻑뇓ꓕ곗軙돛냝藟釡뻣菥髧藩ꃫ语蛯韱飳럵跷黹闻釽䷿省瀃挅圇䬉㔋㠍⠏⬑", a_), global::CommonResources.AcgResources.ID_ZEROLEVELAUDIOMUTE);
			this.radWideAlertTonesZeroLevelAudioMute_A9689.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideAlertTonesZeroLevelAudioMute_A9689.DataTransferOrder = 98;
			this.radWideAlertTonesScanAlertToneEnable_A19555 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ量뻑뇓ꓕ곗軙돛냝藟釡럣藥觧蓩귫苭闯胱胳ꋵ韷铹駻믽滿持昃樅洇唉䴋㼍⤏✑ℓ⌕", a_), global::CommonResources.AcgResources.ID_SCANALERTTONEENABLE);
			this.radWideAlertTonesScanAlertToneEnable_A19555.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideAlertTonesScanAlertToneEnable_A19555.DataTransferOrder = 101;
			this.radWideAdvancedSmartLowBatteryAlert_A9165 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ量뛑ꋓ럕뛗맙맛뫝돟迡藣铥鳧ꛩ菫駭닯鏱胳苵鷷裹藻뿽泿朁瘃爅圇䬉㔋㼍☏✑", a_), global::CommonResources.AcgResources.ID_SMARTLOWBATTERYALERT, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideAdvancedSmartLowBatteryAlert_A9165LovStrs);
			this.radWideAdvancedSmartLowBatteryAlert_A9165.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideAdvancedSmartLowBatteryAlert_A9165.DataTransferOrder = 37;
			this.radProfAlertTonesNewMuteTonesOperation_A42149 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadProfAlertTonesNewMuteTonesOperation_A42149LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadProfAlertTonesNewMuteTonesOperation_A42149LovStrs), this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ飇룉ꏋ꣍量뻑뇓ꓕ곗軙돛냝藟釡ꫣ菥鿧꟩駫髭闯꛱鯳飵鷷觹돻軽旿瀁攃爅愇攉戋儍儏☑☓✕Ⱇ⌙", a_), global::CommonResources.AcgResources.ID_NEWMUTETONESOPERATION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadProfAlertTonesNewMuteTonesOperation_A42149LovStrs);
			this.radProfAlertTonesNewMuteTonesOperation_A42149.IgnoreOnCompare = true;
			this.radProfAlertTonesNewMuteTonesOperation_A42149.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radProfAlertTonesNewMuteTonesOperation_A42149.DataTransferOrder = 30;
			this.radProfAlertTonesEnhancedMuteTonesOperation_A42150 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ飇룉ꏋ꣍量뻑뇓ꓕ곗軙돛냝藟釡ꇣ裥胧诩苫跭闯雱맳菵賷鿹ꣻ釽滿朁眃䤅砇漉縋漍搏笑笓砕䜗嬙⠛Ⱍᄟᜡᐣ", a_), global::CommonResources.AcgResources.ID_ENHANCEDMUTETONESOPERATION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadProfAlertTonesEnhancedMuteTonesOperation_A42150LovStrs);
			this.radProfAlertTonesEnhancedMuteTonesOperation_A42150.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radProfAlertTonesEnhancedMuteTonesOperation_A42150.DataTransferOrder = 170;
			this.radWideTalkProhibitToneSelection_A42416 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ蓏돑룓뷕裗꣙돛뛝觟胡跣鋥볧藩苫语ꏯ韱飳鏵鯷軹闻釽滿崁䔃㈅㨇㸉㴋㠍", a_), global::CommonResources.AcgResources.ID_TALKPROHIBITTONE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideTalkProhibitToneSelection_A42416LovStrs);
			this.radWideTalkProhibitToneSelection_A42416.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideTalkProhibitToneSelection_A42416.DataTransferOrder = 235;
			this.radWideOutOfRangeToneSelection_A42450 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ鿏ꟑꃓ駕뻗裙뷛냝蟟蟡냣觥蛧迩뿫语鳯韱音苵釷闹鋻ꇽ䇿㘁㘃㈅㴇㨉", a_), global::CommonResources.AcgResources.ID_OUTOFRANGETONE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideOutOfRangeToneSelection_A42450LovStrs);
			this.radWideOutOfRangeToneSelection_A42450.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideOutOfRangeToneSelection_A42450.DataTransferOrder = 237;
			this.radWideAlertTonesVolumeAdjustToneDisable = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ量뻑뇓ꓕ곗軙돛냝藟釡닣觥蓧鿩臫语뇯雱黳菵请軹ꣻ釽滿朁䀃漅笇欉渋戍甏", a_), global::CommonResources.AcgResources.ID_DISABLEVOLADJTONE);
			this.radWideAlertTonesVolumeAdjustToneDisable.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideAlertTonesVolumeAdjustToneDisable.DataTransferOrder = 238;
			this.radioWidePTTWarningTone = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅꇇꗉ鯋ꟍ듏럑蓓苕賗跙뷛곝軟诡諣臥볧藩苫语", a_), global::CommonResources.AcgResources.ID_PTT_WARNING_TONE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadioWidePTTWarningToneLovStrs);
			this.radioWidePTTWarningTone.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radioWidePTTWarningTone.DataTransferOrder = 239;
			this.radWideAlertTonesRSMVolumeSetTone = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ量뻑뇓ꓕ곗軙돛냝藟釡뛣뗥ꗧ볩菫苭藯鿱釳ꗵ鷷軹ꣻ釽滿朁", a_), global::CommonResources.AcgResources.ID_RSMVOLUMESETTONE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideAlertTonesRSMVolumeSetToneLovStrs);
			this.radWideAlertTonesRSMVolumeSetTone.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideAlertTonesRSMVolumeSetTone.DataTransferOrder = 240;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菁ꣃꏅ뫇뻉髍뿏병뇓ꗕ", a_);
			base.Id = 10098;
			base.UIName = global::CommonResources.AcgResources.ID_ALERTTONES;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06002A93 RID: 10899 RVA: 0x0029801C File Offset: 0x0029621C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 9;
			short num = (short)277807158;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_148;
				case 1:
					goto IL_E12;
				case 2:
					goto IL_195;
				case 3:
					this.radWideAdvancedSmartLowBatteryAlert_A9165 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕駗뻙ꫛ뿝軟臡臣若믧蟩跫鳭蓯뻱鯳臵뫷鯹裻諽旿瀁紃䜅搇漉縋稍伏匑ⴓ✕⸗⼙", a_), global::CommonResources.AcgResources.ID_SMARTLOWBATTERYALERT, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideAdvancedSmartLowBatteryAlert_A9165LovStrs);
					this.radWideAdvancedSmartLowBatteryAlert_A9165.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideAdvancedSmartLowBatteryAlert_A9165.DataTransferOrder = 37;
					num = (short)381485057;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.radWideAlertTonesZeroLevelAudioMute_A9689 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕駗뛙맛곝铟뛡诣裥跧駩뛫语苯鷱룳鏵軷鿹郻뿽痿昁洃椅䔇缉砋欍伏匑ⴓ―‗⌙", a_), global::CommonResources.AcgResources.ID_ZEROLEVELAUDIOMUTE);
					this.radWideAlertTonesZeroLevelAudioMute_A9689.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideAlertTonesZeroLevelAudioMute_A9689.DataTransferOrder = 98;
					num = (short)226099202;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_CC2;
				case 6:
					if (producerFields != null)
					{
						num = (short)1661730860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EBD;
				case 7:
					goto IL_542;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕駗뛙맛곝铟뛡诣裥跧駩ꃫ꯭듯귱뗳컵쳷죹쓻", a_)))
					{
						num = (short)1219821627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E1;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕駗뛙맛곝铟뛡诣裥跧駩꿫迭鳯黱뗳髵鷷裹裻꫽濿氁愃䜅紇縉挋對甏愑焓戕䜗嬙⬛⬝᤟ᐡ", a_)))
					{
						num = (short)258932784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_921;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕駗뛙맛곝铟뛡诣裥跧駩뿫髭釯鳱郳铵臷맹铻韽狿爁眃挅欇唉䴋㜍ℏ┑ⴓ", a_)))
					{
						num = (short)548601905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_547;
				case 11:
					this.radWideAlertTonesRSMVolumeSetTone = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕駗뛙맛곝铟뛡诣裥跧駩뻫뷭뷯ꓱ鯳髵跷韹駻귽旿瘁倃椅昇漉", a_), global::CommonResources.AcgResources.ID_RSMVOLUMESETTONE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideAlertTonesRSMVolumeSetToneLovStrs);
					this.radWideAlertTonesRSMVolumeSetTone.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideAlertTonesRSMVolumeSetTone.DataTransferOrder = 240;
					num = (short)1945698311;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕駗뛙맛곝铟뛡诣裥跧駩귫苭闯胱胳ꋵ韷铹駻跽忿䌁㌃㈅㨇㈉", a_)))
					{
						num = (short)1371734048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D68;
				case 13:
					this.radioWidePTTWarningTone = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍맏뷑菓뿕볗뿙賛諝듟뗡藣铥蛧菩苫觭ꓯ鷱髳鏵", a_), global::CommonResources.AcgResources.ID_PTT_WARNING_TONE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadioWidePTTWarningToneLovStrs);
					this.radioWidePTTWarningTone.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radioWidePTTWarningTone.DataTransferOrder = 239;
					num = (short)236060677;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_D68;
				case 15:
					this.radProfAlertTonesRotaryAlert_A8983 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕駗뛙맛곝铟뛡诣裥跧駩뻫臭蓯鏱蛳迵맷雹駻賽瓿崁䔃㸅ㄇ㈉㼋", a_), global::CommonResources.AcgResources.ID_ROTARYALERT, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadProfAlertTonesRotaryAlert_A8983LovStrs);
					this.radProfAlertTonesRotaryAlert_A8983.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radProfAlertTonesRotaryAlert_A8983.DataTransferOrder = 35;
					num = (short)1715601429;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					goto IL_359;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕駗뛙맛곝铟뛡诣裥跧駩ꋫ语蟯뿱至苵鷷껹鏻都旿焁䬃瘅洇砉洋稍礏紑稓䤕夗⸙⸛⼝ᐟᬡ", a_)))
					{
						num = (short)609026077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_148;
				case 18:
					this.radWideAlertTonesVolumeAdjustToneDisable = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕駗뛙맛곝铟뛡诣裥跧駩뫫臭鳯蟱駳鏵맷黹電诽珿瘁倃椅昇漉䠋服挏猑瘓稕紗", a_), global::CommonResources.AcgResources.ID_VOLUMEADJUSTTONEOFFSET);
					this.radWideAlertTonesVolumeAdjustToneDisable.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideAlertTonesVolumeAdjustToneDisable.DataTransferOrder = 238;
					num = (short)264503312;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					goto IL_3FB;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕駗뛙맛곝铟뛡诣裥跧駩뿫跭釯鳱뗳髵鷷裹裻꫽濿氁愃䌅昇欉渋戍甏䴑唓✕℗⼙⤛⬝", a_)))
					{
						num = (short)578093102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AAE;
				case 21:
					goto IL_9BD;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕駗뛙맛곝铟뛡诣裥跧駩볫臭蟯韱蛳ꏵ裷꧹駻鋽替嘁愃甅簇䬉怋欍戏昑䀓礕瘗缙䌛弝᠟ᔡᔣḥ", a_)))
					{
						num = (short)1920466978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_69B;
				case 23:
					goto IL_C75;
				case 24:
					goto IL_6EA;
				case 25:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕韗꿙꣛針蛟냡藣裥迧迩룫臭黯韱ꟳ鏵铷鿹鿻諽槿洁樃夅䤇㸉㸋㨍┏∑", a_)))
					{
						num = (short)1350369327;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6EA;
				case 26:
					goto IL_A60;
				case 27:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕駗뛙맛곝铟뛡诣裥跧駩뻫뷭뷯ꓱ鯳髵跷韹駻귽旿瘁倃椅昇漉", a_)))
					{
						num = (short)602865675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EBD;
				case 28:
					goto IL_547;
				case 29:
					this.radProfAlertTonesNewMuteTonesOperation_A42149 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadProfAlertTonesNewMuteTonesOperation_A42149LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadProfAlertTonesNewMuteTonesOperation_A42149LovStrs), this, global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕駗뛙맛곝铟뛡诣裥跧駩ꋫ语蟯뿱至苵鷷껹鏻都旿焁䬃瘅洇砉洋稍礏紑稓䤕夗⸙⸛⼝ᐟᬡ", a_), global::CommonResources.AcgResources.ID_NEWMUTETONESOPERATION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadProfAlertTonesNewMuteTonesOperation_A42149LovStrs);
					this.radProfAlertTonesNewMuteTonesOperation_A42149.IgnoreOnCompare = true;
					this.radProfAlertTonesNewMuteTonesOperation_A42149.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radProfAlertTonesNewMuteTonesOperation_A42149.DataTransferOrder = 30;
					num = (short)802488320;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕駗뛙맛곝铟뛡诣裥跧駩뛫语苯鷱룳鏵軷鿹郻뿽痿昁洃椅䔇缉砋欍伏匑ⴓ―‗⌙", a_)))
					{
						num = (short)164298756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_195;
				case 31:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕駗뛙맛곝铟뛡诣裥跧駩뫫臭鳯蟱駳鏵맷黹電诽珿瘁倃椅昇漉䌋栍瘏愑焓戕䜗嬙┛⠝ᔟᐡ", a_)))
					{
						num = (short)508624937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C75;
				case 32:
					this.radProfAlertTonesAlertTones_A7428 = new global::AcpBusinessLayer.AcpFieldX<bool, bool>(false, new global::Features.Converters.UnpackAndPackAndInvertBooleanField(), this, global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕駗뛙맛곝铟뛡诣裥跧駩귫苭闯胱胳ꋵ韷铹駻跽忿䌁㌃㈅㨇㈉", a_), global::CommonResources.AcgResources.ID_ALERTTONES);
					this.radProfAlertTonesAlertTones_A7428.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radProfAlertTonesAlertTones_A7428.DataTransferOrder = 3;
					num = (short)1010761742;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
					goto IL_69B;
				case 34:
					IL_48D:
					this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕駗뛙맛곝铟뛡诣裥跧駩볫臭蟯韱蛳ꏵ裷꧹駻鋽替嘁愃甅簇䬉怋欍戏昑䀓礕瘗缙䌛弝᠟ᔡᔣḥ", a_), global::CommonResources.AcgResources.ID_POWERUPSELFTESTALERTTONE);
					this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718.DataTransferOrder = 90;
					num = (short)1116799009;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					goto IL_AAE;
				case 36:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕駗뻙ꫛ뿝軟臡臣若믧蟩跫鳭蓯뻱鯳臵뫷鯹裻諽旿瀁紃䜅搇漉縋稍伏匑ⴓ✕⸗⼙", a_)))
					{
						num = (short)1912209411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E12;
				case 37:
					this.radProfAlertTonesMuteTonesOperation_A8562 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadProfAlertTonesMuteTonesOperation_A8562LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadProfAlertTonesMuteTonesOperation_A8562LovStrs), this, global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕駗뛙맛곝铟뛡诣裥跧駩ꇫ鯭蓯韱ꃳ駵雷鿹迻뇽烿朁瘃朅簇按挋怍伏匑Ⱃ⌕⸗⠙", a_), global::CommonResources.AcgResources.ID_MUTETONESOPERATION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadProfAlertTonesMuteTonesOperation_A8562LovStrs);
					this.radProfAlertTonesMuteTonesOperation_A8562.IgnoreOnCompare = true;
					this.radProfAlertTonesMuteTonesOperation_A8562.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radProfAlertTonesMuteTonesOperation_A8562.DataTransferOrder = 29;
					num = (short)2018639891;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					goto IL_921;
				case 39:
					this.radProfAlertTonesEnhancedMuteTonesOperation_A42150 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕駗뛙맛곝铟뛡诣裥跧駩ꧫ胭飯鏱髳闵鷷黹뇻诽瓿朁倃椅昇漉缋䄍怏眑易眕気猙猛瀝缟挡ဣᐥᤧἩᰫ", a_), global::CommonResources.AcgResources.ID_ENHANCEDMUTETONESOPERATION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadProfAlertTonesEnhancedMuteTonesOperation_A42150LovStrs);
					this.radProfAlertTonesEnhancedMuteTonesOperation_A42150.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radProfAlertTonesEnhancedMuteTonesOperation_A42150.DataTransferOrder = 170;
					num = (short)1538588722;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 40:
					this.radWideAlertTonesTxChirp_A9523 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕駗뛙맛곝铟뛡诣裥跧駩룫雭돯髱鷳蓵裷ꗹ뷻쟽㗿、㜃", a_), global::CommonResources.AcgResources.ID_LOWBATTERYTXCHIRP);
					this.radWideAlertTonesTxChirp_A9523.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideAlertTonesTxChirp_A9523.DataTransferOrder = 41;
					num = (short)469565466;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 41:
					this.radWideAlertTonesVolumeAdjustToneOffset_A9656 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕駗뛙맛곝铟뛡诣裥跧駩뫫臭鳯蟱駳鏵맷黹電诽珿瘁倃椅昇漉䌋栍瘏愑焓戕䜗嬙┛⠝ᔟᐡ", a_), global::CommonResources.AcgResources.ID_VOLUMEADJUSTTONEOFFSET);
					this.radWideAlertTonesVolumeAdjustToneOffset_A9656.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideAlertTonesVolumeAdjustToneOffset_A9656.DataTransferOrder = 97;
					num = (short)2017722391;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 42:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕駗뛙맛곝铟뛡诣裥跧駩ꧫ胭飯鏱髳闵鷷黹뇻诽瓿朁倃椅昇漉缋䄍怏眑易眕気猙猛瀝缟挡ဣᐥᤧἩᰫ", a_)))
					{
						num = (short)712376359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_737;
				case 43:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕駗뛙맛곝铟뛡诣裥跧駩ꇫ鯭蓯韱ꃳ駵雷鿹迻뇽烿朁瘃朅簇按挋怍伏匑Ⱃ⌕⸗⠙", a_)))
					{
						num = (short)273874981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3FB;
				case 44:
					num = (short)717094924;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 45:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍맏뷑菓뿕볗뿙賛諝듟뗡藣铥蛧菩苫觭ꓯ鷱髳鏵", a_)))
					{
						num = (short)1700200461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CC2;
				case 46:
					this.radWideAlertTonesScanAlertToneEnable_A19555 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕駗뛙맛곝铟뛡诣裥跧駩뿫跭釯鳱뗳髵鷷裹裻꫽濿氁愃䌅昇欉渋戍甏䴑唓✕℗⼙⤛⬝", a_), global::CommonResources.AcgResources.ID_SCANALERTTONEENABLE);
					this.radWideAlertTonesScanAlertToneEnable_A19555.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideAlertTonesScanAlertToneEnable_A19555.DataTransferOrder = 101;
					num = (short)312672291;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 47:
					this.radWideOutOfRangeToneSelection_A42450 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕韗꿙꣛針蛟냡藣裥迧迩룫臭黯韱ꟳ鏵铷鿹鿻諽槿洁樃夅䤇㸉㸋㨍┏∑", a_), global::CommonResources.AcgResources.ID_OUTOFRANGETONE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideOutOfRangeToneSelection_A42450LovStrs);
					this.radWideOutOfRangeToneSelection_A42450.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideOutOfRangeToneSelection_A42450.DataTransferOrder = 237;
					num = (short)1027145752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 48:
					this.radProfAlertTonesCallAlertToneAutoReset_A7596 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕駗뛙맛곝铟뛡诣裥跧駩꿫迭鳯黱뗳髵鷷裹裻꫽濿氁愃䜅紇縉挋對甏愑焓戕䜗嬙⬛⬝᤟ᐡ", a_), global::CommonResources.AcgResources.ID_CALLALERTTONEAUTORESET);
					this.radProfAlertTonesCallAlertToneAutoReset_A7596.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radProfAlertTonesCallAlertToneAutoReset_A7596.DataTransferOrder = 18;
					num = (short)95813670;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 49:
					this.radProfAlertTonesStandbyChirpsec_A9179 = new global::AcpBusinessLayer.AcpSimpleRangeField(2, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕駗뛙맛곝铟뛡诣裥跧駩뿫髭釯鳱郳铵臷맹铻韽狿爁眃挅欇唉䴋㜍ℏ┑ⴓ", a_), global::CommonResources.AcgResources.ID_LOWBATTERYSTANDBYCHIRPSEC, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 30);
					this.radProfAlertTonesStandbyChirpsec_A9179.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radProfAlertTonesStandbyChirpsec_A9179.DataTransferOrder = 93;
					this.radProfAlertTonesStandbyChirpsec_A9179.ShowHexValue = false;
					num = (short)1580990492;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 50:
					goto IL_737;
				case 51:
					num = (short)1631125510;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 52:
					goto IL_96F;
				case 53:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕駗뛙맛곝铟뛡诣裥跧駩룫雭돯髱鷳蓵裷ꗹ뷻쟽㗿、㜃", a_)))
					{
						num = (short)1123614760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A60;
				case 54:
					switch (0)
					{
					case 0:
						goto IL_122;
					}
					continue;
				case 55:
					goto IL_1E1;
				case 56:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕駗뛙맛곝铟뛡诣裥跧駩뻫臭蓯鏱蛳迵맷雹駻賽瓿崁䔃㸅ㄇ㈉㼋", a_)))
					{
						num = (short)1079050255;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9BD;
				case 57:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕賗믙냛뗝냟郡诣軥臧裩藫髭ꓯ鷱髳鏵꯷鿹郻鯽揿瘁洃椅昇唉䴋㨍∏☑┓―", a_)))
					{
						num = (short)934543420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_96F;
				case 58:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕駗뛙맛곝铟뛡诣裥跧駩뫫臭鳯蟱駳鏵맷黹電诽珿瘁倃椅昇漉䠋服挏猑瘓稕紗", a_)))
					{
						num = (short)1128464402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_359;
				case 59:
					this.radProfAlertTonesLED_A8428 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍胏ꃑ믓냕駗뛙맛곝铟뛡诣裥跧駩ꃫ꯭듯귱뗳컵쳷죹쓻", a_), global::CommonResources.AcgResources.ID_LOWBATTERYLED);
					this.radProfAlertTonesLED_A8428.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radProfAlertTonesLED_A8428.DataTransferOrder = 27;
					num = (short)1940979767;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 60:
				{
					num = (short)1275461632;
					short num3 = num;
					this.radWideTalkProhibitToneSelection_A42416 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕賗믙냛뗝냟郡诣軥臧裩藫髭ꓯ鷱髳鏵꯷鿹郻鯽揿瘁洃椅昇唉䴋㨍∏☑┓―", a_), global::CommonResources.AcgResources.ID_TALKPROHIBITTONE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideTalkProhibitToneSelection_A42416LovStrs);
					this.radWideTalkProhibitToneSelection_A42416.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideTalkProhibitToneSelection_A42416.DataTransferOrder = 235;
					num = (short)809304116;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_122:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)380174387;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_148:
				num = (short)1371537450;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_195:
				num = (short)1202847764;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E1:
				num = (short)1564672043;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_359:
				num = (short)738721837;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3FB:
				num = (short)1565812400;
				short num4 = num;
				num = (short)2111202992;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_48D;
				default:
					num = (short)74121216;
					if (num != 0)
					{
					}
					num = (short)1275396118;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_547:
				num = (short)1976500277;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_69B:
				num = (short)14286904;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6EA:
				num = (short)1095565370;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_737:
				num = (short)35258425;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_921:
				num = (short)1401946120;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_96F:
				num = (short)58916889;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9BD:
				num = (short)1762197514;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A60:
				num = (short)350486559;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AAE:
				num = (short)719323137;
				if (num != 0)
				{
				}
				num = (short)2018639908;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C75:
				num = (short)240189470;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CC2:
				num = (short)1005584411;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D68:
				num = (short)288030729;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E12:
				num = (short)576323601;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_542:
			IL_EBD:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("诉ꃋꯍꋏꛑ苕럗듙맛귝", a_);
			base.Id = 10098;
			base.UIName = global::CommonResources.AcgResources.ID_ALERTTONES;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06002A94 RID: 10900 RVA: 0x00298F18 File Offset: 0x00297118
		public override void PopulateReferences()
		{
			short num = (short)582156288;
			short num2 = num;
			num = (short)1442971649;
			if (num != 0)
			{
			}
			num = (short)1495400809;
			short num3 = num;
			num = (short)2144338281;
			switch (num3 == num)
			{
			}
			num = (short)1773731840;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002A95 RID: 10901 RVA: 0x00298FC0 File Offset: 0x002971C0
		public override void DropReferences()
		{
			short num = (short)1897725952;
			short num2 = num;
			num = (short)35631734;
			short num3 = num;
			num = (short)436712054;
			switch (num3 == num)
			{
			}
			num = (short)148766721;
			if (num != 0)
			{
			}
			num = (short)1692467200;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002A96 RID: 10902 RVA: 0x00299068 File Offset: 0x00297268
		public override void SetConstraints()
		{
			short num = (short)487456768;
			short num2 = num;
			num = (short)1715538142;
			short num3 = num;
			num = (short)807995614;
			switch (num3 == num)
			{
			}
			num = (short)585629696;
			if (num != 0)
			{
			}
			num = (short)656211969;
			if (num != 0)
			{
			}
			this.radProfAlertTonesMuteTonesOperation_A8562.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConLabtoolVisibleOnly);
			this.radProfAlertTonesMuteTonesOperation_A8562.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConValueSetterAttachedOldMuteTones);
			this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConAlertToneInhIsEnabled);
			this.radWideAlertTonesVolumeAdjustToneOffset_A9656.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConAlertToneInhIsEnabled);
			this.radWideAlertTonesScanAlertToneEnable_A19555.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConAlertToneInhIsEnabled);
			this.radProfAlertTonesNewMuteTonesOperation_A42149.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConLabtoolVisibleOnly);
			this.radProfAlertTonesNewMuteTonesOperation_A42149.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConValueSetterAttachedNewMuteTones);
			this.radProfAlertTonesEnhancedMuteTonesOperation_A42150.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConValueSetterAttachedEnhancedMuteTones);
			this.radWideAlertTonesVolumeAdjustToneDisable.IsApplicable = null;
			this.radProfAlertTonesAlertTones_A7428.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsApplicableNfpaCompliant);
		}

		// Token: 0x06002A97 RID: 10903 RVA: 0x002991F0 File Offset: 0x002973F0
		public override void SetupDependencies()
		{
			short num = (short)1418133504;
			short num2 = num;
			num = (short)1828148650;
			short num3 = num;
			num = (short)32658858;
			switch (num3 == num)
			{
			}
			num = (short)1339621377;
			if (num != 0)
			{
			}
			num = (short)1825832960;
			if (num != 0)
			{
			}
			this.radProfAlertTonesNewMuteTonesOperation_A42149.AddDependentObject(this.radProfAlertTonesMuteTonesOperation_A8562);
			this.radProfAlertTonesEnhancedMuteTonesOperation_A42150.AddDependentObject(this.radProfAlertTonesMuteTonesOperation_A8562);
			this.radProfAlertTonesAlertTones_A7428.AddDependentObject(this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718);
			this.radProfAlertTonesAlertTones_A7428.AddDependentObject(this.radWideAlertTonesVolumeAdjustToneOffset_A9656);
			this.radProfAlertTonesAlertTones_A7428.AddDependentObject(this.radWideAlertTonesScanAlertToneEnable_A19555);
			this.radProfAlertTonesAlertTones_A7428.AddDependentObject(this.radWideAlertTonesVolumeAdjustToneDisable);
			this.radProfAlertTonesMuteTonesOperation_A8562.AddDependentObject(this.radProfAlertTonesNewMuteTonesOperation_A42149);
			this.radProfAlertTonesEnhancedMuteTonesOperation_A42150.AddDependentObject(this.radProfAlertTonesNewMuteTonesOperation_A42149);
			this.radProfAlertTonesMuteTonesOperation_A8562.AddDependentObject(this.radProfAlertTonesEnhancedMuteTonesOperation_A42150);
			this.radProfAlertTonesNewMuteTonesOperation_A42149.AddDependentObject(this.radProfAlertTonesEnhancedMuteTonesOperation_A42150);
		}

		// Token: 0x17001545 RID: 5445
		// (get) Token: 0x06002A98 RID: 10904 RVA: 0x0029934C File Offset: 0x0029754C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1549860864;
				short num2 = num;
				num = (short)1900419576;
				short num3 = num;
				num = (short)325130744;
				switch (num3 == num)
				{
				}
				num = (short)490733568;
				if (num != 0)
				{
				}
				num = (short)1008009217;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17001546 RID: 5446
		// (get) Token: 0x06002A99 RID: 10905 RVA: 0x00299400 File Offset: 0x00297600
		// (set) Token: 0x06002A9A RID: 10906 RVA: 0x002994B4 File Offset: 0x002976B4
		public bool RadProfAlertTonesAlertTones_A7428Value
		{
			get
			{
				short num = (short)1230045184;
				short num2 = num;
				num = (short)1247725958;
				short num3 = num;
				num = (short)2079312262;
				switch (num3 == num)
				{
				}
				num = (short)653787137;
				if (num != 0)
				{
				}
				num = (short)1082720256;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesAlertTones_A7428.Value;
			}
			set
			{
				short num = (short)2021261312;
				short num2 = num;
				num = (short)539562753;
				short num3 = num;
				num = (short)35328769;
				switch (num3 == num)
				{
				}
				num = (short)975831040;
				if (num != 0)
				{
				}
				num = (short)2021720065;
				if (num != 0)
				{
				}
				this.radProfAlertTonesAlertTones_A7428.Value = value;
			}
		}

		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x06002A9B RID: 10907 RVA: 0x0029956C File Offset: 0x0029776C
		public global::AcpBusinessLayer.AcpFieldX<bool, bool> RadProfAlertTonesAlertTones_A7428
		{
			get
			{
				short num = (short)1729363968;
				short num2 = num;
				num = (short)373855200;
				short num3 = num;
				num = (short)1922012128;
				switch (num3 == num)
				{
				}
				num = (short)1970798593;
				if (num != 0)
				{
				}
				num = (short)2078146560;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesAlertTones_A7428;
			}
		}

		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x06002A9C RID: 10908 RVA: 0x00299620 File Offset: 0x00297820
		// (set) Token: 0x06002A9D RID: 10909 RVA: 0x002996D8 File Offset: 0x002978D8
		public bool RadProfAlertTonesAlertTones_A7428_UIValue
		{
			get
			{
				short num = (short)613679104;
				short num2 = num;
				num = (short)258636782;
				short num3 = num;
				num = (short)214072302;
				switch (num3 == num)
				{
				}
				num = (short)285343744;
				if (num != 0)
				{
				}
				num = (short)1192361985;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesAlertTones_A7428.UIValue;
			}
			set
			{
				short num = (short)849543168;
				short num2 = num;
				num = (short)287647889;
				short num3 = num;
				num = (short)1177561233;
				switch (num3 == num)
				{
				}
				num = (short)1221984257;
				if (num != 0)
				{
				}
				num = (short)1882521600;
				if (num != 0)
				{
				}
				this.radProfAlertTonesAlertTones_A7428.UIValue = value;
			}
		}

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x06002A9E RID: 10910 RVA: 0x0029978C File Offset: 0x0029798C
		// (set) Token: 0x06002A9F RID: 10911 RVA: 0x00299840 File Offset: 0x00297A40
		public bool RadProfAlertTonesAlertTones_A7428_Applicable
		{
			get
			{
				short num = (short)1400111104;
				short num2 = num;
				num = (short)77610673;
				short num3 = num;
				num = (short)1836727985;
				switch (num3 == num)
				{
				}
				num = (short)255328257;
				if (num != 0)
				{
				}
				num = (short)1586036736;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesAlertTones_A7428.Applicable;
			}
			set
			{
				short num = (short)1699676160;
				short num2 = num;
				num = (short)670202359;
				short num3 = num;
				num = (short)1909488119;
				switch (num3 == num)
				{
				}
				num = (short)871563265;
				if (num != 0)
				{
				}
				num = (short)403898368;
				if (num != 0)
				{
				}
				this.radProfAlertTonesAlertTones_A7428.Applicable = value;
			}
		}

		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x06002AA0 RID: 10912 RVA: 0x002998F8 File Offset: 0x00297AF8
		// (set) Token: 0x06002AA1 RID: 10913 RVA: 0x002999AC File Offset: 0x00297BAC
		public bool RadProfAlertTonesAlertTones_A7428_Valid
		{
			get
			{
				short num = (short)1882193920;
				short num2 = num;
				num = (short)969002334;
				short num3 = num;
				num = (short)752340318;
				switch (num3 == num)
				{
				}
				num = (short)1062666241;
				if (num != 0)
				{
				}
				num = (short)1637810176;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesAlertTones_A7428.Valid;
			}
			set
			{
				short num = (short)2001534976;
				short num2 = num;
				num = (short)870600403;
				short num3 = num;
				num = (short)1179078355;
				switch (num3 == num)
				{
				}
				num = (short)671940609;
				if (num != 0)
				{
				}
				num = (short)1405353984;
				if (num != 0)
				{
				}
				this.radProfAlertTonesAlertTones_A7428.Valid = value;
			}
		}

		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x06002AA2 RID: 10914 RVA: 0x00299A60 File Offset: 0x00297C60
		// (set) Token: 0x06002AA3 RID: 10915 RVA: 0x00299B14 File Offset: 0x00297D14
		public bool RadProfAlertTonesAlertTones_A7428_Visible
		{
			get
			{
				short num = (short)1192886272;
				short num2 = num;
				num = (short)691830899;
				short num3 = num;
				num = (short)198279283;
				switch (num3 == num)
				{
				}
				num = (short)1670053889;
				if (num != 0)
				{
				}
				num = (short)1636237312;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesAlertTones_A7428.Visible;
			}
			set
			{
				short num = (short)247267328;
				short num2 = num;
				num = (short)504627201;
				if (num != 0)
				{
				}
				num = (short)975286654;
				short num3 = num;
				num = (short)1741992318;
				switch (num3 == num)
				{
				}
				num = (short)280363008;
				if (num != 0)
				{
				}
				this.radProfAlertTonesAlertTones_A7428.Visible = value;
			}
		}

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x06002AA4 RID: 10916 RVA: 0x00299BCC File Offset: 0x00297DCC
		// (set) Token: 0x06002AA5 RID: 10917 RVA: 0x00299C80 File Offset: 0x00297E80
		public bool RadProfAlertTonesAlertTones_A7428_Editable
		{
			get
			{
				short num = (short)294846464;
				short num2 = num;
				num = (short)1605857015;
				short num3 = num;
				num = (short)1297772279;
				switch (num3 == num)
				{
				}
				num = (short)420151297;
				if (num != 0)
				{
				}
				num = (short)980811776;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesAlertTones_A7428.Editable;
			}
			set
			{
				short num = (short)1390280704;
				short num2 = num;
				num = (short)1339212250;
				short num3 = num;
				num = (short)1312735706;
				switch (num3 == num)
				{
				}
				num = (short)1801781249;
				if (num != 0)
				{
				}
				num = (short)1683161088;
				if (num != 0)
				{
				}
				this.radProfAlertTonesAlertTones_A7428.Editable = value;
			}
		}

		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x06002AA6 RID: 10918 RVA: 0x00299D38 File Offset: 0x00297F38
		internal string RadProfAlertTonesAlertTones_A7428_UILabel
		{
			get
			{
				short num = (short)1213857792;
				short num2 = num;
				num = (short)1710613479;
				short num3 = num;
				num = (short)761127911;
				switch (num3 == num)
				{
				}
				num = (short)1469317121;
				if (num != 0)
				{
				}
				num = (short)1803878400;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesAlertTones_A7428.UIName;
			}
		}

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x06002AA7 RID: 10919 RVA: 0x00299DF0 File Offset: 0x00297FF0
		// (set) Token: 0x06002AA8 RID: 10920 RVA: 0x00299EA4 File Offset: 0x002980A4
		internal bool RadProfAlertTonesAlertTones_A7428_HiddenStatic
		{
			get
			{
				short num = (short)151257088;
				short num2 = num;
				num = (short)1372025303;
				short num3 = num;
				num = (short)396390871;
				switch (num3 == num)
				{
				}
				num = (short)1145503744;
				if (num != 0)
				{
				}
				num = (short)1937571841;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesAlertTones_A7428.HiddenStatic;
			}
			set
			{
				short num = (short)519962624;
				short num2 = num;
				num = (short)1422510466;
				short num3 = num;
				num = (short)832948610;
				switch (num3 == num)
				{
				}
				num = (short)152764417;
				if (num != 0)
				{
				}
				num = (short)665452544;
				if (num != 0)
				{
				}
				this.radProfAlertTonesAlertTones_A7428.HiddenStatic = value;
			}
		}

		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x06002AA9 RID: 10921 RVA: 0x00299F58 File Offset: 0x00298158
		// (set) Token: 0x06002AAA RID: 10922 RVA: 0x0029A00C File Offset: 0x0029820C
		internal bool RadProfAlertTonesAlertTones_A7428_HiddenDynamic
		{
			get
			{
				short num = (short)877461504;
				short num2 = num;
				num = (short)321127250;
				short num3 = num;
				num = (short)1915224914;
				switch (num3 == num)
				{
				}
				num = (short)1783431168;
				if (num != 0)
				{
				}
				num = (short)511574017;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesAlertTones_A7428.HiddenDynamic;
			}
			set
			{
				short num = (short)1405943808;
				short num2 = num;
				num = (short)1940007911;
				short num3 = num;
				num = (short)1554918375;
				switch (num3 == num)
				{
				}
				num = (short)1745354753;
				if (num != 0)
				{
				}
				num = (short)1361903616;
				if (num != 0)
				{
				}
				this.radProfAlertTonesAlertTones_A7428.HiddenDynamic = value;
			}
		}

		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x06002AAB RID: 10923 RVA: 0x0029A0C0 File Offset: 0x002982C0
		public bool RadProfAlertTonesAlertTones_A7428_HasDiffs
		{
			get
			{
				short num = (short)460390400;
				short num2 = num;
				num = (short)224264193;
				if (num != 0)
				{
				}
				num = (short)514158950;
				short num3 = num;
				num = (short)3109222;
				switch (num3 == num)
				{
				}
				num = (short)1325400064;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesAlertTones_A7428._HasDiffs;
			}
		}

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x06002AAC RID: 10924 RVA: 0x0029A174 File Offset: 0x00298374
		// (set) Token: 0x06002AAD RID: 10925 RVA: 0x0029A228 File Offset: 0x00298428
		public bool RadProfAlertTonesCallAlertToneAutoReset_A7596Value
		{
			get
			{
				short num = (short)226820096;
				short num2 = num;
				num = (short)412878511;
				short num3 = num;
				num = (short)1738081967;
				switch (num3 == num)
				{
				}
				num = (short)799473664;
				if (num != 0)
				{
				}
				num = (short)1014497281;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesCallAlertToneAutoReset_A7596.Value;
			}
			set
			{
				short num = (short)131792896;
				short num2 = num;
				num = (short)1095976953;
				short num3 = num;
				num = (short)1069828089;
				switch (num3 == num)
				{
				}
				num = (short)484835329;
				if (num != 0)
				{
				}
				num = (short)1128857600;
				if (num != 0)
				{
				}
				this.radProfAlertTonesCallAlertToneAutoReset_A7596.Value = value;
			}
		}

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x06002AAE RID: 10926 RVA: 0x0029A2E0 File Offset: 0x002984E0
		public global::AcpBusinessLayer.AcpField<bool> RadProfAlertTonesCallAlertToneAutoReset_A7596
		{
			get
			{
				short num = (short)1704926088;
				short num2 = num;
				num = (short)367729544;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1711341568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)812646401;
				if (num != 0)
				{
				}
				num = (short)659750912;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesCallAlertToneAutoReset_A7596;
			}
		}

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x06002AAF RID: 10927 RVA: 0x0029A38C File Offset: 0x0029858C
		// (set) Token: 0x06002AB0 RID: 10928 RVA: 0x0029A444 File Offset: 0x00298644
		public bool RadProfAlertTonesCallAlertToneAutoReset_A7596_UIValue
		{
			get
			{
				short num = (short)667216194;
				short num2 = num;
				num = (short)148367682;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1130364928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)868483072;
				if (num != 0)
				{
				}
				num = (short)1471741953;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesCallAlertToneAutoReset_A7596.Value;
			}
			set
			{
				short num = (short)1888207935;
				short num2 = num;
				num = (short)1126220863;
				switch (num2 == num)
				{
				default:
				{
					num = (short)417267712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1407188993;
				if (num != 0)
				{
				}
				num = (short)179765248;
				if (num != 0)
				{
				}
				this.radProfAlertTonesCallAlertToneAutoReset_A7596.Value = value;
			}
		}

		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x06002AB1 RID: 10929 RVA: 0x0029A4FC File Offset: 0x002986FC
		// (set) Token: 0x06002AB2 RID: 10930 RVA: 0x0029A5B0 File Offset: 0x002987B0
		public bool RadProfAlertTonesCallAlertToneAutoReset_A7596_Applicable
		{
			get
			{
				short num = (short)1718353348;
				short num2 = num;
				num = (short)766115268;
				switch (num2 == num)
				{
				default:
				{
					num = (short)422051840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)262209536;
				if (num != 0)
				{
				}
				num = (short)1947140097;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesCallAlertToneAutoReset_A7596.Applicable;
			}
			set
			{
				short num = (short)1847240567;
				short num2 = num;
				num = (short)1558685559;
				switch (num2 == num)
				{
				default:
				{
					num = (short)380043264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)825556993;
				if (num != 0)
				{
				}
				num = (short)1389297664;
				if (num != 0)
				{
				}
				this.radProfAlertTonesCallAlertToneAutoReset_A7596.Applicable = value;
			}
		}

		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x06002AB3 RID: 10931 RVA: 0x0029A664 File Offset: 0x00298864
		// (set) Token: 0x06002AB4 RID: 10932 RVA: 0x0029A71C File Offset: 0x0029891C
		public bool RadProfAlertTonesCallAlertToneAutoReset_A7596_Valid
		{
			get
			{
				short num = (short)1227227607;
				short num2 = num;
				num = (short)469238231;
				switch (num2 == num)
				{
				default:
				{
					num = (short)772210688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)922484736;
				if (num != 0)
				{
				}
				num = (short)1575616513;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesCallAlertToneAutoReset_A7596.Valid;
			}
			set
			{
				short num = (short)1519125567;
				short num2 = num;
				num = (short)21169215;
				switch (num2 == num)
				{
				default:
				{
					num = (short)176553984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1940717568;
				if (num != 0)
				{
				}
				num = (short)1753415681;
				if (num != 0)
				{
				}
				this.radProfAlertTonesCallAlertToneAutoReset_A7596.Valid = value;
			}
		}

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x06002AB5 RID: 10933 RVA: 0x0029A7D0 File Offset: 0x002989D0
		// (set) Token: 0x06002AB6 RID: 10934 RVA: 0x0029A884 File Offset: 0x00298A84
		public bool RadProfAlertTonesCallAlertToneAutoReset_A7596_Visible
		{
			get
			{
				short num = (short)94908337;
				short num2 = num;
				num = (short)2145857457;
				switch (num2 == num)
				{
				default:
				{
					num = (short)627900416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)795738113;
				if (num != 0)
				{
				}
				num = (short)1774977024;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesCallAlertToneAutoReset_A7596.Visible;
			}
			set
			{
				short num = (short)1367015425;
				if (num != 0)
				{
				}
				num = (short)1103101952;
				short num2 = num;
				num = (short)1135617860;
				short num3 = num;
				num = (short)13707076;
				switch (num3 == num)
				{
				}
				num = (short)1640300544;
				if (num != 0)
				{
				}
				this.radProfAlertTonesCallAlertToneAutoReset_A7596.Visible = value;
			}
		}

		// Token: 0x17001557 RID: 5463
		// (get) Token: 0x06002AB7 RID: 10935 RVA: 0x0029A938 File Offset: 0x00298B38
		// (set) Token: 0x06002AB8 RID: 10936 RVA: 0x0029A9EC File Offset: 0x00298BEC
		public bool RadProfAlertTonesCallAlertToneAutoReset_A7596_Editable
		{
			get
			{
				short num = (short)219770722;
				short num2 = num;
				num = (short)1793159010;
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
				num = (short)2020409345;
				if (num != 0)
				{
				}
				num = (short)1206583296;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesCallAlertToneAutoReset_A7596.Editable;
			}
			set
			{
				short num = (short)2007303095;
				short num2 = num;
				num = (short)1874789303;
				switch (num2 == num)
				{
				default:
				{
					num = (short)691011584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1260191745;
				if (num != 0)
				{
				}
				num = (short)1357643776;
				if (num != 0)
				{
				}
				this.radProfAlertTonesCallAlertToneAutoReset_A7596.Editable = value;
			}
		}

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x06002AB9 RID: 10937 RVA: 0x0029AAA0 File Offset: 0x00298CA0
		internal string RadProfAlertTonesCallAlertToneAutoReset_A7596_UILabel
		{
			get
			{
				short num = (short)164896234;
				short num2 = num;
				num = (short)1255742954;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1418788864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)846987265;
				if (num != 0)
				{
				}
				num = (short)167837696;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesCallAlertToneAutoReset_A7596.UIName;
			}
		}

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x06002ABA RID: 10938 RVA: 0x0029AB54 File Offset: 0x00298D54
		// (set) Token: 0x06002ABB RID: 10939 RVA: 0x0029AC10 File Offset: 0x00298E10
		internal bool RadProfAlertTonesCallAlertToneAutoReset_A7596_HiddenStatic
		{
			get
			{
				short num = (short)1939789353;
				short num2 = num;
				num = (short)2027673129;
				switch (num2 == num)
				{
				default:
				{
					num = (short)443219968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2110652417;
				if (num != 0)
				{
				}
				num = (short)1752825856;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesCallAlertToneAutoReset_A7596.HiddenStatic;
			}
			set
			{
				short num = (short)559239421;
				short num2 = num;
				num = (short)662982909;
				switch (num2 == num)
				{
				default:
				{
					num = (short)3342336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1535705088;
				if (num != 0)
				{
				}
				num = (short)557776897;
				if (num != 0)
				{
				}
				this.radProfAlertTonesCallAlertToneAutoReset_A7596.HiddenStatic = value;
			}
		}

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x06002ABC RID: 10940 RVA: 0x0029ACC8 File Offset: 0x00298EC8
		// (set) Token: 0x06002ABD RID: 10941 RVA: 0x0029AD7C File Offset: 0x00298F7C
		internal bool RadProfAlertTonesCallAlertToneAutoReset_A7596_HiddenDynamic
		{
			get
			{
				short num = (short)169345025;
				if (num != 0)
				{
				}
				num = (short)1017643008;
				short num2 = num;
				num = (short)1490970331;
				short num3 = num;
				num = (short)488990427;
				switch (num3 == num)
				{
				}
				num = (short)1840185344;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesCallAlertToneAutoReset_A7596.HiddenDynamic;
			}
			set
			{
				short num = (short)110166017;
				if (num != 0)
				{
				}
				num = (short)976945152;
				short num2 = num;
				num = (short)1340941453;
				short num3 = num;
				num = (short)872424589;
				switch (num3 == num)
				{
				}
				num = (short)1512374272;
				if (num != 0)
				{
				}
				this.radProfAlertTonesCallAlertToneAutoReset_A7596.HiddenDynamic = value;
			}
		}

		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x06002ABE RID: 10942 RVA: 0x0029AE30 File Offset: 0x00299030
		public bool RadProfAlertTonesCallAlertToneAutoReset_A7596_HasDiffs
		{
			get
			{
				short num = (short)443596015;
				short num2 = num;
				num = (short)1523629295;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1645674496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)800980993;
				if (num != 0)
				{
				}
				num = (short)1945894912;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesCallAlertToneAutoReset_A7596._HasDiffs;
			}
		}

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x06002ABF RID: 10943 RVA: 0x0029AEE0 File Offset: 0x002990E0
		// (set) Token: 0x06002AC0 RID: 10944 RVA: 0x0029AF94 File Offset: 0x00299194
		public bool RadProfAlertTonesLED_A8428Value
		{
			get
			{
				short num = (short)1537287395;
				short num2 = num;
				num = (short)1588208867;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1878917120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)403767297;
				if (num != 0)
				{
				}
				num = (short)276365312;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesLED_A8428.Value;
			}
			set
			{
				short num = (short)269287425;
				if (num != 0)
				{
				}
				num = (short)1001586688;
				short num2 = num;
				num = (short)54685989;
				short num3 = num;
				num = (short)1729786149;
				switch (num3 == num)
				{
				}
				num = (short)4456448;
				if (num != 0)
				{
				}
				this.radProfAlertTonesLED_A8428.Value = value;
			}
		}

		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x06002AC1 RID: 10945 RVA: 0x0029B048 File Offset: 0x00299248
		public global::AcpBusinessLayer.AcpField<bool> RadProfAlertTonesLED_A8428
		{
			get
			{
				short num = (short)15374296;
				short num2 = num;
				num = (short)602642392;
				switch (num2 == num)
				{
				default:
				{
					num = (short)945553408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1196490753;
				if (num != 0)
				{
				}
				num = (short)2013003776;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesLED_A8428;
			}
		}

		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x06002AC2 RID: 10946 RVA: 0x0029B0F4 File Offset: 0x002992F4
		// (set) Token: 0x06002AC3 RID: 10947 RVA: 0x0029B1AC File Offset: 0x002993AC
		public bool RadProfAlertTonesLED_A8428_UIValue
		{
			get
			{
				short num = (short)1619387197;
				short num2 = num;
				num = (short)921625405;
				switch (num2 == num)
				{
				default:
				{
					num = (short)954204160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1372127233;
				if (num != 0)
				{
				}
				num = (short)121110528;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesLED_A8428.Value;
			}
			set
			{
				short num = (short)2075589356;
				short num2 = num;
				num = (short)2059795180;
				switch (num2 == num)
				{
				default:
				{
					num = (short)900530176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1283063809;
				if (num != 0)
				{
				}
				num = (short)2107572224;
				if (num != 0)
				{
				}
				this.radProfAlertTonesLED_A8428.Value = value;
			}
		}

		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x06002AC4 RID: 10948 RVA: 0x0029B264 File Offset: 0x00299464
		// (set) Token: 0x06002AC5 RID: 10949 RVA: 0x0029B318 File Offset: 0x00299518
		public bool RadProfAlertTonesLED_A8428_Applicable
		{
			get
			{
				short num = (short)368115713;
				if (num != 0)
				{
				}
				num = (short)530251776;
				short num2 = num;
				num = (short)940387165;
				short num3 = num;
				num = (short)1893018461;
				switch (num3 == num)
				{
				}
				num = (short)1746141184;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesLED_A8428.Applicable;
			}
			set
			{
				short num = (short)2004056062;
				short num2 = num;
				num = (short)2071361534;
				switch (num2 == num)
				{
				default:
				{
					num = (short)947650560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1018953729;
				if (num != 0)
				{
				}
				num = (short)1272381440;
				if (num != 0)
				{
				}
				this.radProfAlertTonesLED_A8428.Applicable = value;
			}
		}

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x06002AC6 RID: 10950 RVA: 0x0029B3D4 File Offset: 0x002995D4
		// (set) Token: 0x06002AC7 RID: 10951 RVA: 0x0029B48C File Offset: 0x0029968C
		public bool RadProfAlertTonesLED_A8428_Valid
		{
			get
			{
				short num = (short)959250433;
				if (num != 0)
				{
				}
				num = (short)581697536;
				short num2 = num;
				num = (short)420893199;
				short num3 = num;
				num = (short)1147949583;
				switch (num3 == num)
				{
				}
				num = (short)1142161408;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesLED_A8428.Valid;
			}
			set
			{
				short num = (short)1189347006;
				short num2 = num;
				num = (short)69533374;
				switch (num2 == num)
				{
				default:
				{
					num = (short)600047616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)700383232;
				if (num != 0)
				{
				}
				num = (short)1675886593;
				if (num != 0)
				{
				}
				this.radProfAlertTonesLED_A8428.Valid = value;
			}
		}

		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x06002AC8 RID: 10952 RVA: 0x0029B544 File Offset: 0x00299744
		// (set) Token: 0x06002AC9 RID: 10953 RVA: 0x0029B5FC File Offset: 0x002997FC
		public bool RadProfAlertTonesLED_A8428_Visible
		{
			get
			{
				short num = (short)1838169367;
				short num2 = num;
				num = (short)662125847;
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
				num = (short)522584065;
				if (num != 0)
				{
				}
				num = (short)1231880192;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesLED_A8428.Visible;
			}
			set
			{
				short num = (short)1310309858;
				short num2 = num;
				num = (short)463912418;
				switch (num2 == num)
				{
				default:
				{
					num = (short)920322048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)861732864;
				if (num != 0)
				{
				}
				num = (short)773914625;
				if (num != 0)
				{
				}
				this.radProfAlertTonesLED_A8428.Visible = value;
			}
		}

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x06002ACA RID: 10954 RVA: 0x0029B6B0 File Offset: 0x002998B0
		// (set) Token: 0x06002ACB RID: 10955 RVA: 0x0029B768 File Offset: 0x00299968
		public bool RadProfAlertTonesLED_A8428_Editable
		{
			get
			{
				short num = (short)1447664941;
				short num2 = num;
				num = (short)1358208301;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2038628352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1856438273;
				if (num != 0)
				{
				}
				num = (short)1857421312;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesLED_A8428.Editable;
			}
			set
			{
				short num = (short)858390038;
				short num2 = num;
				num = (short)764083734;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1970864128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2072117249;
				if (num != 0)
				{
				}
				num = (short)1201668096;
				if (num != 0)
				{
				}
				this.radProfAlertTonesLED_A8428.Editable = value;
			}
		}

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x06002ACC RID: 10956 RVA: 0x0029B820 File Offset: 0x00299A20
		internal string RadProfAlertTonesLED_A8428_UILabel
		{
			get
			{
				short num = (short)1211139727;
				short num2 = num;
				num = (short)2026669711;
				switch (num2 == num)
				{
				default:
				{
					num = (short)6815744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2034434049;
				if (num != 0)
				{
				}
				num = (short)254607360;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesLED_A8428.UIName;
			}
		}

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x06002ACD RID: 10957 RVA: 0x0029B8D4 File Offset: 0x00299AD4
		// (set) Token: 0x06002ACE RID: 10958 RVA: 0x0029B984 File Offset: 0x00299B84
		internal bool RadProfAlertTonesLED_A8428_HiddenStatic
		{
			get
			{
				short num = (short)399349624;
				short num2 = num;
				num = (short)1604360056;
				switch (num2 == num)
				{
				default:
				{
					num = (short)290127872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1925054464;
				if (num != 0)
				{
				}
				num = (short)60620801;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesLED_A8428.HiddenStatic;
			}
			set
			{
				short num = (short)570380027;
				short num2 = num;
				num = (short)80367355;
				switch (num2 == num)
				{
				default:
				{
					num = (short)923140096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1219624961;
				if (num != 0)
				{
				}
				num = (short)123797504;
				if (num != 0)
				{
				}
				this.radProfAlertTonesLED_A8428.HiddenStatic = value;
			}
		}

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x06002ACF RID: 10959 RVA: 0x0029BA3C File Offset: 0x00299C3C
		// (set) Token: 0x06002AD0 RID: 10960 RVA: 0x0029BAF0 File Offset: 0x00299CF0
		internal bool RadProfAlertTonesLED_A8428_HiddenDynamic
		{
			get
			{
				short num = (short)100979198;
				short num2 = num;
				num = (short)794743294;
				switch (num2 == num)
				{
				default:
				{
					num = (short)447152128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)842399744;
				if (num != 0)
				{
				}
				num = (short)1475346433;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesLED_A8428.HiddenDynamic;
			}
			set
			{
				short num = (short)204123646;
				short num2 = num;
				num = (short)58961406;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1045233664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)269156352;
				if (num != 0)
				{
				}
				num = (short)1379008513;
				if (num != 0)
				{
				}
				this.radProfAlertTonesLED_A8428.HiddenDynamic = value;
			}
		}

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x06002AD1 RID: 10961 RVA: 0x0029BBA8 File Offset: 0x00299DA8
		public bool RadProfAlertTonesLED_A8428_HasDiffs
		{
			get
			{
				short num = (short)726401025;
				if (num != 0)
				{
				}
				num = (short)1398079488;
				short num2 = num;
				num = (short)1426467262;
				short num3 = num;
				num = (short)2129603006;
				switch (num3 == num)
				{
				}
				num = (short)1068433408;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesLED_A8428._HasDiffs;
			}
		}

		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x06002AD2 RID: 10962 RVA: 0x0029BC5C File Offset: 0x00299E5C
		// (set) Token: 0x06002AD3 RID: 10963 RVA: 0x0029BD10 File Offset: 0x00299F10
		public int RadProfAlertTonesMuteTonesOperation_A8562Value
		{
			get
			{
				short num = (short)1490866081;
				short num2 = num;
				num = (short)1890897825;
				switch (num2 == num)
				{
				default:
				{
					num = (short)415694848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)567214080;
				if (num != 0)
				{
				}
				num = (short)983564289;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesMuteTonesOperation_A8562.Value;
			}
			set
			{
				short num = (short)186908673;
				if (num != 0)
				{
				}
				num = (short)565379072;
				short num2 = num;
				num = (short)1182760489;
				short num3 = num;
				num = (short)463371817;
				switch (num3 == num)
				{
				}
				num = (short)473956352;
				if (num != 0)
				{
				}
				this.radProfAlertTonesMuteTonesOperation_A8562.Value = value;
			}
		}

		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x06002AD4 RID: 10964 RVA: 0x0029BDC8 File Offset: 0x00299FC8
		// (set) Token: 0x06002AD5 RID: 10965 RVA: 0x0029BE80 File Offset: 0x0029A080
		public string RadProfAlertTonesMuteTonesOperation_A8562_UIValue
		{
			get
			{
				short num = (short)1765179674;
				short num2 = num;
				num = (short)1099268378;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1492254720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)191627265;
				if (num != 0)
				{
				}
				num = (short)176160768;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesMuteTonesOperation_A8562.UIValue;
			}
			set
			{
				short num = (short)666778841;
				short num2 = num;
				num = (short)1633500377;
				switch (num2 == num)
				{
				default:
				{
					num = (short)478609408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)394461185;
				if (num != 0)
				{
				}
				num = (short)1424490496;
				if (num != 0)
				{
				}
				this.radProfAlertTonesMuteTonesOperation_A8562.UIValue = value;
			}
		}

		// Token: 0x17001569 RID: 5481
		// (get) Token: 0x06002AD6 RID: 10966 RVA: 0x0029BF38 File Offset: 0x0029A138
		public global::AcpBusinessLayer.AcpListField RadProfAlertTonesMuteTonesOperation_A8562
		{
			get
			{
				short num = (short)1942058424;
				short num2 = num;
				num = (short)1322808760;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1253048320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1695154176;
				if (num != 0)
				{
				}
				num = (short)1506476033;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesMuteTonesOperation_A8562;
			}
		}

		// Token: 0x1700156A RID: 5482
		// (get) Token: 0x06002AD7 RID: 10967 RVA: 0x0029BFE8 File Offset: 0x0029A1E8
		// (set) Token: 0x06002AD8 RID: 10968 RVA: 0x0029C09C File Offset: 0x0029A29C
		public bool RadProfAlertTonesMuteTonesOperation_A8562_Applicable
		{
			get
			{
				short num = (short)1848417709;
				short num2 = num;
				num = (short)1525980589;
				switch (num2 == num)
				{
				default:
				{
					num = (short)369033216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)207290368;
				if (num != 0)
				{
				}
				num = (short)565641217;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesMuteTonesOperation_A8562.Applicable;
			}
			set
			{
				short num = (short)1286678414;
				short num2 = num;
				num = (short)1695754126;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1759379456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)879230977;
				if (num != 0)
				{
				}
				num = (short)295960576;
				if (num != 0)
				{
				}
				this.radProfAlertTonesMuteTonesOperation_A8562.Applicable = value;
			}
		}

		// Token: 0x1700156B RID: 5483
		// (get) Token: 0x06002AD9 RID: 10969 RVA: 0x0029C154 File Offset: 0x0029A354
		// (set) Token: 0x06002ADA RID: 10970 RVA: 0x0029C208 File Offset: 0x0029A408
		public bool RadProfAlertTonesMuteTonesOperation_A8562_Valid
		{
			get
			{
				short num = (short)1630277905;
				short num2 = num;
				num = (short)303763729;
				switch (num2 == num)
				{
				default:
				{
					num = (short)411041792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)790953984;
				if (num != 0)
				{
				}
				num = (short)836632577;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesMuteTonesOperation_A8562.Valid;
			}
			set
			{
				short num = (short)10399174;
				short num2 = num;
				num = (short)744205766;
				switch (num2 == num)
				{
				}
				num = (short)620691456;
				short num3 = num;
				num = (short)1235288064;
				if (num != 0)
				{
				}
				num = (short)2095448065;
				if (num != 0)
				{
				}
				this.radProfAlertTonesMuteTonesOperation_A8562.Valid = value;
			}
		}

		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x06002ADB RID: 10971 RVA: 0x0029C2C0 File Offset: 0x0029A4C0
		// (set) Token: 0x06002ADC RID: 10972 RVA: 0x0029C374 File Offset: 0x0029A574
		public bool RadProfAlertTonesMuteTonesOperation_A8562_Visible
		{
			get
			{
				short num = (short)208994305;
				if (num != 0)
				{
				}
				num = (short)1157648652;
				short num2 = num;
				num = (short)420106508;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1529544704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1202716672;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesMuteTonesOperation_A8562.Visible;
			}
			set
			{
				short num = (short)450751409;
				short num2 = num;
				num = (short)2015751089;
				switch (num2 == num)
				{
				}
				num = (short)1475870720;
				short num3 = num;
				num = (short)786300928;
				if (num != 0)
				{
				}
				num = (short)1672871937;
				if (num != 0)
				{
				}
				this.radProfAlertTonesMuteTonesOperation_A8562.Visible = value;
			}
		}

		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x06002ADD RID: 10973 RVA: 0x0029C42C File Offset: 0x0029A62C
		// (set) Token: 0x06002ADE RID: 10974 RVA: 0x0029C4E0 File Offset: 0x0029A6E0
		public bool RadProfAlertTonesMuteTonesOperation_A8562_Editable
		{
			get
			{
				short num = (short)546542314;
				short num2 = num;
				num = (short)802984682;
				switch (num2 == num)
				{
				}
				num = (short)1237581824;
				short num3 = num;
				num = (short)1916272641;
				if (num != 0)
				{
				}
				num = (short)415694848;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesMuteTonesOperation_A8562.Editable;
			}
			set
			{
				short num = (short)1824787195;
				short num2 = num;
				num = (short)1903758075;
				switch (num2 == num)
				{
				}
				num = (short)1334181888;
				short num3 = num;
				num = (short)366477312;
				if (num != 0)
				{
				}
				num = (short)1592262657;
				if (num != 0)
				{
				}
				this.radProfAlertTonesMuteTonesOperation_A8562.Editable = value;
			}
		}

		// Token: 0x1700156E RID: 5486
		// (get) Token: 0x06002ADF RID: 10975 RVA: 0x0029C594 File Offset: 0x0029A794
		internal string RadProfAlertTonesMuteTonesOperation_A8562_UILabel
		{
			get
			{
				short num = (short)534684917;
				short num2 = num;
				num = (short)409052405;
				switch (num2 == num)
				{
				}
				num = (short)761266176;
				short num3 = num;
				num = (short)117637121;
				if (num != 0)
				{
				}
				num = (short)592445440;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesMuteTonesOperation_A8562.UIName;
			}
		}

		// Token: 0x1700156F RID: 5487
		// (get) Token: 0x06002AE0 RID: 10976 RVA: 0x0029C648 File Offset: 0x0029A848
		// (set) Token: 0x06002AE1 RID: 10977 RVA: 0x0029C6F8 File Offset: 0x0029A8F8
		internal bool RadProfAlertTonesMuteTonesOperation_A8562_HiddenStatic
		{
			get
			{
				short num = (short)1398163043;
				short num2 = num;
				num = (short)311445091;
				switch (num2 == num)
				{
				}
				num = (short)59375616;
				short num3 = num;
				num = (short)1177812993;
				if (num != 0)
				{
				}
				num = (short)1465122816;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesMuteTonesOperation_A8562.HiddenStatic;
			}
			set
			{
				short num = (short)1308362500;
				short num2 = num;
				num = (short)946079492;
				switch (num2 == num)
				{
				}
				num = (short)1036255232;
				short num3 = num;
				num = (short)211222528;
				if (num != 0)
				{
				}
				num = (short)170459137;
				if (num != 0)
				{
				}
				this.radProfAlertTonesMuteTonesOperation_A8562.HiddenStatic = value;
			}
		}

		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x06002AE2 RID: 10978 RVA: 0x0029C7AC File Offset: 0x0029A9AC
		// (set) Token: 0x06002AE3 RID: 10979 RVA: 0x0029C864 File Offset: 0x0029AA64
		internal bool RadProfAlertTonesMuteTonesOperation_A8562_HiddenDynamic
		{
			get
			{
				short num = (short)1947074561;
				if (num != 0)
				{
				}
				num = (short)1407451200;
				short num2 = num;
				num = (short)42336320;
				switch (num2 == num)
				{
				default:
				{
					num = (short)727711744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)636878848;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesMuteTonesOperation_A8562.HiddenDynamic;
			}
			set
			{
				short num = (short)502988801;
				if (num != 0)
				{
				}
				num = (short)1397124822;
				short num2 = num;
				num = (short)595357398;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1210056704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1857486848;
				if (num != 0)
				{
				}
				this.radProfAlertTonesMuteTonesOperation_A8562.HiddenDynamic = value;
			}
		}

		// Token: 0x17001571 RID: 5489
		// (get) Token: 0x06002AE4 RID: 10980 RVA: 0x0029C91C File Offset: 0x0029AB1C
		public bool RadProfAlertTonesMuteTonesOperation_A8562_HasDiffs
		{
			get
			{
				short num = (short)1074488507;
				short num2 = num;
				num = (short)1295541435;
				switch (num2 == num)
				{
				}
				num = (short)224526336;
				short num3 = num;
				num = (short)1991442432;
				if (num != 0)
				{
				}
				num = (short)1753481217;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesMuteTonesOperation_A8562._HasDiffs;
			}
		}

		// Token: 0x17001572 RID: 5490
		// (get) Token: 0x06002AE5 RID: 10981 RVA: 0x0029C9D8 File Offset: 0x0029ABD8
		// (set) Token: 0x06002AE6 RID: 10982 RVA: 0x0029CA8C File Offset: 0x0029AC8C
		public bool RadProfAlertTonesPowerUpSelfTestAlertTone_A8718Value
		{
			get
			{
				short num = (short)1660887195;
				short num2 = num;
				num = (short)448012443;
				switch (num2 == num)
				{
				}
				num = (short)290193408;
				short num3 = num;
				num = (short)947978240;
				if (num != 0)
				{
				}
				num = (short)1836449793;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718.Value;
			}
			set
			{
				short num = (short)837139940;
				short num2 = num;
				num = (short)403619300;
				switch (num2 == num)
				{
				}
				num = (short)447545344;
				short num3 = num;
				num = (short)57344000;
				if (num != 0)
				{
				}
				num = (short)1323696129;
				if (num != 0)
				{
				}
				this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718.Value = value;
			}
		}

		// Token: 0x17001573 RID: 5491
		// (get) Token: 0x06002AE7 RID: 10983 RVA: 0x0029CB44 File Offset: 0x0029AD44
		public global::AcpBusinessLayer.AcpField<bool> RadProfAlertTonesPowerUpSelfTestAlertTone_A8718
		{
			get
			{
				short num = (short)1961512000;
				short num2 = num;
				num = (short)1033718848;
				switch (num2 == num)
				{
				}
				num = (short)230752256;
				short num3 = num;
				num = (short)1278214145;
				if (num != 0)
				{
				}
				num = (short)597622784;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718;
			}
		}

		// Token: 0x17001574 RID: 5492
		// (get) Token: 0x06002AE8 RID: 10984 RVA: 0x0029CBF0 File Offset: 0x0029ADF0
		// (set) Token: 0x06002AE9 RID: 10985 RVA: 0x0029CCA4 File Offset: 0x0029AEA4
		public bool RadProfAlertTonesPowerUpSelfTestAlertTone_A8718_UIValue
		{
			get
			{
				short num = (short)1438952373;
				short num2 = num;
				num = (short)396471221;
				switch (num2 == num)
				{
				}
				num = (short)507183104;
				short num3 = num;
				num = (short)1021050880;
				if (num != 0)
				{
				}
				num = (short)248643585;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718.Value;
			}
			set
			{
				short num = (short)279881912;
				short num2 = num;
				num = (short)444115128;
				switch (num2 == num)
				{
				}
				num = (short)1771372544;
				short num3 = num;
				num = (short)857997313;
				if (num != 0)
				{
				}
				num = (short)572194816;
				if (num != 0)
				{
				}
				this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718.Value = value;
			}
		}

		// Token: 0x17001575 RID: 5493
		// (get) Token: 0x06002AEA RID: 10986 RVA: 0x0029CD58 File Offset: 0x0029AF58
		// (set) Token: 0x06002AEB RID: 10987 RVA: 0x0029CE0C File Offset: 0x0029B00C
		public bool RadProfAlertTonesPowerUpSelfTestAlertTone_A8718_Applicable
		{
			get
			{
				short num = (short)704496831;
				short num2 = num;
				num = (short)1520485567;
				switch (num2 == num)
				{
				}
				num = (short)1186922496;
				short num3 = num;
				num = (short)1023606785;
				if (num != 0)
				{
				}
				num = (short)927465472;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718.Applicable;
			}
			set
			{
				short num = (short)875167745;
				if (num != 0)
				{
				}
				num = (short)345130589;
				short num2 = num;
				num = (short)205342301;
				switch (num2 == num)
				{
				default:
				{
					num = (short)668598272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)726532096;
				if (num != 0)
				{
				}
				this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718.Applicable = value;
			}
		}

		// Token: 0x17001576 RID: 5494
		// (get) Token: 0x06002AEC RID: 10988 RVA: 0x0029CEC0 File Offset: 0x0029B0C0
		// (set) Token: 0x06002AED RID: 10989 RVA: 0x0029CF74 File Offset: 0x0029B174
		public bool RadProfAlertTonesPowerUpSelfTestAlertTone_A8718_Valid
		{
			get
			{
				short num = (short)143168131;
				short num2 = num;
				num = (short)370446979;
				switch (num2 == num)
				{
				}
				num = (short)350617600;
				short num3 = num;
				num = (short)1957953537;
				if (num != 0)
				{
				}
				num = (short)2030370816;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718.Valid;
			}
			set
			{
				short num = (short)1766926637;
				short num2 = num;
				num = (short)2069375277;
				switch (num2 == num)
				{
				}
				num = (short)947060736;
				short num3 = num;
				num = (short)228392960;
				if (num != 0)
				{
				}
				num = (short)1486749697;
				if (num != 0)
				{
				}
				this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718.Valid = value;
			}
		}

		// Token: 0x17001577 RID: 5495
		// (get) Token: 0x06002AEE RID: 10990 RVA: 0x0029D02C File Offset: 0x0029B22C
		// (set) Token: 0x06002AEF RID: 10991 RVA: 0x0029D0E4 File Offset: 0x0029B2E4
		public bool RadProfAlertTonesPowerUpSelfTestAlertTone_A8718_Visible
		{
			get
			{
				short num = (short)970260481;
				if (num != 0)
				{
				}
				num = (short)961603795;
				short num2 = num;
				num = (short)1775167699;
				switch (num2 == num)
				{
				default:
				{
					num = (short)116916224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)26148864;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718.Visible;
			}
			set
			{
				short num = (short)1548839999;
				short num2 = num;
				num = (short)1105488959;
				switch (num2 == num)
				{
				}
				num = (short)1155072000;
				short num3 = num;
				num = (short)1656225793;
				if (num != 0)
				{
				}
				num = (short)1315962880;
				if (num != 0)
				{
				}
				this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718.Visible = value;
			}
		}

		// Token: 0x17001578 RID: 5496
		// (get) Token: 0x06002AF0 RID: 10992 RVA: 0x0029D19C File Offset: 0x0029B39C
		// (set) Token: 0x06002AF1 RID: 10993 RVA: 0x0029D254 File Offset: 0x0029B454
		public bool RadProfAlertTonesPowerUpSelfTestAlertTone_A8718_Editable
		{
			get
			{
				short num = (short)1045941999;
				short num2 = num;
				num = (short)424136431;
				switch (num2 == num)
				{
				}
				num = (short)1700134912;
				short num3 = num;
				num = (short)446169088;
				if (num != 0)
				{
				}
				num = (short)305922049;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718.Editable;
			}
			set
			{
				short num = (short)306185258;
				short num2 = num;
				num = (short)1050477610;
				switch (num2 == num)
				{
				}
				num = (short)185270272;
				short num3 = num;
				num = (short)1946550272;
				if (num != 0)
				{
				}
				num = (short)1988427777;
				if (num != 0)
				{
				}
				this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718.Editable = value;
			}
		}

		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x06002AF2 RID: 10994 RVA: 0x0029D30C File Offset: 0x0029B50C
		internal string RadProfAlertTonesPowerUpSelfTestAlertTone_A8718_UILabel
		{
			get
			{
				short num = (short)860922622;
				short num2 = num;
				num = (short)1404674814;
				switch (num2 == num)
				{
				}
				num = (short)1269956608;
				short num3 = num;
				num = (short)1843724289;
				if (num != 0)
				{
				}
				num = (short)11730944;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718.UIName;
			}
		}

		// Token: 0x1700157A RID: 5498
		// (get) Token: 0x06002AF3 RID: 10995 RVA: 0x0029D3C4 File Offset: 0x0029B5C4
		// (set) Token: 0x06002AF4 RID: 10996 RVA: 0x0029D47C File Offset: 0x0029B67C
		internal bool RadProfAlertTonesPowerUpSelfTestAlertTone_A8718_HiddenStatic
		{
			get
			{
				short num = (short)1674788125;
				short num2 = num;
				num = (short)1690975517;
				switch (num2 == num)
				{
				}
				num = (short)702742528;
				short num3 = num;
				num = (short)499253248;
				if (num != 0)
				{
				}
				num = (short)1643380737;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718.HiddenStatic;
			}
			set
			{
				short num = (short)861689068;
				short num2 = num;
				num = (short)498554092;
				switch (num2 == num)
				{
				}
				num = (short)1746010112;
				short num3 = num;
				num = (short)685965313;
				if (num != 0)
				{
				}
				num = (short)545128448;
				if (num != 0)
				{
				}
				this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718.HiddenStatic = value;
			}
		}

		// Token: 0x1700157B RID: 5499
		// (get) Token: 0x06002AF5 RID: 10997 RVA: 0x0029D534 File Offset: 0x0029B734
		// (set) Token: 0x06002AF6 RID: 10998 RVA: 0x0029D5EC File Offset: 0x0029B7EC
		internal bool RadProfAlertTonesPowerUpSelfTestAlertTone_A8718_HiddenDynamic
		{
			get
			{
				short num = (short)1805336261;
				short num2 = num;
				num = (short)1220689605;
				switch (num2 == num)
				{
				}
				num = (short)710344704;
				short num3 = num;
				num = (short)849608705;
				if (num != 0)
				{
				}
				num = (short)2024210432;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718.HiddenDynamic;
			}
			set
			{
				short num = (short)1874264065;
				if (num != 0)
				{
				}
				num = (short)1428595656;
				short num2 = num;
				num = (short)558146504;
				switch (num2 == num)
				{
				default:
				{
					num = (short)837877760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)480051200;
				if (num != 0)
				{
				}
				this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718.HiddenDynamic = value;
			}
		}

		// Token: 0x1700157C RID: 5500
		// (get) Token: 0x06002AF7 RID: 10999 RVA: 0x0029D6A0 File Offset: 0x0029B8A0
		public bool RadProfAlertTonesPowerUpSelfTestAlertTone_A8718_HasDiffs
		{
			get
			{
				short num = (short)692925516;
				short num2 = num;
				num = (short)80294988;
				switch (num2 == num)
				{
				}
				num = (short)562495488;
				short num3 = num;
				num = (short)1505951745;
				if (num != 0)
				{
				}
				num = (short)1980301312;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesPowerUpSelfTestAlertTone_A8718._HasDiffs;
			}
		}

		// Token: 0x1700157D RID: 5501
		// (get) Token: 0x06002AF8 RID: 11000 RVA: 0x0029D754 File Offset: 0x0029B954
		// (set) Token: 0x06002AF9 RID: 11001 RVA: 0x0029D80C File Offset: 0x0029BA0C
		public int RadProfAlertTonesRotaryAlert_A8983Value
		{
			get
			{
				short num = (short)1084760608;
				short num2 = num;
				num = (short)2112627232;
				switch (num2 == num)
				{
				}
				num = (short)80805888;
				short num3 = num;
				num = (short)1908801536;
				if (num != 0)
				{
				}
				num = (short)1697906689;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesRotaryAlert_A8983.Value;
			}
			set
			{
				short num = (short)256394640;
				short num2 = num;
				num = (short)330253712;
				switch (num2 == num)
				{
				}
				num = (short)1922301952;
				short num3 = num;
				num = (short)1518206977;
				if (num != 0)
				{
				}
				num = (short)983957504;
				if (num != 0)
				{
				}
				this.radProfAlertTonesRotaryAlert_A8983.Value = value;
			}
		}

		// Token: 0x1700157E RID: 5502
		// (get) Token: 0x06002AFA RID: 11002 RVA: 0x0029D8C4 File Offset: 0x0029BAC4
		// (set) Token: 0x06002AFB RID: 11003 RVA: 0x0029D978 File Offset: 0x0029BB78
		public string RadProfAlertTonesRotaryAlert_A8983_UIValue
		{
			get
			{
				short num = (short)515691357;
				short num2 = num;
				num = (short)985322333;
				switch (num2 == num)
				{
				}
				num = (short)943849472;
				short num3 = num;
				num = (short)262930433;
				if (num != 0)
				{
				}
				num = (short)1531183104;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesRotaryAlert_A8983.UIValue;
			}
			set
			{
				short num = (short)1086980097;
				if (num != 0)
				{
				}
				num = (short)1394547276;
				short num2 = num;
				num = (short)412359244;
				switch (num2 == num)
				{
				default:
				{
					num = (short)601161728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1992687616;
				if (num != 0)
				{
				}
				this.radProfAlertTonesRotaryAlert_A8983.UIValue = value;
			}
		}

		// Token: 0x1700157F RID: 5503
		// (get) Token: 0x06002AFC RID: 11004 RVA: 0x0029DA2C File Offset: 0x0029BC2C
		public global::AcpBusinessLayer.AcpListField RadProfAlertTonesRotaryAlert_A8983
		{
			get
			{
				short num = (short)2101594680;
				short num2 = num;
				num = (short)101042744;
				switch (num2 == num)
				{
				}
				num = (short)134676480;
				short num3 = num;
				num = (short)2129723393;
				if (num != 0)
				{
				}
				num = (short)555941888;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesRotaryAlert_A8983;
			}
		}

		// Token: 0x17001580 RID: 5504
		// (get) Token: 0x06002AFD RID: 11005 RVA: 0x0029DAE0 File Offset: 0x0029BCE0
		// (set) Token: 0x06002AFE RID: 11006 RVA: 0x0029DB94 File Offset: 0x0029BD94
		public bool RadProfAlertTonesRotaryAlert_A8983_Applicable
		{
			get
			{
				short num = (short)1612972033;
				if (num != 0)
				{
				}
				num = (short)1710948611;
				short num2 = num;
				num = (short)572719363;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1867776000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1178533888;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesRotaryAlert_A8983.Applicable;
			}
			set
			{
				short num = (short)443618061;
				short num2 = num;
				num = (short)663950093;
				switch (num2 == num)
				{
				}
				num = (short)115146752;
				short num3 = num;
				num = (short)237305856;
				if (num != 0)
				{
				}
				num = (short)81330177;
				if (num != 0)
				{
				}
				this.radProfAlertTonesRotaryAlert_A8983.Applicable = value;
			}
		}

		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x06002AFF RID: 11007 RVA: 0x0029DC4C File Offset: 0x0029BE4C
		// (set) Token: 0x06002B00 RID: 11008 RVA: 0x0029DD04 File Offset: 0x0029BF04
		public bool RadProfAlertTonesRotaryAlert_A8983_Valid
		{
			get
			{
				short num = (short)1069001261;
				short num2 = num;
				num = (short)1236445741;
				switch (num2 == num)
				{
				}
				num = (short)1912733696;
				short num3 = num;
				num = (short)675807233;
				if (num != 0)
				{
				}
				num = (short)1865875456;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesRotaryAlert_A8983.Valid;
			}
			set
			{
				short num = (short)1632154342;
				short num2 = num;
				num = (short)1891742438;
				switch (num2 == num)
				{
				}
				num = (short)372768768;
				short num3 = num;
				num = (short)549650432;
				if (num != 0)
				{
				}
				num = (short)640745473;
				if (num != 0)
				{
				}
				this.radProfAlertTonesRotaryAlert_A8983.Valid = value;
			}
		}

		// Token: 0x17001582 RID: 5506
		// (get) Token: 0x06002B01 RID: 11009 RVA: 0x0029DDBC File Offset: 0x0029BFBC
		// (set) Token: 0x06002B02 RID: 11010 RVA: 0x0029DE70 File Offset: 0x0029C070
		public bool RadProfAlertTonesRotaryAlert_A8983_Visible
		{
			get
			{
				short num = (short)821166081;
				if (num != 0)
				{
				}
				num = (short)1329920056;
				short num2 = num;
				num = (short)2000156728;
				switch (num2 == num)
				{
				default:
				{
					num = (short)897908736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1361772544;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesRotaryAlert_A8983.Visible;
			}
			set
			{
				short num = (short)1270218753;
				if (num != 0)
				{
				}
				num = (short)1188673459;
				short num2 = num;
				num = (short)1669380019;
				switch (num2 == num)
				{
				default:
				{
					num = (short)8716288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)184549376;
				if (num != 0)
				{
				}
				this.radProfAlertTonesRotaryAlert_A8983.Visible = value;
			}
		}

		// Token: 0x17001583 RID: 5507
		// (get) Token: 0x06002B03 RID: 11011 RVA: 0x0029DF24 File Offset: 0x0029C124
		// (set) Token: 0x06002B04 RID: 11012 RVA: 0x0029DFD8 File Offset: 0x0029C1D8
		public bool RadProfAlertTonesRotaryAlert_A8983_Editable
		{
			get
			{
				short num = (short)888373131;
				short num2 = num;
				num = (short)2028175243;
				switch (num2 == num)
				{
				}
				num = (short)2044133376;
				short num3 = num;
				num = (short)227213313;
				if (num != 0)
				{
				}
				num = (short)1242824704;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesRotaryAlert_A8983.Editable;
			}
			set
			{
				short num = (short)654219064;
				short num2 = num;
				num = (short)1157797688;
				switch (num2 == num)
				{
				}
				num = (short)1329725440;
				short num3 = num;
				num = (short)451084288;
				if (num != 0)
				{
				}
				num = (short)161677313;
				if (num != 0)
				{
				}
				this.radProfAlertTonesRotaryAlert_A8983.Editable = value;
			}
		}

		// Token: 0x17001584 RID: 5508
		// (get) Token: 0x06002B05 RID: 11013 RVA: 0x0029E08C File Offset: 0x0029C28C
		internal string RadProfAlertTonesRotaryAlert_A8983_UILabel
		{
			get
			{
				short num = (short)114810916;
				short num2 = num;
				num = (short)1094836260;
				switch (num2 == num)
				{
				}
				num = (short)1915355136;
				short num3 = num;
				num = (short)1421017089;
				if (num != 0)
				{
				}
				num = (short)2012086272;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesRotaryAlert_A8983.UIName;
			}
		}

		// Token: 0x17001585 RID: 5509
		// (get) Token: 0x06002B06 RID: 11014 RVA: 0x0029E140 File Offset: 0x0029C340
		// (set) Token: 0x06002B07 RID: 11015 RVA: 0x0029E1F8 File Offset: 0x0029C3F8
		internal bool RadProfAlertTonesRotaryAlert_A8983_HiddenStatic
		{
			get
			{
				short num = (short)1032154434;
				short num2 = num;
				num = (short)984640834;
				switch (num2 == num)
				{
				}
				num = (short)1747451904;
				short num3 = num;
				num = (short)1789788160;
				if (num != 0)
				{
				}
				num = (short)1857421313;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesRotaryAlert_A8983.HiddenStatic;
			}
			set
			{
				short num = (short)525897059;
				short num2 = num;
				num = (short)1733070179;
				switch (num2 == num)
				{
				}
				num = (short)333381632;
				short num3 = num;
				num = (short)1829634048;
				if (num != 0)
				{
				}
				num = (short)974716929;
				if (num != 0)
				{
				}
				this.radProfAlertTonesRotaryAlert_A8983.HiddenStatic = value;
			}
		}

		// Token: 0x17001586 RID: 5510
		// (get) Token: 0x06002B08 RID: 11016 RVA: 0x0029E2AC File Offset: 0x0029C4AC
		// (set) Token: 0x06002B09 RID: 11017 RVA: 0x0029E360 File Offset: 0x0029C560
		internal bool RadProfAlertTonesRotaryAlert_A8983_HiddenDynamic
		{
			get
			{
				short num = (short)1879534553;
				short num2 = num;
				num = (short)1481010137;
				switch (num2 == num)
				{
				}
				num = (short)269746176;
				short num3 = num;
				num = (short)1616183297;
				if (num != 0)
				{
				}
				num = (short)426377216;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesRotaryAlert_A8983.HiddenDynamic;
			}
			set
			{
				short num = (short)404325216;
				short num2 = num;
				num = (short)267879264;
				switch (num2 == num)
				{
				}
				num = (short)1999503360;
				short num3 = num;
				num = (short)244776961;
				if (num != 0)
				{
				}
				num = (short)1670512640;
				if (num != 0)
				{
				}
				this.radProfAlertTonesRotaryAlert_A8983.HiddenDynamic = value;
			}
		}

		// Token: 0x17001587 RID: 5511
		// (get) Token: 0x06002B0A RID: 11018 RVA: 0x0029E418 File Offset: 0x0029C618
		public bool RadProfAlertTonesRotaryAlert_A8983_HasDiffs
		{
			get
			{
				short num = (short)1375785588;
				short num2 = num;
				num = (short)1146081908;
				switch (num2 == num)
				{
				}
				num = (short)222887936;
				short num3 = num;
				num = (short)301203457;
				if (num != 0)
				{
				}
				num = (short)431423488;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesRotaryAlert_A8983._HasDiffs;
			}
		}

		// Token: 0x17001588 RID: 5512
		// (get) Token: 0x06002B0B RID: 11019 RVA: 0x0029E4CC File Offset: 0x0029C6CC
		// (set) Token: 0x06002B0C RID: 11020 RVA: 0x0029E580 File Offset: 0x0029C780
		public int RadProfAlertTonesStandbyChirpsec_A9179Value
		{
			get
			{
				short num = (short)858445921;
				short num2 = num;
				num = (short)881580129;
				switch (num2 == num)
				{
				}
				num = (short)964100096;
				short num3 = num;
				num = (short)1412890624;
				if (num != 0)
				{
				}
				num = (short)1373372417;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesStandbyChirpsec_A9179.Value;
			}
			set
			{
				short num = (short)10975257;
				short num2 = num;
				num = (short)1949595673;
				switch (num2 == num)
				{
				}
				num = (short)561512448;
				short num3 = num;
				num = (short)1090453505;
				if (num != 0)
				{
				}
				num = (short)548143104;
				if (num != 0)
				{
				}
				this.radProfAlertTonesStandbyChirpsec_A9179.Value = value;
			}
		}

		// Token: 0x17001589 RID: 5513
		// (get) Token: 0x06002B0D RID: 11021 RVA: 0x0029E638 File Offset: 0x0029C838
		public global::AcpBusinessLayer.AcpSimpleRangeField RadProfAlertTonesStandbyChirpsec_A9179
		{
			get
			{
				short num = (short)545533786;
				short num2 = num;
				num = (short)935866202;
				switch (num2 == num)
				{
				}
				num = (short)849805312;
				short num3 = num;
				num = (short)768737280;
				if (num != 0)
				{
				}
				num = (short)1593180161;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesStandbyChirpsec_A9179;
			}
		}

		// Token: 0x1700158A RID: 5514
		// (get) Token: 0x06002B0E RID: 11022 RVA: 0x0029E6EC File Offset: 0x0029C8EC
		// (set) Token: 0x06002B0F RID: 11023 RVA: 0x0029E79C File Offset: 0x0029C99C
		public string RadProfAlertTonesStandbyChirpsec_A9179_UIValue
		{
			get
			{
				short num = (short)2041645866;
				short num2 = num;
				num = (short)591596330;
				switch (num2 == num)
				{
				}
				num = (short)1204355072;
				short num3 = num;
				num = (short)936902657;
				if (num != 0)
				{
				}
				num = (short)321847296;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesStandbyChirpsec_A9179.UIValue;
			}
			set
			{
				short num = (short)1486159457;
				short num2 = num;
				num = (short)900857441;
				switch (num2 == num)
				{
				}
				num = (short)1208025088;
				short num3 = num;
				num = (short)1292894209;
				if (num != 0)
				{
				}
				num = (short)1507000320;
				if (num != 0)
				{
				}
				this.radProfAlertTonesStandbyChirpsec_A9179.UIValue = value;
			}
		}

		// Token: 0x1700158B RID: 5515
		// (get) Token: 0x06002B10 RID: 11024 RVA: 0x0029E850 File Offset: 0x0029CA50
		// (set) Token: 0x06002B11 RID: 11025 RVA: 0x0029E908 File Offset: 0x0029CB08
		internal int RadProfAlertTonesStandbyChirpsec_A9179Min
		{
			get
			{
				short num = (short)1212360766;
				short num2 = num;
				num = (short)385296446;
				switch (num2 == num)
				{
				}
				num = (short)234749952;
				short num3 = num;
				num = (short)563281920;
				if (num != 0)
				{
				}
				num = (short)2041446401;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesStandbyChirpsec_A9179.Min;
			}
			set
			{
				short num = (short)1138835847;
				short num2 = num;
				num = (short)378225031;
				switch (num2 == num)
				{
				}
				num = (short)1993539584;
				short num3 = num;
				num = (short)119078913;
				if (num != 0)
				{
				}
				num = (short)206962688;
				if (num != 0)
				{
				}
				this.radProfAlertTonesStandbyChirpsec_A9179.Min = value;
			}
		}

		// Token: 0x1700158C RID: 5516
		// (get) Token: 0x06002B12 RID: 11026 RVA: 0x0029E9C0 File Offset: 0x0029CBC0
		// (set) Token: 0x06002B13 RID: 11027 RVA: 0x0029EA78 File Offset: 0x0029CC78
		internal int RadProfAlertTonesStandbyChirpsec_A9179Max
		{
			get
			{
				short num = (short)1877803008;
				short num2 = num;
				num = (short)1877344257;
				if (num != 0)
				{
				}
				num = (short)157188636;
				short num3 = num;
				num = (short)304972316;
				switch (num3 == num)
				{
				}
				num = (short)1675296768;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesStandbyChirpsec_A9179.Max;
			}
			set
			{
				short num = (short)163250176;
				short num2 = num;
				num = (short)1001127937;
				if (num != 0)
				{
				}
				num = (short)326494086;
				short num3 = num;
				num = (short)386590598;
				switch (num3 == num)
				{
				}
				num = (short)687013888;
				if (num != 0)
				{
				}
				this.radProfAlertTonesStandbyChirpsec_A9179.Max = value;
			}
		}

		// Token: 0x1700158D RID: 5517
		// (get) Token: 0x06002B14 RID: 11028 RVA: 0x0029EB30 File Offset: 0x0029CD30
		// (set) Token: 0x06002B15 RID: 11029 RVA: 0x0029EBE4 File Offset: 0x0029CDE4
		internal int RadProfAlertTonesStandbyChirpsec_A9179Step
		{
			get
			{
				short num = (short)1733492736;
				short num2 = num;
				num = (short)859570177;
				if (num != 0)
				{
				}
				num = (short)126087147;
				short num3 = num;
				num = (short)770174955;
				switch (num3 == num)
				{
				}
				num = (short)181075968;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesStandbyChirpsec_A9179.StepSize;
			}
			set
			{
				short num = (short)865271808;
				short num2 = num;
				num = (short)1607978462;
				short num3 = num;
				num = (short)1073728990;
				switch (num3 == num)
				{
				}
				num = (short)1766064128;
				if (num != 0)
				{
				}
				num = (short)1729101825;
				if (num != 0)
				{
				}
				this.radProfAlertTonesStandbyChirpsec_A9179.StepSize = value;
			}
		}

		// Token: 0x1700158E RID: 5518
		// (get) Token: 0x06002B16 RID: 11030 RVA: 0x0029EC98 File Offset: 0x0029CE98
		// (set) Token: 0x06002B17 RID: 11031 RVA: 0x0029ED4C File Offset: 0x0029CF4C
		public bool RadProfAlertTonesStandbyChirpsec_A9179_Applicable
		{
			get
			{
				short num = (short)585105408;
				short num2 = num;
				num = (short)376852488;
				short num3 = num;
				num = (short)1409896456;
				switch (num3 == num)
				{
				}
				num = (short)1778581504;
				if (num != 0)
				{
				}
				num = (short)1888878593;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesStandbyChirpsec_A9179.Applicable;
			}
			set
			{
				short num = (short)1498021888;
				short num2 = num;
				num = (short)711919517;
				short num3 = num;
				num = (short)132712349;
				switch (num3 == num)
				{
				}
				num = (short)1108606977;
				if (num != 0)
				{
				}
				num = (short)1662451712;
				if (num != 0)
				{
				}
				this.radProfAlertTonesStandbyChirpsec_A9179.Applicable = value;
			}
		}

		// Token: 0x1700158F RID: 5519
		// (get) Token: 0x06002B18 RID: 11032 RVA: 0x0029EE08 File Offset: 0x0029D008
		// (set) Token: 0x06002B19 RID: 11033 RVA: 0x0029EEC0 File Offset: 0x0029D0C0
		public bool RadProfAlertTonesStandbyChirpsec_A9179_Valid
		{
			get
			{
				short num = (short)1679294464;
				short num2 = num;
				num = (short)814900027;
				short num3 = num;
				num = (short)1689215803;
				switch (num3 == num)
				{
				}
				num = (short)1224343552;
				if (num != 0)
				{
				}
				num = (short)245760001;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesStandbyChirpsec_A9179.Valid;
			}
			set
			{
				short num = (short)1053491200;
				short num2 = num;
				num = (short)1298385908;
				short num3 = num;
				num = (short)266914804;
				switch (num3 == num)
				{
				}
				num = (short)1822818305;
				if (num != 0)
				{
				}
				num = (short)1643905024;
				if (num != 0)
				{
				}
				this.radProfAlertTonesStandbyChirpsec_A9179.Valid = value;
			}
		}

		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x06002B1A RID: 11034 RVA: 0x0029EF74 File Offset: 0x0029D174
		// (set) Token: 0x06002B1B RID: 11035 RVA: 0x0029F02C File Offset: 0x0029D22C
		public bool RadProfAlertTonesStandbyChirpsec_A9179_Visible
		{
			get
			{
				short num = (short)645136384;
				short num2 = num;
				num = (short)154029237;
				short num3 = num;
				num = (short)1412189365;
				switch (num3 == num)
				{
				}
				num = (short)862519297;
				if (num != 0)
				{
				}
				num = (short)996605952;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesStandbyChirpsec_A9179.Visible;
			}
			set
			{
				short num = (short)1568604160;
				short num2 = num;
				num = (short)1199841067;
				short num3 = num;
				num = (short)248192811;
				switch (num3 == num)
				{
				}
				num = (short)1304166401;
				if (num != 0)
				{
				}
				num = (short)1126105088;
				if (num != 0)
				{
				}
				this.radProfAlertTonesStandbyChirpsec_A9179.Visible = value;
			}
		}

		// Token: 0x17001591 RID: 5521
		// (get) Token: 0x06002B1C RID: 11036 RVA: 0x0029F0E0 File Offset: 0x0029D2E0
		// (set) Token: 0x06002B1D RID: 11037 RVA: 0x0029F194 File Offset: 0x0029D394
		public bool RadProfAlertTonesStandbyChirpsec_A9179_Editable
		{
			get
			{
				short num = (short)1680080896;
				short num2 = num;
				num = (short)841698621;
				short num3 = num;
				num = (short)543378749;
				switch (num3 == num)
				{
				}
				num = (short)217055233;
				if (num != 0)
				{
				}
				num = (short)1327038464;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesStandbyChirpsec_A9179.Editable;
			}
			set
			{
				short num = (short)287309824;
				short num2 = num;
				num = (short)1799201688;
				short num3 = num;
				num = (short)958571416;
				switch (num3 == num)
				{
				}
				num = (short)311623680;
				if (num != 0)
				{
				}
				num = (short)970981377;
				if (num != 0)
				{
				}
				this.radProfAlertTonesStandbyChirpsec_A9179.Editable = value;
			}
		}

		// Token: 0x17001592 RID: 5522
		// (get) Token: 0x06002B1E RID: 11038 RVA: 0x0029F248 File Offset: 0x0029D448
		internal string RadProfAlertTonesStandbyChirpsec_A9179_UILabel
		{
			get
			{
				short num = (short)1984036864;
				short num2 = num;
				num = (short)518881800;
				short num3 = num;
				num = (short)2036236808;
				switch (num3 == num)
				{
				}
				num = (short)2135425024;
				if (num != 0)
				{
				}
				num = (short)1449132033;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesStandbyChirpsec_A9179.UIName;
			}
		}

		// Token: 0x17001593 RID: 5523
		// (get) Token: 0x06002B1F RID: 11039 RVA: 0x0029F300 File Offset: 0x0029D500
		// (set) Token: 0x06002B20 RID: 11040 RVA: 0x0029F3B4 File Offset: 0x0029D5B4
		internal bool RadProfAlertTonesStandbyChirpsec_A9179_HiddenStatic
		{
			get
			{
				short num = (short)646316032;
				short num2 = num;
				num = (short)1460513457;
				short num3 = num;
				num = (short)995863217;
				switch (num3 == num)
				{
				}
				num = (short)104988672;
				if (num != 0)
				{
				}
				num = (short)1484455937;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesStandbyChirpsec_A9179.HiddenStatic;
			}
			set
			{
				short num = (short)2048786432;
				short num2 = num;
				num = (short)306156970;
				short num3 = num;
				num = (short)1206752682;
				switch (num3 == num)
				{
				}
				num = (short)623575041;
				if (num != 0)
				{
				}
				num = (short)670826496;
				if (num != 0)
				{
				}
				this.radProfAlertTonesStandbyChirpsec_A9179.HiddenStatic = value;
			}
		}

		// Token: 0x17001594 RID: 5524
		// (get) Token: 0x06002B21 RID: 11041 RVA: 0x0029F46C File Offset: 0x0029D66C
		// (set) Token: 0x06002B22 RID: 11042 RVA: 0x0029F524 File Offset: 0x0029D724
		internal bool RadProfAlertTonesStandbyChirpsec_A9179_HiddenDynamic
		{
			get
			{
				short num = (short)1578827776;
				short num2 = num;
				num = (short)534452882;
				short num3 = num;
				num = (short)1878792850;
				switch (num3 == num)
				{
				}
				num = (short)1252786176;
				if (num != 0)
				{
				}
				num = (short)776732673;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesStandbyChirpsec_A9179.HiddenDynamic;
			}
			set
			{
				short num = (short)849346560;
				short num2 = num;
				num = (short)698810369;
				if (num != 0)
				{
				}
				num = (short)1367970679;
				short num3 = num;
				num = (short)1466209143;
				switch (num3 == num)
				{
				}
				num = (short)1644560384;
				if (num != 0)
				{
				}
				this.radProfAlertTonesStandbyChirpsec_A9179.HiddenDynamic = value;
			}
		}

		// Token: 0x17001595 RID: 5525
		// (get) Token: 0x06002B23 RID: 11043 RVA: 0x0029F5D8 File Offset: 0x0029D7D8
		public bool RadProfAlertTonesStandbyChirpsec_A9179_HasDiffs
		{
			get
			{
				short num = (short)1813905408;
				short num2 = num;
				num = (short)1262918218;
				short num3 = num;
				num = (short)631216714;
				switch (num3 == num)
				{
				}
				num = (short)1694498817;
				if (num != 0)
				{
				}
				num = (short)102236160;
				if (num != 0)
				{
				}
				return this.radProfAlertTonesStandbyChirpsec_A9179._HasDiffs;
			}
		}

		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x06002B24 RID: 11044 RVA: 0x0029F690 File Offset: 0x0029D890
		// (set) Token: 0x06002B25 RID: 11045 RVA: 0x0029F744 File Offset: 0x0029D944
		public bool RadWideAlertTonesTxChirp_A9523Value
		{
			get
			{
				short num = (short)1965883392;
				short num2 = num;
				num = (short)2079617402;
				short num3 = num;
				num = (short)1088385402;
				switch (num3 == num)
				{
				}
				num = (short)54132736;
				if (num != 0)
				{
				}
				num = (short)901971969;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesTxChirp_A9523.Value;
			}
			set
			{
				short num = (short)235732992;
				short num2 = num;
				num = (short)583625031;
				short num3 = num;
				num = (short)326199623;
				switch (num3 == num)
				{
				}
				num = (short)1513619456;
				if (num != 0)
				{
				}
				num = (short)1686306817;
				if (num != 0)
				{
				}
				this.radWideAlertTonesTxChirp_A9523.Value = value;
			}
		}

		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x06002B26 RID: 11046 RVA: 0x0029F7F8 File Offset: 0x0029D9F8
		public global::AcpBusinessLayer.AcpField<bool> RadWideAlertTonesTxChirp_A9523
		{
			get
			{
				short num = (short)1216282624;
				short num2 = num;
				num = (short)787600646;
				short num3 = num;
				num = (short)351982854;
				switch (num3 == num)
				{
				}
				num = (short)1751384065;
				if (num != 0)
				{
				}
				num = (short)1079705600;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesTxChirp_A9523;
			}
		}

		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x06002B27 RID: 11047 RVA: 0x0029F8A8 File Offset: 0x0029DAA8
		// (set) Token: 0x06002B28 RID: 11048 RVA: 0x0029F95C File Offset: 0x0029DB5C
		public bool RadWideAlertTonesTxChirp_A9523_UIValue
		{
			get
			{
				short num = (short)742785024;
				short num2 = num;
				num = (short)1645473482;
				short num3 = num;
				num = (short)1157951178;
				switch (num3 == num)
				{
				}
				num = (short)2066153473;
				if (num != 0)
				{
				}
				num = (short)999817216;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesTxChirp_A9523.Value;
			}
			set
			{
				short num = (short)890175488;
				short num2 = num;
				num = (short)2074869761;
				if (num != 0)
				{
				}
				num = (short)1200789223;
				short num3 = num;
				num = (short)1370199783;
				switch (num3 == num)
				{
				}
				num = (short)1170276352;
				if (num != 0)
				{
				}
				this.radWideAlertTonesTxChirp_A9523.Value = value;
			}
		}

		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x06002B29 RID: 11049 RVA: 0x0029FA10 File Offset: 0x0029DC10
		// (set) Token: 0x06002B2A RID: 11050 RVA: 0x0029FAC4 File Offset: 0x0029DCC4
		public bool RadWideAlertTonesTxChirp_A9523_Applicable
		{
			get
			{
				short num = (short)1461583872;
				short num2 = num;
				num = (short)1631589787;
				short num3 = num;
				num = (short)1424496027;
				switch (num3 == num)
				{
				}
				num = (short)1945436161;
				if (num != 0)
				{
				}
				num = (short)101122048;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesTxChirp_A9523.Applicable;
			}
			set
			{
				short num = (short)1507786752;
				short num2 = num;
				num = (short)1500500291;
				short num3 = num;
				num = (short)512872771;
				switch (num3 == num)
				{
				}
				num = (short)1340604416;
				if (num != 0)
				{
				}
				num = (short)1412759553;
				if (num != 0)
				{
				}
				this.radWideAlertTonesTxChirp_A9523.Applicable = value;
			}
		}

		// Token: 0x1700159A RID: 5530
		// (get) Token: 0x06002B2B RID: 11051 RVA: 0x0029FB78 File Offset: 0x0029DD78
		// (set) Token: 0x06002B2C RID: 11052 RVA: 0x0029FC2C File Offset: 0x0029DE2C
		public bool RadWideAlertTonesTxChirp_A9523_Valid
		{
			get
			{
				short num = (short)120782848;
				short num2 = num;
				num = (short)33935755;
				short num3 = num;
				num = (short)1864880523;
				switch (num3 == num)
				{
				}
				num = (short)315424768;
				if (num != 0)
				{
				}
				num = (short)382140417;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesTxChirp_A9523.Valid;
			}
			set
			{
				short num = (short)1070268416;
				short num2 = num;
				num = (short)756771920;
				short num3 = num;
				num = (short)626093136;
				switch (num3 == num)
				{
				}
				num = (short)1252458497;
				if (num != 0)
				{
				}
				num = (short)1422000128;
				if (num != 0)
				{
				}
				this.radWideAlertTonesTxChirp_A9523.Valid = value;
			}
		}

		// Token: 0x1700159B RID: 5531
		// (get) Token: 0x06002B2D RID: 11053 RVA: 0x0029FCE4 File Offset: 0x0029DEE4
		// (set) Token: 0x06002B2E RID: 11054 RVA: 0x0029FD98 File Offset: 0x0029DF98
		public bool RadWideAlertTonesTxChirp_A9523_Visible
		{
			get
			{
				short num = (short)818741248;
				short num2 = num;
				num = (short)1211157350;
				short num3 = num;
				num = (short)389139302;
				switch (num3 == num)
				{
				}
				num = (short)270401537;
				if (num != 0)
				{
				}
				num = (short)1440743424;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesTxChirp_A9523.Visible;
			}
			set
			{
				short num = (short)1374158848;
				short num2 = num;
				num = (short)1590737970;
				short num3 = num;
				num = (short)170441778;
				switch (num3 == num)
				{
				}
				num = (short)1237778433;
				if (num != 0)
				{
				}
				num = (short)791674880;
				if (num != 0)
				{
				}
				this.radWideAlertTonesTxChirp_A9523.Visible = value;
			}
		}

		// Token: 0x1700159C RID: 5532
		// (get) Token: 0x06002B2F RID: 11055 RVA: 0x0029FE4C File Offset: 0x0029E04C
		// (set) Token: 0x06002B30 RID: 11056 RVA: 0x0029FF00 File Offset: 0x0029E100
		public bool RadWideAlertTonesTxChirp_A9523_Editable
		{
			get
			{
				short num = (short)598933504;
				short num2 = num;
				num = (short)805892806;
				short num3 = num;
				num = (short)780006086;
				switch (num3 == num)
				{
				}
				num = (short)1779695617;
				if (num != 0)
				{
				}
				num = (short)742260736;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesTxChirp_A9523.Editable;
			}
			set
			{
				short num = (short)503447552;
				short num2 = num;
				num = (short)230162433;
				if (num != 0)
				{
				}
				num = (short)1374370406;
				short num3 = num;
				num = (short)28129894;
				switch (num3 == num)
				{
				}
				num = (short)165412864;
				if (num != 0)
				{
				}
				this.radWideAlertTonesTxChirp_A9523.Editable = value;
			}
		}

		// Token: 0x1700159D RID: 5533
		// (get) Token: 0x06002B31 RID: 11057 RVA: 0x0029FFB8 File Offset: 0x0029E1B8
		internal string RadWideAlertTonesTxChirp_A9523_UILabel
		{
			get
			{
				short num = (short)339804160;
				short num2 = num;
				num = (short)530765052;
				short num3 = num;
				num = (short)1704187132;
				switch (num3 == num)
				{
				}
				num = (short)936902656;
				if (num != 0)
				{
				}
				num = (short)1134428161;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesTxChirp_A9523.UIName;
			}
		}

		// Token: 0x1700159E RID: 5534
		// (get) Token: 0x06002B32 RID: 11058 RVA: 0x002A006C File Offset: 0x0029E26C
		// (set) Token: 0x06002B33 RID: 11059 RVA: 0x002A0120 File Offset: 0x0029E320
		internal bool RadWideAlertTonesTxChirp_A9523_HiddenStatic
		{
			get
			{
				short num = (short)285147136;
				short num2 = num;
				num = (short)1017118721;
				if (num != 0)
				{
				}
				num = (short)1143403022;
				short num3 = num;
				num = (short)2004152846;
				switch (num3 == num)
				{
				}
				num = (short)783482880;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesTxChirp_A9523.HiddenStatic;
			}
			set
			{
				short num = (short)852295680;
				short num2 = num;
				num = (short)613320881;
				short num3 = num;
				num = (short)886278321;
				switch (num3 == num)
				{
				}
				num = (short)1616707584;
				if (num != 0)
				{
				}
				num = (short)898826241;
				if (num != 0)
				{
				}
				this.radWideAlertTonesTxChirp_A9523.HiddenStatic = value;
			}
		}

		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x06002B34 RID: 11060 RVA: 0x002A01D4 File Offset: 0x0029E3D4
		// (set) Token: 0x06002B35 RID: 11061 RVA: 0x002A0288 File Offset: 0x0029E488
		internal bool RadWideAlertTonesTxChirp_A9523_HiddenDynamic
		{
			get
			{
				short num = (short)857538560;
				short num2 = num;
				num = (short)1364426470;
				short num3 = num;
				num = (short)800030438;
				switch (num3 == num)
				{
				}
				num = (short)1327169536;
				if (num != 0)
				{
				}
				num = (short)1818230785;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesTxChirp_A9523.HiddenDynamic;
			}
			set
			{
				short num = (short)290848768;
				short num2 = num;
				num = (short)1454386055;
				short num3 = num;
				num = (short)575417223;
				switch (num3 == num)
				{
				}
				num = (short)498008064;
				if (num != 0)
				{
				}
				num = (short)196739073;
				if (num != 0)
				{
				}
				this.radWideAlertTonesTxChirp_A9523.HiddenDynamic = value;
			}
		}

		// Token: 0x170015A0 RID: 5536
		// (get) Token: 0x06002B36 RID: 11062 RVA: 0x002A0340 File Offset: 0x0029E540
		public bool RadWideAlertTonesTxChirp_A9523_HasDiffs
		{
			get
			{
				short num = (short)905969664;
				short num2 = num;
				num = (short)1622260290;
				short num3 = num;
				num = (short)257276482;
				switch (num3 == num)
				{
				}
				num = (short)2023620609;
				if (num != 0)
				{
				}
				num = (short)1433206784;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesTxChirp_A9523._HasDiffs;
			}
		}

		// Token: 0x170015A1 RID: 5537
		// (get) Token: 0x06002B37 RID: 11063 RVA: 0x002A03F4 File Offset: 0x0029E5F4
		// (set) Token: 0x06002B38 RID: 11064 RVA: 0x002A04A8 File Offset: 0x0029E6A8
		public bool RadWideAlertTonesVolumeAdjustToneOffset_A9656Value
		{
			get
			{
				short num = (short)149094400;
				short num2 = num;
				num = (short)680591361;
				if (num != 0)
				{
				}
				num = (short)2106254599;
				short num3 = num;
				num = (short)1879696647;
				switch (num3 == num)
				{
				}
				num = (short)903217152;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesVolumeAdjustToneOffset_A9656.Value;
			}
			set
			{
				short num = (short)309854208;
				short num2 = num;
				num = (short)1731985409;
				if (num != 0)
				{
				}
				num = (short)2025433136;
				short num3 = num;
				num = (short)858433584;
				switch (num3 == num)
				{
				}
				num = (short)662437888;
				if (num != 0)
				{
				}
				this.radWideAlertTonesVolumeAdjustToneOffset_A9656.Value = value;
			}
		}

		// Token: 0x170015A2 RID: 5538
		// (get) Token: 0x06002B39 RID: 11065 RVA: 0x002A055C File Offset: 0x0029E75C
		public global::AcpBusinessLayer.AcpField<bool> RadWideAlertTonesVolumeAdjustToneOffset_A9656
		{
			get
			{
				short num = (short)945487872;
				short num2 = num;
				num = (short)769830933;
				short num3 = num;
				num = (short)1385082901;
				switch (num3 == num)
				{
				}
				num = (short)66519041;
				if (num != 0)
				{
				}
				num = (short)75563008;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesVolumeAdjustToneOffset_A9656;
			}
		}

		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x06002B3A RID: 11066 RVA: 0x002A060C File Offset: 0x0029E80C
		// (set) Token: 0x06002B3B RID: 11067 RVA: 0x002A06C0 File Offset: 0x0029E8C0
		public bool RadWideAlertTonesVolumeAdjustToneOffset_A9656_UIValue
		{
			get
			{
				short num = (short)1518469120;
				short num2 = num;
				num = (short)756816976;
				short num3 = num;
				num = (short)309861456;
				switch (num3 == num)
				{
				}
				num = (short)717488129;
				if (num != 0)
				{
				}
				num = (short)964100096;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesVolumeAdjustToneOffset_A9656.Value;
			}
			set
			{
				short num = (short)2104360960;
				short num2 = num;
				num = (short)651152196;
				short num3 = num;
				num = (short)1671154500;
				switch (num3 == num)
				{
				}
				num = (short)2122776577;
				if (num != 0)
				{
				}
				num = (short)613220352;
				if (num != 0)
				{
				}
				this.radWideAlertTonesVolumeAdjustToneOffset_A9656.Value = value;
			}
		}

		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x06002B3C RID: 11068 RVA: 0x002A0778 File Offset: 0x0029E978
		// (set) Token: 0x06002B3D RID: 11069 RVA: 0x002A082C File Offset: 0x0029EA2C
		public bool RadWideAlertTonesVolumeAdjustToneOffset_A9656_Applicable
		{
			get
			{
				short num = (short)2064384000;
				short num2 = num;
				num = (short)2087649281;
				if (num != 0)
				{
				}
				num = (short)150311791;
				short num3 = num;
				num = (short)1586008943;
				switch (num3 == num)
				{
				}
				num = (short)1951924224;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesVolumeAdjustToneOffset_A9656.Applicable;
			}
			set
			{
				short num = (short)2028666880;
				short num2 = num;
				num = (short)1014517271;
				short num3 = num;
				num = (short)1895714327;
				switch (num3 == num)
				{
				}
				num = (short)71958529;
				if (num != 0)
				{
				}
				num = (short)215154688;
				if (num != 0)
				{
				}
				this.radWideAlertTonesVolumeAdjustToneOffset_A9656.Applicable = value;
			}
		}

		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x06002B3E RID: 11070 RVA: 0x002A08E4 File Offset: 0x0029EAE4
		// (set) Token: 0x06002B3F RID: 11071 RVA: 0x002A0998 File Offset: 0x0029EB98
		public bool RadWideAlertTonesVolumeAdjustToneOffset_A9656_Valid
		{
			get
			{
				short num = (short)1382154240;
				short num2 = num;
				num = (short)1602764837;
				short num3 = num;
				num = (short)405028901;
				switch (num3 == num)
				{
				}
				num = (short)1356005377;
				if (num != 0)
				{
				}
				num = (short)625475584;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesVolumeAdjustToneOffset_A9656.Valid;
			}
			set
			{
				short num = (short)520814592;
				short num2 = num;
				num = (short)676710465;
				short num3 = num;
				num = (short)1888864321;
				switch (num3 == num)
				{
				}
				num = (short)1825898497;
				if (num != 0)
				{
				}
				num = (short)705036288;
				if (num != 0)
				{
				}
				this.radWideAlertTonesVolumeAdjustToneOffset_A9656.Valid = value;
			}
		}

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x06002B40 RID: 11072 RVA: 0x002A0A4C File Offset: 0x0029EC4C
		// (set) Token: 0x06002B41 RID: 11073 RVA: 0x002A0B00 File Offset: 0x0029ED00
		public bool RadWideAlertTonesVolumeAdjustToneOffset_A9656_Visible
		{
			get
			{
				short num = (short)1224802304;
				short num2 = num;
				num = (short)2054881624;
				short num3 = num;
				num = (short)1558774104;
				switch (num3 == num)
				{
				}
				num = (short)1507721217;
				if (num != 0)
				{
				}
				num = (short)1276772352;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesVolumeAdjustToneOffset_A9656.Visible;
			}
			set
			{
				short num = (short)2029453312;
				short num2 = num;
				num = (short)1281173442;
				short num3 = num;
				num = (short)866265026;
				switch (num3 == num)
				{
				}
				num = (short)2044264449;
				if (num != 0)
				{
				}
				num = (short)841154560;
				if (num != 0)
				{
				}
				this.radWideAlertTonesVolumeAdjustToneOffset_A9656.Visible = value;
			}
		}

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x06002B42 RID: 11074 RVA: 0x002A0BB4 File Offset: 0x0029EDB4
		// (set) Token: 0x06002B43 RID: 11075 RVA: 0x002A0C68 File Offset: 0x0029EE68
		public bool RadWideAlertTonesVolumeAdjustToneOffset_A9656_Editable
		{
			get
			{
				short num = (short)277348352;
				short num2 = num;
				num = (short)563495607;
				short num3 = num;
				num = (short)121324215;
				switch (num3 == num)
				{
				}
				num = (short)1872560129;
				if (num != 0)
				{
				}
				num = (short)546570240;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesVolumeAdjustToneOffset_A9656.Editable;
			}
			set
			{
				short num = (short)1168965632;
				short num2 = num;
				num = (short)818044295;
				short num3 = num;
				num = (short)229989767;
				switch (num3 == num)
				{
				}
				num = (short)316801025;
				if (num != 0)
				{
				}
				num = (short)1596194816;
				if (num != 0)
				{
				}
				this.radWideAlertTonesVolumeAdjustToneOffset_A9656.Editable = value;
			}
		}

		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x06002B44 RID: 11076 RVA: 0x002A0D1C File Offset: 0x0029EF1C
		internal string RadWideAlertTonesVolumeAdjustToneOffset_A9656_UILabel
		{
			get
			{
				short num = (short)138412032;
				short num2 = num;
				num = (short)370121699;
				short num3 = num;
				num = (short)450468835;
				switch (num3 == num)
				{
				}
				num = (short)2063728641;
				if (num != 0)
				{
				}
				num = (short)1059717120;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesVolumeAdjustToneOffset_A9656.UIName;
			}
		}

		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x06002B45 RID: 11077 RVA: 0x002A0DD0 File Offset: 0x0029EFD0
		// (set) Token: 0x06002B46 RID: 11078 RVA: 0x002A0E84 File Offset: 0x0029F084
		internal bool RadWideAlertTonesVolumeAdjustToneOffset_A9656_HiddenStatic
		{
			get
			{
				short num = (short)532873216;
				short num2 = num;
				num = (short)1371042015;
				short num3 = num;
				num = (short)1987866847;
				switch (num3 == num)
				{
				}
				num = (short)387383297;
				if (num != 0)
				{
				}
				num = (short)1473249280;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesVolumeAdjustToneOffset_A9656.HiddenStatic;
			}
			set
			{
				short num = (short)419233792;
				short num2 = num;
				num = (short)1071156454;
				short num3 = num;
				num = (short)670338278;
				switch (num3 == num)
				{
				}
				num = (short)1371996161;
				if (num != 0)
				{
				}
				num = (short)331939840;
				if (num != 0)
				{
				}
				this.radWideAlertTonesVolumeAdjustToneOffset_A9656.HiddenStatic = value;
			}
		}

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x06002B47 RID: 11079 RVA: 0x002A0F38 File Offset: 0x0029F138
		// (set) Token: 0x06002B48 RID: 11080 RVA: 0x002A0FEC File Offset: 0x0029F1EC
		internal bool RadWideAlertTonesVolumeAdjustToneOffset_A9656_HiddenDynamic
		{
			get
			{
				short num = (short)947847168;
				short num2 = num;
				num = (short)979304449;
				if (num != 0)
				{
				}
				num = (short)400670454;
				short num3 = num;
				num = (short)203472630;
				switch (num3 == num)
				{
				}
				num = (short)1892286464;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesVolumeAdjustToneOffset_A9656.HiddenDynamic;
			}
			set
			{
				short num = (short)222953472;
				short num2 = num;
				num = (short)1570335872;
				short num3 = num;
				num = (short)1650093184;
				switch (num3 == num)
				{
				}
				num = (short)1336803328;
				if (num != 0)
				{
				}
				num = (short)1743585281;
				if (num != 0)
				{
				}
				this.radWideAlertTonesVolumeAdjustToneOffset_A9656.HiddenDynamic = value;
			}
		}

		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x06002B49 RID: 11081 RVA: 0x002A10A0 File Offset: 0x0029F2A0
		public bool RadWideAlertTonesVolumeAdjustToneOffset_A9656_HasDiffs
		{
			get
			{
				short num = (short)847904768;
				short num2 = num;
				num = (short)1947046737;
				short num3 = num;
				num = (short)60134225;
				switch (num3 == num)
				{
				}
				num = (short)582483969;
				if (num != 0)
				{
				}
				num = (short)1164509184;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesVolumeAdjustToneOffset_A9656._HasDiffs;
			}
		}

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x06002B4A RID: 11082 RVA: 0x002A1154 File Offset: 0x0029F354
		// (set) Token: 0x06002B4B RID: 11083 RVA: 0x002A1208 File Offset: 0x0029F408
		public bool RadWideAlertTonesZeroLevelAudioMute_A9689Value
		{
			get
			{
				short num = (short)1340342272;
				short num2 = num;
				num = (short)2038517918;
				short num3 = num;
				num = (short)383930526;
				switch (num3 == num)
				{
				}
				num = (short)1871839232;
				if (num != 0)
				{
				}
				num = (short)1351811073;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesZeroLevelAudioMute_A9689.Value;
			}
			set
			{
				short num = (short)1910374400;
				short num2 = num;
				num = (short)365025871;
				short num3 = num;
				num = (short)607640143;
				switch (num3 == num)
				{
				}
				num = (short)1003814912;
				if (num != 0)
				{
				}
				num = (short)1604845569;
				if (num != 0)
				{
				}
				this.radWideAlertTonesZeroLevelAudioMute_A9689.Value = value;
			}
		}

		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x06002B4C RID: 11084 RVA: 0x002A12BC File Offset: 0x0029F4BC
		public global::AcpBusinessLayer.AcpField<bool> RadWideAlertTonesZeroLevelAudioMute_A9689
		{
			get
			{
				short num = (short)1799159808;
				short num2 = num;
				num = (short)874840065;
				if (num != 0)
				{
				}
				num = (short)1812266138;
				short num3 = num;
				num = (short)1238629530;
				switch (num3 == num)
				{
				}
				num = (short)1966211072;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesZeroLevelAudioMute_A9689;
			}
		}

		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x06002B4D RID: 11085 RVA: 0x002A136C File Offset: 0x0029F56C
		// (set) Token: 0x06002B4E RID: 11086 RVA: 0x002A1420 File Offset: 0x0029F620
		public bool RadWideAlertTonesZeroLevelAudioMute_A9689_UIValue
		{
			get
			{
				short num = (short)1519386624;
				short num2 = num;
				num = (short)1779793532;
				short num3 = num;
				num = (short)1877573244;
				switch (num3 == num)
				{
				}
				num = (short)1166344192;
				if (num != 0)
				{
				}
				num = (short)1031864321;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesZeroLevelAudioMute_A9689.Value;
			}
			set
			{
				short num = (short)1823775564;
				short num2 = num;
				num = (short)623287116;
				switch (num2 == num)
				{
				}
				num = (short)74907648;
				if (num != 0)
				{
				}
				num = (short)1353318400;
				short num3 = num;
				num = (short)1522532353;
				if (num != 0)
				{
				}
				this.radWideAlertTonesZeroLevelAudioMute_A9689.Value = value;
			}
		}

		// Token: 0x170015AF RID: 5551
		// (get) Token: 0x06002B4F RID: 11087 RVA: 0x002A14D4 File Offset: 0x0029F6D4
		// (set) Token: 0x06002B50 RID: 11088 RVA: 0x002A1588 File Offset: 0x0029F788
		public bool RadWideAlertTonesZeroLevelAudioMute_A9689_Applicable
		{
			get
			{
				short num = (short)664967124;
				short num2 = num;
				num = (short)1373804500;
				switch (num2 == num)
				{
				}
				num = (short)2126839809;
				if (num != 0)
				{
				}
				num = (short)108724224;
				short num3 = num;
				num = (short)1690042368;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesZeroLevelAudioMute_A9689.Applicable;
			}
			set
			{
				short num = (short)808128449;
				short num2 = num;
				num = (short)349310913;
				switch (num2 == num)
				{
				}
				num = (short)1121648641;
				if (num != 0)
				{
				}
				num = (short)1870266368;
				short num3 = num;
				num = (short)746848256;
				if (num != 0)
				{
				}
				this.radWideAlertTonesZeroLevelAudioMute_A9689.Applicable = value;
			}
		}

		// Token: 0x170015B0 RID: 5552
		// (get) Token: 0x06002B51 RID: 11089 RVA: 0x002A163C File Offset: 0x0029F83C
		// (set) Token: 0x06002B52 RID: 11090 RVA: 0x002A16F0 File Offset: 0x0029F8F0
		public bool RadWideAlertTonesZeroLevelAudioMute_A9689_Valid
		{
			get
			{
				short num = (short)1557266433;
				if (num != 0)
				{
				}
				num = (short)296901103;
				short num2 = num;
				num = (short)1018780143;
				switch (num2 == num)
				{
				}
				num = (short)529268736;
				short num3 = num;
				num = (short)1754464256;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesZeroLevelAudioMute_A9689.Valid;
			}
			set
			{
				short num = (short)1809835204;
				short num2 = num;
				num = (short)154002628;
				switch (num2 == num)
				{
				}
				num = (short)1298857985;
				if (num != 0)
				{
				}
				num = (short)2126315520;
				short num3 = num;
				num = (short)1616707584;
				if (num != 0)
				{
				}
				this.radWideAlertTonesZeroLevelAudioMute_A9689.Valid = value;
			}
		}

		// Token: 0x170015B1 RID: 5553
		// (get) Token: 0x06002B53 RID: 11091 RVA: 0x002A17A4 File Offset: 0x0029F9A4
		// (set) Token: 0x06002B54 RID: 11092 RVA: 0x002A185C File Offset: 0x0029FA5C
		public bool RadWideAlertTonesZeroLevelAudioMute_A9689_Visible
		{
			get
			{
				short num = (short)1566734400;
				short num2 = num;
				num = (short)1463384128;
				switch (num2 == num)
				{
				}
				num = (short)1329463296;
				if (num != 0)
				{
				}
				num = (short)1154220032;
				short num3 = num;
				num = (short)9437185;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesZeroLevelAudioMute_A9689.Visible;
			}
			set
			{
				short num = (short)2146087306;
				short num2 = num;
				num = (short)556904842;
				switch (num2 == num)
				{
				}
				num = (short)170328065;
				if (num != 0)
				{
				}
				num = (short)1171259392;
				short num3 = num;
				num = (short)753467392;
				if (num != 0)
				{
				}
				this.radWideAlertTonesZeroLevelAudioMute_A9689.Visible = value;
			}
		}

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x06002B55 RID: 11093 RVA: 0x002A1910 File Offset: 0x0029FB10
		// (set) Token: 0x06002B56 RID: 11094 RVA: 0x002A19C4 File Offset: 0x0029FBC4
		public bool RadWideAlertTonesZeroLevelAudioMute_A9689_Editable
		{
			get
			{
				short num = (short)1026752513;
				if (num != 0)
				{
				}
				num = (short)781646167;
				short num2 = num;
				num = (short)782235991;
				switch (num2 == num)
				{
				}
				num = (short)918355968;
				short num3 = num;
				num = (short)617938944;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesZeroLevelAudioMute_A9689.Editable;
			}
			set
			{
				short num = (short)1372138442;
				short num2 = num;
				num = (short)1007168458;
				switch (num2 == num)
				{
				}
				num = (short)345964544;
				if (num != 0)
				{
				}
				num = (short)1903755264;
				short num3 = num;
				num = (short)1206648833;
				if (num != 0)
				{
				}
				this.radWideAlertTonesZeroLevelAudioMute_A9689.Editable = value;
			}
		}

		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x06002B57 RID: 11095 RVA: 0x002A1A78 File Offset: 0x0029FC78
		internal string RadWideAlertTonesZeroLevelAudioMute_A9689_UILabel
		{
			get
			{
				short num = (short)675572259;
				short num2 = num;
				num = (short)1481665059;
				switch (num2 == num)
				{
				}
				num = (short)407044096;
				if (num != 0)
				{
				}
				num = (short)546439168;
				short num3 = num;
				num = (short)1576009729;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesZeroLevelAudioMute_A9689.UIName;
			}
		}

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x06002B58 RID: 11096 RVA: 0x002A1B2C File Offset: 0x0029FD2C
		// (set) Token: 0x06002B59 RID: 11097 RVA: 0x002A1BE0 File Offset: 0x0029FDE0
		internal bool RadWideAlertTonesZeroLevelAudioMute_A9689_HiddenStatic
		{
			get
			{
				short num = (short)234315856;
				short num2 = num;
				num = (short)1485070416;
				switch (num2 == num)
				{
				}
				num = (short)2000551937;
				if (num != 0)
				{
				}
				num = (short)1404895232;
				short num3 = num;
				num = (short)1390149632;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesZeroLevelAudioMute_A9689.HiddenStatic;
			}
			set
			{
				short num = (short)332639855;
				short num2 = num;
				num = (short)658091631;
				switch (num2 == num)
				{
				}
				num = (short)819265536;
				if (num != 0)
				{
				}
				num = (short)1916272640;
				short num3 = num;
				num = (short)1398013953;
				if (num != 0)
				{
				}
				this.radWideAlertTonesZeroLevelAudioMute_A9689.HiddenStatic = value;
			}
		}

		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x06002B5A RID: 11098 RVA: 0x002A1C94 File Offset: 0x0029FE94
		// (set) Token: 0x06002B5B RID: 11099 RVA: 0x002A1D48 File Offset: 0x0029FF48
		internal bool RadWideAlertTonesZeroLevelAudioMute_A9689_HiddenDynamic
		{
			get
			{
				short num = (short)1133638170;
				short num2 = num;
				num = (short)1849946650;
				switch (num2 == num)
				{
				}
				num = (short)1503854593;
				if (num != 0)
				{
				}
				num = (short)411107328;
				short num3 = num;
				num = (short)383385600;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesZeroLevelAudioMute_A9689.HiddenDynamic;
			}
			set
			{
				short num = (short)395952484;
				short num2 = num;
				num = (short)2116469092;
				switch (num2 == num)
				{
				}
				num = (short)1661861889;
				if (num != 0)
				{
				}
				num = (short)667942912;
				short num3 = num;
				num = (short)1878720512;
				if (num != 0)
				{
				}
				this.radWideAlertTonesZeroLevelAudioMute_A9689.HiddenDynamic = value;
			}
		}

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x06002B5C RID: 11100 RVA: 0x002A1DFC File Offset: 0x0029FFFC
		public bool RadWideAlertTonesZeroLevelAudioMute_A9689_HasDiffs
		{
			get
			{
				short num = (short)1054297335;
				short num2 = num;
				num = (short)286018807;
				switch (num2 == num)
				{
				}
				num = (short)349503489;
				if (num != 0)
				{
				}
				num = (short)2041380864;
				short num3 = num;
				num = (short)795017216;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesZeroLevelAudioMute_A9689._HasDiffs;
			}
		}

		// Token: 0x170015B7 RID: 5559
		// (get) Token: 0x06002B5D RID: 11101 RVA: 0x002A1EB0 File Offset: 0x002A00B0
		// (set) Token: 0x06002B5E RID: 11102 RVA: 0x002A1F64 File Offset: 0x002A0164
		public bool RadWideAlertTonesScanAlertToneEnable_A19555Value
		{
			get
			{
				short num = (short)835258818;
				short num2 = num;
				num = (short)1210845634;
				switch (num2 == num)
				{
				}
				num = (short)498991105;
				if (num != 0)
				{
				}
				num = (short)1856962560;
				short num3 = num;
				num = (short)350289920;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesScanAlertToneEnable_A19555.Value;
			}
			set
			{
				short num = (short)520772443;
				short num2 = num;
				num = (short)1349213019;
				switch (num2 == num)
				{
				}
				num = (short)1646854145;
				if (num != 0)
				{
				}
				num = (short)1399390208;
				short num3 = num;
				num = (short)659423232;
				if (num != 0)
				{
				}
				this.radWideAlertTonesScanAlertToneEnable_A19555.Value = value;
			}
		}

		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x06002B5F RID: 11103 RVA: 0x002A201C File Offset: 0x002A021C
		public global::AcpBusinessLayer.AcpField<bool> RadWideAlertTonesScanAlertToneEnable_A19555
		{
			get
			{
				short num = (short)17582288;
				short num2 = num;
				num = (short)400050384;
				switch (num2 == num)
				{
				}
				num = (short)424804353;
				if (num != 0)
				{
				}
				num = (short)1437794304;
				short num3 = num;
				num = (short)1049952256;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesScanAlertToneEnable_A19555;
			}
		}

		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x06002B60 RID: 11104 RVA: 0x002A20CC File Offset: 0x002A02CC
		// (set) Token: 0x06002B61 RID: 11105 RVA: 0x002A2184 File Offset: 0x002A0384
		public bool RadWideAlertTonesScanAlertToneEnable_A19555_UIValue
		{
			get
			{
				short num = (short)488101238;
				short num2 = num;
				num = (short)753456502;
				switch (num2 == num)
				{
				}
				num = (short)2100953089;
				if (num != 0)
				{
				}
				num = (short)560332800;
				short num3 = num;
				num = (short)2028732416;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesScanAlertToneEnable_A19555.Value;
			}
			set
			{
				short num = (short)1849297154;
				short num2 = num;
				num = (short)1386612994;
				switch (num2 == num)
				{
				}
				num = (short)1921318913;
				if (num != 0)
				{
				}
				num = (short)2062680064;
				short num3 = num;
				num = (short)555745280;
				if (num != 0)
				{
				}
				this.radWideAlertTonesScanAlertToneEnable_A19555.Value = value;
			}
		}

		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x06002B62 RID: 11106 RVA: 0x002A223C File Offset: 0x002A043C
		// (set) Token: 0x06002B63 RID: 11107 RVA: 0x002A22F4 File Offset: 0x002A04F4
		public bool RadWideAlertTonesScanAlertToneEnable_A19555_Applicable
		{
			get
			{
				short num = (short)1375326259;
				short num2 = num;
				num = (short)647155763;
				switch (num2 == num)
				{
				}
				num = (short)54919169;
				if (num != 0)
				{
				}
				num = (short)572588032;
				short num3 = num;
				num = (short)1184432128;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesScanAlertToneEnable_A19555.Applicable;
			}
			set
			{
				short num = (short)808058881;
				if (num != 0)
				{
				}
				num = (short)1794000014;
				short num2 = num;
				num = (short)1556956302;
				switch (num2 == num)
				{
				}
				num = (short)162529280;
				short num3 = num;
				num = (short)33619968;
				if (num != 0)
				{
				}
				this.radWideAlertTonesScanAlertToneEnable_A19555.Applicable = value;
			}
		}

		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x06002B64 RID: 11108 RVA: 0x002A23AC File Offset: 0x002A05AC
		// (set) Token: 0x06002B65 RID: 11109 RVA: 0x002A2464 File Offset: 0x002A0664
		public bool RadWideAlertTonesScanAlertToneEnable_A19555_Valid
		{
			get
			{
				short num = (short)272891905;
				if (num != 0)
				{
				}
				num = (short)1559988399;
				short num2 = num;
				num = (short)1483114671;
				switch (num2 == num)
				{
				}
				num = (short)1136001024;
				short num3 = num;
				num = (short)302448640;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesScanAlertToneEnable_A19555.Valid;
			}
			set
			{
				short num = (short)264527531;
				short num2 = num;
				num = (short)1273126571;
				switch (num2 == num)
				{
				}
				num = (short)824180736;
				if (num != 0)
				{
				}
				num = (short)1888157696;
				short num3 = num;
				num = (short)143589377;
				if (num != 0)
				{
				}
				this.radWideAlertTonesScanAlertToneEnable_A19555.Valid = value;
			}
		}

		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x06002B66 RID: 11110 RVA: 0x002A251C File Offset: 0x002A071C
		// (set) Token: 0x06002B67 RID: 11111 RVA: 0x002A25D0 File Offset: 0x002A07D0
		public bool RadWideAlertTonesScanAlertToneEnable_A19555_Visible
		{
			get
			{
				short num = (short)550983395;
				short num2 = num;
				num = (short)491935459;
				switch (num2 == num)
				{
				}
				num = (short)1483014145;
				if (num != 0)
				{
				}
				num = (short)2013331456;
				short num3 = num;
				num = (short)946405376;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesScanAlertToneEnable_A19555.Visible;
			}
			set
			{
				short num = (short)237685126;
				short num2 = num;
				num = (short)1207290246;
				switch (num2 == num)
				{
				}
				num = (short)53149696;
				if (num != 0)
				{
				}
				num = (short)2057437184;
				short num3 = num;
				num = (short)683999233;
				if (num != 0)
				{
				}
				this.radWideAlertTonesScanAlertToneEnable_A19555.Visible = value;
			}
		}

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x06002B68 RID: 11112 RVA: 0x002A2688 File Offset: 0x002A0888
		// (set) Token: 0x06002B69 RID: 11113 RVA: 0x002A273C File Offset: 0x002A093C
		public bool RadWideAlertTonesScanAlertToneEnable_A19555_Editable
		{
			get
			{
				short num = (short)1632305153;
				if (num != 0)
				{
				}
				num = (short)1763133462;
				short num2 = num;
				num = (short)234309654;
				switch (num2 == num)
				{
				}
				num = (short)568721408;
				short num3 = num;
				num = (short)988741632;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesScanAlertToneEnable_A19555.Editable;
			}
			set
			{
				short num = (short)1754791937;
				if (num != 0)
				{
				}
				num = (short)28390167;
				short num2 = num;
				num = (short)1315189527;
				switch (num2 == num)
				{
				}
				num = (short)1676869632;
				short num3 = num;
				num = (short)1889861632;
				if (num != 0)
				{
				}
				this.radWideAlertTonesScanAlertToneEnable_A19555.Editable = value;
			}
		}

		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x06002B6A RID: 11114 RVA: 0x002A27F4 File Offset: 0x002A09F4
		internal string RadWideAlertTonesScanAlertToneEnable_A19555_UILabel
		{
			get
			{
				short num = (short)681385008;
				short num2 = num;
				num = (short)1422335024;
				switch (num2 == num)
				{
				}
				num = (short)1081278464;
				if (num != 0)
				{
				}
				num = (short)119275520;
				short num3 = num;
				num = (short)580059137;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesScanAlertToneEnable_A19555.UIName;
			}
		}

		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x06002B6B RID: 11115 RVA: 0x002A28AC File Offset: 0x002A0AAC
		// (set) Token: 0x06002B6C RID: 11116 RVA: 0x002A2960 File Offset: 0x002A0B60
		internal bool RadWideAlertTonesScanAlertToneEnable_A19555_HiddenStatic
		{
			get
			{
				short num = (short)830139285;
				short num2 = num;
				num = (short)882371477;
				switch (num2 == num)
				{
				}
				num = (short)1593311233;
				if (num != 0)
				{
				}
				num = (short)964820992;
				short num3 = num;
				num = (short)642121728;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesScanAlertToneEnable_A19555.HiddenStatic;
			}
			set
			{
				short num = (short)571005672;
				short num2 = num;
				num = (short)780196584;
				switch (num2 == num)
				{
				}
				num = (short)260636672;
				if (num != 0)
				{
				}
				num = (short)1863450624;
				short num3 = num;
				num = (short)1518534657;
				if (num != 0)
				{
				}
				this.radWideAlertTonesScanAlertToneEnable_A19555.HiddenStatic = value;
			}
		}

		// Token: 0x170015C0 RID: 5568
		// (get) Token: 0x06002B6D RID: 11117 RVA: 0x002A2A14 File Offset: 0x002A0C14
		// (set) Token: 0x06002B6E RID: 11118 RVA: 0x002A2AC8 File Offset: 0x002A0CC8
		internal bool RadWideAlertTonesScanAlertToneEnable_A19555_HiddenDynamic
		{
			get
			{
				short num = (short)675471346;
				short num2 = num;
				num = (short)447209458;
				switch (num2 == num)
				{
				}
				num = (short)1843331073;
				if (num != 0)
				{
				}
				num = (short)5898240;
				short num3 = num;
				num = (short)2107506688;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesScanAlertToneEnable_A19555.HiddenDynamic;
			}
			set
			{
				short num = (short)532873217;
				if (num != 0)
				{
				}
				num = (short)1518856301;
				short num2 = num;
				num = (short)1847650413;
				switch (num2 == num)
				{
				}
				num = (short)1776877568;
				short num3 = num;
				num = (short)691798016;
				if (num != 0)
				{
				}
				this.radWideAlertTonesScanAlertToneEnable_A19555.HiddenDynamic = value;
			}
		}

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x06002B6F RID: 11119 RVA: 0x002A2B80 File Offset: 0x002A0D80
		public bool RadWideAlertTonesScanAlertToneEnable_A19555_HasDiffs
		{
			get
			{
				short num = (short)165423539;
				short num2 = num;
				num = (short)1091578291;
				switch (num2 == num)
				{
				}
				num = (short)312999937;
				if (num != 0)
				{
				}
				num = (short)27983872;
				short num3 = num;
				num = (short)288751616;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesScanAlertToneEnable_A19555._HasDiffs;
			}
		}

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x06002B70 RID: 11120 RVA: 0x002A2C34 File Offset: 0x002A0E34
		// (set) Token: 0x06002B71 RID: 11121 RVA: 0x002A2CE8 File Offset: 0x002A0EE8
		public int RadWideAdvancedSmartLowBatteryAlert_A9165Value
		{
			get
			{
				short num = (short)1498682568;
				short num2 = num;
				num = (short)877728968;
				switch (num2 == num)
				{
				}
				num = (short)1819607041;
				if (num != 0)
				{
				}
				num = (short)1155858432;
				short num3 = num;
				num = (short)816119808;
				if (num != 0)
				{
				}
				return this.radWideAdvancedSmartLowBatteryAlert_A9165.Value;
			}
			set
			{
				short num = (short)167675003;
				short num2 = num;
				num = (short)2024899707;
				switch (num2 == num)
				{
				}
				num = (short)669057024;
				if (num != 0)
				{
				}
				num = (short)1678180352;
				short num3 = num;
				num = (short)992280577;
				if (num != 0)
				{
				}
				this.radWideAdvancedSmartLowBatteryAlert_A9165.Value = value;
			}
		}

		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x06002B72 RID: 11122 RVA: 0x002A2D9C File Offset: 0x002A0F9C
		// (set) Token: 0x06002B73 RID: 11123 RVA: 0x002A2E50 File Offset: 0x002A1050
		public string RadWideAdvancedSmartLowBatteryAlert_A9165_UIValue
		{
			get
			{
				short num = (short)409534465;
				if (num != 0)
				{
				}
				num = (short)157006722;
				short num2 = num;
				num = (short)733133698;
				switch (num2 == num)
				{
				}
				num = (short)1689059328;
				short num3 = num;
				num = (short)1298530304;
				if (num != 0)
				{
				}
				return this.radWideAdvancedSmartLowBatteryAlert_A9165.UIValue;
			}
			set
			{
				short num = (short)1191786879;
				short num2 = num;
				num = (short)1002453375;
				switch (num2 == num)
				{
				}
				num = (short)276430848;
				if (num != 0)
				{
				}
				num = (short)1325334528;
				short num3 = num;
				num = (short)278134785;
				if (num != 0)
				{
				}
				this.radWideAdvancedSmartLowBatteryAlert_A9165.UIValue = value;
			}
		}

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x06002B74 RID: 11124 RVA: 0x002A2F04 File Offset: 0x002A1104
		public global::AcpBusinessLayer.AcpListField RadWideAdvancedSmartLowBatteryAlert_A9165
		{
			get
			{
				short num = (short)762472786;
				short num2 = num;
				num = (short)1803970898;
				switch (num2 == num)
				{
				}
				num = (short)458686465;
				if (num != 0)
				{
				}
				num = (short)1810235392;
				short num3 = num;
				num = (short)195493888;
				if (num != 0)
				{
				}
				return this.radWideAdvancedSmartLowBatteryAlert_A9165;
			}
		}

		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x06002B75 RID: 11125 RVA: 0x002A2FB4 File Offset: 0x002A11B4
		// (set) Token: 0x06002B76 RID: 11126 RVA: 0x002A306C File Offset: 0x002A126C
		public bool RadWideAdvancedSmartLowBatteryAlert_A9165_Applicable
		{
			get
			{
				short num = (short)623822821;
				short num2 = num;
				num = (short)1175832549;
				switch (num2 == num)
				{
				}
				num = (short)1488125953;
				if (num != 0)
				{
				}
				num = (short)536346624;
				short num3 = num;
				num = (short)2038366208;
				if (num != 0)
				{
				}
				return this.radWideAdvancedSmartLowBatteryAlert_A9165.Applicable;
			}
			set
			{
				short num = (short)1408177847;
				short num2 = num;
				num = (short)1467094711;
				switch (num2 == num)
				{
				}
				num = (short)798818305;
				if (num != 0)
				{
				}
				num = (short)233046016;
				short num3 = num;
				num = (short)533790720;
				if (num != 0)
				{
				}
				this.radWideAdvancedSmartLowBatteryAlert_A9165.Applicable = value;
			}
		}

		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x06002B77 RID: 11127 RVA: 0x002A3120 File Offset: 0x002A1320
		// (set) Token: 0x06002B78 RID: 11128 RVA: 0x002A31D0 File Offset: 0x002A13D0
		public bool RadWideAdvancedSmartLowBatteryAlert_A9165_Valid
		{
			get
			{
				short num = (short)900597761;
				short num2 = num;
				num = (short)10356737;
				switch (num2 == num)
				{
				}
				num = (short)2009268225;
				if (num != 0)
				{
				}
				num = (short)114294784;
				short num3 = num;
				num = (short)591134720;
				if (num != 0)
				{
				}
				return this.radWideAdvancedSmartLowBatteryAlert_A9165.Valid;
			}
			set
			{
				short num = (short)769850360;
				short num2 = num;
				num = (short)887421944;
				switch (num2 == num)
				{
				}
				num = (short)770113537;
				if (num != 0)
				{
				}
				num = (short)1067122688;
				short num3 = num;
				num = (short)751632384;
				if (num != 0)
				{
				}
				this.radWideAdvancedSmartLowBatteryAlert_A9165.Valid = value;
			}
		}

		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x06002B79 RID: 11129 RVA: 0x002A3288 File Offset: 0x002A1488
		// (set) Token: 0x06002B7A RID: 11130 RVA: 0x002A333C File Offset: 0x002A153C
		public bool RadWideAdvancedSmartLowBatteryAlert_A9165_Visible
		{
			get
			{
				short num = (short)825088148;
				short num2 = num;
				num = (short)36362388;
				switch (num2 == num)
				{
				}
				num = (short)408616961;
				if (num != 0)
				{
				}
				num = (short)254869504;
				short num3 = num;
				num = (short)226164736;
				if (num != 0)
				{
				}
				return this.radWideAdvancedSmartLowBatteryAlert_A9165.Visible;
			}
			set
			{
				short num = (short)1954480129;
				if (num != 0)
				{
				}
				num = (short)914750775;
				short num2 = num;
				num = (short)1225653559;
				switch (num2 == num)
				{
				}
				num = (short)1831272448;
				short num3 = num;
				num = (short)888930304;
				if (num != 0)
				{
				}
				this.radWideAdvancedSmartLowBatteryAlert_A9165.Visible = value;
			}
		}

		// Token: 0x170015C8 RID: 5576
		// (get) Token: 0x06002B7B RID: 11131 RVA: 0x002A33F4 File Offset: 0x002A15F4
		// (set) Token: 0x06002B7C RID: 11132 RVA: 0x002A34A8 File Offset: 0x002A16A8
		public bool RadWideAdvancedSmartLowBatteryAlert_A9165_Editable
		{
			get
			{
				short num = (short)1750789491;
				short num2 = num;
				num = (short)1133768051;
				switch (num2 == num)
				{
				}
				num = (short)39845888;
				if (num != 0)
				{
				}
				num = (short)1895956480;
				short num3 = num;
				num = (short)740425729;
				if (num != 0)
				{
				}
				return this.radWideAdvancedSmartLowBatteryAlert_A9165.Editable;
			}
			set
			{
				short num = (short)225541829;
				short num2 = num;
				num = (short)1293844165;
				switch (num2 == num)
				{
				}
				num = (short)1064894464;
				if (num != 0)
				{
				}
				num = (short)1283325952;
				short num3 = num;
				num = (short)2014117889;
				if (num != 0)
				{
				}
				this.radWideAdvancedSmartLowBatteryAlert_A9165.Editable = value;
			}
		}

		// Token: 0x170015C9 RID: 5577
		// (get) Token: 0x06002B7D RID: 11133 RVA: 0x002A355C File Offset: 0x002A175C
		internal string RadWideAdvancedSmartLowBatteryAlert_A9165_UILabel
		{
			get
			{
				short num = (short)829672321;
				short num2 = num;
				num = (short)831769473;
				switch (num2 == num)
				{
				}
				num = (short)2139947009;
				if (num != 0)
				{
				}
				num = (short)900661248;
				short num3 = num;
				num = (short)830865408;
				if (num != 0)
				{
				}
				return this.radWideAdvancedSmartLowBatteryAlert_A9165.UIName;
			}
		}

		// Token: 0x170015CA RID: 5578
		// (get) Token: 0x06002B7E RID: 11134 RVA: 0x002A3610 File Offset: 0x002A1810
		// (set) Token: 0x06002B7F RID: 11135 RVA: 0x002A36C4 File Offset: 0x002A18C4
		internal bool RadWideAdvancedSmartLowBatteryAlert_A9165_HiddenStatic
		{
			get
			{
				short num = (short)1156739582;
				short num2 = num;
				num = (short)95449598;
				switch (num2 == num)
				{
				}
				num = (short)1743126529;
				if (num != 0)
				{
				}
				num = (short)2019819520;
				short num3 = num;
				num = (short)1889009664;
				if (num != 0)
				{
				}
				return this.radWideAdvancedSmartLowBatteryAlert_A9165.HiddenStatic;
			}
			set
			{
				short num = (short)960258749;
				short num2 = num;
				num = (short)808215229;
				switch (num2 == num)
				{
				}
				num = (short)1903296513;
				if (num != 0)
				{
				}
				num = (short)197263360;
				short num3 = num;
				num = (short)2013724672;
				if (num != 0)
				{
				}
				this.radWideAdvancedSmartLowBatteryAlert_A9165.HiddenStatic = value;
			}
		}

		// Token: 0x170015CB RID: 5579
		// (get) Token: 0x06002B80 RID: 11136 RVA: 0x002A3778 File Offset: 0x002A1978
		// (set) Token: 0x06002B81 RID: 11137 RVA: 0x002A382C File Offset: 0x002A1A2C
		internal bool RadWideAdvancedSmartLowBatteryAlert_A9165_HiddenDynamic
		{
			get
			{
				short num = (short)1777809398;
				short num2 = num;
				num = (short)1131886582;
				switch (num2 == num)
				{
				}
				num = (short)1590755328;
				if (num != 0)
				{
				}
				num = (short)56426496;
				short num3 = num;
				num = (short)189530113;
				if (num != 0)
				{
				}
				return this.radWideAdvancedSmartLowBatteryAlert_A9165.HiddenDynamic;
			}
			set
			{
				short num = (short)1122764750;
				short num2 = num;
				num = (short)722601934;
				switch (num2 == num)
				{
				}
				num = (short)1114046465;
				if (num != 0)
				{
				}
				num = (short)1553530880;
				if (num != 0)
				{
				}
				num = (short)803733504;
				short num3 = num;
				this.radWideAdvancedSmartLowBatteryAlert_A9165.HiddenDynamic = value;
			}
		}

		// Token: 0x170015CC RID: 5580
		// (get) Token: 0x06002B82 RID: 11138 RVA: 0x002A38E0 File Offset: 0x002A1AE0
		public bool RadWideAdvancedSmartLowBatteryAlert_A9165_HasDiffs
		{
			get
			{
				short num = (short)1967457497;
				short num2 = num;
				num = (short)1223820505;
				switch (num2 == num)
				{
				}
				num = (short)351535105;
				if (num != 0)
				{
				}
				num = (short)1176567808;
				if (num != 0)
				{
				}
				num = (short)1158152192;
				short num3 = num;
				return this.radWideAdvancedSmartLowBatteryAlert_A9165._HasDiffs;
			}
		}

		// Token: 0x170015CD RID: 5581
		// (get) Token: 0x06002B83 RID: 11139 RVA: 0x002A3994 File Offset: 0x002A1B94
		// (set) Token: 0x06002B84 RID: 11140 RVA: 0x002A3A48 File Offset: 0x002A1C48
		public int RadProfAlertTonesNewMuteTonesOperation_A42149Value
		{
			get
			{
				short num = (short)124122007;
				short num2 = num;
				num = (short)623571863;
				switch (num2 == num)
				{
				}
				num = (short)294191105;
				if (num != 0)
				{
				}
				num = (short)875692032;
				if (num != 0)
				{
				}
				num = (short)861077504;
				short num3 = num;
				return this.radProfAlertTonesNewMuteTonesOperation_A42149.Value;
			}
			set
			{
				short num = (short)1526836809;
				short num2 = num;
				num = (short)1312796233;
				switch (num2 == num)
				{
				}
				num = (short)566165505;
				if (num != 0)
				{
				}
				num = (short)632946688;
				if (num != 0)
				{
				}
				num = (short)1523122176;
				short num3 = num;
				this.radProfAlertTonesNewMuteTonesOperation_A42149.Value = value;
			}
		}

		// Token: 0x170015CE RID: 5582
		// (get) Token: 0x06002B85 RID: 11141 RVA: 0x002A3B00 File Offset: 0x002A1D00
		// (set) Token: 0x06002B86 RID: 11142 RVA: 0x002A3BB4 File Offset: 0x002A1DB4
		public string RadProfAlertTonesNewMuteTonesOperation_A42149_UIValue
		{
			get
			{
				short num = (short)846157502;
				short num2 = num;
				num = (short)1609062078;
				switch (num2 == num)
				{
				}
				num = (short)1886453760;
				if (num != 0)
				{
				}
				num = (short)1510342657;
				if (num != 0)
				{
				}
				num = (short)1454964736;
				short num3 = num;
				return this.radProfAlertTonesNewMuteTonesOperation_A42149.UIValue;
			}
			set
			{
				short num = (short)1601769252;
				short num2 = num;
				num = (short)607784740;
				switch (num2 == num)
				{
				}
				num = (short)1555955713;
				if (num != 0)
				{
				}
				num = (short)1607991296;
				if (num != 0)
				{
				}
				num = (short)804454400;
				short num3 = num;
				this.radProfAlertTonesNewMuteTonesOperation_A42149.UIValue = value;
			}
		}

		// Token: 0x170015CF RID: 5583
		// (get) Token: 0x06002B87 RID: 11143 RVA: 0x002A3C68 File Offset: 0x002A1E68
		public global::AcpBusinessLayer.AcpListField RadProfAlertTonesNewMuteTonesOperation_A42149
		{
			get
			{
				short num = (short)1350545686;
				short num2 = num;
				num = (short)933867798;
				switch (num2 == num)
				{
				}
				num = (short)445382657;
				if (num != 0)
				{
				}
				num = (short)1849950208;
				if (num != 0)
				{
				}
				num = (short)745865216;
				short num3 = num;
				return this.radProfAlertTonesNewMuteTonesOperation_A42149;
			}
		}

		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x06002B88 RID: 11144 RVA: 0x002A3D1C File Offset: 0x002A1F1C
		// (set) Token: 0x06002B89 RID: 11145 RVA: 0x002A3DD0 File Offset: 0x002A1FD0
		public bool RadProfAlertTonesNewMuteTonesOperation_A42149_Applicable
		{
			get
			{
				short num = (short)1472070412;
				short num2 = num;
				num = (short)1097466636;
				switch (num2 == num)
				{
				}
				num = (short)1965096961;
				if (num != 0)
				{
				}
				num = (short)310837248;
				if (num != 0)
				{
				}
				num = (short)1770520576;
				short num3 = num;
				return this.radProfAlertTonesNewMuteTonesOperation_A42149.Applicable;
			}
			set
			{
				short num = (short)1549867837;
				short num2 = num;
				num = (short)1948064573;
				switch (num2 == num)
				{
				}
				num = (short)91422721;
				if (num != 0)
				{
				}
				num = (short)1200291840;
				if (num != 0)
				{
				}
				num = (short)1110835200;
				short num3 = num;
				this.radProfAlertTonesNewMuteTonesOperation_A42149.Applicable = value;
			}
		}

		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x06002B8A RID: 11146 RVA: 0x002A3E88 File Offset: 0x002A2088
		// (set) Token: 0x06002B8B RID: 11147 RVA: 0x002A3F40 File Offset: 0x002A2140
		public bool RadProfAlertTonesNewMuteTonesOperation_A42149_Valid
		{
			get
			{
				short num = (short)739782698;
				short num2 = num;
				num = (short)229388330;
				switch (num2 == num)
				{
				}
				num = (short)338886656;
				if (num != 0)
				{
				}
				num = (short)10092545;
				if (num != 0)
				{
				}
				num = (short)694419456;
				short num3 = num;
				return this.radProfAlertTonesNewMuteTonesOperation_A42149.Valid;
			}
			set
			{
				short num = (short)903970418;
				short num2 = num;
				num = (short)748650098;
				switch (num2 == num)
				{
				}
				num = (short)471400449;
				if (num != 0)
				{
				}
				num = (short)1995505664;
				if (num != 0)
				{
				}
				num = (short)1120993280;
				short num3 = num;
				this.radProfAlertTonesNewMuteTonesOperation_A42149.Valid = value;
			}
		}

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x06002B8C RID: 11148 RVA: 0x002A3FF4 File Offset: 0x002A21F4
		// (set) Token: 0x06002B8D RID: 11149 RVA: 0x002A40A8 File Offset: 0x002A22A8
		public bool RadProfAlertTonesNewMuteTonesOperation_A42149_Visible
		{
			get
			{
				short num = (short)945347878;
				short num2 = num;
				num = (short)890232102;
				switch (num2 == num)
				{
				}
				num = (short)1551171585;
				if (num != 0)
				{
				}
				num = (short)754253824;
				if (num != 0)
				{
				}
				num = (short)1483210752;
				short num3 = num;
				return this.radProfAlertTonesNewMuteTonesOperation_A42149.Visible;
			}
			set
			{
				short num = (short)583352373;
				short num2 = num;
				num = (short)1867137077;
				switch (num2 == num)
				{
				}
				num = (short)8650753;
				if (num != 0)
				{
				}
				num = (short)838991872;
				if (num != 0)
				{
				}
				num = (short)250281984;
				short num3 = num;
				this.radProfAlertTonesNewMuteTonesOperation_A42149.Visible = value;
			}
		}

		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x06002B8E RID: 11150 RVA: 0x002A415C File Offset: 0x002A235C
		// (set) Token: 0x06002B8F RID: 11151 RVA: 0x002A4214 File Offset: 0x002A2414
		public bool RadProfAlertTonesNewMuteTonesOperation_A42149_Editable
		{
			get
			{
				short num = (short)136970241;
				if (num != 0)
				{
				}
				num = (short)1729662778;
				short num2 = num;
				num = (short)406622010;
				switch (num2 == num)
				{
				}
				num = (short)209059840;
				if (num != 0)
				{
				}
				num = (short)1578172416;
				short num3 = num;
				return this.radProfAlertTonesNewMuteTonesOperation_A42149.Editable;
			}
			set
			{
				short num = (short)1552580701;
				short num2 = num;
				num = (short)508199005;
				switch (num2 == num)
				{
				}
				num = (short)336658432;
				if (num != 0)
				{
				}
				num = (short)1892220929;
				if (num != 0)
				{
				}
				num = (short)1110048768;
				short num3 = num;
				this.radProfAlertTonesNewMuteTonesOperation_A42149.Editable = value;
			}
		}

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x06002B90 RID: 11152 RVA: 0x002A42C8 File Offset: 0x002A24C8
		internal string RadProfAlertTonesNewMuteTonesOperation_A42149_UILabel
		{
			get
			{
				short num = (short)1457047042;
				short num2 = num;
				num = (short)986695170;
				switch (num2 == num)
				{
				}
				num = (short)1147207680;
				if (num != 0)
				{
				}
				num = (short)197459969;
				if (num != 0)
				{
				}
				num = (short)1366097920;
				short num3 = num;
				return this.radProfAlertTonesNewMuteTonesOperation_A42149.UIName;
			}
		}

		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x06002B91 RID: 11153 RVA: 0x002A437C File Offset: 0x002A257C
		// (set) Token: 0x06002B92 RID: 11154 RVA: 0x002A4430 File Offset: 0x002A2630
		internal bool RadProfAlertTonesNewMuteTonesOperation_A42149_HiddenStatic
		{
			get
			{
				short num = (short)1481900033;
				if (num != 0)
				{
				}
				num = (short)1175963750;
				short num2 = num;
				num = (short)1110755430;
				switch (num2 == num)
				{
				}
				num = (short)282853376;
				if (num != 0)
				{
				}
				num = (short)28180480;
				short num3 = num;
				return this.radProfAlertTonesNewMuteTonesOperation_A42149.HiddenStatic;
			}
			set
			{
				short num = (short)108768412;
				short num2 = num;
				num = (short)1288613020;
				switch (num2 == num)
				{
				}
				num = (short)1290076161;
				if (num != 0)
				{
				}
				num = (short)1195048960;
				if (num != 0)
				{
				}
				num = (short)2026504192;
				short num3 = num;
				this.radProfAlertTonesNewMuteTonesOperation_A42149.HiddenStatic = value;
			}
		}

		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x06002B93 RID: 11155 RVA: 0x002A44E8 File Offset: 0x002A26E8
		// (set) Token: 0x06002B94 RID: 11156 RVA: 0x002A459C File Offset: 0x002A279C
		internal bool RadProfAlertTonesNewMuteTonesOperation_A42149_HiddenDynamic
		{
			get
			{
				short num = (short)1033357435;
				short num2 = num;
				num = (short)1490405499;
				switch (num2 == num)
				{
				}
				num = (short)1439825920;
				if (num != 0)
				{
				}
				num = (short)1069481985;
				if (num != 0)
				{
				}
				num = (short)2053505024;
				short num3 = num;
				return this.radProfAlertTonesNewMuteTonesOperation_A42149.HiddenDynamic;
			}
			set
			{
				short num = (short)2130726464;
				short num2 = num;
				num = (short)1559121472;
				switch (num2 == num)
				{
				}
				num = (short)898039809;
				if (num != 0)
				{
				}
				num = (short)1977024512;
				if (num != 0)
				{
				}
				num = (short)2051604480;
				short num3 = num;
				this.radProfAlertTonesNewMuteTonesOperation_A42149.HiddenDynamic = value;
			}
		}

		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x06002B95 RID: 11157 RVA: 0x002A4650 File Offset: 0x002A2850
		public bool RadProfAlertTonesNewMuteTonesOperation_A42149_HasDiffs
		{
			get
			{
				short num = (short)210182619;
				short num2 = num;
				num = (short)976101851;
				switch (num2 == num)
				{
				}
				num = (short)722075649;
				if (num != 0)
				{
				}
				num = (short)2064580608;
				if (num != 0)
				{
				}
				num = (short)184090624;
				short num3 = num;
				return this.radProfAlertTonesNewMuteTonesOperation_A42149._HasDiffs;
			}
		}

		// Token: 0x170015D8 RID: 5592
		// (get) Token: 0x06002B96 RID: 11158 RVA: 0x002A4708 File Offset: 0x002A2908
		// (set) Token: 0x06002B97 RID: 11159 RVA: 0x002A47BC File Offset: 0x002A29BC
		public int RadProfAlertTonesEnhancedMuteTonesOperation_A42150Value
		{
			get
			{
				short num = (short)1077927805;
				short num2 = num;
				num = (short)651812733;
				switch (num2 == num)
				{
				}
				num = (short)466354176;
				if (num != 0)
				{
				}
				num = (short)1400307713;
				if (num != 0)
				{
				}
				num = (short)1420165120;
				short num3 = num;
				return this.radProfAlertTonesEnhancedMuteTonesOperation_A42150.Value;
			}
			set
			{
				short num = (short)1989610896;
				short num2 = num;
				num = (short)1431506320;
				switch (num2 == num)
				{
				}
				num = (short)1697972224;
				if (num != 0)
				{
				}
				num = (short)1889402881;
				if (num != 0)
				{
				}
				num = (short)527106048;
				short num3 = num;
				this.radProfAlertTonesEnhancedMuteTonesOperation_A42150.Value = value;
			}
		}

		// Token: 0x170015D9 RID: 5593
		// (get) Token: 0x06002B98 RID: 11160 RVA: 0x002A4874 File Offset: 0x002A2A74
		// (set) Token: 0x06002B99 RID: 11161 RVA: 0x002A4928 File Offset: 0x002A2B28
		public string RadProfAlertTonesEnhancedMuteTonesOperation_A42150_UIValue
		{
			get
			{
				short num = (short)1878782539;
				short num2 = num;
				num = (short)920515147;
				switch (num2 == num)
				{
				}
				num = (short)2124218368;
				if (num != 0)
				{
				}
				num = (short)61734913;
				if (num != 0)
				{
				}
				num = (short)1723596800;
				short num3 = num;
				return this.radProfAlertTonesEnhancedMuteTonesOperation_A42150.UIValue;
			}
			set
			{
				short num = (short)2139539505;
				short num2 = num;
				num = (short)756467761;
				switch (num2 == num)
				{
				}
				num = (short)1881407489;
				if (num != 0)
				{
				}
				num = (short)1482424320;
				if (num != 0)
				{
				}
				num = (short)374407168;
				short num3 = num;
				this.radProfAlertTonesEnhancedMuteTonesOperation_A42150.UIValue = value;
			}
		}

		// Token: 0x170015DA RID: 5594
		// (get) Token: 0x06002B9A RID: 11162 RVA: 0x002A49DC File Offset: 0x002A2BDC
		public global::AcpBusinessLayer.AcpListField RadProfAlertTonesEnhancedMuteTonesOperation_A42150
		{
			get
			{
				short num = (short)2026326166;
				short num2 = num;
				num = (short)371804310;
				switch (num2 == num)
				{
				}
				num = (short)1803419649;
				if (num != 0)
				{
				}
				num = (short)2012676096;
				if (num != 0)
				{
				}
				num = (short)122355712;
				short num3 = num;
				return this.radProfAlertTonesEnhancedMuteTonesOperation_A42150;
			}
		}

		// Token: 0x170015DB RID: 5595
		// (get) Token: 0x06002B9B RID: 11163 RVA: 0x002A4A8C File Offset: 0x002A2C8C
		// (set) Token: 0x06002B9C RID: 11164 RVA: 0x002A4B44 File Offset: 0x002A2D44
		public bool RadProfAlertTonesEnhancedMuteTonesOperation_A42150_Applicable
		{
			get
			{
				short num = (short)1788588059;
				short num2 = num;
				num = (short)377663515;
				switch (num2 == num)
				{
				}
				num = (short)635699201;
				if (num != 0)
				{
				}
				num = (short)509018112;
				if (num != 0)
				{
				}
				num = (short)1283391488;
				short num3 = num;
				return this.radProfAlertTonesEnhancedMuteTonesOperation_A42150.Applicable;
			}
			set
			{
				short num = (short)1910006132;
				short num2 = num;
				num = (short)713777524;
				switch (num2 == num)
				{
				}
				num = (short)1257766913;
				if (num != 0)
				{
				}
				num = (short)473694208;
				if (num != 0)
				{
				}
				num = (short)2069037056;
				short num3 = num;
				this.radProfAlertTonesEnhancedMuteTonesOperation_A42150.Applicable = value;
			}
		}

		// Token: 0x170015DC RID: 5596
		// (get) Token: 0x06002B9D RID: 11165 RVA: 0x002A4BF8 File Offset: 0x002A2DF8
		// (set) Token: 0x06002B9E RID: 11166 RVA: 0x002A4CAC File Offset: 0x002A2EAC
		public bool RadProfAlertTonesEnhancedMuteTonesOperation_A42150_Valid
		{
			get
			{
				short num = (short)1912891759;
				short num2 = num;
				num = (short)1306290543;
				switch (num2 == num)
				{
				}
				num = (short)554762241;
				if (num != 0)
				{
				}
				num = (short)1517813760;
				if (num != 0)
				{
				}
				num = (short)1367408640;
				short num3 = num;
				return this.radProfAlertTonesEnhancedMuteTonesOperation_A42150.Valid;
			}
			set
			{
				short num = (short)754272961;
				short num2 = num;
				num = (short)1656441537;
				switch (num2 == num)
				{
				}
				num = (short)1207107584;
				if (num != 0)
				{
				}
				num = (short)1707147265;
				if (num != 0)
				{
				}
				num = (short)724303872;
				short num3 = num;
				this.radProfAlertTonesEnhancedMuteTonesOperation_A42150.Valid = value;
			}
		}

		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x06002B9F RID: 11167 RVA: 0x002A4D64 File Offset: 0x002A2F64
		// (set) Token: 0x06002BA0 RID: 11168 RVA: 0x002A4E1C File Offset: 0x002A301C
		public bool RadProfAlertTonesEnhancedMuteTonesOperation_A42150_Visible
		{
			get
			{
				short num = (short)1608613012;
				short num2 = num;
				num = (short)1652391060;
				switch (num2 == num)
				{
				}
				num = (short)1973354497;
				if (num != 0)
				{
				}
				num = (short)589430784;
				if (num != 0)
				{
				}
				num = (short)616562688;
				short num3 = num;
				return this.radProfAlertTonesEnhancedMuteTonesOperation_A42150.Visible;
			}
			set
			{
				short num = (short)553107737;
				short num2 = num;
				num = (short)1703002393;
				switch (num2 == num)
				{
				}
				num = (short)1807613953;
				if (num != 0)
				{
				}
				num = (short)650051584;
				if (num != 0)
				{
				}
				num = (short)508887040;
				short num3 = num;
				this.radProfAlertTonesEnhancedMuteTonesOperation_A42150.Visible = value;
			}
		}

		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x06002BA1 RID: 11169 RVA: 0x002A4ED0 File Offset: 0x002A30D0
		// (set) Token: 0x06002BA2 RID: 11170 RVA: 0x002A4F88 File Offset: 0x002A3188
		public bool RadProfAlertTonesEnhancedMuteTonesOperation_A42150_Editable
		{
			get
			{
				short num = (short)325237106;
				short num2 = num;
				num = (short)1861007730;
				switch (num2 == num)
				{
				}
				num = (short)809304065;
				if (num != 0)
				{
				}
				num = (short)1364393984;
				if (num != 0)
				{
				}
				num = (short)1094713344;
				short num3 = num;
				return this.radProfAlertTonesEnhancedMuteTonesOperation_A42150.Editable;
			}
			set
			{
				short num = (short)556577694;
				short num2 = num;
				num = (short)1039578014;
				switch (num2 == num)
				{
				}
				num = (short)1551368192;
				if (num != 0)
				{
				}
				num = (short)1062731777;
				if (num != 0)
				{
				}
				num = (short)901840896;
				short num3 = num;
				this.radProfAlertTonesEnhancedMuteTonesOperation_A42150.Editable = value;
			}
		}

		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x06002BA3 RID: 11171 RVA: 0x002A5040 File Offset: 0x002A3240
		internal string RadProfAlertTonesEnhancedMuteTonesOperation_A42150_UILabel
		{
			get
			{
				short num = (short)160944922;
				short num2 = num;
				num = (short)1043583770;
				switch (num2 == num)
				{
				}
				num = (short)1285423105;
				if (num != 0)
				{
				}
				num = (short)1910177792;
				if (num != 0)
				{
				}
				num = (short)2114650112;
				short num3 = num;
				return this.radProfAlertTonesEnhancedMuteTonesOperation_A42150.UIName;
			}
		}

		// Token: 0x170015E0 RID: 5600
		// (get) Token: 0x06002BA4 RID: 11172 RVA: 0x002A50F4 File Offset: 0x002A32F4
		// (set) Token: 0x06002BA5 RID: 11173 RVA: 0x002A51A4 File Offset: 0x002A33A4
		internal bool RadProfAlertTonesEnhancedMuteTonesOperation_A42150_HiddenStatic
		{
			get
			{
				short num = (short)1769200409;
				short num2 = num;
				num = (short)1410784025;
				switch (num2 == num)
				{
				}
				num = (short)1306591232;
				if (num != 0)
				{
				}
				num = (short)1337458689;
				if (num != 0)
				{
				}
				num = (short)2124283904;
				short num3 = num;
				return this.radProfAlertTonesEnhancedMuteTonesOperation_A42150.HiddenStatic;
			}
			set
			{
				short num = (short)1149301973;
				short num2 = num;
				num = (short)1060697301;
				switch (num2 == num)
				{
				}
				num = (short)2032861185;
				if (num != 0)
				{
				}
				num = (short)181010432;
				if (num != 0)
				{
				}
				num = (short)2071592960;
				short num3 = num;
				this.radProfAlertTonesEnhancedMuteTonesOperation_A42150.HiddenStatic = value;
			}
		}

		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x06002BA6 RID: 11174 RVA: 0x002A5258 File Offset: 0x002A3458
		// (set) Token: 0x06002BA7 RID: 11175 RVA: 0x002A530C File Offset: 0x002A350C
		internal bool RadProfAlertTonesEnhancedMuteTonesOperation_A42150_HiddenDynamic
		{
			get
			{
				short num = (short)727153514;
				short num2 = num;
				num = (short)631602026;
				switch (num2 == num)
				{
				}
				num = (short)1977876480;
				if (num != 0)
				{
				}
				num = (short)1207435265;
				if (num != 0)
				{
				}
				num = (short)689569792;
				short num3 = num;
				return this.radProfAlertTonesEnhancedMuteTonesOperation_A42150.HiddenDynamic;
			}
			set
			{
				short num = (short)1513078282;
				short num2 = num;
				num = (short)1211547146;
				switch (num2 == num)
				{
				}
				num = (short)1117782017;
				if (num != 0)
				{
				}
				num = (short)1000734720;
				if (num != 0)
				{
				}
				num = (short)1794244608;
				short num3 = num;
				this.radProfAlertTonesEnhancedMuteTonesOperation_A42150.HiddenDynamic = value;
			}
		}

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x06002BA8 RID: 11176 RVA: 0x002A53C4 File Offset: 0x002A35C4
		public bool RadProfAlertTonesEnhancedMuteTonesOperation_A42150_HasDiffs
		{
			get
			{
				short num = (short)2133161303;
				short num2 = num;
				num = (short)1290106199;
				switch (num2 == num)
				{
				}
				num = (short)79233025;
				if (num != 0)
				{
				}
				num = (short)490995712;
				if (num != 0)
				{
				}
				num = (short)1085669376;
				short num3 = num;
				return this.radProfAlertTonesEnhancedMuteTonesOperation_A42150._HasDiffs;
			}
		}

		// Token: 0x170015E3 RID: 5603
		// (get) Token: 0x06002BA9 RID: 11177 RVA: 0x002A547C File Offset: 0x002A367C
		// (set) Token: 0x06002BAA RID: 11178 RVA: 0x002A5534 File Offset: 0x002A3734
		public int RadWideTalkProhibitToneSelection_A42416Value
		{
			get
			{
				short num = (short)280824427;
				short num2 = num;
				num = (short)815008363;
				switch (num2 == num)
				{
				}
				num = (short)110100481;
				if (num != 0)
				{
				}
				num = (short)1650065408;
				if (num != 0)
				{
				}
				num = (short)1432420352;
				short num3 = num;
				return this.radWideTalkProhibitToneSelection_A42416.Value;
			}
			set
			{
				short num = (short)1603221107;
				short num2 = num;
				num = (short)203175539;
				switch (num2 == num)
				{
				}
				num = (short)860356609;
				if (num != 0)
				{
				}
				num = (short)522846208;
				if (num != 0)
				{
				}
				num = (short)1793523712;
				short num3 = num;
				this.radWideTalkProhibitToneSelection_A42416.Value = value;
			}
		}

		// Token: 0x170015E4 RID: 5604
		// (get) Token: 0x06002BAB RID: 11179 RVA: 0x002A55EC File Offset: 0x002A37EC
		// (set) Token: 0x06002BAC RID: 11180 RVA: 0x002A56A0 File Offset: 0x002A38A0
		public string RadWideTalkProhibitToneSelection_A42416_UIValue
		{
			get
			{
				short num = (short)2069188116;
				short num2 = num;
				num = (short)591285780;
				switch (num2 == num)
				{
				}
				num = (short)1799880705;
				if (num != 0)
				{
				}
				num = (short)1870331904;
				if (num != 0)
				{
				}
				num = (short)1987510272;
				short num3 = num;
				return this.radWideTalkProhibitToneSelection_A42416.UIValue;
			}
			set
			{
				short num = (short)1590532027;
				short num2 = num;
				num = (short)849123259;
				switch (num2 == num)
				{
				}
				num = (short)3342337;
				if (num != 0)
				{
				}
				num = (short)385744896;
				if (num != 0)
				{
				}
				num = (short)318767104;
				short num3 = num;
				this.radWideTalkProhibitToneSelection_A42416.UIValue = value;
			}
		}

		// Token: 0x170015E5 RID: 5605
		// (get) Token: 0x06002BAD RID: 11181 RVA: 0x002A5754 File Offset: 0x002A3954
		public global::AcpBusinessLayer.AcpListField RadWideTalkProhibitToneSelection_A42416
		{
			get
			{
				short num = (short)28874820;
				short num2 = num;
				num = (short)520591428;
				switch (num2 == num)
				{
				}
				num = (short)380305408;
				if (num != 0)
				{
				}
				num = (short)1890516993;
				if (num != 0)
				{
				}
				num = (short)1205796864;
				short num3 = num;
				return this.radWideTalkProhibitToneSelection_A42416;
			}
		}

		// Token: 0x170015E6 RID: 5606
		// (get) Token: 0x06002BAE RID: 11182 RVA: 0x002A5804 File Offset: 0x002A3A04
		// (set) Token: 0x06002BAF RID: 11183 RVA: 0x002A58B8 File Offset: 0x002A3AB8
		public bool RadWideTalkProhibitToneSelection_A42416_Applicable
		{
			get
			{
				short num = (short)1871642625;
				if (num != 0)
				{
				}
				num = (short)509553370;
				short num2 = num;
				num = (short)1266363098;
				switch (num2 == num)
				{
				}
				num = (short)1812070400;
				if (num != 0)
				{
				}
				num = (short)1757085696;
				short num3 = num;
				return this.radWideTalkProhibitToneSelection_A42416.Applicable;
			}
			set
			{
				short num = (short)1003142082;
				short num2 = num;
				num = (short)1425849282;
				switch (num2 == num)
				{
				}
				num = (short)383188993;
				if (num != 0)
				{
				}
				num = (short)82116608;
				if (num != 0)
				{
				}
				num = (short)150470656;
				short num3 = num;
				this.radWideTalkProhibitToneSelection_A42416.Applicable = value;
			}
		}

		// Token: 0x170015E7 RID: 5607
		// (get) Token: 0x06002BB0 RID: 11184 RVA: 0x002A596C File Offset: 0x002A3B6C
		// (set) Token: 0x06002BB1 RID: 11185 RVA: 0x002A5A20 File Offset: 0x002A3C20
		public bool RadWideTalkProhibitToneSelection_A42416_Valid
		{
			get
			{
				short num = (short)1324435801;
				short num2 = num;
				num = (short)823019865;
				switch (num2 == num)
				{
				}
				num = (short)1360068609;
				if (num != 0)
				{
				}
				num = (short)473104384;
				if (num != 0)
				{
				}
				num = (short)456785920;
				short num3 = num;
				return this.radWideTalkProhibitToneSelection_A42416.Valid;
			}
			set
			{
				short num = (short)1823277057;
				if (num != 0)
				{
				}
				num = (short)64584921;
				short num2 = num;
				num = (short)1982037209;
				switch (num2 == num)
				{
				}
				num = (short)224198656;
				if (num != 0)
				{
				}
				num = (short)503513088;
				short num3 = num;
				this.radWideTalkProhibitToneSelection_A42416.Valid = value;
			}
		}

		// Token: 0x170015E8 RID: 5608
		// (get) Token: 0x06002BB2 RID: 11186 RVA: 0x002A5AD4 File Offset: 0x002A3CD4
		// (set) Token: 0x06002BB3 RID: 11187 RVA: 0x002A5B8C File Offset: 0x002A3D8C
		public bool RadWideTalkProhibitToneSelection_A42416_Visible
		{
			get
			{
				short num = (short)558114673;
				short num2 = num;
				num = (short)1871783793;
				switch (num2 == num)
				{
				}
				num = (short)1483079680;
				if (num != 0)
				{
				}
				num = (short)2018967553;
				if (num != 0)
				{
				}
				num = (short)500563968;
				short num3 = num;
				return this.radWideTalkProhibitToneSelection_A42416.Visible;
			}
			set
			{
				short num = (short)1705096798;
				short num2 = num;
				num = (short)500479582;
				switch (num2 == num)
				{
				}
				num = (short)71237632;
				if (num != 0)
				{
				}
				num = (short)2111373313;
				if (num != 0)
				{
				}
				num = (short)811008000;
				short num3 = num;
				this.radWideTalkProhibitToneSelection_A42416.Visible = value;
			}
		}

		// Token: 0x170015E9 RID: 5609
		// (get) Token: 0x06002BB4 RID: 11188 RVA: 0x002A5C44 File Offset: 0x002A3E44
		// (set) Token: 0x06002BB5 RID: 11189 RVA: 0x002A5CF4 File Offset: 0x002A3EF4
		public bool RadWideTalkProhibitToneSelection_A42416_Editable
		{
			get
			{
				short num = (short)1600855781;
				short num2 = num;
				num = (short)1716854501;
				switch (num2 == num)
				{
				}
				num = (short)1365966848;
				if (num != 0)
				{
				}
				num = (short)427098113;
				if (num != 0)
				{
				}
				num = (short)1199964160;
				short num3 = num;
				return this.radWideTalkProhibitToneSelection_A42416.Editable;
			}
			set
			{
				short num = (short)1179036034;
				short num2 = num;
				num = (short)836675970;
				switch (num2 == num)
				{
				}
				num = (short)386990080;
				if (num != 0)
				{
				}
				num = (short)1815937025;
				if (num != 0)
				{
				}
				num = (short)1854013440;
				short num3 = num;
				this.radWideTalkProhibitToneSelection_A42416.Editable = value;
			}
		}

		// Token: 0x170015EA RID: 5610
		// (get) Token: 0x06002BB6 RID: 11190 RVA: 0x002A5DAC File Offset: 0x002A3FAC
		internal string RadWideTalkProhibitToneSelection_A42416_UILabel
		{
			get
			{
				short num = (short)425858173;
				short num2 = num;
				num = (short)556209277;
				switch (num2 == num)
				{
				}
				num = (short)652476417;
				if (num != 0)
				{
				}
				num = (short)184418304;
				if (num != 0)
				{
				}
				num = (short)1184235520;
				short num3 = num;
				return this.radWideTalkProhibitToneSelection_A42416.UIName;
			}
		}

		// Token: 0x170015EB RID: 5611
		// (get) Token: 0x06002BB7 RID: 11191 RVA: 0x002A5E60 File Offset: 0x002A4060
		// (set) Token: 0x06002BB8 RID: 11192 RVA: 0x002A5F14 File Offset: 0x002A4114
		internal bool RadWideTalkProhibitToneSelection_A42416_HiddenStatic
		{
			get
			{
				short num = (short)1034819098;
				short num2 = num;
				num = (short)474355226;
				switch (num2 == num)
				{
				}
				num = (short)1828061185;
				if (num != 0)
				{
				}
				num = (short)1866530816;
				if (num != 0)
				{
				}
				num = (short)1533804544;
				short num3 = num;
				return this.radWideTalkProhibitToneSelection_A42416.HiddenStatic;
			}
			set
			{
				short num = (short)1734813776;
				short num2 = num;
				num = (short)909650000;
				switch (num2 == num)
				{
				}
				num = (short)536346625;
				if (num != 0)
				{
				}
				num = (short)954728448;
				if (num != 0)
				{
				}
				num = (short)1315373056;
				short num3 = num;
				this.radWideTalkProhibitToneSelection_A42416.HiddenStatic = value;
			}
		}

		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x06002BB9 RID: 11193 RVA: 0x002A5FC8 File Offset: 0x002A41C8
		// (set) Token: 0x06002BBA RID: 11194 RVA: 0x002A607C File Offset: 0x002A427C
		internal bool RadWideTalkProhibitToneSelection_A42416_HiddenDynamic
		{
			get
			{
				short num = (short)1693185864;
				short num2 = num;
				num = (short)107804488;
				switch (num2 == num)
				{
				}
				num = (short)534970369;
				if (num != 0)
				{
				}
				num = (short)1192165376;
				if (num != 0)
				{
				}
				num = (short)1261699072;
				short num3 = num;
				return this.radWideTalkProhibitToneSelection_A42416.HiddenDynamic;
			}
			set
			{
				short num = (short)521732428;
				short num2 = num;
				num = (short)1777795404;
				switch (num2 == num)
				{
				}
				num = (short)2071265280;
				if (num != 0)
				{
				}
				num = (short)182321153;
				if (num != 0)
				{
				}
				num = (short)579796992;
				short num3 = num;
				this.radWideTalkProhibitToneSelection_A42416.HiddenDynamic = value;
			}
		}

		// Token: 0x170015ED RID: 5613
		// (get) Token: 0x06002BBB RID: 11195 RVA: 0x002A6134 File Offset: 0x002A4334
		public bool RadWideTalkProhibitToneSelection_A42416_HasDiffs
		{
			get
			{
				short num = (short)442492439;
				short num2 = num;
				num = (short)1369302551;
				switch (num2 == num)
				{
				}
				num = (short)1864695808;
				if (num != 0)
				{
				}
				num = (short)1796931585;
				if (num != 0)
				{
				}
				num = (short)1361575936;
				short num3 = num;
				return this.radWideTalkProhibitToneSelection_A42416._HasDiffs;
			}
		}

		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x06002BBC RID: 11196 RVA: 0x002A61EC File Offset: 0x002A43EC
		// (set) Token: 0x06002BBD RID: 11197 RVA: 0x002A62A0 File Offset: 0x002A44A0
		public int RadWideOutOfRangeToneSelection_A42450Value
		{
			get
			{
				short num = (short)598937128;
				short num2 = num;
				num = (short)338431528;
				switch (num2 == num)
				{
				}
				num = (short)1771044865;
				if (num != 0)
				{
				}
				num = (short)1372323840;
				if (num != 0)
				{
				}
				num = (short)1897136128;
				short num3 = num;
				return this.radWideOutOfRangeToneSelection_A42450.Value;
			}
			set
			{
				short num = (short)249430016;
				short num2 = num;
				num = (short)1128357641;
				short num3 = num;
				num = (short)1419665161;
				switch (num3 == num)
				{
				}
				num = (short)947847168;
				if (num != 0)
				{
				}
				num = (short)1258487809;
				if (num != 0)
				{
				}
				this.radWideOutOfRangeToneSelection_A42450.Value = value;
			}
		}

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x06002BBE RID: 11198 RVA: 0x002A6354 File Offset: 0x002A4554
		// (set) Token: 0x06002BBF RID: 11199 RVA: 0x002A6408 File Offset: 0x002A4608
		public string RadWideOutOfRangeToneSelection_A42450_UIValue
		{
			get
			{
				short num = (short)540606464;
				short num2 = num;
				num = (short)1298354082;
				short num3 = num;
				num = (short)1175080866;
				switch (num3 == num)
				{
				}
				num = (short)261816320;
				if (num != 0)
				{
				}
				num = (short)2086797313;
				if (num != 0)
				{
				}
				return this.radWideOutOfRangeToneSelection_A42450.UIValue;
			}
			set
			{
				short num = (short)987627520;
				short num2 = num;
				num = (short)2025298332;
				short num3 = num;
				num = (short)1063623068;
				switch (num3 == num)
				{
				}
				num = (short)476119040;
				if (num != 0)
				{
				}
				num = (short)2109931521;
				if (num != 0)
				{
				}
				this.radWideOutOfRangeToneSelection_A42450.UIValue = value;
			}
		}

		// Token: 0x170015F0 RID: 5616
		// (get) Token: 0x06002BC0 RID: 11200 RVA: 0x002A64C0 File Offset: 0x002A46C0
		public global::AcpBusinessLayer.AcpListField RadWideOutOfRangeToneSelection_A42450
		{
			get
			{
				short num = (short)241041408;
				short num2 = num;
				num = (short)402378876;
				short num3 = num;
				num = (short)2114637948;
				switch (num3 == num)
				{
				}
				num = (short)1407909889;
				if (num != 0)
				{
				}
				num = (short)203292672;
				if (num != 0)
				{
				}
				return this.radWideOutOfRangeToneSelection_A42450;
			}
		}

		// Token: 0x170015F1 RID: 5617
		// (get) Token: 0x06002BC1 RID: 11201 RVA: 0x002A6570 File Offset: 0x002A4770
		// (set) Token: 0x06002BC2 RID: 11202 RVA: 0x002A6628 File Offset: 0x002A4828
		public bool RadWideOutOfRangeToneSelection_A42450_Applicable
		{
			get
			{
				short num = (short)1197146112;
				short num2 = num;
				num = (short)513651605;
				short num3 = num;
				num = (short)1415426965;
				switch (num3 == num)
				{
				}
				num = (short)714932225;
				if (num != 0)
				{
				}
				num = (short)638713856;
				if (num != 0)
				{
				}
				return this.radWideOutOfRangeToneSelection_A42450.Applicable;
			}
			set
			{
				short num = (short)960299008;
				short num2 = num;
				num = (short)164757505;
				if (num != 0)
				{
				}
				num = (short)2050080088;
				short num3 = num;
				num = (short)878755160;
				switch (num3 == num)
				{
				}
				num = (short)1662779392;
				if (num != 0)
				{
				}
				this.radWideOutOfRangeToneSelection_A42450.Applicable = value;
			}
		}

		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x06002BC3 RID: 11203 RVA: 0x002A66DC File Offset: 0x002A48DC
		// (set) Token: 0x06002BC4 RID: 11204 RVA: 0x002A6794 File Offset: 0x002A4994
		public bool RadWideOutOfRangeToneSelection_A42450_Valid
		{
			get
			{
				short num = (short)610074624;
				short num2 = num;
				num = (short)930685875;
				short num3 = num;
				num = (short)834741171;
				switch (num3 == num)
				{
				}
				num = (short)1934163968;
				if (num != 0)
				{
				}
				num = (short)2087780353;
				if (num != 0)
				{
				}
				return this.radWideOutOfRangeToneSelection_A42450.Valid;
			}
			set
			{
				short num = (short)1107361792;
				short num2 = num;
				num = (short)1706003607;
				short num3 = num;
				num = (short)726043799;
				switch (num3 == num)
				{
				}
				num = (short)669581313;
				if (num != 0)
				{
				}
				num = (short)2095513600;
				if (num != 0)
				{
				}
				this.radWideOutOfRangeToneSelection_A42450.Valid = value;
			}
		}

		// Token: 0x170015F3 RID: 5619
		// (get) Token: 0x06002BC5 RID: 11205 RVA: 0x002A684C File Offset: 0x002A4A4C
		// (set) Token: 0x06002BC6 RID: 11206 RVA: 0x002A6900 File Offset: 0x002A4B00
		public bool RadWideOutOfRangeToneSelection_A42450_Visible
		{
			get
			{
				short num = (short)404291584;
				short num2 = num;
				num = (short)24493087;
				short num3 = num;
				num = (short)768064543;
				switch (num3 == num)
				{
				}
				num = (short)1902182400;
				if (num != 0)
				{
				}
				num = (short)1771503617;
				if (num != 0)
				{
				}
				return this.radWideOutOfRangeToneSelection_A42450.Visible;
			}
			set
			{
				short num = (short)483721216;
				short num2 = num;
				num = (short)1655504897;
				if (num != 0)
				{
				}
				num = (short)1316136259;
				short num3 = num;
				num = (short)623879491;
				switch (num3 == num)
				{
				}
				num = (short)1224933376;
				if (num != 0)
				{
				}
				this.radWideOutOfRangeToneSelection_A42450.Visible = value;
			}
		}

		// Token: 0x170015F4 RID: 5620
		// (get) Token: 0x06002BC7 RID: 11207 RVA: 0x002A69B8 File Offset: 0x002A4BB8
		// (set) Token: 0x06002BC8 RID: 11208 RVA: 0x002A6A6C File Offset: 0x002A4C6C
		public bool RadWideOutOfRangeToneSelection_A42450_Editable
		{
			get
			{
				short num = (short)1895890944;
				short num2 = num;
				num = (short)444780844;
				short num3 = num;
				num = (short)613601580;
				switch (num3 == num)
				{
				}
				num = (short)2145386497;
				if (num != 0)
				{
				}
				num = (short)644677632;
				if (num != 0)
				{
				}
				return this.radWideOutOfRangeToneSelection_A42450.Editable;
			}
			set
			{
				short num = (short)302252032;
				short num2 = num;
				num = (short)620776700;
				short num3 = num;
				num = (short)1804684540;
				switch (num3 == num)
				{
				}
				num = (short)944635905;
				if (num != 0)
				{
				}
				num = (short)1084555264;
				if (num != 0)
				{
				}
				this.radWideOutOfRangeToneSelection_A42450.Editable = value;
			}
		}

		// Token: 0x170015F5 RID: 5621
		// (get) Token: 0x06002BC9 RID: 11209 RVA: 0x002A6B20 File Offset: 0x002A4D20
		internal string RadWideOutOfRangeToneSelection_A42450_UILabel
		{
			get
			{
				short num = (short)1346568192;
				short num2 = num;
				num = (short)83553937;
				short num3 = num;
				num = (short)1887104657;
				switch (num3 == num)
				{
				}
				num = (short)255787008;
				if (num != 0)
				{
				}
				num = (short)869662721;
				if (num != 0)
				{
				}
				return this.radWideOutOfRangeToneSelection_A42450.UIName;
			}
		}

		// Token: 0x170015F6 RID: 5622
		// (get) Token: 0x06002BCA RID: 11210 RVA: 0x002A6BD8 File Offset: 0x002A4DD8
		// (set) Token: 0x06002BCB RID: 11211 RVA: 0x002A6C8C File Offset: 0x002A4E8C
		internal bool RadWideOutOfRangeToneSelection_A42450_HiddenStatic
		{
			get
			{
				short num = (short)2019098624;
				short num2 = num;
				num = (short)70865700;
				short num3 = num;
				num = (short)1530024740;
				switch (num3 == num)
				{
				}
				num = (short)1892614145;
				if (num != 0)
				{
				}
				num = (short)1260126208;
				if (num != 0)
				{
				}
				return this.radWideOutOfRangeToneSelection_A42450.HiddenStatic;
			}
			set
			{
				short num = (short)1991049216;
				short num2 = num;
				num = (short)788349909;
				short num3 = num;
				num = (short)259605461;
				switch (num3 == num)
				{
				}
				num = (short)2052653057;
				if (num != 0)
				{
				}
				num = (short)688521216;
				if (num != 0)
				{
				}
				this.radWideOutOfRangeToneSelection_A42450.HiddenStatic = value;
			}
		}

		// Token: 0x170015F7 RID: 5623
		// (get) Token: 0x06002BCC RID: 11212 RVA: 0x002A6D40 File Offset: 0x002A4F40
		// (set) Token: 0x06002BCD RID: 11213 RVA: 0x002A6DF4 File Offset: 0x002A4FF4
		internal bool RadWideOutOfRangeToneSelection_A42450_HiddenDynamic
		{
			get
			{
				short num = (short)1601306624;
				short num2 = num;
				num = (short)1795091304;
				short num3 = num;
				num = (short)1561652072;
				switch (num3 == num)
				{
				}
				num = (short)1113456641;
				if (num != 0)
				{
				}
				num = (short)910295040;
				if (num != 0)
				{
				}
				return this.radWideOutOfRangeToneSelection_A42450.HiddenDynamic;
			}
			set
			{
				short num = (short)2359296;
				short num2 = num;
				num = (short)275157352;
				short num3 = num;
				num = (short)1793364328;
				switch (num3 == num)
				{
				}
				num = (short)1941307392;
				if (num != 0)
				{
				}
				num = (short)2026700801;
				if (num != 0)
				{
				}
				this.radWideOutOfRangeToneSelection_A42450.HiddenDynamic = value;
			}
		}

		// Token: 0x170015F8 RID: 5624
		// (get) Token: 0x06002BCE RID: 11214 RVA: 0x002A6EAC File Offset: 0x002A50AC
		public bool RadWideOutOfRangeToneSelection_A42450_HasDiffs
		{
			get
			{
				short num = (short)967835648;
				short num2 = num;
				num = (short)1898673621;
				short num3 = num;
				num = (short)1014724053;
				switch (num3 == num)
				{
				}
				num = (short)601686017;
				if (num != 0)
				{
				}
				num = (short)1514340352;
				if (num != 0)
				{
				}
				return this.radWideOutOfRangeToneSelection_A42450._HasDiffs;
			}
		}

		// Token: 0x170015F9 RID: 5625
		// (get) Token: 0x06002BCF RID: 11215 RVA: 0x002A6F60 File Offset: 0x002A5160
		// (set) Token: 0x06002BD0 RID: 11216 RVA: 0x002A7014 File Offset: 0x002A5214
		public bool RadWideAlertTonesVolumeAdjustToneDisableValue
		{
			get
			{
				short num = (short)1262878720;
				short num2 = num;
				num = (short)1524455942;
				short num3 = num;
				num = (short)37575174;
				switch (num3 == num)
				{
				}
				num = (short)1630076928;
				if (num != 0)
				{
				}
				num = (short)1846673409;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesVolumeAdjustToneDisable.Value;
			}
			set
			{
				short num = (short)879427584;
				short num2 = num;
				num = (short)129736022;
				short num3 = num;
				num = (short)10919254;
				switch (num3 == num)
				{
				}
				num = (short)2102591489;
				if (num != 0)
				{
				}
				num = (short)5636096;
				if (num != 0)
				{
				}
				this.radWideAlertTonesVolumeAdjustToneDisable.Value = value;
			}
		}

		// Token: 0x170015FA RID: 5626
		// (get) Token: 0x06002BD1 RID: 11217 RVA: 0x002A70CC File Offset: 0x002A52CC
		public global::AcpBusinessLayer.AcpField<bool> RadWideAlertTonesVolumeAdjustToneDisable
		{
			get
			{
				short num = (short)1616052224;
				short num2 = num;
				num = (short)2075299027;
				short num3 = num;
				num = (short)1084198099;
				switch (num3 == num)
				{
				}
				num = (short)1887502336;
				if (num != 0)
				{
				}
				num = (short)1597702145;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesVolumeAdjustToneDisable;
			}
		}

		// Token: 0x170015FB RID: 5627
		// (get) Token: 0x06002BD2 RID: 11218 RVA: 0x002A717C File Offset: 0x002A537C
		// (set) Token: 0x06002BD3 RID: 11219 RVA: 0x002A7230 File Offset: 0x002A5430
		public bool RadWideAlertTonesVolumeAdjustToneDisable_UIValue
		{
			get
			{
				short num = (short)1853095936;
				short num2 = num;
				num = (short)951871169;
				short num3 = num;
				num = (short)219113153;
				switch (num3 == num)
				{
				}
				num = (short)53411841;
				if (num != 0)
				{
				}
				num = (short)1660157952;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesVolumeAdjustToneDisable.Value;
			}
			set
			{
				short num = (short)659619840;
				short num2 = num;
				num = (short)2045174938;
				short num3 = num;
				num = (short)397337754;
				switch (num3 == num)
				{
				}
				num = (short)789970945;
				if (num != 0)
				{
				}
				num = (short)1298333696;
				if (num != 0)
				{
				}
				this.radWideAlertTonesVolumeAdjustToneDisable.Value = value;
			}
		}

		// Token: 0x170015FC RID: 5628
		// (get) Token: 0x06002BD4 RID: 11220 RVA: 0x002A72E4 File Offset: 0x002A54E4
		// (set) Token: 0x06002BD5 RID: 11221 RVA: 0x002A739C File Offset: 0x002A559C
		public bool RadWideAlertTonesVolumeAdjustToneDisable_Applicable
		{
			get
			{
				short num = (short)544604160;
				short num2 = num;
				num = (short)585908734;
				short num3 = num;
				num = (short)95306238;
				switch (num3 == num)
				{
				}
				num = (short)200998912;
				if (num != 0)
				{
				}
				num = (short)1929052161;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesVolumeAdjustToneDisable.Applicable;
			}
			set
			{
				short num = (short)946864128;
				short num2 = num;
				num = (short)1698824193;
				if (num != 0)
				{
				}
				num = (short)578327650;
				short num3 = num;
				num = (short)301241442;
				switch (num3 == num)
				{
				}
				num = (short)1439039488;
				if (num != 0)
				{
				}
				this.radWideAlertTonesVolumeAdjustToneDisable.Applicable = value;
			}
		}

		// Token: 0x170015FD RID: 5629
		// (get) Token: 0x06002BD6 RID: 11222 RVA: 0x002A7450 File Offset: 0x002A5650
		// (set) Token: 0x06002BD7 RID: 11223 RVA: 0x002A7504 File Offset: 0x002A5704
		public bool RadWideAlertTonesVolumeAdjustToneDisable_Valid
		{
			get
			{
				short num = (short)1341784064;
				short num2 = num;
				num = (short)281238959;
				short num3 = num;
				num = (short)718298543;
				switch (num3 == num)
				{
				}
				num = (short)233177089;
				if (num != 0)
				{
				}
				num = (short)281018368;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesVolumeAdjustToneDisable.Valid;
			}
			set
			{
				short num = (short)1565196288;
				short num2 = num;
				num = (short)2013730710;
				short num3 = num;
				num = (short)914036630;
				switch (num3 == num)
				{
				}
				num = (short)1771044865;
				if (num != 0)
				{
				}
				num = (short)2005991424;
				if (num != 0)
				{
				}
				this.radWideAlertTonesVolumeAdjustToneDisable.Valid = value;
			}
		}

		// Token: 0x170015FE RID: 5630
		// (get) Token: 0x06002BD8 RID: 11224 RVA: 0x002A75B8 File Offset: 0x002A57B8
		// (set) Token: 0x06002BD9 RID: 11225 RVA: 0x002A7670 File Offset: 0x002A5870
		public bool RadWideAlertTonesVolumeAdjustToneDisable_Visible
		{
			get
			{
				short num = (short)349372416;
				short num2 = num;
				num = (short)1281884161;
				if (num != 0)
				{
				}
				num = (short)983803125;
				short num3 = num;
				num = (short)2053154037;
				switch (num3 == num)
				{
				}
				num = (short)1616904192;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesVolumeAdjustToneDisable.Visible;
			}
			set
			{
				short num = (short)854327296;
				short num2 = num;
				num = (short)840408452;
				short num3 = num;
				num = (short)1678724;
				switch (num3 == num)
				{
				}
				num = (short)1433927681;
				if (num != 0)
				{
				}
				num = (short)1971126272;
				if (num != 0)
				{
				}
				this.radWideAlertTonesVolumeAdjustToneDisable.Visible = value;
			}
		}

		// Token: 0x170015FF RID: 5631
		// (get) Token: 0x06002BDA RID: 11226 RVA: 0x002A7724 File Offset: 0x002A5924
		// (set) Token: 0x06002BDB RID: 11227 RVA: 0x002A77D8 File Offset: 0x002A59D8
		public bool RadWideAlertTonesVolumeAdjustToneDisable_Editable
		{
			get
			{
				short num = (short)600834048;
				short num2 = num;
				num = (short)1633462986;
				short num3 = num;
				num = (short)2125376202;
				switch (num3 == num)
				{
				}
				num = (short)279904256;
				if (num != 0)
				{
				}
				num = (short)1259732993;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesVolumeAdjustToneDisable.Editable;
			}
			set
			{
				short num = (short)122355712;
				short num2 = num;
				num = (short)459400145;
				short num3 = num;
				num = (short)1013179345;
				switch (num3 == num)
				{
				}
				num = (short)1246035969;
				if (num != 0)
				{
				}
				num = (short)529727488;
				if (num != 0)
				{
				}
				this.radWideAlertTonesVolumeAdjustToneDisable.Editable = value;
			}
		}

		// Token: 0x17001600 RID: 5632
		// (get) Token: 0x06002BDC RID: 11228 RVA: 0x002A788C File Offset: 0x002A5A8C
		internal string RadWideAlertTonesVolumeAdjustToneDisable_UILabel
		{
			get
			{
				short num = (short)120651776;
				short num2 = num;
				num = (short)1378218889;
				short num3 = num;
				num = (short)27063177;
				switch (num3 == num)
				{
				}
				num = (short)1920401409;
				if (num != 0)
				{
				}
				num = (short)357761024;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesVolumeAdjustToneDisable.UIName;
			}
		}

		// Token: 0x17001601 RID: 5633
		// (get) Token: 0x06002BDD RID: 11229 RVA: 0x002A7940 File Offset: 0x002A5B40
		// (set) Token: 0x06002BDE RID: 11230 RVA: 0x002A79F4 File Offset: 0x002A5BF4
		internal bool RadWideAlertTonesVolumeAdjustToneDisable_HiddenStatic
		{
			get
			{
				short num = (short)1838415872;
				short num2 = num;
				num = (short)1883805010;
				short num3 = num;
				num = (short)1246467410;
				switch (num3 == num)
				{
				}
				num = (short)1995374592;
				if (num != 0)
				{
				}
				num = (short)853475329;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesVolumeAdjustToneDisable.HiddenStatic;
			}
			set
			{
				short num = (short)1625948160;
				short num2 = num;
				num = (short)1997930497;
				if (num != 0)
				{
				}
				num = (short)1899409377;
				short num3 = num;
				num = (short)97824737;
				switch (num3 == num)
				{
				}
				num = (short)1184563200;
				if (num != 0)
				{
				}
				this.radWideAlertTonesVolumeAdjustToneDisable.HiddenStatic = value;
			}
		}

		// Token: 0x17001602 RID: 5634
		// (get) Token: 0x06002BDF RID: 11231 RVA: 0x002A7AAC File Offset: 0x002A5CAC
		// (set) Token: 0x06002BE0 RID: 11232 RVA: 0x002A7B60 File Offset: 0x002A5D60
		internal bool RadWideAlertTonesVolumeAdjustToneDisable_HiddenDynamic
		{
			get
			{
				short num = (short)101253120;
				short num2 = num;
				num = (short)975509070;
				short num3 = num;
				num = (short)167581262;
				switch (num3 == num)
				{
				}
				num = (short)1794113537;
				if (num != 0)
				{
				}
				num = (short)840564736;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesVolumeAdjustToneDisable.HiddenDynamic;
			}
			set
			{
				short num = (short)1748172800;
				short num2 = num;
				num = (short)692632264;
				short num3 = num;
				num = (short)1470937800;
				switch (num3 == num)
				{
				}
				num = (short)1807220736;
				if (num != 0)
				{
				}
				num = (short)1599930369;
				if (num != 0)
				{
				}
				this.radWideAlertTonesVolumeAdjustToneDisable.HiddenDynamic = value;
			}
		}

		// Token: 0x17001603 RID: 5635
		// (get) Token: 0x06002BE1 RID: 11233 RVA: 0x002A7C18 File Offset: 0x002A5E18
		public bool RadWideAlertTonesVolumeAdjustToneDisable_HasDiffs
		{
			get
			{
				short num = (short)1976238080;
				short num2 = num;
				num = (short)367566039;
				short num3 = num;
				num = (short)459709655;
				switch (num3 == num)
				{
				}
				num = (short)426311681;
				if (num != 0)
				{
				}
				num = (short)509542400;
				if (num != 0)
				{
				}
				return this.radWideAlertTonesVolumeAdjustToneDisable._HasDiffs;
			}
		}

		// Token: 0x17001604 RID: 5636
		// (get) Token: 0x06002BE2 RID: 11234 RVA: 0x002A7CCC File Offset: 0x002A5ECC
		// (set) Token: 0x06002BE3 RID: 11235 RVA: 0x002A7D84 File Offset: 0x002A5F84
		public int RadioWidePTTWarningToneValue
		{
			get
			{
				short num = (short)1611661312;
				short num2 = num;
				num = (short)604536216;
				short num3 = num;
				num = (short)1873509784;
				switch (num3 == num)
				{
				}
				num = (short)2064842752;
				if (num != 0)
				{
				}
				num = (short)544931841;
				if (num != 0)
				{
				}
				return this.radioWidePTTWarningTone.Value;
			}
			set
			{
				short num = (short)1126170624;
				short num2 = num;
				num = (short)1429857317;
				short num3 = num;
				num = (short)1649665061;
				switch (num3 == num)
				{
				}
				num = (short)1140654081;
				if (num != 0)
				{
				}
				num = (short)205520896;
				if (num != 0)
				{
				}
				this.radioWidePTTWarningTone.Value = value;
			}
		}

		// Token: 0x17001605 RID: 5637
		// (get) Token: 0x06002BE4 RID: 11236 RVA: 0x002A7E3C File Offset: 0x002A603C
		// (set) Token: 0x06002BE5 RID: 11237 RVA: 0x002A7EF0 File Offset: 0x002A60F0
		public string RadioWidePTTWarningTone_UIValue
		{
			get
			{
				short num = (short)1506541568;
				short num2 = num;
				num = (short)753523435;
				short num3 = num;
				num = (short)1649335019;
				switch (num3 == num)
				{
				}
				num = (short)1260847104;
				if (num != 0)
				{
				}
				num = (short)544669697;
				if (num != 0)
				{
				}
				return this.radioWidePTTWarningTone.UIValue;
			}
			set
			{
				short num = (short)1187708928;
				short num2 = num;
				num = (short)1564870439;
				short num3 = num;
				num = (short)388892455;
				switch (num3 == num)
				{
				}
				num = (short)1314521089;
				if (num != 0)
				{
				}
				num = (short)887947264;
				if (num != 0)
				{
				}
				this.radioWidePTTWarningTone.UIValue = value;
			}
		}

		// Token: 0x17001606 RID: 5638
		// (get) Token: 0x06002BE6 RID: 11238 RVA: 0x002A7FA4 File Offset: 0x002A61A4
		public global::AcpBusinessLayer.AcpListField RadioWidePTTWarningTone
		{
			get
			{
				short num = (short)128909312;
				short num2 = num;
				num = (short)764882731;
				short num3 = num;
				num = (short)1147612971;
				switch (num3 == num)
				{
				}
				num = (short)1984954368;
				if (num != 0)
				{
				}
				num = (short)505741313;
				if (num != 0)
				{
				}
				return this.radioWidePTTWarningTone;
			}
		}

		// Token: 0x17001607 RID: 5639
		// (get) Token: 0x06002BE7 RID: 11239 RVA: 0x002A8050 File Offset: 0x002A6250
		// (set) Token: 0x06002BE8 RID: 11240 RVA: 0x002A8104 File Offset: 0x002A6304
		public bool RadioWidePTTWarningTone_Applicable
		{
			get
			{
				short num = (short)243924992;
				short num2 = num;
				num = (short)1002671417;
				short num3 = num;
				num = (short)1675201849;
				switch (num3 == num)
				{
				}
				num = (short)319422465;
				if (num != 0)
				{
				}
				num = (short)1063124992;
				if (num != 0)
				{
				}
				return this.radioWidePTTWarningTone.Applicable;
			}
			set
			{
				short num = (short)582025217;
				if (num != 0)
				{
				}
				num = (short)966711190;
				short num2 = num;
				num = (short)1917376406;
				switch (num2 == num)
				{
				}
				num = (short)530907136;
				if (num != 0)
				{
				}
				num = (short)1034158080;
				short num3 = num;
				this.radioWidePTTWarningTone.Applicable = value;
			}
		}

		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x06002BE9 RID: 11241 RVA: 0x002A81B8 File Offset: 0x002A63B8
		// (set) Token: 0x06002BEA RID: 11242 RVA: 0x002A826C File Offset: 0x002A646C
		public bool RadioWidePTTWarningTone_Valid
		{
			get
			{
				short num = (short)112481860;
				short num2 = num;
				num = (short)1049450052;
				switch (num2 == num)
				{
				}
				num = (short)1796341761;
				if (num != 0)
				{
				}
				num = (short)2131689472;
				if (num != 0)
				{
				}
				num = (short)1927806976;
				short num3 = num;
				return this.radioWidePTTWarningTone.Valid;
			}
			set
			{
				short num = (short)807364962;
				short num2 = num;
				num = (short)1702783330;
				switch (num2 == num)
				{
				}
				num = (short)2124808193;
				if (num != 0)
				{
				}
				num = (short)309919744;
				if (num != 0)
				{
				}
				num = (short)495321088;
				short num3 = num;
				this.radioWidePTTWarningTone.Valid = value;
			}
		}

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x06002BEB RID: 11243 RVA: 0x002A8324 File Offset: 0x002A6524
		// (set) Token: 0x06002BEC RID: 11244 RVA: 0x002A83D4 File Offset: 0x002A65D4
		public bool RadioWidePTTWarningTone_Visible
		{
			get
			{
				short num = (short)1322856531;
				short num2 = num;
				num = (short)1930440787;
				switch (num2 == num)
				{
				}
				num = (short)260046848;
				if (num != 0)
				{
				}
				num = (short)957349889;
				if (num != 0)
				{
				}
				num = (short)155975680;
				short num3 = num;
				return this.radioWidePTTWarningTone.Visible;
			}
			set
			{
				short num = (short)371086942;
				short num2 = num;
				num = (short)1872647774;
				switch (num2 == num)
				{
				}
				num = (short)2141847553;
				if (num != 0)
				{
				}
				num = (short)1674772480;
				if (num != 0)
				{
				}
				num = (short)2014183424;
				short num3 = num;
				this.radioWidePTTWarningTone.Visible = value;
			}
		}

		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x06002BED RID: 11245 RVA: 0x002A848C File Offset: 0x002A668C
		// (set) Token: 0x06002BEE RID: 11246 RVA: 0x002A8540 File Offset: 0x002A6740
		public bool RadioWidePTTWarningTone_Editable
		{
			get
			{
				short num = (short)174575784;
				short num2 = num;
				num = (short)1303498920;
				switch (num2 == num)
				{
				}
				num = (short)495845376;
				if (num != 0)
				{
				}
				num = (short)1532231681;
				if (num != 0)
				{
				}
				num = (short)1912537088;
				short num3 = num;
				return this.radioWidePTTWarningTone.Editable;
			}
			set
			{
				short num = (short)30867457;
				if (num != 0)
				{
				}
				num = (short)1830955697;
				short num2 = num;
				num = (short)1729243825;
				switch (num2 == num)
				{
				}
				num = (short)1265696768;
				if (num != 0)
				{
				}
				num = (short)1697251328;
				short num3 = num;
				this.radioWidePTTWarningTone.Editable = value;
			}
		}

		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x06002BEF RID: 11247 RVA: 0x002A85F8 File Offset: 0x002A67F8
		internal string RadioWidePTTWarningTone_UILabel
		{
			get
			{
				short num = (short)1490982631;
				short num2 = num;
				num = (short)1366791911;
				switch (num2 == num)
				{
				}
				num = (short)1854210048;
				if (num != 0)
				{
				}
				num = (short)444465153;
				if (num != 0)
				{
				}
				num = (short)1671102464;
				short num3 = num;
				return this.radioWidePTTWarningTone.UIName;
			}
		}

		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x06002BF0 RID: 11248 RVA: 0x002A86AC File Offset: 0x002A68AC
		// (set) Token: 0x06002BF1 RID: 11249 RVA: 0x002A8760 File Offset: 0x002A6960
		internal bool RadioWidePTTWarningTone_HiddenStatic
		{
			get
			{
				short num = (short)336822643;
				short num2 = num;
				num = (short)1955561843;
				switch (num2 == num)
				{
				}
				num = (short)325255169;
				if (num != 0)
				{
				}
				num = (short)22675456;
				if (num != 0)
				{
				}
				num = (short)1593507840;
				short num3 = num;
				return this.radioWidePTTWarningTone.HiddenStatic;
			}
			set
			{
				short num = (short)1538893637;
				short num2 = num;
				num = (short)570599237;
				switch (num2 == num)
				{
				}
				num = (short)2000617472;
				if (num != 0)
				{
				}
				num = (short)713883649;
				if (num != 0)
				{
				}
				num = (short)277807104;
				short num3 = num;
				this.radioWidePTTWarningTone.HiddenStatic = value;
			}
		}

		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x06002BF2 RID: 11250 RVA: 0x002A8814 File Offset: 0x002A6A14
		// (set) Token: 0x06002BF3 RID: 11251 RVA: 0x002A88CC File Offset: 0x002A6ACC
		internal bool RadioWidePTTWarningTone_HiddenDynamic
		{
			get
			{
				short num = (short)1856194752;
				short num2 = num;
				num = (short)617760960;
				switch (num2 == num)
				{
				}
				num = (short)2085027841;
				if (num != 0)
				{
				}
				num = (short)868220928;
				if (num != 0)
				{
				}
				num = (short)1221656576;
				short num3 = num;
				return this.radioWidePTTWarningTone.HiddenDynamic;
			}
			set
			{
				short num = (short)547324244;
				short num2 = num;
				num = (short)780435796;
				switch (num2 == num)
				{
				}
				num = (short)1604059137;
				if (num != 0)
				{
				}
				num = (short)1491140608;
				if (num != 0)
				{
				}
				num = (short)1406599168;
				short num3 = num;
				this.radioWidePTTWarningTone.HiddenDynamic = value;
			}
		}

		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x06002BF4 RID: 11252 RVA: 0x002A8984 File Offset: 0x002A6B84
		public bool RadioWidePTTWarningTone_HasDiffs
		{
			get
			{
				short num = (short)1070659655;
				short num2 = num;
				num = (short)687142983;
				switch (num2 == num)
				{
				}
				num = (short)448266241;
				if (num != 0)
				{
				}
				num = (short)1080557568;
				if (num != 0)
				{
				}
				num = (short)1003421696;
				short num3 = num;
				return this.radioWidePTTWarningTone._HasDiffs;
			}
		}

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x06002BF5 RID: 11253 RVA: 0x002A8A38 File Offset: 0x002A6C38
		// (set) Token: 0x06002BF6 RID: 11254 RVA: 0x002A8AEC File Offset: 0x002A6CEC
		public int RadWideAlertTonesRSMVolumeSetToneValue
		{
			get
			{
				short num = (short)318832641;
				if (num != 0)
				{
				}
				num = (short)1096641288;
				short num2 = num;
				num = (short)2087938824;
				switch (num2 == num)
				{
				}
				num = (short)122748928;
				if (num != 0)
				{
				}
				num = (short)312016896;
				short num3 = num;
				return this.radWideAlertTonesRSMVolumeSetTone.Value;
			}
			set
			{
				short num = (short)1618280449;
				if (num != 0)
				{
				}
				num = (short)1842763678;
				short num2 = num;
				num = (short)1116755870;
				switch (num2 == num)
				{
				}
				num = (short)1995177984;
				if (num != 0)
				{
				}
				num = (short)1901985792;
				short num3 = num;
				this.radWideAlertTonesRSMVolumeSetTone.Value = value;
			}
		}

		// Token: 0x17001610 RID: 5648
		// (get) Token: 0x06002BF7 RID: 11255 RVA: 0x002A8BA0 File Offset: 0x002A6DA0
		// (set) Token: 0x06002BF8 RID: 11256 RVA: 0x002A8C54 File Offset: 0x002A6E54
		public string RadWideAlertTonesRSMVolumeSetTone_UIValue
		{
			get
			{
				short num = (short)893795353;
				short num2 = num;
				num = (short)465910809;
				switch (num2 == num)
				{
				}
				num = (short)1408040961;
				if (num != 0)
				{
				}
				num = (short)42532864;
				if (num != 0)
				{
				}
				num = (short)944766976;
				short num3 = num;
				return this.radWideAlertTonesRSMVolumeSetTone.UIValue;
			}
			set
			{
				short num = (short)1116755430;
				short num2 = num;
				num = (short)1022383590;
				switch (num2 == num)
				{
				}
				num = (short)1411121153;
				if (num != 0)
				{
				}
				num = (short)517996544;
				if (num != 0)
				{
				}
				num = (short)574619648;
				short num3 = num;
				this.radWideAlertTonesRSMVolumeSetTone.UIValue = value;
			}
		}

		// Token: 0x17001611 RID: 5649
		// (get) Token: 0x06002BF9 RID: 11257 RVA: 0x002A8D08 File Offset: 0x002A6F08
		public global::AcpBusinessLayer.AcpListField RadWideAlertTonesRSMVolumeSetTone
		{
			get
			{
				short num = (short)1093510594;
				short num2 = num;
				num = (short)151299522;
				switch (num2 == num)
				{
				}
				num = (short)1588002817;
				if (num != 0)
				{
				}
				num = (short)1320878080;
				if (num != 0)
				{
				}
				num = (short)503250944;
				short num3 = num;
				return this.radWideAlertTonesRSMVolumeSetTone;
			}
		}

		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x06002BFA RID: 11258 RVA: 0x002A8DB8 File Offset: 0x002A6FB8
		// (set) Token: 0x06002BFB RID: 11259 RVA: 0x002A8E6C File Offset: 0x002A706C
		public bool RadWideAlertTonesRSMVolumeSetTone_Applicable
		{
			get
			{
				short num = (short)1906736830;
				short num2 = num;
				num = (short)521502398;
				switch (num2 == num)
				{
				}
				num = (short)323682305;
				if (num != 0)
				{
				}
				num = (short)1746206720;
				if (num != 0)
				{
				}
				num = (short)755695616;
				short num3 = num;
				return this.radWideAlertTonesRSMVolumeSetTone.Applicable;
			}
			set
			{
				short num = (short)1832976385;
				if (num != 0)
				{
				}
				num = (short)1889529618;
				short num2 = num;
				num = (short)163442450;
				switch (num2 == num)
				{
				}
				num = (short)962920448;
				if (num != 0)
				{
				}
				num = (short)619577344;
				short num3 = num;
				this.radWideAlertTonesRSMVolumeSetTone.Applicable = value;
			}
		}

		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x06002BFC RID: 11260 RVA: 0x002A8F24 File Offset: 0x002A7124
		// (set) Token: 0x06002BFD RID: 11261 RVA: 0x002A8FDC File Offset: 0x002A71DC
		public bool RadWideAlertTonesRSMVolumeSetTone_Valid
		{
			get
			{
				short num = (short)1553273173;
				short num2 = num;
				num = (short)1894977877;
				switch (num2 == num)
				{
				}
				num = (short)330432512;
				if (num != 0)
				{
				}
				num = (short)1649410049;
				if (num != 0)
				{
				}
				num = (short)891486208;
				short num3 = num;
				return this.radWideAlertTonesRSMVolumeSetTone.Valid;
			}
			set
			{
				short num = (short)1401930098;
				short num2 = num;
				num = (short)1189069170;
				switch (num2 == num)
				{
				}
				num = (short)624361472;
				if (num != 0)
				{
				}
				num = (short)236650497;
				if (num != 0)
				{
				}
				num = (short)1222639616;
				short num3 = num;
				this.radWideAlertTonesRSMVolumeSetTone.Valid = value;
			}
		}

		// Token: 0x17001614 RID: 5652
		// (get) Token: 0x06002BFE RID: 11262 RVA: 0x002A9094 File Offset: 0x002A7294
		// (set) Token: 0x06002BFF RID: 11263 RVA: 0x002A914C File Offset: 0x002A734C
		public bool RadWideAlertTonesRSMVolumeSetTone_Visible
		{
			get
			{
				short num = (short)1555750307;
				short num2 = num;
				num = (short)1162337699;
				switch (num2 == num)
				{
				}
				num = (short)664076288;
				if (num != 0)
				{
				}
				num = (short)1065943041;
				if (num != 0)
				{
				}
				num = (short)2011168768;
				short num3 = num;
				return this.radWideAlertTonesRSMVolumeSetTone.Visible;
			}
			set
			{
				short num = (short)84653993;
				short num2 = num;
				num = (short)420525993;
				switch (num2 == num)
				{
				}
				num = (short)677773313;
				if (num != 0)
				{
				}
				num = (short)781189120;
				if (num != 0)
				{
				}
				num = (short)482082816;
				short num3 = num;
				this.radWideAlertTonesRSMVolumeSetTone.Visible = value;
			}
		}

		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x06002C00 RID: 11264 RVA: 0x002A9204 File Offset: 0x002A7404
		// (set) Token: 0x06002C01 RID: 11265 RVA: 0x002A92B8 File Offset: 0x002A74B8
		public bool RadWideAlertTonesRSMVolumeSetTone_Editable
		{
			get
			{
				short num = (short)1021918896;
				short num2 = num;
				num = (short)753811120;
				switch (num2 == num)
				{
				}
				num = (short)1369636864;
				if (num != 0)
				{
				}
				num = (short)1699676161;
				if (num != 0)
				{
				}
				num = (short)537067520;
				short num3 = num;
				return this.radWideAlertTonesRSMVolumeSetTone.Editable;
			}
			set
			{
				short num = (short)472464598;
				short num2 = num;
				num = (short)1789410518;
				switch (num2 == num)
				{
				}
				num = (short)1167196161;
				if (num != 0)
				{
				}
				num = (short)675676160;
				if (num != 0)
				{
				}
				num = (short)1684996096;
				short num3 = num;
				this.radWideAlertTonesRSMVolumeSetTone.Editable = value;
			}
		}

		// Token: 0x17001616 RID: 5654
		// (get) Token: 0x06002C02 RID: 11266 RVA: 0x002A9370 File Offset: 0x002A7570
		internal string RadWideAlertTonesRSMVolumeSetTone_UILabel
		{
			get
			{
				short num = (short)339380492;
				short num2 = num;
				num = (short)1254328588;
				switch (num2 == num)
				{
				}
				num = (short)10878977;
				if (num != 0)
				{
				}
				num = (short)589627392;
				if (num != 0)
				{
				}
				num = (short)1251147776;
				short num3 = num;
				return this.radWideAlertTonesRSMVolumeSetTone.UIName;
			}
		}

		// Token: 0x17001617 RID: 5655
		// (get) Token: 0x06002C03 RID: 11267 RVA: 0x002A9424 File Offset: 0x002A7624
		// (set) Token: 0x06002C04 RID: 11268 RVA: 0x002A94D8 File Offset: 0x002A76D8
		internal bool RadWideAlertTonesRSMVolumeSetTone_HiddenStatic
		{
			get
			{
				short num = (short)156454545;
				short num2 = num;
				num = (short)117591697;
				switch (num2 == num)
				{
				}
				num = (short)1486684160;
				if (num != 0)
				{
				}
				num = (short)1680670721;
				if (num != 0)
				{
				}
				num = (short)515899392;
				short num3 = num;
				return this.radWideAlertTonesRSMVolumeSetTone.HiddenStatic;
			}
			set
			{
				short num = (short)219222992;
				short num2 = num;
				num = (short)1534923728;
				switch (num2 == num)
				{
				}
				num = (short)511901696;
				if (num != 0)
				{
				}
				num = (short)1712586753;
				if (num != 0)
				{
				}
				num = (short)1805320192;
				short num3 = num;
				this.radWideAlertTonesRSMVolumeSetTone.HiddenStatic = value;
			}
		}

		// Token: 0x17001618 RID: 5656
		// (get) Token: 0x06002C05 RID: 11269 RVA: 0x002A9590 File Offset: 0x002A7790
		// (set) Token: 0x06002C06 RID: 11270 RVA: 0x002A9644 File Offset: 0x002A7844
		internal bool RadWideAlertTonesRSMVolumeSetTone_HiddenDynamic
		{
			get
			{
				short num = (short)1217892783;
				short num2 = num;
				num = (short)2000130479;
				switch (num2 == num)
				{
				}
				num = (short)919994369;
				if (num != 0)
				{
				}
				num = (short)171442176;
				if (num != 0)
				{
				}
				num = (short)950468608;
				short num3 = num;
				return this.radWideAlertTonesRSMVolumeSetTone.HiddenDynamic;
			}
			set
			{
				short num = (short)2056650753;
				if (num != 0)
				{
				}
				num = (short)147160859;
				short num2 = num;
				num = (short)713719579;
				switch (num2 == num)
				{
				}
				num = (short)214958080;
				if (num != 0)
				{
				}
				num = (short)668729344;
				short num3 = num;
				this.radWideAlertTonesRSMVolumeSetTone.HiddenDynamic = value;
			}
		}

		// Token: 0x17001619 RID: 5657
		// (get) Token: 0x06002C07 RID: 11271 RVA: 0x002A96FC File Offset: 0x002A78FC
		public bool RadWideAlertTonesRSMVolumeSetTone_HasDiffs
		{
			get
			{
				short num = (short)326276655;
				short num2 = num;
				num = (short)898668079;
				switch (num2 == num)
				{
				}
				num = (short)1407451136;
				if (num != 0)
				{
				}
				num = (short)1008074753;
				if (num != 0)
				{
				}
				num = (short)1923743744;
				short num3 = num;
				return this.radWideAlertTonesRSMVolumeSetTone._HasDiffs;
			}
		}

		// Token: 0x06002C08 RID: 11272 RVA: 0x002A97B0 File Offset: 0x002A79B0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_4A;
			}
			short num;
			int num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)597688321;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1449459714;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					if (base.ParentRecset == null)
					{
						return result;
					}
					num = (short)1047944616;
					short num3 = num;
					num = (short)1283349928;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_146;
					default:
					{
						num = (short)1519190016;
						short num4 = num;
						num = (short)1827733504;
						if (num != 0)
						{
						}
						num = (short)203816963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					return result;
				case 3:
					num = (short)1786511364;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						goto IL_146;
					}
					return result;
				}
				goto IL_4A;
				IL_146:
				num = (short)251133952;
				num2 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_4A:
			result = null;
			num = (short)1717698561;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04000FD0 RID: 4048
		private global::AcpBusinessLayer.AcpFieldX<bool, bool> radProfAlertTonesAlertTones_A7428;

		// Token: 0x04000FD1 RID: 4049
		private global::AcpBusinessLayer.AcpField<bool> radProfAlertTonesCallAlertToneAutoReset_A7596;

		// Token: 0x04000FD2 RID: 4050
		private global::AcpBusinessLayer.AcpField<bool> radProfAlertTonesLED_A8428;

		// Token: 0x04000FD3 RID: 4051
		private global::AcpBusinessLayer.AcpListField radProfAlertTonesMuteTonesOperation_A8562;

		// Token: 0x04000FD4 RID: 4052
		private global::AcpBusinessLayer.AcpField<bool> radProfAlertTonesPowerUpSelfTestAlertTone_A8718;

		// Token: 0x04000FD5 RID: 4053
		private global::AcpBusinessLayer.AcpListField radProfAlertTonesRotaryAlert_A8983;

		// Token: 0x04000FD6 RID: 4054
		private global::AcpBusinessLayer.AcpSimpleRangeField radProfAlertTonesStandbyChirpsec_A9179;

		// Token: 0x04000FD7 RID: 4055
		private global::AcpBusinessLayer.AcpField<bool> radWideAlertTonesTxChirp_A9523;

		// Token: 0x04000FD8 RID: 4056
		private global::AcpBusinessLayer.AcpField<bool> radWideAlertTonesVolumeAdjustToneOffset_A9656;

		// Token: 0x04000FD9 RID: 4057
		private global::AcpBusinessLayer.AcpField<bool> radWideAlertTonesZeroLevelAudioMute_A9689;

		// Token: 0x04000FDA RID: 4058
		private global::AcpBusinessLayer.AcpField<bool> radWideAlertTonesScanAlertToneEnable_A19555;

		// Token: 0x04000FDB RID: 4059
		private global::AcpBusinessLayer.AcpListField radWideAdvancedSmartLowBatteryAlert_A9165;

		// Token: 0x04000FDC RID: 4060
		private global::AcpBusinessLayer.AcpListField radProfAlertTonesNewMuteTonesOperation_A42149;

		// Token: 0x04000FDD RID: 4061
		private global::AcpBusinessLayer.AcpListField radProfAlertTonesEnhancedMuteTonesOperation_A42150;

		// Token: 0x04000FDE RID: 4062
		private global::AcpBusinessLayer.AcpListField radWideTalkProhibitToneSelection_A42416;

		// Token: 0x04000FDF RID: 4063
		private global::AcpBusinessLayer.AcpListField radWideOutOfRangeToneSelection_A42450;

		// Token: 0x04000FE0 RID: 4064
		private global::AcpBusinessLayer.AcpField<bool> radWideAlertTonesVolumeAdjustToneDisable;

		// Token: 0x04000FE1 RID: 4065
		private global::AcpBusinessLayer.AcpListField radioWidePTTWarningTone;

		// Token: 0x04000FE2 RID: 4066
		private global::AcpBusinessLayer.AcpListField radWideAlertTonesRSMVolumeSetTone;
	}
}
