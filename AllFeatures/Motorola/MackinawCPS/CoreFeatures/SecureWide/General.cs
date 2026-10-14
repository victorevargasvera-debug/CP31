using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.SecureWide
{
	// Token: 0x020000E7 RID: 231
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600204E RID: 8270 RVA: 0x0020073C File Offset: 0x001FE93C
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x00200758 File Offset: 0x001FE958
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x00200770 File Offset: 0x001FE970
		public override void Init()
		{
			int a_ = 8;
			short num = (short)1955698116;
			short num2 = num;
			num = (short)1758827972;
			switch (num2 == num)
			{
			}
			num = (short)1492975617;
			if (num != 0)
			{
			}
			num = (short)1469775872;
			if (num != 0)
			{
			}
			num = (short)444334080;
			short num3 = num;
			this.secWideGeneralOTAREnable_A7966 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔郖볘뗚룜귞胠迢ꫤ돦꣨맪꣬臮郰釲駴鋶꛸뫺쫼웾㜀㔂", a_), global::CommonResources.AcgResources.ID_OTARENABLE);
			this.secWideGeneralOTAREnable_A7966.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideGeneralOTAREnable_A7966.DataTransferOrder = 2;
			this.secWideMultikeyErasePreviousOnUserChange_A8373 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔髖곘럚꧜뛞諠蛢鳤ꋦ鯨諪黬諮ꇰ臲郴臶郸铺裼賾一洂倄理氈礊丌朎瀐紒爔爖䘘娚├Ⱎᘠဢ", a_), global::CommonResources.AcgResources.ID_KEYSETERASEPREVIOUSONUSERCHANGE);
			this.secWideMultikeyErasePreviousOnUserChange_A8373.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideMultikeyErasePreviousOnUserChange_A8373.DataTransferOrder = 38;
			this.secWideMultikeyUserSelectable_A9604 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔髖곘럚꧜뛞諠蛢鳤닦髨軪鿬볮铰鿲郴银跸髺鿼鏾搀専䐄㸆㼈㬊㤌", a_), global::CommonResources.AcgResources.ID_KEYSETUSERSELECTABLE);
			this.secWideMultikeyUserSelectable_A9604.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideMultikeyUserSelectable_A9604.DataTransferOrder = 41;
			this.secureConfigurationSecureWide_A19833 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髈껊껌뫎ꏐ뛒雔룖럘뷚드룞铠釢蓤鏦胨蓪菬볮铰郲胴藶鳸곺铼鯾搀専䐄㘆〈㌊㸌㰎", a_), global::CommonResources.AcgResources.ID_KEYLISTMANAGEMENTKVLFIPSLEVEL3APPROVEDMODE, new string[]
			{
				global::CommonResources.AcgResources.ID_KVLFIPSLEVEL3APPROVEDMODE
			});
			this.secureConfigurationSecureWide_A19833.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.secureConfigurationSecureWide_A19833.DataTransferOrder = 16;
			this.secWideGeneralOTARGenerateKeyLossKey_A8169 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔郖볘뗚룜귞胠迢ꫤ돦꣨맪ꫬ諮鿰雲蟴零跸黺뛼髾砀伂樄理稈䀊栌瘎丐划ⴔ☖⼘√", a_), global::CommonResources.AcgResources.ID_KEYLISTMANAGEMENTOTARGENERATEKEYLOSSKEY, new string[]
			{
				global::CommonResources.AcgResources.ID_OTARGENERATEKEYLOSSKEY
			});
			this.secWideGeneralOTARGenerateKeyLossKey_A8169.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideGeneralOTARGenerateKeyLossKey_A8169.DataTransferOrder = 19;
			this.secWideGeneralSecureOperation_A9067 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.indexSecWideGeneralSecureOperation_A9067LovStrs, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.idSecWideGeneralSecureOperation_A9067LovStrs), this, global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔郖볘뗚룜귞胠迢뛤苦諨黪鿬諮뻰菲郴藶飸迺铼郾漀専䐄㸆㤈㴊㨌", a_), global::CommonResources.AcgResources.ID_SECUREOPERATION, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.SecWideGeneralSecureOperation_A9067LovStrs);
			this.secWideGeneralSecureOperation_A9067.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.secWideGeneralSecureOperation_A9067.DataTransferOrder = 1;
			this.secWideGeneralOTAROperation_43700 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.indexSecWideGeneralOTAROperation_43700LovStrs, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.idSecWideGeneralOTAROperation_43700LovStrs), this, global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔郖볘뗚룜귞胠迢ꫤ돦꣨맪ꋬ鿮铰臲铴菶郸铺鏼ꃾ㔀。㈄㜆㤈", a_), global::CommonResources.AcgResources.ID_OTAROPERATION, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.SecWideGeneralOTAROperation_43700LovStrs);
			this.secWideGeneralOTAROperation_43700.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.SecWideGeneralOTAROperation_43700.DataTransferOrder = 3;
			this.secWideGeneralEnhancedADPRadioInhibit_A41461 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔郖볘뗚룜귞胠迢ꃤ触臨諪菬賮铰韲듴돶꧸ꧺ鳼鯾栀氂䰄椆愈戊漌明攐䰒吔⌖⠘⼚⬜⸞", a_), global::CommonResources.AcgResources.ID_ENHANCEDSWKEYERASEONRADIOINHIBIT, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LegacyTitles.SecWideGeneralEnhancedADPRadioInhibit_A41461LegacyTitles);
			this.secWideGeneralEnhancedADPRadioInhibit_A41461.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideGeneralEnhancedADPRadioInhibit_A41461.DataTransferOrder = 45;
			this.secWideInfiniteUKEKRetention_A41551 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔黖럘뷚드뇞裠韢胤닦ꋨ껪ꛬ뷮铰蟲郴駶跸鋺鋼釾帀䈂㄄㘆㰈㸊㰌", a_), global::CommonResources.AcgResources.ID_KEYLISTMANAGEMENTINFINITEUKEKRETENTION, new string[]
			{
				global::CommonResources.AcgResources.ID_INFINITEUKEKRETENTION
			});
			this.secWideInfiniteUKEKRetention_A41551.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideInfiniteUKEKRetention_A41551.DataTransferOrder = 46;
			this.secureWideADPAlgorithmEnable_43200 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髈껊껌뫎ꏐ뛒苔뻖뷘뻚鳜鯞뇠ꋢ觤胦蛨駪蓬鯮駰黲냴駶飸駺釼髾帀㜂㘄㔆㤈㬊", a_), global::CommonResources.AcgResources.ID_SECUREALGORITHMSADVANCEDDIGITALPRIVACYADP);
			this.secureWideADPAlgorithmEnable_43200.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secureWideADPAlgorithmEnable_43200.DataTransferOrder = 51;
			this.secureWideAESAlgorithmEnable_43201 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髈껊껌뫎ꏐ뛒苔뻖뷘뻚鳜髞닠ꋢ觤胦蛨駪蓬鯮駰黲냴駶飸駺釼髾帀㜂㘄㔆㤈㨊", a_), global::CommonResources.AcgResources.ID_SECUREALGORITHMSADVANCEDENCRYPTIONSTANDARDAES256);
			this.secureWideAESAlgorithmEnable_43201.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secureWideAESAlgorithmEnable_43201.DataTransferOrder = 52;
			this.secureWideKeyloadingSource_43204 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("髈껊껌뫎ꏐ뛒苔뻖뷘뻚雜뫞飠迢諤蛦跨苪菬裮ꋰ鳲胴藶髸黺ꋼ쯾㈀㄂㔄㌆", a_), global::CommonResources.AcgResources.ID_KEYLOADINGSOURCE, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.SecureWideKeyloadingSource_43204LovStrs);
			this.secureWideKeyloadingSource_43204.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secureWideKeyloadingSource_43204.DataTransferOrder = 53;
			this.secureWideDESAlgorithmEnable_43744 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髈껊껌뫎ꏐ뛒苔뻖뷘뻚駜髞닠ꋢ觤胦蛨駪蓬鯮駰黲냴駶飸駺釼髾帀㜂㘄〆㴈㼊", a_), global::CommonResources.AcgResources.ID_SECUREALGORITHMSDATAENCRIPTIONSTANDARDDES);
			this.secureWideDESAlgorithmEnable_43744.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secureWideDESAlgorithmEnable_43744.DataTransferOrder = 54;
			this.secWideKeyListMgmtEraseAllKeys_43648 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔鳖볘ꋚ釜뛞鋠韢꣤胦蓨鿪꣬鷮郰胲郴뛶闸韺뛼髾砀瀂娄㌆㨈㴊㤌㜎", a_), global::CommonResources.AcgResources.ID_KEYLISTMANAGEMENTERASEALLKEYS);
			this.secWideKeyListMgmtEraseAllKeys_43648.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideKeyListMgmtEraseAllKeys_43648.DataTransferOrder = 74;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軈껊ꏌ꫎ꏐ닒맔", a_);
			base.Id = 10043;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
			this.b();
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x00200BD4 File Offset: 0x001FEDD4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 1;
			short num = (short)867696669;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ鿇ꏉ꣋ꯍ鷏ꟑ룓ꋕ뇗뇙맛꟝ꗟ郡藣闥跧뫩黫语蛯鯱鯳菵请뗹鋻꯽珿朁瘃䔅怇欉戋植甏䴑唓⸕⬗ⴙ⼛", a_)))
					{
						num = (short)1246363658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BC;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ뷇룉꧋駍맏뛑뇓鷕뷗ꏙ냛뇝臟蛡跣裥迧맩菫鯭苯釱釳꧵쳷짹컻컽㓿", a_)))
					{
						num = (short)563806229;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3EE;
				case 2:
					goto IL_686;
				case 3:
					this.secWideKeyListMgmtEraseAllKeys_43648 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ鿇ꏉ꣋ꯍ鯏럑귓髕뇗꧙꣛鏝蟟迡郣ꏥ髧诩鿫语뇯黱飳뷵鷷菹迻ꇽ㓿㄁㈃㈅〇", a_), global::CommonResources.AcgResources.ID_KEYLISTMANAGEMENTERASEALLKEYS);
					this.secWideKeyListMgmtEraseAllKeys_43648.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideKeyListMgmtEraseAllKeys_43648.DataTransferOrder = 74;
					num = (short)822083595;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ鿇ꏉ꣋ꯍ韏럑뫓돕꫗믙냛針듟ꏡ뛣ꧥ飧迩黫迭蓯鯱鯳飵ꟷ컹쿻짽ヿ㈁", a_)))
					{
						num = (short)672464903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_355;
				case 5:
					goto IL_264;
				case 6:
					this.secureWideDESAlgorithmEnable_43744 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ뷇룉꧋駍맏뛑뇓鋕鷗觙鷛닝蟟跡難迥鳧苩臫꯭黯鏱雳髵鷷ꗹ죻췽㟿㘁〃", a_), global::CommonResources.AcgResources.ID_SECUREALGORITHMSDATAENCRIPTIONSTANDARDDES);
					this.secureWideDESAlgorithmEnable_43744.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secureWideDESAlgorithmEnable_43744.DataTransferOrder = 54;
					num = (short)584843302;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					this.secWideGeneralOTAROperation_43700 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.indexSecWideGeneralOTAROperation_43700LovStrs, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.idSecWideGeneralOTAROperation_43700LovStrs), this, global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ鿇ꏉ꣋ꯍ韏럑뫓돕꫗믙냛針듟ꏡ뛣ꧥ飧迩黫迭蓯鯱鯳飵ꟷ컹쿻짽ヿ㈁", a_), global::CommonResources.AcgResources.ID_OTAROPERATION, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.SecWideGeneralOTAROperation_43700LovStrs);
					this.secWideGeneralOTAROperation_43700.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.secWideGeneralOTAROperation_43700.DataTransferOrder = 3;
					num = (short)346030096;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ뷇룉꧋駍맏뛑뇓韕鳗諙鷛닝蟟跡難迥鳧苩臫꯭黯鏱雳髵鷷ꗹ죻췽㋿㈁㐃", a_)))
					{
						num = (short)1073807383;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6D4;
				case 9:
					goto IL_6D4;
				case 10:
					this.secWideMultikeyErasePreviousOnUserChange_A8373 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ鿇ꏉ꣋ꯍ鷏ꟑ룓ꋕ뇗뇙맛꟝ꗟ郡藣闥跧뫩黫语蛯鯱鯳菵请뗹鋻꯽珿朁瘃䔅怇欉戋植甏䴑唓⸕⬗ⴙ⼛", a_), global::CommonResources.AcgResources.ID_KEYSETERASEPREVIOUSONUSERCHANGE);
					this.secWideMultikeyErasePreviousOnUserChange_A8373.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideMultikeyErasePreviousOnUserChange_A8373.DataTransferOrder = 38;
					num = (short)1529217044;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_4B5;
				case 12:
					num = (short)1568997415;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_4BA;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ鿇ꏉ꣋ꯍ鷏ꟑ룓ꋕ뇗뇙맛꟝뗟釡臣铥믧迩胫语鏯蛱闳铵铷鿹ꏻ뿽㧿㐁㐃㈅", a_)))
					{
						num = (short)1734475811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3A2;
				case 15:
					this.secWideGeneralEnhancedADPRadioInhibit_A41461 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ鿇ꏉ꣋ꯍ韏럑뫓돕꫗믙냛鯝軟諡藣裥诧迩裫꿭듯ꋱ꛳韵鳷鏹鏻럽滿樁洃搅愇縉匋伍␏⌑–―⤗", a_), global::CommonResources.AcgResources.ID_ENHANCEDSWKEYERASEONRADIOINHIBIT, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LegacyTitles.SecWideGeneralEnhancedADPRadioInhibit_A41461LegacyTitles);
					this.secWideGeneralEnhancedADPRadioInhibit_A41461.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideGeneralEnhancedADPRadioInhibit_A41461.DataTransferOrder = 45;
					num = (short)1010892843;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					goto IL_355;
				case 17:
					goto IL_3EE;
				case 18:
					goto IL_2B1;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ뷇룉꧋跍뿏병닓뿕뿗꿙껛뿝铟诡诣裥믧迩迫鯭苯韱ꏳ鿵鳷鿹ꏻ뿽ㇿ㬁㰃㔅㬇", a_)))
					{
						num = (short)817496097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_639;
				case 20:
					goto IL_1BC;
				case 21:
					this.secureWideKeyloadingSource_43204 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ뷇룉꧋駍맏뛑뇓鷕뷗ꏙ냛뇝臟蛡跣裥迧맩菫鯭苯釱釳꧵쳷짹컻컽㓿", a_), global::CommonResources.AcgResources.ID_KEYLOADINGSOURCE, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.SecureWideKeyloadingSource_43204LovStrs);
					this.secureWideKeyloadingSource_43204.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secureWideKeyloadingSource_43204.DataTransferOrder = 53;
					num = (short)1119092753;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ鿇ꏉ꣋ꯍ鯏럑귓髕뇗꧙꣛鏝蟟迡郣ꏥ髧诩鿫语뇯黱飳뷵鷷菹迻ꇽ㓿㄁㈃㈅〇", a_)))
					{
						num = (short)1780219907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B1E;
				case 23:
					this.secureWideADPAlgorithmEnable_43200 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ뷇룉꧋駍맏뛑뇓韕鳗諙鷛닝蟟跡難迥鳧苩臫꯭黯鏱雳髵鷷ꗹ죻췽㋿㈁㐃", a_), global::CommonResources.AcgResources.ID_SECUREALGORITHMSADVANCEDDIGITALPRIVACYADP);
					this.secureWideADPAlgorithmEnable_43200.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secureWideADPAlgorithmEnable_43200.DataTransferOrder = 51;
					num = (short)948568073;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ鿇ꏉ꣋ꯍ駏병닓뿕뛗동꣛믝뗟ꧡꇣ귥뫧迩飫语黯蛱鷳駵雷ꗹ뷻쫽ㇿ㜁㄃㜅", a_)))
					{
						num = (short)1893072940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B1;
				case 25:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ뷇룉꧋駍맏뛑뇓韕鷗觙鷛닝蟟跡難迥鳧苩臫꯭黯鏱雳髵鷷ꗹ죻췽㋿㈁㔃", a_)))
					{
						num = (short)1861746688;
						short num3 = num;
						num = (short)1546321957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_686;
				case 26:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ鿇ꏉ꣋ꯍ韏럑뫓돕꫗믙냛鯝軟諡藣裥诧迩裫꿭듯ꋱ꛳韵鳷鏹鏻럽滿樁洃搅愇縉匋伍␏⌑–―⤗", a_)))
					{
						num = (short)2036137999;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_811;
				case 27:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ鿇ꏉ꣋ꯍ韏럑뫓돕꫗믙냛距藟臡釣铥跧ꗩ鳫语苯鏱胳鿵韷铹ꏻ뿽㧿㈁㈃ㄅ", a_)))
					{
						num = (short)1166802975;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_96C;
				case 28:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ뷇룉꧋駍맏뛑뇓鋕鷗觙鷛닝蟟跡難迥鳧苩臫꯭黯鏱雳髵鷷ꗹ죻췽㟿㘁〃", a_)))
					{
						num = (short)348651526;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A6D;
				case 29:
					switch (0)
					{
					case 0:
						goto IL_E6;
					}
					continue;
				case 30:
					goto IL_3A2;
				case 31:
				{
					num = (short)121905664;
					short num4 = num;
					num = (short)1639129600;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_741;
					default:
						num = (short)699006976;
						if (num != 0)
						{
						}
						this.secWideGeneralSecureOperation_A9067 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.indexSecWideGeneralSecureOperation_A9067LovStrs, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.idSecWideGeneralSecureOperation_A9067LovStrs), this, global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ鿇ꏉ꣋ꯍ韏럑뫓돕꫗믙냛距藟臡釣铥跧ꗩ鳫语苯鏱胳鿵韷铹ꏻ뿽㧿㈁㈃ㄅ", a_), global::CommonResources.AcgResources.ID_SECUREOPERATION, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.SecWideGeneralSecureOperation_A9067LovStrs);
						this.secWideGeneralSecureOperation_A9067.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.secWideGeneralSecureOperation_A9067.DataTransferOrder = 1;
						num = (short)1058930720;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 32:
					goto IL_96C;
				case 33:
					this.secureConfigurationSecureWide_A19833 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ뷇룉꧋跍뿏병닓뿕뿗꿙껛뿝铟诡诣裥믧迩迫鯭苯韱ꏳ鿵鳷鿹ꏻ뿽ㇿ㬁㰃㔅㬇", a_), global::CommonResources.AcgResources.ID_KEYLISTMANAGEMENTKVLFIPSLEVEL3APPROVEDMODE, new string[]
					{
						global::CommonResources.AcgResources.ID_KVLFIPSLEVEL3APPROVEDMODE
					});
					this.secureConfigurationSecureWide_A19833.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.secureConfigurationSecureWide_A19833.DataTransferOrder = 16;
					num = (short)1255276578;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					goto IL_639;
				case 35:
					this.secWideMultikeyUserSelectable_A9604 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ鿇ꏉ꣋ꯍ鷏ꟑ룓ꋕ뇗뇙맛꟝뗟釡臣铥믧迩胫语鏯蛱闳铵铷鿹ꏻ뿽㧿㐁㐃㈅", a_), global::CommonResources.AcgResources.ID_KEYSETUSERSELECTABLE);
					this.secWideMultikeyUserSelectable_A9604.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideMultikeyUserSelectable_A9604.DataTransferOrder = 41;
					num = (short)1904934942;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ鿇ꏉ꣋ꯍ韏럑뫓돕꫗믙냛針듟ꏡ뛣ꏥ蛧诩軫苭闯귱뗳쇵쇷쳹쫻", a_)))
					{
						num = (short)482607145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_264;
				case 37:
					goto IL_741;
				case 38:
					goto IL_A6D;
				case 39:
					if (producerFields != null)
					{
						num = (short)990838824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B1E;
				case 40:
					num = (short)381354020;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 41:
					this.secWideGeneralOTAREnable_A7966 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ鿇ꏉ꣋ꯍ韏럑뫓돕꫗믙냛針듟ꏡ뛣ꏥ蛧诩軫苭闯귱뗳쇵쇷쳹쫻", a_), global::CommonResources.AcgResources.ID_OTARENABLE);
					this.secWideGeneralOTAREnable_A7966.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideGeneralOTAREnable_A7966.DataTransferOrder = 2;
					num = (short)468647941;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 42:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ鿇ꏉ꣋ꯍ韏럑뫓돕꫗믙냛針듟ꏡ뛣ꇥ跧蓩觫鳭釯蛱釳뷵鷷菹냻釽珿焁伃挅焇唉䴋㘍ℏ␑ⴓ", a_)))
					{
						num = (short)479395885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4BA;
				case 43:
					goto IL_811;
				case 44:
					this.secWideInfiniteUKEKRetention_A41551 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ鿇ꏉ꣋ꯍ駏병닓뿕뛗동꣛믝뗟ꧡꇣ귥뫧迩飫语黯蛱鷳駵雷ꗹ뷻쫽ㇿ㜁㄃㜅", a_), global::CommonResources.AcgResources.ID_KEYLISTMANAGEMENTINFINITEUKEKRETENTION, new string[]
					{
						global::CommonResources.AcgResources.ID_INFINITEUKEKRETENTION
					});
					this.secWideInfiniteUKEKRetention_A41551.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideInfiniteUKEKRetention_A41551.DataTransferOrder = 46;
					num = (short)1697906706;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 45:
					this.secWideGeneralOTARGenerateKeyLossKey_A8169 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ鿇ꏉ꣋ꯍ韏럑뫓돕꫗믙냛針듟ꏡ뛣ꇥ跧蓩觫鳭釯蛱釳뷵鷷菹냻釽珿焁伃挅焇唉䴋㘍ℏ␑ⴓ", a_), global::CommonResources.AcgResources.ID_KEYLISTMANAGEMENTOTARGENERATEKEYLOSSKEY, new string[]
					{
						global::CommonResources.AcgResources.ID_OTARGENERATEKEYLOSSKEY
					});
					this.secWideGeneralOTARGenerateKeyLossKey_A8169.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideGeneralOTARGenerateKeyLossKey_A8169.DataTransferOrder = 19;
					num = (short)2091384845;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_E6:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)972029964;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1BC:
				num = (short)1849557006;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_264:
				num = (short)2094530560;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B1:
				num = (short)281935880;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_355:
				num = (short)1836384282;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3A2:
				num = (short)1283522579;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3EE:
				num = (short)2064646145;
				if (num != 0)
				{
				}
				num = (short)462094364;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4BA:
				num = (short)348389403;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_639:
				num = (short)1769930794;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_686:
				num = (short)2010316801;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6D4:
				num = (short)1105199129;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_741:
				this.secureWideAESAlgorithmEnable_43201 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ뷇룉꧋駍맏뛑뇓韕鷗觙鷛닝蟟跡難迥鳧苩臫꯭黯鏱雳髵鷷ꗹ죻췽㋿㈁㔃", a_), global::CommonResources.AcgResources.ID_SECUREALGORITHMSADVANCEDENCRYPTIONSTANDARDAES256);
				this.secureWideAESAlgorithmEnable_43201.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
				this.secureWideAESAlgorithmEnable_43201.DataTransferOrder = 52;
				num = (short)1491402754;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_811:
				num = (short)1129644056;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_96C:
				num = (short)794296324;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A6D:
				num = (short)1144848406;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4B5:
			IL_B1E:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("藁ꇃꣅ귇룉귋ꋍ", a_);
			base.Id = 10043;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x00201730 File Offset: 0x001FF930
		public override void PopulateReferences()
		{
			short num = (short)234482727;
			short num2 = num;
			num = (short)1658317863;
			switch (num2 == num)
			{
			}
			num = (short)33882113;
			if (num != 0)
			{
			}
			num = (short)1860960256;
			if (num != 0)
			{
			}
			num = (short)1081147392;
			short num3 = num;
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x002017DC File Offset: 0x001FF9DC
		public override void DropReferences()
		{
			short num = (short)430337411;
			short num2 = num;
			num = (short)1512926595;
			switch (num2 == num)
			{
			}
			num = (short)411828225;
			if (num != 0)
			{
			}
			num = (short)265814016;
			if (num != 0)
			{
			}
			num = (short)567476224;
			short num3 = num;
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x00201888 File Offset: 0x001FFA88
		public override void SetConstraints()
		{
			short num = (short)1240151948;
			short num2 = num;
			num = (short)1112029068;
			switch (num2 == num)
			{
			}
			num = (short)568524800;
			if (num != 0)
			{
			}
			num = (short)1397227521;
			if (num != 0)
			{
			}
			num = (short)453574656;
			short num3 = num;
			this.secWideGeneralOTAREnable_A7966.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.conOtarEnabledWhenSecOperationIsHardware);
			this.secWideMultikeyErasePreviousOnUserChange_A8373.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConEPOUCinvalidWhenSecOpIsDisabledOrADP);
			this.secWideMultikeyUserSelectable_A9604.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.conUserSelectableEnableWhenSecOperationIsHardwareOrSoftwareWithAESorDES);
			this.secureConfigurationSecureWide_A19833.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecOperationIsHardware);
			this.secWideGeneralOTARGenerateKeyLossKey_A8169.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConOtarIsEnabledAndSecOperationIsHardware);
			this.secWideGeneralSecureOperation_A9067.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConIsSecureOperationApp);
			this.secWideGeneralSecureOperation_A9067.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecureOperationBasedOnTacticalInhibit);
			this.secWideGeneralSecureOperation_A9067.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConIsSecureOperationEditable);
			this.secWideGeneralSecureOperation_A9067.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecureOperationSetter);
			this.secWideGeneralOTAROperation_43700.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.conOtarEnabledWhenSecOperationIsHardware);
			this.secWideGeneralOTAROperation_43700.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConOtarOperationIndexValid);
			this.secWideGeneralEnhancedADPRadioInhibit_A41461.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConIsEnhancedKeyEraseOnRadioInhibitApp);
			this.secWideGeneralEnhancedADPRadioInhibit_A41461.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConIsEnhancedKeyEraseOnRadioInhibitValid);
			this.secWideInfiniteUKEKRetention_A41551.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecOperationIsHardware);
			this.secWideInfiniteUKEKRetention_A41551.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConInfiniteKeyRetentionDisable);
			this.secureWideADPAlgorithmEnable_43200.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecOperationIsSoftware);
			this.secureWideADPAlgorithmEnable_43200.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecureAlgorithmsValid);
			this.secureWideAESAlgorithmEnable_43201.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecOperationIsSoftware);
			this.secureWideAESAlgorithmEnable_43201.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecureAlgorithmsValid);
			this.secureWideKeyloadingSource_43204.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecOperationIsSoftware);
			this.secureWideKeyloadingSource_43204.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConKeyLoadingSourceInvalid);
			this.secWideKeyListMgmtEraseAllKeys_43648.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecOperationIsHardware);
			this.secureWideDESAlgorithmEnable_43744.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecOperationIsSoftware);
			this.secureWideDESAlgorithmEnable_43744.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecureAlgorithmsValid);
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x00201B5C File Offset: 0x001FFD5C
		public override void SetupDependencies()
		{
			short num = (short)1211432961;
			if (num != 0)
			{
			}
			num = (short)388624658;
			short num2 = num;
			num = (short)1727525138;
			switch (num2 == num)
			{
			}
			num = (short)676659200;
			short num3 = num;
			num = (short)1287585792;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			this.secWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideGeneralOTAREnable_A7966);
			this.secureWideAESAlgorithmEnable_43201.AddDependentObject(this.secWideGeneralOTAREnable_A7966);
			this.secWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideMultikeyErasePreviousOnUserChange_A8373);
			this.secureWideAESAlgorithmEnable_43201.AddDependentObject(this.secWideMultikeyErasePreviousOnUserChange_A8373);
			this.secureWideDESAlgorithmEnable_43744.AddDependentObject(this.secWideMultikeyErasePreviousOnUserChange_A8373);
			this.secWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideMultikeyUserSelectable_A9604);
			this.secureWideAESAlgorithmEnable_43201.AddDependentObject(this.secWideMultikeyUserSelectable_A9604);
			this.secureWideDESAlgorithmEnable_43744.AddDependentObject(this.secWideMultikeyUserSelectable_A9604);
			this.secWideGeneralSecureOperation_A9067.AddDependentObject(this.secureConfigurationSecureWide_A19833);
			this.secWideGeneralOTAREnable_A7966.AddDependentObject(this.secWideGeneralOTARGenerateKeyLossKey_A8169);
			this.secWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideGeneralOTARGenerateKeyLossKey_A8169);
			this.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.AddDependentObject(this.secWideGeneralSecureOperation_A9067);
			this.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.AddDependentObject(this.secWideGeneralSecureOperation_A9067);
			this.RefRadioInformation.General.RadInfoGeneralModelNumber_A8539.AddDependentObject(this.secWideGeneralSecureOperation_A9067);
			this.RefRadioInformation.Labtool.RadInfoLabtoolProductModelIdentifier_A37178.AddDependentObject(this.secWideGeneralSecureOperation_A9067);
			this.secureWideAESAlgorithmEnable_43201.AddDependentObject(this.secWideGeneralSecureOperation_A9067);
			this.secureWideDESAlgorithmEnable_43744.AddDependentObject(this.secWideGeneralSecureOperation_A9067);
			this.secWideGeneralOTAREnable_A7966.AddDependentObject(this.secWideGeneralSecureOperation_A9067);
			secureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.secWideGeneralSecureOperation_A9067);
			this.secWideGeneralOTAREnable_A7966.AddDependentObject(this.secWideGeneralEnhancedADPRadioInhibit_A41461);
			this.secWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideGeneralEnhancedADPRadioInhibit_A41461);
			this.secWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideInfiniteUKEKRetention_A41551);
			secureWide.Features.SecWideFeaturesInfiniteKeyRetention_A8292.AddDependentObject(this.secWideInfiniteUKEKRetention_A41551);
			this.secWideGeneralSecureOperation_A9067.AddDependentObject(this.secureWideADPAlgorithmEnable_43200);
			this.secWideGeneralSecureOperation_A9067.AddDependentObject(this.secureWideAESAlgorithmEnable_43201);
			this.secWideGeneralSecureOperation_A9067.AddDependentObject(this.secureWideDESAlgorithmEnable_43744);
			this.secWideGeneralSecureOperation_A9067.AddDependentObject(this.secureWideKeyloadingSource_43204);
			this.secureWideAESAlgorithmEnable_43201.AddDependentObject(this.secureWideKeyloadingSource_43204);
			this.secureWideDESAlgorithmEnable_43744.AddDependentObject(this.secureWideKeyloadingSource_43204);
			this.secWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideKeyListMgmtEraseAllKeys_43648);
			this.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideGeneralOTAROperation_43700);
			this.secWideGeneralOTAROperation_43700.AddDependentObject(this.secWideGeneralOTAREnable_A7966);
			this.secWideGeneralOTAROperation_43700.AddDependentObject(secureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496);
			this.secWideGeneralOTAROperation_43700.AddDependentObject(secureWide.MDCOTAR.SecWideMDCOTAREnable_A7967);
			this.secWideGeneralOTAREnable_A7966.AddDependentObject(this.secWideGeneralOTAROperation_43700);
		}

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x06002056 RID: 8278 RVA: 0x00201EC4 File Offset: 0x002000C4
		public bool HasDiffs
		{
			get
			{
				short num = (short)1374247634;
				short num2 = num;
				num = (short)1617320658;
				switch (num2 == num)
				{
				}
				num = (short)896532481;
				if (num != 0)
				{
				}
				num = (short)1037565952;
				short num3 = num;
				num = (short)1565392896;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x06002057 RID: 8279 RVA: 0x00201F74 File Offset: 0x00200174
		// (set) Token: 0x06002058 RID: 8280 RVA: 0x0020202C File Offset: 0x0020022C
		public bool SecWideGeneralOTAREnable_A7966Value
		{
			get
			{
				short num = (short)1395625808;
				short num2 = num;
				num = (short)1770360656;
				switch (num2 == num)
				{
				}
				num = (short)269287424;
				if (num != 0)
				{
				}
				num = (short)384368640;
				short num3 = num;
				num = (short)13041665;
				if (num != 0)
				{
				}
				return this.secWideGeneralOTAREnable_A7966.Value;
			}
			set
			{
				short num = (short)438731225;
				short num2 = num;
				num = (short)1361543641;
				switch (num2 == num)
				{
				}
				num = (short)954466304;
				if (num != 0)
				{
				}
				num = (short)58195968;
				short num3 = num;
				num = (short)74842113;
				if (num != 0)
				{
				}
				this.secWideGeneralOTAREnable_A7966.Value = value;
			}
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x06002059 RID: 8281 RVA: 0x002020E4 File Offset: 0x002002E4
		public global::AcpBusinessLayer.AcpField<bool> SecWideGeneralOTAREnable_A7966
		{
			get
			{
				short num = (short)517793762;
				short num2 = num;
				num = (short)958719970;
				switch (num2 == num)
				{
				}
				num = (short)441778176;
				if (num != 0)
				{
				}
				num = (short)1833566208;
				short num3 = num;
				num = (short)699269121;
				if (num != 0)
				{
				}
				return this.secWideGeneralOTAREnable_A7966;
			}
		}

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x0600205A RID: 8282 RVA: 0x00202194 File Offset: 0x00200394
		// (set) Token: 0x0600205B RID: 8283 RVA: 0x0020224C File Offset: 0x0020044C
		public bool SecWideGeneralOTAREnable_A7966_UIValue
		{
			get
			{
				short num = (short)890920435;
				short num2 = num;
				num = (short)2024693235;
				switch (num2 == num)
				{
				}
				num = (short)1270743040;
				if (num != 0)
				{
				}
				num = (short)2063073280;
				short num3 = num;
				num = (short)744357889;
				if (num != 0)
				{
				}
				return this.secWideGeneralOTAREnable_A7966.Value;
			}
			set
			{
				short num = (short)559284225;
				if (num != 0)
				{
				}
				num = (short)1693981655;
				short num2 = num;
				num = (short)1942100951;
				switch (num2 == num)
				{
				}
				num = (short)402194432;
				short num3 = num;
				num = (short)1751973888;
				if (num != 0)
				{
				}
				this.secWideGeneralOTAREnable_A7966.Value = value;
			}
		}

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x0600205C RID: 8284 RVA: 0x00202300 File Offset: 0x00200500
		// (set) Token: 0x0600205D RID: 8285 RVA: 0x002023B4 File Offset: 0x002005B4
		public bool SecWideGeneralOTAREnable_A7966_Applicable
		{
			get
			{
				short num = (short)881952139;
				short num2 = num;
				num = (short)676758923;
				switch (num2 == num)
				{
				}
				num = (short)937951233;
				if (num != 0)
				{
				}
				num = (short)1868955648;
				short num3 = num;
				num = (short)117112832;
				if (num != 0)
				{
				}
				return this.secWideGeneralOTAREnable_A7966.Applicable;
			}
			set
			{
				short num = (short)821333081;
				short num2 = num;
				num = (short)1389268057;
				switch (num2 == num)
				{
				}
				num = (short)2107506689;
				if (num != 0)
				{
				}
				num = (short)1676935168;
				short num3 = num;
				num = (short)1963720704;
				if (num != 0)
				{
				}
				this.secWideGeneralOTAREnable_A7966.Applicable = value;
			}
		}

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x0600205E RID: 8286 RVA: 0x0020246C File Offset: 0x0020066C
		// (set) Token: 0x0600205F RID: 8287 RVA: 0x00202520 File Offset: 0x00200720
		public bool SecWideGeneralOTAREnable_A7966_Valid
		{
			get
			{
				short num = (short)197173354;
				short num2 = num;
				num = (short)1573036138;
				switch (num2 == num)
				{
				}
				num = (short)429064193;
				if (num != 0)
				{
				}
				num = (short)1197146112;
				short num3 = num;
				num = (short)1461518336;
				if (num != 0)
				{
				}
				return this.secWideGeneralOTAREnable_A7966.Valid;
			}
			set
			{
				short num = (short)171507713;
				if (num != 0)
				{
				}
				num = (short)713531682;
				short num2 = num;
				num = (short)295280930;
				switch (num2 == num)
				{
				}
				num = (short)1631715328;
				short num3 = num;
				num = (short)1350041600;
				if (num != 0)
				{
				}
				this.secWideGeneralOTAREnable_A7966.Valid = value;
			}
		}

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x06002060 RID: 8288 RVA: 0x002025D4 File Offset: 0x002007D4
		// (set) Token: 0x06002061 RID: 8289 RVA: 0x00202688 File Offset: 0x00200888
		public bool SecWideGeneralOTAREnable_A7966_Visible
		{
			get
			{
				short num = (short)1053550300;
				short num2 = num;
				num = (short)1977476828;
				switch (num2 == num)
				{
				}
				num = (short)47972353;
				if (num != 0)
				{
				}
				num = (short)1894776832;
				short num3 = num;
				num = (short)1543110656;
				if (num != 0)
				{
				}
				return this.secWideGeneralOTAREnable_A7966.Visible;
			}
			set
			{
				short num = (short)726597633;
				if (num != 0)
				{
				}
				num = (short)2056720229;
				short num2 = num;
				num = (short)826150757;
				switch (num2 == num)
				{
				}
				num = (short)1428619264;
				short num3 = num;
				num = (short)1595867136;
				if (num != 0)
				{
				}
				this.secWideGeneralOTAREnable_A7966.Visible = value;
			}
		}

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x06002062 RID: 8290 RVA: 0x00202740 File Offset: 0x00200940
		// (set) Token: 0x06002063 RID: 8291 RVA: 0x002027F8 File Offset: 0x002009F8
		public bool SecWideGeneralOTAREnable_A7966_Editable
		{
			get
			{
				short num = (short)1545722034;
				short num2 = num;
				num = (short)1136711858;
				switch (num2 == num)
				{
				}
				num = (short)1042350081;
				if (num != 0)
				{
				}
				num = (short)1817378816;
				short num3 = num;
				num = (short)637730816;
				if (num != 0)
				{
				}
				return this.secWideGeneralOTAREnable_A7966.Editable;
			}
			set
			{
				short num = (short)756088833;
				if (num != 0)
				{
				}
				num = (short)1697026187;
				short num2 = num;
				num = (short)1278972043;
				switch (num2 == num)
				{
				}
				num = (short)5046272;
				short num3 = num;
				num = (short)1922236416;
				if (num != 0)
				{
				}
				this.secWideGeneralOTAREnable_A7966.Editable = value;
			}
		}

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x06002064 RID: 8292 RVA: 0x002028AC File Offset: 0x00200AAC
		internal string SecWideGeneralOTAREnable_A7966_UILabel
		{
			get
			{
				short num = (short)1107049734;
				short num2 = num;
				num = (short)244530438;
				switch (num2 == num)
				{
				}
				num = (short)294977536;
				if (num != 0)
				{
				}
				num = (short)211681280;
				short num3 = num;
				num = (short)1944125441;
				if (num != 0)
				{
				}
				return this.secWideGeneralOTAREnable_A7966.UIName;
			}
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x06002065 RID: 8293 RVA: 0x00202960 File Offset: 0x00200B60
		// (set) Token: 0x06002066 RID: 8294 RVA: 0x00202A14 File Offset: 0x00200C14
		internal bool SecWideGeneralOTAREnable_A7966_HiddenStatic
		{
			get
			{
				short num = (short)816768637;
				short num2 = num;
				num = (short)111208061;
				switch (num2 == num)
				{
				}
				num = (short)1367998465;
				if (num != 0)
				{
				}
				num = (short)392691712;
				short num3 = num;
				num = (short)2078998528;
				if (num != 0)
				{
				}
				return this.secWideGeneralOTAREnable_A7966.HiddenStatic;
			}
			set
			{
				short num = (short)120488880;
				short num2 = num;
				num = (short)76907440;
				switch (num2 == num)
				{
				}
				num = (short)1207500801;
				if (num != 0)
				{
				}
				num = (short)834928640;
				short num3 = num;
				num = (short)702742528;
				if (num != 0)
				{
				}
				this.secWideGeneralOTAREnable_A7966.HiddenStatic = value;
			}
		}

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x06002067 RID: 8295 RVA: 0x00202ACC File Offset: 0x00200CCC
		// (set) Token: 0x06002068 RID: 8296 RVA: 0x00202B80 File Offset: 0x00200D80
		internal bool SecWideGeneralOTAREnable_A7966_HiddenDynamic
		{
			get
			{
				short num = (short)658853672;
				short num2 = num;
				num = (short)515591976;
				switch (num2 == num)
				{
				}
				num = (short)1457127425;
				if (num != 0)
				{
				}
				num = (short)724762624;
				short num3 = num;
				num = (short)1447755776;
				if (num != 0)
				{
				}
				return this.secWideGeneralOTAREnable_A7966.HiddenDynamic;
			}
			set
			{
				short num = (short)1639919024;
				short num2 = num;
				num = (short)153824688;
				switch (num2 == num)
				{
				}
				num = (short)1403518976;
				if (num != 0)
				{
				}
				num = (short)1519910912;
				short num3 = num;
				num = (short)1683226625;
				if (num != 0)
				{
				}
				this.secWideGeneralOTAREnable_A7966.HiddenDynamic = value;
			}
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x06002069 RID: 8297 RVA: 0x00202C38 File Offset: 0x00200E38
		public bool SecWideGeneralOTAREnable_A7966_HasDiffs
		{
			get
			{
				short num = (short)1866281940;
				short num2 = num;
				num = (short)1301754836;
				switch (num2 == num)
				{
				}
				num = (short)1434845185;
				if (num != 0)
				{
				}
				num = (short)259981312;
				short num3 = num;
				num = (short)1621753856;
				if (num != 0)
				{
				}
				return this.secWideGeneralOTAREnable_A7966._HasDiffs;
			}
		}

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x0600206A RID: 8298 RVA: 0x00202CEC File Offset: 0x00200EEC
		// (set) Token: 0x0600206B RID: 8299 RVA: 0x00202DA0 File Offset: 0x00200FA0
		public bool SecWideMultikeyErasePreviousOnUserChange_A8373Value
		{
			get
			{
				short num = (short)2084289434;
				short num2 = num;
				num = (short)1572256666;
				switch (num2 == num)
				{
				}
				num = (short)1266548737;
				if (num != 0)
				{
				}
				num = (short)1037303808;
				short num3 = num;
				num = (short)678887424;
				if (num != 0)
				{
				}
				return this.secWideMultikeyErasePreviousOnUserChange_A8373.Value;
			}
			set
			{
				short num = (short)113666984;
				short num2 = num;
				num = (short)990800808;
				switch (num2 == num)
				{
				}
				num = (short)524419073;
				if (num != 0)
				{
				}
				num = (short)902168576;
				short num3 = num;
				num = (short)133300224;
				if (num != 0)
				{
				}
				this.secWideMultikeyErasePreviousOnUserChange_A8373.Value = value;
			}
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x0600206C RID: 8300 RVA: 0x00202E54 File Offset: 0x00201054
		public global::AcpBusinessLayer.AcpField<bool> SecWideMultikeyErasePreviousOnUserChange_A8373
		{
			get
			{
				short num = (short)570284220;
				short num2 = num;
				num = (short)1346427068;
				switch (num2 == num)
				{
				}
				num = (short)1032126465;
				if (num != 0)
				{
				}
				num = (short)2032861184;
				short num3 = num;
				num = (short)1091960832;
				if (num != 0)
				{
				}
				return this.secWideMultikeyErasePreviousOnUserChange_A8373;
			}
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x0600206D RID: 8301 RVA: 0x00202F04 File Offset: 0x00201104
		// (set) Token: 0x0600206E RID: 8302 RVA: 0x00202FB8 File Offset: 0x002011B8
		public bool SecWideMultikeyErasePreviousOnUserChange_A8373_UIValue
		{
			get
			{
				short num = (short)492472576;
				short num2 = num;
				num = (short)1946323200;
				switch (num2 == num)
				{
				}
				num = (short)1698496513;
				if (num != 0)
				{
				}
				num = (short)943325184;
				short num3 = num;
				num = (short)1143930880;
				if (num != 0)
				{
				}
				return this.secWideMultikeyErasePreviousOnUserChange_A8373.Value;
			}
			set
			{
				short num = (short)841328470;
				short num2 = num;
				num = (short)1960355670;
				switch (num2 == num)
				{
				}
				num = (short)664600576;
				if (num != 0)
				{
				}
				num = (short)1106575360;
				short num3 = num;
				num = (short)1805058049;
				if (num != 0)
				{
				}
				this.secWideMultikeyErasePreviousOnUserChange_A8373.Value = value;
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x0600206F RID: 8303 RVA: 0x00203070 File Offset: 0x00201270
		// (set) Token: 0x06002070 RID: 8304 RVA: 0x00203128 File Offset: 0x00201328
		public bool SecWideMultikeyErasePreviousOnUserChange_A8373_Applicable
		{
			get
			{
				short num = (short)830437870;
				short num2 = num;
				num = (short)1530624494;
				switch (num2 == num)
				{
				}
				num = (short)726073345;
				if (num != 0)
				{
				}
				num = (short)2146238464;
				short num3 = num;
				num = (short)114556928;
				if (num != 0)
				{
				}
				return this.secWideMultikeyErasePreviousOnUserChange_A8373.Applicable;
			}
			set
			{
				short num = (short)1168237221;
				short num2 = num;
				num = (short)1459151525;
				switch (num2 == num)
				{
				}
				num = (short)1612578817;
				if (num != 0)
				{
				}
				num = (short)1396113408;
				short num3 = num;
				num = (short)1229520896;
				if (num != 0)
				{
				}
				this.secWideMultikeyErasePreviousOnUserChange_A8373.Applicable = value;
			}
		}

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x06002071 RID: 8305 RVA: 0x002031E0 File Offset: 0x002013E0
		// (set) Token: 0x06002072 RID: 8306 RVA: 0x00203294 File Offset: 0x00201494
		public bool SecWideMultikeyErasePreviousOnUserChange_A8373_Valid
		{
			get
			{
				short num = (short)284569854;
				short num2 = num;
				num = (short)2073112830;
				switch (num2 == num)
				{
				}
				num = (short)1524891648;
				if (num != 0)
				{
				}
				num = (short)2025127936;
				short num3 = num;
				num = (short)67305473;
				if (num != 0)
				{
				}
				return this.secWideMultikeyErasePreviousOnUserChange_A8373.Valid;
			}
			set
			{
				short num = (short)481407595;
				short num2 = num;
				num = (short)663204459;
				switch (num2 == num)
				{
				}
				num = (short)1769013249;
				if (num != 0)
				{
				}
				num = (short)1210122240;
				short num3 = num;
				num = (short)370016256;
				if (num != 0)
				{
				}
				this.secWideMultikeyErasePreviousOnUserChange_A8373.Valid = value;
			}
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x06002073 RID: 8307 RVA: 0x0020334C File Offset: 0x0020154C
		// (set) Token: 0x06002074 RID: 8308 RVA: 0x00203404 File Offset: 0x00201604
		public bool SecWideMultikeyErasePreviousOnUserChange_A8373_Visible
		{
			get
			{
				short num = (short)1696546221;
				short num2 = num;
				num = (short)1771519405;
				switch (num2 == num)
				{
				}
				num = (short)1088356353;
				if (num != 0)
				{
				}
				num = (short)815005696;
				short num3 = num;
				num = (short)112394240;
				if (num != 0)
				{
				}
				return this.secWideMultikeyErasePreviousOnUserChange_A8373.Visible;
			}
			set
			{
				short num = (short)27363907;
				short num2 = num;
				num = (short)38767171;
				switch (num2 == num)
				{
				}
				num = (short)1769472001;
				if (num != 0)
				{
				}
				num = (short)960561152;
				short num3 = num;
				num = (short)381419520;
				if (num != 0)
				{
				}
				this.secWideMultikeyErasePreviousOnUserChange_A8373.Visible = value;
			}
		}

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x002034B8 File Offset: 0x002016B8
		// (set) Token: 0x06002076 RID: 8310 RVA: 0x0020356C File Offset: 0x0020176C
		public bool SecWideMultikeyErasePreviousOnUserChange_A8373_Editable
		{
			get
			{
				short num = (short)2074909349;
				short num2 = num;
				num = (short)1498061477;
				switch (num2 == num)
				{
				}
				num = (short)479789057;
				if (num != 0)
				{
				}
				num = (short)2133721088;
				short num3 = num;
				num = (short)964231168;
				if (num != 0)
				{
				}
				return this.secWideMultikeyErasePreviousOnUserChange_A8373.Editable;
			}
			set
			{
				short num = (short)1116574642;
				short num2 = num;
				num = (short)824415154;
				switch (num2 == num)
				{
				}
				num = (short)1121189889;
				if (num != 0)
				{
				}
				num = (short)1269104640;
				short num3 = num;
				num = (short)1517551616;
				if (num != 0)
				{
				}
				this.secWideMultikeyErasePreviousOnUserChange_A8373.Editable = value;
			}
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x00203620 File Offset: 0x00201820
		internal string SecWideMultikeyErasePreviousOnUserChange_A8373_UILabel
		{
			get
			{
				short num = (short)2053786025;
				short num2 = num;
				num = (short)1777027497;
				switch (num2 == num)
				{
				}
				num = (short)372703232;
				if (num != 0)
				{
				}
				num = (short)802291712;
				short num3 = num;
				num = (short)1003094017;
				if (num != 0)
				{
				}
				return this.secWideMultikeyErasePreviousOnUserChange_A8373.UIName;
			}
		}

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x06002078 RID: 8312 RVA: 0x002036D4 File Offset: 0x002018D4
		// (set) Token: 0x06002079 RID: 8313 RVA: 0x00203788 File Offset: 0x00201988
		internal bool SecWideMultikeyErasePreviousOnUserChange_A8373_HiddenStatic
		{
			get
			{
				short num = (short)1186872916;
				short num2 = num;
				num = (short)328613460;
				switch (num2 == num)
				{
				}
				num = (short)1596260353;
				if (num != 0)
				{
				}
				num = (short)1148059648;
				short num3 = num;
				num = (short)2000355328;
				if (num != 0)
				{
				}
				return this.secWideMultikeyErasePreviousOnUserChange_A8373.HiddenStatic;
			}
			set
			{
				short num = (short)257163265;
				if (num != 0)
				{
				}
				num = (short)1979339571;
				short num2 = num;
				num = (short)1497518899;
				switch (num2 == num)
				{
				}
				num = (short)1085538304;
				short num3 = num;
				num = (short)680919040;
				if (num != 0)
				{
				}
				this.secWideMultikeyErasePreviousOnUserChange_A8373.HiddenStatic = value;
			}
		}

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x0600207A RID: 8314 RVA: 0x00203840 File Offset: 0x00201A40
		// (set) Token: 0x0600207B RID: 8315 RVA: 0x002038F4 File Offset: 0x00201AF4
		internal bool SecWideMultikeyErasePreviousOnUserChange_A8373_HiddenDynamic
		{
			get
			{
				short num = (short)1183527701;
				short num2 = num;
				num = (short)1239560981;
				switch (num2 == num)
				{
				}
				num = (short)433192961;
				if (num != 0)
				{
				}
				num = (short)366936064;
				short num3 = num;
				num = (short)1196228608;
				if (num != 0)
				{
				}
				return this.secWideMultikeyErasePreviousOnUserChange_A8373.HiddenDynamic;
			}
			set
			{
				short num = (short)585202307;
				short num2 = num;
				num = (short)2021227139;
				switch (num2 == num)
				{
				}
				num = (short)766443521;
				if (num != 0)
				{
				}
				num = (short)1855389696;
				short num3 = num;
				num = (short)1112932352;
				if (num != 0)
				{
				}
				this.secWideMultikeyErasePreviousOnUserChange_A8373.HiddenDynamic = value;
			}
		}

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x0600207C RID: 8316 RVA: 0x002039AC File Offset: 0x00201BAC
		public bool SecWideMultikeyErasePreviousOnUserChange_A8373_HasDiffs
		{
			get
			{
				short num = (short)1741519943;
				short num2 = num;
				num = (short)1213430855;
				switch (num2 == num)
				{
				}
				num = (short)124059648;
				if (num != 0)
				{
				}
				num = (short)814022656;
				short num3 = num;
				num = (short)441974785;
				if (num != 0)
				{
				}
				return this.secWideMultikeyErasePreviousOnUserChange_A8373._HasDiffs;
			}
		}

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x0600207D RID: 8317 RVA: 0x00203A64 File Offset: 0x00201C64
		// (set) Token: 0x0600207E RID: 8318 RVA: 0x00203B18 File Offset: 0x00201D18
		public bool SecWideMultikeyUserSelectable_A9604Value
		{
			get
			{
				short num = (short)2137642177;
				short num2 = num;
				num = (short)780260545;
				switch (num2 == num)
				{
				}
				num = (short)1915551745;
				if (num != 0)
				{
				}
				num = (short)2063728640;
				short num3 = num;
				num = (short)450232320;
				if (num != 0)
				{
				}
				return this.secWideMultikeyUserSelectable_A9604.Value;
			}
			set
			{
				short num = (short)556409861;
				short num2 = num;
				num = (short)1240212485;
				switch (num2 == num)
				{
				}
				num = (short)231145473;
				if (num != 0)
				{
				}
				num = (short)93978624;
				short num3 = num;
				num = (short)732299264;
				if (num != 0)
				{
				}
				this.secWideMultikeyUserSelectable_A9604.Value = value;
			}
		}

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x0600207F RID: 8319 RVA: 0x00203BCC File Offset: 0x00201DCC
		public global::AcpBusinessLayer.AcpField<bool> SecWideMultikeyUserSelectable_A9604
		{
			get
			{
				short num = (short)1985468178;
				short num2 = num;
				num = (short)1869666066;
				switch (num2 == num)
				{
				}
				num = (short)332005377;
				if (num != 0)
				{
				}
				num = (short)2041774080;
				short num3 = num;
				num = (short)1534525440;
				if (num != 0)
				{
				}
				return this.secWideMultikeyUserSelectable_A9604;
			}
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x06002080 RID: 8320 RVA: 0x00203C80 File Offset: 0x00201E80
		// (set) Token: 0x06002081 RID: 8321 RVA: 0x00203D34 File Offset: 0x00201F34
		public bool SecWideMultikeyUserSelectable_A9604_UIValue
		{
			get
			{
				short num = (short)995923258;
				short num2 = num;
				num = (short)193959226;
				switch (num2 == num)
				{
				}
				num = (short)1057619969;
				if (num != 0)
				{
				}
				num = (short)1237385216;
				short num3 = num;
				num = (short)1167261696;
				if (num != 0)
				{
				}
				return this.secWideMultikeyUserSelectable_A9604.Value;
			}
			set
			{
				short num = (short)1734322792;
				short num2 = num;
				num = (short)1029548648;
				switch (num2 == num)
				{
				}
				num = (short)562888705;
				if (num != 0)
				{
				}
				num = (short)2034302976;
				short num3 = num;
				num = (short)1591672832;
				if (num != 0)
				{
				}
				this.secWideMultikeyUserSelectable_A9604.Value = value;
			}
		}

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x06002082 RID: 8322 RVA: 0x00203DEC File Offset: 0x00201FEC
		// (set) Token: 0x06002083 RID: 8323 RVA: 0x00203EA0 File Offset: 0x002020A0
		public bool SecWideMultikeyUserSelectable_A9604_Applicable
		{
			get
			{
				short num = (short)428300647;
				short num2 = num;
				num = (short)1779194215;
				switch (num2 == num)
				{
				}
				num = (short)1275133953;
				if (num != 0)
				{
				}
				num = (short)996605952;
				short num3 = num;
				num = (short)1627389952;
				if (num != 0)
				{
				}
				return this.secWideMultikeyUserSelectable_A9604.Applicable;
			}
			set
			{
				short num = (short)1663844678;
				short num2 = num;
				num = (short)3490118;
				switch (num2 == num)
				{
				}
				num = (short)1161691137;
				if (num != 0)
				{
				}
				num = (short)1036189696;
				short num3 = num;
				num = (short)196542464;
				if (num != 0)
				{
				}
				this.secWideMultikeyUserSelectable_A9604.Applicable = value;
			}
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x06002084 RID: 8324 RVA: 0x00203F54 File Offset: 0x00202154
		// (set) Token: 0x06002085 RID: 8325 RVA: 0x0020400C File Offset: 0x0020220C
		public bool SecWideMultikeyUserSelectable_A9604_Valid
		{
			get
			{
				short num = (short)607640159;
				short num2 = num;
				num = (short)2084035167;
				switch (num2 == num)
				{
				}
				num = (short)1703542784;
				short num3 = num;
				num = (short)1369505793;
				if (num != 0)
				{
				}
				num = (short)994705408;
				if (num != 0)
				{
				}
				return this.secWideMultikeyUserSelectable_A9604.Valid;
			}
			set
			{
				short num = (short)2113585270;
				short num2 = num;
				num = (short)1422966902;
				switch (num2 == num)
				{
				}
				num = (short)1742995456;
				short num3 = num;
				num = (short)462618625;
				if (num != 0)
				{
				}
				num = (short)2075131904;
				if (num != 0)
				{
				}
				this.secWideMultikeyUserSelectable_A9604.Valid = value;
			}
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x06002086 RID: 8326 RVA: 0x002040C0 File Offset: 0x002022C0
		// (set) Token: 0x06002087 RID: 8327 RVA: 0x00204174 File Offset: 0x00202374
		public bool SecWideMultikeyUserSelectable_A9604_Visible
		{
			get
			{
				short num = (short)612040705;
				if (num != 0)
				{
				}
				num = (short)559769547;
				short num2 = num;
				num = (short)963078091;
				switch (num2 == num)
				{
				default:
				{
					num = (short)750125056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1917190144;
				if (num != 0)
				{
				}
				return this.secWideMultikeyUserSelectable_A9604.Visible;
			}
			set
			{
				short num = (short)1998913537;
				if (num != 0)
				{
				}
				num = (short)699641671;
				short num2 = num;
				num = (short)83996487;
				switch (num2 == num)
				{
				default:
				{
					num = (short)893779968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1789526016;
				if (num != 0)
				{
				}
				this.secWideMultikeyUserSelectable_A9604.Visible = value;
			}
		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x06002088 RID: 8328 RVA: 0x00204228 File Offset: 0x00202428
		// (set) Token: 0x06002089 RID: 8329 RVA: 0x002042DC File Offset: 0x002024DC
		public bool SecWideMultikeyUserSelectable_A9604_Editable
		{
			get
			{
				short num = (short)440114768;
				short num2 = num;
				num = (short)1003069008;
				switch (num2 == num)
				{
				}
				num = (short)2010251264;
				short num3 = num;
				num = (short)1220476928;
				if (num != 0)
				{
				}
				num = (short)105512961;
				if (num != 0)
				{
				}
				return this.secWideMultikeyUserSelectable_A9604.Editable;
			}
			set
			{
				short num = (short)1078172927;
				short num2 = num;
				num = (short)294362367;
				switch (num2 == num)
				{
				}
				num = (short)679804928;
				short num3 = num;
				num = (short)309460993;
				if (num != 0)
				{
				}
				num = (short)946995200;
				if (num != 0)
				{
				}
				this.secWideMultikeyUserSelectable_A9604.Editable = value;
			}
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x0600208A RID: 8330 RVA: 0x00204390 File Offset: 0x00202590
		internal string SecWideMultikeyUserSelectable_A9604_UILabel
		{
			get
			{
				short num = (short)1082277842;
				short num2 = num;
				num = (short)1363623890;
				switch (num2 == num)
				{
				}
				num = (short)823984128;
				short num3 = num;
				num = (short)1751187457;
				if (num != 0)
				{
				}
				num = (short)1202913280;
				if (num != 0)
				{
				}
				return this.secWideMultikeyUserSelectable_A9604.UIName;
			}
		}

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x0600208B RID: 8331 RVA: 0x00204444 File Offset: 0x00202644
		// (set) Token: 0x0600208C RID: 8332 RVA: 0x002044F8 File Offset: 0x002026F8
		internal bool SecWideMultikeyUserSelectable_A9604_HiddenStatic
		{
			get
			{
				short num = (short)440467457;
				if (num != 0)
				{
				}
				num = (short)1189479351;
				short num2 = num;
				num = (short)96076727;
				switch (num2 == num)
				{
				default:
				{
					num = (short)565575680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)717881344;
				if (num != 0)
				{
				}
				return this.secWideMultikeyUserSelectable_A9604.HiddenStatic;
			}
			set
			{
				short num = (short)72824183;
				short num2 = num;
				num = (short)1451832695;
				switch (num2 == num)
				{
				}
				num = (short)1823277056;
				short num3 = num;
				num = (short)977862657;
				if (num != 0)
				{
				}
				num = (short)394133504;
				if (num != 0)
				{
				}
				this.secWideMultikeyUserSelectable_A9604.HiddenStatic = value;
			}
		}

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x002045B0 File Offset: 0x002027B0
		// (set) Token: 0x0600208E RID: 8334 RVA: 0x00204668 File Offset: 0x00202868
		internal bool SecWideMultikeyUserSelectable_A9604_HiddenDynamic
		{
			get
			{
				short num = (short)423100417;
				if (num != 0)
				{
				}
				num = (short)887222058;
				short num2 = num;
				num = (short)570683178;
				switch (num2 == num)
				{
				default:
				{
					num = (short)840761344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)140115968;
				if (num != 0)
				{
				}
				return this.secWideMultikeyUserSelectable_A9604.HiddenDynamic;
			}
			set
			{
				short num = (short)1982641812;
				short num2 = num;
				num = (short)1676195476;
				switch (num2 == num)
				{
				}
				num = (short)72155136;
				short num3 = num;
				num = (short)1106968577;
				if (num != 0)
				{
				}
				num = (short)256114688;
				if (num != 0)
				{
				}
				this.secWideMultikeyUserSelectable_A9604.HiddenDynamic = value;
			}
		}

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x00204720 File Offset: 0x00202920
		public bool SecWideMultikeyUserSelectable_A9604_HasDiffs
		{
			get
			{
				short num = (short)709621976;
				short num2 = num;
				num = (short)443611352;
				switch (num2 == num)
				{
				}
				num = (short)1438449664;
				short num3 = num;
				num = (short)859242497;
				if (num != 0)
				{
				}
				num = (short)587137024;
				if (num != 0)
				{
				}
				return this.secWideMultikeyUserSelectable_A9604._HasDiffs;
			}
		}

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x06002090 RID: 8336 RVA: 0x002047D4 File Offset: 0x002029D4
		// (set) Token: 0x06002091 RID: 8337 RVA: 0x0020488C File Offset: 0x00202A8C
		public bool SecureConfigurationSecureWide_A19833Value
		{
			get
			{
				short num = (short)1930510475;
				short num2 = num;
				num = (short)250429579;
				switch (num2 == num)
				{
				}
				num = (short)1771110400;
				short num3 = num;
				num = (short)962199552;
				if (num != 0)
				{
				}
				num = (short)976683009;
				if (num != 0)
				{
				}
				return this.secureConfigurationSecureWide_A19833.Value;
			}
			set
			{
				short num = (short)1289020421;
				short num2 = num;
				num = (short)1980163077;
				switch (num2 == num)
				{
				}
				num = (short)2130837504;
				short num3 = num;
				num = (short)1246167041;
				if (num != 0)
				{
				}
				num = (short)110821376;
				if (num != 0)
				{
				}
				this.secureConfigurationSecureWide_A19833.Value = value;
			}
		}

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x06002092 RID: 8338 RVA: 0x00204944 File Offset: 0x00202B44
		public global::AcpBusinessLayer.AcpField<bool> SecureConfigurationSecureWide_A19833
		{
			get
			{
				short num = (short)1299462450;
				short num2 = num;
				num = (short)1370372402;
				switch (num2 == num)
				{
				}
				num = (short)737869824;
				short num3 = num;
				num = (short)2088108033;
				if (num != 0)
				{
				}
				num = (short)1921974272;
				if (num != 0)
				{
				}
				return this.secureConfigurationSecureWide_A19833;
			}
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x06002093 RID: 8339 RVA: 0x002049F4 File Offset: 0x00202BF4
		// (set) Token: 0x06002094 RID: 8340 RVA: 0x00204AAC File Offset: 0x00202CAC
		public bool SecureConfigurationSecureWide_A19833_UIValue
		{
			get
			{
				short num = (short)1569412236;
				short num2 = num;
				num = (short)1973113996;
				switch (num2 == num)
				{
				}
				num = (short)565706752;
				short num3 = num;
				num = (short)1729167361;
				if (num != 0)
				{
				}
				num = (short)465567744;
				if (num != 0)
				{
				}
				return this.secureConfigurationSecureWide_A19833.Value;
			}
			set
			{
				short num = (short)1972230637;
				short num2 = num;
				num = (short)1817434605;
				switch (num2 == num)
				{
				}
				num = (short)1861681152;
				short num3 = num;
				num = (short)852033537;
				if (num != 0)
				{
				}
				num = (short)458227712;
				if (num != 0)
				{
				}
				this.secureConfigurationSecureWide_A19833.Value = value;
			}
		}

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x06002095 RID: 8341 RVA: 0x00204B64 File Offset: 0x00202D64
		// (set) Token: 0x06002096 RID: 8342 RVA: 0x00204C18 File Offset: 0x00202E18
		public bool SecureConfigurationSecureWide_A19833_Applicable
		{
			get
			{
				short num = (short)2037998269;
				short num2 = num;
				num = (short)1614308029;
				switch (num2 == num)
				{
				}
				num = (short)299696128;
				short num3 = num;
				num = (short)340656129;
				if (num != 0)
				{
				}
				num = (short)2067857408;
				if (num != 0)
				{
				}
				return this.secureConfigurationSecureWide_A19833.Applicable;
			}
			set
			{
				short num = (short)1418991327;
				short num2 = num;
				num = (short)1205278431;
				switch (num2 == num)
				{
				}
				num = (short)5898240;
				short num3 = num;
				num = (short)934281217;
				if (num != 0)
				{
				}
				num = (short)1661075456;
				if (num != 0)
				{
				}
				this.secureConfigurationSecureWide_A19833.Applicable = value;
			}
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x06002097 RID: 8343 RVA: 0x00204CCC File Offset: 0x00202ECC
		// (set) Token: 0x06002098 RID: 8344 RVA: 0x00204D80 File Offset: 0x00202F80
		public bool SecureConfigurationSecureWide_A19833_Valid
		{
			get
			{
				short num = (short)224021558;
				short num2 = num;
				num = (short)789662774;
				switch (num2 == num)
				{
				}
				num = (short)52101120;
				short num3 = num;
				num = (short)1307705344;
				if (num != 0)
				{
				}
				num = (short)1920598017;
				if (num != 0)
				{
				}
				return this.secureConfigurationSecureWide_A19833.Valid;
			}
			set
			{
				short num = (short)1205238707;
				short num2 = num;
				num = (short)381582259;
				switch (num2 == num)
				{
				}
				num = (short)1637154816;
				short num3 = num;
				num = (short)544276480;
				if (num != 0)
				{
				}
				num = (short)901840897;
				if (num != 0)
				{
				}
				this.secureConfigurationSecureWide_A19833.Valid = value;
			}
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x06002099 RID: 8345 RVA: 0x00204E38 File Offset: 0x00203038
		// (set) Token: 0x0600209A RID: 8346 RVA: 0x00204EEC File Offset: 0x002030EC
		public bool SecureConfigurationSecureWide_A19833_Visible
		{
			get
			{
				short num = (short)659132169;
				short num2 = num;
				num = (short)1647087369;
				switch (num2 == num)
				{
				}
				num = (short)1342373888;
				short num3 = num;
				num = (short)846659585;
				if (num != 0)
				{
				}
				num = (short)1725825024;
				if (num != 0)
				{
				}
				return this.secureConfigurationSecureWide_A19833.Visible;
			}
			set
			{
				short num = (short)1528779319;
				short num2 = num;
				num = (short)1552110135;
				switch (num2 == num)
				{
				}
				num = (short)365953024;
				short num3 = num;
				num = (short)1377304577;
				if (num != 0)
				{
				}
				num = (short)1836711936;
				if (num != 0)
				{
				}
				this.secureConfigurationSecureWide_A19833.Visible = value;
			}
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x0600209B RID: 8347 RVA: 0x00204FA0 File Offset: 0x002031A0
		// (set) Token: 0x0600209C RID: 8348 RVA: 0x00205058 File Offset: 0x00203258
		public bool SecureConfigurationSecureWide_A19833_Editable
		{
			get
			{
				short num = (short)224324051;
				short num2 = num;
				num = (short)1312090579;
				switch (num2 == num)
				{
				}
				num = (short)853540864;
				short num3 = num;
				num = (short)1395523584;
				if (num != 0)
				{
				}
				num = (short)1992818689;
				if (num != 0)
				{
				}
				return this.secureConfigurationSecureWide_A19833.Editable;
			}
			set
			{
				short num = (short)1314829160;
				short num2 = num;
				num = (short)1833153384;
				switch (num2 == num)
				{
				}
				num = (short)1066729472;
				short num3 = num;
				num = (short)1275199489;
				if (num != 0)
				{
				}
				num = (short)604897280;
				if (num != 0)
				{
				}
				this.secureConfigurationSecureWide_A19833.Editable = value;
			}
		}

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x0600209D RID: 8349 RVA: 0x00205110 File Offset: 0x00203310
		internal string SecureConfigurationSecureWide_A19833_UILabel
		{
			get
			{
				short num = (short)1957101569;
				if (num != 0)
				{
				}
				num = (short)1673529645;
				short num2 = num;
				num = (short)2007042349;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1262419968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)791871488;
				if (num != 0)
				{
				}
				return this.secureConfigurationSecureWide_A19833.UIName;
			}
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x0600209E RID: 8350 RVA: 0x002051C4 File Offset: 0x002033C4
		// (set) Token: 0x0600209F RID: 8351 RVA: 0x00205278 File Offset: 0x00203478
		internal bool SecureConfigurationSecureWide_A19833_HiddenStatic
		{
			get
			{
				short num = (short)1340789473;
				short num2 = num;
				num = (short)725603041;
				switch (num2 == num)
				{
				}
				num = (short)530382848;
				short num3 = num;
				num = (short)1648427008;
				if (num != 0)
				{
				}
				num = (short)171900929;
				if (num != 0)
				{
				}
				return this.secureConfigurationSecureWide_A19833.HiddenStatic;
			}
			set
			{
				short num = (short)1510824175;
				short num2 = num;
				num = (short)1802590447;
				switch (num2 == num)
				{
				}
				num = (short)728236032;
				short num3 = num;
				num = (short)1358888961;
				if (num != 0)
				{
				}
				num = (short)763035648;
				if (num != 0)
				{
				}
				this.secureConfigurationSecureWide_A19833.HiddenStatic = value;
			}
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x060020A0 RID: 8352 RVA: 0x00205330 File Offset: 0x00203530
		// (set) Token: 0x060020A1 RID: 8353 RVA: 0x002053E8 File Offset: 0x002035E8
		internal bool SecureConfigurationSecureWide_A19833_HiddenDynamic
		{
			get
			{
				short num = (short)60166095;
				short num2 = num;
				num = (short)683413455;
				switch (num2 == num)
				{
				}
				num = (short)1423245312;
				short num3 = num;
				num = (short)777584641;
				if (num != 0)
				{
				}
				num = (short)480116736;
				if (num != 0)
				{
				}
				return this.secureConfigurationSecureWide_A19833.HiddenDynamic;
			}
			set
			{
				short num = (short)1116595336;
				short num2 = num;
				num = (short)806872200;
				switch (num2 == num)
				{
				}
				num = (short)711327744;
				short num3 = num;
				num = (short)1888944128;
				if (num != 0)
				{
				}
				num = (short)157155329;
				if (num != 0)
				{
				}
				this.secureConfigurationSecureWide_A19833.HiddenDynamic = value;
			}
		}

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x060020A2 RID: 8354 RVA: 0x002054A0 File Offset: 0x002036A0
		public bool SecureConfigurationSecureWide_A19833_HasDiffs
		{
			get
			{
				short num = (short)1128060526;
				short num2 = num;
				num = (short)734910062;
				switch (num2 == num)
				{
				}
				num = (short)2016673792;
				short num3 = num;
				num = (short)1418657793;
				if (num != 0)
				{
				}
				num = (short)1437990912;
				if (num != 0)
				{
				}
				return this.secureConfigurationSecureWide_A19833._HasDiffs;
			}
		}

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x00205554 File Offset: 0x00203754
		// (set) Token: 0x060020A4 RID: 8356 RVA: 0x00205608 File Offset: 0x00203808
		public bool SecWideGeneralOTARGenerateKeyLossKey_A8169Value
		{
			get
			{
				short num = (short)137506387;
				short num2 = num;
				num = (short)1429679699;
				switch (num2 == num)
				{
				}
				num = (short)964362240;
				short num3 = num;
				num = (short)1764884480;
				if (num != 0)
				{
				}
				num = (short)667942913;
				if (num != 0)
				{
				}
				return this.secWideGeneralOTARGenerateKeyLossKey_A8169.Value;
			}
			set
			{
				short num = (short)786640793;
				short num2 = num;
				num = (short)1189621657;
				switch (num2 == num)
				{
				}
				num = (short)271712256;
				short num3 = num;
				num = (short)570818560;
				if (num != 0)
				{
				}
				num = (short)1173815297;
				if (num != 0)
				{
				}
				this.secWideGeneralOTARGenerateKeyLossKey_A8169.Value = value;
			}
		}

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x002056C0 File Offset: 0x002038C0
		public global::AcpBusinessLayer.AcpField<bool> SecWideGeneralOTARGenerateKeyLossKey_A8169
		{
			get
			{
				short num = (short)502464513;
				if (num != 0)
				{
				}
				num = (short)1244358159;
				short num2 = num;
				num = (short)1116956175;
				switch (num2 == num)
				{
				default:
				{
					num = (short)352452608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)331677696;
				if (num != 0)
				{
				}
				return this.secWideGeneralOTARGenerateKeyLossKey_A8169;
			}
		}

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x060020A6 RID: 8358 RVA: 0x00205770 File Offset: 0x00203970
		// (set) Token: 0x060020A7 RID: 8359 RVA: 0x00205824 File Offset: 0x00203A24
		public bool SecWideGeneralOTARGenerateKeyLossKey_A8169_UIValue
		{
			get
			{
				short num = (short)1001627534;
				short num2 = num;
				num = (short)1806016398;
				switch (num2 == num)
				{
				}
				num = (short)832569344;
				short num3 = num;
				num = (short)1379401729;
				if (num != 0)
				{
				}
				num = (short)863436800;
				if (num != 0)
				{
				}
				return this.secWideGeneralOTARGenerateKeyLossKey_A8169.Value;
			}
			set
			{
				short num = (short)942875182;
				short num2 = num;
				num = (short)1463165486;
				switch (num2 == num)
				{
				}
				num = (short)983171072;
				short num3 = num;
				num = (short)1465778177;
				if (num != 0)
				{
				}
				num = (short)1838743552;
				if (num != 0)
				{
				}
				this.secWideGeneralOTARGenerateKeyLossKey_A8169.Value = value;
			}
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x002058DC File Offset: 0x00203ADC
		// (set) Token: 0x060020A9 RID: 8361 RVA: 0x0020598C File Offset: 0x00203B8C
		public bool SecWideGeneralOTARGenerateKeyLossKey_A8169_Applicable
		{
			get
			{
				short num = (short)1102694707;
				short num2 = num;
				num = (short)1532086579;
				switch (num2 == num)
				{
				}
				num = (short)799408128;
				short num3 = num;
				num = (short)298123265;
				if (num != 0)
				{
				}
				num = (short)1538129920;
				if (num != 0)
				{
				}
				return this.secWideGeneralOTARGenerateKeyLossKey_A8169.Applicable;
			}
			set
			{
				short num = (short)1109984036;
				short num2 = num;
				num = (short)1467155236;
				switch (num2 == num)
				{
				}
				num = (short)251658240;
				short num3 = num;
				num = (short)754647041;
				if (num != 0)
				{
				}
				num = (short)184680448;
				if (num != 0)
				{
				}
				this.secWideGeneralOTARGenerateKeyLossKey_A8169.Applicable = value;
			}
		}

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x060020AA RID: 8362 RVA: 0x00205A44 File Offset: 0x00203C44
		// (set) Token: 0x060020AB RID: 8363 RVA: 0x00205AF8 File Offset: 0x00203CF8
		public bool SecWideGeneralOTARGenerateKeyLossKey_A8169_Valid
		{
			get
			{
				short num = (short)1282187101;
				short num2 = num;
				num = (short)723230557;
				switch (num2 == num)
				{
				}
				num = (short)1587806208;
				short num3 = num;
				num = (short)562233344;
				if (num != 0)
				{
				}
				num = (short)1632305153;
				if (num != 0)
				{
				}
				return this.secWideGeneralOTARGenerateKeyLossKey_A8169.Valid;
			}
			set
			{
				short num = (short)627109188;
				short num2 = num;
				num = (short)2078076228;
				switch (num2 == num)
				{
				}
				num = (short)1203961856;
				short num3 = num;
				num = (short)105316352;
				if (num != 0)
				{
				}
				num = (short)1626537985;
				if (num != 0)
				{
				}
				this.secWideGeneralOTARGenerateKeyLossKey_A8169.Valid = value;
			}
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x060020AC RID: 8364 RVA: 0x00205BAC File Offset: 0x00203DAC
		// (set) Token: 0x060020AD RID: 8365 RVA: 0x00205C64 File Offset: 0x00203E64
		public bool SecWideGeneralOTARGenerateKeyLossKey_A8169_Visible
		{
			get
			{
				short num = (short)41310931;
				short num2 = num;
				num = (short)902060755;
				switch (num2 == num)
				{
				}
				num = (short)659750912;
				short num3 = num;
				num = (short)562561025;
				if (num != 0)
				{
				}
				num = (short)800849920;
				if (num != 0)
				{
				}
				return this.secWideGeneralOTARGenerateKeyLossKey_A8169.Visible;
			}
			set
			{
				short num = (short)1881837562;
				short num2 = num;
				num = (short)706187258;
				switch (num2 == num)
				{
				}
				num = (short)1367670784;
				short num3 = num;
				num = (short)1000144897;
				if (num != 0)
				{
				}
				num = (short)1546190848;
				if (num != 0)
				{
				}
				this.secWideGeneralOTARGenerateKeyLossKey_A8169.Visible = value;
			}
		}

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x060020AE RID: 8366 RVA: 0x00205D18 File Offset: 0x00203F18
		// (set) Token: 0x060020AF RID: 8367 RVA: 0x00205DCC File Offset: 0x00203FCC
		public bool SecWideGeneralOTARGenerateKeyLossKey_A8169_Editable
		{
			get
			{
				short num = (short)1634145329;
				short num2 = num;
				num = (short)1608520753;
				switch (num2 == num)
				{
				}
				num = (short)1787166720;
				short num3 = num;
				num = (short)1270087681;
				if (num != 0)
				{
				}
				num = (short)1458765824;
				if (num != 0)
				{
				}
				return this.secWideGeneralOTARGenerateKeyLossKey_A8169.Editable;
			}
			set
			{
				short num = (short)1545424682;
				short num2 = num;
				num = (short)1000361770;
				switch (num2 == num)
				{
				}
				num = (short)565575680;
				short num3 = num;
				num = (short)848953345;
				if (num != 0)
				{
				}
				num = (short)407306240;
				if (num != 0)
				{
				}
				this.secWideGeneralOTARGenerateKeyLossKey_A8169.Editable = value;
			}
		}

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x060020B0 RID: 8368 RVA: 0x00205E80 File Offset: 0x00204080
		internal string SecWideGeneralOTARGenerateKeyLossKey_A8169_UILabel
		{
			get
			{
				short num = (short)1508285599;
				short num2 = num;
				num = (short)1682021535;
				switch (num2 == num)
				{
				}
				num = (short)1458765824;
				short num3 = num;
				num = (short)1807155201;
				if (num != 0)
				{
				}
				num = (short)1684209664;
				if (num != 0)
				{
				}
				return this.secWideGeneralOTARGenerateKeyLossKey_A8169.UIName;
			}
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x060020B1 RID: 8369 RVA: 0x00205F34 File Offset: 0x00204134
		// (set) Token: 0x060020B2 RID: 8370 RVA: 0x00205FE8 File Offset: 0x002041E8
		internal bool SecWideGeneralOTARGenerateKeyLossKey_A8169_HiddenStatic
		{
			get
			{
				short num = (short)1877409793;
				if (num != 0)
				{
				}
				num = (short)1411136060;
				short num2 = num;
				num = (short)1888107068;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2129526784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)158138368;
				if (num != 0)
				{
				}
				return this.secWideGeneralOTARGenerateKeyLossKey_A8169.HiddenStatic;
			}
			set
			{
				short num = (short)446642679;
				short num2 = num;
				num = (short)1608071671;
				switch (num2 == num)
				{
				}
				num = (short)1386676224;
				short num3 = num;
				num = (short)1112408065;
				if (num != 0)
				{
				}
				num = (short)1085734912;
				if (num != 0)
				{
				}
				this.secWideGeneralOTARGenerateKeyLossKey_A8169.HiddenStatic = value;
			}
		}

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x060020B3 RID: 8371 RVA: 0x0020609C File Offset: 0x0020429C
		// (set) Token: 0x060020B4 RID: 8372 RVA: 0x00206154 File Offset: 0x00204354
		internal bool SecWideGeneralOTARGenerateKeyLossKey_A8169_HiddenDynamic
		{
			get
			{
				short num = (short)1118148673;
				short num2 = num;
				num = (short)637573185;
				switch (num2 == num)
				{
				}
				num = (short)1206321152;
				short num3 = num;
				num = (short)697434113;
				if (num != 0)
				{
				}
				num = (short)1134755840;
				if (num != 0)
				{
				}
				return this.secWideGeneralOTARGenerateKeyLossKey_A8169.HiddenDynamic;
			}
			set
			{
				short num = (short)1931975566;
				short num2 = num;
				num = (short)660315022;
				switch (num2 == num)
				{
				}
				num = (short)1685913600;
				short num3 = num;
				num = (short)2118516736;
				if (num != 0)
				{
				}
				num = (short)1856765953;
				if (num != 0)
				{
				}
				this.secWideGeneralOTARGenerateKeyLossKey_A8169.HiddenDynamic = value;
			}
		}

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x00206208 File Offset: 0x00204408
		public bool SecWideGeneralOTARGenerateKeyLossKey_A8169_HasDiffs
		{
			get
			{
				short num = (short)1201917816;
				short num2 = num;
				num = (short)1741737848;
				switch (num2 == num)
				{
				}
				num = (short)1741815808;
				short num3 = num;
				num = (short)2011168769;
				if (num != 0)
				{
				}
				num = (short)1680474112;
				if (num != 0)
				{
				}
				return this.secWideGeneralOTARGenerateKeyLossKey_A8169._HasDiffs;
			}
		}

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x060020B6 RID: 8374 RVA: 0x002062BC File Offset: 0x002044BC
		// (set) Token: 0x060020B7 RID: 8375 RVA: 0x00206374 File Offset: 0x00204574
		public int SecWideGeneralSecureOperation_A9067Value
		{
			get
			{
				short num = (short)419560740;
				short num2 = num;
				num = (short)390528292;
				switch (num2 == num)
				{
				}
				num = (short)504758272;
				short num3 = num;
				num = (short)695009280;
				if (num != 0)
				{
				}
				num = (short)1472790529;
				if (num != 0)
				{
				}
				return this.secWideGeneralSecureOperation_A9067.Value;
			}
			set
			{
				short num = (short)279786109;
				short num2 = num;
				num = (short)527905405;
				switch (num2 == num)
				{
				}
				num = (short)1470824448;
				short num3 = num;
				num = (short)1670053889;
				if (num != 0)
				{
				}
				num = (short)970784768;
				if (num != 0)
				{
				}
				this.secWideGeneralSecureOperation_A9067.Value = value;
			}
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x060020B8 RID: 8376 RVA: 0x00206428 File Offset: 0x00204628
		// (set) Token: 0x060020B9 RID: 8377 RVA: 0x002064DC File Offset: 0x002046DC
		public string SecWideGeneralSecureOperation_A9067_UIValue
		{
			get
			{
				short num = (short)387383297;
				if (num != 0)
				{
				}
				num = (short)1442222985;
				short num2 = num;
				num = (short)1724486537;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1545142272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2042953728;
				if (num != 0)
				{
				}
				return this.secWideGeneralSecureOperation_A9067.UIValue;
			}
			set
			{
				short num = (short)1719536944;
				short num2 = num;
				num = (short)38014256;
				switch (num2 == num)
				{
				}
				num = (short)893583360;
				short num3 = num;
				num = (short)535953408;
				if (num != 0)
				{
				}
				num = (short)1635450881;
				if (num != 0)
				{
				}
				this.secWideGeneralSecureOperation_A9067.UIValue = value;
			}
		}

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x060020BA RID: 8378 RVA: 0x00206594 File Offset: 0x00204794
		public global::AcpBusinessLayer.AcpListField SecWideGeneralSecureOperation_A9067
		{
			get
			{
				short num = (short)1986643347;
				short num2 = num;
				num = (short)1243071891;
				switch (num2 == num)
				{
				}
				num = (short)914489344;
				short num3 = num;
				num = (short)1517944832;
				if (num != 0)
				{
				}
				num = (short)778764289;
				if (num != 0)
				{
				}
				return this.secWideGeneralSecureOperation_A9067;
			}
		}

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x060020BB RID: 8379 RVA: 0x00206644 File Offset: 0x00204844
		// (set) Token: 0x060020BC RID: 8380 RVA: 0x002066FC File Offset: 0x002048FC
		public bool SecWideGeneralSecureOperation_A9067_Applicable
		{
			get
			{
				short num = (short)1644907350;
				short num2 = num;
				num = (short)1677937494;
				switch (num2 == num)
				{
				}
				num = (short)501874688;
				short num3 = num;
				num = (short)193593345;
				if (num != 0)
				{
				}
				num = (short)752680960;
				if (num != 0)
				{
				}
				return this.secWideGeneralSecureOperation_A9067.Applicable;
			}
			set
			{
				short num = (short)1710648895;
				short num2 = num;
				num = (short)1534946879;
				switch (num2 == num)
				{
				}
				num = (short)910426112;
				short num3 = num;
				num = (short)360710145;
				if (num != 0)
				{
				}
				num = (short)2009595904;
				if (num != 0)
				{
				}
				this.secWideGeneralSecureOperation_A9067.Applicable = value;
			}
		}

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x060020BD RID: 8381 RVA: 0x002067B4 File Offset: 0x002049B4
		// (set) Token: 0x060020BE RID: 8382 RVA: 0x00206868 File Offset: 0x00204A68
		public bool SecWideGeneralSecureOperation_A9067_Valid
		{
			get
			{
				short num = (short)92044792;
				short num2 = num;
				num = (short)1173126648;
				switch (num2 == num)
				{
				}
				num = (short)1843789824;
				short num3 = num;
				num = (short)349634561;
				if (num != 0)
				{
				}
				num = (short)849412096;
				if (num != 0)
				{
				}
				return this.secWideGeneralSecureOperation_A9067.Valid;
			}
			set
			{
				short num = (short)1170865119;
				short num2 = num;
				num = (short)1327889375;
				switch (num2 == num)
				{
				}
				num = (short)296550400;
				short num3 = num;
				num = (short)1063649281;
				if (num != 0)
				{
				}
				num = (short)689045504;
				if (num != 0)
				{
				}
				this.secWideGeneralSecureOperation_A9067.Valid = value;
			}
		}

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x060020BF RID: 8383 RVA: 0x0020691C File Offset: 0x00204B1C
		// (set) Token: 0x060020C0 RID: 8384 RVA: 0x002069D0 File Offset: 0x00204BD0
		public bool SecWideGeneralSecureOperation_A9067_Visible
		{
			get
			{
				short num = (short)848663843;
				short num2 = num;
				num = (short)1205441827;
				switch (num2 == num)
				{
				}
				num = (short)2034630656;
				if (num != 0)
				{
				}
				num = (short)2007433217;
				if (num != 0)
				{
				}
				num = (short)919273472;
				short num3 = num;
				return this.secWideGeneralSecureOperation_A9067.Visible;
			}
			set
			{
				short num = (short)584895005;
				short num2 = num;
				num = (short)1159383581;
				switch (num2 == num)
				{
				}
				num = (short)1464401920;
				if (num != 0)
				{
				}
				num = (short)1087766529;
				if (num != 0)
				{
				}
				num = (short)1074069504;
				short num3 = num;
				this.secWideGeneralSecureOperation_A9067.Visible = value;
			}
		}

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x060020C1 RID: 8385 RVA: 0x00206A84 File Offset: 0x00204C84
		// (set) Token: 0x060020C2 RID: 8386 RVA: 0x00206B3C File Offset: 0x00204D3C
		public bool SecWideGeneralSecureOperation_A9067_Editable
		{
			get
			{
				short num = (short)2066212578;
				short num2 = num;
				num = (short)1734665954;
				switch (num2 == num)
				{
				}
				num = (short)22872064;
				if (num != 0)
				{
				}
				num = (short)404291585;
				if (num != 0)
				{
				}
				num = (short)1542914048;
				short num3 = num;
				return this.secWideGeneralSecureOperation_A9067.Editable;
			}
			set
			{
				short num = (short)673248232;
				short num2 = num;
				num = (short)304935912;
				switch (num2 == num)
				{
				}
				num = (short)1870135296;
				if (num != 0)
				{
				}
				num = (short)1874132993;
				if (num != 0)
				{
				}
				num = (short)489029632;
				short num3 = num;
				this.secWideGeneralSecureOperation_A9067.Editable = value;
			}
		}

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x060020C3 RID: 8387 RVA: 0x00206BF4 File Offset: 0x00204DF4
		internal string SecWideGeneralSecureOperation_A9067_UILabel
		{
			get
			{
				short num = (short)196628719;
				short num2 = num;
				num = (short)143151343;
				switch (num2 == num)
				{
				}
				num = (short)2090336257;
				if (num != 0)
				{
				}
				num = (short)261423104;
				if (num != 0)
				{
				}
				num = (short)895287296;
				short num3 = num;
				return this.secWideGeneralSecureOperation_A9067.UIName;
			}
		}

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x060020C4 RID: 8388 RVA: 0x00206CA8 File Offset: 0x00204EA8
		// (set) Token: 0x060020C5 RID: 8389 RVA: 0x00206D60 File Offset: 0x00204F60
		internal bool SecWideGeneralSecureOperation_A9067_HiddenStatic
		{
			get
			{
				short num = (short)1475942587;
				short num2 = num;
				num = (short)1310791867;
				switch (num2 == num)
				{
				}
				num = (short)911933440;
				if (num != 0)
				{
				}
				num = (short)1170407425;
				if (num != 0)
				{
				}
				num = (short)1098776576;
				short num3 = num;
				return this.secWideGeneralSecureOperation_A9067.HiddenStatic;
			}
			set
			{
				short num = (short)1179748416;
				short num2 = num;
				num = (short)1438091328;
				switch (num2 == num)
				{
				}
				num = (short)538836993;
				if (num != 0)
				{
				}
				num = (short)2044461056;
				if (num != 0)
				{
				}
				num = (short)201457664;
				short num3 = num;
				this.secWideGeneralSecureOperation_A9067.HiddenStatic = value;
			}
		}

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x060020C6 RID: 8390 RVA: 0x00206E18 File Offset: 0x00205018
		// (set) Token: 0x060020C7 RID: 8391 RVA: 0x00206ECC File Offset: 0x002050CC
		internal bool SecWideGeneralSecureOperation_A9067_HiddenDynamic
		{
			get
			{
				short num = (short)311740735;
				short num2 = num;
				num = (short)683854143;
				switch (num2 == num)
				{
				}
				num = (short)184418305;
				if (num != 0)
				{
				}
				num = (short)1953562624;
				if (num != 0)
				{
				}
				num = (short)1644429312;
				short num3 = num;
				return this.secWideGeneralSecureOperation_A9067.HiddenDynamic;
			}
			set
			{
				short num = (short)320789115;
				short num2 = num;
				num = (short)838392443;
				switch (num2 == num)
				{
				}
				num = (short)1110966272;
				if (num != 0)
				{
				}
				num = (short)1021902849;
				if (num != 0)
				{
				}
				num = (short)1269956608;
				short num3 = num;
				this.secWideGeneralSecureOperation_A9067.HiddenDynamic = value;
			}
		}

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x060020C8 RID: 8392 RVA: 0x00206F80 File Offset: 0x00205180
		public bool SecWideGeneralSecureOperation_A9067_HasDiffs
		{
			get
			{
				short num = (short)1205683319;
				short num2 = num;
				num = (short)2031109239;
				switch (num2 == num)
				{
				}
				num = (short)975241216;
				if (num != 0)
				{
				}
				num = (short)680919041;
				if (num != 0)
				{
				}
				num = (short)1572929536;
				short num3 = num;
				return this.secWideGeneralSecureOperation_A9067._HasDiffs;
			}
		}

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x060020C9 RID: 8393 RVA: 0x00207038 File Offset: 0x00205238
		// (set) Token: 0x060020CA RID: 8394 RVA: 0x002070EC File Offset: 0x002052EC
		public int SecWideGeneralOTAROperation_43700Value
		{
			get
			{
				short num = (short)2023888644;
				short num2 = num;
				num = (short)63117060;
				switch (num2 == num)
				{
				}
				num = (short)1806499841;
				if (num != 0)
				{
				}
				num = (short)1574371328;
				if (num != 0)
				{
				}
				num = (short)1245511680;
				short num3 = num;
				return this.secWideGeneralOTAROperation_43700.Value;
			}
			set
			{
				short num = (short)950730753;
				if (num != 0)
				{
				}
				num = (short)169315160;
				short num2 = num;
				num = (short)1950583640;
				switch (num2 == num)
				{
				}
				num = (short)269877248;
				if (num != 0)
				{
				}
				num = (short)164757504;
				short num3 = num;
				this.secWideGeneralOTAROperation_43700.Value = value;
			}
		}

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x060020CB RID: 8395 RVA: 0x002071A0 File Offset: 0x002053A0
		// (set) Token: 0x060020CC RID: 8396 RVA: 0x00207254 File Offset: 0x00205454
		public string SecWideGeneralOTAROperation_43700_UIValue
		{
			get
			{
				short num = (short)1518731265;
				if (num != 0)
				{
				}
				num = (short)472831689;
				short num2 = num;
				num = (short)204396233;
				switch (num2 == num)
				{
				}
				num = (short)168820736;
				if (num != 0)
				{
				}
				num = (short)1793261568;
				short num3 = num;
				return this.secWideGeneralOTAROperation_43700.UIValue;
			}
			set
			{
				short num = (short)2132591456;
				short num2 = num;
				num = (short)808239968;
				switch (num2 == num)
				{
				}
				num = (short)1433403392;
				if (num != 0)
				{
				}
				num = (short)136642561;
				if (num != 0)
				{
				}
				num = (short)1071841280;
				short num3 = num;
				this.secWideGeneralOTAROperation_43700.UIValue = value;
			}
		}

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x060020CD RID: 8397 RVA: 0x00207308 File Offset: 0x00205508
		public global::AcpBusinessLayer.AcpListField SecWideGeneralOTAROperation_43700
		{
			get
			{
				short num = (short)918825371;
				short num2 = num;
				num = (short)729491867;
				switch (num2 == num)
				{
				}
				num = (short)652541952;
				if (num != 0)
				{
				}
				num = (short)1502543873;
				if (num != 0)
				{
				}
				num = (short)1480458240;
				short num3 = num;
				return this.secWideGeneralOTAROperation_43700;
			}
		}

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x060020CE RID: 8398 RVA: 0x002073B8 File Offset: 0x002055B8
		// (set) Token: 0x060020CF RID: 8399 RVA: 0x0020746C File Offset: 0x0020566C
		public bool SecWideGeneralOTAROperation_43700_Applicable
		{
			get
			{
				short num = (short)974909794;
				short num2 = num;
				num = (short)2126115170;
				switch (num2 == num)
				{
				}
				num = (short)1807810561;
				if (num != 0)
				{
				}
				num = (short)1711996928;
				if (num != 0)
				{
				}
				num = (short)138084352;
				short num3 = num;
				return this.secWideGeneralOTAROperation_43700.Applicable;
			}
			set
			{
				short num = (short)792587193;
				short num2 = num;
				num = (short)1730800569;
				switch (num2 == num)
				{
				}
				num = (short)854523904;
				if (num != 0)
				{
				}
				num = (short)1384841217;
				if (num != 0)
				{
				}
				num = (short)1214054400;
				short num3 = num;
				this.secWideGeneralOTAROperation_43700.Applicable = value;
			}
		}

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x060020D0 RID: 8400 RVA: 0x00207520 File Offset: 0x00205720
		// (set) Token: 0x060020D1 RID: 8401 RVA: 0x002075D8 File Offset: 0x002057D8
		public bool SecWideGeneralOTAROperation_43700_Valid
		{
			get
			{
				short num = (short)1008664577;
				if (num != 0)
				{
				}
				num = (short)1450932951;
				short num2 = num;
				num = (short)306150103;
				switch (num2 == num)
				{
				}
				num = (short)1305346048;
				if (num != 0)
				{
				}
				num = (short)1001062400;
				short num3 = num;
				return this.secWideGeneralOTAROperation_43700.Valid;
			}
			set
			{
				short num = (short)459932428;
				short num2 = num;
				num = (short)1695154956;
				switch (num2 == num)
				{
				}
				num = (short)1895563265;
				if (num != 0)
				{
				}
				num = (short)860225536;
				if (num != 0)
				{
				}
				num = (short)1033240576;
				short num3 = num;
				this.secWideGeneralOTAROperation_43700.Valid = value;
			}
		}

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x060020D2 RID: 8402 RVA: 0x0020768C File Offset: 0x0020588C
		// (set) Token: 0x060020D3 RID: 8403 RVA: 0x00207744 File Offset: 0x00205944
		public bool SecWideGeneralOTAROperation_43700_Visible
		{
			get
			{
				short num = (short)1298202625;
				if (num != 0)
				{
				}
				num = (short)1048988979;
				short num2 = num;
				num = (short)164842803;
				switch (num2 == num)
				{
				}
				num = (short)1105526784;
				if (num != 0)
				{
				}
				num = (short)880148480;
				short num3 = num;
				return this.secWideGeneralOTAROperation_43700.Visible;
			}
			set
			{
				short num = (short)1138391339;
				short num2 = num;
				num = (short)149584171;
				switch (num2 == num)
				{
				}
				num = (short)721551361;
				if (num != 0)
				{
				}
				num = (short)1798111232;
				if (num != 0)
				{
				}
				num = (short)2140733440;
				short num3 = num;
				this.secWideGeneralOTAROperation_43700.Visible = value;
			}
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x060020D4 RID: 8404 RVA: 0x002077F8 File Offset: 0x002059F8
		// (set) Token: 0x060020D5 RID: 8405 RVA: 0x002078AC File Offset: 0x00205AAC
		public bool SecWideGeneralOTAROperation_43700_Editable
		{
			get
			{
				short num = (short)783798069;
				short num2 = num;
				num = (short)1542180661;
				switch (num2 == num)
				{
				}
				num = (short)65601537;
				if (num != 0)
				{
				}
				num = (short)337248256;
				if (num != 0)
				{
				}
				num = (short)60751872;
				short num3 = num;
				return this.secWideGeneralOTAROperation_43700.Editable;
			}
			set
			{
				short num = (short)747256479;
				short num2 = num;
				num = (short)1441872543;
				switch (num2 == num)
				{
				}
				num = (short)221904897;
				if (num != 0)
				{
				}
				num = (short)1029701632;
				if (num != 0)
				{
				}
				num = (short)1509949440;
				short num3 = num;
				this.secWideGeneralOTAROperation_43700.Editable = value;
			}
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x060020D6 RID: 8406 RVA: 0x00207960 File Offset: 0x00205B60
		internal string SecWideGeneralOTAROperation_43700_UILabel
		{
			get
			{
				short num = (short)1386528097;
				short num2 = num;
				num = (short)166378849;
				switch (num2 == num)
				{
				}
				num = (short)112721921;
				if (num != 0)
				{
				}
				num = (short)1707933696;
				if (num != 0)
				{
				}
				num = (short)197001216;
				short num3 = num;
				return this.secWideGeneralOTAROperation_43700.UIName;
			}
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x060020D7 RID: 8407 RVA: 0x00207A14 File Offset: 0x00205C14
		// (set) Token: 0x060020D8 RID: 8408 RVA: 0x00207AC8 File Offset: 0x00205CC8
		internal bool SecWideGeneralOTAROperation_43700_HiddenStatic
		{
			get
			{
				short num = (short)1536966742;
				short num2 = num;
				num = (short)409157718;
				switch (num2 == num)
				{
				}
				num = (short)834600961;
				if (num != 0)
				{
				}
				num = (short)1696268288;
				if (num != 0)
				{
				}
				num = (short)2138832896;
				short num3 = num;
				return this.secWideGeneralOTAROperation_43700.HiddenStatic;
			}
			set
			{
				short num = (short)2142365540;
				short num2 = num;
				num = (short)1535174500;
				switch (num2 == num)
				{
				}
				num = (short)812580865;
				if (num != 0)
				{
				}
				num = (short)561250304;
				if (num != 0)
				{
				}
				num = (short)1887109120;
				short num3 = num;
				this.secWideGeneralOTAROperation_43700.HiddenStatic = value;
			}
		}

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x060020D9 RID: 8409 RVA: 0x00207B7C File Offset: 0x00205D7C
		// (set) Token: 0x060020DA RID: 8410 RVA: 0x00207C30 File Offset: 0x00205E30
		internal bool SecWideGeneralOTAROperation_43700_HiddenDynamic
		{
			get
			{
				short num = (short)1429709809;
				short num2 = num;
				num = (short)795780081;
				switch (num2 == num)
				{
				}
				num = (short)1875902465;
				if (num != 0)
				{
				}
				num = (short)349700096;
				if (num != 0)
				{
				}
				num = (short)848363520;
				short num3 = num;
				return this.secWideGeneralOTAROperation_43700.HiddenDynamic;
			}
			set
			{
				short num = (short)923114186;
				short num2 = num;
				num = (short)479632074;
				switch (num2 == num)
				{
				}
				num = (short)1733689344;
				if (num != 0)
				{
				}
				num = (short)2621441;
				if (num != 0)
				{
				}
				num = (short)1098383360;
				short num3 = num;
				this.secWideGeneralOTAROperation_43700.HiddenDynamic = value;
			}
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x060020DB RID: 8411 RVA: 0x00207CE8 File Offset: 0x00205EE8
		public bool SecWideGeneralOTAROperation_43700_HasDiffs
		{
			get
			{
				short num = (short)1863852648;
				short num2 = num;
				num = (short)730538600;
				switch (num2 == num)
				{
				}
				num = (short)1569914880;
				if (num != 0)
				{
				}
				num = (short)1103560705;
				if (num != 0)
				{
				}
				num = (short)477102080;
				short num3 = num;
				return this.secWideGeneralOTAROperation_43700._HasDiffs;
			}
		}

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x060020DC RID: 8412 RVA: 0x00207D9C File Offset: 0x00205F9C
		// (set) Token: 0x060020DD RID: 8413 RVA: 0x00207E54 File Offset: 0x00206054
		public bool SecWideGeneralEnhancedADPRadioInhibit_A41461Value
		{
			get
			{
				short num = (short)734044284;
				short num2 = num;
				num = (short)1986371708;
				switch (num2 == num)
				{
				}
				num = (short)1259864065;
				if (num != 0)
				{
				}
				num = (short)1438449664;
				if (num != 0)
				{
				}
				num = (short)413990912;
				short num3 = num;
				return this.secWideGeneralEnhancedADPRadioInhibit_A41461.Value;
			}
			set
			{
				short num = (short)1328174136;
				short num2 = num;
				num = (short)921785400;
				switch (num2 == num)
				{
				}
				num = (short)275775489;
				if (num != 0)
				{
				}
				num = (short)1907490816;
				if (num != 0)
				{
				}
				num = (short)527826944;
				short num3 = num;
				this.secWideGeneralEnhancedADPRadioInhibit_A41461.Value = value;
			}
		}

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x060020DE RID: 8414 RVA: 0x00207F0C File Offset: 0x0020610C
		public global::AcpBusinessLayer.AcpField<bool> SecWideGeneralEnhancedADPRadioInhibit_A41461
		{
			get
			{
				short num = (short)439399406;
				short num2 = num;
				num = (short)219263982;
				switch (num2 == num)
				{
				}
				num = (short)1573519361;
				if (num != 0)
				{
				}
				num = (short)302514176;
				if (num != 0)
				{
				}
				num = (short)1326120960;
				short num3 = num;
				return this.secWideGeneralEnhancedADPRadioInhibit_A41461;
			}
		}

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x060020DF RID: 8415 RVA: 0x00207FBC File Offset: 0x002061BC
		// (set) Token: 0x060020E0 RID: 8416 RVA: 0x00208070 File Offset: 0x00206270
		public bool SecWideGeneralEnhancedADPRadioInhibit_A41461_UIValue
		{
			get
			{
				short num = (short)1830308667;
				short num2 = num;
				num = (short)12077883;
				switch (num2 == num)
				{
				}
				num = (short)1618083841;
				if (num != 0)
				{
				}
				num = (short)1888813056;
				if (num != 0)
				{
				}
				num = (short)2110980096;
				short num3 = num;
				return this.secWideGeneralEnhancedADPRadioInhibit_A41461.Value;
			}
			set
			{
				short num = (short)1816921924;
				short num2 = num;
				num = (short)1884686148;
				switch (num2 == num)
				{
				}
				num = (short)2137325568;
				if (num != 0)
				{
				}
				num = (short)693043201;
				if (num != 0)
				{
				}
				num = (short)1124794368;
				short num3 = num;
				this.secWideGeneralEnhancedADPRadioInhibit_A41461.Value = value;
			}
		}

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x060020E1 RID: 8417 RVA: 0x00208128 File Offset: 0x00206328
		// (set) Token: 0x060020E2 RID: 8418 RVA: 0x002081DC File Offset: 0x002063DC
		public bool SecWideGeneralEnhancedADPRadioInhibit_A41461_Applicable
		{
			get
			{
				short num = (short)933235257;
				short num2 = num;
				num = (short)1017186873;
				switch (num2 == num)
				{
				}
				num = (short)1764818944;
				if (num != 0)
				{
				}
				num = (short)1896415233;
				if (num != 0)
				{
				}
				num = (short)1789001728;
				short num3 = num;
				return this.secWideGeneralEnhancedADPRadioInhibit_A41461.Applicable;
			}
			set
			{
				short num = (short)232661798;
				short num2 = num;
				num = (short)822944550;
				switch (num2 == num)
				{
				}
				num = (short)261554176;
				if (num != 0)
				{
				}
				num = (short)1510277121;
				if (num != 0)
				{
				}
				num = (short)1439301632;
				short num3 = num;
				this.secWideGeneralEnhancedADPRadioInhibit_A41461.Applicable = value;
			}
		}

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x060020E3 RID: 8419 RVA: 0x00208294 File Offset: 0x00206494
		// (set) Token: 0x060020E4 RID: 8420 RVA: 0x00208348 File Offset: 0x00206548
		public bool SecWideGeneralEnhancedADPRadioInhibit_A41461_Valid
		{
			get
			{
				short num = (short)644576240;
				short num2 = num;
				num = (short)1281324016;
				switch (num2 == num)
				{
				}
				num = (short)1875247105;
				if (num != 0)
				{
				}
				num = (short)902365184;
				if (num != 0)
				{
				}
				num = (short)1201668096;
				short num3 = num;
				return this.secWideGeneralEnhancedADPRadioInhibit_A41461.Valid;
			}
			set
			{
				short num = (short)979737618;
				short num2 = num;
				num = (short)949066770;
				switch (num2 == num)
				{
				}
				num = (short)834011137;
				if (num != 0)
				{
				}
				num = (short)1024000000;
				if (num != 0)
				{
				}
				num = (short)649854976;
				short num3 = num;
				this.secWideGeneralEnhancedADPRadioInhibit_A41461.Valid = value;
			}
		}

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x060020E5 RID: 8421 RVA: 0x002083FC File Offset: 0x002065FC
		// (set) Token: 0x060020E6 RID: 8422 RVA: 0x002084B4 File Offset: 0x002066B4
		public bool SecWideGeneralEnhancedADPRadioInhibit_A41461_Visible
		{
			get
			{
				short num = (short)1041875778;
				short num2 = num;
				num = (short)2043593538;
				switch (num2 == num)
				{
				}
				num = (short)1364721664;
				if (num != 0)
				{
				}
				num = (short)762314753;
				if (num != 0)
				{
				}
				num = (short)1860567040;
				short num3 = num;
				return this.secWideGeneralEnhancedADPRadioInhibit_A41461.Visible;
			}
			set
			{
				short num = (short)753153646;
				short num2 = num;
				num = (short)1215575662;
				switch (num2 == num)
				{
				}
				num = (short)129892353;
				if (num != 0)
				{
				}
				num = (short)158990336;
				if (num != 0)
				{
				}
				num = (short)855834624;
				short num3 = num;
				this.secWideGeneralEnhancedADPRadioInhibit_A41461.Visible = value;
			}
		}

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x060020E7 RID: 8423 RVA: 0x00208568 File Offset: 0x00206768
		// (set) Token: 0x060020E8 RID: 8424 RVA: 0x0020861C File Offset: 0x0020681C
		public bool SecWideGeneralEnhancedADPRadioInhibit_A41461_Editable
		{
			get
			{
				short num = (short)1286935646;
				short num2 = num;
				num = (short)1909527646;
				switch (num2 == num)
				{
				}
				num = (short)199688193;
				if (num != 0)
				{
				}
				num = (short)262995968;
				if (num != 0)
				{
				}
				num = (short)793968640;
				short num3 = num;
				return this.secWideGeneralEnhancedADPRadioInhibit_A41461.Editable;
			}
			set
			{
				short num = (short)856912125;
				short num2 = num;
				num = (short)682979581;
				switch (num2 == num)
				{
				}
				num = (short)288751617;
				if (num != 0)
				{
				}
				num = (short)1708589056;
				if (num != 0)
				{
				}
				num = (short)275775488;
				short num3 = num;
				this.secWideGeneralEnhancedADPRadioInhibit_A41461.Editable = value;
			}
		}

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x060020E9 RID: 8425 RVA: 0x002086D0 File Offset: 0x002068D0
		internal string SecWideGeneralEnhancedADPRadioInhibit_A41461_UILabel
		{
			get
			{
				short num = (short)1681743739;
				short num2 = num;
				num = (short)2078039931;
				switch (num2 == num)
				{
				}
				num = (short)1374486529;
				if (num != 0)
				{
				}
				num = (short)1125122048;
				if (num != 0)
				{
				}
				num = (short)1458896896;
				short num3 = num;
				return this.secWideGeneralEnhancedADPRadioInhibit_A41461.UIName;
			}
		}

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x060020EA RID: 8426 RVA: 0x00208788 File Offset: 0x00206988
		// (set) Token: 0x060020EB RID: 8427 RVA: 0x00208840 File Offset: 0x00206A40
		internal bool SecWideGeneralEnhancedADPRadioInhibit_A41461_HiddenStatic
		{
			get
			{
				short num = (short)1924551626;
				short num2 = num;
				num = (short)537416650;
				switch (num2 == num)
				{
				}
				num = (short)1694826497;
				if (num != 0)
				{
				}
				num = (short)603717632;
				if (num != 0)
				{
				}
				num = (short)711196672;
				short num3 = num;
				return this.secWideGeneralEnhancedADPRadioInhibit_A41461.HiddenStatic;
			}
			set
			{
				short num = (short)1465549962;
				short num2 = num;
				num = (short)1927971978;
				switch (num2 == num)
				{
				}
				num = (short)1468465153;
				if (num != 0)
				{
				}
				num = (short)1729495040;
				if (num != 0)
				{
				}
				num = (short)518520832;
				short num3 = num;
				this.secWideGeneralEnhancedADPRadioInhibit_A41461.HiddenStatic = value;
			}
		}

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x060020EC RID: 8428 RVA: 0x002088F8 File Offset: 0x00206AF8
		// (set) Token: 0x060020ED RID: 8429 RVA: 0x002089B0 File Offset: 0x00206BB0
		internal bool SecWideGeneralEnhancedADPRadioInhibit_A41461_HiddenDynamic
		{
			get
			{
				short num = (short)1942242336;
				short num2 = num;
				num = (short)581256224;
				switch (num2 == num)
				{
				}
				num = (short)1330511873;
				if (num != 0)
				{
				}
				num = (short)208797696;
				if (num != 0)
				{
				}
				num = (short)547684352;
				short num3 = num;
				return this.secWideGeneralEnhancedADPRadioInhibit_A41461.HiddenDynamic;
			}
			set
			{
				short num = (short)185280091;
				short num2 = num;
				num = (short)1799300699;
				switch (num2 == num)
				{
				}
				num = (short)49283073;
				if (num != 0)
				{
				}
				num = (short)1311440896;
				if (num != 0)
				{
				}
				num = (short)55836672;
				short num3 = num;
				this.secWideGeneralEnhancedADPRadioInhibit_A41461.HiddenDynamic = value;
			}
		}

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x060020EE RID: 8430 RVA: 0x00208A64 File Offset: 0x00206C64
		public bool SecWideGeneralEnhancedADPRadioInhibit_A41461_HasDiffs
		{
			get
			{
				short num = (short)676921344;
				short num2 = num;
				num = (short)19230492;
				short num3 = num;
				num = (short)1881239324;
				switch (num3 == num)
				{
				}
				num = (short)69992448;
				if (num != 0)
				{
				}
				num = (short)1578237953;
				if (num != 0)
				{
				}
				return this.secWideGeneralEnhancedADPRadioInhibit_A41461._HasDiffs;
			}
		}

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x060020EF RID: 8431 RVA: 0x00208B18 File Offset: 0x00206D18
		// (set) Token: 0x060020F0 RID: 8432 RVA: 0x00208BCC File Offset: 0x00206DCC
		public bool SecWideInfiniteUKEKRetention_A41551Value
		{
			get
			{
				short num = (short)1232863232;
				short num2 = num;
				num = (short)82602477;
				short num3 = num;
				num = (short)1172662765;
				switch (num3 == num)
				{
				}
				num = (short)1975058433;
				if (num != 0)
				{
				}
				num = (short)1745420288;
				if (num != 0)
				{
				}
				return this.secWideInfiniteUKEKRetention_A41551.Value;
			}
			set
			{
				short num = (short)926744576;
				short num2 = num;
				num = (short)1288379342;
				short num3 = num;
				num = (short)1045961678;
				switch (num3 == num)
				{
				}
				num = (short)843841537;
				if (num != 0)
				{
				}
				num = (short)1956839424;
				if (num != 0)
				{
				}
				this.secWideInfiniteUKEKRetention_A41551.Value = value;
			}
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x060020F1 RID: 8433 RVA: 0x00208C84 File Offset: 0x00206E84
		public global::AcpBusinessLayer.AcpField<bool> SecWideInfiniteUKEKRetention_A41551
		{
			get
			{
				short num = (short)150667264;
				short num2 = num;
				num = (short)219807745;
				if (num != 0)
				{
				}
				num = (short)1777195481;
				short num3 = num;
				num = (short)1830541785;
				switch (num3 == num)
				{
				}
				num = (short)1220083712;
				if (num != 0)
				{
				}
				return this.secWideInfiniteUKEKRetention_A41551;
			}
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x060020F2 RID: 8434 RVA: 0x00208D34 File Offset: 0x00206F34
		// (set) Token: 0x060020F3 RID: 8435 RVA: 0x00208DE8 File Offset: 0x00206FE8
		public bool SecWideInfiniteUKEKRetention_A41551_UIValue
		{
			get
			{
				short num = (short)12451840;
				short num2 = num;
				num = (short)1160302718;
				short num3 = num;
				num = (short)254464126;
				switch (num3 == num)
				{
				}
				num = (short)1010696193;
				if (num != 0)
				{
				}
				num = (short)1208745984;
				if (num != 0)
				{
				}
				return this.secWideInfiniteUKEKRetention_A41551.Value;
			}
			set
			{
				short num = (short)2112225280;
				short num2 = num;
				num = (short)960129842;
				short num3 = num;
				num = (short)2026859314;
				switch (num3 == num)
				{
				}
				num = (short)942080001;
				if (num != 0)
				{
				}
				num = (short)661127168;
				if (num != 0)
				{
				}
				this.secWideInfiniteUKEKRetention_A41551.Value = value;
			}
		}

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x060020F4 RID: 8436 RVA: 0x00208EA0 File Offset: 0x002070A0
		// (set) Token: 0x060020F5 RID: 8437 RVA: 0x00208F54 File Offset: 0x00207154
		public bool SecWideInfiniteUKEKRetention_A41551_Applicable
		{
			get
			{
				short num = (short)1806368768;
				short num2 = num;
				num = (short)1535586500;
				short num3 = num;
				num = (short)1636708548;
				switch (num3 == num)
				{
				}
				num = (short)1747517441;
				if (num != 0)
				{
				}
				num = (short)1408434176;
				if (num != 0)
				{
				}
				return this.secWideInfiniteUKEKRetention_A41551.Applicable;
			}
			set
			{
				short num = (short)1385168896;
				short num2 = num;
				num = (short)399934131;
				short num3 = num;
				num = (short)1152615091;
				switch (num3 == num)
				{
				}
				num = (short)508231681;
				if (num != 0)
				{
				}
				num = (short)1488650240;
				if (num != 0)
				{
				}
				this.secWideInfiniteUKEKRetention_A41551.Applicable = value;
			}
		}

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x060020F6 RID: 8438 RVA: 0x0020900C File Offset: 0x0020720C
		// (set) Token: 0x060020F7 RID: 8439 RVA: 0x002090C4 File Offset: 0x002072C4
		public bool SecWideInfiniteUKEKRetention_A41551_Valid
		{
			get
			{
				short num = (short)1852047360;
				short num2 = num;
				num = (short)520537581;
				short num3 = num;
				num = (short)1917568493;
				switch (num3 == num)
				{
				}
				num = (short)171835393;
				if (num != 0)
				{
				}
				num = (short)407896064;
				if (num != 0)
				{
				}
				return this.secWideInfiniteUKEKRetention_A41551.Valid;
			}
			set
			{
				short num = (short)325779456;
				short num2 = num;
				num = (short)1630310269;
				short num3 = num;
				num = (short)234131325;
				switch (num3 == num)
				{
				}
				num = (short)277151745;
				if (num != 0)
				{
				}
				num = (short)1411710976;
				if (num != 0)
				{
				}
				this.secWideInfiniteUKEKRetention_A41551.Valid = value;
			}
		}

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x060020F8 RID: 8440 RVA: 0x00209178 File Offset: 0x00207378
		// (set) Token: 0x060020F9 RID: 8441 RVA: 0x0020922C File Offset: 0x0020742C
		public bool SecWideInfiniteUKEKRetention_A41551_Visible
		{
			get
			{
				short num = (short)1706491904;
				short num2 = num;
				num = (short)368650625;
				short num3 = num;
				num = (short)252979585;
				switch (num3 == num)
				{
				}
				num = (short)1171128321;
				if (num != 0)
				{
				}
				num = (short)1006895104;
				if (num != 0)
				{
				}
				return this.secWideInfiniteUKEKRetention_A41551.Visible;
			}
			set
			{
				short num = (short)1226833920;
				short num2 = num;
				num = (short)460324865;
				if (num != 0)
				{
				}
				num = (short)1712108433;
				short num3 = num;
				num = (short)343323537;
				switch (num3 == num)
				{
				}
				num = (short)2071789568;
				if (num != 0)
				{
				}
				this.secWideInfiniteUKEKRetention_A41551.Visible = value;
			}
		}

		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x060020FA RID: 8442 RVA: 0x002092E4 File Offset: 0x002074E4
		// (set) Token: 0x060020FB RID: 8443 RVA: 0x0020939C File Offset: 0x0020759C
		public bool SecWideInfiniteUKEKRetention_A41551_Editable
		{
			get
			{
				short num = (short)1480916992;
				short num2 = num;
				num = (short)331770250;
				short num3 = num;
				num = (short)1087531402;
				switch (num3 == num)
				{
				}
				num = (short)1740439553;
				if (num != 0)
				{
				}
				num = (short)838139904;
				if (num != 0)
				{
				}
				return this.secWideInfiniteUKEKRetention_A41551.Editable;
			}
			set
			{
				short num = (short)362217472;
				short num2 = num;
				num = (short)1471690;
				short num3 = num;
				num = (short)50296010;
				switch (num3 == num)
				{
				}
				num = (short)1044840449;
				if (num != 0)
				{
				}
				num = (short)807600128;
				if (num != 0)
				{
				}
				this.secWideInfiniteUKEKRetention_A41551.Editable = value;
			}
		}

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x060020FC RID: 8444 RVA: 0x00209450 File Offset: 0x00207650
		internal string SecWideInfiniteUKEKRetention_A41551_UILabel
		{
			get
			{
				short num = (short)1872297984;
				short num2 = num;
				num = (short)1589570933;
				short num3 = num;
				num = (short)1287122293;
				switch (num3 == num)
				{
				}
				num = (short)839778304;
				if (num != 0)
				{
				}
				num = (short)1109655553;
				if (num != 0)
				{
				}
				return this.secWideInfiniteUKEKRetention_A41551.UIName;
			}
		}

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x060020FD RID: 8445 RVA: 0x00209504 File Offset: 0x00207704
		// (set) Token: 0x060020FE RID: 8446 RVA: 0x002095B8 File Offset: 0x002077B8
		internal bool SecWideInfiniteUKEKRetention_A41551_HiddenStatic
		{
			get
			{
				short num = (short)1434255360;
				short num2 = num;
				num = (short)695903958;
				short num3 = num;
				num = (short)1133749974;
				switch (num3 == num)
				{
				}
				num = (short)400556033;
				if (num != 0)
				{
				}
				num = (short)1286995968;
				if (num != 0)
				{
				}
				return this.secWideInfiniteUKEKRetention_A41551.HiddenStatic;
			}
			set
			{
				short num = (short)778502144;
				short num2 = num;
				num = (short)396311039;
				short num3 = num;
				num = (short)1226455551;
				switch (num3 == num)
				{
				}
				num = (short)1446313985;
				if (num != 0)
				{
				}
				num = (short)1209991168;
				if (num != 0)
				{
				}
				this.secWideInfiniteUKEKRetention_A41551.HiddenStatic = value;
			}
		}

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x060020FF RID: 8447 RVA: 0x0020966C File Offset: 0x0020786C
		// (set) Token: 0x06002100 RID: 8448 RVA: 0x00209720 File Offset: 0x00207920
		internal bool SecWideInfiniteUKEKRetention_A41551_HiddenDynamic
		{
			get
			{
				short num = (short)1209663488;
				short num2 = num;
				num = (short)2038100030;
				short num3 = num;
				num = (short)1801252926;
				switch (num3 == num)
				{
				}
				num = (short)643629057;
				if (num != 0)
				{
				}
				num = (short)78643200;
				if (num != 0)
				{
				}
				return this.secWideInfiniteUKEKRetention_A41551.HiddenDynamic;
			}
			set
			{
				short num = (short)716308480;
				short num2 = num;
				num = (short)1061118741;
				short num3 = num;
				num = (short)375677717;
				switch (num3 == num)
				{
				}
				num = (short)675610625;
				if (num != 0)
				{
				}
				num = (short)646316032;
				if (num != 0)
				{
				}
				this.secWideInfiniteUKEKRetention_A41551.HiddenDynamic = value;
			}
		}

		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x06002101 RID: 8449 RVA: 0x002097D4 File Offset: 0x002079D4
		public bool SecWideInfiniteUKEKRetention_A41551_HasDiffs
		{
			get
			{
				short num = (short)108331008;
				short num2 = num;
				num = (short)82460700;
				short num3 = num;
				num = (short)1313226780;
				switch (num3 == num)
				{
				}
				num = (short)53870592;
				if (num != 0)
				{
				}
				num = (short)615186433;
				if (num != 0)
				{
				}
				return this.secWideInfiniteUKEKRetention_A41551._HasDiffs;
			}
		}

		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x06002102 RID: 8450 RVA: 0x0020988C File Offset: 0x00207A8C
		// (set) Token: 0x06002103 RID: 8451 RVA: 0x00209940 File Offset: 0x00207B40
		public bool SecureWideADPAlgorithmEnable_43200Value
		{
			get
			{
				short num = (short)591659008;
				short num2 = num;
				num = (short)1095815044;
				short num3 = num;
				num = (short)1649201028;
				switch (num3 == num)
				{
				}
				num = (short)1648754689;
				if (num != 0)
				{
				}
				num = (short)1371406336;
				if (num != 0)
				{
				}
				return this.secureWideADPAlgorithmEnable_43200.Value;
			}
			set
			{
				short num = (short)787349504;
				short num2 = num;
				num = (short)1100462374;
				short num3 = num;
				num = (short)127383846;
				switch (num3 == num)
				{
				}
				num = (short)420020224;
				if (num != 0)
				{
				}
				num = (short)1206059009;
				if (num != 0)
				{
				}
				this.secureWideADPAlgorithmEnable_43200.Value = value;
			}
		}

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x06002104 RID: 8452 RVA: 0x002099F8 File Offset: 0x00207BF8
		public global::AcpBusinessLayer.AcpField<bool> SecureWideADPAlgorithmEnable_43200
		{
			get
			{
				short num = (short)1758330880;
				short num2 = num;
				num = (short)2103641717;
				short num3 = num;
				num = (short)1237845621;
				switch (num3 == num)
				{
				}
				num = (short)2067333120;
				if (num != 0)
				{
				}
				num = (short)1460600833;
				if (num != 0)
				{
				}
				return this.secureWideADPAlgorithmEnable_43200;
			}
		}

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x06002105 RID: 8453 RVA: 0x00209AA8 File Offset: 0x00207CA8
		// (set) Token: 0x06002106 RID: 8454 RVA: 0x00209B5C File Offset: 0x00207D5C
		public bool SecureWideADPAlgorithmEnable_43200_UIValue
		{
			get
			{
				short num = (short)643170304;
				short num2 = num;
				num = (short)456359281;
				short num3 = num;
				num = (short)2009628017;
				switch (num3 == num)
				{
				}
				num = (short)1147207681;
				if (num != 0)
				{
				}
				num = (short)1552941056;
				if (num != 0)
				{
				}
				return this.secureWideADPAlgorithmEnable_43200.Value;
			}
			set
			{
				short num = (short)1636827136;
				short num2 = num;
				num = (short)471879590;
				short num3 = num;
				num = (short)1045122982;
				switch (num3 == num)
				{
				}
				num = (short)1289748481;
				if (num != 0)
				{
				}
				num = (short)1447755776;
				if (num != 0)
				{
				}
				this.secureWideADPAlgorithmEnable_43200.Value = value;
			}
		}

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x06002107 RID: 8455 RVA: 0x00209C14 File Offset: 0x00207E14
		// (set) Token: 0x06002108 RID: 8456 RVA: 0x00209CC8 File Offset: 0x00207EC8
		public bool SecureWideADPAlgorithmEnable_43200_Applicable
		{
			get
			{
				short num = (short)1765081088;
				short num2 = num;
				num = (short)986691476;
				short num3 = num;
				num = (short)967489428;
				switch (num3 == num)
				{
				}
				num = (short)695336961;
				if (num != 0)
				{
				}
				num = (short)209387520;
				if (num != 0)
				{
				}
				return this.secureWideADPAlgorithmEnable_43200.Applicable;
			}
			set
			{
				short num = (short)120717312;
				short num2 = num;
				num = (short)1558446081;
				if (num != 0)
				{
				}
				num = (short)1790168222;
				short num3 = num;
				num = (short)1243401374;
				switch (num3 == num)
				{
				}
				num = (short)246218752;
				if (num != 0)
				{
				}
				this.secureWideADPAlgorithmEnable_43200.Applicable = value;
			}
		}

		// Token: 0x1700109E RID: 4254
		// (get) Token: 0x06002109 RID: 8457 RVA: 0x00209D7C File Offset: 0x00207F7C
		// (set) Token: 0x0600210A RID: 8458 RVA: 0x00209E30 File Offset: 0x00208030
		public bool SecureWideADPAlgorithmEnable_43200_Valid
		{
			get
			{
				short num = (short)1627389952;
				short num2 = num;
				num = (short)1208105172;
				short num3 = num;
				num = (short)2023176404;
				switch (num3 == num)
				{
				}
				num = (short)1771569152;
				if (num != 0)
				{
				}
				num = (short)230686721;
				if (num != 0)
				{
				}
				return this.secureWideADPAlgorithmEnable_43200.Valid;
			}
			set
			{
				short num = (short)1496776704;
				short num2 = num;
				num = (short)1754400814;
				short num3 = num;
				num = (short)176752686;
				switch (num3 == num)
				{
				}
				num = (short)288227328;
				if (num != 0)
				{
				}
				num = (short)1977614337;
				if (num != 0)
				{
				}
				this.secureWideADPAlgorithmEnable_43200.Valid = value;
			}
		}

		// Token: 0x1700109F RID: 4255
		// (get) Token: 0x0600210B RID: 8459 RVA: 0x00209EE8 File Offset: 0x002080E8
		// (set) Token: 0x0600210C RID: 8460 RVA: 0x00209F9C File Offset: 0x0020819C
		public bool SecureWideADPAlgorithmEnable_43200_Visible
		{
			get
			{
				short num = (short)297271296;
				short num2 = num;
				num = (short)1527148473;
				short num3 = num;
				num = (short)1922265017;
				switch (num3 == num)
				{
				}
				num = (short)490668033;
				if (num != 0)
				{
				}
				num = (short)272105472;
				if (num != 0)
				{
				}
				return this.secureWideADPAlgorithmEnable_43200.Visible;
			}
			set
			{
				short num = (short)401080320;
				short num2 = num;
				num = (short)778299093;
				short num3 = num;
				num = (short)1113319125;
				switch (num3 == num)
				{
				}
				num = (short)149815296;
				if (num != 0)
				{
				}
				num = (short)878641153;
				if (num != 0)
				{
				}
				this.secureWideADPAlgorithmEnable_43200.Visible = value;
			}
		}

		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x0600210D RID: 8461 RVA: 0x0020A050 File Offset: 0x00208250
		// (set) Token: 0x0600210E RID: 8462 RVA: 0x0020A104 File Offset: 0x00208304
		public bool SecureWideADPAlgorithmEnable_43200_Editable
		{
			get
			{
				short num = (short)1306984448;
				short num2 = num;
				num = (short)433141974;
				short num3 = num;
				num = (short)867186902;
				switch (num3 == num)
				{
				}
				num = (short)1903493120;
				if (num != 0)
				{
				}
				num = (short)441253889;
				if (num != 0)
				{
				}
				return this.secureWideADPAlgorithmEnable_43200.Editable;
			}
			set
			{
				short num = (short)1027145728;
				short num2 = num;
				num = (short)1673265153;
				if (num != 0)
				{
				}
				num = (short)1260125238;
				short num3 = num;
				num = (short)281738294;
				switch (num3 == num)
				{
				}
				num = (short)3276800;
				if (num != 0)
				{
				}
				this.secureWideADPAlgorithmEnable_43200.Editable = value;
			}
		}

		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x0600210F RID: 8463 RVA: 0x0020A1B8 File Offset: 0x002083B8
		internal string SecureWideADPAlgorithmEnable_43200_UILabel
		{
			get
			{
				short num = (short)587268096;
				short num2 = num;
				num = (short)327598345;
				short num3 = num;
				num = (short)398311689;
				switch (num3 == num)
				{
				}
				num = (short)1997471745;
				if (num != 0)
				{
				}
				num = (short)960102400;
				if (num != 0)
				{
				}
				return this.secureWideADPAlgorithmEnable_43200.UIName;
			}
		}

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x06002110 RID: 8464 RVA: 0x0020A26C File Offset: 0x0020846C
		// (set) Token: 0x06002111 RID: 8465 RVA: 0x0020A324 File Offset: 0x00208524
		internal bool SecureWideADPAlgorithmEnable_43200_HiddenStatic
		{
			get
			{
				short num = (short)1490092032;
				short num2 = num;
				num = (short)2020947156;
				short num3 = num;
				num = (short)1697395924;
				switch (num3 == num)
				{
				}
				num = (short)432472065;
				if (num != 0)
				{
				}
				num = (short)287637504;
				if (num != 0)
				{
				}
				return this.secureWideADPAlgorithmEnable_43200.HiddenStatic;
			}
			set
			{
				short num = (short)1063321600;
				short num2 = num;
				num = (short)840315101;
				short num3 = num;
				num = (short)968896733;
				switch (num3 == num)
				{
				}
				num = (short)560267265;
				if (num != 0)
				{
				}
				num = (short)1247805440;
				if (num != 0)
				{
				}
				this.secureWideADPAlgorithmEnable_43200.HiddenStatic = value;
			}
		}

		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x06002112 RID: 8466 RVA: 0x0020A3D8 File Offset: 0x002085D8
		// (set) Token: 0x06002113 RID: 8467 RVA: 0x0020A490 File Offset: 0x00208690
		internal bool SecureWideADPAlgorithmEnable_43200_HiddenDynamic
		{
			get
			{
				short num = (short)499712000;
				short num2 = num;
				num = (short)141887130;
				short num3 = num;
				num = (short)1514669722;
				switch (num3 == num)
				{
				}
				num = (short)816513025;
				if (num != 0)
				{
				}
				num = (short)1389559808;
				if (num != 0)
				{
				}
				return this.secureWideADPAlgorithmEnable_43200.HiddenDynamic;
			}
			set
			{
				short num = (short)945094656;
				short num2 = num;
				num = (short)1603192482;
				short num3 = num;
				num = (short)1182844578;
				switch (num3 == num)
				{
				}
				num = (short)1394540545;
				if (num != 0)
				{
				}
				num = (short)670498816;
				if (num != 0)
				{
				}
				this.secureWideADPAlgorithmEnable_43200.HiddenDynamic = value;
			}
		}

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x06002114 RID: 8468 RVA: 0x0020A544 File Offset: 0x00208744
		public bool SecureWideADPAlgorithmEnable_43200_HasDiffs
		{
			get
			{
				short num = (short)1057226752;
				short num2 = num;
				num = (short)395378689;
				if (num != 0)
				{
				}
				num = (short)1909752761;
				short num3 = num;
				num = (short)1460569017;
				switch (num3 == num)
				{
				}
				num = (short)1561853952;
				if (num != 0)
				{
				}
				return this.secureWideADPAlgorithmEnable_43200._HasDiffs;
			}
		}

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x06002115 RID: 8469 RVA: 0x0020A5F8 File Offset: 0x002087F8
		// (set) Token: 0x06002116 RID: 8470 RVA: 0x0020A6AC File Offset: 0x002088AC
		public bool SecureWideAESAlgorithmEnable_43201Value
		{
			get
			{
				short num = (short)2036596736;
				short num2 = num;
				num = (short)1116817595;
				short num3 = num;
				num = (short)1114917051;
				switch (num3 == num)
				{
				}
				num = (short)1656422401;
				if (num != 0)
				{
				}
				num = (short)660799488;
				if (num != 0)
				{
				}
				return this.secureWideAESAlgorithmEnable_43201.Value;
			}
			set
			{
				short num = (short)255918080;
				short num2 = num;
				num = (short)1851071095;
				short num3 = num;
				num = (short)888740471;
				switch (num3 == num)
				{
				}
				num = (short)1274871808;
				if (num != 0)
				{
				}
				num = (short)1031274497;
				if (num != 0)
				{
				}
				this.secureWideAESAlgorithmEnable_43201.Value = value;
			}
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x06002117 RID: 8471 RVA: 0x0020A760 File Offset: 0x00208960
		public global::AcpBusinessLayer.AcpField<bool> SecureWideAESAlgorithmEnable_43201
		{
			get
			{
				short num = (short)1449328640;
				short num2 = num;
				num = (short)225870993;
				short num3 = num;
				num = (short)883655825;
				switch (num3 == num)
				{
				}
				num = (short)40304641;
				if (num != 0)
				{
				}
				num = (short)1531379712;
				if (num != 0)
				{
				}
				return this.secureWideAESAlgorithmEnable_43201;
			}
		}

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x06002118 RID: 8472 RVA: 0x0020A810 File Offset: 0x00208A10
		// (set) Token: 0x06002119 RID: 8473 RVA: 0x0020A8C4 File Offset: 0x00208AC4
		public bool SecureWideAESAlgorithmEnable_43201_UIValue
		{
			get
			{
				short num = (short)740884480;
				short num2 = num;
				num = (short)1664762955;
				short num3 = num;
				num = (short)525878347;
				switch (num3 == num)
				{
				}
				num = (short)439812097;
				if (num != 0)
				{
				}
				num = (short)526909440;
				if (num != 0)
				{
				}
				return this.secureWideAESAlgorithmEnable_43201.Value;
			}
			set
			{
				short num = (short)1786183680;
				short num2 = num;
				num = (short)262050728;
				short num3 = num;
				num = (short)629248936;
				switch (num3 == num)
				{
				}
				num = (short)1574109185;
				if (num != 0)
				{
				}
				num = (short)1276379136;
				if (num != 0)
				{
				}
				this.secureWideAESAlgorithmEnable_43201.Value = value;
			}
		}

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x0600211A RID: 8474 RVA: 0x0020A978 File Offset: 0x00208B78
		// (set) Token: 0x0600211B RID: 8475 RVA: 0x0020AA2C File Offset: 0x00208C2C
		public bool SecureWideAESAlgorithmEnable_43201_Applicable
		{
			get
			{
				short num = (short)1020395520;
				short num2 = num;
				num = (short)2114865775;
				short num3 = num;
				num = (short)1221282415;
				switch (num3 == num)
				{
				}
				num = (short)185991169;
				if (num != 0)
				{
				}
				num = (short)1893924864;
				if (num != 0)
				{
				}
				return this.secureWideAESAlgorithmEnable_43201.Applicable;
			}
			set
			{
				short num = (short)551354368;
				short num2 = num;
				num = (short)38070400;
				short num3 = num;
				num = (short)691857536;
				switch (num3 == num)
				{
				}
				num = (short)627965953;
				if (num != 0)
				{
				}
				num = (short)437452800;
				if (num != 0)
				{
				}
				this.secureWideAESAlgorithmEnable_43201.Applicable = value;
			}
		}

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x0600211C RID: 8476 RVA: 0x0020AAE0 File Offset: 0x00208CE0
		// (set) Token: 0x0600211D RID: 8477 RVA: 0x0020AB98 File Offset: 0x00208D98
		public bool SecureWideAESAlgorithmEnable_43201_Valid
		{
			get
			{
				short num = (short)641466368;
				short num2 = num;
				num = (short)1625184695;
				short num3 = num;
				num = (short)60840375;
				switch (num3 == num)
				{
				}
				num = (short)77266945;
				if (num != 0)
				{
				}
				num = (short)392560640;
				if (num != 0)
				{
				}
				return this.secureWideAESAlgorithmEnable_43201.Valid;
			}
			set
			{
				short num = (short)475332608;
				short num2 = num;
				num = (short)1084015011;
				short num3 = num;
				num = (short)1385873827;
				switch (num3 == num)
				{
				}
				num = (short)1153892352;
				if (num != 0)
				{
				}
				num = (short)2039939073;
				if (num != 0)
				{
				}
				this.secureWideAESAlgorithmEnable_43201.Valid = value;
			}
		}

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x0600211E RID: 8478 RVA: 0x0020AC4C File Offset: 0x00208E4C
		// (set) Token: 0x0600211F RID: 8479 RVA: 0x0020AD00 File Offset: 0x00208F00
		public bool SecureWideAESAlgorithmEnable_43201_Visible
		{
			get
			{
				short num = (short)692125696;
				short num2 = num;
				num = (short)1358833385;
				short num3 = num;
				num = (short)181610217;
				switch (num3 == num)
				{
				}
				num = (short)449642497;
				if (num != 0)
				{
				}
				num = (short)190185472;
				if (num != 0)
				{
				}
				return this.secureWideAESAlgorithmEnable_43201.Visible;
			}
			set
			{
				short num = (short)621346816;
				short num2 = num;
				num = (short)860291073;
				if (num != 0)
				{
				}
				num = (short)443599398;
				short num3 = num;
				num = (short)2109917734;
				switch (num3 == num)
				{
				}
				num = (short)546832384;
				if (num != 0)
				{
				}
				this.secureWideAESAlgorithmEnable_43201.Visible = value;
			}
		}

		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x06002120 RID: 8480 RVA: 0x0020ADB8 File Offset: 0x00208FB8
		// (set) Token: 0x06002121 RID: 8481 RVA: 0x0020AE6C File Offset: 0x0020906C
		public bool SecureWideAESAlgorithmEnable_43201_Editable
		{
			get
			{
				short num = (short)1367932928;
				short num2 = num;
				num = (short)64234876;
				short num3 = num;
				num = (short)632825212;
				switch (num3 == num)
				{
				}
				num = (short)142344192;
				if (num != 0)
				{
				}
				num = (short)734068737;
				if (num != 0)
				{
				}
				return this.secureWideAESAlgorithmEnable_43201.Editable;
			}
			set
			{
				short num = (short)103965579;
				short num2 = num;
				num = (short)1783653259;
				switch (num2 == num)
				{
				default:
				{
					num = (short)214433792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)684785665;
				if (num != 0)
				{
				}
				num = (short)490340352;
				if (num != 0)
				{
				}
				this.secureWideAESAlgorithmEnable_43201.Editable = value;
			}
		}

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x06002122 RID: 8482 RVA: 0x0020AF24 File Offset: 0x00209124
		internal string SecureWideAESAlgorithmEnable_43201_UILabel
		{
			get
			{
				short num = (short)1871642625;
				if (num != 0)
				{
				}
				num = (short)903217152;
				short num2 = num;
				num = (short)520626549;
				short num3 = num;
				num = (short)328933749;
				switch (num3 == num)
				{
				}
				num = (short)287440896;
				if (num != 0)
				{
				}
				return this.secureWideAESAlgorithmEnable_43201.UIName;
			}
		}

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x06002123 RID: 8483 RVA: 0x0020AFDC File Offset: 0x002091DC
		// (set) Token: 0x06002124 RID: 8484 RVA: 0x0020B090 File Offset: 0x00209290
		internal bool SecureWideAESAlgorithmEnable_43201_HiddenStatic
		{
			get
			{
				short num = (short)1780614147;
				short num2 = num;
				num = (short)1173750787;
				switch (num2 == num)
				{
				default:
				{
					num = (short)634322944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)40173568;
				if (num != 0)
				{
				}
				num = (short)608174081;
				if (num != 0)
				{
				}
				return this.secureWideAESAlgorithmEnable_43201.HiddenStatic;
			}
			set
			{
				short num = (short)1595496150;
				short num2 = num;
				num = (short)907630294;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1207828480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)117506049;
				if (num != 0)
				{
				}
				num = (short)1943207936;
				if (num != 0)
				{
				}
				this.secureWideAESAlgorithmEnable_43201.HiddenStatic = value;
			}
		}

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x06002125 RID: 8485 RVA: 0x0020B144 File Offset: 0x00209344
		// (set) Token: 0x06002126 RID: 8486 RVA: 0x0020B1FC File Offset: 0x002093FC
		internal bool SecureWideAESAlgorithmEnable_43201_HiddenDynamic
		{
			get
			{
				short num = (short)340721665;
				if (num != 0)
				{
				}
				num = (short)484638720;
				short num2 = num;
				num = (short)284079606;
				short num3 = num;
				num = (short)197768694;
				switch (num3 == num)
				{
				}
				num = (short)581107712;
				if (num != 0)
				{
				}
				return this.secureWideAESAlgorithmEnable_43201.HiddenDynamic;
			}
			set
			{
				short num = (short)1031431032;
				short num2 = num;
				num = (short)441803640;
				switch (num2 == num)
				{
				default:
				{
					num = (short)927465472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2114519041;
				if (num != 0)
				{
				}
				num = (short)341180416;
				if (num != 0)
				{
				}
				this.secureWideAESAlgorithmEnable_43201.HiddenDynamic = value;
			}
		}

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x06002127 RID: 8487 RVA: 0x0020B2B0 File Offset: 0x002094B0
		public bool SecureWideAESAlgorithmEnable_43201_HasDiffs
		{
			get
			{
				short num = (short)1109327873;
				if (num != 0)
				{
				}
				num = (short)78643200;
				short num2 = num;
				num = (short)215785052;
				short num3 = num;
				num = (short)1393598044;
				switch (num3 == num)
				{
				}
				num = (short)88604672;
				if (num != 0)
				{
				}
				return this.secureWideAESAlgorithmEnable_43201._HasDiffs;
			}
		}

		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x06002128 RID: 8488 RVA: 0x0020B364 File Offset: 0x00209564
		// (set) Token: 0x06002129 RID: 8489 RVA: 0x0020B418 File Offset: 0x00209618
		public bool SecureWideDESAlgorithmEnable_43744Value
		{
			get
			{
				short num = (short)1886751283;
				short num2 = num;
				num = (short)141527603;
				switch (num2 == num)
				{
				default:
				{
					num = (short)421724160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)695009280;
				if (num != 0)
				{
				}
				num = (short)1582956545;
				if (num != 0)
				{
				}
				return this.secureWideDESAlgorithmEnable_43744.Value;
			}
			set
			{
				int a_ = 11;
				short num = (short)513867777;
				if (num != 0)
				{
				}
				num = (short)316276736;
				short num2 = num;
				num = (short)1054939369;
				short num3 = num;
				num = (short)1008933097;
				switch (num3 == num)
				{
				}
				num = (short)938999808;
				if (num != 0)
				{
				}
				global::System.Diagnostics.Trace.WriteLine(string.Format(global::AllFeatures.CodeplugGuid.b("鿋ꯍ꓏ꛑ뷓룕뿗龎飛鯝돟싡쳣ꋥ觧黩跫컭뗯鳱音蓵臷諹裻韽濿氁␃唅簇欉戋樍焏怑瀓㼕㠗礙琛笝䌟䤡䘣䤥倧਩娫伭尯䜱儳వᠷ䄹఻䌽", a_), value));
				this.secureWideDESAlgorithmEnable_43744.Value = value;
			}
		}

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x0600212A RID: 8490 RVA: 0x0020B4F4 File Offset: 0x002096F4
		public global::AcpBusinessLayer.AcpField<bool> SecureWideDESAlgorithmEnable_43744
		{
			get
			{
				short num = (short)631414420;
				short num2 = num;
				num = (short)853843604;
				switch (num2 == num)
				{
				default:
				{
					num = (short)328138752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1584332801;
				if (num != 0)
				{
				}
				num = (short)896860160;
				if (num != 0)
				{
				}
				return this.secureWideDESAlgorithmEnable_43744;
			}
		}

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x0600212B RID: 8491 RVA: 0x0020B5A0 File Offset: 0x002097A0
		// (set) Token: 0x0600212C RID: 8492 RVA: 0x0020B658 File Offset: 0x00209858
		public bool SecureWideDESAlgorithmEnable_43744_UIValue
		{
			get
			{
				short num = (short)898758639;
				short num2 = num;
				num = (short)343275503;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1898905600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)218300417;
				if (num != 0)
				{
				}
				num = (short)1864695808;
				if (num != 0)
				{
				}
				return this.secureWideDESAlgorithmEnable_43744.Value;
			}
			set
			{
				short num = (short)57637508;
				short num2 = num;
				num = (short)40532612;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1292697600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)36306945;
				if (num != 0)
				{
				}
				num = (short)508231680;
				if (num != 0)
				{
				}
				this.secureWideDESAlgorithmEnable_43744.Value = value;
			}
		}

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x0600212D RID: 8493 RVA: 0x0020B710 File Offset: 0x00209910
		// (set) Token: 0x0600212E RID: 8494 RVA: 0x0020B7C4 File Offset: 0x002099C4
		public bool SecureWideDESAlgorithmEnable_43744_Applicable
		{
			get
			{
				short num = (short)600069684;
				short num2 = num;
				num = (short)1856788020;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1609826304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)995098624;
				if (num != 0)
				{
				}
				num = (short)985137153;
				if (num != 0)
				{
				}
				return this.secureWideDESAlgorithmEnable_43744.Applicable;
			}
			set
			{
				short num = (short)800696488;
				short num2 = num;
				num = (short)370911400;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1558380544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)959053825;
				if (num != 0)
				{
				}
				num = (short)1362755584;
				if (num != 0)
				{
				}
				this.secureWideDESAlgorithmEnable_43744.Applicable = value;
			}
		}

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x0600212F RID: 8495 RVA: 0x0020B878 File Offset: 0x00209A78
		// (set) Token: 0x06002130 RID: 8496 RVA: 0x0020B930 File Offset: 0x00209B30
		public bool SecureWideDESAlgorithmEnable_43744_Valid
		{
			get
			{
				short num = (short)1190129835;
				short num2 = num;
				num = (short)511439019;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1101922304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)922812417;
				if (num != 0)
				{
				}
				num = (short)842268672;
				if (num != 0)
				{
				}
				return this.secureWideDESAlgorithmEnable_43744.Valid;
			}
			set
			{
				short num = (short)1183842305;
				if (num != 0)
				{
				}
				num = (short)1127612416;
				short num2 = num;
				num = (short)324056923;
				short num3 = num;
				num = (short)840218459;
				switch (num3 == num)
				{
				}
				num = (short)1063649280;
				if (num != 0)
				{
				}
				this.secureWideDESAlgorithmEnable_43744.Valid = value;
			}
		}

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x06002131 RID: 8497 RVA: 0x0020B9E8 File Offset: 0x00209BE8
		// (set) Token: 0x06002132 RID: 8498 RVA: 0x0020BA9C File Offset: 0x00209C9C
		public bool SecureWideDESAlgorithmEnable_43744_Visible
		{
			get
			{
				short num = (short)1365354625;
				short num2 = num;
				num = (short)1472571521;
				switch (num2 == num)
				{
				default:
				{
					num = (short)628097024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1284833280;
				if (num != 0)
				{
				}
				num = (short)442499073;
				if (num != 0)
				{
				}
				return this.secureWideDESAlgorithmEnable_43744.Visible;
			}
			set
			{
				short num = (short)671498230;
				short num2 = num;
				num = (short)1843871734;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1992491008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1818034176;
				if (num != 0)
				{
				}
				num = (short)1546059777;
				if (num != 0)
				{
				}
				this.secureWideDESAlgorithmEnable_43744.Visible = value;
			}
		}

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x06002133 RID: 8499 RVA: 0x0020BB54 File Offset: 0x00209D54
		// (set) Token: 0x06002134 RID: 8500 RVA: 0x0020BC08 File Offset: 0x00209E08
		public bool SecureWideDESAlgorithmEnable_43744_Editable
		{
			get
			{
				short num = (short)1441184920;
				short num2 = num;
				num = (short)460569752;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1502412800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1252982785;
				if (num != 0)
				{
				}
				num = (short)30670848;
				if (num != 0)
				{
				}
				return this.secureWideDESAlgorithmEnable_43744.Editable;
			}
			set
			{
				short num = (short)991404091;
				short num2 = num;
				num = (short)1543872571;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1125711872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)471269376;
				if (num != 0)
				{
				}
				num = (short)877527041;
				if (num != 0)
				{
				}
				this.secureWideDESAlgorithmEnable_43744.Editable = value;
			}
		}

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x06002135 RID: 8501 RVA: 0x0020BCBC File Offset: 0x00209EBC
		internal string SecureWideDESAlgorithmEnable_43744_UILabel
		{
			get
			{
				short num = (short)295924573;
				short num2 = num;
				num = (short)1561752413;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2060058624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)961216513;
				if (num != 0)
				{
				}
				num = (short)425263104;
				if (num != 0)
				{
				}
				return this.secureWideDESAlgorithmEnable_43744.UIName;
			}
		}

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x06002136 RID: 8502 RVA: 0x0020BD74 File Offset: 0x00209F74
		// (set) Token: 0x06002137 RID: 8503 RVA: 0x0020BE28 File Offset: 0x0020A028
		internal bool SecureWideDESAlgorithmEnable_43744_HiddenStatic
		{
			get
			{
				short num = (short)816737413;
				short num2 = num;
				num = (short)677014661;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1881014272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)212860929;
				if (num != 0)
				{
				}
				num = (short)1925775360;
				if (num != 0)
				{
				}
				return this.secureWideDESAlgorithmEnable_43744.HiddenStatic;
			}
			set
			{
				short num = (short)2093488729;
				short num2 = num;
				num = (short)232069721;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1394212864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1340801025;
				if (num != 0)
				{
				}
				num = (short)695009280;
				if (num != 0)
				{
				}
				this.secureWideDESAlgorithmEnable_43744.HiddenStatic = value;
			}
		}

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x06002138 RID: 8504 RVA: 0x0020BEDC File Offset: 0x0020A0DC
		// (set) Token: 0x06002139 RID: 8505 RVA: 0x0020BF90 File Offset: 0x0020A190
		internal bool SecureWideDESAlgorithmEnable_43744_HiddenDynamic
		{
			get
			{
				short num = (short)108799397;
				short num2 = num;
				num = (short)1227761061;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1562574848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)61079552;
				if (num != 0)
				{
				}
				num = (short)1176698881;
				if (num != 0)
				{
				}
				return this.secureWideDESAlgorithmEnable_43744.HiddenDynamic;
			}
			set
			{
				short num = (short)1925335794;
				short num2 = num;
				num = (short)2020166386;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1711472640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2106982401;
				if (num != 0)
				{
				}
				num = (short)1446117376;
				if (num != 0)
				{
				}
				this.secureWideDESAlgorithmEnable_43744.HiddenDynamic = value;
			}
		}

		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x0600213A RID: 8506 RVA: 0x0020C044 File Offset: 0x0020A244
		public bool SecureWideDESAlgorithmEnable_43744_HasDiffs
		{
			get
			{
				short num = (short)1810003162;
				short num2 = num;
				num = (short)412513498;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1795555328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)805175297;
				if (num != 0)
				{
				}
				num = (short)1421213696;
				if (num != 0)
				{
				}
				return this.secureWideDESAlgorithmEnable_43744._HasDiffs;
			}
		}

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x0020C0F8 File Offset: 0x0020A2F8
		// (set) Token: 0x0600213C RID: 8508 RVA: 0x0020C1AC File Offset: 0x0020A3AC
		public int SecureWideKeyloadingSource_43204Value
		{
			get
			{
				short num = (short)654930636;
				short num2 = num;
				num = (short)1844671180;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1356529664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)727187457;
				if (num != 0)
				{
				}
				num = (short)1457389568;
				if (num != 0)
				{
				}
				return this.secureWideKeyloadingSource_43204.Value;
			}
			set
			{
				short num = (short)1867448321;
				if (num != 0)
				{
				}
				num = (short)1390739456;
				short num2 = num;
				num = (short)1177301762;
				short num3 = num;
				num = (short)1644770050;
				switch (num3 == num)
				{
				}
				num = (short)2031222784;
				if (num != 0)
				{
				}
				this.secureWideKeyloadingSource_43204.Value = value;
			}
		}

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x0600213D RID: 8509 RVA: 0x0020C264 File Offset: 0x0020A464
		// (set) Token: 0x0600213E RID: 8510 RVA: 0x0020C31C File Offset: 0x0020A51C
		public string SecureWideKeyloadingSource_43204_UIValue
		{
			get
			{
				short num = (short)1433075713;
				if (num != 0)
				{
				}
				num = (short)1364131840;
				short num2 = num;
				num = (short)1829332774;
				short num3 = num;
				num = (short)1452107558;
				switch (num3 == num)
				{
				}
				num = (short)612106240;
				if (num != 0)
				{
				}
				return this.secureWideKeyloadingSource_43204.UIValue;
			}
			set
			{
				short num = (short)1819893212;
				short num2 = num;
				num = (short)138567132;
				switch (num2 == num)
				{
				default:
				{
					num = (short)712835072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1327824896;
				if (num != 0)
				{
				}
				num = (short)1173225473;
				if (num != 0)
				{
				}
				this.secureWideKeyloadingSource_43204.UIValue = value;
			}
		}

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x0600213F RID: 8511 RVA: 0x0020C3D0 File Offset: 0x0020A5D0
		public global::AcpBusinessLayer.AcpListField SecureWideKeyloadingSource_43204
		{
			get
			{
				short num = (short)1747845121;
				if (num != 0)
				{
				}
				num = (short)1421082624;
				short num2 = num;
				num = (short)472124154;
				short num3 = num;
				num = (short)974785274;
				switch (num3 == num)
				{
				}
				num = (short)1667104768;
				if (num != 0)
				{
				}
				return this.secureWideKeyloadingSource_43204;
			}
		}

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x06002140 RID: 8512 RVA: 0x0020C47C File Offset: 0x0020A67C
		// (set) Token: 0x06002141 RID: 8513 RVA: 0x0020C530 File Offset: 0x0020A730
		public bool SecureWideKeyloadingSource_43204_Applicable
		{
			get
			{
				short num = (short)2003046891;
				short num2 = num;
				num = (short)720638443;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1258356736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)880345089;
				if (num != 0)
				{
				}
				num = (short)93847552;
				if (num != 0)
				{
				}
				return this.secureWideKeyloadingSource_43204.Applicable;
			}
			set
			{
				short num = (short)1076444679;
				short num2 = num;
				num = (short)1527266823;
				switch (num2 == num)
				{
				default:
				{
					num = (short)626262016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1528365056;
				if (num != 0)
				{
				}
				num = (short)1354629121;
				if (num != 0)
				{
				}
				this.secureWideKeyloadingSource_43204.Applicable = value;
			}
		}

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x06002142 RID: 8514 RVA: 0x0020C5E4 File Offset: 0x0020A7E4
		// (set) Token: 0x06002143 RID: 8515 RVA: 0x0020C698 File Offset: 0x0020A898
		public bool SecureWideKeyloadingSource_43204_Valid
		{
			get
			{
				short num = (short)34228797;
				short num2 = num;
				num = (short)1206798909;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1859387392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)192479233;
				if (num != 0)
				{
				}
				num = (short)700579840;
				if (num != 0)
				{
				}
				return this.secureWideKeyloadingSource_43204.Valid;
			}
			set
			{
				short num = (short)1369277258;
				short num2 = num;
				num = (short)1720353610;
				switch (num2 == num)
				{
				default:
				{
					num = (short)508100608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1705639937;
				if (num != 0)
				{
				}
				num = (short)1516371968;
				if (num != 0)
				{
				}
				this.secureWideKeyloadingSource_43204.Valid = value;
			}
		}

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x06002144 RID: 8516 RVA: 0x0020C74C File Offset: 0x0020A94C
		// (set) Token: 0x06002145 RID: 8517 RVA: 0x0020C800 File Offset: 0x0020AA00
		public bool SecureWideKeyloadingSource_43204_Visible
		{
			get
			{
				short num = (short)964106081;
				short num2 = num;
				num = (short)1560680289;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1960312832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1767702528;
				if (num != 0)
				{
				}
				num = (short)272826369;
				if (num != 0)
				{
				}
				return this.secureWideKeyloadingSource_43204.Visible;
			}
			set
			{
				short num = (short)430307378;
				short num2 = num;
				num = (short)1778186290;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1445855232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)409403393;
				if (num != 0)
				{
				}
				num = (short)1388904448;
				if (num != 0)
				{
				}
				this.secureWideKeyloadingSource_43204.Visible = value;
			}
		}

		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x06002146 RID: 8518 RVA: 0x0020C8B8 File Offset: 0x0020AAB8
		// (set) Token: 0x06002147 RID: 8519 RVA: 0x0020C970 File Offset: 0x0020AB70
		public bool SecureWideKeyloadingSource_43204_Editable
		{
			get
			{
				short num = (short)1576495666;
				short num2 = num;
				num = (short)2006936114;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1255342080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1167917056;
				if (num != 0)
				{
				}
				num = (short)1600258049;
				if (num != 0)
				{
				}
				return this.secureWideKeyloadingSource_43204.Editable;
			}
			set
			{
				short num = (short)69959389;
				short num2 = num;
				num = (short)645562077;
				switch (num2 == num)
				{
				default:
				{
					num = (short)87556096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1906049025;
				if (num != 0)
				{
				}
				num = (short)648806400;
				if (num != 0)
				{
				}
				this.secureWideKeyloadingSource_43204.Editable = value;
			}
		}

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x06002148 RID: 8520 RVA: 0x0020CA24 File Offset: 0x0020AC24
		internal string SecureWideKeyloadingSource_43204_UILabel
		{
			get
			{
				short num = (short)152358244;
				short num2 = num;
				num = (short)372165988;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1023148032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1016397825;
				if (num != 0)
				{
				}
				num = (short)1626931200;
				if (num != 0)
				{
				}
				return this.secureWideKeyloadingSource_43204.UIName;
			}
		}

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x06002149 RID: 8521 RVA: 0x0020CAD8 File Offset: 0x0020ACD8
		// (set) Token: 0x0600214A RID: 8522 RVA: 0x0020CB8C File Offset: 0x0020AD8C
		internal bool SecureWideKeyloadingSource_43204_HiddenStatic
		{
			get
			{
				short num = (short)1371105342;
				short num2 = num;
				num = (short)1303078974;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1636630528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1827667969;
				if (num != 0)
				{
				}
				num = (short)1644494848;
				if (num != 0)
				{
				}
				return this.secureWideKeyloadingSource_43204.HiddenStatic;
			}
			set
			{
				short num = (short)2045131887;
				short num2 = num;
				num = (short)62536815;
				switch (num2 == num)
				{
				default:
				{
					num = (short)166133760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1735524353;
				if (num != 0)
				{
				}
				num = (short)1434910720;
				if (num != 0)
				{
				}
				this.secureWideKeyloadingSource_43204.HiddenStatic = value;
			}
		}

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x0600214B RID: 8523 RVA: 0x0020CC44 File Offset: 0x0020AE44
		// (set) Token: 0x0600214C RID: 8524 RVA: 0x0020CCF8 File Offset: 0x0020AEF8
		internal bool SecureWideKeyloadingSource_43204_HiddenDynamic
		{
			get
			{
				short num = (short)1424752641;
				if (num != 0)
				{
				}
				num = (short)193855488;
				short num2 = num;
				num = (short)1406233296;
				short num3 = num;
				num = (short)431778512;
				switch (num3 == num)
				{
				}
				num = (short)566099968;
				if (num != 0)
				{
				}
				return this.secureWideKeyloadingSource_43204.HiddenDynamic;
			}
			set
			{
				short num = (short)1709615655;
				short num2 = num;
				num = (short)274836007;
				switch (num2 == num)
				{
				default:
				{
					num = (short)951779328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)890634241;
				if (num != 0)
				{
				}
				num = (short)1205141504;
				if (num != 0)
				{
				}
				this.secureWideKeyloadingSource_43204.HiddenDynamic = value;
			}
		}

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x0600214D RID: 8525 RVA: 0x0020CDAC File Offset: 0x0020AFAC
		public bool SecureWideKeyloadingSource_43204_HasDiffs
		{
			get
			{
				short num = (short)1269047943;
				short num2 = num;
				num = (short)44311175;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1013645312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1156317185;
				if (num != 0)
				{
				}
				num = (short)383844352;
				if (num != 0)
				{
				}
				return this.secureWideKeyloadingSource_43204._HasDiffs;
			}
		}

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x0600214E RID: 8526 RVA: 0x0020CE60 File Offset: 0x0020B060
		// (set) Token: 0x0600214F RID: 8527 RVA: 0x0020CF14 File Offset: 0x0020B114
		public bool SecWideKeyListMgmtEraseAllKeys_43648Value
		{
			get
			{
				short num = (short)872483340;
				short num2 = num;
				num = (short)406522380;
				switch (num2 == num)
				{
				default:
				{
					num = (short)934739968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1020264449;
				if (num != 0)
				{
				}
				num = (short)1390346240;
				if (num != 0)
				{
				}
				return this.secWideKeyListMgmtEraseAllKeys_43648.Value;
			}
			set
			{
				short num = (short)3403287;
				short num2 = num;
				num = (short)1634725399;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1422065664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1823735808;
				if (num != 0)
				{
				}
				num = (short)847052801;
				if (num != 0)
				{
				}
				this.secWideKeyListMgmtEraseAllKeys_43648.Value = value;
			}
		}

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x06002150 RID: 8528 RVA: 0x0020CFC8 File Offset: 0x0020B1C8
		public global::AcpBusinessLayer.AcpField<bool> SecWideKeyListMgmtEraseAllKeys_43648
		{
			get
			{
				short num = (short)196340480;
				short num2 = num;
				num = (short)851766016;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1851588608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2039283712;
				if (num != 0)
				{
				}
				num = (short)1087897601;
				if (num != 0)
				{
				}
				return this.secWideKeyListMgmtEraseAllKeys_43648;
			}
		}

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x06002151 RID: 8529 RVA: 0x0020D074 File Offset: 0x0020B274
		// (set) Token: 0x06002152 RID: 8530 RVA: 0x0020D12C File Offset: 0x0020B32C
		public bool SecWideKeyListMgmtEraseAllKeys_43648_UIValue
		{
			get
			{
				short num = (short)1283414468;
				short num2 = num;
				num = (short)163469764;
				switch (num2 == num)
				{
				default:
				{
					num = (short)594083840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1707016192;
				if (num != 0)
				{
				}
				num = (short)479133697;
				if (num != 0)
				{
				}
				return this.secWideKeyListMgmtEraseAllKeys_43648.Value;
			}
			set
			{
				short num = (short)1263612197;
				short num2 = num;
				num = (short)794374437;
				switch (num2 == num)
				{
				default:
				{
					num = (short)467206144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)651034625;
				if (num != 0)
				{
				}
				num = (short)1098579968;
				if (num != 0)
				{
				}
				this.secWideKeyListMgmtEraseAllKeys_43648.Value = value;
			}
		}

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x06002153 RID: 8531 RVA: 0x0020D1E4 File Offset: 0x0020B3E4
		// (set) Token: 0x06002154 RID: 8532 RVA: 0x0020D298 File Offset: 0x0020B498
		public bool SecWideKeyListMgmtEraseAllKeys_43648_Applicable
		{
			get
			{
				short num = (short)1251848502;
				short num2 = num;
				num = (short)892121398;
				switch (num2 == num)
				{
				default:
				{
					num = (short)276103168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1841823745;
				if (num != 0)
				{
				}
				num = (short)334036992;
				if (num != 0)
				{
				}
				return this.secWideKeyListMgmtEraseAllKeys_43648.Applicable;
			}
			set
			{
				short num = (short)1057947649;
				if (num != 0)
				{
				}
				num = (short)1325334528;
				short num2 = num;
				num = (short)328630701;
				short num3 = num;
				num = (short)1343652269;
				switch (num3 == num)
				{
				}
				num = (short)1134952448;
				if (num != 0)
				{
				}
				this.secWideKeyListMgmtEraseAllKeys_43648.Applicable = value;
			}
		}

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x06002155 RID: 8533 RVA: 0x0020D350 File Offset: 0x0020B550
		// (set) Token: 0x06002156 RID: 8534 RVA: 0x0020D404 File Offset: 0x0020B604
		public bool SecWideKeyListMgmtEraseAllKeys_43648_Valid
		{
			get
			{
				short num = (short)316107344;
				short num2 = num;
				num = (short)338979408;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1449459712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1829371905;
				if (num != 0)
				{
				}
				num = (short)1890320384;
				if (num != 0)
				{
				}
				return this.secWideKeyListMgmtEraseAllKeys_43648.Valid;
			}
			set
			{
				short num = (short)1294073857;
				if (num != 0)
				{
				}
				num = (short)1198522368;
				short num2 = num;
				num = (short)164899307;
				short num3 = num;
				num = (short)67643883;
				switch (num3 == num)
				{
				}
				num = (short)439549952;
				if (num != 0)
				{
				}
				this.secWideKeyListMgmtEraseAllKeys_43648.Valid = value;
			}
		}

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x06002157 RID: 8535 RVA: 0x0020D4BC File Offset: 0x0020B6BC
		// (set) Token: 0x06002158 RID: 8536 RVA: 0x0020D570 File Offset: 0x0020B770
		public bool SecWideKeyListMgmtEraseAllKeys_43648_Visible
		{
			get
			{
				short num = (short)646623774;
				short num2 = num;
				num = (short)388346398;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1338245120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1800208385;
				if (num != 0)
				{
				}
				num = (short)1816592384;
				if (num != 0)
				{
				}
				return this.secWideKeyListMgmtEraseAllKeys_43648.Visible;
			}
			set
			{
				short num = (short)1191378945;
				if (num != 0)
				{
				}
				num = (short)1096286208;
				short num2 = num;
				num = (short)1754986246;
				short num3 = num;
				num = (short)1001060102;
				switch (num3 == num)
				{
				}
				num = (short)723845120;
				if (num != 0)
				{
				}
				this.secWideKeyListMgmtEraseAllKeys_43648.Visible = value;
			}
		}

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x06002159 RID: 8537 RVA: 0x0020D628 File Offset: 0x0020B828
		// (set) Token: 0x0600215A RID: 8538 RVA: 0x0020D6DC File Offset: 0x0020B8DC
		public bool SecWideKeyListMgmtEraseAllKeys_43648_Editable
		{
			get
			{
				short num = (short)1696139035;
				short num2 = num;
				num = (short)2095056667;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1554579456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)738263040;
				if (num != 0)
				{
				}
				num = (short)1596850177;
				if (num != 0)
				{
				}
				return this.secWideKeyListMgmtEraseAllKeys_43648.Editable;
			}
			set
			{
				short num = (short)1930485342;
				short num2 = num;
				num = (short)1641209438;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1305018368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)142409728;
				if (num != 0)
				{
				}
				num = (short)1817313281;
				if (num != 0)
				{
				}
				this.secWideKeyListMgmtEraseAllKeys_43648.Editable = value;
			}
		}

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x0600215B RID: 8539 RVA: 0x0020D794 File Offset: 0x0020B994
		internal string SecWideKeyListMgmtEraseAllKeys_43648_UILabel
		{
			get
			{
				short num = (short)86573057;
				if (num != 0)
				{
				}
				num = (short)1495072768;
				short num2 = num;
				num = (short)1725172707;
				short num3 = num;
				num = (short)600050659;
				switch (num3 == num)
				{
				}
				num = (short)322240512;
				if (num != 0)
				{
				}
				return this.secWideKeyListMgmtEraseAllKeys_43648.UIName;
			}
		}

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x0600215C RID: 8540 RVA: 0x0020D848 File Offset: 0x0020BA48
		// (set) Token: 0x0600215D RID: 8541 RVA: 0x0020D900 File Offset: 0x0020BB00
		internal bool SecWideKeyListMgmtEraseAllKeys_43648_HiddenStatic
		{
			get
			{
				short num = (short)1541226780;
				short num2 = num;
				num = (short)246563100;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1243217920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)813301760;
				if (num != 0)
				{
				}
				num = (short)739966977;
				if (num != 0)
				{
				}
				return this.secWideKeyListMgmtEraseAllKeys_43648.HiddenStatic;
			}
			set
			{
				short num = (short)1156968619;
				short num2 = num;
				num = (short)1894707371;
				switch (num2 == num)
				{
				default:
				{
					num = (short)206176256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1391067136;
				if (num != 0)
				{
				}
				num = (short)111280129;
				if (num != 0)
				{
				}
				this.secWideKeyListMgmtEraseAllKeys_43648.HiddenStatic = value;
			}
		}

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x0600215E RID: 8542 RVA: 0x0020D9B8 File Offset: 0x0020BBB8
		// (set) Token: 0x0600215F RID: 8543 RVA: 0x0020DA6C File Offset: 0x0020BC6C
		internal bool SecWideKeyListMgmtEraseAllKeys_43648_HiddenDynamic
		{
			get
			{
				short num = (short)737569626;
				short num2 = num;
				num = (short)1722903386;
				switch (num2 == num)
				{
				}
				num = (short)1755971584;
				short num3 = num;
				num = (short)749207552;
				if (num != 0)
				{
				}
				num = (short)1576992769;
				if (num != 0)
				{
				}
				return this.secWideKeyListMgmtEraseAllKeys_43648.HiddenDynamic;
			}
			set
			{
				short num = (short)744497932;
				short num2 = num;
				num = (short)1748574988;
				switch (num2 == num)
				{
				}
				num = (short)1934884864;
				short num3 = num;
				num = (short)472514561;
				if (num != 0)
				{
				}
				num = (short)199032832;
				if (num != 0)
				{
				}
				this.secWideKeyListMgmtEraseAllKeys_43648.HiddenDynamic = value;
			}
		}

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x06002160 RID: 8544 RVA: 0x0020DB24 File Offset: 0x0020BD24
		public bool SecWideKeyListMgmtEraseAllKeys_43648_HasDiffs
		{
			get
			{
				short num = (short)1725152012;
				short num2 = num;
				num = (short)912571148;
				switch (num2 == num)
				{
				}
				num = (short)728301568;
				short num3 = num;
				num = (short)1033961473;
				if (num != 0)
				{
				}
				num = (short)1264189440;
				if (num != 0)
				{
				}
				return this.secWideKeyListMgmtEraseAllKeys_43648._HasDiffs;
			}
		}

		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x06002161 RID: 8545 RVA: 0x0020DBD8 File Offset: 0x0020BDD8
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)581407641;
				short num2 = num;
				num = (short)549753753;
				switch (num2 == num)
				{
				}
				num = (short)1157431296;
				short num3 = num;
				num = (short)1112735745;
				if (num != 0)
				{
				}
				num = (short)1234960384;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x06002162 RID: 8546 RVA: 0x0020DC98 File Offset: 0x0020BE98
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation RefRadioInformation
		{
			get
			{
				short num = (short)942073347;
				short num2 = num;
				num = (short)1128326659;
				switch (num2 == num)
				{
				}
				num = (short)1116405760;
				short num3 = num;
				num = (short)144244736;
				if (num != 0)
				{
				}
				num = (short)347406337;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			}
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x0020DD54 File Offset: 0x0020BF54
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					if (base.ParentRecset != null)
					{
						num2 = (short)1531772931;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1105002496;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_B5;
				case 4:
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num2 = (short)1372077181;
					short num3 = num2;
					num2 = (short)179846269;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B5;
					default:
						num2 = (short)550830081;
						if (num2 != 0)
						{
						}
						num2 = (short)1151205376;
						if (num2 != 0)
						{
						}
						num2 = (short)1664221186;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
				IL_B5:
				num2 = (short)1168310276;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			num2 = (short)762183680;
			short num4 = num2;
			result = null;
			num2 = (short)284688385;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x0020DED0 File Offset: 0x0020C0D0
		private void b()
		{
			short num = (short)144378870;
			short num2 = num;
			num = (short)1148455926;
			switch (num2 == num)
			{
			}
			num = (short)1529348096;
			short num3 = num;
			num = (short)633864192;
			if (num != 0)
			{
			}
			num = (short)72089601;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x0020DF84 File Offset: 0x0020C184
		private void a()
		{
			short num = (short)995894621;
			short num2 = num;
			num = (short)190522717;
			switch (num2 == num)
			{
			}
			num = (short)735576064;
			short num3 = num;
			num = (short)2079981569;
			if (num != 0)
			{
			}
			num = (short)596312064;
			if (num != 0)
			{
			}
			base.PropertyChanged += global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General.OnSecureWideGeneralOtarEnablePropertyChanged;
			base.PropertyChanged += global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General.a;
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x0020E054 File Offset: 0x0020C254
		private static void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 1;
			short num = (short)870055939;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (secureWide.General.SecWideGeneralOTAROperation_43700.Value != 0)
					{
						num = (short)1715142656;
						short num3 = num;
						num = (short)55967748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					secureWide.General.SecWideGeneralOTAREnable_A7966.Value = false;
					num = (short)1152843781;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					secureWide = (global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide)(A_0 as global::AcpBusinessLayer.FeatureSection).Parent;
					num = (short)336461824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1714094081;
					if (num != 0)
					{
					}
					num = (short)1368260617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				case 4:
				{
					int value = secureWide.General.SecWideGeneralOTAROperation_43700.Value;
					num = (short)981401606;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					goto IL_1F9;
				case 6:
				{
					int value;
					switch (value)
					{
					case 1:
						goto IL_105;
					case 2:
						goto IL_92;
					case 3:
						goto IL_19C;
					default:
						num = (short)1466433546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					if (global::AcpCommonLib.FeatureManager.IsInitialized)
					{
						num = (short)343867393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D9;
				case 8:
					num = (short)681443335;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (A_0 != null)
					{
						num = (short)1905524744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D9;
				case 10:
					return;
				}
				IL_59:
				if (!(A_1.PropertyName == global::AllFeatures.CodeplugGuid.b("釁ꇃꗅ鿇ꏉ꣋ꯍ韏럑뫓돕꫗믙냛針듟ꏡ뛣ꧥ飧迩黫迭蓯鯱鯳飵ꟷ컹쿻짽ヿ㈁刃朅搇缉椋", a_)))
				{
					goto IL_2D9;
				}
				num = (short)1809645570;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_92:
			secureWide.MDCOTAR.SecWideMDCOTARMDCOTAREnable_A8488.Value = false;
			secureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value = true;
			secureWide.General.SecWideGeneralOTAREnable_A7966.Value = true;
			return;
			IL_105:
			secureWide.MDCOTAR.SecWideMDCOTARMDCOTAREnable_A8488.Value = true;
			secureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value = false;
			secureWide.General.SecWideGeneralOTAREnable_A7966.Value = true;
			return;
			IL_19C:
			secureWide.MDCOTAR.SecWideMDCOTARMDCOTAREnable_A8488.Value = true;
			secureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value = true;
			secureWide.General.SecWideGeneralOTAREnable_A7966.Value = true;
			return;
			IL_1F9:
			IL_2D9:
			num = (short)891935049;
			short num4 = num;
			num = (short)262265161;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_105;
			default:
				num = (short)639107072;
				if (num != 0)
				{
				}
				return;
			}
		}

		// Token: 0x06002167 RID: 8551 RVA: 0x0020E388 File Offset: 0x0020C588
		public static void OnSecureWideGeneralOtarEnablePropertyChanged(object section, global::System.ComponentModel.PropertyChangedEventArgs label)
		{
			int a_ = 0;
			short num = (short)477429760;
			switch (num)
			{
			default:
			{
				num = (short)1344471051;
				int num2 = (int)((global::System.IntPtr)num);
				global::AcpBusinessLayer.AcpField<int> acpField;
				for (;;)
				{
					bool value;
					bool value3;
					switch (num2)
					{
					case 0:
						goto IL_473;
					case 1:
						goto IL_116;
					case 2:
						goto IL_451;
					case 3:
					{
						if (value)
						{
							num = (short)648675329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1901985792;
						short num3 = num;
						num = (short)1169293326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_28F;
					case 5:
					{
						bool value2;
						if (value2)
						{
							num = (short)1764032532;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpField.Value = 0;
						num = (short)2036334596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (value3)
						{
							num = (short)454361105;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1366884355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_155;
					case 8:
						if (global::AcpCommonLib.FeatureManager.IsInitialized)
						{
							num = (short)868089868;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						num = (short)1440481298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						num = (short)701677353;
						short num4 = num;
						num = (short)1769914153;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_451;
						default:
							num = (short)964624384;
							if (num != 0)
							{
							}
							num = (short)1446838273;
							if (num != 0)
							{
							}
							if (!(label.PropertyName == global::AllFeatures.CodeplugGuid.b("鋀ꛂꛄ郆ꃈ꿊꣌軎苐蟒蟔飖雘迚鳜跞ꃠ냢뇤뗦ꛨꓪ맬껮ꏰ뛲鯴零鯸韺飼ꃾ䀀㐂㄄㸆㼈崊氌挎搐瘒", a_)))
							{
								num = (short)1174208521;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_155;
						}
						break;
					}
					case 11:
						switch (0)
						{
						case 0:
							goto IL_A2;
						}
						continue;
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide = (global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide)(section as global::AcpBusinessLayer.FeatureSection).Parent;
						value3 = secureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value;
						value = secureWide.MDCOTAR.SecWideMDCOTARMDCOTAREnable_A8488.Value;
						bool value2 = secureWide.General.SecWideGeneralOTAREnable_A7966.Value;
						acpField = secureWide.General.SecWideGeneralOTAROperation_43700;
						num = (short)572456965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						num = (short)887095306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (label.PropertyName != global::AllFeatures.CodeplugGuid.b("鋀ꛂꛄ郆ꃈ꿊꣌裎듐뷒냔ꗖ룘럚鋜诞ꃠ뇢ꃤ触裨觪臬諮껰닲싴컶쿸췺꯼黾洀瘂怄", a_))
						{
							num = (short)402653203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 15:
						num = (short)306118664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (section != null)
						{
							num = (short)993329167;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 17:
						goto IL_150;
					case 18:
						if (label.PropertyName == global::AllFeatures.CodeplugGuid.b("鋀ꛂꛄ郆ꃈ꿊꣌苎闐郒體菖飘觚郜鯞ꋠ곢뇤ꛦ믨껪菬軮鏰鿲郴ꣶ룸쏺짼쟾㤀唂搄欆簈渊", a_))
						{
							num = (short)676200455;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 19:
						goto IL_20D;
					case 20:
						num = (short)1048772610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A2:
					if (!(label.PropertyName == global::AllFeatures.CodeplugGuid.b("鋀ꛂꛄ郆ꃈ꿊꣌裎듐뷒냔ꗖ룘럚鋜诞ꃠ뇢ꃤ触裨觪臬諮껰닲싴컶쿸췺꯼黾洀瘂怄", a_)))
					{
						num = (short)1935015949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_155;
					IL_451:
					if (value3 && value)
					{
						num = (short)706740224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1311834118;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_155:
					num = (short)1322450960;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_116:
				acpField.Value = 1;
				return;
				IL_150:
				acpField.Value = 2;
				return;
				IL_20D:
				acpField.Value = 0;
				return;
				IL_28F:
				return;
				IL_473:
				acpField.Value = 3;
				return;
			}
			}
		}

		// Token: 0x04000BC3 RID: 3011
		private global::AcpBusinessLayer.AcpField<bool> secWideGeneralOTAREnable_A7966;

		// Token: 0x04000BC4 RID: 3012
		private global::AcpBusinessLayer.AcpField<bool> secWideMultikeyErasePreviousOnUserChange_A8373;

		// Token: 0x04000BC5 RID: 3013
		private global::AcpBusinessLayer.AcpField<bool> secWideMultikeyUserSelectable_A9604;

		// Token: 0x04000BC6 RID: 3014
		private global::AcpBusinessLayer.AcpField<bool> secureConfigurationSecureWide_A19833;

		// Token: 0x04000BC7 RID: 3015
		private global::AcpBusinessLayer.AcpField<bool> secWideGeneralOTARGenerateKeyLossKey_A8169;

		// Token: 0x04000BC8 RID: 3016
		private global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A9067;

		// Token: 0x04000BC9 RID: 3017
		private global::AcpBusinessLayer.AcpListField secWideGeneralOTAROperation_43700;

		// Token: 0x04000BCA RID: 3018
		private global::AcpBusinessLayer.AcpField<bool> secWideGeneralEnhancedADPRadioInhibit_A41461;

		// Token: 0x04000BCB RID: 3019
		private global::AcpBusinessLayer.AcpField<bool> secWideInfiniteUKEKRetention_A41551;

		// Token: 0x04000BCC RID: 3020
		private global::AcpBusinessLayer.AcpField<bool> secureWideADPAlgorithmEnable_43200;

		// Token: 0x04000BCD RID: 3021
		private global::AcpBusinessLayer.AcpField<bool> secureWideAESAlgorithmEnable_43201;

		// Token: 0x04000BCE RID: 3022
		private global::AcpBusinessLayer.AcpField<bool> secureWideDESAlgorithmEnable_43744;

		// Token: 0x04000BCF RID: 3023
		private global::AcpBusinessLayer.AcpListField secureWideKeyloadingSource_43204;

		// Token: 0x04000BD0 RID: 3024
		private global::AcpBusinessLayer.AcpField<bool> secWideKeyListMgmtEraseAllKeys_43648;
	}
}
