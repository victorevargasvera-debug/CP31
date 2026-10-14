using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile
{
	// Token: 0x02000264 RID: 612
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06006C35 RID: 27701 RVA: 0x0060A9D8 File Offset: 0x00608BD8
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06006C36 RID: 27702 RVA: 0x0060A9F4 File Offset: 0x00608BF4
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06006C37 RID: 27703 RVA: 0x0060AA0C File Offset: 0x00608C0C
		public override void Init()
		{
			int a_ = 1;
			short num = (short)564002817;
			if (num != 0)
			{
			}
			num = (short)414017789;
			short num2 = num;
			num = (short)793209085;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1449000960;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1043988480;
			if (num != 0)
			{
			}
			this.radErgoCfgGeneralEXPANSIONDEGREE_A22299 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓釕뷗듙맛곝臟軡ꇣ뻥룧ꯩꋫ뷭맯뷱뫳답뷷뷹껻믽䗿崁䔃㐅㨇㠉㔋㜍", a_), global::CommonResources.AcgResources.ID_DWFEXPANSIONDEGREE, 0, 65535, null, null, 0, 1);
			this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.DataTransferOrder = 2;
			this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.ShowHexValue = true;
			this.externalMicNoiseReductionProfileName_A22536 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("蟁볃닅귇룉ꋋ꿍볏鿑뷓뗕雗뗙뗛귝藟냡臣若鷧觩飫蟭鿯鳱ꓳ蓵韷鳹闻鋽旿䰁攃欅洇唉䴋㰍∏✑✓―", a_), global::CommonResources.AcgResources.ID_ACCESSORYNOISEREDUCTIONPROFILENAME, 14, global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.LegacyTitles.ExternalMicNoiseReductionProfileName_A22536LegacyTitles);
			this.externalMicNoiseReductionProfileName_A22536.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.externalMicNoiseReductionProfileName_A22536.DataTransferOrder = 25;
			this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("苃胅軇﷉請裍雏鋓郕黗髛飝ꛟ헡ꋣꃥ껧\udde9ꫫ꣭뛯엱닳냵뻷췹뫻룽䛿㔁䈃䀅万㴉䨋䠍嘏┑刓倕帗ⴙ娛堝星ᔡ戣急渧ᴩ樫栭瘯Ա爳瀵縷ഹ稻砽ؿ畁ɃE็絉ੋࡍᙏ救ቓၕṗ浙ᩛᡝ♟啡≣⁥⹧嵩⩫⡭㙯䕱㉳ふ㹷䵹㩻㡽왿떁슃삅캇붉쪋좍횏ꖑ튓킕\ude97궙\uda9b\ud89d閡鶩薱ﺷ", a_), this, global::AllFeatures.CodeplugGuid.b("蟁볃닅藇ꏉ꿋胍ꏏ胑냓釕뷗듙飛韝껟ꇡꯣ돥볧뫩맫뫭뗯ꏱꋳ돵믷껹돻곽忿䌁㜃ㄅ㼇㠉㰋", a_), global::CommonResources.AcgResources.ID_DINCOUTPUTEQVECTOR, 124);
			this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720.DataTransferOrder = 26;
			this.extMicNsRdGenDINCEPVECTOR_A37721 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("﯉ﻋﻍ탟틡퇣훥\ud8e7\udae9\udceb\udeed싯싱쓳웵죷쫹쳻컽ヿ㈁㐃㘅㠇㨉㰋㸍‏∑␓☕⠗⨙Ⱋ⸝ဟሡᐣᘥᠧᨩᰫḭ/ȱгص࠷ਹ఻฽瀿", a_), this, global::AllFeatures.CodeplugGuid.b("蟁볃닅藇ꏉ꿋胍ꏏ胑냓釕뷗듙飛韝껟ꇡꇣ뛥뻧꿩꿫뫭뿯ꃱ꯳럵쯷췹쯻쳽ㇿ", a_), global::CommonResources.AcgResources.ID_DINCEPVECTOR, 64);
			this.extMicNsRdGenDINCEPVECTOR_A37721.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.extMicNsRdGenDINCEPVECTOR_A37721.DataTransferOrder = 27;
			this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302 = new global::AcpBusinessLayer.AcpSimpleRangeField(768, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓釕뷗듙맛곝臟軡곣ꧥ볧꣩ꧫ꿭뷯뛱뇳ꋵ곷당껻믽叿䨁䀃䐅备㈉匋伍∏‑✓☕⨗", a_), global::CommonResources.AcgResources.ID_HOTBEAMDETTHRESHDBQ8, 0, 65535, null, null, 0, 1);
			this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.DataTransferOrder = 5;
			this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.ShowHexValue = true;
			this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305 = new global::AcpBusinessLayer.AcpSimpleRangeField(6144, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓釕뷗듙맛곝臟軡귣꣥ꧧꧩ룫꟭ꛯ럱ꃳ뻵꫷뿹꿻뛽䓿䀁唃㸅圇䬉㸋㰍⌏∑ℓ", a_), global::CommonResources.AcgResources.ID_BADMICINACTIVETHRESHDBQ8, 0, 65535, null, null, 0, 1);
			this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.DataTransferOrder = 8;
			this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.ShowHexValue = true;
			this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307 = new global::AcpBusinessLayer.AcpSimpleRangeField(2304, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓釕뷗듙맛곝臟軡ꫣꋥꇧ곩ꫫ뫭룯ꃱ뇳ꗵ냷뻹뻻꿽㣿崁䔃㐅㨇㤉㰋㤍", a_), global::CommonResources.AcgResources.ID_BADMICNDIFFTHRESHDBQ8, 0, 65535, null, null, 0, 1);
			this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.DataTransferOrder = 10;
			this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.ShowHexValue = true;
			this.radErgoCfgGeneralRTHRESHDBQ8_A22308 = new global::AcpBusinessLayer.AcpSimpleRangeField(62976, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓釕뷗듙맛곝臟軡뛣닥ꃧ룩ꧫ뷭룯뛱뛳Ꟶ샷ꗹ뷻쳽㋿㄁㐃㸅", a_), global::CommonResources.AcgResources.ID_BADMICRTHRESHDBQ8, 0, 65535, null, null, 0, 1);
			this.radErgoCfgGeneralRTHRESHDBQ8_A22308.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoCfgGeneralRTHRESHDBQ8_A22308.DataTransferOrder = 11;
			this.radErgoCfgGeneralRTHRESHDBQ8_A22308.ShowHexValue = true;
			this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306 = new global::AcpBusinessLayer.AcpSimpleRangeField(12800, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓釕뷗듙맛곝臟軡럣ꋥꇧ곩ꫫ뫭룯ꃱ뇳ꗵ냷뻹뻻꿽㣿崁䔃㐅㨇㤉㰋㠍", a_), global::CommonResources.AcgResources.ID_BADMICSDIFFTHRESHDBQ8, 0, 65535, null, null, 0, 1);
			this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.DataTransferOrder = 9;
			this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.ShowHexValue = true;
			this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303 = new global::AcpBusinessLayer.AcpSimpleRangeField(1536, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓釕뷗듙맛곝臟軡닣꟥곧껩ꧫ뫭ꓯ뫱꛳돵꯷당룻볽凿㨁嬃䜅㨇㠉㼋㸍⌏", a_), global::CommonResources.AcgResources.ID_STATUSVADDETTHRESHDBQ8, 0, 65535, null, null, 0, 1);
			this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.DataTransferOrder = 6;
			this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.ShowHexValue = true;
			this.radErgoCfgGeneralVADDETCOUNT_A22304 = new global::AcpBusinessLayer.AcpSimpleRangeField(9, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓釕뷗듙맛곝臟軡닣꟥곧껩ꧫ뫭돯뷱ꇳ룵곷ꗹ뷻쳽㋿㄁㐃㈅", a_), global::CommonResources.AcgResources.ID_STATUSVADDETCOUNT, 0, 65535, null, null, 0, 1);
			this.radErgoCfgGeneralVADDETCOUNT_A22304.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoCfgGeneralVADDETCOUNT_A22304.DataTransferOrder = 7;
			this.radErgoCfgGeneralVADDETCOUNT_A22304.ShowHexValue = true;
			this.radErgoCfgGeneralMINGAIN_A22298 = new global::AcpBusinessLayer.AcpSimpleRangeField(8231, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓釕뷗듙맛곝臟軡ꧣ꿥ꛧ귩귫꟭뻯귱뗳쓵쫷죹엻웽", a_), global::CommonResources.AcgResources.ID_DWFMINGAIN, 0, 65535, null, null, 0, 1);
			this.radErgoCfgGeneralMINGAIN_A22298.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoCfgGeneralMINGAIN_A22298.DataTransferOrder = 1;
			this.radErgoCfgGeneralMINGAIN_A22298.ShowHexValue = true;
			this.radErgoCfgGeneralDINCABFSS_A22300 = new global::AcpBusinessLayer.AcpSimpleRangeField(819, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓釕뷗듙맛곝臟軡ꃣ꿥ꛧꧩ귫곭뛯ꇱꟳ꧵맷죹컻췽ヿ㈁", a_), global::CommonResources.AcgResources.ID_DINCABFSS, 0, 65535, null, null, 0, 1);
			this.radErgoCfgGeneralDINCABFSS_A22300.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoCfgGeneralDINCABFSS_A22300.DataTransferOrder = 3;
			this.radErgoCfgGeneralDINCABFSS_A22300.ShowHexValue = true;
			this.radErgoCfgGeneralDINCEWINDNBANDS_A22301 = new global::AcpBusinessLayer.AcpSimpleRangeField(3, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓釕뷗듙맛곝臟軡ꃣ꿥ꛧꧩꧫ맭맯볱냳룵뫷믹닻뫽叿崁䔃㐅㨇㤉㰋㼍", a_), global::CommonResources.AcgResources.ID_EWINDDINCEWINDNBANDS, 0, 65535, null, null, 0, 1);
			this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.DataTransferOrder = 4;
			this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.ShowHexValue = true;
			this.radErgoCfgGeneralMAXSVECTOR_A22297 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("ﷇ跋韓鏕髗髛飝ꛟ헡ꋣꃥ껧\udde9ꫫ꣭뛯엱닳냵뻷췹뫻룽䛿㔁䈃䀅万㴉䨋䠍嘏┑刓倕帗ⴙ娛堝星ᔡ戣急渧ᴩ樫栭瘯Ա爳瀵縷ഹ稻砽ؿ畁ɃE็絉ੋࡍᙏ救ቓၕṗ浙ᩛᡝ♟啡≣⁥⹧嵩⩫⡭㙯䕱㉳ふ㹷䵹㩻㡽왿떁슃삅캇붉쪋좍횏ꖑ튓킕\ude97궙\uda9b\ud89d閡鶩薱ﺷ趹請蚿", a_), this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓釕뷗듙맛곝臟軡ꧣ꟥냧맩뫫꯭돯꛱믳ꓵꟷ믹컻쳽㋿㬁㌃", a_), global::CommonResources.AcgResources.ID_EWINDMAXSVECTOR, 128);
			this.radErgoCfgGeneralMAXSVECTOR_A22297.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoCfgGeneralMAXSVECTOR_A22297.DataTransferOrder = 24;
			this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_BA00EC00, this, global::AllFeatures.CodeplugGuid.b("蟁볃닅藇ꏉ꿋胍ꏏ胑냓釕뷗듙鷛鷝ꏟ꟡럣뗥꟧룩뗫꿭ꗯ꛱믳룵럷돹꿻믽䋿䴁儃䠅䰇変䠋䰍䄏⨑䬓∕⨗Ⱉ␛⠝", a_), global::CommonResources.AcgResources.ID_ADAPTIVENOISESUPPRESSIONACCESSORYAUTONOISEBOUNDSDBQ8, 8);
			this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686.DataTransferOrder = 28;
			this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_P_287A040C, this, global::AllFeatures.CodeplugGuid.b("蟁볃닅藇ꏉ꿋胍ꏏ胑냓釕뷗듙鷛鷝ꏟ꟡럣뗥꟧룩뗫꿭ꗯ꛱믳믵뇷듹믻뿽䧿䰁刃䌅䬇帉䌋對伏☑☓―‗ⴙ", a_), global::CommonResources.AcgResources.ID_ADAPTIVENOISESUPPRESSIONACCESSORYAUTOMINGAINVECTOR, 8);
			this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687.DataTransferOrder = 29;
			this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_P_000A, this, global::AllFeatures.CodeplugGuid.b("蟁볃닅藇ꏉ꿋胍ꏏ胑냓釕뷗듙鷛鷝ꏟ꟡럣뗥꟧룩뗫꿭ꗯ꛱믳ꓵ뷷뛹뷻꛽哿䬁䬃䠅䨇䔉夋䀍吏䄑䬓∕⨗Ⱉ␛☝", a_), global::CommonResources.AcgResources.ID_ADAPTIVENOISESUPPRESSIONACCESSORYAUTORELAXATIONBOUNDS, 4);
			this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688.DataTransferOrder = 30;
			this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689 = new global::AcpBusinessLayer.AcpSimpleRangeField(1750, this, global::AllFeatures.CodeplugGuid.b("蟁볃닅藇ꏉ꿋胍ꏏ胑냓釕뷗듙鷛鷝ꏟ꟡럣뗥꟧룩뗫뻭뇯ꇱꟳ냵뇷뛹ꣻ믽勿儁倃䜅娇帉匋㨍∏␑Ⱃ⼕", a_), global::CommonResources.AcgResources.ID_ADAPTIVENOISESUPPRESSIONACCESSORYPASSFILTERSTART, 1, 3999, null, null, 0, 1);
			this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.DataTransferOrder = 31;
			this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("藁ꇃꣅ귇룉귋ꋍ", a_);
			base.Id = 10203;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06006C38 RID: 27704 RVA: 0x0060B094 File Offset: 0x00609294
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)994246677;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)673897356;
					short num3 = num;
					num = (short)553769868;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5F6;
					default:
						num = (short)421789696;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚髜뫞迠蛢韤蛦藨룪ꧬꛮ런뗲ꇴ뿶꯸뻺껼럾䔀䄂各㼆嘈䨊㼌㴎∐⌒⌔", a_)))
						{
							num = (short)1388838953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CF6;
					}
					break;
				}
				case 1:
					goto IL_DF0;
				case 2:
					num = (short)41418753;
					if (num != 0)
					{
					}
					this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305 = new global::AcpBusinessLayer.AcpSimpleRangeField(6144, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚髜뫞迠蛢韤蛦藨ꋪꏬ껮닰ꟲ보ꇶ본꿺뗼귾䐀倂䴄䌆䬈娊㔌倎倐ℒ✔␖⤘⸚", a_), global::CommonResources.AcgResources.ID_BADMICINACTIVETHRESHDBQ8, null, null, 0, 1);
					this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.DataTransferOrder = 8;
					this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.ShowHexValue = true;
					num = (short)222036007;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)417071112;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_P_000A, this, global::AllFeatures.CodeplugGuid.b("賈돊만苎룐냒鯔ꓖ诘뿚髜뫞迠ꋢꛤꓦ골룪뻬ꃮꏰꫲ듴ꋶ그듺꿼뫾䴀䈂崄匆䀈䐊䌌䴎帐䘒嬔化䨘䐚⤜ⴞᜠᬢᴤ", a_), global::CommonResources.AcgResources.ID_ADAPTIVENOISESUPPRESSIONACCESSORYAUTORELAXATIONBOUNDS, 4);
					this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688.DataTransferOrder = 30;
					num = (short)1133903925;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賈돊만苎룐냒鯔ꓖ诘뿚髜뫞迠ꋢꛤꓦ골룪뻬ꃮꏰꫲ듴ꋶ그듺꿼뫾䴀䈂崄匆䀈䐊䌌䴎帐䘒嬔化䨘䐚⤜ⴞᜠᬢᴤ", a_)))
					{
						num = (short)1530003460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D43;
				case 6:
					goto IL_1E2;
				case 7:
					this.radErgoCfgGeneralMAXSVECTOR_A22297 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("龜鋒飚飜鷞훠ꗢꏤꇦ\udee8귪꯬ꧮ웰뗲돴뇶컸뷺민맾㘀䔂䌄䄆㸈䴊䬌䤎☐唒匔儖⸘崚嬜夞ᘠ攢挤愦Ḩ洪欬椮ذ甲猴然ุ紺笼社癀Ղ̈́ņ繈ൊୌॎ晐ᕒፔᅖ湘ᵚ᭜ᥞ噠╢⍤Ⅶ幨⵪⭬⥮䙰㕲㍴ㅶ乸㵺㭼㥾뚀얂쎄솆뺈춊쮌즎Ꚑ햒펔톖꺘\udd9a\udb9c\ud99e隠麨蚰躸ﶺ﮼料藂菄臆", a_), this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚髜뫞迠蛢韤蛦藨ꛪ곬럮ꋰꗲ냴듶그듺꿼ꃾ䀀㄂㜄㔆〈㰊", a_), global::CommonResources.AcgResources.ID_EWINDMAXSVECTOR, 128);
					this.radErgoCfgGeneralMAXSVECTOR_A22297.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radErgoCfgGeneralMAXSVECTOR_A22297.DataTransferOrder = 24;
					num = (short)778764343;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚髜뫞迠蛢韤蛦藨껪뗬뿮냰뷲꛴뻶뛸뗺맼뫾䘀儂䀄䈆嘈䨊㼌㴎⌐⨒Ⱄ", a_)))
					{
						num = (short)1842151437;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DF0;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賈돊만꫎ꏐ뷒듔믖铘닚뻜釞軠諢雤苦믨軪觬髮鋰蟲鳴飶韸꯺迼郾最樂椄戆䜈樊怌樎丐划✔┖Ⱈ⠚⬜", a_)))
					{
						num = (short)704905264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_914;
				case 10:
					this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("ﻈ跊诌觎闒鏔釖鷚鯜駞훠ꗢꏤꇦ\udee8귪꯬ꧮ웰뗲돴뇶컸뷺민맾㘀䔂䌄䄆㸈䴊䬌䤎☐唒匔儖⸘崚嬜夞ᘠ攢挤愦Ḩ洪欬椮ذ甲猴然ุ紺笼社癀Ղ̈́ņ繈ൊୌॎ晐ᕒፔᅖ湘ᵚ᭜ᥞ噠╢⍤Ⅶ幨⵪⭬⥮䙰㕲㍴ㅶ乸㵺㭼㥾뚀얂쎄솆뺈춊쮌즎Ꚑ햒펔톖꺘\udd9a\udb9c\ud99e隠麨蚰躸ﶺ﮼料", a_), this, global::AllFeatures.CodeplugGuid.b("賈돊만苎룐냒鯔ꓖ诘뿚髜뫞迠꟢곤ꧦꫨꓪ룬믮ꇰ꛲ꇴ닶꣸귺룼볾唀䰂圄堆䠈㠊㨌㠎⌐⌒", a_), global::CommonResources.AcgResources.ID_DINCOUTPUTEQVECTOR, 124);
					this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720.DataTransferOrder = 26;
					num = (short)1327759366;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚髜뫞迠蛢韤蛦藨뷪곬꯮뗰뛲ꇴ듶뛸껺돼꯾帀䈂㜄㔆㨈㬊㤌", a_)))
					{
						num = (short)1708130347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B22;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賈돊만苎룐냒鯔ꓖ诘뿚髜뫞迠ꋢꛤꓦ골룪뻬ꃮꏰꫲ듴ꋶ그듺돼냾䠀倂䀄䔆䘈帊䌌䬎䈐園圔䘖℘䐚⤜ⴞᜠᬢጤ", a_)))
					{
						num = (short)1334116352;
						short num4 = num;
						num = (short)180355086;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6D6;
				case 13:
					this.radErgoCfgGeneralEXPANSIONDEGREE_A22299 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚髜뫞迠蛢韤蛦藨껪뗬뿮냰뷲꛴뻶뛸뗺맼뫾䘀儂䀄䈆嘈䨊㼌㴎⌐⨒Ⱄ", a_), global::CommonResources.AcgResources.ID_DWFEXPANSIONDEGREE, null, null, 0, 1);
					this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.DataTransferOrder = 2;
					this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.ShowHexValue = true;
					num = (short)1339883521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_BA00EC00, this, global::AllFeatures.CodeplugGuid.b("賈돊만苎룐냒鯔ꓖ诘뿚髜뫞迠ꋢꛤꓦ골룪뻬ꃮꏰꫲ듴ꋶ그듺돼냾䠀倂䀄䔆䘈帊䌌䬎䈐園圔䘖℘䐚⤜ⴞᜠᬢጤ", a_), global::CommonResources.AcgResources.ID_ADAPTIVENOISESUPPRESSIONACCESSORYAUTONOISEBOUNDSDBQ8, 8);
					this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686.DataTransferOrder = 28;
					num = (short)48627740;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					this.radErgoCfgGeneralMINGAIN_A22298 = new global::AcpBusinessLayer.AcpSimpleRangeField(8231, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚髜뫞迠蛢韤蛦藨ꛪꓬꇮ뛰닲보맶꛸뫺쿼췾㌀㨂㴄", a_), global::CommonResources.AcgResources.ID_DWFMINGAIN, null, null, 0, 1);
					this.radErgoCfgGeneralMINGAIN_A22298.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radErgoCfgGeneralMINGAIN_A22298.DataTransferOrder = 1;
					this.radErgoCfgGeneralMINGAIN_A22298.ShowHexValue = true;
					num = (short)1637482527;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (producerFields != null)
					{
						num = (short)503382019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F4C;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賈돊만苎룐냒鯔ꓖ诘뿚髜뫞迠꟢곤ꧦꫨ껪뷬맮듰냲ꇴ룶꯸ꓺ볼쳾㘀㐂㜄㘆", a_)))
					{
						num = (short)951648312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_400;
				case 18:
					goto IL_148;
				case 19:
					this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303 = new global::AcpBusinessLayer.AcpSimpleRangeField(1536, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚髜뫞迠蛢韤蛦藨뷪곬꯮뗰뛲ꇴꏶ뇸ꧺ룼곾䤀䜂䜄嘆ㄈ吊䰌㴎⌐‒└␖", a_), global::CommonResources.AcgResources.ID_STATUSVADDETTHRESHDBQ8, null, null, 0, 1);
					this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.DataTransferOrder = 6;
					this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.ShowHexValue = true;
					num = (short)1807482904;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					this.radErgoCfgGeneralDINCEWINDNBANDS_A22301 = new global::AcpBusinessLayer.AcpSimpleRangeField(3, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚髜뫞迠蛢韤蛦藨꿪ꓬꇮ닰뛲ꋴ뻶럸뿺돼뷾䀀䴂䄄吆嘈䨊㼌㴎∐⌒␔", a_), global::CommonResources.AcgResources.ID_EWINDDINCEWINDNBANDS, null, null, 0, 1);
					this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.DataTransferOrder = 4;
					this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.ShowHexValue = true;
					num = (short)1490157622;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					switch (0)
					{
					case 0:
						goto IL_122;
					}
					continue;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚髜뫞迠蛢韤蛦藨ꛪ곬럮ꋰꗲ냴듶그듺꿼ꃾ䀀㄂㜄㔆〈㰊", a_)))
					{
						num = (short)1609105415;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_962;
				case 23:
					goto IL_5F6;
				case 24:
					goto IL_195;
				case 25:
					this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_P_287A040C, this, global::AllFeatures.CodeplugGuid.b("賈돊만苎룐냒鯔ꓖ诘뿚髜뫞迠ꋢꛤꓦ골룪뻬ꃮꏰꫲ듴ꋶ그듺냼뛾伀䐂䐄丆䜈崊䠌䰎䔐尒䜔䠖ⴘ⤚⬜✞ᘠ", a_), global::CommonResources.AcgResources.ID_ADAPTIVENOISESUPPRESSIONACCESSORYAUTOMINGAINVECTOR, 8);
					this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687.DataTransferOrder = 29;
					num = (short)943915058;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					goto IL_660;
				case 27:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賈돊만苎룐냒鯔ꓖ诘뿚髜뫞迠ꋢꛤꓦ골룪뻬ꃮꏰꫲꗴ뛶꫸꣺민뛾䴀圂䀄唆娈弊䰌崎䔐䰒℔┖⼘⌚␜", a_)))
					{
						num = (short)1866858525;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F4C;
				case 28:
					goto IL_6D6;
				case 29:
					this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689 = new global::AcpBusinessLayer.AcpSimpleRangeField(1750, this, global::AllFeatures.CodeplugGuid.b("賈돊만苎룐냒鯔ꓖ诘뿚髜뫞迠ꋢꛤꓦ골룪뻬ꃮꏰꫲꗴ뛶꫸꣺민뛾䴀圂䀄唆娈弊䰌崎䔐䰒℔┖⼘⌚␜", a_), global::CommonResources.AcgResources.ID_ADAPTIVENOISESUPPRESSIONACCESSORYPASSFILTERSTART, null, null, 0, 1);
					this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.DataTransferOrder = 31;
					this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.ShowHexValue = false;
					num = (short)523173930;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307 = new global::AcpBusinessLayer.AcpSimpleRangeField(2304, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚髜뫞迠蛢韤蛦藨ꗪꧬꛮ런뗲ꇴ뿶꯸뻺껼럾䔀䄂各㼆嘈䨊㼌㴎∐⌒∔", a_), global::CommonResources.AcgResources.ID_BADMICNDIFFTHRESHDBQ8, null, null, 0, 1);
					this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.DataTransferOrder = 10;
					this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.ShowHexValue = true;
					num = (short)1242562596;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					goto IL_E97;
				case 32:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚髜뫞迠蛢韤蛦藨뷪곬꯮뗰뛲ꇴꏶ뇸ꧺ룼곾䤀䜂䜄嘆ㄈ吊䰌㴎⌐‒└␖", a_)))
					{
						num = (short)94961683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_195;
				case 33:
					goto IL_A8C;
				case 34:
					this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302 = new global::AcpBusinessLayer.AcpSimpleRangeField(768, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚髜뫞迠蛢韤蛦藨ꏪꋬ믮돰뛲듴뫶뷸뻺ꧼ꯾䤀儂䀄吆䄈伊伌帎⤐䰒吔┖⬘⠚ⴜⴞ", a_), global::CommonResources.AcgResources.ID_HOTBEAMDETTHRESHDBQ8, null, null, 0, 1);
					this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.DataTransferOrder = 5;
					this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.ShowHexValue = true;
					num = (short)616824858;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚髜뫞迠蛢韤蛦藨꿪ꓬꇮ닰뛲ꋴ뻶럸뿺돼뷾䀀䴂䄄吆嘈䨊㼌㴎∐⌒␔", a_)))
					{
						num = (short)1228013588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_722;
				case 36:
					goto IL_512;
				case 37:
					goto IL_914;
				case 38:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚髜뫞迠蛢韤蛦藨ꛪꓬꇮ뛰닲보맶꛸뫺쿼췾㌀㨂㴄", a_)))
					{
						num = (short)1901395983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E97;
				case 39:
					goto IL_9D7;
				case 40:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚髜뫞迠蛢韤蛦藨ꏪꋬ믮돰뛲듴뫶뷸뻺ꧼ꯾䤀儂䀄吆䄈伊伌帎⤐䰒吔┖⬘⠚ⴜⴞ", a_)))
					{
						num = (short)842924066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_660;
				case 41:
					this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306 = new global::AcpBusinessLayer.AcpSimpleRangeField(12800, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚髜뫞迠蛢韤蛦藨룪ꧬꛮ런뗲ꇴ뿶꯸뻺껼럾䔀䄂各㼆嘈䨊㼌㴎∐⌒⌔", a_), global::CommonResources.AcgResources.ID_BADMICSDIFFTHRESHDBQ8, null, null, 0, 1);
					this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.DataTransferOrder = 9;
					this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.ShowHexValue = true;
					num = (short)658440251;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 42:
					goto IL_50D;
				case 43:
					this.radErgoCfgGeneralVADDETCOUNT_A22304 = new global::AcpBusinessLayer.AcpSimpleRangeField(9, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚髜뫞迠蛢韤蛦藨뷪곬꯮뗰뛲ꇴ듶뛸껺돼꯾帀䈂㜄㔆㨈㬊㤌", a_), global::CommonResources.AcgResources.ID_STATUSVADDETCOUNT, null, null, 0, 1);
					this.radErgoCfgGeneralVADDETCOUNT_A22304.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radErgoCfgGeneralVADDETCOUNT_A22304.DataTransferOrder = 7;
					this.radErgoCfgGeneralVADDETCOUNT_A22304.ShowHexValue = true;
					num = (short)1200488494;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 44:
					this.radErgoCfgGeneralDINCABFSS_A22300 = new global::AcpBusinessLayer.AcpSimpleRangeField(819, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚髜뫞迠蛢韤蛦藨꿪ꓬꇮ닰닲럴뇶꫸꣺ꋼ뻾㌀㄂㘄㜆㤈", a_), global::CommonResources.AcgResources.ID_DINCABFSS, null, null, 0, 1);
					this.radErgoCfgGeneralDINCABFSS_A22300.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radErgoCfgGeneralDINCABFSS_A22300.DataTransferOrder = 3;
					this.radErgoCfgGeneralDINCABFSS_A22300.ShowHexValue = true;
					num = (short)1420951570;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 45:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賈돊만苎룐냒鯔ꓖ诘뿚髜뫞迠꟢곤ꧦꫨꓪ룬믮ꇰ꛲ꇴ닶꣸귺룼볾唀䰂圄堆䠈㠊㨌㠎⌐⌒", a_)))
					{
						num = (short)1339031562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E2;
				case 46:
					goto IL_B22;
				case 47:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚髜뫞迠蛢韤蛦藨맪맬꟮ꏰ뛲꛴뿶뷸맺과쟾帀䈂㜄㔆㨈㬊㔌", a_)))
					{
						num = (short)613089338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A8C;
				case 48:
					this.externalMicNoiseReductionProfileName_A22536 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("賈돊만꫎ꏐ뷒듔믖铘닚뻜釞軠諢雤苦믨軪觬髮鋰蟲鳴飶韸꯺迼郾最樂椄戆䜈樊怌樎丐划✔┖Ⱈ⠚⬜", a_), global::CommonResources.AcgResources.ID_ACCESSORYNOISEREDUCTIONPROFILENAME, 14, global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.LegacyTitles.ExternalMicNoiseReductionProfileName_A22536LegacyTitles);
					this.externalMicNoiseReductionProfileName_A22536.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.externalMicNoiseReductionProfileName_A22536.DataTransferOrder = 25;
					num = (short)1329070117;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 49:
					num = (short)1672151056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 50:
					goto IL_34E;
				case 51:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚髜뫞迠蛢韤蛦藨꿪ꓬꇮ닰닲럴뇶꫸꣺ꋼ뻾㌀㄂㘄㜆㤈", a_)))
					{
						num = (short)1183252524;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_148;
				case 52:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賈돊만苎룐냒鯔ꓖ诘뿚髜뫞迠ꋢꛤꓦ골룪뻬ꃮꏰꫲ듴ꋶ그듺냼뛾伀䐂䐄丆䜈崊䠌䰎䔐尒䜔䠖ⴘ⤚⬜✞ᘠ", a_)))
					{
						num = (short)1124597785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_34E;
				case 53:
					goto IL_D43;
				case 54:
					goto IL_722;
				case 55:
					goto IL_962;
				case 56:
					this.extMicNsRdGenDINCEPVECTOR_A37721 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("杻流﷌ￎ퇠폢헤ퟦ\ud9e8\udeea\uddec\udfee쇰쏲열엶째쯺췼쿾㄀㌂㔄㜆㤈㬊㴌㼎ℐ⌒└✖⤘⬚ⴜ⼞ᄠጢᔤᜦᤨᬪᴬἮİ̲Դܶस଺഼༾煀獂畄睆", a_), this, global::AllFeatures.CodeplugGuid.b("賈돊만苎룐냒鯔ꓖ诘뿚髜뫞迠꟢곤ꧦꫨ껪뷬맮듰냲ꇴ룶꯸ꓺ볼쳾㘀㐂㜄㘆", a_), global::CommonResources.AcgResources.ID_DINCEPVECTOR, 64);
					this.extMicNsRdGenDINCEPVECTOR_A37721.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.extMicNsRdGenDINCEPVECTOR_A37721.DataTransferOrder = 27;
					num = (short)735182871;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 57:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚髜뫞迠蛢韤蛦藨ꋪꏬ껮닰ꟲ보ꇶ본꿺뗼귾䐀倂䴄䌆䬈娊㔌倎倐ℒ✔␖⤘⸚", a_)))
					{
						num = (short)1457586178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9D7;
				case 58:
					this.radErgoCfgGeneralRTHRESHDBQ8_A22308 = new global::AcpBusinessLayer.AcpSimpleRangeField(62976, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚髜뫞迠蛢韤蛦藨맪맬꟮ꏰ뛲꛴뿶뷸맺과쟾帀䈂㜄㔆㨈㬊㔌", a_), global::CommonResources.AcgResources.ID_BADMICRTHRESHDBQ8, null, null, 0, 1);
					this.radErgoCfgGeneralRTHRESHDBQ8_A22308.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radErgoCfgGeneralRTHRESHDBQ8_A22308.DataTransferOrder = 11;
					this.radErgoCfgGeneralRTHRESHDBQ8_A22308.ShowHexValue = true;
					num = (short)1146814497;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 59:
					goto IL_CF6;
				case 60:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚髜뫞迠蛢韤蛦藨ꗪꧬꛮ런뗲ꇴ뿶꯸뻺껼럾䔀䄂各㼆嘈䨊㼌㴎∐⌒∔", a_)))
					{
						num = (short)1463353374;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_512;
				}
				IL_122:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1491075121;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_148:
				num = (short)2099773475;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_195:
				num = (short)1707671563;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E2:
				num = (short)377421841;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_34E:
				num = (short)1746010117;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_400:
				num = (short)197853224;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5F6:
				goto IL_400;
				IL_512:
				num = (short)1525219375;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_660:
				num = (short)1435959353;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6D6:
				num = (short)1118175284;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_722:
				num = (short)215089174;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_914:
				num = (short)1804075053;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_962:
				num = (short)700907532;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9D7:
				num = (short)1610219580;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A8C:
				num = (short)895614976;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B22:
				num = (short)1702428710;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CF6:
				num = (short)689242144;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D43:
				num = (short)669188123;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_DF0:
				num = (short)796459017;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E97:
				num = (short)709034035;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_50D:
			IL_F4C:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軈껊ꏌ꫎ꏐ닒맔", a_);
			base.Id = 10203;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06006C39 RID: 27705 RVA: 0x0060C020 File Offset: 0x0060A220
		public override void PopulateReferences()
		{
			short num = (short)254148608;
			short num2 = num;
			num = (short)1807730291;
			short num3 = num;
			num = (short)24430195;
			switch (num3 == num)
			{
			}
			num = (short)1702363136;
			if (num != 0)
			{
			}
			num = (short)1366425601;
			if (num != 0)
			{
			}
		}

		// Token: 0x06006C3A RID: 27706 RVA: 0x0060C0C8 File Offset: 0x0060A2C8
		public override void DropReferences()
		{
			short num = (short)547684352;
			short num2 = num;
			num = (short)954269697;
			if (num != 0)
			{
			}
			num = (short)176986284;
			short num3 = num;
			num = (short)996317356;
			switch (num3 == num)
			{
			}
			num = (short)466747392;
			if (num != 0)
			{
			}
		}

		// Token: 0x06006C3B RID: 27707 RVA: 0x0060C170 File Offset: 0x0060A370
		public override void SetConstraints()
		{
			short num = (short)64159744;
			short num2 = num;
			num = (short)1776690068;
			short num3 = num;
			num = (short)1635197844;
			switch (num3 == num)
			{
			}
			num = (short)552861697;
			if (num != 0)
			{
			}
			num = (short)771489792;
			if (num != 0)
			{
			}
			this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfileConstraints.ConExtMicDincOutputEqVectorLengthEqualsTo124);
			this.extMicNsRdGenDINCEPVECTOR_A37721.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfileConstraints.ConExtMicDincEPVectorLengthEqualsTo64);
			this.radErgoCfgGeneralMAXSVECTOR_A22297.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfileConstraints.ConExtMicMaxVectorsLengthNoLessThan128);
			this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfileConstraints.ConACCAUTONSBDSDBQ8LengthEqualsTo8);
			this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfileConstraints.ConACCAUTOMINGAINVCTLengthEqualsTo8);
			this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfileConstraints.ConACCAUTORELAXATIONBDSLengthEqualsTo4);
		}

		// Token: 0x06006C3C RID: 27708 RVA: 0x0060C2A4 File Offset: 0x0060A4A4
		public override void SetupDependencies()
		{
			short num = (short)946012160;
			short num2 = num;
			num = (short)1084479073;
			short num3 = num;
			num = (short)1495979617;
			switch (num3 == num)
			{
			}
			num = (short)1494614016;
			if (num != 0)
			{
			}
			num = (short)1558052865;
			if (num != 0)
			{
			}
		}

		// Token: 0x170037EE RID: 14318
		// (get) Token: 0x06006C3D RID: 27709 RVA: 0x0060C34C File Offset: 0x0060A54C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1792606208;
				short num2 = num;
				num = (short)129975722;
				short num3 = num;
				num = (short)212092330;
				switch (num3 == num)
				{
				}
				num = (short)815988737;
				if (num != 0)
				{
				}
				num = (short)547028992;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170037EF RID: 14319
		// (get) Token: 0x06006C3E RID: 27710 RVA: 0x0060C3FC File Offset: 0x0060A5FC
		// (set) Token: 0x06006C3F RID: 27711 RVA: 0x0060C4B0 File Offset: 0x0060A6B0
		public int RadErgoCfgGeneralEXPANSIONDEGREE_A22299Value
		{
			get
			{
				short num = (short)401604608;
				short num2 = num;
				num = (short)1813048917;
				short num3 = num;
				num = (short)1395125845;
				switch (num3 == num)
				{
				}
				num = (short)806223873;
				if (num != 0)
				{
				}
				num = (short)1755316224;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.Value;
			}
			set
			{
				short num = (short)1358561280;
				short num2 = num;
				num = (short)1940869891;
				short num3 = num;
				num = (short)404837123;
				switch (num3 == num)
				{
				}
				num = (short)535560192;
				if (num != 0)
				{
				}
				num = (short)432865281;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.Value = value;
			}
		}

		// Token: 0x170037F0 RID: 14320
		// (get) Token: 0x06006C40 RID: 27712 RVA: 0x0060C568 File Offset: 0x0060A768
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgGeneralEXPANSIONDEGREE_A22299
		{
			get
			{
				short num = (short)1839923200;
				short num2 = num;
				num = (short)1661415417;
				short num3 = num;
				num = (short)1115697145;
				switch (num3 == num)
				{
				}
				num = (short)1686241281;
				if (num != 0)
				{
				}
				num = (short)827588608;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A22299;
			}
		}

		// Token: 0x170037F1 RID: 14321
		// (get) Token: 0x06006C41 RID: 27713 RVA: 0x0060C614 File Offset: 0x0060A814
		// (set) Token: 0x06006C42 RID: 27714 RVA: 0x0060C6CC File Offset: 0x0060A8CC
		public string RadErgoCfgGeneralEXPANSIONDEGREE_A22299_UIValue
		{
			get
			{
				short num = (short)1804140544;
				short num2 = num;
				num = (short)2136348767;
				short num3 = num;
				num = (short)709826655;
				switch (num3 == num)
				{
				}
				num = (short)1069744128;
				if (num != 0)
				{
				}
				num = (short)167313409;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.UIValue;
			}
			set
			{
				short num = (short)1223360512;
				short num2 = num;
				num = (short)1609189386;
				short num3 = num;
				num = (short)96159754;
				switch (num3 == num)
				{
				}
				num = (short)1535770625;
				if (num != 0)
				{
				}
				num = (short)2006974464;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.UIValue = value;
			}
		}

		// Token: 0x170037F2 RID: 14322
		// (get) Token: 0x06006C43 RID: 27715 RVA: 0x0060C780 File Offset: 0x0060A980
		// (set) Token: 0x06006C44 RID: 27716 RVA: 0x0060C838 File Offset: 0x0060AA38
		public string RadErgoCfgGeneralEXPANSIONDEGREE_A22299_HexUIValue
		{
			get
			{
				short num = (short)535035904;
				short num2 = num;
				num = (short)1010698025;
				short num3 = num;
				num = (short)1216939817;
				switch (num3 == num)
				{
				}
				num = (short)2140667904;
				if (num != 0)
				{
				}
				num = (short)1774714881;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.HexUIValue;
			}
			set
			{
				short num = (short)147456000;
				short num2 = num;
				num = (short)1432682497;
				if (num != 0)
				{
				}
				num = (short)762181731;
				short num3 = num;
				num = (short)580450403;
				switch (num3 == num)
				{
				}
				num = (short)966852608;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.HexUIValue = value;
			}
		}

		// Token: 0x170037F3 RID: 14323
		// (get) Token: 0x06006C45 RID: 27717 RVA: 0x0060C8F0 File Offset: 0x0060AAF0
		// (set) Token: 0x06006C46 RID: 27718 RVA: 0x0060C9A8 File Offset: 0x0060ABA8
		internal int RadErgoCfgGeneralEXPANSIONDEGREE_A22299Min
		{
			get
			{
				short num = (short)1499070464;
				short num2 = num;
				num = (short)862551938;
				short num3 = num;
				num = (short)2075426690;
				switch (num3 == num)
				{
				}
				num = (short)428408833;
				if (num != 0)
				{
				}
				num = (short)1408434176;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.Min;
			}
			set
			{
				short num = (short)1311703040;
				short num2 = num;
				num = (short)154413784;
				short num3 = num;
				num = (short)1760045784;
				switch (num3 == num)
				{
				}
				num = (short)686227457;
				if (num != 0)
				{
				}
				num = (short)1017118720;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.Min = value;
			}
		}

		// Token: 0x170037F4 RID: 14324
		// (get) Token: 0x06006C47 RID: 27719 RVA: 0x0060CA5C File Offset: 0x0060AC5C
		// (set) Token: 0x06006C48 RID: 27720 RVA: 0x0060CB10 File Offset: 0x0060AD10
		internal int RadErgoCfgGeneralEXPANSIONDEGREE_A22299Max
		{
			get
			{
				short num = (short)683278336;
				short num2 = num;
				num = (short)682231743;
				short num3 = num;
				num = (short)185272255;
				switch (num3 == num)
				{
				}
				num = (short)991035393;
				if (num != 0)
				{
				}
				num = (short)954793984;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.Max;
			}
			set
			{
				short num = (short)686161920;
				short num2 = num;
				num = (short)534004718;
				short num3 = num;
				num = (short)1411924974;
				switch (num3 == num)
				{
				}
				num = (short)189333504;
				if (num != 0)
				{
				}
				num = (short)1965555713;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.Max = value;
			}
		}

		// Token: 0x170037F5 RID: 14325
		// (get) Token: 0x06006C49 RID: 27721 RVA: 0x0060CBC4 File Offset: 0x0060ADC4
		// (set) Token: 0x06006C4A RID: 27722 RVA: 0x0060CC78 File Offset: 0x0060AE78
		internal int RadErgoCfgGeneralEXPANSIONDEGREE_A22299Step
		{
			get
			{
				short num = (short)1573519360;
				short num2 = num;
				num = (short)722474801;
				short num3 = num;
				num = (short)1596331825;
				switch (num3 == num)
				{
				}
				num = (short)782696449;
				if (num != 0)
				{
				}
				num = (short)1183514624;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.StepSize;
			}
			set
			{
				short num = (short)1988886528;
				short num2 = num;
				num = (short)172785897;
				short num3 = num;
				num = (short)19235049;
				switch (num3 == num)
				{
				}
				num = (short)1638596609;
				if (num != 0)
				{
				}
				num = (short)614400000;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.StepSize = value;
			}
		}

		// Token: 0x170037F6 RID: 14326
		// (get) Token: 0x06006C4B RID: 27723 RVA: 0x0060CD30 File Offset: 0x0060AF30
		// (set) Token: 0x06006C4C RID: 27724 RVA: 0x0060CDE8 File Offset: 0x0060AFE8
		public bool RadErgoCfgGeneralEXPANSIONDEGREE_A22299_Applicable
		{
			get
			{
				short num = (short)1150484480;
				short num2 = num;
				num = (short)1167854708;
				short num3 = num;
				num = (short)1342508148;
				switch (num3 == num)
				{
				}
				num = (short)1862860800;
				if (num != 0)
				{
				}
				num = (short)1571684353;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.Applicable;
			}
			set
			{
				short num = (short)11141120;
				short num2 = num;
				num = (short)898364293;
				short num3 = num;
				num = (short)1970533253;
				switch (num3 == num)
				{
				}
				num = (short)1097990145;
				if (num != 0)
				{
				}
				num = (short)700055552;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.Applicable = value;
			}
		}

		// Token: 0x170037F7 RID: 14327
		// (get) Token: 0x06006C4D RID: 27725 RVA: 0x0060CE9C File Offset: 0x0060B09C
		// (set) Token: 0x06006C4E RID: 27726 RVA: 0x0060CF50 File Offset: 0x0060B150
		public bool RadErgoCfgGeneralEXPANSIONDEGREE_A22299_Valid
		{
			get
			{
				short num = (short)901775360;
				short num2 = num;
				num = (short)237099754;
				short num3 = num;
				num = (short)795663082;
				switch (num3 == num)
				{
				}
				num = (short)1562640385;
				if (num != 0)
				{
				}
				num = (short)1087766528;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.Valid;
			}
			set
			{
				short num = (short)1920008192;
				short num2 = num;
				num = (short)1996488705;
				if (num != 0)
				{
				}
				num = (short)1244388169;
				short num3 = num;
				num = (short)2075188041;
				switch (num3 == num)
				{
				}
				num = (short)113901568;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.Valid = value;
			}
		}

		// Token: 0x170037F8 RID: 14328
		// (get) Token: 0x06006C4F RID: 27727 RVA: 0x0060D004 File Offset: 0x0060B204
		// (set) Token: 0x06006C50 RID: 27728 RVA: 0x0060D0B8 File Offset: 0x0060B2B8
		public bool RadErgoCfgGeneralEXPANSIONDEGREE_A22299_Visible
		{
			get
			{
				short num = (short)1213726720;
				short num2 = num;
				num = (short)1980253248;
				short num3 = num;
				num = (short)804013120;
				switch (num3 == num)
				{
				}
				num = (short)1445068800;
				if (num != 0)
				{
				}
				num = (short)1455161345;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.Visible;
			}
			set
			{
				short num = (short)2143223808;
				short num2 = num;
				num = (short)574718614;
				short num3 = num;
				num = (short)1966244502;
				switch (num3 == num)
				{
				}
				num = (short)1122041856;
				if (num != 0)
				{
				}
				num = (short)1273036801;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.Visible = value;
			}
		}

		// Token: 0x170037F9 RID: 14329
		// (get) Token: 0x06006C51 RID: 27729 RVA: 0x0060D16C File Offset: 0x0060B36C
		// (set) Token: 0x06006C52 RID: 27730 RVA: 0x0060D220 File Offset: 0x0060B420
		public bool RadErgoCfgGeneralEXPANSIONDEGREE_A22299_Editable
		{
			get
			{
				short num = (short)536018944;
				short num2 = num;
				num = (short)793562535;
				short num3 = num;
				num = (short)1934937511;
				switch (num3 == num)
				{
				}
				num = (short)2128543745;
				if (num != 0)
				{
				}
				num = (short)2084896768;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.Editable;
			}
			set
			{
				short num = (short)878575616;
				short num2 = num;
				num = (short)163381249;
				if (num != 0)
				{
				}
				num = (short)1148350439;
				short num3 = num;
				num = (short)1827434471;
				switch (num3 == num)
				{
				}
				num = (short)1468006400;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.Editable = value;
			}
		}

		// Token: 0x170037FA RID: 14330
		// (get) Token: 0x06006C53 RID: 27731 RVA: 0x0060D2D4 File Offset: 0x0060B4D4
		internal string RadErgoCfgGeneralEXPANSIONDEGREE_A22299_UILabel
		{
			get
			{
				short num = (short)1674772480;
				short num2 = num;
				num = (short)2124055490;
				short num3 = num;
				num = (short)322995138;
				switch (num3 == num)
				{
				}
				num = (short)159318017;
				if (num != 0)
				{
				}
				num = (short)2003042304;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.UIName;
			}
		}

		// Token: 0x170037FB RID: 14331
		// (get) Token: 0x06006C54 RID: 27732 RVA: 0x0060D384 File Offset: 0x0060B584
		// (set) Token: 0x06006C55 RID: 27733 RVA: 0x0060D43C File Offset: 0x0060B63C
		internal bool RadErgoCfgGeneralEXPANSIONDEGREE_A22299_HiddenStatic
		{
			get
			{
				short num = (short)2079981568;
				short num2 = num;
				num = (short)40229528;
				short num3 = num;
				num = (short)16571032;
				switch (num3 == num)
				{
				}
				num = (short)1733099521;
				if (num != 0)
				{
				}
				num = (short)1793654784;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.HiddenStatic;
			}
			set
			{
				short num = (short)108331008;
				short num2 = num;
				num = (short)1832321025;
				if (num != 0)
				{
				}
				num = (short)2065814827;
				short num3 = num;
				num = (short)548721963;
				switch (num3 == num)
				{
				}
				num = (short)623706112;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.HiddenStatic = value;
			}
		}

		// Token: 0x170037FC RID: 14332
		// (get) Token: 0x06006C56 RID: 27734 RVA: 0x0060D4F0 File Offset: 0x0060B6F0
		// (set) Token: 0x06006C57 RID: 27735 RVA: 0x0060D5A4 File Offset: 0x0060B7A4
		internal bool RadErgoCfgGeneralEXPANSIONDEGREE_A22299_HiddenDynamic
		{
			get
			{
				short num = (short)601206821;
				short num2 = num;
				num = (short)50245669;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1964507136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1012072449;
				if (num != 0)
				{
				}
				num = (short)1919811584;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.HiddenDynamic;
			}
			set
			{
				short num = (short)1143042197;
				short num2 = num;
				num = (short)1709535381;
				switch (num2 == num)
				{
				default:
				{
					num = (short)645988352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1640824833;
				if (num != 0)
				{
				}
				num = (short)289406976;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralEXPANSIONDEGREE_A22299.HiddenDynamic = value;
			}
		}

		// Token: 0x170037FD RID: 14333
		// (get) Token: 0x06006C58 RID: 27736 RVA: 0x0060D65C File Offset: 0x0060B85C
		public bool RadErgoCfgGeneralEXPANSIONDEGREE_A22299_HasDiffs
		{
			get
			{
				short num = (short)438633998;
				short num2 = num;
				num = (short)359597582;
				switch (num2 == num)
				{
				default:
				{
					num = (short)975962112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1568538625;
				if (num != 0)
				{
				}
				num = (short)38207488;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A22299._HasDiffs;
			}
		}

		// Token: 0x170037FE RID: 14334
		// (get) Token: 0x06006C59 RID: 27737 RVA: 0x0060D710 File Offset: 0x0060B910
		// (set) Token: 0x06006C5A RID: 27738 RVA: 0x0060D7C8 File Offset: 0x0060B9C8
		public string ExternalMicNoiseReductionProfileName_A22536Value
		{
			get
			{
				short num = (short)388358576;
				short num2 = num;
				num = (short)1036444080;
				switch (num2 == num)
				{
				default:
				{
					num = (short)449380352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1601503233;
				if (num != 0)
				{
				}
				num = (short)2110652416;
				if (num != 0)
				{
				}
				return this.externalMicNoiseReductionProfileName_A22536.Value;
			}
			set
			{
				short num = (short)217513985;
				if (num != 0)
				{
				}
				num = (short)655818752;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1273149083;
						short num3 = num;
						num = (short)699250331;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)522125312;
							if (num != 0)
							{
							}
							num = (short)897974272;
							short num4 = num;
							switch (0)
							{
							case 0:
								goto IL_CA;
							}
							continue;
						}
						}
						break;
					}
					case 1:
						this.externalMicNoiseReductionProfileName_A22536.Value = value;
						num = (short)1722810370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					}
					IL_CA:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						break;
					}
					num = (short)2033254401;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170037FF RID: 14335
		// (get) Token: 0x06006C5B RID: 27739 RVA: 0x0060D8E8 File Offset: 0x0060BAE8
		// (set) Token: 0x06006C5C RID: 27740 RVA: 0x0060D99C File Offset: 0x0060BB9C
		public string ExternalMicNoiseReductionProfileName_A22536_UIValue
		{
			get
			{
				short num = (short)398339157;
				short num2 = num;
				num = (short)169290837;
				switch (num2 == num)
				{
				default:
				{
					num = (short)595197952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)287834113;
				if (num != 0)
				{
				}
				num = (short)35258368;
				if (num != 0)
				{
				}
				return this.externalMicNoiseReductionProfileName_A22536.Value;
			}
			set
			{
				short num = (short)1681833970;
				short num2 = num;
				num = (short)1308278770;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1407909888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)300613633;
				if (num != 0)
				{
				}
				num = (short)222298112;
				if (num != 0)
				{
				}
				this.externalMicNoiseReductionProfileName_A22536.Value = value;
			}
		}

		// Token: 0x17003800 RID: 14336
		// (get) Token: 0x06006C5D RID: 27741 RVA: 0x0060DA54 File Offset: 0x0060BC54
		public global::AcpBusinessLayer.AcpKeyField ExternalMicNoiseReductionProfileName_A22536
		{
			get
			{
				short num = (short)1972189316;
				short num2 = num;
				num = (short)2060925060;
				switch (num2 == num)
				{
				default:
				{
					num = (short)135069696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)216858625;
				if (num != 0)
				{
				}
				num = (short)2069037056;
				if (num != 0)
				{
				}
				return this.externalMicNoiseReductionProfileName_A22536;
			}
		}

		// Token: 0x17003801 RID: 14337
		// (get) Token: 0x06006C5E RID: 27742 RVA: 0x0060DB04 File Offset: 0x0060BD04
		// (set) Token: 0x06006C5F RID: 27743 RVA: 0x0060DBB8 File Offset: 0x0060BDB8
		public bool ExternalMicNoiseReductionProfileName_A22536_Applicable
		{
			get
			{
				short num = (short)1319522329;
				short num2 = num;
				num = (short)2100121625;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1425473536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1308491776;
				if (num != 0)
				{
				}
				num = (short)1395785729;
				if (num != 0)
				{
				}
				return this.externalMicNoiseReductionProfileName_A22536.Applicable;
			}
			set
			{
				short num = (short)877985793;
				if (num != 0)
				{
				}
				num = (short)716374016;
				short num2 = num;
				num = (short)707422368;
				short num3 = num;
				num = (short)1009150112;
				switch (num3 == num)
				{
				}
				num = (short)447086592;
				if (num != 0)
				{
				}
				this.externalMicNoiseReductionProfileName_A22536.Applicable = value;
			}
		}

		// Token: 0x17003802 RID: 14338
		// (get) Token: 0x06006C60 RID: 27744 RVA: 0x0060DC70 File Offset: 0x0060BE70
		// (set) Token: 0x06006C61 RID: 27745 RVA: 0x0060DD28 File Offset: 0x0060BF28
		public bool ExternalMicNoiseReductionProfileName_A22536_Valid
		{
			get
			{
				short num = (short)1882400661;
				short num2 = num;
				num = (short)590030741;
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
				num = (short)2075787265;
				if (num != 0)
				{
				}
				num = (short)281083904;
				if (num != 0)
				{
				}
				return this.externalMicNoiseReductionProfileName_A22536.Valid;
			}
			set
			{
				short num = (short)1408508981;
				short num2 = num;
				num = (short)2008097845;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1555890176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)30212097;
				if (num != 0)
				{
				}
				num = (short)2061172736;
				if (num != 0)
				{
				}
				this.externalMicNoiseReductionProfileName_A22536.Valid = value;
			}
		}

		// Token: 0x17003803 RID: 14339
		// (get) Token: 0x06006C62 RID: 27746 RVA: 0x0060DDDC File Offset: 0x0060BFDC
		// (set) Token: 0x06006C63 RID: 27747 RVA: 0x0060DE90 File Offset: 0x0060C090
		public bool ExternalMicNoiseReductionProfileName_A22536_Visible
		{
			get
			{
				short num = (short)1932573536;
				short num2 = num;
				num = (short)822066016;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1336541184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1779367936;
				if (num != 0)
				{
				}
				num = (short)1456275457;
				if (num != 0)
				{
				}
				return this.externalMicNoiseReductionProfileName_A22536.Visible;
			}
			set
			{
				short num = (short)790584713;
				short num2 = num;
				num = (short)1670208905;
				switch (num2 == num)
				{
				default:
				{
					num = (short)452198400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)45809665;
				if (num != 0)
				{
				}
				num = (short)2047016960;
				if (num != 0)
				{
				}
				this.externalMicNoiseReductionProfileName_A22536.Visible = value;
			}
		}

		// Token: 0x17003804 RID: 14340
		// (get) Token: 0x06006C64 RID: 27748 RVA: 0x0060DF48 File Offset: 0x0060C148
		// (set) Token: 0x06006C65 RID: 27749 RVA: 0x0060DFFC File Offset: 0x0060C1FC
		public bool ExternalMicNoiseReductionProfileName_A22536_Editable
		{
			get
			{
				short num = (short)544890619;
				short num2 = num;
				num = (short)892296955;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1813250048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1986002945;
				if (num != 0)
				{
				}
				num = (short)645267456;
				if (num != 0)
				{
				}
				return this.externalMicNoiseReductionProfileName_A22536.Editable;
			}
			set
			{
				short num = (short)874657085;
				short num2 = num;
				num = (short)1109275965;
				switch (num2 == num)
				{
				default:
				{
					num = (short)738525184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)601423872;
				if (num != 0)
				{
				}
				num = (short)1790115841;
				if (num != 0)
				{
				}
				this.externalMicNoiseReductionProfileName_A22536.Editable = value;
			}
		}

		// Token: 0x17003805 RID: 14341
		// (get) Token: 0x06006C66 RID: 27750 RVA: 0x0060E0B4 File Offset: 0x0060C2B4
		internal string ExternalMicNoiseReductionProfileName_A22536_UILabel
		{
			get
			{
				short num = (short)1012632677;
				short num2 = num;
				num = (short)530025573;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1295646720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1103626241;
				if (num != 0)
				{
				}
				num = (short)679739392;
				if (num != 0)
				{
				}
				return this.externalMicNoiseReductionProfileName_A22536.UIName;
			}
		}

		// Token: 0x17003806 RID: 14342
		// (get) Token: 0x06006C67 RID: 27751 RVA: 0x0060E168 File Offset: 0x0060C368
		// (set) Token: 0x06006C68 RID: 27752 RVA: 0x0060E21C File Offset: 0x0060C41C
		internal bool ExternalMicNoiseReductionProfileName_A22536_HiddenStatic
		{
			get
			{
				short num = (short)1194523592;
				short num2 = num;
				num = (short)239598536;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1707212800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)107479041;
				if (num != 0)
				{
				}
				num = (short)1907294208;
				if (num != 0)
				{
				}
				return this.externalMicNoiseReductionProfileName_A22536.HiddenStatic;
			}
			set
			{
				short num = (short)2142372115;
				short num2 = num;
				num = (short)402063635;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2121465856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1120993280;
				if (num != 0)
				{
				}
				num = (short)1705312257;
				if (num != 0)
				{
				}
				this.externalMicNoiseReductionProfileName_A22536.HiddenStatic = value;
			}
		}

		// Token: 0x17003807 RID: 14343
		// (get) Token: 0x06006C69 RID: 27753 RVA: 0x0060E2D0 File Offset: 0x0060C4D0
		// (set) Token: 0x06006C6A RID: 27754 RVA: 0x0060E388 File Offset: 0x0060C588
		internal bool ExternalMicNoiseReductionProfileName_A22536_HiddenDynamic
		{
			get
			{
				short num = (short)52386509;
				short num2 = num;
				num = (short)1387879117;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1994719232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)239927297;
				if (num != 0)
				{
				}
				num = (short)1360986112;
				if (num != 0)
				{
				}
				return this.externalMicNoiseReductionProfileName_A22536.HiddenDynamic;
			}
			set
			{
				short num = (short)1537732562;
				short num2 = num;
				num = (short)504164306;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1117650944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)790888448;
				if (num != 0)
				{
				}
				num = (short)876544001;
				if (num != 0)
				{
				}
				this.externalMicNoiseReductionProfileName_A22536.HiddenDynamic = value;
			}
		}

		// Token: 0x17003808 RID: 14344
		// (get) Token: 0x06006C6B RID: 27755 RVA: 0x0060E440 File Offset: 0x0060C640
		public bool ExternalMicNoiseReductionProfileName_A22536_HasDiffs
		{
			get
			{
				short num = (short)1244139727;
				short num2 = num;
				num = (short)457052367;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1969225728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1512701953;
				if (num != 0)
				{
				}
				num = (short)1064697856;
				if (num != 0)
				{
				}
				return this.externalMicNoiseReductionProfileName_A22536._HasDiffs;
			}
		}

		// Token: 0x17003809 RID: 14345
		// (get) Token: 0x06006C6C RID: 27756 RVA: 0x0060E4F4 File Offset: 0x0060C6F4
		// (set) Token: 0x06006C6D RID: 27757 RVA: 0x0060E5A8 File Offset: 0x0060C7A8
		public string ExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720Value
		{
			get
			{
				short num = (short)953510656;
				short num2 = num;
				num = (short)66153216;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1277755392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2038759425;
				if (num != 0)
				{
				}
				num = (short)614596608;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720.Value;
			}
			set
			{
				short num = (short)2012733767;
				short num2 = num;
				num = (short)968941895;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1999372288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)759562241;
				if (num != 0)
				{
				}
				num = (short)711720960;
				if (num != 0)
				{
				}
				this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720.Value = value;
			}
		}

		// Token: 0x1700380A RID: 14346
		// (get) Token: 0x06006C6E RID: 27758 RVA: 0x0060E65C File Offset: 0x0060C85C
		public global::AcpBusinessLayer.AcpField<string> ExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720
		{
			get
			{
				short num = (short)733705591;
				short num2 = num;
				num = (short)2031973751;
				switch (num2 == num)
				{
				default:
				{
					num = (short)111149056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1609760769;
				if (num != 0)
				{
				}
				num = (short)1398013952;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720;
			}
		}

		// Token: 0x1700380B RID: 14347
		// (get) Token: 0x06006C6F RID: 27759 RVA: 0x0060E70C File Offset: 0x0060C90C
		// (set) Token: 0x06006C70 RID: 27760 RVA: 0x0060E7C0 File Offset: 0x0060C9C0
		public string ExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720_UIValue
		{
			get
			{
				short num = (short)1538064546;
				short num2 = num;
				num = (short)682295458;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1627848704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1333657601;
				if (num != 0)
				{
				}
				num = (short)1916993536;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720.Value;
			}
			set
			{
				short num = (short)881519401;
				short num2 = num;
				num = (short)1518136105;
				switch (num2 == num)
				{
				default:
				{
					num = (short)767557632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)215678976;
				if (num != 0)
				{
				}
				num = (short)141164545;
				if (num != 0)
				{
				}
				this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720.Value = value;
			}
		}

		// Token: 0x1700380C RID: 14348
		// (get) Token: 0x06006C71 RID: 27761 RVA: 0x0060E874 File Offset: 0x0060CA74
		// (set) Token: 0x06006C72 RID: 27762 RVA: 0x0060E928 File Offset: 0x0060CB28
		public bool ExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720_Applicable
		{
			get
			{
				short num = (short)719475820;
				short num2 = num;
				num = (short)1828017260;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1495597056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1689714689;
				if (num != 0)
				{
				}
				num = (short)306184192;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720.Applicable;
			}
			set
			{
				short num = (short)1233428734;
				short num2 = num;
				num = (short)21995774;
				switch (num2 == num)
				{
				default:
				{
					num = (short)799932416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1353515009;
				if (num != 0)
				{
				}
				num = (short)1644101632;
				if (num != 0)
				{
				}
				this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720.Applicable = value;
			}
		}

		// Token: 0x1700380D RID: 14349
		// (get) Token: 0x06006C73 RID: 27763 RVA: 0x0060E9E0 File Offset: 0x0060CBE0
		// (set) Token: 0x06006C74 RID: 27764 RVA: 0x0060EA94 File Offset: 0x0060CC94
		public bool ExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720_Valid
		{
			get
			{
				short num = (short)1703151802;
				short num2 = num;
				num = (short)972032186;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1593442304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)469106689;
				if (num != 0)
				{
				}
				num = (short)1899823104;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720.Valid;
			}
			set
			{
				short num = (short)579862529;
				if (num != 0)
				{
				}
				num = (short)734593024;
				short num2 = num;
				num = (short)779736515;
				short num3 = num;
				num = (short)1173870019;
				switch (num3 == num)
				{
				}
				num = (short)966918144;
				if (num != 0)
				{
				}
				this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720.Valid = value;
			}
		}

		// Token: 0x1700380E RID: 14350
		// (get) Token: 0x06006C75 RID: 27765 RVA: 0x0060EB48 File Offset: 0x0060CD48
		// (set) Token: 0x06006C76 RID: 27766 RVA: 0x0060EBFC File Offset: 0x0060CDFC
		public bool ExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720_Visible
		{
			get
			{
				short num = (short)849767059;
				short num2 = num;
				num = (short)209349267;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1061683200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)683016193;
				if (num != 0)
				{
				}
				num = (short)440336384;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720.Visible;
			}
			set
			{
				short num = (short)331905130;
				short num2 = num;
				num = (short)1971943530;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1386217472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)904462337;
				if (num != 0)
				{
				}
				num = (short)89653248;
				if (num != 0)
				{
				}
				this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720.Visible = value;
			}
		}

		// Token: 0x1700380F RID: 14351
		// (get) Token: 0x06006C77 RID: 27767 RVA: 0x0060ECB4 File Offset: 0x0060CEB4
		// (set) Token: 0x06006C78 RID: 27768 RVA: 0x0060ED6C File Offset: 0x0060CF6C
		public bool ExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720_Editable
		{
			get
			{
				short num = (short)2088370177;
				if (num != 0)
				{
				}
				num = (short)507576320;
				short num2 = num;
				num = (short)1146116814;
				short num3 = num;
				num = (short)1894013646;
				switch (num3 == num)
				{
				}
				num = (short)1361117184;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720.Editable;
			}
			set
			{
				short num = (short)155805753;
				short num2 = num;
				num = (short)1558865977;
				switch (num2 == num)
				{
				default:
				{
					num = (short)675086336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1398013953;
				if (num != 0)
				{
				}
				num = (short)54591488;
				if (num != 0)
				{
				}
				this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720.Editable = value;
			}
		}

		// Token: 0x17003810 RID: 14352
		// (get) Token: 0x06006C79 RID: 27769 RVA: 0x0060EE24 File Offset: 0x0060D024
		internal string ExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720_UILabel
		{
			get
			{
				short num = (short)1051645812;
				short num2 = num;
				num = (short)693950324;
				switch (num2 == num)
				{
				default:
				{
					num = (short)39845888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1334050816;
				if (num != 0)
				{
				}
				num = (short)405209089;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720.UIName;
			}
		}

		// Token: 0x17003811 RID: 14353
		// (get) Token: 0x06006C7A RID: 27770 RVA: 0x0060EED8 File Offset: 0x0060D0D8
		// (set) Token: 0x06006C7B RID: 27771 RVA: 0x0060EF8C File Offset: 0x0060D18C
		internal bool ExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720_HiddenStatic
		{
			get
			{
				short num = (short)26738689;
				if (num != 0)
				{
				}
				num = (short)1235025920;
				short num2 = num;
				num = (short)227606810;
				short num3 = num;
				num = (short)1791099162;
				switch (num3 == num)
				{
				}
				num = (short)848101376;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720.HiddenStatic;
			}
			set
			{
				short num = (short)1517754034;
				short num2 = num;
				num = (short)1428297394;
				switch (num2 == num)
				{
				default:
				{
					num = (short)86245376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1031798785;
				if (num != 0)
				{
				}
				num = (short)1616838656;
				if (num != 0)
				{
				}
				this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720.HiddenStatic = value;
			}
		}

		// Token: 0x17003812 RID: 14354
		// (get) Token: 0x06006C7C RID: 27772 RVA: 0x0060F040 File Offset: 0x0060D240
		// (set) Token: 0x06006C7D RID: 27773 RVA: 0x0060F0F4 File Offset: 0x0060D2F4
		internal bool ExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720_HiddenDynamic
		{
			get
			{
				short num = (short)892848359;
				short num2 = num;
				num = (short)1883621607;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1364000768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1936719873;
				if (num != 0)
				{
				}
				num = (short)1732247552;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720.HiddenDynamic;
			}
			set
			{
				short num = (short)1311702658;
				short num2 = num;
				num = (short)1103494786;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1599799296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1961885696;
				if (num != 0)
				{
				}
				num = (short)1913323521;
				if (num != 0)
				{
				}
				this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720.HiddenDynamic = value;
			}
		}

		// Token: 0x17003813 RID: 14355
		// (get) Token: 0x06006C7E RID: 27774 RVA: 0x0060F1AC File Offset: 0x0060D3AC
		public bool ExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720_HasDiffs
		{
			get
			{
				short num = (short)1991264205;
				short num2 = num;
				num = (short)1130317773;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1804468224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)43253760;
				if (num != 0)
				{
				}
				num = (short)1624768513;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenDINCOUTPUTEQVECTOR_A37720._HasDiffs;
			}
		}

		// Token: 0x17003814 RID: 14356
		// (get) Token: 0x06006C7F RID: 27775 RVA: 0x0060F260 File Offset: 0x0060D460
		// (set) Token: 0x06006C80 RID: 27776 RVA: 0x0060F314 File Offset: 0x0060D514
		public string ExtMicNsRdGenDINCEPVECTOR_A37721Value
		{
			get
			{
				short num = (short)1782841345;
				if (num != 0)
				{
				}
				num = (short)1930035200;
				short num2 = num;
				num = (short)1559104361;
				short num3 = num;
				num = (short)771951465;
				switch (num3 == num)
				{
				}
				num = (short)1919942656;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenDINCEPVECTOR_A37721.Value;
			}
			set
			{
				short num = (short)976930584;
				short num2 = num;
				num = (short)465749784;
				switch (num2 == num)
				{
				default:
				{
					num = (short)982581248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1337917441;
				if (num != 0)
				{
				}
				num = (short)2147352576;
				if (num != 0)
				{
				}
				this.extMicNsRdGenDINCEPVECTOR_A37721.Value = value;
			}
		}

		// Token: 0x17003815 RID: 14357
		// (get) Token: 0x06006C81 RID: 27777 RVA: 0x0060F3C8 File Offset: 0x0060D5C8
		public global::AcpBusinessLayer.AcpField<string> ExtMicNsRdGenDINCEPVECTOR_A37721
		{
			get
			{
				short num = (short)369170505;
				short num2 = num;
				num = (short)641734729;
				switch (num2 == num)
				{
				default:
				{
					num = (short)142278656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1107492865;
				if (num != 0)
				{
				}
				num = (short)985006080;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenDINCEPVECTOR_A37721;
			}
		}

		// Token: 0x17003816 RID: 14358
		// (get) Token: 0x06006C82 RID: 27778 RVA: 0x0060F478 File Offset: 0x0060D678
		// (set) Token: 0x06006C83 RID: 27779 RVA: 0x0060F530 File Offset: 0x0060D730
		public string ExtMicNsRdGenDINCEPVECTOR_A37721_UIValue
		{
			get
			{
				short num = (short)2076697822;
				short num2 = num;
				num = (short)592110814;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1035927552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1074724865;
				if (num != 0)
				{
				}
				num = (short)1854210048;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenDINCEPVECTOR_A37721.Value;
			}
			set
			{
				short num = (short)1708576592;
				short num2 = num;
				num = (short)630771536;
				switch (num2 == num)
				{
				default:
				{
					num = (short)915341312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1145831424;
				if (num != 0)
				{
				}
				num = (short)246349825;
				if (num != 0)
				{
				}
				this.extMicNsRdGenDINCEPVECTOR_A37721.Value = value;
			}
		}

		// Token: 0x17003817 RID: 14359
		// (get) Token: 0x06006C84 RID: 27780 RVA: 0x0060F5E4 File Offset: 0x0060D7E4
		// (set) Token: 0x06006C85 RID: 27781 RVA: 0x0060F694 File Offset: 0x0060D894
		public bool ExtMicNsRdGenDINCEPVECTOR_A37721_Applicable
		{
			get
			{
				short num = (short)65019786;
				short num2 = num;
				num = (short)733880202;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1463091200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1374879745;
				if (num != 0)
				{
				}
				num = (short)1645215744;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenDINCEPVECTOR_A37721.Applicable;
			}
			set
			{
				short num = (short)632454592;
				short num2 = num;
				num = (short)2094431680;
				switch (num2 == num)
				{
				default:
				{
					num = (short)954662912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1331822593;
				if (num != 0)
				{
				}
				num = (short)784007168;
				if (num != 0)
				{
				}
				this.extMicNsRdGenDINCEPVECTOR_A37721.Applicable = value;
			}
		}

		// Token: 0x17003818 RID: 14360
		// (get) Token: 0x06006C86 RID: 27782 RVA: 0x0060F748 File Offset: 0x0060D948
		// (set) Token: 0x06006C87 RID: 27783 RVA: 0x0060F7FC File Offset: 0x0060D9FC
		public bool ExtMicNsRdGenDINCEPVECTOR_A37721_Valid
		{
			get
			{
				short num = (short)981198149;
				short num2 = num;
				num = (short)1205986629;
				switch (num2 == num)
				{
				default:
				{
					num = (short)800587776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)498466817;
				if (num != 0)
				{
				}
				num = (short)1928331264;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenDINCEPVECTOR_A37721.Valid;
			}
			set
			{
				short num = (short)928907265;
				if (num != 0)
				{
				}
				num = (short)293535744;
				short num2 = num;
				num = (short)1259949400;
				short num3 = num;
				num = (short)726027608;
				switch (num3 == num)
				{
				}
				num = (short)1265631232;
				if (num != 0)
				{
				}
				this.extMicNsRdGenDINCEPVECTOR_A37721.Valid = value;
			}
		}

		// Token: 0x17003819 RID: 14361
		// (get) Token: 0x06006C88 RID: 27784 RVA: 0x0060F8B4 File Offset: 0x0060DAB4
		// (set) Token: 0x06006C89 RID: 27785 RVA: 0x0060F96C File Offset: 0x0060DB6C
		public bool ExtMicNsRdGenDINCEPVECTOR_A37721_Visible
		{
			get
			{
				short num = (short)1219952641;
				if (num != 0)
				{
				}
				num = (short)494010368;
				short num2 = num;
				num = (short)1472151873;
				short num3 = num;
				num = (short)956055873;
				switch (num3 == num)
				{
				}
				num = (short)477626368;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenDINCEPVECTOR_A37721.Visible;
			}
			set
			{
				short num = (short)659452958;
				short num2 = num;
				num = (short)1478980638;
				switch (num2 == num)
				{
				default:
				{
					num = (short)399376384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)545718272;
				if (num != 0)
				{
				}
				num = (short)347340801;
				if (num != 0)
				{
				}
				this.extMicNsRdGenDINCEPVECTOR_A37721.Visible = value;
			}
		}

		// Token: 0x1700381A RID: 14362
		// (get) Token: 0x06006C8A RID: 27786 RVA: 0x0060FA24 File Offset: 0x0060DC24
		// (set) Token: 0x06006C8B RID: 27787 RVA: 0x0060FAD4 File Offset: 0x0060DCD4
		public bool ExtMicNsRdGenDINCEPVECTOR_A37721_Editable
		{
			get
			{
				short num = (short)1779270318;
				short num2 = num;
				num = (short)521372334;
				switch (num2 == num)
				{
				default:
				{
					num = (short)326434816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)542113792;
				if (num != 0)
				{
				}
				num = (short)775094273;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenDINCEPVECTOR_A37721.Editable;
			}
			set
			{
				short num = (short)1856667595;
				short num2 = num;
				num = (short)479494091;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1143144448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)206700544;
				if (num != 0)
				{
				}
				num = (short)1126563841;
				if (num != 0)
				{
				}
				this.extMicNsRdGenDINCEPVECTOR_A37721.Editable = value;
			}
		}

		// Token: 0x1700381B RID: 14363
		// (get) Token: 0x06006C8C RID: 27788 RVA: 0x0060FB8C File Offset: 0x0060DD8C
		internal string ExtMicNsRdGenDINCEPVECTOR_A37721_UILabel
		{
			get
			{
				short num = (short)1932846424;
				short num2 = num;
				num = (short)1900209496;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1043398656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1195966465;
				if (num != 0)
				{
				}
				num = (short)487981056;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenDINCEPVECTOR_A37721.UIName;
			}
		}

		// Token: 0x1700381C RID: 14364
		// (get) Token: 0x06006C8D RID: 27789 RVA: 0x0060FC40 File Offset: 0x0060DE40
		// (set) Token: 0x06006C8E RID: 27790 RVA: 0x0060FCF4 File Offset: 0x0060DEF4
		internal bool ExtMicNsRdGenDINCEPVECTOR_A37721_HiddenStatic
		{
			get
			{
				short num = (short)1122017110;
				short num2 = num;
				num = (short)1283104598;
				switch (num2 == num)
				{
				default:
				{
					num = (short)790560768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1235419136;
				if (num != 0)
				{
				}
				num = (short)1567817729;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenDINCEPVECTOR_A37721.HiddenStatic;
			}
			set
			{
				short num = (short)903939477;
				short num2 = num;
				num = (short)683738517;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1635975168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)816381952;
				if (num != 0)
				{
				}
				num = (short)1325596673;
				if (num != 0)
				{
				}
				this.extMicNsRdGenDINCEPVECTOR_A37721.HiddenStatic = value;
			}
		}

		// Token: 0x1700381D RID: 14365
		// (get) Token: 0x06006C8F RID: 27791 RVA: 0x0060FDA8 File Offset: 0x0060DFA8
		// (set) Token: 0x06006C90 RID: 27792 RVA: 0x0060FE5C File Offset: 0x0060E05C
		internal bool ExtMicNsRdGenDINCEPVECTOR_A37721_HiddenDynamic
		{
			get
			{
				short num = (short)1916141569;
				if (num != 0)
				{
				}
				num = (short)1904410624;
				short num2 = num;
				num = (short)247538887;
				short num3 = num;
				num = (short)230958279;
				switch (num3 == num)
				{
				}
				num = (short)154927104;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenDINCEPVECTOR_A37721.HiddenDynamic;
			}
			set
			{
				short num = (short)1520397369;
				short num2 = num;
				num = (short)1801415737;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1794375680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1904082944;
				if (num != 0)
				{
				}
				num = (short)1455816705;
				if (num != 0)
				{
				}
				this.extMicNsRdGenDINCEPVECTOR_A37721.HiddenDynamic = value;
			}
		}

		// Token: 0x1700381E RID: 14366
		// (get) Token: 0x06006C91 RID: 27793 RVA: 0x0060FF14 File Offset: 0x0060E114
		public bool ExtMicNsRdGenDINCEPVECTOR_A37721_HasDiffs
		{
			get
			{
				short num = (short)2109060601;
				short num2 = num;
				num = (short)339850745;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1977090048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1264844800;
				if (num != 0)
				{
				}
				num = (short)286457857;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenDINCEPVECTOR_A37721._HasDiffs;
			}
		}

		// Token: 0x1700381F RID: 14367
		// (get) Token: 0x06006C92 RID: 27794 RVA: 0x0060FFC8 File Offset: 0x0060E1C8
		// (set) Token: 0x06006C93 RID: 27795 RVA: 0x0061007C File Offset: 0x0060E27C
		public int RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302Value
		{
			get
			{
				short num = (short)1995784491;
				short num2 = num;
				num = (short)1504723243;
				switch (num2 == num)
				{
				default:
				{
					num = (short)981860352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)724107265;
				if (num != 0)
				{
				}
				num = (short)30867456;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.Value;
			}
			set
			{
				short num = (short)45902725;
				short num2 = num;
				num = (short)160983941;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1262747648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)51380225;
				if (num != 0)
				{
				}
				num = (short)654704640;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.Value = value;
			}
		}

		// Token: 0x17003820 RID: 14368
		// (get) Token: 0x06006C94 RID: 27796 RVA: 0x00610130 File Offset: 0x0060E330
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302
		{
			get
			{
				short num = (short)1800077313;
				if (num != 0)
				{
				}
				num = (short)561840128;
				short num2 = num;
				num = (short)1448908678;
				short num3 = num;
				num = (short)701994886;
				switch (num3 == num)
				{
				}
				num = (short)162594816;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302;
			}
		}

		// Token: 0x17003821 RID: 14369
		// (get) Token: 0x06006C95 RID: 27797 RVA: 0x006101E0 File Offset: 0x0060E3E0
		// (set) Token: 0x06006C96 RID: 27798 RVA: 0x00610294 File Offset: 0x0060E494
		public string RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302_UIValue
		{
			get
			{
				short num = (short)1614694238;
				short num2 = num;
				num = (short)1276135262;
				switch (num2 == num)
				{
				default:
				{
					num = (short)861732864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1312161792;
				if (num != 0)
				{
				}
				num = (short)533594113;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.UIValue;
			}
			set
			{
				short num = (short)1467912925;
				short num2 = num;
				num = (short)1134858973;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1280901120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)57540608;
				if (num != 0)
				{
				}
				num = (short)375521281;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.UIValue = value;
			}
		}

		// Token: 0x17003822 RID: 14370
		// (get) Token: 0x06006C97 RID: 27799 RVA: 0x00610348 File Offset: 0x0060E548
		// (set) Token: 0x06006C98 RID: 27800 RVA: 0x006103FC File Offset: 0x0060E5FC
		public string RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302_HexUIValue
		{
			get
			{
				short num = (short)772652289;
				short num2 = num;
				num = (short)1470479617;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1521025024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)591527936;
				if (num != 0)
				{
				}
				num = (short)1695875073;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.HexUIValue;
			}
			set
			{
				short num = (short)2017569738;
				short num2 = num;
				num = (short)910994378;
				switch (num2 == num)
				{
				default:
				{
					num = (short)698155008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1093533697;
				if (num != 0)
				{
				}
				num = (short)336592896;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.HexUIValue = value;
			}
		}

		// Token: 0x17003823 RID: 14371
		// (get) Token: 0x06006C99 RID: 27801 RVA: 0x006104B8 File Offset: 0x0060E6B8
		// (set) Token: 0x06006C9A RID: 27802 RVA: 0x0061056C File Offset: 0x0060E76C
		internal int RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302Min
		{
			get
			{
				short num = (short)1757110417;
				short num2 = num;
				num = (short)42885265;
				switch (num2 == num)
				{
				default:
				{
					num = (short)145424384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)387579904;
				if (num != 0)
				{
				}
				num = (short)1226833921;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.Min;
			}
			set
			{
				short num = (short)247657807;
				short num2 = num;
				num = (short)1151530319;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1074397184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)275251200;
				if (num != 0)
				{
				}
				num = (short)435683329;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.Min = value;
			}
		}

		// Token: 0x17003824 RID: 14372
		// (get) Token: 0x06006C9B RID: 27803 RVA: 0x00610624 File Offset: 0x0060E824
		// (set) Token: 0x06006C9C RID: 27804 RVA: 0x006106D8 File Offset: 0x0060E8D8
		internal int RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302Max
		{
			get
			{
				short num = (short)516130694;
				short num2 = num;
				num = (short)1464960902;
				switch (num2 == num)
				{
				default:
				{
					num = (short)99155968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)628555777;
				if (num != 0)
				{
				}
				num = (short)827392000;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.Max;
			}
			set
			{
				short num = (short)1239954466;
				short num2 = num;
				num = (short)510997538;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2012020736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)955252736;
				if (num != 0)
				{
				}
				num = (short)1973157889;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.Max = value;
			}
		}

		// Token: 0x17003825 RID: 14373
		// (get) Token: 0x06006C9D RID: 27805 RVA: 0x00610790 File Offset: 0x0060E990
		// (set) Token: 0x06006C9E RID: 27806 RVA: 0x00610844 File Offset: 0x0060EA44
		internal int RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302Step
		{
			get
			{
				short num = (short)1836938674;
				short num2 = num;
				num = (short)894596530;
				switch (num2 == num)
				{
				default:
				{
					num = (short)372965376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)92274688;
				if (num != 0)
				{
				}
				num = (short)443351041;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.StepSize;
			}
			set
			{
				short num = (short)749613793;
				short num2 = num;
				num = (short)1979724513;
				switch (num2 == num)
				{
				default:
				{
					num = (short)704643072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1322844160;
				if (num != 0)
				{
				}
				num = (short)2022440961;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.StepSize = value;
			}
		}

		// Token: 0x17003826 RID: 14374
		// (get) Token: 0x06006C9F RID: 27807 RVA: 0x006108F8 File Offset: 0x0060EAF8
		// (set) Token: 0x06006CA0 RID: 27808 RVA: 0x006109AC File Offset: 0x0060EBAC
		public bool RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302_Applicable
		{
			get
			{
				short num = (short)1001717761;
				if (num != 0)
				{
				}
				num = (short)1441071104;
				short num2 = num;
				num = (short)1951269521;
				short num3 = num;
				num = (short)179241617;
				switch (num3 == num)
				{
				}
				num = (short)678100992;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.Applicable;
			}
			set
			{
				short num = (short)397284095;
				short num2 = num;
				num = (short)659231487;
				switch (num2 == num)
				{
				default:
				{
					num = (short)917372928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1793064960;
				if (num != 0)
				{
				}
				num = (short)1580335105;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.Applicable = value;
			}
		}

		// Token: 0x17003827 RID: 14375
		// (get) Token: 0x06006CA1 RID: 27809 RVA: 0x00610A60 File Offset: 0x0060EC60
		// (set) Token: 0x06006CA2 RID: 27810 RVA: 0x00610B10 File Offset: 0x0060ED10
		public bool RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302_Valid
		{
			get
			{
				short num = (short)659940456;
				short num2 = num;
				num = (short)2099635304;
				switch (num2 == num)
				{
				default:
				{
					num = (short)854392832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1466761217;
				if (num != 0)
				{
				}
				num = (short)766377984;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.Valid;
			}
			set
			{
				short num = (short)1793477046;
				short num2 = num;
				num = (short)380062134;
				switch (num2 == num)
				{
				default:
				{
					num = (short)792461312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1443495936;
				if (num != 0)
				{
				}
				num = (short)1578696705;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.Valid = value;
			}
		}

		// Token: 0x17003828 RID: 14376
		// (get) Token: 0x06006CA3 RID: 27811 RVA: 0x00610BC4 File Offset: 0x0060EDC4
		// (set) Token: 0x06006CA4 RID: 27812 RVA: 0x00610C78 File Offset: 0x0060EE78
		public bool RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302_Visible
		{
			get
			{
				short num = (short)432427702;
				short num2 = num;
				num = (short)1782993590;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1999634432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)786235393;
				if (num != 0)
				{
				}
				num = (short)1111687168;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.Visible;
			}
			set
			{
				short num = (short)653655144;
				short num2 = num;
				num = (short)1921514600;
				switch (num2 == num)
				{
				default:
				{
					num = (short)244514816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1484062721;
				if (num != 0)
				{
				}
				num = (short)1963130880;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.Visible = value;
			}
		}

		// Token: 0x17003829 RID: 14377
		// (get) Token: 0x06006CA5 RID: 27813 RVA: 0x00610D30 File Offset: 0x0060EF30
		// (set) Token: 0x06006CA6 RID: 27814 RVA: 0x00610DE8 File Offset: 0x0060EFE8
		public bool RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302_Editable
		{
			get
			{
				short num = (short)483108391;
				short num2 = num;
				num = (short)1468180007;
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
				num = (short)2105671680;
				if (num != 0)
				{
				}
				num = (short)465960961;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.Editable;
			}
			set
			{
				short num = (short)877650199;
				short num2 = num;
				num = (short)114155799;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1406140416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)451215360;
				if (num != 0)
				{
				}
				num = (short)1728708609;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.Editable = value;
			}
		}

		// Token: 0x1700382A RID: 14378
		// (get) Token: 0x06006CA7 RID: 27815 RVA: 0x00610E9C File Offset: 0x0060F09C
		internal string RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302_UILabel
		{
			get
			{
				short num = (short)375811433;
				short num2 = num;
				num = (short)1438281065;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2117402624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)199557121;
				if (num != 0)
				{
				}
				num = (short)539099136;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.UIName;
			}
		}

		// Token: 0x1700382B RID: 14379
		// (get) Token: 0x06006CA8 RID: 27816 RVA: 0x00610F50 File Offset: 0x0060F150
		// (set) Token: 0x06006CA9 RID: 27817 RVA: 0x00611004 File Offset: 0x0060F204
		internal bool RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302_HiddenStatic
		{
			get
			{
				short num = (short)1017343783;
				short num2 = num;
				num = (short)1142779687;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1215889408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)489291777;
				if (num != 0)
				{
				}
				num = (short)1647116288;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.HiddenStatic;
			}
			set
			{
				short num = (short)1341019045;
				short num2 = num;
				num = (short)1915507621;
				switch (num2 == num)
				{
				default:
				{
					num = (short)133234688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1061945345;
				if (num != 0)
				{
				}
				num = (short)1551106048;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.HiddenStatic = value;
			}
		}

		// Token: 0x1700382C RID: 14380
		// (get) Token: 0x06006CAA RID: 27818 RVA: 0x006110B8 File Offset: 0x0060F2B8
		// (set) Token: 0x06006CAB RID: 27819 RVA: 0x0061116C File Offset: 0x0060F36C
		internal bool RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302_HiddenDynamic
		{
			get
			{
				short num = (short)405718904;
				short num2 = num;
				num = (short)255117176;
				switch (num2 == num)
				{
				default:
				{
					num = (short)445775872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)404684801;
				if (num != 0)
				{
				}
				num = (short)1622081536;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.HiddenDynamic;
			}
			set
			{
				short num = (short)124346788;
				short num2 = num;
				num = (short)1742627236;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1684668416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)777322497;
				if (num != 0)
				{
				}
				num = (short)1032650752;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302.HiddenDynamic = value;
			}
		}

		// Token: 0x1700382D RID: 14381
		// (get) Token: 0x06006CAC RID: 27820 RVA: 0x00611220 File Offset: 0x0060F420
		public bool RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302_HasDiffs
		{
			get
			{
				short num = (short)1695344613;
				short num2 = num;
				num = (short)203941861;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1017446400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)92667904;
				if (num != 0)
				{
				}
				num = (short)1563557889;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302._HasDiffs;
			}
		}

		// Token: 0x1700382E RID: 14382
		// (get) Token: 0x06006CAD RID: 27821 RVA: 0x006112D4 File Offset: 0x0060F4D4
		// (set) Token: 0x06006CAE RID: 27822 RVA: 0x00611388 File Offset: 0x0060F588
		public int RadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305Value
		{
			get
			{
				short num = (short)1708259487;
				short num2 = num;
				num = (short)1102641311;
				switch (num2 == num)
				{
				default:
				{
					num = (short)494993408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1987248129;
				if (num != 0)
				{
				}
				num = (short)591855616;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.Value;
			}
			set
			{
				short num = (short)817132917;
				short num2 = num;
				num = (short)787379573;
				switch (num2 == num)
				{
				default:
				{
					num = (short)383188992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)669057024;
				if (num != 0)
				{
				}
				num = (short)495976449;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.Value = value;
			}
		}

		// Token: 0x1700382F RID: 14383
		// (get) Token: 0x06006CAF RID: 27823 RVA: 0x00611440 File Offset: 0x0060F640
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305
		{
			get
			{
				short num = (short)159631587;
				short num2 = num;
				num = (short)885049571;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1882980352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)809107456;
				if (num != 0)
				{
				}
				num = (short)753860609;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305;
			}
		}

		// Token: 0x17003830 RID: 14384
		// (get) Token: 0x06006CB0 RID: 27824 RVA: 0x006114F0 File Offset: 0x0060F6F0
		// (set) Token: 0x06006CB1 RID: 27825 RVA: 0x006115A0 File Offset: 0x0060F7A0
		public string RadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305_UIValue
		{
			get
			{
				short num = (short)418435550;
				short num2 = num;
				num = (short)1489162718;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1166802944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)173604864;
				if (num != 0)
				{
				}
				num = (short)2048786433;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.UIValue;
			}
			set
			{
				short num = (short)1326439507;
				short num2 = num;
				num = (short)310107219;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1612447744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1596260352;
				if (num != 0)
				{
				}
				num = (short)1464598529;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.UIValue = value;
			}
		}

		// Token: 0x17003831 RID: 14385
		// (get) Token: 0x06006CB2 RID: 27826 RVA: 0x00611654 File Offset: 0x0060F854
		// (set) Token: 0x06006CB3 RID: 27827 RVA: 0x0061170C File Offset: 0x0060F90C
		public string RadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305_HexUIValue
		{
			get
			{
				short num = (short)834185849;
				short num2 = num;
				num = (short)1298049657;
				switch (num2 == num)
				{
				default:
				{
					num = (short)660275200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2067595264;
				if (num != 0)
				{
				}
				num = (short)921108481;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.HexUIValue;
			}
			set
			{
				short num = (short)1837109998;
				short num2 = num;
				num = (short)1116476142;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1787953152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1614544897;
				if (num != 0)
				{
				}
				num = (short)1612840960;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.HexUIValue = value;
			}
		}

		// Token: 0x17003832 RID: 14386
		// (get) Token: 0x06006CB4 RID: 27828 RVA: 0x006117C0 File Offset: 0x0060F9C0
		// (set) Token: 0x06006CB5 RID: 27829 RVA: 0x00611878 File Offset: 0x0060FA78
		internal int RadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305Min
		{
			get
			{
				short num = (short)541834582;
				short num2 = num;
				num = (short)2074656086;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1814364160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)679280641;
				if (num != 0)
				{
				}
				num = (short)494141440;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.Min;
			}
			set
			{
				short num = (short)513006663;
				short num2 = num;
				num = (short)1018551367;
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
				num = (short)802029569;
				if (num != 0)
				{
				}
				num = (short)1744437248;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.Min = value;
			}
		}

		// Token: 0x17003833 RID: 14387
		// (get) Token: 0x06006CB6 RID: 27830 RVA: 0x00611930 File Offset: 0x0060FB30
		// (set) Token: 0x06006CB7 RID: 27831 RVA: 0x006119E4 File Offset: 0x0060FBE4
		internal int RadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305Max
		{
			get
			{
				short num = (short)1866137601;
				if (num != 0)
				{
				}
				num = (short)266665984;
				short num2 = num;
				num = (short)1142453218;
				short num3 = num;
				num = (short)961246178;
				switch (num3 == num)
				{
				}
				num = (short)1366687744;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.Max;
			}
			set
			{
				short num = (short)1673166778;
				short num2 = num;
				num = (short)411140026;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2079260672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)416612352;
				if (num != 0)
				{
				}
				num = (short)1079050241;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.Max = value;
			}
		}

		// Token: 0x17003834 RID: 14388
		// (get) Token: 0x06006CB8 RID: 27832 RVA: 0x00611A98 File Offset: 0x0060FC98
		// (set) Token: 0x06006CB9 RID: 27833 RVA: 0x00611B50 File Offset: 0x0060FD50
		internal int RadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305Step
		{
			get
			{
				short num = (short)337216875;
				short num2 = num;
				num = (short)2051245419;
				switch (num2 == num)
				{
				}
				num = (short)1040187393;
				if (num != 0)
				{
				}
				num = (short)354222080;
				if (num != 0)
				{
				}
				num = (short)865271808;
				short num3 = num;
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.StepSize;
			}
			set
			{
				short num = (short)605693917;
				short num2 = num;
				num = (short)313993181;
				switch (num2 == num)
				{
				}
				num = (short)626917377;
				if (num != 0)
				{
				}
				num = (short)1609564160;
				if (num != 0)
				{
				}
				num = (short)1055784960;
				short num3 = num;
				this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.StepSize = value;
			}
		}

		// Token: 0x17003835 RID: 14389
		// (get) Token: 0x06006CBA RID: 27834 RVA: 0x00611C04 File Offset: 0x0060FE04
		// (set) Token: 0x06006CBB RID: 27835 RVA: 0x00611CB8 File Offset: 0x0060FEB8
		public bool RadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305_Applicable
		{
			get
			{
				short num = (short)996287365;
				short num2 = num;
				num = (short)1884365701;
				switch (num2 == num)
				{
				}
				num = (short)904462337;
				if (num != 0)
				{
				}
				num = (short)203227136;
				if (num != 0)
				{
				}
				num = (short)423624704;
				short num3 = num;
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.Applicable;
			}
			set
			{
				short num = (short)612482808;
				short num2 = num;
				num = (short)44416760;
				switch (num2 == num)
				{
				}
				num = (short)1165557761;
				if (num != 0)
				{
				}
				num = (short)1928790016;
				if (num != 0)
				{
				}
				num = (short)1658781696;
				short num3 = num;
				this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.Applicable = value;
			}
		}

		// Token: 0x17003836 RID: 14390
		// (get) Token: 0x06006CBC RID: 27836 RVA: 0x00611D6C File Offset: 0x0060FF6C
		// (set) Token: 0x06006CBD RID: 27837 RVA: 0x00611E24 File Offset: 0x00610024
		public bool RadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305_Valid
		{
			get
			{
				short num = (short)1671989360;
				short num2 = num;
				num = (short)1304135792;
				switch (num2 == num)
				{
				}
				num = (short)67239936;
				if (num != 0)
				{
				}
				num = (short)606863361;
				if (num != 0)
				{
				}
				num = (short)1200226304;
				short num3 = num;
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.Valid;
			}
			set
			{
				short num = (short)1052925374;
				short num2 = num;
				num = (short)853499326;
				switch (num2 == num)
				{
				}
				num = (short)791085057;
				if (num != 0)
				{
				}
				num = (short)993656832;
				if (num != 0)
				{
				}
				num = (short)573898752;
				short num3 = num;
				this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.Valid = value;
			}
		}

		// Token: 0x17003837 RID: 14391
		// (get) Token: 0x06006CBE RID: 27838 RVA: 0x00611ED8 File Offset: 0x006100D8
		// (set) Token: 0x06006CBF RID: 27839 RVA: 0x00611F8C File Offset: 0x0061018C
		public bool RadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305_Visible
		{
			get
			{
				short num = (short)65018166;
				short num2 = num;
				num = (short)937564470;
				switch (num2 == num)
				{
				}
				num = (short)1129250817;
				if (num != 0)
				{
				}
				num = (short)1153368064;
				if (num != 0)
				{
				}
				num = (short)1083637760;
				short num3 = num;
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.Visible;
			}
			set
			{
				short num = (short)1043778447;
				short num2 = num;
				num = (short)1119538063;
				switch (num2 == num)
				{
				}
				num = (short)78512129;
				if (num != 0)
				{
				}
				num = (short)1479802880;
				if (num != 0)
				{
				}
				num = (short)1829371904;
				short num3 = num;
				this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.Visible = value;
			}
		}

		// Token: 0x17003838 RID: 14392
		// (get) Token: 0x06006CC0 RID: 27840 RVA: 0x00612040 File Offset: 0x00610240
		// (set) Token: 0x06006CC1 RID: 27841 RVA: 0x006120F4 File Offset: 0x006102F4
		public bool RadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305_Editable
		{
			get
			{
				short num = (short)2032271361;
				if (num != 0)
				{
				}
				num = (short)786514237;
				short num2 = num;
				num = (short)1639203133;
				switch (num2 == num)
				{
				}
				num = (short)844562432;
				if (num != 0)
				{
				}
				num = (short)428146688;
				short num3 = num;
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.Editable;
			}
			set
			{
				short num = (short)1067548700;
				short num2 = num;
				num = (short)2128117788;
				switch (num2 == num)
				{
				}
				num = (short)59768833;
				if (num != 0)
				{
				}
				num = (short)1265303552;
				if (num != 0)
				{
				}
				num = (short)1054408704;
				short num3 = num;
				this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.Editable = value;
			}
		}

		// Token: 0x17003839 RID: 14393
		// (get) Token: 0x06006CC2 RID: 27842 RVA: 0x006121AC File Offset: 0x006103AC
		internal string RadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305_UILabel
		{
			get
			{
				short num = (short)1488846849;
				if (num != 0)
				{
				}
				num = (short)1651338443;
				short num2 = num;
				num = (short)1473342667;
				switch (num2 == num)
				{
				}
				num = (short)358023168;
				if (num != 0)
				{
				}
				num = (short)1873674240;
				short num3 = num;
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.UIName;
			}
		}

		// Token: 0x1700383A RID: 14394
		// (get) Token: 0x06006CC3 RID: 27843 RVA: 0x00612260 File Offset: 0x00610460
		// (set) Token: 0x06006CC4 RID: 27844 RVA: 0x00612318 File Offset: 0x00610518
		internal bool RadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305_HiddenStatic
		{
			get
			{
				short num = (short)591462640;
				short num2 = num;
				num = (short)616235248;
				switch (num2 == num)
				{
				}
				num = (short)1056768001;
				if (num != 0)
				{
				}
				num = (short)1437204480;
				if (num != 0)
				{
				}
				num = (short)1231486976;
				short num3 = num;
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.HiddenStatic;
			}
			set
			{
				short num = (short)648762783;
				short num2 = num;
				num = (short)997873055;
				switch (num2 == num)
				{
				}
				num = (short)306118656;
				if (num != 0)
				{
				}
				num = (short)1263992833;
				if (num != 0)
				{
				}
				num = (short)1030160384;
				short num3 = num;
				this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.HiddenStatic = value;
			}
		}

		// Token: 0x1700383B RID: 14395
		// (get) Token: 0x06006CC5 RID: 27845 RVA: 0x006123D0 File Offset: 0x006105D0
		// (set) Token: 0x06006CC6 RID: 27846 RVA: 0x00612484 File Offset: 0x00610684
		internal bool RadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305_HiddenDynamic
		{
			get
			{
				short num = (short)157659870;
				short num2 = num;
				num = (short)330478302;
				switch (num2 == num)
				{
				}
				num = (short)446365697;
				if (num != 0)
				{
				}
				num = (short)244056064;
				if (num != 0)
				{
				}
				num = (short)909180928;
				short num3 = num;
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.HiddenDynamic;
			}
			set
			{
				short num = (short)1493706846;
				short num2 = num;
				num = (short)1415719006;
				switch (num2 == num)
				{
				}
				num = (short)1461977088;
				if (num != 0)
				{
				}
				num = (short)1404436481;
				if (num != 0)
				{
				}
				num = (short)1633550336;
				short num3 = num;
				this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305.HiddenDynamic = value;
			}
		}

		// Token: 0x1700383C RID: 14396
		// (get) Token: 0x06006CC7 RID: 27847 RVA: 0x00612538 File Offset: 0x00610738
		public bool RadErgoCfgGeneralINACTIVETHRESHDBQ8_A22305_HasDiffs
		{
			get
			{
				short num = (short)1257031186;
				short num2 = num;
				num = (short)921355794;
				switch (num2 == num)
				{
				}
				num = (short)1198784512;
				if (num != 0)
				{
				}
				num = (short)1758003201;
				if (num != 0)
				{
				}
				num = (short)874708992;
				short num3 = num;
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305._HasDiffs;
			}
		}

		// Token: 0x1700383D RID: 14397
		// (get) Token: 0x06006CC8 RID: 27848 RVA: 0x006125EC File Offset: 0x006107EC
		// (set) Token: 0x06006CC9 RID: 27849 RVA: 0x006126A0 File Offset: 0x006108A0
		public int RadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307Value
		{
			get
			{
				short num = (short)1224933377;
				if (num != 0)
				{
				}
				num = (short)329766113;
				short num2 = num;
				num = (short)845206753;
				switch (num2 == num)
				{
				}
				num = (short)328859648;
				if (num != 0)
				{
				}
				num = (short)220987392;
				short num3 = num;
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.Value;
			}
			set
			{
				short num = (short)405787586;
				short num2 = num;
				num = (short)1926091714;
				switch (num2 == num)
				{
				}
				num = (short)774569985;
				if (num != 0)
				{
				}
				num = (short)218759168;
				if (num != 0)
				{
				}
				num = (short)789381120;
				short num3 = num;
				this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.Value = value;
			}
		}

		// Token: 0x1700383E RID: 14398
		// (get) Token: 0x06006CCA RID: 27850 RVA: 0x00612754 File Offset: 0x00610954
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307
		{
			get
			{
				short num = (short)318110814;
				short num2 = num;
				num = (short)1685912670;
				switch (num2 == num)
				{
				}
				num = (short)1469841408;
				if (num != 0)
				{
				}
				num = (short)412745729;
				if (num != 0)
				{
				}
				num = (short)382402560;
				short num3 = num;
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307;
			}
		}

		// Token: 0x1700383F RID: 14399
		// (get) Token: 0x06006CCB RID: 27851 RVA: 0x00612804 File Offset: 0x00610A04
		// (set) Token: 0x06006CCC RID: 27852 RVA: 0x006128B8 File Offset: 0x00610AB8
		public string RadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307_UIValue
		{
			get
			{
				short num = (short)2106999777;
				short num2 = num;
				num = (short)2127381473;
				switch (num2 == num)
				{
				}
				num = (short)1503723521;
				if (num != 0)
				{
				}
				num = (short)873594880;
				if (num != 0)
				{
				}
				num = (short)258801664;
				short num3 = num;
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.UIValue;
			}
			set
			{
				short num = (short)181043174;
				short num2 = num;
				num = (short)1377533926;
				switch (num2 == num)
				{
				}
				num = (short)1402011649;
				if (num != 0)
				{
				}
				num = (short)1694040064;
				if (num != 0)
				{
				}
				num = (short)542769152;
				short num3 = num;
				this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.UIValue = value;
			}
		}

		// Token: 0x17003840 RID: 14400
		// (get) Token: 0x06006CCD RID: 27853 RVA: 0x00612970 File Offset: 0x00610B70
		// (set) Token: 0x06006CCE RID: 27854 RVA: 0x00612A24 File Offset: 0x00610C24
		public string RadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307_HexUIValue
		{
			get
			{
				short num = (short)1762406712;
				short num2 = num;
				num = (short)402993464;
				switch (num2 == num)
				{
				}
				num = (short)900136960;
				if (num != 0)
				{
				}
				num = (short)880214017;
				if (num != 0)
				{
				}
				num = (short)725680128;
				short num3 = num;
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.HexUIValue;
			}
			set
			{
				short num = (short)1489240065;
				if (num != 0)
				{
				}
				num = (short)1605227803;
				short num2 = num;
				num = (short)64345371;
				switch (num2 == num)
				{
				}
				num = (short)2032664576;
				if (num != 0)
				{
				}
				num = (short)2030501888;
				short num3 = num;
				this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.HexUIValue = value;
			}
		}

		// Token: 0x17003841 RID: 14401
		// (get) Token: 0x06006CCF RID: 27855 RVA: 0x00612ADC File Offset: 0x00610CDC
		// (set) Token: 0x06006CD0 RID: 27856 RVA: 0x00612B90 File Offset: 0x00610D90
		internal int RadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307Min
		{
			get
			{
				short num = (short)1548858154;
				short num2 = num;
				num = (short)52343594;
				switch (num2 == num)
				{
				}
				num = (short)2129330176;
				if (num != 0)
				{
				}
				num = (short)1773928449;
				if (num != 0)
				{
				}
				num = (short)664010752;
				short num3 = num;
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.Min;
			}
			set
			{
				short num = (short)164227867;
				short num2 = num;
				num = (short)1936190235;
				switch (num2 == num)
				{
				}
				num = (short)1252720640;
				if (num != 0)
				{
				}
				num = (short)414253057;
				if (num != 0)
				{
				}
				num = (short)166920192;
				short num3 = num;
				this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.Min = value;
			}
		}

		// Token: 0x17003842 RID: 14402
		// (get) Token: 0x06006CD1 RID: 27857 RVA: 0x00612C48 File Offset: 0x00610E48
		// (set) Token: 0x06006CD2 RID: 27858 RVA: 0x00612CFC File Offset: 0x00610EFC
		internal int RadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307Max
		{
			get
			{
				short num = (short)1532243051;
				short num2 = num;
				num = (short)1183984747;
				switch (num2 == num)
				{
				}
				num = (short)70975488;
				if (num != 0)
				{
				}
				num = (short)126550017;
				if (num != 0)
				{
				}
				num = (short)1058996224;
				short num3 = num;
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.Max;
			}
			set
			{
				short num = (short)2112140711;
				short num2 = num;
				num = (short)769897895;
				switch (num2 == num)
				{
				}
				num = (short)275185665;
				if (num != 0)
				{
				}
				num = (short)1395851264;
				if (num != 0)
				{
				}
				num = (short)986316800;
				short num3 = num;
				this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.Max = value;
			}
		}

		// Token: 0x17003843 RID: 14403
		// (get) Token: 0x06006CD3 RID: 27859 RVA: 0x00612DB0 File Offset: 0x00610FB0
		// (set) Token: 0x06006CD4 RID: 27860 RVA: 0x00612E68 File Offset: 0x00611068
		internal int RadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307Step
		{
			get
			{
				short num = (short)1512921039;
				short num2 = num;
				num = (short)1360680911;
				switch (num2 == num)
				{
				}
				num = (short)90636288;
				if (num != 0)
				{
				}
				num = (short)792592385;
				if (num != 0)
				{
				}
				num = (short)708050944;
				short num3 = num;
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.StepSize;
			}
			set
			{
				short num = (short)163446785;
				if (num != 0)
				{
				}
				num = (short)783076153;
				short num2 = num;
				num = (short)1968819001;
				switch (num2 == num)
				{
				}
				num = (short)1536425984;
				if (num != 0)
				{
				}
				num = (short)533004288;
				short num3 = num;
				this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.StepSize = value;
			}
		}

		// Token: 0x17003844 RID: 14404
		// (get) Token: 0x06006CD5 RID: 27861 RVA: 0x00612F1C File Offset: 0x0061111C
		// (set) Token: 0x06006CD6 RID: 27862 RVA: 0x00612FD0 File Offset: 0x006111D0
		public bool RadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307_Applicable
		{
			get
			{
				short num = (short)295968754;
				short num2 = num;
				num = (short)204786;
				switch (num2 == num)
				{
				}
				num = (short)1547632641;
				if (num != 0)
				{
				}
				num = (short)1136001024;
				if (num != 0)
				{
				}
				num = (short)955645952;
				short num3 = num;
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.Applicable;
			}
			set
			{
				short num = (short)979911994;
				short num2 = num;
				num = (short)1676297530;
				switch (num2 == num)
				{
				}
				num = (short)190316544;
				if (num != 0)
				{
				}
				num = (short)1722875905;
				if (num != 0)
				{
				}
				num = (short)1890648064;
				short num3 = num;
				this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.Applicable = value;
			}
		}

		// Token: 0x17003845 RID: 14405
		// (get) Token: 0x06006CD7 RID: 27863 RVA: 0x00613088 File Offset: 0x00611288
		// (set) Token: 0x06006CD8 RID: 27864 RVA: 0x0061313C File Offset: 0x0061133C
		public bool RadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307_Valid
		{
			get
			{
				short num = (short)1902327479;
				short num2 = num;
				num = (short)655374007;
				switch (num2 == num)
				{
				}
				num = (short)1781858305;
				if (num != 0)
				{
				}
				num = (short)1632370688;
				if (num != 0)
				{
				}
				num = (short)1874329600;
				short num3 = num;
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.Valid;
			}
			set
			{
				short num = (short)726823045;
				short num2 = num;
				num = (short)64516229;
				switch (num2 == num)
				{
				}
				num = (short)316014593;
				if (num != 0)
				{
				}
				num = (short)385155072;
				if (num != 0)
				{
				}
				num = (short)1097138176;
				short num3 = num;
				this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.Valid = value;
			}
		}

		// Token: 0x17003846 RID: 14406
		// (get) Token: 0x06006CD9 RID: 27865 RVA: 0x006131F0 File Offset: 0x006113F0
		// (set) Token: 0x06006CDA RID: 27866 RVA: 0x006132A4 File Offset: 0x006114A4
		public bool RadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307_Visible
		{
			get
			{
				short num = (short)1242103809;
				if (num != 0)
				{
				}
				num = (short)176736764;
				short num2 = num;
				num = (short)1086638588;
				switch (num2 == num)
				{
				}
				num = (short)163840000;
				if (num != 0)
				{
				}
				num = (short)1522860032;
				short num3 = num;
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.Visible;
			}
			set
			{
				short num = (short)1398800385;
				if (num != 0)
				{
				}
				num = (short)529648970;
				short num2 = num;
				num = (short)65326410;
				switch (num2 == num)
				{
				}
				num = (short)327942144;
				if (num != 0)
				{
				}
				num = (short)1993867264;
				short num3 = num;
				this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.Visible = value;
			}
		}

		// Token: 0x17003847 RID: 14407
		// (get) Token: 0x06006CDB RID: 27867 RVA: 0x0061335C File Offset: 0x0061155C
		// (set) Token: 0x06006CDC RID: 27868 RVA: 0x00613410 File Offset: 0x00611610
		public bool RadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307_Editable
		{
			get
			{
				short num = (short)152502273;
				if (num != 0)
				{
				}
				num = (short)1470420107;
				short num2 = num;
				num = (short)1770247307;
				switch (num2 == num)
				{
				}
				num = (short)1001062400;
				if (num != 0)
				{
				}
				num = (short)732626944;
				short num3 = num;
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.Editable;
			}
			set
			{
				short num = (short)1735688865;
				short num2 = num;
				num = (short)368870049;
				switch (num2 == num)
				{
				}
				num = (short)1306591233;
				if (num != 0)
				{
				}
				num = (short)953155584;
				if (num != 0)
				{
				}
				num = (short)387710976;
				short num3 = num;
				this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.Editable = value;
			}
		}

		// Token: 0x17003848 RID: 14408
		// (get) Token: 0x06006CDD RID: 27869 RVA: 0x006134C8 File Offset: 0x006116C8
		internal string RadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307_UILabel
		{
			get
			{
				short num = (short)644022273;
				if (num != 0)
				{
				}
				num = (short)2139824670;
				short num2 = num;
				num = (short)238035486;
				switch (num2 == num)
				{
				}
				num = (short)666501120;
				if (num != 0)
				{
				}
				num = (short)266141696;
				short num3 = num;
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.UIName;
			}
		}

		// Token: 0x17003849 RID: 14409
		// (get) Token: 0x06006CDE RID: 27870 RVA: 0x0061357C File Offset: 0x0061177C
		// (set) Token: 0x06006CDF RID: 27871 RVA: 0x00613630 File Offset: 0x00611830
		internal bool RadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307_HiddenStatic
		{
			get
			{
				short num = (short)1955194104;
				short num2 = num;
				num = (short)1760945400;
				switch (num2 == num)
				{
				}
				num = (short)1794048001;
				if (num != 0)
				{
				}
				num = (short)1894121472;
				if (num != 0)
				{
				}
				num = (short)721682432;
				short num3 = num;
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.HiddenStatic;
			}
			set
			{
				short num = (short)770380136;
				short num2 = num;
				num = (short)983437672;
				switch (num2 == num)
				{
				}
				num = (short)136511489;
				if (num != 0)
				{
				}
				num = (short)896925696;
				if (num != 0)
				{
				}
				num = (short)50135040;
				short num3 = num;
				this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.HiddenStatic = value;
			}
		}

		// Token: 0x1700384A RID: 14410
		// (get) Token: 0x06006CE0 RID: 27872 RVA: 0x006136E8 File Offset: 0x006118E8
		// (set) Token: 0x06006CE1 RID: 27873 RVA: 0x006137A0 File Offset: 0x006119A0
		internal bool RadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307_HiddenDynamic
		{
			get
			{
				short num = (short)478165614;
				short num2 = num;
				num = (short)557267566;
				switch (num2 == num)
				{
				}
				num = (short)907018241;
				if (num != 0)
				{
				}
				num = (short)56819712;
				if (num != 0)
				{
				}
				num = (short)1440677888;
				short num3 = num;
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.HiddenDynamic;
			}
			set
			{
				short num = (short)1968176105;
				short num2 = num;
				num = (short)1381759977;
				switch (num2 == num)
				{
				}
				num = (short)2050490368;
				if (num != 0)
				{
				}
				num = (short)731906049;
				if (num != 0)
				{
				}
				num = (short)1509359616;
				short num3 = num;
				this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307.HiddenDynamic = value;
			}
		}

		// Token: 0x1700384B RID: 14411
		// (get) Token: 0x06006CE2 RID: 27874 RVA: 0x00613854 File Offset: 0x00611A54
		public bool RadErgoCfgGeneralNDIFFTHRESHDBQ8_A22307_HasDiffs
		{
			get
			{
				short num = (short)1282408449;
				if (num != 0)
				{
				}
				num = (short)1664557158;
				short num2 = num;
				num = (short)1965564006;
				switch (num2 == num)
				{
				}
				num = (short)2050359296;
				if (num != 0)
				{
				}
				num = (short)103612416;
				short num3 = num;
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307._HasDiffs;
			}
		}

		// Token: 0x1700384C RID: 14412
		// (get) Token: 0x06006CE3 RID: 27875 RVA: 0x00613908 File Offset: 0x00611B08
		// (set) Token: 0x06006CE4 RID: 27876 RVA: 0x006139BC File Offset: 0x00611BBC
		public int RadErgoCfgGeneralRTHRESHDBQ8_A22308Value
		{
			get
			{
				short num = (short)1673947081;
				short num2 = num;
				num = (short)195651529;
				switch (num2 == num)
				{
				}
				num = (short)367591425;
				if (num != 0)
				{
				}
				num = (short)638189568;
				if (num != 0)
				{
				}
				num = (short)1380057088;
				short num3 = num;
				return this.radErgoCfgGeneralRTHRESHDBQ8_A22308.Value;
			}
			set
			{
				short num = (short)550800340;
				short num2 = num;
				num = (short)1366330324;
				switch (num2 == num)
				{
				}
				num = (short)1183318017;
				if (num != 0)
				{
				}
				num = (short)255000576;
				if (num != 0)
				{
				}
				num = (short)1826357248;
				short num3 = num;
				this.radErgoCfgGeneralRTHRESHDBQ8_A22308.Value = value;
			}
		}

		// Token: 0x1700384D RID: 14413
		// (get) Token: 0x06006CE5 RID: 27877 RVA: 0x00613A74 File Offset: 0x00611C74
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgGeneralRTHRESHDBQ8_A22308
		{
			get
			{
				short num = (short)1467154433;
				if (num != 0)
				{
				}
				num = (short)485717125;
				short num2 = num;
				num = (short)394753157;
				switch (num2 == num)
				{
				}
				num = (short)2009923584;
				if (num != 0)
				{
				}
				num = (short)82051072;
				short num3 = num;
				return this.radErgoCfgGeneralRTHRESHDBQ8_A22308;
			}
		}

		// Token: 0x1700384E RID: 14414
		// (get) Token: 0x06006CE6 RID: 27878 RVA: 0x00613B24 File Offset: 0x00611D24
		// (set) Token: 0x06006CE7 RID: 27879 RVA: 0x00613BD8 File Offset: 0x00611DD8
		public string RadErgoCfgGeneralRTHRESHDBQ8_A22308_UIValue
		{
			get
			{
				short num = (short)592671556;
				short num2 = num;
				num = (short)649687876;
				switch (num2 == num)
				{
				}
				num = (short)479985665;
				if (num != 0)
				{
				}
				num = (short)442368000;
				if (num != 0)
				{
				}
				num = (short)1278803968;
				short num3 = num;
				return this.radErgoCfgGeneralRTHRESHDBQ8_A22308.UIValue;
			}
			set
			{
				short num = (short)1421811456;
				short num2 = num;
				num = (short)396500736;
				switch (num2 == num)
				{
				}
				num = (short)403243009;
				if (num != 0)
				{
				}
				num = (short)1086717952;
				if (num != 0)
				{
				}
				num = (short)490471424;
				short num3 = num;
				this.radErgoCfgGeneralRTHRESHDBQ8_A22308.UIValue = value;
			}
		}

		// Token: 0x1700384F RID: 14415
		// (get) Token: 0x06006CE8 RID: 27880 RVA: 0x00613C90 File Offset: 0x00611E90
		// (set) Token: 0x06006CE9 RID: 27881 RVA: 0x00613D44 File Offset: 0x00611F44
		public string RadErgoCfgGeneralRTHRESHDBQ8_A22308_HexUIValue
		{
			get
			{
				short num = (short)208450549;
				short num2 = num;
				num = (short)1336390645;
				switch (num2 == num)
				{
				}
				num = (short)1303707649;
				if (num != 0)
				{
				}
				num = (short)2068381696;
				if (num != 0)
				{
				}
				num = (short)51314688;
				short num3 = num;
				return this.radErgoCfgGeneralRTHRESHDBQ8_A22308.HexUIValue;
			}
			set
			{
				short num = (short)975299687;
				short num2 = num;
				num = (short)7660647;
				switch (num2 == num)
				{
				}
				num = (short)935591936;
				if (num != 0)
				{
				}
				num = (short)1776091137;
				if (num != 0)
				{
				}
				num = (short)600375296;
				short num3 = num;
				this.radErgoCfgGeneralRTHRESHDBQ8_A22308.HexUIValue = value;
			}
		}

		// Token: 0x17003850 RID: 14416
		// (get) Token: 0x06006CEA RID: 27882 RVA: 0x00613DF8 File Offset: 0x00611FF8
		// (set) Token: 0x06006CEB RID: 27883 RVA: 0x00613EAC File Offset: 0x006120AC
		internal int RadErgoCfgGeneralRTHRESHDBQ8_A22308Min
		{
			get
			{
				short num = (short)1192705548;
				short num2 = num;
				num = (short)2007252492;
				switch (num2 == num)
				{
				}
				num = (short)265420801;
				if (num != 0)
				{
				}
				num = (short)1364590592;
				if (num != 0)
				{
				}
				num = (short)1493368832;
				short num3 = num;
				return this.radErgoCfgGeneralRTHRESHDBQ8_A22308.Min;
			}
			set
			{
				short num = (short)1002831873;
				if (num != 0)
				{
				}
				num = (short)1253501332;
				short num2 = num;
				num = (short)1579805076;
				switch (num2 == num)
				{
				}
				num = (short)1686306816;
				if (num != 0)
				{
				}
				num = (short)1849950208;
				short num3 = num;
				this.radErgoCfgGeneralRTHRESHDBQ8_A22308.Min = value;
			}
		}

		// Token: 0x17003851 RID: 14417
		// (get) Token: 0x06006CEC RID: 27884 RVA: 0x00613F64 File Offset: 0x00612164
		// (set) Token: 0x06006CED RID: 27885 RVA: 0x00614018 File Offset: 0x00612218
		internal int RadErgoCfgGeneralRTHRESHDBQ8_A22308Max
		{
			get
			{
				short num = (short)1336467433;
				short num2 = num;
				num = (short)2080825321;
				switch (num2 == num)
				{
				}
				num = (short)2016542721;
				if (num != 0)
				{
				}
				num = (short)394723328;
				if (num != 0)
				{
				}
				num = (short)1578369024;
				short num3 = num;
				return this.radErgoCfgGeneralRTHRESHDBQ8_A22308.Max;
			}
			set
			{
				short num = (short)967847937;
				short num2 = num;
				num = (short)2083663873;
				switch (num2 == num)
				{
				}
				num = (short)861929473;
				if (num != 0)
				{
				}
				num = (short)2099380224;
				if (num != 0)
				{
				}
				num = (short)555941888;
				short num3 = num;
				this.radErgoCfgGeneralRTHRESHDBQ8_A22308.Max = value;
			}
		}

		// Token: 0x17003852 RID: 14418
		// (get) Token: 0x06006CEE RID: 27886 RVA: 0x006140D0 File Offset: 0x006122D0
		// (set) Token: 0x06006CEF RID: 27887 RVA: 0x00614188 File Offset: 0x00612388
		internal int RadErgoCfgGeneralRTHRESHDBQ8_A22308Step
		{
			get
			{
				short num = (short)595722195;
				short num2 = num;
				num = (short)1546125267;
				switch (num2 == num)
				{
				}
				num = (short)1576992769;
				if (num != 0)
				{
				}
				num = (short)225443840;
				if (num != 0)
				{
				}
				num = (short)2094333952;
				short num3 = num;
				return this.radErgoCfgGeneralRTHRESHDBQ8_A22308.StepSize;
			}
			set
			{
				short num = (short)794317874;
				short num2 = num;
				num = (short)1140479026;
				switch (num2 == num)
				{
				}
				num = (short)152633345;
				if (num != 0)
				{
				}
				num = (short)1707802624;
				if (num != 0)
				{
				}
				num = (short)1168572416;
				short num3 = num;
				this.radErgoCfgGeneralRTHRESHDBQ8_A22308.StepSize = value;
			}
		}

		// Token: 0x17003853 RID: 14419
		// (get) Token: 0x06006CF0 RID: 27888 RVA: 0x00614240 File Offset: 0x00612440
		// (set) Token: 0x06006CF1 RID: 27889 RVA: 0x006142F4 File Offset: 0x006124F4
		public bool RadErgoCfgGeneralRTHRESHDBQ8_A22308_Applicable
		{
			get
			{
				short num = (short)973755073;
				short num2 = num;
				num = (short)473060033;
				switch (num2 == num)
				{
				}
				num = (short)1826619393;
				if (num != 0)
				{
				}
				num = (short)1535705088;
				if (num != 0)
				{
				}
				num = (short)1648427008;
				short num3 = num;
				return this.radErgoCfgGeneralRTHRESHDBQ8_A22308.Applicable;
			}
			set
			{
				short num = (short)78671962;
				short num2 = num;
				num = (short)1971613786;
				switch (num2 == num)
				{
				}
				num = (short)2067136512;
				if (num != 0)
				{
				}
				num = (short)1420951553;
				if (num != 0)
				{
				}
				num = (short)1036255232;
				short num3 = num;
				this.radErgoCfgGeneralRTHRESHDBQ8_A22308.Applicable = value;
			}
		}

		// Token: 0x17003854 RID: 14420
		// (get) Token: 0x06006CF2 RID: 27890 RVA: 0x006143A8 File Offset: 0x006125A8
		// (set) Token: 0x06006CF3 RID: 27891 RVA: 0x0061445C File Offset: 0x0061265C
		public bool RadErgoCfgGeneralRTHRESHDBQ8_A22308_Valid
		{
			get
			{
				short num = (short)754373597;
				short num2 = num;
				num = (short)1331418077;
				switch (num2 == num)
				{
				}
				num = (short)1553596417;
				if (num != 0)
				{
				}
				num = (short)1995636736;
				if (num != 0)
				{
				}
				num = (short)543162368;
				short num3 = num;
				return this.radErgoCfgGeneralRTHRESHDBQ8_A22308.Valid;
			}
			set
			{
				short num = (short)227826693;
				short num2 = num;
				num = (short)40655877;
				switch (num2 == num)
				{
				}
				num = (short)832962560;
				if (num != 0)
				{
				}
				num = (short)2075066369;
				if (num != 0)
				{
				}
				num = (short)567476224;
				short num3 = num;
				this.radErgoCfgGeneralRTHRESHDBQ8_A22308.Valid = value;
			}
		}

		// Token: 0x17003855 RID: 14421
		// (get) Token: 0x06006CF4 RID: 27892 RVA: 0x00614510 File Offset: 0x00612710
		// (set) Token: 0x06006CF5 RID: 27893 RVA: 0x006145C4 File Offset: 0x006127C4
		public bool RadErgoCfgGeneralRTHRESHDBQ8_A22308_Visible
		{
			get
			{
				short num = (short)582068247;
				short num2 = num;
				num = (short)484550679;
				switch (num2 == num)
				{
				}
				num = (short)2098331649;
				if (num != 0)
				{
				}
				num = (short)1521942528;
				if (num != 0)
				{
				}
				num = (short)1963065344;
				short num3 = num;
				return this.radErgoCfgGeneralRTHRESHDBQ8_A22308.Visible;
			}
			set
			{
				short num = (short)541180263;
				short num2 = num;
				num = (short)1692516711;
				switch (num2 == num)
				{
				}
				num = (short)993918977;
				if (num != 0)
				{
				}
				num = (short)376700928;
				if (num != 0)
				{
				}
				num = (short)594280448;
				short num3 = num;
				this.radErgoCfgGeneralRTHRESHDBQ8_A22308.Visible = value;
			}
		}

		// Token: 0x17003856 RID: 14422
		// (get) Token: 0x06006CF6 RID: 27894 RVA: 0x0061467C File Offset: 0x0061287C
		// (set) Token: 0x06006CF7 RID: 27895 RVA: 0x00614734 File Offset: 0x00612934
		public bool RadErgoCfgGeneralRTHRESHDBQ8_A22308_Editable
		{
			get
			{
				short num = (short)1177812993;
				if (num != 0)
				{
				}
				num = (short)299171925;
				short num2 = num;
				num = (short)1775698005;
				switch (num2 == num)
				{
				}
				num = (short)1994260480;
				if (num != 0)
				{
				}
				num = (short)728694784;
				short num3 = num;
				return this.radErgoCfgGeneralRTHRESHDBQ8_A22308.Editable;
			}
			set
			{
				short num = (short)19800394;
				short num2 = num;
				num = (short)540549450;
				switch (num2 == num)
				{
				}
				num = (short)1494155264;
				if (num != 0)
				{
				}
				num = (short)1311834113;
				if (num != 0)
				{
				}
				num = (short)1275723776;
				short num3 = num;
				this.radErgoCfgGeneralRTHRESHDBQ8_A22308.Editable = value;
			}
		}

		// Token: 0x17003857 RID: 14423
		// (get) Token: 0x06006CF8 RID: 27896 RVA: 0x006147EC File Offset: 0x006129EC
		internal string RadErgoCfgGeneralRTHRESHDBQ8_A22308_UILabel
		{
			get
			{
				short num = (short)835730146;
				short num2 = num;
				num = (short)2003319522;
				switch (num2 == num)
				{
				}
				num = (short)777519104;
				if (num != 0)
				{
				}
				num = (short)184745985;
				if (num != 0)
				{
				}
				num = (short)430374912;
				short num3 = num;
				return this.radErgoCfgGeneralRTHRESHDBQ8_A22308.UIName;
			}
		}

		// Token: 0x17003858 RID: 14424
		// (get) Token: 0x06006CF9 RID: 27897 RVA: 0x006148A0 File Offset: 0x00612AA0
		// (set) Token: 0x06006CFA RID: 27898 RVA: 0x00614950 File Offset: 0x00612B50
		internal bool RadErgoCfgGeneralRTHRESHDBQ8_A22308_HiddenStatic
		{
			get
			{
				short num = (short)178992659;
				short num2 = num;
				num = (short)112604691;
				switch (num2 == num)
				{
				}
				num = (short)1151729665;
				if (num != 0)
				{
				}
				num = (short)989134848;
				if (num != 0)
				{
				}
				num = (short)1586823168;
				short num3 = num;
				return this.radErgoCfgGeneralRTHRESHDBQ8_A22308.HiddenStatic;
			}
			set
			{
				short num = (short)1752694785;
				if (num != 0)
				{
				}
				num = (short)2073464938;
				short num2 = num;
				num = (short)676106346;
				switch (num2 == num)
				{
				}
				num = (short)635633664;
				if (num != 0)
				{
				}
				num = (short)169082880;
				short num3 = num;
				this.radErgoCfgGeneralRTHRESHDBQ8_A22308.HiddenStatic = value;
			}
		}

		// Token: 0x17003859 RID: 14425
		// (get) Token: 0x06006CFB RID: 27899 RVA: 0x00614A08 File Offset: 0x00612C08
		// (set) Token: 0x06006CFC RID: 27900 RVA: 0x00614AC0 File Offset: 0x00612CC0
		internal bool RadErgoCfgGeneralRTHRESHDBQ8_A22308_HiddenDynamic
		{
			get
			{
				short num = (short)599952290;
				short num2 = num;
				num = (short)2128120738;
				switch (num2 == num)
				{
				}
				num = (short)2001403905;
				if (num != 0)
				{
				}
				num = (short)1097531392;
				if (num != 0)
				{
				}
				num = (short)1221066752;
				short num3 = num;
				return this.radErgoCfgGeneralRTHRESHDBQ8_A22308.HiddenDynamic;
			}
			set
			{
				short num = (short)712828307;
				short num2 = num;
				num = (short)1679484307;
				switch (num2 == num)
				{
				}
				num = (short)573308929;
				if (num != 0)
				{
				}
				num = (short)1797980160;
				if (num != 0)
				{
				}
				num = (short)766640128;
				short num3 = num;
				this.radErgoCfgGeneralRTHRESHDBQ8_A22308.HiddenDynamic = value;
			}
		}

		// Token: 0x1700385A RID: 14426
		// (get) Token: 0x06006CFD RID: 27901 RVA: 0x00614B78 File Offset: 0x00612D78
		public bool RadErgoCfgGeneralRTHRESHDBQ8_A22308_HasDiffs
		{
			get
			{
				short num = (short)1754616787;
				short num2 = num;
				num = (short)1844597715;
				switch (num2 == num)
				{
				}
				num = (short)1723858944;
				if (num != 0)
				{
				}
				num = (short)242810881;
				if (num != 0)
				{
				}
				num = (short)1592655872;
				short num3 = num;
				return this.radErgoCfgGeneralRTHRESHDBQ8_A22308._HasDiffs;
			}
		}

		// Token: 0x1700385B RID: 14427
		// (get) Token: 0x06006CFE RID: 27902 RVA: 0x00614C30 File Offset: 0x00612E30
		// (set) Token: 0x06006CFF RID: 27903 RVA: 0x00614CE4 File Offset: 0x00612EE4
		public int RadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306Value
		{
			get
			{
				short num = (short)1594835824;
				short num2 = num;
				num = (short)75055984;
				switch (num2 == num)
				{
				}
				num = (short)1476919297;
				if (num != 0)
				{
				}
				num = (short)2017656832;
				if (num != 0)
				{
				}
				num = (short)2073427968;
				short num3 = num;
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.Value;
			}
			set
			{
				short num = (short)1235006146;
				short num2 = num;
				num = (short)429306562;
				switch (num2 == num)
				{
				}
				num = (short)535166976;
				if (num != 0)
				{
				}
				num = (short)1452081153;
				if (num != 0)
				{
				}
				num = (short)281804800;
				short num3 = num;
				this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.Value = value;
			}
		}

		// Token: 0x1700385C RID: 14428
		// (get) Token: 0x06006D00 RID: 27904 RVA: 0x00614D9C File Offset: 0x00612F9C
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306
		{
			get
			{
				short num = (short)1811476169;
				short num2 = num;
				num = (short)328068809;
				switch (num2 == num)
				{
				}
				num = (short)1445593088;
				if (num != 0)
				{
				}
				num = (short)328925185;
				if (num != 0)
				{
				}
				num = (short)700514304;
				short num3 = num;
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306;
			}
		}

		// Token: 0x1700385D RID: 14429
		// (get) Token: 0x06006D01 RID: 27905 RVA: 0x00614E4C File Offset: 0x0061304C
		// (set) Token: 0x06006D02 RID: 27906 RVA: 0x00614F00 File Offset: 0x00613100
		public string RadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306_UIValue
		{
			get
			{
				short num = (short)1955130102;
				short num2 = num;
				num = (short)2112285430;
				switch (num2 == num)
				{
				}
				num = (short)776732673;
				if (num != 0)
				{
				}
				num = (short)154730496;
				if (num != 0)
				{
				}
				num = (short)377683968;
				short num3 = num;
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.UIValue;
			}
			set
			{
				short num = (short)1152516097;
				if (num != 0)
				{
				}
				num = (short)1934625138;
				short num2 = num;
				num = (short)245172594;
				switch (num2 == num)
				{
				}
				num = (short)1137246208;
				if (num != 0)
				{
				}
				num = (short)8912896;
				short num3 = num;
				this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.UIValue = value;
			}
		}

		// Token: 0x1700385E RID: 14430
		// (get) Token: 0x06006D03 RID: 27907 RVA: 0x00614FB8 File Offset: 0x006131B8
		// (set) Token: 0x06006D04 RID: 27908 RVA: 0x0061506C File Offset: 0x0061326C
		public string RadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306_HexUIValue
		{
			get
			{
				short num = (short)1850573820;
				short num2 = num;
				num = (short)1165329404;
				switch (num2 == num)
				{
				}
				num = (short)1052639233;
				if (num != 0)
				{
				}
				num = (short)1625161728;
				if (num != 0)
				{
				}
				num = (short)222822400;
				short num3 = num;
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.HexUIValue;
			}
			set
			{
				short num = (short)1131811026;
				short num2 = num;
				num = (short)1442255058;
				switch (num2 == num)
				{
				}
				num = (short)1428946945;
				if (num != 0)
				{
				}
				num = (short)306708480;
				if (num != 0)
				{
				}
				num = (short)576389120;
				short num3 = num;
				this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.HexUIValue = value;
			}
		}

		// Token: 0x1700385F RID: 14431
		// (get) Token: 0x06006D05 RID: 27909 RVA: 0x00615120 File Offset: 0x00613320
		// (set) Token: 0x06006D06 RID: 27910 RVA: 0x006151D4 File Offset: 0x006133D4
		internal int RadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306Min
		{
			get
			{
				short num = (short)151285074;
				short num2 = num;
				num = (short)547908946;
				switch (num2 == num)
				{
				}
				num = (short)766836736;
				if (num != 0)
				{
				}
				num = (short)435814401;
				if (num != 0)
				{
				}
				num = (short)1994260480;
				short num3 = num;
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.Min;
			}
			set
			{
				short num = (short)839460694;
				short num2 = num;
				num = (short)132130646;
				switch (num2 == num)
				{
				}
				num = (short)1759969281;
				if (num != 0)
				{
				}
				num = (short)1286209536;
				if (num != 0)
				{
				}
				num = (short)508493824;
				short num3 = num;
				this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.Min = value;
			}
		}

		// Token: 0x17003860 RID: 14432
		// (get) Token: 0x06006D07 RID: 27911 RVA: 0x0061528C File Offset: 0x0061348C
		// (set) Token: 0x06006D08 RID: 27912 RVA: 0x00615340 File Offset: 0x00613540
		internal int RadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306Max
		{
			get
			{
				short num = (short)434861717;
				short num2 = num;
				num = (short)415725205;
				switch (num2 == num)
				{
				}
				num = (short)471531520;
				if (num != 0)
				{
				}
				num = (short)30998529;
				if (num != 0)
				{
				}
				num = (short)833159168;
				short num3 = num;
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.Max;
			}
			set
			{
				short num = (short)34650407;
				short num2 = num;
				num = (short)1798486311;
				switch (num2 == num)
				{
				}
				num = (short)791478273;
				if (num != 0)
				{
				}
				num = (short)750714880;
				if (num != 0)
				{
				}
				num = (short)753401856;
				short num3 = num;
				this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.Max = value;
			}
		}

		// Token: 0x17003861 RID: 14433
		// (get) Token: 0x06006D09 RID: 27913 RVA: 0x006153F8 File Offset: 0x006135F8
		// (set) Token: 0x06006D0A RID: 27914 RVA: 0x006154B0 File Offset: 0x006136B0
		internal int RadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306Step
		{
			get
			{
				short num = (short)702414849;
				if (num != 0)
				{
				}
				num = (short)2133890727;
				short num2 = num;
				num = (short)1595119271;
				switch (num2 == num)
				{
				}
				num = (short)1038024704;
				if (num != 0)
				{
				}
				num = (short)1512046592;
				short num3 = num;
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.StepSize;
			}
			set
			{
				short num = (short)1935909849;
				short num2 = num;
				num = (short)35300313;
				switch (num2 == num)
				{
				}
				num = (short)1797521409;
				if (num != 0)
				{
				}
				num = (short)191430656;
				if (num != 0)
				{
				}
				num = (short)1012006912;
				short num3 = num;
				this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.StepSize = value;
			}
		}

		// Token: 0x17003862 RID: 14434
		// (get) Token: 0x06006D0B RID: 27915 RVA: 0x00615564 File Offset: 0x00613764
		// (set) Token: 0x06006D0C RID: 27916 RVA: 0x00615618 File Offset: 0x00613818
		public bool RadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306_Applicable
		{
			get
			{
				short num = (short)423028434;
				short num2 = num;
				num = (short)1840244434;
				switch (num2 == num)
				{
				}
				num = (short)1858273281;
				if (num != 0)
				{
				}
				num = (short)270991360;
				if (num != 0)
				{
				}
				num = (short)289800192;
				short num3 = num;
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.Applicable;
			}
			set
			{
				short num = (short)618652133;
				short num2 = num;
				num = (short)1127866853;
				switch (num2 == num)
				{
				}
				num = (short)611647488;
				if (num != 0)
				{
				}
				num = (short)1668087809;
				if (num != 0)
				{
				}
				num = (short)1023934464;
				short num3 = num;
				this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.Applicable = value;
			}
		}

		// Token: 0x17003863 RID: 14435
		// (get) Token: 0x06006D0D RID: 27917 RVA: 0x006156D0 File Offset: 0x006138D0
		// (set) Token: 0x06006D0E RID: 27918 RVA: 0x00615784 File Offset: 0x00613984
		public bool RadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306_Valid
		{
			get
			{
				short num = (short)1553423270;
				short num2 = num;
				num = (short)1720802214;
				switch (num2 == num)
				{
				}
				num = (short)2129592321;
				if (num != 0)
				{
				}
				num = (short)916389888;
				if (num != 0)
				{
				}
				num = (short)1293156352;
				short num3 = num;
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.Valid;
			}
			set
			{
				short num = (short)1744371713;
				if (num != 0)
				{
				}
				num = (short)523654862;
				short num2 = num;
				num = (short)903960270;
				switch (num2 == num)
				{
				}
				num = (short)1698693120;
				if (num != 0)
				{
				}
				num = (short)65536000;
				short num3 = num;
				this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.Valid = value;
			}
		}

		// Token: 0x17003864 RID: 14436
		// (get) Token: 0x06006D0F RID: 27919 RVA: 0x0061583C File Offset: 0x00613A3C
		// (set) Token: 0x06006D10 RID: 27920 RVA: 0x006158F0 File Offset: 0x00613AF0
		public bool RadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306_Visible
		{
			get
			{
				short num = (short)563953796;
				short num2 = num;
				num = (short)379797636;
				switch (num2 == num)
				{
				}
				num = (short)139919360;
				if (num != 0)
				{
				}
				num = (short)1544617985;
				if (num != 0)
				{
				}
				num = (short)183894016;
				short num3 = num;
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.Visible;
			}
			set
			{
				short num = (short)1460259368;
				short num2 = num;
				num = (short)802146856;
				switch (num2 == num)
				{
				}
				num = (short)600834048;
				if (num != 0)
				{
				}
				num = (short)1146617857;
				if (num != 0)
				{
				}
				num = (short)1652686848;
				short num3 = num;
				this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.Visible = value;
			}
		}

		// Token: 0x17003865 RID: 14437
		// (get) Token: 0x06006D11 RID: 27921 RVA: 0x006159A8 File Offset: 0x00613BA8
		// (set) Token: 0x06006D12 RID: 27922 RVA: 0x00615A5C File Offset: 0x00613C5C
		public bool RadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306_Editable
		{
			get
			{
				short num = (short)1442543895;
				short num2 = num;
				num = (short)475429143;
				switch (num2 == num)
				{
				}
				num = (short)1747058689;
				if (num != 0)
				{
				}
				num = (short)1096024064;
				if (num != 0)
				{
				}
				num = (short)668925952;
				short num3 = num;
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.Editable;
			}
			set
			{
				short num = (short)179929545;
				short num2 = num;
				num = (short)1885110729;
				switch (num2 == num)
				{
				}
				num = (short)1742209024;
				if (num != 0)
				{
				}
				num = (short)621936641;
				if (num != 0)
				{
				}
				num = (short)310771712;
				short num3 = num;
				this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.Editable = value;
			}
		}

		// Token: 0x17003866 RID: 14438
		// (get) Token: 0x06006D13 RID: 27923 RVA: 0x00615B10 File Offset: 0x00613D10
		internal string RadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306_UILabel
		{
			get
			{
				short num = (short)1654526534;
				short num2 = num;
				num = (short)1377440326;
				switch (num2 == num)
				{
				}
				num = (short)744226817;
				if (num != 0)
				{
				}
				num = (short)1950810112;
				if (num != 0)
				{
				}
				num = (short)648544256;
				short num3 = num;
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.UIName;
			}
		}

		// Token: 0x17003867 RID: 14439
		// (get) Token: 0x06006D14 RID: 27924 RVA: 0x00615BC4 File Offset: 0x00613DC4
		// (set) Token: 0x06006D15 RID: 27925 RVA: 0x00615C74 File Offset: 0x00613E74
		internal bool RadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306_HiddenStatic
		{
			get
			{
				short num = (short)1027952193;
				short num2 = num;
				num = (short)593710657;
				switch (num2 == num)
				{
				}
				num = (short)2082734081;
				if (num != 0)
				{
				}
				num = (short)2089549824;
				if (num != 0)
				{
				}
				num = (short)868417536;
				short num3 = num;
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.HiddenStatic;
			}
			set
			{
				short num = (short)1215400179;
				short num2 = num;
				num = (short)2030668019;
				switch (num2 == num)
				{
				}
				num = (short)1808924673;
				if (num != 0)
				{
				}
				num = (short)543293440;
				if (num != 0)
				{
				}
				num = (short)1506672640;
				short num3 = num;
				this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.HiddenStatic = value;
			}
		}

		// Token: 0x17003868 RID: 14440
		// (get) Token: 0x06006D16 RID: 27926 RVA: 0x00615D28 File Offset: 0x00613F28
		// (set) Token: 0x06006D17 RID: 27927 RVA: 0x00615DDC File Offset: 0x00613FDC
		internal bool RadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306_HiddenDynamic
		{
			get
			{
				short num = (short)1315989841;
				short num2 = num;
				num = (short)1864001873;
				switch (num2 == num)
				{
				}
				num = (short)615251969;
				if (num != 0)
				{
				}
				num = (short)1540227072;
				if (num != 0)
				{
				}
				num = (short)1941110784;
				short num3 = num;
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.HiddenDynamic;
			}
			set
			{
				short num = (short)758741255;
				short num2 = num;
				num = (short)1807972615;
				switch (num2 == num)
				{
				}
				num = (short)1561329664;
				if (num != 0)
				{
				}
				num = (short)1147469825;
				if (num != 0)
				{
				}
				num = (short)1195245568;
				short num3 = num;
				this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306.HiddenDynamic = value;
			}
		}

		// Token: 0x17003869 RID: 14441
		// (get) Token: 0x06006D18 RID: 27928 RVA: 0x00615E94 File Offset: 0x00614094
		public bool RadErgoCfgGeneralSDIFFTHRESHDBQ8_A22306_HasDiffs
		{
			get
			{
				short num = (short)222428052;
				short num2 = num;
				num = (short)1320418196;
				switch (num2 == num)
				{
				}
				num = (short)53346304;
				if (num != 0)
				{
				}
				num = (short)467206145;
				if (num != 0)
				{
				}
				num = (short)466550784;
				short num3 = num;
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306._HasDiffs;
			}
		}

		// Token: 0x1700386A RID: 14442
		// (get) Token: 0x06006D19 RID: 27929 RVA: 0x00615F48 File Offset: 0x00614148
		// (set) Token: 0x06006D1A RID: 27930 RVA: 0x00616000 File Offset: 0x00614200
		public int RadErgoCfgGeneralVADDETTHRESHDBQ8_A22303Value
		{
			get
			{
				short num = (short)863567643;
				short num2 = num;
				num = (short)2024865563;
				switch (num2 == num)
				{
				}
				num = (short)623640577;
				if (num != 0)
				{
				}
				num = (short)1171718144;
				if (num != 0)
				{
				}
				num = (short)1588396032;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.Value;
			}
			set
			{
				short num = (short)795290855;
				short num2 = num;
				num = (short)568405223;
				switch (num2 == num)
				{
				}
				num = (short)2062155777;
				if (num != 0)
				{
				}
				num = (short)1670381568;
				if (num != 0)
				{
				}
				num = (short)2022375424;
				short num3 = num;
				this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.Value = value;
			}
		}

		// Token: 0x1700386B RID: 14443
		// (get) Token: 0x06006D1B RID: 27931 RVA: 0x006160B4 File Offset: 0x006142B4
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgGeneralVADDETTHRESHDBQ8_A22303
		{
			get
			{
				short num = (short)1446794689;
				short num2 = num;
				num = (short)1238848961;
				switch (num2 == num)
				{
				}
				num = (short)48365568;
				if (num != 0)
				{
				}
				num = (short)1822162945;
				if (num != 0)
				{
				}
				num = (short)140574720;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303;
			}
		}

		// Token: 0x1700386C RID: 14444
		// (get) Token: 0x06006D1C RID: 27932 RVA: 0x00616164 File Offset: 0x00614364
		// (set) Token: 0x06006D1D RID: 27933 RVA: 0x0061621C File Offset: 0x0061441C
		public string RadErgoCfgGeneralVADDETTHRESHDBQ8_A22303_UIValue
		{
			get
			{
				short num = (short)1312744475;
				short num2 = num;
				num = (short)758899739;
				switch (num2 == num)
				{
				}
				num = (short)1174929408;
				if (num != 0)
				{
				}
				num = (short)2050097153;
				if (num != 0)
				{
				}
				num = (short)949288960;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.UIValue;
			}
			set
			{
				short num = (short)38856609;
				short num2 = num;
				num = (short)2142168993;
				switch (num2 == num)
				{
				}
				num = (short)1867972609;
				if (num != 0)
				{
				}
				num = (short)104595456;
				if (num != 0)
				{
				}
				num = (short)501874688;
				short num3 = num;
				this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.UIValue = value;
			}
		}

		// Token: 0x1700386D RID: 14445
		// (get) Token: 0x06006D1E RID: 27934 RVA: 0x006162D4 File Offset: 0x006144D4
		// (set) Token: 0x06006D1F RID: 27935 RVA: 0x00616388 File Offset: 0x00614588
		public string RadErgoCfgGeneralVADDETTHRESHDBQ8_A22303_HexUIValue
		{
			get
			{
				short num = (short)1023213569;
				if (num != 0)
				{
				}
				num = (short)1051670892;
				short num2 = num;
				num = (short)1890662764;
				switch (num2 == num)
				{
				}
				num = (short)762904576;
				if (num != 0)
				{
				}
				num = (short)1826947072;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.HexUIValue;
			}
			set
			{
				short num = (short)763191330;
				short num2 = num;
				num = (short)110387234;
				switch (num2 == num)
				{
				}
				num = (short)1064632321;
				if (num != 0)
				{
				}
				num = (short)857669632;
				if (num != 0)
				{
				}
				num = (short)1722548224;
				short num3 = num;
				this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.HexUIValue = value;
			}
		}

		// Token: 0x1700386E RID: 14446
		// (get) Token: 0x06006D20 RID: 27936 RVA: 0x0061643C File Offset: 0x0061463C
		// (set) Token: 0x06006D21 RID: 27937 RVA: 0x006164F0 File Offset: 0x006146F0
		internal int RadErgoCfgGeneralVADDETTHRESHDBQ8_A22303Min
		{
			get
			{
				short num = (short)700948726;
				short num2 = num;
				num = (short)1157341430;
				switch (num2 == num)
				{
				}
				num = (short)1129185281;
				if (num != 0)
				{
				}
				num = (short)1135476736;
				if (num != 0)
				{
				}
				num = (short)233701376;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.Min;
			}
			set
			{
				short num = (short)466651978;
				short num2 = num;
				num = (short)1932757834;
				switch (num2 == num)
				{
				}
				num = (short)107282433;
				if (num != 0)
				{
				}
				num = (short)1339228160;
				if (num != 0)
				{
				}
				num = (short)379191296;
				short num3 = num;
				this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.Min = value;
			}
		}

		// Token: 0x1700386F RID: 14447
		// (get) Token: 0x06006D22 RID: 27938 RVA: 0x006165A8 File Offset: 0x006147A8
		// (set) Token: 0x06006D23 RID: 27939 RVA: 0x0061665C File Offset: 0x0061485C
		internal int RadErgoCfgGeneralVADDETTHRESHDBQ8_A22303Max
		{
			get
			{
				short num = (short)1274477258;
				short num2 = num;
				num = (short)914356938;
				switch (num2 == num)
				{
				}
				num = (short)1905065985;
				if (num != 0)
				{
				}
				num = (short)1512767488;
				if (num != 0)
				{
				}
				num = (short)1658912768;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.Max;
			}
			set
			{
				short num = (short)31192307;
				short num2 = num;
				num = (short)1498674419;
				switch (num2 == num)
				{
				}
				num = (short)145817600;
				if (num != 0)
				{
				}
				num = (short)1686896641;
				if (num != 0)
				{
				}
				num = (short)1421475840;
				short num3 = num;
				this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.Max = value;
			}
		}

		// Token: 0x17003870 RID: 14448
		// (get) Token: 0x06006D24 RID: 27940 RVA: 0x00616714 File Offset: 0x00614914
		// (set) Token: 0x06006D25 RID: 27941 RVA: 0x006167C8 File Offset: 0x006149C8
		internal int RadErgoCfgGeneralVADDETTHRESHDBQ8_A22303Step
		{
			get
			{
				short num = (short)867837582;
				short num2 = num;
				num = (short)2085955214;
				switch (num2 == num)
				{
				}
				num = (short)1955266561;
				if (num != 0)
				{
				}
				num = (short)1302396928;
				if (num != 0)
				{
				}
				num = (short)1992163328;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.StepSize;
			}
			set
			{
				short num = (short)856783831;
				short num2 = num;
				num = (short)1123187671;
				switch (num2 == num)
				{
				}
				num = (short)677052417;
				if (num != 0)
				{
				}
				num = (short)1574502400;
				if (num != 0)
				{
				}
				num = (short)1855848448;
				short num3 = num;
				this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.StepSize = value;
			}
		}

		// Token: 0x17003871 RID: 14449
		// (get) Token: 0x06006D26 RID: 27942 RVA: 0x00616880 File Offset: 0x00614A80
		// (set) Token: 0x06006D27 RID: 27943 RVA: 0x00616938 File Offset: 0x00614B38
		public bool RadErgoCfgGeneralVADDETTHRESHDBQ8_A22303_Applicable
		{
			get
			{
				short num = (short)652624736;
				short num2 = num;
				num = (short)487670624;
				switch (num2 == num)
				{
				}
				num = (short)322306048;
				if (num != 0)
				{
				}
				num = (short)1086390273;
				if (num != 0)
				{
				}
				num = (short)198770688;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.Applicable;
			}
			set
			{
				short num = (short)1010623855;
				short num2 = num;
				num = (short)86238575;
				switch (num2 == num)
				{
				}
				num = (short)2046230529;
				if (num != 0)
				{
				}
				num = (short)1633681408;
				if (num != 0)
				{
				}
				num = (short)697368576;
				short num3 = num;
				this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.Applicable = value;
			}
		}

		// Token: 0x17003872 RID: 14450
		// (get) Token: 0x06006D28 RID: 27944 RVA: 0x006169EC File Offset: 0x00614BEC
		// (set) Token: 0x06006D29 RID: 27945 RVA: 0x00616AA4 File Offset: 0x00614CA4
		public bool RadErgoCfgGeneralVADDETTHRESHDBQ8_A22303_Valid
		{
			get
			{
				short num = (short)1240418564;
				short num2 = num;
				num = (short)1959610628;
				switch (num2 == num)
				{
				}
				num = (short)178454529;
				if (num != 0)
				{
				}
				num = (short)1454047232;
				if (num != 0)
				{
				}
				num = (short)204668928;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.Valid;
			}
			set
			{
				short num = (short)1864916295;
				short num2 = num;
				num = (short)330587463;
				switch (num2 == num)
				{
				}
				num = (short)942735360;
				if (num != 0)
				{
				}
				num = (short)2130575361;
				if (num != 0)
				{
				}
				num = (short)1421279232;
				short num3 = num;
				this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.Valid = value;
			}
		}

		// Token: 0x17003873 RID: 14451
		// (get) Token: 0x06006D2A RID: 27946 RVA: 0x00616B58 File Offset: 0x00614D58
		// (set) Token: 0x06006D2B RID: 27947 RVA: 0x00616C0C File Offset: 0x00614E0C
		public bool RadErgoCfgGeneralVADDETTHRESHDBQ8_A22303_Visible
		{
			get
			{
				short num = (short)1389142749;
				short num2 = num;
				num = (short)1656857309;
				switch (num2 == num)
				{
				}
				num = (short)1897332737;
				if (num != 0)
				{
				}
				num = (short)277544960;
				if (num != 0)
				{
				}
				num = (short)1840840704;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.Visible;
			}
			set
			{
				short num = (short)563745135;
				short num2 = num;
				num = (short)345641327;
				switch (num2 == num)
				{
				}
				num = (short)1550516225;
				if (num != 0)
				{
				}
				num = (short)1206452224;
				if (num != 0)
				{
				}
				num = (short)882769920;
				short num3 = num;
				this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.Visible = value;
			}
		}

		// Token: 0x17003874 RID: 14452
		// (get) Token: 0x06006D2C RID: 27948 RVA: 0x00616CC4 File Offset: 0x00614EC4
		// (set) Token: 0x06006D2D RID: 27949 RVA: 0x00616D7C File Offset: 0x00614F7C
		public bool RadErgoCfgGeneralVADDETTHRESHDBQ8_A22303_Editable
		{
			get
			{
				short num = (short)2068651405;
				short num2 = num;
				num = (short)640359821;
				switch (num2 == num)
				{
				}
				num = (short)259129344;
				if (num != 0)
				{
				}
				num = (short)1715535873;
				if (num != 0)
				{
				}
				num = (short)1709375488;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.Editable;
			}
			set
			{
				short num = (short)511646082;
				short num2 = num;
				num = (short)2070157698;
				switch (num2 == num)
				{
				}
				num = (short)636682240;
				if (num != 0)
				{
				}
				num = (short)1300299777;
				if (num != 0)
				{
				}
				num = (short)2065760256;
				short num3 = num;
				this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.Editable = value;
			}
		}

		// Token: 0x17003875 RID: 14453
		// (get) Token: 0x06006D2E RID: 27950 RVA: 0x00616E34 File Offset: 0x00615034
		internal string RadErgoCfgGeneralVADDETTHRESHDBQ8_A22303_UILabel
		{
			get
			{
				short num = (short)1871986533;
				short num2 = num;
				num = (short)1678851941;
				switch (num2 == num)
				{
				}
				num = (short)1638924289;
				if (num != 0)
				{
				}
				num = (short)1546518528;
				if (num != 0)
				{
				}
				num = (short)1613561856;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.UIName;
			}
		}

		// Token: 0x17003876 RID: 14454
		// (get) Token: 0x06006D2F RID: 27951 RVA: 0x00616EE8 File Offset: 0x006150E8
		// (set) Token: 0x06006D30 RID: 27952 RVA: 0x00616F9C File Offset: 0x0061519C
		internal bool RadErgoCfgGeneralVADDETTHRESHDBQ8_A22303_HiddenStatic
		{
			get
			{
				short num = (short)874635068;
				short num2 = num;
				num = (short)2032787260;
				switch (num2 == num)
				{
				}
				num = (short)480313345;
				if (num != 0)
				{
				}
				num = (short)1234894848;
				if (num != 0)
				{
				}
				num = (short)191758336;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.HiddenStatic;
			}
			set
			{
				short num = (short)756801348;
				short num2 = num;
				num = (short)1837621060;
				switch (num2 == num)
				{
				}
				num = (short)65667073;
				if (num != 0)
				{
				}
				num = (short)1376845824;
				if (num != 0)
				{
				}
				num = (short)735641600;
				short num3 = num;
				this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.HiddenStatic = value;
			}
		}

		// Token: 0x17003877 RID: 14455
		// (get) Token: 0x06006D31 RID: 27953 RVA: 0x00617050 File Offset: 0x00615250
		// (set) Token: 0x06006D32 RID: 27954 RVA: 0x00617104 File Offset: 0x00615304
		internal bool RadErgoCfgGeneralVADDETTHRESHDBQ8_A22303_HiddenDynamic
		{
			get
			{
				short num = (short)1900826597;
				short num2 = num;
				num = (short)428363749;
				switch (num2 == num)
				{
				}
				num = (short)300679169;
				if (num != 0)
				{
				}
				num = (short)1080688640;
				if (num != 0)
				{
				}
				num = (short)108199936;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.HiddenDynamic;
			}
			set
			{
				short num = (short)1264304505;
				short num2 = num;
				num = (short)630505849;
				switch (num2 == num)
				{
				}
				num = (short)1289551872;
				if (num != 0)
				{
				}
				num = (short)1003487233;
				if (num != 0)
				{
				}
				num = (short)1870069760;
				short num3 = num;
				this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303.HiddenDynamic = value;
			}
		}

		// Token: 0x17003878 RID: 14456
		// (get) Token: 0x06006D33 RID: 27955 RVA: 0x006171BC File Offset: 0x006153BC
		public bool RadErgoCfgGeneralVADDETTHRESHDBQ8_A22303_HasDiffs
		{
			get
			{
				short num = (short)1709927548;
				short num2 = num;
				num = (short)1899129980;
				switch (num2 == num)
				{
				}
				num = (short)1109786624;
				if (num != 0)
				{
				}
				num = (short)306053121;
				if (num != 0)
				{
				}
				num = (short)788201472;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A22303._HasDiffs;
			}
		}

		// Token: 0x17003879 RID: 14457
		// (get) Token: 0x06006D34 RID: 27956 RVA: 0x00617270 File Offset: 0x00615470
		// (set) Token: 0x06006D35 RID: 27957 RVA: 0x00617324 File Offset: 0x00615524
		public int RadErgoCfgGeneralVADDETCOUNT_A22304Value
		{
			get
			{
				short num = (short)372363785;
				short num2 = num;
				num = (short)1725551113;
				switch (num2 == num)
				{
				}
				num = (short)1910112256;
				if (num != 0)
				{
				}
				num = (short)617676801;
				if (num != 0)
				{
				}
				num = (short)2131361792;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A22304.Value;
			}
			set
			{
				short num = (short)1626943785;
				short num2 = num;
				num = (short)1033580841;
				switch (num2 == num)
				{
				}
				num = (short)1919090688;
				if (num != 0)
				{
				}
				num = (short)1954480129;
				if (num != 0)
				{
				}
				num = (short)455409664;
				short num3 = num;
				this.radErgoCfgGeneralVADDETCOUNT_A22304.Value = value;
			}
		}

		// Token: 0x1700387A RID: 14458
		// (get) Token: 0x06006D36 RID: 27958 RVA: 0x006173D8 File Offset: 0x006155D8
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgGeneralVADDETCOUNT_A22304
		{
			get
			{
				short num = (short)1533240449;
				short num2 = num;
				num = (short)672687233;
				switch (num2 == num)
				{
				}
				num = (short)1625358337;
				if (num != 0)
				{
				}
				num = (short)1201209344;
				if (num != 0)
				{
				}
				num = (short)1330184192;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A22304;
			}
		}

		// Token: 0x1700387B RID: 14459
		// (get) Token: 0x06006D37 RID: 27959 RVA: 0x00617488 File Offset: 0x00615688
		// (set) Token: 0x06006D38 RID: 27960 RVA: 0x00617540 File Offset: 0x00615740
		public string RadErgoCfgGeneralVADDETCOUNT_A22304_UIValue
		{
			get
			{
				short num = (short)698377686;
				short num2 = num;
				num = (short)1231840726;
				switch (num2 == num)
				{
				}
				num = (short)1272381441;
				if (num != 0)
				{
				}
				num = (short)1217396736;
				if (num != 0)
				{
				}
				num = (short)1943076864;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A22304.UIValue;
			}
			set
			{
				short num = (short)520093697;
				if (num != 0)
				{
				}
				num = (short)89227684;
				short num2 = num;
				num = (short)397574564;
				switch (num2 == num)
				{
				}
				num = (short)1663631360;
				if (num != 0)
				{
				}
				num = (short)2043346944;
				short num3 = num;
				this.radErgoCfgGeneralVADDETCOUNT_A22304.UIValue = value;
			}
		}

		// Token: 0x1700387C RID: 14460
		// (get) Token: 0x06006D39 RID: 27961 RVA: 0x006175F8 File Offset: 0x006157F8
		// (set) Token: 0x06006D3A RID: 27962 RVA: 0x006176AC File Offset: 0x006158AC
		public string RadErgoCfgGeneralVADDETCOUNT_A22304_HexUIValue
		{
			get
			{
				short num = (short)148832257;
				if (num != 0)
				{
				}
				num = (short)1866240106;
				short num2 = num;
				num = (short)1223987306;
				switch (num2 == num)
				{
				}
				num = (short)1883373568;
				if (num != 0)
				{
				}
				num = (short)231669760;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A22304.HexUIValue;
			}
			set
			{
				short num = (short)444565608;
				short num2 = num;
				num = (short)1420920936;
				switch (num2 == num)
				{
				}
				num = (short)1578172417;
				if (num != 0)
				{
				}
				num = (short)948174848;
				if (num != 0)
				{
				}
				num = (short)160890880;
				short num3 = num;
				this.radErgoCfgGeneralVADDETCOUNT_A22304.HexUIValue = value;
			}
		}

		// Token: 0x1700387D RID: 14461
		// (get) Token: 0x06006D3B RID: 27963 RVA: 0x00617764 File Offset: 0x00615964
		// (set) Token: 0x06006D3C RID: 27964 RVA: 0x0061781C File Offset: 0x00615A1C
		internal int RadErgoCfgGeneralVADDETCOUNT_A22304Min
		{
			get
			{
				short num = (short)1563890102;
				short num2 = num;
				num = (short)604836278;
				switch (num2 == num)
				{
				}
				num = (short)1677131777;
				if (num != 0)
				{
				}
				num = (short)76677120;
				if (num != 0)
				{
				}
				num = (short)1475346432;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A22304.Min;
			}
			set
			{
				short num = (short)1456881771;
				short num2 = num;
				num = (short)1953513579;
				switch (num2 == num)
				{
				}
				num = (short)860684289;
				if (num != 0)
				{
				}
				num = (short)1323565056;
				if (num != 0)
				{
				}
				num = (short)461766656;
				short num3 = num;
				this.radErgoCfgGeneralVADDETCOUNT_A22304.Min = value;
			}
		}

		// Token: 0x1700387E RID: 14462
		// (get) Token: 0x06006D3D RID: 27965 RVA: 0x006178D4 File Offset: 0x00615AD4
		// (set) Token: 0x06006D3E RID: 27966 RVA: 0x00617988 File Offset: 0x00615B88
		internal int RadErgoCfgGeneralVADDETCOUNT_A22304Max
		{
			get
			{
				short num = (short)270913940;
				short num2 = num;
				num = (short)331731348;
				switch (num2 == num)
				{
				}
				num = (short)282853377;
				if (num != 0)
				{
				}
				num = (short)165675008;
				if (num != 0)
				{
				}
				num = (short)99614720;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A22304.Max;
			}
			set
			{
				short num = (short)319984250;
				short num2 = num;
				num = (short)953062010;
				switch (num2 == num)
				{
				}
				num = (short)1678442496;
				if (num != 0)
				{
				}
				num = (short)1838612481;
				if (num != 0)
				{
				}
				num = (short)308412416;
				short num3 = num;
				this.radErgoCfgGeneralVADDETCOUNT_A22304.Max = value;
			}
		}

		// Token: 0x1700387F RID: 14463
		// (get) Token: 0x06006D3F RID: 27967 RVA: 0x00617A3C File Offset: 0x00615C3C
		// (set) Token: 0x06006D40 RID: 27968 RVA: 0x00617AF4 File Offset: 0x00615CF4
		internal int RadErgoCfgGeneralVADDETCOUNT_A22304Step
		{
			get
			{
				short num = (short)2026962945;
				if (num != 0)
				{
				}
				num = (short)763613573;
				short num2 = num;
				num = (short)1673384325;
				switch (num2 == num)
				{
				}
				num = (short)1376059392;
				if (num != 0)
				{
				}
				num = (short)371392512;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A22304.StepSize;
			}
			set
			{
				short num = (short)111411201;
				if (num != 0)
				{
				}
				num = (short)1843420475;
				short num2 = num;
				num = (short)1004821819;
				switch (num2 == num)
				{
				}
				num = (short)917504000;
				if (num != 0)
				{
				}
				num = (short)917569536;
				short num3 = num;
				this.radErgoCfgGeneralVADDETCOUNT_A22304.StepSize = value;
			}
		}

		// Token: 0x17003880 RID: 14464
		// (get) Token: 0x06006D41 RID: 27969 RVA: 0x00617BA8 File Offset: 0x00615DA8
		// (set) Token: 0x06006D42 RID: 27970 RVA: 0x00617C5C File Offset: 0x00615E5C
		public bool RadErgoCfgGeneralVADDETCOUNT_A22304_Applicable
		{
			get
			{
				short num = (short)1628193719;
				short num2 = num;
				num = (short)709247927;
				switch (num2 == num)
				{
				}
				num = (short)1656160257;
				if (num != 0)
				{
				}
				num = (short)680525824;
				if (num != 0)
				{
				}
				num = (short)9895936;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A22304.Applicable;
			}
			set
			{
				short num = (short)363283932;
				short num2 = num;
				num = (short)65553884;
				switch (num2 == num)
				{
				}
				num = (short)711000064;
				if (num != 0)
				{
				}
				num = (short)1085472769;
				if (num != 0)
				{
				}
				num = (short)856817664;
				short num3 = num;
				this.radErgoCfgGeneralVADDETCOUNT_A22304.Applicable = value;
			}
		}

		// Token: 0x17003881 RID: 14465
		// (get) Token: 0x06006D43 RID: 27971 RVA: 0x00617D10 File Offset: 0x00615F10
		// (set) Token: 0x06006D44 RID: 27972 RVA: 0x00617DC4 File Offset: 0x00615FC4
		public bool RadErgoCfgGeneralVADDETCOUNT_A22304_Valid
		{
			get
			{
				short num = (short)156303361;
				if (num != 0)
				{
				}
				num = (short)262035099;
				short num2 = num;
				num = (short)999577243;
				switch (num2 == num)
				{
				}
				num = (short)8519680;
				if (num != 0)
				{
				}
				num = (short)641335296;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A22304.Valid;
			}
			set
			{
				short num = (short)1873961179;
				short num2 = num;
				num = (short)861036763;
				switch (num2 == num)
				{
				}
				num = (short)969998337;
				if (num != 0)
				{
				}
				num = (short)749338624;
				if (num != 0)
				{
				}
				num = (short)2012151808;
				short num3 = num;
				this.radErgoCfgGeneralVADDETCOUNT_A22304.Valid = value;
			}
		}

		// Token: 0x17003882 RID: 14466
		// (get) Token: 0x06006D45 RID: 27973 RVA: 0x00617E78 File Offset: 0x00616078
		// (set) Token: 0x06006D46 RID: 27974 RVA: 0x00617F2C File Offset: 0x0061612C
		public bool RadErgoCfgGeneralVADDETCOUNT_A22304_Visible
		{
			get
			{
				short num = (short)800023003;
				short num2 = num;
				num = (short)2068799963;
				switch (num2 == num)
				{
				}
				num = (short)1991573505;
				if (num != 0)
				{
				}
				num = (short)13238272;
				if (num != 0)
				{
				}
				num = (short)1978597376;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A22304.Visible;
			}
			set
			{
				short num = (short)709499381;
				short num2 = num;
				num = (short)862984693;
				switch (num2 == num)
				{
				}
				num = (short)520290305;
				if (num != 0)
				{
				}
				num = (short)775487488;
				if (num != 0)
				{
				}
				num = (short)846528512;
				short num3 = num;
				this.radErgoCfgGeneralVADDETCOUNT_A22304.Visible = value;
			}
		}

		// Token: 0x17003883 RID: 14467
		// (get) Token: 0x06006D47 RID: 27975 RVA: 0x00617FE0 File Offset: 0x006161E0
		// (set) Token: 0x06006D48 RID: 27976 RVA: 0x00618094 File Offset: 0x00616294
		public bool RadErgoCfgGeneralVADDETCOUNT_A22304_Editable
		{
			get
			{
				short num = (short)1314999889;
				short num2 = num;
				num = (short)2047168081;
				switch (num2 == num)
				{
				}
				num = (short)1058209793;
				if (num != 0)
				{
				}
				num = (short)408682496;
				if (num != 0)
				{
				}
				num = (short)207880192;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A22304.Editable;
			}
			set
			{
				short num = (short)1476801975;
				short num2 = num;
				num = (short)665662903;
				switch (num2 == num)
				{
				}
				num = (short)2061238272;
				if (num != 0)
				{
				}
				num = (short)1968635905;
				if (num != 0)
				{
				}
				num = (short)923664384;
				short num3 = num;
				this.radErgoCfgGeneralVADDETCOUNT_A22304.Editable = value;
			}
		}

		// Token: 0x17003884 RID: 14468
		// (get) Token: 0x06006D49 RID: 27977 RVA: 0x00618148 File Offset: 0x00616348
		internal string RadErgoCfgGeneralVADDETCOUNT_A22304_UILabel
		{
			get
			{
				short num = (short)223321178;
				short num2 = num;
				num = (short)1898486874;
				switch (num2 == num)
				{
				}
				num = (short)1172832257;
				if (num != 0)
				{
				}
				num = (short)1082458112;
				if (num != 0)
				{
				}
				num = (short)304087040;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A22304.UIName;
			}
		}

		// Token: 0x17003885 RID: 14469
		// (get) Token: 0x06006D4A RID: 27978 RVA: 0x00618200 File Offset: 0x00616400
		// (set) Token: 0x06006D4B RID: 27979 RVA: 0x006182B4 File Offset: 0x006164B4
		internal bool RadErgoCfgGeneralVADDETCOUNT_A22304_HiddenStatic
		{
			get
			{
				short num = (short)1185728834;
				short num2 = num;
				num = (short)1924385090;
				switch (num2 == num)
				{
				}
				num = (short)1971519488;
				if (num != 0)
				{
				}
				num = (short)1930297345;
				if (num != 0)
				{
				}
				num = (short)1879965696;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A22304.HiddenStatic;
			}
			set
			{
				short num = (short)516944122;
				short num2 = num;
				num = (short)684781818;
				switch (num2 == num)
				{
				}
				num = (short)1163460609;
				if (num != 0)
				{
				}
				num = (short)178716672;
				if (num != 0)
				{
				}
				num = (short)1157496832;
				short num3 = num;
				this.radErgoCfgGeneralVADDETCOUNT_A22304.HiddenStatic = value;
			}
		}

		// Token: 0x17003886 RID: 14470
		// (get) Token: 0x06006D4C RID: 27980 RVA: 0x00618368 File Offset: 0x00616568
		// (set) Token: 0x06006D4D RID: 27981 RVA: 0x0061841C File Offset: 0x0061661C
		internal bool RadErgoCfgGeneralVADDETCOUNT_A22304_HiddenDynamic
		{
			get
			{
				short num = (short)1283909141;
				short num2 = num;
				num = (short)166258197;
				switch (num2 == num)
				{
				}
				num = (short)359727105;
				if (num != 0)
				{
				}
				num = (short)920977408;
				if (num != 0)
				{
				}
				num = (short)772407296;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A22304.HiddenDynamic;
			}
			set
			{
				short num = (short)1827930113;
				if (num != 0)
				{
				}
				num = (short)985487329;
				short num2 = num;
				num = (short)2072074209;
				switch (num2 == num)
				{
				}
				num = (short)1120075776;
				if (num != 0)
				{
				}
				num = (short)675479552;
				short num3 = num;
				this.radErgoCfgGeneralVADDETCOUNT_A22304.HiddenDynamic = value;
			}
		}

		// Token: 0x17003887 RID: 14471
		// (get) Token: 0x06006D4E RID: 27982 RVA: 0x006184D4 File Offset: 0x006166D4
		public bool RadErgoCfgGeneralVADDETCOUNT_A22304_HasDiffs
		{
			get
			{
				short num = (short)2058247034;
				short num2 = num;
				num = (short)1693866874;
				switch (num2 == num)
				{
				}
				num = (short)1074790401;
				if (num != 0)
				{
				}
				num = (short)510525440;
				if (num != 0)
				{
				}
				num = (short)1414791168;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A22304._HasDiffs;
			}
		}

		// Token: 0x17003888 RID: 14472
		// (get) Token: 0x06006D4F RID: 27983 RVA: 0x0061858C File Offset: 0x0061678C
		// (set) Token: 0x06006D50 RID: 27984 RVA: 0x00618640 File Offset: 0x00616840
		public int RadErgoCfgGeneralMINGAIN_A22298Value
		{
			get
			{
				short num = (short)570359809;
				if (num != 0)
				{
				}
				num = (short)840950289;
				short num2 = num;
				num = (short)1038279185;
				switch (num2 == num)
				{
				}
				num = (short)1564606464;
				if (num != 0)
				{
				}
				num = (short)1740439552;
				short num3 = num;
				return this.radErgoCfgGeneralMINGAIN_A22298.Value;
			}
			set
			{
				short num = (short)2007171073;
				if (num != 0)
				{
				}
				num = (short)1734655926;
				short num2 = num;
				num = (short)1671610294;
				switch (num2 == num)
				{
				}
				num = (short)1564278784;
				if (num != 0)
				{
				}
				num = (short)1742405632;
				short num3 = num;
				this.radErgoCfgGeneralMINGAIN_A22298.Value = value;
			}
		}

		// Token: 0x17003889 RID: 14473
		// (get) Token: 0x06006D51 RID: 27985 RVA: 0x006186F8 File Offset: 0x006168F8
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgGeneralMINGAIN_A22298
		{
			get
			{
				short num = (short)1351568811;
				short num2 = num;
				num = (short)2138721707;
				switch (num2 == num)
				{
				}
				num = (short)830210048;
				if (num != 0)
				{
				}
				num = (short)1032388609;
				if (num != 0)
				{
				}
				num = (short)1684406272;
				short num3 = num;
				return this.radErgoCfgGeneralMINGAIN_A22298;
			}
		}

		// Token: 0x1700388A RID: 14474
		// (get) Token: 0x06006D52 RID: 27986 RVA: 0x006187A4 File Offset: 0x006169A4
		// (set) Token: 0x06006D53 RID: 27987 RVA: 0x0061885C File Offset: 0x00616A5C
		public string RadErgoCfgGeneralMINGAIN_A22298_UIValue
		{
			get
			{
				short num = (short)1187018365;
				short num2 = num;
				num = (short)684095101;
				switch (num2 == num)
				{
				}
				num = (short)1001259009;
				if (num != 0)
				{
				}
				num = (short)1737162752;
				if (num != 0)
				{
				}
				num = (short)906493952;
				short num3 = num;
				return this.radErgoCfgGeneralMINGAIN_A22298.UIValue;
			}
			set
			{
				short num = (short)1594332213;
				short num2 = num;
				num = (short)213750837;
				switch (num2 == num)
				{
				}
				num = (short)1092616192;
				if (num != 0)
				{
				}
				num = (short)1930559489;
				if (num != 0)
				{
				}
				num = (short)1166344192;
				short num3 = num;
				this.radErgoCfgGeneralMINGAIN_A22298.UIValue = value;
			}
		}

		// Token: 0x1700388B RID: 14475
		// (get) Token: 0x06006D54 RID: 27988 RVA: 0x00618910 File Offset: 0x00616B10
		// (set) Token: 0x06006D55 RID: 27989 RVA: 0x006189C4 File Offset: 0x00616BC4
		public string RadErgoCfgGeneralMINGAIN_A22298_HexUIValue
		{
			get
			{
				short num = (short)1074538023;
				short num2 = num;
				num = (short)17245735;
				switch (num2 == num)
				{
				}
				num = (short)1152385024;
				if (num != 0)
				{
				}
				num = (short)239206401;
				if (num != 0)
				{
				}
				num = (short)146407424;
				short num3 = num;
				return this.radErgoCfgGeneralMINGAIN_A22298.HexUIValue;
			}
			set
			{
				short num = (short)113954032;
				short num2 = num;
				num = (short)693816560;
				switch (num2 == num)
				{
				}
				num = (short)2136932353;
				if (num != 0)
				{
				}
				num = (short)1389297664;
				if (num != 0)
				{
				}
				num = (short)2042298368;
				short num3 = num;
				this.radErgoCfgGeneralMINGAIN_A22298.HexUIValue = value;
			}
		}

		// Token: 0x1700388C RID: 14476
		// (get) Token: 0x06006D56 RID: 27990 RVA: 0x00618A78 File Offset: 0x00616C78
		// (set) Token: 0x06006D57 RID: 27991 RVA: 0x00618B2C File Offset: 0x00616D2C
		internal int RadErgoCfgGeneralMINGAIN_A22298Min
		{
			get
			{
				short num = (short)1207668248;
				short num2 = num;
				num = (short)1556450840;
				switch (num2 == num)
				{
				}
				num = (short)371064833;
				if (num != 0)
				{
				}
				num = (short)262471680;
				if (num != 0)
				{
				}
				num = (short)672202752;
				short num3 = num;
				return this.radErgoCfgGeneralMINGAIN_A22298.Min;
			}
			set
			{
				short num = (short)1801875404;
				short num2 = num;
				num = (short)1721462732;
				switch (num2 == num)
				{
				}
				num = (short)743243777;
				if (num != 0)
				{
				}
				num = (short)1420427264;
				if (num != 0)
				{
				}
				num = (short)1145110528;
				short num3 = num;
				this.radErgoCfgGeneralMINGAIN_A22298.Min = value;
			}
		}

		// Token: 0x1700388D RID: 14477
		// (get) Token: 0x06006D58 RID: 27992 RVA: 0x00618BE0 File Offset: 0x00616DE0
		// (set) Token: 0x06006D59 RID: 27993 RVA: 0x00618C94 File Offset: 0x00616E94
		internal int RadErgoCfgGeneralMINGAIN_A22298Max
		{
			get
			{
				short num = (short)1476732617;
				short num2 = num;
				num = (short)877930185;
				switch (num2 == num)
				{
				}
				num = (short)1754988545;
				if (num != 0)
				{
				}
				num = (short)1158479872;
				if (num != 0)
				{
				}
				num = (short)1485963264;
				short num3 = num;
				return this.radErgoCfgGeneralMINGAIN_A22298.Max;
			}
			set
			{
				short num = (short)943101171;
				short num2 = num;
				num = (short)1237292275;
				switch (num2 == num)
				{
				}
				num = (short)2068578304;
				if (num != 0)
				{
				}
				num = (short)851902465;
				if (num != 0)
				{
				}
				num = (short)12320768;
				short num3 = num;
				this.radErgoCfgGeneralMINGAIN_A22298.Max = value;
			}
		}

		// Token: 0x1700388E RID: 14478
		// (get) Token: 0x06006D5A RID: 27994 RVA: 0x00618D4C File Offset: 0x00616F4C
		// (set) Token: 0x06006D5B RID: 27995 RVA: 0x00618E04 File Offset: 0x00617004
		internal int RadErgoCfgGeneralMINGAIN_A22298Step
		{
			get
			{
				short num = (short)604205902;
				short num2 = num;
				num = (short)1889563470;
				switch (num2 == num)
				{
				}
				num = (short)1058930689;
				if (num != 0)
				{
				}
				num = (short)526647296;
				if (num != 0)
				{
				}
				num = (short)1066008576;
				short num3 = num;
				return this.radErgoCfgGeneralMINGAIN_A22298.StepSize;
			}
			set
			{
				short num = (short)2092209700;
				short num2 = num;
				num = (short)218732068;
				switch (num2 == num)
				{
				}
				num = (short)1256194049;
				if (num != 0)
				{
				}
				num = (short)452657152;
				if (num != 0)
				{
				}
				num = (short)2145386496;
				short num3 = num;
				this.radErgoCfgGeneralMINGAIN_A22298.StepSize = value;
			}
		}

		// Token: 0x1700388F RID: 14479
		// (get) Token: 0x06006D5C RID: 27996 RVA: 0x00618EBC File Offset: 0x006170BC
		// (set) Token: 0x06006D5D RID: 27997 RVA: 0x00618F70 File Offset: 0x00617170
		public bool RadErgoCfgGeneralMINGAIN_A22298_Applicable
		{
			get
			{
				short num = (short)1166868481;
				if (num != 0)
				{
				}
				num = (short)108917614;
				short num2 = num;
				num = (short)751891310;
				switch (num2 == num)
				{
				}
				num = (short)1224540160;
				if (num != 0)
				{
				}
				num = (short)1054605312;
				short num3 = num;
				return this.radErgoCfgGeneralMINGAIN_A22298.Applicable;
			}
			set
			{
				short num = (short)123482538;
				short num2 = num;
				num = (short)1433350570;
				switch (num2 == num)
				{
				}
				num = (short)2012872705;
				if (num != 0)
				{
				}
				num = (short)1149698048;
				if (num != 0)
				{
				}
				num = (short)780075008;
				short num3 = num;
				this.radErgoCfgGeneralMINGAIN_A22298.Applicable = value;
			}
		}

		// Token: 0x17003890 RID: 14480
		// (get) Token: 0x06006D5E RID: 27998 RVA: 0x00619028 File Offset: 0x00617228
		// (set) Token: 0x06006D5F RID: 27999 RVA: 0x006190E4 File Offset: 0x006172E4
		public bool RadErgoCfgGeneralMINGAIN_A22298_Valid
		{
			get
			{
				short num = (short)2075436292;
				short num2 = num;
				num = (short)472491268;
				switch (num2 == num)
				{
				}
				num = (short)1008009216;
				if (num != 0)
				{
				}
				num = (short)25690113;
				if (num != 0)
				{
				}
				num = (short)2108358656;
				short num3 = num;
				return this.radErgoCfgGeneralMINGAIN_A22298.Valid;
			}
			set
			{
				short num = (short)1744074607;
				short num2 = num;
				num = (short)229209967;
				switch (num2 == num)
				{
				}
				num = (short)1664548865;
				if (num != 0)
				{
				}
				num = (short)677511168;
				if (num != 0)
				{
				}
				num = (short)2075459584;
				short num3 = num;
				this.radErgoCfgGeneralMINGAIN_A22298.Valid = value;
			}
		}

		// Token: 0x17003891 RID: 14481
		// (get) Token: 0x06006D60 RID: 28000 RVA: 0x00619198 File Offset: 0x00617398
		// (set) Token: 0x06006D61 RID: 28001 RVA: 0x0061924C File Offset: 0x0061744C
		public bool RadErgoCfgGeneralMINGAIN_A22298_Visible
		{
			get
			{
				short num = (short)1667760128;
				short num2 = num;
				num = (short)825936589;
				short num3 = num;
				num = (short)380750541;
				switch (num3 == num)
				{
				}
				num = (short)1183973376;
				if (num != 0)
				{
				}
				num = (short)2144665601;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMINGAIN_A22298.Visible;
			}
			set
			{
				short num = (short)305135616;
				short num2 = num;
				num = (short)758436183;
				short num3 = num;
				num = (short)1502335319;
				switch (num3 == num)
				{
				}
				num = (short)2007367681;
				if (num != 0)
				{
				}
				num = (short)894107648;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralMINGAIN_A22298.Visible = value;
			}
		}

		// Token: 0x17003892 RID: 14482
		// (get) Token: 0x06006D62 RID: 28002 RVA: 0x00619304 File Offset: 0x00617504
		// (set) Token: 0x06006D63 RID: 28003 RVA: 0x006193BC File Offset: 0x006175BC
		public bool RadErgoCfgGeneralMINGAIN_A22298_Editable
		{
			get
			{
				short num = (short)1102446592;
				short num2 = num;
				num = (short)1271903284;
				short num3 = num;
				num = (short)1266332724;
				switch (num3 == num)
				{
				}
				num = (short)502857729;
				if (num != 0)
				{
				}
				num = (short)1758330880;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMINGAIN_A22298.Editable;
			}
			set
			{
				short num = (short)191102976;
				short num2 = num;
				num = (short)1666374101;
				short num3 = num;
				num = (short)1708775893;
				switch (num3 == num)
				{
				}
				num = (short)1202454529;
				if (num != 0)
				{
				}
				num = (short)528482304;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralMINGAIN_A22298.Editable = value;
			}
		}

		// Token: 0x17003893 RID: 14483
		// (get) Token: 0x06006D64 RID: 28004 RVA: 0x00619470 File Offset: 0x00617670
		internal string RadErgoCfgGeneralMINGAIN_A22298_UILabel
		{
			get
			{
				short num = (short)1978531840;
				short num2 = num;
				num = (short)882693030;
				short num3 = num;
				num = (short)1381028774;
				switch (num3 == num)
				{
				}
				num = (short)1343160320;
				if (num != 0)
				{
				}
				num = (short)444858369;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMINGAIN_A22298.UIName;
			}
		}

		// Token: 0x17003894 RID: 14484
		// (get) Token: 0x06006D65 RID: 28005 RVA: 0x00619524 File Offset: 0x00617724
		// (set) Token: 0x06006D66 RID: 28006 RVA: 0x006195DC File Offset: 0x006177DC
		internal bool RadErgoCfgGeneralMINGAIN_A22298_HiddenStatic
		{
			get
			{
				short num = (short)1916731392;
				short num2 = num;
				num = (short)1512898561;
				if (num != 0)
				{
				}
				num = (short)857336009;
				short num3 = num;
				num = (short)1425270985;
				switch (num3 == num)
				{
				}
				num = (short)549912576;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMINGAIN_A22298.HiddenStatic;
			}
			set
			{
				short num = (short)773128192;
				short num2 = num;
				num = (short)912555616;
				short num3 = num;
				num = (short)1817935456;
				switch (num3 == num)
				{
				}
				num = (short)980549632;
				if (num != 0)
				{
				}
				num = (short)366870529;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralMINGAIN_A22298.HiddenStatic = value;
			}
		}

		// Token: 0x17003895 RID: 14485
		// (get) Token: 0x06006D67 RID: 28007 RVA: 0x00619690 File Offset: 0x00617890
		// (set) Token: 0x06006D68 RID: 28008 RVA: 0x00619744 File Offset: 0x00617944
		internal bool RadErgoCfgGeneralMINGAIN_A22298_HiddenDynamic
		{
			get
			{
				short num = (short)1248198656;
				short num2 = num;
				num = (short)1744469352;
				short num3 = num;
				num = (short)160071016;
				switch (num3 == num)
				{
				}
				num = (short)660865025;
				if (num != 0)
				{
				}
				num = (short)53215232;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMINGAIN_A22298.HiddenDynamic;
			}
			set
			{
				short num = (short)1870594048;
				short num2 = num;
				num = (short)744568304;
				short num3 = num;
				num = (short)2082092528;
				switch (num3 == num)
				{
				}
				num = (short)87949312;
				if (num != 0)
				{
				}
				num = (short)1145634817;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralMINGAIN_A22298.HiddenDynamic = value;
			}
		}

		// Token: 0x17003896 RID: 14486
		// (get) Token: 0x06006D69 RID: 28009 RVA: 0x006197F8 File Offset: 0x006179F8
		public bool RadErgoCfgGeneralMINGAIN_A22298_HasDiffs
		{
			get
			{
				short num = (short)1963524096;
				short num2 = num;
				num = (short)1432515368;
				short num3 = num;
				num = (short)2035708712;
				switch (num3 == num)
				{
				}
				num = (short)511770625;
				if (num != 0)
				{
				}
				num = (short)1879310336;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMINGAIN_A22298._HasDiffs;
			}
		}

		// Token: 0x17003897 RID: 14487
		// (get) Token: 0x06006D6A RID: 28010 RVA: 0x006198B0 File Offset: 0x00617AB0
		// (set) Token: 0x06006D6B RID: 28011 RVA: 0x00619968 File Offset: 0x00617B68
		public int RadErgoCfgGeneralDINCABFSS_A22300Value
		{
			get
			{
				short num = (short)1892417536;
				short num2 = num;
				num = (short)1962030788;
				short num3 = num;
				num = (short)1708537540;
				switch (num3 == num)
				{
				}
				num = (short)79953920;
				if (num != 0)
				{
				}
				num = (short)1175322625;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A22300.Value;
			}
			set
			{
				short num = (short)1014890496;
				short num2 = num;
				num = (short)2145924527;
				short num3 = num;
				num = (short)530789807;
				switch (num3 == num)
				{
				}
				num = (short)64159745;
				if (num != 0)
				{
				}
				num = (short)1599799296;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCABFSS_A22300.Value = value;
			}
		}

		// Token: 0x17003898 RID: 14488
		// (get) Token: 0x06006D6C RID: 28012 RVA: 0x00619A20 File Offset: 0x00617C20
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgGeneralDINCABFSS_A22300
		{
			get
			{
				short num = (short)1046413312;
				short num2 = num;
				num = (short)694550529;
				if (num != 0)
				{
				}
				num = (short)985884647;
				short num3 = num;
				num = (short)938239975;
				switch (num3 == num)
				{
				}
				num = (short)923467776;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A22300;
			}
		}

		// Token: 0x17003899 RID: 14489
		// (get) Token: 0x06006D6D RID: 28013 RVA: 0x00619AD4 File Offset: 0x00617CD4
		// (set) Token: 0x06006D6E RID: 28014 RVA: 0x00619B88 File Offset: 0x00617D88
		public string RadErgoCfgGeneralDINCABFSS_A22300_UIValue
		{
			get
			{
				short num = (short)1079508992;
				short num2 = num;
				num = (short)130839430;
				short num3 = num;
				num = (short)341275526;
				switch (num3 == num)
				{
				}
				num = (short)118554624;
				if (num != 0)
				{
				}
				num = (short)1146355713;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A22300.UIValue;
			}
			set
			{
				short num = (short)803799040;
				short num2 = num;
				num = (short)524189633;
				short num3 = num;
				num = (short)11435969;
				switch (num3 == num)
				{
				}
				num = (short)184352768;
				if (num != 0)
				{
				}
				num = (short)1579352065;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCABFSS_A22300.UIValue = value;
			}
		}

		// Token: 0x1700389A RID: 14490
		// (get) Token: 0x06006D6F RID: 28015 RVA: 0x00619C3C File Offset: 0x00617E3C
		// (set) Token: 0x06006D70 RID: 28016 RVA: 0x00619CF0 File Offset: 0x00617EF0
		public string RadErgoCfgGeneralDINCABFSS_A22300_HexUIValue
		{
			get
			{
				short num = (short)1618280448;
				short num2 = num;
				num = (short)2069037057;
				if (num != 0)
				{
				}
				num = (short)985672130;
				short num3 = num;
				num = (short)1007626690;
				switch (num3 == num)
				{
				}
				num = (short)1186332672;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A22300.HexUIValue;
			}
			set
			{
				short num = (short)1061748736;
				short num2 = num;
				num = (short)1135621360;
				short num3 = num;
				num = (short)1803039984;
				switch (num3 == num)
				{
				}
				num = (short)1117388800;
				if (num != 0)
				{
				}
				num = (short)1939996673;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCABFSS_A22300.HexUIValue = value;
			}
		}

		// Token: 0x1700389B RID: 14491
		// (get) Token: 0x06006D71 RID: 28017 RVA: 0x00619DA4 File Offset: 0x00617FA4
		// (set) Token: 0x06006D72 RID: 28018 RVA: 0x00619E58 File Offset: 0x00618058
		internal int RadErgoCfgGeneralDINCABFSS_A22300Min
		{
			get
			{
				short num = (short)1088421888;
				short num2 = num;
				num = (short)380544599;
				short num3 = num;
				num = (short)1927980631;
				switch (num3 == num)
				{
				}
				num = (short)2027618305;
				if (num != 0)
				{
				}
				num = (short)1966800896;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A22300.Min;
			}
			set
			{
				short num = (short)1031143424;
				short num2 = num;
				num = (short)953176575;
				short num3 = num;
				num = (short)1271026175;
				switch (num3 == num)
				{
				}
				num = (short)1110048769;
				if (num != 0)
				{
				}
				num = (short)1900412928;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCABFSS_A22300.Min = value;
			}
		}

		// Token: 0x1700389C RID: 14492
		// (get) Token: 0x06006D73 RID: 28019 RVA: 0x00619F0C File Offset: 0x0061810C
		// (set) Token: 0x06006D74 RID: 28020 RVA: 0x00619FC4 File Offset: 0x006181C4
		internal int RadErgoCfgGeneralDINCABFSS_A22300Max
		{
			get
			{
				short num = (short)666435584;
				short num2 = num;
				num = (short)168096447;
				short num3 = num;
				num = (short)1080947391;
				switch (num3 == num)
				{
				}
				num = (short)1390870529;
				if (num != 0)
				{
				}
				num = (short)562429952;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A22300.Max;
			}
			set
			{
				short num = (short)1844248576;
				short num2 = num;
				num = (short)469172225;
				if (num != 0)
				{
				}
				num = (short)1522490135;
				short num3 = num;
				num = (short)1621449495;
				switch (num3 == num)
				{
				}
				num = (short)1066663936;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCABFSS_A22300.Max = value;
			}
		}

		// Token: 0x1700389D RID: 14493
		// (get) Token: 0x06006D75 RID: 28021 RVA: 0x0061A078 File Offset: 0x00618278
		// (set) Token: 0x06006D76 RID: 28022 RVA: 0x0061A12C File Offset: 0x0061832C
		internal int RadErgoCfgGeneralDINCABFSS_A22300Step
		{
			get
			{
				short num = (short)1548222464;
				short num2 = num;
				num = (short)391773764;
				short num3 = num;
				num = (short)2000944708;
				switch (num3 == num)
				{
				}
				num = (short)681312257;
				if (num != 0)
				{
				}
				num = (short)498728960;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A22300.StepSize;
			}
			set
			{
				short num = (short)54001664;
				short num2 = num;
				num = (short)1374989150;
				short num3 = num;
				num = (short)203074398;
				switch (num3 == num)
				{
				}
				num = (short)1961426945;
				if (num != 0)
				{
				}
				num = (short)1762328576;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCABFSS_A22300.StepSize = value;
			}
		}

		// Token: 0x1700389E RID: 14494
		// (get) Token: 0x06006D77 RID: 28023 RVA: 0x0061A1E0 File Offset: 0x006183E0
		// (set) Token: 0x06006D78 RID: 28024 RVA: 0x0061A294 File Offset: 0x00618494
		public bool RadErgoCfgGeneralDINCABFSS_A22300_Applicable
		{
			get
			{
				short num = (short)129892352;
				short num2 = num;
				num = (short)1701351499;
				short num3 = num;
				num = (short)1876136011;
				switch (num3 == num)
				{
				}
				num = (short)1710620672;
				if (num != 0)
				{
				}
				num = (short)1641414657;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A22300.Applicable;
			}
			set
			{
				short num = (short)59768832;
				short num2 = num;
				num = (short)1979495839;
				short num3 = num;
				num = (short)1331803551;
				switch (num3 == num)
				{
				}
				num = (short)1469120512;
				if (num != 0)
				{
				}
				num = (short)861732865;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCABFSS_A22300.Applicable = value;
			}
		}

		// Token: 0x1700389F RID: 14495
		// (get) Token: 0x06006D79 RID: 28025 RVA: 0x0061A34C File Offset: 0x0061854C
		// (set) Token: 0x06006D7A RID: 28026 RVA: 0x0061A400 File Offset: 0x00618600
		public bool RadErgoCfgGeneralDINCABFSS_A22300_Valid
		{
			get
			{
				short num = (short)1775370240;
				short num2 = num;
				num = (short)2025641487;
				short num3 = num;
				num = (short)753194511;
				switch (num3 == num)
				{
				}
				num = (short)1601306625;
				if (num != 0)
				{
				}
				num = (short)1622867968;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A22300.Valid;
			}
			set
			{
				short num = (short)1912537088;
				short num2 = num;
				num = (short)338898898;
				short num3 = num;
				num = (short)1907371986;
				switch (num3 == num)
				{
				}
				num = (short)1274281984;
				if (num != 0)
				{
				}
				num = (short)215351297;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCABFSS_A22300.Valid = value;
			}
		}

		// Token: 0x170038A0 RID: 14496
		// (get) Token: 0x06006D7B RID: 28027 RVA: 0x0061A4B8 File Offset: 0x006186B8
		// (set) Token: 0x06006D7C RID: 28028 RVA: 0x0061A56C File Offset: 0x0061876C
		public bool RadErgoCfgGeneralDINCABFSS_A22300_Visible
		{
			get
			{
				short num = (short)1874788352;
				short num2 = num;
				num = (short)1950862311;
				short num3 = num;
				num = (short)1049152487;
				switch (num3 == num)
				{
				}
				num = (short)1799749633;
				if (num != 0)
				{
				}
				num = (short)884015104;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A22300.Visible;
			}
			set
			{
				short num = (short)1139343360;
				short num2 = num;
				num = (short)556920461;
				short num3 = num;
				num = (short)522776205;
				switch (num3 == num)
				{
				}
				num = (short)1361248257;
				if (num != 0)
				{
				}
				num = (short)1315897344;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCABFSS_A22300.Visible = value;
			}
		}

		// Token: 0x170038A1 RID: 14497
		// (get) Token: 0x06006D7D RID: 28029 RVA: 0x0061A624 File Offset: 0x00618824
		// (set) Token: 0x06006D7E RID: 28030 RVA: 0x0061A6D4 File Offset: 0x006188D4
		public bool RadErgoCfgGeneralDINCABFSS_A22300_Editable
		{
			get
			{
				short num = (short)334823424;
				short num2 = num;
				num = (short)1824359377;
				short num3 = num;
				num = (short)194020305;
				switch (num3 == num)
				{
				}
				num = (short)304480257;
				if (num != 0)
				{
				}
				num = (short)464519168;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A22300.Editable;
			}
			set
			{
				short num = (short)1024393216;
				short num2 = num;
				num = (short)595787777;
				if (num != 0)
				{
				}
				num = (short)1276664546;
				short num3 = num;
				num = (short)1539594978;
				switch (num3 == num)
				{
				}
				num = (short)1096613888;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCABFSS_A22300.Editable = value;
			}
		}

		// Token: 0x170038A2 RID: 14498
		// (get) Token: 0x06006D7F RID: 28031 RVA: 0x0061A788 File Offset: 0x00618988
		internal string RadErgoCfgGeneralDINCABFSS_A22300_UILabel
		{
			get
			{
				short num = (short)1799028736;
				short num2 = num;
				num = (short)284951564;
				short num3 = num;
				num = (short)1739392012;
				switch (num3 == num)
				{
				}
				num = (short)1937047553;
				if (num != 0)
				{
				}
				num = (short)370081792;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A22300.UIName;
			}
		}

		// Token: 0x170038A3 RID: 14499
		// (get) Token: 0x06006D80 RID: 28032 RVA: 0x0061A83C File Offset: 0x00618A3C
		// (set) Token: 0x06006D81 RID: 28033 RVA: 0x0061A8F4 File Offset: 0x00618AF4
		internal bool RadErgoCfgGeneralDINCABFSS_A22300_HiddenStatic
		{
			get
			{
				short num = (short)834011136;
				short num2 = num;
				num = (short)814479189;
				short num3 = num;
				num = (short)294188885;
				switch (num3 == num)
				{
				}
				num = (short)1617166337;
				if (num != 0)
				{
				}
				num = (short)1977286656;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A22300.HiddenStatic;
			}
			set
			{
				short num = (short)1365901312;
				short num2 = num;
				num = (short)1456099794;
				short num3 = num;
				num = (short)83841490;
				switch (num3 == num)
				{
				}
				num = (short)1774780417;
				if (num != 0)
				{
				}
				num = (short)197722112;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCABFSS_A22300.HiddenStatic = value;
			}
		}

		// Token: 0x170038A4 RID: 14500
		// (get) Token: 0x06006D82 RID: 28034 RVA: 0x0061A9A8 File Offset: 0x00618BA8
		// (set) Token: 0x06006D83 RID: 28035 RVA: 0x0061AA5C File Offset: 0x00618C5C
		internal bool RadErgoCfgGeneralDINCABFSS_A22300_HiddenDynamic
		{
			get
			{
				short num = (short)1767505920;
				short num2 = num;
				num = (short)2083989037;
				short num3 = num;
				num = (short)137242157;
				switch (num3 == num)
				{
				}
				num = (short)585367552;
				if (num != 0)
				{
				}
				num = (short)811925505;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A22300.HiddenDynamic;
			}
			set
			{
				short num = (short)1959591936;
				short num2 = num;
				num = (short)1061164222;
				short num3 = num;
				num = (short)58070206;
				switch (num3 == num)
				{
				}
				num = (short)564592641;
				if (num != 0)
				{
				}
				num = (short)1008533504;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCABFSS_A22300.HiddenDynamic = value;
			}
		}

		// Token: 0x170038A5 RID: 14501
		// (get) Token: 0x06006D84 RID: 28036 RVA: 0x0061AB14 File Offset: 0x00618D14
		public bool RadErgoCfgGeneralDINCABFSS_A22300_HasDiffs
		{
			get
			{
				short num = (short)120455168;
				short num2 = num;
				num = (short)361800621;
				short num3 = num;
				num = (short)804168621;
				switch (num3 == num)
				{
				}
				num = (short)711065601;
				if (num != 0)
				{
				}
				num = (short)1640562688;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A22300._HasDiffs;
			}
		}

		// Token: 0x170038A6 RID: 14502
		// (get) Token: 0x06006D85 RID: 28037 RVA: 0x0061ABC4 File Offset: 0x00618DC4
		// (set) Token: 0x06006D86 RID: 28038 RVA: 0x0061AC7C File Offset: 0x00618E7C
		public int RadErgoCfgGeneralDINCEWINDNBANDS_A22301Value
		{
			get
			{
				short num = (short)932052992;
				short num2 = num;
				num = (short)1603961252;
				short num3 = num;
				num = (short)1481998756;
				switch (num3 == num)
				{
				}
				num = (short)1045430272;
				if (num != 0)
				{
				}
				num = (short)1153499137;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.Value;
			}
			set
			{
				short num = (short)1921122304;
				short num2 = num;
				num = (short)1186532970;
				short num3 = num;
				num = (short)1319833194;
				switch (num3 == num)
				{
				}
				num = (short)383254529;
				if (num != 0)
				{
				}
				num = (short)257294336;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.Value = value;
			}
		}

		// Token: 0x170038A7 RID: 14503
		// (get) Token: 0x06006D87 RID: 28039 RVA: 0x0061AD30 File Offset: 0x00618F30
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgGeneralDINCEWINDNBANDS_A22301
		{
			get
			{
				short num = (short)291831808;
				short num2 = num;
				num = (short)2101411841;
				if (num != 0)
				{
				}
				num = (short)846255852;
				short num3 = num;
				num = (short)674617068;
				switch (num3 == num)
				{
				}
				num = (short)816971776;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCEWINDNBANDS_A22301;
			}
		}

		// Token: 0x170038A8 RID: 14504
		// (get) Token: 0x06006D88 RID: 28040 RVA: 0x0061ADE4 File Offset: 0x00618FE4
		// (set) Token: 0x06006D89 RID: 28041 RVA: 0x0061AE9C File Offset: 0x0061909C
		public string RadErgoCfgGeneralDINCEWINDNBANDS_A22301_UIValue
		{
			get
			{
				short num = (short)1922813770;
				short num2 = num;
				num = (short)1079758666;
				switch (num2 == num)
				{
				}
				num = (short)398131201;
				if (num != 0)
				{
				}
				num = (short)106889216;
				short num3 = num;
				num = (short)536936448;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.UIValue;
			}
			set
			{
				short num = (short)982908929;
				if (num != 0)
				{
				}
				num = (short)792721684;
				short num2 = num;
				num = (short)1758591252;
				switch (num2 == num)
				{
				}
				num = (short)1262944256;
				short num3 = num;
				num = (short)1689124864;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.UIValue = value;
			}
		}

		// Token: 0x170038A9 RID: 14505
		// (get) Token: 0x06006D8A RID: 28042 RVA: 0x0061AF50 File Offset: 0x00619150
		// (set) Token: 0x06006D8B RID: 28043 RVA: 0x0061B004 File Offset: 0x00619204
		public string RadErgoCfgGeneralDINCEWINDNBANDS_A22301_HexUIValue
		{
			get
			{
				short num = (short)125656645;
				short num2 = num;
				num = (short)419978821;
				switch (num2 == num)
				{
				}
				num = (short)756285440;
				if (num != 0)
				{
				}
				num = (short)548667392;
				short num3 = num;
				num = (short)809500673;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.HexUIValue;
			}
			set
			{
				short num = (short)1346679551;
				short num2 = num;
				num = (short)1841214207;
				switch (num2 == num)
				{
				}
				num = (short)635109377;
				if (num != 0)
				{
				}
				num = (short)773521408;
				short num3 = num;
				num = (short)1557790720;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.HexUIValue = value;
			}
		}

		// Token: 0x170038AA RID: 14506
		// (get) Token: 0x06006D8C RID: 28044 RVA: 0x0061B0B8 File Offset: 0x006192B8
		// (set) Token: 0x06006D8D RID: 28045 RVA: 0x0061B16C File Offset: 0x0061936C
		internal int RadErgoCfgGeneralDINCEWINDNBANDS_A22301Min
		{
			get
			{
				short num = (short)554079787;
				short num2 = num;
				num = (short)1545442859;
				switch (num2 == num)
				{
				}
				num = (short)508428289;
				if (num != 0)
				{
				}
				num = (short)1739784192;
				short num3 = num;
				num = (short)584384512;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.Min;
			}
			set
			{
				short num = (short)517560425;
				short num2 = num;
				num = (short)261838953;
				switch (num2 == num)
				{
				}
				num = (short)1828257792;
				if (num != 0)
				{
				}
				num = (short)728498176;
				short num3 = num;
				num = (short)1755447297;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.Min = value;
			}
		}

		// Token: 0x170038AB RID: 14507
		// (get) Token: 0x06006D8E RID: 28046 RVA: 0x0061B224 File Offset: 0x00619424
		// (set) Token: 0x06006D8F RID: 28047 RVA: 0x0061B2D8 File Offset: 0x006194D8
		internal int RadErgoCfgGeneralDINCEWINDNBANDS_A22301Max
		{
			get
			{
				short num = (short)403638245;
				short num2 = num;
				num = (short)1330776037;
				switch (num2 == num)
				{
				}
				num = (short)341245953;
				if (num != 0)
				{
				}
				num = (short)2113011712;
				short num3 = num;
				num = (short)355205120;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.Max;
			}
			set
			{
				short num = (short)1327739714;
				short num2 = num;
				num = (short)873116482;
				switch (num2 == num)
				{
				}
				num = (short)492109825;
				if (num != 0)
				{
				}
				num = (short)2081751040;
				short num3 = num;
				num = (short)944046080;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.Max = value;
			}
		}

		// Token: 0x170038AC RID: 14508
		// (get) Token: 0x06006D90 RID: 28048 RVA: 0x0061B38C File Offset: 0x0061958C
		// (set) Token: 0x06006D91 RID: 28049 RVA: 0x0061B440 File Offset: 0x00619640
		internal int RadErgoCfgGeneralDINCEWINDNBANDS_A22301Step
		{
			get
			{
				short num = (short)330432513;
				if (num != 0)
				{
				}
				num = (short)1890784562;
				short num2 = num;
				num = (short)1895896370;
				switch (num2 == num)
				{
				}
				num = (short)1938423808;
				short num3 = num;
				num = (short)297205760;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.StepSize;
			}
			set
			{
				short num = (short)273762699;
				short num2 = num;
				num = (short)169232779;
				switch (num2 == num)
				{
				}
				num = (short)236322817;
				if (num != 0)
				{
				}
				num = (short)109641728;
				short num3 = num;
				num = (short)665976832;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.StepSize = value;
			}
		}

		// Token: 0x170038AD RID: 14509
		// (get) Token: 0x06006D92 RID: 28050 RVA: 0x0061B4F4 File Offset: 0x006196F4
		// (set) Token: 0x06006D93 RID: 28051 RVA: 0x0061B5A8 File Offset: 0x006197A8
		public bool RadErgoCfgGeneralDINCEWINDNBANDS_A22301_Applicable
		{
			get
			{
				short num = (short)505766195;
				short num2 = num;
				num = (short)673407283;
				switch (num2 == num)
				{
				}
				num = (short)22675456;
				if (num != 0)
				{
				}
				num = (short)28704768;
				short num3 = num;
				num = (short)54788097;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.Applicable;
			}
			set
			{
				short num = (short)2036092183;
				short num2 = num;
				num = (short)1037847831;
				switch (num2 == num)
				{
				}
				num = (short)331481089;
				if (num != 0)
				{
				}
				num = (short)1431896064;
				short num3 = num;
				num = (short)994967552;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.Applicable = value;
			}
		}

		// Token: 0x170038AE RID: 14510
		// (get) Token: 0x06006D94 RID: 28052 RVA: 0x0061B65C File Offset: 0x0061985C
		// (set) Token: 0x06006D95 RID: 28053 RVA: 0x0061B710 File Offset: 0x00619910
		public bool RadErgoCfgGeneralDINCEWINDNBANDS_A22301_Valid
		{
			get
			{
				short num = (short)879419307;
				short num2 = num;
				num = (short)568319915;
				switch (num2 == num)
				{
				}
				num = (short)1037762560;
				if (num != 0)
				{
				}
				num = (short)1842085888;
				short num3 = num;
				num = (short)939065345;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.Valid;
			}
			set
			{
				short num = (short)2046603844;
				short num2 = num;
				num = (short)1177989700;
				switch (num2 == num)
				{
				}
				num = (short)939393025;
				if (num != 0)
				{
				}
				num = (short)40501248;
				short num3 = num;
				num = (short)341114880;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.Valid = value;
			}
		}

		// Token: 0x170038AF RID: 14511
		// (get) Token: 0x06006D96 RID: 28054 RVA: 0x0061B7C8 File Offset: 0x006199C8
		// (set) Token: 0x06006D97 RID: 28055 RVA: 0x0061B87C File Offset: 0x00619A7C
		public bool RadErgoCfgGeneralDINCEWINDNBANDS_A22301_Visible
		{
			get
			{
				short num = (short)301800536;
				short num2 = num;
				num = (short)991173720;
				switch (num2 == num)
				{
				}
				num = (short)637534209;
				if (num != 0)
				{
				}
				num = (short)958857216;
				short num3 = num;
				num = (short)144310272;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.Visible;
			}
			set
			{
				short num = (short)311807112;
				short num2 = num;
				num = (short)1288817800;
				switch (num2 == num)
				{
				}
				num = (short)578289665;
				if (num != 0)
				{
				}
				num = (short)197591040;
				short num3 = num;
				num = (short)1427832832;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.Visible = value;
			}
		}

		// Token: 0x170038B0 RID: 14512
		// (get) Token: 0x06006D98 RID: 28056 RVA: 0x0061B930 File Offset: 0x00619B30
		// (set) Token: 0x06006D99 RID: 28057 RVA: 0x0061B9E4 File Offset: 0x00619BE4
		public bool RadErgoCfgGeneralDINCEWINDNBANDS_A22301_Editable
		{
			get
			{
				short num = (short)515122681;
				short num2 = num;
				num = (short)727524857;
				switch (num2 == num)
				{
				}
				num = (short)223281152;
				if (num != 0)
				{
				}
				num = (short)170131456;
				short num3 = num;
				num = (short)764870657;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.Editable;
			}
			set
			{
				short num = (short)34546664;
				short num2 = num;
				num = (short)1841832936;
				switch (num2 == num)
				{
				}
				num = (short)1089011712;
				if (num != 0)
				{
				}
				num = (short)1276641280;
				short num3 = num;
				num = (short)526909441;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.Editable = value;
			}
		}

		// Token: 0x170038B1 RID: 14513
		// (get) Token: 0x06006D9A RID: 28058 RVA: 0x0061BA98 File Offset: 0x00619C98
		internal string RadErgoCfgGeneralDINCEWINDNBANDS_A22301_UILabel
		{
			get
			{
				short num = (short)1595810870;
				short num2 = num;
				num = (short)472523830;
				switch (num2 == num)
				{
				}
				num = (short)1488781313;
				if (num != 0)
				{
				}
				num = (short)1303838720;
				short num3 = num;
				num = (short)1240596480;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.UIName;
			}
		}

		// Token: 0x170038B2 RID: 14514
		// (get) Token: 0x06006D9B RID: 28059 RVA: 0x0061BB4C File Offset: 0x00619D4C
		// (set) Token: 0x06006D9C RID: 28060 RVA: 0x0061BC00 File Offset: 0x00619E00
		internal bool RadErgoCfgGeneralDINCEWINDNBANDS_A22301_HiddenStatic
		{
			get
			{
				short num = (short)250150295;
				short num2 = num;
				num = (short)1573780887;
				switch (num2 == num)
				{
				}
				num = (short)931790849;
				if (num != 0)
				{
				}
				num = (short)895483904;
				short num3 = num;
				num = (short)364380160;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.HiddenStatic;
			}
			set
			{
				short num = (short)537198593;
				if (num != 0)
				{
				}
				num = (short)1229699319;
				short num2 = num;
				num = (short)553564407;
				switch (num2 == num)
				{
				}
				num = (short)1585774592;
				short num3 = num;
				num = (short)2053373952;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.HiddenStatic = value;
			}
		}

		// Token: 0x170038B3 RID: 14515
		// (get) Token: 0x06006D9D RID: 28061 RVA: 0x0061BCB4 File Offset: 0x00619EB4
		// (set) Token: 0x06006D9E RID: 28062 RVA: 0x0061BD68 File Offset: 0x00619F68
		internal bool RadErgoCfgGeneralDINCEWINDNBANDS_A22301_HiddenDynamic
		{
			get
			{
				short num = (short)1285075576;
				short num2 = num;
				num = (short)1985983096;
				switch (num2 == num)
				{
				}
				num = (short)384040961;
				if (num != 0)
				{
				}
				num = (short)417529856;
				short num3 = num;
				num = (short)2019295232;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.HiddenDynamic;
			}
			set
			{
				short num = (short)1695780571;
				short num2 = num;
				num = (short)1048219355;
				switch (num2 == num)
				{
				}
				num = (short)438370305;
				if (num != 0)
				{
				}
				num = (short)1850605568;
				short num3 = num;
				num = (short)976420864;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCEWINDNBANDS_A22301.HiddenDynamic = value;
			}
		}

		// Token: 0x170038B4 RID: 14516
		// (get) Token: 0x06006D9F RID: 28063 RVA: 0x0061BE20 File Offset: 0x0061A020
		public bool RadErgoCfgGeneralDINCEWINDNBANDS_A22301_HasDiffs
		{
			get
			{
				short num = (short)1418375710;
				short num2 = num;
				num = (short)685617694;
				switch (num2 == num)
				{
				}
				num = (short)455802881;
				if (num != 0)
				{
				}
				num = (short)1765081088;
				short num3 = num;
				num = (short)370868224;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCEWINDNBANDS_A22301._HasDiffs;
			}
		}

		// Token: 0x170038B5 RID: 14517
		// (get) Token: 0x06006DA0 RID: 28064 RVA: 0x0061BED4 File Offset: 0x0061A0D4
		// (set) Token: 0x06006DA1 RID: 28065 RVA: 0x0061BF8C File Offset: 0x0061A18C
		public string RadErgoCfgGeneralMAXSVECTOR_A22297Value
		{
			get
			{
				short num = (short)1753552965;
				short num2 = num;
				num = (short)741349445;
				switch (num2 == num)
				{
				}
				num = (short)503054337;
				if (num != 0)
				{
				}
				num = (short)1861550080;
				short num3 = num;
				num = (short)815071232;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMAXSVECTOR_A22297.Value;
			}
			set
			{
				short num = (short)1393308344;
				short num2 = num;
				num = (short)25440952;
				switch (num2 == num)
				{
				}
				num = (short)1104019457;
				if (num != 0)
				{
				}
				num = (short)342949888;
				short num3 = num;
				num = (short)1476460544;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralMAXSVECTOR_A22297.Value = value;
			}
		}

		// Token: 0x170038B6 RID: 14518
		// (get) Token: 0x06006DA2 RID: 28066 RVA: 0x0061C044 File Offset: 0x0061A244
		public global::AcpBusinessLayer.AcpField<string> RadErgoCfgGeneralMAXSVECTOR_A22297
		{
			get
			{
				short num = (short)1997996033;
				if (num != 0)
				{
				}
				num = (short)1815428697;
				short num2 = num;
				num = (short)2034777689;
				switch (num2 == num)
				{
				}
				num = (short)88735744;
				short num3 = num;
				num = (short)985661440;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMAXSVECTOR_A22297;
			}
		}

		// Token: 0x170038B7 RID: 14519
		// (get) Token: 0x06006DA3 RID: 28067 RVA: 0x0061C0F0 File Offset: 0x0061A2F0
		// (set) Token: 0x06006DA4 RID: 28068 RVA: 0x0061C1A4 File Offset: 0x0061A3A4
		public string RadErgoCfgGeneralMAXSVECTOR_A22297_UIValue
		{
			get
			{
				short num = (short)1835144724;
				short num2 = num;
				num = (short)1477318164;
				switch (num2 == num)
				{
				}
				num = (short)1872101377;
				if (num != 0)
				{
				}
				num = (short)939065344;
				short num3 = num;
				num = (short)23461888;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMAXSVECTOR_A22297.Value;
			}
			set
			{
				short num = (short)1251429721;
				short num2 = num;
				num = (short)1955810649;
				switch (num2 == num)
				{
				}
				num = (short)171966464;
				if (num != 0)
				{
				}
				num = (short)504102912;
				short num3 = num;
				num = (short)1239220225;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralMAXSVECTOR_A22297.Value = value;
			}
		}

		// Token: 0x170038B8 RID: 14520
		// (get) Token: 0x06006DA5 RID: 28069 RVA: 0x0061C25C File Offset: 0x0061A45C
		// (set) Token: 0x06006DA6 RID: 28070 RVA: 0x0061C310 File Offset: 0x0061A510
		public bool RadErgoCfgGeneralMAXSVECTOR_A22297_Applicable
		{
			get
			{
				short num = (short)417426179;
				short num2 = num;
				num = (short)173042435;
				switch (num2 == num)
				{
				}
				num = (short)1754005505;
				if (num != 0)
				{
				}
				num = (short)1333002240;
				short num3 = num;
				num = (short)1387921408;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMAXSVECTOR_A22297.Applicable;
			}
			set
			{
				short num = (short)1425180181;
				short num2 = num;
				num = (short)353142293;
				switch (num2 == num)
				{
				}
				num = (short)489553921;
				if (num != 0)
				{
				}
				num = (short)924450816;
				short num3 = num;
				num = (short)1110638592;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralMAXSVECTOR_A22297.Applicable = value;
			}
		}

		// Token: 0x170038B9 RID: 14521
		// (get) Token: 0x06006DA7 RID: 28071 RVA: 0x0061C3C8 File Offset: 0x0061A5C8
		// (set) Token: 0x06006DA8 RID: 28072 RVA: 0x0061C478 File Offset: 0x0061A678
		public bool RadErgoCfgGeneralMAXSVECTOR_A22297_Valid
		{
			get
			{
				short num = (short)699446091;
				short num2 = num;
				num = (short)2114827083;
				switch (num2 == num)
				{
				}
				num = (short)2063794176;
				if (num != 0)
				{
				}
				num = (short)50003968;
				short num3 = num;
				num = (short)1832583169;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMAXSVECTOR_A22297.Valid;
			}
			set
			{
				short num = (short)246192108;
				short num2 = num;
				num = (short)211654636;
				switch (num2 == num)
				{
				}
				num = (short)1395785729;
				if (num != 0)
				{
				}
				num = (short)1152253952;
				short num3 = num;
				num = (short)1829765120;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralMAXSVECTOR_A22297.Valid = value;
			}
		}

		// Token: 0x170038BA RID: 14522
		// (get) Token: 0x06006DA9 RID: 28073 RVA: 0x0061C52C File Offset: 0x0061A72C
		// (set) Token: 0x06006DAA RID: 28074 RVA: 0x0061C5E4 File Offset: 0x0061A7E4
		public bool RadErgoCfgGeneralMAXSVECTOR_A22297_Visible
		{
			get
			{
				short num = (short)1855421202;
				short num2 = num;
				num = (short)1363835666;
				switch (num2 == num)
				{
				}
				num = (short)1246298113;
				if (num != 0)
				{
				}
				num = (short)112066560;
				short num3 = num;
				num = (short)332726272;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMAXSVECTOR_A22297.Visible;
			}
			set
			{
				short num = (short)1556095861;
				short num2 = num;
				num = (short)1226777461;
				switch (num2 == num)
				{
				}
				num = (short)609812481;
				if (num != 0)
				{
				}
				num = (short)417071104;
				short num3 = num;
				num = (short)1799356416;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralMAXSVECTOR_A22297.Visible = value;
			}
		}

		// Token: 0x170038BB RID: 14523
		// (get) Token: 0x06006DAB RID: 28075 RVA: 0x0061C69C File Offset: 0x0061A89C
		// (set) Token: 0x06006DAC RID: 28076 RVA: 0x0061C754 File Offset: 0x0061A954
		public bool RadErgoCfgGeneralMAXSVECTOR_A22297_Editable
		{
			get
			{
				short num = (short)1853645315;
				short num2 = num;
				num = (short)315712003;
				switch (num2 == num)
				{
				}
				num = (short)126681088;
				if (num != 0)
				{
				}
				num = (short)1504116736;
				short num3 = num;
				num = (short)1568866305;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMAXSVECTOR_A22297.Editable;
			}
			set
			{
				short num = (short)1380884478;
				short num2 = num;
				num = (short)298098686;
				switch (num2 == num)
				{
				}
				num = (short)1080295425;
				if (num != 0)
				{
				}
				num = (short)1235681280;
				short num3 = num;
				num = (short)1908473856;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralMAXSVECTOR_A22297.Editable = value;
			}
		}

		// Token: 0x170038BC RID: 14524
		// (get) Token: 0x06006DAD RID: 28077 RVA: 0x0061C80C File Offset: 0x0061AA0C
		internal string RadErgoCfgGeneralMAXSVECTOR_A22297_UILabel
		{
			get
			{
				short num = (short)829945951;
				short num2 = num;
				num = (short)201521247;
				switch (num2 == num)
				{
				}
				num = (short)345505792;
				if (num != 0)
				{
				}
				num = (short)1384316928;
				short num3 = num;
				num = (short)468320257;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMAXSVECTOR_A22297.UIName;
			}
		}

		// Token: 0x170038BD RID: 14525
		// (get) Token: 0x06006DAE RID: 28078 RVA: 0x0061C8C0 File Offset: 0x0061AAC0
		// (set) Token: 0x06006DAF RID: 28079 RVA: 0x0061C974 File Offset: 0x0061AB74
		internal bool RadErgoCfgGeneralMAXSVECTOR_A22297_HiddenStatic
		{
			get
			{
				short num = (short)1575221792;
				short num2 = num;
				num = (short)1053882912;
				switch (num2 == num)
				{
				}
				num = (short)435552257;
				if (num != 0)
				{
				}
				num = (short)2065235968;
				short num3 = num;
				num = (short)1090977792;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMAXSVECTOR_A22297.HiddenStatic;
			}
			set
			{
				short num = (short)1225654273;
				if (num != 0)
				{
				}
				num = (short)1673682229;
				short num2 = num;
				num = (short)1744526645;
				switch (num2 == num)
				{
				}
				num = (short)367001600;
				short num3 = num;
				num = (short)934346752;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralMAXSVECTOR_A22297.HiddenStatic = value;
			}
		}

		// Token: 0x170038BE RID: 14526
		// (get) Token: 0x06006DB0 RID: 28080 RVA: 0x0061CA28 File Offset: 0x0061AC28
		// (set) Token: 0x06006DB1 RID: 28081 RVA: 0x0061CAE0 File Offset: 0x0061ACE0
		internal bool RadErgoCfgGeneralMAXSVECTOR_A22297_HiddenDynamic
		{
			get
			{
				short num = (short)2076901377;
				if (num != 0)
				{
				}
				num = (short)865259049;
				short num2 = num;
				num = (short)974442025;
				switch (num2 == num)
				{
				}
				num = (short)982319104;
				short num3 = num;
				num = (short)1332805632;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMAXSVECTOR_A22297.HiddenDynamic;
			}
			set
			{
				short num = (short)1380088975;
				short num2 = num;
				num = (short)534215823;
				switch (num2 == num)
				{
				}
				num = (short)936443905;
				if (num != 0)
				{
				}
				num = (short)652804096;
				short num3 = num;
				num = (short)956563456;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralMAXSVECTOR_A22297.HiddenDynamic = value;
			}
		}

		// Token: 0x170038BF RID: 14527
		// (get) Token: 0x06006DB2 RID: 28082 RVA: 0x0061CB98 File Offset: 0x0061AD98
		public bool RadErgoCfgGeneralMAXSVECTOR_A22297_HasDiffs
		{
			get
			{
				short num = (short)122533557;
				short num2 = num;
				num = (short)948745909;
				switch (num2 == num)
				{
				}
				num = (short)637665281;
				if (num != 0)
				{
				}
				num = (short)1797324800;
				short num3 = num;
				num = (short)69271552;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMAXSVECTOR_A22297._HasDiffs;
			}
		}

		// Token: 0x170038C0 RID: 14528
		// (get) Token: 0x06006DB3 RID: 28083 RVA: 0x0061CC4C File Offset: 0x0061AE4C
		// (set) Token: 0x06006DB4 RID: 28084 RVA: 0x0061CD00 File Offset: 0x0061AF00
		public string ExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686Value
		{
			get
			{
				short num = (short)975634433;
				if (num != 0)
				{
				}
				num = (short)1974445313;
				short num2 = num;
				num = (short)1973855489;
				switch (num2 == num)
				{
				}
				num = (short)1344602112;
				short num3 = num;
				num = (short)1029701632;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686.Value;
			}
			set
			{
				short num = (short)943137437;
				short num2 = num;
				num = (short)1570316957;
				switch (num2 == num)
				{
				}
				num = (short)473169921;
				if (num != 0)
				{
				}
				num = (short)2052718592;
				short num3 = num;
				num = (short)624427008;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686.Value = value;
			}
		}

		// Token: 0x170038C1 RID: 14529
		// (get) Token: 0x06006DB5 RID: 28085 RVA: 0x0061CDB4 File Offset: 0x0061AFB4
		public global::AcpBusinessLayer.AcpField<string> ExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686
		{
			get
			{
				short num = (short)1442385354;
				short num2 = num;
				num = (short)1282018762;
				switch (num2 == num)
				{
				}
				num = (short)1179975681;
				if (num != 0)
				{
				}
				num = (short)847511552;
				short num3 = num;
				num = (short)235536384;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686;
			}
		}

		// Token: 0x170038C2 RID: 14530
		// (get) Token: 0x06006DB6 RID: 28086 RVA: 0x0061CE64 File Offset: 0x0061B064
		// (set) Token: 0x06006DB7 RID: 28087 RVA: 0x0061CF18 File Offset: 0x0061B118
		public string ExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686_UIValue
		{
			get
			{
				short num = (short)1748771936;
				short num2 = num;
				num = (short)2058167392;
				switch (num2 == num)
				{
				}
				num = (short)194838529;
				if (num != 0)
				{
				}
				num = (short)799735808;
				short num3 = num;
				num = (short)51511296;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686.Value;
			}
			set
			{
				short num = (short)638582785;
				if (num != 0)
				{
				}
				num = (short)1358906641;
				short num2 = num;
				num = (short)1260537105;
				switch (num2 == num)
				{
				}
				num = (short)526843904;
				short num3 = num;
				num = (short)898039808;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686.Value = value;
			}
		}

		// Token: 0x170038C3 RID: 14531
		// (get) Token: 0x06006DB8 RID: 28088 RVA: 0x0061CFD0 File Offset: 0x0061B1D0
		// (set) Token: 0x06006DB9 RID: 28089 RVA: 0x0061D084 File Offset: 0x0061B284
		public bool ExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686_Applicable
		{
			get
			{
				short num = (short)2012231034;
				short num2 = num;
				num = (short)833631610;
				switch (num2 == num)
				{
				}
				num = (short)1998192641;
				if (num != 0)
				{
				}
				num = (short)970260480;
				short num3 = num;
				num = (short)1343029248;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686.Applicable;
			}
			set
			{
				short num = (short)1307269540;
				short num2 = num;
				num = (short)80566692;
				switch (num2 == num)
				{
				}
				num = (short)736886785;
				if (num != 0)
				{
				}
				num = (short)332988416;
				short num3 = num;
				num = (short)76152832;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686.Applicable = value;
			}
		}

		// Token: 0x170038C4 RID: 14532
		// (get) Token: 0x06006DBA RID: 28090 RVA: 0x0061D138 File Offset: 0x0061B338
		// (set) Token: 0x06006DBB RID: 28091 RVA: 0x0061D1EC File Offset: 0x0061B3EC
		public bool ExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686_Valid
		{
			get
			{
				short num = (short)1451093700;
				short num2 = num;
				num = (short)1033039556;
				switch (num2 == num)
				{
				}
				num = (short)897253377;
				if (num != 0)
				{
				}
				num = (short)249626624;
				short num3 = num;
				num = (short)1825439744;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686.Valid;
			}
			set
			{
				short num = (short)895188932;
				short num2 = num;
				num = (short)747077572;
				switch (num2 == num)
				{
				}
				num = (short)930873344;
				if (num != 0)
				{
				}
				num = (short)458293248;
				short num3 = num;
				num = (short)52887553;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686.Valid = value;
			}
		}

		// Token: 0x170038C5 RID: 14533
		// (get) Token: 0x06006DBC RID: 28092 RVA: 0x0061D2A4 File Offset: 0x0061B4A4
		// (set) Token: 0x06006DBD RID: 28093 RVA: 0x0061D358 File Offset: 0x0061B558
		public bool ExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686_Visible
		{
			get
			{
				short num = (short)477715822;
				short num2 = num;
				num = (short)1711955310;
				switch (num2 == num)
				{
				}
				num = (short)1268056065;
				if (num != 0)
				{
				}
				num = (short)171048960;
				short num3 = num;
				num = (short)1900740608;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686.Visible;
			}
			set
			{
				short num = (short)274600147;
				short num2 = num;
				num = (short)259395795;
				switch (num2 == num)
				{
				}
				num = (short)641204224;
				if (num != 0)
				{
				}
				num = (short)2050949120;
				short num3 = num;
				num = (short)407502849;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686.Visible = value;
			}
		}

		// Token: 0x170038C6 RID: 14534
		// (get) Token: 0x06006DBE RID: 28094 RVA: 0x0061D410 File Offset: 0x0061B610
		// (set) Token: 0x06006DBF RID: 28095 RVA: 0x0061D4C8 File Offset: 0x0061B6C8
		public bool ExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686_Editable
		{
			get
			{
				short num = (short)782966261;
				short num2 = num;
				num = (short)1758469621;
				switch (num2 == num)
				{
				}
				num = (short)52363264;
				if (num != 0)
				{
				}
				num = (short)486080512;
				short num3 = num;
				num = (short)680919041;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686.Editable;
			}
			set
			{
				short num = (short)425270482;
				short num2 = num;
				num = (short)146480338;
				switch (num2 == num)
				{
				}
				num = (short)246087680;
				if (num != 0)
				{
				}
				num = (short)279576576;
				short num3 = num;
				num = (short)499253249;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686.Editable = value;
			}
		}

		// Token: 0x170038C7 RID: 14535
		// (get) Token: 0x06006DC0 RID: 28096 RVA: 0x0061D57C File Offset: 0x0061B77C
		internal string ExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686_UILabel
		{
			get
			{
				short num = (short)639134264;
				short num2 = num;
				num = (short)10316344;
				switch (num2 == num)
				{
				}
				num = (short)831324161;
				if (num != 0)
				{
				}
				num = (short)1051459584;
				short num3 = num;
				num = (short)911474688;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686.UIName;
			}
		}

		// Token: 0x170038C8 RID: 14536
		// (get) Token: 0x06006DC1 RID: 28097 RVA: 0x0061D630 File Offset: 0x0061B830
		// (set) Token: 0x06006DC2 RID: 28098 RVA: 0x0061D6E4 File Offset: 0x0061B8E4
		internal bool ExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686_HiddenStatic
		{
			get
			{
				short num = (short)29797415;
				short num2 = num;
				num = (short)2070195239;
				switch (num2 == num)
				{
				}
				num = (short)608174081;
				if (num != 0)
				{
				}
				num = (short)1302593536;
				short num3 = num;
				num = (short)35454976;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686.HiddenStatic;
			}
			set
			{
				short num = (short)91593401;
				short num2 = num;
				num = (short)1912117945;
				switch (num2 == num)
				{
				}
				num = (short)11403264;
				if (num != 0)
				{
				}
				num = (short)1859321856;
				short num3 = num;
				num = (short)1051852801;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686.HiddenStatic = value;
			}
		}

		// Token: 0x170038C9 RID: 14537
		// (get) Token: 0x06006DC3 RID: 28099 RVA: 0x0061D798 File Offset: 0x0061B998
		// (set) Token: 0x06006DC4 RID: 28100 RVA: 0x0061D850 File Offset: 0x0061BA50
		internal bool ExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686_HiddenDynamic
		{
			get
			{
				short num = (short)1442014066;
				short num2 = num;
				num = (short)1118790514;
				switch (num2 == num)
				{
				}
				num = (short)883228672;
				if (num != 0)
				{
				}
				num = (short)394199040;
				short num3 = num;
				num = (short)1593311233;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686.HiddenDynamic;
			}
			set
			{
				short num = (short)1342183951;
				short num2 = num;
				num = (short)1583946255;
				switch (num2 == num)
				{
				}
				num = (short)1036517377;
				if (num != 0)
				{
				}
				num = (short)233701376;
				short num3 = num;
				num = (short)640548864;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686.HiddenDynamic = value;
			}
		}

		// Token: 0x170038CA RID: 14538
		// (get) Token: 0x06006DC5 RID: 28101 RVA: 0x0061D908 File Offset: 0x0061BB08
		public bool ExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686_HasDiffs
		{
			get
			{
				short num = (short)1127350273;
				if (num != 0)
				{
				}
				num = (short)1044944;
				short num2 = num;
				num = (short)1748496848;
				switch (num2 == num)
				{
				}
				num = (short)1490354176;
				short num3 = num;
				num = (short)1106051072;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686._HasDiffs;
			}
		}

		// Token: 0x170038CB RID: 14539
		// (get) Token: 0x06006DC6 RID: 28102 RVA: 0x0061D9BC File Offset: 0x0061BBBC
		// (set) Token: 0x06006DC7 RID: 28103 RVA: 0x0061DA74 File Offset: 0x0061BC74
		public string ExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687Value
		{
			get
			{
				short num = (short)1669555689;
				short num2 = num;
				num = (short)1037264361;
				switch (num2 == num)
				{
				}
				num = (short)1281818625;
				if (num != 0)
				{
				}
				num = (short)1292959744;
				short num3 = num;
				num = (short)1169817600;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687.Value;
			}
			set
			{
				short num = (short)1730128431;
				short num2 = num;
				num = (short)1834592815;
				switch (num2 == num)
				{
				}
				num = (short)1669791745;
				if (num != 0)
				{
				}
				num = (short)890961920;
				short num3 = num;
				num = (short)855703552;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687.Value = value;
			}
		}

		// Token: 0x170038CC RID: 14540
		// (get) Token: 0x06006DC8 RID: 28104 RVA: 0x0061DB2C File Offset: 0x0061BD2C
		public global::AcpBusinessLayer.AcpField<string> ExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687
		{
			get
			{
				short num = (short)967442433;
				if (num != 0)
				{
				}
				num = (short)1969800054;
				short num2 = num;
				num = (short)110936950;
				switch (num2 == num)
				{
				}
				num = (short)1119420416;
				short num3 = num;
				num = (short)2038366208;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687;
			}
		}

		// Token: 0x170038CD RID: 14541
		// (get) Token: 0x06006DC9 RID: 28105 RVA: 0x0061DBDC File Offset: 0x0061BDDC
		// (set) Token: 0x06006DCA RID: 28106 RVA: 0x0061DC90 File Offset: 0x0061BE90
		public string ExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687_UIValue
		{
			get
			{
				short num = (short)626458625;
				if (num != 0)
				{
				}
				num = (short)260025832;
				short num2 = num;
				num = (short)954969576;
				switch (num2 == num)
				{
				}
				num = (short)1644298240;
				short num3 = num;
				num = (short)116654080;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687.Value;
			}
			set
			{
				short num = (short)1501082923;
				short num2 = num;
				num = (short)978433323;
				switch (num2 == num)
				{
				}
				num = (short)61276161;
				if (num != 0)
				{
				}
				num = (short)742588416;
				short num3 = num;
				num = (short)1154547712;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687.Value = value;
			}
		}

		// Token: 0x170038CE RID: 14542
		// (get) Token: 0x06006DCB RID: 28107 RVA: 0x0061DD48 File Offset: 0x0061BF48
		// (set) Token: 0x06006DCC RID: 28108 RVA: 0x0061DE00 File Offset: 0x0061C000
		public bool ExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687_Applicable
		{
			get
			{
				short num = (short)639067289;
				short num2 = num;
				num = (short)49439897;
				switch (num2 == num)
				{
				}
				num = (short)1480065025;
				if (num != 0)
				{
				}
				num = (short)2038890496;
				short num3 = num;
				num = (short)548864000;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687.Applicable;
			}
			set
			{
				short num = (short)1877118671;
				short num2 = num;
				num = (short)104894159;
				switch (num2 == num)
				{
				}
				num = (short)1758986240;
				if (num != 0)
				{
				}
				num = (short)440991744;
				short num3 = num;
				num = (short)1722744833;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687.Applicable = value;
			}
		}

		// Token: 0x170038CF RID: 14543
		// (get) Token: 0x06006DCD RID: 28109 RVA: 0x0061DEB8 File Offset: 0x0061C0B8
		// (set) Token: 0x06006DCE RID: 28110 RVA: 0x0061DF6C File Offset: 0x0061C16C
		public bool ExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687_Valid
		{
			get
			{
				short num = (short)1107540564;
				short num2 = num;
				num = (short)965392980;
				switch (num2 == num)
				{
				}
				num = (short)491388929;
				if (num != 0)
				{
				}
				num = (short)1078263808;
				short num3 = num;
				num = (short)1201143808;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687.Valid;
			}
			set
			{
				short num = (short)559623305;
				short num2 = num;
				num = (short)1868967049;
				switch (num2 == num)
				{
				}
				num = (short)312934401;
				if (num != 0)
				{
				}
				num = (short)2077294592;
				short num3 = num;
				num = (short)913047552;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687.Valid = value;
			}
		}

		// Token: 0x170038D0 RID: 14544
		// (get) Token: 0x06006DCF RID: 28111 RVA: 0x0061E020 File Offset: 0x0061C220
		// (set) Token: 0x06006DD0 RID: 28112 RVA: 0x0061E0D4 File Offset: 0x0061C2D4
		public bool ExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687_Visible
		{
			get
			{
				short num = (short)1510998017;
				if (num != 0)
				{
				}
				num = (short)1902325145;
				short num2 = num;
				num = (short)795291033;
				switch (num2 == num)
				{
				}
				num = (short)2085814272;
				short num3 = num;
				num = (short)724107264;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687.Visible;
			}
			set
			{
				short num = (short)1270426056;
				short num2 = num;
				num = (short)1563371976;
				switch (num2 == num)
				{
				}
				num = (short)1853095937;
				if (num != 0)
				{
				}
				num = (short)1738670080;
				short num3 = num;
				num = (short)1446117376;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687.Visible = value;
			}
		}

		// Token: 0x170038D1 RID: 14545
		// (get) Token: 0x06006DD1 RID: 28113 RVA: 0x0061E18C File Offset: 0x0061C38C
		// (set) Token: 0x06006DD2 RID: 28114 RVA: 0x0061E240 File Offset: 0x0061C440
		public bool ExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687_Editable
		{
			get
			{
				short num = (short)674809600;
				short num2 = num;
				num = (short)193644288;
				switch (num2 == num)
				{
				}
				num = (short)1975189505;
				if (num != 0)
				{
				}
				num = (short)2102657024;
				short num3 = num;
				num = (short)491126784;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687.Editable;
			}
			set
			{
				short num = (short)362688365;
				short num2 = num;
				num = (short)1373122413;
				switch (num2 == num)
				{
				}
				num = (short)384368641;
				if (num != 0)
				{
				}
				num = (short)672661504;
				short num3 = num;
				num = (short)2027028480;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687.Editable = value;
			}
		}

		// Token: 0x170038D2 RID: 14546
		// (get) Token: 0x06006DD3 RID: 28115 RVA: 0x0061E2F8 File Offset: 0x0061C4F8
		internal string ExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687_UILabel
		{
			get
			{
				short num = (short)1102527592;
				short num2 = num;
				num = (short)863452264;
				switch (num2 == num)
				{
				}
				num = (short)479657985;
				if (num != 0)
				{
				}
				num = (short)267517952;
				short num3 = num;
				num = (short)1463418880;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687.UIName;
			}
		}

		// Token: 0x170038D3 RID: 14547
		// (get) Token: 0x06006DD4 RID: 28116 RVA: 0x0061E3AC File Offset: 0x0061C5AC
		// (set) Token: 0x06006DD5 RID: 28117 RVA: 0x0061E460 File Offset: 0x0061C660
		internal bool ExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687_HiddenStatic
		{
			get
			{
				short num = (short)2015886275;
				short num2 = num;
				num = (short)445774787;
				switch (num2 == num)
				{
				}
				num = (short)1235812352;
				if (num != 0)
				{
				}
				num = (short)1789984768;
				short num3 = num;
				num = (short)583794689;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687.HiddenStatic;
			}
			set
			{
				short num = (short)528083417;
				short num2 = num;
				num = (short)247851481;
				switch (num2 == num)
				{
				}
				num = (short)261160961;
				if (num != 0)
				{
				}
				num = (short)353828864;
				short num3 = num;
				num = (short)172425216;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687.HiddenStatic = value;
			}
		}

		// Token: 0x170038D4 RID: 14548
		// (get) Token: 0x06006DD6 RID: 28118 RVA: 0x0061E514 File Offset: 0x0061C714
		// (set) Token: 0x06006DD7 RID: 28119 RVA: 0x0061E5C8 File Offset: 0x0061C7C8
		internal bool ExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687_HiddenDynamic
		{
			get
			{
				short num = (short)534548352;
				short num2 = num;
				num = (short)2047250304;
				switch (num2 == num)
				{
				}
				num = (short)245628928;
				if (num != 0)
				{
				}
				num = (short)1551302656;
				short num3 = num;
				num = (short)549715969;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687.HiddenDynamic;
			}
			set
			{
				short num = (short)696060538;
				short num2 = num;
				num = (short)51907194;
				switch (num2 == num)
				{
				}
				num = (short)1361510400;
				if (num != 0)
				{
				}
				num = (short)278200320;
				short num3 = num;
				num = (short)1080885249;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687.HiddenDynamic = value;
			}
		}

		// Token: 0x170038D5 RID: 14549
		// (get) Token: 0x06006DD8 RID: 28120 RVA: 0x0061E680 File Offset: 0x0061C880
		public bool ExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687_HasDiffs
		{
			get
			{
				short num = (short)1294467073;
				if (num != 0)
				{
				}
				num = (short)833752664;
				short num2 = num;
				num = (short)1227820632;
				switch (num2 == num)
				{
				}
				num = (short)1845886976;
				short num3 = num;
				num = (short)774504448;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687._HasDiffs;
			}
		}

		// Token: 0x170038D6 RID: 14550
		// (get) Token: 0x06006DD9 RID: 28121 RVA: 0x0061E734 File Offset: 0x0061C934
		// (set) Token: 0x06006DDA RID: 28122 RVA: 0x0061E7E8 File Offset: 0x0061C9E8
		public string ExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688Value
		{
			get
			{
				short num = (short)2015689032;
				short num2 = num;
				num = (short)1412757832;
				switch (num2 == num)
				{
				}
				num = (short)563281920;
				if (num != 0)
				{
				}
				num = (short)679673856;
				short num3 = num;
				num = (short)1409024001;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688.Value;
			}
			set
			{
				short num = (short)746971290;
				short num2 = num;
				num = (short)1887101082;
				switch (num2 == num)
				{
				}
				num = (short)1835466752;
				if (num != 0)
				{
				}
				num = (short)435748864;
				short num3 = num;
				num = (short)1078853633;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688.Value = value;
			}
		}

		// Token: 0x170038D7 RID: 14551
		// (get) Token: 0x06006DDB RID: 28123 RVA: 0x0061E8A0 File Offset: 0x0061CAA0
		public global::AcpBusinessLayer.AcpField<string> ExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688
		{
			get
			{
				short num = (short)894038964;
				short num2 = num;
				num = (short)1221915572;
				switch (num2 == num)
				{
				}
				num = (short)1065680897;
				if (num != 0)
				{
				}
				num = (short)874774528;
				short num3 = num;
				num = (short)1874657280;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688;
			}
		}

		// Token: 0x170038D8 RID: 14552
		// (get) Token: 0x06006DDC RID: 28124 RVA: 0x0061E950 File Offset: 0x0061CB50
		// (set) Token: 0x06006DDD RID: 28125 RVA: 0x0061EA08 File Offset: 0x0061CC08
		public string ExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688_UIValue
		{
			get
			{
				short num = (short)382696510;
				short num2 = num;
				num = (short)929528894;
				switch (num2 == num)
				{
				}
				num = (short)720240641;
				if (num != 0)
				{
				}
				num = (short)1857093632;
				short num3 = num;
				num = (short)654508032;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688.Value;
			}
			set
			{
				short num = (short)647693904;
				short num2 = num;
				num = (short)1384187472;
				switch (num2 == num)
				{
				}
				num = (short)1369309184;
				if (num != 0)
				{
				}
				num = (short)660209664;
				short num3 = num;
				num = (short)1576861697;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688.Value = value;
			}
		}

		// Token: 0x170038D9 RID: 14553
		// (get) Token: 0x06006DDE RID: 28126 RVA: 0x0061EABC File Offset: 0x0061CCBC
		// (set) Token: 0x06006DDF RID: 28127 RVA: 0x0061EB70 File Offset: 0x0061CD70
		public bool ExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688_Applicable
		{
			get
			{
				short num = (short)1491949020;
				short num2 = num;
				num = (short)1574524380;
				switch (num2 == num)
				{
				}
				num = (short)1378811905;
				if (num != 0)
				{
				}
				num = (short)152829952;
				short num3 = num;
				num = (short)1681391616;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688.Applicable;
			}
			set
			{
				short num = (short)1450411800;
				short num2 = num;
				num = (short)1250789144;
				switch (num2 == num)
				{
				}
				num = (short)268697601;
				if (num != 0)
				{
				}
				num = (short)1040187392;
				short num3 = num;
				num = (short)462422016;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688.Applicable = value;
			}
		}

		// Token: 0x170038DA RID: 14554
		// (get) Token: 0x06006DE0 RID: 28128 RVA: 0x0061EC28 File Offset: 0x0061CE28
		// (set) Token: 0x06006DE1 RID: 28129 RVA: 0x0061ECDC File Offset: 0x0061CEDC
		public bool ExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688_Valid
		{
			get
			{
				short num = (short)602234141;
				short num2 = num;
				num = (short)897080605;
				switch (num2 == num)
				{
				}
				num = (short)627310593;
				if (num != 0)
				{
				}
				num = (short)1659961344;
				short num3 = num;
				num = (short)956301312;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688.Valid;
			}
			set
			{
				short num = (short)106104483;
				short num2 = num;
				num = (short)1584596643;
				switch (num2 == num)
				{
				}
				num = (short)377356289;
				if (num != 0)
				{
				}
				num = (short)1948188672;
				short num3 = num;
				num = (short)1571225600;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688.Valid = value;
			}
		}

		// Token: 0x170038DB RID: 14555
		// (get) Token: 0x06006DE2 RID: 28130 RVA: 0x0061ED94 File Offset: 0x0061CF94
		// (set) Token: 0x06006DE3 RID: 28131 RVA: 0x0061EE4C File Offset: 0x0061D04C
		public bool ExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688_Visible
		{
			get
			{
				short num = (short)1835464651;
				short num2 = num;
				num = (short)664401867;
				switch (num2 == num)
				{
				}
				num = (short)222560257;
				if (num != 0)
				{
				}
				num = (short)246743040;
				short num3 = num;
				num = (short)340262912;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688.Visible;
			}
			set
			{
				short num = (short)1414463489;
				if (num != 0)
				{
				}
				num = (short)1998058455;
				short num2 = num;
				num = (short)2140206039;
				switch (num2 == num)
				{
				}
				num = (short)1863385088;
				short num3 = num;
				num = (short)1003552768;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688.Visible = value;
			}
		}

		// Token: 0x170038DC RID: 14556
		// (get) Token: 0x06006DE4 RID: 28132 RVA: 0x0061EF04 File Offset: 0x0061D104
		// (set) Token: 0x06006DE5 RID: 28133 RVA: 0x0061EFB8 File Offset: 0x0061D1B8
		public bool ExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688_Editable
		{
			get
			{
				short num = (short)1729912230;
				short num2 = num;
				num = (short)2078236070;
				switch (num2 == num)
				{
				}
				num = (short)1516503041;
				if (num != 0)
				{
				}
				num = (short)1354760192;
				short num3 = num;
				num = (short)1491992576;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688.Editable;
			}
			set
			{
				short num = (short)2079495853;
				short num2 = num;
				num = (short)611817133;
				switch (num2 == num)
				{
				}
				num = (short)992215041;
				if (num != 0)
				{
				}
				num = (short)1269301248;
				short num3 = num;
				num = (short)2031616;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688.Editable = value;
			}
		}

		// Token: 0x170038DD RID: 14557
		// (get) Token: 0x06006DE6 RID: 28134 RVA: 0x0061F06C File Offset: 0x0061D26C
		internal string ExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688_UILabel
		{
			get
			{
				short num = (short)1848460069;
				short num2 = num;
				num = (short)1367950117;
				switch (num2 == num)
				{
				}
				num = (short)625672193;
				if (num != 0)
				{
				}
				num = (short)156565504;
				short num3 = num;
				num = (short)537264128;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688.UIName;
			}
		}

		// Token: 0x170038DE RID: 14558
		// (get) Token: 0x06006DE7 RID: 28135 RVA: 0x0061F124 File Offset: 0x0061D324
		// (set) Token: 0x06006DE8 RID: 28136 RVA: 0x0061F1D8 File Offset: 0x0061D3D8
		internal bool ExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688_HiddenStatic
		{
			get
			{
				short num = (short)6881281;
				if (num != 0)
				{
				}
				num = (short)1667292249;
				short num2 = num;
				num = (short)1531436121;
				switch (num2 == num)
				{
				}
				num = (short)1815150592;
				short num3 = num;
				num = (short)97976320;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688.HiddenStatic;
			}
			set
			{
				short num = (short)1118312102;
				short num2 = num;
				num = (short)1924732582;
				switch (num2 == num)
				{
				}
				num = (short)1780088832;
				if (num != 0)
				{
				}
				num = (short)557645824;
				short num3 = num;
				num = (short)1150353409;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688.HiddenStatic = value;
			}
		}

		// Token: 0x170038DF RID: 14559
		// (get) Token: 0x06006DE9 RID: 28137 RVA: 0x0061F28C File Offset: 0x0061D48C
		// (set) Token: 0x06006DEA RID: 28138 RVA: 0x0061F344 File Offset: 0x0061D544
		internal bool ExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688_HiddenDynamic
		{
			get
			{
				short num = (short)1454967941;
				short num2 = num;
				num = (short)2065370245;
				switch (num2 == num)
				{
				}
				num = (short)1598095360;
				if (num != 0)
				{
				}
				num = (short)1593835520;
				short num3 = num;
				num = (short)703201281;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688.HiddenDynamic;
			}
			set
			{
				short num = (short)209649665;
				if (num != 0)
				{
				}
				num = (short)1923473803;
				short num2 = num;
				num = (short)665706891;
				switch (num2 == num)
				{
				}
				num = (short)1848115200;
				short num3 = num;
				num = (short)413138944;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688.HiddenDynamic = value;
			}
		}

		// Token: 0x170038E0 RID: 14560
		// (get) Token: 0x06006DEB RID: 28139 RVA: 0x0061F3F8 File Offset: 0x0061D5F8
		public bool ExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688_HasDiffs
		{
			get
			{
				short num = (short)378303669;
				short num2 = num;
				num = (short)1621652661;
				switch (num2 == num)
				{
				}
				num = (short)1382612993;
				if (num != 0)
				{
				}
				num = (short)836763648;
				short num3 = num;
				num = (short)726925312;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688._HasDiffs;
			}
		}

		// Token: 0x170038E1 RID: 14561
		// (get) Token: 0x06006DEC RID: 28140 RVA: 0x0061F4AC File Offset: 0x0061D6AC
		// (set) Token: 0x06006DED RID: 28141 RVA: 0x0061F560 File Offset: 0x0061D760
		public int ExtMicNsRdGenACCESSORYPASSFILTERSTART_42689Value
		{
			get
			{
				short num = (short)1440569503;
				short num2 = num;
				num = (short)1609193631;
				switch (num2 == num)
				{
				}
				num = (short)2099511297;
				if (num != 0)
				{
				}
				num = (short)1268449280;
				short num3 = num;
				num = (short)718733312;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.Value;
			}
			set
			{
				short num = (short)1009762247;
				short num2 = num;
				num = (short)461815751;
				switch (num2 == num)
				{
				}
				num = (short)133955584;
				if (num != 0)
				{
				}
				num = (short)1092222976;
				short num3 = num;
				num = (short)484638721;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.Value = value;
			}
		}

		// Token: 0x170038E2 RID: 14562
		// (get) Token: 0x06006DEE RID: 28142 RVA: 0x0061F618 File Offset: 0x0061D818
		public global::AcpBusinessLayer.AcpSimpleRangeField ExtMicNsRdGenACCESSORYPASSFILTERSTART_42689
		{
			get
			{
				short num = (short)1694217793;
				short num2 = num;
				num = (short)1821947457;
				switch (num2 == num)
				{
				}
				num = (short)429654017;
				if (num != 0)
				{
				}
				num = (short)911015936;
				short num3 = num;
				num = (short)1924136960;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689;
			}
		}

		// Token: 0x170038E3 RID: 14563
		// (get) Token: 0x06006DEF RID: 28143 RVA: 0x0061F6C8 File Offset: 0x0061D8C8
		// (set) Token: 0x06006DF0 RID: 28144 RVA: 0x0061F77C File Offset: 0x0061D97C
		public string ExtMicNsRdGenACCESSORYPASSFILTERSTART_42689_UIValue
		{
			get
			{
				short num = (short)1498512165;
				short num2 = num;
				num = (short)68385573;
				switch (num2 == num)
				{
				}
				num = (short)1367539713;
				if (num != 0)
				{
				}
				num = (short)1167392768;
				short num3 = num;
				num = (short)1818427392;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.UIValue;
			}
			set
			{
				short num = (short)198978843;
				short num2 = num;
				num = (short)169422107;
				switch (num2 == num)
				{
				}
				num = (short)1907884032;
				if (num != 0)
				{
				}
				num = (short)647233536;
				short num3 = num;
				num = (short)1584857089;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.UIValue = value;
			}
		}

		// Token: 0x170038E4 RID: 14564
		// (get) Token: 0x06006DF1 RID: 28145 RVA: 0x0061F830 File Offset: 0x0061DA30
		// (set) Token: 0x06006DF2 RID: 28146 RVA: 0x0061F8E4 File Offset: 0x0061DAE4
		internal int ExtMicNsRdGenACCESSORYPASSFILTERSTART_42689Min
		{
			get
			{
				short num = (short)2088812842;
				short num2 = num;
				num = (short)1921237290;
				switch (num2 == num)
				{
				}
				num = (short)599195649;
				if (num != 0)
				{
				}
				num = (short)378077184;
				short num3 = num;
				num = (short)431292416;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.Min;
			}
			set
			{
				short num = (short)1527404028;
				short num2 = num;
				num = (short)1324045820;
				switch (num2 == num)
				{
				}
				num = (short)2083389441;
				if (num != 0)
				{
				}
				num = (short)594870272;
				short num3 = num;
				num = (short)212402176;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.Min = value;
			}
		}

		// Token: 0x170038E5 RID: 14565
		// (get) Token: 0x06006DF3 RID: 28147 RVA: 0x0061F998 File Offset: 0x0061DB98
		// (set) Token: 0x06006DF4 RID: 28148 RVA: 0x0061FA4C File Offset: 0x0061DC4C
		internal int ExtMicNsRdGenACCESSORYPASSFILTERSTART_42689Max
		{
			get
			{
				short num = (short)93230701;
				short num2 = num;
				num = (short)1742445;
				switch (num2 == num)
				{
				}
				num = (short)1401815040;
				if (num != 0)
				{
				}
				num = (short)416612352;
				short num3 = num;
				num = (short)1670905857;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.Max;
			}
			set
			{
				short num = (short)1655038310;
				short num2 = num;
				num = (short)714203494;
				switch (num2 == num)
				{
				}
				num = (short)381288449;
				if (num != 0)
				{
				}
				num = (short)1251475456;
				short num3 = num;
				num = (short)1214447616;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.Max = value;
			}
		}

		// Token: 0x170038E6 RID: 14566
		// (get) Token: 0x06006DF5 RID: 28149 RVA: 0x0061FB00 File Offset: 0x0061DD00
		// (set) Token: 0x06006DF6 RID: 28150 RVA: 0x0061FBB4 File Offset: 0x0061DDB4
		internal int ExtMicNsRdGenACCESSORYPASSFILTERSTART_42689Step
		{
			get
			{
				short num = (short)654238093;
				short num2 = num;
				num = (short)1041162637;
				switch (num2 == num)
				{
				}
				num = (short)309919745;
				if (num != 0)
				{
				}
				num = (short)2027159552;
				short num3 = num;
				num = (short)1559166976;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.StepSize;
			}
			set
			{
				short num = (short)1310466318;
				short num2 = num;
				num = (short)564273422;
				switch (num2 == num)
				{
				}
				num = (short)1568342016;
				if (num != 0)
				{
				}
				num = (short)149422080;
				short num3 = num;
				num = (short)48037889;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.StepSize = value;
			}
		}

		// Token: 0x170038E7 RID: 14567
		// (get) Token: 0x06006DF7 RID: 28151 RVA: 0x0061FC68 File Offset: 0x0061DE68
		// (set) Token: 0x06006DF8 RID: 28152 RVA: 0x0061FD1C File Offset: 0x0061DF1C
		public bool ExtMicNsRdGenACCESSORYPASSFILTERSTART_42689_Applicable
		{
			get
			{
				short num = (short)1023049822;
				short num2 = num;
				num = (short)1022394462;
				switch (num2 == num)
				{
				}
				num = (short)785711104;
				if (num != 0)
				{
				}
				num = (short)2092695552;
				short num3 = num;
				num = (short)1141702657;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.Applicable;
			}
			set
			{
				short num = (short)1391008934;
				short num2 = num;
				num = (short)864033958;
				switch (num2 == num)
				{
				}
				num = (short)1640300545;
				if (num != 0)
				{
				}
				num = (short)708247552;
				short num3 = num;
				num = (short)1813774336;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.Applicable = value;
			}
		}

		// Token: 0x170038E8 RID: 14568
		// (get) Token: 0x06006DF9 RID: 28153 RVA: 0x0061FDD0 File Offset: 0x0061DFD0
		// (set) Token: 0x06006DFA RID: 28154 RVA: 0x0061FE84 File Offset: 0x0061E084
		public bool ExtMicNsRdGenACCESSORYPASSFILTERSTART_42689_Valid
		{
			get
			{
				short num = (short)894275646;
				short num2 = num;
				num = (short)665423934;
				switch (num2 == num)
				{
				}
				num = (short)1954611200;
				if (num != 0)
				{
				}
				num = (short)694091776;
				short num3 = num;
				num = (short)1466826753;
				if (num != 0)
				{
				}
				return this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.Valid;
			}
			set
			{
				short num = (short)1426674970;
				short num2 = num;
				num = (short)470897946;
				switch (num2 == num)
				{
				}
				num = (short)1793916928;
				if (num != 0)
				{
				}
				num = (short)601227264;
				short num3 = num;
				num = (short)1554513921;
				if (num != 0)
				{
				}
				this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.Valid = value;
			}
		}

		// Token: 0x170038E9 RID: 14569
		// (get) Token: 0x06006DFB RID: 28155 RVA: 0x0061FF3C File Offset: 0x0061E13C
		// (set) Token: 0x06006DFC RID: 28156 RVA: 0x0061FFF0 File Offset: 0x0061E1F0
		public bool ExtMicNsRdGenACCESSORYPASSFILTERSTART_42689_Visible
		{
			get
			{
				short num = (short)94380231;
				short num2 = num;
				num = (short)362422471;
				switch (num2 == num)
				{
				}
				num = (short)58785793;
				if (num != 0)
				{
				}
				num = (short)782172160;
				if (num != 0)
				{
				}
				num = (short)312410112;
				short num3 = num;
				return this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.Visible;
			}
			set
			{
				short num = (short)267653430;
				short num2 = num;
				num = (short)1894584630;
				switch (num2 == num)
				{
				}
				num = (short)1752039425;
				if (num != 0)
				{
				}
				num = (short)832962560;
				if (num != 0)
				{
				}
				num = (short)2092564480;
				short num3 = num;
				this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.Visible = value;
			}
		}

		// Token: 0x170038EA RID: 14570
		// (get) Token: 0x06006DFD RID: 28157 RVA: 0x006200A4 File Offset: 0x0061E2A4
		// (set) Token: 0x06006DFE RID: 28158 RVA: 0x00620154 File Offset: 0x0061E354
		public bool ExtMicNsRdGenACCESSORYPASSFILTERSTART_42689_Editable
		{
			get
			{
				short num = (short)15663105;
				if (num != 0)
				{
				}
				num = (short)2105635380;
				short num2 = num;
				num = (short)1339126324;
				switch (num2 == num)
				{
				}
				num = (short)710606848;
				if (num != 0)
				{
				}
				num = (short)1876295680;
				short num3 = num;
				return this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.Editable;
			}
			set
			{
				short num = (short)848244209;
				short num2 = num;
				num = (short)1121070577;
				switch (num2 == num)
				{
				}
				num = (short)838991872;
				if (num != 0)
				{
				}
				num = (short)322830337;
				if (num != 0)
				{
				}
				num = (short)573702144;
				short num3 = num;
				this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.Editable = value;
			}
		}

		// Token: 0x170038EB RID: 14571
		// (get) Token: 0x06006DFF RID: 28159 RVA: 0x00620208 File Offset: 0x0061E408
		internal string ExtMicNsRdGenACCESSORYPASSFILTERSTART_42689_UILabel
		{
			get
			{
				short num = (short)205896997;
				short num2 = num;
				num = (short)2095430949;
				switch (num2 == num)
				{
				}
				num = (short)329252865;
				if (num != 0)
				{
				}
				num = (short)1888681984;
				if (num != 0)
				{
				}
				num = (short)2044198912;
				short num3 = num;
				return this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.UIName;
			}
		}

		// Token: 0x170038EC RID: 14572
		// (get) Token: 0x06006E00 RID: 28160 RVA: 0x006202BC File Offset: 0x0061E4BC
		// (set) Token: 0x06006E01 RID: 28161 RVA: 0x00620370 File Offset: 0x0061E570
		internal bool ExtMicNsRdGenACCESSORYPASSFILTERSTART_42689_HiddenStatic
		{
			get
			{
				short num = (short)710170635;
				short num2 = num;
				num = (short)1421563915;
				switch (num2 == num)
				{
				}
				num = (short)2133000193;
				if (num != 0)
				{
				}
				num = (short)1737031680;
				if (num != 0)
				{
				}
				num = (short)1839857664;
				short num3 = num;
				return this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.HiddenStatic;
			}
			set
			{
				short num = (short)170012178;
				short num2 = num;
				num = (short)1893412370;
				switch (num2 == num)
				{
				}
				num = (short)746127361;
				if (num != 0)
				{
				}
				num = (short)1873412096;
				if (num != 0)
				{
				}
				num = (short)1685520384;
				short num3 = num;
				this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.HiddenStatic = value;
			}
		}

		// Token: 0x170038ED RID: 14573
		// (get) Token: 0x06006E02 RID: 28162 RVA: 0x00620424 File Offset: 0x0061E624
		// (set) Token: 0x06006E03 RID: 28163 RVA: 0x006204D8 File Offset: 0x0061E6D8
		internal bool ExtMicNsRdGenACCESSORYPASSFILTERSTART_42689_HiddenDynamic
		{
			get
			{
				short num = (short)285149052;
				short num2 = num;
				num = (short)237307772;
				switch (num2 == num)
				{
				}
				num = (short)273285121;
				if (num != 0)
				{
				}
				num = (short)270663680;
				if (num != 0)
				{
				}
				num = (short)1976893440;
				short num3 = num;
				return this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.HiddenDynamic;
			}
			set
			{
				short num = (short)730826796;
				short num2 = num;
				num = (short)599885868;
				switch (num2 == num)
				{
				}
				num = (short)1845624833;
				if (num != 0)
				{
				}
				num = (short)1078722560;
				if (num != 0)
				{
				}
				num = (short)16252928;
				short num3 = num;
				this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689.HiddenDynamic = value;
			}
		}

		// Token: 0x170038EE RID: 14574
		// (get) Token: 0x06006E04 RID: 28164 RVA: 0x0062058C File Offset: 0x0061E78C
		public bool ExtMicNsRdGenACCESSORYPASSFILTERSTART_42689_HasDiffs
		{
			get
			{
				short num = (short)1501872777;
				short num2 = num;
				num = (short)1744355977;
				switch (num2 == num)
				{
				}
				num = (short)706740224;
				if (num != 0)
				{
				}
				num = (short)1279918081;
				if (num != 0)
				{
				}
				num = (short)1820852224;
				short num3 = num;
				return this.extMicNsRdGenACCESSORYPASSFILTERSTART_42689._HasDiffs;
			}
		}

		// Token: 0x06006E05 RID: 28165 RVA: 0x00620644 File Offset: 0x0061E844
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)1383413937;
			short num2 = num;
			num = (short)564869297;
			global::AcpCommonLib.IAcpRecordset result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)101187584;
				if (num != 0)
				{
				}
				num = (short)1103495169;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_C1;
				}
				int num4;
				for (;;)
				{
					IL_7B:
					num = (short)1761083392;
					short num3 = num;
					switch (num4)
					{
					case 0:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)2059862019;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)1544159232;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						num = (short)813236225;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return result;
					case 4:
						if (base.ParentRecset != null)
						{
							num = (short)445054978;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					break;
				}
				IL_C1:
				result = null;
				num = (short)690094084;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_7B;
			}
			}
			return result;
		}

		// Token: 0x04002AD1 RID: 10961
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgGeneralEXPANSIONDEGREE_A22299;

		// Token: 0x04002AD2 RID: 10962
		private global::AcpBusinessLayer.AcpKeyField externalMicNoiseReductionProfileName_A22536;

		// Token: 0x04002AD3 RID: 10963
		private global::AcpBusinessLayer.AcpField<string> extMicNsRdGenDINCOUTPUTEQVECTOR_A37720;

		// Token: 0x04002AD4 RID: 10964
		private global::AcpBusinessLayer.AcpField<string> extMicNsRdGenDINCEPVECTOR_A37721;

		// Token: 0x04002AD5 RID: 10965
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A22302;

		// Token: 0x04002AD6 RID: 10966
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgGeneralINACTIVETHRESHDBQ8_A22305;

		// Token: 0x04002AD7 RID: 10967
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgGeneralNDIFFTHRESHDBQ8_A22307;

		// Token: 0x04002AD8 RID: 10968
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgGeneralRTHRESHDBQ8_A22308;

		// Token: 0x04002AD9 RID: 10969
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgGeneralSDIFFTHRESHDBQ8_A22306;

		// Token: 0x04002ADA RID: 10970
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgGeneralVADDETTHRESHDBQ8_A22303;

		// Token: 0x04002ADB RID: 10971
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgGeneralVADDETCOUNT_A22304;

		// Token: 0x04002ADC RID: 10972
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgGeneralMINGAIN_A22298;

		// Token: 0x04002ADD RID: 10973
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgGeneralDINCABFSS_A22300;

		// Token: 0x04002ADE RID: 10974
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgGeneralDINCEWINDNBANDS_A22301;

		// Token: 0x04002ADF RID: 10975
		private global::AcpBusinessLayer.AcpField<string> radErgoCfgGeneralMAXSVECTOR_A22297;

		// Token: 0x04002AE0 RID: 10976
		private global::AcpBusinessLayer.AcpField<string> extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686;

		// Token: 0x04002AE1 RID: 10977
		private global::AcpBusinessLayer.AcpField<string> extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687;

		// Token: 0x04002AE2 RID: 10978
		private global::AcpBusinessLayer.AcpField<string> extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688;

		// Token: 0x04002AE3 RID: 10979
		private global::AcpBusinessLayer.AcpSimpleRangeField extMicNsRdGenACCESSORYPASSFILTERSTART_42689;
	}
}
