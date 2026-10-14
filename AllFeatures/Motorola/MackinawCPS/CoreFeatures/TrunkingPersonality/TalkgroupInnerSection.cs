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
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality
{
	// Token: 0x020000D0 RID: 208
	[global::System.Serializable]
	public class TalkgroupInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001CCD RID: 7373 RVA: 0x001CB03C File Offset: 0x001C923C
		public TalkgroupInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x001CB058 File Offset: 0x001C9258
		protected TalkgroupInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x001CB070 File Offset: 0x001C9270
		public override void Init()
		{
			int a_ = 6;
			short num = (short)1122238464;
			short num2 = num;
			num = (short)1207845059;
			short num3 = num;
			num = (short)1013268675;
			switch (num3 == num)
			{
			}
			num = (short)1042022400;
			if (num != 0)
			{
			}
			num = (short)1082195969;
			if (num != 0)
			{
			}
			this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001 = new global::AcpBusinessLayer.AcpFrequencyField(170202500, this, global::AllFeatures.CodeplugGuid.b("鏆믈ꃊ鷌꫎ꏐ蟒듔믖님볚꿜냞铠鏢ꏤ蛦胨蟪黬胮韰蟲ꟴ迶뿸觺飼軾琀昂欄搆瀈䘊䔌甎丐划ⴔ✖⤘⨚", a_), global::CommonResources.AcgResources.ID_FAILSOFTRXFREQUENCYMHZ, 0, int.MaxValue, 1);
			this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.DataTransferOrder = 54;
			this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003 = new global::AcpBusinessLayer.AcpFrequencyField(161202500, this, global::AllFeatures.CodeplugGuid.b("鏆믈ꃊ鷌꫎ꏐ蟒듔믖님볚꿜냞铠鏢ꏤ蛦胨蟪黬胮韰蟲ꇴ迶뿸觺飼軾琀昂欄搆瀈䘊䔌甎丐划ⴔ✖⤘⠚", a_), global::CommonResources.AcgResources.ID_FAILSOFTTXFREQUENCYMHZ, 0, int.MaxValue, 1);
			this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.DataTransferOrder = 55;
			this.trkPerTalkgroupTalkgroupFailsoft_A8005 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏆믈ꃊ鷌꫎ꏐ蟒듔믖님볚꿜냞铠鏢뇤蛦藨胪諬鷮黰蛲藴뇶飸鋺釼賾渀攂焄堆䠈㌊㴌㼎␐", a_), global::CommonResources.AcgResources.ID_TALKGROUPFAILSOFT);
			this.trkPerTalkgroupTalkgroupFailsoft_A8005.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerTalkgroupTalkgroupFailsoft_A8005.DataTransferOrder = 11;
			this.trkPerTalkgroupKeySelect_A8365 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鏆믈ꃊ鷌꫎ꏐ蟒듔믖님볚꿜냞铠鏢껤苦部룪裬菮铰郲致ꣶ룸쏺컼짾㐀", a_), global::CommonResources.AcgResources.ID_KEYSELECT, null, null, true, false);
			this.trkPerTalkgroupKeySelect_A8365.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerTalkgroupKeySelect_A8365.DataTransferOrder = 77;
			this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900 = new global::AcpBusinessLayer.AcpFrequencyField(170202500, this, global::AllFeatures.CodeplugGuid.b("鏆믈ꃊ鷌꫎ꏐ蟒듔믖님볚꿜냞铠鏢뛤苦諨蓪菬诮郰臲賴뇶飸鋺釼賾渀攂焄唆焈䴊缌樎怐昒瀔礖稘戚倜圞嬠簢搤ἦဨᬪᴬ", a_), global::CommonResources.AcgResources.ID_SECONDARYFAILSOFTRXFREQMHZ, 0, int.MaxValue, 1);
			this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.DataTransferOrder = 57;
			this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902 = new global::AcpBusinessLayer.AcpFrequencyField(161202500, this, global::AllFeatures.CodeplugGuid.b("鏆믈ꃊ鷌꫎ꏐ蟒듔믖님볚꿜냞铠鏢뛤苦諨蓪菬诮郰臲賴뇶飸鋺釼賾渀攂焄匆焈䴊缌樎怐昒瀔礖稘戚倜圞嬠簢搤ἦဨᬪἬ", a_), global::CommonResources.AcgResources.ID_SECONDARYFAILSOFTTXFREQMHZ, 0, int.MaxValue, 1);
			this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.DataTransferOrder = 58;
			this.trkPerTalkgroupSecureClearStrapping_A9095 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鏆믈ꃊ鷌꫎ꏐ蟒듔믖님볚꿜냞铠鏢뛤苦諨黪鿬諮닰鿲郴零诸꣺觼跾怀猂甄渆月氊刌与⠐⌒Ⱄ∖", a_), global::CommonResources.AcgResources.ID_SECURECLEARSTRAPPING_1, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerTalkgroupSecureClearStrapping_A9095LovStrs);
			this.trkPerTalkgroupSecureClearStrapping_A9095.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerTalkgroupSecureClearStrapping_A9095.DataTransferOrder = 14;
			this.trkPerTalkgroupTalkgroup_A9274 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鏆믈ꃊ鷌꫎ꏐ蟒듔믖님볚꿜냞铠鏢뇤蛦藨胪諬鷮黰蛲藴ꣶ룸싺쿼죾㔀", a_), global::CommonResources.AcgResources.ID_TALKGROUPID, 1, 65534, null, null, 0, 1);
			this.trkPerTalkgroupTalkgroup_A9274.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerTalkgroupTalkgroup_A9274.DataTransferOrder = 52;
			this.trkPerTalkgroupTalkgroup_A9274.ShowHexValue = true;
			this.trkPerTalkgroupTxVoiceSignalType_A9575 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鏆믈ꃊ鷌꫎ꏐ蟒듔믖님볚꿜냞铠鏢뇤鿦뿨蓪蓬賮铰ꃲ鳴郶韸髺釼꯾砀猂怄堆䠈㈊㠌㠎␐", a_), global::CommonResources.AcgResources.ID_TXVOICESIGNALTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerTalkgroupTxVoiceSignalType_A9575LovStrs);
			this.trkPerTalkgroupTxVoiceSignalType_A9575.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerTalkgroupTxVoiceSignalType_A9575.DataTransferOrder = 3;
			this.trkPerTalkgroupTGSystemID_A19715 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鏆믈ꃊ鷌꫎ꏐ蟒듔믖님볚꿜냞铠鏢뇤ꃦ뫨鋪黬鯮铰黲보돶꛸뫺쳼웾㘀㈂〄", a_), global::CommonResources.AcgResources.ID_TGSYSTEMID, 0, 4094, null, null, 0, 1);
			this.trkPerTalkgroupTGSystemID_A19715.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerTalkgroupTGSystemID_A19715.DataTransferOrder = 28;
			this.trkPerTalkgroupTGSystemID_A19715.ShowHexValue = true;
			this.trkPerTalkgroupTGSystemID_A19715.ShowLeadingZeros = true;
			this.trkPerTalkgroupTGWACNID_A19716 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鏆믈ꃊ鷌꫎ꏐ蟒듔믖님볚꿜냞铠鏢뇤ꃦ뻨ꫪ껬ꇮ룰럲ꫴ뛶죸싺쫼컾㜀", a_), global::CommonResources.AcgResources.ID_TGWACNID, 0, 1048574, null, null, 0, 1);
			this.trkPerTalkgroupTGWACNID_A19716.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkPerTalkgroupTGWACNID_A19716.DataTransferOrder = 29;
			this.trkPerTalkgroupTGWACNID_A19716.ShowHexValue = true;
			this.trkPerTalkgroupTGWACNID_A19716.ShowLeadingZeros = true;
			this.trkPerTalkgroupTGSecondaryFailsoft_A19989 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏆믈ꃊ鷌꫎ꏐ蟒듔믖님볚꿜냞铠鏢뇤ꃦ뫨軪軬胮鿰韲铴藶胸뷺鳼雾洀瀂樄愆紈吊䰌㸎⠐⨒ⴔ⸖", a_), global::CommonResources.AcgResources.ID_TGSECONDARYFAILSOFT);
			this.trkPerTalkgroupTGSecondaryFailsoft_A19989.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerTalkgroupTGSecondaryFailsoft_A19989.DataTransferOrder = 9;
			this.trkSysGeneralKeyofTrunkingTalkgroup_A20742 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鏆믈ꃊ黌뛎ꋐ铒냔맖볘꧚볜돞ꫠ蛢鳤裦迨뿪鿬髮鿰飲鳴駶黸꿺鳼鏾樀搂眄栆簈笊刌与⌐⌒∔⌖⬘", a_), global::CommonResources.AcgResources.ID_TALKGROUPNAME, 14);
			this.trkSysGeneralKeyofTrunkingTalkgroup_A20742.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysGeneralKeyofTrunkingTalkgroup_A20742.DataTransferOrder = 32;
			this.trkPerTalkgroupPriorityDispatch_43599 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鏆믈ꃊ鷌꫎ꏐ蟒듔믖님볚꿜냞铠鏢뗤闦胨蓪鿬蛮藰諲뇴黶諸诺鳼课戀欂娄㌆㨈㸊㐌㘎", a_), global::CommonResources.AcgResources.ID_PRIORITYTALKGROUP, new string[]
			{
				global::CommonResources.AcgResources.ID_NONE
			}, new int[1], true, false);
			this.trkPerTalkgroupPriorityDispatch_43599.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerTalkgroupPriorityDispatch_43599.DataTransferOrder = 73;
			this.trkPerTalkgroupPriorityDispatch_43599.ValidateAcrossRecset = true;
			this.trkPerTalkgroupAstroOTARProfileIndex_43687 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鏆믈ꃊ鷌꫎ꏐ蟒듔믖님볚꿜냞铠鏢ꓤ铦鷨駪苬ꃮꗰ닲ꟴꟶ诸铺鯼雾洀昂䰄椆洈渊甌倎┐‒⌔⼖⸘", a_), global::CommonResources.AcgResources.ID_ASTROOTARPROFILEINDEX, new string[]
			{
				global::CommonResources.AcgResources.ID_HOME
			}, new int[1], true, false);
			this.trkPerTalkgroupAstroOTARProfileIndex_43687.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerTalkgroupAstroOTARProfileIndex_43687.DataTransferOrder = 45;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鏆꣈ꟊꛌ꣎ꏐ볒ꃔꟖ", a_);
			base.Id = 10180;
			base.UIName = global::CommonResources.AcgResources.ID_TALKGROUP;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x001CB574 File Offset: 0x001C9774
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)2037121040;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣ꃥ觧菩胫鷭鿯铱胳ꓵ胷볹軻鯽燿省愃栅欇猉䄋䘍樏䴑唓⸕⠗⨙ⴛ", a_)))
					{
						num = (short)237961222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_258;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣뗥跧觩駫鳭闯뇱飳鏵駷裹꿻諽狿持球瘅愇搉欋儍儏⬑␓⼕ⴗ", a_)))
					{
						num = (short)1290862603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A59;
				case 2:
					if (producerFields != null)
					{
						num = (short)1685389319;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C07;
				case 3:
					goto IL_58E;
				case 4:
					this.trkPerTalkgroupTGSecondaryFailsoft_A19989 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣닥꿧맩觫跭鿯鳱郳韵諷菹뫻鿽槿渁眃椅渇縉匋伍ℏ⬑ⴓ⸕℗", a_), global::CommonResources.AcgResources.ID_TGSECONDARYFAILSOFT);
					this.trkPerTalkgroupTGSecondaryFailsoft_A19989.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerTalkgroupTGSecondaryFailsoft_A19989.DataTransferOrder = 9;
					num = (short)2051014673;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)1052442624;
					short num3 = num;
					this.trkPerTalkgroupPriorityDispatch_43599 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣뛥髧菩菫鳭駯蛱跳답釷觹賻鿽瓿愁氃夅㰇㤉㤋㜍⤏", a_), global::CommonResources.AcgResources.ID_PRIORITYTALKGROUP, new string[]
					{
						global::CommonResources.AcgResources.ID_NONE
					}, new int[1], true, false);
					this.trkPerTalkgroupPriorityDispatch_43599.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerTalkgroupPriorityDispatch_43599.DataTransferOrder = 73;
					this.trkPerTalkgroupPriorityDispatch_43599.ValidateAcrossRecset = true;
					num = (short)1328283672;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001 = new global::AcpBusinessLayer.AcpFrequencyField(170202500, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣ꃥ觧菩胫鷭鿯铱胳ꓵ胷볹軻鯽燿省愃栅欇猉䄋䘍樏䴑唓⸕⠗⨙ⴛ", a_), global::CommonResources.AcgResources.ID_FAILSOFTRXFREQUENCYMHZ);
					this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.DataTransferOrder = 54;
					num = (short)795934728;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)1201668096;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_258;
				case 9:
					goto IL_168;
				case 10:
					this.trkPerTalkgroupAstroOTARProfileIndex_43687 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣꟥鯧黩黫臭뿯꛱뗳ꓵꣷ裹鏻飽槿渁愃伅昇渉椋瘍伏☑✓―‗ⴙ", a_), global::CommonResources.AcgResources.ID_ASTROOTARPROFILEINDEX, new string[]
					{
						global::CommonResources.AcgResources.ID_HOME
					}, new int[1], true, false);
					this.trkPerTalkgroupAstroOTARProfileIndex_43687.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerTalkgroupAstroOTARProfileIndex_43687.DataTransferOrder = 45;
					num = (short)550240259;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					this.trkPerTalkgroupSecureClearStrapping_A9095 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣뗥跧觩駫鳭闯뇱飳鏵駷裹꿻諽狿持球瘅愇搉欋儍儏⬑␓⼕ⴗ", a_), global::CommonResources.AcgResources.ID_SECURECLEARSTRAPPING_1, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerTalkgroupSecureClearStrapping_A9095LovStrs);
					this.trkPerTalkgroupSecureClearStrapping_A9095.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerTalkgroupSecureClearStrapping_A9095.DataTransferOrder = 14;
					num = (short)1507459104;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003 = new global::AcpBusinessLayer.AcpFrequencyField(161202500, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣ꃥ觧菩胫鷭鿯铱胳ꋵ胷볹軻鯽燿省愃栅欇猉䄋䘍樏䴑唓⸕⠗⨙⼛", a_), global::CommonResources.AcgResources.ID_FAILSOFTTXFREQUENCYMHZ);
					this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.DataTransferOrder = 55;
					num = (short)1087045650;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_48B;
				case 14:
					goto IL_119;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣닥郧볩菫蟭鏯韱ꟳ鿵鿷铹鷻鋽哿笁球挅圇䬉㔋㬍✏✑", a_)))
					{
						num = (short)195690535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_852;
				case 16:
					switch (0)
					{
					case 0:
						goto IL_F2;
					}
					continue;
				case 17:
					goto IL_20A;
				case 18:
					goto IL_626;
				case 19:
					this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902 = new global::AcpBusinessLayer.AcpFrequencyField(161202500, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣뗥跧觩菫胭铯鏱蛳迵뻷鯹闻鋽珿洁戃爅將爉䨋簍甏挑愓猕瘗礙攛匝栟堡笣朥ဧጩᰫᰭ", a_), global::CommonResources.AcgResources.ID_SECONDARYFAILSOFTTXFREQMHZ);
					this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.DataTransferOrder = 58;
					num = (short)2135294000;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					this.trkPerTalkgroupTGSystemID_A19715 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣닥꿧맩闫鷭蓯韱駳뿵볷ꗹ뷻쿽㧿㔁㔃㌅", a_), global::CommonResources.AcgResources.ID_TGSYSTEMID, null, null, 0, 1);
					this.trkPerTalkgroupTGSystemID_A19715.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkPerTalkgroupTGSystemID_A19715.DataTransferOrder = 28;
					this.trkPerTalkgroupTGSystemID_A19715.ShowHexValue = true;
					this.trkPerTalkgroupTGSystemID_A19715.ShowLeadingZeros = true;
					num = (short)1250951182;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					this.trkSysGeneralKeyofTrunkingTalkgroup_A20742 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ鏓돕뛗뿙껛뿝賟ꧡ臣鿥蟧賩룫鳭藯鳱鿳鿵雷鷹ꣻ鿽泿椁挃琅朇缉簋儍儏‑␓ℕⰗ⠙", a_), global::CommonResources.AcgResources.ID_TALKGROUPNAME, 14);
					this.trkSysGeneralKeyofTrunkingTalkgroup_A20742.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysGeneralKeyofTrunkingTalkgroup_A20742.DataTransferOrder = 32;
					num = (short)659488791;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					this.trkPerTalkgroupKeySelect_A8365 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣귥跧鏩뿫语鳯韱音苵ꟷ믹쓻췽㛿㜁", a_), global::CommonResources.AcgResources.ID_KEYSELECT, null, null, true, false);
					this.trkPerTalkgroupKeySelect_A8365.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerTalkgroupKeySelect_A8365.DataTransferOrder = 77;
					num = (short)1619197993;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					goto IL_4DA;
				case 24:
					goto IL_BBE;
				case 25:
					this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900 = new global::AcpBusinessLayer.AcpFrequencyField(170202500, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣뗥跧觩菫胭铯鏱蛳迵뻷鯹闻鋽珿洁戃爅娇爉䨋簍甏挑愓猕瘗礙攛匝栟堡笣朥ဧጩᰫḭ", a_), global::CommonResources.AcgResources.ID_SECONDARYFAILSOFTRXFREQMHZ);
					this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.DataTransferOrder = 57;
					num = (short)1683554347;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣귥跧鏩뿫语鳯韱音苵ꟷ믹쓻췽㛿㜁", a_)))
					{
						num = (short)935067670;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6CB;
				case 27:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣뛥髧菩菫鳭駯蛱跳답釷觹賻鿽瓿愁氃夅㰇㤉㤋㜍⤏", a_)))
					{
						num = (short)1284243461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BBE;
				case 28:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣ꃥ觧菩胫鷭鿯铱胳ꋵ胷볹軻鯽燿省愃栅欇猉䄋䘍樏䴑唓⸕⠗⨙⼛", a_)))
					{
						num = (short)45219852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_626;
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ鏓돕뛗뿙껛뿝賟ꧡ臣鿥蟧賩룫鳭藯鳱鿳鿵雷鷹ꣻ鿽泿椁挃琅朇缉簋儍儏‑␓ℕⰗ⠙", a_)))
					{
						num = (short)669646869;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4DA;
				case 30:
					goto IL_5ED;
				case 31:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣뗥跧觩菫胭铯鏱蛳迵뻷鯹闻鋽珿洁戃爅娇爉䨋簍甏挑愓猕瘗礙攛匝栟堡笣朥ဧጩᰫḭ", a_)))
					{
						num = (short)1151860761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_808;
				case 32:
					goto IL_A59;
				case 33:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣닥觧蛩蟫觭苯鷱至蛵뻷鯹闻鋽珿洁戃爅圇䬉㐋㸍‏✑", a_)))
					{
						num = (short)145162286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_48B;
				case 34:
					goto IL_852;
				case 35:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣닥꿧맩觫跭鿯鳱郳韵諷菹뫻鿽槿渁眃椅渇縉匋伍ℏ⬑ⴓ⸕℗", a_)))
					{
						num = (short)1184497668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_20A;
				case 36:
				{
					num = (short)231241718;
					short num4 = num;
					num = (short)636778486;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5ED;
					default:
						num = (short)951451649;
						if (num != 0)
						{
						}
						num = (short)1373962240;
						if (num != 0)
						{
						}
						this.trkPerTalkgroupTalkgroup_A9274 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣닥觧蛩蟫觭苯鷱至蛵ꟷ믹엻쳽㟿㘁", a_), global::CommonResources.AcgResources.ID_TALKGROUPID, null, null, 0, 1);
						this.trkPerTalkgroupTalkgroup_A9274.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.trkPerTalkgroupTalkgroup_A9274.DataTransferOrder = 52;
						this.trkPerTalkgroupTalkgroup_A9274.ShowHexValue = true;
						num = (short)944111625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 37:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣꟥鯧黩黫臭뿯꛱뗳ꓵꣷ裹鏻飽槿渁愃伅昇渉椋瘍伏☑✓―‗ⴙ", a_)))
					{
						num = (short)555417610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C07;
				case 38:
					this.trkPerTalkgroupTGWACNID_A19716 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣닥꿧뷩귫귭뻯믱냳꧵맷쯹엻짽ㇿ㐁", a_), global::CommonResources.AcgResources.ID_TGWACNID, null, null, 0, 1);
					this.trkPerTalkgroupTGWACNID_A19716.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkPerTalkgroupTGWACNID_A19716.DataTransferOrder = 29;
					this.trkPerTalkgroupTGWACNID_A19716.ShowHexValue = true;
					this.trkPerTalkgroupTGWACNID_A19716.ShowLeadingZeros = true;
					num = (short)396820527;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 39:
					this.trkPerTalkgroupTxVoiceSignalType_A9575 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣닥郧볩菫蟭鏯韱ꟳ鿵鿷铹鷻鋽哿笁球挅圇䬉㔋㬍✏✑", a_), global::CommonResources.AcgResources.ID_TXVOICESIGNALTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerTalkgroupTxVoiceSignalType_A9575LovStrs);
					this.trkPerTalkgroupTxVoiceSignalType_A9575.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkPerTalkgroupTxVoiceSignalType_A9575.DataTransferOrder = 3;
					num = (short)1265106978;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 40:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣닥꿧맩闫鷭蓯韱駳뿵볷ꗹ뷻쿽㧿㔁㔃㌅", a_)))
					{
						num = (short)1775042580;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_119;
				case 41:
					goto IL_6CB;
				case 42:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣뗥跧觩菫胭铯鏱蛳迵뻷鯹闻鋽珿洁戃爅將爉䨋簍甏挑愓猕瘗礙攛匝栟堡笣朥ဧጩᰫᰭ", a_)))
					{
						num = (short)2071199763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7BC;
				case 43:
					goto IL_808;
				case 44:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣닥꿧뷩귫귭뻯믱냳꧵맷쯹엻짽ㇿ㐁", a_)))
					{
						num = (short)1181548582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_770;
				case 45:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣닥觧蛩蟫觭苯鷱至蛵ꟷ믹엻쳽㟿㘁", a_)))
					{
						num = (short)1315569700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_168;
				case 46:
					this.trkPerTalkgroupTalkgroupFailsoft_A8005 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ黍뗏ꃑ胓럕듗뇙믛곝迟韡铣닥觧蛩蟫觭苯鷱至蛵뻷鯹闻鋽珿洁戃爅圇䬉㐋㸍‏✑", a_), global::CommonResources.AcgResources.ID_TALKGROUPFAILSOFT);
					this.trkPerTalkgroupTalkgroupFailsoft_A8005.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerTalkgroupTalkgroupFailsoft_A8005.DataTransferOrder = 11;
					num = (short)534904845;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 47:
					goto IL_770;
				case 48:
					goto IL_7BC;
				}
				IL_F2:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1849098270;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_119:
				num = (short)366739500;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_168:
				num = (short)1657405455;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_20A:
				num = (short)1279262749;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_258:
				num = (short)782827548;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_48B:
				num = (short)788267034;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4DA:
				num = (short)1088815131;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5ED:
				num = (short)1779892226;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_626:
				num = (short)1170407457;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6CB:
				num = (short)1179648031;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_770:
				num = (short)1473839139;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7BC:
				num = (short)515702785;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_808:
				num = (short)2030698538;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_852:
				num = (short)1584005160;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A59:
				num = (short)475267117;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BBE:
				num = (short)129564709;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_58E:
			IL_C07:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鳇ꯉꃋꗍ럏ꃑ믓ꏕ꣗", a_);
			base.Id = 10180;
			base.UIName = global::CommonResources.AcgResources.ID_TALKGROUP;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x001CC1BC File Offset: 0x001CA3BC
		public override void PopulateReferences()
		{
			short num = (short)847380480;
			short num2 = num;
			num = (short)1461593267;
			short num3 = num;
			num = (short)1609704627;
			switch (num3 == num)
			{
			}
			num = (short)867434496;
			if (num != 0)
			{
			}
			num = (short)1456078849;
			if (num != 0)
			{
			}
			this.trkPerTalkgroupPriorityDispatch_43599.SetRecset(base.ParentRecset);
			this.trkPerTalkgroupAstroOTARProfileIndex_43687.SetRecset(this.a(2055));
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.TalkgroupAstroOtarProfileIndexIsEnable(this);
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x001CC294 File Offset: 0x001CA494
		public override void DropReferences()
		{
			short num = (short)1293287424;
			short num2 = num;
			num = (short)1893971683;
			short num3 = num;
			num = (short)1051899619;
			switch (num3 == num)
			{
			}
			num = (short)1438973953;
			if (num != 0)
			{
			}
			num = (short)676659200;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x001CC340 File Offset: 0x001CA540
		public override void SetConstraints()
		{
			short num = (short)1657405440;
			short num2 = num;
			num = (short)608079879;
			short num3 = num;
			num = (short)1560383495;
			switch (num3 == num)
			{
			}
			num = (short)1148715009;
			if (num != 0)
			{
			}
			num = (short)2006843392;
			if (num != 0)
			{
			}
			this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkTypeIIObtFsIsEnabledAndApplicable);
			this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conTGFailsoftRxFreqIsValid);
			this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conSetValueTGFailsoftTxFrequency);
			this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conTGFailsoftTxFreqApplicability);
			this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conTGFailsoftTxFreqIsValid);
			this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conTGFailsoftTxFreqApplicabilityEditabl);
			this.trkPerTalkgroupTalkgroupFailsoft_A8005.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConFsIsTlkGrp);
			this.trkPerTalkgroupKeySelect_A8365.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConSecOpHwAndTGNotClearOrSecOpAdpAndTGNotClearAndASTRO25);
			this.trkPerTalkgroupKeySelect_A8365.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConKeySelect8365IsValid);
			this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTG2ndFsEnAndTkGrpFsEnAndFsTypeTkGrp);
			this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conTGFailsoftSecRxFreqIsValid);
			this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conSetValueTGSecondaryFailsoftTxFrequency);
			this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conTGSecondaryFailsoftTxFreqApplicability);
			this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conTGFailsoftSecTxFreqIsValid);
			this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conTGSecondaryFailsoftTxFreqApplicabilityEditbl);
			this.trkPerTalkgroupSecureClearStrapping_A9095.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConSecOpHwOrSecOpAdpAndASTRO25);
			this.trkPerTalkgroupSecureClearStrapping_A9095.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTgStrpIsClrAndTxVSigTypNotAngOrBndWdhNot125);
			this.trkPerTalkgroupTalkgroup_A9274.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTlkgrpValid);
			this.trkPerTalkgroupTxVoiceSignalType_A9575.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkPerIsTypeII);
			this.trkPerTalkgroupTxVoiceSignalType_A9575.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkPerTxIsTypeIINot900MDigital);
			this.trkPerTalkgroupTGSystemID_A19715.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkPerIsAstro25AndCvrTypeIsWACN);
			this.trkPerTalkgroupTGWACNID_A19716.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConWacnIDBasedOnSystemTypeAndCovType);
			this.trkPerTalkgroupTGSecondaryFailsoft_A19989.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkTypeIIObtFsIsEnabledAndApplicable);
			this.trkPerTalkgroupPriorityDispatch_43599.ValidateAcrossRecset = true;
			this.trkPerTalkgroupPriorityDispatch_43599.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkPerIsASTRO25DVRSProfileDisabled);
			this.trkPerTalkgroupAstroOTARProfileIndex_43687.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.TalkgroupAstroOtarProfileIndexIsEnable);
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x001CC634 File Offset: 0x001CA834
		public override void SetupDependencies()
		{
			switch (0)
			{
			case 0:
				goto IL_8F;
			}
			short num;
			int num4;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
			for (;;)
			{
				IL_0A:
				num = (short)1180245136;
				short num2 = num;
				num = (short)594091152;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1873412096;
					if (num != 0)
					{
					}
					num = (short)267714560;
					short num3 = num;
					switch (num4)
					{
					case 0:
						if (trunkingSystem != null)
						{
							num = (short)1842282497;
							if (num != 0)
							{
							}
							num = (short)108134402;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						return;
					case 2:
						goto IL_688;
					}
					goto IL_8F;
				}
				}
				IL_688:
				this.trkPerTalkgroupAstroOTARProfileIndex_43687.AddDependentObject(trunkingSystem.General.TrkSysGeneralCoverageType_A7782);
				num = (short)2047016961;
				num4 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_8F:
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.AddDependentObject(this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001);
			trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.AddDependentObject(this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.AddDependentObject(this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001);
			this.trkPerTalkgroupTalkgroupFailsoft_A8005.AddDependentObject(this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001);
			trunkingPersonality.General.TrkPerGeneralFailsoftType_A8599.AddDependentObject(this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001);
			trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001);
			this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.AddDependentObject(this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.AddDependentObject(this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003);
			this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.AddDependentObject(this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003);
			trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.AddDependentObject(this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.AddDependentObject(this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003);
			this.trkPerTalkgroupTalkgroupFailsoft_A8005.AddDependentObject(this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003);
			trunkingPersonality.General.TrkPerGeneralFailsoftType_A8599.AddDependentObject(this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003);
			trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003);
			trunkingPersonality.General.TrkPerGeneralFailsoftType_A8599.AddDependentObject(this.trkPerTalkgroupTalkgroupFailsoft_A8005);
			this.trkPerTalkgroupSecureClearStrapping_A9095.AddDependentObject(this.trkPerTalkgroupKeySelect_A8365);
			trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerTalkgroupKeySelect_A8365);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkPerTalkgroupKeySelect_A8365);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.trkPerTalkgroupKeySelect_A8365);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.trkPerTalkgroupKeySelect_A8365);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.trkPerTalkgroupKeySelect_A8365);
			this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.trkPerTalkgroupKeySelect_A8365);
			this.trkPerTalkgroupTGSecondaryFailsoft_A19989.AddDependentObject(this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900);
			this.trkPerTalkgroupTalkgroupFailsoft_A8005.AddDependentObject(this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900);
			trunkingPersonality.General.TrkPerGeneralFailsoftType_A8599.AddDependentObject(this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.AddDependentObject(this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900);
			trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.AddDependentObject(this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.AddDependentObject(this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900);
			trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900);
			this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.AddDependentObject(this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.AddDependentObject(this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902);
			this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.AddDependentObject(this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902);
			trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.AddDependentObject(this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.AddDependentObject(this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902);
			this.trkPerTalkgroupTGSecondaryFailsoft_A19989.AddDependentObject(this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902);
			this.trkPerTalkgroupTalkgroupFailsoft_A8005.AddDependentObject(this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902);
			trunkingPersonality.General.TrkPerGeneralFailsoftType_A8599.AddDependentObject(this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902);
			trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902);
			trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerTalkgroupSecureClearStrapping_A9095);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkPerTalkgroupSecureClearStrapping_A9095);
			trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerTalkgroupSecureClearStrapping_A9095);
			this.trkPerTalkgroupTxVoiceSignalType_A9575.AddDependentObject(this.trkPerTalkgroupSecureClearStrapping_A9095);
			trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerTalkgroupTalkgroup_A9274);
			trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerTalkgroupTalkgroup_A9274);
			trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerTalkgroupTxVoiceSignalType_A9575);
			trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerTalkgroupTxVoiceSignalType_A9575);
			trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerTalkgroupTGSystemID_A19715);
			trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerTalkgroupTGSystemID_A19715);
			trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerTalkgroupTGWACNID_A19716);
			trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerTalkgroupTGWACNID_A19716);
			this.trkPerTalkgroupTalkgroupFailsoft_A8005.AddDependentObject(this.trkPerTalkgroupTGSecondaryFailsoft_A19989);
			trunkingPersonality.General.TrkPerGeneralFailsoftType_A8599.AddDependentObject(this.trkPerTalkgroupTGSecondaryFailsoft_A19989);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkPerTalkgroupAstroOTARProfileIndex_43687);
			this.trkPerTalkgroupTGSystemID_A19715.AddDependentObject(this.trkPerTalkgroupAstroOTARProfileIndex_43687);
			this.trkPerTalkgroupTGWACNID_A19716.AddDependentObject(this.trkPerTalkgroupAstroOTARProfileIndex_43687);
			trunkingSystem = ((base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality).General.TrkPerGeneralSystem_A9237.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
			num = (short)611844096;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06001CD5 RID: 7381 RVA: 0x001CCCFC File Offset: 0x001CAEFC
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner EncryptionKeyListInnerSectionForTrkPerTalkgroupKeySelect_A8365
		{
			get
			{
				short num = (short)896204800;
				short num2 = num;
				num = (short)2080125625;
				short num3 = num;
				num = (short)932262585;
				switch (num3 == num)
				{
				}
				num = (short)1950351361;
				if (num != 0)
				{
				}
				num = (short)14811136;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupKeySelect_A8365.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner;
			}
		}

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x001CCDB8 File Offset: 0x001CAFB8
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInner TalkgroupInnerSectionForTrkPerTalkgroupPriorityDispatch_43599
		{
			get
			{
				short num = (short)660471808;
				short num2 = num;
				num = (short)1546755959;
				short num3 = num;
				num = (short)283418487;
				switch (num3 == num)
				{
				}
				num = (short)2069561345;
				if (num != 0)
				{
				}
				num = (short)345702400;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupPriorityDispatch_43599.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInner;
			}
		}

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06001CD7 RID: 7383 RVA: 0x001CCE70 File Offset: 0x001CB070
		public global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile SecureKMFProfileForTrkPerTalkgroupAstroOTARProfileIndex_43687
		{
			get
			{
				short num = (short)1756626944;
				short num2 = num;
				num = (short)141271946;
				short num3 = num;
				num = (short)1031119754;
				switch (num3 == num)
				{
				}
				num = (short)505741313;
				if (num != 0)
				{
				}
				num = (short)332005376;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupAstroOTARProfileIndex_43687.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
			}
		}

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x001CCF28 File Offset: 0x001CB128
		public bool HasDiffs
		{
			get
			{
				short num = (short)821832924;
				short num2 = num;
				num = (short)144977116;
				switch (num2 == num)
				{
				}
				num = (short)1659174913;
				if (num != 0)
				{
				}
				num = (short)521732096;
				short num3 = num;
				num = (short)971309056;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x06001CD9 RID: 7385 RVA: 0x001CCFDC File Offset: 0x001CB1DC
		// (set) Token: 0x06001CDA RID: 7386 RVA: 0x001CD094 File Offset: 0x001CB294
		public int TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001Value
		{
			get
			{
				short num = (short)825971934;
				short num2 = num;
				num = (short)1876448478;
				switch (num2 == num)
				{
				}
				num = (short)985137153;
				if (num != 0)
				{
				}
				num = (short)2056454144;
				short num3 = num;
				num = (short)97124352;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.Value;
			}
			set
			{
				short num = (short)2141230922;
				short num2 = num;
				num = (short)907843402;
				switch (num2 == num)
				{
				}
				num = (short)146079745;
				if (num != 0)
				{
				}
				num = (short)1067646976;
				short num3 = num;
				num = (short)1274347520;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.Value = value;
			}
		}

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x06001CDB RID: 7387 RVA: 0x001CD14C File Offset: 0x001CB34C
		// (set) Token: 0x06001CDC RID: 7388 RVA: 0x001CD204 File Offset: 0x001CB404
		public string TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001_UIValue
		{
			get
			{
				short num = (short)1438156079;
				short num2 = num;
				num = (short)1171227951;
				switch (num2 == num)
				{
				}
				num = (short)1644822528;
				if (num != 0)
				{
				}
				num = (short)239337472;
				short num3 = num;
				num = (short)303104001;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.UIValue;
			}
			set
			{
				short num = (short)1065202424;
				short num2 = num;
				num = (short)2001908472;
				switch (num2 == num)
				{
				}
				num = (short)884408321;
				if (num != 0)
				{
				}
				num = (short)808058880;
				short num3 = num;
				num = (short)1324679168;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.UIValue = value;
			}
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06001CDD RID: 7389 RVA: 0x001CD2BC File Offset: 0x001CB4BC
		public global::AcpBusinessLayer.AcpFrequencyField TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001
		{
			get
			{
				short num = (short)1332540066;
				short num2 = num;
				num = (short)524481186;
				switch (num2 == num)
				{
				}
				num = (short)1095303169;
				if (num != 0)
				{
				}
				num = (short)1018626048;
				short num3 = num;
				num = (short)1846476800;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001;
			}
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06001CDE RID: 7390 RVA: 0x001CD370 File Offset: 0x001CB570
		// (set) Token: 0x06001CDF RID: 7391 RVA: 0x001CD428 File Offset: 0x001CB628
		internal int TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001Min
		{
			get
			{
				short num = (short)1788712478;
				short num2 = num;
				num = (short)197105182;
				switch (num2 == num)
				{
				}
				num = (short)499515392;
				if (num != 0)
				{
				}
				num = (short)2012020736;
				short num3 = num;
				num = (short)247398401;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.Min;
			}
			set
			{
				short num = (short)1360265217;
				if (num != 0)
				{
				}
				num = (short)2079448908;
				short num2 = num;
				num = (short)700899148;
				switch (num2 == num)
				{
				}
				num = (short)627113984;
				short num3 = num;
				num = (short)491520000;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.Min = value;
			}
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x001CD4DC File Offset: 0x001CB6DC
		// (set) Token: 0x06001CE1 RID: 7393 RVA: 0x001CD590 File Offset: 0x001CB790
		internal int TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001Max
		{
			get
			{
				short num = (short)844660947;
				short num2 = num;
				num = (short)1365410003;
				switch (num2 == num)
				{
				}
				num = (short)1721630721;
				if (num != 0)
				{
				}
				num = (short)193069056;
				short num3 = num;
				num = (short)855638016;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.Max;
			}
			set
			{
				short num = (short)476264270;
				short num2 = num;
				num = (short)1915238222;
				switch (num2 == num)
				{
				}
				num = (short)135921665;
				if (num != 0)
				{
				}
				num = (short)291766272;
				short num3 = num;
				num = (short)411828224;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.Max = value;
			}
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x001CD648 File Offset: 0x001CB848
		// (set) Token: 0x06001CE3 RID: 7395 RVA: 0x001CD6FC File Offset: 0x001CB8FC
		internal int TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001Step
		{
			get
			{
				short num = (short)125068671;
				short num2 = num;
				num = (short)490628479;
				switch (num2 == num)
				{
				}
				num = (short)387186689;
				if (num != 0)
				{
				}
				num = (short)393412608;
				short num3 = num;
				num = (short)354549760;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.StepSize;
			}
			set
			{
				short num = (short)754517786;
				short num2 = num;
				num = (short)446760730;
				switch (num2 == num)
				{
				}
				num = (short)1800732672;
				if (num != 0)
				{
				}
				num = (short)1629290496;
				short num3 = num;
				num = (short)909115393;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.StepSize = value;
			}
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x001CD7B4 File Offset: 0x001CB9B4
		// (set) Token: 0x06001CE5 RID: 7397 RVA: 0x001CD868 File Offset: 0x001CBA68
		public bool TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001_Applicable
		{
			get
			{
				short num = (short)1272622095;
				short num2 = num;
				num = (short)1344973839;
				switch (num2 == num)
				{
				}
				num = (short)814284801;
				if (num != 0)
				{
				}
				num = (short)1360789504;
				short num3 = num;
				num = (short)1598685184;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.Applicable;
			}
			set
			{
				short num = (short)303431681;
				if (num != 0)
				{
				}
				num = (short)1062847616;
				short num2 = num;
				num = (short)187352192;
				switch (num2 == num)
				{
				}
				num = (short)954597376;
				short num3 = num;
				num = (short)1140981760;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.Applicable = value;
			}
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x001CD920 File Offset: 0x001CBB20
		// (set) Token: 0x06001CE7 RID: 7399 RVA: 0x001CD9D4 File Offset: 0x001CBBD4
		public bool TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001_Valid
		{
			get
			{
				short num = (short)1186986867;
				short num2 = num;
				num = (short)784923507;
				switch (num2 == num)
				{
				}
				num = (short)3932160;
				if (num != 0)
				{
				}
				num = (short)955318272;
				short num3 = num;
				num = (short)888668161;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.Valid;
			}
			set
			{
				short num = (short)381019582;
				short num2 = num;
				num = (short)257353150;
				switch (num2 == num)
				{
				}
				num = (short)1732247552;
				if (num != 0)
				{
				}
				num = (short)1988231168;
				short num3 = num;
				num = (short)1061879809;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.Valid = value;
			}
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x001CDA88 File Offset: 0x001CBC88
		// (set) Token: 0x06001CE9 RID: 7401 RVA: 0x001CDB40 File Offset: 0x001CBD40
		public bool TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001_Visible
		{
			get
			{
				short num = (short)1578499854;
				short num2 = num;
				num = (short)207617806;
				switch (num2 == num)
				{
				}
				num = (short)1701969921;
				if (num != 0)
				{
				}
				num = (short)70975488;
				short num3 = num;
				num = (short)934608896;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.Visible;
			}
			set
			{
				short num = (short)1214375046;
				short num2 = num;
				num = (short)1542120582;
				switch (num2 == num)
				{
				}
				num = (short)2003042305;
				if (num != 0)
				{
				}
				num = (short)2091974656;
				short num3 = num;
				num = (short)147128320;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.Visible = value;
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06001CEA RID: 7402 RVA: 0x001CDBF4 File Offset: 0x001CBDF4
		// (set) Token: 0x06001CEB RID: 7403 RVA: 0x001CDCA8 File Offset: 0x001CBEA8
		public bool TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001_Editable
		{
			get
			{
				short num = (short)624384490;
				short num2 = num;
				num = (short)1670339050;
				switch (num2 == num)
				{
				}
				num = (short)1829765121;
				if (num != 0)
				{
				}
				num = (short)1071841280;
				short num3 = num;
				num = (short)1163198464;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.Editable;
			}
			set
			{
				short num = (short)2006126411;
				short num2 = num;
				num = (short)956239691;
				switch (num2 == num)
				{
				}
				num = (short)1317601280;
				if (num != 0)
				{
				}
				num = (short)2142568448;
				short num3 = num;
				num = (short)670892033;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.Editable = value;
			}
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06001CEC RID: 7404 RVA: 0x001CDD5C File Offset: 0x001CBF5C
		internal string TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001_UILabel
		{
			get
			{
				short num = (short)696057857;
				if (num != 0)
				{
				}
				num = (short)2137560572;
				short num2 = num;
				num = (short)2076546556;
				switch (num2 == num)
				{
				}
				num = (short)464453632;
				short num3 = num;
				num = (short)759431168;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.UIName;
			}
		}

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06001CED RID: 7405 RVA: 0x001CDE14 File Offset: 0x001CC014
		// (set) Token: 0x06001CEE RID: 7406 RVA: 0x001CDEC8 File Offset: 0x001CC0C8
		internal bool TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001_HiddenStatic
		{
			get
			{
				short num = (short)1718717601;
				short num2 = num;
				num = (short)458394785;
				switch (num2 == num)
				{
				}
				num = (short)456327169;
				if (num != 0)
				{
				}
				num = (short)2089156608;
				short num3 = num;
				num = (short)2062090240;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.HiddenStatic;
			}
			set
			{
				short num = (short)536805377;
				if (num != 0)
				{
				}
				num = (short)1389772189;
				short num2 = num;
				num = (short)501300637;
				switch (num2 == num)
				{
				}
				num = (short)122093568;
				short num3 = num;
				num = (short)1296957440;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.HiddenStatic = value;
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x06001CEF RID: 7407 RVA: 0x001CDF7C File Offset: 0x001CC17C
		// (set) Token: 0x06001CF0 RID: 7408 RVA: 0x001CE030 File Offset: 0x001CC230
		internal bool TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001_HiddenDynamic
		{
			get
			{
				short num = (short)1644153386;
				short num2 = num;
				num = (short)2033568298;
				switch (num2 == num)
				{
				}
				num = (short)2069495808;
				if (num != 0)
				{
				}
				num = (short)237109248;
				short num3 = num;
				num = (short)1115750401;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.HiddenDynamic;
			}
			set
			{
				short num = (short)448724993;
				if (num != 0)
				{
				}
				num = (short)468398930;
				short num2 = num;
				num = (short)1894921042;
				switch (num2 == num)
				{
				}
				num = (short)2030764032;
				short num3 = num;
				num = (short)1384382464;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001.HiddenDynamic = value;
			}
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x06001CF1 RID: 7409 RVA: 0x001CE0E4 File Offset: 0x001CC2E4
		public bool TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001_HasDiffs
		{
			get
			{
				short num = (short)1268449281;
				if (num != 0)
				{
				}
				num = (short)146666260;
				short num2 = num;
				num = (short)32699156;
				switch (num2 == num)
				{
				}
				num = (short)1802764288;
				short num3 = num;
				num = (short)1834418176;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupFailsoftRxFrequencyMHz_A8001._HasDiffs;
			}
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x001CE198 File Offset: 0x001CC398
		// (set) Token: 0x06001CF3 RID: 7411 RVA: 0x001CE24C File Offset: 0x001CC44C
		public int TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003Value
		{
			get
			{
				short num = (short)1224409089;
				if (num != 0)
				{
				}
				num = (short)1723539878;
				short num2 = num;
				num = (short)45162918;
				switch (num2 == num)
				{
				}
				num = (short)235798528;
				short num3 = num;
				num = (short)13762560;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.Value;
			}
			set
			{
				short num = (short)1358561281;
				if (num != 0)
				{
				}
				num = (short)25882131;
				short num2 = num;
				num = (short)813428243;
				switch (num2 == num)
				{
				}
				num = (short)1818624000;
				short num3 = num;
				num = (short)42860544;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.Value = value;
			}
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x06001CF4 RID: 7412 RVA: 0x001CE304 File Offset: 0x001CC504
		// (set) Token: 0x06001CF5 RID: 7413 RVA: 0x001CE3B8 File Offset: 0x001CC5B8
		public string TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003_UIValue
		{
			get
			{
				short num = (short)1892551205;
				short num2 = num;
				num = (short)894241317;
				switch (num2 == num)
				{
				}
				num = (short)1493762048;
				if (num != 0)
				{
				}
				num = (short)945160192;
				short num3 = num;
				num = (short)770506753;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.UIValue;
			}
			set
			{
				short num = (short)2102460468;
				short num2 = num;
				num = (short)1763442740;
				switch (num2 == num)
				{
				}
				num = (short)818479105;
				if (num != 0)
				{
				}
				num = (short)1993408512;
				short num3 = num;
				num = (short)1489240064;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.UIValue = value;
			}
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x001CE46C File Offset: 0x001CC66C
		public global::AcpBusinessLayer.AcpFrequencyField TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003
		{
			get
			{
				short num = (short)1667624070;
				short num2 = num;
				num = (short)1164635270;
				switch (num2 == num)
				{
				}
				num = (short)977666049;
				if (num != 0)
				{
				}
				num = (short)1078919168;
				short num3 = num;
				num = (short)627245056;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003;
			}
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x06001CF7 RID: 7415 RVA: 0x001CE51C File Offset: 0x001CC71C
		// (set) Token: 0x06001CF8 RID: 7416 RVA: 0x001CE5D0 File Offset: 0x001CC7D0
		internal int TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003Min
		{
			get
			{
				short num = (short)1500955500;
				short num2 = num;
				num = (short)1224852332;
				switch (num2 == num)
				{
				}
				num = (short)2017132545;
				if (num != 0)
				{
				}
				num = (short)455540736;
				short num3 = num;
				num = (short)1601110016;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.Min;
			}
			set
			{
				short num = (short)1605057265;
				short num2 = num;
				num = (short)2026781425;
				switch (num2 == num)
				{
				}
				num = (short)1970601984;
				if (num != 0)
				{
				}
				num = (short)2074083328;
				short num3 = num;
				num = (short)1392771073;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.Min = value;
			}
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06001CF9 RID: 7417 RVA: 0x001CE688 File Offset: 0x001CC888
		// (set) Token: 0x06001CFA RID: 7418 RVA: 0x001CE73C File Offset: 0x001CC93C
		internal int TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003Max
		{
			get
			{
				short num = (short)739217168;
				short num2 = num;
				num = (short)1063620368;
				switch (num2 == num)
				{
				}
				num = (short)1276116993;
				if (num != 0)
				{
				}
				num = (short)118292480;
				short num3 = num;
				num = (short)1226244096;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.Max;
			}
			set
			{
				short num = (short)914098841;
				short num2 = num;
				num = (short)1745816217;
				switch (num2 == num)
				{
				}
				num = (short)910622721;
				if (num != 0)
				{
				}
				num = (short)1713438720;
				short num3 = num;
				num = (short)705363968;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.Max = value;
			}
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06001CFB RID: 7419 RVA: 0x001CE7F0 File Offset: 0x001CC9F0
		// (set) Token: 0x06001CFC RID: 7420 RVA: 0x001CE8A4 File Offset: 0x001CCAA4
		internal int TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003Step
		{
			get
			{
				short num = (short)265285411;
				short num2 = num;
				num = (short)1337782051;
				switch (num2 == num)
				{
				}
				num = (short)2017853440;
				if (num != 0)
				{
				}
				num = (short)1389101056;
				short num3 = num;
				num = (short)1340276737;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.StepSize;
			}
			set
			{
				short num = (short)1101685636;
				short num2 = num;
				num = (short)882205572;
				switch (num2 == num)
				{
				}
				num = (short)2021261313;
				if (num != 0)
				{
				}
				num = (short)530251776;
				short num3 = num;
				num = (short)532611072;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.StepSize = value;
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06001CFD RID: 7421 RVA: 0x001CE958 File Offset: 0x001CCB58
		// (set) Token: 0x06001CFE RID: 7422 RVA: 0x001CEA0C File Offset: 0x001CCC0C
		public bool TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003_Applicable
		{
			get
			{
				short num = (short)1643768501;
				short num2 = num;
				num = (short)188017333;
				switch (num2 == num)
				{
				}
				num = (short)1187643392;
				if (num != 0)
				{
				}
				num = (short)1455095808;
				short num3 = num;
				num = (short)1970864129;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.Applicable;
			}
			set
			{
				short num = (short)1559764751;
				short num2 = num;
				num = (short)1685397263;
				switch (num2 == num)
				{
				}
				num = (short)2082996225;
				if (num != 0)
				{
				}
				num = (short)1379532800;
				short num3 = num;
				num = (short)372441088;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.Applicable = value;
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06001CFF RID: 7423 RVA: 0x001CEAC4 File Offset: 0x001CCCC4
		// (set) Token: 0x06001D00 RID: 7424 RVA: 0x001CEB7C File Offset: 0x001CCD7C
		public bool TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003_Valid
		{
			get
			{
				short num = (short)1463188806;
				short num2 = num;
				num = (short)1155956038;
				switch (num2 == num)
				{
				}
				num = (short)1807876097;
				if (num != 0)
				{
				}
				num = (short)1839398912;
				short num3 = num;
				num = (short)1625882624;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.Valid;
			}
			set
			{
				short num = (short)1714006329;
				short num2 = num;
				num = (short)357017913;
				switch (num2 == num)
				{
				}
				num = (short)907673601;
				if (num != 0)
				{
				}
				num = (short)1906180096;
				if (num != 0)
				{
				}
				num = (short)1910112256;
				short num3 = num;
				this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.Valid = value;
			}
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06001D01 RID: 7425 RVA: 0x001CEC34 File Offset: 0x001CCE34
		// (set) Token: 0x06001D02 RID: 7426 RVA: 0x001CECE8 File Offset: 0x001CCEE8
		public bool TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003_Visible
		{
			get
			{
				short num = (short)2129038684;
				short num2 = num;
				num = (short)968068444;
				switch (num2 == num)
				{
				}
				num = (short)1367474177;
				if (num != 0)
				{
				}
				num = (short)632553472;
				if (num != 0)
				{
				}
				num = (short)1494745088;
				short num3 = num;
				return this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.Visible;
			}
			set
			{
				short num = (short)1740145575;
				short num2 = num;
				num = (short)1733526439;
				switch (num2 == num)
				{
				}
				num = (short)1866399744;
				if (num != 0)
				{
				}
				num = (short)897515521;
				if (num != 0)
				{
				}
				num = (short)1884422144;
				short num3 = num;
				this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.Visible = value;
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06001D03 RID: 7427 RVA: 0x001CEDA0 File Offset: 0x001CCFA0
		// (set) Token: 0x06001D04 RID: 7428 RVA: 0x001CEE54 File Offset: 0x001CD054
		public bool TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003_Editable
		{
			get
			{
				short num = (short)1792143250;
				short num2 = num;
				num = (short)45543314;
				switch (num2 == num)
				{
				}
				num = (short)1746337793;
				if (num != 0)
				{
				}
				num = (short)630652928;
				if (num != 0)
				{
				}
				num = (short)1600782336;
				short num3 = num;
				return this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.Editable;
			}
			set
			{
				short num = (short)274661377;
				if (num != 0)
				{
				}
				num = (short)770314620;
				short num2 = num;
				num = (short)1788744060;
				switch (num2 == num)
				{
				}
				num = (short)726532096;
				if (num != 0)
				{
				}
				num = (short)1321730048;
				short num3 = num;
				this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.Editable = value;
			}
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06001D05 RID: 7429 RVA: 0x001CEF0C File Offset: 0x001CD10C
		internal string TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003_UILabel
		{
			get
			{
				short num = (short)937706699;
				short num2 = num;
				num = (short)1262044363;
				switch (num2 == num)
				{
				}
				num = (short)1256390656;
				if (num != 0)
				{
				}
				num = (short)1287389185;
				if (num != 0)
				{
				}
				num = (short)86769664;
				short num3 = num;
				return this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.UIName;
			}
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06001D06 RID: 7430 RVA: 0x001CEFC0 File Offset: 0x001CD1C0
		// (set) Token: 0x06001D07 RID: 7431 RVA: 0x001CF074 File Offset: 0x001CD274
		internal bool TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003_HiddenStatic
		{
			get
			{
				short num = (short)172397748;
				short num2 = num;
				num = (short)262444212;
				switch (num2 == num)
				{
				}
				num = (short)1628569601;
				if (num != 0)
				{
				}
				num = (short)44564480;
				if (num != 0)
				{
				}
				num = (short)2129461248;
				short num3 = num;
				return this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.HiddenStatic;
			}
			set
			{
				short num = (short)2066219009;
				if (num != 0)
				{
				}
				num = (short)366588789;
				short num2 = num;
				num = (short)1316991861;
				switch (num2 == num)
				{
				}
				num = (short)914423808;
				if (num != 0)
				{
				}
				num = (short)2002386944;
				short num3 = num;
				this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.HiddenStatic = value;
			}
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06001D08 RID: 7432 RVA: 0x001CF128 File Offset: 0x001CD328
		// (set) Token: 0x06001D09 RID: 7433 RVA: 0x001CF1E0 File Offset: 0x001CD3E0
		internal bool TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003_HiddenDynamic
		{
			get
			{
				short num = (short)1847404864;
				short num2 = num;
				num = (short)384772416;
				switch (num2 == num)
				{
				}
				num = (short)1300037632;
				if (num != 0)
				{
				}
				num = (short)401735681;
				if (num != 0)
				{
				}
				num = (short)1569914880;
				short num3 = num;
				return this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.HiddenDynamic;
			}
			set
			{
				short num = (short)2116800804;
				short num2 = num;
				num = (short)1167642916;
				switch (num2 == num)
				{
				}
				num = (short)1941372929;
				if (num != 0)
				{
				}
				num = (short)344129536;
				if (num != 0)
				{
				}
				num = (short)782958592;
				short num3 = num;
				this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003.HiddenDynamic = value;
			}
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06001D0A RID: 7434 RVA: 0x001CF298 File Offset: 0x001CD498
		public bool TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003_HasDiffs
		{
			get
			{
				short num = (short)1596559608;
				short num2 = num;
				num = (short)148607224;
				switch (num2 == num)
				{
				}
				num = (short)511836161;
				if (num != 0)
				{
				}
				num = (short)713949184;
				if (num != 0)
				{
				}
				num = (short)604504064;
				short num3 = num;
				return this.trkPerTalkgroupFailsoftTxFrequencyMHz_A8003._HasDiffs;
			}
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x001CF34C File Offset: 0x001CD54C
		// (set) Token: 0x06001D0C RID: 7436 RVA: 0x001CF400 File Offset: 0x001CD600
		public bool TrkPerTalkgroupTalkgroupFailsoft_A8005Value
		{
			get
			{
				short num = (short)1859059713;
				if (num != 0)
				{
				}
				num = (short)1442199561;
				short num2 = num;
				num = (short)226637833;
				switch (num2 == num)
				{
				}
				num = (short)60096512;
				if (num != 0)
				{
				}
				num = (short)2042888192;
				short num3 = num;
				return this.trkPerTalkgroupTalkgroupFailsoft_A8005.Value;
			}
			set
			{
				short num = (short)1683282126;
				short num2 = num;
				num = (short)424532174;
				switch (num2 == num)
				{
				}
				num = (short)1938423809;
				if (num != 0)
				{
				}
				num = (short)948502528;
				if (num != 0)
				{
				}
				num = (short)2124742656;
				short num3 = num;
				this.trkPerTalkgroupTalkgroupFailsoft_A8005.Value = value;
			}
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x001CF4B4 File Offset: 0x001CD6B4
		public global::AcpBusinessLayer.AcpField<bool> TrkPerTalkgroupTalkgroupFailsoft_A8005
		{
			get
			{
				short num = (short)1698074667;
				short num2 = num;
				num = (short)1573359659;
				switch (num2 == num)
				{
				}
				num = (short)555548672;
				if (num != 0)
				{
				}
				num = (short)1217724417;
				if (num != 0)
				{
				}
				num = (short)1112801280;
				short num3 = num;
				return this.trkPerTalkgroupTalkgroupFailsoft_A8005;
			}
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06001D0E RID: 7438 RVA: 0x001CF560 File Offset: 0x001CD760
		// (set) Token: 0x06001D0F RID: 7439 RVA: 0x001CF618 File Offset: 0x001CD818
		public bool TrkPerTalkgroupTalkgroupFailsoft_A8005_UIValue
		{
			get
			{
				short num = (short)2037452173;
				short num2 = num;
				num = (short)1432489357;
				switch (num2 == num)
				{
				}
				num = (short)1795555329;
				if (num != 0)
				{
				}
				num = (short)1249705984;
				if (num != 0)
				{
				}
				num = (short)636026880;
				short num3 = num;
				return this.trkPerTalkgroupTalkgroupFailsoft_A8005.Value;
			}
			set
			{
				short num = (short)1478557697;
				if (num != 0)
				{
				}
				num = (short)214147130;
				short num2 = num;
				num = (short)1871355962;
				switch (num2 == num)
				{
				}
				num = (short)914423808;
				if (num != 0)
				{
				}
				num = (short)2006384640;
				short num3 = num;
				this.trkPerTalkgroupTalkgroupFailsoft_A8005.Value = value;
			}
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06001D10 RID: 7440 RVA: 0x001CF6D0 File Offset: 0x001CD8D0
		// (set) Token: 0x06001D11 RID: 7441 RVA: 0x001CF784 File Offset: 0x001CD984
		public bool TrkPerTalkgroupTalkgroupFailsoft_A8005_Applicable
		{
			get
			{
				short num = (short)1379735360;
				short num2 = num;
				num = (short)1898714944;
				switch (num2 == num)
				{
				}
				num = (short)1300234241;
				if (num != 0)
				{
				}
				num = (short)2009006080;
				if (num != 0)
				{
				}
				num = (short)804913152;
				short num3 = num;
				return this.trkPerTalkgroupTalkgroupFailsoft_A8005.Applicable;
			}
			set
			{
				short num = (short)328781088;
				short num2 = num;
				num = (short)1031982368;
				switch (num2 == num)
				{
				}
				num = (short)1724186624;
				if (num != 0)
				{
				}
				num = (short)410255361;
				if (num != 0)
				{
				}
				num = (short)1772748800;
				short num3 = num;
				this.trkPerTalkgroupTalkgroupFailsoft_A8005.Applicable = value;
			}
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06001D12 RID: 7442 RVA: 0x001CF83C File Offset: 0x001CDA3C
		// (set) Token: 0x06001D13 RID: 7443 RVA: 0x001CF8F4 File Offset: 0x001CDAF4
		public bool TrkPerTalkgroupTalkgroupFailsoft_A8005_Valid
		{
			get
			{
				short num = (short)1589268957;
				short num2 = num;
				num = (short)1715753437;
				switch (num2 == num)
				{
				}
				num = (short)2058747905;
				if (num != 0)
				{
				}
				num = (short)1307967488;
				if (num != 0)
				{
				}
				num = (short)2034434048;
				short num3 = num;
				return this.trkPerTalkgroupTalkgroupFailsoft_A8005.Valid;
			}
			set
			{
				short num = (short)1099743203;
				short num2 = num;
				num = (short)771866595;
				switch (num2 == num)
				{
				}
				num = (short)685899777;
				if (num != 0)
				{
				}
				num = (short)238223360;
				if (num != 0)
				{
				}
				num = (short)582025216;
				short num3 = num;
				this.trkPerTalkgroupTalkgroupFailsoft_A8005.Valid = value;
			}
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06001D14 RID: 7444 RVA: 0x001CF9A4 File Offset: 0x001CDBA4
		// (set) Token: 0x06001D15 RID: 7445 RVA: 0x001CFA58 File Offset: 0x001CDC58
		public bool TrkPerTalkgroupTalkgroupFailsoft_A8005_Visible
		{
			get
			{
				short num = (short)1335546108;
				short num2 = num;
				num = (short)29937916;
				switch (num2 == num)
				{
				}
				num = (short)1295187969;
				if (num != 0)
				{
				}
				num = (short)814481408;
				if (num != 0)
				{
				}
				num = (short)620625920;
				short num3 = num;
				return this.trkPerTalkgroupTalkgroupFailsoft_A8005.Visible;
			}
			set
			{
				short num = (short)670541835;
				short num2 = num;
				num = (short)519809035;
				switch (num2 == num)
				{
				}
				num = (short)686161920;
				if (num != 0)
				{
				}
				num = (short)120717313;
				if (num != 0)
				{
				}
				num = (short)36765696;
				short num3 = num;
				this.trkPerTalkgroupTalkgroupFailsoft_A8005.Visible = value;
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06001D16 RID: 7446 RVA: 0x001CFB0C File Offset: 0x001CDD0C
		// (set) Token: 0x06001D17 RID: 7447 RVA: 0x001CFBC0 File Offset: 0x001CDDC0
		public bool TrkPerTalkgroupTalkgroupFailsoft_A8005_Editable
		{
			get
			{
				short num = (short)1284636673;
				if (num != 0)
				{
				}
				num = (short)1658508583;
				short num2 = num;
				num = (short)512087335;
				switch (num2 == num)
				{
				}
				num = (short)568655872;
				if (num != 0)
				{
				}
				num = (short)1657143296;
				short num3 = num;
				return this.trkPerTalkgroupTalkgroupFailsoft_A8005.Editable;
			}
			set
			{
				short num = (short)690913438;
				short num2 = num;
				num = (short)2055504030;
				switch (num2 == num)
				{
				}
				num = (short)240189440;
				if (num != 0)
				{
				}
				num = (short)1649803265;
				if (num != 0)
				{
				}
				num = (short)568524800;
				short num3 = num;
				this.trkPerTalkgroupTalkgroupFailsoft_A8005.Editable = value;
			}
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06001D18 RID: 7448 RVA: 0x001CFC74 File Offset: 0x001CDE74
		internal string TrkPerTalkgroupTalkgroupFailsoft_A8005_UILabel
		{
			get
			{
				short num = (short)1317030599;
				short num2 = num;
				num = (short)1976453831;
				switch (num2 == num)
				{
				}
				num = (short)1895170048;
				if (num != 0)
				{
				}
				num = (short)1356267521;
				if (num != 0)
				{
				}
				num = (short)1253441536;
				short num3 = num;
				return this.trkPerTalkgroupTalkgroupFailsoft_A8005.UIName;
			}
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06001D19 RID: 7449 RVA: 0x001CFD28 File Offset: 0x001CDF28
		// (set) Token: 0x06001D1A RID: 7450 RVA: 0x001CFDE0 File Offset: 0x001CDFE0
		internal bool TrkPerTalkgroupTalkgroupFailsoft_A8005_HiddenStatic
		{
			get
			{
				short num = (short)881041938;
				short num2 = num;
				num = (short)1013686802;
				switch (num2 == num)
				{
				}
				num = (short)195100673;
				if (num != 0)
				{
				}
				num = (short)162136064;
				if (num != 0)
				{
				}
				num = (short)1637482496;
				short num3 = num;
				return this.trkPerTalkgroupTalkgroupFailsoft_A8005.HiddenStatic;
			}
			set
			{
				short num = (short)235995137;
				if (num != 0)
				{
				}
				num = (short)211668009;
				short num2 = num;
				num = (short)1047514153;
				switch (num2 == num)
				{
				}
				num = (short)995688448;
				if (num != 0)
				{
				}
				num = (short)1533935616;
				short num3 = num;
				this.trkPerTalkgroupTalkgroupFailsoft_A8005.HiddenStatic = value;
			}
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x06001D1B RID: 7451 RVA: 0x001CFE94 File Offset: 0x001CE094
		// (set) Token: 0x06001D1C RID: 7452 RVA: 0x001CFF4C File Offset: 0x001CE14C
		internal bool TrkPerTalkgroupTalkgroupFailsoft_A8005_HiddenDynamic
		{
			get
			{
				short num = (short)188423422;
				short num2 = num;
				num = (short)1466309886;
				switch (num2 == num)
				{
				}
				num = (short)2006974464;
				if (num != 0)
				{
				}
				num = (short)1696399361;
				if (num != 0)
				{
				}
				num = (short)878837760;
				short num3 = num;
				return this.trkPerTalkgroupTalkgroupFailsoft_A8005.HiddenDynamic;
			}
			set
			{
				short num = (short)579385830;
				short num2 = num;
				num = (short)633584102;
				switch (num2 == num)
				{
				}
				num = (short)1140260864;
				if (num != 0)
				{
				}
				num = (short)1452867585;
				if (num != 0)
				{
				}
				num = (short)51445760;
				short num3 = num;
				this.trkPerTalkgroupTalkgroupFailsoft_A8005.HiddenDynamic = value;
			}
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x06001D1D RID: 7453 RVA: 0x001D0000 File Offset: 0x001CE200
		public bool TrkPerTalkgroupTalkgroupFailsoft_A8005_HasDiffs
		{
			get
			{
				short num = (short)1801915471;
				short num2 = num;
				num = (short)1850739791;
				switch (num2 == num)
				{
				}
				num = (short)1217003521;
				if (num != 0)
				{
				}
				num = (short)368902144;
				if (num != 0)
				{
				}
				num = (short)193003520;
				short num3 = num;
				return this.trkPerTalkgroupTalkgroupFailsoft_A8005._HasDiffs;
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06001D1E RID: 7454 RVA: 0x001D00B8 File Offset: 0x001CE2B8
		// (set) Token: 0x06001D1F RID: 7455 RVA: 0x001D016C File Offset: 0x001CE36C
		public int TrkPerTalkgroupKeySelect_A8365Value
		{
			get
			{
				short num = (short)149520954;
				short num2 = num;
				num = (short)1583448634;
				switch (num2 == num)
				{
				}
				num = (short)1291845633;
				if (num != 0)
				{
				}
				num = (short)939786240;
				if (num != 0)
				{
				}
				num = (short)2033451008;
				short num3 = num;
				return this.trkPerTalkgroupKeySelect_A8365.Value;
			}
			set
			{
				short num = (short)1884951641;
				short num2 = num;
				num = (short)785585241;
				switch (num2 == num)
				{
				}
				num = (short)825032705;
				if (num != 0)
				{
				}
				num = (short)1621229568;
				if (num != 0)
				{
				}
				num = (short)1938685952;
				short num3 = num;
				this.trkPerTalkgroupKeySelect_A8365.Value = value;
			}
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x06001D20 RID: 7456 RVA: 0x001D0220 File Offset: 0x001CE420
		// (set) Token: 0x06001D21 RID: 7457 RVA: 0x001D02D4 File Offset: 0x001CE4D4
		public string TrkPerTalkgroupKeySelect_A8365_UIValue
		{
			get
			{
				short num = (short)594855286;
				short num2 = num;
				num = (short)130663798;
				switch (num2 == num)
				{
				}
				num = (short)1287323649;
				if (num != 0)
				{
				}
				num = (short)622919680;
				if (num != 0)
				{
				}
				num = (short)2072444928;
				short num3 = num;
				return this.trkPerTalkgroupKeySelect_A8365.UIValue;
			}
			set
			{
				short num = (short)461364388;
				short num2 = num;
				num = (short)875617444;
				switch (num2 == num)
				{
				}
				num = (short)274595840;
				if (num != 0)
				{
				}
				num = (short)1185808385;
				if (num != 0)
				{
				}
				num = (short)1726021632;
				short num3 = num;
				this.trkPerTalkgroupKeySelect_A8365.UIValue = value;
			}
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x06001D22 RID: 7458 RVA: 0x001D0388 File Offset: 0x001CE588
		public global::AcpBusinessLayer.AcpRecRefField TrkPerTalkgroupKeySelect_A8365
		{
			get
			{
				short num = (short)1433232913;
				short num2 = num;
				num = (short)896820753;
				switch (num2 == num)
				{
				}
				num = (short)443809793;
				if (num != 0)
				{
				}
				num = (short)1935540224;
				if (num != 0)
				{
				}
				num = (short)620756992;
				short num3 = num;
				return this.trkPerTalkgroupKeySelect_A8365;
			}
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x001D0438 File Offset: 0x001CE638
		// (set) Token: 0x06001D24 RID: 7460 RVA: 0x001D04EC File Offset: 0x001CE6EC
		public bool TrkPerTalkgroupKeySelect_A8365_Applicable
		{
			get
			{
				short num = (short)2045118624;
				short num2 = num;
				num = (short)1644103840;
				switch (num2 == num)
				{
				}
				num = (short)344981505;
				if (num != 0)
				{
				}
				num = (short)362807296;
				if (num != 0)
				{
				}
				num = (short)1312686080;
				short num3 = num;
				return this.trkPerTalkgroupKeySelect_A8365.Applicable;
			}
			set
			{
				short num = (short)847972602;
				short num2 = num;
				num = (short)1992100090;
				switch (num2 == num)
				{
				}
				num = (short)2094661633;
				if (num != 0)
				{
				}
				num = (short)937295872;
				if (num != 0)
				{
				}
				num = (short)23592960;
				short num3 = num;
				this.trkPerTalkgroupKeySelect_A8365.Applicable = value;
			}
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x001D05A0 File Offset: 0x001CE7A0
		// (set) Token: 0x06001D26 RID: 7462 RVA: 0x001D0654 File Offset: 0x001CE854
		public bool TrkPerTalkgroupKeySelect_A8365_Valid
		{
			get
			{
				short num = (short)672747019;
				short num2 = num;
				num = (short)1278889483;
				switch (num2 == num)
				{
				}
				num = (short)648413184;
				if (num != 0)
				{
				}
				num = (short)20381697;
				if (num != 0)
				{
				}
				num = (short)174981120;
				short num3 = num;
				return this.trkPerTalkgroupKeySelect_A8365.Valid;
			}
			set
			{
				short num = (short)1146992813;
				short num2 = num;
				num = (short)400472237;
				switch (num2 == num)
				{
				}
				num = (short)1376256000;
				if (num != 0)
				{
				}
				num = (short)2123694081;
				if (num != 0)
				{
				}
				num = (short)1794310144;
				short num3 = num;
				this.trkPerTalkgroupKeySelect_A8365.Valid = value;
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x001D0708 File Offset: 0x001CE908
		// (set) Token: 0x06001D28 RID: 7464 RVA: 0x001D07BC File Offset: 0x001CE9BC
		public bool TrkPerTalkgroupKeySelect_A8365_Visible
		{
			get
			{
				short num = (short)60293121;
				if (num != 0)
				{
				}
				num = (short)2060709510;
				short num2 = num;
				num = (short)1035726470;
				switch (num2 == num)
				{
				}
				num = (short)1136001024;
				if (num != 0)
				{
				}
				num = (short)1502674944;
				short num3 = num;
				return this.trkPerTalkgroupKeySelect_A8365.Visible;
			}
			set
			{
				short num = (short)692149855;
				short num2 = num;
				num = (short)1655070303;
				switch (num2 == num)
				{
				}
				num = (short)1158021120;
				if (num != 0)
				{
				}
				num = (short)92930049;
				if (num != 0)
				{
				}
				num = (short)698613760;
				short num3 = num;
				this.trkPerTalkgroupKeySelect_A8365.Visible = value;
			}
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x001D0870 File Offset: 0x001CEA70
		// (set) Token: 0x06001D2A RID: 7466 RVA: 0x001D0924 File Offset: 0x001CEB24
		public bool TrkPerTalkgroupKeySelect_A8365_Editable
		{
			get
			{
				short num = (short)1304784432;
				short num2 = num;
				num = (short)279998000;
				switch (num2 == num)
				{
				}
				num = (short)1153433600;
				if (num != 0)
				{
				}
				num = (short)401014785;
				if (num != 0)
				{
				}
				num = (short)1747320832;
				short num3 = num;
				return this.trkPerTalkgroupKeySelect_A8365.Editable;
			}
			set
			{
				short num = (short)358859987;
				short num2 = num;
				num = (short)617006291;
				switch (num2 == num)
				{
				}
				num = (short)873660417;
				if (num != 0)
				{
				}
				num = (short)460587008;
				if (num != 0)
				{
				}
				num = (short)1259601920;
				short num3 = num;
				this.trkPerTalkgroupKeySelect_A8365.Editable = value;
			}
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x001D09DC File Offset: 0x001CEBDC
		internal string TrkPerTalkgroupKeySelect_A8365_UILabel
		{
			get
			{
				short num = (short)1127233792;
				short num2 = num;
				num = (short)864958720;
				switch (num2 == num)
				{
				}
				num = (short)853934081;
				if (num != 0)
				{
				}
				num = (short)163774464;
				if (num != 0)
				{
				}
				num = (short)1656881152;
				short num3 = num;
				return this.trkPerTalkgroupKeySelect_A8365.UIName;
			}
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x001D0A90 File Offset: 0x001CEC90
		// (set) Token: 0x06001D2D RID: 7469 RVA: 0x001D0B44 File Offset: 0x001CED44
		internal bool TrkPerTalkgroupKeySelect_A8365_HiddenStatic
		{
			get
			{
				short num = (short)1274113852;
				short num2 = num;
				num = (short)1856139068;
				switch (num2 == num)
				{
				}
				num = (short)1385955328;
				if (num != 0)
				{
				}
				num = (short)1367670785;
				if (num != 0)
				{
				}
				num = (short)1980891136;
				short num3 = num;
				return this.trkPerTalkgroupKeySelect_A8365.HiddenStatic;
			}
			set
			{
				short num = (short)748486657;
				if (num != 0)
				{
				}
				num = (short)849327228;
				short num2 = num;
				num = (short)669693052;
				switch (num2 == num)
				{
				}
				num = (short)121176064;
				if (num != 0)
				{
				}
				num = (short)1501233152;
				short num3 = num;
				this.trkPerTalkgroupKeySelect_A8365.HiddenStatic = value;
			}
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x001D0BF8 File Offset: 0x001CEDF8
		// (set) Token: 0x06001D2F RID: 7471 RVA: 0x001D0CA8 File Offset: 0x001CEEA8
		internal bool TrkPerTalkgroupKeySelect_A8365_HiddenDynamic
		{
			get
			{
				short num = (short)170262529;
				if (num != 0)
				{
				}
				num = (short)176417437;
				short num2 = num;
				num = (short)177007261;
				switch (num2 == num)
				{
				}
				num = (short)1769078784;
				if (num != 0)
				{
				}
				num = (short)1020723200;
				short num3 = num;
				return this.trkPerTalkgroupKeySelect_A8365.HiddenDynamic;
			}
			set
			{
				short num = (short)950599681;
				if (num != 0)
				{
				}
				num = (short)476621509;
				short num2 = num;
				num = (short)1224714949;
				switch (num2 == num)
				{
				}
				num = (short)680394752;
				if (num != 0)
				{
				}
				num = (short)1755709440;
				short num3 = num;
				this.trkPerTalkgroupKeySelect_A8365.HiddenDynamic = value;
			}
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x06001D30 RID: 7472 RVA: 0x001D0D5C File Offset: 0x001CEF5C
		public bool TrkPerTalkgroupKeySelect_A8365_HasDiffs
		{
			get
			{
				short num = (short)1576436098;
				short num2 = num;
				num = (short)200311170;
				switch (num2 == num)
				{
				}
				num = (short)1785331713;
				if (num != 0)
				{
				}
				num = (short)928972800;
				if (num != 0)
				{
				}
				num = (short)761659392;
				short num3 = num;
				return this.trkPerTalkgroupKeySelect_A8365._HasDiffs;
			}
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x001D0E10 File Offset: 0x001CF010
		// (set) Token: 0x06001D32 RID: 7474 RVA: 0x001D0EC4 File Offset: 0x001CF0C4
		public int TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900Value
		{
			get
			{
				short num = (short)786262622;
				short num2 = num;
				num = (short)392850014;
				switch (num2 == num)
				{
				}
				num = (short)1001717761;
				if (num != 0)
				{
				}
				num = (short)92405760;
				if (num != 0)
				{
				}
				num = (short)1735720960;
				short num3 = num;
				return this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.Value;
			}
			set
			{
				short num = (short)817813474;
				short num2 = num;
				num = (short)1179047906;
				switch (num2 == num)
				{
				}
				num = (short)1226375169;
				if (num != 0)
				{
				}
				num = (short)957546496;
				if (num != 0)
				{
				}
				num = (short)1386086400;
				short num3 = num;
				this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.Value = value;
			}
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06001D33 RID: 7475 RVA: 0x001D0F78 File Offset: 0x001CF178
		// (set) Token: 0x06001D34 RID: 7476 RVA: 0x001D1030 File Offset: 0x001CF230
		public string TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900_UIValue
		{
			get
			{
				short num = (short)589731428;
				short num2 = num;
				num = (short)35952228;
				switch (num2 == num)
				{
				}
				num = (short)1089601537;
				if (num != 0)
				{
				}
				num = (short)1498808320;
				if (num != 0)
				{
				}
				num = (short)2094333952;
				short num3 = num;
				return this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.UIValue;
			}
			set
			{
				short num = (short)1841037312;
				short num2 = num;
				num = (short)965908695;
				short num3 = num;
				num = (short)780703959;
				switch (num3 == num)
				{
				}
				num = (short)1261633537;
				if (num != 0)
				{
				}
				num = (short)1136918528;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.UIValue = value;
			}
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x06001D35 RID: 7477 RVA: 0x001D10E4 File Offset: 0x001CF2E4
		public global::AcpBusinessLayer.AcpFrequencyField TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900
		{
			get
			{
				short num = (short)1169883136;
				short num2 = num;
				num = (short)1377001259;
				short num3 = num;
				num = (short)735469355;
				switch (num3 == num)
				{
				}
				num = (short)934019072;
				if (num != 0)
				{
				}
				num = (short)643497985;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900;
			}
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x06001D36 RID: 7478 RVA: 0x001D1194 File Offset: 0x001CF394
		// (set) Token: 0x06001D37 RID: 7479 RVA: 0x001D124C File Offset: 0x001CF44C
		internal int TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900Min
		{
			get
			{
				short num = (short)365756416;
				short num2 = num;
				num = (short)1700986881;
				if (num != 0)
				{
				}
				num = (short)692694089;
				short num3 = num;
				num = (short)718908489;
				switch (num3 == num)
				{
				}
				num = (short)1785921536;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.Min;
			}
			set
			{
				short num = (short)1607139328;
				short num2 = num;
				num = (short)846266670;
				short num3 = num;
				num = (short)2060648750;
				switch (num3 == num)
				{
				}
				num = (short)837287936;
				if (num != 0)
				{
				}
				num = (short)429326337;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.Min = value;
			}
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x06001D38 RID: 7480 RVA: 0x001D1300 File Offset: 0x001CF500
		// (set) Token: 0x06001D39 RID: 7481 RVA: 0x001D13B8 File Offset: 0x001CF5B8
		internal int TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900Max
		{
			get
			{
				short num = (short)994902016;
				short num2 = num;
				num = (short)1175435316;
				short num3 = num;
				num = (short)244627508;
				switch (num3 == num)
				{
				}
				num = (short)1734344705;
				if (num != 0)
				{
				}
				num = (short)744095744;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.Max;
			}
			set
			{
				short num = (short)1965359104;
				short num2 = num;
				num = (short)820839176;
				short num3 = num;
				num = (short)2013266696;
				switch (num3 == num)
				{
				}
				num = (short)1643380736;
				if (num != 0)
				{
				}
				num = (short)1923940353;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.Max = value;
			}
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x06001D3A RID: 7482 RVA: 0x001D1470 File Offset: 0x001CF670
		// (set) Token: 0x06001D3B RID: 7483 RVA: 0x001D1524 File Offset: 0x001CF724
		internal int TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900Step
		{
			get
			{
				short num = (short)1313341440;
				short num2 = num;
				num = (short)1924506826;
				short num3 = num;
				num = (short)1627563210;
				switch (num3 == num)
				{
				}
				num = (short)375980033;
				if (num != 0)
				{
				}
				num = (short)855310336;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.StepSize;
			}
			set
			{
				short num = (short)861405184;
				short num2 = num;
				num = (short)1840017258;
				short num3 = num;
				num = (short)630681450;
				switch (num3 == num)
				{
				}
				num = (short)650182656;
				if (num != 0)
				{
				}
				num = (short)1345716225;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.StepSize = value;
			}
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x06001D3C RID: 7484 RVA: 0x001D15DC File Offset: 0x001CF7DC
		// (set) Token: 0x06001D3D RID: 7485 RVA: 0x001D1690 File Offset: 0x001CF890
		public bool TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900_Applicable
		{
			get
			{
				short num = (short)1761411072;
				short num2 = num;
				num = (short)368408737;
				short num3 = num;
				num = (short)1289648289;
				switch (num3 == num)
				{
				}
				num = (short)815136768;
				if (num != 0)
				{
				}
				num = (short)1022689281;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.Applicable;
			}
			set
			{
				short num = (short)1627979776;
				short num2 = num;
				num = (short)1010464693;
				short num3 = num;
				num = (short)590247861;
				switch (num3 == num)
				{
				}
				num = (short)1453588481;
				if (num != 0)
				{
				}
				num = (short)557121536;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.Applicable = value;
			}
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x06001D3E RID: 7486 RVA: 0x001D1744 File Offset: 0x001CF944
		// (set) Token: 0x06001D3F RID: 7487 RVA: 0x001D17F8 File Offset: 0x001CF9F8
		public bool TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900_Valid
		{
			get
			{
				short num = (short)806158336;
				short num2 = num;
				num = (short)1615722895;
				short num3 = num;
				num = (short)755759503;
				switch (num3 == num)
				{
				}
				num = (short)1695350785;
				if (num != 0)
				{
				}
				num = (short)2036400128;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.Valid;
			}
			set
			{
				short num = (short)627507200;
				short num2 = num;
				num = (short)586882288;
				short num3 = num;
				num = (short)1592728816;
				switch (num3 == num)
				{
				}
				num = (short)1360527360;
				if (num != 0)
				{
				}
				num = (short)1695547393;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.Valid = value;
			}
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06001D40 RID: 7488 RVA: 0x001D18B0 File Offset: 0x001CFAB0
		// (set) Token: 0x06001D41 RID: 7489 RVA: 0x001D1964 File Offset: 0x001CFB64
		public bool TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900_Visible
		{
			get
			{
				short num = (short)344850432;
				short num2 = num;
				num = (short)1819758314;
				short num3 = num;
				num = (short)1232621290;
				switch (num3 == num)
				{
				}
				num = (short)1121910784;
				if (num != 0)
				{
				}
				num = (short)787152897;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.Visible;
			}
			set
			{
				short num = (short)718995456;
				short num2 = num;
				num = (short)1903558657;
				if (num != 0)
				{
				}
				num = (short)328170654;
				short num3 = num;
				num = (short)2002025630;
				switch (num3 == num)
				{
				}
				num = (short)1649672192;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.Visible = value;
			}
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x001D1A18 File Offset: 0x001CFC18
		// (set) Token: 0x06001D43 RID: 7491 RVA: 0x001D1ACC File Offset: 0x001CFCCC
		public bool TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900_Editable
		{
			get
			{
				short num = (short)1980563456;
				short num2 = num;
				num = (short)1796240018;
				short num3 = num;
				num = (short)1342796434;
				switch (num3 == num)
				{
				}
				num = (short)2111111168;
				if (num != 0)
				{
				}
				num = (short)1155334145;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.Editable;
			}
			set
			{
				short num = (short)441516032;
				short num2 = num;
				num = (short)444070953;
				short num3 = num;
				num = (short)920321065;
				switch (num3 == num)
				{
				}
				num = (short)1946353665;
				if (num != 0)
				{
				}
				num = (short)1611726848;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.Editable = value;
			}
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06001D44 RID: 7492 RVA: 0x001D1B80 File Offset: 0x001CFD80
		internal string TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900_UILabel
		{
			get
			{
				short num = (short)2065235968;
				short num2 = num;
				num = (short)464857625;
				short num3 = num;
				num = (short)959916569;
				switch (num3 == num)
				{
				}
				num = (short)403046401;
				if (num != 0)
				{
				}
				num = (short)836304896;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.UIName;
			}
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06001D45 RID: 7493 RVA: 0x001D1C38 File Offset: 0x001CFE38
		// (set) Token: 0x06001D46 RID: 7494 RVA: 0x001D1CEC File Offset: 0x001CFEEC
		internal bool TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900_HiddenStatic
		{
			get
			{
				short num = (short)525533184;
				short num2 = num;
				num = (short)1784612077;
				short num3 = num;
				num = (short)535954669;
				switch (num3 == num)
				{
				}
				num = (short)1844641792;
				if (num != 0)
				{
				}
				num = (short)884408321;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.HiddenStatic;
			}
			set
			{
				short num = (short)480706560;
				short num2 = num;
				num = (short)1658165056;
				short num3 = num;
				num = (short)25007936;
				switch (num3 == num)
				{
				}
				num = (short)1375535105;
				if (num != 0)
				{
				}
				num = (short)1256456192;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.HiddenStatic = value;
			}
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06001D47 RID: 7495 RVA: 0x001D1DA4 File Offset: 0x001CFFA4
		// (set) Token: 0x06001D48 RID: 7496 RVA: 0x001D1E58 File Offset: 0x001D0058
		internal bool TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900_HiddenDynamic
		{
			get
			{
				short num = (short)1416888320;
				short num2 = num;
				num = (short)1992411445;
				short num3 = num;
				num = (short)1622067509;
				switch (num3 == num)
				{
				}
				num = (short)853409793;
				if (num != 0)
				{
				}
				num = (short)1447034880;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.HiddenDynamic;
			}
			set
			{
				short num = (short)712441856;
				short num2 = num;
				num = (short)1489174529;
				if (num != 0)
				{
				}
				num = (short)239866994;
				short num3 = num;
				num = (short)2043417714;
				switch (num3 == num)
				{
				}
				num = (short)505348096;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.HiddenDynamic = value;
			}
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06001D49 RID: 7497 RVA: 0x001D1F0C File Offset: 0x001D010C
		public bool TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900_HasDiffs
		{
			get
			{
				short num = (short)1929838592;
				short num2 = num;
				num = (short)1713398614;
				short num3 = num;
				num = (short)1535075158;
				switch (num3 == num)
				{
				}
				num = (short)326631425;
				if (num != 0)
				{
				}
				num = (short)769720320;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900._HasDiffs;
			}
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06001D4A RID: 7498 RVA: 0x001D1FC4 File Offset: 0x001D01C4
		// (set) Token: 0x06001D4B RID: 7499 RVA: 0x001D2078 File Offset: 0x001D0278
		public int TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902Value
		{
			get
			{
				short num = (short)1734344704;
				short num2 = num;
				num = (short)1480679811;
				short num3 = num;
				num = (short)1673617795;
				switch (num3 == num)
				{
				}
				num = (short)234291201;
				if (num != 0)
				{
				}
				num = (short)960823296;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.Value;
			}
			set
			{
				short num = (short)405667840;
				short num2 = num;
				num = (short)1878090443;
				short num3 = num;
				num = (short)746087115;
				switch (num3 == num)
				{
				}
				num = (short)1471545345;
				if (num != 0)
				{
				}
				num = (short)1895432192;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.Value = value;
			}
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06001D4C RID: 7500 RVA: 0x001D2130 File Offset: 0x001D0330
		// (set) Token: 0x06001D4D RID: 7501 RVA: 0x001D21E4 File Offset: 0x001D03E4
		public string TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902_UIValue
		{
			get
			{
				short num = (short)2101215232;
				short num2 = num;
				num = (short)1416356663;
				short num3 = num;
				num = (short)1809965879;
				switch (num3 == num)
				{
				}
				num = (short)1457258497;
				if (num != 0)
				{
				}
				num = (short)1215496192;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.UIValue;
			}
			set
			{
				short num = (short)1725104128;
				short num2 = num;
				num = (short)140352551;
				short num3 = num;
				num = (short)1827839015;
				switch (num3 == num)
				{
				}
				num = (short)896008193;
				if (num != 0)
				{
				}
				num = (short)1132396544;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.UIValue = value;
			}
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06001D4E RID: 7502 RVA: 0x001D2298 File Offset: 0x001D0498
		public global::AcpBusinessLayer.AcpFrequencyField TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902
		{
			get
			{
				short num = (short)1971847168;
				short num2 = num;
				num = (short)2030506338;
				short num3 = num;
				num = (short)1916146018;
				switch (num3 == num)
				{
				}
				num = (short)14745600;
				if (num != 0)
				{
				}
				num = (short)45219841;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902;
			}
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x06001D4F RID: 7503 RVA: 0x001D2348 File Offset: 0x001D0548
		// (set) Token: 0x06001D50 RID: 7504 RVA: 0x001D23FC File Offset: 0x001D05FC
		internal int TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902Min
		{
			get
			{
				short num = (short)1552351232;
				short num2 = num;
				num = (short)1697551946;
				short num3 = num;
				num = (short)469997130;
				switch (num3 == num)
				{
				}
				num = (short)274595840;
				if (num != 0)
				{
				}
				num = (short)468189185;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.Min;
			}
			set
			{
				short num = (short)1000669184;
				short num2 = num;
				num = (short)195035137;
				if (num != 0)
				{
				}
				num = (short)2043131764;
				short num3 = num;
				num = (short)997046132;
				switch (num3 == num)
				{
				}
				num = (short)483524608;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.Min = value;
			}
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x06001D51 RID: 7505 RVA: 0x001D24B0 File Offset: 0x001D06B0
		// (set) Token: 0x06001D52 RID: 7506 RVA: 0x001D2564 File Offset: 0x001D0764
		internal int TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902Max
		{
			get
			{
				short num = (short)1200488448;
				short num2 = num;
				num = (short)1361912163;
				short num3 = num;
				num = (short)1320624483;
				switch (num3 == num)
				{
				}
				num = (short)2015166464;
				if (num != 0)
				{
				}
				num = (short)94371841;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.Max;
			}
			set
			{
				short num = (short)1912668160;
				short num2 = num;
				num = (short)1827576700;
				short num3 = num;
				num = (short)1815255932;
				switch (num3 == num)
				{
				}
				num = (short)446365697;
				if (num != 0)
				{
				}
				num = (short)1573650432;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.Max = value;
			}
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x06001D53 RID: 7507 RVA: 0x001D261C File Offset: 0x001D081C
		// (set) Token: 0x06001D54 RID: 7508 RVA: 0x001D26D0 File Offset: 0x001D08D0
		internal int TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902Step
		{
			get
			{
				short num = (short)75628544;
				short num2 = num;
				num = (short)1593724807;
				short num3 = num;
				num = (short)1080971143;
				switch (num3 == num)
				{
				}
				num = (short)2082799617;
				if (num != 0)
				{
				}
				num = (short)57933824;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.StepSize;
			}
			set
			{
				short num = (short)334954496;
				short num2 = num;
				num = (short)1042953325;
				short num3 = num;
				num = (short)2128295021;
				switch (num3 == num)
				{
				}
				num = (short)1509818368;
				if (num != 0)
				{
				}
				num = (short)2097348609;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.StepSize = value;
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06001D55 RID: 7509 RVA: 0x001D2788 File Offset: 0x001D0988
		// (set) Token: 0x06001D56 RID: 7510 RVA: 0x001D2840 File Offset: 0x001D0A40
		public bool TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902_Applicable
		{
			get
			{
				short num = (short)926613504;
				short num2 = num;
				num = (short)262668289;
				if (num != 0)
				{
				}
				num = (short)169339861;
				short num3 = num;
				num = (short)201255893;
				switch (num3 == num)
				{
				}
				num = (short)537985024;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.Applicable;
			}
			set
			{
				short num = (short)993591296;
				short num2 = num;
				num = (short)217152386;
				short num3 = num;
				num = (short)1620867970;
				switch (num3 == num)
				{
				}
				num = (short)1261961216;
				if (num != 0)
				{
				}
				num = (short)1523122177;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.Applicable = value;
			}
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06001D57 RID: 7511 RVA: 0x001D28F4 File Offset: 0x001D0AF4
		// (set) Token: 0x06001D58 RID: 7512 RVA: 0x001D29AC File Offset: 0x001D0BAC
		public bool TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902_Valid
		{
			get
			{
				short num = (short)556269568;
				short num2 = num;
				num = (short)726230602;
				short num3 = num;
				num = (short)183133770;
				switch (num3 == num)
				{
				}
				num = (short)1831927809;
				if (num != 0)
				{
				}
				num = (short)2020016128;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.Valid;
			}
			set
			{
				short num = (short)259129344;
				short num2 = num;
				num = (short)1900687450;
				short num3 = num;
				num = (short)22098010;
				switch (num3 == num)
				{
				}
				num = (short)2083717120;
				if (num != 0)
				{
				}
				num = (short)1114113;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.Valid = value;
			}
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06001D59 RID: 7513 RVA: 0x001D2A60 File Offset: 0x001D0C60
		// (set) Token: 0x06001D5A RID: 7514 RVA: 0x001D2B14 File Offset: 0x001D0D14
		public bool TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902_Visible
		{
			get
			{
				short num = (short)621150208;
				short num2 = num;
				num = (short)1806918882;
				short num3 = num;
				num = (short)1470391522;
				switch (num3 == num)
				{
				}
				num = (short)1139867649;
				if (num != 0)
				{
				}
				num = (short)60620800;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.Visible;
			}
			set
			{
				short num = (short)172818432;
				short num2 = num;
				num = (short)921063531;
				short num3 = num;
				num = (short)1071927403;
				switch (num3 == num)
				{
				}
				num = (short)491061248;
				if (num != 0)
				{
				}
				num = (short)1752956929;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.Visible = value;
			}
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06001D5B RID: 7515 RVA: 0x001D2BC8 File Offset: 0x001D0DC8
		// (set) Token: 0x06001D5C RID: 7516 RVA: 0x001D2C7C File Offset: 0x001D0E7C
		public bool TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902_Editable
		{
			get
			{
				short num = (short)912392192;
				short num2 = num;
				num = (short)1006962161;
				short num3 = num;
				num = (short)1064633841;
				switch (num3 == num)
				{
				}
				num = (short)2140667905;
				if (num != 0)
				{
				}
				num = (short)1036779520;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.Editable;
			}
			set
			{
				short num = (short)347078656;
				short num2 = num;
				num = (short)436054337;
				short num3 = num;
				num = (short)376088897;
				switch (num3 == num)
				{
				}
				num = (short)1169948673;
				if (num != 0)
				{
				}
				num = (short)775290880;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.Editable = value;
			}
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06001D5D RID: 7517 RVA: 0x001D2D30 File Offset: 0x001D0F30
		internal string TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902_UILabel
		{
			get
			{
				short num = (short)711917568;
				short num2 = num;
				num = (short)1989167427;
				short num3 = num;
				num = (short)1270303043;
				switch (num3 == num)
				{
				}
				num = (short)518848512;
				if (num != 0)
				{
				}
				num = (short)1238433793;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.UIName;
			}
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x001D2DE8 File Offset: 0x001D0FE8
		// (set) Token: 0x06001D5F RID: 7519 RVA: 0x001D2E9C File Offset: 0x001D109C
		internal bool TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902_HiddenStatic
		{
			get
			{
				short num = (short)1004929024;
				short num2 = num;
				num = (short)1929314305;
				if (num != 0)
				{
				}
				num = (short)1037268453;
				short num3 = num;
				num = (short)37582309;
				switch (num3 == num)
				{
				}
				num = (short)621215744;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.HiddenStatic;
			}
			set
			{
				short num = (short)1859452928;
				short num2 = num;
				num = (short)779478698;
				short num3 = num;
				num = (short)1073145514;
				switch (num3 == num)
				{
				}
				num = (short)1393491969;
				if (num != 0)
				{
				}
				num = (short)780206080;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.HiddenStatic = value;
			}
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x001D2F50 File Offset: 0x001D1150
		// (set) Token: 0x06001D61 RID: 7521 RVA: 0x001D3004 File Offset: 0x001D1204
		internal bool TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902_HiddenDynamic
		{
			get
			{
				short num = (short)1691090944;
				short num2 = num;
				num = (short)1054897313;
				short num3 = num;
				num = (short)814707873;
				switch (num3 == num)
				{
				}
				num = (short)1739653121;
				if (num != 0)
				{
				}
				num = (short)1467809792;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.HiddenDynamic;
			}
			set
			{
				short num = (short)1704198144;
				short num2 = num;
				num = (short)1912580066;
				short num3 = num;
				num = (short)115517410;
				switch (num3 == num)
				{
				}
				num = (short)834928641;
				if (num != 0)
				{
				}
				num = (short)475267072;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.HiddenDynamic = value;
			}
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06001D62 RID: 7522 RVA: 0x001D30B8 File Offset: 0x001D12B8
		public bool TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902_HasDiffs
		{
			get
			{
				short num = (short)152633344;
				short num2 = num;
				num = (short)1239869973;
				short num3 = num;
				num = (short)191097365;
				switch (num3 == num)
				{
				}
				num = (short)1299447808;
				if (num != 0)
				{
				}
				num = (short)657391617;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902._HasDiffs;
			}
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06001D63 RID: 7523 RVA: 0x001D3170 File Offset: 0x001D1370
		// (set) Token: 0x06001D64 RID: 7524 RVA: 0x001D3224 File Offset: 0x001D1424
		public int TrkPerTalkgroupSecureClearStrapping_A9095Value
		{
			get
			{
				short num = (short)472186880;
				short num2 = num;
				num = (short)1898967709;
				short num3 = num;
				num = (short)488436381;
				switch (num3 == num)
				{
				}
				num = (short)1295777792;
				if (num != 0)
				{
				}
				num = (short)1141702657;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecureClearStrapping_A9095.Value;
			}
			set
			{
				short num = (short)929824768;
				short num2 = num;
				num = (short)1516061162;
				short num3 = num;
				num = (short)1113080298;
				switch (num3 == num)
				{
				}
				num = (short)1095630849;
				if (num != 0)
				{
				}
				num = (short)1039597568;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecureClearStrapping_A9095.Value = value;
			}
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06001D65 RID: 7525 RVA: 0x001D32D8 File Offset: 0x001D14D8
		// (set) Token: 0x06001D66 RID: 7526 RVA: 0x001D338C File Offset: 0x001D158C
		public string TrkPerTalkgroupSecureClearStrapping_A9095_UIValue
		{
			get
			{
				short num = (short)1553793024;
				short num2 = num;
				num = (short)1581903475;
				short num3 = num;
				num = (short)1353248371;
				switch (num3 == num)
				{
				}
				num = (short)1755906049;
				if (num != 0)
				{
				}
				num = (short)840171520;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecureClearStrapping_A9095.UIValue;
			}
			set
			{
				short num = (short)1848311808;
				short num2 = num;
				num = (short)1000964268;
				short num3 = num;
				num = (short)2108129452;
				switch (num3 == num)
				{
				}
				num = (short)1322319873;
				if (num != 0)
				{
				}
				num = (short)1576534016;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecureClearStrapping_A9095.UIValue = value;
			}
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06001D67 RID: 7527 RVA: 0x001D3440 File Offset: 0x001D1640
		public global::AcpBusinessLayer.AcpListField TrkPerTalkgroupSecureClearStrapping_A9095
		{
			get
			{
				short num = (short)361103360;
				short num2 = num;
				num = (short)208239764;
				short num3 = num;
				num = (short)419855508;
				switch (num3 == num)
				{
				}
				num = (short)465633281;
				if (num != 0)
				{
				}
				num = (short)1831337984;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecureClearStrapping_A9095;
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06001D68 RID: 7528 RVA: 0x001D34F0 File Offset: 0x001D16F0
		// (set) Token: 0x06001D69 RID: 7529 RVA: 0x001D35A8 File Offset: 0x001D17A8
		public bool TrkPerTalkgroupSecureClearStrapping_A9095_Applicable
		{
			get
			{
				short num = (short)994902016;
				short num2 = num;
				num = (short)210359070;
				short num3 = num;
				num = (short)249090846;
				switch (num3 == num)
				{
				}
				num = (short)1751580672;
				if (num != 0)
				{
				}
				num = (short)125304833;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecureClearStrapping_A9095.Applicable;
			}
			set
			{
				short num = (short)1676410880;
				short num2 = num;
				num = (short)1814302381;
				short num3 = num;
				num = (short)1263603373;
				switch (num3 == num)
				{
				}
				num = (short)1130889216;
				if (num != 0)
				{
				}
				num = (short)1671430145;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecureClearStrapping_A9095.Applicable = value;
			}
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06001D6A RID: 7530 RVA: 0x001D365C File Offset: 0x001D185C
		// (set) Token: 0x06001D6B RID: 7531 RVA: 0x001D3710 File Offset: 0x001D1910
		public bool TrkPerTalkgroupSecureClearStrapping_A9095_Valid
		{
			get
			{
				short num = (short)834535424;
				short num2 = num;
				num = (short)1220510194;
				short num3 = num;
				num = (short)1007714802;
				switch (num3 == num)
				{
				}
				num = (short)20840449;
				if (num != 0)
				{
				}
				num = (short)652869632;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecureClearStrapping_A9095.Valid;
			}
			set
			{
				short num = (short)1750663168;
				short num2 = num;
				num = (short)1105081729;
				short num3 = num;
				num = (short)1001207169;
				switch (num3 == num)
				{
				}
				num = (short)1041039361;
				if (num != 0)
				{
				}
				num = (short)1966080000;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecureClearStrapping_A9095.Valid = value;
			}
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06001D6C RID: 7532 RVA: 0x001D37C8 File Offset: 0x001D19C8
		// (set) Token: 0x06001D6D RID: 7533 RVA: 0x001D387C File Offset: 0x001D1A7C
		public bool TrkPerTalkgroupSecureClearStrapping_A9095_Visible
		{
			get
			{
				short num = (short)545062912;
				short num2 = num;
				num = (short)1578500097;
				if (num != 0)
				{
				}
				num = (short)1730805160;
				short num3 = num;
				num = (short)2003697064;
				switch (num3 == num)
				{
				}
				num = (short)156106752;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecureClearStrapping_A9095.Visible;
			}
			set
			{
				short num = (short)1433600000;
				short num2 = num;
				num = (short)489245054;
				short num3 = num;
				num = (short)471550334;
				switch (num3 == num)
				{
				}
				num = (short)1718157313;
				if (num != 0)
				{
				}
				num = (short)155713536;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecureClearStrapping_A9095.Visible = value;
			}
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06001D6E RID: 7534 RVA: 0x001D3934 File Offset: 0x001D1B34
		// (set) Token: 0x06001D6F RID: 7535 RVA: 0x001D39E8 File Offset: 0x001D1BE8
		public bool TrkPerTalkgroupSecureClearStrapping_A9095_Editable
		{
			get
			{
				short num = (short)1330118656;
				short num2 = num;
				num = (short)1650793974;
				short num3 = num;
				num = (short)1925848566;
				switch (num3 == num)
				{
				}
				num = (short)294060033;
				if (num != 0)
				{
				}
				num = (short)245170176;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecureClearStrapping_A9095.Editable;
			}
			set
			{
				short num = (short)239992832;
				short num2 = num;
				num = (short)623975436;
				short num3 = num;
				num = (short)1405819916;
				switch (num3 == num)
				{
				}
				num = (short)1798569984;
				if (num != 0)
				{
				}
				num = (short)1003028481;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecureClearStrapping_A9095.Editable = value;
			}
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06001D70 RID: 7536 RVA: 0x001D3A9C File Offset: 0x001D1C9C
		internal string TrkPerTalkgroupSecureClearStrapping_A9095_UILabel
		{
			get
			{
				short num = (short)376176640;
				short num2 = num;
				num = (short)1298592165;
				short num3 = num;
				num = (short)798421413;
				switch (num3 == num)
				{
				}
				num = (short)93978624;
				if (num != 0)
				{
				}
				num = (short)1809055745;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecureClearStrapping_A9095.UIName;
			}
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06001D71 RID: 7537 RVA: 0x001D3B50 File Offset: 0x001D1D50
		// (set) Token: 0x06001D72 RID: 7538 RVA: 0x001D3C08 File Offset: 0x001D1E08
		internal bool TrkPerTalkgroupSecureClearStrapping_A9095_HiddenStatic
		{
			get
			{
				short num = (short)1107623936;
				short num2 = num;
				num = (short)1901334143;
				short num3 = num;
				num = (short)2096696959;
				switch (num3 == num)
				{
				}
				num = (short)880082945;
				if (num != 0)
				{
				}
				num = (short)1180565504;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecureClearStrapping_A9095.HiddenStatic;
			}
			set
			{
				short num = (short)795475968;
				short num2 = num;
				num = (short)432191477;
				short num3 = num;
				num = (short)1339602933;
				switch (num3 == num)
				{
				}
				num = (short)1191182336;
				if (num != 0)
				{
				}
				num = (short)1841954817;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecureClearStrapping_A9095.HiddenStatic = value;
			}
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06001D73 RID: 7539 RVA: 0x001D3CC0 File Offset: 0x001D1EC0
		// (set) Token: 0x06001D74 RID: 7540 RVA: 0x001D3D78 File Offset: 0x001D1F78
		internal bool TrkPerTalkgroupSecureClearStrapping_A9095_HiddenDynamic
		{
			get
			{
				short num = (short)1808334848;
				short num2 = num;
				num = (short)392757249;
				if (num != 0)
				{
				}
				num = (short)1464126;
				short num3 = num;
				num = (short)1211848510;
				switch (num3 == num)
				{
				}
				num = (short)238223360;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecureClearStrapping_A9095.HiddenDynamic;
			}
			set
			{
				short num = (short)1570111488;
				short num2 = num;
				num = (short)1823267897;
				short num3 = num;
				num = (short)1563483193;
				switch (num3 == num)
				{
				}
				num = (short)1959395329;
				if (num != 0)
				{
				}
				num = (short)1462173696;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupSecureClearStrapping_A9095.HiddenDynamic = value;
			}
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x06001D75 RID: 7541 RVA: 0x001D3E2C File Offset: 0x001D202C
		public bool TrkPerTalkgroupSecureClearStrapping_A9095_HasDiffs
		{
			get
			{
				short num = (short)1230962688;
				short num2 = num;
				num = (short)2131798535;
				short num3 = num;
				num = (short)406170119;
				switch (num3 == num)
				{
				}
				num = (short)453705728;
				if (num != 0)
				{
				}
				num = (short)1138360321;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupSecureClearStrapping_A9095._HasDiffs;
			}
		}

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x06001D76 RID: 7542 RVA: 0x001D3EE0 File Offset: 0x001D20E0
		// (set) Token: 0x06001D77 RID: 7543 RVA: 0x001D3F94 File Offset: 0x001D2194
		public int TrkPerTalkgroupTalkgroup_A9274Value
		{
			get
			{
				short num = (short)1295974400;
				short num2 = num;
				num = (short)473432065;
				if (num != 0)
				{
				}
				num = (short)755755139;
				short num3 = num;
				num = (short)1393879171;
				switch (num3 == num)
				{
				}
				num = (short)1085931520;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTalkgroup_A9274.Value;
			}
			set
			{
				short num = (short)1085800448;
				short num2 = num;
				num = (short)1722049301;
				short num3 = num;
				num = (short)242508565;
				switch (num3 == num)
				{
				}
				num = (short)2048851969;
				if (num != 0)
				{
				}
				num = (short)1237516288;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTalkgroup_A9274.Value = value;
			}
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x06001D78 RID: 7544 RVA: 0x001D4048 File Offset: 0x001D2248
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkPerTalkgroupTalkgroup_A9274
		{
			get
			{
				short num = (short)482279424;
				short num2 = num;
				num = (short)1150157084;
				short num3 = num;
				num = (short)2044461340;
				switch (num3 == num)
				{
				}
				num = (short)1599340545;
				if (num != 0)
				{
				}
				num = (short)1178402816;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTalkgroup_A9274;
			}
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x06001D79 RID: 7545 RVA: 0x001D40F8 File Offset: 0x001D22F8
		// (set) Token: 0x06001D7A RID: 7546 RVA: 0x001D41B0 File Offset: 0x001D23B0
		public string TrkPerTalkgroupTalkgroup_A9274_UIValue
		{
			get
			{
				short num = (short)1817182208;
				short num2 = num;
				num = (short)1298205767;
				short num3 = num;
				num = (short)451218503;
				switch (num3 == num)
				{
				}
				num = (short)2119892993;
				if (num != 0)
				{
				}
				num = (short)1700986880;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTalkgroup_A9274.UIValue;
			}
			set
			{
				short num = (short)202571776;
				short num2 = num;
				num = (short)276679631;
				short num3 = num;
				num = (short)712690639;
				switch (num3 == num)
				{
				}
				num = (short)895811585;
				if (num != 0)
				{
				}
				num = (short)1250295808;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTalkgroup_A9274.UIValue = value;
			}
		}

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x06001D7B RID: 7547 RVA: 0x001D4268 File Offset: 0x001D2468
		// (set) Token: 0x06001D7C RID: 7548 RVA: 0x001D431C File Offset: 0x001D251C
		public string TrkPerTalkgroupTalkgroup_A9274_HexUIValue
		{
			get
			{
				short num = (short)2076296502;
				short num2 = num;
				num = (short)767345974;
				switch (num2 == num)
				{
				}
				num = (short)1173291008;
				short num3 = num;
				num = (short)1911422977;
				if (num != 0)
				{
				}
				num = (short)1750532096;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTalkgroup_A9274.HexUIValue;
			}
			set
			{
				short num = (short)801551490;
				short num2 = num;
				num = (short)931902594;
				switch (num2 == num)
				{
				}
				num = (short)799735808;
				short num3 = num;
				num = (short)427360256;
				if (num != 0)
				{
				}
				num = (short)129368065;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTalkgroup_A9274.HexUIValue = value;
			}
		}

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x06001D7D RID: 7549 RVA: 0x001D43D0 File Offset: 0x001D25D0
		// (set) Token: 0x06001D7E RID: 7550 RVA: 0x001D4488 File Offset: 0x001D2688
		internal int TrkPerTalkgroupTalkgroup_A9274Min
		{
			get
			{
				short num = (short)728273230;
				short num2 = num;
				num = (short)1008832846;
				switch (num2 == num)
				{
				}
				num = (short)446431232;
				short num3 = num;
				num = (short)355991552;
				if (num != 0)
				{
				}
				num = (short)367853569;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTalkgroup_A9274.Min;
			}
			set
			{
				short num = (short)1834418177;
				if (num != 0)
				{
				}
				num = (short)1086463987;
				short num2 = num;
				num = (short)90906611;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1545207808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1042612224;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTalkgroup_A9274.Min = value;
			}
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x06001D7F RID: 7551 RVA: 0x001D453C File Offset: 0x001D273C
		// (set) Token: 0x06001D80 RID: 7552 RVA: 0x001D45F4 File Offset: 0x001D27F4
		internal int TrkPerTalkgroupTalkgroup_A9274Max
		{
			get
			{
				short num = (short)1645857583;
				short num2 = num;
				num = (short)1681640239;
				switch (num2 == num)
				{
				}
				num = (short)25296896;
				short num3 = num;
				num = (short)1280835585;
				if (num != 0)
				{
				}
				num = (short)2049048576;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTalkgroup_A9274.Max;
			}
			set
			{
				short num = (short)1182330225;
				short num2 = num;
				num = (short)955772273;
				switch (num2 == num)
				{
				}
				num = (short)957284352;
				short num3 = num;
				num = (short)2020278273;
				if (num != 0)
				{
				}
				num = (short)1805975552;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTalkgroup_A9274.Max = value;
			}
		}

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x001D46AC File Offset: 0x001D28AC
		// (set) Token: 0x06001D82 RID: 7554 RVA: 0x001D4760 File Offset: 0x001D2960
		internal int TrkPerTalkgroupTalkgroup_A9274Step
		{
			get
			{
				short num = (short)1369440257;
				if (num != 0)
				{
				}
				num = (short)1352039129;
				short num2 = num;
				num = (short)1549826777;
				switch (num2 == num)
				{
				default:
				{
					num = (short)802422784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1353187328;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTalkgroup_A9274.StepSize;
			}
			set
			{
				short num = (short)1984097834;
				short num2 = num;
				num = (short)101248554;
				switch (num2 == num)
				{
				}
				num = (short)395902976;
				short num3 = num;
				num = (short)837877760;
				if (num != 0)
				{
				}
				num = (short)716570625;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTalkgroup_A9274.StepSize = value;
			}
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x06001D83 RID: 7555 RVA: 0x001D4814 File Offset: 0x001D2A14
		// (set) Token: 0x06001D84 RID: 7556 RVA: 0x001D48CC File Offset: 0x001D2ACC
		public bool TrkPerTalkgroupTalkgroup_A9274_Applicable
		{
			get
			{
				short num = (short)2028419925;
				short num2 = num;
				num = (short)1594964821;
				switch (num2 == num)
				{
				}
				num = (short)1371865088;
				short num3 = num;
				num = (short)1675427841;
				if (num != 0)
				{
				}
				num = (short)1627848704;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTalkgroup_A9274.Applicable;
			}
			set
			{
				short num = (short)1407300114;
				short num2 = num;
				num = (short)992064018;
				switch (num2 == num)
				{
				}
				num = (short)1033568256;
				short num3 = num;
				num = (short)168886272;
				if (num != 0)
				{
				}
				num = (short)945881089;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTalkgroup_A9274.Applicable = value;
			}
		}

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x06001D85 RID: 7557 RVA: 0x001D4984 File Offset: 0x001D2B84
		// (set) Token: 0x06001D86 RID: 7558 RVA: 0x001D4A38 File Offset: 0x001D2C38
		public bool TrkPerTalkgroupTalkgroup_A9274_Valid
		{
			get
			{
				short num = (short)990248961;
				if (num != 0)
				{
				}
				num = (short)1627725509;
				short num2 = num;
				num = (short)1988894405;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1208811520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1758527488;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTalkgroup_A9274.Valid;
			}
			set
			{
				short num = (short)1536316512;
				short num2 = num;
				num = (short)762664032;
				switch (num2 == num)
				{
				}
				num = (short)337969152;
				short num3 = num;
				num = (short)790626305;
				if (num != 0)
				{
				}
				num = (short)1304428544;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTalkgroup_A9274.Valid = value;
			}
		}

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06001D87 RID: 7559 RVA: 0x001D4AF0 File Offset: 0x001D2CF0
		// (set) Token: 0x06001D88 RID: 7560 RVA: 0x001D4BA4 File Offset: 0x001D2DA4
		public bool TrkPerTalkgroupTalkgroup_A9274_Visible
		{
			get
			{
				short num = (short)2094450945;
				short num2 = num;
				num = (short)2026948865;
				switch (num2 == num)
				{
				}
				num = (short)1977090048;
				short num3 = num;
				num = (short)731709441;
				if (num != 0)
				{
				}
				num = (short)78774272;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTalkgroup_A9274.Visible;
			}
			set
			{
				short num = (short)1184276663;
				short num2 = num;
				num = (short)34250935;
				switch (num2 == num)
				{
				}
				num = (short)1448017920;
				short num3 = num;
				num = (short)86441985;
				if (num != 0)
				{
				}
				num = (short)677380096;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTalkgroup_A9274.Visible = value;
			}
		}

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06001D89 RID: 7561 RVA: 0x001D4C5C File Offset: 0x001D2E5C
		// (set) Token: 0x06001D8A RID: 7562 RVA: 0x001D4D14 File Offset: 0x001D2F14
		public bool TrkPerTalkgroupTalkgroup_A9274_Editable
		{
			get
			{
				short num = (short)1694375655;
				short num2 = num;
				num = (short)870063847;
				switch (num2 == num)
				{
				}
				num = (short)1494286336;
				short num3 = num;
				num = (short)1525481473;
				if (num != 0)
				{
				}
				num = (short)1425932288;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTalkgroup_A9274.Editable;
			}
			set
			{
				short num = (short)889945193;
				short num2 = num;
				num = (short)747338857;
				switch (num2 == num)
				{
				}
				num = (short)1904345088;
				short num3 = num;
				num = (short)1984692225;
				if (num != 0)
				{
				}
				num = (short)19660800;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTalkgroup_A9274.Editable = value;
			}
		}

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06001D8B RID: 7563 RVA: 0x001D4DCC File Offset: 0x001D2FCC
		internal string TrkPerTalkgroupTalkgroup_A9274_UILabel
		{
			get
			{
				short num = (short)1575036351;
				short num2 = num;
				num = (short)1332291007;
				switch (num2 == num)
				{
				}
				num = (short)323223552;
				short num3 = num;
				num = (short)730267648;
				if (num != 0)
				{
				}
				num = (short)418578433;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTalkgroup_A9274.UIName;
			}
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x06001D8C RID: 7564 RVA: 0x001D4E80 File Offset: 0x001D3080
		// (set) Token: 0x06001D8D RID: 7565 RVA: 0x001D4F38 File Offset: 0x001D3138
		internal bool TrkPerTalkgroupTalkgroup_A9274_HiddenStatic
		{
			get
			{
				short num = (short)746285539;
				short num2 = num;
				num = (short)291531235;
				switch (num2 == num)
				{
				}
				num = (short)939458560;
				short num3 = num;
				num = (short)2017984513;
				if (num != 0)
				{
				}
				num = (short)1537212416;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTalkgroup_A9274.HiddenStatic;
			}
			set
			{
				short num = (short)1491420672;
				short num2 = num;
				num = (short)977880576;
				switch (num2 == num)
				{
				}
				num = (short)1402470400;
				short num3 = num;
				num = (short)428802049;
				if (num != 0)
				{
				}
				num = (short)280297472;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTalkgroup_A9274.HiddenStatic = value;
			}
		}

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06001D8E RID: 7566 RVA: 0x001D4FEC File Offset: 0x001D31EC
		// (set) Token: 0x06001D8F RID: 7567 RVA: 0x001D50A0 File Offset: 0x001D32A0
		internal bool TrkPerTalkgroupTalkgroup_A9274_HiddenDynamic
		{
			get
			{
				short num = (short)1010919586;
				short num2 = num;
				num = (short)144337058;
				switch (num2 == num)
				{
				}
				num = (short)966328320;
				short num3 = num;
				num = (short)1829175297;
				if (num != 0)
				{
				}
				num = (short)726138880;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTalkgroup_A9274.HiddenDynamic;
			}
			set
			{
				short num = (short)1601038044;
				short num2 = num;
				num = (short)1402201820;
				switch (num2 == num)
				{
				}
				num = (short)1936064512;
				short num3 = num;
				num = (short)1563623425;
				if (num != 0)
				{
				}
				num = (short)1931411456;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTalkgroup_A9274.HiddenDynamic = value;
			}
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x06001D90 RID: 7568 RVA: 0x001D5158 File Offset: 0x001D3358
		public bool TrkPerTalkgroupTalkgroup_A9274_HasDiffs
		{
			get
			{
				short num = (short)581828609;
				if (num != 0)
				{
				}
				num = (short)832456427;
				short num2 = num;
				num = (short)1693271787;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1256652800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1438515200;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTalkgroup_A9274._HasDiffs;
			}
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x06001D91 RID: 7569 RVA: 0x001D5210 File Offset: 0x001D3410
		// (set) Token: 0x06001D92 RID: 7570 RVA: 0x001D52C4 File Offset: 0x001D34C4
		public int TrkPerTalkgroupTxVoiceSignalType_A9575Value
		{
			get
			{
				short num = (short)15021150;
				short num2 = num;
				num = (short)1091908702;
				switch (num2 == num)
				{
				}
				num = (short)1309605888;
				short num3 = num;
				num = (short)274137088;
				if (num != 0)
				{
				}
				num = (short)1912471553;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTxVoiceSignalType_A9575.Value;
			}
			set
			{
				short num = (short)474944588;
				short num2 = num;
				num = (short)1765348428;
				switch (num2 == num)
				{
				}
				num = (short)666959872;
				short num3 = num;
				num = (short)465960961;
				if (num != 0)
				{
				}
				num = (short)1516437504;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTxVoiceSignalType_A9575.Value = value;
			}
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06001D93 RID: 7571 RVA: 0x001D537C File Offset: 0x001D357C
		// (set) Token: 0x06001D94 RID: 7572 RVA: 0x001D5438 File Offset: 0x001D3638
		public string TrkPerTalkgroupTxVoiceSignalType_A9575_UIValue
		{
			get
			{
				short num = (short)1289682945;
				if (num != 0)
				{
				}
				num = (short)1507039937;
				short num2 = num;
				num = (short)1388550849;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1035599872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)525533184;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTxVoiceSignalType_A9575.UIValue;
			}
			set
			{
				short num = (short)584122369;
				if (num != 0)
				{
				}
				num = (short)1049465165;
				short num2 = num;
				num = (short)462786893;
				switch (num2 == num)
				{
				default:
				{
					num = (short)639172608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1759510528;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTxVoiceSignalType_A9575.UIValue = value;
			}
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x06001D95 RID: 7573 RVA: 0x001D54EC File Offset: 0x001D36EC
		public global::AcpBusinessLayer.AcpListField TrkPerTalkgroupTxVoiceSignalType_A9575
		{
			get
			{
				short num = (short)243073025;
				if (num != 0)
				{
				}
				num = (short)59842214;
				short num2 = num;
				num = (short)1931812518;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1308688384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)850067456;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTxVoiceSignalType_A9575;
			}
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x06001D96 RID: 7574 RVA: 0x001D5598 File Offset: 0x001D3798
		// (set) Token: 0x06001D97 RID: 7575 RVA: 0x001D5648 File Offset: 0x001D3848
		public bool TrkPerTalkgroupTxVoiceSignalType_A9575_Applicable
		{
			get
			{
				short num = (short)501678081;
				if (num != 0)
				{
				}
				num = (short)1646791280;
				short num2 = num;
				num = (short)1578830448;
				switch (num2 == num)
				{
				default:
				{
					num = (short)656080896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1914961920;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTxVoiceSignalType_A9575.Applicable;
			}
			set
			{
				short num = (short)893504153;
				short num2 = num;
				num = (short)1912851097;
				switch (num2 == num)
				{
				}
				num = (short)2003435520;
				short num3 = num;
				num = (short)1689255937;
				if (num != 0)
				{
				}
				num = (short)1756626944;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTxVoiceSignalType_A9575.Applicable = value;
			}
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x06001D98 RID: 7576 RVA: 0x001D56FC File Offset: 0x001D38FC
		// (set) Token: 0x06001D99 RID: 7577 RVA: 0x001D57B4 File Offset: 0x001D39B4
		public bool TrkPerTalkgroupTxVoiceSignalType_A9575_Valid
		{
			get
			{
				short num = (short)1154203487;
				short num2 = num;
				num = (short)1478344543;
				switch (num2 == num)
				{
				}
				num = (short)1889730560;
				short num3 = num;
				num = (short)1419051009;
				if (num != 0)
				{
				}
				num = (short)650117120;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTxVoiceSignalType_A9575.Valid;
			}
			set
			{
				short num = (short)2029977601;
				if (num != 0)
				{
				}
				num = (short)1438942975;
				short num2 = num;
				num = (short)186877695;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1292828672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)788987904;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTxVoiceSignalType_A9575.Valid = value;
			}
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x06001D9A RID: 7578 RVA: 0x001D586C File Offset: 0x001D3A6C
		// (set) Token: 0x06001D9B RID: 7579 RVA: 0x001D5920 File Offset: 0x001D3B20
		public bool TrkPerTalkgroupTxVoiceSignalType_A9575_Visible
		{
			get
			{
				short num = (short)700772737;
				short num2 = num;
				num = (short)203223425;
				switch (num2 == num)
				{
				}
				num = (short)247922688;
				short num3 = num;
				num = (short)335413249;
				if (num != 0)
				{
				}
				num = (short)797310976;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTxVoiceSignalType_A9575.Visible;
			}
			set
			{
				short num = (short)1256207778;
				short num2 = num;
				num = (short)1851798946;
				switch (num2 == num)
				{
				}
				num = (short)1064828928;
				short num3 = num;
				num = (short)847183873;
				if (num != 0)
				{
				}
				num = (short)399310848;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTxVoiceSignalType_A9575.Visible = value;
			}
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x06001D9C RID: 7580 RVA: 0x001D59D8 File Offset: 0x001D3BD8
		// (set) Token: 0x06001D9D RID: 7581 RVA: 0x001D5A8C File Offset: 0x001D3C8C
		public bool TrkPerTalkgroupTxVoiceSignalType_A9575_Editable
		{
			get
			{
				short num = (short)619913892;
				short num2 = num;
				num = (short)288891556;
				switch (num2 == num)
				{
				}
				num = (short)23658496;
				short num3 = num;
				num = (short)271122432;
				if (num != 0)
				{
				}
				num = (short)205586433;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTxVoiceSignalType_A9575.Editable;
			}
			set
			{
				short num = (short)529447797;
				short num2 = num;
				num = (short)9157493;
				switch (num2 == num)
				{
				}
				num = (short)1571946496;
				short num3 = num;
				num = (short)1995964416;
				if (num != 0)
				{
				}
				num = (short)477429761;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTxVoiceSignalType_A9575.Editable = value;
			}
		}

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06001D9E RID: 7582 RVA: 0x001D5B40 File Offset: 0x001D3D40
		internal string TrkPerTalkgroupTxVoiceSignalType_A9575_UILabel
		{
			get
			{
				short num = (short)915785746;
				short num2 = num;
				num = (short)949209106;
				switch (num2 == num)
				{
				}
				num = (short)1473052672;
				short num3 = num;
				num = (short)1433796609;
				if (num != 0)
				{
				}
				num = (short)2001010688;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTxVoiceSignalType_A9575.UIName;
			}
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06001D9F RID: 7583 RVA: 0x001D5BF4 File Offset: 0x001D3DF4
		// (set) Token: 0x06001DA0 RID: 7584 RVA: 0x001D5CAC File Offset: 0x001D3EAC
		internal bool TrkPerTalkgroupTxVoiceSignalType_A9575_HiddenStatic
		{
			get
			{
				short num = (short)342770127;
				short num2 = num;
				num = (short)2100183503;
				switch (num2 == num)
				{
				}
				num = (short)590086144;
				short num3 = num;
				num = (short)588251136;
				if (num != 0)
				{
				}
				num = (short)905183233;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTxVoiceSignalType_A9575.HiddenStatic;
			}
			set
			{
				short num = (short)44297913;
				short num2 = num;
				num = (short)1146941113;
				switch (num2 == num)
				{
				}
				num = (short)1117585408;
				short num3 = num;
				num = (short)603258880;
				if (num != 0)
				{
				}
				num = (short)33357825;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTxVoiceSignalType_A9575.HiddenStatic = value;
			}
		}

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06001DA1 RID: 7585 RVA: 0x001D5D64 File Offset: 0x001D3F64
		// (set) Token: 0x06001DA2 RID: 7586 RVA: 0x001D5E18 File Offset: 0x001D4018
		internal bool TrkPerTalkgroupTxVoiceSignalType_A9575_HiddenDynamic
		{
			get
			{
				short num = (short)1890825922;
				short num2 = num;
				num = (short)545633986;
				switch (num2 == num)
				{
				}
				num = (short)535363584;
				short num3 = num;
				num = (short)1119551489;
				if (num != 0)
				{
				}
				num = (short)1467416576;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTxVoiceSignalType_A9575.HiddenDynamic;
			}
			set
			{
				short num = (short)813432833;
				if (num != 0)
				{
				}
				num = (short)1449328640;
				short num2 = num;
				num = (short)1392134159;
				short num3 = num;
				num = (short)1587234831;
				switch (num3 == num)
				{
				}
				num = (short)1001324544;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTxVoiceSignalType_A9575.HiddenDynamic = value;
			}
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x001D5ECC File Offset: 0x001D40CC
		public bool TrkPerTalkgroupTxVoiceSignalType_A9575_HasDiffs
		{
			get
			{
				short num = (short)487587841;
				if (num != 0)
				{
				}
				num = (short)1795883008;
				short num2 = num;
				num = (short)177898190;
				short num3 = num;
				num = (short)1826456270;
				switch (num3 == num)
				{
				}
				num = (short)2146304000;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTxVoiceSignalType_A9575._HasDiffs;
			}
		}

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x001D5F80 File Offset: 0x001D4180
		// (set) Token: 0x06001DA5 RID: 7589 RVA: 0x001D6034 File Offset: 0x001D4234
		public int TrkPerTalkgroupTGSystemID_A19715Value
		{
			get
			{
				short num = (short)1115904851;
				short num2 = num;
				num = (short)869358419;
				switch (num2 == num)
				{
				default:
				{
					num = (short)893714432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)560070656;
				if (num != 0)
				{
				}
				num = (short)1686896641;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSystemID_A19715.Value;
			}
			set
			{
				short num = (short)69788321;
				short num2 = num;
				num = (short)1783882401;
				switch (num2 == num)
				{
				default:
				{
					num = (short)849149952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)902365184;
				if (num != 0)
				{
				}
				num = (short)1234501633;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGSystemID_A19715.Value = value;
			}
		}

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x001D60EC File Offset: 0x001D42EC
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkPerTalkgroupTGSystemID_A19715
		{
			get
			{
				short num = (short)453929466;
				short num2 = num;
				num = (short)930441722;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1503985664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1723269120;
				if (num != 0)
				{
				}
				num = (short)446955521;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSystemID_A19715;
			}
		}

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x001D619C File Offset: 0x001D439C
		// (set) Token: 0x06001DA8 RID: 7592 RVA: 0x001D6254 File Offset: 0x001D4454
		public string TrkPerTalkgroupTGSystemID_A19715_UIValue
		{
			get
			{
				short num = (short)813748960;
				short num2 = num;
				num = (short)308859616;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1198325760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1972502528;
				if (num != 0)
				{
				}
				num = (short)1438777345;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSystemID_A19715.UIValue;
			}
			set
			{
				short num = (short)1539029535;
				short num2 = num;
				num = (short)17938975;
				switch (num2 == num)
				{
				default:
				{
					num = (short)780206080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)380239872;
				if (num != 0)
				{
				}
				num = (short)1433403393;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGSystemID_A19715.UIValue = value;
			}
		}

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x001D6308 File Offset: 0x001D4508
		// (set) Token: 0x06001DAA RID: 7594 RVA: 0x001D63BC File Offset: 0x001D45BC
		public string TrkPerTalkgroupTGSystemID_A19715_HexUIValue
		{
			get
			{
				short num = (short)1995370228;
				short num2 = num;
				num = (short)1787752180;
				switch (num2 == num)
				{
				default:
				{
					num = (short)208470016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1501888513;
				if (num != 0)
				{
				}
				num = (short)1110638592;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSystemID_A19715.HexUIValue;
			}
			set
			{
				short num = (short)1191884422;
				short num2 = num;
				num = (short)323466886;
				switch (num2 == num)
				{
				default:
				{
					num = (short)192675840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)465502209;
				if (num != 0)
				{
				}
				num = (short)1282211840;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGSystemID_A19715.HexUIValue = value;
			}
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06001DAB RID: 7595 RVA: 0x001D6474 File Offset: 0x001D4674
		// (set) Token: 0x06001DAC RID: 7596 RVA: 0x001D6528 File Offset: 0x001D4728
		internal int TrkPerTalkgroupTGSystemID_A19715Min
		{
			get
			{
				short num = (short)745913682;
				short num2 = num;
				num = (short)1092468050;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1207500800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1048903681;
				if (num != 0)
				{
				}
				num = (short)26673152;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSystemID_A19715.Min;
			}
			set
			{
				short num = (short)25439646;
				short num2 = num;
				num = (short)1325542814;
				switch (num2 == num)
				{
				default:
				{
					num = (short)601686016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)749273089;
				if (num != 0)
				{
				}
				num = (short)1576861696;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGSystemID_A19715.Min = value;
			}
		}

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06001DAD RID: 7597 RVA: 0x001D65DC File Offset: 0x001D47DC
		// (set) Token: 0x06001DAE RID: 7598 RVA: 0x001D6690 File Offset: 0x001D4890
		internal int TrkPerTalkgroupTGSystemID_A19715Max
		{
			get
			{
				short num = (short)1281753089;
				if (num != 0)
				{
				}
				num = (short)2028208128;
				short num2 = num;
				num = (short)495698627;
				short num3 = num;
				num = (short)1529070275;
				switch (num3 == num)
				{
				}
				num = (short)114556928;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSystemID_A19715.Max;
			}
			set
			{
				short num = (short)65861938;
				short num2 = num;
				num = (short)447740210;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2018705408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)651165696;
				if (num != 0)
				{
				}
				num = (short)840105985;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGSystemID_A19715.Max = value;
			}
		}

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x06001DAF RID: 7599 RVA: 0x001D6744 File Offset: 0x001D4944
		// (set) Token: 0x06001DB0 RID: 7600 RVA: 0x001D67FC File Offset: 0x001D49FC
		internal int TrkPerTalkgroupTGSystemID_A19715Step
		{
			get
			{
				short num = (short)1163836187;
				short num2 = num;
				num = (short)2062269211;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1914699776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)882573312;
				if (num != 0)
				{
				}
				num = (short)877592577;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSystemID_A19715.StepSize;
			}
			set
			{
				short num = (short)1581622181;
				short num2 = num;
				num = (short)1807262629;
				switch (num2 == num)
				{
				default:
				{
					num = (short)901251072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1773469697;
				if (num != 0)
				{
				}
				num = (short)71041024;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGSystemID_A19715.StepSize = value;
			}
		}

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x001D68B4 File Offset: 0x001D4AB4
		// (set) Token: 0x06001DB2 RID: 7602 RVA: 0x001D6968 File Offset: 0x001D4B68
		public bool TrkPerTalkgroupTGSystemID_A19715_Applicable
		{
			get
			{
				short num = (short)1154671858;
				short num2 = num;
				num = (short)1437852914;
				switch (num2 == num)
				{
				default:
				{
					num = (short)908853248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)975568897;
				if (num != 0)
				{
				}
				num = (short)1635123200;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSystemID_A19715.Applicable;
			}
			set
			{
				short num = (short)709918282;
				short num2 = num;
				num = (short)445677130;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1794179072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)605487105;
				if (num != 0)
				{
				}
				num = (short)1191444480;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGSystemID_A19715.Applicable = value;
			}
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x06001DB3 RID: 7603 RVA: 0x001D6A1C File Offset: 0x001D4C1C
		// (set) Token: 0x06001DB4 RID: 7604 RVA: 0x001D6AD4 File Offset: 0x001D4CD4
		public bool TrkPerTalkgroupTGSystemID_A19715_Valid
		{
			get
			{
				short num = (short)2073985059;
				short num2 = num;
				num = (short)1864925219;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1095499776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)220266496;
				if (num != 0)
				{
				}
				num = (short)1112801281;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSystemID_A19715.Valid;
			}
			set
			{
				short num = (short)1886223618;
				short num2 = num;
				num = (short)1470397698;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1897660416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1029242881;
				if (num != 0)
				{
				}
				num = (short)2029912064;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGSystemID_A19715.Valid = value;
			}
		}

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x001D6B88 File Offset: 0x001D4D88
		// (set) Token: 0x06001DB6 RID: 7606 RVA: 0x001D6C3C File Offset: 0x001D4E3C
		public bool TrkPerTalkgroupTGSystemID_A19715_Visible
		{
			get
			{
				short num = (short)1879900161;
				if (num != 0)
				{
				}
				num = (short)2073165824;
				short num2 = num;
				num = (short)353142066;
				short num3 = num;
				num = (short)242976050;
				switch (num3 == num)
				{
				}
				num = (short)162267136;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSystemID_A19715.Visible;
			}
			set
			{
				short num = (short)12845057;
				if (num != 0)
				{
				}
				num = (short)239009792;
				short num2 = num;
				num = (short)245709281;
				short num3 = num;
				num = (short)846215649;
				switch (num3 == num)
				{
				}
				num = (short)598933504;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGSystemID_A19715.Visible = value;
			}
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x001D6CF0 File Offset: 0x001D4EF0
		// (set) Token: 0x06001DB8 RID: 7608 RVA: 0x001D6DA8 File Offset: 0x001D4FA8
		public bool TrkPerTalkgroupTGSystemID_A19715_Editable
		{
			get
			{
				short num = (short)1916260042;
				short num2 = num;
				num = (short)1028705994;
				switch (num2 == num)
				{
				default:
				{
					num = (short)952107008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)398655489;
				if (num != 0)
				{
				}
				num = (short)137363456;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSystemID_A19715.Editable;
			}
			set
			{
				short num = (short)1960968193;
				if (num != 0)
				{
				}
				num = (short)1427963904;
				short num2 = num;
				num = (short)606695529;
				short num3 = num;
				num = (short)1615556713;
				switch (num3 == num)
				{
				}
				num = (short)1641873408;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGSystemID_A19715.Editable = value;
			}
		}

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x001D6E5C File Offset: 0x001D505C
		internal string TrkPerTalkgroupTGSystemID_A19715_UILabel
		{
			get
			{
				short num = (short)973874064;
				short num2 = num;
				num = (short)409084816;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1389035520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1241579521;
				if (num != 0)
				{
				}
				num = (short)985071616;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSystemID_A19715.UIName;
			}
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06001DBA RID: 7610 RVA: 0x001D6F14 File Offset: 0x001D5114
		// (set) Token: 0x06001DBB RID: 7611 RVA: 0x001D6FCC File Offset: 0x001D51CC
		internal bool TrkPerTalkgroupTGSystemID_A19715_HiddenStatic
		{
			get
			{
				short num = (short)653818869;
				short num2 = num;
				num = (short)1704688629;
				switch (num2 == num)
				{
				default:
				{
					num = (short)660078592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1805123584;
				if (num != 0)
				{
				}
				num = (short)1862270977;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSystemID_A19715.HiddenStatic;
			}
			set
			{
				short num = (short)691350291;
				short num2 = num;
				num = (short)608447251;
				switch (num2 == num)
				{
				default:
				{
					num = (short)787349504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)571080704;
				if (num != 0)
				{
				}
				num = (short)351797249;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGSystemID_A19715.HiddenStatic = value;
			}
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x06001DBC RID: 7612 RVA: 0x001D7080 File Offset: 0x001D5280
		// (set) Token: 0x06001DBD RID: 7613 RVA: 0x001D7134 File Offset: 0x001D5334
		internal bool TrkPerTalkgroupTGSystemID_A19715_HiddenDynamic
		{
			get
			{
				short num = (short)915483971;
				short num2 = num;
				num = (short)679750979;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1442054144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1925644289;
				if (num != 0)
				{
				}
				num = (short)1441071104;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSystemID_A19715.HiddenDynamic;
			}
			set
			{
				short num = (short)2033393342;
				short num2 = num;
				num = (short)802496190;
				switch (num2 == num)
				{
				default:
				{
					num = (short)330235904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1219166208;
				if (num != 0)
				{
				}
				num = (short)121503745;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGSystemID_A19715.HiddenDynamic = value;
			}
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x06001DBE RID: 7614 RVA: 0x001D71EC File Offset: 0x001D53EC
		public bool TrkPerTalkgroupTGSystemID_A19715_HasDiffs
		{
			get
			{
				short num = (short)800892508;
				short num2 = num;
				num = (short)1291495004;
				switch (num2 == num)
				{
				default:
				{
					num = (short)798556160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)943652865;
				if (num != 0)
				{
				}
				num = (short)856948736;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSystemID_A19715._HasDiffs;
			}
		}

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x06001DBF RID: 7615 RVA: 0x001D729C File Offset: 0x001D549C
		// (set) Token: 0x06001DC0 RID: 7616 RVA: 0x001D7350 File Offset: 0x001D5550
		public int TrkPerTalkgroupTGWACNID_A19716Value
		{
			get
			{
				short num = (short)1633281345;
				short num2 = num;
				num = (short)577168705;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1477509120;
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
				num = (short)1044054016;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGWACNID_A19716.Value;
			}
			set
			{
				short num = (short)1793021653;
				short num2 = num;
				num = (short)82073301;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1536229376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)262275073;
				if (num != 0)
				{
				}
				num = (short)1983184896;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGWACNID_A19716.Value = value;
			}
		}

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x001D7404 File Offset: 0x001D5604
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkPerTalkgroupTGWACNID_A19716
		{
			get
			{
				short num = (short)1999714969;
				short num2 = num;
				num = (short)68303513;
				switch (num2 == num)
				{
				default:
				{
					num = (short)598999040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)726663169;
				if (num != 0)
				{
				}
				num = (short)341311488;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGWACNID_A19716;
			}
		}

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x001D74B4 File Offset: 0x001D56B4
		// (set) Token: 0x06001DC3 RID: 7619 RVA: 0x001D756C File Offset: 0x001D576C
		public string TrkPerTalkgroupTGWACNID_A19716_UIValue
		{
			get
			{
				short num = (short)1677066241;
				if (num != 0)
				{
				}
				num = (short)1156120576;
				short num2 = num;
				num = (short)151271173;
				short num3 = num;
				num = (short)1266169605;
				switch (num3 == num)
				{
				}
				num = (short)1485766656;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGWACNID_A19716.UIValue;
			}
			set
			{
				short num = (short)1038725920;
				short num2 = num;
				num = (short)537178912;
				switch (num2 == num)
				{
				default:
				{
					num = (short)952303616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)899678209;
				if (num != 0)
				{
				}
				num = (short)1609302016;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGWACNID_A19716.UIValue = value;
			}
		}

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x06001DC4 RID: 7620 RVA: 0x001D7620 File Offset: 0x001D5820
		// (set) Token: 0x06001DC5 RID: 7621 RVA: 0x001D76D8 File Offset: 0x001D58D8
		public string TrkPerTalkgroupTGWACNID_A19716_HexUIValue
		{
			get
			{
				short num = (short)435748337;
				short num2 = num;
				num = (short)830340593;
				switch (num2 == num)
				{
				default:
				{
					num = (short)999030784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)771293185;
				if (num != 0)
				{
				}
				num = (short)1407844352;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGWACNID_A19716.HexUIValue;
			}
			set
			{
				short num = (short)1393223124;
				short num2 = num;
				num = (short)1982260692;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1136263168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1852571649;
				if (num != 0)
				{
				}
				num = (short)1843134464;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGWACNID_A19716.HexUIValue = value;
			}
		}

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x001D778C File Offset: 0x001D598C
		// (set) Token: 0x06001DC7 RID: 7623 RVA: 0x001D7840 File Offset: 0x001D5A40
		internal int TrkPerTalkgroupTGWACNID_A19716Min
		{
			get
			{
				short num = (short)2073332616;
				short num2 = num;
				num = (short)96635784;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1975844864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)452329473;
				if (num != 0)
				{
				}
				num = (short)1848442880;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGWACNID_A19716.Min;
			}
			set
			{
				short num = (short)1428946945;
				if (num != 0)
				{
				}
				num = (short)1801846784;
				short num2 = num;
				num = (short)620848202;
				short num3 = num;
				num = (short)1934779466;
				switch (num3 == num)
				{
				}
				num = (short)1105657856;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGWACNID_A19716.Min = value;
			}
		}

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x001D78F4 File Offset: 0x001D5AF4
		// (set) Token: 0x06001DC9 RID: 7625 RVA: 0x001D79A8 File Offset: 0x001D5BA8
		internal int TrkPerTalkgroupTGWACNID_A19716Max
		{
			get
			{
				short num = (short)1309919844;
				short num2 = num;
				num = (short)957074020;
				switch (num2 == num)
				{
				default:
				{
					num = (short)192937984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1633681408;
				if (num != 0)
				{
				}
				num = (short)28049409;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGWACNID_A19716.Max;
			}
			set
			{
				short num = (short)893403499;
				short num2 = num;
				num = (short)1995391339;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2094989312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)585695232;
				if (num != 0)
				{
				}
				num = (short)1963196417;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGWACNID_A19716.Max = value;
			}
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x06001DCA RID: 7626 RVA: 0x001D7A5C File Offset: 0x001D5C5C
		// (set) Token: 0x06001DCB RID: 7627 RVA: 0x001D7B10 File Offset: 0x001D5D10
		internal int TrkPerTalkgroupTGWACNID_A19716Step
		{
			get
			{
				short num = (short)712376321;
				if (num != 0)
				{
				}
				num = (short)281739264;
				short num2 = num;
				num = (short)1579737249;
				short num3 = num;
				num = (short)1521737889;
				switch (num3 == num)
				{
				}
				num = (short)1941241856;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGWACNID_A19716.StepSize;
			}
			set
			{
				short num = (short)563192409;
				short num2 = num;
				num = (short)2111873625;
				switch (num2 == num)
				{
				default:
				{
					num = (short)573571072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)446562304;
				if (num != 0)
				{
				}
				num = (short)526581761;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGWACNID_A19716.StepSize = value;
			}
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x06001DCC RID: 7628 RVA: 0x001D7BC8 File Offset: 0x001D5DC8
		// (set) Token: 0x06001DCD RID: 7629 RVA: 0x001D7C80 File Offset: 0x001D5E80
		public bool TrkPerTalkgroupTGWACNID_A19716_Applicable
		{
			get
			{
				short num = (short)840656927;
				short num2 = num;
				num = (short)1649109023;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1635647488;
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
				num = (short)87883776;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGWACNID_A19716.Applicable;
			}
			set
			{
				short num = (short)889998622;
				short num2 = num;
				num = (short)1753959710;
				switch (num2 == num)
				{
				default:
				{
					num = (short)270598144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1894645761;
				if (num != 0)
				{
				}
				num = (short)706805760;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGWACNID_A19716.Applicable = value;
			}
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x06001DCE RID: 7630 RVA: 0x001D7D38 File Offset: 0x001D5F38
		// (set) Token: 0x06001DCF RID: 7631 RVA: 0x001D7DEC File Offset: 0x001D5FEC
		public bool TrkPerTalkgroupTGWACNID_A19716_Valid
		{
			get
			{
				short num = (short)1441333249;
				if (num != 0)
				{
				}
				num = (short)1300103168;
				short num2 = num;
				num = (short)172203259;
				short num3 = num;
				num = (short)1894358267;
				switch (num3 == num)
				{
				}
				num = (short)244383744;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGWACNID_A19716.Valid;
			}
			set
			{
				short num = (short)1544158363;
				short num2 = num;
				num = (short)1752562843;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1704329216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1140588545;
				if (num != 0)
				{
				}
				num = (short)48300032;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGWACNID_A19716.Valid = value;
			}
		}

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x001D7EA0 File Offset: 0x001D60A0
		// (set) Token: 0x06001DD1 RID: 7633 RVA: 0x001D7F58 File Offset: 0x001D6158
		public bool TrkPerTalkgroupTGWACNID_A19716_Visible
		{
			get
			{
				short num = (short)1618149377;
				if (num != 0)
				{
				}
				num = (short)967180288;
				short num2 = num;
				num = (short)34639309;
				short num3 = num;
				num = (short)1114672589;
				switch (num3 == num)
				{
				}
				num = (short)184745984;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGWACNID_A19716.Visible;
			}
			set
			{
				short num = (short)654259813;
				short num2 = num;
				num = (short)802436709;
				switch (num2 == num)
				{
				default:
				{
					num = (short)188088320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1596784640;
				if (num != 0)
				{
				}
				num = (short)1831469057;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGWACNID_A19716.Visible = value;
			}
		}

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x001D8010 File Offset: 0x001D6210
		// (set) Token: 0x06001DD3 RID: 7635 RVA: 0x001D80C4 File Offset: 0x001D62C4
		public bool TrkPerTalkgroupTGWACNID_A19716_Editable
		{
			get
			{
				short num = (short)1651675644;
				short num2 = num;
				num = (short)1021547004;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1413808128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)693764097;
				if (num != 0)
				{
				}
				num = (short)1652752384;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGWACNID_A19716.Editable;
			}
			set
			{
				short num = (short)349191602;
				short num2 = num;
				num = (short)1242512818;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2067267584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1524695041;
				if (num != 0)
				{
				}
				num = (short)2031616000;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGWACNID_A19716.Editable = value;
			}
		}

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x001D8178 File Offset: 0x001D6378
		internal string TrkPerTalkgroupTGWACNID_A19716_UILabel
		{
			get
			{
				short num = (short)2046246186;
				short num2 = num;
				num = (short)2025602346;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1990918144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1504903169;
				if (num != 0)
				{
				}
				num = (short)1479802880;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGWACNID_A19716.UIName;
			}
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x06001DD5 RID: 7637 RVA: 0x001D8230 File Offset: 0x001D6430
		// (set) Token: 0x06001DD6 RID: 7638 RVA: 0x001D82E4 File Offset: 0x001D64E4
		internal bool TrkPerTalkgroupTGWACNID_A19716_HiddenStatic
		{
			get
			{
				short num = (short)611665902;
				short num2 = num;
				num = (short)468207598;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1255931904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)510328833;
				if (num != 0)
				{
				}
				num = (short)792788992;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGWACNID_A19716.HiddenStatic;
			}
			set
			{
				short num = (short)176932045;
				short num2 = num;
				num = (short)1292289229;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1608777728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)534708224;
				if (num != 0)
				{
				}
				num = (short)699924481;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGWACNID_A19716.HiddenStatic = value;
			}
		}

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x001D839C File Offset: 0x001D659C
		// (set) Token: 0x06001DD8 RID: 7640 RVA: 0x001D8454 File Offset: 0x001D6654
		internal bool TrkPerTalkgroupTGWACNID_A19716_HiddenDynamic
		{
			get
			{
				short num = (short)500132230;
				short num2 = num;
				num = (short)1061710214;
				switch (num2 == num)
				{
				default:
				{
					num = (short)536084480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)342294528;
				if (num != 0)
				{
				}
				num = (short)799277057;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGWACNID_A19716.HiddenDynamic;
			}
			set
			{
				short num = (short)1724218592;
				short num2 = num;
				num = (short)779910368;
				switch (num2 == num)
				{
				default:
				{
					num = (short)221446144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1020919809;
				if (num != 0)
				{
				}
				num = (short)1930035200;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGWACNID_A19716.HiddenDynamic = value;
			}
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x06001DD9 RID: 7641 RVA: 0x001D850C File Offset: 0x001D670C
		public bool TrkPerTalkgroupTGWACNID_A19716_HasDiffs
		{
			get
			{
				short num = (short)936540485;
				short num2 = num;
				num = (short)737966405;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1272053760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)642514945;
				if (num != 0)
				{
				}
				num = (short)1883963392;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGWACNID_A19716._HasDiffs;
			}
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x001D85C0 File Offset: 0x001D67C0
		// (set) Token: 0x06001DDB RID: 7643 RVA: 0x001D8674 File Offset: 0x001D6874
		public bool TrkPerTalkgroupTGSecondaryFailsoft_A19989Value
		{
			get
			{
				short num = (short)609091584;
				short num2 = num;
				num = (short)991952897;
				if (num != 0)
				{
				}
				num = (short)763892325;
				short num3 = num;
				num = (short)775164517;
				switch (num3 == num)
				{
				}
				num = (short)1530068992;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSecondaryFailsoft_A19989.Value;
			}
			set
			{
				short num = (short)250871808;
				short num2 = num;
				num = (short)1544697794;
				short num3 = num;
				num = (short)1796945858;
				switch (num3 == num)
				{
				}
				num = (short)291373057;
				if (num != 0)
				{
				}
				num = (short)393084928;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGSecondaryFailsoft_A19989.Value = value;
			}
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x06001DDC RID: 7644 RVA: 0x001D8728 File Offset: 0x001D6928
		public global::AcpBusinessLayer.AcpField<bool> TrkPerTalkgroupTGSecondaryFailsoft_A19989
		{
			get
			{
				short num = (short)442368000;
				short num2 = num;
				num = (short)1700790273;
				if (num != 0)
				{
				}
				num = (short)657811115;
				short num3 = num;
				num = (short)1256220331;
				switch (num3 == num)
				{
				}
				num = (short)1150418944;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSecondaryFailsoft_A19989;
			}
		}

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x001D87DC File Offset: 0x001D69DC
		// (set) Token: 0x06001DDE RID: 7646 RVA: 0x001D8890 File Offset: 0x001D6A90
		public bool TrkPerTalkgroupTGSecondaryFailsoft_A19989_UIValue
		{
			get
			{
				short num = (short)2102198272;
				short num2 = num;
				num = (short)1232027367;
				short num3 = num;
				num = (short)35602151;
				switch (num3 == num)
				{
				}
				num = (short)108593153;
				if (num != 0)
				{
				}
				num = (short)1882652672;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSecondaryFailsoft_A19989.Value;
			}
			set
			{
				short num = (short)1046872064;
				short num2 = num;
				num = (short)2065737117;
				short num3 = num;
				num = (short)294888861;
				switch (num3 == num)
				{
				}
				num = (short)224526337;
				if (num != 0)
				{
				}
				num = (short)1902116864;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGSecondaryFailsoft_A19989.Value = value;
			}
		}

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x06001DDF RID: 7647 RVA: 0x001D8948 File Offset: 0x001D6B48
		// (set) Token: 0x06001DE0 RID: 7648 RVA: 0x001D89F8 File Offset: 0x001D6BF8
		public bool TrkPerTalkgroupTGSecondaryFailsoft_A19989_Applicable
		{
			get
			{
				short num = (short)1436549120;
				short num2 = num;
				num = (short)1807876097;
				if (num != 0)
				{
				}
				num = (short)962894689;
				short num3 = num;
				num = (short)5938017;
				switch (num3 == num)
				{
				}
				num = (short)1886257152;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSecondaryFailsoft_A19989.Applicable;
			}
			set
			{
				short num = (short)683933696;
				short num2 = num;
				num = (short)729630872;
				short num3 = num;
				num = (short)442124440;
				switch (num3 == num)
				{
				}
				num = (short)2041053184;
				if (num != 0)
				{
				}
				num = (short)374865921;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGSecondaryFailsoft_A19989.Applicable = value;
			}
		}

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x001D8AB0 File Offset: 0x001D6CB0
		// (set) Token: 0x06001DE2 RID: 7650 RVA: 0x001D8B64 File Offset: 0x001D6D64
		public bool TrkPerTalkgroupTGSecondaryFailsoft_A19989_Valid
		{
			get
			{
				short num = (short)1091108864;
				short num2 = num;
				num = (short)754766149;
				short num3 = num;
				num = (short)335073605;
				switch (num3 == num)
				{
				}
				num = (short)305397760;
				if (num != 0)
				{
				}
				num = (short)727318529;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSecondaryFailsoft_A19989.Valid;
			}
			set
			{
				short num = (short)797638656;
				short num2 = num;
				num = (short)500393596;
				short num3 = num;
				num = (short)235890300;
				switch (num3 == num)
				{
				}
				num = (short)1196949505;
				if (num != 0)
				{
				}
				num = (short)1466630144;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGSecondaryFailsoft_A19989.Valid = value;
			}
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x06001DE3 RID: 7651 RVA: 0x001D8C1C File Offset: 0x001D6E1C
		// (set) Token: 0x06001DE4 RID: 7652 RVA: 0x001D8CD0 File Offset: 0x001D6ED0
		public bool TrkPerTalkgroupTGSecondaryFailsoft_A19989_Visible
		{
			get
			{
				short num = (short)978583552;
				short num2 = num;
				num = (short)443347716;
				short num3 = num;
				num = (short)1073279748;
				switch (num3 == num)
				{
				}
				num = (short)403505153;
				if (num != 0)
				{
				}
				num = (short)255000576;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSecondaryFailsoft_A19989.Visible;
			}
			set
			{
				short num = (short)452591616;
				short num2 = num;
				num = (short)941162497;
				if (num != 0)
				{
				}
				num = (short)676694974;
				short num3 = num;
				num = (short)884706238;
				switch (num3 == num)
				{
				}
				num = (short)2051211264;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGSecondaryFailsoft_A19989.Visible = value;
			}
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x06001DE5 RID: 7653 RVA: 0x001D8D84 File Offset: 0x001D6F84
		// (set) Token: 0x06001DE6 RID: 7654 RVA: 0x001D8E3C File Offset: 0x001D703C
		public bool TrkPerTalkgroupTGSecondaryFailsoft_A19989_Editable
		{
			get
			{
				short num = (short)1901395968;
				short num2 = num;
				num = (short)2027177489;
				short num3 = num;
				num = (short)400639505;
				switch (num3 == num)
				{
				}
				num = (short)1875836929;
				if (num != 0)
				{
				}
				num = (short)1707933696;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSecondaryFailsoft_A19989.Editable;
			}
			set
			{
				short num = (short)2137128960;
				short num2 = num;
				num = (short)2072755498;
				short num3 = num;
				num = (short)1985264938;
				switch (num3 == num)
				{
				}
				num = (short)1610350593;
				if (num != 0)
				{
				}
				num = (short)113901568;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGSecondaryFailsoft_A19989.Editable = value;
			}
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x001D8EF0 File Offset: 0x001D70F0
		internal string TrkPerTalkgroupTGSecondaryFailsoft_A19989_UILabel
		{
			get
			{
				short num = (short)1377435648;
				short num2 = num;
				num = (short)2092547537;
				short num3 = num;
				num = (short)468893137;
				switch (num3 == num)
				{
				}
				num = (short)572588032;
				if (num != 0)
				{
				}
				num = (short)1305149441;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSecondaryFailsoft_A19989.UIName;
			}
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x001D8FA8 File Offset: 0x001D71A8
		// (set) Token: 0x06001DE9 RID: 7657 RVA: 0x001D905C File Offset: 0x001D725C
		internal bool TrkPerTalkgroupTGSecondaryFailsoft_A19989_HiddenStatic
		{
			get
			{
				short num = (short)777912320;
				short num2 = num;
				num = (short)300570985;
				short num3 = num;
				num = (short)236804457;
				switch (num3 == num)
				{
				}
				num = (short)1628372992;
				if (num != 0)
				{
				}
				num = (short)1154940929;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSecondaryFailsoft_A19989.HiddenStatic;
			}
			set
			{
				short num = (short)1276510208;
				short num2 = num;
				num = (short)753736192;
				short num3 = num;
				num = (short)2091325952;
				switch (num3 == num)
				{
				}
				num = (short)885981185;
				if (num != 0)
				{
				}
				num = (short)521273344;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGSecondaryFailsoft_A19989.HiddenStatic = value;
			}
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x06001DEA RID: 7658 RVA: 0x001D9114 File Offset: 0x001D7314
		// (set) Token: 0x06001DEB RID: 7659 RVA: 0x001D91C8 File Offset: 0x001D73C8
		internal bool TrkPerTalkgroupTGSecondaryFailsoft_A19989_HiddenDynamic
		{
			get
			{
				short num = (short)231997440;
				short num2 = num;
				num = (short)680375743;
				short num3 = num;
				num = (short)1397732799;
				switch (num3 == num)
				{
				}
				num = (short)473366528;
				if (num != 0)
				{
				}
				num = (short)92930049;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSecondaryFailsoft_A19989.HiddenDynamic;
			}
			set
			{
				short num = (short)152174592;
				short num2 = num;
				num = (short)1485192087;
				short num3 = num;
				num = (short)237255575;
				switch (num3 == num)
				{
				}
				num = (short)1941110785;
				if (num != 0)
				{
				}
				num = (short)997588992;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupTGSecondaryFailsoft_A19989.HiddenDynamic = value;
			}
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06001DEC RID: 7660 RVA: 0x001D927C File Offset: 0x001D747C
		public bool TrkPerTalkgroupTGSecondaryFailsoft_A19989_HasDiffs
		{
			get
			{
				short num = (short)1743388672;
				short num2 = num;
				num = (short)372155537;
				short num3 = num;
				num = (short)2138612881;
				switch (num3 == num)
				{
				}
				num = (short)313393152;
				if (num != 0)
				{
				}
				num = (short)1086062593;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupTGSecondaryFailsoft_A19989._HasDiffs;
			}
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x06001DED RID: 7661 RVA: 0x001D9330 File Offset: 0x001D7530
		// (set) Token: 0x06001DEE RID: 7662 RVA: 0x001D93EC File Offset: 0x001D75EC
		public string TrkSysGeneralKeyofTrunkingTalkgroup_A20742Value
		{
			get
			{
				short num = (short)1311244288;
				short num2 = num;
				num = (short)1026922376;
				short num3 = num;
				num = (short)1725470600;
				switch (num3 == num)
				{
				}
				num = (short)2106327041;
				if (num != 0)
				{
				}
				num = (short)237764608;
				if (num != 0)
				{
				}
				return this.trkSysGeneralKeyofTrunkingTalkgroup_A20742.Value;
			}
			set
			{
				short num = (short)1253048322;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_56;
					case 1:
					{
						num = (short)1310418602;
						short num3 = num;
						num = (short)563832490;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_56;
						default:
							goto IL_AC;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					if (!string.IsNullOrEmpty(value.Trim()))
					{
						num = (short)2012413952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EE;
					IL_56:
					this.trkSysGeneralKeyofTrunkingTalkgroup_A20742.Value = value;
					num = (short)1243414529;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_AC:
				num = (short)1656881152;
				if (num != 0)
				{
				}
				num = (short)1255276544;
				short num4 = num;
				IL_EE:
				num = (short)555286529;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06001DEF RID: 7663 RVA: 0x001D9510 File Offset: 0x001D7710
		// (set) Token: 0x06001DF0 RID: 7664 RVA: 0x001D95C4 File Offset: 0x001D77C4
		public string TrkSysGeneralKeyofTrunkingTalkgroup_A20742_UIValue
		{
			get
			{
				short num = (short)887357440;
				short num2 = num;
				num = (short)449192778;
				short num3 = num;
				num = (short)1160586058;
				switch (num3 == num)
				{
				}
				num = (short)1626472449;
				if (num != 0)
				{
				}
				num = (short)1759313920;
				if (num != 0)
				{
				}
				return this.trkSysGeneralKeyofTrunkingTalkgroup_A20742.Value;
			}
			set
			{
				short num = (short)945422336;
				short num2 = num;
				num = (short)1346930325;
				short num3 = num;
				num = (short)1951368853;
				switch (num3 == num)
				{
				}
				num = (short)112721921;
				if (num != 0)
				{
				}
				num = (short)1260716032;
				if (num != 0)
				{
				}
				this.trkSysGeneralKeyofTrunkingTalkgroup_A20742.Value = value;
			}
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x001D967C File Offset: 0x001D787C
		public global::AcpBusinessLayer.AcpKeyField TrkSysGeneralKeyofTrunkingTalkgroup_A20742
		{
			get
			{
				short num = (short)779616256;
				short num2 = num;
				num = (short)24411994;
				short num3 = num;
				num = (short)1605140314;
				switch (num3 == num)
				{
				}
				num = (short)1368850432;
				if (num != 0)
				{
				}
				num = (short)235601921;
				if (num != 0)
				{
				}
				return this.trkSysGeneralKeyofTrunkingTalkgroup_A20742;
			}
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x001D972C File Offset: 0x001D792C
		// (set) Token: 0x06001DF3 RID: 7667 RVA: 0x001D97E0 File Offset: 0x001D79E0
		public bool TrkSysGeneralKeyofTrunkingTalkgroup_A20742_Applicable
		{
			get
			{
				short num = (short)177405952;
				short num2 = num;
				num = (short)1466408262;
				short num3 = num;
				num = (short)1508351302;
				switch (num3 == num)
				{
				}
				num = (short)1391788032;
				if (num != 0)
				{
				}
				num = (short)997785601;
				if (num != 0)
				{
				}
				return this.trkSysGeneralKeyofTrunkingTalkgroup_A20742.Applicable;
			}
			set
			{
				short num = (short)228917248;
				short num2 = num;
				num = (short)129300189;
				short num3 = num;
				num = (short)1647376093;
				switch (num3 == num)
				{
				}
				num = (short)1638400001;
				if (num != 0)
				{
				}
				num = (short)1379926016;
				if (num != 0)
				{
				}
				this.trkSysGeneralKeyofTrunkingTalkgroup_A20742.Applicable = value;
			}
		}

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06001DF4 RID: 7668 RVA: 0x001D9894 File Offset: 0x001D7A94
		// (set) Token: 0x06001DF5 RID: 7669 RVA: 0x001D9948 File Offset: 0x001D7B48
		public bool TrkSysGeneralKeyofTrunkingTalkgroup_A20742_Valid
		{
			get
			{
				short num = (short)183042048;
				short num2 = num;
				num = (short)1205767361;
				short num3 = num;
				num = (short)1183878337;
				switch (num3 == num)
				{
				}
				num = (short)1420361729;
				if (num != 0)
				{
				}
				num = (short)1328545792;
				if (num != 0)
				{
				}
				return this.trkSysGeneralKeyofTrunkingTalkgroup_A20742.Valid;
			}
			set
			{
				short num = (short)726335488;
				short num2 = num;
				num = (short)1975675049;
				short num3 = num;
				num = (short)1403021481;
				switch (num3 == num)
				{
				}
				num = (short)189923328;
				if (num != 0)
				{
				}
				num = (short)1051394049;
				if (num != 0)
				{
				}
				this.trkSysGeneralKeyofTrunkingTalkgroup_A20742.Valid = value;
			}
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x001D99FC File Offset: 0x001D7BFC
		// (set) Token: 0x06001DF7 RID: 7671 RVA: 0x001D9AAC File Offset: 0x001D7CAC
		public bool TrkSysGeneralKeyofTrunkingTalkgroup_A20742_Visible
		{
			get
			{
				short num = (short)1090912256;
				short num2 = num;
				num = (short)2066393110;
				short num3 = num;
				num = (short)2119870486;
				switch (num3 == num)
				{
				}
				num = (short)799277056;
				if (num != 0)
				{
				}
				num = (short)513474561;
				if (num != 0)
				{
				}
				return this.trkSysGeneralKeyofTrunkingTalkgroup_A20742.Visible;
			}
			set
			{
				short num = (short)685965312;
				short num2 = num;
				num = (short)529334273;
				if (num != 0)
				{
				}
				num = (short)310054631;
				short num3 = num;
				num = (short)394530535;
				switch (num3 == num)
				{
				}
				num = (short)1403453440;
				if (num != 0)
				{
				}
				this.trkSysGeneralKeyofTrunkingTalkgroup_A20742.Visible = value;
			}
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x06001DF8 RID: 7672 RVA: 0x001D9B60 File Offset: 0x001D7D60
		// (set) Token: 0x06001DF9 RID: 7673 RVA: 0x001D9C14 File Offset: 0x001D7E14
		public bool TrkSysGeneralKeyofTrunkingTalkgroup_A20742_Editable
		{
			get
			{
				short num = (short)281149440;
				short num2 = num;
				num = (short)1555396044;
				short num3 = num;
				num = (short)1727296972;
				switch (num3 == num)
				{
				}
				num = (short)1927086080;
				if (num != 0)
				{
				}
				num = (short)2081816577;
				if (num != 0)
				{
				}
				return this.trkSysGeneralKeyofTrunkingTalkgroup_A20742.Editable;
			}
			set
			{
				short num = (short)1648295936;
				short num2 = num;
				num = (short)281857406;
				short num3 = num;
				num = (short)523029886;
				switch (num3 == num)
				{
				}
				num = (short)248053761;
				if (num != 0)
				{
				}
				num = (short)556007424;
				if (num != 0)
				{
				}
				this.trkSysGeneralKeyofTrunkingTalkgroup_A20742.Editable = value;
			}
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06001DFA RID: 7674 RVA: 0x001D9CC8 File Offset: 0x001D7EC8
		internal string TrkSysGeneralKeyofTrunkingTalkgroup_A20742_UILabel
		{
			get
			{
				short num = (short)1793589248;
				short num2 = num;
				num = (short)1266103871;
				short num3 = num;
				num = (short)1382430271;
				switch (num3 == num)
				{
				}
				num = (short)95617025;
				if (num != 0)
				{
				}
				num = (short)1179648;
				if (num != 0)
				{
				}
				return this.trkSysGeneralKeyofTrunkingTalkgroup_A20742.UIName;
			}
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06001DFB RID: 7675 RVA: 0x001D9D7C File Offset: 0x001D7F7C
		// (set) Token: 0x06001DFC RID: 7676 RVA: 0x001D9E30 File Offset: 0x001D8030
		internal bool TrkSysGeneralKeyofTrunkingTalkgroup_A20742_HiddenStatic
		{
			get
			{
				short num = (short)1516634112;
				short num2 = num;
				num = (short)572163243;
				short num3 = num;
				num = (short)1597998251;
				switch (num3 == num)
				{
				}
				num = (short)1797259264;
				if (num != 0)
				{
				}
				num = (short)1496907777;
				if (num != 0)
				{
				}
				return this.trkSysGeneralKeyofTrunkingTalkgroup_A20742.HiddenStatic;
			}
			set
			{
				short num = (short)1624440832;
				short num2 = num;
				num = (short)1514591086;
				short num3 = num;
				num = (short)1122685806;
				switch (num3 == num)
				{
				}
				num = (short)7471105;
				if (num != 0)
				{
				}
				num = (short)462028800;
				if (num != 0)
				{
				}
				this.trkSysGeneralKeyofTrunkingTalkgroup_A20742.HiddenStatic = value;
			}
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06001DFD RID: 7677 RVA: 0x001D9EE4 File Offset: 0x001D80E4
		// (set) Token: 0x06001DFE RID: 7678 RVA: 0x001D9F9C File Offset: 0x001D819C
		internal bool TrkSysGeneralKeyofTrunkingTalkgroup_A20742_HiddenDynamic
		{
			get
			{
				short num = (short)1244135424;
				short num2 = num;
				num = (short)824792006;
				short num3 = num;
				num = (short)1543984070;
				switch (num3 == num)
				{
				}
				num = (short)1031143425;
				if (num != 0)
				{
				}
				num = (short)2089943040;
				if (num != 0)
				{
				}
				return this.trkSysGeneralKeyofTrunkingTalkgroup_A20742.HiddenDynamic;
			}
			set
			{
				short num = (short)625016832;
				short num2 = num;
				num = (short)1870004225;
				if (num != 0)
				{
				}
				num = (short)1521810846;
				short num3 = num;
				num = (short)804453790;
				switch (num3 == num)
				{
				}
				num = (short)1206452224;
				if (num != 0)
				{
				}
				this.trkSysGeneralKeyofTrunkingTalkgroup_A20742.HiddenDynamic = value;
			}
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06001DFF RID: 7679 RVA: 0x001DA050 File Offset: 0x001D8250
		public bool TrkSysGeneralKeyofTrunkingTalkgroup_A20742_HasDiffs
		{
			get
			{
				short num = (short)1219231744;
				short num2 = num;
				num = (short)113019773;
				short num3 = num;
				num = (short)648842109;
				switch (num3 == num)
				{
				}
				num = (short)300154880;
				if (num != 0)
				{
				}
				num = (short)644677633;
				if (num != 0)
				{
				}
				return this.trkSysGeneralKeyofTrunkingTalkgroup_A20742._HasDiffs;
			}
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06001E00 RID: 7680 RVA: 0x001DA104 File Offset: 0x001D8304
		// (set) Token: 0x06001E01 RID: 7681 RVA: 0x001DA1B8 File Offset: 0x001D83B8
		public int TrkPerTalkgroupPriorityDispatch_43599Value
		{
			get
			{
				short num = (short)1276903424;
				short num2 = num;
				num = (short)526057473;
				if (num != 0)
				{
				}
				num = (short)1541905358;
				short num3 = num;
				num = (short)855808974;
				switch (num3 == num)
				{
				}
				num = (short)975896576;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupPriorityDispatch_43599.Value;
			}
			set
			{
				short num = (short)1697906688;
				short num2 = num;
				num = (short)1370030081;
				if (num != 0)
				{
				}
				num = (short)855328064;
				short num3 = num;
				num = (short)182535488;
				switch (num3 == num)
				{
				}
				num = (short)1294532608;
				if (num != 0)
				{
				}
				this.trkPerTalkgroupPriorityDispatch_43599.Value = value;
			}
		}

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x06001E02 RID: 7682 RVA: 0x001DA270 File Offset: 0x001D8470
		// (set) Token: 0x06001E03 RID: 7683 RVA: 0x001DA324 File Offset: 0x001D8524
		public string TrkPerTalkgroupPriorityDispatch_43599_UIValue
		{
			get
			{
				short num = (short)514654208;
				short num2 = num;
				num = (short)966656001;
				if (num != 0)
				{
				}
				num = (short)1626626497;
				short num3 = num;
				num = (short)215767489;
				switch (num3 == num)
				{
				}
				num = (short)1769209856;
				if (num != 0)
				{
				}
				return this.trkPerTalkgroupPriorityDispatch_43599.UIValue;
			}
			set
			{
				short num = (short)1095407322;
				short num2 = num;
				num = (short)1248827098;
				switch (num2 == num)
				{
				}
				num = (short)1164574721;
				if (num != 0)
				{
				}
				num = (short)1110245376;
				if (num != 0)
				{
				}
				num = (short)437256192;
				short num3 = num;
				this.trkPerTalkgroupPriorityDispatch_43599.UIValue = value;
			}
		}

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x06001E04 RID: 7684 RVA: 0x001DA3E0 File Offset: 0x001D85E0
		public global::AcpBusinessLayer.AcpRecRefField TrkPerTalkgroupPriorityDispatch_43599
		{
			get
			{
				short num = (short)783607457;
				short num2 = num;
				num = (short)245032609;
				switch (num2 == num)
				{
				}
				num = (short)162922496;
				if (num != 0)
				{
				}
				num = (short)682885121;
				if (num != 0)
				{
				}
				num = (short)745799680;
				short num3 = num;
				return this.trkPerTalkgroupPriorityDispatch_43599;
			}
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x06001E05 RID: 7685 RVA: 0x001DA494 File Offset: 0x001D8694
		// (set) Token: 0x06001E06 RID: 7686 RVA: 0x001DA54C File Offset: 0x001D874C
		public bool TrkPerTalkgroupPriorityDispatch_43599_Applicable
		{
			get
			{
				short num = (short)1767418359;
				short num2 = num;
				num = (short)2105453047;
				switch (num2 == num)
				{
				}
				num = (short)1015283713;
				if (num != 0)
				{
				}
				num = (short)258277376;
				if (num != 0)
				{
				}
				num = (short)241696768;
				short num3 = num;
				return this.trkPerTalkgroupPriorityDispatch_43599.Applicable;
			}
			set
			{
				short num = (short)447574237;
				short num2 = num;
				num = (short)1281650909;
				switch (num2 == num)
				{
				}
				num = (short)1965948929;
				if (num != 0)
				{
				}
				num = (short)644284416;
				if (num != 0)
				{
				}
				num = (short)928579584;
				short num3 = num;
				this.trkPerTalkgroupPriorityDispatch_43599.Applicable = value;
			}
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06001E07 RID: 7687 RVA: 0x001DA600 File Offset: 0x001D8800
		// (set) Token: 0x06001E08 RID: 7688 RVA: 0x001DA6B8 File Offset: 0x001D88B8
		public bool TrkPerTalkgroupPriorityDispatch_43599_Valid
		{
			get
			{
				short num = (short)938887099;
				short num2 = num;
				num = (short)1126123451;
				switch (num2 == num)
				{
				}
				num = (short)843776001;
				if (num != 0)
				{
				}
				num = (short)306511872;
				if (num != 0)
				{
				}
				num = (short)1042808832;
				short num3 = num;
				return this.trkPerTalkgroupPriorityDispatch_43599.Valid;
			}
			set
			{
				short num = (short)1047034171;
				short num2 = num;
				num = (short)218790203;
				switch (num2 == num)
				{
				}
				num = (short)1995177985;
				if (num != 0)
				{
				}
				num = (short)1291452416;
				if (num != 0)
				{
				}
				num = (short)863895552;
				short num3 = num;
				this.trkPerTalkgroupPriorityDispatch_43599.Valid = value;
			}
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x06001E09 RID: 7689 RVA: 0x001DA76C File Offset: 0x001D896C
		// (set) Token: 0x06001E0A RID: 7690 RVA: 0x001DA820 File Offset: 0x001D8A20
		public bool TrkPerTalkgroupPriorityDispatch_43599_Visible
		{
			get
			{
				short num = (short)261674027;
				short num2 = num;
				num = (short)294704171;
				switch (num2 == num)
				{
				}
				num = (short)55836673;
				if (num != 0)
				{
				}
				num = (short)1564147712;
				if (num != 0)
				{
				}
				num = (short)522387456;
				short num3 = num;
				return this.trkPerTalkgroupPriorityDispatch_43599.Visible;
			}
			set
			{
				short num = (short)701817928;
				short num2 = num;
				num = (short)973726792;
				switch (num2 == num)
				{
				}
				num = (short)142409729;
				if (num != 0)
				{
				}
				num = (short)57147392;
				if (num != 0)
				{
				}
				num = (short)1610285056;
				short num3 = num;
				this.trkPerTalkgroupPriorityDispatch_43599.Visible = value;
			}
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x06001E0B RID: 7691 RVA: 0x001DA8D8 File Offset: 0x001D8AD8
		// (set) Token: 0x06001E0C RID: 7692 RVA: 0x001DA98C File Offset: 0x001D8B8C
		public bool TrkPerTalkgroupPriorityDispatch_43599_Editable
		{
			get
			{
				short num = (short)1059398442;
				short num2 = num;
				num = (short)377692970;
				switch (num2 == num)
				{
				}
				num = (short)1523646465;
				if (num != 0)
				{
				}
				num = (short)94765056;
				if (num != 0)
				{
				}
				num = (short)1803288576;
				short num3 = num;
				return this.trkPerTalkgroupPriorityDispatch_43599.Editable;
			}
			set
			{
				short num = (short)911315502;
				short num2 = num;
				num = (short)105222702;
				switch (num2 == num)
				{
				}
				num = (short)1038811137;
				if (num != 0)
				{
				}
				num = (short)674168832;
				if (num != 0)
				{
				}
				num = (short)824246272;
				short num3 = num;
				this.trkPerTalkgroupPriorityDispatch_43599.Editable = value;
			}
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x06001E0D RID: 7693 RVA: 0x001DAA48 File Offset: 0x001D8C48
		internal string TrkPerTalkgroupPriorityDispatch_43599_UILabel
		{
			get
			{
				short num = (short)1481738549;
				short num2 = num;
				num = (short)1527417141;
				switch (num2 == num)
				{
				}
				num = (short)893911041;
				if (num != 0)
				{
				}
				num = (short)1365639168;
				if (num != 0)
				{
				}
				num = (short)1976369152;
				short num3 = num;
				return this.trkPerTalkgroupPriorityDispatch_43599.UIName;
			}
		}

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x06001E0E RID: 7694 RVA: 0x001DAAFC File Offset: 0x001D8CFC
		// (set) Token: 0x06001E0F RID: 7695 RVA: 0x001DABB0 File Offset: 0x001D8DB0
		internal bool TrkPerTalkgroupPriorityDispatch_43599_HiddenStatic
		{
			get
			{
				short num = (short)507626741;
				short num2 = num;
				num = (short)1455473909;
				switch (num2 == num)
				{
				}
				num = (short)42991616;
				if (num != 0)
				{
				}
				num = (short)291569665;
				if (num != 0)
				{
				}
				num = (short)748224512;
				short num3 = num;
				return this.trkPerTalkgroupPriorityDispatch_43599.HiddenStatic;
			}
			set
			{
				short num = (short)2071323992;
				short num2 = num;
				num = (short)545973592;
				switch (num2 == num)
				{
				}
				num = (short)602341376;
				if (num != 0)
				{
				}
				num = (short)1491664897;
				if (num != 0)
				{
				}
				num = (short)1162215424;
				short num3 = num;
				this.trkPerTalkgroupPriorityDispatch_43599.HiddenStatic = value;
			}
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x06001E10 RID: 7696 RVA: 0x001DAC68 File Offset: 0x001D8E68
		// (set) Token: 0x06001E11 RID: 7697 RVA: 0x001DAD20 File Offset: 0x001D8F20
		internal bool TrkPerTalkgroupPriorityDispatch_43599_HiddenDynamic
		{
			get
			{
				short num = (short)1308824218;
				short num2 = num;
				num = (short)742068890;
				switch (num2 == num)
				{
				}
				num = (short)177340417;
				if (num != 0)
				{
				}
				num = (short)765853696;
				if (num != 0)
				{
				}
				num = (short)1678442496;
				short num3 = num;
				return this.trkPerTalkgroupPriorityDispatch_43599.HiddenDynamic;
			}
			set
			{
				short num = (short)1980821275;
				short num2 = num;
				num = (short)199683867;
				switch (num2 == num)
				{
				}
				num = (short)47841281;
				if (num != 0)
				{
				}
				num = (short)92209152;
				if (num != 0)
				{
				}
				num = (short)289931264;
				short num3 = num;
				this.trkPerTalkgroupPriorityDispatch_43599.HiddenDynamic = value;
			}
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x06001E12 RID: 7698 RVA: 0x001DADD4 File Offset: 0x001D8FD4
		public bool TrkPerTalkgroupPriorityDispatch_43599_HasDiffs
		{
			get
			{
				short num = (short)1525809153;
				if (num != 0)
				{
				}
				num = (short)903459117;
				short num2 = num;
				num = (short)1353363757;
				switch (num2 == num)
				{
				}
				num = (short)1905328128;
				if (num != 0)
				{
				}
				num = (short)1929641984;
				short num3 = num;
				return this.trkPerTalkgroupPriorityDispatch_43599._HasDiffs;
			}
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06001E13 RID: 7699 RVA: 0x001DAE88 File Offset: 0x001D9088
		// (set) Token: 0x06001E14 RID: 7700 RVA: 0x001DAF38 File Offset: 0x001D9138
		public int TrkPerTalkgroupAstroOTARProfileIndex_43687Value
		{
			get
			{
				short num = (short)108259153;
				short num2 = num;
				num = (short)1587865425;
				switch (num2 == num)
				{
				}
				num = (short)1849032705;
				if (num != 0)
				{
				}
				num = (short)914161664;
				if (num != 0)
				{
				}
				num = (short)1614741504;
				short num3 = num;
				return this.trkPerTalkgroupAstroOTARProfileIndex_43687.Value;
			}
			set
			{
				short num = (short)2076549536;
				short num2 = num;
				num = (short)1178837408;
				switch (num2 == num)
				{
				}
				num = (short)98369537;
				if (num != 0)
				{
				}
				num = (short)90439680;
				if (num != 0)
				{
				}
				num = (short)1078263808;
				short num3 = num;
				this.trkPerTalkgroupAstroOTARProfileIndex_43687.Value = value;
			}
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x06001E15 RID: 7701 RVA: 0x001DAFEC File Offset: 0x001D91EC
		// (set) Token: 0x06001E16 RID: 7702 RVA: 0x001DB0A0 File Offset: 0x001D92A0
		public string TrkPerTalkgroupAstroOTARProfileIndex_43687_UIValue
		{
			get
			{
				short num = (short)1361161919;
				short num2 = num;
				num = (short)418361023;
				switch (num2 == num)
				{
				}
				num = (short)856489985;
				if (num != 0)
				{
				}
				num = (short)1607532544;
				if (num != 0)
				{
				}
				num = (short)1533607936;
				short num3 = num;
				return this.trkPerTalkgroupAstroOTARProfileIndex_43687.UIValue;
			}
			set
			{
				short num = (short)2064780959;
				short num2 = num;
				num = (short)1435569823;
				switch (num2 == num)
				{
				}
				num = (short)162922497;
				if (num != 0)
				{
				}
				num = (short)526974976;
				if (num != 0)
				{
				}
				num = (short)1906245632;
				short num3 = num;
				this.trkPerTalkgroupAstroOTARProfileIndex_43687.UIValue = value;
			}
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x06001E17 RID: 7703 RVA: 0x001DB154 File Offset: 0x001D9354
		public global::AcpBusinessLayer.AcpRecRefField TrkPerTalkgroupAstroOTARProfileIndex_43687
		{
			get
			{
				short num = (short)1059512302;
				short num2 = num;
				num = (short)190046190;
				switch (num2 == num)
				{
				}
				num = (short)1003487232;
				if (num != 0)
				{
				}
				num = (short)1308033025;
				if (num != 0)
				{
				}
				num = (short)1395261440;
				short num3 = num;
				return this.trkPerTalkgroupAstroOTARProfileIndex_43687;
			}
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x06001E18 RID: 7704 RVA: 0x001DB204 File Offset: 0x001D9404
		// (set) Token: 0x06001E19 RID: 7705 RVA: 0x001DB2B8 File Offset: 0x001D94B8
		public bool TrkPerTalkgroupAstroOTARProfileIndex_43687_Applicable
		{
			get
			{
				short num = (short)1257242625;
				if (num != 0)
				{
				}
				num = (short)879503662;
				short num2 = num;
				num = (short)1663052078;
				switch (num2 == num)
				{
				}
				num = (short)1486028800;
				if (num != 0)
				{
				}
				num = (short)740425728;
				short num3 = num;
				return this.trkPerTalkgroupAstroOTARProfileIndex_43687.Applicable;
			}
			set
			{
				short num = (short)1194284949;
				short num2 = num;
				num = (short)996104085;
				switch (num2 == num)
				{
				}
				num = (short)1925316609;
				if (num != 0)
				{
				}
				num = (short)1193803776;
				if (num != 0)
				{
				}
				num = (short)533659648;
				short num3 = num;
				this.trkPerTalkgroupAstroOTARProfileIndex_43687.Applicable = value;
			}
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x06001E1A RID: 7706 RVA: 0x001DB36C File Offset: 0x001D956C
		// (set) Token: 0x06001E1B RID: 7707 RVA: 0x001DB424 File Offset: 0x001D9624
		public bool TrkPerTalkgroupAstroOTARProfileIndex_43687_Valid
		{
			get
			{
				short num = (short)361069879;
				short num2 = num;
				num = (short)323058999;
				switch (num2 == num)
				{
				}
				num = (short)1786249216;
				if (num != 0)
				{
				}
				num = (short)1808793601;
				if (num != 0)
				{
				}
				num = (short)363659264;
				short num3 = num;
				return this.trkPerTalkgroupAstroOTARProfileIndex_43687.Valid;
			}
			set
			{
				short num = (short)600161855;
				short num2 = num;
				num = (short)778354239;
				switch (num2 == num)
				{
				}
				num = (short)1719533568;
				if (num != 0)
				{
				}
				num = (short)799145985;
				if (num != 0)
				{
				}
				num = (short)1298071552;
				short num3 = num;
				this.trkPerTalkgroupAstroOTARProfileIndex_43687.Valid = value;
			}
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x06001E1C RID: 7708 RVA: 0x001DB4D8 File Offset: 0x001D96D8
		// (set) Token: 0x06001E1D RID: 7709 RVA: 0x001DB58C File Offset: 0x001D978C
		public bool TrkPerTalkgroupAstroOTARProfileIndex_43687_Visible
		{
			get
			{
				short num = (short)1916866513;
				short num2 = num;
				num = (short)210505681;
				switch (num2 == num)
				{
				}
				num = (short)646840321;
				if (num != 0)
				{
				}
				num = (short)1244790784;
				if (num != 0)
				{
				}
				num = (short)1748500480;
				short num3 = num;
				return this.trkPerTalkgroupAstroOTARProfileIndex_43687.Visible;
			}
			set
			{
				short num = (short)78723198;
				short num2 = num;
				num = (short)2069248126;
				switch (num2 == num)
				{
				}
				num = (short)116654080;
				if (num != 0)
				{
				}
				num = (short)981729281;
				if (num != 0)
				{
				}
				num = (short)199884800;
				short num3 = num;
				this.trkPerTalkgroupAstroOTARProfileIndex_43687.Visible = value;
			}
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x06001E1E RID: 7710 RVA: 0x001DB644 File Offset: 0x001D9844
		// (set) Token: 0x06001E1F RID: 7711 RVA: 0x001DB6F8 File Offset: 0x001D98F8
		public bool TrkPerTalkgroupAstroOTARProfileIndex_43687_Editable
		{
			get
			{
				short num = (short)265742946;
				short num2 = num;
				num = (short)724167266;
				switch (num2 == num)
				{
				}
				num = (short)171835393;
				if (num != 0)
				{
				}
				num = (short)1144193024;
				if (num != 0)
				{
				}
				num = (short)2005729280;
				short num3 = num;
				return this.trkPerTalkgroupAstroOTARProfileIndex_43687.Editable;
			}
			set
			{
				short num = (short)1081476515;
				short num2 = num;
				num = (short)64882083;
				switch (num2 == num)
				{
				}
				num = (short)19136513;
				if (num != 0)
				{
				}
				num = (short)1703936000;
				if (num != 0)
				{
				}
				num = (short)2047934464;
				short num3 = num;
				this.trkPerTalkgroupAstroOTARProfileIndex_43687.Editable = value;
			}
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x06001E20 RID: 7712 RVA: 0x001DB7B0 File Offset: 0x001D99B0
		internal string TrkPerTalkgroupAstroOTARProfileIndex_43687_UILabel
		{
			get
			{
				short num = (short)1111497826;
				short num2 = num;
				num = (short)975117410;
				switch (num2 == num)
				{
				}
				num = (short)1992687617;
				if (num != 0)
				{
				}
				num = (short)2039087104;
				if (num != 0)
				{
				}
				num = (short)169410560;
				short num3 = num;
				return this.trkPerTalkgroupAstroOTARProfileIndex_43687.UIName;
			}
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x06001E21 RID: 7713 RVA: 0x001DB864 File Offset: 0x001D9A64
		// (set) Token: 0x06001E22 RID: 7714 RVA: 0x001DB918 File Offset: 0x001D9B18
		internal bool TrkPerTalkgroupAstroOTARProfileIndex_43687_HiddenStatic
		{
			get
			{
				short num = (short)859439105;
				if (num != 0)
				{
				}
				num = (short)3353154;
				short num2 = num;
				num = (short)151136834;
				switch (num2 == num)
				{
				}
				num = (short)153026560;
				if (num != 0)
				{
				}
				num = (short)31522816;
				short num3 = num;
				return this.trkPerTalkgroupAstroOTARProfileIndex_43687.HiddenStatic;
			}
			set
			{
				short num = (short)102473673;
				short num2 = num;
				num = (short)2035851209;
				switch (num2 == num)
				{
				}
				num = (short)72876033;
				if (num != 0)
				{
				}
				num = (short)940703744;
				if (num != 0)
				{
				}
				num = (short)1396047872;
				short num3 = num;
				this.trkPerTalkgroupAstroOTARProfileIndex_43687.HiddenStatic = value;
			}
		}

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x06001E23 RID: 7715 RVA: 0x001DB9CC File Offset: 0x001D9BCC
		// (set) Token: 0x06001E24 RID: 7716 RVA: 0x001DBA80 File Offset: 0x001D9C80
		internal bool TrkPerTalkgroupAstroOTARProfileIndex_43687_HiddenDynamic
		{
			get
			{
				short num = (short)387866448;
				short num2 = num;
				num = (short)410738512;
				switch (num2 == num)
				{
				}
				num = (short)216662016;
				if (num != 0)
				{
				}
				num = (short)1061027841;
				if (num != 0)
				{
				}
				num = (short)1846607872;
				short num3 = num;
				return this.trkPerTalkgroupAstroOTARProfileIndex_43687.HiddenDynamic;
			}
			set
			{
				short num = (short)1013923270;
				short num2 = num;
				num = (short)1235500486;
				switch (num2 == num)
				{
				}
				num = (short)1379598337;
				if (num != 0)
				{
				}
				num = (short)431095808;
				if (num != 0)
				{
				}
				num = (short)2045509632;
				short num3 = num;
				this.trkPerTalkgroupAstroOTARProfileIndex_43687.HiddenDynamic = value;
			}
		}

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x001DBB34 File Offset: 0x001D9D34
		public bool TrkPerTalkgroupAstroOTARProfileIndex_43687_HasDiffs
		{
			get
			{
				short num = (short)1542180816;
				short num2 = num;
				num = (short)1831063504;
				switch (num2 == num)
				{
				}
				num = (short)409468929;
				if (num != 0)
				{
				}
				num = (short)28114944;
				if (num != 0)
				{
				}
				num = (short)587268096;
				short num3 = num;
				return this.trkPerTalkgroupAstroOTARProfileIndex_43687._HasDiffs;
			}
		}

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x06001E26 RID: 7718 RVA: 0x001DBBEC File Offset: 0x001D9DEC
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation RefRadioInformation
		{
			get
			{
				short num = (short)1718303912;
				short num2 = num;
				num = (short)1860648104;
				switch (num2 == num)
				{
				}
				num = (short)248840193;
				if (num != 0)
				{
				}
				num = (short)253624320;
				if (num != 0)
				{
				}
				num = (short)286392320;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			}
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x06001E27 RID: 7719 RVA: 0x001DBCA8 File Offset: 0x001D9EA8
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide RefSecureWide
		{
			get
			{
				short num = (short)1061477533;
				short num2 = num;
				num = (short)357162141;
				switch (num2 == num)
				{
				}
				num = (short)188612608;
				if (num != 0)
				{
				}
				num = (short)1570308097;
				if (num != 0)
				{
				}
				num = (short)175177728;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			}
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x001DBD68 File Offset: 0x001D9F68
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
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1626476157;
					short num3 = num2;
					num2 = (short)2016153213;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)34013184;
						if (num2 != 0)
						{
						}
						num2 = (short)132251649;
						if (num2 != 0)
						{
						}
						num2 = (short)463339522;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					num2 = (short)558628868;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return result;
				case 3:
				{
					num2 = (short)351731712;
					short num4 = num2;
					if (base.ParentRecset != null)
					{
						num2 = (short)960167937;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)571080704;
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
			num2 = (short)77594627;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400090B RID: 2315
		private global::AcpBusinessLayer.AcpFrequencyField trkPerTalkgroupFailsoftRxFrequencyMHz_A8001;

		// Token: 0x0400090C RID: 2316
		private global::AcpBusinessLayer.AcpFrequencyField trkPerTalkgroupFailsoftTxFrequencyMHz_A8003;

		// Token: 0x0400090D RID: 2317
		private global::AcpBusinessLayer.AcpField<bool> trkPerTalkgroupTalkgroupFailsoft_A8005;

		// Token: 0x0400090E RID: 2318
		private global::AcpBusinessLayer.AcpRecRefField trkPerTalkgroupKeySelect_A8365;

		// Token: 0x0400090F RID: 2319
		private global::AcpBusinessLayer.AcpFrequencyField trkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900;

		// Token: 0x04000910 RID: 2320
		private global::AcpBusinessLayer.AcpFrequencyField trkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902;

		// Token: 0x04000911 RID: 2321
		private global::AcpBusinessLayer.AcpListField trkPerTalkgroupSecureClearStrapping_A9095;

		// Token: 0x04000912 RID: 2322
		private global::AcpBusinessLayer.AcpSimpleRangeField trkPerTalkgroupTalkgroup_A9274;

		// Token: 0x04000913 RID: 2323
		private global::AcpBusinessLayer.AcpListField trkPerTalkgroupTxVoiceSignalType_A9575;

		// Token: 0x04000914 RID: 2324
		private global::AcpBusinessLayer.AcpSimpleRangeField trkPerTalkgroupTGSystemID_A19715;

		// Token: 0x04000915 RID: 2325
		private global::AcpBusinessLayer.AcpSimpleRangeField trkPerTalkgroupTGWACNID_A19716;

		// Token: 0x04000916 RID: 2326
		private global::AcpBusinessLayer.AcpField<bool> trkPerTalkgroupTGSecondaryFailsoft_A19989;

		// Token: 0x04000917 RID: 2327
		private global::AcpBusinessLayer.AcpKeyField trkSysGeneralKeyofTrunkingTalkgroup_A20742;

		// Token: 0x04000918 RID: 2328
		private global::AcpBusinessLayer.AcpRecRefField trkPerTalkgroupPriorityDispatch_43599;

		// Token: 0x04000919 RID: 2329
		private global::AcpBusinessLayer.AcpRecRefField trkPerTalkgroupAstroOTARProfileIndex_43687;
	}
}
