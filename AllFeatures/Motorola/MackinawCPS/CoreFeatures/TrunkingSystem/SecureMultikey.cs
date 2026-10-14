using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x020000A0 RID: 160
	[global::System.Serializable]
	public class SecureMultikey : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600125D RID: 4701 RVA: 0x00117B50 File Offset: 0x00115D50
		public SecureMultikey(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x00117B6C File Offset: 0x00115D6C
		protected SecureMultikey(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00117B84 File Offset: 0x00115D84
		public override void Init()
		{
			int a_ = 4;
			short num = (short)1425240540;
			short num2 = num;
			num = (short)477458908;
			switch (num2 == num)
			{
			}
			num = (short)1878917120;
			if (num != 0)
			{
			}
			num = (short)2128412672;
			short num3 = num;
			num = (short)1566834689;
			if (num != 0)
			{
			}
			this.trkSysSecureMultikeyASTROOTAR_A7494 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("釄뗆ꋈ飊듌볎苐뛒뛔ꋖꯘ뻚郜꫞跠韢賤賦賨鋪곬볮ꗰꇲ뫴룶그뫺꿼ꃾ䀀㐂㄄㸆㴈", a_), global::CommonResources.AcgResources.ID_OTARASTROOTAR);
			this.trkSysSecureMultikeyASTROOTAR_A7494.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysSecureMultikeyASTROOTAR_A7494.DataTransferOrder = 12;
			this.trkSysSecureMultikeyDESXLTxRxDefault_A7833 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("釄뗆ꋈ飊듌볎苐뛒뛔ꋖꯘ뻚郜꫞跠韢賤賦賨鋪ꧬꫮꋰ꯲맴ꏶ臸ꧺ藼믾搀攂搄爆攈缊刌与☐⬒☔␖", a_), global::CommonResources.AcgResources.ID_DESXLTXRXDEFAULT);
			this.trkSysSecureMultikeyDESXLTxRxDefault_A7833.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysSecureMultikeyDESXLTxRxDefault_A7833.DataTransferOrder = 36;
			this.trkSysSecureMultikeyDynamicAGKeySelect_A7914 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("釄뗆ꋈ飊듌볎苐뛒뛔ꋖꯘ뻚郜꫞跠韢賤賦賨鋪ꧬ雮鿰鋲飴黶髸뫺뫼듾搀稂嘄戆攈渊渌笎丐划∔⸖⠘⼚", a_), global::CommonResources.AcgResources.ID_DYNAMICREGROUPINGAGKEYSELECT, null, null, true, false);
			this.trkSysSecureMultikeyDynamicAGKeySelect_A7914.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysSecureMultikeyDynamicAGKeySelect_A7914.DataTransferOrder = 82;
			this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("釄뗆ꋈ飊듌볎苐뛒뛔ꋖꯘ뻚郜꫞跠韢賤賦賨鋪ꧬ雮鿰鋲飴黶髸꿺鳼鏾樀搂眄栆簈笊䘌樎栐䀒瀔笖簘砚検䀞怠ᐢᰤᘦᄨ", a_), global::CommonResources.AcgResources.ID_DYNAMICREGROUPINGTALKGROUPKEYSELECT, null, null, true, false);
			this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.DataTransferOrder = 83;
			this.trkSysSecureMultikeyFailsoftKeySelect_A8012 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("釄뗆ꋈ飊듌볎苐뛒뛔ꋖꯘ뻚郜꫞跠韢賤賦賨鋪꯬軮飰鿲蛴飶鿸迺뛼髾砀倂怄欆氈栊礌倎倐⬒└☖⬘", a_), global::CommonResources.AcgResources.ID_FAILSOFTKEYSELECT_1, null, null, true, false);
			this.trkSysSecureMultikeyFailsoftKeySelect_A8012.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysSecureMultikeyFailsoftKeySelect_A8012.DataTransferOrder = 57;
			this.trkSysSecureMultikeyInterconnectKeySelect_A8298 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("釄뗆ꋈ飊듌볎苐뛒뛔ꋖꯘ뻚郜꫞跠韢賤賦賨鋪ꓬ臮藰雲蟴银雸闺鏼髾戀眂丄戆瀈堊栌挎琐瀒愔䠖堘⌚⼜☞ᤠ", a_), global::CommonResources.AcgResources.ID_INTERCONNECTKEYSELECT_1, null, null, true, false);
			this.trkSysSecureMultikeyInterconnectKeySelect_A8298.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysSecureMultikeyInterconnectKeySelect_A8298.DataTransferOrder = 63;
			this.trkSysSecureMultikeyKMFProfileIndex_A8382 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("釄뗆ꋈ飊듌볎苐뛒뛔ꋖꯘ뻚郜꫞跠韢賤賦賨鋪ꛬꋮ런ꏲ蟴飶鿸鋺釼髾䠀洂愄戆焈吊䰌㜎∐⬒✔", a_), global::CommonResources.AcgResources.ID_OTARASTROOTARPROFILEINDEX, new string[]
			{
				global::CommonResources.AcgResources.ID_DISABLED
			}, new int[1], true, false, new string[]
			{
				global::CommonResources.AcgResources.ID_OTARKMFPROFILEINDEX
			});
			this.trkSysSecureMultikeyKMFProfileIndex_A8382.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysSecureMultikeyKMFProfileIndex_A8382.DataTransferOrder = 43;
			this.trkSysSecureMultikeyOTARTx_A8676 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("釄뗆ꋈ飊듌볎苐뛒뛔ꋖꯘ뻚郜꫞跠韢賤賦賨鋪ꋬ믮냰ꇲꇴ迶꛸뫺염짾㘀㔂", a_), global::CommonResources.AcgResources.ID_OTAROTARTX);
			this.trkSysSecureMultikeyOTARTx_A8676.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysSecureMultikeyOTARTx_A8676.DataTransferOrder = 90;
			this.trkSysSecureMultikeyPatchKeySelect_A8694 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("釄뗆ꋈ飊듌볎苐뛒뛔ꋖꯘ뻚郜꫞跠韢賤賦賨鋪뷬軮藰郲鷴볶鳸苺껼髾洀昂昄猆嘈䨊㔌㤎⠐✒", a_), global::CommonResources.AcgResources.ID_PATCHKEYSELECT, null, null, true, false);
			this.trkSysSecureMultikeyPatchKeySelect_A8694.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysSecureMultikeyPatchKeySelect_A8694.DataTransferOrder = 95;
			this.trkSysSecureMultikeyPrivateCallKeySelect_A8757 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("釄뗆ꋈ飊듌볎苐뛒뛔ꋖꯘ뻚郜꫞跠韢賤賦賨鋪뷬鷮飰藲铴菶鳸룺鳼鏾洀䠂怄縆娈渊愌樎爐朒䨔嘖℘Ⱊ⠜⠞", a_), global::CommonResources.AcgResources.ID_PRIVATECALLKEYSELECT_1, null, null, true, false);
			this.trkSysSecureMultikeyPrivateCallKeySelect_A8757.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysSecureMultikeyPrivateCallKeySelect_A8757.DataTransferOrder = 68;
			this.trkSysSecureMultikeySystemWideKeySelect_A9253 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("釄뗆ꋈ飊듌볎苐뛒뛔ꋖꯘ뻚郜꫞跠韢賤賦賨鋪뻬雮苰蟲郴髶껸鋺駼髾䨀昂簄吆氈朊栌氎攐䰒吔⸖⬘⸚⸜", a_), global::CommonResources.AcgResources.ID_SYSTEMWIDEKEYSELECT, null, null, true, false);
			this.trkSysSecureMultikeySystemWideKeySelect_A9253.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysSecureMultikeySystemWideKeySelect_A9253.DataTransferOrder = 75;
			this.trkSysSecureMultikeyAutoKeyIDRx_A43185 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("釄뗆ꋈ飊듌볎苐뛒뛔ꋖꯘ뻚郜꫞跠韢賤賦賨鋪곬髮藰鳲뻴鋶胸닺맼귾礀専䐄㌆㨈㨊㔌㨎", a_), global::CommonResources.AcgResources.ID_AUTOKEYIDRX);
			this.trkSysSecureMultikeyAutoKeyIDRx_A43185.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysSecureMultikeyAutoKeyIDRx_A43185.DataTransferOrder = 105;
			this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477 = new global::AcpBusinessLayer.AcpListField(2, this, global::AllFeatures.CodeplugGuid.b("釄뗆ꋈ飊듌볎苐뛒뛔ꋖꯘ뻚郜꫞跠韢賤賦賨鋪뷬鷮飰藲铴菶鳸룺鳼鏾洀倂怄搆簈礊栌䰎紐瘒琔攖䨘漚漜縞儠匢䰤䤦丨琪᤬ᰮ԰вȴ", a_), global::CommonResources.AcgResources.ID_PRIVATECALLSECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477LovStrs);
			this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477.DataTransferOrder = 502;
			this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478 = new global::AcpBusinessLayer.AcpListField(2, this, global::AllFeatures.CodeplugGuid.b("釄뗆ꋈ飊듌볎苐뛒뛔ꋖꯘ뻚郜꫞跠韢賤賦賨鋪ꓬ臮藰雲蟴银雸闺鏼髾戀眂嘄戆樈縊缌樎刐缒瀔瘖欘䠚検洞䀠匢唤並䜨䰪爬ᬮȰܲȴ༶", a_), global::CommonResources.AcgResources.ID_INTERCONNECTSECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysSecureMultikeyInterconnectSecureClearStrapping_43478LovStrs);
			this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478.DataTransferOrder = 503;
			this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479 = new global::AcpBusinessLayer.AcpListField(2, this, global::AllFeatures.CodeplugGuid.b("釄뗆ꋈ飊듌볎苐뛒뛔ꋖꯘ뻚郜꫞跠韢賤賦賨鋪꯬軮飰鿲蛴飶鿸迺껼髾戀瘂眄戆䨈朊栌渎挐䀒愔攖砘欚洜瘞传䐢稤ጦᨨἪᨬᘮ", a_), global::CommonResources.AcgResources.ID_FAILSOFTSECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysSecureMultikeyFailsoftSecureClearStrapping_43479LovStrs);
			this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479.DataTransferOrder = 501;
			this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489 = new global::AcpBusinessLayer.AcpListField(2, this, global::AllFeatures.CodeplugGuid.b("釄뗆ꋈ飊듌볎苐뛒뛔ꋖꯘ뻚郜꫞跠韢賤賦賨鋪ꧬ雮鿰鋲飴黶髸꣺飼鳾琀焂怄䐆攈渊氌紎䈐朒朔瘖椘欚琜焞䘠簢ᄤᐦᴨጪᐬ", a_), global::CommonResources.AcgResources.ID_DYNAMICREGROUPINGSECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysSecureMultikeyDynamicSecureClearStrapping_43489LovStrs);
			this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489.DataTransferOrder = 504;
			this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("釄뗆ꋈ飊듌볎苐뛒뛔ꋖꯘ뻚郜꫞跠韢賤賦賨鋪믬蛮菰蟲胴零闸꯺鳼跾甀洂怄甆䈈渊琌導琐缒瀔琖洘䐚尜⬞ሠᔢጤḦ", a_), global::CommonResources.AcgResources.ID_VIRTUALPARTNERKEYSELECT, null, null, true, false);
			this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669.DataTransferOrder = 508;
			this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("釄뗆ꋈ飊듌볎苐뛒뛔ꋖꯘ뻚郜꫞跠韢賤賦賨鋪믬蛮菰蟲胴零闸꯺鳼跾甀洂怄甆娈渊渌税挐瘒嘔笖簘稚漜䰞唠儢䐤圦夨䈪䌬䠮渰爲Ĵж༸఺഼", a_), global::CommonResources.AcgResources.ID_VIRTUALPARTNERSECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670LovStrs);
			this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670.DataTransferOrder = 509;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("雄ꋆ꫈뻊뿌꫎ﳒ髖곘럚꧜뛞諠蛢鳤", a_);
			base.Id = 10158;
			base.UIName = global::CommonResources.AcgResources.ID_SECUREMULTIKEY;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x001180D0 File Offset: 0x001162D0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 16;
			short num = (short)2042232834;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_A3C;
				case 1:
					goto IL_8B4;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_115;
					}
					continue;
				case 3:
					goto IL_901;
				case 4:
					goto IL_840;
				case 5:
					this.trkSysSecureMultikeyASTROOTAR_A7494 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶룸꣺ꧼ귾一䰂億䘆嬈吊䰌㠎┐⨒℔", a_), global::CommonResources.AcgResources.ID_OTARASTROOTAR);
					this.trkSysSecureMultikeyASTROOTAR_A7494.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysSecureMultikeyASTROOTAR_A7494.DataTransferOrder = 12;
					num = (short)340787200;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_C1D;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶꧸髺觼鳾椀䠂怄縆娈渊愌樎爐朒䨔嘖℘ⴚ␜⬞", a_)))
					{
						num = (short)813629469;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_39B;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶꧸觺铼觾怀眂怄䐆栈朊愌導琐瀒怔攖簘堚焜稞䀠儢瘤匦嬨䨪崬弮堰崲刴栶സ࠺़࠾癀", a_)))
					{
						num = (short)434569257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D61;
				case 9:
					this.trkSysSecureMultikeyDynamicAGKeySelect_A7914 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶뷸苺鏼黾氀樂昄䘆丈䀊栌瘎䈐瘒礔爖稘漚䈜帞ᘠᨢᐤጦ", a_), global::CommonResources.AcgResources.ID_DYNAMICREGROUPINGAGKEYSELECT, null, null, true, false);
					this.trkSysSecureMultikeyDynamicAGKeySelect_A7914.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysSecureMultikeyDynamicAGKeySelect_A7914.DataTransferOrder = 82;
					num = (short)1099235377;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶닸뛺민꿾猀氂挄渆攈渊䐌愎甐瘒洔䠖堘⌚⸜✞ጠ", a_)))
					{
						num = (short)1038024757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_757;
				case 11:
					this.trkSysSecureMultikeyDESXLTxRxDefault_A7833 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶뷸뻺껼ꟾ䴀圂約唆焈伊栌椎瀐昒礔挖䘘娚⨜✞ሠဢ", a_), global::CommonResources.AcgResources.ID_DESXLTXRXDEFAULT);
					this.trkSysSecureMultikeyDESXLTxRxDefault_A7833.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysSecureMultikeyDESXLTxRxDefault_A7833.DataTransferOrder = 36;
					num = (short)1522139158;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					this.trkSysSecureMultikeyOTARTx_A8676 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶뛸꿺볼귾唀笂娄䘆ㄈ㴊㨌㤎", a_), global::CommonResources.AcgResources.ID_OTAROTARTX);
					this.trkSysSecureMultikeyOTARTx_A8676.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysSecureMultikeyOTARTx_A8676.DataTransferOrder = 90;
					num = (short)1706164230;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_B2F;
				case 14:
					goto IL_6AE;
				case 15:
					num = (short)1136197665;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶뷸苺鏼黾氀樂昄匆栈朊昌栎挐簒怔朖刘縚搜䰞䐠伢䀤䐦崨琪氬ᠮ࠰Ȳഴ", a_), global::CommonResources.AcgResources.ID_DYNAMICREGROUPINGTALKGROUPKEYSELECT, null, null, true, false);
					this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.DataTransferOrder = 83;
					num = (short)810090499;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶꿸鋺迼课琀戂椄圆栈礊礌愎琐愒䘔爖稘渚漜稞戠伢䀤䘦嬨砪夬崮倰䌲䔴帶圸尺戼績畀灂獄灆祈", a_), global::CommonResources.AcgResources.ID_VIRTUALPARTNERSECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670LovStrs);
					this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670.DataTransferOrder = 509;
					num = (short)1352204307;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶꿸鋺迼课琀戂椄圆栈礊礌愎琐愒帔爖怘䠚砜猞䐠䀢儤砦栨ἪḬ᤮ܰਲ", a_)))
					{
						num = (short)1852309530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C6A;
				case 19:
					goto IL_4F6;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶뿸髺铼鏾爀氂挄猆娈渊渌税挐瘒嘔笖簘稚漜䰞唠儢䐤圦夨䈪䌬䠮渰ܲش̶ุȺ", a_)))
					{
						num = (short)74252338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6AE;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶뷸苺鏼黾氀樂昄吆氈栊砌紎琐倒礔爖砘椚东欞匠䈢唤圦䀨䔪䨬瀮԰2Ĵ༶8", a_)))
					{
						num = (short)1857028130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BD3;
				case 22:
					goto IL_608;
				case 23:
					goto IL_94B;
				case 24:
					this.trkSysSecureMultikeyFailsoftKeySelect_A8012 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶뿸髺铼鏾爀氂挄猆䈈渊琌導琐缒瀔琖洘䐚尜✞ᄠሢᜤ", a_), global::CommonResources.AcgResources.ID_FAILSOFTKEYSELECT_1, null, null, true, false);
					this.trkSysSecureMultikeyFailsoftKeySelect_A8012.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysSecureMultikeyFailsoftKeySelect_A8012.DataTransferOrder = 57;
					num = (short)1141702657;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					this.trkSysSecureMultikeySystemWideKeySelect_A9253 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶꫸苺軼课搀渂刄渆洈渊䘌樎栐䀒瀔笖簘砚検䀞怠ᨢᜤሦᨨ", a_), global::CommonResources.AcgResources.ID_SYSTEMWIDEKEYSELECT, null, null, true, false);
					this.trkSysSecureMultikeySystemWideKeySelect_A9253.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysSecureMultikeySystemWideKeySelect_A9253.DataTransferOrder = 75;
					num = (short)1909587972;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶꿸鋺迼课琀戂椄圆栈礊礌愎琐愒帔爖怘䠚砜猞䐠䀢儤砦栨ἪḬ᤮ܰਲ", a_), global::CommonResources.AcgResources.ID_VIRTUALPARTNERKEYSELECT, null, null, true, false);
					this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669.DataTransferOrder = 508;
					num = (short)623706143;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					goto IL_BD3;
				case 28:
					this.trkSysSecureMultikeyInterconnectKeySelect_A8298 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶냸闺觼髾猀怂樄椆月渊渌笎娐瘒气䐖簘眚砜簞唠簢搤ἦᬨሪᔬ", a_), global::CommonResources.AcgResources.ID_INTERCONNECTKEYSELECT_1, null, null, true, false);
					this.trkSysSecureMultikeyInterconnectKeySelect_A8298.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysSecureMultikeyInterconnectKeySelect_A8298.DataTransferOrder = 63;
					num = (short)1299316778;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					this.trkSysSecureMultikeyPatchKeySelect_A8694 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶꧸髺觼鳾椀䠂怄縆娈渊愌樎爐朒䨔嘖℘ⴚ␜⬞", a_), global::CommonResources.AcgResources.ID_PATCHKEYSELECT, null, null, true, false);
					this.trkSysSecureMultikeyPatchKeySelect_A8694.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysSecureMultikeyPatchKeySelect_A8694.DataTransferOrder = 95;
					num = (short)1197670455;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶꧸觺铼觾怀眂怄䐆栈朊愌䐎琐樒䘔爖甘縚縜欞縠戢ᴤဦᰨᰪ", a_)))
					{
						num = (short)2122055736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B2F;
				case 31:
					goto IL_C6A;
				case 32:
				{
					num = (short)1354366976;
					short num3 = num;
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶냸闺觼髾猀怂樄椆月渊渌笎䈐瘒瘔或欘縚帜猞䐠䈢圤琦崨太䰬弮䄰娲嬴倶昸༺฼ା癀筂", a_)))
					{
						num = (short)1738539062;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_94B;
				}
				case 33:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶룸꣺ꧼ귾一䰂億䘆嬈吊䰌㠎┐⨒℔", a_)))
					{
						num = (short)216203269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A3C;
				case 34:
					this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489 = new global::AcpBusinessLayer.AcpListField(2, this, global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶뷸苺鏼黾氀樂昄吆氈栊砌紎琐倒礔爖砘椚东欞匠䈢唤圦䀨䔪䨬瀮԰2Ĵ༶8", a_), global::CommonResources.AcgResources.ID_DYNAMICREGROUPINGSECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysSecureMultikeyDynamicSecureClearStrapping_43489LovStrs);
					this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489.DataTransferOrder = 504;
					num = (short)495845403;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶뿸髺铼鏾爀氂挄猆䈈渊琌導琐缒瀔琖洘䐚尜✞ᄠሢᜤ", a_)))
					{
						num = (short)894697496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8B4;
				case 36:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶뛸꿺볼귾唀笂娄䘆ㄈ㴊㨌㤎", a_)))
					{
						num = (short)1644691468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C1D;
				case 37:
					goto IL_13B;
				case 38:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶냸闺觼髾猀怂樄椆月渊渌笎娐瘒气䐖簘眚砜簞唠簢搤ἦᬨሪᔬ", a_)))
					{
						num = (short)152043548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9F0;
				case 39:
					if (producerFields != null)
					{
						num = (short)1810235407;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DD8;
				case 40:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶뷸苺鏼黾氀樂昄匆栈朊昌栎挐簒怔朖刘縚搜䰞䐠伢䀤䐦崨琪氬ᠮ࠰Ȳഴ", a_)))
					{
						num = (short)419823632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_901;
				case 41:
					this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477 = new global::AcpBusinessLayer.AcpListField(2, this, global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶꧸觺铼觾怀眂怄䐆栈朊愌導琐瀒怔攖簘堚焜稞䀠儢瘤匦嬨䨪崬弮堰崲刴栶സ࠺़࠾癀", a_), global::CommonResources.AcgResources.ID_PRIVATECALLSECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477LovStrs);
					this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477.DataTransferOrder = 502;
					num = (short)1744896052;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 42:
					goto IL_9F0;
				case 43:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶뷸苺鏼黾氀樂昄䘆丈䀊栌瘎䈐瘒礔爖稘漚䈜帞ᘠᨢᐤጦ", a_)))
					{
						num = (short)1573257225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E1;
				case 44:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶룸軺觼郾䨀昂簄丆䴈夊甌倎倐✒☔☖℘⸚", a_)))
					{
						num = (short)139329583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13B;
				case 45:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶꿸鋺迼课琀戂椄圆栈礊礌愎琐愒䘔爖稘渚漜稞戠伢䀤䘦嬨砪夬崮倰䌲䔴帶圸尺戼績畀灂獄灆祈", a_)))
					{
						num = (short)575668241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DD8;
				case 46:
					num = (short)1907163175;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 47:
					this.trkSysSecureMultikeyAutoKeyIDRx_A43185 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶룸軺觼郾䨀昂簄丆䴈夊甌倎倐✒☔☖℘⸚", a_), global::CommonResources.AcgResources.ID_AUTOKEYIDRX);
					this.trkSysSecureMultikeyAutoKeyIDRx_A43185.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysSecureMultikeyAutoKeyIDRx_A43185.DataTransferOrder = 105;
					num = (short)790822949;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 48:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶뷸뻺껼ꟾ䴀圂約唆焈伊栌椎瀐昒礔挖䘘娚⨜✞ሠဢ", a_)))
					{
						num = (short)1919352843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_608;
				case 49:
					goto IL_1E1;
				case 50:
					this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479 = new global::AcpBusinessLayer.AcpListField(2, this, global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶뿸髺铼鏾爀氂挄猆娈渊渌税挐瘒嘔笖簘稚漜䰞唠儢䐤圦夨䈪䌬䠮渰ܲش̶ุȺ", a_), global::CommonResources.AcgResources.ID_FAILSOFTSECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysSecureMultikeyFailsoftSecureClearStrapping_43479LovStrs);
					this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479.DataTransferOrder = 501;
					num = (short)377421838;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 51:
					goto IL_757;
				case 52:
					goto IL_D61;
				case 53:
					this.trkSysSecureMultikeyKMFProfileIndex_A8382 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶닸뛺민꿾猀氂挄渆攈渊䐌愎甐瘒洔䠖堘⌚⸜✞ጠ", a_), global::CommonResources.AcgResources.ID_OTARASTROOTARPROFILEINDEX, new string[]
					{
						global::CommonResources.AcgResources.ID_DISABLED
					}, new int[1], true, false, new string[]
					{
						global::CommonResources.AcgResources.ID_OTARKMFPROFILEINDEX
					});
					this.trkSysSecureMultikeyKMFProfileIndex_A8382.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysSecureMultikeyKMFProfileIndex_A8382.DataTransferOrder = 43;
					num = (short)1758920755;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 54:
					this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478 = new global::AcpBusinessLayer.AcpListField(2, this, global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶냸闺觼髾猀怂樄椆月渊渌笎䈐瘒瘔或欘縚帜猞䐠䈢圤琦崨太䰬弮䄰娲嬴倶昸༺฼ା癀筂", a_), global::CommonResources.AcgResources.ID_INTERCONNECTSECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysSecureMultikeyInterconnectSecureClearStrapping_43478LovStrs);
					this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478.DataTransferOrder = 503;
					num = (short)1491009559;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 55:
					goto IL_39B;
				case 56:
					this.trkSysSecureMultikeyPrivateCallKeySelect_A8757 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶꧸觺铼觾怀眂怄䐆栈朊愌䐎琐樒䘔爖甘縚縜欞縠戢ᴤဦᰨᰪ", a_), global::CommonResources.AcgResources.ID_PRIVATECALLKEYSELECT_1, null, null, true, false);
					this.trkSysSecureMultikeyPrivateCallKeySelect_A8757.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysSecureMultikeyPrivateCallKeySelect_A8757.DataTransferOrder = 68;
					num = (short)1337065485;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 57:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚軜뫞苠離韤苦ꓨ黪臬鯮飰飲郴軶꫸苺軼课搀渂刄渆洈渊䘌樎栐䀒瀔笖簘砚検䀞怠ᨢᜤሦᨨ", a_)))
					{
						num = (short)1404764185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_840;
				}
				IL_115:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)468189230;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_13B:
				num = (short)300351496;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E1:
				num = (short)310509608;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_39B:
				num = (short)2036793374;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_608:
				num = (short)1126367275;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6AE:
				num = (short)748683285;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_757:
				num = (short)1138240538;
				short num4 = num;
				num = (short)1434135578;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_6AE;
				default:
					num = (short)1332609024;
					if (num != 0)
					{
					}
					num = (short)1735655460;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_840:
				num = (short)989134849;
				if (num != 0)
				{
				}
				num = (short)1625227308;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8B4:
				num = (short)286130214;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_901:
				num = (short)912261155;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_94B:
				num = (short)1938489364;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9F0:
				num = (short)1724186634;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A3C:
				num = (short)11010096;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B2F:
				num = (short)324796473;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BD3:
				num = (short)1618804754;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C1D:
				num = (short)1838219271;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C6A:
				num = (short)671875117;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D61:
				num = (short)669122592;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4F6:
			IL_DD8:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苐뛒뛔ꋖꯘ뻚﷜쇠껢郤详鷨苪蛬諮裰", a_);
			base.Id = 10158;
			base.UIName = global::CommonResources.AcgResources.ID_SECUREMULTIKEY;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00118EE8 File Offset: 0x001170E8
		public override void PopulateReferences()
		{
			short num = (short)1075511296;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5B;
				}
				global::AcpCommonLib.IAcpRecordset embeddedRecset;
				for (;;)
				{
					IL_28:
					bool? flag;
					bool flag2;
					bool? flag3;
					switch (num2)
					{
					case 0:
						if (this.trkSysSecureMultikeyKMFProfileIndex_A8382.ReferencedNode != null)
						{
							num = (short)1164705797;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DC;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						if (secureKMFProfile != null)
						{
							num = (short)309657602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DC;
					}
					case 2:
						num = (short)546701321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)557580292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DC;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						embeddedRecset = secureKMFProfile.SecureHardwareEncryptionIndependentKeyList.EmbeddedRecset;
						num = (short)1604452358;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)792264712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_1BD;
					case 7:
					{
						bool? flag4;
						flag3 = flag4;
						goto IL_266;
					}
					case 8:
						if (this.trkSysSecureMultikeyKMFProfileIndex_A8382.Value > 0)
						{
							num = (short)446431242;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DC;
					case 9:
					{
						num = (short)1322577336;
						short num3 = num;
						num = (short)941419960;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num = (short)1990328320;
							if (num != 0)
							{
							}
							global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
							global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General general = secureKMFProfile.General;
							if (general == null)
							{
								bool? flag4 = null;
								num = (short)37027847;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							flag3 = new bool?(general.SecKmfProfGenIndependentKeyList_43597.Value);
							goto IL_266;
						}
						}
						break;
					}
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = this.trkSysSecureMultikeyKMFProfileIndex_A8382.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
						num = (short)1743781889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_5B;
					IL_266:
					flag = flag3;
					flag2 = true;
					num = (short)1982922752;
					short num4 = num;
					num = (short)321388547;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1BD:
				num = (short)2051670017;
				if (num != 0)
				{
				}
				IL_2DC:
				this.trkSysSecureMultikeyDynamicAGKeySelect_A7914.SetRecset(this.a(2021)[0][10040].EmbeddedRecset);
				this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.SetRecset(embeddedRecset);
				this.trkSysSecureMultikeyFailsoftKeySelect_A8012.SetRecset(embeddedRecset);
				this.trkSysSecureMultikeyInterconnectKeySelect_A8298.SetRecset(embeddedRecset);
				this.trkSysSecureMultikeyPatchKeySelect_A8694.SetRecset(embeddedRecset);
				this.trkSysSecureMultikeyPrivateCallKeySelect_A8757.SetRecset(embeddedRecset);
				this.trkSysSecureMultikeySystemWideKeySelect_A9253.SetRecset(embeddedRecset);
				this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669.SetRecset(embeddedRecset);
				return;
				IL_5B:
				this.trkSysSecureMultikeyKMFProfileIndex_A8382.SetRecset(this.a(2055));
				embeddedRecset = this.a(2021)[0][10040].EmbeddedRecset;
				num = (short)15335424;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00119250 File Offset: 0x00117450
		public override void DropReferences()
		{
			short num = (short)1314518579;
			short num2 = num;
			num = (short)818411059;
			switch (num2 == num)
			{
			}
			num = (short)1844248576;
			if (num != 0)
			{
			}
			num = (short)1367080961;
			if (num != 0)
			{
			}
			num = (short)2009989120;
			short num3 = num;
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x001192F8 File Offset: 0x001174F8
		public override void SetConstraints()
		{
			short num = (short)2008217931;
			short num2 = num;
			num = (short)646641995;
			switch (num2 == num)
			{
			}
			num = (short)814022657;
			if (num != 0)
			{
			}
			num = (short)1851195392;
			if (num != 0)
			{
			}
			num = (short)859176960;
			short num3 = num;
			this.trkSysSecureMultikeyASTROOTAR_A7494.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConSetValueKMFProfileIndex);
			this.trkSysSecureMultikeyASTROOTAR_A7494.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkAstroOtarAvailable);
			this.trkSysSecureMultikeyASTROOTAR_A7494.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkPer7494CallValidityConstraint);
			this.trkSysSecureMultikeyDESXLTxRxDefault_A7833.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConSecOperationIsHardware);
			this.trkSysSecureMultikeyDynamicAGKeySelect_A7914.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConSecEqpIsEnabledAndTrkSysTypeIIAndDynRgrpIsEnAndSecTypeIsHW);
			this.trkSysSecureMultikeyDynamicAGKeySelect_A7914.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conReferedHWKeyValid);
			this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConDynTlkGrpAndMultiKeyAndHWOrADPAndTrkSysTypeIsApco);
			this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conReferedHWKeyValid);
			this.trkSysSecureMultikeyFailsoftKeySelect_A8012.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.IsKeySelectApplicable);
			this.trkSysSecureMultikeyFailsoftKeySelect_A8012.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conReferedHWKeyValid);
			this.trkSysSecureMultikeyInterconnectKeySelect_A8298.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.IsKeySelectApplicable);
			this.trkSysSecureMultikeyInterconnectKeySelect_A8298.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conReferedHWKeyValid);
			this.trkSysSecureMultikeyKMFProfileIndex_A8382.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkKMFProfileIndexAvailable);
			this.trkSysSecureMultikeyKMFProfileIndex_A8382.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConSetValueAstroOTAR);
			this.trkSysSecureMultikeyKMFProfileIndex_A8382.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConValidConstraintForKMFProfileIndex);
			this.trkSysSecureMultikeyOTARTx_A8676.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConDependOnTrkAstroOtar);
			this.trkSysSecureMultikeyPatchKeySelect_A8694.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConHWOrADPAndTrkSysTypeApco);
			this.trkSysSecureMultikeyPatchKeySelect_A8694.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conReferedHWKeyValid);
			this.trkSysSecureMultikeyPrivateCallKeySelect_A8757.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.IsKeySelectApplicable);
			this.trkSysSecureMultikeyPrivateCallKeySelect_A8757.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conReferedHWKeyValid);
			this.trkSysSecureMultikeySystemWideKeySelect_A9253.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIIAndSecTypeIsHW);
			this.trkSysSecureMultikeySystemWideKeySelect_A9253.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conReferedHWKeyValid);
			this.trkSysSecureMultikeyAutoKeyIDRx_A43185.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conTrkSysSecureMultikeyAutoKeyIDRx);
			this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConHWOrADPAndTrkSysTypeApco);
			this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConHWOrADPAndTrkSysTypeApco);
			this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConHWOrADPAndTrkSysTypeApco);
			this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConHWOrADPAndTrkSysTypeApco);
			this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.IsVPKeySelectApplicable);
			this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conReferedHWKeyValid);
			this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConSecOperNotDisabledAndTrkSysTypeApco);
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00119654 File Offset: 0x00117854
		public override void SetupDependencies()
		{
			short num = (short)578551809;
			if (num != 0)
			{
			}
			num = (short)1430825258;
			short num2 = num;
			num = (short)842443050;
			switch (num2 == num)
			{
			}
			num = (short)1771241472;
			if (num != 0)
			{
			}
			num = (short)1383137280;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
			trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449.AddDependentObject(this.trkSysSecureMultikeyASTROOTAR_A7494);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysSecureMultikeyASTROOTAR_A7494);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.trkSysSecureMultikeyASTROOTAR_A7494);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.trkSysSecureMultikeyASTROOTAR_A7494);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkSysSecureMultikeyASTROOTAR_A7494);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.trkSysSecureMultikeyASTROOTAR_A7494);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkSysSecureMultikeyDESXLTxRxDefault_A7833);
			this.trkSysSecureMultikeyASTROOTAR_A7494.AddDependentObject(this.trkSysSecureMultikeyDynamicAGKeySelect_A7914);
			this.trkSysSecureMultikeyKMFProfileIndex_A8382.AddDependentObject(this.trkSysSecureMultikeyDynamicAGKeySelect_A7914);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkSysSecureMultikeyDynamicAGKeySelect_A7914);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.trkSysSecureMultikeyDynamicAGKeySelect_A7914);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.trkSysSecureMultikeyDynamicAGKeySelect_A7914);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysSecureMultikeyDynamicAGKeySelect_A7914);
			trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449.AddDependentObject(this.trkSysSecureMultikeyDynamicAGKeySelect_A7914);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.trkSysSecureMultikeyDynamicAGKeySelect_A7914);
			this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.trkSysSecureMultikeyDynamicAGKeySelect_A7914);
			trunkingSystem.Features.TrkSysFeaturesDynamicRegroupingEnable_A7969.AddDependentObject(this.trkSysSecureMultikeyDynamicAGKeySelect_A7914);
			this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489.AddDependentObject(this.trkSysSecureMultikeyDynamicAGKeySelect_A7914);
			this.trkSysSecureMultikeyASTROOTAR_A7494.AddDependentObject(this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918);
			this.trkSysSecureMultikeyKMFProfileIndex_A8382.AddDependentObject(this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918);
			trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449.AddDependentObject(this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918);
			this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918);
			trunkingSystem.Features.TrkSysFeaturesDynamicRegroupingEnable_A7969.AddDependentObject(this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918);
			this.trkSysSecureMultikeyASTROOTAR_A7494.AddDependentObject(this.trkSysSecureMultikeyFailsoftKeySelect_A8012);
			this.trkSysSecureMultikeyKMFProfileIndex_A8382.AddDependentObject(this.trkSysSecureMultikeyFailsoftKeySelect_A8012);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkSysSecureMultikeyFailsoftKeySelect_A8012);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.trkSysSecureMultikeyFailsoftKeySelect_A8012);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.trkSysSecureMultikeyFailsoftKeySelect_A8012);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysSecureMultikeyFailsoftKeySelect_A8012);
			trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449.AddDependentObject(this.trkSysSecureMultikeyFailsoftKeySelect_A8012);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.trkSysSecureMultikeyFailsoftKeySelect_A8012);
			this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.trkSysSecureMultikeyFailsoftKeySelect_A8012);
			this.trkSysSecureMultikeyASTROOTAR_A7494.AddDependentObject(this.trkSysSecureMultikeyInterconnectKeySelect_A8298);
			this.trkSysSecureMultikeyKMFProfileIndex_A8382.AddDependentObject(this.trkSysSecureMultikeyInterconnectKeySelect_A8298);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkSysSecureMultikeyInterconnectKeySelect_A8298);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.trkSysSecureMultikeyInterconnectKeySelect_A8298);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.trkSysSecureMultikeyInterconnectKeySelect_A8298);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysSecureMultikeyInterconnectKeySelect_A8298);
			trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449.AddDependentObject(this.trkSysSecureMultikeyInterconnectKeySelect_A8298);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.trkSysSecureMultikeyInterconnectKeySelect_A8298);
			this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.trkSysSecureMultikeyInterconnectKeySelect_A8298);
			this.trkSysSecureMultikeyASTROOTAR_A7494.AddDependentObject(this.trkSysSecureMultikeyKMFProfileIndex_A8382);
			trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449.AddDependentObject(this.trkSysSecureMultikeyKMFProfileIndex_A8382);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysSecureMultikeyKMFProfileIndex_A8382);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.trkSysSecureMultikeyKMFProfileIndex_A8382);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.trkSysSecureMultikeyKMFProfileIndex_A8382);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkSysSecureMultikeyKMFProfileIndex_A8382);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.trkSysSecureMultikeyKMFProfileIndex_A8382);
			this.trkSysSecureMultikeyASTROOTAR_A7494.AddDependentObject(this.trkSysSecureMultikeyOTARTx_A8676);
			trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449.AddDependentObject(this.trkSysSecureMultikeyOTARTx_A8676);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysSecureMultikeyOTARTx_A8676);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.trkSysSecureMultikeyOTARTx_A8676);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.trkSysSecureMultikeyOTARTx_A8676);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkSysSecureMultikeyOTARTx_A8676);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.trkSysSecureMultikeyOTARTx_A8676);
			this.trkSysSecureMultikeyASTROOTAR_A7494.AddDependentObject(this.trkSysSecureMultikeyPatchKeySelect_A8694);
			this.trkSysSecureMultikeyKMFProfileIndex_A8382.AddDependentObject(this.trkSysSecureMultikeyPatchKeySelect_A8694);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkSysSecureMultikeyPatchKeySelect_A8694);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.trkSysSecureMultikeyPatchKeySelect_A8694);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.trkSysSecureMultikeyPatchKeySelect_A8694);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysSecureMultikeyPatchKeySelect_A8694);
			trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449.AddDependentObject(this.trkSysSecureMultikeyPatchKeySelect_A8694);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.trkSysSecureMultikeyPatchKeySelect_A8694);
			this.RefRadioInformation.Labtool.RadInfoLabtoolH38G51Smartzone_A8185.AddDependentObject(this.trkSysSecureMultikeyPatchKeySelect_A8694);
			this.RefRadioInformation.Labtool.RadInfoLabtoolH37G50Smartnet_A8184.AddDependentObject(this.trkSysSecureMultikeyPatchKeySelect_A8694);
			this.trkSysSecureMultikeyASTROOTAR_A7494.AddDependentObject(this.trkSysSecureMultikeyPrivateCallKeySelect_A8757);
			this.trkSysSecureMultikeyKMFProfileIndex_A8382.AddDependentObject(this.trkSysSecureMultikeyPrivateCallKeySelect_A8757);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkSysSecureMultikeyPrivateCallKeySelect_A8757);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.trkSysSecureMultikeyPrivateCallKeySelect_A8757);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.trkSysSecureMultikeyPrivateCallKeySelect_A8757);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysSecureMultikeyPrivateCallKeySelect_A8757);
			trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449.AddDependentObject(this.trkSysSecureMultikeyPrivateCallKeySelect_A8757);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.trkSysSecureMultikeyPrivateCallKeySelect_A8757);
			this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.trkSysSecureMultikeyPrivateCallKeySelect_A8757);
			this.trkSysSecureMultikeyASTROOTAR_A7494.AddDependentObject(this.TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669);
			this.trkSysSecureMultikeyKMFProfileIndex_A8382.AddDependentObject(this.TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669);
			trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449.AddDependentObject(this.TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669);
			this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669);
			this.trkSysSecureMultikeyASTROOTAR_A7494.AddDependentObject(this.trkSysSecureMultikeySystemWideKeySelect_A9253);
			this.trkSysSecureMultikeyKMFProfileIndex_A8382.AddDependentObject(this.trkSysSecureMultikeySystemWideKeySelect_A9253);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkSysSecureMultikeySystemWideKeySelect_A9253);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.trkSysSecureMultikeySystemWideKeySelect_A9253);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.trkSysSecureMultikeySystemWideKeySelect_A9253);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysSecureMultikeySystemWideKeySelect_A9253);
			trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449.AddDependentObject(this.trkSysSecureMultikeySystemWideKeySelect_A9253);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.trkSysSecureMultikeySystemWideKeySelect_A9253);
			this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.trkSysSecureMultikeySystemWideKeySelect_A9253);
			this.RefRadioInformation.Labtool.RadInfoLabtoolH38G51Smartzone_A8185.AddDependentObject(this.trkSysSecureMultikeySystemWideKeySelect_A9253);
			this.RefRadioInformation.Labtool.RadInfoLabtoolH37G50Smartnet_A8184.AddDependentObject(this.trkSysSecureMultikeySystemWideKeySelect_A9253);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkSysSecureMultikeyAutoKeyIDRx_A43185);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysSecureMultikeyAutoKeyIDRx_A43185);
			this.RefRadioInformation.Labtool.RadInfoLabtoolH38G51Smartzone_A8185.AddDependentObject(this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477);
			this.RefRadioInformation.Labtool.RadInfoLabtoolH37G50Smartnet_A8184.AddDependentObject(this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477);
			this.RefRadioInformation.Labtool.RadInfoLabtoolH38G51Smartzone_A8185.AddDependentObject(this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478);
			this.RefRadioInformation.Labtool.RadInfoLabtoolH37G50Smartnet_A8184.AddDependentObject(this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478);
			this.RefRadioInformation.Labtool.RadInfoLabtoolH38G51Smartzone_A8185.AddDependentObject(this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479);
			this.RefRadioInformation.Labtool.RadInfoLabtoolH37G50Smartnet_A8184.AddDependentObject(this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479);
			this.RefRadioInformation.Labtool.RadInfoLabtoolH38G51Smartzone_A8185.AddDependentObject(this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489);
			this.RefRadioInformation.Labtool.RadInfoLabtoolH37G50Smartnet_A8184.AddDependentObject(this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489);
			this.RefRadioInformation.Labtool.RadInfoLabtoolH38G51Smartzone_A8185.AddDependentObject(this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670);
			this.RefRadioInformation.Labtool.RadInfoLabtoolH37G50Smartnet_A8184.AddDependentObject(this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670);
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x0011A2EC File Offset: 0x001184EC
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner EncryptionKeyListInnerSectionForTrkSysSecureMultikeyDynamicAGKeySelect_A7914
		{
			get
			{
				short num = (short)377358434;
				short num2 = num;
				num = (short)962463842;
				switch (num2 == num)
				{
				}
				num = (short)64815105;
				if (num != 0)
				{
				}
				num = (short)702021632;
				if (num != 0)
				{
				}
				num = (short)641794048;
				short num3 = num;
				return this.trkSysSecureMultikeyDynamicAGKeySelect_A7914.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner;
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06001266 RID: 4710 RVA: 0x0011A3A4 File Offset: 0x001185A4
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner EncryptionKeyListInnerSectionForTrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918
		{
			get
			{
				short num = (short)941096961;
				if (num != 0)
				{
				}
				num = (short)1048413463;
				short num2 = num;
				num = (short)785614103;
				switch (num2 == num)
				{
				}
				num = (short)1629880320;
				if (num != 0)
				{
				}
				num = (short)1563295744;
				short num3 = num;
				return this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner;
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x0011A45C File Offset: 0x0011865C
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner EncryptionKeyListInnerSectionForTrkSysSecureMultikeyFailsoftKeySelect_A8012
		{
			get
			{
				short num = (short)890337251;
				short num2 = num;
				num = (short)1013938147;
				switch (num2 == num)
				{
				}
				num = (short)2016608256;
				if (num != 0)
				{
				}
				num = (short)208011265;
				if (num != 0)
				{
				}
				num = (short)76611584;
				short num3 = num;
				return this.trkSysSecureMultikeyFailsoftKeySelect_A8012.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner;
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x0011A518 File Offset: 0x00118718
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner EncryptionKeyListInnerSectionForTrkSysSecureMultikeyInterconnectKeySelect_A8298
		{
			get
			{
				short num = (short)340263596;
				short num2 = num;
				num = (short)2017919660;
				switch (num2 == num)
				{
				}
				num = (short)1918500865;
				if (num != 0)
				{
				}
				num = (short)822607872;
				if (num != 0)
				{
				}
				num = (short)802226176;
				short num3 = num;
				return this.trkSysSecureMultikeyInterconnectKeySelect_A8298.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner;
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x0011A5D0 File Offset: 0x001187D0
		public global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile SecureKMFProfileForTrkSysSecureMultikeyKMFProfileIndex_A8382
		{
			get
			{
				short num = (short)1195566313;
				short num2 = num;
				num = (short)752542953;
				switch (num2 == num)
				{
				}
				num = (short)1229783040;
				if (num != 0)
				{
				}
				num = (short)1949958145;
				if (num != 0)
				{
				}
				num = (short)183042048;
				short num3 = num;
				return this.trkSysSecureMultikeyKMFProfileIndex_A8382.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x0011A688 File Offset: 0x00118888
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner EncryptionKeyListInnerSectionForTrkSysSecureMultikeyPatchKeySelect_A8694
		{
			get
			{
				short num = (short)1158759605;
				short num2 = num;
				num = (short)162677941;
				switch (num2 == num)
				{
				}
				num = (short)525008897;
				if (num != 0)
				{
				}
				num = (short)1900412928;
				if (num != 0)
				{
				}
				num = (short)393150464;
				short num3 = num;
				return this.trkSysSecureMultikeyPatchKeySelect_A8694.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner;
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x0011A740 File Offset: 0x00118940
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner EncryptionKeyListInnerSectionForTrkSysSecureMultikeyPrivateCallKeySelect_A8757
		{
			get
			{
				short num = (short)773123181;
				short num2 = num;
				num = (short)585034861;
				switch (num2 == num)
				{
				}
				num = (short)1956839425;
				if (num != 0)
				{
				}
				num = (short)482148352;
				if (num != 0)
				{
				}
				num = (short)516423680;
				short num3 = num;
				return this.trkSysSecureMultikeyPrivateCallKeySelect_A8757.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner;
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x0011A7F8 File Offset: 0x001189F8
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner EncryptionKeyListInnerSectionForTrkSysSecureMultikeySystemWideKeySelect_A9253
		{
			get
			{
				short num = (short)1513542767;
				short num2 = num;
				num = (short)231527535;
				switch (num2 == num)
				{
				}
				num = (short)975634432;
				if (num != 0)
				{
				}
				num = (short)1418526721;
				if (num != 0)
				{
				}
				num = (short)26935296;
				short num3 = num;
				return this.trkSysSecureMultikeySystemWideKeySelect_A9253.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner;
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x0011A8B4 File Offset: 0x00118AB4
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner EncryptionKeyListInnerSectionForTrkSysSecureMultikeyVirtualPartnerKeySelect_A43669
		{
			get
			{
				short num = (short)372602934;
				short num2 = num;
				num = (short)624195638;
				switch (num2 == num)
				{
				}
				num = (short)1598095360;
				if (num != 0)
				{
				}
				num = (short)227278849;
				if (num != 0)
				{
				}
				num = (short)1093468160;
				short num3 = num;
				return this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner;
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x0011A970 File Offset: 0x00118B70
		public bool HasDiffs
		{
			get
			{
				short num = (short)1566178848;
				short num2 = num;
				num = (short)321584672;
				switch (num2 == num)
				{
				}
				num = (short)1773928449;
				if (num != 0)
				{
				}
				num = (short)1308426240;
				if (num != 0)
				{
				}
				num = (short)934477824;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x0600126F RID: 4719 RVA: 0x0011AA20 File Offset: 0x00118C20
		// (set) Token: 0x06001270 RID: 4720 RVA: 0x0011AAD4 File Offset: 0x00118CD4
		public bool TrkSysSecureMultikeyASTROOTAR_A7494Value
		{
			get
			{
				short num = (short)233884288;
				short num2 = num;
				num = (short)1975503488;
				switch (num2 == num)
				{
				default:
				{
					num = (short)104660992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1062273025;
				if (num != 0)
				{
				}
				num = (short)1233584128;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyASTROOTAR_A7494.Value;
			}
			set
			{
				short num = (short)602109921;
				short num2 = num;
				num = (short)2116909025;
				switch (num2 == num)
				{
				default:
				{
					num = (short)264437760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)572194817;
				if (num != 0)
				{
				}
				num = (short)1955790848;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyASTROOTAR_A7494.Value = value;
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x0011AB8C File Offset: 0x00118D8C
		public global::AcpBusinessLayer.AcpField<bool> TrkSysSecureMultikeyASTROOTAR_A7494
		{
			get
			{
				short num = (short)1032189026;
				short num2 = num;
				num = (short)1320481890;
				switch (num2 == num)
				{
				default:
				{
					num = (short)658767872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1473970176;
				if (num != 0)
				{
				}
				num = (short)476971009;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyASTROOTAR_A7494;
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06001272 RID: 4722 RVA: 0x0011AC3C File Offset: 0x00118E3C
		// (set) Token: 0x06001273 RID: 4723 RVA: 0x0011ACF0 File Offset: 0x00118EF0
		public bool TrkSysSecureMultikeyASTROOTAR_A7494_UIValue
		{
			get
			{
				short num = (short)446161935;
				short num2 = num;
				num = (short)1927537679;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1350303744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)157810688;
				if (num != 0)
				{
				}
				num = (short)676724737;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyASTROOTAR_A7494.Value;
			}
			set
			{
				short num = (short)701483697;
				short num2 = num;
				num = (short)1219676849;
				switch (num2 == num)
				{
				default:
				{
					num = (short)876675072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)60751873;
				if (num != 0)
				{
				}
				num = (short)1572798464;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyASTROOTAR_A7494.Value = value;
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001274 RID: 4724 RVA: 0x0011ADA8 File Offset: 0x00118FA8
		// (set) Token: 0x06001275 RID: 4725 RVA: 0x0011AE60 File Offset: 0x00119060
		public bool TrkSysSecureMultikeyASTROOTAR_A7494_Applicable
		{
			get
			{
				short num = (short)876019713;
				if (num != 0)
				{
				}
				num = (short)1334902784;
				short num2 = num;
				num = (short)1499721184;
				short num3 = num;
				num = (short)1446178272;
				switch (num3 == num)
				{
				}
				num = (short)213909504;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyASTROOTAR_A7494.Applicable;
			}
			set
			{
				short num = (short)1974400592;
				short num2 = num;
				num = (short)688649808;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1213267968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1207894017;
				if (num != 0)
				{
				}
				num = (short)330432512;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyASTROOTAR_A7494.Applicable = value;
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x0011AF14 File Offset: 0x00119114
		// (set) Token: 0x06001277 RID: 4727 RVA: 0x0011AFCC File Offset: 0x001191CC
		public bool TrkSysSecureMultikeyASTROOTAR_A7494_Valid
		{
			get
			{
				short num = (short)1343160321;
				if (num != 0)
				{
				}
				num = (short)554958848;
				short num2 = num;
				num = (short)1648652936;
				short num3 = num;
				num = (short)1194750600;
				switch (num3 == num)
				{
				}
				num = (short)2063204352;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyASTROOTAR_A7494.Valid;
			}
			set
			{
				short num = (short)3303905;
				short num2 = num;
				num = (short)2147183073;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1848770560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1787363328;
				if (num != 0)
				{
				}
				num = (short)1882259457;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyASTROOTAR_A7494.Valid = value;
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06001278 RID: 4728 RVA: 0x0011B080 File Offset: 0x00119280
		// (set) Token: 0x06001279 RID: 4729 RVA: 0x0011B134 File Offset: 0x00119334
		public bool TrkSysSecureMultikeyASTROOTAR_A7494_Visible
		{
			get
			{
				short num = (short)944793626;
				short num2 = num;
				num = (short)1310091290;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1977483264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)780468225;
				if (num != 0)
				{
				}
				num = (short)206503936;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyASTROOTAR_A7494.Visible;
			}
			set
			{
				short num = (short)669838859;
				short num2 = num;
				num = (short)952692235;
				switch (num2 == num)
				{
				default:
				{
					num = (short)818872320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1368391680;
				if (num != 0)
				{
				}
				num = (short)272629761;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyASTROOTAR_A7494.Visible = value;
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x0600127A RID: 4730 RVA: 0x0011B1EC File Offset: 0x001193EC
		// (set) Token: 0x0600127B RID: 4731 RVA: 0x0011B2A0 File Offset: 0x001194A0
		public bool TrkSysSecureMultikeyASTROOTAR_A7494_Editable
		{
			get
			{
				short num = (short)1490217033;
				short num2 = num;
				num = (short)985065545;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1737228288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)411697152;
				if (num != 0)
				{
				}
				num = (short)1933639681;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyASTROOTAR_A7494.Editable;
			}
			set
			{
				short num = (short)138592496;
				short num2 = num;
				num = (short)153534704;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1395654656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1378025473;
				if (num != 0)
				{
				}
				num = (short)40828928;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyASTROOTAR_A7494.Editable = value;
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x0600127C RID: 4732 RVA: 0x0011B358 File Offset: 0x00119558
		internal string TrkSysSecureMultikeyASTROOTAR_A7494_UILabel
		{
			get
			{
				short num = (short)590354089;
				short num2 = num;
				num = (short)290526889;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1817837568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)632291328;
				if (num != 0)
				{
				}
				num = (short)1846542337;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyASTROOTAR_A7494.UIName;
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x0600127D RID: 4733 RVA: 0x0011B410 File Offset: 0x00119610
		// (set) Token: 0x0600127E RID: 4734 RVA: 0x0011B4C4 File Offset: 0x001196C4
		internal bool TrkSysSecureMultikeyASTROOTAR_A7494_HiddenStatic
		{
			get
			{
				short num = (short)166609368;
				short num2 = num;
				num = (short)1417691608;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2142044160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1839529985;
				if (num != 0)
				{
				}
				num = (short)808976384;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyASTROOTAR_A7494.HiddenStatic;
			}
			set
			{
				short num = (short)397279233;
				if (num != 0)
				{
				}
				num = (short)599261184;
				short num2 = num;
				num = (short)226724774;
				short num3 = num;
				num = (short)1954909094;
				switch (num3 == num)
				{
				}
				num = (short)51052544;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyASTROOTAR_A7494.HiddenStatic = value;
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x0600127F RID: 4735 RVA: 0x0011B578 File Offset: 0x00119778
		// (set) Token: 0x06001280 RID: 4736 RVA: 0x0011B62C File Offset: 0x0011982C
		internal bool TrkSysSecureMultikeyASTROOTAR_A7494_HiddenDynamic
		{
			get
			{
				short num = (short)2043588251;
				short num2 = num;
				num = (short)1586015899;
				switch (num2 == num)
				{
				default:
				{
					num = (short)781647872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)611254273;
				if (num != 0)
				{
				}
				num = (short)1791229952;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyASTROOTAR_A7494.HiddenDynamic;
			}
			set
			{
				short num = (short)2047410177;
				if (num != 0)
				{
				}
				num = (short)1584463872;
				short num2 = num;
				num = (short)104122754;
				short num3 = num;
				num = (short)1999620482;
				switch (num3 == num)
				{
				}
				num = (short)924778496;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyASTROOTAR_A7494.HiddenDynamic = value;
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x0011B6E4 File Offset: 0x001198E4
		public bool TrkSysSecureMultikeyASTROOTAR_A7494_HasDiffs
		{
			get
			{
				short num = (short)22386263;
				short num2 = num;
				num = (short)1362138711;
				switch (num2 == num)
				{
				default:
				{
					num = (short)940507136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1235091457;
				if (num != 0)
				{
				}
				num = (short)609812480;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyASTROOTAR_A7494._HasDiffs;
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06001282 RID: 4738 RVA: 0x0011B798 File Offset: 0x00119998
		// (set) Token: 0x06001283 RID: 4739 RVA: 0x0011B850 File Offset: 0x00119A50
		public bool TrkSysSecureMultikeyDESXLTxRxDefault_A7833Value
		{
			get
			{
				short num = (short)1511931023;
				short num2 = num;
				num = (short)1873427599;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1376845824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)262930433;
				if (num != 0)
				{
				}
				num = (short)281477120;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDESXLTxRxDefault_A7833.Value;
			}
			set
			{
				short num = (short)461927521;
				short num2 = num;
				num = (short)1082881121;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1483669504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1316552705;
				if (num != 0)
				{
				}
				num = (short)624558080;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDESXLTxRxDefault_A7833.Value = value;
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x0011B908 File Offset: 0x00119B08
		public global::AcpBusinessLayer.AcpField<bool> TrkSysSecureMultikeyDESXLTxRxDefault_A7833
		{
			get
			{
				short num = (short)1918959617;
				if (num != 0)
				{
				}
				num = (short)1156120576;
				short num2 = num;
				num = (short)764232230;
				short num3 = num;
				num = (short)679297574;
				switch (num3 == num)
				{
				}
				num = (short)1066860544;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDESXLTxRxDefault_A7833;
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x0011B9BC File Offset: 0x00119BBC
		// (set) Token: 0x06001286 RID: 4742 RVA: 0x0011BA70 File Offset: 0x00119C70
		public bool TrkSysSecureMultikeyDESXLTxRxDefault_A7833_UIValue
		{
			get
			{
				short num = (short)847314183;
				short num2 = num;
				num = (short)244448519;
				switch (num2 == num)
				{
				default:
				{
					num = (short)984285184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)989331456;
				if (num != 0)
				{
				}
				num = (short)1199243265;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDESXLTxRxDefault_A7833.Value;
			}
			set
			{
				short num = (short)1771478893;
				short num2 = num;
				num = (short)790798189;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1523122176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)405929985;
				if (num != 0)
				{
				}
				num = (short)975699968;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDESXLTxRxDefault_A7833.Value = value;
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x0011BB28 File Offset: 0x00119D28
		// (set) Token: 0x06001288 RID: 4744 RVA: 0x0011BBDC File Offset: 0x00119DDC
		public bool TrkSysSecureMultikeyDESXLTxRxDefault_A7833_Applicable
		{
			get
			{
				short num = (short)1787974020;
				short num2 = num;
				num = (short)450318724;
				switch (num2 == num)
				{
				default:
				{
					num = (short)486932480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)751108097;
				if (num != 0)
				{
				}
				num = (short)1609302016;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDESXLTxRxDefault_A7833.Applicable;
			}
			set
			{
				short num = (short)928900911;
				short num2 = num;
				num = (short)1687676719;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1485963264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)515244032;
				if (num != 0)
				{
				}
				num = (short)1628438529;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDESXLTxRxDefault_A7833.Applicable = value;
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x0011BC90 File Offset: 0x00119E90
		// (set) Token: 0x0600128A RID: 4746 RVA: 0x0011BD44 File Offset: 0x00119F44
		public bool TrkSysSecureMultikeyDESXLTxRxDefault_A7833_Valid
		{
			get
			{
				short num = (short)2033410708;
				short num2 = num;
				num = (short)1570333332;
				switch (num2 == num)
				{
				default:
				{
					num = (short)779943936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)765526017;
				if (num != 0)
				{
				}
				num = (short)1792606208;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDESXLTxRxDefault_A7833.Valid;
			}
			set
			{
				short num = (short)186446144;
				short num2 = num;
				num = (short)1919676736;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1919221760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)639696897;
				if (num != 0)
				{
				}
				num = (short)1206910976;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDESXLTxRxDefault_A7833.Valid = value;
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x0011BDF8 File Offset: 0x00119FF8
		// (set) Token: 0x0600128C RID: 4748 RVA: 0x0011BEAC File Offset: 0x0011A0AC
		public bool TrkSysSecureMultikeyDESXLTxRxDefault_A7833_Visible
		{
			get
			{
				short num = (short)283531912;
				short num2 = num;
				num = (short)958421640;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1075970048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1353383937;
				if (num != 0)
				{
				}
				num = (short)719192064;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDESXLTxRxDefault_A7833.Visible;
			}
			set
			{
				short num = (short)1705574401;
				if (num != 0)
				{
				}
				num = (short)2048327680;
				short num2 = num;
				num = (short)642311406;
				short num3 = num;
				num = (short)730588398;
				switch (num3 == num)
				{
				}
				num = (short)926547968;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDESXLTxRxDefault_A7833.Visible = value;
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x0011BF64 File Offset: 0x0011A164
		// (set) Token: 0x0600128E RID: 4750 RVA: 0x0011C018 File Offset: 0x0011A218
		public bool TrkSysSecureMultikeyDESXLTxRxDefault_A7833_Editable
		{
			get
			{
				short num = (short)2044304848;
				short num2 = num;
				num = (short)1147182544;
				switch (num2 == num)
				{
				default:
				{
					num = (short)685375488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)953155584;
				if (num != 0)
				{
				}
				num = (short)1448869889;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDESXLTxRxDefault_A7833.Editable;
			}
			set
			{
				short num = (short)1255163152;
				short num2 = num;
				num = (short)1210467600;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1047134208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)946077697;
				if (num != 0)
				{
				}
				num = (short)1953234944;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDESXLTxRxDefault_A7833.Editable = value;
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x0011C0D0 File Offset: 0x0011A2D0
		internal string TrkSysSecureMultikeyDESXLTxRxDefault_A7833_UILabel
		{
			get
			{
				short num = (short)346388909;
				short num2 = num;
				num = (short)1683192237;
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
				num = (short)1355415553;
				if (num != 0)
				{
				}
				num = (short)824180736;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDESXLTxRxDefault_A7833.UIName;
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06001290 RID: 4752 RVA: 0x0011C184 File Offset: 0x0011A384
		// (set) Token: 0x06001291 RID: 4753 RVA: 0x0011C238 File Offset: 0x0011A438
		internal bool TrkSysSecureMultikeyDESXLTxRxDefault_A7833_HiddenStatic
		{
			get
			{
				short num = (short)171746394;
				short num2 = num;
				num = (short)1999807578;
				switch (num2 == num)
				{
				default:
				{
					num = (short)140378112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2106982400;
				if (num != 0)
				{
				}
				num = (short)829620225;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDESXLTxRxDefault_A7833.HiddenStatic;
			}
			set
			{
				short num = (short)729947789;
				short num2 = num;
				num = (short)1086856845;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1094254592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)992542721;
				if (num != 0)
				{
				}
				num = (short)379125760;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDESXLTxRxDefault_A7833.HiddenStatic = value;
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06001292 RID: 4754 RVA: 0x0011C2EC File Offset: 0x0011A4EC
		// (set) Token: 0x06001293 RID: 4755 RVA: 0x0011C3A0 File Offset: 0x0011A5A0
		internal bool TrkSysSecureMultikeyDESXLTxRxDefault_A7833_HiddenDynamic
		{
			get
			{
				short num = (short)120382119;
				short num2 = num;
				num = (short)1346167463;
				switch (num2 == num)
				{
				default:
				{
					num = (short)453902336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1311899648;
				if (num != 0)
				{
				}
				num = (short)1057423361;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDESXLTxRxDefault_A7833.HiddenDynamic;
			}
			set
			{
				short num = (short)2139687216;
				short num2 = num;
				num = (short)527305008;
				switch (num2 == num)
				{
				default:
				{
					num = (short)995622912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)907608065;
				if (num != 0)
				{
				}
				num = (short)141164544;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDESXLTxRxDefault_A7833.HiddenDynamic = value;
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06001294 RID: 4756 RVA: 0x0011C458 File Offset: 0x0011A658
		public bool TrkSysSecureMultikeyDESXLTxRxDefault_A7833_HasDiffs
		{
			get
			{
				short num = (short)2083192833;
				if (num != 0)
				{
				}
				num = (short)479461376;
				short num2 = num;
				num = (short)787292658;
				short num3 = num;
				num = (short)1208164850;
				switch (num3 == num)
				{
				}
				num = (short)100663296;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDESXLTxRxDefault_A7833._HasDiffs;
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x0011C50C File Offset: 0x0011A70C
		// (set) Token: 0x06001296 RID: 4758 RVA: 0x0011C5C4 File Offset: 0x0011A7C4
		public int TrkSysSecureMultikeyDynamicAGKeySelect_A7914Value
		{
			get
			{
				short num = (short)365592837;
				short num2 = num;
				num = (short)2050720005;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1660616704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2117206016;
				if (num != 0)
				{
				}
				num = (short)65601537;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicAGKeySelect_A7914.Value;
			}
			set
			{
				short num = (short)1563984892;
				short num2 = num;
				num = (short)630686716;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1557266432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1892220928;
				if (num != 0)
				{
				}
				num = (short)264568833;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDynamicAGKeySelect_A7914.Value = value;
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06001297 RID: 4759 RVA: 0x0011C678 File Offset: 0x0011A878
		// (set) Token: 0x06001298 RID: 4760 RVA: 0x0011C72C File Offset: 0x0011A92C
		public string TrkSysSecureMultikeyDynamicAGKeySelect_A7914_UIValue
		{
			get
			{
				short num = (short)437138889;
				short num2 = num;
				num = (short)1562981833;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1116733440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)166985728;
				if (num != 0)
				{
				}
				num = (short)1598423041;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicAGKeySelect_A7914.UIValue;
			}
			set
			{
				short num = (short)274430768;
				short num2 = num;
				num = (short)296450864;
				switch (num2 == num)
				{
				default:
				{
					num = (short)813629440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1981677569;
				if (num != 0)
				{
				}
				num = (short)1133772800;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDynamicAGKeySelect_A7914.UIValue = value;
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06001299 RID: 4761 RVA: 0x0011C7E0 File Offset: 0x0011A9E0
		public global::AcpBusinessLayer.AcpRecRefField TrkSysSecureMultikeyDynamicAGKeySelect_A7914
		{
			get
			{
				short num = (short)123404289;
				if (num != 0)
				{
				}
				num = (short)34537472;
				short num2 = num;
				num = (short)1676840017;
				short num3 = num;
				num = (short)1640074321;
				switch (num3 == num)
				{
				}
				num = (short)1485832192;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicAGKeySelect_A7914;
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x0600129A RID: 4762 RVA: 0x0011C890 File Offset: 0x0011AA90
		// (set) Token: 0x0600129B RID: 4763 RVA: 0x0011C944 File Offset: 0x0011AB44
		public bool TrkSysSecureMultikeyDynamicAGKeySelect_A7914_Applicable
		{
			get
			{
				short num = (short)351768881;
				short num2 = num;
				num = (short)692818225;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1496907776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)163840001;
				if (num != 0)
				{
				}
				num = (short)1464401920;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicAGKeySelect_A7914.Applicable;
			}
			set
			{
				short num = (short)1911208734;
				short num2 = num;
				num = (short)579386142;
				switch (num2 == num)
				{
				default:
				{
					num = (short)164954112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)337772545;
				if (num != 0)
				{
				}
				num = (short)1894842368;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDynamicAGKeySelect_A7914.Applicable = value;
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x0600129C RID: 4764 RVA: 0x0011C9F8 File Offset: 0x0011ABF8
		// (set) Token: 0x0600129D RID: 4765 RVA: 0x0011CAB0 File Offset: 0x0011ACB0
		public bool TrkSysSecureMultikeyDynamicAGKeySelect_A7914_Valid
		{
			get
			{
				short num = (short)140320793;
				short num2 = num;
				num = (short)1500258329;
				switch (num2 == num)
				{
				default:
				{
					num = (short)939720704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)744226816;
				if (num != 0)
				{
				}
				num = (short)1860763649;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicAGKeySelect_A7914.Valid;
			}
			set
			{
				short num = (short)1392755750;
				short num2 = num;
				num = (short)1684587558;
				switch (num2 == num)
				{
				default:
				{
					num = (short)568459264;
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
				num = (short)1709768705;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDynamicAGKeySelect_A7914.Valid = value;
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x0011CB64 File Offset: 0x0011AD64
		// (set) Token: 0x0600129F RID: 4767 RVA: 0x0011CC18 File Offset: 0x0011AE18
		public bool TrkSysSecureMultikeyDynamicAGKeySelect_A7914_Visible
		{
			get
			{
				short num = (short)1381564417;
				if (num != 0)
				{
				}
				num = (short)1471086592;
				short num2 = num;
				num = (short)1940283706;
				short num3 = num;
				num = (short)1164665146;
				switch (num3 == num)
				{
				}
				num = (short)352845824;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicAGKeySelect_A7914.Visible;
			}
			set
			{
				short num = (short)657063937;
				if (num != 0)
				{
				}
				num = (short)332464128;
				short num2 = num;
				num = (short)1024180435;
				short num3 = num;
				num = (short)718192851;
				switch (num3 == num)
				{
				}
				num = (short)542507008;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDynamicAGKeySelect_A7914.Visible = value;
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x060012A0 RID: 4768 RVA: 0x0011CCD0 File Offset: 0x0011AED0
		// (set) Token: 0x060012A1 RID: 4769 RVA: 0x0011CD84 File Offset: 0x0011AF84
		public bool TrkSysSecureMultikeyDynamicAGKeySelect_A7914_Editable
		{
			get
			{
				short num = (short)2117556546;
				short num2 = num;
				num = (short)597645634;
				switch (num2 == num)
				{
				default:
				{
					num = (short)104988672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)463208448;
				if (num != 0)
				{
				}
				num = (short)748617729;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicAGKeySelect_A7914.Editable;
			}
			set
			{
				short num = (short)1213661185;
				if (num != 0)
				{
				}
				num = (short)2016739328;
				short num2 = num;
				num = (short)1393989146;
				short num3 = num;
				num = (short)779982362;
				switch (num3 == num)
				{
				}
				num = (short)1645936640;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDynamicAGKeySelect_A7914.Editable = value;
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x060012A2 RID: 4770 RVA: 0x0011CE3C File Offset: 0x0011B03C
		internal string TrkSysSecureMultikeyDynamicAGKeySelect_A7914_UILabel
		{
			get
			{
				short num = (short)1838359274;
				short num2 = num;
				num = (short)2008163050;
				switch (num2 == num)
				{
				default:
				{
					num = (short)640155648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1452343297;
				if (num != 0)
				{
				}
				num = (short)970326016;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicAGKeySelect_A7914.UIName;
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x060012A3 RID: 4771 RVA: 0x0011CEF0 File Offset: 0x0011B0F0
		// (set) Token: 0x060012A4 RID: 4772 RVA: 0x0011CFA0 File Offset: 0x0011B1A0
		internal bool TrkSysSecureMultikeyDynamicAGKeySelect_A7914_HiddenStatic
		{
			get
			{
				short num = (short)218054168;
				short num2 = num;
				num = (short)1735999000;
				switch (num2 == num)
				{
				default:
				{
					num = (short)343867392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)300351489;
				if (num != 0)
				{
				}
				num = (short)949878784;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicAGKeySelect_A7914.HiddenStatic;
			}
			set
			{
				short num = (short)2102999974;
				short num2 = num;
				num = (short)1737374630;
				switch (num2 == num)
				{
				default:
				{
					num = (short)903217152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)505479169;
				if (num != 0)
				{
				}
				num = (short)216924160;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDynamicAGKeySelect_A7914.HiddenStatic = value;
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x0011D058 File Offset: 0x0011B258
		// (set) Token: 0x060012A6 RID: 4774 RVA: 0x0011D10C File Offset: 0x0011B30C
		internal bool TrkSysSecureMultikeyDynamicAGKeySelect_A7914_HiddenDynamic
		{
			get
			{
				short num = (short)591235519;
				short num2 = num;
				num = (short)1915718079;
				switch (num2 == num)
				{
				default:
				{
					num = (short)268369920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1998127104;
				if (num != 0)
				{
				}
				num = (short)164954113;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicAGKeySelect_A7914.HiddenDynamic;
			}
			set
			{
				short num = (short)1045465178;
				short num2 = num;
				num = (short)182552666;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1816133632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)344915969;
				if (num != 0)
				{
				}
				num = (short)2030370816;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDynamicAGKeySelect_A7914.HiddenDynamic = value;
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x060012A7 RID: 4775 RVA: 0x0011D1C4 File Offset: 0x0011B3C4
		public bool TrkSysSecureMultikeyDynamicAGKeySelect_A7914_HasDiffs
		{
			get
			{
				short num = (short)1572174554;
				short num2 = num;
				num = (short)1021672154;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1788805120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1252261889;
				if (num != 0)
				{
				}
				num = (short)1568210944;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicAGKeySelect_A7914._HasDiffs;
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x0011D278 File Offset: 0x0011B478
		// (set) Token: 0x060012A9 RID: 4777 RVA: 0x0011D32C File Offset: 0x0011B52C
		public int TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918Value
		{
			get
			{
				short num = (short)451368180;
				short num2 = num;
				num = (short)1795511540;
				switch (num2 == num)
				{
				default:
				{
					num = (short)909115392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1437007873;
				if (num != 0)
				{
				}
				num = (short)483262464;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.Value;
			}
			set
			{
				short num = (short)611422858;
				short num2 = num;
				num = (short)477729418;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1177550848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)414646273;
				if (num != 0)
				{
				}
				num = (short)1685716992;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.Value = value;
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x0011D3E0 File Offset: 0x0011B5E0
		// (set) Token: 0x060012AB RID: 4779 RVA: 0x0011D494 File Offset: 0x0011B694
		public string TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918_UIValue
		{
			get
			{
				short num = (short)457499521;
				short num2 = num;
				num = (short)646636417;
				switch (num2 == num)
				{
				default:
				{
					num = (short)32505856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1496580096;
				if (num != 0)
				{
				}
				num = (short)915341313;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.UIValue;
			}
			set
			{
				short num = (short)1857719115;
				short num2 = num;
				num = (short)204311371;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1470562304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1833238529;
				if (num != 0)
				{
				}
				num = (short)1043398656;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.UIValue = value;
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x0011D548 File Offset: 0x0011B748
		public global::AcpBusinessLayer.AcpRecRefField TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918
		{
			get
			{
				short num = (short)1338769409;
				if (num != 0)
				{
				}
				num = (short)333447168;
				short num2 = num;
				num = (short)1060111632;
				short num3 = num;
				num = (short)91686160;
				switch (num3 == num)
				{
				}
				num = (short)1816395776;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918;
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x0011D5F8 File Offset: 0x0011B7F8
		// (set) Token: 0x060012AE RID: 4782 RVA: 0x0011D6B0 File Offset: 0x0011B8B0
		public bool TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918_Applicable
		{
			get
			{
				short num = (short)187701247;
				short num2 = num;
				num = (short)815863807;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1756102656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)200671232;
				if (num != 0)
				{
				}
				num = (short)2094989313;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.Applicable;
			}
			set
			{
				short num = (short)1253016819;
				short num2 = num;
				num = (short)656508147;
				switch (num2 == num)
				{
				}
				num = (short)1213333504;
				short num3 = num;
				num = (short)1634467841;
				if (num != 0)
				{
				}
				num = (short)960233472;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.Applicable = value;
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x060012AF RID: 4783 RVA: 0x0011D768 File Offset: 0x0011B968
		// (set) Token: 0x060012B0 RID: 4784 RVA: 0x0011D81C File Offset: 0x0011BA1C
		public bool TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918_Valid
		{
			get
			{
				short num = (short)1586088521;
				short num2 = num;
				num = (short)1575668297;
				switch (num2 == num)
				{
				}
				num = (short)570556416;
				short num3 = num;
				num = (short)282853377;
				if (num != 0)
				{
				}
				num = (short)564396032;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.Valid;
			}
			set
			{
				short num = (short)1353754874;
				short num2 = num;
				num = (short)126265594;
				switch (num2 == num)
				{
				}
				num = (short)1599078400;
				short num3 = num;
				num = (short)1797521409;
				if (num != 0)
				{
				}
				num = (short)151191552;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.Valid = value;
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x060012B1 RID: 4785 RVA: 0x0011D8D4 File Offset: 0x0011BAD4
		// (set) Token: 0x060012B2 RID: 4786 RVA: 0x0011D988 File Offset: 0x0011BB88
		public bool TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918_Visible
		{
			get
			{
				short num = (short)2019520155;
				short num2 = num;
				num = (short)1651207835;
				switch (num2 == num)
				{
				}
				num = (short)609157120;
				short num3 = num;
				num = (short)1045299201;
				if (num != 0)
				{
				}
				num = (short)1135673344;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.Visible;
			}
			set
			{
				short num = (short)1665408149;
				short num2 = num;
				num = (short)1738480789;
				switch (num2 == num)
				{
				}
				num = (short)849346560;
				short num3 = num;
				num = (short)201129985;
				if (num != 0)
				{
				}
				num = (short)992739328;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.Visible = value;
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x060012B3 RID: 4787 RVA: 0x0011DA3C File Offset: 0x0011BC3C
		// (set) Token: 0x060012B4 RID: 4788 RVA: 0x0011DAF0 File Offset: 0x0011BCF0
		public bool TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918_Editable
		{
			get
			{
				short num = (short)372045852;
				short num2 = num;
				num = (short)671414300;
				switch (num2 == num)
				{
				}
				num = (short)256704512;
				short num3 = num;
				num = (short)106102785;
				if (num != 0)
				{
				}
				num = (short)770506752;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.Editable;
			}
			set
			{
				short num = (short)94527280;
				short num2 = num;
				num = (short)936795952;
				switch (num2 == num)
				{
				}
				num = (short)1143734272;
				short num3 = num;
				num = (short)1375928321;
				if (num != 0)
				{
				}
				num = (short)266141696;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.Editable = value;
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x060012B5 RID: 4789 RVA: 0x0011DBA8 File Offset: 0x0011BDA8
		internal string TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918_UILabel
		{
			get
			{
				short num = (short)910197365;
				short num2 = num;
				num = (short)810386037;
				switch (num2 == num)
				{
				}
				num = (short)1129185280;
				short num3 = num;
				num = (short)1490812928;
				if (num != 0)
				{
				}
				num = (short)455999489;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.UIName;
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x060012B6 RID: 4790 RVA: 0x0011DC5C File Offset: 0x0011BE5C
		// (set) Token: 0x060012B7 RID: 4791 RVA: 0x0011DD14 File Offset: 0x0011BF14
		internal bool TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918_HiddenStatic
		{
			get
			{
				short num = (short)52595880;
				short num2 = num;
				num = (short)1099140264;
				switch (num2 == num)
				{
				}
				num = (short)1350959104;
				short num3 = num;
				num = (short)482869249;
				if (num != 0)
				{
				}
				num = (short)940048384;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.HiddenStatic;
			}
			set
			{
				short num = (short)2084718716;
				short num2 = num;
				num = (short)912279676;
				switch (num2 == num)
				{
				}
				num = (short)278462464;
				short num3 = num;
				num = (short)1403125761;
				if (num != 0)
				{
				}
				num = (short)1857486848;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.HiddenStatic = value;
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x060012B8 RID: 4792 RVA: 0x0011DDCC File Offset: 0x0011BFCC
		// (set) Token: 0x060012B9 RID: 4793 RVA: 0x0011DE80 File Offset: 0x0011C080
		internal bool TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918_HiddenDynamic
		{
			get
			{
				short num = (short)1911296602;
				short num2 = num;
				num = (short)2104693338;
				switch (num2 == num)
				{
				}
				num = (short)1364525056;
				short num3 = num;
				num = (short)1520369665;
				if (num != 0)
				{
				}
				num = (short)1264189440;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.HiddenDynamic;
			}
			set
			{
				short num = (short)1507264198;
				short num2 = num;
				num = (short)657655494;
				switch (num2 == num)
				{
				}
				num = (short)441122816;
				short num3 = num;
				num = (short)1831206913;
				if (num != 0)
				{
				}
				num = (short)771555328;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.HiddenDynamic = value;
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x0011DF38 File Offset: 0x0011C138
		public bool TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918_HasDiffs
		{
			get
			{
				short num = (short)1592588592;
				short num2 = num;
				num = (short)1991506224;
				switch (num2 == num)
				{
				}
				num = (short)1377697792;
				short num3 = num;
				num = (short)1355153408;
				if (num != 0)
				{
				}
				num = (short)1552285697;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918._HasDiffs;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x060012BB RID: 4795 RVA: 0x0011DFEC File Offset: 0x0011C1EC
		// (set) Token: 0x060012BC RID: 4796 RVA: 0x0011E0A0 File Offset: 0x0011C2A0
		public int TrkSysSecureMultikeyFailsoftKeySelect_A8012Value
		{
			get
			{
				short num = (short)1293137364;
				short num2 = num;
				num = (short)2059253204;
				switch (num2 == num)
				{
				}
				num = (short)1339555840;
				short num3 = num;
				num = (short)102825984;
				if (num != 0)
				{
				}
				num = (short)2066284545;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyFailsoftKeySelect_A8012.Value;
			}
			set
			{
				short num = (short)321219541;
				short num2 = num;
				num = (short)1315269589;
				switch (num2 == num)
				{
				}
				num = (short)579207168;
				short num3 = num;
				num = (short)1919614977;
				if (num != 0)
				{
				}
				num = (short)1500643328;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyFailsoftKeySelect_A8012.Value = value;
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x060012BD RID: 4797 RVA: 0x0011E154 File Offset: 0x0011C354
		// (set) Token: 0x060012BE RID: 4798 RVA: 0x0011E208 File Offset: 0x0011C408
		public string TrkSysSecureMultikeyFailsoftKeySelect_A8012_UIValue
		{
			get
			{
				short num = (short)31319118;
				short num2 = num;
				num = (short)1578951758;
				switch (num2 == num)
				{
				}
				num = (short)2094202880;
				short num3 = num;
				num = (short)558628865;
				if (num != 0)
				{
				}
				num = (short)1861746688;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyFailsoftKeySelect_A8012.UIValue;
			}
			set
			{
				short num = (short)789983595;
				short num2 = num;
				num = (short)642134379;
				switch (num2 == num)
				{
				}
				num = (short)1167130624;
				short num3 = num;
				num = (short)984219649;
				if (num != 0)
				{
				}
				num = (short)847380480;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyFailsoftKeySelect_A8012.UIValue = value;
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x060012BF RID: 4799 RVA: 0x0011E2C0 File Offset: 0x0011C4C0
		public global::AcpBusinessLayer.AcpRecRefField TrkSysSecureMultikeyFailsoftKeySelect_A8012
		{
			get
			{
				short num = (short)1410596865;
				if (num != 0)
				{
				}
				num = (short)63382280;
				short num2 = num;
				num = (short)1798447880;
				switch (num2 == num)
				{
				default:
				{
					num = (short)919404544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1632960512;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyFailsoftKeySelect_A8012;
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x060012C0 RID: 4800 RVA: 0x0011E370 File Offset: 0x0011C570
		// (set) Token: 0x060012C1 RID: 4801 RVA: 0x0011E424 File Offset: 0x0011C624
		public bool TrkSysSecureMultikeyFailsoftKeySelect_A8012_Applicable
		{
			get
			{
				short num = (short)971112793;
				short num2 = num;
				num = (short)1041695065;
				switch (num2 == num)
				{
				}
				num = (short)885719040;
				short num3 = num;
				num = (short)1383989249;
				if (num != 0)
				{
				}
				num = (short)1847656448;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyFailsoftKeySelect_A8012.Applicable;
			}
			set
			{
				short num = (short)1432760428;
				short num2 = num;
				num = (short)185217132;
				switch (num2 == num)
				{
				}
				num = (short)1933967360;
				short num3 = num;
				num = (short)1963130881;
				if (num != 0)
				{
				}
				num = (short)1279524864;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyFailsoftKeySelect_A8012.Applicable = value;
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x060012C2 RID: 4802 RVA: 0x0011E4DC File Offset: 0x0011C6DC
		// (set) Token: 0x060012C3 RID: 4803 RVA: 0x0011E590 File Offset: 0x0011C790
		public bool TrkSysSecureMultikeyFailsoftKeySelect_A8012_Valid
		{
			get
			{
				short num = (short)2010382662;
				short num2 = num;
				num = (short)1300300102;
				switch (num2 == num)
				{
				}
				num = (short)1754791936;
				short num3 = num;
				num = (short)1086324737;
				if (num != 0)
				{
				}
				num = (short)811335680;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyFailsoftKeySelect_A8012.Valid;
			}
			set
			{
				short num = (short)1876099073;
				if (num != 0)
				{
				}
				num = (short)783634132;
				short num2 = num;
				num = (short)2076856020;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1933115392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)284753920;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyFailsoftKeySelect_A8012.Valid = value;
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x060012C4 RID: 4804 RVA: 0x0011E644 File Offset: 0x0011C844
		// (set) Token: 0x060012C5 RID: 4805 RVA: 0x0011E6F8 File Offset: 0x0011C8F8
		public bool TrkSysSecureMultikeyFailsoftKeySelect_A8012_Visible
		{
			get
			{
				short num = (short)1000700645;
				short num2 = num;
				num = (short)683113189;
				switch (num2 == num)
				{
				}
				num = (short)1662976000;
				short num3 = num;
				num = (short)206045185;
				if (num != 0)
				{
				}
				num = (short)1478033408;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyFailsoftKeySelect_A8012.Visible;
			}
			set
			{
				short num = (short)501548792;
				short num2 = num;
				num = (short)2109736696;
				switch (num2 == num)
				{
				}
				num = (short)1883504640;
				short num3 = num;
				num = (short)1039204353;
				if (num != 0)
				{
				}
				num = (short)664731648;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyFailsoftKeySelect_A8012.Visible = value;
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x060012C6 RID: 4806 RVA: 0x0011E7AC File Offset: 0x0011C9AC
		// (set) Token: 0x060012C7 RID: 4807 RVA: 0x0011E864 File Offset: 0x0011CA64
		public bool TrkSysSecureMultikeyFailsoftKeySelect_A8012_Editable
		{
			get
			{
				short num = (short)526925319;
				short num2 = num;
				num = (short)1716010503;
				switch (num2 == num)
				{
				}
				num = (short)621543424;
				short num3 = num;
				num = (short)2146369536;
				if (num != 0)
				{
				}
				num = (short)752287745;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyFailsoftKeySelect_A8012.Editable;
			}
			set
			{
				short num = (short)1115291649;
				if (num != 0)
				{
				}
				num = (short)1001921179;
				short num2 = num;
				num = (short)1159535259;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1042546688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)596443136;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyFailsoftKeySelect_A8012.Editable = value;
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x060012C8 RID: 4808 RVA: 0x0011E918 File Offset: 0x0011CB18
		internal string TrkSysSecureMultikeyFailsoftKeySelect_A8012_UILabel
		{
			get
			{
				short num = (short)1136825906;
				short num2 = num;
				num = (short)1074501170;
				switch (num2 == num)
				{
				}
				num = (short)1209860096;
				short num3 = num;
				num = (short)906231809;
				if (num != 0)
				{
				}
				num = (short)1409744896;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyFailsoftKeySelect_A8012.UIName;
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x0011E9CC File Offset: 0x0011CBCC
		// (set) Token: 0x060012CA RID: 4810 RVA: 0x0011EA80 File Offset: 0x0011CC80
		internal bool TrkSysSecureMultikeyFailsoftKeySelect_A8012_HiddenStatic
		{
			get
			{
				short num = (short)1401055181;
				short num2 = num;
				num = (short)1336043469;
				switch (num2 == num)
				{
				}
				num = (short)2012348416;
				short num3 = num;
				num = (short)416350209;
				if (num != 0)
				{
				}
				num = (short)267649024;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyFailsoftKeySelect_A8012.HiddenStatic;
			}
			set
			{
				short num = (short)1123267643;
				short num2 = num;
				num = (short)1739699259;
				switch (num2 == num)
				{
				}
				num = (short)1071316992;
				short num3 = num;
				num = (short)135593984;
				if (num != 0)
				{
				}
				num = (short)61079553;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyFailsoftKeySelect_A8012.HiddenStatic = value;
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x060012CB RID: 4811 RVA: 0x0011EB38 File Offset: 0x0011CD38
		// (set) Token: 0x060012CC RID: 4812 RVA: 0x0011EBEC File Offset: 0x0011CDEC
		internal bool TrkSysSecureMultikeyFailsoftKeySelect_A8012_HiddenDynamic
		{
			get
			{
				short num = (short)2110820200;
				short num2 = num;
				num = (short)954371944;
				switch (num2 == num)
				{
				}
				num = (short)493813760;
				short num3 = num;
				num = (short)1944125441;
				if (num != 0)
				{
				}
				num = (short)974192640;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyFailsoftKeySelect_A8012.HiddenDynamic;
			}
			set
			{
				short num = (short)1306369412;
				short num2 = num;
				num = (short)1200790916;
				switch (num2 == num)
				{
				}
				num = (short)877330432;
				short num3 = num;
				num = (short)1835597825;
				if (num != 0)
				{
				}
				num = (short)624623616;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyFailsoftKeySelect_A8012.HiddenDynamic = value;
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x060012CD RID: 4813 RVA: 0x0011ECA0 File Offset: 0x0011CEA0
		public bool TrkSysSecureMultikeyFailsoftKeySelect_A8012_HasDiffs
		{
			get
			{
				short num = (short)477952176;
				short num2 = num;
				num = (short)1977809072;
				switch (num2 == num)
				{
				}
				num = (short)1756233728;
				short num3 = num;
				num = (short)683540481;
				if (num != 0)
				{
				}
				num = (short)124780544;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyFailsoftKeySelect_A8012._HasDiffs;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x060012CE RID: 4814 RVA: 0x0011ED54 File Offset: 0x0011CF54
		// (set) Token: 0x060012CF RID: 4815 RVA: 0x0011EE0C File Offset: 0x0011D00C
		public int TrkSysSecureMultikeyInterconnectKeySelect_A8298Value
		{
			get
			{
				short num = (short)1502556344;
				short num2 = num;
				num = (short)96022712;
				switch (num2 == num)
				{
				}
				num = (short)1337982976;
				short num3 = num;
				num = (short)274268160;
				if (num != 0)
				{
				}
				num = (short)2075852801;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyInterconnectKeySelect_A8298.Value;
			}
			set
			{
				short num = (short)628581168;
				short num2 = num;
				num = (short)2064737072;
				switch (num2 == num)
				{
				}
				num = (short)884539392;
				short num3 = num;
				num = (short)144900096;
				if (num != 0)
				{
				}
				num = (short)1825636353;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyInterconnectKeySelect_A8298.Value = value;
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x060012D0 RID: 4816 RVA: 0x0011EEC0 File Offset: 0x0011D0C0
		// (set) Token: 0x060012D1 RID: 4817 RVA: 0x0011EF78 File Offset: 0x0011D178
		public string TrkSysSecureMultikeyInterconnectKeySelect_A8298_UIValue
		{
			get
			{
				short num = (short)861931358;
				short num2 = num;
				num = (short)900532062;
				switch (num2 == num)
				{
				}
				num = (short)898301952;
				short num3 = num;
				num = (short)1842806785;
				if (num != 0)
				{
				}
				num = (short)804257792;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyInterconnectKeySelect_A8298.UIValue;
			}
			set
			{
				short num = (short)558628865;
				if (num != 0)
				{
				}
				num = (short)842319591;
				short num2 = num;
				num = (short)679724775;
				switch (num2 == num)
				{
				default:
				{
					num = (short)691994624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)748290048;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyInterconnectKeySelect_A8298.UIValue = value;
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x060012D2 RID: 4818 RVA: 0x0011F02C File Offset: 0x0011D22C
		public global::AcpBusinessLayer.AcpRecRefField TrkSysSecureMultikeyInterconnectKeySelect_A8298
		{
			get
			{
				short num = (short)4395556;
				short num2 = num;
				num = (short)1267012132;
				switch (num2 == num)
				{
				}
				num = (short)1508835328;
				short num3 = num;
				num = (short)1824849920;
				if (num != 0)
				{
				}
				num = (short)1591279617;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyInterconnectKeySelect_A8298;
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x0011F0DC File Offset: 0x0011D2DC
		// (set) Token: 0x060012D4 RID: 4820 RVA: 0x0011F190 File Offset: 0x0011D390
		public bool TrkSysSecureMultikeyInterconnectKeySelect_A8298_Applicable
		{
			get
			{
				short num = (short)1153630209;
				if (num != 0)
				{
				}
				num = (short)1240838525;
				short num2 = num;
				num = (short)1286320509;
				switch (num2 == num)
				{
				default:
				{
					num = (short)7405568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1280835584;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyInterconnectKeySelect_A8298.Applicable;
			}
			set
			{
				short num = (short)619685777;
				short num2 = num;
				num = (short)287877009;
				switch (num2 == num)
				{
				}
				num = (short)757202944;
				short num3 = num;
				num = (short)1108541441;
				if (num != 0)
				{
				}
				num = (short)1724710912;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyInterconnectKeySelect_A8298.Applicable = value;
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x0011F248 File Offset: 0x0011D448
		// (set) Token: 0x060012D6 RID: 4822 RVA: 0x0011F2FC File Offset: 0x0011D4FC
		public bool TrkSysSecureMultikeyInterconnectKeySelect_A8298_Valid
		{
			get
			{
				short num = (short)476735774;
				short num2 = num;
				num = (short)1232627998;
				switch (num2 == num)
				{
				}
				num = (short)511115264;
				short num3 = num;
				num = (short)1295581185;
				if (num != 0)
				{
				}
				num = (short)403505152;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyInterconnectKeySelect_A8298.Valid;
			}
			set
			{
				short num = (short)968057251;
				short num2 = num;
				num = (short)1763140003;
				switch (num2 == num)
				{
				}
				num = (short)343736320;
				short num3 = num;
				num = (short)960495616;
				if (num != 0)
				{
				}
				num = (short)1538260993;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyInterconnectKeySelect_A8298.Valid = value;
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x060012D7 RID: 4823 RVA: 0x0011F3B0 File Offset: 0x0011D5B0
		// (set) Token: 0x060012D8 RID: 4824 RVA: 0x0011F468 File Offset: 0x0011D668
		public bool TrkSysSecureMultikeyInterconnectKeySelect_A8298_Visible
		{
			get
			{
				short num = (short)503185409;
				if (num != 0)
				{
				}
				num = (short)10868428;
				short num2 = num;
				num = (short)1316411084;
				switch (num2 == num)
				{
				default:
				{
					num = (short)82182144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)975568896;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyInterconnectKeySelect_A8298.Visible;
			}
			set
			{
				short num = (short)1325468017;
				short num2 = num;
				num = (short)1833306481;
				switch (num2 == num)
				{
				}
				num = (short)675676160;
				short num3 = num;
				num = (short)1164771329;
				if (num != 0)
				{
				}
				num = (short)860815360;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyInterconnectKeySelect_A8298.Visible = value;
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x060012D9 RID: 4825 RVA: 0x0011F520 File Offset: 0x0011D720
		// (set) Token: 0x060012DA RID: 4826 RVA: 0x0011F5D8 File Offset: 0x0011D7D8
		public bool TrkSysSecureMultikeyInterconnectKeySelect_A8298_Editable
		{
			get
			{
				short num = (short)918683649;
				if (num != 0)
				{
				}
				num = (short)984341102;
				short num2 = num;
				num = (short)1014487662;
				switch (num2 == num)
				{
				default:
				{
					num = (short)948174848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1133182976;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyInterconnectKeySelect_A8298.Editable;
			}
			set
			{
				short num = (short)2045717437;
				short num2 = num;
				num = (short)1013525437;
				switch (num2 == num)
				{
				}
				num = (short)939982848;
				short num3 = num;
				num = (short)1971716096;
				if (num != 0)
				{
				}
				num = (short)1853489153;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyInterconnectKeySelect_A8298.Editable = value;
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x0011F690 File Offset: 0x0011D890
		internal string TrkSysSecureMultikeyInterconnectKeySelect_A8298_UILabel
		{
			get
			{
				short num = (short)587019488;
				short num2 = num;
				num = (short)817509600;
				switch (num2 == num)
				{
				}
				num = (short)356384768;
				if (num != 0)
				{
				}
				num = (short)2096037888;
				short num3 = num;
				num = (short)1461714945;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyInterconnectKeySelect_A8298.UIName;
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x060012DC RID: 4828 RVA: 0x0011F744 File Offset: 0x0011D944
		// (set) Token: 0x060012DD RID: 4829 RVA: 0x0011F7F4 File Offset: 0x0011D9F4
		internal bool TrkSysSecureMultikeyInterconnectKeySelect_A8298_HiddenStatic
		{
			get
			{
				short num = (short)1891405966;
				short num2 = num;
				num = (short)847155342;
				switch (num2 == num)
				{
				}
				num = (short)1530789888;
				if (num != 0)
				{
				}
				num = (short)2007498752;
				short num3 = num;
				num = (short)806944769;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyInterconnectKeySelect_A8298.HiddenStatic;
			}
			set
			{
				short num = (short)567399045;
				short num2 = num;
				num = (short)904057477;
				switch (num2 == num)
				{
				}
				num = (short)1123549185;
				if (num != 0)
				{
				}
				num = (short)610467840;
				short num3 = num;
				num = (short)1119944704;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyInterconnectKeySelect_A8298.HiddenStatic = value;
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x060012DE RID: 4830 RVA: 0x0011F8A8 File Offset: 0x0011DAA8
		// (set) Token: 0x060012DF RID: 4831 RVA: 0x0011F95C File Offset: 0x0011DB5C
		internal bool TrkSysSecureMultikeyInterconnectKeySelect_A8298_HiddenDynamic
		{
			get
			{
				short num = (short)1708457985;
				if (num != 0)
				{
				}
				num = (short)1671499524;
				short num2 = num;
				num = (short)1555500804;
				switch (num2 == num)
				{
				}
				num = (short)1442906112;
				short num3 = num;
				num = (short)753467392;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyInterconnectKeySelect_A8298.HiddenDynamic;
			}
			set
			{
				short num = (short)200634534;
				short num2 = num;
				num = (short)1371107494;
				switch (num2 == num)
				{
				}
				num = (short)758054912;
				if (num != 0)
				{
				}
				num = (short)396099584;
				short num3 = num;
				num = (short)1461714945;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyInterconnectKeySelect_A8298.HiddenDynamic = value;
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x060012E0 RID: 4832 RVA: 0x0011FA10 File Offset: 0x0011DC10
		public bool TrkSysSecureMultikeyInterconnectKeySelect_A8298_HasDiffs
		{
			get
			{
				short num = (short)553607454;
				short num2 = num;
				num = (short)1850958110;
				switch (num2 == num)
				{
				}
				num = (short)1948581888;
				if (num != 0)
				{
				}
				num = (short)1915486208;
				short num3 = num;
				num = (short)584974337;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyInterconnectKeySelect_A8298._HasDiffs;
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x0011FAC4 File Offset: 0x0011DCC4
		// (set) Token: 0x060012E2 RID: 4834 RVA: 0x0011FB78 File Offset: 0x0011DD78
		public int TrkSysSecureMultikeyKMFProfileIndex_A8382Value
		{
			get
			{
				short num = (short)740147320;
				short num2 = num;
				num = (short)1244971128;
				switch (num2 == num)
				{
				}
				num = (short)1022623745;
				if (num != 0)
				{
				}
				num = (short)480575488;
				short num3 = num;
				num = (short)1756102656;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyKMFProfileIndex_A8382.Value;
			}
			set
			{
				short num = (short)1472104946;
				short num2 = num;
				num = (short)1800636914;
				switch (num2 == num)
				{
				}
				num = (short)53215232;
				if (num != 0)
				{
				}
				num = (short)1285881856;
				short num3 = num;
				num = (short)21692417;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyKMFProfileIndex_A8382.Value = value;
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x060012E3 RID: 4835 RVA: 0x0011FC2C File Offset: 0x0011DE2C
		// (set) Token: 0x060012E4 RID: 4836 RVA: 0x0011FCE0 File Offset: 0x0011DEE0
		public string TrkSysSecureMultikeyKMFProfileIndex_A8382_UIValue
		{
			get
			{
				short num = (short)788845732;
				short num2 = num;
				num = (short)61068452;
				switch (num2 == num)
				{
				}
				num = (short)95551489;
				if (num != 0)
				{
				}
				num = (short)351141888;
				short num3 = num;
				num = (short)1657077760;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyKMFProfileIndex_A8382.UIValue;
			}
			set
			{
				short num = (short)1651250873;
				short num2 = num;
				num = (short)1153504953;
				switch (num2 == num)
				{
				}
				num = (short)281935873;
				if (num != 0)
				{
				}
				num = (short)62062592;
				short num3 = num;
				num = (short)1264123904;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyKMFProfileIndex_A8382.UIValue = value;
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x060012E5 RID: 4837 RVA: 0x0011FD94 File Offset: 0x0011DF94
		public global::AcpBusinessLayer.AcpRecRefField TrkSysSecureMultikeyKMFProfileIndex_A8382
		{
			get
			{
				short num = (short)999831070;
				short num2 = num;
				num = (short)807941662;
				switch (num2 == num)
				{
				}
				num = (short)2037645313;
				if (num != 0)
				{
				}
				num = (short)1865875456;
				short num3 = num;
				num = (short)1441792;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyKMFProfileIndex_A8382;
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x060012E6 RID: 4838 RVA: 0x0011FE48 File Offset: 0x0011E048
		// (set) Token: 0x060012E7 RID: 4839 RVA: 0x0011FEFC File Offset: 0x0011E0FC
		public bool TrkSysSecureMultikeyKMFProfileIndex_A8382_Applicable
		{
			get
			{
				short num = (short)1892044644;
				short num2 = num;
				num = (short)750538596;
				switch (num2 == num)
				{
				}
				num = (short)1077805057;
				if (num != 0)
				{
				}
				num = (short)1220280320;
				short num3 = num;
				num = (short)703004672;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyKMFProfileIndex_A8382.Applicable;
			}
			set
			{
				short num = (short)488088066;
				short num2 = num;
				num = (short)1481351682;
				switch (num2 == num)
				{
				}
				num = (short)803536896;
				if (num != 0)
				{
				}
				num = (short)432668672;
				short num3 = num;
				num = (short)422641665;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyKMFProfileIndex_A8382.Applicable = value;
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x060012E8 RID: 4840 RVA: 0x0011FFB4 File Offset: 0x0011E1B4
		// (set) Token: 0x060012E9 RID: 4841 RVA: 0x00120068 File Offset: 0x0011E268
		public bool TrkSysSecureMultikeyKMFProfileIndex_A8382_Valid
		{
			get
			{
				short num = (short)1645031572;
				short num2 = num;
				num = (short)311046292;
				switch (num2 == num)
				{
				}
				num = (short)1829371904;
				if (num != 0)
				{
				}
				num = (short)406323200;
				short num3 = num;
				num = (short)960364545;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyKMFProfileIndex_A8382.Valid;
			}
			set
			{
				short num = (short)997458426;
				short num2 = num;
				num = (short)1291649530;
				switch (num2 == num)
				{
				}
				num = (short)620298241;
				if (num != 0)
				{
				}
				num = (short)871563264;
				short num3 = num;
				num = (short)714473472;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyKMFProfileIndex_A8382.Valid = value;
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x060012EA RID: 4842 RVA: 0x00120120 File Offset: 0x0011E320
		// (set) Token: 0x060012EB RID: 4843 RVA: 0x001201D4 File Offset: 0x0011E3D4
		public bool TrkSysSecureMultikeyKMFProfileIndex_A8382_Visible
		{
			get
			{
				short num = (short)1022779881;
				short num2 = num;
				num = (short)1628201449;
				switch (num2 == num)
				{
				}
				num = (short)2059796480;
				if (num != 0)
				{
				}
				num = (short)909508608;
				short num3 = num;
				num = (short)402980865;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyKMFProfileIndex_A8382.Visible;
			}
			set
			{
				short num = (short)501940225;
				if (num != 0)
				{
				}
				num = (short)809629539;
				short num2 = num;
				num = (short)1005320035;
				switch (num2 == num)
				{
				}
				num = (short)478543872;
				short num3 = num;
				num = (short)1123024896;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyKMFProfileIndex_A8382.Visible = value;
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x060012EC RID: 4844 RVA: 0x00120288 File Offset: 0x0011E488
		// (set) Token: 0x060012ED RID: 4845 RVA: 0x0012033C File Offset: 0x0011E53C
		public bool TrkSysSecureMultikeyKMFProfileIndex_A8382_Editable
		{
			get
			{
				short num = (short)1568525882;
				short num2 = num;
				num = (short)1935330874;
				switch (num2 == num)
				{
				}
				num = (short)2118975488;
				if (num != 0)
				{
				}
				num = (short)1893793792;
				short num3 = num;
				num = (short)1185873921;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyKMFProfileIndex_A8382.Editable;
			}
			set
			{
				short num = (short)1564278079;
				short num2 = num;
				num = (short)1375599935;
				switch (num2 == num)
				{
				}
				num = (short)1652162560;
				if (num != 0)
				{
				}
				num = (short)1691353088;
				short num3 = num;
				num = (short)909312001;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyKMFProfileIndex_A8382.Editable = value;
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x060012EE RID: 4846 RVA: 0x001203F0 File Offset: 0x0011E5F0
		internal string TrkSysSecureMultikeyKMFProfileIndex_A8382_UILabel
		{
			get
			{
				short num = (short)193003521;
				if (num != 0)
				{
				}
				num = (short)276343543;
				short num2 = num;
				num = (short)760326903;
				switch (num2 == num)
				{
				}
				num = (short)1424752640;
				short num3 = num;
				num = (short)542703616;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyKMFProfileIndex_A8382.UIName;
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x001204A0 File Offset: 0x0011E6A0
		// (set) Token: 0x060012F0 RID: 4848 RVA: 0x00120554 File Offset: 0x0011E754
		internal bool TrkSysSecureMultikeyKMFProfileIndex_A8382_HiddenStatic
		{
			get
			{
				short num = (short)587667882;
				short num2 = num;
				num = (short)1037375914;
				switch (num2 == num)
				{
				}
				num = (short)1145372673;
				if (num != 0)
				{
				}
				num = (short)265814016;
				short num3 = num;
				num = (short)1589379072;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyKMFProfileIndex_A8382.HiddenStatic;
			}
			set
			{
				short num = (short)445896205;
				short num2 = num;
				num = (short)1239668237;
				switch (num2 == num)
				{
				}
				num = (short)1967063040;
				if (num != 0)
				{
				}
				num = (short)1028587520;
				short num3 = num;
				num = (short)394002433;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyKMFProfileIndex_A8382.HiddenStatic = value;
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x00120608 File Offset: 0x0011E808
		// (set) Token: 0x060012F2 RID: 4850 RVA: 0x001206BC File Offset: 0x0011E8BC
		internal bool TrkSysSecureMultikeyKMFProfileIndex_A8382_HiddenDynamic
		{
			get
			{
				short num = (short)2051053056;
				short num2 = num;
				num = (short)153064960;
				switch (num2 == num)
				{
				}
				num = (short)984678400;
				if (num != 0)
				{
				}
				num = (short)1864368128;
				short num3 = num;
				num = (short)1493762049;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyKMFProfileIndex_A8382.HiddenDynamic;
			}
			set
			{
				short num = (short)1484631670;
				short num2 = num;
				num = (short)1497542262;
				switch (num2 == num)
				{
				}
				num = (short)1882587137;
				if (num != 0)
				{
				}
				num = (short)219545600;
				short num3 = num;
				num = (short)964886528;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyKMFProfileIndex_A8382.HiddenDynamic = value;
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x00120770 File Offset: 0x0011E970
		public bool TrkSysSecureMultikeyKMFProfileIndex_A8382_HasDiffs
		{
			get
			{
				short num = (short)1805427950;
				short num2 = num;
				num = (short)318678254;
				switch (num2 == num)
				{
				}
				num = (short)1921908737;
				if (num != 0)
				{
				}
				num = (short)1189019648;
				short num3 = num;
				num = (short)1471938560;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyKMFProfileIndex_A8382._HasDiffs;
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x00120824 File Offset: 0x0011EA24
		// (set) Token: 0x060012F5 RID: 4853 RVA: 0x001208D8 File Offset: 0x0011EAD8
		public bool TrkSysSecureMultikeyOTARTx_A8676Value
		{
			get
			{
				short num = (short)1935397418;
				short num2 = num;
				num = (short)640733738;
				switch (num2 == num)
				{
				}
				num = (short)1834418177;
				if (num != 0)
				{
				}
				num = (short)926416896;
				short num3 = num;
				num = (short)1767178240;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyOTARTx_A8676.Value;
			}
			set
			{
				short num = (short)620855278;
				short num2 = num;
				num = (short)124026862;
				switch (num2 == num)
				{
				}
				num = (short)411041793;
				if (num != 0)
				{
				}
				num = (short)381091840;
				short num3 = num;
				num = (short)290521088;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyOTARTx_A8676.Value = value;
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x060012F6 RID: 4854 RVA: 0x0012098C File Offset: 0x0011EB8C
		public global::AcpBusinessLayer.AcpField<bool> TrkSysSecureMultikeyOTARTx_A8676
		{
			get
			{
				short num = (short)1080392567;
				short num2 = num;
				num = (short)732199799;
				switch (num2 == num)
				{
				}
				num = (short)2089484289;
				if (num != 0)
				{
				}
				num = (short)2142699520;
				short num3 = num;
				num = (short)464781312;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyOTARTx_A8676;
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x00120A3C File Offset: 0x0011EC3C
		// (set) Token: 0x060012F8 RID: 4856 RVA: 0x00120AF0 File Offset: 0x0011ECF0
		public bool TrkSysSecureMultikeyOTARTx_A8676_UIValue
		{
			get
			{
				short num = (short)2085355521;
				if (num != 0)
				{
				}
				num = (short)831166523;
				short num2 = num;
				num = (short)930322491;
				switch (num2 == num)
				{
				}
				num = (short)1459355648;
				short num3 = num;
				num = (short)1567555584;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyOTARTx_A8676.Value;
			}
			set
			{
				short num = (short)1093390024;
				short num2 = num;
				num = (short)1541525192;
				switch (num2 == num)
				{
				}
				num = (short)1363214337;
				if (num != 0)
				{
				}
				num = (short)569442304;
				short num3 = num;
				num = (short)106758144;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyOTARTx_A8676.Value = value;
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x00120BA4 File Offset: 0x0011EDA4
		// (set) Token: 0x060012FA RID: 4858 RVA: 0x00120C5C File Offset: 0x0011EE5C
		public bool TrkSysSecureMultikeyOTARTx_A8676_Applicable
		{
			get
			{
				short num = (short)1475619449;
				short num2 = num;
				num = (short)782183033;
				switch (num2 == num)
				{
				}
				num = (short)29753345;
				if (num != 0)
				{
				}
				num = (short)1134821376;
				short num3 = num;
				num = (short)1381761024;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyOTARTx_A8676.Applicable;
			}
			set
			{
				short num = (short)1111573858;
				short num2 = num;
				num = (short)1842496866;
				switch (num2 == num)
				{
				}
				num = (short)1273364481;
				if (num != 0)
				{
				}
				num = (short)1946812416;
				short num3 = num;
				num = (short)1746927616;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyOTARTx_A8676.Applicable = value;
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x00120D10 File Offset: 0x0011EF10
		// (set) Token: 0x060012FC RID: 4860 RVA: 0x00120DC8 File Offset: 0x0011EFC8
		public bool TrkSysSecureMultikeyOTARTx_A8676_Valid
		{
			get
			{
				short num = (short)702324854;
				short num2 = num;
				num = (short)1347788918;
				switch (num2 == num)
				{
				}
				num = (short)26083329;
				if (num != 0)
				{
				}
				num = (short)1877540864;
				short num3 = num;
				num = (short)189988864;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyOTARTx_A8676.Valid;
			}
			set
			{
				short num = (short)24435514;
				short num2 = num;
				num = (short)88660794;
				switch (num2 == num)
				{
				}
				num = (short)1826553857;
				if (num != 0)
				{
				}
				num = (short)1213136896;
				short num3 = num;
				num = (short)444661760;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyOTARTx_A8676.Valid = value;
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x00120E7C File Offset: 0x0011F07C
		// (set) Token: 0x060012FE RID: 4862 RVA: 0x00120F34 File Offset: 0x0011F134
		public bool TrkSysSecureMultikeyOTARTx_A8676_Visible
		{
			get
			{
				short num = (short)182714369;
				if (num != 0)
				{
				}
				num = (short)313854246;
				short num2 = num;
				num = (short)300747046;
				switch (num2 == num)
				{
				}
				num = (short)1069678592;
				short num3 = num;
				num = (short)1070006272;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyOTARTx_A8676.Visible;
			}
			set
			{
				short num = (short)2028863489;
				if (num != 0)
				{
				}
				num = (short)1336379916;
				short num2 = num;
				num = (short)2132969996;
				switch (num2 == num)
				{
				}
				num = (short)1239613440;
				short num3 = num;
				num = (short)538574848;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyOTARTx_A8676.Visible = value;
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x00120FE8 File Offset: 0x0011F1E8
		// (set) Token: 0x06001300 RID: 4864 RVA: 0x00121098 File Offset: 0x0011F298
		public bool TrkSysSecureMultikeyOTARTx_A8676_Editable
		{
			get
			{
				short num = (short)713016237;
				short num2 = num;
				num = (short)405455789;
				switch (num2 == num)
				{
				}
				num = (short)162988032;
				if (num != 0)
				{
				}
				num = (short)364642304;
				short num3 = num;
				num = (short)1240662017;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyOTARTx_A8676.Editable;
			}
			set
			{
				short num = (short)1235179721;
				short num2 = num;
				num = (short)1961580745;
				switch (num2 == num)
				{
				}
				num = (short)327090177;
				if (num != 0)
				{
				}
				num = (short)488243200;
				short num3 = num;
				num = (short)232587264;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyOTARTx_A8676.Editable = value;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06001301 RID: 4865 RVA: 0x0012114C File Offset: 0x0011F34C
		internal string TrkSysSecureMultikeyOTARTx_A8676_UILabel
		{
			get
			{
				short num = (short)1539785621;
				short num2 = num;
				num = (short)1304642453;
				switch (num2 == num)
				{
				}
				num = (short)327548928;
				if (num != 0)
				{
				}
				num = (short)1806172160;
				short num3 = num;
				num = (short)1007353857;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyOTARTx_A8676.UIName;
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x00121200 File Offset: 0x0011F400
		// (set) Token: 0x06001303 RID: 4867 RVA: 0x001212B8 File Offset: 0x0011F4B8
		internal bool TrkSysSecureMultikeyOTARTx_A8676_HiddenStatic
		{
			get
			{
				short num = (short)1897672265;
				short num2 = num;
				num = (short)366489161;
				switch (num2 == num)
				{
				}
				num = (short)616824832;
				if (num != 0)
				{
				}
				num = (short)1048772608;
				short num3 = num;
				num = (short)781385729;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyOTARTx_A8676.HiddenStatic;
			}
			set
			{
				short num = (short)1116069131;
				short num2 = num;
				num = (short)660725003;
				switch (num2 == num)
				{
				}
				num = (short)1800077313;
				if (num != 0)
				{
				}
				num = (short)394919936;
				short num3 = num;
				num = (short)1178599424;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyOTARTx_A8676.HiddenStatic = value;
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06001304 RID: 4868 RVA: 0x00121370 File Offset: 0x0011F570
		// (set) Token: 0x06001305 RID: 4869 RVA: 0x00121428 File Offset: 0x0011F628
		internal bool TrkSysSecureMultikeyOTARTx_A8676_HiddenDynamic
		{
			get
			{
				short num = (short)1390833342;
				short num2 = num;
				num = (short)1182625470;
				switch (num2 == num)
				{
				}
				num = (short)400162817;
				if (num != 0)
				{
				}
				num = (short)898564096;
				short num3 = num;
				num = (short)428802048;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyOTARTx_A8676.HiddenDynamic;
			}
			set
			{
				short num = (short)1552154625;
				if (num != 0)
				{
				}
				num = (short)753949715;
				short num2 = num;
				num = (short)1919769619;
				switch (num2 == num)
				{
				}
				num = (short)1423572992;
				short num3 = num;
				num = (short)549060608;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyOTARTx_A8676.HiddenDynamic = value;
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x001214DC File Offset: 0x0011F6DC
		public bool TrkSysSecureMultikeyOTARTx_A8676_HasDiffs
		{
			get
			{
				short num = (short)644566135;
				short num2 = num;
				num = (short)1865174135;
				switch (num2 == num)
				{
				}
				num = (short)1242693633;
				if (num != 0)
				{
				}
				num = (short)699138048;
				short num3 = num;
				num = (short)887488512;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyOTARTx_A8676._HasDiffs;
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06001307 RID: 4871 RVA: 0x00121590 File Offset: 0x0011F790
		// (set) Token: 0x06001308 RID: 4872 RVA: 0x00121644 File Offset: 0x0011F844
		public int TrkSysSecureMultikeyPatchKeySelect_A8694Value
		{
			get
			{
				short num = (short)1325257023;
				short num2 = num;
				num = (short)1054331199;
				switch (num2 == num)
				{
				}
				num = (short)790560768;
				if (num != 0)
				{
				}
				num = (short)1914503168;
				short num3 = num;
				num = (short)781713409;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyPatchKeySelect_A8694.Value;
			}
			set
			{
				short num = (short)2072934275;
				short num2 = num;
				num = (short)1515288451;
				switch (num2 == num)
				{
				}
				num = (short)927531009;
				if (num != 0)
				{
				}
				num = (short)2039545856;
				short num3 = num;
				num = (short)878641152;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyPatchKeySelect_A8694.Value = value;
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x001216F8 File Offset: 0x0011F8F8
		// (set) Token: 0x0600130A RID: 4874 RVA: 0x001217AC File Offset: 0x0011F9AC
		public string TrkSysSecureMultikeyPatchKeySelect_A8694_UIValue
		{
			get
			{
				short num = (short)1086586881;
				if (num != 0)
				{
				}
				num = (short)515993633;
				short num2 = num;
				num = (short)463761441;
				switch (num2 == num)
				{
				}
				num = (short)1688535040;
				short num3 = num;
				num = (short)1569718272;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyPatchKeySelect_A8694.UIValue;
			}
			set
			{
				short num = (short)1939308776;
				short num2 = num;
				num = (short)1712947432;
				switch (num2 == num)
				{
				}
				num = (short)1402601473;
				if (num != 0)
				{
				}
				num = (short)1359806464;
				short num3 = num;
				num = (short)1821442048;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyPatchKeySelect_A8694.UIValue = value;
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x0600130B RID: 4875 RVA: 0x00121860 File Offset: 0x0011FA60
		public global::AcpBusinessLayer.AcpRecRefField TrkSysSecureMultikeyPatchKeySelect_A8694
		{
			get
			{
				short num = (short)1674510337;
				if (num != 0)
				{
				}
				num = (short)1881908630;
				short num2 = num;
				num = (short)814720406;
				switch (num2 == num)
				{
				}
				num = (short)718929920;
				short num3 = num;
				num = (short)1470627840;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyPatchKeySelect_A8694;
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x0012190C File Offset: 0x0011FB0C
		// (set) Token: 0x0600130D RID: 4877 RVA: 0x001219C4 File Offset: 0x0011FBC4
		public bool TrkSysSecureMultikeyPatchKeySelect_A8694_Applicable
		{
			get
			{
				short num = (short)1591478069;
				short num2 = num;
				num = (short)1776289589;
				switch (num2 == num)
				{
				}
				num = (short)354484225;
				if (num != 0)
				{
				}
				num = (short)753729536;
				short num3 = num;
				num = (short)925368320;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyPatchKeySelect_A8694.Applicable;
			}
			set
			{
				short num = (short)519006783;
				short num2 = num;
				num = (short)43870783;
				switch (num2 == num)
				{
				}
				num = (short)489947137;
				if (num != 0)
				{
				}
				num = (short)1568538624;
				short num3 = num;
				num = (short)1577975808;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyPatchKeySelect_A8694.Applicable = value;
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x0600130E RID: 4878 RVA: 0x00121A78 File Offset: 0x0011FC78
		// (set) Token: 0x0600130F RID: 4879 RVA: 0x00121B2C File Offset: 0x0011FD2C
		public bool TrkSysSecureMultikeyPatchKeySelect_A8694_Valid
		{
			get
			{
				short num = (short)1129250817;
				if (num != 0)
				{
				}
				num = (short)1872955538;
				short num2 = num;
				num = (short)1471809682;
				switch (num2 == num)
				{
				}
				num = (short)248119296;
				short num3 = num;
				num = (short)1886322688;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyPatchKeySelect_A8694.Valid;
			}
			set
			{
				short num = (short)1917979698;
				short num2 = num;
				num = (short)328404018;
				switch (num2 == num)
				{
				}
				num = (short)476643328;
				if (num != 0)
				{
				}
				num = (short)1019936768;
				short num3 = num;
				num = (short)925237249;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyPatchKeySelect_A8694.Valid = value;
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06001310 RID: 4880 RVA: 0x00121BE0 File Offset: 0x0011FDE0
		// (set) Token: 0x06001311 RID: 4881 RVA: 0x00121C94 File Offset: 0x0011FE94
		public bool TrkSysSecureMultikeyPatchKeySelect_A8694_Visible
		{
			get
			{
				short num = (short)86114305;
				if (num != 0)
				{
				}
				num = (short)1365716854;
				short num2 = num;
				num = (short)60698486;
				switch (num2 == num)
				{
				}
				num = (short)1336737792;
				short num3 = num;
				num = (short)1278476288;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyPatchKeySelect_A8694.Visible;
			}
			set
			{
				short num = (short)1502941715;
				short num2 = num;
				num = (short)435491347;
				switch (num2 == num)
				{
				}
				num = (short)1893793793;
				if (num != 0)
				{
				}
				num = (short)69402624;
				short num3 = num;
				num = (short)565248000;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyPatchKeySelect_A8694.Visible = value;
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06001312 RID: 4882 RVA: 0x00121D48 File Offset: 0x0011FF48
		// (set) Token: 0x06001313 RID: 4883 RVA: 0x00121DFC File Offset: 0x0011FFFC
		public bool TrkSysSecureMultikeyPatchKeySelect_A8694_Editable
		{
			get
			{
				short num = (short)783900370;
				short num2 = num;
				num = (short)266690258;
				switch (num2 == num)
				{
				}
				num = (short)629669888;
				if (num != 0)
				{
				}
				num = (short)999227392;
				short num3 = num;
				num = (short)474611713;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyPatchKeySelect_A8694.Editable;
			}
			set
			{
				short num = (short)1623128718;
				short num2 = num;
				num = (short)2117991054;
				switch (num2 == num)
				{
				}
				num = (short)1626210304;
				if (num != 0)
				{
				}
				num = (short)1884094464;
				short num3 = num;
				num = (short)1224671233;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyPatchKeySelect_A8694.Editable = value;
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06001314 RID: 4884 RVA: 0x00121EB0 File Offset: 0x001200B0
		internal string TrkSysSecureMultikeyPatchKeySelect_A8694_UILabel
		{
			get
			{
				short num = (short)1114243073;
				if (num != 0)
				{
				}
				num = (short)1550394382;
				short num2 = num;
				num = (short)30352398;
				switch (num2 == num)
				{
				}
				num = (short)198574080;
				short num3 = num;
				num = (short)401801216;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyPatchKeySelect_A8694.UIName;
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06001315 RID: 4885 RVA: 0x00121F68 File Offset: 0x00120168
		// (set) Token: 0x06001316 RID: 4886 RVA: 0x00122020 File Offset: 0x00120220
		internal bool TrkSysSecureMultikeyPatchKeySelect_A8694_HiddenStatic
		{
			get
			{
				short num = (short)1300195861;
				short num2 = num;
				num = (short)883714581;
				switch (num2 == num)
				{
				}
				num = (short)1202061313;
				if (num != 0)
				{
				}
				num = (short)2094792704;
				short num3 = num;
				num = (short)12189696;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyPatchKeySelect_A8694.HiddenStatic;
			}
			set
			{
				short num = (short)1489608316;
				short num2 = num;
				num = (short)1515757180;
				switch (num2 == num)
				{
				}
				num = (short)990314497;
				if (num != 0)
				{
				}
				num = (short)1739849728;
				short num3 = num;
				num = (short)1261699072;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyPatchKeySelect_A8694.HiddenStatic = value;
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06001317 RID: 4887 RVA: 0x001220D4 File Offset: 0x001202D4
		// (set) Token: 0x06001318 RID: 4888 RVA: 0x00122188 File Offset: 0x00120388
		internal bool TrkSysSecureMultikeyPatchKeySelect_A8694_HiddenDynamic
		{
			get
			{
				short num = (short)465756464;
				short num2 = num;
				num = (short)915923248;
				switch (num2 == num)
				{
				}
				num = (short)1669136385;
				if (num != 0)
				{
				}
				num = (short)789381120;
				short num3 = num;
				num = (short)1928396800;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyPatchKeySelect_A8694.HiddenDynamic;
			}
			set
			{
				short num = (short)2030716161;
				short num2 = num;
				num = (short)268911873;
				switch (num2 == num)
				{
				}
				num = (short)1021181952;
				if (num != 0)
				{
				}
				num = (short)256835584;
				short num3 = num;
				num = (short)2146172929;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyPatchKeySelect_A8694.HiddenDynamic = value;
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06001319 RID: 4889 RVA: 0x00122240 File Offset: 0x00120440
		public bool TrkSysSecureMultikeyPatchKeySelect_A8694_HasDiffs
		{
			get
			{
				short num = (short)364507574;
				short num2 = num;
				num = (short)135786934;
				switch (num2 == num)
				{
				}
				num = (short)1990459392;
				if (num != 0)
				{
				}
				num = (short)855179264;
				short num3 = num;
				num = (short)604700673;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyPatchKeySelect_A8694._HasDiffs;
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x0600131A RID: 4890 RVA: 0x001222F4 File Offset: 0x001204F4
		// (set) Token: 0x0600131B RID: 4891 RVA: 0x001223A8 File Offset: 0x001205A8
		public int TrkSysSecureMultikeyPrivateCallKeySelect_A8757Value
		{
			get
			{
				short num = (short)820577755;
				short num2 = num;
				num = (short)1835599323;
				switch (num2 == num)
				{
				}
				num = (short)1611333632;
				if (num != 0)
				{
				}
				num = (short)944504832;
				short num3 = num;
				num = (short)1594753025;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyPrivateCallKeySelect_A8757.Value;
			}
			set
			{
				short num = (short)897379391;
				short num2 = num;
				num = (short)925166655;
				switch (num2 == num)
				{
				}
				num = (short)1276641281;
				if (num != 0)
				{
				}
				num = (short)683016192;
				short num3 = num;
				num = (short)1127022592;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyPrivateCallKeySelect_A8757.Value = value;
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x0600131C RID: 4892 RVA: 0x0012245C File Offset: 0x0012065C
		// (set) Token: 0x0600131D RID: 4893 RVA: 0x00122510 File Offset: 0x00120710
		public string TrkSysSecureMultikeyPrivateCallKeySelect_A8757_UIValue
		{
			get
			{
				short num = (short)690745532;
				short num2 = num;
				num = (short)1338110140;
				switch (num2 == num)
				{
				}
				num = (short)1742012417;
				if (num != 0)
				{
				}
				num = (short)358285312;
				short num3 = num;
				num = (short)1786511360;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyPrivateCallKeySelect_A8757.UIValue;
			}
			set
			{
				short num = (short)738635501;
				short num2 = num;
				num = (short)1221897965;
				switch (num2 == num)
				{
				}
				num = (short)2016608256;
				if (num != 0)
				{
				}
				num = (short)1376911360;
				short num3 = num;
				num = (short)636485633;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyPrivateCallKeySelect_A8757.UIValue = value;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x0600131E RID: 4894 RVA: 0x001225C4 File Offset: 0x001207C4
		public global::AcpBusinessLayer.AcpRecRefField TrkSysSecureMultikeyPrivateCallKeySelect_A8757
		{
			get
			{
				short num = (short)1595328199;
				short num2 = num;
				num = (short)1849018055;
				switch (num2 == num)
				{
				}
				num = (short)415498241;
				if (num != 0)
				{
				}
				num = (short)115408896;
				short num3 = num;
				num = (short)1208483840;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyPrivateCallKeySelect_A8757;
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x0600131F RID: 4895 RVA: 0x00122670 File Offset: 0x00120870
		// (set) Token: 0x06001320 RID: 4896 RVA: 0x00122728 File Offset: 0x00120928
		public bool TrkSysSecureMultikeyPrivateCallKeySelect_A8757_Applicable
		{
			get
			{
				short num = (short)318973805;
				short num2 = num;
				num = (short)1959602029;
				switch (num2 == num)
				{
				}
				num = (short)2023030785;
				if (num != 0)
				{
				}
				num = (short)1025310720;
				short num3 = num;
				num = (short)2037972992;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyPrivateCallKeySelect_A8757.Applicable;
			}
			set
			{
				short num = (short)2013624301;
				short num2 = num;
				num = (short)2001631213;
				switch (num2 == num)
				{
				}
				num = (short)251002881;
				if (num != 0)
				{
				}
				num = (short)1022623744;
				short num3 = num;
				num = (short)2069889024;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyPrivateCallKeySelect_A8757.Applicable = value;
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06001321 RID: 4897 RVA: 0x001227DC File Offset: 0x001209DC
		// (set) Token: 0x06001322 RID: 4898 RVA: 0x00122890 File Offset: 0x00120A90
		public bool TrkSysSecureMultikeyPrivateCallKeySelect_A8757_Valid
		{
			get
			{
				short num = (short)798490625;
				if (num != 0)
				{
				}
				num = (short)173579835;
				short num2 = num;
				num = (short)129146427;
				switch (num2 == num)
				{
				}
				num = (short)720109568;
				short num3 = num;
				num = (short)183304192;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyPrivateCallKeySelect_A8757.Valid;
			}
			set
			{
				short num = (short)259563162;
				short num2 = num;
				num = (short)2006621850;
				switch (num2 == num)
				{
				}
				num = (short)268697600;
				if (num != 0)
				{
				}
				num = (short)1294204928;
				short num3 = num;
				num = (short)1893466113;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyPrivateCallKeySelect_A8757.Valid = value;
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06001323 RID: 4899 RVA: 0x00122948 File Offset: 0x00120B48
		// (set) Token: 0x06001324 RID: 4900 RVA: 0x001229FC File Offset: 0x00120BFC
		public bool TrkSysSecureMultikeyPrivateCallKeySelect_A8757_Visible
		{
			get
			{
				short num = (short)1596456961;
				if (num != 0)
				{
				}
				num = (short)1824098980;
				short num2 = num;
				num = (short)1136429732;
				switch (num2 == num)
				{
				}
				num = (short)886964224;
				short num3 = num;
				num = (short)1952382976;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyPrivateCallKeySelect_A8757.Visible;
			}
			set
			{
				short num = (short)1211485942;
				short num2 = num;
				num = (short)1864748790;
				switch (num2 == num)
				{
				}
				num = (short)1910439936;
				if (num != 0)
				{
				}
				num = (short)368246784;
				short num3 = num;
				num = (short)599719937;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyPrivateCallKeySelect_A8757.Visible = value;
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06001325 RID: 4901 RVA: 0x00122AB4 File Offset: 0x00120CB4
		// (set) Token: 0x06001326 RID: 4902 RVA: 0x00122B68 File Offset: 0x00120D68
		public bool TrkSysSecureMultikeyPrivateCallKeySelect_A8757_Editable
		{
			get
			{
				short num = (short)542559724;
				short num2 = num;
				num = (short)1431490028;
				switch (num2 == num)
				{
				}
				num = (short)1980497921;
				if (num != 0)
				{
				}
				num = (short)152567808;
				short num3 = num;
				num = (short)1409613824;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyPrivateCallKeySelect_A8757.Editable;
			}
			set
			{
				short num = (short)464235243;
				short num2 = num;
				num = (short)798141163;
				switch (num2 == num)
				{
				}
				num = (short)1522663425;
				if (num != 0)
				{
				}
				num = (short)916717568;
				short num3 = num;
				num = (short)874315776;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyPrivateCallKeySelect_A8757.Editable = value;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06001327 RID: 4903 RVA: 0x00122C1C File Offset: 0x00120E1C
		internal string TrkSysSecureMultikeyPrivateCallKeySelect_A8757_UILabel
		{
			get
			{
				short num = (short)1357412858;
				short num2 = num;
				num = (short)450394618;
				switch (num2 == num)
				{
				}
				num = (short)1059061761;
				if (num != 0)
				{
				}
				num = (short)103874560;
				short num3 = num;
				num = (short)1429143552;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyPrivateCallKeySelect_A8757.UIName;
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06001328 RID: 4904 RVA: 0x00122CD0 File Offset: 0x00120ED0
		// (set) Token: 0x06001329 RID: 4905 RVA: 0x00122D84 File Offset: 0x00120F84
		internal bool TrkSysSecureMultikeyPrivateCallKeySelect_A8757_HiddenStatic
		{
			get
			{
				short num = (short)618088840;
				short num2 = num;
				num = (short)527124872;
				switch (num2 == num)
				{
				}
				num = (short)1197998081;
				if (num != 0)
				{
				}
				num = (short)1072431104;
				short num3 = num;
				num = (short)855965696;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyPrivateCallKeySelect_A8757.HiddenStatic;
			}
			set
			{
				short num = (short)1525734711;
				short num2 = num;
				num = (short)1417338167;
				switch (num2 == num)
				{
				}
				num = (short)1015283712;
				if (num != 0)
				{
				}
				num = (short)248709120;
				short num3 = num;
				num = (short)1593638913;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyPrivateCallKeySelect_A8757.HiddenStatic = value;
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x0600132A RID: 4906 RVA: 0x00122E38 File Offset: 0x00121038
		// (set) Token: 0x0600132B RID: 4907 RVA: 0x00122EF0 File Offset: 0x001210F0
		internal bool TrkSysSecureMultikeyPrivateCallKeySelect_A8757_HiddenDynamic
		{
			get
			{
				short num = (short)139395073;
				if (num != 0)
				{
				}
				num = (short)539045227;
				short num2 = num;
				num = (short)1568419179;
				switch (num2 == num)
				{
				}
				num = (short)1228013568;
				short num3 = num;
				num = (short)836960256;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyPrivateCallKeySelect_A8757.HiddenDynamic;
			}
			set
			{
				short num = (short)1575510536;
				short num2 = num;
				num = (short)239231496;
				switch (num2 == num)
				{
				}
				num = (short)788070401;
				if (num != 0)
				{
				}
				num = (short)2092171264;
				short num3 = num;
				num = (short)1173422080;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyPrivateCallKeySelect_A8757.HiddenDynamic = value;
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x00122FA8 File Offset: 0x001211A8
		public bool TrkSysSecureMultikeyPrivateCallKeySelect_A8757_HasDiffs
		{
			get
			{
				short num = (short)570752773;
				short num2 = num;
				num = (short)1511456517;
				switch (num2 == num)
				{
				}
				num = (short)1080098817;
				if (num != 0)
				{
				}
				num = (short)1180827648;
				short num3 = num;
				num = (short)384040960;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyPrivateCallKeySelect_A8757._HasDiffs;
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x00123060 File Offset: 0x00121260
		// (set) Token: 0x0600132E RID: 4910 RVA: 0x00123114 File Offset: 0x00121314
		public int TrkSysSecureMultikeySystemWideKeySelect_A9253Value
		{
			get
			{
				short num = (short)1470617056;
				short num2 = num;
				num = (short)1247991264;
				switch (num2 == num)
				{
				}
				num = (short)1268056065;
				if (num != 0)
				{
				}
				num = (short)625147904;
				short num3 = num;
				num = (short)1130102784;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeySystemWideKeySelect_A9253.Value;
			}
			set
			{
				short num = (short)382439686;
				short num2 = num;
				num = (short)583241990;
				switch (num2 == num)
				{
				}
				num = (short)147193857;
				if (num != 0)
				{
				}
				num = (short)796000256;
				short num3 = num;
				num = (short)591265792;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeySystemWideKeySelect_A9253.Value = value;
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x001231CC File Offset: 0x001213CC
		// (set) Token: 0x06001330 RID: 4912 RVA: 0x00123280 File Offset: 0x00121480
		public string TrkSysSecureMultikeySystemWideKeySelect_A9253_UIValue
		{
			get
			{
				short num = (short)894828545;
				if (num != 0)
				{
				}
				num = (short)1264477321;
				short num2 = num;
				num = (short)858612873;
				switch (num2 == num)
				{
				}
				num = (short)1687420928;
				short num3 = num;
				num = (short)1302528000;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeySystemWideKeySelect_A9253.UIValue;
			}
			set
			{
				short num = (short)791478273;
				if (num != 0)
				{
				}
				num = (short)2025660902;
				short num2 = num;
				num = (short)1728455142;
				switch (num2 == num)
				{
				}
				num = (short)478937088;
				short num3 = num;
				num = (short)703332352;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeySystemWideKeySelect_A9253.UIValue = value;
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x00123338 File Offset: 0x00121538
		public global::AcpBusinessLayer.AcpRecRefField TrkSysSecureMultikeySystemWideKeySelect_A9253
		{
			get
			{
				short num = (short)1396128048;
				short num2 = num;
				num = (short)663501104;
				switch (num2 == num)
				{
				}
				num = (short)715522049;
				if (num != 0)
				{
				}
				num = (short)307363840;
				short num3 = num;
				num = (short)354549760;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeySystemWideKeySelect_A9253;
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x001233E8 File Offset: 0x001215E8
		// (set) Token: 0x06001333 RID: 4915 RVA: 0x0012349C File Offset: 0x0012169C
		public bool TrkSysSecureMultikeySystemWideKeySelect_A9253_Applicable
		{
			get
			{
				short num = (short)1186754815;
				short num2 = num;
				num = (short)759001343;
				switch (num2 == num)
				{
				}
				num = (short)2065170433;
				if (num != 0)
				{
				}
				num = (short)1112145920;
				short num3 = num;
				num = (short)1548746752;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeySystemWideKeySelect_A9253.Applicable;
			}
			set
			{
				short num = (short)259246374;
				short num2 = num;
				num = (short)1833158950;
				switch (num2 == num)
				{
				}
				num = (short)1413021696;
				if (num != 0)
				{
				}
				num = (short)401080320;
				short num3 = num;
				num = (short)1364393985;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeySystemWideKeySelect_A9253.Applicable = value;
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x00123554 File Offset: 0x00121754
		// (set) Token: 0x06001335 RID: 4917 RVA: 0x0012360C File Offset: 0x0012180C
		public bool TrkSysSecureMultikeySystemWideKeySelect_A9253_Valid
		{
			get
			{
				short num = (short)1425670145;
				if (num != 0)
				{
				}
				num = (short)593865300;
				short num2 = num;
				num = (short)1038658132;
				switch (num2 == num)
				{
				}
				num = (short)442826752;
				short num3 = num;
				num = (short)1660289024;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeySystemWideKeySelect_A9253.Valid;
			}
			set
			{
				short num = (short)1536855934;
				short num2 = num;
				num = (short)1954385790;
				switch (num2 == num)
				{
				}
				num = (short)551747585;
				if (num != 0)
				{
				}
				num = (short)447938560;
				short num3 = num;
				num = (short)81854464;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeySystemWideKeySelect_A9253.Valid = value;
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x001236C0 File Offset: 0x001218C0
		// (set) Token: 0x06001337 RID: 4919 RVA: 0x00123774 File Offset: 0x00121974
		public bool TrkSysSecureMultikeySystemWideKeySelect_A9253_Visible
		{
			get
			{
				short num = (short)1844879263;
				short num2 = num;
				num = (short)27238303;
				switch (num2 == num)
				{
				}
				num = (short)1874526208;
				if (num != 0)
				{
				}
				num = (short)1783365632;
				short num3 = num;
				num = (short)989069313;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeySystemWideKeySelect_A9253.Visible;
			}
			set
			{
				short num = (short)972418739;
				short num2 = num;
				num = (short)1451093683;
				switch (num2 == num)
				{
				}
				num = (short)974061568;
				if (num != 0)
				{
				}
				num = (short)788463616;
				short num3 = num;
				num = (short)1732247553;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeySystemWideKeySelect_A9253.Visible = value;
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06001338 RID: 4920 RVA: 0x00123830 File Offset: 0x00121A30
		// (set) Token: 0x06001339 RID: 4921 RVA: 0x001238E4 File Offset: 0x00121AE4
		public bool TrkSysSecureMultikeySystemWideKeySelect_A9253_Editable
		{
			get
			{
				short num = (short)2013898009;
				short num2 = num;
				num = (short)371369241;
				switch (num2 == num)
				{
				}
				num = (short)1963982849;
				if (num != 0)
				{
				}
				num = (short)619577344;
				short num3 = num;
				num = (short)1579941888;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeySystemWideKeySelect_A9253.Editable;
			}
			set
			{
				short num = (short)341134617;
				short num2 = num;
				num = (short)25513241;
				switch (num2 == num)
				{
				}
				num = (short)1183711233;
				if (num != 0)
				{
				}
				num = (short)962789376;
				short num3 = num;
				num = (short)849281024;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeySystemWideKeySelect_A9253.Editable = value;
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x00123998 File Offset: 0x00121B98
		internal string TrkSysSecureMultikeySystemWideKeySelect_A9253_UILabel
		{
			get
			{
				short num = (short)665819145;
				short num2 = num;
				num = (short)382244873;
				switch (num2 == num)
				{
				}
				num = (short)1579089921;
				if (num != 0)
				{
				}
				num = (short)253427712;
				short num3 = num;
				num = (short)1714749440;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeySystemWideKeySelect_A9253.UIName;
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x0600133B RID: 4923 RVA: 0x00123A4C File Offset: 0x00121C4C
		// (set) Token: 0x0600133C RID: 4924 RVA: 0x00123B00 File Offset: 0x00121D00
		internal bool TrkSysSecureMultikeySystemWideKeySelect_A9253_HiddenStatic
		{
			get
			{
				short num = (short)1645509896;
				short num2 = num;
				num = (short)1628273928;
				switch (num2 == num)
				{
				}
				num = (short)1505296384;
				if (num != 0)
				{
				}
				num = (short)1017184256;
				short num3 = num;
				num = (short)1460142081;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeySystemWideKeySelect_A9253.HiddenStatic;
			}
			set
			{
				short num = (short)308172344;
				short num2 = num;
				num = (short)602101304;
				switch (num2 == num)
				{
				}
				num = (short)2038693889;
				if (num != 0)
				{
				}
				num = (short)1144520704;
				short num3 = num;
				num = (short)109379584;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeySystemWideKeySelect_A9253.HiddenStatic = value;
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x0600133D RID: 4925 RVA: 0x00123BB4 File Offset: 0x00121DB4
		// (set) Token: 0x0600133E RID: 4926 RVA: 0x00123C68 File Offset: 0x00121E68
		internal bool TrkSysSecureMultikeySystemWideKeySelect_A9253_HiddenDynamic
		{
			get
			{
				short num = (short)1586364417;
				if (num != 0)
				{
				}
				num = (short)865296439;
				short num2 = num;
				num = (short)1888968759;
				switch (num2 == num)
				{
				}
				num = (short)517144576;
				short num3 = num;
				num = (short)1903886336;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeySystemWideKeySelect_A9253.HiddenDynamic;
			}
			set
			{
				short num = (short)2117984387;
				short num2 = num;
				num = (short)1747443843;
				switch (num2 == num)
				{
				}
				num = (short)894566401;
				if (num != 0)
				{
				}
				num = (short)1067384832;
				short num3 = num;
				num = (short)1737752576;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeySystemWideKeySelect_A9253.HiddenDynamic = value;
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x0600133F RID: 4927 RVA: 0x00123D20 File Offset: 0x00121F20
		public bool TrkSysSecureMultikeySystemWideKeySelect_A9253_HasDiffs
		{
			get
			{
				short num = (short)1301727382;
				short num2 = num;
				num = (short)1116981398;
				switch (num2 == num)
				{
				}
				num = (short)1911750657;
				if (num != 0)
				{
				}
				num = (short)2129526784;
				short num3 = num;
				num = (short)912916480;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeySystemWideKeySelect_A9253._HasDiffs;
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06001340 RID: 4928 RVA: 0x00123DD4 File Offset: 0x00121FD4
		// (set) Token: 0x06001341 RID: 4929 RVA: 0x00123E84 File Offset: 0x00122084
		public bool TrkSysSecureMultikeyAutoKeyIDRx_A43185Value
		{
			get
			{
				short num = (short)505588057;
				short num2 = num;
				num = (short)1234282841;
				switch (num2 == num)
				{
				}
				num = (short)2101608449;
				if (num != 0)
				{
				}
				num = (short)1943142400;
				short num3 = num;
				num = (short)1467482112;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyAutoKeyIDRx_A43185.Value;
			}
			set
			{
				short num = (short)1079007610;
				short num2 = num;
				num = (short)232675706;
				switch (num2 == num)
				{
				}
				num = (short)829816833;
				if (num != 0)
				{
				}
				num = (short)1023737856;
				short num3 = num;
				num = (short)1018691584;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyAutoKeyIDRx_A43185.Value = value;
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06001342 RID: 4930 RVA: 0x00123F38 File Offset: 0x00122138
		public global::AcpBusinessLayer.AcpField<bool> TrkSysSecureMultikeyAutoKeyIDRx_A43185
		{
			get
			{
				short num = (short)1785277865;
				short num2 = num;
				num = (short)1732783529;
				switch (num2 == num)
				{
				}
				num = (short)990707712;
				if (num != 0)
				{
				}
				num = (short)1131675648;
				short num3 = num;
				num = (short)741343233;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyAutoKeyIDRx_A43185;
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06001343 RID: 4931 RVA: 0x00123FE4 File Offset: 0x001221E4
		// (set) Token: 0x06001344 RID: 4932 RVA: 0x0012409C File Offset: 0x0012229C
		public bool TrkSysSecureMultikeyAutoKeyIDRx_A43185_UIValue
		{
			get
			{
				short num = (short)502884601;
				short num2 = num;
				num = (short)546793721;
				switch (num2 == num)
				{
				}
				num = (short)1084227585;
				if (num != 0)
				{
				}
				num = (short)1756954624;
				if (num != 0)
				{
				}
				num = (short)1362362368;
				short num3 = num;
				return this.trkSysSecureMultikeyAutoKeyIDRx_A43185.Value;
			}
			set
			{
				short num = (short)1984940965;
				short num2 = num;
				num = (short)267307941;
				switch (num2 == num)
				{
				}
				num = (short)2001010688;
				if (num != 0)
				{
				}
				num = (short)1246953473;
				if (num != 0)
				{
				}
				num = (short)1813381120;
				short num3 = num;
				this.trkSysSecureMultikeyAutoKeyIDRx_A43185.Value = value;
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06001345 RID: 4933 RVA: 0x00124154 File Offset: 0x00122354
		// (set) Token: 0x06001346 RID: 4934 RVA: 0x00124208 File Offset: 0x00122408
		public bool TrkSysSecureMultikeyAutoKeyIDRx_A43185_Applicable
		{
			get
			{
				short num = (short)968064494;
				short num2 = num;
				num = (short)1240497646;
				switch (num2 == num)
				{
				}
				num = (short)1105657856;
				if (num != 0)
				{
				}
				num = (short)1620770817;
				if (num != 0)
				{
				}
				num = (short)1884160000;
				short num3 = num;
				return this.trkSysSecureMultikeyAutoKeyIDRx_A43185.Applicable;
			}
			set
			{
				short num = (short)446234625;
				if (num != 0)
				{
				}
				num = (short)1762082107;
				short num2 = num;
				num = (short)1101217083;
				switch (num2 == num)
				{
				}
				num = (short)1858666496;
				if (num != 0)
				{
				}
				num = (short)191561728;
				short num3 = num;
				this.trkSysSecureMultikeyAutoKeyIDRx_A43185.Applicable = value;
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06001347 RID: 4935 RVA: 0x001242BC File Offset: 0x001224BC
		// (set) Token: 0x06001348 RID: 4936 RVA: 0x00124370 File Offset: 0x00122570
		public bool TrkSysSecureMultikeyAutoKeyIDRx_A43185_Valid
		{
			get
			{
				short num = (short)1096180106;
				short num2 = num;
				num = (short)1947099530;
				switch (num2 == num)
				{
				}
				num = (short)713490433;
				if (num != 0)
				{
				}
				num = (short)13565952;
				if (num != 0)
				{
				}
				num = (short)1886126080;
				short num3 = num;
				return this.trkSysSecureMultikeyAutoKeyIDRx_A43185.Valid;
			}
			set
			{
				short num = (short)1499424552;
				short num2 = num;
				num = (short)1848469288;
				switch (num2 == num)
				{
				}
				num = (short)451084288;
				if (num != 0)
				{
				}
				num = (short)273874945;
				if (num != 0)
				{
				}
				num = (short)1326972928;
				short num3 = num;
				this.trkSysSecureMultikeyAutoKeyIDRx_A43185.Valid = value;
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06001349 RID: 4937 RVA: 0x00124428 File Offset: 0x00122628
		// (set) Token: 0x0600134A RID: 4938 RVA: 0x001244DC File Offset: 0x001226DC
		public bool TrkSysSecureMultikeyAutoKeyIDRx_A43185_Visible
		{
			get
			{
				short num = (short)573236440;
				short num2 = num;
				num = (short)7791832;
				switch (num2 == num)
				{
				}
				num = (short)37945345;
				if (num != 0)
				{
				}
				num = (short)1043922944;
				if (num != 0)
				{
				}
				num = (short)1091436544;
				short num3 = num;
				return this.trkSysSecureMultikeyAutoKeyIDRx_A43185.Visible;
			}
			set
			{
				short num = (short)1268166917;
				short num2 = num;
				num = (short)1463005445;
				switch (num2 == num)
				{
				}
				num = (short)322568193;
				if (num != 0)
				{
				}
				num = (short)78249984;
				if (num != 0)
				{
				}
				num = (short)1726611456;
				short num3 = num;
				this.trkSysSecureMultikeyAutoKeyIDRx_A43185.Visible = value;
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x00124590 File Offset: 0x00122790
		// (set) Token: 0x0600134C RID: 4940 RVA: 0x00124644 File Offset: 0x00122844
		public bool TrkSysSecureMultikeyAutoKeyIDRx_A43185_Editable
		{
			get
			{
				short num = (short)782386903;
				short num2 = num;
				num = (short)1577010903;
				switch (num2 == num)
				{
				}
				num = (short)1135280129;
				if (num != 0)
				{
				}
				num = (short)1034420224;
				if (num != 0)
				{
				}
				num = (short)284098560;
				short num3 = num;
				return this.trkSysSecureMultikeyAutoKeyIDRx_A43185.Editable;
			}
			set
			{
				short num = (short)1068055722;
				short num2 = num;
				num = (short)766721194;
				switch (num2 == num)
				{
				}
				num = (short)1370554369;
				if (num != 0)
				{
				}
				num = (short)1370226688;
				if (num != 0)
				{
				}
				num = (short)2097741824;
				short num3 = num;
				this.trkSysSecureMultikeyAutoKeyIDRx_A43185.Editable = value;
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x0600134D RID: 4941 RVA: 0x001246FC File Offset: 0x001228FC
		internal string TrkSysSecureMultikeyAutoKeyIDRx_A43185_UILabel
		{
			get
			{
				short num = (short)2131115123;
				short num2 = num;
				num = (short)1518222451;
				switch (num2 == num)
				{
				}
				num = (short)1214119937;
				if (num != 0)
				{
				}
				num = (short)1701183488;
				if (num != 0)
				{
				}
				num = (short)1037107200;
				short num3 = num;
				return this.trkSysSecureMultikeyAutoKeyIDRx_A43185.UIName;
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x0600134E RID: 4942 RVA: 0x001247B0 File Offset: 0x001229B0
		// (set) Token: 0x0600134F RID: 4943 RVA: 0x00124868 File Offset: 0x00122A68
		internal bool TrkSysSecureMultikeyAutoKeyIDRx_A43185_HiddenStatic
		{
			get
			{
				short num = (short)899342890;
				short num2 = num;
				num = (short)135455274;
				switch (num2 == num)
				{
				}
				num = (short)945225728;
				if (num != 0)
				{
				}
				num = (short)1379532801;
				if (num != 0)
				{
				}
				num = (short)535822336;
				short num3 = num;
				return this.trkSysSecureMultikeyAutoKeyIDRx_A43185.HiddenStatic;
			}
			set
			{
				short num = (short)2125360928;
				short num2 = num;
				num = (short)1564700448;
				switch (num2 == num)
				{
				}
				num = (short)1748500481;
				if (num != 0)
				{
				}
				num = (short)881655808;
				if (num != 0)
				{
				}
				num = (short)159776768;
				short num3 = num;
				this.trkSysSecureMultikeyAutoKeyIDRx_A43185.HiddenStatic = value;
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06001350 RID: 4944 RVA: 0x0012491C File Offset: 0x00122B1C
		// (set) Token: 0x06001351 RID: 4945 RVA: 0x001249D0 File Offset: 0x00122BD0
		internal bool TrkSysSecureMultikeyAutoKeyIDRx_A43185_HiddenDynamic
		{
			get
			{
				short num = (short)1494048943;
				short num2 = num;
				num = (short)403792047;
				switch (num2 == num)
				{
				}
				num = (short)614334465;
				if (num != 0)
				{
				}
				num = (short)1347026944;
				if (num != 0)
				{
				}
				num = (short)1183973376;
				short num3 = num;
				return this.trkSysSecureMultikeyAutoKeyIDRx_A43185.HiddenDynamic;
			}
			set
			{
				short num = (short)191144274;
				short num2 = num;
				num = (short)58237266;
				switch (num2 == num)
				{
				}
				num = (short)967180288;
				if (num != 0)
				{
				}
				num = (short)1817837569;
				if (num != 0)
				{
				}
				num = (short)2114060288;
				short num3 = num;
				this.trkSysSecureMultikeyAutoKeyIDRx_A43185.HiddenDynamic = value;
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06001352 RID: 4946 RVA: 0x00124A88 File Offset: 0x00122C88
		public bool TrkSysSecureMultikeyAutoKeyIDRx_A43185_HasDiffs
		{
			get
			{
				short num = (short)76925528;
				short num2 = num;
				num = (short)937675352;
				switch (num2 == num)
				{
				}
				num = (short)481624065;
				if (num != 0)
				{
				}
				num = (short)1944780800;
				if (num != 0)
				{
				}
				num = (short)1467744256;
				short num3 = num;
				return this.trkSysSecureMultikeyAutoKeyIDRx_A43185._HasDiffs;
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06001353 RID: 4947 RVA: 0x00124B40 File Offset: 0x00122D40
		// (set) Token: 0x06001354 RID: 4948 RVA: 0x00124BF4 File Offset: 0x00122DF4
		public int TrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477Value
		{
			get
			{
				short num = (short)160348043;
				short num2 = num;
				num = (short)1228846987;
				switch (num2 == num)
				{
				}
				num = (short)1581645824;
				if (num != 0)
				{
				}
				num = (short)1336279041;
				if (num != 0)
				{
				}
				num = (short)1854406656;
				short num3 = num;
				return this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477.Value;
			}
			set
			{
				short num = (short)1698905581;
				short num2 = num;
				num = (short)1683766765;
				switch (num2 == num)
				{
				}
				num = (short)737607681;
				if (num != 0)
				{
				}
				num = (short)1886060544;
				if (num != 0)
				{
				}
				num = (short)904396800;
				short num3 = num;
				this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477.Value = value;
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06001355 RID: 4949 RVA: 0x00124CAC File Offset: 0x00122EAC
		// (set) Token: 0x06001356 RID: 4950 RVA: 0x00124D60 File Offset: 0x00122F60
		public string TrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477_UIValue
		{
			get
			{
				short num = (short)1563819425;
				short num2 = num;
				num = (short)840039841;
				switch (num2 == num)
				{
				}
				num = (short)1858011137;
				if (num != 0)
				{
				}
				num = (short)1920204800;
				if (num != 0)
				{
				}
				num = (short)348389376;
				short num3 = num;
				return this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477.UIValue;
			}
			set
			{
				short num = (short)821919001;
				short num2 = num;
				num = (short)674856217;
				switch (num2 == num)
				{
				}
				num = (short)399441921;
				if (num != 0)
				{
				}
				num = (short)889978880;
				if (num != 0)
				{
				}
				num = (short)1309868032;
				short num3 = num;
				this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477.UIValue = value;
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x00124E18 File Offset: 0x00123018
		public global::AcpBusinessLayer.AcpListField TrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477
		{
			get
			{
				short num = (short)1213071361;
				if (num != 0)
				{
				}
				num = (short)1171974254;
				short num2 = num;
				num = (short)1960044654;
				switch (num2 == num)
				{
				}
				num = (short)1472266240;
				if (num != 0)
				{
				}
				num = (short)715259904;
				short num3 = num;
				return this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477;
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06001358 RID: 4952 RVA: 0x00124EC4 File Offset: 0x001230C4
		// (set) Token: 0x06001359 RID: 4953 RVA: 0x00124F74 File Offset: 0x00123174
		public bool TrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477_Applicable
		{
			get
			{
				short num = (short)1526333441;
				if (num != 0)
				{
				}
				num = (short)1273757340;
				short num2 = num;
				num = (short)129171100;
				switch (num2 == num)
				{
				}
				num = (short)1501429760;
				if (num != 0)
				{
				}
				num = (short)663027712;
				short num3 = num;
				return this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477.Applicable;
			}
			set
			{
				short num = (short)135069697;
				if (num != 0)
				{
				}
				num = (short)1730588646;
				short num2 = num;
				num = (short)1732947942;
				switch (num2 == num)
				{
				}
				num = (short)1259667456;
				if (num != 0)
				{
				}
				num = (short)719388672;
				short num3 = num;
				this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477.Applicable = value;
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x0600135A RID: 4954 RVA: 0x00125028 File Offset: 0x00123228
		// (set) Token: 0x0600135B RID: 4955 RVA: 0x001250DC File Offset: 0x001232DC
		public bool TrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477_Valid
		{
			get
			{
				short num = (short)609674635;
				short num2 = num;
				num = (short)921888139;
				switch (num2 == num)
				{
				}
				num = (short)988872704;
				if (num != 0)
				{
				}
				num = (short)1089208321;
				if (num != 0)
				{
				}
				num = (short)380567552;
				short num3 = num;
				return this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477.Valid;
			}
			set
			{
				short num = (short)887456220;
				short num2 = num;
				num = (short)1322287580;
				switch (num2 == num)
				{
				}
				num = (short)1549467649;
				if (num != 0)
				{
				}
				num = (short)1710948352;
				if (num != 0)
				{
				}
				num = (short)1228537856;
				short num3 = num;
				this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477.Valid = value;
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x00125190 File Offset: 0x00123390
		// (set) Token: 0x0600135D RID: 4957 RVA: 0x00125244 File Offset: 0x00123444
		public bool TrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477_Visible
		{
			get
			{
				short num = (short)641283554;
				short num2 = num;
				num = (short)240661986;
				switch (num2 == num)
				{
				}
				num = (short)1712848896;
				if (num != 0)
				{
				}
				num = (short)2060713985;
				if (num != 0)
				{
				}
				num = (short)1047527424;
				short num3 = num;
				return this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477.Visible;
			}
			set
			{
				short num = (short)1843211747;
				short num2 = num;
				num = (short)1751854563;
				switch (num2 == num)
				{
				}
				num = (short)576061440;
				if (num != 0)
				{
				}
				num = (short)1037893633;
				if (num != 0)
				{
				}
				num = (short)796000256;
				short num3 = num;
				this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477.Visible = value;
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x0600135E RID: 4958 RVA: 0x001252F8 File Offset: 0x001234F8
		// (set) Token: 0x0600135F RID: 4959 RVA: 0x001253AC File Offset: 0x001235AC
		public bool TrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477_Editable
		{
			get
			{
				short num = (short)629089218;
				short num2 = num;
				num = (short)835462082;
				switch (num2 == num)
				{
				}
				num = (short)1773142017;
				if (num != 0)
				{
				}
				num = (short)84344832;
				if (num != 0)
				{
				}
				num = (short)2096300032;
				short num3 = num;
				return this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477.Editable;
			}
			set
			{
				short num = (short)1206053200;
				short num2 = num;
				num = (short)891021648;
				switch (num2 == num)
				{
				}
				num = (short)1946419201;
				if (num != 0)
				{
				}
				num = (short)678821888;
				if (num != 0)
				{
				}
				num = (short)342687744;
				short num3 = num;
				this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477.Editable = value;
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x00125460 File Offset: 0x00123660
		internal string TrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477_UILabel
		{
			get
			{
				short num = (short)334232756;
				short num2 = num;
				num = (short)1989016756;
				switch (num2 == num)
				{
				}
				num = (short)623902721;
				if (num != 0)
				{
				}
				num = (short)574423040;
				if (num != 0)
				{
				}
				num = (short)1264451584;
				short num3 = num;
				return this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477.UIName;
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x00125514 File Offset: 0x00123714
		// (set) Token: 0x06001362 RID: 4962 RVA: 0x001255CC File Offset: 0x001237CC
		internal bool TrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477_HiddenStatic
		{
			get
			{
				short num = (short)1392534741;
				short num2 = num;
				num = (short)1859871957;
				switch (num2 == num)
				{
				}
				num = (short)337510401;
				if (num != 0)
				{
				}
				num = (short)1304231936;
				if (num != 0)
				{
				}
				num = (short)1261043712;
				short num3 = num;
				return this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477.HiddenStatic;
			}
			set
			{
				short num = (short)439924910;
				short num2 = num;
				num = (short)1513601198;
				switch (num2 == num)
				{
				}
				num = (short)171573248;
				if (num != 0)
				{
				}
				num = (short)983302145;
				if (num != 0)
				{
				}
				num = (short)746192896;
				short num3 = num;
				this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477.HiddenStatic = value;
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06001363 RID: 4963 RVA: 0x00125684 File Offset: 0x00123884
		// (set) Token: 0x06001364 RID: 4964 RVA: 0x00125738 File Offset: 0x00123938
		internal bool TrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477_HiddenDynamic
		{
			get
			{
				short num = (short)1218291082;
				short num2 = num;
				num = (short)285189514;
				switch (num2 == num)
				{
				}
				num = (short)62652417;
				if (num != 0)
				{
				}
				num = (short)1110638592;
				if (num != 0)
				{
				}
				num = (short)1091108864;
				short num3 = num;
				return this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477.HiddenDynamic;
			}
			set
			{
				short num = (short)1185130551;
				short num2 = num;
				num = (short)1117825079;
				switch (num2 == num)
				{
				}
				num = (short)1219493888;
				if (num != 0)
				{
				}
				num = (short)178454529;
				if (num != 0)
				{
				}
				num = (short)1560084480;
				short num3 = num;
				this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477.HiddenDynamic = value;
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06001365 RID: 4965 RVA: 0x001257EC File Offset: 0x001239EC
		public bool TrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477_HasDiffs
		{
			get
			{
				short num = (short)871442444;
				short num2 = num;
				num = (short)816654348;
				switch (num2 == num)
				{
				}
				num = (short)392429568;
				if (num != 0)
				{
				}
				num = (short)1853489153;
				if (num != 0)
				{
				}
				num = (short)1306656768;
				short num3 = num;
				return this.trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477._HasDiffs;
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06001366 RID: 4966 RVA: 0x001258A4 File Offset: 0x00123AA4
		// (set) Token: 0x06001367 RID: 4967 RVA: 0x0012595C File Offset: 0x00123B5C
		public int TrkSysSecureMultikeyInterconnectSecureClearStrapping_43478Value
		{
			get
			{
				short num = (short)1158453475;
				short num2 = num;
				num = (short)1054447843;
				switch (num2 == num)
				{
				}
				num = (short)892600321;
				if (num != 0)
				{
				}
				num = (short)473169920;
				if (num != 0)
				{
				}
				num = (short)2043805696;
				short num3 = num;
				return this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478.Value;
			}
			set
			{
				short num = (short)663004152;
				short num2 = num;
				num = (short)476423160;
				switch (num2 == num)
				{
				}
				num = (short)399441921;
				if (num != 0)
				{
				}
				num = (short)176226304;
				if (num != 0)
				{
				}
				num = (short)666304512;
				short num3 = num;
				this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478.Value = value;
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06001368 RID: 4968 RVA: 0x00125A14 File Offset: 0x00123C14
		// (set) Token: 0x06001369 RID: 4969 RVA: 0x00125AD0 File Offset: 0x00123CD0
		public string TrkSysSecureMultikeyInterconnectSecureClearStrapping_43478_UIValue
		{
			get
			{
				short num = (short)1589312500;
				short num2 = num;
				num = (short)1760164852;
				switch (num2 == num)
				{
				}
				num = (short)506462209;
				if (num != 0)
				{
				}
				num = (short)2033778688;
				if (num != 0)
				{
				}
				num = (short)1335296000;
				short num3 = num;
				return this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478.UIValue;
			}
			set
			{
				short num = (short)1614544897;
				if (num != 0)
				{
				}
				num = (short)266276725;
				short num2 = num;
				num = (short)1810042741;
				switch (num2 == num)
				{
				}
				num = (short)1922498560;
				if (num != 0)
				{
				}
				num = (short)1204092928;
				short num3 = num;
				this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478.UIValue = value;
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x00125B84 File Offset: 0x00123D84
		public global::AcpBusinessLayer.AcpListField TrkSysSecureMultikeyInterconnectSecureClearStrapping_43478
		{
			get
			{
				short num = (short)339804161;
				if (num != 0)
				{
				}
				num = (short)473129470;
				short num2 = num;
				num = (short)22045182;
				switch (num2 == num)
				{
				}
				num = (short)1490550784;
				if (num != 0)
				{
				}
				num = (short)1764884480;
				short num3 = num;
				return this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478;
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x0600136B RID: 4971 RVA: 0x00125C34 File Offset: 0x00123E34
		// (set) Token: 0x0600136C RID: 4972 RVA: 0x00125CE4 File Offset: 0x00123EE4
		public bool TrkSysSecureMultikeyInterconnectSecureClearStrapping_43478_Applicable
		{
			get
			{
				short num = (short)1788265851;
				short num2 = num;
				num = (short)1490732411;
				switch (num2 == num)
				{
				}
				num = (short)1917452288;
				if (num != 0)
				{
				}
				num = (short)315949057;
				if (num != 0)
				{
				}
				num = (short)1555955712;
				short num3 = num;
				return this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478.Applicable;
			}
			set
			{
				short num = (short)418242168;
				short num2 = num;
				num = (short)1094377080;
				switch (num2 == num)
				{
				}
				num = (short)281280512;
				if (num != 0)
				{
				}
				num = (short)1471676417;
				if (num != 0)
				{
				}
				num = (short)1093861376;
				short num3 = num;
				this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478.Applicable = value;
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x00125D98 File Offset: 0x00123F98
		// (set) Token: 0x0600136E RID: 4974 RVA: 0x00125E50 File Offset: 0x00124050
		public bool TrkSysSecureMultikeyInterconnectSecureClearStrapping_43478_Valid
		{
			get
			{
				short num = (short)765417671;
				short num2 = num;
				num = (short)418732231;
				switch (num2 == num)
				{
				}
				num = (short)1574043649;
				if (num != 0)
				{
				}
				num = (short)2130837504;
				if (num != 0)
				{
				}
				num = (short)1286733824;
				short num3 = num;
				return this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478.Valid;
			}
			set
			{
				short num = (short)1823126025;
				short num2 = num;
				num = (short)599437833;
				switch (num2 == num)
				{
				}
				num = (short)777977857;
				if (num != 0)
				{
				}
				num = (short)1592066048;
				if (num != 0)
				{
				}
				num = (short)2021326848;
				short num3 = num;
				this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478.Valid = value;
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x0600136F RID: 4975 RVA: 0x00125F08 File Offset: 0x00124108
		// (set) Token: 0x06001370 RID: 4976 RVA: 0x00125FBC File Offset: 0x001241BC
		public bool TrkSysSecureMultikeyInterconnectSecureClearStrapping_43478_Visible
		{
			get
			{
				short num = (short)1267493029;
				short num2 = num;
				num = (short)1950247077;
				switch (num2 == num)
				{
				}
				num = (short)11927552;
				if (num != 0)
				{
				}
				num = (short)1758265345;
				if (num != 0)
				{
				}
				num = (short)1146224640;
				short num3 = num;
				return this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478.Visible;
			}
			set
			{
				short num = (short)1098541806;
				short num2 = num;
				num = (short)1649699566;
				switch (num2 == num)
				{
				}
				num = (short)203423745;
				if (num != 0)
				{
				}
				num = (short)1095827456;
				if (num != 0)
				{
				}
				num = (short)1618018304;
				short num3 = num;
				this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478.Visible = value;
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06001371 RID: 4977 RVA: 0x00126074 File Offset: 0x00124274
		// (set) Token: 0x06001372 RID: 4978 RVA: 0x00126128 File Offset: 0x00124328
		public bool TrkSysSecureMultikeyInterconnectSecureClearStrapping_43478_Editable
		{
			get
			{
				short num = (short)452536553;
				short num2 = num;
				num = (short)1028204777;
				switch (num2 == num)
				{
				}
				num = (short)423624705;
				if (num != 0)
				{
				}
				num = (short)1955397632;
				if (num != 0)
				{
				}
				num = (short)1499594752;
				short num3 = num;
				return this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478.Editable;
			}
			set
			{
				short num = (short)232332376;
				short num2 = num;
				num = (short)159063128;
				switch (num2 == num)
				{
				}
				num = (short)1579745281;
				if (num != 0)
				{
				}
				num = (short)1530593280;
				if (num != 0)
				{
				}
				num = (short)178192384;
				short num3 = num;
				this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478.Editable = value;
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06001373 RID: 4979 RVA: 0x001261DC File Offset: 0x001243DC
		internal string TrkSysSecureMultikeyInterconnectSecureClearStrapping_43478_UILabel
		{
			get
			{
				short num = (short)134657253;
				short num2 = num;
				num = (short)1638184165;
				switch (num2 == num)
				{
				}
				num = (short)1958543361;
				if (num != 0)
				{
				}
				num = (short)375980032;
				if (num != 0)
				{
				}
				num = (short)25427968;
				short num3 = num;
				return this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478.UIName;
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x00126290 File Offset: 0x00124490
		// (set) Token: 0x06001375 RID: 4981 RVA: 0x00126344 File Offset: 0x00124544
		internal bool TrkSysSecureMultikeyInterconnectSecureClearStrapping_43478_HiddenStatic
		{
			get
			{
				short num = (short)1811518943;
				short num2 = num;
				num = (short)865899999;
				switch (num2 == num)
				{
				}
				num = (short)1353973760;
				if (num != 0)
				{
				}
				num = (short)729088001;
				if (num != 0)
				{
				}
				num = (short)1546518528;
				short num3 = num;
				return this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478.HiddenStatic;
			}
			set
			{
				short num = (short)805447927;
				short num2 = num;
				num = (short)489236727;
				switch (num2 == num)
				{
				}
				num = (short)1930035201;
				if (num != 0)
				{
				}
				num = (short)1570635776;
				if (num != 0)
				{
				}
				num = (short)961085440;
				short num3 = num;
				this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478.HiddenStatic = value;
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06001376 RID: 4982 RVA: 0x001263FC File Offset: 0x001245FC
		// (set) Token: 0x06001377 RID: 4983 RVA: 0x001264B0 File Offset: 0x001246B0
		internal bool TrkSysSecureMultikeyInterconnectSecureClearStrapping_43478_HiddenDynamic
		{
			get
			{
				short num = (short)1631488680;
				short num2 = num;
				num = (short)200444584;
				switch (num2 == num)
				{
				}
				num = (short)1994915841;
				if (num != 0)
				{
				}
				num = (short)587268096;
				if (num != 0)
				{
				}
				num = (short)1897201664;
				short num3 = num;
				return this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478.HiddenDynamic;
			}
			set
			{
				short num = (short)1122304001;
				if (num != 0)
				{
				}
				num = (short)837921720;
				short num2 = num;
				num = (short)730311608;
				switch (num2 == num)
				{
				}
				num = (short)487915520;
				if (num != 0)
				{
				}
				num = (short)1421934592;
				short num3 = num;
				this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478.HiddenDynamic = value;
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06001378 RID: 4984 RVA: 0x00126568 File Offset: 0x00124768
		public bool TrkSysSecureMultikeyInterconnectSecureClearStrapping_43478_HasDiffs
		{
			get
			{
				short num = (short)1835401217;
				if (num != 0)
				{
				}
				num = (short)9886817;
				short num2 = num;
				num = (short)639687777;
				switch (num2 == num)
				{
				}
				num = (short)56492032;
				if (num != 0)
				{
				}
				num = (short)30081024;
				short num3 = num;
				return this.trkSysSecureMultikeyInterconnectSecureClearStrapping_43478._HasDiffs;
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06001379 RID: 4985 RVA: 0x0012661C File Offset: 0x0012481C
		// (set) Token: 0x0600137A RID: 4986 RVA: 0x001266D0 File Offset: 0x001248D0
		public int TrkSysSecureMultikeyFailsoftSecureClearStrapping_43479Value
		{
			get
			{
				short num = (short)1970750778;
				short num2 = num;
				num = (short)1898988858;
				switch (num2 == num)
				{
				}
				num = (short)1260912641;
				if (num != 0)
				{
				}
				num = (short)25100288;
				if (num != 0)
				{
				}
				num = (short)1757085696;
				short num3 = num;
				return this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479.Value;
			}
			set
			{
				short num = (short)2141809245;
				short num2 = num;
				num = (short)2092657245;
				switch (num2 == num)
				{
				}
				num = (short)986906625;
				if (num != 0)
				{
				}
				num = (short)536739840;
				if (num != 0)
				{
				}
				num = (short)1256521728;
				short num3 = num;
				this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479.Value = value;
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x00126784 File Offset: 0x00124984
		// (set) Token: 0x0600137C RID: 4988 RVA: 0x0012683C File Offset: 0x00124A3C
		public string TrkSysSecureMultikeyFailsoftSecureClearStrapping_43479_UIValue
		{
			get
			{
				short num = (short)1842617279;
				short num2 = num;
				num = (short)1173232575;
				switch (num2 == num)
				{
				}
				num = (short)608567297;
				if (num != 0)
				{
				}
				num = (short)1369112576;
				if (num != 0)
				{
				}
				num = (short)1439825920;
				short num3 = num;
				return this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479.UIValue;
			}
			set
			{
				short num = (short)649723904;
				short num2 = num;
				num = (short)1599012865;
				if (num != 0)
				{
				}
				num = (short)713267298;
				short num3 = num;
				num = (short)664836194;
				switch (num3 == num)
				{
				}
				num = (short)199426048;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479.UIValue = value;
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x0600137D RID: 4989 RVA: 0x001268F4 File Offset: 0x00124AF4
		public global::AcpBusinessLayer.AcpListField TrkSysSecureMultikeyFailsoftSecureClearStrapping_43479
		{
			get
			{
				short num = (short)88735744;
				short num2 = num;
				num = (short)1848884062;
				short num3 = num;
				num = (short)1583725406;
				switch (num3 == num)
				{
				}
				num = (short)48889856;
				if (num != 0)
				{
				}
				num = (short)1690238977;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479;
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x0600137E RID: 4990 RVA: 0x001269A0 File Offset: 0x00124BA0
		// (set) Token: 0x0600137F RID: 4991 RVA: 0x00126A58 File Offset: 0x00124C58
		public bool TrkSysSecureMultikeyFailsoftSecureClearStrapping_43479_Applicable
		{
			get
			{
				short num = (short)2035089408;
				short num2 = num;
				num = (short)826944423;
				short num3 = num;
				num = (short)721431463;
				switch (num3 == num)
				{
				}
				num = (short)1419182081;
				if (num != 0)
				{
				}
				num = (short)312475648;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479.Applicable;
			}
			set
			{
				short num = (short)1329266688;
				short num2 = num;
				num = (short)2036269057;
				if (num != 0)
				{
				}
				num = (short)1709324612;
				short num3 = num;
				num = (short)2095528260;
				switch (num3 == num)
				{
				}
				num = (short)1653932032;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479.Applicable = value;
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06001380 RID: 4992 RVA: 0x00126B0C File Offset: 0x00124D0C
		// (set) Token: 0x06001381 RID: 4993 RVA: 0x00126BC4 File Offset: 0x00124DC4
		public bool TrkSysSecureMultikeyFailsoftSecureClearStrapping_43479_Valid
		{
			get
			{
				short num = (short)895680512;
				short num2 = num;
				num = (short)619692310;
				short num3 = num;
				num = (short)984203542;
				switch (num3 == num)
				{
				}
				num = (short)1006108672;
				if (num != 0)
				{
				}
				num = (short)200409089;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479.Valid;
			}
			set
			{
				short num = (short)121569280;
				short num2 = num;
				num = (short)2029242293;
				short num3 = num;
				num = (short)1889781685;
				switch (num3 == num)
				{
				}
				num = (short)1654128641;
				if (num != 0)
				{
				}
				num = (short)1072627712;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479.Valid = value;
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06001382 RID: 4994 RVA: 0x00126C7C File Offset: 0x00124E7C
		// (set) Token: 0x06001383 RID: 4995 RVA: 0x00126D34 File Offset: 0x00124F34
		public bool TrkSysSecureMultikeyFailsoftSecureClearStrapping_43479_Visible
		{
			get
			{
				short num = (short)1408368640;
				short num2 = num;
				num = (short)1594903074;
				short num3 = num;
				num = (short)1522682402;
				switch (num3 == num)
				{
				}
				num = (short)2062483456;
				if (num != 0)
				{
				}
				num = (short)1797718017;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479.Visible;
			}
			set
			{
				short num = (short)1066860544;
				short num2 = num;
				num = (short)129292245;
				short num3 = num;
				num = (short)627627989;
				switch (num3 == num)
				{
				}
				num = (short)242352128;
				if (num != 0)
				{
				}
				num = (short)1927806977;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479.Visible = value;
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06001384 RID: 4996 RVA: 0x00126DE8 File Offset: 0x00124FE8
		// (set) Token: 0x06001385 RID: 4997 RVA: 0x00126E9C File Offset: 0x0012509C
		public bool TrkSysSecureMultikeyFailsoftSecureClearStrapping_43479_Editable
		{
			get
			{
				short num = (short)847904768;
				short num2 = num;
				num = (short)2079294404;
				short num3 = num;
				num = (short)939361220;
				switch (num3 == num)
				{
				}
				num = (short)1928855553;
				if (num != 0)
				{
				}
				num = (short)13369344;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479.Editable;
			}
			set
			{
				short num = (short)1190068224;
				short num2 = num;
				num = (short)1908161696;
				short num3 = num;
				num = (short)1827421344;
				switch (num3 == num)
				{
				}
				num = (short)381288449;
				if (num != 0)
				{
				}
				num = (short)369426432;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479.Editable = value;
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06001386 RID: 4998 RVA: 0x00126F50 File Offset: 0x00125150
		internal string TrkSysSecureMultikeyFailsoftSecureClearStrapping_43479_UILabel
		{
			get
			{
				short num = (short)541655040;
				short num2 = num;
				num = (short)1021232872;
				short num3 = num;
				num = (short)215533288;
				switch (num3 == num)
				{
				}
				num = (short)1614872577;
				if (num != 0)
				{
				}
				num = (short)781647872;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479.UIName;
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x00127008 File Offset: 0x00125208
		// (set) Token: 0x06001388 RID: 5000 RVA: 0x001270BC File Offset: 0x001252BC
		internal bool TrkSysSecureMultikeyFailsoftSecureClearStrapping_43479_HiddenStatic
		{
			get
			{
				short num = (short)1462829056;
				short num2 = num;
				num = (short)757545123;
				short num3 = num;
				num = (short)394213539;
				switch (num3 == num)
				{
				}
				num = (short)538181633;
				if (num != 0)
				{
				}
				num = (short)138346496;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479.HiddenStatic;
			}
			set
			{
				short num = (short)25755648;
				short num2 = num;
				num = (short)271321199;
				short num3 = num;
				num = (short)1618937967;
				switch (num3 == num)
				{
				}
				num = (short)350355457;
				if (num != 0)
				{
				}
				num = (short)289472512;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479.HiddenStatic = value;
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x00127170 File Offset: 0x00125370
		// (set) Token: 0x0600138A RID: 5002 RVA: 0x00127224 File Offset: 0x00125424
		internal bool TrkSysSecureMultikeyFailsoftSecureClearStrapping_43479_HiddenDynamic
		{
			get
			{
				short num = (short)1430126592;
				short num2 = num;
				num = (short)1582759937;
				if (num != 0)
				{
				}
				num = (short)73016928;
				short num3 = num;
				num = (short)1557931616;
				switch (num3 == num)
				{
				}
				num = (short)1345650688;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479.HiddenDynamic;
			}
			set
			{
				short num = (short)1358561280;
				short num2 = num;
				num = (short)987741079;
				short num3 = num;
				num = (short)1087486871;
				switch (num3 == num)
				{
				}
				num = (short)1750990849;
				if (num != 0)
				{
				}
				num = (short)1327300608;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479.HiddenDynamic = value;
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x001272DC File Offset: 0x001254DC
		public bool TrkSysSecureMultikeyFailsoftSecureClearStrapping_43479_HasDiffs
		{
			get
			{
				short num = (short)1886912512;
				short num2 = num;
				num = (short)646327927;
				short num3 = num;
				num = (short)839069303;
				switch (num3 == num)
				{
				}
				num = (short)1431568385;
				if (num != 0)
				{
				}
				num = (short)1649606656;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyFailsoftSecureClearStrapping_43479._HasDiffs;
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x00127390 File Offset: 0x00125590
		// (set) Token: 0x0600138D RID: 5005 RVA: 0x00127444 File Offset: 0x00125644
		public int TrkSysSecureMultikeyDynamicSecureClearStrapping_43489Value
		{
			get
			{
				short num = (short)1821442048;
				short num2 = num;
				num = (short)1604688802;
				short num3 = num;
				num = (short)1850645410;
				switch (num3 == num)
				{
				}
				num = (short)489095169;
				if (num != 0)
				{
				}
				num = (short)526712832;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489.Value;
			}
			set
			{
				short num = (short)1474232320;
				short num2 = num;
				num = (short)1673050014;
				short num3 = num;
				num = (short)2017769374;
				switch (num3 == num)
				{
				}
				num = (short)567148544;
				if (num != 0)
				{
				}
				num = (short)1485045761;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489.Value = value;
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x001274F8 File Offset: 0x001256F8
		// (set) Token: 0x0600138F RID: 5007 RVA: 0x001275AC File Offset: 0x001257AC
		public string TrkSysSecureMultikeyDynamicSecureClearStrapping_43489_UIValue
		{
			get
			{
				short num = (short)1472987136;
				short num2 = num;
				num = (short)733350390;
				short num3 = num;
				num = (short)606341622;
				switch (num3 == num)
				{
				}
				num = (short)1129644033;
				if (num != 0)
				{
				}
				num = (short)1869086720;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489.UIValue;
			}
			set
			{
				short num = (short)843513856;
				short num2 = num;
				num = (short)227911124;
				short num3 = num;
				num = (short)1676518868;
				switch (num3 == num)
				{
				}
				num = (short)2089484289;
				if (num != 0)
				{
				}
				num = (short)227475456;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489.UIValue = value;
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06001390 RID: 5008 RVA: 0x00127664 File Offset: 0x00125864
		public global::AcpBusinessLayer.AcpListField TrkSysSecureMultikeyDynamicSecureClearStrapping_43489
		{
			get
			{
				short num = (short)2097414144;
				short num2 = num;
				num = (short)397213148;
				short num3 = num;
				num = (short)34799068;
				switch (num3 == num)
				{
				}
				num = (short)1644691457;
				if (num != 0)
				{
				}
				num = (short)658505728;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489;
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06001391 RID: 5009 RVA: 0x00127710 File Offset: 0x00125910
		// (set) Token: 0x06001392 RID: 5010 RVA: 0x001277C4 File Offset: 0x001259C4
		public bool TrkSysSecureMultikeyDynamicSecureClearStrapping_43489_Applicable
		{
			get
			{
				short num = (short)597229568;
				short num2 = num;
				num = (short)935985153;
				if (num != 0)
				{
				}
				num = (short)1447394533;
				short num3 = num;
				num = (short)1151827173;
				switch (num3 == num)
				{
				}
				num = (short)931594240;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489.Applicable;
			}
			set
			{
				short num = (short)1684209664;
				short num2 = num;
				num = (short)587863790;
				short num3 = num;
				num = (short)1639323374;
				switch (num3 == num)
				{
				}
				num = (short)731447297;
				if (num != 0)
				{
				}
				num = (short)324009984;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489.Applicable = value;
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06001393 RID: 5011 RVA: 0x0012787C File Offset: 0x00125A7C
		// (set) Token: 0x06001394 RID: 5012 RVA: 0x00127934 File Offset: 0x00125B34
		public bool TrkSysSecureMultikeyDynamicSecureClearStrapping_43489_Valid
		{
			get
			{
				short num = (short)482279424;
				short num2 = num;
				num = (short)46337273;
				short num3 = num;
				num = (short)475008249;
				switch (num3 == num)
				{
				}
				num = (short)453574657;
				if (num != 0)
				{
				}
				num = (short)2071396352;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489.Valid;
			}
			set
			{
				short num = (short)479985664;
				short num2 = num;
				num = (short)1706693003;
				short num3 = num;
				num = (short)863834507;
				switch (num3 == num)
				{
				}
				num = (short)1331888129;
				if (num != 0)
				{
				}
				num = (short)1477378048;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489.Valid = value;
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06001395 RID: 5013 RVA: 0x001279E8 File Offset: 0x00125BE8
		// (set) Token: 0x06001396 RID: 5014 RVA: 0x00127A9C File Offset: 0x00125C9C
		public bool TrkSysSecureMultikeyDynamicSecureClearStrapping_43489_Visible
		{
			get
			{
				short num = (short)1526726656;
				short num2 = num;
				num = (short)942436060;
				short num3 = num;
				num = (short)1989897948;
				switch (num3 == num)
				{
				}
				num = (short)1423900673;
				if (num != 0)
				{
				}
				num = (short)922157056;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489.Visible;
			}
			set
			{
				short num = (short)1498349568;
				short num2 = num;
				num = (short)672093041;
				short num3 = num;
				num = (short)1203917681;
				switch (num3 == num)
				{
				}
				num = (short)845807616;
				if (num != 0)
				{
				}
				num = (short)618397697;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489.Visible = value;
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06001397 RID: 5015 RVA: 0x00127B50 File Offset: 0x00125D50
		// (set) Token: 0x06001398 RID: 5016 RVA: 0x00127C08 File Offset: 0x00125E08
		public bool TrkSysSecureMultikeyDynamicSecureClearStrapping_43489_Editable
		{
			get
			{
				short num = (short)153354240;
				short num2 = num;
				num = (short)1766577085;
				short num3 = num;
				num = (short)2093470653;
				switch (num3 == num)
				{
				}
				num = (short)1676607489;
				if (num != 0)
				{
				}
				num = (short)55443456;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489.Editable;
			}
			set
			{
				short num = (short)1749811200;
				short num2 = num;
				num = (short)1243798060;
				short num3 = num;
				num = (short)1924848172;
				switch (num3 == num)
				{
				}
				num = (short)773390337;
				if (num != 0)
				{
				}
				num = (short)196935680;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489.Editable = value;
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x00127CC0 File Offset: 0x00125EC0
		internal string TrkSysSecureMultikeyDynamicSecureClearStrapping_43489_UILabel
		{
			get
			{
				short num = (short)358088704;
				short num2 = num;
				num = (short)1749028086;
				short num3 = num;
				num = (short)653462774;
				switch (num3 == num)
				{
				}
				num = (short)1424228353;
				if (num != 0)
				{
				}
				num = (short)1292697600;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489.UIName;
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x00127D74 File Offset: 0x00125F74
		// (set) Token: 0x0600139B RID: 5019 RVA: 0x00127E28 File Offset: 0x00126028
		internal bool TrkSysSecureMultikeyDynamicSecureClearStrapping_43489_HiddenStatic
		{
			get
			{
				short num = (short)316866560;
				short num2 = num;
				num = (short)1591265577;
				short num3 = num;
				num = (short)1189464361;
				switch (num3 == num)
				{
				}
				num = (short)1123680257;
				if (num != 0)
				{
				}
				num = (short)244383744;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489.HiddenStatic;
			}
			set
			{
				short num = (short)1768292352;
				short num2 = num;
				num = (short)512647933;
				short num3 = num;
				num = (short)1079927549;
				switch (num3 == num)
				{
				}
				num = (short)2031617;
				if (num != 0)
				{
				}
				num = (short)666566656;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489.HiddenStatic = value;
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x00127EE0 File Offset: 0x001260E0
		// (set) Token: 0x0600139D RID: 5021 RVA: 0x00127F94 File Offset: 0x00126194
		internal bool TrkSysSecureMultikeyDynamicSecureClearStrapping_43489_HiddenDynamic
		{
			get
			{
				short num = (short)1568342016;
				short num2 = num;
				num = (short)314949039;
				short num3 = num;
				num = (short)1959771567;
				switch (num3 == num)
				{
				}
				num = (short)941621249;
				if (num != 0)
				{
				}
				num = (short)587137024;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489.HiddenDynamic;
			}
			set
			{
				short num = (short)283967488;
				short num2 = num;
				num = (short)201096484;
				short num3 = num;
				num = (short)1821605156;
				switch (num3 == num)
				{
				}
				num = (short)773718017;
				if (num != 0)
				{
				}
				num = (short)26935296;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489.HiddenDynamic = value;
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x0012804C File Offset: 0x0012624C
		public bool TrkSysSecureMultikeyDynamicSecureClearStrapping_43489_HasDiffs
		{
			get
			{
				short num = (short)1881735168;
				short num2 = num;
				num = (short)901120001;
				if (num != 0)
				{
				}
				num = (short)2132020118;
				short num3 = num;
				num = (short)1461128086;
				switch (num3 == num)
				{
				}
				num = (short)116719616;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyDynamicSecureClearStrapping_43489._HasDiffs;
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x0600139F RID: 5023 RVA: 0x00128100 File Offset: 0x00126300
		// (set) Token: 0x060013A0 RID: 5024 RVA: 0x001281B8 File Offset: 0x001263B8
		public int TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669Value
		{
			get
			{
				short num = (short)872022016;
				short num2 = num;
				num = (short)537542805;
				short num3 = num;
				num = (short)1103184021;
				switch (num3 == num)
				{
				}
				num = (short)980680705;
				if (num != 0)
				{
				}
				num = (short)1078984704;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669.Value;
			}
			set
			{
				short num = (short)459931648;
				short num2 = num;
				num = (short)837411789;
				short num3 = num;
				num = (short)369746893;
				switch (num3 == num)
				{
				}
				num = (short)981336065;
				if (num != 0)
				{
				}
				num = (short)1314521088;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669.Value = value;
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x060013A1 RID: 5025 RVA: 0x0012826C File Offset: 0x0012646C
		// (set) Token: 0x060013A2 RID: 5026 RVA: 0x00128320 File Offset: 0x00126520
		public string TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669_UIValue
		{
			get
			{
				short num = (short)921239552;
				short num2 = num;
				num = (short)1962541057;
				if (num != 0)
				{
				}
				num = (short)1371744442;
				short num3 = num;
				num = (short)1838622906;
				switch (num3 == num)
				{
				}
				num = (short)701759488;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669.UIValue;
			}
			set
			{
				short num = (short)1005453312;
				short num2 = num;
				num = (short)1613562980;
				short num3 = num;
				num = (short)489686116;
				switch (num3 == num)
				{
				}
				num = (short)1249968128;
				if (num != 0)
				{
				}
				num = (short)238157825;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669.UIValue = value;
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x060013A3 RID: 5027 RVA: 0x001283D4 File Offset: 0x001265D4
		public global::AcpBusinessLayer.AcpRecRefField TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669
		{
			get
			{
				short num = (short)1063845888;
				short num2 = num;
				num = (short)97064643;
				short num3 = num;
				num = (short)1075582659;
				switch (num3 == num)
				{
				}
				num = (short)617676801;
				if (num != 0)
				{
				}
				num = (short)618397696;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669;
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x060013A4 RID: 5028 RVA: 0x00128484 File Offset: 0x00126684
		// (set) Token: 0x060013A5 RID: 5029 RVA: 0x00128538 File Offset: 0x00126738
		public bool TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669_Applicable
		{
			get
			{
				short num = (short)1981546496;
				short num2 = num;
				num = (short)893193893;
				short num3 = num;
				num = (short)1432096421;
				switch (num3 == num)
				{
				}
				num = (short)1685389312;
				if (num != 0)
				{
				}
				num = (short)553058305;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669.Applicable;
			}
			set
			{
				short num = (short)1067057152;
				short num2 = num;
				num = (short)729340468;
				short num3 = num;
				num = (short)2088491572;
				switch (num3 == num)
				{
				}
				num = (short)1201143809;
				if (num != 0)
				{
				}
				num = (short)324272128;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669.Applicable = value;
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x001285F0 File Offset: 0x001267F0
		// (set) Token: 0x060013A7 RID: 5031 RVA: 0x001286A4 File Offset: 0x001268A4
		public bool TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669_Valid
		{
			get
			{
				short num = (short)471531520;
				short num2 = num;
				num = (short)144368865;
				short num3 = num;
				num = (short)451405025;
				switch (num3 == num)
				{
				}
				num = (short)1146617857;
				if (num != 0)
				{
				}
				num = (short)153944064;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669.Valid;
			}
			set
			{
				short num = (short)428081152;
				short num2 = num;
				num = (short)1917398605;
				short num3 = num;
				num = (short)49622605;
				switch (num3 == num)
				{
				}
				num = (short)409141249;
				if (num != 0)
				{
				}
				num = (short)599392256;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669.Valid = value;
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x00128758 File Offset: 0x00126958
		// (set) Token: 0x060013A9 RID: 5033 RVA: 0x0012880C File Offset: 0x00126A0C
		public bool TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669_Visible
		{
			get
			{
				short num = (short)461963264;
				short num2 = num;
				num = (short)591356416;
				short num3 = num;
				num = (short)267149824;
				switch (num3 == num)
				{
				}
				num = (short)342818816;
				if (num != 0)
				{
				}
				num = (short)1736048641;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669.Visible;
			}
			set
			{
				short num = (short)1236992000;
				short num2 = num;
				num = (short)1677452212;
				short num3 = num;
				num = (short)1767760820;
				switch (num3 == num)
				{
				}
				num = (short)528089089;
				if (num != 0)
				{
				}
				num = (short)918945792;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669.Visible = value;
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x001288C4 File Offset: 0x00126AC4
		// (set) Token: 0x060013AB RID: 5035 RVA: 0x0012897C File Offset: 0x00126B7C
		public bool TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669_Editable
		{
			get
			{
				short num = (short)1358561280;
				short num2 = num;
				num = (short)2011278454;
				short num3 = num;
				num = (short)859548790;
				switch (num3 == num)
				{
				}
				num = (short)1830027265;
				if (num != 0)
				{
				}
				num = (short)128647168;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669.Editable;
			}
			set
			{
				short num = (short)268042240;
				short num2 = num;
				num = (short)45248383;
				short num3 = num;
				num = (short)585068415;
				switch (num3 == num)
				{
				}
				num = (short)736690176;
				if (num != 0)
				{
				}
				num = (short)1156710401;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669.Editable = value;
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x00128A30 File Offset: 0x00126C30
		internal string TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669_UILabel
		{
			get
			{
				short num = (short)242483200;
				short num2 = num;
				num = (short)498401281;
				if (num != 0)
				{
				}
				num = (short)1258777952;
				short num3 = num;
				num = (short)1654091104;
				switch (num3 == num)
				{
				}
				num = (short)272039936;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669.UIName;
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x00128AE4 File Offset: 0x00126CE4
		// (set) Token: 0x060013AE RID: 5038 RVA: 0x00128B9C File Offset: 0x00126D9C
		internal bool TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669_HiddenStatic
		{
			get
			{
				short num = (short)1531445248;
				short num2 = num;
				num = (short)482171952;
				short num3 = num;
				num = (short)1208507440;
				switch (num3 == num)
				{
				}
				num = (short)1113653248;
				if (num != 0)
				{
				}
				num = (short)607780865;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669.HiddenStatic;
			}
			set
			{
				short num = (short)1606418432;
				short num2 = num;
				num = (short)1375277077;
				short num3 = num;
				num = (short)1048907797;
				switch (num3 == num)
				{
				}
				num = (short)1797259265;
				if (num != 0)
				{
				}
				num = (short)525860864;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669.HiddenStatic = value;
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x060013AF RID: 5039 RVA: 0x00128C50 File Offset: 0x00126E50
		// (set) Token: 0x060013B0 RID: 5040 RVA: 0x00128D08 File Offset: 0x00126F08
		internal bool TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669_HiddenDynamic
		{
			get
			{
				short num = (short)1018757120;
				short num2 = num;
				num = (short)377889986;
				short num3 = num;
				num = (short)1439114434;
				switch (num3 == num)
				{
				}
				num = (short)1736376321;
				if (num != 0)
				{
				}
				num = (short)2067857408;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669.HiddenDynamic;
			}
			set
			{
				short num = (short)1997471744;
				short num2 = num;
				num = (short)1287273284;
				short num3 = num;
				num = (short)1708931908;
				switch (num3 == num)
				{
				}
				num = (short)1526071297;
				if (num != 0)
				{
				}
				num = (short)1302003712;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669.HiddenDynamic = value;
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x060013B1 RID: 5041 RVA: 0x00128DBC File Offset: 0x00126FBC
		public bool TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669_HasDiffs
		{
			get
			{
				short num = (short)2006450176;
				short num2 = num;
				num = (short)1666434184;
				short num3 = num;
				num = (short)1003013256;
				switch (num3 == num)
				{
				}
				num = (short)921042944;
				if (num != 0)
				{
				}
				num = (short)1775566849;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyVirtualPartnerKeySelect_A43669._HasDiffs;
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x060013B2 RID: 5042 RVA: 0x00128E70 File Offset: 0x00127070
		// (set) Token: 0x060013B3 RID: 5043 RVA: 0x00128F24 File Offset: 0x00127124
		public int TrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670Value
		{
			get
			{
				short num = (short)1228931073;
				if (num != 0)
				{
				}
				num = (short)1449263104;
				short num2 = num;
				num = (short)1018240482;
				short num3 = num;
				num = (short)335027682;
				switch (num3 == num)
				{
				}
				num = (short)572981248;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670.Value;
			}
			set
			{
				short num = (short)2000690045;
				short num2 = num;
				num = (short)516758397;
				switch (num2 == num)
				{
				default:
				{
					num = (short)91553792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1306132480;
				if (num != 0)
				{
				}
				num = (short)1112932353;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670.Value = value;
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x00128FDC File Offset: 0x001271DC
		// (set) Token: 0x060013B5 RID: 5045 RVA: 0x00129094 File Offset: 0x00127294
		public string TrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670_UIValue
		{
			get
			{
				short num = (short)1224713328;
				short num2 = num;
				num = (short)1735304304;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1597767680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2106589185;
				if (num != 0)
				{
				}
				num = (short)1313275904;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670.UIValue;
			}
			set
			{
				short num = (short)1239023617;
				if (num != 0)
				{
				}
				num = (short)1057488896;
				short num2 = num;
				num = (short)853745326;
				short num3 = num;
				num = (short)1430331054;
				switch (num3 == num)
				{
				}
				num = (short)1586888704;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670.UIValue = value;
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x060013B6 RID: 5046 RVA: 0x00129148 File Offset: 0x00127348
		public global::AcpBusinessLayer.AcpListField TrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670
		{
			get
			{
				short num = (short)2001479609;
				short num2 = num;
				num = (short)624961465;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2076835840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)487325696;
				if (num != 0)
				{
				}
				num = (short)1728512001;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670;
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x001291F8 File Offset: 0x001273F8
		// (set) Token: 0x060013B8 RID: 5048 RVA: 0x001292AC File Offset: 0x001274AC
		public bool TrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670_Applicable
		{
			get
			{
				short num = (short)1324110393;
				short num2 = num;
				num = (short)1697010233;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1113260032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1090715649;
				if (num != 0)
				{
				}
				num = (short)215285760;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670.Applicable;
			}
			set
			{
				short num = (short)1056732227;
				short num2 = num;
				num = (short)577532995;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1410924544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)461045760;
				if (num != 0)
				{
				}
				num = (short)1321861121;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670.Applicable = value;
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x060013B9 RID: 5049 RVA: 0x00129364 File Offset: 0x00127564
		// (set) Token: 0x060013BA RID: 5050 RVA: 0x0012941C File Offset: 0x0012761C
		public bool TrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670_Valid
		{
			get
			{
				short num = (short)575829605;
				short num2 = num;
				num = (short)1630303845;
				switch (num2 == num)
				{
				default:
				{
					num = (short)238026752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1284636673;
				if (num != 0)
				{
				}
				num = (short)1176174592;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670.Valid;
			}
			set
			{
				short num = (short)2063007144;
				short num2 = num;
				num = (short)814677416;
				switch (num2 == num)
				{
				default:
				{
					num = (short)506003456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1018101761;
				if (num != 0)
				{
				}
				num = (short)789970944;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670.Valid = value;
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x001294D0 File Offset: 0x001276D0
		// (set) Token: 0x060013BC RID: 5052 RVA: 0x00129584 File Offset: 0x00127784
		public bool TrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670_Visible
		{
			get
			{
				short num = (short)263550670;
				short num2 = num;
				num = (short)1739421390;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1511260160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1853816832;
				if (num != 0)
				{
				}
				num = (short)116588545;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670.Visible;
			}
			set
			{
				short num = (short)1760392054;
				short num2 = num;
				num = (short)1002140534;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2082799616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1146224640;
				if (num != 0)
				{
				}
				num = (short)1539244033;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670.Visible = value;
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x00129638 File Offset: 0x00127838
		// (set) Token: 0x060013BE RID: 5054 RVA: 0x001296EC File Offset: 0x001278EC
		public bool TrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670_Editable
		{
			get
			{
				short num = (short)2012963819;
				short num2 = num;
				num = (short)501244907;
				switch (num2 == num)
				{
				default:
				{
					num = (short)984809472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)286457857;
				if (num != 0)
				{
				}
				num = (short)766509056;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670.Editable;
			}
			set
			{
				short num = (short)1840282355;
				short num2 = num;
				num = (short)1781299955;
				switch (num2 == num)
				{
				default:
				{
					num = (short)528023552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1240006656;
				if (num != 0)
				{
				}
				num = (short)7077889;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670.Editable = value;
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x060013BF RID: 5055 RVA: 0x001297A0 File Offset: 0x001279A0
		internal string TrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670_UILabel
		{
			get
			{
				short num = (short)2083752778;
				short num2 = num;
				num = (short)52333386;
				switch (num2 == num)
				{
				default:
				{
					num = (short)603848704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)979435520;
				if (num != 0)
				{
				}
				num = (short)686620673;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670.UIName;
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x060013C0 RID: 5056 RVA: 0x00129858 File Offset: 0x00127A58
		// (set) Token: 0x060013C1 RID: 5057 RVA: 0x0012990C File Offset: 0x00127B0C
		internal bool TrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670_HiddenStatic
		{
			get
			{
				short num = (short)1443764938;
				short num2 = num;
				num = (short)886119114;
				switch (num2 == num)
				{
				default:
				{
					num = (short)19791872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)512098304;
				if (num != 0)
				{
				}
				num = (short)763559937;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670.HiddenStatic;
			}
			set
			{
				short num = (short)772242177;
				short num2 = num;
				num = (short)1934457601;
				switch (num2 == num)
				{
				default:
				{
					num = (short)844234752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1372848129;
				if (num != 0)
				{
				}
				num = (short)1087897600;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670.HiddenStatic = value;
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x060013C2 RID: 5058 RVA: 0x001299C0 File Offset: 0x00127BC0
		// (set) Token: 0x060013C3 RID: 5059 RVA: 0x00129A74 File Offset: 0x00127C74
		internal bool TrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670_HiddenDynamic
		{
			get
			{
				short num = (short)368265898;
				short num2 = num;
				num = (short)1715751594;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1874132992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2081816576;
				if (num != 0)
				{
				}
				num = (short)1387003905;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670.HiddenDynamic;
			}
			set
			{
				short num = (short)2069459688;
				short num2 = num;
				num = (short)560427752;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1709572096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)955645953;
				if (num != 0)
				{
				}
				num = (short)1613496320;
				if (num != 0)
				{
				}
				this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670.HiddenDynamic = value;
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x060013C4 RID: 5060 RVA: 0x00129B28 File Offset: 0x00127D28
		public bool TrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670_HasDiffs
		{
			get
			{
				short num = (short)233419577;
				short num2 = num;
				num = (short)624210745;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1034420224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)184156160;
				if (num != 0)
				{
				}
				num = (short)1218445313;
				if (num != 0)
				{
				}
				return this.trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670._HasDiffs;
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x00129BDC File Offset: 0x00127DDC
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide RefSecureWide
		{
			get
			{
				short num = (short)306118657;
				if (num != 0)
				{
				}
				num = (short)1248526336;
				short num2 = num;
				num = (short)868545330;
				short num3 = num;
				num = (short)672854834;
				switch (num3 == num)
				{
				}
				num = (short)1874067456;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x060013C6 RID: 5062 RVA: 0x00129C9C File Offset: 0x00127E9C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation RefRadioInformation
		{
			get
			{
				short num = (short)1128699695;
				short num2 = num;
				num = (short)98735919;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1599078400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)659226625;
				if (num != 0)
				{
				}
				num = (short)757792768;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			}
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x00129D58 File Offset: 0x00127F58
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
					num2 = (short)1867776004;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_FE;
				case 2:
				{
					for (;;)
					{
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1581982632;
						short num3 = num2;
						num2 = (short)483795880;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_A8;
						}
					}
					IL_A8:
					num2 = (short)1732050944;
					short num4 = num2;
					num2 = (short)19070976;
					if (num2 != 0)
					{
					}
					num2 = (short)934412289;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)1906835456;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_140;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)947716098;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_140;
				}
				goto IL_24;
			}
			IL_FE:
			IL_140:
			num2 = (short)571539457;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)63111171;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000454 RID: 1108
		private global::AcpBusinessLayer.AcpField<bool> trkSysSecureMultikeyASTROOTAR_A7494;

		// Token: 0x04000455 RID: 1109
		private global::AcpBusinessLayer.AcpField<bool> trkSysSecureMultikeyDESXLTxRxDefault_A7833;

		// Token: 0x04000456 RID: 1110
		private global::AcpBusinessLayer.AcpRecRefField trkSysSecureMultikeyDynamicAGKeySelect_A7914;

		// Token: 0x04000457 RID: 1111
		private global::AcpBusinessLayer.AcpRecRefField trkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918;

		// Token: 0x04000458 RID: 1112
		private global::AcpBusinessLayer.AcpRecRefField trkSysSecureMultikeyFailsoftKeySelect_A8012;

		// Token: 0x04000459 RID: 1113
		private global::AcpBusinessLayer.AcpRecRefField trkSysSecureMultikeyInterconnectKeySelect_A8298;

		// Token: 0x0400045A RID: 1114
		private global::AcpBusinessLayer.AcpRecRefField trkSysSecureMultikeyKMFProfileIndex_A8382;

		// Token: 0x0400045B RID: 1115
		private global::AcpBusinessLayer.AcpField<bool> trkSysSecureMultikeyOTARTx_A8676;

		// Token: 0x0400045C RID: 1116
		private global::AcpBusinessLayer.AcpRecRefField trkSysSecureMultikeyPatchKeySelect_A8694;

		// Token: 0x0400045D RID: 1117
		private global::AcpBusinessLayer.AcpRecRefField trkSysSecureMultikeyPrivateCallKeySelect_A8757;

		// Token: 0x0400045E RID: 1118
		private global::AcpBusinessLayer.AcpRecRefField trkSysSecureMultikeySystemWideKeySelect_A9253;

		// Token: 0x0400045F RID: 1119
		private global::AcpBusinessLayer.AcpField<bool> trkSysSecureMultikeyAutoKeyIDRx_A43185;

		// Token: 0x04000460 RID: 1120
		private global::AcpBusinessLayer.AcpListField trkSysSecureMultikeyPrivateCallSecureClearStrapping_43477;

		// Token: 0x04000461 RID: 1121
		private global::AcpBusinessLayer.AcpListField trkSysSecureMultikeyInterconnectSecureClearStrapping_43478;

		// Token: 0x04000462 RID: 1122
		private global::AcpBusinessLayer.AcpListField trkSysSecureMultikeyFailsoftSecureClearStrapping_43479;

		// Token: 0x04000463 RID: 1123
		private global::AcpBusinessLayer.AcpListField trkSysSecureMultikeyDynamicSecureClearStrapping_43489;

		// Token: 0x04000464 RID: 1124
		private global::AcpBusinessLayer.AcpRecRefField trkSysSecureMultikeyVirtualPartnerKeySelect_A43669;

		// Token: 0x04000465 RID: 1125
		private global::AcpBusinessLayer.AcpListField trkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670;
	}
}
