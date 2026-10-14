using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingWide
{
	// Token: 0x02000060 RID: 96
	[global::System.Serializable]
	public class RSSIThresholds : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06000720 RID: 1824 RVA: 0x00070C9C File Offset: 0x0006EE9C
		public RSSIThresholds(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00070CB8 File Offset: 0x0006EEB8
		protected RSSIThresholds(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00070CD0 File Offset: 0x0006EED0
		public override void Init()
		{
			int a_ = 10;
			short num = (short)642187264;
			short num2 = num;
			num = (short)275421438;
			short num3 = num;
			num = (short)217553150;
			switch (num3 == num)
			{
			}
			num = (short)847052801;
			if (num != 0)
			{
			}
			num = (short)1694892032;
			if (num != 0)
			{
			}
			this.trkWideRSSIThresholdsDesenseTimer_A7828 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎蛐뫒뇔닖诘裚軜雞뗠询韤苦髨菪苬菮闰胲뇴鋶諸黺鏼賾搀圂氄樆氈礊刌与☐⬒✔⼖", a_), global::CommonResources.AcgResources.ID_DESENSETIMERSEC, 0, 30, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 1);
			this.trkWideRSSIThresholdsDesenseTimer_A7828.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideRSSIThresholdsDesenseTimer_A7828.DataTransferOrder = 19;
			this.trkWideRSSIThresholdsDesenseTimer_A7828.ShowHexValue = false;
			this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989 = new global::AcpBusinessLayer.AcpSimpleRangeField(52, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎蛐뫒뇔닖诘裚軜雞뗠询韤苦髨菪苬菮闰胲ꟴꓶ꫸닺볼鳾戀昂甄猆栈椊愌樎䔐笒朔爖樘猚爜猞䔠簢搤ἦဨጪᐬ", a_), global::CommonResources.AcgResources.ID_SMARTZONERSSITHRESHOLDSRSSIACCEPTABLETHRESHOLD, 0, 255, null, null, 0, 1);
			this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.DataTransferOrder = 23;
			this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.ShowHexValue = true;
			this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991 = new global::AcpBusinessLayer.AcpSimpleRangeField(77, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎蛐뫒뇔닖诘裚軜雞뗠询韤苦髨菪苬菮闰胲ꟴꓶ꫸닺룼蟾戀昂椄欆氈攊礌嬎礐愒瀔搖焘琚焜笞縠戢ᴤḦဨᨪ", a_), global::CommonResources.AcgResources.ID_SMARTZONERSSITHRESHOLDSRSSIEXCELLENTTHRESHOLD, 0, 255, null, null, 0, 1);
			this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.DataTransferOrder = 24;
			this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.ShowHexValue = true;
			this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992 = new global::AcpBusinessLayer.AcpSimpleRangeField(64, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎蛐뫒뇔닖诘裚軜雞뗠询韤苦髨菪苬菮闰胲ꟴꓶ꫸닺뫼郾渀朂億漆笈渊縌朎縐缒焔䠖堘⌚␜☞ጠ", a_), global::CommonResources.AcgResources.ID_SMARTZONERSSITHRESHOLDSRSSIGOODTHRESHOLD, 0, 255, null, null, 0, 1);
			this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.DataTransferOrder = 20;
			this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.ShowHexValue = true;
			this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996 = new global::AcpBusinessLayer.AcpSimpleRangeField(70, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎蛐뫒뇔닖诘裚軜雞뗠询韤苦髨菪苬菮闰胲ꟴꓶ꫸닺꯼髾猀稂䈄栆昈漊夌朎挐瘒昔编瘘眚礜䀞怠ᬢᰤḦἨ", a_), global::CommonResources.AcgResources.ID_SMARTZONERSSITHRESHOLDSRSSIVERYGOODTHRESHOLD, 0, 255, null, null, 0, 1);
			this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.DataTransferOrder = 25;
			this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.ShowHexValue = true;
			this.trkWideRSSIThresholdsStrongSignalRoaming_A24630 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎蛐뫒뇔닖诘裚軜雞뗠询韤苦髨菪苬菮闰胲꛴菶诸铺鏼飾刀樂戄椆栈朊弌怎瀐縒簔礖縘䐚尜ⴞᔠᔢᘤᜦ", a_), global::CommonResources.AcgResources.ID_SMARTZONERSSITHRESHOLDSSTRONGSIGNALROAMING);
			this.trkWideRSSIThresholdsStrongSignalRoaming_A24630.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideRSSIThresholdsStrongSignalRoaming_A24630.DataTransferOrder = 33;
			this.trkWideRSSIThresholdsRSSIOSPCounter_A8994 = new global::AcpBusinessLayer.AcpSimpleRangeField(102, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎蛐뫒뇔닖诘裚軜雞뗠询韤苦髨菪苬菮闰胲ꟴꓶ꫸닺닼곾儀䀂樄爆月缊栌紎丐划ⴔ⸖‘⼚", a_), global::CommonResources.AcgResources.ID_RSSIOSPCOUNTER, 40, 255, null, null, 0, 1);
			this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.DataTransferOrder = 21;
			this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.ShowHexValue = false;
			this.trkWideRSSIThresholdsRSSIOSWCounter_A8995 = new global::AcpBusinessLayer.AcpSimpleRangeField(80, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎蛐뫒뇔닖诘裚軜雞뗠询韤苦髨菪苬菮闰胲ꟴꓶ꫸닺닼곾嘀䀂樄爆月缊栌紎丐划ⴔ⸖‘⸚", a_), global::CommonResources.AcgResources.ID_RSSIOSWCOUNTER, 60, 255, null, null, 0, 1);
			this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.DataTransferOrder = 22;
			this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.ShowHexValue = false;
			this.trkWideRSSIBackupPTTFallbackThreshold_A43626 = new global::AcpBusinessLayer.AcpSimpleRangeField(52, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎蛐뫒뇔닖诘裚軜雞ꏠ苢蛤賦鳨鯪뷬믮ꗰ뗲铴鯶闸駺鳼鳾樀圂洄甆氈砊攌怎紐眒䨔嘖ⴘ⠚⬜ⴞᜠ", a_), global::CommonResources.AcgResources.ID_SMARTCONNECTRSSITHRESHOLDSRSSISMARTCONNECTFALLBACKTHRESHOLD, 0, 255, null, null, 0, 1);
			this.trkWideRSSIBackupPTTFallbackThreshold_A43626.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkWideRSSIBackupPTTFallbackThreshold_A43626.DataTransferOrder = 36;
			this.trkWideRSSIBackupPTTFallbackThreshold_A43626.ShowHexValue = true;
			this.trkWideSmartConnectRSSIReturnThreshold_43723 = new global::AcpBusinessLayer.AcpSimpleRangeField(65, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎蛐뫒뇔닖諘뛚볜귞闠ꃢ諤触蟨軪軬鯮ꏰꃲ꛴뻶꯸黺觼諾猀洂億漆笈渊縌朎縐缒焔䠖ⴘ⠚⨜ⴞሠ", a_), global::CommonResources.AcgResources.ID_SMARTCONNECTRSSITHRESHOLDSRETURNTOLMRRSSITHRESHOLD, 0, 255, null, null, 0, 1);
			this.trkWideSmartConnectRSSIReturnThreshold_43723.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkWideSmartConnectRSSIReturnThreshold_43723.DataTransferOrder = 98;
			this.trkWideSmartConnectRSSIReturnThreshold_43723.ShowHexValue = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("駊黌鳎飐臔뿖ꯘ뻚껜럞軠迢臤铦", a_);
			base.Id = 10061;
			base.UIName = global::CommonResources.AcgResources.ID_RSSITHRESHOLDS;
			base.DataTransferOrder = 4;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x000710C0 File Offset: 0x0006F2C0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 2;
			short num = (short)1679163400;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆黈ꋊ꧌꫎菐胒蛔黖跘돚꿜뫞鋠询諤详跨飪뿬볮ꋰ뫲담飶雸鿺ꧼ韾猀昂瘄漆昈朊椌倎倐⬒Ⱄ⸖⬘", a_)))
					{
						num = (short)131137541;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_774;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆黈ꋊ꧌꫎苐뻒듔ꗖ귘飚닜뇞迠蛢蛤鏦믨룪뻬ꛮꏰ雲致苶诸闺ꧼ韾猀昂瘄漆昈朊椌倎┐‒∔┖⨘", a_)))
					{
						num = (short)946077706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8B1;
				case 2:
					num = (short)212205587;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆黈ꋊ꧌꫎菐胒蛔黖跘돚꿜뫞鋠询諤详跨飪뿬볮ꋰ뫲뫴ꓶ껸룺鋼諾漀眂怄甆嘈䨊㔌㘎⠐☒", a_)))
					{
						num = (short)2075918349;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_21F;
				case 4:
					this.trkWideRSSIBackupPTTFallbackThreshold_A43626 = new global::AcpBusinessLayer.AcpSimpleRangeField(52, this, global::AllFeatures.CodeplugGuid.b("韂럄곆黈ꋊ꧌꫎菐胒蛔黖鯘뫚뻜듞铠鏢뗤돦뷨귪賬菮鷰釲铴银鋸꿺闼跾搀瀂洄栆攈漊刌与┐‒⌔┖⼘", a_), global::CommonResources.AcgResources.ID_SMARTCONNECTRSSITHRESHOLDSRSSISMARTCONNECTFALLBACKTHRESHOLD, null, null, 0, 1);
					this.trkWideRSSIBackupPTTFallbackThreshold_A43626.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkWideRSSIBackupPTTFallbackThreshold_A43626.DataTransferOrder = 36;
					this.trkWideRSSIBackupPTTFallbackThreshold_A43626.ShowHexValue = true;
					num = (short)292290593;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992 = new global::AcpBusinessLayer.AcpSimpleRangeField(64, this, global::AllFeatures.CodeplugGuid.b("韂럄곆黈ꋊ꧌꫎菐胒蛔黖跘돚꿜뫞鋠询諤详跨飪뿬볮ꋰ뫲담飶雸鿺ꧼ韾猀昂瘄漆昈朊椌倎倐⬒Ⱄ⸖⬘", a_), global::CommonResources.AcgResources.ID_SMARTZONERSSITHRESHOLDSRSSIGOODTHRESHOLD, null, null, 0, 1);
					this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.DataTransferOrder = 20;
					this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.ShowHexValue = true;
					num = (short)317980689;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_21F;
				case 7:
					goto IL_2D7;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_B5;
					}
					continue;
				case 9:
					num = (short)1739456513;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆黈ꋊ꧌꫎菐胒蛔黖跘돚꿜뫞鋠询諤详跨飪뻬鯮菰鳲鯴郶꫸鋺髼釾怀漂圄栆栈昊搌愎瘐䰒吔┖ⴘⴚ⸜⼞", a_)))
					{
						num = (short)246743069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_725;
				case 10:
					this.trkWideSmartConnectRSSIReturnThreshold_43723 = new global::AcpBusinessLayer.AcpSimpleRangeField(65, this, global::AllFeatures.CodeplugGuid.b("韂럄곆黈ꋊ꧌꫎苐뻒듔ꗖ귘飚닜뇞迠蛢蛤鏦믨룪뻬ꛮꏰ雲致苶诸闺ꧼ韾猀昂瘄漆昈朊椌倎┐‒∔┖⨘", a_), global::CommonResources.AcgResources.ID_SMARTCONNECTRSSITHRESHOLDSRETURNTOLMRRSSITHRESHOLD, null, null, 0, 1);
					this.trkWideSmartConnectRSSIReturnThreshold_43723.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkWideSmartConnectRSSIReturnThreshold_43723.DataTransferOrder = 98;
					this.trkWideSmartConnectRSSIReturnThreshold_43723.ShowHexValue = true;
					num = (short)508100628;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆黈ꋊ꧌꫎菐胒蛔黖跘돚꿜뫞鋠询諤详跨飪뿬볮ꋰ뫲듴银髸黺跼课怀愂椄戆崈挊缌樎成笒稔笖紘䐚尜✞ᠠᬢᰤ", a_)))
					{
						num = (short)1268449311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3D6;
				case 12:
					goto IL_5A4;
				case 13:
					this.trkWideRSSIThresholdsRSSIOSWCounter_A8995 = new global::AcpBusinessLayer.AcpSimpleRangeField(80, this, global::AllFeatures.CodeplugGuid.b("韂럄곆黈ꋊ꧌꫎菐胒蛔黖跘돚꿜뫞鋠询諤详跨飪뿬볮ꋰ뫲뫴ꓶ껸룺鋼諾漀眂怄甆嘈䨊㔌㘎⠐☒", a_), global::CommonResources.AcgResources.ID_RSSIOSWCOUNTER, null, null, 0, 1);
					this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.DataTransferOrder = 22;
					this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.ShowHexValue = false;
					num = (short)1981415430;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_3D6;
				case 15:
					goto IL_725;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆黈ꋊ꧌꫎菐胒蛔黖跘돚꿜뫞鋠询諤详跨飪뿬볮ꋰ뫲냴迶髸黺釼鏾搀洂焄匆愈礊栌簎礐簒礔猖䘘娚├☞ᠠሢ", a_)))
					{
						goto IL_407;
					}
					goto IL_51D;
				case 17:
					goto IL_774;
				case 18:
					this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996 = new global::AcpBusinessLayer.AcpSimpleRangeField(70, this, global::AllFeatures.CodeplugGuid.b("韂럄곆黈ꋊ꧌꫎菐胒蛔黖跘돚꿜뫞鋠询諤详跨飪뿬볮ꋰ뫲ꏴ鋶诸苺뫼郾渀朂億漆笈渊縌朎縐缒焔䠖堘⌚␜☞ᜠ", a_), global::CommonResources.AcgResources.ID_SMARTZONERSSITHRESHOLDSRSSIVERYGOODTHRESHOLD, null, null, 0, 1);
					this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.DataTransferOrder = 25;
					this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.ShowHexValue = true;
					num = (short)890241048;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					if (producerFields != null)
					{
						num = (short)157024283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8B1;
				case 20:
					goto IL_518;
				case 21:
					this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991 = new global::AcpBusinessLayer.AcpSimpleRangeField(77, this, global::AllFeatures.CodeplugGuid.b("韂럄곆黈ꋊ꧌꫎菐胒蛔黖跘돚꿜뫞鋠询諤详跨飪뿬볮ꋰ뫲냴迶髸黺釼鏾搀洂焄匆愈礊栌簎礐簒礔猖䘘娚├☞ᠠሢ", a_), global::CommonResources.AcgResources.ID_SMARTZONERSSITHRESHOLDSRSSIEXCELLENTTHRESHOLD, null, null, 0, 1);
					this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.DataTransferOrder = 24;
					this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.ShowHexValue = true;
					num = (short)224329754;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆黈ꋊ꧌꫎菐胒蛔黖鯘뫚뻜듞铠鏢뗤돦뷨귪賬菮鷰釲铴银鋸꿺闼跾搀瀂洄栆攈漊刌与┐‒⌔┖⼘", a_)))
					{
						num = (short)1290076164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_324;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆黈ꋊ꧌꫎菐胒蛔黖跘돚꿜뫞鋠询諤详跨飪뿬볮ꋰ뫲뫴ꓶ꧸룺鋼諾漀眂怄甆嘈䨊㔌㘎⠐✒", a_)))
					{
						num = (short)410976281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D7;
				case 24:
					goto IL_143;
				case 25:
					this.trkWideRSSIThresholdsRSSIOSPCounter_A8994 = new global::AcpBusinessLayer.AcpSimpleRangeField(102, this, global::AllFeatures.CodeplugGuid.b("韂럄곆黈ꋊ꧌꫎菐胒蛔黖跘돚꿜뫞鋠询諤详跨飪뿬볮ꋰ뫲뫴ꓶ꧸룺鋼諾漀眂怄甆嘈䨊㔌㘎⠐✒", a_), global::CommonResources.AcgResources.ID_RSSIOSPCOUNTER, null, null, 0, 1);
					this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.DataTransferOrder = 21;
					this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.ShowHexValue = false;
					num = (short)857800711;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					goto IL_51D;
				case 27:
					num = (short)644415516;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆黈ꋊ꧌꫎菐胒蛔黖跘돚꿜뫞鋠询諤详跨飪ꧬ諮苰雲鯴蓶鳸꿺铼鋾搀焂娄䘆㸈㌊㼌㜎", a_)))
					{
						num = (short)1393819680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5A4;
				case 29:
					this.trkWideRSSIThresholdsStrongSignalRoaming_A24630 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("韂럄곆黈ꋊ꧌꫎菐胒蛔黖跘돚꿜뫞鋠询諤详跨飪뻬鯮菰鳲鯴郶꫸鋺髼釾怀漂圄栆栈昊搌愎瘐䰒吔┖ⴘⴚ⸜⼞", a_), global::CommonResources.AcgResources.ID_SMARTZONERSSITHRESHOLDSSTRONGSIGNALROAMING);
					this.trkWideRSSIThresholdsStrongSignalRoaming_A24630.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideRSSIThresholdsStrongSignalRoaming_A24630.DataTransferOrder = 33;
					num = (short)1467088911;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
				{
					num = (short)1543305337;
					short num3 = num;
					num = (short)656210041;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_407;
					default:
						num = (short)557121536;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆黈ꋊ꧌꫎菐胒蛔黖跘돚꿜뫞鋠询諤详跨飪뿬볮ꋰ뫲ꏴ鋶诸苺뫼郾渀朂億漆笈渊縌朎縐缒焔䠖堘⌚␜☞ᜠ", a_)))
						{
							num = (short)577962002;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_143;
					}
					break;
				}
				case 31:
					this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989 = new global::AcpBusinessLayer.AcpSimpleRangeField(52, this, global::AllFeatures.CodeplugGuid.b("韂럄곆黈ꋊ꧌꫎菐胒蛔黖跘돚꿜뫞鋠询諤详跨飪뿬볮ꋰ뫲듴银髸黺跼课怀愂椄戆崈挊缌樎成笒稔笖紘䐚尜✞ᠠᬢᰤ", a_), global::CommonResources.AcgResources.ID_SMARTZONERSSITHRESHOLDSRSSIACCEPTABLETHRESHOLD, null, null, 0, 1);
					this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.DataTransferOrder = 23;
					this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.ShowHexValue = true;
					num = (short)1962541070;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					this.trkWideRSSIThresholdsDesenseTimer_A7828 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("韂럄곆黈ꋊ꧌꫎菐胒蛔黖跘돚꿜뫞鋠询諤详跨飪ꧬ諮苰雲鯴蓶鳸꿺铼鋾搀焂娄䘆㸈㌊㼌㜎", a_), global::CommonResources.AcgResources.ID_DESENSETIMERSEC, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 1);
					this.trkWideRSSIThresholdsDesenseTimer_A7828.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideRSSIThresholdsDesenseTimer_A7828.DataTransferOrder = 19;
					this.trkWideRSSIThresholdsDesenseTimer_A7828.ShowHexValue = false;
					num = (short)1092354060;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
				{
					num = (short)224133120;
					short num4 = num;
					goto IL_324;
				}
				}
				IL_B5:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)2131296258;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_143:
				num = (short)1248067593;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_21F:
				num = (short)1286144022;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2D7:
				num = (short)426508291;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_324:
				num = (short)1377894401;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3D6:
				num = (short)1613234192;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_407:
				num = (short)586088469;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_51D:
				num = (short)377356288;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5A4:
				num = (short)734003211;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_725:
				num = (short)384303127;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_774:
				num = (short)1159725086;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_518:
			IL_8B1:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("釂雄铆胈駌꟎ꏐ뛒ꛔ뿖뛘럚맜곞", a_);
			base.Id = 10061;
			base.UIName = global::CommonResources.AcgResources.ID_RSSITHRESHOLDS;
			base.DataTransferOrder = 4;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x000719B0 File Offset: 0x0006FBB0
		public override void PopulateReferences()
		{
			short num = (short)2003828736;
			short num2 = num;
			num = (short)1373845676;
			short num3 = num;
			num = (short)1770338476;
			switch (num3 == num)
			{
			}
			num = (short)1260060673;
			if (num != 0)
			{
			}
			num = (short)1709637632;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00071A58 File Offset: 0x0006FC58
		public override void DropReferences()
		{
			short num = (short)1301020672;
			short num2 = num;
			num = (short)775163601;
			short num3 = num;
			num = (short)1824132817;
			switch (num3 == num)
			{
			}
			num = (short)2042167297;
			if (num != 0)
			{
			}
			num = (short)1405747200;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00071B04 File Offset: 0x0006FD04
		public override void SetConstraints()
		{
			short num = (short)553254912;
			short num2 = num;
			num = (short)1975033300;
			short num3 = num;
			num = (short)1606524372;
			switch (num3 == num)
			{
			}
			num = (short)1998192640;
			if (num != 0)
			{
			}
			num = (short)1434124289;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00071BAC File Offset: 0x0006FDAC
		public override void SetupDependencies()
		{
			short num = (short)1188954112;
			short num2 = num;
			num = (short)713951930;
			short num3 = num;
			num = (short)1161824954;
			switch (num3 == num)
			{
			}
			num = (short)240779265;
			if (num != 0)
			{
			}
			num = (short)1518206976;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x00071C58 File Offset: 0x0006FE58
		public bool HasDiffs
		{
			get
			{
				short num = (short)1350303744;
				short num2 = num;
				num = (short)383407848;
				short num3 = num;
				num = (short)28399336;
				switch (num3 == num)
				{
				}
				num = (short)1596915713;
				if (num != 0)
				{
				}
				num = (short)1998258176;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x00071D08 File Offset: 0x0006FF08
		// (set) Token: 0x0600072A RID: 1834 RVA: 0x00071DBC File Offset: 0x0006FFBC
		public int TrkWideRSSIThresholdsDesenseTimer_A7828Value
		{
			get
			{
				short num = (short)1295515648;
				short num2 = num;
				num = (short)1536836953;
				short num3 = num;
				num = (short)53691737;
				switch (num3 == num)
				{
				}
				num = (short)149094401;
				if (num != 0)
				{
				}
				num = (short)1738866688;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsDesenseTimer_A7828.Value;
			}
			set
			{
				short num = (short)768081920;
				short num2 = num;
				num = (short)388307037;
				short num3 = num;
				num = (short)1405294685;
				switch (num3 == num)
				{
				}
				num = (short)583794689;
				if (num != 0)
				{
				}
				num = (short)641204224;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsDesenseTimer_A7828.Value = value;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x00071E74 File Offset: 0x00070074
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideRSSIThresholdsDesenseTimer_A7828
		{
			get
			{
				short num = (short)1897267200;
				short num2 = num;
				num = (short)1143996556;
				short num3 = num;
				num = (short)1528823948;
				switch (num3 == num)
				{
				}
				num = (short)1230635009;
				if (num != 0)
				{
				}
				num = (short)874446848;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsDesenseTimer_A7828;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x00071F20 File Offset: 0x00070120
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x00071FD0 File Offset: 0x000701D0
		public string TrkWideRSSIThresholdsDesenseTimer_A7828_UIValue
		{
			get
			{
				short num = (short)966459392;
				short num2 = num;
				num = (short)2015761905;
				short num3 = num;
				num = (short)699274737;
				switch (num3 == num)
				{
				}
				num = (short)274399233;
				if (num != 0)
				{
				}
				num = (short)1110376448;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsDesenseTimer_A7828.UIValue;
			}
			set
			{
				short num = (short)485883904;
				short num2 = num;
				num = (short)1933253490;
				short num3 = num;
				num = (short)717101938;
				switch (num3 == num)
				{
				}
				num = (short)1867972608;
				if (num != 0)
				{
				}
				num = (short)1505755137;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsDesenseTimer_A7828.UIValue = value;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x00072084 File Offset: 0x00070284
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x0007213C File Offset: 0x0007033C
		internal int TrkWideRSSIThresholdsDesenseTimer_A7828Min
		{
			get
			{
				short num = (short)588906496;
				short num2 = num;
				num = (short)1794450183;
				short num3 = num;
				num = (short)970466055;
				switch (num3 == num)
				{
				}
				num = (short)569966592;
				if (num != 0)
				{
				}
				num = (short)295567361;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsDesenseTimer_A7828.Min;
			}
			set
			{
				short num = (short)859176960;
				short num2 = num;
				num = (short)1551313092;
				short num3 = num;
				num = (short)1690446020;
				switch (num3 == num)
				{
				}
				num = (short)425525249;
				if (num != 0)
				{
				}
				num = (short)263389184;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsDesenseTimer_A7828.Min = value;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x000721F0 File Offset: 0x000703F0
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x000722A4 File Offset: 0x000704A4
		internal int TrkWideRSSIThresholdsDesenseTimer_A7828Max
		{
			get
			{
				short num = (short)1426915328;
				short num2 = num;
				num = (short)918814721;
				if (num != 0)
				{
				}
				num = (short)367817355;
				short num3 = num;
				num = (short)817066635;
				switch (num3 == num)
				{
				}
				num = (short)1665007616;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsDesenseTimer_A7828.Max;
			}
			set
			{
				short num = (short)1014759424;
				short num2 = num;
				num = (short)273028590;
				short num3 = num;
				num = (short)367728110;
				switch (num3 == num)
				{
				}
				num = (short)1277624321;
				if (num != 0)
				{
				}
				num = (short)402784256;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsDesenseTimer_A7828.Max = value;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x0007235C File Offset: 0x0007055C
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x00072410 File Offset: 0x00070610
		internal int TrkWideRSSIThresholdsDesenseTimer_A7828Step
		{
			get
			{
				short num = (short)2136869922;
				short num2 = num;
				num = (short)1253968930;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1238368256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)75300864;
				if (num != 0)
				{
				}
				num = (short)1829634049;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsDesenseTimer_A7828.StepSize;
			}
			set
			{
				short num = (short)957628158;
				short num2 = num;
				num = (short)1805008638;
				switch (num2 == num)
				{
				default:
				{
					num = (short)299499520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1128398849;
				if (num != 0)
				{
				}
				num = (short)2054225920;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsDesenseTimer_A7828.StepSize = value;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x000724C8 File Offset: 0x000706C8
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x00072580 File Offset: 0x00070780
		public bool TrkWideRSSIThresholdsDesenseTimer_A7828_Applicable
		{
			get
			{
				short num = (short)69332976;
				short num2 = num;
				num = (short)656732144;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1976303616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1558773760;
				if (num != 0)
				{
				}
				num = (short)830013441;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsDesenseTimer_A7828.Applicable;
			}
			set
			{
				short num = (short)1922498561;
				if (num != 0)
				{
				}
				num = (short)1453522944;
				short num2 = num;
				num = (short)1291183212;
				short num3 = num;
				num = (short)1224729708;
				switch (num3 == num)
				{
				}
				num = (short)1942814720;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsDesenseTimer_A7828.Applicable = value;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x00072638 File Offset: 0x00070838
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x000726F0 File Offset: 0x000708F0
		public bool TrkWideRSSIThresholdsDesenseTimer_A7828_Valid
		{
			get
			{
				short num = (short)1647110906;
				short num2 = num;
				num = (short)1482812154;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1928658944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2146893825;
				if (num != 0)
				{
				}
				num = (short)293339136;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsDesenseTimer_A7828.Valid;
			}
			set
			{
				short num = (short)878619292;
				short num2 = num;
				num = (short)961784476;
				switch (num2 == num)
				{
				default:
				{
					num = (short)416350208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1450573825;
				if (num != 0)
				{
				}
				num = (short)1827340288;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsDesenseTimer_A7828.Valid = value;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x000727A4 File Offset: 0x000709A4
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x00072858 File Offset: 0x00070A58
		public bool TrkWideRSSIThresholdsDesenseTimer_A7828_Visible
		{
			get
			{
				short num = (short)255788716;
				short num2 = num;
				num = (short)1332414124;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1829437440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1462304769;
				if (num != 0)
				{
				}
				num = (short)1919680512;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsDesenseTimer_A7828.Visible;
			}
			set
			{
				short num = (short)1295777357;
				short num2 = num;
				num = (short)1021967949;
				switch (num2 == num)
				{
				default:
				{
					num = (short)136380416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1677852672;
				if (num != 0)
				{
				}
				num = (short)348127233;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsDesenseTimer_A7828.Visible = value;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x0007290C File Offset: 0x00070B0C
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x000729C0 File Offset: 0x00070BC0
		public bool TrkWideRSSIThresholdsDesenseTimer_A7828_Editable
		{
			get
			{
				short num = (short)843334410;
				short num2 = num;
				num = (short)2142651146;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1867579392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1718943745;
				if (num != 0)
				{
				}
				num = (short)135593984;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsDesenseTimer_A7828.Editable;
			}
			set
			{
				short num = (short)1977304486;
				short num2 = num;
				num = (short)1656047014;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1418461184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1255276545;
				if (num != 0)
				{
				}
				num = (short)1003945984;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsDesenseTimer_A7828.Editable = value;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x00072A78 File Offset: 0x00070C78
		internal string TrkWideRSSIThresholdsDesenseTimer_A7828_UILabel
		{
			get
			{
				short num = (short)913148896;
				short num2 = num;
				num = (short)776571872;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1155399680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)857931777;
				if (num != 0)
				{
				}
				num = (short)99614720;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsDesenseTimer_A7828.UIName;
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x00072B2C File Offset: 0x00070D2C
		// (set) Token: 0x0600073E RID: 1854 RVA: 0x00072BE0 File Offset: 0x00070DE0
		internal bool TrkWideRSSIThresholdsDesenseTimer_A7828_HiddenStatic
		{
			get
			{
				short num = (short)2082078721;
				if (num != 0)
				{
				}
				num = (short)631635968;
				short num2 = num;
				num = (short)148949681;
				short num3 = num;
				num = (short)785828529;
				switch (num3 == num)
				{
				}
				num = (short)1012858880;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsDesenseTimer_A7828.HiddenStatic;
			}
			set
			{
				short num = (short)1482081255;
				short num2 = num;
				num = (short)785368039;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1221066752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)547618816;
				if (num != 0)
				{
				}
				num = (short)629407745;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsDesenseTimer_A7828.HiddenStatic = value;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x00072C94 File Offset: 0x00070E94
		// (set) Token: 0x06000740 RID: 1856 RVA: 0x00072D4C File Offset: 0x00070F4C
		internal bool TrkWideRSSIThresholdsDesenseTimer_A7828_HiddenDynamic
		{
			get
			{
				short num = (short)1827736589;
				short num2 = num;
				num = (short)1461652493;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1018298368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1006567425;
				if (num != 0)
				{
				}
				num = (short)2061500416;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsDesenseTimer_A7828.HiddenDynamic;
			}
			set
			{
				short num = (short)1232016101;
				short num2 = num;
				num = (short)751899365;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1966931968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1288437760;
				if (num != 0)
				{
				}
				num = (short)1734606849;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsDesenseTimer_A7828.HiddenDynamic = value;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x00072E00 File Offset: 0x00071000
		public bool TrkWideRSSIThresholdsDesenseTimer_A7828_HasDiffs
		{
			get
			{
				short num = (short)1377819926;
				short num2 = num;
				num = (short)535092502;
				switch (num2 == num)
				{
				default:
				{
					num = (short)715522048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)577830913;
				if (num != 0)
				{
				}
				num = (short)973340672;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsDesenseTimer_A7828._HasDiffs;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x00072EB4 File Offset: 0x000710B4
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x00072F68 File Offset: 0x00071168
		public int TrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989Value
		{
			get
			{
				short num = (short)2105341273;
				short num2 = num;
				num = (short)576714073;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1358036992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)677445632;
				if (num != 0)
				{
				}
				num = (short)229179393;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.Value;
			}
			set
			{
				short num = (short)1310354561;
				short num2 = num;
				num = (short)689925249;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1464074240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1418133504;
				if (num != 0)
				{
				}
				num = (short)257753089;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.Value = value;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x00073020 File Offset: 0x00071220
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989
		{
			get
			{
				short num = (short)1272250126;
				short num2 = num;
				num = (short)2045181710;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1717633024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1498873857;
				if (num != 0)
				{
				}
				num = (short)1877999616;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x000730D0 File Offset: 0x000712D0
		// (set) Token: 0x06000746 RID: 1862 RVA: 0x00073184 File Offset: 0x00071384
		public string TrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989_UIValue
		{
			get
			{
				short num = (short)2120549122;
				short num2 = num;
				num = (short)676725506;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1180237824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1570308097;
				if (num != 0)
				{
				}
				num = (short)55967744;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.UIValue;
			}
			set
			{
				short num = (short)672899163;
				short num2 = num;
				num = (short)1189716059;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1558118400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)780664833;
				if (num != 0)
				{
				}
				num = (short)839319552;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.UIValue = value;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x0007323C File Offset: 0x0007143C
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x000732F0 File Offset: 0x000714F0
		public string TrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989_HexUIValue
		{
			get
			{
				short num = (short)1960042852;
				short num2 = num;
				num = (short)234807652;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2038628352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1136197633;
				if (num != 0)
				{
				}
				num = (short)1905590272;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.HexUIValue;
			}
			set
			{
				short num = (short)127843019;
				short num2 = num;
				num = (short)796834507;
				switch (num2 == num)
				{
				default:
				{
					num = (short)297533440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1600978945;
				if (num != 0)
				{
				}
				num = (short)1077542912;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.HexUIValue = value;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x000733A8 File Offset: 0x000715A8
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x0007345C File Offset: 0x0007165C
		internal int TrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989Min
		{
			get
			{
				short num = (short)367614521;
				short num2 = num;
				num = (short)931224121;
				switch (num2 == num)
				{
				default:
				{
					num = (short)597229568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1081212929;
				if (num != 0)
				{
				}
				num = (short)456785920;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.Min;
			}
			set
			{
				short num = (short)809292099;
				short num2 = num;
				num = (short)1402458435;
				switch (num2 == num)
				{
				default:
				{
					num = (short)93061120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1436352513;
				if (num != 0)
				{
				}
				num = (short)29032448;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.Min = value;
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x00073510 File Offset: 0x00071710
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x000735C4 File Offset: 0x000717C4
		internal int TrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989Max
		{
			get
			{
				short num = (short)805928396;
				short num2 = num;
				num = (short)1299021260;
				switch (num2 == num)
				{
				default:
				{
					num = (short)508952576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)877264897;
				if (num != 0)
				{
				}
				num = (short)1755316224;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.Max;
			}
			set
			{
				short num = (short)1456207528;
				short num2 = num;
				num = (short)1327232680;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1370685440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)617807872;
				if (num != 0)
				{
				}
				num = (short)1738276865;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.Max = value;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x0007367C File Offset: 0x0007187C
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x00073730 File Offset: 0x00071930
		internal int TrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989Step
		{
			get
			{
				short num = (short)1389254257;
				short num2 = num;
				num = (short)467031665;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1678049280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)258211841;
				if (num != 0)
				{
				}
				num = (short)1262813184;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.StepSize;
			}
			set
			{
				short num = (short)1044487467;
				short num2 = num;
				num = (short)1826069803;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1268973568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1287389184;
				if (num != 0)
				{
				}
				num = (short)2012872705;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.StepSize = value;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x000737E4 File Offset: 0x000719E4
		// (set) Token: 0x06000750 RID: 1872 RVA: 0x00073898 File Offset: 0x00071A98
		public bool TrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989_Applicable
		{
			get
			{
				short num = (short)1709401559;
				short num2 = num;
				num = (short)1352099287;
				switch (num2 == num)
				{
				default:
				{
					num = (short)132710400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)646643713;
				if (num != 0)
				{
				}
				num = (short)1125974016;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.Applicable;
			}
			set
			{
				short num = (short)711822543;
				short num2 = num;
				num = (short)104959183;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1403715584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1031077888;
				if (num != 0)
				{
				}
				num = (short)314048513;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.Applicable = value;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x0007394C File Offset: 0x00071B4C
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x00073A04 File Offset: 0x00071C04
		public bool TrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989_Valid
		{
			get
			{
				short num = (short)546831255;
				short num2 = num;
				num = (short)661453719;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1729888256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1253638145;
				if (num != 0)
				{
				}
				num = (short)866516992;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.Valid;
			}
			set
			{
				short num = (short)1682583370;
				short num2 = num;
				num = (short)2174794;
				switch (num2 == num)
				{
				default:
				{
					num = (short)966262784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1484652545;
				if (num != 0)
				{
				}
				num = (short)1722679296;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.Valid = value;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x00073AB8 File Offset: 0x00071CB8
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x00073B6C File Offset: 0x00071D6C
		public bool TrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989_Visible
		{
			get
			{
				short num = (short)2134087109;
				short num2 = num;
				num = (short)1701352901;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1843527680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)811270145;
				if (num != 0)
				{
				}
				num = (short)809566208;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.Visible;
			}
			set
			{
				short num = (short)526843905;
				if (num != 0)
				{
				}
				num = (short)797769728;
				short num2 = num;
				num = (short)1472913835;
				short num3 = num;
				num = (short)315351467;
				switch (num3 == num)
				{
				}
				num = (short)1290600448;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.Visible = value;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00073C24 File Offset: 0x00071E24
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x00073CD8 File Offset: 0x00071ED8
		public bool TrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989_Editable
		{
			get
			{
				short num = (short)474092294;
				short num2 = num;
				num = (short)582816518;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2034237440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1618804737;
				if (num != 0)
				{
				}
				num = (short)1456603136;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.Editable;
			}
			set
			{
				short num = (short)1977155585;
				if (num != 0)
				{
				}
				num = (short)789970944;
				short num2 = num;
				num = (short)1980526098;
				short num3 = num;
				num = (short)1148153362;
				switch (num3 == num)
				{
				}
				num = (short)1800273920;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.Editable = value;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x00073D90 File Offset: 0x00071F90
		internal string TrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989_UILabel
		{
			get
			{
				short num = (short)217096204;
				short num2 = num;
				num = (short)741646348;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1860567040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)748879872;
				if (num != 0)
				{
				}
				num = (short)71892993;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.UIName;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x00073E44 File Offset: 0x00072044
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x00073EF8 File Offset: 0x000720F8
		internal bool TrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989_HiddenStatic
		{
			get
			{
				short num = (short)46661633;
				if (num != 0)
				{
				}
				num = (short)1493565440;
				short num2 = num;
				num = (short)1721314285;
				short num3 = num;
				num = (short)926034925;
				switch (num3 == num)
				{
				}
				num = (short)1060438016;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.HiddenStatic;
			}
			set
			{
				short num = (short)369684066;
				short num2 = num;
				num = (short)1693576802;
				switch (num2 == num)
				{
				default:
				{
					num = (short)246611968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1033502721;
				if (num != 0)
				{
				}
				num = (short)1045168128;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.HiddenStatic = value;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x00073FB4 File Offset: 0x000721B4
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x0007406C File Offset: 0x0007226C
		internal bool TrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989_HiddenDynamic
		{
			get
			{
				short num = (short)1013445068;
				short num2 = num;
				num = (short)2104750540;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1091371008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1255473152;
				if (num != 0)
				{
				}
				num = (short)1862139905;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.HiddenDynamic;
			}
			set
			{
				short num = (short)1604794975;
				short num2 = num;
				num = (short)1749760607;
				switch (num2 == num)
				{
				}
				num = (short)1523515392;
				if (num != 0)
				{
				}
				num = (short)1644298241;
				if (num != 0)
				{
				}
				num = (short)188284928;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989.HiddenDynamic = value;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x00074120 File Offset: 0x00072320
		public bool TrkWideRSSIThresholdsRSSIAcceptableThreshold_A8989_HasDiffs
		{
			get
			{
				short num = (short)1679491073;
				if (num != 0)
				{
				}
				num = (short)1200278471;
				short num2 = num;
				num = (short)711773127;
				switch (num2 == num)
				{
				}
				num = (short)128843776;
				if (num != 0)
				{
				}
				num = (short)1449000960;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989._HasDiffs;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x000741D4 File Offset: 0x000723D4
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x00074288 File Offset: 0x00072488
		public int TrkWideRSSIThresholdsRSSIExcellentThreshold_A8991Value
		{
			get
			{
				short num = (short)546723886;
				short num2 = num;
				num = (short)1243830318;
				switch (num2 == num)
				{
				}
				num = (short)50855936;
				if (num != 0)
				{
				}
				num = (short)1185808385;
				if (num != 0)
				{
				}
				num = (short)753598464;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.Value;
			}
			set
			{
				short num = (short)816545497;
				short num2 = num;
				num = (short)1741848281;
				switch (num2 == num)
				{
				}
				num = (short)988086272;
				if (num != 0)
				{
				}
				num = (short)1672740865;
				if (num != 0)
				{
				}
				num = (short)485425152;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.Value = value;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x00074340 File Offset: 0x00072540
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideRSSIThresholdsRSSIExcellentThreshold_A8991
		{
			get
			{
				short num = (short)1238142006;
				short num2 = num;
				num = (short)668306486;
				switch (num2 == num)
				{
				}
				num = (short)1813839873;
				if (num != 0)
				{
				}
				num = (short)1278345216;
				if (num != 0)
				{
				}
				num = (short)2053832704;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x000743F0 File Offset: 0x000725F0
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x000744A4 File Offset: 0x000726A4
		public string TrkWideRSSIThresholdsRSSIExcellentThreshold_A8991_UIValue
		{
			get
			{
				short num = (short)14713202;
				short num2 = num;
				num = (short)45252978;
				switch (num2 == num)
				{
				}
				num = (short)759693313;
				if (num != 0)
				{
				}
				num = (short)1500184576;
				if (num != 0)
				{
				}
				num = (short)1878327296;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.UIValue;
			}
			set
			{
				short num = (short)1778322512;
				short num2 = num;
				num = (short)45419600;
				switch (num2 == num)
				{
				}
				num = (short)412680193;
				if (num != 0)
				{
				}
				num = (short)1772421120;
				if (num != 0)
				{
				}
				num = (short)78774272;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.UIValue = value;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x0007455C File Offset: 0x0007275C
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x00074614 File Offset: 0x00072814
		public string TrkWideRSSIThresholdsRSSIExcellentThreshold_A8991_HexUIValue
		{
			get
			{
				short num = (short)471657894;
				short num2 = num;
				num = (short)1789259174;
				switch (num2 == num)
				{
				}
				num = (short)316276737;
				if (num != 0)
				{
				}
				num = (short)1955921920;
				if (num != 0)
				{
				}
				num = (short)1337131008;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.HexUIValue;
			}
			set
			{
				short num = (short)1423704065;
				if (num != 0)
				{
				}
				num = (short)1150564571;
				short num2 = num;
				num = (short)256260315;
				switch (num2 == num)
				{
				}
				num = (short)1055588352;
				if (num != 0)
				{
				}
				num = (short)1516503040;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.HexUIValue = value;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x000746C8 File Offset: 0x000728C8
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x0007477C File Offset: 0x0007297C
		internal int TrkWideRSSIThresholdsRSSIExcellentThreshold_A8991Min
		{
			get
			{
				short num = (short)1362624513;
				if (num != 0)
				{
				}
				num = (short)328082968;
				short num2 = num;
				num = (short)1581917720;
				switch (num2 == num)
				{
				}
				num = (short)1644625920;
				if (num != 0)
				{
				}
				num = (short)2063597568;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.Min;
			}
			set
			{
				short num = (short)45023233;
				if (num != 0)
				{
				}
				num = (short)1662236294;
				short num2 = num;
				num = (short)1530181254;
				switch (num2 == num)
				{
				}
				num = (short)771883008;
				if (num != 0)
				{
				}
				num = (short)206569472;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.Min = value;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x00074834 File Offset: 0x00072A34
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x000748EC File Offset: 0x00072AEC
		internal int TrkWideRSSIThresholdsRSSIExcellentThreshold_A8991Max
		{
			get
			{
				short num = (short)992029110;
				short num2 = num;
				num = (short)988490166;
				switch (num2 == num)
				{
				}
				num = (short)1817640961;
				if (num != 0)
				{
				}
				num = (short)1963851776;
				if (num != 0)
				{
				}
				num = (short)1008009216;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.Max;
			}
			set
			{
				short num = (short)109473673;
				short num2 = num;
				num = (short)1748922249;
				switch (num2 == num)
				{
				}
				num = (short)614989824;
				if (num != 0)
				{
				}
				num = (short)1380450305;
				if (num != 0)
				{
				}
				num = (short)1466433536;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.Max = value;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x000749A0 File Offset: 0x00072BA0
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x00074A54 File Offset: 0x00072C54
		internal int TrkWideRSSIThresholdsRSSIExcellentThreshold_A8991Step
		{
			get
			{
				short num = (short)1918006674;
				short num2 = num;
				num = (short)513570194;
				switch (num2 == num)
				{
				}
				num = (short)871366656;
				if (num != 0)
				{
				}
				num = (short)1804140545;
				if (num != 0)
				{
				}
				num = (short)197722112;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.StepSize;
			}
			set
			{
				short num = (short)259271358;
				short num2 = num;
				num = (short)1596664510;
				switch (num2 == num)
				{
				}
				num = (short)422838273;
				if (num != 0)
				{
				}
				num = (short)1180631040;
				if (num != 0)
				{
				}
				num = (short)1533411328;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.StepSize = value;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x00074B0C File Offset: 0x00072D0C
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x00074BC0 File Offset: 0x00072DC0
		public bool TrkWideRSSIThresholdsRSSIExcellentThreshold_A8991_Applicable
		{
			get
			{
				short num = (short)1769964594;
				short num2 = num;
				num = (short)845251634;
				switch (num2 == num)
				{
				}
				num = (short)1378091008;
				if (num != 0)
				{
				}
				num = (short)1349058561;
				if (num != 0)
				{
				}
				num = (short)866451456;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.Applicable;
			}
			set
			{
				short num = (short)138384822;
				short num2 = num;
				num = (short)87987638;
				switch (num2 == num)
				{
				}
				num = (short)1800077313;
				if (num != 0)
				{
				}
				num = (short)342425600;
				if (num != 0)
				{
				}
				num = (short)1944256512;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.Applicable = value;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x00074C78 File Offset: 0x00072E78
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x00074D2C File Offset: 0x00072F2C
		public bool TrkWideRSSIThresholdsRSSIExcellentThreshold_A8991_Valid
		{
			get
			{
				short num = (short)1708462889;
				short num2 = num;
				num = (short)1488851753;
				switch (num2 == num)
				{
				}
				num = (short)1265041409;
				if (num != 0)
				{
				}
				num = (short)348061696;
				if (num != 0)
				{
				}
				num = (short)558825472;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.Valid;
			}
			set
			{
				short num = (short)1829109761;
				if (num != 0)
				{
				}
				num = (short)1654287662;
				short num2 = num;
				num = (short)275672366;
				switch (num2 == num)
				{
				}
				num = (short)67043328;
				if (num != 0)
				{
				}
				num = (short)846069760;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.Valid = value;
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x00074DE0 File Offset: 0x00072FE0
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x00074E94 File Offset: 0x00073094
		public bool TrkWideRSSIThresholdsRSSIExcellentThreshold_A8991_Visible
		{
			get
			{
				short num = (short)845722611;
				short num2 = num;
				num = (short)1954526195;
				switch (num2 == num)
				{
				}
				num = (short)1818820609;
				if (num != 0)
				{
				}
				num = (short)1044054016;
				if (num != 0)
				{
				}
				num = (short)1222836224;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.Visible;
			}
			set
			{
				short num = (short)500760577;
				if (num != 0)
				{
				}
				num = (short)142061627;
				short num2 = num;
				num = (short)602255419;
				switch (num2 == num)
				{
				}
				num = (short)2062614528;
				if (num != 0)
				{
				}
				num = (short)80478208;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.Visible = value;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x00074F48 File Offset: 0x00073148
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x00075000 File Offset: 0x00073200
		public bool TrkWideRSSIThresholdsRSSIExcellentThreshold_A8991_Editable
		{
			get
			{
				short num = (short)1911841057;
				short num2 = num;
				num = (short)1016488225;
				switch (num2 == num)
				{
				}
				num = (short)1344208896;
				if (num != 0)
				{
				}
				num = (short)1121517569;
				if (num != 0)
				{
				}
				num = (short)2066087936;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.Editable;
			}
			set
			{
				short num = (short)1082055986;
				short num2 = num;
				num = (short)773381426;
				switch (num2 == num)
				{
				}
				num = (short)2090074112;
				if (num != 0)
				{
				}
				num = (short)1306853377;
				if (num != 0)
				{
				}
				num = (short)1405288448;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.Editable = value;
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x000750B4 File Offset: 0x000732B4
		internal string TrkWideRSSIThresholdsRSSIExcellentThreshold_A8991_UILabel
		{
			get
			{
				short num = (short)1939454166;
				short num2 = num;
				num = (short)211794134;
				switch (num2 == num)
				{
				}
				num = (short)1109721089;
				if (num != 0)
				{
				}
				num = (short)725614592;
				if (num != 0)
				{
				}
				num = (short)1600323584;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.UIName;
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x0007516C File Offset: 0x0007336C
		// (set) Token: 0x06000774 RID: 1908 RVA: 0x00075220 File Offset: 0x00073420
		internal bool TrkWideRSSIThresholdsRSSIExcellentThreshold_A8991_HiddenStatic
		{
			get
			{
				short num = (short)1659473993;
				short num2 = num;
				num = (short)502829129;
				switch (num2 == num)
				{
				}
				num = (short)589889536;
				if (num != 0)
				{
				}
				num = (short)1176764417;
				if (num != 0)
				{
				}
				num = (short)1367539712;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.HiddenStatic;
			}
			set
			{
				short num = (short)61774695;
				short num2 = num;
				num = (short)1459723111;
				switch (num2 == num)
				{
				}
				num = (short)806748161;
				if (num != 0)
				{
				}
				num = (short)1165754368;
				if (num != 0)
				{
				}
				num = (short)1663107072;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.HiddenStatic = value;
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x000752D4 File Offset: 0x000734D4
		// (set) Token: 0x06000776 RID: 1910 RVA: 0x00075384 File Offset: 0x00073584
		internal bool TrkWideRSSIThresholdsRSSIExcellentThreshold_A8991_HiddenDynamic
		{
			get
			{
				short num = (short)1257701377;
				if (num != 0)
				{
				}
				num = (short)1818177057;
				short num2 = num;
				num = (short)305737249;
				switch (num2 == num)
				{
				}
				num = (short)1989804032;
				if (num != 0)
				{
				}
				num = (short)1531641856;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.HiddenDynamic;
			}
			set
			{
				short num = (short)515189345;
				short num2 = num;
				num = (short)1634282081;
				switch (num2 == num)
				{
				}
				num = (short)547815425;
				if (num != 0)
				{
				}
				num = (short)153223168;
				if (num != 0)
				{
				}
				num = (short)920322048;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991.HiddenDynamic = value;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x0007543C File Offset: 0x0007363C
		public bool TrkWideRSSIThresholdsRSSIExcellentThreshold_A8991_HasDiffs
		{
			get
			{
				short num = (short)980352991;
				short num2 = num;
				num = (short)196542431;
				switch (num2 == num)
				{
				}
				num = (short)1095827457;
				if (num != 0)
				{
				}
				num = (short)1869807616;
				if (num != 0)
				{
				}
				num = (short)1486618624;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIExcellentThreshold_A8991._HasDiffs;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x000754F4 File Offset: 0x000736F4
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x000755A8 File Offset: 0x000737A8
		public int TrkWideRSSIThresholdsRSSIGoodThreshold_A8992Value
		{
			get
			{
				short num = (short)784494340;
				short num2 = num;
				num = (short)752054020;
				switch (num2 == num)
				{
				}
				num = (short)1547894785;
				if (num != 0)
				{
				}
				num = (short)996540416;
				if (num != 0)
				{
				}
				num = (short)982974464;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.Value;
			}
			set
			{
				short num = (short)849302860;
				short num2 = num;
				num = (short)1593333068;
				switch (num2 == num)
				{
				}
				num = (short)796459008;
				if (num != 0)
				{
				}
				num = (short)520093697;
				if (num != 0)
				{
				}
				num = (short)1962278912;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.Value = value;
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x0007565C File Offset: 0x0007385C
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideRSSIThresholdsRSSIGoodThreshold_A8992
		{
			get
			{
				short num = (short)1213087891;
				short num2 = num;
				num = (short)2037792915;
				switch (num2 == num)
				{
				}
				num = (short)1602355200;
				if (num != 0)
				{
				}
				num = (short)303759361;
				if (num != 0)
				{
				}
				num = (short)1705443328;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x00075708 File Offset: 0x00073908
		// (set) Token: 0x0600077C RID: 1916 RVA: 0x000757BC File Offset: 0x000739BC
		public string TrkWideRSSIThresholdsRSSIGoodThreshold_A8992_UIValue
		{
			get
			{
				short num = (short)308281345;
				if (num != 0)
				{
				}
				num = (short)327946411;
				short num2 = num;
				num = (short)56037547;
				switch (num2 == num)
				{
				}
				num = (short)352583680;
				if (num != 0)
				{
				}
				num = (short)436273152;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.UIValue;
			}
			set
			{
				short num = (short)1923420469;
				short num2 = num;
				num = (short)1114968373;
				switch (num2 == num)
				{
				}
				num = (short)514850817;
				if (num != 0)
				{
				}
				num = (short)701693952;
				if (num != 0)
				{
				}
				num = (short)1966014464;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.UIValue = value;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x00075870 File Offset: 0x00073A70
		// (set) Token: 0x0600077E RID: 1918 RVA: 0x00075928 File Offset: 0x00073B28
		public string TrkWideRSSIThresholdsRSSIGoodThreshold_A8992_HexUIValue
		{
			get
			{
				short num = (short)2032035324;
				short num2 = num;
				num = (short)1058366972;
				switch (num2 == num)
				{
				}
				num = (short)507707393;
				if (num != 0)
				{
				}
				num = (short)112590848;
				if (num != 0)
				{
				}
				num = (short)1217134592;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.HexUIValue;
			}
			set
			{
				short num = (short)2044597660;
				short num2 = num;
				num = (short)2080183708;
				switch (num2 == num)
				{
				}
				num = (short)1992949761;
				if (num != 0)
				{
				}
				num = (short)969146368;
				if (num != 0)
				{
				}
				num = (short)52953088;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.HexUIValue = value;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x000759E0 File Offset: 0x00073BE0
		// (set) Token: 0x06000780 RID: 1920 RVA: 0x00075A94 File Offset: 0x00073C94
		internal int TrkWideRSSIThresholdsRSSIGoodThreshold_A8992Min
		{
			get
			{
				short num = (short)768434845;
				short num2 = num;
				num = (short)403727005;
				switch (num2 == num)
				{
				}
				num = (short)642777089;
				if (num != 0)
				{
				}
				num = (short)867893248;
				if (num != 0)
				{
				}
				num = (short)1507917824;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.Min;
			}
			set
			{
				short num = (short)1702681440;
				short num2 = num;
				num = (short)1559354208;
				switch (num2 == num)
				{
				}
				num = (short)282722305;
				if (num != 0)
				{
				}
				num = (short)1302200320;
				if (num != 0)
				{
				}
				num = (short)1407254528;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.Min = value;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x00075B48 File Offset: 0x00073D48
		// (set) Token: 0x06000782 RID: 1922 RVA: 0x00075BFC File Offset: 0x00073DFC
		internal int TrkWideRSSIThresholdsRSSIGoodThreshold_A8992Max
		{
			get
			{
				short num = (short)2113601537;
				if (num != 0)
				{
				}
				num = (short)650265868;
				short num2 = num;
				num = (short)1526088972;
				switch (num2 == num)
				{
				}
				num = (short)2093416448;
				if (num != 0)
				{
				}
				num = (short)1226506240;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.Max;
			}
			set
			{
				short num = (short)142474330;
				short num2 = num;
				num = (short)475069530;
				switch (num2 == num)
				{
				}
				num = (short)725811200;
				if (num != 0)
				{
				}
				num = (short)1105854465;
				if (num != 0)
				{
				}
				num = (short)836108288;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.Max = value;
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x00075CB4 File Offset: 0x00073EB4
		// (set) Token: 0x06000784 RID: 1924 RVA: 0x00075D68 File Offset: 0x00073F68
		internal int TrkWideRSSIThresholdsRSSIGoodThreshold_A8992Step
		{
			get
			{
				short num = (short)962718296;
				short num2 = num;
				num = (short)348711512;
				switch (num2 == num)
				{
				}
				num = (short)1580466177;
				if (num != 0)
				{
				}
				num = (short)1398865920;
				if (num != 0)
				{
				}
				num = (short)16515072;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.StepSize;
			}
			set
			{
				short num = (short)894527691;
				short num2 = num;
				num = (short)1336699083;
				switch (num2 == num)
				{
				}
				num = (short)676528129;
				if (num != 0)
				{
				}
				num = (short)710148096;
				if (num != 0)
				{
				}
				num = (short)1198522368;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.StepSize = value;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x00075E20 File Offset: 0x00074020
		// (set) Token: 0x06000786 RID: 1926 RVA: 0x00075ED4 File Offset: 0x000740D4
		public bool TrkWideRSSIThresholdsRSSIGoodThreshold_A8992_Applicable
		{
			get
			{
				short num = (short)913138768;
				short num2 = num;
				num = (short)1229153360;
				switch (num2 == num)
				{
				}
				num = (short)2102067200;
				if (num != 0)
				{
				}
				num = (short)997851137;
				if (num != 0)
				{
				}
				num = (short)1299709952;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.Applicable;
			}
			set
			{
				short num = (short)1407991742;
				short num2 = num;
				num = (short)2041266110;
				switch (num2 == num)
				{
				}
				num = (short)618397697;
				if (num != 0)
				{
				}
				num = (short)250281984;
				if (num != 0)
				{
				}
				num = (short)1415315456;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.Applicable = value;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x00075F8C File Offset: 0x0007418C
		// (set) Token: 0x06000788 RID: 1928 RVA: 0x00076040 File Offset: 0x00074240
		public bool TrkWideRSSIThresholdsRSSIGoodThreshold_A8992_Valid
		{
			get
			{
				short num = (short)392287816;
				short num2 = num;
				num = (short)1051317832;
				switch (num2 == num)
				{
				}
				num = (short)1934622721;
				if (num != 0)
				{
				}
				num = (short)33619968;
				if (num != 0)
				{
				}
				num = (short)1455489024;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.Valid;
			}
			set
			{
				short num = (short)820105696;
				short num2 = num;
				num = (short)2056376800;
				switch (num2 == num)
				{
				}
				num = (short)54067201;
				if (num != 0)
				{
				}
				num = (short)2054029312;
				if (num != 0)
				{
				}
				num = (short)196411392;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.Valid = value;
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x000760F8 File Offset: 0x000742F8
		// (set) Token: 0x0600078A RID: 1930 RVA: 0x000761AC File Offset: 0x000743AC
		public bool TrkWideRSSIThresholdsRSSIGoodThreshold_A8992_Visible
		{
			get
			{
				short num = (short)1699200960;
				short num2 = num;
				num = (short)1012449216;
				switch (num2 == num)
				{
				}
				num = (short)1898774529;
				if (num != 0)
				{
				}
				num = (short)1068302336;
				if (num != 0)
				{
				}
				num = (short)140050432;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.Visible;
			}
			set
			{
				short num = (short)1289363506;
				short num2 = num;
				num = (short)708386866;
				switch (num2 == num)
				{
				}
				num = (short)249757696;
				if (num != 0)
				{
				}
				num = (short)1920139265;
				if (num != 0)
				{
				}
				num = (short)538968064;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.Visible = value;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x00076260 File Offset: 0x00074460
		// (set) Token: 0x0600078C RID: 1932 RVA: 0x00076314 File Offset: 0x00074514
		public bool TrkWideRSSIThresholdsRSSIGoodThreshold_A8992_Editable
		{
			get
			{
				short num = (short)596096749;
				short num2 = num;
				num = (short)1283307245;
				switch (num2 == num)
				{
				}
				num = (short)1779630080;
				if (num != 0)
				{
				}
				num = (short)1629552641;
				if (num != 0)
				{
				}
				num = (short)32309248;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.Editable;
			}
			set
			{
				short num = (short)809275091;
				short num2 = num;
				num = (short)1439338195;
				switch (num2 == num)
				{
				}
				num = (short)636551169;
				if (num != 0)
				{
				}
				num = (short)1258815488;
				if (num != 0)
				{
				}
				num = (short)1048772608;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.Editable = value;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x000763CC File Offset: 0x000745CC
		internal string TrkWideRSSIThresholdsRSSIGoodThreshold_A8992_UILabel
		{
			get
			{
				short num = (short)1113577563;
				short num2 = num;
				num = (short)829937755;
				switch (num2 == num)
				{
				}
				num = (short)372572161;
				if (num != 0)
				{
				}
				num = (short)238288896;
				if (num != 0)
				{
				}
				num = (short)23986176;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.UIName;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00076480 File Offset: 0x00074680
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x00076538 File Offset: 0x00074738
		internal bool TrkWideRSSIThresholdsRSSIGoodThreshold_A8992_HiddenStatic
		{
			get
			{
				short num = (short)1482752001;
				if (num != 0)
				{
				}
				num = (short)1904381155;
				short num2 = num;
				num = (short)441289955;
				switch (num2 == num)
				{
				}
				num = (short)1176436736;
				if (num != 0)
				{
				}
				num = (short)6553600;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.HiddenStatic;
			}
			set
			{
				short num = (short)60604095;
				short num2 = num;
				num = (short)2119220927;
				switch (num2 == num)
				{
				}
				num = (short)1425866752;
				if (num != 0)
				{
				}
				num = (short)765329409;
				if (num != 0)
				{
				}
				num = (short)1433927680;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.HiddenStatic = value;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x000765EC File Offset: 0x000747EC
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x000766A4 File Offset: 0x000748A4
		internal bool TrkWideRSSIThresholdsRSSIGoodThreshold_A8992_HiddenDynamic
		{
			get
			{
				short num = (short)1407728239;
				short num2 = num;
				num = (short)886061679;
				switch (num2 == num)
				{
				}
				num = (short)677117953;
				if (num != 0)
				{
				}
				num = (short)1928855552;
				if (num != 0)
				{
				}
				num = (short)627376128;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.HiddenDynamic;
			}
			set
			{
				short num = (short)1623343505;
				short num2 = num;
				num = (short)890585489;
				switch (num2 == num)
				{
				}
				num = (short)187039745;
				if (num != 0)
				{
				}
				num = (short)1959919616;
				if (num != 0)
				{
				}
				num = (short)1752563712;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992.HiddenDynamic = value;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x0007675C File Offset: 0x0007495C
		public bool TrkWideRSSIThresholdsRSSIGoodThreshold_A8992_HasDiffs
		{
			get
			{
				short num = (short)348379453;
				short num2 = num;
				num = (short)1650252093;
				switch (num2 == num)
				{
				}
				num = (short)1095630848;
				if (num != 0)
				{
				}
				num = (short)53346305;
				if (num != 0)
				{
				}
				num = (short)495845376;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIGoodThreshold_A8992._HasDiffs;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x00076814 File Offset: 0x00074A14
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x000768C4 File Offset: 0x00074AC4
		public int TrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996Value
		{
			get
			{
				short num = (short)69398164;
				short num2 = num;
				num = (short)2110254740;
				switch (num2 == num)
				{
				}
				num = (short)429129729;
				if (num != 0)
				{
				}
				num = (short)1783627776;
				if (num != 0)
				{
				}
				num = (short)1075773440;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.Value;
			}
			set
			{
				short num = (short)1812242263;
				short num2 = num;
				num = (short)216899415;
				switch (num2 == num)
				{
				}
				num = (short)315621377;
				if (num != 0)
				{
				}
				num = (short)1341521920;
				if (num != 0)
				{
				}
				num = (short)510722048;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.Value = value;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x00076978 File Offset: 0x00074B78
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996
		{
			get
			{
				short num = (short)132837008;
				short num2 = num;
				num = (short)998043280;
				switch (num2 == num)
				{
				}
				num = (short)1437859840;
				if (num != 0)
				{
				}
				num = (short)598999041;
				if (num != 0)
				{
				}
				num = (short)68747264;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x00076A28 File Offset: 0x00074C28
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x00076ADC File Offset: 0x00074CDC
		public string TrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996_UIValue
		{
			get
			{
				short num = (short)1068953806;
				short num2 = num;
				num = (short)486011086;
				switch (num2 == num)
				{
				}
				num = (short)983826433;
				if (num != 0)
				{
				}
				num = (short)2032271360;
				if (num != 0)
				{
				}
				num = (short)1237778432;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.UIValue;
			}
			set
			{
				short num = (short)1778930512;
				short num2 = num;
				num = (short)1067668304;
				switch (num2 == num)
				{
				}
				num = (short)1695481857;
				if (num != 0)
				{
				}
				num = (short)1574502400;
				if (num != 0)
				{
				}
				num = (short)928972800;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.UIValue = value;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x00076B94 File Offset: 0x00074D94
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x00076C4C File Offset: 0x00074E4C
		public string TrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996_HexUIValue
		{
			get
			{
				short num = (short)167116801;
				if (num != 0)
				{
				}
				num = (short)129491438;
				short num2 = num;
				num = (short)2058609134;
				switch (num2 == num)
				{
				}
				num = (short)534052864;
				if (num != 0)
				{
				}
				num = (short)1284833280;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.HexUIValue;
			}
			set
			{
				short num = (short)1732837377;
				if (num != 0)
				{
				}
				num = (short)1580723654;
				short num2 = num;
				num = (short)201715142;
				switch (num2 == num)
				{
				}
				num = (short)1479147520;
				if (num != 0)
				{
				}
				num = (short)1491795968;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.HexUIValue = value;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00076D00 File Offset: 0x00074F00
		// (set) Token: 0x0600079B RID: 1947 RVA: 0x00076DB4 File Offset: 0x00074FB4
		internal int TrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996Min
		{
			get
			{
				short num = (short)2095172055;
				short num2 = num;
				num = (short)234080727;
				switch (num2 == num)
				{
				}
				num = (short)1614872576;
				if (num != 0)
				{
				}
				num = (short)96075777;
				if (num != 0)
				{
				}
				num = (short)1394671616;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.Min;
			}
			set
			{
				short num = (short)883294209;
				if (num != 0)
				{
				}
				num = (short)1222037708;
				short num2 = num;
				num = (short)1628360908;
				switch (num2 == num)
				{
				}
				num = (short)70844416;
				if (num != 0)
				{
				}
				num = (short)570884096;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.Min = value;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x00076E68 File Offset: 0x00075068
		// (set) Token: 0x0600079D RID: 1949 RVA: 0x00076F1C File Offset: 0x0007511C
		internal int TrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996Max
		{
			get
			{
				short num = (short)881161715;
				short num2 = num;
				num = (short)363361779;
				switch (num2 == num)
				{
				}
				num = (short)1383071745;
				if (num != 0)
				{
				}
				num = (short)1627783168;
				if (num != 0)
				{
				}
				num = (short)127139840;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.Max;
			}
			set
			{
				short num = (short)2039939073;
				if (num != 0)
				{
				}
				num = (short)499390731;
				short num2 = num;
				num = (short)763762955;
				switch (num2 == num)
				{
				}
				num = (short)1428881408;
				if (num != 0)
				{
				}
				num = (short)1833369600;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.Max = value;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x00076FD4 File Offset: 0x000751D4
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x00077088 File Offset: 0x00075288
		internal int TrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996Step
		{
			get
			{
				short num = (short)1895849555;
				short num2 = num;
				num = (short)455237203;
				switch (num2 == num)
				{
				}
				num = (short)1551433729;
				if (num != 0)
				{
				}
				num = (short)1733296128;
				if (num != 0)
				{
				}
				num = (short)2057764864;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.StepSize;
			}
			set
			{
				short num = (short)441061270;
				short num2 = num;
				num = (short)437653398;
				switch (num2 == num)
				{
				}
				num = (short)86376449;
				if (num != 0)
				{
				}
				num = (short)917241856;
				if (num != 0)
				{
				}
				num = (short)83427328;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.StepSize = value;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x0007713C File Offset: 0x0007533C
		// (set) Token: 0x060007A1 RID: 1953 RVA: 0x000771F0 File Offset: 0x000753F0
		public bool TrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996_Applicable
		{
			get
			{
				short num = (short)360781089;
				short num2 = num;
				num = (short)376902945;
				switch (num2 == num)
				{
				}
				num = (short)731774976;
				if (num != 0)
				{
				}
				num = (short)69074945;
				if (num != 0)
				{
				}
				num = (short)2089156608;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.Applicable;
			}
			set
			{
				short num = (short)1445208468;
				short num2 = num;
				num = (short)1366434196;
				switch (num2 == num)
				{
				}
				num = (short)1367408641;
				if (num != 0)
				{
				}
				num = (short)864419840;
				if (num != 0)
				{
				}
				num = (short)1230241792;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.Applicable = value;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x000772A4 File Offset: 0x000754A4
		// (set) Token: 0x060007A3 RID: 1955 RVA: 0x00077358 File Offset: 0x00075558
		public bool TrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996_Valid
		{
			get
			{
				short num = (short)1977465430;
				short num2 = num;
				num = (short)1195686486;
				switch (num2 == num)
				{
				}
				num = (short)1610153984;
				if (num != 0)
				{
				}
				num = (short)1331494913;
				if (num != 0)
				{
				}
				num = (short)597360640;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.Valid;
			}
			set
			{
				short num = (short)1406062108;
				short num2 = num;
				num = (short)27708956;
				switch (num2 == num)
				{
				}
				num = (short)608436225;
				if (num != 0)
				{
				}
				num = (short)1689387008;
				if (num != 0)
				{
				}
				num = (short)1685192704;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.Valid = value;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x0007740C File Offset: 0x0007560C
		// (set) Token: 0x060007A5 RID: 1957 RVA: 0x000774C8 File Offset: 0x000756C8
		public bool TrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996_Visible
		{
			get
			{
				short num = (short)560296148;
				short num2 = num;
				num = (short)224424148;
				switch (num2 == num)
				{
				}
				num = (short)491716609;
				if (num != 0)
				{
				}
				num = (short)2006515712;
				if (num != 0)
				{
				}
				num = (short)1081802752;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.Visible;
			}
			set
			{
				short num = (short)143837595;
				short num2 = num;
				num = (short)740608411;
				switch (num2 == num)
				{
				}
				num = (short)1658060800;
				if (num != 0)
				{
				}
				num = (short)2077360129;
				if (num != 0)
				{
				}
				num = (short)299630592;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.Visible = value;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x00077580 File Offset: 0x00075780
		// (set) Token: 0x060007A7 RID: 1959 RVA: 0x00077634 File Offset: 0x00075834
		public bool TrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996_Editable
		{
			get
			{
				short num = (short)3229552;
				short num2 = num;
				num = (short)1483949936;
				switch (num2 == num)
				{
				}
				num = (short)1617559553;
				if (num != 0)
				{
				}
				num = (short)236060672;
				if (num != 0)
				{
				}
				num = (short)1185284096;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.Editable;
			}
			set
			{
				short num = (short)2116549841;
				short num2 = num;
				num = (short)893123793;
				switch (num2 == num)
				{
				}
				num = (short)1751908353;
				if (num != 0)
				{
				}
				num = (short)430571520;
				if (num != 0)
				{
				}
				num = (short)135856128;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.Editable = value;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x060007A8 RID: 1960 RVA: 0x000776EC File Offset: 0x000758EC
		internal string TrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996_UILabel
		{
			get
			{
				short num = (short)1635753332;
				short num2 = num;
				num = (short)1609342324;
				switch (num2 == num)
				{
				}
				num = (short)986185729;
				if (num != 0)
				{
				}
				num = (short)2096365568;
				if (num != 0)
				{
				}
				num = (short)2065432576;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.UIName;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x000777A0 File Offset: 0x000759A0
		// (set) Token: 0x060007AA RID: 1962 RVA: 0x00077854 File Offset: 0x00075A54
		internal bool TrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996_HiddenStatic
		{
			get
			{
				short num = (short)1005511309;
				short num2 = num;
				num = (short)898556557;
				switch (num2 == num)
				{
				}
				num = (short)201129984;
				if (num != 0)
				{
				}
				num = (short)1036648449;
				if (num != 0)
				{
				}
				num = (short)1377239040;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.HiddenStatic;
			}
			set
			{
				short num = (short)695778920;
				short num2 = num;
				num = (short)322485864;
				switch (num2 == num)
				{
				}
				num = (short)215154689;
				if (num != 0)
				{
				}
				num = (short)858128384;
				if (num != 0)
				{
				}
				num = (short)2024538112;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.HiddenStatic = value;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x0007790C File Offset: 0x00075B0C
		// (set) Token: 0x060007AC RID: 1964 RVA: 0x000779C0 File Offset: 0x00075BC0
		internal bool TrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996_HiddenDynamic
		{
			get
			{
				short num = (short)1290853287;
				short num2 = num;
				num = (short)465820583;
				switch (num2 == num)
				{
				}
				num = (short)1480851456;
				if (num != 0)
				{
				}
				num = (short)1326448641;
				if (num != 0)
				{
				}
				num = (short)542769152;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.HiddenDynamic;
			}
			set
			{
				short num = (short)1042550255;
				short num2 = num;
				num = (short)452070895;
				switch (num2 == num)
				{
				}
				num = (short)1282932737;
				if (num != 0)
				{
				}
				num = (short)69140480;
				if (num != 0)
				{
				}
				num = (short)1341259776;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996.HiddenDynamic = value;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060007AD RID: 1965 RVA: 0x00077A74 File Offset: 0x00075C74
		public bool TrkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996_HasDiffs
		{
			get
			{
				short num = (short)1028617076;
				short num2 = num;
				num = (short)178877300;
				switch (num2 == num)
				{
				}
				num = (short)1577451521;
				if (num != 0)
				{
				}
				num = (short)849936384;
				if (num != 0)
				{
				}
				num = (short)1451884544;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996._HasDiffs;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x00077B2C File Offset: 0x00075D2C
		// (set) Token: 0x060007AF RID: 1967 RVA: 0x00077BE0 File Offset: 0x00075DE0
		public bool TrkWideRSSIThresholdsStrongSignalRoaming_A24630Value
		{
			get
			{
				short num = (short)123171084;
				short num2 = num;
				num = (short)1463841036;
				switch (num2 == num)
				{
				}
				num = (short)219414528;
				if (num != 0)
				{
				}
				num = (short)1356136449;
				if (num != 0)
				{
				}
				num = (short)38993920;
				short num3 = num;
				return this.trkWideRSSIThresholdsStrongSignalRoaming_A24630.Value;
			}
			set
			{
				short num = (short)1623299752;
				short num2 = num;
				num = (short)1020368552;
				switch (num2 == num)
				{
				}
				num = (short)1835663361;
				if (num != 0)
				{
				}
				num = (short)781582336;
				if (num != 0)
				{
				}
				num = (short)2063597568;
				short num3 = num;
				this.trkWideRSSIThresholdsStrongSignalRoaming_A24630.Value = value;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x00077C94 File Offset: 0x00075E94
		public global::AcpBusinessLayer.AcpField<bool> TrkWideRSSIThresholdsStrongSignalRoaming_A24630
		{
			get
			{
				short num = (short)479643752;
				short num2 = num;
				num = (short)1387317352;
				switch (num2 == num)
				{
				}
				num = (short)700121088;
				if (num != 0)
				{
				}
				num = (short)985661441;
				if (num != 0)
				{
				}
				num = (short)362807296;
				short num3 = num;
				return this.trkWideRSSIThresholdsStrongSignalRoaming_A24630;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x00077D40 File Offset: 0x00075F40
		// (set) Token: 0x060007B2 RID: 1970 RVA: 0x00077DF8 File Offset: 0x00075FF8
		public bool TrkWideRSSIThresholdsStrongSignalRoaming_A24630_UIValue
		{
			get
			{
				short num = (short)1614119379;
				short num2 = num;
				num = (short)108167635;
				switch (num2 == num)
				{
				}
				num = (short)170852352;
				if (num != 0)
				{
				}
				num = (short)767950849;
				if (num != 0)
				{
				}
				num = (short)1318518784;
				short num3 = num;
				return this.trkWideRSSIThresholdsStrongSignalRoaming_A24630.Value;
			}
			set
			{
				short num = (short)442553916;
				short num2 = num;
				num = (short)783930940;
				switch (num2 == num)
				{
				}
				num = (short)431489025;
				if (num != 0)
				{
				}
				num = (short)2049441792;
				if (num != 0)
				{
				}
				num = (short)2005139456;
				short num3 = num;
				this.trkWideRSSIThresholdsStrongSignalRoaming_A24630.Value = value;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x00077EB0 File Offset: 0x000760B0
		// (set) Token: 0x060007B4 RID: 1972 RVA: 0x00077F64 File Offset: 0x00076164
		public bool TrkWideRSSIThresholdsStrongSignalRoaming_A24630_Applicable
		{
			get
			{
				short num = (short)1339346852;
				short num2 = num;
				num = (short)1409863588;
				switch (num2 == num)
				{
				}
				num = (short)1282801664;
				if (num != 0)
				{
				}
				num = (short)285933569;
				if (num != 0)
				{
				}
				num = (short)1251868672;
				short num3 = num;
				return this.trkWideRSSIThresholdsStrongSignalRoaming_A24630.Applicable;
			}
			set
			{
				short num = (short)499223742;
				short num2 = num;
				num = (short)1956547774;
				switch (num2 == num)
				{
				}
				num = (short)354877441;
				if (num != 0)
				{
				}
				num = (short)150142976;
				if (num != 0)
				{
				}
				num = (short)220921856;
				short num3 = num;
				this.trkWideRSSIThresholdsStrongSignalRoaming_A24630.Applicable = value;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x00078018 File Offset: 0x00076218
		// (set) Token: 0x060007B6 RID: 1974 RVA: 0x000780D0 File Offset: 0x000762D0
		public bool TrkWideRSSIThresholdsStrongSignalRoaming_A24630_Valid
		{
			get
			{
				short num = (short)1870735112;
				short num2 = num;
				num = (short)356329224;
				switch (num2 == num)
				{
				}
				num = (short)1670184961;
				if (num != 0)
				{
				}
				num = (short)1200029696;
				if (num != 0)
				{
				}
				num = (short)2093416448;
				short num3 = num;
				return this.trkWideRSSIThresholdsStrongSignalRoaming_A24630.Valid;
			}
			set
			{
				short num = (short)1529332549;
				short num2 = num;
				num = (short)1253950277;
				switch (num2 == num)
				{
				}
				num = (short)1372651521;
				if (num != 0)
				{
				}
				num = (short)511705088;
				if (num != 0)
				{
				}
				num = (short)744685568;
				short num3 = num;
				this.trkWideRSSIThresholdsStrongSignalRoaming_A24630.Valid = value;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x00078184 File Offset: 0x00076384
		// (set) Token: 0x060007B8 RID: 1976 RVA: 0x00078238 File Offset: 0x00076438
		public bool TrkWideRSSIThresholdsStrongSignalRoaming_A24630_Visible
		{
			get
			{
				short num = (short)2079780047;
				short num2 = num;
				num = (short)386002127;
				switch (num2 == num)
				{
				}
				num = (short)857538560;
				if (num != 0)
				{
				}
				num = (short)224657409;
				if (num != 0)
				{
				}
				num = (short)377683968;
				short num3 = num;
				return this.trkWideRSSIThresholdsStrongSignalRoaming_A24630.Visible;
			}
			set
			{
				short num = (short)1447580733;
				short num2 = num;
				num = (short)1000494141;
				switch (num2 == num)
				{
				}
				num = (short)1187250177;
				if (num != 0)
				{
				}
				num = (short)1394278400;
				if (num != 0)
				{
				}
				num = (short)1420492800;
				short num3 = num;
				this.trkWideRSSIThresholdsStrongSignalRoaming_A24630.Visible = value;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x000782EC File Offset: 0x000764EC
		// (set) Token: 0x060007BA RID: 1978 RVA: 0x000783A4 File Offset: 0x000765A4
		public bool TrkWideRSSIThresholdsStrongSignalRoaming_A24630_Editable
		{
			get
			{
				short num = (short)547465482;
				short num2 = num;
				num = (short)1907140874;
				switch (num2 == num)
				{
				}
				num = (short)1685651457;
				if (num != 0)
				{
				}
				num = (short)518193152;
				if (num != 0)
				{
				}
				num = (short)762249216;
				short num3 = num;
				return this.trkWideRSSIThresholdsStrongSignalRoaming_A24630.Editable;
			}
			set
			{
				short num = (short)282593385;
				short num2 = num;
				num = (short)191563881;
				switch (num2 == num)
				{
				}
				num = (short)1163788289;
				if (num != 0)
				{
				}
				num = (short)238616576;
				if (num != 0)
				{
				}
				num = (short)1187577856;
				short num3 = num;
				this.trkWideRSSIThresholdsStrongSignalRoaming_A24630.Editable = value;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x0007845C File Offset: 0x0007665C
		internal string TrkWideRSSIThresholdsStrongSignalRoaming_A24630_UILabel
		{
			get
			{
				short num = (short)374045445;
				short num2 = num;
				num = (short)1306032901;
				switch (num2 == num)
				{
				}
				num = (short)1527382017;
				if (num != 0)
				{
				}
				num = (short)1033109504;
				if (num != 0)
				{
				}
				num = (short)465698816;
				short num3 = num;
				return this.trkWideRSSIThresholdsStrongSignalRoaming_A24630.UIName;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x00078510 File Offset: 0x00076710
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x000785C4 File Offset: 0x000767C4
		internal bool TrkWideRSSIThresholdsStrongSignalRoaming_A24630_HiddenStatic
		{
			get
			{
				short num = (short)887134840;
				short num2 = num;
				num = (short)339188344;
				switch (num2 == num)
				{
				}
				num = (short)110755840;
				if (num != 0)
				{
				}
				num = (short)324403201;
				if (num != 0)
				{
				}
				num = (short)1984757760;
				short num3 = num;
				return this.trkWideRSSIThresholdsStrongSignalRoaming_A24630.HiddenStatic;
			}
			set
			{
				short num = (short)849243890;
				short num2 = num;
				num = (short)106655474;
				switch (num2 == num)
				{
				}
				num = (short)988741633;
				if (num != 0)
				{
				}
				num = (short)1003356160;
				if (num != 0)
				{
				}
				num = (short)1468727296;
				short num3 = num;
				this.trkWideRSSIThresholdsStrongSignalRoaming_A24630.HiddenStatic = value;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x0007867C File Offset: 0x0007687C
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x00078730 File Offset: 0x00076930
		internal bool TrkWideRSSIThresholdsStrongSignalRoaming_A24630_HiddenDynamic
		{
			get
			{
				short num = (short)532766805;
				short num2 = num;
				num = (short)1339908181;
				switch (num2 == num)
				{
				}
				num = (short)1181745153;
				if (num != 0)
				{
				}
				num = (short)1579220992;
				if (num != 0)
				{
				}
				num = (short)893386752;
				short num3 = num;
				return this.trkWideRSSIThresholdsStrongSignalRoaming_A24630.HiddenDynamic;
			}
			set
			{
				short num = (short)1302902997;
				short num2 = num;
				num = (short)1469364437;
				switch (num2 == num)
				{
				}
				num = (short)1758658561;
				if (num != 0)
				{
				}
				num = (short)116523008;
				if (num != 0)
				{
				}
				num = (short)1605763072;
				short num3 = num;
				this.trkWideRSSIThresholdsStrongSignalRoaming_A24630.HiddenDynamic = value;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x000787E4 File Offset: 0x000769E4
		public bool TrkWideRSSIThresholdsStrongSignalRoaming_A24630_HasDiffs
		{
			get
			{
				short num = (short)1695441260;
				short num2 = num;
				num = (short)39674220;
				switch (num2 == num)
				{
				}
				num = (short)1016004609;
				if (num != 0)
				{
				}
				num = (short)1667891200;
				if (num != 0)
				{
				}
				num = (short)1392967680;
				short num3 = num;
				return this.trkWideRSSIThresholdsStrongSignalRoaming_A24630._HasDiffs;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x0007889C File Offset: 0x00076A9C
		// (set) Token: 0x060007C2 RID: 1986 RVA: 0x0007894C File Offset: 0x00076B4C
		public int TrkWideRSSIThresholdsRSSIOSPCounter_A8994Value
		{
			get
			{
				short num = (short)1420890268;
				short num2 = num;
				num = (short)969150620;
				switch (num2 == num)
				{
				}
				num = (short)1231552513;
				if (num != 0)
				{
				}
				num = (short)1790902272;
				if (num != 0)
				{
				}
				num = (short)1136263168;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.Value;
			}
			set
			{
				short num = (short)1175101899;
				short num2 = num;
				num = (short)1246863819;
				switch (num2 == num)
				{
				}
				num = (short)812580864;
				if (num != 0)
				{
				}
				num = (short)1798504449;
				if (num != 0)
				{
				}
				num = (short)1671364608;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.Value = value;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x00078A00 File Offset: 0x00076C00
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideRSSIThresholdsRSSIOSPCounter_A8994
		{
			get
			{
				short num = (short)1084648766;
				short num2 = num;
				num = (short)1698327870;
				switch (num2 == num)
				{
				}
				num = (short)1248395265;
				if (num != 0)
				{
				}
				num = (short)2066677760;
				if (num != 0)
				{
				}
				num = (short)268763136;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIOSPCounter_A8994;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00078AB0 File Offset: 0x00076CB0
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x00078B68 File Offset: 0x00076D68
		public string TrkWideRSSIThresholdsRSSIOSPCounter_A8994_UIValue
		{
			get
			{
				short num = (short)1668488708;
				short num2 = num;
				num = (short)1941904900;
				switch (num2 == num)
				{
				}
				num = (short)1402929152;
				if (num != 0)
				{
				}
				num = (short)521928705;
				if (num != 0)
				{
				}
				num = (short)523042816;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.UIValue;
			}
			set
			{
				short num = (short)1545584327;
				short num2 = num;
				num = (short)1721548487;
				switch (num2 == num)
				{
				}
				num = (short)745144321;
				if (num != 0)
				{
				}
				num = (short)1009385472;
				if (num != 0)
				{
				}
				num = (short)1447362560;
				short num3 = num;
				this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.UIValue = value;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00078C20 File Offset: 0x00076E20
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x00078CD4 File Offset: 0x00076ED4
		internal int TrkWideRSSIThresholdsRSSIOSPCounter_A8994Min
		{
			get
			{
				short num = (short)1531923947;
				short num2 = num;
				num = (short)2139114987;
				switch (num2 == num)
				{
				}
				num = (short)905773056;
				if (num != 0)
				{
				}
				num = (short)287178753;
				if (num != 0)
				{
				}
				num = (short)1884618752;
				short num3 = num;
				return this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.Min;
			}
			set
			{
				short num = (short)347107539;
				short num2 = num;
				num = (short)1147629779;
				switch (num2 == num)
				{
				}
				num = (short)1478164481;
				if (num != 0)
				{
				}
				num = (short)944832512;
				short num3 = num;
				num = (short)313393152;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.Min = value;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x00078D88 File Offset: 0x00076F88
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x00078E3C File Offset: 0x0007703C
		internal int TrkWideRSSIThresholdsRSSIOSPCounter_A8994Max
		{
			get
			{
				short num = (short)4192801;
				short num2 = num;
				num = (short)1476196897;
				switch (num2 == num)
				{
				}
				num = (short)295567361;
				if (num != 0)
				{
				}
				num = (short)1437204480;
				short num3 = num;
				num = (short)163840000;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.Max;
			}
			set
			{
				short num = (short)1407573099;
				short num2 = num;
				num = (short)1267260523;
				switch (num2 == num)
				{
				}
				num = (short)1005977600;
				if (num != 0)
				{
				}
				num = (short)234160128;
				short num3 = num;
				num = (short)228589569;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.Max = value;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x00078EF0 File Offset: 0x000770F0
		// (set) Token: 0x060007CB RID: 1995 RVA: 0x00078FA4 File Offset: 0x000771A4
		internal int TrkWideRSSIThresholdsRSSIOSPCounter_A8994Step
		{
			get
			{
				short num = (short)1204244768;
				short num2 = num;
				num = (short)278155552;
				switch (num2 == num)
				{
				}
				num = (short)351535104;
				if (num != 0)
				{
				}
				num = (short)601096192;
				short num3 = num;
				num = (short)42270721;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.StepSize;
			}
			set
			{
				short num = (short)1564064970;
				short num2 = num;
				num = (short)1887943882;
				switch (num2 == num)
				{
				}
				num = (short)830930945;
				if (num != 0)
				{
				}
				num = (short)1703936000;
				short num3 = num;
				num = (short)1721499648;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.StepSize = value;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x00079058 File Offset: 0x00077258
		// (set) Token: 0x060007CD RID: 1997 RVA: 0x0007910C File Offset: 0x0007730C
		public bool TrkWideRSSIThresholdsRSSIOSPCounter_A8994_Applicable
		{
			get
			{
				short num = (short)727986216;
				short num2 = num;
				num = (short)681455656;
				switch (num2 == num)
				{
				}
				num = (short)530251777;
				if (num != 0)
				{
				}
				num = (short)1195376640;
				short num3 = num;
				num = (short)1363738624;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.Applicable;
			}
			set
			{
				short num = (short)1511003431;
				short num2 = num;
				num = (short)749212967;
				switch (num2 == num)
				{
				}
				num = (short)41811968;
				if (num != 0)
				{
				}
				num = (short)960888832;
				short num3 = num;
				num = (short)602406913;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.Applicable = value;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x000791C4 File Offset: 0x000773C4
		// (set) Token: 0x060007CF RID: 1999 RVA: 0x00079278 File Offset: 0x00077478
		public bool TrkWideRSSIThresholdsRSSIOSPCounter_A8994_Valid
		{
			get
			{
				short num = (short)792068097;
				if (num != 0)
				{
				}
				num = (short)523060577;
				short num2 = num;
				num = (short)565921121;
				switch (num2 == num)
				{
				}
				num = (short)389808128;
				short num3 = num;
				num = (short)544800768;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.Valid;
			}
			set
			{
				short num = (short)1991011962;
				short num2 = num;
				num = (short)2097442426;
				switch (num2 == num)
				{
				}
				num = (short)2052325377;
				if (num != 0)
				{
				}
				num = (short)1951072256;
				short num3 = num;
				num = (short)566493184;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.Valid = value;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x0007932C File Offset: 0x0007752C
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x000793E0 File Offset: 0x000775E0
		public bool TrkWideRSSIThresholdsRSSIOSPCounter_A8994_Visible
		{
			get
			{
				short num = (short)1729526969;
				short num2 = num;
				num = (short)126057657;
				switch (num2 == num)
				{
				}
				num = (short)725614593;
				if (num != 0)
				{
				}
				num = (short)407502848;
				short num3 = num;
				num = (short)276889600;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.Visible;
			}
			set
			{
				short num = (short)1239626542;
				short num2 = num;
				num = (short)1366111022;
				switch (num2 == num)
				{
				}
				num = (short)160301057;
				if (num != 0)
				{
				}
				num = (short)629866496;
				short num3 = num;
				num = (short)2046951424;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.Visible = value;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x00079498 File Offset: 0x00077698
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x0007954C File Offset: 0x0007774C
		public bool TrkWideRSSIThresholdsRSSIOSPCounter_A8994_Editable
		{
			get
			{
				short num = (short)1995311203;
				short num2 = num;
				num = (short)708773987;
				switch (num2 == num)
				{
				}
				num = (short)1393950721;
				if (num != 0)
				{
				}
				num = (short)1643839488;
				short num3 = num;
				num = (short)345112576;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.Editable;
			}
			set
			{
				short num = (short)94958623;
				short num2 = num;
				num = (short)603845663;
				switch (num2 == num)
				{
				}
				num = (short)338886657;
				if (num != 0)
				{
				}
				num = (short)523042816;
				short num3 = num;
				num = (short)737411072;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.Editable = value;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x00079600 File Offset: 0x00077800
		internal string TrkWideRSSIThresholdsRSSIOSPCounter_A8994_UILabel
		{
			get
			{
				short num = (short)1642283726;
				short num2 = num;
				num = (short)2122793678;
				switch (num2 == num)
				{
				}
				num = (short)1277296641;
				if (num != 0)
				{
				}
				num = (short)420216832;
				short num3 = num;
				num = (short)2084896768;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.UIName;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x000796B4 File Offset: 0x000778B4
		// (set) Token: 0x060007D6 RID: 2006 RVA: 0x0007976C File Offset: 0x0007796C
		internal bool TrkWideRSSIThresholdsRSSIOSPCounter_A8994_HiddenStatic
		{
			get
			{
				short num = (short)1957990063;
				short num2 = num;
				num = (short)820219567;
				switch (num2 == num)
				{
				}
				num = (short)46923777;
				if (num != 0)
				{
				}
				num = (short)1217134592;
				short num3 = num;
				num = (short)512950272;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.HiddenStatic;
			}
			set
			{
				short num = (short)505774808;
				short num2 = num;
				num = (short)245203672;
				switch (num2 == num)
				{
				}
				num = (short)508231680;
				if (num != 0)
				{
				}
				num = (short)1150418944;
				short num3 = num;
				num = (short)817627137;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.HiddenStatic = value;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x00079820 File Offset: 0x00077A20
		// (set) Token: 0x060007D8 RID: 2008 RVA: 0x000798D0 File Offset: 0x00077AD0
		internal bool TrkWideRSSIThresholdsRSSIOSPCounter_A8994_HiddenDynamic
		{
			get
			{
				short num = (short)826404377;
				short num2 = num;
				num = (short)1771171353;
				switch (num2 == num)
				{
				}
				num = (short)1589837825;
				if (num != 0)
				{
				}
				num = (short)813367296;
				short num3 = num;
				num = (short)811139072;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.HiddenDynamic;
			}
			set
			{
				short num = (short)272326223;
				short num2 = num;
				num = (short)1338793551;
				switch (num2 == num)
				{
				}
				num = (short)405405696;
				if (num != 0)
				{
				}
				num = (short)705101824;
				short num3 = num;
				num = (short)1123352577;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIOSPCounter_A8994.HiddenDynamic = value;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x00079984 File Offset: 0x00077B84
		public bool TrkWideRSSIThresholdsRSSIOSPCounter_A8994_HasDiffs
		{
			get
			{
				short num = (short)1085603841;
				if (num != 0)
				{
				}
				num = (short)1853083014;
				short num2 = num;
				num = (short)2108411270;
				switch (num2 == num)
				{
				}
				num = (short)1334050816;
				short num3 = num;
				num = (short)1282473984;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIOSPCounter_A8994._HasDiffs;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x00079A3C File Offset: 0x00077C3C
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x00079AF0 File Offset: 0x00077CF0
		public int TrkWideRSSIThresholdsRSSIOSWCounter_A8995Value
		{
			get
			{
				short num = (short)1690663390;
				short num2 = num;
				num = (short)1057716702;
				switch (num2 == num)
				{
				}
				num = (short)473038849;
				if (num != 0)
				{
				}
				num = (short)1772158976;
				short num3 = num;
				num = (short)1840185344;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.Value;
			}
			set
			{
				short num = (short)1457899466;
				short num2 = num;
				num = (short)1147914186;
				switch (num2 == num)
				{
				}
				num = (short)2097676288;
				if (num != 0)
				{
				}
				num = (short)587726848;
				short num3 = num;
				num = (short)1863712769;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.Value = value;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x00079BA8 File Offset: 0x00077DA8
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideRSSIThresholdsRSSIOSWCounter_A8995
		{
			get
			{
				short num = (short)964018482;
				short num2 = num;
				num = (short)245023026;
				switch (num2 == num)
				{
				}
				num = (short)447414273;
				if (num != 0)
				{
				}
				num = (short)1695416320;
				short num3 = num;
				num = (short)1712914432;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIOSWCounter_A8995;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x00079C58 File Offset: 0x00077E58
		// (set) Token: 0x060007DE RID: 2014 RVA: 0x00079D0C File Offset: 0x00077F0C
		public string TrkWideRSSIThresholdsRSSIOSWCounter_A8995_UIValue
		{
			get
			{
				short num = (short)559205483;
				short num2 = num;
				num = (short)106679403;
				switch (num2 == num)
				{
				}
				num = (short)1407516672;
				if (num != 0)
				{
				}
				num = (short)790626304;
				short num3 = num;
				num = (short)899284993;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.UIValue;
			}
			set
			{
				short num = (short)1641439832;
				short num2 = num;
				num = (short)501113432;
				switch (num2 == num)
				{
				}
				num = (short)1910702081;
				if (num != 0)
				{
				}
				num = (short)1918763008;
				short num3 = num;
				num = (short)1063518208;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.UIValue = value;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x00079DC0 File Offset: 0x00077FC0
		// (set) Token: 0x060007E0 RID: 2016 RVA: 0x00079E74 File Offset: 0x00078074
		internal int TrkWideRSSIThresholdsRSSIOSWCounter_A8995Min
		{
			get
			{
				short num = (short)246689410;
				short num2 = num;
				num = (short)2029465218;
				switch (num2 == num)
				{
				}
				num = (short)277020672;
				if (num != 0)
				{
				}
				num = (short)583335936;
				short num3 = num;
				num = (short)849477633;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.Min;
			}
			set
			{
				short num = (short)828277303;
				short num2 = num;
				num = (short)1640727095;
				switch (num2 == num)
				{
				}
				num = (short)1155727361;
				if (num != 0)
				{
				}
				num = (short)219152384;
				short num3 = num;
				num = (short)543817728;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.Min = value;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x00079F2C File Offset: 0x0007812C
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x00079FE0 File Offset: 0x000781E0
		internal int TrkWideRSSIThresholdsRSSIOSWCounter_A8995Max
		{
			get
			{
				short num = (short)393676178;
				short num2 = num;
				num = (short)667026834;
				switch (num2 == num)
				{
				}
				num = (short)1348009984;
				if (num != 0)
				{
				}
				num = (short)367263744;
				short num3 = num;
				num = (short)256311297;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.Max;
			}
			set
			{
				short num = (short)928348730;
				short num2 = num;
				num = (short)1761704506;
				switch (num2 == num)
				{
				}
				num = (short)1844903937;
				if (num != 0)
				{
				}
				num = (short)977600512;
				short num3 = num;
				num = (short)313393152;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.Max = value;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x0007A098 File Offset: 0x00078298
		// (set) Token: 0x060007E4 RID: 2020 RVA: 0x0007A150 File Offset: 0x00078350
		internal int TrkWideRSSIThresholdsRSSIOSWCounter_A8995Step
		{
			get
			{
				short num = (short)307101010;
				short num2 = num;
				num = (short)1573649746;
				switch (num2 == num)
				{
				}
				num = (short)534315008;
				if (num != 0)
				{
				}
				num = (short)2059337728;
				short num3 = num;
				num = (short)328663041;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.StepSize;
			}
			set
			{
				short num = (short)419156393;
				short num2 = num;
				num = (short)683463081;
				switch (num2 == num)
				{
				}
				num = (short)1950941185;
				if (num != 0)
				{
				}
				num = (short)583270400;
				short num3 = num;
				num = (short)804323328;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.StepSize = value;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x0007A204 File Offset: 0x00078404
		// (set) Token: 0x060007E6 RID: 2022 RVA: 0x0007A2B8 File Offset: 0x000784B8
		public bool TrkWideRSSIThresholdsRSSIOSWCounter_A8995_Applicable
		{
			get
			{
				short num = (short)309068749;
				short num2 = num;
				num = (short)847578061;
				switch (num2 == num)
				{
				}
				num = (short)1964310529;
				if (num != 0)
				{
				}
				num = (short)579010560;
				short num3 = num;
				num = (short)1577844736;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.Applicable;
			}
			set
			{
				short num = (short)810776739;
				short num2 = num;
				num = (short)1640003747;
				switch (num2 == num)
				{
				}
				num = (short)1684668417;
				if (num != 0)
				{
				}
				num = (short)604045312;
				short num3 = num;
				num = (short)957349888;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.Applicable = value;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x0007A36C File Offset: 0x0007856C
		// (set) Token: 0x060007E8 RID: 2024 RVA: 0x0007A420 File Offset: 0x00078620
		public bool TrkWideRSSIThresholdsRSSIOSWCounter_A8995_Valid
		{
			get
			{
				short num = (short)1009256865;
				short num2 = num;
				num = (short)607259041;
				switch (num2 == num)
				{
				}
				num = (short)655753217;
				if (num != 0)
				{
				}
				num = (short)2949120;
				short num3 = num;
				num = (short)1713897472;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.Valid;
			}
			set
			{
				short num = (short)1706898408;
				short num2 = num;
				num = (short)1506620392;
				switch (num2 == num)
				{
				}
				num = (short)2132541440;
				if (num != 0)
				{
				}
				num = (short)640024576;
				short num3 = num;
				num = (short)2116288513;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.Valid = value;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x0007A4D8 File Offset: 0x000786D8
		// (set) Token: 0x060007EA RID: 2026 RVA: 0x0007A58C File Offset: 0x0007878C
		public bool TrkWideRSSIThresholdsRSSIOSWCounter_A8995_Visible
		{
			get
			{
				short num = (short)1443587432;
				short num2 = num;
				num = (short)31417704;
				switch (num2 == num)
				{
				}
				num = (short)1074462720;
				if (num != 0)
				{
				}
				num = (short)1806237696;
				short num3 = num;
				num = (short)1561198593;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.Visible;
			}
			set
			{
				short num = (short)365417859;
				short num2 = num;
				num = (short)1347409283;
				switch (num2 == num)
				{
				}
				num = (short)1784020993;
				if (num != 0)
				{
				}
				num = (short)424869888;
				short num3 = num;
				num = (short)791019520;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.Visible = value;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x0007A644 File Offset: 0x00078844
		// (set) Token: 0x060007EC RID: 2028 RVA: 0x0007A6F8 File Offset: 0x000788F8
		public bool TrkWideRSSIThresholdsRSSIOSWCounter_A8995_Editable
		{
			get
			{
				short num = (short)859025490;
				short num2 = num;
				num = (short)1953345618;
				switch (num2 == num)
				{
				}
				num = (short)1953693696;
				if (num != 0)
				{
				}
				num = (short)203227136;
				short num3 = num;
				num = (short)504168449;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.Editable;
			}
			set
			{
				short num = (short)1832506856;
				short num2 = num;
				num = (short)1223480808;
				switch (num2 == num)
				{
				}
				num = (short)530644993;
				if (num != 0)
				{
				}
				num = (short)916062208;
				short num3 = num;
				num = (short)331087872;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.Editable = value;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x0007A7AC File Offset: 0x000789AC
		internal string TrkWideRSSIThresholdsRSSIOSWCounter_A8995_UILabel
		{
			get
			{
				short num = (short)949225083;
				short num2 = num;
				num = (short)1217988219;
				switch (num2 == num)
				{
				}
				num = (short)1113522176;
				if (num != 0)
				{
				}
				num = (short)2020868096;
				short num3 = num;
				num = (short)784596993;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.UIName;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x0007A860 File Offset: 0x00078A60
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x0007A910 File Offset: 0x00078B10
		internal bool TrkWideRSSIThresholdsRSSIOSWCounter_A8995_HiddenStatic
		{
			get
			{
				short num = (short)915586215;
				short num2 = num;
				num = (short)1180679335;
				switch (num2 == num)
				{
				}
				num = (short)2129526785;
				if (num != 0)
				{
				}
				num = (short)101974016;
				short num3 = num;
				num = (short)404226048;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.HiddenStatic;
			}
			set
			{
				short num = (short)1276722966;
				short num2 = num;
				num = (short)942817046;
				switch (num2 == num)
				{
				}
				num = (short)963706881;
				if (num != 0)
				{
				}
				num = (short)248446976;
				short num3 = num;
				num = (short)1756430336;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.HiddenStatic = value;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x0007A9C4 File Offset: 0x00078BC4
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x0007AA78 File Offset: 0x00078C78
		internal bool TrkWideRSSIThresholdsRSSIOSWCounter_A8995_HiddenDynamic
		{
			get
			{
				short num = (short)874537897;
				short num2 = num;
				num = (short)59466665;
				switch (num2 == num)
				{
				}
				num = (short)71827457;
				if (num != 0)
				{
				}
				num = (short)462880768;
				short num3 = num;
				num = (short)2135162880;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.HiddenDynamic;
			}
			set
			{
				short num = (short)425302511;
				short num2 = num;
				num = (short)1411226095;
				switch (num2 == num)
				{
				}
				num = (short)635305984;
				if (num != 0)
				{
				}
				num = (short)527368192;
				short num3 = num;
				num = (short)841875457;
				if (num != 0)
				{
				}
				this.trkWideRSSIThresholdsRSSIOSWCounter_A8995.HiddenDynamic = value;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x0007AB2C File Offset: 0x00078D2C
		public bool TrkWideRSSIThresholdsRSSIOSWCounter_A8995_HasDiffs
		{
			get
			{
				short num = (short)1639382603;
				short num2 = num;
				num = (short)1599274571;
				switch (num2 == num)
				{
				}
				num = (short)889520129;
				if (num != 0)
				{
				}
				num = (short)2042953728;
				short num3 = num;
				num = (short)918945792;
				if (num != 0)
				{
				}
				return this.trkWideRSSIThresholdsRSSIOSWCounter_A8995._HasDiffs;
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x0007ABE0 File Offset: 0x00078DE0
		// (set) Token: 0x060007F4 RID: 2036 RVA: 0x0007AC98 File Offset: 0x00078E98
		public int TrkWideRSSIBackupPTTFallbackThreshold_A43626Value
		{
			get
			{
				short num = (short)515729226;
				short num2 = num;
				num = (short)1497589578;
				switch (num2 == num)
				{
				}
				num = (short)25886721;
				if (num != 0)
				{
				}
				num = (short)1275265024;
				short num3 = num;
				num = (short)1019805696;
				if (num != 0)
				{
				}
				return this.trkWideRSSIBackupPTTFallbackThreshold_A43626.Value;
			}
			set
			{
				short num = (short)1939367566;
				short num2 = num;
				num = (short)1811834510;
				switch (num2 == num)
				{
				}
				num = (short)434241537;
				if (num != 0)
				{
				}
				num = (short)1153368064;
				short num3 = num;
				num = (short)1145110528;
				if (num != 0)
				{
				}
				this.trkWideRSSIBackupPTTFallbackThreshold_A43626.Value = value;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x0007AD50 File Offset: 0x00078F50
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideRSSIBackupPTTFallbackThreshold_A43626
		{
			get
			{
				short num = (short)1556311094;
				short num2 = num;
				num = (short)1629187126;
				switch (num2 == num)
				{
				}
				num = (short)825032705;
				if (num != 0)
				{
				}
				num = (short)1910308864;
				short num3 = num;
				num = (short)266010624;
				if (num != 0)
				{
				}
				return this.trkWideRSSIBackupPTTFallbackThreshold_A43626;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x0007ADFC File Offset: 0x00078FFC
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x0007AEB0 File Offset: 0x000790B0
		public string TrkWideRSSIBackupPTTFallbackThreshold_A43626_UIValue
		{
			get
			{
				short num = (short)632780294;
				short num2 = num;
				num = (short)1826059782;
				switch (num2 == num)
				{
				}
				num = (short)340393984;
				if (num != 0)
				{
				}
				num = (short)996605952;
				short num3 = num;
				num = (short)1519321089;
				if (num != 0)
				{
				}
				return this.trkWideRSSIBackupPTTFallbackThreshold_A43626.UIValue;
			}
			set
			{
				short num = (short)274256573;
				short num2 = num;
				num = (short)67424957;
				switch (num2 == num)
				{
				}
				num = (short)254345217;
				if (num != 0)
				{
				}
				num = (short)447807488;
				short num3 = num;
				num = (short)278659072;
				if (num != 0)
				{
				}
				this.trkWideRSSIBackupPTTFallbackThreshold_A43626.UIValue = value;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x0007AF64 File Offset: 0x00079164
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x0007B018 File Offset: 0x00079218
		public string TrkWideRSSIBackupPTTFallbackThreshold_A43626_HexUIValue
		{
			get
			{
				short num = (short)1953861060;
				short num2 = num;
				num = (short)710643140;
				switch (num2 == num)
				{
				}
				num = (short)815661057;
				if (num != 0)
				{
				}
				num = (short)449511424;
				short num3 = num;
				num = (short)23527424;
				if (num != 0)
				{
				}
				return this.trkWideRSSIBackupPTTFallbackThreshold_A43626.HexUIValue;
			}
			set
			{
				short num = (short)1106621362;
				short num2 = num;
				num = (short)80130994;
				switch (num2 == num)
				{
				}
				num = (short)849805313;
				if (num != 0)
				{
				}
				num = (short)1900871680;
				short num3 = num;
				num = (short)1595801600;
				if (num != 0)
				{
				}
				this.trkWideRSSIBackupPTTFallbackThreshold_A43626.HexUIValue = value;
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x0007B0D0 File Offset: 0x000792D0
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x0007B188 File Offset: 0x00079388
		internal int TrkWideRSSIBackupPTTFallbackThreshold_A43626Min
		{
			get
			{
				short num = (short)768741103;
				short num2 = num;
				num = (short)1368198895;
				switch (num2 == num)
				{
				}
				num = (short)2052128769;
				if (num != 0)
				{
				}
				num = (short)345243648;
				short num3 = num;
				num = (short)885587968;
				if (num != 0)
				{
				}
				return this.trkWideRSSIBackupPTTFallbackThreshold_A43626.Min;
			}
			set
			{
				short num = (short)1126649982;
				short num2 = num;
				num = (short)2056802430;
				switch (num2 == num)
				{
				}
				num = (short)691011584;
				if (num != 0)
				{
				}
				num = (short)1701838848;
				short num3 = num;
				num = (short)2126053377;
				if (num != 0)
				{
				}
				this.trkWideRSSIBackupPTTFallbackThreshold_A43626.Min = value;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x0007B23C File Offset: 0x0007943C
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x0007B2F4 File Offset: 0x000794F4
		internal int TrkWideRSSIBackupPTTFallbackThreshold_A43626Max
		{
			get
			{
				short num = (short)1404847336;
				short num2 = num;
				num = (short)355681512;
				switch (num2 == num)
				{
				}
				num = (short)310312961;
				if (num != 0)
				{
				}
				num = (short)562561024;
				short num3 = num;
				num = (short)1564409856;
				if (num != 0)
				{
				}
				return this.trkWideRSSIBackupPTTFallbackThreshold_A43626.Max;
			}
			set
			{
				short num = (short)2007467552;
				short num2 = num;
				num = (short)215778848;
				switch (num2 == num)
				{
				}
				num = (short)4587520;
				if (num != 0)
				{
				}
				num = (short)255918080;
				short num3 = num;
				num = (short)171573249;
				if (num != 0)
				{
				}
				this.trkWideRSSIBackupPTTFallbackThreshold_A43626.Max = value;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x0007B3AC File Offset: 0x000795AC
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x0007B464 File Offset: 0x00079664
		internal int TrkWideRSSIBackupPTTFallbackThreshold_A43626Step
		{
			get
			{
				short num = (short)704229281;
				short num2 = num;
				num = (short)594128801;
				switch (num2 == num)
				{
				}
				num = (short)1128071169;
				if (num != 0)
				{
				}
				num = (short)1100742656;
				short num3 = num;
				num = (short)1605107712;
				if (num != 0)
				{
				}
				return this.trkWideRSSIBackupPTTFallbackThreshold_A43626.StepSize;
			}
			set
			{
				short num = (short)1969827254;
				short num2 = num;
				num = (short)1096297910;
				switch (num2 == num)
				{
				}
				num = (short)1738539009;
				if (num != 0)
				{
				}
				num = (short)624558080;
				short num3 = num;
				num = (short)296878080;
				if (num != 0)
				{
				}
				this.trkWideRSSIBackupPTTFallbackThreshold_A43626.StepSize = value;
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x0007B51C File Offset: 0x0007971C
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x0007B5D0 File Offset: 0x000797D0
		public bool TrkWideRSSIBackupPTTFallbackThreshold_A43626_Applicable
		{
			get
			{
				short num = (short)1018919442;
				short num2 = num;
				num = (short)631732754;
				switch (num2 == num)
				{
				}
				num = (short)1740570625;
				if (num != 0)
				{
				}
				num = (short)142737408;
				short num3 = num;
				num = (short)1711276032;
				if (num != 0)
				{
				}
				return this.trkWideRSSIBackupPTTFallbackThreshold_A43626.Applicable;
			}
			set
			{
				short num = (short)510590977;
				if (num != 0)
				{
				}
				num = (short)1744118430;
				short num2 = num;
				num = (short)1451762334;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1271398400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1318322176;
				if (num != 0)
				{
				}
				this.trkWideRSSIBackupPTTFallbackThreshold_A43626.Applicable = value;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x0007B684 File Offset: 0x00079884
		// (set) Token: 0x06000803 RID: 2051 RVA: 0x0007B738 File Offset: 0x00079938
		public bool TrkWideRSSIBackupPTTFallbackThreshold_A43626_Valid
		{
			get
			{
				short num = (short)1826503314;
				short num2 = num;
				num = (short)879311506;
				switch (num2 == num)
				{
				}
				num = (short)881524736;
				short num3 = num;
				num = (short)118947840;
				if (num != 0)
				{
				}
				num = (short)1586561025;
				if (num != 0)
				{
				}
				return this.trkWideRSSIBackupPTTFallbackThreshold_A43626.Valid;
			}
			set
			{
				short num = (short)618474133;
				short num2 = num;
				num = (short)1452681877;
				switch (num2 == num)
				{
				}
				num = (short)1408303104;
				short num3 = num;
				num = (short)1622212609;
				if (num != 0)
				{
				}
				num = (short)1054343168;
				if (num != 0)
				{
				}
				this.trkWideRSSIBackupPTTFallbackThreshold_A43626.Valid = value;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x0007B7F0 File Offset: 0x000799F0
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x0007B8A4 File Offset: 0x00079AA4
		public bool TrkWideRSSIBackupPTTFallbackThreshold_A43626_Visible
		{
			get
			{
				short num = (short)2145583105;
				if (num != 0)
				{
				}
				num = (short)1156750061;
				short num2 = num;
				num = (short)998349549;
				switch (num2 == num)
				{
				default:
				{
					num = (short)989265920;
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
				return this.trkWideRSSIBackupPTTFallbackThreshold_A43626.Visible;
			}
			set
			{
				short num = (short)469827585;
				if (num != 0)
				{
				}
				num = (short)222775310;
				short num2 = num;
				num = (short)1288914958;
				switch (num2 == num)
				{
				default:
				{
					num = (short)426246144;
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
				this.trkWideRSSIBackupPTTFallbackThreshold_A43626.Visible = value;
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x0007B95C File Offset: 0x00079B5C
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x0007BA10 File Offset: 0x00079C10
		public bool TrkWideRSSIBackupPTTFallbackThreshold_A43626_Editable
		{
			get
			{
				short num = (short)1031707856;
				short num2 = num;
				num = (short)983145680;
				switch (num2 == num)
				{
				}
				num = (short)2098593792;
				short num3 = num;
				num = (short)1524629505;
				if (num != 0)
				{
				}
				num = (short)1921843200;
				if (num != 0)
				{
				}
				return this.trkWideRSSIBackupPTTFallbackThreshold_A43626.Editable;
			}
			set
			{
				short num = (short)816347372;
				short num2 = num;
				num = (short)852588780;
				switch (num2 == num)
				{
				}
				num = (short)82247680;
				short num3 = num;
				num = (short)936902657;
				if (num != 0)
				{
				}
				num = (short)760872960;
				if (num != 0)
				{
				}
				this.trkWideRSSIBackupPTTFallbackThreshold_A43626.Editable = value;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x0007BAC8 File Offset: 0x00079CC8
		internal string TrkWideRSSIBackupPTTFallbackThreshold_A43626_UILabel
		{
			get
			{
				short num = (short)1045150347;
				short num2 = num;
				num = (short)1908456075;
				switch (num2 == num)
				{
				}
				num = (short)1174994944;
				short num3 = num;
				num = (short)1602289664;
				if (num != 0)
				{
				}
				num = (short)1000341505;
				if (num != 0)
				{
				}
				return this.trkWideRSSIBackupPTTFallbackThreshold_A43626.UIName;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x0007BB7C File Offset: 0x00079D7C
		// (set) Token: 0x0600080A RID: 2058 RVA: 0x0007BC30 File Offset: 0x00079E30
		internal bool TrkWideRSSIBackupPTTFallbackThreshold_A43626_HiddenStatic
		{
			get
			{
				short num = (short)600440513;
				short num2 = num;
				num = (short)2135883457;
				switch (num2 == num)
				{
				}
				num = (short)400490496;
				short num3 = num;
				num = (short)716177408;
				if (num != 0)
				{
				}
				num = (short)2139160577;
				if (num != 0)
				{
				}
				return this.trkWideRSSIBackupPTTFallbackThreshold_A43626.HiddenStatic;
			}
			set
			{
				short num = (short)1937948726;
				short num2 = num;
				num = (short)640991286;
				switch (num2 == num)
				{
				}
				num = (short)578682880;
				short num3 = num;
				num = (short)631046145;
				if (num != 0)
				{
				}
				num = (short)420413440;
				if (num != 0)
				{
				}
				this.trkWideRSSIBackupPTTFallbackThreshold_A43626.HiddenStatic = value;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x0007BCE4 File Offset: 0x00079EE4
		// (set) Token: 0x0600080C RID: 2060 RVA: 0x0007BD98 File Offset: 0x00079F98
		internal bool TrkWideRSSIBackupPTTFallbackThreshold_A43626_HiddenDynamic
		{
			get
			{
				short num = (short)114875750;
				short num2 = num;
				num = (short)1056300390;
				switch (num2 == num)
				{
				}
				num = (short)270663680;
				short num3 = num;
				num = (short)662175744;
				if (num != 0)
				{
				}
				num = (short)443219969;
				if (num != 0)
				{
				}
				return this.trkWideRSSIBackupPTTFallbackThreshold_A43626.HiddenDynamic;
			}
			set
			{
				short num = (short)522452993;
				if (num != 0)
				{
				}
				num = (short)1247721771;
				short num2 = num;
				num = (short)1486862635;
				switch (num2 == num)
				{
				default:
				{
					num = (short)131727360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)746848256;
				if (num != 0)
				{
				}
				this.trkWideRSSIBackupPTTFallbackThreshold_A43626.HiddenDynamic = value;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x0007BE4C File Offset: 0x0007A04C
		public bool TrkWideRSSIBackupPTTFallbackThreshold_A43626_HasDiffs
		{
			get
			{
				short num = (short)1977471621;
				short num2 = num;
				num = (short)1256313477;
				switch (num2 == num)
				{
				}
				num = (short)2100494336;
				short num3 = num;
				num = (short)1582432256;
				if (num != 0)
				{
				}
				num = (short)136118273;
				if (num != 0)
				{
				}
				return this.trkWideRSSIBackupPTTFallbackThreshold_A43626._HasDiffs;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x0007BF00 File Offset: 0x0007A100
		// (set) Token: 0x0600080F RID: 2063 RVA: 0x0007BFB0 File Offset: 0x0007A1B0
		public int TrkWideSmartConnectRSSIReturnThreshold_43723Value
		{
			get
			{
				short num = (short)287447088;
				short num2 = num;
				num = (short)787617840;
				switch (num2 == num)
				{
				}
				num = (short)1681850368;
				short num3 = num;
				num = (short)993918977;
				if (num != 0)
				{
				}
				num = (short)2120220672;
				if (num != 0)
				{
				}
				return this.trkWideSmartConnectRSSIReturnThreshold_43723.Value;
			}
			set
			{
				short num = (short)741408769;
				if (num != 0)
				{
				}
				num = (short)430987219;
				short num2 = num;
				num = (short)928798675;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1784676352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)152633344;
				if (num != 0)
				{
				}
				this.trkWideSmartConnectRSSIReturnThreshold_43723.Value = value;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x0007C068 File Offset: 0x0007A268
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideSmartConnectRSSIReturnThreshold_43723
		{
			get
			{
				short num = (short)1024200927;
				short num2 = num;
				num = (short)524488927;
				switch (num2 == num)
				{
				}
				num = (short)1667694592;
				short num3 = num;
				num = (short)532545536;
				if (num != 0)
				{
				}
				num = (short)899874817;
				if (num != 0)
				{
				}
				return this.trkWideSmartConnectRSSIReturnThreshold_43723;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x0007C118 File Offset: 0x0007A318
		// (set) Token: 0x06000812 RID: 2066 RVA: 0x0007C1CC File Offset: 0x0007A3CC
		public string TrkWideSmartConnectRSSIReturnThreshold_43723_UIValue
		{
			get
			{
				short num = (short)1117141704;
				short num2 = num;
				num = (short)2029664968;
				switch (num2 == num)
				{
				}
				num = (short)1942224896;
				short num3 = num;
				num = (short)1711865857;
				if (num != 0)
				{
				}
				num = (short)1180172288;
				if (num != 0)
				{
				}
				return this.trkWideSmartConnectRSSIReturnThreshold_43723.UIValue;
			}
			set
			{
				short num = (short)1426875425;
				short num2 = num;
				num = (short)1739547681;
				switch (num2 == num)
				{
				}
				num = (short)1539244032;
				short num3 = num;
				num = (short)233111553;
				if (num != 0)
				{
				}
				num = (short)1186201600;
				if (num != 0)
				{
				}
				this.trkWideSmartConnectRSSIReturnThreshold_43723.UIValue = value;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x0007C280 File Offset: 0x0007A480
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x0007C334 File Offset: 0x0007A534
		public string TrkWideSmartConnectRSSIReturnThreshold_43723_HexUIValue
		{
			get
			{
				short num = (short)1980311362;
				short num2 = num;
				num = (short)300033858;
				switch (num2 == num)
				{
				}
				num = (short)874643456;
				short num3 = num;
				num = (short)1416364033;
				if (num != 0)
				{
				}
				num = (short)1781727232;
				if (num != 0)
				{
				}
				return this.trkWideSmartConnectRSSIReturnThreshold_43723.HexUIValue;
			}
			set
			{
				short num = (short)252169759;
				short num2 = num;
				num = (short)1321192991;
				switch (num2 == num)
				{
				}
				num = (short)1270677504;
				short num3 = num;
				num = (short)795607041;
				if (num != 0)
				{
				}
				num = (short)2097676288;
				if (num != 0)
				{
				}
				this.trkWideSmartConnectRSSIReturnThreshold_43723.HexUIValue = value;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x0007C3EC File Offset: 0x0007A5EC
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x0007C4A0 File Offset: 0x0007A6A0
		internal int TrkWideSmartConnectRSSIReturnThreshold_43723Min
		{
			get
			{
				short num = (short)164233217;
				if (num != 0)
				{
				}
				num = (short)1782840078;
				short num2 = num;
				num = (short)1124465422;
				switch (num2 == num)
				{
				default:
				{
					num = (short)481755136;
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
				return this.trkWideSmartConnectRSSIReturnThreshold_43723.Min;
			}
			set
			{
				short num = (short)70895603;
				short num2 = num;
				num = (short)755615731;
				switch (num2 == num)
				{
				}
				num = (short)2135425024;
				short num3 = num;
				num = (short)864288769;
				if (num != 0)
				{
				}
				num = (short)1502281728;
				if (num != 0)
				{
				}
				this.trkWideSmartConnectRSSIReturnThreshold_43723.Min = value;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x0007C558 File Offset: 0x0007A758
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x0007C60C File Offset: 0x0007A80C
		internal int TrkWideSmartConnectRSSIReturnThreshold_43723Max
		{
			get
			{
				short num = (short)712447489;
				short num2 = num;
				num = (short)1599870465;
				switch (num2 == num)
				{
				}
				num = (short)1766588416;
				short num3 = num;
				num = (short)386269184;
				if (num != 0)
				{
				}
				num = (short)1379139585;
				if (num != 0)
				{
				}
				return this.trkWideSmartConnectRSSIReturnThreshold_43723.Max;
			}
			set
			{
				short num = (short)521797633;
				if (num != 0)
				{
				}
				num = (short)236228491;
				short num2 = num;
				num = (short)1316196235;
				switch (num2 == num)
				{
				default:
				{
					num = (short)467337216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1394081792;
				if (num != 0)
				{
				}
				this.trkWideSmartConnectRSSIReturnThreshold_43723.Max = value;
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x0007C6C4 File Offset: 0x0007A8C4
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x0007C778 File Offset: 0x0007A978
		internal int TrkWideSmartConnectRSSIReturnThreshold_43723Step
		{
			get
			{
				short num = (short)1989322620;
				short num2 = num;
				num = (short)1730783100;
				switch (num2 == num)
				{
				}
				num = (short)752156672;
				short num3 = num;
				num = (short)2049769472;
				if (num != 0)
				{
				}
				num = (short)1262223361;
				if (num != 0)
				{
				}
				return this.trkWideSmartConnectRSSIReturnThreshold_43723.StepSize;
			}
			set
			{
				short num = (short)509964174;
				short num2 = num;
				num = (short)1090088846;
				switch (num2 == num)
				{
				}
				num = (short)1306329088;
				short num3 = num;
				num = (short)1689911297;
				if (num != 0)
				{
				}
				num = (short)1251672064;
				if (num != 0)
				{
				}
				this.trkWideSmartConnectRSSIReturnThreshold_43723.StepSize = value;
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x0007C82C File Offset: 0x0007AA2C
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x0007C8E0 File Offset: 0x0007AAE0
		public bool TrkWideSmartConnectRSSIReturnThreshold_43723_Applicable
		{
			get
			{
				short num = (short)816979446;
				short num2 = num;
				num = (short)1424039414;
				switch (num2 == num)
				{
				}
				num = (short)1191772160;
				short num3 = num;
				num = (short)645267457;
				if (num != 0)
				{
				}
				num = (short)611647488;
				if (num != 0)
				{
				}
				return this.trkWideSmartConnectRSSIReturnThreshold_43723.Applicable;
			}
			set
			{
				short num = (short)1631846401;
				if (num != 0)
				{
				}
				num = (short)355923165;
				short num2 = num;
				num = (short)1086649565;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1159397376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)963444736;
				if (num != 0)
				{
				}
				this.trkWideSmartConnectRSSIReturnThreshold_43723.Applicable = value;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x0007C998 File Offset: 0x0007AB98
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x0007CA4C File Offset: 0x0007AC4C
		public bool TrkWideSmartConnectRSSIReturnThreshold_43723_Valid
		{
			get
			{
				short num = (short)1114253349;
				short num2 = num;
				num = (short)220145701;
				switch (num2 == num)
				{
				}
				num = (short)810156032;
				short num3 = num;
				num = (short)763297793;
				if (num != 0)
				{
				}
				num = (short)1285029888;
				if (num != 0)
				{
				}
				return this.trkWideSmartConnectRSSIReturnThreshold_43723.Valid;
			}
			set
			{
				short num = (short)2085930169;
				short num2 = num;
				num = (short)1675347129;
				switch (num2 == num)
				{
				}
				num = (short)1163264000;
				short num3 = num;
				num = (short)2125135873;
				if (num != 0)
				{
				}
				num = (short)1504444416;
				if (num != 0)
				{
				}
				this.trkWideSmartConnectRSSIReturnThreshold_43723.Valid = value;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x0007CB00 File Offset: 0x0007AD00
		// (set) Token: 0x06000820 RID: 2080 RVA: 0x0007CBB4 File Offset: 0x0007ADB4
		public bool TrkWideSmartConnectRSSIReturnThreshold_43723_Visible
		{
			get
			{
				short num = (short)892862465;
				if (num != 0)
				{
				}
				num = (short)506441159;
				short num2 = num;
				num = (short)525446599;
				switch (num2 == num)
				{
				default:
				{
					num = (short)555220992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1942421504;
				if (num != 0)
				{
				}
				return this.trkWideSmartConnectRSSIReturnThreshold_43723.Visible;
			}
			set
			{
				short num = (short)951891399;
				short num2 = num;
				num = (short)75675079;
				switch (num2 == num)
				{
				}
				num = (short)554958848;
				short num3 = num;
				num = (short)859570177;
				if (num != 0)
				{
				}
				num = (short)95420416;
				if (num != 0)
				{
				}
				this.trkWideSmartConnectRSSIReturnThreshold_43723.Visible = value;
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x0007CC6C File Offset: 0x0007AE6C
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x0007CD20 File Offset: 0x0007AF20
		public bool TrkWideSmartConnectRSSIReturnThreshold_43723_Editable
		{
			get
			{
				short num = (short)147564493;
				short num2 = num;
				num = (short)1787799501;
				switch (num2 == num)
				{
				}
				num = (short)762314752;
				short num3 = num;
				num = (short)1905065984;
				if (num != 0)
				{
				}
				num = (short)1318191105;
				if (num != 0)
				{
				}
				return this.trkWideSmartConnectRSSIReturnThreshold_43723.Editable;
			}
			set
			{
				short num = (short)1387017791;
				short num2 = num;
				num = (short)291452479;
				switch (num2 == num)
				{
				}
				num = (short)1769603072;
				short num3 = num;
				num = (short)2102198273;
				if (num != 0)
				{
				}
				num = (short)1156644864;
				if (num != 0)
				{
				}
				this.trkWideSmartConnectRSSIReturnThreshold_43723.Editable = value;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x0007CDD8 File Offset: 0x0007AFD8
		internal string TrkWideSmartConnectRSSIReturnThreshold_43723_UILabel
		{
			get
			{
				short num = (short)32420682;
				short num2 = num;
				num = (short)1378726730;
				switch (num2 == num)
				{
				}
				num = (short)382402560;
				short num3 = num;
				num = (short)2123169793;
				if (num != 0)
				{
				}
				num = (short)1518206976;
				if (num != 0)
				{
				}
				return this.trkWideSmartConnectRSSIReturnThreshold_43723.UIName;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x0007CE8C File Offset: 0x0007B08C
		// (set) Token: 0x06000825 RID: 2085 RVA: 0x0007CF40 File Offset: 0x0007B140
		internal bool TrkWideSmartConnectRSSIReturnThreshold_43723_HiddenStatic
		{
			get
			{
				short num = (short)928828393;
				short num2 = num;
				num = (short)518048745;
				switch (num2 == num)
				{
				}
				num = (short)1245315072;
				short num3 = num;
				num = (short)161677312;
				if (num != 0)
				{
				}
				num = (short)1445462017;
				if (num != 0)
				{
				}
				return this.trkWideSmartConnectRSSIReturnThreshold_43723.HiddenStatic;
			}
			set
			{
				short num = (short)490639889;
				short num2 = num;
				num = (short)1531548177;
				switch (num2 == num)
				{
				}
				num = (short)2133262336;
				short num3 = num;
				num = (short)1063387137;
				if (num != 0)
				{
				}
				num = (short)992673792;
				if (num != 0)
				{
				}
				this.trkWideSmartConnectRSSIReturnThreshold_43723.HiddenStatic = value;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x0007CFF8 File Offset: 0x0007B1F8
		// (set) Token: 0x06000827 RID: 2087 RVA: 0x0007D0B0 File Offset: 0x0007B2B0
		internal bool TrkWideSmartConnectRSSIReturnThreshold_43723_HiddenDynamic
		{
			get
			{
				short num = (short)167420968;
				short num2 = num;
				num = (short)340960296;
				switch (num2 == num)
				{
				}
				num = (short)1406599168;
				short num3 = num;
				num = (short)1378091009;
				if (num != 0)
				{
				}
				num = (short)862650368;
				if (num != 0)
				{
				}
				return this.trkWideSmartConnectRSSIReturnThreshold_43723.HiddenDynamic;
			}
			set
			{
				short num = (short)593435546;
				short num2 = num;
				num = (short)1927945114;
				switch (num2 == num)
				{
				}
				num = (short)1188691968;
				short num3 = num;
				num = (short)1943273473;
				if (num != 0)
				{
				}
				num = (short)115474432;
				if (num != 0)
				{
				}
				this.trkWideSmartConnectRSSIReturnThreshold_43723.HiddenDynamic = value;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x0007D164 File Offset: 0x0007B364
		public bool TrkWideSmartConnectRSSIReturnThreshold_43723_HasDiffs
		{
			get
			{
				short num = (short)1529412894;
				short num2 = num;
				num = (short)1670118686;
				switch (num2 == num)
				{
				}
				num = (short)1458307072;
				short num3 = num;
				num = (short)1216610305;
				if (num != 0)
				{
				}
				num = (short)1782579200;
				if (num != 0)
				{
				}
				return this.trkWideSmartConnectRSSIReturnThreshold_43723._HasDiffs;
			}
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x0007D218 File Offset: 0x0007B418
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_100;
				case 1:
					goto IL_13E;
				case 2:
				{
					num2 = (short)1697710080;
					short num3 = num2;
					if (base.ParentRecset != null)
					{
						num2 = (short)785186820;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)867303425;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					num2 = (short)272302083;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			IL_100:
			return result;
			IL_13E:
			num2 = (short)210632705;
			if (num2 != 0)
			{
			}
			result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
			goto IL_E8;
			IL_24:
			num2 = (short)1520010590;
			short num4 = num2;
			num2 = (short)2139456862;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_E8:
				num2 = (short)605749248;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)898564096;
				if (num2 != 0)
				{
				}
				result = null;
				num2 = (short)613679106;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0400020F RID: 527
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideRSSIThresholdsDesenseTimer_A7828;

		// Token: 0x04000210 RID: 528
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideRSSIThresholdsRSSIAcceptableThreshold_A8989;

		// Token: 0x04000211 RID: 529
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideRSSIThresholdsRSSIExcellentThreshold_A8991;

		// Token: 0x04000212 RID: 530
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideRSSIThresholdsRSSIGoodThreshold_A8992;

		// Token: 0x04000213 RID: 531
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideRSSIThresholdsRSSIVeryGoodThreshold_A8996;

		// Token: 0x04000214 RID: 532
		private global::AcpBusinessLayer.AcpField<bool> trkWideRSSIThresholdsStrongSignalRoaming_A24630;

		// Token: 0x04000215 RID: 533
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideRSSIThresholdsRSSIOSPCounter_A8994;

		// Token: 0x04000216 RID: 534
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideRSSIThresholdsRSSIOSWCounter_A8995;

		// Token: 0x04000217 RID: 535
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideRSSIBackupPTTFallbackThreshold_A43626;

		// Token: 0x04000218 RID: 536
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideSmartConnectRSSIReturnThreshold_43723;
	}
}
