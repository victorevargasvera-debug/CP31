using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Features.Converters;
using Motorola.MackinawCPS.CoreFeatures.DataWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.DataProfiles
{
	// Token: 0x0200050F RID: 1295
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600AD08 RID: 44296 RVA: 0x00A1077C File Offset: 0x00A0E97C
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600AD09 RID: 44297 RVA: 0x00A10798 File Offset: 0x00A0E998
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600AD0A RID: 44298 RVA: 0x00A107B0 File Offset: 0x00A0E9B0
		public override void Init()
		{
			int a_ = 7;
			short num = (short)884863999;
			short num2 = num;
			num = (short)549581823;
			switch (num2 == num)
			{
			}
			num = (short)1218117633;
			if (num != 0)
			{
			}
			num = (short)2109538304;
			if (num != 0)
			{
			}
			num = (short)232718336;
			short num3 = num;
			this.dataProfGeneralDataScanPreambleLength_A7798 = new global::AcpBusinessLayer.AcpSimpleRangeField(20, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍胏ꃑ믓냕鿗뿙닛믝鋟菡裣ꋥ觧黩跫뷭鏯鏱髳꛵諷鿹鷻鏽拿渁愃䨅洇搉欋稍砏䴑唓ℕ⼗⌙␛", a_), global::CommonResources.AcgResources.ID_DATASCANPREAMBLELENGTH, 0, 100, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 1);
			this.dataProfGeneralDataScanPreambleLength_A7798.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataProfGeneralDataScanPreambleLength_A7798.DataTransferOrder = 23;
			this.dataProfGeneralDataScanPreambleLength_A7798.ShowHexValue = false;
			this.dataProfGeneralLimitedBroadcast_A8431 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍胏ꃑ믓냕鿗뿙닛믝鋟菡裣ꫥ臧蟩藫髭闯雱뛳蓵韷鯹飻鷽懿焁瀃夅䤇㈉㠋㴍ℏ", a_), global::CommonResources.AcgResources.ID_LIMITEDBROADCAST);
			this.dataProfGeneralLimitedBroadcast_A8431.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataProfGeneralLimitedBroadcast_A8431.DataTransferOrder = 21;
			this.dataProfGeneralLimitedBroadcast_A8431.EvaluateRecRefs = true;
			this.dataProfGeneralMobileComputerIPAddress_A8523 = new global::AcpBusinessLayer.AcpIPAddressField(0L, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍胏ꃑ믓냕鿗뿙닛믝鋟菡裣ꯥ蟧裩藫苭闯뇱鯳鯵裷迹裻鯽狿䬁吃䜅氇渉縋欍挏愑䬓圕‗⼙⸛ⴝ", a_), global::CommonResources.AcgResources.ID_SERIALLINK1ADDRESSESPEERIPADDRESS);
			this.dataProfGeneralMobileComputerIPAddress_A8523.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataProfGeneralMobileComputerIPAddress_A8523.DataTransferOrder = 7;
			this.dataProfGeneralMobileComputerIPAddress_A8523.EvaluateRecRefs = true;
			this.dataProfGeneralPacketDataMode_A8689 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍胏ꃑ믓냕鿗뿙닛믝鋟菡裣뛥觧觩蟫语蓯뛱闳苵駷럹鏻髽旿崁䔃㸅㸇㈉㔋", a_), global::CommonResources.AcgResources.ID_PACKETDATAMODE, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataProfGeneralPacketDataMode_A8689LovStrs);
			this.dataProfGeneralPacketDataMode_A8689.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dataProfGeneralPacketDataMode_A8689.DataTransferOrder = 3;
			this.trkSysLabtoolRxVoiceInterruptsData_A9043 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ飓럕뫗껙돛뇝賟냡鳣냥蟧菩迫语맯鳱胳鏵諷裹觻軽瓿焁䀃朅簇欉匋伍⤏∑–┕", a_), global::CommonResources.AcgResources.ID_RXVOICEINTERRUPTSDATA);
			this.trkSysLabtoolRxVoiceInterruptsData_A9043.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysLabtoolRxVoiceInterruptsData_A9043.DataTransferOrder = 17;
			this.trkSysLabtoolRxVoiceInterruptsData_A9043.EvaluateRecRefs = true;
			this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220 = new global::AcpBusinessLayer.AcpIPAddressField(0L, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍胏ꃑ믓냕鿗뿙닛믝鋟菡裣뗥鷧裩鿫跭苯鯱雳鏵諷믹闻賽䧿氁瀃挅稇氉洋洍甏嬑䐓圕簗縙減笝匟儡笣朥ᄧᠩḫḭ", a_), global::CommonResources.AcgResources.ID_SUBSCRIBERAIRINTERFACEIPADDRESS);
			this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.DataTransferOrder = 31;
			this.dataProfGeneralAutoGenerateIPAddress_A19320 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍胏ꃑ믓냕鿗뿙닛믝鋟菡裣꟥鷧黩菫ꧭ闯鳱釳蓵駷軹駻럽僿䌁怃戅稇漉缋納伏匑┓⼕⬗⠙Ⱋ", a_), global::CommonResources.AcgResources.ID_AUTOGENERATEIPADDRESS);
			this.dataProfGeneralAutoGenerateIPAddress_A19320.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataProfGeneralAutoGenerateIPAddress_A19320.DataTransferOrder = 5;
			this.dataProfGeneralkeyofDataProfiles_A19446 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍胏ꃑ믓냕鿗뿙닛믝鋟菡裣跥跧鏩菫裭듯鏱胳韵ꣷ裹鏻飽槿渁愃甅圇䬉㴋㜍␏☑∓", a_), global::CommonResources.AcgResources.ID_DATAPROFILENAME, 14);
			this.dataProfGeneralkeyofDataProfiles_A19446.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataProfGeneralkeyofDataProfiles_A19446.DataTransferOrder = 12;
			this.dataProfGeneralSubscriberIPAddress_A21157 = new global::AcpBusinessLayer.AcpIPAddressField(0L, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍胏ꃑ믓냕鿗뿙닛믝鋟菡裣뗥鷧裩鿫跭苯鯱雳鏵諷돹곻뿽擿昁瘃挅笇礉匋伍∏⌑┓⌕⼗", a_), global::CommonResources.AcgResources.ID_SERIALLINK1ADDRESSESSUBSCRIBERIPADDRESS);
			this.dataProfGeneralSubscriberIPAddress_A21157.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataProfGeneralSubscriberIPAddress_A21157.DataTransferOrder = 32;
			this.dataProfGeneralSubscriberIPAddress_A21157.EvaluateRecRefs = true;
			this.dataProfGeneralDataProfileType_A21320 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍胏ꃑ믓냕鿗뿙닛믝鋟菡裣ꋥ觧黩跫뻭苯鷱鋳鿵铷鿹ꣻ蟽烿朁嬃䜅㨇㬉㼋㰍‏", a_), global::CommonResources.AcgResources.ID_DATAPROFILETYPE, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataProfGeneralDataProfileType_A21320LovStrs);
			this.dataProfGeneralDataProfileType_A21320.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dataProfGeneralDataProfileType_A21320.DataTransferOrder = 6;
			this.dataProfGeneralDataProfileType_A21320.EvaluateRecRefs = true;
			this.dataWideGeneralPeerIPAddressAssignmentType_A22263 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍蟏믑냓돕鿗뿙닛믝鋟菡裣뛥跧迩黫꟭ꃯ돱郳鋵諷鿹迻跽䇿焁眃漅漇搉愋欍縏昑䀓漕栗缙䌛弝ሟအᘣဥᬧ", a_), global::CommonResources.AcgResources.ID_SERIALLINK1ADDRESSESPEERIPADDRESSASSIGNMENTTYPE, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataWideGeneralPeerIPAddressAssignmentType_A22263LovStrs);
			this.dataWideGeneralPeerIPAddressAssignmentType_A22263.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideGeneralPeerIPAddressAssignmentType_A22263.DataTransferOrder = 8;
			this.dataConfigDataProfIPHeaderCompressionEnable_A36190 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍鏏뷑뫓냕뇗뷙飛뿝铟菡듣铥蟧賩ꗫ뻭룯韱闳鋵鷷裹뿻釽淿爁瘃挅笇礉攋愍縏圑稓眕稗瘙礛䄝感ᄡሣᜥᄧᨩ", a_), global::CommonResources.AcgResources.ID_IPHEADERCOMPRESSIONENABLE);
			this.dataConfigDataProfIPHeaderCompressionEnable_A36190.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataConfigDataProfIPHeaderCompressionEnable_A36190.DataTransferOrder = 34;
			this.dataConfigDataProfIPHeaderCompressionEnable_A36190.EvaluateRecRefs = true;
			this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍鏏뷑뫓뿕뿗꿙껛뿝铟诡诣裥곧诩飫迭ꃯ胱鯳郵釷雹駻껽懿愁漃挅簇三洋稍焏䀑焓焕焗椙栛氝䄟嘡䴣䤥䘧簩䤫尭䌯嬱嬳堵朷笹༻࠽爿獁瑃", a_), global::CommonResources.AcgResources.ID_REGISTRATIONPACKETDATAREGISTRATIONVERSION, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataConigurationDataProfilePacketDataRegistrationVersion_A36210LovStrs);
			this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210.DataTransferOrder = 33;
			this.dataConfigDataProfContextActivationHoldoffTime_A36551 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍鏏뷑뫓냕뇗뷙飛뿝铟菡듣铥蟧賩꿫臭黯蛱釳軵賷믹鿻諽槿琁攃爅愇攉戋䘍缏縑瀓礕縗簙䠛眝䴟䜡笣朥ᬧᰩᤫᬭį", a_), global::CommonResources.AcgResources.ID_REGISTRATIONCONTEXTACTIVATIONHOLDOFFTIMEMIN, 0, 60, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 1);
			this.dataConfigDataProfContextActivationHoldoffTime_A36551.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataConfigDataProfContextActivationHoldoffTime_A36551.DataTransferOrder = 39;
			this.dataConfigDataProfContextActivationHoldoffTime_A36551.ShowHexValue = false;
			this.dataConfigDataProfRandomHoldOffTime_A36552 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍鏏뷑뫓냕뇗뷙飛뿝铟菡듣铥蟧賩뻫迭黯雱鯳鯵냷闹郻髽俿搁戃刅愇有椋儍儏ℑ∓⌕ⴗ⠙", a_), global::CommonResources.AcgResources.ID_REGISTRATIONRANDOMHOLDOFFTIME);
			this.dataConfigDataProfRandomHoldOffTime_A36552.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataConfigDataProfRandomHoldOffTime_A36552.DataTransferOrder = 38;
			this.dataProfGeneralQueueDwellTimersec_A8806 = new global::AcpBusinessLayer.AcpSimpleRangeField(60, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍胏ꃑ믓냕鿗뿙닛믝鋟菡裣럥鷧迩駫语듯藱釳髵铷껹闻鏽旿瀁眃挅欇唉䴋㘍⠏∑∓", a_), global::CommonResources.AcgResources.ID_QUEUEDWELLTIMERSEC, 15, 120, null, null, 0, 1);
			this.dataProfGeneralQueueDwellTimersec_A8806.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataProfGeneralQueueDwellTimersec_A8806.DataTransferOrder = 15;
			this.dataProfGeneralQueueDwellTimersec_A8806.ShowHexValue = false;
			this.dataWideGeneralNATEnable_A38866 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍蟏믑냓돕鿗뿙닛믝鋟菡裣꣥ꧧ뻩ꧫ胭釯郱飳鏵ꟷ믹쿻웽㣿㐁㈃", a_), global::CommonResources.AcgResources.ID_NATENABLE);
			this.dataWideGeneralNATEnable_A38866.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataWideGeneralNATEnable_A38866.DataTransferOrder = 4;
			this.dataProfilesGeneralBTDUNSUIPAddress_A41126 = new global::AcpBusinessLayer.AcpIPAddressField(25340096L, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍胏ꃑ믓냕뇗뛙맛귝꟟蟡諣菥髧诩胫곭ꓯ뛱ꇳ룵꯷꿹뗻껽䇿昁怃琅洇礉缋儍儏☑┓✕⨗Ⱉ", a_), global::CommonResources.AcgResources.ID_BLUETOOTHDIALUPNETWORKINGADDRESSESSUBSCRIBERIPADDRESS);
			this.dataProfilesGeneralBTDUNSUIPAddress_A41126.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataProfilesGeneralBTDUNSUIPAddress_A41126.DataTransferOrder = 47;
			this.dataProfilesGeneralBTDUNSUIPAddress_A41126.EvaluateRecRefs = true;
			this.dataProfilesGeneralBTDUNPeerIPAddress_A41127 = new global::AcpBusinessLayer.AcpIPAddressField(42117312L, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍胏ꃑ믓냕뇗뛙맛귝꟟蟡諣菥髧诩胫곭ꓯ뛱ꇳ룵ꣷ鿹駻賽䧿刁䔃戅氇砉椋納挏䴑唓∕⤗⬙⸛⤝", a_), global::CommonResources.AcgResources.ID_BLUETOOTHDIALUPNETWORKINGADDRESSESPEERIPADDRESS);
			this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.DataTransferOrder = 24;
			this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.EvaluateRecRefs = true;
			this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍胏ꃑ믓냕뇗뛙맛귝꟟蟡諣菥髧诩胫곭ꓯ뛱ꇳ룵ꣷ鿹駻賽䧿刁䔃戅氇砉椋納挏匑朓攕焗紙爛猝䔟䰡倣爥儧娩䤫焭焯رԳܵ਷ȹ", a_), global::CommonResources.AcgResources.ID_BLUETOOTHDIALUPNETWORKINGADDRESSESPEERIPADDRESSASSIGNMENTTYPE, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128LovStrs);
			this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.DataTransferOrder = 14;
			this.dataProfGeneralAutoGenerateTargetIPAddress_A41697 = new global::AcpBusinessLayer.AcpFieldX<bool, bool>(true, new global::Features.Converters.UnpackAndPackAndInvertBooleanField(), this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍胏ꃑ믓냕鿗뿙닛믝鋟菡裣꟥鷧黩菫ꧭ闯鳱釳蓵駷軹駻꫽懿瀁挃挅簇䌉尋伍琏瘑易猕欗椙䌛弝ᐟጡሣἥἧ", a_), global::CommonResources.AcgResources.ID_AUTOGENERATETARGETIPADDRESS);
			this.dataProfGeneralAutoGenerateTargetIPAddress_A41697.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataProfGeneralAutoGenerateTargetIPAddress_A41697.DataTransferOrder = 40;
			this.dataConfigDataProfIntersystemData_A42381 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍鏏뷑뫓냕뇗뷙飛뿝铟菡듣铥蟧賩ꗫ胭蓯韱蛳藵臷觹裻鯽淿䘁攃爅椇唉䴋㨍∏ℑⰓ✕", a_), global::CommonResources.AcgResources.ID_REGISTRATIONINTERSYSTEMDATA);
			this.dataConfigDataProfIntersystemData_A42381.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dataConfigDataProfIntersystemData_A42381.DataTransferOrder = 41;
			this.priorityScanRxVoiceInterruptsData_A42590 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飇룉ꗋꇍꋏ믑ꃓ꿕诗맙뷛냝닟髡닣觥臧觩觫꟭黯蛱釳蓵諷迹賻諽珿䘁攃爅椇唉䴋㨍∏✑ⴓ☕", a_), global::CommonResources.AcgResources.ID_PRIORITYSCANRXVOICEINTERRUPTSDATA);
			this.priorityScanRxVoiceInterruptsData_A42590.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.priorityScanRxVoiceInterruptsData_A42590.DataTransferOrder = 73;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("过꿉ꋋꯍꋏ돑룓", a_);
			base.Id = 10121;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600AD0B RID: 44299 RVA: 0x00A10E7C File Offset: 0x00A0F07C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)1010171922;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_45B;
				case 1:
					num = (short)98238510;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋跍뿏병닓뿕뿗黙뷛ꫝ臟닡難觥軧ꏩ볫ꛭ闯鏱郳鏵諷맹鏻鏽烿瀁愃甅笇按挋怍唏簑甓琕琗缙䌛弝ጟᐡᔣἥᠧ", a_)))
					{
						num = (short)1404436491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3BF;
				case 3:
					goto IL_17A;
				case 4:
					goto IL_4F4;
				case 5:
					goto IL_40D;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓釕뷗듙맛곝臟軡ꗣ鏥鳧藩꯫语黯韱蛳韵賷鿹ꣻ鿽狿攁愃爅䄇娉䴋樍琏怑焓攕欗䔙崛⨝ᄟᐡᴣᄥ", a_)))
					{
						num = (short)1672609853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_371;
				case 7:
					this.dataConfigDataProfContextActivationHoldoffTime_A36551 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋跍뿏병닓뿕뿗黙뷛ꫝ臟닡難觥軧ꧩ菫胭蓯韱賳苵맷駹裻韽盿持瀃漅朇搉䐋愍簏瘑笓瀕縗丙甛猝䔟紡攣ᔥḧἩᤫἭ", a_), global::CommonResources.AcgResources.ID_REGISTRATIONCONTEXTACTIVATIONHOLDOFFTIMEMIN, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 1);
					this.dataConfigDataProfContextActivationHoldoffTime_A36551.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataConfigDataProfContextActivationHoldoffTime_A36551.DataTransferOrder = 39;
					this.dataConfigDataProfContextActivationHoldoffTime_A36551.ShowHexValue = false;
					num = (short)259719227;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓釕뷗듙맛곝臟軡ꗣ鏥鳧藩꯫语黯韱蛳韵賷鿹뗻껽䇿昁怃琅洇礉缋儍儏⌑ⴓ┕⨗⨙", a_)))
					{
						num = (short)2092498972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_84A;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓釕뷗듙맛곝臟軡ꃣ蟥鳧诩볫鳭鿯铱鷳髵鷷껹藻軽旿崁䔃㐅㤇㤉㸋㸍", a_)))
					{
						num = (short)1691811861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B45;
				case 10:
					goto IL_ED8;
				case 11:
					this.dataConfigDataProfIPHeaderCompressionEnable_A36190 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋跍뿏병닓뿕뿗黙뷛ꫝ臟닡難觥軧ꏩ볫ꛭ闯鏱郳鏵諷맹鏻鏽烿瀁愃甅笇按挋怍唏簑甓琕琗缙䌛弝ጟᐡᔣἥᠧ", a_), global::CommonResources.AcgResources.ID_IPHEADERCOMPRESSIONENABLE);
					this.dataConfigDataProfIPHeaderCompressionEnable_A36190.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataConfigDataProfIPHeaderCompressionEnable_A36190.DataTransferOrder = 34;
					this.dataConfigDataProfIPHeaderCompressionEnable_A36190.EvaluateRecRefs = true;
					num = (short)1479999557;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					this.dataProfilesGeneralBTDUNSUIPAddress_A41126 = new global::AcpBusinessLayer.AcpIPAddressField(25340096L, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓뿕듗뿙꿛駝藟賡臣铥觧蛩껫뫭듯꟱뫳ꗵ귷돹곻뿽擿昁瘃挅笇礉匋伍␏⌑┓␕⸗", a_), global::CommonResources.AcgResources.ID_BLUETOOTHDIALUPNETWORKINGADDRESSESSUBSCRIBERIPADDRESS);
					this.dataProfilesGeneralBTDUNSUIPAddress_A41126.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataProfilesGeneralBTDUNSUIPAddress_A41126.DataTransferOrder = 47;
					this.dataProfilesGeneralBTDUNSUIPAddress_A41126.EvaluateRecRefs = true;
					num = (short)215679041;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_84A;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓釕뷗듙맛곝臟軡ꃣ蟥鳧诩뿫跭釯鳱ꓳ蓵鷷鯹釻鳽泿朁䠃挅昇洉砋昍伏匑⌓ℕ℗∙", a_)))
					{
						num = (short)614137927;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_ED8;
				case 15:
					goto IL_B45;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓釕뷗듙맛곝臟軡뗣鏥跧鿩觫ꫭ蟯韱飳髵곷鏹釻鯽狿焁愃攅圇䬉㐋㘍‏␑", a_)))
					{
						num = (short)591855656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17A;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋跍뿏병닓뿕뿗黙뷛ꫝ臟닡難觥軧룩跫胭铯鷱駳뻵韷雹飻뇽替搁倃漅攇漉匋伍⌏␑ℓ⌕⨗", a_)))
					{
						num = (short)1518862381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_323;
				case 18:
					switch (0)
					{
					case 0:
						goto IL_152;
					}
					continue;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓뿕듗뿙꿛駝藟賡臣铥觧蛩껫뫭듯꟱뫳꛵鷷鿹軻럽僿䌁怃戅稇漉缋納儏愑朓缕缗琙焛笝丟嘡瀣弥堧伩猫漭Я̱Գе7", a_)))
					{
						num = (short)1666187316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_45B;
				case 20:
					goto IL_4BF;
				case 21:
					this.dataProfGeneralDataProfileType_A21320 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓釕뷗듙맛곝臟軡ꃣ蟥鳧诩볫鳭鿯铱鷳髵鷷껹藻軽旿崁䔃㐅㤇㤉㸋㸍", a_), global::CommonResources.AcgResources.ID_DATAPROFILETYPE, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataProfGeneralDataProfileType_A21320LovStrs);
					this.dataProfGeneralDataProfileType_A21320.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dataProfGeneralDataProfileType_A21320.DataTransferOrder = 6;
					this.dataProfGeneralDataProfileType_A21320.EvaluateRecRefs = true;
					num = (short)618135567;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓釕뷗듙맛곝臟軡ꧣ觥諧菩胫语돯鷱駳蛵跷軹駻賽䧿刁䔃戅氇砉椋納挏䴑唓⸕ⴗ⠙⼛", a_)))
					{
						num = (short)855113777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5D8;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋跍뿏병뷓뇕귗꣙뷛ꫝ觟跡諣ꋥ觧黩跫뻭苯鷱鋳鿵铷鿹곻鿽揿椁愃爅䰇欉砋漍䈏眑猓缕欗渙減缝吟䬡䬣䠥縧伩師崭夯崱娳椵礷ह਻ఽ焿牁", a_)))
					{
						num = (short)27197478;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A46;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋駍맏뛑뇓釕뷗듙맛곝臟軡듣菥跧飩ꗫ뻭뇯雱郳蓵鷷觹迻뿽珿焁洃愅昇有椋怍搏䘑洓昕紗䔙崛Ⱍሟအሣᔥ", a_)))
					{
						num = (short)1625882686;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F26;
				case 25:
					this.dataProfGeneralSubscriberIPAddress_A21157 = new global::AcpBusinessLayer.AcpIPAddressField(0L, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓釕뷗듙맛곝臟軡럣鏥諧駩迫鳭駯郱釳蓵뇷꫹뷻髽擿瀁愃甅笇唉䴋㰍ℏ⌑ℓℕ", a_), global::CommonResources.AcgResources.ID_SERIALLINK1ADDRESSESSUBSCRIBERIPADDRESS);
					this.dataProfGeneralSubscriberIPAddress_A21157.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataProfGeneralSubscriberIPAddress_A21157.DataTransferOrder = 32;
					this.dataProfGeneralSubscriberIPAddress_A21157.EvaluateRecRefs = true;
					num = (short)2013921284;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					this.trkSysLabtoolRxVoiceInterruptsData_A9043 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ黑뗓듕곗뗙돛닝닟髡닣觥臧觩觫꟭黯蛱釳蓵諷迹賻諽珿䘁攃爅椇唉䴋㜍‏☑✓", a_), global::CommonResources.AcgResources.ID_RXVOICEINTERRUPTSDATA);
					this.trkSysLabtoolRxVoiceInterruptsData_A9043.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysLabtoolRxVoiceInterruptsData_A9043.DataTransferOrder = 17;
					this.trkSysLabtoolRxVoiceInterruptsData_A9043.EvaluateRecRefs = true;
					num = (short)1417871365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋駍맏뛑뇓釕뷗듙맛곝臟軡ꫣ꟥볧꿩苫迭鋯黱釳꧵맷짹쓻웽㛿㐁", a_)))
					{
						num = (short)1818755122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B8E;
				case 28:
					this.dataProfGeneralAutoGenerateIPAddress_A19320 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓釕뷗듙맛곝臟軡ꗣ鏥鳧藩꯫语黯韱蛳韵賷鿹뗻껽䇿昁怃琅洇礉缋儍儏⌑ⴓ┕⨗⨙", a_), global::CommonResources.AcgResources.ID_AUTOGENERATEIPADDRESS);
					this.dataProfGeneralAutoGenerateIPAddress_A19320.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataProfGeneralAutoGenerateIPAddress_A19320.DataTransferOrder = 5;
					num = (short)1898577933;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓뿕듗뿙꿛駝藟賡臣铥觧蛩껫뫭듯꟱뫳꛵鷷鿹軻럽僿䌁怃戅稇漉缋納伏匑–✕⤗⠙⬛", a_)))
					{
						num = (short)682688546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E8B;
				case 30:
					goto IL_5D8;
				case 31:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋跍뿏병닓뿕뿗黙뷛ꫝ臟닡難觥軧ꧩ菫胭蓯韱賳苵맷駹裻韽盿持瀃漅朇搉䐋愍簏瘑笓瀕縗丙甛猝䔟紡攣ᔥḧἩᤫἭ", a_)))
					{
						num = (short)908460039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7FE;
				case 32:
					this.dataProfGeneralPacketDataMode_A8689 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓釕뷗듙맛곝臟軡듣蟥诧臩觫髭듯鏱胳韵뗷闹飻鯽忿䌁㰃々〇㌉", a_), global::CommonResources.AcgResources.ID_PACKETDATAMODE, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataProfGeneralPacketDataMode_A8689LovStrs);
					this.dataProfGeneralPacketDataMode_A8689.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dataProfGeneralPacketDataMode_A8689.DataTransferOrder = 3;
					num = (short)1574043720;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
					this.dataProfGeneralkeyofDataProfiles_A19446 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓釕뷗듙맛곝臟軡迣菥釧藩諫ꫭ釯蛱闳꛵諷闹髻韽泿朁眃夅䤇㬉㔋㨍␏␑", a_), global::CommonResources.AcgResources.ID_DATAPROFILENAME, 14);
					this.dataProfGeneralkeyofDataProfiles_A19446.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataProfGeneralkeyofDataProfiles_A19446.DataTransferOrder = 12;
					num = (short)1103364131;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					this.dataProfilesGeneralBTDUNPeerIPAddress_A41127 = new global::AcpBusinessLayer.AcpIPAddressField(42117312L, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓뿕듗뿙꿛駝藟賡臣铥觧蛩껫뫭듯꟱뫳꛵鷷鿹軻럽僿䌁怃戅稇漉缋納伏匑–✕⤗⠙⬛", a_), global::CommonResources.AcgResources.ID_BLUETOOTHDIALUPNETWORKINGADDRESSESPEERIPADDRESS);
					this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.DataTransferOrder = 24;
					this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.EvaluateRecRefs = true;
					num = (short)239861817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					goto IL_DDB;
				case 36:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ黑뗓듕곗뗙돛닝닟髡닣觥臧觩觫꟭黯蛱釳蓵諷迹賻諽珿䘁攃爅椇唉䴋㜍‏☑✓", a_)))
					{
						num = (short)56885274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_40D;
				case 37:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓釕뷗듙맛곝臟軡듣蟥诧臩觫髭듯鏱胳韵뗷闹飻鯽忿䌁㰃々〇㌉", a_)))
					{
						num = (short)2111635488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_223;
				case 38:
					this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋跍뿏병뷓뇕귗꣙뷛ꫝ觟跡諣ꋥ觧黩跫뻭苯鷱鋳鿵铷鿹곻鿽揿椁愃爅䰇欉砋漍䈏眑猓缕欗渙減缝吟䬡䬣䠥縧伩師崭夯崱娳椵礷ह਻ఽ焿牁", a_), global::CommonResources.AcgResources.ID_REGISTRATIONPACKETDATAREGISTRATIONVERSION, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataConigurationDataProfilePacketDataRegistrationVersion_A36210LovStrs);
					this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210.DataTransferOrder = 33;
					num = (short)974979142;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 39:
					this.dataProfGeneralLimitedBroadcast_A8431 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓釕뷗듙맛곝臟軡꣣迥藧菩飫语铯냱蛳駵駷黹鿻鿽珿瘁嬃䜅〇㸉㼋㼍", a_), global::CommonResources.AcgResources.ID_LIMITEDBROADCAST);
					this.dataProfGeneralLimitedBroadcast_A8431.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataProfGeneralLimitedBroadcast_A8431.DataTransferOrder = 21;
					this.dataProfGeneralLimitedBroadcast_A8431.EvaluateRecRefs = true;
					num = (short)554565690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 40:
					this.dataProfGeneralQueueDwellTimersec_A8806 = new global::AcpBusinessLayer.AcpSimpleRangeField(60, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓釕뷗듙맛곝臟軡뗣鏥跧鿩觫ꫭ蟯韱飳髵곷鏹釻鯽狿焁愃攅圇䬉㐋㘍‏␑", a_), global::CommonResources.AcgResources.ID_QUEUEDWELLTIMERSEC, null, null, 0, 1);
					this.dataProfGeneralQueueDwellTimersec_A8806.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataProfGeneralQueueDwellTimersec_A8806.DataTransferOrder = 15;
					this.dataProfGeneralQueueDwellTimersec_A8806.ShowHexValue = false;
					num = (short)571408387;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 41:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓뿕듗뿙꿛駝藟賡臣铥觧蛩껫뫭듯꟱뫳ꗵ귷돹곻뿽擿昁瘃挅笇礉匋伍␏⌑┓␕⸗", a_)))
					{
						num = (short)171180044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8F7;
				case 42:
					goto IL_F26;
				case 43:
					goto IL_B8E;
				case 44:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓釕뷗듙맛곝臟軡迣菥釧藩諫ꫭ釯蛱闳꛵諷闹髻韽泿朁眃夅䤇㬉㔋㨍␏␑", a_)))
					{
						num = (short)1711341601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DDB;
				case 45:
					this.dataConfigDataProfRandomHoldOffTime_A36552 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋跍뿏병닓뿕뿗黙뷛ꫝ臟닡難觥軧룩跫胭铯鷱駳뻵韷雹飻뇽替搁倃漅攇漉匋伍⌏␑ℓ⌕⨗", a_), global::CommonResources.AcgResources.ID_REGISTRATIONRANDOMHOLDOFFTIME);
					this.dataConfigDataProfRandomHoldOffTime_A36552.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataConfigDataProfRandomHoldOffTime_A36552.DataTransferOrder = 38;
					num = (short)31129660;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 46:
					if (producerFields != null)
					{
						num = (short)1493631044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11B5;
				case 47:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓釕뷗듙맛곝臟軡럣鏥諧駩迫鳭駯郱釳蓵뇷꫹뷻髽擿瀁愃甅笇唉䴋㰍ℏ⌑ℓℕ", a_)))
					{
						num = (short)1990787097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4F4;
				case 48:
					goto IL_10E0;
				case 49:
					this.dataProfGeneralMobileComputerIPAddress_A8523 = new global::AcpBusinessLayer.AcpIPAddressField(0L, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓釕뷗듙맛곝臟軡ꧣ觥諧菩胫语돯鷱駳蛵跷軹駻賽䧿刁䔃戅氇砉椋納挏䴑唓⸕ⴗ⠙⼛", a_), global::CommonResources.AcgResources.ID_SERIALLINK1ADDRESSESPEERIPADDRESS);
					this.dataProfGeneralMobileComputerIPAddress_A8523.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataProfGeneralMobileComputerIPAddress_A8523.DataTransferOrder = 7;
					this.dataProfGeneralMobileComputerIPAddress_A8523.EvaluateRecRefs = true;
					num = (short)1889730590;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 50:
					this.dataWideGeneralNATEnable_A38866 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋駍맏뛑뇓釕뷗듙맛곝臟軡ꫣ꟥볧꿩苫迭鋯黱釳꧵맷짹쓻웽㛿㐁", a_), global::CommonResources.AcgResources.ID_NATENABLE);
					this.dataWideGeneralNATEnable_A38866.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataWideGeneralNATEnable_A38866.DataTransferOrder = 4;
					num = (short)947191851;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 51:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋跍뿏병닓뿕뿗黙뷛ꫝ臟닡難觥軧ꏩ苫髭闯胱蟳迵请軹駻鏽䓿持瀃朅圇䬉㠋㰍⌏⨑┓", a_)))
					{
						num = (short)1384120383;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4A7;
				case 52:
					this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓뿕듗뿙꿛駝藟賡臣铥觧蛩껫뫭듯꟱뫳꛵鷷鿹軻럽僿䌁怃戅稇漉缋納儏愑朓缕缗琙焛笝丟嘡瀣弥堧伩猫漭Я̱Գе7", a_), global::CommonResources.AcgResources.ID_BLUETOOTHDIALUPNETWORKINGADDRESSESPEERIPADDRESSASSIGNMENTTYPE, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128LovStrs);
					this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.DataTransferOrder = 14;
					num = (short)840368128;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 53:
				{
					num = (short)71970650;
					short num3 = num;
					num = (short)1298411354;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4BF;
					default:
						num = (short)1804075008;
						if (num != 0)
						{
						}
						this.priorityScanRxVoiceInterruptsData_A42590 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("雅뫇ꏉꏋ볍맏ꛑ귓藕믗믙닛賝食듡诣迥诧迩ꗫ胭蓯韱蛳蓵跷諹裻跽䓿持瀃朅圇䬉㠋㰍┏⬑␓", a_), global::CommonResources.AcgResources.ID_PRIORITYSCANRXVOICEINTERRUPTSDATA);
						this.priorityScanRxVoiceInterruptsData_A42590.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
						this.priorityScanRxVoiceInterruptsData_A42590.DataTransferOrder = 73;
						num = (short)494075952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 54:
					goto IL_371;
				case 55:
					goto IL_4A7;
				case 56:
					this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220 = new global::AcpBusinessLayer.AcpIPAddressField(0L, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓釕뷗듙맛곝臟軡럣鏥諧駩迫鳭駯郱釳蓵맷鏹軻럽滿瘁愃琅渇欉漋欍夏䈑唓爕簗栙礛洝匟紡攣ἥᨧᠩᰫ", a_), global::CommonResources.AcgResources.ID_SUBSCRIBERAIRINTERFACEIPADDRESS);
					this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.DataTransferOrder = 31;
					num = (short)2033516610;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 57:
					goto IL_E8B;
				case 58:
					goto IL_2D7;
				case 59:
					goto IL_7FE;
				case 60:
					num = (short)898695169;
					if (num != 0)
					{
					}
					goto IL_323;
				case 61:
					this.dataProfGeneralAutoGenerateTargetIPAddress_A41697 = new global::AcpBusinessLayer.AcpFieldX<bool, bool>(true, new global::Features.Converters.UnpackAndPackAndInvertBooleanField(), this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓釕뷗듙맛곝臟軡ꗣ鏥鳧藩꯫语黯韱蛳韵賷鿹ꣻ鿽狿攁愃爅䄇娉䴋樍琏怑焓攕欗䔙崛⨝ᄟᐡᴣᄥ", a_), global::CommonResources.AcgResources.ID_AUTOGENERATETARGETIPADDRESS);
					this.dataProfGeneralAutoGenerateTargetIPAddress_A41697.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataProfGeneralAutoGenerateTargetIPAddress_A41697.DataTransferOrder = 40;
					num = (short)238485558;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 62:
					this.dataWideGeneralPeerIPAddressAssignmentType_A22263 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋駍맏뛑뇓釕뷗듙맛곝臟軡듣菥跧飩ꗫ뻭뇯雱郳蓵鷷觹迻뿽珿焁洃愅昇有椋怍搏䘑洓昕紗䔙崛Ⱍሟအሣᔥ", a_), global::CommonResources.AcgResources.ID_SERIALLINK1ADDRESSESPEERIPADDRESSASSIGNMENTTYPE, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataWideGeneralPeerIPAddressAssignmentType_A22263LovStrs);
					this.dataWideGeneralPeerIPAddressAssignmentType_A22263.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideGeneralPeerIPAddressAssignmentType_A22263.DataTransferOrder = 8;
					num = (short)1092616234;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 63:
				{
					num = (short)1971191808;
					short num4 = num;
					this.dataConfigDataProfIntersystemData_A42381 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋跍뿏병닓뿕뿗黙뷛ꫝ臟닡難觥軧ꏩ苫髭闯胱蟳迵请軹駻鏽䓿持瀃朅圇䬉㠋㰍⌏⨑┓", a_), global::CommonResources.AcgResources.ID_REGISTRATIONINTERSYSTEMDATA);
					this.dataConfigDataProfIntersystemData_A42381.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dataConfigDataProfIntersystemData_A42381.DataTransferOrder = 41;
					num = (short)1715208247;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 64:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓釕뷗듙맛곝臟軡꣣迥藧菩飫语铯냱蛳駵駷黹鿻鿽珿瘁嬃䜅〇㸉㼋㼍", a_)))
					{
						num = (short)1671168039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D7;
				case 65:
					goto IL_8F7;
				case 66:
					goto IL_627;
				case 67:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓釕뷗듙맛곝臟軡럣鏥諧駩迫鳭駯郱釳蓵맷鏹軻럽滿瘁愃琅渇欉漋欍夏䈑唓爕簗栙礛洝匟紡攣ἥᨧᠩᰫ", a_)))
					{
						num = (short)1459486776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_627;
				case 68:
					num = (short)1801453582;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 69:
					goto IL_3BF;
				case 70:
					goto IL_A46;
				case 71:
					this.dataProfGeneralDataScanPreambleLength_A7798 = new global::AcpBusinessLayer.AcpSimpleRangeField(20, this, global::AllFeatures.CodeplugGuid.b("苅꧇뻉귋黍ꋏ뷑닓釕뷗듙맛곝臟軡ꃣ蟥鳧诩뿫跭釯鳱ꓳ蓵鷷鯹釻鳽泿朁䠃挅昇洉砋昍伏匑⌓ℕ℗∙", a_), global::CommonResources.AcgResources.ID_DATASCANPREAMBLELENGTH, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 1);
					this.dataProfGeneralDataScanPreambleLength_A7798.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataProfGeneralDataScanPreambleLength_A7798.DataTransferOrder = 23;
					this.dataProfGeneralDataScanPreambleLength_A7798.ShowHexValue = false;
					num = (short)632422410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 72:
					goto IL_223;
				}
				IL_152:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1070989313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_17A:
				num = (short)937492507;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_223:
				num = (short)2078736420;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2D7:
				num = (short)1883570198;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_323:
				num = (short)802357264;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_371:
				num = (short)67371059;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3BF:
				num = (short)487129111;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_40D:
				num = (short)53739587;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_45B:
				num = (short)1439694854;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4A7:
				num = (short)1341259796;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4BF:
				if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雅뫇ꏉꏋ볍맏ꛑ귓藕믗믙닛賝食듡诣迥诧迩ꗫ胭蓯韱蛳蓵跷諹裻跽䓿持瀃朅圇䬉㠋㰍┏⬑␓", a_)))
				{
					num = (short)435814453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_4F4:
				num = (short)372244489;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5D8:
				num = (short)546439205;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_627:
				num = (short)463732744;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7FE:
				num = (short)43515921;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_84A:
				num = (short)1345781804;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8F7:
				num = (short)1968242717;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A46:
				num = (short)2121465887;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B45:
				num = (short)1879769112;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B8E:
				num = (short)403767337;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_DDB:
				num = (short)771883055;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E8B:
				num = (short)1519321107;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_ED8:
				num = (short)245825600;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F26:
				num = (short)2015690754;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10E0:
			IL_11B5:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臅귇꓉꧋볍뇏뻑", a_);
			base.Id = 10121;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600AD0C RID: 44300 RVA: 0x00A12070 File Offset: 0x00A10270
		public override void PopulateReferences()
		{
			short num = (short)69402625;
			if (num != 0)
			{
			}
			num = (short)1425045634;
			short num2 = num;
			num = (short)143423618;
			switch (num2 == num)
			{
			}
			num = (short)481689600;
			if (num != 0)
			{
			}
			num = (short)434896896;
			short num3 = num;
		}

		// Token: 0x0600AD0D RID: 44301 RVA: 0x00A12118 File Offset: 0x00A10318
		public override void DropReferences()
		{
			short num = (short)1208714871;
			short num2 = num;
			num = (short)330991223;
			switch (num2 == num)
			{
			}
			num = (short)372178944;
			if (num != 0)
			{
			}
			num = (short)981139457;
			if (num != 0)
			{
			}
			num = (short)605290496;
			short num3 = num;
		}

		// Token: 0x0600AD0E RID: 44302 RVA: 0x00A121C0 File Offset: 0x00A103C0
		public override void SetConstraints()
		{
			short num = (short)162660353;
			if (num != 0)
			{
			}
			num = (short)335852872;
			short num2 = num;
			num = (short)554743112;
			switch (num2 == num)
			{
			}
			num = (short)448331776;
			if (num != 0)
			{
			}
			num = (short)788135936;
			short num3 = num;
			this.dataProfGeneralDataScanPreambleLength_A7798.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfileTypeIsConventional);
			this.dataProfGeneralLimitedBroadcast_A8431.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfileTypeIsLMR);
			this.dataProfGeneralLimitedBroadcast_A8431.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfATAKDataEnableChannels);
			this.dataProfGeneralMobileComputerIPAddress_A8523.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfileTypeIsCnvPacketDataModeIsFNEAndAutoGenIpAddrDisabledNATEnableDisabled);
			this.dataProfGeneralMobileComputerIPAddress_A8523.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conEnsureSameSubnetBetweenSubscriberAndPeerIP);
			this.dataProfGeneralMobileComputerIPAddress_A8523.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataPrfTypeIsConventionalAndAutoGenIpAddrDisabledWithRMC);
			this.dataProfGeneralMobileComputerIPAddress_A8523.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfileTypeIsConventionalAndAutoGenIpAddrDisabledEditblForRMC);
			this.dataProfGeneralPacketDataMode_A8689.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConPacketDataModeValid);
			this.dataProfGeneralPacketDataMode_A8689.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfileTypeIsConventional);
			this.trkSysLabtoolRxVoiceInterruptsData_A9043.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfileTypeTrunking);
			this.trkSysLabtoolRxVoiceInterruptsData_A9043.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conTrkSysTypeIsTrunking);
			this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfileTypeIsConventionalAndAutoGenIpAddrDisabled);
			this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conEnsureSubscriberAirInterfaceIPAddressDifferentIpAddress);
			this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataPrfTypeIsConventionalAndAutoGenIpAddrDisabledWithRMC);
			this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conNonEditableWhenOpenFromRMC);
			this.dataProfGeneralAutoGenerateIPAddress_A19320.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conAutoGenerateIPAddressIsApplicable);
			this.dataProfGeneralAutoGenerateIPAddress_A19320.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfileTypeIsConventionalForPortable);
			this.dataProfGeneralSubscriberIPAddress_A21157.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfileTypeIsCnvPacketDataModeIsFNEAndAutoGenIpAddrDisabledNATEnableDisabled);
			this.dataProfGeneralSubscriberIPAddress_A21157.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conEnsureSubscriberIPAddressDifferentIpAddress);
			this.dataProfGeneralSubscriberIPAddress_A21157.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataPrfTypeIsConventionalAndAutoGenIpAddrDisabledWithRMC);
			this.dataProfGeneralSubscriberIPAddress_A21157.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfileTypeIsConventionalAndAutoGenIpAddrDisabledEditblForRMC);
			this.dataProfGeneralDataProfileType_A21320.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conCallGroupIDConstraint);
			this.dataProfGeneralDataProfileType_A21320.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conSetDataPrfPeerIpSubIpPeerIpAssignTypeValue);
			this.dataWideGeneralPeerIPAddressAssignmentType_A22263.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfileTypeIsCnvPacketDataModeIsFNEAndAutoGenIpAddrDisabledNATEnableDisabled);
			this.dataWideGeneralPeerIPAddressAssignmentType_A22263.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataPrfTypeIsConventionalAndAutoGenIpAddrDisabled);
			this.dataWideGeneralPeerIPAddressAssignmentType_A22263.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfileTypeIsConventionalAndAutoGenIpAddrDisabledEditbl);
			this.dataConfigDataProfIPHeaderCompressionEnable_A36190.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfTypeIsTrkAndDataRegVerIsSNDCPv3);
			this.dataConfigDataProfIPHeaderCompressionEnable_A36190.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfileTypeTrunking);
			this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conPackDataRegVerValid);
			this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conTrkSysTypeIsTrunking);
			this.dataConfigDataProfContextActivationHoldoffTime_A36551.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conTrkSysTypeIsTrunking);
			this.dataConfigDataProfRandomHoldOffTime_A36552.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conTrkSysTypeIsTrunking);
			this.dataProfGeneralQueueDwellTimersec_A8806.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfileTypeIsLMR);
			this.dataWideGeneralNATEnable_A38866.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConNATEableAvaliable);
			this.dataWideGeneralNATEnable_A38866.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfNATEableValid);
			this.dataWideGeneralNATEnable_A38866.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProfileNATEnabledVisible);
			this.dataProfilesGeneralBTDUNSUIPAddress_A41126.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConBluetoothEnableIsEnabledDataProfileTypeIsConventionalAndAutoGenIpAddrDisabledAndDataModeIsFNEAndNATEnableDisabled);
			this.dataProfilesGeneralBTDUNSUIPAddress_A41126.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProBTDUNSUIPAddressesIsValid);
			this.dataProfilesGeneralBTDUNSUIPAddress_A41126.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataPrfTypeIsConventionalAndAutoGenIpAddrDisabledWithRMC);
			this.dataProfilesGeneralBTDUNSUIPAddress_A41126.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfileTypeIsConventionalAndAutoGenIpAddrDisabledEditblForRMC);
			this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProBTDUNPeerIPAddressesIsApplicable);
			this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConDataProBTDUNPeerIPAddressesIsValid);
			this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataPrfTypeIsConventionalAndAutoGenIpAddrDisabledWithRMC);
			this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfileTypeIsConventionalAndAutoGenIpAddrDisabledEditblForRMC);
			this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.ConBluetoothEnableIsEnabledDataProfileTypeIsConventionalAndAutoGenIpAddrDisabledAndDataModeIsFNEAndNATEnableDisabled);
			this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataPrfTypeIsConventionalAndAutoGenIpAddrDisabled);
			this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfileTypeIsConventionalAndAutoGenIpAddrDisabledEditbl);
			this.dataProfGeneralAutoGenerateTargetIPAddress_A41697.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conAutoGenerateTargetIPAddressIsApplicable);
			this.dataProfGeneralAutoGenerateTargetIPAddress_A41697.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfileTypeIsConventionalForPortable);
			this.dataConfigDataProfIntersystemData_A42381.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conTrkSysTypeIsTrunking);
			this.priorityScanRxVoiceInterruptsData_A42590.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfileTypeTrunkingAndRID);
			this.priorityScanRxVoiceInterruptsData_A42590.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conTrkSysTypeIsTrunking);
		}

		// Token: 0x0600AD0F RID: 44303 RVA: 0x00A12714 File Offset: 0x00A10914
		public override void SetupDependencies()
		{
			short num = (short)617742337;
			if (num != 0)
			{
			}
			num = (short)37651255;
			short num2 = num;
			num = (short)364479287;
			switch (num2 == num)
			{
			}
			num = (short)1816199168;
			if (num != 0)
			{
			}
			num = (short)1099890688;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
			this.dataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfGeneralDataScanPreambleLength_A7798);
			this.dataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfGeneralLimitedBroadcast_A8431);
			this.dataProfGeneralSubscriberIPAddress_A21157.AddDependentObject(this.dataProfGeneralMobileComputerIPAddress_A8523);
			this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.AddDependentObject(this.dataProfGeneralMobileComputerIPAddress_A8523);
			this.RefDataWide.General.DataWideGeneralSubscriberIPAddress1_A9222.AddDependentObject(this.dataProfGeneralMobileComputerIPAddress_A8523);
			this.RefRadioWide.Features.RadWideFeaturesZoneCloneEnable_43130.AddDependentObject(this.dataProfGeneralMobileComputerIPAddress_A8523);
			this.dataProfGeneralAutoGenerateIPAddress_A19320.AddDependentObject(this.dataProfGeneralMobileComputerIPAddress_A8523);
			this.dataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfGeneralMobileComputerIPAddress_A8523);
			this.dataProfGeneralPacketDataMode_A8689.AddDependentObject(this.dataProfGeneralMobileComputerIPAddress_A8523);
			this.dataWideGeneralNATEnable_A38866.AddDependentObject(this.dataProfGeneralMobileComputerIPAddress_A8523);
			this.dataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfGeneralPacketDataMode_A8689);
			this.dataProfGeneralDataProfileType_A21320.AddDependentObject(this.trkSysLabtoolRxVoiceInterruptsData_A9043);
			this.dataProfGeneralAutoGenerateIPAddress_A19320.AddDependentObject(this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220);
			this.dataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220);
			this.dataProfGeneralMobileComputerIPAddress_A8523.AddDependentObject(this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220);
			this.dataProfGeneralSubscriberIPAddress_A21157.AddDependentObject(this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220);
			this.dataProfilesGeneralBTDUNSUIPAddress_A41126.AddDependentObject(this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220);
			this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.AddDependentObject(this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220);
			dataProfiles.Features.DataProfFeaturesAutomaticRegistrationServerAddress_A7524.AddDependentObject(this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220);
			dataProfiles.Features.DataProfFeaturesARSMode_A7465.AddDependentObject(this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220);
			this.RefDataWide.General.DataWideGeneralPeerIPAddress1_A8524.AddDependentObject(this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220);
			this.RefDataWide.General.DataWideGeneralSubscriberIPAddress1_A9222.AddDependentObject(this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220);
			this.dataProfGeneralPacketDataMode_A8689.AddDependentObject(this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220);
			this.dataWideGeneralNATEnable_A38866.AddDependentObject(this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220);
			this.RefRadioWide.Bluetooth.RadWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220);
			this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.AddDependentObject(this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220);
			this.RefRadioWide.Features.RadWideFeaturesZoneCloneEnable_43130.AddDependentObject(this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220);
			this.dataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfGeneralAutoGenerateIPAddress_A19320);
			this.dataProfGeneralAutoGenerateIPAddress_A19320.AddDependentObject(this.dataProfGeneralSubscriberIPAddress_A21157);
			this.dataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfGeneralSubscriberIPAddress_A21157);
			this.dataProfGeneralPacketDataMode_A8689.AddDependentObject(this.dataProfGeneralSubscriberIPAddress_A21157);
			this.dataWideGeneralNATEnable_A38866.AddDependentObject(this.dataProfGeneralSubscriberIPAddress_A21157);
			this.dataProfGeneralMobileComputerIPAddress_A8523.AddDependentObject(this.dataProfGeneralSubscriberIPAddress_A21157);
			this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.AddDependentObject(this.dataProfGeneralSubscriberIPAddress_A21157);
			dataProfiles.Features.DataProfFeaturesAutomaticRegistrationServerAddress_A7524.AddDependentObject(this.dataProfGeneralSubscriberIPAddress_A21157);
			this.RefRadioWide.Features.RadWideFeaturesZoneCloneEnable_43130.AddDependentObject(this.dataProfGeneralSubscriberIPAddress_A21157);
			this.RefDataWide.General.DataWideGeneralSubscriberIPAddress1_A9222.AddDependentObject(this.dataProfGeneralDataProfileType_A21320);
			this.RefDataWide.General.DataWideGeneralPeerIPAddress1_A8524.AddDependentObject(this.dataProfGeneralDataProfileType_A21320);
			this.RefDataWide.General.DataWideGeneralPeerIPAddressAssignmentType1_A22376.AddDependentObject(this.dataProfGeneralDataProfileType_A21320);
			this.dataProfGeneralSubscriberIPAddress_A21157.AddDependentObject(this.dataProfGeneralDataProfileType_A21320);
			this.dataProfGeneralMobileComputerIPAddress_A8523.AddDependentObject(this.dataProfGeneralDataProfileType_A21320);
			this.dataWideGeneralPeerIPAddressAssignmentType_A22263.AddDependentObject(this.dataProfGeneralDataProfileType_A21320);
			this.RefDataWide.General.DataWideGeneralBTDUNSUIPAddress_A41120.AddDependentObject(this.dataProfGeneralDataProfileType_A21320);
			this.RefDataWide.General.DataWideGeneralBTDUNPeerIPAddress_A41123.AddDependentObject(this.dataProfGeneralDataProfileType_A21320);
			this.RefDataWide.General.DataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.AddDependentObject(this.dataProfGeneralDataProfileType_A21320);
			this.dataProfilesGeneralBTDUNSUIPAddress_A41126.AddDependentObject(this.dataProfGeneralDataProfileType_A21320);
			this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.AddDependentObject(this.dataProfGeneralDataProfileType_A21320);
			this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.AddDependentObject(this.dataProfGeneralDataProfileType_A21320);
			this.dataProfGeneralAutoGenerateIPAddress_A19320.AddDependentObject(this.dataWideGeneralPeerIPAddressAssignmentType_A22263);
			this.dataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataWideGeneralPeerIPAddressAssignmentType_A22263);
			this.dataProfGeneralPacketDataMode_A8689.AddDependentObject(this.dataWideGeneralPeerIPAddressAssignmentType_A22263);
			this.dataWideGeneralNATEnable_A38866.AddDependentObject(this.dataWideGeneralPeerIPAddressAssignmentType_A22263);
			this.dataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataConfigDataProfIPHeaderCompressionEnable_A36190);
			this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210.AddDependentObject(this.dataConfigDataProfIPHeaderCompressionEnable_A36190);
			this.dataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210);
			dataProfiles.EnhancedData.DatProFeaturesPortListSelection_A42011.AddDependentObject(this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210);
			this.dataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataConfigDataProfContextActivationHoldoffTime_A36551);
			this.dataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataConfigDataProfRandomHoldOffTime_A36552);
			this.dataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfGeneralQueueDwellTimersec_A8806);
			this.dataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataWideGeneralNATEnable_A38866);
			this.dataProfGeneralPacketDataMode_A8689.AddDependentObject(this.dataWideGeneralNATEnable_A38866);
			this.dataProfGeneralAutoGenerateIPAddress_A19320.AddDependentObject(this.dataProfilesGeneralBTDUNSUIPAddress_A41126);
			this.dataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfilesGeneralBTDUNSUIPAddress_A41126);
			this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.AddDependentObject(this.dataProfilesGeneralBTDUNSUIPAddress_A41126);
			this.dataProfGeneralSubscriberIPAddress_A21157.AddDependentObject(this.dataProfilesGeneralBTDUNSUIPAddress_A41126);
			this.dataProfGeneralMobileComputerIPAddress_A8523.AddDependentObject(this.dataProfilesGeneralBTDUNSUIPAddress_A41126);
			this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.AddDependentObject(this.dataProfilesGeneralBTDUNSUIPAddress_A41126);
			this.RefRadioWide.Features.RadWideFeaturesZoneCloneEnable_43130.AddDependentObject(this.dataProfilesGeneralBTDUNSUIPAddress_A41126);
			this.RefRadioWide.Bluetooth.RadWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.dataProfilesGeneralBTDUNSUIPAddress_A41126);
			this.dataProfGeneralPacketDataMode_A8689.AddDependentObject(this.dataProfilesGeneralBTDUNSUIPAddress_A41126);
			this.dataWideGeneralNATEnable_A38866.AddDependentObject(this.dataProfilesGeneralBTDUNSUIPAddress_A41126);
			this.dataProfGeneralAutoGenerateIPAddress_A19320.AddDependentObject(this.dataProfilesGeneralBTDUNPeerIPAddress_A41127);
			this.dataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfilesGeneralBTDUNPeerIPAddress_A41127);
			this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.AddDependentObject(this.dataProfilesGeneralBTDUNPeerIPAddress_A41127);
			this.RefRadioWide.Bluetooth.RadWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.dataProfilesGeneralBTDUNPeerIPAddress_A41127);
			this.dataProfGeneralPacketDataMode_A8689.AddDependentObject(this.dataProfilesGeneralBTDUNPeerIPAddress_A41127);
			this.dataWideGeneralNATEnable_A38866.AddDependentObject(this.dataProfilesGeneralBTDUNPeerIPAddress_A41127);
			this.dataProfilesGeneralBTDUNSUIPAddress_A41126.AddDependentObject(this.dataProfilesGeneralBTDUNPeerIPAddress_A41127);
			this.dataProfGeneralMobileComputerIPAddress_A8523.AddDependentObject(this.dataProfilesGeneralBTDUNPeerIPAddress_A41127);
			this.dataProfGeneralSubscriberIPAddress_A21157.AddDependentObject(this.dataProfilesGeneralBTDUNPeerIPAddress_A41127);
			this.RefRadioWide.Features.RadWideFeaturesZoneCloneEnable_43130.AddDependentObject(this.dataProfilesGeneralBTDUNPeerIPAddress_A41127);
			this.dataProfGeneralAutoGenerateIPAddress_A19320.AddDependentObject(this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128);
			this.dataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128);
			this.RefRadioWide.Bluetooth.RadWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128);
			this.dataProfGeneralPacketDataMode_A8689.AddDependentObject(this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128);
			this.dataWideGeneralNATEnable_A38866.AddDependentObject(this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128);
			this.dataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfGeneralAutoGenerateTargetIPAddress_A41697);
			this.dataProfGeneralAutoGenerateIPAddress_A19320.AddDependentObject(this.dataProfGeneralAutoGenerateTargetIPAddress_A41697);
			this.dataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataConfigDataProfIntersystemData_A42381);
			this.dataProfGeneralDataProfileType_A21320.AddDependentObject(this.priorityScanRxVoiceInterruptsData_A42590);
			this.trkSysLabtoolRxVoiceInterruptsData_A9043.AddDependentObject(this.priorityScanRxVoiceInterruptsData_A42590);
			this.dataProfGeneralMobileComputerIPAddress_A8523.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10066] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General).DataWideGeneralPeerIPAddress1_A8524);
			this.dataProfGeneralMobileComputerIPAddress_A8523.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10102] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideUserInformationandPasswordsSoftIDUsername_A9169);
			this.dataProfGeneralMobileComputerIPAddress_A8523.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10066] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General).DataWideGeneralSubscriberIPAddress1_A9222);
			this.dataProfGeneralMobileComputerIPAddress_A8523.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10102] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideUserInformationandPasswordsRadioAlias_A8829);
			this.dataProfGeneralMobileComputerIPAddress_A8523.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10066] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General).DataWideGeneralBTDUNSUIPAddress_A41120);
			this.dataProfGeneralMobileComputerIPAddress_A8523.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10066] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General).DataWideGeneralBTDUNPeerIPAddress_A41123);
			this.dataProfGeneralMobileComputerIPAddress_A8523.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10630] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth).RadWideBluetoothFriendlyName_A41181);
			this.dataProfGeneralMobileComputerIPAddress_A8523.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10102] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideUserInformationandPINPassword_41303);
			this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10066] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General).DataWideGeneralPeerIPAddress1_A8524);
			this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10066] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General).DataWideGeneralSubscriberIPAddress1_A9222);
			this.dataProfGeneralSubscriberIPAddress_A21157.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10066] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General).DataWideGeneralPeerIPAddress1_A8524);
			this.dataProfGeneralSubscriberIPAddress_A21157.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10102] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideUserInformationandPasswordsSoftIDUsername_A9169);
			this.dataProfGeneralSubscriberIPAddress_A21157.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10066] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General).DataWideGeneralSubscriberIPAddress1_A9222);
			this.dataProfGeneralSubscriberIPAddress_A21157.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10102] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideUserInformationandPasswordsRadioAlias_A8829);
			this.dataProfGeneralSubscriberIPAddress_A21157.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10066] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General).DataWideGeneralBTDUNSUIPAddress_A41120);
			this.dataProfGeneralSubscriberIPAddress_A21157.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10066] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General).DataWideGeneralBTDUNPeerIPAddress_A41123);
			this.dataProfGeneralSubscriberIPAddress_A21157.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10630] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth).RadWideBluetoothFriendlyName_A41181);
			this.dataProfGeneralSubscriberIPAddress_A21157.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10102] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideUserInformationandPINPassword_41303);
			this.dataProfilesGeneralBTDUNSUIPAddress_A41126.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10066] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General).DataWideGeneralPeerIPAddress1_A8524);
			this.dataProfilesGeneralBTDUNSUIPAddress_A41126.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10102] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideUserInformationandPasswordsSoftIDUsername_A9169);
			this.dataProfilesGeneralBTDUNSUIPAddress_A41126.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10066] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General).DataWideGeneralSubscriberIPAddress1_A9222);
			this.dataProfilesGeneralBTDUNSUIPAddress_A41126.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10102] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideUserInformationandPasswordsRadioAlias_A8829);
			this.dataProfilesGeneralBTDUNSUIPAddress_A41126.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10066] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General).DataWideGeneralBTDUNSUIPAddress_A41120);
			this.dataProfilesGeneralBTDUNSUIPAddress_A41126.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10066] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General).DataWideGeneralBTDUNPeerIPAddress_A41123);
			this.dataProfilesGeneralBTDUNSUIPAddress_A41126.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10630] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth).RadWideBluetoothFriendlyName_A41181);
			this.dataProfilesGeneralBTDUNSUIPAddress_A41126.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10102] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideUserInformationandPINPassword_41303);
			this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10066] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General).DataWideGeneralPeerIPAddress1_A8524);
			this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10102] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideUserInformationandPasswordsSoftIDUsername_A9169);
			this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10066] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General).DataWideGeneralSubscriberIPAddress1_A9222);
			this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10102] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideUserInformationandPasswordsRadioAlias_A8829);
			this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10066] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General).DataWideGeneralBTDUNSUIPAddress_A41120);
			this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10066] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General).DataWideGeneralBTDUNPeerIPAddress_A41123);
			this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10630] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth).RadWideBluetoothFriendlyName_A41181);
			this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10102] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideUserInformationandPINPassword_41303);
		}

		// Token: 0x170056B5 RID: 22197
		// (get) Token: 0x0600AD10 RID: 44304 RVA: 0x00A13558 File Offset: 0x00A11758
		public bool HasDiffs
		{
			get
			{
				short num = (short)875031905;
				short num2 = num;
				num = (short)112782689;
				switch (num2 == num)
				{
				}
				num = (short)1128398848;
				if (num != 0)
				{
				}
				num = (short)1973747713;
				if (num != 0)
				{
				}
				num = (short)253034496;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x170056B6 RID: 22198
		// (get) Token: 0x0600AD11 RID: 44305 RVA: 0x00A13608 File Offset: 0x00A11808
		// (set) Token: 0x0600AD12 RID: 44306 RVA: 0x00A136BC File Offset: 0x00A118BC
		public int DataProfGeneralDataScanPreambleLength_A7798Value
		{
			get
			{
				short num = (short)1251999745;
				if (num != 0)
				{
				}
				num = (short)298472347;
				short num2 = num;
				num = (short)1489130395;
				switch (num2 == num)
				{
				}
				num = (short)411762688;
				if (num != 0)
				{
				}
				num = (short)798556160;
				short num3 = num;
				return this.dataProfGeneralDataScanPreambleLength_A7798.Value;
			}
			set
			{
				short num = (short)613223252;
				short num2 = num;
				num = (short)1993542484;
				switch (num2 == num)
				{
				}
				num = (short)1514340353;
				if (num != 0)
				{
				}
				num = (short)1374486528;
				if (num != 0)
				{
				}
				num = (short)1898184704;
				short num3 = num;
				this.dataProfGeneralDataScanPreambleLength_A7798.Value = value;
			}
		}

		// Token: 0x170056B7 RID: 22199
		// (get) Token: 0x0600AD13 RID: 44307 RVA: 0x00A13770 File Offset: 0x00A11970
		public global::AcpBusinessLayer.AcpSimpleRangeField DataProfGeneralDataScanPreambleLength_A7798
		{
			get
			{
				short num = (short)1893993405;
				short num2 = num;
				num = (short)1757744061;
				switch (num2 == num)
				{
				}
				num = (short)1555103745;
				if (num != 0)
				{
				}
				num = (short)1170276352;
				if (num != 0)
				{
				}
				num = (short)484507648;
				short num3 = num;
				return this.dataProfGeneralDataScanPreambleLength_A7798;
			}
		}

		// Token: 0x170056B8 RID: 22200
		// (get) Token: 0x0600AD14 RID: 44308 RVA: 0x00A13820 File Offset: 0x00A11A20
		// (set) Token: 0x0600AD15 RID: 44309 RVA: 0x00A138D4 File Offset: 0x00A11AD4
		public string DataProfGeneralDataScanPreambleLength_A7798_UIValue
		{
			get
			{
				short num = (short)590610433;
				if (num != 0)
				{
				}
				num = (short)1684589345;
				short num2 = num;
				num = (short)1916652321;
				switch (num2 == num)
				{
				}
				num = (short)1738080256;
				if (num != 0)
				{
				}
				num = (short)537788416;
				short num3 = num;
				return this.dataProfGeneralDataScanPreambleLength_A7798.UIValue;
			}
			set
			{
				short num = (short)1505361921;
				if (num != 0)
				{
				}
				num = (short)566830666;
				short num2 = num;
				num = (short)122627658;
				switch (num2 == num)
				{
				}
				num = (short)204996608;
				if (num != 0)
				{
				}
				num = (short)1803878400;
				short num3 = num;
				this.dataProfGeneralDataScanPreambleLength_A7798.UIValue = value;
			}
		}

		// Token: 0x170056B9 RID: 22201
		// (get) Token: 0x0600AD16 RID: 44310 RVA: 0x00A1398C File Offset: 0x00A11B8C
		// (set) Token: 0x0600AD17 RID: 44311 RVA: 0x00A13A40 File Offset: 0x00A11C40
		internal int DataProfGeneralDataScanPreambleLength_A7798Min
		{
			get
			{
				short num = (short)1532323231;
				short num2 = num;
				num = (short)1884513695;
				switch (num2 == num)
				{
				}
				num = (short)1193345025;
				if (num != 0)
				{
				}
				num = (short)365363200;
				if (num != 0)
				{
				}
				num = (short)243859456;
				short num3 = num;
				return this.dataProfGeneralDataScanPreambleLength_A7798.Min;
			}
			set
			{
				short num = (short)1721872594;
				short num2 = num;
				num = (short)225489106;
				switch (num2 == num)
				{
				}
				num = (short)794296320;
				if (num != 0)
				{
				}
				num = (short)1018888193;
				if (num != 0)
				{
				}
				num = (short)1822883840;
				short num3 = num;
				this.dataProfGeneralDataScanPreambleLength_A7798.Min = value;
			}
		}

		// Token: 0x170056BA RID: 22202
		// (get) Token: 0x0600AD18 RID: 44312 RVA: 0x00A13AF8 File Offset: 0x00A11CF8
		// (set) Token: 0x0600AD19 RID: 44313 RVA: 0x00A13BB0 File Offset: 0x00A11DB0
		internal int DataProfGeneralDataScanPreambleLength_A7798Max
		{
			get
			{
				short num = (short)577175553;
				if (num != 0)
				{
				}
				num = (short)1359085568;
				short num2 = num;
				num = (short)1550649030;
				short num3 = num;
				num = (short)660014790;
				switch (num3 == num)
				{
				}
				num = (short)1290207232;
				if (num != 0)
				{
				}
				return this.dataProfGeneralDataScanPreambleLength_A7798.Max;
			}
			set
			{
				short num = (short)1116471297;
				if (num != 0)
				{
				}
				num = (short)1905197056;
				short num2 = num;
				num = (short)28486418;
				short num3 = num;
				num = (short)106933010;
				switch (num3 == num)
				{
				}
				num = (short)2072051712;
				if (num != 0)
				{
				}
				this.dataProfGeneralDataScanPreambleLength_A7798.Max = value;
			}
		}

		// Token: 0x170056BB RID: 22203
		// (get) Token: 0x0600AD1A RID: 44314 RVA: 0x00A13C68 File Offset: 0x00A11E68
		// (set) Token: 0x0600AD1B RID: 44315 RVA: 0x00A13D20 File Offset: 0x00A11F20
		internal int DataProfGeneralDataScanPreambleLength_A7798Step
		{
			get
			{
				short num = (short)160380398;
				short num2 = num;
				num = (short)606680558;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2139357184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1408499713;
				if (num != 0)
				{
				}
				num = (short)1016659968;
				if (num != 0)
				{
				}
				return this.dataProfGeneralDataScanPreambleLength_A7798.StepSize;
			}
			set
			{
				short num = (short)1490331611;
				short num2 = num;
				num = (short)1085515739;
				switch (num2 == num)
				{
				default:
				{
					num = (short)883884032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)211550209;
				if (num != 0)
				{
				}
				num = (short)1984102400;
				if (num != 0)
				{
				}
				this.dataProfGeneralDataScanPreambleLength_A7798.StepSize = value;
			}
		}

		// Token: 0x170056BC RID: 22204
		// (get) Token: 0x0600AD1C RID: 44316 RVA: 0x00A13DD4 File Offset: 0x00A11FD4
		// (set) Token: 0x0600AD1D RID: 44317 RVA: 0x00A13E88 File Offset: 0x00A12088
		public bool DataProfGeneralDataScanPreambleLength_A7798_Applicable
		{
			get
			{
				short num = (short)205249142;
				short num2 = num;
				num = (short)1637210742;
				switch (num2 == num)
				{
				default:
				{
					num = (short)571277312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)195821569;
				if (num != 0)
				{
				}
				num = (short)332529664;
				if (num != 0)
				{
				}
				return this.dataProfGeneralDataScanPreambleLength_A7798.Applicable;
			}
			set
			{
				short num = (short)343525938;
				short num2 = num;
				num = (short)3197490;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1991639040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)945094657;
				if (num != 0)
				{
				}
				num = (short)419299328;
				if (num != 0)
				{
				}
				this.dataProfGeneralDataScanPreambleLength_A7798.Applicable = value;
			}
		}

		// Token: 0x170056BD RID: 22205
		// (get) Token: 0x0600AD1E RID: 44318 RVA: 0x00A13F40 File Offset: 0x00A12140
		// (set) Token: 0x0600AD1F RID: 44319 RVA: 0x00A13FF4 File Offset: 0x00A121F4
		public bool DataProfGeneralDataScanPreambleLength_A7798_Valid
		{
			get
			{
				short num = (short)1418877793;
				short num2 = num;
				num = (short)1666866017;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1822883840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)16646145;
				if (num != 0)
				{
				}
				num = (short)1416691712;
				if (num != 0)
				{
				}
				return this.dataProfGeneralDataScanPreambleLength_A7798.Valid;
			}
			set
			{
				short num = (short)1837422586;
				short num2 = num;
				num = (short)1017370618;
				switch (num2 == num)
				{
				default:
				{
					num = (short)252444672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1344012289;
				if (num != 0)
				{
				}
				num = (short)473694208;
				if (num != 0)
				{
				}
				this.dataProfGeneralDataScanPreambleLength_A7798.Valid = value;
			}
		}

		// Token: 0x170056BE RID: 22206
		// (get) Token: 0x0600AD20 RID: 44320 RVA: 0x00A140A8 File Offset: 0x00A122A8
		// (set) Token: 0x0600AD21 RID: 44321 RVA: 0x00A14160 File Offset: 0x00A12360
		public bool DataProfGeneralDataScanPreambleLength_A7798_Visible
		{
			get
			{
				short num = (short)1199218706;
				short num2 = num;
				num = (short)1197907986;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1470955520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)6684672;
				if (num != 0)
				{
				}
				num = 1;
				if (num != 0)
				{
				}
				return this.dataProfGeneralDataScanPreambleLength_A7798.Visible;
			}
			set
			{
				short num = (short)1731592298;
				short num2 = num;
				num = (short)966983786;
				switch (num2 == num)
				{
				default:
				{
					num = (short)889651200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1464401921;
				if (num != 0)
				{
				}
				num = (short)164823040;
				if (num != 0)
				{
				}
				this.dataProfGeneralDataScanPreambleLength_A7798.Visible = value;
			}
		}

		// Token: 0x170056BF RID: 22207
		// (get) Token: 0x0600AD22 RID: 44322 RVA: 0x00A14214 File Offset: 0x00A12414
		// (set) Token: 0x0600AD23 RID: 44323 RVA: 0x00A142C8 File Offset: 0x00A124C8
		public bool DataProfGeneralDataScanPreambleLength_A7798_Editable
		{
			get
			{
				short num = (short)803077127;
				short num2 = num;
				num = (short)1935670279;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1544028160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)955383808;
				if (num != 0)
				{
				}
				num = (short)789839873;
				if (num != 0)
				{
				}
				return this.dataProfGeneralDataScanPreambleLength_A7798.Editable;
			}
			set
			{
				short num = (short)1496234545;
				short num2 = num;
				num = (short)524401201;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1199570944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)764215296;
				if (num != 0)
				{
				}
				num = (short)1231421441;
				if (num != 0)
				{
				}
				this.dataProfGeneralDataScanPreambleLength_A7798.Editable = value;
			}
		}

		// Token: 0x170056C0 RID: 22208
		// (get) Token: 0x0600AD24 RID: 44324 RVA: 0x00A14380 File Offset: 0x00A12580
		internal string DataProfGeneralDataScanPreambleLength_A7798_UILabel
		{
			get
			{
				short num = (short)1530524023;
				short num2 = num;
				num = (short)661778807;
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
				num = (short)167510017;
				if (num != 0)
				{
				}
				num = (short)856424448;
				if (num != 0)
				{
				}
				return this.dataProfGeneralDataScanPreambleLength_A7798.UIName;
			}
		}

		// Token: 0x170056C1 RID: 22209
		// (get) Token: 0x0600AD25 RID: 44325 RVA: 0x00A14438 File Offset: 0x00A12638
		// (set) Token: 0x0600AD26 RID: 44326 RVA: 0x00A144EC File Offset: 0x00A126EC
		internal bool DataProfGeneralDataScanPreambleLength_A7798_HiddenStatic
		{
			get
			{
				short num = (short)906421306;
				short num2 = num;
				num = (short)303883322;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1621884928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1388838912;
				if (num != 0)
				{
				}
				num = (short)1961099265;
				if (num != 0)
				{
				}
				return this.dataProfGeneralDataScanPreambleLength_A7798.HiddenStatic;
			}
			set
			{
				short num = (short)1989264504;
				short num2 = num;
				num = (short)274973816;
				switch (num2 == num)
				{
				default:
				{
					num = (short)95944704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)625410049;
				if (num != 0)
				{
				}
				num = (short)1378222080;
				if (num != 0)
				{
				}
				this.dataProfGeneralDataScanPreambleLength_A7798.HiddenStatic = value;
			}
		}

		// Token: 0x170056C2 RID: 22210
		// (get) Token: 0x0600AD27 RID: 44327 RVA: 0x00A145A0 File Offset: 0x00A127A0
		// (set) Token: 0x0600AD28 RID: 44328 RVA: 0x00A1465C File Offset: 0x00A1285C
		internal bool DataProfGeneralDataScanPreambleLength_A7798_HiddenDynamic
		{
			get
			{
				short num = (short)271501146;
				short num2 = num;
				num = (short)1562625882;
				switch (num2 == num)
				{
				default:
				{
					num = (short)690946048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1973026817;
				if (num != 0)
				{
				}
				num = (short)587792384;
				if (num != 0)
				{
				}
				return this.dataProfGeneralDataScanPreambleLength_A7798.HiddenDynamic;
			}
			set
			{
				short num = (short)963186755;
				short num2 = num;
				num = (short)126292035;
				switch (num2 == num)
				{
				default:
				{
					num = (short)289472512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)209584129;
				if (num != 0)
				{
				}
				num = (short)2061959168;
				if (num != 0)
				{
				}
				this.dataProfGeneralDataScanPreambleLength_A7798.HiddenDynamic = value;
			}
		}

		// Token: 0x170056C3 RID: 22211
		// (get) Token: 0x0600AD29 RID: 44329 RVA: 0x00A14710 File Offset: 0x00A12910
		public bool DataProfGeneralDataScanPreambleLength_A7798_HasDiffs
		{
			get
			{
				short num = (short)1955851337;
				short num2 = num;
				num = (short)27454537;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1918894080;
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
				num = (short)988938240;
				if (num != 0)
				{
				}
				return this.dataProfGeneralDataScanPreambleLength_A7798._HasDiffs;
			}
		}

		// Token: 0x170056C4 RID: 22212
		// (get) Token: 0x0600AD2A RID: 44330 RVA: 0x00A147C4 File Offset: 0x00A129C4
		// (set) Token: 0x0600AD2B RID: 44331 RVA: 0x00A14878 File Offset: 0x00A12A78
		public bool DataProfGeneralLimitedBroadcast_A8431Value
		{
			get
			{
				short num = (short)474104097;
				short num2 = num;
				num = (short)1500397857;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1219952640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1142292480;
				if (num != 0)
				{
				}
				num = (short)1135804417;
				if (num != 0)
				{
				}
				return this.dataProfGeneralLimitedBroadcast_A8431.Value;
			}
			set
			{
				short num = (short)1872487918;
				short num2 = num;
				num = (short)1002104302;
				switch (num2 == num)
				{
				default:
				{
					num = (short)296747008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)84869120;
				if (num != 0)
				{
				}
				num = (short)1981939713;
				if (num != 0)
				{
				}
				this.dataProfGeneralLimitedBroadcast_A8431.Value = value;
			}
		}

		// Token: 0x170056C5 RID: 22213
		// (get) Token: 0x0600AD2C RID: 44332 RVA: 0x00A14930 File Offset: 0x00A12B30
		public global::AcpBusinessLayer.AcpField<bool> DataProfGeneralLimitedBroadcast_A8431
		{
			get
			{
				short num = (short)79394154;
				short num2 = num;
				num = (short)163607914;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1832517632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)215613441;
				if (num != 0)
				{
				}
				num = (short)76414976;
				if (num != 0)
				{
				}
				return this.dataProfGeneralLimitedBroadcast_A8431;
			}
		}

		// Token: 0x170056C6 RID: 22214
		// (get) Token: 0x0600AD2D RID: 44333 RVA: 0x00A149E0 File Offset: 0x00A12BE0
		// (set) Token: 0x0600AD2E RID: 44334 RVA: 0x00A14A94 File Offset: 0x00A12C94
		public bool DataProfGeneralLimitedBroadcast_A8431_UIValue
		{
			get
			{
				short num = (short)1522913210;
				short num2 = num;
				num = (short)1323683770;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2029846528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)43384833;
				if (num != 0)
				{
				}
				num = (short)1538785280;
				if (num != 0)
				{
				}
				return this.dataProfGeneralLimitedBroadcast_A8431.Value;
			}
			set
			{
				short num = (short)1893805867;
				short num2 = num;
				num = (short)849096491;
				switch (num2 == num)
				{
				default:
				{
					num = (short)413728768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)117374976;
				if (num != 0)
				{
				}
				num = (short)1966342145;
				if (num != 0)
				{
				}
				this.dataProfGeneralLimitedBroadcast_A8431.Value = value;
			}
		}

		// Token: 0x170056C7 RID: 22215
		// (get) Token: 0x0600AD2F RID: 44335 RVA: 0x00A14B4C File Offset: 0x00A12D4C
		// (set) Token: 0x0600AD30 RID: 44336 RVA: 0x00A14C04 File Offset: 0x00A12E04
		public bool DataProfGeneralLimitedBroadcast_A8431_Applicable
		{
			get
			{
				short num = (short)1627673814;
				short num2 = num;
				num = (short)321606870;
				switch (num2 == num)
				{
				default:
				{
					num = (short)362479616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1472331777;
				if (num != 0)
				{
				}
				num = (short)647888896;
				if (num != 0)
				{
				}
				return this.dataProfGeneralLimitedBroadcast_A8431.Applicable;
			}
			set
			{
				short num = (short)313947317;
				short num2 = num;
				num = (short)1554019509;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2126905344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)426180608;
				if (num != 0)
				{
				}
				num = (short)732692481;
				if (num != 0)
				{
				}
				this.dataProfGeneralLimitedBroadcast_A8431.Applicable = value;
			}
		}

		// Token: 0x170056C8 RID: 22216
		// (get) Token: 0x0600AD31 RID: 44337 RVA: 0x00A14CB8 File Offset: 0x00A12EB8
		// (set) Token: 0x0600AD32 RID: 44338 RVA: 0x00A14D6C File Offset: 0x00A12F6C
		public bool DataProfGeneralLimitedBroadcast_A8431_Valid
		{
			get
			{
				short num = (short)1553439971;
				short num2 = num;
				num = (short)388013283;
				switch (num2 == num)
				{
				default:
				{
					num = (short)645726208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)948961280;
				if (num != 0)
				{
				}
				num = (short)84672513;
				if (num != 0)
				{
				}
				return this.dataProfGeneralLimitedBroadcast_A8431.Valid;
			}
			set
			{
				short num = (short)1649419038;
				short num2 = num;
				num = (short)1498620702;
				switch (num2 == num)
				{
				default:
				{
					num = (short)194248704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)817299456;
				if (num != 0)
				{
				}
				num = (short)1008402433;
				if (num != 0)
				{
				}
				this.dataProfGeneralLimitedBroadcast_A8431.Valid = value;
			}
		}

		// Token: 0x170056C9 RID: 22217
		// (get) Token: 0x0600AD33 RID: 44339 RVA: 0x00A14E20 File Offset: 0x00A13020
		// (set) Token: 0x0600AD34 RID: 44340 RVA: 0x00A14ED4 File Offset: 0x00A130D4
		public bool DataProfGeneralLimitedBroadcast_A8431_Visible
		{
			get
			{
				short num = (short)1527578625;
				if (num != 0)
				{
				}
				num = (short)1182400512;
				short num2 = num;
				num = (short)191038295;
				short num3 = num;
				num = (short)956498775;
				switch (num3 == num)
				{
				}
				num = (short)872873984;
				if (num != 0)
				{
				}
				return this.dataProfGeneralLimitedBroadcast_A8431.Visible;
			}
			set
			{
				short num = (short)251901653;
				short num2 = num;
				num = (short)1665906389;
				switch (num2 == num)
				{
				default:
				{
					num = (short)136314880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2000027649;
				if (num != 0)
				{
				}
				num = (short)895549440;
				if (num != 0)
				{
				}
				this.dataProfGeneralLimitedBroadcast_A8431.Visible = value;
			}
		}

		// Token: 0x170056CA RID: 22218
		// (get) Token: 0x0600AD35 RID: 44341 RVA: 0x00A14F88 File Offset: 0x00A13188
		// (set) Token: 0x0600AD36 RID: 44342 RVA: 0x00A1503C File Offset: 0x00A1323C
		public bool DataProfGeneralLimitedBroadcast_A8431_Editable
		{
			get
			{
				short num = (short)823460177;
				short num2 = num;
				num = (short)1432027473;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1298923520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2072772608;
				if (num != 0)
				{
				}
				num = (short)854327297;
				if (num != 0)
				{
				}
				return this.dataProfGeneralLimitedBroadcast_A8431.Editable;
			}
			set
			{
				short num = (short)1296914008;
				short num2 = num;
				num = (short)41965144;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1514078208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)334823425;
				if (num != 0)
				{
				}
				num = (short)546766848;
				if (num != 0)
				{
				}
				this.dataProfGeneralLimitedBroadcast_A8431.Editable = value;
			}
		}

		// Token: 0x170056CB RID: 22219
		// (get) Token: 0x0600AD37 RID: 44343 RVA: 0x00A150F4 File Offset: 0x00A132F4
		internal string DataProfGeneralLimitedBroadcast_A8431_UILabel
		{
			get
			{
				short num = (short)272967674;
				short num2 = num;
				num = (short)736962554;
				switch (num2 == num)
				{
				default:
				{
					num = (short)828440576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1184366592;
				if (num != 0)
				{
				}
				num = (short)453246977;
				if (num != 0)
				{
				}
				return this.dataProfGeneralLimitedBroadcast_A8431.UIName;
			}
		}

		// Token: 0x170056CC RID: 22220
		// (get) Token: 0x0600AD38 RID: 44344 RVA: 0x00A151AC File Offset: 0x00A133AC
		// (set) Token: 0x0600AD39 RID: 44345 RVA: 0x00A15260 File Offset: 0x00A13460
		internal bool DataProfGeneralLimitedBroadcast_A8431_HiddenStatic
		{
			get
			{
				short num = (short)582228042;
				short num2 = num;
				num = (short)1667373130;
				switch (num2 == num)
				{
				default:
				{
					num = (short)680853504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1730412545;
				if (num != 0)
				{
				}
				num = (short)124387328;
				if (num != 0)
				{
				}
				return this.dataProfGeneralLimitedBroadcast_A8431.HiddenStatic;
			}
			set
			{
				short num = (short)1348075521;
				if (num != 0)
				{
				}
				num = (short)1756299264;
				short num2 = num;
				num = (short)1760902455;
				short num3 = num;
				num = (short)346504503;
				switch (num3 == num)
				{
				}
				num = (short)891224064;
				if (num != 0)
				{
				}
				this.dataProfGeneralLimitedBroadcast_A8431.HiddenStatic = value;
			}
		}

		// Token: 0x170056CD RID: 22221
		// (get) Token: 0x0600AD3A RID: 44346 RVA: 0x00A15314 File Offset: 0x00A13514
		// (set) Token: 0x0600AD3B RID: 44347 RVA: 0x00A153C8 File Offset: 0x00A135C8
		internal bool DataProfGeneralLimitedBroadcast_A8431_HiddenDynamic
		{
			get
			{
				short num = (short)1446297451;
				short num2 = num;
				num = (short)504872811;
				switch (num2 == num)
				{
				default:
				{
					num = (short)893386752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1260257281;
				if (num != 0)
				{
				}
				num = (short)377552896;
				if (num != 0)
				{
				}
				return this.dataProfGeneralLimitedBroadcast_A8431.HiddenDynamic;
			}
			set
			{
				short num = (short)174630787;
				short num2 = num;
				num = (short)493528963;
				switch (num2 == num)
				{
				default:
				{
					num = (short)73334784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1048444929;
				if (num != 0)
				{
				}
				num = (short)239075328;
				if (num != 0)
				{
				}
				this.dataProfGeneralLimitedBroadcast_A8431.HiddenDynamic = value;
			}
		}

		// Token: 0x170056CE RID: 22222
		// (get) Token: 0x0600AD3C RID: 44348 RVA: 0x00A15480 File Offset: 0x00A13680
		public bool DataProfGeneralLimitedBroadcast_A8431_HasDiffs
		{
			get
			{
				short num = (short)243112445;
				short num2 = num;
				num = (short)1127848445;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1242955776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)282787841;
				if (num != 0)
				{
				}
				num = (short)2111569920;
				if (num != 0)
				{
				}
				return this.dataProfGeneralLimitedBroadcast_A8431._HasDiffs;
			}
		}

		// Token: 0x170056CF RID: 22223
		// (get) Token: 0x0600AD3D RID: 44349 RVA: 0x00A15534 File Offset: 0x00A13734
		// (set) Token: 0x0600AD3E RID: 44350 RVA: 0x00A155E8 File Offset: 0x00A137E8
		public long DataProfGeneralMobileComputerIPAddress_A8523Value
		{
			get
			{
				short num = (short)1424961589;
				short num2 = num;
				num = (short)1302147125;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1659568128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)683409408;
				if (num != 0)
				{
				}
				num = (short)1225785345;
				if (num != 0)
				{
				}
				return this.dataProfGeneralMobileComputerIPAddress_A8523.Value;
			}
			set
			{
				short num = (short)1465594572;
				short num2 = num;
				num = (short)945763020;
				switch (num2 == num)
				{
				default:
				{
					num = (short)816971776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)267649025;
				if (num != 0)
				{
				}
				num = (short)2042232832;
				if (num != 0)
				{
				}
				this.dataProfGeneralMobileComputerIPAddress_A8523.Value = value;
			}
		}

		// Token: 0x170056D0 RID: 22224
		// (get) Token: 0x0600AD3F RID: 44351 RVA: 0x00A156A0 File Offset: 0x00A138A0
		// (set) Token: 0x0600AD40 RID: 44352 RVA: 0x00A15754 File Offset: 0x00A13954
		public string DataProfGeneralMobileComputerIPAddress_A8523_UIValue
		{
			get
			{
				short num = (short)1962672129;
				if (num != 0)
				{
				}
				num = (short)1640824832;
				short num2 = num;
				num = (short)492031911;
				short num3 = num;
				num = (short)331009959;
				switch (num3 == num)
				{
				}
				num = (short)1806696448;
				if (num != 0)
				{
				}
				return this.dataProfGeneralMobileComputerIPAddress_A8523.UIValue;
			}
			set
			{
				short num = (short)433072255;
				short num2 = num;
				num = (short)734996607;
				switch (num2 == num)
				{
				default:
				{
					num = (short)417333248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2026831872;
				if (num != 0)
				{
				}
				num = (short)882114561;
				if (num != 0)
				{
				}
				this.dataProfGeneralMobileComputerIPAddress_A8523.UIValue = value;
			}
		}

		// Token: 0x170056D1 RID: 22225
		// (get) Token: 0x0600AD41 RID: 44353 RVA: 0x00A1580C File Offset: 0x00A13A0C
		public global::AcpBusinessLayer.AcpIPAddressField DataProfGeneralMobileComputerIPAddress_A8523
		{
			get
			{
				short num = (short)33561604;
				short num2 = num;
				num = (short)1465588740;
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
				num = (short)170000385;
				if (num != 0)
				{
				}
				num = (short)335085568;
				if (num != 0)
				{
				}
				return this.dataProfGeneralMobileComputerIPAddress_A8523;
			}
		}

		// Token: 0x170056D2 RID: 22226
		// (get) Token: 0x0600AD42 RID: 44354 RVA: 0x00A158BC File Offset: 0x00A13ABC
		// (set) Token: 0x0600AD43 RID: 44355 RVA: 0x00A15974 File Offset: 0x00A13B74
		public bool DataProfGeneralMobileComputerIPAddress_A8523_Applicable
		{
			get
			{
				short num = (short)1318358856;
				short num2 = num;
				num = (short)323325768;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1671299072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)276561921;
				if (num != 0)
				{
				}
				num = (short)254803968;
				if (num != 0)
				{
				}
				return this.dataProfGeneralMobileComputerIPAddress_A8523.Applicable;
			}
			set
			{
				short num = (short)358053912;
				short num2 = num;
				num = (short)922974232;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1363345408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2127101952;
				if (num != 0)
				{
				}
				num = (short)1106640897;
				if (num != 0)
				{
				}
				this.dataProfGeneralMobileComputerIPAddress_A8523.Applicable = value;
			}
		}

		// Token: 0x170056D3 RID: 22227
		// (get) Token: 0x0600AD44 RID: 44356 RVA: 0x00A15A2C File Offset: 0x00A13C2C
		// (set) Token: 0x0600AD45 RID: 44357 RVA: 0x00A15AE4 File Offset: 0x00A13CE4
		public bool DataProfGeneralMobileComputerIPAddress_A8523_Valid
		{
			get
			{
				short num = (short)231770736;
				short num2 = num;
				num = (short)1070107248;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1771175936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)877330433;
				if (num != 0)
				{
				}
				num = (short)829882368;
				if (num != 0)
				{
				}
				return this.dataProfGeneralMobileComputerIPAddress_A8523.Valid;
			}
			set
			{
				short num = (short)156498711;
				short num2 = num;
				num = (short)757529367;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1499856896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2111569921;
				if (num != 0)
				{
				}
				num = (short)746192896;
				if (num != 0)
				{
				}
				this.dataProfGeneralMobileComputerIPAddress_A8523.Valid = value;
			}
		}

		// Token: 0x170056D4 RID: 22228
		// (get) Token: 0x0600AD46 RID: 44358 RVA: 0x00A15B98 File Offset: 0x00A13D98
		// (set) Token: 0x0600AD47 RID: 44359 RVA: 0x00A15C4C File Offset: 0x00A13E4C
		public bool DataProfGeneralMobileComputerIPAddress_A8523_Visible
		{
			get
			{
				short num = (short)1911722431;
				short num2 = num;
				num = (short)1286640063;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1903099904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1256849408;
				if (num != 0)
				{
				}
				num = (short)473366529;
				if (num != 0)
				{
				}
				return this.dataProfGeneralMobileComputerIPAddress_A8523.Visible;
			}
			set
			{
				short num = (short)533530918;
				short num2 = num;
				num = (short)362481958;
				switch (num2 == num)
				{
				default:
				{
					num = (short)926482432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)834863105;
				if (num != 0)
				{
				}
				num = (short)1787559936;
				if (num != 0)
				{
				}
				this.dataProfGeneralMobileComputerIPAddress_A8523.Visible = value;
			}
		}

		// Token: 0x170056D5 RID: 22229
		// (get) Token: 0x0600AD48 RID: 44360 RVA: 0x00A15D04 File Offset: 0x00A13F04
		// (set) Token: 0x0600AD49 RID: 44361 RVA: 0x00A15DB8 File Offset: 0x00A13FB8
		public bool DataProfGeneralMobileComputerIPAddress_A8523_Editable
		{
			get
			{
				short num = (short)2047971107;
				short num2 = num;
				num = (short)1139904291;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1320681472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)209977345;
				if (num != 0)
				{
				}
				num = (short)1230635008;
				if (num != 0)
				{
				}
				return this.dataProfGeneralMobileComputerIPAddress_A8523.Editable;
			}
			set
			{
				short num = (short)934691834;
				short num2 = num;
				num = (short)1769554938;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1105068032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)965672960;
				if (num != 0)
				{
				}
				num = (short)370540545;
				if (num != 0)
				{
				}
				this.dataProfGeneralMobileComputerIPAddress_A8523.Editable = value;
			}
		}

		// Token: 0x170056D6 RID: 22230
		// (get) Token: 0x0600AD4A RID: 44362 RVA: 0x00A15E6C File Offset: 0x00A1406C
		internal string DataProfGeneralMobileComputerIPAddress_A8523_UILabel
		{
			get
			{
				short num = (short)89324409;
				short num2 = num;
				num = (short)816970617;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2110914560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1282539520;
				if (num != 0)
				{
				}
				num = (short)1874395137;
				if (num != 0)
				{
				}
				return this.dataProfGeneralMobileComputerIPAddress_A8523.UIName;
			}
		}

		// Token: 0x170056D7 RID: 22231
		// (get) Token: 0x0600AD4B RID: 44363 RVA: 0x00A15F20 File Offset: 0x00A14120
		// (set) Token: 0x0600AD4C RID: 44364 RVA: 0x00A15FD4 File Offset: 0x00A141D4
		internal bool DataProfGeneralMobileComputerIPAddress_A8523_HiddenStatic
		{
			get
			{
				short num = (short)952360663;
				short num2 = num;
				num = (short)1428610775;
				switch (num2 == num)
				{
				default:
				{
					num = (short)498335744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)275382272;
				if (num != 0)
				{
				}
				num = (short)1264517121;
				if (num != 0)
				{
				}
				return this.dataProfGeneralMobileComputerIPAddress_A8523.HiddenStatic;
			}
			set
			{
				short num = (short)1207756072;
				short num2 = num;
				num = (short)1637672232;
				switch (num2 == num)
				{
				default:
				{
					num = (short)135659520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)837025793;
				if (num != 0)
				{
				}
				num = (short)802488320;
				if (num != 0)
				{
				}
				this.dataProfGeneralMobileComputerIPAddress_A8523.HiddenStatic = value;
			}
		}

		// Token: 0x170056D8 RID: 22232
		// (get) Token: 0x0600AD4D RID: 44365 RVA: 0x00A16088 File Offset: 0x00A14288
		// (set) Token: 0x0600AD4E RID: 44366 RVA: 0x00A1613C File Offset: 0x00A1433C
		internal bool DataProfGeneralMobileComputerIPAddress_A8523_HiddenDynamic
		{
			get
			{
				short num = (short)1918795697;
				short num2 = num;
				num = (short)1704755121;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2126970880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2079850497;
				if (num != 0)
				{
				}
				num = (short)1563623424;
				if (num != 0)
				{
				}
				return this.dataProfGeneralMobileComputerIPAddress_A8523.HiddenDynamic;
			}
			set
			{
				short num = (short)490027879;
				short num2 = num;
				num = (short)1133460327;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1248526336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)714014721;
				if (num != 0)
				{
				}
				num = (short)463601664;
				if (num != 0)
				{
				}
				this.dataProfGeneralMobileComputerIPAddress_A8523.HiddenDynamic = value;
			}
		}

		// Token: 0x170056D9 RID: 22233
		// (get) Token: 0x0600AD4F RID: 44367 RVA: 0x00A161F0 File Offset: 0x00A143F0
		public bool DataProfGeneralMobileComputerIPAddress_A8523_HasDiffs
		{
			get
			{
				short num = (short)1671954432;
				short num2 = num;
				num = (short)306263819;
				short num3 = num;
				num = (short)155268875;
				switch (num3 == num)
				{
				}
				num = (short)258473984;
				if (num != 0)
				{
				}
				num = (short)581500929;
				if (num != 0)
				{
				}
				return this.dataProfGeneralMobileComputerIPAddress_A8523._HasDiffs;
			}
		}

		// Token: 0x170056DA RID: 22234
		// (get) Token: 0x0600AD50 RID: 44368 RVA: 0x00A162A8 File Offset: 0x00A144A8
		// (set) Token: 0x0600AD51 RID: 44369 RVA: 0x00A16360 File Offset: 0x00A14560
		public int DataProfGeneralPacketDataMode_A8689Value
		{
			get
			{
				short num = (short)582483968;
				short num2 = num;
				num = (short)505969638;
				short num3 = num;
				num = (short)1554217958;
				switch (num3 == num)
				{
				}
				num = (short)408354817;
				if (num != 0)
				{
				}
				num = (short)1779761152;
				if (num != 0)
				{
				}
				return this.dataProfGeneralPacketDataMode_A8689.Value;
			}
			set
			{
				short num = (short)1465581568;
				short num2 = num;
				num = (short)186310936;
				short num3 = num;
				num = (short)2046157080;
				switch (num3 == num)
				{
				}
				num = (short)1015611393;
				if (num != 0)
				{
				}
				num = (short)1922039808;
				if (num != 0)
				{
				}
				this.dataProfGeneralPacketDataMode_A8689.Value = value;
			}
		}

		// Token: 0x170056DB RID: 22235
		// (get) Token: 0x0600AD52 RID: 44370 RVA: 0x00A16418 File Offset: 0x00A14618
		// (set) Token: 0x0600AD53 RID: 44371 RVA: 0x00A164CC File Offset: 0x00A146CC
		public string DataProfGeneralPacketDataMode_A8689_UIValue
		{
			get
			{
				short num = (short)1051459584;
				short num2 = num;
				num = (short)1273246502;
				short num3 = num;
				num = (short)1964520230;
				switch (num3 == num)
				{
				}
				num = (short)657522689;
				if (num != 0)
				{
				}
				num = (short)614334464;
				if (num != 0)
				{
				}
				return this.dataProfGeneralPacketDataMode_A8689.UIValue;
			}
			set
			{
				short num = (short)241434624;
				short num2 = num;
				num = (short)566115730;
				short num3 = num;
				num = (short)2096971154;
				switch (num3 == num)
				{
				}
				num = (short)1695744001;
				if (num != 0)
				{
				}
				num = (short)1476460544;
				if (num != 0)
				{
				}
				this.dataProfGeneralPacketDataMode_A8689.UIValue = value;
			}
		}

		// Token: 0x170056DC RID: 22236
		// (get) Token: 0x0600AD54 RID: 44372 RVA: 0x00A16580 File Offset: 0x00A14780
		public global::AcpBusinessLayer.AcpListField DataProfGeneralPacketDataMode_A8689
		{
			get
			{
				short num = (short)65601536;
				short num2 = num;
				num = (short)1577035540;
				short num3 = num;
				num = (short)893757204;
				switch (num3 == num)
				{
				}
				num = (short)418185216;
				if (num != 0)
				{
				}
				num = (short)603652097;
				if (num != 0)
				{
				}
				return this.dataProfGeneralPacketDataMode_A8689;
			}
		}

		// Token: 0x170056DD RID: 22237
		// (get) Token: 0x0600AD55 RID: 44373 RVA: 0x00A16630 File Offset: 0x00A14830
		// (set) Token: 0x0600AD56 RID: 44374 RVA: 0x00A166E4 File Offset: 0x00A148E4
		public bool DataProfGeneralPacketDataMode_A8689_Applicable
		{
			get
			{
				short num = (short)1646985216;
				short num2 = num;
				num = (short)1897551882;
				short num3 = num;
				num = (short)104421386;
				switch (num3 == num)
				{
				}
				num = (short)685113345;
				if (num != 0)
				{
				}
				num = (short)1852571648;
				if (num != 0)
				{
				}
				return this.dataProfGeneralPacketDataMode_A8689.Applicable;
			}
			set
			{
				short num = (short)1385299968;
				short num2 = num;
				num = (short)1391337765;
				short num3 = num;
				num = (short)86974757;
				switch (num3 == num)
				{
				}
				num = (short)586219520;
				if (num != 0)
				{
				}
				num = (short)387645441;
				if (num != 0)
				{
				}
				this.dataProfGeneralPacketDataMode_A8689.Applicable = value;
			}
		}

		// Token: 0x170056DE RID: 22238
		// (get) Token: 0x0600AD57 RID: 44375 RVA: 0x00A16798 File Offset: 0x00A14998
		// (set) Token: 0x0600AD58 RID: 44376 RVA: 0x00A1684C File Offset: 0x00A14A4C
		public bool DataProfGeneralPacketDataMode_A8689_Valid
		{
			get
			{
				short num = (short)916193280;
				short num2 = num;
				num = (short)1692991489;
				if (num != 0)
				{
				}
				num = (short)652779201;
				short num3 = num;
				num = (short)300588737;
				switch (num3 == num)
				{
				}
				num = (short)786759680;
				if (num != 0)
				{
				}
				return this.dataProfGeneralPacketDataMode_A8689.Valid;
			}
			set
			{
				short num = (short)1245446144;
				short num2 = num;
				num = (short)22937601;
				if (num != 0)
				{
				}
				num = (short)535538193;
				short num3 = num;
				num = (short)1981393425;
				switch (num3 == num)
				{
				}
				num = (short)60948480;
				if (num != 0)
				{
				}
				this.dataProfGeneralPacketDataMode_A8689.Valid = value;
			}
		}

		// Token: 0x170056DF RID: 22239
		// (get) Token: 0x0600AD59 RID: 44377 RVA: 0x00A16904 File Offset: 0x00A14B04
		// (set) Token: 0x0600AD5A RID: 44378 RVA: 0x00A169BC File Offset: 0x00A14BBC
		public bool DataProfGeneralPacketDataMode_A8689_Visible
		{
			get
			{
				short num = (short)1999699968;
				short num2 = num;
				num = (short)775738381;
				short num3 = num;
				num = (short)1848103949;
				switch (num3 == num)
				{
				}
				num = (short)1754595328;
				if (num != 0)
				{
				}
				num = (short)162201601;
				if (num != 0)
				{
				}
				return this.dataProfGeneralPacketDataMode_A8689.Visible;
			}
			set
			{
				short num = (short)2072444928;
				short num2 = num;
				num = (short)36348390;
				short num3 = num;
				num = (short)441360870;
				switch (num3 == num)
				{
				}
				num = (short)604635137;
				if (num != 0)
				{
				}
				num = (short)1387134976;
				if (num != 0)
				{
				}
				this.dataProfGeneralPacketDataMode_A8689.Visible = value;
			}
		}

		// Token: 0x170056E0 RID: 22240
		// (get) Token: 0x0600AD5B RID: 44379 RVA: 0x00A16A74 File Offset: 0x00A14C74
		// (set) Token: 0x0600AD5C RID: 44380 RVA: 0x00A16B2C File Offset: 0x00A14D2C
		public bool DataProfGeneralPacketDataMode_A8689_Editable
		{
			get
			{
				short num = (short)828047360;
				short num2 = num;
				num = (short)1337504832;
				short num3 = num;
				num = (short)1288877120;
				switch (num3 == num)
				{
				}
				num = (short)155320321;
				if (num != 0)
				{
				}
				num = (short)1303642112;
				if (num != 0)
				{
				}
				return this.dataProfGeneralPacketDataMode_A8689.Editable;
			}
			set
			{
				short num = (short)1210712064;
				short num2 = num;
				num = (short)794624001;
				if (num != 0)
				{
				}
				num = (short)134816975;
				short num3 = num;
				num = (short)1880106191;
				switch (num3 == num)
				{
				}
				num = (short)1707540480;
				if (num != 0)
				{
				}
				this.dataProfGeneralPacketDataMode_A8689.Editable = value;
			}
		}

		// Token: 0x170056E1 RID: 22241
		// (get) Token: 0x0600AD5D RID: 44381 RVA: 0x00A16BE0 File Offset: 0x00A14DE0
		internal string DataProfGeneralPacketDataMode_A8689_UILabel
		{
			get
			{
				short num = (short)1882324992;
				short num2 = num;
				num = (short)1746607348;
				short num3 = num;
				num = (short)1186209012;
				switch (num3 == num)
				{
				}
				num = (short)1041760257;
				if (num != 0)
				{
				}
				num = (short)1176043520;
				if (num != 0)
				{
				}
				return this.dataProfGeneralPacketDataMode_A8689.UIName;
			}
		}

		// Token: 0x170056E2 RID: 22242
		// (get) Token: 0x0600AD5E RID: 44382 RVA: 0x00A16C94 File Offset: 0x00A14E94
		// (set) Token: 0x0600AD5F RID: 44383 RVA: 0x00A16D48 File Offset: 0x00A14F48
		internal bool DataProfGeneralPacketDataMode_A8689_HiddenStatic
		{
			get
			{
				short num = (short)1075249152;
				short num2 = num;
				num = (short)1775709532;
				short num3 = num;
				num = (short)249113948;
				switch (num3 == num)
				{
				}
				num = (short)1741422593;
				if (num != 0)
				{
				}
				num = (short)931332096;
				if (num != 0)
				{
				}
				return this.dataProfGeneralPacketDataMode_A8689.HiddenStatic;
			}
			set
			{
				short num = (short)355205120;
				short num2 = num;
				num = (short)182837262;
				short num3 = num;
				num = (short)756277262;
				switch (num3 == num)
				{
				}
				num = (short)1744175104;
				if (num != 0)
				{
				}
				num = (short)1035665409;
				if (num != 0)
				{
				}
				this.dataProfGeneralPacketDataMode_A8689.HiddenStatic = value;
			}
		}

		// Token: 0x170056E3 RID: 22243
		// (get) Token: 0x0600AD60 RID: 44384 RVA: 0x00A16E00 File Offset: 0x00A15000
		// (set) Token: 0x0600AD61 RID: 44385 RVA: 0x00A16EB4 File Offset: 0x00A150B4
		internal bool DataProfGeneralPacketDataMode_A8689_HiddenDynamic
		{
			get
			{
				short num = (short)1524826112;
				short num2 = num;
				num = (short)1329790977;
				if (num != 0)
				{
				}
				num = (short)1795406204;
				short num3 = num;
				num = (short)1531689340;
				switch (num3 == num)
				{
				}
				num = (short)623968256;
				if (num != 0)
				{
				}
				return this.dataProfGeneralPacketDataMode_A8689.HiddenDynamic;
			}
			set
			{
				short num = (short)1651441664;
				short num2 = num;
				num = (short)375746937;
				short num3 = num;
				num = (short)1957065081;
				switch (num3 == num)
				{
				}
				num = (short)505217025;
				if (num != 0)
				{
				}
				num = (short)439812096;
				if (num != 0)
				{
				}
				this.dataProfGeneralPacketDataMode_A8689.HiddenDynamic = value;
			}
		}

		// Token: 0x170056E4 RID: 22244
		// (get) Token: 0x0600AD62 RID: 44386 RVA: 0x00A16F6C File Offset: 0x00A1516C
		public bool DataProfGeneralPacketDataMode_A8689_HasDiffs
		{
			get
			{
				short num = (short)1004273664;
				short num2 = num;
				num = (short)1055522817;
				if (num != 0)
				{
				}
				num = (short)2052701550;
				short num3 = num;
				num = (short)820297070;
				switch (num3 == num)
				{
				}
				num = (short)1970667520;
				if (num != 0)
				{
				}
				return this.dataProfGeneralPacketDataMode_A8689._HasDiffs;
			}
		}

		// Token: 0x170056E5 RID: 22245
		// (get) Token: 0x0600AD63 RID: 44387 RVA: 0x00A17024 File Offset: 0x00A15224
		// (set) Token: 0x0600AD64 RID: 44388 RVA: 0x00A170D8 File Offset: 0x00A152D8
		public bool TrkSysLabtoolRxVoiceInterruptsData_A9043Value
		{
			get
			{
				short num = (short)358678528;
				short num2 = num;
				num = (short)1149589861;
				short num3 = num;
				num = (short)260659557;
				switch (num3 == num)
				{
				}
				num = (short)466944000;
				if (num != 0)
				{
				}
				num = (short)499056641;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolRxVoiceInterruptsData_A9043.Value;
			}
			set
			{
				short num = (short)1902379008;
				short num2 = num;
				num = (short)1764425729;
				if (num != 0)
				{
				}
				num = (short)1143488626;
				short num3 = num;
				num = (short)264978546;
				switch (num3 == num)
				{
				}
				num = (short)36569088;
				if (num != 0)
				{
				}
				this.trkSysLabtoolRxVoiceInterruptsData_A9043.Value = value;
			}
		}

		// Token: 0x170056E6 RID: 22246
		// (get) Token: 0x0600AD65 RID: 44389 RVA: 0x00A1718C File Offset: 0x00A1538C
		public global::AcpBusinessLayer.AcpField<bool> TrkSysLabtoolRxVoiceInterruptsData_A9043
		{
			get
			{
				short num = (short)1300496384;
				short num2 = num;
				num = (short)175552275;
				short num3 = num;
				num = (short)1623897875;
				switch (num3 == num)
				{
				}
				num = (short)2036006912;
				if (num != 0)
				{
				}
				num = (short)1753481217;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolRxVoiceInterruptsData_A9043;
			}
		}

		// Token: 0x170056E7 RID: 22247
		// (get) Token: 0x0600AD66 RID: 44390 RVA: 0x00A1723C File Offset: 0x00A1543C
		// (set) Token: 0x0600AD67 RID: 44391 RVA: 0x00A172F0 File Offset: 0x00A154F0
		public bool TrkSysLabtoolRxVoiceInterruptsData_A9043_UIValue
		{
			get
			{
				short num = (short)1740111872;
				short num2 = num;
				num = (short)227344385;
				if (num != 0)
				{
				}
				num = (short)1044957797;
				short num3 = num;
				num = (short)404933221;
				switch (num3 == num)
				{
				}
				num = (short)567672832;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolRxVoiceInterruptsData_A9043.Value;
			}
			set
			{
				short num = (short)530251776;
				short num2 = num;
				num = (short)1558870430;
				short num3 = num;
				num = (short)658078110;
				switch (num3 == num)
				{
				}
				num = (short)686096385;
				if (num != 0)
				{
				}
				num = (short)503447552;
				if (num != 0)
				{
				}
				this.trkSysLabtoolRxVoiceInterruptsData_A9043.Value = value;
			}
		}

		// Token: 0x170056E8 RID: 22248
		// (get) Token: 0x0600AD68 RID: 44392 RVA: 0x00A173A8 File Offset: 0x00A155A8
		// (set) Token: 0x0600AD69 RID: 44393 RVA: 0x00A1745C File Offset: 0x00A1565C
		public bool TrkSysLabtoolRxVoiceInterruptsData_A9043_Applicable
		{
			get
			{
				short num = (short)1149173760;
				short num2 = num;
				num = (short)1675758372;
				short num3 = num;
				num = (short)1943145252;
				switch (num3 == num)
				{
				}
				num = (short)689176577;
				if (num != 0)
				{
				}
				num = (short)241631232;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolRxVoiceInterruptsData_A9043.Applicable;
			}
			set
			{
				short num = (short)90243072;
				short num2 = num;
				num = (short)838605303;
				short num3 = num;
				num = (short)1161697783;
				switch (num3 == num)
				{
				}
				num = (short)1017184257;
				if (num != 0)
				{
				}
				num = (short)1161232384;
				if (num != 0)
				{
				}
				this.trkSysLabtoolRxVoiceInterruptsData_A9043.Applicable = value;
			}
		}

		// Token: 0x170056E9 RID: 22249
		// (get) Token: 0x0600AD6A RID: 44394 RVA: 0x00A17514 File Offset: 0x00A15714
		// (set) Token: 0x0600AD6B RID: 44395 RVA: 0x00A175C8 File Offset: 0x00A157C8
		public bool TrkSysLabtoolRxVoiceInterruptsData_A9043_Valid
		{
			get
			{
				short num = (short)1598554112;
				short num2 = num;
				num = (short)1864791092;
				short num3 = num;
				num = (short)457864244;
				switch (num3 == num)
				{
				}
				num = (short)1483276289;
				if (num != 0)
				{
				}
				num = (short)309067776;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolRxVoiceInterruptsData_A9043.Valid;
			}
			set
			{
				short num = (short)1691222016;
				short num2 = num;
				num = (short)2716379;
				short num3 = num;
				num = (short)1419211483;
				switch (num3 == num)
				{
				}
				num = (short)1394475009;
				if (num != 0)
				{
				}
				num = (short)950272000;
				if (num != 0)
				{
				}
				this.trkSysLabtoolRxVoiceInterruptsData_A9043.Valid = value;
			}
		}

		// Token: 0x170056EA RID: 22250
		// (get) Token: 0x0600AD6C RID: 44396 RVA: 0x00A1767C File Offset: 0x00A1587C
		// (set) Token: 0x0600AD6D RID: 44397 RVA: 0x00A17730 File Offset: 0x00A15930
		public bool TrkSysLabtoolRxVoiceInterruptsData_A9043_Visible
		{
			get
			{
				short num = (short)1162805248;
				short num2 = num;
				num = (short)1016989143;
				short num3 = num;
				num = (short)547816919;
				switch (num3 == num)
				{
				}
				num = (short)773980160;
				if (num != 0)
				{
				}
				num = (short)1764753409;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolRxVoiceInterruptsData_A9043.Visible;
			}
			set
			{
				short num = (short)185204736;
				short num2 = num;
				num = (short)1762883457;
				short num3 = num;
				num = (short)1399093121;
				switch (num3 == num)
				{
				}
				num = (short)722534401;
				if (num != 0)
				{
				}
				num = (short)783613952;
				if (num != 0)
				{
				}
				this.trkSysLabtoolRxVoiceInterruptsData_A9043.Visible = value;
			}
		}

		// Token: 0x170056EB RID: 22251
		// (get) Token: 0x0600AD6E RID: 44398 RVA: 0x00A177E4 File Offset: 0x00A159E4
		// (set) Token: 0x0600AD6F RID: 44399 RVA: 0x00A1789C File Offset: 0x00A15A9C
		public bool TrkSysLabtoolRxVoiceInterruptsData_A9043_Editable
		{
			get
			{
				short num = (short)1607794688;
				short num2 = num;
				num = (short)213713;
				short num3 = num;
				num = (short)2050638545;
				switch (num3 == num)
				{
				}
				num = (short)2083979265;
				if (num != 0)
				{
				}
				num = (short)93126656;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolRxVoiceInterruptsData_A9043.Editable;
			}
			set
			{
				short num = (short)1239547904;
				short num2 = num;
				num = (short)1903859865;
				short num3 = num;
				num = (short)699373721;
				switch (num3 == num)
				{
				}
				num = (short)1031798785;
				if (num != 0)
				{
				}
				num = (short)1844510720;
				if (num != 0)
				{
				}
				this.trkSysLabtoolRxVoiceInterruptsData_A9043.Editable = value;
			}
		}

		// Token: 0x170056EC RID: 22252
		// (get) Token: 0x0600AD70 RID: 44400 RVA: 0x00A17950 File Offset: 0x00A15B50
		internal string TrkSysLabtoolRxVoiceInterruptsData_A9043_UILabel
		{
			get
			{
				short num = (short)581828608;
				short num2 = num;
				num = (short)1419313615;
				short num3 = num;
				num = (short)1314783695;
				switch (num3 == num)
				{
				}
				num = (short)491651073;
				if (num != 0)
				{
				}
				num = (short)430702592;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolRxVoiceInterruptsData_A9043.UIName;
			}
		}

		// Token: 0x170056ED RID: 22253
		// (get) Token: 0x0600AD71 RID: 44401 RVA: 0x00A17A04 File Offset: 0x00A15C04
		// (set) Token: 0x0600AD72 RID: 44402 RVA: 0x00A17AB4 File Offset: 0x00A15CB4
		internal bool TrkSysLabtoolRxVoiceInterruptsData_A9043_HiddenStatic
		{
			get
			{
				short num = (short)1268973568;
				short num2 = num;
				num = (short)1016629343;
				short num3 = num;
				num = (short)1443072095;
				switch (num3 == num)
				{
				}
				num = (short)276627456;
				if (num != 0)
				{
				}
				num = (short)643629057;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolRxVoiceInterruptsData_A9043.HiddenStatic;
			}
			set
			{
				short num = (short)1212153856;
				short num2 = num;
				num = (short)234171293;
				short num3 = num;
				num = (short)280505245;
				switch (num3 == num)
				{
				}
				num = (short)1938358272;
				if (num != 0)
				{
				}
				num = (short)308346881;
				if (num != 0)
				{
				}
				this.trkSysLabtoolRxVoiceInterruptsData_A9043.HiddenStatic = value;
			}
		}

		// Token: 0x170056EE RID: 22254
		// (get) Token: 0x0600AD73 RID: 44403 RVA: 0x00A17B68 File Offset: 0x00A15D68
		// (set) Token: 0x0600AD74 RID: 44404 RVA: 0x00A17C1C File Offset: 0x00A15E1C
		internal bool TrkSysLabtoolRxVoiceInterruptsData_A9043_HiddenDynamic
		{
			get
			{
				short num = (short)889782272;
				short num2 = num;
				num = (short)1817360613;
				short num3 = num;
				num = (short)203667685;
				switch (num3 == num)
				{
				}
				num = (short)861405184;
				if (num != 0)
				{
				}
				num = (short)1827274753;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolRxVoiceInterruptsData_A9043.HiddenDynamic;
			}
			set
			{
				short num = (short)379256832;
				short num2 = num;
				num = (short)1946222593;
				if (num != 0)
				{
				}
				num = (short)709295375;
				short num3 = num;
				num = (short)1171782927;
				switch (num3 == num)
				{
				}
				num = (short)473300992;
				if (num != 0)
				{
				}
				this.trkSysLabtoolRxVoiceInterruptsData_A9043.HiddenDynamic = value;
			}
		}

		// Token: 0x170056EF RID: 22255
		// (get) Token: 0x0600AD75 RID: 44405 RVA: 0x00A17CD4 File Offset: 0x00A15ED4
		public bool TrkSysLabtoolRxVoiceInterruptsData_A9043_HasDiffs
		{
			get
			{
				short num = (short)1795686400;
				short num2 = num;
				num = (short)1025766713;
				short num3 = num;
				num = (short)129955129;
				switch (num3 == num)
				{
				}
				num = (short)1690763264;
				if (num != 0)
				{
				}
				num = (short)740556801;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolRxVoiceInterruptsData_A9043._HasDiffs;
			}
		}

		// Token: 0x170056F0 RID: 22256
		// (get) Token: 0x0600AD76 RID: 44406 RVA: 0x00A17D88 File Offset: 0x00A15F88
		// (set) Token: 0x0600AD77 RID: 44407 RVA: 0x00A17E3C File Offset: 0x00A1603C
		public long DataProfGeneralSubscriberAirInterfaceIPAddress_A9220Value
		{
			get
			{
				short num = (short)877985792;
				short num2 = num;
				num = (short)1139878035;
				short num3 = num;
				num = (short)563357843;
				switch (num3 == num)
				{
				}
				num = (short)249823233;
				if (num != 0)
				{
				}
				num = (short)1742274560;
				if (num != 0)
				{
				}
				return this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Value;
			}
			set
			{
				short num = (short)911015936;
				short num2 = num;
				num = (short)1252315253;
				short num3 = num;
				num = (short)441241717;
				switch (num3 == num)
				{
				}
				num = (short)1777532929;
				if (num != 0)
				{
				}
				num = (short)359792640;
				if (num != 0)
				{
				}
				this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Value = value;
			}
		}

		// Token: 0x170056F1 RID: 22257
		// (get) Token: 0x0600AD78 RID: 44408 RVA: 0x00A17EF4 File Offset: 0x00A160F4
		// (set) Token: 0x0600AD79 RID: 44409 RVA: 0x00A17FA8 File Offset: 0x00A161A8
		public string DataProfGeneralSubscriberAirInterfaceIPAddress_A9220_UIValue
		{
			get
			{
				short num = (short)1917059072;
				short num2 = num;
				num = (short)125500127;
				short num3 = num;
				num = (short)1518992095;
				switch (num3 == num)
				{
				}
				num = (short)72810497;
				if (num != 0)
				{
				}
				num = (short)1440743424;
				if (num != 0)
				{
				}
				return this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.UIValue;
			}
			set
			{
				short num = (short)1967128576;
				short num2 = num;
				num = (short)1302462465;
				if (num != 0)
				{
				}
				num = (short)105508999;
				short num3 = num;
				num = (short)432533639;
				switch (num3 == num)
				{
				}
				num = (short)60948480;
				if (num != 0)
				{
				}
				this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.UIValue = value;
			}
		}

		// Token: 0x170056F2 RID: 22258
		// (get) Token: 0x0600AD7A RID: 44410 RVA: 0x00A1805C File Offset: 0x00A1625C
		public global::AcpBusinessLayer.AcpIPAddressField DataProfGeneralSubscriberAirInterfaceIPAddress_A9220
		{
			get
			{
				short num = (short)1711144960;
				short num2 = num;
				num = (short)1185598982;
				short num3 = num;
				num = (short)836947462;
				switch (num3 == num)
				{
				}
				num = (short)869728256;
				if (num != 0)
				{
				}
				num = (short)948371457;
				if (num != 0)
				{
				}
				return this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220;
			}
		}

		// Token: 0x170056F3 RID: 22259
		// (get) Token: 0x0600AD7B RID: 44411 RVA: 0x00A1810C File Offset: 0x00A1630C
		// (set) Token: 0x0600AD7C RID: 44412 RVA: 0x00A181C4 File Offset: 0x00A163C4
		public bool DataProfGeneralSubscriberAirInterfaceIPAddress_A9220_Applicable
		{
			get
			{
				short num = (short)1571160064;
				short num2 = num;
				num = (short)395687523;
				short num3 = num;
				num = (short)210155107;
				switch (num3 == num)
				{
				}
				num = (short)490995713;
				if (num != 0)
				{
				}
				num = (short)1010499584;
				if (num != 0)
				{
				}
				return this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Applicable;
			}
			set
			{
				short num = (short)2001272832;
				short num2 = num;
				num = (short)389503280;
				short num3 = num;
				num = (short)453663024;
				switch (num3 == num)
				{
				}
				num = (short)463208449;
				if (num != 0)
				{
				}
				num = (short)190316544;
				if (num != 0)
				{
				}
				this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Applicable = value;
			}
		}

		// Token: 0x170056F4 RID: 22260
		// (get) Token: 0x0600AD7D RID: 44413 RVA: 0x00A18278 File Offset: 0x00A16478
		// (set) Token: 0x0600AD7E RID: 44414 RVA: 0x00A1832C File Offset: 0x00A1652C
		public bool DataProfGeneralSubscriberAirInterfaceIPAddress_A9220_Valid
		{
			get
			{
				short num = (short)2090655103;
				short num2 = num;
				num = (short)1775885695;
				switch (num2 == num)
				{
				}
				num = (short)1580531713;
				if (num != 0)
				{
				}
				num = (short)161284096;
				if (num != 0)
				{
				}
				num = (short)1452015616;
				short num3 = num;
				return this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Valid;
			}
			set
			{
				short num = (short)1719926785;
				if (num != 0)
				{
				}
				num = (short)2130568279;
				short num2 = num;
				num = (short)837215319;
				switch (num2 == num)
				{
				}
				num = (short)359399424;
				if (num != 0)
				{
				}
				num = (short)1031077888;
				short num3 = num;
				this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Valid = value;
			}
		}

		// Token: 0x170056F5 RID: 22261
		// (get) Token: 0x0600AD7F RID: 44415 RVA: 0x00A183E4 File Offset: 0x00A165E4
		// (set) Token: 0x0600AD80 RID: 44416 RVA: 0x00A18498 File Offset: 0x00A16698
		public bool DataProfGeneralSubscriberAirInterfaceIPAddress_A9220_Visible
		{
			get
			{
				short num = (short)1263759918;
				short num2 = num;
				num = (short)1986425390;
				switch (num2 == num)
				{
				}
				num = (short)563740673;
				if (num != 0)
				{
				}
				num = (short)1483735040;
				if (num != 0)
				{
				}
				num = (short)982515712;
				short num3 = num;
				return this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Visible;
			}
			set
			{
				short num = (short)438376093;
				short num2 = num;
				num = (short)957879965;
				switch (num2 == num)
				{
				}
				num = (short)1645084672;
				if (num != 0)
				{
				}
				num = (short)1501429761;
				if (num != 0)
				{
				}
				num = (short)1852309504;
				short num3 = num;
				this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Visible = value;
			}
		}

		// Token: 0x170056F6 RID: 22262
		// (get) Token: 0x0600AD81 RID: 44417 RVA: 0x00A1854C File Offset: 0x00A1674C
		// (set) Token: 0x0600AD82 RID: 44418 RVA: 0x00A18600 File Offset: 0x00A16800
		public bool DataProfGeneralSubscriberAirInterfaceIPAddress_A9220_Editable
		{
			get
			{
				short num = (short)385162091;
				short num2 = num;
				num = (short)1390222187;
				switch (num2 == num)
				{
				}
				num = (short)1808728065;
				if (num != 0)
				{
				}
				num = (short)1086652416;
				if (num != 0)
				{
				}
				num = (short)776667136;
				short num3 = num;
				return this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Editable;
			}
			set
			{
				short num = (short)1826956634;
				short num2 = num;
				num = (short)1549083994;
				switch (num2 == num)
				{
				}
				num = (short)671416320;
				if (num != 0)
				{
				}
				num = (short)1880096769;
				if (num != 0)
				{
				}
				num = (short)1341521920;
				short num3 = num;
				this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Editable = value;
			}
		}

		// Token: 0x170056F7 RID: 22263
		// (get) Token: 0x0600AD83 RID: 44419 RVA: 0x00A186B4 File Offset: 0x00A168B4
		internal string DataProfGeneralSubscriberAirInterfaceIPAddress_A9220_UILabel
		{
			get
			{
				short num = (short)1205564334;
				short num2 = num;
				num = (short)682128302;
				switch (num2 == num)
				{
				}
				num = (short)1274216448;
				if (num != 0)
				{
				}
				num = (short)1894711297;
				if (num != 0)
				{
				}
				num = (short)882442240;
				short num3 = num;
				return this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.UIName;
			}
		}

		// Token: 0x170056F8 RID: 22264
		// (get) Token: 0x0600AD84 RID: 44420 RVA: 0x00A1876C File Offset: 0x00A1696C
		// (set) Token: 0x0600AD85 RID: 44421 RVA: 0x00A18820 File Offset: 0x00A16A20
		internal bool DataProfGeneralSubscriberAirInterfaceIPAddress_A9220_HiddenStatic
		{
			get
			{
				short num = (short)988267074;
				short num2 = num;
				num = (short)59097666;
				switch (num2 == num)
				{
				}
				num = (short)318504961;
				if (num != 0)
				{
				}
				num = (short)2096824320;
				if (num != 0)
				{
				}
				num = (short)2037907456;
				short num3 = num;
				return this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.HiddenStatic;
			}
			set
			{
				short num = (short)876405249;
				short num2 = num;
				num = (short)1438769665;
				switch (num2 == num)
				{
				}
				num = (short)365821953;
				if (num != 0)
				{
				}
				num = (short)1078132736;
				if (num != 0)
				{
				}
				num = (short)1312620544;
				short num3 = num;
				this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.HiddenStatic = value;
			}
		}

		// Token: 0x170056F9 RID: 22265
		// (get) Token: 0x0600AD86 RID: 44422 RVA: 0x00A188D8 File Offset: 0x00A16AD8
		// (set) Token: 0x0600AD87 RID: 44423 RVA: 0x00A18990 File Offset: 0x00A16B90
		internal bool DataProfGeneralSubscriberAirInterfaceIPAddress_A9220_HiddenDynamic
		{
			get
			{
				short num = (short)1813313177;
				short num2 = num;
				num = (short)16184985;
				switch (num2 == num)
				{
				}
				num = (short)409993216;
				if (num != 0)
				{
				}
				num = (short)873791489;
				if (num != 0)
				{
				}
				num = (short)143065088;
				short num3 = num;
				return this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.HiddenDynamic;
			}
			set
			{
				short num = (short)1347011795;
				short num2 = num;
				num = (short)239518931;
				switch (num2 == num)
				{
				}
				num = (short)310837249;
				if (num != 0)
				{
				}
				num = (short)858062848;
				if (num != 0)
				{
				}
				num = (short)1349058560;
				short num3 = num;
				this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220.HiddenDynamic = value;
			}
		}

		// Token: 0x170056FA RID: 22266
		// (get) Token: 0x0600AD88 RID: 44424 RVA: 0x00A18A44 File Offset: 0x00A16C44
		public bool DataProfGeneralSubscriberAirInterfaceIPAddress_A9220_HasDiffs
		{
			get
			{
				short num = (short)657659571;
				short num2 = num;
				num = (short)1492588211;
				switch (num2 == num)
				{
				}
				num = (short)1757151233;
				if (num != 0)
				{
				}
				num = (short)1650917376;
				if (num != 0)
				{
				}
				num = (short)870842368;
				short num3 = num;
				return this.dataProfGeneralSubscriberAirInterfaceIPAddress_A9220._HasDiffs;
			}
		}

		// Token: 0x170056FB RID: 22267
		// (get) Token: 0x0600AD89 RID: 44425 RVA: 0x00A18AFC File Offset: 0x00A16CFC
		// (set) Token: 0x0600AD8A RID: 44426 RVA: 0x00A18BB0 File Offset: 0x00A16DB0
		public bool DataProfGeneralAutoGenerateIPAddress_A19320Value
		{
			get
			{
				short num = (short)2063204353;
				if (num != 0)
				{
				}
				num = (short)1712109959;
				short num2 = num;
				num = (short)972929415;
				switch (num2 == num)
				{
				}
				num = (short)1539702784;
				if (num != 0)
				{
				}
				num = (short)986447872;
				short num3 = num;
				return this.dataProfGeneralAutoGenerateIPAddress_A19320.Value;
			}
			set
			{
				short num = (short)84030062;
				short num2 = num;
				num = (short)907358830;
				switch (num2 == num)
				{
				}
				num = (short)1491271681;
				if (num != 0)
				{
				}
				num = (short)604569600;
				if (num != 0)
				{
				}
				num = (short)1755447296;
				short num3 = num;
				this.dataProfGeneralAutoGenerateIPAddress_A19320.Value = value;
			}
		}

		// Token: 0x170056FC RID: 22268
		// (get) Token: 0x0600AD8B RID: 44427 RVA: 0x00A18C68 File Offset: 0x00A16E68
		public global::AcpBusinessLayer.AcpField<bool> DataProfGeneralAutoGenerateIPAddress_A19320
		{
			get
			{
				short num = (short)1623100700;
				short num2 = num;
				num = (short)1035832604;
				switch (num2 == num)
				{
				}
				num = (short)421724161;
				if (num != 0)
				{
				}
				num = (short)550371328;
				if (num != 0)
				{
				}
				num = (short)484769792;
				short num3 = num;
				return this.dataProfGeneralAutoGenerateIPAddress_A19320;
			}
		}

		// Token: 0x170056FD RID: 22269
		// (get) Token: 0x0600AD8C RID: 44428 RVA: 0x00A18D18 File Offset: 0x00A16F18
		// (set) Token: 0x0600AD8D RID: 44429 RVA: 0x00A18DCC File Offset: 0x00A16FCC
		public bool DataProfGeneralAutoGenerateIPAddress_A19320_UIValue
		{
			get
			{
				short num = (short)1624761301;
				short num2 = num;
				num = (short)21095381;
				switch (num2 == num)
				{
				}
				num = (short)1022230528;
				if (num != 0)
				{
				}
				num = (short)49807361;
				if (num != 0)
				{
				}
				num = (short)3801088;
				short num3 = num;
				return this.dataProfGeneralAutoGenerateIPAddress_A19320.Value;
			}
			set
			{
				short num = (short)620408394;
				short num2 = num;
				num = (short)1939320394;
				switch (num2 == num)
				{
				}
				num = (short)707723265;
				if (num != 0)
				{
				}
				num = (short)444006400;
				if (num != 0)
				{
				}
				num = (short)1126498304;
				short num3 = num;
				this.dataProfGeneralAutoGenerateIPAddress_A19320.Value = value;
			}
		}

		// Token: 0x170056FE RID: 22270
		// (get) Token: 0x0600AD8E RID: 44430 RVA: 0x00A18E84 File Offset: 0x00A17084
		// (set) Token: 0x0600AD8F RID: 44431 RVA: 0x00A18F38 File Offset: 0x00A17138
		public bool DataProfGeneralAutoGenerateIPAddress_A19320_Applicable
		{
			get
			{
				short num = (short)1693489385;
				short num2 = num;
				num = (short)1194105065;
				switch (num2 == num)
				{
				}
				num = (short)1078591489;
				if (num != 0)
				{
				}
				num = (short)182910976;
				if (num != 0)
				{
				}
				num = (short)1611333632;
				short num3 = num;
				return this.dataProfGeneralAutoGenerateIPAddress_A19320.Applicable;
			}
			set
			{
				short num = (short)591606416;
				short num2 = num;
				num = (short)1274557072;
				switch (num2 == num)
				{
				}
				num = (short)1639907328;
				if (num != 0)
				{
				}
				num = (short)923598849;
				if (num != 0)
				{
				}
				num = (short)901251072;
				short num3 = num;
				this.dataProfGeneralAutoGenerateIPAddress_A19320.Applicable = value;
			}
		}

		// Token: 0x170056FF RID: 22271
		// (get) Token: 0x0600AD90 RID: 44432 RVA: 0x00A18FF0 File Offset: 0x00A171F0
		// (set) Token: 0x0600AD91 RID: 44433 RVA: 0x00A190A4 File Offset: 0x00A172A4
		public bool DataProfGeneralAutoGenerateIPAddress_A19320_Valid
		{
			get
			{
				short num = (short)1366855995;
				short num2 = num;
				num = (short)778146107;
				switch (num2 == num)
				{
				}
				num = (short)148570113;
				if (num != 0)
				{
				}
				num = (short)1592262656;
				if (num != 0)
				{
				}
				num = (short)1078657024;
				short num3 = num;
				return this.dataProfGeneralAutoGenerateIPAddress_A19320.Valid;
			}
			set
			{
				short num = (short)1536428365;
				short num2 = num;
				num = (short)1942161741;
				switch (num2 == num)
				{
				}
				num = (short)856686592;
				if (num != 0)
				{
				}
				num = (short)1048903681;
				if (num != 0)
				{
				}
				num = (short)743571456;
				short num3 = num;
				this.dataProfGeneralAutoGenerateIPAddress_A19320.Valid = value;
			}
		}

		// Token: 0x17005700 RID: 22272
		// (get) Token: 0x0600AD92 RID: 44434 RVA: 0x00A1915C File Offset: 0x00A1735C
		// (set) Token: 0x0600AD93 RID: 44435 RVA: 0x00A19210 File Offset: 0x00A17410
		public bool DataProfGeneralAutoGenerateIPAddress_A19320_Visible
		{
			get
			{
				short num = (short)898740848;
				short num2 = num;
				num = (short)128103024;
				switch (num2 == num)
				{
				}
				num = (short)1100677121;
				if (num != 0)
				{
				}
				num = (short)1270808576;
				if (num != 0)
				{
				}
				num = (short)770375680;
				short num3 = num;
				return this.dataProfGeneralAutoGenerateIPAddress_A19320.Visible;
			}
			set
			{
				short num = (short)1432788080;
				short num2 = num;
				num = (short)626039920;
				switch (num2 == num)
				{
				}
				num = (short)1998585857;
				if (num != 0)
				{
				}
				num = (short)1018626048;
				if (num != 0)
				{
				}
				num = (short)167772160;
				short num3 = num;
				this.dataProfGeneralAutoGenerateIPAddress_A19320.Visible = value;
			}
		}

		// Token: 0x17005701 RID: 22273
		// (get) Token: 0x0600AD94 RID: 44436 RVA: 0x00A192C0 File Offset: 0x00A174C0
		// (set) Token: 0x0600AD95 RID: 44437 RVA: 0x00A19374 File Offset: 0x00A17574
		public bool DataProfGeneralAutoGenerateIPAddress_A19320_Editable
		{
			get
			{
				short num = (short)1961357655;
				short num2 = num;
				num = (short)1898836311;
				switch (num2 == num)
				{
				}
				num = (short)88473601;
				if (num != 0)
				{
				}
				num = (short)1957298176;
				if (num != 0)
				{
				}
				num = (short)850788352;
				short num3 = num;
				return this.dataProfGeneralAutoGenerateIPAddress_A19320.Editable;
			}
			set
			{
				short num = (short)421753975;
				short num2 = num;
				num = (short)1493988471;
				switch (num2 == num)
				{
				}
				num = (short)635109377;
				if (num != 0)
				{
				}
				num = (short)1134493696;
				if (num != 0)
				{
				}
				num = (short)826081280;
				short num3 = num;
				this.dataProfGeneralAutoGenerateIPAddress_A19320.Editable = value;
			}
		}

		// Token: 0x17005702 RID: 22274
		// (get) Token: 0x0600AD96 RID: 44438 RVA: 0x00A19428 File Offset: 0x00A17628
		internal string DataProfGeneralAutoGenerateIPAddress_A19320_UILabel
		{
			get
			{
				short num = (short)1768219391;
				short num2 = num;
				num = (short)1438704383;
				switch (num2 == num)
				{
				}
				num = (short)1222639617;
				if (num != 0)
				{
				}
				num = (short)1186136064;
				if (num != 0)
				{
				}
				num = (short)840499200;
				short num3 = num;
				return this.dataProfGeneralAutoGenerateIPAddress_A19320.UIName;
			}
		}

		// Token: 0x17005703 RID: 22275
		// (get) Token: 0x0600AD97 RID: 44439 RVA: 0x00A194E0 File Offset: 0x00A176E0
		// (set) Token: 0x0600AD98 RID: 44440 RVA: 0x00A19594 File Offset: 0x00A17794
		internal bool DataProfGeneralAutoGenerateIPAddress_A19320_HiddenStatic
		{
			get
			{
				short num = (short)940426307;
				short num2 = num;
				num = (short)867222595;
				switch (num2 == num)
				{
				}
				num = (short)668860417;
				if (num != 0)
				{
				}
				num = (short)1011875840;
				if (num != 0)
				{
				}
				num = (short)16580608;
				short num3 = num;
				return this.dataProfGeneralAutoGenerateIPAddress_A19320.HiddenStatic;
			}
			set
			{
				short num = (short)1818708198;
				short num2 = num;
				num = (short)392644838;
				switch (num2 == num)
				{
				}
				num = (short)168755201;
				if (num != 0)
				{
				}
				num = (short)1592655872;
				if (num != 0)
				{
				}
				num = (short)535822336;
				short num3 = num;
				this.dataProfGeneralAutoGenerateIPAddress_A19320.HiddenStatic = value;
			}
		}

		// Token: 0x17005704 RID: 22276
		// (get) Token: 0x0600AD99 RID: 44441 RVA: 0x00A19648 File Offset: 0x00A17848
		// (set) Token: 0x0600AD9A RID: 44442 RVA: 0x00A19700 File Offset: 0x00A17900
		internal bool DataProfGeneralAutoGenerateIPAddress_A19320_HiddenDynamic
		{
			get
			{
				short num = (short)1616375033;
				short num2 = num;
				num = (short)631303417;
				switch (num2 == num)
				{
				}
				num = (short)718536705;
				if (num != 0)
				{
				}
				num = (short)1488453632;
				if (num != 0)
				{
				}
				num = (short)70189056;
				short num3 = num;
				return this.dataProfGeneralAutoGenerateIPAddress_A19320.HiddenDynamic;
			}
			set
			{
				short num = (short)1772510854;
				short num2 = num;
				num = (short)376462982;
				switch (num2 == num)
				{
				}
				num = (short)1379139585;
				if (num != 0)
				{
				}
				num = (short)965017600;
				if (num != 0)
				{
				}
				num = (short)1785921536;
				short num3 = num;
				this.dataProfGeneralAutoGenerateIPAddress_A19320.HiddenDynamic = value;
			}
		}

		// Token: 0x17005705 RID: 22277
		// (get) Token: 0x0600AD9B RID: 44443 RVA: 0x00A197B8 File Offset: 0x00A179B8
		public bool DataProfGeneralAutoGenerateIPAddress_A19320_HasDiffs
		{
			get
			{
				short num = (short)1855193089;
				if (num != 0)
				{
				}
				num = (short)1602637803;
				short num2 = num;
				num = (short)2065321963;
				switch (num2 == num)
				{
				}
				num = (short)387448832;
				if (num != 0)
				{
				}
				num = (short)482082816;
				short num3 = num;
				return this.dataProfGeneralAutoGenerateIPAddress_A19320._HasDiffs;
			}
		}

		// Token: 0x17005706 RID: 22278
		// (get) Token: 0x0600AD9C RID: 44444 RVA: 0x00A1986C File Offset: 0x00A17A6C
		// (set) Token: 0x0600AD9D RID: 44445 RVA: 0x00A19920 File Offset: 0x00A17B20
		public string DataProfGeneralkeyofDataProfiles_A19446Value
		{
			get
			{
				short num = (short)1220339980;
				short num2 = num;
				num = (short)680126732;
				switch (num2 == num)
				{
				}
				num = (short)831913985;
				if (num != 0)
				{
				}
				num = (short)385679360;
				if (num != 0)
				{
				}
				num = (short)1802108928;
				short num3 = num;
				return this.dataProfGeneralkeyofDataProfiles_A19446.Value;
			}
			set
			{
				short num = (short)320143362;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						IL_53:
						this.dataProfGeneralkeyofDataProfiles_A19446.Value = value;
						num = (short)1007484929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_77;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					if (!string.IsNullOrEmpty(value.Trim()))
					{
						num = (short)83492864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_77:
					num = (short)1717376001;
					short num3 = num;
					num = (short)1577653249;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_53;
					default:
						goto IL_AC;
					}
				}
				IL_AC:
				num = (short)282198017;
				if (num != 0)
				{
				}
				num = (short)362676224;
				if (num != 0)
				{
				}
				num = (short)1090256896;
				short num4 = num;
			}
		}

		// Token: 0x17005707 RID: 22279
		// (get) Token: 0x0600AD9E RID: 44446 RVA: 0x00A19A40 File Offset: 0x00A17C40
		// (set) Token: 0x0600AD9F RID: 44447 RVA: 0x00A19AF8 File Offset: 0x00A17CF8
		public string DataProfGeneralkeyofDataProfiles_A19446_UIValue
		{
			get
			{
				short num = (short)280952833;
				if (num != 0)
				{
				}
				num = (short)1201873005;
				short num2 = num;
				num = (short)452730989;
				switch (num2 == num)
				{
				}
				num = (short)881917952;
				if (num != 0)
				{
				}
				num = (short)1388052480;
				short num3 = num;
				return this.dataProfGeneralkeyofDataProfiles_A19446.Value;
			}
			set
			{
				short num = (short)1126968740;
				short num2 = num;
				num = (short)1681141156;
				switch (num2 == num)
				{
				}
				num = (short)773586944;
				if (num != 0)
				{
				}
				num = (short)1201537025;
				if (num != 0)
				{
				}
				num = (short)1353711616;
				short num3 = num;
				this.dataProfGeneralkeyofDataProfiles_A19446.Value = value;
			}
		}

		// Token: 0x17005708 RID: 22280
		// (get) Token: 0x0600ADA0 RID: 44448 RVA: 0x00A19BAC File Offset: 0x00A17DAC
		public global::AcpBusinessLayer.AcpKeyField DataProfGeneralkeyofDataProfiles_A19446
		{
			get
			{
				short num = (short)806892960;
				short num2 = num;
				num = (short)764753312;
				switch (num2 == num)
				{
				}
				num = (short)800391169;
				if (num != 0)
				{
				}
				num = (short)58195968;
				if (num != 0)
				{
				}
				num = (short)2022834176;
				short num3 = num;
				return this.dataProfGeneralkeyofDataProfiles_A19446;
			}
		}

		// Token: 0x17005709 RID: 22281
		// (get) Token: 0x0600ADA1 RID: 44449 RVA: 0x00A19C58 File Offset: 0x00A17E58
		// (set) Token: 0x0600ADA2 RID: 44450 RVA: 0x00A19D10 File Offset: 0x00A17F10
		public bool DataProfGeneralkeyofDataProfiles_A19446_Applicable
		{
			get
			{
				short num = (short)123994113;
				if (num != 0)
				{
				}
				num = (short)281018886;
				short num2 = num;
				num = (short)1693123078;
				switch (num2 == num)
				{
				}
				num = (short)107544576;
				if (num != 0)
				{
				}
				num = (short)182124544;
				short num3 = num;
				return this.dataProfGeneralkeyofDataProfiles_A19446.Applicable;
			}
			set
			{
				short num = (short)1449483325;
				short num2 = num;
				num = (short)1062362173;
				switch (num2 == num)
				{
				}
				num = (short)47775744;
				if (num != 0)
				{
				}
				num = (short)939917313;
				if (num != 0)
				{
				}
				num = (short)1705246720;
				short num3 = num;
				this.dataProfGeneralkeyofDataProfiles_A19446.Applicable = value;
			}
		}

		// Token: 0x1700570A RID: 22282
		// (get) Token: 0x0600ADA3 RID: 44451 RVA: 0x00A19DC4 File Offset: 0x00A17FC4
		// (set) Token: 0x0600ADA4 RID: 44452 RVA: 0x00A19E78 File Offset: 0x00A18078
		public bool DataProfGeneralkeyofDataProfiles_A19446_Valid
		{
			get
			{
				short num = (short)1639246444;
				short num2 = num;
				num = (short)980806252;
				switch (num2 == num)
				{
				}
				num = (short)1871314945;
				if (num != 0)
				{
				}
				num = (short)288292864;
				if (num != 0)
				{
				}
				num = (short)1161428992;
				short num3 = num;
				return this.dataProfGeneralkeyofDataProfiles_A19446.Valid;
			}
			set
			{
				short num = (short)151736870;
				short num2 = num;
				num = (short)999772710;
				switch (num2 == num)
				{
				}
				num = (short)1254162433;
				if (num != 0)
				{
				}
				num = (short)682557440;
				if (num != 0)
				{
				}
				num = (short)1383727104;
				short num3 = num;
				this.dataProfGeneralkeyofDataProfiles_A19446.Valid = value;
			}
		}

		// Token: 0x1700570B RID: 22283
		// (get) Token: 0x0600ADA5 RID: 44453 RVA: 0x00A19F2C File Offset: 0x00A1812C
		// (set) Token: 0x0600ADA6 RID: 44454 RVA: 0x00A19FE4 File Offset: 0x00A181E4
		public bool DataProfGeneralkeyofDataProfiles_A19446_Visible
		{
			get
			{
				short num = (short)1129107234;
				short num2 = num;
				num = (short)35049250;
				switch (num2 == num)
				{
				}
				num = (short)648478721;
				if (num != 0)
				{
				}
				num = (short)1980628992;
				if (num != 0)
				{
				}
				num = (short)1985806336;
				short num3 = num;
				return this.dataProfGeneralkeyofDataProfiles_A19446.Visible;
			}
			set
			{
				short num = (short)733741057;
				if (num != 0)
				{
				}
				num = (short)378459734;
				short num2 = num;
				num = (short)1239668310;
				switch (num2 == num)
				{
				}
				num = (short)2097152;
				if (num != 0)
				{
				}
				num = (short)1195769856;
				short num3 = num;
				this.dataProfGeneralkeyofDataProfiles_A19446.Visible = value;
			}
		}

		// Token: 0x1700570C RID: 22284
		// (get) Token: 0x0600ADA7 RID: 44455 RVA: 0x00A1A09C File Offset: 0x00A1829C
		// (set) Token: 0x0600ADA8 RID: 44456 RVA: 0x00A1A154 File Offset: 0x00A18354
		public bool DataProfGeneralkeyofDataProfiles_A19446_Editable
		{
			get
			{
				short num = (short)1207377870;
				short num2 = num;
				num = (short)1834360782;
				switch (num2 == num)
				{
				}
				num = (short)2130051073;
				if (num != 0)
				{
				}
				num = (short)927137792;
				if (num != 0)
				{
				}
				num = (short)990248960;
				short num3 = num;
				return this.dataProfGeneralkeyofDataProfiles_A19446.Editable;
			}
			set
			{
				short num = (short)155161029;
				short num2 = num;
				num = (short)1074893253;
				switch (num2 == num)
				{
				}
				num = (short)1124728832;
				if (num != 0)
				{
				}
				num = (short)119013377;
				if (num != 0)
				{
				}
				num = (short)565051392;
				short num3 = num;
				this.dataProfGeneralkeyofDataProfiles_A19446.Editable = value;
			}
		}

		// Token: 0x1700570D RID: 22285
		// (get) Token: 0x0600ADA9 RID: 44457 RVA: 0x00A1A208 File Offset: 0x00A18408
		internal string DataProfGeneralkeyofDataProfiles_A19446_UILabel
		{
			get
			{
				short num = (short)102393545;
				short num2 = num;
				num = (short)1124951753;
				switch (num2 == num)
				{
				}
				num = (short)990642177;
				if (num != 0)
				{
				}
				num = (short)1556938752;
				if (num != 0)
				{
				}
				num = (short)1504509952;
				short num3 = num;
				return this.dataProfGeneralkeyofDataProfiles_A19446.UIName;
			}
		}

		// Token: 0x1700570E RID: 22286
		// (get) Token: 0x0600ADAA RID: 44458 RVA: 0x00A1A2BC File Offset: 0x00A184BC
		// (set) Token: 0x0600ADAB RID: 44459 RVA: 0x00A1A370 File Offset: 0x00A18570
		internal bool DataProfGeneralkeyofDataProfiles_A19446_HiddenStatic
		{
			get
			{
				short num = (short)1963762225;
				short num2 = num;
				num = (short)1467392561;
				switch (num2 == num)
				{
				}
				num = (short)1320419329;
				if (num != 0)
				{
				}
				num = (short)2131689472;
				if (num != 0)
				{
				}
				num = (short)806223872;
				short num3 = num;
				return this.dataProfGeneralkeyofDataProfiles_A19446.HiddenStatic;
			}
			set
			{
				short num = (short)876609537;
				if (num != 0)
				{
				}
				num = (short)1935360903;
				short num2 = num;
				num = (short)315835271;
				switch (num2 == num)
				{
				}
				num = (short)1603862528;
				if (num != 0)
				{
				}
				num = (short)606732288;
				short num3 = num;
				this.dataProfGeneralkeyofDataProfiles_A19446.HiddenStatic = value;
			}
		}

		// Token: 0x1700570F RID: 22287
		// (get) Token: 0x0600ADAC RID: 44460 RVA: 0x00A1A424 File Offset: 0x00A18624
		// (set) Token: 0x0600ADAD RID: 44461 RVA: 0x00A1A4D4 File Offset: 0x00A186D4
		internal bool DataProfGeneralkeyofDataProfiles_A19446_HiddenDynamic
		{
			get
			{
				short num = (short)1380369099;
				short num2 = num;
				num = (short)1699398347;
				switch (num2 == num)
				{
				}
				num = (short)863043585;
				if (num != 0)
				{
				}
				num = (short)1237975040;
				if (num != 0)
				{
				}
				num = (short)665583616;
				short num3 = num;
				return this.dataProfGeneralkeyofDataProfiles_A19446.HiddenDynamic;
			}
			set
			{
				short num = (short)1120206849;
				if (num != 0)
				{
				}
				num = (short)2091228023;
				short num2 = num;
				num = (short)1172544375;
				switch (num2 == num)
				{
				}
				num = (short)2136932352;
				if (num != 0)
				{
				}
				num = (short)1089601536;
				short num3 = num;
				this.dataProfGeneralkeyofDataProfiles_A19446.HiddenDynamic = value;
			}
		}

		// Token: 0x17005710 RID: 22288
		// (get) Token: 0x0600ADAE RID: 44462 RVA: 0x00A1A588 File Offset: 0x00A18788
		public bool DataProfGeneralkeyofDataProfiles_A19446_HasDiffs
		{
			get
			{
				short num = (short)61467807;
				short num2 = num;
				num = (short)859237535;
				switch (num2 == num)
				{
				}
				num = (short)429916161;
				if (num != 0)
				{
				}
				num = (short)751501312;
				if (num != 0)
				{
				}
				num = (short)307167232;
				short num3 = num;
				return this.dataProfGeneralkeyofDataProfiles_A19446._HasDiffs;
			}
		}

		// Token: 0x17005711 RID: 22289
		// (get) Token: 0x0600ADAF RID: 44463 RVA: 0x00A1A640 File Offset: 0x00A18840
		// (set) Token: 0x0600ADB0 RID: 44464 RVA: 0x00A1A6F4 File Offset: 0x00A188F4
		public long DataProfGeneralSubscriberIPAddress_A21157Value
		{
			get
			{
				short num = (short)1494174869;
				short num2 = num;
				num = (short)136989845;
				switch (num2 == num)
				{
				}
				num = (short)1787428865;
				if (num != 0)
				{
				}
				num = (short)566034432;
				if (num != 0)
				{
				}
				num = (short)732430336;
				short num3 = num;
				return this.dataProfGeneralSubscriberIPAddress_A21157.Value;
			}
			set
			{
				short num = (short)2016171933;
				short num2 = num;
				num = (short)1287346077;
				switch (num2 == num)
				{
				}
				num = (short)1967325185;
				if (num != 0)
				{
				}
				num = (short)158334976;
				if (num != 0)
				{
				}
				num = (short)376307712;
				short num3 = num;
				this.dataProfGeneralSubscriberIPAddress_A21157.Value = value;
			}
		}

		// Token: 0x17005712 RID: 22290
		// (get) Token: 0x0600ADB1 RID: 44465 RVA: 0x00A1A7AC File Offset: 0x00A189AC
		// (set) Token: 0x0600ADB2 RID: 44466 RVA: 0x00A1A860 File Offset: 0x00A18A60
		public string DataProfGeneralSubscriberIPAddress_A21157_UIValue
		{
			get
			{
				short num = (short)109969409;
				if (num != 0)
				{
				}
				num = (short)2141231989;
				short num2 = num;
				num = (short)1203149685;
				switch (num2 == num)
				{
				}
				num = (short)386465792;
				if (num != 0)
				{
				}
				num = (short)85655552;
				short num3 = num;
				return this.dataProfGeneralSubscriberIPAddress_A21157.UIValue;
			}
			set
			{
				short num = (short)885531943;
				short num2 = num;
				num = (short)92480807;
				switch (num2 == num)
				{
				}
				num = (short)1084489729;
				if (num != 0)
				{
				}
				num = (short)1269563392;
				if (num != 0)
				{
				}
				num = (short)1824194560;
				short num3 = num;
				this.dataProfGeneralSubscriberIPAddress_A21157.UIValue = value;
			}
		}

		// Token: 0x17005713 RID: 22291
		// (get) Token: 0x0600ADB3 RID: 44467 RVA: 0x00A1A914 File Offset: 0x00A18B14
		public global::AcpBusinessLayer.AcpIPAddressField DataProfGeneralSubscriberIPAddress_A21157
		{
			get
			{
				short num = (short)978669539;
				short num2 = num;
				num = (short)1142575075;
				switch (num2 == num)
				{
				}
				num = (short)1955856385;
				if (num != 0)
				{
				}
				num = (short)2056978432;
				if (num != 0)
				{
				}
				num = (short)178847744;
				short num3 = num;
				return this.dataProfGeneralSubscriberIPAddress_A21157;
			}
		}

		// Token: 0x17005714 RID: 22292
		// (get) Token: 0x0600ADB4 RID: 44468 RVA: 0x00A1A9C4 File Offset: 0x00A18BC4
		// (set) Token: 0x0600ADB5 RID: 44469 RVA: 0x00A1AA78 File Offset: 0x00A18C78
		public bool DataProfGeneralSubscriberIPAddress_A21157_Applicable
		{
			get
			{
				short num = (short)143338255;
				short num2 = num;
				num = (short)119024399;
				switch (num2 == num)
				{
				}
				num = (short)846397440;
				if (num != 0)
				{
				}
				num = (short)379322369;
				if (num != 0)
				{
				}
				num = (short)350486528;
				short num3 = num;
				return this.dataProfGeneralSubscriberIPAddress_A21157.Applicable;
			}
			set
			{
				short num = (short)1751861222;
				short num2 = num;
				num = (short)1821132774;
				switch (num2 == num)
				{
				}
				num = (short)624623617;
				if (num != 0)
				{
				}
				num = (short)1946746880;
				if (num != 0)
				{
				}
				num = (short)759365632;
				short num3 = num;
				this.dataProfGeneralSubscriberIPAddress_A21157.Applicable = value;
			}
		}

		// Token: 0x17005715 RID: 22293
		// (get) Token: 0x0600ADB6 RID: 44470 RVA: 0x00A1AB2C File Offset: 0x00A18D2C
		// (set) Token: 0x0600ADB7 RID: 44471 RVA: 0x00A1ABE0 File Offset: 0x00A18DE0
		public bool DataProfGeneralSubscriberIPAddress_A21157_Valid
		{
			get
			{
				short num = (short)333381633;
				if (num != 0)
				{
				}
				num = (short)236814550;
				short num2 = num;
				num = (short)1290371286;
				switch (num2 == num)
				{
				}
				num = (short)159711232;
				if (num != 0)
				{
				}
				num = (short)1256718336;
				short num3 = num;
				return this.dataProfGeneralSubscriberIPAddress_A21157.Valid;
			}
			set
			{
				short num = (short)1538040357;
				short num2 = num;
				num = (short)569811493;
				switch (num2 == num)
				{
				}
				num = (short)874971137;
				if (num != 0)
				{
				}
				num = (short)1033961472;
				if (num != 0)
				{
				}
				num = (short)1504051200;
				short num3 = num;
				this.dataProfGeneralSubscriberIPAddress_A21157.Valid = value;
			}
		}

		// Token: 0x17005716 RID: 22294
		// (get) Token: 0x0600ADB8 RID: 44472 RVA: 0x00A1AC94 File Offset: 0x00A18E94
		// (set) Token: 0x0600ADB9 RID: 44473 RVA: 0x00A1AD4C File Offset: 0x00A18F4C
		public bool DataProfGeneralSubscriberIPAddress_A21157_Visible
		{
			get
			{
				short num = (short)1388329067;
				short num2 = num;
				num = (short)1792358507;
				switch (num2 == num)
				{
				}
				num = (short)1658978305;
				if (num != 0)
				{
				}
				num = (short)863174656;
				short num3 = num;
				num = (short)1254752256;
				if (num != 0)
				{
				}
				return this.dataProfGeneralSubscriberIPAddress_A21157.Visible;
			}
			set
			{
				short num = (short)946692375;
				short num2 = num;
				num = (short)1409179927;
				switch (num2 == num)
				{
				}
				num = (short)1898250241;
				if (num != 0)
				{
				}
				num = (short)1989279744;
				short num3 = num;
				num = (short)1767899136;
				if (num != 0)
				{
				}
				this.dataProfGeneralSubscriberIPAddress_A21157.Visible = value;
			}
		}

		// Token: 0x17005717 RID: 22295
		// (get) Token: 0x0600ADBA RID: 44474 RVA: 0x00A1AE00 File Offset: 0x00A19000
		// (set) Token: 0x0600ADBB RID: 44475 RVA: 0x00A1AEB8 File Offset: 0x00A190B8
		public bool DataProfGeneralSubscriberIPAddress_A21157_Editable
		{
			get
			{
				short num = (short)327887560;
				short num2 = num;
				num = (short)206973640;
				switch (num2 == num)
				{
				}
				num = (short)1707343873;
				if (num != 0)
				{
				}
				num = (short)1732640768;
				short num3 = num;
				num = (short)478216192;
				if (num != 0)
				{
				}
				return this.dataProfGeneralSubscriberIPAddress_A21157.Editable;
			}
			set
			{
				short num = (short)2008219649;
				if (num != 0)
				{
				}
				num = (short)996267336;
				short num2 = num;
				num = (short)81843528;
				switch (num2 == num)
				{
				}
				num = (short)1811742720;
				short num3 = num;
				num = (short)334626816;
				if (num != 0)
				{
				}
				this.dataProfGeneralSubscriberIPAddress_A21157.Editable = value;
			}
		}

		// Token: 0x17005718 RID: 22296
		// (get) Token: 0x0600ADBC RID: 44476 RVA: 0x00A1AF70 File Offset: 0x00A19170
		internal string DataProfGeneralSubscriberIPAddress_A21157_UILabel
		{
			get
			{
				short num = (short)1077280769;
				if (num != 0)
				{
				}
				num = (short)816743291;
				short num2 = num;
				num = (short)658146171;
				switch (num2 == num)
				{
				}
				num = (short)879362048;
				short num3 = num;
				num = (short)1203503104;
				if (num != 0)
				{
				}
				return this.dataProfGeneralSubscriberIPAddress_A21157.UIName;
			}
		}

		// Token: 0x17005719 RID: 22297
		// (get) Token: 0x0600ADBD RID: 44477 RVA: 0x00A1B028 File Offset: 0x00A19228
		// (set) Token: 0x0600ADBE RID: 44478 RVA: 0x00A1B0DC File Offset: 0x00A192DC
		internal bool DataProfGeneralSubscriberIPAddress_A21157_HiddenStatic
		{
			get
			{
				short num = (short)781231790;
				short num2 = num;
				num = (short)336045742;
				switch (num2 == num)
				{
				}
				num = (short)1703608320;
				if (num != 0)
				{
				}
				num = (short)747765760;
				short num3 = num;
				num = (short)1300365313;
				if (num != 0)
				{
				}
				return this.dataProfGeneralSubscriberIPAddress_A21157.HiddenStatic;
			}
			set
			{
				short num = (short)3464134;
				short num2 = num;
				num = (short)1503189958;
				switch (num2 == num)
				{
				}
				num = (short)1367015425;
				if (num != 0)
				{
				}
				num = (short)105709568;
				short num3 = num;
				num = (short)716898304;
				if (num != 0)
				{
				}
				this.dataProfGeneralSubscriberIPAddress_A21157.HiddenStatic = value;
			}
		}

		// Token: 0x1700571A RID: 22298
		// (get) Token: 0x0600ADBF RID: 44479 RVA: 0x00A1B194 File Offset: 0x00A19394
		// (set) Token: 0x0600ADC0 RID: 44480 RVA: 0x00A1B248 File Offset: 0x00A19448
		internal bool DataProfGeneralSubscriberIPAddress_A21157_HiddenDynamic
		{
			get
			{
				short num = (short)337052337;
				short num2 = num;
				num = (short)47186609;
				switch (num2 == num)
				{
				}
				num = (short)1215627265;
				if (num != 0)
				{
				}
				num = (short)1187250176;
				short num3 = num;
				num = (short)98369536;
				if (num != 0)
				{
				}
				return this.dataProfGeneralSubscriberIPAddress_A21157.HiddenDynamic;
			}
			set
			{
				short num = (short)1119223809;
				if (num != 0)
				{
				}
				num = (short)1045862682;
				short num2 = num;
				num = (short)665032986;
				switch (num2 == num)
				{
				}
				num = (short)1952055296;
				short num3 = num;
				num = (short)818872320;
				if (num != 0)
				{
				}
				this.dataProfGeneralSubscriberIPAddress_A21157.HiddenDynamic = value;
			}
		}

		// Token: 0x1700571B RID: 22299
		// (get) Token: 0x0600ADC1 RID: 44481 RVA: 0x00A1B2FC File Offset: 0x00A194FC
		public bool DataProfGeneralSubscriberIPAddress_A21157_HasDiffs
		{
			get
			{
				short num = (short)16450761;
				short num2 = num;
				num = (short)1236206793;
				switch (num2 == num)
				{
				}
				num = (short)410189825;
				if (num != 0)
				{
				}
				num = (short)371654656;
				short num3 = num;
				num = (short)547028992;
				if (num != 0)
				{
				}
				return this.dataProfGeneralSubscriberIPAddress_A21157._HasDiffs;
			}
		}

		// Token: 0x1700571C RID: 22300
		// (get) Token: 0x0600ADC2 RID: 44482 RVA: 0x00A1B3AC File Offset: 0x00A195AC
		// (set) Token: 0x0600ADC3 RID: 44483 RVA: 0x00A1B460 File Offset: 0x00A19660
		public int DataProfGeneralDataProfileType_A21320Value
		{
			get
			{
				short num = (short)1765037947;
				short num2 = num;
				num = (short)700471163;
				switch (num2 == num)
				{
				}
				num = (short)1970798593;
				if (num != 0)
				{
				}
				num = (short)65732608;
				short num3 = num;
				num = (short)1437007872;
				if (num != 0)
				{
				}
				return this.dataProfGeneralDataProfileType_A21320.Value;
			}
			set
			{
				short num = (short)1389683151;
				short num2 = num;
				num = (short)1305862607;
				switch (num2 == num)
				{
				}
				num = (short)680001536;
				if (num != 0)
				{
				}
				num = (short)2011496448;
				short num3 = num;
				num = (short)2138636289;
				if (num != 0)
				{
				}
				this.dataProfGeneralDataProfileType_A21320.Value = value;
			}
		}

		// Token: 0x1700571D RID: 22301
		// (get) Token: 0x0600ADC4 RID: 44484 RVA: 0x00A1B514 File Offset: 0x00A19714
		// (set) Token: 0x0600ADC5 RID: 44485 RVA: 0x00A1B5C8 File Offset: 0x00A197C8
		public string DataProfGeneralDataProfileType_A21320_UIValue
		{
			get
			{
				short num = (short)100749836;
				short num2 = num;
				num = (short)708203020;
				switch (num2 == num)
				{
				}
				num = (short)101580801;
				if (num != 0)
				{
				}
				num = (short)17170432;
				short num3 = num;
				num = (short)416088064;
				if (num != 0)
				{
				}
				return this.dataProfGeneralDataProfileType_A21320.UIValue;
			}
			set
			{
				short num = (short)1531227773;
				short num2 = num;
				num = (short)503099005;
				switch (num2 == num)
				{
				}
				num = (short)1947140096;
				if (num != 0)
				{
				}
				num = (short)860094464;
				short num3 = num;
				num = (short)1883373569;
				if (num != 0)
				{
				}
				this.dataProfGeneralDataProfileType_A21320.UIValue = value;
			}
		}

		// Token: 0x1700571E RID: 22302
		// (get) Token: 0x0600ADC6 RID: 44486 RVA: 0x00A1B67C File Offset: 0x00A1987C
		public global::AcpBusinessLayer.AcpListField DataProfGeneralDataProfileType_A21320
		{
			get
			{
				short num = (short)163373162;
				short num2 = num;
				num = (short)1127735402;
				switch (num2 == num)
				{
				}
				num = (short)1313144833;
				if (num != 0)
				{
				}
				num = (short)1167196160;
				short num3 = num;
				num = (short)34865152;
				if (num != 0)
				{
				}
				return this.dataProfGeneralDataProfileType_A21320;
			}
		}

		// Token: 0x1700571F RID: 22303
		// (get) Token: 0x0600ADC7 RID: 44487 RVA: 0x00A1B730 File Offset: 0x00A19930
		// (set) Token: 0x0600ADC8 RID: 44488 RVA: 0x00A1B7E8 File Offset: 0x00A199E8
		public bool DataProfGeneralDataProfileType_A21320_Applicable
		{
			get
			{
				short num = (short)1720828440;
				short num2 = num;
				num = (short)855556632;
				switch (num2 == num)
				{
				}
				num = (short)772014080;
				if (num != 0)
				{
				}
				num = (short)113639424;
				short num3 = num;
				num = (short)1010499585;
				if (num != 0)
				{
				}
				return this.dataProfGeneralDataProfileType_A21320.Applicable;
			}
			set
			{
				short num = (short)1688548086;
				short num2 = num;
				num = (short)1746285302;
				switch (num2 == num)
				{
				}
				num = (short)1919549440;
				if (num != 0)
				{
				}
				num = (short)494534656;
				short num3 = num;
				num = (short)2023882753;
				if (num != 0)
				{
				}
				this.dataProfGeneralDataProfileType_A21320.Applicable = value;
			}
		}

		// Token: 0x17005720 RID: 22304
		// (get) Token: 0x0600ADC9 RID: 44489 RVA: 0x00A1B89C File Offset: 0x00A19A9C
		// (set) Token: 0x0600ADCA RID: 44490 RVA: 0x00A1B950 File Offset: 0x00A19B50
		public bool DataProfGeneralDataProfileType_A21320_Valid
		{
			get
			{
				short num = (short)1462669986;
				short num2 = num;
				num = (short)1209373346;
				switch (num2 == num)
				{
				}
				num = (short)876806145;
				if (num != 0)
				{
				}
				num = (short)925040640;
				short num3 = num;
				num = (short)1957560320;
				if (num != 0)
				{
				}
				return this.dataProfGeneralDataProfileType_A21320.Valid;
			}
			set
			{
				short num = (short)508168874;
				short num2 = num;
				num = (short)580979370;
				switch (num2 == num)
				{
				}
				num = (short)1891696641;
				if (num != 0)
				{
				}
				num = (short)1678311424;
				short num3 = num;
				num = (short)449511424;
				if (num != 0)
				{
				}
				this.dataProfGeneralDataProfileType_A21320.Valid = value;
			}
		}

		// Token: 0x17005721 RID: 22305
		// (get) Token: 0x0600ADCB RID: 44491 RVA: 0x00A1BA08 File Offset: 0x00A19C08
		// (set) Token: 0x0600ADCC RID: 44492 RVA: 0x00A1BAC0 File Offset: 0x00A19CC0
		public bool DataProfGeneralDataProfileType_A21320_Visible
		{
			get
			{
				short num = (short)1996851854;
				short num2 = num;
				num = (short)1404078734;
				switch (num2 == num)
				{
				}
				num = (short)1598291968;
				if (num != 0)
				{
				}
				num = (short)1465319424;
				short num3 = num;
				num = (short)393217;
				if (num != 0)
				{
				}
				return this.dataProfGeneralDataProfileType_A21320.Visible;
			}
			set
			{
				short num = (short)227070534;
				short num2 = num;
				num = (short)440586822;
				switch (num2 == num)
				{
				}
				num = (short)1813708800;
				if (num != 0)
				{
				}
				num = (short)2078212096;
				short num3 = num;
				num = (short)742719489;
				if (num != 0)
				{
				}
				this.dataProfGeneralDataProfileType_A21320.Visible = value;
			}
		}

		// Token: 0x17005722 RID: 22306
		// (get) Token: 0x0600ADCD RID: 44493 RVA: 0x00A1BB78 File Offset: 0x00A19D78
		// (set) Token: 0x0600ADCE RID: 44494 RVA: 0x00A1BC2C File Offset: 0x00A19E2C
		public bool DataProfGeneralDataProfileType_A21320_Editable
		{
			get
			{
				short num = (short)1887412088;
				short num2 = num;
				num = (short)1877778296;
				switch (num2 == num)
				{
				}
				num = (short)350420993;
				if (num != 0)
				{
				}
				num = (short)171180032;
				short num3 = num;
				num = (short)525926400;
				if (num != 0)
				{
				}
				return this.dataProfGeneralDataProfileType_A21320.Editable;
			}
			set
			{
				short num = (short)404160887;
				short num2 = num;
				num = (short)180683127;
				switch (num2 == num)
				{
				}
				num = (short)676659200;
				if (num != 0)
				{
				}
				num = (short)222429184;
				short num3 = num;
				num = (short)1034813441;
				if (num != 0)
				{
				}
				this.dataProfGeneralDataProfileType_A21320.Editable = value;
			}
		}

		// Token: 0x17005723 RID: 22307
		// (get) Token: 0x0600ADCF RID: 44495 RVA: 0x00A1BCE0 File Offset: 0x00A19EE0
		internal string DataProfGeneralDataProfileType_A21320_UILabel
		{
			get
			{
				short num = (short)1447690241;
				if (num != 0)
				{
				}
				num = (short)1441901934;
				short num2 = num;
				num = (short)523677038;
				switch (num2 == num)
				{
				}
				num = (short)362872832;
				short num3 = num;
				num = (short)951320576;
				if (num != 0)
				{
				}
				return this.dataProfGeneralDataProfileType_A21320.UIName;
			}
		}

		// Token: 0x17005724 RID: 22308
		// (get) Token: 0x0600ADD0 RID: 44496 RVA: 0x00A1BD94 File Offset: 0x00A19F94
		// (set) Token: 0x0600ADD1 RID: 44497 RVA: 0x00A1BE48 File Offset: 0x00A1A048
		internal bool DataProfGeneralDataProfileType_A21320_HiddenStatic
		{
			get
			{
				short num = (short)1692336218;
				short num2 = num;
				num = (short)2041970778;
				switch (num2 == num)
				{
				}
				num = (short)1044054016;
				if (num != 0)
				{
				}
				num = (short)281083904;
				short num3 = num;
				num = (short)1181089793;
				if (num != 0)
				{
				}
				return this.dataProfGeneralDataProfileType_A21320.HiddenStatic;
			}
			set
			{
				short num = (short)636097008;
				short num2 = num;
				num = (short)1833374192;
				switch (num2 == num)
				{
				}
				num = (short)963837952;
				if (num != 0)
				{
				}
				num = (short)1342767104;
				short num3 = num;
				num = (short)11468801;
				if (num != 0)
				{
				}
				this.dataProfGeneralDataProfileType_A21320.HiddenStatic = value;
			}
		}

		// Token: 0x17005725 RID: 22309
		// (get) Token: 0x0600ADD2 RID: 44498 RVA: 0x00A1BEFC File Offset: 0x00A1A0FC
		// (set) Token: 0x0600ADD3 RID: 44499 RVA: 0x00A1BFB4 File Offset: 0x00A1A1B4
		internal bool DataProfGeneralDataProfileType_A21320_HiddenDynamic
		{
			get
			{
				short num = (short)706541645;
				short num2 = num;
				num = (short)628619341;
				switch (num2 == num)
				{
				}
				num = (short)115343361;
				if (num != 0)
				{
				}
				num = (short)1717436416;
				short num3 = num;
				num = (short)1197801472;
				if (num != 0)
				{
				}
				return this.dataProfGeneralDataProfileType_A21320.HiddenDynamic;
			}
			set
			{
				short num = (short)154271745;
				if (num != 0)
				{
				}
				num = (short)1158565271;
				short num2 = num;
				num = (short)950488471;
				switch (num2 == num)
				{
				}
				num = (short)54591488;
				short num3 = num;
				num = (short)952172544;
				if (num != 0)
				{
				}
				this.dataProfGeneralDataProfileType_A21320.HiddenDynamic = value;
			}
		}

		// Token: 0x17005726 RID: 22310
		// (get) Token: 0x0600ADD4 RID: 44500 RVA: 0x00A1C068 File Offset: 0x00A1A268
		public bool DataProfGeneralDataProfileType_A21320_HasDiffs
		{
			get
			{
				short num = (short)626192090;
				short num2 = num;
				num = (short)744287962;
				switch (num2 == num)
				{
				}
				num = (short)252116993;
				if (num != 0)
				{
				}
				num = (short)1095303168;
				short num3 = num;
				num = (short)2032992256;
				if (num != 0)
				{
				}
				return this.dataProfGeneralDataProfileType_A21320._HasDiffs;
			}
		}

		// Token: 0x17005727 RID: 22311
		// (get) Token: 0x0600ADD5 RID: 44501 RVA: 0x00A1C11C File Offset: 0x00A1A31C
		// (set) Token: 0x0600ADD6 RID: 44502 RVA: 0x00A1C1D0 File Offset: 0x00A1A3D0
		public int DataWideGeneralPeerIPAddressAssignmentType_A22263Value
		{
			get
			{
				short num = (short)497537162;
				short num2 = num;
				num = (short)2007027850;
				switch (num2 == num)
				{
				}
				num = (short)788922369;
				if (num != 0)
				{
				}
				num = (short)1080295424;
				short num3 = num;
				num = (short)878510080;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType_A22263.Value;
			}
			set
			{
				short num = (short)1634337429;
				short num2 = num;
				num = (short)2068710037;
				switch (num2 == num)
				{
				}
				num = (short)241172480;
				if (num != 0)
				{
				}
				num = (short)677314560;
				short num3 = num;
				num = (short)535363585;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddressAssignmentType_A22263.Value = value;
			}
		}

		// Token: 0x17005728 RID: 22312
		// (get) Token: 0x0600ADD7 RID: 44503 RVA: 0x00A1C288 File Offset: 0x00A1A488
		// (set) Token: 0x0600ADD8 RID: 44504 RVA: 0x00A1C338 File Offset: 0x00A1A538
		public string DataWideGeneralPeerIPAddressAssignmentType_A22263_UIValue
		{
			get
			{
				short num = (short)910290361;
				short num2 = num;
				num = (short)390000057;
				switch (num2 == num)
				{
				}
				num = (short)1008205824;
				if (num != 0)
				{
				}
				num = (short)701825024;
				short num3 = num;
				num = (short)305266689;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType_A22263.UIValue;
			}
			set
			{
				short num = (short)785186817;
				if (num != 0)
				{
				}
				num = (short)932282671;
				short num2 = num;
				num = (short)861831471;
				switch (num2 == num)
				{
				}
				num = (short)2016870400;
				short num3 = num;
				num = (short)1532690432;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddressAssignmentType_A22263.UIValue = value;
			}
		}

		// Token: 0x17005729 RID: 22313
		// (get) Token: 0x0600ADD9 RID: 44505 RVA: 0x00A1C3F0 File Offset: 0x00A1A5F0
		public global::AcpBusinessLayer.AcpListField DataWideGeneralPeerIPAddressAssignmentType_A22263
		{
			get
			{
				short num = (short)704035352;
				short num2 = num;
				num = (short)215530008;
				switch (num2 == num)
				{
				}
				num = (short)2031812609;
				if (num != 0)
				{
				}
				num = (short)336003072;
				short num3 = num;
				num = (short)284033024;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType_A22263;
			}
		}

		// Token: 0x1700572A RID: 22314
		// (get) Token: 0x0600ADDA RID: 44506 RVA: 0x00A1C4A0 File Offset: 0x00A1A6A0
		// (set) Token: 0x0600ADDB RID: 44507 RVA: 0x00A1C558 File Offset: 0x00A1A758
		public bool DataWideGeneralPeerIPAddressAssignmentType_A22263_Applicable
		{
			get
			{
				short num = (short)346488833;
				if (num != 0)
				{
				}
				num = (short)306033152;
				short num2 = num;
				num = (short)1418179072;
				switch (num2 == num)
				{
				}
				num = (short)1023279104;
				short num3 = num;
				num = (short)1291517952;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType_A22263.Applicable;
			}
			set
			{
				short num = (short)493482254;
				short num2 = num;
				num = (short)1567551758;
				switch (num2 == num)
				{
				}
				num = (short)1820000256;
				if (num != 0)
				{
				}
				num = (short)495255552;
				short num3 = num;
				num = (short)1658585089;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddressAssignmentType_A22263.Applicable = value;
			}
		}

		// Token: 0x1700572B RID: 22315
		// (get) Token: 0x0600ADDC RID: 44508 RVA: 0x00A1C60C File Offset: 0x00A1A80C
		// (set) Token: 0x0600ADDD RID: 44509 RVA: 0x00A1C6C0 File Offset: 0x00A1A8C0
		public bool DataWideGeneralPeerIPAddressAssignmentType_A22263_Valid
		{
			get
			{
				short num = (short)1522115673;
				short num2 = num;
				num = (short)2134352985;
				switch (num2 == num)
				{
				}
				num = (short)2108227585;
				if (num != 0)
				{
				}
				num = (short)522190848;
				short num3 = num;
				num = (short)1206059008;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType_A22263.Valid;
			}
			set
			{
				short num = (short)1687158785;
				if (num != 0)
				{
				}
				num = (short)1511194894;
				short num2 = num;
				num = (short)1947402510;
				switch (num2 == num)
				{
				}
				num = (short)196542464;
				short num3 = num;
				num = (short)750190592;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddressAssignmentType_A22263.Valid = value;
			}
		}

		// Token: 0x1700572C RID: 22316
		// (get) Token: 0x0600ADDE RID: 44510 RVA: 0x00A1C778 File Offset: 0x00A1A978
		// (set) Token: 0x0600ADDF RID: 44511 RVA: 0x00A1C828 File Offset: 0x00A1AA28
		public bool DataWideGeneralPeerIPAddressAssignmentType_A22263_Visible
		{
			get
			{
				short num = (short)64920658;
				short num2 = num;
				num = (short)1992727634;
				switch (num2 == num)
				{
				}
				num = (short)959774721;
				if (num != 0)
				{
				}
				num = (short)1761148928;
				short num3 = num;
				num = (short)779288576;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType_A22263.Visible;
			}
			set
			{
				short num = (short)1232071447;
				short num2 = num;
				num = (short)1656613655;
				switch (num2 == num)
				{
				}
				num = (short)1449656321;
				if (num != 0)
				{
				}
				num = (short)1888288768;
				short num3 = num;
				num = (short)1772552192;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddressAssignmentType_A22263.Visible = value;
			}
		}

		// Token: 0x1700572D RID: 22317
		// (get) Token: 0x0600ADE0 RID: 44512 RVA: 0x00A1C8E0 File Offset: 0x00A1AAE0
		// (set) Token: 0x0600ADE1 RID: 44513 RVA: 0x00A1C998 File Offset: 0x00A1AB98
		public bool DataWideGeneralPeerIPAddressAssignmentType_A22263_Editable
		{
			get
			{
				short num = (short)1789430530;
				short num2 = num;
				num = (short)887786242;
				switch (num2 == num)
				{
				}
				num = (short)1266352129;
				if (num != 0)
				{
				}
				num = (short)2134638592;
				short num3 = num;
				num = (short)1839005696;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType_A22263.Editable;
			}
			set
			{
				short num = (short)305831808;
				short num2 = num;
				num = (short)166567808;
				switch (num2 == num)
				{
				}
				num = (short)1350500352;
				if (num != 0)
				{
				}
				num = (short)1807810560;
				short num3 = num;
				num = (short)997326849;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddressAssignmentType_A22263.Editable = value;
			}
		}

		// Token: 0x1700572E RID: 22318
		// (get) Token: 0x0600ADE2 RID: 44514 RVA: 0x00A1CA50 File Offset: 0x00A1AC50
		internal string DataWideGeneralPeerIPAddressAssignmentType_A22263_UILabel
		{
			get
			{
				short num = (short)1018036225;
				if (num != 0)
				{
				}
				num = (short)1305061996;
				short num2 = num;
				num = (short)1339730540;
				switch (num2 == num)
				{
				}
				num = (short)957874176;
				short num3 = num;
				num = (short)1088356352;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType_A22263.UIName;
			}
		}

		// Token: 0x1700572F RID: 22319
		// (get) Token: 0x0600ADE3 RID: 44515 RVA: 0x00A1CB08 File Offset: 0x00A1AD08
		// (set) Token: 0x0600ADE4 RID: 44516 RVA: 0x00A1CBBC File Offset: 0x00A1ADBC
		internal bool DataWideGeneralPeerIPAddressAssignmentType_A22263_HiddenStatic
		{
			get
			{
				short num = (short)327532033;
				short num2 = num;
				num = (short)1149877761;
				switch (num2 == num)
				{
				}
				num = (short)1291911168;
				if (num != 0)
				{
				}
				num = (short)814546944;
				short num3 = num;
				num = (short)678690817;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType_A22263.HiddenStatic;
			}
			set
			{
				short num = (short)1959281659;
				short num2 = num;
				num = (short)1837777915;
				switch (num2 == num)
				{
				}
				num = (short)1802567681;
				if (num != 0)
				{
				}
				num = (short)955908096;
				short num3 = num;
				num = (short)1942552576;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddressAssignmentType_A22263.HiddenStatic = value;
			}
		}

		// Token: 0x17005730 RID: 22320
		// (get) Token: 0x0600ADE5 RID: 44517 RVA: 0x00A1CC70 File Offset: 0x00A1AE70
		// (set) Token: 0x0600ADE6 RID: 44518 RVA: 0x00A1CD24 File Offset: 0x00A1AF24
		internal bool DataWideGeneralPeerIPAddressAssignmentType_A22263_HiddenDynamic
		{
			get
			{
				short num = (short)1773734607;
				short num2 = num;
				num = (short)178326223;
				switch (num2 == num)
				{
				}
				num = (short)932577280;
				if (num != 0)
				{
				}
				num = (short)378077184;
				short num3 = num;
				num = (short)118358017;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType_A22263.HiddenDynamic;
			}
			set
			{
				short num = (short)1129249416;
				short num2 = num;
				num = (short)1431370376;
				switch (num2 == num)
				{
				}
				num = (short)925106176;
				if (num != 0)
				{
				}
				num = (short)1751449600;
				short num3 = num;
				num = (short)650969089;
				if (num != 0)
				{
				}
				this.dataWideGeneralPeerIPAddressAssignmentType_A22263.HiddenDynamic = value;
			}
		}

		// Token: 0x17005731 RID: 22321
		// (get) Token: 0x0600ADE7 RID: 44519 RVA: 0x00A1CDD8 File Offset: 0x00A1AFD8
		public bool DataWideGeneralPeerIPAddressAssignmentType_A22263_HasDiffs
		{
			get
			{
				short num = (short)347449632;
				short num2 = num;
				num = (short)718776608;
				switch (num2 == num)
				{
				}
				num = (short)1279328256;
				if (num != 0)
				{
				}
				num = (short)2027749376;
				short num3 = num;
				num = (short)242876417;
				if (num != 0)
				{
				}
				return this.dataWideGeneralPeerIPAddressAssignmentType_A22263._HasDiffs;
			}
		}

		// Token: 0x17005732 RID: 22322
		// (get) Token: 0x0600ADE8 RID: 44520 RVA: 0x00A1CE8C File Offset: 0x00A1B08C
		// (set) Token: 0x0600ADE9 RID: 44521 RVA: 0x00A1CF44 File Offset: 0x00A1B144
		public bool DataConfigDataProfIPHeaderCompressionEnable_A36190Value
		{
			get
			{
				short num = (short)1744550667;
				short num2 = num;
				num = (short)814070539;
				switch (num2 == num)
				{
				}
				num = (short)1038876672;
				if (num != 0)
				{
				}
				num = (short)1786118144;
				short num3 = num;
				num = (short)1455226881;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfIPHeaderCompressionEnable_A36190.Value;
			}
			set
			{
				short num = (short)730030863;
				short num2 = num;
				num = (short)1648583439;
				switch (num2 == num)
				{
				}
				num = (short)1788870656;
				if (num != 0)
				{
				}
				num = (short)243990528;
				short num3 = num;
				num = (short)2146631681;
				if (num != 0)
				{
				}
				this.dataConfigDataProfIPHeaderCompressionEnable_A36190.Value = value;
			}
		}

		// Token: 0x17005733 RID: 22323
		// (get) Token: 0x0600ADEA RID: 44522 RVA: 0x00A1CFFC File Offset: 0x00A1B1FC
		public global::AcpBusinessLayer.AcpField<bool> DataConfigDataProfIPHeaderCompressionEnable_A36190
		{
			get
			{
				short num = (short)1208884460;
				short num2 = num;
				num = (short)2087853292;
				switch (num2 == num)
				{
				}
				num = (short)2094268416;
				if (num != 0)
				{
				}
				num = (short)1101463552;
				short num3 = num;
				num = (short)973406209;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfIPHeaderCompressionEnable_A36190;
			}
		}

		// Token: 0x17005734 RID: 22324
		// (get) Token: 0x0600ADEB RID: 44523 RVA: 0x00A1D0AC File Offset: 0x00A1B2AC
		// (set) Token: 0x0600ADEC RID: 44524 RVA: 0x00A1D160 File Offset: 0x00A1B360
		public bool DataConfigDataProfIPHeaderCompressionEnable_A36190_UIValue
		{
			get
			{
				short num = (short)781385728;
				short num2 = num;
				num = (short)2087360621;
				short num3 = num;
				num = (short)886872173;
				switch (num3 == num)
				{
				}
				num = (short)998047745;
				if (num != 0)
				{
				}
				num = (short)21823488;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfIPHeaderCompressionEnable_A36190.Value;
			}
			set
			{
				short num = (short)1101004800;
				short num2 = num;
				num = (short)1824275772;
				short num3 = num;
				num = (short)668089660;
				switch (num3 == num)
				{
				}
				num = (short)1143013377;
				if (num != 0)
				{
				}
				num = (short)1319895040;
				if (num != 0)
				{
				}
				this.dataConfigDataProfIPHeaderCompressionEnable_A36190.Value = value;
			}
		}

		// Token: 0x17005735 RID: 22325
		// (get) Token: 0x0600ADED RID: 44525 RVA: 0x00A1D214 File Offset: 0x00A1B414
		// (set) Token: 0x0600ADEE RID: 44526 RVA: 0x00A1D2C8 File Offset: 0x00A1B4C8
		public bool DataConfigDataProfIPHeaderCompressionEnable_A36190_Applicable
		{
			get
			{
				short num = (short)910753792;
				short num2 = num;
				num = (short)410187336;
				short num3 = num;
				num = (short)646903368;
				switch (num3 == num)
				{
				}
				num = (short)2071199745;
				if (num != 0)
				{
				}
				num = (short)1904345088;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfIPHeaderCompressionEnable_A36190.Applicable;
			}
			set
			{
				short num = (short)782237696;
				short num2 = num;
				num = (short)57266143;
				short num3 = num;
				num = (short)334352351;
				switch (num3 == num)
				{
				}
				num = (short)1909325825;
				if (num != 0)
				{
				}
				num = (short)2062352384;
				if (num != 0)
				{
				}
				this.dataConfigDataProfIPHeaderCompressionEnable_A36190.Applicable = value;
			}
		}

		// Token: 0x17005736 RID: 22326
		// (get) Token: 0x0600ADEF RID: 44527 RVA: 0x00A1D380 File Offset: 0x00A1B580
		// (set) Token: 0x0600ADF0 RID: 44528 RVA: 0x00A1D434 File Offset: 0x00A1B634
		public bool DataConfigDataProfIPHeaderCompressionEnable_A36190_Valid
		{
			get
			{
				short num = (short)1220870144;
				short num2 = num;
				num = (short)290756851;
				short num3 = num;
				num = (short)129472755;
				switch (num3 == num)
				{
				}
				num = (short)1709703168;
				if (num != 0)
				{
				}
				num = (short)1611202561;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfIPHeaderCompressionEnable_A36190.Valid;
			}
			set
			{
				short num = (short)930152448;
				short num2 = num;
				num = (short)1146249119;
				short num3 = num;
				num = (short)183066527;
				switch (num3 == num)
				{
				}
				num = (short)878444544;
				if (num != 0)
				{
				}
				num = (short)1479278593;
				if (num != 0)
				{
				}
				this.dataConfigDataProfIPHeaderCompressionEnable_A36190.Valid = value;
			}
		}

		// Token: 0x17005737 RID: 22327
		// (get) Token: 0x0600ADF1 RID: 44529 RVA: 0x00A1D4EC File Offset: 0x00A1B6EC
		// (set) Token: 0x0600ADF2 RID: 44530 RVA: 0x00A1D5A0 File Offset: 0x00A1B7A0
		public bool DataConfigDataProfIPHeaderCompressionEnable_A36190_Visible
		{
			get
			{
				short num = (short)1050869760;
				short num2 = num;
				num = (short)626752858;
				short num3 = num;
				num = (short)684686682;
				switch (num3 == num)
				{
				}
				num = (short)2134507521;
				if (num != 0)
				{
				}
				num = (short)2043215872;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfIPHeaderCompressionEnable_A36190.Visible;
			}
			set
			{
				short num = (short)694550528;
				short num2 = num;
				num = (short)735969281;
				if (num != 0)
				{
				}
				num = (short)1722143981;
				short num3 = num;
				num = (short)1454626029;
				switch (num3 == num)
				{
				}
				num = (short)903610368;
				if (num != 0)
				{
				}
				this.dataConfigDataProfIPHeaderCompressionEnable_A36190.Visible = value;
			}
		}

		// Token: 0x17005738 RID: 22328
		// (get) Token: 0x0600ADF3 RID: 44531 RVA: 0x00A1D658 File Offset: 0x00A1B858
		// (set) Token: 0x0600ADF4 RID: 44532 RVA: 0x00A1D70C File Offset: 0x00A1B90C
		public bool DataConfigDataProfIPHeaderCompressionEnable_A36190_Editable
		{
			get
			{
				short num = (short)1513619456;
				short num2 = num;
				num = (short)696254465;
				if (num != 0)
				{
				}
				num = (short)1918136715;
				short num3 = num;
				num = (short)1934193035;
				switch (num3 == num)
				{
				}
				num = (short)1758920704;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfIPHeaderCompressionEnable_A36190.Editable;
			}
			set
			{
				short num = (short)1366884352;
				short num2 = num;
				num = (short)1577561696;
				short num3 = num;
				num = (short)1617342048;
				switch (num3 == num)
				{
				}
				num = (short)949157889;
				if (num != 0)
				{
				}
				num = (short)1115422720;
				if (num != 0)
				{
				}
				this.dataConfigDataProfIPHeaderCompressionEnable_A36190.Editable = value;
			}
		}

		// Token: 0x17005739 RID: 22329
		// (get) Token: 0x0600ADF5 RID: 44533 RVA: 0x00A1D7C4 File Offset: 0x00A1B9C4
		internal string DataConfigDataProfIPHeaderCompressionEnable_A36190_UILabel
		{
			get
			{
				short num = (short)1004863488;
				short num2 = num;
				num = (short)630390785;
				if (num != 0)
				{
				}
				num = (short)1432784431;
				short num3 = num;
				num = (short)1457557039;
				switch (num3 == num)
				{
				}
				num = (short)1248657408;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfIPHeaderCompressionEnable_A36190.UIName;
			}
		}

		// Token: 0x1700573A RID: 22330
		// (get) Token: 0x0600ADF6 RID: 44534 RVA: 0x00A1D878 File Offset: 0x00A1BA78
		// (set) Token: 0x0600ADF7 RID: 44535 RVA: 0x00A1D92C File Offset: 0x00A1BB2C
		internal bool DataConfigDataProfIPHeaderCompressionEnable_A36190_HiddenStatic
		{
			get
			{
				short num = (short)568131584;
				short num2 = num;
				num = (short)1472271319;
				short num3 = num;
				num = (short)1038357463;
				switch (num3 == num)
				{
				}
				num = (short)726401025;
				if (num != 0)
				{
				}
				num = (short)63242240;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfIPHeaderCompressionEnable_A36190.HiddenStatic;
			}
			set
			{
				short num = (short)1192361984;
				short num2 = num;
				num = (short)1011206287;
				short num3 = num;
				num = (short)24758415;
				switch (num3 == num)
				{
				}
				num = (short)1888485377;
				if (num != 0)
				{
				}
				num = (short)2085289984;
				if (num != 0)
				{
				}
				this.dataConfigDataProfIPHeaderCompressionEnable_A36190.HiddenStatic = value;
			}
		}

		// Token: 0x1700573B RID: 22331
		// (get) Token: 0x0600ADF8 RID: 44536 RVA: 0x00A1D9DC File Offset: 0x00A1BBDC
		// (set) Token: 0x0600ADF9 RID: 44537 RVA: 0x00A1DA90 File Offset: 0x00A1BC90
		internal bool DataConfigDataProfIPHeaderCompressionEnable_A36190_HiddenDynamic
		{
			get
			{
				short num = (short)2039152640;
				short num2 = num;
				num = (short)1126761011;
				short num3 = num;
				num = (short)2030436915;
				switch (num3 == num)
				{
				}
				num = (short)1010106369;
				if (num != 0)
				{
				}
				num = (short)1498415104;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfIPHeaderCompressionEnable_A36190.HiddenDynamic;
			}
			set
			{
				short num = (short)441188352;
				short num2 = num;
				num = (short)1780443586;
				short num3 = num;
				num = (short)1196059074;
				switch (num3 == num)
				{
				}
				num = (short)146931712;
				if (num != 0)
				{
				}
				num = (short)669712385;
				if (num != 0)
				{
				}
				this.dataConfigDataProfIPHeaderCompressionEnable_A36190.HiddenDynamic = value;
			}
		}

		// Token: 0x1700573C RID: 22332
		// (get) Token: 0x0600ADFA RID: 44538 RVA: 0x00A1DB48 File Offset: 0x00A1BD48
		public bool DataConfigDataProfIPHeaderCompressionEnable_A36190_HasDiffs
		{
			get
			{
				short num = (short)626065408;
				short num2 = num;
				num = (short)949969055;
				short num3 = num;
				num = (short)182149279;
				switch (num3 == num)
				{
				}
				num = (short)1651900417;
				if (num != 0)
				{
				}
				num = (short)954728448;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfIPHeaderCompressionEnable_A36190._HasDiffs;
			}
		}

		// Token: 0x1700573D RID: 22333
		// (get) Token: 0x0600ADFB RID: 44539 RVA: 0x00A1DBFC File Offset: 0x00A1BDFC
		// (set) Token: 0x0600ADFC RID: 44540 RVA: 0x00A1DCB4 File Offset: 0x00A1BEB4
		public int DataConigurationDataProfilePacketDataRegistrationVersion_A36210Value
		{
			get
			{
				short num = (short)1632763904;
				short num2 = num;
				num = (short)431921140;
				short num3 = num;
				num = (short)635475956;
				switch (num3 == num)
				{
				}
				num = (short)2042101760;
				if (num != 0)
				{
				}
				num = (short)621805569;
				if (num != 0)
				{
				}
				return this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210.Value;
			}
			set
			{
				short num = (short)1829830656;
				short num2 = num;
				num = (short)1773403260;
				short num3 = num;
				num = (short)156236924;
				switch (num3 == num)
				{
				}
				num = (short)1991049216;
				if (num != 0)
				{
				}
				num = (short)1134100481;
				if (num != 0)
				{
				}
				this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210.Value = value;
			}
		}

		// Token: 0x1700573E RID: 22334
		// (get) Token: 0x0600ADFD RID: 44541 RVA: 0x00A1DD6C File Offset: 0x00A1BF6C
		// (set) Token: 0x0600ADFE RID: 44542 RVA: 0x00A1DE20 File Offset: 0x00A1C020
		public string DataConigurationDataProfilePacketDataRegistrationVersion_A36210_UIValue
		{
			get
			{
				short num = (short)2014314496;
				short num2 = num;
				num = (short)758968155;
				short num3 = num;
				num = (short)1613098843;
				switch (num3 == num)
				{
				}
				num = (short)215220225;
				if (num != 0)
				{
				}
				num = (short)1340407808;
				if (num != 0)
				{
				}
				return this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210.UIValue;
			}
			set
			{
				short num = (short)576651264;
				short num2 = num;
				num = (short)490347966;
				short num3 = num;
				num = (short)1003560382;
				switch (num3 == num)
				{
				}
				num = (short)747569153;
				if (num != 0)
				{
				}
				num = (short)685375488;
				if (num != 0)
				{
				}
				this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210.UIValue = value;
			}
		}

		// Token: 0x1700573F RID: 22335
		// (get) Token: 0x0600ADFF RID: 44543 RVA: 0x00A1DED4 File Offset: 0x00A1C0D4
		public global::AcpBusinessLayer.AcpListField DataConigurationDataProfilePacketDataRegistrationVersion_A36210
		{
			get
			{
				short num = (short)1269563392;
				short num2 = num;
				num = (short)726675943;
				short num3 = num;
				num = (short)1585197543;
				switch (num3 == num)
				{
				}
				num = (short)1020198912;
				if (num != 0)
				{
				}
				num = (short)1079836673;
				if (num != 0)
				{
				}
				return this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210;
			}
		}

		// Token: 0x17005740 RID: 22336
		// (get) Token: 0x0600AE00 RID: 44544 RVA: 0x00A1DF84 File Offset: 0x00A1C184
		// (set) Token: 0x0600AE01 RID: 44545 RVA: 0x00A1E038 File Offset: 0x00A1C238
		public bool DataConigurationDataProfilePacketDataRegistrationVersion_A36210_Applicable
		{
			get
			{
				short num = (short)116195328;
				short num2 = num;
				num = (short)924712961;
				if (num != 0)
				{
				}
				num = (short)1253045840;
				short num3 = num;
				num = (short)342292048;
				switch (num3 == num)
				{
				}
				num = (short)1874788352;
				if (num != 0)
				{
				}
				return this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210.Applicable;
			}
			set
			{
				short num = (short)283967488;
				short num2 = num;
				num = (short)907280385;
				if (num != 0)
				{
				}
				num = (short)1920343954;
				short num3 = num;
				num = (short)203104146;
				switch (num3 == num)
				{
				}
				num = (short)63832064;
				if (num != 0)
				{
				}
				this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210.Applicable = value;
			}
		}

		// Token: 0x17005741 RID: 22337
		// (get) Token: 0x0600AE02 RID: 44546 RVA: 0x00A1E0F0 File Offset: 0x00A1C2F0
		// (set) Token: 0x0600AE03 RID: 44547 RVA: 0x00A1E1A4 File Offset: 0x00A1C3A4
		public bool DataConigurationDataProfilePacketDataRegistrationVersion_A36210_Valid
		{
			get
			{
				short num = (short)857866240;
				short num2 = num;
				num = (short)1554251659;
				short num3 = num;
				num = (short)141098891;
				switch (num3 == num)
				{
				}
				num = (short)87490561;
				if (num != 0)
				{
				}
				num = (short)1818099712;
				if (num != 0)
				{
				}
				return this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210.Valid;
			}
			set
			{
				short num = (short)1758527488;
				short num2 = num;
				num = (short)118764229;
				short num3 = num;
				num = (short)2089038533;
				switch (num3 == num)
				{
				}
				num = (short)387121152;
				if (num != 0)
				{
				}
				num = (short)721879041;
				if (num != 0)
				{
				}
				this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210.Valid = value;
			}
		}

		// Token: 0x17005742 RID: 22338
		// (get) Token: 0x0600AE04 RID: 44548 RVA: 0x00A1E25C File Offset: 0x00A1C45C
		// (set) Token: 0x0600AE05 RID: 44549 RVA: 0x00A1E310 File Offset: 0x00A1C510
		public bool DataConigurationDataProfilePacketDataRegistrationVersion_A36210_Visible
		{
			get
			{
				short num = (short)1144848384;
				short num2 = num;
				num = (short)891483403;
				short num3 = num;
				num = (short)1656812811;
				switch (num3 == num)
				{
				}
				num = (short)568262657;
				if (num != 0)
				{
				}
				num = (short)723517440;
				if (num != 0)
				{
				}
				return this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210.Visible;
			}
			set
			{
				short num = (short)1068171264;
				short num2 = num;
				num = (short)1743012726;
				short num3 = num;
				num = (short)462504822;
				switch (num3 == num)
				{
				}
				num = (short)1784348672;
				if (num != 0)
				{
				}
				num = (short)1458176001;
				if (num != 0)
				{
				}
				this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210.Visible = value;
			}
		}

		// Token: 0x17005743 RID: 22339
		// (get) Token: 0x0600AE06 RID: 44550 RVA: 0x00A1E3C4 File Offset: 0x00A1C5C4
		// (set) Token: 0x0600AE07 RID: 44551 RVA: 0x00A1E47C File Offset: 0x00A1C67C
		public bool DataConigurationDataProfilePacketDataRegistrationVersion_A36210_Editable
		{
			get
			{
				short num = (short)1713242112;
				short num2 = num;
				num = (short)677341555;
				short num3 = num;
				num = (short)19556723;
				switch (num3 == num)
				{
				}
				num = (short)1846214657;
				if (num != 0)
				{
				}
				num = (short)397475840;
				if (num != 0)
				{
				}
				return this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210.Editable;
			}
			set
			{
				short num = (short)621936640;
				short num2 = num;
				num = (short)1514993034;
				short num3 = num;
				num = (short)959444362;
				switch (num3 == num)
				{
				}
				num = (short)570097664;
				if (num != 0)
				{
				}
				num = (short)1811808257;
				if (num != 0)
				{
				}
				this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210.Editable = value;
			}
		}

		// Token: 0x17005744 RID: 22340
		// (get) Token: 0x0600AE08 RID: 44552 RVA: 0x00A1E534 File Offset: 0x00A1C734
		internal string DataConigurationDataProfilePacketDataRegistrationVersion_A36210_UILabel
		{
			get
			{
				short num = (short)1299447808;
				short num2 = num;
				num = (short)686096385;
				if (num != 0)
				{
				}
				num = (short)2142050151;
				short num3 = num;
				num = (short)96802663;
				switch (num3 == num)
				{
				}
				num = (short)425263104;
				if (num != 0)
				{
				}
				return this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210.UIName;
			}
		}

		// Token: 0x17005745 RID: 22341
		// (get) Token: 0x0600AE09 RID: 44553 RVA: 0x00A1E5E8 File Offset: 0x00A1C7E8
		// (set) Token: 0x0600AE0A RID: 44554 RVA: 0x00A1E69C File Offset: 0x00A1C89C
		internal bool DataConigurationDataProfilePacketDataRegistrationVersion_A36210_HiddenStatic
		{
			get
			{
				short num = (short)370081792;
				short num2 = num;
				num = (short)724061997;
				short num3 = num;
				num = (short)72175405;
				switch (num3 == num)
				{
				}
				num = (short)1845886977;
				if (num != 0)
				{
				}
				num = (short)1432944640;
				if (num != 0)
				{
				}
				return this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210.HiddenStatic;
			}
			set
			{
				short num = (short)497614848;
				short num2 = num;
				num = (short)244945547;
				short num3 = num;
				num = (short)293704331;
				switch (num3 == num)
				{
				}
				num = (short)1630208001;
				if (num != 0)
				{
				}
				num = (short)170590208;
				if (num != 0)
				{
				}
				this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210.HiddenStatic = value;
			}
		}

		// Token: 0x17005746 RID: 22342
		// (get) Token: 0x0600AE0B RID: 44555 RVA: 0x00A1E754 File Offset: 0x00A1C954
		// (set) Token: 0x0600AE0C RID: 44556 RVA: 0x00A1E808 File Offset: 0x00A1CA08
		internal bool DataConigurationDataProfilePacketDataRegistrationVersion_A36210_HiddenDynamic
		{
			get
			{
				short num = (short)914620416;
				short num2 = num;
				num = (short)598707147;
				short num3 = num;
				num = (short)661097419;
				switch (num3 == num)
				{
				}
				num = (short)1865285633;
				if (num != 0)
				{
				}
				num = (short)1396310016;
				if (num != 0)
				{
				}
				return this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210.HiddenDynamic;
			}
			set
			{
				short num = (short)1281294336;
				short num2 = num;
				num = (short)1638314910;
				short num3 = num;
				num = (short)561492894;
				switch (num3 == num)
				{
				}
				num = (short)2100953088;
				if (num != 0)
				{
				}
				num = (short)534904833;
				if (num != 0)
				{
				}
				this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210.HiddenDynamic = value;
			}
		}

		// Token: 0x17005747 RID: 22343
		// (get) Token: 0x0600AE0D RID: 44557 RVA: 0x00A1E8C0 File Offset: 0x00A1CAC0
		public bool DataConigurationDataProfilePacketDataRegistrationVersion_A36210_HasDiffs
		{
			get
			{
				short num = (short)1217265664;
				short num2 = num;
				num = (short)2113825320;
				short num3 = num;
				num = (short)1295280680;
				switch (num3 == num)
				{
				}
				num = (short)1755512833;
				if (num != 0)
				{
				}
				num = (short)1380253696;
				if (num != 0)
				{
				}
				return this.dataConigurationDataProfilePacketDataRegistrationVersion_A36210._HasDiffs;
			}
		}

		// Token: 0x17005748 RID: 22344
		// (get) Token: 0x0600AE0E RID: 44558 RVA: 0x00A1E974 File Offset: 0x00A1CB74
		// (set) Token: 0x0600AE0F RID: 44559 RVA: 0x00A1EA28 File Offset: 0x00A1CC28
		public int DataConfigDataProfContextActivationHoldoffTime_A36551Value
		{
			get
			{
				short num = (short)140509184;
				short num2 = num;
				num = (short)229224573;
				short num3 = num;
				num = (short)1549185149;
				switch (num3 == num)
				{
				}
				num = (short)401145857;
				if (num != 0)
				{
				}
				num = (short)1540882432;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfContextActivationHoldoffTime_A36551.Value;
			}
			set
			{
				short num = (short)929759232;
				short num2 = num;
				num = (short)1640008422;
				short num3 = num;
				num = (short)2038663910;
				switch (num3 == num)
				{
				}
				num = (short)1569062912;
				if (num != 0)
				{
				}
				num = (short)1852506113;
				if (num != 0)
				{
				}
				this.dataConfigDataProfContextActivationHoldoffTime_A36551.Value = value;
			}
		}

		// Token: 0x17005749 RID: 22345
		// (get) Token: 0x0600AE10 RID: 44560 RVA: 0x00A1EADC File Offset: 0x00A1CCDC
		public global::AcpBusinessLayer.AcpSimpleRangeField DataConfigDataProfContextActivationHoldoffTime_A36551
		{
			get
			{
				short num = (short)1050345473;
				if (num != 0)
				{
				}
				num = (short)1041295928;
				short num2 = num;
				num = (short)1285286456;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1810694144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)758185984;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfContextActivationHoldoffTime_A36551;
			}
		}

		// Token: 0x1700574A RID: 22346
		// (get) Token: 0x0600AE11 RID: 44561 RVA: 0x00A1EB8C File Offset: 0x00A1CD8C
		// (set) Token: 0x0600AE12 RID: 44562 RVA: 0x00A1EC40 File Offset: 0x00A1CE40
		public string DataConfigDataProfContextActivationHoldoffTime_A36551_UIValue
		{
			get
			{
				short num = (short)766771201;
				if (num != 0)
				{
				}
				num = (short)487201037;
				short num2 = num;
				num = (short)609229069;
				switch (num2 == num)
				{
				default:
				{
					num = (short)892534784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1493237760;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfContextActivationHoldoffTime_A36551.UIValue;
			}
			set
			{
				short num = (short)102498305;
				if (num != 0)
				{
				}
				num = (short)1919324527;
				short num2 = num;
				num = (short)635015535;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1757151232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)847970304;
				if (num != 0)
				{
				}
				this.dataConfigDataProfContextActivationHoldoffTime_A36551.UIValue = value;
			}
		}

		// Token: 0x1700574B RID: 22347
		// (get) Token: 0x0600AE13 RID: 44563 RVA: 0x00A1ECF8 File Offset: 0x00A1CEF8
		// (set) Token: 0x0600AE14 RID: 44564 RVA: 0x00A1EDAC File Offset: 0x00A1CFAC
		internal int DataConfigDataProfContextActivationHoldoffTime_A36551Min
		{
			get
			{
				short num = (short)596256511;
				short num2 = num;
				num = (short)1131620095;
				switch (num2 == num)
				{
				}
				num = (short)902299648;
				short num3 = num;
				num = (short)1036058624;
				if (num != 0)
				{
				}
				num = (short)1675362305;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfContextActivationHoldoffTime_A36551.Min;
			}
			set
			{
				short num = (short)1390029856;
				short num2 = num;
				num = (short)1490627616;
				switch (num2 == num)
				{
				}
				num = (short)4259840;
				short num3 = num;
				num = (short)902365184;
				if (num != 0)
				{
				}
				num = (short)135004161;
				if (num != 0)
				{
				}
				this.dataConfigDataProfContextActivationHoldoffTime_A36551.Min = value;
			}
		}

		// Token: 0x1700574C RID: 22348
		// (get) Token: 0x0600AE15 RID: 44565 RVA: 0x00A1EE64 File Offset: 0x00A1D064
		// (set) Token: 0x0600AE16 RID: 44566 RVA: 0x00A1EF18 File Offset: 0x00A1D118
		internal int DataConfigDataProfContextActivationHoldoffTime_A36551Max
		{
			get
			{
				short num = (short)2162689;
				if (num != 0)
				{
				}
				num = (short)1978084038;
				short num2 = num;
				num = (short)844049094;
				switch (num2 == num)
				{
				default:
				{
					num = (short)853671936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1225719808;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfContextActivationHoldoffTime_A36551.Max;
			}
			set
			{
				short num = (short)1311587511;
				short num2 = num;
				num = (short)2110930103;
				switch (num2 == num)
				{
				}
				num = (short)2131951616;
				short num3 = num;
				num = (short)1149370368;
				if (num != 0)
				{
				}
				num = (short)1704787969;
				if (num != 0)
				{
				}
				this.dataConfigDataProfContextActivationHoldoffTime_A36551.Max = value;
			}
		}

		// Token: 0x1700574D RID: 22349
		// (get) Token: 0x0600AE17 RID: 44567 RVA: 0x00A1EFCC File Offset: 0x00A1D1CC
		// (set) Token: 0x0600AE18 RID: 44568 RVA: 0x00A1F080 File Offset: 0x00A1D280
		internal int DataConfigDataProfContextActivationHoldoffTime_A36551Step
		{
			get
			{
				short num = (short)1494219987;
				short num2 = num;
				num = (short)1459682515;
				switch (num2 == num)
				{
				}
				num = (short)264241152;
				short num3 = num;
				num = (short)1743781889;
				if (num != 0)
				{
				}
				num = (short)1365573632;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfContextActivationHoldoffTime_A36551.StepSize;
			}
			set
			{
				short num = (short)296061864;
				short num2 = num;
				num = (short)649366440;
				switch (num2 == num)
				{
				}
				num = (short)924778496;
				short num3 = num;
				num = (short)1069350913;
				if (num != 0)
				{
				}
				num = (short)850722816;
				if (num != 0)
				{
				}
				this.dataConfigDataProfContextActivationHoldoffTime_A36551.StepSize = value;
			}
		}

		// Token: 0x1700574E RID: 22350
		// (get) Token: 0x0600AE19 RID: 44569 RVA: 0x00A1F138 File Offset: 0x00A1D338
		// (set) Token: 0x0600AE1A RID: 44570 RVA: 0x00A1F1F0 File Offset: 0x00A1D3F0
		public bool DataConfigDataProfContextActivationHoldoffTime_A36551_Applicable
		{
			get
			{
				short num = (short)2091442653;
				short num2 = num;
				num = (short)597811677;
				switch (num2 == num)
				{
				}
				num = (short)1628569600;
				short num3 = num;
				num = (short)1410531329;
				if (num != 0)
				{
				}
				num = (short)1080426496;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfContextActivationHoldoffTime_A36551.Applicable;
			}
			set
			{
				short num = (short)1800321997;
				short num2 = num;
				num = (short)124894157;
				switch (num2 == num)
				{
				}
				num = (short)1240924160;
				short num3 = num;
				num = (short)1389625345;
				if (num != 0)
				{
				}
				num = (short)1547370496;
				if (num != 0)
				{
				}
				this.dataConfigDataProfContextActivationHoldoffTime_A36551.Applicable = value;
			}
		}

		// Token: 0x1700574F RID: 22351
		// (get) Token: 0x0600AE1B RID: 44571 RVA: 0x00A1F2A4 File Offset: 0x00A1D4A4
		// (set) Token: 0x0600AE1C RID: 44572 RVA: 0x00A1F358 File Offset: 0x00A1D558
		public bool DataConfigDataProfContextActivationHoldoffTime_A36551_Valid
		{
			get
			{
				short num = (short)1712183864;
				short num2 = num;
				num = (short)659806776;
				switch (num2 == num)
				{
				}
				num = (short)172228608;
				short num3 = num;
				num = (short)1966211072;
				if (num != 0)
				{
				}
				num = (short)1175388161;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfContextActivationHoldoffTime_A36551.Valid;
			}
			set
			{
				short num = (short)1806543407;
				short num2 = num;
				num = (short)1186900527;
				switch (num2 == num)
				{
				}
				num = (short)515375104;
				short num3 = num;
				num = (short)1102839809;
				if (num != 0)
				{
				}
				num = (short)104398848;
				if (num != 0)
				{
				}
				this.dataConfigDataProfContextActivationHoldoffTime_A36551.Valid = value;
			}
		}

		// Token: 0x17005750 RID: 22352
		// (get) Token: 0x0600AE1D RID: 44573 RVA: 0x00A1F40C File Offset: 0x00A1D60C
		// (set) Token: 0x0600AE1E RID: 44574 RVA: 0x00A1F4C0 File Offset: 0x00A1D6C0
		public bool DataConfigDataProfContextActivationHoldoffTime_A36551_Visible
		{
			get
			{
				short num = (short)553844737;
				if (num != 0)
				{
				}
				num = (short)645423764;
				short num2 = num;
				num = (short)1484284564;
				switch (num2 == num)
				{
				default:
				{
					num = (short)268828672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)964427776;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfContextActivationHoldoffTime_A36551.Visible;
			}
			set
			{
				short num = (short)43297955;
				short num2 = num;
				num = (short)1595649187;
				switch (num2 == num)
				{
				}
				num = (short)1677262848;
				short num3 = num;
				num = (short)1725300737;
				if (num != 0)
				{
				}
				num = (short)394854400;
				if (num != 0)
				{
				}
				this.dataConfigDataProfContextActivationHoldoffTime_A36551.Visible = value;
			}
		}

		// Token: 0x17005751 RID: 22353
		// (get) Token: 0x0600AE1F RID: 44575 RVA: 0x00A1F574 File Offset: 0x00A1D774
		// (set) Token: 0x0600AE20 RID: 44576 RVA: 0x00A1F628 File Offset: 0x00A1D828
		public bool DataConfigDataProfContextActivationHoldoffTime_A36551_Editable
		{
			get
			{
				short num = (short)697355184;
				short num2 = num;
				num = (short)917425072;
				switch (num2 == num)
				{
				}
				num = (short)1545928704;
				short num3 = num;
				num = (short)1802764289;
				if (num != 0)
				{
				}
				num = (short)885129216;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfContextActivationHoldoffTime_A36551.Editable;
			}
			set
			{
				short num = (short)1434862928;
				short num2 = num;
				num = (short)1101743440;
				switch (num2 == num)
				{
				}
				num = (short)1129316352;
				short num3 = num;
				num = (short)1676214273;
				if (num != 0)
				{
				}
				num = (short)2087059456;
				if (num != 0)
				{
				}
				this.dataConfigDataProfContextActivationHoldoffTime_A36551.Editable = value;
			}
		}

		// Token: 0x17005752 RID: 22354
		// (get) Token: 0x0600AE21 RID: 44577 RVA: 0x00A1F6DC File Offset: 0x00A1D8DC
		internal string DataConfigDataProfContextActivationHoldoffTime_A36551_UILabel
		{
			get
			{
				short num = (short)2116550657;
				if (num != 0)
				{
				}
				num = (short)862120708;
				short num2 = num;
				num = (short)1203104516;
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
				num = (short)1061748736;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfContextActivationHoldoffTime_A36551.UIName;
			}
		}

		// Token: 0x17005753 RID: 22355
		// (get) Token: 0x0600AE22 RID: 44578 RVA: 0x00A1F790 File Offset: 0x00A1D990
		// (set) Token: 0x0600AE23 RID: 44579 RVA: 0x00A1F844 File Offset: 0x00A1DA44
		internal bool DataConfigDataProfContextActivationHoldoffTime_A36551_HiddenStatic
		{
			get
			{
				short num = (short)1814929948;
				short num2 = num;
				num = (short)316449308;
				switch (num2 == num)
				{
				}
				num = (short)1920925696;
				short num3 = num;
				num = (short)856162305;
				if (num != 0)
				{
				}
				num = (short)137953280;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfContextActivationHoldoffTime_A36551.HiddenStatic;
			}
			set
			{
				short num = (short)1832066473;
				short num2 = num;
				num = (short)2006064553;
				switch (num2 == num)
				{
				}
				num = (short)1172570112;
				short num3 = num;
				num = (short)189399041;
				if (num != 0)
				{
				}
				num = (short)1768095744;
				if (num != 0)
				{
				}
				this.dataConfigDataProfContextActivationHoldoffTime_A36551.HiddenStatic = value;
			}
		}

		// Token: 0x17005754 RID: 22356
		// (get) Token: 0x0600AE24 RID: 44580 RVA: 0x00A1F8F8 File Offset: 0x00A1DAF8
		// (set) Token: 0x0600AE25 RID: 44581 RVA: 0x00A1F9AC File Offset: 0x00A1DBAC
		internal bool DataConfigDataProfContextActivationHoldoffTime_A36551_HiddenDynamic
		{
			get
			{
				short num = (short)409927681;
				if (num != 0)
				{
				}
				num = (short)617805501;
				short num2 = num;
				num = (short)162461373;
				switch (num2 == num)
				{
				default:
				{
					num = (short)586940416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2011824128;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfContextActivationHoldoffTime_A36551.HiddenDynamic;
			}
			set
			{
				short num = (short)286891289;
				short num2 = num;
				num = (short)1415486745;
				switch (num2 == num)
				{
				}
				num = (short)490995712;
				short num3 = num;
				num = (short)893517825;
				if (num != 0)
				{
				}
				num = (short)459931648;
				if (num != 0)
				{
				}
				this.dataConfigDataProfContextActivationHoldoffTime_A36551.HiddenDynamic = value;
			}
		}

		// Token: 0x17005755 RID: 22357
		// (get) Token: 0x0600AE26 RID: 44582 RVA: 0x00A1FA64 File Offset: 0x00A1DC64
		public bool DataConfigDataProfContextActivationHoldoffTime_A36551_HasDiffs
		{
			get
			{
				short num = (short)61580263;
				short num2 = num;
				num = (short)1444520935;
				switch (num2 == num)
				{
				}
				num = (short)826343424;
				short num3 = num;
				num = (short)972292097;
				if (num != 0)
				{
				}
				num = (short)1436221440;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfContextActivationHoldoffTime_A36551._HasDiffs;
			}
		}

		// Token: 0x17005756 RID: 22358
		// (get) Token: 0x0600AE27 RID: 44583 RVA: 0x00A1FB18 File Offset: 0x00A1DD18
		// (set) Token: 0x0600AE28 RID: 44584 RVA: 0x00A1FBCC File Offset: 0x00A1DDCC
		public bool DataConfigDataProfRandomHoldOffTime_A36552Value
		{
			get
			{
				short num = (short)2140544041;
				short num2 = num;
				num = (short)1098128425;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2013724672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)854589440;
				if (num != 0)
				{
				}
				num = (short)669450241;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfRandomHoldOffTime_A36552.Value;
			}
			set
			{
				short num = (short)926684134;
				short num2 = num;
				num = (short)147723238;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1805975552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1468923905;
				if (num != 0)
				{
				}
				num = (short)886636544;
				if (num != 0)
				{
				}
				this.dataConfigDataProfRandomHoldOffTime_A36552.Value = value;
			}
		}

		// Token: 0x17005757 RID: 22359
		// (get) Token: 0x0600AE29 RID: 44585 RVA: 0x00A1FC80 File Offset: 0x00A1DE80
		public global::AcpBusinessLayer.AcpField<bool> DataConfigDataProfRandomHoldOffTime_A36552
		{
			get
			{
				short num = (short)967565155;
				short num2 = num;
				num = (short)1285087075;
				switch (num2 == num)
				{
				default:
				{
					num = (short)529727488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1200553985;
				if (num != 0)
				{
				}
				num = (short)561840128;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfRandomHoldOffTime_A36552;
			}
		}

		// Token: 0x17005758 RID: 22360
		// (get) Token: 0x0600AE2A RID: 44586 RVA: 0x00A1FD2C File Offset: 0x00A1DF2C
		// (set) Token: 0x0600AE2B RID: 44587 RVA: 0x00A1FDDC File Offset: 0x00A1DFDC
		public bool DataConfigDataProfRandomHoldOffTime_A36552_UIValue
		{
			get
			{
				short num = (short)447610881;
				if (num != 0)
				{
				}
				num = (short)1130823680;
				short num2 = num;
				num = (short)140466723;
				short num3 = num;
				num = (short)1035754019;
				switch (num3 == num)
				{
				}
				num = (short)475201536;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfRandomHoldOffTime_A36552.Value;
			}
			set
			{
				short num = (short)1343160321;
				if (num != 0)
				{
				}
				num = (short)54657024;
				short num2 = num;
				num = (short)55992114;
				short num3 = num;
				num = (short)1883004722;
				switch (num3 == num)
				{
				}
				num = (short)1345650688;
				if (num != 0)
				{
				}
				this.dataConfigDataProfRandomHoldOffTime_A36552.Value = value;
			}
		}

		// Token: 0x17005759 RID: 22361
		// (get) Token: 0x0600AE2C RID: 44588 RVA: 0x00A1FE90 File Offset: 0x00A1E090
		// (set) Token: 0x0600AE2D RID: 44589 RVA: 0x00A1FF48 File Offset: 0x00A1E148
		public bool DataConfigDataProfRandomHoldOffTime_A36552_Applicable
		{
			get
			{
				short num = (short)1583217571;
				short num2 = num;
				num = (short)1989409699;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1686700032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1146486785;
				if (num != 0)
				{
				}
				num = (short)702283776;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfRandomHoldOffTime_A36552.Applicable;
			}
			set
			{
				short num = (short)593559553;
				if (num != 0)
				{
				}
				num = (short)332398592;
				short num2 = num;
				num = (short)660178956;
				short num3 = num;
				num = (short)719816716;
				switch (num3 == num)
				{
				}
				num = (short)1095368704;
				if (num != 0)
				{
				}
				this.dataConfigDataProfRandomHoldOffTime_A36552.Applicable = value;
			}
		}

		// Token: 0x1700575A RID: 22362
		// (get) Token: 0x0600AE2E RID: 44590 RVA: 0x00A1FFFC File Offset: 0x00A1E1FC
		// (set) Token: 0x0600AE2F RID: 44591 RVA: 0x00A200B0 File Offset: 0x00A1E2B0
		public bool DataConfigDataProfRandomHoldOffTime_A36552_Valid
		{
			get
			{
				short num = (short)1887573233;
				short num2 = num;
				num = (short)801248497;
				switch (num2 == num)
				{
				default:
				{
					num = (short)536215552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1182793728;
				if (num != 0)
				{
				}
				num = (short)315490305;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfRandomHoldOffTime_A36552.Valid;
			}
			set
			{
				short num = (short)1835898891;
				short num2 = num;
				num = (short)1694210059;
				switch (num2 == num)
				{
				default:
				{
					num = (short)941031424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1784479745;
				if (num != 0)
				{
				}
				num = (short)1599602688;
				if (num != 0)
				{
				}
				this.dataConfigDataProfRandomHoldOffTime_A36552.Valid = value;
			}
		}

		// Token: 0x1700575B RID: 22363
		// (get) Token: 0x0600AE30 RID: 44592 RVA: 0x00A20164 File Offset: 0x00A1E364
		// (set) Token: 0x0600AE31 RID: 44593 RVA: 0x00A20218 File Offset: 0x00A1E418
		public bool DataConfigDataProfRandomHoldOffTime_A36552_Visible
		{
			get
			{
				short num = (short)1323481413;
				short num2 = num;
				num = (short)530561349;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1010302976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1087700993;
				if (num != 0)
				{
				}
				num = (short)1848180736;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfRandomHoldOffTime_A36552.Visible;
			}
			set
			{
				short num = (short)1332204985;
				short num2 = num;
				num = (short)1548342713;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1443102720;
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
				num = (short)1828585473;
				if (num != 0)
				{
				}
				this.dataConfigDataProfRandomHoldOffTime_A36552.Visible = value;
			}
		}

		// Token: 0x1700575C RID: 22364
		// (get) Token: 0x0600AE32 RID: 44594 RVA: 0x00A202D0 File Offset: 0x00A1E4D0
		// (set) Token: 0x0600AE33 RID: 44595 RVA: 0x00A20384 File Offset: 0x00A1E584
		public bool DataConfigDataProfRandomHoldOffTime_A36552_Editable
		{
			get
			{
				short num = (short)1256435131;
				short num2 = num;
				num = (short)1012968891;
				switch (num2 == num)
				{
				default:
				{
					num = (short)63832064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1004011520;
				if (num != 0)
				{
				}
				num = (short)345374721;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfRandomHoldOffTime_A36552.Editable;
			}
			set
			{
				short num = (short)948757359;
				short num2 = num;
				num = (short)1543824239;
				switch (num2 == num)
				{
				default:
				{
					num = (short)245366784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1281490945;
				if (num != 0)
				{
				}
				num = (short)1990524928;
				if (num != 0)
				{
				}
				this.dataConfigDataProfRandomHoldOffTime_A36552.Editable = value;
			}
		}

		// Token: 0x1700575D RID: 22365
		// (get) Token: 0x0600AE34 RID: 44596 RVA: 0x00A20438 File Offset: 0x00A1E638
		internal string DataConfigDataProfRandomHoldOffTime_A36552_UILabel
		{
			get
			{
				short num = (short)1125277164;
				short num2 = num;
				num = (short)1747344876;
				switch (num2 == num)
				{
				default:
				{
					num = (short)68616192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)659292161;
				if (num != 0)
				{
				}
				num = (short)1913454592;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfRandomHoldOffTime_A36552.UIName;
			}
		}

		// Token: 0x1700575E RID: 22366
		// (get) Token: 0x0600AE35 RID: 44597 RVA: 0x00A204F0 File Offset: 0x00A1E6F0
		// (set) Token: 0x0600AE36 RID: 44598 RVA: 0x00A205A4 File Offset: 0x00A1E7A4
		internal bool DataConfigDataProfRandomHoldOffTime_A36552_HiddenStatic
		{
			get
			{
				short num = (short)1733031615;
				short num2 = num;
				num = (short)530249407;
				switch (num2 == num)
				{
				default:
				{
					num = (short)287506432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)918487041;
				if (num != 0)
				{
				}
				num = (short)1805910016;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfRandomHoldOffTime_A36552.HiddenStatic;
			}
			set
			{
				short num = (short)1098843591;
				short num2 = num;
				num = (short)1882588615;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1247936512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1373765632;
				if (num != 0)
				{
				}
				num = (short)1298989057;
				if (num != 0)
				{
				}
				this.dataConfigDataProfRandomHoldOffTime_A36552.HiddenStatic = value;
			}
		}

		// Token: 0x1700575F RID: 22367
		// (get) Token: 0x0600AE37 RID: 44599 RVA: 0x00A20658 File Offset: 0x00A1E858
		// (set) Token: 0x0600AE38 RID: 44600 RVA: 0x00A2070C File Offset: 0x00A1E90C
		internal bool DataConfigDataProfRandomHoldOffTime_A36552_HiddenDynamic
		{
			get
			{
				short num = (short)1613876105;
				short num2 = num;
				num = (short)390777737;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1941897216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1819017216;
				if (num != 0)
				{
				}
				num = (short)1713307649;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfRandomHoldOffTime_A36552.HiddenDynamic;
			}
			set
			{
				short num = (short)1371529947;
				short num2 = num;
				num = (short)29156059;
				switch (num2 == num)
				{
				default:
				{
					num = (short)115212288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1553596417;
				if (num != 0)
				{
				}
				num = (short)648085504;
				if (num != 0)
				{
				}
				this.dataConfigDataProfRandomHoldOffTime_A36552.HiddenDynamic = value;
			}
		}

		// Token: 0x17005760 RID: 22368
		// (get) Token: 0x0600AE39 RID: 44601 RVA: 0x00A207C4 File Offset: 0x00A1E9C4
		public bool DataConfigDataProfRandomHoldOffTime_A36552_HasDiffs
		{
			get
			{
				short num = (short)2097808056;
				short num2 = num;
				num = (short)21037752;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1897136128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)970588160;
				if (num != 0)
				{
				}
				num = (short)150994945;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfRandomHoldOffTime_A36552._HasDiffs;
			}
		}

		// Token: 0x17005761 RID: 22369
		// (get) Token: 0x0600AE3A RID: 44602 RVA: 0x00A2087C File Offset: 0x00A1EA7C
		// (set) Token: 0x0600AE3B RID: 44603 RVA: 0x00A20934 File Offset: 0x00A1EB34
		public int DataProfGeneralQueueDwellTimersec_A8806Value
		{
			get
			{
				short num = (short)1557964572;
				short num2 = num;
				num = (short)1485874972;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1466040320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1147863041;
				if (num != 0)
				{
				}
				num = (short)1189675008;
				if (num != 0)
				{
				}
				return this.dataProfGeneralQueueDwellTimersec_A8806.Value;
			}
			set
			{
				short num = (short)4980737;
				if (num != 0)
				{
				}
				num = (short)1196228608;
				short num2 = num;
				num = (short)1228346158;
				short num3 = num;
				num = (short)1171133230;
				switch (num3 == num)
				{
				}
				num = (short)1272119296;
				if (num != 0)
				{
				}
				this.dataProfGeneralQueueDwellTimersec_A8806.Value = value;
			}
		}

		// Token: 0x17005762 RID: 22370
		// (get) Token: 0x0600AE3C RID: 44604 RVA: 0x00A209EC File Offset: 0x00A1EBEC
		public global::AcpBusinessLayer.AcpSimpleRangeField DataProfGeneralQueueDwellTimersec_A8806
		{
			get
			{
				short num = (short)2115209128;
				short num2 = num;
				num = (short)464750504;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1396310016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)664993793;
				if (num != 0)
				{
				}
				num = (short)1176895488;
				if (num != 0)
				{
				}
				return this.dataProfGeneralQueueDwellTimersec_A8806;
			}
		}

		// Token: 0x17005763 RID: 22371
		// (get) Token: 0x0600AE3D RID: 44605 RVA: 0x00A20A9C File Offset: 0x00A1EC9C
		// (set) Token: 0x0600AE3E RID: 44606 RVA: 0x00A20B54 File Offset: 0x00A1ED54
		public string DataProfGeneralQueueDwellTimersec_A8806_UIValue
		{
			get
			{
				short num = (short)996708154;
				short num2 = num;
				num = (short)139759418;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1995636736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)32833536;
				if (num != 0)
				{
				}
				num = (short)899612673;
				if (num != 0)
				{
				}
				return this.dataProfGeneralQueueDwellTimersec_A8806.UIValue;
			}
			set
			{
				short num = (short)645090138;
				short num2 = num;
				num = (short)102517594;
				switch (num2 == num)
				{
				default:
				{
					num = (short)618528768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)185597953;
				if (num != 0)
				{
				}
				num = (short)1308819456;
				if (num != 0)
				{
				}
				this.dataProfGeneralQueueDwellTimersec_A8806.UIValue = value;
			}
		}

		// Token: 0x17005764 RID: 22372
		// (get) Token: 0x0600AE3F RID: 44607 RVA: 0x00A20C08 File Offset: 0x00A1EE08
		// (set) Token: 0x0600AE40 RID: 44608 RVA: 0x00A20CBC File Offset: 0x00A1EEBC
		internal int DataProfGeneralQueueDwellTimersec_A8806Min
		{
			get
			{
				short num = (short)220200961;
				if (num != 0)
				{
				}
				num = (short)1595801600;
				short num2 = num;
				num = (short)628405459;
				short num3 = num;
				num = (short)747353299;
				switch (num3 == num)
				{
				}
				num = (short)1709113344;
				if (num != 0)
				{
				}
				return this.dataProfGeneralQueueDwellTimersec_A8806.Min;
			}
			set
			{
				short num = (short)1445372554;
				short num2 = num;
				num = (short)1910743690;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1351745536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1159004161;
				if (num != 0)
				{
				}
				num = (short)855310336;
				if (num != 0)
				{
				}
				this.dataProfGeneralQueueDwellTimersec_A8806.Min = value;
			}
		}

		// Token: 0x17005765 RID: 22373
		// (get) Token: 0x0600AE41 RID: 44609 RVA: 0x00A20D70 File Offset: 0x00A1EF70
		// (set) Token: 0x0600AE42 RID: 44610 RVA: 0x00A20E28 File Offset: 0x00A1F028
		internal int DataProfGeneralQueueDwellTimersec_A8806Max
		{
			get
			{
				short num = (short)1862846171;
				short num2 = num;
				num = (short)1803667163;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1185939456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1210515457;
				if (num != 0)
				{
				}
				num = (short)1011220480;
				if (num != 0)
				{
				}
				return this.dataProfGeneralQueueDwellTimersec_A8806.Max;
			}
			set
			{
				short num = (short)1591672833;
				if (num != 0)
				{
				}
				num = (short)888930304;
				short num2 = num;
				num = (short)478365306;
				short num3 = num;
				num = (short)1705199226;
				switch (num3 == num)
				{
				}
				num = (short)733216768;
				if (num != 0)
				{
				}
				this.dataProfGeneralQueueDwellTimersec_A8806.Max = value;
			}
		}

		// Token: 0x17005766 RID: 22374
		// (get) Token: 0x0600AE43 RID: 44611 RVA: 0x00A20EE0 File Offset: 0x00A1F0E0
		// (set) Token: 0x0600AE44 RID: 44612 RVA: 0x00A20F94 File Offset: 0x00A1F194
		internal int DataProfGeneralQueueDwellTimersec_A8806Step
		{
			get
			{
				short num = (short)1052493977;
				short num2 = num;
				num = (short)1331087513;
				switch (num2 == num)
				{
				default:
				{
					num = (short)145031168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2112815104;
				if (num != 0)
				{
				}
				num = (short)2082668545;
				if (num != 0)
				{
				}
				return this.dataProfGeneralQueueDwellTimersec_A8806.StepSize;
			}
			set
			{
				short num = (short)1830602763;
				short num2 = num;
				num = (short)1901971467;
				switch (num2 == num)
				{
				default:
				{
					num = (short)105971712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)712114177;
				if (num != 0)
				{
				}
				num = (short)1974599680;
				if (num != 0)
				{
				}
				this.dataProfGeneralQueueDwellTimersec_A8806.StepSize = value;
			}
		}

		// Token: 0x17005767 RID: 22375
		// (get) Token: 0x0600AE45 RID: 44613 RVA: 0x00A2104C File Offset: 0x00A1F24C
		// (set) Token: 0x0600AE46 RID: 44614 RVA: 0x00A210FC File Offset: 0x00A1F2FC
		public bool DataProfGeneralQueueDwellTimersec_A8806_Applicable
		{
			get
			{
				short num = (short)48337619;
				short num2 = num;
				num = (short)604803795;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1493499904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2147352577;
				if (num != 0)
				{
				}
				num = (short)317521920;
				if (num != 0)
				{
				}
				return this.dataProfGeneralQueueDwellTimersec_A8806.Applicable;
			}
			set
			{
				short num = (short)536187945;
				short num2 = num;
				num = (short)1890554921;
				switch (num2 == num)
				{
				default:
				{
					num = (short)267714560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1942093825;
				if (num != 0)
				{
				}
				num = (short)639959040;
				if (num != 0)
				{
				}
				this.dataProfGeneralQueueDwellTimersec_A8806.Applicable = value;
			}
		}

		// Token: 0x17005768 RID: 22376
		// (get) Token: 0x0600AE47 RID: 44615 RVA: 0x00A211B0 File Offset: 0x00A1F3B0
		// (set) Token: 0x0600AE48 RID: 44616 RVA: 0x00A21268 File Offset: 0x00A1F468
		public bool DataProfGeneralQueueDwellTimersec_A8806_Valid
		{
			get
			{
				short num = (short)1172000031;
				short num2 = num;
				num = (short)2052738335;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1006501888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)789643265;
				if (num != 0)
				{
				}
				num = (short)609353728;
				if (num != 0)
				{
				}
				return this.dataProfGeneralQueueDwellTimersec_A8806.Valid;
			}
			set
			{
				short num = (short)871068965;
				short num2 = num;
				num = (short)321615141;
				switch (num2 == num)
				{
				default:
				{
					num = (short)859242496;
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
				num = (short)298188801;
				if (num != 0)
				{
				}
				this.dataProfGeneralQueueDwellTimersec_A8806.Valid = value;
			}
		}

		// Token: 0x17005769 RID: 22377
		// (get) Token: 0x0600AE49 RID: 44617 RVA: 0x00A2131C File Offset: 0x00A1F51C
		// (set) Token: 0x0600AE4A RID: 44618 RVA: 0x00A213D0 File Offset: 0x00A1F5D0
		public bool DataProfGeneralQueueDwellTimersec_A8806_Visible
		{
			get
			{
				short num = (short)818216961;
				if (num != 0)
				{
				}
				num = (short)323551232;
				short num2 = num;
				num = (short)620328261;
				short num3 = num;
				num = (short)1602319685;
				switch (num3 == num)
				{
				}
				num = (short)2015428608;
				if (num != 0)
				{
				}
				return this.dataProfGeneralQueueDwellTimersec_A8806.Visible;
			}
			set
			{
				short num = (short)572920600;
				short num2 = num;
				num = (short)158667544;
				switch (num2 == num)
				{
				default:
				{
					num = (short)271384576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)502267905;
				if (num != 0)
				{
				}
				num = (short)1185349632;
				if (num != 0)
				{
				}
				this.dataProfGeneralQueueDwellTimersec_A8806.Visible = value;
			}
		}

		// Token: 0x1700576A RID: 22378
		// (get) Token: 0x0600AE4B RID: 44619 RVA: 0x00A21488 File Offset: 0x00A1F688
		// (set) Token: 0x0600AE4C RID: 44620 RVA: 0x00A21538 File Offset: 0x00A1F738
		public bool DataProfGeneralQueueDwellTimersec_A8806_Editable
		{
			get
			{
				short num = (short)745032893;
				short num2 = num;
				num = (short)1639730365;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1845362688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)739049472;
				if (num != 0)
				{
				}
				num = (short)1853423617;
				if (num != 0)
				{
				}
				return this.dataProfGeneralQueueDwellTimersec_A8806.Editable;
			}
			set
			{
				short num = (short)1123024897;
				if (num != 0)
				{
				}
				num = (short)308805632;
				short num2 = num;
				num = (short)1102434467;
				short num3 = num;
				num = (short)1696256163;
				switch (num3 == num)
				{
				}
				num = (short)948305920;
				if (num != 0)
				{
				}
				this.dataProfGeneralQueueDwellTimersec_A8806.Editable = value;
			}
		}

		// Token: 0x1700576B RID: 22379
		// (get) Token: 0x0600AE4D RID: 44621 RVA: 0x00A215EC File Offset: 0x00A1F7EC
		internal string DataProfGeneralQueueDwellTimersec_A8806_UILabel
		{
			get
			{
				short num = (short)1111088517;
				short num2 = num;
				num = (short)516152709;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1146552320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1007550465;
				if (num != 0)
				{
				}
				num = (short)1105592320;
				if (num != 0)
				{
				}
				return this.dataProfGeneralQueueDwellTimersec_A8806.UIName;
			}
		}

		// Token: 0x1700576C RID: 22380
		// (get) Token: 0x0600AE4E RID: 44622 RVA: 0x00A216A4 File Offset: 0x00A1F8A4
		// (set) Token: 0x0600AE4F RID: 44623 RVA: 0x00A21758 File Offset: 0x00A1F958
		internal bool DataProfGeneralQueueDwellTimersec_A8806_HiddenStatic
		{
			get
			{
				short num = (short)1911423279;
				short num2 = num;
				num = (short)910885167;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1396637696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1146486785;
				if (num != 0)
				{
				}
				num = (short)552730624;
				if (num != 0)
				{
				}
				return this.dataProfGeneralQueueDwellTimersec_A8806.HiddenStatic;
			}
			set
			{
				short num = (short)118031260;
				short num2 = num;
				num = (short)485753756;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1297350656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)370475009;
				if (num != 0)
				{
				}
				num = (short)270204928;
				if (num != 0)
				{
				}
				this.dataProfGeneralQueueDwellTimersec_A8806.HiddenStatic = value;
			}
		}

		// Token: 0x1700576D RID: 22381
		// (get) Token: 0x0600AE50 RID: 44624 RVA: 0x00A2180C File Offset: 0x00A1FA0C
		// (set) Token: 0x0600AE51 RID: 44625 RVA: 0x00A218C4 File Offset: 0x00A1FAC4
		internal bool DataProfGeneralQueueDwellTimersec_A8806_HiddenDynamic
		{
			get
			{
				short num = (short)951831787;
				short num2 = num;
				num = (short)341298411;
				switch (num2 == num)
				{
				default:
				{
					num = (short)865009664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1975779329;
				if (num != 0)
				{
				}
				num = (short)621281280;
				if (num != 0)
				{
				}
				return this.dataProfGeneralQueueDwellTimersec_A8806.HiddenDynamic;
			}
			set
			{
				short num = (short)1927816130;
				short num2 = num;
				num = (short)1779377090;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2085158912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2145517568;
				if (num != 0)
				{
				}
				num = (short)2140667905;
				if (num != 0)
				{
				}
				this.dataProfGeneralQueueDwellTimersec_A8806.HiddenDynamic = value;
			}
		}

		// Token: 0x1700576E RID: 22382
		// (get) Token: 0x0600AE52 RID: 44626 RVA: 0x00A21978 File Offset: 0x00A1FB78
		public bool DataProfGeneralQueueDwellTimersec_A8806_HasDiffs
		{
			get
			{
				short num = (short)262873331;
				short num2 = num;
				num = (short)1438392563;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1026686976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)377946113;
				if (num != 0)
				{
				}
				num = (short)24707072;
				if (num != 0)
				{
				}
				return this.dataProfGeneralQueueDwellTimersec_A8806._HasDiffs;
			}
		}

		// Token: 0x1700576F RID: 22383
		// (get) Token: 0x0600AE53 RID: 44627 RVA: 0x00A21A2C File Offset: 0x00A1FC2C
		// (set) Token: 0x0600AE54 RID: 44628 RVA: 0x00A21AE4 File Offset: 0x00A1FCE4
		public bool DataWideGeneralNATEnable_A38866Value
		{
			get
			{
				short num = (short)1829229686;
				short num2 = num;
				num = (short)454087798;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1463681024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)546701313;
				if (num != 0)
				{
				}
				num = (short)940572672;
				if (num != 0)
				{
				}
				return this.dataWideGeneralNATEnable_A38866.Value;
			}
			set
			{
				short num = (short)985248985;
				short num2 = num;
				num = (short)1095480537;
				switch (num2 == num)
				{
				default:
				{
					num = (short)45940736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)423493633;
				if (num != 0)
				{
				}
				num = (short)832372736;
				if (num != 0)
				{
				}
				this.dataWideGeneralNATEnable_A38866.Value = value;
			}
		}

		// Token: 0x17005770 RID: 22384
		// (get) Token: 0x0600AE55 RID: 44629 RVA: 0x00A21B9C File Offset: 0x00A1FD9C
		public global::AcpBusinessLayer.AcpField<bool> DataWideGeneralNATEnable_A38866
		{
			get
			{
				short num = (short)717080884;
				short num2 = num;
				num = (short)1168099636;
				switch (num2 == num)
				{
				default:
				{
					num = (short)281673728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1081409537;
				if (num != 0)
				{
				}
				num = (short)1867317248;
				if (num != 0)
				{
				}
				return this.dataWideGeneralNATEnable_A38866;
			}
		}

		// Token: 0x17005771 RID: 22385
		// (get) Token: 0x0600AE56 RID: 44630 RVA: 0x00A21C4C File Offset: 0x00A1FE4C
		// (set) Token: 0x0600AE57 RID: 44631 RVA: 0x00A21D04 File Offset: 0x00A1FF04
		public bool DataWideGeneralNATEnable_A38866_UIValue
		{
			get
			{
				short num = (short)1852140995;
				short num2 = num;
				num = (short)1215655363;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1069809664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)777912321;
				if (num != 0)
				{
				}
				num = (short)1258029056;
				if (num != 0)
				{
				}
				return this.dataWideGeneralNATEnable_A38866.Value;
			}
			set
			{
				short num = (short)1783975568;
				short num2 = num;
				num = (short)629755536;
				switch (num2 == num)
				{
				default:
				{
					num = (short)892272640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1544749057;
				if (num != 0)
				{
				}
				num = (short)772866048;
				if (num != 0)
				{
				}
				this.dataWideGeneralNATEnable_A38866.Value = value;
			}
		}

		// Token: 0x17005772 RID: 22386
		// (get) Token: 0x0600AE58 RID: 44632 RVA: 0x00A21DB8 File Offset: 0x00A1FFB8
		// (set) Token: 0x0600AE59 RID: 44633 RVA: 0x00A21E70 File Offset: 0x00A20070
		public bool DataWideGeneralNATEnable_A38866_Applicable
		{
			get
			{
				short num = (short)524936509;
				short num2 = num;
				num = (short)1858135357;
				switch (num2 == num)
				{
				default:
				{
					num = (short)785711104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)768606209;
				if (num != 0)
				{
				}
				num = (short)175964160;
				if (num != 0)
				{
				}
				return this.dataWideGeneralNATEnable_A38866.Applicable;
			}
			set
			{
				short num = (short)1349899923;
				short num2 = num;
				num = (short)1500436115;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1910898688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1675165697;
				if (num != 0)
				{
				}
				num = (short)1622016000;
				if (num != 0)
				{
				}
				this.dataWideGeneralNATEnable_A38866.Applicable = value;
			}
		}

		// Token: 0x17005773 RID: 22387
		// (get) Token: 0x0600AE5A RID: 44634 RVA: 0x00A21F28 File Offset: 0x00A20128
		// (set) Token: 0x0600AE5B RID: 44635 RVA: 0x00A21FDC File Offset: 0x00A201DC
		public bool DataWideGeneralNATEnable_A38866_Valid
		{
			get
			{
				short num = (short)899627726;
				short num2 = num;
				num = (short)1846164174;
				switch (num2 == num)
				{
				}
				num = (short)1851981824;
				short num3 = num;
				num = (short)703463424;
				if (num != 0)
				{
				}
				num = (short)1590231041;
				if (num != 0)
				{
				}
				return this.dataWideGeneralNATEnable_A38866.Valid;
			}
			set
			{
				short num = (short)718667777;
				if (num != 0)
				{
				}
				num = (short)289207301;
				short num2 = num;
				num = (short)1449980933;
				switch (num2 == num)
				{
				default:
				{
					num = (short)736952320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)772538368;
				if (num != 0)
				{
				}
				this.dataWideGeneralNATEnable_A38866.Valid = value;
			}
		}

		// Token: 0x17005774 RID: 22388
		// (get) Token: 0x0600AE5C RID: 44636 RVA: 0x00A22090 File Offset: 0x00A20290
		// (set) Token: 0x0600AE5D RID: 44637 RVA: 0x00A22144 File Offset: 0x00A20344
		public bool DataWideGeneralNATEnable_A38866_Visible
		{
			get
			{
				short num = (short)1213396476;
				short num2 = num;
				num = (short)879293948;
				switch (num2 == num)
				{
				}
				num = (short)994902016;
				short num3 = num;
				num = (short)1692467201;
				if (num != 0)
				{
				}
				num = (short)181600256;
				if (num != 0)
				{
				}
				return this.dataWideGeneralNATEnable_A38866.Visible;
			}
			set
			{
				short num = (short)255955129;
				short num2 = num;
				num = (short)2133627065;
				switch (num2 == num)
				{
				}
				num = (short)767033344;
				short num3 = num;
				num = (short)1158086657;
				if (num != 0)
				{
				}
				num = (short)879034368;
				if (num != 0)
				{
				}
				this.dataWideGeneralNATEnable_A38866.Visible = value;
			}
		}

		// Token: 0x17005775 RID: 22389
		// (get) Token: 0x0600AE5E RID: 44638 RVA: 0x00A221FC File Offset: 0x00A203FC
		// (set) Token: 0x0600AE5F RID: 44639 RVA: 0x00A222B4 File Offset: 0x00A204B4
		public bool DataWideGeneralNATEnable_A38866_Editable
		{
			get
			{
				short num = (short)594252928;
				short num2 = num;
				num = (short)1197053056;
				switch (num2 == num)
				{
				}
				num = (short)1242234880;
				short num3 = num;
				num = (short)980287489;
				if (num != 0)
				{
				}
				num = (short)1017053184;
				if (num != 0)
				{
				}
				return this.dataWideGeneralNATEnable_A38866.Editable;
			}
			set
			{
				short num = (short)371492012;
				short num2 = num;
				num = (short)781812908;
				switch (num2 == num)
				{
				}
				num = (short)1762394112;
				short num3 = num;
				num = (short)1001848832;
				if (num != 0)
				{
				}
				num = (short)141950977;
				if (num != 0)
				{
				}
				this.dataWideGeneralNATEnable_A38866.Editable = value;
			}
		}

		// Token: 0x17005776 RID: 22390
		// (get) Token: 0x0600AE60 RID: 44640 RVA: 0x00A2236C File Offset: 0x00A2056C
		internal string DataWideGeneralNATEnable_A38866_UILabel
		{
			get
			{
				short num = (short)1559335944;
				short num2 = num;
				num = (short)208180232;
				switch (num2 == num)
				{
				}
				num = (short)1059782656;
				short num3 = num;
				num = (short)397082625;
				if (num != 0)
				{
				}
				num = (short)78839808;
				if (num != 0)
				{
				}
				return this.dataWideGeneralNATEnable_A38866.UIName;
			}
		}

		// Token: 0x17005777 RID: 22391
		// (get) Token: 0x0600AE61 RID: 44641 RVA: 0x00A22420 File Offset: 0x00A20620
		// (set) Token: 0x0600AE62 RID: 44642 RVA: 0x00A224D8 File Offset: 0x00A206D8
		internal bool DataWideGeneralNATEnable_A38866_HiddenStatic
		{
			get
			{
				short num = (short)1141155152;
				short num2 = num;
				num = (short)1291756880;
				switch (num2 == num)
				{
				}
				num = (short)895090688;
				short num3 = num;
				num = (short)1097203712;
				if (num != 0)
				{
				}
				num = (short)1135411201;
				if (num != 0)
				{
				}
				return this.dataWideGeneralNATEnable_A38866.HiddenStatic;
			}
			set
			{
				short num = (short)2002828455;
				short num2 = num;
				num = (short)1662827687;
				switch (num2 == num)
				{
				}
				num = (short)860291072;
				short num3 = num;
				num = (short)1864433664;
				if (num != 0)
				{
				}
				num = (short)801570817;
				if (num != 0)
				{
				}
				this.dataWideGeneralNATEnable_A38866.HiddenStatic = value;
			}
		}

		// Token: 0x17005778 RID: 22392
		// (get) Token: 0x0600AE63 RID: 44643 RVA: 0x00A2258C File Offset: 0x00A2078C
		// (set) Token: 0x0600AE64 RID: 44644 RVA: 0x00A22644 File Offset: 0x00A20844
		internal bool DataWideGeneralNATEnable_A38866_HiddenDynamic
		{
			get
			{
				short num = (short)585839815;
				short num2 = num;
				num = (short)487077063;
				switch (num2 == num)
				{
				}
				num = (short)144900096;
				short num3 = num;
				num = (short)638713857;
				if (num != 0)
				{
				}
				num = (short)1364131840;
				if (num != 0)
				{
				}
				return this.dataWideGeneralNATEnable_A38866.HiddenDynamic;
			}
			set
			{
				short num = (short)1245004177;
				short num2 = num;
				num = (short)964641169;
				switch (num2 == num)
				{
				}
				num = (short)1016791040;
				short num3 = num;
				num = (short)213319680;
				if (num != 0)
				{
				}
				num = (short)1479081985;
				if (num != 0)
				{
				}
				this.dataWideGeneralNATEnable_A38866.HiddenDynamic = value;
			}
		}

		// Token: 0x17005779 RID: 22393
		// (get) Token: 0x0600AE65 RID: 44645 RVA: 0x00A226FC File Offset: 0x00A208FC
		public bool DataWideGeneralNATEnable_A38866_HasDiffs
		{
			get
			{
				short num = (short)1287716865;
				if (num != 0)
				{
				}
				num = (short)2056014936;
				short num2 = num;
				num = (short)1464159320;
				switch (num2 == num)
				{
				default:
				{
					num = (short)955056128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1648623616;
				if (num != 0)
				{
				}
				return this.dataWideGeneralNATEnable_A38866._HasDiffs;
			}
		}

		// Token: 0x1700577A RID: 22394
		// (get) Token: 0x0600AE66 RID: 44646 RVA: 0x00A227B4 File Offset: 0x00A209B4
		// (set) Token: 0x0600AE67 RID: 44647 RVA: 0x00A22868 File Offset: 0x00A20A68
		public long DataProfilesGeneralBTDUNSUIPAddress_A41126Value
		{
			get
			{
				short num = (short)1688784895;
				short num2 = num;
				num = (short)2041106431;
				switch (num2 == num)
				{
				}
				num = (short)1226768384;
				short num3 = num;
				num = (short)1409810432;
				if (num != 0)
				{
				}
				num = (short)1071513601;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNSUIPAddress_A41126.Value;
			}
			set
			{
				short num = (short)493944833;
				if (num != 0)
				{
				}
				num = (short)355280497;
				short num2 = num;
				num = (short)2032215665;
				switch (num2 == num)
				{
				default:
				{
					num = (short)483000320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1164574720;
				if (num != 0)
				{
				}
				this.dataProfilesGeneralBTDUNSUIPAddress_A41126.Value = value;
			}
		}

		// Token: 0x1700577B RID: 22395
		// (get) Token: 0x0600AE68 RID: 44648 RVA: 0x00A22920 File Offset: 0x00A20B20
		// (set) Token: 0x0600AE69 RID: 44649 RVA: 0x00A229D4 File Offset: 0x00A20BD4
		public string DataProfilesGeneralBTDUNSUIPAddress_A41126_UIValue
		{
			get
			{
				short num = (short)346309007;
				short num2 = num;
				num = (short)521748879;
				switch (num2 == num)
				{
				}
				num = (short)1551302656;
				short num3 = num;
				num = (short)904986625;
				if (num != 0)
				{
				}
				num = (short)1867579392;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNSUIPAddress_A41126.UIValue;
			}
			set
			{
				short num = (short)251093147;
				short num2 = num;
				num = (short)901406875;
				switch (num2 == num)
				{
				}
				num = (short)596312064;
				short num3 = num;
				num = (short)1580728321;
				if (num != 0)
				{
				}
				num = (short)398917632;
				if (num != 0)
				{
				}
				this.dataProfilesGeneralBTDUNSUIPAddress_A41126.UIValue = value;
			}
		}

		// Token: 0x1700577C RID: 22396
		// (get) Token: 0x0600AE6A RID: 44650 RVA: 0x00A22A8C File Offset: 0x00A20C8C
		public global::AcpBusinessLayer.AcpIPAddressField DataProfilesGeneralBTDUNSUIPAddress_A41126
		{
			get
			{
				short num = (short)126250569;
				short num2 = num;
				num = (short)1733193289;
				switch (num2 == num)
				{
				}
				num = (short)995622912;
				short num3 = num;
				num = (short)1065484288;
				if (num != 0)
				{
				}
				num = (short)2097283073;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNSUIPAddress_A41126;
			}
		}

		// Token: 0x1700577D RID: 22397
		// (get) Token: 0x0600AE6B RID: 44651 RVA: 0x00A22B3C File Offset: 0x00A20D3C
		// (set) Token: 0x0600AE6C RID: 44652 RVA: 0x00A22BF0 File Offset: 0x00A20DF0
		public bool DataProfilesGeneralBTDUNSUIPAddress_A41126_Applicable
		{
			get
			{
				short num = (short)545384614;
				short num2 = num;
				num = (short)199223462;
				switch (num2 == num)
				{
				}
				num = (short)498008064;
				short num3 = num;
				num = (short)843513857;
				if (num != 0)
				{
				}
				num = (short)947453952;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNSUIPAddress_A41126.Applicable;
			}
			set
			{
				short num = (short)2012799910;
				short num2 = num;
				num = (short)2101863334;
				switch (num2 == num)
				{
				}
				num = (short)1453129728;
				short num3 = num;
				num = (short)299958273;
				if (num != 0)
				{
				}
				num = (short)490995712;
				if (num != 0)
				{
				}
				this.dataProfilesGeneralBTDUNSUIPAddress_A41126.Applicable = value;
			}
		}

		// Token: 0x1700577E RID: 22398
		// (get) Token: 0x0600AE6D RID: 44653 RVA: 0x00A22CA4 File Offset: 0x00A20EA4
		// (set) Token: 0x0600AE6E RID: 44654 RVA: 0x00A22D58 File Offset: 0x00A20F58
		public bool DataProfilesGeneralBTDUNSUIPAddress_A41126_Valid
		{
			get
			{
				short num = (short)2135865610;
				short num2 = num;
				num = (short)147634442;
				switch (num2 == num)
				{
				}
				num = (short)2009006080;
				short num3 = num;
				num = (short)286785536;
				if (num != 0)
				{
				}
				num = (short)1283325953;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNSUIPAddress_A41126.Valid;
			}
			set
			{
				short num = (short)245693157;
				short num2 = num;
				num = (short)1718680293;
				switch (num2 == num)
				{
				}
				num = (short)469958656;
				short num3 = num;
				num = (short)1176109056;
				if (num != 0)
				{
				}
				num = (short)1908998145;
				if (num != 0)
				{
				}
				this.dataProfilesGeneralBTDUNSUIPAddress_A41126.Valid = value;
			}
		}

		// Token: 0x1700577F RID: 22399
		// (get) Token: 0x0600AE6F RID: 44655 RVA: 0x00A22E0C File Offset: 0x00A2100C
		// (set) Token: 0x0600AE70 RID: 44656 RVA: 0x00A22EC0 File Offset: 0x00A210C0
		public bool DataProfilesGeneralBTDUNSUIPAddress_A41126_Visible
		{
			get
			{
				short num = (short)2059273558;
				short num2 = num;
				num = (short)1829373270;
				switch (num2 == num)
				{
				}
				num = (short)1010958336;
				short num3 = num;
				num = (short)812449792;
				if (num != 0)
				{
				}
				num = (short)1517879297;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNSUIPAddress_A41126.Visible;
			}
			set
			{
				short num = (short)2079326600;
				short num2 = num;
				num = (short)1278476680;
				switch (num2 == num)
				{
				}
				num = (short)779288576;
				short num3 = num;
				num = (short)226820097;
				if (num != 0)
				{
				}
				num = (short)1135017984;
				if (num != 0)
				{
				}
				this.dataProfilesGeneralBTDUNSUIPAddress_A41126.Visible = value;
			}
		}

		// Token: 0x17005780 RID: 22400
		// (get) Token: 0x0600AE71 RID: 44657 RVA: 0x00A22F78 File Offset: 0x00A21178
		// (set) Token: 0x0600AE72 RID: 44658 RVA: 0x00A2302C File Offset: 0x00A2122C
		public bool DataProfilesGeneralBTDUNSUIPAddress_A41126_Editable
		{
			get
			{
				short num = (short)1681826688;
				short num2 = num;
				num = (short)1783866240;
				switch (num2 == num)
				{
				}
				num = (short)850132992;
				short num3 = num;
				num = (short)255393792;
				if (num != 0)
				{
				}
				num = (short)854458369;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNSUIPAddress_A41126.Editable;
			}
			set
			{
				short num = (short)459294274;
				short num2 = num;
				num = (short)1328432706;
				switch (num2 == num)
				{
				}
				num = (short)2115764224;
				short num3 = num;
				num = (short)1704525825;
				if (num != 0)
				{
				}
				num = (short)97714176;
				if (num != 0)
				{
				}
				this.dataProfilesGeneralBTDUNSUIPAddress_A41126.Editable = value;
			}
		}

		// Token: 0x17005781 RID: 22401
		// (get) Token: 0x0600AE73 RID: 44659 RVA: 0x00A230E4 File Offset: 0x00A212E4
		internal string DataProfilesGeneralBTDUNSUIPAddress_A41126_UILabel
		{
			get
			{
				short num = (short)153707494;
				short num2 = num;
				num = (short)1533174758;
				switch (num2 == num)
				{
				}
				num = (short)1134297088;
				short num3 = num;
				num = (short)2098659329;
				if (num != 0)
				{
				}
				num = (short)60620800;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNSUIPAddress_A41126.UIName;
			}
		}

		// Token: 0x17005782 RID: 22402
		// (get) Token: 0x0600AE74 RID: 44660 RVA: 0x00A23198 File Offset: 0x00A21398
		// (set) Token: 0x0600AE75 RID: 44661 RVA: 0x00A23250 File Offset: 0x00A21450
		internal bool DataProfilesGeneralBTDUNSUIPAddress_A41126_HiddenStatic
		{
			get
			{
				short num = (short)1254190662;
				short num2 = num;
				num = (short)17264198;
				switch (num2 == num)
				{
				}
				num = (short)310575104;
				short num3 = num;
				num = (short)619184129;
				if (num != 0)
				{
				}
				num = (short)1754595328;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNSUIPAddress_A41126.HiddenStatic;
			}
			set
			{
				short num = (short)1768716003;
				short num2 = num;
				num = (short)453801699;
				switch (num2 == num)
				{
				}
				num = (short)1566310400;
				short num3 = num;
				num = (short)1298202625;
				if (num != 0)
				{
				}
				num = (short)174063616;
				if (num != 0)
				{
				}
				this.dataProfilesGeneralBTDUNSUIPAddress_A41126.HiddenStatic = value;
			}
		}

		// Token: 0x17005783 RID: 22403
		// (get) Token: 0x0600AE76 RID: 44662 RVA: 0x00A23304 File Offset: 0x00A21504
		// (set) Token: 0x0600AE77 RID: 44663 RVA: 0x00A233B8 File Offset: 0x00A215B8
		internal bool DataProfilesGeneralBTDUNSUIPAddress_A41126_HiddenDynamic
		{
			get
			{
				short num = (short)1939996665;
				short num2 = num;
				num = (short)1541275641;
				switch (num2 == num)
				{
				}
				num = (short)718471168;
				short num3 = num;
				num = (short)482213888;
				if (num != 0)
				{
				}
				num = (short)1419575297;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNSUIPAddress_A41126.HiddenDynamic;
			}
			set
			{
				short num = (short)592238934;
				short num2 = num;
				num = (short)734255446;
				switch (num2 == num)
				{
				}
				num = (short)314900480;
				short num3 = num;
				num = (short)1562836992;
				if (num != 0)
				{
				}
				num = (short)944111617;
				if (num != 0)
				{
				}
				this.dataProfilesGeneralBTDUNSUIPAddress_A41126.HiddenDynamic = value;
			}
		}

		// Token: 0x17005784 RID: 22404
		// (get) Token: 0x0600AE78 RID: 44664 RVA: 0x00A2346C File Offset: 0x00A2166C
		public bool DataProfilesGeneralBTDUNSUIPAddress_A41126_HasDiffs
		{
			get
			{
				short num = (short)1837259031;
				short num2 = num;
				num = (short)830494999;
				switch (num2 == num)
				{
				}
				num = (short)1454964736;
				short num3 = num;
				num = (short)562429953;
				if (num != 0)
				{
				}
				num = (short)1570308096;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNSUIPAddress_A41126._HasDiffs;
			}
		}

		// Token: 0x17005785 RID: 22405
		// (get) Token: 0x0600AE79 RID: 44665 RVA: 0x00A23520 File Offset: 0x00A21720
		// (set) Token: 0x0600AE7A RID: 44666 RVA: 0x00A235D8 File Offset: 0x00A217D8
		public long DataProfilesGeneralBTDUNPeerIPAddress_A41127Value
		{
			get
			{
				short num = (short)404027370;
				short num2 = num;
				num = (short)1180301290;
				switch (num2 == num)
				{
				}
				num = (short)1160380416;
				short num3 = num;
				num = (short)1366818817;
				if (num != 0)
				{
				}
				num = (short)1603076096;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.Value;
			}
			set
			{
				short num = (short)169534300;
				short num2 = num;
				num = (short)67691356;
				switch (num2 == num)
				{
				}
				num = (short)744161280;
				short num3 = num;
				num = (short)1172176897;
				if (num != 0)
				{
				}
				num = (short)1368260608;
				if (num != 0)
				{
				}
				this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.Value = value;
			}
		}

		// Token: 0x17005786 RID: 22406
		// (get) Token: 0x0600AE7B RID: 44667 RVA: 0x00A23690 File Offset: 0x00A21890
		// (set) Token: 0x0600AE7C RID: 44668 RVA: 0x00A23744 File Offset: 0x00A21944
		public string DataProfilesGeneralBTDUNPeerIPAddress_A41127_UIValue
		{
			get
			{
				short num = (short)2120413559;
				short num2 = num;
				num = (short)463532407;
				switch (num2 == num)
				{
				}
				num = (short)887422976;
				short num3 = num;
				num = (short)1718681600;
				if (num != 0)
				{
				}
				num = (short)926679041;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.UIValue;
			}
			set
			{
				short num = (short)1111382021;
				short num2 = num;
				num = (short)1922062341;
				switch (num2 == num)
				{
				}
				num = (short)722468864;
				short num3 = num;
				num = (short)2007171073;
				if (num != 0)
				{
				}
				num = (short)1206124544;
				if (num != 0)
				{
				}
				this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.UIValue = value;
			}
		}

		// Token: 0x17005787 RID: 22407
		// (get) Token: 0x0600AE7D RID: 44669 RVA: 0x00A237F4 File Offset: 0x00A219F4
		public global::AcpBusinessLayer.AcpIPAddressField DataProfilesGeneralBTDUNPeerIPAddress_A41127
		{
			get
			{
				short num = (short)548184100;
				short num2 = num;
				num = (short)1509990436;
				switch (num2 == num)
				{
				}
				num = (short)1130496000;
				short num3 = num;
				num = (short)113901569;
				if (num != 0)
				{
				}
				num = (short)1049624576;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNPeerIPAddress_A41127;
			}
		}

		// Token: 0x17005788 RID: 22408
		// (get) Token: 0x0600AE7E RID: 44670 RVA: 0x00A238A8 File Offset: 0x00A21AA8
		// (set) Token: 0x0600AE7F RID: 44671 RVA: 0x00A2395C File Offset: 0x00A21B5C
		public bool DataProfilesGeneralBTDUNPeerIPAddress_A41127_Applicable
		{
			get
			{
				short num = (short)415039489;
				if (num != 0)
				{
				}
				num = (short)442128162;
				short num2 = num;
				num = (short)398022434;
				switch (num2 == num)
				{
				default:
				{
					num = (short)532938752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1401159680;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.Applicable;
			}
			set
			{
				short num = (short)559342700;
				short num2 = num;
				num = (short)683861100;
				switch (num2 == num)
				{
				}
				num = (short)908132352;
				short num3 = num;
				num = (short)168165377;
				if (num != 0)
				{
				}
				num = (short)946077696;
				if (num != 0)
				{
				}
				this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.Applicable = value;
			}
		}

		// Token: 0x17005789 RID: 22409
		// (get) Token: 0x0600AE80 RID: 44672 RVA: 0x00A23A10 File Offset: 0x00A21C10
		// (set) Token: 0x0600AE81 RID: 44673 RVA: 0x00A23AC4 File Offset: 0x00A21CC4
		public bool DataProfilesGeneralBTDUNPeerIPAddress_A41127_Valid
		{
			get
			{
				short num = (short)1502077124;
				short num2 = num;
				num = (short)1397547204;
				switch (num2 == num)
				{
				}
				num = (short)294912000;
				short num3 = num;
				num = (short)624295937;
				if (num != 0)
				{
				}
				num = (short)42598400;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.Valid;
			}
			set
			{
				short num = (short)353406571;
				short num2 = num;
				num = (short)408915563;
				switch (num2 == num)
				{
				}
				num = (short)1917255680;
				short num3 = num;
				num = (short)672923649;
				if (num != 0)
				{
				}
				num = (short)1326972928;
				if (num != 0)
				{
				}
				this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.Valid = value;
			}
		}

		// Token: 0x1700578A RID: 22410
		// (get) Token: 0x0600AE82 RID: 44674 RVA: 0x00A23B78 File Offset: 0x00A21D78
		// (set) Token: 0x0600AE83 RID: 44675 RVA: 0x00A23C28 File Offset: 0x00A21E28
		public bool DataProfilesGeneralBTDUNPeerIPAddress_A41127_Visible
		{
			get
			{
				short num = (short)30521524;
				short num2 = num;
				num = (short)1316272308;
				switch (num2 == num)
				{
				}
				num = (short)50528256;
				short num3 = num;
				num = (short)2136866817;
				if (num != 0)
				{
				}
				num = (short)1129381888;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.Visible;
			}
			set
			{
				short num = (short)1098711041;
				if (num != 0)
				{
				}
				num = (short)1674586963;
				short num2 = num;
				num = (short)1011166035;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1572208640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1656684544;
				if (num != 0)
				{
				}
				this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.Visible = value;
			}
		}

		// Token: 0x1700578B RID: 22411
		// (get) Token: 0x0600AE84 RID: 44676 RVA: 0x00A23CE0 File Offset: 0x00A21EE0
		// (set) Token: 0x0600AE85 RID: 44677 RVA: 0x00A23D94 File Offset: 0x00A21F94
		public bool DataProfilesGeneralBTDUNPeerIPAddress_A41127_Editable
		{
			get
			{
				short num = (short)1600397533;
				short num2 = num;
				num = (short)1724063965;
				switch (num2 == num)
				{
				}
				num = (short)1233256448;
				short num3 = num;
				num = (short)790626304;
				if (num != 0)
				{
				}
				num = (short)1731067905;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.Editable;
			}
			set
			{
				short num = (short)1385942119;
				short num2 = num;
				num = (short)1569967207;
				switch (num2 == num)
				{
				}
				num = (short)1656619008;
				short num3 = num;
				num = (short)1095172097;
				if (num != 0)
				{
				}
				num = (short)442564608;
				if (num != 0)
				{
				}
				this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.Editable = value;
			}
		}

		// Token: 0x1700578C RID: 22412
		// (get) Token: 0x0600AE86 RID: 44678 RVA: 0x00A23E4C File Offset: 0x00A2204C
		internal string DataProfilesGeneralBTDUNPeerIPAddress_A41127_UILabel
		{
			get
			{
				short num = (short)97108491;
				short num2 = num;
				num = (short)1128776203;
				switch (num2 == num)
				{
				}
				num = (short)882507776;
				short num3 = num;
				num = (short)42074113;
				if (num != 0)
				{
				}
				num = (short)1250557952;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.UIName;
			}
		}

		// Token: 0x1700578D RID: 22413
		// (get) Token: 0x0600AE87 RID: 44679 RVA: 0x00A23F00 File Offset: 0x00A22100
		// (set) Token: 0x0600AE88 RID: 44680 RVA: 0x00A23FB4 File Offset: 0x00A221B4
		internal bool DataProfilesGeneralBTDUNPeerIPAddress_A41127_HiddenStatic
		{
			get
			{
				short num = (short)36995219;
				short num2 = num;
				num = (short)1420918931;
				switch (num2 == num)
				{
				}
				num = (short)1759510528;
				short num3 = num;
				num = (short)1203634177;
				if (num != 0)
				{
				}
				num = (short)1674772480;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.HiddenStatic;
			}
			set
			{
				short num = (short)1357512705;
				if (num != 0)
				{
				}
				num = (short)357782467;
				short num2 = num;
				num = (short)1229607875;
				switch (num2 == num)
				{
				default:
				{
					num = (short)342228992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)941424640;
				if (num != 0)
				{
				}
				this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.HiddenStatic = value;
			}
		}

		// Token: 0x1700578E RID: 22414
		// (get) Token: 0x0600AE89 RID: 44681 RVA: 0x00A24068 File Offset: 0x00A22268
		// (set) Token: 0x0600AE8A RID: 44682 RVA: 0x00A2411C File Offset: 0x00A2231C
		internal bool DataProfilesGeneralBTDUNPeerIPAddress_A41127_HiddenDynamic
		{
			get
			{
				short num = (short)1106508417;
				short num2 = num;
				num = (short)1731394177;
				switch (num2 == num)
				{
				}
				num = (short)1893400576;
				short num3 = num;
				num = (short)431489025;
				if (num != 0)
				{
				}
				num = (short)252837888;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.HiddenDynamic;
			}
			set
			{
				short num = (short)237830145;
				if (num != 0)
				{
				}
				num = (short)2091750119;
				short num2 = num;
				num = (short)477139687;
				switch (num2 == num)
				{
				default:
				{
					num = (short)240254976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)428081152;
				if (num != 0)
				{
				}
				this.dataProfilesGeneralBTDUNPeerIPAddress_A41127.HiddenDynamic = value;
			}
		}

		// Token: 0x1700578F RID: 22415
		// (get) Token: 0x0600AE8B RID: 44683 RVA: 0x00A241D0 File Offset: 0x00A223D0
		public bool DataProfilesGeneralBTDUNPeerIPAddress_A41127_HasDiffs
		{
			get
			{
				short num = (short)1859146813;
				short num2 = num;
				num = (short)1608864829;
				switch (num2 == num)
				{
				}
				num = (short)117309440;
				short num3 = num;
				num = (short)1520697344;
				if (num != 0)
				{
				}
				num = (short)1015152641;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNPeerIPAddress_A41127._HasDiffs;
			}
		}

		// Token: 0x17005790 RID: 22416
		// (get) Token: 0x0600AE8C RID: 44684 RVA: 0x00A24284 File Offset: 0x00A22484
		// (set) Token: 0x0600AE8D RID: 44685 RVA: 0x00A24334 File Offset: 0x00A22534
		public int DataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128Value
		{
			get
			{
				short num = (short)1320377067;
				short num2 = num;
				num = (short)1596611307;
				switch (num2 == num)
				{
				}
				num = (short)1572208640;
				short num3 = num;
				num = (short)1235419137;
				if (num != 0)
				{
				}
				num = (short)777584640;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.Value;
			}
			set
			{
				short num = (short)1520010525;
				short num2 = num;
				num = (short)75924765;
				switch (num2 == num)
				{
				}
				num = (short)2133393408;
				short num3 = num;
				num = (short)1106116609;
				if (num != 0)
				{
				}
				num = (short)1741946880;
				if (num != 0)
				{
				}
				this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.Value = value;
			}
		}

		// Token: 0x17005791 RID: 22417
		// (get) Token: 0x0600AE8E RID: 44686 RVA: 0x00A243E8 File Offset: 0x00A225E8
		// (set) Token: 0x0600AE8F RID: 44687 RVA: 0x00A2449C File Offset: 0x00A2269C
		public string DataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128_UIValue
		{
			get
			{
				short num = (short)1636461290;
				short num2 = num;
				num = (short)625961706;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1600389120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1563426817;
				if (num != 0)
				{
				}
				num = (short)1509294080;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.UIValue;
			}
			set
			{
				short num = (short)1368534067;
				short num2 = num;
				num = (short)931605555;
				switch (num2 == num)
				{
				default:
				{
					num = (short)993329152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1931542529;
				if (num != 0)
				{
				}
				num = (short)53936128;
				if (num != 0)
				{
				}
				this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.UIValue = value;
			}
		}

		// Token: 0x17005792 RID: 22418
		// (get) Token: 0x0600AE90 RID: 44688 RVA: 0x00A24554 File Offset: 0x00A22754
		public global::AcpBusinessLayer.AcpListField DataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128
		{
			get
			{
				short num = (short)38263726;
				short num2 = num;
				num = (short)640670638;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1246560256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)321191936;
				if (num != 0)
				{
				}
				num = (short)1835008001;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128;
			}
		}

		// Token: 0x17005793 RID: 22419
		// (get) Token: 0x0600AE91 RID: 44689 RVA: 0x00A24604 File Offset: 0x00A22804
		// (set) Token: 0x0600AE92 RID: 44690 RVA: 0x00A246B8 File Offset: 0x00A228B8
		public bool DataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128_Applicable
		{
			get
			{
				short num = (short)48431105;
				if (num != 0)
				{
				}
				num = (short)1215168512;
				short num2 = num;
				num = (short)1125201272;
				short num3 = num;
				num = (short)714618232;
				switch (num3 == num)
				{
				}
				num = (short)305135616;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.Applicable;
			}
			set
			{
				short num = (short)136508028;
				short num2 = num;
				num = (short)1952051836;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1611268096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)814415872;
				if (num != 0)
				{
				}
				num = (short)1896939521;
				if (num != 0)
				{
				}
				this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.Applicable = value;
			}
		}

		// Token: 0x17005794 RID: 22420
		// (get) Token: 0x0600AE93 RID: 44691 RVA: 0x00A2476C File Offset: 0x00A2296C
		// (set) Token: 0x0600AE94 RID: 44692 RVA: 0x00A24824 File Offset: 0x00A22A24
		public bool DataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128_Valid
		{
			get
			{
				short num = (short)1547522684;
				short num2 = num;
				num = (short)552030844;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2038824960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1582170113;
				if (num != 0)
				{
				}
				num = (short)1588396032;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.Valid;
			}
			set
			{
				short num = (short)2009746038;
				short num2 = num;
				num = (short)620251766;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1615462400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)155189248;
				if (num != 0)
				{
				}
				num = (short)2117992449;
				if (num != 0)
				{
				}
				this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.Valid = value;
			}
		}

		// Token: 0x17005795 RID: 22421
		// (get) Token: 0x0600AE95 RID: 44693 RVA: 0x00A248D8 File Offset: 0x00A22AD8
		// (set) Token: 0x0600AE96 RID: 44694 RVA: 0x00A2498C File Offset: 0x00A22B8C
		public bool DataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128_Visible
		{
			get
			{
				short num = (short)97648641;
				if (num != 0)
				{
				}
				num = (short)239927296;
				short num2 = num;
				num = (short)1851732122;
				short num3 = num;
				num = (short)1841639578;
				switch (num3 == num)
				{
				}
				num = (short)2078146560;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.Visible;
			}
			set
			{
				short num = (short)2135692902;
				short num2 = num;
				num = (short)2003048038;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1168703488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)729219073;
				if (num != 0)
				{
				}
				num = (short)586874880;
				if (num != 0)
				{
				}
				this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.Visible = value;
			}
		}

		// Token: 0x17005796 RID: 22422
		// (get) Token: 0x0600AE97 RID: 44695 RVA: 0x00A24A40 File Offset: 0x00A22C40
		// (set) Token: 0x0600AE98 RID: 44696 RVA: 0x00A24AF8 File Offset: 0x00A22CF8
		public bool DataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128_Editable
		{
			get
			{
				short num = (short)1336475649;
				if (num != 0)
				{
				}
				num = (short)1832779776;
				short num2 = num;
				num = (short)212606245;
				short num3 = num;
				num = (short)486022437;
				switch (num3 == num)
				{
				}
				num = (short)1899560960;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.Editable;
			}
			set
			{
				short num = (short)1008926721;
				if (num != 0)
				{
				}
				num = (short)711393280;
				short num2 = num;
				num = (short)2068620630;
				short num3 = num;
				num = (short)782542166;
				switch (num3 == num)
				{
				}
				num = (short)671940608;
				if (num != 0)
				{
				}
				this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.Editable = value;
			}
		}

		// Token: 0x17005797 RID: 22423
		// (get) Token: 0x0600AE99 RID: 44697 RVA: 0x00A24BAC File Offset: 0x00A22DAC
		internal string DataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128_UILabel
		{
			get
			{
				short num = (short)630587393;
				if (num != 0)
				{
				}
				num = (short)1667039232;
				short num2 = num;
				num = (short)1624761169;
				short num3 = num;
				num = (short)1170269009;
				switch (num3 == num)
				{
				}
				num = (short)2081685504;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.UIName;
			}
		}

		// Token: 0x17005798 RID: 22424
		// (get) Token: 0x0600AE9A RID: 44698 RVA: 0x00A24C60 File Offset: 0x00A22E60
		// (set) Token: 0x0600AE9B RID: 44699 RVA: 0x00A24D14 File Offset: 0x00A22F14
		internal bool DataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128_HiddenStatic
		{
			get
			{
				short num = (short)1053350831;
				short num2 = num;
				num = (short)762174383;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2129133568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)245825536;
				if (num != 0)
				{
				}
				num = (short)1249443841;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.HiddenStatic;
			}
			set
			{
				short num = (short)1172392359;
				short num2 = num;
				num = (short)884427175;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2118778880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1811742721;
				if (num != 0)
				{
				}
				num = (short)705888256;
				if (num != 0)
				{
				}
				this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.HiddenStatic = value;
			}
		}

		// Token: 0x17005799 RID: 22425
		// (get) Token: 0x0600AE9C RID: 44700 RVA: 0x00A24DCC File Offset: 0x00A22FCC
		// (set) Token: 0x0600AE9D RID: 44701 RVA: 0x00A24E80 File Offset: 0x00A23080
		internal bool DataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128_HiddenDynamic
		{
			get
			{
				short num = (short)1216571643;
				short num2 = num;
				num = (short)1301833979;
				switch (num2 == num)
				{
				default:
				{
					num = (short)595263488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1368915969;
				if (num != 0)
				{
				}
				num = (short)24051712;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.HiddenDynamic;
			}
			set
			{
				short num = (short)1295441543;
				short num2 = num;
				num = (short)1367793287;
				switch (num2 == num)
				{
				default:
				{
					num = (short)167116800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)216662016;
				if (num != 0)
				{
				}
				num = (short)2077753345;
				if (num != 0)
				{
				}
				this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.HiddenDynamic = value;
			}
		}

		// Token: 0x1700579A RID: 22426
		// (get) Token: 0x0600AE9E RID: 44702 RVA: 0x00A24F38 File Offset: 0x00A23138
		public bool DataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128_HasDiffs
		{
			get
			{
				short num = (short)1664077420;
				short num2 = num;
				num = (short)1983041132;
				switch (num2 == num)
				{
				default:
				{
					num = (short)546045952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)365232129;
				if (num != 0)
				{
				}
				num = (short)1802502144;
				if (num != 0)
				{
				}
				return this.dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128._HasDiffs;
			}
		}

		// Token: 0x1700579B RID: 22427
		// (get) Token: 0x0600AE9F RID: 44703 RVA: 0x00A24FEC File Offset: 0x00A231EC
		// (set) Token: 0x0600AEA0 RID: 44704 RVA: 0x00A250A0 File Offset: 0x00A232A0
		public bool DataProfGeneralAutoGenerateTargetIPAddress_A41697Value
		{
			get
			{
				short num = (short)1393664363;
				short num2 = num;
				num = (short)580231531;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1463549952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)452395009;
				if (num != 0)
				{
				}
				num = (short)376045568;
				if (num != 0)
				{
				}
				return this.dataProfGeneralAutoGenerateTargetIPAddress_A41697.Value;
			}
			set
			{
				short num = (short)1693649273;
				short num2 = num;
				num = (short)3541369;
				switch (num2 == num)
				{
				default:
				{
					num = (short)511377408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)457441281;
				if (num != 0)
				{
				}
				num = (short)288358400;
				if (num != 0)
				{
				}
				this.dataProfGeneralAutoGenerateTargetIPAddress_A41697.Value = value;
			}
		}

		// Token: 0x1700579C RID: 22428
		// (get) Token: 0x0600AEA1 RID: 44705 RVA: 0x00A25158 File Offset: 0x00A23358
		public global::AcpBusinessLayer.AcpFieldX<bool, bool> DataProfGeneralAutoGenerateTargetIPAddress_A41697
		{
			get
			{
				short num = (short)1013156316;
				short num2 = num;
				num = (short)1178241500;
				switch (num2 == num)
				{
				default:
				{
					num = (short)824573952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)326893569;
				if (num != 0)
				{
				}
				num = (short)1588789248;
				if (num != 0)
				{
				}
				return this.dataProfGeneralAutoGenerateTargetIPAddress_A41697;
			}
		}

		// Token: 0x1700579D RID: 22429
		// (get) Token: 0x0600AEA2 RID: 44706 RVA: 0x00A25208 File Offset: 0x00A23408
		// (set) Token: 0x0600AEA3 RID: 44707 RVA: 0x00A252C0 File Offset: 0x00A234C0
		public bool DataProfGeneralAutoGenerateTargetIPAddress_A41697_UIValue
		{
			get
			{
				short num = (short)127535073;
				short num2 = num;
				num = (short)1356269537;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1705836544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)922419200;
				if (num != 0)
				{
				}
				num = (short)1148256257;
				if (num != 0)
				{
				}
				return this.dataProfGeneralAutoGenerateTargetIPAddress_A41697.UIValue;
			}
			set
			{
				short num = (short)857101626;
				short num2 = num;
				num = (short)1260279098;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1092485120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)979238912;
				if (num != 0)
				{
				}
				num = (short)434503681;
				if (num != 0)
				{
				}
				this.dataProfGeneralAutoGenerateTargetIPAddress_A41697.UIValue = value;
			}
		}

		// Token: 0x1700579E RID: 22430
		// (get) Token: 0x0600AEA4 RID: 44708 RVA: 0x00A25378 File Offset: 0x00A23578
		// (set) Token: 0x0600AEA5 RID: 44709 RVA: 0x00A25430 File Offset: 0x00A23630
		public bool DataProfGeneralAutoGenerateTargetIPAddress_A41697_Applicable
		{
			get
			{
				short num = (short)1400438869;
				short num2 = num;
				num = (short)873988181;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1764687872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)289144833;
				if (num != 0)
				{
				}
				num = (short)244645888;
				if (num != 0)
				{
				}
				return this.dataProfGeneralAutoGenerateTargetIPAddress_A41697.Applicable;
			}
			set
			{
				short num = (short)1737674642;
				short num2 = num;
				num = (short)2077675410;
				switch (num2 == num)
				{
				default:
				{
					num = (short)672464896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)722993152;
				if (num != 0)
				{
				}
				num = (short)1183449089;
				if (num != 0)
				{
				}
				this.dataProfGeneralAutoGenerateTargetIPAddress_A41697.Applicable = value;
			}
		}

		// Token: 0x1700579F RID: 22431
		// (get) Token: 0x0600AEA6 RID: 44710 RVA: 0x00A254E8 File Offset: 0x00A236E8
		// (set) Token: 0x0600AEA7 RID: 44711 RVA: 0x00A255A4 File Offset: 0x00A237A4
		public bool DataProfGeneralAutoGenerateTargetIPAddress_A41697_Valid
		{
			get
			{
				short num = (short)98296952;
				short num2 = num;
				num = (short)1539695736;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1127088128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1804861440;
				if (num != 0)
				{
				}
				num = (short)1971650561;
				if (num != 0)
				{
				}
				return this.dataProfGeneralAutoGenerateTargetIPAddress_A41697.Valid;
			}
			set
			{
				short num = (short)1449918465;
				if (num != 0)
				{
				}
				num = (short)386990080;
				short num2 = num;
				num = (short)804992288;
				short num3 = num;
				num = (short)1323513120;
				switch (num3 == num)
				{
				}
				num = (short)1703215104;
				if (num != 0)
				{
				}
				this.dataProfGeneralAutoGenerateTargetIPAddress_A41697.Valid = value;
			}
		}

		// Token: 0x170057A0 RID: 22432
		// (get) Token: 0x0600AEA8 RID: 44712 RVA: 0x00A25658 File Offset: 0x00A23858
		// (set) Token: 0x0600AEA9 RID: 44713 RVA: 0x00A2570C File Offset: 0x00A2390C
		public bool DataProfGeneralAutoGenerateTargetIPAddress_A41697_Visible
		{
			get
			{
				short num = (short)1899684212;
				short num2 = num;
				num = (short)1496637812;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1387790336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1216937985;
				if (num != 0)
				{
				}
				num = (short)621477888;
				if (num != 0)
				{
				}
				return this.dataProfGeneralAutoGenerateTargetIPAddress_A41697.Visible;
			}
			set
			{
				short num = (short)443401647;
				short num2 = num;
				num = (short)1890436527;
				switch (num2 == num)
				{
				default:
				{
					num = (short)823984128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)943063040;
				if (num != 0)
				{
				}
				num = (short)696975361;
				if (num != 0)
				{
				}
				this.dataProfGeneralAutoGenerateTargetIPAddress_A41697.Visible = value;
			}
		}

		// Token: 0x170057A1 RID: 22433
		// (get) Token: 0x0600AEAA RID: 44714 RVA: 0x00A257C0 File Offset: 0x00A239C0
		// (set) Token: 0x0600AEAB RID: 44715 RVA: 0x00A25874 File Offset: 0x00A23A74
		public bool DataProfGeneralAutoGenerateTargetIPAddress_A41697_Editable
		{
			get
			{
				short num = (short)1813450786;
				short num2 = num;
				num = (short)808194082;
				switch (num2 == num)
				{
				default:
				{
					num = (short)550371328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)104988673;
				if (num != 0)
				{
				}
				num = (short)1017511936;
				if (num != 0)
				{
				}
				return this.dataProfGeneralAutoGenerateTargetIPAddress_A41697.Editable;
			}
			set
			{
				short num = (short)1745551361;
				if (num != 0)
				{
				}
				num = (short)429981696;
				short num2 = num;
				num = (short)1200255940;
				short num3 = num;
				num = (short)1629123524;
				switch (num3 == num)
				{
				}
				num = (short)1521745920;
				if (num != 0)
				{
				}
				this.dataProfGeneralAutoGenerateTargetIPAddress_A41697.Editable = value;
			}
		}

		// Token: 0x170057A2 RID: 22434
		// (get) Token: 0x0600AEAC RID: 44716 RVA: 0x00A25928 File Offset: 0x00A23B28
		internal string DataProfGeneralAutoGenerateTargetIPAddress_A41697_UILabel
		{
			get
			{
				short num = (short)296084476;
				short num2 = num;
				num = (short)63431676;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2108096512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1972502529;
				if (num != 0)
				{
				}
				num = (short)1635385344;
				if (num != 0)
				{
				}
				return this.dataProfGeneralAutoGenerateTargetIPAddress_A41697.UIName;
			}
		}

		// Token: 0x170057A3 RID: 22435
		// (get) Token: 0x0600AEAD RID: 44717 RVA: 0x00A259D8 File Offset: 0x00A23BD8
		// (set) Token: 0x0600AEAE RID: 44718 RVA: 0x00A25A8C File Offset: 0x00A23C8C
		internal bool DataProfGeneralAutoGenerateTargetIPAddress_A41697_HiddenStatic
		{
			get
			{
				short num = (short)1007594428;
				short num2 = num;
				num = (short)83602364;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1744764928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1746010113;
				if (num != 0)
				{
				}
				num = (short)1522794496;
				if (num != 0)
				{
				}
				return this.dataProfGeneralAutoGenerateTargetIPAddress_A41697.HiddenStatic;
			}
			set
			{
				short num = (short)149454443;
				short num2 = num;
				num = (short)1933868651;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2042167296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1815937025;
				if (num != 0)
				{
				}
				num = (short)1014890496;
				if (num != 0)
				{
				}
				this.dataProfGeneralAutoGenerateTargetIPAddress_A41697.HiddenStatic = value;
			}
		}

		// Token: 0x170057A4 RID: 22436
		// (get) Token: 0x0600AEAF RID: 44719 RVA: 0x00A25B40 File Offset: 0x00A23D40
		// (set) Token: 0x0600AEB0 RID: 44720 RVA: 0x00A25BF4 File Offset: 0x00A23DF4
		internal bool DataProfGeneralAutoGenerateTargetIPAddress_A41697_HiddenDynamic
		{
			get
			{
				short num = (short)852612090;
				short num2 = num;
				num = (short)535483386;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1914109952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1754660865;
				if (num != 0)
				{
				}
				num = (short)180748288;
				if (num != 0)
				{
				}
				return this.dataProfGeneralAutoGenerateTargetIPAddress_A41697.HiddenDynamic;
			}
			set
			{
				short num = (short)1509330175;
				short num2 = num;
				num = (short)1602850047;
				switch (num2 == num)
				{
				default:
				{
					num = (short)235012096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)787087361;
				if (num != 0)
				{
				}
				num = (short)739377152;
				if (num != 0)
				{
				}
				this.dataProfGeneralAutoGenerateTargetIPAddress_A41697.HiddenDynamic = value;
			}
		}

		// Token: 0x170057A5 RID: 22437
		// (get) Token: 0x0600AEB1 RID: 44721 RVA: 0x00A25CA8 File Offset: 0x00A23EA8
		public bool DataProfGeneralAutoGenerateTargetIPAddress_A41697_HasDiffs
		{
			get
			{
				short num = (short)268632065;
				if (num != 0)
				{
				}
				num = (short)845086720;
				short num2 = num;
				num = (short)485865257;
				short num3 = num;
				num = (short)1434564393;
				switch (num3 == num)
				{
				}
				num = (short)407568384;
				if (num != 0)
				{
				}
				return this.dataProfGeneralAutoGenerateTargetIPAddress_A41697._HasDiffs;
			}
		}

		// Token: 0x170057A6 RID: 22438
		// (get) Token: 0x0600AEB2 RID: 44722 RVA: 0x00A25D5C File Offset: 0x00A23F5C
		// (set) Token: 0x0600AEB3 RID: 44723 RVA: 0x00A25E10 File Offset: 0x00A24010
		public bool DataConfigDataProfIntersystemData_A42381Value
		{
			get
			{
				short num = (short)1361510401;
				if (num != 0)
				{
				}
				num = (short)900857856;
				short num2 = num;
				num = (short)354883017;
				short num3 = num;
				num = (short)1919817161;
				switch (num3 == num)
				{
				}
				num = (short)1852571648;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfIntersystemData_A42381.Value;
			}
			set
			{
				short num = (short)1520837260;
				short num2 = num;
				num = (short)1005134476;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1947598848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1895825409;
				if (num != 0)
				{
				}
				num = (short)1253900288;
				if (num != 0)
				{
				}
				this.dataConfigDataProfIntersystemData_A42381.Value = value;
			}
		}

		// Token: 0x170057A7 RID: 22439
		// (get) Token: 0x0600AEB4 RID: 44724 RVA: 0x00A25EC8 File Offset: 0x00A240C8
		public global::AcpBusinessLayer.AcpField<bool> DataConfigDataProfIntersystemData_A42381
		{
			get
			{
				short num = (short)1128115623;
				short num2 = num;
				num = (short)992259495;
				switch (num2 == num)
				{
				default:
				{
					num = (short)47054848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1913257984;
				if (num != 0)
				{
				}
				num = (short)2066612225;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfIntersystemData_A42381;
			}
		}

		// Token: 0x170057A8 RID: 22440
		// (get) Token: 0x0600AEB5 RID: 44725 RVA: 0x00A25F78 File Offset: 0x00A24178
		// (set) Token: 0x0600AEB6 RID: 44726 RVA: 0x00A2602C File Offset: 0x00A2422C
		public bool DataConfigDataProfIntersystemData_A42381_UIValue
		{
			get
			{
				short num = (short)723453094;
				short num2 = num;
				num = (short)1414792358;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1262878720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)824508417;
				if (num != 0)
				{
				}
				num = (short)643891200;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfIntersystemData_A42381.Value;
			}
			set
			{
				short num = (short)1041537525;
				short num2 = num;
				num = (short)1996200437;
				switch (num2 == num)
				{
				default:
				{
					num = (short)882049024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)225509377;
				if (num != 0)
				{
				}
				num = (short)1851457536;
				if (num != 0)
				{
				}
				this.dataConfigDataProfIntersystemData_A42381.Value = value;
			}
		}

		// Token: 0x170057A9 RID: 22441
		// (get) Token: 0x0600AEB7 RID: 44727 RVA: 0x00A260E0 File Offset: 0x00A242E0
		// (set) Token: 0x0600AEB8 RID: 44728 RVA: 0x00A26198 File Offset: 0x00A24398
		public bool DataConfigDataProfIntersystemData_A42381_Applicable
		{
			get
			{
				short num = (short)262058025;
				short num2 = num;
				num = (short)371961897;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1184235520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)634388481;
				if (num != 0)
				{
				}
				num = (short)1397555200;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfIntersystemData_A42381.Applicable;
			}
			set
			{
				short num = (short)926054405;
				short num2 = num;
				num = (short)576681989;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1733165056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1802305537;
				if (num != 0)
				{
				}
				num = (short)1691353088;
				if (num != 0)
				{
				}
				this.dataConfigDataProfIntersystemData_A42381.Applicable = value;
			}
		}

		// Token: 0x170057AA RID: 22442
		// (get) Token: 0x0600AEB9 RID: 44729 RVA: 0x00A2624C File Offset: 0x00A2444C
		// (set) Token: 0x0600AEBA RID: 44730 RVA: 0x00A26300 File Offset: 0x00A24500
		public bool DataConfigDataProfIntersystemData_A42381_Valid
		{
			get
			{
				short num = (short)1277139855;
				short num2 = num;
				num = (short)1458543503;
				switch (num2 == num)
				{
				default:
				{
					num = (short)415629312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1684406273;
				if (num != 0)
				{
				}
				num = (short)291700736;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfIntersystemData_A42381.Valid;
			}
			set
			{
				short num = (short)1186529281;
				if (num != 0)
				{
				}
				num = (short)471793664;
				short num2 = num;
				num = (short)1312589308;
				short num3 = num;
				num = (short)1972864508;
				switch (num3 == num)
				{
				}
				num = (short)1540947968;
				if (num != 0)
				{
				}
				this.dataConfigDataProfIntersystemData_A42381.Valid = value;
			}
		}

		// Token: 0x170057AB RID: 22443
		// (get) Token: 0x0600AEBB RID: 44731 RVA: 0x00A263B4 File Offset: 0x00A245B4
		// (set) Token: 0x0600AEBC RID: 44732 RVA: 0x00A26468 File Offset: 0x00A24668
		public bool DataConfigDataProfIntersystemData_A42381_Visible
		{
			get
			{
				short num = (short)1718238603;
				short num2 = num;
				num = (short)1876573579;
				switch (num2 == num)
				{
				default:
				{
					num = (short)18284544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1240268801;
				if (num != 0)
				{
				}
				num = (short)1446379520;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfIntersystemData_A42381.Visible;
			}
			set
			{
				short num = (short)858190007;
				short num2 = num;
				num = (short)1578365111;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1296302080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1197670401;
				if (num != 0)
				{
				}
				num = (short)775487488;
				if (num != 0)
				{
				}
				this.dataConfigDataProfIntersystemData_A42381.Visible = value;
			}
		}

		// Token: 0x170057AC RID: 22444
		// (get) Token: 0x0600AEBD RID: 44733 RVA: 0x00A2651C File Offset: 0x00A2471C
		// (set) Token: 0x0600AEBE RID: 44734 RVA: 0x00A265D0 File Offset: 0x00A247D0
		public bool DataConfigDataProfIntersystemData_A42381_Editable
		{
			get
			{
				short num = (short)1198653441;
				if (num != 0)
				{
				}
				num = (short)1848573952;
				short num2 = num;
				num = (short)2042787940;
				short num3 = num;
				num = (short)593983588;
				switch (num3 == num)
				{
				}
				num = (short)1954021376;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfIntersystemData_A42381.Editable;
			}
			set
			{
				short num = (short)2080446359;
				short num2 = num;
				num = (short)1753159575;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1417478144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1332936704;
				if (num != 0)
				{
				}
				num = (short)1905459201;
				if (num != 0)
				{
				}
				this.dataConfigDataProfIntersystemData_A42381.Editable = value;
			}
		}

		// Token: 0x170057AD RID: 22445
		// (get) Token: 0x0600AEBF RID: 44735 RVA: 0x00A26684 File Offset: 0x00A24884
		internal string DataConfigDataProfIntersystemData_A42381_UILabel
		{
			get
			{
				short num = (short)1505326395;
				short num2 = num;
				num = (short)953840955;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1650720768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1891106817;
				if (num != 0)
				{
				}
				num = (short)591003648;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfIntersystemData_A42381.UIName;
			}
		}

		// Token: 0x170057AE RID: 22446
		// (get) Token: 0x0600AEC0 RID: 44736 RVA: 0x00A26738 File Offset: 0x00A24938
		// (set) Token: 0x0600AEC1 RID: 44737 RVA: 0x00A267F0 File Offset: 0x00A249F0
		internal bool DataConfigDataProfIntersystemData_A42381_HiddenStatic
		{
			get
			{
				short num = (short)1171532821;
				short num2 = num;
				num = (short)1531325461;
				switch (num2 == num)
				{
				default:
				{
					num = (short)67829760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1047724032;
				if (num != 0)
				{
				}
				num = (short)165347329;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfIntersystemData_A42381.HiddenStatic;
			}
			set
			{
				short num = (short)158134652;
				short num2 = num;
				num = (short)84734332;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1093468160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)480968705;
				if (num != 0)
				{
				}
				num = (short)1302790144;
				if (num != 0)
				{
				}
				this.dataConfigDataProfIntersystemData_A42381.HiddenStatic = value;
			}
		}

		// Token: 0x170057AF RID: 22447
		// (get) Token: 0x0600AEC2 RID: 44738 RVA: 0x00A268A4 File Offset: 0x00A24AA4
		// (set) Token: 0x0600AEC3 RID: 44739 RVA: 0x00A2695C File Offset: 0x00A24B5C
		internal bool DataConfigDataProfIntersystemData_A42381_HiddenDynamic
		{
			get
			{
				short num = (short)273828548;
				short num2 = num;
				num = (short)511593156;
				switch (num2 == num)
				{
				default:
				{
					num = (short)828899328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1760624641;
				if (num != 0)
				{
				}
				num = (short)913440768;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfIntersystemData_A42381.HiddenDynamic;
			}
			set
			{
				short num = (short)1894699278;
				short num2 = num;
				num = (short)1009176846;
				switch (num2 == num)
				{
				default:
				{
					num = (short)901447680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1047265280;
				if (num != 0)
				{
				}
				num = (short)120455169;
				if (num != 0)
				{
				}
				this.dataConfigDataProfIntersystemData_A42381.HiddenDynamic = value;
			}
		}

		// Token: 0x170057B0 RID: 22448
		// (get) Token: 0x0600AEC4 RID: 44740 RVA: 0x00A26A10 File Offset: 0x00A24C10
		public bool DataConfigDataProfIntersystemData_A42381_HasDiffs
		{
			get
			{
				short num = (short)2131000635;
				short num2 = num;
				num = (short)1459649851;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1232601088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1748893697;
				if (num != 0)
				{
				}
				num = (short)1972895744;
				if (num != 0)
				{
				}
				return this.dataConfigDataProfIntersystemData_A42381._HasDiffs;
			}
		}

		// Token: 0x170057B1 RID: 22449
		// (get) Token: 0x0600AEC5 RID: 44741 RVA: 0x00A26AC4 File Offset: 0x00A24CC4
		// (set) Token: 0x0600AEC6 RID: 44742 RVA: 0x00A26B7C File Offset: 0x00A24D7C
		public bool PriorityScanRxVoiceInterruptsData_A42590Value
		{
			get
			{
				short num = (short)1213535663;
				short num2 = num;
				num = (short)1696535983;
				switch (num2 == num)
				{
				default:
				{
					num = (short)907149312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)416153601;
				if (num != 0)
				{
				}
				num = (short)860749824;
				if (num != 0)
				{
				}
				return this.priorityScanRxVoiceInterruptsData_A42590.Value;
			}
			set
			{
				short num = (short)677194717;
				short num2 = num;
				num = (short)405679069;
				switch (num2 == num)
				{
				default:
				{
					num = (short)873398272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)740950016;
				if (num != 0)
				{
				}
				num = (short)1006632961;
				if (num != 0)
				{
				}
				this.priorityScanRxVoiceInterruptsData_A42590.Value = value;
			}
		}

		// Token: 0x170057B2 RID: 22450
		// (get) Token: 0x0600AEC7 RID: 44743 RVA: 0x00A26C34 File Offset: 0x00A24E34
		public global::AcpBusinessLayer.AcpField<bool> PriorityScanRxVoiceInterruptsData_A42590
		{
			get
			{
				short num = (short)1804730369;
				if (num != 0)
				{
				}
				num = (short)2040594432;
				short num2 = num;
				num = (short)1711803419;
				short num3 = num;
				num = (short)238685211;
				switch (num3 == num)
				{
				}
				num = (short)549191680;
				if (num != 0)
				{
				}
				return this.priorityScanRxVoiceInterruptsData_A42590;
			}
		}

		// Token: 0x170057B3 RID: 22451
		// (get) Token: 0x0600AEC8 RID: 44744 RVA: 0x00A26CE4 File Offset: 0x00A24EE4
		// (set) Token: 0x0600AEC9 RID: 44745 RVA: 0x00A26DA0 File Offset: 0x00A24FA0
		public bool PriorityScanRxVoiceInterruptsData_A42590_UIValue
		{
			get
			{
				short num = (short)2108030977;
				if (num != 0)
				{
				}
				num = (short)171442176;
				short num2 = num;
				num = (short)1009406207;
				short num3 = num;
				num = (short)15159551;
				switch (num3 == num)
				{
				}
				num = (short)2117140480;
				if (num != 0)
				{
				}
				return this.priorityScanRxVoiceInterruptsData_A42590.Value;
			}
			set
			{
				short num = (short)157138268;
				short num2 = num;
				num = (short)703905116;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1504182272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)593035265;
				if (num != 0)
				{
				}
				num = (short)1082523648;
				if (num != 0)
				{
				}
				this.priorityScanRxVoiceInterruptsData_A42590.Value = value;
			}
		}

		// Token: 0x170057B4 RID: 22452
		// (get) Token: 0x0600AECA RID: 44746 RVA: 0x00A26E54 File Offset: 0x00A25054
		// (set) Token: 0x0600AECB RID: 44747 RVA: 0x00A26F08 File Offset: 0x00A25108
		public bool PriorityScanRxVoiceInterruptsData_A42590_Applicable
		{
			get
			{
				short num = (short)941715720;
				short num2 = num;
				num = (short)1775661320;
				switch (num2 == num)
				{
				default:
				{
					num = (short)983236608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2124677121;
				if (num != 0)
				{
				}
				num = (short)787021824;
				if (num != 0)
				{
				}
				return this.priorityScanRxVoiceInterruptsData_A42590.Applicable;
			}
			set
			{
				short num = (short)1548190919;
				short num2 = num;
				num = (short)1773896903;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1135804416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)863567873;
				if (num != 0)
				{
				}
				num = (short)2128674816;
				if (num != 0)
				{
				}
				this.priorityScanRxVoiceInterruptsData_A42590.Applicable = value;
			}
		}

		// Token: 0x170057B5 RID: 22453
		// (get) Token: 0x0600AECC RID: 44748 RVA: 0x00A26FC0 File Offset: 0x00A251C0
		// (set) Token: 0x0600AECD RID: 44749 RVA: 0x00A27074 File Offset: 0x00A25274
		public bool PriorityScanRxVoiceInterruptsData_A42590_Valid
		{
			get
			{
				short num = (short)1067786360;
				short num2 = num;
				num = (short)1836720248;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2036203520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1127219201;
				if (num != 0)
				{
				}
				num = (short)1997602816;
				if (num != 0)
				{
				}
				return this.priorityScanRxVoiceInterruptsData_A42590.Valid;
			}
			set
			{
				short num = (short)1017225889;
				short num2 = num;
				num = (short)690004641;
				switch (num2 == num)
				{
				default:
				{
					num = (short)336527360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1758724097;
				if (num != 0)
				{
				}
				num = (short)213975040;
				if (num != 0)
				{
				}
				this.priorityScanRxVoiceInterruptsData_A42590.Valid = value;
			}
		}

		// Token: 0x170057B6 RID: 22454
		// (get) Token: 0x0600AECE RID: 44750 RVA: 0x00A2712C File Offset: 0x00A2532C
		// (set) Token: 0x0600AECF RID: 44751 RVA: 0x00A271E0 File Offset: 0x00A253E0
		public bool PriorityScanRxVoiceInterruptsData_A42590_Visible
		{
			get
			{
				short num = (short)2067806504;
				short num2 = num;
				num = (short)43268392;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1388380160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2016870400;
				if (num != 0)
				{
				}
				num = (short)851509249;
				if (num != 0)
				{
				}
				return this.priorityScanRxVoiceInterruptsData_A42590.Visible;
			}
			set
			{
				short num = (short)1663891866;
				short num2 = num;
				num = (short)1509882266;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1747648512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)944766976;
				if (num != 0)
				{
				}
				num = (short)1886846977;
				if (num != 0)
				{
				}
				this.priorityScanRxVoiceInterruptsData_A42590.Visible = value;
			}
		}

		// Token: 0x170057B7 RID: 22455
		// (get) Token: 0x0600AED0 RID: 44752 RVA: 0x00A27298 File Offset: 0x00A25498
		// (set) Token: 0x0600AED1 RID: 44753 RVA: 0x00A27350 File Offset: 0x00A25550
		public bool PriorityScanRxVoiceInterruptsData_A42590_Editable
		{
			get
			{
				short num = (short)841049318;
				short num2 = num;
				num = (short)519267558;
				switch (num2 == num)
				{
				default:
				{
					num = (short)912523264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1263992832;
				if (num != 0)
				{
				}
				num = (short)676462593;
				if (num != 0)
				{
				}
				return this.priorityScanRxVoiceInterruptsData_A42590.Editable;
			}
			set
			{
				short num = (short)1711540149;
				short num2 = num;
				num = (short)1064175541;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1258618880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)988610561;
				if (num != 0)
				{
				}
				num = (short)1337786368;
				if (num != 0)
				{
				}
				this.priorityScanRxVoiceInterruptsData_A42590.Editable = value;
			}
		}

		// Token: 0x170057B8 RID: 22456
		// (get) Token: 0x0600AED2 RID: 44754 RVA: 0x00A27404 File Offset: 0x00A25604
		internal string PriorityScanRxVoiceInterruptsData_A42590_UILabel
		{
			get
			{
				short num = (short)1308884993;
				if (num != 0)
				{
				}
				num = (short)270008320;
				short num2 = num;
				num = (short)770227367;
				short num3 = num;
				num = (short)1692056743;
				switch (num3 == num)
				{
				}
				num = (short)1101201408;
				if (num != 0)
				{
				}
				return this.priorityScanRxVoiceInterruptsData_A42590.UIName;
			}
		}

		// Token: 0x170057B9 RID: 22457
		// (get) Token: 0x0600AED3 RID: 44755 RVA: 0x00A274B8 File Offset: 0x00A256B8
		// (set) Token: 0x0600AED4 RID: 44756 RVA: 0x00A2756C File Offset: 0x00A2576C
		internal bool PriorityScanRxVoiceInterruptsData_A42590_HiddenStatic
		{
			get
			{
				short num = (short)1106293202;
				short num2 = num;
				num = (short)803713490;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1764360192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1777401857;
				if (num != 0)
				{
				}
				num = (short)1663959040;
				if (num != 0)
				{
				}
				return this.priorityScanRxVoiceInterruptsData_A42590.HiddenStatic;
			}
			set
			{
				short num = (short)2130430141;
				short num2 = num;
				num = (short)1042073789;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1007288320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)12713984;
				if (num != 0)
				{
				}
				num = (short)1676410881;
				if (num != 0)
				{
				}
				this.priorityScanRxVoiceInterruptsData_A42590.HiddenStatic = value;
			}
		}

		// Token: 0x170057BA RID: 22458
		// (get) Token: 0x0600AED5 RID: 44757 RVA: 0x00A27624 File Offset: 0x00A25824
		// (set) Token: 0x0600AED6 RID: 44758 RVA: 0x00A276D8 File Offset: 0x00A258D8
		internal bool PriorityScanRxVoiceInterruptsData_A42590_HiddenDynamic
		{
			get
			{
				short num = (short)1921297375;
				short num2 = num;
				num = (short)1572318175;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1016528896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1135673345;
				if (num != 0)
				{
				}
				num = (short)1692663808;
				if (num != 0)
				{
				}
				return this.priorityScanRxVoiceInterruptsData_A42590.HiddenDynamic;
			}
			set
			{
				short num = (short)421131203;
				short num2 = num;
				num = (short)1339683779;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1693384704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1282146304;
				if (num != 0)
				{
				}
				num = (short)1072168961;
				if (num != 0)
				{
				}
				this.priorityScanRxVoiceInterruptsData_A42590.HiddenDynamic = value;
			}
		}

		// Token: 0x170057BB RID: 22459
		// (get) Token: 0x0600AED7 RID: 44759 RVA: 0x00A2778C File Offset: 0x00A2598C
		public bool PriorityScanRxVoiceInterruptsData_A42590_HasDiffs
		{
			get
			{
				short num = (short)1814627538;
				short num2 = num;
				num = (short)489620690;
				switch (num2 == num)
				{
				default:
				{
					num = (short)769785856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)119078912;
				if (num != 0)
				{
				}
				num = (short)1129316353;
				if (num != 0)
				{
				}
				return this.priorityScanRxVoiceInterruptsData_A42590._HasDiffs;
			}
		}

		// Token: 0x170057BC RID: 22460
		// (get) Token: 0x0600AED8 RID: 44760 RVA: 0x00A27844 File Offset: 0x00A25A44
		public global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide RefDataWide
		{
			get
			{
				short num = (short)590807041;
				if (num != 0)
				{
				}
				num = (short)1743519744;
				short num2 = num;
				num = (short)640937959;
				short num3 = num;
				num = (short)2085744615;
				switch (num3 == num)
				{
				}
				num = (short)2012020736;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide;
			}
		}

		// Token: 0x170057BD RID: 22461
		// (get) Token: 0x0600AED9 RID: 44761 RVA: 0x00A27904 File Offset: 0x00A25B04
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1713919928;
				short num2 = num;
				num = (short)190732216;
				switch (num2 == num)
				{
				default:
				{
					num = (short)95551488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)519962625;
				if (num != 0)
				{
				}
				num = (short)677969920;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x0600AEDA RID: 44762 RVA: 0x00A279C0 File Offset: 0x00A25BC0
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
					num2 = (short)1865482242;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)1413537076;
					short num3 = num2;
					num2 = (short)929226036;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					case 1:
						goto IL_125;
					default:
					{
						num2 = (short)447086592;
						short num4 = num2;
						goto IL_125;
					}
					}
					IL_5B:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)26345475;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_125:
					num2 = (short)1079377921;
					if (num2 != 0)
					{
					}
					num2 = (short)877920256;
					if (num2 != 0)
					{
					}
					goto IL_5B;
				}
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)842334209;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					return result;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)1847066624;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1313800196;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040053C3 RID: 21443
		private global::AcpBusinessLayer.AcpSimpleRangeField dataProfGeneralDataScanPreambleLength_A7798;

		// Token: 0x040053C4 RID: 21444
		private global::AcpBusinessLayer.AcpField<bool> dataProfGeneralLimitedBroadcast_A8431;

		// Token: 0x040053C5 RID: 21445
		private global::AcpBusinessLayer.AcpIPAddressField dataProfGeneralMobileComputerIPAddress_A8523;

		// Token: 0x040053C6 RID: 21446
		private global::AcpBusinessLayer.AcpListField dataProfGeneralPacketDataMode_A8689;

		// Token: 0x040053C7 RID: 21447
		private global::AcpBusinessLayer.AcpField<bool> trkSysLabtoolRxVoiceInterruptsData_A9043;

		// Token: 0x040053C8 RID: 21448
		private global::AcpBusinessLayer.AcpIPAddressField dataProfGeneralSubscriberAirInterfaceIPAddress_A9220;

		// Token: 0x040053C9 RID: 21449
		private global::AcpBusinessLayer.AcpField<bool> dataProfGeneralAutoGenerateIPAddress_A19320;

		// Token: 0x040053CA RID: 21450
		private global::AcpBusinessLayer.AcpKeyField dataProfGeneralkeyofDataProfiles_A19446;

		// Token: 0x040053CB RID: 21451
		private global::AcpBusinessLayer.AcpIPAddressField dataProfGeneralSubscriberIPAddress_A21157;

		// Token: 0x040053CC RID: 21452
		private global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A21320;

		// Token: 0x040053CD RID: 21453
		private global::AcpBusinessLayer.AcpListField dataWideGeneralPeerIPAddressAssignmentType_A22263;

		// Token: 0x040053CE RID: 21454
		private global::AcpBusinessLayer.AcpField<bool> dataConfigDataProfIPHeaderCompressionEnable_A36190;

		// Token: 0x040053CF RID: 21455
		private global::AcpBusinessLayer.AcpListField dataConigurationDataProfilePacketDataRegistrationVersion_A36210;

		// Token: 0x040053D0 RID: 21456
		private global::AcpBusinessLayer.AcpSimpleRangeField dataConfigDataProfContextActivationHoldoffTime_A36551;

		// Token: 0x040053D1 RID: 21457
		private global::AcpBusinessLayer.AcpField<bool> dataConfigDataProfRandomHoldOffTime_A36552;

		// Token: 0x040053D2 RID: 21458
		private global::AcpBusinessLayer.AcpSimpleRangeField dataProfGeneralQueueDwellTimersec_A8806;

		// Token: 0x040053D3 RID: 21459
		private global::AcpBusinessLayer.AcpField<bool> dataWideGeneralNATEnable_A38866;

		// Token: 0x040053D4 RID: 21460
		private global::AcpBusinessLayer.AcpIPAddressField dataProfilesGeneralBTDUNSUIPAddress_A41126;

		// Token: 0x040053D5 RID: 21461
		private global::AcpBusinessLayer.AcpIPAddressField dataProfilesGeneralBTDUNPeerIPAddress_A41127;

		// Token: 0x040053D6 RID: 21462
		private global::AcpBusinessLayer.AcpListField dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128;

		// Token: 0x040053D7 RID: 21463
		private global::AcpBusinessLayer.AcpFieldX<bool, bool> dataProfGeneralAutoGenerateTargetIPAddress_A41697;

		// Token: 0x040053D8 RID: 21464
		private global::AcpBusinessLayer.AcpField<bool> dataConfigDataProfIntersystemData_A42381;

		// Token: 0x040053D9 RID: 21465
		private global::AcpBusinessLayer.AcpField<bool> priorityScanRxVoiceInterruptsData_A42590;
	}
}
