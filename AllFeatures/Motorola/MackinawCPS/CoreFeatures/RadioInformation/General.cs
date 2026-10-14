using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Features.Converters;

namespace Motorola.MackinawCPS.CoreFeatures.RadioInformation
{
	// Token: 0x020001AB RID: 427
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060046ED RID: 18157 RVA: 0x0041ABC0 File Offset: 0x00418DC0
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060046EE RID: 18158 RVA: 0x0041ABDC File Offset: 0x00418DDC
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060046EF RID: 18159 RVA: 0x0041ABF4 File Offset: 0x00418DF4
		public override void Init()
		{
			int a_ = 5;
			short num = (short)1491763763;
			short num2 = num;
			num = (short)1467253299;
			switch (num2 == num)
			{
			}
			num = (short)361431041;
			if (num != 0)
			{
			}
			num = (short)623378432;
			short num3 = num;
			num = (short)1916665856;
			if (num != 0)
			{
			}
			this.radInfoGeneralBootloaderVersion_A7567 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟ꃡ诣觥鳧蛩菫迭铯韱蛳ꃵ鷷裹迻韽濿氁嬃䜅㼇㼉㨋㤍", a_), global::CommonResources.AcgResources.ID_BOOTLOADERVERSION, 100);
			this.radInfoGeneralBootloaderVersion_A7567.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralBootloaderVersion_A7567.DataTransferOrder = -1;
			this.radInfoGeneralCodeplugVersion_A7683 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("냇﯉", a_), this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟ꇡ诣若跧髩胫鯭韯ꓱ釳蓵请鏹鏻都忿䌁㌃々〇㤉", a_), global::CommonResources.AcgResources.ID_CODEPLUGVERSION, 12);
			this.radInfoGeneralCodeplugVersion_A7683.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralCodeplugVersion_A7683.DataTransferOrder = -1;
			this.radInfoGeneralDSPVersion_A7892 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟ꛡ럣뛥뻧迩黫鷭駯鷱髳꧵맷췹쓻쟽㋿", a_), global::CommonResources.AcgResources.ID_DSPVERSION, 100);
			this.radInfoGeneralDSPVersion_A7892.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralDSPVersion_A7892.DataTransferOrder = -1;
			this.radInfoGeneralFirmwareVersion_A8124 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟ꓡ跣铥藧鷩跫鳭闯ꓱ釳蓵请鏹鏻都忿䌁㰃㜅㨇㸉", a_), global::CommonResources.AcgResources.ID_FIRMWAREVERSION, 100);
			this.radInfoGeneralFirmwareVersion_A8124.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralFirmwareVersion_A8124.DataTransferOrder = -1;
			this.radInfoGeneralModelNumber_A8539 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_H97TGD9PW1AN, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟꿡诣若跧蛩ꋫ鯭鷯郱釳蓵ꟷ믹쓻쯽㏿㬁", a_), global::CommonResources.AcgResources.ID_MODELNUMBER, 16);
			this.radInfoGeneralModelNumber_A8539.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralModelNumber_A8539.DataTransferOrder = -1;
			this.radInfoGeneralNautilusVersion_A8564 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟곡藣鏥鳧菩胫鯭華ꓱ釳蓵请鏹鏻都忿䌁㰃㌅㸇㸉", a_), global::CommonResources.AcgResources.ID_NAUTILUSVERSION, 100);
			this.radInfoGeneralNautilusVersion_A8564.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralNautilusVersion_A8564.DataTransferOrder = -1;
			this.radInfoGeneralPSDTVersion_A8768 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟닡럣ꋥ볧볩觫鳭華鯱鯳飵ꟷ믹쓻짽㛿㨁", a_), global::CommonResources.AcgResources.ID_PSDTVERSION, 100);
			this.radInfoGeneralPSDTVersion_A8768.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralPSDTVersion_A8768.DataTransferOrder = -1;
			this.radInfoGeneralSerialNumber_A9122 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_P_123ABC1234, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟뇡臣铥臧诩胫ꃭ藯鿱雳鏵諷ꗹ뷻쟽ㇿ、㘃", a_), global::CommonResources.AcgResources.ID_SERIALNUMBER, 10);
			this.radInfoGeneralSerialNumber_A9122.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralSerialNumber_A9122.DataTransferOrder = -1;
			this.radInfoGeneralTuningVersion_A9509 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟뛡釣裥臧蓩诫룭闯胱蟳鿵韷铹ꏻ뿽㧿㜁㐃㼅", a_), global::CommonResources.AcgResources.ID_TUNINGVERSION, 100);
			this.radInfoGeneralTuningVersion_A9509.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralTuningVersion_A9509.DataTransferOrder = -1;
			this.radInfoGeneralMaximumChannels_A11479 = new global::AcpBusinessLayer.AcpSimpleRangeField(96, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟꿡藣黥臧蟩駫菭돯髱闳飵雷鿹郻跽忿䌁㔃㜅㰇㴉㔋", a_), global::CommonResources.AcgResources.ID_MAXIMUMCHANNELS, 0, 2147483646, null, null, 0, 1);
			this.radInfoGeneralMaximumChannels_A11479.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralMaximumChannels_A11479.DataTransferOrder = -1;
			this.radInfoGeneralMaximumChannels_A11479.ShowHexValue = false;
			this.radInfoGeneralPrimaryFrequencyBand_A12713 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_P_700800MHZ, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟닡難迥藧诩黫韭뛯胱釳蟵跷鿹鋻鷽秿䀁攃栅氇唉䴋㼍∏┑┓┕", a_), global::CommonResources.AcgResources.ID_PRIMARYFREQUENCYBAND, 100);
			this.radInfoGeneralPrimaryFrequencyBand_A12713.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralPrimaryFrequencyBand_A12713.DataTransferOrder = -1;
			this.radInfoGeneralSecondaryFrequencyBand_A12715 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NONE, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟뇡臣藥蟧蓩裫迭苯诱닳蓵鷷诹觻鯽滿愁紃䐅椇搉栋儍儏⌑☓ℕ⤗⼙", a_), global::CommonResources.AcgResources.ID_SECONDARYFREQUENCYBAND, 100);
			this.radInfoGeneralSecondaryFrequencyBand_A12715.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralSecondaryFrequencyBand_A12715.DataTransferOrder = -1;
			this.radInfoGeneralRegionalGovernance_A36710 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.LOVs.indexRadInfoGeneralRegionalGovernance_A36710LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.LOVs.idRadInfoGeneralRegionalGovernance_A36710LovStrs), this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟냡臣臥臧藩苫迭鳯뗱鯳胵鷷裹鋻鿽滿愁愃夅䤇㤉㨋㤍ℏ∑", a_), global::CommonResources.AcgResources.ID_REGIONALGOVERNANCE, global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.LOVs.RadInfoGeneralRegionalGovernance_A36710LovStrs);
			this.radInfoGeneralRegionalGovernance_A36710.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralRegionalGovernance_A36710.DataTransferOrder = -1;
			this.radInfoGeneralWiFiRegulatoryRegion_A43772 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("", a_), new global::Features.Converters.PackUnpackAsciiRegion(), this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟뗡跣ꃥ臧룩觫觭藯黱闳苵韷裹藻곽旿攁洃椅昇唉䴋㨍⌏┑⌓␕", a_), global::CommonResources.AcgResources.ID_WIFIREGULATORYREGION);
			this.radInfoGeneralWiFiRegulatoryRegion_A43772.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralWiFiRegulatoryRegion_A43772.DataTransferOrder = -1;
			this.radInfoGeneralUCMVersion_A9591 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟럡꟣ꯥ뻧迩黫鷭駯鷱髳꧵맷쏹짻쟽ㇿ", a_), global::CommonResources.AcgResources.ID_SECUREVERSION, 100);
			this.radInfoGeneralUCMVersion_A9591.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralUCMVersion_A9591.DataTransferOrder = -1;
			this.radInfoGeneralCodeplugAlias_A7684 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟ꇡ诣若跧髩胫鯭韯돱飳鿵駷觹ꏻ뿽㟿㐁㰃㈅", a_), global::CommonResources.AcgResources.ID_CODEPLUGALIAS, 31);
			this.radInfoGeneralCodeplugAlias_A7684.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralCodeplugAlias_A7684.DataTransferOrder = 1;
			this.radInfoGeneralElectronicSerialNumber_A41744 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟꟡裣菥诧黩黫臭黯鯱音ꗵ鷷裹闻鿽泿䰁焃欅樇漉縋儍儏☑┓ℕⰗ⸙", a_), global::CommonResources.AcgResources.ID_ESNNUMBER, 100);
			this.radInfoGeneralElectronicSerialNumber_A41744.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radInfoGeneralElectronicSerialNumber_A41744.DataTransferOrder = -1;
			this.radInfoGeneralMACAddress_A41837 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("觇韛ﳋ﷍闏", a_), new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.MACAddressConverter(), this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟꿡ꗣꗥꧧ軩裫鳭闯臱蟳꧵맷컹췻웽㏿㔁", a_), global::CommonResources.AcgResources.ID_MACADDRESS);
			this.radInfoGeneralMACAddress_A41837.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radInfoGeneralMACAddress_A41837.DataTransferOrder = -1;
			this.radInfoGeneralSecureHardwareType = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟뇡臣藥鷧飩觫ꛭ釯胱郳臵駷裹駻꫽秿爁愃", a_), global::CommonResources.AcgResources.ID_SECUREHARDWARETYPE, 100);
			this.radInfoGeneralSecureHardwareType.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralSecureHardwareType.DataTransferOrder = -1;
			this.radInfoGeneralSecureHardwareVersion = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟뇡臣藥鷧飩觫ꛭ釯胱郳臵駷裹駻ꣽ旿瀁眃漅朇搉", a_), global::CommonResources.AcgResources.ID_SECUREHARDWAREVERSION, 100);
			this.radInfoGeneralSecureHardwareVersion.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralSecureHardwareVersion.DataTransferOrder = -1;
			this.radInfoGeneralInstalledTxmCertificate = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟ꯡ諣闥鳧诩胫苭闯雱ꃳ軵闷맹駻賽瓿欁戃漅欇欉砋欍", a_), global::CommonResources.AcgResources.ID_INSTALLEDTXMCERT, 256);
			this.radInfoGeneralInstalledTxmCertificate.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralInstalledTxmCertificate.DataTransferOrder = -1;
			this.radInfoGeneralWiFiMACAddress_42509 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("韛ﳋﻍ", a_), new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.WiFiMACAddressConverter(), this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟뗡跣ꃥ臧꟩귫귭뇯雱郳蓵鷷觹迻ꇽ㓿、㄃㘅ㄇ", a_), global::CommonResources.AcgResources.ID_WIFIMACADDRESS);
			this.radInfoGeneralWiFiMACAddress_42509.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radInfoGeneralWiFiMACAddress_42509.DataTransferOrder = -1;
			this.radInfoGeneralWiFiBTMACAddress_42510 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("韛ﳋﻍ", a_), new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.WiFiMACAddressConverter(), this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟뗡跣ꃥ臧꣩룫ꏭ뇯뇱뗳鋵鳷裹駻跽珿崁〃㐅㴇㬉㰋", a_), global::CommonResources.AcgResources.ID_BTADDRESS);
			this.radInfoGeneralWiFiBTMACAddress_42510.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radInfoGeneralWiFiBTMACAddress_42510.DataTransferOrder = -1;
			this.radInfoGeneralPrimaryFrequencyBand700_A42543 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟닡難迥藧诩黫韭뛯胱釳蟵跷鿹鋻鷽秿䀁攃栅氇㴉㰋㸍伏匑–␕ⴗ⸙⼛", a_), global::CommonResources.AcgResources.ID_P_700MHZENABLE);
			this.radInfoGeneralPrimaryFrequencyBand700_A42543.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralPrimaryFrequencyBand700_A42543.DataTransferOrder = -1;
			this.radInfoGeneralPrimaryFrequencyBand800_A42544 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟닡難迥藧诩黫韭뛯胱釳蟵跷鿹鋻鷽秿䀁攃栅氇㈉㰋㸍伏匑–␕ⴗ⸙⠛", a_), global::CommonResources.AcgResources.ID_P_800MHZENABLE);
			this.radInfoGeneralPrimaryFrequencyBand800_A42544.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralPrimaryFrequencyBand800_A42544.DataTransferOrder = -1;
			this.radInfoGeneralPrimaryFrequencyBandVHF_A42545 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟닡難迥藧诩黫韭뛯胱釳蟵跷鿹鋻鷽秿䀁攃栅氇尉䐋䠍伏匑–␕ⴗ⸙⤛", a_), global::CommonResources.AcgResources.ID_VHFENABLE);
			this.radInfoGeneralPrimaryFrequencyBandVHF_A42545.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralPrimaryFrequencyBandVHF_A42545.DataTransferOrder = -1;
			this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟닡難迥藧诩黫韭뛯胱釳蟵跷鿹鋻鷽秿䀁攃栅氇弉䐋䠍ℏ䴑唓∕⨗⼙⠛⠝", a_), global::CommonResources.AcgResources.ID_UHF1ENABLE);
			this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546.DataTransferOrder = -1;
			this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟닡難迥藧诩黫韭뛯胱釳蟵跷鿹鋻鷽秿䀁攃栅氇弉䐋䠍∏䴑唓∕⨗⼙⠛⤝", a_), global::CommonResources.AcgResources.ID_UHF2ENABLE);
			this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547.DataTransferOrder = -1;
			this.radInfoGeneralPrimaryFrequencyBand900_A42548 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟닡難迥藧诩黫韭뛯胱釳蟵跷鿹鋻鷽秿䀁攃栅氇㌉㰋㸍伏匑–␕ⴗ⸙␛", a_), global::CommonResources.AcgResources.ID_P_900MHZENABLE);
			this.radInfoGeneralPrimaryFrequencyBand900_A42548.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralPrimaryFrequencyBand900_A42548.DataTransferOrder = -1;
			this.radInfoGeneralDisplayCodeplugAlias_43580 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉藋ꃍ뛏뷑鏓돕뛗뿙껛뿝賟ꛡ跣闥飧蛩跫韭돯鷱郳鏵裷雹觻駽䇿渁洃朅笇唉㠋㴍┏⨑␓", a_), global::CommonResources.AcgResources.ID_DISPLAYCODEPLUGALIAS);
			this.radInfoGeneralDisplayCodeplugAlias_43580.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralDisplayCodeplugAlias_43580.DataTransferOrder = 2;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臅귇꓉꧋볍뇏뻑", a_);
			base.Id = 10108;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060046F0 RID: 18160 RVA: 0x0041B44C File Offset: 0x0041964C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 9;
			short num = (short)753401928;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_418;
				case 1:
					goto IL_632;
				case 2:
					this.radInfoGeneralModelNumber_A8539 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_H97TGD9PW1AN, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣ꯥ蟧軩觫苭뻯蟱駳铵鷷裹ꏻ뿽㣿㜁㜃㼅", a_), global::CommonResources.AcgResources.ID_MODELNUMBER, 16);
					this.radInfoGeneralModelNumber_A8539.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralModelNumber_A8539.DataTransferOrder = -1;
					num = (short)960495642;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣꿥蛧駩飫迭鳯黱釳鋵곷苹釻뷽旿瀁瀃漅渇按漋漍搏眑", a_)))
					{
						num = (short)1227554864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_161B;
				case 4:
					this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뛥髧菩臫迭苯诱닳蓵鷷诹觻鯽滿愁紃䐅椇搉栋嬍堏向☓䤕夗⸙⸛⬝ᐟᔡ", a_), global::CommonResources.AcgResources.ID_UHF2ENABLE);
					this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547.DataTransferOrder = -1;
					num = (short)1024458786;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뛥髧菩臫迭苯诱닳蓵鷷诹觻鯽滿愁紃䐅椇搉栋㘍‏∑䬓圕Ⱇ⠙⤛⨝ᐟ", a_)))
					{
						num = (short)40042554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1075;
				case 6:
					this.radInfoGeneralUCMVersion_A9591 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣돥ꯧ꟩뫫语苯臱鷳駵雷ꗹ뷻쟽㗿㬁㔃", a_), global::CommonResources.AcgResources.ID_SECUREVERSION, 100);
					this.radInfoGeneralUCMVersion_A9591.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralUCMVersion_A9591.DataTransferOrder = -1;
					num = (short)242286656;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_949;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뇥臧곩藫ꏭ뇯뇱뗳鋵鳷裹駻跽珿崁〃㐅㴇㨉㔋", a_)))
					{
						num = (short)32178176;
						short num3 = num;
						num = (short)949944386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_136E;
				case 9:
					this.radInfoGeneralPrimaryFrequencyBand700_A42543 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뛥髧菩臫迭苯诱닳蓵鷷诹觻鯽滿愁紃䐅椇搉栋㤍‏∑䬓圕Ⱇ⠙⤛⨝ጟ", a_), global::CommonResources.AcgResources.ID_P_700MHZENABLE);
					this.radInfoGeneralPrimaryFrequencyBand700_A42543.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralPrimaryFrequencyBand700_A42543.DataTransferOrder = -1;
					num = (short)489291783;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뛥髧菩臫迭苯诱닳蓵鷷诹觻鯽滿愁紃䐅椇搉栋㤍‏∑䬓圕Ⱇ⠙⤛⨝ጟ", a_)))
					{
						num = (short)1571880969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_949;
				case 11:
					goto IL_9F0;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣ꯥꧧꧩ귫諭铯胱釳藵请ꗹ뷻쫽ㇿ㨁㜃ㄅ", a_)))
					{
						num = (short)820838418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1505;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣ꋥ臧駩鳫苭釯诱럳駵鳷鿹賻鋽痿攁䔃樅愇欉缋儍␏ℑℓ⸕⠗", a_)))
					{
						num = (short)1803747377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1668;
				case 14:
					this.radInfoGeneralElectronicSerialNumber_A41744 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣ꏥ蓧迩迫髭苯鷱髳鿵鯷꧹駻賽槿持栃䠅紇有渋欍戏䴑唓∕⤗ⴙ⠛⨝", a_), global::CommonResources.AcgResources.ID_ESNNUMBER, 100);
					this.radInfoGeneralElectronicSerialNumber_A41744.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radInfoGeneralElectronicSerialNumber_A41744.DataTransferOrder = -1;
					num = (short)524746792;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_161B;
				case 16:
					this.radInfoGeneralBootloaderVersion_A7567 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣ꓥ蟧藩飫苭鿯鏱郳鏵諷곹駻賽珿欁欃栅圇䬉㬋㬍☏┑", a_), global::CommonResources.AcgResources.ID_BOOTLOADERVERSION, 100);
					this.radInfoGeneralBootloaderVersion_A7567.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralBootloaderVersion_A7567.DataTransferOrder = -1;
					num = (short)252837957;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣ꋥ믧뫩뫫语苯臱鷳駵雷ꗹ뷻짽㣿㬁㘃", a_)))
					{
						num = (short)757923894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_632;
				case 18:
					this.radInfoGeneralMACAddress_A41837 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("韛跋ﻍ釓폟", a_), new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.MACAddressConverter(), this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣ꯥꧧꧩ귫諭铯胱釳藵请ꗹ뷻쫽ㇿ㨁㜃ㄅ", a_), global::CommonResources.AcgResources.ID_MACADDRESS);
					this.radInfoGeneralMACAddress_A41837.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radInfoGeneralMACAddress_A41837.DataTransferOrder = -1;
					num = (short)1767178326;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					goto IL_C60;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣ꓥ蟧藩飫苭鿯鏱郳鏵諷곹駻賽珿欁欃栅圇䬉㬋㬍☏┑", a_)))
					{
						num = (short)726925328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1321;
				case 21:
					goto IL_A3E;
				case 22:
					this.radInfoGeneralSerialNumber_A9122 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_P_123ABC1234, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뗥跧飩藫迭鳯볱至鯵髷鿹軻ꇽ䇿㬁㔃㐅㨇", a_), global::CommonResources.AcgResources.ID_SERIALNUMBER, 10);
					this.radInfoGeneralSerialNumber_A9122.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralSerialNumber_A9122.DataTransferOrder = -1;
					num = (short)159252559;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뗥跧觩駫鳭闯뫱闳蓵鳷跹鷻賽旿吁愃琅笇按挋怍", a_)))
					{
						num = (short)1209860157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1554;
				case 24:
					this.radInfoGeneralWiFiRegulatoryRegion_A43772 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("韛ﳋ", a_), new global::Features.Converters.PackUnpackAsciiRegion(), this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뇥臧곩藫볭闯闱至髵駷軹鏻賽秿倁愃愅愇攉戋儍儏☑✓ℕ⼗⠙", a_), global::CommonResources.AcgResources.ID_WIFIREGULATORYREGION);
					this.radInfoGeneralWiFiRegulatoryRegion_A43772.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralWiFiRegulatoryRegion_A43772.DataTransferOrder = -1;
					num = (short)545980454;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					this.radInfoGeneralFirmwareVersion_A8124 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣ꃥ臧飩臫駭釯胱釳ꃵ鷷裹迻韽濿氁嬃䜅〇㬉㸋㨍", a_), global::CommonResources.AcgResources.ID_FIRMWAREVERSION, 100);
					this.radInfoGeneralFirmwareVersion_A8124.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralFirmwareVersion_A8124.DataTransferOrder = -1;
					num = (short)282787879;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					goto IL_8FD;
				case 27:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣ꯥ蟧軩觫苭뻯蟱駳铵鷷裹ꏻ뿽㣿㜁㜃㼅", a_)))
					{
						num = (short)1250099202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8FD;
				case 28:
					this.radInfoGeneralTuningVersion_A9509 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣닥鷧蓩藫胭韯ꓱ釳蓵请鏹鏻都忿䌁㴃㌅㠇㌉", a_), global::CommonResources.AcgResources.ID_TUNINGVERSION, 100);
					this.radInfoGeneralTuningVersion_A9509.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralTuningVersion_A9509.DataTransferOrder = -1;
					num = (short)1752170585;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					this.radInfoGeneralNautilusVersion_A8564 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣꣥觧鿩飫蟭鳯蟱蟳ꃵ鷷裹迻韽濿氁嬃䜅〇㼉㨋㨍", a_), global::CommonResources.AcgResources.ID_NAUTILUSVERSION, 100);
					this.radInfoGeneralNautilusVersion_A8564.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralNautilusVersion_A8564.DataTransferOrder = -1;
					num = (short)1078329365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					goto IL_1554;
				case 31:
					this.radInfoGeneralMaximumChannels_A11479 = new global::AcpBusinessLayer.AcpSimpleRangeField(96, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣ꯥ觧鋩藫菭藯鿱럳黵駷铹鋻鯽泿焁嬃䜅㤇㬉㠋㤍⤏", a_), global::CommonResources.AcgResources.ID_MAXIMUMCHANNELS, null, null, 0, 1);
					this.radInfoGeneralMaximumChannels_A11479.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralMaximumChannels_A11479.DataTransferOrder = -1;
					this.radInfoGeneralMaximumChannels_A11479.ShowHexValue = false;
					num = (short)1136001091;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					this.radInfoGeneralPrimaryFrequencyBand900_A42548 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뛥髧菩臫迭苯诱닳蓵鷷诹觻鯽滿愁紃䐅椇搉栋㜍‏∑䬓圕Ⱇ⠙⤛⨝᠟", a_), global::CommonResources.AcgResources.ID_P_900MHZENABLE);
					this.radInfoGeneralPrimaryFrequencyBand900_A42548.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralPrimaryFrequencyBand900_A42548.DataTransferOrder = -1;
					num = (short)850133082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣닥鷧蓩藫胭韯ꓱ釳蓵请鏹鏻都忿䌁㴃㌅㠇㌉", a_)))
					{
						num = (short)105971740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F74;
				case 34:
					goto IL_DC2;
				case 35:
					goto IL_757;
				case 36:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뛥髧菩臫迭苯诱닳蓵鷷诹觻鯽滿愁紃䐅椇搉栋嬍堏向┓䤕夗⸙⸛⬝ᐟᐡ", a_)))
					{
						num = (short)1636171857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3CB;
				case 37:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣ꗥ蟧軩觫黭鳯蟱鏳럵铷鏹鷻跽忿䌁㌃々〇㸉", a_)))
					{
						num = (short)1040515155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_418;
				case 38:
					goto IL_1408;
				case 39:
					goto IL_5E4;
				case 40:
					goto IL_122D;
				case 41:
					goto IL_1619;
				case 42:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뛥髧菩臫迭苯诱닳蓵鷷诹觻鯽滿愁紃䐅椇搉栋嬍堏向☓䤕夗⸙⸛⬝ᐟᔡ", a_)))
					{
						num = (short)833159172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DC2;
				case 43:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뛥믧껩룫룭闯胱蟳鿵韷铹ꏻ뿽㣿㔁㈃㸅", a_)))
					{
						num = (short)2052915293;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9F0;
				case 44:
					this.radInfoGeneralPrimaryFrequencyBandVHF_A42545 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뛥髧菩臫迭苯诱닳蓵鷷诹觻鯽滿愁紃䐅椇搉栋堍堏向䬓圕Ⱇ⠙⤛⨝ᔟ", a_), global::CommonResources.AcgResources.ID_VHFENABLE);
					this.radInfoGeneralPrimaryFrequencyBandVHF_A42545.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralPrimaryFrequencyBandVHF_A42545.DataTransferOrder = -1;
					num = (short)1092485211;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 45:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("룉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뇥臧곩藫볭闯闱至髵駷軹鏻賽秿倁愃愅愇攉戋儍儏☑✓ℕ⼗⠙", a_)))
					{
						num = (short)928120856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1408;
				case 46:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣듥跧跩藫臭黯鏱飳뇵韷賹駻賽滿持樃攅洇唉䴋㴍☏┑┓☕", a_)))
					{
						num = (short)2094792757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1279;
				case 47:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣돥ꯧ꟩뫫语苯臱鷳駵雷ꗹ뷻쟽㗿㬁㔃", a_)))
					{
						num = (short)811532294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13BB;
				case 48:
					this.radInfoGeneralInstalledTxmCertificate = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣꿥蛧駩飫迭鳯黱釳鋵곷苹釻뷽旿瀁瀃漅渇按漋漍搏眑", a_), global::CommonResources.AcgResources.ID_INSTALLEDTXMCERT, 256);
					this.radInfoGeneralInstalledTxmCertificate.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralInstalledTxmCertificate.DataTransferOrder = -1;
					num = (short)988282895;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 49:
					this.radInfoGeneralDisplayCodeplugAlias_43580 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣ꋥ臧駩鳫苭釯诱럳駵鳷鿹賻鋽痿攁䔃樅愇欉缋儍␏ℑℓ⸕⠗", a_), global::CommonResources.AcgResources.ID_DISPLAYCODEPLUGALIAS);
					this.radInfoGeneralDisplayCodeplugAlias_43580.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralDisplayCodeplugAlias_43580.DataTransferOrder = 2;
					num = (short)1613889577;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 50:
					this.radInfoGeneralSecureHardwareType = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뗥跧觩駫鳭闯뫱闳蓵鳷跹鷻賽旿嘁紃瘅洇", a_), global::CommonResources.AcgResources.ID_SECUREHARDWARETYPE, 100);
					this.radInfoGeneralSecureHardwareType.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralSecureHardwareType.DataTransferOrder = -1;
					num = (short)527827007;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 51:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뛥髧菩臫迭苯诱닳蓵鷷诹觻鯽滿愁紃䐅椇搉栋儍儏⌑☓ℕ⤗⤙", a_)))
					{
						num = (short)989462583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_55E;
				case 52:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣꣥觧鿩飫蟭鳯蟱蟳ꃵ鷷裹迻韽濿氁嬃䜅〇㼉㨋㨍", a_)))
					{
						num = (short)902168605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A3E;
				case 53:
					this.radInfoGeneralRegionalGovernance_A36710 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.LOVs.indexRadInfoGeneralRegionalGovernance_A36710LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.LOVs.idRadInfoGeneralRegionalGovernance_A36710LovStrs), this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣듥跧跩藫臭黯鏱飳뇵韷賹駻賽滿持樃攅洇唉䴋㴍☏┑┓☕", a_), global::CommonResources.AcgResources.ID_REGIONALGOVERNANCE, global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.LOVs.RadInfoGeneralRegionalGovernance_A36710LovStrs);
					this.radInfoGeneralRegionalGovernance_A36710.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralRegionalGovernance_A36710.DataTransferOrder = -1;
					num = (short)1495203896;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 54:
					this.radInfoGeneralDSPVersion_A7892 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣ꋥ믧뫩뫫语苯臱鷳駵雷ꗹ뷻짽㣿㬁㘃", a_), global::CommonResources.AcgResources.ID_DSPVERSION, 100);
					this.radInfoGeneralDSPVersion_A7892.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralDSPVersion_A7892.DataTransferOrder = -1;
					num = (short)2124873729;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 55:
					this.radInfoGeneralPrimaryFrequencyBand_A12713 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_P_700800MHZ, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뛥髧菩臫迭苯诱닳蓵鷷诹觻鯽滿愁紃䐅椇搉栋儍儏⌑☓ℕ⤗⤙", a_), global::CommonResources.AcgResources.ID_PRIMARYFREQUENCYBAND, 100);
					this.radInfoGeneralPrimaryFrequencyBand_A12713.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralPrimaryFrequencyBand_A12713.DataTransferOrder = -1;
					num = (short)1581711419;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 56:
				{
					num = (short)288584143;
					short num4 = num;
					num = (short)1129148879;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DDA;
					default:
						num = (short)135528448;
						if (num != 0)
						{
						}
						goto IL_1279;
					}
					break;
				}
				case 57:
					num = (short)1570177027;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 58:
					this.radInfoGeneralPrimaryFrequencyBand800_A42544 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뛥髧菩臫迭苯诱닳蓵鷷诹觻鯽滿愁紃䐅椇搉栋㘍‏∑䬓圕Ⱇ⠙⤛⨝ᐟ", a_), global::CommonResources.AcgResources.ID_P_800MHZENABLE);
					this.radInfoGeneralPrimaryFrequencyBand800_A42544.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralPrimaryFrequencyBand800_A42544.DataTransferOrder = -1;
					num = (short)2124021847;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 59:
					goto IL_55E;
				case 60:
					num = (short)31850564;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 61:
					this.radInfoGeneralSecureHardwareVersion = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뗥跧觩駫鳭闯뫱闳蓵鳷跹鷻賽旿吁愃琅笇按挋怍", a_), global::CommonResources.AcgResources.ID_SECUREHARDWAREVERSION, 100);
					this.radInfoGeneralSecureHardwareVersion.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralSecureHardwareVersion.DataTransferOrder = -1;
					num = (short)1560084510;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 62:
					goto IL_3CB;
				case 63:
					goto IL_37F;
				case 64:
					goto IL_13BB;
				case 65:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣ꗥ蟧軩觫黭鳯蟱鏳ꃵ鷷裹迻韽濿氁嬃䜅㼇㰉㐋㴍", a_)))
					{
						num = (short)503971917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_331;
				case 66:
					this.radInfoGeneralWiFiMACAddress_42509 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("韛ﳋﻍ탟", a_), new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.WiFiMACAddressConverter(), this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뇥臧곩藫ꏭ뇯뇱뗳鋵鳷裹駻跽珿崁〃㐅㴇㨉㔋", a_), global::CommonResources.AcgResources.ID_WIFIMACADDRESS);
					this.radInfoGeneralWiFiMACAddress_42509.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radInfoGeneralWiFiMACAddress_42509.DataTransferOrder = -1;
					num = (short)1405157449;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 67:
					goto IL_7FE;
				case 68:
					if (producerFields != null)
					{
						num = (short)1069350969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1668;
				case 69:
					goto IL_1321;
				case 70:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣ꏥ蓧迩迫髭苯鷱髳鿵鯷꧹駻賽槿持栃䠅紇有渋欍戏䴑唓∕⤗ⴙ⠛⨝", a_)))
					{
						num = (short)700710926;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_122D;
				case 71:
					goto IL_331;
				case 72:
					switch (0)
					{
					case 0:
						goto IL_1A6;
					}
					continue;
				case 73:
					goto IL_136E;
				case 74:
					num = (short)2104754177;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣ꃥ臧飩臫駭釯胱釳ꃵ鷷裹迻韽濿氁嬃䜅〇㬉㸋㨍", a_)))
					{
						num = (short)2061565977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5E4;
				case 75:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뗥跧觩駫鳭闯뫱闳蓵鳷跹鷻賽旿嘁紃瘅洇", a_)))
					{
						num = (short)890110002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37F;
				case 76:
					this.radInfoGeneralSecondaryFrequencyBand_A12715 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NONE, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뗥跧觩菫胭铯鏱蛳迵뻷裹駻追痿朁樃攅焇䠉洋怍琏䴑唓✕⨗ⴙⴛ⬝", a_), global::CommonResources.AcgResources.ID_SECONDARYFREQUENCYBAND, 100);
					this.radInfoGeneralSecondaryFrequencyBand_A12715.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralSecondaryFrequencyBand_A12715.DataTransferOrder = -1;
					num = (short)299565075;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 77:
					this.radInfoGeneralCodeplugVersion_A7683 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("韛듋ￍ", a_), this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣ꗥ蟧軩觫黭鳯蟱鏳ꃵ鷷裹迻韽濿氁嬃䜅㼇㰉㐋㴍", a_), global::CommonResources.AcgResources.ID_CODEPLUGVERSION, 12);
					this.radInfoGeneralCodeplugVersion_A7683.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralCodeplugVersion_A7683.DataTransferOrder = -1;
					num = (short)33882183;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 78:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뇥臧곩藫곭ꓯ뿱뗳뗵맷黹飻賽旿焁眃夅㰇㠉㤋㼍‏", a_)))
					{
						num = (short)1105264722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_757;
				case 79:
					goto IL_8B0;
				case 80:
					goto IL_DDA;
				case 81:
					this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뛥髧菩臫迭苯诱닳蓵鷷诹觻鯽滿愁紃䐅椇搉栋嬍堏向┓䤕夗⸙⸛⬝ᐟᐡ", a_), global::CommonResources.AcgResources.ID_UHF1ENABLE);
					this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546.DataTransferOrder = -1;
					num = (short)576913470;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 82:
					this.radInfoGeneralWiFiBTMACAddress_42510 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("韛ﳋﻍ탟", a_), new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.WiFiMACAddressConverter(), this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뇥臧곩藫곭ꓯ뿱뗳뗵맷黹飻賽旿焁眃夅㰇㠉㤋㼍‏", a_), global::CommonResources.AcgResources.ID_BTADDRESS);
					this.radInfoGeneralWiFiBTMACAddress_42510.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radInfoGeneralWiFiBTMACAddress_42510.DataTransferOrder = -1;
					num = (short)419495971;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 83:
					this.radInfoGeneralCodeplugAlias_A7684 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣ꗥ蟧軩觫黭鳯蟱鏳럵铷鏹鷻跽忿䌁㌃々〇㸉", a_), global::CommonResources.AcgResources.ID_CODEPLUGALIAS, 31);
					this.radInfoGeneralCodeplugAlias_A7684.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralCodeplugAlias_A7684.DataTransferOrder = 1;
					num = (short)26738688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 84:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뗥跧飩藫迭鳯볱至鯵髷鿹軻ꇽ䇿㬁㔃㐅㨇", a_)))
					{
						num = (short)2031157270;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8B0;
				case 85:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뛥髧菩臫迭苯诱닳蓵鷷诹觻鯽滿愁紃䐅椇搉栋堍堏向䬓圕Ⱇ⠙⤛⨝ᔟ", a_)))
					{
						num = (short)353828908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4C0;
				case 86:
					goto IL_1505;
				case 87:
					goto IL_1075;
				case 88:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣ꯥ觧鋩藫菭藯鿱럳黵駷铹鋻鯽泿焁嬃䜅㤇㬉㠋㤍⤏", a_)))
					{
						num = (short)868941855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7FE;
				case 89:
					goto IL_F74;
				case 90:
					goto IL_50E;
				case 91:
					goto IL_4C0;
				case 92:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뗥跧觩菫胭铯鏱蛳迵뻷裹駻追痿朁樃攅焇䠉洋怍琏䴑唓✕⨗ⴙⴛ⬝", a_)))
					{
						num = (short)1535705164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C60;
				case 93:
					this.radInfoGeneralPSDTVersion_A8768 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뛥믧껩룫룭闯胱蟳鿵韷铹ꏻ뿽㣿㔁㈃㸅", a_), global::CommonResources.AcgResources.ID_PSDTVERSION, 100);
					this.radInfoGeneralPSDTVersion_A8768.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralPSDTVersion_A8768.DataTransferOrder = -1;
					num = (short)1272578059;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1A6:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)841809980;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_331:
				num = (short)195559441;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_37F:
				num = (short)1211498519;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3CB:
				num = (short)606994474;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_418:
				num = (short)861208646;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4C0:
				num = (short)218759204;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_50E:
				num = (short)1734803469;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_DDA:
				if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕鿗뿙닛믝鋟菡裣뛥髧菩臫迭苯诱닳蓵鷷诹觻鯽滿愁紃䐅椇搉栋㜍‏∑䬓圕Ⱇ⠙⤛⨝᠟", a_)))
				{
					num = (short)1984626720;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_50E;
				IL_55E:
				num = (short)1646395484;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5E4:
				num = (short)652541979;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_632:
				num = (short)1876820042;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_757:
				num = (short)1548812298;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7FE:
				num = (short)408879155;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8B0:
				num = (short)1251672097;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8FD:
				num = (short)341770292;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_949:
				num = (short)1267728389;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9F0:
				num = (short)1668546644;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A3E:
				num = (short)1049886763;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C60:
				num = (short)1490485294;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_DC2:
				num = (short)211484752;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F74:
				num = (short)1341784152;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1075:
				num = (short)441974869;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_122D:
				num = (short)1935867916;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1279:
				num = (short)2017853485;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1321:
				num = (short)1673723969;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_136E:
				num = (short)849477710;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_13BB:
				num = (short)530776101;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1408:
				num = (short)327221295;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1505:
				num = (short)1420820555;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1554:
				num = (short)1059389448;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_161B:
				num = (short)1938423828;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1619:
			IL_1668:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("跉꧋ꃍ뗏ꃑ뗓뫕", a_);
			base.Id = 10108;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060046F1 RID: 18161 RVA: 0x0041CAF4 File Offset: 0x0041ACF4
		public override void PopulateReferences()
		{
			short num = (short)1291440096;
			short num2 = num;
			num = (short)1674235872;
			switch (num2 == num)
			{
			}
			num = (short)2112487424;
			if (num != 0)
			{
			}
			num = (short)501219328;
			short num3 = num;
			num = (short)768409601;
			if (num != 0)
			{
			}
		}

		// Token: 0x060046F2 RID: 18162 RVA: 0x0041CBA0 File Offset: 0x0041ADA0
		public override void DropReferences()
		{
			short num = (short)1536751407;
			short num2 = num;
			num = (short)1303967535;
			switch (num2 == num)
			{
			}
			num = (short)347013120;
			if (num != 0)
			{
			}
			num = (short)34406400;
			short num3 = num;
			num = (short)179765249;
			if (num != 0)
			{
			}
		}

		// Token: 0x060046F3 RID: 18163 RVA: 0x0041CC4C File Offset: 0x0041AE4C
		public override void SetConstraints()
		{
			short num = (short)2113032064;
			short num2 = num;
			num = (short)1111641984;
			switch (num2 == num)
			{
			}
			num = (short)1645543424;
			if (num != 0)
			{
			}
			num = (short)742260736;
			short num3 = num;
			num = (short)1315962881;
			if (num != 0)
			{
			}
			this.radInfoGeneralInstalledTxmCertificate.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoGeneralBootloaderVersion_A7567.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoGeneralCodeplugVersion_A7683.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoGeneralDSPVersion_A7892.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoGeneralFirmwareVersion_A8124.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoGeneralModelNumber_A8539.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoGeneralNautilusVersion_A8564.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoGeneralPSDTVersion_A8768.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoGeneralSerialNumber_A9122.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.RadInfoGeneralSerialNumber_A9122_Check);
			this.radInfoGeneralSerialNumber_A9122.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.conDepotEditable);
			this.radInfoGeneralTuningVersion_A9509.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoGeneralMaximumChannels_A11479.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoGeneralPrimaryFrequencyBand_A12713.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoGeneralSecondaryFrequencyBand_A12715.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoGeneralRegionalGovernance_A36710.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.conRegionalGovernanceValid);
			this.radInfoGeneralRegionalGovernance_A36710.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.conDepotEditable);
			this.radInfoGeneralUCMVersion_A9591.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoGeneralElectronicSerialNumber_A41744.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoGeneralMACAddress_A41837.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoGeneralSecureHardwareType.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoGeneralSecureHardwareVersion.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoGeneralWiFiMACAddress_42509.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoGeneralWiFiBTMACAddress_42510.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoGeneralPrimaryFrequencyBand700_A42543.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoGeneralPrimaryFrequencyBand800_A42544.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoGeneralPrimaryFrequencyBandVHF_A42545.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoGeneralPrimaryFrequencyBand900_A42548.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x060046F4 RID: 18164 RVA: 0x0041CF94 File Offset: 0x0041B194
		public override void SetupDependencies()
		{
			short num = (short)2076838622;
			short num2 = num;
			num = (short)2097744606;
			switch (num2 == num)
			{
			}
			num = (short)128188417;
			if (num != 0)
			{
			}
			num = (short)1332740096;
			short num3 = num;
			num = (short)1480196096;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700246B RID: 9323
		// (get) Token: 0x060046F5 RID: 18165 RVA: 0x0041D03C File Offset: 0x0041B23C
		public bool HasDiffs
		{
			get
			{
				short num = (short)238290778;
				short num2 = num;
				num = (short)697435994;
				switch (num2 == num)
				{
				}
				num = (short)1425473536;
				if (num != 0)
				{
				}
				num = (short)2140536832;
				short num3 = num;
				num = (short)268107777;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700246C RID: 9324
		// (get) Token: 0x060046F6 RID: 18166 RVA: 0x0041D0EC File Offset: 0x0041B2EC
		// (set) Token: 0x060046F7 RID: 18167 RVA: 0x0041D1A4 File Offset: 0x0041B3A4
		public string RadInfoGeneralInstalledTxmCertificateValue
		{
			get
			{
				short num = (short)2100990942;
				short num2 = num;
				num = (short)1625920478;
				switch (num2 == num)
				{
				}
				num = (short)1286144001;
				if (num != 0)
				{
				}
				num = (short)1983905792;
				short num3 = num;
				num = (short)1501888512;
				if (num != 0)
				{
				}
				return this.radInfoGeneralInstalledTxmCertificate.Value;
			}
			set
			{
				short num = (short)1698168833;
				if (num != 0)
				{
				}
				num = (short)1812233209;
				short num2 = num;
				num = (short)338787321;
				switch (num2 == num)
				{
				}
				num = (short)1873346560;
				short num3 = num;
				num = (short)267190272;
				if (num != 0)
				{
				}
				this.radInfoGeneralInstalledTxmCertificate.Value = value;
			}
		}

		// Token: 0x1700246D RID: 9325
		// (get) Token: 0x060046F8 RID: 18168 RVA: 0x0041D25C File Offset: 0x0041B45C
		public global::AcpBusinessLayer.AcpField<string> RadInfoGeneralInstalledTxmCertificate
		{
			get
			{
				short num = (short)218487951;
				short num2 = num;
				num = (short)2022366351;
				switch (num2 == num)
				{
				}
				num = (short)623247360;
				if (num != 0)
				{
				}
				num = (short)1220476928;
				short num3 = num;
				num = (short)405602305;
				if (num != 0)
				{
				}
				return this.radInfoGeneralInstalledTxmCertificate;
			}
		}

		// Token: 0x1700246E RID: 9326
		// (get) Token: 0x060046F9 RID: 18169 RVA: 0x0041D310 File Offset: 0x0041B510
		// (set) Token: 0x060046FA RID: 18170 RVA: 0x0041D3C4 File Offset: 0x0041B5C4
		public string RadInfoGeneralInstalledTxmCertificate_UIValue
		{
			get
			{
				short num = (short)304731361;
				short num2 = num;
				num = (short)2025116897;
				switch (num2 == num)
				{
				}
				num = (short)489422849;
				if (num != 0)
				{
				}
				num = (short)975634432;
				short num3 = num;
				num = (short)511770624;
				if (num != 0)
				{
				}
				return this.radInfoGeneralInstalledTxmCertificate.Value;
			}
			set
			{
				short num = (short)1500765853;
				short num2 = num;
				num = (short)518971037;
				switch (num2 == num)
				{
				}
				num = (short)868417536;
				if (num != 0)
				{
				}
				num = (short)475594752;
				short num3 = num;
				num = (short)1638137857;
				if (num != 0)
				{
				}
				this.radInfoGeneralInstalledTxmCertificate.Value = value;
			}
		}

		// Token: 0x1700246F RID: 9327
		// (get) Token: 0x060046FB RID: 18171 RVA: 0x0041D47C File Offset: 0x0041B67C
		// (set) Token: 0x060046FC RID: 18172 RVA: 0x0041D534 File Offset: 0x0041B734
		public bool RadInfoGeneralInstalledTxmCertificate_Applicable
		{
			get
			{
				short num = (short)280193537;
				short num2 = num;
				num = (short)139356673;
				switch (num2 == num)
				{
				}
				num = (short)261750784;
				if (num != 0)
				{
				}
				num = (short)1169555456;
				short num3 = num;
				num = (short)329383937;
				if (num != 0)
				{
				}
				return this.radInfoGeneralInstalledTxmCertificate.Applicable;
			}
			set
			{
				short num = (short)1386205568;
				short num2 = num;
				num = (short)1873858944;
				switch (num2 == num)
				{
				}
				num = (short)1173618688;
				if (num != 0)
				{
				}
				num = (short)342032384;
				short num3 = num;
				num = (short)1783562241;
				if (num != 0)
				{
				}
				this.radInfoGeneralInstalledTxmCertificate.Applicable = value;
			}
		}

		// Token: 0x17002470 RID: 9328
		// (get) Token: 0x060046FD RID: 18173 RVA: 0x0041D5E4 File Offset: 0x0041B7E4
		// (set) Token: 0x060046FE RID: 18174 RVA: 0x0041D69C File Offset: 0x0041B89C
		public bool RadInfoGeneralInstalledTxmCertificate_Valid
		{
			get
			{
				short num = (short)740017825;
				short num2 = num;
				num = (short)1148634785;
				switch (num2 == num)
				{
				}
				num = (short)1074331649;
				if (num != 0)
				{
				}
				num = (short)687013888;
				short num3 = num;
				num = (short)1313734656;
				if (num != 0)
				{
				}
				return this.radInfoGeneralInstalledTxmCertificate.Valid;
			}
			set
			{
				short num = (short)1365747556;
				short num2 = num;
				num = (short)1724163940;
				switch (num2 == num)
				{
				}
				num = (short)1477574656;
				if (num != 0)
				{
				}
				num = (short)943718400;
				short num3 = num;
				num = (short)2013593601;
				if (num != 0)
				{
				}
				this.radInfoGeneralInstalledTxmCertificate.Valid = value;
			}
		}

		// Token: 0x17002471 RID: 9329
		// (get) Token: 0x060046FF RID: 18175 RVA: 0x0041D750 File Offset: 0x0041B950
		// (set) Token: 0x06004700 RID: 18176 RVA: 0x0041D804 File Offset: 0x0041BA04
		public bool RadInfoGeneralInstalledTxmCertificate_Visible
		{
			get
			{
				short num = (short)1708261377;
				if (num != 0)
				{
				}
				num = (short)1969365359;
				short num2 = num;
				num = (short)950870383;
				switch (num2 == num)
				{
				}
				num = (short)1793130496;
				short num3 = num;
				num = (short)815464448;
				if (num != 0)
				{
				}
				return this.radInfoGeneralInstalledTxmCertificate.Visible;
			}
			set
			{
				short num = (short)877517556;
				short num2 = num;
				num = (short)1207098100;
				switch (num2 == num)
				{
				}
				num = (short)891944961;
				if (num != 0)
				{
				}
				num = (short)1186529280;
				short num3 = num;
				num = (short)892665856;
				if (num != 0)
				{
				}
				this.radInfoGeneralInstalledTxmCertificate.Visible = value;
			}
		}

		// Token: 0x17002472 RID: 9330
		// (get) Token: 0x06004701 RID: 18177 RVA: 0x0041D8BC File Offset: 0x0041BABC
		// (set) Token: 0x06004702 RID: 18178 RVA: 0x0041D970 File Offset: 0x0041BB70
		public bool RadInfoGeneralInstalledTxmCertificate_Editable
		{
			get
			{
				short num = (short)843630930;
				short num2 = num;
				num = (short)316393810;
				switch (num2 == num)
				{
				}
				num = (short)1687420928;
				if (num != 0)
				{
				}
				num = (short)1951137792;
				short num3 = num;
				num = (short)2147024897;
				if (num != 0)
				{
				}
				return this.radInfoGeneralInstalledTxmCertificate.Editable;
			}
			set
			{
				short num = (short)1558784386;
				short num2 = num;
				num = (short)769730946;
				switch (num2 == num)
				{
				}
				num = (short)1904541697;
				if (num != 0)
				{
				}
				num = (short)1060175872;
				short num3 = num;
				num = (short)1702821888;
				if (num != 0)
				{
				}
				this.radInfoGeneralInstalledTxmCertificate.Editable = value;
			}
		}

		// Token: 0x17002473 RID: 9331
		// (get) Token: 0x06004703 RID: 18179 RVA: 0x0041DA24 File Offset: 0x0041BC24
		internal string RadInfoGeneralInstalledTxmCertificate_UILabel
		{
			get
			{
				short num = (short)710017025;
				if (num != 0)
				{
				}
				num = (short)2080229337;
				short num2 = num;
				num = (short)661374937;
				switch (num2 == num)
				{
				}
				num = (short)1401552896;
				short num3 = num;
				num = (short)234291200;
				if (num != 0)
				{
				}
				return this.radInfoGeneralInstalledTxmCertificate.UIName;
			}
		}

		// Token: 0x17002474 RID: 9332
		// (get) Token: 0x06004704 RID: 18180 RVA: 0x0041DAD8 File Offset: 0x0041BCD8
		// (set) Token: 0x06004705 RID: 18181 RVA: 0x0041DB8C File Offset: 0x0041BD8C
		internal bool RadInfoGeneralInstalledTxmCertificate_HiddenStatic
		{
			get
			{
				short num = (short)2068844294;
				short num2 = num;
				num = (short)716705542;
				switch (num2 == num)
				{
				}
				num = (short)29818881;
				if (num != 0)
				{
				}
				num = (short)1763180544;
				short num3 = num;
				num = (short)174129152;
				if (num != 0)
				{
				}
				return this.radInfoGeneralInstalledTxmCertificate.HiddenStatic;
			}
			set
			{
				short num = (short)1141257886;
				short num2 = num;
				num = (short)765867678;
				switch (num2 == num)
				{
				}
				num = (short)1052704769;
				if (num != 0)
				{
				}
				num = (short)145686528;
				short num3 = num;
				num = (short)1769209856;
				if (num != 0)
				{
				}
				this.radInfoGeneralInstalledTxmCertificate.HiddenStatic = value;
			}
		}

		// Token: 0x17002475 RID: 9333
		// (get) Token: 0x06004706 RID: 18182 RVA: 0x0041DC40 File Offset: 0x0041BE40
		// (set) Token: 0x06004707 RID: 18183 RVA: 0x0041DCF4 File Offset: 0x0041BEF4
		internal bool RadInfoGeneralInstalledTxmCertificate_HiddenDynamic
		{
			get
			{
				short num = (short)869904254;
				short num2 = num;
				num = (short)1460711294;
				switch (num2 == num)
				{
				}
				num = (short)1404108800;
				if (num != 0)
				{
				}
				num = (short)1177157632;
				short num3 = num;
				num = (short)833945601;
				if (num != 0)
				{
				}
				return this.radInfoGeneralInstalledTxmCertificate.HiddenDynamic;
			}
			set
			{
				short num = (short)201285074;
				short num2 = num;
				num = (short)1886674386;
				switch (num2 == num)
				{
				}
				num = (short)579272705;
				if (num != 0)
				{
				}
				num = (short)1782251520;
				short num3 = num;
				num = (short)251002880;
				if (num != 0)
				{
				}
				this.radInfoGeneralInstalledTxmCertificate.HiddenDynamic = value;
			}
		}

		// Token: 0x17002476 RID: 9334
		// (get) Token: 0x06004708 RID: 18184 RVA: 0x0041DDAC File Offset: 0x0041BFAC
		public bool RadInfoGeneralInstalledTxmCertificate_HasDiffs
		{
			get
			{
				short num = (short)831258625;
				if (num != 0)
				{
				}
				num = (short)1472648510;
				short num2 = num;
				num = (short)981194046;
				switch (num2 == num)
				{
				}
				num = (short)1089273856;
				short num3 = num;
				num = (short)2122514432;
				if (num != 0)
				{
				}
				return this.radInfoGeneralInstalledTxmCertificate._HasDiffs;
			}
		}

		// Token: 0x17002477 RID: 9335
		// (get) Token: 0x06004709 RID: 18185 RVA: 0x0041DE64 File Offset: 0x0041C064
		// (set) Token: 0x0600470A RID: 18186 RVA: 0x0041DF18 File Offset: 0x0041C118
		public string RadInfoGeneralBootloaderVersion_A7567Value
		{
			get
			{
				short num = (short)1592429587;
				short num2 = num;
				num = (short)152341523;
				switch (num2 == num)
				{
				}
				num = (short)1475084289;
				if (num != 0)
				{
				}
				num = (short)736952320;
				short num3 = num;
				num = (short)1604583424;
				if (num != 0)
				{
				}
				return this.radInfoGeneralBootloaderVersion_A7567.Value;
			}
			set
			{
				short num = (short)425388325;
				short num2 = num;
				num = (short)485484837;
				switch (num2 == num)
				{
				}
				num = (short)1352663040;
				if (num != 0)
				{
				}
				num = (short)616824832;
				short num3 = num;
				num = (short)1765539841;
				if (num != 0)
				{
				}
				this.radInfoGeneralBootloaderVersion_A7567.Value = value;
			}
		}

		// Token: 0x17002478 RID: 9336
		// (get) Token: 0x0600470B RID: 18187 RVA: 0x0041DFCC File Offset: 0x0041C1CC
		public global::AcpBusinessLayer.AcpField<string> RadInfoGeneralBootloaderVersion_A7567
		{
			get
			{
				short num = (short)1075901744;
				short num2 = num;
				num = (short)882505008;
				switch (num2 == num)
				{
				}
				num = (short)1241645057;
				if (num != 0)
				{
				}
				num = (short)506462208;
				if (num != 0)
				{
				}
				num = (short)1725628416;
				short num3 = num;
				return this.radInfoGeneralBootloaderVersion_A7567;
			}
		}

		// Token: 0x17002479 RID: 9337
		// (get) Token: 0x0600470C RID: 18188 RVA: 0x0041E080 File Offset: 0x0041C280
		// (set) Token: 0x0600470D RID: 18189 RVA: 0x0041E138 File Offset: 0x0041C338
		public string RadInfoGeneralBootloaderVersion_A7567_UIValue
		{
			get
			{
				short num = (short)656253726;
				short num2 = num;
				num = (short)1409917726;
				switch (num2 == num)
				{
				}
				num = (short)21954561;
				if (num != 0)
				{
				}
				num = (short)1967456256;
				if (num != 0)
				{
				}
				num = (short)1555234816;
				short num3 = num;
				return this.radInfoGeneralBootloaderVersion_A7567.Value;
			}
			set
			{
				short num = (short)548986488;
				short num2 = num;
				num = (short)582803064;
				switch (num2 == num)
				{
				}
				num = (short)385089537;
				if (num != 0)
				{
				}
				num = (short)1824980992;
				if (num != 0)
				{
				}
				num = (short)1433731072;
				short num3 = num;
				this.radInfoGeneralBootloaderVersion_A7567.Value = value;
			}
		}

		// Token: 0x1700247A RID: 9338
		// (get) Token: 0x0600470E RID: 18190 RVA: 0x0041E1F0 File Offset: 0x0041C3F0
		// (set) Token: 0x0600470F RID: 18191 RVA: 0x0041E2A4 File Offset: 0x0041C4A4
		public bool RadInfoGeneralBootloaderVersion_A7567_Applicable
		{
			get
			{
				short num = (short)1904133530;
				short num2 = num;
				num = (short)2111227290;
				switch (num2 == num)
				{
				}
				num = (short)1868365825;
				if (num != 0)
				{
				}
				num = (short)53149696;
				if (num != 0)
				{
				}
				num = (short)1677918208;
				short num3 = num;
				return this.radInfoGeneralBootloaderVersion_A7567.Applicable;
			}
			set
			{
				short num = (short)1800219457;
				short num2 = num;
				num = (short)588524353;
				switch (num2 == num)
				{
				}
				num = (short)2129461248;
				if (num != 0)
				{
				}
				num = (short)846069761;
				if (num != 0)
				{
				}
				num = (short)397410304;
				short num3 = num;
				this.radInfoGeneralBootloaderVersion_A7567.Applicable = value;
			}
		}

		// Token: 0x1700247B RID: 9339
		// (get) Token: 0x06004710 RID: 18192 RVA: 0x0041E358 File Offset: 0x0041C558
		// (set) Token: 0x06004711 RID: 18193 RVA: 0x0041E410 File Offset: 0x0041C610
		public bool RadInfoGeneralBootloaderVersion_A7567_Valid
		{
			get
			{
				short num = (short)1917472015;
				short num2 = num;
				num = (short)503336207;
				switch (num2 == num)
				{
				}
				num = (short)535035905;
				if (num != 0)
				{
				}
				num = (short)1074462720;
				if (num != 0)
				{
				}
				num = (short)193986560;
				short num3 = num;
				return this.radInfoGeneralBootloaderVersion_A7567.Valid;
			}
			set
			{
				short num = (short)1038311994;
				short num2 = num;
				num = (short)1096507962;
				switch (num2 == num)
				{
				}
				num = (short)1619394561;
				if (num != 0)
				{
				}
				num = (short)1316618240;
				if (num != 0)
				{
				}
				num = (short)1227096064;
				short num3 = num;
				this.radInfoGeneralBootloaderVersion_A7567.Valid = value;
			}
		}

		// Token: 0x1700247C RID: 9340
		// (get) Token: 0x06004712 RID: 18194 RVA: 0x0041E4C4 File Offset: 0x0041C6C4
		// (set) Token: 0x06004713 RID: 18195 RVA: 0x0041E57C File Offset: 0x0041C77C
		public bool RadInfoGeneralBootloaderVersion_A7567_Visible
		{
			get
			{
				short num = (short)1652378120;
				short num2 = num;
				num = (short)1157384712;
				switch (num2 == num)
				{
				}
				num = (short)1991442432;
				if (num != 0)
				{
				}
				num = (short)485949441;
				if (num != 0)
				{
				}
				num = (short)302186496;
				short num3 = num;
				return this.radInfoGeneralBootloaderVersion_A7567.Visible;
			}
			set
			{
				short num = (short)814809089;
				if (num != 0)
				{
				}
				num = (short)1282952596;
				short num2 = num;
				num = (short)2028359060;
				switch (num2 == num)
				{
				}
				num = (short)2053242880;
				if (num != 0)
				{
				}
				num = (short)368115712;
				short num3 = num;
				this.radInfoGeneralBootloaderVersion_A7567.Visible = value;
			}
		}

		// Token: 0x1700247D RID: 9341
		// (get) Token: 0x06004714 RID: 18196 RVA: 0x0041E634 File Offset: 0x0041C834
		// (set) Token: 0x06004715 RID: 18197 RVA: 0x0041E6E8 File Offset: 0x0041C8E8
		public bool RadInfoGeneralBootloaderVersion_A7567_Editable
		{
			get
			{
				short num = (short)1630272036;
				short num2 = num;
				num = (short)1161624100;
				switch (num2 == num)
				{
				}
				num = (short)1064632321;
				if (num != 0)
				{
				}
				num = (short)1423376384;
				if (num != 0)
				{
				}
				num = (short)541589504;
				short num3 = num;
				return this.radInfoGeneralBootloaderVersion_A7567.Editable;
			}
			set
			{
				short num = (short)1058007098;
				short num2 = num;
				num = (short)73656378;
				switch (num2 == num)
				{
				}
				num = (short)1656291329;
				if (num != 0)
				{
				}
				num = (short)588513280;
				if (num != 0)
				{
				}
				num = (short)1291124736;
				short num3 = num;
				this.radInfoGeneralBootloaderVersion_A7567.Editable = value;
			}
		}

		// Token: 0x1700247E RID: 9342
		// (get) Token: 0x06004716 RID: 18198 RVA: 0x0041E79C File Offset: 0x0041C99C
		internal string RadInfoGeneralBootloaderVersion_A7567_UILabel
		{
			get
			{
				short num = (short)716707213;
				short num2 = num;
				num = (short)1804866957;
				switch (num2 == num)
				{
				}
				num = (short)894238720;
				if (num != 0)
				{
				}
				num = (short)980221953;
				if (num != 0)
				{
				}
				num = (short)259522560;
				short num3 = num;
				return this.radInfoGeneralBootloaderVersion_A7567.UIName;
			}
		}

		// Token: 0x1700247F RID: 9343
		// (get) Token: 0x06004717 RID: 18199 RVA: 0x0041E850 File Offset: 0x0041CA50
		// (set) Token: 0x06004718 RID: 18200 RVA: 0x0041E904 File Offset: 0x0041CB04
		internal bool RadInfoGeneralBootloaderVersion_A7567_HiddenStatic
		{
			get
			{
				short num = (short)539059813;
				short num2 = num;
				num = (short)1990747749;
				switch (num2 == num)
				{
				}
				num = (short)1108541440;
				if (num != 0)
				{
				}
				num = (short)1146093569;
				if (num != 0)
				{
				}
				num = (short)697827328;
				short num3 = num;
				return this.radInfoGeneralBootloaderVersion_A7567.HiddenStatic;
			}
			set
			{
				short num = (short)1539979755;
				short num2 = num;
				num = (short)1658665451;
				switch (num2 == num)
				{
				}
				num = (short)631308288;
				if (num != 0)
				{
				}
				num = (short)325779457;
				if (num != 0)
				{
				}
				num = (short)1957298176;
				short num3 = num;
				this.radInfoGeneralBootloaderVersion_A7567.HiddenStatic = value;
			}
		}

		// Token: 0x17002480 RID: 9344
		// (get) Token: 0x06004719 RID: 18201 RVA: 0x0041E9B8 File Offset: 0x0041CBB8
		// (set) Token: 0x0600471A RID: 18202 RVA: 0x0041EA70 File Offset: 0x0041CC70
		internal bool RadInfoGeneralBootloaderVersion_A7567_HiddenDynamic
		{
			get
			{
				short num = (short)745094058;
				short num2 = num;
				num = (short)2095922090;
				switch (num2 == num)
				{
				}
				num = (short)431423489;
				if (num != 0)
				{
				}
				num = (short)721944576;
				if (num != 0)
				{
				}
				num = (short)993853440;
				short num3 = num;
				return this.radInfoGeneralBootloaderVersion_A7567.HiddenDynamic;
			}
			set
			{
				short num = (short)746334755;
				short num2 = num;
				num = (short)178924067;
				switch (num2 == num)
				{
				}
				num = (short)2077949952;
				if (num != 0)
				{
				}
				num = (short)946667521;
				if (num != 0)
				{
				}
				num = (short)710934528;
				short num3 = num;
				this.radInfoGeneralBootloaderVersion_A7567.HiddenDynamic = value;
			}
		}

		// Token: 0x17002481 RID: 9345
		// (get) Token: 0x0600471B RID: 18203 RVA: 0x0041EB2C File Offset: 0x0041CD2C
		public bool RadInfoGeneralBootloaderVersion_A7567_HasDiffs
		{
			get
			{
				short num = (short)2024883211;
				short num2 = num;
				num = (short)1755923467;
				switch (num2 == num)
				{
				}
				num = (short)1305477121;
				if (num != 0)
				{
				}
				num = (short)824442880;
				if (num != 0)
				{
				}
				num = (short)1685651456;
				short num3 = num;
				return this.radInfoGeneralBootloaderVersion_A7567._HasDiffs;
			}
		}

		// Token: 0x17002482 RID: 9346
		// (get) Token: 0x0600471C RID: 18204 RVA: 0x0041EBE0 File Offset: 0x0041CDE0
		// (set) Token: 0x0600471D RID: 18205 RVA: 0x0041EC94 File Offset: 0x0041CE94
		public string RadInfoGeneralCodeplugVersion_A7683Value
		{
			get
			{
				short num = (short)1935574654;
				short num2 = num;
				num = (short)1372358270;
				switch (num2 == num)
				{
				}
				num = (short)385351680;
				if (num != 0)
				{
				}
				num = (short)225771521;
				if (num != 0)
				{
				}
				num = (short)1837367296;
				short num3 = num;
				return this.radInfoGeneralCodeplugVersion_A7683.Value;
			}
			set
			{
				short num = (short)1115872032;
				short num2 = num;
				num = (short)870505248;
				switch (num2 == num)
				{
				}
				num = (short)412418048;
				if (num != 0)
				{
				}
				num = (short)1251999745;
				if (num != 0)
				{
				}
				num = (short)2097283072;
				short num3 = num;
				this.radInfoGeneralCodeplugVersion_A7683.Value = value;
			}
		}

		// Token: 0x17002483 RID: 9347
		// (get) Token: 0x0600471E RID: 18206 RVA: 0x0041ED48 File Offset: 0x0041CF48
		public global::AcpBusinessLayer.AcpField<string> RadInfoGeneralCodeplugVersion_A7683
		{
			get
			{
				short num = (short)1655826628;
				short num2 = num;
				num = (short)1901914308;
				switch (num2 == num)
				{
				}
				num = (short)1978728448;
				if (num != 0)
				{
				}
				num = (short)1297154049;
				if (num != 0)
				{
				}
				num = (short)258867200;
				short num3 = num;
				return this.radInfoGeneralCodeplugVersion_A7683;
			}
		}

		// Token: 0x17002484 RID: 9348
		// (get) Token: 0x0600471F RID: 18207 RVA: 0x0041EDFC File Offset: 0x0041CFFC
		// (set) Token: 0x06004720 RID: 18208 RVA: 0x0041EEB0 File Offset: 0x0041D0B0
		public string RadInfoGeneralCodeplugVersion_A7683_UIValue
		{
			get
			{
				short num = (short)1279181545;
				short num2 = num;
				num = (short)1023460073;
				switch (num2 == num)
				{
				}
				num = (short)677773313;
				if (num != 0)
				{
				}
				num = (short)1011089408;
				if (num != 0)
				{
				}
				num = (short)756809728;
				short num3 = num;
				return this.radInfoGeneralCodeplugVersion_A7683.Value;
			}
			set
			{
				short num = (short)1486879198;
				short num2 = num;
				num = (short)167311838;
				switch (num2 == num)
				{
				}
				num = (short)485949440;
				if (num != 0)
				{
				}
				num = (short)756088833;
				if (num != 0)
				{
				}
				num = (short)573374464;
				short num3 = num;
				this.radInfoGeneralCodeplugVersion_A7683.Value = value;
			}
		}

		// Token: 0x17002485 RID: 9349
		// (get) Token: 0x06004721 RID: 18209 RVA: 0x0041EF64 File Offset: 0x0041D164
		// (set) Token: 0x06004722 RID: 18210 RVA: 0x0041F018 File Offset: 0x0041D218
		public bool RadInfoGeneralCodeplugVersion_A7683_Applicable
		{
			get
			{
				short num = (short)1529067052;
				short num2 = num;
				num = (short)1076409900;
				switch (num2 == num)
				{
				}
				num = (short)123207681;
				if (num != 0)
				{
				}
				num = (short)1675821056;
				if (num != 0)
				{
				}
				num = (short)1766522880;
				short num3 = num;
				return this.radInfoGeneralCodeplugVersion_A7683.Applicable;
			}
			set
			{
				short num = (short)981360884;
				short num2 = num;
				num = (short)477585652;
				switch (num2 == num)
				{
				}
				num = (short)782565377;
				if (num != 0)
				{
				}
				num = (short)2020868096;
				if (num != 0)
				{
				}
				num = (short)2140405760;
				short num3 = num;
				this.radInfoGeneralCodeplugVersion_A7683.Applicable = value;
			}
		}

		// Token: 0x17002486 RID: 9350
		// (get) Token: 0x06004723 RID: 18211 RVA: 0x0041F0CC File Offset: 0x0041D2CC
		// (set) Token: 0x06004724 RID: 18212 RVA: 0x0041F184 File Offset: 0x0041D384
		public bool RadInfoGeneralCodeplugVersion_A7683_Valid
		{
			get
			{
				short num = (short)266441882;
				short num2 = num;
				num = (short)229217434;
				switch (num2 == num)
				{
				}
				num = (short)2137128960;
				if (num != 0)
				{
				}
				num = (short)1625554945;
				if (num != 0)
				{
				}
				num = (short)1117257728;
				short num3 = num;
				return this.radInfoGeneralCodeplugVersion_A7683.Valid;
			}
			set
			{
				short num = (short)1983977008;
				short num2 = num;
				num = (short)22615600;
				switch (num2 == num)
				{
				}
				num = (short)1570635777;
				if (num != 0)
				{
				}
				num = (short)1134559232;
				if (num != 0)
				{
				}
				num = (short)1084948480;
				short num3 = num;
				this.radInfoGeneralCodeplugVersion_A7683.Valid = value;
			}
		}

		// Token: 0x17002487 RID: 9351
		// (get) Token: 0x06004725 RID: 18213 RVA: 0x0041F238 File Offset: 0x0041D438
		// (set) Token: 0x06004726 RID: 18214 RVA: 0x0041F2EC File Offset: 0x0041D4EC
		public bool RadInfoGeneralCodeplugVersion_A7683_Visible
		{
			get
			{
				short num = (short)1974179232;
				short num2 = num;
				num = (short)1207604640;
				switch (num2 == num)
				{
				}
				num = (short)1770651649;
				if (num != 0)
				{
				}
				num = (short)1959919616;
				if (num != 0)
				{
				}
				num = (short)248381440;
				short num3 = num;
				return this.radInfoGeneralCodeplugVersion_A7683.Visible;
			}
			set
			{
				short num = (short)1572172589;
				short num2 = num;
				num = (short)1466331949;
				switch (num2 == num)
				{
				}
				num = (short)1250164736;
				if (num != 0)
				{
				}
				num = (short)1850933249;
				if (num != 0)
				{
				}
				num = (short)498270208;
				short num3 = num;
				this.radInfoGeneralCodeplugVersion_A7683.Visible = value;
			}
		}

		// Token: 0x17002488 RID: 9352
		// (get) Token: 0x06004727 RID: 18215 RVA: 0x0041F3A0 File Offset: 0x0041D5A0
		// (set) Token: 0x06004728 RID: 18216 RVA: 0x0041F454 File Offset: 0x0041D654
		public bool RadInfoGeneralCodeplugVersion_A7683_Editable
		{
			get
			{
				short num = (short)374407169;
				if (num != 0)
				{
				}
				num = (short)259799857;
				short num2 = num;
				num = (short)1430207281;
				switch (num2 == num)
				{
				}
				num = (short)154730496;
				if (num != 0)
				{
				}
				num = (short)1041235968;
				short num3 = num;
				return this.radInfoGeneralCodeplugVersion_A7683.Editable;
			}
			set
			{
				short num = (short)1729634401;
				short num2 = num;
				num = (short)1588666465;
				switch (num2 == num)
				{
				}
				num = (short)857735168;
				if (num != 0)
				{
				}
				num = (short)1771307009;
				if (num != 0)
				{
				}
				num = (short)1571815424;
				short num3 = num;
				this.radInfoGeneralCodeplugVersion_A7683.Editable = value;
			}
		}

		// Token: 0x17002489 RID: 9353
		// (get) Token: 0x06004729 RID: 18217 RVA: 0x0041F50C File Offset: 0x0041D70C
		internal string RadInfoGeneralCodeplugVersion_A7683_UILabel
		{
			get
			{
				short num = (short)553556317;
				short num2 = num;
				num = (short)625252701;
				switch (num2 == num)
				{
				}
				num = (short)368705537;
				if (num != 0)
				{
				}
				num = (short)1606090752;
				if (num != 0)
				{
				}
				num = (short)2056912896;
				short num3 = num;
				return this.radInfoGeneralCodeplugVersion_A7683.UIName;
			}
		}

		// Token: 0x1700248A RID: 9354
		// (get) Token: 0x0600472A RID: 18218 RVA: 0x0041F5C0 File Offset: 0x0041D7C0
		// (set) Token: 0x0600472B RID: 18219 RVA: 0x0041F674 File Offset: 0x0041D874
		internal bool RadInfoGeneralCodeplugVersion_A7683_HiddenStatic
		{
			get
			{
				short num = (short)284064322;
				short num2 = num;
				num = (short)1517386306;
				switch (num2 == num)
				{
				}
				num = (short)558759936;
				if (num != 0)
				{
				}
				num = (short)108134401;
				if (num != 0)
				{
				}
				num = (short)67436544;
				short num3 = num;
				return this.radInfoGeneralCodeplugVersion_A7683.HiddenStatic;
			}
			set
			{
				short num = (short)2084438017;
				if (num != 0)
				{
				}
				num = (short)2094366411;
				short num2 = num;
				num = (short)1381596875;
				switch (num2 == num)
				{
				}
				num = (short)1347682304;
				if (num != 0)
				{
				}
				num = (short)1453457408;
				short num3 = num;
				this.radInfoGeneralCodeplugVersion_A7683.HiddenStatic = value;
			}
		}

		// Token: 0x1700248B RID: 9355
		// (get) Token: 0x0600472C RID: 18220 RVA: 0x0041F728 File Offset: 0x0041D928
		// (set) Token: 0x0600472D RID: 18221 RVA: 0x0041F7D8 File Offset: 0x0041D9D8
		internal bool RadInfoGeneralCodeplugVersion_A7683_HiddenDynamic
		{
			get
			{
				short num = (short)2038832693;
				short num2 = num;
				num = (short)571153973;
				switch (num2 == num)
				{
				}
				num = (short)1736704000;
				if (num != 0)
				{
				}
				num = (short)1735720961;
				if (num != 0)
				{
				}
				num = (short)1080950784;
				short num3 = num;
				return this.radInfoGeneralCodeplugVersion_A7683.HiddenDynamic;
			}
			set
			{
				short num = (short)550567937;
				if (num != 0)
				{
				}
				num = (short)1303223982;
				short num2 = num;
				num = (short)786407086;
				switch (num2 == num)
				{
				}
				num = (short)221839360;
				if (num != 0)
				{
				}
				num = (short)210632704;
				short num3 = num;
				this.radInfoGeneralCodeplugVersion_A7683.HiddenDynamic = value;
			}
		}

		// Token: 0x1700248C RID: 9356
		// (get) Token: 0x0600472E RID: 18222 RVA: 0x0041F890 File Offset: 0x0041DA90
		public bool RadInfoGeneralCodeplugVersion_A7683_HasDiffs
		{
			get
			{
				short num = (short)833607899;
				short num2 = num;
				num = (short)2100025563;
				switch (num2 == num)
				{
				}
				num = (short)1887764480;
				if (num != 0)
				{
				}
				num = (short)139001857;
				if (num != 0)
				{
				}
				num = (short)38535168;
				short num3 = num;
				return this.radInfoGeneralCodeplugVersion_A7683._HasDiffs;
			}
		}

		// Token: 0x1700248D RID: 9357
		// (get) Token: 0x0600472F RID: 18223 RVA: 0x0041F944 File Offset: 0x0041DB44
		// (set) Token: 0x06004730 RID: 18224 RVA: 0x0041F9F4 File Offset: 0x0041DBF4
		public string RadInfoGeneralDSPVersion_A7892Value
		{
			get
			{
				short num = (short)360906263;
				short num2 = num;
				num = (short)840105495;
				switch (num2 == num)
				{
				}
				num = (short)123731969;
				if (num != 0)
				{
				}
				num = (short)653524992;
				if (num != 0)
				{
				}
				num = (short)415039488;
				short num3 = num;
				return this.radInfoGeneralDSPVersion_A7892.Value;
			}
			set
			{
				short num = (short)1700007750;
				short num2 = num;
				num = (short)197332806;
				switch (num2 == num)
				{
				}
				num = (short)1024000000;
				if (num != 0)
				{
				}
				num = (short)1741160449;
				if (num != 0)
				{
				}
				num = (short)188743680;
				short num3 = num;
				this.radInfoGeneralDSPVersion_A7892.Value = value;
			}
		}

		// Token: 0x1700248E RID: 9358
		// (get) Token: 0x06004731 RID: 18225 RVA: 0x0041FAA8 File Offset: 0x0041DCA8
		public global::AcpBusinessLayer.AcpField<string> RadInfoGeneralDSPVersion_A7892
		{
			get
			{
				short num = (short)964408155;
				short num2 = num;
				num = (short)1701098331;
				switch (num2 == num)
				{
				}
				num = (short)720175104;
				if (num != 0)
				{
				}
				num = (short)746389505;
				if (num != 0)
				{
				}
				num = (short)909836288;
				short num3 = num;
				return this.radInfoGeneralDSPVersion_A7892;
			}
		}

		// Token: 0x1700248F RID: 9359
		// (get) Token: 0x06004732 RID: 18226 RVA: 0x0041FB58 File Offset: 0x0041DD58
		// (set) Token: 0x06004733 RID: 18227 RVA: 0x0041FC0C File Offset: 0x0041DE0C
		public string RadInfoGeneralDSPVersion_A7892_UIValue
		{
			get
			{
				short num = (short)260964353;
				if (num != 0)
				{
				}
				num = (short)1437998321;
				short num2 = num;
				num = (short)330177777;
				switch (num2 == num)
				{
				}
				num = (short)1536688128;
				if (num != 0)
				{
				}
				num = (short)1645477888;
				short num3 = num;
				return this.radInfoGeneralDSPVersion_A7892.Value;
			}
			set
			{
				short num = (short)865562437;
				short num2 = num;
				num = (short)266825541;
				switch (num2 == num)
				{
				}
				num = (short)597819393;
				if (num != 0)
				{
				}
				num = (short)364969984;
				if (num != 0)
				{
				}
				num = (short)375455744;
				short num3 = num;
				this.radInfoGeneralDSPVersion_A7892.Value = value;
			}
		}

		// Token: 0x17002490 RID: 9360
		// (get) Token: 0x06004734 RID: 18228 RVA: 0x0041FCC4 File Offset: 0x0041DEC4
		// (set) Token: 0x06004735 RID: 18229 RVA: 0x0041FD78 File Offset: 0x0041DF78
		public bool RadInfoGeneralDSPVersion_A7892_Applicable
		{
			get
			{
				short num = (short)186154137;
				short num2 = num;
				num = (short)1713011865;
				switch (num2 == num)
				{
				}
				num = (short)2084372481;
				if (num != 0)
				{
				}
				num = (short)70975488;
				if (num != 0)
				{
				}
				num = (short)449380352;
				short num3 = num;
				return this.radInfoGeneralDSPVersion_A7892.Applicable;
			}
			set
			{
				short num = (short)1441290704;
				short num2 = num;
				num = (short)2040158672;
				switch (num2 == num)
				{
				}
				num = (short)524419073;
				if (num != 0)
				{
				}
				num = (short)1310982144;
				if (num != 0)
				{
				}
				num = (short)1371275264;
				short num3 = num;
				this.radInfoGeneralDSPVersion_A7892.Applicable = value;
			}
		}

		// Token: 0x17002491 RID: 9361
		// (get) Token: 0x06004736 RID: 18230 RVA: 0x0041FE2C File Offset: 0x0041E02C
		// (set) Token: 0x06004737 RID: 18231 RVA: 0x0041FEE0 File Offset: 0x0041E0E0
		public bool RadInfoGeneralDSPVersion_A7892_Valid
		{
			get
			{
				short num = (short)19408715;
				short num2 = num;
				num = (short)1892558667;
				switch (num2 == num)
				{
				}
				num = (short)548798465;
				if (num != 0)
				{
				}
				num = (short)1928658944;
				if (num != 0)
				{
				}
				num = (short)1092026368;
				short num3 = num;
				return this.radInfoGeneralDSPVersion_A7892.Valid;
			}
			set
			{
				short num = (short)817296057;
				short num2 = num;
				num = (short)46002873;
				switch (num2 == num)
				{
				}
				num = (short)1216020481;
				if (num != 0)
				{
				}
				num = (short)1588133888;
				if (num != 0)
				{
				}
				num = (short)1925054464;
				short num3 = num;
				this.radInfoGeneralDSPVersion_A7892.Valid = value;
			}
		}

		// Token: 0x17002492 RID: 9362
		// (get) Token: 0x06004738 RID: 18232 RVA: 0x0041FF94 File Offset: 0x0041E194
		// (set) Token: 0x06004739 RID: 18233 RVA: 0x0042004C File Offset: 0x0041E24C
		public bool RadInfoGeneralDSPVersion_A7892_Visible
		{
			get
			{
				short num = (short)441299908;
				short num2 = num;
				num = (short)1878307780;
				switch (num2 == num)
				{
				}
				num = (short)671154176;
				if (num != 0)
				{
				}
				num = (short)1751842817;
				if (num != 0)
				{
				}
				num = (short)1300103168;
				short num3 = num;
				return this.radInfoGeneralDSPVersion_A7892.Visible;
			}
			set
			{
				short num = (short)838517533;
				short num2 = num;
				num = (short)303416093;
				switch (num2 == num)
				{
				}
				num = (short)755695617;
				if (num != 0)
				{
				}
				num = (short)436142080;
				if (num != 0)
				{
				}
				num = (short)1950547968;
				short num3 = num;
				this.radInfoGeneralDSPVersion_A7892.Visible = value;
			}
		}

		// Token: 0x17002493 RID: 9363
		// (get) Token: 0x0600473A RID: 18234 RVA: 0x00420104 File Offset: 0x0041E304
		// (set) Token: 0x0600473B RID: 18235 RVA: 0x004201B8 File Offset: 0x0041E3B8
		public bool RadInfoGeneralDSPVersion_A7892_Editable
		{
			get
			{
				short num = (short)1938161665;
				if (num != 0)
				{
				}
				num = (short)276336110;
				short num2 = num;
				num = (short)77958638;
				switch (num2 == num)
				{
				}
				num = (short)1868365824;
				if (num != 0)
				{
				}
				num = (short)1428750336;
				short num3 = num;
				return this.radInfoGeneralDSPVersion_A7892.Editable;
			}
			set
			{
				short num = (short)1677775707;
				short num2 = num;
				num = (short)2049954651;
				switch (num2 == num)
				{
				}
				num = (short)1521090560;
				if (num != 0)
				{
				}
				num = (short)1563623425;
				if (num != 0)
				{
				}
				num = (short)82706432;
				short num3 = num;
				this.radInfoGeneralDSPVersion_A7892.Editable = value;
			}
		}

		// Token: 0x17002494 RID: 9364
		// (get) Token: 0x0600473C RID: 18236 RVA: 0x00420270 File Offset: 0x0041E470
		internal string RadInfoGeneralDSPVersion_A7892_UILabel
		{
			get
			{
				short num = (short)1969163387;
				short num2 = num;
				num = (short)1731464315;
				switch (num2 == num)
				{
				}
				num = (short)723845121;
				if (num != 0)
				{
				}
				num = (short)290390016;
				if (num != 0)
				{
				}
				num = (short)83492864;
				short num3 = num;
				return this.radInfoGeneralDSPVersion_A7892.UIName;
			}
		}

		// Token: 0x17002495 RID: 9365
		// (get) Token: 0x0600473D RID: 18237 RVA: 0x00420324 File Offset: 0x0041E524
		// (set) Token: 0x0600473E RID: 18238 RVA: 0x004203D8 File Offset: 0x0041E5D8
		internal bool RadInfoGeneralDSPVersion_A7892_HiddenStatic
		{
			get
			{
				short num = (short)740322162;
				short num2 = num;
				num = (short)1652583282;
				switch (num2 == num)
				{
				}
				num = (short)896532481;
				if (num != 0)
				{
				}
				num = (short)558891008;
				if (num != 0)
				{
				}
				num = (short)1367605248;
				short num3 = num;
				return this.radInfoGeneralDSPVersion_A7892.HiddenStatic;
			}
			set
			{
				short num = (short)1690621779;
				short num2 = num;
				num = (short)1924454227;
				switch (num2 == num)
				{
				}
				num = (short)892207104;
				if (num != 0)
				{
				}
				num = (short)2108555265;
				if (num != 0)
				{
				}
				num = (short)1837039616;
				short num3 = num;
				this.radInfoGeneralDSPVersion_A7892.HiddenStatic = value;
			}
		}

		// Token: 0x17002496 RID: 9366
		// (get) Token: 0x0600473F RID: 18239 RVA: 0x00420490 File Offset: 0x0041E690
		// (set) Token: 0x06004740 RID: 18240 RVA: 0x00420544 File Offset: 0x0041E744
		internal bool RadInfoGeneralDSPVersion_A7892_HiddenDynamic
		{
			get
			{
				short num = (short)992475678;
				short num2 = num;
				num = (short)884734494;
				switch (num2 == num)
				{
				}
				num = (short)1423114241;
				if (num != 0)
				{
				}
				num = (short)1442512896;
				short num3 = num;
				num = (short)1280114688;
				if (num != 0)
				{
				}
				return this.radInfoGeneralDSPVersion_A7892.HiddenDynamic;
			}
			set
			{
				short num = (short)25535310;
				short num2 = num;
				num = (short)16294734;
				switch (num2 == num)
				{
				}
				num = (short)113967105;
				if (num != 0)
				{
				}
				num = (short)1956249600;
				short num3 = num;
				num = (short)1165754368;
				if (num != 0)
				{
				}
				this.radInfoGeneralDSPVersion_A7892.HiddenDynamic = value;
			}
		}

		// Token: 0x17002497 RID: 9367
		// (get) Token: 0x06004741 RID: 18241 RVA: 0x004205F8 File Offset: 0x0041E7F8
		public bool RadInfoGeneralDSPVersion_A7892_HasDiffs
		{
			get
			{
				short num = (short)1591748155;
				short num2 = num;
				num = (short)948643387;
				switch (num2 == num)
				{
				}
				num = (short)1966080001;
				if (num != 0)
				{
				}
				num = (short)2136014848;
				short num3 = num;
				num = (short)1074724864;
				if (num != 0)
				{
				}
				return this.radInfoGeneralDSPVersion_A7892._HasDiffs;
			}
		}

		// Token: 0x17002498 RID: 9368
		// (get) Token: 0x06004742 RID: 18242 RVA: 0x004206AC File Offset: 0x0041E8AC
		// (set) Token: 0x06004743 RID: 18243 RVA: 0x00420768 File Offset: 0x0041E968
		public string RadInfoGeneralFirmwareVersion_A8124Value
		{
			get
			{
				short num = (short)625146705;
				short num2 = num;
				num = (short)672201553;
				switch (num2 == num)
				{
				}
				num = (short)1146224641;
				if (num != 0)
				{
				}
				num = (short)91947008;
				short num3 = num;
				num = (short)1611137024;
				if (num != 0)
				{
				}
				return this.radInfoGeneralFirmwareVersion_A8124.Value;
			}
			set
			{
				short num = (short)486337777;
				short num2 = num;
				num = (short)135720177;
				switch (num2 == num)
				{
				}
				num = (short)1663959041;
				if (num != 0)
				{
				}
				num = (short)433913856;
				short num3 = num;
				num = (short)2111766528;
				if (num != 0)
				{
				}
				this.radInfoGeneralFirmwareVersion_A8124.Value = value;
			}
		}

		// Token: 0x17002499 RID: 9369
		// (get) Token: 0x06004744 RID: 18244 RVA: 0x00420820 File Offset: 0x0041EA20
		public global::AcpBusinessLayer.AcpField<string> RadInfoGeneralFirmwareVersion_A8124
		{
			get
			{
				short num = (short)1936031107;
				short num2 = num;
				num = (short)798588291;
				switch (num2 == num)
				{
				}
				num = (short)33816576;
				if (num != 0)
				{
				}
				num = (short)506265600;
				short num3 = num;
				num = (short)1423507457;
				if (num != 0)
				{
				}
				return this.radInfoGeneralFirmwareVersion_A8124;
			}
		}

		// Token: 0x1700249A RID: 9370
		// (get) Token: 0x06004745 RID: 18245 RVA: 0x004208D0 File Offset: 0x0041EAD0
		// (set) Token: 0x06004746 RID: 18246 RVA: 0x00420984 File Offset: 0x0041EB84
		public string RadInfoGeneralFirmwareVersion_A8124_UIValue
		{
			get
			{
				short num = (short)1139224832;
				short num2 = num;
				num = (short)1900753152;
				switch (num2 == num)
				{
				}
				num = (short)900923392;
				if (num != 0)
				{
				}
				num = (short)1624834048;
				short num3 = num;
				num = (short)645005313;
				if (num != 0)
				{
				}
				return this.radInfoGeneralFirmwareVersion_A8124.Value;
			}
			set
			{
				short num = (short)952243473;
				short num2 = num;
				num = (short)164435217;
				switch (num2 == num)
				{
				}
				num = (short)250806273;
				if (num != 0)
				{
				}
				num = (short)287244288;
				short num3 = num;
				num = (short)1510604800;
				if (num != 0)
				{
				}
				this.radInfoGeneralFirmwareVersion_A8124.Value = value;
			}
		}

		// Token: 0x1700249B RID: 9371
		// (get) Token: 0x06004747 RID: 18247 RVA: 0x00420A3C File Offset: 0x0041EC3C
		// (set) Token: 0x06004748 RID: 18248 RVA: 0x00420AF0 File Offset: 0x0041ECF0
		public bool RadInfoGeneralFirmwareVersion_A8124_Applicable
		{
			get
			{
				short num = (short)97695599;
				short num2 = num;
				num = (short)1496561519;
				switch (num2 == num)
				{
				}
				num = (short)1980039169;
				if (num != 0)
				{
				}
				num = (short)2051276800;
				short num3 = num;
				num = (short)747962368;
				if (num != 0)
				{
				}
				return this.radInfoGeneralFirmwareVersion_A8124.Applicable;
			}
			set
			{
				short num = (short)451866381;
				short num2 = num;
				num = (short)379645709;
				switch (num2 == num)
				{
				}
				num = (short)2135425025;
				if (num != 0)
				{
				}
				num = (short)1761214464;
				short num3 = num;
				num = (short)1156579328;
				if (num != 0)
				{
				}
				this.radInfoGeneralFirmwareVersion_A8124.Applicable = value;
			}
		}

		// Token: 0x1700249C RID: 9372
		// (get) Token: 0x06004749 RID: 18249 RVA: 0x00420BA8 File Offset: 0x0041EDA8
		// (set) Token: 0x0600474A RID: 18250 RVA: 0x00420C5C File Offset: 0x0041EE5C
		public bool RadInfoGeneralFirmwareVersion_A8124_Valid
		{
			get
			{
				short num = (short)1685196502;
				short num2 = num;
				num = (short)2032078550;
				switch (num2 == num)
				{
				}
				num = (short)70189056;
				if (num != 0)
				{
				}
				num = (short)1231814656;
				short num3 = num;
				num = (short)1137836033;
				if (num != 0)
				{
				}
				return this.radInfoGeneralFirmwareVersion_A8124.Valid;
			}
			set
			{
				short num = (short)1335635250;
				short num2 = num;
				num = (short)692202802;
				switch (num2 == num)
				{
				}
				num = (short)540803073;
				if (num != 0)
				{
				}
				num = (short)1557397504;
				short num3 = num;
				num = (short)1295646720;
				if (num != 0)
				{
				}
				this.radInfoGeneralFirmwareVersion_A8124.Valid = value;
			}
		}

		// Token: 0x1700249D RID: 9373
		// (get) Token: 0x0600474B RID: 18251 RVA: 0x00420D14 File Offset: 0x0041EF14
		// (set) Token: 0x0600474C RID: 18252 RVA: 0x00420DC8 File Offset: 0x0041EFC8
		public bool RadInfoGeneralFirmwareVersion_A8124_Visible
		{
			get
			{
				short num = (short)1847484614;
				short num2 = num;
				num = (short)441934022;
				switch (num2 == num)
				{
				}
				num = (short)666894337;
				if (num != 0)
				{
				}
				num = (short)1675165696;
				short num3 = num;
				num = (short)2130313216;
				if (num != 0)
				{
				}
				return this.radInfoGeneralFirmwareVersion_A8124.Visible;
			}
			set
			{
				short num = (short)623537656;
				short num2 = num;
				num = (short)1492413944;
				switch (num2 == num)
				{
				}
				num = (short)215613440;
				if (num != 0)
				{
				}
				num = (short)1280901120;
				short num3 = num;
				num = (short)525533185;
				if (num != 0)
				{
				}
				this.radInfoGeneralFirmwareVersion_A8124.Visible = value;
			}
		}

		// Token: 0x1700249E RID: 9374
		// (get) Token: 0x0600474D RID: 18253 RVA: 0x00420E80 File Offset: 0x0041F080
		// (set) Token: 0x0600474E RID: 18254 RVA: 0x00420F34 File Offset: 0x0041F134
		public bool RadInfoGeneralFirmwareVersion_A8124_Editable
		{
			get
			{
				short num = (short)1897502402;
				short num2 = num;
				num = (short)35690178;
				switch (num2 == num)
				{
				}
				num = (short)105709568;
				if (num != 0)
				{
				}
				num = (short)1890975744;
				short num3 = num;
				num = (short)1792409601;
				if (num != 0)
				{
				}
				return this.radInfoGeneralFirmwareVersion_A8124.Editable;
			}
			set
			{
				short num = (short)292552705;
				if (num != 0)
				{
				}
				num = (short)1629898800;
				short num2 = num;
				num = (short)1516718128;
				switch (num2 == num)
				{
				}
				num = (short)1060372480;
				short num3 = num;
				num = (short)777191424;
				if (num != 0)
				{
				}
				this.radInfoGeneralFirmwareVersion_A8124.Editable = value;
			}
		}

		// Token: 0x1700249F RID: 9375
		// (get) Token: 0x0600474F RID: 18255 RVA: 0x00420FE8 File Offset: 0x0041F1E8
		internal string RadInfoGeneralFirmwareVersion_A8124_UILabel
		{
			get
			{
				short num = (short)1921293116;
				short num2 = num;
				num = (short)1466211132;
				switch (num2 == num)
				{
				}
				num = (short)1232207872;
				if (num != 0)
				{
				}
				num = (short)138346496;
				short num3 = num;
				num = (short)1984888833;
				if (num != 0)
				{
				}
				return this.radInfoGeneralFirmwareVersion_A8124.UIName;
			}
		}

		// Token: 0x170024A0 RID: 9376
		// (get) Token: 0x06004750 RID: 18256 RVA: 0x0042109C File Offset: 0x0041F29C
		// (set) Token: 0x06004751 RID: 18257 RVA: 0x00421150 File Offset: 0x0041F350
		internal bool RadInfoGeneralFirmwareVersion_A8124_HiddenStatic
		{
			get
			{
				short num = (short)1635148494;
				short num2 = num;
				num = (short)741565134;
				switch (num2 == num)
				{
				}
				num = (short)1170735105;
				if (num != 0)
				{
				}
				num = (short)896860160;
				short num3 = num;
				num = (short)1335230464;
				if (num != 0)
				{
				}
				return this.radInfoGeneralFirmwareVersion_A8124.HiddenStatic;
			}
			set
			{
				short num = (short)1138240523;
				short num2 = num;
				num = (short)1483287563;
				switch (num2 == num)
				{
				}
				num = (short)1193213953;
				if (num != 0)
				{
				}
				num = (short)1579417600;
				short num3 = num;
				num = (short)1058209792;
				if (num != 0)
				{
				}
				this.radInfoGeneralFirmwareVersion_A8124.HiddenStatic = value;
			}
		}

		// Token: 0x170024A1 RID: 9377
		// (get) Token: 0x06004752 RID: 18258 RVA: 0x00421208 File Offset: 0x0041F408
		// (set) Token: 0x06004753 RID: 18259 RVA: 0x004212BC File Offset: 0x0041F4BC
		internal bool RadInfoGeneralFirmwareVersion_A8124_HiddenDynamic
		{
			get
			{
				short num = (short)230831301;
				short num2 = num;
				num = (short)1484076229;
				switch (num2 == num)
				{
				}
				num = (short)2101084161;
				if (num != 0)
				{
				}
				num = (short)1527971840;
				short num3 = num;
				num = (short)1029570560;
				if (num != 0)
				{
				}
				return this.radInfoGeneralFirmwareVersion_A8124.HiddenDynamic;
			}
			set
			{
				short num = (short)1809896226;
				short num2 = num;
				num = (short)1040372514;
				switch (num2 == num)
				{
				}
				num = (short)396099584;
				if (num != 0)
				{
				}
				num = (short)1432616960;
				short num3 = num;
				num = (short)789184513;
				if (num != 0)
				{
				}
				this.radInfoGeneralFirmwareVersion_A8124.HiddenDynamic = value;
			}
		}

		// Token: 0x170024A2 RID: 9378
		// (get) Token: 0x06004754 RID: 18260 RVA: 0x00421370 File Offset: 0x0041F570
		public bool RadInfoGeneralFirmwareVersion_A8124_HasDiffs
		{
			get
			{
				short num = (short)1275444782;
				short num2 = num;
				num = (short)2014953006;
				switch (num2 == num)
				{
				}
				num = (short)1574567937;
				if (num != 0)
				{
				}
				num = (short)1580138496;
				short num3 = num;
				num = (short)129368064;
				if (num != 0)
				{
				}
				return this.radInfoGeneralFirmwareVersion_A8124._HasDiffs;
			}
		}

		// Token: 0x170024A3 RID: 9379
		// (get) Token: 0x06004755 RID: 18261 RVA: 0x00421424 File Offset: 0x0041F624
		// (set) Token: 0x06004756 RID: 18262 RVA: 0x004214D8 File Offset: 0x0041F6D8
		public string RadInfoGeneralModelNumber_A8539Value
		{
			get
			{
				short num = (short)1835366783;
				short num2 = num;
				num = (short)1701345663;
				switch (num2 == num)
				{
				}
				num = (short)239140865;
				if (num != 0)
				{
				}
				num = (short)393412608;
				short num3 = num;
				num = (short)711393280;
				if (num != 0)
				{
				}
				return this.radInfoGeneralModelNumber_A8539.Value;
			}
			set
			{
				short num = (short)585320016;
				short num2 = num;
				num = (short)1495418448;
				switch (num2 == num)
				{
				}
				num = (short)326303744;
				if (num != 0)
				{
				}
				num = (short)585105408;
				short num3 = num;
				num = (short)295895041;
				if (num != 0)
				{
				}
				this.radInfoGeneralModelNumber_A8539.Value = value;
			}
		}

		// Token: 0x170024A4 RID: 9380
		// (get) Token: 0x06004757 RID: 18263 RVA: 0x00421590 File Offset: 0x0041F790
		public global::AcpBusinessLayer.AcpField<string> RadInfoGeneralModelNumber_A8539
		{
			get
			{
				short num = (short)372547598;
				short num2 = num;
				num = (short)1922146318;
				switch (num2 == num)
				{
				}
				num = (short)354091009;
				if (num != 0)
				{
				}
				num = (short)686948352;
				short num3 = num;
				num = (short)1402667008;
				if (num != 0)
				{
				}
				return this.radInfoGeneralModelNumber_A8539;
			}
		}

		// Token: 0x170024A5 RID: 9381
		// (get) Token: 0x06004758 RID: 18264 RVA: 0x00421640 File Offset: 0x0041F840
		// (set) Token: 0x06004759 RID: 18265 RVA: 0x004216F8 File Offset: 0x0041F8F8
		public string RadInfoGeneralModelNumber_A8539_UIValue
		{
			get
			{
				short num = (short)2019725025;
				short num2 = num;
				num = (short)572952289;
				switch (num2 == num)
				{
				}
				num = (short)1301610496;
				if (num != 0)
				{
				}
				num = (short)680329216;
				short num3 = num;
				num = (short)593362945;
				if (num != 0)
				{
				}
				return this.radInfoGeneralModelNumber_A8539.Value;
			}
			set
			{
				short num = (short)689532475;
				short num2 = num;
				num = (short)1258843707;
				switch (num2 == num)
				{
				}
				num = (short)692649985;
				if (num != 0)
				{
				}
				num = (short)259981312;
				short num3 = num;
				num = (short)1318649856;
				if (num != 0)
				{
				}
				this.radInfoGeneralModelNumber_A8539.Value = value;
			}
		}

		// Token: 0x170024A6 RID: 9382
		// (get) Token: 0x0600475A RID: 18266 RVA: 0x004217AC File Offset: 0x0041F9AC
		// (set) Token: 0x0600475B RID: 18267 RVA: 0x00421860 File Offset: 0x0041FA60
		public bool RadInfoGeneralModelNumber_A8539_Applicable
		{
			get
			{
				short num = (short)673382401;
				if (num != 0)
				{
				}
				num = (short)1198055637;
				short num2 = num;
				num = (short)2137907413;
				switch (num2 == num)
				{
				}
				num = (short)1548419072;
				short num3 = num;
				num = (short)725286912;
				if (num != 0)
				{
				}
				return this.radInfoGeneralModelNumber_A8539.Applicable;
			}
			set
			{
				short num = (short)1811370770;
				short num2 = num;
				num = (short)730682130;
				switch (num2 == num)
				{
				}
				num = (short)1888813057;
				if (num != 0)
				{
				}
				num = (short)13828096;
				short num3 = num;
				num = (short)167247872;
				if (num != 0)
				{
				}
				this.radInfoGeneralModelNumber_A8539.Applicable = value;
			}
		}

		// Token: 0x170024A7 RID: 9383
		// (get) Token: 0x0600475C RID: 18268 RVA: 0x00421914 File Offset: 0x0041FB14
		// (set) Token: 0x0600475D RID: 18269 RVA: 0x004219C8 File Offset: 0x0041FBC8
		public bool RadInfoGeneralModelNumber_A8539_Valid
		{
			get
			{
				short num = (short)918357937;
				short num2 = num;
				num = (short)1781794737;
				switch (num2 == num)
				{
				}
				num = (short)1640038401;
				if (num != 0)
				{
				}
				num = (short)19070976;
				short num3 = num;
				num = (short)494075904;
				if (num != 0)
				{
				}
				return this.radInfoGeneralModelNumber_A8539.Valid;
			}
			set
			{
				short num = (short)1356898257;
				short num2 = num;
				num = (short)1589223377;
				switch (num2 == num)
				{
				}
				num = (short)450494464;
				if (num != 0)
				{
				}
				num = (short)1963851776;
				short num3 = num;
				num = (short)1785069569;
				if (num != 0)
				{
				}
				this.radInfoGeneralModelNumber_A8539.Valid = value;
			}
		}

		// Token: 0x170024A8 RID: 9384
		// (get) Token: 0x0600475E RID: 18270 RVA: 0x00421A7C File Offset: 0x0041FC7C
		// (set) Token: 0x0600475F RID: 18271 RVA: 0x00421B2C File Offset: 0x0041FD2C
		public bool RadInfoGeneralModelNumber_A8539_Visible
		{
			get
			{
				short num = (short)1080110774;
				short num2 = num;
				num = (short)1180708534;
				switch (num2 == num)
				{
				}
				num = (short)1037762560;
				if (num != 0)
				{
				}
				num = (short)1953234944;
				short num3 = num;
				num = (short)1676083201;
				if (num != 0)
				{
				}
				return this.radInfoGeneralModelNumber_A8539.Visible;
			}
			set
			{
				short num = (short)91927791;
				short num2 = num;
				num = (short)1839707375;
				switch (num2 == num)
				{
				}
				num = (short)1118568449;
				if (num != 0)
				{
				}
				num = (short)440532992;
				short num3 = num;
				num = (short)1904279552;
				if (num != 0)
				{
				}
				this.radInfoGeneralModelNumber_A8539.Visible = value;
			}
		}

		// Token: 0x170024A9 RID: 9385
		// (get) Token: 0x06004760 RID: 18272 RVA: 0x00421BE4 File Offset: 0x0041FDE4
		// (set) Token: 0x06004761 RID: 18273 RVA: 0x00421C98 File Offset: 0x0041FE98
		public bool RadInfoGeneralModelNumber_A8539_Editable
		{
			get
			{
				short num = (short)2138030602;
				short num2 = num;
				num = (short)97436170;
				switch (num2 == num)
				{
				}
				num = (short)1628635137;
				if (num != 0)
				{
				}
				num = (short)1850408960;
				short num3 = num;
				num = (short)1857028096;
				if (num != 0)
				{
				}
				return this.radInfoGeneralModelNumber_A8539.Editable;
			}
			set
			{
				short num = (short)1893826596;
				short num2 = num;
				num = (short)2145288228;
				switch (num2 == num)
				{
				}
				num = (short)190316545;
				if (num != 0)
				{
				}
				num = (short)906100736;
				short num3 = num;
				num = (short)126550016;
				if (num != 0)
				{
				}
				this.radInfoGeneralModelNumber_A8539.Editable = value;
			}
		}

		// Token: 0x170024AA RID: 9386
		// (get) Token: 0x06004762 RID: 18274 RVA: 0x00421D4C File Offset: 0x0041FF4C
		internal string RadInfoGeneralModelNumber_A8539_UILabel
		{
			get
			{
				short num = (short)344644476;
				short num2 = num;
				num = (short)198892412;
				switch (num2 == num)
				{
				}
				num = (short)791412737;
				if (num != 0)
				{
				}
				num = (short)161021952;
				short num3 = num;
				num = (short)2001797120;
				if (num != 0)
				{
				}
				return this.radInfoGeneralModelNumber_A8539.UIName;
			}
		}

		// Token: 0x170024AB RID: 9387
		// (get) Token: 0x06004763 RID: 18275 RVA: 0x00421E00 File Offset: 0x00420000
		// (set) Token: 0x06004764 RID: 18276 RVA: 0x00421EB4 File Offset: 0x004200B4
		internal bool RadInfoGeneralModelNumber_A8539_HiddenStatic
		{
			get
			{
				short num = (short)851572729;
				short num2 = num;
				num = (short)1064695801;
				switch (num2 == num)
				{
				}
				num = (short)183042049;
				if (num != 0)
				{
				}
				num = (short)1955659776;
				short num3 = num;
				num = (short)1338179584;
				if (num != 0)
				{
				}
				return this.radInfoGeneralModelNumber_A8539.HiddenStatic;
			}
			set
			{
				short num = (short)2137760604;
				short num2 = num;
				num = (short)929276764;
				switch (num2 == num)
				{
				}
				num = (short)1325596673;
				if (num != 0)
				{
				}
				num = (short)835059712;
				short num3 = num;
				num = (short)1416888320;
				if (num != 0)
				{
				}
				this.radInfoGeneralModelNumber_A8539.HiddenStatic = value;
			}
		}

		// Token: 0x170024AC RID: 9388
		// (get) Token: 0x06004765 RID: 18277 RVA: 0x00421F6C File Offset: 0x0042016C
		// (set) Token: 0x06004766 RID: 18278 RVA: 0x00422020 File Offset: 0x00420220
		internal bool RadInfoGeneralModelNumber_A8539_HiddenDynamic
		{
			get
			{
				short num = (short)625667050;
				short num2 = num;
				num = (short)1334438890;
				switch (num2 == num)
				{
				}
				num = (short)383254529;
				if (num != 0)
				{
				}
				num = (short)2072772608;
				short num3 = num;
				num = (short)88735744;
				if (num != 0)
				{
				}
				return this.radInfoGeneralModelNumber_A8539.HiddenDynamic;
			}
			set
			{
				short num = (short)1774944404;
				short num2 = num;
				num = (short)1547993236;
				switch (num2 == num)
				{
				}
				num = (short)1110638592;
				if (num != 0)
				{
				}
				num = (short)1278214144;
				short num3 = num;
				num = (short)983041;
				if (num != 0)
				{
				}
				this.radInfoGeneralModelNumber_A8539.HiddenDynamic = value;
			}
		}

		// Token: 0x170024AD RID: 9389
		// (get) Token: 0x06004767 RID: 18279 RVA: 0x004220D4 File Offset: 0x004202D4
		public bool RadInfoGeneralModelNumber_A8539_HasDiffs
		{
			get
			{
				short num = (short)248250369;
				if (num != 0)
				{
				}
				num = (short)1202904646;
				short num2 = num;
				num = (short)1903222342;
				switch (num2 == num)
				{
				}
				num = (short)940703744;
				short num3 = num;
				num = (short)1201537024;
				if (num != 0)
				{
				}
				return this.radInfoGeneralModelNumber_A8539._HasDiffs;
			}
		}

		// Token: 0x170024AE RID: 9390
		// (get) Token: 0x06004768 RID: 18280 RVA: 0x00422188 File Offset: 0x00420388
		// (set) Token: 0x06004769 RID: 18281 RVA: 0x00422240 File Offset: 0x00420440
		public string RadInfoGeneralNautilusVersion_A8564Value
		{
			get
			{
				short num = (short)307732042;
				short num2 = num;
				num = (short)421961290;
				switch (num2 == num)
				{
				}
				num = (short)926154753;
				if (num != 0)
				{
				}
				num = (short)512425984;
				short num3 = num;
				num = (short)1332346880;
				if (num != 0)
				{
				}
				return this.radInfoGeneralNautilusVersion_A8564.Value;
			}
			set
			{
				short num = (short)21652866;
				short num2 = num;
				num = (short)833840514;
				switch (num2 == num)
				{
				}
				num = (short)1998651392;
				if (num != 0)
				{
				}
				num = (short)2046296064;
				short num3 = num;
				num = (short)1223163905;
				if (num != 0)
				{
				}
				this.radInfoGeneralNautilusVersion_A8564.Value = value;
			}
		}

		// Token: 0x170024AF RID: 9391
		// (get) Token: 0x0600476A RID: 18282 RVA: 0x004222F8 File Offset: 0x004204F8
		public global::AcpBusinessLayer.AcpField<string> RadInfoGeneralNautilusVersion_A8564
		{
			get
			{
				short num = (short)1473609783;
				short num2 = num;
				num = (short)1035042871;
				switch (num2 == num)
				{
				}
				num = (short)1246560256;
				if (num != 0)
				{
				}
				num = (short)752091136;
				short num3 = num;
				num = (short)1896153089;
				if (num != 0)
				{
				}
				return this.radInfoGeneralNautilusVersion_A8564;
			}
		}

		// Token: 0x170024B0 RID: 9392
		// (get) Token: 0x0600476B RID: 18283 RVA: 0x004223A8 File Offset: 0x004205A8
		// (set) Token: 0x0600476C RID: 18284 RVA: 0x0042245C File Offset: 0x0042065C
		public string RadInfoGeneralNautilusVersion_A8564_UIValue
		{
			get
			{
				short num = (short)438791618;
				short num2 = num;
				num = (short)1889496514;
				switch (num2 == num)
				{
				}
				num = (short)1456734208;
				if (num != 0)
				{
				}
				num = (short)1357185024;
				short num3 = num;
				num = (short)1651769345;
				if (num != 0)
				{
				}
				return this.radInfoGeneralNautilusVersion_A8564.Value;
			}
			set
			{
				short num = (short)986197149;
				short num2 = num;
				num = (short)489958557;
				switch (num2 == num)
				{
				}
				num = (short)1054408705;
				if (num != 0)
				{
				}
				num = (short)860618752;
				short num3 = num;
				num = (short)1851719680;
				if (num != 0)
				{
				}
				this.radInfoGeneralNautilusVersion_A8564.Value = value;
			}
		}

		// Token: 0x170024B1 RID: 9393
		// (get) Token: 0x0600476D RID: 18285 RVA: 0x00422510 File Offset: 0x00420710
		// (set) Token: 0x0600476E RID: 18286 RVA: 0x004225C4 File Offset: 0x004207C4
		public bool RadInfoGeneralNautilusVersion_A8564_Applicable
		{
			get
			{
				short num = (short)1607386756;
				short num2 = num;
				num = (short)2090976900;
				switch (num2 == num)
				{
				}
				num = (short)490799105;
				if (num != 0)
				{
				}
				num = (short)417333248;
				short num3 = num;
				num = (short)1420623872;
				if (num != 0)
				{
				}
				return this.radInfoGeneralNautilusVersion_A8564.Applicable;
			}
			set
			{
				short num = (short)1675986112;
				short num2 = num;
				num = (short)1187480768;
				switch (num2 == num)
				{
				}
				num = (short)304349184;
				if (num != 0)
				{
				}
				num = (short)254738432;
				short num3 = num;
				num = (short)1271398401;
				if (num != 0)
				{
				}
				this.radInfoGeneralNautilusVersion_A8564.Applicable = value;
			}
		}

		// Token: 0x170024B2 RID: 9394
		// (get) Token: 0x0600476F RID: 18287 RVA: 0x0042267C File Offset: 0x0042087C
		// (set) Token: 0x06004770 RID: 18288 RVA: 0x00422730 File Offset: 0x00420930
		public bool RadInfoGeneralNautilusVersion_A8564_Valid
		{
			get
			{
				short num = (short)48103425;
				if (num != 0)
				{
				}
				num = (short)886381826;
				short num2 = num;
				num = (short)806493442;
				switch (num2 == num)
				{
				}
				num = (short)308805632;
				short num3 = num;
				num = (short)227868672;
				if (num != 0)
				{
				}
				return this.radInfoGeneralNautilusVersion_A8564.Valid;
			}
			set
			{
				short num = (short)957119213;
				short num2 = num;
				num = (short)278690541;
				switch (num2 == num)
				{
				}
				num = (short)1699479553;
				if (num != 0)
				{
				}
				num = (short)1548943360;
				short num3 = num;
				num = (short)1140850688;
				if (num != 0)
				{
				}
				this.radInfoGeneralNautilusVersion_A8564.Valid = value;
			}
		}

		// Token: 0x170024B3 RID: 9395
		// (get) Token: 0x06004771 RID: 18289 RVA: 0x004227E8 File Offset: 0x004209E8
		// (set) Token: 0x06004772 RID: 18290 RVA: 0x0042289C File Offset: 0x00420A9C
		public bool RadInfoGeneralNautilusVersion_A8564_Visible
		{
			get
			{
				short num = (short)1267856050;
				short num2 = num;
				num = (short)1696395954;
				switch (num2 == num)
				{
				}
				num = (short)1316618241;
				if (num != 0)
				{
				}
				num = (short)1502085120;
				short num3 = num;
				num = (short)865665024;
				if (num != 0)
				{
				}
				return this.radInfoGeneralNautilusVersion_A8564.Visible;
			}
			set
			{
				short num = (short)786919565;
				short num2 = num;
				num = (short)950890637;
				switch (num2 == num)
				{
				}
				num = (short)1112735745;
				if (num != 0)
				{
				}
				num = (short)2139750400;
				short num3 = num;
				num = (short)101187584;
				if (num != 0)
				{
				}
				this.radInfoGeneralNautilusVersion_A8564.Visible = value;
			}
		}

		// Token: 0x170024B4 RID: 9396
		// (get) Token: 0x06004773 RID: 18291 RVA: 0x00422954 File Offset: 0x00420B54
		// (set) Token: 0x06004774 RID: 18292 RVA: 0x00422A0C File Offset: 0x00420C0C
		public bool RadInfoGeneralNautilusVersion_A8564_Editable
		{
			get
			{
				short num = (short)721158145;
				if (num != 0)
				{
				}
				num = (short)1463148656;
				short num2 = num;
				num = (short)1256579184;
				switch (num2 == num)
				{
				}
				num = (short)334036992;
				short num3 = num;
				num = (short)875560960;
				if (num != 0)
				{
				}
				return this.radInfoGeneralNautilusVersion_A8564.Editable;
			}
			set
			{
				short num = (short)385037997;
				short num2 = num;
				num = (short)758265517;
				switch (num2 == num)
				{
				}
				num = (short)784465920;
				if (num != 0)
				{
				}
				num = (short)650772480;
				short num3 = num;
				num = (short)2121138177;
				if (num != 0)
				{
				}
				this.radInfoGeneralNautilusVersion_A8564.Editable = value;
			}
		}

		// Token: 0x170024B5 RID: 9397
		// (get) Token: 0x06004775 RID: 18293 RVA: 0x00422AC0 File Offset: 0x00420CC0
		internal string RadInfoGeneralNautilusVersion_A8564_UILabel
		{
			get
			{
				short num = (short)2011365377;
				if (num != 0)
				{
				}
				num = (short)172295217;
				short num2 = num;
				num = (short)1426588721;
				switch (num2 == num)
				{
				}
				num = (short)1118044160;
				short num3 = num;
				num = (short)1955987456;
				if (num != 0)
				{
				}
				return this.radInfoGeneralNautilusVersion_A8564.UIName;
			}
		}

		// Token: 0x170024B6 RID: 9398
		// (get) Token: 0x06004776 RID: 18294 RVA: 0x00422B78 File Offset: 0x00420D78
		// (set) Token: 0x06004777 RID: 18295 RVA: 0x00422C2C File Offset: 0x00420E2C
		internal bool RadInfoGeneralNautilusVersion_A8564_HiddenStatic
		{
			get
			{
				short num = (short)1609120751;
				short num2 = num;
				num = (short)391724015;
				switch (num2 == num)
				{
				}
				num = (short)1770913793;
				if (num != 0)
				{
				}
				num = (short)1129185280;
				short num3 = num;
				num = (short)279379968;
				if (num != 0)
				{
				}
				return this.radInfoGeneralNautilusVersion_A8564.HiddenStatic;
			}
			set
			{
				short num = (short)751774159;
				short num2 = num;
				num = (short)967059919;
				switch (num2 == num)
				{
				}
				num = (short)728236032;
				if (num != 0)
				{
				}
				num = (short)8126464;
				short num3 = num;
				num = (short)1711210497;
				if (num != 0)
				{
				}
				this.radInfoGeneralNautilusVersion_A8564.HiddenStatic = value;
			}
		}

		// Token: 0x170024B7 RID: 9399
		// (get) Token: 0x06004778 RID: 18296 RVA: 0x00422CE0 File Offset: 0x00420EE0
		// (set) Token: 0x06004779 RID: 18297 RVA: 0x00422D94 File Offset: 0x00420F94
		internal bool RadInfoGeneralNautilusVersion_A8564_HiddenDynamic
		{
			get
			{
				short num = (short)865001450;
				short num2 = num;
				num = (short)960684010;
				switch (num2 == num)
				{
				}
				num = (short)335413248;
				if (num != 0)
				{
				}
				num = (short)964952064;
				short num3 = num;
				num = (short)2142896129;
				if (num != 0)
				{
				}
				return this.radInfoGeneralNautilusVersion_A8564.HiddenDynamic;
			}
			set
			{
				short num = (short)1358256963;
				short num2 = num;
				num = (short)891640643;
				switch (num2 == num)
				{
				}
				num = (short)1141964801;
				if (num != 0)
				{
				}
				num = (short)355860480;
				short num3 = num;
				num = (short)568131584;
				if (num != 0)
				{
				}
				this.radInfoGeneralNautilusVersion_A8564.HiddenDynamic = value;
			}
		}

		// Token: 0x170024B8 RID: 9400
		// (get) Token: 0x0600477A RID: 18298 RVA: 0x00422E48 File Offset: 0x00421048
		public bool RadInfoGeneralNautilusVersion_A8564_HasDiffs
		{
			get
			{
				short num = (short)599940624;
				short num2 = num;
				num = (short)1089429008;
				switch (num2 == num)
				{
				}
				num = (short)313262081;
				if (num != 0)
				{
				}
				num = (short)1780547584;
				short num3 = num;
				num = (short)2000814080;
				if (num != 0)
				{
				}
				return this.radInfoGeneralNautilusVersion_A8564._HasDiffs;
			}
		}

		// Token: 0x170024B9 RID: 9401
		// (get) Token: 0x0600477B RID: 18299 RVA: 0x00422F00 File Offset: 0x00421100
		// (set) Token: 0x0600477C RID: 18300 RVA: 0x00422FB8 File Offset: 0x004211B8
		public string RadInfoGeneralPSDTVersion_A8768Value
		{
			get
			{
				short num = (short)1563365191;
				short num2 = num;
				num = (short)957419335;
				switch (num2 == num)
				{
				}
				num = (short)582680577;
				if (num != 0)
				{
				}
				num = (short)1510866944;
				short num3 = num;
				num = (short)1460535296;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPSDTVersion_A8768.Value;
			}
			set
			{
				short num = (short)191909930;
				short num2 = num;
				num = (short)1962954794;
				switch (num2 == num)
				{
				}
				num = (short)1548222464;
				if (num != 0)
				{
				}
				num = (short)1256456192;
				short num3 = num;
				num = (short)2047016961;
				if (num != 0)
				{
				}
				this.radInfoGeneralPSDTVersion_A8768.Value = value;
			}
		}

		// Token: 0x170024BA RID: 9402
		// (get) Token: 0x0600477D RID: 18301 RVA: 0x0042306C File Offset: 0x0042126C
		public global::AcpBusinessLayer.AcpField<string> RadInfoGeneralPSDTVersion_A8768
		{
			get
			{
				short num = (short)1644216830;
				short num2 = num;
				num = (short)738574846;
				switch (num2 == num)
				{
				}
				num = (short)1734213632;
				if (num != 0)
				{
				}
				num = (short)705036288;
				short num3 = num;
				num = (short)1179516929;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPSDTVersion_A8768;
			}
		}

		// Token: 0x170024BB RID: 9403
		// (get) Token: 0x0600477E RID: 18302 RVA: 0x0042311C File Offset: 0x0042131C
		// (set) Token: 0x0600477F RID: 18303 RVA: 0x004231CC File Offset: 0x004213CC
		public string RadInfoGeneralPSDTVersion_A8768_UIValue
		{
			get
			{
				short num = (short)1597681597;
				short num2 = num;
				num = (short)819179453;
				switch (num2 == num)
				{
				}
				num = (short)84148224;
				if (num != 0)
				{
				}
				num = (short)860487680;
				short num3 = num;
				num = (short)825491457;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPSDTVersion_A8768.Value;
			}
			set
			{
				short num = (short)213602108;
				short num2 = num;
				num = (short)1638354748;
				switch (num2 == num)
				{
				}
				num = (short)1887436801;
				if (num != 0)
				{
				}
				num = (short)799342592;
				short num3 = num;
				num = (short)1700462592;
				if (num != 0)
				{
				}
				this.radInfoGeneralPSDTVersion_A8768.Value = value;
			}
		}

		// Token: 0x170024BC RID: 9404
		// (get) Token: 0x06004780 RID: 18304 RVA: 0x00423280 File Offset: 0x00421480
		// (set) Token: 0x06004781 RID: 18305 RVA: 0x00423334 File Offset: 0x00421534
		public bool RadInfoGeneralPSDTVersion_A8768_Applicable
		{
			get
			{
				short num = (short)181141505;
				if (num != 0)
				{
				}
				num = (short)791797792;
				short num2 = num;
				num = (short)1707728928;
				switch (num2 == num)
				{
				}
				num = (short)472317952;
				short num3 = num;
				num = (short)1287847936;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPSDTVersion_A8768.Applicable;
			}
			set
			{
				short num = (short)1922070595;
				short num2 = num;
				num = (short)1353611331;
				switch (num2 == num)
				{
				}
				num = (short)1553727488;
				if (num != 0)
				{
				}
				num = (short)698941440;
				short num3 = num;
				num = (short)107872257;
				if (num != 0)
				{
				}
				this.radInfoGeneralPSDTVersion_A8768.Applicable = value;
			}
		}

		// Token: 0x170024BD RID: 9405
		// (get) Token: 0x06004782 RID: 18306 RVA: 0x004233EC File Offset: 0x004215EC
		// (set) Token: 0x06004783 RID: 18307 RVA: 0x004234A0 File Offset: 0x004216A0
		public bool RadInfoGeneralPSDTVersion_A8768_Valid
		{
			get
			{
				short num = (short)1123131068;
				short num2 = num;
				num = (short)827367100;
				switch (num2 == num)
				{
				}
				num = (short)2033647617;
				if (num != 0)
				{
				}
				num = (short)1481834496;
				short num3 = num;
				num = (short)2072707072;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPSDTVersion_A8768.Valid;
			}
			set
			{
				short num = (short)484568532;
				short num2 = num;
				num = (short)464121300;
				switch (num2 == num)
				{
				}
				num = (short)893911041;
				if (num != 0)
				{
				}
				num = (short)433389568;
				short num3 = num;
				num = (short)1719730176;
				if (num != 0)
				{
				}
				this.radInfoGeneralPSDTVersion_A8768.Valid = value;
			}
		}

		// Token: 0x170024BE RID: 9406
		// (get) Token: 0x06004784 RID: 18308 RVA: 0x00423554 File Offset: 0x00421754
		// (set) Token: 0x06004785 RID: 18309 RVA: 0x00423608 File Offset: 0x00421808
		public bool RadInfoGeneralPSDTVersion_A8768_Visible
		{
			get
			{
				short num = (short)1694808901;
				short num2 = num;
				num = (short)1250671429;
				switch (num2 == num)
				{
				}
				num = (short)941031425;
				if (num != 0)
				{
				}
				num = (short)1381302272;
				short num3 = num;
				num = (short)1446445056;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPSDTVersion_A8768.Visible;
			}
			set
			{
				short num = (short)1751863350;
				short num2 = num;
				num = (short)854478902;
				switch (num2 == num)
				{
				}
				num = (short)1425801216;
				if (num != 0)
				{
				}
				num = (short)1242955776;
				short num3 = num;
				num = (short)1410924545;
				if (num != 0)
				{
				}
				this.radInfoGeneralPSDTVersion_A8768.Visible = value;
			}
		}

		// Token: 0x170024BF RID: 9407
		// (get) Token: 0x06004786 RID: 18310 RVA: 0x004236C0 File Offset: 0x004218C0
		// (set) Token: 0x06004787 RID: 18311 RVA: 0x00423778 File Offset: 0x00421978
		public bool RadInfoGeneralPSDTVersion_A8768_Editable
		{
			get
			{
				short num = (short)1973417952;
				short num2 = num;
				num = (short)863303648;
				switch (num2 == num)
				{
				}
				num = (short)1434451969;
				if (num != 0)
				{
				}
				num = (short)752680960;
				short num3 = num;
				num = (short)464715776;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPSDTVersion_A8768.Editable;
			}
			set
			{
				short num = (short)1577088740;
				short num2 = num;
				num = (short)473396964;
				switch (num2 == num)
				{
				}
				num = (short)521273345;
				if (num != 0)
				{
				}
				num = (short)273154048;
				short num3 = num;
				num = (short)1454047232;
				if (num != 0)
				{
				}
				this.radInfoGeneralPSDTVersion_A8768.Editable = value;
			}
		}

		// Token: 0x170024C0 RID: 9408
		// (get) Token: 0x06004788 RID: 18312 RVA: 0x0042382C File Offset: 0x00421A2C
		internal string RadInfoGeneralPSDTVersion_A8768_UILabel
		{
			get
			{
				short num = (short)1478536054;
				short num2 = num;
				num = (short)897428342;
				switch (num2 == num)
				{
				}
				num = (short)1820917761;
				if (num != 0)
				{
				}
				num = (short)232849408;
				short num3 = num;
				num = (short)2063990784;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPSDTVersion_A8768.UIName;
			}
		}

		// Token: 0x170024C1 RID: 9409
		// (get) Token: 0x06004789 RID: 18313 RVA: 0x004238E0 File Offset: 0x00421AE0
		// (set) Token: 0x0600478A RID: 18314 RVA: 0x00423998 File Offset: 0x00421B98
		internal bool RadInfoGeneralPSDTVersion_A8768_HiddenStatic
		{
			get
			{
				short num = (short)1205491327;
				short num2 = num;
				num = (short)1661752959;
				switch (num2 == num)
				{
				}
				num = (short)140836865;
				if (num != 0)
				{
				}
				num = (short)473890816;
				short num3 = num;
				num = (short)2111635456;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPSDTVersion_A8768.HiddenStatic;
			}
			set
			{
				short num = (short)190330071;
				short num2 = num;
				num = (short)73086167;
				switch (num2 == num)
				{
				}
				num = (short)352911361;
				if (num != 0)
				{
				}
				num = (short)2059534336;
				short num3 = num;
				num = (short)2045968384;
				if (num != 0)
				{
				}
				this.radInfoGeneralPSDTVersion_A8768.HiddenStatic = value;
			}
		}

		// Token: 0x170024C2 RID: 9410
		// (get) Token: 0x0600478B RID: 18315 RVA: 0x00423A50 File Offset: 0x00421C50
		// (set) Token: 0x0600478C RID: 18316 RVA: 0x00423B08 File Offset: 0x00421D08
		internal bool RadInfoGeneralPSDTVersion_A8768_HiddenDynamic
		{
			get
			{
				short num = (short)1420056748;
				short num2 = num;
				num = (short)1330927788;
				switch (num2 == num)
				{
				}
				num = (short)766705664;
				if (num != 0)
				{
				}
				num = (short)911015936;
				short num3 = num;
				num = (short)1332346881;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPSDTVersion_A8768.HiddenDynamic;
			}
			set
			{
				short num = (short)1934489927;
				short num2 = num;
				num = (short)1066268999;
				switch (num2 == num)
				{
				}
				num = (short)1621426176;
				if (num != 0)
				{
				}
				num = (short)996147200;
				short num3 = num;
				num = (short)990052353;
				if (num != 0)
				{
				}
				this.radInfoGeneralPSDTVersion_A8768.HiddenDynamic = value;
			}
		}

		// Token: 0x170024C3 RID: 9411
		// (get) Token: 0x0600478D RID: 18317 RVA: 0x00423BC0 File Offset: 0x00421DC0
		public bool RadInfoGeneralPSDTVersion_A8768_HasDiffs
		{
			get
			{
				short num = (short)1785528321;
				if (num != 0)
				{
				}
				num = (short)63953038;
				short num2 = num;
				num = (short)1153226894;
				switch (num2 == num)
				{
				}
				num = (short)377749504;
				short num3 = num;
				num = (short)119078912;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPSDTVersion_A8768._HasDiffs;
			}
		}

		// Token: 0x170024C4 RID: 9412
		// (get) Token: 0x0600478E RID: 18318 RVA: 0x00423C74 File Offset: 0x00421E74
		// (set) Token: 0x0600478F RID: 18319 RVA: 0x00423D28 File Offset: 0x00421F28
		public string RadInfoGeneralSerialNumber_A9122Value
		{
			get
			{
				short num = (short)1571058545;
				short num2 = num;
				num = (short)730821489;
				switch (num2 == num)
				{
				}
				num = (short)763494400;
				if (num != 0)
				{
				}
				num = (short)1486684160;
				short num3 = num;
				num = (short)125042689;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSerialNumber_A9122.Value;
			}
			set
			{
				short num = (short)2120796252;
				short num2 = num;
				num = (short)1108199516;
				switch (num2 == num)
				{
				}
				num = (short)1731526657;
				if (num != 0)
				{
				}
				num = (short)1102446592;
				short num3 = num;
				num = (short)1868169216;
				if (num != 0)
				{
				}
				this.radInfoGeneralSerialNumber_A9122.Value = value;
			}
		}

		// Token: 0x170024C5 RID: 9413
		// (get) Token: 0x06004790 RID: 18320 RVA: 0x00423DDC File Offset: 0x00421FDC
		public global::AcpBusinessLayer.AcpField<string> RadInfoGeneralSerialNumber_A9122
		{
			get
			{
				short num = (short)1004464507;
				short num2 = num;
				num = (short)1455876475;
				switch (num2 == num)
				{
				}
				num = (short)1820393473;
				if (num != 0)
				{
				}
				num = (short)153550848;
				short num3 = num;
				num = (short)215089152;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSerialNumber_A9122;
			}
		}

		// Token: 0x170024C6 RID: 9414
		// (get) Token: 0x06004791 RID: 18321 RVA: 0x00423E8C File Offset: 0x0042208C
		// (set) Token: 0x06004792 RID: 18322 RVA: 0x00423F40 File Offset: 0x00422140
		public string RadInfoGeneralSerialNumber_A9122_UIValue
		{
			get
			{
				short num = (short)1040958419;
				short num2 = num;
				num = (short)302171091;
				switch (num2 == num)
				{
				}
				num = (short)6225920;
				if (num != 0)
				{
				}
				num = (short)813694976;
				short num3 = num;
				num = (short)179109889;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSerialNumber_A9122.Value;
			}
			set
			{
				short num = (short)1894766629;
				short num2 = num;
				num = (short)217962533;
				switch (num2 == num)
				{
				}
				num = (short)453967872;
				if (num != 0)
				{
				}
				num = (short)401866752;
				short num3 = num;
				num = (short)515440641;
				if (num != 0)
				{
				}
				this.radInfoGeneralSerialNumber_A9122.Value = value;
			}
		}

		// Token: 0x170024C7 RID: 9415
		// (get) Token: 0x06004793 RID: 18323 RVA: 0x00423FF8 File Offset: 0x004221F8
		// (set) Token: 0x06004794 RID: 18324 RVA: 0x004240AC File Offset: 0x004222AC
		public bool RadInfoGeneralSerialNumber_A9122_Applicable
		{
			get
			{
				short num = (short)712774911;
				short num2 = num;
				num = (short)1539970303;
				switch (num2 == num)
				{
				}
				num = (short)1854537729;
				if (num != 0)
				{
				}
				num = (short)103612416;
				short num3 = num;
				num = (short)738656256;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSerialNumber_A9122.Applicable;
			}
			set
			{
				short num = (short)1886400323;
				short num2 = num;
				num = (short)412364611;
				switch (num2 == num)
				{
				}
				num = (short)747896832;
				if (num != 0)
				{
				}
				num = (short)848560128;
				short num3 = num;
				num = (short)13631489;
				if (num != 0)
				{
				}
				this.radInfoGeneralSerialNumber_A9122.Applicable = value;
			}
		}

		// Token: 0x170024C8 RID: 9416
		// (get) Token: 0x06004795 RID: 18325 RVA: 0x00424160 File Offset: 0x00422360
		// (set) Token: 0x06004796 RID: 18326 RVA: 0x00424218 File Offset: 0x00422418
		public bool RadInfoGeneralSerialNumber_A9122_Valid
		{
			get
			{
				short num = (short)1578126918;
				short num2 = num;
				num = (short)58805830;
				switch (num2 == num)
				{
				}
				num = (short)296484865;
				if (num != 0)
				{
				}
				num = (short)1481768960;
				short num3 = num;
				num = (short)1387462656;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSerialNumber_A9122.Valid;
			}
			set
			{
				short num = (short)1819377217;
				short num2 = num;
				num = (short)582516289;
				switch (num2 == num)
				{
				}
				num = (short)1854996481;
				if (num != 0)
				{
				}
				num = (short)1294991360;
				short num3 = num;
				num = (short)1091764224;
				if (num != 0)
				{
				}
				this.radInfoGeneralSerialNumber_A9122.Valid = value;
			}
		}

		// Token: 0x170024C9 RID: 9417
		// (get) Token: 0x06004797 RID: 18327 RVA: 0x004242CC File Offset: 0x004224CC
		// (set) Token: 0x06004798 RID: 18328 RVA: 0x00424384 File Offset: 0x00422584
		public bool RadInfoGeneralSerialNumber_A9122_Visible
		{
			get
			{
				short num = (short)1453768153;
				short num2 = num;
				num = (short)1958723033;
				switch (num2 == num)
				{
				}
				num = (short)1674706945;
				if (num != 0)
				{
				}
				num = (short)1128792064;
				short num3 = num;
				num = (short)2041380864;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSerialNumber_A9122.Visible;
			}
			set
			{
				short num = (short)807486516;
				short num2 = num;
				num = (short)2122859572;
				switch (num2 == num)
				{
				}
				num = (short)1064173568;
				if (num != 0)
				{
				}
				num = (short)1328611328;
				short num3 = num;
				num = (short)493223937;
				if (num != 0)
				{
				}
				this.radInfoGeneralSerialNumber_A9122.Visible = value;
			}
		}

		// Token: 0x170024CA RID: 9418
		// (get) Token: 0x06004799 RID: 18329 RVA: 0x00424438 File Offset: 0x00422638
		// (set) Token: 0x0600479A RID: 18330 RVA: 0x004244F0 File Offset: 0x004226F0
		public bool RadInfoGeneralSerialNumber_A9122_Editable
		{
			get
			{
				short num = (short)246460845;
				short num2 = num;
				num = (short)1056158125;
				switch (num2 == num)
				{
				}
				num = (short)1944322049;
				if (num != 0)
				{
				}
				num = (short)303235072;
				short num3 = num;
				num = (short)1105920000;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSerialNumber_A9122.Editable;
			}
			set
			{
				short num = (short)135272462;
				short num2 = num;
				num = (short)311826446;
				switch (num2 == num)
				{
				}
				num = (short)108003329;
				if (num != 0)
				{
				}
				num = (short)1769013248;
				short num3 = num;
				num = (short)93782016;
				if (num != 0)
				{
				}
				this.radInfoGeneralSerialNumber_A9122.Editable = value;
			}
		}

		// Token: 0x170024CB RID: 9419
		// (get) Token: 0x0600479B RID: 18331 RVA: 0x004245A8 File Offset: 0x004227A8
		internal string RadInfoGeneralSerialNumber_A9122_UILabel
		{
			get
			{
				short num = (short)1387350041;
				short num2 = num;
				num = (short)1700284441;
				switch (num2 == num)
				{
				}
				num = (short)2111242241;
				if (num != 0)
				{
				}
				num = (short)666370048;
				short num3 = num;
				num = (short)326762496;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSerialNumber_A9122.UIName;
			}
		}

		// Token: 0x170024CC RID: 9420
		// (get) Token: 0x0600479C RID: 18332 RVA: 0x00424660 File Offset: 0x00422860
		// (set) Token: 0x0600479D RID: 18333 RVA: 0x00424714 File Offset: 0x00422914
		internal bool RadInfoGeneralSerialNumber_A9122_HiddenStatic
		{
			get
			{
				short num = (short)2018414042;
				short num2 = num;
				num = (short)745377242;
				switch (num2 == num)
				{
				}
				num = (short)1992163329;
				if (num != 0)
				{
				}
				num = (short)902955008;
				short num3 = num;
				num = (short)1847197696;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSerialNumber_A9122.HiddenStatic;
			}
			set
			{
				short num = (short)362312012;
				short num2 = num;
				num = (short)2078306636;
				switch (num2 == num)
				{
				}
				num = (short)883687425;
				if (num != 0)
				{
				}
				num = (short)17891328;
				short num3 = num;
				num = (short)1292173312;
				if (num != 0)
				{
				}
				this.radInfoGeneralSerialNumber_A9122.HiddenStatic = value;
			}
		}

		// Token: 0x170024CD RID: 9421
		// (get) Token: 0x0600479E RID: 18334 RVA: 0x004247C8 File Offset: 0x004229C8
		// (set) Token: 0x0600479F RID: 18335 RVA: 0x0042487C File Offset: 0x00422A7C
		internal bool RadInfoGeneralSerialNumber_A9122_HiddenDynamic
		{
			get
			{
				short num = (short)1863552539;
				short num2 = num;
				num = (short)102665755;
				switch (num2 == num)
				{
				}
				num = (short)994902017;
				if (num != 0)
				{
				}
				num = (short)331677696;
				short num3 = num;
				num = (short)1313538048;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSerialNumber_A9122.HiddenDynamic;
			}
			set
			{
				short num = (short)1733614668;
				short num2 = num;
				num = (short)623303756;
				switch (num2 == num)
				{
				}
				num = (short)711131137;
				if (num != 0)
				{
				}
				num = (short)1954545664;
				short num3 = num;
				num = (short)2125201408;
				if (num != 0)
				{
				}
				this.radInfoGeneralSerialNumber_A9122.HiddenDynamic = value;
			}
		}

		// Token: 0x170024CE RID: 9422
		// (get) Token: 0x060047A0 RID: 18336 RVA: 0x00424930 File Offset: 0x00422B30
		public bool RadInfoGeneralSerialNumber_A9122_HasDiffs
		{
			get
			{
				short num = (short)1772617729;
				if (num != 0)
				{
				}
				num = (short)958051780;
				short num2 = num;
				num = (short)1437185476;
				switch (num2 == num)
				{
				}
				num = (short)159318016;
				short num3 = num;
				num = (short)206372864;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSerialNumber_A9122._HasDiffs;
			}
		}

		// Token: 0x170024CF RID: 9423
		// (get) Token: 0x060047A1 RID: 18337 RVA: 0x004249E4 File Offset: 0x00422BE4
		// (set) Token: 0x060047A2 RID: 18338 RVA: 0x00424A98 File Offset: 0x00422C98
		public string RadInfoGeneralTuningVersion_A9509Value
		{
			get
			{
				short num = (short)1593192698;
				short num2 = num;
				num = (short)2083598586;
				switch (num2 == num)
				{
				}
				num = (short)1948254209;
				if (num != 0)
				{
				}
				num = (short)613941248;
				short num3 = num;
				num = (short)1928593408;
				if (num != 0)
				{
				}
				return this.radInfoGeneralTuningVersion_A9509.Value;
			}
			set
			{
				short num = (short)348360097;
				short num2 = num;
				num = (short)1390579105;
				switch (num2 == num)
				{
				}
				num = (short)1262419968;
				if (num != 0)
				{
				}
				num = (short)1307443200;
				short num3 = num;
				num = (short)1780940801;
				if (num != 0)
				{
				}
				this.radInfoGeneralTuningVersion_A9509.Value = value;
			}
		}

		// Token: 0x170024D0 RID: 9424
		// (get) Token: 0x060047A3 RID: 18339 RVA: 0x00424B4C File Offset: 0x00422D4C
		public global::AcpBusinessLayer.AcpField<string> RadInfoGeneralTuningVersion_A9509
		{
			get
			{
				short num = (short)1864348762;
				short num2 = num;
				num = (short)1888924762;
				switch (num2 == num)
				{
				}
				num = (short)857538561;
				if (num != 0)
				{
				}
				num = (short)1710424064;
				short num3 = num;
				num = (short)1024000000;
				if (num != 0)
				{
				}
				return this.radInfoGeneralTuningVersion_A9509;
			}
		}

		// Token: 0x170024D1 RID: 9425
		// (get) Token: 0x060047A4 RID: 18340 RVA: 0x00424C00 File Offset: 0x00422E00
		// (set) Token: 0x060047A5 RID: 18341 RVA: 0x00424CB4 File Offset: 0x00422EB4
		public string RadInfoGeneralTuningVersion_A9509_UIValue
		{
			get
			{
				short num = (short)430450632;
				short num2 = num;
				num = (short)1332357064;
				switch (num2 == num)
				{
				}
				num = (short)15466496;
				if (num != 0)
				{
				}
				num = (short)1331888128;
				short num3 = num;
				num = (short)719388673;
				if (num != 0)
				{
				}
				return this.radInfoGeneralTuningVersion_A9509.Value;
			}
			set
			{
				short num = (short)974558955;
				short num2 = num;
				num = (short)1198495467;
				switch (num2 == num)
				{
				}
				num = (short)271974400;
				if (num != 0)
				{
				}
				num = (short)651755520;
				short num3 = num;
				num = (short)1171193857;
				if (num != 0)
				{
				}
				this.radInfoGeneralTuningVersion_A9509.Value = value;
			}
		}

		// Token: 0x170024D2 RID: 9426
		// (get) Token: 0x060047A6 RID: 18342 RVA: 0x00424D68 File Offset: 0x00422F68
		// (set) Token: 0x060047A7 RID: 18343 RVA: 0x00424E1C File Offset: 0x0042301C
		public bool RadInfoGeneralTuningVersion_A9509_Applicable
		{
			get
			{
				short num = (short)845111741;
				short num2 = num;
				num = (short)635658685;
				switch (num2 == num)
				{
				}
				num = (short)575340544;
				if (num != 0)
				{
				}
				num = (short)766181376;
				short num3 = num;
				num = (short)1818820609;
				if (num != 0)
				{
				}
				return this.radInfoGeneralTuningVersion_A9509.Applicable;
			}
			set
			{
				short num = (short)418458294;
				short num2 = num;
				num = (short)982657718;
				switch (num2 == num)
				{
				}
				num = (short)326172672;
				if (num != 0)
				{
				}
				num = (short)2135621632;
				short num3 = num;
				num = (short)1055391745;
				if (num != 0)
				{
				}
				this.radInfoGeneralTuningVersion_A9509.Applicable = value;
			}
		}

		// Token: 0x170024D3 RID: 9427
		// (get) Token: 0x060047A8 RID: 18344 RVA: 0x00424ED4 File Offset: 0x004230D4
		// (set) Token: 0x060047A9 RID: 18345 RVA: 0x00424F88 File Offset: 0x00423188
		public bool RadInfoGeneralTuningVersion_A9509_Valid
		{
			get
			{
				short num = (short)791608018;
				short num2 = num;
				num = (short)625867474;
				switch (num2 == num)
				{
				}
				num = (short)1400111105;
				if (num != 0)
				{
				}
				num = (short)290652160;
				short num3 = num;
				num = (short)1104936960;
				if (num != 0)
				{
				}
				return this.radInfoGeneralTuningVersion_A9509.Valid;
			}
			set
			{
				short num = (short)1038219688;
				short num2 = num;
				num = (short)1737816488;
				switch (num2 == num)
				{
				}
				num = (short)1726611456;
				if (num != 0)
				{
				}
				num = (short)845283329;
				if (num != 0)
				{
				}
				num = (short)604897280;
				short num3 = num;
				this.radInfoGeneralTuningVersion_A9509.Valid = value;
			}
		}

		// Token: 0x170024D4 RID: 9428
		// (get) Token: 0x060047AA RID: 18346 RVA: 0x00425044 File Offset: 0x00423244
		// (set) Token: 0x060047AB RID: 18347 RVA: 0x004250F8 File Offset: 0x004232F8
		public bool RadInfoGeneralTuningVersion_A9509_Visible
		{
			get
			{
				short num = (short)535704825;
				short num2 = num;
				num = (short)1225209081;
				switch (num2 == num)
				{
				}
				num = (short)260833281;
				if (num != 0)
				{
				}
				num = (short)86900736;
				if (num != 0)
				{
				}
				num = (short)1049231360;
				short num3 = num;
				return this.radInfoGeneralTuningVersion_A9509.Visible;
			}
			set
			{
				short num = (short)1330176046;
				short num2 = num;
				num = (short)1740496942;
				switch (num2 == num)
				{
				}
				num = (short)1163198465;
				if (num != 0)
				{
				}
				num = (short)1371996160;
				if (num != 0)
				{
				}
				num = (short)756875264;
				short num3 = num;
				this.radInfoGeneralTuningVersion_A9509.Visible = value;
			}
		}

		// Token: 0x170024D5 RID: 9429
		// (get) Token: 0x060047AC RID: 18348 RVA: 0x004251B0 File Offset: 0x004233B0
		// (set) Token: 0x060047AD RID: 18349 RVA: 0x00425264 File Offset: 0x00423464
		public bool RadInfoGeneralTuningVersion_A9509_Editable
		{
			get
			{
				short num = (short)343854937;
				short num2 = num;
				num = (short)497143641;
				switch (num2 == num)
				{
				}
				num = (short)1237975040;
				if (num != 0)
				{
				}
				num = (short)1972895745;
				if (num != 0)
				{
				}
				num = (short)1027866624;
				short num3 = num;
				return this.radInfoGeneralTuningVersion_A9509.Editable;
			}
			set
			{
				short num = (short)1681777475;
				short num2 = num;
				num = (short)1607328579;
				switch (num2 == num)
				{
				}
				num = (short)1513488384;
				if (num != 0)
				{
				}
				num = (short)1208877057;
				if (num != 0)
				{
				}
				num = (short)1378418688;
				short num3 = num;
				this.radInfoGeneralTuningVersion_A9509.Editable = value;
			}
		}

		// Token: 0x170024D6 RID: 9430
		// (get) Token: 0x060047AE RID: 18350 RVA: 0x0042531C File Offset: 0x0042351C
		internal string RadInfoGeneralTuningVersion_A9509_UILabel
		{
			get
			{
				short num = (short)1184759809;
				if (num != 0)
				{
				}
				num = (short)507195527;
				short num2 = num;
				num = (short)744239239;
				switch (num2 == num)
				{
				}
				num = (short)1978204160;
				if (num != 0)
				{
				}
				num = (short)1012400128;
				short num3 = num;
				return this.radInfoGeneralTuningVersion_A9509.UIName;
			}
		}

		// Token: 0x170024D7 RID: 9431
		// (get) Token: 0x060047AF RID: 18351 RVA: 0x004253D0 File Offset: 0x004235D0
		// (set) Token: 0x060047B0 RID: 18352 RVA: 0x00425484 File Offset: 0x00423684
		internal bool RadInfoGeneralTuningVersion_A9509_HiddenStatic
		{
			get
			{
				short num = (short)1912407900;
				short num2 = num;
				num = (short)2067662684;
				switch (num2 == num)
				{
				}
				num = (short)2099380225;
				if (num != 0)
				{
				}
				num = (short)96796672;
				if (num != 0)
				{
				}
				num = (short)1402470400;
				short num3 = num;
				return this.radInfoGeneralTuningVersion_A9509.HiddenStatic;
			}
			set
			{
				short num = (short)1120593873;
				short num2 = num;
				num = (short)623306705;
				switch (num2 == num)
				{
				}
				num = (short)1924464641;
				if (num != 0)
				{
				}
				num = (short)326434816;
				if (num != 0)
				{
				}
				num = (short)1704198144;
				short num3 = num;
				this.radInfoGeneralTuningVersion_A9509.HiddenStatic = value;
			}
		}

		// Token: 0x170024D8 RID: 9432
		// (get) Token: 0x060047B1 RID: 18353 RVA: 0x0042553C File Offset: 0x0042373C
		// (set) Token: 0x060047B2 RID: 18354 RVA: 0x004255F0 File Offset: 0x004237F0
		internal bool RadInfoGeneralTuningVersion_A9509_HiddenDynamic
		{
			get
			{
				short num = (short)1336147969;
				if (num != 0)
				{
				}
				num = (short)1093440947;
				short num2 = num;
				num = (short)740660659;
				switch (num2 == num)
				{
				}
				num = (short)1055719424;
				if (num != 0)
				{
				}
				num = (short)1552154624;
				short num3 = num;
				return this.radInfoGeneralTuningVersion_A9509.HiddenDynamic;
			}
			set
			{
				short num = (short)522397132;
				short num2 = num;
				num = (short)119219660;
				switch (num2 == num)
				{
				}
				num = (short)2091712513;
				if (num != 0)
				{
				}
				num = (short)1869676544;
				if (num != 0)
				{
				}
				num = (short)839057408;
				short num3 = num;
				this.radInfoGeneralTuningVersion_A9509.HiddenDynamic = value;
			}
		}

		// Token: 0x170024D9 RID: 9433
		// (get) Token: 0x060047B3 RID: 18355 RVA: 0x004256A8 File Offset: 0x004238A8
		public bool RadInfoGeneralTuningVersion_A9509_HasDiffs
		{
			get
			{
				short num = (short)661883991;
				short num2 = num;
				num = (short)1846971479;
				switch (num2 == num)
				{
				}
				num = (short)409600000;
				if (num != 0)
				{
				}
				num = (short)1735720961;
				if (num != 0)
				{
				}
				num = (short)2143092736;
				short num3 = num;
				return this.radInfoGeneralTuningVersion_A9509._HasDiffs;
			}
		}

		// Token: 0x170024DA RID: 9434
		// (get) Token: 0x060047B4 RID: 18356 RVA: 0x0042575C File Offset: 0x0042395C
		// (set) Token: 0x060047B5 RID: 18357 RVA: 0x00425810 File Offset: 0x00423A10
		public int RadInfoGeneralMaximumChannels_A11479Value
		{
			get
			{
				short num = (short)409332184;
				short num2 = num;
				num = (short)502589912;
				switch (num2 == num)
				{
				}
				num = (short)1149501440;
				if (num != 0)
				{
				}
				num = (short)436862977;
				if (num != 0)
				{
				}
				num = (short)1082785792;
				short num3 = num;
				return this.radInfoGeneralMaximumChannels_A11479.Value;
			}
			set
			{
				short num = (short)475962046;
				short num2 = num;
				num = (short)1686608574;
				switch (num2 == num)
				{
				}
				num = (short)644349953;
				if (num != 0)
				{
				}
				num = (short)616693760;
				if (num != 0)
				{
				}
				num = (short)363397120;
				short num3 = num;
				this.radInfoGeneralMaximumChannels_A11479.Value = value;
			}
		}

		// Token: 0x170024DB RID: 9435
		// (get) Token: 0x060047B6 RID: 18358 RVA: 0x004258C4 File Offset: 0x00423AC4
		public global::AcpBusinessLayer.AcpSimpleRangeField RadInfoGeneralMaximumChannels_A11479
		{
			get
			{
				short num = (short)1828724728;
				short num2 = num;
				num = (short)1622941688;
				switch (num2 == num)
				{
				}
				num = (short)1172111360;
				if (num != 0)
				{
				}
				num = (short)1463353345;
				if (num != 0)
				{
				}
				num = (short)1125908480;
				short num3 = num;
				return this.radInfoGeneralMaximumChannels_A11479;
			}
		}

		// Token: 0x170024DC RID: 9436
		// (get) Token: 0x060047B7 RID: 18359 RVA: 0x00425974 File Offset: 0x00423B74
		// (set) Token: 0x060047B8 RID: 18360 RVA: 0x00425A28 File Offset: 0x00423C28
		public string RadInfoGeneralMaximumChannels_A11479_UIValue
		{
			get
			{
				short num = (short)888705498;
				short num2 = num;
				num = (short)2128646618;
				switch (num2 == num)
				{
				}
				num = (short)2020081665;
				if (num != 0)
				{
				}
				num = (short)1696268288;
				if (num != 0)
				{
				}
				num = (short)372834304;
				short num3 = num;
				return this.radInfoGeneralMaximumChannels_A11479.UIValue;
			}
			set
			{
				short num = (short)2025978369;
				short num2 = num;
				num = (short)1159330305;
				switch (num2 == num)
				{
				}
				num = (short)287637505;
				if (num != 0)
				{
				}
				num = (short)2117206016;
				if (num != 0)
				{
				}
				num = (short)2051538944;
				short num3 = num;
				this.radInfoGeneralMaximumChannels_A11479.UIValue = value;
			}
		}

		// Token: 0x170024DD RID: 9437
		// (get) Token: 0x060047B9 RID: 18361 RVA: 0x00425AE0 File Offset: 0x00423CE0
		// (set) Token: 0x060047BA RID: 18362 RVA: 0x00425B98 File Offset: 0x00423D98
		internal int RadInfoGeneralMaximumChannels_A11479Min
		{
			get
			{
				short num = (short)840761345;
				if (num != 0)
				{
				}
				num = (short)1224663267;
				short num2 = num;
				num = (short)1290854627;
				switch (num2 == num)
				{
				}
				num = (short)1140523008;
				if (num != 0)
				{
				}
				num = (short)693567488;
				short num3 = num;
				return this.radInfoGeneralMaximumChannels_A11479.Min;
			}
			set
			{
				short num = (short)289778080;
				short num2 = num;
				num = (short)1860938144;
				switch (num2 == num)
				{
				}
				num = (short)833224705;
				if (num != 0)
				{
				}
				num = (short)1888550912;
				if (num != 0)
				{
				}
				num = (short)217448448;
				short num3 = num;
				this.radInfoGeneralMaximumChannels_A11479.Min = value;
			}
		}

		// Token: 0x170024DE RID: 9438
		// (get) Token: 0x060047BB RID: 18363 RVA: 0x00425C4C File Offset: 0x00423E4C
		// (set) Token: 0x060047BC RID: 18364 RVA: 0x00425D04 File Offset: 0x00423F04
		internal int RadInfoGeneralMaximumChannels_A11479Max
		{
			get
			{
				short num = (short)1520699799;
				short num2 = num;
				num = (short)1966279063;
				switch (num2 == num)
				{
				}
				num = (short)1596981249;
				if (num != 0)
				{
				}
				num = (short)31195136;
				if (num != 0)
				{
				}
				num = (short)1600258048;
				short num3 = num;
				return this.radInfoGeneralMaximumChannels_A11479.Max;
			}
			set
			{
				short num = (short)2057189415;
				short num2 = num;
				num = (short)204814375;
				switch (num2 == num)
				{
				}
				num = (short)790691841;
				if (num != 0)
				{
				}
				num = (short)2026110976;
				if (num != 0)
				{
				}
				num = (short)1534525440;
				short num3 = num;
				this.radInfoGeneralMaximumChannels_A11479.Max = value;
			}
		}

		// Token: 0x170024DF RID: 9439
		// (get) Token: 0x060047BD RID: 18365 RVA: 0x00425DB8 File Offset: 0x00423FB8
		// (set) Token: 0x060047BE RID: 18366 RVA: 0x00425E6C File Offset: 0x0042406C
		internal int RadInfoGeneralMaximumChannels_A11479Step
		{
			get
			{
				short num = (short)1757458374;
				short num2 = num;
				num = (short)1308078022;
				switch (num2 == num)
				{
				}
				num = (short)794951681;
				if (num != 0)
				{
				}
				num = (short)449118208;
				if (num != 0)
				{
				}
				num = (short)889913344;
				short num3 = num;
				return this.radInfoGeneralMaximumChannels_A11479.StepSize;
			}
			set
			{
				short num = (short)1311899649;
				if (num != 0)
				{
				}
				num = (short)519170314;
				short num2 = num;
				num = (short)2145970442;
				switch (num2 == num)
				{
				}
				num = (short)806813696;
				if (num != 0)
				{
				}
				num = (short)9437184;
				short num3 = num;
				this.radInfoGeneralMaximumChannels_A11479.StepSize = value;
			}
		}

		// Token: 0x170024E0 RID: 9440
		// (get) Token: 0x060047BF RID: 18367 RVA: 0x00425F24 File Offset: 0x00424124
		// (set) Token: 0x060047C0 RID: 18368 RVA: 0x00425FD8 File Offset: 0x004241D8
		public bool RadInfoGeneralMaximumChannels_A11479_Applicable
		{
			get
			{
				short num = (short)1989083137;
				if (num != 0)
				{
				}
				num = (short)845494826;
				short num2 = num;
				num = (short)47790634;
				switch (num2 == num)
				{
				}
				num = (short)1106771968;
				if (num != 0)
				{
				}
				num = (short)1743978496;
				short num3 = num;
				return this.radInfoGeneralMaximumChannels_A11479.Applicable;
			}
			set
			{
				short num = (short)2028324963;
				short num2 = num;
				num = (short)1076611171;
				switch (num2 == num)
				{
				}
				num = (short)239403009;
				if (num != 0)
				{
				}
				num = (short)1195048960;
				if (num != 0)
				{
				}
				num = (short)649330688;
				short num3 = num;
				this.radInfoGeneralMaximumChannels_A11479.Applicable = value;
			}
		}

		// Token: 0x170024E1 RID: 9441
		// (get) Token: 0x060047C1 RID: 18369 RVA: 0x0042608C File Offset: 0x0042428C
		// (set) Token: 0x060047C2 RID: 18370 RVA: 0x00426140 File Offset: 0x00424340
		public bool RadInfoGeneralMaximumChannels_A11479_Valid
		{
			get
			{
				short num = (short)377903242;
				short num2 = num;
				num = (short)1465407626;
				switch (num2 == num)
				{
				}
				num = (short)298647553;
				if (num != 0)
				{
				}
				num = (short)1396965376;
				if (num != 0)
				{
				}
				num = (short)1859321856;
				short num3 = num;
				return this.radInfoGeneralMaximumChannels_A11479.Valid;
			}
			set
			{
				short num = (short)1759945447;
				short num2 = num;
				num = (short)662282983;
				switch (num2 == num)
				{
				}
				num = (short)1768292353;
				if (num != 0)
				{
				}
				num = (short)441122816;
				if (num != 0)
				{
				}
				num = (short)2070282240;
				short num3 = num;
				this.radInfoGeneralMaximumChannels_A11479.Valid = value;
			}
		}

		// Token: 0x170024E2 RID: 9442
		// (get) Token: 0x060047C3 RID: 18371 RVA: 0x004261F4 File Offset: 0x004243F4
		// (set) Token: 0x060047C4 RID: 18372 RVA: 0x004262A8 File Offset: 0x004244A8
		public bool RadInfoGeneralMaximumChannels_A11479_Visible
		{
			get
			{
				short num = (short)1540999245;
				short num2 = num;
				num = (short)2061551693;
				switch (num2 == num)
				{
				}
				num = (short)1026162689;
				if (num != 0)
				{
				}
				num = (short)1589379072;
				if (num != 0)
				{
				}
				num = (short)2123497472;
				short num3 = num;
				return this.radInfoGeneralMaximumChannels_A11479.Visible;
			}
			set
			{
				short num = (short)1186679532;
				short num2 = num;
				num = (short)1906330348;
				switch (num2 == num)
				{
				}
				num = (short)1391001601;
				if (num != 0)
				{
				}
				num = (short)181600256;
				if (num != 0)
				{
				}
				num = (short)1496907776;
				short num3 = num;
				this.radInfoGeneralMaximumChannels_A11479.Visible = value;
			}
		}

		// Token: 0x170024E3 RID: 9443
		// (get) Token: 0x060047C5 RID: 18373 RVA: 0x00426360 File Offset: 0x00424560
		// (set) Token: 0x060047C6 RID: 18374 RVA: 0x00426414 File Offset: 0x00424614
		public bool RadInfoGeneralMaximumChannels_A11479_Editable
		{
			get
			{
				short num = (short)1336065815;
				short num2 = num;
				num = (short)1228979991;
				switch (num2 == num)
				{
				}
				num = (short)1808793601;
				if (num != 0)
				{
				}
				num = (short)389414912;
				if (num != 0)
				{
				}
				num = (short)955121664;
				short num3 = num;
				return this.radInfoGeneralMaximumChannels_A11479.Editable;
			}
			set
			{
				short num = (short)619487379;
				short num2 = num;
				num = (short)1075552403;
				switch (num2 == num)
				{
				}
				num = (short)1546125312;
				if (num != 0)
				{
				}
				num = (short)171769857;
				if (num != 0)
				{
				}
				num = (short)1719205888;
				short num3 = num;
				this.radInfoGeneralMaximumChannels_A11479.Editable = value;
			}
		}

		// Token: 0x170024E4 RID: 9444
		// (get) Token: 0x060047C7 RID: 18375 RVA: 0x004264CC File Offset: 0x004246CC
		internal string RadInfoGeneralMaximumChannels_A11479_UILabel
		{
			get
			{
				short num = (short)1747341968;
				short num2 = num;
				num = (short)2096255632;
				switch (num2 == num)
				{
				}
				num = (short)565248000;
				if (num != 0)
				{
				}
				num = (short)539885569;
				if (num != 0)
				{
				}
				num = (short)1107230720;
				short num3 = num;
				return this.radInfoGeneralMaximumChannels_A11479.UIName;
			}
		}

		// Token: 0x170024E5 RID: 9445
		// (get) Token: 0x060047C8 RID: 18376 RVA: 0x00426580 File Offset: 0x00424780
		// (set) Token: 0x060047C9 RID: 18377 RVA: 0x00426634 File Offset: 0x00424834
		internal bool RadInfoGeneralMaximumChannels_A11479_HiddenStatic
		{
			get
			{
				short num = (short)1519215125;
				short num2 = num;
				num = (short)632119829;
				switch (num2 == num)
				{
				}
				num = (short)1466695680;
				if (num != 0)
				{
				}
				num = (short)1621884929;
				if (num != 0)
				{
				}
				num = (short)1769668608;
				short num3 = num;
				return this.radInfoGeneralMaximumChannels_A11479.HiddenStatic;
			}
			set
			{
				short num = (short)549584897;
				if (num != 0)
				{
				}
				num = (short)364162415;
				short num2 = num;
				num = (short)2110172527;
				switch (num2 == num)
				{
				}
				num = (short)1162936320;
				if (num != 0)
				{
				}
				num = (short)1741815808;
				short num3 = num;
				this.radInfoGeneralMaximumChannels_A11479.HiddenStatic = value;
			}
		}

		// Token: 0x170024E6 RID: 9446
		// (get) Token: 0x060047CA RID: 18378 RVA: 0x004266E8 File Offset: 0x004248E8
		// (set) Token: 0x060047CB RID: 18379 RVA: 0x004267A0 File Offset: 0x004249A0
		internal bool RadInfoGeneralMaximumChannels_A11479_HiddenDynamic
		{
			get
			{
				short num = (short)1853757997;
				short num2 = num;
				num = (short)1942952493;
				switch (num2 == num)
				{
				}
				num = (short)1201995777;
				if (num != 0)
				{
				}
				num = (short)1552547840;
				if (num != 0)
				{
				}
				num = (short)521273344;
				short num3 = num;
				return this.radInfoGeneralMaximumChannels_A11479.HiddenDynamic;
			}
			set
			{
				short num = (short)1437021595;
				short num2 = num;
				num = (short)1392457115;
				switch (num2 == num)
				{
				}
				num = (short)91422720;
				if (num != 0)
				{
				}
				num = (short)825753601;
				if (num != 0)
				{
				}
				num = (short)2139881472;
				short num3 = num;
				this.radInfoGeneralMaximumChannels_A11479.HiddenDynamic = value;
			}
		}

		// Token: 0x170024E7 RID: 9447
		// (get) Token: 0x060047CC RID: 18380 RVA: 0x00426854 File Offset: 0x00424A54
		public bool RadInfoGeneralMaximumChannels_A11479_HasDiffs
		{
			get
			{
				short num = (short)1068040193;
				if (num != 0)
				{
				}
				num = (short)1120278860;
				short num2 = num;
				num = (short)1512315212;
				switch (num2 == num)
				{
				}
				num = (short)244514816;
				if (num != 0)
				{
				}
				num = (short)633864192;
				short num3 = num;
				return this.radInfoGeneralMaximumChannels_A11479._HasDiffs;
			}
		}

		// Token: 0x170024E8 RID: 9448
		// (get) Token: 0x060047CD RID: 18381 RVA: 0x00426908 File Offset: 0x00424B08
		// (set) Token: 0x060047CE RID: 18382 RVA: 0x004269BC File Offset: 0x00424BBC
		public string RadInfoGeneralPrimaryFrequencyBand_A12713Value
		{
			get
			{
				short num = (short)8298003;
				short num2 = num;
				num = (short)750165523;
				switch (num2 == num)
				{
				}
				num = (short)848429056;
				if (num != 0)
				{
				}
				num = (short)264044545;
				if (num != 0)
				{
				}
				num = (short)694550528;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBand_A12713.Value;
			}
			set
			{
				short num = (short)783806079;
				short num2 = num;
				num = (short)1548152447;
				switch (num2 == num)
				{
				}
				num = (short)1903427584;
				if (num != 0)
				{
				}
				num = (short)1365835777;
				if (num != 0)
				{
				}
				num = (short)1438449664;
				short num3 = num;
				this.radInfoGeneralPrimaryFrequencyBand_A12713.Value = value;
			}
		}

		// Token: 0x170024E9 RID: 9449
		// (get) Token: 0x060047CF RID: 18383 RVA: 0x00426A74 File Offset: 0x00424C74
		public global::AcpBusinessLayer.AcpField<string> RadInfoGeneralPrimaryFrequencyBand_A12713
		{
			get
			{
				short num = (short)20472049;
				short num2 = num;
				num = (short)1460887793;
				switch (num2 == num)
				{
				}
				num = (short)1458831361;
				if (num != 0)
				{
				}
				num = (short)1423507456;
				if (num != 0)
				{
				}
				num = (short)1981022208;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBand_A12713;
			}
		}

		// Token: 0x170024EA RID: 9450
		// (get) Token: 0x060047D0 RID: 18384 RVA: 0x00426B24 File Offset: 0x00424D24
		// (set) Token: 0x060047D1 RID: 18385 RVA: 0x00426BDC File Offset: 0x00424DDC
		public string RadInfoGeneralPrimaryFrequencyBand_A12713_UIValue
		{
			get
			{
				short num = (short)1701544230;
				short num2 = num;
				num = (short)898859302;
				switch (num2 == num)
				{
				}
				num = (short)2110259201;
				if (num != 0)
				{
				}
				num = (short)910032896;
				if (num != 0)
				{
				}
				num = (short)1026818048;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBand_A12713.Value;
			}
			set
			{
				short num = (short)1183977650;
				short num2 = num;
				num = (short)1127289010;
				switch (num2 == num)
				{
				}
				num = (short)603914240;
				if (num != 0)
				{
				}
				num = (short)812711937;
				if (num != 0)
				{
				}
				num = (short)68681728;
				short num3 = num;
				this.radInfoGeneralPrimaryFrequencyBand_A12713.Value = value;
			}
		}

		// Token: 0x170024EB RID: 9451
		// (get) Token: 0x060047D2 RID: 18386 RVA: 0x00426C90 File Offset: 0x00424E90
		// (set) Token: 0x060047D3 RID: 18387 RVA: 0x00426D48 File Offset: 0x00424F48
		public bool RadInfoGeneralPrimaryFrequencyBand_A12713_Applicable
		{
			get
			{
				short num = (short)2110480455;
				short num2 = num;
				num = (short)612065351;
				switch (num2 == num)
				{
				}
				num = (short)1899036672;
				if (num != 0)
				{
				}
				num = (short)729481217;
				if (num != 0)
				{
				}
				num = (short)772079616;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBand_A12713.Applicable;
			}
			set
			{
				short num = (short)5240870;
				short num2 = num;
				num = (short)695924774;
				switch (num2 == num)
				{
				}
				num = (short)1072168961;
				if (num != 0)
				{
				}
				num = (short)1763180544;
				if (num != 0)
				{
				}
				num = (short)1934622720;
				short num3 = num;
				this.radInfoGeneralPrimaryFrequencyBand_A12713.Applicable = value;
			}
		}

		// Token: 0x170024EC RID: 9452
		// (get) Token: 0x060047D4 RID: 18388 RVA: 0x00426E00 File Offset: 0x00425000
		// (set) Token: 0x060047D5 RID: 18389 RVA: 0x00426EB4 File Offset: 0x004250B4
		public bool RadInfoGeneralPrimaryFrequencyBand_A12713_Valid
		{
			get
			{
				short num = (short)1355893631;
				short num2 = num;
				num = (short)784485247;
				switch (num2 == num)
				{
				}
				num = (short)345309184;
				if (num != 0)
				{
				}
				num = (short)1291124737;
				if (num != 0)
				{
				}
				num = (short)2030239744;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBand_A12713.Valid;
			}
			set
			{
				short num = (short)337445316;
				short num2 = num;
				num = (short)1858011588;
				switch (num2 == num)
				{
				}
				num = (short)395378689;
				if (num != 0)
				{
				}
				num = (short)397082624;
				if (num != 0)
				{
				}
				num = (short)1194590208;
				short num3 = num;
				this.radInfoGeneralPrimaryFrequencyBand_A12713.Valid = value;
			}
		}

		// Token: 0x170024ED RID: 9453
		// (get) Token: 0x060047D6 RID: 18390 RVA: 0x00426F68 File Offset: 0x00425168
		// (set) Token: 0x060047D7 RID: 18391 RVA: 0x0042701C File Offset: 0x0042521C
		public bool RadInfoGeneralPrimaryFrequencyBand_A12713_Visible
		{
			get
			{
				short num = (short)712045172;
				short num2 = num;
				num = (short)305001076;
				switch (num2 == num)
				{
				}
				num = (short)266010625;
				if (num != 0)
				{
				}
				num = (short)2060517376;
				if (num != 0)
				{
				}
				num = (short)696057856;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBand_A12713.Visible;
			}
			set
			{
				short num = (short)1272716038;
				short num2 = num;
				num = (short)1497897734;
				switch (num2 == num)
				{
				}
				num = (short)1337196545;
				if (num != 0)
				{
				}
				num = (short)194379776;
				if (num != 0)
				{
				}
				num = (short)66912256;
				short num3 = num;
				this.radInfoGeneralPrimaryFrequencyBand_A12713.Visible = value;
			}
		}

		// Token: 0x170024EE RID: 9454
		// (get) Token: 0x060047D8 RID: 18392 RVA: 0x004270D4 File Offset: 0x004252D4
		// (set) Token: 0x060047D9 RID: 18393 RVA: 0x0042718C File Offset: 0x0042538C
		public bool RadInfoGeneralPrimaryFrequencyBand_A12713_Editable
		{
			get
			{
				short num = (short)1971392769;
				short num2 = num;
				num = (short)199168257;
				switch (num2 == num)
				{
				}
				num = (short)1157693441;
				if (num != 0)
				{
				}
				num = (short)643497984;
				if (num != 0)
				{
				}
				num = (short)1466564608;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBand_A12713.Editable;
			}
			set
			{
				short num = (short)474741703;
				short num2 = num;
				num = (short)786496455;
				switch (num2 == num)
				{
				}
				num = (short)1122566145;
				if (num != 0)
				{
				}
				num = (short)2070478848;
				if (num != 0)
				{
				}
				num = (short)796131328;
				short num3 = num;
				this.radInfoGeneralPrimaryFrequencyBand_A12713.Editable = value;
			}
		}

		// Token: 0x170024EF RID: 9455
		// (get) Token: 0x060047DA RID: 18394 RVA: 0x00427240 File Offset: 0x00425440
		internal string RadInfoGeneralPrimaryFrequencyBand_A12713_UILabel
		{
			get
			{
				short num = (short)623688280;
				short num2 = num;
				num = (short)581089880;
				switch (num2 == num)
				{
				}
				num = (short)1625489408;
				if (num != 0)
				{
				}
				num = (short)909901825;
				if (num != 0)
				{
				}
				num = (short)1608974336;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBand_A12713.UIName;
			}
		}

		// Token: 0x170024F0 RID: 9456
		// (get) Token: 0x060047DB RID: 18395 RVA: 0x004272F4 File Offset: 0x004254F4
		// (set) Token: 0x060047DC RID: 18396 RVA: 0x004273A8 File Offset: 0x004255A8
		internal bool RadInfoGeneralPrimaryFrequencyBand_A12713_HiddenStatic
		{
			get
			{
				short num = (short)893667045;
				short num2 = num;
				num = (short)718358245;
				switch (num2 == num)
				{
				}
				num = (short)1708261377;
				if (num != 0)
				{
				}
				num = (short)371785728;
				if (num != 0)
				{
				}
				num = (short)1162215424;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBand_A12713.HiddenStatic;
			}
			set
			{
				short num = (short)974187850;
				short num2 = num;
				num = (short)2003692874;
				switch (num2 == num)
				{
				}
				num = (short)118685697;
				if (num != 0)
				{
				}
				num = (short)1996881920;
				if (num != 0)
				{
				}
				num = (short)1475149824;
				short num3 = num;
				this.radInfoGeneralPrimaryFrequencyBand_A12713.HiddenStatic = value;
			}
		}

		// Token: 0x170024F1 RID: 9457
		// (get) Token: 0x060047DD RID: 18397 RVA: 0x00427460 File Offset: 0x00425660
		// (set) Token: 0x060047DE RID: 18398 RVA: 0x00427518 File Offset: 0x00425718
		internal bool RadInfoGeneralPrimaryFrequencyBand_A12713_HiddenDynamic
		{
			get
			{
				short num = (short)234706981;
				short num2 = num;
				num = (short)2085574693;
				switch (num2 == num)
				{
				}
				num = (short)1148321793;
				if (num != 0)
				{
				}
				num = (short)1658781696;
				if (num != 0)
				{
				}
				num = (short)220397568;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBand_A12713.HiddenDynamic;
			}
			set
			{
				short num = (short)1049752206;
				short num2 = num;
				num = (short)989524622;
				switch (num2 == num)
				{
				}
				num = (short)1807941633;
				if (num != 0)
				{
				}
				num = (short)469237760;
				if (num != 0)
				{
				}
				num = (short)2030960640;
				short num3 = num;
				this.radInfoGeneralPrimaryFrequencyBand_A12713.HiddenDynamic = value;
			}
		}

		// Token: 0x170024F2 RID: 9458
		// (get) Token: 0x060047DF RID: 18399 RVA: 0x004275CC File Offset: 0x004257CC
		public bool RadInfoGeneralPrimaryFrequencyBand_A12713_HasDiffs
		{
			get
			{
				short num = (short)1492667147;
				short num2 = num;
				num = (short)897665803;
				switch (num2 == num)
				{
				}
				num = (short)614662145;
				if (num != 0)
				{
				}
				num = (short)1053032448;
				if (num != 0)
				{
				}
				num = (short)118226944;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBand_A12713._HasDiffs;
			}
		}

		// Token: 0x170024F3 RID: 9459
		// (get) Token: 0x060047E0 RID: 18400 RVA: 0x00427684 File Offset: 0x00425884
		// (set) Token: 0x060047E1 RID: 18401 RVA: 0x0042773C File Offset: 0x0042593C
		public string RadInfoGeneralSecondaryFrequencyBand_A12715Value
		{
			get
			{
				short num = (short)1045041309;
				short num2 = num;
				num = (short)137236637;
				switch (num2 == num)
				{
				}
				num = (short)627638273;
				if (num != 0)
				{
				}
				num = (short)1311571968;
				if (num != 0)
				{
				}
				num = (short)1614151680;
				short num3 = num;
				return this.radInfoGeneralSecondaryFrequencyBand_A12715.Value;
			}
			set
			{
				short num = (short)765655758;
				short num2 = num;
				num = (short)1107950286;
				switch (num2 == num)
				{
				}
				num = (short)722010113;
				if (num != 0)
				{
				}
				num = (short)1345585152;
				if (num != 0)
				{
				}
				num = (short)560463872;
				short num3 = num;
				this.radInfoGeneralSecondaryFrequencyBand_A12715.Value = value;
			}
		}

		// Token: 0x170024F4 RID: 9460
		// (get) Token: 0x060047E2 RID: 18402 RVA: 0x004277F0 File Offset: 0x004259F0
		public global::AcpBusinessLayer.AcpField<string> RadInfoGeneralSecondaryFrequencyBand_A12715
		{
			get
			{
				short num = (short)1048319947;
				short num2 = num;
				num = (short)762058699;
				switch (num2 == num)
				{
				}
				num = (short)539820033;
				if (num != 0)
				{
				}
				num = (short)245301248;
				if (num != 0)
				{
				}
				num = (short)661061632;
				short num3 = num;
				return this.radInfoGeneralSecondaryFrequencyBand_A12715;
			}
		}

		// Token: 0x170024F5 RID: 9461
		// (get) Token: 0x060047E3 RID: 18403 RVA: 0x004278A4 File Offset: 0x00425AA4
		// (set) Token: 0x060047E4 RID: 18404 RVA: 0x0042795C File Offset: 0x00425B5C
		public string RadInfoGeneralSecondaryFrequencyBand_A12715_UIValue
		{
			get
			{
				short num = (short)1110704129;
				if (num != 0)
				{
				}
				num = (short)841512654;
				short num2 = num;
				num = (short)810251982;
				switch (num2 == num)
				{
				}
				num = (short)1317863424;
				if (num != 0)
				{
				}
				num = (short)1800077312;
				short num3 = num;
				return this.radInfoGeneralSecondaryFrequencyBand_A12715.Value;
			}
			set
			{
				short num = (short)906559489;
				if (num != 0)
				{
				}
				num = (short)2037727323;
				short num2 = num;
				num = (short)2111455323;
				switch (num2 == num)
				{
				}
				num = (short)1329266688;
				if (num != 0)
				{
				}
				num = (short)1095696384;
				short num3 = num;
				this.radInfoGeneralSecondaryFrequencyBand_A12715.Value = value;
			}
		}

		// Token: 0x170024F6 RID: 9462
		// (get) Token: 0x060047E5 RID: 18405 RVA: 0x00427A14 File Offset: 0x00425C14
		// (set) Token: 0x060047E6 RID: 18406 RVA: 0x00427ACC File Offset: 0x00425CCC
		public bool RadInfoGeneralSecondaryFrequencyBand_A12715_Applicable
		{
			get
			{
				short num = (short)1762355258;
				short num2 = num;
				num = (short)105670714;
				switch (num2 == num)
				{
				}
				num = (short)513277953;
				if (num != 0)
				{
				}
				num = (short)1293811712;
				if (num != 0)
				{
				}
				num = (short)881852416;
				short num3 = num;
				return this.radInfoGeneralSecondaryFrequencyBand_A12715.Applicable;
			}
			set
			{
				short num = (short)687062128;
				short num2 = num;
				num = (short)1094433904;
				switch (num2 == num)
				{
				}
				num = (short)1775894529;
				if (num != 0)
				{
				}
				num = (short)254214144;
				if (num != 0)
				{
				}
				num = (short)865206272;
				short num3 = num;
				this.radInfoGeneralSecondaryFrequencyBand_A12715.Applicable = value;
			}
		}

		// Token: 0x170024F7 RID: 9463
		// (get) Token: 0x060047E7 RID: 18407 RVA: 0x00427B80 File Offset: 0x00425D80
		// (set) Token: 0x060047E8 RID: 18408 RVA: 0x00427C30 File Offset: 0x00425E30
		public bool RadInfoGeneralSecondaryFrequencyBand_A12715_Valid
		{
			get
			{
				short num = (short)1261512890;
				short num2 = num;
				num = (short)853747898;
				switch (num2 == num)
				{
				}
				num = (short)1365245952;
				if (num != 0)
				{
				}
				num = (short)184352769;
				if (num != 0)
				{
				}
				num = (short)1942224896;
				short num3 = num;
				return this.radInfoGeneralSecondaryFrequencyBand_A12715.Valid;
			}
			set
			{
				short num = (short)1825568031;
				short num2 = num;
				num = (short)1871312159;
				switch (num2 == num)
				{
				}
				num = (short)2058289153;
				if (num != 0)
				{
				}
				num = (short)187170816;
				if (num != 0)
				{
				}
				num = (short)802160640;
				short num3 = num;
				this.radInfoGeneralSecondaryFrequencyBand_A12715.Valid = value;
			}
		}

		// Token: 0x170024F8 RID: 9464
		// (get) Token: 0x060047E9 RID: 18409 RVA: 0x00427CE4 File Offset: 0x00425EE4
		// (set) Token: 0x060047EA RID: 18410 RVA: 0x00427D98 File Offset: 0x00425F98
		public bool RadInfoGeneralSecondaryFrequencyBand_A12715_Visible
		{
			get
			{
				short num = (short)847893308;
				short num2 = num;
				num = (short)407229244;
				switch (num2 == num)
				{
				}
				num = (short)49676289;
				if (num != 0)
				{
				}
				num = (short)1689780224;
				if (num != 0)
				{
				}
				num = (short)1912864768;
				short num3 = num;
				return this.radInfoGeneralSecondaryFrequencyBand_A12715.Visible;
			}
			set
			{
				short num = (short)909584961;
				short num2 = num;
				num = (short)1285564993;
				switch (num2 == num)
				{
				}
				num = (short)1341128704;
				if (num != 0)
				{
				}
				num = (short)1416560641;
				if (num != 0)
				{
				}
				num = (short)225968128;
				short num3 = num;
				this.radInfoGeneralSecondaryFrequencyBand_A12715.Visible = value;
			}
		}

		// Token: 0x170024F9 RID: 9465
		// (get) Token: 0x060047EB RID: 18411 RVA: 0x00427E50 File Offset: 0x00426050
		// (set) Token: 0x060047EC RID: 18412 RVA: 0x00427F00 File Offset: 0x00426100
		public bool RadInfoGeneralSecondaryFrequencyBand_A12715_Editable
		{
			get
			{
				short num = (short)342572137;
				short num2 = num;
				num = (short)2122726505;
				switch (num2 == num)
				{
				}
				num = (short)856162304;
				if (num != 0)
				{
				}
				num = (short)857735169;
				if (num != 0)
				{
				}
				num = (short)971374592;
				short num3 = num;
				return this.radInfoGeneralSecondaryFrequencyBand_A12715.Editable;
			}
			set
			{
				short num = (short)1092485121;
				if (num != 0)
				{
				}
				num = (short)1152745616;
				short num2 = num;
				num = (short)868515984;
				switch (num2 == num)
				{
				}
				num = (short)1132855296;
				if (num != 0)
				{
				}
				num = (short)1182138368;
				short num3 = num;
				this.radInfoGeneralSecondaryFrequencyBand_A12715.Editable = value;
			}
		}

		// Token: 0x170024FA RID: 9466
		// (get) Token: 0x060047ED RID: 18413 RVA: 0x00427FB8 File Offset: 0x004261B8
		internal string RadInfoGeneralSecondaryFrequencyBand_A12715_UILabel
		{
			get
			{
				short num = (short)1128917597;
				short num2 = num;
				num = (short)1456204381;
				switch (num2 == num)
				{
				}
				num = (short)11206656;
				if (num != 0)
				{
				}
				num = (short)430571521;
				if (num != 0)
				{
				}
				num = (short)381943808;
				short num3 = num;
				return this.radInfoGeneralSecondaryFrequencyBand_A12715.UIName;
			}
		}

		// Token: 0x170024FB RID: 9467
		// (get) Token: 0x060047EE RID: 18414 RVA: 0x0042806C File Offset: 0x0042626C
		// (set) Token: 0x060047EF RID: 18415 RVA: 0x00428120 File Offset: 0x00426320
		internal bool RadInfoGeneralSecondaryFrequencyBand_A12715_HiddenStatic
		{
			get
			{
				short num = (short)718698637;
				short num2 = num;
				num = (short)1952807053;
				switch (num2 == num)
				{
				}
				num = (short)1615396865;
				if (num != 0)
				{
				}
				num = (short)2039873536;
				if (num != 0)
				{
				}
				num = (short)1372585984;
				short num3 = num;
				return this.radInfoGeneralSecondaryFrequencyBand_A12715.HiddenStatic;
			}
			set
			{
				short num = (short)1176722414;
				short num2 = num;
				num = (short)839343086;
				switch (num2 == num)
				{
				}
				num = (short)1395392513;
				if (num != 0)
				{
				}
				num = (short)284491776;
				if (num != 0)
				{
				}
				num = (short)2071920640;
				short num3 = num;
				this.radInfoGeneralSecondaryFrequencyBand_A12715.HiddenStatic = value;
			}
		}

		// Token: 0x170024FC RID: 9468
		// (get) Token: 0x060047F0 RID: 18416 RVA: 0x004281D4 File Offset: 0x004263D4
		// (set) Token: 0x060047F1 RID: 18417 RVA: 0x0042828C File Offset: 0x0042648C
		internal bool RadInfoGeneralSecondaryFrequencyBand_A12715_HiddenDynamic
		{
			get
			{
				short num = (short)894562915;
				short num2 = num;
				num = (short)2105799267;
				switch (num2 == num)
				{
				}
				num = (short)1690894337;
				if (num != 0)
				{
				}
				num = (short)2063400960;
				if (num != 0)
				{
				}
				num = (short)102957056;
				short num3 = num;
				return this.radInfoGeneralSecondaryFrequencyBand_A12715.HiddenDynamic;
			}
			set
			{
				short num = (short)238485505;
				if (num != 0)
				{
				}
				num = (short)1320765614;
				short num2 = num;
				num = (short)2136623278;
				switch (num2 == num)
				{
				}
				num = (short)375521280;
				if (num != 0)
				{
				}
				num = (short)106299392;
				short num3 = num;
				this.radInfoGeneralSecondaryFrequencyBand_A12715.HiddenDynamic = value;
			}
		}

		// Token: 0x170024FD RID: 9469
		// (get) Token: 0x060047F2 RID: 18418 RVA: 0x00428340 File Offset: 0x00426540
		public bool RadInfoGeneralSecondaryFrequencyBand_A12715_HasDiffs
		{
			get
			{
				short num = (short)1756364801;
				if (num != 0)
				{
				}
				num = (short)2061338737;
				short num2 = num;
				num = (short)584484977;
				switch (num2 == num)
				{
				}
				num = (short)1452408832;
				if (num != 0)
				{
				}
				num = (short)1157365760;
				short num3 = num;
				return this.radInfoGeneralSecondaryFrequencyBand_A12715._HasDiffs;
			}
		}

		// Token: 0x170024FE RID: 9470
		// (get) Token: 0x060047F3 RID: 18419 RVA: 0x004283F8 File Offset: 0x004265F8
		// (set) Token: 0x060047F4 RID: 18420 RVA: 0x004284AC File Offset: 0x004266AC
		public int RadInfoGeneralRegionalGovernance_A36710Value
		{
			get
			{
				short num = (short)913319797;
				short num2 = num;
				num = (short)1538598773;
				switch (num2 == num)
				{
				}
				num = (short)784138241;
				if (num != 0)
				{
				}
				num = (short)226623488;
				if (num != 0)
				{
				}
				num = (short)955777024;
				short num3 = num;
				return this.radInfoGeneralRegionalGovernance_A36710.Value;
			}
			set
			{
				short num = (short)1390038911;
				short num2 = num;
				num = (short)353783679;
				switch (num2 == num)
				{
				}
				num = (short)913244161;
				if (num != 0)
				{
				}
				num = (short)846987264;
				if (num != 0)
				{
				}
				num = (short)500760576;
				short num3 = num;
				this.radInfoGeneralRegionalGovernance_A36710.Value = value;
			}
		}

		// Token: 0x170024FF RID: 9471
		// (get) Token: 0x060047F5 RID: 18421 RVA: 0x00428560 File Offset: 0x00426760
		// (set) Token: 0x060047F6 RID: 18422 RVA: 0x00428614 File Offset: 0x00426814
		public string RadInfoGeneralRegionalGovernance_A36710_UIValue
		{
			get
			{
				short num = (short)1695281380;
				short num2 = num;
				num = (short)553447652;
				switch (num2 == num)
				{
				}
				num = (short)978190337;
				if (num != 0)
				{
				}
				num = (short)1220673536;
				if (num != 0)
				{
				}
				num = (short)508821504;
				short num3 = num;
				return this.radInfoGeneralRegionalGovernance_A36710.UIValue;
			}
			set
			{
				short num = (short)2058874538;
				short num2 = num;
				num = (short)179236522;
				switch (num2 == num)
				{
				}
				num = (short)1759707137;
				if (num != 0)
				{
				}
				num = (short)1184038912;
				if (num != 0)
				{
				}
				num = (short)1106903040;
				short num3 = num;
				this.radInfoGeneralRegionalGovernance_A36710.UIValue = value;
			}
		}

		// Token: 0x17002500 RID: 9472
		// (get) Token: 0x060047F7 RID: 18423 RVA: 0x004286C8 File Offset: 0x004268C8
		public global::AcpBusinessLayer.AcpListField RadInfoGeneralRegionalGovernance_A36710
		{
			get
			{
				short num = (short)276940446;
				short num2 = num;
				num = (short)1132512926;
				switch (num2 == num)
				{
				}
				num = (short)449773568;
				if (num != 0)
				{
				}
				num = (short)1113260033;
				if (num != 0)
				{
				}
				num = (short)306577408;
				short num3 = num;
				return this.radInfoGeneralRegionalGovernance_A36710;
			}
		}

		// Token: 0x17002501 RID: 9473
		// (get) Token: 0x060047F8 RID: 18424 RVA: 0x00428778 File Offset: 0x00426978
		// (set) Token: 0x060047F9 RID: 18425 RVA: 0x00428830 File Offset: 0x00426A30
		public bool RadInfoGeneralRegionalGovernance_A36710_Applicable
		{
			get
			{
				short num = (short)872218625;
				if (num != 0)
				{
				}
				num = (short)2144495126;
				short num2 = num;
				num = (short)1299342870;
				switch (num2 == num)
				{
				}
				num = (short)64749568;
				if (num != 0)
				{
				}
				num = (short)148766720;
				short num3 = num;
				return this.radInfoGeneralRegionalGovernance_A36710.Applicable;
			}
			set
			{
				short num = (short)1592756192;
				short num2 = num;
				num = (short)399869920;
				switch (num2 == num)
				{
				}
				num = (short)367722497;
				if (num != 0)
				{
				}
				num = (short)123994112;
				if (num != 0)
				{
				}
				num = (short)827195392;
				short num3 = num;
				this.radInfoGeneralRegionalGovernance_A36710.Applicable = value;
			}
		}

		// Token: 0x17002502 RID: 9474
		// (get) Token: 0x060047FA RID: 18426 RVA: 0x004288E4 File Offset: 0x00426AE4
		// (set) Token: 0x060047FB RID: 18427 RVA: 0x00428998 File Offset: 0x00426B98
		public bool RadInfoGeneralRegionalGovernance_A36710_Valid
		{
			get
			{
				short num = (short)956479307;
				short num2 = num;
				num = (short)579188555;
				switch (num2 == num)
				{
				}
				num = (short)1619132417;
				if (num != 0)
				{
				}
				num = (short)1324679168;
				if (num != 0)
				{
				}
				num = (short)809369600;
				short num3 = num;
				return this.radInfoGeneralRegionalGovernance_A36710.Valid;
			}
			set
			{
				short num = (short)107479041;
				if (num != 0)
				{
				}
				num = (short)2009157412;
				short num2 = num;
				num = (short)398413604;
				switch (num2 == num)
				{
				}
				num = (short)752287744;
				if (num != 0)
				{
				}
				num = (short)1869676544;
				short num3 = num;
				this.radInfoGeneralRegionalGovernance_A36710.Valid = value;
			}
		}

		// Token: 0x17002503 RID: 9475
		// (get) Token: 0x060047FC RID: 18428 RVA: 0x00428A4C File Offset: 0x00426C4C
		// (set) Token: 0x060047FD RID: 18429 RVA: 0x00428B00 File Offset: 0x00426D00
		public bool RadInfoGeneralRegionalGovernance_A36710_Visible
		{
			get
			{
				short num = (short)715457726;
				short num2 = num;
				num = (short)656934078;
				switch (num2 == num)
				{
				}
				num = (short)1020723201;
				if (num != 0)
				{
				}
				num = (short)1218969600;
				if (num != 0)
				{
				}
				num = (short)1416167424;
				short num3 = num;
				return this.radInfoGeneralRegionalGovernance_A36710.Visible;
			}
			set
			{
				short num = (short)615012782;
				short num2 = num;
				num = (short)1517574574;
				switch (num2 == num)
				{
				}
				num = (short)1225261057;
				if (num != 0)
				{
				}
				num = (short)822280192;
				if (num != 0)
				{
				}
				num = (short)824901632;
				short num3 = num;
				this.radInfoGeneralRegionalGovernance_A36710.Visible = value;
			}
		}

		// Token: 0x17002504 RID: 9476
		// (get) Token: 0x060047FE RID: 18430 RVA: 0x00428BB8 File Offset: 0x00426DB8
		// (set) Token: 0x060047FF RID: 18431 RVA: 0x00428C70 File Offset: 0x00426E70
		public bool RadInfoGeneralRegionalGovernance_A36710_Editable
		{
			get
			{
				short num = (short)1251632453;
				short num2 = num;
				num = (short)1824679237;
				switch (num2 == num)
				{
				}
				num = (short)1937702913;
				if (num != 0)
				{
				}
				num = (short)1384185856;
				if (num != 0)
				{
				}
				num = (short)773980160;
				short num3 = num;
				return this.radInfoGeneralRegionalGovernance_A36710.Editable;
			}
			set
			{
				short num = (short)514787823;
				short num2 = num;
				num = (short)8325615;
				switch (num2 == num)
				{
				}
				num = (short)396623873;
				if (num != 0)
				{
				}
				num = (short)9502720;
				if (num != 0)
				{
				}
				num = (short)1885995008;
				short num3 = num;
				this.radInfoGeneralRegionalGovernance_A36710.Editable = value;
			}
		}

		// Token: 0x17002505 RID: 9477
		// (get) Token: 0x06004800 RID: 18432 RVA: 0x00428D24 File Offset: 0x00426F24
		internal string RadInfoGeneralRegionalGovernance_A36710_UILabel
		{
			get
			{
				short num = (short)835173088;
				short num2 = num;
				num = (short)1443412704;
				switch (num2 == num)
				{
				}
				num = (short)876478465;
				if (num != 0)
				{
				}
				num = (short)820838400;
				if (num != 0)
				{
				}
				num = (short)1218248704;
				short num3 = num;
				return this.radInfoGeneralRegionalGovernance_A36710.UIName;
			}
		}

		// Token: 0x17002506 RID: 9478
		// (get) Token: 0x06004801 RID: 18433 RVA: 0x00428DD8 File Offset: 0x00426FD8
		// (set) Token: 0x06004802 RID: 18434 RVA: 0x00428E8C File Offset: 0x0042708C
		internal bool RadInfoGeneralRegionalGovernance_A36710_HiddenStatic
		{
			get
			{
				short num = (short)1774190593;
				if (num != 0)
				{
				}
				num = (short)1308544801;
				short num2 = num;
				num = (short)1411829537;
				switch (num2 == num)
				{
				}
				num = (short)414580736;
				if (num != 0)
				{
				}
				num = (short)305463296;
				short num3 = num;
				return this.radInfoGeneralRegionalGovernance_A36710.HiddenStatic;
			}
			set
			{
				short num = (short)1882203389;
				short num2 = num;
				num = (short)713893117;
				switch (num2 == num)
				{
				}
				num = (short)1309933569;
				if (num != 0)
				{
				}
				num = (short)242941952;
				if (num != 0)
				{
				}
				num = (short)1501822976;
				short num3 = num;
				this.radInfoGeneralRegionalGovernance_A36710.HiddenStatic = value;
			}
		}

		// Token: 0x17002507 RID: 9479
		// (get) Token: 0x06004803 RID: 18435 RVA: 0x00428F44 File Offset: 0x00427144
		// (set) Token: 0x06004804 RID: 18436 RVA: 0x00428FF8 File Offset: 0x004271F8
		internal bool RadInfoGeneralRegionalGovernance_A36710_HiddenDynamic
		{
			get
			{
				short num = (short)2020482685;
				short num2 = num;
				num = (short)1070538365;
				switch (num2 == num)
				{
				}
				num = (short)1107689473;
				if (num != 0)
				{
				}
				num = (short)1897332736;
				if (num != 0)
				{
				}
				num = (short)1601241088;
				short num3 = num;
				return this.radInfoGeneralRegionalGovernance_A36710.HiddenDynamic;
			}
			set
			{
				short num = (short)1109886535;
				short num2 = num;
				num = (short)2108196423;
				switch (num2 == num)
				{
				}
				num = (short)1118765057;
				if (num != 0)
				{
				}
				num = (short)1201537024;
				if (num != 0)
				{
				}
				num = (short)1351417856;
				short num3 = num;
				this.radInfoGeneralRegionalGovernance_A36710.HiddenDynamic = value;
			}
		}

		// Token: 0x17002508 RID: 9480
		// (get) Token: 0x06004805 RID: 18437 RVA: 0x004290AC File Offset: 0x004272AC
		public bool RadInfoGeneralRegionalGovernance_A36710_HasDiffs
		{
			get
			{
				short num = (short)157775793;
				short num2 = num;
				num = (short)109213617;
				switch (num2 == num)
				{
				}
				num = (short)44105729;
				if (num != 0)
				{
				}
				num = (short)1873477632;
				if (num != 0)
				{
				}
				num = (short)1624637440;
				short num3 = num;
				return this.radInfoGeneralRegionalGovernance_A36710._HasDiffs;
			}
		}

		// Token: 0x17002509 RID: 9481
		// (get) Token: 0x06004806 RID: 18438 RVA: 0x00429160 File Offset: 0x00427360
		// (set) Token: 0x06004807 RID: 18439 RVA: 0x00429214 File Offset: 0x00427414
		public string RadInfoGeneralWiFiRegulatoryRegion_A43772Value
		{
			get
			{
				short num = (short)83820545;
				if (num != 0)
				{
				}
				num = (short)336601237;
				short num2 = num;
				num = (short)2060394645;
				switch (num2 == num)
				{
				}
				num = (short)2013200384;
				if (num != 0)
				{
				}
				num = (short)1396310016;
				short num3 = num;
				return this.radInfoGeneralWiFiRegulatoryRegion_A43772.Value;
			}
			set
			{
				short num = (short)1940068587;
				short num2 = num;
				num = (short)1277106411;
				switch (num2 == num)
				{
				}
				num = (short)1081344000;
				if (num != 0)
				{
				}
				num = (short)1919877121;
				if (num != 0)
				{
				}
				num = (short)595329024;
				short num3 = num;
				this.radInfoGeneralWiFiRegulatoryRegion_A43772.Value = value;
			}
		}

		// Token: 0x1700250A RID: 9482
		// (get) Token: 0x06004808 RID: 18440 RVA: 0x004292CC File Offset: 0x004274CC
		// (set) Token: 0x06004809 RID: 18441 RVA: 0x00429384 File Offset: 0x00427584
		public string RadInfoGeneralWiFiRegulatoryRegion_A43772_UIValue
		{
			get
			{
				short num = (short)1536382018;
				short num2 = num;
				num = (short)721572930;
				switch (num2 == num)
				{
				}
				num = (short)500695041;
				if (num != 0)
				{
				}
				num = (short)883163136;
				if (num != 0)
				{
				}
				num = (short)600440832;
				short num3 = num;
				return this.radInfoGeneralWiFiRegulatoryRegion_A43772.UIValue;
			}
			set
			{
				short num = (short)285423500;
				short num2 = num;
				num = (short)1318860684;
				switch (num2 == num)
				{
				}
				num = (short)1457389568;
				if (num != 0)
				{
				}
				num = (short)1066205185;
				if (num != 0)
				{
				}
				num = (short)369819648;
				short num3 = num;
				this.radInfoGeneralWiFiRegulatoryRegion_A43772.UIValue = value;
			}
		}

		// Token: 0x1700250B RID: 9483
		// (get) Token: 0x0600480A RID: 18442 RVA: 0x00429438 File Offset: 0x00427638
		public global::AcpBusinessLayer.AcpFieldX<string, string> RadInfoGeneralWiFiRegulatoryRegion_A43772
		{
			get
			{
				short num = (short)101908481;
				if (num != 0)
				{
				}
				num = (short)1558119174;
				short num2 = num;
				num = (short)1259012870;
				switch (num2 == num)
				{
				}
				num = (short)2019753984;
				if (num != 0)
				{
				}
				num = (short)104202240;
				short num3 = num;
				return this.radInfoGeneralWiFiRegulatoryRegion_A43772;
			}
		}

		// Token: 0x1700250C RID: 9484
		// (get) Token: 0x0600480B RID: 18443 RVA: 0x004294E8 File Offset: 0x004276E8
		// (set) Token: 0x0600480C RID: 18444 RVA: 0x004295A0 File Offset: 0x004277A0
		public bool RadInfoGeneralWiFiRegulatoryRegion_A43772_Applicable
		{
			get
			{
				short num = (short)865171523;
				short num2 = num;
				num = (short)1668053059;
				switch (num2 == num)
				{
				}
				num = (short)886505473;
				if (num != 0)
				{
				}
				num = (short)425263104;
				if (num != 0)
				{
				}
				num = (short)1095434240;
				short num3 = num;
				return this.radInfoGeneralWiFiRegulatoryRegion_A43772.Applicable;
			}
			set
			{
				short num = (short)354277251;
				short num2 = num;
				num = (short)597022595;
				switch (num2 == num)
				{
				}
				num = (short)1839857665;
				if (num != 0)
				{
				}
				num = (short)1272315904;
				if (num != 0)
				{
				}
				num = (short)373424128;
				short num3 = num;
				this.radInfoGeneralWiFiRegulatoryRegion_A43772.Applicable = value;
			}
		}

		// Token: 0x1700250D RID: 9485
		// (get) Token: 0x0600480D RID: 18445 RVA: 0x00429654 File Offset: 0x00427854
		// (set) Token: 0x0600480E RID: 18446 RVA: 0x00429708 File Offset: 0x00427908
		public bool RadInfoGeneralWiFiRegulatoryRegion_A43772_Valid
		{
			get
			{
				short num = (short)1697494538;
				short num2 = num;
				num = (short)1659221514;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2005401600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)827326465;
				if (num != 0)
				{
				}
				num = (short)1160380416;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiRegulatoryRegion_A43772.Valid;
			}
			set
			{
				short num = (short)576297589;
				short num2 = num;
				num = (short)1875548789;
				switch (num2 == num)
				{
				default:
				{
					num = (short)471531520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1386479617;
				if (num != 0)
				{
				}
				num = (short)227868672;
				if (num != 0)
				{
				}
				this.radInfoGeneralWiFiRegulatoryRegion_A43772.Valid = value;
			}
		}

		// Token: 0x1700250E RID: 9486
		// (get) Token: 0x0600480F RID: 18447 RVA: 0x004297C0 File Offset: 0x004279C0
		// (set) Token: 0x06004810 RID: 18448 RVA: 0x00429874 File Offset: 0x00427A74
		public bool RadInfoGeneralWiFiRegulatoryRegion_A43772_Visible
		{
			get
			{
				short num = (short)176629412;
				short num2 = num;
				num = (short)605038244;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1581187072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1518469121;
				if (num != 0)
				{
				}
				num = (short)1823473664;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiRegulatoryRegion_A43772.Visible;
			}
			set
			{
				short num = (short)1610253113;
				short num2 = num;
				num = (short)1690731321;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2075721728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)362545153;
				if (num != 0)
				{
				}
				num = (short)1247674368;
				if (num != 0)
				{
				}
				this.radInfoGeneralWiFiRegulatoryRegion_A43772.Visible = value;
			}
		}

		// Token: 0x1700250F RID: 9487
		// (get) Token: 0x06004811 RID: 18449 RVA: 0x0042992C File Offset: 0x00427B2C
		// (set) Token: 0x06004812 RID: 18450 RVA: 0x004299E4 File Offset: 0x00427BE4
		public bool RadInfoGeneralWiFiRegulatoryRegion_A43772_Editable
		{
			get
			{
				short num = (short)1390960233;
				short num2 = num;
				num = (short)507338345;
				switch (num2 == num)
				{
				default:
				{
					num = (short)230031360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1294204929;
				if (num != 0)
				{
				}
				num = (short)2075918336;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiRegulatoryRegion_A43772.Editable;
			}
			set
			{
				short num = (short)633361537;
				short num2 = num;
				num = (short)254301313;
				switch (num2 == num)
				{
				default:
				{
					num = (short)216334336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1585315841;
				if (num != 0)
				{
				}
				num = (short)94633984;
				if (num != 0)
				{
				}
				this.radInfoGeneralWiFiRegulatoryRegion_A43772.Editable = value;
			}
		}

		// Token: 0x17002510 RID: 9488
		// (get) Token: 0x06004813 RID: 18451 RVA: 0x00429A9C File Offset: 0x00427C9C
		internal string RadInfoGeneralWiFiRegulatoryRegion_A43772_UILabel
		{
			get
			{
				short num = (short)1439409307;
				short num2 = num;
				num = (short)1751295131;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1434386432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1536753665;
				if (num != 0)
				{
				}
				num = (short)444006400;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiRegulatoryRegion_A43772.UIName;
			}
		}

		// Token: 0x17002511 RID: 9489
		// (get) Token: 0x06004814 RID: 18452 RVA: 0x00429B50 File Offset: 0x00427D50
		// (set) Token: 0x06004815 RID: 18453 RVA: 0x00429C08 File Offset: 0x00427E08
		internal bool RadInfoGeneralWiFiRegulatoryRegion_A43772_HiddenStatic
		{
			get
			{
				short num = (short)1300221876;
				short num2 = num;
				num = (short)1624231860;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1624702976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2117533697;
				if (num != 0)
				{
				}
				num = (short)508690432;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiRegulatoryRegion_A43772.HiddenStatic;
			}
			set
			{
				short num = (short)203803417;
				short num2 = num;
				num = (short)2091371289;
				switch (num2 == num)
				{
				default:
				{
					num = (short)982253568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2056585217;
				if (num != 0)
				{
				}
				num = (short)576585728;
				if (num != 0)
				{
				}
				this.radInfoGeneralWiFiRegulatoryRegion_A43772.HiddenStatic = value;
			}
		}

		// Token: 0x17002512 RID: 9490
		// (get) Token: 0x06004816 RID: 18454 RVA: 0x00429CC0 File Offset: 0x00427EC0
		// (set) Token: 0x06004817 RID: 18455 RVA: 0x00429D74 File Offset: 0x00427F74
		internal bool RadInfoGeneralWiFiRegulatoryRegion_A43772_HiddenDynamic
		{
			get
			{
				short num = (short)1903819660;
				short num2 = num;
				num = (short)1261697932;
				switch (num2 == num)
				{
				default:
				{
					num = (short)161480704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)931659776;
				if (num != 0)
				{
				}
				num = (short)593559553;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiRegulatoryRegion_A43772.HiddenDynamic;
			}
			set
			{
				short num = (short)627515321;
				short num2 = num;
				num = (short)2080251833;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2075787264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)17956864;
				if (num != 0)
				{
				}
				num = (short)160104449;
				if (num != 0)
				{
				}
				this.radInfoGeneralWiFiRegulatoryRegion_A43772.HiddenDynamic = value;
			}
		}

		// Token: 0x17002513 RID: 9491
		// (get) Token: 0x06004818 RID: 18456 RVA: 0x00429E2C File Offset: 0x0042802C
		public bool RadInfoGeneralWiFiRegulatoryRegion_A43772_HasDiffs
		{
			get
			{
				short num = (short)1865550884;
				short num2 = num;
				num = (short)954469412;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1109721088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)299171841;
				if (num != 0)
				{
				}
				num = (short)227213312;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiRegulatoryRegion_A43772._HasDiffs;
			}
		}

		// Token: 0x17002514 RID: 9492
		// (get) Token: 0x06004819 RID: 18457 RVA: 0x00429EE4 File Offset: 0x004280E4
		// (set) Token: 0x0600481A RID: 18458 RVA: 0x00429F98 File Offset: 0x00428198
		public string RadInfoGeneralUCMVersion_A9591Value
		{
			get
			{
				short num = (short)1030508845;
				short num2 = num;
				num = (short)1138118957;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1422262272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1292697601;
				if (num != 0)
				{
				}
				num = (short)1592262656;
				if (num != 0)
				{
				}
				return this.radInfoGeneralUCMVersion_A9591.Value;
			}
			set
			{
				short num = (short)1161494529;
				if (num != 0)
				{
				}
				num = (short)1201143808;
				short num2 = num;
				num = (short)2090995895;
				short num3 = num;
				num = (short)1119948983;
				switch (num3 == num)
				{
				}
				num = (short)1756889088;
				if (num != 0)
				{
				}
				this.radInfoGeneralUCMVersion_A9591.Value = value;
			}
		}

		// Token: 0x17002515 RID: 9493
		// (get) Token: 0x0600481B RID: 18459 RVA: 0x0042A04C File Offset: 0x0042824C
		public global::AcpBusinessLayer.AcpField<string> RadInfoGeneralUCMVersion_A9591
		{
			get
			{
				short num = (short)1678162043;
				short num2 = num;
				num = (short)205109371;
				switch (num2 == num)
				{
				default:
				{
					num = (short)156631040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)263258112;
				if (num != 0)
				{
				}
				num = (short)2032140289;
				if (num != 0)
				{
				}
				return this.radInfoGeneralUCMVersion_A9591;
			}
		}

		// Token: 0x17002516 RID: 9494
		// (get) Token: 0x0600481C RID: 18460 RVA: 0x0042A0FC File Offset: 0x004282FC
		// (set) Token: 0x0600481D RID: 18461 RVA: 0x0042A1B0 File Offset: 0x004283B0
		public string RadInfoGeneralUCMVersion_A9591_UIValue
		{
			get
			{
				short num = (short)1012838639;
				short num2 = num;
				num = (short)1212068079;
				switch (num2 == num)
				{
				default:
				{
					num = (short)121700352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)568655873;
				if (num != 0)
				{
				}
				num = (short)775749632;
				if (num != 0)
				{
				}
				return this.radInfoGeneralUCMVersion_A9591.Value;
			}
			set
			{
				short num = (short)89681227;
				short num2 = num;
				num = (short)424111435;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1205534720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1284505601;
				if (num != 0)
				{
				}
				num = (short)341835776;
				if (num != 0)
				{
				}
				this.radInfoGeneralUCMVersion_A9591.Value = value;
			}
		}

		// Token: 0x17002517 RID: 9495
		// (get) Token: 0x0600481E RID: 18462 RVA: 0x0042A264 File Offset: 0x00428464
		// (set) Token: 0x0600481F RID: 18463 RVA: 0x0042A318 File Offset: 0x00428518
		public bool RadInfoGeneralUCMVersion_A9591_Applicable
		{
			get
			{
				short num = (short)1537811451;
				short num2 = num;
				num = (short)508699643;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1800339456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1762787329;
				if (num != 0)
				{
				}
				num = (short)1503789056;
				if (num != 0)
				{
				}
				return this.radInfoGeneralUCMVersion_A9591.Applicable;
			}
			set
			{
				short num = (short)1084857201;
				short num2 = num;
				num = (short)1557240689;
				switch (num2 == num)
				{
				default:
				{
					num = (short)566558720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1204486144;
				if (num != 0)
				{
				}
				num = (short)105906177;
				if (num != 0)
				{
				}
				this.radInfoGeneralUCMVersion_A9591.Applicable = value;
			}
		}

		// Token: 0x17002518 RID: 9496
		// (get) Token: 0x06004820 RID: 18464 RVA: 0x0042A3CC File Offset: 0x004285CC
		// (set) Token: 0x06004821 RID: 18465 RVA: 0x0042A484 File Offset: 0x00428684
		public bool RadInfoGeneralUCMVersion_A9591_Valid
		{
			get
			{
				short num = (short)561343990;
				short num2 = num;
				num = (short)1494642166;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1550188544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1654652929;
				if (num != 0)
				{
				}
				num = (short)2004877312;
				if (num != 0)
				{
				}
				return this.radInfoGeneralUCMVersion_A9591.Valid;
			}
			set
			{
				short num = (short)1788813393;
				short num2 = num;
				num = (short)1771184209;
				switch (num2 == num)
				{
				default:
				{
					num = (short)366870528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1512177665;
				if (num != 0)
				{
				}
				num = (short)1623523328;
				if (num != 0)
				{
				}
				this.radInfoGeneralUCMVersion_A9591.Valid = value;
			}
		}

		// Token: 0x17002519 RID: 9497
		// (get) Token: 0x06004822 RID: 18466 RVA: 0x0042A538 File Offset: 0x00428738
		// (set) Token: 0x06004823 RID: 18467 RVA: 0x0042A5EC File Offset: 0x004287EC
		public bool RadInfoGeneralUCMVersion_A9591_Visible
		{
			get
			{
				short num = (short)377454985;
				short num2 = num;
				num = (short)918192521;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1994391552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1114113;
				if (num != 0)
				{
				}
				num = (short)1460994048;
				if (num != 0)
				{
				}
				return this.radInfoGeneralUCMVersion_A9591.Visible;
			}
			set
			{
				short num = (short)847819119;
				short num2 = num;
				num = (short)738111855;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1529479168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1334837248;
				if (num != 0)
				{
				}
				num = (short)1391788033;
				if (num != 0)
				{
				}
				this.radInfoGeneralUCMVersion_A9591.Visible = value;
			}
		}

		// Token: 0x1700251A RID: 9498
		// (get) Token: 0x06004824 RID: 18468 RVA: 0x0042A6A4 File Offset: 0x004288A4
		// (set) Token: 0x06004825 RID: 18469 RVA: 0x0042A754 File Offset: 0x00428954
		public bool RadInfoGeneralUCMVersion_A9591_Editable
		{
			get
			{
				short num = (short)736281951;
				short num2 = num;
				num = (short)869909855;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1954021376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1980497921;
				if (num != 0)
				{
				}
				num = (short)1409482752;
				if (num != 0)
				{
				}
				return this.radInfoGeneralUCMVersion_A9591.Editable;
			}
			set
			{
				short num = (short)248928784;
				short num2 = num;
				num = (short)666917392;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1304625152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)513605633;
				if (num != 0)
				{
				}
				num = (short)1934884864;
				if (num != 0)
				{
				}
				this.radInfoGeneralUCMVersion_A9591.Editable = value;
			}
		}

		// Token: 0x1700251B RID: 9499
		// (get) Token: 0x06004826 RID: 18470 RVA: 0x0042A80C File Offset: 0x00428A0C
		internal string RadInfoGeneralUCMVersion_A9591_UILabel
		{
			get
			{
				short num = (short)1745092609;
				if (num != 0)
				{
				}
				num = (short)1981284352;
				short num2 = num;
				num = (short)835704230;
				short num3 = num;
				num = (short)1005966758;
				switch (num3 == num)
				{
				}
				num = (short)519634944;
				if (num != 0)
				{
				}
				return this.radInfoGeneralUCMVersion_A9591.UIName;
			}
		}

		// Token: 0x1700251C RID: 9500
		// (get) Token: 0x06004827 RID: 18471 RVA: 0x0042A8C4 File Offset: 0x00428AC4
		// (set) Token: 0x06004828 RID: 18472 RVA: 0x0042A97C File Offset: 0x00428B7C
		internal bool RadInfoGeneralUCMVersion_A9591_HiddenStatic
		{
			get
			{
				short num = (short)910523058;
				short num2 = num;
				num = (short)365722290;
				switch (num2 == num)
				{
				default:
				{
					num = (short)179372032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1534853121;
				if (num != 0)
				{
				}
				num = (short)339869696;
				if (num != 0)
				{
				}
				return this.radInfoGeneralUCMVersion_A9591.HiddenStatic;
			}
			set
			{
				short num = (short)1934239769;
				short num2 = num;
				num = (short)1655580697;
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
				num = (short)2067005440;
				if (num != 0)
				{
				}
				num = (short)537722881;
				if (num != 0)
				{
				}
				this.radInfoGeneralUCMVersion_A9591.HiddenStatic = value;
			}
		}

		// Token: 0x1700251D RID: 9501
		// (get) Token: 0x06004829 RID: 18473 RVA: 0x0042AA34 File Offset: 0x00428C34
		// (set) Token: 0x0600482A RID: 18474 RVA: 0x0042AAE8 File Offset: 0x00428CE8
		internal bool RadInfoGeneralUCMVersion_A9591_HiddenDynamic
		{
			get
			{
				short num = (short)1602355201;
				if (num != 0)
				{
				}
				num = (short)1081278464;
				short num2 = num;
				num = (short)565342085;
				short num3 = num;
				num = (short)558329733;
				switch (num3 == num)
				{
				}
				num = (short)14417920;
				if (num != 0)
				{
				}
				return this.radInfoGeneralUCMVersion_A9591.HiddenDynamic;
			}
			set
			{
				short num = (short)1116984115;
				short num2 = num;
				num = (short)1955844915;
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
				num = (short)859832321;
				if (num != 0)
				{
				}
				num = (short)1473380352;
				if (num != 0)
				{
				}
				this.radInfoGeneralUCMVersion_A9591.HiddenDynamic = value;
			}
		}

		// Token: 0x1700251E RID: 9502
		// (get) Token: 0x0600482B RID: 18475 RVA: 0x0042AB9C File Offset: 0x00428D9C
		public bool RadInfoGeneralUCMVersion_A9591_HasDiffs
		{
			get
			{
				short num = (short)136058866;
				short num2 = num;
				num = (short)754784242;
				switch (num2 == num)
				{
				default:
				{
					num = (short)746061824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1384120321;
				if (num != 0)
				{
				}
				num = (short)1647640576;
				if (num != 0)
				{
				}
				return this.radInfoGeneralUCMVersion_A9591._HasDiffs;
			}
		}

		// Token: 0x1700251F RID: 9503
		// (get) Token: 0x0600482C RID: 18476 RVA: 0x0042AC50 File Offset: 0x00428E50
		// (set) Token: 0x0600482D RID: 18477 RVA: 0x0042AD04 File Offset: 0x00428F04
		public string RadInfoGeneralCodeplugAlias_A7684Value
		{
			get
			{
				short num = (short)1030548957;
				short num2 = num;
				num = (short)1541008861;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1773142016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1697775617;
				if (num != 0)
				{
				}
				num = (short)1145372672;
				if (num != 0)
				{
				}
				return this.radInfoGeneralCodeplugAlias_A7684.Value;
			}
			set
			{
				short num = (short)1005680230;
				short num2 = num;
				num = (short)1662482022;
				switch (num2 == num)
				{
				default:
				{
					num = (short)768409600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1641938944;
				if (num != 0)
				{
				}
				num = (short)1286471681;
				if (num != 0)
				{
				}
				this.radInfoGeneralCodeplugAlias_A7684.Value = value;
			}
		}

		// Token: 0x17002520 RID: 9504
		// (get) Token: 0x0600482E RID: 18478 RVA: 0x0042ADBC File Offset: 0x00428FBC
		public global::AcpBusinessLayer.AcpField<string> RadInfoGeneralCodeplugAlias_A7684
		{
			get
			{
				short num = (short)988606234;
				short num2 = num;
				num = (short)39055130;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1403912192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1742143489;
				if (num != 0)
				{
				}
				num = (short)1548877824;
				if (num != 0)
				{
				}
				return this.radInfoGeneralCodeplugAlias_A7684;
			}
		}

		// Token: 0x17002521 RID: 9505
		// (get) Token: 0x0600482F RID: 18479 RVA: 0x0042AE6C File Offset: 0x0042906C
		// (set) Token: 0x06004830 RID: 18480 RVA: 0x0042AF20 File Offset: 0x00429120
		public string RadInfoGeneralCodeplugAlias_A7684_UIValue
		{
			get
			{
				short num = (short)1220390923;
				short num2 = num;
				num = (short)1324658699;
				switch (num2 == num)
				{
				default:
				{
					num = (short)340000768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1250033665;
				if (num != 0)
				{
				}
				num = (short)692518912;
				if (num != 0)
				{
				}
				return this.radInfoGeneralCodeplugAlias_A7684.Value;
			}
			set
			{
				short num = (short)1314647402;
				short num2 = num;
				num = (short)2033511786;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1576206336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1965948928;
				if (num != 0)
				{
				}
				num = (short)1566048257;
				if (num != 0)
				{
				}
				this.radInfoGeneralCodeplugAlias_A7684.Value = value;
			}
		}

		// Token: 0x17002522 RID: 9506
		// (get) Token: 0x06004831 RID: 18481 RVA: 0x0042AFD4 File Offset: 0x004291D4
		// (set) Token: 0x06004832 RID: 18482 RVA: 0x0042B088 File Offset: 0x00429288
		public bool RadInfoGeneralCodeplugAlias_A7684_Applicable
		{
			get
			{
				short num = (short)1438421158;
				short num2 = num;
				num = (short)1680445606;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1643184128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1738276865;
				if (num != 0)
				{
				}
				num = (short)843055104;
				if (num != 0)
				{
				}
				return this.radInfoGeneralCodeplugAlias_A7684.Applicable;
			}
			set
			{
				short num = (short)1897843691;
				short num2 = num;
				num = (short)778357739;
				switch (num2 == num)
				{
				default:
				{
					num = (short)109772800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)45547520;
				if (num != 0)
				{
				}
				num = (short)732692481;
				if (num != 0)
				{
				}
				this.radInfoGeneralCodeplugAlias_A7684.Applicable = value;
			}
		}

		// Token: 0x17002523 RID: 9507
		// (get) Token: 0x06004833 RID: 18483 RVA: 0x0042B140 File Offset: 0x00429340
		// (set) Token: 0x06004834 RID: 18484 RVA: 0x0042B1F8 File Offset: 0x004293F8
		public bool RadInfoGeneralCodeplugAlias_A7684_Valid
		{
			get
			{
				short num = (short)1096722005;
				short num2 = num;
				num = (short)1605215829;
				switch (num2 == num)
				{
				default:
				{
					num = (short)156368896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)273874945;
				if (num != 0)
				{
				}
				num = (short)490733568;
				if (num != 0)
				{
				}
				return this.radInfoGeneralCodeplugAlias_A7684.Valid;
			}
			set
			{
				short num = (short)1318518785;
				if (num != 0)
				{
				}
				num = (short)1954086912;
				short num2 = num;
				num = (short)683803948;
				short num3 = num;
				num = (short)625607980;
				switch (num3 == num)
				{
				}
				num = (short)582615040;
				if (num != 0)
				{
				}
				this.radInfoGeneralCodeplugAlias_A7684.Valid = value;
			}
		}

		// Token: 0x17002524 RID: 9508
		// (get) Token: 0x06004835 RID: 18485 RVA: 0x0042B2B0 File Offset: 0x004294B0
		// (set) Token: 0x06004836 RID: 18486 RVA: 0x0042B364 File Offset: 0x00429564
		public bool RadInfoGeneralCodeplugAlias_A7684_Visible
		{
			get
			{
				short num = (short)1336262825;
				short num2 = num;
				num = (short)1196212393;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2060189696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)395640832;
				if (num != 0)
				{
				}
				num = (short)24117249;
				if (num != 0)
				{
				}
				return this.radInfoGeneralCodeplugAlias_A7684.Visible;
			}
			set
			{
				short num = (short)1951268865;
				if (num != 0)
				{
				}
				num = (short)440270848;
				short num2 = num;
				num = (short)1173699131;
				short num3 = num;
				num = (short)1155611195;
				switch (num3 == num)
				{
				}
				num = (short)36765696;
				if (num != 0)
				{
				}
				this.radInfoGeneralCodeplugAlias_A7684.Visible = value;
			}
		}

		// Token: 0x17002525 RID: 9509
		// (get) Token: 0x06004837 RID: 18487 RVA: 0x0042B41C File Offset: 0x0042961C
		// (set) Token: 0x06004838 RID: 18488 RVA: 0x0042B4D0 File Offset: 0x004296D0
		public bool RadInfoGeneralCodeplugAlias_A7684_Editable
		{
			get
			{
				short num = (short)1010302977;
				if (num != 0)
				{
				}
				num = (short)1740046336;
				short num2 = num;
				num = (short)1927409606;
				short num3 = num;
				num = (short)2116546502;
				switch (num3 == num)
				{
				}
				num = (short)1312030720;
				if (num != 0)
				{
				}
				return this.radInfoGeneralCodeplugAlias_A7684.Editable;
			}
			set
			{
				short num = (short)1316082581;
				short num2 = num;
				num = (short)795530133;
				switch (num2 == num)
				{
				default:
				{
					num = (short)839450624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1846542337;
				if (num != 0)
				{
				}
				num = (short)1138884608;
				if (num != 0)
				{
				}
				this.radInfoGeneralCodeplugAlias_A7684.Editable = value;
			}
		}

		// Token: 0x17002526 RID: 9510
		// (get) Token: 0x06004839 RID: 18489 RVA: 0x0042B580 File Offset: 0x00429780
		internal string RadInfoGeneralCodeplugAlias_A7684_UILabel
		{
			get
			{
				short num = (short)1641481540;
				short num2 = num;
				num = (short)812909892;
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
				num = (short)1662648321;
				if (num != 0)
				{
				}
				num = (short)945225728;
				if (num != 0)
				{
				}
				return this.radInfoGeneralCodeplugAlias_A7684.UIName;
			}
		}

		// Token: 0x17002527 RID: 9511
		// (get) Token: 0x0600483A RID: 18490 RVA: 0x0042B634 File Offset: 0x00429834
		// (set) Token: 0x0600483B RID: 18491 RVA: 0x0042B6EC File Offset: 0x004298EC
		internal bool RadInfoGeneralCodeplugAlias_A7684_HiddenStatic
		{
			get
			{
				short num = (short)1764037209;
				short num2 = num;
				num = (short)1257378393;
				switch (num2 == num)
				{
				default:
				{
					num = (short)495976448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1919811585;
				if (num != 0)
				{
				}
				num = (short)1551171584;
				if (num != 0)
				{
				}
				return this.radInfoGeneralCodeplugAlias_A7684.HiddenStatic;
			}
			set
			{
				short num = (short)647430145;
				if (num != 0)
				{
				}
				num = (short)1948123136;
				short num2 = num;
				num = (short)339752218;
				short num3 = num;
				num = (short)919483674;
				switch (num3 == num)
				{
				}
				num = (short)1821310976;
				if (num != 0)
				{
				}
				this.radInfoGeneralCodeplugAlias_A7684.HiddenStatic = value;
			}
		}

		// Token: 0x17002528 RID: 9512
		// (get) Token: 0x0600483C RID: 18492 RVA: 0x0042B7A8 File Offset: 0x004299A8
		// (set) Token: 0x0600483D RID: 18493 RVA: 0x0042B85C File Offset: 0x00429A5C
		internal bool RadInfoGeneralCodeplugAlias_A7684_HiddenDynamic
		{
			get
			{
				short num = (short)1396008697;
				short num2 = num;
				num = (short)877291257;
				switch (num2 == num)
				{
				default:
				{
					num = (short)691339264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1552482305;
				if (num != 0)
				{
				}
				num = (short)1562771456;
				if (num != 0)
				{
				}
				return this.radInfoGeneralCodeplugAlias_A7684.HiddenDynamic;
			}
			set
			{
				short num = (short)1648388122;
				short num2 = num;
				num = (short)75786266;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1243414528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1311571969;
				if (num != 0)
				{
				}
				num = (short)282001408;
				if (num != 0)
				{
				}
				this.radInfoGeneralCodeplugAlias_A7684.HiddenDynamic = value;
			}
		}

		// Token: 0x17002529 RID: 9513
		// (get) Token: 0x0600483E RID: 18494 RVA: 0x0042B914 File Offset: 0x00429B14
		public bool RadInfoGeneralCodeplugAlias_A7684_HasDiffs
		{
			get
			{
				short num = (short)426534908;
				short num2 = num;
				num = (short)1627088892;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1814560768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)514064385;
				if (num != 0)
				{
				}
				num = (short)933232640;
				if (num != 0)
				{
				}
				return this.radInfoGeneralCodeplugAlias_A7684._HasDiffs;
			}
		}

		// Token: 0x1700252A RID: 9514
		// (get) Token: 0x0600483F RID: 18495 RVA: 0x0042B9C4 File Offset: 0x00429BC4
		// (set) Token: 0x06004840 RID: 18496 RVA: 0x0042BA7C File Offset: 0x00429C7C
		public string RadInfoGeneralElectronicSerialNumber_A41744Value
		{
			get
			{
				short num = (short)1946871542;
				short num2 = num;
				num = (short)144697078;
				switch (num2 == num)
				{
				default:
				{
					num = (short)22020096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)134610945;
				if (num != 0)
				{
				}
				num = (short)1885798400;
				if (num != 0)
				{
				}
				return this.radInfoGeneralElectronicSerialNumber_A41744.Value;
			}
			set
			{
				short num = (short)376509328;
				short num2 = num;
				num = (short)930878352;
				switch (num2 == num)
				{
				default:
				{
					num = (short)249692160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)206897153;
				if (num != 0)
				{
				}
				num = (short)7929856;
				if (num != 0)
				{
				}
				this.radInfoGeneralElectronicSerialNumber_A41744.Value = value;
			}
		}

		// Token: 0x1700252B RID: 9515
		// (get) Token: 0x06004841 RID: 18497 RVA: 0x0042BB30 File Offset: 0x00429D30
		public global::AcpBusinessLayer.AcpField<string> RadInfoGeneralElectronicSerialNumber_A41744
		{
			get
			{
				short num = (short)439091201;
				if (num != 0)
				{
				}
				num = (short)536608768;
				short num2 = num;
				num = (short)2091018133;
				short num3 = num;
				num = (short)533030805;
				switch (num3 == num)
				{
				}
				num = (short)230293504;
				if (num != 0)
				{
				}
				return this.radInfoGeneralElectronicSerialNumber_A41744;
			}
		}

		// Token: 0x1700252C RID: 9516
		// (get) Token: 0x06004842 RID: 18498 RVA: 0x0042BBE4 File Offset: 0x00429DE4
		// (set) Token: 0x06004843 RID: 18499 RVA: 0x0042BC98 File Offset: 0x00429E98
		public string RadInfoGeneralElectronicSerialNumber_A41744_UIValue
		{
			get
			{
				short num = (short)1408895564;
				short num2 = num;
				num = (short)1965820492;
				switch (num2 == num)
				{
				default:
				{
					num = (short)824508416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)349044736;
				if (num != 0)
				{
				}
				num = (short)1412956161;
				if (num != 0)
				{
				}
				return this.radInfoGeneralElectronicSerialNumber_A41744.Value;
			}
			set
			{
				short num = (short)416874497;
				if (num != 0)
				{
				}
				num = (short)1890058240;
				short num2 = num;
				num = (short)295614257;
				short num3 = num;
				num = (short)1962719025;
				switch (num3 == num)
				{
				}
				num = (short)566624256;
				if (num != 0)
				{
				}
				this.radInfoGeneralElectronicSerialNumber_A41744.Value = value;
			}
		}

		// Token: 0x1700252D RID: 9517
		// (get) Token: 0x06004844 RID: 18500 RVA: 0x0042BD50 File Offset: 0x00429F50
		// (set) Token: 0x06004845 RID: 18501 RVA: 0x0042BE08 File Offset: 0x0042A008
		public bool RadInfoGeneralElectronicSerialNumber_A41744_Applicable
		{
			get
			{
				short num = (short)1895301121;
				if (num != 0)
				{
				}
				num = (short)254279680;
				short num2 = num;
				num = (short)688731265;
				short num3 = num;
				num = (short)812135553;
				switch (num3 == num)
				{
				}
				num = (short)1912274944;
				if (num != 0)
				{
				}
				return this.radInfoGeneralElectronicSerialNumber_A41744.Applicable;
			}
			set
			{
				short num = (short)1840834822;
				short num2 = num;
				num = (short)251586822;
				switch (num2 == num)
				{
				default:
				{
					num = (short)50200576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)960430081;
				if (num != 0)
				{
				}
				num = (short)1177419776;
				if (num != 0)
				{
				}
				this.radInfoGeneralElectronicSerialNumber_A41744.Applicable = value;
			}
		}

		// Token: 0x1700252E RID: 9518
		// (get) Token: 0x06004846 RID: 18502 RVA: 0x0042BEC0 File Offset: 0x0042A0C0
		// (set) Token: 0x06004847 RID: 18503 RVA: 0x0042BF78 File Offset: 0x0042A178
		public bool RadInfoGeneralElectronicSerialNumber_A41744_Valid
		{
			get
			{
				short num = (short)481583429;
				short num2 = num;
				num = (short)978018629;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1514733568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1722810368;
				if (num != 0)
				{
				}
				num = (short)749207553;
				if (num != 0)
				{
				}
				return this.radInfoGeneralElectronicSerialNumber_A41744.Valid;
			}
			set
			{
				short num = (short)820980009;
				short num2 = num;
				num = (short)1696475433;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1181810688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1316225025;
				if (num != 0)
				{
				}
				num = (short)2103836672;
				if (num != 0)
				{
				}
				this.radInfoGeneralElectronicSerialNumber_A41744.Valid = value;
			}
		}

		// Token: 0x1700252F RID: 9519
		// (get) Token: 0x06004848 RID: 18504 RVA: 0x0042C02C File Offset: 0x0042A22C
		// (set) Token: 0x06004849 RID: 18505 RVA: 0x0042C0E0 File Offset: 0x0042A2E0
		public bool RadInfoGeneralElectronicSerialNumber_A41744_Visible
		{
			get
			{
				short num = (short)2057341122;
				short num2 = num;
				num = (short)78350530;
				switch (num2 == num)
				{
				default:
				{
					num = (short)654376960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1491861505;
				if (num != 0)
				{
				}
				num = (short)629145600;
				if (num != 0)
				{
				}
				return this.radInfoGeneralElectronicSerialNumber_A41744.Visible;
			}
			set
			{
				short num = (short)444914127;
				short num2 = num;
				num = (short)531093967;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1346895872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)574160897;
				if (num != 0)
				{
				}
				num = (short)472121344;
				if (num != 0)
				{
				}
				this.radInfoGeneralElectronicSerialNumber_A41744.Visible = value;
			}
		}

		// Token: 0x17002530 RID: 9520
		// (get) Token: 0x0600484A RID: 18506 RVA: 0x0042C198 File Offset: 0x0042A398
		// (set) Token: 0x0600484B RID: 18507 RVA: 0x0042C24C File Offset: 0x0042A44C
		public bool RadInfoGeneralElectronicSerialNumber_A41744_Editable
		{
			get
			{
				short num = (short)501120130;
				short num2 = num;
				num = (short)955743362;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1305870336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)824442881;
				if (num != 0)
				{
				}
				num = (short)1809776640;
				if (num != 0)
				{
				}
				return this.radInfoGeneralElectronicSerialNumber_A41744.Editable;
			}
			set
			{
				short num = (short)1944346670;
				short num2 = num;
				num = (short)1129668654;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1816985600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)786628609;
				if (num != 0)
				{
				}
				num = (short)1359020032;
				if (num != 0)
				{
				}
				this.radInfoGeneralElectronicSerialNumber_A41744.Editable = value;
			}
		}

		// Token: 0x17002531 RID: 9521
		// (get) Token: 0x0600484C RID: 18508 RVA: 0x0042C304 File Offset: 0x0042A504
		internal string RadInfoGeneralElectronicSerialNumber_A41744_UILabel
		{
			get
			{
				short num = (short)691795942;
				short num2 = num;
				num = (short)1381300198;
				switch (num2 == num)
				{
				default:
				{
					num = (short)316276736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1521287169;
				if (num != 0)
				{
				}
				num = (short)781975552;
				if (num != 0)
				{
				}
				return this.radInfoGeneralElectronicSerialNumber_A41744.UIName;
			}
		}

		// Token: 0x17002532 RID: 9522
		// (get) Token: 0x0600484D RID: 18509 RVA: 0x0042C3B8 File Offset: 0x0042A5B8
		// (set) Token: 0x0600484E RID: 18510 RVA: 0x0042C468 File Offset: 0x0042A668
		internal bool RadInfoGeneralElectronicSerialNumber_A41744_HiddenStatic
		{
			get
			{
				short num = (short)624157593;
				short num2 = num;
				num = (short)898360217;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1775108096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)764215297;
				if (num != 0)
				{
				}
				num = (short)1766719488;
				if (num != 0)
				{
				}
				return this.radInfoGeneralElectronicSerialNumber_A41744.HiddenStatic;
			}
			set
			{
				short num = (short)1925722587;
				short num2 = num;
				num = (short)1183723995;
				switch (num2 == num)
				{
				default:
				{
					num = (short)90898432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1967063041;
				if (num != 0)
				{
				}
				num = (short)1684537344;
				if (num != 0)
				{
				}
				this.radInfoGeneralElectronicSerialNumber_A41744.HiddenStatic = value;
			}
		}

		// Token: 0x17002533 RID: 9523
		// (get) Token: 0x0600484F RID: 18511 RVA: 0x0042C51C File Offset: 0x0042A71C
		// (set) Token: 0x06004850 RID: 18512 RVA: 0x0042C5D0 File Offset: 0x0042A7D0
		internal bool RadInfoGeneralElectronicSerialNumber_A41744_HiddenDynamic
		{
			get
			{
				short num = (short)325424573;
				short num2 = num;
				num = (short)162371005;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1661272064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)985530369;
				if (num != 0)
				{
				}
				num = (short)1596063744;
				if (num != 0)
				{
				}
				return this.radInfoGeneralElectronicSerialNumber_A41744.HiddenDynamic;
			}
			set
			{
				short num = (short)1095262738;
				short num2 = num;
				num = (short)1814979090;
				switch (num2 == num)
				{
				default:
				{
					num = (short)261357568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)168624129;
				if (num != 0)
				{
				}
				num = (short)1884225536;
				if (num != 0)
				{
				}
				this.radInfoGeneralElectronicSerialNumber_A41744.HiddenDynamic = value;
			}
		}

		// Token: 0x17002534 RID: 9524
		// (get) Token: 0x06004851 RID: 18513 RVA: 0x0042C688 File Offset: 0x0042A888
		public bool RadInfoGeneralElectronicSerialNumber_A41744_HasDiffs
		{
			get
			{
				short num = (short)1514168491;
				short num2 = num;
				num = (short)2056741035;
				switch (num2 == num)
				{
				default:
				{
					num = (short)249626624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2075459585;
				if (num != 0)
				{
				}
				num = (short)151715840;
				if (num != 0)
				{
				}
				return this.radInfoGeneralElectronicSerialNumber_A41744._HasDiffs;
			}
		}

		// Token: 0x17002535 RID: 9525
		// (get) Token: 0x06004852 RID: 18514 RVA: 0x0042C73C File Offset: 0x0042A93C
		// (set) Token: 0x06004853 RID: 18515 RVA: 0x0042C7F0 File Offset: 0x0042A9F0
		public string RadInfoGeneralMACAddress_A41837Value
		{
			get
			{
				short num = (short)652659472;
				short num2 = num;
				num = (short)831048464;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1185218560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1543569409;
				if (num != 0)
				{
				}
				num = (short)1936719872;
				if (num != 0)
				{
				}
				return this.radInfoGeneralMACAddress_A41837.Value;
			}
			set
			{
				short num = (short)228597832;
				short num2 = num;
				num = (short)1472995400;
				switch (num2 == num)
				{
				default:
				{
					num = (short)691732480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1037959169;
				if (num != 0)
				{
				}
				num = (short)1049493504;
				if (num != 0)
				{
				}
				this.radInfoGeneralMACAddress_A41837.Value = value;
			}
		}

		// Token: 0x17002536 RID: 9526
		// (get) Token: 0x06004854 RID: 18516 RVA: 0x0042C8A4 File Offset: 0x0042AAA4
		public global::AcpBusinessLayer.AcpFieldX<string, string> RadInfoGeneralMACAddress_A41837
		{
			get
			{
				short num = (short)907977056;
				short num2 = num;
				num = (short)1470865760;
				switch (num2 == num)
				{
				default:
				{
					num = (short)341245952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)771948545;
				if (num != 0)
				{
				}
				num = (short)385220608;
				if (num != 0)
				{
				}
				return this.radInfoGeneralMACAddress_A41837;
			}
		}

		// Token: 0x17002537 RID: 9527
		// (get) Token: 0x06004855 RID: 18517 RVA: 0x0042C954 File Offset: 0x0042AB54
		// (set) Token: 0x06004856 RID: 18518 RVA: 0x0042CA04 File Offset: 0x0042AC04
		public string RadInfoGeneralMACAddress_A41837_UIValue
		{
			get
			{
				short num = (short)431062438;
				short num2 = num;
				num = (short)536051110;
				switch (num2 == num)
				{
				default:
				{
					num = (short)663617536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1503330305;
				if (num != 0)
				{
				}
				num = (short)917504;
				if (num != 0)
				{
				}
				return this.radInfoGeneralMACAddress_A41837.UIValue;
			}
			set
			{
				short num = (short)35362372;
				short num2 = num;
				num = (short)1806603844;
				switch (num2 == num)
				{
				default:
				{
					num = (short)484900864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1637810176;
				if (num != 0)
				{
				}
				num = (short)630194177;
				if (num != 0)
				{
				}
				this.radInfoGeneralMACAddress_A41837.UIValue = value;
			}
		}

		// Token: 0x17002538 RID: 9528
		// (get) Token: 0x06004857 RID: 18519 RVA: 0x0042CAB8 File Offset: 0x0042ACB8
		// (set) Token: 0x06004858 RID: 18520 RVA: 0x0042CB6C File Offset: 0x0042AD6C
		public bool RadInfoGeneralMACAddress_A41837_Applicable
		{
			get
			{
				short num = (short)950644045;
				short num2 = num;
				num = (short)1105833293;
				switch (num2 == num)
				{
				default:
				{
					num = (short)246546432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1859780609;
				if (num != 0)
				{
				}
				num = (short)1094778880;
				if (num != 0)
				{
				}
				return this.radInfoGeneralMACAddress_A41837.Applicable;
			}
			set
			{
				short num = (short)964552214;
				short num2 = num;
				num = (short)1234232854;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2090139648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1808662529;
				if (num != 0)
				{
				}
				num = (short)1008074752;
				if (num != 0)
				{
				}
				this.radInfoGeneralMACAddress_A41837.Applicable = value;
			}
		}

		// Token: 0x17002539 RID: 9529
		// (get) Token: 0x06004859 RID: 18521 RVA: 0x0042CC24 File Offset: 0x0042AE24
		// (set) Token: 0x0600485A RID: 18522 RVA: 0x0042CCD8 File Offset: 0x0042AED8
		public bool RadInfoGeneralMACAddress_A41837_Valid
		{
			get
			{
				short num = (short)1529713090;
				short num2 = num;
				num = (short)1440780738;
				switch (num2 == num)
				{
				default:
				{
					num = (short)121503744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)151715841;
				if (num != 0)
				{
				}
				num = (short)684523520;
				if (num != 0)
				{
				}
				return this.radInfoGeneralMACAddress_A41837.Valid;
			}
			set
			{
				short num = (short)2007621081;
				short num2 = num;
				num = (short)1406459353;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1182400512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)536543232;
				if (num != 0)
				{
				}
				num = (short)1092616193;
				if (num != 0)
				{
				}
				this.radInfoGeneralMACAddress_A41837.Valid = value;
			}
		}

		// Token: 0x1700253A RID: 9530
		// (get) Token: 0x0600485B RID: 18523 RVA: 0x0042CD8C File Offset: 0x0042AF8C
		// (set) Token: 0x0600485C RID: 18524 RVA: 0x0042CE40 File Offset: 0x0042B040
		public bool RadInfoGeneralMACAddress_A41837_Visible
		{
			get
			{
				short num = (short)2071789569;
				if (num != 0)
				{
				}
				num = (short)384892928;
				short num2 = num;
				num = (short)1252900890;
				short num3 = num;
				num = (short)1439678490;
				switch (num3 == num)
				{
				}
				num = (short)1656291328;
				if (num != 0)
				{
				}
				return this.radInfoGeneralMACAddress_A41837.Visible;
			}
			set
			{
				short num = (short)497960886;
				short num2 = num;
				num = (short)2096318390;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1408958464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1553727489;
				if (num != 0)
				{
				}
				num = (short)1173815296;
				if (num != 0)
				{
				}
				this.radInfoGeneralMACAddress_A41837.Visible = value;
			}
		}

		// Token: 0x1700253B RID: 9531
		// (get) Token: 0x0600485D RID: 18525 RVA: 0x0042CEF4 File Offset: 0x0042B0F4
		// (set) Token: 0x0600485E RID: 18526 RVA: 0x0042CFAC File Offset: 0x0042B1AC
		public bool RadInfoGeneralMACAddress_A41837_Editable
		{
			get
			{
				short num = (short)1388159115;
				short num2 = num;
				num = (short)229482635;
				switch (num2 == num)
				{
				default:
				{
					num = (short)456982528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1417412608;
				if (num != 0)
				{
				}
				num = (short)108199937;
				if (num != 0)
				{
				}
				return this.radInfoGeneralMACAddress_A41837.Editable;
			}
			set
			{
				short num = (short)1224212481;
				if (num != 0)
				{
				}
				num = (short)1717436416;
				short num2 = num;
				num = (short)192680888;
				short num3 = num;
				num = (short)321393592;
				switch (num3 == num)
				{
				}
				num = (short)1927217152;
				if (num != 0)
				{
				}
				this.radInfoGeneralMACAddress_A41837.Editable = value;
			}
		}

		// Token: 0x1700253C RID: 9532
		// (get) Token: 0x0600485F RID: 18527 RVA: 0x0042D060 File Offset: 0x0042B260
		internal string RadInfoGeneralMACAddress_A41837_UILabel
		{
			get
			{
				short num = (short)1412612095;
				short num2 = num;
				num = (short)1879425023;
				switch (num2 == num)
				{
				default:
				{
					num = (short)474939392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1706229761;
				if (num != 0)
				{
				}
				num = (short)106430464;
				if (num != 0)
				{
				}
				return this.radInfoGeneralMACAddress_A41837.UIName;
			}
		}

		// Token: 0x1700253D RID: 9533
		// (get) Token: 0x06004860 RID: 18528 RVA: 0x0042D118 File Offset: 0x0042B318
		// (set) Token: 0x06004861 RID: 18529 RVA: 0x0042D1CC File Offset: 0x0042B3CC
		internal bool RadInfoGeneralMACAddress_A41837_HiddenStatic
		{
			get
			{
				short num = (short)530384777;
				short num2 = num;
				num = (short)474285961;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1095565312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)376635393;
				if (num != 0)
				{
				}
				num = (short)1334181888;
				if (num != 0)
				{
				}
				return this.radInfoGeneralMACAddress_A41837.HiddenStatic;
			}
			set
			{
				short num = (short)1526262844;
				short num2 = num;
				num = (short)1092873276;
				switch (num2 == num)
				{
				default:
				{
					num = (short)359858176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)214040577;
				if (num != 0)
				{
				}
				num = (short)89718784;
				if (num != 0)
				{
				}
				this.radInfoGeneralMACAddress_A41837.HiddenStatic = value;
			}
		}

		// Token: 0x1700253E RID: 9534
		// (get) Token: 0x06004862 RID: 18530 RVA: 0x0042D280 File Offset: 0x0042B480
		// (set) Token: 0x06004863 RID: 18531 RVA: 0x0042D334 File Offset: 0x0042B534
		internal bool RadInfoGeneralMACAddress_A41837_HiddenDynamic
		{
			get
			{
				short num = (short)1710620673;
				if (num != 0)
				{
				}
				num = (short)282263552;
				short num2 = num;
				num = (short)997196898;
				short num3 = num;
				num = (short)105448546;
				switch (num3 == num)
				{
				}
				num = (short)1016135680;
				if (num != 0)
				{
				}
				return this.radInfoGeneralMACAddress_A41837.HiddenDynamic;
			}
			set
			{
				short num = (short)10847816;
				short num2 = num;
				num = (short)949323336;
				switch (num2 == num)
				{
				default:
				{
					num = (short)955121664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)797638657;
				if (num != 0)
				{
				}
				num = (short)1752956928;
				if (num != 0)
				{
				}
				this.radInfoGeneralMACAddress_A41837.HiddenDynamic = value;
			}
		}

		// Token: 0x1700253F RID: 9535
		// (get) Token: 0x06004864 RID: 18532 RVA: 0x0042D3EC File Offset: 0x0042B5EC
		public bool RadInfoGeneralMACAddress_A41837_HasDiffs
		{
			get
			{
				short num = (short)723741721;
				short num2 = num;
				num = (short)1649241113;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1937899520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1638989824;
				if (num != 0)
				{
				}
				num = (short)1013907457;
				if (num != 0)
				{
				}
				return this.radInfoGeneralMACAddress_A41837._HasDiffs;
			}
		}

		// Token: 0x17002540 RID: 9536
		// (get) Token: 0x06004865 RID: 18533 RVA: 0x0042D4A0 File Offset: 0x0042B6A0
		// (set) Token: 0x06004866 RID: 18534 RVA: 0x0042D554 File Offset: 0x0042B754
		public string RadInfoGeneralSecureHardwareTypeValue
		{
			get
			{
				short num = (short)2142386153;
				short num2 = num;
				num = (short)65550313;
				switch (num2 == num)
				{
				default:
				{
					num = (short)574357504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)278593537;
				if (num != 0)
				{
				}
				num = (short)546308096;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSecureHardwareType.Value;
			}
			set
			{
				short num = (short)2073983882;
				short num2 = num;
				num = (short)14252938;
				switch (num2 == num)
				{
				default:
				{
					num = (short)714997760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)334495745;
				if (num != 0)
				{
				}
				num = (short)696320000;
				if (num != 0)
				{
				}
				this.radInfoGeneralSecureHardwareType.Value = value;
			}
		}

		// Token: 0x17002541 RID: 9537
		// (get) Token: 0x06004867 RID: 18535 RVA: 0x0042D608 File Offset: 0x0042B808
		public global::AcpBusinessLayer.AcpField<string> RadInfoGeneralSecureHardwareType
		{
			get
			{
				short num = (short)656409700;
				short num2 = num;
				num = (short)682820708;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1163395072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)804782081;
				if (num != 0)
				{
				}
				num = (short)1302200320;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSecureHardwareType;
			}
		}

		// Token: 0x17002542 RID: 9538
		// (get) Token: 0x06004868 RID: 18536 RVA: 0x0042D6B8 File Offset: 0x0042B8B8
		// (set) Token: 0x06004869 RID: 18537 RVA: 0x0042D770 File Offset: 0x0042B970
		public string RadInfoGeneralSecureHardwareType_UIValue
		{
			get
			{
				short num = (short)1175727968;
				short num2 = num;
				num = (short)241643360;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1497104384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1398538241;
				if (num != 0)
				{
				}
				num = (short)1225064448;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSecureHardwareType.Value;
			}
			set
			{
				short num = (short)2143265473;
				short num2 = num;
				num = (short)1089512129;
				switch (num2 == num)
				{
				default:
				{
					num = (short)38404096;
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
				num = (short)475332608;
				if (num != 0)
				{
				}
				this.radInfoGeneralSecureHardwareType.Value = value;
			}
		}

		// Token: 0x17002543 RID: 9539
		// (get) Token: 0x0600486A RID: 18538 RVA: 0x0042D824 File Offset: 0x0042BA24
		// (set) Token: 0x0600486B RID: 18539 RVA: 0x0042D8DC File Offset: 0x0042BADC
		public bool RadInfoGeneralSecureHardwareType_Applicable
		{
			get
			{
				short num = (short)479534482;
				short num2 = num;
				num = (short)944315794;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1473052672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1349124096;
				if (num != 0)
				{
				}
				num = (short)919732225;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSecureHardwareType.Applicable;
			}
			set
			{
				short num = (short)759245661;
				short num2 = num;
				num = (short)1274162013;
				switch (num2 == num)
				{
				default:
				{
					num = (short)600113152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)781254657;
				if (num != 0)
				{
				}
				num = (short)1252917248;
				if (num != 0)
				{
				}
				this.radInfoGeneralSecureHardwareType.Applicable = value;
			}
		}

		// Token: 0x17002544 RID: 9540
		// (get) Token: 0x0600486C RID: 18540 RVA: 0x0042D990 File Offset: 0x0042BB90
		// (set) Token: 0x0600486D RID: 18541 RVA: 0x0042DA40 File Offset: 0x0042BC40
		public bool RadInfoGeneralSecureHardwareType_Valid
		{
			get
			{
				short num = (short)1967080486;
				short num2 = num;
				num = (short)623854630;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1897332736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)405012481;
				if (num != 0)
				{
				}
				num = (short)1849491456;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSecureHardwareType.Valid;
			}
			set
			{
				short num = (short)1750129164;
				short num2 = num;
				num = (short)699652620;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1645608960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)859439104;
				if (num != 0)
				{
				}
				num = (short)168165377;
				if (num != 0)
				{
				}
				this.radInfoGeneralSecureHardwareType.Valid = value;
			}
		}

		// Token: 0x17002545 RID: 9541
		// (get) Token: 0x0600486E RID: 18542 RVA: 0x0042DAF4 File Offset: 0x0042BCF4
		// (set) Token: 0x0600486F RID: 18543 RVA: 0x0042DBAC File Offset: 0x0042BDAC
		public bool RadInfoGeneralSecureHardwareType_Visible
		{
			get
			{
				short num = (short)1956575200;
				short num2 = num;
				num = (short)159250400;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1603469312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)141230081;
				if (num != 0)
				{
				}
				num = (short)2113339392;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSecureHardwareType.Visible;
			}
			set
			{
				short num = (short)2050748411;
				short num2 = num;
				num = (short)131133435;
				switch (num2 == num)
				{
				}
				num = (short)2049703936;
				if (num != 0)
				{
				}
				num = (short)1474691072;
				short num3 = num;
				num = (short)2130444289;
				if (num != 0)
				{
				}
				this.radInfoGeneralSecureHardwareType.Visible = value;
			}
		}

		// Token: 0x17002546 RID: 9542
		// (get) Token: 0x06004870 RID: 18544 RVA: 0x0042DC60 File Offset: 0x0042BE60
		// (set) Token: 0x06004871 RID: 18545 RVA: 0x0042DD18 File Offset: 0x0042BF18
		public bool RadInfoGeneralSecureHardwareType_Editable
		{
			get
			{
				short num = (short)1894121473;
				if (num != 0)
				{
				}
				num = (short)648401768;
				short num2 = num;
				num = (short)204526440;
				switch (num2 == num)
				{
				}
				num = (short)615055360;
				short num3 = num;
				num = (short)959119360;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSecureHardwareType.Editable;
			}
			set
			{
				short num = (short)1875934363;
				short num2 = num;
				num = (short)1245215899;
				switch (num2 == num)
				{
				}
				num = (short)1811873792;
				if (num != 0)
				{
				}
				num = (short)944963584;
				short num3 = num;
				num = (short)621871105;
				if (num != 0)
				{
				}
				this.radInfoGeneralSecureHardwareType.Editable = value;
			}
		}

		// Token: 0x17002547 RID: 9543
		// (get) Token: 0x06004872 RID: 18546 RVA: 0x0042DDD0 File Offset: 0x0042BFD0
		internal string RadInfoGeneralSecureHardwareType_UILabel
		{
			get
			{
				short num = (short)1795805960;
				short num2 = num;
				num = (short)51761928;
				switch (num2 == num)
				{
				}
				num = (short)902168576;
				if (num != 0)
				{
				}
				num = (short)346882048;
				short num3 = num;
				num = (short)583467009;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSecureHardwareType.UIName;
			}
		}

		// Token: 0x17002548 RID: 9544
		// (get) Token: 0x06004873 RID: 18547 RVA: 0x0042DE84 File Offset: 0x0042C084
		// (set) Token: 0x06004874 RID: 18548 RVA: 0x0042DF38 File Offset: 0x0042C138
		internal bool RadInfoGeneralSecureHardwareType_HiddenStatic
		{
			get
			{
				short num = (short)1805256269;
				short num2 = num;
				num = (short)1985021517;
				switch (num2 == num)
				{
				}
				num = (short)1233125376;
				if (num != 0)
				{
				}
				num = (short)1659043840;
				short num3 = num;
				num = (short)50528257;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSecureHardwareType.HiddenStatic;
			}
			set
			{
				short num = (short)1718878209;
				if (num != 0)
				{
				}
				num = (short)768843017;
				short num2 = num;
				num = (short)1244962057;
				switch (num2 == num)
				{
				}
				num = (short)2027683840;
				short num3 = num;
				num = (short)1787232256;
				if (num != 0)
				{
				}
				this.radInfoGeneralSecureHardwareType.HiddenStatic = value;
			}
		}

		// Token: 0x17002549 RID: 9545
		// (get) Token: 0x06004875 RID: 18549 RVA: 0x0042DFEC File Offset: 0x0042C1EC
		// (set) Token: 0x06004876 RID: 18550 RVA: 0x0042E0A4 File Offset: 0x0042C2A4
		internal bool RadInfoGeneralSecureHardwareType_HiddenDynamic
		{
			get
			{
				short num = (short)1175472051;
				short num2 = num;
				num = (short)568608691;
				switch (num2 == num)
				{
				}
				num = (short)297009152;
				if (num != 0)
				{
				}
				num = (short)312213504;
				short num3 = num;
				num = (short)2071527425;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSecureHardwareType.HiddenDynamic;
			}
			set
			{
				short num = (short)475612566;
				short num2 = num;
				num = (short)2122139030;
				switch (num2 == num)
				{
				}
				num = (short)1440022529;
				if (num != 0)
				{
				}
				num = (short)1575092224;
				short num3 = num;
				num = (short)3997696;
				if (num != 0)
				{
				}
				this.radInfoGeneralSecureHardwareType.HiddenDynamic = value;
			}
		}

		// Token: 0x1700254A RID: 9546
		// (get) Token: 0x06004877 RID: 18551 RVA: 0x0042E15C File Offset: 0x0042C35C
		public bool RadInfoGeneralSecureHardwareType_HasDiffs
		{
			get
			{
				short num = (short)765498858;
				short num2 = num;
				num = (short)509449706;
				switch (num2 == num)
				{
				}
				num = (short)22675457;
				if (num != 0)
				{
				}
				num = (short)756875264;
				short num3 = num;
				num = (short)1100283904;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSecureHardwareType._HasDiffs;
			}
		}

		// Token: 0x1700254B RID: 9547
		// (get) Token: 0x06004878 RID: 18552 RVA: 0x0042E210 File Offset: 0x0042C410
		// (set) Token: 0x06004879 RID: 18553 RVA: 0x0042E2C4 File Offset: 0x0042C4C4
		public string RadInfoGeneralSecureHardwareVersionValue
		{
			get
			{
				short num = (short)1542967632;
				short num2 = num;
				num = (short)470405456;
				switch (num2 == num)
				{
				}
				num = (short)865337345;
				if (num != 0)
				{
				}
				num = (short)370147328;
				short num3 = num;
				num = (short)970063872;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSecureHardwareVersion.Value;
			}
			set
			{
				short num = (short)650009855;
				short num2 = num;
				num = (short)128081151;
				switch (num2 == num)
				{
				}
				num = (short)862715905;
				if (num != 0)
				{
				}
				num = (short)459472896;
				short num3 = num;
				num = (short)1367998464;
				if (num != 0)
				{
				}
				this.radInfoGeneralSecureHardwareVersion.Value = value;
			}
		}

		// Token: 0x1700254C RID: 9548
		// (get) Token: 0x0600487A RID: 18554 RVA: 0x0042E378 File Offset: 0x0042C578
		public global::AcpBusinessLayer.AcpField<string> RadInfoGeneralSecureHardwareVersion
		{
			get
			{
				short num = (short)868995354;
				short num2 = num;
				num = (short)946786586;
				switch (num2 == num)
				{
				}
				num = (short)2046164992;
				if (num != 0)
				{
				}
				num = (short)13500416;
				short num3 = num;
				num = (short)684261377;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSecureHardwareVersion;
			}
		}

		// Token: 0x1700254D RID: 9549
		// (get) Token: 0x0600487B RID: 18555 RVA: 0x0042E428 File Offset: 0x0042C628
		// (set) Token: 0x0600487C RID: 18556 RVA: 0x0042E4DC File Offset: 0x0042C6DC
		public string RadInfoGeneralSecureHardwareVersion_UIValue
		{
			get
			{
				short num = (short)1602986686;
				short num2 = num;
				num = (short)493789886;
				switch (num2 == num)
				{
				}
				num = (short)1799225345;
				if (num != 0)
				{
				}
				num = (short)1812987904;
				short num3 = num;
				num = (short)1599406080;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSecureHardwareVersion.Value;
			}
			set
			{
				short num = (short)856951596;
				short num2 = num;
				num = (short)1322453804;
				switch (num2 == num)
				{
				}
				num = (short)189988865;
				if (num != 0)
				{
				}
				num = (short)1651048448;
				short num3 = num;
				num = (short)577175552;
				if (num != 0)
				{
				}
				this.radInfoGeneralSecureHardwareVersion.Value = value;
			}
		}

		// Token: 0x1700254E RID: 9550
		// (get) Token: 0x0600487D RID: 18557 RVA: 0x0042E590 File Offset: 0x0042C790
		// (set) Token: 0x0600487E RID: 18558 RVA: 0x0042E644 File Offset: 0x0042C844
		public bool RadInfoGeneralSecureHardwareVersion_Applicable
		{
			get
			{
				short num = (short)1297391914;
				short num2 = num;
				num = (short)1881252138;
				switch (num2 == num)
				{
				}
				num = (short)1498939392;
				if (num != 0)
				{
				}
				num = (short)1089339392;
				short num3 = num;
				num = (short)1260453889;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSecureHardwareVersion.Applicable;
			}
			set
			{
				short num = (short)2092949874;
				short num2 = num;
				num = (short)448061810;
				switch (num2 == num)
				{
				}
				num = (short)968622081;
				if (num != 0)
				{
				}
				num = (short)1470431232;
				short num3 = num;
				num = (short)1543503872;
				if (num != 0)
				{
				}
				this.radInfoGeneralSecureHardwareVersion.Applicable = value;
			}
		}

		// Token: 0x1700254F RID: 9551
		// (get) Token: 0x0600487F RID: 18559 RVA: 0x0042E6F8 File Offset: 0x0042C8F8
		// (set) Token: 0x06004880 RID: 18560 RVA: 0x0042E7B0 File Offset: 0x0042C9B0
		public bool RadInfoGeneralSecureHardwareVersion_Valid
		{
			get
			{
				short num = (short)684582966;
				short num2 = num;
				num = (short)528148534;
				switch (num2 == num)
				{
				}
				num = (short)266207233;
				if (num != 0)
				{
				}
				num = (short)40108032;
				short num3 = num;
				num = (short)1000669184;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSecureHardwareVersion.Valid;
			}
			set
			{
				short num = (short)1773520406;
				short num2 = num;
				num = (short)168216086;
				switch (num2 == num)
				{
				}
				num = (short)1713897473;
				if (num != 0)
				{
				}
				num = (short)1495465984;
				short num3 = num;
				num = (short)1416691712;
				if (num != 0)
				{
				}
				this.radInfoGeneralSecureHardwareVersion.Valid = value;
			}
		}

		// Token: 0x17002550 RID: 9552
		// (get) Token: 0x06004881 RID: 18561 RVA: 0x0042E868 File Offset: 0x0042CA68
		// (set) Token: 0x06004882 RID: 18562 RVA: 0x0042E91C File Offset: 0x0042CB1C
		public bool RadInfoGeneralSecureHardwareVersion_Visible
		{
			get
			{
				short num = (short)159825027;
				short num2 = num;
				num = (short)1984281731;
				switch (num2 == num)
				{
				}
				num = (short)470941696;
				if (num != 0)
				{
				}
				num = (short)940572672;
				short num3 = num;
				num = (short)791478273;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSecureHardwareVersion.Visible;
			}
			set
			{
				short num = (short)1566398629;
				short num2 = num;
				num = (short)964057253;
				switch (num2 == num)
				{
				}
				num = (short)568459264;
				if (num != 0)
				{
				}
				num = (short)1402732544;
				short num3 = num;
				num = (short)886636545;
				if (num != 0)
				{
				}
				this.radInfoGeneralSecureHardwareVersion.Visible = value;
			}
		}

		// Token: 0x17002551 RID: 9553
		// (get) Token: 0x06004883 RID: 18563 RVA: 0x0042E9D0 File Offset: 0x0042CBD0
		// (set) Token: 0x06004884 RID: 18564 RVA: 0x0042EA88 File Offset: 0x0042CC88
		public bool RadInfoGeneralSecureHardwareVersion_Editable
		{
			get
			{
				short num = (short)1316096937;
				short num2 = num;
				num = (short)1537870761;
				switch (num2 == num)
				{
				}
				num = (short)1369440257;
				if (num != 0)
				{
				}
				num = (short)1102381056;
				short num3 = num;
				num = (short)2029125632;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSecureHardwareVersion.Editable;
			}
			set
			{
				short num = (short)694935351;
				short num2 = num;
				num = (short)1649532727;
				switch (num2 == num)
				{
				}
				num = (short)1425997825;
				if (num != 0)
				{
				}
				num = (short)820969472;
				short num3 = num;
				num = (short)1839661056;
				if (num != 0)
				{
				}
				this.radInfoGeneralSecureHardwareVersion.Editable = value;
			}
		}

		// Token: 0x17002552 RID: 9554
		// (get) Token: 0x06004885 RID: 18565 RVA: 0x0042EB3C File Offset: 0x0042CD3C
		internal string RadInfoGeneralSecureHardwareVersion_UILabel
		{
			get
			{
				short num = (short)100510611;
				short num2 = num;
				num = (short)1983622035;
				switch (num2 == num)
				{
				}
				num = (short)1678901248;
				if (num != 0)
				{
				}
				num = (short)2143617024;
				short num3 = num;
				num = (short)445382657;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSecureHardwareVersion.UIName;
			}
		}

		// Token: 0x17002553 RID: 9555
		// (get) Token: 0x06004886 RID: 18566 RVA: 0x0042EBF0 File Offset: 0x0042CDF0
		// (set) Token: 0x06004887 RID: 18567 RVA: 0x0042ECA4 File Offset: 0x0042CEA4
		internal bool RadInfoGeneralSecureHardwareVersion_HiddenStatic
		{
			get
			{
				short num = (short)1050683812;
				short num2 = num;
				num = (short)788277668;
				switch (num2 == num)
				{
				}
				num = (short)1991704577;
				if (num != 0)
				{
				}
				num = (short)936640512;
				short num3 = num;
				num = (short)886833152;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSecureHardwareVersion.HiddenStatic;
			}
			set
			{
				short num = (short)2132082689;
				if (num != 0)
				{
				}
				num = (short)1166944808;
				short num2 = num;
				num = (short)1895377448;
				switch (num2 == num)
				{
				}
				num = (short)536150016;
				short num3 = num;
				num = (short)1459945472;
				if (num != 0)
				{
				}
				this.radInfoGeneralSecureHardwareVersion.HiddenStatic = value;
			}
		}

		// Token: 0x17002554 RID: 9556
		// (get) Token: 0x06004888 RID: 18568 RVA: 0x0042ED5C File Offset: 0x0042CF5C
		// (set) Token: 0x06004889 RID: 18569 RVA: 0x0042EE10 File Offset: 0x0042D010
		internal bool RadInfoGeneralSecureHardwareVersion_HiddenDynamic
		{
			get
			{
				short num = (short)2142102817;
				short num2 = num;
				num = (short)390522145;
				switch (num2 == num)
				{
				}
				num = (short)30015489;
				if (num != 0)
				{
				}
				num = (short)590479360;
				short num3 = num;
				num = (short)627638272;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSecureHardwareVersion.HiddenDynamic;
			}
			set
			{
				short num = (short)295618220;
				short num2 = num;
				num = (short)466929324;
				switch (num2 == num)
				{
				}
				num = (short)1082982400;
				if (num != 0)
				{
				}
				num = (short)1009713152;
				short num3 = num;
				num = (short)552337409;
				if (num != 0)
				{
				}
				this.radInfoGeneralSecureHardwareVersion.HiddenDynamic = value;
			}
		}

		// Token: 0x17002555 RID: 9557
		// (get) Token: 0x0600488A RID: 18570 RVA: 0x0042EEC4 File Offset: 0x0042D0C4
		public bool RadInfoGeneralSecureHardwareVersion_HasDiffs
		{
			get
			{
				short num = (short)1738600680;
				short num2 = num;
				num = (short)1843196136;
				switch (num2 == num)
				{
				}
				num = (short)21233664;
				if (num != 0)
				{
				}
				num = (short)675020800;
				short num3 = num;
				num = (short)1944649729;
				if (num != 0)
				{
				}
				return this.radInfoGeneralSecureHardwareVersion._HasDiffs;
			}
		}

		// Token: 0x17002556 RID: 9558
		// (get) Token: 0x0600488B RID: 18571 RVA: 0x0042EF78 File Offset: 0x0042D178
		// (set) Token: 0x0600488C RID: 18572 RVA: 0x0042F030 File Offset: 0x0042D230
		public string RadInfoGeneralWiFiMACAddress_42509Value
		{
			get
			{
				short num = (short)1290403841;
				if (num != 0)
				{
				}
				num = (short)312999582;
				short num2 = num;
				num = (short)1356201630;
				switch (num2 == num)
				{
				}
				num = (short)2138636288;
				short num3 = num;
				num = (short)1700528128;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiMACAddress_42509.Value;
			}
			set
			{
				short num = (short)876563;
				short num2 = num;
				num = (short)1804296211;
				switch (num2 == num)
				{
				}
				num = (short)519897089;
				if (num != 0)
				{
				}
				num = (short)1578041344;
				short num3 = num;
				num = (short)173998080;
				if (num != 0)
				{
				}
				this.radInfoGeneralWiFiMACAddress_42509.Value = value;
			}
		}

		// Token: 0x17002557 RID: 9559
		// (get) Token: 0x0600488D RID: 18573 RVA: 0x0042F0E8 File Offset: 0x0042D2E8
		public global::AcpBusinessLayer.AcpFieldX<string, string> RadInfoGeneralWiFiMACAddress_42509
		{
			get
			{
				short num = (short)175598311;
				short num2 = num;
				num = (short)2116250343;
				switch (num2 == num)
				{
				}
				num = (short)1828978689;
				if (num != 0)
				{
				}
				num = (short)944701440;
				short num3 = num;
				num = (short)203161600;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiMACAddress_42509;
			}
		}

		// Token: 0x17002558 RID: 9560
		// (get) Token: 0x0600488E RID: 18574 RVA: 0x0042F194 File Offset: 0x0042D394
		// (set) Token: 0x0600488F RID: 18575 RVA: 0x0042F248 File Offset: 0x0042D448
		public string RadInfoGeneralWiFiMACAddress_42509_UIValue
		{
			get
			{
				short num = (short)1226768385;
				if (num != 0)
				{
				}
				num = (short)1107192102;
				short num2 = num;
				num = (short)834496806;
				switch (num2 == num)
				{
				}
				num = (short)1167720448;
				short num3 = num;
				num = (short)1701314560;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiMACAddress_42509.UIValue;
			}
			set
			{
				short num = (short)1438649354;
				short num2 = num;
				num = (short)1033964554;
				switch (num2 == num)
				{
				}
				num = (short)1849884673;
				if (num != 0)
				{
				}
				num = (short)1251868672;
				short num3 = num;
				num = (short)265617408;
				if (num != 0)
				{
				}
				this.radInfoGeneralWiFiMACAddress_42509.UIValue = value;
			}
		}

		// Token: 0x17002559 RID: 9561
		// (get) Token: 0x06004890 RID: 18576 RVA: 0x0042F2FC File Offset: 0x0042D4FC
		// (set) Token: 0x06004891 RID: 18577 RVA: 0x0042F3B0 File Offset: 0x0042D5B0
		public bool RadInfoGeneralWiFiMACAddress_42509_Applicable
		{
			get
			{
				short num = (short)1222089186;
				short num2 = num;
				num = (short)799709666;
				switch (num2 == num)
				{
				}
				num = (short)1646264320;
				if (num != 0)
				{
				}
				num = (short)469303296;
				short num3 = num;
				num = (short)54722561;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiMACAddress_42509.Applicable;
			}
			set
			{
				short num = (short)1465122817;
				if (num != 0)
				{
				}
				num = (short)18738654;
				short num2 = num;
				num = (short)513207774;
				switch (num2 == num)
				{
				}
				num = (short)753008640;
				short num3 = num;
				num = (short)1593049088;
				if (num != 0)
				{
				}
				this.radInfoGeneralWiFiMACAddress_42509.Applicable = value;
			}
		}

		// Token: 0x1700255A RID: 9562
		// (get) Token: 0x06004892 RID: 18578 RVA: 0x0042F464 File Offset: 0x0042D664
		// (set) Token: 0x06004893 RID: 18579 RVA: 0x0042F518 File Offset: 0x0042D718
		public bool RadInfoGeneralWiFiMACAddress_42509_Valid
		{
			get
			{
				short num = (short)624885761;
				if (num != 0)
				{
				}
				num = (short)1518988466;
				short num2 = num;
				num = (short)1036512434;
				switch (num2 == num)
				{
				}
				num = (short)1655308288;
				short num3 = num;
				num = (short)596639744;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiMACAddress_42509.Valid;
			}
			set
			{
				short num = (short)550292251;
				short num2 = num;
				num = (short)1719520027;
				switch (num2 == num)
				{
				}
				num = (short)1661468673;
				if (num != 0)
				{
				}
				num = (short)129433600;
				short num3 = num;
				num = (short)1959133184;
				if (num != 0)
				{
				}
				this.radInfoGeneralWiFiMACAddress_42509.Valid = value;
			}
		}

		// Token: 0x1700255B RID: 9563
		// (get) Token: 0x06004894 RID: 18580 RVA: 0x0042F5CC File Offset: 0x0042D7CC
		// (set) Token: 0x06004895 RID: 18581 RVA: 0x0042F680 File Offset: 0x0042D880
		public bool RadInfoGeneralWiFiMACAddress_42509_Visible
		{
			get
			{
				short num = (short)2061028739;
				short num2 = num;
				num = (short)293916035;
				switch (num2 == num)
				{
				}
				num = (short)334823424;
				if (num != 0)
				{
				}
				num = (short)656474112;
				short num3 = num;
				num = (short)635830273;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiMACAddress_42509.Visible;
			}
			set
			{
				short num = (short)2121731435;
				short num2 = num;
				num = (short)1636371819;
				switch (num2 == num)
				{
				}
				num = (short)1498021889;
				if (num != 0)
				{
				}
				num = (short)702808064;
				short num3 = num;
				num = (short)1885732864;
				if (num != 0)
				{
				}
				this.radInfoGeneralWiFiMACAddress_42509.Visible = value;
			}
		}

		// Token: 0x1700255C RID: 9564
		// (get) Token: 0x06004896 RID: 18582 RVA: 0x0042F734 File Offset: 0x0042D934
		// (set) Token: 0x06004897 RID: 18583 RVA: 0x0042F7E8 File Offset: 0x0042D9E8
		public bool RadInfoGeneralWiFiMACAddress_42509_Editable
		{
			get
			{
				short num = (short)1877418741;
				short num2 = num;
				num = (short)915546869;
				switch (num2 == num)
				{
				}
				num = (short)1871773697;
				if (num != 0)
				{
				}
				num = (short)1795293184;
				short num3 = num;
				num = (short)114819072;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiMACAddress_42509.Editable;
			}
			set
			{
				short num = (short)1697955797;
				short num2 = num;
				num = (short)720355285;
				switch (num2 == num)
				{
				}
				num = (short)854982657;
				if (num != 0)
				{
				}
				num = (short)616431616;
				short num3 = num;
				num = (short)539295744;
				if (num != 0)
				{
				}
				this.radInfoGeneralWiFiMACAddress_42509.Editable = value;
			}
		}

		// Token: 0x1700255D RID: 9565
		// (get) Token: 0x06004898 RID: 18584 RVA: 0x0042F89C File Offset: 0x0042DA9C
		internal string RadInfoGeneralWiFiMACAddress_42509_UILabel
		{
			get
			{
				short num = (short)169584294;
				short num2 = num;
				num = (short)1779738278;
				switch (num2 == num)
				{
				}
				num = (short)1510473728;
				if (num != 0)
				{
				}
				num = (short)2084110336;
				short num3 = num;
				num = (short)1473708033;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiMACAddress_42509.UIName;
			}
		}

		// Token: 0x1700255E RID: 9566
		// (get) Token: 0x06004899 RID: 18585 RVA: 0x0042F94C File Offset: 0x0042DB4C
		// (set) Token: 0x0600489A RID: 18586 RVA: 0x0042FA00 File Offset: 0x0042DC00
		internal bool RadInfoGeneralWiFiMACAddress_42509_HiddenStatic
		{
			get
			{
				short num = (short)1950445175;
				short num2 = num;
				num = (short)1399746167;
				switch (num2 == num)
				{
				}
				num = (short)1096613888;
				if (num != 0)
				{
				}
				num = (short)1884291072;
				short num3 = num;
				num = (short)533659649;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiMACAddress_42509.HiddenStatic;
			}
			set
			{
				short num = (short)863024375;
				short num2 = num;
				num = (short)1624814839;
				switch (num2 == num)
				{
				}
				num = (short)1510604801;
				if (num != 0)
				{
				}
				num = (short)1621884928;
				short num3 = num;
				num = (short)256376832;
				if (num != 0)
				{
				}
				this.radInfoGeneralWiFiMACAddress_42509.HiddenStatic = value;
			}
		}

		// Token: 0x1700255F RID: 9567
		// (get) Token: 0x0600489B RID: 18587 RVA: 0x0042FAB4 File Offset: 0x0042DCB4
		// (set) Token: 0x0600489C RID: 18588 RVA: 0x0042FB68 File Offset: 0x0042DD68
		internal bool RadInfoGeneralWiFiMACAddress_42509_HiddenDynamic
		{
			get
			{
				short num = (short)72027930;
				short num2 = num;
				num = (short)1066209050;
				switch (num2 == num)
				{
				}
				num = (short)812646401;
				if (num != 0)
				{
				}
				num = (short)1838219264;
				short num3 = num;
				num = (short)295436288;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiMACAddress_42509.HiddenDynamic;
			}
			set
			{
				short num = (short)2084005583;
				short num2 = num;
				num = (short)124413647;
				switch (num2 == num)
				{
				}
				num = (short)954531841;
				if (num != 0)
				{
				}
				num = (short)1498218496;
				short num3 = num;
				num = (short)667942912;
				if (num != 0)
				{
				}
				this.radInfoGeneralWiFiMACAddress_42509.HiddenDynamic = value;
			}
		}

		// Token: 0x17002560 RID: 9568
		// (get) Token: 0x0600489D RID: 18589 RVA: 0x0042FC1C File Offset: 0x0042DE1C
		public bool RadInfoGeneralWiFiMACAddress_42509_HasDiffs
		{
			get
			{
				short num = (short)494131404;
				short num2 = num;
				num = (short)422631628;
				switch (num2 == num)
				{
				}
				num = (short)1212612609;
				if (num != 0)
				{
				}
				num = (short)973537280;
				short num3 = num;
				num = (short)443809792;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiMACAddress_42509._HasDiffs;
			}
		}

		// Token: 0x17002561 RID: 9569
		// (get) Token: 0x0600489E RID: 18590 RVA: 0x0042FCD0 File Offset: 0x0042DED0
		// (set) Token: 0x0600489F RID: 18591 RVA: 0x0042FD88 File Offset: 0x0042DF88
		public string RadInfoGeneralWiFiBTMACAddress_42510Value
		{
			get
			{
				short num = (short)69204279;
				short num2 = num;
				num = (short)455014711;
				switch (num2 == num)
				{
				}
				num = (short)1428553729;
				if (num != 0)
				{
				}
				num = (short)1386676224;
				short num3 = num;
				num = (short)1563099136;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiBTMACAddress_42510.Value;
			}
			set
			{
				short num = (short)1975750197;
				short num2 = num;
				num = (short)907185717;
				switch (num2 == num)
				{
				}
				num = (short)136183808;
				if (num != 0)
				{
				}
				num = (short)1071185920;
				short num3 = num;
				num = (short)1529217025;
				if (num != 0)
				{
				}
				this.radInfoGeneralWiFiBTMACAddress_42510.Value = value;
			}
		}

		// Token: 0x17002562 RID: 9570
		// (get) Token: 0x060048A0 RID: 18592 RVA: 0x0042FE3C File Offset: 0x0042E03C
		public global::AcpBusinessLayer.AcpFieldX<string, string> RadInfoGeneralWiFiBTMACAddress_42510
		{
			get
			{
				short num = (short)1993539585;
				if (num != 0)
				{
				}
				num = (short)1442693455;
				short num2 = num;
				num = (short)1765065039;
				switch (num2 == num)
				{
				}
				num = (short)1425932288;
				short num3 = num;
				num = (short)490733568;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiBTMACAddress_42510;
			}
		}

		// Token: 0x17002563 RID: 9571
		// (get) Token: 0x060048A1 RID: 18593 RVA: 0x0042FEF0 File Offset: 0x0042E0F0
		// (set) Token: 0x060048A2 RID: 18594 RVA: 0x0042FFA4 File Offset: 0x0042E1A4
		public string RadInfoGeneralWiFiBTMACAddress_42510_UIValue
		{
			get
			{
				short num = (short)5125468;
				short num2 = num;
				num = (short)915289436;
				switch (num2 == num)
				{
				}
				num = (short)1990328321;
				if (num != 0)
				{
				}
				num = (short)1716191232;
				short num3 = num;
				num = (short)1854668800;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiBTMACAddress_42510.UIValue;
			}
			set
			{
				short num = (short)165806080;
				short num2 = num;
				num = (short)127205377;
				if (num != 0)
				{
				}
				num = (short)1932223814;
				short num3 = num;
				num = (short)218719558;
				switch (num3 == num)
				{
				}
				num = (short)749666304;
				if (num != 0)
				{
				}
				this.radInfoGeneralWiFiBTMACAddress_42510.UIValue = value;
			}
		}

		// Token: 0x17002564 RID: 9572
		// (get) Token: 0x060048A3 RID: 18595 RVA: 0x00430058 File Offset: 0x0042E258
		// (set) Token: 0x060048A4 RID: 18596 RVA: 0x0043010C File Offset: 0x0042E30C
		public bool RadInfoGeneralWiFiBTMACAddress_42510_Applicable
		{
			get
			{
				short num = (short)1475346432;
				short num2 = num;
				num = (short)265848739;
				short num3 = num;
				num = (short)1851426723;
				switch (num3 == num)
				{
				}
				num = (short)1603600385;
				if (num != 0)
				{
				}
				num = (short)415694848;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiBTMACAddress_42510.Applicable;
			}
			set
			{
				short num = (short)982188032;
				short num2 = num;
				num = (short)1296662886;
				short num3 = num;
				num = (short)1665499494;
				switch (num3 == num)
				{
				}
				num = (short)1376059392;
				if (num != 0)
				{
				}
				num = (short)872087553;
				if (num != 0)
				{
				}
				this.radInfoGeneralWiFiBTMACAddress_42510.Applicable = value;
			}
		}

		// Token: 0x17002565 RID: 9573
		// (get) Token: 0x060048A5 RID: 18597 RVA: 0x004301C4 File Offset: 0x0042E3C4
		// (set) Token: 0x060048A6 RID: 18598 RVA: 0x00430278 File Offset: 0x0042E478
		public bool RadInfoGeneralWiFiBTMACAddress_42510_Valid
		{
			get
			{
				short num = (short)774111232;
				short num2 = num;
				num = (short)402653185;
				if (num != 0)
				{
				}
				num = (short)209054774;
				short num3 = num;
				num = (short)785574966;
				switch (num3 == num)
				{
				}
				num = (short)1079967744;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiBTMACAddress_42510.Valid;
			}
			set
			{
				short num = (short)893059072;
				short num2 = num;
				num = (short)1515983043;
				short num3 = num;
				num = (short)857870531;
				switch (num3 == num)
				{
				}
				num = (short)1918763009;
				if (num != 0)
				{
				}
				num = (short)875233280;
				if (num != 0)
				{
				}
				this.radInfoGeneralWiFiBTMACAddress_42510.Valid = value;
			}
		}

		// Token: 0x17002566 RID: 9574
		// (get) Token: 0x060048A7 RID: 18599 RVA: 0x0043032C File Offset: 0x0042E52C
		// (set) Token: 0x060048A8 RID: 18600 RVA: 0x004303E0 File Offset: 0x0042E5E0
		public bool RadInfoGeneralWiFiBTMACAddress_42510_Visible
		{
			get
			{
				short num = (short)1659633664;
				short num2 = num;
				num = (short)1083768833;
				if (num != 0)
				{
				}
				num = (short)1337599956;
				short num3 = num;
				num = (short)829695956;
				switch (num3 == num)
				{
				}
				num = (short)344195072;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiBTMACAddress_42510.Visible;
			}
			set
			{
				short num = (short)205783040;
				short num2 = num;
				num = (short)1034506999;
				short num3 = num;
				num = (short)605442807;
				switch (num3 == num)
				{
				}
				num = (short)1450901505;
				if (num != 0)
				{
				}
				num = (short)974454784;
				if (num != 0)
				{
				}
				this.radInfoGeneralWiFiBTMACAddress_42510.Visible = value;
			}
		}

		// Token: 0x17002567 RID: 9575
		// (get) Token: 0x060048A9 RID: 18601 RVA: 0x00430494 File Offset: 0x0042E694
		// (set) Token: 0x060048AA RID: 18602 RVA: 0x00430548 File Offset: 0x0042E748
		public bool RadInfoGeneralWiFiBTMACAddress_42510_Editable
		{
			get
			{
				short num = (short)578289664;
				short num2 = num;
				num = (short)1052682464;
				short num3 = num;
				num = (short)1842718944;
				switch (num3 == num)
				{
				}
				num = (short)536805376;
				if (num != 0)
				{
				}
				num = (short)1521745921;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiBTMACAddress_42510.Editable;
			}
			set
			{
				short num = (short)611188736;
				short num2 = num;
				num = (short)1997873452;
				short num3 = num;
				num = (short)945889580;
				switch (num3 == num)
				{
				}
				num = (short)1922367489;
				if (num != 0)
				{
				}
				num = (short)2048786432;
				if (num != 0)
				{
				}
				this.radInfoGeneralWiFiBTMACAddress_42510.Editable = value;
			}
		}

		// Token: 0x17002568 RID: 9576
		// (get) Token: 0x060048AB RID: 18603 RVA: 0x00430600 File Offset: 0x0042E800
		internal string RadInfoGeneralWiFiBTMACAddress_42510_UILabel
		{
			get
			{
				short num = (short)637337600;
				short num2 = num;
				num = (short)1462490717;
				short num3 = num;
				num = (short)517002845;
				switch (num3 == num)
				{
				}
				num = (short)739573761;
				if (num != 0)
				{
				}
				num = (short)959643648;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiBTMACAddress_42510.UIName;
			}
		}

		// Token: 0x17002569 RID: 9577
		// (get) Token: 0x060048AC RID: 18604 RVA: 0x004306B4 File Offset: 0x0042E8B4
		// (set) Token: 0x060048AD RID: 18605 RVA: 0x0043076C File Offset: 0x0042E96C
		internal bool RadInfoGeneralWiFiBTMACAddress_42510_HiddenStatic
		{
			get
			{
				short num = (short)941621248;
				short num2 = num;
				num = (short)981729281;
				if (num != 0)
				{
				}
				num = (short)2060146379;
				short num3 = num;
				num = (short)681596619;
				switch (num3 == num)
				{
				}
				num = (short)1920794624;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiBTMACAddress_42510.HiddenStatic;
			}
			set
			{
				short num = (short)745930752;
				short num2 = num;
				num = (short)283836417;
				if (num != 0)
				{
				}
				num = (short)2046248695;
				short num3 = num;
				num = (short)101598967;
				switch (num3 == num)
				{
				}
				num = (short)2047213568;
				if (num != 0)
				{
				}
				this.radInfoGeneralWiFiBTMACAddress_42510.HiddenStatic = value;
			}
		}

		// Token: 0x1700256A RID: 9578
		// (get) Token: 0x060048AE RID: 18606 RVA: 0x00430820 File Offset: 0x0042EA20
		// (set) Token: 0x060048AF RID: 18607 RVA: 0x004308D4 File Offset: 0x0042EAD4
		internal bool RadInfoGeneralWiFiBTMACAddress_42510_HiddenDynamic
		{
			get
			{
				short num = (short)2039939072;
				short num2 = num;
				num = (short)2011117014;
				short num3 = num;
				num = (short)832517590;
				switch (num3 == num)
				{
				}
				num = (short)742785024;
				if (num != 0)
				{
				}
				num = (short)1279393793;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiBTMACAddress_42510.HiddenDynamic;
			}
			set
			{
				short num = (short)461045760;
				short num2 = num;
				num = (short)1890543209;
				short num3 = num;
				num = (short)1232954985;
				switch (num3 == num)
				{
				}
				num = (short)1556021248;
				if (num != 0)
				{
				}
				num = (short)1333919745;
				if (num != 0)
				{
				}
				this.radInfoGeneralWiFiBTMACAddress_42510.HiddenDynamic = value;
			}
		}

		// Token: 0x1700256B RID: 9579
		// (get) Token: 0x060048B0 RID: 18608 RVA: 0x0043098C File Offset: 0x0042EB8C
		public bool RadInfoGeneralWiFiBTMACAddress_42510_HasDiffs
		{
			get
			{
				short num = (short)730988544;
				short num2 = num;
				num = (short)1984164825;
				short num3 = num;
				num = (short)2057237465;
				switch (num3 == num)
				{
				}
				num = (short)1130430465;
				if (num != 0)
				{
				}
				num = (short)135069696;
				if (num != 0)
				{
				}
				return this.radInfoGeneralWiFiBTMACAddress_42510._HasDiffs;
			}
		}

		// Token: 0x1700256C RID: 9580
		// (get) Token: 0x060048B1 RID: 18609 RVA: 0x00430A44 File Offset: 0x0042EC44
		// (set) Token: 0x060048B2 RID: 18610 RVA: 0x00430AF8 File Offset: 0x0042ECF8
		public bool RadInfoGeneralPrimaryFrequencyBand700_A42543Value
		{
			get
			{
				short num = (short)87687168;
				short num2 = num;
				num = (short)1451803919;
				short num3 = num;
				num = (short)976274703;
				switch (num3 == num)
				{
				}
				num = (short)1704525825;
				if (num != 0)
				{
				}
				num = (short)1893662720;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBand700_A42543.Value;
			}
			set
			{
				short num = (short)958988288;
				short num2 = num;
				num = (short)1557530843;
				short num3 = num;
				num = (short)294914267;
				switch (num3 == num)
				{
				}
				num = (short)6750208;
				if (num != 0)
				{
				}
				num = (short)8978433;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBand700_A42543.Value = value;
			}
		}

		// Token: 0x1700256D RID: 9581
		// (get) Token: 0x060048B3 RID: 18611 RVA: 0x00430BAC File Offset: 0x0042EDAC
		public global::AcpBusinessLayer.AcpField<bool> RadInfoGeneralPrimaryFrequencyBand700_A42543
		{
			get
			{
				short num = (short)1703673856;
				short num2 = num;
				num = (short)744234318;
				short num3 = num;
				num = (short)478027086;
				switch (num3 == num)
				{
				}
				num = (short)421920769;
				if (num != 0)
				{
				}
				num = (short)1886912512;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBand700_A42543;
			}
		}

		// Token: 0x1700256E RID: 9582
		// (get) Token: 0x060048B4 RID: 18612 RVA: 0x00430C5C File Offset: 0x0042EE5C
		// (set) Token: 0x060048B5 RID: 18613 RVA: 0x00430D10 File Offset: 0x0042EF10
		public bool RadInfoGeneralPrimaryFrequencyBand700_A42543_UIValue
		{
			get
			{
				short num = (short)302710784;
				short num2 = num;
				num = (short)1764340856;
				short num3 = num;
				num = (short)346731640;
				switch (num3 == num)
				{
				}
				num = (short)1333526528;
				if (num != 0)
				{
				}
				num = (short)1105723393;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBand700_A42543.Value;
			}
			set
			{
				short num = (short)1971257344;
				short num2 = num;
				num = (short)547100246;
				short num3 = num;
				num = (short)505222742;
				switch (num3 == num)
				{
				}
				num = (short)22740993;
				if (num != 0)
				{
				}
				num = (short)1432027136;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBand700_A42543.Value = value;
			}
		}

		// Token: 0x1700256F RID: 9583
		// (get) Token: 0x060048B6 RID: 18614 RVA: 0x00430DC4 File Offset: 0x0042EFC4
		// (set) Token: 0x060048B7 RID: 18615 RVA: 0x00430E78 File Offset: 0x0042F078
		public bool RadInfoGeneralPrimaryFrequencyBand700_A42543_Applicable
		{
			get
			{
				short num = (short)340393984;
				short num2 = num;
				num = (short)1885346483;
				short num3 = num;
				num = (short)1482824371;
				switch (num3 == num)
				{
				}
				num = (short)1799553025;
				if (num != 0)
				{
				}
				num = (short)1224409088;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBand700_A42543.Applicable;
			}
			set
			{
				short num = (short)1110048768;
				short num2 = num;
				num = (short)2135799979;
				short num3 = num;
				num = (short)2008987819;
				switch (num3 == num)
				{
				}
				num = (short)1133576193;
				if (num != 0)
				{
				}
				num = (short)750780416;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBand700_A42543.Applicable = value;
			}
		}

		// Token: 0x17002570 RID: 9584
		// (get) Token: 0x060048B8 RID: 18616 RVA: 0x00430F2C File Offset: 0x0042F12C
		// (set) Token: 0x060048B9 RID: 18617 RVA: 0x00430FE0 File Offset: 0x0042F1E0
		public bool RadInfoGeneralPrimaryFrequencyBand700_A42543_Valid
		{
			get
			{
				short num = (short)1436286976;
				short num2 = num;
				num = (short)935893390;
				short num3 = num;
				num = (short)1706531214;
				switch (num3 == num)
				{
				}
				num = (short)62980097;
				if (num != 0)
				{
				}
				num = (short)591527936;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBand700_A42543.Valid;
			}
			set
			{
				short num = (short)634650624;
				short num2 = num;
				num = (short)1801492688;
				short num3 = num;
				num = (short)1639094480;
				switch (num3 == num)
				{
				}
				num = (short)179896321;
				if (num != 0)
				{
				}
				num = (short)2039873536;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBand700_A42543.Valid = value;
			}
		}

		// Token: 0x17002571 RID: 9585
		// (get) Token: 0x060048BA RID: 18618 RVA: 0x00431094 File Offset: 0x0042F294
		// (set) Token: 0x060048BB RID: 18619 RVA: 0x00431148 File Offset: 0x0042F348
		public bool RadInfoGeneralPrimaryFrequencyBand700_A42543_Visible
		{
			get
			{
				short num = (short)1146224640;
				short num2 = num;
				num = (short)328557826;
				short num3 = num;
				num = (short)909731074;
				switch (num3 == num)
				{
				}
				num = (short)1015676929;
				if (num != 0)
				{
				}
				num = (short)185466880;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBand700_A42543.Visible;
			}
			set
			{
				short num = (short)894369792;
				short num2 = num;
				num = (short)2119790783;
				short num3 = num;
				num = (short)2029285567;
				switch (num3 == num)
				{
				}
				num = (short)1483276289;
				if (num != 0)
				{
				}
				num = (short)2005663744;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBand700_A42543.Visible = value;
			}
		}

		// Token: 0x17002572 RID: 9586
		// (get) Token: 0x060048BC RID: 18620 RVA: 0x004311FC File Offset: 0x0042F3FC
		// (set) Token: 0x060048BD RID: 18621 RVA: 0x004312B0 File Offset: 0x0042F4B0
		public bool RadInfoGeneralPrimaryFrequencyBand700_A42543_Editable
		{
			get
			{
				short num = (short)1185153024;
				short num2 = num;
				num = (short)1315108508;
				short num3 = num;
				num = (short)1302001308;
				switch (num3 == num)
				{
				}
				num = (short)1848049665;
				if (num != 0)
				{
				}
				num = (short)1794965504;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBand700_A42543.Editable;
			}
			set
			{
				short num = (short)265879552;
				short num2 = num;
				num = (short)1096751753;
				short num3 = num;
				num = (short)1847007881;
				switch (num3 == num)
				{
				}
				num = (short)112066561;
				if (num != 0)
				{
				}
				num = (short)1868300288;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBand700_A42543.Editable = value;
			}
		}

		// Token: 0x17002573 RID: 9587
		// (get) Token: 0x060048BE RID: 18622 RVA: 0x0043136C File Offset: 0x0042F56C
		internal string RadInfoGeneralPrimaryFrequencyBand700_A42543_UILabel
		{
			get
			{
				short num = (short)2009858048;
				short num2 = num;
				num = (short)1594737497;
				short num3 = num;
				num = (short)981123929;
				switch (num3 == num)
				{
				}
				num = (short)1146683392;
				if (num != 0)
				{
				}
				num = (short)1662976001;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBand700_A42543.UIName;
			}
		}

		// Token: 0x17002574 RID: 9588
		// (get) Token: 0x060048BF RID: 18623 RVA: 0x00431424 File Offset: 0x0042F624
		// (set) Token: 0x060048C0 RID: 18624 RVA: 0x004314D8 File Offset: 0x0042F6D8
		internal bool RadInfoGeneralPrimaryFrequencyBand700_A42543_HiddenStatic
		{
			get
			{
				short num = (short)276758528;
				short num2 = num;
				num = (short)1739459669;
				short num3 = num;
				num = (short)2115963989;
				switch (num3 == num)
				{
				}
				num = (short)996737024;
				if (num != 0)
				{
				}
				num = (short)30867457;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBand700_A42543.HiddenStatic;
			}
			set
			{
				short num = (short)838795264;
				short num2 = num;
				num = (short)232508788;
				short num3 = num;
				num = (short)255642996;
				switch (num3 == num)
				{
				}
				num = (short)1218314241;
				if (num != 0)
				{
				}
				num = (short)1731264512;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBand700_A42543.HiddenStatic = value;
			}
		}

		// Token: 0x17002575 RID: 9589
		// (get) Token: 0x060048C1 RID: 18625 RVA: 0x00431590 File Offset: 0x0042F790
		// (set) Token: 0x060048C2 RID: 18626 RVA: 0x00431648 File Offset: 0x0042F848
		internal bool RadInfoGeneralPrimaryFrequencyBand700_A42543_HiddenDynamic
		{
			get
			{
				short num = (short)6160384;
				short num2 = num;
				num = (short)1173880833;
				if (num != 0)
				{
				}
				num = (short)1549427378;
				short num3 = num;
				num = (short)1398629042;
				switch (num3 == num)
				{
				}
				num = (short)1438187520;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBand700_A42543.HiddenDynamic;
			}
			set
			{
				short num = (short)1990328320;
				short num2 = num;
				num = (short)1947352399;
				short num3 = num;
				num = (short)145964367;
				switch (num3 == num)
				{
				}
				num = (short)511377408;
				if (num != 0)
				{
				}
				num = (short)1306787841;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBand700_A42543.HiddenDynamic = value;
			}
		}

		// Token: 0x17002576 RID: 9590
		// (get) Token: 0x060048C3 RID: 18627 RVA: 0x004316FC File Offset: 0x0042F8FC
		public bool RadInfoGeneralPrimaryFrequencyBand700_A42543_HasDiffs
		{
			get
			{
				short num = (short)1979514880;
				short num2 = num;
				num = (short)537733815;
				short num3 = num;
				num = (short)229321399;
				switch (num3 == num)
				{
				}
				num = (short)938803201;
				if (num != 0)
				{
				}
				num = (short)1868234752;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBand700_A42543._HasDiffs;
			}
		}

		// Token: 0x17002577 RID: 9591
		// (get) Token: 0x060048C4 RID: 18628 RVA: 0x004317B0 File Offset: 0x0042F9B0
		// (set) Token: 0x060048C5 RID: 18629 RVA: 0x00431868 File Offset: 0x0042FA68
		public bool RadInfoGeneralPrimaryFrequencyBand800_A42544Value
		{
			get
			{
				short num = (short)1783234560;
				short num2 = num;
				num = (short)1960904096;
				short num3 = num;
				num = (short)1190200736;
				switch (num3 == num)
				{
				}
				num = (short)1979318273;
				if (num != 0)
				{
				}
				num = (short)1955266560;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBand800_A42544.Value;
			}
			set
			{
				short num = (short)1161166848;
				short num2 = num;
				num = (short)1653531010;
				short num3 = num;
				num = (short)216260994;
				switch (num3 == num)
				{
				}
				num = (short)1812398081;
				if (num != 0)
				{
				}
				num = (short)1851719680;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBand800_A42544.Value = value;
			}
		}

		// Token: 0x17002578 RID: 9592
		// (get) Token: 0x060048C6 RID: 18630 RVA: 0x0043191C File Offset: 0x0042FB1C
		public global::AcpBusinessLayer.AcpField<bool> RadInfoGeneralPrimaryFrequencyBand800_A42544
		{
			get
			{
				short num = (short)1935474688;
				short num2 = num;
				num = (short)1843366563;
				short num3 = num;
				num = (short)1493994147;
				switch (num3 == num)
				{
				}
				num = (short)1000931328;
				if (num != 0)
				{
				}
				num = (short)1599078401;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBand800_A42544;
			}
		}

		// Token: 0x17002579 RID: 9593
		// (get) Token: 0x060048C7 RID: 18631 RVA: 0x004319CC File Offset: 0x0042FBCC
		// (set) Token: 0x060048C8 RID: 18632 RVA: 0x00431A84 File Offset: 0x0042FC84
		public bool RadInfoGeneralPrimaryFrequencyBand800_A42544_UIValue
		{
			get
			{
				short num = (short)1300758528;
				short num2 = num;
				num = (short)1078046124;
				short num3 = num;
				num = (short)415083948;
				switch (num3 == num)
				{
				}
				num = (short)1706622976;
				if (num != 0)
				{
				}
				num = (short)194641921;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBand800_A42544.Value;
			}
			set
			{
				short num = (short)1851981824;
				short num2 = num;
				num = (short)519560474;
				short num3 = num;
				num = (short)1826479386;
				switch (num3 == num)
				{
				}
				num = (short)1197998081;
				if (num != 0)
				{
				}
				num = (short)1684537344;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBand800_A42544.Value = value;
			}
		}

		// Token: 0x1700257A RID: 9594
		// (get) Token: 0x060048C9 RID: 18633 RVA: 0x00431B3C File Offset: 0x0042FD3C
		// (set) Token: 0x060048CA RID: 18634 RVA: 0x00431BF0 File Offset: 0x0042FDF0
		public bool RadInfoGeneralPrimaryFrequencyBand800_A42544_Applicable
		{
			get
			{
				short num = (short)276234240;
				short num2 = num;
				num = (short)175636481;
				if (num != 0)
				{
				}
				num = (short)1755890909;
				short num3 = num;
				num = (short)1011270877;
				switch (num3 == num)
				{
				}
				num = (short)452067328;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBand800_A42544.Applicable;
			}
			set
			{
				short num = (short)1450901504;
				short num2 = num;
				num = (short)1298036772;
				short num3 = num;
				num = (short)2084337700;
				switch (num3 == num)
				{
				}
				num = (short)1800404993;
				if (num != 0)
				{
				}
				num = (short)1230831616;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBand800_A42544.Applicable = value;
			}
		}

		// Token: 0x1700257B RID: 9595
		// (get) Token: 0x060048CB RID: 18635 RVA: 0x00431CA4 File Offset: 0x0042FEA4
		// (set) Token: 0x060048CC RID: 18636 RVA: 0x00431D5C File Offset: 0x0042FF5C
		public bool RadInfoGeneralPrimaryFrequencyBand800_A42544_Valid
		{
			get
			{
				short num = (short)1059202211;
				short num2 = num;
				num = (short)667296931;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1816592384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1878130689;
				if (num != 0)
				{
				}
				num = (short)1362165760;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBand800_A42544.Valid;
			}
			set
			{
				short num = (short)2111171646;
				short num2 = num;
				num = (short)529853502;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1836187648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)676593664;
				if (num != 0)
				{
				}
				num = (short)1822228481;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBand800_A42544.Valid = value;
			}
		}

		// Token: 0x1700257C RID: 9596
		// (get) Token: 0x060048CD RID: 18637 RVA: 0x00431E10 File Offset: 0x00430010
		// (set) Token: 0x060048CE RID: 18638 RVA: 0x00431EC8 File Offset: 0x004300C8
		public bool RadInfoGeneralPrimaryFrequencyBand800_A42544_Visible
		{
			get
			{
				short num = (short)67587223;
				short num2 = num;
				num = (short)582962327;
				switch (num2 == num)
				{
				default:
				{
					num = (short)233635840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1491664897;
				if (num != 0)
				{
				}
				num = (short)505020416;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBand800_A42544.Visible;
			}
			set
			{
				short num = (short)117664009;
				short num2 = num;
				num = (short)507472137;
				switch (num2 == num)
				{
				default:
				{
					num = (short)679804928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)460259329;
				if (num != 0)
				{
				}
				num = (short)1011417088;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBand800_A42544.Visible = value;
			}
		}

		// Token: 0x1700257D RID: 9597
		// (get) Token: 0x060048CF RID: 18639 RVA: 0x00431F80 File Offset: 0x00430180
		// (set) Token: 0x060048D0 RID: 18640 RVA: 0x00432038 File Offset: 0x00430238
		public bool RadInfoGeneralPrimaryFrequencyBand800_A42544_Editable
		{
			get
			{
				short num = (short)1686331310;
				short num2 = num;
				num = (short)1525178286;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1750138880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)171442176;
				if (num != 0)
				{
				}
				num = (short)316866561;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBand800_A42544.Editable;
			}
			set
			{
				short num = (short)413087905;
				short num2 = num;
				num = (short)194066593;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1632567296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1412890624;
				if (num != 0)
				{
				}
				num = (short)1191641089;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBand800_A42544.Editable = value;
			}
		}

		// Token: 0x1700257E RID: 9598
		// (get) Token: 0x060048D1 RID: 18641 RVA: 0x004320F0 File Offset: 0x004302F0
		internal string RadInfoGeneralPrimaryFrequencyBand800_A42544_UILabel
		{
			get
			{
				short num = (short)855264909;
				short num2 = num;
				num = (short)1844399757;
				switch (num2 == num)
				{
				default:
				{
					num = (short)118292480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)827392001;
				if (num != 0)
				{
				}
				num = (short)1888354304;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBand800_A42544.UIName;
			}
		}

		// Token: 0x1700257F RID: 9599
		// (get) Token: 0x060048D2 RID: 18642 RVA: 0x004321A8 File Offset: 0x004303A8
		// (set) Token: 0x060048D3 RID: 18643 RVA: 0x0043225C File Offset: 0x0043045C
		internal bool RadInfoGeneralPrimaryFrequencyBand800_A42544_HiddenStatic
		{
			get
			{
				short num = (short)366615360;
				short num2 = num;
				num = (short)420223808;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1549729792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1476984832;
				if (num != 0)
				{
				}
				num = (short)1865089025;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBand800_A42544.HiddenStatic;
			}
			set
			{
				short num = (short)587268097;
				if (num != 0)
				{
				}
				num = (short)378994688;
				short num2 = num;
				num = (short)1452712383;
				short num3 = num;
				num = (short)1593745855;
				switch (num3 == num)
				{
				}
				num = (short)505741312;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBand800_A42544.HiddenStatic = value;
			}
		}

		// Token: 0x17002580 RID: 9600
		// (get) Token: 0x060048D4 RID: 18644 RVA: 0x00432314 File Offset: 0x00430514
		// (set) Token: 0x060048D5 RID: 18645 RVA: 0x004323CC File Offset: 0x004305CC
		internal bool RadInfoGeneralPrimaryFrequencyBand800_A42544_HiddenDynamic
		{
			get
			{
				short num = (short)1191759856;
				short num2 = num;
				num = (short)1399771120;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1307443200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1320091649;
				if (num != 0)
				{
				}
				num = (short)2083520512;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBand800_A42544.HiddenDynamic;
			}
			set
			{
				short num = (short)816381953;
				if (num != 0)
				{
				}
				num = (short)1304297472;
				short num2 = num;
				num = (short)2090720233;
				short num3 = num;
				num = (short)326884329;
				switch (num3 == num)
				{
				}
				num = (short)475856896;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBand800_A42544.HiddenDynamic = value;
			}
		}

		// Token: 0x17002581 RID: 9601
		// (get) Token: 0x060048D6 RID: 18646 RVA: 0x00432484 File Offset: 0x00430684
		public bool RadInfoGeneralPrimaryFrequencyBand800_A42544_HasDiffs
		{
			get
			{
				short num = (short)1565589505;
				if (num != 0)
				{
				}
				num = (short)1564475392;
				short num2 = num;
				num = (short)886299069;
				short num3 = num;
				num = (short)736614845;
				switch (num3 == num)
				{
				}
				num = (short)1602879488;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBand800_A42544._HasDiffs;
			}
		}

		// Token: 0x17002582 RID: 9602
		// (get) Token: 0x060048D7 RID: 18647 RVA: 0x00432538 File Offset: 0x00430738
		// (set) Token: 0x060048D8 RID: 18648 RVA: 0x004325EC File Offset: 0x004307EC
		public bool RadInfoGeneralPrimaryFrequencyBandVHF_A42545Value
		{
			get
			{
				short num = (short)1758898936;
				short num2 = num;
				num = (short)2089069304;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1260912640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)248381441;
				if (num != 0)
				{
				}
				num = (short)1533149184;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBandVHF_A42545.Value;
			}
			set
			{
				short num = (short)227744424;
				short num2 = num;
				num = (short)442374824;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1314914304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1855324161;
				if (num != 0)
				{
				}
				num = (short)1132593152;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBandVHF_A42545.Value = value;
			}
		}

		// Token: 0x17002583 RID: 9603
		// (get) Token: 0x060048D9 RID: 18649 RVA: 0x004326A0 File Offset: 0x004308A0
		public global::AcpBusinessLayer.AcpField<bool> RadInfoGeneralPrimaryFrequencyBandVHF_A42545
		{
			get
			{
				short num = (short)782347419;
				short num2 = num;
				num = (short)2048109723;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1934622720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1331953664;
				if (num != 0)
				{
				}
				num = (short)1368129537;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBandVHF_A42545;
			}
		}

		// Token: 0x17002584 RID: 9604
		// (get) Token: 0x060048DA RID: 18650 RVA: 0x0043274C File Offset: 0x0043094C
		// (set) Token: 0x060048DB RID: 18651 RVA: 0x00432800 File Offset: 0x00430A00
		public bool RadInfoGeneralPrimaryFrequencyBandVHF_A42545_UIValue
		{
			get
			{
				short num = (short)1949625877;
				short num2 = num;
				num = (short)933490197;
				switch (num2 == num)
				{
				default:
				{
					num = (short)26542080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)63504385;
				if (num != 0)
				{
				}
				num = (short)115343360;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBandVHF_A42545.Value;
			}
			set
			{
				short num = (short)1304357014;
				short num2 = num;
				num = (short)1472981142;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1032519680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1824129025;
				if (num != 0)
				{
				}
				num = (short)852295680;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBandVHF_A42545.Value = value;
			}
		}

		// Token: 0x17002585 RID: 9605
		// (get) Token: 0x060048DC RID: 18652 RVA: 0x004328B8 File Offset: 0x00430AB8
		// (set) Token: 0x060048DD RID: 18653 RVA: 0x0043296C File Offset: 0x00430B6C
		public bool RadInfoGeneralPrimaryFrequencyBandVHF_A42545_Applicable
		{
			get
			{
				short num = (short)69109555;
				short num2 = num;
				num = (short)1349420851;
				switch (num2 == num)
				{
				default:
				{
					num = (short)431030272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1229520897;
				if (num != 0)
				{
				}
				num = (short)879230976;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBandVHF_A42545.Applicable;
			}
			set
			{
				short num = (short)504471556;
				short num2 = num;
				num = (short)63152132;
				switch (num2 == num)
				{
				default:
				{
					num = (short)110755840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1306787841;
				if (num != 0)
				{
				}
				num = (short)1539375104;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBandVHF_A42545.Applicable = value;
			}
		}

		// Token: 0x17002586 RID: 9606
		// (get) Token: 0x060048DE RID: 18654 RVA: 0x00432A20 File Offset: 0x00430C20
		// (set) Token: 0x060048DF RID: 18655 RVA: 0x00432AD4 File Offset: 0x00430CD4
		public bool RadInfoGeneralPrimaryFrequencyBandVHF_A42545_Valid
		{
			get
			{
				short num = (short)4993335;
				short num2 = num;
				num = (short)1272787255;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1630535680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1892417537;
				if (num != 0)
				{
				}
				num = (short)512098304;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBandVHF_A42545.Valid;
			}
			set
			{
				short num = (short)1258749953;
				if (num != 0)
				{
				}
				num = (short)422510592;
				short num2 = num;
				num = (short)319371373;
				short num3 = num;
				num = (short)187512941;
				switch (num3 == num)
				{
				}
				num = (short)1607729152;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBandVHF_A42545.Valid = value;
			}
		}

		// Token: 0x17002587 RID: 9607
		// (get) Token: 0x060048E0 RID: 18656 RVA: 0x00432B88 File Offset: 0x00430D88
		// (set) Token: 0x060048E1 RID: 18657 RVA: 0x00432C3C File Offset: 0x00430E3C
		public bool RadInfoGeneralPrimaryFrequencyBandVHF_A42545_Visible
		{
			get
			{
				short num = (short)1513291777;
				if (num != 0)
				{
				}
				num = (short)530251776;
				short num2 = num;
				num = (short)2027808134;
				short num3 = num;
				num = (short)1561847174;
				switch (num3 == num)
				{
				}
				num = (short)802881536;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBandVHF_A42545.Visible;
			}
			set
			{
				short num = (short)933827799;
				short num2 = num;
				num = (short)655168727;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1562771456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)400031745;
				if (num != 0)
				{
				}
				num = (short)149291008;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBandVHF_A42545.Visible = value;
			}
		}

		// Token: 0x17002588 RID: 9608
		// (get) Token: 0x060048E2 RID: 18658 RVA: 0x00432CF4 File Offset: 0x00430EF4
		// (set) Token: 0x060048E3 RID: 18659 RVA: 0x00432DA8 File Offset: 0x00430FA8
		public bool RadInfoGeneralPrimaryFrequencyBandVHF_A42545_Editable
		{
			get
			{
				short num = (short)1295122433;
				if (num != 0)
				{
				}
				num = (short)2064777216;
				short num2 = num;
				num = (short)1259997416;
				short num3 = num;
				num = (short)1856178408;
				switch (num3 == num)
				{
				}
				num = (short)1496317952;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBandVHF_A42545.Editable;
			}
			set
			{
				short num = (short)828961817;
				short num2 = num;
				num = (short)250016793;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1738670080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)195952640;
				if (num != 0)
				{
				}
				num = (short)1998323713;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBandVHF_A42545.Editable = value;
			}
		}

		// Token: 0x17002589 RID: 9609
		// (get) Token: 0x060048E4 RID: 18660 RVA: 0x00432E5C File Offset: 0x0043105C
		internal string RadInfoGeneralPrimaryFrequencyBandVHF_A42545_UILabel
		{
			get
			{
				short num = (short)1851656616;
				short num2 = num;
				num = (short)1297090984;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1207566336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)630521857;
				if (num != 0)
				{
				}
				num = (short)198705152;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBandVHF_A42545.UIName;
			}
		}

		// Token: 0x1700258A RID: 9610
		// (get) Token: 0x060048E5 RID: 18661 RVA: 0x00432F14 File Offset: 0x00431114
		// (set) Token: 0x060048E6 RID: 18662 RVA: 0x00432FC8 File Offset: 0x004311C8
		internal bool RadInfoGeneralPrimaryFrequencyBandVHF_A42545_HiddenStatic
		{
			get
			{
				short num = (short)620366623;
				short num2 = num;
				num = (short)188812063;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1060503552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)566362113;
				if (num != 0)
				{
				}
				num = (short)1970470912;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBandVHF_A42545.HiddenStatic;
			}
			set
			{
				short num = (short)366698696;
				short num2 = num;
				num = (short)41836744;
				switch (num2 == num)
				{
				default:
				{
					num = (short)156237824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1682571265;
				if (num != 0)
				{
				}
				num = (short)201588736;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBandVHF_A42545.HiddenStatic = value;
			}
		}

		// Token: 0x1700258B RID: 9611
		// (get) Token: 0x060048E7 RID: 18663 RVA: 0x0043307C File Offset: 0x0043127C
		// (set) Token: 0x060048E8 RID: 18664 RVA: 0x00433130 File Offset: 0x00431330
		internal bool RadInfoGeneralPrimaryFrequencyBandVHF_A42545_HiddenDynamic
		{
			get
			{
				short num = (short)1442386518;
				short num2 = num;
				num = (short)1207439958;
				switch (num2 == num)
				{
				default:
				{
					num = (short)88276992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1396310016;
				if (num != 0)
				{
				}
				num = (short)1923612673;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBandVHF_A42545.HiddenDynamic;
			}
			set
			{
				short num = (short)1399929451;
				short num2 = num;
				num = (short)1537948267;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2060779520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1697710081;
				if (num != 0)
				{
				}
				num = (short)635830272;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBandVHF_A42545.HiddenDynamic = value;
			}
		}

		// Token: 0x1700258C RID: 9612
		// (get) Token: 0x060048E9 RID: 18665 RVA: 0x004331E8 File Offset: 0x004313E8
		public bool RadInfoGeneralPrimaryFrequencyBandVHF_A42545_HasDiffs
		{
			get
			{
				short num = (short)157178671;
				short num2 = num;
				num = (short)1131961135;
				switch (num2 == num)
				{
				default:
				{
					num = (short)803995648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1335623680;
				if (num != 0)
				{
				}
				num = (short)2088566785;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBandVHF_A42545._HasDiffs;
			}
		}

		// Token: 0x1700258D RID: 9613
		// (get) Token: 0x060048EA RID: 18666 RVA: 0x0043329C File Offset: 0x0043149C
		// (set) Token: 0x060048EB RID: 18667 RVA: 0x00433354 File Offset: 0x00431554
		public bool RadInfoGeneralPrimaryFrequencyBandUHF1_A42546Value
		{
			get
			{
				short num = (short)1238302721;
				if (num != 0)
				{
				}
				num = (short)1805975552;
				short num2 = num;
				num = (short)2144682035;
				short num3 = num;
				num = (short)1437024307;
				switch (num3 == num)
				{
				}
				num = (short)149815296;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546.Value;
			}
			set
			{
				short num = (short)283701147;
				short num2 = num;
				num = (short)172879771;
				switch (num2 == num)
				{
				default:
				{
					num = (short)294715392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1934622721;
				if (num != 0)
				{
				}
				num = (short)2122579968;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546.Value = value;
			}
		}

		// Token: 0x1700258E RID: 9614
		// (get) Token: 0x060048EC RID: 18668 RVA: 0x00433408 File Offset: 0x00431608
		public global::AcpBusinessLayer.AcpField<bool> RadInfoGeneralPrimaryFrequencyBandUHF1_A42546
		{
			get
			{
				short num = (short)711761458;
				short num2 = num;
				num = (short)533306930;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1501429760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1804926977;
				if (num != 0)
				{
				}
				num = (short)1927413760;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546;
			}
		}

		// Token: 0x1700258F RID: 9615
		// (get) Token: 0x060048ED RID: 18669 RVA: 0x004334B4 File Offset: 0x004316B4
		// (set) Token: 0x060048EE RID: 18670 RVA: 0x00433568 File Offset: 0x00431768
		public bool RadInfoGeneralPrimaryFrequencyBandUHF1_A42546_UIValue
		{
			get
			{
				short num = (short)1087829520;
				short num2 = num;
				num = (short)1255732752;
				switch (num2 == num)
				{
				default:
				{
					num = (short)788070400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1112604673;
				if (num != 0)
				{
				}
				num = (short)623575040;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546.Value;
			}
			set
			{
				short num = (short)181455981;
				short num2 = num;
				num = (short)1497549933;
				switch (num2 == num)
				{
				default:
				{
					num = (short)791019520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1481900033;
				if (num != 0)
				{
				}
				num = (short)2097676288;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546.Value = value;
			}
		}

		// Token: 0x17002590 RID: 9616
		// (get) Token: 0x060048EF RID: 18671 RVA: 0x00433620 File Offset: 0x00431820
		// (set) Token: 0x060048F0 RID: 18672 RVA: 0x004336D8 File Offset: 0x004318D8
		public bool RadInfoGeneralPrimaryFrequencyBandUHF1_A42546_Applicable
		{
			get
			{
				short num = (short)1541557494;
				short num2 = num;
				num = (short)43273462;
				switch (num2 == num)
				{
				default:
				{
					num = (short)889454592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)87293952;
				if (num != 0)
				{
				}
				num = (short)687669249;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546.Applicable;
			}
			set
			{
				short num = (short)11141121;
				if (num != 0)
				{
				}
				num = (short)183238656;
				short num2 = num;
				num = (short)1031548870;
				short num3 = num;
				num = (short)1629106118;
				switch (num3 == num)
				{
				}
				num = (short)647561216;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546.Applicable = value;
			}
		}

		// Token: 0x17002591 RID: 9617
		// (get) Token: 0x060048F1 RID: 18673 RVA: 0x00433790 File Offset: 0x00431990
		// (set) Token: 0x060048F2 RID: 18674 RVA: 0x00433844 File Offset: 0x00431A44
		public bool RadInfoGeneralPrimaryFrequencyBandUHF1_A42546_Valid
		{
			get
			{
				short num = (short)963773780;
				short num2 = num;
				num = (short)133760340;
				switch (num2 == num)
				{
				default:
				{
					num = (short)565313536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1019215873;
				if (num != 0)
				{
				}
				num = (short)1879703552;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546.Valid;
			}
			set
			{
				short num = (short)1048262686;
				short num2 = num;
				num = (short)252131358;
				switch (num2 == num)
				{
				default:
				{
					num = (short)212598784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1813446657;
				if (num != 0)
				{
				}
				num = (short)1176305664;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546.Valid = value;
			}
		}

		// Token: 0x17002592 RID: 9618
		// (get) Token: 0x060048F3 RID: 18675 RVA: 0x004338FC File Offset: 0x00431AFC
		// (set) Token: 0x060048F4 RID: 18676 RVA: 0x004339B0 File Offset: 0x00431BB0
		public bool RadInfoGeneralPrimaryFrequencyBandUHF1_A42546_Visible
		{
			get
			{
				short num = (short)1816854529;
				if (num != 0)
				{
				}
				num = (short)505151488;
				short num2 = num;
				num = (short)1600104462;
				short num3 = num;
				num = (short)1078700046;
				switch (num3 == num)
				{
				}
				num = (short)1271201792;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546.Visible;
			}
			set
			{
				short num = (short)363396937;
				short num2 = num;
				num = (short)447938377;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2118189056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)804585473;
				if (num != 0)
				{
				}
				num = (short)2074804224;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546.Visible = value;
			}
		}

		// Token: 0x17002593 RID: 9619
		// (get) Token: 0x060048F5 RID: 18677 RVA: 0x00433A68 File Offset: 0x00431C68
		// (set) Token: 0x060048F6 RID: 18678 RVA: 0x00433B1C File Offset: 0x00431D1C
		public bool RadInfoGeneralPrimaryFrequencyBandUHF1_A42546_Editable
		{
			get
			{
				short num = (short)1396580762;
				short num2 = num;
				num = (short)829759898;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1438908416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1016659969;
				if (num != 0)
				{
				}
				num = (short)1452408832;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546.Editable;
			}
			set
			{
				short num = (short)1882209380;
				short num2 = num;
				num = (short)1007565924;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1143865344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1050804225;
				if (num != 0)
				{
				}
				num = (short)937820160;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546.Editable = value;
			}
		}

		// Token: 0x17002594 RID: 9620
		// (get) Token: 0x060048F7 RID: 18679 RVA: 0x00433BD4 File Offset: 0x00431DD4
		internal string RadInfoGeneralPrimaryFrequencyBandUHF1_A42546_UILabel
		{
			get
			{
				short num = (short)2081488897;
				if (num != 0)
				{
				}
				num = (short)94240768;
				short num2 = num;
				num = (short)1777267083;
				short num3 = num;
				num = (short)1072296331;
				switch (num3 == num)
				{
				}
				num = (short)2102001664;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546.UIName;
			}
		}

		// Token: 0x17002595 RID: 9621
		// (get) Token: 0x060048F8 RID: 18680 RVA: 0x00433C88 File Offset: 0x00431E88
		// (set) Token: 0x060048F9 RID: 18681 RVA: 0x00433D3C File Offset: 0x00431F3C
		internal bool RadInfoGeneralPrimaryFrequencyBandUHF1_A42546_HiddenStatic
		{
			get
			{
				short num = (short)2101184757;
				short num2 = num;
				num = (short)730302709;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2002124800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1051852800;
				if (num != 0)
				{
				}
				num = (short)1092354049;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546.HiddenStatic;
			}
			set
			{
				short num = (short)838636119;
				short num2 = num;
				num = (short)1393726039;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1842610176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)18939905;
				if (num != 0)
				{
				}
				num = (short)710606848;
				if (num != 0)
				{
				}
				this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546.HiddenStatic = value;
			}
		}

		// Token: 0x17002596 RID: 9622
		// (get) Token: 0x060048FA RID: 18682 RVA: 0x00433DF0 File Offset: 0x00431FF0
		// (set) Token: 0x060048FB RID: 18683 RVA: 0x00433EA8 File Offset: 0x004320A8
		internal bool RadInfoGeneralPrimaryFrequencyBandUHF1_A42546_HiddenDynamic
		{
			get
			{
				short num = (short)1332023310;
				short num2 = num;
				num = (short)1463619598;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1425408000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2003238913;
				if (num != 0)
				{
				}
				num = (short)1961164800;
				if (num != 0)
				{
				}
				return this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546.HiddenDynamic;
			}
			set
			{
				short num = (short)272521477;
				short num2 = num;
				num = (short)1642813701;
				switch (num2 == num)
				{
				}
				num = (short)186056705;
				if (num != 0)
				{
				}
				num = (short)740163584;
				if (num != 0)
				{
				}
				num = (short)1128660992;
				short num3 = num;
				this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546.HiddenDynamic = value;
			}
		}

		// Token: 0x17002597 RID: 9623
		// (get) Token: 0x060048FC RID: 18684 RVA: 0x00433F5C File Offset: 0x0043215C
		public bool RadInfoGeneralPrimaryFrequencyBandUHF1_A42546_HasDiffs
		{
			get
			{
				short num = (short)1809314669;
				short num2 = num;
				num = (short)502199149;
				switch (num2 == num)
				{
				}
				num = (short)1925447681;
				if (num != 0)
				{
				}
				num = (short)266600448;
				if (num != 0)
				{
				}
				num = (short)1533870080;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBandUHF1_A42546._HasDiffs;
			}
		}

		// Token: 0x17002598 RID: 9624
		// (get) Token: 0x060048FD RID: 18685 RVA: 0x00434010 File Offset: 0x00432210
		// (set) Token: 0x060048FE RID: 18686 RVA: 0x004340C4 File Offset: 0x004322C4
		public bool RadInfoGeneralPrimaryFrequencyBandUHF2_A42547Value
		{
			get
			{
				short num = (short)325362189;
				short num2 = num;
				num = (short)1323475469;
				switch (num2 == num)
				{
				}
				num = (short)1002110977;
				if (num != 0)
				{
				}
				num = (short)2001207296;
				if (num != 0)
				{
				}
				num = (short)918290432;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547.Value;
			}
			set
			{
				short num = (short)1113007736;
				short num2 = num;
				num = (short)774776440;
				switch (num2 == num)
				{
				}
				num = (short)1005846529;
				if (num != 0)
				{
				}
				num = (short)2008940544;
				if (num != 0)
				{
				}
				num = (short)1903099904;
				short num3 = num;
				this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547.Value = value;
			}
		}

		// Token: 0x17002599 RID: 9625
		// (get) Token: 0x060048FF RID: 18687 RVA: 0x0043417C File Offset: 0x0043237C
		public global::AcpBusinessLayer.AcpField<bool> RadInfoGeneralPrimaryFrequencyBandUHF2_A42547
		{
			get
			{
				short num = (short)1943223574;
				short num2 = num;
				num = (short)1681276182;
				switch (num2 == num)
				{
				}
				num = (short)1990524929;
				if (num != 0)
				{
				}
				num = (short)1586167808;
				if (num != 0)
				{
				}
				num = (short)208863232;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547;
			}
		}

		// Token: 0x1700259A RID: 9626
		// (get) Token: 0x06004900 RID: 18688 RVA: 0x0043422C File Offset: 0x0043242C
		// (set) Token: 0x06004901 RID: 18689 RVA: 0x004342E0 File Offset: 0x004324E0
		public bool RadInfoGeneralPrimaryFrequencyBandUHF2_A42547_UIValue
		{
			get
			{
				short num = (short)871469989;
				short num2 = num;
				num = (short)849253285;
				switch (num2 == num)
				{
				}
				num = (short)1784545281;
				if (num != 0)
				{
				}
				num = (short)466288640;
				if (num != 0)
				{
				}
				num = (short)1825832960;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547.Value;
			}
			set
			{
				short num = (short)80166839;
				short num2 = num;
				num = (short)1344683959;
				switch (num2 == num)
				{
				}
				num = (short)398262273;
				if (num != 0)
				{
				}
				num = (short)2038235136;
				if (num != 0)
				{
				}
				num = (short)1987575808;
				short num3 = num;
				this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547.Value = value;
			}
		}

		// Token: 0x1700259B RID: 9627
		// (get) Token: 0x06004902 RID: 18690 RVA: 0x00434394 File Offset: 0x00432594
		// (set) Token: 0x06004903 RID: 18691 RVA: 0x00434444 File Offset: 0x00432644
		public bool RadInfoGeneralPrimaryFrequencyBandUHF2_A42547_Applicable
		{
			get
			{
				short num = (short)2107572225;
				if (num != 0)
				{
				}
				num = (short)597311260;
				short num2 = num;
				num = (short)1588215580;
				switch (num2 == num)
				{
				}
				num = (short)419627008;
				if (num != 0)
				{
				}
				num = (short)1620377600;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547.Applicable;
			}
			set
			{
				short num = (short)1593890662;
				short num2 = num;
				num = (short)388814694;
				switch (num2 == num)
				{
				}
				num = (short)395378689;
				if (num != 0)
				{
				}
				num = (short)1879965696;
				if (num != 0)
				{
				}
				num = (short)1565851648;
				short num3 = num;
				this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547.Applicable = value;
			}
		}

		// Token: 0x1700259C RID: 9628
		// (get) Token: 0x06004904 RID: 18692 RVA: 0x004344F8 File Offset: 0x004326F8
		// (set) Token: 0x06004905 RID: 18693 RVA: 0x004345B0 File Offset: 0x004327B0
		public bool RadInfoGeneralPrimaryFrequencyBandUHF2_A42547_Valid
		{
			get
			{
				short num = (short)479347630;
				short num2 = num;
				num = (short)1997095854;
				switch (num2 == num)
				{
				}
				num = (short)700907521;
				if (num != 0)
				{
				}
				num = (short)1479671808;
				if (num != 0)
				{
				}
				num = (short)2104033280;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547.Valid;
			}
			set
			{
				short num = (short)571634928;
				short num2 = num;
				num = (short)1048933616;
				switch (num2 == num)
				{
				}
				num = (short)1792147457;
				if (num != 0)
				{
				}
				num = (short)1208680448;
				if (num != 0)
				{
				}
				num = (short)341377024;
				short num3 = num;
				this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547.Valid = value;
			}
		}

		// Token: 0x1700259D RID: 9629
		// (get) Token: 0x06004906 RID: 18694 RVA: 0x00434664 File Offset: 0x00432864
		// (set) Token: 0x06004907 RID: 18695 RVA: 0x0043471C File Offset: 0x0043291C
		public bool RadInfoGeneralPrimaryFrequencyBandUHF2_A42547_Visible
		{
			get
			{
				short num = (short)254825990;
				short num2 = num;
				num = (short)30234118;
				switch (num2 == num)
				{
				}
				num = (short)1832714241;
				if (num != 0)
				{
				}
				num = (short)507904000;
				if (num != 0)
				{
				}
				num = (short)2042757120;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547.Visible;
			}
			set
			{
				short num = (short)1541614978;
				short num2 = num;
				num = (short)356527490;
				switch (num2 == num)
				{
				}
				num = (short)1220870145;
				if (num != 0)
				{
				}
				num = (short)2032861184;
				if (num != 0)
				{
				}
				num = (short)1156448256;
				short num3 = num;
				this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547.Visible = value;
			}
		}

		// Token: 0x1700259E RID: 9630
		// (get) Token: 0x06004908 RID: 18696 RVA: 0x004347D0 File Offset: 0x004329D0
		// (set) Token: 0x06004909 RID: 18697 RVA: 0x00434884 File Offset: 0x00432A84
		public bool RadInfoGeneralPrimaryFrequencyBandUHF2_A42547_Editable
		{
			get
			{
				short num = (short)397471173;
				short num2 = num;
				num = (short)1793387973;
				switch (num2 == num)
				{
				}
				num = (short)1862139905;
				if (num != 0)
				{
				}
				num = (short)516489216;
				if (num != 0)
				{
				}
				num = (short)358285312;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547.Editable;
			}
			set
			{
				short num = (short)1395326977;
				if (num != 0)
				{
				}
				num = (short)1376979178;
				short num2 = num;
				num = (short)1665337578;
				switch (num2 == num)
				{
				}
				num = (short)89260032;
				if (num != 0)
				{
				}
				num = (short)1456406528;
				short num3 = num;
				this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547.Editable = value;
			}
		}

		// Token: 0x1700259F RID: 9631
		// (get) Token: 0x0600490A RID: 18698 RVA: 0x00434938 File Offset: 0x00432B38
		internal string RadInfoGeneralPrimaryFrequencyBandUHF2_A42547_UILabel
		{
			get
			{
				short num = (short)861824851;
				short num2 = num;
				num = (short)1646552915;
				switch (num2 == num)
				{
				}
				num = (short)1806893057;
				if (num != 0)
				{
				}
				num = (short)580190208;
				if (num != 0)
				{
				}
				num = (short)929759232;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547.UIName;
			}
		}

		// Token: 0x170025A0 RID: 9632
		// (get) Token: 0x0600490B RID: 18699 RVA: 0x004349F0 File Offset: 0x00432BF0
		// (set) Token: 0x0600490C RID: 18700 RVA: 0x00434AA4 File Offset: 0x00432CA4
		internal bool RadInfoGeneralPrimaryFrequencyBandUHF2_A42547_HiddenStatic
		{
			get
			{
				short num = (short)1679652033;
				short num2 = num;
				num = (short)455505089;
				switch (num2 == num)
				{
				}
				num = (short)1305739264;
				if (num != 0)
				{
				}
				num = (short)1713700865;
				if (num != 0)
				{
				}
				num = (short)2121924608;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547.HiddenStatic;
			}
			set
			{
				short num = (short)364445697;
				if (num != 0)
				{
				}
				num = (short)945986485;
				short num2 = num;
				num = (short)88841141;
				switch (num2 == num)
				{
				}
				num = (short)966787072;
				if (num != 0)
				{
				}
				num = (short)785776640;
				short num3 = num;
				this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547.HiddenStatic = value;
			}
		}

		// Token: 0x170025A1 RID: 9633
		// (get) Token: 0x0600490D RID: 18701 RVA: 0x00434B58 File Offset: 0x00432D58
		// (set) Token: 0x0600490E RID: 18702 RVA: 0x00434C0C File Offset: 0x00432E0C
		internal bool RadInfoGeneralPrimaryFrequencyBandUHF2_A42547_HiddenDynamic
		{
			get
			{
				short num = (short)209709601;
				short num2 = num;
				num = (short)1672735265;
				switch (num2 == num)
				{
				}
				num = (short)1011875841;
				if (num != 0)
				{
				}
				num = (short)1058013184;
				if (num != 0)
				{
				}
				num = (short)2099576832;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547.HiddenDynamic;
			}
			set
			{
				short num = (short)1943011329;
				if (num != 0)
				{
				}
				num = (short)1319046341;
				short num2 = num;
				num = (short)1942883525;
				switch (num2 == num)
				{
				}
				num = (short)167247872;
				if (num != 0)
				{
				}
				num = (short)675872768;
				short num3 = num;
				this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547.HiddenDynamic = value;
			}
		}

		// Token: 0x170025A2 RID: 9634
		// (get) Token: 0x0600490F RID: 18703 RVA: 0x00434CC0 File Offset: 0x00432EC0
		public bool RadInfoGeneralPrimaryFrequencyBandUHF2_A42547_HasDiffs
		{
			get
			{
				short num = (short)751501313;
				if (num != 0)
				{
				}
				num = (short)1592206488;
				short num2 = num;
				num = (short)1625367704;
				switch (num2 == num)
				{
				}
				num = (short)841482240;
				if (num != 0)
				{
				}
				num = (short)2042822656;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBandUHF2_A42547._HasDiffs;
			}
		}

		// Token: 0x170025A3 RID: 9635
		// (get) Token: 0x06004910 RID: 18704 RVA: 0x00434D74 File Offset: 0x00432F74
		// (set) Token: 0x06004911 RID: 18705 RVA: 0x00434E2C File Offset: 0x0043302C
		public bool RadInfoGeneralPrimaryFrequencyBand900_A42548Value
		{
			get
			{
				short num = (short)465625133;
				short num2 = num;
				num = (short)1966530605;
				switch (num2 == num)
				{
				}
				num = (short)1933115393;
				if (num != 0)
				{
				}
				num = (short)378142720;
				if (num != 0)
				{
				}
				num = (short)989265920;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBand900_A42548.Value;
			}
			set
			{
				short num = (short)2118361374;
				short num2 = num;
				num = (short)535732510;
				switch (num2 == num)
				{
				}
				num = (short)1922564097;
				if (num != 0)
				{
				}
				num = (short)2027094016;
				if (num != 0)
				{
				}
				num = (short)1357316096;
				short num3 = num;
				this.radInfoGeneralPrimaryFrequencyBand900_A42548.Value = value;
			}
		}

		// Token: 0x170025A4 RID: 9636
		// (get) Token: 0x06004912 RID: 18706 RVA: 0x00434EE4 File Offset: 0x004330E4
		public global::AcpBusinessLayer.AcpField<bool> RadInfoGeneralPrimaryFrequencyBand900_A42548
		{
			get
			{
				short num = (short)213385217;
				if (num != 0)
				{
				}
				num = (short)1954920655;
				short num2 = num;
				num = (short)374061263;
				switch (num2 == num)
				{
				}
				num = (short)336986112;
				if (num != 0)
				{
				}
				num = (short)309919744;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBand900_A42548;
			}
		}

		// Token: 0x170025A5 RID: 9637
		// (get) Token: 0x06004913 RID: 18707 RVA: 0x00434F94 File Offset: 0x00433194
		// (set) Token: 0x06004914 RID: 18708 RVA: 0x0043504C File Offset: 0x0043324C
		public bool RadInfoGeneralPrimaryFrequencyBand900_A42548_UIValue
		{
			get
			{
				short num = (short)868254175;
				short num2 = num;
				num = (short)1223459295;
				switch (num2 == num)
				{
				}
				num = (short)419692544;
				if (num != 0)
				{
				}
				num = (short)172818433;
				if (num != 0)
				{
				}
				num = (short)1393885184;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBand900_A42548.Value;
			}
			set
			{
				short num = (short)386754533;
				short num2 = num;
				num = (short)137586661;
				switch (num2 == num)
				{
				}
				num = (short)188284929;
				if (num != 0)
				{
				}
				num = (short)120979456;
				if (num != 0)
				{
				}
				num = (short)1083768832;
				short num3 = num;
				this.radInfoGeneralPrimaryFrequencyBand900_A42548.Value = value;
			}
		}

		// Token: 0x170025A6 RID: 9638
		// (get) Token: 0x06004915 RID: 18709 RVA: 0x00435104 File Offset: 0x00433304
		// (set) Token: 0x06004916 RID: 18710 RVA: 0x004351B8 File Offset: 0x004333B8
		public bool RadInfoGeneralPrimaryFrequencyBand900_A42548_Applicable
		{
			get
			{
				short num = (short)1581091113;
				short num2 = num;
				num = (short)1634765097;
				switch (num2 == num)
				{
				}
				num = (short)1638858753;
				if (num != 0)
				{
				}
				num = (short)422051840;
				if (num != 0)
				{
				}
				num = (short)1708261376;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBand900_A42548.Applicable;
			}
			set
			{
				short num = (short)915814692;
				short num2 = num;
				num = (short)1054095652;
				switch (num2 == num)
				{
				}
				num = (short)1308688385;
				if (num != 0)
				{
				}
				num = (short)665124864;
				if (num != 0)
				{
				}
				num = (short)135987200;
				short num3 = num;
				this.radInfoGeneralPrimaryFrequencyBand900_A42548.Applicable = value;
			}
		}

		// Token: 0x170025A7 RID: 9639
		// (get) Token: 0x06004917 RID: 18711 RVA: 0x00435270 File Offset: 0x00433470
		// (set) Token: 0x06004918 RID: 18712 RVA: 0x00435324 File Offset: 0x00433524
		public bool RadInfoGeneralPrimaryFrequencyBand900_A42548_Valid
		{
			get
			{
				short num = (short)1824572396;
				short num2 = num;
				num = (short)1084933100;
				switch (num2 == num)
				{
				}
				num = (short)426901505;
				if (num != 0)
				{
				}
				num = (short)1209204736;
				if (num != 0)
				{
				}
				num = (short)1534525440;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBand900_A42548.Valid;
			}
			set
			{
				short num = (short)1634850931;
				short num2 = num;
				num = (short)316725363;
				switch (num2 == num)
				{
				}
				num = (short)1649344513;
				if (num != 0)
				{
				}
				num = (short)282722304;
				if (num != 0)
				{
				}
				num = (short)900595712;
				short num3 = num;
				this.radInfoGeneralPrimaryFrequencyBand900_A42548.Valid = value;
			}
		}

		// Token: 0x170025A8 RID: 9640
		// (get) Token: 0x06004919 RID: 18713 RVA: 0x004353D8 File Offset: 0x004335D8
		// (set) Token: 0x0600491A RID: 18714 RVA: 0x0043548C File Offset: 0x0043368C
		public bool RadInfoGeneralPrimaryFrequencyBand900_A42548_Visible
		{
			get
			{
				short num = (short)1403518977;
				if (num != 0)
				{
				}
				num = (short)282138461;
				short num2 = num;
				num = (short)299308893;
				switch (num2 == num)
				{
				}
				num = (short)1456013312;
				if (num != 0)
				{
				}
				num = (short)1606287360;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBand900_A42548.Visible;
			}
			set
			{
				short num = (short)256535332;
				short num2 = num;
				num = (short)1507355428;
				switch (num2 == num)
				{
				}
				num = (short)1546518528;
				if (num != 0)
				{
				}
				num = (short)170262529;
				if (num != 0)
				{
				}
				num = (short)2030174208;
				short num3 = num;
				this.radInfoGeneralPrimaryFrequencyBand900_A42548.Visible = value;
			}
		}

		// Token: 0x170025A9 RID: 9641
		// (get) Token: 0x0600491B RID: 18715 RVA: 0x00435544 File Offset: 0x00433744
		// (set) Token: 0x0600491C RID: 18716 RVA: 0x004355FC File Offset: 0x004337FC
		public bool RadInfoGeneralPrimaryFrequencyBand900_A42548_Editable
		{
			get
			{
				short num = (short)880834385;
				short num2 = num;
				num = (short)1258846033;
				switch (num2 == num)
				{
				}
				num = (short)127991809;
				if (num != 0)
				{
				}
				num = (short)743571456;
				if (num != 0)
				{
				}
				num = (short)1488584704;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBand900_A42548.Editable;
			}
			set
			{
				short num = (short)1470167824;
				short num2 = num;
				num = (short)902298384;
				switch (num2 == num)
				{
				}
				num = (short)781582336;
				if (num != 0)
				{
				}
				num = (short)46137345;
				if (num != 0)
				{
				}
				num = (short)1632174080;
				short num3 = num;
				this.radInfoGeneralPrimaryFrequencyBand900_A42548.Editable = value;
			}
		}

		// Token: 0x170025AA RID: 9642
		// (get) Token: 0x0600491D RID: 18717 RVA: 0x004356B0 File Offset: 0x004338B0
		internal string RadInfoGeneralPrimaryFrequencyBand900_A42548_UILabel
		{
			get
			{
				short num = (short)1648691138;
				short num2 = num;
				num = (short)586680258;
				switch (num2 == num)
				{
				}
				num = (short)635240448;
				if (num != 0)
				{
				}
				num = (short)1145110529;
				if (num != 0)
				{
				}
				num = (short)1291714560;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBand900_A42548.UIName;
			}
		}

		// Token: 0x170025AB RID: 9643
		// (get) Token: 0x0600491E RID: 18718 RVA: 0x00435764 File Offset: 0x00433964
		// (set) Token: 0x0600491F RID: 18719 RVA: 0x00435818 File Offset: 0x00433A18
		internal bool RadInfoGeneralPrimaryFrequencyBand900_A42548_HiddenStatic
		{
			get
			{
				short num = (short)1474305768;
				short num2 = num;
				num = (short)1761156840;
				switch (num2 == num)
				{
				}
				num = (short)1586233345;
				if (num != 0)
				{
				}
				num = (short)1685061632;
				if (num != 0)
				{
				}
				num = (short)261554176;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBand900_A42548.HiddenStatic;
			}
			set
			{
				short num = (short)544512094;
				short num2 = num;
				num = (short)1985386590;
				switch (num2 == num)
				{
				}
				num = (short)1786380288;
				if (num != 0)
				{
				}
				num = (short)24248321;
				if (num != 0)
				{
				}
				num = (short)1954807808;
				short num3 = num;
				this.radInfoGeneralPrimaryFrequencyBand900_A42548.HiddenStatic = value;
			}
		}

		// Token: 0x170025AC RID: 9644
		// (get) Token: 0x06004920 RID: 18720 RVA: 0x004358CC File Offset: 0x00433ACC
		// (set) Token: 0x06004921 RID: 18721 RVA: 0x00435980 File Offset: 0x00433B80
		internal bool RadInfoGeneralPrimaryFrequencyBand900_A42548_HiddenDynamic
		{
			get
			{
				short num = (short)768160950;
				short num2 = num;
				num = (short)490812598;
				switch (num2 == num)
				{
				}
				num = (short)1216872448;
				if (num != 0)
				{
				}
				num = (short)511705089;
				if (num != 0)
				{
				}
				num = (short)1064960000;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBand900_A42548.HiddenDynamic;
			}
			set
			{
				short num = (short)96142109;
				short num2 = num;
				num = (short)312148765;
				switch (num2 == num)
				{
				}
				num = (short)418643968;
				if (num != 0)
				{
				}
				num = (short)42205185;
				if (num != 0)
				{
				}
				num = (short)548274176;
				short num3 = num;
				this.radInfoGeneralPrimaryFrequencyBand900_A42548.HiddenDynamic = value;
			}
		}

		// Token: 0x170025AD RID: 9645
		// (get) Token: 0x06004922 RID: 18722 RVA: 0x00435A38 File Offset: 0x00433C38
		public bool RadInfoGeneralPrimaryFrequencyBand900_A42548_HasDiffs
		{
			get
			{
				short num = (short)535101441;
				if (num != 0)
				{
				}
				num = (short)600923125;
				short num2 = num;
				num = (short)54680565;
				switch (num2 == num)
				{
				}
				num = (short)587988992;
				if (num != 0)
				{
				}
				num = (short)69795840;
				short num3 = num;
				return this.radInfoGeneralPrimaryFrequencyBand900_A42548._HasDiffs;
			}
		}

		// Token: 0x170025AE RID: 9646
		// (get) Token: 0x06004923 RID: 18723 RVA: 0x00435AEC File Offset: 0x00433CEC
		// (set) Token: 0x06004924 RID: 18724 RVA: 0x00435BA0 File Offset: 0x00433DA0
		public bool RadInfoGeneralDisplayCodeplugAlias_43580Value
		{
			get
			{
				short num = (short)875823105;
				if (num != 0)
				{
				}
				num = (short)1838046843;
				short num2 = num;
				num = (short)764305019;
				switch (num2 == num)
				{
				}
				num = (short)69206016;
				if (num != 0)
				{
				}
				num = (short)710017024;
				short num3 = num;
				return this.radInfoGeneralDisplayCodeplugAlias_43580.Value;
			}
			set
			{
				short num = (short)1090125825;
				if (num != 0)
				{
				}
				num = (short)646035187;
				short num2 = num;
				num = (short)110737139;
				switch (num2 == num)
				{
				}
				num = (short)1766457344;
				if (num != 0)
				{
				}
				num = (short)1211170816;
				short num3 = num;
				this.radInfoGeneralDisplayCodeplugAlias_43580.Value = value;
			}
		}

		// Token: 0x170025AF RID: 9647
		// (get) Token: 0x06004925 RID: 18725 RVA: 0x00435C54 File Offset: 0x00433E54
		public global::AcpBusinessLayer.AcpField<bool> RadInfoGeneralDisplayCodeplugAlias_43580
		{
			get
			{
				short num = (short)475198726;
				short num2 = num;
				num = (short)2019751174;
				switch (num2 == num)
				{
				}
				num = (short)957087744;
				if (num != 0)
				{
				}
				num = (short)1044054017;
				if (num != 0)
				{
				}
				num = (short)808255488;
				short num3 = num;
				return this.radInfoGeneralDisplayCodeplugAlias_43580;
			}
		}

		// Token: 0x170025B0 RID: 9648
		// (get) Token: 0x06004926 RID: 18726 RVA: 0x00435D00 File Offset: 0x00433F00
		// (set) Token: 0x06004927 RID: 18727 RVA: 0x00435DB4 File Offset: 0x00433FB4
		public bool RadInfoGeneralDisplayCodeplugAlias_43580_UIValue
		{
			get
			{
				short num = (short)1089472839;
				short num2 = num;
				num = (short)2017790279;
				switch (num2 == num)
				{
				}
				num = (short)482803713;
				if (num != 0)
				{
				}
				num = (short)1715470336;
				if (num != 0)
				{
				}
				num = (short)1978466304;
				short num3 = num;
				return this.radInfoGeneralDisplayCodeplugAlias_43580.Value;
			}
			set
			{
				short num = (short)1667152598;
				short num2 = num;
				num = (short)1433975510;
				switch (num2 == num)
				{
				}
				num = (short)1898315777;
				if (num != 0)
				{
				}
				num = (short)1692925952;
				if (num != 0)
				{
				}
				num = (short)407109632;
				short num3 = num;
				this.radInfoGeneralDisplayCodeplugAlias_43580.Value = value;
			}
		}

		// Token: 0x170025B1 RID: 9649
		// (get) Token: 0x06004928 RID: 18728 RVA: 0x00435E6C File Offset: 0x0043406C
		// (set) Token: 0x06004929 RID: 18729 RVA: 0x00435F20 File Offset: 0x00434120
		public bool RadInfoGeneralDisplayCodeplugAlias_43580_Applicable
		{
			get
			{
				short num = (short)1724624717;
				short num2 = num;
				num = (short)1002745677;
				switch (num2 == num)
				{
				}
				num = (short)342556672;
				if (num != 0)
				{
				}
				num = (short)1557856257;
				if (num != 0)
				{
				}
				num = (short)291176448;
				short num3 = num;
				return this.radInfoGeneralDisplayCodeplugAlias_43580.Applicable;
			}
			set
			{
				short num = (short)1838680731;
				short num2 = num;
				num = (short)48171675;
				switch (num2 == num)
				{
				}
				num = (short)318308352;
				if (num != 0)
				{
				}
				num = (short)985989121;
				if (num != 0)
				{
				}
				num = (short)790953984;
				short num3 = num;
				this.radInfoGeneralDisplayCodeplugAlias_43580.Applicable = value;
			}
		}

		// Token: 0x170025B2 RID: 9650
		// (get) Token: 0x0600492A RID: 18730 RVA: 0x00435FD4 File Offset: 0x004341D4
		// (set) Token: 0x0600492B RID: 18731 RVA: 0x00436088 File Offset: 0x00434288
		public bool RadInfoGeneralDisplayCodeplugAlias_43580_Valid
		{
			get
			{
				short num = (short)1347074633;
				short num2 = num;
				num = (short)450148937;
				switch (num2 == num)
				{
				}
				num = (short)815923200;
				if (num != 0)
				{
				}
				num = (short)434110465;
				if (num != 0)
				{
				}
				num = (short)186580992;
				short num3 = num;
				return this.radInfoGeneralDisplayCodeplugAlias_43580.Valid;
			}
			set
			{
				short num = (short)897316446;
				short num2 = num;
				num = (short)998045278;
				switch (num2 == num)
				{
				}
				num = (short)1895301121;
				if (num != 0)
				{
				}
				num = (short)1493893120;
				if (num != 0)
				{
				}
				num = (short)1579876352;
				short num3 = num;
				this.radInfoGeneralDisplayCodeplugAlias_43580.Valid = value;
			}
		}

		// Token: 0x170025B3 RID: 9651
		// (get) Token: 0x0600492C RID: 18732 RVA: 0x0043613C File Offset: 0x0043433C
		// (set) Token: 0x0600492D RID: 18733 RVA: 0x004361F0 File Offset: 0x004343F0
		public bool RadInfoGeneralDisplayCodeplugAlias_43580_Visible
		{
			get
			{
				short num = (short)1398276097;
				if (num != 0)
				{
				}
				num = (short)1316665927;
				short num2 = num;
				num = (short)1869199943;
				switch (num2 == num)
				{
				}
				num = (short)1479868416;
				if (num != 0)
				{
				}
				num = (short)620822528;
				short num3 = num;
				return this.radInfoGeneralDisplayCodeplugAlias_43580.Visible;
			}
			set
			{
				short num = (short)2103232419;
				short num2 = num;
				num = (short)1678886819;
				switch (num2 == num)
				{
				}
				num = (short)2092236801;
				if (num != 0)
				{
				}
				num = (short)143065088;
				if (num != 0)
				{
				}
				num = (short)1921449984;
				short num3 = num;
				this.radInfoGeneralDisplayCodeplugAlias_43580.Visible = value;
			}
		}

		// Token: 0x170025B4 RID: 9652
		// (get) Token: 0x0600492E RID: 18734 RVA: 0x004362A4 File Offset: 0x004344A4
		// (set) Token: 0x0600492F RID: 18735 RVA: 0x00436358 File Offset: 0x00434558
		public bool RadInfoGeneralDisplayCodeplugAlias_43580_Editable
		{
			get
			{
				short num = (short)1542914049;
				if (num != 0)
				{
				}
				num = (short)733042134;
				short num2 = num;
				num = (short)637294038;
				switch (num2 == num)
				{
				}
				num = (short)316276736;
				if (num != 0)
				{
				}
				num = (short)1219690496;
				short num3 = num;
				return this.radInfoGeneralDisplayCodeplugAlias_43580.Editable;
			}
			set
			{
				short num = (short)1532141267;
				short num2 = num;
				num = (short)2090376915;
				switch (num2 == num)
				{
				}
				num = (short)442826753;
				if (num != 0)
				{
				}
				num = (short)905183232;
				if (num != 0)
				{
				}
				num = (short)1970274304;
				short num3 = num;
				this.radInfoGeneralDisplayCodeplugAlias_43580.Editable = value;
			}
		}

		// Token: 0x170025B5 RID: 9653
		// (get) Token: 0x06004930 RID: 18736 RVA: 0x00436410 File Offset: 0x00434610
		internal string RadInfoGeneralDisplayCodeplugAlias_43580_UILabel
		{
			get
			{
				short num = (short)1729398161;
				short num2 = num;
				num = (short)59671953;
				switch (num2 == num)
				{
				}
				num = (short)1439367169;
				if (num != 0)
				{
				}
				num = (short)1660682240;
				if (num != 0)
				{
				}
				num = (short)1154875392;
				short num3 = num;
				return this.radInfoGeneralDisplayCodeplugAlias_43580.UIName;
			}
		}

		// Token: 0x170025B6 RID: 9654
		// (get) Token: 0x06004931 RID: 18737 RVA: 0x004364C8 File Offset: 0x004346C8
		// (set) Token: 0x06004932 RID: 18738 RVA: 0x00436580 File Offset: 0x00434780
		internal bool RadInfoGeneralDisplayCodeplugAlias_43580_HiddenStatic
		{
			get
			{
				short num = (short)1996024693;
				short num2 = num;
				num = (short)451799925;
				switch (num2 == num)
				{
				}
				num = (short)1639251969;
				if (num != 0)
				{
				}
				num = (short)992280576;
				if (num != 0)
				{
				}
				num = (short)1957691392;
				short num3 = num;
				return this.radInfoGeneralDisplayCodeplugAlias_43580.HiddenStatic;
			}
			set
			{
				short num = (short)729839831;
				short num2 = num;
				num = (short)1740077271;
				switch (num2 == num)
				{
				}
				num = (short)2009137152;
				if (num != 0)
				{
				}
				num = (short)2031550464;
				short num3 = num;
				num = (short)860880897;
				if (num != 0)
				{
				}
				this.radInfoGeneralDisplayCodeplugAlias_43580.HiddenStatic = value;
			}
		}

		// Token: 0x170025B7 RID: 9655
		// (get) Token: 0x06004933 RID: 18739 RVA: 0x00436634 File Offset: 0x00434834
		// (set) Token: 0x06004934 RID: 18740 RVA: 0x004366EC File Offset: 0x004348EC
		internal bool RadInfoGeneralDisplayCodeplugAlias_43580_HiddenDynamic
		{
			get
			{
				short num = (short)1917517825;
				if (num != 0)
				{
				}
				num = (short)1942770255;
				short num2 = num;
				num = (short)1514754639;
				switch (num2 == num)
				{
				}
				num = (short)39911424;
				short num3 = num;
				num = (short)112918528;
				if (num != 0)
				{
				}
				return this.radInfoGeneralDisplayCodeplugAlias_43580.HiddenDynamic;
			}
			set
			{
				short num = (short)379971902;
				short num2 = num;
				num = (short)736684350;
				switch (num2 == num)
				{
				}
				num = (short)695140353;
				if (num != 0)
				{
				}
				num = (short)314114048;
				short num3 = num;
				num = (short)803864576;
				if (num != 0)
				{
				}
				this.radInfoGeneralDisplayCodeplugAlias_43580.HiddenDynamic = value;
			}
		}

		// Token: 0x170025B8 RID: 9656
		// (get) Token: 0x06004935 RID: 18741 RVA: 0x004367A0 File Offset: 0x004349A0
		public bool RadInfoGeneralDisplayCodeplugAlias_43580_HasDiffs
		{
			get
			{
				short num = (short)1875158169;
				short num2 = num;
				num = (short)2032313497;
				switch (num2 == num)
				{
				}
				num = (short)286457857;
				if (num != 0)
				{
				}
				num = (short)328138752;
				short num3 = num;
				num = (short)182190080;
				if (num != 0)
				{
				}
				return this.radInfoGeneralDisplayCodeplugAlias_43580._HasDiffs;
			}
		}

		// Token: 0x06004936 RID: 18742 RVA: 0x00436858 File Offset: 0x00434A58
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
					goto IL_13F;
				case 1:
					num2 = (short)1923678208;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return result;
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)578027521;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
				{
					num2 = (short)646501680;
					short num3 = num2;
					num2 = (short)348116272;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13F;
					default:
					{
						num2 = (short)1647902720;
						if (num2 != 0)
						{
						}
						num2 = (short)1201078272;
						short num4 = num2;
						num2 = (short)726007809;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)323682306;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_24;
				IL_13F:
				if (base.ParentRecset.ContainerDoc == null)
				{
					break;
				}
				num2 = (short)579338244;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1266417667;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04001A8E RID: 6798
		private global::AcpBusinessLayer.AcpField<string> radInfoGeneralInstalledTxmCertificate;

		// Token: 0x04001A8F RID: 6799
		private global::AcpBusinessLayer.AcpField<string> radInfoGeneralBootloaderVersion_A7567;

		// Token: 0x04001A90 RID: 6800
		private global::AcpBusinessLayer.AcpField<string> radInfoGeneralCodeplugVersion_A7683;

		// Token: 0x04001A91 RID: 6801
		private global::AcpBusinessLayer.AcpField<string> radInfoGeneralDSPVersion_A7892;

		// Token: 0x04001A92 RID: 6802
		private global::AcpBusinessLayer.AcpField<string> radInfoGeneralFirmwareVersion_A8124;

		// Token: 0x04001A93 RID: 6803
		private global::AcpBusinessLayer.AcpField<string> radInfoGeneralModelNumber_A8539;

		// Token: 0x04001A94 RID: 6804
		private global::AcpBusinessLayer.AcpField<string> radInfoGeneralNautilusVersion_A8564;

		// Token: 0x04001A95 RID: 6805
		private global::AcpBusinessLayer.AcpField<string> radInfoGeneralPSDTVersion_A8768;

		// Token: 0x04001A96 RID: 6806
		private global::AcpBusinessLayer.AcpField<string> radInfoGeneralSerialNumber_A9122;

		// Token: 0x04001A97 RID: 6807
		private global::AcpBusinessLayer.AcpField<string> radInfoGeneralTuningVersion_A9509;

		// Token: 0x04001A98 RID: 6808
		private global::AcpBusinessLayer.AcpSimpleRangeField radInfoGeneralMaximumChannels_A11479;

		// Token: 0x04001A99 RID: 6809
		private global::AcpBusinessLayer.AcpField<string> radInfoGeneralPrimaryFrequencyBand_A12713;

		// Token: 0x04001A9A RID: 6810
		private global::AcpBusinessLayer.AcpField<string> radInfoGeneralSecondaryFrequencyBand_A12715;

		// Token: 0x04001A9B RID: 6811
		private global::AcpBusinessLayer.AcpListField radInfoGeneralRegionalGovernance_A36710;

		// Token: 0x04001A9C RID: 6812
		private global::AcpBusinessLayer.AcpFieldX<string, string> radInfoGeneralWiFiRegulatoryRegion_A43772;

		// Token: 0x04001A9D RID: 6813
		private global::AcpBusinessLayer.AcpField<string> radInfoGeneralUCMVersion_A9591;

		// Token: 0x04001A9E RID: 6814
		private global::AcpBusinessLayer.AcpField<string> radInfoGeneralCodeplugAlias_A7684;

		// Token: 0x04001A9F RID: 6815
		private global::AcpBusinessLayer.AcpField<string> radInfoGeneralElectronicSerialNumber_A41744;

		// Token: 0x04001AA0 RID: 6816
		private global::AcpBusinessLayer.AcpFieldX<string, string> radInfoGeneralMACAddress_A41837;

		// Token: 0x04001AA1 RID: 6817
		private global::AcpBusinessLayer.AcpField<string> radInfoGeneralSecureHardwareType;

		// Token: 0x04001AA2 RID: 6818
		private global::AcpBusinessLayer.AcpField<string> radInfoGeneralSecureHardwareVersion;

		// Token: 0x04001AA3 RID: 6819
		private global::AcpBusinessLayer.AcpFieldX<string, string> radInfoGeneralWiFiMACAddress_42509;

		// Token: 0x04001AA4 RID: 6820
		private global::AcpBusinessLayer.AcpFieldX<string, string> radInfoGeneralWiFiBTMACAddress_42510;

		// Token: 0x04001AA5 RID: 6821
		private global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBand700_A42543;

		// Token: 0x04001AA6 RID: 6822
		private global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBand800_A42544;

		// Token: 0x04001AA7 RID: 6823
		private global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBandVHF_A42545;

		// Token: 0x04001AA8 RID: 6824
		private global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBandUHF1_A42546;

		// Token: 0x04001AA9 RID: 6825
		private global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBandUHF2_A42547;

		// Token: 0x04001AAA RID: 6826
		private global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBand900_A42548;

		// Token: 0x04001AAB RID: 6827
		private global::AcpBusinessLayer.AcpField<bool> radInfoGeneralDisplayCodeplugAlias_43580;
	}
}
