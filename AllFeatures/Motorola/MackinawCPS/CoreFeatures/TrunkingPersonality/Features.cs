using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.ScanList;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality
{
	// Token: 0x020000C5 RID: 197
	[global::System.Serializable]
	public class Features : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001805 RID: 6149 RVA: 0x001902D0 File Offset: 0x0018E4D0
		public Features(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x001902EC File Offset: 0x0018E4EC
		protected Features(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x00190304 File Offset: 0x0018E504
		public override void Init()
		{
			int a_ = 18;
			short num = (short)814228109;
			short num2 = num;
			num = (short)653599373;
			switch (num2 == num)
			{
			}
			num = (short)2021851137;
			if (num != 0)
			{
			}
			num = (short)48168960;
			if (num != 0)
			{
			}
			num = (short)1752170496;
			short num3 = num;
			this.trkPerFeaturesAutomaticScan_A7528 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖觘뻚꿜駞蓠苢釤鋦鯨軪黬껮蓰蟲髴髶飸迺铼鳾刀怂搄椆嘈䨊㨌㨎⌐⬒", a_), global::CommonResources.AcgResources.ID_SCANAUTOMATICSCAN);
			this.trkPerFeaturesAutomaticScan_A7528.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerFeaturesAutomaticScan_A7528.DataTransferOrder = 33;
			this.trkPerFeaturesHotKeypadDTMF_A8209 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖觘뻚꿜駞蓠苢釤鋦鯨軪黬꟮黰蟲뻴鋶胸诺鳼鯾䔀圂䠄䄆嘈䨊㔌㴎ℐ⨒", a_), global::CommonResources.AcgResources.ID_HOTKEYPADDTMF);
			this.trkPerFeaturesHotKeypadDTMF_A8209.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkPerFeaturesHotKeypadDTMF_A8209.DataTransferOrder = 34;
			this.trkPerFeaturesMessageEnable_A8499 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖觘뻚꿜駞蓠苢釤鋦鯨軪黬ꋮ铰胲蛴零黸黺룼釾怀愂椄戆嘈䨊㔌㬎⠐⨒", a_), global::CommonResources.AcgResources.ID_STATUSMESSAGEMESSAGEENABLE);
			this.trkPerFeaturesMessageEnable_A8499.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerFeaturesMessageEnable_A8499.DataTransferOrder = 35;
			this.trkPerFeaturesPhoneOperation_A8701 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖觘뻚꿜駞蓠苢釤鋦鯨軪黬뿮駰鳲鯴鋶뛸诺飼跾怀眂氄栆月吊䰌㜎☐⌒␔", a_), global::CommonResources.AcgResources.ID_PHONEOPERATION, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerFeaturesPhoneOperation_A8701LovStrs);
			this.trkPerFeaturesPhoneOperation_A8701.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerFeaturesPhoneOperation_A8701.DataTransferOrder = 36;
			this.trkPerFeaturesSecureProperCodeDetect_A8763 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖觘뻚꿜駞蓠苢釤鋦鯨軪黬볮铰郲胴藶鳸꯺迼郾焀昂眄䐆昈漊栌䬎琐朒瀔琖洘䐚尜✞ᘠᔢᘤ", a_), global::CommonResources.AcgResources.ID_SECUREPROPERCODEDETECT);
			this.trkPerFeaturesSecureProperCodeDetect_A8763.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerFeaturesSecureProperCodeDetect_A8763.DataTransferOrder = 42;
			this.trkPerFeaturesScanListSelection_A9053 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖觘뻚꿜駞蓠苢釤鋦鯨軪黬볮鋰鋲鯴믶郸裺觼곾搀漂怄搆紈戊戌愎丐划Ⱄ✖Ⱈ⠚", a_), global::CommonResources.AcgResources.ID_SCANSCANLISTSELECTION, new string[]
			{
				global::CommonResources.AcgResources.ID_NONE
			}, new int[1], true, false);
			this.trkPerFeaturesScanListSelection_A9053.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerFeaturesScanListSelection_A9053.DataTransferOrder = 22;
			this.trkPerFeaturesStatusEnable_A9188 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖觘뻚꿜駞蓠苢釤鋦鯨軪黬볮藰鋲致苶諸뻺鏼黾挀漂怄堆䠈㈊㰌㜎⤐", a_), global::CommonResources.AcgResources.ID_STATUSMESSAGESTATUSENABLE);
			this.trkPerFeaturesStatusEnable_A9188.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerFeaturesStatusEnable_A9188.DataTransferOrder = 19;
			this.trkPerFeaturesTalkPermitTone_A9271 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖觘뻚꿜駞蓠苢釤鋦鯨軪黬믮郰鿲黴ꟶ鳸觺郼雾甀圂樄椆氈吊䰌㘎⌐␒␔", a_), global::CommonResources.AcgResources.ID_RADIOERGOTALKPERMITTONE);
			this.trkPerFeaturesTalkPermitTone_A9271.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerFeaturesTalkPermitTone_A9271.DataTransferOrder = 20;
			this.trkPerIgnoreRxClearVoice_A41610 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖觘뻚꿜雞蛠跢諤闦賨맪闬곮鷰雲铴藶꿸铺铼鳾搀専䐄㌆㠈㴊㰌㼎", a_), global::CommonResources.AcgResources.ID_IGNORERXCLEARVOICE);
			this.trkPerIgnoreRxClearVoice_A41610.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerIgnoreRxClearVoice_A41610.DataTransferOrder = 50;
			this.trkPerEndTxOnVoiceAbsence_42461 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖觘뻚꿜髞迠蟢뇤鿦ꛨ藪믬胮飰郲郴뛶鯸裺飼釾戀昂娄㌆㬈㼊㬌㸎", a_), global::CommonResources.AcgResources.ID_ENDTXONVOICEABSENCE);
			this.trkPerEndTxOnVoiceAbsence_42461.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkPerEndTxOnVoiceAbsence_42461.DataTransferOrder = 70;
			this.trkPerFeaturesHazardZoneModePersonality = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖觘뻚꿜駞蓠苢釤鋦鯨軪黬꟮郰觲铴藶鷸ꇺ鋼釾搀丂樄挆氈嬊栌紎成簒笔瘖甘爚検昞", a_), global::CommonResources.AcgResources.ID_TRUNKINGHAZARDZONEMODEPERSONALITY);
			this.trkPerFeaturesHazardZoneModePersonality.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkPerFeaturesHazardZoneModePersonality.DataTransferOrder = 72;
			this.trkPerFeaturesTacticalPublicSafetyUIEnable = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖觘뻚꿜駞蓠苢釤鋦鯨軪黬믮郰郲致黶髸髺釼꿾琀愂椄渆樈堊氌椎琐朒气䈖倘帚猜縞䌠伢䀤", a_), global::CommonResources.AcgResources.ID_TRKTACTICALPUBLICSAFETYUIENABLE);
			this.trkPerFeaturesTacticalPublicSafetyUIEnable.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerFeaturesTacticalPublicSafetyUIEnable.DataTransferOrder = 73;
			this.trkPerFeatureDTMFMicEn_A42482 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖觘뻚꿜駞蓠苢釤鋦鯨軪ꧬ믮볰뗲룴黶髸뻺鏼ꃾ䀀㜂㜄㌆ㄈ㤊", a_), global::CommonResources.AcgResources.ID_DTMFMICENABLE);
			this.trkPerFeatureDTMFMicEn_A42482.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkPerFeatureDTMFMicEn_A42482.DataTransferOrder = 285;
			this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖觘뻚꿜駞蓠苢釤鋦鯨軪黬뿮菰髲髴藶郸迺蓼믾栀瀂甄昆紈栊攌嬎砐縒瀔堖氘漚䤜瘞䰠䘢圤否䰨䠪爬ᬮȰزఴ༶", a_), global::CommonResources.AcgResources.ID_PRIORITYDISPATCHTIMEOUTTIMER, 1, 255, null, null, 0, 1);
			this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.DataTransferOrder = 71;
			this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.ShowHexValue = false;
			this.trkPerFeatureBackupPTTOperation_A43628 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.indexTrkPerFeatureBackupPTTOperation_A43628LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.idTrkPerFeatureBackupPTTOperation_A43628LovStrs), this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖觘뻚꿜駞蓠苢釤鋦鯨軪꿬軮鋰飲胴蟶꧸꿺ꧼ냾焀昂眄昆紈戊戌愎丐划℔␖⼘⤚├", a_), global::CommonResources.AcgResources.ID_BACKUPPTTOPERATION, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerFeatureBackupPTTOperation_A43628LovStrs);
			this.trkPerFeatureBackupPTTOperation_A43628.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerFeatureBackupPTTOperation_A43628.DataTransferOrder = 286;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("闒냔뛖귘껚꿜뫞鋠", a_);
			base.Id = 10175;
			base.UIName = global::CommonResources.AcgResources.ID_FEATURES;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x00190784 File Offset: 0x0018E984
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)1251082287;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ釓룕볗軙ꓛ針軟듡诣迥诧迩귫賭華韱髳闵鷷ꗹ죻쳽㓿㐁㔃", a_)))
					{
						num = (short)281018372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_119;
				case 1:
					goto IL_18F;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟釡듣铥臧藩黫蟭蓯诱냳鿵请諹鷻諽揿樁倃漅攇漉䌋笍搏䘑紓笕紗栙漛笝䌟紡ဣᔥᴧጩᐫ", a_)))
					{
						num = (short)1231618092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B65;
				case 3:
					goto IL_27E;
				case 4:
					this.trkPerEndTxOnVoiceAbsence_42461 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ釓룕볗軙ꓛ針軟듡诣迥诧迩귫賭華韱髳闵鷷ꗹ죻쳽㓿㐁㔃", a_), global::CommonResources.AcgResources.ID_ENDTXONVOICEABSENCE);
					this.trkPerEndTxOnVoiceAbsence_42461.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkPerEndTxOnVoiceAbsence_42461.DataTransferOrder = 70;
					num = (short)1617100815;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_BA9;
				case 6:
					goto IL_A1F;
				case 7:
					this.trkPerFeaturesMessageEnable_A8499 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟釡ꧣ菥鯧駩跫觭闯럱髳韵髷雹駻ꇽ䇿㨁〃㼅ㄇ", a_), global::CommonResources.AcgResources.ID_STATUSMESSAGEMESSAGEENABLE);
					this.trkPerFeaturesMessageEnable_A8499.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerFeaturesMessageEnable_A8499.DataTransferOrder = 35;
					num = (short)243204137;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)299696164;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					this.trkPerFeaturesScanListSelection_A9053 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟釡럣藥觧蓩ꃫ蟭華蛱ꟳ鏵铷鿹鿻諽槿洁樃夅䤇㌉㰋㬍⌏", a_), global::CommonResources.AcgResources.ID_SCANSCANLISTSELECTION, new string[]
					{
						global::CommonResources.AcgResources.ID_NONE
					}, new int[1], true, false);
					this.trkPerFeaturesScanListSelection_A9053.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerFeaturesScanListSelection_A9053.DataTransferOrder = 22;
					num = (short)40828967;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_49D;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鷓뇕뛗뗙껛믝닟髡꟣諥跧诩黫룭鿯鯱音鏵ꟷ믹죻쿽㛿㌁㐃", a_)))
					{
						num = (short)1531969560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_825;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟釡ꧣ菥鯧駩跫觭闯럱髳韵髷雹駻ꇽ䇿㨁〃㼅ㄇ", a_)))
					{
						num = (short)1362362375;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3DC;
				case 13:
					this.trkPerFeaturesHotKeypadDTMF_A8209 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟釡곣觥鳧ꇩ觫韭胯鏱郳답곷럹뫻ꇽ䇿㨁㘃㘅ㄇ", a_), global::CommonResources.AcgResources.ID_HOTKEYPADDTMF);
					this.trkPerFeaturesHotKeypadDTMF_A8209.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkPerFeaturesHotKeypadDTMF_A8209.DataTransferOrder = 34;
					num = (short)5832722;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟釡럣鋥觧黩駫鷭뗯鳱闳铵铷鿹ꏻ뿽㧿㌁㰃㸅", a_)))
					{
						num = (short)1859321872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A1F;
				case 15:
					goto IL_119;
				case 16:
					this.trkPerFeaturesStatusEnable_A9188 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟釡럣鋥觧黩駫鷭뗯鳱闳铵铷鿹ꏻ뿽㧿㌁㰃㸅", a_), global::CommonResources.AcgResources.ID_STATUSMESSAGESTATUSENABLE);
					this.trkPerFeaturesStatusEnable_A9188.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerFeaturesStatusEnable_A9188.DataTransferOrder = 19;
					num = (short)97976326;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					this.trkPerFeaturesSecureProperCodeDetect_A8763 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟釡럣菥诧鿩黫语ꃯ胱鯳蛵鷷裹뿻釽擿朁䀃挅簇漉漋稍伏匑Ⱃℕ⸗⤙", a_), global::CommonResources.AcgResources.ID_SECUREPROPERCODEDETECT);
					this.trkPerFeaturesSecureProperCodeDetect_A8763.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerFeaturesSecureProperCodeDetect_A8763.DataTransferOrder = 42;
					num = (short)1484914714;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_5FD;
				case 19:
					num = (short)1858601005;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟釡럣菥诧鿩黫语ꃯ胱鯳蛵鷷裹뿻釽擿朁䀃挅簇漉漋稍伏匑Ⱃℕ⸗⤙", a_)))
					{
						num = (short)1147535377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7DC;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟釡냣蟥蓧臩볫语苯鿱鷳苵곷闹鋻鯽忿䌁㴃㐅㼇㬉", a_)))
					{
						num = (short)21364758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18F;
				case 22:
					this.trkPerFeaturesTalkPermitTone_A9271 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟釡냣蟥蓧臩볫语苯鿱鷳苵곷闹鋻鯽忿䌁㴃㐅㼇㬉", a_), global::CommonResources.AcgResources.ID_RADIOERGOTALKPERMITTONE);
					this.trkPerFeaturesTalkPermitTone_A9271.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkPerFeaturesTalkPermitTone_A9271.DataTransferOrder = 20;
					num = (short)458489857;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
				{
					if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟釡듣軥蟧蓩觫ꇭ胯韱蛳韵賷鏹鏻都忿䌁㰃ㄅ㠇㬉", a_)))
					{
						goto IL_69E;
					}
					num = (short)381186000;
					short num3 = num;
					num = (short)1593208784;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BA9;
					default:
					{
						num = (short)1179648;
						short num4 = num;
						num = (short)1984954368;
						if (num != 0)
						{
						}
						num = (short)1312555041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 24:
					this.trkPerIgnoreRxClearVoice_A41610 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鷓뇕뛗뗙껛믝닟髡꟣諥跧诩黫룭鿯鯱音鏵ꟷ믹죻쿽㛿㌁㐃", a_), global::CommonResources.AcgResources.ID_IGNORERXCLEARVOICE);
					this.trkPerIgnoreRxClearVoice_A41610.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerIgnoreRxClearVoice_A41610.DataTransferOrder = 50;
					num = (short)406650912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					this.trkPerFeaturesTacticalPublicSafetyUIEnable = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟釡냣蟥诧黩藫跭釯黱ꓳ菵髷雹闻鷽叿持戃挅簇猉夋䜍唏簑甓琕琗缙", a_), global::CommonResources.AcgResources.ID_TRKTACTICALPUBLICSAFETYUIENABLE);
					this.trkPerFeaturesTacticalPublicSafetyUIEnable.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerFeaturesTacticalPublicSafetyUIEnable.DataTransferOrder = 73;
					num = (short)1491468319;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					goto IL_7DC;
				case 27:
					goto IL_742;
				case 28:
					this.trkPerFeatureDTMFMicEn_A42482 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟ꛡ냣ꯥ껧꟩藫跭뗯鳱꯳럵쳷죹죻웽㋿", a_), global::CommonResources.AcgResources.ID_DTMFMICENABLE);
					this.trkPerFeatureDTMFMicEn_A42482.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkPerFeatureDTMFMicEn_A42482.DataTransferOrder = 285;
					num = (short)1012727818;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟ꃡ藣藥菧鿩鳫뻭ꓯ꛱믳蛵鷷裹鷻諽槿洁樃夅䤇㸉㼋㠍∏⨑", a_)))
					{
						num = (short)1889533957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BAE;
				case 30:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟ꛡ냣ꯥ껧꟩藫跭뗯鳱꯳럵쳷죹죻웽㋿", a_)))
					{
						num = (short)1389887516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_49D;
				case 31:
					goto IL_231;
				case 32:
					goto IL_825;
				case 33:
					this.trkPerFeaturesPhoneOperation_A8701 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟釡듣軥蟧蓩觫ꇭ胯韱蛳韵賷鏹鏻都忿䌁㰃ㄅ㠇㬉", a_), global::CommonResources.AcgResources.ID_PHONEOPERATION, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerFeaturesPhoneOperation_A8701LovStrs);
					this.trkPerFeaturesPhoneOperation_A8701.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerFeaturesPhoneOperation_A8701.DataTransferOrder = 36;
					num = (short)1264320552;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					goto IL_551;
				case 35:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟釡곣觥鳧ꇩ觫韭胯鏱郳답곷럹뫻ꇽ䇿㨁㘃㘅ㄇ", a_)))
					{
						num = (short)2014576653;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5FD;
				case 36:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟釡ꗣ鏥鳧藩臫迭蓯鯱音ꗵ鯷鯹鋻ꇽ䇿㔁㄃㐅〇", a_)))
					{
						num = (short)1872035886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_27E;
				case 37:
					this.trkPerFeaturesHazardZoneModePersonality = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟釡곣蟥鋧诩黫諭ꫯ鷱髳鏵뗷闹飻鯽僿朁瘃甅朇搉洋戍礏昑洓", a_), global::CommonResources.AcgResources.ID_TRUNKINGHAZARDZONEMODEPERSONALITY);
					this.trkPerFeaturesHazardZoneModePersonality.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkPerFeaturesHazardZoneModePersonality.DataTransferOrder = 72;
					num = (short)1124925467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟釡곣蟥鋧诩黫諭ꫯ鷱髳鏵뗷闹飻鯽僿朁瘃甅朇搉洋戍礏昑洓", a_)))
					{
						num = (short)1069875201;
						if (num != 0)
						{
						}
						num = (short)784269349;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_742;
				case 39:
					goto IL_78F;
				case 40:
					goto IL_69E;
				case 41:
					goto IL_3DC;
				case 42:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟釡럣藥觧蓩ꃫ蟭華蛱ꟳ鏵铷鿹鿻諽槿洁樃夅䤇㌉㰋㬍⌏", a_)))
					{
						num = (short)1231159305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_78F;
				case 43:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟釡냣蟥诧黩藫跭釯黱ꓳ菵髷雹闻鷽叿持戃挅簇猉夋䜍唏簑甓琕琗缙", a_)))
					{
						num = (short)315490329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_231;
				case 44:
					this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟釡듣铥臧藩黫蟭蓯诱냳鿵请諹鷻諽揿樁倃漅攇漉䌋笍搏䘑紓笕紗栙漛笝䌟紡ဣᔥᴧጩᐫ", a_), global::CommonResources.AcgResources.ID_PRIORITYDISPATCHTIMEOUTTIMER, null, null, 0, 1);
					this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.DataTransferOrder = 71;
					this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.ShowHexValue = false;
					num = (short)1834221616;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 45:
					if (producerFields != null)
					{
						num = (short)1440284680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BAE;
				case 46:
					this.trkPerFeaturesAutomaticScan_A7528 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟釡ꗣ鏥鳧藩臫迭蓯鯱音ꗵ鯷鯹鋻ꇽ䇿㔁㄃㐅〇", a_), global::CommonResources.AcgResources.ID_SCANAUTOMATICSCAN);
					this.trkPerFeaturesAutomaticScan_A7528.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerFeaturesAutomaticScan_A7528.DataTransferOrder = 33;
					num = (short)2102853635;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 47:
					switch (0)
					{
					case 0:
						goto IL_F2;
					}
					continue;
				case 48:
					goto IL_B65;
				}
				IL_F2:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1874067475;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_119:
				num = (short)1755578406;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_18F:
				num = (short)2106064907;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_231:
				num = (short)1202257950;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_27E:
				num = (short)833028131;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3DC:
				num = (short)1172504599;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_49D:
				num = (short)2098921474;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5FD:
				num = (short)1210515468;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_69E:
				num = (short)2100756500;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_742:
				num = (short)2105344043;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_78F:
				num = (short)1415708686;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7DC:
				num = (short)345833514;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_825:
				num = (short)1050935296;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A1F:
				num = (short)1359413269;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B65:
				num = (short)1378746397;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BA9:
				this.trkPerFeatureBackupPTTOperation_A43628 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.indexTrkPerFeatureBackupPTTOperation_A43628LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.idTrkPerFeatureBackupPTTOperation_A43628LovStrs), this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ鋓돕맗껙꧛곝藟ꃡ藣藥菧鿩鳫뻭ꓯ꛱믳蛵鷷裹鷻諽槿洁樃夅䤇㸉㼋㠍∏⨑", a_), global::CommonResources.AcgResources.ID_BACKUPPTTOPERATION, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerFeatureBackupPTTOperation_A43628LovStrs);
				this.trkPerFeatureBackupPTTOperation_A43628.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
				this.trkPerFeatureBackupPTTOperation_A43628.DataTransferOrder = 286;
				num = (short)1642135586;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_551:
			IL_BAE:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軇꿉귋뫍ꗏꃑ뇓ꗕ", a_);
			base.Id = 10175;
			base.UIName = global::CommonResources.AcgResources.ID_FEATURES;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x00191370 File Offset: 0x0018F570
		public override void PopulateReferences()
		{
			short num = (short)705453131;
			short num2 = num;
			num = (short)164912203;
			switch (num2 == num)
			{
			}
			num = (short)261881857;
			if (num != 0)
			{
			}
			num = (short)971767808;
			if (num != 0)
			{
			}
			num = (short)2044854272;
			short num3 = num;
			this.trkPerFeaturesScanListSelection_A9053.SetRecset(this.a(2057));
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x00191430 File Offset: 0x0018F630
		public override void DropReferences()
		{
			short num = (short)1453407931;
			short num2 = num;
			num = (short)1266237115;
			switch (num2 == num)
			{
			}
			num = (short)1947467777;
			if (num != 0)
			{
			}
			num = (short)1969422336;
			if (num != 0)
			{
			}
			num = (short)1767047168;
			short num3 = num;
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x001914DC File Offset: 0x0018F6DC
		public override void SetConstraints()
		{
			short num = (short)308810993;
			short num2 = num;
			num = (short)135664881;
			switch (num2 == num)
			{
			}
			num = (short)386269185;
			if (num != 0)
			{
			}
			num = (short)342687744;
			if (num != 0)
			{
			}
			num = (short)774766592;
			short num3 = num;
			this.trkPerFeaturesAutomaticScan_A7528.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkPerPerScanMbrVctIndexIsNotNoChoice);
			this.trkPerFeaturesHotKeypadDTMF_A8209.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conReturnTrue);
			this.trkPerFeaturesMessageEnable_A8499.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkPerIsTypeII);
			this.trkPerFeaturesSecureProperCodeDetect_A8763.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConEmcEqpdExtEnableAndTrkSysTypeIsII);
			this.trkPerFeaturesScanListSelection_A9053.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConIsTrkPerScanRecRefSelectionValid);
			this.trkPerFeaturesStatusEnable_A9188.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConDvrsMsuGenStsOnModChgApp);
			this.trkPerFeaturesStatusEnable_A9188.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConDvrsMsuGenStsOnModChgValid);
			this.trkPerIgnoreRxClearVoice_A41610.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConSecureOperationIsNotDisabledForTrkPer);
			this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkPerIsASTRO25DVRSProfileDisabled);
			this.trkPerFeatureBackupPTTOperation_A43628.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkPerIsASTRO25);
			this.trkPerFeatureBackupPTTOperation_A43628.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conIsBackupPTTOperationSelectionValid);
			this.trkPerFeaturesHazardZoneModePersonality.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.TrkSysFeaturesHazardZoneModePersonalityValid);
			this.trkPerFeaturesTacticalPublicSafetyUIEnable.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkPerIsASTRO25);
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x001916B0 File Offset: 0x0018F8B0
		public override void SetupDependencies()
		{
			short num = (short)360005720;
			short num2 = num;
			num = (short)1053376600;
			switch (num2 == num)
			{
			}
			num = (short)1783955456;
			if (num != 0)
			{
			}
			num = (short)718405633;
			if (num != 0)
			{
			}
			num = (short)2046623744;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
			this.trkPerFeaturesScanListSelection_A9053.AddDependentObject(this.trkPerFeaturesAutomaticScan_A7528);
			trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerFeaturesMessageEnable_A8499);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkPerFeaturesSecureProperCodeDetect_A8763);
			trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerFeaturesSecureProperCodeDetect_A8763);
			trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerFeaturesScanListSelection_A9053);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.trkPerFeaturesStatusEnable_A9188);
			this.RefRadioWide.Labtool.RadioWideDVRSTrunkingStatusCapability_A42772.AddDependentObject(this.trkPerFeaturesStatusEnable_A9188);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkPerIgnoreRxClearVoice_A41610);
			trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerFeatureBackupPTTOperation_A43628);
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide = global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			this.trkPerFeaturesHazardZoneModePersonality.AddDependentObject(radioErgonomicsWide.HomeMode.HomeModeChannel);
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x0600180D RID: 6157 RVA: 0x00191870 File Offset: 0x0018FA70
		public global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList ScanListForTrkPerFeaturesScanListSelection_A9053
		{
			get
			{
				short num = (short)1717010995;
				short num2 = num;
				num = (short)976192051;
				switch (num2 == num)
				{
				}
				num = (short)2115174401;
				if (num != 0)
				{
				}
				num = (short)1877803008;
				if (num != 0)
				{
				}
				num = (short)409403392;
				short num3 = num;
				return this.trkPerFeaturesScanListSelection_A9053.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList;
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x0600180E RID: 6158 RVA: 0x00191928 File Offset: 0x0018FB28
		public bool HasDiffs
		{
			get
			{
				short num = (short)848462236;
				short num2 = num;
				num = (short)2118353308;
				switch (num2 == num)
				{
				}
				num = (short)533921793;
				if (num != 0)
				{
				}
				num = (short)236257280;
				if (num != 0)
				{
				}
				num = (short)1779695616;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x0600180F RID: 6159 RVA: 0x001919D8 File Offset: 0x0018FBD8
		// (set) Token: 0x06001810 RID: 6160 RVA: 0x00191A90 File Offset: 0x0018FC90
		public bool TrkPerFeaturesAutomaticScan_A7528Value
		{
			get
			{
				short num = (short)502423303;
				short num2 = num;
				num = (short)2110283527;
				switch (num2 == num)
				{
				}
				num = (short)1086849024;
				if (num != 0)
				{
				}
				num = (short)310116353;
				if (num != 0)
				{
				}
				num = (short)2029977600;
				short num3 = num;
				return this.trkPerFeaturesAutomaticScan_A7528.Value;
			}
			set
			{
				short num = (short)1637169052;
				short num2 = num;
				num = (short)2145925020;
				switch (num2 == num)
				{
				}
				num = (short)1673265153;
				if (num != 0)
				{
				}
				num = (short)959512576;
				if (num != 0)
				{
				}
				num = (short)1894645760;
				short num3 = num;
				this.trkPerFeaturesAutomaticScan_A7528.Value = value;
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x06001811 RID: 6161 RVA: 0x00191B48 File Offset: 0x0018FD48
		public global::AcpBusinessLayer.AcpField<bool> TrkPerFeaturesAutomaticScan_A7528
		{
			get
			{
				short num = (short)1319370753;
				if (num != 0)
				{
				}
				num = (short)310578492;
				short num2 = num;
				num = (short)497290556;
				switch (num2 == num)
				{
				}
				num = (short)1036845056;
				if (num != 0)
				{
				}
				num = (short)212402176;
				short num3 = num;
				return this.trkPerFeaturesAutomaticScan_A7528;
			}
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x06001812 RID: 6162 RVA: 0x00191BFC File Offset: 0x0018FDFC
		// (set) Token: 0x06001813 RID: 6163 RVA: 0x00191CB0 File Offset: 0x0018FEB0
		public bool TrkPerFeaturesAutomaticScan_A7528_UIValue
		{
			get
			{
				short num = (short)1120973161;
				short num2 = num;
				num = (short)301445481;
				switch (num2 == num)
				{
				}
				num = (short)2134769664;
				if (num != 0)
				{
				}
				num = (short)1067974657;
				if (num != 0)
				{
				}
				num = (short)1476132864;
				short num3 = num;
				return this.trkPerFeaturesAutomaticScan_A7528.Value;
			}
			set
			{
				short num = (short)1175351227;
				short num2 = num;
				num = (short)1826254779;
				switch (num2 == num)
				{
				}
				num = (short)33488897;
				if (num != 0)
				{
				}
				num = (short)1610219520;
				if (num != 0)
				{
				}
				num = (short)1292042240;
				short num3 = num;
				this.trkPerFeaturesAutomaticScan_A7528.Value = value;
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x06001814 RID: 6164 RVA: 0x00191D64 File Offset: 0x0018FF64
		// (set) Token: 0x06001815 RID: 6165 RVA: 0x00191E1C File Offset: 0x0019001C
		public bool TrkPerFeaturesAutomaticScan_A7528_Applicable
		{
			get
			{
				short num = (short)1236314212;
				short num2 = num;
				num = (short)1723508836;
				switch (num2 == num)
				{
				}
				num = (short)528285697;
				if (num != 0)
				{
				}
				num = (short)981598208;
				if (num != 0)
				{
				}
				num = (short)944111616;
				short num3 = num;
				return this.trkPerFeaturesAutomaticScan_A7528.Applicable;
			}
			set
			{
				short num = (short)1096434215;
				short num2 = num;
				num = (short)1994998311;
				switch (num2 == num)
				{
				}
				num = (short)812384257;
				if (num != 0)
				{
				}
				num = (short)1252524032;
				if (num != 0)
				{
				}
				num = (short)1114177536;
				short num3 = num;
				this.trkPerFeaturesAutomaticScan_A7528.Applicable = value;
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x06001816 RID: 6166 RVA: 0x00191ED0 File Offset: 0x001900D0
		// (set) Token: 0x06001817 RID: 6167 RVA: 0x00191F84 File Offset: 0x00190184
		public bool TrkPerFeaturesAutomaticScan_A7528_Valid
		{
			get
			{
				short num = (short)1136787457;
				if (num != 0)
				{
				}
				num = (short)580731145;
				short num2 = num;
				num = (short)80691465;
				switch (num2 == num)
				{
				}
				num = (short)1956970496;
				if (num != 0)
				{
				}
				num = (short)807862272;
				short num3 = num;
				return this.trkPerFeaturesAutomaticScan_A7528.Valid;
			}
			set
			{
				short num = (short)485359617;
				if (num != 0)
				{
				}
				num = (short)1267448545;
				short num2 = num;
				num = (short)1328593633;
				switch (num2 == num)
				{
				}
				num = (short)2071789568;
				if (num != 0)
				{
				}
				num = (short)1867907072;
				short num3 = num;
				this.trkPerFeaturesAutomaticScan_A7528.Valid = value;
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x06001818 RID: 6168 RVA: 0x00192038 File Offset: 0x00190238
		// (set) Token: 0x06001819 RID: 6169 RVA: 0x001920EC File Offset: 0x001902EC
		public bool TrkPerFeaturesAutomaticScan_A7528_Visible
		{
			get
			{
				short num = (short)2138144855;
				short num2 = num;
				num = (short)409501783;
				switch (num2 == num)
				{
				}
				num = (short)857866240;
				if (num != 0)
				{
				}
				num = (short)291307521;
				if (num != 0)
				{
				}
				num = (short)1395195904;
				short num3 = num;
				return this.trkPerFeaturesAutomaticScan_A7528.Visible;
			}
			set
			{
				short num = (short)394842089;
				short num2 = num;
				num = (short)1027854313;
				switch (num2 == num)
				{
				}
				num = (short)1954807808;
				if (num != 0)
				{
				}
				num = (short)1012858881;
				if (num != 0)
				{
				}
				num = (short)158597120;
				short num3 = num;
				this.trkPerFeaturesAutomaticScan_A7528.Visible = value;
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x001921A0 File Offset: 0x001903A0
		// (set) Token: 0x0600181B RID: 6171 RVA: 0x00192254 File Offset: 0x00190454
		public bool TrkPerFeaturesAutomaticScan_A7528_Editable
		{
			get
			{
				short num = (short)2008621234;
				short num2 = num;
				num = (short)1870012594;
				switch (num2 == num)
				{
				}
				num = (short)1671299073;
				if (num != 0)
				{
				}
				num = (short)306118656;
				if (num != 0)
				{
				}
				num = (short)390987776;
				short num3 = num;
				return this.trkPerFeaturesAutomaticScan_A7528.Editable;
			}
			set
			{
				short num = (short)333245009;
				short num2 = num;
				num = (short)1684269649;
				switch (num2 == num)
				{
				}
				num = (short)1364328448;
				if (num != 0)
				{
				}
				num = (short)352124929;
				if (num != 0)
				{
				}
				num = (short)895287296;
				short num3 = num;
				this.trkPerFeaturesAutomaticScan_A7528.Editable = value;
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x0600181C RID: 6172 RVA: 0x00192308 File Offset: 0x00190508
		internal string TrkPerFeaturesAutomaticScan_A7528_UILabel
		{
			get
			{
				short num = (short)868936173;
				short num2 = num;
				num = (short)1577118189;
				switch (num2 == num)
				{
				}
				num = (short)1487929344;
				if (num != 0)
				{
				}
				num = (short)734527489;
				if (num != 0)
				{
				}
				num = (short)143196160;
				short num3 = num;
				return this.trkPerFeaturesAutomaticScan_A7528.UIName;
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x0600181D RID: 6173 RVA: 0x001923BC File Offset: 0x001905BC
		// (set) Token: 0x0600181E RID: 6174 RVA: 0x0019246C File Offset: 0x0019066C
		internal bool TrkPerFeaturesAutomaticScan_A7528_HiddenStatic
		{
			get
			{
				short num = (short)1853223026;
				short num2 = num;
				num = (short)1610674290;
				switch (num2 == num)
				{
				}
				num = (short)647888897;
				if (num != 0)
				{
				}
				num = (short)1812201472;
				if (num != 0)
				{
				}
				num = (short)772014080;
				short num3 = num;
				return this.trkPerFeaturesAutomaticScan_A7528.HiddenStatic;
			}
			set
			{
				short num = (short)1873828734;
				short num2 = num;
				num = (short)1526291326;
				switch (num2 == num)
				{
				}
				num = (short)1902772225;
				if (num != 0)
				{
				}
				num = (short)2097610752;
				if (num != 0)
				{
				}
				num = (short)284884992;
				short num3 = num;
				this.trkPerFeaturesAutomaticScan_A7528.HiddenStatic = value;
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x00192520 File Offset: 0x00190720
		// (set) Token: 0x06001820 RID: 6176 RVA: 0x001925D4 File Offset: 0x001907D4
		internal bool TrkPerFeaturesAutomaticScan_A7528_HiddenDynamic
		{
			get
			{
				short num = (short)1760838286;
				short num2 = num;
				num = (short)1846887054;
				switch (num2 == num)
				{
				}
				num = (short)209846272;
				if (num != 0)
				{
				}
				num = (short)203948033;
				if (num != 0)
				{
				}
				num = (short)742326272;
				short num3 = num;
				return this.trkPerFeaturesAutomaticScan_A7528.HiddenDynamic;
			}
			set
			{
				short num = (short)827959468;
				short num2 = num;
				num = (short)1614981292;
				switch (num2 == num)
				{
				}
				num = (short)1188233216;
				if (num != 0)
				{
				}
				num = (short)980025345;
				if (num != 0)
				{
				}
				num = (short)1419051008;
				short num3 = num;
				this.trkPerFeaturesAutomaticScan_A7528.HiddenDynamic = value;
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x06001821 RID: 6177 RVA: 0x00192688 File Offset: 0x00190888
		public bool TrkPerFeaturesAutomaticScan_A7528_HasDiffs
		{
			get
			{
				short num = (short)845313096;
				short num2 = num;
				num = (short)155743304;
				switch (num2 == num)
				{
				}
				num = (short)1175257089;
				if (num != 0)
				{
				}
				num = (short)981860352;
				if (num != 0)
				{
				}
				num = (short)1510801408;
				short num3 = num;
				return this.trkPerFeaturesAutomaticScan_A7528._HasDiffs;
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06001822 RID: 6178 RVA: 0x0019273C File Offset: 0x0019093C
		// (set) Token: 0x06001823 RID: 6179 RVA: 0x001927F0 File Offset: 0x001909F0
		public bool TrkPerFeaturesHotKeypadDTMF_A8209Value
		{
			get
			{
				short num = (short)1247962683;
				short num2 = num;
				num = (short)389441083;
				switch (num2 == num)
				{
				}
				num = (short)738394113;
				if (num != 0)
				{
				}
				num = (short)359989248;
				if (num != 0)
				{
				}
				num = (short)2100035584;
				short num3 = num;
				return this.trkPerFeaturesHotKeypadDTMF_A8209.Value;
			}
			set
			{
				short num = (short)1607875286;
				short num2 = num;
				num = (short)1912879830;
				switch (num2 == num)
				{
				}
				num = (short)1624637440;
				if (num != 0)
				{
				}
				num = (short)381747201;
				if (num != 0)
				{
				}
				num = (short)1571160064;
				short num3 = num;
				this.trkPerFeaturesHotKeypadDTMF_A8209.Value = value;
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06001824 RID: 6180 RVA: 0x001928A8 File Offset: 0x00190AA8
		public global::AcpBusinessLayer.AcpField<bool> TrkPerFeaturesHotKeypadDTMF_A8209
		{
			get
			{
				short num = (short)1870682342;
				short num2 = num;
				num = (short)537417958;
				switch (num2 == num)
				{
				}
				num = (short)196673537;
				if (num != 0)
				{
				}
				num = (short)459341824;
				if (num != 0)
				{
				}
				num = (short)1064370176;
				short num3 = num;
				return this.trkPerFeaturesHotKeypadDTMF_A8209;
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06001825 RID: 6181 RVA: 0x00192958 File Offset: 0x00190B58
		// (set) Token: 0x06001826 RID: 6182 RVA: 0x00192A0C File Offset: 0x00190C0C
		public bool TrkPerFeaturesHotKeypadDTMF_A8209_UIValue
		{
			get
			{
				short num = (short)322526753;
				short num2 = num;
				num = (short)1667522081;
				switch (num2 == num)
				{
				}
				num = (short)1248264193;
				if (num != 0)
				{
				}
				num = (short)1702756352;
				if (num != 0)
				{
				}
				num = (short)835911680;
				short num3 = num;
				return this.trkPerFeaturesHotKeypadDTMF_A8209.Value;
			}
			set
			{
				short num = (short)359975173;
				short num2 = num;
				num = (short)159172869;
				switch (num2 == num)
				{
				}
				num = (short)661585921;
				if (num != 0)
				{
				}
				num = (short)1099497472;
				if (num != 0)
				{
				}
				num = (short)1185480704;
				short num3 = num;
				this.trkPerFeaturesHotKeypadDTMF_A8209.Value = value;
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06001827 RID: 6183 RVA: 0x00192AC0 File Offset: 0x00190CC0
		// (set) Token: 0x06001828 RID: 6184 RVA: 0x00192B70 File Offset: 0x00190D70
		public bool TrkPerFeaturesHotKeypadDTMF_A8209_Applicable
		{
			get
			{
				short num = (short)590009283;
				short num2 = num;
				num = (short)1738200003;
				switch (num2 == num)
				{
				}
				num = (short)485097473;
				if (num != 0)
				{
				}
				num = (short)36503552;
				if (num != 0)
				{
				}
				num = (short)1594949632;
				short num3 = num;
				return this.trkPerFeaturesHotKeypadDTMF_A8209.Applicable;
			}
			set
			{
				short num = (short)1605376093;
				short num2 = num;
				num = (short)1658787933;
				switch (num2 == num)
				{
				}
				num = (short)599654401;
				if (num != 0)
				{
				}
				num = (short)1060896768;
				if (num != 0)
				{
				}
				num = (short)1890713600;
				short num3 = num;
				this.trkPerFeaturesHotKeypadDTMF_A8209.Applicable = value;
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06001829 RID: 6185 RVA: 0x00192C24 File Offset: 0x00190E24
		// (set) Token: 0x0600182A RID: 6186 RVA: 0x00192CD8 File Offset: 0x00190ED8
		public bool TrkPerFeaturesHotKeypadDTMF_A8209_Valid
		{
			get
			{
				short num = (short)122582981;
				short num2 = num;
				num = (short)778729413;
				switch (num2 == num)
				{
				}
				num = (short)1615790081;
				if (num != 0)
				{
				}
				num = (short)1199767552;
				if (num != 0)
				{
				}
				num = (short)1019609088;
				short num3 = num;
				return this.trkPerFeaturesHotKeypadDTMF_A8209.Valid;
			}
			set
			{
				short num = (short)411893761;
				if (num != 0)
				{
				}
				num = (short)179709185;
				short num2 = num;
				num = (short)1162290433;
				switch (num2 == num)
				{
				}
				num = (short)304742400;
				if (num != 0)
				{
				}
				num = (short)425525248;
				short num3 = num;
				this.trkPerFeaturesHotKeypadDTMF_A8209.Valid = value;
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x0600182B RID: 6187 RVA: 0x00192D8C File Offset: 0x00190F8C
		// (set) Token: 0x0600182C RID: 6188 RVA: 0x00192E44 File Offset: 0x00191044
		public bool TrkPerFeaturesHotKeypadDTMF_A8209_Visible
		{
			get
			{
				short num = (short)1561980512;
				short num2 = num;
				num = (short)1694953056;
				switch (num2 == num)
				{
				}
				num = (short)154075137;
				if (num != 0)
				{
				}
				num = (short)717225984;
				if (num != 0)
				{
				}
				num = (short)1918631936;
				short num3 = num;
				return this.trkPerFeaturesHotKeypadDTMF_A8209.Visible;
			}
			set
			{
				short num = (short)1006290985;
				short num2 = num;
				num = (short)2019608617;
				switch (num2 == num)
				{
				}
				num = (short)2090991617;
				if (num != 0)
				{
				}
				num = (short)1240072192;
				if (num != 0)
				{
				}
				num = (short)540147712;
				short num3 = num;
				this.trkPerFeaturesHotKeypadDTMF_A8209.Visible = value;
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x00192EF8 File Offset: 0x001910F8
		// (set) Token: 0x0600182E RID: 6190 RVA: 0x00192FAC File Offset: 0x001911AC
		public bool TrkPerFeaturesHotKeypadDTMF_A8209_Editable
		{
			get
			{
				short num = (short)1138760064;
				short num2 = num;
				num = (short)578492800;
				switch (num2 == num)
				{
				}
				num = (short)1306591232;
				if (num != 0)
				{
				}
				num = (short)308609025;
				if (num != 0)
				{
				}
				num = (short)1768095744;
				short num3 = num;
				return this.trkPerFeaturesHotKeypadDTMF_A8209.Editable;
			}
			set
			{
				short num = (short)1504171855;
				short num2 = num;
				num = (short)1445189455;
				switch (num2 == num)
				{
				}
				num = (short)1915551744;
				if (num != 0)
				{
				}
				num = (short)1428357121;
				if (num != 0)
				{
				}
				num = (short)973078528;
				short num3 = num;
				this.trkPerFeaturesHotKeypadDTMF_A8209.Editable = value;
			}
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x0600182F RID: 6191 RVA: 0x00193060 File Offset: 0x00191260
		internal string TrkPerFeaturesHotKeypadDTMF_A8209_UILabel
		{
			get
			{
				short num = (short)1234960385;
				if (num != 0)
				{
				}
				num = (short)350781811;
				short num2 = num;
				num = (short)2077589875;
				switch (num2 == num)
				{
				}
				num = (short)799145984;
				if (num != 0)
				{
				}
				num = (short)828506112;
				short num3 = num;
				return this.trkPerFeaturesHotKeypadDTMF_A8209.UIName;
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06001830 RID: 6192 RVA: 0x00193114 File Offset: 0x00191314
		// (set) Token: 0x06001831 RID: 6193 RVA: 0x001931CC File Offset: 0x001913CC
		internal bool TrkPerFeaturesHotKeypadDTMF_A8209_HiddenStatic
		{
			get
			{
				short num = (short)1866012456;
				short num2 = num;
				num = (short)1573197608;
				switch (num2 == num)
				{
				}
				num = (short)93126657;
				if (num != 0)
				{
				}
				num = (short)1496645632;
				if (num != 0)
				{
				}
				num = (short)48693248;
				short num3 = num;
				return this.trkPerFeaturesHotKeypadDTMF_A8209.HiddenStatic;
			}
			set
			{
				short num = (short)755535621;
				short num2 = num;
				num = (short)1346670341;
				switch (num2 == num)
				{
				}
				num = (short)510132225;
				if (num != 0)
				{
				}
				num = (short)1982136320;
				if (num != 0)
				{
				}
				num = (short)1823277056;
				short num3 = num;
				this.trkPerFeaturesHotKeypadDTMF_A8209.HiddenStatic = value;
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06001832 RID: 6194 RVA: 0x00193284 File Offset: 0x00191484
		// (set) Token: 0x06001833 RID: 6195 RVA: 0x00193338 File Offset: 0x00191538
		internal bool TrkPerFeaturesHotKeypadDTMF_A8209_HiddenDynamic
		{
			get
			{
				short num = (short)1320778352;
				short num2 = num;
				num = (short)2032564848;
				switch (num2 == num)
				{
				}
				num = (short)1593769984;
				if (num != 0)
				{
				}
				num = (short)458162177;
				if (num != 0)
				{
				}
				num = (short)320667648;
				short num3 = num;
				return this.trkPerFeaturesHotKeypadDTMF_A8209.HiddenDynamic;
			}
			set
			{
				short num = (short)446940223;
				short num2 = num;
				num = (short)297845823;
				switch (num2 == num)
				{
				}
				num = (short)299040769;
				if (num != 0)
				{
				}
				num = (short)1631780864;
				if (num != 0)
				{
				}
				num = (short)1588002816;
				short num3 = num;
				this.trkPerFeaturesHotKeypadDTMF_A8209.HiddenDynamic = value;
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06001834 RID: 6196 RVA: 0x001933EC File Offset: 0x001915EC
		public bool TrkPerFeaturesHotKeypadDTMF_A8209_HasDiffs
		{
			get
			{
				short num = (short)1408842498;
				short num2 = num;
				num = (short)664025858;
				switch (num2 == num)
				{
				}
				num = (short)2070216705;
				if (num != 0)
				{
				}
				num = (short)486866944;
				if (num != 0)
				{
				}
				num = (short)42008576;
				short num3 = num;
				return this.trkPerFeaturesHotKeypadDTMF_A8209._HasDiffs;
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x001934A0 File Offset: 0x001916A0
		// (set) Token: 0x06001836 RID: 6198 RVA: 0x00193554 File Offset: 0x00191754
		public bool TrkPerFeaturesMessageEnable_A8499Value
		{
			get
			{
				short num = (short)542603121;
				short num2 = num;
				num = (short)556234609;
				switch (num2 == num)
				{
				}
				num = (short)1006239744;
				if (num != 0)
				{
				}
				num = (short)1664417793;
				if (num != 0)
				{
				}
				num = (short)1352531968;
				short num3 = num;
				return this.trkPerFeaturesMessageEnable_A8499.Value;
			}
			set
			{
				short num = (short)1223901757;
				short num2 = num;
				num = (short)257704509;
				switch (num2 == num)
				{
				}
				num = (short)854786048;
				if (num != 0)
				{
				}
				num = (short)266141697;
				if (num != 0)
				{
				}
				num = (short)2065039360;
				short num3 = num;
				this.trkPerFeaturesMessageEnable_A8499.Value = value;
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x0019360C File Offset: 0x0019180C
		public global::AcpBusinessLayer.AcpField<bool> TrkPerFeaturesMessageEnable_A8499
		{
			get
			{
				short num = (short)1509781787;
				short num2 = num;
				num = (short)1014395163;
				switch (num2 == num)
				{
				}
				num = (short)1248985089;
				if (num != 0)
				{
				}
				num = (short)1320222720;
				if (num != 0)
				{
				}
				num = (short)1211760640;
				short num3 = num;
				return this.trkPerFeaturesMessageEnable_A8499;
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x06001838 RID: 6200 RVA: 0x001936BC File Offset: 0x001918BC
		// (set) Token: 0x06001839 RID: 6201 RVA: 0x00193770 File Offset: 0x00191970
		public bool TrkPerFeaturesMessageEnable_A8499_UIValue
		{
			get
			{
				short num = (short)403401622;
				short num2 = num;
				num = (short)438397846;
				switch (num2 == num)
				{
				}
				num = (short)1307705344;
				if (num != 0)
				{
				}
				num = (short)2116354049;
				if (num != 0)
				{
				}
				num = (short)1775370240;
				short num3 = num;
				return this.trkPerFeaturesMessageEnable_A8499.Value;
			}
			set
			{
				short num = (short)986298429;
				short num2 = num;
				num = (short)439072829;
				switch (num2 == num)
				{
				}
				num = (short)1519845377;
				if (num != 0)
				{
				}
				num = (short)2061303808;
				if (num != 0)
				{
				}
				num = (short)1976238080;
				short num3 = num;
				this.trkPerFeaturesMessageEnable_A8499.Value = value;
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x0600183A RID: 6202 RVA: 0x00193824 File Offset: 0x00191A24
		// (set) Token: 0x0600183B RID: 6203 RVA: 0x001938D8 File Offset: 0x00191AD8
		public bool TrkPerFeaturesMessageEnable_A8499_Applicable
		{
			get
			{
				short num = (short)1394028227;
				short num2 = num;
				num = (short)1230712515;
				switch (num2 == num)
				{
				}
				num = (short)1139736576;
				if (num != 0)
				{
				}
				num = (short)1149435905;
				if (num != 0)
				{
				}
				num = (short)880214016;
				short num3 = num;
				return this.trkPerFeaturesMessageEnable_A8499.Applicable;
			}
			set
			{
				short num = (short)1729279903;
				short num2 = num;
				num = (short)1677965215;
				switch (num2 == num)
				{
				}
				num = (short)180420609;
				if (num != 0)
				{
				}
				num = (short)405471232;
				if (num != 0)
				{
				}
				num = (short)222429184;
				short num3 = num;
				this.trkPerFeaturesMessageEnable_A8499.Applicable = value;
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x0600183C RID: 6204 RVA: 0x0019398C File Offset: 0x00191B8C
		// (set) Token: 0x0600183D RID: 6205 RVA: 0x00193A40 File Offset: 0x00191C40
		public bool TrkPerFeaturesMessageEnable_A8499_Valid
		{
			get
			{
				short num = (short)1335391360;
				short num2 = num;
				num = (short)1297642624;
				switch (num2 == num)
				{
				}
				num = (short)716111872;
				if (num != 0)
				{
				}
				num = (short)769392641;
				if (num != 0)
				{
				}
				num = (short)1105526784;
				short num3 = num;
				return this.trkPerFeaturesMessageEnable_A8499.Valid;
			}
			set
			{
				short num = (short)294745005;
				short num2 = num;
				num = (short)1755935661;
				switch (num2 == num)
				{
				}
				num = (short)1325793281;
				if (num != 0)
				{
				}
				num = (short)1702297600;
				if (num != 0)
				{
				}
				num = (short)1889599488;
				short num3 = num;
				this.trkPerFeaturesMessageEnable_A8499.Valid = value;
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x0600183E RID: 6206 RVA: 0x00193AF8 File Offset: 0x00191CF8
		// (set) Token: 0x0600183F RID: 6207 RVA: 0x00193BB0 File Offset: 0x00191DB0
		public bool TrkPerFeaturesMessageEnable_A8499_Visible
		{
			get
			{
				short num = (short)1848391840;
				short num2 = num;
				num = (short)1285044384;
				switch (num2 == num)
				{
				}
				num = (short)1729363968;
				if (num != 0)
				{
				}
				num = (short)1369964545;
				if (num != 0)
				{
				}
				num = (short)346292224;
				short num3 = num;
				return this.trkPerFeaturesMessageEnable_A8499.Visible;
			}
			set
			{
				short num = (short)1825013598;
				short num2 = num;
				num = (short)774864734;
				switch (num2 == num)
				{
				}
				num = (short)3604481;
				if (num != 0)
				{
				}
				num = (short)1682440192;
				if (num != 0)
				{
				}
				num = (short)425852928;
				short num3 = num;
				this.trkPerFeaturesMessageEnable_A8499.Visible = value;
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06001840 RID: 6208 RVA: 0x00193C64 File Offset: 0x00191E64
		// (set) Token: 0x06001841 RID: 6209 RVA: 0x00193D18 File Offset: 0x00191F18
		public bool TrkPerFeaturesMessageEnable_A8499_Editable
		{
			get
			{
				short num = (short)2132410369;
				if (num != 0)
				{
				}
				num = (short)911671501;
				short num2 = num;
				num = (short)721813709;
				switch (num2 == num)
				{
				}
				num = (short)1150550016;
				if (num != 0)
				{
				}
				num = (short)254148608;
				short num3 = num;
				return this.trkPerFeaturesMessageEnable_A8499.Editable;
			}
			set
			{
				short num = (short)576977964;
				short num2 = num;
				num = (short)62127148;
				switch (num2 == num)
				{
				}
				num = (short)547160064;
				if (num != 0)
				{
				}
				num = (short)785383425;
				if (num != 0)
				{
				}
				num = (short)1649934336;
				short num3 = num;
				this.trkPerFeaturesMessageEnable_A8499.Editable = value;
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06001842 RID: 6210 RVA: 0x00193DD0 File Offset: 0x00191FD0
		internal string TrkPerFeaturesMessageEnable_A8499_UILabel
		{
			get
			{
				short num = (short)612789317;
				short num2 = num;
				num = (short)666594373;
				switch (num2 == num)
				{
				}
				num = (short)1132199937;
				if (num != 0)
				{
				}
				num = (short)93913088;
				if (num != 0)
				{
				}
				num = (short)1408696320;
				short num3 = num;
				return this.trkPerFeaturesMessageEnable_A8499.UIName;
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x06001843 RID: 6211 RVA: 0x00193E88 File Offset: 0x00192088
		// (set) Token: 0x06001844 RID: 6212 RVA: 0x00193F40 File Offset: 0x00192140
		internal bool TrkPerFeaturesMessageEnable_A8499_HiddenStatic
		{
			get
			{
				short num = (short)185781263;
				short num2 = num;
				num = (short)1286065167;
				switch (num2 == num)
				{
				}
				num = (short)1934426113;
				if (num != 0)
				{
				}
				num = (short)620691456;
				if (num != 0)
				{
				}
				num = (short)1553924096;
				short num3 = num;
				return this.trkPerFeaturesMessageEnable_A8499.HiddenStatic;
			}
			set
			{
				short num = (short)228269047;
				short num2 = num;
				num = (short)1220615159;
				switch (num2 == num)
				{
				}
				num = (short)966328320;
				if (num != 0)
				{
				}
				num = (short)983564289;
				if (num != 0)
				{
				}
				num = (short)1126039552;
				short num3 = num;
				this.trkPerFeaturesMessageEnable_A8499.HiddenStatic = value;
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x06001845 RID: 6213 RVA: 0x00193FF4 File Offset: 0x001921F4
		// (set) Token: 0x06001846 RID: 6214 RVA: 0x001940A8 File Offset: 0x001922A8
		internal bool TrkPerFeaturesMessageEnable_A8499_HiddenDynamic
		{
			get
			{
				short num = (short)1429817029;
				short num2 = num;
				num = (short)420497093;
				switch (num2 == num)
				{
				}
				num = (short)1270874112;
				if (num != 0)
				{
				}
				num = (short)298319873;
				if (num != 0)
				{
				}
				num = (short)165019648;
				short num3 = num;
				return this.trkPerFeaturesMessageEnable_A8499.HiddenDynamic;
			}
			set
			{
				short num = (short)463210017;
				short num2 = num;
				num = (short)103613985;
				switch (num2 == num)
				{
				}
				num = (short)2106130433;
				if (num != 0)
				{
				}
				num = (short)1296302080;
				if (num != 0)
				{
				}
				num = (short)1384775680;
				short num3 = num;
				this.trkPerFeaturesMessageEnable_A8499.HiddenDynamic = value;
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x06001847 RID: 6215 RVA: 0x00194160 File Offset: 0x00192360
		public bool TrkPerFeaturesMessageEnable_A8499_HasDiffs
		{
			get
			{
				short num = (short)2055133563;
				short num2 = num;
				num = (short)105765243;
				switch (num2 == num)
				{
				}
				num = (short)604766208;
				if (num != 0)
				{
				}
				num = (short)2066743297;
				if (num != 0)
				{
				}
				num = (short)733675520;
				short num3 = num;
				return this.trkPerFeaturesMessageEnable_A8499._HasDiffs;
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06001848 RID: 6216 RVA: 0x00194214 File Offset: 0x00192414
		// (set) Token: 0x06001849 RID: 6217 RVA: 0x001942C8 File Offset: 0x001924C8
		public int TrkPerFeaturesPhoneOperation_A8701Value
		{
			get
			{
				short num = (short)93471799;
				short num2 = num;
				num = (short)1904165943;
				switch (num2 == num)
				{
				}
				num = (short)1990656001;
				if (num != 0)
				{
				}
				num = (short)1825964032;
				if (num != 0)
				{
				}
				num = (short)2101870592;
				short num3 = num;
				return this.trkPerFeaturesPhoneOperation_A8701.Value;
			}
			set
			{
				short num = (short)828104102;
				short num2 = num;
				num = (short)2004802982;
				switch (num2 == num)
				{
				}
				num = (short)1885470721;
				if (num != 0)
				{
				}
				num = (short)1983840256;
				if (num != 0)
				{
				}
				num = (short)1379532800;
				short num3 = num;
				this.trkPerFeaturesPhoneOperation_A8701.Value = value;
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x0600184A RID: 6218 RVA: 0x00194380 File Offset: 0x00192580
		// (set) Token: 0x0600184B RID: 6219 RVA: 0x00194434 File Offset: 0x00192634
		public string TrkPerFeaturesPhoneOperation_A8701_UIValue
		{
			get
			{
				short num = (short)142956382;
				short num2 = num;
				num = (short)708859742;
				switch (num2 == num)
				{
				}
				num = (short)1596325889;
				if (num != 0)
				{
				}
				num = (short)619184128;
				if (num != 0)
				{
				}
				num = (short)1616248832;
				short num3 = num;
				return this.trkPerFeaturesPhoneOperation_A8701.UIValue;
			}
			set
			{
				short num = (short)677392542;
				short num2 = num;
				num = (short)1177039006;
				switch (num2 == num)
				{
				}
				num = (short)1087897601;
				if (num != 0)
				{
				}
				num = (short)1470038016;
				if (num != 0)
				{
				}
				num = (short)1711669248;
				short num3 = num;
				this.trkPerFeaturesPhoneOperation_A8701.UIValue = value;
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x0600184C RID: 6220 RVA: 0x001944EC File Offset: 0x001926EC
		public global::AcpBusinessLayer.AcpListField TrkPerFeaturesPhoneOperation_A8701
		{
			get
			{
				short num = (short)943398181;
				short num2 = num;
				num = (short)73800997;
				switch (num2 == num)
				{
				}
				num = (short)2086993921;
				if (num != 0)
				{
				}
				num = (short)1252655104;
				if (num != 0)
				{
				}
				num = (short)55902208;
				short num3 = num;
				return this.trkPerFeaturesPhoneOperation_A8701;
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x00194598 File Offset: 0x00192798
		// (set) Token: 0x0600184E RID: 6222 RVA: 0x0019464C File Offset: 0x0019284C
		public bool TrkPerFeaturesPhoneOperation_A8701_Applicable
		{
			get
			{
				short num = (short)62018217;
				short num2 = num;
				num = (short)870666921;
				switch (num2 == num)
				{
				}
				num = (short)340656129;
				if (num != 0)
				{
				}
				num = (short)365887488;
				if (num != 0)
				{
				}
				num = (short)842137600;
				short num3 = num;
				return this.trkPerFeaturesPhoneOperation_A8701.Applicable;
			}
			set
			{
				short num = (short)227603128;
				short num2 = num;
				num = (short)1527837368;
				switch (num2 == num)
				{
				}
				num = (short)1810759681;
				if (num != 0)
				{
				}
				num = (short)2066939904;
				if (num != 0)
				{
				}
				num = (short)957284352;
				short num3 = num;
				this.trkPerFeaturesPhoneOperation_A8701.Applicable = value;
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x0600184F RID: 6223 RVA: 0x00194704 File Offset: 0x00192904
		// (set) Token: 0x06001850 RID: 6224 RVA: 0x001947B8 File Offset: 0x001929B8
		public bool TrkPerFeaturesPhoneOperation_A8701_Valid
		{
			get
			{
				short num = (short)1459775191;
				short num2 = num;
				num = (short)102065879;
				switch (num2 == num)
				{
				}
				num = (short)2041577472;
				if (num != 0)
				{
				}
				num = (short)1902247937;
				if (num != 0)
				{
				}
				num = (short)792788992;
				short num3 = num;
				return this.trkPerFeaturesPhoneOperation_A8701.Valid;
			}
			set
			{
				short num = (short)1195180033;
				if (num != 0)
				{
				}
				num = (short)783612058;
				short num2 = num;
				num = (short)1179449498;
				switch (num2 == num)
				{
				}
				num = (short)26279936;
				if (num != 0)
				{
				}
				num = (short)1039663104;
				short num3 = num;
				this.trkPerFeaturesPhoneOperation_A8701.Valid = value;
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06001851 RID: 6225 RVA: 0x00194870 File Offset: 0x00192A70
		// (set) Token: 0x06001852 RID: 6226 RVA: 0x00194924 File Offset: 0x00192B24
		public bool TrkPerFeaturesPhoneOperation_A8701_Visible
		{
			get
			{
				short num = (short)1468702527;
				short num2 = num;
				num = (short)1981325119;
				switch (num2 == num)
				{
				}
				num = (short)1097072641;
				if (num != 0)
				{
				}
				num = (short)1417805824;
				if (num != 0)
				{
				}
				num = (short)361168896;
				short num3 = num;
				return this.trkPerFeaturesPhoneOperation_A8701.Visible;
			}
			set
			{
				short num = (short)426693417;
				short num2 = num;
				num = (short)1108726569;
				switch (num2 == num)
				{
				}
				num = (short)1230438401;
				if (num != 0)
				{
				}
				num = (short)1506017280;
				if (num != 0)
				{
				}
				num = (short)68812800;
				short num3 = num;
				this.trkPerFeaturesPhoneOperation_A8701.Visible = value;
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06001853 RID: 6227 RVA: 0x001949D8 File Offset: 0x00192BD8
		// (set) Token: 0x06001854 RID: 6228 RVA: 0x00194A90 File Offset: 0x00192C90
		public bool TrkPerFeaturesPhoneOperation_A8701_Editable
		{
			get
			{
				short num = (short)455432935;
				short num2 = num;
				num = (short)1901222631;
				switch (num2 == num)
				{
				}
				num = (short)1040318465;
				if (num != 0)
				{
				}
				num = (short)1687158784;
				if (num != 0)
				{
				}
				num = (short)219742208;
				short num3 = num;
				return this.trkPerFeaturesPhoneOperation_A8701.Editable;
			}
			set
			{
				short num = (short)2130736642;
				short num2 = num;
				num = (short)1777694210;
				switch (num2 == num)
				{
				}
				num = (short)1440022529;
				if (num != 0)
				{
				}
				num = (short)498794496;
				if (num != 0)
				{
				}
				num = (short)1679818752;
				short num3 = num;
				this.trkPerFeaturesPhoneOperation_A8701.Editable = value;
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x00194B48 File Offset: 0x00192D48
		internal string TrkPerFeaturesPhoneOperation_A8701_UILabel
		{
			get
			{
				short num = (short)1073715006;
				short num2 = num;
				num = (short)688559934;
				switch (num2 == num)
				{
				}
				num = (short)1007353856;
				if (num != 0)
				{
				}
				num = (short)905117697;
				if (num != 0)
				{
				}
				num = (short)464453632;
				short num3 = num;
				return this.trkPerFeaturesPhoneOperation_A8701.UIName;
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06001856 RID: 6230 RVA: 0x00194BFC File Offset: 0x00192DFC
		// (set) Token: 0x06001857 RID: 6231 RVA: 0x00194CB0 File Offset: 0x00192EB0
		internal bool TrkPerFeaturesPhoneOperation_A8701_HiddenStatic
		{
			get
			{
				short num = (short)68421516;
				short num2 = num;
				num = (short)37226380;
				switch (num2 == num)
				{
				}
				num = (short)2009333761;
				if (num != 0)
				{
				}
				num = (short)1817378816;
				if (num != 0)
				{
				}
				num = (short)2133590016;
				short num3 = num;
				return this.trkPerFeaturesPhoneOperation_A8701.HiddenStatic;
			}
			set
			{
				short num = (short)1768226817;
				if (num != 0)
				{
				}
				num = (short)1382297915;
				short num2 = num;
				num = (short)130232635;
				switch (num2 == num)
				{
				}
				num = (short)1743847424;
				if (num != 0)
				{
				}
				num = (short)1613692928;
				short num3 = num;
				this.trkPerFeaturesPhoneOperation_A8701.HiddenStatic = value;
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06001858 RID: 6232 RVA: 0x00194D64 File Offset: 0x00192F64
		// (set) Token: 0x06001859 RID: 6233 RVA: 0x00194E1C File Offset: 0x0019301C
		internal bool TrkPerFeaturesPhoneOperation_A8701_HiddenDynamic
		{
			get
			{
				short num = (short)1465135626;
				short num2 = num;
				num = (short)1203122698;
				switch (num2 == num)
				{
				}
				num = (short)1724907521;
				if (num != 0)
				{
				}
				num = (short)2068643840;
				if (num != 0)
				{
				}
				num = (short)1419968512;
				short num3 = num;
				return this.trkPerFeaturesPhoneOperation_A8701.HiddenDynamic;
			}
			set
			{
				short num = (short)719058208;
				short num2 = num;
				num = (short)1694496032;
				switch (num2 == num)
				{
				}
				num = (short)772734977;
				if (num != 0)
				{
				}
				num = (short)1108410368;
				if (num != 0)
				{
				}
				num = (short)286261248;
				short num3 = num;
				this.trkPerFeaturesPhoneOperation_A8701.HiddenDynamic = value;
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x0600185A RID: 6234 RVA: 0x00194ED0 File Offset: 0x001930D0
		public bool TrkPerFeaturesPhoneOperation_A8701_HasDiffs
		{
			get
			{
				short num = (short)1410453312;
				short num2 = num;
				num = (short)644599616;
				switch (num2 == num)
				{
				}
				num = (short)798294016;
				if (num != 0)
				{
				}
				num = (short)1020264449;
				if (num != 0)
				{
				}
				num = (short)907411456;
				short num3 = num;
				return this.trkPerFeaturesPhoneOperation_A8701._HasDiffs;
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x0600185B RID: 6235 RVA: 0x00194F80 File Offset: 0x00193180
		// (set) Token: 0x0600185C RID: 6236 RVA: 0x00195034 File Offset: 0x00193234
		public bool TrkPerFeaturesSecureProperCodeDetect_A8763Value
		{
			get
			{
				short num = (short)714776745;
				short num2 = num;
				num = (short)519938217;
				switch (num2 == num)
				{
				}
				num = (short)1180106753;
				if (num != 0)
				{
				}
				num = (short)1721958400;
				if (num != 0)
				{
				}
				num = (short)876412928;
				short num3 = num;
				return this.trkPerFeaturesSecureProperCodeDetect_A8763.Value;
			}
			set
			{
				short num = (short)2102013789;
				short num2 = num;
				num = (short)1555967837;
				switch (num2 == num)
				{
				}
				num = (short)1870659584;
				if (num != 0)
				{
				}
				num = (short)1423245313;
				if (num != 0)
				{
				}
				num = (short)1356857344;
				short num3 = num;
				this.trkPerFeaturesSecureProperCodeDetect_A8763.Value = value;
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x0600185D RID: 6237 RVA: 0x001950EC File Offset: 0x001932EC
		public global::AcpBusinessLayer.AcpField<bool> TrkPerFeaturesSecureProperCodeDetect_A8763
		{
			get
			{
				short num = (short)1547501569;
				if (num != 0)
				{
				}
				num = (short)136647013;
				short num2 = num;
				num = (short)1449660773;
				switch (num2 == num)
				{
				}
				num = (short)477495296;
				if (num != 0)
				{
				}
				num = (short)2008743936;
				short num3 = num;
				return this.trkPerFeaturesSecureProperCodeDetect_A8763;
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x0600185E RID: 6238 RVA: 0x0019519C File Offset: 0x0019339C
		// (set) Token: 0x0600185F RID: 6239 RVA: 0x00195254 File Offset: 0x00193454
		public bool TrkPerFeaturesSecureProperCodeDetect_A8763_UIValue
		{
			get
			{
				short num = (short)805199682;
				short num2 = num;
				num = (short)1450204994;
				switch (num2 == num)
				{
				}
				num = (short)506068992;
				if (num != 0)
				{
				}
				num = (short)1341521921;
				if (num != 0)
				{
				}
				num = (short)1189937152;
				short num3 = num;
				return this.trkPerFeaturesSecureProperCodeDetect_A8763.Value;
			}
			set
			{
				short num = (short)812688559;
				short num2 = num;
				num = (short)959663;
				switch (num2 == num)
				{
				}
				num = (short)883163136;
				if (num != 0)
				{
				}
				num = (short)602996737;
				if (num != 0)
				{
				}
				num = (short)2134048768;
				short num3 = num;
				this.trkPerFeaturesSecureProperCodeDetect_A8763.Value = value;
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06001860 RID: 6240 RVA: 0x00195308 File Offset: 0x00193508
		// (set) Token: 0x06001861 RID: 6241 RVA: 0x001953C0 File Offset: 0x001935C0
		public bool TrkPerFeaturesSecureProperCodeDetect_A8763_Applicable
		{
			get
			{
				short num = (short)1980055333;
				short num2 = num;
				num = (short)1776762661;
				switch (num2 == num)
				{
				}
				num = (short)1742667777;
				if (num != 0)
				{
				}
				num = (short)335020032;
				if (num != 0)
				{
				}
				num = (short)507117568;
				short num3 = num;
				return this.trkPerFeaturesSecureProperCodeDetect_A8763.Applicable;
			}
			set
			{
				short num = (short)1937679779;
				short num2 = num;
				num = (short)409183651;
				switch (num2 == num)
				{
				}
				num = (short)622395393;
				if (num != 0)
				{
				}
				num = (short)1947729920;
				if (num != 0)
				{
				}
				num = (short)1674510336;
				short num3 = num;
				this.trkPerFeaturesSecureProperCodeDetect_A8763.Applicable = value;
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06001862 RID: 6242 RVA: 0x00195474 File Offset: 0x00193674
		// (set) Token: 0x06001863 RID: 6243 RVA: 0x00195528 File Offset: 0x00193728
		public bool TrkPerFeaturesSecureProperCodeDetect_A8763_Valid
		{
			get
			{
				short num = (short)357297555;
				short num2 = num;
				num = (short)441707923;
				switch (num2 == num)
				{
				}
				num = (short)2065956865;
				if (num != 0)
				{
				}
				num = (short)89653248;
				if (num != 0)
				{
				}
				num = (short)1258618880;
				short num3 = num;
				return this.trkPerFeaturesSecureProperCodeDetect_A8763.Valid;
			}
			set
			{
				short num = (short)1880017917;
				short num2 = num;
				num = (short)748080125;
				switch (num2 == num)
				{
				}
				num = (short)1122500609;
				if (num != 0)
				{
				}
				num = (short)1494417408;
				if (num != 0)
				{
				}
				num = (short)554500096;
				short num3 = num;
				this.trkPerFeaturesSecureProperCodeDetect_A8763.Valid = value;
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06001864 RID: 6244 RVA: 0x001955DC File Offset: 0x001937DC
		// (set) Token: 0x06001865 RID: 6245 RVA: 0x00195690 File Offset: 0x00193890
		public bool TrkPerFeaturesSecureProperCodeDetect_A8763_Visible
		{
			get
			{
				short num = (short)1929882938;
				short num2 = num;
				num = (short)2123607354;
				switch (num2 == num)
				{
				}
				num = (short)491585537;
				if (num != 0)
				{
				}
				num = (short)2017853440;
				if (num != 0)
				{
				}
				num = (short)953417728;
				short num3 = num;
				return this.trkPerFeaturesSecureProperCodeDetect_A8763.Visible;
			}
			set
			{
				short num = (short)682822464;
				short num2 = num;
				num = (short)1716652864;
				switch (num2 == num)
				{
				}
				num = (short)534315009;
				if (num != 0)
				{
				}
				num = (short)1657143296;
				if (num != 0)
				{
				}
				num = (short)2048655360;
				short num3 = num;
				this.trkPerFeaturesSecureProperCodeDetect_A8763.Visible = value;
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06001866 RID: 6246 RVA: 0x00195744 File Offset: 0x00193944
		// (set) Token: 0x06001867 RID: 6247 RVA: 0x001957F8 File Offset: 0x001939F8
		public bool TrkPerFeaturesSecureProperCodeDetect_A8763_Editable
		{
			get
			{
				short num = (short)1134191995;
				short num2 = num;
				num = (short)373319035;
				switch (num2 == num)
				{
				}
				num = (short)1522401281;
				if (num != 0)
				{
				}
				num = (short)191234048;
				if (num != 0)
				{
				}
				num = (short)1253769216;
				short num3 = num;
				return this.trkPerFeaturesSecureProperCodeDetect_A8763.Editable;
			}
			set
			{
				short num = (short)276156514;
				short num2 = num;
				num = (short)1872679010;
				switch (num2 == num)
				{
				}
				num = (short)1676214273;
				if (num != 0)
				{
				}
				num = (short)824311808;
				if (num != 0)
				{
				}
				num = (short)1506607104;
				short num3 = num;
				this.trkPerFeaturesSecureProperCodeDetect_A8763.Editable = value;
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06001868 RID: 6248 RVA: 0x001958B0 File Offset: 0x00193AB0
		internal string TrkPerFeaturesSecureProperCodeDetect_A8763_UILabel
		{
			get
			{
				short num = (short)1613203684;
				short num2 = num;
				num = (short)2015135972;
				switch (num2 == num)
				{
				}
				num = (short)1725038592;
				if (num != 0)
				{
				}
				num = (short)1726087169;
				if (num != 0)
				{
				}
				num = (short)1099825152;
				short num3 = num;
				return this.trkPerFeaturesSecureProperCodeDetect_A8763.UIName;
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06001869 RID: 6249 RVA: 0x00195968 File Offset: 0x00193B68
		// (set) Token: 0x0600186A RID: 6250 RVA: 0x00195A20 File Offset: 0x00193C20
		internal bool TrkPerFeaturesSecureProperCodeDetect_A8763_HiddenStatic
		{
			get
			{
				short num = (short)479895796;
				short num2 = num;
				num = (short)247242996;
				switch (num2 == num)
				{
				}
				num = (short)2077687809;
				if (num != 0)
				{
				}
				num = (short)585957376;
				if (num != 0)
				{
				}
				num = (short)157417472;
				short num3 = num;
				return this.trkPerFeaturesSecureProperCodeDetect_A8763.HiddenStatic;
			}
			set
			{
				short num = (short)44859400;
				short num2 = num;
				num = (short)254509064;
				switch (num2 == num)
				{
				}
				num = (short)1972961280;
				if (num != 0)
				{
				}
				num = (short)708706305;
				if (num != 0)
				{
				}
				num = (short)2135097344;
				short num3 = num;
				this.trkPerFeaturesSecureProperCodeDetect_A8763.HiddenStatic = value;
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x0600186B RID: 6251 RVA: 0x00195AD4 File Offset: 0x00193CD4
		// (set) Token: 0x0600186C RID: 6252 RVA: 0x00195B88 File Offset: 0x00193D88
		internal bool TrkPerFeaturesSecureProperCodeDetect_A8763_HiddenDynamic
		{
			get
			{
				short num = (short)1501650267;
				short num2 = num;
				num = (short)1833852251;
				switch (num2 == num)
				{
				}
				num = (short)306642944;
				if (num != 0)
				{
				}
				num = (short)1196883969;
				if (num != 0)
				{
				}
				num = (short)471728128;
				short num3 = num;
				return this.trkPerFeaturesSecureProperCodeDetect_A8763.HiddenDynamic;
			}
			set
			{
				short num = (short)672407570;
				short num2 = num;
				num = (short)937041938;
				switch (num2 == num)
				{
				}
				num = (short)1154088961;
				if (num != 0)
				{
				}
				num = (short)229048320;
				if (num != 0)
				{
				}
				num = (short)2117337088;
				short num3 = num;
				this.trkPerFeaturesSecureProperCodeDetect_A8763.HiddenDynamic = value;
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x0600186D RID: 6253 RVA: 0x00195C3C File Offset: 0x00193E3C
		public bool TrkPerFeaturesSecureProperCodeDetect_A8763_HasDiffs
		{
			get
			{
				short num = (short)555553183;
				short num2 = num;
				num = (short)2091848095;
				switch (num2 == num)
				{
				}
				num = (short)694091777;
				if (num != 0)
				{
				}
				num = (short)1459814400;
				if (num != 0)
				{
				}
				num = (short)1503068160;
				short num3 = num;
				return this.trkPerFeaturesSecureProperCodeDetect_A8763._HasDiffs;
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x00195CEC File Offset: 0x00193EEC
		// (set) Token: 0x0600186F RID: 6255 RVA: 0x00195DA0 File Offset: 0x00193FA0
		public int TrkPerFeaturesScanListSelection_A9053Value
		{
			get
			{
				short num = (short)1097159669;
				short num2 = num;
				num = (short)307647477;
				switch (num2 == num)
				{
				}
				num = (short)1546452992;
				if (num != 0)
				{
				}
				num = (short)636092417;
				if (num != 0)
				{
				}
				num = (short)842858496;
				short num3 = num;
				return this.trkPerFeaturesScanListSelection_A9053.Value;
			}
			set
			{
				short num = (short)1583618284;
				short num2 = num;
				num = (short)2101876972;
				switch (num2 == num)
				{
				}
				num = (short)935395329;
				if (num != 0)
				{
				}
				num = (short)2036531200;
				if (num != 0)
				{
				}
				num = (short)1453785088;
				short num3 = num;
				this.trkPerFeaturesScanListSelection_A9053.Value = value;
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x00195E54 File Offset: 0x00194054
		// (set) Token: 0x06001871 RID: 6257 RVA: 0x00195F08 File Offset: 0x00194108
		public string TrkPerFeaturesScanListSelection_A9053_UIValue
		{
			get
			{
				short num = (short)1869414401;
				if (num != 0)
				{
				}
				num = (short)1532085637;
				short num2 = num;
				num = (short)2050606469;
				switch (num2 == num)
				{
				}
				num = (short)494796800;
				if (num != 0)
				{
				}
				num = (short)130220032;
				short num3 = num;
				return this.trkPerFeaturesScanListSelection_A9053.UIValue;
			}
			set
			{
				short num = (short)328255468;
				short num2 = num;
				num = (short)503564268;
				switch (num2 == num)
				{
				}
				num = (short)1008467968;
				if (num != 0)
				{
				}
				num = (short)1450442753;
				if (num != 0)
				{
				}
				num = (short)942211072;
				short num3 = num;
				this.trkPerFeaturesScanListSelection_A9053.UIValue = value;
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06001872 RID: 6258 RVA: 0x00195FC0 File Offset: 0x001941C0
		public global::AcpBusinessLayer.AcpRecRefField TrkPerFeaturesScanListSelection_A9053
		{
			get
			{
				short num = (short)1216003844;
				short num2 = num;
				num = (short)1119796996;
				switch (num2 == num)
				{
				}
				num = (short)1088159745;
				if (num != 0)
				{
				}
				num = (short)997064704;
				if (num != 0)
				{
				}
				num = (short)1602748416;
				short num3 = num;
				return this.trkPerFeaturesScanListSelection_A9053;
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x00196070 File Offset: 0x00194270
		// (set) Token: 0x06001874 RID: 6260 RVA: 0x00196124 File Offset: 0x00194324
		public bool TrkPerFeaturesScanListSelection_A9053_Applicable
		{
			get
			{
				short num = (short)351262017;
				short num2 = num;
				num = (short)1805505857;
				switch (num2 == num)
				{
				}
				num = (short)2145583105;
				if (num != 0)
				{
				}
				num = (short)1738080256;
				if (num != 0)
				{
				}
				num = (short)611647488;
				short num3 = num;
				return this.trkPerFeaturesScanListSelection_A9053.Applicable;
			}
			set
			{
				short num = (short)632750081;
				if (num != 0)
				{
				}
				num = (short)645963908;
				short num2 = num;
				num = (short)145531012;
				switch (num2 == num)
				{
				}
				num = (short)137756672;
				if (num != 0)
				{
				}
				num = (short)1984036864;
				short num3 = num;
				this.trkPerFeaturesScanListSelection_A9053.Applicable = value;
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06001875 RID: 6261 RVA: 0x001961D8 File Offset: 0x001943D8
		// (set) Token: 0x06001876 RID: 6262 RVA: 0x0019628C File Offset: 0x0019448C
		public bool TrkPerFeaturesScanListSelection_A9053_Valid
		{
			get
			{
				short num = (short)996990392;
				short num2 = num;
				num = (short)1463213496;
				switch (num2 == num)
				{
				}
				num = (short)1250230273;
				if (num != 0)
				{
				}
				num = (short)269746176;
				if (num != 0)
				{
				}
				num = (short)928972800;
				short num3 = num;
				return this.trkPerFeaturesScanListSelection_A9053.Valid;
			}
			set
			{
				short num = (short)288950620;
				short num2 = num;
				num = (short)1632569692;
				switch (num2 == num)
				{
				}
				num = (short)414253057;
				if (num != 0)
				{
				}
				num = (short)541851648;
				if (num != 0)
				{
				}
				num = (short)89784320;
				short num3 = num;
				this.trkPerFeaturesScanListSelection_A9053.Valid = value;
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x06001877 RID: 6263 RVA: 0x00196340 File Offset: 0x00194540
		// (set) Token: 0x06001878 RID: 6264 RVA: 0x001963F4 File Offset: 0x001945F4
		public bool TrkPerFeaturesScanListSelection_A9053_Visible
		{
			get
			{
				short num = (short)381353985;
				if (num != 0)
				{
				}
				num = (short)1252157838;
				short num2 = num;
				num = (short)495610254;
				switch (num2 == num)
				{
				}
				num = (short)1483341824;
				if (num != 0)
				{
				}
				num = (short)1164640256;
				short num3 = num;
				return this.trkPerFeaturesScanListSelection_A9053.Visible;
			}
			set
			{
				short num = (short)909770753;
				if (num != 0)
				{
				}
				num = (short)337114272;
				short num2 = num;
				num = (short)584381600;
				switch (num2 == num)
				{
				}
				num = (short)801898496;
				if (num != 0)
				{
				}
				num = (short)2137194496;
				short num3 = num;
				this.trkPerFeaturesScanListSelection_A9053.Visible = value;
			}
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x06001879 RID: 6265 RVA: 0x001964AC File Offset: 0x001946AC
		// (set) Token: 0x0600187A RID: 6266 RVA: 0x00196564 File Offset: 0x00194764
		public bool TrkPerFeaturesScanListSelection_A9053_Editable
		{
			get
			{
				short num = (short)765344522;
				short num2 = num;
				num = (short)1530608394;
				switch (num2 == num)
				{
				}
				num = (short)1451098113;
				if (num != 0)
				{
				}
				num = (short)414908416;
				if (num != 0)
				{
				}
				num = (short)930873344;
				short num3 = num;
				return this.trkPerFeaturesScanListSelection_A9053.Editable;
			}
			set
			{
				short num = (short)101947908;
				short num2 = num;
				num = (short)499948036;
				switch (num2 == num)
				{
				}
				num = (short)609026048;
				if (num != 0)
				{
				}
				num = (short)1876426753;
				if (num != 0)
				{
				}
				num = (short)1858469888;
				short num3 = num;
				this.trkPerFeaturesScanListSelection_A9053.Editable = value;
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x0600187B RID: 6267 RVA: 0x00196618 File Offset: 0x00194818
		internal string TrkPerFeaturesScanListSelection_A9053_UILabel
		{
			get
			{
				short num = (short)1585718999;
				short num2 = num;
				num = (short)1516054231;
				switch (num2 == num)
				{
				}
				num = (short)1660157953;
				if (num != 0)
				{
				}
				num = (short)1622736896;
				if (num != 0)
				{
				}
				num = (short)102891520;
				short num3 = num;
				return this.trkPerFeaturesScanListSelection_A9053.UIName;
			}
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x0600187C RID: 6268 RVA: 0x001966CC File Offset: 0x001948CC
		// (set) Token: 0x0600187D RID: 6269 RVA: 0x00196780 File Offset: 0x00194980
		internal bool TrkPerFeaturesScanListSelection_A9053_HiddenStatic
		{
			get
			{
				short num = (short)178091908;
				short num2 = num;
				num = (short)665679748;
				switch (num2 == num)
				{
				}
				num = (short)130809856;
				if (num != 0)
				{
				}
				num = (short)688848897;
				if (num != 0)
				{
				}
				num = (short)1186004992;
				short num3 = num;
				return this.trkPerFeaturesScanListSelection_A9053.HiddenStatic;
			}
			set
			{
				short num = (short)539583864;
				short num2 = num;
				num = (short)283272568;
				switch (num2 == num)
				{
				}
				num = (short)1719664640;
				if (num != 0)
				{
				}
				num = (short)650772481;
				if (num != 0)
				{
				}
				num = (short)2039939072;
				short num3 = num;
				this.trkPerFeaturesScanListSelection_A9053.HiddenStatic = value;
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x00196834 File Offset: 0x00194A34
		// (set) Token: 0x0600187F RID: 6271 RVA: 0x001968E8 File Offset: 0x00194AE8
		internal bool TrkPerFeaturesScanListSelection_A9053_HiddenDynamic
		{
			get
			{
				short num = (short)1826947073;
				if (num != 0)
				{
				}
				num = (short)2115021341;
				short num2 = num;
				num = (short)1237363229;
				switch (num2 == num)
				{
				}
				num = (short)1636106240;
				if (num != 0)
				{
				}
				num = (short)1372323840;
				short num3 = num;
				return this.trkPerFeaturesScanListSelection_A9053.HiddenDynamic;
			}
			set
			{
				short num = (short)75313873;
				short num2 = num;
				num = (short)1078604497;
				switch (num2 == num)
				{
				}
				num = (short)1747714049;
				if (num != 0)
				{
				}
				num = (short)1024458752;
				if (num != 0)
				{
				}
				num = (short)19660800;
				short num3 = num;
				this.trkPerFeaturesScanListSelection_A9053.HiddenDynamic = value;
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06001880 RID: 6272 RVA: 0x0019699C File Offset: 0x00194B9C
		public bool TrkPerFeaturesScanListSelection_A9053_HasDiffs
		{
			get
			{
				short num = (short)767131236;
				short num2 = num;
				num = (short)17071716;
				switch (num2 == num)
				{
				}
				num = (short)1464664065;
				if (num != 0)
				{
				}
				num = (short)1559953408;
				if (num != 0)
				{
				}
				num = (short)192413696;
				short num3 = num;
				return this.trkPerFeaturesScanListSelection_A9053._HasDiffs;
			}
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x06001881 RID: 6273 RVA: 0x00196A50 File Offset: 0x00194C50
		// (set) Token: 0x06001882 RID: 6274 RVA: 0x00196B08 File Offset: 0x00194D08
		public bool TrkPerFeaturesStatusEnable_A9188Value
		{
			get
			{
				short num = (short)615166638;
				short num2 = num;
				num = (short)1305588398;
				switch (num2 == num)
				{
				}
				num = (short)1390542849;
				if (num != 0)
				{
				}
				num = (short)844169216;
				if (num != 0)
				{
				}
				num = (short)1833304064;
				short num3 = num;
				return this.trkPerFeaturesStatusEnable_A9188.Value;
			}
			set
			{
				short num = (short)370143609;
				short num2 = num;
				num = (short)2123755897;
				switch (num2 == num)
				{
				}
				num = (short)131858432;
				if (num != 0)
				{
				}
				num = (short)838467585;
				if (num != 0)
				{
				}
				num = (short)923009024;
				short num3 = num;
				this.trkPerFeaturesStatusEnable_A9188.Value = value;
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x06001883 RID: 6275 RVA: 0x00196BC0 File Offset: 0x00194DC0
		public global::AcpBusinessLayer.AcpField<bool> TrkPerFeaturesStatusEnable_A9188
		{
			get
			{
				short num = (short)417560450;
				short num2 = num;
				num = (short)692287362;
				switch (num2 == num)
				{
				}
				num = (short)1710686208;
				if (num != 0)
				{
				}
				num = (short)2033254401;
				if (num != 0)
				{
				}
				num = (short)1563754496;
				short num3 = num;
				return this.trkPerFeaturesStatusEnable_A9188;
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x00196C70 File Offset: 0x00194E70
		// (set) Token: 0x06001885 RID: 6277 RVA: 0x00196D28 File Offset: 0x00194F28
		public bool TrkPerFeaturesStatusEnable_A9188_UIValue
		{
			get
			{
				short num = (short)1456432406;
				short num2 = num;
				num = (short)63792406;
				switch (num2 == num)
				{
				}
				num = (short)390070273;
				if (num != 0)
				{
				}
				num = (short)440598528;
				if (num != 0)
				{
				}
				num = (short)1401094144;
				short num3 = num;
				return this.trkPerFeaturesStatusEnable_A9188.Value;
			}
			set
			{
				short num = (short)769599163;
				short num2 = num;
				num = (short)796075707;
				switch (num2 == num)
				{
				}
				num = (short)964034560;
				if (num != 0)
				{
				}
				num = (short)380698625;
				if (num != 0)
				{
				}
				num = (short)119078912;
				short num3 = num;
				this.trkPerFeaturesStatusEnable_A9188.Value = value;
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x06001886 RID: 6278 RVA: 0x00196DDC File Offset: 0x00194FDC
		// (set) Token: 0x06001887 RID: 6279 RVA: 0x00196E90 File Offset: 0x00195090
		public bool TrkPerFeaturesStatusEnable_A9188_Applicable
		{
			get
			{
				short num = (short)796309916;
				short num2 = num;
				num = (short)668187036;
				switch (num2 == num)
				{
				}
				num = (short)232521729;
				if (num != 0)
				{
				}
				num = (short)488833024;
				if (num != 0)
				{
				}
				num = (short)115081216;
				short num3 = num;
				return this.trkPerFeaturesStatusEnable_A9188.Applicable;
			}
			set
			{
				short num = (short)680979802;
				short num2 = num;
				num = (short)2007952730;
				switch (num2 == num)
				{
				}
				num = (short)1021902849;
				if (num != 0)
				{
				}
				num = (short)1658585088;
				if (num != 0)
				{
				}
				num = (short)143392768;
				short num3 = num;
				this.trkPerFeaturesStatusEnable_A9188.Applicable = value;
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x06001888 RID: 6280 RVA: 0x00196F44 File Offset: 0x00195144
		// (set) Token: 0x06001889 RID: 6281 RVA: 0x00196FFC File Offset: 0x001951FC
		public bool TrkPerFeaturesStatusEnable_A9188_Valid
		{
			get
			{
				short num = (short)229507073;
				if (num != 0)
				{
				}
				num = (short)1878276547;
				short num2 = num;
				num = (short)1290877379;
				switch (num2 == num)
				{
				}
				num = (short)1195245568;
				if (num != 0)
				{
				}
				num = (short)1391919104;
				short num3 = num;
				return this.trkPerFeaturesStatusEnable_A9188.Valid;
			}
			set
			{
				short num = (short)1771504326;
				short num2 = num;
				num = (short)341639878;
				switch (num2 == num)
				{
				}
				num = (short)1970274305;
				if (num != 0)
				{
				}
				num = (short)975568896;
				if (num != 0)
				{
				}
				num = (short)746782720;
				short num3 = num;
				this.trkPerFeaturesStatusEnable_A9188.Valid = value;
			}
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x001970B0 File Offset: 0x001952B0
		// (set) Token: 0x0600188B RID: 6283 RVA: 0x00197168 File Offset: 0x00195368
		public bool TrkPerFeaturesStatusEnable_A9188_Visible
		{
			get
			{
				short num = (short)329634307;
				short num2 = num;
				num = (short)104845827;
				switch (num2 == num)
				{
				}
				num = (short)1854996480;
				if (num != 0)
				{
				}
				num = (short)289603585;
				if (num != 0)
				{
				}
				num = (short)298516480;
				short num3 = num;
				return this.trkPerFeaturesStatusEnable_A9188.Visible;
			}
			set
			{
				short num = (short)1372837133;
				short num2 = num;
				num = (short)1448793357;
				switch (num2 == num)
				{
				}
				num = (short)1159725057;
				if (num != 0)
				{
				}
				num = (short)1911554048;
				if (num != 0)
				{
				}
				num = (short)1777860608;
				short num3 = num;
				this.trkPerFeaturesStatusEnable_A9188.Visible = value;
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x00197220 File Offset: 0x00195420
		// (set) Token: 0x0600188D RID: 6285 RVA: 0x001972D4 File Offset: 0x001954D4
		public bool TrkPerFeaturesStatusEnable_A9188_Editable
		{
			get
			{
				short num = (short)1168774965;
				short num2 = num;
				num = (short)1677334325;
				switch (num2 == num)
				{
				}
				num = (short)546308097;
				if (num != 0)
				{
				}
				num = (short)1419575296;
				if (num != 0)
				{
				}
				num = (short)29229056;
				short num3 = num;
				return this.trkPerFeaturesStatusEnable_A9188.Editable;
			}
			set
			{
				short num = (short)1642048048;
				short num2 = num;
				num = (short)1577495088;
				switch (num2 == num)
				{
				}
				num = (short)174981121;
				if (num != 0)
				{
				}
				num = (short)2026831872;
				if (num != 0)
				{
				}
				num = (short)961347584;
				short num3 = num;
				this.trkPerFeaturesStatusEnable_A9188.Editable = value;
			}
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x0600188E RID: 6286 RVA: 0x00197388 File Offset: 0x00195588
		internal string TrkPerFeaturesStatusEnable_A9188_UILabel
		{
			get
			{
				short num = (short)1575162152;
				short num2 = num;
				num = (short)3805480;
				switch (num2 == num)
				{
				}
				num = (short)40894465;
				if (num != 0)
				{
				}
				num = (short)451280896;
				if (num != 0)
				{
				}
				num = (short)942211072;
				short num3 = num;
				return this.trkPerFeaturesStatusEnable_A9188.UIName;
			}
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x0600188F RID: 6287 RVA: 0x0019743C File Offset: 0x0019563C
		// (set) Token: 0x06001890 RID: 6288 RVA: 0x001974F0 File Offset: 0x001956F0
		internal bool TrkPerFeaturesStatusEnable_A9188_HiddenStatic
		{
			get
			{
				short num = (short)477765739;
				short num2 = num;
				num = (short)731783275;
				switch (num2 == num)
				{
				}
				num = (short)371195904;
				if (num != 0)
				{
				}
				num = (short)33095681;
				if (num != 0)
				{
				}
				num = (short)1538260992;
				short num3 = num;
				return this.trkPerFeaturesStatusEnable_A9188.HiddenStatic;
			}
			set
			{
				short num = (short)159097130;
				short num2 = num;
				num = (short)181117226;
				switch (num2 == num)
				{
				}
				num = (short)1597964289;
				if (num != 0)
				{
				}
				num = (short)1639383040;
				if (num != 0)
				{
				}
				num = (short)563085312;
				short num3 = num;
				this.trkPerFeaturesStatusEnable_A9188.HiddenStatic = value;
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x06001891 RID: 6289 RVA: 0x001975A4 File Offset: 0x001957A4
		// (set) Token: 0x06001892 RID: 6290 RVA: 0x00197658 File Offset: 0x00195858
		internal bool TrkPerFeaturesStatusEnable_A9188_HiddenDynamic
		{
			get
			{
				short num = (short)1970779732;
				short num2 = num;
				num = (short)33273428;
				switch (num2 == num)
				{
				}
				num = (short)1651572737;
				if (num != 0)
				{
				}
				num = (short)893911040;
				if (num != 0)
				{
				}
				num = (short)702349312;
				short num3 = num;
				return this.trkPerFeaturesStatusEnable_A9188.HiddenDynamic;
			}
			set
			{
				short num = (short)1391713059;
				short num2 = num;
				num = (short)951376675;
				switch (num2 == num)
				{
				}
				num = (short)1400176641;
				if (num != 0)
				{
				}
				num = (short)1175912448;
				if (num != 0)
				{
				}
				num = (short)952631296;
				short num3 = num;
				this.trkPerFeaturesStatusEnable_A9188.HiddenDynamic = value;
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06001893 RID: 6291 RVA: 0x0019770C File Offset: 0x0019590C
		public bool TrkPerFeaturesStatusEnable_A9188_HasDiffs
		{
			get
			{
				short num = (short)1352034161;
				short num2 = num;
				num = (short)1138452337;
				switch (num2 == num)
				{
				}
				num = (short)82313216;
				if (num != 0)
				{
				}
				num = (short)1409220609;
				if (num != 0)
				{
				}
				num = (short)131268608;
				short num3 = num;
				return this.trkPerFeaturesStatusEnable_A9188._HasDiffs;
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06001894 RID: 6292 RVA: 0x001977C0 File Offset: 0x001959C0
		// (set) Token: 0x06001895 RID: 6293 RVA: 0x00197874 File Offset: 0x00195A74
		public bool TrkPerFeaturesTalkPermitTone_A9271Value
		{
			get
			{
				short num = (short)1253003873;
				short num2 = num;
				num = (short)104092257;
				switch (num2 == num)
				{
				}
				num = (short)1662648321;
				if (num != 0)
				{
				}
				num = (short)1138229248;
				if (num != 0)
				{
				}
				num = (short)1784283136;
				short num3 = num;
				return this.trkPerFeaturesTalkPermitTone_A9271.Value;
			}
			set
			{
				short num = (short)1795721728;
				short num2 = num;
				num = (short)1085114880;
				switch (num2 == num)
				{
				}
				num = (short)1468006401;
				if (num != 0)
				{
				}
				num = (short)1905000448;
				if (num != 0)
				{
				}
				num = (short)1202126848;
				short num3 = num;
				this.trkPerFeaturesTalkPermitTone_A9271.Value = value;
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x06001896 RID: 6294 RVA: 0x00197928 File Offset: 0x00195B28
		public global::AcpBusinessLayer.AcpField<bool> TrkPerFeaturesTalkPermitTone_A9271
		{
			get
			{
				short num = (short)2095514667;
				short num2 = num;
				num = (short)344130603;
				switch (num2 == num)
				{
				}
				num = (short)666173440;
				if (num != 0)
				{
				}
				num = (short)1027407873;
				if (num != 0)
				{
				}
				num = (short)477560832;
				short num3 = num;
				return this.trkPerFeaturesTalkPermitTone_A9271;
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06001897 RID: 6295 RVA: 0x001979D8 File Offset: 0x00195BD8
		// (set) Token: 0x06001898 RID: 6296 RVA: 0x00197A90 File Offset: 0x00195C90
		public bool TrkPerFeaturesTalkPermitTone_A9271_UIValue
		{
			get
			{
				short num = (short)1508991340;
				short num2 = num;
				num = (short)567435628;
				switch (num2 == num)
				{
				}
				num = (short)1397096449;
				if (num != 0)
				{
				}
				num = (short)543227904;
				if (num != 0)
				{
				}
				num = (short)1221787648;
				short num3 = num;
				return this.trkPerFeaturesTalkPermitTone_A9271.Value;
			}
			set
			{
				short num = (short)328073217;
				if (num != 0)
				{
				}
				num = (short)296918087;
				short num2 = num;
				num = (short)1591057479;
				switch (num2 == num)
				{
				}
				num = (short)186449920;
				if (num != 0)
				{
				}
				num = (short)464125952;
				short num3 = num;
				this.trkPerFeaturesTalkPermitTone_A9271.Value = value;
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06001899 RID: 6297 RVA: 0x00197B48 File Offset: 0x00195D48
		// (set) Token: 0x0600189A RID: 6298 RVA: 0x00197BFC File Offset: 0x00195DFC
		public bool TrkPerFeaturesTalkPermitTone_A9271_Applicable
		{
			get
			{
				short num = (short)1530496004;
				short num2 = num;
				num = (short)649561092;
				switch (num2 == num)
				{
				}
				num = (short)1455292417;
				if (num != 0)
				{
				}
				num = (short)527564800;
				if (num != 0)
				{
				}
				num = (short)1396178944;
				short num3 = num;
				return this.trkPerFeaturesTalkPermitTone_A9271.Applicable;
			}
			set
			{
				short num = (short)815322973;
				short num2 = num;
				num = (short)438032221;
				switch (num2 == num)
				{
				}
				num = (short)160038913;
				if (num != 0)
				{
				}
				num = (short)182452224;
				if (num != 0)
				{
				}
				num = (short)1912602624;
				short num3 = num;
				this.trkPerFeaturesTalkPermitTone_A9271.Applicable = value;
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x0600189B RID: 6299 RVA: 0x00197CB0 File Offset: 0x00195EB0
		// (set) Token: 0x0600189C RID: 6300 RVA: 0x00197D68 File Offset: 0x00195F68
		public bool TrkPerFeaturesTalkPermitTone_A9271_Valid
		{
			get
			{
				short num = (short)576680496;
				short num2 = num;
				num = (short)674198064;
				switch (num2 == num)
				{
				}
				num = (short)2080833536;
				if (num != 0)
				{
				}
				num = (short)448004097;
				if (num != 0)
				{
				}
				num = (short)1579679744;
				short num3 = num;
				return this.trkPerFeaturesTalkPermitTone_A9271.Valid;
			}
			set
			{
				short num = (short)2096197947;
				short num2 = num;
				num = (short)37515579;
				switch (num2 == num)
				{
				}
				num = (short)904658945;
				if (num != 0)
				{
				}
				num = (short)788267008;
				if (num != 0)
				{
				}
				num = (short)150339584;
				short num3 = num;
				this.trkPerFeaturesTalkPermitTone_A9271.Valid = value;
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x0600189D RID: 6301 RVA: 0x00197E1C File Offset: 0x0019601C
		// (set) Token: 0x0600189E RID: 6302 RVA: 0x00197ED0 File Offset: 0x001960D0
		public bool TrkPerFeaturesTalkPermitTone_A9271_Visible
		{
			get
			{
				short num = (short)150617764;
				short num2 = num;
				num = (short)1992375972;
				switch (num2 == num)
				{
				}
				num = (short)748290048;
				if (num != 0)
				{
				}
				num = (short)1717960705;
				if (num != 0)
				{
				}
				num = (short)1507655680;
				short num3 = num;
				return this.trkPerFeaturesTalkPermitTone_A9271.Visible;
			}
			set
			{
				short num = (short)1423464670;
				short num2 = num;
				num = (short)1959549150;
				switch (num2 == num)
				{
				}
				num = (short)910295041;
				if (num != 0)
				{
				}
				num = (short)132972544;
				if (num != 0)
				{
				}
				num = (short)135659520;
				short num3 = num;
				this.trkPerFeaturesTalkPermitTone_A9271.Visible = value;
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x0600189F RID: 6303 RVA: 0x00197F88 File Offset: 0x00196188
		// (set) Token: 0x060018A0 RID: 6304 RVA: 0x0019803C File Offset: 0x0019623C
		public bool TrkPerFeaturesTalkPermitTone_A9271_Editable
		{
			get
			{
				short num = (short)888152940;
				short num2 = num;
				num = (short)967910252;
				switch (num2 == num)
				{
				}
				num = (short)1932918784;
				if (num != 0)
				{
				}
				num = (short)1916272641;
				if (num != 0)
				{
				}
				num = (short)232652800;
				short num3 = num;
				return this.trkPerFeaturesTalkPermitTone_A9271.Editable;
			}
			set
			{
				short num = (short)1468334081;
				if (num != 0)
				{
				}
				num = (short)2025191127;
				short num2 = num;
				num = (short)119142103;
				switch (num2 == num)
				{
				}
				num = (short)198574080;
				if (num != 0)
				{
				}
				num = (short)400687104;
				short num3 = num;
				this.trkPerFeaturesTalkPermitTone_A9271.Editable = value;
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x060018A1 RID: 6305 RVA: 0x001980F4 File Offset: 0x001962F4
		internal string TrkPerFeaturesTalkPermitTone_A9271_UILabel
		{
			get
			{
				short num = (short)407457079;
				short num2 = num;
				num = (short)559762743;
				switch (num2 == num)
				{
				}
				num = (short)1981022209;
				if (num != 0)
				{
				}
				num = (short)671875072;
				if (num != 0)
				{
				}
				num = (short)1054998528;
				short num3 = num;
				return this.trkPerFeaturesTalkPermitTone_A9271.UIName;
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x060018A2 RID: 6306 RVA: 0x001981A8 File Offset: 0x001963A8
		// (set) Token: 0x060018A3 RID: 6307 RVA: 0x00198258 File Offset: 0x00196458
		internal bool TrkPerFeaturesTalkPermitTone_A9271_HiddenStatic
		{
			get
			{
				short num = (short)684449527;
				short num2 = num;
				num = (short)1889263351;
				switch (num2 == num)
				{
				}
				num = (short)523370497;
				if (num != 0)
				{
				}
				num = (short)1674903552;
				if (num != 0)
				{
				}
				num = (short)2039087104;
				short num3 = num;
				return this.trkPerFeaturesTalkPermitTone_A9271.HiddenStatic;
			}
			set
			{
				short num = (short)782265699;
				short num2 = num;
				num = (short)1686465891;
				switch (num2 == num)
				{
				}
				num = (short)92209153;
				if (num != 0)
				{
				}
				num = (short)1090584576;
				if (num != 0)
				{
				}
				num = (short)1791492096;
				short num3 = num;
				this.trkPerFeaturesTalkPermitTone_A9271.HiddenStatic = value;
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x060018A4 RID: 6308 RVA: 0x0019830C File Offset: 0x0019650C
		// (set) Token: 0x060018A5 RID: 6309 RVA: 0x001983C0 File Offset: 0x001965C0
		internal bool TrkPerFeaturesTalkPermitTone_A9271_HiddenDynamic
		{
			get
			{
				short num = (short)1065951269;
				short num2 = num;
				num = (short)1625628709;
				switch (num2 == num)
				{
				}
				num = (short)1521483776;
				if (num != 0)
				{
				}
				num = (short)757202945;
				if (num != 0)
				{
				}
				num = (short)1646460928;
				short num3 = num;
				return this.trkPerFeaturesTalkPermitTone_A9271.HiddenDynamic;
			}
			set
			{
				short num = (short)1995955315;
				short num2 = num;
				num = (short)1966398579;
				switch (num2 == num)
				{
				}
				num = (short)26673153;
				if (num != 0)
				{
				}
				num = (short)1703804928;
				if (num != 0)
				{
				}
				num = (short)1072562176;
				short num3 = num;
				this.trkPerFeaturesTalkPermitTone_A9271.HiddenDynamic = value;
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x060018A6 RID: 6310 RVA: 0x00198474 File Offset: 0x00196674
		public bool TrkPerFeaturesTalkPermitTone_A9271_HasDiffs
		{
			get
			{
				short num = (short)2080945109;
				short num2 = num;
				num = (short)423998421;
				switch (num2 == num)
				{
				}
				num = (short)273219584;
				if (num != 0)
				{
				}
				num = (short)1231880193;
				if (num != 0)
				{
				}
				num = (short)1956708352;
				short num3 = num;
				return this.trkPerFeaturesTalkPermitTone_A9271._HasDiffs;
			}
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x060018A7 RID: 6311 RVA: 0x00198528 File Offset: 0x00196728
		// (set) Token: 0x060018A8 RID: 6312 RVA: 0x001985DC File Offset: 0x001967DC
		public bool TrkPerIgnoreRxClearVoice_A41610Value
		{
			get
			{
				short num = (short)780705482;
				short num2 = num;
				num = (short)1283432138;
				switch (num2 == num)
				{
				}
				num = (short)1406795777;
				if (num != 0)
				{
				}
				num = (short)1423441920;
				if (num != 0)
				{
				}
				num = (short)1588068352;
				short num3 = num;
				return this.trkPerIgnoreRxClearVoice_A41610.Value;
			}
			set
			{
				short num = (short)1342180943;
				short num2 = num;
				num = (short)225709647;
				switch (num2 == num)
				{
				}
				num = (short)559218689;
				if (num != 0)
				{
				}
				num = (short)1070137344;
				if (num != 0)
				{
				}
				num = (short)914685952;
				short num3 = num;
				this.trkPerIgnoreRxClearVoice_A41610.Value = value;
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x060018A9 RID: 6313 RVA: 0x00198694 File Offset: 0x00196894
		public global::AcpBusinessLayer.AcpField<bool> TrkPerIgnoreRxClearVoice_A41610
		{
			get
			{
				short num = (short)336515498;
				short num2 = num;
				num = (short)1861800362;
				switch (num2 == num)
				{
				}
				num = (short)781975552;
				if (num != 0)
				{
				}
				num = (short)226164737;
				if (num != 0)
				{
				}
				num = (short)417595392;
				short num3 = num;
				return this.trkPerIgnoreRxClearVoice_A41610;
			}
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x060018AA RID: 6314 RVA: 0x00198744 File Offset: 0x00196944
		// (set) Token: 0x060018AB RID: 6315 RVA: 0x001987F8 File Offset: 0x001969F8
		public bool TrkPerIgnoreRxClearVoice_A41610_UIValue
		{
			get
			{
				short num = (short)1292278654;
				short num2 = num;
				num = (short)1712561022;
				switch (num2 == num)
				{
				}
				num = (short)1599864833;
				if (num != 0)
				{
				}
				num = (short)102105088;
				if (num != 0)
				{
				}
				num = (short)2063007744;
				short num3 = num;
				return this.trkPerIgnoreRxClearVoice_A41610.Value;
			}
			set
			{
				short num = (short)769826237;
				short num2 = num;
				num = (short)995139005;
				switch (num2 == num)
				{
				}
				num = (short)1140916224;
				if (num != 0)
				{
				}
				num = (short)732626945;
				if (num != 0)
				{
				}
				num = (short)1818951680;
				short num3 = num;
				this.trkPerIgnoreRxClearVoice_A41610.Value = value;
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x060018AC RID: 6316 RVA: 0x001988AC File Offset: 0x00196AAC
		// (set) Token: 0x060018AD RID: 6317 RVA: 0x00198960 File Offset: 0x00196B60
		public bool TrkPerIgnoreRxClearVoice_A41610_Applicable
		{
			get
			{
				short num = (short)593038261;
				short num2 = num;
				num = (short)1418136501;
				switch (num2 == num)
				{
				}
				num = (short)1242759169;
				if (num != 0)
				{
				}
				num = (short)1493958656;
				if (num != 0)
				{
				}
				num = (short)1581842432;
				short num3 = num;
				return this.trkPerIgnoreRxClearVoice_A41610.Applicable;
			}
			set
			{
				short num = (short)1347957838;
				short num2 = num;
				num = (short)162411598;
				switch (num2 == num)
				{
				}
				num = (short)543162368;
				if (num != 0)
				{
				}
				num = (short)893255681;
				if (num != 0)
				{
				}
				num = (short)1237909504;
				short num3 = num;
				this.trkPerIgnoreRxClearVoice_A41610.Applicable = value;
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x060018AE RID: 6318 RVA: 0x00198A18 File Offset: 0x00196C18
		// (set) Token: 0x060018AF RID: 6319 RVA: 0x00198ACC File Offset: 0x00196CCC
		public bool TrkPerIgnoreRxClearVoice_A41610_Valid
		{
			get
			{
				short num = (short)997413464;
				short num2 = num;
				num = (short)1026904664;
				switch (num2 == num)
				{
				}
				num = (short)1491009536;
				if (num != 0)
				{
				}
				num = (short)450887681;
				if (num != 0)
				{
				}
				num = (short)1677262848;
				short num3 = num;
				return this.trkPerIgnoreRxClearVoice_A41610.Valid;
			}
			set
			{
				short num = (short)418597487;
				short num2 = num;
				num = (short)1361398383;
				switch (num2 == num)
				{
				}
				num = (short)1153433600;
				short num3 = num;
				num = (short)1137967105;
				if (num != 0)
				{
				}
				num = (short)415105024;
				if (num != 0)
				{
				}
				this.trkPerIgnoreRxClearVoice_A41610.Valid = value;
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x060018B0 RID: 6320 RVA: 0x00198B80 File Offset: 0x00196D80
		// (set) Token: 0x060018B1 RID: 6321 RVA: 0x00198C34 File Offset: 0x00196E34
		public bool TrkPerIgnoreRxClearVoice_A41610_Visible
		{
			get
			{
				short num = (short)1261906402;
				short num2 = num;
				num = (short)1569925602;
				switch (num2 == num)
				{
				}
				num = (short)1323827200;
				short num3 = num;
				num = (short)468975616;
				if (num != 0)
				{
				}
				num = (short)577699841;
				if (num != 0)
				{
				}
				return this.trkPerIgnoreRxClearVoice_A41610.Visible;
			}
			set
			{
				short num = (short)1710061976;
				short num2 = num;
				num = (short)1575057816;
				switch (num2 == num)
				{
				}
				num = (short)391249920;
				short num3 = num;
				num = (short)960233472;
				if (num != 0)
				{
				}
				num = (short)1935736833;
				if (num != 0)
				{
				}
				this.trkPerIgnoreRxClearVoice_A41610.Visible = value;
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x060018B2 RID: 6322 RVA: 0x00198CEC File Offset: 0x00196EEC
		// (set) Token: 0x060018B3 RID: 6323 RVA: 0x00198DA0 File Offset: 0x00196FA0
		public bool TrkPerIgnoreRxClearVoice_A41610_Editable
		{
			get
			{
				short num = (short)785548717;
				short num2 = num;
				num = (short)1614579117;
				switch (num2 == num)
				{
				}
				num = (short)77135872;
				short num3 = num;
				num = (short)216530944;
				if (num != 0)
				{
				}
				num = (short)336527361;
				if (num != 0)
				{
				}
				return this.trkPerIgnoreRxClearVoice_A41610.Editable;
			}
			set
			{
				short num = (short)1030537519;
				short num2 = num;
				num = (short)1208729903;
				switch (num2 == num)
				{
				}
				num = (short)1169555456;
				short num3 = num;
				num = (short)526712833;
				if (num != 0)
				{
				}
				num = (short)969015296;
				if (num != 0)
				{
				}
				this.trkPerIgnoreRxClearVoice_A41610.Editable = value;
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x060018B4 RID: 6324 RVA: 0x00198E58 File Offset: 0x00197058
		internal string TrkPerIgnoreRxClearVoice_A41610_UILabel
		{
			get
			{
				short num = (short)969116244;
				short num2 = num;
				num = (short)1547536980;
				switch (num2 == num)
				{
				}
				num = (short)895680512;
				short num3 = num;
				num = (short)535822337;
				if (num != 0)
				{
				}
				num = (short)1883897856;
				if (num != 0)
				{
				}
				return this.trkPerIgnoreRxClearVoice_A41610.UIName;
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x060018B5 RID: 6325 RVA: 0x00198F10 File Offset: 0x00197110
		// (set) Token: 0x060018B6 RID: 6326 RVA: 0x00198FC4 File Offset: 0x001971C4
		internal bool TrkPerIgnoreRxClearVoice_A41610_HiddenStatic
		{
			get
			{
				short num = (short)172490753;
				if (num != 0)
				{
				}
				num = (short)1878934187;
				short num2 = num;
				num = (short)366428843;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2128084992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)632356864;
				if (num != 0)
				{
				}
				return this.trkPerIgnoreRxClearVoice_A41610.HiddenStatic;
			}
			set
			{
				short num = (short)1514201200;
				short num2 = num;
				num = (short)151969904;
				switch (num2 == num)
				{
				}
				num = (short)713293824;
				short num3 = num;
				num = (short)996343808;
				if (num != 0)
				{
				}
				num = (short)705101825;
				if (num != 0)
				{
				}
				this.trkPerIgnoreRxClearVoice_A41610.HiddenStatic = value;
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x060018B7 RID: 6327 RVA: 0x0019907C File Offset: 0x0019727C
		// (set) Token: 0x060018B8 RID: 6328 RVA: 0x00199134 File Offset: 0x00197334
		internal bool TrkPerIgnoreRxClearVoice_A41610_HiddenDynamic
		{
			get
			{
				short num = (short)1723006977;
				if (num != 0)
				{
				}
				num = (short)1887499363;
				short num2 = num;
				num = (short)148567139;
				switch (num2 == num)
				{
				default:
				{
					num = (short)633339904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)429129728;
				if (num != 0)
				{
				}
				return this.trkPerIgnoreRxClearVoice_A41610.HiddenDynamic;
			}
			set
			{
				short num = (short)1584901763;
				short num2 = num;
				num = (short)795061891;
				switch (num2 == num)
				{
				}
				num = (short)2112552960;
				short num3 = num;
				num = (short)627703809;
				if (num != 0)
				{
				}
				num = (short)1619460096;
				if (num != 0)
				{
				}
				this.trkPerIgnoreRxClearVoice_A41610.HiddenDynamic = value;
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x060018B9 RID: 6329 RVA: 0x001991F0 File Offset: 0x001973F0
		public bool TrkPerIgnoreRxClearVoice_A41610_HasDiffs
		{
			get
			{
				short num = (short)1454215181;
				short num2 = num;
				num = (short)590254093;
				switch (num2 == num)
				{
				}
				num = (short)462487552;
				short num3 = num;
				num = (short)1418330113;
				if (num != 0)
				{
				}
				num = (short)930807808;
				if (num != 0)
				{
				}
				return this.trkPerIgnoreRxClearVoice_A41610._HasDiffs;
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x060018BA RID: 6330 RVA: 0x001992A4 File Offset: 0x001974A4
		// (set) Token: 0x060018BB RID: 6331 RVA: 0x00199358 File Offset: 0x00197558
		public bool TrkPerEndTxOnVoiceAbsence_42461Value
		{
			get
			{
				short num = (short)693492539;
				short num2 = num;
				num = (short)1655036731;
				switch (num2 == num)
				{
				}
				num = (short)673906688;
				short num3 = num;
				num = (short)2112356352;
				if (num != 0)
				{
				}
				num = (short)603258881;
				if (num != 0)
				{
				}
				return this.trkPerEndTxOnVoiceAbsence_42461.Value;
			}
			set
			{
				short num = (short)622985217;
				if (num != 0)
				{
				}
				num = (short)909959441;
				short num2 = num;
				num = (short)990044433;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1874067456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1291321344;
				if (num != 0)
				{
				}
				this.trkPerEndTxOnVoiceAbsence_42461.Value = value;
			}
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x060018BC RID: 6332 RVA: 0x00199410 File Offset: 0x00197610
		public global::AcpBusinessLayer.AcpField<bool> TrkPerEndTxOnVoiceAbsence_42461
		{
			get
			{
				short num = (short)345919326;
				short num2 = num;
				num = (short)1263161182;
				switch (num2 == num)
				{
				}
				num = (short)1653997568;
				short num3 = num;
				num = (short)9240577;
				if (num != 0)
				{
				}
				num = (short)1290862592;
				if (num != 0)
				{
				}
				return this.trkPerEndTxOnVoiceAbsence_42461;
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x060018BD RID: 6333 RVA: 0x001994C0 File Offset: 0x001976C0
		// (set) Token: 0x060018BE RID: 6334 RVA: 0x00199574 File Offset: 0x00197774
		public bool TrkPerEndTxOnVoiceAbsence_42461_UIValue
		{
			get
			{
				short num = (short)908150635;
				short num2 = num;
				num = (short)1804158827;
				switch (num2 == num)
				{
				}
				num = (short)41811968;
				short num3 = num;
				num = (short)1588658177;
				if (num != 0)
				{
				}
				num = (short)2006908928;
				if (num != 0)
				{
				}
				return this.trkPerEndTxOnVoiceAbsence_42461.Value;
			}
			set
			{
				short num = (short)1787001886;
				short num2 = num;
				num = (short)232619038;
				switch (num2 == num)
				{
				}
				num = (short)1527447552;
				short num3 = num;
				num = (short)673841152;
				if (num != 0)
				{
				}
				num = (short)194707457;
				if (num != 0)
				{
				}
				this.trkPerEndTxOnVoiceAbsence_42461.Value = value;
			}
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x060018BF RID: 6335 RVA: 0x0019962C File Offset: 0x0019782C
		// (set) Token: 0x060018C0 RID: 6336 RVA: 0x001996E4 File Offset: 0x001978E4
		public bool TrkPerEndTxOnVoiceAbsence_42461_Applicable
		{
			get
			{
				short num = (short)164690718;
				short num2 = num;
				num = (short)993852190;
				switch (num2 == num)
				{
				}
				num = (short)622198784;
				short num3 = num;
				num = (short)1535311873;
				if (num != 0)
				{
				}
				num = (short)2102198272;
				if (num != 0)
				{
				}
				return this.trkPerEndTxOnVoiceAbsence_42461.Applicable;
			}
			set
			{
				short num = (short)833333735;
				short num2 = num;
				num = (short)632924647;
				switch (num2 == num)
				{
				}
				num = (short)266797056;
				short num3 = num;
				num = (short)422772736;
				if (num != 0)
				{
				}
				num = (short)1548550145;
				if (num != 0)
				{
				}
				this.trkPerEndTxOnVoiceAbsence_42461.Applicable = value;
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x060018C1 RID: 6337 RVA: 0x0019979C File Offset: 0x0019799C
		// (set) Token: 0x060018C2 RID: 6338 RVA: 0x00199850 File Offset: 0x00197A50
		public bool TrkPerEndTxOnVoiceAbsence_42461_Valid
		{
			get
			{
				short num = (short)747941527;
				short num2 = num;
				num = (short)1015262871;
				switch (num2 == num)
				{
				}
				num = (short)543293440;
				short num3 = num;
				num = (short)1558773760;
				if (num != 0)
				{
				}
				num = (short)747438081;
				if (num != 0)
				{
				}
				return this.trkPerEndTxOnVoiceAbsence_42461.Valid;
			}
			set
			{
				short num = (short)375643702;
				short num2 = num;
				num = (short)1822547510;
				switch (num2 == num)
				{
				}
				num = (short)772800512;
				short num3 = num;
				num = (short)1228144641;
				if (num != 0)
				{
				}
				num = (short)1632043008;
				if (num != 0)
				{
				}
				this.trkPerEndTxOnVoiceAbsence_42461.Valid = value;
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x060018C3 RID: 6339 RVA: 0x00199904 File Offset: 0x00197B04
		// (set) Token: 0x060018C4 RID: 6340 RVA: 0x001999B8 File Offset: 0x00197BB8
		public bool TrkPerEndTxOnVoiceAbsence_42461_Visible
		{
			get
			{
				short num = (short)1921829374;
				short num2 = num;
				num = (short)1182386686;
				switch (num2 == num)
				{
				}
				num = (short)452788224;
				short num3 = num;
				num = (short)31457280;
				if (num != 0)
				{
				}
				num = (short)753401857;
				if (num != 0)
				{
				}
				return this.trkPerEndTxOnVoiceAbsence_42461.Visible;
			}
			set
			{
				short num = (short)195887105;
				if (num != 0)
				{
				}
				num = (short)2115226424;
				short num2 = num;
				num = (short)1207552824;
				switch (num2 == num)
				{
				default:
				{
					num = (short)421330944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2027421696;
				if (num != 0)
				{
				}
				this.trkPerEndTxOnVoiceAbsence_42461.Visible = value;
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x060018C5 RID: 6341 RVA: 0x00199A6C File Offset: 0x00197C6C
		// (set) Token: 0x060018C6 RID: 6342 RVA: 0x00199B20 File Offset: 0x00197D20
		public bool TrkPerEndTxOnVoiceAbsence_42461_Editable
		{
			get
			{
				short num = (short)132817860;
				short num2 = num;
				num = (short)1342022596;
				switch (num2 == num)
				{
				}
				num = (short)4259840;
				short num3 = num;
				num = (short)127598593;
				if (num != 0)
				{
				}
				num = (short)1201340416;
				if (num != 0)
				{
				}
				return this.trkPerEndTxOnVoiceAbsence_42461.Editable;
			}
			set
			{
				short num = (short)1730609222;
				short num2 = num;
				num = (short)1740832838;
				switch (num2 == num)
				{
				}
				num = (short)1267531776;
				short num3 = num;
				num = (short)586481664;
				if (num != 0)
				{
				}
				num = (short)1697054721;
				if (num != 0)
				{
				}
				this.trkPerEndTxOnVoiceAbsence_42461.Editable = value;
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x060018C7 RID: 6343 RVA: 0x00199BD4 File Offset: 0x00197DD4
		internal string TrkPerEndTxOnVoiceAbsence_42461_UILabel
		{
			get
			{
				short num = (short)696632503;
				short num2 = num;
				num = (short)470074551;
				switch (num2 == num)
				{
				}
				num = (short)1573584896;
				short num3 = num;
				num = (short)1951072257;
				if (num != 0)
				{
				}
				num = (short)301858816;
				if (num != 0)
				{
				}
				return this.trkPerEndTxOnVoiceAbsence_42461.UIName;
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x060018C8 RID: 6344 RVA: 0x00199C84 File Offset: 0x00197E84
		// (set) Token: 0x060018C9 RID: 6345 RVA: 0x00199D38 File Offset: 0x00197F38
		internal bool TrkPerEndTxOnVoiceAbsence_42461_HiddenStatic
		{
			get
			{
				short num = (short)2111308414;
				short num2 = num;
				num = (short)2085356158;
				switch (num2 == num)
				{
				}
				num = (short)1528168448;
				short num3 = num;
				num = (short)368771072;
				if (num != 0)
				{
				}
				num = (short)63373313;
				if (num != 0)
				{
				}
				return this.trkPerEndTxOnVoiceAbsence_42461.HiddenStatic;
			}
			set
			{
				short num = (short)1223113817;
				short num2 = num;
				num = (short)1536113753;
				switch (num2 == num)
				{
				}
				num = (short)1139802112;
				short num3 = num;
				num = (short)780599297;
				if (num != 0)
				{
				}
				num = (short)403701760;
				if (num != 0)
				{
				}
				this.trkPerEndTxOnVoiceAbsence_42461.HiddenStatic = value;
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x060018CA RID: 6346 RVA: 0x00199DF0 File Offset: 0x00197FF0
		// (set) Token: 0x060018CB RID: 6347 RVA: 0x00199EA4 File Offset: 0x001980A4
		internal bool TrkPerEndTxOnVoiceAbsence_42461_HiddenDynamic
		{
			get
			{
				short num = (short)890853665;
				short num2 = num;
				num = (short)747788577;
				switch (num2 == num)
				{
				}
				num = (short)881852416;
				short num3 = num;
				num = (short)487653377;
				if (num != 0)
				{
				}
				num = (short)1026949120;
				if (num != 0)
				{
				}
				return this.trkPerEndTxOnVoiceAbsence_42461.HiddenDynamic;
			}
			set
			{
				short num = (short)308314294;
				short num2 = num;
				num = (short)1648001206;
				switch (num2 == num)
				{
				}
				num = (short)1374879744;
				short num3 = num;
				num = (short)1591410688;
				if (num != 0)
				{
				}
				num = (short)277282817;
				if (num != 0)
				{
				}
				this.trkPerEndTxOnVoiceAbsence_42461.HiddenDynamic = value;
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x060018CC RID: 6348 RVA: 0x00199F5C File Offset: 0x0019815C
		public bool TrkPerEndTxOnVoiceAbsence_42461_HasDiffs
		{
			get
			{
				short num = (short)301858817;
				if (num != 0)
				{
				}
				num = (short)1594359808;
				short num2 = num;
				num = (short)1450372738;
				short num3 = num;
				num = (short)626978434;
				switch (num3 == num)
				{
				}
				num = (short)791412736;
				if (num != 0)
				{
				}
				return this.trkPerEndTxOnVoiceAbsence_42461._HasDiffs;
			}
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x060018CD RID: 6349 RVA: 0x0019A010 File Offset: 0x00198210
		// (set) Token: 0x060018CE RID: 6350 RVA: 0x0019A0C4 File Offset: 0x001982C4
		public bool TrkPerFeaturesHazardZoneModePersonalityValue
		{
			get
			{
				short num = (short)434857581;
				short num2 = num;
				num = (short)307127917;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2137522176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1575747585;
				if (num != 0)
				{
				}
				num = (short)2076114944;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesHazardZoneModePersonality.Value;
			}
			set
			{
				short num = (short)1138578870;
				short num2 = num;
				num = (short)1695634870;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1327824896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)7536641;
				if (num != 0)
				{
				}
				num = (short)1816526848;
				if (num != 0)
				{
				}
				this.trkPerFeaturesHazardZoneModePersonality.Value = value;
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x060018CF RID: 6351 RVA: 0x0019A17C File Offset: 0x0019837C
		public global::AcpBusinessLayer.AcpField<bool> TrkPerFeaturesHazardZoneModePersonality
		{
			get
			{
				short num = (short)378431480;
				short num2 = num;
				num = (short)2015455224;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1999175680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)515768321;
				if (num != 0)
				{
				}
				num = (short)1661140992;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesHazardZoneModePersonality;
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x060018D0 RID: 6352 RVA: 0x0019A22C File Offset: 0x0019842C
		// (set) Token: 0x060018D1 RID: 6353 RVA: 0x0019A2DC File Offset: 0x001984DC
		public bool TrkPerFeaturesHazardZoneModePersonality_UIValue
		{
			get
			{
				short num = (short)1103376812;
				short num2 = num;
				num = (short)1620849068;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2008875008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)345964545;
				if (num != 0)
				{
				}
				num = (short)1763704832;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesHazardZoneModePersonality.Value;
			}
			set
			{
				short num = (short)22478849;
				if (num != 0)
				{
				}
				num = (short)1764032512;
				short num2 = num;
				num = (short)449809645;
				short num3 = num;
				num = (short)2015333613;
				switch (num3 == num)
				{
				}
				num = (short)626458624;
				if (num != 0)
				{
				}
				this.trkPerFeaturesHazardZoneModePersonality.Value = value;
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x060018D2 RID: 6354 RVA: 0x0019A390 File Offset: 0x00198590
		// (set) Token: 0x060018D3 RID: 6355 RVA: 0x0019A440 File Offset: 0x00198640
		public bool TrkPerFeaturesHazardZoneModePersonality_Applicable
		{
			get
			{
				short num = (short)910229505;
				if (num != 0)
				{
				}
				num = (short)297271296;
				short num2 = num;
				num = (short)1498171470;
				short num3 = num;
				num = (short)630278222;
				switch (num3 == num)
				{
				}
				num = (short)1681850368;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesHazardZoneModePersonality.Applicable;
			}
			set
			{
				short num = (short)833681314;
				short num2 = num;
				num = (short)375322530;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1887043584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1799815168;
				if (num != 0)
				{
				}
				num = (short)1078788097;
				if (num != 0)
				{
				}
				this.trkPerFeaturesHazardZoneModePersonality.Applicable = value;
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x060018D4 RID: 6356 RVA: 0x0019A4F8 File Offset: 0x001986F8
		// (set) Token: 0x060018D5 RID: 6357 RVA: 0x0019A5AC File Offset: 0x001987AC
		public bool TrkPerFeaturesHazardZoneModePersonality_Valid
		{
			get
			{
				short num = (short)773372151;
				short num2 = num;
				num = (short)1816967415;
				switch (num2 == num)
				{
				default:
				{
					num = (short)756285440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1694433280;
				if (num != 0)
				{
				}
				num = (short)610402305;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesHazardZoneModePersonality.Valid;
			}
			set
			{
				short num = (short)583204865;
				if (num != 0)
				{
				}
				num = (short)1126236160;
				short num2 = num;
				num = (short)1293981614;
				short num3 = num;
				num = (short)847484846;
				switch (num3 == num)
				{
				}
				num = (short)1783037952;
				if (num != 0)
				{
				}
				this.trkPerFeaturesHazardZoneModePersonality.Valid = value;
			}
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x060018D6 RID: 6358 RVA: 0x0019A664 File Offset: 0x00198864
		// (set) Token: 0x060018D7 RID: 6359 RVA: 0x0019A71C File Offset: 0x0019891C
		public bool TrkPerFeaturesHazardZoneModePersonality_Visible
		{
			get
			{
				short num = (short)2141231383;
				short num2 = num;
				num = (short)1155373335;
				switch (num2 == num)
				{
				default:
				{
					num = (short)289865728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2139881472;
				if (num != 0)
				{
				}
				num = (short)2119303169;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesHazardZoneModePersonality.Visible;
			}
			set
			{
				short num = (short)2050995243;
				short num2 = num;
				num = (short)227390507;
				switch (num2 == num)
				{
				default:
				{
					num = (short)128581632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)744488960;
				if (num != 0)
				{
				}
				num = (short)1791754241;
				if (num != 0)
				{
				}
				this.trkPerFeaturesHazardZoneModePersonality.Visible = value;
			}
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x060018D8 RID: 6360 RVA: 0x0019A7D0 File Offset: 0x001989D0
		// (set) Token: 0x060018D9 RID: 6361 RVA: 0x0019A884 File Offset: 0x00198A84
		public bool TrkPerFeaturesHazardZoneModePersonality_Editable
		{
			get
			{
				short num = (short)2006805703;
				short num2 = num;
				num = (short)717909191;
				switch (num2 == num)
				{
				default:
				{
					num = (short)385613824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)845348865;
				if (num != 0)
				{
				}
				num = (short)18350080;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesHazardZoneModePersonality.Editable;
			}
			set
			{
				short num = (short)1594944148;
				short num2 = num;
				num = (short)1914038932;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2043019264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1494745089;
				if (num != 0)
				{
				}
				num = (short)1313406976;
				if (num != 0)
				{
				}
				this.trkPerFeaturesHazardZoneModePersonality.Editable = value;
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x060018DA RID: 6362 RVA: 0x0019A938 File Offset: 0x00198B38
		internal string TrkPerFeaturesHazardZoneModePersonality_UILabel
		{
			get
			{
				short num = (short)2073280224;
				short num2 = num;
				num = (short)1493548768;
				switch (num2 == num)
				{
				default:
				{
					num = (short)794820608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1488715776;
				if (num != 0)
				{
				}
				num = (short)134676481;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesHazardZoneModePersonality.UIName;
			}
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x060018DB RID: 6363 RVA: 0x0019A9EC File Offset: 0x00198BEC
		// (set) Token: 0x060018DC RID: 6364 RVA: 0x0019AAA0 File Offset: 0x00198CA0
		internal bool TrkPerFeaturesHazardZoneModePersonality_HiddenStatic
		{
			get
			{
				short num = (short)538415128;
				short num2 = num;
				num = (short)859541528;
				switch (num2 == num)
				{
				default:
				{
					num = (short)297467904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)774701057;
				if (num != 0)
				{
				}
				num = (short)1551302656;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesHazardZoneModePersonality.HiddenStatic;
			}
			set
			{
				short num = (short)858325303;
				short num2 = num;
				num = (short)1210188087;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1046872064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)224133121;
				if (num != 0)
				{
				}
				num = (short)1994915840;
				if (num != 0)
				{
				}
				this.trkPerFeaturesHazardZoneModePersonality.HiddenStatic = value;
			}
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x060018DD RID: 6365 RVA: 0x0019AB54 File Offset: 0x00198D54
		// (set) Token: 0x060018DE RID: 6366 RVA: 0x0019AC08 File Offset: 0x00198E08
		internal bool TrkPerFeaturesHazardZoneModePersonality_HiddenDynamic
		{
			get
			{
				short num = (short)827708099;
				short num2 = num;
				num = (short)1530647235;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1892810752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1214185473;
				if (num != 0)
				{
				}
				num = (short)603258880;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesHazardZoneModePersonality.HiddenDynamic;
			}
			set
			{
				short num = (short)1268404075;
				short num2 = num;
				num = (short)1473531755;
				switch (num2 == num)
				{
				default:
				{
					num = (short)676528128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)5439488;
				if (num != 0)
				{
				}
				num = (short)1795031041;
				if (num != 0)
				{
				}
				this.trkPerFeaturesHazardZoneModePersonality.HiddenDynamic = value;
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x060018DF RID: 6367 RVA: 0x0019ACBC File Offset: 0x00198EBC
		public bool TrkPerFeaturesHazardZoneModePersonality_HasDiffs
		{
			get
			{
				short num = (short)998754019;
				short num2 = num;
				num = (short)531220195;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1194917888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)973340673;
				if (num != 0)
				{
				}
				num = (short)2071330816;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesHazardZoneModePersonality._HasDiffs;
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x060018E0 RID: 6368 RVA: 0x0019AD70 File Offset: 0x00198F70
		// (set) Token: 0x060018E1 RID: 6369 RVA: 0x0019AE24 File Offset: 0x00199024
		public bool TrkPerFeaturesTacticalPublicSafetyUIEnableValue
		{
			get
			{
				short num = (short)679608321;
				if (num != 0)
				{
				}
				num = (short)1009844224;
				short num2 = num;
				num = (short)562910603;
				short num3 = num;
				num = (short)31675787;
				switch (num3 == num)
				{
				}
				num = (short)417792000;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesTacticalPublicSafetyUIEnable.Value;
			}
			set
			{
				short num = (short)824246273;
				if (num != 0)
				{
				}
				num = (short)1234173952;
				short num2 = num;
				num = (short)745119839;
				short num3 = num;
				num = (short)792895583;
				switch (num3 == num)
				{
				}
				num = (short)2077622272;
				if (num != 0)
				{
				}
				this.trkPerFeaturesTacticalPublicSafetyUIEnable.Value = value;
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x060018E2 RID: 6370 RVA: 0x0019AED8 File Offset: 0x001990D8
		public global::AcpBusinessLayer.AcpField<bool> TrkPerFeaturesTacticalPublicSafetyUIEnable
		{
			get
			{
				short num = (short)1945695190;
				short num2 = num;
				num = (short)247395286;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1781792768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1629749248;
				if (num != 0)
				{
				}
				num = (short)598016001;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesTacticalPublicSafetyUIEnable;
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x060018E3 RID: 6371 RVA: 0x0019AF8C File Offset: 0x0019918C
		// (set) Token: 0x060018E4 RID: 6372 RVA: 0x0019B040 File Offset: 0x00199240
		public bool TrkPerFeaturesTacticalPublicSafetyUIEnable_UIValue
		{
			get
			{
				short num = (short)690904349;
				short num2 = num;
				num = (short)1718312221;
				switch (num2 == num)
				{
				default:
				{
					num = (short)282132480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1547436032;
				if (num != 0)
				{
				}
				num = (short)490209281;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesTacticalPublicSafetyUIEnable.Value;
			}
			set
			{
				short num = (short)1494832664;
				short num2 = num;
				num = (short)964187672;
				switch (num2 == num)
				{
				default:
				{
					num = (short)409665536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1741619200;
				if (num != 0)
				{
				}
				num = (short)2034040833;
				if (num != 0)
				{
				}
				this.trkPerFeaturesTacticalPublicSafetyUIEnable.Value = value;
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x060018E5 RID: 6373 RVA: 0x0019B0F8 File Offset: 0x001992F8
		// (set) Token: 0x060018E6 RID: 6374 RVA: 0x0019B1AC File Offset: 0x001993AC
		public bool TrkPerFeaturesTacticalPublicSafetyUIEnable_Applicable
		{
			get
			{
				short num = (short)435486721;
				if (num != 0)
				{
				}
				num = (short)1748631552;
				short num2 = num;
				num = (short)1943767130;
				short num3 = num;
				num = (short)1199671386;
				switch (num3 == num)
				{
				}
				num = (short)1823932416;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesTacticalPublicSafetyUIEnable.Applicable;
			}
			set
			{
				short num = (short)456294199;
				short num2 = num;
				num = (short)1869512503;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1639251968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2123300865;
				if (num != 0)
				{
				}
				num = (short)510656512;
				if (num != 0)
				{
				}
				this.trkPerFeaturesTacticalPublicSafetyUIEnable.Applicable = value;
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x060018E7 RID: 6375 RVA: 0x0019B264 File Offset: 0x00199464
		// (set) Token: 0x060018E8 RID: 6376 RVA: 0x0019B318 File Offset: 0x00199518
		public bool TrkPerFeaturesTacticalPublicSafetyUIEnable_Valid
		{
			get
			{
				short num = (short)1887667741;
				short num2 = num;
				num = (short)2116650525;
				switch (num2 == num)
				{
				default:
				{
					num = (short)653197312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1062600705;
				if (num != 0)
				{
				}
				num = (short)204865536;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesTacticalPublicSafetyUIEnable.Valid;
			}
			set
			{
				short num = (short)1832089938;
				short num2 = num;
				num = (short)768899410;
				switch (num2 == num)
				{
				default:
				{
					num = (short)389545984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1108279296;
				if (num != 0)
				{
				}
				num = (short)1548156929;
				if (num != 0)
				{
				}
				this.trkPerFeaturesTacticalPublicSafetyUIEnable.Valid = value;
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x060018E9 RID: 6377 RVA: 0x0019B3D0 File Offset: 0x001995D0
		// (set) Token: 0x060018EA RID: 6378 RVA: 0x0019B484 File Offset: 0x00199684
		public bool TrkPerFeaturesTacticalPublicSafetyUIEnable_Visible
		{
			get
			{
				short num = (short)129351926;
				short num2 = num;
				num = (short)1151451382;
				switch (num2 == num)
				{
				default:
				{
					num = (short)390529024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1741684737;
				if (num != 0)
				{
				}
				num = (short)359333888;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesTacticalPublicSafetyUIEnable.Visible;
			}
			set
			{
				short num = (short)1125039793;
				short num2 = num;
				num = (short)875740849;
				switch (num2 == num)
				{
				default:
				{
					num = (short)448856064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1173684225;
				if (num != 0)
				{
				}
				num = (short)964820992;
				if (num != 0)
				{
				}
				this.trkPerFeaturesTacticalPublicSafetyUIEnable.Visible = value;
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x060018EB RID: 6379 RVA: 0x0019B53C File Offset: 0x0019973C
		// (set) Token: 0x060018EC RID: 6380 RVA: 0x0019B5F0 File Offset: 0x001997F0
		public bool TrkPerFeaturesTacticalPublicSafetyUIEnable_Editable
		{
			get
			{
				short num = (short)1176391162;
				short num2 = num;
				num = (short)333794810;
				switch (num2 == num)
				{
				}
				num = (short)238092288;
				short num3 = num;
				num = (short)257818624;
				if (num != 0)
				{
				}
				num = (short)482738177;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesTacticalPublicSafetyUIEnable.Editable;
			}
			set
			{
				short num = (short)1536289161;
				short num2 = num;
				num = (short)355199369;
				switch (num2 == num)
				{
				}
				num = (short)1947926528;
				short num3 = num;
				num = (short)1769209857;
				if (num != 0)
				{
				}
				num = (short)1875509248;
				if (num != 0)
				{
				}
				this.trkPerFeaturesTacticalPublicSafetyUIEnable.Editable = value;
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x0019B6A0 File Offset: 0x001998A0
		internal string TrkPerFeaturesTacticalPublicSafetyUIEnable_UILabel
		{
			get
			{
				short num = (short)308174777;
				short num2 = num;
				num = (short)399007673;
				switch (num2 == num)
				{
				}
				num = (short)1195442176;
				short num3 = num;
				num = (short)1004404736;
				if (num != 0)
				{
				}
				num = (short)155123713;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesTacticalPublicSafetyUIEnable.UIName;
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x060018EE RID: 6382 RVA: 0x0019B754 File Offset: 0x00199954
		// (set) Token: 0x060018EF RID: 6383 RVA: 0x0019B808 File Offset: 0x00199A08
		internal bool TrkPerFeaturesTacticalPublicSafetyUIEnable_HiddenStatic
		{
			get
			{
				short num = (short)2021720065;
				if (num != 0)
				{
				}
				num = (short)1938294240;
				short num2 = num;
				num = (short)1229063648;
				switch (num2 == num)
				{
				default:
				{
					num = (short)152174592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)546635776;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesTacticalPublicSafetyUIEnable.HiddenStatic;
			}
			set
			{
				short num = (short)1735936022;
				short num2 = num;
				num = (short)426854422;
				switch (num2 == num)
				{
				}
				num = (short)1974403072;
				short num3 = num;
				num = (short)1664679937;
				if (num != 0)
				{
				}
				num = (short)281542656;
				if (num != 0)
				{
				}
				this.trkPerFeaturesTacticalPublicSafetyUIEnable.HiddenStatic = value;
			}
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x060018F0 RID: 6384 RVA: 0x0019B8C0 File Offset: 0x00199AC0
		// (set) Token: 0x060018F1 RID: 6385 RVA: 0x0019B970 File Offset: 0x00199B70
		internal bool TrkPerFeaturesTacticalPublicSafetyUIEnable_HiddenDynamic
		{
			get
			{
				short num = (short)1866545750;
				short num2 = num;
				num = (short)964115030;
				switch (num2 == num)
				{
				}
				num = (short)1593049088;
				short num3 = num;
				num = (short)2121007104;
				if (num != 0)
				{
				}
				num = (short)1322123265;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesTacticalPublicSafetyUIEnable.HiddenDynamic;
			}
			set
			{
				short num = (short)640840515;
				short num2 = num;
				num = (short)1860203331;
				switch (num2 == num)
				{
				}
				num = (short)1361510400;
				short num3 = num;
				num = (short)637730817;
				if (num != 0)
				{
				}
				num = (short)1003290624;
				if (num != 0)
				{
				}
				this.trkPerFeaturesTacticalPublicSafetyUIEnable.HiddenDynamic = value;
			}
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x060018F2 RID: 6386 RVA: 0x0019BA20 File Offset: 0x00199C20
		public bool TrkPerFeaturesTacticalPublicSafetyUIEnable_HasDiffs
		{
			get
			{
				short num = (short)1756671845;
				short num2 = num;
				num = (short)1782886245;
				switch (num2 == num)
				{
				}
				num = (short)833355776;
				short num3 = num;
				num = (short)1494417409;
				if (num != 0)
				{
				}
				num = (short)1224015872;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesTacticalPublicSafetyUIEnable._HasDiffs;
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x060018F3 RID: 6387 RVA: 0x0019BAD8 File Offset: 0x00199CD8
		// (set) Token: 0x060018F4 RID: 6388 RVA: 0x0019BB8C File Offset: 0x00199D8C
		public bool TrkPerFeatureDTMFMicEn_A42482Value
		{
			get
			{
				short num = (short)1346159216;
				short num2 = num;
				num = (short)511951472;
				switch (num2 == num)
				{
				}
				num = (short)1359085568;
				short num3 = num;
				num = (short)1159659521;
				if (num != 0)
				{
				}
				num = (short)1025572864;
				if (num != 0)
				{
				}
				return this.trkPerFeatureDTMFMicEn_A42482.Value;
			}
			set
			{
				short num = (short)439287581;
				short num2 = num;
				num = (short)1612054301;
				switch (num2 == num)
				{
				}
				num = (short)1762197504;
				short num3 = num;
				num = (short)1027342337;
				if (num != 0)
				{
				}
				num = (short)1120272384;
				if (num != 0)
				{
				}
				this.trkPerFeatureDTMFMicEn_A42482.Value = value;
			}
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x060018F5 RID: 6389 RVA: 0x0019BC40 File Offset: 0x00199E40
		public global::AcpBusinessLayer.AcpField<bool> TrkPerFeatureDTMFMicEn_A42482
		{
			get
			{
				short num = (short)1973485569;
				if (num != 0)
				{
				}
				num = (short)639534203;
				short num2 = num;
				num = (short)531334267;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1540620288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)937951232;
				if (num != 0)
				{
				}
				return this.trkPerFeatureDTMFMicEn_A42482;
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x0019BCF4 File Offset: 0x00199EF4
		// (set) Token: 0x060018F7 RID: 6391 RVA: 0x0019BDAC File Offset: 0x00199FAC
		public bool TrkPerFeatureDTMFMicEn_A42482_UIValue
		{
			get
			{
				short num = (short)2105819687;
				short num2 = num;
				num = (short)124011047;
				switch (num2 == num)
				{
				}
				num = (short)994705408;
				short num3 = num;
				num = (short)2072510465;
				if (num != 0)
				{
				}
				num = (short)956366848;
				if (num != 0)
				{
				}
				return this.trkPerFeatureDTMFMicEn_A42482.Value;
			}
			set
			{
				short num = (short)380965433;
				short num2 = num;
				num = (short)1387860537;
				switch (num2 == num)
				{
				}
				num = (short)1270546432;
				short num3 = num;
				num = (short)857669632;
				if (num != 0)
				{
				}
				num = (short)662437889;
				if (num != 0)
				{
				}
				this.trkPerFeatureDTMFMicEn_A42482.Value = value;
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x0019BE60 File Offset: 0x0019A060
		// (set) Token: 0x060018F9 RID: 6393 RVA: 0x0019BF18 File Offset: 0x0019A118
		public bool TrkPerFeatureDTMFMicEn_A42482_Applicable
		{
			get
			{
				short num = (short)1213661185;
				if (num != 0)
				{
				}
				num = (short)2034046336;
				short num2 = num;
				num = (short)988026240;
				switch (num2 == num)
				{
				default:
				{
					num = (short)205717504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1195835392;
				if (num != 0)
				{
				}
				return this.trkPerFeatureDTMFMicEn_A42482.Applicable;
			}
			set
			{
				short num = (short)865413643;
				short num2 = num;
				num = (short)3877387;
				switch (num2 == num)
				{
				}
				num = (short)906625024;
				short num3 = num;
				num = (short)764805121;
				if (num != 0)
				{
				}
				num = (short)1593573376;
				if (num != 0)
				{
				}
				this.trkPerFeatureDTMFMicEn_A42482.Applicable = value;
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x0019BFCC File Offset: 0x0019A1CC
		// (set) Token: 0x060018FB RID: 6395 RVA: 0x0019C07C File Offset: 0x0019A27C
		public bool TrkPerFeatureDTMFMicEn_A42482_Valid
		{
			get
			{
				short num = (short)1935367478;
				short num2 = num;
				num = (short)1710251318;
				switch (num2 == num)
				{
				}
				num = (short)1849753600;
				short num3 = num;
				num = (short)1335951361;
				if (num != 0)
				{
				}
				num = (short)2083782656;
				if (num != 0)
				{
				}
				return this.trkPerFeatureDTMFMicEn_A42482.Valid;
			}
			set
			{
				short num = (short)1591009444;
				short num2 = num;
				num = (short)303030436;
				switch (num2 == num)
				{
				}
				num = (short)2126315520;
				short num3 = num;
				num = (short)506658817;
				if (num != 0)
				{
				}
				num = (short)1149829120;
				if (num != 0)
				{
				}
				this.trkPerFeatureDTMFMicEn_A42482.Valid = value;
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x0019C130 File Offset: 0x0019A330
		// (set) Token: 0x060018FD RID: 6397 RVA: 0x0019C1E4 File Offset: 0x0019A3E4
		public bool TrkPerFeatureDTMFMicEn_A42482_Visible
		{
			get
			{
				short num = (short)1919476964;
				short num2 = num;
				num = (short)551216356;
				switch (num2 == num)
				{
				}
				num = (short)1901854720;
				short num3 = num;
				num = (short)1238761473;
				if (num != 0)
				{
				}
				num = (short)921436160;
				if (num != 0)
				{
				}
				return this.trkPerFeatureDTMFMicEn_A42482.Visible;
			}
			set
			{
				short num = (short)1493790765;
				short num2 = num;
				num = (short)1081962541;
				switch (num2 == num)
				{
				}
				num = (short)2118647808;
				short num3 = num;
				num = (short)1468268545;
				if (num != 0)
				{
				}
				num = (short)507052032;
				if (num != 0)
				{
				}
				this.trkPerFeatureDTMFMicEn_A42482.Visible = value;
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x060018FE RID: 6398 RVA: 0x0019C29C File Offset: 0x0019A49C
		// (set) Token: 0x060018FF RID: 6399 RVA: 0x0019C350 File Offset: 0x0019A550
		public bool TrkPerFeatureDTMFMicEn_A42482_Editable
		{
			get
			{
				short num = (short)1177469823;
				short num2 = num;
				num = (short)263111551;
				switch (num2 == num)
				{
				}
				num = (short)1592852480;
				short num3 = num;
				num = (short)1249837056;
				if (num != 0)
				{
				}
				num = (short)1949171713;
				if (num != 0)
				{
				}
				return this.trkPerFeatureDTMFMicEn_A42482.Editable;
			}
			set
			{
				short num = (short)1444544513;
				if (num != 0)
				{
				}
				num = (short)819474362;
				short num2 = num;
				num = (short)1631530938;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1606615040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)584056832;
				if (num != 0)
				{
				}
				this.trkPerFeatureDTMFMicEn_A42482.Editable = value;
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x0019C404 File Offset: 0x0019A604
		internal string TrkPerFeatureDTMFMicEn_A42482_UILabel
		{
			get
			{
				short num = (short)735571181;
				short num2 = num;
				num = (short)1551887597;
				switch (num2 == num)
				{
				}
				num = (short)562233344;
				short num3 = num;
				num = (short)1571880961;
				if (num != 0)
				{
				}
				num = (short)1584463872;
				if (num != 0)
				{
				}
				return this.trkPerFeatureDTMFMicEn_A42482.UIName;
			}
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x06001901 RID: 6401 RVA: 0x0019C4B8 File Offset: 0x0019A6B8
		// (set) Token: 0x06001902 RID: 6402 RVA: 0x0019C56C File Offset: 0x0019A76C
		internal bool TrkPerFeatureDTMFMicEn_A42482_HiddenStatic
		{
			get
			{
				short num = (short)2130743869;
				short num2 = num;
				num = (short)2075562557;
				switch (num2 == num)
				{
				}
				num = (short)1459421184;
				short num3 = num;
				num = (short)506724352;
				if (num != 0)
				{
				}
				num = (short)553385985;
				if (num != 0)
				{
				}
				return this.trkPerFeatureDTMFMicEn_A42482.HiddenStatic;
			}
			set
			{
				short num = (short)493693739;
				short num2 = num;
				num = (short)551758635;
				switch (num2 == num)
				{
				}
				num = (short)701759488;
				short num3 = num;
				num = (short)1381695489;
				if (num != 0)
				{
				}
				num = (short)900661248;
				if (num != 0)
				{
				}
				this.trkPerFeatureDTMFMicEn_A42482.HiddenStatic = value;
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06001903 RID: 6403 RVA: 0x0019C624 File Offset: 0x0019A824
		// (set) Token: 0x06001904 RID: 6404 RVA: 0x0019C6DC File Offset: 0x0019A8DC
		internal bool TrkPerFeatureDTMFMicEn_A42482_HiddenDynamic
		{
			get
			{
				short num = (short)2126446593;
				if (num != 0)
				{
				}
				num = (short)1448889890;
				short num2 = num;
				num = (short)1711164962;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1223163904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)776863744;
				if (num != 0)
				{
				}
				return this.trkPerFeatureDTMFMicEn_A42482.HiddenDynamic;
			}
			set
			{
				short num = (short)1851617943;
				short num2 = num;
				num = (short)1952674455;
				switch (num2 == num)
				{
				}
				num = (short)63373312;
				short num3 = num;
				num = (short)520093697;
				if (num != 0)
				{
				}
				num = (short)481755136;
				if (num != 0)
				{
				}
				this.trkPerFeatureDTMFMicEn_A42482.HiddenDynamic = value;
			}
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x06001905 RID: 6405 RVA: 0x0019C790 File Offset: 0x0019A990
		public bool TrkPerFeatureDTMFMicEn_A42482_HasDiffs
		{
			get
			{
				short num = (short)2055469209;
				short num2 = num;
				num = (short)2044983449;
				switch (num2 == num)
				{
				}
				num = (short)994246656;
				short num3 = num;
				num = (short)1534459904;
				if (num != 0)
				{
				}
				num = (short)711393281;
				if (num != 0)
				{
				}
				return this.trkPerFeatureDTMFMicEn_A42482._HasDiffs;
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x0019C844 File Offset: 0x0019AA44
		// (set) Token: 0x06001907 RID: 6407 RVA: 0x0019C8F8 File Offset: 0x0019AAF8
		public int TrkPerFeaturesPriorityDispatchTimeOutTimersec_43598Value
		{
			get
			{
				short num = (short)1107366368;
				short num2 = num;
				num = (short)2117407200;
				switch (num2 == num)
				{
				}
				num = (short)169017344;
				short num3 = num;
				num = (short)468844545;
				if (num != 0)
				{
				}
				num = (short)1981874176;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.Value;
			}
			set
			{
				short num = (short)131180881;
				short num2 = num;
				num = (short)2073733457;
				switch (num2 == num)
				{
				}
				num = (short)1464139776;
				short num3 = num;
				num = (short)842334209;
				if (num != 0)
				{
				}
				num = (short)129761280;
				if (num != 0)
				{
				}
				this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.Value = value;
			}
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x0019C9B0 File Offset: 0x0019ABB0
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkPerFeaturesPriorityDispatchTimeOutTimersec_43598
		{
			get
			{
				short num = (short)1241255350;
				short num2 = num;
				num = (short)351210934;
				switch (num2 == num)
				{
				}
				num = (short)748486656;
				short num3 = num;
				num = (short)1031602176;
				if (num != 0)
				{
				}
				num = (short)1464598529;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598;
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x06001909 RID: 6409 RVA: 0x0019CA60 File Offset: 0x0019AC60
		// (set) Token: 0x0600190A RID: 6410 RVA: 0x0019CB14 File Offset: 0x0019AD14
		public string TrkPerFeaturesPriorityDispatchTimeOutTimersec_43598_UIValue
		{
			get
			{
				short num = (short)654033456;
				short num2 = num;
				num = (short)547406384;
				switch (num2 == num)
				{
				}
				num = (short)2129592320;
				short num3 = num;
				num = (short)542310401;
				if (num != 0)
				{
				}
				num = (short)1150484480;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.UIValue;
			}
			set
			{
				short num = (short)707100240;
				short num2 = num;
				num = (short)1937145424;
				switch (num2 == num)
				{
				}
				num = (short)1181679616;
				short num3 = num;
				num = (short)1860763648;
				if (num != 0)
				{
				}
				num = (short)864223233;
				if (num != 0)
				{
				}
				this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.UIValue = value;
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x0600190B RID: 6411 RVA: 0x0019CBCC File Offset: 0x0019ADCC
		// (set) Token: 0x0600190C RID: 6412 RVA: 0x0019CC80 File Offset: 0x0019AE80
		internal int TrkPerFeaturesPriorityDispatchTimeOutTimersec_43598Min
		{
			get
			{
				short num = (short)877590528;
				short num2 = num;
				num = (short)1769601024;
				switch (num2 == num)
				{
				}
				num = (short)1978925056;
				short num3 = num;
				num = (short)1842675713;
				if (num != 0)
				{
				}
				num = (short)1127219200;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.Min;
			}
			set
			{
				short num = (short)1717491964;
				short num2 = num;
				num = (short)760666364;
				switch (num2 == num)
				{
				}
				num = (short)283443200;
				short num3 = num;
				num = (short)2112618497;
				if (num != 0)
				{
				}
				num = (short)2084110336;
				if (num != 0)
				{
				}
				this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.Min = value;
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x0600190D RID: 6413 RVA: 0x0019CD34 File Offset: 0x0019AF34
		// (set) Token: 0x0600190E RID: 6414 RVA: 0x0019CDE8 File Offset: 0x0019AFE8
		internal int TrkPerFeaturesPriorityDispatchTimeOutTimersec_43598Max
		{
			get
			{
				short num = (short)866011932;
				short num2 = num;
				num = (short)1575308060;
				switch (num2 == num)
				{
				}
				num = (short)67305472;
				short num3 = num;
				num = (short)205193216;
				if (num != 0)
				{
				}
				num = (short)1396899841;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.Max;
			}
			set
			{
				short num = (short)1130482337;
				short num2 = num;
				num = (short)409062049;
				switch (num2 == num)
				{
				}
				num = (short)1781989376;
				short num3 = num;
				num = (short)1361248257;
				if (num != 0)
				{
				}
				num = (short)1694498816;
				if (num != 0)
				{
				}
				this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.Max = value;
			}
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x0600190F RID: 6415 RVA: 0x0019CEA0 File Offset: 0x0019B0A0
		// (set) Token: 0x06001910 RID: 6416 RVA: 0x0019CF54 File Offset: 0x0019B154
		internal int TrkPerFeaturesPriorityDispatchTimeOutTimersec_43598Step
		{
			get
			{
				short num = (short)1231686925;
				short num2 = num;
				num = (short)1004080397;
				switch (num2 == num)
				{
				}
				num = (short)1819344896;
				short num3 = num;
				num = (short)1591083009;
				if (num != 0)
				{
				}
				num = (short)1386217472;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.StepSize;
			}
			set
			{
				short num = (short)35972275;
				short num2 = num;
				num = (short)1824908467;
				switch (num2 == num)
				{
				}
				num = (short)1565851648;
				short num3 = num;
				num = (short)178913281;
				if (num != 0)
				{
				}
				num = (short)1267597312;
				if (num != 0)
				{
				}
				this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.StepSize = value;
			}
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x06001911 RID: 6417 RVA: 0x0019D00C File Offset: 0x0019B20C
		// (set) Token: 0x06001912 RID: 6418 RVA: 0x0019D0C0 File Offset: 0x0019B2C0
		public bool TrkPerFeaturesPriorityDispatchTimeOutTimersec_43598_Applicable
		{
			get
			{
				short num = (short)1865119434;
				short num2 = num;
				num = (short)1584101066;
				switch (num2 == num)
				{
				}
				num = (short)486146048;
				short num3 = num;
				num = (short)1098383360;
				if (num != 0)
				{
				}
				num = (short)240844801;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.Applicable;
			}
			set
			{
				short num = (short)1223120321;
				short num2 = num;
				num = (short)935613889;
				switch (num2 == num)
				{
				}
				num = (short)2127429632;
				short num3 = num;
				num = (short)822280193;
				if (num != 0)
				{
				}
				num = (short)1099694080;
				if (num != 0)
				{
				}
				this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.Applicable = value;
			}
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x06001913 RID: 6419 RVA: 0x0019D174 File Offset: 0x0019B374
		// (set) Token: 0x06001914 RID: 6420 RVA: 0x0019D228 File Offset: 0x0019B428
		public bool TrkPerFeaturesPriorityDispatchTimeOutTimersec_43598_Valid
		{
			get
			{
				short num = (short)1785761268;
				short num2 = num;
				num = (short)1893109236;
				switch (num2 == num)
				{
				}
				num = (short)1518469120;
				short num3 = num;
				num = (short)1976827904;
				if (num != 0)
				{
				}
				num = (short)748486657;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.Valid;
			}
			set
			{
				short num = (short)882910046;
				short num2 = num;
				num = (short)912139102;
				switch (num2 == num)
				{
				}
				num = (short)1280901120;
				short num3 = num;
				num = (short)1784283137;
				if (num != 0)
				{
				}
				num = (short)1772224512;
				if (num != 0)
				{
				}
				this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.Valid = value;
			}
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x0019D2DC File Offset: 0x0019B4DC
		// (set) Token: 0x06001916 RID: 6422 RVA: 0x0019D394 File Offset: 0x0019B594
		public bool TrkPerFeaturesPriorityDispatchTimeOutTimersec_43598_Visible
		{
			get
			{
				short num = (short)2088471803;
				short num2 = num;
				num = (short)694652155;
				switch (num2 == num)
				{
				}
				num = (short)1829109760;
				short num3 = num;
				num = (short)1244332033;
				if (num != 0)
				{
				}
				num = (short)320471040;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.Visible;
			}
			set
			{
				short num = (short)1463222273;
				if (num != 0)
				{
				}
				num = (short)140429254;
				short num2 = num;
				num = (short)894683078;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1884356608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2115764224;
				if (num != 0)
				{
				}
				this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.Visible = value;
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06001917 RID: 6423 RVA: 0x0019D448 File Offset: 0x0019B648
		// (set) Token: 0x06001918 RID: 6424 RVA: 0x0019D4FC File Offset: 0x0019B6FC
		public bool TrkPerFeaturesPriorityDispatchTimeOutTimersec_43598_Editable
		{
			get
			{
				short num = (short)1336344577;
				if (num != 0)
				{
				}
				num = (short)546230543;
				short num2 = num;
				num = (short)1624363279;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1231355904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1735458816;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.Editable;
			}
			set
			{
				short num = (short)306470456;
				short num2 = num;
				num = (short)721837624;
				switch (num2 == num)
				{
				}
				num = (short)1274871808;
				short num3 = num;
				num = (short)1815609345;
				if (num != 0)
				{
				}
				num = (short)1958084608;
				if (num != 0)
				{
				}
				this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.Editable = value;
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06001919 RID: 6425 RVA: 0x0019D5B4 File Offset: 0x0019B7B4
		internal string TrkPerFeaturesPriorityDispatchTimeOutTimersec_43598_UILabel
		{
			get
			{
				short num = (short)1214316545;
				if (num != 0)
				{
				}
				num = (short)566419868;
				short num2 = num;
				num = (short)373481884;
				switch (num2 == num)
				{
				default:
				{
					num = (short)83492864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)723976192;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.UIName;
			}
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x0019D66C File Offset: 0x0019B86C
		// (set) Token: 0x0600191B RID: 6427 RVA: 0x0019D720 File Offset: 0x0019B920
		internal bool TrkPerFeaturesPriorityDispatchTimeOutTimersec_43598_HiddenStatic
		{
			get
			{
				short num = (short)750405533;
				short num2 = num;
				num = (short)1871398813;
				switch (num2 == num)
				{
				}
				num = (short)1012400128;
				short num3 = num;
				num = (short)770244609;
				if (num != 0)
				{
				}
				num = (short)1409286144;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.HiddenStatic;
			}
			set
			{
				short num = (short)1233267724;
				short num2 = num;
				num = (short)1162161164;
				switch (num2 == num)
				{
				}
				num = (short)49217536;
				short num3 = num;
				num = (short)991100929;
				if (num != 0)
				{
				}
				num = (short)403636224;
				if (num != 0)
				{
				}
				this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.HiddenStatic = value;
			}
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x0600191C RID: 6428 RVA: 0x0019D7D4 File Offset: 0x0019B9D4
		// (set) Token: 0x0600191D RID: 6429 RVA: 0x0019D888 File Offset: 0x0019BA88
		internal bool TrkPerFeaturesPriorityDispatchTimeOutTimersec_43598_HiddenDynamic
		{
			get
			{
				short num = (short)63449891;
				short num2 = num;
				num = (short)2103847715;
				switch (num2 == num)
				{
				}
				num = (short)1609433088;
				short num3 = num;
				num = (short)559611904;
				if (num != 0)
				{
				}
				num = (short)1543241729;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.HiddenDynamic;
			}
			set
			{
				short num = (short)633118354;
				short num2 = num;
				num = (short)90873490;
				switch (num2 == num)
				{
				}
				num = (short)2125135872;
				short num3 = num;
				num = (short)669384705;
				if (num != 0)
				{
				}
				num = (short)713424896;
				if (num != 0)
				{
				}
				this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598.HiddenDynamic = value;
			}
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x0019D93C File Offset: 0x0019BB3C
		public bool TrkPerFeaturesPriorityDispatchTimeOutTimersec_43598_HasDiffs
		{
			get
			{
				short num = (short)1274257720;
				short num2 = num;
				num = (short)1037672760;
				switch (num2 == num)
				{
				}
				num = (short)820117504;
				short num3 = num;
				num = (short)1427046401;
				if (num != 0)
				{
				}
				num = (short)1000669184;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesPriorityDispatchTimeOutTimersec_43598._HasDiffs;
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x0600191F RID: 6431 RVA: 0x0019D9F0 File Offset: 0x0019BBF0
		// (set) Token: 0x06001920 RID: 6432 RVA: 0x0019DAA0 File Offset: 0x0019BCA0
		public int TrkPerFeatureBackupPTTOperation_A43628Value
		{
			get
			{
				short num = (short)1587284260;
				short num2 = num;
				num = (short)2002258212;
				switch (num2 == num)
				{
				}
				num = (short)945291264;
				short num3 = num;
				num = (short)2094858241;
				if (num != 0)
				{
				}
				num = (short)594149376;
				if (num != 0)
				{
				}
				return this.trkPerFeatureBackupPTTOperation_A43628.Value;
			}
			set
			{
				short num = (short)934477174;
				short num2 = num;
				num = (short)1350499702;
				switch (num2 == num)
				{
				}
				num = (short)1680736256;
				short num3 = num;
				num = (short)426049536;
				if (num != 0)
				{
				}
				num = (short)1783103489;
				if (num != 0)
				{
				}
				this.trkPerFeatureBackupPTTOperation_A43628.Value = value;
			}
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x06001921 RID: 6433 RVA: 0x0019DB54 File Offset: 0x0019BD54
		// (set) Token: 0x06001922 RID: 6434 RVA: 0x0019DC08 File Offset: 0x0019BE08
		public string TrkPerFeatureBackupPTTOperation_A43628_UIValue
		{
			get
			{
				short num = (short)1394839287;
				short num2 = num;
				num = (short)414027511;
				switch (num2 == num)
				{
				}
				num = (short)1393426432;
				short num3 = num;
				num = (short)1861025793;
				if (num != 0)
				{
				}
				num = (short)1485373440;
				if (num != 0)
				{
				}
				return this.trkPerFeatureBackupPTTOperation_A43628.UIValue;
			}
			set
			{
				short num = (short)508821504;
				short num2 = num;
				num = (short)330588429;
				short num3 = num;
				num = (short)584999181;
				switch (num3 == num)
				{
				}
				num = (short)169607169;
				if (num != 0)
				{
				}
				num = (short)1627848704;
				if (num != 0)
				{
				}
				this.trkPerFeatureBackupPTTOperation_A43628.UIValue = value;
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x06001923 RID: 6435 RVA: 0x0019DCBC File Offset: 0x0019BEBC
		public global::AcpBusinessLayer.AcpListField TrkPerFeatureBackupPTTOperation_A43628
		{
			get
			{
				short num = (short)1190920192;
				short num2 = num;
				num = (short)681137996;
				short num3 = num;
				num = (short)970544972;
				switch (num3 == num)
				{
				}
				num = (short)52101121;
				if (num != 0)
				{
				}
				num = (short)922091520;
				if (num != 0)
				{
				}
				return this.trkPerFeatureBackupPTTOperation_A43628;
			}
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x0019DD6C File Offset: 0x0019BF6C
		// (set) Token: 0x06001925 RID: 6437 RVA: 0x0019DE20 File Offset: 0x0019C020
		public bool TrkPerFeatureBackupPTTOperation_A43628_Applicable
		{
			get
			{
				short num = (short)1636302848;
				short num2 = num;
				num = (short)647967886;
				short num3 = num;
				num = (short)1446655118;
				switch (num3 == num)
				{
				}
				num = (short)1169424385;
				if (num != 0)
				{
				}
				num = (short)668401664;
				if (num != 0)
				{
				}
				return this.trkPerFeatureBackupPTTOperation_A43628.Applicable;
			}
			set
			{
				short num = (short)1686110208;
				short num2 = num;
				num = (short)2136473601;
				if (num != 0)
				{
				}
				num = (short)1820506046;
				short num3 = num;
				num = (short)98875326;
				switch (num3 == num)
				{
				}
				num = (short)944046080;
				if (num != 0)
				{
				}
				this.trkPerFeatureBackupPTTOperation_A43628.Applicable = value;
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x0019DED8 File Offset: 0x0019C0D8
		// (set) Token: 0x06001927 RID: 6439 RVA: 0x0019DF8C File Offset: 0x0019C18C
		public bool TrkPerFeatureBackupPTTOperation_A43628_Valid
		{
			get
			{
				short num = (short)819200000;
				short num2 = num;
				num = (short)580638078;
				short num3 = num;
				num = (short)77845886;
				switch (num3 == num)
				{
				}
				num = (short)291569664;
				if (num != 0)
				{
				}
				num = (short)470614017;
				if (num != 0)
				{
				}
				return this.trkPerFeatureBackupPTTOperation_A43628.Valid;
			}
			set
			{
				short num = (short)1722023936;
				short num2 = num;
				num = (short)1561395201;
				if (num != 0)
				{
				}
				num = (short)859587004;
				short num3 = num;
				num = (short)563757500;
				switch (num3 == num)
				{
				}
				num = (short)710475776;
				if (num != 0)
				{
				}
				this.trkPerFeatureBackupPTTOperation_A43628.Valid = value;
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x0019E044 File Offset: 0x0019C244
		// (set) Token: 0x06001929 RID: 6441 RVA: 0x0019E0F8 File Offset: 0x0019C2F8
		public bool TrkPerFeatureBackupPTTOperation_A43628_Visible
		{
			get
			{
				short num = (short)140902400;
				short num2 = num;
				num = (short)1882652673;
				if (num != 0)
				{
				}
				num = (short)1058365794;
				short num3 = num;
				num = (short)1633575266;
				switch (num3 == num)
				{
				}
				num = (short)1221001216;
				if (num != 0)
				{
				}
				return this.trkPerFeatureBackupPTTOperation_A43628.Visible;
			}
			set
			{
				short num = (short)87949312;
				short num2 = num;
				num = (short)1396573715;
				short num3 = num;
				num = (short)1623918099;
				switch (num3 == num)
				{
				}
				num = (short)838008832;
				if (num != 0)
				{
				}
				num = (short)598278145;
				if (num != 0)
				{
				}
				this.trkPerFeatureBackupPTTOperation_A43628.Visible = value;
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x0019E1AC File Offset: 0x0019C3AC
		// (set) Token: 0x0600192B RID: 6443 RVA: 0x0019E260 File Offset: 0x0019C460
		public bool TrkPerFeatureBackupPTTOperation_A43628_Editable
		{
			get
			{
				short num = (short)599654400;
				short num2 = num;
				num = (short)441234618;
				short num3 = num;
				num = (short)668710074;
				switch (num3 == num)
				{
				}
				num = (short)414187521;
				if (num != 0)
				{
				}
				num = (short)1081540608;
				if (num != 0)
				{
				}
				return this.trkPerFeatureBackupPTTOperation_A43628.Editable;
			}
			set
			{
				short num = (short)629538816;
				short num2 = num;
				num = (short)1007369453;
				short num3 = num;
				num = (short)1649884397;
				switch (num3 == num)
				{
				}
				num = (short)296615937;
				if (num != 0)
				{
				}
				num = (short)1699282944;
				if (num != 0)
				{
				}
				this.trkPerFeatureBackupPTTOperation_A43628.Editable = value;
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x0019E314 File Offset: 0x0019C514
		internal string TrkPerFeatureBackupPTTOperation_A43628_UILabel
		{
			get
			{
				short num = (short)2088304640;
				short num2 = num;
				num = (short)1858274859;
				short num3 = num;
				num = (short)285279787;
				switch (num3 == num)
				{
				}
				num = (short)1593180161;
				if (num != 0)
				{
				}
				num = (short)1823670272;
				if (num != 0)
				{
				}
				return this.trkPerFeatureBackupPTTOperation_A43628.UIName;
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x0600192D RID: 6445 RVA: 0x0019E3CC File Offset: 0x0019C5CC
		// (set) Token: 0x0600192E RID: 6446 RVA: 0x0019E480 File Offset: 0x0019C680
		internal bool TrkPerFeatureBackupPTTOperation_A43628_HiddenStatic
		{
			get
			{
				short num = (short)1682767872;
				short num2 = num;
				num = (short)1500250113;
				if (num != 0)
				{
				}
				num = (short)1188842022;
				short num3 = num;
				num = (short)48581158;
				switch (num3 == num)
				{
				}
				num = (short)1361248256;
				if (num != 0)
				{
				}
				return this.trkPerFeatureBackupPTTOperation_A43628.HiddenStatic;
			}
			set
			{
				short num = (short)368050176;
				short num2 = num;
				num = (short)1216821564;
				short num3 = num;
				num = (short)1402091836;
				switch (num3 == num)
				{
				}
				num = (short)1834745857;
				if (num != 0)
				{
				}
				num = (short)1077805056;
				if (num != 0)
				{
				}
				this.trkPerFeatureBackupPTTOperation_A43628.HiddenStatic = value;
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x0600192F RID: 6447 RVA: 0x0019E534 File Offset: 0x0019C734
		// (set) Token: 0x06001930 RID: 6448 RVA: 0x0019E5EC File Offset: 0x0019C7EC
		internal bool TrkPerFeatureBackupPTTOperation_A43628_HiddenDynamic
		{
			get
			{
				short num = (short)375914496;
				short num2 = num;
				num = (short)411355747;
				short num3 = num;
				num = (short)1785383523;
				switch (num3 == num)
				{
				}
				num = (short)1864368129;
				if (num != 0)
				{
				}
				num = (short)501481472;
				if (num != 0)
				{
				}
				return this.trkPerFeatureBackupPTTOperation_A43628.HiddenDynamic;
			}
			set
			{
				short num = (short)1022558208;
				short num2 = num;
				num = (short)1371955049;
				short num3 = num;
				num = (short)1564565353;
				switch (num3 == num)
				{
				}
				num = (short)623771649;
				if (num != 0)
				{
				}
				num = (short)499449856;
				if (num != 0)
				{
				}
				this.trkPerFeatureBackupPTTOperation_A43628.HiddenDynamic = value;
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x0019E6A0 File Offset: 0x0019C8A0
		public bool TrkPerFeatureBackupPTTOperation_A43628_HasDiffs
		{
			get
			{
				short num = (short)1580138496;
				short num2 = num;
				num = (short)1250512936;
				short num3 = num;
				num = (short)508973096;
				switch (num3 == num)
				{
				}
				num = (short)1662058497;
				if (num != 0)
				{
				}
				num = (short)747438080;
				if (num != 0)
				{
				}
				return this.trkPerFeatureBackupPTTOperation_A43628._HasDiffs;
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x0019E758 File Offset: 0x0019C958
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide RefSecureWide
		{
			get
			{
				short num = (short)1777795072;
				short num2 = num;
				num = (short)445119472;
				short num3 = num;
				num = (short)714210288;
				switch (num3 == num)
				{
				}
				num = (short)210894849;
				if (num != 0)
				{
				}
				num = (short)1618804736;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			}
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06001933 RID: 6451 RVA: 0x0019E818 File Offset: 0x0019CA18
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide RefDVRSWide
		{
			get
			{
				short num = (short)1947336704;
				short num2 = num;
				num = (short)1148743194;
				short num3 = num;
				num = (short)813329946;
				switch (num3 == num)
				{
				}
				num = (short)1859190785;
				if (num != 0)
				{
				}
				num = (short)1340866560;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
			}
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x0019E8D8 File Offset: 0x0019CAD8
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1624637440;
				short num2 = num;
				num = (short)2004818540;
				short num3 = num;
				num = (short)650451564;
				switch (num3 == num)
				{
				}
				num = (short)1671364609;
				if (num != 0)
				{
				}
				num = (short)42205184;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x0019E998 File Offset: 0x0019CB98
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_98;
			}
			short num;
			global::AcpCommonLib.IAcpRecordset result;
			int num4;
			for (;;)
			{
				IL_0A:
				num = (short)962213258;
				short num2 = num;
				num = (short)8664458;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return result;
				default:
				{
					num = (short)2094399488;
					if (num != 0)
					{
					}
					num = (short)1850605568;
					short num3 = num;
					switch (num4)
					{
					case 0:
						if (base.ParentRecset != null)
						{
							num = (short)1531445249;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						num = (short)1598160899;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return result;
					case 3:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)1785462788;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						num = (short)2005139457;
						if (num != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)321323010;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_98;
				}
				}
			}
			return result;
			IL_98:
			result = null;
			num = (short)459538432;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x040008C9 RID: 2249
		private global::AcpBusinessLayer.AcpField<bool> trkPerFeaturesAutomaticScan_A7528;

		// Token: 0x040008CA RID: 2250
		private global::AcpBusinessLayer.AcpField<bool> trkPerFeaturesHotKeypadDTMF_A8209;

		// Token: 0x040008CB RID: 2251
		private global::AcpBusinessLayer.AcpField<bool> trkPerFeaturesMessageEnable_A8499;

		// Token: 0x040008CC RID: 2252
		private global::AcpBusinessLayer.AcpListField trkPerFeaturesPhoneOperation_A8701;

		// Token: 0x040008CD RID: 2253
		private global::AcpBusinessLayer.AcpField<bool> trkPerFeaturesSecureProperCodeDetect_A8763;

		// Token: 0x040008CE RID: 2254
		private global::AcpBusinessLayer.AcpRecRefField trkPerFeaturesScanListSelection_A9053;

		// Token: 0x040008CF RID: 2255
		private global::AcpBusinessLayer.AcpField<bool> trkPerFeaturesStatusEnable_A9188;

		// Token: 0x040008D0 RID: 2256
		private global::AcpBusinessLayer.AcpField<bool> trkPerFeaturesTalkPermitTone_A9271;

		// Token: 0x040008D1 RID: 2257
		private global::AcpBusinessLayer.AcpField<bool> trkPerIgnoreRxClearVoice_A41610;

		// Token: 0x040008D2 RID: 2258
		private global::AcpBusinessLayer.AcpField<bool> trkPerEndTxOnVoiceAbsence_42461;

		// Token: 0x040008D3 RID: 2259
		private global::AcpBusinessLayer.AcpField<bool> trkPerFeaturesHazardZoneModePersonality;

		// Token: 0x040008D4 RID: 2260
		private global::AcpBusinessLayer.AcpField<bool> trkPerFeaturesTacticalPublicSafetyUIEnable;

		// Token: 0x040008D5 RID: 2261
		private global::AcpBusinessLayer.AcpField<bool> trkPerFeatureDTMFMicEn_A42482;

		// Token: 0x040008D6 RID: 2262
		private global::AcpBusinessLayer.AcpSimpleRangeField trkPerFeaturesPriorityDispatchTimeOutTimersec_43598;

		// Token: 0x040008D7 RID: 2263
		private global::AcpBusinessLayer.AcpListField trkPerFeatureBackupPTTOperation_A43628;
	}
}
