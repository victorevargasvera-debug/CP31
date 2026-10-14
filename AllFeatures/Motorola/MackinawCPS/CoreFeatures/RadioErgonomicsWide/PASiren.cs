using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Features.Converters;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide
{
	// Token: 0x0200023B RID: 571
	[global::System.Serializable]
	public class PASiren : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060066C3 RID: 26307 RVA: 0x005BE834 File Offset: 0x005BCA34
		public PASiren(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060066C4 RID: 26308 RVA: 0x005BE850 File Offset: 0x005BCA50
		protected PASiren(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060066C5 RID: 26309 RVA: 0x005BE868 File Offset: 0x005BCA68
		public override void Init()
		{
			int a_ = 12;
			short num = (short)2085552128;
			short num2 = num;
			num = (short)1627327384;
			short num3 = num;
			num = (short)1587088280;
			switch (num3 == num)
			{
			}
			num = (short)955908097;
			if (num != 0)
			{
			}
			num = (short)5439488;
			if (num != 0)
			{
			}
			this.radErgoWidePASirenDefaultPAVolumeLevel_A7812 = new global::AcpBusinessLayer.AcpSimpleRangeField(11, this, global::AllFeatures.CodeplugGuid.b("鿌껎뗐雒꟔냖뛘賚드믞蓠돢ꓤ듦胨駪裬臮뗰雲鏴零賸韺觼꿾䀀唂樄欆簈昊栌䌎琐攒瀔笖䘘娚⨜✞ဠᄢ", a_), global::CommonResources.AcgResources.ID_PUBLICADDRESSDEFAULTPAVOLUMELEVEL, 0, 15, null, null, 0, 1);
			this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.DataTransferOrder = 13;
			this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.ShowHexValue = false;
			this.radErgoWidePASirenExternalRadioIgnition_A7992 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鿌껎뗐雒꟔냖뛘賚드믞蓠돢ꓤ듦胨駪裬臮듰诲致鋶诸闺鳼鏾匀戂愄渆昈䈊樌愎砐朒簔砖眘䐚尜⠞ᠠᨢᜤ", a_), global::CommonResources.AcgResources.ID_PUBLICADDRESSEXTERNALRADIOIGNITION);
			this.radErgoWidePASirenExternalRadioIgnition_A7992.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWidePASirenExternalRadioIgnition_A7992.DataTransferOrder = 6;
			this.radErgoWidePASirenOptionsAudioMuting_A8623 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鿌껎뗐雒꟔냖뛘賚드믞蓠돢ꓤ듦胨駪裬臮뻰菲致黶雸闺軼뻾琀朂氄栆䐈縊礌明缐琒䨔嘖℘ⴚ⼜Ⱎ", a_), global::CommonResources.AcgResources.ID_PUBLICADDRESSOPTIONSAUDIOMUTING);
			this.radErgoWidePASirenOptionsAudioMuting_A8623.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radErgoWidePASirenOptionsAudioMuting_A8623.DataTransferOrder = 9;
			this.radErgoWidePASirenPAIgnitionSense_A8683 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鿌껎뗐雒꟔냖뛘賚드믞蓠돢ꓤ듦胨駪裬臮ꇰ닲보郶韸鋺觼雾渀洂嘄戆月砊栌倎倐⬒⌔⼖⨘", a_), global::CommonResources.AcgResources.ID_PUBLICADDRESSPAIGNITIONSENSE);
			this.radErgoWidePASirenPAIgnitionSense_A8683.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWidePASirenPAIgnitionSense_A8683.DataTransferOrder = 8;
			this.radErgoWidePASirenSirenIgnitionSense_A9138 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鿌껎뗐雒꟔냖뛘賚드믞蓠돢ꓤ듦胨駪裬臮ꋰ髲蟴鋶韸닺髼釾栀眂氄栆月堊栌愎成瘒䨔嘖‘⨚⸜✞", a_), global::CommonResources.AcgResources.ID_SIRENSIRENIGNITIONSENSE);
			this.radErgoWidePASirenSirenIgnitionSense_A9138.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWidePASirenSirenIgnitionSense_A9138.DataTransferOrder = 10;
			this.radErgoWidePASirenSirenOperation_A9139 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.indexRadErgoWidePASirenSirenOperation_A9139LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.idRadErgoWidePASirenSirenOperation_A9139LovStrs), this, global::AllFeatures.CodeplugGuid.b("鿌껎뗐雒꟔냖뛘賚드믞蓠돢ꓤ듦胨駪裬臮ꋰ髲蟴鋶韸듺跼髾猀戂焄渆昈攊刌与⠐−☔⸖", a_), global::CommonResources.AcgResources.ID_SIRENOPERATION, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWidePASirenSirenOperation_A9139LovStrs);
			this.radErgoWidePASirenSirenOperation_A9139.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWidePASirenSirenOperation_A9139.DataTransferOrder = 5;
			this.radErgoWidePASirenSirenPAAfterReset_A9140 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鿌껎뗐雒꟔냖뛘賚드믞蓠돢ꓤ듦胨駪裬臮ꋰ髲蟴鋶韸꯺볼뻾最眂怄甆嬈渊縌樎攐䰒吔⸖⠘⼚ⴜ", a_), global::CommonResources.AcgResources.ID_PUBLICADDRESSSIRENPAAFTERRESET, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWidePASirenSirenPAAfterReset_A9140LovStrs);
			this.radErgoWidePASirenSirenPAAfterReset_A9140.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radErgoWidePASirenSirenPAAfterReset_A9140.DataTransferOrder = 12;
			this.radErgoWidePASirenHiLoAirhornTones_A8200 = new global::AcpBusinessLayer.AcpFieldX<bool, bool>(true, new global::Features.Converters.UnpackAndPackAndInvertBooleanField(), this, global::AllFeatures.CodeplugGuid.b("鿌껎뗐雒꟔냖뛘賚드믞蓠돢ꓤ듦胨駪裬臮맰髲맴飶룸鋺迼韾渀焂欄匆昈攊栌簎丐划ⴔ┖⤘⬚", a_), global::CommonResources.AcgResources.ID_SIRENHILOAIRHORNTONES);
			this.radErgoWidePASirenHiLoAirhornTones_A8200.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radErgoWidePASirenHiLoAirhornTones_A8200.DataTransferOrder = 7;
			this.radErgoWidePASirenManualTone_A8464 = new global::AcpBusinessLayer.AcpSparseLOVField(2, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.indexRadErgoWidePASirenManualTone_A8464LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.idRadErgoWidePASirenManualTone_A8464LovStrs), this, global::AllFeatures.CodeplugGuid.b("鿌껎뗐雒꟔냖뛘賚드믞蓠돢ꓤ듦胨駪裬臮볰鋲鯴苶飸韺ꧼ郾漀昂娄䘆ㄈ㼊㬌㬎", a_), global::CommonResources.AcgResources.ID_SIRENMANUALTONE, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWidePASirenManualTone_A8464LovStrs);
			this.radErgoWidePASirenManualTone_A8464.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radErgoWidePASirenManualTone_A8464.DataTransferOrder = 11;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鷌軎ﻐ胒볔ꗖ볘뗚", a_);
			base.Id = 10225;
			base.UIName = global::CommonResources.AcgResources.ID_PASIREN;
			base.DataTransferOrder = 3;
		}

		// Token: 0x060066C6 RID: 26310 RVA: 0x005BEB8C File Offset: 0x005BCD8C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 10;
			short num = (short)2144403472;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1416691733;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖軘닚맜뫞뇠ꋢ뛤軦鯨軪菬ꫮ觰蟲郴藶韸髺釼귾怀朂氄栆䀈氊挌明攐稒稔礖䘘娚⨜☞ᠠᄢ", a_)))
					{
						num = (short)1977417735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_54B;
				case 2:
					this.radErgoWidePASirenSirenIgnitionSense_A9138 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖軘닚맜뫞뇠ꋢ뛤軦鯨軪菬볮飰臲郴駶냸鳺鏼雾甀樂樄椆娈渊挌簎琐䰒吔⸖⠘⠚├", a_), global::CommonResources.AcgResources.ID_SIRENSIRENIGNITIONSENSE);
					this.radErgoWidePASirenSirenIgnitionSense_A9138.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWidePASirenSirenIgnitionSense_A9138.DataTransferOrder = 10;
					num = (short)1134952465;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_176;
				case 4:
					goto IL_2E0;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖軘닚맜뫞뇠ꋢ뛤軦鯨軪菬볮飰臲郴駶꧸뫺볼駾甀昂眄唆氈砊栌笎丐划Ⱄ☖ⴘ⬚", a_)))
					{
						num = (short)1510604818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C4;
				case 6:
					goto IL_1C4;
				case 7:
					this.radErgoWidePASirenExternalRadioIgnition_A7992 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖軘닚맜뫞뇠ꋢ뛤軦鯨軪菬ꫮ觰蟲郴藶韸髺釼귾怀朂氄栆䀈氊挌明攐稒稔礖䘘娚⨜☞ᠠᄢ", a_), global::CommonResources.AcgResources.ID_PUBLICADDRESSEXTERNALRADIOIGNITION);
					this.radErgoWidePASirenExternalRadioIgnition_A7992.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWidePASirenExternalRadioIgnition_A7992.DataTransferOrder = 6;
					num = (short)223739924;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖軘닚맜뫞뇠ꋢ뛤軦鯨軪菬뿮냰뫲鋴駶郸迺铼郾漀倂怄椆稈渊刌与⤐┒ⴔ␖", a_)))
					{
						num = (short)578093084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_358;
				case 9:
					num = (short)740950017;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖軘닚맜뫞뇠ꋢ뛤軦鯨軪菬볮飰臲郴駶뛸诺飼跾怀眂氄栆月吊䰌㘎‐‒Ⱄ", a_)))
					{
						num = (short)423034894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D3;
				case 10:
					this.radErgoWidePASirenDefaultPAVolumeLevel_A7812 = new global::AcpBusinessLayer.AcpSimpleRangeField(11, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖軘닚맜뫞뇠ꋢ뛤軦鯨軪菬꯮铰闲铴苶闸迺근뻾圀氂椄爆搈渊䄌樎朐瘒礔䠖堘Ⱊ├⸞ጠ", a_), global::CommonResources.AcgResources.ID_PUBLICADDRESSDEFAULTPAVOLUMELEVEL, null, null, 0, 1);
					this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.DataTransferOrder = 13;
					this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.ShowHexValue = false;
					num = (short)1847918595;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
				{
					num = (short)839685681;
					short num3 = num;
					num = (short)2143852081;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_20D;
					default:
						num = (short)1927479296;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖軘닚맜뫞뇠ꋢ뛤軦鯨軪菬ꃮ臰蟲鳴飶韸裺볼諾攀樂樄䨆簈缊搌愎瘐䰒吔⼖⼘⤚⸜", a_)))
						{
							num = (short)1815740442;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_62E;
					}
					break;
				}
				case 12:
					num = (short)1786183703;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖軘닚맜뫞뇠ꋢ뛤軦鯨軪菬꟮飰뿲髴뛶郸觺闼郾猀洂億栆月渊縌倎倐⬒✔✖⤘", a_)))
					{
						num = (short)165347353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E0;
				case 14:
					this.radErgoWidePASirenSirenOperation_A9139 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.indexRadErgoWidePASirenSirenOperation_A9139LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.idRadErgoWidePASirenSirenOperation_A9139LovStrs), this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖軘닚맜뫞뇠ꋢ뛤軦鯨軪菬볮飰臲郴駶뛸诺飼跾怀眂氄栆月吊䰌㘎‐‒Ⱄ", a_), global::CommonResources.AcgResources.ID_SIRENOPERATION, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWidePASirenSirenOperation_A9139LovStrs);
					this.radErgoWidePASirenSirenOperation_A9139.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWidePASirenSirenOperation_A9139.DataTransferOrder = 5;
					num = (short)1464074269;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					this.radErgoWidePASirenManualTone_A8464 = new global::AcpBusinessLayer.AcpSparseLOVField(2, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.indexRadErgoWidePASirenManualTone_A8464LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.idRadErgoWidePASirenManualTone_A8464LovStrs), this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖軘닚맜뫞뇠ꋢ뛤軦鯨軪菬ꋮ郰鷲胴零闸꿺鋼釾搀専䐄㼆㴈㴊㤌", a_), global::CommonResources.AcgResources.ID_SIRENMANUALTONE, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWidePASirenManualTone_A8464LovStrs);
					this.radErgoWidePASirenManualTone_A8464.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radErgoWidePASirenManualTone_A8464.DataTransferOrder = 11;
					num = (short)906952731;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					switch (0)
					{
					case 0:
						goto IL_AB;
					}
					continue;
				case 17:
					goto IL_6D5;
				case 18:
					this.radErgoWidePASirenSirenPAAfterReset_A9140 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖軘닚맜뫞뇠ꋢ뛤軦鯨軪菬볮飰臲郴駶꧸뫺볼駾甀昂眄唆氈砊栌笎丐划Ⱄ☖ⴘ⬚", a_), global::CommonResources.AcgResources.ID_PUBLICADDRESSSIRENPAAFTERRESET, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWidePASirenSirenPAAfterReset_A9140LovStrs);
					this.radErgoWidePASirenSirenPAAfterReset_A9140.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radErgoWidePASirenSirenPAAfterReset_A9140.DataTransferOrder = 12;
					num = (short)206176262;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					goto IL_358;
				case 20:
					goto IL_54B;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖軘닚맜뫞뇠ꋢ뛤軦鯨軪菬꯮铰闲铴苶闸迺근뻾圀氂椄爆搈渊䄌樎朐瘒礔䠖堘Ⱊ├⸞ጠ", a_)))
					{
						num = (short)1810235402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_176;
				case 22:
				{
					num = (short)1707737088;
					short num4 = num;
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖軘닚맜뫞뇠ꋢ뛤軦鯨軪菬ꋮ郰鷲胴零闸꿺鋼釾搀専䐄㼆㴈㴊㤌", a_)))
					{
						num = (short)910032911;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_79D;
				}
				case 23:
					if (producerFields != null)
					{
						num = (short)1669070848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_79D;
				case 24:
					goto IL_62E;
				case 25:
					goto IL_20D;
				case 26:
					this.radErgoWidePASirenOptionsAudioMuting_A8623 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖軘닚맜뫞뇠ꋢ뛤軦鯨軪菬ꃮ臰蟲鳴飶韸裺볼諾攀樂樄䨆簈缊搌愎瘐䰒吔⼖⼘⤚⸜", a_), global::CommonResources.AcgResources.ID_PUBLICADDRESSOPTIONSAUDIOMUTING);
					this.radErgoWidePASirenOptionsAudioMuting_A8623.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radErgoWidePASirenOptionsAudioMuting_A8623.DataTransferOrder = 9;
					num = (short)2065104920;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					goto IL_4B7;
				case 28:
					this.radErgoWidePASirenPAIgnitionSense_A8683 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖軘닚맜뫞뇠ꋢ뛤軦鯨軪菬뿮냰뫲鋴駶郸迺铼郾漀倂怄椆稈渊刌与⤐┒ⴔ␖", a_), global::CommonResources.AcgResources.ID_PUBLICADDRESSPAIGNITIONSENSE);
					this.radErgoWidePASirenPAIgnitionSense_A8683.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWidePASirenPAIgnitionSense_A8683.DataTransferOrder = 8;
					num = (short)1920466963;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					goto IL_D3;
				case 30:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖軘닚맜뫞뇠ꋢ뛤軦鯨軪菬볮飰臲郴駶냸鳺鏼雾甀樂樄椆娈渊挌簎琐䰒吔⸖⠘⠚├", a_)))
					{
						num = (short)1986002946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6D5;
				}
				IL_AB:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1483210764;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_D3:
				num = (short)162529285;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_176:
				num = (short)977403905;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C4:
				num = (short)813170701;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_20D:
				this.radErgoWidePASirenHiLoAirhornTones_A8200 = new global::AcpBusinessLayer.AcpFieldX<bool, bool>(true, new global::Features.Converters.UnpackAndPackAndInvertBooleanField(), this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ铐ꇒ닔룖軘닚맜뫞뇠ꋢ뛤軦鯨軪菬꟮飰뿲髴뛶郸觺闼郾猀洂億栆月渊縌倎倐⬒✔✖⤘", a_), global::CommonResources.AcgResources.ID_SIRENHILOAIRHORNTONES);
				this.radErgoWidePASirenHiLoAirhornTones_A8200.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
				this.radErgoWidePASirenHiLoAirhornTones_A8200.DataTransferOrder = 7;
				num = (short)2083782660;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E0:
				num = (short)1203961878;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_358:
				num = (short)1205075998;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_54B:
				num = (short)1352990731;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_62E:
				num = (short)654442504;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6D5:
				num = (short)2055667721;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4B7:
			IL_79D:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鯊賌苐뫒꟔닖럘", a_);
			base.Id = 10225;
			base.UIName = global::CommonResources.AcgResources.ID_PASIREN;
			base.DataTransferOrder = 3;
		}

		// Token: 0x060066C7 RID: 26311 RVA: 0x005BF368 File Offset: 0x005BD568
		public override void PopulateReferences()
		{
			short num = (short)1095499776;
			short num2 = num;
			num = (short)1930821633;
			if (num != 0)
			{
			}
			num = (short)343678816;
			short num3 = num;
			num = (short)1318657888;
			switch (num3 == num)
			{
			}
			num = (short)1857486848;
			if (num != 0)
			{
			}
		}

		// Token: 0x060066C8 RID: 26312 RVA: 0x005BF410 File Offset: 0x005BD610
		public override void DropReferences()
		{
			short num = (short)1957494784;
			short num2 = num;
			num = (short)1696198006;
			short num3 = num;
			num = (short)523365750;
			switch (num3 == num)
			{
			}
			num = (short)1245708289;
			if (num != 0)
			{
			}
			num = (short)1251934208;
			if (num != 0)
			{
			}
		}

		// Token: 0x060066C9 RID: 26313 RVA: 0x005BF4B8 File Offset: 0x005BD6B8
		public override void SetConstraints()
		{
			short num = (short)976027648;
			short num2 = num;
			num = (short)1847263233;
			if (num != 0)
			{
			}
			num = (short)1118744670;
			short num3 = num;
			num = (short)1137619038;
			switch (num3 == num)
			{
			}
			num = (short)1382023168;
			if (num != 0)
			{
			}
			this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConPaOnlyDisplayChoice);
			this.radErgoWidePASirenExternalRadioIgnition_A7992.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConPaOnlyDisplayChoice);
			this.radErgoWidePASirenOptionsAudioMuting_A8623.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConPaOnlyDisplayChoice);
			this.radErgoWidePASirenPAIgnitionSense_A8683.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConPaOnlyDisplayChoice);
			this.radErgoWidePASirenSirenIgnitionSense_A9138.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConSirenPaDisplayChoice);
			this.radErgoWidePASirenSirenOperation_A9139.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConRadErgoWideSirenOperationApp);
			this.radErgoWidePASirenSirenOperation_A9139.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConRadErgoWideSirenOperationValid);
			this.radErgoWidePASirenSirenOperation_A9139.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.conSetSirenPASystemLookupAndSirenPAOnly);
			this.radErgoWidePASirenSirenPAAfterReset_A9140.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConPaOnlyDisplayChoice);
			this.radErgoWidePASirenSirenPAAfterReset_A9140.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConRadioIsLockedAndSirenLockChecked);
			this.radErgoWidePASirenHiLoAirhornTones_A8200.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConSirenPaDisplayChoice);
			this.radErgoWidePASirenHiLoAirhornTones_A8200.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConSirenPaDisplayChoiceEdt);
			this.radErgoWidePASirenHiLoAirhornTones_A8200.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConSetNullIfHiloAirhornToneDisabled);
			this.radErgoWidePASirenManualTone_A8464.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConSirenPaDisplayChoice);
			this.radErgoWidePASirenManualTone_A8464.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConManualToneIndexValid);
		}

		// Token: 0x060066CA RID: 26314 RVA: 0x005BF6BC File Offset: 0x005BD8BC
		public override void SetupDependencies()
		{
			short num = (short)1900281856;
			short num2 = num;
			num = (short)663408743;
			short num3 = num;
			num = (short)1633669223;
			switch (num3 == num)
			{
			}
			num = (short)828571648;
			if (num != 0)
			{
			}
			num = (short)1823408129;
			if (num != 0)
			{
			}
			this.radErgoWidePASirenSirenOperation_A9139.AddDependentObject(this.radErgoWidePASirenDefaultPAVolumeLevel_A7812);
			this.radErgoWidePASirenSirenOperation_A9139.AddDependentObject(this.radErgoWidePASirenExternalRadioIgnition_A7992);
			this.radErgoWidePASirenSirenOperation_A9139.AddDependentObject(this.radErgoWidePASirenOptionsAudioMuting_A8623);
			this.radErgoWidePASirenSirenOperation_A9139.AddDependentObject(this.radErgoWidePASirenPAIgnitionSense_A8683);
			this.radErgoWidePASirenSirenOperation_A9139.AddDependentObject(this.radErgoWidePASirenSirenIgnitionSense_A9138);
			this.RefRadioWide.Labtool.RadWideLabtoolSirenPaSystemLookup_A9143.AddDependentObject(this.radErgoWidePASirenSirenOperation_A9139);
			this.RefRadioWide.Labtool.RadWideLabtoolSirenPaOnly_A9142.AddDependentObject(this.radErgoWidePASirenSirenOperation_A9139);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoWidePASirenSirenOperation_A9139);
			this.radErgoWidePASirenSirenOperation_A9139.AddDependentObject(this.radErgoWidePASirenSirenPAAfterReset_A9140);
			this.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsRadioLock_A8836.AddDependentObject(this.radErgoWidePASirenSirenPAAfterReset_A9140);
			this.RefRadioWide.UserInformationAndPasswords.RadWideUserinfoPassRequiredForSiren_A36533.AddDependentObject(this.radErgoWidePASirenSirenPAAfterReset_A9140);
			this.radErgoWidePASirenSirenOperation_A9139.AddDependentObject(this.radErgoWidePASirenHiLoAirhornTones_A8200);
			this.radErgoWidePASirenSirenOperation_A9139.AddDependentObject(this.radErgoWidePASirenManualTone_A8464);
			this.radErgoWidePASirenHiLoAirhornTones_A8200.AddDependentObject(this.radErgoWidePASirenManualTone_A8464);
		}

		// Token: 0x17003554 RID: 13652
		// (get) Token: 0x060066CB RID: 26315 RVA: 0x005BF894 File Offset: 0x005BDA94
		public bool HasDiffs
		{
			get
			{
				short num = (short)1640693760;
				short num2 = num;
				num = (short)2107426657;
				short num3 = num;
				num = (short)539281249;
				switch (num3 == num)
				{
				}
				num = (short)260374529;
				if (num != 0)
				{
				}
				num = (short)1853882368;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17003555 RID: 13653
		// (get) Token: 0x060066CC RID: 26316 RVA: 0x005BF944 File Offset: 0x005BDB44
		// (set) Token: 0x060066CD RID: 26317 RVA: 0x005BF9FC File Offset: 0x005BDBFC
		public int RadErgoWidePASirenDefaultPAVolumeLevel_A7812Value
		{
			get
			{
				short num = (short)247595008;
				short num2 = num;
				num = (short)686858687;
				short num3 = num;
				num = (short)1626317247;
				switch (num3 == num)
				{
				}
				num = (short)958136321;
				if (num != 0)
				{
				}
				num = (short)1412628480;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.Value;
			}
			set
			{
				short num = (short)146145280;
				short num2 = num;
				num = (short)1362541683;
				short num3 = num;
				num = (short)157662323;
				switch (num3 == num)
				{
				}
				num = (short)220659713;
				if (num != 0)
				{
				}
				num = (short)1368326144;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.Value = value;
			}
		}

		// Token: 0x17003556 RID: 13654
		// (get) Token: 0x060066CE RID: 26318 RVA: 0x005BFAB0 File Offset: 0x005BDCB0
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoWidePASirenDefaultPAVolumeLevel_A7812
		{
			get
			{
				short num = (short)15138816;
				short num2 = num;
				num = (short)1904672769;
				if (num != 0)
				{
				}
				num = (short)1859710228;
				short num3 = num;
				num = (short)2001595668;
				switch (num3 == num)
				{
				}
				num = (short)1919352832;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenDefaultPAVolumeLevel_A7812;
			}
		}

		// Token: 0x17003557 RID: 13655
		// (get) Token: 0x060066CF RID: 26319 RVA: 0x005BFB60 File Offset: 0x005BDD60
		// (set) Token: 0x060066D0 RID: 26320 RVA: 0x005BFC14 File Offset: 0x005BDE14
		public string RadErgoWidePASirenDefaultPAVolumeLevel_A7812_UIValue
		{
			get
			{
				short num = (short)157024256;
				short num2 = num;
				num = (short)1351166075;
				short num3 = num;
				num = (short)985540731;
				switch (num3 == num)
				{
				}
				num = (short)1451687937;
				if (num != 0)
				{
				}
				num = (short)509870080;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.UIValue;
			}
			set
			{
				short num = (short)968097792;
				short num2 = num;
				num = (short)339307821;
				short num3 = num;
				num = (short)362769709;
				switch (num3 == num)
				{
				}
				num = (short)1189806081;
				if (num != 0)
				{
				}
				num = (short)1267859456;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.UIValue = value;
			}
		}

		// Token: 0x17003558 RID: 13656
		// (get) Token: 0x060066D1 RID: 26321 RVA: 0x005BFCC8 File Offset: 0x005BDEC8
		// (set) Token: 0x060066D2 RID: 26322 RVA: 0x005BFD7C File Offset: 0x005BDF7C
		internal int RadErgoWidePASirenDefaultPAVolumeLevel_A7812Min
		{
			get
			{
				short num = (short)1278083072;
				short num2 = num;
				num = (short)1412650495;
				short num3 = num;
				num = (short)801330687;
				switch (num3 == num)
				{
				}
				num = (short)76742657;
				if (num != 0)
				{
				}
				num = (short)856293376;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.Min;
			}
			set
			{
				short num = (short)1017708544;
				short num2 = num;
				num = (short)286974414;
				short num3 = num;
				num = (short)1379328462;
				switch (num3 == num)
				{
				}
				num = (short)1286078464;
				if (num != 0)
				{
				}
				num = (short)720437249;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.Min = value;
			}
		}

		// Token: 0x17003559 RID: 13657
		// (get) Token: 0x060066D3 RID: 26323 RVA: 0x005BFE34 File Offset: 0x005BE034
		// (set) Token: 0x060066D4 RID: 26324 RVA: 0x005BFEEC File Offset: 0x005BE0EC
		internal int RadErgoWidePASirenDefaultPAVolumeLevel_A7812Max
		{
			get
			{
				short num = (short)919797760;
				short num2 = num;
				num = (short)139942732;
				short num3 = num;
				num = (short)430725964;
				switch (num3 == num)
				{
				}
				num = (short)1699676161;
				if (num != 0)
				{
				}
				num = (short)875102208;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.Max;
			}
			set
			{
				short num = (short)609681408;
				short num2 = num;
				num = (short)1479611510;
				short num3 = num;
				num = (short)334763126;
				switch (num3 == num)
				{
				}
				num = (short)267780096;
				if (num != 0)
				{
				}
				num = (short)345112577;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.Max = value;
			}
		}

		// Token: 0x1700355A RID: 13658
		// (get) Token: 0x060066D5 RID: 26325 RVA: 0x005BFFA0 File Offset: 0x005BE1A0
		// (set) Token: 0x060066D6 RID: 26326 RVA: 0x005C0058 File Offset: 0x005BE258
		internal int RadErgoWidePASirenDefaultPAVolumeLevel_A7812Step
		{
			get
			{
				short num = (short)860553216;
				short num2 = num;
				num = (short)131337339;
				short num3 = num;
				num = (short)1266093179;
				switch (num3 == num)
				{
				}
				num = (short)1314193409;
				if (num != 0)
				{
				}
				num = (short)1762656256;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.StepSize;
			}
			set
			{
				short num = (short)670695424;
				short num2 = num;
				num = (short)531737475;
				short num3 = num;
				num = (short)442674051;
				switch (num3 == num)
				{
				}
				num = (short)1168965633;
				if (num != 0)
				{
				}
				num = (short)462094336;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.StepSize = value;
			}
		}

		// Token: 0x1700355B RID: 13659
		// (get) Token: 0x060066D7 RID: 26327 RVA: 0x005C010C File Offset: 0x005BE30C
		// (set) Token: 0x060066D8 RID: 26328 RVA: 0x005C01C0 File Offset: 0x005BE3C0
		public bool RadErgoWidePASirenDefaultPAVolumeLevel_A7812_Applicable
		{
			get
			{
				short num = (short)2076966912;
				short num2 = num;
				num = (short)817981228;
				short num3 = num;
				num = (short)2048091948;
				switch (num3 == num)
				{
				}
				num = (short)2052718593;
				if (num != 0)
				{
				}
				num = (short)727908352;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.Applicable;
			}
			set
			{
				short num = (short)800063488;
				short num2 = num;
				num = (short)261743997;
				short num3 = num;
				num = (short)1530848637;
				switch (num3 == num)
				{
				}
				num = (short)1635778560;
				if (num != 0)
				{
				}
				num = (short)275513345;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.Applicable = value;
			}
		}

		// Token: 0x1700355C RID: 13660
		// (get) Token: 0x060066D9 RID: 26329 RVA: 0x005C0278 File Offset: 0x005BE478
		// (set) Token: 0x060066DA RID: 26330 RVA: 0x005C032C File Offset: 0x005BE52C
		public bool RadErgoWidePASirenDefaultPAVolumeLevel_A7812_Valid
		{
			get
			{
				short num = (short)611188736;
				short num2 = num;
				num = (short)550004128;
				short num3 = num;
				num = (short)354575776;
				switch (num3 == num)
				{
				}
				num = (short)2146959361;
				if (num != 0)
				{
				}
				num = (short)1881276416;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.Valid;
			}
			set
			{
				short num = (short)1058013184;
				short num2 = num;
				num = (short)1821618608;
				short num3 = num;
				num = (short)468693424;
				switch (num3 == num)
				{
				}
				num = (short)643039232;
				if (num != 0)
				{
				}
				num = (short)1418067969;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.Valid = value;
			}
		}

		// Token: 0x1700355D RID: 13661
		// (get) Token: 0x060066DB RID: 26331 RVA: 0x005C03E4 File Offset: 0x005BE5E4
		// (set) Token: 0x060066DC RID: 26332 RVA: 0x005C0498 File Offset: 0x005BE698
		public bool RadErgoWidePASirenDefaultPAVolumeLevel_A7812_Visible
		{
			get
			{
				short num = (short)28573696;
				short num2 = num;
				num = (short)508381672;
				short num3 = num;
				num = (short)298994152;
				switch (num3 == num)
				{
				}
				num = (short)359858176;
				if (num != 0)
				{
				}
				num = (short)45875201;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.Visible;
			}
			set
			{
				short num = (short)1911422976;
				short num2 = num;
				num = (short)1899038763;
				short num3 = num;
				num = (short)988219435;
				switch (num3 == num)
				{
				}
				num = (short)1820065793;
				if (num != 0)
				{
				}
				num = (short)2059665408;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.Visible = value;
			}
		}

		// Token: 0x1700355E RID: 13662
		// (get) Token: 0x060066DD RID: 26333 RVA: 0x005C054C File Offset: 0x005BE74C
		// (set) Token: 0x060066DE RID: 26334 RVA: 0x005C0604 File Offset: 0x005BE804
		public bool RadErgoWidePASirenDefaultPAVolumeLevel_A7812_Editable
		{
			get
			{
				short num = (short)342163456;
				short num2 = num;
				num = (short)1134690305;
				if (num != 0)
				{
				}
				num = (short)746177381;
				short num3 = num;
				num = (short)1219216229;
				switch (num3 == num)
				{
				}
				num = (short)1326055424;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.Editable;
			}
			set
			{
				short num = (short)1785659392;
				short num2 = num;
				num = (short)1184362387;
				short num3 = num;
				num = (short)89976723;
				switch (num3 == num)
				{
				}
				num = (short)1955659776;
				if (num != 0)
				{
				}
				num = (short)375193601;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.Editable = value;
			}
		}

		// Token: 0x1700355F RID: 13663
		// (get) Token: 0x060066DF RID: 26335 RVA: 0x005C06BC File Offset: 0x005BE8BC
		internal string RadErgoWidePASirenDefaultPAVolumeLevel_A7812_UILabel
		{
			get
			{
				short num = (short)2038956032;
				short num2 = num;
				num = (short)2120744238;
				short num3 = num;
				num = (short)1615592750;
				switch (num3 == num)
				{
				}
				num = (short)1702952961;
				if (num != 0)
				{
				}
				num = (short)435159040;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.UIName;
			}
		}

		// Token: 0x17003560 RID: 13664
		// (get) Token: 0x060066E0 RID: 26336 RVA: 0x005C0774 File Offset: 0x005BE974
		// (set) Token: 0x060066E1 RID: 26337 RVA: 0x005C0828 File Offset: 0x005BEA28
		internal bool RadErgoWidePASirenDefaultPAVolumeLevel_A7812_HiddenStatic
		{
			get
			{
				short num = (short)572522496;
				short num2 = num;
				num = (short)2118924694;
				short num3 = num;
				num = (short)2131442070;
				switch (num3 == num)
				{
				}
				num = (short)1835925505;
				if (num != 0)
				{
				}
				num = (short)1865285632;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.HiddenStatic;
			}
			set
			{
				short num = (short)1878261760;
				short num2 = num;
				num = (short)2025560831;
				short num3 = num;
				num = (short)1170643711;
				switch (num3 == num)
				{
				}
				num = (short)1951924225;
				if (num != 0)
				{
				}
				num = (short)2092498944;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.HiddenStatic = value;
			}
		}

		// Token: 0x17003561 RID: 13665
		// (get) Token: 0x060066E2 RID: 26338 RVA: 0x005C08DC File Offset: 0x005BEADC
		// (set) Token: 0x060066E3 RID: 26339 RVA: 0x005C0990 File Offset: 0x005BEB90
		internal bool RadErgoWidePASirenDefaultPAVolumeLevel_A7812_HiddenDynamic
		{
			get
			{
				short num = (short)1512636416;
				short num2 = num;
				num = (short)1646756728;
				short num3 = num;
				num = (short)757367672;
				switch (num3 == num)
				{
				}
				num = (short)2106916865;
				if (num != 0)
				{
				}
				num = (short)1631584256;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.HiddenDynamic;
			}
			set
			{
				short num = (short)823263232;
				short num2 = num;
				num = (short)1431552686;
				short num3 = num;
				num = (short)878166702;
				switch (num3 == num)
				{
				}
				num = (short)1284833281;
				if (num != 0)
				{
				}
				num = (short)455737344;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenDefaultPAVolumeLevel_A7812.HiddenDynamic = value;
			}
		}

		// Token: 0x17003562 RID: 13666
		// (get) Token: 0x060066E4 RID: 26340 RVA: 0x005C0A48 File Offset: 0x005BEC48
		public bool RadErgoWidePASirenDefaultPAVolumeLevel_A7812_HasDiffs
		{
			get
			{
				short num = (short)432472064;
				short num2 = num;
				num = (short)1508740453;
				short num3 = num;
				num = (short)1810206053;
				switch (num3 == num)
				{
				}
				num = (short)172032001;
				if (num != 0)
				{
				}
				num = (short)1705902080;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenDefaultPAVolumeLevel_A7812._HasDiffs;
			}
		}

		// Token: 0x17003563 RID: 13667
		// (get) Token: 0x060066E5 RID: 26341 RVA: 0x005C0B00 File Offset: 0x005BED00
		// (set) Token: 0x060066E6 RID: 26342 RVA: 0x005C0BB4 File Offset: 0x005BEDB4
		public bool RadErgoWidePASirenExternalRadioIgnition_A7992Value
		{
			get
			{
				short num = (short)189988864;
				short num2 = num;
				num = (short)367154766;
				short num3 = num;
				num = (short)875189838;
				switch (num3 == num)
				{
				}
				num = (short)960692225;
				if (num != 0)
				{
				}
				num = (short)240517120;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenExternalRadioIgnition_A7992.Value;
			}
			set
			{
				short num = (short)659816448;
				short num2 = num;
				num = (short)1663211758;
				short num3 = num;
				num = (short)553621742;
				switch (num3 == num)
				{
				}
				num = (short)1829306368;
				if (num != 0)
				{
				}
				num = (short)2132082689;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenExternalRadioIgnition_A7992.Value = value;
			}
		}

		// Token: 0x17003564 RID: 13668
		// (get) Token: 0x060066E7 RID: 26343 RVA: 0x005C0C6C File Offset: 0x005BEE6C
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWidePASirenExternalRadioIgnition_A7992
		{
			get
			{
				short num = (short)7667712;
				short num2 = num;
				num = (short)27744310;
				short num3 = num;
				num = (short)1263425590;
				switch (num3 == num)
				{
				}
				num = (short)1725890560;
				if (num != 0)
				{
				}
				num = (short)2027749377;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenExternalRadioIgnition_A7992;
			}
		}

		// Token: 0x17003565 RID: 13669
		// (get) Token: 0x060066E8 RID: 26344 RVA: 0x005C0D1C File Offset: 0x005BEF1C
		// (set) Token: 0x060066E9 RID: 26345 RVA: 0x005C0DD0 File Offset: 0x005BEFD0
		public bool RadErgoWidePASirenExternalRadioIgnition_A7992_UIValue
		{
			get
			{
				short num = (short)79429632;
				short num2 = num;
				num = (short)1179613394;
				short num3 = num;
				num = (short)1711241426;
				switch (num3 == num)
				{
				}
				num = (short)1713242112;
				if (num != 0)
				{
				}
				num = (short)282132481;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenExternalRadioIgnition_A7992.Value;
			}
			set
			{
				short num = (short)125304832;
				short num2 = num;
				num = (short)853549535;
				short num3 = num;
				num = (short)380576223;
				switch (num3 == num)
				{
				}
				num = (short)972095489;
				if (num != 0)
				{
				}
				num = (short)153354240;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenExternalRadioIgnition_A7992.Value = value;
			}
		}

		// Token: 0x17003566 RID: 13670
		// (get) Token: 0x060066EA RID: 26346 RVA: 0x005C0E88 File Offset: 0x005BF088
		// (set) Token: 0x060066EB RID: 26347 RVA: 0x005C0F3C File Offset: 0x005BF13C
		public bool RadErgoWidePASirenExternalRadioIgnition_A7992_Applicable
		{
			get
			{
				short num = (short)1160773632;
				short num2 = num;
				num = (short)806680319;
				short num3 = num;
				num = (short)702412543;
				switch (num3 == num)
				{
				}
				num = (short)978583553;
				if (num != 0)
				{
				}
				num = (short)1955856384;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenExternalRadioIgnition_A7992.Applicable;
			}
			set
			{
				short num = (short)2103771136;
				short num2 = num;
				num = (short)2029846529;
				if (num != 0)
				{
				}
				num = (short)655830862;
				short num3 = num;
				num = (short)126103374;
				switch (num3 == num)
				{
				}
				num = (short)1391591424;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenExternalRadioIgnition_A7992.Applicable = value;
			}
		}

		// Token: 0x17003567 RID: 13671
		// (get) Token: 0x060066EC RID: 26348 RVA: 0x005C0FF8 File Offset: 0x005BF1F8
		// (set) Token: 0x060066ED RID: 26349 RVA: 0x005C10B0 File Offset: 0x005BF2B0
		public bool RadErgoWidePASirenExternalRadioIgnition_A7992_Valid
		{
			get
			{
				short num = (short)1731985408;
				short num2 = num;
				num = (short)1206484384;
				short num3 = num;
				num = (short)112819616;
				switch (num3 == num)
				{
				}
				num = (short)1018691585;
				if (num != 0)
				{
				}
				num = (short)1930887168;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenExternalRadioIgnition_A7992.Valid;
			}
			set
			{
				short num = (short)1448214528;
				short num2 = num;
				num = (short)1196228609;
				if (num != 0)
				{
				}
				num = (short)6915081;
				short num3 = num;
				num = (short)873628681;
				switch (num3 == num)
				{
				}
				num = (short)449839104;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenExternalRadioIgnition_A7992.Valid = value;
			}
		}

		// Token: 0x17003568 RID: 13672
		// (get) Token: 0x060066EE RID: 26350 RVA: 0x005C1164 File Offset: 0x005BF364
		// (set) Token: 0x060066EF RID: 26351 RVA: 0x005C1218 File Offset: 0x005BF418
		public bool RadErgoWidePASirenExternalRadioIgnition_A7992_Visible
		{
			get
			{
				short num = (short)770768896;
				short num2 = num;
				num = (short)2116465327;
				short num3 = num;
				num = (short)1530901167;
				switch (num3 == num)
				{
				}
				num = (short)395575297;
				if (num != 0)
				{
				}
				num = (short)1697775616;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenExternalRadioIgnition_A7992.Visible;
			}
			set
			{
				short num = (short)1671233536;
				short num2 = num;
				num = (short)1670250497;
				if (num != 0)
				{
				}
				num = (short)1356517225;
				short num3 = num;
				num = (short)1040764777;
				switch (num3 == num)
				{
				}
				num = (short)1703280640;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenExternalRadioIgnition_A7992.Visible = value;
			}
		}

		// Token: 0x17003569 RID: 13673
		// (get) Token: 0x060066F0 RID: 26352 RVA: 0x005C12D0 File Offset: 0x005BF4D0
		// (set) Token: 0x060066F1 RID: 26353 RVA: 0x005C1384 File Offset: 0x005BF584
		public bool RadErgoWidePASirenExternalRadioIgnition_A7992_Editable
		{
			get
			{
				short num = (short)341639168;
				short num2 = num;
				num = (short)1653893076;
				short num3 = num;
				num = (short)1267296212;
				switch (num3 == num)
				{
				}
				num = (short)644349952;
				if (num != 0)
				{
				}
				num = (short)229048321;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenExternalRadioIgnition_A7992.Editable;
			}
			set
			{
				short num = (short)1587085312;
				short num2 = num;
				num = (short)1049436304;
				short num3 = num;
				num = (short)1877745808;
				switch (num3 == num)
				{
				}
				num = (short)285343745;
				if (num != 0)
				{
				}
				num = (short)1043660800;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenExternalRadioIgnition_A7992.Editable = value;
			}
		}

		// Token: 0x1700356A RID: 13674
		// (get) Token: 0x060066F2 RID: 26354 RVA: 0x005C1438 File Offset: 0x005BF638
		internal string RadErgoWidePASirenExternalRadioIgnition_A7992_UILabel
		{
			get
			{
				short num = (short)448921600;
				short num2 = num;
				num = (short)1608717837;
				short num3 = num;
				num = (short)1770264077;
				switch (num3 == num)
				{
				}
				num = (short)662962177;
				if (num != 0)
				{
				}
				num = (short)1777532928;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenExternalRadioIgnition_A7992.UIName;
			}
		}

		// Token: 0x1700356B RID: 13675
		// (get) Token: 0x060066F3 RID: 26355 RVA: 0x005C14EC File Offset: 0x005BF6EC
		// (set) Token: 0x060066F4 RID: 26356 RVA: 0x005C15A0 File Offset: 0x005BF7A0
		internal bool RadErgoWidePASirenExternalRadioIgnition_A7992_HiddenStatic
		{
			get
			{
				short num = (short)637534208;
				short num2 = num;
				num = (short)454931075;
				short num3 = num;
				num = (short)2104668803;
				switch (num3 == num)
				{
				}
				num = (short)488636416;
				if (num != 0)
				{
				}
				num = (short)1503068161;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenExternalRadioIgnition_A7992.HiddenStatic;
			}
			set
			{
				short num = (short)1241972736;
				short num2 = num;
				num = (short)632792269;
				short num3 = num;
				num = (short)1803199693;
				switch (num3 == num)
				{
				}
				num = (short)506920960;
				if (num != 0)
				{
				}
				num = (short)1288372225;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenExternalRadioIgnition_A7992.HiddenStatic = value;
			}
		}

		// Token: 0x1700356C RID: 13676
		// (get) Token: 0x060066F5 RID: 26357 RVA: 0x005C1654 File Offset: 0x005BF854
		// (set) Token: 0x060066F6 RID: 26358 RVA: 0x005C170C File Offset: 0x005BF90C
		internal bool RadErgoWidePASirenExternalRadioIgnition_A7992_HiddenDynamic
		{
			get
			{
				short num = (short)1645936640;
				short num2 = num;
				num = (short)505450266;
				short num3 = num;
				num = (short)2113441562;
				switch (num3 == num)
				{
				}
				num = (short)83230721;
				if (num != 0)
				{
				}
				num = (short)1090781184;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenExternalRadioIgnition_A7992.HiddenDynamic;
			}
			set
			{
				short num = (short)1205338112;
				short num2 = num;
				num = (short)1716066178;
				short num3 = num;
				num = (short)868030338;
				switch (num3 == num)
				{
				}
				num = (short)441122817;
				if (num != 0)
				{
				}
				num = (short)316407808;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenExternalRadioIgnition_A7992.HiddenDynamic = value;
			}
		}

		// Token: 0x1700356D RID: 13677
		// (get) Token: 0x060066F7 RID: 26359 RVA: 0x005C17C0 File Offset: 0x005BF9C0
		public bool RadErgoWidePASirenExternalRadioIgnition_A7992_HasDiffs
		{
			get
			{
				short num = (short)697565184;
				short num2 = num;
				num = (short)1978531841;
				if (num != 0)
				{
				}
				num = (short)1583730398;
				short num3 = num;
				num = (short)249089758;
				switch (num3 == num)
				{
				}
				num = (short)705036288;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenExternalRadioIgnition_A7992._HasDiffs;
			}
		}

		// Token: 0x1700356E RID: 13678
		// (get) Token: 0x060066F8 RID: 26360 RVA: 0x005C1874 File Offset: 0x005BFA74
		// (set) Token: 0x060066F9 RID: 26361 RVA: 0x005C1928 File Offset: 0x005BFB28
		public bool RadErgoWidePASirenOptionsAudioMuting_A8623Value
		{
			get
			{
				short num = (short)1065156608;
				short num2 = num;
				num = (short)1441726465;
				if (num != 0)
				{
				}
				num = (short)939909327;
				short num3 = num;
				num = (short)1956241615;
				switch (num3 == num)
				{
				}
				num = (short)41287680;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenOptionsAudioMuting_A8623.Value;
			}
			set
			{
				short num = (short)133300224;
				short num2 = num;
				num = (short)1786077912;
				short num3 = num;
				num = (short)1298883288;
				switch (num3 == num)
				{
				}
				num = (short)204603393;
				if (num != 0)
				{
				}
				num = (short)636878848;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenOptionsAudioMuting_A8623.Value = value;
			}
		}

		// Token: 0x1700356F RID: 13679
		// (get) Token: 0x060066FA RID: 26362 RVA: 0x005C19E0 File Offset: 0x005BFBE0
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWidePASirenOptionsAudioMuting_A8623
		{
			get
			{
				short num = (short)823459840;
				short num2 = num;
				num = (short)2091905319;
				short num3 = num;
				num = (short)904458535;
				switch (num3 == num)
				{
				}
				num = (short)1669660673;
				if (num != 0)
				{
				}
				num = (short)2110455808;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenOptionsAudioMuting_A8623;
			}
		}

		// Token: 0x17003570 RID: 13680
		// (get) Token: 0x060066FB RID: 26363 RVA: 0x005C1A90 File Offset: 0x005BFC90
		// (set) Token: 0x060066FC RID: 26364 RVA: 0x005C1B48 File Offset: 0x005BFD48
		public bool RadErgoWidePASirenOptionsAudioMuting_A8623_UIValue
		{
			get
			{
				short num = (short)1460928512;
				short num2 = num;
				num = (short)816447489;
				if (num != 0)
				{
				}
				num = (short)1155238751;
				short num3 = num;
				num = (short)1737329503;
				switch (num3 == num)
				{
				}
				num = (short)1867513856;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenOptionsAudioMuting_A8623.Value;
			}
			set
			{
				short num = (short)572719104;
				short num2 = num;
				num = (short)550132199;
				short num3 = num;
				num = (short)984046055;
				switch (num3 == num)
				{
				}
				num = (short)1992622081;
				if (num != 0)
				{
				}
				num = (short)727384064;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenOptionsAudioMuting_A8623.Value = value;
			}
		}

		// Token: 0x17003571 RID: 13681
		// (get) Token: 0x060066FD RID: 26365 RVA: 0x005C1BFC File Offset: 0x005BFDFC
		// (set) Token: 0x060066FE RID: 26366 RVA: 0x005C1CB4 File Offset: 0x005BFEB4
		public bool RadErgoWidePASirenOptionsAudioMuting_A8623_Applicable
		{
			get
			{
				short num = (short)1882849280;
				short num2 = num;
				num = (short)1754202113;
				if (num != 0)
				{
				}
				num = (short)1239239753;
				short num3 = num;
				num = (short)95308873;
				switch (num3 == num)
				{
				}
				num = (short)1053163520;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenOptionsAudioMuting_A8623.Applicable;
			}
			set
			{
				short num = (short)1326841856;
				short num2 = num;
				num = (short)240457524;
				short num3 = num;
				num = (short)521082676;
				switch (num3 == num)
				{
				}
				num = (short)110166016;
				if (num != 0)
				{
				}
				num = (short)1995964417;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenOptionsAudioMuting_A8623.Applicable = value;
			}
		}

		// Token: 0x17003572 RID: 13682
		// (get) Token: 0x060066FF RID: 26367 RVA: 0x005C1D68 File Offset: 0x005BFF68
		// (set) Token: 0x06006700 RID: 26368 RVA: 0x005C1E1C File Offset: 0x005C001C
		public bool RadErgoWidePASirenOptionsAudioMuting_A8623_Valid
		{
			get
			{
				short num = (short)1976696832;
				short num2 = num;
				num = (short)1856317969;
				short num3 = num;
				num = (short)208546321;
				switch (num3 == num)
				{
				}
				num = (short)96796673;
				if (num != 0)
				{
				}
				num = (short)2131165184;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenOptionsAudioMuting_A8623.Valid;
			}
			set
			{
				short num = (short)2140602368;
				short num2 = num;
				num = (short)415940811;
				short num3 = num;
				num = (short)1942929611;
				switch (num3 == num)
				{
				}
				num = (short)1312096257;
				if (num != 0)
				{
				}
				num = (short)1736114176;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenOptionsAudioMuting_A8623.Valid = value;
			}
		}

		// Token: 0x17003573 RID: 13683
		// (get) Token: 0x06006701 RID: 26369 RVA: 0x005C1ED0 File Offset: 0x005C00D0
		// (set) Token: 0x06006702 RID: 26370 RVA: 0x005C1F84 File Offset: 0x005C0184
		public bool RadErgoWidePASirenOptionsAudioMuting_A8623_Visible
		{
			get
			{
				short num = (short)409731072;
				short num2 = num;
				num = (short)1135792952;
				short num3 = num;
				num = (short)377738040;
				switch (num3 == num)
				{
				}
				num = (short)115474433;
				if (num != 0)
				{
				}
				num = (short)1224212480;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenOptionsAudioMuting_A8623.Visible;
			}
			set
			{
				short num = (short)1104347137;
				if (num != 0)
				{
				}
				num = (short)8162763;
				short num2 = num;
				num = (short)1751354827;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1790181376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1340145664;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenOptionsAudioMuting_A8623.Visible = value;
			}
		}

		// Token: 0x17003574 RID: 13684
		// (get) Token: 0x06006703 RID: 26371 RVA: 0x005C2038 File Offset: 0x005C0238
		// (set) Token: 0x06006704 RID: 26372 RVA: 0x005C20EC File Offset: 0x005C02EC
		public bool RadErgoWidePASirenOptionsAudioMuting_A8623_Editable
		{
			get
			{
				short num = (short)418318016;
				short num2 = num;
				num = (short)42993344;
				switch (num2 == num)
				{
				}
				num = (short)29622272;
				short num3 = num;
				num = (short)1017380864;
				if (num != 0)
				{
				}
				num = (short)2038038529;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenOptionsAudioMuting_A8623.Editable;
			}
			set
			{
				short num = (short)1932525569;
				if (num != 0)
				{
				}
				num = (short)1518287098;
				short num2 = num;
				num = (short)1668692218;
				switch (num2 == num)
				{
				default:
				{
					num = (short)319291392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1881079808;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenOptionsAudioMuting_A8623.Editable = value;
			}
		}

		// Token: 0x17003575 RID: 13685
		// (get) Token: 0x06006705 RID: 26373 RVA: 0x005C21A0 File Offset: 0x005C03A0
		internal string RadErgoWidePASirenOptionsAudioMuting_A8623_UILabel
		{
			get
			{
				short num = (short)2020092517;
				short num2 = num;
				num = (short)1398876773;
				switch (num2 == num)
				{
				}
				num = (short)390529024;
				short num3 = num;
				num = (short)860553217;
				if (num != 0)
				{
				}
				num = (short)545456128;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenOptionsAudioMuting_A8623.UIName;
			}
		}

		// Token: 0x17003576 RID: 13686
		// (get) Token: 0x06006706 RID: 26374 RVA: 0x005C2258 File Offset: 0x005C0458
		// (set) Token: 0x06006707 RID: 26375 RVA: 0x005C230C File Offset: 0x005C050C
		internal bool RadErgoWidePASirenOptionsAudioMuting_A8623_HiddenStatic
		{
			get
			{
				short num = (short)1668022273;
				if (num != 0)
				{
				}
				num = (short)1767938837;
				short num2 = num;
				num = (short)764451605;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1897005056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)428670976;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenOptionsAudioMuting_A8623.HiddenStatic;
			}
			set
			{
				short num = (short)937105118;
				short num2 = num;
				num = (short)1646008030;
				switch (num2 == num)
				{
				}
				num = (short)669646848;
				short num3 = num;
				num = (short)1214971904;
				if (num != 0)
				{
				}
				num = (short)2126708737;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenOptionsAudioMuting_A8623.HiddenStatic = value;
			}
		}

		// Token: 0x17003577 RID: 13687
		// (get) Token: 0x06006708 RID: 26376 RVA: 0x005C23C4 File Offset: 0x005C05C4
		// (set) Token: 0x06006709 RID: 26377 RVA: 0x005C2478 File Offset: 0x005C0678
		internal bool RadErgoWidePASirenOptionsAudioMuting_A8623_HiddenDynamic
		{
			get
			{
				short num = (short)2146483472;
				short num2 = num;
				num = (short)1434369296;
				switch (num2 == num)
				{
				}
				num = (short)846921728;
				short num3 = num;
				num = (short)2030370816;
				if (num != 0)
				{
				}
				num = (short)2034302977;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenOptionsAudioMuting_A8623.HiddenDynamic;
			}
			set
			{
				short num = (short)806717848;
				short num2 = num;
				num = (short)2048821656;
				switch (num2 == num)
				{
				}
				num = (short)465960960;
				short num3 = num;
				num = (short)1744437248;
				if (num != 0)
				{
				}
				num = (short)1757544449;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenOptionsAudioMuting_A8623.HiddenDynamic = value;
			}
		}

		// Token: 0x17003578 RID: 13688
		// (get) Token: 0x0600670A RID: 26378 RVA: 0x005C252C File Offset: 0x005C072C
		public bool RadErgoWidePASirenOptionsAudioMuting_A8623_HasDiffs
		{
			get
			{
				short num = (short)2035999354;
				short num2 = num;
				num = (short)1855971962;
				switch (num2 == num)
				{
				}
				num = (short)88276992;
				short num3 = num;
				num = (short)1073676289;
				if (num != 0)
				{
				}
				num = (short)282460160;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenOptionsAudioMuting_A8623._HasDiffs;
			}
		}

		// Token: 0x17003579 RID: 13689
		// (get) Token: 0x0600670B RID: 26379 RVA: 0x005C25E0 File Offset: 0x005C07E0
		// (set) Token: 0x0600670C RID: 26380 RVA: 0x005C2694 File Offset: 0x005C0894
		public bool RadErgoWidePASirenPAIgnitionSense_A8683Value
		{
			get
			{
				short num = (short)916845206;
				short num2 = num;
				num = (short)1653273238;
				switch (num2 == num)
				{
				}
				num = (short)1570242560;
				short num3 = num;
				num = (short)663027713;
				if (num != 0)
				{
				}
				num = (short)1153368064;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenPAIgnitionSense_A8683.Value;
			}
			set
			{
				short num = (short)1757615483;
				short num2 = num;
				num = (short)514135419;
				switch (num2 == num)
				{
				}
				num = (short)916783104;
				short num3 = num;
				num = (short)595918848;
				if (num != 0)
				{
				}
				num = (short)864813057;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenPAIgnitionSense_A8683.Value = value;
			}
		}

		// Token: 0x1700357A RID: 13690
		// (get) Token: 0x0600670D RID: 26381 RVA: 0x005C274C File Offset: 0x005C094C
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWidePASirenPAIgnitionSense_A8683
		{
			get
			{
				short num = (short)1790016565;
				short num2 = num;
				num = (short)1284013109;
				switch (num2 == num)
				{
				}
				num = (short)1046216704;
				short num3 = num;
				num = (short)110362625;
				if (num != 0)
				{
				}
				num = (short)1854865408;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenPAIgnitionSense_A8683;
			}
		}

		// Token: 0x1700357B RID: 13691
		// (get) Token: 0x0600670E RID: 26382 RVA: 0x005C27F8 File Offset: 0x005C09F8
		// (set) Token: 0x0600670F RID: 26383 RVA: 0x005C28B0 File Offset: 0x005C0AB0
		public bool RadErgoWidePASirenPAIgnitionSense_A8683_UIValue
		{
			get
			{
				short num = (short)706275723;
				short num2 = num;
				num = (short)571861387;
				switch (num2 == num)
				{
				}
				num = (short)2027356160;
				short num3 = num;
				num = (short)1573781505;
				if (num != 0)
				{
				}
				num = (short)1297612800;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenPAIgnitionSense_A8683.Value;
			}
			set
			{
				short num = (short)1556308340;
				short num2 = num;
				num = (short)701325684;
				switch (num2 == num)
				{
				}
				num = (short)214106112;
				short num3 = num;
				num = (short)1905000448;
				if (num != 0)
				{
				}
				num = (short)1678311425;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenPAIgnitionSense_A8683.Value = value;
			}
		}

		// Token: 0x1700357C RID: 13692
		// (get) Token: 0x06006710 RID: 26384 RVA: 0x005C2968 File Offset: 0x005C0B68
		// (set) Token: 0x06006711 RID: 26385 RVA: 0x005C2A20 File Offset: 0x005C0C20
		public bool RadErgoWidePASirenPAIgnitionSense_A8683_Applicable
		{
			get
			{
				short num = (short)1198306032;
				short num2 = num;
				num = (short)992391920;
				switch (num2 == num)
				{
				}
				num = (short)556859392;
				short num3 = num;
				num = (short)1145372672;
				if (num != 0)
				{
				}
				num = (short)1078657025;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenPAIgnitionSense_A8683.Applicable;
			}
			set
			{
				short num = (short)1316741703;
				short num2 = num;
				num = (short)725344839;
				switch (num2 == num)
				{
				}
				num = (short)661454848;
				short num3 = num;
				num = (short)743440384;
				if (num != 0)
				{
				}
				num = (short)1427701761;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenPAIgnitionSense_A8683.Applicable = value;
			}
		}

		// Token: 0x1700357D RID: 13693
		// (get) Token: 0x06006712 RID: 26386 RVA: 0x005C2AD4 File Offset: 0x005C0CD4
		// (set) Token: 0x06006713 RID: 26387 RVA: 0x005C2B88 File Offset: 0x005C0D88
		public bool RadErgoWidePASirenPAIgnitionSense_A8683_Valid
		{
			get
			{
				short num = (short)1974723091;
				short num2 = num;
				num = (short)1159258643;
				switch (num2 == num)
				{
				}
				num = (short)1244200960;
				short num3 = num;
				num = (short)638844929;
				if (num != 0)
				{
				}
				num = (short)550305792;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenPAIgnitionSense_A8683.Valid;
			}
			set
			{
				short num = (short)1196156826;
				short num2 = num;
				num = (short)734979994;
				switch (num2 == num)
				{
				}
				num = (short)579010560;
				short num3 = num;
				num = (short)62717952;
				if (num != 0)
				{
				}
				num = (short)1395326977;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenPAIgnitionSense_A8683.Valid = value;
			}
		}

		// Token: 0x1700357E RID: 13694
		// (get) Token: 0x06006714 RID: 26388 RVA: 0x005C2C3C File Offset: 0x005C0E3C
		// (set) Token: 0x06006715 RID: 26389 RVA: 0x005C2CF0 File Offset: 0x005C0EF0
		public bool RadErgoWidePASirenPAIgnitionSense_A8683_Visible
		{
			get
			{
				short num = (short)452832600;
				short num2 = num;
				num = (short)1842785624;
				switch (num2 == num)
				{
				}
				num = (short)1412562944;
				short num3 = num;
				num = (short)977993729;
				if (num != 0)
				{
				}
				num = (short)1998979072;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenPAIgnitionSense_A8683.Visible;
			}
			set
			{
				short num = (short)1504263439;
				short num2 = num;
				num = (short)89865487;
				switch (num2 == num)
				{
				}
				num = (short)1213530112;
				short num3 = num;
				num = (short)1845231616;
				if (num != 0)
				{
				}
				num = (short)1914503169;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenPAIgnitionSense_A8683.Visible = value;
			}
		}

		// Token: 0x1700357F RID: 13695
		// (get) Token: 0x06006716 RID: 26390 RVA: 0x005C2DA8 File Offset: 0x005C0FA8
		// (set) Token: 0x06006717 RID: 26391 RVA: 0x005C2E5C File Offset: 0x005C105C
		public bool RadErgoWidePASirenPAIgnitionSense_A8683_Editable
		{
			get
			{
				short num = (short)1469405280;
				short num2 = num;
				num = (short)1010784352;
				switch (num2 == num)
				{
				}
				num = (short)2110128128;
				short num3 = num;
				num = (short)883556353;
				if (num != 0)
				{
				}
				num = (short)550109184;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenPAIgnitionSense_A8683.Editable;
			}
			set
			{
				short num = (short)1159375484;
				short num2 = num;
				num = (short)403679868;
				switch (num2 == num)
				{
				}
				num = (short)1925906432;
				short num3 = num;
				num = (short)1374683136;
				if (num != 0)
				{
				}
				num = (short)160235521;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenPAIgnitionSense_A8683.Editable = value;
			}
		}

		// Token: 0x17003580 RID: 13696
		// (get) Token: 0x06006718 RID: 26392 RVA: 0x005C2F10 File Offset: 0x005C1110
		internal string RadErgoWidePASirenPAIgnitionSense_A8683_UILabel
		{
			get
			{
				short num = (short)406553468;
				short num2 = num;
				num = (short)1802339196;
				switch (num2 == num)
				{
				}
				num = (short)1920729088;
				short num3 = num;
				num = (short)1838874625;
				if (num != 0)
				{
				}
				num = (short)1317797888;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenPAIgnitionSense_A8683.UIName;
			}
		}

		// Token: 0x17003581 RID: 13697
		// (get) Token: 0x06006719 RID: 26393 RVA: 0x005C2FC4 File Offset: 0x005C11C4
		// (set) Token: 0x0600671A RID: 26394 RVA: 0x005C3078 File Offset: 0x005C1278
		internal bool RadErgoWidePASirenPAIgnitionSense_A8683_HiddenStatic
		{
			get
			{
				short num = (short)483112090;
				short num2 = num;
				num = (short)578466970;
				switch (num2 == num)
				{
				}
				num = (short)1926889472;
				short num3 = num;
				num = (short)1934295041;
				if (num != 0)
				{
				}
				num = (short)1593507840;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenPAIgnitionSense_A8683.HiddenStatic;
			}
			set
			{
				short num = (short)680387038;
				short num2 = num;
				num = (short)468640222;
				switch (num2 == num)
				{
				}
				num = (short)985071616;
				short num3 = num;
				num = (short)1567162369;
				if (num != 0)
				{
				}
				num = (short)69337088;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenPAIgnitionSense_A8683.HiddenStatic = value;
			}
		}

		// Token: 0x17003582 RID: 13698
		// (get) Token: 0x0600671B RID: 26395 RVA: 0x005C312C File Offset: 0x005C132C
		// (set) Token: 0x0600671C RID: 26396 RVA: 0x005C31E0 File Offset: 0x005C13E0
		internal bool RadErgoWidePASirenPAIgnitionSense_A8683_HiddenDynamic
		{
			get
			{
				short num = (short)762718861;
				short num2 = num;
				num = (short)1863985805;
				switch (num2 == num)
				{
				}
				num = (short)165543936;
				short num3 = num;
				num = (short)1953628161;
				if (num != 0)
				{
				}
				num = (short)310116352;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenPAIgnitionSense_A8683.HiddenDynamic;
			}
			set
			{
				short num = (short)2103010598;
				short num2 = num;
				num = (short)109208870;
				switch (num2 == num)
				{
				}
				num = (short)1554972672;
				short num3 = num;
				num = (short)909246464;
				if (num != 0)
				{
				}
				num = (short)1805189121;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenPAIgnitionSense_A8683.HiddenDynamic = value;
			}
		}

		// Token: 0x17003583 RID: 13699
		// (get) Token: 0x0600671D RID: 26397 RVA: 0x005C3294 File Offset: 0x005C1494
		public bool RadErgoWidePASirenPAIgnitionSense_A8683_HasDiffs
		{
			get
			{
				short num = (short)472911246;
				short num2 = num;
				num = (short)908529038;
				switch (num2 == num)
				{
				}
				num = (short)1319895040;
				short num3 = num;
				num = (short)1239285761;
				if (num != 0)
				{
				}
				num = (short)1278345216;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenPAIgnitionSense_A8683._HasDiffs;
			}
		}

		// Token: 0x17003584 RID: 13700
		// (get) Token: 0x0600671E RID: 26398 RVA: 0x005C3348 File Offset: 0x005C1548
		// (set) Token: 0x0600671F RID: 26399 RVA: 0x005C33FC File Offset: 0x005C15FC
		public bool RadErgoWidePASirenSirenIgnitionSense_A9138Value
		{
			get
			{
				short num = (short)809827918;
				short num2 = num;
				num = (short)1848114766;
				switch (num2 == num)
				{
				}
				num = (short)139264000;
				short num3 = num;
				num = (short)1680277505;
				if (num != 0)
				{
				}
				num = (short)1261109248;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenIgnitionSense_A9138.Value;
			}
			set
			{
				short num = (short)576728201;
				short num2 = num;
				num = (short)411118729;
				switch (num2 == num)
				{
				}
				num = (short)254803968;
				short num3 = num;
				num = (short)1975910400;
				if (num != 0)
				{
				}
				num = (short)501874689;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenSirenIgnitionSense_A9138.Value = value;
			}
		}

		// Token: 0x17003585 RID: 13701
		// (get) Token: 0x06006720 RID: 26400 RVA: 0x005C34B0 File Offset: 0x005C16B0
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWidePASirenSirenIgnitionSense_A9138
		{
			get
			{
				short num = (short)1050544811;
				short num2 = num;
				num = (short)2127956651;
				switch (num2 == num)
				{
				}
				num = (short)682098688;
				short num3 = num;
				num = (short)369033217;
				if (num != 0)
				{
				}
				num = (short)1511194624;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenIgnitionSense_A9138;
			}
		}

		// Token: 0x17003586 RID: 13702
		// (get) Token: 0x06006721 RID: 26401 RVA: 0x005C3560 File Offset: 0x005C1760
		// (set) Token: 0x06006722 RID: 26402 RVA: 0x005C3614 File Offset: 0x005C1814
		public bool RadErgoWidePASirenSirenIgnitionSense_A9138_UIValue
		{
			get
			{
				short num = (short)1471663342;
				short num2 = num;
				num = (short)658754798;
				switch (num2 == num)
				{
				}
				num = (short)1851392000;
				short num3 = num;
				num = (short)2118189056;
				if (num != 0)
				{
				}
				num = (short)1115029505;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenIgnitionSense_A9138.Value;
			}
			set
			{
				short num = (short)947089026;
				short num2 = num;
				num = (short)843673218;
				switch (num2 == num)
				{
				}
				num = (short)938344448;
				short num3 = num;
				num = (short)1553334273;
				if (num != 0)
				{
				}
				num = (short)1498218496;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenSirenIgnitionSense_A9138.Value = value;
			}
		}

		// Token: 0x17003587 RID: 13703
		// (get) Token: 0x06006723 RID: 26403 RVA: 0x005C36CC File Offset: 0x005C18CC
		// (set) Token: 0x06006724 RID: 26404 RVA: 0x005C3780 File Offset: 0x005C1980
		public bool RadErgoWidePASirenSirenIgnitionSense_A9138_Applicable
		{
			get
			{
				short num = (short)641706600;
				short num2 = num;
				num = (short)38447720;
				switch (num2 == num)
				{
				}
				num = (short)2015100928;
				short num3 = num;
				num = (short)687144960;
				if (num != 0)
				{
				}
				num = (short)1096810497;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenIgnitionSense_A9138.Applicable;
			}
			set
			{
				short num = (short)1523119677;
				short num2 = num;
				num = (short)1940518461;
				switch (num2 == num)
				{
				}
				num = (short)1082589184;
				short num3 = num;
				num = (short)1214185472;
				if (num != 0)
				{
				}
				num = (short)803864577;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenSirenIgnitionSense_A9138.Applicable = value;
			}
		}

		// Token: 0x17003588 RID: 13704
		// (get) Token: 0x06006725 RID: 26405 RVA: 0x005C3838 File Offset: 0x005C1A38
		// (set) Token: 0x06006726 RID: 26406 RVA: 0x005C38EC File Offset: 0x005C1AEC
		public bool RadErgoWidePASirenSirenIgnitionSense_A9138_Valid
		{
			get
			{
				short num = (short)637250543;
				short num2 = num;
				num = (short)57191407;
				switch (num2 == num)
				{
				}
				num = (short)1663500288;
				short num3 = num;
				num = (short)1254096897;
				if (num != 0)
				{
				}
				num = (short)677314560;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenIgnitionSense_A9138.Valid;
			}
			set
			{
				short num = (short)1270126190;
				short num2 = num;
				num = (short)1565103726;
				switch (num2 == num)
				{
				}
				num = (short)1346240512;
				short num3 = num;
				num = (short)1960378368;
				if (num != 0)
				{
				}
				num = (short)656867329;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenSirenIgnitionSense_A9138.Valid = value;
			}
		}

		// Token: 0x17003589 RID: 13705
		// (get) Token: 0x06006727 RID: 26407 RVA: 0x005C39A0 File Offset: 0x005C1BA0
		// (set) Token: 0x06006728 RID: 26408 RVA: 0x005C3A54 File Offset: 0x005C1C54
		public bool RadErgoWidePASirenSirenIgnitionSense_A9138_Visible
		{
			get
			{
				short num = (short)1941831681;
				if (num != 0)
				{
				}
				num = (short)141573486;
				short num2 = num;
				num = (short)623656302;
				switch (num2 == num)
				{
				default:
				{
					num = (short)374800384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2033844224;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenIgnitionSense_A9138.Visible;
			}
			set
			{
				short num = (short)1921746298;
				short num2 = num;
				num = (short)133006714;
				switch (num2 == num)
				{
				}
				num = (short)1823604736;
				short num3 = num;
				num = (short)1339817985;
				if (num != 0)
				{
				}
				num = (short)297730048;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenSirenIgnitionSense_A9138.Visible = value;
			}
		}

		// Token: 0x1700358A RID: 13706
		// (get) Token: 0x06006729 RID: 26409 RVA: 0x005C3B0C File Offset: 0x005C1D0C
		// (set) Token: 0x0600672A RID: 26410 RVA: 0x005C3BBC File Offset: 0x005C1DBC
		public bool RadErgoWidePASirenSirenIgnitionSense_A9138_Editable
		{
			get
			{
				short num = (short)1161494318;
				short num2 = num;
				num = (short)1747058478;
				switch (num2 == num)
				{
				}
				num = (short)619446272;
				short num3 = num;
				num = (short)1217069057;
				if (num != 0)
				{
				}
				num = (short)1683554304;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenIgnitionSense_A9138.Editable;
			}
			set
			{
				short num = (short)1853227009;
				if (num != 0)
				{
				}
				num = (short)888993138;
				short num2 = num;
				num = (short)993916274;
				switch (num2 == num)
				{
				default:
				{
					num = (short)446693376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)819986432;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenSirenIgnitionSense_A9138.Editable = value;
			}
		}

		// Token: 0x1700358B RID: 13707
		// (get) Token: 0x0600672B RID: 26411 RVA: 0x005C3C74 File Offset: 0x005C1E74
		internal string RadErgoWidePASirenSirenIgnitionSense_A9138_UILabel
		{
			get
			{
				short num = (short)256973621;
				short num2 = num;
				num = (short)468392757;
				switch (num2 == num)
				{
				}
				num = (short)681443328;
				short num3 = num;
				num = (short)2121465856;
				if (num != 0)
				{
				}
				num = (short)1371340801;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenIgnitionSense_A9138.UIName;
			}
		}

		// Token: 0x1700358C RID: 13708
		// (get) Token: 0x0600672C RID: 26412 RVA: 0x005C3D28 File Offset: 0x005C1F28
		// (set) Token: 0x0600672D RID: 26413 RVA: 0x005C3DDC File Offset: 0x005C1FDC
		internal bool RadErgoWidePASirenSirenIgnitionSense_A9138_HiddenStatic
		{
			get
			{
				short num = (short)1964616863;
				short num2 = num;
				num = (short)2137042079;
				switch (num2 == num)
				{
				}
				num = (short)1272119296;
				short num3 = num;
				num = (short)1901133824;
				if (num != 0)
				{
				}
				num = (short)784334849;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenIgnitionSense_A9138.HiddenStatic;
			}
			set
			{
				short num = (short)129901804;
				short num2 = num;
				num = (short)1711613164;
				switch (num2 == num)
				{
				}
				num = (short)2090926080;
				short num3 = num;
				num = (short)275513344;
				if (num != 0)
				{
				}
				num = (short)1191641089;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenSirenIgnitionSense_A9138.HiddenStatic = value;
			}
		}

		// Token: 0x1700358D RID: 13709
		// (get) Token: 0x0600672E RID: 26414 RVA: 0x005C3E94 File Offset: 0x005C2094
		// (set) Token: 0x0600672F RID: 26415 RVA: 0x005C3F4C File Offset: 0x005C214C
		internal bool RadErgoWidePASirenSirenIgnitionSense_A9138_HiddenDynamic
		{
			get
			{
				short num = (short)2072361314;
				short num2 = num;
				num = (short)340834658;
				switch (num2 == num)
				{
				}
				num = (short)217317376;
				short num3 = num;
				num = (short)504102913;
				if (num != 0)
				{
				}
				num = (short)256376832;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenIgnitionSense_A9138.HiddenDynamic;
			}
			set
			{
				short num = (short)1836999834;
				short num2 = num;
				num = (short)1800037530;
				switch (num2 == num)
				{
				}
				num = (short)1041432576;
				short num3 = num;
				num = (short)804585472;
				if (num != 0)
				{
				}
				num = (short)1564999681;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenSirenIgnitionSense_A9138.HiddenDynamic = value;
			}
		}

		// Token: 0x1700358E RID: 13710
		// (get) Token: 0x06006730 RID: 26416 RVA: 0x005C4000 File Offset: 0x005C2200
		public bool RadErgoWidePASirenSirenIgnitionSense_A9138_HasDiffs
		{
			get
			{
				short num = (short)1545535489;
				if (num != 0)
				{
				}
				num = (short)1265269068;
				short num2 = num;
				num = (short)1626962252;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1521614848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)129236992;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenIgnitionSense_A9138._HasDiffs;
			}
		}

		// Token: 0x1700358F RID: 13711
		// (get) Token: 0x06006731 RID: 26417 RVA: 0x005C40B8 File Offset: 0x005C22B8
		// (set) Token: 0x06006732 RID: 26418 RVA: 0x005C416C File Offset: 0x005C236C
		public int RadErgoWidePASirenSirenOperation_A9139Value
		{
			get
			{
				short num = (short)1255706547;
				short num2 = num;
				num = (short)472485811;
				switch (num2 == num)
				{
				}
				num = (short)2046754816;
				short num3 = num;
				num = (short)908722176;
				if (num != 0)
				{
				}
				num = (short)2111832065;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenOperation_A9139.Value;
			}
			set
			{
				short num = (short)1391384687;
				short num2 = num;
				num = (short)605214831;
				switch (num2 == num)
				{
				}
				num = (short)908132352;
				short num3 = num;
				num = (short)1660747777;
				if (num != 0)
				{
				}
				num = (short)192806912;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenSirenOperation_A9139.Value = value;
			}
		}

		// Token: 0x17003590 RID: 13712
		// (get) Token: 0x06006733 RID: 26419 RVA: 0x005C4220 File Offset: 0x005C2420
		// (set) Token: 0x06006734 RID: 26420 RVA: 0x005C42D4 File Offset: 0x005C24D4
		public string RadErgoWidePASirenSirenOperation_A9139_UIValue
		{
			get
			{
				short num = (short)1447589792;
				short num2 = num;
				num = (short)1637971872;
				switch (num2 == num)
				{
				}
				num = (short)138477568;
				short num3 = num;
				num = (short)853278721;
				if (num != 0)
				{
				}
				num = (short)399507456;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenOperation_A9139.UIValue;
			}
			set
			{
				short num = (short)1920821813;
				short num2 = num;
				num = (short)542403125;
				switch (num2 == num)
				{
				}
				num = (short)1025048576;
				short num3 = num;
				num = (short)407502848;
				if (num != 0)
				{
				}
				num = (short)455540737;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenSirenOperation_A9139.UIValue = value;
			}
		}

		// Token: 0x17003591 RID: 13713
		// (get) Token: 0x06006735 RID: 26421 RVA: 0x005C438C File Offset: 0x005C258C
		public global::AcpBusinessLayer.AcpListField RadErgoWidePASirenSirenOperation_A9139
		{
			get
			{
				short num = (short)1728982937;
				short num2 = num;
				num = (short)237383577;
				switch (num2 == num)
				{
				}
				num = (short)1429929984;
				short num3 = num;
				num = (short)1396703232;
				if (num != 0)
				{
				}
				num = (short)1377173505;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenOperation_A9139;
			}
		}

		// Token: 0x17003592 RID: 13714
		// (get) Token: 0x06006736 RID: 26422 RVA: 0x005C4438 File Offset: 0x005C2638
		// (set) Token: 0x06006737 RID: 26423 RVA: 0x005C44EC File Offset: 0x005C26EC
		public bool RadErgoWidePASirenSirenOperation_A9139_Applicable
		{
			get
			{
				short num = (short)685210808;
				short num2 = num;
				num = (short)728595640;
				switch (num2 == num)
				{
				}
				num = (short)653197312;
				short num3 = num;
				num = (short)1073872896;
				if (num != 0)
				{
				}
				num = (short)91947009;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenOperation_A9139.Applicable;
			}
			set
			{
				short num = (short)1501922235;
				short num2 = num;
				num = (short)1846248379;
				switch (num2 == num)
				{
				}
				num = (short)857145344;
				short num3 = num;
				num = (short)1233125377;
				if (num != 0)
				{
				}
				num = (short)1680736256;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenSirenOperation_A9139.Applicable = value;
			}
		}

		// Token: 0x17003593 RID: 13715
		// (get) Token: 0x06006738 RID: 26424 RVA: 0x005C45A0 File Offset: 0x005C27A0
		// (set) Token: 0x06006739 RID: 26425 RVA: 0x005C4658 File Offset: 0x005C2858
		public bool RadErgoWidePASirenSirenOperation_A9139_Valid
		{
			get
			{
				short num = (short)1991539416;
				short num2 = num;
				num = (short)888699608;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1742929920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)88866817;
				if (num != 0)
				{
				}
				num = (short)1294991360;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenOperation_A9139.Valid;
			}
			set
			{
				short num = (short)1437393742;
				short num2 = num;
				num = (short)303031118;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1412628480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1574371329;
				if (num != 0)
				{
				}
				num = (short)793051136;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenSirenOperation_A9139.Valid = value;
			}
		}

		// Token: 0x17003594 RID: 13716
		// (get) Token: 0x0600673A RID: 26426 RVA: 0x005C470C File Offset: 0x005C290C
		// (set) Token: 0x0600673B RID: 26427 RVA: 0x005C47C0 File Offset: 0x005C29C0
		public bool RadErgoWidePASirenSirenOperation_A9139_Visible
		{
			get
			{
				short num = (short)833520452;
				short num2 = num;
				num = (short)261784388;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2073690112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)630980609;
				if (num != 0)
				{
				}
				num = (short)1048313856;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenOperation_A9139.Visible;
			}
			set
			{
				short num = (short)1525580896;
				short num2 = num;
				num = (short)1802208352;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1481965568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1332871168;
				if (num != 0)
				{
				}
				num = (short)1000210433;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenSirenOperation_A9139.Visible = value;
			}
		}

		// Token: 0x17003595 RID: 13717
		// (get) Token: 0x0600673C RID: 26428 RVA: 0x005C4874 File Offset: 0x005C2A74
		// (set) Token: 0x0600673D RID: 26429 RVA: 0x005C4928 File Offset: 0x005C2B28
		public bool RadErgoWidePASirenSirenOperation_A9139_Editable
		{
			get
			{
				short num = (short)1965049991;
				short num2 = num;
				num = (short)1866942599;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1415118848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)129236993;
				if (num != 0)
				{
				}
				num = (short)1104674816;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenOperation_A9139.Editable;
			}
			set
			{
				short num = (short)1692299400;
				short num2 = num;
				num = (short)1647669384;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1550450688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1880883200;
				if (num != 0)
				{
				}
				num = (short)1815609345;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenSirenOperation_A9139.Editable = value;
			}
		}

		// Token: 0x17003596 RID: 13718
		// (get) Token: 0x0600673E RID: 26430 RVA: 0x005C49DC File Offset: 0x005C2BDC
		internal string RadErgoWidePASirenSirenOperation_A9139_UILabel
		{
			get
			{
				short num = (short)2068578305;
				if (num != 0)
				{
				}
				num = (short)1957494784;
				short num2 = num;
				num = (short)1438757304;
				short num3 = num;
				num = (short)1313452472;
				switch (num3 == num)
				{
				}
				num = (short)269352960;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenOperation_A9139.UIName;
			}
		}

		// Token: 0x17003597 RID: 13719
		// (get) Token: 0x0600673F RID: 26431 RVA: 0x005C4A90 File Offset: 0x005C2C90
		// (set) Token: 0x06006740 RID: 26432 RVA: 0x005C4B44 File Offset: 0x005C2D44
		internal bool RadErgoWidePASirenSirenOperation_A9139_HiddenStatic
		{
			get
			{
				short num = (short)566538113;
				short num2 = num;
				num = (short)743092097;
				switch (num2 == num)
				{
				default:
				{
					num = (short)104857600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)735248385;
				if (num != 0)
				{
				}
				num = (short)237633536;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenOperation_A9139.HiddenStatic;
			}
			set
			{
				short num = (short)1168608073;
				short num2 = num;
				num = (short)1137150793;
				switch (num2 == num)
				{
				default:
				{
					num = (short)782106624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2090008577;
				if (num != 0)
				{
				}
				num = (short)1422786560;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenSirenOperation_A9139.HiddenStatic = value;
			}
		}

		// Token: 0x17003598 RID: 13720
		// (get) Token: 0x06006741 RID: 26433 RVA: 0x005C4BFC File Offset: 0x005C2DFC
		// (set) Token: 0x06006742 RID: 26434 RVA: 0x005C4CB0 File Offset: 0x005C2EB0
		internal bool RadErgoWidePASirenSirenOperation_A9139_HiddenDynamic
		{
			get
			{
				short num = (short)749188593;
				short num2 = num;
				num = (short)1264432625;
				switch (num2 == num)
				{
				default:
				{
					num = (short)164167680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)39780352;
				if (num != 0)
				{
				}
				num = (short)560005121;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenOperation_A9139.HiddenDynamic;
			}
			set
			{
				short num = (short)1955522538;
				short num2 = num;
				num = (short)168421354;
				switch (num2 == num)
				{
				default:
				{
					num = (short)448528384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1024000000;
				if (num != 0)
				{
				}
				num = (short)1101070337;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenSirenOperation_A9139.HiddenDynamic = value;
			}
		}

		// Token: 0x17003599 RID: 13721
		// (get) Token: 0x06006743 RID: 26435 RVA: 0x005C4D64 File Offset: 0x005C2F64
		public bool RadErgoWidePASirenSirenOperation_A9139_HasDiffs
		{
			get
			{
				short num = (short)711018637;
				short num2 = num;
				num = (short)1473726605;
				switch (num2 == num)
				{
				default:
				{
					num = (short)825098240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1684078592;
				if (num != 0)
				{
				}
				num = (short)292749313;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenOperation_A9139._HasDiffs;
			}
		}

		// Token: 0x1700359A RID: 13722
		// (get) Token: 0x06006744 RID: 26436 RVA: 0x005C4E18 File Offset: 0x005C3018
		// (set) Token: 0x06006745 RID: 26437 RVA: 0x005C4ECC File Offset: 0x005C30CC
		public int RadErgoWidePASirenSirenPAAfterReset_A9140Value
		{
			get
			{
				short num = (short)935267762;
				short num2 = num;
				num = (short)342625714;
				switch (num2 == num)
				{
				default:
				{
					num = (short)69992448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)775618561;
				if (num != 0)
				{
				}
				num = (short)1044578304;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenPAAfterReset_A9140.Value;
			}
			set
			{
				short num = (short)938557219;
				short num2 = num;
				num = (short)1813331747;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1828847616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2002059265;
				if (num != 0)
				{
				}
				num = (short)368771072;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenSirenPAAfterReset_A9140.Value = value;
			}
		}

		// Token: 0x1700359B RID: 13723
		// (get) Token: 0x06006746 RID: 26438 RVA: 0x005C4F84 File Offset: 0x005C3184
		// (set) Token: 0x06006747 RID: 26439 RVA: 0x005C503C File Offset: 0x005C323C
		public string RadErgoWidePASirenSirenPAAfterReset_A9140_UIValue
		{
			get
			{
				short num = (short)2102029110;
				short num2 = num;
				num = (short)2129423158;
				switch (num2 == num)
				{
				default:
				{
					num = (short)973406208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)248250368;
				if (num != 0)
				{
				}
				num = (short)2011299841;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenPAAfterReset_A9140.UIValue;
			}
			set
			{
				short num = (short)1121519361;
				short num2 = num;
				num = (short)753338113;
				switch (num2 == num)
				{
				default:
				{
					num = (short)991297536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)784465921;
				if (num != 0)
				{
				}
				num = (short)1247805440;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenSirenPAAfterReset_A9140.UIValue = value;
			}
		}

		// Token: 0x1700359C RID: 13724
		// (get) Token: 0x06006748 RID: 26440 RVA: 0x005C50F0 File Offset: 0x005C32F0
		public global::AcpBusinessLayer.AcpListField RadErgoWidePASirenSirenPAAfterReset_A9140
		{
			get
			{
				short num = (short)236322817;
				if (num != 0)
				{
				}
				num = (short)485359616;
				short num2 = num;
				num = (short)1040731096;
				short num3 = num;
				num = (short)944851928;
				switch (num3 == num)
				{
				}
				num = (short)1707409408;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenPAAfterReset_A9140;
			}
		}

		// Token: 0x1700359D RID: 13725
		// (get) Token: 0x06006749 RID: 26441 RVA: 0x005C51A0 File Offset: 0x005C33A0
		// (set) Token: 0x0600674A RID: 26442 RVA: 0x005C5258 File Offset: 0x005C3458
		public bool RadErgoWidePASirenSirenPAAfterReset_A9140_Applicable
		{
			get
			{
				short num = (short)209846273;
				if (num != 0)
				{
				}
				num = (short)1041498112;
				short num2 = num;
				num = (short)58631333;
				short num3 = num;
				num = (short)369337509;
				switch (num3 == num)
				{
				}
				num = (short)360644608;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenPAAfterReset_A9140.Applicable;
			}
			set
			{
				short num = (short)406938144;
				short num2 = num;
				num = (short)740385312;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1718026240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)270532608;
				if (num != 0)
				{
				}
				num = (short)1591672833;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenSirenPAAfterReset_A9140.Applicable = value;
			}
		}

		// Token: 0x1700359E RID: 13726
		// (get) Token: 0x0600674B RID: 26443 RVA: 0x005C530C File Offset: 0x005C350C
		// (set) Token: 0x0600674C RID: 26444 RVA: 0x005C53C0 File Offset: 0x005C35C0
		public bool RadErgoWidePASirenSirenPAAfterReset_A9140_Valid
		{
			get
			{
				short num = (short)1620422186;
				short num2 = num;
				num = (short)1124838954;
				switch (num2 == num)
				{
				default:
				{
					num = (short)739508224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1570045953;
				if (num != 0)
				{
				}
				num = (short)1471414272;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenPAAfterReset_A9140.Valid;
			}
			set
			{
				short num = (short)2062763933;
				short num2 = num;
				num = (short)2117879709;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1844576256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)626982913;
				if (num != 0)
				{
				}
				num = (short)1208221696;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenSirenPAAfterReset_A9140.Valid = value;
			}
		}

		// Token: 0x1700359F RID: 13727
		// (get) Token: 0x0600674D RID: 26445 RVA: 0x005C5478 File Offset: 0x005C3678
		// (set) Token: 0x0600674E RID: 26446 RVA: 0x005C552C File Offset: 0x005C372C
		public bool RadErgoWidePASirenSirenPAAfterReset_A9140_Visible
		{
			get
			{
				short num = (short)1677737259;
				short num2 = num;
				num = (short)913521963;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1873346560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1422196736;
				if (num != 0)
				{
				}
				num = (short)1790640129;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenPAAfterReset_A9140.Visible;
			}
			set
			{
				short num = (short)18415069;
				short num2 = num;
				num = (short)1786379741;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1238433792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1803091968;
				if (num != 0)
				{
				}
				num = (short)1791754241;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenSirenPAAfterReset_A9140.Visible = value;
			}
		}

		// Token: 0x170035A0 RID: 13728
		// (get) Token: 0x0600674F RID: 26447 RVA: 0x005C55E0 File Offset: 0x005C37E0
		// (set) Token: 0x06006750 RID: 26448 RVA: 0x005C5690 File Offset: 0x005C3890
		public bool RadErgoWidePASirenSirenPAAfterReset_A9140_Editable
		{
			get
			{
				short num = (short)201940624;
				short num2 = num;
				num = (short)2145476240;
				switch (num2 == num)
				{
				default:
				{
					num = (short)908525568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1051852801;
				if (num != 0)
				{
				}
				num = (short)2067791872;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenPAAfterReset_A9140.Editable;
			}
			set
			{
				short num = (short)99416887;
				short num2 = num;
				num = (short)466615095;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1607204864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)60686336;
				if (num != 0)
				{
				}
				num = (short)994377729;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenSirenPAAfterReset_A9140.Editable = value;
			}
		}

		// Token: 0x170035A1 RID: 13729
		// (get) Token: 0x06006751 RID: 26449 RVA: 0x005C5748 File Offset: 0x005C3948
		internal string RadErgoWidePASirenSirenPAAfterReset_A9140_UILabel
		{
			get
			{
				short num = (short)394296643;
				short num2 = num;
				num = (short)192707907;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1682964480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1945370625;
				if (num != 0)
				{
				}
				num = (short)30408704;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenPAAfterReset_A9140.UIName;
			}
		}

		// Token: 0x170035A2 RID: 13730
		// (get) Token: 0x06006752 RID: 26450 RVA: 0x005C5800 File Offset: 0x005C3A00
		// (set) Token: 0x06006753 RID: 26451 RVA: 0x005C58B4 File Offset: 0x005C3AB4
		internal bool RadErgoWidePASirenSirenPAAfterReset_A9140_HiddenStatic
		{
			get
			{
				short num = (short)837287937;
				if (num != 0)
				{
				}
				num = (short)903020544;
				short num2 = num;
				num = (short)119845184;
				short num3 = num;
				num = (short)896119104;
				switch (num3 == num)
				{
				}
				num = (short)111411200;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenPAAfterReset_A9140.HiddenStatic;
			}
			set
			{
				short num = (short)1862598657;
				if (num != 0)
				{
				}
				num = (short)53084160;
				short num2 = num;
				num = (short)983750003;
				short num3 = num;
				num = (short)1204540787;
				switch (num3 == num)
				{
				}
				num = (short)141950976;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenSirenPAAfterReset_A9140.HiddenStatic = value;
			}
		}

		// Token: 0x170035A3 RID: 13731
		// (get) Token: 0x06006754 RID: 26452 RVA: 0x005C596C File Offset: 0x005C3B6C
		// (set) Token: 0x06006755 RID: 26453 RVA: 0x005C5A24 File Offset: 0x005C3C24
		internal bool RadErgoWidePASirenSirenPAAfterReset_A9140_HiddenDynamic
		{
			get
			{
				short num = (short)448017695;
				short num2 = num;
				num = (short)461387039;
				switch (num2 == num)
				{
				default:
				{
					num = (short)767164416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2121072641;
				if (num != 0)
				{
				}
				num = (short)801505280;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenPAAfterReset_A9140.HiddenDynamic;
			}
			set
			{
				short num = (short)1236043438;
				short num2 = num;
				num = (short)205948590;
				switch (num2 == num)
				{
				default:
				{
					num = (short)129564672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1804730369;
				if (num != 0)
				{
				}
				num = (short)735641600;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenSirenPAAfterReset_A9140.HiddenDynamic = value;
			}
		}

		// Token: 0x170035A4 RID: 13732
		// (get) Token: 0x06006756 RID: 26454 RVA: 0x005C5AD8 File Offset: 0x005C3CD8
		public bool RadErgoWidePASirenSirenPAAfterReset_A9140_HasDiffs
		{
			get
			{
				short num = (short)610074625;
				if (num != 0)
				{
				}
				num = (short)66650112;
				short num2 = num;
				num = (short)212320852;
				short num3 = num;
				num = (short)389399124;
				switch (num3 == num)
				{
				}
				num = (short)1329266688;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenSirenPAAfterReset_A9140._HasDiffs;
			}
		}

		// Token: 0x170035A5 RID: 13733
		// (get) Token: 0x06006757 RID: 26455 RVA: 0x005C5B88 File Offset: 0x005C3D88
		// (set) Token: 0x06006758 RID: 26456 RVA: 0x005C5C3C File Offset: 0x005C3E3C
		public bool RadErgoWidePASirenHiLoAirhornTones_A8200Value
		{
			get
			{
				short num = (short)903338770;
				short num2 = num;
				num = (short)1025366802;
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
				num = (short)311820288;
				if (num != 0)
				{
				}
				num = (short)429326337;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenHiLoAirhornTones_A8200.Value;
			}
			set
			{
				short num = (short)828637185;
				if (num != 0)
				{
				}
				num = (short)778895360;
				short num2 = num;
				num = (short)1910526005;
				short num3 = num;
				num = (short)1330008117;
				switch (num3 == num)
				{
				}
				num = (short)1014956032;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenHiLoAirhornTones_A8200.Value = value;
			}
		}

		// Token: 0x170035A6 RID: 13734
		// (get) Token: 0x06006759 RID: 26457 RVA: 0x005C5CF0 File Offset: 0x005C3EF0
		public global::AcpBusinessLayer.AcpFieldX<bool, bool> RadErgoWidePASirenHiLoAirhornTones_A8200
		{
			get
			{
				short num = (short)1343422465;
				if (num != 0)
				{
				}
				num = (short)645332992;
				short num2 = num;
				num = (short)1553263302;
				short num3 = num;
				num = (short)1657334470;
				switch (num3 == num)
				{
				}
				num = (short)259588096;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenHiLoAirhornTones_A8200;
			}
		}

		// Token: 0x170035A7 RID: 13735
		// (get) Token: 0x0600675A RID: 26458 RVA: 0x005C5D9C File Offset: 0x005C3F9C
		// (set) Token: 0x0600675B RID: 26459 RVA: 0x005C5E50 File Offset: 0x005C4050
		public bool RadErgoWidePASirenHiLoAirhornTones_A8200_UIValue
		{
			get
			{
				short num = (short)1263480720;
				short num2 = num;
				num = (short)1165832080;
				switch (num2 == num)
				{
				default:
				{
					num = (short)325582848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1033371649;
				if (num != 0)
				{
				}
				num = (short)247267328;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenHiLoAirhornTones_A8200.UIValue;
			}
			set
			{
				short num = (short)1253839599;
				short num2 = num;
				num = (short)1229918959;
				switch (num2 == num)
				{
				default:
				{
					num = (short)232652800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)369557505;
				if (num != 0)
				{
				}
				num = (short)1252589568;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenHiLoAirhornTones_A8200.UIValue = value;
			}
		}

		// Token: 0x170035A8 RID: 13736
		// (get) Token: 0x0600675C RID: 26460 RVA: 0x005C5F04 File Offset: 0x005C4104
		// (set) Token: 0x0600675D RID: 26461 RVA: 0x005C5FB8 File Offset: 0x005C41B8
		public bool RadErgoWidePASirenHiLoAirhornTones_A8200_Applicable
		{
			get
			{
				short num = (short)1766729899;
				short num2 = num;
				num = (short)179513515;
				switch (num2 == num)
				{
				default:
				{
					num = (short)807862272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1028194304;
				if (num != 0)
				{
				}
				num = (short)1577648129;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenHiLoAirhornTones_A8200.Applicable;
			}
			set
			{
				short num = (short)1050153486;
				short num2 = num;
				num = (short)559485454;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1454243840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)602079232;
				if (num != 0)
				{
				}
				num = (short)25624577;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenHiLoAirhornTones_A8200.Applicable = value;
			}
		}

		// Token: 0x170035A9 RID: 13737
		// (get) Token: 0x0600675E RID: 26462 RVA: 0x005C6070 File Offset: 0x005C4270
		// (set) Token: 0x0600675F RID: 26463 RVA: 0x005C6124 File Offset: 0x005C4324
		public bool RadErgoWidePASirenHiLoAirhornTones_A8200_Valid
		{
			get
			{
				short num = (short)1927738598;
				short num2 = num;
				num = (short)614200550;
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
				num = (short)1139802113;
				if (num != 0)
				{
				}
				num = (short)1692270592;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenHiLoAirhornTones_A8200.Valid;
			}
			set
			{
				short num = (short)2057901298;
				short num2 = num;
				num = (short)252974322;
				switch (num2 == num)
				{
				default:
				{
					num = (short)925302784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1953824769;
				if (num != 0)
				{
				}
				num = (short)643301376;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenHiLoAirhornTones_A8200.Valid = value;
			}
		}

		// Token: 0x170035AA RID: 13738
		// (get) Token: 0x06006760 RID: 26464 RVA: 0x005C61D8 File Offset: 0x005C43D8
		// (set) Token: 0x06006761 RID: 26465 RVA: 0x005C628C File Offset: 0x005C448C
		public bool RadErgoWidePASirenHiLoAirhornTones_A8200_Visible
		{
			get
			{
				short num = (short)1315065206;
				short num2 = num;
				num = (short)1072385398;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1287913472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1536491521;
				if (num != 0)
				{
				}
				num = (short)595263488;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenHiLoAirhornTones_A8200.Visible;
			}
			set
			{
				short num = (short)24462832;
				short num2 = num;
				num = (short)1908819440;
				switch (num2 == num)
				{
				default:
				{
					num = (short)78708736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)13697024;
				if (num != 0)
				{
				}
				num = (short)2133000193;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenHiLoAirhornTones_A8200.Visible = value;
			}
		}

		// Token: 0x170035AB RID: 13739
		// (get) Token: 0x06006762 RID: 26466 RVA: 0x005C6340 File Offset: 0x005C4540
		// (set) Token: 0x06006763 RID: 26467 RVA: 0x005C63F4 File Offset: 0x005C45F4
		public bool RadErgoWidePASirenHiLoAirhornTones_A8200_Editable
		{
			get
			{
				short num = (short)336039916;
				short num2 = num;
				num = (short)1675244;
				switch (num2 == num)
				{
				default:
				{
					num = (short)485425152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)620363776;
				if (num != 0)
				{
				}
				num = (short)1015218177;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenHiLoAirhornTones_A8200.Editable;
			}
			set
			{
				short num = (short)397670062;
				short num2 = num;
				num = (short)234944174;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1665138688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)991559681;
				if (num != 0)
				{
				}
				num = (short)1496121344;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenHiLoAirhornTones_A8200.Editable = value;
			}
		}

		// Token: 0x170035AC RID: 13740
		// (get) Token: 0x06006764 RID: 26468 RVA: 0x005C64A8 File Offset: 0x005C46A8
		internal string RadErgoWidePASirenHiLoAirhornTones_A8200_UILabel
		{
			get
			{
				short num = (short)1155465217;
				if (num != 0)
				{
				}
				num = (short)1240596480;
				short num2 = num;
				num = (short)1625177345;
				short num3 = num;
				num = (short)1051213057;
				switch (num3 == num)
				{
				}
				num = (short)916783104;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenHiLoAirhornTones_A8200.UIName;
			}
		}

		// Token: 0x170035AD RID: 13741
		// (get) Token: 0x06006765 RID: 26469 RVA: 0x005C655C File Offset: 0x005C475C
		// (set) Token: 0x06006766 RID: 26470 RVA: 0x005C6610 File Offset: 0x005C4810
		internal bool RadErgoWidePASirenHiLoAirhornTones_A8200_HiddenStatic
		{
			get
			{
				short num = (short)2025746645;
				short num2 = num;
				num = (short)1980264661;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2147090432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1168048129;
				if (num != 0)
				{
				}
				num = (short)1612709888;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenHiLoAirhornTones_A8200.HiddenStatic;
			}
			set
			{
				short num = (short)45023233;
				if (num != 0)
				{
				}
				num = (short)1268580352;
				short num2 = num;
				num = (short)967923431;
				short num3 = num;
				num = (short)1077630695;
				switch (num3 == num)
				{
				}
				num = (short)1144061952;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenHiLoAirhornTones_A8200.HiddenStatic = value;
			}
		}

		// Token: 0x170035AE RID: 13742
		// (get) Token: 0x06006767 RID: 26471 RVA: 0x005C66C4 File Offset: 0x005C48C4
		// (set) Token: 0x06006768 RID: 26472 RVA: 0x005C6778 File Offset: 0x005C4978
		internal bool RadErgoWidePASirenHiLoAirhornTones_A8200_HiddenDynamic
		{
			get
			{
				short num = (short)28850729;
				short num2 = num;
				num = (short)1963932201;
				switch (num2 == num)
				{
				}
				num = (short)1265565696;
				if (num != 0)
				{
				}
				num = (short)1670512640;
				short num3 = num;
				num = (short)2077949953;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenHiLoAirhornTones_A8200.HiddenDynamic;
			}
			set
			{
				short num = (short)514729085;
				short num2 = num;
				num = (short)755770493;
				switch (num2 == num)
				{
				}
				num = (short)1751973888;
				if (num != 0)
				{
				}
				num = (short)1642790912;
				short num3 = num;
				num = (short)412090369;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenHiLoAirhornTones_A8200.HiddenDynamic = value;
			}
		}

		// Token: 0x170035AF RID: 13743
		// (get) Token: 0x06006769 RID: 26473 RVA: 0x005C682C File Offset: 0x005C4A2C
		public bool RadErgoWidePASirenHiLoAirhornTones_A8200_HasDiffs
		{
			get
			{
				short num = (short)1510986093;
				short num2 = num;
				num = (short)1874448749;
				switch (num2 == num)
				{
				}
				num = (short)1457127424;
				if (num != 0)
				{
				}
				num = (short)190185472;
				short num3 = num;
				num = (short)307167233;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenHiLoAirhornTones_A8200._HasDiffs;
			}
		}

		// Token: 0x170035B0 RID: 13744
		// (get) Token: 0x0600676A RID: 26474 RVA: 0x005C68E4 File Offset: 0x005C4AE4
		// (set) Token: 0x0600676B RID: 26475 RVA: 0x005C6998 File Offset: 0x005C4B98
		public int RadErgoWidePASirenManualTone_A8464Value
		{
			get
			{
				short num = (short)918694855;
				short num2 = num;
				num = (short)1191717831;
				switch (num2 == num)
				{
				}
				num = (short)1183776769;
				if (num != 0)
				{
				}
				num = (short)201195520;
				short num3 = num;
				num = (short)1709441024;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenManualTone_A8464.Value;
			}
			set
			{
				short num = (short)130008463;
				short num2 = num;
				num = (short)708756879;
				switch (num2 == num)
				{
				}
				num = (short)2069037056;
				if (num != 0)
				{
				}
				num = (short)833028096;
				short num3 = num;
				num = (short)1716846593;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenManualTone_A8464.Value = value;
			}
		}

		// Token: 0x170035B1 RID: 13745
		// (get) Token: 0x0600676C RID: 26476 RVA: 0x005C6A50 File Offset: 0x005C4C50
		// (set) Token: 0x0600676D RID: 26477 RVA: 0x005C6B04 File Offset: 0x005C4D04
		public string RadErgoWidePASirenManualTone_A8464_UIValue
		{
			get
			{
				short num = (short)384552313;
				short num2 = num;
				num = (short)1903873401;
				switch (num2 == num)
				{
				}
				num = (short)1481113601;
				if (num != 0)
				{
				}
				num = (short)483917824;
				short num3 = num;
				num = (short)191692800;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenManualTone_A8464.UIValue;
			}
			set
			{
				short num = (short)796315278;
				short num2 = num;
				num = (short)1451675278;
				switch (num2 == num)
				{
				}
				num = (short)1091829761;
				if (num != 0)
				{
				}
				num = (short)876085248;
				short num3 = num;
				num = (short)282722304;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenManualTone_A8464.UIValue = value;
			}
		}

		// Token: 0x170035B2 RID: 13746
		// (get) Token: 0x0600676E RID: 26478 RVA: 0x005C6BB8 File Offset: 0x005C4DB8
		public global::AcpBusinessLayer.AcpListField RadErgoWidePASirenManualTone_A8464
		{
			get
			{
				short num = (short)724843550;
				short num2 = num;
				num = (short)1071725598;
				switch (num2 == num)
				{
				}
				num = (short)348192768;
				if (num != 0)
				{
				}
				num = (short)1630797824;
				short num3 = num;
				num = (short)1853947905;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenManualTone_A8464;
			}
		}

		// Token: 0x170035B3 RID: 13747
		// (get) Token: 0x0600676F RID: 26479 RVA: 0x005C6C64 File Offset: 0x005C4E64
		// (set) Token: 0x06006770 RID: 26480 RVA: 0x005C6D18 File Offset: 0x005C4F18
		public bool RadErgoWidePASirenManualTone_A8464_Applicable
		{
			get
			{
				short num = (short)479870380;
				short num2 = num;
				num = (short)483933612;
				switch (num2 == num)
				{
				}
				num = (short)1389953024;
				if (num != 0)
				{
				}
				num = (short)1710555136;
				short num3 = num;
				num = (short)926154753;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenManualTone_A8464.Applicable;
			}
			set
			{
				short num = (short)2094327153;
				short num2 = num;
				num = (short)266331505;
				switch (num2 == num)
				{
				}
				num = (short)349765633;
				if (num != 0)
				{
				}
				num = (short)713621504;
				short num3 = num;
				num = (short)1907097600;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenManualTone_A8464.Applicable = value;
			}
		}

		// Token: 0x170035B4 RID: 13748
		// (get) Token: 0x06006771 RID: 26481 RVA: 0x005C6DCC File Offset: 0x005C4FCC
		// (set) Token: 0x06006772 RID: 26482 RVA: 0x005C6E80 File Offset: 0x005C5080
		public bool RadErgoWidePASirenManualTone_A8464_Valid
		{
			get
			{
				short num = (short)116729011;
				short num2 = num;
				num = (short)784868531;
				switch (num2 == num)
				{
				}
				num = (short)2070872065;
				if (num != 0)
				{
				}
				num = (short)1358823424;
				short num3 = num;
				num = (short)914358272;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenManualTone_A8464.Valid;
			}
			set
			{
				short num = (short)463863809;
				if (num != 0)
				{
				}
				num = (short)777423144;
				short num2 = num;
				num = (short)915900712;
				switch (num2 == num)
				{
				}
				num = (short)44761088;
				short num3 = num;
				num = (short)2001141760;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenManualTone_A8464.Valid = value;
			}
		}

		// Token: 0x170035B5 RID: 13749
		// (get) Token: 0x06006773 RID: 26483 RVA: 0x005C6F38 File Offset: 0x005C5138
		// (set) Token: 0x06006774 RID: 26484 RVA: 0x005C6FEC File Offset: 0x005C51EC
		public bool RadErgoWidePASirenManualTone_A8464_Visible
		{
			get
			{
				short num = (short)1147863041;
				if (num != 0)
				{
				}
				num = (short)663538499;
				short num2 = num;
				num = (short)1672661827;
				switch (num2 == num)
				{
				}
				num = (short)1930821632;
				short num3 = num;
				num = (short)1298071552;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenManualTone_A8464.Visible;
			}
			set
			{
				short num = (short)2075311944;
				short num2 = num;
				num = (short)2128330568;
				switch (num2 == num)
				{
				}
				num = (short)1336803328;
				if (num != 0)
				{
				}
				num = (short)722796544;
				short num3 = num;
				num = (short)1184759809;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenManualTone_A8464.Visible = value;
			}
		}

		// Token: 0x170035B6 RID: 13750
		// (get) Token: 0x06006775 RID: 26485 RVA: 0x005C70A0 File Offset: 0x005C52A0
		// (set) Token: 0x06006776 RID: 26486 RVA: 0x005C7154 File Offset: 0x005C5354
		public bool RadErgoWidePASirenManualTone_A8464_Editable
		{
			get
			{
				short num = (short)375128065;
				if (num != 0)
				{
				}
				num = (short)2104482884;
				short num2 = num;
				num = (short)2047532100;
				switch (num2 == num)
				{
				}
				num = (short)1496186880;
				short num3 = num;
				num = (short)1913716736;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenManualTone_A8464.Editable;
			}
			set
			{
				short num = (short)700349026;
				short num2 = num;
				num = (short)2147056226;
				switch (num2 == num)
				{
				}
				num = (short)505282560;
				if (num != 0)
				{
				}
				num = (short)169345024;
				short num3 = num;
				num = (short)790298625;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenManualTone_A8464.Editable = value;
			}
		}

		// Token: 0x170035B7 RID: 13751
		// (get) Token: 0x06006777 RID: 26487 RVA: 0x005C7208 File Offset: 0x005C5408
		internal string RadErgoWidePASirenManualTone_A8464_UILabel
		{
			get
			{
				short num = (short)904463514;
				short num2 = num;
				num = (short)674432154;
				switch (num2 == num)
				{
				}
				num = (short)391512064;
				if (num != 0)
				{
				}
				num = (short)1703936000;
				short num3 = num;
				num = (short)1326186497;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenManualTone_A8464.UIName;
			}
		}

		// Token: 0x170035B8 RID: 13752
		// (get) Token: 0x06006778 RID: 26488 RVA: 0x005C72C0 File Offset: 0x005C54C0
		// (set) Token: 0x06006779 RID: 26489 RVA: 0x005C7374 File Offset: 0x005C5574
		internal bool RadErgoWidePASirenManualTone_A8464_HiddenStatic
		{
			get
			{
				short num = (short)559149981;
				short num2 = num;
				num = (short)380367773;
				switch (num2 == num)
				{
				}
				num = (short)60817409;
				if (num != 0)
				{
				}
				num = (short)1851195392;
				short num3 = num;
				num = (short)1945763840;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenManualTone_A8464.HiddenStatic;
			}
			set
			{
				short num = (short)165022936;
				short num2 = num;
				num = (short)663293144;
				switch (num2 == num)
				{
				}
				num = (short)1301020672;
				if (num != 0)
				{
				}
				num = (short)1123942400;
				short num3 = num;
				num = (short)959840257;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenManualTone_A8464.HiddenStatic = value;
			}
		}

		// Token: 0x170035B9 RID: 13753
		// (get) Token: 0x0600677A RID: 26490 RVA: 0x005C742C File Offset: 0x005C562C
		// (set) Token: 0x0600677B RID: 26491 RVA: 0x005C74E0 File Offset: 0x005C56E0
		internal bool RadErgoWidePASirenManualTone_A8464_HiddenDynamic
		{
			get
			{
				short num = (short)1818490967;
				short num2 = num;
				num = (short)1673328727;
				switch (num2 == num)
				{
				}
				num = (short)1748697088;
				if (num != 0)
				{
				}
				num = (short)1675886592;
				short num3 = num;
				num = (short)566624257;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenManualTone_A8464.HiddenDynamic;
			}
			set
			{
				short num = (short)1206395628;
				short num2 = num;
				num = (short)1684873964;
				switch (num2 == num)
				{
				}
				num = (short)695402497;
				if (num != 0)
				{
				}
				num = (short)1495465984;
				short num3 = num;
				num = (short)1913913344;
				if (num != 0)
				{
				}
				this.radErgoWidePASirenManualTone_A8464.HiddenDynamic = value;
			}
		}

		// Token: 0x170035BA RID: 13754
		// (get) Token: 0x0600677C RID: 26492 RVA: 0x005C7594 File Offset: 0x005C5794
		public bool RadErgoWidePASirenManualTone_A8464_HasDiffs
		{
			get
			{
				short num = (short)1288769427;
				short num2 = num;
				num = (short)994185107;
				switch (num2 == num)
				{
				}
				num = (short)1556152320;
				if (num != 0)
				{
				}
				num = (short)1997275136;
				short num3 = num;
				num = (short)1462501377;
				if (num != 0)
				{
				}
				return this.radErgoWidePASirenManualTone_A8464._HasDiffs;
			}
		}

		// Token: 0x170035BB RID: 13755
		// (get) Token: 0x0600677D RID: 26493 RVA: 0x005C764C File Offset: 0x005C584C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)848123974;
				short num2 = num;
				num = (short)474634310;
				switch (num2 == num)
				{
				}
				num = (short)1532624897;
				if (num != 0)
				{
				}
				num = (short)981270528;
				short num3 = num;
				num = (short)2144534528;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x0600677E RID: 26494 RVA: 0x005C770C File Offset: 0x005C590C
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
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1009123332;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
				{
					num2 = (short)1132977750;
					short num3 = num2;
					num2 = (short)1119608406;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)952303617;
						if (num2 != 0)
						{
						}
						num2 = (short)12320768;
						if (num2 != 0)
						{
						}
						num2 = (short)1381826560;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)407109633;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					return result;
				case 4:
				{
					num2 = (short)1239089152;
					short num4 = num2;
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)659488771;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)168165378;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040026AF RID: 9903
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoWidePASirenDefaultPAVolumeLevel_A7812;

		// Token: 0x040026B0 RID: 9904
		private global::AcpBusinessLayer.AcpField<bool> radErgoWidePASirenExternalRadioIgnition_A7992;

		// Token: 0x040026B1 RID: 9905
		private global::AcpBusinessLayer.AcpField<bool> radErgoWidePASirenOptionsAudioMuting_A8623;

		// Token: 0x040026B2 RID: 9906
		private global::AcpBusinessLayer.AcpField<bool> radErgoWidePASirenPAIgnitionSense_A8683;

		// Token: 0x040026B3 RID: 9907
		private global::AcpBusinessLayer.AcpField<bool> radErgoWidePASirenSirenIgnitionSense_A9138;

		// Token: 0x040026B4 RID: 9908
		private global::AcpBusinessLayer.AcpListField radErgoWidePASirenSirenOperation_A9139;

		// Token: 0x040026B5 RID: 9909
		private global::AcpBusinessLayer.AcpListField radErgoWidePASirenSirenPAAfterReset_A9140;

		// Token: 0x040026B6 RID: 9910
		private global::AcpBusinessLayer.AcpFieldX<bool, bool> radErgoWidePASirenHiLoAirhornTones_A8200;

		// Token: 0x040026B7 RID: 9911
		private global::AcpBusinessLayer.AcpListField radErgoWidePASirenManualTone_A8464;
	}
}
