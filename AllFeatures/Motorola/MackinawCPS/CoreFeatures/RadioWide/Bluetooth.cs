using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000123 RID: 291
	[global::System.Serializable]
	public class Bluetooth : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06002C09 RID: 11273 RVA: 0x002A9920 File Offset: 0x002A7B20
		public Bluetooth(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x002A993C File Offset: 0x002A7B3C
		protected Bluetooth(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x002A9954 File Offset: 0x002A7B54
		public override void Init()
		{
			int a_ = 0;
			short num = (short)1926093192;
			short num2 = num;
			num = (short)1302845832;
			switch (num2 == num)
			{
			}
			num = (short)1000800256;
			if (num != 0)
			{
			}
			num = (short)1028784129;
			if (num != 0)
			{
			}
			num = (short)1941700608;
			short num3 = num;
			this.radWideBluetoothBluetoothEnable_A37028 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌跎뷐ꛒ냔ꏖ뛘듚꧜럞ꏠ迢郤苦鷨蓪苬鯮駰뛲鯴零鯸韺飼ꃾ䀀。㈄㜆㬈㌊", a_), global::CommonResources.AcgResources.ID_BLUETOOTHENABLE);
			this.radWideBluetoothBluetoothEnable_A37028.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideBluetoothBluetoothEnable_A37028.DataTransferOrder = 147;
			this.radWideBluetoothBluetoothTones_A37035 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌跎뷐ꛒ냔ꏖ뛘듚꧜럞ꏠ迢郤苦鷨蓪苬鯮駰ꟲ髴駶鳸裺ꋼ뻾㈀㐂㔄㐆㰈", a_), global::CommonResources.AcgResources.ID_BLUETOOTHTONES);
			this.radWideBluetoothBluetoothTones_A37035.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideBluetoothBluetoothTones_A37035.DataTransferOrder = 148;
			this.radWideBluetoothBluetoothRSMLED_A37039 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌跎뷐ꛒ냔ꏖ뛘듚꧜럞ꏠ迢郤苦鷨蓪苬鯮駰ꇲ꛴뫶뗸뻺맼ꃾ䀀。㈄㜆㨈㈊", a_), global::CommonResources.AcgResources.ID_RSMBLUETOOTHLED);
			this.radWideBluetoothBluetoothRSMLED_A37039.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideBluetoothBluetoothRSMLED_A37039.DataTransferOrder = 154;
			this.radWideBluetoothBluetoothPairingType_A37036 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadWideBluetoothBluetoothPairingType_A37036LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadWideBluetoothBluetoothPairingType_A37036LovStrs), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌跎뷐ꛒ냔ꏖ뛘듚꧜럞ꏠ迢郤苦鷨蓪苬鯮駰ꏲ铴黶诸鋺鏼飾唀稂甄戆嘈䨊㸌㠎ℐ‒⌔", a_), global::CommonResources.AcgResources.ID_BLUETOOTHPAIRINGTYPE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideBluetoothBluetoothPairingType_A37036LovStrs);
			this.radWideBluetoothBluetoothPairingType_A37036.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideBluetoothBluetoothPairingType_A37036.DataTransferOrder = 149;
			this.radWideBluetoothBluetoothReconnectTimer_A37037 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌跎뷐ꛒ냔ꏖ뛘듚꧜럞ꏠ迢郤苦鷨蓪苬鯮駰ꇲ郴银雸闺鏼髾戀眂億渆搈渊缌倎倐‒∔✖⨘Ⱊ", a_), global::CommonResources.AcgResources.ID_BLUETOOTHREPAIRTIMER, 0, 255, 255, global::CommonResources.AcgResources.ID_IMMEDIATE, null);
			this.radWideBluetoothBluetoothReconnectTimer_A37037.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideBluetoothBluetoothReconnectTimer_A37037.DataTransferOrder = 150;
			this.radWideBluetoothBluetoothReconnectTimer_A37037.AddCustomValue(255, global::CommonResources.AcgResources.ID_INFINITE);
			this.radWideBluetoothBluetoothReconnectTimer_A37037.ShowHexValue = false;
			this.radWideBluetoothBluetoothDropTimer_A37038 = new global::AcpBusinessLayer.AcpSparseLOVField(5, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadWideBluetoothBluetoothDropTimer_A37038LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadWideBluetoothBluetoothDropTimer_A37038LovStrs), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌跎뷐ꛒ냔ꏖ뛘듚꧜럞ꏠ迢郤苦鷨蓪苬鯮駰럲蟴飶觸꿺铼鋾搀焂娄䘆㨈㰊㴌㰎⤐", a_), global::CommonResources.AcgResources.ID_BLUETOOTHDROPTIMER, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideBluetoothBluetoothDropTimer_A37038LovStrs);
			this.radWideBluetoothBluetoothDropTimer_A37038.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideBluetoothBluetoothDropTimer_A37038.DataTransferOrder = 151;
			this.radWideBluetoothFriendlyName_A41181 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_APXRADIO, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌跎뷐ꛒ냔ꏖ뛘듚꧜럞꟠釢賤苦蟨迪臬雮뿰鋲飴鋶꛸뫺짼컾\u3000㬂㐄", a_), global::CommonResources.AcgResources.ID_BLUETOOTHFRIENDLYNAME, 14);
			this.radWideBluetoothFriendlyName_A41181.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideBluetoothFriendlyName_A41181.DataTransferOrder = 153;
			this.radWideBluetoothFriendlyNameEditable_A41182 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌跎뷐ꛒ냔ꏖ뛘듚꧜럞꟠釢賤苦蟨迪臬雮뿰鋲飴鋶본鿺铼课怀愂椄戆嘈䨊㤌㸎‐⬒✔", a_), global::CommonResources.AcgResources.ID_BLUETOOTHFRIENDLYNAMEEDITABLE);
			this.radWideBluetoothFriendlyNameEditable_A41182.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideBluetoothFriendlyNameEditable_A41182.DataTransferOrder = 152;
			this.radWideBluetoothLegacyBluetoothPINPairing = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌跎뷐ꛒ냔ꏖ뛘듚꧜럞균蛢苤蛦諨鋪꿬菮蓰雲致飶雸迺闼꿾䠀䴂唄昆怈礊搌愎瘐", a_), global::CommonResources.AcgResources.ID_LEGACY_BLUETOOTHPINPAIRING);
			this.radWideBluetoothLegacyBluetoothPINPairing.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideBluetoothLegacyBluetoothPINPairing.DataTransferOrder = 232;
			this.radWideStandardNFCPairing_A44928 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌鳎ꗐ닒믔돖룘꧚맜釞꟠ꃢ뗤蛦胨駪蓬臮雰곲듴쏶췸싺쿼쟾", a_), global::CommonResources.AcgResources.ID_STANDARD_NFC_PAIRING);
			this.radWideStandardNFCPairing_A44928.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideStandardNFCPairing_A44928.DataTransferOrder = 233;
			this.radWideSecureNFCPairing_A44931 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌鳎듐냒ꃔꗖ볘闚鯜鳞뇠苢賤闦胨藪諬냮냰쟲쇴컶쫸쫺", a_), global::CommonResources.AcgResources.ID_SECURE_NFC_PAIRING);
			this.radWideSecureNFCPairing_A44931.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideSecureNFCPairing_A44931.DataTransferOrder = 234;
			this.radWideBluetoothReplacePairingInfo_A41562 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌跎뷐ꛒ냔ꏖ뛘듚꧜럞돠蛢闤详裨裪裬뿮郰髲蟴黶韸鳺듼釾最氂娄䘆㴈㨊㠌㤎⌐", a_), global::CommonResources.AcgResources.ID_BLUETOOTHREPLACEPAIRINGINFO);
			this.radWideBluetoothReplacePairingInfo_A41562.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideBluetoothReplacePairingInfo_A41562.DataTransferOrder = 210;
			this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌跎뷐ꛒ냔ꏖ뛘듚꧜럞ꃠ胢釤軦鿨軪뿬볮볰뫲鯴菶鳸觺鏼黾洀丂氄搆䀈洊䌌怎攐儒愔娖瀘砚䈜帞ᔠሢဤဦἨ", a_), global::CommonResources.AcgResources.ID_ACTIVERSMINTERNALMICIFNOBLUETOOTHMIC);
			this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.DataTransferOrder = 215;
			this.radWideBluetoothBluetoothDeviceInquiryDuration_41977 = new global::AcpBusinessLayer.AcpCustomRangeField(30, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌跎뷐ꛒ냔ꏖ뛘듚꧜럞ꏠ迢郤苦鷨蓪苬鯮駰럲郴臶郸飺飼뛾漀爂瀄渆笈爊䤌税挐爒愔縖瘘甚䈜⬞ဠᨢሤဦ", a_), global::CommonResources.AcgResources.ID_BLUETOOTHDEVICESEARCHDURATIONSEC, 5, 60, 5, null, null);
			this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.DataTransferOrder = 229;
			this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.ShowHexValue = false;
			this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980 = new global::AcpBusinessLayer.AcpSimpleRangeField(2, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌跎뷐ꛒ냔ꏖ뛘듚꧜럞ꏠ迢郤苦鷨蓪苬鯮駰럲鳴蓶髸铺诼髾猀戂朄欆氈上甌缎砐愒琔挖瀘琚猜䬞䠠丢䀤唦瘨Ἢᰬᘮर̲", a_), global::CommonResources.AcgResources.ID_BLUETOOTHRADIOVISIBILITYDURATIONMIN, 1, 10, null, null, 0, 1);
			this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.DataTransferOrder = 230;
			this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.ShowHexValue = false;
			this.radWideBluetoothBluetoothPANNetworkAddress_41983 = new global::AcpBusinessLayer.AcpIPAddressField(25471168L, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌跎뷐ꛒ냔ꏖ뛘듚꧜럞ꏠ迢郤苦鷨蓪苬鯮駰ꏲ듴맶럸黺觼裾渀焂渄䘆洈漊缌樎成怒䨔⌖⠘√├Ⱎ", a_), global::CommonResources.AcgResources.ID_BLUETOOTHPANNETWORKBASEADDRESS);
			this.radWideBluetoothBluetoothPANNetworkAddress_41983.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideBluetoothBluetoothPANNetworkAddress_41983.DataTransferOrder = 231;
			this.radWideMPPPairingOnlyWithLTE_A42320 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌苎臐菒藔뛖냘꧚드뇞蛠곢诤详部볪蓬鯮駰뿲ꇴ닶꛸뫺짼췾㈀㄂㔄", a_), global::CommonResources.AcgResources.ID_MPPPAIRINGONLYWITHLTE);
			this.radWideMPPPairingOnlyWithLTE_A42320.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideMPPPairingOnlyWithLTE_A42320.DataTransferOrder = -1;
			this.radWideBluetoothAudioBackwardsCompatibility_A44942 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌跎뷐ꛒ냔ꏖ뛘듚꧜럞ꃠ離臤軦蛨ꧪ賬賮髰蓲铴藶鷸裺뻼郾氀猂搄猆怈椊搌挎砐朒气䠖堘⼚⤜☞ᔠᄢ", a_), global::CommonResources.AcgResources.ID_BLUETOOTH_AUDIO_BACKWARDS_COMPATIBILITY);
			this.radWideBluetoothAudioBackwardsCompatibility_A44942.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideBluetoothAudioBackwardsCompatibility_A44942.DataTransferOrder = 235;
			this.radWideBluetoothImproveAudioLatency_A44943 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌跎뷐ꛒ냔ꏖ뛘듚꧜럞꣠転闤闦蛨鷪裬껮蓰韲鳴飶뗸髺觼髾漀怂簄堆䠈㼊㤌㘎┐‒", a_), global::CommonResources.AcgResources.ID_BLUETOOTH_IMPROVE_AUDIO_LATENCY);
			this.radWideBluetoothImproveAudioLatency_A44943.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radWideBluetoothImproveAudioLatency_A44943.DataTransferOrder = 236;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菀꿂냄ꋆ뷈꓊ꋌ믎말", a_);
			base.Id = 10630;
			base.UIName = global::CommonResources.AcgResources.ID_BLUETOOTH;
			base.DataTransferOrder = 15;
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x002A9F34 File Offset: 0x002A8134
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)684392502;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_197;
				case 1:
					this.radWideBluetoothBluetoothDropTimer_A37038 = new global::AcpBusinessLayer.AcpSparseLOVField(5, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadWideBluetoothBluetoothDropTimer_A37038LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadWideBluetoothBluetoothDropTimer_A37038LovStrs), this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꫧ蛩駫语蓯鷱鯳苵郷뻹軻釽烿嘁洃欅洇砉匋伍⌏┑␓┕‗", a_), global::CommonResources.AcgResources.ID_BLUETOOTHDROPTIMER, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideBluetoothBluetoothDropTimer_A37038LovStrs);
					this.radWideBluetoothBluetoothDropTimer_A37038.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideBluetoothBluetoothDropTimer_A37038.DataTransferOrder = 151;
					num = (short)1035665445;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_AC0;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꫧ蛩駫语蓯鷱鯳苵郷꫹뷻냽仿朁瀃焅朇砉朋伍琏瘑易猕欗椙䌛⨝ᄟᬡᰣᔥ", a_)))
					{
						num = (short)669712401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_149;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓藕뷗맙꧛곝藟곡ꋣꗥ룧诩藫鳭駯鳱鏳꧵맷컹죻쟽㏿㌁", a_)))
					{
						num = (short)1769340983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6DF;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꫧ蛩駫语蓯鷱鯳苵郷뻹軻釽烿嘁洃欅洇砉匋伍⌏┑␓┕‗", a_)))
					{
						num = (short)1938227201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9C8;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꫧ蛩駫语蓯鷱鯳苵郷뻹闻跽揿洁爃挅稇欉渋戍甏圑氓昕焗栙紛樝䤟䴡䨣爥䄧䜩䤫尭漯رԳ༵7ਹ", a_)))
					{
						num = (short)1206386700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E46;
				case 7:
					this.radWideBluetoothBluetoothRSMLED_A37039 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꫧ蛩駫语蓯鷱鯳苵郷꣹꿻돽䳿䜁䀃夅䤇㤉㬋㸍⌏⬑", a_), global::CommonResources.AcgResources.ID_RSMBLUETOOTHLED);
					this.radWideBluetoothBluetoothRSMLED_A37039.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideBluetoothBluetoothRSMLED_A37039.DataTransferOrder = 154;
					num = (short)1941372959;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					this.radWideBluetoothBluetoothDeviceInquiryDuration_41977 = new global::AcpBusinessLayer.AcpCustomRangeField(30, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꫧ蛩駫语蓯鷱鯳苵郷뻹駻製槿愁愃伅昇笉礋服戏欑倓挕樗笙栛眝伟䰡笣ሥᤧጩᬫ᤭", a_), global::CommonResources.AcgResources.ID_BLUETOOTHDEVICESEARCHDURATIONSEC, null, null);
					this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.DataTransferOrder = 229;
					this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.ShowHexValue = false;
					num = (short)2016739346;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					this.radWideBluetoothBluetoothTones_A37035 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꫧ蛩駫语蓯鷱鯳苵郷껹鏻都旿焁嬃䜅㬇㴉㰋㴍┏", a_), global::CommonResources.AcgResources.ID_BLUETOOTHTONES);
					this.radWideBluetoothBluetoothTones_A37035.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideBluetoothBluetoothTones_A37035.DataTransferOrder = 148;
					num = (short)591265811;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꫧ蛩駫语蓯鷱鯳苵郷뻹駻製槿愁愃伅昇笉礋服戏欑倓挕樗笙栛眝伟䰡笣ሥᤧጩᬫ᤭", a_)))
					{
						num = (short)1960443912;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B0E;
				case 11:
					num = (short)683474982;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980 = new global::AcpBusinessLayer.AcpSimpleRangeField(2, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꫧ蛩駫语蓯鷱鯳苵郷뻹闻跽揿洁爃挅稇欉渋戍甏圑氓昕焗栙紛樝䤟䴡䨣爥䄧䜩䤫尭漯رԳ༵7ਹ", a_), global::CommonResources.AcgResources.ID_BLUETOOTHRADIOVISIBILITYDURATIONMIN, null, null, 0, 1);
					this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.DataTransferOrder = 230;
					this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.ShowHexValue = false;
					num = (short)1787494434;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_53F;
				case 14:
					goto IL_6DF;
				case 15:
					this.radWideBluetoothBluetoothPairingType_A37036 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadWideBluetoothBluetoothPairingType_A37036LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadWideBluetoothBluetoothPairingType_A37036LovStrs), this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꫧ蛩駫语蓯鷱鯳苵郷꫹鷻韽狿欁樃愅將猉簋欍伏匑✓ℕ⠗⤙⨛", a_), global::CommonResources.AcgResources.ID_BLUETOOTHPAIRINGTYPE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideBluetoothBluetoothPairingType_A37036LovStrs);
					this.radWideBluetoothBluetoothPairingType_A37036.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideBluetoothBluetoothPairingType_A37036.DataTransferOrder = 149;
					num = (short)1399586848;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥껧飩藫语黯雱飳迵뛷鯹釻鯽忿䌁〃㜅㤇㈉㴋", a_)))
					{
						num = (short)1334312960;
						short num3 = num;
						num = (short)251133999;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_53F;
				case 17:
					this.radWideBluetoothBluetoothPANNetworkAddress_41983 = new global::AcpBusinessLayer.AcpIPAddressField(25471168L, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꫧ蛩駫语蓯鷱鯳苵郷꫹뷻냽仿朁瀃焅朇砉朋伍琏瘑易猕欗椙䌛⨝ᄟᬡᰣᔥ", a_), global::CommonResources.AcgResources.ID_BLUETOOTHPANNETWORKBASEADDRESS);
					this.radWideBluetoothBluetoothPANNetworkAddress_41983.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideBluetoothBluetoothPANNetworkAddress_41983.DataTransferOrder = 231;
					num = (short)574423097;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_B0E;
				case 19:
					goto IL_92D;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꓧ迩诫迭鏯诱뛳髵跷鿹裻釽濿瘁氃嘅䄇䐉尋漍礏怑紓砕缗", a_)))
					{
						num = (short)546963491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_340;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥뫧迩鳫苭釯釱釳꛵駷鏹軻韽滿攁䴃栅渇攉匋伍␏⌑ℓ―⨗", a_)))
					{
						num = (short)655401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CB0;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꫧ蛩駫语蓯鷱鯳苵郷껹鏻都旿焁嬃䜅㬇㴉㰋㴍┏", a_)))
					{
						num = (short)999489545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_92D;
				case 23:
					this.radWideBluetoothAudioBackwardsCompatibility_A44942 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꧧ鿩裫蟭鿯냱闳闵鏷跹鷻賽擿焁䜃椅攇稉洋稍礏瀑紓稕焗渙攛䄝感ᘡဣἥᰧᠩ", a_), global::CommonResources.AcgResources.ID_BLUETOOTH_AUDIO_BACKWARDS_COMPATIBILITY);
					this.radWideBluetoothAudioBackwardsCompatibility_A44942.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideBluetoothAudioBackwardsCompatibility_A44942.DataTransferOrder = 235;
					num = (short)1309212700;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꧧ觩飫蟭蛯韱꛳ꗵ뗷돹鋻諽旿瀁樃朅搇䜉攋洍夏琑娓礕気堙栛匝䤟䄡笣朥ᰧᬩᤫ᤭د", a_)))
					{
						num = (short)1243349019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_197;
				case 25:
					goto IL_53A;
				case 26:
					goto IL_690;
				case 27:
					this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꧧ觩飫蟭蛯韱꛳ꗵ뗷돹鋻諽旿瀁樃朅搇䜉攋洍夏琑娓礕気堙栛匝䤟䄡笣朥ᰧᬩᤫ᤭د", a_), global::CommonResources.AcgResources.ID_ACTIVERSMINTERNALMICIFNOBLUETOOTHMIC);
					this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.DataTransferOrder = 215;
					num = (short)402456576;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					goto IL_CFE;
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꧧ鿩裫蟭鿯냱闳闵鏷跹鷻賽擿焁䜃椅攇稉洋稍礏瀑紓稕焗渙攛䄝感ᘡဣἥᰧᠩ", a_)))
					{
						num = (short)1551302679;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CFE;
				case 30:
					this.radWideBluetoothImproveAudioLatency_A44943 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꇧ蟩鳫鳭鿯蓱釳럵跷黹闻釽䳿持瀃挅昇椉甋儍儏☑–⼕Ⱇ⤙", a_), global::CommonResources.AcgResources.ID_BLUETOOTH_IMPROVE_AUDIO_LATENCY);
					this.radWideBluetoothImproveAudioLatency_A44943.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radWideBluetoothImproveAudioLatency_A44943.DataTransferOrder = 236;
					num = (short)168493081;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					goto IL_1E6;
				case 32:
					goto IL_632;
				case 33:
					goto IL_DA0;
				case 34:
					goto IL_E46;
				case 35:
				{
					this.radWideBluetoothLegacyBluetoothPINPairing = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꓧ迩诫迭鏯诱뛳髵跷鿹裻釽濿瘁氃嘅䄇䐉尋漍礏怑紓砕缗", a_), global::CommonResources.AcgResources.ID_LEGACY_BLUETOOTHPINPAIRING);
					this.radWideBluetoothLegacyBluetoothPINPairing.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideBluetoothLegacyBluetoothPINPairing.DataTransferOrder = 232;
					num = (short)360254723;
					short num4 = num;
					num = (short)1772096771;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_632;
					default:
						num = (short)365690880;
						if (num != 0)
						{
						}
						num = (short)365494331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 36:
					this.radWideBluetoothBluetoothReconnectTimer_A37037 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꫧ蛩駫语蓯鷱鯳苵郷꣹駻鷽濿氁樃挅欇縉堋服紏眑易䤕夗⤙⬛⸝ጟᔡ", a_), global::CommonResources.AcgResources.ID_BLUETOOTHREPAIRTIMER, global::CommonResources.AcgResources.ID_IMMEDIATE, null);
					this.radWideBluetoothBluetoothReconnectTimer_A37037.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideBluetoothBluetoothReconnectTimer_A37037.DataTransferOrder = 150;
					this.radWideBluetoothBluetoothReconnectTimer_A37037.AddCustomValue(255, global::CommonResources.AcgResources.ID_INFINITE);
					this.radWideBluetoothBluetoothReconnectTimer_A37037.ShowHexValue = false;
					num = (short)1141178394;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 37:
					goto IL_9C8;
				case 38:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꫧ蛩駫语蓯鷱鯳苵郷뿹鋻鿽拿渁愃夅䤇㤉㬋㸍∏⨑", a_)))
					{
						num = (short)439353387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DA0;
				case 39:
					this.radWideStandardNFCPairing_A44928 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓藕곗믙닛뫝臟郡胣꣥껧ꧩ볫迭駯胱鷳飵鿷ꗹ뷻쫽㓿㬁㘃㸅", a_), global::CommonResources.AcgResources.ID_STANDARD_NFC_PAIRING);
					this.radWideStandardNFCPairing_A44928.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideStandardNFCPairing_A44928.DataTransferOrder = 233;
					num = (short)1939996728;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 40:
					this.radWideMPPPairingOnlyWithLTE_A42320 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓鯕裗諙賛뿝觟郡跣裥迧ꗩ苫苭觯ꗱ鷳苵郷뛹ꣻ믽忿䌁〃㐅㬇㠉㰋", a_), global::CommonResources.AcgResources.ID_MPPPAIRINGONLYWITHLTE);
					this.radWideMPPPairingOnlyWithLTE_A42320.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideMPPPairingOnlyWithLTE_A42320.DataTransferOrder = -1;
					num = (short)1805910074;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 41:
					this.radWideBluetoothReplacePairingInfo_A41562 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥뫧迩鳫苭釯釱釳꛵駷鏹軻韽滿攁䴃栅渇攉匋伍␏⌑ℓ―⨗", a_), global::CommonResources.AcgResources.ID_BLUETOOTHREPLACEPAIRINGINFO);
					this.radWideBluetoothReplacePairingInfo_A41562.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideBluetoothReplacePairingInfo_A41562.DataTransferOrder = 210;
					num = (short)605880380;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 42:
					this.radWideBluetoothFriendlyNameEditable_A41182 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥껧飩藫语黯雱飳迵뛷鯹釻鯽䗿昁洃爅椇栉怋欍伏匑–✕⤗∙⸛", a_), global::CommonResources.AcgResources.ID_BLUETOOTHFRIENDLYNAMEEDITABLE);
					this.radWideBluetoothFriendlyNameEditable_A41182.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideBluetoothFriendlyNameEditable_A41182.DataTransferOrder = 152;
					num = (short)1322385410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 43:
					this.radWideBluetoothBluetoothEnable_A37028 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꫧ蛩駫语蓯鷱鯳苵郷뿹鋻鿽拿渁愃夅䤇㤉㬋㸍∏⨑", a_), global::CommonResources.AcgResources.ID_BLUETOOTHENABLE);
					this.radWideBluetoothBluetoothEnable_A37028.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideBluetoothBluetoothEnable_A37028.DataTransferOrder = 147;
					num = (short)1774518305;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 44:
					num = (short)1689387060;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 45:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꫧ蛩駫语蓯鷱鯳苵郷꣹駻鷽濿氁樃挅欇縉堋服紏眑易䤕夗⤙⬛⸝ጟᔡ", a_)))
					{
						num = (short)648675364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_690;
				case 46:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓藕곗믙닛뫝臟郡胣꣥껧ꧩ볫迭駯胱鷳飵鿷ꗹ뷻쫽㓿㬁㘃㸅", a_)))
					{
						num = (short)763756583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_97B;
				case 47:
					this.radWideBluetoothFriendlyName_A41181 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_APXRADIO, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥껧飩藫语黯雱飳迵뛷鯹釻鯽忿䌁〃㜅㤇㈉㴋", a_), global::CommonResources.AcgResources.ID_BLUETOOTHFRIENDLYNAME, 14);
					this.radWideBluetoothFriendlyName_A41181.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideBluetoothFriendlyName_A41181.DataTransferOrder = 153;
					num = (short)383844353;
					if (num != 0)
					{
					}
					num = (short)611188749;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 48:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꇧ蟩鳫鳭鿯蓱釳럵跷黹闻釽䳿持瀃挅昇椉甋儍儏☑–⼕Ⱇ⤙", a_)))
					{
						num = (short)175767582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EE9;
				case 49:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥껧飩藫语黯雱飳迵뛷鯹釻鯽䗿昁洃爅椇栉怋欍伏匑–✕⤗∙⸛", a_)))
					{
						num = (short)1554317354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AC0;
				case 50:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꫧ蛩駫语蓯鷱鯳苵郷꣹꿻돽䳿䜁䀃夅䤇㤉㬋㸍⌏⬑", a_)))
					{
						num = (short)1204617223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E6;
				case 51:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓铕듗꿙맛ꫝ迟跡郣軥ꫧ蛩駫语蓯鷱鯳苵郷꫹鷻韽狿欁樃愅將猉簋欍伏匑✓ℕ⠗⤙⨛", a_)))
					{
						num = (short)610664463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3F4;
				case 52:
					if (producerFields != null)
					{
						num = (short)1862598667;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EE9;
				case 53:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓鯕裗諙賛뿝觟郡跣裥迧ꗩ苫苭觯ꗱ鷳苵郷뛹ꣻ믽忿䌁〃㐅㬇㠉㰋", a_)))
					{
						num = (short)1040121896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_72C;
				case 54:
					switch (0)
					{
					case 0:
						goto IL_121;
					}
					continue;
				case 55:
					this.radWideSecureNFCPairing_A44931 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓藕뷗맙꧛곝藟곡ꋣꗥ룧诩藫鳭駯鳱鏳꧵맷컹죻쟽㏿㌁", a_), global::CommonResources.AcgResources.ID_SECURE_NFC_PAIRING);
					this.radWideSecureNFCPairing_A44931.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideSecureNFCPairing_A44931.DataTransferOrder = 234;
					num = (short)1884946446;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 56:
					goto IL_97B;
				case 57:
					goto IL_149;
				case 58:
					goto IL_72C;
				case 59:
					goto IL_340;
				case 60:
					goto IL_CB0;
				}
				IL_121:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)33488940;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_149:
				num = (short)1184104501;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_197:
				num = (short)1651245066;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E6:
				num = (short)1491206195;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_340:
				num = (short)476053533;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3F4:
				num = (short)2147090477;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_632:
				goto IL_3F4;
				IL_53F:
				num = (short)1046413361;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_690:
				num = (short)1364787205;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6DF:
				num = (short)1703936020;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_72C:
				num = (short)853671982;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_92D:
				num = (short)539164722;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_97B:
				num = (short)1483276292;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9C8:
				num = (short)765657104;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AC0:
				num = (short)1929773077;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B0E:
				num = (short)63242246;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CB0:
				num = (short)660930584;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CFE:
				num = (short)1245642800;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_DA0:
				num = (short)1152057366;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E46:
				num = (short)631701507;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_53A:
			IL_EE9:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("談ꛉ맋ꯍ꓏뷑믓ꋕ냗", a_);
			base.Id = 10630;
			base.UIName = global::CommonResources.AcgResources.ID_BLUETOOTH;
			base.DataTransferOrder = 15;
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x002AAE5C File Offset: 0x002A905C
		public override void PopulateReferences()
		{
			short num = (short)502328249;
			short num2 = num;
			num = (short)1913449401;
			switch (num2 == num)
			{
			}
			num = (short)113311744;
			short num3 = num;
			num = (short)1058209793;
			if (num != 0)
			{
			}
			num = (short)1622409216;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x002AAF08 File Offset: 0x002A9108
		public override void DropReferences()
		{
			short num = (short)112536320;
			short num2 = num;
			num = (short)1240607488;
			switch (num2 == num)
			{
			}
			num = (short)1659043840;
			short num3 = num;
			num = (short)315686913;
			if (num != 0)
			{
			}
			num = (short)1921908736;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x002AAFB4 File Offset: 0x002A91B4
		public override void SetConstraints()
		{
			short num = (short)1471622491;
			short num2 = num;
			num = (short)816262491;
			switch (num2 == num)
			{
			}
			num = (short)743702528;
			short num3 = num;
			num = (short)1917517824;
			if (num != 0)
			{
			}
			num = (short)1945632769;
			if (num != 0)
			{
			}
			this.radWideBluetoothBluetoothTones_A37035.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConBluetoothEnableIsEnabled);
			this.radWideBluetoothBluetoothPairingType_A37036.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConBluetoothEnableIsEnabled);
			this.radWideStandardNFCPairing_A44928.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConBluetoothEnableIsEnabled);
			this.radWideStandardNFCPairing_A44928.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideSecureNFCPairing_A44931.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConBluetoothEnableIsEnabled);
			this.radWideSecureNFCPairing_A44931.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideBluetoothBluetoothReconnectTimer_A37037.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConBluetoothEnableIsEnabled);
			this.radWideBluetoothBluetoothDropTimer_A37038.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConBluetoothEnableIsEnabled);
			this.radWideBluetoothBluetoothRSMLED_A37039.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConBluetoothEnableIsEnabled);
			this.radWideBluetoothBluetoothRSMLED_A37039.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsValidRSMBluetoothNfpaCompliant);
			this.radWideBluetoothBluetoothDropTimer_A37038.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConValidateBluetoothDropTimer);
			this.radWideBluetoothFriendlyName_A41181.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConBluetoothEnableIsEnabled);
			this.radWideBluetoothFriendlyName_A41181.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConInvisibleWhenOpenfromRMC);
			this.radWideBluetoothFriendlyName_A41181.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conNonEditableWhenOpenFromRMC);
			this.radWideBluetoothFriendlyNameEditable_A41182.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConBluetoothEnableIsEnabled);
			this.radWideBluetoothReplacePairingInfo_A41562.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConBluetoothReplacePairingInfoIsApp);
			this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConBluetoothEnableIsEnabled);
			this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConLegacyActiveRSMInternalMicVisible);
			this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConSyncOldToActiveMicforBTPTT);
			this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConBluetoothPANCOTSEnableIsEnabled);
			this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConBluetoothPANCOTSEnableIsEnabled);
			this.radWideBluetoothBluetoothPANNetworkAddress_41983.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConBluetoothEnableIsEnabled);
			this.radWideBluetoothBluetoothPANNetworkAddress_41983.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConBluetoothPANNetworkBaseAddressValidity);
			this.radWideMPPPairingOnlyWithLTE_A42320.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConBluetoothEnableIsEnabled);
			this.radWideMPPPairingOnlyWithLTE_A42320.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideBluetoothLegacyBluetoothPINPairing.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConBluetoothPANCOTSEnableIsEnabled);
			this.radWideBluetoothAudioBackwardsCompatibility_A44942.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConBluetoothEnableIsEnabled);
			this.radWideBluetoothAudioBackwardsCompatibility_A44942.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideBluetoothImproveAudioLatency_A44943.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConBluetoothEnableIsEnabled);
			this.radWideBluetoothImproveAudioLatency_A44943.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x002AB310 File Offset: 0x002A9510
		public override void SetupDependencies()
		{
			short num = (short)1436598584;
			short num2 = num;
			num = (short)2144387384;
			switch (num2 == num)
			{
			}
			num = (short)1996685312;
			short num3 = num;
			num = (short)284360705;
			if (num != 0)
			{
			}
			num = (short)1813053440;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			this.radWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.radWideBluetoothBluetoothTones_A37035);
			this.radWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.radWideBluetoothBluetoothPairingType_A37036);
			this.radWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.radWideStandardNFCPairing_A44928);
			this.radWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.radWideSecureNFCPairing_A44931);
			this.radWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.radWideBluetoothBluetoothReconnectTimer_A37037);
			this.radWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.radWideBluetoothBluetoothDropTimer_A37038);
			this.radWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.radWideBluetoothFriendlyName_A41181);
			this.radWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.radWideBluetoothFriendlyNameEditable_A41182);
			this.radWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.radWideBluetoothReplacePairingInfo_A41562);
			this.radWideBluetoothBluetoothReconnectTimer_A37037.AddDependentObject(this.radWideBluetoothReplacePairingInfo_A41562);
			this.radWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576);
			radioWide.Labtool.RadWideLabtoolActiveMicForBTPTTCapable_43053.AddDependentObject(this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576);
			this.radWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.radWideBluetoothBluetoothDeviceInquiryDuration_41977);
			this.radWideBluetoothBluetoothPairingType_A37036.AddDependentObject(this.radWideBluetoothBluetoothDeviceInquiryDuration_41977);
			this.radWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980);
			this.radWideBluetoothBluetoothPairingType_A37036.AddDependentObject(this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980);
			this.radWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.radWideBluetoothBluetoothPANNetworkAddress_41983);
			radioWide.Features.RadWideFeaturesZoneCloneEnable_43130.AddDependentObject(this.radWideBluetoothBluetoothPANNetworkAddress_41983);
			this.radWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.radWideMPPPairingOnlyWithLTE_A42320);
			this.radWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.radWideBluetoothAudioBackwardsCompatibility_A44942);
			this.radWideBluetoothBluetoothEnable_A37028.AddDependentObject(this.radWideBluetoothImproveAudioLatency_A44943);
		}

		// Token: 0x1700161A RID: 5658
		// (get) Token: 0x06002C11 RID: 11281 RVA: 0x002AB548 File Offset: 0x002A9748
		public bool HasDiffs
		{
			get
			{
				short num = (short)701158476;
				short num2 = num;
				num = (short)1719129164;
				switch (num2 == num)
				{
				}
				num = (short)523894784;
				short num3 = num;
				num = (short)1216937985;
				if (num != 0)
				{
				}
				num = (short)579928064;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x06002C12 RID: 11282 RVA: 0x002AB5F8 File Offset: 0x002A97F8
		// (set) Token: 0x06002C13 RID: 11283 RVA: 0x002AB6B0 File Offset: 0x002A98B0
		public bool RadWideBluetoothBluetoothEnable_A37028Value
		{
			get
			{
				short num = (short)2134143699;
				short num2 = num;
				num = (short)995193555;
				switch (num2 == num)
				{
				}
				num = (short)1474756608;
				short num3 = num;
				num = (short)1239482369;
				if (num != 0)
				{
				}
				num = (short)1904017408;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothEnable_A37028.Value;
			}
			set
			{
				short num = (short)1078137826;
				short num2 = num;
				num = (short)1713378274;
				switch (num2 == num)
				{
				}
				num = (short)1674117120;
				short num3 = num;
				num = (short)1437138944;
				if (num != 0)
				{
				}
				num = (short)1662189569;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothEnable_A37028.Value = value;
			}
		}

		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x06002C14 RID: 11284 RVA: 0x002AB764 File Offset: 0x002A9964
		public global::AcpBusinessLayer.AcpField<bool> RadWideBluetoothBluetoothEnable_A37028
		{
			get
			{
				short num = (short)1414987777;
				if (num != 0)
				{
				}
				num = (short)1544577629;
				short num2 = num;
				num = (short)1189700189;
				switch (num2 == num)
				{
				default:
				{
					num = (short)825819136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)515768320;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothEnable_A37028;
			}
		}

		// Token: 0x1700161D RID: 5661
		// (get) Token: 0x06002C15 RID: 11285 RVA: 0x002AB814 File Offset: 0x002A9A14
		// (set) Token: 0x06002C16 RID: 11286 RVA: 0x002AB8CC File Offset: 0x002A9ACC
		public bool RadWideBluetoothBluetoothEnable_A37028_UIValue
		{
			get
			{
				short num = (short)451693635;
				short num2 = num;
				num = (short)310529091;
				switch (num2 == num)
				{
				}
				num = (short)591986688;
				short num3 = num;
				num = (short)1587740672;
				if (num != 0)
				{
				}
				num = (short)1774977025;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothEnable_A37028.Value;
			}
			set
			{
				short num = (short)1086934162;
				short num2 = num;
				num = (short)639519890;
				switch (num2 == num)
				{
				}
				num = (short)2090401792;
				short num3 = num;
				num = (short)678690817;
				if (num != 0)
				{
				}
				num = (short)2012479488;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothEnable_A37028.Value = value;
			}
		}

		// Token: 0x1700161E RID: 5662
		// (get) Token: 0x06002C17 RID: 11287 RVA: 0x002AB984 File Offset: 0x002A9B84
		// (set) Token: 0x06002C18 RID: 11288 RVA: 0x002ABA38 File Offset: 0x002A9C38
		public bool RadWideBluetoothBluetoothEnable_A37028_Applicable
		{
			get
			{
				short num = (short)1297362572;
				short num2 = num;
				num = (short)2075733644;
				switch (num2 == num)
				{
				}
				num = (short)2621440;
				short num3 = num;
				num = (short)896532481;
				if (num != 0)
				{
				}
				num = (short)524550144;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothEnable_A37028.Applicable;
			}
			set
			{
				short num = (short)1092361735;
				short num2 = num;
				num = (short)475799047;
				switch (num2 == num)
				{
				}
				num = (short)604241920;
				short num3 = num;
				num = (short)1542455296;
				if (num != 0)
				{
				}
				num = (short)740098049;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothEnable_A37028.Applicable = value;
			}
		}

		// Token: 0x1700161F RID: 5663
		// (get) Token: 0x06002C19 RID: 11289 RVA: 0x002ABAEC File Offset: 0x002A9CEC
		// (set) Token: 0x06002C1A RID: 11290 RVA: 0x002ABBA0 File Offset: 0x002A9DA0
		public bool RadWideBluetoothBluetoothEnable_A37028_Valid
		{
			get
			{
				short num = (short)1525895103;
				short num2 = num;
				num = (short)1530548159;
				switch (num2 == num)
				{
				}
				num = (short)1604517888;
				short num3 = num;
				num = (short)1371471872;
				if (num != 0)
				{
				}
				num = (short)210567169;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothEnable_A37028.Valid;
			}
			set
			{
				short num = (short)1071859000;
				short num2 = num;
				num = (short)1652704568;
				switch (num2 == num)
				{
				}
				num = (short)1235877888;
				short num3 = num;
				num = (short)824573953;
				if (num != 0)
				{
				}
				num = (short)375062528;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothEnable_A37028.Valid = value;
			}
		}

		// Token: 0x17001620 RID: 5664
		// (get) Token: 0x06002C1B RID: 11291 RVA: 0x002ABC54 File Offset: 0x002A9E54
		// (set) Token: 0x06002C1C RID: 11292 RVA: 0x002ABD0C File Offset: 0x002A9F0C
		public bool RadWideBluetoothBluetoothEnable_A37028_Visible
		{
			get
			{
				short num = (short)893927807;
				short num2 = num;
				num = (short)2068070783;
				switch (num2 == num)
				{
				}
				num = (short)410910720;
				short num3 = num;
				num = (short)1781268480;
				if (num != 0)
				{
				}
				num = (short)226426881;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothEnable_A37028.Visible;
			}
			set
			{
				short num = (short)796167743;
				short num2 = num;
				num = (short)1335004735;
				switch (num2 == num)
				{
				}
				num = (short)1164312576;
				short num3 = num;
				num = (short)2133458945;
				if (num != 0)
				{
				}
				num = (short)1866596352;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothEnable_A37028.Visible = value;
			}
		}

		// Token: 0x17001621 RID: 5665
		// (get) Token: 0x06002C1D RID: 11293 RVA: 0x002ABDBC File Offset: 0x002A9FBC
		// (set) Token: 0x06002C1E RID: 11294 RVA: 0x002ABE70 File Offset: 0x002AA070
		public bool RadWideBluetoothBluetoothEnable_A37028_Editable
		{
			get
			{
				short num = (short)99431721;
				short num2 = num;
				num = (short)991114537;
				switch (num2 == num)
				{
				}
				num = (short)1063124992;
				short num3 = num;
				num = (short)1025179649;
				if (num != 0)
				{
				}
				num = (short)1603338240;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothEnable_A37028.Editable;
			}
			set
			{
				short num = (short)431589480;
				short num2 = num;
				num = (short)630098024;
				switch (num2 == num)
				{
				}
				num = (short)15532032;
				short num3 = num;
				num = (short)299368449;
				if (num != 0)
				{
				}
				num = (short)1609957376;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothEnable_A37028.Editable = value;
			}
		}

		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x06002C1F RID: 11295 RVA: 0x002ABF28 File Offset: 0x002AA128
		internal string RadWideBluetoothBluetoothEnable_A37028_UILabel
		{
			get
			{
				short num = (short)898973720;
				short num2 = num;
				num = (short)1425621016;
				switch (num2 == num)
				{
				}
				num = (short)207683584;
				short num3 = num;
				num = (short)84541440;
				if (num != 0)
				{
				}
				num = (short)1479802881;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothEnable_A37028.UIName;
			}
		}

		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x06002C20 RID: 11296 RVA: 0x002ABFDC File Offset: 0x002AA1DC
		// (set) Token: 0x06002C21 RID: 11297 RVA: 0x002AC094 File Offset: 0x002AA294
		internal bool RadWideBluetoothBluetoothEnable_A37028_HiddenStatic
		{
			get
			{
				short num = (short)1826323428;
				short num2 = num;
				num = (short)975272932;
				switch (num2 == num)
				{
				}
				num = (short)2027225088;
				short num3 = num;
				num = (short)478150657;
				if (num != 0)
				{
				}
				num = (short)809762816;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothEnable_A37028.HiddenStatic;
			}
			set
			{
				short num = (short)1171002916;
				short num2 = num;
				num = (short)1087903268;
				switch (num2 == num)
				{
				}
				num = (short)1394540544;
				short num3 = num;
				num = (short)1274937345;
				if (num != 0)
				{
				}
				num = (short)1357512704;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothEnable_A37028.HiddenStatic = value;
			}
		}

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x06002C22 RID: 11298 RVA: 0x002AC148 File Offset: 0x002AA348
		// (set) Token: 0x06002C23 RID: 11299 RVA: 0x002AC1FC File Offset: 0x002AA3FC
		internal bool RadWideBluetoothBluetoothEnable_A37028_HiddenDynamic
		{
			get
			{
				short num = (short)1937012897;
				short num2 = num;
				num = (short)1219786913;
				switch (num2 == num)
				{
				}
				num = (short)428343296;
				short num3 = num;
				num = (short)1785266177;
				if (num != 0)
				{
				}
				num = (short)544866304;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothEnable_A37028.HiddenDynamic;
			}
			set
			{
				short num = (short)940421560;
				short num2 = num;
				num = (short)1048818104;
				switch (num2 == num)
				{
				}
				num = (short)1500643328;
				short num3 = num;
				num = (short)757202945;
				if (num != 0)
				{
				}
				num = (short)1460862976;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothEnable_A37028.HiddenDynamic = value;
			}
		}

		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x06002C24 RID: 11300 RVA: 0x002AC2B0 File Offset: 0x002AA4B0
		public bool RadWideBluetoothBluetoothEnable_A37028_HasDiffs
		{
			get
			{
				short num = (short)1868824577;
				if (num != 0)
				{
				}
				num = (short)188805539;
				short num2 = num;
				num = (short)1892807075;
				switch (num2 == num)
				{
				default:
				{
					num = (short)447021056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2035023872;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothEnable_A37028._HasDiffs;
			}
		}

		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x06002C25 RID: 11301 RVA: 0x002AC364 File Offset: 0x002AA564
		// (set) Token: 0x06002C26 RID: 11302 RVA: 0x002AC418 File Offset: 0x002AA618
		public bool RadWideBluetoothBluetoothTones_A37035Value
		{
			get
			{
				short num = (short)1851988359;
				short num2 = num;
				num = (short)130554247;
				switch (num2 == num)
				{
				}
				num = (short)2009006080;
				short num3 = num;
				num = (short)1797586944;
				if (num != 0)
				{
				}
				num = (short)2018902017;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothTones_A37035.Value;
			}
			set
			{
				short num = (short)1454768129;
				if (num != 0)
				{
				}
				num = (short)1156859804;
				short num2 = num;
				num = (short)2048870300;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1728577536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1968766976;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothTones_A37035.Value = value;
			}
		}

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x06002C27 RID: 11303 RVA: 0x002AC4CC File Offset: 0x002AA6CC
		public global::AcpBusinessLayer.AcpField<bool> RadWideBluetoothBluetoothTones_A37035
		{
			get
			{
				short num = (short)1122884640;
				short num2 = num;
				num = (short)69852192;
				switch (num2 == num)
				{
				}
				num = (short)228851712;
				short num3 = num;
				num = (short)2083586049;
				if (num != 0)
				{
				}
				num = (short)4259840;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothTones_A37035;
			}
		}

		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x06002C28 RID: 11304 RVA: 0x002AC578 File Offset: 0x002AA778
		// (set) Token: 0x06002C29 RID: 11305 RVA: 0x002AC630 File Offset: 0x002AA830
		public bool RadWideBluetoothBluetoothTones_A37035_UIValue
		{
			get
			{
				short num = (short)2075590657;
				if (num != 0)
				{
				}
				num = (short)768836375;
				short num2 = num;
				num = (short)1661240087;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1667825664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1690894336;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothTones_A37035.Value;
			}
			set
			{
				short num = (short)215412676;
				short num2 = num;
				num = (short)435417028;
				switch (num2 == num)
				{
				}
				num = (short)580059136;
				short num3 = num;
				num = (short)1734148096;
				if (num != 0)
				{
				}
				num = (short)692125697;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothTones_A37035.Value = value;
			}
		}

		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x06002C2A RID: 11306 RVA: 0x002AC6E4 File Offset: 0x002AA8E4
		// (set) Token: 0x06002C2B RID: 11307 RVA: 0x002AC79C File Offset: 0x002AA99C
		public bool RadWideBluetoothBluetoothTones_A37035_Applicable
		{
			get
			{
				short num = (short)1071392810;
				short num2 = num;
				num = (short)305211434;
				switch (num2 == num)
				{
				}
				num = (short)375914496;
				short num3 = num;
				num = (short)1849163776;
				if (num != 0)
				{
				}
				num = (short)1918631937;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothTones_A37035.Applicable;
			}
			set
			{
				short num = (short)1008664576;
				short num2 = num;
				num = (short)2109649552;
				short num3 = num;
				num = (short)1404416656;
				switch (num3 == num)
				{
				}
				num = (short)348389377;
				if (num != 0)
				{
				}
				num = (short)884670464;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothTones_A37035.Applicable = value;
			}
		}

		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x06002C2C RID: 11308 RVA: 0x002AC850 File Offset: 0x002AAA50
		// (set) Token: 0x06002C2D RID: 11309 RVA: 0x002AC904 File Offset: 0x002AAB04
		public bool RadWideBluetoothBluetoothTones_A37035_Valid
		{
			get
			{
				short num = (short)2020212736;
				short num2 = num;
				num = (short)1434657707;
				short num3 = num;
				num = (short)1386226603;
				switch (num3 == num)
				{
				}
				num = (short)1266941953;
				if (num != 0)
				{
				}
				num = (short)665649152;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothTones_A37035.Valid;
			}
			set
			{
				short num = (short)1443168256;
				short num2 = num;
				num = (short)1500061374;
				short num3 = num;
				num = (short)1146560190;
				switch (num3 == num)
				{
				}
				num = (short)1750335489;
				if (num != 0)
				{
				}
				num = (short)492109824;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothTones_A37035.Valid = value;
			}
		}

		// Token: 0x1700162B RID: 5675
		// (get) Token: 0x06002C2E RID: 11310 RVA: 0x002AC9BC File Offset: 0x002AABBC
		// (set) Token: 0x06002C2F RID: 11311 RVA: 0x002ACA70 File Offset: 0x002AAC70
		public bool RadWideBluetoothBluetoothTones_A37035_Visible
		{
			get
			{
				short num = (short)1333460992;
				short num2 = num;
				num = (short)394681861;
				short num3 = num;
				num = (short)1383161349;
				switch (num3 == num)
				{
				}
				num = (short)475856897;
				if (num != 0)
				{
				}
				num = (short)1038352384;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothTones_A37035.Visible;
			}
			set
			{
				short num = (short)371392512;
				short num2 = num;
				num = (short)635268069;
				short num3 = num;
				num = (short)1063349221;
				switch (num3 == num)
				{
				}
				num = (short)2031353857;
				if (num != 0)
				{
				}
				num = (short)836894720;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothTones_A37035.Visible = value;
			}
		}

		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x06002C30 RID: 11312 RVA: 0x002ACB24 File Offset: 0x002AAD24
		// (set) Token: 0x06002C31 RID: 11313 RVA: 0x002ACBD8 File Offset: 0x002AADD8
		public bool RadWideBluetoothBluetoothTones_A37035_Editable
		{
			get
			{
				short num = (short)6553600;
				short num2 = num;
				num = (short)185274648;
				short num3 = num;
				num = (short)1395462424;
				switch (num3 == num)
				{
				}
				num = (short)1143144448;
				if (num != 0)
				{
				}
				num = (short)1170931713;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothTones_A37035.Editable;
			}
			set
			{
				short num = (short)2131165184;
				short num2 = num;
				num = (short)1632905354;
				short num3 = num;
				num = (short)2101094538;
				switch (num3 == num)
				{
				}
				num = (short)842072064;
				if (num != 0)
				{
				}
				num = (short)1349058561;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothTones_A37035.Editable = value;
			}
		}

		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x06002C32 RID: 11314 RVA: 0x002ACC8C File Offset: 0x002AAE8C
		internal string RadWideBluetoothBluetoothTones_A37035_UILabel
		{
			get
			{
				short num = (short)1032716288;
				short num2 = num;
				num = (short)1806499841;
				if (num != 0)
				{
				}
				num = (short)197125257;
				short num3 = num;
				num = (short)572449929;
				switch (num3 == num)
				{
				}
				num = (short)619708416;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothTones_A37035.UIName;
			}
		}

		// Token: 0x1700162E RID: 5678
		// (get) Token: 0x06002C33 RID: 11315 RVA: 0x002ACD44 File Offset: 0x002AAF44
		// (set) Token: 0x06002C34 RID: 11316 RVA: 0x002ACDF8 File Offset: 0x002AAFF8
		internal bool RadWideBluetoothBluetoothTones_A37035_HiddenStatic
		{
			get
			{
				short num = (short)691732480;
				short num2 = num;
				num = (short)1522903665;
				short num3 = num;
				num = (short)1255582321;
				switch (num3 == num)
				{
				}
				num = (short)1750466561;
				if (num != 0)
				{
				}
				num = (short)795344896;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothTones_A37035.HiddenStatic;
			}
			set
			{
				short num = (short)938606592;
				short num2 = num;
				num = (short)791903295;
				short num3 = num;
				num = (short)23166015;
				switch (num3 == num)
				{
				}
				num = (short)524550145;
				if (num != 0)
				{
				}
				num = (short)1391984640;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothTones_A37035.HiddenStatic = value;
			}
		}

		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x06002C35 RID: 11317 RVA: 0x002ACEAC File Offset: 0x002AB0AC
		// (set) Token: 0x06002C36 RID: 11318 RVA: 0x002ACF60 File Offset: 0x002AB160
		internal bool RadWideBluetoothBluetoothTones_A37035_HiddenDynamic
		{
			get
			{
				short num = (short)581238784;
				short num2 = num;
				num = (short)2110913906;
				short num3 = num;
				num = (short)1759772018;
				switch (num3 == num)
				{
				}
				num = (short)1357643776;
				if (num != 0)
				{
				}
				num = (short)920518657;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothTones_A37035.HiddenDynamic;
			}
			set
			{
				short num = (short)310968320;
				short num2 = num;
				num = (short)1239113492;
				short num3 = num;
				num = (short)2120376084;
				switch (num3 == num)
				{
				}
				num = (short)695730176;
				if (num != 0)
				{
				}
				num = (short)1844248577;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothTones_A37035.HiddenDynamic = value;
			}
		}

		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x06002C37 RID: 11319 RVA: 0x002AD014 File Offset: 0x002AB214
		public bool RadWideBluetoothBluetoothTones_A37035_HasDiffs
		{
			get
			{
				short num = (short)641859584;
				short num2 = num;
				num = (short)85065729;
				if (num != 0)
				{
				}
				num = (short)1456902496;
				short num3 = num;
				num = (short)938643808;
				switch (num3 == num)
				{
				}
				num = (short)1959526400;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothTones_A37035._HasDiffs;
			}
		}

		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x06002C38 RID: 11320 RVA: 0x002AD0CC File Offset: 0x002AB2CC
		// (set) Token: 0x06002C39 RID: 11321 RVA: 0x002AD180 File Offset: 0x002AB380
		public bool RadWideBluetoothBluetoothRSMLED_A37039Value
		{
			get
			{
				short num = (short)502136832;
				short num2 = num;
				num = (short)1998547735;
				short num3 = num;
				num = (short)1276865303;
				switch (num3 == num)
				{
				}
				num = (short)2002649088;
				if (num != 0)
				{
				}
				num = (short)868483073;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothRSMLED_A37039.Value;
			}
			set
			{
				short num = (short)1678180352;
				short num2 = num;
				num = (short)1236340771;
				short num3 = num;
				num = (short)664670243;
				switch (num3 == num)
				{
				}
				num = (short)870449153;
				if (num != 0)
				{
				}
				num = (short)1353908224;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothRSMLED_A37039.Value = value;
			}
		}

		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x06002C3A RID: 11322 RVA: 0x002AD23C File Offset: 0x002AB43C
		public global::AcpBusinessLayer.AcpField<bool> RadWideBluetoothBluetoothRSMLED_A37039
		{
			get
			{
				short num = (short)863698944;
				short num2 = num;
				num = (short)445980366;
				short num3 = num;
				num = (short)1018109646;
				switch (num3 == num)
				{
				}
				num = (short)1789263873;
				if (num != 0)
				{
				}
				num = (short)1572798464;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothRSMLED_A37039;
			}
		}

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x06002C3B RID: 11323 RVA: 0x002AD2E8 File Offset: 0x002AB4E8
		// (set) Token: 0x06002C3C RID: 11324 RVA: 0x002AD398 File Offset: 0x002AB598
		public bool radWideBluetoothBluetoothRSMLED_A37039_UIValue
		{
			get
			{
				short num = (short)900988928;
				short num2 = num;
				num = (short)851786060;
				short num3 = num;
				num = (short)1506490700;
				switch (num3 == num)
				{
				}
				num = (short)1018691584;
				if (num != 0)
				{
				}
				num = (short)792199169;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothRSMLED_A37039.Value;
			}
			set
			{
				short num = (short)470482944;
				short num2 = num;
				num = (short)771230040;
				short num3 = num;
				num = (short)222955864;
				switch (num3 == num)
				{
				}
				num = (short)473759745;
				if (num != 0)
				{
				}
				num = (short)40960000;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothRSMLED_A37039.Value = value;
			}
		}

		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x06002C3D RID: 11325 RVA: 0x002AD44C File Offset: 0x002AB64C
		// (set) Token: 0x06002C3E RID: 11326 RVA: 0x002AD500 File Offset: 0x002AB700
		public bool RadWideBluetoothBluetoothRSMLED_A37039_Applicable
		{
			get
			{
				short num = (short)1744961536;
				short num2 = num;
				num = (short)379179600;
				short num3 = num;
				num = (short)2084622928;
				switch (num3 == num)
				{
				}
				num = (short)966852608;
				if (num != 0)
				{
				}
				num = (short)35389441;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothRSMLED_A37039.Applicable;
			}
			set
			{
				short num = (short)1606090752;
				short num2 = num;
				num = (short)15008623;
				short num3 = num;
				num = (short)1461060463;
				switch (num3 == num)
				{
				}
				num = (short)992542721;
				if (num != 0)
				{
				}
				num = (short)116981760;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothRSMLED_A37039.Applicable = value;
			}
		}

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x06002C3F RID: 11327 RVA: 0x002AD5B4 File Offset: 0x002AB7B4
		// (set) Token: 0x06002C40 RID: 11328 RVA: 0x002AD668 File Offset: 0x002AB868
		public bool RadWideBluetoothBluetoothRSMLED_A37039_Valid
		{
			get
			{
				short num = (short)1243807744;
				short num2 = num;
				num = (short)794708465;
				short num3 = num;
				num = (short)1115703793;
				switch (num3 == num)
				{
				}
				num = (short)223870977;
				if (num != 0)
				{
				}
				num = (short)1606352896;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothRSMLED_A37039.Valid;
			}
			set
			{
				short num = (short)1205469184;
				short num2 = num;
				num = (short)345574855;
				short num3 = num;
				num = (short)674893255;
				switch (num3 == num)
				{
				}
				num = (short)913113089;
				if (num != 0)
				{
				}
				num = (short)1834876928;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothRSMLED_A37039.Valid = value;
			}
		}

		// Token: 0x17001636 RID: 5686
		// (get) Token: 0x06002C41 RID: 11329 RVA: 0x002AD71C File Offset: 0x002AB91C
		// (set) Token: 0x06002C42 RID: 11330 RVA: 0x002AD7D0 File Offset: 0x002AB9D0
		public bool RadWideBluetoothBluetoothRSMLED_A37039_Visible
		{
			get
			{
				short num = (short)1930952704;
				short num2 = num;
				num = (short)1413815696;
				short num3 = num;
				num = (short)1113070992;
				switch (num3 == num)
				{
				}
				num = (short)1244856321;
				if (num != 0)
				{
				}
				num = (short)569507840;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothRSMLED_A37039.Visible;
			}
			set
			{
				short num = (short)761528320;
				short num2 = num;
				num = (short)1288723875;
				short num3 = num;
				num = (short)1247436195;
				switch (num3 == num)
				{
				}
				num = (short)1408827393;
				if (num != 0)
				{
				}
				num = (short)197656576;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothRSMLED_A37039.Visible = value;
			}
		}

		// Token: 0x17001637 RID: 5687
		// (get) Token: 0x06002C43 RID: 11331 RVA: 0x002AD888 File Offset: 0x002ABA88
		// (set) Token: 0x06002C44 RID: 11332 RVA: 0x002AD93C File Offset: 0x002ABB3C
		public bool RadWideBluetoothBluetoothRSMLED_A37039_Editable
		{
			get
			{
				short num = (short)990707712;
				short num2 = num;
				num = (short)460322527;
				short num3 = num;
				num = (short)386660063;
				switch (num3 == num)
				{
				}
				num = (short)1429274625;
				if (num != 0)
				{
				}
				num = (short)661127168;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothRSMLED_A37039.Editable;
			}
			set
			{
				short num = (short)682033152;
				short num2 = num;
				num = (short)1755476760;
				short num3 = num;
				num = (short)1665626904;
				switch (num3 == num)
				{
				}
				num = (short)2121531393;
				if (num != 0)
				{
				}
				num = (short)1796276224;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothRSMLED_A37039.Editable = value;
			}
		}

		// Token: 0x17001638 RID: 5688
		// (get) Token: 0x06002C45 RID: 11333 RVA: 0x002AD9F0 File Offset: 0x002ABBF0
		internal string RadWideBluetoothBluetoothRSMLED_A37039_UILabel
		{
			get
			{
				short num = (short)221970432;
				short num2 = num;
				num = (short)34240840;
				short num3 = num;
				num = (short)90208584;
				switch (num3 == num)
				{
				}
				num = (short)93126656;
				if (num != 0)
				{
				}
				num = (short)488570881;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothRSMLED_A37039.UIName;
			}
		}

		// Token: 0x17001639 RID: 5689
		// (get) Token: 0x06002C46 RID: 11334 RVA: 0x002ADAA4 File Offset: 0x002ABCA4
		// (set) Token: 0x06002C47 RID: 11335 RVA: 0x002ADB58 File Offset: 0x002ABD58
		internal bool RadWideBluetoothBluetoothRSMLED_A37039_HiddenStatic
		{
			get
			{
				short num = (short)1666580480;
				short num2 = num;
				num = (short)512048056;
				short num3 = num;
				num = (short)76037048;
				switch (num3 == num)
				{
				}
				num = (short)58392577;
				if (num != 0)
				{
				}
				num = (short)1571553280;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothRSMLED_A37039.HiddenStatic;
			}
			set
			{
				short num = (short)476184576;
				short num2 = num;
				num = (short)2139793328;
				short num3 = num;
				num = (short)22718384;
				switch (num3 == num)
				{
				}
				num = (short)670236673;
				if (num != 0)
				{
				}
				num = (short)1631518720;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothRSMLED_A37039.HiddenStatic = value;
			}
		}

		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x06002C48 RID: 11336 RVA: 0x002ADC10 File Offset: 0x002ABE10
		// (set) Token: 0x06002C49 RID: 11337 RVA: 0x002ADCC8 File Offset: 0x002ABEC8
		internal bool RadWideBluetoothBluetoothRSMLED_A37039_HiddenDynamic
		{
			get
			{
				short num = (short)291700736;
				short num2 = num;
				num = (short)1478659248;
				short num3 = num;
				num = (short)1393069232;
				switch (num3 == num)
				{
				}
				num = (short)1731395585;
				if (num != 0)
				{
				}
				num = (short)528547840;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothRSMLED_A37039.HiddenDynamic;
			}
			set
			{
				short num = (short)1499201536;
				short num2 = num;
				num = (short)1547802290;
				short num3 = num;
				num = (short)648976050;
				switch (num3 == num)
				{
				}
				num = (short)2001600513;
				if (num != 0)
				{
				}
				num = (short)88801280;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothRSMLED_A37039.HiddenDynamic = value;
			}
		}

		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x06002C4A RID: 11338 RVA: 0x002ADD80 File Offset: 0x002ABF80
		public bool RadWideBluetoothBluetoothRSMLED_A37039_HasDiffs
		{
			get
			{
				short num = (short)1436942336;
				short num2 = num;
				num = (short)221286603;
				short num3 = num;
				num = (short)1937412299;
				switch (num3 == num)
				{
				}
				num = (short)1511718912;
				if (num != 0)
				{
				}
				num = (short)1192558593;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothRSMLED_A37039._HasDiffs;
			}
		}

		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x06002C4B RID: 11339 RVA: 0x002ADE38 File Offset: 0x002AC038
		// (set) Token: 0x06002C4C RID: 11340 RVA: 0x002ADEEC File Offset: 0x002AC0EC
		public int RadWideBluetoothBluetoothPairingType_A37036Value
		{
			get
			{
				short num = (short)855048192;
				short num2 = num;
				num = (short)980316825;
				short num3 = num;
				num = (short)992178841;
				switch (num3 == num)
				{
				}
				num = (short)1639186433;
				if (num != 0)
				{
				}
				num = (short)1650130944;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothPairingType_A37036.Value;
			}
			set
			{
				short num = (short)1295712256;
				short num2 = num;
				num = (short)1239089153;
				if (num != 0)
				{
				}
				num = (short)62465049;
				short num3 = num;
				num = (short)1448616985;
				switch (num3 == num)
				{
				}
				num = (short)63832064;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothPairingType_A37036.Value = value;
			}
		}

		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x06002C4D RID: 11341 RVA: 0x002ADFA0 File Offset: 0x002AC1A0
		// (set) Token: 0x06002C4E RID: 11342 RVA: 0x002AE054 File Offset: 0x002AC254
		public string RadWideBluetoothBluetoothPairingType_A37036_UIValue
		{
			get
			{
				short num = (short)782893056;
				short num2 = num;
				num = (short)883137025;
				short num3 = num;
				num = (short)1370331649;
				switch (num3 == num)
				{
				}
				num = (short)1185742849;
				if (num != 0)
				{
				}
				num = (short)353435648;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothPairingType_A37036.UIValue;
			}
			set
			{
				short num = (short)1889665024;
				short num2 = num;
				num = (short)1969687264;
				short num3 = num;
				num = (short)105056992;
				switch (num3 == num)
				{
				}
				num = (short)1465581568;
				if (num != 0)
				{
				}
				num = (short)1331953665;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothPairingType_A37036.UIValue = value;
			}
		}

		// Token: 0x1700163E RID: 5694
		// (get) Token: 0x06002C4F RID: 11343 RVA: 0x002AE10C File Offset: 0x002AC30C
		public global::AcpBusinessLayer.AcpListField RadWideBluetoothBluetoothPairingType_A37036
		{
			get
			{
				short num = (short)313065472;
				short num2 = num;
				num = (short)570031944;
				short num3 = num;
				num = (short)671285064;
				switch (num3 == num)
				{
				}
				num = (short)1012203521;
				if (num != 0)
				{
				}
				num = (short)761397248;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothPairingType_A37036;
			}
		}

		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x06002C50 RID: 11344 RVA: 0x002AE1BC File Offset: 0x002AC3BC
		// (set) Token: 0x06002C51 RID: 11345 RVA: 0x002AE270 File Offset: 0x002AC470
		public bool RadWideBluetoothBluetoothPairingType_A37036_Applicable
		{
			get
			{
				short num = (short)963969024;
				short num2 = num;
				num = (short)59699642;
				short num3 = num;
				num = (short)1629942202;
				switch (num3 == num)
				{
				}
				num = (short)557711361;
				if (num != 0)
				{
				}
				num = (short)1984036864;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothPairingType_A37036.Applicable;
			}
			set
			{
				short num = (short)636289024;
				short num2 = num;
				num = (short)1795676499;
				short num3 = num;
				num = (short)1495062867;
				switch (num3 == num)
				{
				}
				num = (short)894697472;
				if (num != 0)
				{
				}
				num = (short)260571137;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothPairingType_A37036.Applicable = value;
			}
		}

		// Token: 0x17001640 RID: 5696
		// (get) Token: 0x06002C52 RID: 11346 RVA: 0x002AE328 File Offset: 0x002AC528
		// (set) Token: 0x06002C53 RID: 11347 RVA: 0x002AE3E0 File Offset: 0x002AC5E0
		public bool RadWideBluetoothBluetoothPairingType_A37036_Valid
		{
			get
			{
				short num = (short)1812398080;
				short num2 = num;
				num = (short)1268711425;
				if (num != 0)
				{
				}
				num = (short)606023782;
				short num3 = num;
				num = (short)81342566;
				switch (num3 == num)
				{
				}
				num = (short)1593573376;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothPairingType_A37036.Valid;
			}
			set
			{
				short num = (short)868286464;
				short num2 = num;
				num = (short)1378641332;
				short num3 = num;
				num = (short)1529439668;
				switch (num3 == num)
				{
				}
				num = (short)1814888448;
				if (num != 0)
				{
				}
				num = (short)870711297;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothPairingType_A37036.Valid = value;
			}
		}

		// Token: 0x17001641 RID: 5697
		// (get) Token: 0x06002C54 RID: 11348 RVA: 0x002AE498 File Offset: 0x002AC698
		// (set) Token: 0x06002C55 RID: 11349 RVA: 0x002AE550 File Offset: 0x002AC750
		public bool RadWideBluetoothBluetoothPairingType_A37036_Visible
		{
			get
			{
				short num = (short)596901888;
				short num2 = num;
				num = (short)839471263;
				short num3 = num;
				num = (short)906121375;
				switch (num3 == num)
				{
				}
				num = (short)870121473;
				if (num != 0)
				{
				}
				num = (short)961478656;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothPairingType_A37036.Visible;
			}
			set
			{
				short num = (short)647036928;
				short num2 = num;
				num = (short)864476662;
				short num3 = num;
				num = (short)779869686;
				switch (num3 == num)
				{
				}
				num = (short)1081278465;
				if (num != 0)
				{
				}
				num = (short)2027814912;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothPairingType_A37036.Visible = value;
			}
		}

		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x06002C56 RID: 11350 RVA: 0x002AE608 File Offset: 0x002AC808
		// (set) Token: 0x06002C57 RID: 11351 RVA: 0x002AE6BC File Offset: 0x002AC8BC
		public bool RadWideBluetoothBluetoothPairingType_A37036_Editable
		{
			get
			{
				short num = (short)378404864;
				short num2 = num;
				num = (short)1761657817;
				short num3 = num;
				num = (short)898810841;
				switch (num3 == num)
				{
				}
				num = (short)1592131585;
				if (num != 0)
				{
				}
				num = (short)1122500608;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothPairingType_A37036.Editable;
			}
			set
			{
				short num = (short)1986985984;
				short num2 = num;
				num = (short)2137882226;
				short num3 = num;
				num = (short)1374977650;
				switch (num3 == num)
				{
				}
				num = (short)2145910785;
				if (num != 0)
				{
				}
				num = (short)611844096;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothPairingType_A37036.Editable = value;
			}
		}

		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x06002C58 RID: 11352 RVA: 0x002AE774 File Offset: 0x002AC974
		internal string RadWideBluetoothBluetoothPairingType_A37036_UILabel
		{
			get
			{
				short num = (short)2003369984;
				short num2 = num;
				num = (short)545306383;
				short num3 = num;
				num = (short)2090645263;
				switch (num3 == num)
				{
				}
				num = (short)1013776385;
				if (num != 0)
				{
				}
				num = (short)1305542656;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothPairingType_A37036.UIName;
			}
		}

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x06002C59 RID: 11353 RVA: 0x002AE828 File Offset: 0x002ACA28
		// (set) Token: 0x06002C5A RID: 11354 RVA: 0x002AE8E0 File Offset: 0x002ACAE0
		internal bool RadWideBluetoothBluetoothPairingType_A37036_HiddenStatic
		{
			get
			{
				short num = (short)1212743680;
				short num2 = num;
				num = (short)786425664;
				short num3 = num;
				num = (short)360245056;
				switch (num3 == num)
				{
				}
				num = (short)1119879169;
				if (num != 0)
				{
				}
				num = (short)817561600;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothPairingType_A37036.HiddenStatic;
			}
			set
			{
				short num = (short)1804009472;
				short num2 = num;
				num = (short)426657440;
				short num3 = num;
				num = (short)304039584;
				switch (num3 == num)
				{
				}
				num = (short)2131165185;
				if (num != 0)
				{
				}
				num = (short)1041694720;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothPairingType_A37036.HiddenStatic = value;
			}
		}

		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x06002C5B RID: 11355 RVA: 0x002AE994 File Offset: 0x002ACB94
		// (set) Token: 0x06002C5C RID: 11356 RVA: 0x002AEA48 File Offset: 0x002ACC48
		internal bool RadWideBluetoothBluetoothPairingType_A37036_HiddenDynamic
		{
			get
			{
				short num = (short)1960902656;
				short num2 = num;
				num = (short)679993727;
				short num3 = num;
				num = (short)359260543;
				switch (num3 == num)
				{
				}
				num = (short)1837236224;
				if (num != 0)
				{
				}
				num = (short)898891777;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothPairingType_A37036.HiddenDynamic;
			}
			set
			{
				short num = (short)483328000;
				short num2 = num;
				num = (short)103414456;
				short num3 = num;
				num = (short)1573452472;
				switch (num3 == num)
				{
				}
				num = (short)1916928001;
				if (num != 0)
				{
				}
				num = (short)2092040192;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothPairingType_A37036.HiddenDynamic = value;
			}
		}

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x06002C5D RID: 11357 RVA: 0x002AEAFC File Offset: 0x002ACCFC
		public bool RadWideBluetoothBluetoothPairingType_A37036_HasDiffs
		{
			get
			{
				short num = (short)82378752;
				short num2 = num;
				num = (short)698486351;
				short num3 = num;
				num = (short)1084493391;
				switch (num3 == num)
				{
				}
				num = (short)1887305729;
				if (num != 0)
				{
				}
				num = (short)1754988544;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothPairingType_A37036._HasDiffs;
			}
		}

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x06002C5E RID: 11358 RVA: 0x002AEBB0 File Offset: 0x002ACDB0
		// (set) Token: 0x06002C5F RID: 11359 RVA: 0x002AEC64 File Offset: 0x002ACE64
		public bool RadWideStandardNFCPairing_A44928Value
		{
			get
			{
				short num = (short)1026162688;
				short num2 = num;
				num = (short)2133578439;
				short num3 = num;
				num = (short)1757663943;
				switch (num3 == num)
				{
				}
				num = (short)805699584;
				if (num != 0)
				{
				}
				num = (short)2023620609;
				if (num != 0)
				{
				}
				return this.radWideStandardNFCPairing_A44928.Value;
			}
			set
			{
				short num = (short)699924480;
				short num2 = num;
				num = (short)30257350;
				short num3 = num;
				num = (short)230404294;
				switch (num3 == num)
				{
				}
				num = (short)450297857;
				if (num != 0)
				{
				}
				num = (short)1912602624;
				if (num != 0)
				{
				}
				this.radWideStandardNFCPairing_A44928.Value = value;
			}
		}

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x06002C60 RID: 11360 RVA: 0x002AED18 File Offset: 0x002ACF18
		public global::AcpBusinessLayer.AcpField<bool> RadWideStandardNFCPairing_A44928
		{
			get
			{
				short num = (short)1974992896;
				short num2 = num;
				num = (short)1448602708;
				short num3 = num;
				num = (short)1570630740;
				switch (num3 == num)
				{
				}
				num = (short)2022178817;
				if (num != 0)
				{
				}
				num = (short)989790208;
				if (num != 0)
				{
				}
				return this.radWideStandardNFCPairing_A44928;
			}
		}

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x06002C61 RID: 11361 RVA: 0x002AEDC8 File Offset: 0x002ACFC8
		// (set) Token: 0x06002C62 RID: 11362 RVA: 0x002AEE7C File Offset: 0x002AD07C
		public bool RadWideStandardNFCPairing_A44928_UIValue
		{
			get
			{
				short num = (short)189726720;
				short num2 = num;
				num = (short)493551617;
				if (num != 0)
				{
				}
				num = (short)1614339640;
				short num3 = num;
				num = (short)961863224;
				switch (num3 == num)
				{
				}
				num = (short)1403518976;
				if (num != 0)
				{
				}
				return this.radWideStandardNFCPairing_A44928.Value;
			}
			set
			{
				short num = (short)1535246336;
				short num2 = num;
				num = (short)1259250889;
				short num3 = num;
				num = (short)555197641;
				switch (num3 == num)
				{
				}
				num = (short)1683881985;
				if (num != 0)
				{
				}
				num = (short)1600520192;
				if (num != 0)
				{
				}
				this.radWideStandardNFCPairing_A44928.Value = value;
			}
		}

		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x06002C63 RID: 11363 RVA: 0x002AEF34 File Offset: 0x002AD134
		// (set) Token: 0x06002C64 RID: 11364 RVA: 0x002AEFE8 File Offset: 0x002AD1E8
		public bool RadWideStandardNFCPairing_A44928_Applicable
		{
			get
			{
				short num = (short)226756123;
				short num2 = num;
				num = (short)318440987;
				switch (num2 == num)
				{
				}
				num = (short)1622016001;
				if (num != 0)
				{
				}
				num = (short)89325568;
				if (num != 0)
				{
				}
				num = (short)54919168;
				short num3 = num;
				return this.radWideStandardNFCPairing_A44928.Applicable;
			}
			set
			{
				short num = (short)1228800001;
				if (num != 0)
				{
				}
				num = (short)969982235;
				short num2 = num;
				num = (short)367640859;
				switch (num2 == num)
				{
				}
				num = (short)924385280;
				if (num != 0)
				{
				}
				num = (short)934477824;
				short num3 = num;
				this.radWideStandardNFCPairing_A44928.Applicable = value;
			}
		}

		// Token: 0x1700164B RID: 5707
		// (get) Token: 0x06002C65 RID: 11365 RVA: 0x002AF0A4 File Offset: 0x002AD2A4
		// (set) Token: 0x06002C66 RID: 11366 RVA: 0x002AF158 File Offset: 0x002AD358
		public bool RadWideStandardNFCPairing_A44928_Valid
		{
			get
			{
				short num = (short)650667813;
				short num2 = num;
				num = (short)408381221;
				switch (num2 == num)
				{
				}
				num = (short)1131085825;
				if (num != 0)
				{
				}
				num = (short)947847168;
				if (num != 0)
				{
				}
				num = (short)1005191168;
				short num3 = num;
				return this.radWideStandardNFCPairing_A44928.Valid;
			}
			set
			{
				short num = (short)1829697740;
				short num2 = num;
				num = (short)690944204;
				switch (num2 == num)
				{
				}
				num = (short)1942945793;
				if (num != 0)
				{
				}
				num = (short)2087256064;
				if (num != 0)
				{
				}
				num = (short)609419264;
				short num3 = num;
				this.radWideStandardNFCPairing_A44928.Valid = value;
			}
		}

		// Token: 0x1700164C RID: 5708
		// (get) Token: 0x06002C67 RID: 11367 RVA: 0x002AF210 File Offset: 0x002AD410
		// (set) Token: 0x06002C68 RID: 11368 RVA: 0x002AF2C4 File Offset: 0x002AD4C4
		public bool RadWideStandardNFCPairing_A44928_Visible
		{
			get
			{
				short num = (short)133666768;
				short num2 = num;
				num = (short)382834640;
				switch (num2 == num)
				{
				}
				num = (short)561840128;
				if (num != 0)
				{
				}
				num = (short)285802497;
				if (num != 0)
				{
				}
				num = (short)1198325760;
				short num3 = num;
				return this.radWideStandardNFCPairing_A44928.Visible;
			}
			set
			{
				short num = (short)886046721;
				if (num != 0)
				{
				}
				num = (short)830401746;
				short num2 = num;
				num = (short)1631120594;
				switch (num2 == num)
				{
				}
				num = (short)1136656384;
				if (num != 0)
				{
				}
				num = (short)1921908736;
				short num3 = num;
				this.radWideStandardNFCPairing_A44928.Visible = value;
			}
		}

		// Token: 0x1700164D RID: 5709
		// (get) Token: 0x06002C69 RID: 11369 RVA: 0x002AF378 File Offset: 0x002AD578
		// (set) Token: 0x06002C6A RID: 11370 RVA: 0x002AF428 File Offset: 0x002AD628
		public bool RadWideStandardNFCPairing_A44928_Editable
		{
			get
			{
				short num = (short)237059288;
				short num2 = num;
				num = (short)2074164440;
				switch (num2 == num)
				{
				}
				num = (short)1048117249;
				if (num != 0)
				{
				}
				num = (short)1160183808;
				if (num != 0)
				{
				}
				num = (short)1701380096;
				short num3 = num;
				return this.radWideStandardNFCPairing_A44928.Editable;
			}
			set
			{
				short num = (short)375659969;
				short num2 = num;
				num = (short)1603149249;
				switch (num2 == num)
				{
				}
				num = (short)1272840193;
				if (num != 0)
				{
				}
				num = (short)1315766272;
				if (num != 0)
				{
				}
				num = (short)1188233216;
				short num3 = num;
				this.radWideStandardNFCPairing_A44928.Editable = value;
			}
		}

		// Token: 0x1700164E RID: 5710
		// (get) Token: 0x06002C6B RID: 11371 RVA: 0x002AF4DC File Offset: 0x002AD6DC
		internal string RadWideStandardNFCPairing_A44928_UILabel
		{
			get
			{
				short num = (short)500753804;
				short num2 = num;
				num = (short)1494869388;
				switch (num2 == num)
				{
				}
				num = (short)2029191169;
				if (num != 0)
				{
				}
				num = (short)758972416;
				if (num != 0)
				{
				}
				num = (short)571998208;
				short num3 = num;
				return this.radWideStandardNFCPairing_A44928.UIName;
			}
		}

		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x06002C6C RID: 11372 RVA: 0x002AF58C File Offset: 0x002AD78C
		// (set) Token: 0x06002C6D RID: 11373 RVA: 0x002AF640 File Offset: 0x002AD840
		internal bool RadWideStandardNFCPairing_A44928_HiddenStatic
		{
			get
			{
				short num = (short)350355457;
				if (num != 0)
				{
				}
				num = (short)1628794022;
				short num2 = num;
				num = (short)10382502;
				switch (num2 == num)
				{
				}
				num = (short)666828800;
				if (num != 0)
				{
				}
				num = (short)1701773312;
				short num3 = num;
				return this.radWideStandardNFCPairing_A44928.HiddenStatic;
			}
			set
			{
				short num = (short)1701506170;
				short num2 = num;
				num = (short)693169274;
				switch (num2 == num)
				{
				}
				num = (short)88473601;
				if (num != 0)
				{
				}
				num = (short)391839744;
				if (num != 0)
				{
				}
				num = (short)1206714368;
				short num3 = num;
				this.radWideStandardNFCPairing_A44928.HiddenStatic = value;
			}
		}

		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x06002C6E RID: 11374 RVA: 0x002AF6F8 File Offset: 0x002AD8F8
		// (set) Token: 0x06002C6F RID: 11375 RVA: 0x002AF7B0 File Offset: 0x002AD9B0
		internal bool RadWideStandardNFCPairing_A44928_HiddenDynamic
		{
			get
			{
				short num = (short)984968518;
				short num2 = num;
				num = (short)1912302918;
				switch (num2 == num)
				{
				}
				num = (short)184418304;
				if (num != 0)
				{
				}
				num = (short)1875574785;
				if (num != 0)
				{
				}
				num = (short)93519872;
				short num3 = num;
				return this.radWideStandardNFCPairing_A44928.HiddenDynamic;
			}
			set
			{
				short num = (short)1949356310;
				short num2 = num;
				num = (short)1643565334;
				switch (num2 == num)
				{
				}
				num = (short)559349761;
				if (num != 0)
				{
				}
				num = (short)298778624;
				if (num != 0)
				{
				}
				num = (short)688848896;
				short num3 = num;
				this.radWideStandardNFCPairing_A44928.HiddenDynamic = value;
			}
		}

		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x06002C70 RID: 11376 RVA: 0x002AF868 File Offset: 0x002ADA68
		public bool RadWideStandardNFCPairing_A44928_HasDiffs
		{
			get
			{
				short num = (short)131728706;
				short num2 = num;
				num = (short)1474299202;
				switch (num2 == num)
				{
				}
				num = (short)1721565185;
				if (num != 0)
				{
				}
				num = (short)1733033984;
				if (num != 0)
				{
				}
				num = (short)639696896;
				short num3 = num;
				return this.radWideStandardNFCPairing_A44928._HasDiffs;
			}
		}

		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x06002C71 RID: 11377 RVA: 0x002AF91C File Offset: 0x002ADB1C
		// (set) Token: 0x06002C72 RID: 11378 RVA: 0x002AF9D4 File Offset: 0x002ADBD4
		public bool RadWideSecureNFCPairing_A44931Value
		{
			get
			{
				short num = (short)1019420550;
				short num2 = num;
				num = (short)1756110726;
				switch (num2 == num)
				{
				}
				num = (short)1505689601;
				if (num != 0)
				{
				}
				num = (short)843251712;
				if (num != 0)
				{
				}
				num = (short)582025216;
				short num3 = num;
				return this.radWideSecureNFCPairing_A44931.Value;
			}
			set
			{
				short num = (short)1073891217;
				short num2 = num;
				num = (short)1341081489;
				switch (num2 == num)
				{
				}
				num = (short)180355073;
				if (num != 0)
				{
				}
				num = (short)1936654336;
				if (num != 0)
				{
				}
				num = (short)1054474240;
				short num3 = num;
				this.radWideSecureNFCPairing_A44931.Value = value;
			}
		}

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x06002C73 RID: 11379 RVA: 0x002AFA8C File Offset: 0x002ADC8C
		public global::AcpBusinessLayer.AcpField<bool> RadWideSecureNFCPairing_A44931
		{
			get
			{
				short num = (short)1491480581;
				short num2 = num;
				num = (short)649342981;
				switch (num2 == num)
				{
				}
				num = (short)338624513;
				if (num != 0)
				{
				}
				num = (short)226033664;
				if (num != 0)
				{
				}
				num = (short)19529728;
				short num3 = num;
				return this.radWideSecureNFCPairing_A44931;
			}
		}

		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x06002C74 RID: 11380 RVA: 0x002AFB3C File Offset: 0x002ADD3C
		// (set) Token: 0x06002C75 RID: 11381 RVA: 0x002AFBF0 File Offset: 0x002ADDF0
		public bool RadWideSecureNFCPairing_A44931_UIValue
		{
			get
			{
				short num = (short)193372650;
				short num2 = num;
				num = (short)1106354666;
				switch (num2 == num)
				{
				}
				num = (short)823132160;
				if (num != 0)
				{
				}
				num = (short)307036161;
				if (num != 0)
				{
				}
				num = (short)368246784;
				short num3 = num;
				return this.radWideSecureNFCPairing_A44931.Value;
			}
			set
			{
				short num = (short)609131962;
				short num2 = num;
				num = (short)1064082874;
				switch (num2 == num)
				{
				}
				num = (short)1020854272;
				if (num != 0)
				{
				}
				num = (short)425656321;
				if (num != 0)
				{
				}
				num = (short)1203044352;
				short num3 = num;
				this.radWideSecureNFCPairing_A44931.Value = value;
			}
		}

		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x06002C76 RID: 11382 RVA: 0x002AFCA4 File Offset: 0x002ADEA4
		// (set) Token: 0x06002C77 RID: 11383 RVA: 0x002AFD58 File Offset: 0x002ADF58
		public bool RadWideSecureNFCPairing_A44931_Applicable
		{
			get
			{
				short num = (short)951777617;
				short num2 = num;
				num = (short)1060632913;
				switch (num2 == num)
				{
				}
				num = (short)1903624193;
				if (num != 0)
				{
				}
				num = (short)1974206464;
				if (num != 0)
				{
				}
				num = (short)1596981248;
				short num3 = num;
				return this.radWideSecureNFCPairing_A44931.Applicable;
			}
			set
			{
				short num = (short)1326383105;
				if (num != 0)
				{
				}
				num = (short)1982672848;
				short num2 = num;
				num = (short)1723150288;
				switch (num2 == num)
				{
				}
				num = (short)46006272;
				if (num != 0)
				{
				}
				num = (short)69009408;
				short num3 = num;
				this.radWideSecureNFCPairing_A44931.Applicable = value;
			}
		}

		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x06002C78 RID: 11384 RVA: 0x002AFE0C File Offset: 0x002AE00C
		// (set) Token: 0x06002C79 RID: 11385 RVA: 0x002AFEC0 File Offset: 0x002AE0C0
		public bool RadWideSecureNFCPairing_A44931_Valid
		{
			get
			{
				short num = (short)1695766966;
				short num2 = num;
				num = (short)699226550;
				switch (num2 == num)
				{
				}
				num = (short)1191772160;
				if (num != 0)
				{
				}
				num = (short)542703617;
				if (num != 0)
				{
				}
				num = (short)1628241920;
				short num3 = num;
				return this.radWideSecureNFCPairing_A44931.Valid;
			}
			set
			{
				short num = (short)782753585;
				short num2 = num;
				num = (short)1348132657;
				switch (num2 == num)
				{
				}
				num = (short)2114322432;
				if (num != 0)
				{
				}
				num = (short)842661889;
				if (num != 0)
				{
				}
				num = (short)688914432;
				short num3 = num;
				this.radWideSecureNFCPairing_A44931.Valid = value;
			}
		}

		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x06002C7A RID: 11386 RVA: 0x002AFF74 File Offset: 0x002AE174
		// (set) Token: 0x06002C7B RID: 11387 RVA: 0x002B0028 File Offset: 0x002AE228
		public bool RadWideSecureNFCPairing_A44931_Visible
		{
			get
			{
				short num = (short)1613316047;
				short num2 = num;
				num = (short)280117199;
				switch (num2 == num)
				{
				}
				num = (short)983891969;
				if (num != 0)
				{
				}
				num = (short)2078408704;
				if (num != 0)
				{
				}
				num = (short)2045902848;
				short num3 = num;
				return this.radWideSecureNFCPairing_A44931.Visible;
			}
			set
			{
				short num = (short)969378775;
				short num2 = num;
				num = (short)900238295;
				switch (num2 == num)
				{
				}
				num = (short)1743716352;
				if (num != 0)
				{
				}
				num = (short)608763905;
				if (num != 0)
				{
				}
				num = (short)2134704128;
				short num3 = num;
				this.radWideSecureNFCPairing_A44931.Visible = value;
			}
		}

		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x06002C7C RID: 11388 RVA: 0x002B00E0 File Offset: 0x002AE2E0
		// (set) Token: 0x06002C7D RID: 11389 RVA: 0x002B0194 File Offset: 0x002AE394
		public bool RadWideSecureNFCPairing_A44931_Editable
		{
			get
			{
				short num = (short)457978535;
				short num2 = num;
				num = (short)1045246631;
				switch (num2 == num)
				{
				}
				num = (short)420872193;
				if (num != 0)
				{
				}
				num = (short)2055471104;
				if (num != 0)
				{
				}
				num = (short)1574109184;
				short num3 = num;
				return this.radWideSecureNFCPairing_A44931.Editable;
			}
			set
			{
				short num = (short)1549425208;
				short num2 = num;
				num = (short)782326328;
				switch (num2 == num)
				{
				}
				num = (short)1177747456;
				if (num != 0)
				{
				}
				num = (short)914227201;
				if (num != 0)
				{
				}
				num = (short)1359544320;
				short num3 = num;
				this.radWideSecureNFCPairing_A44931.Editable = value;
			}
		}

		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x06002C7E RID: 11390 RVA: 0x002B024C File Offset: 0x002AE44C
		internal string RadWideSecureNFCPairing_A44931_UILabel
		{
			get
			{
				short num = (short)1717501953;
				if (num != 0)
				{
				}
				num = (short)2090183927;
				short num2 = num;
				num = (short)1185656055;
				switch (num2 == num)
				{
				}
				num = (short)2085289984;
				if (num != 0)
				{
				}
				num = (short)1992556544;
				short num3 = num;
				return this.radWideSecureNFCPairing_A44931.UIName;
			}
		}

		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x06002C7F RID: 11391 RVA: 0x002B0304 File Offset: 0x002AE504
		// (set) Token: 0x06002C80 RID: 11392 RVA: 0x002B03BC File Offset: 0x002AE5BC
		internal bool RadWideSecureNFCPairing_A44931_HiddenStatic
		{
			get
			{
				short num = (short)1494253153;
				short num2 = num;
				num = (short)2072804961;
				switch (num2 == num)
				{
				}
				num = (short)222887936;
				if (num != 0)
				{
				}
				num = (short)828178433;
				if (num != 0)
				{
				}
				num = (short)2113732608;
				short num3 = num;
				return this.radWideSecureNFCPairing_A44931.HiddenStatic;
			}
			set
			{
				short num = (short)313705451;
				short num2 = num;
				num = (short)543867883;
				switch (num2 == num)
				{
				}
				num = (short)1225195521;
				if (num != 0)
				{
				}
				num = (short)1199439872;
				if (num != 0)
				{
				}
				num = (short)1288241152;
				short num3 = num;
				this.radWideSecureNFCPairing_A44931.HiddenStatic = value;
			}
		}

		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x06002C81 RID: 11393 RVA: 0x002B0474 File Offset: 0x002AE674
		// (set) Token: 0x06002C82 RID: 11394 RVA: 0x002B0528 File Offset: 0x002AE728
		internal bool RadWideSecureNFCPairing_A44931_HiddenDynamic
		{
			get
			{
				short num = (short)285335556;
				short num2 = num;
				num = (short)2035736580;
				switch (num2 == num)
				{
				}
				num = (short)315359233;
				if (num != 0)
				{
				}
				num = (short)225902592;
				if (num != 0)
				{
				}
				num = (short)2077556736;
				short num3 = num;
				return this.radWideSecureNFCPairing_A44931.HiddenDynamic;
			}
			set
			{
				short num = (short)1960902657;
				if (num != 0)
				{
				}
				num = (short)1850115653;
				short num2 = num;
				num = (short)354518597;
				switch (num2 == num)
				{
				}
				num = (short)1167851520;
				if (num != 0)
				{
				}
				num = (short)2119434240;
				short num3 = num;
				this.radWideSecureNFCPairing_A44931.HiddenDynamic = value;
			}
		}

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x06002C83 RID: 11395 RVA: 0x002B05E0 File Offset: 0x002AE7E0
		public bool RadWideSecureNFCPairing_A44931_HasDiffs
		{
			get
			{
				short num = (short)442189280;
				short num2 = num;
				num = (short)1715946976;
				switch (num2 == num)
				{
				}
				num = (short)1019871232;
				if (num != 0)
				{
				}
				num = (short)2077425665;
				if (num != 0)
				{
				}
				num = (short)566099968;
				short num3 = num;
				return this.radWideSecureNFCPairing_A44931._HasDiffs;
			}
		}

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x06002C84 RID: 11396 RVA: 0x002B0694 File Offset: 0x002AE894
		// (set) Token: 0x06002C85 RID: 11397 RVA: 0x002B0748 File Offset: 0x002AE948
		public int RadWideBluetoothBluetoothReconnectTimer_A37037Value
		{
			get
			{
				short num = (short)8975671;
				short num2 = num;
				num = (short)928773431;
				switch (num2 == num)
				{
				}
				num = (short)961216513;
				if (num != 0)
				{
				}
				num = (short)1898905600;
				if (num != 0)
				{
				}
				num = (short)296353792;
				short num3 = num;
				return this.radWideBluetoothBluetoothReconnectTimer_A37037.Value;
			}
			set
			{
				short num = (short)144835781;
				short num2 = num;
				num = (short)163972293;
				switch (num2 == num)
				{
				}
				num = (short)573898753;
				if (num != 0)
				{
				}
				num = (short)1752301568;
				if (num != 0)
				{
				}
				num = (short)154664960;
				short num3 = num;
				this.radWideBluetoothBluetoothReconnectTimer_A37037.Value = value;
			}
		}

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x06002C86 RID: 11398 RVA: 0x002B07FC File Offset: 0x002AE9FC
		public global::AcpBusinessLayer.AcpCustomRangeField RadWideBluetoothBluetoothReconnectTimer_A37037
		{
			get
			{
				short num = (short)1931951661;
				short num2 = num;
				num = (short)30883373;
				switch (num2 == num)
				{
				}
				num = (short)2092826625;
				if (num != 0)
				{
				}
				num = (short)833617920;
				if (num != 0)
				{
				}
				num = (short)10027008;
				short num3 = num;
				return this.radWideBluetoothBluetoothReconnectTimer_A37037;
			}
		}

		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x06002C87 RID: 11399 RVA: 0x002B08AC File Offset: 0x002AEAAC
		// (set) Token: 0x06002C88 RID: 11400 RVA: 0x002B0960 File Offset: 0x002AEB60
		public string RadWideBluetoothBluetoothReconnectTimer_A37037_UIValue
		{
			get
			{
				short num = (short)1696631445;
				short num2 = num;
				num = (short)1451461269;
				switch (num2 == num)
				{
				}
				num = (short)189136896;
				if (num != 0)
				{
				}
				num = (short)56623105;
				if (num != 0)
				{
				}
				num = (short)285409280;
				short num3 = num;
				return this.radWideBluetoothBluetoothReconnectTimer_A37037.UIValue;
			}
			set
			{
				short num = (short)1294196870;
				short num2 = num;
				num = (short)1590812806;
				switch (num2 == num)
				{
				}
				num = (short)1182924800;
				if (num != 0)
				{
				}
				num = (short)1047003137;
				if (num != 0)
				{
				}
				num = (short)1541079040;
				short num3 = num;
				this.radWideBluetoothBluetoothReconnectTimer_A37037.UIValue = value;
			}
		}

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x06002C89 RID: 11401 RVA: 0x002B0A14 File Offset: 0x002AEC14
		// (set) Token: 0x06002C8A RID: 11402 RVA: 0x002B0AC8 File Offset: 0x002AECC8
		internal int RadWideBluetoothBluetoothReconnectTimer_A37037Min
		{
			get
			{
				short num = (short)917805206;
				short num2 = num;
				num = (short)1900648598;
				switch (num2 == num)
				{
				}
				num = (short)1525153793;
				if (num != 0)
				{
				}
				num = (short)2101149696;
				if (num != 0)
				{
				}
				num = (short)1551171584;
				short num3 = num;
				return this.radWideBluetoothBluetoothReconnectTimer_A37037.Min;
			}
			set
			{
				short num = (short)1069381857;
				short num2 = num;
				num = (short)304183521;
				switch (num2 == num)
				{
				}
				num = (short)1301807104;
				if (num != 0)
				{
				}
				num = (short)1803812865;
				if (num != 0)
				{
				}
				num = (short)686292992;
				short num3 = num;
				this.radWideBluetoothBluetoothReconnectTimer_A37037.Min = value;
			}
		}

		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x06002C8B RID: 11403 RVA: 0x002B0B80 File Offset: 0x002AED80
		// (set) Token: 0x06002C8C RID: 11404 RVA: 0x002B0C38 File Offset: 0x002AEE38
		internal int RadWideBluetoothBluetoothReconnectTimer_A37037Max
		{
			get
			{
				short num = (short)2117669831;
				short num2 = num;
				num = (short)2002785223;
				switch (num2 == num)
				{
				}
				num = (short)795672576;
				if (num != 0)
				{
				}
				num = (short)357171201;
				if (num != 0)
				{
				}
				num = (short)585760768;
				short num3 = num;
				return this.radWideBluetoothBluetoothReconnectTimer_A37037.Max;
			}
			set
			{
				short num = (short)1418706997;
				short num2 = num;
				num = (short)445169717;
				switch (num2 == num)
				{
				}
				num = (short)348258304;
				if (num != 0)
				{
				}
				num = (short)199491585;
				if (num != 0)
				{
				}
				num = (short)1669529600;
				short num3 = num;
				this.radWideBluetoothBluetoothReconnectTimer_A37037.Max = value;
			}
		}

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x06002C8D RID: 11405 RVA: 0x002B0CEC File Offset: 0x002AEEEC
		// (set) Token: 0x06002C8E RID: 11406 RVA: 0x002B0DA0 File Offset: 0x002AEFA0
		internal int RadWideBluetoothBluetoothReconnectTimer_A37037Step
		{
			get
			{
				short num = (short)1758649933;
				short num2 = num;
				num = (short)1078124109;
				switch (num2 == num)
				{
				}
				num = (short)978386944;
				if (num != 0)
				{
				}
				num = (short)154927105;
				if (num != 0)
				{
				}
				num = (short)1966473216;
				short num3 = num;
				return this.radWideBluetoothBluetoothReconnectTimer_A37037.StepSize;
			}
			set
			{
				short num = (short)3609035;
				short num2 = num;
				num = (short)570626507;
				switch (num2 == num)
				{
				}
				num = (short)1995636737;
				if (num != 0)
				{
				}
				num = (short)578682880;
				if (num != 0)
				{
				}
				num = (short)719060992;
				short num3 = num;
				this.radWideBluetoothBluetoothReconnectTimer_A37037.StepSize = value;
			}
		}

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x06002C8F RID: 11407 RVA: 0x002B0E54 File Offset: 0x002AF054
		// (set) Token: 0x06002C90 RID: 11408 RVA: 0x002B0F08 File Offset: 0x002AF108
		public bool RadWideBluetoothBluetoothReconnectTimer_A37037_Applicable
		{
			get
			{
				short num = (short)1473249281;
				if (num != 0)
				{
				}
				num = (short)1887488661;
				short num2 = num;
				num = (short)171559573;
				switch (num2 == num)
				{
				}
				num = (short)375193600;
				if (num != 0)
				{
				}
				num = (short)999292928;
				short num3 = num;
				return this.radWideBluetoothBluetoothReconnectTimer_A37037.Applicable;
			}
			set
			{
				short num = (short)850426361;
				short num2 = num;
				num = (short)1004894713;
				switch (num2 == num)
				{
				}
				num = (short)1920991233;
				if (num != 0)
				{
				}
				num = (short)906362880;
				if (num != 0)
				{
				}
				num = (short)1060634624;
				short num3 = num;
				this.radWideBluetoothBluetoothReconnectTimer_A37037.Applicable = value;
			}
		}

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x06002C91 RID: 11409 RVA: 0x002B0FBC File Offset: 0x002AF1BC
		// (set) Token: 0x06002C92 RID: 11410 RVA: 0x002B1070 File Offset: 0x002AF270
		public bool RadWideBluetoothBluetoothReconnectTimer_A37037_Valid
		{
			get
			{
				short num = (short)2047606785;
				if (num != 0)
				{
				}
				num = (short)1810789770;
				short num2 = num;
				num = (short)1494119818;
				switch (num2 == num)
				{
				}
				num = (short)983040000;
				if (num != 0)
				{
				}
				num = (short)1870790656;
				short num3 = num;
				return this.radWideBluetoothBluetoothReconnectTimer_A37037.Valid;
			}
			set
			{
				short num = (short)1833360444;
				short num2 = num;
				num = (short)565304380;
				switch (num2 == num)
				{
				}
				num = (short)94437377;
				if (num != 0)
				{
				}
				num = (short)1482162176;
				if (num != 0)
				{
				}
				num = (short)663879680;
				short num3 = num;
				this.radWideBluetoothBluetoothReconnectTimer_A37037.Valid = value;
			}
		}

		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x06002C93 RID: 11411 RVA: 0x002B1128 File Offset: 0x002AF328
		// (set) Token: 0x06002C94 RID: 11412 RVA: 0x002B11DC File Offset: 0x002AF3DC
		public bool RadWideBluetoothBluetoothReconnectTimer_A37037_Visible
		{
			get
			{
				short num = (short)1320409906;
				short num2 = num;
				num = (short)193321778;
				switch (num2 == num)
				{
				}
				num = (short)1828978689;
				if (num != 0)
				{
				}
				num = (short)347602944;
				if (num != 0)
				{
				}
				num = (short)1383399424;
				short num3 = num;
				return this.radWideBluetoothBluetoothReconnectTimer_A37037.Visible;
			}
			set
			{
				short num = (short)742639294;
				short num2 = num;
				num = (short)265995966;
				switch (num2 == num)
				{
				}
				num = (short)995360769;
				if (num != 0)
				{
				}
				num = (short)1781596160;
				if (num != 0)
				{
				}
				num = (short)1575878656;
				short num3 = num;
				this.radWideBluetoothBluetoothReconnectTimer_A37037.Visible = value;
			}
		}

		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x06002C95 RID: 11413 RVA: 0x002B1294 File Offset: 0x002AF494
		// (set) Token: 0x06002C96 RID: 11414 RVA: 0x002B1348 File Offset: 0x002AF548
		public bool RadWideBluetoothBluetoothReconnectTimer_A37037_Editable
		{
			get
			{
				short num = (short)1895736001;
				short num2 = num;
				num = (short)1031512769;
				switch (num2 == num)
				{
				}
				num = (short)1436876801;
				if (num != 0)
				{
				}
				num = (short)1984299008;
				if (num != 0)
				{
				}
				num = (short)1869086720;
				short num3 = num;
				return this.radWideBluetoothBluetoothReconnectTimer_A37037.Editable;
			}
			set
			{
				short num = (short)2117603036;
				short num2 = num;
				num = (short)256380636;
				switch (num2 == num)
				{
				}
				num = (short)1524432897;
				if (num != 0)
				{
				}
				num = (short)1033109504;
				if (num != 0)
				{
				}
				num = (short)1390608384;
				short num3 = num;
				this.radWideBluetoothBluetoothReconnectTimer_A37037.Editable = value;
			}
		}

		// Token: 0x17001667 RID: 5735
		// (get) Token: 0x06002C97 RID: 11415 RVA: 0x002B1400 File Offset: 0x002AF600
		internal string RadWideBluetoothBluetoothReconnectTimer_A37037_UILabel
		{
			get
			{
				short num = (short)209997465;
				short num2 = num;
				num = (short)339365529;
				switch (num2 == num)
				{
				}
				num = (short)669384705;
				if (num != 0)
				{
				}
				num = (short)121765888;
				if (num != 0)
				{
				}
				num = (short)123535360;
				short num3 = num;
				return this.radWideBluetoothBluetoothReconnectTimer_A37037.UIName;
			}
		}

		// Token: 0x17001668 RID: 5736
		// (get) Token: 0x06002C98 RID: 11416 RVA: 0x002B14B4 File Offset: 0x002AF6B4
		// (set) Token: 0x06002C99 RID: 11417 RVA: 0x002B1568 File Offset: 0x002AF768
		internal bool RadWideBluetoothBluetoothReconnectTimer_A37037_HiddenStatic
		{
			get
			{
				short num = (short)1248191719;
				short num2 = num;
				num = (short)1820517607;
				switch (num2 == num)
				{
				}
				num = (short)932380673;
				if (num != 0)
				{
				}
				num = (short)909246464;
				if (num != 0)
				{
				}
				num = (short)1193607168;
				short num3 = num;
				return this.radWideBluetoothBluetoothReconnectTimer_A37037.HiddenStatic;
			}
			set
			{
				short num = (short)1572304120;
				short num2 = num;
				num = (short)556496120;
				switch (num2 == num)
				{
				}
				num = (short)585957377;
				if (num != 0)
				{
				}
				num = (short)621936640;
				if (num != 0)
				{
				}
				num = (short)895877120;
				short num3 = num;
				this.radWideBluetoothBluetoothReconnectTimer_A37037.HiddenStatic = value;
			}
		}

		// Token: 0x17001669 RID: 5737
		// (get) Token: 0x06002C9A RID: 11418 RVA: 0x002B1620 File Offset: 0x002AF820
		// (set) Token: 0x06002C9B RID: 11419 RVA: 0x002B16D4 File Offset: 0x002AF8D4
		internal bool RadWideBluetoothBluetoothReconnectTimer_A37037_HiddenDynamic
		{
			get
			{
				short num = (short)1663609957;
				short num2 = num;
				num = (short)865381477;
				switch (num2 == num)
				{
				}
				num = (short)1291517953;
				if (num != 0)
				{
				}
				num = (short)864813056;
				short num3 = num;
				num = (short)1220673536;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothReconnectTimer_A37037.HiddenDynamic;
			}
			set
			{
				short num = (short)1004724713;
				short num2 = num;
				num = (short)1701700073;
				switch (num2 == num)
				{
				}
				num = (short)788856833;
				if (num != 0)
				{
				}
				num = (short)1642463232;
				short num3 = num;
				num = (short)1666187264;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothReconnectTimer_A37037.HiddenDynamic = value;
			}
		}

		// Token: 0x1700166A RID: 5738
		// (get) Token: 0x06002C9C RID: 11420 RVA: 0x002B1788 File Offset: 0x002AF988
		public bool RadWideBluetoothBluetoothReconnectTimer_A37037_HasDiffs
		{
			get
			{
				short num = (short)1853761366;
				short num2 = num;
				num = (short)1759455062;
				switch (num2 == num)
				{
				}
				num = (short)1593311233;
				if (num != 0)
				{
				}
				num = (short)361168896;
				short num3 = num;
				num = (short)760086528;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothReconnectTimer_A37037._HasDiffs;
			}
		}

		// Token: 0x1700166B RID: 5739
		// (get) Token: 0x06002C9D RID: 11421 RVA: 0x002B183C File Offset: 0x002AFA3C
		// (set) Token: 0x06002C9E RID: 11422 RVA: 0x002B18F0 File Offset: 0x002AFAF0
		public int RadWideBluetoothBluetoothDropTimer_A37038Value
		{
			get
			{
				short num = (short)911043829;
				short num2 = num;
				num = (short)2118872309;
				switch (num2 == num)
				{
				}
				num = (short)1015152641;
				if (num != 0)
				{
				}
				num = (short)1881800704;
				short num3 = num;
				num = (short)1394278400;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDropTimer_A37038.Value;
			}
			set
			{
				short num = (short)1418421545;
				short num2 = num;
				num = (short)1000236329;
				switch (num2 == num)
				{
				}
				num = (short)1487405057;
				if (num != 0)
				{
				}
				num = (short)2000945152;
				short num3 = num;
				num = (short)1997406208;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDropTimer_A37038.Value = value;
			}
		}

		// Token: 0x1700166C RID: 5740
		// (get) Token: 0x06002C9F RID: 11423 RVA: 0x002B19A8 File Offset: 0x002AFBA8
		// (set) Token: 0x06002CA0 RID: 11424 RVA: 0x002B1A5C File Offset: 0x002AFC5C
		public string RadWideBluetoothBluetoothDropTimer_A37038_UIValue
		{
			get
			{
				short num = (short)268210842;
				short num2 = num;
				num = (short)658739866;
				switch (num2 == num)
				{
				}
				num = (short)1132593153;
				if (num != 0)
				{
				}
				num = (short)937230336;
				short num3 = num;
				num = (short)933167104;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDropTimer_A37038.UIValue;
			}
			set
			{
				short num = (short)282431457;
				short num2 = num;
				num = (short)1274122209;
				switch (num2 == num)
				{
				}
				num = (short)418709505;
				if (num != 0)
				{
				}
				num = (short)1820983296;
				short num3 = num;
				num = (short)1395064832;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDropTimer_A37038.UIValue = value;
			}
		}

		// Token: 0x1700166D RID: 5741
		// (get) Token: 0x06002CA1 RID: 11425 RVA: 0x002B1B10 File Offset: 0x002AFD10
		public global::AcpBusinessLayer.AcpListField RadWideBluetoothBluetoothDropTimer_A37038
		{
			get
			{
				short num = (short)110862176;
				short num2 = num;
				num = (short)876912480;
				switch (num2 == num)
				{
				}
				num = (short)125435905;
				if (num != 0)
				{
				}
				num = (short)1224998912;
				short num3 = num;
				num = (short)251396096;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDropTimer_A37038;
			}
		}

		// Token: 0x1700166E RID: 5742
		// (get) Token: 0x06002CA2 RID: 11426 RVA: 0x002B1BC0 File Offset: 0x002AFDC0
		// (set) Token: 0x06002CA3 RID: 11427 RVA: 0x002B1C74 File Offset: 0x002AFE74
		public bool RadWideBluetoothBluetoothDropTimer_A37038_Applicable
		{
			get
			{
				short num = (short)505815457;
				short num2 = num;
				num = (short)89596321;
				switch (num2 == num)
				{
				}
				num = (short)117637120;
				if (num != 0)
				{
				}
				num = (short)1207762944;
				short num3 = num;
				num = (short)715390977;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDropTimer_A37038.Applicable;
			}
			set
			{
				short num = (short)1285590178;
				short num2 = num;
				num = (short)883920034;
				switch (num2 == num)
				{
				}
				num = (short)1200095233;
				if (num != 0)
				{
				}
				num = (short)7929856;
				short num3 = num;
				num = (short)1089863680;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDropTimer_A37038.Applicable = value;
			}
		}

		// Token: 0x1700166F RID: 5743
		// (get) Token: 0x06002CA4 RID: 11428 RVA: 0x002B1D28 File Offset: 0x002AFF28
		// (set) Token: 0x06002CA5 RID: 11429 RVA: 0x002B1DDC File Offset: 0x002AFFDC
		public bool RadWideBluetoothBluetoothDropTimer_A37038_Valid
		{
			get
			{
				short num = (short)1281713716;
				short num2 = num;
				num = (short)1076258356;
				switch (num2 == num)
				{
				}
				num = (short)13107201;
				if (num != 0)
				{
				}
				num = (short)686817280;
				short num3 = num;
				num = (short)275709952;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDropTimer_A37038.Valid;
			}
			set
			{
				short num = (short)1189019649;
				if (num != 0)
				{
				}
				num = (short)499787622;
				short num2 = num;
				num = (short)807544678;
				switch (num2 == num)
				{
				}
				num = (short)667156480;
				short num3 = num;
				num = (short)62586880;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDropTimer_A37038.Valid = value;
			}
		}

		// Token: 0x17001670 RID: 5744
		// (get) Token: 0x06002CA6 RID: 11430 RVA: 0x002B1E90 File Offset: 0x002B0090
		// (set) Token: 0x06002CA7 RID: 11431 RVA: 0x002B1F44 File Offset: 0x002B0144
		public bool RadWideBluetoothBluetoothDropTimer_A37038_Visible
		{
			get
			{
				short num = (short)75553759;
				short num2 = num;
				num = (short)119528415;
				switch (num2 == num)
				{
				}
				num = (short)333381633;
				if (num != 0)
				{
				}
				num = (short)1586102272;
				short num3 = num;
				num = (short)17235968;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDropTimer_A37038.Visible;
			}
			set
			{
				short num = (short)61145213;
				short num2 = num;
				num = (short)326238333;
				switch (num2 == num)
				{
				}
				num = (short)1432420352;
				if (num != 0)
				{
				}
				num = (short)1793261568;
				short num3 = num;
				num = (short)429064193;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDropTimer_A37038.Visible = value;
			}
		}

		// Token: 0x17001671 RID: 5745
		// (get) Token: 0x06002CA8 RID: 11432 RVA: 0x002B1FF8 File Offset: 0x002B01F8
		// (set) Token: 0x06002CA9 RID: 11433 RVA: 0x002B20B0 File Offset: 0x002B02B0
		public bool RadWideBluetoothBluetoothDropTimer_A37038_Editable
		{
			get
			{
				short num = (short)1348591961;
				short num2 = num;
				num = (short)1556865369;
				switch (num2 == num)
				{
				}
				num = (short)1311834112;
				if (num != 0)
				{
				}
				num = (short)1861484544;
				short num3 = num;
				num = (short)523960321;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDropTimer_A37038.Editable;
			}
			set
			{
				short num = (short)588496124;
				short num2 = num;
				num = (short)1270332668;
				switch (num2 == num)
				{
				}
				num = (short)1126760448;
				if (num != 0)
				{
				}
				num = (short)2090729472;
				short num3 = num;
				num = (short)1989345281;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDropTimer_A37038.Editable = value;
			}
		}

		// Token: 0x17001672 RID: 5746
		// (get) Token: 0x06002CAA RID: 11434 RVA: 0x002B2168 File Offset: 0x002B0368
		internal string RadWideBluetoothBluetoothDropTimer_A37038_UILabel
		{
			get
			{
				short num = (short)305745791;
				short num2 = num;
				num = (short)1328107391;
				switch (num2 == num)
				{
				}
				num = (short)2030043136;
				if (num != 0)
				{
				}
				num = (short)206635008;
				short num3 = num;
				num = (short)1254162433;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDropTimer_A37038.UIName;
			}
		}

		// Token: 0x17001673 RID: 5747
		// (get) Token: 0x06002CAB RID: 11435 RVA: 0x002B221C File Offset: 0x002B041C
		// (set) Token: 0x06002CAC RID: 11436 RVA: 0x002B22D0 File Offset: 0x002B04D0
		internal bool RadWideBluetoothBluetoothDropTimer_A37038_HiddenStatic
		{
			get
			{
				short num = (short)1339165011;
				short num2 = num;
				num = (short)1289423187;
				switch (num2 == num)
				{
				}
				num = (short)21430273;
				if (num != 0)
				{
				}
				num = (short)945946624;
				short num3 = num;
				num = (short)1964048384;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDropTimer_A37038.HiddenStatic;
			}
			set
			{
				short num = (short)1634402305;
				if (num != 0)
				{
				}
				num = (short)688399577;
				short num2 = num;
				num = (short)720643289;
				switch (num2 == num)
				{
				}
				num = (short)1557135360;
				short num3 = num;
				num = (short)313131008;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDropTimer_A37038.HiddenStatic = value;
			}
		}

		// Token: 0x17001674 RID: 5748
		// (get) Token: 0x06002CAD RID: 11437 RVA: 0x002B2388 File Offset: 0x002B0588
		// (set) Token: 0x06002CAE RID: 11438 RVA: 0x002B243C File Offset: 0x002B063C
		internal bool RadWideBluetoothBluetoothDropTimer_A37038_HiddenDynamic
		{
			get
			{
				short num = (short)1516365194;
				short num2 = num;
				num = (short)148497802;
				switch (num2 == num)
				{
				}
				num = (short)851181569;
				if (num != 0)
				{
				}
				num = (short)639172608;
				short num3 = num;
				num = (short)1293090816;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDropTimer_A37038.HiddenDynamic;
			}
			set
			{
				short num = (short)1244688283;
				short num2 = num;
				num = (short)1051029403;
				switch (num2 == num)
				{
				}
				num = (short)1653800961;
				if (num != 0)
				{
				}
				num = (short)927465472;
				short num3 = num;
				num = (short)1596784640;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDropTimer_A37038.HiddenDynamic = value;
			}
		}

		// Token: 0x17001675 RID: 5749
		// (get) Token: 0x06002CAF RID: 11439 RVA: 0x002B24F4 File Offset: 0x002B06F4
		public bool RadWideBluetoothBluetoothDropTimer_A37038_HasDiffs
		{
			get
			{
				short num = (short)1513847657;
				short num2 = num;
				num = (short)1887402857;
				switch (num2 == num)
				{
				}
				num = (short)1271660544;
				if (num != 0)
				{
				}
				num = (short)1011613696;
				short num3 = num;
				num = (short)668073985;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDropTimer_A37038._HasDiffs;
			}
		}

		// Token: 0x17001676 RID: 5750
		// (get) Token: 0x06002CB0 RID: 11440 RVA: 0x002B25A8 File Offset: 0x002B07A8
		// (set) Token: 0x06002CB1 RID: 11441 RVA: 0x002B2660 File Offset: 0x002B0860
		public string RadWideBluetoothFriendlyName_A41181Value
		{
			get
			{
				short num = (short)1987038566;
				short num2 = num;
				num = (short)1516424550;
				switch (num2 == num)
				{
				}
				num = (short)2071134209;
				if (num != 0)
				{
				}
				num = (short)620560384;
				short num3 = num;
				num = (short)917766144;
				if (num != 0)
				{
				}
				return this.radWideBluetoothFriendlyName_A41181.Value;
			}
			set
			{
				short num = (short)917468473;
				short num2 = num;
				num = (short)1088255289;
				switch (num2 == num)
				{
				}
				num = (short)1624637441;
				if (num != 0)
				{
				}
				num = (short)1299251200;
				short num3 = num;
				num = (short)1474560000;
				if (num != 0)
				{
				}
				this.radWideBluetoothFriendlyName_A41181.Value = value;
			}
		}

		// Token: 0x17001677 RID: 5751
		// (get) Token: 0x06002CB2 RID: 11442 RVA: 0x002B2714 File Offset: 0x002B0914
		public global::AcpBusinessLayer.AcpField<string> RadWideBluetoothFriendlyName_A41181
		{
			get
			{
				short num = (short)1318195677;
				short num2 = num;
				num = (short)1767969245;
				switch (num2 == num)
				{
				}
				num = (short)100597761;
				if (num != 0)
				{
				}
				num = (short)2070609920;
				short num3 = num;
				num = (short)1831993344;
				if (num != 0)
				{
				}
				return this.radWideBluetoothFriendlyName_A41181;
			}
		}

		// Token: 0x17001678 RID: 5752
		// (get) Token: 0x06002CB3 RID: 11443 RVA: 0x002B27C4 File Offset: 0x002B09C4
		// (set) Token: 0x06002CB4 RID: 11444 RVA: 0x002B2878 File Offset: 0x002B0A78
		public string RadWideBluetoothFriendlyName_A41181_UIValue
		{
			get
			{
				short num = (short)2013117724;
				short num2 = num;
				num = (short)746437916;
				switch (num2 == num)
				{
				}
				num = (short)1513816065;
				if (num != 0)
				{
				}
				num = (short)662372352;
				short num3 = num;
				num = (short)1847001088;
				if (num != 0)
				{
				}
				return this.radWideBluetoothFriendlyName_A41181.Value;
			}
			set
			{
				short num = (short)896302588;
				short num2 = num;
				num = (short)720666108;
				switch (num2 == num)
				{
				}
				num = (short)1952645121;
				if (num != 0)
				{
				}
				num = (short)569376768;
				short num3 = num;
				num = (short)309854208;
				if (num != 0)
				{
				}
				this.radWideBluetoothFriendlyName_A41181.Value = value;
			}
		}

		// Token: 0x17001679 RID: 5753
		// (get) Token: 0x06002CB5 RID: 11445 RVA: 0x002B292C File Offset: 0x002B0B2C
		// (set) Token: 0x06002CB6 RID: 11446 RVA: 0x002B29E0 File Offset: 0x002B0BE0
		public bool RadWideBluetoothFriendlyName_A41181_Applicable
		{
			get
			{
				short num = (short)1698156997;
				short num2 = num;
				num = (short)79221189;
				switch (num2 == num)
				{
				}
				num = (short)1150287872;
				if (num != 0)
				{
				}
				num = (short)1228472320;
				short num3 = num;
				num = (short)536215553;
				if (num != 0)
				{
				}
				return this.radWideBluetoothFriendlyName_A41181.Applicable;
			}
			set
			{
				short num = (short)826193826;
				short num2 = num;
				num = (short)813086626;
				switch (num2 == num)
				{
				}
				num = (short)451936257;
				if (num != 0)
				{
				}
				num = (short)1515978752;
				short num3 = num;
				num = (short)1295908864;
				if (num != 0)
				{
				}
				this.radWideBluetoothFriendlyName_A41181.Applicable = value;
			}
		}

		// Token: 0x1700167A RID: 5754
		// (get) Token: 0x06002CB7 RID: 11447 RVA: 0x002B2A94 File Offset: 0x002B0C94
		// (set) Token: 0x06002CB8 RID: 11448 RVA: 0x002B2B48 File Offset: 0x002B0D48
		public bool RadWideBluetoothFriendlyName_A41181_Valid
		{
			get
			{
				short num = (short)1850351913;
				short num2 = num;
				num = (short)738140457;
				switch (num2 == num)
				{
				}
				num = (short)2137718785;
				if (num != 0)
				{
				}
				num = (short)773390336;
				short num3 = num;
				num = (short)1076690944;
				if (num != 0)
				{
				}
				return this.radWideBluetoothFriendlyName_A41181.Valid;
			}
			set
			{
				short num = (short)398053671;
				short num2 = num;
				num = (short)444256551;
				switch (num2 == num)
				{
				}
				num = (short)1199308801;
				if (num != 0)
				{
				}
				num = (short)793116672;
				short num3 = num;
				num = (short)28311552;
				if (num != 0)
				{
				}
				this.radWideBluetoothFriendlyName_A41181.Valid = value;
			}
		}

		// Token: 0x1700167B RID: 5755
		// (get) Token: 0x06002CB9 RID: 11449 RVA: 0x002B2C00 File Offset: 0x002B0E00
		// (set) Token: 0x06002CBA RID: 11450 RVA: 0x002B2CB4 File Offset: 0x002B0EB4
		public bool RadWideBluetoothFriendlyName_A41181_Visible
		{
			get
			{
				short num = (short)75904939;
				short num2 = num;
				num = (short)752629675;
				switch (num2 == num)
				{
				}
				num = (short)809959425;
				if (num != 0)
				{
				}
				num = (short)1489960960;
				short num3 = num;
				num = (short)1968701440;
				if (num != 0)
				{
				}
				return this.radWideBluetoothFriendlyName_A41181.Visible;
			}
			set
			{
				short num = (short)514547960;
				short num2 = num;
				num = (short)133062904;
				switch (num2 == num)
				{
				}
				num = (short)1164378113;
				if (num != 0)
				{
				}
				num = (short)1912537088;
				short num3 = num;
				num = (short)794099712;
				if (num != 0)
				{
				}
				this.radWideBluetoothFriendlyName_A41181.Visible = value;
			}
		}

		// Token: 0x1700167C RID: 5756
		// (get) Token: 0x06002CBB RID: 11451 RVA: 0x002B2D68 File Offset: 0x002B0F68
		// (set) Token: 0x06002CBC RID: 11452 RVA: 0x002B2E1C File Offset: 0x002B101C
		public bool RadWideBluetoothFriendlyName_A41181_Editable
		{
			get
			{
				short num = (short)830472193;
				if (num != 0)
				{
				}
				num = (short)42958910;
				short num2 = num;
				num = (short)1847099454;
				switch (num2 == num)
				{
				}
				num = (short)761987072;
				short num3 = num;
				num = (short)1542979584;
				if (num != 0)
				{
				}
				return this.radWideBluetoothFriendlyName_A41181.Editable;
			}
			set
			{
				short num = (short)1781792769;
				if (num != 0)
				{
				}
				num = (short)1739872351;
				short num2 = num;
				num = (short)2097567839;
				switch (num2 == num)
				{
				}
				num = (short)1877868544;
				short num3 = num;
				num = (short)1989541888;
				if (num != 0)
				{
				}
				this.radWideBluetoothFriendlyName_A41181.Editable = value;
			}
		}

		// Token: 0x1700167D RID: 5757
		// (get) Token: 0x06002CBD RID: 11453 RVA: 0x002B2ED0 File Offset: 0x002B10D0
		internal string RadWideBluetoothFriendlyName_A41181_UILabel
		{
			get
			{
				short num = (short)844389443;
				short num2 = num;
				num = (short)1895914563;
				switch (num2 == num)
				{
				}
				num = (short)1384710144;
				if (num != 0)
				{
				}
				num = (short)1799028736;
				short num3 = num;
				num = (short)342425601;
				if (num != 0)
				{
				}
				return this.radWideBluetoothFriendlyName_A41181.UIName;
			}
		}

		// Token: 0x1700167E RID: 5758
		// (get) Token: 0x06002CBE RID: 11454 RVA: 0x002B2F84 File Offset: 0x002B1184
		// (set) Token: 0x06002CBF RID: 11455 RVA: 0x002B303C File Offset: 0x002B123C
		internal bool RadWideBluetoothFriendlyName_A41181_HiddenStatic
		{
			get
			{
				short num = (short)1765368638;
				short num2 = num;
				num = (short)53633854;
				switch (num2 == num)
				{
				}
				num = (short)389218305;
				if (num != 0)
				{
				}
				num = (short)1546780672;
				short num3 = num;
				num = (short)302710784;
				if (num != 0)
				{
				}
				return this.radWideBluetoothFriendlyName_A41181.HiddenStatic;
			}
			set
			{
				short num = (short)2024043408;
				short num2 = num;
				num = (short)873100176;
				switch (num2 == num)
				{
				}
				num = (short)133562369;
				if (num != 0)
				{
				}
				num = (short)602210304;
				short num3 = num;
				num = (short)2049572864;
				if (num != 0)
				{
				}
				this.radWideBluetoothFriendlyName_A41181.HiddenStatic = value;
			}
		}

		// Token: 0x1700167F RID: 5759
		// (get) Token: 0x06002CC0 RID: 11456 RVA: 0x002B30F0 File Offset: 0x002B12F0
		// (set) Token: 0x06002CC1 RID: 11457 RVA: 0x002B31A4 File Offset: 0x002B13A4
		internal bool RadWideBluetoothFriendlyName_A41181_HiddenDynamic
		{
			get
			{
				short num = (short)8467308;
				short num2 = num;
				num = (short)293024620;
				switch (num2 == num)
				{
				}
				num = (short)873005056;
				if (num != 0)
				{
				}
				num = (short)1349124096;
				short num3 = num;
				num = (short)652738561;
				if (num != 0)
				{
				}
				return this.radWideBluetoothFriendlyName_A41181.HiddenDynamic;
			}
			set
			{
				short num = (short)1161487943;
				short num2 = num;
				num = (short)1954997831;
				switch (num2 == num)
				{
				}
				num = (short)605880321;
				if (num != 0)
				{
				}
				num = (short)1082064896;
				short num3 = num;
				num = (short)173867008;
				if (num != 0)
				{
				}
				this.radWideBluetoothFriendlyName_A41181.HiddenDynamic = value;
			}
		}

		// Token: 0x17001680 RID: 5760
		// (get) Token: 0x06002CC2 RID: 11458 RVA: 0x002B325C File Offset: 0x002B145C
		public bool RadWideBluetoothFriendlyName_A41181_HasDiffs
		{
			get
			{
				short num = (short)1461289957;
				short num2 = num;
				num = (short)1406370789;
				switch (num2 == num)
				{
				}
				num = (short)688521217;
				if (num != 0)
				{
				}
				num = (short)2065629184;
				short num3 = num;
				num = (short)884932608;
				if (num != 0)
				{
				}
				return this.radWideBluetoothFriendlyName_A41181._HasDiffs;
			}
		}

		// Token: 0x17001681 RID: 5761
		// (get) Token: 0x06002CC3 RID: 11459 RVA: 0x002B3310 File Offset: 0x002B1510
		// (set) Token: 0x06002CC4 RID: 11460 RVA: 0x002B33C4 File Offset: 0x002B15C4
		public bool RadWideBluetoothFriendlyNameEditable_A41182Value
		{
			get
			{
				short num = (short)328409301;
				short num2 = num;
				num = (short)1711218901;
				switch (num2 == num)
				{
				}
				num = (short)1847197697;
				if (num != 0)
				{
				}
				num = (short)235929600;
				short num3 = num;
				num = (short)777453568;
				if (num != 0)
				{
				}
				return this.radWideBluetoothFriendlyNameEditable_A41182.Value;
			}
			set
			{
				short num = (short)481868971;
				short num2 = num;
				num = (short)1961933995;
				switch (num2 == num)
				{
				}
				num = (short)319881216;
				if (num != 0)
				{
				}
				num = (short)53542912;
				short num3 = num;
				num = (short)561643521;
				if (num != 0)
				{
				}
				this.radWideBluetoothFriendlyNameEditable_A41182.Value = value;
			}
		}

		// Token: 0x17001682 RID: 5762
		// (get) Token: 0x06002CC5 RID: 11461 RVA: 0x002B3478 File Offset: 0x002B1678
		public global::AcpBusinessLayer.AcpField<bool> RadWideBluetoothFriendlyNameEditable_A41182
		{
			get
			{
				short num = (short)159941928;
				short num2 = num;
				num = (short)161842472;
				switch (num2 == num)
				{
				}
				num = (short)501415936;
				if (num != 0)
				{
				}
				num = (short)2118057984;
				short num3 = num;
				num = (short)977272833;
				if (num != 0)
				{
				}
				return this.radWideBluetoothFriendlyNameEditable_A41182;
			}
		}

		// Token: 0x17001683 RID: 5763
		// (get) Token: 0x06002CC6 RID: 11462 RVA: 0x002B3528 File Offset: 0x002B1728
		// (set) Token: 0x06002CC7 RID: 11463 RVA: 0x002B35DC File Offset: 0x002B17DC
		public bool RadWideBluetoothFriendlyNameEditable_A41182_UIValue
		{
			get
			{
				short num = (short)240084064;
				short num2 = num;
				num = (short)307258464;
				switch (num2 == num)
				{
				}
				num = (short)1396768769;
				if (num != 0)
				{
				}
				num = (short)776470528;
				short num3 = num;
				num = (short)1024655360;
				if (num != 0)
				{
				}
				return this.radWideBluetoothFriendlyNameEditable_A41182.Value;
			}
			set
			{
				short num = (short)1264145043;
				short num2 = num;
				num = (short)1415074451;
				switch (num2 == num)
				{
				}
				num = (short)591331329;
				if (num != 0)
				{
				}
				num = (short)118947840;
				short num3 = num;
				num = (short)368771072;
				if (num != 0)
				{
				}
				this.radWideBluetoothFriendlyNameEditable_A41182.Value = value;
			}
		}

		// Token: 0x17001684 RID: 5764
		// (get) Token: 0x06002CC8 RID: 11464 RVA: 0x002B3690 File Offset: 0x002B1890
		// (set) Token: 0x06002CC9 RID: 11465 RVA: 0x002B3744 File Offset: 0x002B1944
		public bool RadWideBluetoothFriendlyNameEditable_A41182_Applicable
		{
			get
			{
				short num = (short)1421449643;
				short num2 = num;
				num = (short)1341364651;
				switch (num2 == num)
				{
				}
				num = (short)491520000;
				if (num != 0)
				{
				}
				num = (short)266403840;
				short num3 = num;
				num = (short)761462785;
				if (num != 0)
				{
				}
				return this.radWideBluetoothFriendlyNameEditable_A41182.Applicable;
			}
			set
			{
				short num = (short)866900926;
				short num2 = num;
				num = (short)1977605054;
				switch (num2 == num)
				{
				}
				num = (short)908066817;
				if (num != 0)
				{
				}
				num = (short)1029505024;
				short num3 = num;
				num = (short)191627264;
				if (num != 0)
				{
				}
				this.radWideBluetoothFriendlyNameEditable_A41182.Applicable = value;
			}
		}

		// Token: 0x17001685 RID: 5765
		// (get) Token: 0x06002CCA RID: 11466 RVA: 0x002B37F4 File Offset: 0x002B19F4
		// (set) Token: 0x06002CCB RID: 11467 RVA: 0x002B38A8 File Offset: 0x002B1AA8
		public bool RadWideBluetoothFriendlyNameEditable_A41182_Valid
		{
			get
			{
				short num = (short)1859713497;
				short num2 = num;
				num = (short)1399912921;
				switch (num2 == num)
				{
				}
				num = (short)1137704961;
				if (num != 0)
				{
				}
				num = (short)787152896;
				short num3 = num;
				num = (short)1449066496;
				if (num != 0)
				{
				}
				return this.radWideBluetoothFriendlyNameEditable_A41182.Valid;
			}
			set
			{
				short num = (short)1417480641;
				short num2 = num;
				num = (short)734464449;
				switch (num2 == num)
				{
				}
				num = (short)1901461504;
				if (num != 0)
				{
				}
				num = (short)1520828416;
				short num3 = num;
				num = (short)495255553;
				if (num != 0)
				{
				}
				this.radWideBluetoothFriendlyNameEditable_A41182.Valid = value;
			}
		}

		// Token: 0x17001686 RID: 5766
		// (get) Token: 0x06002CCC RID: 11468 RVA: 0x002B3960 File Offset: 0x002B1B60
		// (set) Token: 0x06002CCD RID: 11469 RVA: 0x002B3A18 File Offset: 0x002B1C18
		public bool RadWideBluetoothFriendlyNameEditable_A41182_Visible
		{
			get
			{
				short num = (short)482759490;
				short num2 = num;
				num = (short)1839158082;
				switch (num2 == num)
				{
				}
				num = (short)1671495681;
				if (num != 0)
				{
				}
				num = (short)1995964416;
				short num3 = num;
				num = (short)663814144;
				if (num != 0)
				{
				}
				return this.radWideBluetoothFriendlyNameEditable_A41182.Visible;
			}
			set
			{
				short num = (short)1606288776;
				short num2 = num;
				num = (short)1166345608;
				switch (num2 == num)
				{
				}
				num = (short)719323136;
				if (num != 0)
				{
				}
				num = (short)774569984;
				short num3 = num;
				num = (short)29622273;
				if (num != 0)
				{
				}
				this.radWideBluetoothFriendlyNameEditable_A41182.Visible = value;
			}
		}

		// Token: 0x17001687 RID: 5767
		// (get) Token: 0x06002CCE RID: 11470 RVA: 0x002B3ACC File Offset: 0x002B1CCC
		// (set) Token: 0x06002CCF RID: 11471 RVA: 0x002B3B80 File Offset: 0x002B1D80
		public bool RadWideBluetoothFriendlyNameEditable_A41182_Editable
		{
			get
			{
				short num = (short)1215244736;
				short num2 = num;
				num = (short)516827584;
				switch (num2 == num)
				{
				}
				num = (short)1734279169;
				if (num != 0)
				{
				}
				num = (short)1742340096;
				short num3 = num;
				num = (short)2062221312;
				if (num != 0)
				{
				}
				return this.radWideBluetoothFriendlyNameEditable_A41182.Editable;
			}
			set
			{
				short num = (short)1568669697;
				if (num != 0)
				{
				}
				num = (short)1205272413;
				short num2 = num;
				num = (short)269942621;
				switch (num2 == num)
				{
				}
				num = (short)1410203648;
				short num3 = num;
				num = (short)2140536832;
				if (num != 0)
				{
				}
				this.radWideBluetoothFriendlyNameEditable_A41182.Editable = value;
			}
		}

		// Token: 0x17001688 RID: 5768
		// (get) Token: 0x06002CD0 RID: 11472 RVA: 0x002B3C38 File Offset: 0x002B1E38
		internal string RadWideBluetoothFriendlyNameEditable_A41182_UILabel
		{
			get
			{
				short num = (short)312868865;
				if (num != 0)
				{
				}
				num = (short)1363871069;
				short num2 = num;
				num = (short)349635933;
				switch (num2 == num)
				{
				}
				num = (short)1844445184;
				short num3 = num;
				num = (short)1024720896;
				if (num != 0)
				{
				}
				return this.radWideBluetoothFriendlyNameEditable_A41182.UIName;
			}
		}

		// Token: 0x17001689 RID: 5769
		// (get) Token: 0x06002CD1 RID: 11473 RVA: 0x002B3CF0 File Offset: 0x002B1EF0
		// (set) Token: 0x06002CD2 RID: 11474 RVA: 0x002B3DA4 File Offset: 0x002B1FA4
		internal bool RadWideBluetoothFriendlyNameEditable_A41182_HiddenStatic
		{
			get
			{
				short num = (short)1990406396;
				short num2 = num;
				num = (short)462827772;
				switch (num2 == num)
				{
				}
				num = (short)1843003393;
				if (num != 0)
				{
				}
				num = (short)843907072;
				short num3 = num;
				num = (short)1806827520;
				if (num != 0)
				{
				}
				return this.radWideBluetoothFriendlyNameEditable_A41182.HiddenStatic;
			}
			set
			{
				short num = (short)1953961091;
				short num2 = num;
				num = (short)2124944515;
				switch (num2 == num)
				{
				}
				num = (short)1410269184;
				if (num != 0)
				{
				}
				num = (short)1000472576;
				short num3 = num;
				num = (short)1675886593;
				if (num != 0)
				{
				}
				this.radWideBluetoothFriendlyNameEditable_A41182.HiddenStatic = value;
			}
		}

		// Token: 0x1700168A RID: 5770
		// (get) Token: 0x06002CD3 RID: 11475 RVA: 0x002B3E5C File Offset: 0x002B205C
		// (set) Token: 0x06002CD4 RID: 11476 RVA: 0x002B3F10 File Offset: 0x002B2110
		internal bool RadWideBluetoothFriendlyNameEditable_A41182_HiddenDynamic
		{
			get
			{
				short num = (short)456962588;
				short num2 = num;
				num = (short)2092085788;
				switch (num2 == num)
				{
				}
				num = (short)382599168;
				if (num != 0)
				{
				}
				num = (short)1525874688;
				short num3 = num;
				num = (short)181862401;
				if (num != 0)
				{
				}
				return this.radWideBluetoothFriendlyNameEditable_A41182.HiddenDynamic;
			}
			set
			{
				short num = (short)1937267480;
				short num2 = num;
				num = (short)572152600;
				switch (num2 == num)
				{
				}
				num = (short)710606848;
				if (num != 0)
				{
				}
				num = (short)837615616;
				short num3 = num;
				num = (short)1737228289;
				if (num != 0)
				{
				}
				this.radWideBluetoothFriendlyNameEditable_A41182.HiddenDynamic = value;
			}
		}

		// Token: 0x1700168B RID: 5771
		// (get) Token: 0x06002CD5 RID: 11477 RVA: 0x002B3FC8 File Offset: 0x002B21C8
		public bool RadWideBluetoothFriendlyNameEditable_A41182_HasDiffs
		{
			get
			{
				short num = (short)44738572;
				short num2 = num;
				num = (short)2066393100;
				switch (num2 == num)
				{
				}
				num = (short)319094784;
				if (num != 0)
				{
				}
				num = (short)392364032;
				short num3 = num;
				num = (short)320143361;
				if (num != 0)
				{
				}
				return this.radWideBluetoothFriendlyNameEditable_A41182._HasDiffs;
			}
		}

		// Token: 0x1700168C RID: 5772
		// (get) Token: 0x06002CD6 RID: 11478 RVA: 0x002B407C File Offset: 0x002B227C
		// (set) Token: 0x06002CD7 RID: 11479 RVA: 0x002B4130 File Offset: 0x002B2330
		public bool RadWideBluetoothReplacePairingInfo_A41562Value
		{
			get
			{
				short num = (short)264901790;
				short num2 = num;
				num = (short)1694438558;
				switch (num2 == num)
				{
				}
				num = (short)1091698688;
				if (num != 0)
				{
				}
				num = (short)1869938688;
				short num3 = num;
				num = (short)167116801;
				if (num != 0)
				{
				}
				return this.radWideBluetoothReplacePairingInfo_A41562.Value;
			}
			set
			{
				short num = (short)277724700;
				short num2 = num;
				num = (short)1710865948;
				switch (num2 == num)
				{
				}
				num = (short)1160839169;
				if (num != 0)
				{
				}
				num = (short)923860992;
				short num3 = num;
				num = (short)1657929728;
				if (num != 0)
				{
				}
				this.radWideBluetoothReplacePairingInfo_A41562.Value = value;
			}
		}

		// Token: 0x1700168D RID: 5773
		// (get) Token: 0x06002CD8 RID: 11480 RVA: 0x002B41E8 File Offset: 0x002B23E8
		public global::AcpBusinessLayer.AcpField<bool> RadWideBluetoothReplacePairingInfo_A41562
		{
			get
			{
				short num = (short)1168441345;
				if (num != 0)
				{
				}
				num = (short)436463549;
				short num2 = num;
				num = (short)2033444797;
				switch (num2 == num)
				{
				}
				num = (short)912392192;
				short num3 = num;
				num = (short)1136721920;
				if (num != 0)
				{
				}
				return this.radWideBluetoothReplacePairingInfo_A41562;
			}
		}

		// Token: 0x1700168E RID: 5774
		// (get) Token: 0x06002CD9 RID: 11481 RVA: 0x002B4298 File Offset: 0x002B2498
		// (set) Token: 0x06002CDA RID: 11482 RVA: 0x002B434C File Offset: 0x002B254C
		public bool RadWideBluetoothReplacePairingInfo_A41562_UIValue
		{
			get
			{
				short num = (short)948830328;
				short num2 = num;
				num = (short)847642744;
				switch (num2 == num)
				{
				}
				num = (short)1556938752;
				if (num != 0)
				{
				}
				num = (short)1669857280;
				short num3 = num;
				num = (short)774832129;
				if (num != 0)
				{
				}
				return this.radWideBluetoothReplacePairingInfo_A41562.Value;
			}
			set
			{
				short num = (short)149011322;
				short num2 = num;
				num = (short)711572346;
				switch (num2 == num)
				{
				}
				num = (short)13959169;
				if (num != 0)
				{
				}
				num = (short)385089536;
				short num3 = num;
				num = (short)1379794944;
				if (num != 0)
				{
				}
				this.radWideBluetoothReplacePairingInfo_A41562.Value = value;
			}
		}

		// Token: 0x1700168F RID: 5775
		// (get) Token: 0x06002CDB RID: 11483 RVA: 0x002B4400 File Offset: 0x002B2600
		// (set) Token: 0x06002CDC RID: 11484 RVA: 0x002B44B8 File Offset: 0x002B26B8
		public bool RadWideBluetoothReplacePairingInfo_A41562_Applicable
		{
			get
			{
				short num = (short)1863855753;
				short num2 = num;
				num = (short)795750025;
				switch (num2 == num)
				{
				}
				num = (short)1503854592;
				if (num != 0)
				{
				}
				num = (short)1092681728;
				short num3 = num;
				num = (short)965410817;
				if (num != 0)
				{
				}
				return this.radWideBluetoothReplacePairingInfo_A41562.Applicable;
			}
			set
			{
				short num = (short)1727645294;
				short num2 = num;
				num = (short)1878640238;
				switch (num2 == num)
				{
				}
				num = (short)1367080960;
				if (num != 0)
				{
				}
				num = (short)36896768;
				short num3 = num;
				num = (short)1142095873;
				if (num != 0)
				{
				}
				this.radWideBluetoothReplacePairingInfo_A41562.Applicable = value;
			}
		}

		// Token: 0x17001690 RID: 5776
		// (get) Token: 0x06002CDD RID: 11485 RVA: 0x002B456C File Offset: 0x002B276C
		// (set) Token: 0x06002CDE RID: 11486 RVA: 0x002B4620 File Offset: 0x002B2820
		public bool RadWideBluetoothReplacePairingInfo_A41562_Valid
		{
			get
			{
				short num = (short)76176288;
				short num2 = num;
				num = (short)2096782240;
				switch (num2 == num)
				{
				}
				num = (short)753336321;
				if (num != 0)
				{
				}
				num = (short)412483584;
				short num3 = num;
				num = (short)377552896;
				if (num != 0)
				{
				}
				return this.radWideBluetoothReplacePairingInfo_A41562.Valid;
			}
			set
			{
				short num = (short)1151117342;
				short num2 = num;
				num = (short)547989534;
				switch (num2 == num)
				{
				}
				num = (short)334233600;
				if (num != 0)
				{
				}
				num = (short)980877312;
				short num3 = num;
				num = (short)1003749377;
				if (num != 0)
				{
				}
				this.radWideBluetoothReplacePairingInfo_A41562.Valid = value;
			}
		}

		// Token: 0x17001691 RID: 5777
		// (get) Token: 0x06002CDF RID: 11487 RVA: 0x002B46D8 File Offset: 0x002B28D8
		// (set) Token: 0x06002CE0 RID: 11488 RVA: 0x002B478C File Offset: 0x002B298C
		public bool RadWideBluetoothReplacePairingInfo_A41562_Visible
		{
			get
			{
				short num = (short)926416897;
				if (num != 0)
				{
				}
				num = (short)1170965781;
				short num2 = num;
				num = (short)2000848149;
				switch (num2 == num)
				{
				}
				num = (short)1495465984;
				short num3 = num;
				num = (short)521535488;
				if (num != 0)
				{
				}
				return this.radWideBluetoothReplacePairingInfo_A41562.Visible;
			}
			set
			{
				short num = (short)629430717;
				short num2 = num;
				num = (short)41703869;
				switch (num2 == num)
				{
				}
				num = (short)1196163073;
				if (num != 0)
				{
				}
				num = (short)200933376;
				short num3 = num;
				num = (short)2139815936;
				if (num != 0)
				{
				}
				this.radWideBluetoothReplacePairingInfo_A41562.Visible = value;
			}
		}

		// Token: 0x17001692 RID: 5778
		// (get) Token: 0x06002CE1 RID: 11489 RVA: 0x002B4840 File Offset: 0x002B2A40
		// (set) Token: 0x06002CE2 RID: 11490 RVA: 0x002B48F4 File Offset: 0x002B2AF4
		public bool RadWideBluetoothReplacePairingInfo_A41562_Editable
		{
			get
			{
				short num = (short)1624628206;
				short num2 = num;
				num = (short)711121902;
				switch (num2 == num)
				{
				}
				num = (short)1842151425;
				if (num != 0)
				{
				}
				num = (short)1582366720;
				short num3 = num;
				num = (short)521994240;
				if (num != 0)
				{
				}
				return this.radWideBluetoothReplacePairingInfo_A41562.Editable;
			}
			set
			{
				short num = (short)1881462247;
				short num2 = num;
				num = (short)1214961127;
				switch (num2 == num)
				{
				}
				num = (short)1151795201;
				if (num != 0)
				{
				}
				num = (short)260964352;
				short num3 = num;
				num = (short)306577408;
				if (num != 0)
				{
				}
				this.radWideBluetoothReplacePairingInfo_A41562.Editable = value;
			}
		}

		// Token: 0x17001693 RID: 5779
		// (get) Token: 0x06002CE3 RID: 11491 RVA: 0x002B49A8 File Offset: 0x002B2BA8
		internal string RadWideBluetoothReplacePairingInfo_A41562_UILabel
		{
			get
			{
				short num = (short)1559314065;
				short num2 = num;
				num = (short)1051934353;
				switch (num2 == num)
				{
				}
				num = (short)375980033;
				if (num != 0)
				{
				}
				num = (short)113901568;
				short num3 = num;
				num = (short)318832640;
				if (num != 0)
				{
				}
				return this.radWideBluetoothReplacePairingInfo_A41562.UIName;
			}
		}

		// Token: 0x17001694 RID: 5780
		// (get) Token: 0x06002CE4 RID: 11492 RVA: 0x002B4A5C File Offset: 0x002B2C5C
		// (set) Token: 0x06002CE5 RID: 11493 RVA: 0x002B4B10 File Offset: 0x002B2D10
		internal bool RadWideBluetoothReplacePairingInfo_A41562_HiddenStatic
		{
			get
			{
				short num = (short)733634980;
				short num2 = num;
				num = (short)2025218468;
				switch (num2 == num)
				{
				}
				num = (short)1247805441;
				if (num != 0)
				{
				}
				num = (short)715390976;
				short num3 = num;
				num = (short)1819148288;
				if (num != 0)
				{
				}
				return this.radWideBluetoothReplacePairingInfo_A41562.HiddenStatic;
			}
			set
			{
				short num = (short)2040942278;
				short num2 = num;
				num = (short)495865542;
				switch (num2 == num)
				{
				}
				num = (short)1060306945;
				if (num != 0)
				{
				}
				num = (short)2041446400;
				short num3 = num;
				num = (short)2059796480;
				if (num != 0)
				{
				}
				this.radWideBluetoothReplacePairingInfo_A41562.HiddenStatic = value;
			}
		}

		// Token: 0x17001695 RID: 5781
		// (get) Token: 0x06002CE6 RID: 11494 RVA: 0x002B4BC4 File Offset: 0x002B2DC4
		// (set) Token: 0x06002CE7 RID: 11495 RVA: 0x002B4C78 File Offset: 0x002B2E78
		internal bool RadWideBluetoothReplacePairingInfo_A41562_HiddenDynamic
		{
			get
			{
				short num = (short)1576271873;
				if (num != 0)
				{
				}
				num = (short)1961148093;
				short num2 = num;
				num = (short)1877982909;
				switch (num2 == num)
				{
				}
				num = (short)794624000;
				short num3 = num;
				num = (short)839581696;
				if (num != 0)
				{
				}
				return this.radWideBluetoothReplacePairingInfo_A41562.HiddenDynamic;
			}
			set
			{
				short num = (short)148391997;
				short num2 = num;
				num = (short)962218045;
				switch (num2 == num)
				{
				}
				num = (short)1578762241;
				if (num != 0)
				{
				}
				num = (short)228524032;
				short num3 = num;
				num = (short)640286720;
				if (num != 0)
				{
				}
				this.radWideBluetoothReplacePairingInfo_A41562.HiddenDynamic = value;
			}
		}

		// Token: 0x17001696 RID: 5782
		// (get) Token: 0x06002CE8 RID: 11496 RVA: 0x002B4D30 File Offset: 0x002B2F30
		public bool RadWideBluetoothReplacePairingInfo_A41562_HasDiffs
		{
			get
			{
				short num = (short)256053465;
				short num2 = num;
				num = (short)467603673;
				switch (num2 == num)
				{
				}
				num = (short)1589772289;
				if (num != 0)
				{
				}
				num = (short)1946550272;
				short num3 = num;
				num = (short)695468032;
				if (num != 0)
				{
				}
				return this.radWideBluetoothReplacePairingInfo_A41562._HasDiffs;
			}
		}

		// Token: 0x17001697 RID: 5783
		// (get) Token: 0x06002CE9 RID: 11497 RVA: 0x002B4DE4 File Offset: 0x002B2FE4
		// (set) Token: 0x06002CEA RID: 11498 RVA: 0x002B4E98 File Offset: 0x002B3098
		public bool RadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576Value
		{
			get
			{
				short num = (short)1153302529;
				if (num != 0)
				{
				}
				num = (short)1751826250;
				short num2 = num;
				num = (short)2051129162;
				switch (num2 == num)
				{
				}
				num = (short)1483538432;
				short num3 = num;
				num = (short)524877824;
				if (num != 0)
				{
				}
				return this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.Value;
			}
			set
			{
				short num = (short)1399661425;
				short num2 = num;
				num = (short)541533041;
				switch (num2 == num)
				{
				}
				num = (short)1617625089;
				if (num != 0)
				{
				}
				num = (short)1599602688;
				short num3 = num;
				num = (short)712507392;
				if (num != 0)
				{
				}
				this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.Value = value;
			}
		}

		// Token: 0x17001698 RID: 5784
		// (get) Token: 0x06002CEB RID: 11499 RVA: 0x002B4F50 File Offset: 0x002B3150
		public global::AcpBusinessLayer.AcpField<bool> RadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576
		{
			get
			{
				short num = (short)24224317;
				short num2 = num;
				num = (short)633774653;
				switch (num2 == num)
				{
				}
				num = (short)1623064576;
				if (num != 0)
				{
				}
				num = (short)1063321600;
				short num3 = num;
				num = (short)922222593;
				if (num != 0)
				{
				}
				return this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576;
			}
		}

		// Token: 0x17001699 RID: 5785
		// (get) Token: 0x06002CEC RID: 11500 RVA: 0x002B5000 File Offset: 0x002B3200
		// (set) Token: 0x06002CED RID: 11501 RVA: 0x002B50B4 File Offset: 0x002B32B4
		public bool RadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576_UIValue
		{
			get
			{
				short num = (short)78239723;
				short num2 = num;
				num = (short)1438832619;
				switch (num2 == num)
				{
				}
				num = (short)239271937;
				if (num != 0)
				{
				}
				num = (short)1282277376;
				short num3 = num;
				num = (short)934608896;
				if (num != 0)
				{
				}
				return this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.Value;
			}
			set
			{
				short num = (short)983870945;
				short num2 = num;
				num = (short)1057271265;
				switch (num2 == num)
				{
				}
				num = (short)1429471233;
				if (num != 0)
				{
				}
				num = (short)1234698240;
				short num3 = num;
				num = (short)799211520;
				if (num != 0)
				{
				}
				this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.Value = value;
			}
		}

		// Token: 0x1700169A RID: 5786
		// (get) Token: 0x06002CEE RID: 11502 RVA: 0x002B5168 File Offset: 0x002B3368
		// (set) Token: 0x06002CEF RID: 11503 RVA: 0x002B5218 File Offset: 0x002B3418
		public bool RadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576_Applicable
		{
			get
			{
				short num = (short)653381094;
				short num2 = num;
				num = (short)1432931814;
				switch (num2 == num)
				{
				}
				num = (short)787283968;
				if (num != 0)
				{
				}
				num = (short)1815019520;
				short num3 = num;
				num = (short)868089857;
				if (num != 0)
				{
				}
				return this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.Applicable;
			}
			set
			{
				short num = (short)1163512734;
				short num2 = num;
				num = (short)1163250590;
				switch (num2 == num)
				{
				}
				num = (short)2101149697;
				if (num != 0)
				{
				}
				num = (short)1656160256;
				short num3 = num;
				num = (short)359530496;
				if (num != 0)
				{
				}
				this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.Applicable = value;
			}
		}

		// Token: 0x1700169B RID: 5787
		// (get) Token: 0x06002CF0 RID: 11504 RVA: 0x002B52CC File Offset: 0x002B34CC
		// (set) Token: 0x06002CF1 RID: 11505 RVA: 0x002B5380 File Offset: 0x002B3580
		public bool RadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576_Valid
		{
			get
			{
				short num = (short)610799083;
				short num2 = num;
				num = (short)1803292139;
				switch (num2 == num)
				{
				}
				num = (short)384565249;
				if (num != 0)
				{
				}
				num = (short)42663936;
				short num3 = num;
				num = (short)601686016;
				if (num != 0)
				{
				}
				return this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.Valid;
			}
			set
			{
				short num = (short)464282011;
				short num2 = num;
				num = (short)1451712923;
				switch (num2 == num)
				{
				}
				num = (short)641794049;
				if (num != 0)
				{
				}
				num = (short)1686503424;
				short num3 = num;
				num = (short)935985152;
				if (num != 0)
				{
				}
				this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.Valid = value;
			}
		}

		// Token: 0x1700169C RID: 5788
		// (get) Token: 0x06002CF2 RID: 11506 RVA: 0x002B5438 File Offset: 0x002B3638
		// (set) Token: 0x06002CF3 RID: 11507 RVA: 0x002B54EC File Offset: 0x002B36EC
		public bool RadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576_Visible
		{
			get
			{
				short num = (short)1826847457;
				short num2 = num;
				num = (short)1837726433;
				switch (num2 == num)
				{
				}
				num = (short)1418657792;
				if (num != 0)
				{
				}
				num = (short)926023680;
				short num3 = num;
				num = (short)1813970945;
				if (num != 0)
				{
				}
				return this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.Visible;
			}
			set
			{
				short num = (short)2079139683;
				short num2 = num;
				num = (short)897132387;
				switch (num2 == num)
				{
				}
				num = (short)1106706433;
				if (num != 0)
				{
				}
				num = (short)143851520;
				short num3 = num;
				num = (short)849739776;
				if (num != 0)
				{
				}
				this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.Visible = value;
			}
		}

		// Token: 0x1700169D RID: 5789
		// (get) Token: 0x06002CF4 RID: 11508 RVA: 0x002B55A0 File Offset: 0x002B37A0
		// (set) Token: 0x06002CF5 RID: 11509 RVA: 0x002B5654 File Offset: 0x002B3854
		public bool RadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576_Editable
		{
			get
			{
				short num = (short)1818165249;
				if (num != 0)
				{
				}
				num = (short)510216128;
				short num2 = num;
				num = (short)1117145024;
				switch (num2 == num)
				{
				}
				num = (short)870842368;
				short num3 = num;
				num = (short)1152909312;
				if (num != 0)
				{
				}
				return this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.Editable;
			}
			set
			{
				short num = (short)1327673633;
				short num2 = num;
				num = (short)105099553;
				switch (num2 == num)
				{
				}
				num = (short)356843521;
				if (num != 0)
				{
				}
				num = (short)1347354624;
				short num3 = num;
				num = (short)2125856768;
				if (num != 0)
				{
				}
				this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.Editable = value;
			}
		}

		// Token: 0x1700169E RID: 5790
		// (get) Token: 0x06002CF6 RID: 11510 RVA: 0x002B570C File Offset: 0x002B390C
		internal string RadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576_UILabel
		{
			get
			{
				short num = (short)328800376;
				short num2 = num;
				num = (short)991893624;
				switch (num2 == num)
				{
				}
				num = (short)950337537;
				if (num != 0)
				{
				}
				num = (short)1170210816;
				short num3 = num;
				num = (short)1149370368;
				if (num != 0)
				{
				}
				return this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.UIName;
			}
		}

		// Token: 0x1700169F RID: 5791
		// (get) Token: 0x06002CF7 RID: 11511 RVA: 0x002B57C0 File Offset: 0x002B39C0
		// (set) Token: 0x06002CF8 RID: 11512 RVA: 0x002B5870 File Offset: 0x002B3A70
		internal bool RadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576_HiddenStatic
		{
			get
			{
				short num = (short)661979137;
				if (num != 0)
				{
				}
				num = (short)1274514272;
				short num2 = num;
				num = (short)1031703392;
				switch (num2 == num)
				{
				}
				num = (short)985858048;
				short num3 = num;
				num = (short)1120337920;
				if (num != 0)
				{
				}
				return this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.HiddenStatic;
			}
			set
			{
				short num = (short)14537129;
				short num2 = num;
				num = (short)308662697;
				switch (num2 == num)
				{
				}
				num = (short)907935745;
				if (num != 0)
				{
				}
				num = (short)154009600;
				short num3 = num;
				num = (short)531365888;
				if (num != 0)
				{
				}
				this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.HiddenStatic = value;
			}
		}

		// Token: 0x170016A0 RID: 5792
		// (get) Token: 0x06002CF9 RID: 11513 RVA: 0x002B5924 File Offset: 0x002B3B24
		// (set) Token: 0x06002CFA RID: 11514 RVA: 0x002B59D8 File Offset: 0x002B3BD8
		internal bool RadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576_HiddenDynamic
		{
			get
			{
				short num = (short)366659017;
				short num2 = num;
				num = (short)547997129;
				switch (num2 == num)
				{
				}
				num = (short)1632043009;
				if (num != 0)
				{
				}
				num = (short)205783040;
				short num3 = num;
				num = (short)990117888;
				if (num != 0)
				{
				}
				return this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.HiddenDynamic;
			}
			set
			{
				short num = (short)551500055;
				short num2 = num;
				num = (short)1362704663;
				switch (num2 == num)
				{
				}
				num = (short)910950401;
				if (num != 0)
				{
				}
				num = (short)851574784;
				short num3 = num;
				num = (short)860749824;
				if (num != 0)
				{
				}
				this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.HiddenDynamic = value;
			}
		}

		// Token: 0x170016A1 RID: 5793
		// (get) Token: 0x06002CFB RID: 11515 RVA: 0x002B5A90 File Offset: 0x002B3C90
		public bool RadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576_HasDiffs
		{
			get
			{
				short num = (short)43629619;
				short num2 = num;
				num = (short)707116083;
				switch (num2 == num)
				{
				}
				num = (short)1182662656;
				short num3 = num;
				num = (short)386007041;
				if (num != 0)
				{
				}
				num = (short)791478272;
				if (num != 0)
				{
				}
				return this.radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576._HasDiffs;
			}
		}

		// Token: 0x170016A2 RID: 5794
		// (get) Token: 0x06002CFC RID: 11516 RVA: 0x002B5B44 File Offset: 0x002B3D44
		// (set) Token: 0x06002CFD RID: 11517 RVA: 0x002B5BF8 File Offset: 0x002B3DF8
		public int RadWideBluetoothBluetoothDeviceInquiryDuration_41977Value
		{
			get
			{
				short num = (short)110545326;
				short num2 = num;
				num = (short)625068462;
				switch (num2 == num)
				{
				}
				num = (short)1258094592;
				short num3 = num;
				num = (short)1735524352;
				if (num != 0)
				{
				}
				num = (short)891617281;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.Value;
			}
			set
			{
				short num = (short)595015127;
				short num2 = num;
				num = (short)158152151;
				switch (num2 == num)
				{
				}
				num = (short)384761856;
				short num3 = num;
				num = (short)1972699137;
				if (num != 0)
				{
				}
				num = (short)2064449536;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.Value = value;
			}
		}

		// Token: 0x170016A3 RID: 5795
		// (get) Token: 0x06002CFE RID: 11518 RVA: 0x002B5CAC File Offset: 0x002B3EAC
		public global::AcpBusinessLayer.AcpCustomRangeField RadWideBluetoothBluetoothDeviceInquiryDuration_41977
		{
			get
			{
				short num = (short)1050774565;
				short num2 = num;
				num = (short)317426725;
				switch (num2 == num)
				{
				}
				num = (short)1861746688;
				short num3 = num;
				num = (short)1727266817;
				if (num != 0)
				{
				}
				num = (short)1638793216;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDeviceInquiryDuration_41977;
			}
		}

		// Token: 0x170016A4 RID: 5796
		// (get) Token: 0x06002CFF RID: 11519 RVA: 0x002B5D58 File Offset: 0x002B3F58
		// (set) Token: 0x06002D00 RID: 11520 RVA: 0x002B5E0C File Offset: 0x002B400C
		public string RadWideBluetoothBluetoothDeviceInquiryDuration_41977_UIValue
		{
			get
			{
				short num = (short)1018117642;
				short num2 = num;
				num = (short)646856202;
				switch (num2 == num)
				{
				}
				num = (short)229965824;
				short num3 = num;
				num = (short)821821441;
				if (num != 0)
				{
				}
				num = (short)1111228416;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.UIValue;
			}
			set
			{
				short num = (short)458503072;
				short num2 = num;
				num = (short)185021344;
				switch (num2 == num)
				{
				}
				num = (short)460455936;
				short num3 = num;
				num = (short)610271232;
				if (num != 0)
				{
				}
				num = (short)1087963137;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.UIValue = value;
			}
		}

		// Token: 0x170016A5 RID: 5797
		// (get) Token: 0x06002D01 RID: 11521 RVA: 0x002B5EC0 File Offset: 0x002B40C0
		// (set) Token: 0x06002D02 RID: 11522 RVA: 0x002B5F74 File Offset: 0x002B4174
		internal int RadWideBluetoothBluetoothDeviceInquiryDuration_41977Min
		{
			get
			{
				short num = (short)1077834948;
				short num2 = num;
				num = (short)1743418564;
				switch (num2 == num)
				{
				}
				num = (short)708378624;
				short num3 = num;
				num = (short)655687681;
				if (num != 0)
				{
				}
				num = (short)1963524096;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.Min;
			}
			set
			{
				short num = (short)1488191489;
				if (num != 0)
				{
				}
				num = (short)423014403;
				short num2 = num;
				num = (short)1006284803;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2076180480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)912916480;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.Min = value;
			}
		}

		// Token: 0x170016A6 RID: 5798
		// (get) Token: 0x06002D03 RID: 11523 RVA: 0x002B6028 File Offset: 0x002B4228
		// (set) Token: 0x06002D04 RID: 11524 RVA: 0x002B60DC File Offset: 0x002B42DC
		internal int RadWideBluetoothBluetoothDeviceInquiryDuration_41977Max
		{
			get
			{
				short num = (short)1858928641;
				if (num != 0)
				{
				}
				num = (short)2024175444;
				short num2 = num;
				num = (short)996833108;
				switch (num2 == num)
				{
				default:
				{
					num = (short)983498752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)457179136;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.Max;
			}
			set
			{
				short num = (short)1819946913;
				short num2 = num;
				num = (short)940126113;
				switch (num2 == num)
				{
				}
				num = (short)374931456;
				short num3 = num;
				num = (short)730333185;
				if (num != 0)
				{
				}
				num = (short)1046609920;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.Max = value;
			}
		}

		// Token: 0x170016A7 RID: 5799
		// (get) Token: 0x06002D05 RID: 11525 RVA: 0x002B6190 File Offset: 0x002B4390
		// (set) Token: 0x06002D06 RID: 11526 RVA: 0x002B6244 File Offset: 0x002B4444
		internal int RadWideBluetoothBluetoothDeviceInquiryDuration_41977Step
		{
			get
			{
				short num = (short)1340205871;
				short num2 = num;
				num = (short)973400879;
				switch (num2 == num)
				{
				}
				num = (short)185597952;
				short num3 = num;
				num = (short)4653057;
				if (num != 0)
				{
				}
				num = (short)2293760;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.StepSize;
			}
			set
			{
				short num = (short)1465884088;
				short num2 = num;
				num = (short)1939316152;
				switch (num2 == num)
				{
				}
				num = (short)1868759040;
				short num3 = num;
				num = (short)1599995905;
				if (num != 0)
				{
				}
				num = (short)359661568;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.StepSize = value;
			}
		}

		// Token: 0x170016A8 RID: 5800
		// (get) Token: 0x06002D07 RID: 11527 RVA: 0x002B62F8 File Offset: 0x002B44F8
		// (set) Token: 0x06002D08 RID: 11528 RVA: 0x002B63B0 File Offset: 0x002B45B0
		public bool RadWideBluetoothBluetoothDeviceInquiryDuration_41977_Applicable
		{
			get
			{
				short num = (short)850310806;
				short num2 = num;
				num = (short)94156438;
				switch (num2 == num)
				{
				}
				num = (short)31719424;
				short num3 = num;
				num = (short)1084489729;
				if (num != 0)
				{
				}
				num = (short)353107968;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.Applicable;
			}
			set
			{
				short num = (short)65958462;
				short num2 = num;
				num = (short)366178878;
				switch (num2 == num)
				{
				}
				num = (short)43909120;
				short num3 = num;
				num = (short)323026945;
				if (num != 0)
				{
				}
				num = (short)2055143424;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.Applicable = value;
			}
		}

		// Token: 0x170016A9 RID: 5801
		// (get) Token: 0x06002D09 RID: 11529 RVA: 0x002B6464 File Offset: 0x002B4664
		// (set) Token: 0x06002D0A RID: 11530 RVA: 0x002B6518 File Offset: 0x002B4718
		public bool RadWideBluetoothBluetoothDeviceInquiryDuration_41977_Valid
		{
			get
			{
				short num = (short)369478725;
				short num2 = num;
				num = (short)1628359749;
				switch (num2 == num)
				{
				}
				num = (short)222691328;
				short num3 = num;
				num = (short)136773633;
				if (num != 0)
				{
				}
				num = (short)2049769472;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.Valid;
			}
			set
			{
				short num = (short)199860547;
				short num2 = num;
				num = (short)2044698947;
				switch (num2 == num)
				{
				}
				num = (short)1764163584;
				short num3 = num;
				num = (short)1948188672;
				if (num != 0)
				{
				}
				num = (short)2043412481;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.Valid = value;
			}
		}

		// Token: 0x170016AA RID: 5802
		// (get) Token: 0x06002D0B RID: 11531 RVA: 0x002B65CC File Offset: 0x002B47CC
		// (set) Token: 0x06002D0C RID: 11532 RVA: 0x002B6684 File Offset: 0x002B4884
		public bool RadWideBluetoothBluetoothDeviceInquiryDuration_41977_Visible
		{
			get
			{
				short num = (short)1409588173;
				short num2 = num;
				num = (short)1460116429;
				switch (num2 == num)
				{
				}
				num = (short)292290560;
				short num3 = num;
				num = (short)1178927104;
				if (num != 0)
				{
				}
				num = (short)990838785;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.Visible;
			}
			set
			{
				short num = (short)1441694875;
				short num2 = num;
				num = (short)376603803;
				switch (num2 == num)
				{
				}
				num = (short)960364544;
				short num3 = num;
				num = (short)175505409;
				if (num != 0)
				{
				}
				num = (short)1861746688;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.Visible = value;
			}
		}

		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x06002D0D RID: 11533 RVA: 0x002B673C File Offset: 0x002B493C
		// (set) Token: 0x06002D0E RID: 11534 RVA: 0x002B67F0 File Offset: 0x002B49F0
		public bool RadWideBluetoothBluetoothDeviceInquiryDuration_41977_Editable
		{
			get
			{
				short num = (short)863502337;
				if (num != 0)
				{
				}
				num = (short)1393455712;
				short num2 = num;
				num = (short)870871648;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1509818368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1745354752;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.Editable;
			}
			set
			{
				short num = (short)1022092848;
				short num2 = num;
				num = (short)2143675952;
				switch (num2 == num)
				{
				}
				num = (short)1274478592;
				short num3 = num;
				num = (short)988610561;
				if (num != 0)
				{
				}
				num = (short)1976565760;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.Editable = value;
			}
		}

		// Token: 0x170016AC RID: 5804
		// (get) Token: 0x06002D0F RID: 11535 RVA: 0x002B68A4 File Offset: 0x002B4AA4
		internal string RadWideBluetoothBluetoothDeviceInquiryDuration_41977_UILabel
		{
			get
			{
				short num = (short)344013275;
				short num2 = num;
				num = (short)1563965915;
				switch (num2 == num)
				{
				}
				num = (short)450494464;
				short num3 = num;
				num = (short)1813250049;
				if (num != 0)
				{
				}
				num = (short)1372520448;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.UIName;
			}
		}

		// Token: 0x170016AD RID: 5805
		// (get) Token: 0x06002D10 RID: 11536 RVA: 0x002B6958 File Offset: 0x002B4B58
		// (set) Token: 0x06002D11 RID: 11537 RVA: 0x002B6A0C File Offset: 0x002B4C0C
		internal bool RadWideBluetoothBluetoothDeviceInquiryDuration_41977_HiddenStatic
		{
			get
			{
				short num = (short)579600385;
				if (num != 0)
				{
				}
				num = (short)483734161;
				short num2 = num;
				num = (short)742404753;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1018232832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)806027264;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.HiddenStatic;
			}
			set
			{
				short num = (short)1106636763;
				short num2 = num;
				num = (short)792326107;
				switch (num2 == num)
				{
				}
				num = (short)957939712;
				short num3 = num;
				num = (short)1003487232;
				if (num != 0)
				{
				}
				num = (short)1052246017;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.HiddenStatic = value;
			}
		}

		// Token: 0x170016AE RID: 5806
		// (get) Token: 0x06002D12 RID: 11538 RVA: 0x002B6AC0 File Offset: 0x002B4CC0
		// (set) Token: 0x06002D13 RID: 11539 RVA: 0x002B6B74 File Offset: 0x002B4D74
		internal bool RadWideBluetoothBluetoothDeviceInquiryDuration_41977_HiddenDynamic
		{
			get
			{
				short num = (short)660349085;
				short num2 = num;
				num = (short)935141533;
				switch (num2 == num)
				{
				}
				num = (short)1274478592;
				short num3 = num;
				num = (short)862322689;
				if (num != 0)
				{
				}
				num = (short)745013248;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.HiddenDynamic;
			}
			set
			{
				short num = (short)134243538;
				short num2 = num;
				num = (short)1122919634;
				switch (num2 == num)
				{
				}
				num = (short)1196490752;
				short num3 = num;
				num = (short)1754398721;
				if (num != 0)
				{
				}
				num = (short)2053636096;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDeviceInquiryDuration_41977.HiddenDynamic = value;
			}
		}

		// Token: 0x170016AF RID: 5807
		// (get) Token: 0x06002D14 RID: 11540 RVA: 0x002B6C2C File Offset: 0x002B4E2C
		public bool RadWideBluetoothBluetoothDeviceInquiryDuration_41977_HasDiffs
		{
			get
			{
				short num = (short)1987174591;
				short num2 = num;
				num = (short)1123082431;
				switch (num2 == num)
				{
				}
				num = (short)759169024;
				short num3 = num;
				num = (short)1127743489;
				if (num != 0)
				{
				}
				num = (short)464388096;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDeviceInquiryDuration_41977._HasDiffs;
			}
		}

		// Token: 0x170016B0 RID: 5808
		// (get) Token: 0x06002D15 RID: 11541 RVA: 0x002B6CE0 File Offset: 0x002B4EE0
		// (set) Token: 0x06002D16 RID: 11542 RVA: 0x002B6D94 File Offset: 0x002B4F94
		public int RadWideBluetoothBluetoothDiscoverableExpirationTimer_41980Value
		{
			get
			{
				short num = (short)660177082;
				short num2 = num;
				num = (short)410550458;
				switch (num2 == num)
				{
				}
				num = (short)2143420416;
				short num3 = num;
				num = (short)1154023425;
				if (num != 0)
				{
				}
				num = (short)2010447872;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.Value;
			}
			set
			{
				short num = (short)68828500;
				short num2 = num;
				num = (short)940850516;
				switch (num2 == num)
				{
				}
				num = (short)66519040;
				short num3 = num;
				num = (short)1307377664;
				if (num != 0)
				{
				}
				num = (short)1704722433;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.Value = value;
			}
		}

		// Token: 0x170016B1 RID: 5809
		// (get) Token: 0x06002D17 RID: 11543 RVA: 0x002B6E4C File Offset: 0x002B504C
		public global::AcpBusinessLayer.AcpSimpleRangeField RadWideBluetoothBluetoothDiscoverableExpirationTimer_41980
		{
			get
			{
				short num = (short)863021212;
				short num2 = num;
				num = (short)1557702812;
				switch (num2 == num)
				{
				}
				num = (short)1992491008;
				short num3 = num;
				num = (short)2058420225;
				if (num != 0)
				{
				}
				num = (short)876216320;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980;
			}
		}

		// Token: 0x170016B2 RID: 5810
		// (get) Token: 0x06002D18 RID: 11544 RVA: 0x002B6EFC File Offset: 0x002B50FC
		// (set) Token: 0x06002D19 RID: 11545 RVA: 0x002B6FB0 File Offset: 0x002B51B0
		public string RadWideBluetoothBluetoothDiscoverableExpirationTimer_41980_UIValue
		{
			get
			{
				short num = (short)1472266241;
				if (num != 0)
				{
				}
				num = (short)314098549;
				short num2 = num;
				num = (short)1458815861;
				switch (num2 == num)
				{
				default:
				{
					num = (short)182059008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)767688704;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.UIValue;
			}
			set
			{
				short num = (short)1761233542;
				short num2 = num;
				num = (short)644500102;
				switch (num2 == num)
				{
				}
				num = (short)1268252672;
				short num3 = num;
				num = (short)898039809;
				if (num != 0)
				{
				}
				num = (short)2007433216;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.UIValue = value;
			}
		}

		// Token: 0x170016B3 RID: 5811
		// (get) Token: 0x06002D1A RID: 11546 RVA: 0x002B7064 File Offset: 0x002B5264
		// (set) Token: 0x06002D1B RID: 11547 RVA: 0x002B7118 File Offset: 0x002B5318
		internal int RadWideBluetoothBluetoothDiscoverableExpirationTimer_41980Min
		{
			get
			{
				short num = (short)520290305;
				if (num != 0)
				{
				}
				num = (short)1425763559;
				short num2 = num;
				num = (short)1741122791;
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
				num = (short)2050949120;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.Min;
			}
			set
			{
				short num = (short)129801178;
				short num2 = num;
				num = (short)623746010;
				switch (num2 == num)
				{
				}
				num = (short)1843920896;
				short num3 = num;
				num = (short)945160192;
				if (num != 0)
				{
				}
				num = (short)544014337;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.Min = value;
			}
		}

		// Token: 0x170016B4 RID: 5812
		// (get) Token: 0x06002D1C RID: 11548 RVA: 0x002B71D0 File Offset: 0x002B53D0
		// (set) Token: 0x06002D1D RID: 11549 RVA: 0x002B7288 File Offset: 0x002B5488
		internal int RadWideBluetoothBluetoothDiscoverableExpirationTimer_41980Max
		{
			get
			{
				short num = (short)1388254638;
				short num2 = num;
				num = (short)953882030;
				switch (num2 == num)
				{
				}
				num = (short)828833792;
				short num3 = num;
				num = (short)1817247744;
				if (num != 0)
				{
				}
				num = (short)1557856257;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.Max;
			}
			set
			{
				short num = (short)779092617;
				short num2 = num;
				num = (short)1770324617;
				switch (num2 == num)
				{
				}
				num = (short)1237188608;
				short num3 = num;
				num = (short)1924333568;
				if (num != 0)
				{
				}
				num = (short)119144449;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.Max = value;
			}
		}

		// Token: 0x170016B5 RID: 5813
		// (get) Token: 0x06002D1E RID: 11550 RVA: 0x002B7340 File Offset: 0x002B5540
		// (set) Token: 0x06002D1F RID: 11551 RVA: 0x002B73F8 File Offset: 0x002B55F8
		internal int RadWideBluetoothBluetoothDiscoverableExpirationTimer_41980Step
		{
			get
			{
				short num = (short)2027585167;
				short num2 = num;
				num = (short)801668751;
				switch (num2 == num)
				{
				}
				num = (short)1506934784;
				short num3 = num;
				num = (short)362086401;
				if (num != 0)
				{
				}
				num = (short)1916600320;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.StepSize;
			}
			set
			{
				short num = (short)343661313;
				short num2 = num;
				num = (short)286710529;
				switch (num2 == num)
				{
				}
				num = (short)1149173760;
				short num3 = num;
				num = (short)1161756673;
				if (num != 0)
				{
				}
				num = (short)526188544;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.StepSize = value;
			}
		}

		// Token: 0x170016B6 RID: 5814
		// (get) Token: 0x06002D20 RID: 11552 RVA: 0x002B74AC File Offset: 0x002B56AC
		// (set) Token: 0x06002D21 RID: 11553 RVA: 0x002B7560 File Offset: 0x002B5760
		public bool RadWideBluetoothBluetoothDiscoverableExpirationTimer_41980_Applicable
		{
			get
			{
				short num = (short)2107781925;
				short num2 = num;
				num = (short)836776741;
				switch (num2 == num)
				{
				}
				num = (short)1183055872;
				short num3 = num;
				num = (short)84213761;
				if (num != 0)
				{
				}
				num = (short)907411456;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.Applicable;
			}
			set
			{
				short num = (short)771548518;
				short num2 = num;
				num = (short)1882711398;
				switch (num2 == num)
				{
				}
				num = (short)1525809152;
				short num3 = num;
				num = (short)685965312;
				if (num != 0)
				{
				}
				num = (short)252444673;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.Applicable = value;
			}
		}

		// Token: 0x170016B7 RID: 5815
		// (get) Token: 0x06002D22 RID: 11554 RVA: 0x002B7614 File Offset: 0x002B5814
		// (set) Token: 0x06002D23 RID: 11555 RVA: 0x002B76C8 File Offset: 0x002B58C8
		public bool RadWideBluetoothBluetoothDiscoverableExpirationTimer_41980_Valid
		{
			get
			{
				short num = (short)1292173313;
				if (num != 0)
				{
				}
				num = (short)1289907868;
				short num2 = num;
				num = (short)78278300;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1645412352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2060386304;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.Valid;
			}
			set
			{
				short num = (short)541392897;
				if (num != 0)
				{
				}
				num = (short)365781799;
				short num2 = num;
				num = (short)454648615;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2089943040;
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
				this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.Valid = value;
			}
		}

		// Token: 0x170016B8 RID: 5816
		// (get) Token: 0x06002D24 RID: 11556 RVA: 0x002B7780 File Offset: 0x002B5980
		// (set) Token: 0x06002D25 RID: 11557 RVA: 0x002B7838 File Offset: 0x002B5A38
		public bool RadWideBluetoothBluetoothDiscoverableExpirationTimer_41980_Visible
		{
			get
			{
				short num = (short)303103453;
				short num2 = num;
				num = (short)1972764125;
				switch (num2 == num)
				{
				}
				num = (short)1561526272;
				short num3 = num;
				num = (short)957874177;
				if (num != 0)
				{
				}
				num = (short)153419776;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.Visible;
			}
			set
			{
				short num = (short)1128421009;
				short num2 = num;
				num = (short)821384849;
				switch (num2 == num)
				{
				}
				num = (short)445186048;
				short num3 = num;
				num = (short)2125856768;
				if (num != 0)
				{
				}
				num = (short)922484737;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.Visible = value;
			}
		}

		// Token: 0x170016B9 RID: 5817
		// (get) Token: 0x06002D26 RID: 11558 RVA: 0x002B78EC File Offset: 0x002B5AEC
		// (set) Token: 0x06002D27 RID: 11559 RVA: 0x002B79A0 File Offset: 0x002B5BA0
		public bool RadWideBluetoothBluetoothDiscoverableExpirationTimer_41980_Editable
		{
			get
			{
				short num = (short)121347069;
				short num2 = num;
				num = (short)2093718525;
				switch (num2 == num)
				{
				}
				num = (short)1151336448;
				short num3 = num;
				num = (short)1053556736;
				if (num != 0)
				{
				}
				num = (short)332398593;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.Editable;
			}
			set
			{
				short num = (short)2104763068;
				short num2 = num;
				num = (short)1695687356;
				switch (num2 == num)
				{
				}
				num = (short)2147352576;
				short num3 = num;
				num = (short)532086784;
				if (num != 0)
				{
				}
				num = (short)1452605441;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.Editable = value;
			}
		}

		// Token: 0x170016BA RID: 5818
		// (get) Token: 0x06002D28 RID: 11560 RVA: 0x002B7A58 File Offset: 0x002B5C58
		internal string RadWideBluetoothBluetoothDiscoverableExpirationTimer_41980_UILabel
		{
			get
			{
				short num = (short)1974322146;
				short num2 = num;
				num = (short)1375454178;
				switch (num2 == num)
				{
				}
				num = (short)1823735808;
				short num3 = num;
				num = (short)1582563329;
				if (num != 0)
				{
				}
				num = (short)761921536;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.UIName;
			}
		}

		// Token: 0x170016BB RID: 5819
		// (get) Token: 0x06002D29 RID: 11561 RVA: 0x002B7B10 File Offset: 0x002B5D10
		// (set) Token: 0x06002D2A RID: 11562 RVA: 0x002B7BC4 File Offset: 0x002B5DC4
		internal bool RadWideBluetoothBluetoothDiscoverableExpirationTimer_41980_HiddenStatic
		{
			get
			{
				short num = (short)463389770;
				short num2 = num;
				num = (short)861848650;
				switch (num2 == num)
				{
				}
				num = (short)1319567360;
				short num3 = num;
				num = (short)280297473;
				if (num != 0)
				{
				}
				num = (short)148242432;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.HiddenStatic;
			}
			set
			{
				short num = (short)117880100;
				short num2 = num;
				num = (short)944485668;
				switch (num2 == num)
				{
				}
				num = (short)864419840;
				short num3 = num;
				num = (short)1378877440;
				if (num != 0)
				{
				}
				num = (short)196345857;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.HiddenStatic = value;
			}
		}

		// Token: 0x170016BC RID: 5820
		// (get) Token: 0x06002D2B RID: 11563 RVA: 0x002B7C78 File Offset: 0x002B5E78
		// (set) Token: 0x06002D2C RID: 11564 RVA: 0x002B7D28 File Offset: 0x002B5F28
		internal bool RadWideBluetoothBluetoothDiscoverableExpirationTimer_41980_HiddenDynamic
		{
			get
			{
				short num = (short)1915845499;
				short num2 = num;
				num = (short)85425019;
				switch (num2 == num)
				{
				}
				num = (short)2117206016;
				short num3 = num;
				num = (short)591659009;
				if (num != 0)
				{
				}
				num = (short)1923612672;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.HiddenDynamic;
			}
			set
			{
				short num = (short)1342509022;
				short num2 = num;
				num = (short)2061635550;
				switch (num2 == num)
				{
				}
				num = (short)1383792640;
				short num3 = num;
				num = (short)700907521;
				if (num != 0)
				{
				}
				num = (short)1803747328;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980.HiddenDynamic = value;
			}
		}

		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x06002D2D RID: 11565 RVA: 0x002B7DDC File Offset: 0x002B5FDC
		public bool RadWideBluetoothBluetoothDiscoverableExpirationTimer_41980_HasDiffs
		{
			get
			{
				short num = (short)236485803;
				short num2 = num;
				num = (short)577862827;
				switch (num2 == num)
				{
				}
				num = (short)569769984;
				short num3 = num;
				num = (short)55443457;
				if (num != 0)
				{
				}
				num = (short)2008940544;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothDiscoverableExpirationTimer_41980._HasDiffs;
			}
		}

		// Token: 0x170016BE RID: 5822
		// (get) Token: 0x06002D2E RID: 11566 RVA: 0x002B7E94 File Offset: 0x002B6094
		// (set) Token: 0x06002D2F RID: 11567 RVA: 0x002B7F48 File Offset: 0x002B6148
		public long RadWideBluetoothBluetoothPANNetworkAddress_41983Value
		{
			get
			{
				short num = (short)1427572421;
				short num2 = num;
				num = (short)226559685;
				switch (num2 == num)
				{
				}
				num = (short)996802560;
				short num3 = num;
				num = (short)838795264;
				if (num != 0)
				{
				}
				num = (short)492109825;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothPANNetworkAddress_41983.Value;
			}
			set
			{
				short num = (short)1232625480;
				short num2 = num;
				num = (short)365715272;
				switch (num2 == num)
				{
				}
				num = (short)978255872;
				short num3 = num;
				num = (short)263061505;
				if (num != 0)
				{
				}
				num = (short)245760000;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothPANNetworkAddress_41983.Value = value;
			}
		}

		// Token: 0x170016BF RID: 5823
		// (get) Token: 0x06002D30 RID: 11568 RVA: 0x002B7FFC File Offset: 0x002B61FC
		// (set) Token: 0x06002D31 RID: 11569 RVA: 0x002B80B0 File Offset: 0x002B62B0
		public string RadWideBluetoothBluetoothPANNetworkAddress_41983_UIValue
		{
			get
			{
				short num = (short)1681645465;
				short num2 = num;
				num = (short)538238873;
				switch (num2 == num)
				{
				}
				num = (short)2049966080;
				short num3 = num;
				num = (short)525271041;
				if (num != 0)
				{
				}
				num = (short)1788870656;
				if (num != 0)
				{
				}
				return this.radWideBluetoothBluetoothPANNetworkAddress_41983.UIValue;
			}
			set
			{
				short num = (short)2049900348;
				short num2 = num;
				num = (short)790822716;
				switch (num2 == num)
				{
				}
				num = (short)1334116352;
				short num3 = num;
				num = (short)574357505;
				if (num != 0)
				{
				}
				num = (short)1916076032;
				if (num != 0)
				{
				}
				this.radWideBluetoothBluetoothPANNetworkAddress_41983.UIValue = value;
			}
		}

		// Token: 0x170016C0 RID: 5824
		// (get) Token: 0x06002D32 RID: 11570 RVA: 0x002B8168 File Offset: 0x002B6368
		public global::AcpBusinessLayer.AcpIPAddressField RadWideBluetoothBluetoothPANNetworkAddress_41983
		{
			get
			{
				short num = (short)240058369;
				if (num != 0)
				{
				}
				num = (short)426150306;
				short num2 = num;
				num = (short)1569098146;
				switch (num2 == num)
				{
				}
				num = (short)1933443072;
				if (num != 0)
				{
				}
				num = (short)2138701824;
				short num3 = num;
				return this.radWideBluetoothBluetoothPANNetworkAddress_41983;
			}
		}

		// Token: 0x170016C1 RID: 5825
		// (get) Token: 0x06002D33 RID: 11571 RVA: 0x002B8214 File Offset: 0x002B6414
		// (set) Token: 0x06002D34 RID: 11572 RVA: 0x002B82C8 File Offset: 0x002B64C8
		public bool RadWideBluetoothBluetoothPANNetworkAddress_41983_Applicable
		{
			get
			{
				short num = (short)1302649298;
				short num2 = num;
				num = (short)390846930;
				switch (num2 == num)
				{
				}
				num = (short)1145765888;
				if (num != 0)
				{
				}
				num = (short)778043393;
				if (num != 0)
				{
				}
				num = (short)657784832;
				short num3 = num;
				return this.radWideBluetoothBluetoothPANNetworkAddress_41983.Applicable;
			}
			set
			{
				short num = (short)591533370;
				short num2 = num;
				num = (short)212145466;
				switch (num2 == num)
				{
				}
				num = (short)1025245185;
				if (num != 0)
				{
				}
				num = (short)1643249664;
				if (num != 0)
				{
				}
				num = (short)1334444032;
				short num3 = num;
				this.radWideBluetoothBluetoothPANNetworkAddress_41983.Applicable = value;
			}
		}

		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x06002D35 RID: 11573 RVA: 0x002B8380 File Offset: 0x002B6580
		// (set) Token: 0x06002D36 RID: 11574 RVA: 0x002B8438 File Offset: 0x002B6638
		public bool RadWideBluetoothBluetoothPANNetworkAddress_41983_Valid
		{
			get
			{
				short num = (short)2026186578;
				short num2 = num;
				num = (short)872621906;
				switch (num2 == num)
				{
				}
				num = (short)1654390784;
				if (num != 0)
				{
				}
				num = (short)881262593;
				if (num != 0)
				{
				}
				num = (short)1637941248;
				short num3 = num;
				return this.radWideBluetoothBluetoothPANNetworkAddress_41983.Valid;
			}
			set
			{
				short num = (short)999644491;
				short num2 = num;
				num = (short)997154123;
				switch (num2 == num)
				{
				}
				num = (short)1157562369;
				if (num != 0)
				{
				}
				num = (short)217448448;
				if (num != 0)
				{
				}
				num = (short)2129657856;
				short num3 = num;
				this.radWideBluetoothBluetoothPANNetworkAddress_41983.Valid = value;
			}
		}

		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x06002D37 RID: 11575 RVA: 0x002B84EC File Offset: 0x002B66EC
		// (set) Token: 0x06002D38 RID: 11576 RVA: 0x002B85A4 File Offset: 0x002B67A4
		public bool RadWideBluetoothBluetoothPANNetworkAddress_41983_Visible
		{
			get
			{
				short num = (short)465875686;
				short num2 = num;
				num = (short)2099688166;
				switch (num2 == num)
				{
				}
				num = (short)460849153;
				if (num != 0)
				{
				}
				num = (short)710082560;
				if (num != 0)
				{
				}
				num = (short)267583488;
				short num3 = num;
				return this.radWideBluetoothBluetoothPANNetworkAddress_41983.Visible;
			}
			set
			{
				short num = (short)1890465647;
				short num2 = num;
				num = (short)1489385327;
				switch (num2 == num)
				{
				}
				num = (short)1911554049;
				if (num != 0)
				{
				}
				num = (short)1459552256;
				if (num != 0)
				{
				}
				num = (short)404357120;
				short num3 = num;
				this.radWideBluetoothBluetoothPANNetworkAddress_41983.Visible = value;
			}
		}

		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x06002D39 RID: 11577 RVA: 0x002B865C File Offset: 0x002B685C
		// (set) Token: 0x06002D3A RID: 11578 RVA: 0x002B870C File Offset: 0x002B690C
		public bool RadWideBluetoothBluetoothPANNetworkAddress_41983_Editable
		{
			get
			{
				short num = (short)579798887;
				short num2 = num;
				num = (short)862783335;
				switch (num2 == num)
				{
				}
				num = (short)887029761;
				if (num != 0)
				{
				}
				num = (short)812253184;
				if (num != 0)
				{
				}
				num = (short)1221984256;
				short num3 = num;
				return this.radWideBluetoothBluetoothPANNetworkAddress_41983.Editable;
			}
			set
			{
				short num = (short)1283699679;
				short num2 = num;
				num = (short)787919839;
				switch (num2 == num)
				{
				}
				num = (short)698417152;
				if (num != 0)
				{
				}
				num = (short)1406599169;
				if (num != 0)
				{
				}
				num = (short)601882624;
				short num3 = num;
				this.radWideBluetoothBluetoothPANNetworkAddress_41983.Editable = value;
			}
		}

		// Token: 0x170016C5 RID: 5829
		// (get) Token: 0x06002D3B RID: 11579 RVA: 0x002B87C0 File Offset: 0x002B69C0
		internal string RadWideBluetoothBluetoothPANNetworkAddress_41983_UILabel
		{
			get
			{
				short num = (short)379774234;
				short num2 = num;
				num = (short)181789978;
				switch (num2 == num)
				{
				}
				num = (short)735576064;
				if (num != 0)
				{
				}
				num = (short)634388481;
				if (num != 0)
				{
				}
				num = (short)281935872;
				short num3 = num;
				return this.radWideBluetoothBluetoothPANNetworkAddress_41983.UIName;
			}
		}

		// Token: 0x170016C6 RID: 5830
		// (get) Token: 0x06002D3C RID: 11580 RVA: 0x002B8874 File Offset: 0x002B6A74
		// (set) Token: 0x06002D3D RID: 11581 RVA: 0x002B892C File Offset: 0x002B6B2C
		internal bool RadWideBluetoothBluetoothPANNetworkAddress_41983_HiddenStatic
		{
			get
			{
				short num = (short)767458887;
				short num2 = num;
				num = (short)1802206791;
				switch (num2 == num)
				{
				}
				num = (short)1341194241;
				if (num != 0)
				{
				}
				num = (short)1051787264;
				if (num != 0)
				{
				}
				num = (short)753401856;
				short num3 = num;
				return this.radWideBluetoothBluetoothPANNetworkAddress_41983.HiddenStatic;
			}
			set
			{
				short num = (short)689373661;
				short num2 = num;
				num = (short)1229062621;
				switch (num2 == num)
				{
				}
				num = (short)1669922817;
				if (num != 0)
				{
				}
				num = (short)658178048;
				if (num != 0)
				{
				}
				num = (short)1626800128;
				short num3 = num;
				this.radWideBluetoothBluetoothPANNetworkAddress_41983.HiddenStatic = value;
			}
		}

		// Token: 0x170016C7 RID: 5831
		// (get) Token: 0x06002D3E RID: 11582 RVA: 0x002B89E0 File Offset: 0x002B6BE0
		// (set) Token: 0x06002D3F RID: 11583 RVA: 0x002B8A98 File Offset: 0x002B6C98
		internal bool RadWideBluetoothBluetoothPANNetworkAddress_41983_HiddenDynamic
		{
			get
			{
				short num = (short)24879336;
				short num2 = num;
				num = (short)1893572840;
				switch (num2 == num)
				{
				}
				num = (short)1531052033;
				if (num != 0)
				{
				}
				num = (short)1678180352;
				if (num != 0)
				{
				}
				num = (short)693764096;
				short num3 = num;
				return this.radWideBluetoothBluetoothPANNetworkAddress_41983.HiddenDynamic;
			}
			set
			{
				short num = (short)1356427189;
				short num2 = num;
				num = (short)1872850869;
				switch (num2 == num)
				{
				}
				num = (short)359202817;
				if (num != 0)
				{
				}
				num = (short)1704067072;
				if (num != 0)
				{
				}
				num = (short)542441472;
				short num3 = num;
				this.radWideBluetoothBluetoothPANNetworkAddress_41983.HiddenDynamic = value;
			}
		}

		// Token: 0x170016C8 RID: 5832
		// (get) Token: 0x06002D40 RID: 11584 RVA: 0x002B8B4C File Offset: 0x002B6D4C
		public bool RadWideBluetoothBluetoothPANNetworkAddress_41983_HasDiffs
		{
			get
			{
				short num = (short)23874998;
				short num2 = num;
				num = (short)231624118;
				switch (num2 == num)
				{
				}
				num = (short)1656094720;
				if (num != 0)
				{
				}
				num = (short)122159105;
				if (num != 0)
				{
				}
				num = (short)1848705024;
				short num3 = num;
				return this.radWideBluetoothBluetoothPANNetworkAddress_41983._HasDiffs;
			}
		}

		// Token: 0x170016C9 RID: 5833
		// (get) Token: 0x06002D41 RID: 11585 RVA: 0x002B8C04 File Offset: 0x002B6E04
		// (set) Token: 0x06002D42 RID: 11586 RVA: 0x002B8CB8 File Offset: 0x002B6EB8
		public bool RadWideMPPPairingOnlyWithLTE_A42320Value
		{
			get
			{
				short num = (short)416073281;
				short num2 = num;
				num = (short)967165505;
				switch (num2 == num)
				{
				}
				num = (short)552337409;
				if (num != 0)
				{
				}
				num = (short)166854656;
				if (num != 0)
				{
				}
				num = (short)204800000;
				short num3 = num;
				return this.radWideMPPPairingOnlyWithLTE_A42320.Value;
			}
			set
			{
				short num = (short)963209384;
				short num2 = num;
				num = (short)477063336;
				switch (num2 == num)
				{
				}
				num = (short)188547073;
				if (num != 0)
				{
				}
				num = (short)199950336;
				if (num != 0)
				{
				}
				num = (short)692715520;
				short num3 = num;
				this.radWideMPPPairingOnlyWithLTE_A42320.Value = value;
			}
		}

		// Token: 0x170016CA RID: 5834
		// (get) Token: 0x06002D43 RID: 11587 RVA: 0x002B8D6C File Offset: 0x002B6F6C
		public global::AcpBusinessLayer.AcpField<bool> RadWideMPPPairingOnlyWithLTE_A42320
		{
			get
			{
				short num = (short)1314037556;
				short num2 = num;
				num = (short)2029428532;
				switch (num2 == num)
				{
				}
				num = (short)73990145;
				if (num != 0)
				{
				}
				num = (short)1668415488;
				if (num != 0)
				{
				}
				num = (short)552402944;
				short num3 = num;
				return this.radWideMPPPairingOnlyWithLTE_A42320;
			}
		}

		// Token: 0x170016CB RID: 5835
		// (get) Token: 0x06002D44 RID: 11588 RVA: 0x002B8E1C File Offset: 0x002B701C
		// (set) Token: 0x06002D45 RID: 11589 RVA: 0x002B8ED0 File Offset: 0x002B70D0
		public bool RadWideMPPPairingOnlyWithLTE_A42320_UIValue
		{
			get
			{
				short num = (short)389415876;
				short num2 = num;
				num = (short)1271530436;
				switch (num2 == num)
				{
				}
				num = (short)342491136;
				if (num != 0)
				{
				}
				num = (short)1809448961;
				if (num != 0)
				{
				}
				num = (short)1095892992;
				short num3 = num;
				return this.radWideMPPPairingOnlyWithLTE_A42320.Value;
			}
			set
			{
				short num = (short)388759553;
				if (num != 0)
				{
				}
				num = (short)406225673;
				short num2 = num;
				num = (short)1132364553;
				switch (num2 == num)
				{
				}
				num = (short)2006581248;
				if (num != 0)
				{
				}
				num = (short)55246848;
				short num3 = num;
				this.radWideMPPPairingOnlyWithLTE_A42320.Value = value;
			}
		}

		// Token: 0x170016CC RID: 5836
		// (get) Token: 0x06002D46 RID: 11590 RVA: 0x002B8F84 File Offset: 0x002B7184
		// (set) Token: 0x06002D47 RID: 11591 RVA: 0x002B903C File Offset: 0x002B723C
		public bool RadWideMPPPairingOnlyWithLTE_A42320_Applicable
		{
			get
			{
				short num = (short)714816510;
				short num2 = num;
				num = (short)493960190;
				switch (num2 == num)
				{
				}
				num = (short)362020864;
				if (num != 0)
				{
				}
				num = (short)1882718209;
				if (num != 0)
				{
				}
				num = (short)50003968;
				short num3 = num;
				return this.radWideMPPPairingOnlyWithLTE_A42320.Applicable;
			}
			set
			{
				short num = (short)1264901120;
				short num2 = num;
				num = (short)528014336;
				switch (num2 == num)
				{
				}
				num = (short)358547457;
				if (num != 0)
				{
				}
				num = (short)454295552;
				if (num != 0)
				{
				}
				num = (short)1478098944;
				short num3 = num;
				this.radWideMPPPairingOnlyWithLTE_A42320.Applicable = value;
			}
		}

		// Token: 0x170016CD RID: 5837
		// (get) Token: 0x06002D48 RID: 11592 RVA: 0x002B90F4 File Offset: 0x002B72F4
		// (set) Token: 0x06002D49 RID: 11593 RVA: 0x002B91AC File Offset: 0x002B73AC
		public bool RadWideMPPPairingOnlyWithLTE_A42320_Valid
		{
			get
			{
				short num = (short)1299251201;
				if (num != 0)
				{
				}
				num = (short)526341086;
				short num2 = num;
				num = (short)1481659358;
				switch (num2 == num)
				{
				}
				num = (short)630325248;
				if (num != 0)
				{
				}
				num = (short)350486528;
				short num3 = num;
				return this.radWideMPPPairingOnlyWithLTE_A42320.Valid;
			}
			set
			{
				short num = (short)1522400736;
				short num2 = num;
				num = (short)557776352;
				switch (num2 == num)
				{
				}
				num = (short)285605889;
				if (num != 0)
				{
				}
				num = (short)198967296;
				if (num != 0)
				{
				}
				num = (short)1962868736;
				short num3 = num;
				this.radWideMPPPairingOnlyWithLTE_A42320.Valid = value;
			}
		}

		// Token: 0x170016CE RID: 5838
		// (get) Token: 0x06002D4A RID: 11594 RVA: 0x002B9264 File Offset: 0x002B7464
		// (set) Token: 0x06002D4B RID: 11595 RVA: 0x002B9318 File Offset: 0x002B7518
		public bool RadWideMPPPairingOnlyWithLTE_A42320_Visible
		{
			get
			{
				short num = (short)1097965807;
				short num2 = num;
				num = (short)126394607;
				switch (num2 == num)
				{
				}
				num = (short)373751808;
				if (num != 0)
				{
				}
				num = (short)2005008385;
				if (num != 0)
				{
				}
				num = (short)434110464;
				short num3 = num;
				return this.radWideMPPPairingOnlyWithLTE_A42320.Visible;
			}
			set
			{
				short num = (short)828054644;
				short num2 = num;
				num = (short)1670716532;
				switch (num2 == num)
				{
				}
				num = (short)1211170816;
				if (num != 0)
				{
				}
				num = (short)1022689281;
				if (num != 0)
				{
				}
				num = (short)1555628032;
				short num3 = num;
				this.radWideMPPPairingOnlyWithLTE_A42320.Visible = value;
			}
		}

		// Token: 0x170016CF RID: 5839
		// (get) Token: 0x06002D4C RID: 11596 RVA: 0x002B93D0 File Offset: 0x002B75D0
		// (set) Token: 0x06002D4D RID: 11597 RVA: 0x002B9484 File Offset: 0x002B7684
		public bool RadWideMPPPairingOnlyWithLTE_A42320_Editable
		{
			get
			{
				short num = (short)1242352533;
				short num2 = num;
				num = (short)699059093;
				switch (num2 == num)
				{
				}
				num = (short)875560961;
				if (num != 0)
				{
				}
				num = (short)1117126656;
				if (num != 0)
				{
				}
				num = (short)1068236800;
				short num3 = num;
				return this.radWideMPPPairingOnlyWithLTE_A42320.Editable;
			}
			set
			{
				short num = (short)619495897;
				short num2 = num;
				num = (short)2013053401;
				switch (num2 == num)
				{
				}
				num = (short)851902465;
				if (num != 0)
				{
				}
				num = (short)473432064;
				if (num != 0)
				{
				}
				num = (short)1232797696;
				short num3 = num;
				this.radWideMPPPairingOnlyWithLTE_A42320.Editable = value;
			}
		}

		// Token: 0x170016D0 RID: 5840
		// (get) Token: 0x06002D4E RID: 11598 RVA: 0x002B9538 File Offset: 0x002B7738
		internal string RadWideMPPPairingOnlyWithLTE_A42320_UILabel
		{
			get
			{
				short num = (short)1210187777;
				if (num != 0)
				{
				}
				num = (short)1238669501;
				short num2 = num;
				num = (short)1202493629;
				switch (num2 == num)
				{
				}
				num = (short)329646080;
				if (num != 0)
				{
				}
				num = (short)913899520;
				short num3 = num;
				return this.radWideMPPPairingOnlyWithLTE_A42320.UIName;
			}
		}

		// Token: 0x170016D1 RID: 5841
		// (get) Token: 0x06002D4F RID: 11599 RVA: 0x002B95F0 File Offset: 0x002B77F0
		// (set) Token: 0x06002D50 RID: 11600 RVA: 0x002B96A8 File Offset: 0x002B78A8
		internal bool RadWideMPPPairingOnlyWithLTE_A42320_HiddenStatic
		{
			get
			{
				short num = (short)242697929;
				short num2 = num;
				num = (short)1934313161;
				switch (num2 == num)
				{
				}
				num = (short)1519386625;
				if (num != 0)
				{
				}
				num = (short)2131755008;
				if (num != 0)
				{
				}
				num = (short)212795392;
				short num3 = num;
				return this.radWideMPPPairingOnlyWithLTE_A42320.HiddenStatic;
			}
			set
			{
				short num = (short)37241793;
				short num2 = num;
				num = (short)159531969;
				switch (num2 == num)
				{
				}
				num = (short)1405681665;
				if (num != 0)
				{
				}
				num = (short)354156544;
				if (num != 0)
				{
				}
				num = (short)1326514176;
				short num3 = num;
				this.radWideMPPPairingOnlyWithLTE_A42320.HiddenStatic = value;
			}
		}

		// Token: 0x170016D2 RID: 5842
		// (get) Token: 0x06002D51 RID: 11601 RVA: 0x002B975C File Offset: 0x002B795C
		// (set) Token: 0x06002D52 RID: 11602 RVA: 0x002B9810 File Offset: 0x002B7A10
		internal bool RadWideMPPPairingOnlyWithLTE_A42320_HiddenDynamic
		{
			get
			{
				short num = (short)1305152926;
				short num2 = num;
				num = (short)548670878;
				switch (num2 == num)
				{
				}
				num = (short)35848193;
				if (num != 0)
				{
				}
				num = (short)588840960;
				if (num != 0)
				{
				}
				num = (short)1762590720;
				short num3 = num;
				return this.radWideMPPPairingOnlyWithLTE_A42320.HiddenDynamic;
			}
			set
			{
				short num = (short)1700576321;
				short num2 = num;
				num = (short)1795210305;
				switch (num2 == num)
				{
				}
				num = (short)1713569793;
				if (num != 0)
				{
				}
				num = (short)2115960832;
				if (num != 0)
				{
				}
				num = (short)737542144;
				short num3 = num;
				this.radWideMPPPairingOnlyWithLTE_A42320.HiddenDynamic = value;
			}
		}

		// Token: 0x170016D3 RID: 5843
		// (get) Token: 0x06002D53 RID: 11603 RVA: 0x002B98C8 File Offset: 0x002B7AC8
		public bool RadWideMPPPairingOnlyWithLTE_A42320_HasDiffs
		{
			get
			{
				short num = (short)1144329842;
				short num2 = num;
				num = (short)1195841138;
				switch (num2 == num)
				{
				}
				num = (short)956628993;
				if (num != 0)
				{
				}
				num = (short)1950285824;
				if (num != 0)
				{
				}
				num = (short)1082785792;
				short num3 = num;
				return this.radWideMPPPairingOnlyWithLTE_A42320._HasDiffs;
			}
		}

		// Token: 0x170016D4 RID: 5844
		// (get) Token: 0x06002D54 RID: 11604 RVA: 0x002B997C File Offset: 0x002B7B7C
		// (set) Token: 0x06002D55 RID: 11605 RVA: 0x002B9A30 File Offset: 0x002B7C30
		public bool RadWideBluetoothLegacyBluetoothPINPairingValue
		{
			get
			{
				short num = (short)1908832487;
				short num2 = num;
				num = (short)1181251815;
				switch (num2 == num)
				{
				}
				num = (short)1586298880;
				if (num != 0)
				{
				}
				num = (short)1232601089;
				if (num != 0)
				{
				}
				num = (short)1705639936;
				short num3 = num;
				return this.radWideBluetoothLegacyBluetoothPINPairing.Value;
			}
			set
			{
				short num = (short)2104009916;
				short num2 = num;
				num = (short)527803580;
				switch (num2 == num)
				{
				}
				num = (short)123338753;
				if (num != 0)
				{
				}
				num = (short)283246592;
				if (num != 0)
				{
				}
				num = (short)2045181952;
				short num3 = num;
				this.radWideBluetoothLegacyBluetoothPINPairing.Value = value;
			}
		}

		// Token: 0x170016D5 RID: 5845
		// (get) Token: 0x06002D56 RID: 11606 RVA: 0x002B9AE8 File Offset: 0x002B7CE8
		public global::AcpBusinessLayer.AcpField<bool> RadWideBluetoothLegacyBluetoothPINPairing
		{
			get
			{
				short num = (short)1437976007;
				short num2 = num;
				num = (short)1841153479;
				switch (num2 == num)
				{
				}
				num = (short)1896873985;
				if (num != 0)
				{
				}
				num = (short)1145176064;
				if (num != 0)
				{
				}
				num = (short)1115881472;
				short num3 = num;
				return this.radWideBluetoothLegacyBluetoothPINPairing;
			}
		}

		// Token: 0x170016D6 RID: 5846
		// (get) Token: 0x06002D57 RID: 11607 RVA: 0x002B9B98 File Offset: 0x002B7D98
		// (set) Token: 0x06002D58 RID: 11608 RVA: 0x002B9C4C File Offset: 0x002B7E4C
		public bool RadWideBluetoothLegacyBluetoothPINPairing_UIValue
		{
			get
			{
				short num = (short)724241362;
				short num2 = num;
				num = (short)2010713042;
				switch (num2 == num)
				{
				}
				num = (short)197066753;
				if (num != 0)
				{
				}
				num = (short)330825728;
				if (num != 0)
				{
				}
				num = (short)172032000;
				short num3 = num;
				return this.radWideBluetoothLegacyBluetoothPINPairing.Value;
			}
			set
			{
				short num = (short)1219135514;
				short num2 = num;
				num = (short)484739098;
				switch (num2 == num)
				{
				}
				num = (short)201785345;
				if (num != 0)
				{
				}
				num = (short)1903296512;
				if (num != 0)
				{
				}
				num = (short)1432616960;
				short num3 = num;
				this.radWideBluetoothLegacyBluetoothPINPairing.Value = value;
			}
		}

		// Token: 0x170016D7 RID: 5847
		// (get) Token: 0x06002D59 RID: 11609 RVA: 0x002B9D00 File Offset: 0x002B7F00
		// (set) Token: 0x06002D5A RID: 11610 RVA: 0x002B9DB8 File Offset: 0x002B7FB8
		public bool RadWideBluetoothLegacyBluetoothPINPairing_Applicable
		{
			get
			{
				short num = (short)596294582;
				short num2 = num;
				num = (short)1026997174;
				switch (num2 == num)
				{
				}
				num = (short)53936129;
				if (num != 0)
				{
				}
				num = (short)604831744;
				if (num != 0)
				{
				}
				num = (short)1722679296;
				short num3 = num;
				return this.radWideBluetoothLegacyBluetoothPINPairing.Applicable;
			}
			set
			{
				short num = (short)1694706615;
				short num2 = num;
				num = (short)1977756599;
				switch (num2 == num)
				{
				}
				num = (short)1970405376;
				if (num != 0)
				{
				}
				num = (short)327024641;
				if (num != 0)
				{
				}
				num = (short)1825243136;
				short num3 = num;
				this.radWideBluetoothLegacyBluetoothPINPairing.Applicable = value;
			}
		}

		// Token: 0x170016D8 RID: 5848
		// (get) Token: 0x06002D5B RID: 11611 RVA: 0x002B9E6C File Offset: 0x002B806C
		// (set) Token: 0x06002D5C RID: 11612 RVA: 0x002B9F20 File Offset: 0x002B8120
		public bool RadWideBluetoothLegacyBluetoothPINPairing_Valid
		{
			get
			{
				short num = (short)1718482550;
				short num2 = num;
				num = (short)1528624758;
				switch (num2 == num)
				{
				}
				num = (short)1002373120;
				if (num != 0)
				{
				}
				num = (short)1171849217;
				if (num != 0)
				{
				}
				num = (short)1299513344;
				short num3 = num;
				return this.radWideBluetoothLegacyBluetoothPINPairing.Valid;
			}
			set
			{
				short num = (short)142910130;
				short num2 = num;
				num = (short)1464115890;
				switch (num2 == num)
				{
				}
				num = (short)732758016;
				if (num != 0)
				{
				}
				num = (short)111345665;
				if (num != 0)
				{
				}
				num = (short)1595867136;
				short num3 = num;
				this.radWideBluetoothLegacyBluetoothPINPairing.Valid = value;
			}
		}

		// Token: 0x170016D9 RID: 5849
		// (get) Token: 0x06002D5D RID: 11613 RVA: 0x002B9FD4 File Offset: 0x002B81D4
		// (set) Token: 0x06002D5E RID: 11614 RVA: 0x002BA088 File Offset: 0x002B8288
		public bool RadWideBluetoothLegacyBluetoothPINPairing_Visible
		{
			get
			{
				short num = (short)648263394;
				short num2 = num;
				num = (short)1299298018;
				switch (num2 == num)
				{
				}
				num = (short)1632763904;
				if (num != 0)
				{
				}
				num = (short)670367745;
				if (num != 0)
				{
				}
				num = (short)971177984;
				short num3 = num;
				return this.radWideBluetoothLegacyBluetoothPINPairing.Visible;
			}
			set
			{
				short num = (short)1004184693;
				short num2 = num;
				num = (short)1888461941;
				switch (num2 == num)
				{
				}
				num = (short)1149763585;
				if (num != 0)
				{
				}
				num = (short)333905920;
				if (num != 0)
				{
				}
				num = (short)1630273536;
				short num3 = num;
				this.radWideBluetoothLegacyBluetoothPINPairing.Visible = value;
			}
		}

		// Token: 0x170016DA RID: 5850
		// (get) Token: 0x06002D5F RID: 11615 RVA: 0x002BA140 File Offset: 0x002B8340
		// (set) Token: 0x06002D60 RID: 11616 RVA: 0x002BA1F8 File Offset: 0x002B83F8
		public bool RadWideBluetoothLegacyBluetoothPINPairing_Editable
		{
			get
			{
				short num = (short)1761542145;
				if (num != 0)
				{
				}
				num = (short)1859961349;
				short num2 = num;
				num = (short)1446953477;
				switch (num2 == num)
				{
				}
				num = (short)1592983552;
				if (num != 0)
				{
				}
				num = (short)280756224;
				short num3 = num;
				return this.radWideBluetoothLegacyBluetoothPINPairing.Editable;
			}
			set
			{
				short num = (short)632759137;
				short num2 = num;
				num = (short)31204193;
				switch (num2 == num)
				{
				}
				num = (short)1299775488;
				if (num != 0)
				{
				}
				num = (short)310771713;
				if (num != 0)
				{
				}
				num = (short)1727922176;
				short num3 = num;
				this.radWideBluetoothLegacyBluetoothPINPairing.Editable = value;
			}
		}

		// Token: 0x170016DB RID: 5851
		// (get) Token: 0x06002D61 RID: 11617 RVA: 0x002BA2B0 File Offset: 0x002B84B0
		internal string RadWideBluetoothLegacyBluetoothPINPairing_UILabel
		{
			get
			{
				short num = (short)2048738671;
				short num2 = num;
				num = (short)747980143;
				switch (num2 == num)
				{
				}
				num = (short)1295450113;
				if (num != 0)
				{
				}
				num = (short)1641349120;
				if (num != 0)
				{
				}
				num = (short)2017984512;
				short num3 = num;
				return this.radWideBluetoothLegacyBluetoothPINPairing.UIName;
			}
		}

		// Token: 0x170016DC RID: 5852
		// (get) Token: 0x06002D62 RID: 11618 RVA: 0x002BA364 File Offset: 0x002B8564
		// (set) Token: 0x06002D63 RID: 11619 RVA: 0x002BA418 File Offset: 0x002B8618
		internal bool RadWideBluetoothLegacyBluetoothPINPairing_HiddenStatic
		{
			get
			{
				short num = (short)1935617476;
				short num2 = num;
				num = (short)89796036;
				switch (num2 == num)
				{
				}
				num = (short)555614209;
				if (num != 0)
				{
				}
				num = (short)1463025664;
				if (num != 0)
				{
				}
				num = (short)63963136;
				short num3 = num;
				return this.radWideBluetoothLegacyBluetoothPINPairing.HiddenStatic;
			}
			set
			{
				short num = (short)971458972;
				short num2 = num;
				num = (short)339954076;
				switch (num2 == num)
				{
				}
				num = (short)1879834625;
				if (num != 0)
				{
				}
				num = (short)218693632;
				if (num != 0)
				{
				}
				num = (short)125894656;
				short num3 = num;
				this.radWideBluetoothLegacyBluetoothPINPairing.HiddenStatic = value;
			}
		}

		// Token: 0x170016DD RID: 5853
		// (get) Token: 0x06002D64 RID: 11620 RVA: 0x002BA4CC File Offset: 0x002B86CC
		// (set) Token: 0x06002D65 RID: 11621 RVA: 0x002BA580 File Offset: 0x002B8780
		internal bool RadWideBluetoothLegacyBluetoothPINPairing_HiddenDynamic
		{
			get
			{
				short num = (short)184942593;
				if (num != 0)
				{
				}
				num = (short)222696450;
				short num2 = num;
				num = (short)2107773954;
				switch (num2 == num)
				{
				}
				num = (short)892534784;
				if (num != 0)
				{
				}
				num = (short)730923008;
				short num3 = num;
				return this.radWideBluetoothLegacyBluetoothPINPairing.HiddenDynamic;
			}
			set
			{
				short num = (short)993552272;
				short num2 = num;
				num = (short)1009936272;
				switch (num2 == num)
				{
				}
				num = (short)1845624833;
				if (num != 0)
				{
				}
				num = (short)362676224;
				if (num != 0)
				{
				}
				num = (short)1780678656;
				short num3 = num;
				this.radWideBluetoothLegacyBluetoothPINPairing.HiddenDynamic = value;
			}
		}

		// Token: 0x170016DE RID: 5854
		// (get) Token: 0x06002D66 RID: 11622 RVA: 0x002BA634 File Offset: 0x002B8834
		public bool RadWideBluetoothLegacyBluetoothPINPairing_HasDiffs
		{
			get
			{
				short num = (short)1045191556;
				short num2 = num;
				num = (short)23747460;
				switch (num2 == num)
				{
				}
				num = (short)800784385;
				if (num != 0)
				{
				}
				num = (short)1409024000;
				if (num != 0)
				{
				}
				num = (short)952238080;
				short num3 = num;
				return this.radWideBluetoothLegacyBluetoothPINPairing._HasDiffs;
			}
		}

		// Token: 0x170016DF RID: 5855
		// (get) Token: 0x06002D67 RID: 11623 RVA: 0x002BA6EC File Offset: 0x002B88EC
		// (set) Token: 0x06002D68 RID: 11624 RVA: 0x002BA79C File Offset: 0x002B899C
		public bool RadWideBluetoothAudioBackwardsCompatibility_A44942Value
		{
			get
			{
				short num = (short)2103663760;
				short num2 = num;
				num = (short)370826384;
				switch (num2 == num)
				{
				}
				num = (short)1678442497;
				if (num != 0)
				{
				}
				num = (short)161218560;
				if (num != 0)
				{
				}
				num = (short)1231355904;
				short num3 = num;
				return this.radWideBluetoothAudioBackwardsCompatibility_A44942.Value;
			}
			set
			{
				short num = (short)624935741;
				short num2 = num;
				num = (short)1461240637;
				switch (num2 == num)
				{
				}
				num = (short)1489043457;
				if (num != 0)
				{
				}
				num = (short)632422400;
				if (num != 0)
				{
				}
				num = (short)1554644992;
				short num3 = num;
				this.radWideBluetoothAudioBackwardsCompatibility_A44942.Value = value;
			}
		}

		// Token: 0x170016E0 RID: 5856
		// (get) Token: 0x06002D69 RID: 11625 RVA: 0x002BA850 File Offset: 0x002B8A50
		public global::AcpBusinessLayer.AcpField<bool> RadWideBluetoothAudioBackwardsCompatibility_A44942
		{
			get
			{
				short num = (short)127970722;
				short num2 = num;
				num = (short)1513991586;
				switch (num2 == num)
				{
				}
				num = (short)1216872448;
				short num3 = num;
				num = (short)1026228224;
				if (num != 0)
				{
				}
				num = (short)1738735617;
				if (num != 0)
				{
				}
				return this.radWideBluetoothAudioBackwardsCompatibility_A44942;
			}
		}

		// Token: 0x170016E1 RID: 5857
		// (get) Token: 0x06002D6A RID: 11626 RVA: 0x002BA900 File Offset: 0x002B8B00
		// (set) Token: 0x06002D6B RID: 11627 RVA: 0x002BA9B4 File Offset: 0x002B8BB4
		public bool RadWideBluetoothAudioBackwardsCompatibility_A44942_UIValue
		{
			get
			{
				short num = (short)1329956340;
				short num2 = num;
				num = (short)2058520052;
				switch (num2 == num)
				{
				}
				num = (short)814612480;
				short num3 = num;
				num = (short)1427963904;
				if (num != 0)
				{
				}
				num = (short)702152705;
				if (num != 0)
				{
				}
				return this.radWideBluetoothAudioBackwardsCompatibility_A44942.Value;
			}
			set
			{
				short num = (short)327948121;
				short num2 = num;
				num = (short)1971984217;
				switch (num2 == num)
				{
				}
				num = (short)431685632;
				short num3 = num;
				num = (short)1946025984;
				if (num != 0)
				{
				}
				num = (short)1327104001;
				if (num != 0)
				{
				}
				this.radWideBluetoothAudioBackwardsCompatibility_A44942.Value = value;
			}
		}

		// Token: 0x170016E2 RID: 5858
		// (get) Token: 0x06002D6C RID: 11628 RVA: 0x002BAA68 File Offset: 0x002B8C68
		// (set) Token: 0x06002D6D RID: 11629 RVA: 0x002BAB20 File Offset: 0x002B8D20
		public bool RadWideBluetoothAudioBackwardsCompatibility_A44942_Applicable
		{
			get
			{
				short num = (short)1689845761;
				if (num != 0)
				{
				}
				num = (short)356025954;
				short num2 = num;
				num = (short)1062504034;
				switch (num2 == num)
				{
				default:
				{
					num = (short)497418240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1604321280;
				if (num != 0)
				{
				}
				return this.radWideBluetoothAudioBackwardsCompatibility_A44942.Applicable;
			}
			set
			{
				short num = (short)1824211158;
				short num2 = num;
				num = (short)157302998;
				switch (num2 == num)
				{
				}
				num = (short)1769537536;
				short num3 = num;
				num = (short)522256385;
				if (num != 0)
				{
				}
				num = (short)435552256;
				if (num != 0)
				{
				}
				this.radWideBluetoothAudioBackwardsCompatibility_A44942.Applicable = value;
			}
		}

		// Token: 0x170016E3 RID: 5859
		// (get) Token: 0x06002D6E RID: 11630 RVA: 0x002BABD8 File Offset: 0x002B8DD8
		// (set) Token: 0x06002D6F RID: 11631 RVA: 0x002BAC8C File Offset: 0x002B8E8C
		public bool RadWideBluetoothAudioBackwardsCompatibility_A44942_Valid
		{
			get
			{
				short num = (short)683474945;
				if (num != 0)
				{
				}
				num = (short)1957619536;
				short num2 = num;
				num = (short)799598416;
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
				num = (short)311558144;
				if (num != 0)
				{
				}
				return this.radWideBluetoothAudioBackwardsCompatibility_A44942.Valid;
			}
			set
			{
				short num = (short)2038986134;
				short num2 = num;
				num = (short)1049589142;
				switch (num2 == num)
				{
				}
				num = (short)1929838592;
				short num3 = num;
				num = (short)179109888;
				if (num != 0)
				{
				}
				num = (short)143917057;
				if (num != 0)
				{
				}
				this.radWideBluetoothAudioBackwardsCompatibility_A44942.Valid = value;
			}
		}

		// Token: 0x170016E4 RID: 5860
		// (get) Token: 0x06002D70 RID: 11632 RVA: 0x002BAD40 File Offset: 0x002B8F40
		// (set) Token: 0x06002D71 RID: 11633 RVA: 0x002BADF4 File Offset: 0x002B8FF4
		public bool RadWideBluetoothAudioBackwardsCompatibility_A44942_Visible
		{
			get
			{
				short num = (short)2013163177;
				short num2 = num;
				num = (short)694054569;
				switch (num2 == num)
				{
				}
				num = (short)1428750336;
				short num3 = num;
				num = (short)1307115521;
				if (num != 0)
				{
				}
				num = (short)108003328;
				if (num != 0)
				{
				}
				return this.radWideBluetoothAudioBackwardsCompatibility_A44942.Visible;
			}
			set
			{
				short num = (short)1301769493;
				short num2 = num;
				num = (short)614821141;
				switch (num2 == num)
				{
				}
				num = (short)1700003840;
				short num3 = num;
				num = (short)1019740161;
				if (num != 0)
				{
				}
				num = (short)1332871168;
				if (num != 0)
				{
				}
				this.radWideBluetoothAudioBackwardsCompatibility_A44942.Visible = value;
			}
		}

		// Token: 0x170016E5 RID: 5861
		// (get) Token: 0x06002D72 RID: 11634 RVA: 0x002BAEA8 File Offset: 0x002B90A8
		// (set) Token: 0x06002D73 RID: 11635 RVA: 0x002BAF60 File Offset: 0x002B9160
		public bool RadWideBluetoothAudioBackwardsCompatibility_A44942_Editable
		{
			get
			{
				short num = (short)1223598425;
				short num2 = num;
				num = (short)1824891225;
				switch (num2 == num)
				{
				}
				num = (short)787677184;
				short num3 = num;
				num = (short)1919680513;
				if (num != 0)
				{
				}
				num = (short)1262813184;
				if (num != 0)
				{
				}
				return this.radWideBluetoothAudioBackwardsCompatibility_A44942.Editable;
			}
			set
			{
				short num = (short)1679454376;
				short num2 = num;
				num = (short)1577611432;
				switch (num2 == num)
				{
				}
				num = (short)1564409856;
				short num3 = num;
				num = (short)302514176;
				if (num != 0)
				{
				}
				num = (short)1680736257;
				if (num != 0)
				{
				}
				this.radWideBluetoothAudioBackwardsCompatibility_A44942.Editable = value;
			}
		}

		// Token: 0x170016E6 RID: 5862
		// (get) Token: 0x06002D74 RID: 11636 RVA: 0x002BB018 File Offset: 0x002B9218
		internal string RadWideBluetoothAudioBackwardsCompatibility_A44942_UILabel
		{
			get
			{
				short num = (short)59983260;
				short num2 = num;
				num = (short)1848329628;
				switch (num2 == num)
				{
				}
				num = (short)275841024;
				short num3 = num;
				num = (short)747700224;
				if (num != 0)
				{
				}
				num = (short)3145729;
				if (num != 0)
				{
				}
				return this.radWideBluetoothAudioBackwardsCompatibility_A44942.UIName;
			}
		}

		// Token: 0x170016E7 RID: 5863
		// (get) Token: 0x06002D75 RID: 11637 RVA: 0x002BB0CC File Offset: 0x002B92CC
		// (set) Token: 0x06002D76 RID: 11638 RVA: 0x002BB180 File Offset: 0x002B9380
		internal bool RadWideBluetoothAudioBackwardsCompatibility_A44942_HiddenStatic
		{
			get
			{
				short num = (short)685935221;
				short num2 = num;
				num = (short)2025687669;
				switch (num2 == num)
				{
				}
				num = (short)1354301440;
				short num3 = num;
				num = (short)161873920;
				if (num != 0)
				{
				}
				num = (short)951582721;
				if (num != 0)
				{
				}
				return this.radWideBluetoothAudioBackwardsCompatibility_A44942.HiddenStatic;
			}
			set
			{
				short num = (short)509474510;
				short num2 = num;
				num = (short)1303443150;
				switch (num2 == num)
				{
				}
				num = (short)842596352;
				short num3 = num;
				num = (short)333119488;
				if (num != 0)
				{
				}
				num = (short)182517761;
				if (num != 0)
				{
				}
				this.radWideBluetoothAudioBackwardsCompatibility_A44942.HiddenStatic = value;
			}
		}

		// Token: 0x170016E8 RID: 5864
		// (get) Token: 0x06002D77 RID: 11639 RVA: 0x002BB234 File Offset: 0x002B9434
		// (set) Token: 0x06002D78 RID: 11640 RVA: 0x002BB2E8 File Offset: 0x002B94E8
		internal bool RadWideBluetoothAudioBackwardsCompatibility_A44942_HiddenDynamic
		{
			get
			{
				short num = (short)227125498;
				short num2 = num;
				num = (short)1696049402;
				switch (num2 == num)
				{
				}
				num = (short)2061762560;
				short num3 = num;
				num = (short)21757953;
				if (num != 0)
				{
				}
				num = (short)65798144;
				if (num != 0)
				{
				}
				return this.radWideBluetoothAudioBackwardsCompatibility_A44942.HiddenDynamic;
			}
			set
			{
				short num = (short)581697537;
				if (num != 0)
				{
				}
				num = (short)248905850;
				short num2 = num;
				num = (short)1143668858;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1575288832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)319422464;
				if (num != 0)
				{
				}
				this.radWideBluetoothAudioBackwardsCompatibility_A44942.HiddenDynamic = value;
			}
		}

		// Token: 0x170016E9 RID: 5865
		// (get) Token: 0x06002D79 RID: 11641 RVA: 0x002BB39C File Offset: 0x002B959C
		public bool RadWideBluetoothAudioBackwardsCompatibility_A44942_HasDiffs
		{
			get
			{
				short num = (short)813718742;
				short num2 = num;
				num = (short)1809341654;
				switch (num2 == num)
				{
				}
				num = (short)264110080;
				short num3 = num;
				num = (short)1750663168;
				if (num != 0)
				{
				}
				num = (short)193527809;
				if (num != 0)
				{
				}
				return this.radWideBluetoothAudioBackwardsCompatibility_A44942._HasDiffs;
			}
		}

		// Token: 0x170016EA RID: 5866
		// (get) Token: 0x06002D7A RID: 11642 RVA: 0x002BB450 File Offset: 0x002B9650
		// (set) Token: 0x06002D7B RID: 11643 RVA: 0x002BB504 File Offset: 0x002B9704
		public bool RadWideBluetoothImproveAudioLatency_A44943Value
		{
			get
			{
				short num = (short)556734233;
				short num2 = num;
				num = (short)2026247961;
				switch (num2 == num)
				{
				}
				num = (short)1283522560;
				if (num != 0)
				{
				}
				num = (short)1105854465;
				if (num != 0)
				{
				}
				num = (short)1253244928;
				short num3 = num;
				return this.radWideBluetoothImproveAudioLatency_A44943.Value;
			}
			set
			{
				short num = (short)1898399758;
				short num2 = num;
				num = (short)602359822;
				switch (num2 == num)
				{
				}
				num = (short)1309605889;
				if (num != 0)
				{
				}
				num = (short)1582170112;
				if (num != 0)
				{
				}
				num = (short)1586626560;
				short num3 = num;
				this.radWideBluetoothImproveAudioLatency_A44943.Value = value;
			}
		}

		// Token: 0x170016EB RID: 5867
		// (get) Token: 0x06002D7C RID: 11644 RVA: 0x002BB5B8 File Offset: 0x002B97B8
		public global::AcpBusinessLayer.AcpField<bool> RadWideBluetoothImproveAudioLatency_A44943
		{
			get
			{
				short num = (short)150886225;
				short num2 = num;
				num = (short)1738102609;
				switch (num2 == num)
				{
				}
				num = (short)599851009;
				if (num != 0)
				{
				}
				num = (short)167378944;
				if (num != 0)
				{
				}
				num = (short)1752104960;
				short num3 = num;
				return this.radWideBluetoothImproveAudioLatency_A44943;
			}
		}

		// Token: 0x170016EC RID: 5868
		// (get) Token: 0x06002D7D RID: 11645 RVA: 0x002BB668 File Offset: 0x002B9868
		// (set) Token: 0x06002D7E RID: 11646 RVA: 0x002BB720 File Offset: 0x002B9920
		public bool RadWideBluetoothImproveAudioLatency_A44943_UIValue
		{
			get
			{
				short num = (short)66322433;
				if (num != 0)
				{
				}
				num = (short)2028881287;
				short num2 = num;
				num = (short)1183794567;
				switch (num2 == num)
				{
				}
				num = (short)449118208;
				if (num != 0)
				{
				}
				num = (short)1267531776;
				short num3 = num;
				return this.radWideBluetoothImproveAudioLatency_A44943.Value;
			}
			set
			{
				short num = (short)742603086;
				short num2 = num;
				num = (short)617953614;
				switch (num2 == num)
				{
				}
				num = (short)1135411201;
				if (num != 0)
				{
				}
				num = (short)219807744;
				if (num != 0)
				{
				}
				num = (short)1235156992;
				short num3 = num;
				this.radWideBluetoothImproveAudioLatency_A44943.Value = value;
			}
		}

		// Token: 0x170016ED RID: 5869
		// (get) Token: 0x06002D7F RID: 11647 RVA: 0x002BB7D4 File Offset: 0x002B99D4
		// (set) Token: 0x06002D80 RID: 11648 RVA: 0x002BB888 File Offset: 0x002B9A88
		public bool RadWideBluetoothImproveAudioLatency_A44943_Applicable
		{
			get
			{
				short num = (short)1959632124;
				short num2 = num;
				num = (short)1410505980;
				switch (num2 == num)
				{
				}
				num = (short)525467649;
				if (num != 0)
				{
				}
				num = (short)757137408;
				if (num != 0)
				{
				}
				num = (short)251002880;
				short num3 = num;
				return this.radWideBluetoothImproveAudioLatency_A44943.Applicable;
			}
			set
			{
				short num = (short)816273771;
				short num2 = num;
				num = (short)1074747755;
				switch (num2 == num)
				{
				}
				num = (short)1545011200;
				if (num != 0)
				{
				}
				num = (short)270925825;
				if (num != 0)
				{
				}
				num = (short)942407680;
				short num3 = num;
				this.radWideBluetoothImproveAudioLatency_A44943.Applicable = value;
			}
		}

		// Token: 0x170016EE RID: 5870
		// (get) Token: 0x06002D81 RID: 11649 RVA: 0x002BB93C File Offset: 0x002B9B3C
		// (set) Token: 0x06002D82 RID: 11650 RVA: 0x002BB9F0 File Offset: 0x002B9BF0
		public bool RadWideBluetoothImproveAudioLatency_A44943_Valid
		{
			get
			{
				short num = (short)775216874;
				short num2 = num;
				num = (short)66969322;
				switch (num2 == num)
				{
				}
				num = (short)1553793024;
				if (num != 0)
				{
				}
				num = (short)1113587713;
				if (num != 0)
				{
				}
				num = (short)605093888;
				short num3 = num;
				return this.radWideBluetoothImproveAudioLatency_A44943.Valid;
			}
			set
			{
				short num = (short)1791621395;
				short num2 = num;
				num = (short)1504966931;
				switch (num2 == num)
				{
				}
				num = (short)1101201408;
				if (num != 0)
				{
				}
				num = (short)1888944129;
				if (num != 0)
				{
				}
				num = (short)1161953280;
				short num3 = num;
				this.radWideBluetoothImproveAudioLatency_A44943.Valid = value;
			}
		}

		// Token: 0x170016EF RID: 5871
		// (get) Token: 0x06002D83 RID: 11651 RVA: 0x002BBAA8 File Offset: 0x002B9CA8
		// (set) Token: 0x06002D84 RID: 11652 RVA: 0x002BBB60 File Offset: 0x002B9D60
		public bool RadWideBluetoothImproveAudioLatency_A44943_Visible
		{
			get
			{
				short num = (short)1468958246;
				short num2 = num;
				num = (short)1261274662;
				switch (num2 == num)
				{
				}
				num = (short)1734475776;
				if (num != 0)
				{
				}
				num = (short)920518657;
				if (num != 0)
				{
				}
				num = (short)96272384;
				short num3 = num;
				return this.radWideBluetoothImproveAudioLatency_A44943.Visible;
			}
			set
			{
				short num = (short)1929352212;
				short num2 = num;
				num = (short)1860342804;
				switch (num2 == num)
				{
				}
				num = (short)2084503552;
				if (num != 0)
				{
				}
				num = (short)1470103553;
				if (num != 0)
				{
				}
				num = (short)302972928;
				short num3 = num;
				this.radWideBluetoothImproveAudioLatency_A44943.Visible = value;
			}
		}

		// Token: 0x170016F0 RID: 5872
		// (get) Token: 0x06002D85 RID: 11653 RVA: 0x002BBC18 File Offset: 0x002B9E18
		// (set) Token: 0x06002D86 RID: 11654 RVA: 0x002BBCCC File Offset: 0x002B9ECC
		public bool RadWideBluetoothImproveAudioLatency_A44943_Editable
		{
			get
			{
				short num = (short)1721257761;
				short num2 = num;
				num = (short)2112638753;
				switch (num2 == num)
				{
				}
				num = (short)2115239936;
				if (num != 0)
				{
				}
				num = (short)419233793;
				if (num != 0)
				{
				}
				num = (short)364445696;
				short num3 = num;
				return this.radWideBluetoothImproveAudioLatency_A44943.Editable;
			}
			set
			{
				short num = (short)611005127;
				short num2 = num;
				num = (short)49230535;
				switch (num2 == num)
				{
				}
				num = (short)45088769;
				if (num != 0)
				{
				}
				num = (short)2093678592;
				if (num != 0)
				{
				}
				num = (short)1857159168;
				short num3 = num;
				this.radWideBluetoothImproveAudioLatency_A44943.Editable = value;
			}
		}

		// Token: 0x170016F1 RID: 5873
		// (get) Token: 0x06002D87 RID: 11655 RVA: 0x002BBD80 File Offset: 0x002B9F80
		internal string RadWideBluetoothImproveAudioLatency_A44943_UILabel
		{
			get
			{
				short num = (short)1812913201;
				short num2 = num;
				num = (short)277142577;
				switch (num2 == num)
				{
				}
				num = (short)1707999233;
				if (num != 0)
				{
				}
				num = (short)1812070400;
				if (num != 0)
				{
				}
				num = (short)123076608;
				short num3 = num;
				return this.radWideBluetoothImproveAudioLatency_A44943.UIName;
			}
		}

		// Token: 0x170016F2 RID: 5874
		// (get) Token: 0x06002D88 RID: 11656 RVA: 0x002BBE34 File Offset: 0x002BA034
		// (set) Token: 0x06002D89 RID: 11657 RVA: 0x002BBEEC File Offset: 0x002BA0EC
		internal bool RadWideBluetoothImproveAudioLatency_A44943_HiddenStatic
		{
			get
			{
				short num = (short)809873946;
				short num2 = num;
				num = (short)1072607770;
				switch (num2 == num)
				{
				}
				num = (short)1476198400;
				if (num != 0)
				{
				}
				num = (short)2088828929;
				if (num != 0)
				{
				}
				num = (short)704577536;
				short num3 = num;
				return this.radWideBluetoothImproveAudioLatency_A44943.HiddenStatic;
			}
			set
			{
				short num = (short)184639409;
				short num2 = num;
				num = (short)948461489;
				switch (num2 == num)
				{
				}
				num = (short)1763508225;
				if (num != 0)
				{
				}
				num = (short)211091456;
				if (num != 0)
				{
				}
				num = (short)795017216;
				short num3 = num;
				this.radWideBluetoothImproveAudioLatency_A44943.HiddenStatic = value;
			}
		}

		// Token: 0x170016F3 RID: 5875
		// (get) Token: 0x06002D8A RID: 11658 RVA: 0x002BBFA0 File Offset: 0x002BA1A0
		// (set) Token: 0x06002D8B RID: 11659 RVA: 0x002BC054 File Offset: 0x002BA254
		internal bool RadWideBluetoothImproveAudioLatency_A44943_HiddenDynamic
		{
			get
			{
				short num = (short)273765172;
				short num2 = num;
				num = (short)1159090996;
				switch (num2 == num)
				{
				}
				num = (short)1307901953;
				if (num != 0)
				{
				}
				num = (short)1854930944;
				if (num != 0)
				{
				}
				num = (short)1496580096;
				short num3 = num;
				return this.radWideBluetoothImproveAudioLatency_A44943.HiddenDynamic;
			}
			set
			{
				short num = (short)1708968773;
				short num2 = num;
				num = (short)534629189;
				switch (num2 == num)
				{
				}
				num = (short)2087649280;
				if (num != 0)
				{
				}
				num = (short)243662849;
				if (num != 0)
				{
				}
				num = (short)281673728;
				short num3 = num;
				this.radWideBluetoothImproveAudioLatency_A44943.HiddenDynamic = value;
			}
		}

		// Token: 0x170016F4 RID: 5876
		// (get) Token: 0x06002D8C RID: 11660 RVA: 0x002BC108 File Offset: 0x002BA308
		public bool RadWideBluetoothImproveAudioLatency_A44943_HasDiffs
		{
			get
			{
				short num = (short)1035083463;
				short num2 = num;
				num = (short)740957895;
				switch (num2 == num)
				{
				}
				num = (short)243466240;
				if (num != 0)
				{
				}
				num = (short)1932328961;
				if (num != 0)
				{
				}
				num = (short)442892288;
				short num3 = num;
				return this.radWideBluetoothImproveAudioLatency_A44943._HasDiffs;
			}
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x002BC1BC File Offset: 0x002BA3BC
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
					goto IL_83;
				case 1:
					goto IL_AC;
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)1898643457;
						if (num2 != 0)
						{
						}
						num2 = (short)1505296387;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13C;
				case 3:
				{
					num2 = (short)2073144942;
					short num3 = num2;
					num2 = (short)680046190;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_83;
					default:
						num2 = (short)1445134336;
						if (num2 != 0)
						{
						}
						num2 = (short)1056243716;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)819462144;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13C;
				}
				goto IL_24;
				IL_83:
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num2 = (short)1648230401;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_AC:
			IL_13C:
			num2 = (short)1608318976;
			short num4 = num2;
			return result;
			IL_24:
			result = null;
			num2 = (short)1327955970;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000FE3 RID: 4067
		private global::AcpBusinessLayer.AcpField<bool> radWideBluetoothBluetoothEnable_A37028;

		// Token: 0x04000FE4 RID: 4068
		private global::AcpBusinessLayer.AcpField<bool> radWideBluetoothBluetoothTones_A37035;

		// Token: 0x04000FE5 RID: 4069
		private global::AcpBusinessLayer.AcpField<bool> radWideBluetoothBluetoothRSMLED_A37039;

		// Token: 0x04000FE6 RID: 4070
		private global::AcpBusinessLayer.AcpListField radWideBluetoothBluetoothPairingType_A37036;

		// Token: 0x04000FE7 RID: 4071
		private global::AcpBusinessLayer.AcpField<bool> radWideStandardNFCPairing_A44928;

		// Token: 0x04000FE8 RID: 4072
		private global::AcpBusinessLayer.AcpField<bool> radWideSecureNFCPairing_A44931;

		// Token: 0x04000FE9 RID: 4073
		private global::AcpBusinessLayer.AcpCustomRangeField radWideBluetoothBluetoothReconnectTimer_A37037;

		// Token: 0x04000FEA RID: 4074
		private global::AcpBusinessLayer.AcpListField radWideBluetoothBluetoothDropTimer_A37038;

		// Token: 0x04000FEB RID: 4075
		private global::AcpBusinessLayer.AcpField<string> radWideBluetoothFriendlyName_A41181;

		// Token: 0x04000FEC RID: 4076
		private global::AcpBusinessLayer.AcpField<bool> radWideBluetoothFriendlyNameEditable_A41182;

		// Token: 0x04000FED RID: 4077
		private global::AcpBusinessLayer.AcpField<bool> radWideBluetoothReplacePairingInfo_A41562;

		// Token: 0x04000FEE RID: 4078
		private global::AcpBusinessLayer.AcpField<bool> radWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576;

		// Token: 0x04000FEF RID: 4079
		private global::AcpBusinessLayer.AcpCustomRangeField radWideBluetoothBluetoothDeviceInquiryDuration_41977;

		// Token: 0x04000FF0 RID: 4080
		private global::AcpBusinessLayer.AcpSimpleRangeField radWideBluetoothBluetoothDiscoverableExpirationTimer_41980;

		// Token: 0x04000FF1 RID: 4081
		private global::AcpBusinessLayer.AcpIPAddressField radWideBluetoothBluetoothPANNetworkAddress_41983;

		// Token: 0x04000FF2 RID: 4082
		private global::AcpBusinessLayer.AcpField<bool> radWideMPPPairingOnlyWithLTE_A42320;

		// Token: 0x04000FF3 RID: 4083
		private global::AcpBusinessLayer.AcpField<bool> radWideBluetoothLegacyBluetoothPINPairing;

		// Token: 0x04000FF4 RID: 4084
		private global::AcpBusinessLayer.AcpField<bool> radWideBluetoothAudioBackwardsCompatibility_A44942;

		// Token: 0x04000FF5 RID: 4085
		private global::AcpBusinessLayer.AcpField<bool> radWideBluetoothImproveAudioLatency_A44943;
	}
}
