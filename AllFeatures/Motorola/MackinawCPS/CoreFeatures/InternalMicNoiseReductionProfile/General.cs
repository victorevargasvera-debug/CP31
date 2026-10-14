using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile
{
	// Token: 0x02000252 RID: 594
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060068C8 RID: 26824 RVA: 0x005DD018 File Offset: 0x005DB218
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060068C9 RID: 26825 RVA: 0x005DD034 File Offset: 0x005DB234
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060068CA RID: 26826 RVA: 0x005DD04C File Offset: 0x005DB24C
		public override void Init()
		{
			int a_ = 11;
			short num = (short)62586880;
			short num2 = num;
			num = (short)2141523608;
			short num3 = num;
			num = (short)972689048;
			switch (num3 == num)
			{
			}
			num = (short)1783300096;
			if (num != 0)
			{
			}
			num = (short)184549377;
			if (num != 0)
			{
			}
			this.radErgoCfgGeneralEXPANSIONDEGREE_A21563 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("黋꿍듏韑ꛓ뇕럗駙뫛망꟟蟡諣菥髧诩胫꯭꣯ꋱ뗳룵꯷돹돻냽䓿䜁䌃吅䴇伉匋伍∏⌑ℓ―⬗", a_), global::CommonResources.AcgResources.ID_DWFEXPANSIONDEGREE, 0, 65535, null, null, 0, 1);
			this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.DataTransferOrder = 13;
			this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.ShowHexValue = true;
			this.internalMicNoiseReductionProfileName_A22535 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("藋ꃍ꓏럑ꛓ룕맗뛙釛럝菟곡诣迥鯧迩뻫语铯蟱音苵釷闹鋻껽狿洁戃漅搇漉䈋漍紏眑䬓圕⨗⠙⤛ⴝᔟ", a_), global::CommonResources.AcgResources.ID_RADIONOISEREDUCTIONPROFILENAME, 14, global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.LegacyTitles.InternalMicNoiseReductionProfileName_A22535LegacyTitles);
			this.internalMicNoiseReductionProfileName_A22535.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.internalMicNoiseReductionProfileName_A22535.DataTransferOrder = 24;
			this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("﯋裍雏铑郕黗鳙飝ꛟꓡ폣ꃥ껧곩\udbeb꣭뛯등쏳냵뻷볹쯻룽䛿䐁㌃䀅万䰉㬋䠍嘏向⌓倕帗尙⬛堝星搡ጣ急渧氩ᬫ栭瘯琱̳瀵縷簹଻砽ؿс獃E็౉筋ࡍᙏᑑ捓ၕṗ᱙歛ᡝ♟②卣⁥⹧Ⱪ孫⡭㙯㑱䍳ふ㹷㱹䭻㡽왿쒁뎃삅캇첉뮋좍횏풑ꎓ킕\ude97\udc99ꮛ\ud89d鎣鮫莳ﺷﲹ讻蚿蓁", a_), this, global::AllFeatures.CodeplugGuid.b("藋ꃍ꓏鿑뷓뗕雗꧙軛뫝꟟蟡諣ꋥꇧꓩ꿫ꇭꗯ꛱ꓳꏵ곷뿹귻ꣽ䗿䄁倃䤅娇唉䴋㴍✏┑┓⸕", a_), global::CommonResources.AcgResources.ID_DINCOUTPUTEQVECTOR, 124);
			this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718.DataTransferOrder = 25;
			this.intMicNsRdGenDINCEPVECTOR_A37719 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("ﳋﳍ훟훡퓣훥\ud8e7\udae9\udceb\udbed샯싱쓳웵죷죹쳻컽ヿ㈁㐃㘅㠇㨉㰋㸍‏∑␓☕⠗⨙Ⱋ⸝ဟሡᐣᘥᠧᨩᰫḭ/ȱгص࠷ਹ఻฽瀿牁瑃癅硇穉", a_), this, global::AllFeatures.CodeplugGuid.b("藋ꃍ꓏鿑뷓뗕雗꧙軛뫝꟟蟡諣ꋥꇧꓩ꿫꯭ꃯꓱ뇳뗵곷뗹껻ꇽ䇿㄁㌃ㄅ㤇㌉", a_), global::CommonResources.AcgResources.ID_DINCEPVECTOR, 64);
			this.intMicNsRdGenDINCEPVECTOR_A37719.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.intMicNsRdGenDINCEPVECTOR_A37719.DataTransferOrder = 26;
			this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566 = new global::AcpBusinessLayer.AcpSimpleRangeField(768, this, global::AllFeatures.CodeplugGuid.b("黋꿍듏韑ꛓ뇕럗駙뫛망꟟蟡諣菥髧诩胫ꛭ뿯꛱뛳돵맷럹룻믽哿嘁䰃吅䴇変䐋䨍刏䌑Ⱃ䤕夗⠙ⴛ⬝ᘟᐡ", a_), global::CommonResources.AcgResources.ID_HOTBEAMDETTHRESHDBQ8, 0, 65535, null, null, 0, 1);
			this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.DataTransferOrder = 15;
			this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.ShowHexValue = true;
			this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569 = new global::AcpBusinessLayer.AcpSimpleRangeField(6144, this, global::AllFeatures.CodeplugGuid.b("黋꿍듏韑ꛓ뇕럗駙뫛망꟟蟡諣菥髧诩胫꟭뻯돱럳ꋵ뇷곹맻꫽䣿倁䄃唅䀇三下弍⠏䴑唓␕⤗⼙⨛✝", a_), global::CommonResources.AcgResources.ID_BADMICINACTIVETHRESHDBQ8, 0, 65535, null, null, 0, 1);
			this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.DataTransferOrder = 18;
			this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.ShowHexValue = true;
			this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571 = new global::AcpBusinessLayer.AcpSimpleRangeField(2304, this, global::AllFeatures.CodeplugGuid.b("黋꿍듏韑ꛓ뇕럗駙뫛망꟟蟡諣菥髧诩胫ꃭ듯믱닳냵곷당껻믽叿䨁䀃䐅备㈉匋伍∏⌑ℓℕ⤗", a_), global::CommonResources.AcgResources.ID_BADMICNDIFFTHRESHDBQ8, 0, 65535, null, null, 0, 1);
			this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.DataTransferOrder = 20;
			this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.ShowHexValue = true;
			this.radErgoCfgGeneralRTHRESHDBQ8_A21572 = new global::AcpBusinessLayer.AcpSimpleRangeField(62976, this, global::AllFeatures.CodeplugGuid.b("黋꿍듏韑ꛓ뇕럗駙뫛망꟟蟡諣菥髧诩胫볭ꓯ뫱꛳돵꯷당룻볽凿㨁嬃䜅㨇㬉㤋㤍∏", a_), global::CommonResources.AcgResources.ID_BADMICRTHRESHDBQ8, 0, 65535, null, null, 0, 1);
			this.radErgoCfgGeneralRTHRESHDBQ8_A21572.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoCfgGeneralRTHRESHDBQ8_A21572.DataTransferOrder = 21;
			this.radErgoCfgGeneralRTHRESHDBQ8_A21572.ShowHexValue = true;
			this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570 = new global::AcpBusinessLayer.AcpSimpleRangeField(12800, this, global::AllFeatures.CodeplugGuid.b("黋꿍듏韑ꛓ뇕럗駙뫛망꟟蟡諣菥髧诩胫뷭듯믱닳냵곷당껻믽叿䨁䀃䐅备㈉匋伍∏⌑ℓℕ⠗", a_), global::CommonResources.AcgResources.ID_BADMICSDIFFTHRESHDBQ8, 0, 65535, null, null, 0, 1);
			this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.DataTransferOrder = 19;
			this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.ShowHexValue = true;
			this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567 = new global::AcpBusinessLayer.AcpSimpleRangeField(1536, this, global::AllFeatures.CodeplugGuid.b("黋꿍듏韑ꛓ뇕럗駙뫛망꟟蟡諣菥髧诩胫룭뇯뛱냳돵곷껹듻곽䗿儁䰃䈅䨇嬉㐋儍儏‑┓⌕⸗ⴙ", a_), global::CommonResources.AcgResources.ID_STATUSVADDETTHRESHDBQ8, 0, 65535, null, null, 0, 1);
			this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.DataTransferOrder = 16;
			this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.ShowHexValue = true;
			this.radErgoCfgGeneralVADDETCOUNT_A21568 = new global::AcpBusinessLayer.AcpSimpleRangeField(9, this, global::AllFeatures.CodeplugGuid.b("黋꿍듏韑ꛓ뇕럗駙뫛망꟟蟡諣菥髧诩胫룭뇯뛱냳돵곷맹돻꯽仿嘁嬃䜅㨇㬉㤋㠍⠏", a_), global::CommonResources.AcgResources.ID_STATUSVADDETCOUNT, 0, 65535, null, null, 0, 1);
			this.radErgoCfgGeneralVADDETCOUNT_A21568.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoCfgGeneralVADDETCOUNT_A21568.DataTransferOrder = 17;
			this.radErgoCfgGeneralVADDETCOUNT_A21568.ShowHexValue = true;
			this.radErgoCfgGeneralMINGAIN_A21562 = new global::AcpBusinessLayer.AcpSimpleRangeField(8231, this, global::AllFeatures.CodeplugGuid.b("黋꿍듏韑ꛓ뇕럗駙뫛망꟟蟡諣菥髧诩胫ꏭ맯볱돳럵뇷듹ꏻ뿽㋿㌁㄃々㨇", a_), global::CommonResources.AcgResources.ID_DWFMINGAIN, 0, 65535, null, null, 0, 1);
			this.radErgoCfgGeneralMINGAIN_A21562.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoCfgGeneralMINGAIN_A21562.DataTransferOrder = 12;
			this.radErgoCfgGeneralMINGAIN_A21562.ShowHexValue = true;
			this.radErgoCfgGeneralDINCABFSS_A21564 = new global::AcpBusinessLayer.AcpSimpleRangeField(819, this, global::AllFeatures.CodeplugGuid.b("黋꿍듏韑ꛓ뇕럗駙뫛망꟟蟡諣菥髧诩胫ꫭ맯볱럳럵뫷볹꿻귽忿䌁㘃㜅㴇㰉㠋", a_), global::CommonResources.AcgResources.ID_DINCABFSS, 0, 65535, null, null, 0, 1);
			this.radErgoCfgGeneralDINCABFSS_A21564.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoCfgGeneralDINCABFSS_A21564.DataTransferOrder = 14;
			this.radErgoCfgGeneralDINCABFSS_A21564.ShowHexValue = true;
			this.radErgoCfgGeneralNBANDS_A21573 = new global::AcpBusinessLayer.AcpSimpleRangeField(3, this, global::AllFeatures.CodeplugGuid.b("黋꿍듏韑ꛓ뇕럗駙뫛망꟟蟡諣菥髧诩胫ꃭ닯돱뫳답꯷ꗹ뷻쳽ㇿ㜁㌃㔅", a_), global::CommonResources.AcgResources.ID_EWINDNBANDS, 0, 65535, null, null, 0, 1);
			this.radErgoCfgGeneralNBANDS_A21573.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoCfgGeneralNBANDS_A21573.DataTransferOrder = 22;
			this.radErgoCfgGeneralNBANDS_A21573.ShowHexValue = true;
			this.radErgoCfgGeneralMAXSVECTOR_A21565 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("﷋﷍韕鷝ꗟꃡ폣ꃥ껧곩\udbeb꣭뛯등쏳냵뻷볹쯻룽䛿䐁㌃䀅万䰉㬋䠍嘏向⌓倕帗尙⬛堝星搡ጣ急渧氩ᬫ栭瘯琱̳瀵縷簹଻砽ؿс獃E็౉筋ࡍᙏᑑ捓ၕṗ᱙歛ᡝ♟②卣⁥⹧Ⱪ孫⡭㙯㑱䍳ふ㹷㱹䭻㡽왿쒁뎃삅캇첉뮋좍횏풑ꎓ킕\ude97\udc99ꮛ\ud89d鎣鮫莳ﺷﲹ讻蚿蓁胅軇賉", a_), this, global::AllFeatures.CodeplugGuid.b("黋꿍듏韑ꛓ뇕럗駙뫛망꟟蟡諣菥髧诩胫ꏭ뇯꫱ꟳꃵ뷷맹ꣻ뇽勿崁䔃㐅㤇㼉㨋㬍", a_), global::CommonResources.AcgResources.ID_EWINDMAXSVECTOR, 128);
			this.radErgoCfgGeneralMAXSVECTOR_A21565.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoCfgGeneralMAXSVECTOR_A21565.DataTransferOrder = 23;
			this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_BA00EC00, this, global::AllFeatures.CodeplugGuid.b("藋ꃍ꓏鿑뷓뗕雗꧙軛뫝꟟蟡諣듥ꧧ껩ꗫꇭ뇯꟱ꃳ맵뛷뗹뗻귽䗿䀁䬃包䘇三弋䨍刏䌑Ⱃ䤕Ⱇ⠙⨛⤝ᘟ", a_), global::CommonResources.AcgResources.ID_ADAPTIVENOISESUPPRESSIONRADIOAUTONOISEBOUNDSDBQ8, 8);
			this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676.DataTransferOrder = 27;
			this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_P_287A040C, this, global::AllFeatures.CodeplugGuid.b("藋ꃍ꓏鿑뷓뗕雗꧙軛뫝꟟蟡諣듥ꧧ껩ꗫꇭ뇯꟱ꃳ맵뗷돹닻맽䇿䬁䨃倅䴇䤉堋䄍䈏䴑–␕⸗ⴙ⬛", a_), global::CommonResources.AcgResources.ID_ADAPTIVENOISESUPPRESSIONRADIOAUTOMINGAINVECTOR, 8);
			this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677.DataTransferOrder = 28;
			this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_P_000A, this, global::AllFeatures.CodeplugGuid.b("藋ꃍ꓏鿑뷓뗕雗꧙軛뫝꟟蟡諣듥ꧧ껩ꗫꇭ뇯꟱ꃳ맵꫷뿹냻뿽壿嘁䴃䤅䘇䠉䌋嬍帏嘑䜓䤕Ⱇ⠙⨛⤝᠟", a_), global::CommonResources.AcgResources.ID_ADAPTIVENOISESUPPRESSIONRADIOAUTORELAXATIONBOUNDS, 4);
			this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678.DataTransferOrder = 29;
			this.intMicNsRdGenRADIOPASSFILTERSTART_42679 = new global::AcpBusinessLayer.AcpSimpleRangeField(1750, this, global::AllFeatures.CodeplugGuid.b("藋ꃍ꓏鿑뷓뗕雗꧙軛뫝꟟蟡諣듥ꧧ껩ꗫꇭꃯ돱ꟳꗵ뻷돹냻꫽䗿倁圃刅䤇堉堋儍␏‑∓ℕ℗", a_), global::CommonResources.AcgResources.ID_ADAPTIVENOISESUPPRESSIONRADIOPASSFILTERSTART, 1, 3999, null, null, 0, 1);
			this.intMicNsRdGenRADIOPASSFILTERSTART_42679.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.intMicNsRdGenRADIOPASSFILTERSTART_42679.DataTransferOrder = 30;
			this.intMicNsRdGenRADIOPASSFILTERSTART_42679.ShowHexValue = false;
			this.intMicNsRdGenRADIOSAMMIXMODE_42680 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("藋ꃍ꓏鿑뷓뗕雗꧙軛뫝꟟蟡諣듥ꧧ껩ꗫꇭꏯ돱맳믵뇷ꋹ뇻뇽䓿䜁嬃㈅㨇㰉㐋㸍", a_), global::CommonResources.AcgResources.ID_ADAPTIVENOISESUPPRESSIONRADIOSAMMIXMODE, 0, 2, null, null, 0, 1);
			this.intMicNsRdGenRADIOSAMMIXMODE_42680.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.intMicNsRdGenRADIOSAMMIXMODE_42680.DataTransferOrder = 31;
			this.intMicNsRdGenRADIOSAMMIXMODE_42680.ShowHexValue = false;
			this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681 = new global::AcpBusinessLayer.AcpSimpleRangeField(1000, this, global::AllFeatures.CodeplugGuid.b("藋ꃍ꓏鿑뷓뗕雗꧙軛뫝꟟蟡諣듥ꧧ껩ꗫꇭꏯ돱맳뗵귷껹돻ꣽ䗿倁䈃吅䴇嬉夋䬍帏儑䴓䤕Ⱇ⠙⨛☝ᄟ", a_), global::CommonResources.AcgResources.ID_ADAPTIVENOISESUPPRESSIONRADIOSAMCUTOVERFREQUENCY, 1, 3999, null, null, 0, 1);
			this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.DataTransferOrder = 32;
			this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.ShowHexValue = false;
			this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682 = new global::AcpBusinessLayer.AcpSimpleRangeField(25, this, global::AllFeatures.CodeplugGuid.b("藋ꃍ꓏鿑뷓뗕雗꧙軛뫝꟟蟡諣듥ꧧ껩ꗫꇭ룯뷱ꃳ듵뷷믹뇻돽䧿威嘃䜅將伉匋㨍∏␑Ⱃ␕", a_), global::CommonResources.AcgResources.ID_ADAPTIVENOISESUPPRESSIONRADIOHOTBEAMMIXRATE, 1, 250, null, null, 0, 1);
			this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.DataTransferOrder = 33;
			this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.ShowHexValue = false;
			this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683 = new global::AcpBusinessLayer.AcpSimpleRangeField(6144, this, global::AllFeatures.CodeplugGuid.b("藋ꃍ꓏鿑뷓뗕雗꧙軛뫝꟟蟡諣듥ꧧ껩ꗫꇭ룯뷱ꃳ듵뷷믹뇻돽䇿威䔃刅將伉䈋嬍儏䘑崓夕嘗帙帛伝᠟紡ဣᐥḧሩἫ", a_), global::CommonResources.AcgResources.ID_ADAPTIVENOISESUPPRESSIONRADIOHOTBEAMMAXATTENUATIONDBQ8, 1, 7680, null, null, 0, 1);
			this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.DataTransferOrder = 34;
			this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("诋ꯍ뻏럑ꛓ럕듗", a_);
			base.Id = 10202;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060068CB RID: 26827 RVA: 0x005DD81C File Offset: 0x005DBA1C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 0;
			short num = (short)404553746;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.intMicNsRdGenRADIOPASSFILTERSTART_42679 = new global::AcpBusinessLayer.AcpSimpleRangeField(1750, this, global::AllFeatures.CodeplugGuid.b("裀귂뇄諆ꃈ꣊菌볎菐럒鋔닖럘觚鳜鯞꣠곢뗤ꛦ뫨룪꯬ꛮ뷰ꟲ냴ꗶ꫸꿺볼귾唀専㄄㔆㼈㰊㐌", a_), global::CommonResources.AcgResources.ID_ADAPTIVENOISESUPPRESSIONRADIOPASSFILTERSTART, null, null, 0, 1);
					this.intMicNsRdGenRADIOPASSFILTERSTART_42679.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.intMicNsRdGenRADIOPASSFILTERSTART_42679.DataTransferOrder = 30;
					this.intMicNsRdGenRADIOPASSFILTERSTART_42679.ShowHexValue = false;
					num = (short)1760821286;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒鋔닖럘뻚꿜뻞跠껢곤ꧦ껨ꫪꓬꇮ껰닲쟴웶쳸췺쿼", a_)))
					{
						num = (short)1224605735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3CD;
				case 2:
					this.internalMicNoiseReductionProfileName_A22535 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("裀귂뇄ꋆ믈ꗊ곌ꏎ鳐뫒뛔駖뛘닚껜뫞돠蛢臤鋦諨鿪蓬胮鿰ꏲ蟴飶鿸鋺釼髾伀戂栄戆嘈䨊㼌㴎␐‒—", a_), global::CommonResources.AcgResources.ID_RADIONOISEREDUCTIONPROFILENAME, 14, global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.LegacyTitles.InternalMicNoiseReductionProfileName_A22535LegacyTitles);
					this.internalMicNoiseReductionProfileName_A22535.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.internalMicNoiseReductionProfileName_A22535.DataTransferOrder = 24;
					num = (short)1930428451;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_C4A;
				case 4:
					goto IL_AD0;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒鋔닖럘뻚꿜뻞跠껢ꓤ뿦뫨뷪꣬곮ꗰ볲ꟴꣶ룸짺쳼쫾㜀㘂", a_)))
					{
						num = (short)384434225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_333;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裀귂뇄諆ꃈ꣊菌볎菐럒鋔닖럘觚鳜鯞꣠곢귤꣦뷨ꧪ꣬껮볰뻲보꿶꯸뫺ꧼ뫾帀㜂㜄ㄆㄈ㤊", a_)))
					{
						num = (short)141557779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4B3;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裀귂뇄ꋆ믈ꗊ곌ꏎ鳐뫒뛔駖뛘닚껜뫞돠蛢臤鋦諨鿪蓬胮鿰ꏲ蟴飶鿸鋺釼髾伀戂栄戆嘈䨊㼌㴎␐‒—", a_)))
					{
						num = (short)1244987394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E6;
				case 8:
					this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_P_000A, this, global::AllFeatures.CodeplugGuid.b("裀귂뇄諆ꃈ꣊菌볎菐럒鋔닖럘觚鳜鯞꣠곢ꓤ닦뷨ꓪ뿬ꫮ뷰닲귴ꏶ냸듺돼뷾一嘂䬄䌆娈吊㤌㴎✐␒ⴔ", a_), global::CommonResources.AcgResources.ID_ADAPTIVENOISESUPPRESSIONRADIOAUTORELAXATIONBOUNDS, 4);
					this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678.DataTransferOrder = 29;
					num = (short)1076494389;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					this.radErgoCfgGeneralDINCABFSS_A21564 = new global::AcpBusinessLayer.AcpSimpleRangeField(819, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒鋔닖럘뻚꿜뻞跠꟢곤ꧦꫨꫪ꿬ꧮꋰꃲꫴ뛶쯸쫺주짾㔀", a_), global::CommonResources.AcgResources.ID_DINCABFSS, null, null, 0, 1);
					this.radErgoCfgGeneralDINCABFSS_A21564.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radErgoCfgGeneralDINCABFSS_A21564.DataTransferOrder = 14;
					this.radErgoCfgGeneralDINCABFSS_A21564.ShowHexValue = true;
					num = (short)898367492;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					this.radErgoCfgGeneralVADDETCOUNT_A21568 = new global::AcpBusinessLayer.AcpSimpleRangeField(9, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒鋔닖럘뻚꿜뻞跠뗢ꓤꏦ귨껪맬곮뻰꛲믴ꏶ꛸뫺쿼컾㐀㔂㴄", a_), global::CommonResources.AcgResources.ID_STATUSVADDETCOUNT, null, null, 0, 1);
					this.radErgoCfgGeneralVADDETCOUNT_A21568.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radErgoCfgGeneralVADDETCOUNT_A21568.DataTransferOrder = 17;
					this.radErgoCfgGeneralVADDETCOUNT_A21568.ShowHexValue = true;
					num = (short)836042809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_F8D;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裀귂뇄諆ꃈ꣊菌볎菐럒鋔닖럘鿚铜釞ꋠ곢냤돦맨뻪맬ꫮꃰꗲ냴듶그듺꿼ꃾ䀀。㈄〆㠈㌊", a_)))
					{
						num = (short)1154285635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_614;
				case 13:
					goto IL_661;
				case 14:
					this.radErgoCfgGeneralNBANDS_A21573 = new global::AcpBusinessLayer.AcpSimpleRangeField(3, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒鋔닖럘뻚꿜뻞跠귢꟤ꛦ꟨꿪뻬냮냰쇲쓴싶컸죺", a_), global::CommonResources.AcgResources.ID_EWINDNBANDS, null, null, 0, 1);
					this.radErgoCfgGeneralNBANDS_A21573.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radErgoCfgGeneralNBANDS_A21573.DataTransferOrder = 22;
					this.radErgoCfgGeneralNBANDS_A21573.ShowHexValue = true;
					num = (short)546308167;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571 = new global::AcpBusinessLayer.AcpSimpleRangeField(2304, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒鋔닖럘뻚꿜뻞跠귢ꇤ껦꿨귪맬꟮ꏰ뛲꛴뿶뷸맺과쟾帀䈂㜄㘆㰈㰊㰌", a_), global::CommonResources.AcgResources.ID_BADMICNDIFFTHRESHDBQ8, null, null, 0, 1);
					this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.DataTransferOrder = 20;
					this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.ShowHexValue = true;
					num = (short)1710161952;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裀귂뇄諆ꃈ꣊菌볎菐럒鋔닖럘鿚铜釞ꋠꛢ뗤뇦골꣪맬ꃮꏰ곲듴쓶컸쳺쳼웾", a_)))
					{
						num = (short)376963099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_22F;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒鋔닖럘뻚꿜뻞跠귢꟤ꛦ꟨꿪뻬냮냰쇲쓴싶컸죺", a_)))
					{
						num = (short)227475470;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_842;
				case 18:
					switch (0)
					{
					case 0:
						goto IL_151;
					}
					continue;
				case 19:
					this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682 = new global::AcpBusinessLayer.AcpSimpleRangeField(25, this, global::AllFeatures.CodeplugGuid.b("裀귂뇄諆ꃈ꣊菌볎菐럒鋔닖럘觚鳜鯞꣠곢귤꣦뷨ꧪ꣬껮볰뻲보꿶꯸뫺ꧼ뫾帀㜂㜄ㄆㄈ㤊", a_), global::CommonResources.AcgResources.ID_ADAPTIVENOISESUPPRESSIONRADIOHOTBEAMMIXRATE, null, null, 0, 1);
					this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.DataTransferOrder = 33;
					this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.ShowHexValue = false;
					num = (short)2020933673;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					goto IL_BFF;
				case 21:
					this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569 = new global::AcpBusinessLayer.AcpSimpleRangeField(6144, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒鋔닖럘뻚꿜뻞跠ꫢꯤꛦꫨ뿪ꓬ맮듰ꟲ뷴ꗶ본꣺뗼믾䌀刂㴄堆䠈㤊㰌㨎✐⨒", a_), global::CommonResources.AcgResources.ID_BADMICINACTIVETHRESHDBQ8, null, null, 0, 1);
					this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.DataTransferOrder = 18;
					this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.ShowHexValue = true;
					num = (short)969670669;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					goto IL_380;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒鋔닖럘뻚꿜뻞跠꟢곤ꧦꫨꫪ꿬ꧮꋰꃲꫴ뛶쯸쫺주짾㔀", a_)))
					{
						num = (short)181665801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AD0;
				case 24:
					this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681 = new global::AcpBusinessLayer.AcpSimpleRangeField(1000, this, global::AllFeatures.CodeplugGuid.b("裀귂뇄諆ꃈ꣊菌볎菐럒鋔닖럘觚鳜鯞꣠곢뛤ꛦꓨ꣪룬믮뻰ꗲ냴ꗶ뿸ꧺ룼껾吀䘂䬄䐆倈吊㤌㴎✐⬒␔", a_), global::CommonResources.AcgResources.ID_ADAPTIVENOISESUPPRESSIONRADIOSAMCUTOVERFREQUENCY, null, null, 0, 1);
					this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.DataTransferOrder = 32;
					this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.ShowHexValue = false;
					num = (short)514195478;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					goto IL_501;
				case 26:
					goto IL_466;
				case 27:
					this.intMicNsRdGenDINCEPVECTOR_A37719 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("流﷌ￎ퇠훢헤ퟦ\ud9e8\udbea\uddec\uddee쇰쏲열쟶째쯺췼쿾㄀㌂㔄㜆㤈㬊㴌㼎ℐ⌒└✖⤘⬚ⴜ⼞ᄠጢᔤᜦᤨᬪᴬἮİ̲Դܶस଺഼༾", a_), this, global::AllFeatures.CodeplugGuid.b("裀귂뇄諆ꃈ꣊菌볎菐럒鋔닖럘鿚铜釞ꋠꛢ뗤뇦골꣪맬ꃮꏰ곲듴쓶컸쳺쳼웾", a_), global::CommonResources.AcgResources.ID_DINCEPVECTOR, 64);
					this.intMicNsRdGenDINCEPVECTOR_A37719.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.intMicNsRdGenDINCEPVECTOR_A37719.DataTransferOrder = 26;
					num = (short)700645377;
					if (num != 0)
					{
					}
					num = (short)1753481280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
				{
					num = (short)1036386304;
					short num3 = num;
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒鋔닖럘뻚꿜뻞跠ꛢ뷤럦꣨ꗪ뻬ꛮ뻰뷲뇴닶뻸ꧺ룼뫾帀䈂㜄㘆㰈㴊㸌", a_)))
					{
						num = (short)786628662;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F8D;
				}
				case 29:
					num = (short)1114112028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒鋔닖럘뻚꿜뻞跠ꯢꫤ돦ꯨ껪곬ꋮ뗰뛲ꇴꏶ뇸ꧺ룼곾䤀䜂䜄嘆ㄈ吊䰌㴎‐☒⌔№", a_)))
					{
						num = (short)1045495876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_419;
				case 31:
					goto IL_3CD;
				case 32:
					goto IL_88E;
				case 33:
					this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570 = new global::AcpBusinessLayer.AcpSimpleRangeField(12800, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒鋔닖럘뻚꿜뻞跠냢ꇤ껦꿨귪맬꟮ꏰ뛲꛴뿶뷸맺과쟾帀䈂㜄㘆㰈㰊㴌", a_), global::CommonResources.AcgResources.ID_BADMICSDIFFTHRESHDBQ8, null, null, 0, 1);
					this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.DataTransferOrder = 19;
					this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.ShowHexValue = true;
					num = (short)1878982681;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					this.radErgoCfgGeneralRTHRESHDBQ8_A21572 = new global::AcpBusinessLayer.AcpSimpleRangeField(62976, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒鋔닖럘뻚꿜뻞跠뇢뇤꿦믨껪뻬꟮뗰뇲ꓴ쿶꛸뫺쿼컾㐀㐂㜄", a_), global::CommonResources.AcgResources.ID_BADMICRTHRESHDBQ8, null, null, 0, 1);
					this.radErgoCfgGeneralRTHRESHDBQ8_A21572.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radErgoCfgGeneralRTHRESHDBQ8_A21572.DataTransferOrder = 21;
					this.radErgoCfgGeneralRTHRESHDBQ8_A21572.ShowHexValue = true;
					num = (short)895025213;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					goto IL_2E6;
				case 36:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裀귂뇄諆ꃈ꣊菌볎菐럒鋔닖럘觚鳜鯞꣠곢뗤ꛦ뫨룪꯬ꛮ뷰ꟲ냴ꗶ꫸꿺볼귾唀専㄄㔆㼈㰊㐌", a_)))
					{
						num = (short)1496186880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F3F;
				case 37:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裀귂뇄諆ꃈ꣊菌볎菐럒鋔닖럘觚鳜鯞꣠곢ꓤ닦뷨ꓪꏬꃮ룰ꃲ냴뗶뛸껺돼믾刀䜂䜄嘆ㄈ吊㤌㴎✐␒⌔", a_)))
					{
						num = (short)598540332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_178;
				case 38:
					goto IL_F3F;
				case 39:
					this.radErgoCfgGeneralMINGAIN_A21562 = new global::AcpBusinessLayer.AcpSimpleRangeField(8231, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒鋔닖럘뻚꿜뻞跠껢곤ꧦ껨ꫪꓬꇮ껰닲쟴웶쳸췺쿼", a_), global::CommonResources.AcgResources.ID_DWFMINGAIN, null, null, 0, 1);
					this.radErgoCfgGeneralMINGAIN_A21562.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radErgoCfgGeneralMINGAIN_A21562.DataTransferOrder = 12;
					this.radErgoCfgGeneralMINGAIN_A21562.ShowHexValue = true;
					num = (short)6422559;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 40:
					goto IL_419;
				case 41:
					goto IL_4B3;
				case 42:
					this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683 = new global::AcpBusinessLayer.AcpSimpleRangeField(6144, this, global::AllFeatures.CodeplugGuid.b("裀귂뇄諆ꃈ꣊菌볎菐럒鋔닖럘觚鳜鯞꣠곢귤꣦뷨ꧪ꣬껮볰뻲듴꿶룸꿺ꧼ뫾伀嘂䐄匆䀈䐊䌌䬎匐䈒ⴔ䠖ⴘ⤚⬜✞ሠ", a_), global::CommonResources.AcgResources.ID_ADAPTIVENOISESUPPRESSIONRADIOHOTBEAMMAXATTENUATIONDBQ8, null, null, 0, 1);
					this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.DataTransferOrder = 34;
					this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.ShowHexValue = false;
					num = (short)905183301;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 43:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒鋔닖럘뻚꿜뻞跠뇢뇤꿦믨껪뻬꟮뗰뇲ꓴ쿶꛸뫺쿼컾㐀㐂㜄", a_)))
					{
						num = (short)1806827554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E8F;
				case 44:
					this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_BA00EC00, this, global::AllFeatures.CodeplugGuid.b("裀귂뇄諆ꃈ꣊菌볎菐럒鋔닖럘觚鳜鯞꣠곢ꓤ닦뷨ꓪꏬꃮ룰ꃲ냴뗶뛸껺돼믾刀䜂䜄嘆ㄈ吊㤌㴎✐␒⌔", a_), global::CommonResources.AcgResources.ID_ADAPTIVENOISESUPPRESSIONRADIOAUTONOISEBOUNDSDBQ8, 8);
					this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676.DataTransferOrder = 27;
					num = (short)736362554;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 45:
					if (producerFields != null)
					{
						num = (short)1738342429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_125B;
				case 46:
					goto IL_333;
				case 47:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒鋔닖럘뻚꿜뻞跠ꫢꯤꛦꫨ뿪ꓬ맮듰ꟲ뷴ꗶ본꣺뗼믾䌀刂㴄堆䠈㤊㰌㨎✐⨒", a_)))
					{
						num = (short)901447701;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_661;
				case 48:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裀귂뇄諆ꃈ꣊菌볎菐럒鋔닖럘觚鳜鯞꣠곢ꓤ닦뷨ꓪꃬꛮ뿰듲듴뻶럸귺룼볾唀䰂圄堆㴈㤊㬌㠎☐", a_)))
					{
						num = (short)1487142982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C4A;
				case 49:
				{
					num = (short)579082670;
					short num4 = num;
					num = (short)1541216686;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_ACB;
					default:
						num = (short)1256062976;
						if (num != 0)
						{
						}
						this.radErgoCfgGeneralMAXSVECTOR_A21565 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("﯈諊﯌﷎郒郔闖鷚鯜駞훠ꗢꏤꇦ\udee8귪꯬ꧮ웰뗲돴뇶컸뷺민맾㘀䔂䌄䄆㸈䴊䬌䤎☐唒匔儖⸘崚嬜夞ᘠ攢挤愦Ḩ洪欬椮ذ甲猴然ุ紺笼社癀Ղ̈́ņ繈ൊୌॎ晐ᕒፔᅖ湘ᵚ᭜ᥞ噠╢⍤Ⅶ幨⵪⭬⥮䙰㕲㍴ㅶ乸㵺㭼㥾뚀얂쎄솆뺈춊쮌즎Ꚑ햒펔톖꺘\udd9a\udb9c\ud99e隠麨蚰躸ﶺ﮼料", a_), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒鋔닖럘뻚꿜뻞跠껢ꓤ뿦뫨뷪꣬곮ꗰ볲ꟴꣶ룸짺쳼쫾㜀㘂", a_), global::CommonResources.AcgResources.ID_EWINDMAXSVECTOR, 128);
						this.radErgoCfgGeneralMAXSVECTOR_A21565.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
						this.radErgoCfgGeneralMAXSVECTOR_A21565.DataTransferOrder = 23;
						num = (short)2055209006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 50:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒鋔닖럘뻚꿜뻞跠냢ꇤ껦꿨귪맬꟮ꏰ뛲꛴뿶뷸맺과쟾帀䈂㜄㘆㰈㰊㴌", a_)))
					{
						num = (short)1169752097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_501;
				case 51:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒鋔닖럘뻚꿜뻞跠귢ꇤ껦꿨귪맬꟮ꏰ뛲꛴뿶뷸맺과쟾帀䈂㜄㘆㰈㰊㰌", a_)))
					{
						num = (short)129695759;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_88E;
				case 52:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裀귂뇄諆ꃈ꣊菌볎菐럒鋔닖럘觚鳜鯞꣠곢뛤ꛦꓨꛪꓬ럮볰볲뇴닶꛸쿺쿼짾㤀㌂", a_)))
					{
						num = (short)1155137592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_466;
				case 53:
					goto IL_945;
				case 54:
					this.radErgoCfgGeneralEXPANSIONDEGREE_A21563 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒鋔닖럘뻚꿜뻞跠ꛢ뷤럦꣨ꗪ뻬ꛮ뻰뷲뇴닶뻸ꧺ룼뫾帀䈂㜄㘆㰈㴊㸌", a_), global::CommonResources.AcgResources.ID_DWFEXPANSIONDEGREE, null, null, 0, 1);
					this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.DataTransferOrder = 13;
					this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.ShowHexValue = true;
					num = (short)1390542859;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 55:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒鋔닖럘뻚꿜뻞跠뗢ꓤꏦ귨껪맬믮맰ꇲ냴ꓶ뇸뿺뿼껾㤀専䐄㔆㠈㸊㬌㠎", a_)))
					{
						num = (short)2068185160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BFF;
				case 56:
					this.intMicNsRdGenRADIOSAMMIXMODE_42680 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("裀귂뇄諆ꃈ꣊菌볎菐럒鋔닖럘觚鳜鯞꣠곢뛤ꛦꓨꛪꓬ럮볰볲뇴닶꛸쿺쿼짾㤀㌂", a_), global::CommonResources.AcgResources.ID_ADAPTIVENOISESUPPRESSIONRADIOSAMMIXMODE, null, null, 0, 1);
					this.intMicNsRdGenRADIOSAMMIXMODE_42680.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.intMicNsRdGenRADIOSAMMIXMODE_42680.DataTransferOrder = 31;
					this.intMicNsRdGenRADIOSAMMIXMODE_42680.ShowHexValue = false;
					num = (short)965804058;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 57:
					goto IL_FDA;
				case 58:
					goto IL_178;
				case 59:
					num = (short)1298071597;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 60:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裀귂뇄諆ꃈ꣊菌볎菐럒鋔닖럘觚鳜鯞꣠곢귤꣦뷨ꧪ꣬껮볰뻲듴꿶룸꿺ꧼ뫾伀嘂䐄匆䀈䐊䌌䬎匐䈒ⴔ䠖ⴘ⤚⬜✞ሠ", a_)))
					{
						num = (short)2038169642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_125B;
				case 61:
					goto IL_ACB;
				case 62:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裀귂뇄諆ꃈ꣊菌볎菐럒鋔닖럘觚鳜鯞꣠곢ꓤ닦뷨ꓪ뿬ꫮ뷰닲귴ꏶ냸듺돼뷾一嘂䬄䌆娈吊㤌㴎✐␒ⴔ", a_)))
					{
						num = (short)2136277000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_945;
				case 63:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裀귂뇄諆ꃈ꣊菌볎菐럒鋔닖럘觚鳜鯞꣠곢뛤ꛦꓨ꣪룬믮뻰ꗲ냴ꗶ뿸ꧺ룼껾吀䘂䬄䐆倈吊㤌㴎✐⬒␔", a_)))
					{
						num = (short)1966931992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_380;
				case 64:
					goto IL_22F;
				case 65:
					goto IL_614;
				case 66:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒鋔닖럘뻚꿜뻞跠뗢ꓤꏦ귨껪맬곮뻰꛲믴ꏶ꛸뫺쿼컾㐀㔂㴄", a_)))
					{
						num = (short)1399455754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FDA;
				case 67:
					this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("藂菄臆ﻈ跊诌觎闒鏔釖鷚鯜駞훠ꗢꏤꇦ\udee8귪꯬ꧮ웰뗲돴뇶컸뷺민맾㘀䔂䌄䄆㸈䴊䬌䤎☐唒匔儖⸘崚嬜夞ᘠ攢挤愦Ḩ洪欬椮ذ甲猴然ุ紺笼社癀Ղ̈́ņ繈ൊୌॎ晐ᕒፔᅖ湘ᵚ᭜ᥞ噠╢⍤Ⅶ幨⵪⭬⥮䙰㕲㍴ㅶ乸㵺㭼㥾뚀얂쎄솆뺈춊쮌즎Ꚑ햒펔톖꺘\udd9a\udb9c\ud99e隠麨蚰", a_), this, global::AllFeatures.CodeplugGuid.b("裀귂뇄諆ꃈ꣊菌볎菐럒鋔닖럘鿚铜釞ꋠ곢냤돦맨뻪맬ꫮꃰꗲ냴듶그듺꿼ꃾ䀀。㈄〆㠈㌊", a_), global::CommonResources.AcgResources.ID_DINCOUTPUTEQVECTOR, 124);
					this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718.DataTransferOrder = 25;
					num = (short)1736769601;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 68:
					this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566 = new global::AcpBusinessLayer.AcpSimpleRangeField(768, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒鋔닖럘뻚꿜뻞跠ꯢꫤ돦ꯨ껪곬ꋮ뗰뛲ꇴꏶ뇸ꧺ룼곾䤀䜂䜄嘆ㄈ吊䰌㴎‐☒⌔№", a_), global::CommonResources.AcgResources.ID_HOTBEAMDETTHRESHDBQ8, null, null, 0, 1);
					this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.DataTransferOrder = 15;
					this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.ShowHexValue = true;
					num = (short)1818558504;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 69:
					goto IL_114C;
				case 70:
					this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_P_287A040C, this, global::AllFeatures.CodeplugGuid.b("裀귂뇄諆ꃈ꣊菌볎菐럒鋔닖럘觚鳜鯞꣠곢ꓤ닦뷨ꓪꃬꛮ뿰듲듴뻶럸귺룼볾唀䰂圄堆㴈㤊㬌㠎☐", a_), global::CommonResources.AcgResources.ID_ADAPTIVENOISESUPPRESSIONRADIOAUTOMINGAINVECTOR, 8);
					this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677.DataTransferOrder = 28;
					num = (short)718274563;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 71:
					goto IL_842;
				case 72:
					this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567 = new global::AcpBusinessLayer.AcpSimpleRangeField(1536, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ苆믈곊ꋌ賎럐듒鋔닖럘뻚꿜뻞跠뗢ꓤꏦ귨껪맬믮맰ꇲ냴ꓶ뇸뿺뿼껾㤀専䐄㔆㠈㸊㬌㠎", a_), global::CommonResources.AcgResources.ID_STATUSVADDETTHRESHDBQ8, null, null, 0, 1);
					this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.DataTransferOrder = 16;
					this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.ShowHexValue = true;
					num = (short)260571156;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_151:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1334706235;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_178:
				num = (short)1501233200;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_22F:
				num = (short)981008414;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E6:
				num = (short)1180106764;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_333:
				num = (short)1301479461;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_380:
				num = (short)1148583942;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3CD:
				num = (short)440270871;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_419:
				num = (short)283508783;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_466:
				num = (short)852951103;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4B3:
				num = (short)1302921276;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_501:
				num = (short)1402798135;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_614:
				num = (short)1554055184;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_661:
				num = (short)66912307;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_842:
				num = (short)607322117;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_88E:
				num = (short)469762091;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_945:
				num = (short)10354724;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AD0:
				num = (short)1064960017;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BFF:
				num = (short)819986498;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C4A:
				num = (short)49610814;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E8F:
				num = (short)1658585138;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_ACB:
				goto IL_E8F;
				IL_F3F:
				num = (short)1496121396;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F8D:
				num = (short)283443207;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_FDA:
				num = (short)262537217;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_114C:
			IL_125B:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛀ꛂꯄꋆ믈꫊ꇌ", a_);
			base.Id = 10202;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060068CC RID: 26828 RVA: 0x005DEAB8 File Offset: 0x005DCCB8
		public override void PopulateReferences()
		{
			short num = (short)1282665908;
			short num2 = num;
			num = (short)1144319412;
			switch (num2 == num)
			{
			}
			num = (short)1235484673;
			if (num != 0)
			{
			}
			num = (short)570490880;
			if (num != 0)
			{
			}
			num = (short)128581632;
			short num3 = num;
		}

		// Token: 0x060068CD RID: 26829 RVA: 0x005DEB64 File Offset: 0x005DCD64
		public override void DropReferences()
		{
			short num = (short)934150145;
			if (num != 0)
			{
			}
			num = (short)1192938992;
			short num2 = num;
			num = (short)1933233648;
			switch (num2 == num)
			{
			}
			num = (short)234356736;
			if (num != 0)
			{
			}
			num = (short)630652928;
			short num3 = num;
		}

		// Token: 0x060068CE RID: 26830 RVA: 0x005DEC10 File Offset: 0x005DCE10
		public override void SetConstraints()
		{
			short num = (short)1140777352;
			short num2 = num;
			num = (short)1869013384;
			switch (num2 == num)
			{
			}
			num = (short)170328065;
			if (num != 0)
			{
			}
			num = (short)979894272;
			if (num != 0)
			{
			}
			num = (short)229834752;
			short num3 = num;
			this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfileConstraints.ConIntMicDincOutputEqVectorLengthEqualsTo124);
			this.intMicNsRdGenDINCEPVECTOR_A37719.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfileConstraints.ConIntMicDincEPVectorLengthEqualsTo64);
			this.radErgoCfgGeneralMAXSVECTOR_A21565.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfileConstraints.ConIntMicMaxVectorsLengthNoLessThan128);
			this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfileConstraints.ConRADAUTONSBDSDBQ8LengthEqualsTo8);
			this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfileConstraints.ConRADAUTOMINGAINVCTLengthEqualsTo8);
			this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfileConstraints.ConRADAUTORELAXTIONBDSEqualsTo4);
		}

		// Token: 0x060068CF RID: 26831 RVA: 0x005DED44 File Offset: 0x005DCF44
		public override void SetupDependencies()
		{
			short num = (short)1752387175;
			short num2 = num;
			num = (short)1039617639;
			switch (num2 == num)
			{
			}
			num = (short)1395916801;
			if (num != 0)
			{
			}
			num = (short)530841600;
			if (num != 0)
			{
			}
			num = (short)600113152;
			short num3 = num;
		}

		// Token: 0x1700363B RID: 13883
		// (get) Token: 0x060068D0 RID: 26832 RVA: 0x005DEDEC File Offset: 0x005DCFEC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1732625660;
				short num2 = num;
				num = (short)569558268;
				switch (num2 == num)
				{
				}
				num = (short)1698430977;
				if (num != 0)
				{
				}
				num = (short)93388800;
				if (num != 0)
				{
				}
				num = (short)708050944;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x1700363C RID: 13884
		// (get) Token: 0x060068D1 RID: 26833 RVA: 0x005DEE9C File Offset: 0x005DD09C
		// (set) Token: 0x060068D2 RID: 26834 RVA: 0x005DEF50 File Offset: 0x005DD150
		public int RadErgoCfgGeneralEXPANSIONDEGREE_A21563Value
		{
			get
			{
				short num = (short)1920644226;
				short num2 = num;
				num = (short)1260172418;
				switch (num2 == num)
				{
				}
				num = (short)1397489665;
				if (num != 0)
				{
				}
				num = (short)1138688000;
				if (num != 0)
				{
				}
				num = (short)844955648;
				short num3 = num;
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.Value;
			}
			set
			{
				short num = (short)1422419016;
				short num2 = num;
				num = (short)403268680;
				switch (num2 == num)
				{
				}
				num = (short)927334401;
				if (num != 0)
				{
				}
				num = (short)2027945984;
				if (num != 0)
				{
				}
				num = (short)419102720;
				short num3 = num;
				this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.Value = value;
			}
		}

		// Token: 0x1700363D RID: 13885
		// (get) Token: 0x060068D3 RID: 26835 RVA: 0x005DF004 File Offset: 0x005DD204
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgGeneralEXPANSIONDEGREE_A21563
		{
			get
			{
				short num = (short)849938832;
				short num2 = num;
				num = (short)1700137360;
				switch (num2 == num)
				{
				}
				num = (short)123994113;
				if (num != 0)
				{
				}
				num = (short)912457728;
				if (num != 0)
				{
				}
				num = (short)929497088;
				short num3 = num;
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A21563;
			}
		}

		// Token: 0x1700363E RID: 13886
		// (get) Token: 0x060068D4 RID: 26836 RVA: 0x005DF0B4 File Offset: 0x005DD2B4
		// (set) Token: 0x060068D5 RID: 26837 RVA: 0x005DF168 File Offset: 0x005DD368
		public string RadErgoCfgGeneralEXPANSIONDEGREE_A21563_UIValue
		{
			get
			{
				short num = (short)474502003;
				short num2 = num;
				num = (short)1534088051;
				switch (num2 == num)
				{
				}
				num = (short)41746433;
				if (num != 0)
				{
				}
				num = (short)1665662976;
				if (num != 0)
				{
				}
				num = (short)1176567808;
				short num3 = num;
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.UIValue;
			}
			set
			{
				short num = (short)94628597;
				short num2 = num;
				num = (short)1821567733;
				switch (num2 == num)
				{
				}
				num = (short)2090336256;
				if (num != 0)
				{
				}
				num = (short)416088065;
				if (num != 0)
				{
				}
				num = (short)378208256;
				short num3 = num;
				this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.UIValue = value;
			}
		}

		// Token: 0x1700363F RID: 13887
		// (get) Token: 0x060068D6 RID: 26838 RVA: 0x005DF21C File Offset: 0x005DD41C
		// (set) Token: 0x060068D7 RID: 26839 RVA: 0x005DF2D4 File Offset: 0x005DD4D4
		public string RadErgoCfgGeneralEXPANSIONDEGREE_A21563_HexUIValue
		{
			get
			{
				short num = (short)1672628726;
				short num2 = num;
				num = (short)464341494;
				switch (num2 == num)
				{
				}
				num = (short)2033188864;
				if (num != 0)
				{
				}
				num = (short)1924399105;
				if (num != 0)
				{
				}
				num = (short)584646656;
				short num3 = num;
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.HexUIValue;
			}
			set
			{
				short num = (short)1304249441;
				short num2 = num;
				num = (short)2003125345;
				switch (num2 == num)
				{
				}
				num = (short)1208614912;
				if (num != 0)
				{
				}
				num = (short)385548289;
				if (num != 0)
				{
				}
				num = (short)1671626752;
				short num3 = num;
				this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.HexUIValue = value;
			}
		}

		// Token: 0x17003640 RID: 13888
		// (get) Token: 0x060068D8 RID: 26840 RVA: 0x005DF388 File Offset: 0x005DD588
		// (set) Token: 0x060068D9 RID: 26841 RVA: 0x005DF43C File Offset: 0x005DD63C
		internal int RadErgoCfgGeneralEXPANSIONDEGREE_A21563Min
		{
			get
			{
				short num = (short)671219713;
				if (num != 0)
				{
				}
				num = (short)658520060;
				short num2 = num;
				num = (short)1653159932;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1567555584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1972633600;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.Min;
			}
			set
			{
				short num = (short)1410980846;
				short num2 = num;
				num = (short)2144984046;
				switch (num2 == num)
				{
				}
				num = (short)898170880;
				short num3 = num;
				num = (short)683540480;
				if (num != 0)
				{
				}
				num = (short)2082471937;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.Min = value;
			}
		}

		// Token: 0x17003641 RID: 13889
		// (get) Token: 0x060068DA RID: 26842 RVA: 0x005DF4F4 File Offset: 0x005DD6F4
		// (set) Token: 0x060068DB RID: 26843 RVA: 0x005DF5A8 File Offset: 0x005DD7A8
		internal int RadErgoCfgGeneralEXPANSIONDEGREE_A21563Max
		{
			get
			{
				short num = (short)232704722;
				short num2 = num;
				num = (short)1607846610;
				switch (num2 == num)
				{
				}
				num = (short)1660092416;
				short num3 = num;
				num = (short)1452081153;
				if (num != 0)
				{
				}
				num = (short)862912512;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.Max;
			}
			set
			{
				short num = (short)1451753473;
				if (num != 0)
				{
				}
				num = (short)416561557;
				short num2 = num;
				num = (short)1473264021;
				switch (num2 == num)
				{
				default:
				{
					num = (short)637337600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1624834048;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.Max = value;
			}
		}

		// Token: 0x17003642 RID: 13890
		// (get) Token: 0x060068DC RID: 26844 RVA: 0x005DF65C File Offset: 0x005DD85C
		// (set) Token: 0x060068DD RID: 26845 RVA: 0x005DF714 File Offset: 0x005DD914
		internal int RadErgoCfgGeneralEXPANSIONDEGREE_A21563Step
		{
			get
			{
				short num = (short)2037248247;
				short num2 = num;
				num = (short)399962359;
				switch (num2 == num)
				{
				}
				num = (short)389677056;
				short num3 = num;
				num = (short)2029584384;
				if (num != 0)
				{
				}
				num = (short)918093825;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.StepSize;
			}
			set
			{
				short num = (short)1652036083;
				short num2 = num;
				num = (short)183374323;
				switch (num2 == num)
				{
				}
				num = (short)1775435776;
				short num3 = num;
				num = (short)747175936;
				if (num != 0)
				{
				}
				num = (short)770637825;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.StepSize = value;
			}
		}

		// Token: 0x17003643 RID: 13891
		// (get) Token: 0x060068DE RID: 26846 RVA: 0x005DF7C8 File Offset: 0x005DD9C8
		// (set) Token: 0x060068DF RID: 26847 RVA: 0x005DF87C File Offset: 0x005DDA7C
		public bool RadErgoCfgGeneralEXPANSIONDEGREE_A21563_Applicable
		{
			get
			{
				short num = (short)1853849862;
				short num2 = num;
				num = (short)1138852102;
				switch (num2 == num)
				{
				}
				num = (short)1177485312;
				short num3 = num;
				num = (short)1126170624;
				if (num != 0)
				{
				}
				num = (short)545390593;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.Applicable;
			}
			set
			{
				short num = (short)848024947;
				short num2 = num;
				num = (short)68015475;
				switch (num2 == num)
				{
				}
				num = (short)678428672;
				short num3 = num;
				num = (short)19595265;
				if (num != 0)
				{
				}
				num = (short)1870987264;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.Applicable = value;
			}
		}

		// Token: 0x17003644 RID: 13892
		// (get) Token: 0x060068E0 RID: 26848 RVA: 0x005DF934 File Offset: 0x005DDB34
		// (set) Token: 0x060068E1 RID: 26849 RVA: 0x005DF9E8 File Offset: 0x005DDBE8
		public bool RadErgoCfgGeneralEXPANSIONDEGREE_A21563_Valid
		{
			get
			{
				short num = (short)1387509119;
				short num2 = num;
				num = (short)26850687;
				switch (num2 == num)
				{
				}
				num = (short)334626816;
				short num3 = num;
				num = (short)1171980288;
				if (num != 0)
				{
				}
				num = (short)1242431489;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.Valid;
			}
			set
			{
				short num = (short)1493499905;
				if (num != 0)
				{
				}
				num = (short)724883888;
				short num2 = num;
				num = (short)89905584;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1608253440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1919287296;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.Valid = value;
			}
		}

		// Token: 0x17003645 RID: 13893
		// (get) Token: 0x060068E2 RID: 26850 RVA: 0x005DFA9C File Offset: 0x005DDC9C
		// (set) Token: 0x060068E3 RID: 26851 RVA: 0x005DFB4C File Offset: 0x005DDD4C
		public bool RadErgoCfgGeneralEXPANSIONDEGREE_A21563_Visible
		{
			get
			{
				short num = (short)2094661633;
				if (num != 0)
				{
				}
				num = (short)1215733391;
				short num2 = num;
				num = (short)344301199;
				switch (num2 == num)
				{
				default:
				{
					num = (short)503906304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1304756224;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.Visible;
			}
			set
			{
				short num = (short)761859327;
				short num2 = num;
				num = (short)1028918527;
				switch (num2 == num)
				{
				}
				num = (short)38076416;
				short num3 = num;
				num = (short)1082851329;
				if (num != 0)
				{
				}
				num = (short)1314717696;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.Visible = value;
			}
		}

		// Token: 0x17003646 RID: 13894
		// (get) Token: 0x060068E4 RID: 26852 RVA: 0x005DFC04 File Offset: 0x005DDE04
		// (set) Token: 0x060068E5 RID: 26853 RVA: 0x005DFCB8 File Offset: 0x005DDEB8
		public bool RadErgoCfgGeneralEXPANSIONDEGREE_A21563_Editable
		{
			get
			{
				short num = (short)1645698125;
				short num2 = num;
				num = (short)1969577037;
				switch (num2 == num)
				{
				}
				num = (short)1517355008;
				short num3 = num;
				num = (short)1663631361;
				if (num != 0)
				{
				}
				num = (short)1695416320;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.Editable;
			}
			set
			{
				short num = (short)1328892329;
				short num2 = num;
				num = (short)1448233385;
				switch (num2 == num)
				{
				}
				num = (short)287178752;
				short num3 = num;
				num = (short)428343296;
				if (num != 0)
				{
				}
				num = (short)216334337;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.Editable = value;
			}
		}

		// Token: 0x17003647 RID: 13895
		// (get) Token: 0x060068E6 RID: 26854 RVA: 0x005DFD6C File Offset: 0x005DDF6C
		internal string RadErgoCfgGeneralEXPANSIONDEGREE_A21563_UILabel
		{
			get
			{
				short num = (short)145035123;
				short num2 = num;
				num = (short)1081347955;
				switch (num2 == num)
				{
				}
				num = (short)1142554624;
				short num3 = num;
				num = (short)882769921;
				if (num != 0)
				{
				}
				num = (short)915734528;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.UIName;
			}
		}

		// Token: 0x17003648 RID: 13896
		// (get) Token: 0x060068E7 RID: 26855 RVA: 0x005DFE24 File Offset: 0x005DE024
		// (set) Token: 0x060068E8 RID: 26856 RVA: 0x005DFED8 File Offset: 0x005DE0D8
		internal bool RadErgoCfgGeneralEXPANSIONDEGREE_A21563_HiddenStatic
		{
			get
			{
				short num = (short)1211738656;
				short num2 = num;
				num = (short)1385867808;
				switch (num2 == num)
				{
				}
				num = (short)1243742208;
				short num3 = num;
				num = (short)1539047425;
				if (num != 0)
				{
				}
				num = (short)1729757184;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.HiddenStatic;
			}
			set
			{
				short num = (short)1737314327;
				short num2 = num;
				num = (short)601313303;
				switch (num2 == num)
				{
				}
				num = (short)2033385472;
				short num3 = num;
				num = (short)1799749633;
				if (num != 0)
				{
				}
				num = (short)912916480;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.HiddenStatic = value;
			}
		}

		// Token: 0x17003649 RID: 13897
		// (get) Token: 0x060068E9 RID: 26857 RVA: 0x005DFF8C File Offset: 0x005DE18C
		// (set) Token: 0x060068EA RID: 26858 RVA: 0x005E0040 File Offset: 0x005DE240
		internal bool RadErgoCfgGeneralEXPANSIONDEGREE_A21563_HiddenDynamic
		{
			get
			{
				short num = (short)61407233;
				if (num != 0)
				{
				}
				num = (short)426830666;
				short num2 = num;
				num = (short)1235610442;
				switch (num2 == num)
				{
				default:
				{
					num = (short)188809216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)678821888;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.HiddenDynamic;
			}
			set
			{
				short num = (short)253165569;
				if (num != 0)
				{
				}
				num = (short)601955129;
				short num2 = num;
				num = (short)1404377913;
				switch (num2 == num)
				{
				default:
				{
					num = (short)927858688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)720437248;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralEXPANSIONDEGREE_A21563.HiddenDynamic = value;
			}
		}

		// Token: 0x1700364A RID: 13898
		// (get) Token: 0x060068EB RID: 26859 RVA: 0x005E00F8 File Offset: 0x005DE2F8
		public bool RadErgoCfgGeneralEXPANSIONDEGREE_A21563_HasDiffs
		{
			get
			{
				short num = (short)1927665418;
				short num2 = num;
				num = (short)188733194;
				switch (num2 == num)
				{
				}
				num = (short)399638528;
				short num3 = num;
				num = (short)473366529;
				if (num != 0)
				{
				}
				num = (short)2088697856;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralEXPANSIONDEGREE_A21563._HasDiffs;
			}
		}

		// Token: 0x1700364B RID: 13899
		// (get) Token: 0x060068EC RID: 26860 RVA: 0x005E01AC File Offset: 0x005DE3AC
		// (set) Token: 0x060068ED RID: 26861 RVA: 0x005E0264 File Offset: 0x005DE464
		public string InternalMicNoiseReductionProfileName_A22535Value
		{
			get
			{
				short num = (short)652749123;
				short num2 = num;
				num = (short)597961027;
				switch (num2 == num)
				{
				}
				num = (short)1295122432;
				short num3 = num;
				num = (short)799997953;
				if (num != 0)
				{
				}
				num = (short)1400832000;
				if (num != 0)
				{
				}
				return this.internalMicNoiseReductionProfileName_A22535.Value;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)972816384;
					short num2 = num;
					num = (short)14548994;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)1016532240;
						short num4 = num;
						num = (short)257756432;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)468058112;
							if (num != 0)
							{
							}
							num = (short)2072248321;
							if (num != 0)
							{
							}
							switch (num3)
							{
							case 0:
								this.internalMicNoiseReductionProfileName_A22535.Value = value;
								num = (short)1252458497;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								return;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_CB;
								}
								continue;
							}
							IL_CB:
							if (string.IsNullOrEmpty(value.Trim()))
							{
								return;
							}
							num = (short)177668096;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
					}
				}
			}
		}

		// Token: 0x1700364C RID: 13900
		// (get) Token: 0x060068EE RID: 26862 RVA: 0x005E0388 File Offset: 0x005DE588
		// (set) Token: 0x060068EF RID: 26863 RVA: 0x005E043C File Offset: 0x005DE63C
		public string InternalMicNoiseReductionProfileName_A22535_UIValue
		{
			get
			{
				short num = (short)1794616696;
				short num2 = num;
				num = (short)2007543160;
				switch (num2 == num)
				{
				}
				num = (short)405995520;
				short num3 = num;
				num = (short)1987969025;
				if (num != 0)
				{
				}
				num = (short)919142400;
				if (num != 0)
				{
				}
				return this.internalMicNoiseReductionProfileName_A22535.Value;
			}
			set
			{
				short num = (short)1355519494;
				short num2 = num;
				num = (short)70817286;
				switch (num2 == num)
				{
				}
				num = (short)421003264;
				short num3 = num;
				num = (short)1649213441;
				if (num != 0)
				{
				}
				num = (short)322830336;
				if (num != 0)
				{
				}
				this.internalMicNoiseReductionProfileName_A22535.Value = value;
			}
		}

		// Token: 0x1700364D RID: 13901
		// (get) Token: 0x060068F0 RID: 26864 RVA: 0x005E04F0 File Offset: 0x005DE6F0
		public global::AcpBusinessLayer.AcpKeyField InternalMicNoiseReductionProfileName_A22535
		{
			get
			{
				short num = (short)361268373;
				short num2 = num;
				num = (short)1756595349;
				switch (num2 == num)
				{
				}
				num = (short)845545472;
				short num3 = num;
				num = (short)575078400;
				if (num != 0)
				{
				}
				num = (short)548077569;
				if (num != 0)
				{
				}
				return this.internalMicNoiseReductionProfileName_A22535;
			}
		}

		// Token: 0x1700364E RID: 13902
		// (get) Token: 0x060068F1 RID: 26865 RVA: 0x005E05A4 File Offset: 0x005DE7A4
		// (set) Token: 0x060068F2 RID: 26866 RVA: 0x005E065C File Offset: 0x005DE85C
		public bool InternalMicNoiseReductionProfileName_A22535_Applicable
		{
			get
			{
				short num = (short)990481541;
				short num2 = num;
				num = (short)328699013;
				switch (num2 == num)
				{
				}
				num = (short)1819934720;
				short num3 = num;
				num = (short)500695041;
				if (num != 0)
				{
				}
				num = (short)532742144;
				if (num != 0)
				{
				}
				return this.internalMicNoiseReductionProfileName_A22535.Applicable;
			}
			set
			{
				short num = (short)564654694;
				short num2 = num;
				num = (short)13496934;
				switch (num2 == num)
				{
				}
				num = (short)26673152;
				short num3 = num;
				num = (short)1121517569;
				if (num != 0)
				{
				}
				num = (short)813826048;
				if (num != 0)
				{
				}
				this.internalMicNoiseReductionProfileName_A22535.Applicable = value;
			}
		}

		// Token: 0x1700364F RID: 13903
		// (get) Token: 0x060068F3 RID: 26867 RVA: 0x005E0710 File Offset: 0x005DE910
		// (set) Token: 0x060068F4 RID: 26868 RVA: 0x005E07C4 File Offset: 0x005DE9C4
		public bool InternalMicNoiseReductionProfileName_A22535_Valid
		{
			get
			{
				short num = (short)2034446359;
				short num2 = num;
				num = (short)1427582999;
				switch (num2 == num)
				{
				}
				num = (short)771096576;
				short num3 = num;
				num = (short)144506881;
				if (num != 0)
				{
				}
				num = (short)662044672;
				if (num != 0)
				{
				}
				return this.internalMicNoiseReductionProfileName_A22535.Valid;
			}
			set
			{
				short num = (short)135278078;
				short num2 = num;
				num = (short)1026698750;
				switch (num2 == num)
				{
				}
				num = (short)341573632;
				short num3 = num;
				num = (short)651689985;
				if (num != 0)
				{
				}
				num = (short)854917120;
				if (num != 0)
				{
				}
				this.internalMicNoiseReductionProfileName_A22535.Valid = value;
			}
		}

		// Token: 0x17003650 RID: 13904
		// (get) Token: 0x060068F5 RID: 26869 RVA: 0x005E087C File Offset: 0x005DEA7C
		// (set) Token: 0x060068F6 RID: 26870 RVA: 0x005E0930 File Offset: 0x005DEB30
		public bool InternalMicNoiseReductionProfileName_A22535_Visible
		{
			get
			{
				short num = (short)518193153;
				if (num != 0)
				{
				}
				num = (short)652849762;
				short num2 = num;
				num = (short)1432662626;
				switch (num2 == num)
				{
				default:
				{
					num = (short)629342208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)993263616;
				if (num != 0)
				{
				}
				return this.internalMicNoiseReductionProfileName_A22535.Visible;
			}
			set
			{
				short num = (short)98263444;
				short num2 = num;
				num = (short)1453678996;
				switch (num2 == num)
				{
				}
				num = (short)1678442496;
				short num3 = num;
				num = (short)1839202305;
				if (num != 0)
				{
				}
				num = (short)1714421760;
				if (num != 0)
				{
				}
				this.internalMicNoiseReductionProfileName_A22535.Visible = value;
			}
		}

		// Token: 0x17003651 RID: 13905
		// (get) Token: 0x060068F7 RID: 26871 RVA: 0x005E09E4 File Offset: 0x005DEBE4
		// (set) Token: 0x060068F8 RID: 26872 RVA: 0x005E0A98 File Offset: 0x005DEC98
		public bool InternalMicNoiseReductionProfileName_A22535_Editable
		{
			get
			{
				short num = (short)190971000;
				short num2 = num;
				num = (short)486014072;
				switch (num2 == num)
				{
				}
				num = (short)1982791680;
				short num3 = num;
				num = (short)1938489345;
				if (num != 0)
				{
				}
				num = (short)1156841472;
				if (num != 0)
				{
				}
				return this.internalMicNoiseReductionProfileName_A22535.Editable;
			}
			set
			{
				short num = (short)116199780;
				short num2 = num;
				num = (short)307499364;
				switch (num2 == num)
				{
				}
				num = (short)916979712;
				short num3 = num;
				num = (short)1849032705;
				if (num != 0)
				{
				}
				num = (short)246677504;
				if (num != 0)
				{
				}
				this.internalMicNoiseReductionProfileName_A22535.Editable = value;
			}
		}

		// Token: 0x17003652 RID: 13906
		// (get) Token: 0x060068F9 RID: 26873 RVA: 0x005E0B50 File Offset: 0x005DED50
		internal string InternalMicNoiseReductionProfileName_A22535_UILabel
		{
			get
			{
				short num = (short)1316541874;
				short num2 = num;
				num = (short)170055090;
				switch (num2 == num)
				{
				}
				num = (short)1611857920;
				short num3 = num;
				num = (short)179372033;
				if (num != 0)
				{
				}
				num = (short)1246363648;
				if (num != 0)
				{
				}
				return this.internalMicNoiseReductionProfileName_A22535.UIName;
			}
		}

		// Token: 0x17003653 RID: 13907
		// (get) Token: 0x060068FA RID: 26874 RVA: 0x005E0C04 File Offset: 0x005DEE04
		// (set) Token: 0x060068FB RID: 26875 RVA: 0x005E0CB4 File Offset: 0x005DEEB4
		internal bool InternalMicNoiseReductionProfileName_A22535_HiddenStatic
		{
			get
			{
				short num = (short)855524735;
				short num2 = num;
				num = (short)1658668415;
				switch (num2 == num)
				{
				}
				num = (short)1454047232;
				short num3 = num;
				num = (short)377618433;
				if (num != 0)
				{
				}
				num = (short)985661440;
				if (num != 0)
				{
				}
				return this.internalMicNoiseReductionProfileName_A22535.HiddenStatic;
			}
			set
			{
				short num = (short)538436360;
				short num2 = num;
				num = (short)501801736;
				switch (num2 == num)
				{
				}
				num = (short)383385600;
				short num3 = num;
				num = (short)568918017;
				if (num != 0)
				{
				}
				num = (short)766836736;
				if (num != 0)
				{
				}
				this.internalMicNoiseReductionProfileName_A22535.HiddenStatic = value;
			}
		}

		// Token: 0x17003654 RID: 13908
		// (get) Token: 0x060068FC RID: 26876 RVA: 0x005E0D6C File Offset: 0x005DEF6C
		// (set) Token: 0x060068FD RID: 26877 RVA: 0x005E0E20 File Offset: 0x005DF020
		internal bool InternalMicNoiseReductionProfileName_A22535_HiddenDynamic
		{
			get
			{
				short num = (short)1487450761;
				short num2 = num;
				num = (short)486191753;
				switch (num2 == num)
				{
				}
				num = (short)981991424;
				short num3 = num;
				num = (short)43384833;
				if (num != 0)
				{
				}
				num = (short)2140209152;
				if (num != 0)
				{
				}
				return this.internalMicNoiseReductionProfileName_A22535.HiddenDynamic;
			}
			set
			{
				short num = (short)1910207700;
				short num2 = num;
				num = (short)487027924;
				switch (num2 == num)
				{
				}
				num = (short)319750144;
				short num3 = num;
				num = (short)1717108737;
				if (num != 0)
				{
				}
				num = (short)347275264;
				if (num != 0)
				{
				}
				this.internalMicNoiseReductionProfileName_A22535.HiddenDynamic = value;
			}
		}

		// Token: 0x17003655 RID: 13909
		// (get) Token: 0x060068FE RID: 26878 RVA: 0x005E0ED4 File Offset: 0x005DF0D4
		public bool InternalMicNoiseReductionProfileName_A22535_HasDiffs
		{
			get
			{
				short num = (short)462591996;
				short num2 = num;
				num = (short)1597347836;
				switch (num2 == num)
				{
				}
				num = (short)612958208;
				short num3 = num;
				num = (short)1003421697;
				if (num != 0)
				{
				}
				num = (short)1746337792;
				if (num != 0)
				{
				}
				return this.internalMicNoiseReductionProfileName_A22535._HasDiffs;
			}
		}

		// Token: 0x17003656 RID: 13910
		// (get) Token: 0x060068FF RID: 26879 RVA: 0x005E0F8C File Offset: 0x005DF18C
		// (set) Token: 0x06006900 RID: 26880 RVA: 0x005E1040 File Offset: 0x005DF240
		public string IntMicNsRdGenDINCOUTPUTEQVECTOR_A37718Value
		{
			get
			{
				short num = (short)1619159599;
				short num2 = num;
				num = (short)24078895;
				switch (num2 == num)
				{
				}
				num = (short)453640192;
				short num3 = num;
				num = (short)1634926593;
				if (num != 0)
				{
				}
				num = (short)1184890880;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718.Value;
			}
			set
			{
				short num = (short)673685994;
				short num2 = num;
				num = (short)374383082;
				switch (num2 == num)
				{
				}
				num = (short)1928921088;
				short num3 = num;
				num = (short)1196425217;
				if (num != 0)
				{
				}
				num = (short)2059862016;
				if (num != 0)
				{
				}
				this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718.Value = value;
			}
		}

		// Token: 0x17003657 RID: 13911
		// (get) Token: 0x06006901 RID: 26881 RVA: 0x005E10F8 File Offset: 0x005DF2F8
		public global::AcpBusinessLayer.AcpField<string> IntMicNsRdGenDINCOUTPUTEQVECTOR_A37718
		{
			get
			{
				short num = (short)288897316;
				short num2 = num;
				num = (short)1271609636;
				switch (num2 == num)
				{
				}
				num = (short)2107506688;
				short num3 = num;
				num = (short)330170369;
				if (num != 0)
				{
				}
				num = (short)1564409856;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718;
			}
		}

		// Token: 0x17003658 RID: 13912
		// (get) Token: 0x06006902 RID: 26882 RVA: 0x005E11A4 File Offset: 0x005DF3A4
		// (set) Token: 0x06006903 RID: 26883 RVA: 0x005E1258 File Offset: 0x005DF458
		public string IntMicNsRdGenDINCOUTPUTEQVECTOR_A37718_UIValue
		{
			get
			{
				short num = (short)414671918;
				short num2 = num;
				num = (short)1379886126;
				switch (num2 == num)
				{
				}
				num = (short)666435584;
				short num3 = num;
				num = (short)2048000001;
				if (num != 0)
				{
				}
				num = (short)1914437632;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718.Value;
			}
			set
			{
				short num = (short)1457067011;
				short num2 = num;
				num = (short)276632579;
				switch (num2 == num)
				{
				}
				num = (short)1477246976;
				short num3 = num;
				num = (short)388825089;
				if (num != 0)
				{
				}
				num = (short)1328611328;
				if (num != 0)
				{
				}
				this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718.Value = value;
			}
		}

		// Token: 0x17003659 RID: 13913
		// (get) Token: 0x06006904 RID: 26884 RVA: 0x005E130C File Offset: 0x005DF50C
		// (set) Token: 0x06006905 RID: 26885 RVA: 0x005E13C4 File Offset: 0x005DF5C4
		public bool IntMicNsRdGenDINCOUTPUTEQVECTOR_A37718_Applicable
		{
			get
			{
				short num = (short)197394433;
				if (num != 0)
				{
				}
				num = (short)331296608;
				short num2 = num;
				num = (short)26816352;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1452343296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)379715584;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718.Applicable;
			}
			set
			{
				short num = (short)395039881;
				short num2 = num;
				num = (short)837211273;
				switch (num2 == num)
				{
				}
				num = (short)1180172288;
				short num3 = num;
				num = (short)355794944;
				if (num != 0)
				{
				}
				num = (short)395706369;
				if (num != 0)
				{
				}
				this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718.Applicable = value;
			}
		}

		// Token: 0x1700365A RID: 13914
		// (get) Token: 0x06006906 RID: 26886 RVA: 0x005E1478 File Offset: 0x005DF678
		// (set) Token: 0x06006907 RID: 26887 RVA: 0x005E1528 File Offset: 0x005DF728
		public bool IntMicNsRdGenDINCOUTPUTEQVECTOR_A37718_Valid
		{
			get
			{
				short num = (short)1829699585;
				if (num != 0)
				{
				}
				num = (short)833876506;
				short num2 = num;
				num = (short)564458010;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1239941120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)688717824;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718.Valid;
			}
			set
			{
				short num = (short)1167883091;
				short num2 = num;
				num = (short)83917651;
				switch (num2 == num)
				{
				}
				num = (short)255524864;
				short num3 = num;
				num = (short)1266941952;
				if (num != 0)
				{
				}
				num = (short)1185349633;
				if (num != 0)
				{
				}
				this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718.Valid = value;
			}
		}

		// Token: 0x1700365B RID: 13915
		// (get) Token: 0x06006908 RID: 26888 RVA: 0x005E15E0 File Offset: 0x005DF7E0
		// (set) Token: 0x06006909 RID: 26889 RVA: 0x005E1698 File Offset: 0x005DF898
		public bool IntMicNsRdGenDINCOUTPUTEQVECTOR_A37718_Visible
		{
			get
			{
				short num = (short)1793303822;
				short num2 = num;
				num = (short)998417678;
				switch (num2 == num)
				{
				}
				num = (short)540475392;
				short num3 = num;
				num = (short)2061303808;
				if (num != 0)
				{
				}
				num = (short)599457793;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718.Visible;
			}
			set
			{
				short num = (short)1869021185;
				if (num != 0)
				{
				}
				num = (short)1810610728;
				short num2 = num;
				num = (short)1989196328;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1740832768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)357957632;
				if (num != 0)
				{
				}
				this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718.Visible = value;
			}
		}

		// Token: 0x1700365C RID: 13916
		// (get) Token: 0x0600690A RID: 26890 RVA: 0x005E1750 File Offset: 0x005DF950
		// (set) Token: 0x0600690B RID: 26891 RVA: 0x005E1804 File Offset: 0x005DFA04
		public bool IntMicNsRdGenDINCOUTPUTEQVECTOR_A37718_Editable
		{
			get
			{
				short num = (short)2014689657;
				short num2 = num;
				num = (short)1177598329;
				switch (num2 == num)
				{
				}
				num = (short)368050176;
				short num3 = num;
				num = (short)961871872;
				if (num != 0)
				{
				}
				num = (short)2104819713;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718.Editable;
			}
			set
			{
				short num = (short)1992744;
				short num2 = num;
				num = (short)278226984;
				switch (num2 == num)
				{
				}
				num = (short)789184512;
				short num3 = num;
				num = (short)666894337;
				if (num != 0)
				{
				}
				num = (short)1676738560;
				if (num != 0)
				{
				}
				this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718.Editable = value;
			}
		}

		// Token: 0x1700365D RID: 13917
		// (get) Token: 0x0600690C RID: 26892 RVA: 0x005E18BC File Offset: 0x005DFABC
		internal string IntMicNsRdGenDINCOUTPUTEQVECTOR_A37718_UILabel
		{
			get
			{
				short num = (short)1110167483;
				short num2 = num;
				num = (short)2099695547;
				switch (num2 == num)
				{
				}
				num = (short)412876800;
				short num3 = num;
				num = (short)10682368;
				if (num != 0)
				{
				}
				num = (short)1871380481;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718.UIName;
			}
		}

		// Token: 0x1700365E RID: 13918
		// (get) Token: 0x0600690D RID: 26893 RVA: 0x005E1970 File Offset: 0x005DFB70
		// (set) Token: 0x0600690E RID: 26894 RVA: 0x005E1A24 File Offset: 0x005DFC24
		internal bool IntMicNsRdGenDINCOUTPUTEQVECTOR_A37718_HiddenStatic
		{
			get
			{
				short num = (short)941257451;
				short num2 = num;
				num = (short)219575019;
				switch (num2 == num)
				{
				}
				num = (short)851181568;
				short num3 = num;
				num = (short)23724033;
				if (num != 0)
				{
				}
				num = (short)833224704;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718.HiddenStatic;
			}
			set
			{
				short num = (short)2025134877;
				short num2 = num;
				num = (short)1305352989;
				switch (num2 == num)
				{
				}
				num = (short)463273984;
				short num3 = num;
				num = (short)962330625;
				if (num != 0)
				{
				}
				num = (short)24510464;
				if (num != 0)
				{
				}
				this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718.HiddenStatic = value;
			}
		}

		// Token: 0x1700365F RID: 13919
		// (get) Token: 0x0600690F RID: 26895 RVA: 0x005E1AD8 File Offset: 0x005DFCD8
		// (set) Token: 0x06006910 RID: 26896 RVA: 0x005E1B90 File Offset: 0x005DFD90
		internal bool IntMicNsRdGenDINCOUTPUTEQVECTOR_A37718_HiddenDynamic
		{
			get
			{
				short num = (short)1327901419;
				short num2 = num;
				num = (short)1572154091;
				switch (num2 == num)
				{
				}
				num = (short)821100544;
				short num3 = num;
				num = (short)1687093249;
				if (num != 0)
				{
				}
				num = (short)1638006784;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718.HiddenDynamic;
			}
			set
			{
				short num = (short)833629813;
				short num2 = num;
				num = (short)1204825717;
				switch (num2 == num)
				{
				}
				num = (short)1222508544;
				short num3 = num;
				num = (short)263782401;
				if (num != 0)
				{
				}
				num = (short)521994240;
				if (num != 0)
				{
				}
				this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718.HiddenDynamic = value;
			}
		}

		// Token: 0x17003660 RID: 13920
		// (get) Token: 0x06006911 RID: 26897 RVA: 0x005E1C44 File Offset: 0x005DFE44
		public bool IntMicNsRdGenDINCOUTPUTEQVECTOR_A37718_HasDiffs
		{
			get
			{
				short num = (short)2057633793;
				if (num != 0)
				{
				}
				num = (short)1829975244;
				short num2 = num;
				num = (short)502478028;
				switch (num2 == num)
				{
				}
				num = (short)827260928;
				short num3 = num;
				num = (short)1114963968;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenDINCOUTPUTEQVECTOR_A37718._HasDiffs;
			}
		}

		// Token: 0x17003661 RID: 13921
		// (get) Token: 0x06006912 RID: 26898 RVA: 0x005E1CF4 File Offset: 0x005DFEF4
		// (set) Token: 0x06006913 RID: 26899 RVA: 0x005E1DAC File Offset: 0x005DFFAC
		public string IntMicNsRdGenDINCEPVECTOR_A37719Value
		{
			get
			{
				short num = (short)1215673599;
				short num2 = num;
				num = (short)1709487359;
				switch (num2 == num)
				{
				}
				num = (short)1824784385;
				if (num != 0)
				{
				}
				num = (short)1142751232;
				short num3 = num;
				num = (short)697565184;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenDINCEPVECTOR_A37719.Value;
			}
			set
			{
				short num = (short)947807345;
				short num2 = num;
				num = (short)769025137;
				switch (num2 == num)
				{
				}
				num = (short)597950465;
				if (num != 0)
				{
				}
				num = (short)1147797504;
				short num3 = num;
				num = (short)1222836224;
				if (num != 0)
				{
				}
				this.intMicNsRdGenDINCEPVECTOR_A37719.Value = value;
			}
		}

		// Token: 0x17003662 RID: 13922
		// (get) Token: 0x06006914 RID: 26900 RVA: 0x005E1E64 File Offset: 0x005E0064
		public global::AcpBusinessLayer.AcpField<string> IntMicNsRdGenDINCEPVECTOR_A37719
		{
			get
			{
				short num = (short)1208754060;
				short num2 = num;
				num = (short)1234706316;
				switch (num2 == num)
				{
				}
				num = (short)1764622337;
				if (num != 0)
				{
				}
				num = (short)1654718464;
				short num3 = num;
				num = (short)1992359936;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenDINCEPVECTOR_A37719;
			}
		}

		// Token: 0x17003663 RID: 13923
		// (get) Token: 0x06006915 RID: 26901 RVA: 0x005E1F10 File Offset: 0x005E0110
		// (set) Token: 0x06006916 RID: 26902 RVA: 0x005E1FC4 File Offset: 0x005E01C4
		public string IntMicNsRdGenDINCEPVECTOR_A37719_UIValue
		{
			get
			{
				short num = (short)40390894;
				short num2 = num;
				num = (short)344871150;
				switch (num2 == num)
				{
				}
				num = (short)57933825;
				if (num != 0)
				{
				}
				num = (short)1988165632;
				short num3 = num;
				num = (short)1520828416;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenDINCEPVECTOR_A37719.Value;
			}
			set
			{
				short num = (short)312606721;
				if (num != 0)
				{
				}
				num = (short)287287157;
				short num2 = num;
				num = (short)2081007477;
				switch (num2 == num)
				{
				}
				num = (short)178520064;
				short num3 = num;
				num = (short)1337786368;
				if (num != 0)
				{
				}
				this.intMicNsRdGenDINCEPVECTOR_A37719.Value = value;
			}
		}

		// Token: 0x17003664 RID: 13924
		// (get) Token: 0x06006917 RID: 26903 RVA: 0x005E2078 File Offset: 0x005E0278
		// (set) Token: 0x06006918 RID: 26904 RVA: 0x005E212C File Offset: 0x005E032C
		public bool IntMicNsRdGenDINCEPVECTOR_A37719_Applicable
		{
			get
			{
				short num = (short)317063964;
				short num2 = num;
				num = (short)1151140636;
				switch (num2 == num)
				{
				}
				num = (short)384761857;
				if (num != 0)
				{
				}
				num = (short)1854930944;
				short num3 = num;
				num = (short)628490240;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenDINCEPVECTOR_A37719.Applicable;
			}
			set
			{
				short num = (short)1178368027;
				short num2 = num;
				num = (short)1758820379;
				switch (num2 == num)
				{
				}
				num = (short)1554448385;
				if (num != 0)
				{
				}
				num = (short)1737555968;
				short num3 = num;
				num = (short)566099968;
				if (num != 0)
				{
				}
				this.intMicNsRdGenDINCEPVECTOR_A37719.Applicable = value;
			}
		}

		// Token: 0x17003665 RID: 13925
		// (get) Token: 0x06006919 RID: 26905 RVA: 0x005E21E0 File Offset: 0x005E03E0
		// (set) Token: 0x0600691A RID: 26906 RVA: 0x005E2294 File Offset: 0x005E0494
		public bool IntMicNsRdGenDINCEPVECTOR_A37719_Valid
		{
			get
			{
				short num = (short)1050321430;
				short num2 = num;
				num = (short)2127929878;
				switch (num2 == num)
				{
				}
				num = (short)1713373185;
				if (num != 0)
				{
				}
				num = (short)387121152;
				short num3 = num;
				num = (short)6094848;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenDINCEPVECTOR_A37719.Valid;
			}
			set
			{
				short num = (short)683604890;
				short num2 = num;
				num = (short)99023770;
				switch (num2 == num)
				{
				}
				num = (short)1949827072;
				if (num != 0)
				{
				}
				num = (short)2004746240;
				short num3 = num;
				num = (short)66453505;
				if (num != 0)
				{
				}
				this.intMicNsRdGenDINCEPVECTOR_A37719.Valid = value;
			}
		}

		// Token: 0x17003666 RID: 13926
		// (get) Token: 0x0600691B RID: 26907 RVA: 0x005E2348 File Offset: 0x005E0548
		// (set) Token: 0x0600691C RID: 26908 RVA: 0x005E2400 File Offset: 0x005E0600
		public bool IntMicNsRdGenDINCEPVECTOR_A37719_Visible
		{
			get
			{
				short num = (short)1738507931;
				short num2 = num;
				num = (short)1770620571;
				switch (num2 == num)
				{
				}
				num = (short)1878392832;
				if (num != 0)
				{
				}
				num = (short)1521876992;
				short num3 = num;
				num = (short)1118240769;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenDINCEPVECTOR_A37719.Visible;
			}
			set
			{
				short num = (short)1546585130;
				short num2 = num;
				num = (short)931988522;
				switch (num2 == num)
				{
				}
				num = (short)2060910593;
				if (num != 0)
				{
				}
				num = (short)1122041856;
				short num3 = num;
				num = (short)1844183040;
				if (num != 0)
				{
				}
				this.intMicNsRdGenDINCEPVECTOR_A37719.Visible = value;
			}
		}

		// Token: 0x17003667 RID: 13927
		// (get) Token: 0x0600691D RID: 26909 RVA: 0x005E24B8 File Offset: 0x005E06B8
		// (set) Token: 0x0600691E RID: 26910 RVA: 0x005E256C File Offset: 0x005E076C
		public bool IntMicNsRdGenDINCEPVECTOR_A37719_Editable
		{
			get
			{
				short num = (short)515178497;
				if (num != 0)
				{
				}
				num = (short)1297362026;
				short num2 = num;
				num = (short)1329081450;
				switch (num2 == num)
				{
				}
				num = (short)1845821440;
				short num3 = num;
				num = (short)1920073728;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenDINCEPVECTOR_A37719.Editable;
			}
			set
			{
				short num = (short)1945894913;
				if (num != 0)
				{
				}
				num = (short)1664350102;
				short num2 = num;
				num = (short)1514010518;
				switch (num2 == num)
				{
				}
				num = (short)2082340864;
				short num3 = num;
				num = (short)1720647680;
				if (num != 0)
				{
				}
				this.intMicNsRdGenDINCEPVECTOR_A37719.Editable = value;
			}
		}

		// Token: 0x17003668 RID: 13928
		// (get) Token: 0x0600691F RID: 26911 RVA: 0x005E2620 File Offset: 0x005E0820
		internal string IntMicNsRdGenDINCEPVECTOR_A37719_UILabel
		{
			get
			{
				short num = (short)811195202;
				short num2 = num;
				num = (short)1065016130;
				switch (num2 == num)
				{
				}
				num = (short)214695937;
				if (num != 0)
				{
				}
				num = (short)1031536640;
				short num3 = num;
				num = (short)18612224;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenDINCEPVECTOR_A37719.UIName;
			}
		}

		// Token: 0x17003669 RID: 13929
		// (get) Token: 0x06006920 RID: 26912 RVA: 0x005E26D4 File Offset: 0x005E08D4
		// (set) Token: 0x06006921 RID: 26913 RVA: 0x005E278C File Offset: 0x005E098C
		internal bool IntMicNsRdGenDINCEPVECTOR_A37719_HiddenStatic
		{
			get
			{
				short num = (short)568546126;
				short num2 = num;
				num = (short)829903694;
				switch (num2 == num)
				{
				}
				num = (short)1340080128;
				if (num != 0)
				{
				}
				num = (short)1069940736;
				short num3 = num;
				num = (short)1280901121;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenDINCEPVECTOR_A37719.HiddenStatic;
			}
			set
			{
				short num = (short)722579722;
				short num2 = num;
				num = (short)963293450;
				switch (num2 == num)
				{
				}
				num = (short)48758785;
				if (num != 0)
				{
				}
				num = (short)310706176;
				short num3 = num;
				num = (short)89194496;
				if (num != 0)
				{
				}
				this.intMicNsRdGenDINCEPVECTOR_A37719.HiddenStatic = value;
			}
		}

		// Token: 0x1700366A RID: 13930
		// (get) Token: 0x06006922 RID: 26914 RVA: 0x005E2840 File Offset: 0x005E0A40
		// (set) Token: 0x06006923 RID: 26915 RVA: 0x005E28F4 File Offset: 0x005E0AF4
		internal bool IntMicNsRdGenDINCEPVECTOR_A37719_HiddenDynamic
		{
			get
			{
				short num = (short)1504458016;
				short num2 = num;
				num = (short)350434592;
				switch (num2 == num)
				{
				}
				num = (short)1738407937;
				if (num != 0)
				{
				}
				num = (short)1622343680;
				short num3 = num;
				num = (short)592773120;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenDINCEPVECTOR_A37719.HiddenDynamic;
			}
			set
			{
				short num = (short)1454702593;
				if (num != 0)
				{
				}
				num = (short)1518792734;
				short num2 = num;
				num = (short)526250014;
				switch (num2 == num)
				{
				}
				num = (short)36372480;
				short num3 = num;
				num = (short)1698299904;
				if (num != 0)
				{
				}
				this.intMicNsRdGenDINCEPVECTOR_A37719.HiddenDynamic = value;
			}
		}

		// Token: 0x1700366B RID: 13931
		// (get) Token: 0x06006924 RID: 26916 RVA: 0x005E29A8 File Offset: 0x005E0BA8
		public bool IntMicNsRdGenDINCEPVECTOR_A37719_HasDiffs
		{
			get
			{
				short num = (short)794863842;
				short num2 = num;
				num = (short)543926498;
				switch (num2 == num)
				{
				}
				num = (short)354746368;
				if (num != 0)
				{
				}
				num = (short)1775042560;
				short num3 = num;
				num = (short)2124218369;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenDINCEPVECTOR_A37719._HasDiffs;
			}
		}

		// Token: 0x1700366C RID: 13932
		// (get) Token: 0x06006925 RID: 26917 RVA: 0x005E2A5C File Offset: 0x005E0C5C
		// (set) Token: 0x06006926 RID: 26918 RVA: 0x005E2B10 File Offset: 0x005E0D10
		public int RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566Value
		{
			get
			{
				short num = (short)151951732;
				short num2 = num;
				num = (short)1796774260;
				switch (num2 == num)
				{
				}
				num = (short)875495425;
				if (num != 0)
				{
				}
				num = (short)536018944;
				short num3 = num;
				num = (short)1306722304;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.Value;
			}
			set
			{
				short num = (short)1427072678;
				short num2 = num;
				num = (short)1288791718;
				switch (num2 == num)
				{
				}
				num = (short)484966401;
				if (num != 0)
				{
				}
				num = (short)1775828992;
				short num3 = num;
				num = (short)263913472;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.Value = value;
			}
		}

		// Token: 0x1700366D RID: 13933
		// (get) Token: 0x06006927 RID: 26919 RVA: 0x005E2BC4 File Offset: 0x005E0DC4
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566
		{
			get
			{
				short num = (short)913879052;
				short num2 = num;
				num = (short)1428008972;
				switch (num2 == num)
				{
				}
				num = (short)624492544;
				if (num != 0)
				{
				}
				num = (short)260767744;
				short num3 = num;
				num = (short)1801912321;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566;
			}
		}

		// Token: 0x1700366E RID: 13934
		// (get) Token: 0x06006928 RID: 26920 RVA: 0x005E2C78 File Offset: 0x005E0E78
		// (set) Token: 0x06006929 RID: 26921 RVA: 0x005E2D2C File Offset: 0x005E0F2C
		public string RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566_UIValue
		{
			get
			{
				short num = (short)626301546;
				short num2 = num;
				num = (short)1687788138;
				switch (num2 == num)
				{
				}
				num = (short)2100232193;
				if (num != 0)
				{
				}
				num = (short)96468992;
				short num3 = num;
				num = (short)940638208;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.UIValue;
			}
			set
			{
				short num = (short)494171923;
				short num2 = num;
				num = (short)993556243;
				switch (num2 == num)
				{
				}
				num = (short)21495809;
				if (num != 0)
				{
				}
				num = (short)1800404992;
				short num3 = num;
				num = (short)1447690240;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.UIValue = value;
			}
		}

		// Token: 0x1700366F RID: 13935
		// (get) Token: 0x0600692A RID: 26922 RVA: 0x005E2DE4 File Offset: 0x005E0FE4
		// (set) Token: 0x0600692B RID: 26923 RVA: 0x005E2E9C File Offset: 0x005E109C
		public string RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566_HexUIValue
		{
			get
			{
				short num = (short)1784187656;
				short num2 = num;
				num = (short)491621128;
				switch (num2 == num)
				{
				}
				num = (short)951386113;
				if (num != 0)
				{
				}
				num = (short)933691392;
				short num3 = num;
				num = (short)639369216;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.HexUIValue;
			}
			set
			{
				short num = (short)1530754005;
				short num2 = num;
				num = (short)1845523413;
				switch (num2 == num)
				{
				}
				num = (short)1326841857;
				if (num != 0)
				{
				}
				num = (short)1783496704;
				short num3 = num;
				num = (short)302383104;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.HexUIValue = value;
			}
		}

		// Token: 0x17003670 RID: 13936
		// (get) Token: 0x0600692C RID: 26924 RVA: 0x005E2F50 File Offset: 0x005E1150
		// (set) Token: 0x0600692D RID: 26925 RVA: 0x005E3004 File Offset: 0x005E1204
		internal int RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566Min
		{
			get
			{
				short num = (short)442759401;
				short num2 = num;
				num = (short)611776745;
				switch (num2 == num)
				{
				}
				num = (short)1994719233;
				if (num != 0)
				{
				}
				num = (short)2095841280;
				short num3 = num;
				num = (short)358285312;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.Min;
			}
			set
			{
				short num = (short)624753003;
				short num2 = num;
				num = (short)168360299;
				switch (num2 == num)
				{
				}
				num = (short)486211585;
				if (num != 0)
				{
				}
				num = (short)2084962304;
				short num3 = num;
				num = (short)333578240;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.Min = value;
			}
		}

		// Token: 0x17003671 RID: 13937
		// (get) Token: 0x0600692E RID: 26926 RVA: 0x005E30BC File Offset: 0x005E12BC
		// (set) Token: 0x0600692F RID: 26927 RVA: 0x005E3174 File Offset: 0x005E1374
		internal int RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566Max
		{
			get
			{
				short num = (short)260320445;
				short num2 = num;
				num = (short)417017021;
				switch (num2 == num)
				{
				}
				num = (short)56229888;
				if (num != 0)
				{
				}
				num = (short)486670336;
				short num3 = num;
				num = (short)653000705;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.Max;
			}
			set
			{
				short num = (short)376544888;
				short num2 = num;
				num = (short)59547256;
				switch (num2 == num)
				{
				}
				num = (short)930283521;
				if (num != 0)
				{
				}
				num = (short)1894645760;
				short num3 = num;
				num = (short)928186368;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.Max = value;
			}
		}

		// Token: 0x17003672 RID: 13938
		// (get) Token: 0x06006930 RID: 26928 RVA: 0x005E322C File Offset: 0x005E142C
		// (set) Token: 0x06006931 RID: 26929 RVA: 0x005E32E0 File Offset: 0x005E14E0
		internal int RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566Step
		{
			get
			{
				short num = (short)280494081;
				if (num != 0)
				{
				}
				num = (short)1573960340;
				short num2 = num;
				num = (short)328120980;
				switch (num2 == num)
				{
				}
				num = (short)644349952;
				short num3 = num;
				num = (short)1856045056;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.StepSize;
			}
			set
			{
				short num = (short)1866472083;
				short num2 = num;
				num = (short)1339300499;
				switch (num2 == num)
				{
				}
				num = (short)847708160;
				if (num != 0)
				{
				}
				num = (short)1481572352;
				short num3 = num;
				num = (short)214237185;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.StepSize = value;
			}
		}

		// Token: 0x17003673 RID: 13939
		// (get) Token: 0x06006932 RID: 26930 RVA: 0x005E3398 File Offset: 0x005E1598
		// (set) Token: 0x06006933 RID: 26931 RVA: 0x005E344C File Offset: 0x005E164C
		public bool RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566_Applicable
		{
			get
			{
				short num = (short)933429249;
				if (num != 0)
				{
				}
				num = (short)1687467154;
				short num2 = num;
				num = (short)149075090;
				switch (num2 == num)
				{
				}
				num = (short)942669824;
				short num3 = num;
				num = (short)1433534464;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.Applicable;
			}
			set
			{
				short num = (short)1715240381;
				short num2 = num;
				num = (short)1093434813;
				switch (num2 == num)
				{
				}
				num = (short)447938561;
				if (num != 0)
				{
				}
				num = (short)747241472;
				short num3 = num;
				num = (short)294453248;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.Applicable = value;
			}
		}

		// Token: 0x17003674 RID: 13940
		// (get) Token: 0x06006934 RID: 26932 RVA: 0x005E3500 File Offset: 0x005E1700
		// (set) Token: 0x06006935 RID: 26933 RVA: 0x005E35B8 File Offset: 0x005E17B8
		public bool RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566_Valid
		{
			get
			{
				short num = (short)1330446337;
				if (num != 0)
				{
				}
				num = (short)1685962708;
				short num2 = num;
				num = (short)246661076;
				switch (num2 == num)
				{
				}
				num = (short)527695872;
				short num3 = num;
				num = (short)1641742336;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.Valid;
			}
			set
			{
				short num = (short)1211052938;
				short num2 = num;
				num = (short)1205416842;
				switch (num2 == num)
				{
				}
				num = (short)778305536;
				if (num != 0)
				{
				}
				num = (short)1954611200;
				short num3 = num;
				num = (short)868220929;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.Valid = value;
			}
		}

		// Token: 0x17003675 RID: 13941
		// (get) Token: 0x06006936 RID: 26934 RVA: 0x005E366C File Offset: 0x005E186C
		// (set) Token: 0x06006937 RID: 26935 RVA: 0x005E3720 File Offset: 0x005E1920
		public bool RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566_Visible
		{
			get
			{
				short num = (short)336874147;
				short num2 = num;
				num = (short)1905150627;
				switch (num2 == num)
				{
				}
				num = (short)602669057;
				if (num != 0)
				{
				}
				num = (short)998834176;
				short num3 = num;
				num = (short)870973440;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.Visible;
			}
			set
			{
				short num = (short)308150273;
				if (num != 0)
				{
				}
				num = (short)596857083;
				short num2 = num;
				num = (short)691163387;
				switch (num2 == num)
				{
				}
				num = (short)726532096;
				short num3 = num;
				num = (short)455606272;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.Visible = value;
			}
		}

		// Token: 0x17003676 RID: 13942
		// (get) Token: 0x06006938 RID: 26936 RVA: 0x005E37D8 File Offset: 0x005E19D8
		// (set) Token: 0x06006939 RID: 26937 RVA: 0x005E3890 File Offset: 0x005E1A90
		public bool RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566_Editable
		{
			get
			{
				short num = (short)817037313;
				if (num != 0)
				{
				}
				num = (short)1517523375;
				short num2 = num;
				num = (short)758944175;
				switch (num2 == num)
				{
				}
				num = (short)387121152;
				short num3 = num;
				num = (short)1515651072;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.Editable;
			}
			set
			{
				short num = (short)376373249;
				if (num != 0)
				{
				}
				num = (short)1369334033;
				short num2 = num;
				num = (short)1896177937;
				switch (num2 == num)
				{
				}
				num = (short)231473152;
				short num3 = num;
				num = (short)2042036224;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.Editable = value;
			}
		}

		// Token: 0x17003677 RID: 13943
		// (get) Token: 0x0600693A RID: 26938 RVA: 0x005E3944 File Offset: 0x005E1B44
		internal string RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566_UILabel
		{
			get
			{
				short num = (short)389782503;
				short num2 = num;
				num = (short)1535286247;
				switch (num2 == num)
				{
				}
				num = (short)991363072;
				if (num != 0)
				{
				}
				num = (short)1632829440;
				short num3 = num;
				num = (short)296222721;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.UIName;
			}
		}

		// Token: 0x17003678 RID: 13944
		// (get) Token: 0x0600693B RID: 26939 RVA: 0x005E39F8 File Offset: 0x005E1BF8
		// (set) Token: 0x0600693C RID: 26940 RVA: 0x005E3AAC File Offset: 0x005E1CAC
		internal bool RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566_HiddenStatic
		{
			get
			{
				short num = (short)17075530;
				short num2 = num;
				num = (short)1038716234;
				switch (num2 == num)
				{
				}
				num = (short)1687420929;
				if (num != 0)
				{
				}
				num = (short)152764416;
				short num3 = num;
				num = (short)1588592640;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.HiddenStatic;
			}
			set
			{
				short num = (short)1383979247;
				short num2 = num;
				num = (short)1846597871;
				switch (num2 == num)
				{
				}
				num = (short)868024320;
				if (num != 0)
				{
				}
				num = (short)1721499648;
				short num3 = num;
				num = (short)484900865;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.HiddenStatic = value;
			}
		}

		// Token: 0x17003679 RID: 13945
		// (get) Token: 0x0600693D RID: 26941 RVA: 0x005E3B64 File Offset: 0x005E1D64
		// (set) Token: 0x0600693E RID: 26942 RVA: 0x005E3C18 File Offset: 0x005E1E18
		internal bool RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566_HiddenDynamic
		{
			get
			{
				short num = (short)890596223;
				short num2 = num;
				num = (short)933194623;
				switch (num2 == num)
				{
				}
				num = (short)1264320513;
				if (num != 0)
				{
				}
				num = (short)711524352;
				short num3 = num;
				num = (short)280821760;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.HiddenDynamic;
			}
			set
			{
				short num = (short)1951889192;
				short num2 = num;
				num = (short)837580584;
				switch (num2 == num)
				{
				}
				num = (short)1910439937;
				if (num != 0)
				{
				}
				num = (short)1523122176;
				short num3 = num;
				num = (short)1536884736;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566.HiddenDynamic = value;
			}
		}

		// Token: 0x1700367A RID: 13946
		// (get) Token: 0x0600693F RID: 26943 RVA: 0x005E3CCC File Offset: 0x005E1ECC
		public bool RadErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566_HasDiffs
		{
			get
			{
				short num = (short)1980332196;
				short num2 = num;
				num = (short)129464484;
				switch (num2 == num)
				{
				}
				num = (short)1608450048;
				if (num != 0)
				{
				}
				num = (short)1431830528;
				short num3 = num;
				num = (short)1140064257;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566._HasDiffs;
			}
		}

		// Token: 0x1700367B RID: 13947
		// (get) Token: 0x06006940 RID: 26944 RVA: 0x005E3D80 File Offset: 0x005E1F80
		// (set) Token: 0x06006941 RID: 26945 RVA: 0x005E3E30 File Offset: 0x005E2030
		public int RadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569Value
		{
			get
			{
				short num = (short)345293457;
				short num2 = num;
				num = (short)526762641;
				switch (num2 == num)
				{
				}
				num = (short)692322304;
				if (num != 0)
				{
				}
				num = (short)1719074816;
				short num3 = num;
				num = (short)1200750593;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.Value;
			}
			set
			{
				short num = (short)1610210870;
				short num2 = num;
				num = (short)970382902;
				switch (num2 == num)
				{
				}
				num = (short)451411969;
				if (num != 0)
				{
				}
				num = (short)1625292800;
				short num3 = num;
				num = (short)1993342976;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.Value = value;
			}
		}

		// Token: 0x1700367C RID: 13948
		// (get) Token: 0x06006942 RID: 26946 RVA: 0x005E3EE4 File Offset: 0x005E20E4
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569
		{
			get
			{
				short num = (short)1652364506;
				short num2 = num;
				num = (short)236459226;
				switch (num2 == num)
				{
				}
				num = (short)1959067649;
				if (num != 0)
				{
				}
				num = (short)1277493248;
				short num3 = num;
				num = (short)310116352;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569;
			}
		}

		// Token: 0x1700367D RID: 13949
		// (get) Token: 0x06006943 RID: 26947 RVA: 0x005E3F94 File Offset: 0x005E2194
		// (set) Token: 0x06006944 RID: 26948 RVA: 0x005E4048 File Offset: 0x005E2248
		public string RadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569_UIValue
		{
			get
			{
				short num = (short)2009276081;
				short num2 = num;
				num = (short)2073566897;
				switch (num2 == num)
				{
				}
				num = (short)2027421697;
				if (num != 0)
				{
				}
				num = (short)378863616;
				short num3 = num;
				num = (short)2012282880;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.UIValue;
			}
			set
			{
				short num = (short)1675771339;
				short num2 = num;
				num = (short)1264139723;
				switch (num2 == num)
				{
				}
				num = (short)146472961;
				if (num != 0)
				{
				}
				num = (short)434176000;
				short num3 = num;
				num = (short)2077687808;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.UIValue = value;
			}
		}

		// Token: 0x1700367E RID: 13950
		// (get) Token: 0x06006945 RID: 26949 RVA: 0x005E40FC File Offset: 0x005E22FC
		// (set) Token: 0x06006946 RID: 26950 RVA: 0x005E41B0 File Offset: 0x005E23B0
		public string RadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569_HexUIValue
		{
			get
			{
				short num = (short)186264319;
				short num2 = num;
				num = (short)2109745919;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1916993536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1426456577;
				if (num != 0)
				{
				}
				num = (short)511377408;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.HexUIValue;
			}
			set
			{
				short num = (short)921403912;
				short num2 = num;
				num = (short)384139784;
				switch (num2 == num)
				{
				default:
				{
					num = (short)96010240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)482476032;
				if (num != 0)
				{
				}
				num = (short)2028077057;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.HexUIValue = value;
			}
		}

		// Token: 0x1700367F RID: 13951
		// (get) Token: 0x06006947 RID: 26951 RVA: 0x005E4268 File Offset: 0x005E2468
		// (set) Token: 0x06006948 RID: 26952 RVA: 0x005E4320 File Offset: 0x005E2520
		internal int RadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569Min
		{
			get
			{
				short num = (short)346488833;
				if (num != 0)
				{
				}
				num = (short)1973288960;
				short num2 = num;
				num = (short)1532204289;
				short num3 = num;
				num = (short)1269601537;
				switch (num3 == num)
				{
				}
				num = (short)1250820096;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.Min;
			}
			set
			{
				short num = (short)49401381;
				short num2 = num;
				num = (short)1681182245;
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
				num = (short)1155203072;
				if (num != 0)
				{
				}
				num = (short)1818886145;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.Min = value;
			}
		}

		// Token: 0x17003680 RID: 13952
		// (get) Token: 0x06006949 RID: 26953 RVA: 0x005E43D8 File Offset: 0x005E25D8
		// (set) Token: 0x0600694A RID: 26954 RVA: 0x005E448C File Offset: 0x005E268C
		internal int RadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569Max
		{
			get
			{
				short num = (short)1484391667;
				short num2 = num;
				num = (short)735118579;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1881997312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)151388161;
				if (num != 0)
				{
				}
				num = (short)1882521600;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.Max;
			}
			set
			{
				short num = (short)1226164743;
				short num2 = num;
				num = (short)853330439;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1975648256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1748500481;
				if (num != 0)
				{
				}
				num = (short)335020032;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.Max = value;
			}
		}

		// Token: 0x17003681 RID: 13953
		// (get) Token: 0x0600694B RID: 26955 RVA: 0x005E4540 File Offset: 0x005E2740
		// (set) Token: 0x0600694C RID: 26956 RVA: 0x005E45F4 File Offset: 0x005E27F4
		internal int RadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569Step
		{
			get
			{
				short num = (short)1212983416;
				short num2 = num;
				num = (short)795715704;
				switch (num2 == num)
				{
				default:
				{
					num = (short)432734208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)938278912;
				if (num != 0)
				{
				}
				num = (short)136052737;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.StepSize;
			}
			set
			{
				short num = (short)419874278;
				short num2 = num;
				num = (short)1731904998;
				switch (num2 == num)
				{
				default:
				{
					num = (short)34537472;
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
				num = (short)632750080;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.StepSize = value;
			}
		}

		// Token: 0x17003682 RID: 13954
		// (get) Token: 0x0600694D RID: 26957 RVA: 0x005E46A8 File Offset: 0x005E28A8
		// (set) Token: 0x0600694E RID: 26958 RVA: 0x005E475C File Offset: 0x005E295C
		public bool RadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569_Applicable
		{
			get
			{
				short num = (short)39334815;
				short num2 = num;
				num = (short)1443967903;
				switch (num2 == num)
				{
				default:
				{
					num = (short)247857152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1857093633;
				if (num != 0)
				{
				}
				num = (short)1128857600;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.Applicable;
			}
			set
			{
				short num = (short)498797107;
				short num2 = num;
				num = (short)467405363;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1618935808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)994050049;
				if (num != 0)
				{
				}
				num = (short)1949106176;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.Applicable = value;
			}
		}

		// Token: 0x17003683 RID: 13955
		// (get) Token: 0x0600694F RID: 26959 RVA: 0x005E4810 File Offset: 0x005E2A10
		// (set) Token: 0x06006950 RID: 26960 RVA: 0x005E48C8 File Offset: 0x005E2AC8
		public bool RadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569_Valid
		{
			get
			{
				short num = (short)458194608;
				short num2 = num;
				num = (short)696680112;
				switch (num2 == num)
				{
				default:
				{
					num = (short)126746624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1699348481;
				if (num != 0)
				{
				}
				num = (short)1695809536;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.Valid;
			}
			set
			{
				short num = (short)438138201;
				short num2 = num;
				num = (short)1772647769;
				switch (num2 == num)
				{
				default:
				{
					num = (short)326631424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1160708097;
				if (num != 0)
				{
				}
				num = (short)1142816768;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.Valid = value;
			}
		}

		// Token: 0x17003684 RID: 13956
		// (get) Token: 0x06006951 RID: 26961 RVA: 0x005E4980 File Offset: 0x005E2B80
		// (set) Token: 0x06006952 RID: 26962 RVA: 0x005E4A34 File Offset: 0x005E2C34
		public bool RadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569_Visible
		{
			get
			{
				short num = (short)1329683745;
				short num2 = num;
				num = (short)1733516577;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1656422400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1447231489;
				if (num != 0)
				{
				}
				num = (short)581435392;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.Visible;
			}
			set
			{
				short num = (short)1310051334;
				short num2 = num;
				num = (short)1459735558;
				switch (num2 == num)
				{
				default:
				{
					num = (short)956891136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)811073536;
				if (num != 0)
				{
				}
				num = (short)1753546753;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.Visible = value;
			}
		}

		// Token: 0x17003685 RID: 13957
		// (get) Token: 0x06006953 RID: 26963 RVA: 0x005E4AE8 File Offset: 0x005E2CE8
		// (set) Token: 0x06006954 RID: 26964 RVA: 0x005E4BA0 File Offset: 0x005E2DA0
		public bool RadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569_Editable
		{
			get
			{
				short num = (short)1706486166;
				short num2 = num;
				num = (short)373942678;
				switch (num2 == num)
				{
				default:
				{
					num = (short)676855808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)29425665;
				if (num != 0)
				{
				}
				num = (short)72941568;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.Editable;
			}
			set
			{
				short num = (short)1823277057;
				if (num != 0)
				{
				}
				num = (short)433782784;
				short num2 = num;
				num = (short)443971543;
				short num3 = num;
				num = (short)924415959;
				switch (num3 == num)
				{
				}
				num = (short)1148977152;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.Editable = value;
			}
		}

		// Token: 0x17003686 RID: 13958
		// (get) Token: 0x06006955 RID: 26965 RVA: 0x005E4C58 File Offset: 0x005E2E58
		internal string RadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569_UILabel
		{
			get
			{
				short num = (short)159939033;
				short num2 = num;
				num = (short)60717529;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1057423360;
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
				num = (short)310640641;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.UIName;
			}
		}

		// Token: 0x17003687 RID: 13959
		// (get) Token: 0x06006956 RID: 26966 RVA: 0x005E4D10 File Offset: 0x005E2F10
		// (set) Token: 0x06006957 RID: 26967 RVA: 0x005E4DC4 File Offset: 0x005E2FC4
		internal bool RadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569_HiddenStatic
		{
			get
			{
				short num = (short)2050497389;
				short num2 = num;
				num = (short)1245846381;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1596653568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)869728257;
				if (num != 0)
				{
				}
				num = (short)408748032;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.HiddenStatic;
			}
			set
			{
				short num = (short)14557124;
				short num2 = num;
				num = (short)1286021060;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2140667904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1416364032;
				if (num != 0)
				{
				}
				num = (short)1891958785;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.HiddenStatic = value;
			}
		}

		// Token: 0x17003688 RID: 13960
		// (get) Token: 0x06006958 RID: 26968 RVA: 0x005E4E7C File Offset: 0x005E307C
		// (set) Token: 0x06006959 RID: 26969 RVA: 0x005E4F34 File Offset: 0x005E3134
		internal bool RadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569_HiddenDynamic
		{
			get
			{
				short num = (short)534839297;
				if (num != 0)
				{
				}
				num = (short)821100544;
				short num2 = num;
				num = (short)1398498919;
				short num3 = num;
				num = (short)2078893671;
				switch (num3 == num)
				{
				}
				num = (short)1750269952;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.HiddenDynamic;
			}
			set
			{
				short num = (short)1448600612;
				short num2 = num;
				num = (short)113894436;
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
				num = (short)42205185;
				if (num != 0)
				{
				}
				num = (short)1267138560;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569.HiddenDynamic = value;
			}
		}

		// Token: 0x17003689 RID: 13961
		// (get) Token: 0x0600695A RID: 26970 RVA: 0x005E4FEC File Offset: 0x005E31EC
		public bool RadErgoCfgGeneralINACTIVETHRESHDBQ8_A21569_HasDiffs
		{
			get
			{
				short num = (short)1493524079;
				short num2 = num;
				num = (short)414277231;
				switch (num2 == num)
				{
				default:
				{
					num = (short)87425024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1186529280;
				if (num != 0)
				{
				}
				num = (short)1049362433;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569._HasDiffs;
			}
		}

		// Token: 0x1700368A RID: 13962
		// (get) Token: 0x0600695B RID: 26971 RVA: 0x005E50A0 File Offset: 0x005E32A0
		// (set) Token: 0x0600695C RID: 26972 RVA: 0x005E5154 File Offset: 0x005E3354
		public int RadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571Value
		{
			get
			{
				short num = (short)2124040144;
				short num2 = num;
				num = (short)1819822032;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2041577472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)113311744;
				if (num != 0)
				{
				}
				num = (short)826671105;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.Value;
			}
			set
			{
				short num = (short)1314585997;
				short num2 = num;
				num = (short)1792474509;
				switch (num2 == num)
				{
				default:
				{
					num = (short)745209856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)108199937;
				if (num != 0)
				{
				}
				num = (short)1415970816;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.Value = value;
			}
		}

		// Token: 0x1700368B RID: 13963
		// (get) Token: 0x0600695D RID: 26973 RVA: 0x005E520C File Offset: 0x005E340C
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571
		{
			get
			{
				short num = (short)2126174555;
				short num2 = num;
				num = (short)1139792219;
				switch (num2 == num)
				{
				default:
				{
					num = (short)866516992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)916258817;
				if (num != 0)
				{
				}
				num = (short)224657408;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571;
			}
		}

		// Token: 0x1700368C RID: 13964
		// (get) Token: 0x0600695E RID: 26974 RVA: 0x005E52BC File Offset: 0x005E34BC
		// (set) Token: 0x0600695F RID: 26975 RVA: 0x005E5370 File Offset: 0x005E3570
		public string RadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571_UIValue
		{
			get
			{
				short num = (short)526833436;
				short num2 = num;
				num = (short)366794524;
				switch (num2 == num)
				{
				default:
				{
					num = (short)942997504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)160235520;
				if (num != 0)
				{
				}
				num = (short)571211777;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.UIValue;
			}
			set
			{
				short num = (short)509607937;
				if (num != 0)
				{
				}
				num = (short)946929664;
				short num2 = num;
				num = (short)1193815787;
				short num3 = num;
				num = (short)1154166507;
				switch (num3 == num)
				{
				}
				num = (short)675872768;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.UIValue = value;
			}
		}

		// Token: 0x1700368D RID: 13965
		// (get) Token: 0x06006960 RID: 26976 RVA: 0x005E5428 File Offset: 0x005E3628
		// (set) Token: 0x06006961 RID: 26977 RVA: 0x005E54DC File Offset: 0x005E36DC
		public string RadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571_HexUIValue
		{
			get
			{
				short num = (short)386858987;
				short num2 = num;
				num = (short)1669660651;
				switch (num2 == num)
				{
				default:
				{
					num = (short)121241600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)725942273;
				if (num != 0)
				{
				}
				num = (short)604241920;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.HexUIValue;
			}
			set
			{
				short num = (short)1620906595;
				short num2 = num;
				num = (short)1075712611;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1621688320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1092288512;
				if (num != 0)
				{
				}
				num = (short)1481179137;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.HexUIValue = value;
			}
		}

		// Token: 0x1700368E RID: 13966
		// (get) Token: 0x06006962 RID: 26978 RVA: 0x005E5590 File Offset: 0x005E3790
		// (set) Token: 0x06006963 RID: 26979 RVA: 0x005E5648 File Offset: 0x005E3848
		internal int RadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571Min
		{
			get
			{
				short num = (short)1024438596;
				short num2 = num;
				num = (short)318878020;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1022885888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1695023105;
				if (num != 0)
				{
				}
				num = (short)1762525184;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.Min;
			}
			set
			{
				short num = (short)473111218;
				short num2 = num;
				num = (short)359799474;
				switch (num2 == num)
				{
				default:
				{
					num = (short)854261760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)354942977;
				if (num != 0)
				{
				}
				num = (short)1177944064;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.Min = value;
			}
		}

		// Token: 0x1700368F RID: 13967
		// (get) Token: 0x06006964 RID: 26980 RVA: 0x005E56FC File Offset: 0x005E38FC
		// (set) Token: 0x06006965 RID: 26981 RVA: 0x005E57B4 File Offset: 0x005E39B4
		internal int RadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571Max
		{
			get
			{
				short num = (short)132048017;
				short num2 = num;
				num = (short)1026417809;
				switch (num2 == num)
				{
				default:
				{
					num = (short)142475264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)548339713;
				if (num != 0)
				{
				}
				num = (short)372637696;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.Max;
			}
			set
			{
				short num = (short)1613434380;
				short num2 = num;
				num = (short)1316359692;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1029767168;
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
				num = (short)1999765504;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.Max = value;
			}
		}

		// Token: 0x17003690 RID: 13968
		// (get) Token: 0x06006966 RID: 26982 RVA: 0x005E586C File Offset: 0x005E3A6C
		// (set) Token: 0x06006967 RID: 26983 RVA: 0x005E5920 File Offset: 0x005E3B20
		internal int RadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571Step
		{
			get
			{
				short num = (short)2142240769;
				if (num != 0)
				{
				}
				num = (short)1879834624;
				short num2 = num;
				num = (short)1223254189;
				short num3 = num;
				num = (short)530014381;
				switch (num3 == num)
				{
				}
				num = (short)790429696;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.StepSize;
			}
			set
			{
				short num = (short)1320193940;
				short num2 = num;
				num = (short)1864470420;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1360527360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)945291265;
				if (num != 0)
				{
				}
				num = (short)2118778880;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.StepSize = value;
			}
		}

		// Token: 0x17003691 RID: 13969
		// (get) Token: 0x06006968 RID: 26984 RVA: 0x005E59D4 File Offset: 0x005E3BD4
		// (set) Token: 0x06006969 RID: 26985 RVA: 0x005E5A88 File Offset: 0x005E3C88
		public bool RadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571_Applicable
		{
			get
			{
				short num = (short)2064121857;
				if (num != 0)
				{
				}
				num = (short)618856448;
				short num2 = num;
				num = (short)1011652746;
				short num3 = num;
				num = (short)232953994;
				switch (num3 == num)
				{
				}
				num = (short)991363072;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.Applicable;
			}
			set
			{
				short num = (short)370475009;
				if (num != 0)
				{
				}
				num = (short)87949312;
				short num2 = num;
				num = (short)1046749073;
				short num3 = num;
				num = (short)145432465;
				switch (num3 == num)
				{
				}
				num = (short)586743808;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.Applicable = value;
			}
		}

		// Token: 0x17003692 RID: 13970
		// (get) Token: 0x0600696A RID: 26986 RVA: 0x005E5B3C File Offset: 0x005E3D3C
		// (set) Token: 0x0600696B RID: 26987 RVA: 0x005E5BF0 File Offset: 0x005E3DF0
		public bool RadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571_Valid
		{
			get
			{
				short num = (short)1198370711;
				short num2 = num;
				num = (short)1053077399;
				switch (num2 == num)
				{
				default:
				{
					num = (short)127270912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)461570049;
				if (num != 0)
				{
				}
				num = (short)1626013696;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.Valid;
			}
			set
			{
				short num = (short)296205025;
				short num2 = num;
				num = (short)406108897;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1792016384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1625161728;
				if (num != 0)
				{
				}
				num = (short)1153957889;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.Valid = value;
			}
		}

		// Token: 0x17003693 RID: 13971
		// (get) Token: 0x0600696C RID: 26988 RVA: 0x005E5CA4 File Offset: 0x005E3EA4
		// (set) Token: 0x0600696D RID: 26989 RVA: 0x005E5D5C File Offset: 0x005E3F5C
		public bool RadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571_Visible
		{
			get
			{
				short num = (short)1315858818;
				short num2 = num;
				num = (short)140011906;
				switch (num2 == num)
				{
				}
				num = (short)1068302336;
				short num3 = num;
				num = (short)319422465;
				if (num != 0)
				{
				}
				num = (short)910491648;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.Visible;
			}
			set
			{
				short num = (short)1888395818;
				short num2 = num;
				num = (short)770613802;
				switch (num2 == num)
				{
				}
				num = (short)1250361344;
				short num3 = num;
				num = (short)1599406081;
				if (num != 0)
				{
				}
				num = (short)1225326592;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.Visible = value;
			}
		}

		// Token: 0x17003694 RID: 13972
		// (get) Token: 0x0600696E RID: 26990 RVA: 0x005E5E14 File Offset: 0x005E4014
		// (set) Token: 0x0600696F RID: 26991 RVA: 0x005E5EC8 File Offset: 0x005E40C8
		public bool RadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571_Editable
		{
			get
			{
				short num = (short)81431317;
				short num2 = num;
				num = (short)128551701;
				switch (num2 == num)
				{
				}
				num = (short)1458044928;
				short num3 = num;
				num = (short)1950023681;
				if (num != 0)
				{
				}
				num = (short)479068160;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.Editable;
			}
			set
			{
				short num = (short)708926991;
				short num2 = num;
				num = (short)1587830287;
				switch (num2 == num)
				{
				}
				num = (short)590741504;
				short num3 = num;
				num = (short)1974337537;
				if (num != 0)
				{
				}
				num = (short)555220992;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.Editable = value;
			}
		}

		// Token: 0x17003695 RID: 13973
		// (get) Token: 0x06006970 RID: 26992 RVA: 0x005E5F80 File Offset: 0x005E4180
		internal string RadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571_UILabel
		{
			get
			{
				short num = (short)1542870750;
				short num2 = num;
				num = (short)45700830;
				switch (num2 == num)
				{
				}
				num = (short)1849425920;
				short num3 = num;
				num = (short)237436929;
				if (num != 0)
				{
				}
				num = (short)1786183680;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.UIName;
			}
		}

		// Token: 0x17003696 RID: 13974
		// (get) Token: 0x06006971 RID: 26993 RVA: 0x005E6034 File Offset: 0x005E4234
		// (set) Token: 0x06006972 RID: 26994 RVA: 0x005E60E8 File Offset: 0x005E42E8
		internal bool RadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571_HiddenStatic
		{
			get
			{
				short num = (short)399383863;
				short num2 = num;
				num = (short)1598364983;
				switch (num2 == num)
				{
				}
				num = (short)71041024;
				short num3 = num;
				num = (short)340197377;
				if (num != 0)
				{
				}
				num = (short)259719168;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.HiddenStatic;
			}
			set
			{
				short num = (short)1481709552;
				short num2 = num;
				num = (short)995104752;
				switch (num2 == num)
				{
				}
				num = (short)1255538688;
				short num3 = num;
				num = (short)195166209;
				if (num != 0)
				{
				}
				num = (short)1255669760;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.HiddenStatic = value;
			}
		}

		// Token: 0x17003697 RID: 13975
		// (get) Token: 0x06006973 RID: 26995 RVA: 0x005E619C File Offset: 0x005E439C
		// (set) Token: 0x06006974 RID: 26996 RVA: 0x005E6250 File Offset: 0x005E4450
		internal bool RadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571_HiddenDynamic
		{
			get
			{
				short num = (short)243104717;
				short num2 = num;
				num = (short)290094029;
				switch (num2 == num)
				{
				}
				num = (short)1947992064;
				short num3 = num;
				num = (short)482344961;
				if (num != 0)
				{
				}
				num = (short)241041408;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.HiddenDynamic;
			}
			set
			{
				short num = (short)2088935288;
				short num2 = num;
				num = (short)1076273016;
				switch (num2 == num)
				{
				}
				num = (short)1618804736;
				short num3 = num;
				num = (short)1352138753;
				if (num != 0)
				{
				}
				num = (short)725549056;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571.HiddenDynamic = value;
			}
		}

		// Token: 0x17003698 RID: 13976
		// (get) Token: 0x06006975 RID: 26997 RVA: 0x005E630C File Offset: 0x005E450C
		public bool RadErgoCfgGeneralNDIFFTHRESHDBQ8_A21571_HasDiffs
		{
			get
			{
				short num = (short)578391441;
				short num2 = num;
				num = (short)2133393;
				switch (num2 == num)
				{
				}
				num = (short)1706622976;
				short num3 = num;
				num = (short)1542914048;
				if (num != 0)
				{
				}
				num = (short)560005121;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571._HasDiffs;
			}
		}

		// Token: 0x17003699 RID: 13977
		// (get) Token: 0x06006976 RID: 26998 RVA: 0x005E63C0 File Offset: 0x005E45C0
		// (set) Token: 0x06006977 RID: 26999 RVA: 0x005E6474 File Offset: 0x005E4674
		public int RadErgoCfgGeneralRTHRESHDBQ8_A21572Value
		{
			get
			{
				short num = (short)326041804;
				short num2 = num;
				num = (short)144244940;
				switch (num2 == num)
				{
				}
				num = (short)1260191744;
				short num3 = num;
				num = (short)1259732992;
				if (num != 0)
				{
				}
				num = (short)87883777;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralRTHRESHDBQ8_A21572.Value;
			}
			set
			{
				short num = (short)1266043063;
				short num2 = num;
				num = (short)1081886903;
				switch (num2 == num)
				{
				}
				num = (short)1835139072;
				short num3 = num;
				num = (short)1036451840;
				if (num != 0)
				{
				}
				num = (short)2056978433;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralRTHRESHDBQ8_A21572.Value = value;
			}
		}

		// Token: 0x1700369A RID: 13978
		// (get) Token: 0x06006978 RID: 27000 RVA: 0x005E652C File Offset: 0x005E472C
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgGeneralRTHRESHDBQ8_A21572
		{
			get
			{
				short num = (short)682869449;
				short num2 = num;
				num = (short)1944699593;
				switch (num2 == num)
				{
				}
				num = (short)1883308032;
				short num3 = num;
				num = (short)1869479937;
				if (num != 0)
				{
				}
				num = (short)2008088576;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralRTHRESHDBQ8_A21572;
			}
		}

		// Token: 0x1700369B RID: 13979
		// (get) Token: 0x06006979 RID: 27001 RVA: 0x005E65DC File Offset: 0x005E47DC
		// (set) Token: 0x0600697A RID: 27002 RVA: 0x005E6690 File Offset: 0x005E4890
		public string RadErgoCfgGeneralRTHRESHDBQ8_A21572_UIValue
		{
			get
			{
				short num = (short)89715989;
				short num2 = num;
				num = (short)178713877;
				switch (num2 == num)
				{
				}
				num = (short)336003072;
				short num3 = num;
				num = (short)1688141825;
				if (num != 0)
				{
				}
				num = (short)1497956352;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralRTHRESHDBQ8_A21572.UIValue;
			}
			set
			{
				short num = (short)820623434;
				short num2 = num;
				num = (short)1964947530;
				switch (num2 == num)
				{
				}
				num = (short)912064512;
				short num3 = num;
				num = (short)843513857;
				if (num != 0)
				{
				}
				num = (short)1149304832;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralRTHRESHDBQ8_A21572.UIValue = value;
			}
		}

		// Token: 0x1700369C RID: 13980
		// (get) Token: 0x0600697B RID: 27003 RVA: 0x005E6744 File Offset: 0x005E4944
		// (set) Token: 0x0600697C RID: 27004 RVA: 0x005E67FC File Offset: 0x005E49FC
		public string RadErgoCfgGeneralRTHRESHDBQ8_A21572_HexUIValue
		{
			get
			{
				short num = (short)1425932289;
				if (num != 0)
				{
				}
				num = (short)869554598;
				short num2 = num;
				num = (short)103176614;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1230110720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1436614656;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralRTHRESHDBQ8_A21572.HexUIValue;
			}
			set
			{
				short num = (short)1490537616;
				short num2 = num;
				num = (short)434031760;
				switch (num2 == num)
				{
				}
				num = (short)1040318464;
				short num3 = num;
				num = (short)191299585;
				if (num != 0)
				{
				}
				num = (short)2081816576;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralRTHRESHDBQ8_A21572.HexUIValue = value;
			}
		}

		// Token: 0x1700369D RID: 13981
		// (get) Token: 0x0600697D RID: 27005 RVA: 0x005E68B0 File Offset: 0x005E4AB0
		// (set) Token: 0x0600697E RID: 27006 RVA: 0x005E6964 File Offset: 0x005E4B64
		internal int RadErgoCfgGeneralRTHRESHDBQ8_A21572Min
		{
			get
			{
				short num = (short)1495924737;
				if (num != 0)
				{
				}
				num = (short)1525692984;
				short num2 = num;
				num = (short)1609251384;
				switch (num2 == num)
				{
				default:
				{
					num = (short)383254528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1325268992;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralRTHRESHDBQ8_A21572.Min;
			}
			set
			{
				short num = (short)2145163123;
				short num2 = num;
				num = (short)952407923;
				switch (num2 == num)
				{
				}
				num = (short)2093940736;
				short num3 = num;
				num = (short)1695547393;
				if (num != 0)
				{
				}
				num = (short)145031168;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralRTHRESHDBQ8_A21572.Min = value;
			}
		}

		// Token: 0x1700369E RID: 13982
		// (get) Token: 0x0600697F RID: 27007 RVA: 0x005E6A1C File Offset: 0x005E4C1C
		// (set) Token: 0x06006980 RID: 27008 RVA: 0x005E6AD4 File Offset: 0x005E4CD4
		internal int RadErgoCfgGeneralRTHRESHDBQ8_A21572Max
		{
			get
			{
				short num = (short)909440201;
				short num2 = num;
				num = (short)1325987017;
				switch (num2 == num)
				{
				}
				num = (short)1782710272;
				short num3 = num;
				num = (short)495779841;
				if (num != 0)
				{
				}
				num = (short)1876361216;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralRTHRESHDBQ8_A21572.Max;
			}
			set
			{
				short num = (short)1922313687;
				short num2 = num;
				num = (short)201797079;
				switch (num2 == num)
				{
				}
				num = (short)1038090240;
				short num3 = num;
				num = (short)683606017;
				if (num != 0)
				{
				}
				num = (short)797310976;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralRTHRESHDBQ8_A21572.Max = value;
			}
		}

		// Token: 0x1700369F RID: 13983
		// (get) Token: 0x06006981 RID: 27009 RVA: 0x005E6B88 File Offset: 0x005E4D88
		// (set) Token: 0x06006982 RID: 27010 RVA: 0x005E6C40 File Offset: 0x005E4E40
		internal int RadErgoCfgGeneralRTHRESHDBQ8_A21572Step
		{
			get
			{
				short num = (short)1633943553;
				if (num != 0)
				{
				}
				num = (short)1278122780;
				short num2 = num;
				num = (short)1102945052;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1580597248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1800929280;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralRTHRESHDBQ8_A21572.StepSize;
			}
			set
			{
				short num = (short)2084677773;
				short num2 = num;
				num = (short)581281933;
				switch (num2 == num)
				{
				}
				num = (short)316801024;
				short num3 = num;
				num = (short)1009451009;
				if (num != 0)
				{
				}
				num = (short)770899968;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralRTHRESHDBQ8_A21572.StepSize = value;
			}
		}

		// Token: 0x170036A0 RID: 13984
		// (get) Token: 0x06006983 RID: 27011 RVA: 0x005E6CF4 File Offset: 0x005E4EF4
		// (set) Token: 0x06006984 RID: 27012 RVA: 0x005E6DAC File Offset: 0x005E4FAC
		public bool RadErgoCfgGeneralRTHRESHDBQ8_A21572_Applicable
		{
			get
			{
				short num = (short)1633203074;
				short num2 = num;
				num = (short)840676226;
				switch (num2 == num)
				{
				}
				num = (short)1434976256;
				short num3 = num;
				num = (short)384565249;
				if (num != 0)
				{
				}
				num = (short)144048128;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralRTHRESHDBQ8_A21572.Applicable;
			}
			set
			{
				short num = (short)2035778139;
				short num2 = num;
				num = (short)854950491;
				switch (num2 == num)
				{
				}
				num = (short)786759680;
				short num3 = num;
				num = (short)1847394304;
				if (num != 0)
				{
				}
				num = (short)1729167361;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralRTHRESHDBQ8_A21572.Applicable = value;
			}
		}

		// Token: 0x170036A1 RID: 13985
		// (get) Token: 0x06006985 RID: 27013 RVA: 0x005E6E64 File Offset: 0x005E5064
		// (set) Token: 0x06006986 RID: 27014 RVA: 0x005E6F18 File Offset: 0x005E5118
		public bool RadErgoCfgGeneralRTHRESHDBQ8_A21572_Valid
		{
			get
			{
				short num = (short)1993011072;
				short num2 = num;
				num = (short)1495461760;
				switch (num2 == num)
				{
				}
				num = (short)407961600;
				short num3 = num;
				num = (short)638648320;
				if (num != 0)
				{
				}
				num = (short)1007616001;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralRTHRESHDBQ8_A21572.Valid;
			}
			set
			{
				short num = (short)1919195678;
				short num2 = num;
				num = (short)807574046;
				switch (num2 == num)
				{
				}
				num = (short)150405120;
				short num3 = num;
				num = (short)666828800;
				if (num != 0)
				{
				}
				num = (short)1959002113;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralRTHRESHDBQ8_A21572.Valid = value;
			}
		}

		// Token: 0x170036A2 RID: 13986
		// (get) Token: 0x06006987 RID: 27015 RVA: 0x005E6FCC File Offset: 0x005E51CC
		// (set) Token: 0x06006988 RID: 27016 RVA: 0x005E7080 File Offset: 0x005E5280
		public bool RadErgoCfgGeneralRTHRESHDBQ8_A21572_Visible
		{
			get
			{
				short num = (short)2136866817;
				if (num != 0)
				{
				}
				num = (short)1379493709;
				short num2 = num;
				num = (short)867592013;
				switch (num2 == num)
				{
				default:
				{
					num = (short)22544384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)882049024;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralRTHRESHDBQ8_A21572.Visible;
			}
			set
			{
				short num = (short)1703279732;
				short num2 = num;
				num = (short)945421428;
				switch (num2 == num)
				{
				}
				num = (short)892272640;
				short num3 = num;
				num = (short)11468801;
				if (num != 0)
				{
				}
				num = (short)2046820352;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralRTHRESHDBQ8_A21572.Visible = value;
			}
		}

		// Token: 0x170036A3 RID: 13987
		// (get) Token: 0x06006989 RID: 27017 RVA: 0x005E7134 File Offset: 0x005E5334
		// (set) Token: 0x0600698A RID: 27018 RVA: 0x005E71E8 File Offset: 0x005E53E8
		public bool RadErgoCfgGeneralRTHRESHDBQ8_A21572_Editable
		{
			get
			{
				short num = (short)1102527602;
				short num2 = num;
				num = (short)108018802;
				switch (num2 == num)
				{
				}
				num = (short)1047855104;
				short num3 = num;
				num = (short)1837236225;
				if (num != 0)
				{
				}
				num = (short)1080557568;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralRTHRESHDBQ8_A21572.Editable;
			}
			set
			{
				short num = (short)637358347;
				short num2 = num;
				num = (short)1139298571;
				switch (num2 == num)
				{
				}
				num = (short)1118371840;
				short num3 = num;
				num = (short)757792769;
				if (num != 0)
				{
				}
				num = (short)507445248;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralRTHRESHDBQ8_A21572.Editable = value;
			}
		}

		// Token: 0x170036A4 RID: 13988
		// (get) Token: 0x0600698B RID: 27019 RVA: 0x005E72A0 File Offset: 0x005E54A0
		internal string RadErgoCfgGeneralRTHRESHDBQ8_A21572_UILabel
		{
			get
			{
				short num = (short)1255823430;
				short num2 = num;
				num = (short)996038726;
				switch (num2 == num)
				{
				}
				num = (short)619511808;
				short num3 = num;
				num = (short)1274544128;
				if (num != 0)
				{
				}
				num = (short)1499004929;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralRTHRESHDBQ8_A21572.UIName;
			}
		}

		// Token: 0x170036A5 RID: 13989
		// (get) Token: 0x0600698C RID: 27020 RVA: 0x005E7354 File Offset: 0x005E5554
		// (set) Token: 0x0600698D RID: 27021 RVA: 0x005E7408 File Offset: 0x005E5608
		internal bool RadErgoCfgGeneralRTHRESHDBQ8_A21572_HiddenStatic
		{
			get
			{
				short num = (short)240765506;
				short num2 = num;
				num = (short)650562114;
				switch (num2 == num)
				{
				}
				num = (short)1026031616;
				short num3 = num;
				num = (short)1022951425;
				if (num != 0)
				{
				}
				num = (short)365101056;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralRTHRESHDBQ8_A21572.HiddenStatic;
			}
			set
			{
				short num = (short)159342732;
				short num2 = num;
				num = (short)377512076;
				switch (num2 == num)
				{
				}
				num = (short)454950912;
				short num3 = num;
				num = (short)1143996417;
				if (num != 0)
				{
				}
				num = (short)1598488576;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralRTHRESHDBQ8_A21572.HiddenStatic = value;
			}
		}

		// Token: 0x170036A6 RID: 13990
		// (get) Token: 0x0600698E RID: 27022 RVA: 0x005E74C0 File Offset: 0x005E56C0
		// (set) Token: 0x0600698F RID: 27023 RVA: 0x005E7574 File Offset: 0x005E5774
		internal bool RadErgoCfgGeneralRTHRESHDBQ8_A21572_HiddenDynamic
		{
			get
			{
				short num = (short)495302209;
				short num2 = num;
				num = (short)1458681409;
				switch (num2 == num)
				{
				}
				num = (short)971046912;
				short num3 = num;
				num = (short)1176174593;
				if (num != 0)
				{
				}
				num = (short)928645120;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralRTHRESHDBQ8_A21572.HiddenDynamic;
			}
			set
			{
				short num = (short)1447412796;
				short num2 = num;
				num = (short)1915143228;
				switch (num2 == num)
				{
				}
				num = (short)569769984;
				short num3 = num;
				num = (short)1021313024;
				if (num != 0)
				{
				}
				num = (short)788398081;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralRTHRESHDBQ8_A21572.HiddenDynamic = value;
			}
		}

		// Token: 0x170036A7 RID: 13991
		// (get) Token: 0x06006990 RID: 27024 RVA: 0x005E762C File Offset: 0x005E582C
		public bool RadErgoCfgGeneralRTHRESHDBQ8_A21572_HasDiffs
		{
			get
			{
				short num = (short)1292261647;
				short num2 = num;
				num = (short)1344035087;
				switch (num2 == num)
				{
				}
				num = (short)1385824256;
				short num3 = num;
				num = (short)2079457281;
				if (num != 0)
				{
				}
				num = (short)1880555520;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralRTHRESHDBQ8_A21572._HasDiffs;
			}
		}

		// Token: 0x170036A8 RID: 13992
		// (get) Token: 0x06006991 RID: 27025 RVA: 0x005E76E0 File Offset: 0x005E58E0
		// (set) Token: 0x06006992 RID: 27026 RVA: 0x005E7798 File Offset: 0x005E5998
		public int RadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570Value
		{
			get
			{
				short num = (short)862781535;
				short num2 = num;
				num = (short)291831903;
				switch (num2 == num)
				{
				}
				num = (short)317128704;
				short num3 = num;
				num = (short)2127691777;
				if (num != 0)
				{
				}
				num = (short)154009600;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.Value;
			}
			set
			{
				short num = (short)1075310833;
				short num2 = num;
				num = (short)1527378161;
				switch (num2 == num)
				{
				}
				num = (short)171311104;
				short num3 = num;
				num = (short)648151041;
				if (num != 0)
				{
				}
				num = (short)1390673920;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.Value = value;
			}
		}

		// Token: 0x170036A9 RID: 13993
		// (get) Token: 0x06006993 RID: 27027 RVA: 0x005E7850 File Offset: 0x005E5A50
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570
		{
			get
			{
				short num = (short)972816385;
				if (num != 0)
				{
				}
				num = (short)915267669;
				short num2 = num;
				num = (short)2049040469;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1969553408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1554382848;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570;
			}
		}

		// Token: 0x170036AA RID: 13994
		// (get) Token: 0x06006994 RID: 27028 RVA: 0x005E7900 File Offset: 0x005E5B00
		// (set) Token: 0x06006995 RID: 27029 RVA: 0x005E79B0 File Offset: 0x005E5BB0
		public string RadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570_UIValue
		{
			get
			{
				short num = (short)1883750763;
				short num2 = num;
				num = (short)1956626795;
				switch (num2 == num)
				{
				}
				num = (short)93782016;
				short num3 = num;
				num = (short)959184897;
				if (num != 0)
				{
				}
				num = (short)1797652480;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.UIValue;
			}
			set
			{
				short num = (short)276388687;
				short num2 = num;
				num = (short)1606507343;
				switch (num2 == num)
				{
				}
				num = (short)651427840;
				short num3 = num;
				num = (short)2059730945;
				if (num != 0)
				{
				}
				num = (short)473235456;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.UIValue = value;
			}
		}

		// Token: 0x170036AB RID: 13995
		// (get) Token: 0x06006996 RID: 27030 RVA: 0x005E7A64 File Offset: 0x005E5C64
		// (set) Token: 0x06006997 RID: 27031 RVA: 0x005E7B18 File Offset: 0x005E5D18
		public string RadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570_HexUIValue
		{
			get
			{
				short num = (short)1713999730;
				short num2 = num;
				num = (short)1028755314;
				switch (num2 == num)
				{
				}
				num = (short)517144576;
				short num3 = num;
				num = (short)503185409;
				if (num != 0)
				{
				}
				num = (short)1820196864;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.HexUIValue;
			}
			set
			{
				short num = (short)1902735961;
				short num2 = num;
				num = (short)1312256601;
				switch (num2 == num)
				{
				}
				num = (short)1118175232;
				short num3 = num;
				num = (short)1880096769;
				if (num != 0)
				{
				}
				num = (short)660340736;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.HexUIValue = value;
			}
		}

		// Token: 0x170036AC RID: 13996
		// (get) Token: 0x06006998 RID: 27032 RVA: 0x005E7BD0 File Offset: 0x005E5DD0
		// (set) Token: 0x06006999 RID: 27033 RVA: 0x005E7C84 File Offset: 0x005E5E84
		internal int RadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570Min
		{
			get
			{
				short num = (short)670175639;
				short num2 = num;
				num = (short)1113330071;
				switch (num2 == num)
				{
				}
				num = (short)1164050432;
				short num3 = num;
				num = (short)58982401;
				if (num != 0)
				{
				}
				num = (short)655491072;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.Min;
			}
			set
			{
				short num = (short)1315268748;
				short num2 = num;
				num = (short)1252157580;
				switch (num2 == num)
				{
				}
				num = (short)1182531584;
				short num3 = num;
				num = (short)886702081;
				if (num != 0)
				{
				}
				num = (short)818479104;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.Min = value;
			}
		}

		// Token: 0x170036AD RID: 13997
		// (get) Token: 0x0600699A RID: 27034 RVA: 0x005E7D38 File Offset: 0x005E5F38
		// (set) Token: 0x0600699B RID: 27035 RVA: 0x005E7DEC File Offset: 0x005E5FEC
		internal int RadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570Max
		{
			get
			{
				short num = (short)1279219689;
				short num2 = num;
				num = (short)1297242089;
				switch (num2 == num)
				{
				}
				num = (short)1159528448;
				short num3 = num;
				num = (short)1251803137;
				if (num != 0)
				{
				}
				num = (short)841023488;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.Max;
			}
			set
			{
				short num = (short)1167912827;
				short num2 = num;
				num = (short)397930363;
				switch (num2 == num)
				{
				}
				num = (short)218955776;
				short num3 = num;
				num = (short)829882368;
				if (num != 0)
				{
				}
				num = (short)1555169281;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.Max = value;
			}
		}

		// Token: 0x170036AE RID: 13998
		// (get) Token: 0x0600699C RID: 27036 RVA: 0x005E7EA0 File Offset: 0x005E60A0
		// (set) Token: 0x0600699D RID: 27037 RVA: 0x005E7F54 File Offset: 0x005E6154
		internal int RadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570Step
		{
			get
			{
				short num = (short)718099905;
				short num2 = num;
				num = (short)511858113;
				switch (num2 == num)
				{
				}
				num = (short)1286144000;
				short num3 = num;
				num = (short)441974785;
				if (num != 0)
				{
				}
				num = (short)489947136;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.StepSize;
			}
			set
			{
				short num = (short)1514733569;
				if (num != 0)
				{
				}
				num = (short)1636828934;
				short num2 = num;
				num = (short)1293420294;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1353449472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2013724672;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.StepSize = value;
			}
		}

		// Token: 0x170036AF RID: 13999
		// (get) Token: 0x0600699E RID: 27038 RVA: 0x005E800C File Offset: 0x005E620C
		// (set) Token: 0x0600699F RID: 27039 RVA: 0x005E80C4 File Offset: 0x005E62C4
		public bool RadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570_Applicable
		{
			get
			{
				short num = (short)114737924;
				short num2 = num;
				num = (short)1434305284;
				switch (num2 == num)
				{
				}
				num = (short)420937728;
				short num3 = num;
				num = (short)1487994880;
				if (num != 0)
				{
				}
				num = (short)372637697;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.Applicable;
			}
			set
			{
				short num = (short)115408897;
				if (num != 0)
				{
				}
				num = (short)667573842;
				short num2 = num;
				num = (short)1967808082;
				switch (num2 == num)
				{
				default:
				{
					num = (short)661061632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)158990336;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.Applicable = value;
			}
		}

		// Token: 0x170036B0 RID: 14000
		// (get) Token: 0x060069A0 RID: 27040 RVA: 0x005E8178 File Offset: 0x005E6378
		// (set) Token: 0x060069A1 RID: 27041 RVA: 0x005E8230 File Offset: 0x005E6430
		public bool RadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570_Valid
		{
			get
			{
				short num = (short)567314461;
				short num2 = num;
				num = (short)1465944093;
				switch (num2 == num)
				{
				}
				num = (short)692453376;
				short num3 = num;
				num = (short)84344833;
				if (num != 0)
				{
				}
				num = (short)1766326272;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.Valid;
			}
			set
			{
				short num = (short)411024077;
				short num2 = num;
				num = (short)252623565;
				switch (num2 == num)
				{
				}
				num = (short)374145024;
				short num3 = num;
				num = (short)1386676224;
				if (num != 0)
				{
				}
				num = (short)976093185;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.Valid = value;
			}
		}

		// Token: 0x170036B1 RID: 14001
		// (get) Token: 0x060069A2 RID: 27042 RVA: 0x005E82E4 File Offset: 0x005E64E4
		// (set) Token: 0x060069A3 RID: 27043 RVA: 0x005E8398 File Offset: 0x005E6598
		public bool RadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570_Visible
		{
			get
			{
				short num = (short)231902474;
				short num2 = num;
				num = (short)1407421706;
				switch (num2 == num)
				{
				}
				num = (short)1482096640;
				short num3 = num;
				num = (short)85131265;
				if (num != 0)
				{
				}
				num = (short)180224000;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.Visible;
			}
			set
			{
				short num = (short)1556270694;
				short num2 = num;
				num = (short)1779289702;
				switch (num2 == num)
				{
				}
				num = (short)704512000;
				short num3 = num;
				num = (short)1388707841;
				if (num != 0)
				{
				}
				num = (short)1124990976;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.Visible = value;
			}
		}

		// Token: 0x170036B2 RID: 14002
		// (get) Token: 0x060069A4 RID: 27044 RVA: 0x005E8450 File Offset: 0x005E6650
		// (set) Token: 0x060069A5 RID: 27045 RVA: 0x005E8504 File Offset: 0x005E6704
		public bool RadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570_Editable
		{
			get
			{
				short num = (short)915274140;
				short num2 = num;
				num = (short)179370396;
				switch (num2 == num)
				{
				}
				num = (short)163905536;
				short num3 = num;
				num = (short)1793196032;
				if (num != 0)
				{
				}
				num = (short)1980301313;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.Editable;
			}
			set
			{
				short num = (short)1658050450;
				short num2 = num;
				num = (short)1726666642;
				switch (num2 == num)
				{
				}
				num = (short)982712320;
				short num3 = num;
				num = (short)677904384;
				if (num != 0)
				{
				}
				num = (short)1804926977;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.Editable = value;
			}
		}

		// Token: 0x170036B3 RID: 14003
		// (get) Token: 0x060069A6 RID: 27046 RVA: 0x005E85BC File Offset: 0x005E67BC
		internal string RadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570_UILabel
		{
			get
			{
				short num = (short)1485364148;
				short num2 = num;
				num = (short)1413209012;
				switch (num2 == num)
				{
				}
				num = (short)1942355968;
				if (num != 0)
				{
				}
				num = (short)2045575169;
				if (num != 0)
				{
				}
				num = (short)1506279424;
				short num3 = num;
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.UIName;
			}
		}

		// Token: 0x170036B4 RID: 14004
		// (get) Token: 0x060069A7 RID: 27047 RVA: 0x005E8670 File Offset: 0x005E6870
		// (set) Token: 0x060069A8 RID: 27048 RVA: 0x005E8724 File Offset: 0x005E6924
		internal bool RadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570_HiddenStatic
		{
			get
			{
				short num = (short)1907713886;
				short num2 = num;
				num = (short)1004955486;
				switch (num2 == num)
				{
				}
				num = (short)1970274305;
				if (num != 0)
				{
				}
				num = (short)1170472960;
				if (num != 0)
				{
				}
				num = (short)1565720576;
				short num3 = num;
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.HiddenStatic;
			}
			set
			{
				short num = (short)1468695320;
				short num2 = num;
				num = (short)422544152;
				switch (num2 == num)
				{
				}
				num = (short)2133458944;
				if (num != 0)
				{
				}
				num = (short)937164801;
				if (num != 0)
				{
				}
				num = (short)1969487872;
				short num3 = num;
				this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.HiddenStatic = value;
			}
		}

		// Token: 0x170036B5 RID: 14005
		// (get) Token: 0x060069A9 RID: 27049 RVA: 0x005E87D8 File Offset: 0x005E69D8
		// (set) Token: 0x060069AA RID: 27050 RVA: 0x005E888C File Offset: 0x005E6A8C
		internal bool RadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570_HiddenDynamic
		{
			get
			{
				short num = (short)1178775715;
				short num2 = num;
				num = (short)2009641123;
				switch (num2 == num)
				{
				}
				num = (short)1542914049;
				if (num != 0)
				{
				}
				num = (short)1290862592;
				if (num != 0)
				{
				}
				num = (short)753860608;
				short num3 = num;
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.HiddenDynamic;
			}
			set
			{
				short num = (short)2039643993;
				short num2 = num;
				num = (short)1808498521;
				switch (num2 == num)
				{
				}
				num = (short)947257344;
				if (num != 0)
				{
				}
				num = (short)1828978689;
				if (num != 0)
				{
				}
				num = (short)669253632;
				short num3 = num;
				this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570.HiddenDynamic = value;
			}
		}

		// Token: 0x170036B6 RID: 14006
		// (get) Token: 0x060069AB RID: 27051 RVA: 0x005E8940 File Offset: 0x005E6B40
		public bool RadErgoCfgGeneralSDIFFTHRESHDBQ8_A21570_HasDiffs
		{
			get
			{
				short num = (short)1679097857;
				if (num != 0)
				{
				}
				num = (short)1655857926;
				short num2 = num;
				num = (short)1575969542;
				switch (num2 == num)
				{
				}
				num = (short)1924071424;
				if (num != 0)
				{
				}
				num = (short)675414016;
				short num3 = num;
				return this.radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570._HasDiffs;
			}
		}

		// Token: 0x170036B7 RID: 14007
		// (get) Token: 0x060069AC RID: 27052 RVA: 0x005E89F8 File Offset: 0x005E6BF8
		// (set) Token: 0x060069AD RID: 27053 RVA: 0x005E8AB0 File Offset: 0x005E6CB0
		public int RadErgoCfgGeneralVADDETTHRESHDBQ8_A21567Value
		{
			get
			{
				short num = (short)1217739910;
				short num2 = num;
				num = (short)1749367942;
				switch (num2 == num)
				{
				}
				num = (short)385744897;
				if (num != 0)
				{
				}
				num = (short)1792737280;
				if (num != 0)
				{
				}
				num = (short)1002110976;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.Value;
			}
			set
			{
				short num = (short)1508026501;
				short num2 = num;
				num = (short)1423681669;
				switch (num2 == num)
				{
				}
				num = (short)515768320;
				if (num != 0)
				{
				}
				num = (short)1391198209;
				if (num != 0)
				{
				}
				num = (short)2026766336;
				short num3 = num;
				this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.Value = value;
			}
		}

		// Token: 0x170036B8 RID: 14008
		// (get) Token: 0x060069AE RID: 27054 RVA: 0x005E8B68 File Offset: 0x005E6D68
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgGeneralVADDETTHRESHDBQ8_A21567
		{
			get
			{
				short num = (short)1551990389;
				short num2 = num;
				num = (short)980778613;
				switch (num2 == num)
				{
				}
				num = (short)567869441;
				if (num != 0)
				{
				}
				num = (short)257032192;
				if (num != 0)
				{
				}
				num = (short)303759360;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567;
			}
		}

		// Token: 0x170036B9 RID: 14009
		// (get) Token: 0x060069AF RID: 27055 RVA: 0x005E8C14 File Offset: 0x005E6E14
		// (set) Token: 0x060069B0 RID: 27056 RVA: 0x005E8CC8 File Offset: 0x005E6EC8
		public string RadErgoCfgGeneralVADDETTHRESHDBQ8_A21567_UIValue
		{
			get
			{
				short num = (short)2141872700;
				short num2 = num;
				num = (short)318333500;
				switch (num2 == num)
				{
				}
				num = (short)1353908224;
				if (num != 0)
				{
				}
				num = (short)1795751937;
				if (num != 0)
				{
				}
				num = (short)118882304;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.UIValue;
			}
			set
			{
				short num = (short)1236942548;
				short num2 = num;
				num = (short)2047360724;
				switch (num2 == num)
				{
				}
				num = (short)520683521;
				if (num != 0)
				{
				}
				num = (short)1302659072;
				if (num != 0)
				{
				}
				num = (short)1744633856;
				short num3 = num;
				this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.UIValue = value;
			}
		}

		// Token: 0x170036BA RID: 14010
		// (get) Token: 0x060069B1 RID: 27057 RVA: 0x005E8D80 File Offset: 0x005E6F80
		// (set) Token: 0x060069B2 RID: 27058 RVA: 0x005E8E34 File Offset: 0x005E7034
		public string RadErgoCfgGeneralVADDETTHRESHDBQ8_A21567_HexUIValue
		{
			get
			{
				short num = (short)269743117;
				short num2 = num;
				num = (short)1092088845;
				switch (num2 == num)
				{
				}
				num = (short)313917441;
				if (num != 0)
				{
				}
				num = (short)1209401344;
				if (num != 0)
				{
				}
				num = (short)500367360;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.HexUIValue;
			}
			set
			{
				short num = (short)507707543;
				short num2 = num;
				num = (short)303038615;
				switch (num2 == num)
				{
				}
				num = (short)36962305;
				if (num != 0)
				{
				}
				num = (short)1422786560;
				if (num != 0)
				{
				}
				num = (short)1401815040;
				short num3 = num;
				this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.HexUIValue = value;
			}
		}

		// Token: 0x170036BB RID: 14011
		// (get) Token: 0x060069B3 RID: 27059 RVA: 0x005E8EE8 File Offset: 0x005E70E8
		// (set) Token: 0x060069B4 RID: 27060 RVA: 0x005E8FA0 File Offset: 0x005E71A0
		internal int RadErgoCfgGeneralVADDETTHRESHDBQ8_A21567Min
		{
			get
			{
				short num = (short)1300089904;
				short num2 = num;
				num = (short)1917373488;
				switch (num2 == num)
				{
				}
				num = (short)1021575169;
				if (num != 0)
				{
				}
				num = (short)677380096;
				if (num != 0)
				{
				}
				num = (short)1805647872;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.Min;
			}
			set
			{
				short num = (short)1054230855;
				short num2 = num;
				num = (short)863324487;
				switch (num2 == num)
				{
				}
				num = (short)464912384;
				if (num != 0)
				{
				}
				num = (short)809172993;
				if (num != 0)
				{
				}
				num = (short)1421606912;
				short num3 = num;
				this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.Min = value;
			}
		}

		// Token: 0x170036BC RID: 14012
		// (get) Token: 0x060069B5 RID: 27061 RVA: 0x005E9054 File Offset: 0x005E7254
		// (set) Token: 0x060069B6 RID: 27062 RVA: 0x005E9108 File Offset: 0x005E7308
		internal int RadErgoCfgGeneralVADDETTHRESHDBQ8_A21567Max
		{
			get
			{
				short num = (short)547993374;
				short num2 = num;
				num = (short)113358622;
				switch (num2 == num)
				{
				}
				num = (short)1959067649;
				if (num != 0)
				{
				}
				num = (short)1926889472;
				if (num != 0)
				{
				}
				num = (short)1145634816;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.Max;
			}
			set
			{
				short num = (short)354549761;
				if (num != 0)
				{
				}
				num = (short)2051683166;
				short num2 = num;
				num = (short)1294349150;
				switch (num2 == num)
				{
				}
				num = (short)1644298240;
				if (num != 0)
				{
				}
				num = (short)300548096;
				short num3 = num;
				this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.Max = value;
			}
		}

		// Token: 0x170036BD RID: 14013
		// (get) Token: 0x060069B7 RID: 27063 RVA: 0x005E91C0 File Offset: 0x005E73C0
		// (set) Token: 0x060069B8 RID: 27064 RVA: 0x005E9274 File Offset: 0x005E7474
		internal int RadErgoCfgGeneralVADDETTHRESHDBQ8_A21567Step
		{
			get
			{
				short num = (short)93639303;
				short num2 = num;
				num = (short)1716048519;
				switch (num2 == num)
				{
				}
				num = (short)1242497024;
				if (num != 0)
				{
				}
				num = (short)2015559681;
				if (num != 0)
				{
				}
				num = (short)748486656;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.StepSize;
			}
			set
			{
				short num = (short)29428649;
				short num2 = num;
				num = (short)2103184297;
				switch (num2 == num)
				{
				}
				num = (short)1228931073;
				if (num != 0)
				{
				}
				num = (short)563150848;
				if (num != 0)
				{
				}
				num = (short)1862598656;
				short num3 = num;
				this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.StepSize = value;
			}
		}

		// Token: 0x170036BE RID: 14014
		// (get) Token: 0x060069B9 RID: 27065 RVA: 0x005E932C File Offset: 0x005E752C
		// (set) Token: 0x060069BA RID: 27066 RVA: 0x005E93E0 File Offset: 0x005E75E0
		public bool RadErgoCfgGeneralVADDETTHRESHDBQ8_A21567_Applicable
		{
			get
			{
				short num = (short)927858689;
				if (num != 0)
				{
				}
				num = (short)10434100;
				short num2 = num;
				num = (short)1082865204;
				switch (num2 == num)
				{
				}
				num = (short)947388416;
				if (num != 0)
				{
				}
				num = (short)654049280;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.Applicable;
			}
			set
			{
				short num = (short)1158849003;
				short num2 = num;
				num = (short)151495147;
				switch (num2 == num)
				{
				}
				num = (short)1158545409;
				if (num != 0)
				{
				}
				num = (short)1268580352;
				if (num != 0)
				{
				}
				num = (short)1233911808;
				short num3 = num;
				this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.Applicable = value;
			}
		}

		// Token: 0x170036BF RID: 14015
		// (get) Token: 0x060069BB RID: 27067 RVA: 0x005E9494 File Offset: 0x005E7694
		// (set) Token: 0x060069BC RID: 27068 RVA: 0x005E9548 File Offset: 0x005E7748
		public bool RadErgoCfgGeneralVADDETTHRESHDBQ8_A21567_Valid
		{
			get
			{
				short num = (short)472652238;
				short num2 = num;
				num = (short)1515067854;
				switch (num2 == num)
				{
				}
				num = (short)954466305;
				if (num != 0)
				{
				}
				num = (short)1362100224;
				if (num != 0)
				{
				}
				num = (short)147849216;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.Valid;
			}
			set
			{
				short num = (short)1364236183;
				short num2 = num;
				num = (short)97294231;
				switch (num2 == num)
				{
				}
				num = (short)428343297;
				if (num != 0)
				{
				}
				num = (short)1826881536;
				if (num != 0)
				{
				}
				num = (short)1435238400;
				short num3 = num;
				this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.Valid = value;
			}
		}

		// Token: 0x170036C0 RID: 14016
		// (get) Token: 0x060069BD RID: 27069 RVA: 0x005E95FC File Offset: 0x005E77FC
		// (set) Token: 0x060069BE RID: 27070 RVA: 0x005E96B0 File Offset: 0x005E78B0
		public bool RadErgoCfgGeneralVADDETTHRESHDBQ8_A21567_Visible
		{
			get
			{
				short num = (short)1957604003;
				short num2 = num;
				num = (short)1310370467;
				switch (num2 == num)
				{
				}
				num = (short)1227489280;
				if (num != 0)
				{
				}
				num = (short)303628289;
				if (num != 0)
				{
				}
				num = (short)1899233280;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.Visible;
			}
			set
			{
				short num = (short)1616253323;
				short num2 = num;
				num = (short)911217035;
				switch (num2 == num)
				{
				}
				num = (short)1833172992;
				if (num != 0)
				{
				}
				num = (short)1805123585;
				if (num != 0)
				{
				}
				num = (short)1586954240;
				short num3 = num;
				this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.Visible = value;
			}
		}

		// Token: 0x170036C1 RID: 14017
		// (get) Token: 0x060069BF RID: 27071 RVA: 0x005E9768 File Offset: 0x005E7968
		// (set) Token: 0x060069C0 RID: 27072 RVA: 0x005E981C File Offset: 0x005E7A1C
		public bool RadErgoCfgGeneralVADDETTHRESHDBQ8_A21567_Editable
		{
			get
			{
				short num = (short)1577252205;
				short num2 = num;
				num = (short)904131949;
				switch (num2 == num)
				{
				}
				num = (short)1919221761;
				if (num != 0)
				{
				}
				num = (short)973930496;
				if (num != 0)
				{
				}
				num = (short)34996224;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.Editable;
			}
			set
			{
				short num = (short)755071342;
				short num2 = num;
				num = (short)774994286;
				switch (num2 == num)
				{
				}
				num = (short)941031425;
				if (num != 0)
				{
				}
				num = (short)160104448;
				if (num != 0)
				{
				}
				num = (short)1744371712;
				short num3 = num;
				this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.Editable = value;
			}
		}

		// Token: 0x170036C2 RID: 14018
		// (get) Token: 0x060069C1 RID: 27073 RVA: 0x005E98D4 File Offset: 0x005E7AD4
		internal string RadErgoCfgGeneralVADDETTHRESHDBQ8_A21567_UILabel
		{
			get
			{
				short num = (short)960754361;
				short num2 = num;
				num = (short)1618080441;
				switch (num2 == num)
				{
				}
				num = (short)537001985;
				if (num != 0)
				{
				}
				num = (short)1136590848;
				if (num != 0)
				{
				}
				num = (short)497418240;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.UIName;
			}
		}

		// Token: 0x170036C3 RID: 14019
		// (get) Token: 0x060069C2 RID: 27074 RVA: 0x005E9988 File Offset: 0x005E7B88
		// (set) Token: 0x060069C3 RID: 27075 RVA: 0x005E9A3C File Offset: 0x005E7C3C
		internal bool RadErgoCfgGeneralVADDETTHRESHDBQ8_A21567_HiddenStatic
		{
			get
			{
				short num = (short)445829160;
				short num2 = num;
				num = (short)595120168;
				switch (num2 == num)
				{
				}
				num = (short)740556801;
				if (num != 0)
				{
				}
				num = (short)2125529088;
				if (num != 0)
				{
				}
				num = (short)251527168;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.HiddenStatic;
			}
			set
			{
				short num = (short)1596460916;
				short num2 = num;
				num = (short)616173428;
				switch (num2 == num)
				{
				}
				num = (short)1954152449;
				if (num != 0)
				{
				}
				num = (short)1140457472;
				if (num != 0)
				{
				}
				num = (short)2131034112;
				short num3 = num;
				this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.HiddenStatic = value;
			}
		}

		// Token: 0x170036C4 RID: 14020
		// (get) Token: 0x060069C4 RID: 27076 RVA: 0x005E9AF0 File Offset: 0x005E7CF0
		// (set) Token: 0x060069C5 RID: 27077 RVA: 0x005E9BA8 File Offset: 0x005E7DA8
		internal bool RadErgoCfgGeneralVADDETTHRESHDBQ8_A21567_HiddenDynamic
		{
			get
			{
				short num = (short)6029313;
				if (num != 0)
				{
				}
				num = (short)1602671490;
				short num2 = num;
				num = (short)1393742722;
				switch (num2 == num)
				{
				}
				num = (short)182124544;
				if (num != 0)
				{
				}
				num = (short)946339840;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.HiddenDynamic;
			}
			set
			{
				short num = (short)1960765402;
				short num2 = num;
				num = (short)567470042;
				switch (num2 == num)
				{
				}
				num = (short)1060503552;
				if (num != 0)
				{
				}
				num = (short)1882718209;
				if (num != 0)
				{
				}
				num = (short)196149248;
				short num3 = num;
				this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567.HiddenDynamic = value;
			}
		}

		// Token: 0x170036C5 RID: 14021
		// (get) Token: 0x060069C6 RID: 27078 RVA: 0x005E9C60 File Offset: 0x005E7E60
		public bool RadErgoCfgGeneralVADDETTHRESHDBQ8_A21567_HasDiffs
		{
			get
			{
				short num = (short)269535904;
				short num2 = num;
				num = (short)548915872;
				switch (num2 == num)
				{
				}
				num = (short)1205075968;
				if (num != 0)
				{
				}
				num = (short)2079457281;
				if (num != 0)
				{
				}
				num = (short)328138752;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETTHRESHDBQ8_A21567._HasDiffs;
			}
		}

		// Token: 0x170036C6 RID: 14022
		// (get) Token: 0x060069C7 RID: 27079 RVA: 0x005E9D14 File Offset: 0x005E7F14
		// (set) Token: 0x060069C8 RID: 27080 RVA: 0x005E9DCC File Offset: 0x005E7FCC
		public int RadErgoCfgGeneralVADDETCOUNT_A21568Value
		{
			get
			{
				short num = (short)1854177661;
				short num2 = num;
				num = (short)458588541;
				switch (num2 == num)
				{
				}
				num = (short)690880512;
				if (num != 0)
				{
				}
				num = (short)456785921;
				if (num != 0)
				{
				}
				num = (short)30539776;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A21568.Value;
			}
			set
			{
				short num = (short)738010283;
				short num2 = num;
				num = (short)1800414379;
				switch (num2 == num)
				{
				}
				num = (short)589692929;
				if (num != 0)
				{
				}
				num = (short)1209270272;
				if (num != 0)
				{
				}
				num = (short)420478976;
				short num3 = num;
				this.radErgoCfgGeneralVADDETCOUNT_A21568.Value = value;
			}
		}

		// Token: 0x170036C7 RID: 14023
		// (get) Token: 0x060069C9 RID: 27081 RVA: 0x005E9E88 File Offset: 0x005E8088
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgGeneralVADDETCOUNT_A21568
		{
			get
			{
				short num = (short)525765011;
				short num2 = num;
				num = (short)1074235795;
				switch (num2 == num)
				{
				}
				num = (short)222625793;
				if (num != 0)
				{
				}
				num = (short)2054356992;
				if (num != 0)
				{
				}
				num = (short)1200553984;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A21568;
			}
		}

		// Token: 0x170036C8 RID: 14024
		// (get) Token: 0x060069CA RID: 27082 RVA: 0x005E9F38 File Offset: 0x005E8138
		// (set) Token: 0x060069CB RID: 27083 RVA: 0x005E9FEC File Offset: 0x005E81EC
		public string RadErgoCfgGeneralVADDETCOUNT_A21568_UIValue
		{
			get
			{
				short num = (short)598957372;
				short num2 = num;
				num = (short)1505844540;
				switch (num2 == num)
				{
				}
				num = (short)445186049;
				if (num != 0)
				{
				}
				num = (short)943652864;
				if (num != 0)
				{
				}
				num = (short)1352204288;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A21568.UIValue;
			}
			set
			{
				short num = (short)1164115969;
				if (num != 0)
				{
				}
				num = (short)438571207;
				short num2 = num;
				num = (short)1151144135;
				switch (num2 == num)
				{
				}
				num = (short)667418624;
				if (num != 0)
				{
				}
				num = (short)16711680;
				short num3 = num;
				this.radErgoCfgGeneralVADDETCOUNT_A21568.UIValue = value;
			}
		}

		// Token: 0x170036C9 RID: 14025
		// (get) Token: 0x060069CC RID: 27084 RVA: 0x005EA0A4 File Offset: 0x005E82A4
		// (set) Token: 0x060069CD RID: 27085 RVA: 0x005EA158 File Offset: 0x005E8358
		public string RadErgoCfgGeneralVADDETCOUNT_A21568_HexUIValue
		{
			get
			{
				short num = (short)569891829;
				short num2 = num;
				num = (short)1274665973;
				switch (num2 == num)
				{
				}
				num = (short)115802112;
				if (num != 0)
				{
				}
				num = (short)1244463105;
				if (num != 0)
				{
				}
				num = (short)577110016;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A21568.HexUIValue;
			}
			set
			{
				short num = (short)1318071404;
				short num2 = num;
				num = (short)1947348076;
				switch (num2 == num)
				{
				}
				num = (short)549453825;
				if (num != 0)
				{
				}
				num = (short)1090453504;
				if (num != 0)
				{
				}
				num = (short)1778647040;
				short num3 = num;
				this.radErgoCfgGeneralVADDETCOUNT_A21568.HexUIValue = value;
			}
		}

		// Token: 0x170036CA RID: 14026
		// (get) Token: 0x060069CE RID: 27086 RVA: 0x005EA20C File Offset: 0x005E840C
		// (set) Token: 0x060069CF RID: 27087 RVA: 0x005EA2C0 File Offset: 0x005E84C0
		internal int RadErgoCfgGeneralVADDETCOUNT_A21568Min
		{
			get
			{
				short num = (short)1156186113;
				if (num != 0)
				{
				}
				num = (short)1945515474;
				short num2 = num;
				num = (short)1484142034;
				switch (num2 == num)
				{
				}
				num = (short)1887830016;
				if (num != 0)
				{
				}
				num = (short)375521280;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A21568.Min;
			}
			set
			{
				short num = (short)218917137;
				short num2 = num;
				num = (short)561670417;
				switch (num2 == num)
				{
				}
				num = (short)1850671105;
				if (num != 0)
				{
				}
				num = (short)1584726016;
				if (num != 0)
				{
				}
				num = (short)2038693888;
				short num3 = num;
				this.radErgoCfgGeneralVADDETCOUNT_A21568.Min = value;
			}
		}

		// Token: 0x170036CB RID: 14027
		// (get) Token: 0x060069D0 RID: 27088 RVA: 0x005EA378 File Offset: 0x005E8578
		// (set) Token: 0x060069D1 RID: 27089 RVA: 0x005EA428 File Offset: 0x005E8628
		internal int RadErgoCfgGeneralVADDETCOUNT_A21568Max
		{
			get
			{
				short num = (short)1999628823;
				short num2 = num;
				num = (short)679209495;
				switch (num2 == num)
				{
				}
				num = (short)796459009;
				if (num != 0)
				{
				}
				num = (short)525664256;
				if (num != 0)
				{
				}
				num = (short)1984299008;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A21568.Max;
			}
			set
			{
				short num = (short)380827052;
				short num2 = num;
				num = (short)1029633452;
				switch (num2 == num)
				{
				}
				num = (short)1708785665;
				if (num != 0)
				{
				}
				num = (short)1072562176;
				if (num != 0)
				{
				}
				num = (short)856227840;
				short num3 = num;
				this.radErgoCfgGeneralVADDETCOUNT_A21568.Max = value;
			}
		}

		// Token: 0x170036CC RID: 14028
		// (get) Token: 0x060069D2 RID: 27090 RVA: 0x005EA4E0 File Offset: 0x005E86E0
		// (set) Token: 0x060069D3 RID: 27091 RVA: 0x005EA594 File Offset: 0x005E8794
		internal int RadErgoCfgGeneralVADDETCOUNT_A21568Step
		{
			get
			{
				short num = (short)418427047;
				short num2 = num;
				num = (short)638562471;
				switch (num2 == num)
				{
				}
				num = (short)815398913;
				if (num != 0)
				{
				}
				num = (short)478478336;
				if (num != 0)
				{
				}
				num = (short)597295104;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A21568.StepSize;
			}
			set
			{
				short num = (short)2064998836;
				short num2 = num;
				num = (short)2070766004;
				switch (num2 == num)
				{
				}
				num = (short)331153409;
				if (num != 0)
				{
				}
				num = (short)187301888;
				if (num != 0)
				{
				}
				num = (short)1026883584;
				short num3 = num;
				this.radErgoCfgGeneralVADDETCOUNT_A21568.StepSize = value;
			}
		}

		// Token: 0x170036CD RID: 14029
		// (get) Token: 0x060069D4 RID: 27092 RVA: 0x005EA648 File Offset: 0x005E8848
		// (set) Token: 0x060069D5 RID: 27093 RVA: 0x005EA700 File Offset: 0x005E8900
		public bool RadErgoCfgGeneralVADDETCOUNT_A21568_Applicable
		{
			get
			{
				short num = (short)1785923183;
				short num2 = num;
				num = (short)293668463;
				switch (num2 == num)
				{
				}
				num = (short)1007091712;
				if (num != 0)
				{
				}
				num = (short)1316618241;
				if (num != 0)
				{
				}
				num = (short)1718288384;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A21568.Applicable;
			}
			set
			{
				short num = (short)1033369299;
				short num2 = num;
				num = (short)1136850643;
				switch (num2 == num)
				{
				}
				num = (short)650706945;
				if (num != 0)
				{
				}
				num = (short)377946112;
				if (num != 0)
				{
				}
				num = (short)1554186240;
				short num3 = num;
				this.radErgoCfgGeneralVADDETCOUNT_A21568.Applicable = value;
			}
		}

		// Token: 0x170036CE RID: 14030
		// (get) Token: 0x060069D6 RID: 27094 RVA: 0x005EA7B4 File Offset: 0x005E89B4
		// (set) Token: 0x060069D7 RID: 27095 RVA: 0x005EA868 File Offset: 0x005E8A68
		public bool RadErgoCfgGeneralVADDETCOUNT_A21568_Valid
		{
			get
			{
				short num = (short)1189156107;
				short num2 = num;
				num = (short)271652107;
				switch (num2 == num)
				{
				}
				num = (short)1539112961;
				if (num != 0)
				{
				}
				num = (short)1677459456;
				if (num != 0)
				{
				}
				num = (short)1451819008;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A21568.Valid;
			}
			set
			{
				short num = (short)726192383;
				short num2 = num;
				num = (short)780980479;
				switch (num2 == num)
				{
				}
				num = (short)2071658497;
				if (num != 0)
				{
				}
				num = (short)1917452288;
				if (num != 0)
				{
				}
				num = (short)1273823232;
				short num3 = num;
				this.radErgoCfgGeneralVADDETCOUNT_A21568.Valid = value;
			}
		}

		// Token: 0x170036CF RID: 14031
		// (get) Token: 0x060069D8 RID: 27096 RVA: 0x005EA91C File Offset: 0x005E8B1C
		// (set) Token: 0x060069D9 RID: 27097 RVA: 0x005EA9D0 File Offset: 0x005E8BD0
		public bool RadErgoCfgGeneralVADDETCOUNT_A21568_Visible
		{
			get
			{
				short num = (short)1833076590;
				short num2 = num;
				num = (short)1609009006;
				switch (num2 == num)
				{
				}
				num = (short)1732902912;
				if (num != 0)
				{
				}
				num = (short)975699969;
				if (num != 0)
				{
				}
				num = (short)1860960256;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A21568.Visible;
			}
			set
			{
				short num = (short)44153474;
				short num2 = num;
				num = (short)719895170;
				switch (num2 == num)
				{
				}
				num = (short)892076033;
				if (num != 0)
				{
				}
				num = (short)2121138176;
				if (num != 0)
				{
				}
				num = (short)830799872;
				short num3 = num;
				this.radErgoCfgGeneralVADDETCOUNT_A21568.Visible = value;
			}
		}

		// Token: 0x170036D0 RID: 14032
		// (get) Token: 0x060069DA RID: 27098 RVA: 0x005EAA84 File Offset: 0x005E8C84
		// (set) Token: 0x060069DB RID: 27099 RVA: 0x005EAB38 File Offset: 0x005E8D38
		public bool RadErgoCfgGeneralVADDETCOUNT_A21568_Editable
		{
			get
			{
				short num = (short)1023787709;
				short num2 = num;
				num = (short)892060349;
				switch (num2 == num)
				{
				}
				num = (short)312344576;
				if (num != 0)
				{
				}
				num = (short)86310913;
				if (num != 0)
				{
				}
				num = (short)945029120;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A21568.Editable;
			}
			set
			{
				short num = (short)1965802343;
				short num2 = num;
				num = (short)2048836455;
				switch (num2 == num)
				{
				}
				num = (short)1427308544;
				if (num != 0)
				{
				}
				num = (short)1374945281;
				if (num != 0)
				{
				}
				num = (short)131792896;
				short num3 = num;
				this.radErgoCfgGeneralVADDETCOUNT_A21568.Editable = value;
			}
		}

		// Token: 0x170036D1 RID: 14033
		// (get) Token: 0x060069DC RID: 27100 RVA: 0x005EABEC File Offset: 0x005E8DEC
		internal string RadErgoCfgGeneralVADDETCOUNT_A21568_UILabel
		{
			get
			{
				short num = (short)470037926;
				short num2 = num;
				num = (short)248919462;
				switch (num2 == num)
				{
				}
				num = (short)883949569;
				if (num != 0)
				{
				}
				num = (short)2077294592;
				if (num != 0)
				{
				}
				num = (short)259522560;
				short num3 = num;
				return this.radErgoCfgGeneralVADDETCOUNT_A21568.UIName;
			}
		}

		// Token: 0x170036D2 RID: 14034
		// (get) Token: 0x060069DD RID: 27101 RVA: 0x005EACA0 File Offset: 0x005E8EA0
		// (set) Token: 0x060069DE RID: 27102 RVA: 0x005EAD58 File Offset: 0x005E8F58
		internal bool RadErgoCfgGeneralVADDETCOUNT_A21568_HiddenStatic
		{
			get
			{
				short num = (short)1145094629;
				short num2 = num;
				num = (short)1790951909;
				switch (num2 == num)
				{
				}
				num = (short)187760640;
				short num3 = num;
				num = (short)1983709185;
				if (num != 0)
				{
				}
				num = (short)1571094528;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralVADDETCOUNT_A21568.HiddenStatic;
			}
			set
			{
				short num = (short)1624887239;
				short num2 = num;
				num = (short)1940180935;
				switch (num2 == num)
				{
				}
				num = (short)1931673600;
				short num3 = num;
				num = (short)178257920;
				if (num != 0)
				{
				}
				num = (short)1518075905;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralVADDETCOUNT_A21568.HiddenStatic = value;
			}
		}

		// Token: 0x170036D3 RID: 14035
		// (get) Token: 0x060069DF RID: 27103 RVA: 0x005EAE10 File Offset: 0x005E9010
		// (set) Token: 0x060069E0 RID: 27104 RVA: 0x005EAECC File Offset: 0x005E90CC
		internal bool RadErgoCfgGeneralVADDETCOUNT_A21568_HiddenDynamic
		{
			get
			{
				short num = (short)1458100341;
				short num2 = num;
				num = (short)425252981;
				switch (num2 == num)
				{
				}
				num = (short)57278464;
				short num3 = num;
				num = (short)1083375616;
				if (num != 0)
				{
				}
				num = (short)1881866241;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralVADDETCOUNT_A21568.HiddenDynamic;
			}
			set
			{
				short num = (short)1699651352;
				short num2 = num;
				num = (short)2066849560;
				switch (num2 == num)
				{
				}
				num = (short)1783627776;
				short num3 = num;
				num = (short)1342242817;
				if (num != 0)
				{
				}
				num = (short)370278400;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralVADDETCOUNT_A21568.HiddenDynamic = value;
			}
		}

		// Token: 0x170036D4 RID: 14036
		// (get) Token: 0x060069E1 RID: 27105 RVA: 0x005EAF84 File Offset: 0x005E9184
		public bool RadErgoCfgGeneralVADDETCOUNT_A21568_HasDiffs
		{
			get
			{
				short num = (short)1831438828;
				short num2 = num;
				num = (short)2129627628;
				switch (num2 == num)
				{
				}
				num = (short)2106130432;
				short num3 = num;
				num = (short)1985347585;
				if (num != 0)
				{
				}
				num = (short)728301568;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralVADDETCOUNT_A21568._HasDiffs;
			}
		}

		// Token: 0x170036D5 RID: 14037
		// (get) Token: 0x060069E2 RID: 27106 RVA: 0x005EB038 File Offset: 0x005E9238
		// (set) Token: 0x060069E3 RID: 27107 RVA: 0x005EB0EC File Offset: 0x005E92EC
		public int RadErgoCfgGeneralMINGAIN_A21562Value
		{
			get
			{
				short num = (short)1130621335;
				short num2 = num;
				num = (short)20703639;
				switch (num2 == num)
				{
				}
				num = (short)955187200;
				short num3 = num;
				num = (short)732561409;
				if (num != 0)
				{
				}
				num = (short)1790312448;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMINGAIN_A21562.Value;
			}
			set
			{
				short num = (short)1853835724;
				short num2 = num;
				num = (short)1653098956;
				switch (num2 == num)
				{
				}
				num = (short)1492647936;
				short num3 = num;
				num = (short)2105475072;
				if (num != 0)
				{
				}
				num = (short)1396113409;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralMINGAIN_A21562.Value = value;
			}
		}

		// Token: 0x170036D6 RID: 14038
		// (get) Token: 0x060069E4 RID: 27108 RVA: 0x005EB1A0 File Offset: 0x005E93A0
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgGeneralMINGAIN_A21562
		{
			get
			{
				short num = (short)759027805;
				short num2 = num;
				num = (short)394319965;
				switch (num2 == num)
				{
				}
				num = (short)2075394048;
				short num3 = num;
				num = (short)2061172737;
				if (num != 0)
				{
				}
				num = (short)1513226240;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMINGAIN_A21562;
			}
		}

		// Token: 0x170036D7 RID: 14039
		// (get) Token: 0x060069E5 RID: 27109 RVA: 0x005EB250 File Offset: 0x005E9450
		// (set) Token: 0x060069E6 RID: 27110 RVA: 0x005EB304 File Offset: 0x005E9504
		public string RadErgoCfgGeneralMINGAIN_A21562_UIValue
		{
			get
			{
				short num = (short)1335652096;
				short num2 = num;
				num = (short)1635151616;
				switch (num2 == num)
				{
				}
				num = (short)1662844928;
				short num3 = num;
				num = (short)726401024;
				if (num != 0)
				{
				}
				num = (short)1790902273;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMINGAIN_A21562.UIValue;
			}
			set
			{
				short num = (short)528977594;
				short num2 = num;
				num = (short)1065717434;
				switch (num2 == num)
				{
				}
				num = (short)426246144;
				short num3 = num;
				num = (short)441516032;
				if (num != 0)
				{
				}
				num = (short)586219521;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralMINGAIN_A21562.UIValue = value;
			}
		}

		// Token: 0x170036D8 RID: 14040
		// (get) Token: 0x060069E7 RID: 27111 RVA: 0x005EB3BC File Offset: 0x005E95BC
		// (set) Token: 0x060069E8 RID: 27112 RVA: 0x005EB470 File Offset: 0x005E9670
		public string RadErgoCfgGeneralMINGAIN_A21562_HexUIValue
		{
			get
			{
				short num = (short)1979537145;
				short num2 = num;
				num = (short)802641657;
				switch (num2 == num)
				{
				}
				num = (short)1845952512;
				short num3 = num;
				num = (short)418185217;
				if (num != 0)
				{
				}
				num = (short)922419200;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMINGAIN_A21562.HexUIValue;
			}
			set
			{
				short num = (short)1630611821;
				short num2 = num;
				num = (short)1126574445;
				switch (num2 == num)
				{
				}
				num = (short)1540292608;
				short num3 = num;
				num = (short)694681601;
				if (num != 0)
				{
				}
				num = (short)954400768;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralMINGAIN_A21562.HexUIValue = value;
			}
		}

		// Token: 0x170036D9 RID: 14041
		// (get) Token: 0x060069E9 RID: 27113 RVA: 0x005EB528 File Offset: 0x005E9728
		// (set) Token: 0x060069EA RID: 27114 RVA: 0x005EB5E0 File Offset: 0x005E97E0
		internal int RadErgoCfgGeneralMINGAIN_A21562Min
		{
			get
			{
				short num = (short)1666154266;
				short num2 = num;
				num = (short)1592753946;
				switch (num2 == num)
				{
				}
				num = (short)1451556864;
				short num3 = num;
				num = (short)1532297217;
				if (num != 0)
				{
				}
				num = (short)1346764800;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMINGAIN_A21562.Min;
			}
			set
			{
				short num = (short)127444869;
				short num2 = num;
				num = (short)204646277;
				switch (num2 == num)
				{
				}
				num = (short)1486422016;
				short num3 = num;
				num = (short)387907584;
				if (num != 0)
				{
				}
				num = (short)1978138625;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralMINGAIN_A21562.Min = value;
			}
		}

		// Token: 0x170036DA RID: 14042
		// (get) Token: 0x060069EB RID: 27115 RVA: 0x005EB694 File Offset: 0x005E9894
		// (set) Token: 0x060069EC RID: 27116 RVA: 0x005EB74C File Offset: 0x005E994C
		internal int RadErgoCfgGeneralMINGAIN_A21562Max
		{
			get
			{
				short num = (short)23248819;
				short num2 = num;
				num = (short)546946995;
				switch (num2 == num)
				{
				}
				num = (short)1753088000;
				short num3 = num;
				num = (short)1468137473;
				if (num != 0)
				{
				}
				num = (short)1774911488;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMINGAIN_A21562.Max;
			}
			set
			{
				short num = (short)987781601;
				short num2 = num;
				num = (short)1521048033;
				switch (num2 == num)
				{
				}
				num = (short)1136590848;
				short num3 = num;
				num = (short)1335558144;
				if (num != 0)
				{
				}
				num = (short)1911881729;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralMINGAIN_A21562.Max = value;
			}
		}

		// Token: 0x170036DB RID: 14043
		// (get) Token: 0x060069ED RID: 27117 RVA: 0x005EB800 File Offset: 0x005E9A00
		// (set) Token: 0x060069EE RID: 27118 RVA: 0x005EB8B8 File Offset: 0x005E9AB8
		internal int RadErgoCfgGeneralMINGAIN_A21562Step
		{
			get
			{
				short num = (short)1733567127;
				short num2 = num;
				num = (short)1270293143;
				switch (num2 == num)
				{
				}
				num = (short)1948188672;
				short num3 = num;
				num = (short)1710292992;
				if (num != 0)
				{
				}
				num = (short)2146238465;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMINGAIN_A21562.StepSize;
			}
			set
			{
				short num = (short)668071569;
				short num2 = num;
				num = (short)2112878225;
				switch (num2 == num)
				{
				}
				num = (short)863240192;
				short num3 = num;
				num = (short)484114432;
				if (num != 0)
				{
				}
				num = (short)1209729025;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralMINGAIN_A21562.StepSize = value;
			}
		}

		// Token: 0x170036DC RID: 14044
		// (get) Token: 0x060069EF RID: 27119 RVA: 0x005EB96C File Offset: 0x005E9B6C
		// (set) Token: 0x060069F0 RID: 27120 RVA: 0x005EBA24 File Offset: 0x005E9C24
		public bool RadErgoCfgGeneralMINGAIN_A21562_Applicable
		{
			get
			{
				short num = (short)485359617;
				if (num != 0)
				{
				}
				num = (short)255516477;
				short num2 = num;
				num = (short)514252605;
				switch (num2 == num)
				{
				default:
				{
					num = (short)595394560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2041905152;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMINGAIN_A21562.Applicable;
			}
			set
			{
				short num = (short)1117978625;
				if (num != 0)
				{
				}
				num = (short)541851745;
				short num2 = num;
				num = (short)1407516769;
				switch (num2 == num)
				{
				default:
				{
					num = (short)911933440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)935002112;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralMINGAIN_A21562.Applicable = value;
			}
		}

		// Token: 0x170036DD RID: 14045
		// (get) Token: 0x060069F1 RID: 27121 RVA: 0x005EBADC File Offset: 0x005E9CDC
		// (set) Token: 0x060069F2 RID: 27122 RVA: 0x005EBB90 File Offset: 0x005E9D90
		public bool RadErgoCfgGeneralMINGAIN_A21562_Valid
		{
			get
			{
				short num = (short)1503264769;
				if (num != 0)
				{
				}
				num = (short)629618905;
				short num2 = num;
				num = (short)1978743001;
				switch (num2 == num)
				{
				default:
				{
					num = (short)532283392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1704853504;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMINGAIN_A21562.Valid;
			}
			set
			{
				short num = (short)1580806071;
				short num2 = num;
				num = (short)1373646775;
				switch (num2 == num)
				{
				}
				num = (short)1243611136;
				short num3 = num;
				num = (short)236322816;
				if (num != 0)
				{
				}
				num = (short)961413121;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralMINGAIN_A21562.Valid = value;
			}
		}

		// Token: 0x170036DE RID: 14046
		// (get) Token: 0x060069F3 RID: 27123 RVA: 0x005EBC48 File Offset: 0x005E9E48
		// (set) Token: 0x060069F4 RID: 27124 RVA: 0x005EBD00 File Offset: 0x005E9F00
		public bool RadErgoCfgGeneralMINGAIN_A21562_Visible
		{
			get
			{
				short num = (short)137994730;
				short num2 = num;
				num = (short)767468010;
				switch (num2 == num)
				{
				}
				num = (short)490733568;
				short num3 = num;
				num = (short)1363083265;
				if (num != 0)
				{
				}
				num = (short)72941568;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMINGAIN_A21562.Visible;
			}
			set
			{
				short num = (short)1263860219;
				short num2 = num;
				num = (short)245561851;
				switch (num2 == num)
				{
				}
				num = (short)1033043968;
				short num3 = num;
				num = (short)571670529;
				if (num != 0)
				{
				}
				num = (short)433979392;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralMINGAIN_A21562.Visible = value;
			}
		}

		// Token: 0x170036DF RID: 14047
		// (get) Token: 0x060069F5 RID: 27125 RVA: 0x005EBDB8 File Offset: 0x005E9FB8
		// (set) Token: 0x060069F6 RID: 27126 RVA: 0x005EBE6C File Offset: 0x005EA06C
		public bool RadErgoCfgGeneralMINGAIN_A21562_Editable
		{
			get
			{
				short num = (short)110034945;
				if (num != 0)
				{
				}
				num = (short)230469590;
				short num2 = num;
				num = (short)1413132246;
				switch (num2 == num)
				{
				default:
				{
					num = (short)613941248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)32768000;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMINGAIN_A21562.Editable;
			}
			set
			{
				short num = (short)634318589;
				short num2 = num;
				num = (short)346418941;
				switch (num2 == num)
				{
				}
				num = (short)164757504;
				short num3 = num;
				num = (short)1933246465;
				if (num != 0)
				{
				}
				num = (short)1362558976;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralMINGAIN_A21562.Editable = value;
			}
		}

		// Token: 0x170036E0 RID: 14048
		// (get) Token: 0x060069F7 RID: 27127 RVA: 0x005EBF20 File Offset: 0x005EA120
		internal string RadErgoCfgGeneralMINGAIN_A21562_UILabel
		{
			get
			{
				short num = (short)1737293825;
				if (num != 0)
				{
				}
				num = (short)219447963;
				short num2 = num;
				num = (short)949846683;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1455292416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)390004736;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMINGAIN_A21562.UIName;
			}
		}

		// Token: 0x170036E1 RID: 14049
		// (get) Token: 0x060069F8 RID: 27128 RVA: 0x005EBFD4 File Offset: 0x005EA1D4
		// (set) Token: 0x060069F9 RID: 27129 RVA: 0x005EC088 File Offset: 0x005EA288
		internal bool RadErgoCfgGeneralMINGAIN_A21562_HiddenStatic
		{
			get
			{
				short num = (short)700374446;
				short num2 = num;
				num = (short)1193139630;
				switch (num2 == num)
				{
				}
				num = (short)1502740480;
				short num3 = num;
				num = (short)1503657985;
				if (num != 0)
				{
				}
				num = (short)60227584;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMINGAIN_A21562.HiddenStatic;
			}
			set
			{
				short num = (short)1260584745;
				short num2 = num;
				num = (short)951713577;
				switch (num2 == num)
				{
				}
				num = (short)331677696;
				short num3 = num;
				num = (short)278790144;
				if (num != 0)
				{
				}
				num = (short)27787265;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralMINGAIN_A21562.HiddenStatic = value;
			}
		}

		// Token: 0x170036E2 RID: 14050
		// (get) Token: 0x060069FA RID: 27130 RVA: 0x005EC13C File Offset: 0x005EA33C
		// (set) Token: 0x060069FB RID: 27131 RVA: 0x005EC1F4 File Offset: 0x005EA3F4
		internal bool RadErgoCfgGeneralMINGAIN_A21562_HiddenDynamic
		{
			get
			{
				short num = (short)614369286;
				short num2 = num;
				num = (short)3180550;
				switch (num2 == num)
				{
				}
				num = (short)744488960;
				short num3 = num;
				num = (short)1200553985;
				if (num != 0)
				{
				}
				num = (short)256638976;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMINGAIN_A21562.HiddenDynamic;
			}
			set
			{
				short num = (short)1541019904;
				short num2 = num;
				num = (short)905582848;
				switch (num2 == num)
				{
				}
				num = (short)216858624;
				short num3 = num;
				num = (short)546832385;
				if (num != 0)
				{
				}
				num = (short)1049427968;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralMINGAIN_A21562.HiddenDynamic = value;
			}
		}

		// Token: 0x170036E3 RID: 14051
		// (get) Token: 0x060069FC RID: 27132 RVA: 0x005EC2AC File Offset: 0x005EA4AC
		public bool RadErgoCfgGeneralMINGAIN_A21562_HasDiffs
		{
			get
			{
				short num = (short)811345181;
				short num2 = num;
				num = (short)1923491101;
				switch (num2 == num)
				{
				}
				num = (short)487587840;
				short num3 = num;
				num = (short)2140274688;
				if (num != 0)
				{
				}
				num = (short)1027080193;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralMINGAIN_A21562._HasDiffs;
			}
		}

		// Token: 0x170036E4 RID: 14052
		// (get) Token: 0x060069FD RID: 27133 RVA: 0x005EC360 File Offset: 0x005EA560
		// (set) Token: 0x060069FE RID: 27134 RVA: 0x005EC414 File Offset: 0x005EA614
		public int RadErgoCfgGeneralDINCABFSS_A21564Value
		{
			get
			{
				short num = (short)349437953;
				if (num != 0)
				{
				}
				num = (short)212862776;
				short num2 = num;
				num = (short)5179192;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1739325440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1764950016;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A21564.Value;
			}
			set
			{
				short num = (short)400968662;
				short num2 = num;
				num = (short)436227030;
				switch (num2 == num)
				{
				}
				num = (short)438501376;
				short num3 = num;
				num = (short)1238892545;
				if (num != 0)
				{
				}
				num = (short)679477248;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCABFSS_A21564.Value = value;
			}
		}

		// Token: 0x170036E5 RID: 14053
		// (get) Token: 0x060069FF RID: 27135 RVA: 0x005EC4C8 File Offset: 0x005EA6C8
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgGeneralDINCABFSS_A21564
		{
			get
			{
				short num = (short)1032388609;
				if (num != 0)
				{
				}
				num = (short)1216963270;
				short num2 = num;
				num = (short)187327174;
				switch (num2 == num)
				{
				default:
				{
					num = (short)631635968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1499136000;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A21564;
			}
		}

		// Token: 0x170036E6 RID: 14054
		// (get) Token: 0x06006A00 RID: 27136 RVA: 0x005EC578 File Offset: 0x005EA778
		// (set) Token: 0x06006A01 RID: 27137 RVA: 0x005EC62C File Offset: 0x005EA82C
		public string RadErgoCfgGeneralDINCABFSS_A21564_UIValue
		{
			get
			{
				short num = (short)85113291;
				short num2 = num;
				num = (short)289913291;
				switch (num2 == num)
				{
				}
				num = (short)579665920;
				short num3 = num;
				num = (short)1325662209;
				if (num != 0)
				{
				}
				num = (short)813039616;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A21564.UIValue;
			}
			set
			{
				short num = (short)1168344262;
				short num2 = num;
				num = (short)863470790;
				switch (num2 == num)
				{
				}
				num = (short)1737621504;
				short num3 = num;
				num = (short)1677328385;
				if (num != 0)
				{
				}
				num = (short)773324800;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCABFSS_A21564.UIValue = value;
			}
		}

		// Token: 0x170036E7 RID: 14055
		// (get) Token: 0x06006A02 RID: 27138 RVA: 0x005EC6E4 File Offset: 0x005EA8E4
		// (set) Token: 0x06006A03 RID: 27139 RVA: 0x005EC79C File Offset: 0x005EA99C
		public string RadErgoCfgGeneralDINCABFSS_A21564_HexUIValue
		{
			get
			{
				short num = (short)1383166383;
				short num2 = num;
				num = (short)43741615;
				switch (num2 == num)
				{
				}
				num = (short)1789329408;
				short num3 = num;
				num = (short)2145714177;
				if (num != 0)
				{
				}
				num = (short)2093481984;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A21564.HexUIValue;
			}
			set
			{
				short num = (short)1956663817;
				short num2 = num;
				num = (short)1755468297;
				switch (num2 == num)
				{
				}
				num = (short)1745354752;
				short num3 = num;
				num = (short)549715969;
				if (num != 0)
				{
				}
				num = (short)869924864;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCABFSS_A21564.HexUIValue = value;
			}
		}

		// Token: 0x170036E8 RID: 14056
		// (get) Token: 0x06006A04 RID: 27140 RVA: 0x005EC850 File Offset: 0x005EAA50
		// (set) Token: 0x06006A05 RID: 27141 RVA: 0x005EC908 File Offset: 0x005EAB08
		internal int RadErgoCfgGeneralDINCABFSS_A21564Min
		{
			get
			{
				short num = (short)1350451924;
				short num2 = num;
				num = (short)1511408340;
				switch (num2 == num)
				{
				}
				num = (short)1759313920;
				short num3 = num;
				num = (short)573046784;
				if (num != 0)
				{
				}
				num = (short)1269039105;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A21564.Min;
			}
			set
			{
				short num = (short)1047658497;
				if (num != 0)
				{
				}
				num = (short)1680993285;
				short num2 = num;
				num = (short)1508174853;
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
				num = (short)1442643968;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCABFSS_A21564.Min = value;
			}
		}

		// Token: 0x170036E9 RID: 14057
		// (get) Token: 0x06006A06 RID: 27142 RVA: 0x005EC9BC File Offset: 0x005EABBC
		// (set) Token: 0x06006A07 RID: 27143 RVA: 0x005ECA74 File Offset: 0x005EAC74
		internal int RadErgoCfgGeneralDINCABFSS_A21564Max
		{
			get
			{
				short num = (short)2105512116;
				short num2 = num;
				num = (short)883527860;
				switch (num2 == num)
				{
				}
				num = (short)1632763904;
				short num3 = num;
				num = (short)1745485824;
				if (num != 0)
				{
				}
				num = (short)1500774401;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A21564.Max;
			}
			set
			{
				short num = (short)248806166;
				short num2 = num;
				num = (short)1500740374;
				switch (num2 == num)
				{
				}
				num = (short)577568768;
				short num3 = num;
				num = (short)1925578753;
				if (num != 0)
				{
				}
				num = (short)82903040;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCABFSS_A21564.Max = value;
			}
		}

		// Token: 0x170036EA RID: 14058
		// (get) Token: 0x06006A08 RID: 27144 RVA: 0x005ECB28 File Offset: 0x005EAD28
		// (set) Token: 0x06006A09 RID: 27145 RVA: 0x005ECBDC File Offset: 0x005EADDC
		internal int RadErgoCfgGeneralDINCABFSS_A21564Step
		{
			get
			{
				short num = (short)836855538;
				short num2 = num;
				num = (short)642737906;
				switch (num2 == num)
				{
				}
				num = (short)106889216;
				short num3 = num;
				num = (short)1453981697;
				if (num != 0)
				{
				}
				num = (short)1786773504;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A21564.StepSize;
			}
			set
			{
				short num = (short)1803747329;
				if (num != 0)
				{
				}
				num = (short)261577133;
				short num2 = num;
				num = (short)1903057325;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1182334976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1922891776;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCABFSS_A21564.StepSize = value;
			}
		}

		// Token: 0x170036EB RID: 14059
		// (get) Token: 0x06006A0A RID: 27146 RVA: 0x005ECC94 File Offset: 0x005EAE94
		// (set) Token: 0x06006A0B RID: 27147 RVA: 0x005ECD4C File Offset: 0x005EAF4C
		public bool RadErgoCfgGeneralDINCABFSS_A21564_Applicable
		{
			get
			{
				short num = (short)1198864454;
				short num2 = num;
				num = (short)886716486;
				switch (num2 == num)
				{
				}
				num = (short)738328576;
				short num3 = num;
				num = (short)515112960;
				if (num != 0)
				{
				}
				num = (short)935067649;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A21564.Applicable;
			}
			set
			{
				short num = (short)607749973;
				short num2 = num;
				num = (short)1714456405;
				switch (num2 == num)
				{
				}
				num = (short)1236926464;
				short num3 = num;
				num = (short)611188737;
				if (num != 0)
				{
				}
				num = (short)23199744;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCABFSS_A21564.Applicable = value;
			}
		}

		// Token: 0x170036EC RID: 14060
		// (get) Token: 0x06006A0C RID: 27148 RVA: 0x005ECE04 File Offset: 0x005EB004
		// (set) Token: 0x06006A0D RID: 27149 RVA: 0x005ECEB8 File Offset: 0x005EB0B8
		public bool RadErgoCfgGeneralDINCABFSS_A21564_Valid
		{
			get
			{
				short num = (short)324685645;
				short num2 = num;
				num = (short)1624002381;
				switch (num2 == num)
				{
				}
				num = (short)1678835712;
				short num3 = num;
				num = (short)1817313281;
				if (num != 0)
				{
				}
				num = (short)65536;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A21564.Valid;
			}
			set
			{
				short num = (short)147019095;
				short num2 = num;
				num = (short)1963152727;
				switch (num2 == num)
				{
				}
				num = (short)368312320;
				short num3 = num;
				num = (short)646709248;
				if (num != 0)
				{
				}
				num = (short)560922625;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCABFSS_A21564.Valid = value;
			}
		}

		// Token: 0x170036ED RID: 14061
		// (get) Token: 0x06006A0E RID: 27150 RVA: 0x005ECF6C File Offset: 0x005EB16C
		// (set) Token: 0x06006A0F RID: 27151 RVA: 0x005ED020 File Offset: 0x005EB220
		public bool RadErgoCfgGeneralDINCABFSS_A21564_Visible
		{
			get
			{
				short num = (short)1294759710;
				short num2 = num;
				num = (short)898463518;
				switch (num2 == num)
				{
				}
				num = (short)573898752;
				short num3 = num;
				num = (short)2070216705;
				if (num != 0)
				{
				}
				num = (short)1000865792;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A21564.Visible;
			}
			set
			{
				short num = (short)1873700055;
				short num2 = num;
				num = (short)1194550487;
				switch (num2 == num)
				{
				}
				num = (short)778764288;
				short num3 = num;
				num = (short)801374208;
				if (num != 0)
				{
				}
				num = (short)1214251009;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCABFSS_A21564.Visible = value;
			}
		}

		// Token: 0x170036EE RID: 14062
		// (get) Token: 0x06006A10 RID: 27152 RVA: 0x005ED0D8 File Offset: 0x005EB2D8
		// (set) Token: 0x06006A11 RID: 27153 RVA: 0x005ED190 File Offset: 0x005EB390
		public bool RadErgoCfgGeneralDINCABFSS_A21564_Editable
		{
			get
			{
				short num = (short)1599259632;
				short num2 = num;
				num = (short)2017903600;
				switch (num2 == num)
				{
				}
				num = (short)1980497920;
				short num3 = num;
				num = (short)1510342657;
				if (num != 0)
				{
				}
				num = (short)1163591680;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A21564.Editable;
			}
			set
			{
				short num = (short)962388864;
				short num2 = num;
				num = (short)2061362048;
				switch (num2 == num)
				{
				}
				num = (short)1372913664;
				short num3 = num;
				num = (short)1080492032;
				if (num != 0)
				{
				}
				num = (short)953876481;
				if (num != 0)
				{
				}
				this.radErgoCfgGeneralDINCABFSS_A21564.Editable = value;
			}
		}

		// Token: 0x170036EF RID: 14063
		// (get) Token: 0x06006A12 RID: 27154 RVA: 0x005ED244 File Offset: 0x005EB444
		internal string RadErgoCfgGeneralDINCABFSS_A21564_UILabel
		{
			get
			{
				short num = (short)327664390;
				short num2 = num;
				num = (short)1619903238;
				switch (num2 == num)
				{
				}
				num = (short)1257177088;
				short num3 = num;
				num = (short)742850561;
				if (num != 0)
				{
				}
				num = (short)521338880;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A21564.UIName;
			}
		}

		// Token: 0x170036F0 RID: 14064
		// (get) Token: 0x06006A13 RID: 27155 RVA: 0x005ED2F8 File Offset: 0x005EB4F8
		// (set) Token: 0x06006A14 RID: 27156 RVA: 0x005ED3AC File Offset: 0x005EB5AC
		internal bool RadErgoCfgGeneralDINCABFSS_A21564_HiddenStatic
		{
			get
			{
				short num = (short)494927053;
				short num2 = num;
				num = (short)1798175949;
				switch (num2 == num)
				{
				}
				num = (short)1778974720;
				short num3 = num;
				num = (short)1845231617;
				if (num != 0)
				{
				}
				num = (short)1055457280;
				if (num != 0)
				{
				}
				return this.radErgoCfgGeneralDINCABFSS_A21564.HiddenStatic;
			}
			set
			{
				short num = (short)1259508269;
				short num2 = num;
				num = (short)23564845;
				switch (num2 == num)
				{
				}
				num = (short)1753153537;
				if (num != 0)
				{
				}
				num = (short)718077952;
				if (num != 0)
				{
				}
				num = (short)1796145152;
				short num3 = num;
				this.radErgoCfgGeneralDINCABFSS_A21564.HiddenStatic = value;
			}
		}

		// Token: 0x170036F1 RID: 14065
		// (get) Token: 0x06006A15 RID: 27157 RVA: 0x005ED460 File Offset: 0x005EB660
		// (set) Token: 0x06006A16 RID: 27158 RVA: 0x005ED514 File Offset: 0x005EB714
		internal bool RadErgoCfgGeneralDINCABFSS_A21564_HiddenDynamic
		{
			get
			{
				short num = (short)1235627484;
				short num2 = num;
				num = (short)1751395804;
				switch (num2 == num)
				{
				}
				num = (short)719060993;
				if (num != 0)
				{
				}
				num = (short)2082734080;
				if (num != 0)
				{
				}
				num = (short)997392384;
				short num3 = num;
				return this.radErgoCfgGeneralDINCABFSS_A21564.HiddenDynamic;
			}
			set
			{
				short num = (short)462741113;
				short num2 = num;
				num = (short)668458617;
				switch (num2 == num)
				{
				}
				num = (short)523304961;
				if (num != 0)
				{
				}
				num = (short)723451904;
				if (num != 0)
				{
				}
				num = (short)1297219584;
				short num3 = num;
				this.radErgoCfgGeneralDINCABFSS_A21564.HiddenDynamic = value;
			}
		}

		// Token: 0x170036F2 RID: 14066
		// (get) Token: 0x06006A17 RID: 27159 RVA: 0x005ED5C8 File Offset: 0x005EB7C8
		public bool RadErgoCfgGeneralDINCABFSS_A21564_HasDiffs
		{
			get
			{
				short num = (short)1373171521;
				short num2 = num;
				num = (short)440004417;
				switch (num2 == num)
				{
				}
				num = (short)95420417;
				if (num != 0)
				{
				}
				num = (short)1878786048;
				if (num != 0)
				{
				}
				num = (short)243400704;
				short num3 = num;
				return this.radErgoCfgGeneralDINCABFSS_A21564._HasDiffs;
			}
		}

		// Token: 0x170036F3 RID: 14067
		// (get) Token: 0x06006A18 RID: 27160 RVA: 0x005ED678 File Offset: 0x005EB878
		// (set) Token: 0x06006A19 RID: 27161 RVA: 0x005ED730 File Offset: 0x005EB930
		public int RadErgoCfgGeneralNBANDS_A21573Value
		{
			get
			{
				short num = (short)63150830;
				short num2 = num;
				num = (short)959027950;
				switch (num2 == num)
				{
				}
				num = (short)1095565313;
				if (num != 0)
				{
				}
				num = (short)909443072;
				if (num != 0)
				{
				}
				num = (short)143589376;
				short num3 = num;
				return this.radErgoCfgGeneralNBANDS_A21573.Value;
			}
			set
			{
				short num = (short)1976657660;
				short num2 = num;
				num = (short)1274373884;
				switch (num2 == num)
				{
				}
				num = (short)2086600705;
				if (num != 0)
				{
				}
				num = (short)1700659200;
				if (num != 0)
				{
				}
				num = (short)636092416;
				short num3 = num;
				this.radErgoCfgGeneralNBANDS_A21573.Value = value;
			}
		}

		// Token: 0x170036F4 RID: 14068
		// (get) Token: 0x06006A1A RID: 27162 RVA: 0x005ED7E8 File Offset: 0x005EB9E8
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgGeneralNBANDS_A21573
		{
			get
			{
				short num = (short)305294366;
				short num2 = num;
				num = (short)426667038;
				switch (num2 == num)
				{
				}
				num = (short)2094596096;
				if (num != 0)
				{
				}
				num = (short)151650305;
				if (num != 0)
				{
				}
				num = (short)856227840;
				short num3 = num;
				return this.radErgoCfgGeneralNBANDS_A21573;
			}
		}

		// Token: 0x170036F5 RID: 14069
		// (get) Token: 0x06006A1B RID: 27163 RVA: 0x005ED894 File Offset: 0x005EBA94
		// (set) Token: 0x06006A1C RID: 27164 RVA: 0x005ED94C File Offset: 0x005EBB4C
		public string RadErgoCfgGeneralNBANDS_A21573_UIValue
		{
			get
			{
				short num = (short)1293801780;
				short num2 = num;
				num = (short)92854580;
				switch (num2 == num)
				{
				}
				num = (short)158334977;
				if (num != 0)
				{
				}
				num = (short)1082458112;
				if (num != 0)
				{
				}
				num = (short)748945408;
				short num3 = num;
				return this.radErgoCfgGeneralNBANDS_A21573.UIValue;
			}
			set
			{
				short num = (short)1519321089;
				if (num != 0)
				{
				}
				num = (short)1862788858;
				short num2 = num;
				num = (short)917694202;
				switch (num2 == num)
				{
				}
				num = (short)1169752064;
				if (num != 0)
				{
				}
				num = (short)498991104;
				short num3 = num;
				this.radErgoCfgGeneralNBANDS_A21573.UIValue = value;
			}
		}

		// Token: 0x170036F6 RID: 14070
		// (get) Token: 0x06006A1D RID: 27165 RVA: 0x005EDA00 File Offset: 0x005EBC00
		// (set) Token: 0x06006A1E RID: 27166 RVA: 0x005EDAB4 File Offset: 0x005EBCB4
		public string RadErgoCfgGeneralNBANDS_A21573_HexUIValue
		{
			get
			{
				short num = (short)1589278138;
				short num2 = num;
				num = (short)620590522;
				switch (num2 == num)
				{
				}
				num = (short)382795777;
				if (num != 0)
				{
				}
				num = (short)1794506752;
				if (num != 0)
				{
				}
				num = (short)2020802560;
				short num3 = num;
				return this.radErgoCfgGeneralNBANDS_A21573.HexUIValue;
			}
			set
			{
				short num = (short)525152732;
				short num2 = num;
				num = (short)726807004;
				switch (num2 == num)
				{
				}
				num = (short)2084634625;
				if (num != 0)
				{
				}
				num = (short)1279524864;
				if (num != 0)
				{
				}
				num = (short)1848573952;
				short num3 = num;
				this.radErgoCfgGeneralNBANDS_A21573.HexUIValue = value;
			}
		}

		// Token: 0x170036F7 RID: 14071
		// (get) Token: 0x06006A1F RID: 27167 RVA: 0x005EDB6C File Offset: 0x005EBD6C
		// (set) Token: 0x06006A20 RID: 27168 RVA: 0x005EDC20 File Offset: 0x005EBE20
		internal int RadErgoCfgGeneralNBANDS_A21573Min
		{
			get
			{
				short num = (short)1541677621;
				short num2 = num;
				num = (short)1035412021;
				switch (num2 == num)
				{
				}
				num = (short)946536449;
				if (num != 0)
				{
				}
				num = (short)1382481920;
				if (num != 0)
				{
				}
				num = (short)134807552;
				short num3 = num;
				return this.radErgoCfgGeneralNBANDS_A21573.Min;
			}
			set
			{
				short num = (short)1003893572;
				short num2 = num;
				num = (short)1253258052;
				switch (num2 == num)
				{
				}
				num = (short)312475648;
				if (num != 0)
				{
				}
				num = (short)1165688833;
				if (num != 0)
				{
				}
				num = (short)93716480;
				short num3 = num;
				this.radErgoCfgGeneralNBANDS_A21573.Min = value;
			}
		}

		// Token: 0x170036F8 RID: 14072
		// (get) Token: 0x06006A21 RID: 27169 RVA: 0x005EDCD4 File Offset: 0x005EBED4
		// (set) Token: 0x06006A22 RID: 27170 RVA: 0x005EDD88 File Offset: 0x005EBF88
		internal int RadErgoCfgGeneralNBANDS_A21573Max
		{
			get
			{
				short num = (short)2044085439;
				short num2 = num;
				num = (short)1419199679;
				switch (num2 == num)
				{
				}
				num = (short)593625088;
				if (num != 0)
				{
				}
				num = (short)101974017;
				if (num != 0)
				{
				}
				num = (short)2106654720;
				short num3 = num;
				return this.radErgoCfgGeneralNBANDS_A21573.Max;
			}
			set
			{
				short num = (short)2014512615;
				short num2 = num;
				num = (short)1402144231;
				switch (num2 == num)
				{
				}
				num = (short)1449590785;
				if (num != 0)
				{
				}
				num = (short)1850998784;
				if (num != 0)
				{
				}
				num = (short)634126336;
				short num3 = num;
				this.radErgoCfgGeneralNBANDS_A21573.Max = value;
			}
		}

		// Token: 0x170036F9 RID: 14073
		// (get) Token: 0x06006A23 RID: 27171 RVA: 0x005EDE44 File Offset: 0x005EC044
		// (set) Token: 0x06006A24 RID: 27172 RVA: 0x005EDEF8 File Offset: 0x005EC0F8
		internal int RadErgoCfgGeneralNBANDS_A21573Step
		{
			get
			{
				short num = (short)2103629082;
				short num2 = num;
				num = (short)1229706522;
				switch (num2 == num)
				{
				}
				num = (short)1775894529;
				if (num != 0)
				{
				}
				num = (short)1796210688;
				if (num != 0)
				{
				}
				num = (short)1025310720;
				short num3 = num;
				return this.radErgoCfgGeneralNBANDS_A21573.StepSize;
			}
			set
			{
				short num = (short)310685928;
				short num2 = num;
				num = (short)312652008;
				switch (num2 == num)
				{
				}
				num = (short)1654390785;
				if (num != 0)
				{
				}
				num = (short)644349952;
				if (num != 0)
				{
				}
				num = (short)1450639360;
				short num3 = num;
				this.radErgoCfgGeneralNBANDS_A21573.StepSize = value;
			}
		}

		// Token: 0x170036FA RID: 14074
		// (get) Token: 0x06006A25 RID: 27173 RVA: 0x005EDFB4 File Offset: 0x005EC1B4
		// (set) Token: 0x06006A26 RID: 27174 RVA: 0x005EE064 File Offset: 0x005EC264
		public bool RadErgoCfgGeneralNBANDS_A21573_Applicable
		{
			get
			{
				short num = (short)319202439;
				short num2 = num;
				num = (short)1462543495;
				switch (num2 == num)
				{
				}
				num = (short)1475543041;
				if (num != 0)
				{
				}
				num = (short)1914503168;
				if (num != 0)
				{
				}
				num = (short)1419902976;
				short num3 = num;
				return this.radErgoCfgGeneralNBANDS_A21573.Applicable;
			}
			set
			{
				short num = (short)2087689320;
				short num2 = num;
				num = (short)1867291752;
				switch (num2 == num)
				{
				}
				num = (short)971833345;
				if (num != 0)
				{
				}
				num = (short)503840768;
				if (num != 0)
				{
				}
				num = (short)188612608;
				short num3 = num;
				this.radErgoCfgGeneralNBANDS_A21573.Applicable = value;
			}
		}

		// Token: 0x170036FB RID: 14075
		// (get) Token: 0x06006A27 RID: 27175 RVA: 0x005EE11C File Offset: 0x005EC31C
		// (set) Token: 0x06006A28 RID: 27176 RVA: 0x005EE1D0 File Offset: 0x005EC3D0
		public bool RadErgoCfgGeneralNBANDS_A21573_Valid
		{
			get
			{
				short num = (short)2106785793;
				if (num != 0)
				{
				}
				num = (short)1435374683;
				short num2 = num;
				num = (short)2114262107;
				switch (num2 == num)
				{
				}
				num = (short)1084358656;
				if (num != 0)
				{
				}
				num = (short)301006848;
				short num3 = num;
				return this.radErgoCfgGeneralNBANDS_A21573.Valid;
			}
			set
			{
				short num = (short)823263233;
				if (num != 0)
				{
				}
				num = (short)448768037;
				short num2 = num;
				num = (short)805283877;
				switch (num2 == num)
				{
				}
				num = (short)1605566464;
				if (num != 0)
				{
				}
				num = (short)2140405760;
				short num3 = num;
				this.radErgoCfgGeneralNBANDS_A21573.Valid = value;
			}
		}

		// Token: 0x170036FC RID: 14076
		// (get) Token: 0x06006A29 RID: 27177 RVA: 0x005EE284 File Offset: 0x005EC484
		// (set) Token: 0x06006A2A RID: 27178 RVA: 0x005EE33C File Offset: 0x005EC53C
		public bool RadErgoCfgGeneralNBANDS_A21573_Visible
		{
			get
			{
				short num = (short)1234810017;
				short num2 = num;
				num = (short)1687073953;
				switch (num2 == num)
				{
				}
				num = (short)164102145;
				if (num != 0)
				{
				}
				num = (short)1868824576;
				if (num != 0)
				{
				}
				num = (short)1806172160;
				short num3 = num;
				return this.radErgoCfgGeneralNBANDS_A21573.Visible;
			}
			set
			{
				short num = (short)20250625;
				if (num != 0)
				{
				}
				num = (short)442841847;
				short num2 = num;
				num = (short)1500986103;
				switch (num2 == num)
				{
				}
				num = (short)1167917056;
				if (num != 0)
				{
				}
				num = (short)1729298432;
				short num3 = num;
				this.radErgoCfgGeneralNBANDS_A21573.Visible = value;
			}
		}

		// Token: 0x170036FD RID: 14077
		// (get) Token: 0x06006A2B RID: 27179 RVA: 0x005EE3F4 File Offset: 0x005EC5F4
		// (set) Token: 0x06006A2C RID: 27180 RVA: 0x005EE4A8 File Offset: 0x005EC6A8
		public bool RadErgoCfgGeneralNBANDS_A21573_Editable
		{
			get
			{
				short num = (short)441098318;
				short num2 = num;
				num = (short)1947246670;
				switch (num2 == num)
				{
				}
				num = (short)990642177;
				if (num != 0)
				{
				}
				num = (short)1910308864;
				if (num != 0)
				{
				}
				num = (short)1831862272;
				short num3 = num;
				return this.radErgoCfgGeneralNBANDS_A21573.Editable;
			}
			set
			{
				short num = (short)1730478081;
				if (num != 0)
				{
				}
				num = (short)1601206160;
				short num2 = num;
				num = (short)1501198224;
				switch (num2 == num)
				{
				}
				num = (short)1145044992;
				if (num != 0)
				{
				}
				num = (short)670367744;
				short num3 = num;
				this.radErgoCfgGeneralNBANDS_A21573.Editable = value;
			}
		}

		// Token: 0x170036FE RID: 14078
		// (get) Token: 0x06006A2D RID: 27181 RVA: 0x005EE55C File Offset: 0x005EC75C
		internal string RadErgoCfgGeneralNBANDS_A21573_UILabel
		{
			get
			{
				short num = (short)1342072744;
				short num2 = num;
				num = (short)106784680;
				switch (num2 == num)
				{
				}
				num = (short)1151074305;
				if (num != 0)
				{
				}
				num = (short)889454592;
				if (num != 0)
				{
				}
				num = (short)2001993728;
				short num3 = num;
				return this.radErgoCfgGeneralNBANDS_A21573.UIName;
			}
		}

		// Token: 0x170036FF RID: 14079
		// (get) Token: 0x06006A2E RID: 27182 RVA: 0x005EE614 File Offset: 0x005EC814
		// (set) Token: 0x06006A2F RID: 27183 RVA: 0x005EE6C8 File Offset: 0x005EC8C8
		internal bool RadErgoCfgGeneralNBANDS_A21573_HiddenStatic
		{
			get
			{
				short num = (short)1264268109;
				short num2 = num;
				num = (short)957690701;
				switch (num2 == num)
				{
				}
				num = (short)1131610113;
				if (num != 0)
				{
				}
				num = (short)2017918976;
				if (num != 0)
				{
				}
				num = (short)1972502528;
				short num3 = num;
				return this.radErgoCfgGeneralNBANDS_A21573.HiddenStatic;
			}
			set
			{
				short num = (short)1074432086;
				short num2 = num;
				num = (short)1366132822;
				switch (num2 == num)
				{
				}
				num = (short)220790785;
				if (num != 0)
				{
				}
				num = (short)1718222848;
				if (num != 0)
				{
				}
				num = (short)1270874112;
				short num3 = num;
				this.radErgoCfgGeneralNBANDS_A21573.HiddenStatic = value;
			}
		}

		// Token: 0x17003700 RID: 14080
		// (get) Token: 0x06006A30 RID: 27184 RVA: 0x005EE77C File Offset: 0x005EC97C
		// (set) Token: 0x06006A31 RID: 27185 RVA: 0x005EE834 File Offset: 0x005ECA34
		internal bool RadErgoCfgGeneralNBANDS_A21573_HiddenDynamic
		{
			get
			{
				short num = (short)1283557386;
				short num2 = num;
				num = (short)717785098;
				switch (num2 == num)
				{
				}
				num = (short)959578113;
				if (num != 0)
				{
				}
				num = (short)342228992;
				if (num != 0)
				{
				}
				num = (short)257294336;
				short num3 = num;
				return this.radErgoCfgGeneralNBANDS_A21573.HiddenDynamic;
			}
			set
			{
				short num = (short)1437279023;
				short num2 = num;
				num = (short)508961583;
				switch (num2 == num)
				{
				}
				num = (short)668663808;
				if (num != 0)
				{
				}
				num = (short)99155969;
				if (num != 0)
				{
				}
				num = (short)1689976832;
				short num3 = num;
				this.radErgoCfgGeneralNBANDS_A21573.HiddenDynamic = value;
			}
		}

		// Token: 0x17003701 RID: 14081
		// (get) Token: 0x06006A32 RID: 27186 RVA: 0x005EE8F0 File Offset: 0x005ECAF0
		public bool RadErgoCfgGeneralNBANDS_A21573_HasDiffs
		{
			get
			{
				short num = (short)225596687;
				short num2 = num;
				num = (short)940070159;
				switch (num2 == num)
				{
				}
				num = (short)983891968;
				if (num != 0)
				{
				}
				num = (short)1724579841;
				if (num != 0)
				{
				}
				num = (short)1963720704;
				short num3 = num;
				return this.radErgoCfgGeneralNBANDS_A21573._HasDiffs;
			}
		}

		// Token: 0x17003702 RID: 14082
		// (get) Token: 0x06006A33 RID: 27187 RVA: 0x005EE9A4 File Offset: 0x005ECBA4
		// (set) Token: 0x06006A34 RID: 27188 RVA: 0x005EEA58 File Offset: 0x005ECC58
		public string RadErgoCfgGeneralMAXSVECTOR_A21565Value
		{
			get
			{
				short num = (short)704839681;
				if (num != 0)
				{
				}
				num = (short)1367753116;
				short num2 = num;
				num = (short)1446658460;
				switch (num2 == num)
				{
				}
				num = (short)837615616;
				if (num != 0)
				{
				}
				num = (short)1229455360;
				short num3 = num;
				return this.radErgoCfgGeneralMAXSVECTOR_A21565.Value;
			}
			set
			{
				short num = (short)1211647026;
				short num2 = num;
				num = (short)1445938226;
				switch (num2 == num)
				{
				}
				num = (short)959512577;
				if (num != 0)
				{
				}
				num = (short)1572470784;
				if (num != 0)
				{
				}
				num = (short)37683200;
				short num3 = num;
				this.radErgoCfgGeneralMAXSVECTOR_A21565.Value = value;
			}
		}

		// Token: 0x17003703 RID: 14083
		// (get) Token: 0x06006A35 RID: 27189 RVA: 0x005EEB0C File Offset: 0x005ECD0C
		public global::AcpBusinessLayer.AcpField<string> RadErgoCfgGeneralMAXSVECTOR_A21565
		{
			get
			{
				short num = (short)770965505;
				if (num != 0)
				{
				}
				num = (short)1805602569;
				short num2 = num;
				num = (short)1812942601;
				switch (num2 == num)
				{
				}
				num = (short)1247543296;
				if (num != 0)
				{
				}
				num = (short)898367488;
				short num3 = num;
				return this.radErgoCfgGeneralMAXSVECTOR_A21565;
			}
		}

		// Token: 0x17003704 RID: 14084
		// (get) Token: 0x06006A36 RID: 27190 RVA: 0x005EEBC0 File Offset: 0x005ECDC0
		// (set) Token: 0x06006A37 RID: 27191 RVA: 0x005EEC74 File Offset: 0x005ECE74
		public string RadErgoCfgGeneralMAXSVECTOR_A21565_UIValue
		{
			get
			{
				short num = (short)2063650968;
				short num2 = num;
				num = (short)183029912;
				switch (num2 == num)
				{
				}
				num = (short)628555777;
				if (num != 0)
				{
				}
				num = (short)1455620096;
				if (num != 0)
				{
				}
				num = (short)870711296;
				short num3 = num;
				return this.radErgoCfgGeneralMAXSVECTOR_A21565.Value;
			}
			set
			{
				short num = (short)2050228225;
				if (num != 0)
				{
				}
				num = (short)1440451566;
				short num2 = num;
				num = (short)809536494;
				switch (num2 == num)
				{
				}
				num = (short)1253507072;
				if (num != 0)
				{
				}
				num = (short)1541799936;
				short num3 = num;
				this.radErgoCfgGeneralMAXSVECTOR_A21565.Value = value;
			}
		}

		// Token: 0x17003705 RID: 14085
		// (get) Token: 0x06006A38 RID: 27192 RVA: 0x005EED28 File Offset: 0x005ECF28
		// (set) Token: 0x06006A39 RID: 27193 RVA: 0x005EEDDC File Offset: 0x005ECFDC
		public bool RadErgoCfgGeneralMAXSVECTOR_A21565_Applicable
		{
			get
			{
				short num = (short)426508289;
				if (num != 0)
				{
				}
				num = (short)733652556;
				short num2 = num;
				num = (short)1687266892;
				switch (num2 == num)
				{
				}
				num = (short)559808512;
				if (num != 0)
				{
				}
				num = (short)906231808;
				short num3 = num;
				return this.radErgoCfgGeneralMAXSVECTOR_A21565.Applicable;
			}
			set
			{
				short num = (short)1155760749;
				short num2 = num;
				num = (short)1743815277;
				switch (num2 == num)
				{
				}
				num = (short)1481834497;
				if (num != 0)
				{
				}
				num = (short)1539440640;
				if (num != 0)
				{
				}
				num = (short)565379072;
				short num3 = num;
				this.radErgoCfgGeneralMAXSVECTOR_A21565.Applicable = value;
			}
		}

		// Token: 0x17003706 RID: 14086
		// (get) Token: 0x06006A3A RID: 27194 RVA: 0x005EEE90 File Offset: 0x005ED090
		// (set) Token: 0x06006A3B RID: 27195 RVA: 0x005EEF48 File Offset: 0x005ED148
		public bool RadErgoCfgGeneralMAXSVECTOR_A21565_Valid
		{
			get
			{
				short num = (short)650295067;
				short num2 = num;
				num = (short)475707163;
				switch (num2 == num)
				{
				}
				num = (short)1080164352;
				if (num != 0)
				{
				}
				num = (short)937099265;
				if (num != 0)
				{
				}
				num = (short)2028994560;
				short num3 = num;
				return this.radErgoCfgGeneralMAXSVECTOR_A21565.Valid;
			}
			set
			{
				short num = (short)1821704193;
				if (num != 0)
				{
				}
				num = (short)1233705943;
				short num2 = num;
				num = (short)1607392215;
				switch (num2 == num)
				{
				}
				num = (short)1156448256;
				if (num != 0)
				{
				}
				num = (short)630587392;
				short num3 = num;
				this.radErgoCfgGeneralMAXSVECTOR_A21565.Valid = value;
			}
		}

		// Token: 0x17003707 RID: 14087
		// (get) Token: 0x06006A3C RID: 27196 RVA: 0x005EF000 File Offset: 0x005ED200
		// (set) Token: 0x06006A3D RID: 27197 RVA: 0x005EF0B8 File Offset: 0x005ED2B8
		public bool RadErgoCfgGeneralMAXSVECTOR_A21565_Visible
		{
			get
			{
				short num = (short)202538983;
				short num2 = num;
				num = (short)1841528807;
				switch (num2 == num)
				{
				}
				num = (short)1484062721;
				if (num != 0)
				{
				}
				num = (short)1096613888;
				if (num != 0)
				{
				}
				num = (short)2054488064;
				short num3 = num;
				return this.radErgoCfgGeneralMAXSVECTOR_A21565.Visible;
			}
			set
			{
				short num = (short)1875949439;
				short num2 = num;
				num = (short)1358608255;
				switch (num2 == num)
				{
				}
				num = (short)957612033;
				if (num != 0)
				{
				}
				num = (short)1947926528;
				if (num != 0)
				{
				}
				num = (short)770244608;
				short num3 = num;
				this.radErgoCfgGeneralMAXSVECTOR_A21565.Visible = value;
			}
		}

		// Token: 0x17003708 RID: 14088
		// (get) Token: 0x06006A3E RID: 27198 RVA: 0x005EF16C File Offset: 0x005ED36C
		// (set) Token: 0x06006A3F RID: 27199 RVA: 0x005EF220 File Offset: 0x005ED420
		public bool RadErgoCfgGeneralMAXSVECTOR_A21565_Editable
		{
			get
			{
				short num = (short)291935260;
				short num2 = num;
				num = (short)2041156636;
				switch (num2 == num)
				{
				}
				num = (short)522911745;
				if (num != 0)
				{
				}
				num = (short)2021982208;
				if (num != 0)
				{
				}
				num = (short)2073624576;
				short num3 = num;
				return this.radErgoCfgGeneralMAXSVECTOR_A21565.Editable;
			}
			set
			{
				short num = (short)210366776;
				short num2 = num;
				num = (short)777646392;
				switch (num2 == num)
				{
				}
				num = (short)1171783680;
				if (num != 0)
				{
				}
				num = (short)604372993;
				if (num != 0)
				{
				}
				num = (short)645922816;
				short num3 = num;
				this.radErgoCfgGeneralMAXSVECTOR_A21565.Editable = value;
			}
		}

		// Token: 0x17003709 RID: 14089
		// (get) Token: 0x06006A40 RID: 27200 RVA: 0x005EF2D4 File Offset: 0x005ED4D4
		internal string RadErgoCfgGeneralMAXSVECTOR_A21565_UILabel
		{
			get
			{
				short num = (short)744433616;
				short num2 = num;
				num = (short)2002528208;
				switch (num2 == num)
				{
				}
				num = (short)1443233793;
				if (num != 0)
				{
				}
				num = (short)157810688;
				if (num != 0)
				{
				}
				num = (short)1387069440;
				short num3 = num;
				return this.radErgoCfgGeneralMAXSVECTOR_A21565.UIName;
			}
		}

		// Token: 0x1700370A RID: 14090
		// (get) Token: 0x06006A41 RID: 27201 RVA: 0x005EF388 File Offset: 0x005ED588
		// (set) Token: 0x06006A42 RID: 27202 RVA: 0x005EF43C File Offset: 0x005ED63C
		internal bool RadErgoCfgGeneralMAXSVECTOR_A21565_HiddenStatic
		{
			get
			{
				short num = (short)1690834449;
				short num2 = num;
				num = (short)1022826001;
				switch (num2 == num)
				{
				}
				num = (short)1858273281;
				if (num != 0)
				{
				}
				num = (short)1073741824;
				if (num != 0)
				{
				}
				num = (short)13893632;
				short num3 = num;
				return this.radErgoCfgGeneralMAXSVECTOR_A21565.HiddenStatic;
			}
			set
			{
				short num = (short)1782207505;
				short num2 = num;
				num = (short)1133859857;
				switch (num2 == num)
				{
				}
				num = (short)1855062017;
				if (num != 0)
				{
				}
				num = (short)131727360;
				if (num != 0)
				{
				}
				num = (short)1644429312;
				short num3 = num;
				this.radErgoCfgGeneralMAXSVECTOR_A21565.HiddenStatic = value;
			}
		}

		// Token: 0x1700370B RID: 14091
		// (get) Token: 0x06006A43 RID: 27203 RVA: 0x005EF4F0 File Offset: 0x005ED6F0
		// (set) Token: 0x06006A44 RID: 27204 RVA: 0x005EF5A8 File Offset: 0x005ED7A8
		internal bool RadErgoCfgGeneralMAXSVECTOR_A21565_HiddenDynamic
		{
			get
			{
				short num = (short)250153614;
				short num2 = num;
				num = (short)1873742478;
				switch (num2 == num)
				{
				}
				num = (short)202833920;
				if (num != 0)
				{
				}
				num = (short)172032001;
				if (num != 0)
				{
				}
				num = (short)928251904;
				short num3 = num;
				return this.radErgoCfgGeneralMAXSVECTOR_A21565.HiddenDynamic;
			}
			set
			{
				short num = (short)970280815;
				short num2 = num;
				num = (short)829050735;
				switch (num2 == num)
				{
				}
				num = (short)946929665;
				if (num != 0)
				{
				}
				num = (short)2091515904;
				if (num != 0)
				{
				}
				num = (short)862060544;
				short num3 = num;
				this.radErgoCfgGeneralMAXSVECTOR_A21565.HiddenDynamic = value;
			}
		}

		// Token: 0x1700370C RID: 14092
		// (get) Token: 0x06006A45 RID: 27205 RVA: 0x005EF660 File Offset: 0x005ED860
		public bool RadErgoCfgGeneralMAXSVECTOR_A21565_HasDiffs
		{
			get
			{
				short num = (short)229244929;
				if (num != 0)
				{
				}
				num = (short)1782424067;
				short num2 = num;
				num = (short)1197449731;
				switch (num2 == num)
				{
				}
				num = (short)1235222528;
				if (num != 0)
				{
				}
				num = (short)1867841536;
				short num3 = num;
				return this.radErgoCfgGeneralMAXSVECTOR_A21565._HasDiffs;
			}
		}

		// Token: 0x1700370D RID: 14093
		// (get) Token: 0x06006A46 RID: 27206 RVA: 0x005EF710 File Offset: 0x005ED910
		// (set) Token: 0x06006A47 RID: 27207 RVA: 0x005EF7C4 File Offset: 0x005ED9C4
		public string IntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676Value
		{
			get
			{
				short num = (short)735622126;
				short num2 = num;
				num = (short)1971893230;
				switch (num2 == num)
				{
				}
				num = (short)1068826625;
				if (num != 0)
				{
				}
				num = (short)724631552;
				if (num != 0)
				{
				}
				num = (short)1125187584;
				short num3 = num;
				return this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676.Value;
			}
			set
			{
				short num = (short)1577852776;
				short num2 = num;
				num = (short)965484392;
				switch (num2 == num)
				{
				}
				num = (short)1679622145;
				if (num != 0)
				{
				}
				num = (short)232914944;
				if (num != 0)
				{
				}
				num = (short)477233152;
				short num3 = num;
				this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676.Value = value;
			}
		}

		// Token: 0x1700370E RID: 14094
		// (get) Token: 0x06006A48 RID: 27208 RVA: 0x005EF87C File Offset: 0x005EDA7C
		public global::AcpBusinessLayer.AcpField<string> IntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676
		{
			get
			{
				short num = (short)1716340503;
				short num2 = num;
				num = (short)651183895;
				switch (num2 == num)
				{
				}
				num = (short)983171073;
				if (num != 0)
				{
				}
				num = (short)1806893056;
				if (num != 0)
				{
				}
				num = (short)168427520;
				short num3 = num;
				return this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676;
			}
		}

		// Token: 0x1700370F RID: 14095
		// (get) Token: 0x06006A49 RID: 27209 RVA: 0x005EF92C File Offset: 0x005EDB2C
		// (set) Token: 0x06006A4A RID: 27210 RVA: 0x005EF9E4 File Offset: 0x005EDBE4
		public string IntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676_UIValue
		{
			get
			{
				short num = (short)2134900736;
				short num2 = num;
				num = (short)1754312362;
				short num3 = num;
				num = (short)551464618;
				switch (num3 == num)
				{
				}
				num = (short)42532865;
				if (num != 0)
				{
				}
				num = (short)1992884224;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676.Value;
			}
			set
			{
				short num = (short)234291200;
				short num2 = num;
				num = (short)283815;
				short num3 = num;
				num = (short)438457511;
				switch (num3 == num)
				{
				}
				num = (short)135135233;
				if (num != 0)
				{
				}
				num = (short)2085027840;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676.Value = value;
			}
		}

		// Token: 0x17003710 RID: 14096
		// (get) Token: 0x06006A4B RID: 27211 RVA: 0x005EFA98 File Offset: 0x005EDC98
		// (set) Token: 0x06006A4C RID: 27212 RVA: 0x005EFB4C File Offset: 0x005EDD4C
		public bool IntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676_Applicable
		{
			get
			{
				short num = (short)1461256192;
				short num2 = num;
				num = (short)1503976844;
				short num3 = num;
				num = (short)763682188;
				switch (num3 == num)
				{
				}
				num = (short)1679753217;
				if (num != 0)
				{
				}
				num = (short)142016512;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676.Applicable;
			}
			set
			{
				short num = (short)171900928;
				short num2 = num;
				num = (short)1372451557;
				short num3 = num;
				num = (short)1855845093;
				switch (num3 == num)
				{
				}
				num = (short)1528627201;
				if (num != 0)
				{
				}
				num = (short)1822556160;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676.Applicable = value;
			}
		}

		// Token: 0x17003711 RID: 14097
		// (get) Token: 0x06006A4D RID: 27213 RVA: 0x005EFC00 File Offset: 0x005EDE00
		// (set) Token: 0x06006A4E RID: 27214 RVA: 0x005EFCB4 File Offset: 0x005EDEB4
		public bool IntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676_Valid
		{
			get
			{
				short num = (short)326893568;
				short num2 = num;
				num = (short)95829547;
				short num3 = num;
				num = (short)1040989739;
				switch (num3 == num)
				{
				}
				num = (short)1404764160;
				if (num != 0)
				{
				}
				num = (short)1768423425;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676.Valid;
			}
			set
			{
				short num = (short)607191040;
				short num2 = num;
				num = (short)1033533361;
				short num3 = num;
				num = (short)1818916785;
				switch (num3 == num)
				{
				}
				num = (short)1921122305;
				if (num != 0)
				{
				}
				num = (short)1742733312;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676.Valid = value;
			}
		}

		// Token: 0x17003712 RID: 14098
		// (get) Token: 0x06006A4F RID: 27215 RVA: 0x005EFD68 File Offset: 0x005EDF68
		// (set) Token: 0x06006A50 RID: 27216 RVA: 0x005EFE1C File Offset: 0x005EE01C
		public bool IntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676_Visible
		{
			get
			{
				short num = (short)1825243136;
				short num2 = num;
				num = (short)160904006;
				short num3 = num;
				num = (short)1796944710;
				switch (num3 == num)
				{
				}
				num = (short)394264577;
				if (num != 0)
				{
				}
				num = (short)134283264;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676.Visible;
			}
			set
			{
				short num = (short)1194131456;
				short num2 = num;
				num = (short)198128559;
				short num3 = num;
				num = (short)1974088623;
				switch (num3 == num)
				{
				}
				num = (short)523763713;
				if (num != 0)
				{
				}
				num = (short)1197277184;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676.Visible = value;
			}
		}

		// Token: 0x17003713 RID: 14099
		// (get) Token: 0x06006A51 RID: 27217 RVA: 0x005EFED4 File Offset: 0x005EE0D4
		// (set) Token: 0x06006A52 RID: 27218 RVA: 0x005EFF88 File Offset: 0x005EE188
		public bool IntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676_Editable
		{
			get
			{
				short num = (short)1982136320;
				short num2 = num;
				num = (short)1222501319;
				short num3 = num;
				num = (short)1681056711;
				switch (num3 == num)
				{
				}
				num = (short)1613103105;
				if (num != 0)
				{
				}
				num = (short)894435328;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676.Editable;
			}
			set
			{
				short num = (short)1752104960;
				short num2 = num;
				num = (short)1986482473;
				short num3 = num;
				num = (short)567562537;
				switch (num3 == num)
				{
				}
				num = (short)1324613633;
				if (num != 0)
				{
				}
				num = (short)720896;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676.Editable = value;
			}
		}

		// Token: 0x17003714 RID: 14100
		// (get) Token: 0x06006A53 RID: 27219 RVA: 0x005F003C File Offset: 0x005EE23C
		internal string IntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676_UILabel
		{
			get
			{
				short num = (short)1173618688;
				short num2 = num;
				num = (short)629588938;
				short num3 = num;
				num = (short)1797112778;
				switch (num3 == num)
				{
				}
				num = (short)1094844417;
				if (num != 0)
				{
				}
				num = (short)1313538048;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676.UIName;
			}
		}

		// Token: 0x17003715 RID: 14101
		// (get) Token: 0x06006A54 RID: 27220 RVA: 0x005F00F0 File Offset: 0x005EE2F0
		// (set) Token: 0x06006A55 RID: 27221 RVA: 0x005F01A4 File Offset: 0x005EE3A4
		internal bool IntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676_HiddenStatic
		{
			get
			{
				short num = (short)2005467136;
				short num2 = num;
				num = (short)1689133226;
				short num3 = num;
				num = (short)730079402;
				switch (num3 == num)
				{
				}
				num = (short)58130432;
				if (num != 0)
				{
				}
				num = (short)1589182465;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676.HiddenStatic;
			}
			set
			{
				short num = (short)1968439296;
				short num2 = num;
				num = (short)551743552;
				short num3 = num;
				num = (short)1174859840;
				switch (num3 == num)
				{
				}
				num = (short)2039939073;
				if (num != 0)
				{
				}
				num = (short)1147404288;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676.HiddenStatic = value;
			}
		}

		// Token: 0x17003716 RID: 14102
		// (get) Token: 0x06006A56 RID: 27222 RVA: 0x005F0258 File Offset: 0x005EE458
		// (set) Token: 0x06006A57 RID: 27223 RVA: 0x005F030C File Offset: 0x005EE50C
		internal bool IntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676_HiddenDynamic
		{
			get
			{
				short num = (short)1981743104;
				short num2 = num;
				num = (short)1956773889;
				if (num != 0)
				{
				}
				num = (short)557702659;
				short num3 = num;
				num = (short)2114379267;
				switch (num3 == num)
				{
				}
				num = (short)225640448;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676.HiddenDynamic;
			}
			set
			{
				short num = (short)128581632;
				short num2 = num;
				num = (short)91022395;
				short num3 = num;
				num = (short)1546249275;
				switch (num3 == num)
				{
				}
				num = (short)810352640;
				if (num != 0)
				{
				}
				num = (short)493420545;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676.HiddenDynamic = value;
			}
		}

		// Token: 0x17003717 RID: 14103
		// (get) Token: 0x06006A58 RID: 27224 RVA: 0x005F03C4 File Offset: 0x005EE5C4
		public bool IntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676_HasDiffs
		{
			get
			{
				short num = (short)1871446016;
				short num2 = num;
				num = (short)1401648166;
				short num3 = num;
				num = (short)1799124006;
				switch (num3 == num)
				{
				}
				num = (short)1201537025;
				if (num != 0)
				{
				}
				num = (short)472055808;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676._HasDiffs;
			}
		}

		// Token: 0x17003718 RID: 14104
		// (get) Token: 0x06006A59 RID: 27225 RVA: 0x005F0478 File Offset: 0x005EE678
		// (set) Token: 0x06006A5A RID: 27226 RVA: 0x005F052C File Offset: 0x005EE72C
		public string IntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677Value
		{
			get
			{
				short num = (short)883687424;
				short num2 = num;
				num = (short)29194744;
				short num3 = num;
				num = (short)1094416888;
				switch (num3 == num)
				{
				}
				num = (short)731316225;
				if (num != 0)
				{
				}
				num = (short)1066991616;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677.Value;
			}
			set
			{
				short num = (short)49283072;
				short num2 = num;
				num = (short)1163407053;
				short num3 = num;
				num = (short)596913869;
				switch (num3 == num)
				{
				}
				num = (short)1711079425;
				if (num != 0)
				{
				}
				num = (short)1284505600;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677.Value = value;
			}
		}

		// Token: 0x17003719 RID: 14105
		// (get) Token: 0x06006A5B RID: 27227 RVA: 0x005F05E0 File Offset: 0x005EE7E0
		public global::AcpBusinessLayer.AcpField<string> IntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677
		{
			get
			{
				short num = (short)1915682816;
				short num2 = num;
				num = (short)1473064570;
				short num3 = num;
				num = (short)488451706;
				switch (num3 == num)
				{
				}
				num = (short)865599488;
				if (num != 0)
				{
				}
				num = (short)2014838785;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677;
			}
		}

		// Token: 0x1700371A RID: 14106
		// (get) Token: 0x06006A5C RID: 27228 RVA: 0x005F0690 File Offset: 0x005EE890
		// (set) Token: 0x06006A5D RID: 27229 RVA: 0x005F0748 File Offset: 0x005EE948
		public string IntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677_UIValue
		{
			get
			{
				short num = (short)1112997888;
				short num2 = num;
				num = (short)823913836;
				short num3 = num;
				num = (short)686681452;
				switch (num3 == num)
				{
				}
				num = (short)805044225;
				if (num != 0)
				{
				}
				num = (short)972816384;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677.Value;
			}
			set
			{
				short num = (short)1295056896;
				short num2 = num;
				num = (short)1416036353;
				if (num != 0)
				{
				}
				num = (short)2095890577;
				short num3 = num;
				num = (short)96845969;
				switch (num3 == num)
				{
				}
				num = (short)182845440;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677.Value = value;
			}
		}

		// Token: 0x1700371B RID: 14107
		// (get) Token: 0x06006A5E RID: 27230 RVA: 0x005F0800 File Offset: 0x005EEA00
		// (set) Token: 0x06006A5F RID: 27231 RVA: 0x005F08B4 File Offset: 0x005EEAB4
		public bool IntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677_Applicable
		{
			get
			{
				short num = (short)1226440704;
				short num2 = num;
				num = (short)725587060;
				short num3 = num;
				num = (short)1634374772;
				switch (num3 == num)
				{
				}
				num = (short)679149568;
				if (num != 0)
				{
				}
				num = (short)1998520321;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677.Applicable;
			}
			set
			{
				short num = (short)1293811712;
				short num2 = num;
				num = (short)1262612645;
				short num3 = num;
				num = (short)1099428005;
				switch (num3 == num)
				{
				}
				num = (short)768081920;
				if (num != 0)
				{
				}
				num = (short)1259077633;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677.Applicable = value;
			}
		}

		// Token: 0x1700371C RID: 14108
		// (get) Token: 0x06006A60 RID: 27232 RVA: 0x005F0968 File Offset: 0x005EEB68
		// (set) Token: 0x06006A61 RID: 27233 RVA: 0x005F0A1C File Offset: 0x005EEC1C
		public bool IntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677_Valid
		{
			get
			{
				short num = (short)164823040;
				short num2 = num;
				num = (short)552018052;
				short num3 = num;
				num = (short)1662328964;
				switch (num3 == num)
				{
				}
				num = (short)298909697;
				if (num != 0)
				{
				}
				num = (short)1970274304;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677.Valid;
			}
			set
			{
				short num = (short)2015887360;
				short num2 = num;
				num = (short)1294879167;
				short num3 = num;
				num = (short)1122912703;
				switch (num3 == num)
				{
				}
				num = (short)419692545;
				if (num != 0)
				{
				}
				num = (short)1779826688;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677.Valid = value;
			}
		}

		// Token: 0x1700371D RID: 14109
		// (get) Token: 0x06006A62 RID: 27234 RVA: 0x005F0AD0 File Offset: 0x005EECD0
		// (set) Token: 0x06006A63 RID: 27235 RVA: 0x005F0B84 File Offset: 0x005EED84
		public bool IntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677_Visible
		{
			get
			{
				short num = (short)480968704;
				short num2 = num;
				num = (short)995850366;
				short num3 = num;
				num = (short)2143844478;
				switch (num3 == num)
				{
				}
				num = (short)347799552;
				if (num != 0)
				{
				}
				num = (short)122945537;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677.Visible;
			}
			set
			{
				short num = (short)341311488;
				short num2 = num;
				num = (short)310796670;
				short num3 = num;
				num = (short)1209622910;
				switch (num3 == num)
				{
				}
				num = (short)1341128705;
				if (num != 0)
				{
				}
				num = (short)250478592;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677.Visible = value;
			}
		}

		// Token: 0x1700371E RID: 14110
		// (get) Token: 0x06006A64 RID: 27236 RVA: 0x005F0C3C File Offset: 0x005EEE3C
		// (set) Token: 0x06006A65 RID: 27237 RVA: 0x005F0CF0 File Offset: 0x005EEEF0
		public bool IntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677_Editable
		{
			get
			{
				short num = (short)117309440;
				short num2 = num;
				num = (short)516620289;
				if (num != 0)
				{
				}
				num = (short)1098978199;
				short num3 = num;
				num = (short)1702302615;
				switch (num3 == num)
				{
				}
				num = (short)1327300608;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677.Editable;
			}
			set
			{
				short num = (short)703594496;
				short num2 = num;
				num = (short)692136126;
				short num3 = num;
				num = (short)1491806398;
				switch (num3 == num)
				{
				}
				num = (short)951910401;
				if (num != 0)
				{
				}
				num = (short)1871839232;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677.Editable = value;
			}
		}

		// Token: 0x1700371F RID: 14111
		// (get) Token: 0x06006A66 RID: 27238 RVA: 0x005F0DA8 File Offset: 0x005EEFA8
		internal string IntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677_UILabel
		{
			get
			{
				short num = (short)1088290816;
				short num2 = num;
				num = (short)439746561;
				if (num != 0)
				{
				}
				num = (short)1655322855;
				short num3 = num;
				num = (short)228669671;
				switch (num3 == num)
				{
				}
				num = (short)2064515072;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677.UIName;
			}
		}

		// Token: 0x17003720 RID: 14112
		// (get) Token: 0x06006A67 RID: 27239 RVA: 0x005F0E5C File Offset: 0x005EF05C
		// (set) Token: 0x06006A68 RID: 27240 RVA: 0x005F0F10 File Offset: 0x005EF110
		internal bool IntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677_HiddenStatic
		{
			get
			{
				short num = (short)1907490816;
				short num2 = num;
				num = (short)1227482631;
				short num3 = num;
				num = (short)1296033287;
				switch (num3 == num)
				{
				}
				num = (short)897777665;
				if (num != 0)
				{
				}
				num = (short)1384972288;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677.HiddenStatic;
			}
			set
			{
				short num = (short)942211072;
				short num2 = num;
				num = (short)430833665;
				if (num != 0)
				{
				}
				num = (short)703229760;
				short num3 = num;
				num = (short)811822912;
				switch (num3 == num)
				{
				}
				num = (short)1968701440;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677.HiddenStatic = value;
			}
		}

		// Token: 0x17003721 RID: 14113
		// (get) Token: 0x06006A69 RID: 27241 RVA: 0x005F0FC4 File Offset: 0x005EF1C4
		// (set) Token: 0x06006A6A RID: 27242 RVA: 0x005F1078 File Offset: 0x005EF278
		internal bool IntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677_HiddenDynamic
		{
			get
			{
				short num = (short)970391552;
				short num2 = num;
				num = (short)1430664614;
				short num3 = num;
				num = (short)2032678310;
				switch (num3 == num)
				{
				}
				num = (short)555352065;
				if (num != 0)
				{
				}
				num = (short)1712586752;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677.HiddenDynamic;
			}
			set
			{
				short num = (short)993984512;
				short num2 = num;
				num = (short)515177093;
				short num3 = num;
				num = (short)857143941;
				switch (num3 == num)
				{
				}
				num = (short)843120641;
				if (num != 0)
				{
				}
				num = (short)1313538048;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677.HiddenDynamic = value;
			}
		}

		// Token: 0x17003722 RID: 14114
		// (get) Token: 0x06006A6B RID: 27243 RVA: 0x005F112C File Offset: 0x005EF32C
		public bool IntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677_HasDiffs
		{
			get
			{
				short num = (short)1914175488;
				short num2 = num;
				num = (short)800691591;
				short num3 = num;
				num = (short)846566791;
				switch (num3 == num)
				{
				}
				num = (short)1871118336;
				if (num != 0)
				{
				}
				num = (short)259260417;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677._HasDiffs;
			}
		}

		// Token: 0x17003723 RID: 14115
		// (get) Token: 0x06006A6C RID: 27244 RVA: 0x005F11E0 File Offset: 0x005EF3E0
		// (set) Token: 0x06006A6D RID: 27245 RVA: 0x005F1294 File Offset: 0x005EF494
		public string IntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678Value
		{
			get
			{
				short num = (short)2112618496;
				short num2 = num;
				num = (short)940243553;
				short num3 = num;
				num = (short)1680931425;
				switch (num3 == num)
				{
				}
				num = (short)670236672;
				if (num != 0)
				{
				}
				num = (short)1565589505;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678.Value;
			}
			set
			{
				short num = (short)1505755136;
				short num2 = num;
				num = (short)276165387;
				short num3 = num;
				num = (short)117371659;
				switch (num3 == num)
				{
				}
				num = (short)2086207489;
				if (num != 0)
				{
				}
				num = (short)1409024000;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678.Value = value;
			}
		}

		// Token: 0x17003724 RID: 14116
		// (get) Token: 0x06006A6E RID: 27246 RVA: 0x005F1348 File Offset: 0x005EF548
		public global::AcpBusinessLayer.AcpField<string> IntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678
		{
			get
			{
				short num = (short)1283260416;
				short num2 = num;
				num = (short)1719507209;
				short num3 = num;
				num = (short)1516017929;
				switch (num3 == num)
				{
				}
				num = (short)716439553;
				if (num != 0)
				{
				}
				num = (short)2024275968;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678;
			}
		}

		// Token: 0x17003725 RID: 14117
		// (get) Token: 0x06006A6F RID: 27247 RVA: 0x005F13FC File Offset: 0x005EF5FC
		// (set) Token: 0x06006A70 RID: 27248 RVA: 0x005F14B0 File Offset: 0x005EF6B0
		public string IntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678_UIValue
		{
			get
			{
				short num = (short)167968768;
				short num2 = num;
				num = (short)440729601;
				if (num != 0)
				{
				}
				num = (short)1102276641;
				short num3 = num;
				num = (short)502294561;
				switch (num3 == num)
				{
				}
				num = (short)851247104;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678.Value;
			}
			set
			{
				short num = (short)1034092544;
				short num2 = num;
				num = (short)2014055100;
				short num3 = num;
				num = (short)1954876092;
				switch (num3 == num)
				{
				}
				num = (short)1141243905;
				if (num != 0)
				{
				}
				num = (short)1943928832;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678.Value = value;
			}
		}

		// Token: 0x17003726 RID: 14118
		// (get) Token: 0x06006A71 RID: 27249 RVA: 0x005F1564 File Offset: 0x005EF764
		// (set) Token: 0x06006A72 RID: 27250 RVA: 0x005F161C File Offset: 0x005EF81C
		public bool IntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678_Applicable
		{
			get
			{
				short num = (short)431882240;
				short num2 = num;
				num = (short)745178069;
				short num3 = num;
				num = (short)2123203541;
				switch (num3 == num)
				{
				}
				num = (short)1841954817;
				if (num != 0)
				{
				}
				num = (short)1274675200;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678.Applicable;
			}
			set
			{
				short num = (short)1980235776;
				short num2 = num;
				num = (short)1020831783;
				short num3 = num;
				num = (short)979675175;
				switch (num3 == num)
				{
				}
				num = (short)770703360;
				if (num != 0)
				{
				}
				num = (short)66191361;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678.Applicable = value;
			}
		}

		// Token: 0x17003727 RID: 14119
		// (get) Token: 0x06006A73 RID: 27251 RVA: 0x005F16D0 File Offset: 0x005EF8D0
		// (set) Token: 0x06006A74 RID: 27252 RVA: 0x005F1784 File Offset: 0x005EF984
		public bool IntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678_Valid
		{
			get
			{
				short num = (short)280100864;
				short num2 = num;
				num = (short)1840356383;
				short num3 = num;
				num = (short)15375391;
				switch (num3 == num)
				{
				}
				num = (short)1988886528;
				if (num != 0)
				{
				}
				num = (short)530317313;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678.Valid;
			}
			set
			{
				short num = (short)476971008;
				short num2 = num;
				num = (short)1912012801;
				if (num != 0)
				{
				}
				num = (short)423781974;
				short num3 = num;
				num = (short)1971480150;
				switch (num3 == num)
				{
				}
				num = (short)2126839808;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678.Valid = value;
			}
		}

		// Token: 0x17003728 RID: 14120
		// (get) Token: 0x06006A75 RID: 27253 RVA: 0x005F183C File Offset: 0x005EFA3C
		// (set) Token: 0x06006A76 RID: 27254 RVA: 0x005F18F4 File Offset: 0x005EFAF4
		public bool IntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678_Visible
		{
			get
			{
				short num = (short)825884672;
				short num2 = num;
				num = (short)1619185745;
				short num3 = num;
				num = (short)1978060881;
				switch (num3 == num)
				{
				}
				num = (short)1093140481;
				if (num != 0)
				{
				}
				num = (short)1380777984;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678.Visible;
			}
			set
			{
				short num = (short)1519255552;
				short num2 = num;
				num = (short)1879638017;
				if (num != 0)
				{
				}
				num = (short)62378125;
				short num3 = num;
				num = (short)1991430285;
				switch (num3 == num)
				{
				}
				num = (short)1678770176;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678.Visible = value;
			}
		}

		// Token: 0x17003729 RID: 14121
		// (get) Token: 0x06006A77 RID: 27255 RVA: 0x005F19AC File Offset: 0x005EFBAC
		// (set) Token: 0x06006A78 RID: 27256 RVA: 0x005F1A60 File Offset: 0x005EFC60
		public bool IntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678_Editable
		{
			get
			{
				short num = (short)548208640;
				short num2 = num;
				num = (short)647051152;
				short num3 = num;
				num = (short)253638544;
				switch (num3 == num)
				{
				}
				num = (short)1383333889;
				if (num != 0)
				{
				}
				num = (short)1704394752;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678.Editable;
			}
			set
			{
				short num = (short)142489614;
				short num2 = num;
				num = (short)1719547918;
				switch (num2 == num)
				{
				}
				num = (short)1548419073;
				if (num != 0)
				{
				}
				num = (short)2077360128;
				short num3 = num;
				num = (short)53673984;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678.Editable = value;
			}
		}

		// Token: 0x1700372A RID: 14122
		// (get) Token: 0x06006A79 RID: 27257 RVA: 0x005F1B18 File Offset: 0x005EFD18
		internal string IntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678_UILabel
		{
			get
			{
				short num = (short)1199075286;
				short num2 = num;
				num = (short)886796246;
				switch (num2 == num)
				{
				}
				num = (short)1065418753;
				if (num != 0)
				{
				}
				num = (short)97189888;
				short num3 = num;
				num = (short)1524891648;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678.UIName;
			}
		}

		// Token: 0x1700372B RID: 14123
		// (get) Token: 0x06006A7A RID: 27258 RVA: 0x005F1BCC File Offset: 0x005EFDCC
		// (set) Token: 0x06006A7B RID: 27259 RVA: 0x005F1C80 File Offset: 0x005EFE80
		internal bool IntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678_HiddenStatic
		{
			get
			{
				short num = (short)381785704;
				short num2 = num;
				num = (short)1918670440;
				switch (num2 == num)
				{
				}
				num = (short)1280049153;
				if (num != 0)
				{
				}
				num = (short)1654521856;
				short num3 = num;
				num = (short)746782720;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678.HiddenStatic;
			}
			set
			{
				short num = (short)1267193206;
				short num2 = num;
				num = (short)1943655798;
				switch (num2 == num)
				{
				}
				num = (short)1281818624;
				if (num != 0)
				{
				}
				num = (short)1481375744;
				short num3 = num;
				num = (short)223281153;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678.HiddenStatic = value;
			}
		}

		// Token: 0x1700372C RID: 14124
		// (get) Token: 0x06006A7C RID: 27260 RVA: 0x005F1D38 File Offset: 0x005EFF38
		// (set) Token: 0x06006A7D RID: 27261 RVA: 0x005F1DEC File Offset: 0x005EFFEC
		internal bool IntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678_HiddenDynamic
		{
			get
			{
				short num = (short)843084598;
				short num2 = num;
				num = (short)1742631734;
				switch (num2 == num)
				{
				}
				num = (short)1244069889;
				if (num != 0)
				{
				}
				num = (short)1057554432;
				short num3 = num;
				num = (short)1855913984;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678.HiddenDynamic;
			}
			set
			{
				short num = (short)1936295283;
				short num2 = num;
				num = (short)258049395;
				switch (num2 == num)
				{
				}
				num = (short)270467072;
				if (num != 0)
				{
				}
				num = (short)1985740800;
				short num3 = num;
				num = (short)2108096513;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678.HiddenDynamic = value;
			}
		}

		// Token: 0x1700372D RID: 14125
		// (get) Token: 0x06006A7E RID: 27262 RVA: 0x005F1EA0 File Offset: 0x005F00A0
		public bool IntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678_HasDiffs
		{
			get
			{
				short num = (short)1420046843;
				short num2 = num;
				num = (short)1045180923;
				switch (num2 == num)
				{
				}
				num = (short)511311873;
				if (num != 0)
				{
				}
				num = (short)1379074048;
				short num3 = num;
				num = (short)229769216;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678._HasDiffs;
			}
		}

		// Token: 0x1700372E RID: 14126
		// (get) Token: 0x06006A7F RID: 27263 RVA: 0x005F1F58 File Offset: 0x005F0158
		// (set) Token: 0x06006A80 RID: 27264 RVA: 0x005F200C File Offset: 0x005F020C
		public int IntMicNsRdGenRADIOPASSFILTERSTART_42679Value
		{
			get
			{
				short num = (short)542082694;
				short num2 = num;
				num = (short)2006812294;
				switch (num2 == num)
				{
				}
				num = (short)1667825665;
				if (num != 0)
				{
				}
				num = (short)1941635072;
				short num3 = num;
				num = (short)985792512;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOPASSFILTERSTART_42679.Value;
			}
			set
			{
				short num = (short)82647605;
				short num2 = num;
				num = (short)203037237;
				switch (num2 == num)
				{
				}
				num = (short)968556545;
				if (num != 0)
				{
				}
				num = (short)740687872;
				short num3 = num;
				num = (short)1816788992;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOPASSFILTERSTART_42679.Value = value;
			}
		}

		// Token: 0x1700372F RID: 14127
		// (get) Token: 0x06006A81 RID: 27265 RVA: 0x005F20C4 File Offset: 0x005F02C4
		public global::AcpBusinessLayer.AcpSimpleRangeField IntMicNsRdGenRADIOPASSFILTERSTART_42679
		{
			get
			{
				short num = (short)1928487937;
				short num2 = num;
				num = (short)786654209;
				switch (num2 == num)
				{
				}
				num = (short)332136449;
				if (num != 0)
				{
				}
				num = (short)922615808;
				short num3 = num;
				num = (short)2051014656;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOPASSFILTERSTART_42679;
			}
		}

		// Token: 0x17003730 RID: 14128
		// (get) Token: 0x06006A82 RID: 27266 RVA: 0x005F2174 File Offset: 0x005F0374
		// (set) Token: 0x06006A83 RID: 27267 RVA: 0x005F222C File Offset: 0x005F042C
		public string IntMicNsRdGenRADIOPASSFILTERSTART_42679_UIValue
		{
			get
			{
				short num = (short)2021309704;
				short num2 = num;
				num = (short)1885912328;
				switch (num2 == num)
				{
				}
				num = (short)777453569;
				if (num != 0)
				{
				}
				num = (short)1668612096;
				short num3 = num;
				num = (short)2022703104;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOPASSFILTERSTART_42679.UIValue;
			}
			set
			{
				short num = (short)134785317;
				short num2 = num;
				num = (short)1636215077;
				switch (num2 == num)
				{
				}
				num = (short)747831297;
				if (num != 0)
				{
				}
				num = (short)575078400;
				short num3 = num;
				num = (short)1307443200;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOPASSFILTERSTART_42679.UIValue = value;
			}
		}

		// Token: 0x17003731 RID: 14129
		// (get) Token: 0x06006A84 RID: 27268 RVA: 0x005F22DC File Offset: 0x005F04DC
		// (set) Token: 0x06006A85 RID: 27269 RVA: 0x005F2390 File Offset: 0x005F0590
		internal int IntMicNsRdGenRADIOPASSFILTERSTART_42679Min
		{
			get
			{
				short num = (short)1249378305;
				if (num != 0)
				{
				}
				num = (short)67683757;
				short num2 = num;
				num = (short)1076610477;
				switch (num2 == num)
				{
				}
				num = (short)130285568;
				short num3 = num;
				num = (short)1983578112;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOPASSFILTERSTART_42679.Min;
			}
			set
			{
				short num = (short)1448154674;
				short num2 = num;
				num = (short)649598514;
				switch (num2 == num)
				{
				}
				num = (short)390922241;
				if (num != 0)
				{
				}
				num = (short)1342898176;
				short num3 = num;
				num = (short)1517158400;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOPASSFILTERSTART_42679.Min = value;
			}
		}

		// Token: 0x17003732 RID: 14130
		// (get) Token: 0x06006A86 RID: 27270 RVA: 0x005F2444 File Offset: 0x005F0644
		// (set) Token: 0x06006A87 RID: 27271 RVA: 0x005F24FC File Offset: 0x005F06FC
		internal int IntMicNsRdGenRADIOPASSFILTERSTART_42679Max
		{
			get
			{
				short num = (short)877985793;
				if (num != 0)
				{
				}
				num = (short)1843929006;
				short num2 = num;
				num = (short)539697070;
				switch (num2 == num)
				{
				}
				num = (short)564330496;
				short num3 = num;
				num = (short)330235904;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOPASSFILTERSTART_42679.Max;
			}
			set
			{
				short num = (short)1232210673;
				short num2 = num;
				num = (short)310577905;
				switch (num2 == num)
				{
				}
				num = (short)49283072;
				if (num != 0)
				{
				}
				num = (short)2118647808;
				short num3 = num;
				num = (short)1110769665;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOPASSFILTERSTART_42679.Max = value;
			}
		}

		// Token: 0x17003733 RID: 14131
		// (get) Token: 0x06006A88 RID: 27272 RVA: 0x005F25B0 File Offset: 0x005F07B0
		// (set) Token: 0x06006A89 RID: 27273 RVA: 0x005F2664 File Offset: 0x005F0864
		internal int IntMicNsRdGenRADIOPASSFILTERSTART_42679Step
		{
			get
			{
				short num = (short)1661053664;
				short num2 = num;
				num = (short)446081760;
				switch (num2 == num)
				{
				}
				num = (short)847446017;
				if (num != 0)
				{
				}
				num = (short)646184960;
				short num3 = num;
				num = (short)656277504;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOPASSFILTERSTART_42679.StepSize;
			}
			set
			{
				short num = (short)1173580578;
				short num2 = num;
				num = (short)282618658;
				switch (num2 == num)
				{
				}
				num = (short)199622656;
				if (num != 0)
				{
				}
				num = (short)1108279296;
				short num3 = num;
				num = (short)421724161;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOPASSFILTERSTART_42679.StepSize = value;
			}
		}

		// Token: 0x17003734 RID: 14132
		// (get) Token: 0x06006A8A RID: 27274 RVA: 0x005F2718 File Offset: 0x005F0918
		// (set) Token: 0x06006A8B RID: 27275 RVA: 0x005F27CC File Offset: 0x005F09CC
		public bool IntMicNsRdGenRADIOPASSFILTERSTART_42679_Applicable
		{
			get
			{
				short num = (short)1574589578;
				short num2 = num;
				num = (short)1194611850;
				switch (num2 == num)
				{
				}
				num = (short)1243545601;
				if (num != 0)
				{
				}
				num = (short)1181089792;
				short num3 = num;
				num = (short)2025521152;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOPASSFILTERSTART_42679.Applicable;
			}
			set
			{
				short num = (short)1418002433;
				if (num != 0)
				{
				}
				num = (short)974646019;
				short num2 = num;
				num = (short)682289923;
				switch (num2 == num)
				{
				}
				num = (short)853999616;
				short num3 = num;
				num = (short)1150681088;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOPASSFILTERSTART_42679.Applicable = value;
			}
		}

		// Token: 0x17003735 RID: 14133
		// (get) Token: 0x06006A8C RID: 27276 RVA: 0x005F2884 File Offset: 0x005F0A84
		// (set) Token: 0x06006A8D RID: 27277 RVA: 0x005F2938 File Offset: 0x005F0B38
		public bool IntMicNsRdGenRADIOPASSFILTERSTART_42679_Valid
		{
			get
			{
				short num = (short)2024863162;
				short num2 = num;
				num = (short)1054209466;
				switch (num2 == num)
				{
				}
				num = (short)1112801280;
				if (num != 0)
				{
				}
				num = (short)47513600;
				short num3 = num;
				num = (short)628228097;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOPASSFILTERSTART_42679.Valid;
			}
			set
			{
				short num = (short)1025788027;
				short num2 = num;
				num = (short)1365461115;
				switch (num2 == num)
				{
				}
				num = (short)1583742977;
				if (num != 0)
				{
				}
				num = (short)81461248;
				short num3 = num;
				num = (short)121110528;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOPASSFILTERSTART_42679.Valid = value;
			}
		}

		// Token: 0x17003736 RID: 14134
		// (get) Token: 0x06006A8E RID: 27278 RVA: 0x005F29F4 File Offset: 0x005F0BF4
		// (set) Token: 0x06006A8F RID: 27279 RVA: 0x005F2AA8 File Offset: 0x005F0CA8
		public bool IntMicNsRdGenRADIOPASSFILTERSTART_42679_Visible
		{
			get
			{
				short num = (short)1227620353;
				if (num != 0)
				{
				}
				num = (short)1367402969;
				short num2 = num;
				num = (short)527165913;
				switch (num2 == num)
				{
				}
				num = (short)1406074880;
				short num3 = num;
				num = (short)1033895936;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOPASSFILTERSTART_42679.Visible;
			}
			set
			{
				short num = (short)1541210113;
				if (num != 0)
				{
				}
				num = (short)2115535131;
				short num2 = num;
				num = (short)1002537243;
				switch (num2 == num)
				{
				}
				num = (short)293142528;
				short num3 = num;
				num = (short)1625948160;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOPASSFILTERSTART_42679.Visible = value;
			}
		}

		// Token: 0x17003737 RID: 14135
		// (get) Token: 0x06006A90 RID: 27280 RVA: 0x005F2B60 File Offset: 0x005F0D60
		// (set) Token: 0x06006A91 RID: 27281 RVA: 0x005F2C14 File Offset: 0x005F0E14
		public bool IntMicNsRdGenRADIOPASSFILTERSTART_42679_Editable
		{
			get
			{
				short num = (short)1563418863;
				short num2 = num;
				num = (short)2077417711;
				switch (num2 == num)
				{
				}
				num = (short)1157758976;
				if (num != 0)
				{
				}
				num = (short)11862016;
				short num3 = num;
				num = (short)2130575361;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOPASSFILTERSTART_42679.Editable;
			}
			set
			{
				short num = (short)1682163371;
				short num2 = num;
				num = (short)1760020139;
				switch (num2 == num)
				{
				}
				num = (short)1042677761;
				if (num != 0)
				{
				}
				num = (short)108593152;
				short num3 = num;
				num = (short)536215552;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOPASSFILTERSTART_42679.Editable = value;
			}
		}

		// Token: 0x17003738 RID: 14136
		// (get) Token: 0x06006A92 RID: 27282 RVA: 0x005F2CC8 File Offset: 0x005F0EC8
		internal string IntMicNsRdGenRADIOPASSFILTERSTART_42679_UILabel
		{
			get
			{
				short num = (short)927212478;
				short num2 = num;
				num = (short)1625695166;
				switch (num2 == num)
				{
				}
				num = (short)1226571776;
				if (num != 0)
				{
				}
				num = (short)1664155648;
				short num3 = num;
				num = (short)1881473025;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOPASSFILTERSTART_42679.UIName;
			}
		}

		// Token: 0x17003739 RID: 14137
		// (get) Token: 0x06006A93 RID: 27283 RVA: 0x005F2D7C File Offset: 0x005F0F7C
		// (set) Token: 0x06006A94 RID: 27284 RVA: 0x005F2E30 File Offset: 0x005F1030
		internal bool IntMicNsRdGenRADIOPASSFILTERSTART_42679_HiddenStatic
		{
			get
			{
				short num = (short)1173383575;
				short num2 = num;
				num = (short)766011799;
				switch (num2 == num)
				{
				}
				num = (short)252641280;
				if (num != 0)
				{
				}
				num = (short)1923284992;
				short num3 = num;
				num = (short)1362296833;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOPASSFILTERSTART_42679.HiddenStatic;
			}
			set
			{
				short num = (short)1067718761;
				short num2 = num;
				num = (short)2129401961;
				switch (num2 == num)
				{
				}
				num = (short)1643905025;
				if (num != 0)
				{
				}
				num = (short)2018312192;
				short num3 = num;
				num = (short)1735852032;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOPASSFILTERSTART_42679.HiddenStatic = value;
			}
		}

		// Token: 0x1700373A RID: 14138
		// (get) Token: 0x06006A95 RID: 27285 RVA: 0x005F2EE8 File Offset: 0x005F10E8
		// (set) Token: 0x06006A96 RID: 27286 RVA: 0x005F2FA0 File Offset: 0x005F11A0
		internal bool IntMicNsRdGenRADIOPASSFILTERSTART_42679_HiddenDynamic
		{
			get
			{
				short num = (short)1379139585;
				if (num != 0)
				{
				}
				num = (short)875493461;
				short num2 = num;
				num = (short)1359870037;
				switch (num2 == num)
				{
				}
				num = (short)909049856;
				short num3 = num;
				num = (short)913833984;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOPASSFILTERSTART_42679.HiddenDynamic;
			}
			set
			{
				short num = (short)994019919;
				short num2 = num;
				num = (short)1393199695;
				switch (num2 == num)
				{
				}
				num = (short)679084033;
				if (num != 0)
				{
				}
				num = (short)1592655872;
				short num3 = num;
				num = (short)1286012928;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOPASSFILTERSTART_42679.HiddenDynamic = value;
			}
		}

		// Token: 0x1700373B RID: 14139
		// (get) Token: 0x06006A97 RID: 27287 RVA: 0x005F3054 File Offset: 0x005F1254
		public bool IntMicNsRdGenRADIOPASSFILTERSTART_42679_HasDiffs
		{
			get
			{
				short num = (short)715477043;
				short num2 = num;
				num = (short)247287859;
				switch (num2 == num)
				{
				}
				num = (short)1477050369;
				if (num != 0)
				{
				}
				num = (short)879296512;
				short num3 = num;
				num = (short)1488257024;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOPASSFILTERSTART_42679._HasDiffs;
			}
		}

		// Token: 0x1700373C RID: 14140
		// (get) Token: 0x06006A98 RID: 27288 RVA: 0x005F310C File Offset: 0x005F130C
		// (set) Token: 0x06006A99 RID: 27289 RVA: 0x005F31C0 File Offset: 0x005F13C0
		public int IntMicNsRdGenRADIOSAMMIXMODE_42680Value
		{
			get
			{
				short num = (short)352680241;
				short num2 = num;
				num = (short)573995313;
				switch (num2 == num)
				{
				}
				num = (short)512491521;
				if (num != 0)
				{
				}
				num = (short)1755840512;
				short num3 = num;
				num = (short)1669791744;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMMIXMODE_42680.Value;
			}
			set
			{
				short num = (short)370688237;
				short num2 = num;
				num = (short)1127104749;
				switch (num2 == num)
				{
				}
				num = (short)142147585;
				if (num != 0)
				{
				}
				num = (short)186908672;
				short num3 = num;
				num = (short)508624896;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOSAMMIXMODE_42680.Value = value;
			}
		}

		// Token: 0x1700373D RID: 14141
		// (get) Token: 0x06006A9A RID: 27290 RVA: 0x005F3274 File Offset: 0x005F1474
		public global::AcpBusinessLayer.AcpSimpleRangeField IntMicNsRdGenRADIOSAMMIXMODE_42680
		{
			get
			{
				short num = (short)1376135536;
				short num2 = num;
				num = (short)1715087728;
				switch (num2 == num)
				{
				}
				num = (short)2023292929;
				if (num != 0)
				{
				}
				num = (short)1069088768;
				short num3 = num;
				num = (short)1116143616;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMMIXMODE_42680;
			}
		}

		// Token: 0x1700373E RID: 14142
		// (get) Token: 0x06006A9B RID: 27291 RVA: 0x005F3324 File Offset: 0x005F1524
		// (set) Token: 0x06006A9C RID: 27292 RVA: 0x005F33DC File Offset: 0x005F15DC
		public string IntMicNsRdGenRADIOSAMMIXMODE_42680_UIValue
		{
			get
			{
				short num = (short)1790157761;
				short num2 = num;
				num = (short)98214849;
				switch (num2 == num)
				{
				}
				num = (short)33685505;
				if (num != 0)
				{
				}
				num = (short)325451776;
				short num3 = num;
				num = (short)769327104;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMMIXMODE_42680.UIValue;
			}
			set
			{
				short num = (short)1634308694;
				short num2 = num;
				num = (short)1017418326;
				switch (num2 == num)
				{
				}
				num = (short)1698955264;
				if (num != 0)
				{
				}
				num = (short)1202847744;
				short num3 = num;
				num = (short)609615873;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOSAMMIXMODE_42680.UIValue = value;
			}
		}

		// Token: 0x1700373F RID: 14143
		// (get) Token: 0x06006A9D RID: 27293 RVA: 0x005F3494 File Offset: 0x005F1694
		// (set) Token: 0x06006A9E RID: 27294 RVA: 0x005F3548 File Offset: 0x005F1748
		internal int IntMicNsRdGenRADIOSAMMIXMODE_42680Min
		{
			get
			{
				short num = (short)1409180529;
				short num2 = num;
				num = (short)410805105;
				switch (num2 == num)
				{
				}
				num = (short)2091778049;
				if (num != 0)
				{
				}
				num = (short)1211760640;
				short num3 = num;
				num = (short)708837376;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMMIXMODE_42680.Min;
			}
			set
			{
				short num = (short)1934258896;
				short num2 = num;
				num = (short)468415184;
				switch (num2 == num)
				{
				}
				num = (short)1315569665;
				if (num != 0)
				{
				}
				num = (short)1884880896;
				short num3 = num;
				num = (short)974323712;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOSAMMIXMODE_42680.Min = value;
			}
		}

		// Token: 0x17003740 RID: 14144
		// (get) Token: 0x06006A9F RID: 27295 RVA: 0x005F3600 File Offset: 0x005F1800
		// (set) Token: 0x06006AA0 RID: 27296 RVA: 0x005F36B4 File Offset: 0x005F18B4
		internal int IntMicNsRdGenRADIOSAMMIXMODE_42680Max
		{
			get
			{
				short num = (short)70052301;
				short num2 = num;
				num = (short)1382017485;
				switch (num2 == num)
				{
				}
				num = (short)1948909569;
				if (num != 0)
				{
				}
				num = (short)1886060544;
				short num3 = num;
				num = (short)1441464320;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMMIXMODE_42680.Max;
			}
			set
			{
				short num = (short)545587201;
				if (num != 0)
				{
				}
				num = (short)336069547;
				short num2 = num;
				num = (short)972555179;
				switch (num2 == num)
				{
				}
				num = (short)1167261696;
				short num3 = num;
				num = (short)361955328;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOSAMMIXMODE_42680.Max = value;
			}
		}

		// Token: 0x17003741 RID: 14145
		// (get) Token: 0x06006AA1 RID: 27297 RVA: 0x005F3768 File Offset: 0x005F1968
		// (set) Token: 0x06006AA2 RID: 27298 RVA: 0x005F381C File Offset: 0x005F1A1C
		internal int IntMicNsRdGenRADIOSAMMIXMODE_42680Step
		{
			get
			{
				short num = (short)411202558;
				short num2 = num;
				num = (short)1009218558;
				switch (num2 == num)
				{
				}
				num = (short)1379991552;
				if (num != 0)
				{
				}
				num = (short)1572995072;
				short num3 = num;
				num = (short)631439361;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMMIXMODE_42680.StepSize;
			}
			set
			{
				short num = (short)1455913810;
				short num2 = num;
				num = (short)2137946962;
				switch (num2 == num)
				{
				}
				num = (short)1059717121;
				if (num != 0)
				{
				}
				num = (short)1513160704;
				short num3 = num;
				num = (short)2060451840;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOSAMMIXMODE_42680.StepSize = value;
			}
		}

		// Token: 0x17003742 RID: 14146
		// (get) Token: 0x06006AA3 RID: 27299 RVA: 0x005F38D0 File Offset: 0x005F1AD0
		// (set) Token: 0x06006AA4 RID: 27300 RVA: 0x005F3984 File Offset: 0x005F1B84
		public bool IntMicNsRdGenRADIOSAMMIXMODE_42680_Applicable
		{
			get
			{
				short num = (short)320706143;
				short num2 = num;
				num = (short)555849311;
				switch (num2 == num)
				{
				}
				num = (short)468910081;
				if (num != 0)
				{
				}
				num = (short)384958464;
				short num3 = num;
				num = (short)1326448640;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMMIXMODE_42680.Applicable;
			}
			set
			{
				short num = (short)600978947;
				short num2 = num;
				num = (short)1011103235;
				switch (num2 == num)
				{
				}
				num = (short)101842945;
				if (num != 0)
				{
				}
				num = (short)1342242816;
				short num3 = num;
				num = (short)573374464;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOSAMMIXMODE_42680.Applicable = value;
			}
		}

		// Token: 0x17003743 RID: 14147
		// (get) Token: 0x06006AA5 RID: 27301 RVA: 0x005F3A3C File Offset: 0x005F1C3C
		// (set) Token: 0x06006AA6 RID: 27302 RVA: 0x005F3AF4 File Offset: 0x005F1CF4
		public bool IntMicNsRdGenRADIOSAMMIXMODE_42680_Valid
		{
			get
			{
				short num = (short)163114980;
				short num2 = num;
				num = (short)796913636;
				switch (num2 == num)
				{
				}
				num = (short)1714159617;
				if (num != 0)
				{
				}
				num = (short)497156096;
				short num3 = num;
				num = (short)682098688;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMMIXMODE_42680.Valid;
			}
			set
			{
				short num = (short)65839732;
				short num2 = num;
				num = (short)378970740;
				switch (num2 == num)
				{
				}
				num = (short)1712062464;
				if (num != 0)
				{
				}
				num = (short)1044840448;
				short num3 = num;
				num = (short)1894187009;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOSAMMIXMODE_42680.Valid = value;
			}
		}

		// Token: 0x17003744 RID: 14148
		// (get) Token: 0x06006AA7 RID: 27303 RVA: 0x005F3BA8 File Offset: 0x005F1DA8
		// (set) Token: 0x06006AA8 RID: 27304 RVA: 0x005F3C5C File Offset: 0x005F1E5C
		public bool IntMicNsRdGenRADIOSAMMIXMODE_42680_Visible
		{
			get
			{
				short num = (short)90895497;
				short num2 = num;
				num = (short)2054354057;
				switch (num2 == num)
				{
				}
				num = (short)94699521;
				if (num != 0)
				{
				}
				num = (short)2002321408;
				short num3 = num;
				num = (short)1464336384;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMMIXMODE_42680.Visible;
			}
			set
			{
				short num = (short)1694786598;
				short num2 = num;
				num = (short)321479718;
				switch (num2 == num)
				{
				}
				num = (short)1399259137;
				if (num != 0)
				{
				}
				num = (short)887095296;
				short num3 = num;
				num = (short)994770944;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOSAMMIXMODE_42680.Visible = value;
			}
		}

		// Token: 0x17003745 RID: 14149
		// (get) Token: 0x06006AA9 RID: 27305 RVA: 0x005F3D10 File Offset: 0x005F1F10
		// (set) Token: 0x06006AAA RID: 27306 RVA: 0x005F3DC8 File Offset: 0x005F1FC8
		public bool IntMicNsRdGenRADIOSAMMIXMODE_42680_Editable
		{
			get
			{
				short num = (short)859217206;
				short num2 = num;
				num = (short)1657183542;
				switch (num2 == num)
				{
				}
				num = (short)722272256;
				if (num != 0)
				{
				}
				num = (short)1667563520;
				short num3 = num;
				num = (short)718798849;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMMIXMODE_42680.Editable;
			}
			set
			{
				short num = (short)549450047;
				short num2 = num;
				num = (short)1186394431;
				switch (num2 == num)
				{
				}
				num = (short)1130364929;
				if (num != 0)
				{
				}
				num = (short)62586880;
				short num3 = num;
				num = (short)162398208;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOSAMMIXMODE_42680.Editable = value;
			}
		}

		// Token: 0x17003746 RID: 14150
		// (get) Token: 0x06006AAB RID: 27307 RVA: 0x005F3E80 File Offset: 0x005F2080
		internal string IntMicNsRdGenRADIOSAMMIXMODE_42680_UILabel
		{
			get
			{
				short num = (short)2020670260;
				short num2 = num;
				num = (short)1692072756;
				switch (num2 == num)
				{
				}
				num = (short)1676083201;
				if (num != 0)
				{
				}
				num = (short)1880752128;
				short num3 = num;
				num = (short)980287488;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMMIXMODE_42680.UIName;
			}
		}

		// Token: 0x17003747 RID: 14151
		// (get) Token: 0x06006AAC RID: 27308 RVA: 0x005F3F38 File Offset: 0x005F2138
		// (set) Token: 0x06006AAD RID: 27309 RVA: 0x005F3FEC File Offset: 0x005F21EC
		internal bool IntMicNsRdGenRADIOSAMMIXMODE_42680_HiddenStatic
		{
			get
			{
				short num = (short)1159166919;
				short num2 = num;
				num = (short)129661895;
				switch (num2 == num)
				{
				}
				num = (short)816840705;
				if (num != 0)
				{
				}
				num = (short)1955135488;
				short num3 = num;
				num = (short)1567031296;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMMIXMODE_42680.HiddenStatic;
			}
			set
			{
				short num = (short)1811152897;
				if (num != 0)
				{
				}
				num = (short)737600906;
				short num2 = num;
				num = (short)1807410570;
				switch (num2 == num)
				{
				}
				num = (short)23592960;
				short num3 = num;
				num = (short)1301676032;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOSAMMIXMODE_42680.HiddenStatic = value;
			}
		}

		// Token: 0x17003748 RID: 14152
		// (get) Token: 0x06006AAE RID: 27310 RVA: 0x005F40A4 File Offset: 0x005F22A4
		// (set) Token: 0x06006AAF RID: 27311 RVA: 0x005F415C File Offset: 0x005F235C
		internal bool IntMicNsRdGenRADIOSAMMIXMODE_42680_HiddenDynamic
		{
			get
			{
				short num = (short)855196117;
				short num2 = num;
				num = (short)254427605;
				switch (num2 == num)
				{
				}
				num = (short)1733689345;
				if (num != 0)
				{
				}
				num = (short)553844736;
				short num3 = num;
				num = (short)455409664;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMMIXMODE_42680.HiddenDynamic;
			}
			set
			{
				short num = (short)52297729;
				if (num != 0)
				{
				}
				num = (short)1927016338;
				short num2 = num;
				num = (short)1596977042;
				switch (num2 == num)
				{
				}
				num = (short)529727488;
				short num3 = num;
				num = (short)276168704;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOSAMMIXMODE_42680.HiddenDynamic = value;
			}
		}

		// Token: 0x17003749 RID: 14153
		// (get) Token: 0x06006AB0 RID: 27312 RVA: 0x005F4210 File Offset: 0x005F2410
		public bool IntMicNsRdGenRADIOSAMMIXMODE_42680_HasDiffs
		{
			get
			{
				short num = (short)622822908;
				short num2 = num;
				num = (short)1216382460;
				switch (num2 == num)
				{
				}
				num = (short)1159397377;
				if (num != 0)
				{
				}
				num = (short)2059010048;
				short num3 = num;
				num = (short)1591476224;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMMIXMODE_42680._HasDiffs;
			}
		}

		// Token: 0x1700374A RID: 14154
		// (get) Token: 0x06006AB1 RID: 27313 RVA: 0x005F42C8 File Offset: 0x005F24C8
		// (set) Token: 0x06006AB2 RID: 27314 RVA: 0x005F437C File Offset: 0x005F257C
		public int IntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681Value
		{
			get
			{
				short num = (short)1379603788;
				short num2 = num;
				num = (short)1929975116;
				switch (num2 == num)
				{
				}
				num = (short)1206779905;
				if (num != 0)
				{
				}
				num = (short)1372979200;
				short num3 = num;
				num = (short)490930176;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.Value;
			}
			set
			{
				short num = (short)633009287;
				short num2 = num;
				num = (short)1973875847;
				switch (num2 == num)
				{
				}
				num = (short)1738407936;
				if (num != 0)
				{
				}
				num = (short)2093940736;
				short num3 = num;
				num = (short)1200029697;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.Value = value;
			}
		}

		// Token: 0x1700374B RID: 14155
		// (get) Token: 0x06006AB3 RID: 27315 RVA: 0x005F4434 File Offset: 0x005F2634
		public global::AcpBusinessLayer.AcpSimpleRangeField IntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681
		{
			get
			{
				short num = (short)1476373642;
				short num2 = num;
				num = (short)2127080586;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1854603264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)90832897;
				if (num != 0)
				{
				}
				num = (short)895156224;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681;
			}
		}

		// Token: 0x1700374C RID: 14156
		// (get) Token: 0x06006AB4 RID: 27316 RVA: 0x005F44E4 File Offset: 0x005F26E4
		// (set) Token: 0x06006AB5 RID: 27317 RVA: 0x005F4598 File Offset: 0x005F2798
		public string IntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681_UIValue
		{
			get
			{
				short num = (short)1503879604;
				short num2 = num;
				num = (short)1847878068;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1124532224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1417478144;
				if (num != 0)
				{
				}
				num = (short)1635909633;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.UIValue;
			}
			set
			{
				short num = (short)1347274852;
				short num2 = num;
				num = (short)1128712292;
				switch (num2 == num)
				{
				default:
				{
					num = (short)347996160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)863305729;
				if (num != 0)
				{
				}
				num = (short)2121334784;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.UIValue = value;
			}
		}

		// Token: 0x1700374D RID: 14157
		// (get) Token: 0x06006AB6 RID: 27318 RVA: 0x005F4650 File Offset: 0x005F2850
		// (set) Token: 0x06006AB7 RID: 27319 RVA: 0x005F4704 File Offset: 0x005F2904
		internal int IntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681Min
		{
			get
			{
				short num = (short)702967324;
				short num2 = num;
				num = (short)1773628956;
				switch (num2 == num)
				{
				default:
				{
					num = (short)919928832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2138243073;
				if (num != 0)
				{
				}
				num = (short)810811392;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.Min;
			}
			set
			{
				short num = (short)184426975;
				short num2 = num;
				num = (short)1722622431;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1642725376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2061565953;
				if (num != 0)
				{
				}
				num = (short)1795489792;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.Min = value;
			}
		}

		// Token: 0x1700374E RID: 14158
		// (get) Token: 0x06006AB8 RID: 27320 RVA: 0x005F47B8 File Offset: 0x005F29B8
		// (set) Token: 0x06006AB9 RID: 27321 RVA: 0x005F486C File Offset: 0x005F2A6C
		internal int IntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681Max
		{
			get
			{
				short num = (short)650434994;
				short num2 = num;
				num = (short)210295218;
				switch (num2 == num)
				{
				default:
				{
					num = (short)233897984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1845821440;
				if (num != 0)
				{
				}
				num = (short)1173946369;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.Max;
			}
			set
			{
				short num = (short)283929812;
				short num2 = num;
				num = (short)2112253140;
				switch (num2 == num)
				{
				default:
				{
					num = (short)564658176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1781465089;
				if (num != 0)
				{
				}
				num = (short)461373440;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.Max = value;
			}
		}

		// Token: 0x1700374F RID: 14159
		// (get) Token: 0x06006ABA RID: 27322 RVA: 0x005F4920 File Offset: 0x005F2B20
		// (set) Token: 0x06006ABB RID: 27323 RVA: 0x005F49D8 File Offset: 0x005F2BD8
		internal int IntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681Step
		{
			get
			{
				short num = (short)2004824051;
				short num2 = num;
				num = (short)968372211;
				switch (num2 == num)
				{
				default:
				{
					num = (short)871628800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1254490112;
				if (num != 0)
				{
				}
				num = (short)1095434241;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.StepSize;
			}
			set
			{
				short num = (short)877233343;
				short num2 = num;
				num = (short)1414694079;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1805844480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)968818689;
				if (num != 0)
				{
				}
				num = (short)2062745600;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.StepSize = value;
			}
		}

		// Token: 0x17003750 RID: 14160
		// (get) Token: 0x06006ABC RID: 27324 RVA: 0x005F4A8C File Offset: 0x005F2C8C
		// (set) Token: 0x06006ABD RID: 27325 RVA: 0x005F4B40 File Offset: 0x005F2D40
		public bool IntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681_Applicable
		{
			get
			{
				short num = (short)1320091649;
				if (num != 0)
				{
				}
				num = (short)143917056;
				short num2 = num;
				num = (short)1386474690;
				short num3 = num;
				num = (short)1676078274;
				switch (num3 == num)
				{
				}
				num = (short)255393792;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.Applicable;
			}
			set
			{
				short num = (short)1803975661;
				short num2 = num;
				num = (short)1012104173;
				switch (num2 == num)
				{
				default:
				{
					num = (short)514457600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1602879489;
				if (num != 0)
				{
				}
				num = (short)591331328;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.Applicable = value;
			}
		}

		// Token: 0x17003751 RID: 14161
		// (get) Token: 0x06006ABE RID: 27326 RVA: 0x005F4BF4 File Offset: 0x005F2DF4
		// (set) Token: 0x06006ABF RID: 27327 RVA: 0x005F4CAC File Offset: 0x005F2EAC
		public bool IntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681_Valid
		{
			get
			{
				short num = (short)1193345025;
				if (num != 0)
				{
				}
				num = (short)1678245888;
				short num2 = num;
				num = (short)1226537115;
				short num3 = num;
				num = (short)363886747;
				switch (num3 == num)
				{
				}
				num = (short)1961754624;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.Valid;
			}
			set
			{
				short num = (short)2032093038;
				short num2 = num;
				num = (short)1787971438;
				switch (num2 == num)
				{
				default:
				{
					num = (short)596770816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1985478657;
				if (num != 0)
				{
				}
				num = (short)1675165696;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.Valid = value;
			}
		}

		// Token: 0x17003752 RID: 14162
		// (get) Token: 0x06006AC0 RID: 27328 RVA: 0x005F4D60 File Offset: 0x005F2F60
		// (set) Token: 0x06006AC1 RID: 27329 RVA: 0x005F4E18 File Offset: 0x005F3018
		public bool IntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681_Visible
		{
			get
			{
				short num = (short)351666177;
				if (num != 0)
				{
				}
				num = (short)1131413504;
				short num2 = num;
				num = (short)1443362897;
				short num3 = num;
				num = (short)1384511569;
				switch (num3 == num)
				{
				}
				num = (short)2017263616;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.Visible;
			}
			set
			{
				short num = (short)517106364;
				short num2 = num;
				num = (short)249916092;
				switch (num2 == num)
				{
				default:
				{
					num = (short)671219712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1408172032;
				if (num != 0)
				{
				}
				num = (short)1597177857;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.Visible = value;
			}
		}

		// Token: 0x17003753 RID: 14163
		// (get) Token: 0x06006AC2 RID: 27330 RVA: 0x005F4ED0 File Offset: 0x005F30D0
		// (set) Token: 0x06006AC3 RID: 27331 RVA: 0x005F4F84 File Offset: 0x005F3184
		public bool IntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681_Editable
		{
			get
			{
				short num = (short)1182269441;
				if (num != 0)
				{
				}
				num = (short)869924864;
				short num2 = num;
				num = (short)214493016;
				short num3 = num;
				num = (short)1887430488;
				switch (num3 == num)
				{
				}
				num = (short)932511744;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.Editable;
			}
			set
			{
				short num = (short)2131788219;
				short num2 = num;
				num = (short)632193467;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2105802752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)582746112;
				if (num != 0)
				{
				}
				num = (short)1522335745;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.Editable = value;
			}
		}

		// Token: 0x17003754 RID: 14164
		// (get) Token: 0x06006AC4 RID: 27332 RVA: 0x005F503C File Offset: 0x005F323C
		internal string IntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681_UILabel
		{
			get
			{
				short num = (short)471059752;
				short num2 = num;
				num = (short)1027001640;
				switch (num2 == num)
				{
				default:
				{
					num = (short)876347392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2114781184;
				if (num != 0)
				{
				}
				num = (short)448004097;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.UIName;
			}
		}

		// Token: 0x17003755 RID: 14165
		// (get) Token: 0x06006AC5 RID: 27333 RVA: 0x005F50EC File Offset: 0x005F32EC
		// (set) Token: 0x06006AC6 RID: 27334 RVA: 0x005F51A0 File Offset: 0x005F33A0
		internal bool IntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681_HiddenStatic
		{
			get
			{
				short num = (short)1067930490;
				short num2 = num;
				num = (short)668095354;
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
				num = (short)913375233;
				if (num != 0)
				{
				}
				num = (short)1747714048;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.HiddenStatic;
			}
			set
			{
				short num = (short)1927432983;
				short num2 = num;
				num = (short)923814679;
				switch (num2 == num)
				{
				default:
				{
					num = (short)889847808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)682360833;
				if (num != 0)
				{
				}
				num = (short)660733952;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.HiddenStatic = value;
			}
		}

		// Token: 0x17003756 RID: 14166
		// (get) Token: 0x06006AC7 RID: 27335 RVA: 0x005F5254 File Offset: 0x005F3454
		// (set) Token: 0x06006AC8 RID: 27336 RVA: 0x005F5308 File Offset: 0x005F3508
		internal bool IntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681_HiddenDynamic
		{
			get
			{
				short num = (short)444723466;
				short num2 = num;
				num = (short)1520431370;
				switch (num2 == num)
				{
				default:
				{
					num = (short)435224576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)129957889;
				if (num != 0)
				{
				}
				num = (short)1448280064;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.HiddenDynamic;
			}
			set
			{
				short num = (short)956048439;
				short num2 = num;
				num = (short)774775863;
				switch (num2 == num)
				{
				default:
				{
					num = (short)827981824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)997195777;
				if (num != 0)
				{
				}
				num = (short)1385693184;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681.HiddenDynamic = value;
			}
		}

		// Token: 0x17003757 RID: 14167
		// (get) Token: 0x06006AC9 RID: 27337 RVA: 0x005F53BC File Offset: 0x005F35BC
		public bool IntMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681_HasDiffs
		{
			get
			{
				short num = (short)766521141;
				short num2 = num;
				num = (short)172240693;
				switch (num2 == num)
				{
				default:
				{
					num = (short)429326336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)905969665;
				if (num != 0)
				{
				}
				num = (short)968228864;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681._HasDiffs;
			}
		}

		// Token: 0x17003758 RID: 14168
		// (get) Token: 0x06006ACA RID: 27338 RVA: 0x005F5474 File Offset: 0x005F3674
		// (set) Token: 0x06006ACB RID: 27339 RVA: 0x005F552C File Offset: 0x005F372C
		public int IntMicNsRdGenRADIOHOTBEAMMIXRATE_42682Value
		{
			get
			{
				short num = (short)90506609;
				short num2 = num;
				num = (short)1079575921;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1495203840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1435369473;
				if (num != 0)
				{
				}
				num = (short)614334464;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.Value;
			}
			set
			{
				short num = (short)1231911731;
				short num2 = num;
				num = (short)1908243251;
				switch (num2 == num)
				{
				default:
				{
					num = (short)606273536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)297336833;
				if (num != 0)
				{
				}
				num = (short)948109312;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.Value = value;
			}
		}

		// Token: 0x17003759 RID: 14169
		// (get) Token: 0x06006ACC RID: 27340 RVA: 0x005F55E8 File Offset: 0x005F37E8
		public global::AcpBusinessLayer.AcpSimpleRangeField IntMicNsRdGenRADIOHOTBEAMMIXRATE_42682
		{
			get
			{
				short num = (short)941360918;
				short num2 = num;
				num = (short)2090731286;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1386676224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)182648833;
				if (num != 0)
				{
				}
				num = (short)1537146880;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682;
			}
		}

		// Token: 0x1700375A RID: 14170
		// (get) Token: 0x06006ACD RID: 27341 RVA: 0x005F5698 File Offset: 0x005F3898
		// (set) Token: 0x06006ACE RID: 27342 RVA: 0x005F574C File Offset: 0x005F394C
		public string IntMicNsRdGenRADIOHOTBEAMMIXRATE_42682_UIValue
		{
			get
			{
				short num = (short)385912602;
				short num2 = num;
				num = (short)1179946778;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1690435584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1505296385;
				if (num != 0)
				{
				}
				num = (short)1954938880;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.UIValue;
			}
			set
			{
				short num = (short)496041985;
				if (num != 0)
				{
				}
				num = (short)755236864;
				short num2 = num;
				num = (short)934401131;
				short num3 = num;
				num = (short)1716835435;
				switch (num3 == num)
				{
				}
				num = (short)299827200;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.UIValue = value;
			}
		}

		// Token: 0x1700375B RID: 14171
		// (get) Token: 0x06006ACF RID: 27343 RVA: 0x005F5804 File Offset: 0x005F3A04
		// (set) Token: 0x06006AD0 RID: 27344 RVA: 0x005F58B8 File Offset: 0x005F3AB8
		internal int IntMicNsRdGenRADIOHOTBEAMMIXRATE_42682Min
		{
			get
			{
				short num = (short)1766036391;
				short num2 = num;
				num = (short)746492839;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2040070144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)533331969;
				if (num != 0)
				{
				}
				num = (short)1444347904;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.Min;
			}
			set
			{
				short num = (short)1449393944;
				short num2 = num;
				num = (short)1049624344;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1373241344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1102249985;
				if (num != 0)
				{
				}
				num = (short)742785024;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.Min = value;
			}
		}

		// Token: 0x1700375C RID: 14172
		// (get) Token: 0x06006AD1 RID: 27345 RVA: 0x005F596C File Offset: 0x005F3B6C
		// (set) Token: 0x06006AD2 RID: 27346 RVA: 0x005F5A20 File Offset: 0x005F3C20
		internal int IntMicNsRdGenRADIOHOTBEAMMIXRATE_42682Max
		{
			get
			{
				short num = (short)626604509;
				short num2 = num;
				num = (short)2084649437;
				switch (num2 == num)
				{
				default:
				{
					num = (short)221511680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)506658817;
				if (num != 0)
				{
				}
				num = (short)313065472;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.Max;
			}
			set
			{
				short num = (short)1998724548;
				short num2 = num;
				num = (short)322510276;
				switch (num2 == num)
				{
				default:
				{
					num = (short)12058624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1577320449;
				if (num != 0)
				{
				}
				num = (short)1437728768;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.Max = value;
			}
		}

		// Token: 0x1700375D RID: 14173
		// (get) Token: 0x06006AD3 RID: 27347 RVA: 0x005F5AD8 File Offset: 0x005F3CD8
		// (set) Token: 0x06006AD4 RID: 27348 RVA: 0x005F5B90 File Offset: 0x005F3D90
		internal int IntMicNsRdGenRADIOHOTBEAMMIXRATE_42682Step
		{
			get
			{
				short num = (short)375946505;
				short num2 = num;
				num = (short)1752792329;
				switch (num2 == num)
				{
				default:
				{
					num = (short)234946560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)389873665;
				if (num != 0)
				{
				}
				num = (short)2122514432;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.StepSize;
			}
			set
			{
				short num = (short)628911850;
				short num2 = num;
				num = (short)1899851498;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2119172096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)213057537;
				if (num != 0)
				{
				}
				num = (short)1400897536;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.StepSize = value;
			}
		}

		// Token: 0x1700375E RID: 14174
		// (get) Token: 0x06006AD5 RID: 27349 RVA: 0x005F5C44 File Offset: 0x005F3E44
		// (set) Token: 0x06006AD6 RID: 27350 RVA: 0x005F5CF8 File Offset: 0x005F3EF8
		public bool IntMicNsRdGenRADIOHOTBEAMMIXRATE_42682_Applicable
		{
			get
			{
				short num = (short)407619142;
				short num2 = num;
				num = (short)245876294;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2140209152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1810432001;
				if (num != 0)
				{
				}
				num = (short)523304960;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.Applicable;
			}
			set
			{
				short num = (short)1475446808;
				short num2 = num;
				num = (short)27691032;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1777467392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1337589761;
				if (num != 0)
				{
				}
				num = (short)710344704;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.Applicable = value;
			}
		}

		// Token: 0x1700375F RID: 14175
		// (get) Token: 0x06006AD7 RID: 27351 RVA: 0x005F5DB4 File Offset: 0x005F3FB4
		// (set) Token: 0x06006AD8 RID: 27352 RVA: 0x005F5E68 File Offset: 0x005F4068
		public bool IntMicNsRdGenRADIOHOTBEAMMIXRATE_42682_Valid
		{
			get
			{
				short num = (short)70925126;
				short num2 = num;
				num = (short)231160646;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1473839104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)36962305;
				if (num != 0)
				{
				}
				num = (short)1904214016;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.Valid;
			}
			set
			{
				short num = (short)286262754;
				short num2 = num;
				num = (short)2076378594;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1872756736;
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
				num = (short)708247553;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.Valid = value;
			}
		}

		// Token: 0x17003760 RID: 14176
		// (get) Token: 0x06006AD9 RID: 27353 RVA: 0x005F5F20 File Offset: 0x005F4120
		// (set) Token: 0x06006ADA RID: 27354 RVA: 0x005F5FD4 File Offset: 0x005F41D4
		public bool IntMicNsRdGenRADIOHOTBEAMMIXRATE_42682_Visible
		{
			get
			{
				short num = (short)338385266;
				short num2 = num;
				num = (short)286284146;
				switch (num2 == num)
				{
				default:
				{
					num = (short)258080768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1866858497;
				if (num != 0)
				{
				}
				num = (short)544079872;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.Visible;
			}
			set
			{
				short num = (short)1962130604;
				short num2 = num;
				num = (short)1745796268;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1134231552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)31784961;
				if (num != 0)
				{
				}
				num = (short)1730805760;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.Visible = value;
			}
		}

		// Token: 0x17003761 RID: 14177
		// (get) Token: 0x06006ADB RID: 27355 RVA: 0x005F6088 File Offset: 0x005F4288
		// (set) Token: 0x06006ADC RID: 27356 RVA: 0x005F613C File Offset: 0x005F433C
		public bool IntMicNsRdGenRADIOHOTBEAMMIXRATE_42682_Editable
		{
			get
			{
				short num = (short)1040304430;
				short num2 = num;
				num = (short)1346357550;
				switch (num2 == num)
				{
				default:
				{
					num = (short)807075840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)956694529;
				if (num != 0)
				{
				}
				num = (short)539295744;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.Editable;
			}
			set
			{
				short num = (short)872726512;
				short num2 = num;
				num = (short)901824496;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1703018496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2129657857;
				if (num != 0)
				{
				}
				num = (short)1914896384;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.Editable = value;
			}
		}

		// Token: 0x17003762 RID: 14178
		// (get) Token: 0x06006ADD RID: 27357 RVA: 0x005F61F0 File Offset: 0x005F43F0
		internal string IntMicNsRdGenRADIOHOTBEAMMIXRATE_42682_UILabel
		{
			get
			{
				short num = (short)999497140;
				short num2 = num;
				num = (short)2095914420;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2114846720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1365508097;
				if (num != 0)
				{
				}
				num = (short)1507393536;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.UIName;
			}
		}

		// Token: 0x17003763 RID: 14179
		// (get) Token: 0x06006ADE RID: 27358 RVA: 0x005F62A4 File Offset: 0x005F44A4
		// (set) Token: 0x06006ADF RID: 27359 RVA: 0x005F6354 File Offset: 0x005F4554
		internal bool IntMicNsRdGenRADIOHOTBEAMMIXRATE_42682_HiddenStatic
		{
			get
			{
				short num = (short)678954950;
				short num2 = num;
				num = (short)2119632838;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1137442816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1253703681;
				if (num != 0)
				{
				}
				num = (short)2087124992;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.HiddenStatic;
			}
			set
			{
				short num = (short)1308026936;
				short num2 = num;
				num = (short)2037508152;
				switch (num2 == num)
				{
				default:
				{
					num = (short)577961984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)188874753;
				if (num != 0)
				{
				}
				num = (short)722665472;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.HiddenStatic = value;
			}
		}

		// Token: 0x17003764 RID: 14180
		// (get) Token: 0x06006AE0 RID: 27360 RVA: 0x005F6408 File Offset: 0x005F4608
		// (set) Token: 0x06006AE1 RID: 27361 RVA: 0x005F64BC File Offset: 0x005F46BC
		internal bool IntMicNsRdGenRADIOHOTBEAMMIXRATE_42682_HiddenDynamic
		{
			get
			{
				short num = (short)1478108314;
				short num2 = num;
				num = (short)973743258;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1801322496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)743047168;
				if (num != 0)
				{
				}
				num = (short)1072037889;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.HiddenDynamic;
			}
			set
			{
				short num = (short)2060888528;
				short num2 = num;
				num = (short)2053941712;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1241710592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1554579457;
				if (num != 0)
				{
				}
				num = (short)552075264;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682.HiddenDynamic = value;
			}
		}

		// Token: 0x17003765 RID: 14181
		// (get) Token: 0x06006AE2 RID: 27362 RVA: 0x005F6570 File Offset: 0x005F4770
		public bool IntMicNsRdGenRADIOHOTBEAMMIXRATE_42682_HasDiffs
		{
			get
			{
				short num = (short)581763810;
				short num2 = num;
				num = (short)244122338;
				switch (num2 == num)
				{
				default:
				{
					num = (short)4456448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1867644929;
				if (num != 0)
				{
				}
				num = (short)28180480;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMIXRATE_42682._HasDiffs;
			}
		}

		// Token: 0x17003766 RID: 14182
		// (get) Token: 0x06006AE3 RID: 27363 RVA: 0x005F6628 File Offset: 0x005F4828
		// (set) Token: 0x06006AE4 RID: 27364 RVA: 0x005F66E0 File Offset: 0x005F48E0
		public int IntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683Value
		{
			get
			{
				short num = (short)563941642;
				short num2 = num;
				num = (short)417927434;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1726414848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1329856513;
				if (num != 0)
				{
				}
				num = (short)1269235712;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.Value;
			}
			set
			{
				short num = (short)1025310257;
				short num2 = num;
				num = (short)2014641713;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1661468672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)568655872;
				if (num != 0)
				{
				}
				num = (short)1696858113;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.Value = value;
			}
		}

		// Token: 0x17003767 RID: 14183
		// (get) Token: 0x06006AE5 RID: 27365 RVA: 0x005F6794 File Offset: 0x005F4994
		public global::AcpBusinessLayer.AcpSimpleRangeField IntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683
		{
			get
			{
				short num = (short)1966784537;
				short num2 = num;
				num = (short)490979353;
				switch (num2 == num)
				{
				default:
				{
					num = (short)503775232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1268449281;
				if (num != 0)
				{
				}
				num = (short)702283776;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683;
			}
		}

		// Token: 0x17003768 RID: 14184
		// (get) Token: 0x06006AE6 RID: 27366 RVA: 0x005F6844 File Offset: 0x005F4A44
		// (set) Token: 0x06006AE7 RID: 27367 RVA: 0x005F68F8 File Offset: 0x005F4AF8
		public string IntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683_UIValue
		{
			get
			{
				short num = (short)322183786;
				short num2 = num;
				num = (short)1283007082;
				switch (num2 == num)
				{
				}
				num = (short)600309760;
				short num3 = num;
				num = (short)513015809;
				if (num != 0)
				{
				}
				num = (short)1378222080;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.UIValue;
			}
			set
			{
				short num = (short)1985819266;
				short num2 = num;
				num = (short)1964978818;
				switch (num2 == num)
				{
				}
				num = (short)762576896;
				short num3 = num;
				num = (short)667549696;
				if (num != 0)
				{
				}
				num = (short)1819672577;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.UIValue = value;
			}
		}

		// Token: 0x17003769 RID: 14185
		// (get) Token: 0x06006AE8 RID: 27368 RVA: 0x005F69AC File Offset: 0x005F4BAC
		// (set) Token: 0x06006AE9 RID: 27369 RVA: 0x005F6A60 File Offset: 0x005F4C60
		internal int IntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683Min
		{
			get
			{
				short num = (short)939117109;
				short num2 = num;
				num = (short)241027637;
				switch (num2 == num)
				{
				}
				num = (short)1110048768;
				short num3 = num;
				num = (short)1225261056;
				if (num != 0)
				{
				}
				num = (short)2103312385;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.Min;
			}
			set
			{
				short num = (short)353698684;
				short num2 = num;
				num = (short)1168769916;
				switch (num2 == num)
				{
				}
				num = (short)1500971008;
				short num3 = num;
				num = (short)325124097;
				if (num != 0)
				{
				}
				num = (short)1589444608;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.Min = value;
			}
		}

		// Token: 0x1700376A RID: 14186
		// (get) Token: 0x06006AEA RID: 27370 RVA: 0x005F6B14 File Offset: 0x005F4D14
		// (set) Token: 0x06006AEB RID: 27371 RVA: 0x005F6BC8 File Offset: 0x005F4DC8
		internal int IntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683Max
		{
			get
			{
				short num = (short)2131265619;
				short num2 = num;
				num = (short)2114947155;
				switch (num2 == num)
				{
				}
				num = (short)549453824;
				short num3 = num;
				num = (short)1520500737;
				if (num != 0)
				{
				}
				num = (short)160235520;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.Max;
			}
			set
			{
				short num = (short)1187197567;
				short num2 = num;
				num = (short)186331775;
				switch (num2 == num)
				{
				}
				num = (short)2000814080;
				short num3 = num;
				num = (short)52232192;
				if (num != 0)
				{
				}
				num = (short)683737089;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.Max = value;
			}
		}

		// Token: 0x1700376B RID: 14187
		// (get) Token: 0x06006AEC RID: 27372 RVA: 0x005F6C80 File Offset: 0x005F4E80
		// (set) Token: 0x06006AED RID: 27373 RVA: 0x005F6D34 File Offset: 0x005F4F34
		internal int IntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683Step
		{
			get
			{
				short num = (short)832160498;
				short num2 = num;
				num = (short)1067827954;
				switch (num2 == num)
				{
				}
				num = (short)2082340864;
				short num3 = num;
				num = (short)733675521;
				if (num != 0)
				{
				}
				num = (short)1461452800;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.StepSize;
			}
			set
			{
				short num = (short)1368781545;
				short num2 = num;
				num = (short)165475049;
				switch (num2 == num)
				{
				}
				num = (short)314966016;
				short num3 = num;
				num = (short)1447100416;
				if (num != 0)
				{
				}
				num = (short)1008599041;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.StepSize = value;
			}
		}

		// Token: 0x1700376C RID: 14188
		// (get) Token: 0x06006AEE RID: 27374 RVA: 0x005F6DE8 File Offset: 0x005F4FE8
		// (set) Token: 0x06006AEF RID: 27375 RVA: 0x005F6EA0 File Offset: 0x005F50A0
		public bool IntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683_Applicable
		{
			get
			{
				short num = (short)545914881;
				if (num != 0)
				{
				}
				num = (short)1097013961;
				short num2 = num;
				num = (short)1724652233;
				switch (num2 == num)
				{
				default:
				{
					num = (short)281149440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1661665280;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.Applicable;
			}
			set
			{
				short num = (short)16665240;
				short num2 = num;
				num = (short)1272924824;
				switch (num2 == num)
				{
				}
				num = (short)1468661760;
				short num3 = num;
				num = (short)229113857;
				if (num != 0)
				{
				}
				num = (short)298647552;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.Applicable = value;
			}
		}

		// Token: 0x1700376D RID: 14189
		// (get) Token: 0x06006AF0 RID: 27376 RVA: 0x005F6F54 File Offset: 0x005F5154
		// (set) Token: 0x06006AF1 RID: 27377 RVA: 0x005F700C File Offset: 0x005F520C
		public bool IntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683_Valid
		{
			get
			{
				short num = (short)393910377;
				short num2 = num;
				num = (short)624859241;
				switch (num2 == num)
				{
				}
				num = (short)354091008;
				short num3 = num;
				num = (short)1307181057;
				if (num != 0)
				{
				}
				num = (short)1304100864;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.Valid;
			}
			set
			{
				short num = (short)681548875;
				short num2 = num;
				num = (short)992517195;
				switch (num2 == num)
				{
				}
				num = (short)1965621248;
				short num3 = num;
				num = (short)177143808;
				if (num != 0)
				{
				}
				num = (short)209977345;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.Valid = value;
			}
		}

		// Token: 0x1700376E RID: 14190
		// (get) Token: 0x06006AF2 RID: 27378 RVA: 0x005F70C0 File Offset: 0x005F52C0
		// (set) Token: 0x06006AF3 RID: 27379 RVA: 0x005F7174 File Offset: 0x005F5374
		public bool IntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683_Visible
		{
			get
			{
				short num = (short)1213760935;
				short num2 = num;
				num = (short)2102035879;
				switch (num2 == num)
				{
				}
				num = (short)745406464;
				short num3 = num;
				num = (short)1183907841;
				if (num != 0)
				{
				}
				num = (short)639631360;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.Visible;
			}
			set
			{
				short num = (short)1158329061;
				short num2 = num;
				num = (short)796373733;
				switch (num2 == num)
				{
				}
				num = (short)1438253056;
				short num3 = num;
				num = (short)389611520;
				if (num != 0)
				{
				}
				num = (short)652017665;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.Visible = value;
			}
		}

		// Token: 0x1700376F RID: 14191
		// (get) Token: 0x06006AF4 RID: 27380 RVA: 0x005F7228 File Offset: 0x005F5428
		// (set) Token: 0x06006AF5 RID: 27381 RVA: 0x005F72DC File Offset: 0x005F54DC
		public bool IntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683_Editable
		{
			get
			{
				short num = (short)2006408745;
				short num2 = num;
				num = (short)67067433;
				switch (num2 == num)
				{
				}
				num = (short)645988352;
				short num3 = num;
				num = (short)1595146241;
				if (num != 0)
				{
				}
				num = (short)1491468288;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.Editable;
			}
			set
			{
				short num = (short)1225259921;
				short num2 = num;
				num = (short)546503569;
				switch (num2 == num)
				{
				}
				num = (short)1015939072;
				short num3 = num;
				num = (short)839909376;
				if (num != 0)
				{
				}
				num = (short)685375489;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.Editable = value;
			}
		}

		// Token: 0x17003770 RID: 14192
		// (get) Token: 0x06006AF6 RID: 27382 RVA: 0x005F7390 File Offset: 0x005F5590
		internal string IntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683_UILabel
		{
			get
			{
				short num = (short)222943364;
				short num2 = num;
				num = (short)780982404;
				switch (num2 == num)
				{
				}
				num = (short)1903886336;
				short num3 = num;
				num = (short)1389625344;
				if (num != 0)
				{
				}
				num = (short)559480833;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.UIName;
			}
		}

		// Token: 0x17003771 RID: 14193
		// (get) Token: 0x06006AF7 RID: 27383 RVA: 0x005F7444 File Offset: 0x005F5644
		// (set) Token: 0x06006AF8 RID: 27384 RVA: 0x005F74F4 File Offset: 0x005F56F4
		internal bool IntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683_HiddenStatic
		{
			get
			{
				short num = (short)457388555;
				short num2 = num;
				num = (short)425275915;
				switch (num2 == num)
				{
				}
				num = (short)942669824;
				short num3 = num;
				num = (short)518520832;
				if (num != 0)
				{
				}
				num = (short)982777857;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.HiddenStatic;
			}
			set
			{
				short num = (short)2013323940;
				short num2 = num;
				num = (short)1260970660;
				switch (num2 == num)
				{
				}
				num = (short)43122688;
				short num3 = num;
				num = (short)1485766657;
				if (num != 0)
				{
				}
				num = (short)1648754688;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.HiddenStatic = value;
			}
		}

		// Token: 0x17003772 RID: 14194
		// (get) Token: 0x06006AF9 RID: 27385 RVA: 0x005F75A8 File Offset: 0x005F57A8
		// (set) Token: 0x06006AFA RID: 27386 RVA: 0x005F7660 File Offset: 0x005F5860
		internal bool IntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683_HiddenDynamic
		{
			get
			{
				short num = (short)1130343441;
				short num2 = num;
				num = (short)1386130449;
				switch (num2 == num)
				{
				}
				num = (short)1447821312;
				short num3 = num;
				num = (short)1705639937;
				if (num != 0)
				{
				}
				num = (short)7077888;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.HiddenDynamic;
			}
			set
			{
				short num = (short)718306265;
				short num2 = num;
				num = (short)1678408665;
				switch (num2 == num)
				{
				}
				num = (short)388890624;
				short num3 = num;
				num = (short)789774337;
				if (num != 0)
				{
				}
				num = (short)197853184;
				if (num != 0)
				{
				}
				this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683.HiddenDynamic = value;
			}
		}

		// Token: 0x17003773 RID: 14195
		// (get) Token: 0x06006AFB RID: 27387 RVA: 0x005F7718 File Offset: 0x005F5918
		public bool IntMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683_HasDiffs
		{
			get
			{
				short num = (short)778073013;
				short num2 = num;
				num = (short)16413621;
				switch (num2 == num)
				{
				}
				num = (short)687407104;
				short num3 = num;
				num = (short)619118593;
				if (num != 0)
				{
				}
				num = (short)1349451776;
				if (num != 0)
				{
				}
				return this.intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683._HasDiffs;
			}
		}

		// Token: 0x06006AFC RID: 27388 RVA: 0x005F77CC File Offset: 0x005F59CC
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)899978957;
			short num2 = num;
			num = (short)116365005;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B6:
				num = (short)1989804035;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)664469504;
				if (num != 0)
				{
				}
				num = (short)147324929;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_95;
				}
				break;
			}
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_7B:
				switch (num3)
				{
				case 0:
					goto IL_F2;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)1806893058;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)84082688;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1618149377;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_AB;
				}
				goto IL_95;
			}
			IL_AB:
			if (base.ParentRecset != null)
			{
				goto IL_B6;
			}
			return result;
			IL_F2:
			num = (short)2067791872;
			short num4 = num;
			return result;
			IL_95:
			result = null;
			num = (short)993787908;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7B;
		}

		// Token: 0x0400293D RID: 10557
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgGeneralEXPANSIONDEGREE_A21563;

		// Token: 0x0400293E RID: 10558
		private global::AcpBusinessLayer.AcpKeyField internalMicNoiseReductionProfileName_A22535;

		// Token: 0x0400293F RID: 10559
		private global::AcpBusinessLayer.AcpField<string> intMicNsRdGenDINCOUTPUTEQVECTOR_A37718;

		// Token: 0x04002940 RID: 10560
		private global::AcpBusinessLayer.AcpField<string> intMicNsRdGenDINCEPVECTOR_A37719;

		// Token: 0x04002941 RID: 10561
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgGeneralHOTBEAMDETTHRESHDBQ8_A21566;

		// Token: 0x04002942 RID: 10562
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgGeneralINACTIVETHRESHDBQ8_A21569;

		// Token: 0x04002943 RID: 10563
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgGeneralNDIFFTHRESHDBQ8_A21571;

		// Token: 0x04002944 RID: 10564
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgGeneralRTHRESHDBQ8_A21572;

		// Token: 0x04002945 RID: 10565
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgGeneralSDIFFTHRESHDBQ8_A21570;

		// Token: 0x04002946 RID: 10566
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgGeneralVADDETTHRESHDBQ8_A21567;

		// Token: 0x04002947 RID: 10567
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgGeneralVADDETCOUNT_A21568;

		// Token: 0x04002948 RID: 10568
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgGeneralMINGAIN_A21562;

		// Token: 0x04002949 RID: 10569
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgGeneralDINCABFSS_A21564;

		// Token: 0x0400294A RID: 10570
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgGeneralNBANDS_A21573;

		// Token: 0x0400294B RID: 10571
		private global::AcpBusinessLayer.AcpField<string> radErgoCfgGeneralMAXSVECTOR_A21565;

		// Token: 0x0400294C RID: 10572
		private global::AcpBusinessLayer.AcpField<string> intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676;

		// Token: 0x0400294D RID: 10573
		private global::AcpBusinessLayer.AcpField<string> intMicNsRdGenRADIOAUTOMINGAINVECTOR_42677;

		// Token: 0x0400294E RID: 10574
		private global::AcpBusinessLayer.AcpField<string> intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678;

		// Token: 0x0400294F RID: 10575
		private global::AcpBusinessLayer.AcpSimpleRangeField intMicNsRdGenRADIOPASSFILTERSTART_42679;

		// Token: 0x04002950 RID: 10576
		private global::AcpBusinessLayer.AcpSimpleRangeField intMicNsRdGenRADIOSAMMIXMODE_42680;

		// Token: 0x04002951 RID: 10577
		private global::AcpBusinessLayer.AcpSimpleRangeField intMicNsRdGenRADIOSAMCUTOVERFREQUENCY_42681;

		// Token: 0x04002952 RID: 10578
		private global::AcpBusinessLayer.AcpSimpleRangeField intMicNsRdGenRADIOHOTBEAMMIXRATE_42682;

		// Token: 0x04002953 RID: 10579
		private global::AcpBusinessLayer.AcpSimpleRangeField intMicNsRdGenRADIOHOTBEAMMAXATTENUATIONDBQ8_42683;
	}
}
