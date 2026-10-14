using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Features.Converters;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalWide
{
	// Token: 0x0200053F RID: 1343
	[global::System.Serializable]
	public class ASTROData : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600B372 RID: 45938 RVA: 0x00A67658 File Offset: 0x00A65858
		public ASTROData(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600B373 RID: 45939 RVA: 0x00A67674 File Offset: 0x00A65874
		protected ASTROData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600B374 RID: 45940 RVA: 0x00A6768C File Offset: 0x00A6588C
		public override void Init()
		{
			int a_ = 6;
			short num = (short)308936704;
			short num2 = num;
			num = (short)369426433;
			if (num != 0)
			{
			}
			num = (short)1964360746;
			short num3 = num;
			num = (short)586859562;
			switch (num3 == num)
			{
			}
			num = (short)1519517696;
			if (num != 0)
			{
			}
			this.cnvWideASTRODataARPCacheDepth_A7463 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊髌ꛎ뗐뛒铔蓖跘觚鋜鯞胠韢蓤ꛦ믨믪껬軮鋰鯲郴돶鳸诺觼韾帀䈂㈄㌆㼈㠊", a_), global::CommonResources.AcgResources.ID_ARPCACHEDEPTH, 0, 50, null, null, 0, 1);
			this.cnvWideASTRODataARPCacheDepth_A7463.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvWideASTRODataARPCacheDepth_A7463.DataTransferOrder = 1;
			this.cnvWideASTRODataARPCacheDepth_A7463.ShowHexValue = false;
			this.cnvWideASTRODataARPCacheTimehrs_A7464 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊髌ꛎ뗐뛒铔蓖跘觚鋜鯞胠韢蓤ꛦ믨믪껬軮鋰鯲郴ꏶ郸雺飼韾猀瀂娄䘆㸈㼊㬌㬎", a_), global::CommonResources.AcgResources.ID_ARPCACHETIMEHRS, 0, 24, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 1);
			this.cnvWideASTRODataARPCacheTimehrs_A7464.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvWideASTRODataARPCacheTimehrs_A7464.DataTransferOrder = 24;
			this.cnvWideASTRODataARPCacheTimehrs_A7464.ShowHexValue = false;
			this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145 = new global::AcpBusinessLayer.AcpSimpleRangeField(15, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊髌ꛎ뗐뛒铔蓖跘觚鋜鯞胠韢蓤ꇦ鯨諪胬諮ꋰ諲鯴银꫸黺飼链儀昂眄渆昈漊怌簎丐划ⴔ☖ⴘ⸚", a_), global::CommonResources.AcgResources.ID_FRAMESYNCSEEKPERIODMS, 0, 100, null, null, 0, 50);
			this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.DataTransferOrder = 13;
			this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.ShowHexValue = false;
			this.cnvWideASTRODataTxLimitedPatienceSec_A9544 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊髌ꛎ뗐뛒铔蓖跘觚鋜鯞胠韢蓤돦釨꟪蓬苮飰蟲郴鏶꧸髺觼雾搀洂昄戆娈渊渌倎倐⨒—⌖ⴘ", a_), global::CommonResources.AcgResources.ID_TXLIMITEDPATIENCESEC, 2, 255, null, null, 0, 1);
			this.cnvWideASTRODataTxLimitedPatienceSec_A9544.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvWideASTRODataTxLimitedPatienceSec_A9544.DataTransferOrder = 11;
			this.cnvWideASTRODataTxLimitedPatienceSec_A9544.AddCustomValue(0, global::CommonResources.AcgResources.ID_INFINITE);
			this.cnvWideASTRODataTxLimitedPatienceSec_A9544.ShowHexValue = false;
			this.cnvWideASTRODataMaxTxAttempts_A8474 = new global::AcpBusinessLayer.AcpSimpleRangeField(4, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊髌ꛎ뗐뛒铔蓖跘觚鋜鯞胠韢蓤ꫦ裨鏪맬韮냰蟲致鋶铸诺觼賾帀䈂㴄㌆㸈㼊", a_), global::CommonResources.AcgResources.ID_CAIDATAMAXTXATTEMPTS, 2, 10, null, null, 0, 1);
			this.cnvWideASTRODataMaxTxAttempts_A8474.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvWideASTRODataMaxTxAttempts_A8474.DataTransferOrder = 20;
			this.cnvWideASTRODataMaxTxAttempts_A8474.ShowHexValue = false;
			this.cnvWideASTRODataMinResponseTimerms_A8514 = new global::AcpBusinessLayer.AcpSimpleRangeField(14, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊髌ꛎ뗐뛒铔蓖跘觚鋜鯞胠韢蓤ꫦ胨藪뿬諮苰菲髴駶諸黺ꧼ雾氀昂眄樆稈吊䰌㜎␐−℔", a_), global::CommonResources.AcgResources.ID_CAIDATAMINRESPONSETIMERMS, 1, 40, null, null, 0, 50);
			this.cnvWideASTRODataMinResponseTimerms_A8514.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvWideASTRODataMinResponseTimerms_A8514.DataTransferOrder = 21;
			this.cnvWideASTRODataMinResponseTimerms_A8514.ShowHexValue = false;
			this.cnvWideASTRODataResponseTimerms_A8948 = new global::AcpBusinessLayer.AcpSimpleRangeField(33, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊髌ꛎ뗐뛒铔蓖跘觚鋜鯞胠韢蓤뗦賨飪鷬胮鿰胲郴ꏶ郸雺飼跾氀瀂娄䘆ㄈ㈊㤌㜎", a_), global::CommonResources.AcgResources.ID_CAIDATARESPONSETIMERMS, 1, 50, null, null, 0, 100);
			this.cnvWideASTRODataResponseTimerms_A8948.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvWideASTRODataResponseTimerms_A8948.DataTransferOrder = 22;
			this.cnvWideASTRODataResponseTimerms_A8948.ShowHexValue = false;
			this.cnvWideASTRODataTxLongRandomRangeMs_A9546 = new global::AcpBusinessLayer.AcpSimpleRangeField(40, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊髌ꛎ뗐뛒铔蓖跘觚鋜鯞胠韢蓤돦釨꟪苬臮雰ꇲ铴駶鷸铺郼귾怀洂戄戆䐈砊刌与⠐☒℔№", a_), global::CommonResources.AcgResources.ID_TXLONGRANDOMRANGEMS, 1, 100, null, null, 0, 50);
			this.cnvWideASTRODataTxLongRandomRangeMs_A9546.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvWideASTRODataTxLongRandomRangeMs_A9546.DataTransferOrder = 16;
			this.cnvWideASTRODataTxLongRandomRangeMs_A9546.ShowHexValue = false;
			this.cnvWideASTRODataTxRespRandomRangeMs_A9563 = new global::AcpBusinessLayer.AcpSimpleRangeField(20, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊髌ꛎ뗐뛒铔蓖跘觚鋜鯞胠韢蓤돦釨맪裬鳮臰ꇲ铴駶鷸铺郼귾怀洂戄戆䐈砊刌与⠐☒⌔␖", a_), global::CommonResources.AcgResources.ID_TXRESPRANDOMRANGEMS, 1, 20, null, null, 0, 50);
			this.cnvWideASTRODataTxRespRandomRangeMs_A9563.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvWideASTRODataTxRespRandomRangeMs_A9563.DataTransferOrder = 17;
			this.cnvWideASTRODataTxRespRandomRangeMs_A9563.ShowHexValue = false;
			this.cnvWideASTRODataTxShortRandomRangeMs_A9565 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊髌ꛎ뗐뛒铔蓖跘觚鋜鯞胠韢蓤돦釨룪藬胮菰蟲ꟴ零韸鿺鋼鋾匀戂欄怆氈䘊縌倎倐⨒—№Ⱈ", a_), global::CommonResources.AcgResources.ID_TXSHORTRANDOMRANGEMS, 1, 10, null, null, 0, 50);
			this.cnvWideASTRODataTxShortRandomRangeMs_A9565.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvWideASTRODataTxShortRandomRangeMs_A9565.DataTransferOrder = 18;
			this.cnvWideASTRODataTxShortRandomRangeMs_A9565.ShowHexValue = false;
			this.cnvWideASTRODataMaxPacketSizebytes_A8471 = new global::AcpBusinessLayer.AcpRangeField<int, string>(512, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊髌ꛎ뗐뛒铔蓖跘觚鋜鯞胠韢蓤ꫦ裨鏪뷬軮鋰飲郴菶꫸鋺蟼髾挀稂焄戆稈吊䰌㜎┐␒␔", a_), global::CommonResources.AcgResources.ID_CAIDATAMAXPACKETSIZEBYTES, 16, 512, 16);
			this.cnvWideASTRODataMaxPacketSizebytes_A8471.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvWideASTRODataMaxPacketSizebytes_A8471.DataTransferOrder = 19;
			this.cnvWideASTRODataMaxPacketSizebytes_A8471.ShowHexValue = false;
			this.cnvWideConventionalCustomerID_41558 = new global::AcpBusinessLayer.AcpRangeField<int, string>(0, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.UnpackDecToHexPackHexToDecStr4(), this, global::AllFeatures.CodeplugGuid.b("蓆ꟈ뷊髌ꛎ뗐뛒雔룖럘귚룜뇞闠諢諤触裨蟪껬髮苰蟲髴髶鳸觺듼믾帀㜂㐄㈆㰈㌊", a_), global::CommonResources.AcgResources.ID_CONVENTIONALCUSTOMERIDHEX, 0, 65535, 1);
			this.cnvWideConventionalCustomerID_41558.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvWideConventionalCustomerID_41558.DataTransferOrder = 28;
			this.cnvWideConventionalCustomerID_41558.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛆髈鿊鿌胎韒듔ꏖ룘", a_);
			base.Id = 10058;
			base.UIName = global::CommonResources.AcgResources.ID_ASTRODATA;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600B375 RID: 45941 RVA: 0x00A67B34 File Offset: 0x00A65D34
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)1236533272;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.cnvWideASTRODataARPCacheDepth_A7463 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔雖諘迚远郞ꗠ苢釤蛦꣨맪뷬곮郰郲鷴鋶뷸黺跼课椀専䐄〆㴈㴊㸌", a_), global::CommonResources.AcgResources.ID_ARPCACHEDEPTH, null, null, 0, 1);
					this.cnvWideASTRODataARPCacheDepth_A7463.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvWideASTRODataARPCacheDepth_A7463.DataTransferOrder = 1;
					this.cnvWideASTRODataARPCacheDepth_A7463.ShowHexValue = false;
					num = (short)237633537;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_5FE;
				case 2:
					this.cnvWideConventionalCustomerID_41558 = new global::AcpBusinessLayer.AcpRangeField<int, string>(0, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.UnpackDecToHexPackHexToDecStr4(), this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔铖뛘뗚ꯜ뫞迠韢賤裦蟨諪臬곮蓰胲致飶铸黺迼뛾䔀専㄄㘆㰈㸊㔌", a_), global::CommonResources.AcgResources.ID_CONVENTIONALCUSTOMERIDHEX);
					this.cnvWideConventionalCustomerID_41558.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvWideConventionalCustomerID_41558.DataTransferOrder = 28;
					this.cnvWideConventionalCustomerID_41558.ShowHexValue = false;
					num = (short)936771610;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145 = new global::AcpBusinessLayer.AcpSimpleRangeField(15, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔雖諘迚远郞ꗠ苢釤蛦꿨駪賬苮铰ꃲ賴駶髸꣺飼髾樀匂怄甆怈搊椌戎成䰒吔⼖⠘⼚⠜", a_), global::CommonResources.AcgResources.ID_FRAMESYNCSEEKPERIODMS, null, null, 0, 50);
					this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.DataTransferOrder = 13;
					this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.ShowHexValue = false;
					num = (short)219283486;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_83D;
				case 5:
					goto IL_5B1;
				case 6:
					goto IL_99F;
				case 7:
					num = (short)270991361;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔雖諘迚远郞ꗠ苢釤蛦ꓨ諪闬믮觰닲致菶鳸雺跼课爀専䐄㼆㴈㰊㤌", a_)))
					{
						num = (short)135856165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_83D;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔铖뛘뗚ꯜ뫞迠韢賤裦蟨諪臬곮蓰胲致飶铸黺迼뛾䔀専㄄㘆㰈㸊㔌", a_)))
					{
						num = (short)565575682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A54;
				case 9:
				{
					this.cnvWideASTRODataTxRespRandomRangeMs_A9563 = new global::AcpBusinessLayer.AcpSimpleRangeField(20, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔雖諘迚远郞ꗠ苢釤蛦뷨鏪뿬諮苰菲ꟴ零韸鿺鋼鋾匀戂欄怆氈䘊縌倎倐⨒—№⨘", a_), global::CommonResources.AcgResources.ID_TXRESPRANDOMRANGEMS, null, null, 0, 50);
					this.cnvWideASTRODataTxRespRandomRangeMs_A9563.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvWideASTRODataTxRespRandomRangeMs_A9563.DataTransferOrder = 17;
					this.cnvWideASTRODataTxRespRandomRangeMs_A9563.ShowHexValue = false;
					num = (short)983539;
					short num3 = num;
					num = (short)1796014579;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_70D;
					default:
						num = (short)2033516544;
						if (num != 0)
						{
						}
						num = (short)2099314694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 10:
					num = (short)1297940494;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_44F;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔雖諘迚远郞ꗠ苢釤蛦ꓨ諪闬뿮郰郲黴鋶跸꣺铼藾搀愂簄猆氈砊刌与⤐✒∔☖", a_)))
					{
						num = (short)134676512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_330;
				case 13:
					goto IL_145;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔雖諘迚远郞ꗠ苢釤蛦꣨맪뷬곮郰郲鷴鋶뷸黺跼课椀専䐄〆㴈㴊㸌", a_)))
					{
						num = (short)904462336;
						short num4 = num;
						num = (short)924188672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5FE;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔雖諘迚远郞ꗠ苢釤蛦ꓨ苪菬뷮铰胲藴飶韸裺飼꯾栀渂怄甆搈砊刌与⤐☒␔⌖", a_)))
					{
						num = (short)757202971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_145;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔雖諘迚远郞ꗠ苢釤蛦꿨駪賬苮铰ꃲ賴駶髸꣺飼髾樀匂怄甆怈搊椌戎成䰒吔⼖⠘⼚⠜", a_)))
					{
						num = (short)50135043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8D9;
				case 17:
					this.cnvWideASTRODataTxLimitedPatienceSec_A9544 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔雖諘迚远郞ꗠ苢釤蛦뷨鏪ꇬ蛮鳰髲致鋶鷸꯺鳼课栀昂欄搆氈堊栌氎丐划Ⱄ∖ⴘ⼚", a_), global::CommonResources.AcgResources.ID_TXLIMITEDPATIENCESEC, null, null, 0, 1);
					this.cnvWideASTRODataTxLimitedPatienceSec_A9544.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvWideASTRODataTxLimitedPatienceSec_A9544.DataTransferOrder = 11;
					this.cnvWideASTRODataTxLimitedPatienceSec_A9544.AddCustomValue(0, global::CommonResources.AcgResources.ID_INFINITE);
					this.cnvWideASTRODataTxLimitedPatienceSec_A9544.ShowHexValue = false;
					num = (short)330563605;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_F5;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔雖諘迚远郞ꗠ苢釤蛦뷨鏪뻬蟮黰臲致ꗶ飸闺駼郾氀儂搄椆済渊䀌簎丐划Ⱄ∖⼘⸚", a_)))
					{
						num = (short)298057767;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_44F;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔雖諘迚远郞ꗠ苢釤蛦믨軪黬鿮黰鷲蛴鋶그鋺郼髾猀渂瘄堆䠈㌊㐌㬎⤐", a_)))
					{
						num = (short)464519190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_88A;
				case 21:
					goto IL_503;
				case 22:
					this.cnvWideASTRODataResponseTimerms_A8948 = new global::AcpBusinessLayer.AcpSimpleRangeField(33, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔雖諘迚远郞ꗠ苢釤蛦믨軪黬鿮黰鷲蛴鋶그鋺郼髾猀渂瘄堆䠈㌊㐌㬎⤐", a_), global::CommonResources.AcgResources.ID_CAIDATARESPONSETIMERMS, null, null, 0, 100);
					this.cnvWideASTRODataResponseTimerms_A8948.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvWideASTRODataResponseTimerms_A8948.DataTransferOrder = 22;
					this.cnvWideASTRODataResponseTimerms_A8948.ShowHexValue = false;
					num = (short)415105047;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					goto IL_88A;
				case 24:
					switch (0)
					{
					case 0:
						goto IL_CE;
					}
					continue;
				case 25:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔雖諘迚远郞ꗠ苢釤蛦뷨鏪뿬諮苰菲ꟴ零韸鿺鋼鋾匀戂欄怆氈䘊縌倎倐⨒—№⨘", a_)))
					{
						num = (short)1848115209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_99F;
				case 26:
					goto IL_4FE;
				case 27:
					this.cnvWideASTRODataMinResponseTimerms_A8514 = new global::AcpBusinessLayer.AcpSimpleRangeField(14, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔雖諘迚远郞ꗠ苢釤蛦ꓨ苪菬뷮铰胲藴飶韸裺飼꯾栀渂怄甆搈砊刌与⤐☒␔⌖", a_), global::CommonResources.AcgResources.ID_CAIDATAMINRESPONSETIMERMS, null, null, 0, 50);
					this.cnvWideASTRODataMinResponseTimerms_A8514.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvWideASTRODataMinResponseTimerms_A8514.DataTransferOrder = 21;
					this.cnvWideASTRODataMinResponseTimerms_A8514.ShowHexValue = false;
					num = (short)1607139341;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					num = (short)274530338;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					goto IL_330;
				case 30:
					goto IL_8D9;
				case 31:
					this.cnvWideASTRODataTxLongRandomRangeMs_A9546 = new global::AcpBusinessLayer.AcpSimpleRangeField(40, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔雖諘迚远郞ꗠ苢釤蛦뷨鏪ꇬ胮鿰铲ꟴ零韸鿺鋼鋾匀戂欄怆氈䘊縌倎倐⨒—⌖⼘", a_), global::CommonResources.AcgResources.ID_TXLONGRANDOMRANGEMS, null, null, 0, 50);
					this.cnvWideASTRODataTxLongRandomRangeMs_A9546.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvWideASTRODataTxLongRandomRangeMs_A9546.DataTransferOrder = 16;
					this.cnvWideASTRODataTxLongRandomRangeMs_A9546.ShowHexValue = false;
					num = (short)617742354;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					this.cnvWideASTRODataMaxPacketSizebytes_A8471 = new global::AcpBusinessLayer.AcpRangeField<int, string>(512, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔雖諘迚远郞ꗠ苢釤蛦ꓨ諪闬뿮郰郲黴鋶跸꣺铼藾搀愂簄猆氈砊刌与⤐✒∔☖", a_), global::CommonResources.AcgResources.ID_CAIDATAMAXPACKETSIZEBYTES);
					this.cnvWideASTRODataMaxPacketSizebytes_A8471.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvWideASTRODataMaxPacketSizebytes_A8471.DataTransferOrder = 19;
					this.cnvWideASTRODataMaxPacketSizebytes_A8471.ShowHexValue = false;
					goto IL_70D;
				case 33:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔雖諘迚远郞ꗠ苢釤蛦뷨鏪ꇬ胮鿰铲ꟴ零韸鿺鋼鋾匀戂欄怆氈䘊縌倎倐⨒—⌖⼘", a_)))
					{
						num = (short)839778335;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F5;
				case 34:
					if (producerFields != null)
					{
						num = (short)2094333962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A54;
				case 35:
					this.cnvWideASTRODataARPCacheTimehrs_A7464 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔雖諘迚远郞ꗠ苢釤蛦꣨맪뷬곮郰郲鷴鋶그鋺郼髾椀焂瘄堆䠈㰊㤌㤎┐", a_), global::CommonResources.AcgResources.ID_ARPCACHETIMEHRS, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 1);
					this.cnvWideASTRODataARPCacheTimehrs_A7464.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvWideASTRODataARPCacheTimehrs_A7464.DataTransferOrder = 24;
					this.cnvWideASTRODataARPCacheTimehrs_A7464.ShowHexValue = false;
					num = (short)302710789;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔雖諘迚远郞ꗠ苢釤蛦꣨맪뷬곮郰郲鷴鋶그鋺郼髾椀焂瘄堆䠈㰊㤌㤎┐", a_)))
					{
						num = (short)573374499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5B1;
				case 37:
					this.cnvWideASTRODataMaxTxAttempts_A8474 = new global::AcpBusinessLayer.AcpSimpleRangeField(4, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔雖諘迚远郞ꗠ苢釤蛦ꓨ諪闬믮觰닲致菶鳸雺跼课爀専䐄㼆㴈㰊㤌", a_), global::CommonResources.AcgResources.ID_CAIDATAMAXTXATTEMPTS, null, null, 0, 1);
					this.cnvWideASTRODataMaxTxAttempts_A8474.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvWideASTRODataMaxTxAttempts_A8474.DataTransferOrder = 20;
					this.cnvWideASTRODataMaxTxAttempts_A8474.ShowHexValue = false;
					num = (short)1566507012;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔雖諘迚远郞ꗠ苢釤蛦뷨鏪ꇬ蛮鳰髲致鋶鷸꯺鳼课栀昂欄搆氈堊栌氎丐划Ⱄ∖ⴘ⼚", a_)))
					{
						num = (short)205062161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_503;
				case 39:
					this.cnvWideASTRODataTxShortRandomRangeMs_A9565 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔雖諘迚远郞ꗠ苢釤蛦뷨鏪뻬蟮黰臲致ꗶ飸闺駼郾氀儂搄椆済渊䀌簎丐划Ⱄ∖⼘⸚", a_), global::CommonResources.AcgResources.ID_TXSHORTRANDOMRANGEMS, null, null, 0, 50);
					this.cnvWideASTRODataTxShortRandomRangeMs_A9565.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvWideASTRODataTxShortRandomRangeMs_A9565.DataTransferOrder = 18;
					this.cnvWideASTRODataTxShortRandomRangeMs_A9565.ShowHexValue = false;
					num = (short)674299915;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_CE:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1583611932;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_F5:
				num = (short)684064793;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_145:
				num = (short)1782775828;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_330:
				num = (short)335740936;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_44F:
				num = (short)26673164;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_503:
				num = (short)1452933127;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5B1:
				num = (short)1643642896;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5FE:
				num = (short)695599140;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_70D:
				num = (short)1440677917;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_83D:
				num = (short)410779663;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_88A:
				num = (short)498204705;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8D9:
				num = (short)1496121382;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_99F:
				num = (short)755892243;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4FE:
			IL_A54:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("裈飊駌鷎黐釔뛖귘뫚", a_);
			base.Id = 10058;
			base.UIName = global::CommonResources.AcgResources.ID_ASTRODATA;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600B376 RID: 45942 RVA: 0x00A685C8 File Offset: 0x00A667C8
		public override void PopulateReferences()
		{
			short num = (short)554827776;
			short num2 = num;
			num = (short)444379111;
			short num3 = num;
			num = (short)91795431;
			switch (num3 == num)
			{
			}
			num = (short)458948608;
			if (num != 0)
			{
			}
			num = (short)2122514433;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B377 RID: 45943 RVA: 0x00A68670 File Offset: 0x00A66870
		public override void DropReferences()
		{
			short num = (short)1403977728;
			short num2 = num;
			num = (short)621555387;
			short num3 = num;
			num = (short)562245307;
			switch (num3 == num)
			{
			}
			num = (short)1827602432;
			if (num != 0)
			{
			}
			num = (short)977469441;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B378 RID: 45944 RVA: 0x00A68718 File Offset: 0x00A66918
		public override void SetConstraints()
		{
			short num = (short)414253056;
			short num2 = num;
			num = (short)616644150;
			short num3 = num;
			num = (short)1634745910;
			switch (num3 == num)
			{
			}
			num = (short)477888513;
			if (num != 0)
			{
			}
			num = (short)1969946624;
			if (num != 0)
			{
			}
			this.cnvWideASTRODataARPCacheTimehrs_A7464.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideConstraints.conARPCacheDepthNotZero);
			this.cnvWideConventionalCustomerID_41558.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideConstraints.ConTacticalInhibitEnabled);
		}

		// Token: 0x0600B379 RID: 45945 RVA: 0x00A687EC File Offset: 0x00A669EC
		public override void SetupDependencies()
		{
			short num = (short)1020002304;
			short num2 = num;
			num = (short)1081922625;
			short num3 = num;
			num = (short)369153089;
			switch (num3 == num)
			{
			}
			num = (short)1874001920;
			if (num != 0)
			{
			}
			num = (short)457375745;
			if (num != 0)
			{
			}
			this.cnvWideASTRODataARPCacheDepth_A7463.AddDependentObject(this.cnvWideASTRODataARPCacheTimehrs_A7464);
			this.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.AddDependentObject(this.cnvWideConventionalCustomerID_41558);
		}

		// Token: 0x170059F7 RID: 23031
		// (get) Token: 0x0600B37A RID: 45946 RVA: 0x00A688C4 File Offset: 0x00A66AC4
		public bool HasDiffs
		{
			get
			{
				short num = (short)1160052736;
				short num2 = num;
				num = (short)2036988952;
				short num3 = num;
				num = (short)576125976;
				switch (num3 == num)
				{
				}
				num = (short)112066560;
				if (num != 0)
				{
				}
				num = (short)1098448897;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170059F8 RID: 23032
		// (get) Token: 0x0600B37B RID: 45947 RVA: 0x00A68974 File Offset: 0x00A66B74
		// (set) Token: 0x0600B37C RID: 45948 RVA: 0x00A68A30 File Offset: 0x00A66C30
		public int CnvWideASTRODataARPCacheDepth_A7463Value
		{
			get
			{
				short num = (short)1811349504;
				short num2 = num;
				num = (short)1282777155;
				short num3 = num;
				num = (short)507551811;
				switch (num3 == num)
				{
				}
				num = (short)1476919297;
				if (num != 0)
				{
				}
				num = (short)1926692864;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheDepth_A7463.Value;
			}
			set
			{
				short num = (short)1309868032;
				short num2 = num;
				num = (short)184569645;
				short num3 = num;
				num = (short)974868269;
				switch (num3 == num)
				{
				}
				num = (short)1656487936;
				if (num != 0)
				{
				}
				num = (short)646578177;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataARPCacheDepth_A7463.Value = value;
			}
		}

		// Token: 0x170059F9 RID: 23033
		// (get) Token: 0x0600B37D RID: 45949 RVA: 0x00A68AEC File Offset: 0x00A66CEC
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvWideASTRODataARPCacheDepth_A7463
		{
			get
			{
				short num = (short)2142175232;
				short num2 = num;
				num = (short)171517308;
				short num3 = num;
				num = (short)1286743420;
				switch (num3 == num)
				{
				}
				num = (short)2016411648;
				if (num != 0)
				{
				}
				num = (short)15597569;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheDepth_A7463;
			}
		}

		// Token: 0x170059FA RID: 23034
		// (get) Token: 0x0600B37E RID: 45950 RVA: 0x00A68B9C File Offset: 0x00A66D9C
		// (set) Token: 0x0600B37F RID: 45951 RVA: 0x00A68C50 File Offset: 0x00A66E50
		public string CnvWideASTRODataARPCacheDepth_A7463_UIValue
		{
			get
			{
				short num = (short)1183645696;
				short num2 = num;
				num = (short)1930630991;
				short num3 = num;
				num = (short)1907955535;
				switch (num3 == num)
				{
				}
				num = (short)1334706177;
				if (num != 0)
				{
				}
				num = (short)1663762432;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheDepth_A7463.UIValue;
			}
			set
			{
				short num = (short)574881792;
				short num2 = num;
				num = (short)1836770925;
				short num3 = num;
				num = (short)307816045;
				switch (num3 == num)
				{
				}
				num = (short)850067457;
				if (num != 0)
				{
				}
				num = (short)194117632;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataARPCacheDepth_A7463.UIValue = value;
			}
		}

		// Token: 0x170059FB RID: 23035
		// (get) Token: 0x0600B380 RID: 45952 RVA: 0x00A68D04 File Offset: 0x00A66F04
		// (set) Token: 0x0600B381 RID: 45953 RVA: 0x00A68DBC File Offset: 0x00A66FBC
		internal int CnvWideASTRODataARPCacheDepth_A7463Min
		{
			get
			{
				short num = (short)1149501440;
				short num2 = num;
				num = (short)1192789879;
				short num3 = num;
				num = (short)1689225079;
				switch (num3 == num)
				{
				}
				num = (short)1708064769;
				if (num != 0)
				{
				}
				num = (short)1254883328;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheDepth_A7463.Min;
			}
			set
			{
				short num = (short)821755904;
				short num2 = num;
				num = (short)48163487;
				short num3 = num;
				num = (short)850193055;
				switch (num3 == num)
				{
				}
				num = (short)796459009;
				if (num != 0)
				{
				}
				num = (short)425918464;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataARPCacheDepth_A7463.Min = value;
			}
		}

		// Token: 0x170059FC RID: 23036
		// (get) Token: 0x0600B382 RID: 45954 RVA: 0x00A68E70 File Offset: 0x00A67070
		// (set) Token: 0x0600B383 RID: 45955 RVA: 0x00A68F24 File Offset: 0x00A67124
		internal int CnvWideASTRODataARPCacheDepth_A7463Max
		{
			get
			{
				short num = (short)2098200576;
				short num2 = num;
				num = (short)148504577;
				if (num != 0)
				{
				}
				num = (short)1886407182;
				short num3 = num;
				num = (short)637487630;
				switch (num3 == num)
				{
				}
				num = (short)1380384768;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheDepth_A7463.Max;
			}
			set
			{
				short num = (short)1493237760;
				short num2 = num;
				num = (short)831214388;
				short num3 = num;
				num = (short)267277108;
				switch (num3 == num)
				{
				}
				num = (short)1087438849;
				if (num != 0)
				{
				}
				num = (short)1251540992;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataARPCacheDepth_A7463.Max = value;
			}
		}

		// Token: 0x170059FD RID: 23037
		// (get) Token: 0x0600B384 RID: 45956 RVA: 0x00A68FDC File Offset: 0x00A671DC
		// (set) Token: 0x0600B385 RID: 45957 RVA: 0x00A69090 File Offset: 0x00A67290
		internal int CnvWideASTRODataARPCacheDepth_A7463Step
		{
			get
			{
				short num = (short)1409613824;
				short num2 = num;
				num = (short)969605121;
				if (num != 0)
				{
				}
				num = (short)703364234;
				short num3 = num;
				num = (short)652311690;
				switch (num3 == num)
				{
				}
				num = (short)208666624;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheDepth_A7463.StepSize;
			}
			set
			{
				short num = (short)1487929344;
				short num2 = num;
				num = (short)842479264;
				short num3 = num;
				num = (short)1695102624;
				switch (num3 == num)
				{
				}
				num = (short)1111752705;
				if (num != 0)
				{
				}
				num = (short)41680896;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataARPCacheDepth_A7463.StepSize = value;
			}
		}

		// Token: 0x170059FE RID: 23038
		// (get) Token: 0x0600B386 RID: 45958 RVA: 0x00A69144 File Offset: 0x00A67344
		// (set) Token: 0x0600B387 RID: 45959 RVA: 0x00A691FC File Offset: 0x00A673FC
		public bool CnvWideASTRODataARPCacheDepth_A7463_Applicable
		{
			get
			{
				short num = (short)1699807232;
				short num2 = num;
				num = (short)1904552028;
				short num3 = num;
				num = (short)323233884;
				switch (num3 == num)
				{
				}
				num = (short)123863040;
				if (num != 0)
				{
				}
				num = (short)1267138561;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheDepth_A7463.Applicable;
			}
			set
			{
				short num = (short)1912274944;
				short num2 = num;
				num = (short)1530331137;
				if (num != 0)
				{
				}
				num = (short)2087332933;
				short num3 = num;
				num = (short)1271540805;
				switch (num3 == num)
				{
				}
				num = (short)970784768;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataARPCacheDepth_A7463.Applicable = value;
			}
		}

		// Token: 0x170059FF RID: 23039
		// (get) Token: 0x0600B388 RID: 45960 RVA: 0x00A692B4 File Offset: 0x00A674B4
		// (set) Token: 0x0600B389 RID: 45961 RVA: 0x00A69368 File Offset: 0x00A67568
		public bool CnvWideASTRODataARPCacheDepth_A7463_Valid
		{
			get
			{
				short num = (short)1175453696;
				short num2 = num;
				num = (short)957886551;
				short num3 = num;
				num = (short)1269117015;
				switch (num3 == num)
				{
				}
				num = (short)379846656;
				if (num != 0)
				{
				}
				num = (short)1480392705;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheDepth_A7463.Valid;
			}
			set
			{
				short num = (short)1276837888;
				short num2 = num;
				num = (short)328001394;
				short num3 = num;
				num = (short)1352984434;
				switch (num3 == num)
				{
				}
				num = (short)617152512;
				if (num != 0)
				{
				}
				num = (short)1799421953;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataARPCacheDepth_A7463.Valid = value;
			}
		}

		// Token: 0x17005A00 RID: 23040
		// (get) Token: 0x0600B38A RID: 45962 RVA: 0x00A69420 File Offset: 0x00A67620
		// (set) Token: 0x0600B38B RID: 45963 RVA: 0x00A694D4 File Offset: 0x00A676D4
		public bool CnvWideASTRODataARPCacheDepth_A7463_Visible
		{
			get
			{
				short num = (short)1295515648;
				short num2 = num;
				num = (short)713853992;
				short num3 = num;
				num = (short)236817448;
				switch (num3 == num)
				{
				}
				num = (short)375717888;
				if (num != 0)
				{
				}
				num = (short)630456321;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheDepth_A7463.Visible;
			}
			set
			{
				short num = (short)758906880;
				short num2 = num;
				num = (short)1476332555;
				short num3 = num;
				num = (short)1601506315;
				switch (num3 == num)
				{
				}
				num = (short)878116864;
				if (num != 0)
				{
				}
				num = (short)905183233;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataARPCacheDepth_A7463.Visible = value;
			}
		}

		// Token: 0x17005A01 RID: 23041
		// (get) Token: 0x0600B38C RID: 45964 RVA: 0x00A69588 File Offset: 0x00A67788
		// (set) Token: 0x0600B38D RID: 45965 RVA: 0x00A6963C File Offset: 0x00A6783C
		public bool CnvWideASTRODataARPCacheDepth_A7463_Editable
		{
			get
			{
				short num = (short)903872512;
				short num2 = num;
				num = (short)1475956121;
				short num3 = num;
				num = (short)843468185;
				switch (num3 == num)
				{
				}
				num = (short)2060058625;
				if (num != 0)
				{
				}
				num = (short)1201537024;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheDepth_A7463.Editable;
			}
			set
			{
				short num = (short)87490560;
				short num2 = num;
				num = (short)810423630;
				short num3 = num;
				num = (short)1213011278;
				switch (num3 == num)
				{
				}
				num = (short)1440546816;
				if (num != 0)
				{
				}
				num = (short)581828609;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataARPCacheDepth_A7463.Editable = value;
			}
		}

		// Token: 0x17005A02 RID: 23042
		// (get) Token: 0x0600B38E RID: 45966 RVA: 0x00A696F0 File Offset: 0x00A678F0
		internal string CnvWideASTRODataARPCacheDepth_A7463_UILabel
		{
			get
			{
				short num = (short)615645184;
				short num2 = num;
				num = (short)2051448138;
				short num3 = num;
				num = (short)1605803338;
				switch (num3 == num)
				{
				}
				num = (short)161284097;
				if (num != 0)
				{
				}
				num = (short)2015821824;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheDepth_A7463.UIName;
			}
		}

		// Token: 0x17005A03 RID: 23043
		// (get) Token: 0x0600B38F RID: 45967 RVA: 0x00A697A4 File Offset: 0x00A679A4
		// (set) Token: 0x0600B390 RID: 45968 RVA: 0x00A6985C File Offset: 0x00A67A5C
		internal bool CnvWideASTRODataARPCacheDepth_A7463_HiddenStatic
		{
			get
			{
				short num = (short)616431616;
				short num2 = num;
				num = (short)956709859;
				short num3 = num;
				num = (short)807877603;
				switch (num3 == num)
				{
				}
				num = (short)1760231424;
				if (num != 0)
				{
				}
				num = (short)1953497089;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheDepth_A7463.HiddenStatic;
			}
			set
			{
				short num = (short)941555712;
				short num2 = num;
				num = (short)578847774;
				short num3 = num;
				num = (short)8160286;
				switch (num3 == num)
				{
				}
				num = (short)786366464;
				if (num != 0)
				{
				}
				num = (short)440795137;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataARPCacheDepth_A7463.HiddenStatic = value;
			}
		}

		// Token: 0x17005A04 RID: 23044
		// (get) Token: 0x0600B391 RID: 45969 RVA: 0x00A69910 File Offset: 0x00A67B10
		// (set) Token: 0x0600B392 RID: 45970 RVA: 0x00A699C4 File Offset: 0x00A67BC4
		internal bool CnvWideASTRODataARPCacheDepth_A7463_HiddenDynamic
		{
			get
			{
				short num = (short)1968308224;
				short num2 = num;
				num = (short)1920110005;
				short num3 = num;
				num = (short)92442037;
				switch (num3 == num)
				{
				}
				num = (short)1891762176;
				if (num != 0)
				{
				}
				num = (short)1186988033;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheDepth_A7463.HiddenDynamic;
			}
			set
			{
				short num = (short)366936064;
				short num2 = num;
				num = (short)691361254;
				short num3 = num;
				num = (short)618354150;
				switch (num3 == num)
				{
				}
				num = (short)660537345;
				if (num != 0)
				{
				}
				num = (short)724303872;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataARPCacheDepth_A7463.HiddenDynamic = value;
			}
		}

		// Token: 0x17005A05 RID: 23045
		// (get) Token: 0x0600B393 RID: 45971 RVA: 0x00A69A78 File Offset: 0x00A67C78
		public bool CnvWideASTRODataARPCacheDepth_A7463_HasDiffs
		{
			get
			{
				short num = (short)468910080;
				short num2 = num;
				num = (short)1360513095;
				short num3 = num;
				num = (short)631490631;
				switch (num3 == num)
				{
				}
				num = (short)498401280;
				if (num != 0)
				{
				}
				num = (short)666501121;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheDepth_A7463._HasDiffs;
			}
		}

		// Token: 0x17005A06 RID: 23046
		// (get) Token: 0x0600B394 RID: 45972 RVA: 0x00A69B30 File Offset: 0x00A67D30
		// (set) Token: 0x0600B395 RID: 45973 RVA: 0x00A69BE4 File Offset: 0x00A67DE4
		public int CnvWideASTRODataARPCacheTimehrs_A7464Value
		{
			get
			{
				short num = (short)292618240;
				short num2 = num;
				num = (short)656867329;
				if (num != 0)
				{
				}
				num = (short)1947197255;
				short num3 = num;
				num = (short)462937927;
				switch (num3 == num)
				{
				}
				num = (short)811794432;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheTimehrs_A7464.Value;
			}
			set
			{
				short num = (short)840695808;
				short num2 = num;
				num = (short)1677608037;
				short num3 = num;
				num = (short)1000883301;
				switch (num3 == num)
				{
				}
				num = (short)691011585;
				if (num != 0)
				{
				}
				num = (short)842072064;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataARPCacheTimehrs_A7464.Value = value;
			}
		}

		// Token: 0x17005A07 RID: 23047
		// (get) Token: 0x0600B396 RID: 45974 RVA: 0x00A69C98 File Offset: 0x00A67E98
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvWideASTRODataARPCacheTimehrs_A7464
		{
			get
			{
				short num = (short)471662592;
				short num2 = num;
				num = (short)99125312;
				short num3 = num;
				num = (short)1837729856;
				switch (num3 == num)
				{
				}
				num = (short)658243585;
				if (num != 0)
				{
				}
				num = (short)1689714688;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheTimehrs_A7464;
			}
		}

		// Token: 0x17005A08 RID: 23048
		// (get) Token: 0x0600B397 RID: 45975 RVA: 0x00A69D4C File Offset: 0x00A67F4C
		// (set) Token: 0x0600B398 RID: 45976 RVA: 0x00A69E00 File Offset: 0x00A68000
		public string CnvWideASTRODataARPCacheTimehrs_A7464_UIValue
		{
			get
			{
				short num = (short)1718026240;
				short num2 = num;
				num = (short)926461184;
				short num3 = num;
				num = (short)2084220160;
				switch (num3 == num)
				{
				}
				num = (short)1630076929;
				if (num != 0)
				{
				}
				num = (short)1552285696;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheTimehrs_A7464.UIValue;
			}
			set
			{
				short num = (short)1827143680;
				short num2 = num;
				num = (short)1934652161;
				short num3 = num;
				num = (short)1156346625;
				switch (num3 == num)
				{
				}
				num = (short)1107165185;
				if (num != 0)
				{
				}
				num = (short)1076887552;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataARPCacheTimehrs_A7464.UIValue = value;
			}
		}

		// Token: 0x17005A09 RID: 23049
		// (get) Token: 0x0600B399 RID: 45977 RVA: 0x00A69EB8 File Offset: 0x00A680B8
		// (set) Token: 0x0600B39A RID: 45978 RVA: 0x00A69F6C File Offset: 0x00A6816C
		internal int CnvWideASTRODataARPCacheTimehrs_A7464Min
		{
			get
			{
				short num = (short)1088618496;
				short num2 = num;
				num = (short)782565377;
				if (num != 0)
				{
				}
				num = (short)431266100;
				short num3 = num;
				num = (short)2104465716;
				switch (num3 == num)
				{
				}
				num = (short)1768882176;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheTimehrs_A7464.Min;
			}
			set
			{
				short num = (short)1591869440;
				short num2 = num;
				num = (short)1575486621;
				short num3 = num;
				num = (short)316015773;
				switch (num3 == num)
				{
				}
				num = (short)1031077889;
				if (num != 0)
				{
				}
				num = (short)1549336576;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataARPCacheTimehrs_A7464.Min = value;
			}
		}

		// Token: 0x17005A0A RID: 23050
		// (get) Token: 0x0600B39B RID: 45979 RVA: 0x00A6A024 File Offset: 0x00A68224
		// (set) Token: 0x0600B39C RID: 45980 RVA: 0x00A6A0D8 File Offset: 0x00A682D8
		internal int CnvWideASTRODataARPCacheTimehrs_A7464Max
		{
			get
			{
				short num = (short)2138243072;
				short num2 = num;
				num = (short)177740850;
				short num3 = num;
				num = (short)1002380338;
				switch (num3 == num)
				{
				}
				num = (short)606208000;
				if (num != 0)
				{
				}
				num = (short)1456799745;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheTimehrs_A7464.Max;
			}
			set
			{
				short num = (short)400883712;
				short num2 = num;
				num = (short)608642235;
				short num3 = num;
				num = (short)735978683;
				switch (num3 == num)
				{
				}
				num = (short)756416513;
				if (num != 0)
				{
				}
				num = (short)1456537600;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataARPCacheTimehrs_A7464.Max = value;
			}
		}

		// Token: 0x17005A0B RID: 23051
		// (get) Token: 0x0600B39D RID: 45981 RVA: 0x00A6A190 File Offset: 0x00A68390
		// (set) Token: 0x0600B39E RID: 45982 RVA: 0x00A6A244 File Offset: 0x00A68444
		internal int CnvWideASTRODataARPCacheTimehrs_A7464Step
		{
			get
			{
				short num = (short)1695350784;
				short num2 = num;
				num = (short)1305554633;
				short num3 = num;
				num = (short)757149385;
				switch (num3 == num)
				{
				}
				num = (short)1055981569;
				if (num != 0)
				{
				}
				num = (short)289865728;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheTimehrs_A7464.StepSize;
			}
			set
			{
				short num = (short)452240936;
				short num2 = num;
				num = (short)997041704;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1235615744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)938213377;
				if (num != 0)
				{
				}
				num = (short)28901376;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataARPCacheTimehrs_A7464.StepSize = value;
			}
		}

		// Token: 0x17005A0C RID: 23052
		// (get) Token: 0x0600B39F RID: 45983 RVA: 0x00A6A2F8 File Offset: 0x00A684F8
		// (set) Token: 0x0600B3A0 RID: 45984 RVA: 0x00A6A3AC File Offset: 0x00A685AC
		public bool CnvWideASTRODataARPCacheTimehrs_A7464_Applicable
		{
			get
			{
				short num = (short)1633034718;
				short num2 = num;
				num = (short)1711612382;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1439629312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1327431681;
				if (num != 0)
				{
				}
				num = (short)136708096;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheTimehrs_A7464.Applicable;
			}
			set
			{
				short num = (short)1247903275;
				short num2 = num;
				num = (short)550796843;
				switch (num2 == num)
				{
				default:
				{
					num = (short)390660096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1178927104;
				if (num != 0)
				{
				}
				num = (short)1133903873;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataARPCacheTimehrs_A7464.Applicable = value;
			}
		}

		// Token: 0x17005A0D RID: 23053
		// (get) Token: 0x0600B3A1 RID: 45985 RVA: 0x00A6A464 File Offset: 0x00A68664
		// (set) Token: 0x0600B3A2 RID: 45986 RVA: 0x00A6A518 File Offset: 0x00A68718
		public bool CnvWideASTRODataARPCacheTimehrs_A7464_Valid
		{
			get
			{
				short num = (short)1719276257;
				short num2 = num;
				num = (short)1034949345;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1935015936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1700724736;
				if (num != 0)
				{
				}
				num = (short)1683226625;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheTimehrs_A7464.Valid;
			}
			set
			{
				short num = (short)1885902265;
				short num2 = num;
				num = (short)622564793;
				switch (num2 == num)
				{
				default:
				{
					num = (short)410648576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1771962369;
				if (num != 0)
				{
				}
				num = (short)1973223424;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataARPCacheTimehrs_A7464.Valid = value;
			}
		}

		// Token: 0x17005A0E RID: 23054
		// (get) Token: 0x0600B3A3 RID: 45987 RVA: 0x00A6A5CC File Offset: 0x00A687CC
		// (set) Token: 0x0600B3A4 RID: 45988 RVA: 0x00A6A680 File Offset: 0x00A68880
		public bool CnvWideASTRODataARPCacheTimehrs_A7464_Visible
		{
			get
			{
				short num = (short)378370088;
				short num2 = num;
				num = (short)509507624;
				switch (num2 == num)
				{
				default:
				{
					num = (short)322043904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1606352896;
				if (num != 0)
				{
				}
				num = (short)1811021825;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheTimehrs_A7464.Visible;
			}
			set
			{
				short num = (short)638433505;
				short num2 = num;
				num = (short)1306245345;
				switch (num2 == num)
				{
				default:
				{
					num = (short)873070592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)747372544;
				if (num != 0)
				{
				}
				num = (short)1221918721;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataARPCacheTimehrs_A7464.Visible = value;
			}
		}

		// Token: 0x17005A0F RID: 23055
		// (get) Token: 0x0600B3A5 RID: 45989 RVA: 0x00A6A734 File Offset: 0x00A68934
		// (set) Token: 0x0600B3A6 RID: 45990 RVA: 0x00A6A7E8 File Offset: 0x00A689E8
		public bool CnvWideASTRODataARPCacheTimehrs_A7464_Editable
		{
			get
			{
				short num = (short)436680253;
				short num2 = num;
				num = (short)992491069;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1019805696;
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
				num = (short)687538176;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheTimehrs_A7464.Editable;
			}
			set
			{
				short num = (short)1119962472;
				short num2 = num;
				num = (short)950355304;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2038038528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2089746433;
				if (num != 0)
				{
				}
				num = (short)53936128;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataARPCacheTimehrs_A7464.Editable = value;
			}
		}

		// Token: 0x17005A10 RID: 23056
		// (get) Token: 0x0600B3A7 RID: 45991 RVA: 0x00A6A89C File Offset: 0x00A68A9C
		internal string CnvWideASTRODataARPCacheTimehrs_A7464_UILabel
		{
			get
			{
				short num = (short)1529534576;
				short num2 = num;
				num = (short)38721648;
				switch (num2 == num)
				{
				default:
				{
					num = (short)986054656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)958464000;
				if (num != 0)
				{
				}
				num = (short)1614479361;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheTimehrs_A7464.UIName;
			}
		}

		// Token: 0x17005A11 RID: 23057
		// (get) Token: 0x0600B3A8 RID: 45992 RVA: 0x00A6A950 File Offset: 0x00A68B50
		// (set) Token: 0x0600B3A9 RID: 45993 RVA: 0x00A6AA04 File Offset: 0x00A68C04
		internal bool CnvWideASTRODataARPCacheTimehrs_A7464_HiddenStatic
		{
			get
			{
				short num = (short)1252524033;
				if (num != 0)
				{
				}
				num = (short)1293615104;
				short num2 = num;
				num = (short)1151996001;
				short num3 = num;
				num = (short)2096894049;
				switch (num3 == num)
				{
				}
				num = (short)1472004096;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheTimehrs_A7464.HiddenStatic;
			}
			set
			{
				short num = (short)1870332785;
				short num2 = num;
				num = (short)1680147313;
				switch (num2 == num)
				{
				default:
				{
					num = (short)871759872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)331153409;
				if (num != 0)
				{
				}
				num = (short)1459552256;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataARPCacheTimehrs_A7464.HiddenStatic = value;
			}
		}

		// Token: 0x17005A12 RID: 23058
		// (get) Token: 0x0600B3AA RID: 45994 RVA: 0x00A6AABC File Offset: 0x00A68CBC
		// (set) Token: 0x0600B3AB RID: 45995 RVA: 0x00A6AB70 File Offset: 0x00A68D70
		internal bool CnvWideASTRODataARPCacheTimehrs_A7464_HiddenDynamic
		{
			get
			{
				short num = (short)97976321;
				if (num != 0)
				{
				}
				num = (short)129957888;
				short num2 = num;
				num = (short)823238507;
				short num3 = num;
				num = (short)1864540011;
				switch (num3 == num)
				{
				}
				num = (short)1432092672;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheTimehrs_A7464.HiddenDynamic;
			}
			set
			{
				short num = (short)2096496641;
				if (num != 0)
				{
				}
				num = (short)1799553024;
				short num2 = num;
				num = (short)656268471;
				short num3 = num;
				num = (short)1575214263;
				switch (num3 == num)
				{
				}
				num = (short)654508032;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataARPCacheTimehrs_A7464.HiddenDynamic = value;
			}
		}

		// Token: 0x17005A13 RID: 23059
		// (get) Token: 0x0600B3AC RID: 45996 RVA: 0x00A6AC24 File Offset: 0x00A68E24
		public bool CnvWideASTRODataARPCacheTimehrs_A7464_HasDiffs
		{
			get
			{
				short num = (short)2067953098;
				short num2 = num;
				num = (short)1263695306;
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
				num = (short)634060801;
				if (num != 0)
				{
				}
				num = (short)1196097536;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataARPCacheTimehrs_A7464._HasDiffs;
			}
		}

		// Token: 0x17005A14 RID: 23060
		// (get) Token: 0x0600B3AD RID: 45997 RVA: 0x00A6ACD8 File Offset: 0x00A68ED8
		// (set) Token: 0x0600B3AE RID: 45998 RVA: 0x00A6AD8C File Offset: 0x00A68F8C
		public int CnvWideASTRODataFrameSyncSeekPeriodms_A8145Value
		{
			get
			{
				short num = (short)112108508;
				short num2 = num;
				num = (short)1148036060;
				switch (num2 == num)
				{
				default:
				{
					num = (short)879493120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)655097857;
				if (num != 0)
				{
				}
				num = (short)1845952512;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.Value;
			}
			set
			{
				short num = (short)1053876514;
				short num2 = num;
				num = (short)1273880866;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1820131328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)904658945;
				if (num != 0)
				{
				}
				num = (short)784400384;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.Value = value;
			}
		}

		// Token: 0x17005A15 RID: 23061
		// (get) Token: 0x0600B3AF RID: 45999 RVA: 0x00A6AE40 File Offset: 0x00A69040
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvWideASTRODataFrameSyncSeekPeriodms_A8145
		{
			get
			{
				short num = (short)617425127;
				short num2 = num;
				num = (short)172501223;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1608908800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1773928449;
				if (num != 0)
				{
				}
				num = (short)895811584;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145;
			}
		}

		// Token: 0x17005A16 RID: 23062
		// (get) Token: 0x0600B3B0 RID: 46000 RVA: 0x00A6AEF0 File Offset: 0x00A690F0
		// (set) Token: 0x0600B3B1 RID: 46001 RVA: 0x00A6AFA0 File Offset: 0x00A691A0
		public string CnvWideASTRODataFrameSyncSeekPeriodms_A8145_UIValue
		{
			get
			{
				short num = (short)112211702;
				short num2 = num;
				num = (short)1030764278;
				switch (num2 == num)
				{
				default:
				{
					num = (short)616693760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1819934721;
				if (num != 0)
				{
				}
				num = (short)1056374784;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.UIValue;
			}
			set
			{
				short num = (short)2048311348;
				short num2 = num;
				num = (short)1951055924;
				switch (num2 == num)
				{
				default:
				{
					num = (short)675020800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)429981696;
				if (num != 0)
				{
				}
				num = (short)108986369;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.UIValue = value;
			}
		}

		// Token: 0x17005A17 RID: 23063
		// (get) Token: 0x0600B3B2 RID: 46002 RVA: 0x00A6B054 File Offset: 0x00A69254
		// (set) Token: 0x0600B3B3 RID: 46003 RVA: 0x00A6B108 File Offset: 0x00A69308
		internal int CnvWideASTRODataFrameSyncSeekPeriodms_A8145Min
		{
			get
			{
				short num = (short)1666325541;
				short num2 = num;
				num = (short)474422309;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1859977216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)734265345;
				if (num != 0)
				{
				}
				num = (short)215810048;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.Min;
			}
			set
			{
				short num = (short)1096810497;
				if (num != 0)
				{
				}
				num = (short)1076297728;
				short num2 = num;
				num = (short)922599799;
				short num3 = num;
				num = (short)10797431;
				switch (num3 == num)
				{
				}
				num = (short)1624506368;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.Min = value;
			}
		}

		// Token: 0x17005A18 RID: 23064
		// (get) Token: 0x0600B3B4 RID: 46004 RVA: 0x00A6B1C0 File Offset: 0x00A693C0
		// (set) Token: 0x0600B3B5 RID: 46005 RVA: 0x00A6B274 File Offset: 0x00A69474
		internal int CnvWideASTRODataFrameSyncSeekPeriodms_A8145Max
		{
			get
			{
				short num = (short)1671352214;
				short num2 = num;
				num = (short)513920918;
				switch (num2 == num)
				{
				default:
				{
					num = (short)942145536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1844248577;
				if (num != 0)
				{
				}
				num = (short)1667432448;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.Max;
			}
			set
			{
				short num = (short)560549640;
				short num2 = num;
				num = (short)477712136;
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
				num = (short)973733889;
				if (num != 0)
				{
				}
				num = (short)579534848;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.Max = value;
			}
		}

		// Token: 0x17005A19 RID: 23065
		// (get) Token: 0x0600B3B6 RID: 46006 RVA: 0x00A6B328 File Offset: 0x00A69528
		// (set) Token: 0x0600B3B7 RID: 46007 RVA: 0x00A6B3DC File Offset: 0x00A695DC
		internal int CnvWideASTRODataFrameSyncSeekPeriodms_A8145Step
		{
			get
			{
				short num = (short)1919092517;
				short num2 = num;
				num = (short)1467287333;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1567227904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2107441153;
				if (num != 0)
				{
				}
				num = (short)1586167808;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.StepSize;
			}
			set
			{
				short num = (short)909443073;
				if (num != 0)
				{
				}
				num = (short)862846976;
				short num2 = num;
				num = (short)190726930;
				short num3 = num;
				num = (short)124863250;
				switch (num3 == num)
				{
				}
				num = (short)1026228224;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.StepSize = value;
			}
		}

		// Token: 0x17005A1A RID: 23066
		// (get) Token: 0x0600B3B8 RID: 46008 RVA: 0x00A6B494 File Offset: 0x00A69694
		// (set) Token: 0x0600B3B9 RID: 46009 RVA: 0x00A6B548 File Offset: 0x00A69748
		public bool CnvWideASTRODataFrameSyncSeekPeriodms_A8145_Applicable
		{
			get
			{
				short num = (short)1167286879;
				short num2 = num;
				num = (short)1239048799;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1011154944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)684392448;
				if (num != 0)
				{
				}
				num = (short)99352577;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.Applicable;
			}
			set
			{
				short num = (short)1296538894;
				short num2 = num;
				num = (short)1804377358;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1441464320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1490747392;
				if (num != 0)
				{
				}
				num = (short)340459521;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.Applicable = value;
			}
		}

		// Token: 0x17005A1B RID: 23067
		// (get) Token: 0x0600B3BA RID: 46010 RVA: 0x00A6B5FC File Offset: 0x00A697FC
		// (set) Token: 0x0600B3BB RID: 46011 RVA: 0x00A6B6B0 File Offset: 0x00A698B0
		public bool CnvWideASTRODataFrameSyncSeekPeriodms_A8145_Valid
		{
			get
			{
				short num = (short)2054086707;
				short num2 = num;
				num = (short)1757601843;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1091305472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)735969281;
				if (num != 0)
				{
				}
				num = (short)1722875904;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.Valid;
			}
			set
			{
				short num = (short)1416029014;
				short num2 = num;
				num = (short)1156375382;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2033385472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1584857088;
				if (num != 0)
				{
				}
				num = (short)2066087937;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.Valid = value;
			}
		}

		// Token: 0x17005A1C RID: 23068
		// (get) Token: 0x0600B3BC RID: 46012 RVA: 0x00A6B768 File Offset: 0x00A69968
		// (set) Token: 0x0600B3BD RID: 46013 RVA: 0x00A6B81C File Offset: 0x00A69A1C
		public bool CnvWideASTRODataFrameSyncSeekPeriodms_A8145_Visible
		{
			get
			{
				short num = (short)60436995;
				short num2 = num;
				num = (short)1414541827;
				switch (num2 == num)
				{
				default:
				{
					num = (short)727842816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1907687425;
				if (num != 0)
				{
				}
				num = (short)1170931712;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.Visible;
			}
			set
			{
				short num = (short)299892737;
				if (num != 0)
				{
				}
				num = (short)50200576;
				short num2 = num;
				num = (short)477236266;
				short num3 = num;
				num = (short)1393101866;
				switch (num3 == num)
				{
				}
				num = (short)248315904;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.Visible = value;
			}
		}

		// Token: 0x17005A1D RID: 23069
		// (get) Token: 0x0600B3BE RID: 46014 RVA: 0x00A6B8D0 File Offset: 0x00A69AD0
		// (set) Token: 0x0600B3BF RID: 46015 RVA: 0x00A6B984 File Offset: 0x00A69B84
		public bool CnvWideASTRODataFrameSyncSeekPeriodms_A8145_Editable
		{
			get
			{
				short num = (short)586614666;
				short num2 = num;
				num = (short)410191754;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1026818048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)763494400;
				if (num != 0)
				{
				}
				num = (short)785973249;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.Editable;
			}
			set
			{
				short num = (short)544670093;
				short num2 = num;
				num = (short)601883021;
				switch (num2 == num)
				{
				default:
				{
					num = (short)901120000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2146959361;
				if (num != 0)
				{
				}
				num = (short)1040973824;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.Editable = value;
			}
		}

		// Token: 0x17005A1E RID: 23070
		// (get) Token: 0x0600B3C0 RID: 46016 RVA: 0x00A6BA38 File Offset: 0x00A69C38
		internal string CnvWideASTRODataFrameSyncSeekPeriodms_A8145_UILabel
		{
			get
			{
				short num = (short)546128202;
				short num2 = num;
				num = (short)1261781322;
				switch (num2 == num)
				{
				default:
				{
					num = (short)395378688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1306263553;
				if (num != 0)
				{
				}
				num = (short)2097610752;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.UIName;
			}
		}

		// Token: 0x17005A1F RID: 23071
		// (get) Token: 0x0600B3C1 RID: 46017 RVA: 0x00A6BAEC File Offset: 0x00A69CEC
		// (set) Token: 0x0600B3C2 RID: 46018 RVA: 0x00A6BBA4 File Offset: 0x00A69DA4
		internal bool CnvWideASTRODataFrameSyncSeekPeriodms_A8145_HiddenStatic
		{
			get
			{
				short num = (short)1234135625;
				short num2 = num;
				num = (short)578447945;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1872560128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)772603905;
				if (num != 0)
				{
				}
				num = (short)1270546432;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.HiddenStatic;
			}
			set
			{
				short num = (short)1775930848;
				short num2 = num;
				num = (short)668110304;
				switch (num2 == num)
				{
				default:
				{
					num = (short)673316864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)960626688;
				if (num != 0)
				{
				}
				num = (short)29360129;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.HiddenStatic = value;
			}
		}

		// Token: 0x17005A20 RID: 23072
		// (get) Token: 0x0600B3C3 RID: 46019 RVA: 0x00A6BC58 File Offset: 0x00A69E58
		// (set) Token: 0x0600B3C4 RID: 46020 RVA: 0x00A6BD10 File Offset: 0x00A69F10
		internal bool CnvWideASTRODataFrameSyncSeekPeriodms_A8145_HiddenDynamic
		{
			get
			{
				short num = (short)1835219640;
				short num2 = num;
				num = (short)1084242616;
				switch (num2 == num)
				{
				default:
				{
					num = (short)60162048;
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
				num = (short)430047232;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.HiddenDynamic;
			}
			set
			{
				short num = (short)1641185172;
				short num2 = num;
				num = (short)1832288148;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2079064064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)124321793;
				if (num != 0)
				{
				}
				num = (short)1098252288;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145.HiddenDynamic = value;
			}
		}

		// Token: 0x17005A21 RID: 23073
		// (get) Token: 0x0600B3C5 RID: 46021 RVA: 0x00A6BDC8 File Offset: 0x00A69FC8
		public bool CnvWideASTRODataFrameSyncSeekPeriodms_A8145_HasDiffs
		{
			get
			{
				short num = (short)1809786145;
				short num2 = num;
				num = (short)7677217;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1836908544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)270467073;
				if (num != 0)
				{
				}
				num = (short)1735196672;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataFrameSyncSeekPeriodms_A8145._HasDiffs;
			}
		}

		// Token: 0x17005A22 RID: 23074
		// (get) Token: 0x0600B3C6 RID: 46022 RVA: 0x00A6BE80 File Offset: 0x00A6A080
		// (set) Token: 0x0600B3C7 RID: 46023 RVA: 0x00A6BF38 File Offset: 0x00A6A138
		public int CnvWideASTRODataTxLimitedPatienceSec_A9544Value
		{
			get
			{
				short num = (short)221118465;
				if (num != 0)
				{
				}
				num = (short)1992228864;
				short num2 = num;
				num = (short)1424130817;
				short num3 = num;
				num = (short)98534145;
				switch (num3 == num)
				{
				}
				num = (short)2114650112;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLimitedPatienceSec_A9544.Value;
			}
			set
			{
				short num = (short)1384336864;
				short num2 = num;
				num = (short)654265824;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1905721344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)370671617;
				if (num != 0)
				{
				}
				num = (short)1455685632;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxLimitedPatienceSec_A9544.Value = value;
			}
		}

		// Token: 0x17005A23 RID: 23075
		// (get) Token: 0x0600B3C8 RID: 46024 RVA: 0x00A6BFF0 File Offset: 0x00A6A1F0
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvWideASTRODataTxLimitedPatienceSec_A9544
		{
			get
			{
				short num = (short)882788428;
				short num2 = num;
				num = (short)933906508;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1835466752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)12451840;
				if (num != 0)
				{
				}
				num = (short)1259732993;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLimitedPatienceSec_A9544;
			}
		}

		// Token: 0x17005A24 RID: 23076
		// (get) Token: 0x0600B3C9 RID: 46025 RVA: 0x00A6C0A4 File Offset: 0x00A6A2A4
		// (set) Token: 0x0600B3CA RID: 46026 RVA: 0x00A6C158 File Offset: 0x00A6A358
		public string CnvWideASTRODataTxLimitedPatienceSec_A9544_UIValue
		{
			get
			{
				short num = (short)567508342;
				short num2 = num;
				num = (short)186482038;
				switch (num2 == num)
				{
				default:
				{
					num = (short)383909888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1598423040;
				if (num != 0)
				{
				}
				num = (short)1741553665;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLimitedPatienceSec_A9544.UIValue;
			}
			set
			{
				short num = (short)2085599206;
				short num2 = num;
				num = (short)1872017382;
				switch (num2 == num)
				{
				default:
				{
					num = (short)453115904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1392050176;
				if (num != 0)
				{
				}
				num = (short)1135476737;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxLimitedPatienceSec_A9544.UIValue = value;
			}
		}

		// Token: 0x17005A25 RID: 23077
		// (get) Token: 0x0600B3CB RID: 46027 RVA: 0x00A6C210 File Offset: 0x00A6A410
		// (set) Token: 0x0600B3CC RID: 46028 RVA: 0x00A6C2C4 File Offset: 0x00A6A4C4
		internal int CnvWideASTRODataTxLimitedPatienceSec_A9544Min
		{
			get
			{
				short num = (short)1087232982;
				short num2 = num;
				num = (short)1935465430;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1319043072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)748355585;
				if (num != 0)
				{
				}
				num = (short)1538523136;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLimitedPatienceSec_A9544.Min;
			}
			set
			{
				short num = (short)1771676921;
				short num2 = num;
				num = (short)257139961;
				switch (num2 == num)
				{
				default:
				{
					num = (short)605749248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1169162241;
				if (num != 0)
				{
				}
				num = (short)51707904;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxLimitedPatienceSec_A9544.Min = value;
			}
		}

		// Token: 0x17005A26 RID: 23078
		// (get) Token: 0x0600B3CD RID: 46029 RVA: 0x00A6C378 File Offset: 0x00A6A578
		// (set) Token: 0x0600B3CE RID: 46030 RVA: 0x00A6C430 File Offset: 0x00A6A630
		internal int CnvWideASTRODataTxLimitedPatienceSec_A9544Max
		{
			get
			{
				short num = (short)1193913225;
				short num2 = num;
				num = (short)1646635913;
				switch (num2 == num)
				{
				default:
				{
					num = (short)898957312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1173028865;
				if (num != 0)
				{
				}
				num = (short)476119040;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLimitedPatienceSec_A9544.Max;
			}
			set
			{
				short num = (short)1247164213;
				short num2 = num;
				num = (short)1117140789;
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
				num = (short)341704705;
				if (num != 0)
				{
				}
				num = (short)371851264;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxLimitedPatienceSec_A9544.Max = value;
			}
		}

		// Token: 0x17005A27 RID: 23079
		// (get) Token: 0x0600B3CF RID: 46031 RVA: 0x00A6C4E8 File Offset: 0x00A6A6E8
		// (set) Token: 0x0600B3D0 RID: 46032 RVA: 0x00A6C5A0 File Offset: 0x00A6A7A0
		internal int CnvWideASTRODataTxLimitedPatienceSec_A9544Step
		{
			get
			{
				short num = (short)1708379941;
				short num2 = num;
				num = (short)1617940261;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1673461760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)39780353;
				if (num != 0)
				{
				}
				num = (short)1548156928;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLimitedPatienceSec_A9544.StepSize;
			}
			set
			{
				short num = (short)729921554;
				short num2 = num;
				num = (short)548845586;
				switch (num2 == num)
				{
				default:
				{
					num = (short)179568640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1094713345;
				if (num != 0)
				{
				}
				num = (short)1009516544;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxLimitedPatienceSec_A9544.StepSize = value;
			}
		}

		// Token: 0x17005A28 RID: 23080
		// (get) Token: 0x0600B3D1 RID: 46033 RVA: 0x00A6C658 File Offset: 0x00A6A858
		// (set) Token: 0x0600B3D2 RID: 46034 RVA: 0x00A6C708 File Offset: 0x00A6A908
		public bool CnvWideASTRODataTxLimitedPatienceSec_A9544_Applicable
		{
			get
			{
				short num = (short)1502862261;
				short num2 = num;
				num = (short)138468277;
				switch (num2 == num)
				{
				default:
				{
					num = (short)504168448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1830879232;
				if (num != 0)
				{
				}
				num = (short)2039218177;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLimitedPatienceSec_A9544.Applicable;
			}
			set
			{
				short num = (short)1735451963;
				short num2 = num;
				num = (short)630515003;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2065825792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1580990465;
				if (num != 0)
				{
				}
				num = (short)1017446400;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxLimitedPatienceSec_A9544.Applicable = value;
			}
		}

		// Token: 0x17005A29 RID: 23081
		// (get) Token: 0x0600B3D3 RID: 46035 RVA: 0x00A6C7BC File Offset: 0x00A6A9BC
		// (set) Token: 0x0600B3D4 RID: 46036 RVA: 0x00A6C874 File Offset: 0x00A6AA74
		public bool CnvWideASTRODataTxLimitedPatienceSec_A9544_Valid
		{
			get
			{
				short num = (short)2516102;
				short num2 = num;
				num = (short)496460934;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1373831168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1358102529;
				if (num != 0)
				{
				}
				num = (short)591986688;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLimitedPatienceSec_A9544.Valid;
			}
			set
			{
				short num = (short)322310819;
				short num2 = num;
				num = (short)1045697187;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1087307776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1837498369;
				if (num != 0)
				{
				}
				num = (short)2108030976;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxLimitedPatienceSec_A9544.Valid = value;
			}
		}

		// Token: 0x17005A2A RID: 23082
		// (get) Token: 0x0600B3D5 RID: 46037 RVA: 0x00A6C928 File Offset: 0x00A6AB28
		// (set) Token: 0x0600B3D6 RID: 46038 RVA: 0x00A6C9E0 File Offset: 0x00A6ABE0
		public bool CnvWideASTRODataTxLimitedPatienceSec_A9544_Visible
		{
			get
			{
				short num = (short)1425335473;
				short num2 = num;
				num = (short)548725937;
				switch (num2 == num)
				{
				default:
				{
					num = (short)265814016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)643563521;
				if (num != 0)
				{
				}
				num = (short)2014314496;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLimitedPatienceSec_A9544.Visible;
			}
			set
			{
				short num = (short)59179009;
				if (num != 0)
				{
				}
				num = (short)1714770504;
				short num2 = num;
				num = (short)720196168;
				switch (num2 == num)
				{
				}
				num = (short)2075787264;
				short num3 = num;
				num = (short)496107520;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxLimitedPatienceSec_A9544.Visible = value;
			}
		}

		// Token: 0x17005A2B RID: 23083
		// (get) Token: 0x0600B3D7 RID: 46039 RVA: 0x00A6CA98 File Offset: 0x00A6AC98
		// (set) Token: 0x0600B3D8 RID: 46040 RVA: 0x00A6CB50 File Offset: 0x00A6AD50
		public bool CnvWideASTRODataTxLimitedPatienceSec_A9544_Editable
		{
			get
			{
				short num = (short)138489634;
				short num2 = num;
				num = (short)1264463650;
				switch (num2 == num)
				{
				}
				num = (short)457572353;
				if (num != 0)
				{
				}
				num = (short)453050368;
				short num3 = num;
				num = (short)258539520;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLimitedPatienceSec_A9544.Editable;
			}
			set
			{
				short num = (short)6753211;
				short num2 = num;
				num = (short)1683033019;
				switch (num2 == num)
				{
				}
				num = (short)650444801;
				if (num != 0)
				{
				}
				num = (short)2096562176;
				short num3 = num;
				num = (short)429916160;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxLimitedPatienceSec_A9544.Editable = value;
			}
		}

		// Token: 0x17005A2C RID: 23084
		// (get) Token: 0x0600B3D9 RID: 46041 RVA: 0x00A6CC0C File Offset: 0x00A6AE0C
		internal string CnvWideASTRODataTxLimitedPatienceSec_A9544_UILabel
		{
			get
			{
				short num = (short)1391219367;
				short num2 = num;
				num = (short)292311719;
				switch (num2 == num)
				{
				}
				num = (short)832045057;
				if (num != 0)
				{
				}
				num = (short)905576448;
				short num3 = num;
				num = (short)170459136;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLimitedPatienceSec_A9544.UIName;
			}
		}

		// Token: 0x17005A2D RID: 23085
		// (get) Token: 0x0600B3DA RID: 46042 RVA: 0x00A6CCC0 File Offset: 0x00A6AEC0
		// (set) Token: 0x0600B3DB RID: 46043 RVA: 0x00A6CD74 File Offset: 0x00A6AF74
		internal bool CnvWideASTRODataTxLimitedPatienceSec_A9544_HiddenStatic
		{
			get
			{
				short num = (short)2095251457;
				if (num != 0)
				{
				}
				num = (short)799675849;
				short num2 = num;
				num = (short)404035017;
				switch (num2 == num)
				{
				}
				num = (short)1332084736;
				short num3 = num;
				num = (short)1796014080;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLimitedPatienceSec_A9544.HiddenStatic;
			}
			set
			{
				short num = (short)1888033746;
				short num2 = num;
				num = (short)2046368722;
				switch (num2 == num)
				{
				}
				num = (short)1923153921;
				if (num != 0)
				{
				}
				num = (short)277872640;
				short num3 = num;
				num = (short)463863808;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxLimitedPatienceSec_A9544.HiddenStatic = value;
			}
		}

		// Token: 0x17005A2E RID: 23086
		// (get) Token: 0x0600B3DC RID: 46044 RVA: 0x00A6CE28 File Offset: 0x00A6B028
		// (set) Token: 0x0600B3DD RID: 46045 RVA: 0x00A6CEE0 File Offset: 0x00A6B0E0
		internal bool CnvWideASTRODataTxLimitedPatienceSec_A9544_HiddenDynamic
		{
			get
			{
				short num = (short)714888714;
				short num2 = num;
				num = (short)786978314;
				switch (num2 == num)
				{
				}
				num = (short)1836515329;
				if (num != 0)
				{
				}
				num = (short)2141454336;
				short num3 = num;
				num = (short)280494080;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLimitedPatienceSec_A9544.HiddenDynamic;
			}
			set
			{
				short num = (short)1362977298;
				short num2 = num;
				num = (short)1922261522;
				switch (num2 == num)
				{
				}
				num = (short)1356464129;
				if (num != 0)
				{
				}
				num = (short)1582628864;
				short num3 = num;
				num = (short)219938816;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxLimitedPatienceSec_A9544.HiddenDynamic = value;
			}
		}

		// Token: 0x17005A2F RID: 23087
		// (get) Token: 0x0600B3DE RID: 46046 RVA: 0x00A6CF98 File Offset: 0x00A6B198
		public bool CnvWideASTRODataTxLimitedPatienceSec_A9544_HasDiffs
		{
			get
			{
				short num = (short)26345473;
				if (num != 0)
				{
				}
				num = (short)1216652909;
				short num2 = num;
				num = (short)1517004397;
				switch (num2 == num)
				{
				}
				num = (short)1881604096;
				short num3 = num;
				num = (short)760872960;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLimitedPatienceSec_A9544._HasDiffs;
			}
		}

		// Token: 0x17005A30 RID: 23088
		// (get) Token: 0x0600B3DF RID: 46047 RVA: 0x00A6D050 File Offset: 0x00A6B250
		// (set) Token: 0x0600B3E0 RID: 46048 RVA: 0x00A6D104 File Offset: 0x00A6B304
		public int CnvWideASTRODataMaxTxAttempts_A8474Value
		{
			get
			{
				short num = (short)1289158657;
				if (num != 0)
				{
				}
				num = (short)61670455;
				short num2 = num;
				num = (short)626983991;
				switch (num2 == num)
				{
				}
				num = (short)101449728;
				short num3 = num;
				num = (short)1028980736;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxTxAttempts_A8474.Value;
			}
			set
			{
				short num = (short)493222886;
				short num2 = num;
				num = (short)1528888294;
				switch (num2 == num)
				{
				}
				num = (short)1872625665;
				if (num != 0)
				{
				}
				num = (short)100925440;
				short num3 = num;
				num = (short)149356544;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMaxTxAttempts_A8474.Value = value;
			}
		}

		// Token: 0x17005A31 RID: 23089
		// (get) Token: 0x0600B3E1 RID: 46049 RVA: 0x00A6D1BC File Offset: 0x00A6B3BC
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvWideASTRODataMaxTxAttempts_A8474
		{
			get
			{
				short num = (short)1546952157;
				short num2 = num;
				num = (short)50896349;
				switch (num2 == num)
				{
				}
				num = (short)1758265344;
				if (num != 0)
				{
				}
				num = (short)2025717760;
				short num3 = num;
				num = (short)1134231553;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxTxAttempts_A8474;
			}
		}

		// Token: 0x17005A32 RID: 23090
		// (get) Token: 0x0600B3E2 RID: 46050 RVA: 0x00A6D26C File Offset: 0x00A6B46C
		// (set) Token: 0x0600B3E3 RID: 46051 RVA: 0x00A6D324 File Offset: 0x00A6B524
		public string CnvWideASTRODataMaxTxAttempts_A8474_UIValue
		{
			get
			{
				short num = (short)464165741;
				short num2 = num;
				num = (short)1629199213;
				switch (num2 == num)
				{
				}
				num = (short)1842348032;
				if (num != 0)
				{
				}
				num = (short)1218314240;
				short num3 = num;
				num = (short)242614273;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxTxAttempts_A8474.UIValue;
			}
			set
			{
				short num = (short)1966738305;
				short num2 = num;
				num = (short)1322519425;
				switch (num2 == num)
				{
				}
				num = (short)1987641345;
				if (num != 0)
				{
				}
				num = (short)1175060480;
				short num3 = num;
				num = (short)325124096;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMaxTxAttempts_A8474.UIValue = value;
			}
		}

		// Token: 0x17005A33 RID: 23091
		// (get) Token: 0x0600B3E4 RID: 46052 RVA: 0x00A6D3D8 File Offset: 0x00A6B5D8
		// (set) Token: 0x0600B3E5 RID: 46053 RVA: 0x00A6D48C File Offset: 0x00A6B68C
		internal int CnvWideASTRODataMaxTxAttempts_A8474Min
		{
			get
			{
				short num = (short)346232315;
				short num2 = num;
				num = (short)91756027;
				switch (num2 == num)
				{
				}
				num = (short)465895425;
				if (num != 0)
				{
				}
				num = (short)1081999360;
				short num3 = num;
				num = (short)2090860544;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxTxAttempts_A8474.Min;
			}
			set
			{
				short num = (short)1533257321;
				short num2 = num;
				num = (short)1370465897;
				switch (num2 == num)
				{
				}
				num = (short)396951553;
				if (num != 0)
				{
				}
				num = (short)1409220608;
				short num3 = num;
				num = (short)99614720;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMaxTxAttempts_A8474.Min = value;
			}
		}

		// Token: 0x17005A34 RID: 23092
		// (get) Token: 0x0600B3E6 RID: 46054 RVA: 0x00A6D540 File Offset: 0x00A6B740
		// (set) Token: 0x0600B3E7 RID: 46055 RVA: 0x00A6D5F8 File Offset: 0x00A6B7F8
		internal int CnvWideASTRODataMaxTxAttempts_A8474Max
		{
			get
			{
				short num = (short)495823187;
				short num2 = num;
				num = (short)1206954323;
				switch (num2 == num)
				{
				}
				num = (short)1042743297;
				if (num != 0)
				{
				}
				num = (short)502661120;
				short num3 = num;
				num = (short)1038548992;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxTxAttempts_A8474.Max;
			}
			set
			{
				short num = (short)1988170197;
				short num2 = num;
				num = (short)944247253;
				switch (num2 == num)
				{
				}
				num = (short)1271988225;
				if (num != 0)
				{
				}
				num = (short)1364393984;
				short num3 = num;
				num = (short)988545024;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMaxTxAttempts_A8474.Max = value;
			}
		}

		// Token: 0x17005A35 RID: 23093
		// (get) Token: 0x0600B3E8 RID: 46056 RVA: 0x00A6D6AC File Offset: 0x00A6B8AC
		// (set) Token: 0x0600B3E9 RID: 46057 RVA: 0x00A6D75C File Offset: 0x00A6B95C
		internal int CnvWideASTRODataMaxTxAttempts_A8474Step
		{
			get
			{
				short num = (short)1155218738;
				short num2 = num;
				num = (short)1654471986;
				switch (num2 == num)
				{
				}
				num = (short)1708130304;
				if (num != 0)
				{
				}
				num = (short)1533280256;
				short num3 = num;
				num = (short)637272065;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxTxAttempts_A8474.StepSize;
			}
			set
			{
				short num = (short)1370017349;
				short num2 = num;
				num = (short)1275711045;
				switch (num2 == num)
				{
				}
				num = (short)364642305;
				if (num != 0)
				{
				}
				num = (short)687996928;
				short num3 = num;
				num = (short)1306656768;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMaxTxAttempts_A8474.StepSize = value;
			}
		}

		// Token: 0x17005A36 RID: 23094
		// (get) Token: 0x0600B3EA RID: 46058 RVA: 0x00A6D814 File Offset: 0x00A6BA14
		// (set) Token: 0x0600B3EB RID: 46059 RVA: 0x00A6D8CC File Offset: 0x00A6BACC
		public bool CnvWideASTRODataMaxTxAttempts_A8474_Applicable
		{
			get
			{
				short num = (short)1703573802;
				short num2 = num;
				num = (short)475298090;
				switch (num2 == num)
				{
				}
				num = (short)847446017;
				if (num != 0)
				{
				}
				num = (short)530120704;
				short num3 = num;
				num = (short)1387266048;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxTxAttempts_A8474.Applicable;
			}
			set
			{
				short num = (short)825774623;
				short num2 = num;
				num = (short)1575113247;
				switch (num2 == num)
				{
				}
				num = (short)615448577;
				if (num != 0)
				{
				}
				num = (short)1690501120;
				short num3 = num;
				num = (short)1330970624;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMaxTxAttempts_A8474.Applicable = value;
			}
		}

		// Token: 0x17005A37 RID: 23095
		// (get) Token: 0x0600B3EC RID: 46060 RVA: 0x00A6D980 File Offset: 0x00A6BB80
		// (set) Token: 0x0600B3ED RID: 46061 RVA: 0x00A6DA34 File Offset: 0x00A6BC34
		public bool CnvWideASTRODataMaxTxAttempts_A8474_Valid
		{
			get
			{
				short num = (short)1101174561;
				short num2 = num;
				num = (short)1860409121;
				switch (num2 == num)
				{
				}
				num = (short)1087700992;
				if (num != 0)
				{
				}
				num = (short)931266560;
				short num3 = num;
				num = (short)2112880641;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxTxAttempts_A8474.Valid;
			}
			set
			{
				short num = (short)2012687183;
				short num2 = num;
				num = (short)553986895;
				switch (num2 == num)
				{
				}
				num = (short)644349952;
				if (num != 0)
				{
				}
				num = (short)402456576;
				short num3 = num;
				num = (short)998506497;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMaxTxAttempts_A8474.Valid = value;
			}
		}

		// Token: 0x17005A38 RID: 23096
		// (get) Token: 0x0600B3EE RID: 46062 RVA: 0x00A6DAEC File Offset: 0x00A6BCEC
		// (set) Token: 0x0600B3EF RID: 46063 RVA: 0x00A6DBA8 File Offset: 0x00A6BDA8
		public bool CnvWideASTRODataMaxTxAttempts_A8474_Visible
		{
			get
			{
				short num = (short)252747288;
				short num2 = num;
				num = (short)2146868760;
				switch (num2 == num)
				{
				}
				num = (short)1103691776;
				if (num != 0)
				{
				}
				num = (short)2120417280;
				short num3 = num;
				num = (short)196542465;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxTxAttempts_A8474.Visible;
			}
			set
			{
				short num = (short)1075033813;
				short num2 = num;
				num = (short)448116437;
				switch (num2 == num)
				{
				}
				num = (short)706674689;
				if (num != 0)
				{
				}
				num = (short)1643970560;
				short num3 = num;
				num = (short)386007040;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMaxTxAttempts_A8474.Visible = value;
			}
		}

		// Token: 0x17005A39 RID: 23097
		// (get) Token: 0x0600B3F0 RID: 46064 RVA: 0x00A6DC60 File Offset: 0x00A6BE60
		// (set) Token: 0x0600B3F1 RID: 46065 RVA: 0x00A6DD18 File Offset: 0x00A6BF18
		public bool CnvWideASTRODataMaxTxAttempts_A8474_Editable
		{
			get
			{
				short num = (short)291333593;
				short num2 = num;
				num = (short)382035417;
				switch (num2 == num)
				{
				}
				num = (short)1570177025;
				if (num != 0)
				{
				}
				num = (short)2050752512;
				short num3 = num;
				num = (short)968425472;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxTxAttempts_A8474.Editable;
			}
			set
			{
				short num = (short)49352973;
				short num2 = num;
				num = (short)1115820301;
				switch (num2 == num)
				{
				}
				num = (short)249626625;
				if (num != 0)
				{
				}
				num = (short)813891584;
				short num3 = num;
				num = (short)1492975616;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMaxTxAttempts_A8474.Editable = value;
			}
		}

		// Token: 0x17005A3A RID: 23098
		// (get) Token: 0x0600B3F2 RID: 46066 RVA: 0x00A6DDCC File Offset: 0x00A6BFCC
		internal string CnvWideASTRODataMaxTxAttempts_A8474_UILabel
		{
			get
			{
				short num = (short)451226436;
				short num2 = num;
				num = (short)279194436;
				switch (num2 == num)
				{
				}
				num = (short)716111873;
				if (num != 0)
				{
				}
				num = (short)1392050176;
				short num3 = num;
				num = (short)920977408;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxTxAttempts_A8474.UIName;
			}
		}

		// Token: 0x17005A3B RID: 23099
		// (get) Token: 0x0600B3F3 RID: 46067 RVA: 0x00A6DE80 File Offset: 0x00A6C080
		// (set) Token: 0x0600B3F4 RID: 46068 RVA: 0x00A6DF34 File Offset: 0x00A6C134
		internal bool CnvWideASTRODataMaxTxAttempts_A8474_HiddenStatic
		{
			get
			{
				short num = (short)6444621;
				short num2 = num;
				num = (short)1118656077;
				switch (num2 == num)
				{
				}
				num = (short)1655308289;
				if (num != 0)
				{
				}
				num = (short)659030016;
				short num3 = num;
				num = (short)227540992;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxTxAttempts_A8474.HiddenStatic;
			}
			set
			{
				short num = (short)343549678;
				short num2 = num;
				num = (short)1205217006;
				switch (num2 == num)
				{
				}
				num = (short)1057226753;
				if (num != 0)
				{
				}
				num = (short)863830016;
				short num3 = num;
				num = (short)1241448448;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMaxTxAttempts_A8474.HiddenStatic = value;
			}
		}

		// Token: 0x17005A3C RID: 23100
		// (get) Token: 0x0600B3F5 RID: 46069 RVA: 0x00A6DFE8 File Offset: 0x00A6C1E8
		// (set) Token: 0x0600B3F6 RID: 46070 RVA: 0x00A6E09C File Offset: 0x00A6C29C
		internal bool CnvWideASTRODataMaxTxAttempts_A8474_HiddenDynamic
		{
			get
			{
				short num = (short)1348444932;
				short num2 = num;
				num = (short)1899143940;
				switch (num2 == num)
				{
				}
				num = (short)506003457;
				if (num != 0)
				{
				}
				num = (short)1856241664;
				short num3 = num;
				num = (short)684326912;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxTxAttempts_A8474.HiddenDynamic;
			}
			set
			{
				short num = (short)1149042689;
				if (num != 0)
				{
				}
				num = (short)459337450;
				short num2 = num;
				num = (short)708833002;
				switch (num2 == num)
				{
				}
				num = (short)1720385536;
				short num3 = num;
				num = (short)1096482816;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMaxTxAttempts_A8474.HiddenDynamic = value;
			}
		}

		// Token: 0x17005A3D RID: 23101
		// (get) Token: 0x0600B3F7 RID: 46071 RVA: 0x00A6E154 File Offset: 0x00A6C354
		public bool CnvWideASTRODataMaxTxAttempts_A8474_HasDiffs
		{
			get
			{
				short num = (short)1040342168;
				short num2 = num;
				num = (short)77487256;
				switch (num2 == num)
				{
				}
				num = (short)485294081;
				if (num != 0)
				{
				}
				num = (short)961871872;
				short num3 = num;
				num = (short)601358336;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxTxAttempts_A8474._HasDiffs;
			}
		}

		// Token: 0x17005A3E RID: 23102
		// (get) Token: 0x0600B3F8 RID: 46072 RVA: 0x00A6E20C File Offset: 0x00A6C40C
		// (set) Token: 0x0600B3F9 RID: 46073 RVA: 0x00A6E2C0 File Offset: 0x00A6C4C0
		public int CnvWideASTRODataMinResponseTimerms_A8514Value
		{
			get
			{
				short num = (short)2045253633;
				short num2 = num;
				num = (short)313268225;
				switch (num2 == num)
				{
				}
				num = (short)1581514753;
				if (num != 0)
				{
				}
				num = (short)1560150016;
				short num3 = num;
				num = (short)1300103168;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMinResponseTimerms_A8514.Value;
			}
			set
			{
				short num = (short)595680957;
				short num2 = num;
				num = (short)425352893;
				switch (num2 == num)
				{
				}
				num = (short)905117697;
				if (num != 0)
				{
				}
				num = (short)1680932864;
				short num3 = num;
				num = (short)2107179008;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMinResponseTimerms_A8514.Value = value;
			}
		}

		// Token: 0x17005A3F RID: 23103
		// (get) Token: 0x0600B3FA RID: 46074 RVA: 0x00A6E374 File Offset: 0x00A6C574
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvWideASTRODataMinResponseTimerms_A8514
		{
			get
			{
				short num = (short)990850812;
				short num2 = num;
				num = (short)1432301308;
				switch (num2 == num)
				{
				}
				num = (short)979435520;
				if (num != 0)
				{
				}
				num = (short)1366294528;
				short num3 = num;
				num = (short)1054277633;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMinResponseTimerms_A8514;
			}
		}

		// Token: 0x17005A40 RID: 23104
		// (get) Token: 0x0600B3FB RID: 46075 RVA: 0x00A6E424 File Offset: 0x00A6C624
		// (set) Token: 0x0600B3FC RID: 46076 RVA: 0x00A6E4D8 File Offset: 0x00A6C6D8
		public string CnvWideASTRODataMinResponseTimerms_A8514_UIValue
		{
			get
			{
				short num = (short)363605228;
				short num2 = num;
				num = (short)1853566188;
				switch (num2 == num)
				{
				}
				num = (short)34013185;
				if (num != 0)
				{
				}
				num = (short)164691968;
				short num3 = num;
				num = (short)791216128;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMinResponseTimerms_A8514.UIValue;
			}
			set
			{
				short num = (short)1368788823;
				short num2 = num;
				num = (short)1602948951;
				switch (num2 == num)
				{
				}
				num = (short)753926145;
				if (num != 0)
				{
				}
				num = (short)1116995584;
				short num3 = num;
				num = (short)1476395008;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMinResponseTimerms_A8514.UIValue = value;
			}
		}

		// Token: 0x17005A41 RID: 23105
		// (get) Token: 0x0600B3FD RID: 46077 RVA: 0x00A6E590 File Offset: 0x00A6C790
		// (set) Token: 0x0600B3FE RID: 46078 RVA: 0x00A6E644 File Offset: 0x00A6C844
		internal int CnvWideASTRODataMinResponseTimerms_A8514Min
		{
			get
			{
				short num = (short)880961327;
				short num2 = num;
				num = (short)727672623;
				switch (num2 == num)
				{
				}
				num = (short)403767296;
				if (num != 0)
				{
				}
				num = (short)1548943360;
				short num3 = num;
				num = (short)307101697;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMinResponseTimerms_A8514.Min;
			}
			set
			{
				short num = (short)1331099606;
				short num2 = num;
				num = (short)364443606;
				switch (num2 == num)
				{
				}
				num = (short)1019346944;
				if (num != 0)
				{
				}
				num = (short)2046033920;
				short num3 = num;
				num = (short)997654529;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMinResponseTimerms_A8514.Min = value;
			}
		}

		// Token: 0x17005A42 RID: 23106
		// (get) Token: 0x0600B3FF RID: 46079 RVA: 0x00A6E6FC File Offset: 0x00A6C8FC
		// (set) Token: 0x0600B400 RID: 46080 RVA: 0x00A6E7B0 File Offset: 0x00A6C9B0
		internal int CnvWideASTRODataMinResponseTimerms_A8514Max
		{
			get
			{
				short num = (short)332457530;
				short num2 = num;
				num = (short)883942970;
				switch (num2 == num)
				{
				}
				num = (short)1453195265;
				if (num != 0)
				{
				}
				num = (short)426115072;
				short num3 = num;
				num = (short)230752256;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMinResponseTimerms_A8514.Max;
			}
			set
			{
				short num = (short)2121389833;
				short num2 = num;
				num = (short)1212733193;
				switch (num2 == num)
				{
				}
				num = (short)616235009;
				if (num != 0)
				{
				}
				num = (short)148897792;
				short num3 = num;
				num = (short)1525874688;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMinResponseTimerms_A8514.Max = value;
			}
		}

		// Token: 0x17005A43 RID: 23107
		// (get) Token: 0x0600B401 RID: 46081 RVA: 0x00A6E864 File Offset: 0x00A6CA64
		// (set) Token: 0x0600B402 RID: 46082 RVA: 0x00A6E918 File Offset: 0x00A6CB18
		internal int CnvWideASTRODataMinResponseTimerms_A8514Step
		{
			get
			{
				short num = (short)200192943;
				short num2 = num;
				num = (short)565490607;
				switch (num2 == num)
				{
				}
				num = (short)2126381056;
				if (num != 0)
				{
				}
				num = (short)1154875392;
				short num3 = num;
				num = (short)1630994433;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMinResponseTimerms_A8514.StepSize;
			}
			set
			{
				short num = (short)662298607;
				short num2 = num;
				num = (short)319086575;
				switch (num2 == num)
				{
				}
				num = (short)709361665;
				if (num != 0)
				{
				}
				num = (short)243138560;
				short num3 = num;
				num = (short)836173824;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMinResponseTimerms_A8514.StepSize = value;
			}
		}

		// Token: 0x17005A44 RID: 23108
		// (get) Token: 0x0600B403 RID: 46083 RVA: 0x00A6E9CC File Offset: 0x00A6CBCC
		// (set) Token: 0x0600B404 RID: 46084 RVA: 0x00A6EA80 File Offset: 0x00A6CC80
		public bool CnvWideASTRODataMinResponseTimerms_A8514_Applicable
		{
			get
			{
				short num = (short)1575749403;
				short num2 = num;
				num = (short)79103771;
				switch (num2 == num)
				{
				}
				num = (short)22609921;
				if (num != 0)
				{
				}
				num = (short)2068185088;
				short num3 = num;
				num = (short)23724032;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMinResponseTimerms_A8514.Applicable;
			}
			set
			{
				short num = (short)674369563;
				short num2 = num;
				num = (short)533467163;
				switch (num2 == num)
				{
				}
				num = (short)222035968;
				if (num != 0)
				{
				}
				num = (short)86048768;
				short num3 = num;
				num = (short)1320484865;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMinResponseTimerms_A8514.Applicable = value;
			}
		}

		// Token: 0x17005A45 RID: 23109
		// (get) Token: 0x0600B405 RID: 46085 RVA: 0x00A6EB38 File Offset: 0x00A6CD38
		// (set) Token: 0x0600B406 RID: 46086 RVA: 0x00A6EBEC File Offset: 0x00A6CDEC
		public bool CnvWideASTRODataMinResponseTimerms_A8514_Valid
		{
			get
			{
				short num = (short)1128147892;
				short num2 = num;
				num = (short)423701428;
				switch (num2 == num)
				{
				}
				num = (short)1691222017;
				if (num != 0)
				{
				}
				num = (short)649723904;
				short num3 = num;
				num = (short)1768423424;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMinResponseTimerms_A8514.Valid;
			}
			set
			{
				short num = (short)421378345;
				short num2 = num;
				num = (short)1130281257;
				switch (num2 == num)
				{
				}
				num = (short)1240727552;
				if (num != 0)
				{
				}
				num = (short)1075445760;
				short num3 = num;
				num = (short)1602355201;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMinResponseTimerms_A8514.Valid = value;
			}
		}

		// Token: 0x17005A46 RID: 23110
		// (get) Token: 0x0600B407 RID: 46087 RVA: 0x00A6ECA4 File Offset: 0x00A6CEA4
		// (set) Token: 0x0600B408 RID: 46088 RVA: 0x00A6ED58 File Offset: 0x00A6CF58
		public bool CnvWideASTRODataMinResponseTimerms_A8514_Visible
		{
			get
			{
				short num = (short)438505896;
				short num2 = num;
				num = (short)947655080;
				switch (num2 == num)
				{
				}
				num = (short)1612775425;
				if (num != 0)
				{
				}
				num = (short)1043922944;
				short num3 = num;
				num = (short)1786904576;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMinResponseTimerms_A8514.Visible;
			}
			set
			{
				short num = (short)663630434;
				short num2 = num;
				num = (short)880751202;
				switch (num2 == num)
				{
				}
				num = (short)1132462081;
				if (num != 0)
				{
				}
				num = (short)948436992;
				short num3 = num;
				num = (short)1576534016;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMinResponseTimerms_A8514.Visible = value;
			}
		}

		// Token: 0x17005A47 RID: 23111
		// (get) Token: 0x0600B409 RID: 46089 RVA: 0x00A6EE0C File Offset: 0x00A6D00C
		// (set) Token: 0x0600B40A RID: 46090 RVA: 0x00A6EEC0 File Offset: 0x00A6D0C0
		public bool CnvWideASTRODataMinResponseTimerms_A8514_Editable
		{
			get
			{
				short num = (short)738263041;
				if (num != 0)
				{
				}
				num = (short)668914534;
				short num2 = num;
				num = (short)1529205606;
				switch (num2 == num)
				{
				}
				num = (short)796852224;
				short num3 = num;
				num = (short)327352320;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMinResponseTimerms_A8514.Editable;
			}
			set
			{
				short num = (short)1690642259;
				short num2 = num;
				num = (short)1607346003;
				switch (num2 == num)
				{
				}
				num = (short)2103312385;
				if (num != 0)
				{
				}
				num = (short)645398528;
				short num3 = num;
				num = (short)1558511616;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMinResponseTimerms_A8514.Editable = value;
			}
		}

		// Token: 0x17005A48 RID: 23112
		// (get) Token: 0x0600B40B RID: 46091 RVA: 0x00A6EF74 File Offset: 0x00A6D174
		internal string CnvWideASTRODataMinResponseTimerms_A8514_UILabel
		{
			get
			{
				short num = (short)45219841;
				if (num != 0)
				{
				}
				num = (short)1136018526;
				short num2 = num;
				num = (short)1938572382;
				switch (num2 == num)
				{
				}
				num = (short)1362034688;
				short num3 = num;
				num = (short)90636288;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMinResponseTimerms_A8514.UIName;
			}
		}

		// Token: 0x17005A49 RID: 23113
		// (get) Token: 0x0600B40C RID: 46092 RVA: 0x00A6F028 File Offset: 0x00A6D228
		// (set) Token: 0x0600B40D RID: 46093 RVA: 0x00A6F0DC File Offset: 0x00A6D2DC
		internal bool CnvWideASTRODataMinResponseTimerms_A8514_HiddenStatic
		{
			get
			{
				short num = (short)2105371526;
				short num2 = num;
				num = (short)877226886;
				switch (num2 == num)
				{
				}
				num = (short)631570433;
				if (num != 0)
				{
				}
				num = (short)1303511040;
				short num3 = num;
				num = (short)1805385728;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMinResponseTimerms_A8514.HiddenStatic;
			}
			set
			{
				short num = (short)447348776;
				short num2 = num;
				num = (short)1019150376;
				switch (num2 == num)
				{
				}
				num = (short)1339883521;
				if (num != 0)
				{
				}
				num = (short)897318912;
				short num3 = num;
				num = (short)473825280;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMinResponseTimerms_A8514.HiddenStatic = value;
			}
		}

		// Token: 0x17005A4A RID: 23114
		// (get) Token: 0x0600B40E RID: 46094 RVA: 0x00A6F194 File Offset: 0x00A6D394
		// (set) Token: 0x0600B40F RID: 46095 RVA: 0x00A6F248 File Offset: 0x00A6D448
		internal bool CnvWideASTRODataMinResponseTimerms_A8514_HiddenDynamic
		{
			get
			{
				short num = (short)558143489;
				short num2 = num;
				num = (short)252286977;
				switch (num2 == num)
				{
				}
				num = (short)1797783553;
				if (num != 0)
				{
				}
				num = (short)208142336;
				short num3 = num;
				num = (short)1766129664;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMinResponseTimerms_A8514.HiddenDynamic;
			}
			set
			{
				short num = (short)1861869676;
				short num2 = num;
				num = (short)2109857900;
				switch (num2 == num)
				{
				}
				num = (short)706084865;
				if (num != 0)
				{
				}
				num = (short)1685716992;
				short num3 = num;
				num = (short)2129133568;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMinResponseTimerms_A8514.HiddenDynamic = value;
			}
		}

		// Token: 0x17005A4B RID: 23115
		// (get) Token: 0x0600B410 RID: 46096 RVA: 0x00A6F2FC File Offset: 0x00A6D4FC
		public bool CnvWideASTRODataMinResponseTimerms_A8514_HasDiffs
		{
			get
			{
				short num = (short)190100623;
				short num2 = num;
				num = (short)1183691919;
				switch (num2 == num)
				{
				}
				num = (short)1569783808;
				if (num != 0)
				{
				}
				num = (short)276824064;
				short num3 = num;
				num = (short)771358721;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMinResponseTimerms_A8514._HasDiffs;
			}
		}

		// Token: 0x17005A4C RID: 23116
		// (get) Token: 0x0600B411 RID: 46097 RVA: 0x00A6F3AC File Offset: 0x00A6D5AC
		// (set) Token: 0x0600B412 RID: 46098 RVA: 0x00A6F460 File Offset: 0x00A6D660
		public int CnvWideASTRODataResponseTimerms_A8948Value
		{
			get
			{
				short num = (short)1669684979;
				short num2 = num;
				num = (short)657481459;
				switch (num2 == num)
				{
				}
				num = (short)1309016064;
				if (num != 0)
				{
				}
				num = (short)398917632;
				short num3 = num;
				num = (short)1353121793;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataResponseTimerms_A8948.Value;
			}
			set
			{
				short num = (short)1226421753;
				short num2 = num;
				num = (short)993179129;
				switch (num2 == num)
				{
				}
				num = (short)57999360;
				if (num != 0)
				{
				}
				num = (short)78905344;
				short num3 = num;
				num = (short)1257570305;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataResponseTimerms_A8948.Value = value;
			}
		}

		// Token: 0x17005A4D RID: 23117
		// (get) Token: 0x0600B413 RID: 46099 RVA: 0x00A6F514 File Offset: 0x00A6D714
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvWideASTRODataResponseTimerms_A8948
		{
			get
			{
				short num = (short)785645569;
				if (num != 0)
				{
				}
				num = (short)1570784509;
				short num2 = num;
				num = (short)504644861;
				switch (num2 == num)
				{
				}
				num = (short)1162608640;
				short num3 = num;
				num = (short)2086600704;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataResponseTimerms_A8948;
			}
		}

		// Token: 0x17005A4E RID: 23118
		// (get) Token: 0x0600B414 RID: 46100 RVA: 0x00A6F5C8 File Offset: 0x00A6D7C8
		// (set) Token: 0x0600B415 RID: 46101 RVA: 0x00A6F67C File Offset: 0x00A6D87C
		public string CnvWideASTRODataResponseTimerms_A8948_UIValue
		{
			get
			{
				short num = (short)1168062157;
				short num2 = num;
				num = (short)517158605;
				switch (num2 == num)
				{
				}
				num = (short)306839553;
				if (num != 0)
				{
				}
				num = (short)1523908608;
				short num3 = num;
				num = (short)873332736;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataResponseTimerms_A8948.UIValue;
			}
			set
			{
				short num = (short)1379946527;
				short num2 = num;
				num = (short)1484345375;
				switch (num2 == num)
				{
				}
				num = (short)261488641;
				if (num != 0)
				{
				}
				num = (short)223608832;
				short num3 = num;
				num = (short)286392320;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataResponseTimerms_A8948.UIValue = value;
			}
		}

		// Token: 0x17005A4F RID: 23119
		// (get) Token: 0x0600B416 RID: 46102 RVA: 0x00A6F730 File Offset: 0x00A6D930
		// (set) Token: 0x0600B417 RID: 46103 RVA: 0x00A6F7E4 File Offset: 0x00A6D9E4
		internal int CnvWideASTRODataResponseTimerms_A8948Min
		{
			get
			{
				short num = (short)1814355272;
				short num2 = num;
				num = (short)1227545928;
				switch (num2 == num)
				{
				}
				num = (short)863436801;
				if (num != 0)
				{
				}
				num = (short)1851064320;
				short num3 = num;
				num = (short)139919360;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataResponseTimerms_A8948.Min;
			}
			set
			{
				short num = (short)236322817;
				if (num != 0)
				{
				}
				num = (short)496392418;
				short num2 = num;
				num = (short)1139955938;
				switch (num2 == num)
				{
				}
				num = (short)1050148864;
				short num3 = num;
				num = (short)670892032;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataResponseTimerms_A8948.Min = value;
			}
		}

		// Token: 0x17005A50 RID: 23120
		// (get) Token: 0x0600B418 RID: 46104 RVA: 0x00A6F89C File Offset: 0x00A6DA9C
		// (set) Token: 0x0600B419 RID: 46105 RVA: 0x00A6F950 File Offset: 0x00A6DB50
		internal int CnvWideASTRODataResponseTimerms_A8948Max
		{
			get
			{
				short num = (short)334671603;
				short num2 = num;
				num = (short)1776398067;
				switch (num2 == num)
				{
				}
				num = (short)561709056;
				if (num != 0)
				{
				}
				num = (short)214630400;
				short num3 = num;
				num = (short)724303873;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataResponseTimerms_A8948.Max;
			}
			set
			{
				short num = (short)1849425921;
				if (num != 0)
				{
				}
				num = (short)1885880020;
				short num2 = num;
				num = (short)972635860;
				switch (num2 == num)
				{
				}
				num = (short)959315968;
				short num3 = num;
				num = (short)532348928;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataResponseTimerms_A8948.Max = value;
			}
		}

		// Token: 0x17005A51 RID: 23121
		// (get) Token: 0x0600B41A RID: 46106 RVA: 0x00A6FA04 File Offset: 0x00A6DC04
		// (set) Token: 0x0600B41B RID: 46107 RVA: 0x00A6FABC File Offset: 0x00A6DCBC
		internal int CnvWideASTRODataResponseTimerms_A8948Step
		{
			get
			{
				short num = (short)531297152;
				short num2 = num;
				num = (short)1967453056;
				switch (num2 == num)
				{
				}
				num = (short)1453916160;
				if (num != 0)
				{
				}
				num = (short)1231355904;
				short num3 = num;
				num = (short)460652545;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataResponseTimerms_A8948.StepSize;
			}
			set
			{
				short num = (short)413316926;
				short num2 = num;
				num = (short)1643755326;
				switch (num2 == num)
				{
				}
				num = (short)1883308032;
				if (num != 0)
				{
				}
				num = (short)394067968;
				short num3 = num;
				num = (short)1677459457;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataResponseTimerms_A8948.StepSize = value;
			}
		}

		// Token: 0x17005A52 RID: 23122
		// (get) Token: 0x0600B41C RID: 46108 RVA: 0x00A6FB70 File Offset: 0x00A6DD70
		// (set) Token: 0x0600B41D RID: 46109 RVA: 0x00A6FC24 File Offset: 0x00A6DE24
		public bool CnvWideASTRODataResponseTimerms_A8948_Applicable
		{
			get
			{
				short num = (short)539195244;
				short num2 = num;
				num = (short)1191147372;
				switch (num2 == num)
				{
				}
				num = (short)1749680129;
				if (num != 0)
				{
				}
				num = (short)1567358976;
				short num3 = num;
				num = (short)1724121088;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataResponseTimerms_A8948.Applicable;
			}
			set
			{
				short num = (short)1727429734;
				short num2 = num;
				num = (short)457604198;
				switch (num2 == num)
				{
				}
				num = (short)1336344576;
				if (num != 0)
				{
				}
				num = (short)111017984;
				short num3 = num;
				num = (short)1844772865;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataResponseTimerms_A8948.Applicable = value;
			}
		}

		// Token: 0x17005A53 RID: 23123
		// (get) Token: 0x0600B41E RID: 46110 RVA: 0x00A6FCDC File Offset: 0x00A6DEDC
		// (set) Token: 0x0600B41F RID: 46111 RVA: 0x00A6FD90 File Offset: 0x00A6DF90
		public bool CnvWideASTRODataResponseTimerms_A8948_Valid
		{
			get
			{
				short num = (short)766050941;
				short num2 = num;
				num = (short)1590887037;
				switch (num2 == num)
				{
				}
				num = (short)11075585;
				if (num != 0)
				{
				}
				num = (short)1810694144;
				short num3 = num;
				num = (short)206372864;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataResponseTimerms_A8948.Valid;
			}
			set
			{
				short num = (short)235274241;
				if (num != 0)
				{
				}
				num = (short)1867896323;
				short num2 = num;
				num = (short)1151522307;
				switch (num2 == num)
				{
				}
				num = (short)1614741504;
				short num3 = num;
				num = (short)1482817536;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataResponseTimerms_A8948.Valid = value;
			}
		}

		// Token: 0x17005A54 RID: 23124
		// (get) Token: 0x0600B420 RID: 46112 RVA: 0x00A6FE48 File Offset: 0x00A6E048
		// (set) Token: 0x0600B421 RID: 46113 RVA: 0x00A6FEFC File Offset: 0x00A6E0FC
		public bool CnvWideASTRODataResponseTimerms_A8948_Visible
		{
			get
			{
				short num = (short)1903941231;
				short num2 = num;
				num = (short)747296367;
				switch (num2 == num)
				{
				}
				num = (short)1845100545;
				if (num != 0)
				{
				}
				num = (short)1641742336;
				short num3 = num;
				num = (short)1283260416;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataResponseTimerms_A8948.Visible;
			}
			set
			{
				short num = (short)1146196720;
				short num2 = num;
				num = (short)1129747184;
				switch (num2 == num)
				{
				}
				num = (short)1103888384;
				if (num != 0)
				{
				}
				num = (short)1891958784;
				short num3 = num;
				num = (short)1077018625;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataResponseTimerms_A8948.Visible = value;
			}
		}

		// Token: 0x17005A55 RID: 23125
		// (get) Token: 0x0600B422 RID: 46114 RVA: 0x00A6FFB4 File Offset: 0x00A6E1B4
		// (set) Token: 0x0600B423 RID: 46115 RVA: 0x00A70068 File Offset: 0x00A6E268
		public bool CnvWideASTRODataResponseTimerms_A8948_Editable
		{
			get
			{
				short num = (short)1176533782;
				short num2 = num;
				num = (short)1225947926;
				switch (num2 == num)
				{
				}
				num = (short)14876672;
				if (num != 0)
				{
				}
				num = (short)187432960;
				short num3 = num;
				num = (short)1445265409;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataResponseTimerms_A8948.Editable;
			}
			set
			{
				short num = (short)1754791937;
				if (num != 0)
				{
				}
				num = (short)717611890;
				short num2 = num;
				num = (short)42525554;
				switch (num2 == num)
				{
				}
				num = (short)458293248;
				short num3 = num;
				num = (short)733675520;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataResponseTimerms_A8948.Editable = value;
			}
		}

		// Token: 0x17005A56 RID: 23126
		// (get) Token: 0x0600B424 RID: 46116 RVA: 0x00A70120 File Offset: 0x00A6E320
		internal string CnvWideASTRODataResponseTimerms_A8948_UILabel
		{
			get
			{
				short num = (short)1646414688;
				short num2 = num;
				num = (short)1416907616;
				switch (num2 == num)
				{
				}
				num = (short)692256768;
				if (num != 0)
				{
				}
				num = (short)1709637632;
				short num3 = num;
				num = (short)1014759425;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataResponseTimerms_A8948.UIName;
			}
		}

		// Token: 0x17005A57 RID: 23127
		// (get) Token: 0x0600B425 RID: 46117 RVA: 0x00A701D0 File Offset: 0x00A6E3D0
		// (set) Token: 0x0600B426 RID: 46118 RVA: 0x00A70288 File Offset: 0x00A6E488
		internal bool CnvWideASTRODataResponseTimerms_A8948_HiddenStatic
		{
			get
			{
				short num = (short)1305253628;
				short num2 = num;
				num = (short)939300604;
				switch (num2 == num)
				{
				}
				num = (short)169803777;
				if (num != 0)
				{
				}
				num = (short)269680640;
				short num3 = num;
				num = (short)1680146432;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataResponseTimerms_A8948.HiddenStatic;
			}
			set
			{
				short num = (short)1225696954;
				short num2 = num;
				num = (short)1514710714;
				switch (num2 == num)
				{
				}
				num = (short)1291452417;
				if (num != 0)
				{
				}
				num = (short)458096640;
				short num3 = num;
				num = (short)1773666304;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataResponseTimerms_A8948.HiddenStatic = value;
			}
		}

		// Token: 0x17005A58 RID: 23128
		// (get) Token: 0x0600B427 RID: 46119 RVA: 0x00A7033C File Offset: 0x00A6E53C
		// (set) Token: 0x0600B428 RID: 46120 RVA: 0x00A703F0 File Offset: 0x00A6E5F0
		internal bool CnvWideASTRODataResponseTimerms_A8948_HiddenDynamic
		{
			get
			{
				short num = (short)10304037;
				short num2 = num;
				num = (short)897792549;
				switch (num2 == num)
				{
				}
				num = (short)1600258048;
				if (num != 0)
				{
				}
				num = (short)1700659200;
				short num3 = num;
				num = (short)1491992577;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataResponseTimerms_A8948.HiddenDynamic;
			}
			set
			{
				short num = (short)541087715;
				short num2 = num;
				num = (short)1706514403;
				switch (num2 == num)
				{
				}
				num = (short)700121089;
				if (num != 0)
				{
				}
				num = (short)972881920;
				short num3 = num;
				num = (short)459407360;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataResponseTimerms_A8948.HiddenDynamic = value;
			}
		}

		// Token: 0x17005A59 RID: 23129
		// (get) Token: 0x0600B429 RID: 46121 RVA: 0x00A704A8 File Offset: 0x00A6E6A8
		public bool CnvWideASTRODataResponseTimerms_A8948_HasDiffs
		{
			get
			{
				short num = (short)1498945947;
				short num2 = num;
				num = (short)1835014555;
				switch (num2 == num)
				{
				}
				num = (short)1070989313;
				if (num != 0)
				{
				}
				num = (short)1025245184;
				short num3 = num;
				num = (short)1753153536;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataResponseTimerms_A8948._HasDiffs;
			}
		}

		// Token: 0x17005A5A RID: 23130
		// (get) Token: 0x0600B42A RID: 46122 RVA: 0x00A70560 File Offset: 0x00A6E760
		// (set) Token: 0x0600B42B RID: 46123 RVA: 0x00A70614 File Offset: 0x00A6E814
		public int CnvWideASTRODataTxLongRandomRangeMs_A9546Value
		{
			get
			{
				short num = (short)1316487169;
				if (num != 0)
				{
				}
				num = (short)190784491;
				short num2 = num;
				num = (short)535962603;
				switch (num2 == num)
				{
				}
				num = (short)1426784256;
				short num3 = num;
				num = (short)919207936;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLongRandomRangeMs_A9546.Value;
			}
			set
			{
				short num = (short)1081299848;
				short num2 = num;
				num = (short)2108183432;
				switch (num2 == num)
				{
				}
				num = (short)2054029313;
				if (num != 0)
				{
				}
				num = (short)644546560;
				short num3 = num;
				num = (short)644874240;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxLongRandomRangeMs_A9546.Value = value;
			}
		}

		// Token: 0x17005A5B RID: 23131
		// (get) Token: 0x0600B42C RID: 46124 RVA: 0x00A706CC File Offset: 0x00A6E8CC
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvWideASTRODataTxLongRandomRangeMs_A9546
		{
			get
			{
				short num = (short)818117553;
				short num2 = num;
				num = (short)974486449;
				switch (num2 == num)
				{
				}
				num = (short)877592577;
				if (num != 0)
				{
				}
				num = (short)1436745728;
				short num3 = num;
				num = (short)129564672;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLongRandomRangeMs_A9546;
			}
		}

		// Token: 0x17005A5C RID: 23132
		// (get) Token: 0x0600B42D RID: 46125 RVA: 0x00A70778 File Offset: 0x00A6E978
		// (set) Token: 0x0600B42E RID: 46126 RVA: 0x00A70828 File Offset: 0x00A6EA28
		public string CnvWideASTRODataTxLongRandomRangeMs_A9546_UIValue
		{
			get
			{
				short num = (short)949092353;
				if (num != 0)
				{
				}
				num = (short)224635532;
				short num2 = num;
				num = (short)531737228;
				switch (num2 == num)
				{
				}
				num = (short)616890368;
				short num3 = num;
				num = (short)1939603456;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLongRandomRangeMs_A9546.UIValue;
			}
			set
			{
				short num = (short)373944594;
				short num2 = num;
				num = (short)1592520978;
				switch (num2 == num)
				{
				}
				num = (short)735969281;
				if (num != 0)
				{
				}
				num = (short)2021982208;
				short num3 = num;
				num = (short)611778560;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxLongRandomRangeMs_A9546.UIValue = value;
			}
		}

		// Token: 0x17005A5D RID: 23133
		// (get) Token: 0x0600B42F RID: 46127 RVA: 0x00A708E0 File Offset: 0x00A6EAE0
		// (set) Token: 0x0600B430 RID: 46128 RVA: 0x00A70994 File Offset: 0x00A6EB94
		internal int CnvWideASTRODataTxLongRandomRangeMs_A9546Min
		{
			get
			{
				short num = (short)361371608;
				short num2 = num;
				num = (short)262543320;
				switch (num2 == num)
				{
				}
				num = (short)905117696;
				if (num != 0)
				{
				}
				num = (short)554434560;
				short num3 = num;
				num = (short)1615003649;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLongRandomRangeMs_A9546.Min;
			}
			set
			{
				short num = (short)1288423100;
				short num2 = num;
				num = (short)1459668668;
				switch (num2 == num)
				{
				}
				num = (short)36634624;
				if (num != 0)
				{
				}
				num = (short)2049179648;
				short num3 = num;
				num = (short)1986396161;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxLongRandomRangeMs_A9546.Min = value;
			}
		}

		// Token: 0x17005A5E RID: 23134
		// (get) Token: 0x0600B431 RID: 46129 RVA: 0x00A70A4C File Offset: 0x00A6EC4C
		// (set) Token: 0x0600B432 RID: 46130 RVA: 0x00A70AFC File Offset: 0x00A6ECFC
		internal int CnvWideASTRODataTxLongRandomRangeMs_A9546Max
		{
			get
			{
				short num = (short)1844596368;
				short num2 = num;
				num = (short)2093305488;
				switch (num2 == num)
				{
				}
				num = (short)293535745;
				if (num != 0)
				{
				}
				num = (short)359071744;
				short num3 = num;
				num = (short)339345408;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLongRandomRangeMs_A9546.Max;
			}
			set
			{
				short num = (short)388593757;
				short num2 = num;
				num = (short)978155613;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1329070080;
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
				num = (short)385417217;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxLongRandomRangeMs_A9546.Max = value;
			}
		}

		// Token: 0x17005A5F RID: 23135
		// (get) Token: 0x0600B433 RID: 46131 RVA: 0x00A70BB4 File Offset: 0x00A6EDB4
		// (set) Token: 0x0600B434 RID: 46132 RVA: 0x00A70C6C File Offset: 0x00A6EE6C
		internal int CnvWideASTRODataTxLongRandomRangeMs_A9546Step
		{
			get
			{
				short num = (short)1353429091;
				short num2 = num;
				num = (short)476491875;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1638400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)680001537;
				if (num != 0)
				{
				}
				num = (short)1193607168;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLongRandomRangeMs_A9546.StepSize;
			}
			set
			{
				short num = (short)1116713270;
				short num2 = num;
				num = (short)1352905014;
				switch (num2 == num)
				{
				default:
				{
					num = (short)354942976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1077936128;
				if (num != 0)
				{
				}
				num = (short)435879937;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxLongRandomRangeMs_A9546.StepSize = value;
			}
		}

		// Token: 0x17005A60 RID: 23136
		// (get) Token: 0x0600B435 RID: 46133 RVA: 0x00A70D20 File Offset: 0x00A6EF20
		// (set) Token: 0x0600B436 RID: 46134 RVA: 0x00A70DD4 File Offset: 0x00A6EFD4
		public bool CnvWideASTRODataTxLongRandomRangeMs_A9546_Applicable
		{
			get
			{
				short num = (short)1341960920;
				short num2 = num;
				num = (short)1136505560;
				switch (num2 == num)
				{
				default:
				{
					num = (short)305463296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)76939264;
				if (num != 0)
				{
				}
				num = (short)1385168897;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLongRandomRangeMs_A9546.Applicable;
			}
			set
			{
				short num = (short)1907928940;
				short num2 = num;
				num = (short)868396908;
				switch (num2 == num)
				{
				default:
				{
					num = (short)138674176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)662241280;
				if (num != 0)
				{
				}
				num = (short)1631977473;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxLongRandomRangeMs_A9546.Applicable = value;
			}
		}

		// Token: 0x17005A61 RID: 23137
		// (get) Token: 0x0600B437 RID: 46135 RVA: 0x00A70E88 File Offset: 0x00A6F088
		// (set) Token: 0x0600B438 RID: 46136 RVA: 0x00A70F3C File Offset: 0x00A6F13C
		public bool CnvWideASTRODataTxLongRandomRangeMs_A9546_Valid
		{
			get
			{
				short num = (short)1319667433;
				short num2 = num;
				num = (short)405702377;
				switch (num2 == num)
				{
				default:
				{
					num = (short)372441088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1814364161;
				if (num != 0)
				{
				}
				num = (short)174260224;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLongRandomRangeMs_A9546.Valid;
			}
			set
			{
				short num = (short)759824385;
				if (num != 0)
				{
				}
				num = (short)927531008;
				short num2 = num;
				num = (short)744412774;
				short num3 = num;
				num = (short)1443747430;
				switch (num3 == num)
				{
				}
				num = (short)11141120;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxLongRandomRangeMs_A9546.Valid = value;
			}
		}

		// Token: 0x17005A62 RID: 23138
		// (get) Token: 0x0600B439 RID: 46137 RVA: 0x00A70FF0 File Offset: 0x00A6F1F0
		// (set) Token: 0x0600B43A RID: 46138 RVA: 0x00A710A8 File Offset: 0x00A6F2A8
		public bool CnvWideASTRODataTxLongRandomRangeMs_A9546_Visible
		{
			get
			{
				short num = (short)1911881729;
				if (num != 0)
				{
				}
				num = (short)1867186176;
				short num2 = num;
				num = (short)1817413389;
				short num3 = num;
				num = (short)671647501;
				switch (num3 == num)
				{
				}
				num = (short)1165492224;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLongRandomRangeMs_A9546.Visible;
			}
			set
			{
				short num = (short)541218856;
				short num2 = num;
				num = (short)480073768;
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
				num = (short)1959657473;
				if (num != 0)
				{
				}
				num = (short)1641152512;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxLongRandomRangeMs_A9546.Visible = value;
			}
		}

		// Token: 0x17005A63 RID: 23139
		// (get) Token: 0x0600B43B RID: 46139 RVA: 0x00A71160 File Offset: 0x00A6F360
		// (set) Token: 0x0600B43C RID: 46140 RVA: 0x00A71218 File Offset: 0x00A6F418
		public bool CnvWideASTRODataTxLongRandomRangeMs_A9546_Editable
		{
			get
			{
				short num = (short)1121702215;
				short num2 = num;
				num = (short)169922887;
				switch (num2 == num)
				{
				default:
				{
					num = (short)455671808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1451753473;
				if (num != 0)
				{
				}
				num = (short)1724055552;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLongRandomRangeMs_A9546.Editable;
			}
			set
			{
				short num = (short)1697921075;
				short num2 = num;
				num = (short)1769486387;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2101739520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1061486593;
				if (num != 0)
				{
				}
				num = (short)732889088;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxLongRandomRangeMs_A9546.Editable = value;
			}
		}

		// Token: 0x17005A64 RID: 23140
		// (get) Token: 0x0600B43D RID: 46141 RVA: 0x00A712CC File Offset: 0x00A6F4CC
		internal string CnvWideASTRODataTxLongRandomRangeMs_A9546_UILabel
		{
			get
			{
				short num = (short)6291947;
				short num2 = num;
				num = (short)342491627;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1337720832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1227227136;
				if (num != 0)
				{
				}
				num = (short)1222443009;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLongRandomRangeMs_A9546.UIName;
			}
		}

		// Token: 0x17005A65 RID: 23141
		// (get) Token: 0x0600B43E RID: 46142 RVA: 0x00A71380 File Offset: 0x00A6F580
		// (set) Token: 0x0600B43F RID: 46143 RVA: 0x00A71438 File Offset: 0x00A6F638
		internal bool CnvWideASTRODataTxLongRandomRangeMs_A9546_HiddenStatic
		{
			get
			{
				short num = (short)1098357307;
				short num2 = num;
				num = (short)869046843;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1348796416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)92012544;
				if (num != 0)
				{
				}
				num = (short)1844051969;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLongRandomRangeMs_A9546.HiddenStatic;
			}
			set
			{
				short num = (short)1606333947;
				short num2 = num;
				num = (short)861844987;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2000748544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2137849856;
				if (num != 0)
				{
				}
				num = (short)1121976321;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxLongRandomRangeMs_A9546.HiddenStatic = value;
			}
		}

		// Token: 0x17005A66 RID: 23142
		// (get) Token: 0x0600B440 RID: 46144 RVA: 0x00A714EC File Offset: 0x00A6F6EC
		// (set) Token: 0x0600B441 RID: 46145 RVA: 0x00A715A0 File Offset: 0x00A6F7A0
		internal bool CnvWideASTRODataTxLongRandomRangeMs_A9546_HiddenDynamic
		{
			get
			{
				short num = (short)1044304104;
				short num2 = num;
				num = (short)1393676520;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1555169280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1303707648;
				if (num != 0)
				{
				}
				num = (short)804716545;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLongRandomRangeMs_A9546.HiddenDynamic;
			}
			set
			{
				short num = (short)1479102799;
				short num2 = num;
				num = (short)777343311;
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
				num = (short)1727594497;
				if (num != 0)
				{
				}
				num = (short)764739584;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxLongRandomRangeMs_A9546.HiddenDynamic = value;
			}
		}

		// Token: 0x17005A67 RID: 23143
		// (get) Token: 0x0600B442 RID: 46146 RVA: 0x00A71658 File Offset: 0x00A6F858
		public bool CnvWideASTRODataTxLongRandomRangeMs_A9546_HasDiffs
		{
			get
			{
				short num = (short)71331311;
				short num2 = num;
				num = (short)1041526255;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1477443584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1221197824;
				if (num != 0)
				{
				}
				num = (short)408551425;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxLongRandomRangeMs_A9546._HasDiffs;
			}
		}

		// Token: 0x17005A68 RID: 23144
		// (get) Token: 0x0600B443 RID: 46147 RVA: 0x00A7170C File Offset: 0x00A6F90C
		// (set) Token: 0x0600B444 RID: 46148 RVA: 0x00A717C0 File Offset: 0x00A6F9C0
		public int CnvWideASTRODataTxRespRandomRangeMs_A9563Value
		{
			get
			{
				short num = (short)1619450005;
				short num2 = num;
				num = (short)1576458389;
				switch (num2 == num)
				{
				default:
				{
					num = (short)10682368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)548798465;
				if (num != 0)
				{
				}
				num = (short)1389101056;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxRespRandomRangeMs_A9563.Value;
			}
			set
			{
				short num = (short)708347153;
				short num2 = num;
				num = (short)159941905;
				switch (num2 == num)
				{
				default:
				{
					num = (short)620822528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1254096896;
				if (num != 0)
				{
				}
				num = (short)584974337;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxRespRandomRangeMs_A9563.Value = value;
			}
		}

		// Token: 0x17005A69 RID: 23145
		// (get) Token: 0x0600B445 RID: 46149 RVA: 0x00A71878 File Offset: 0x00A6FA78
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvWideASTRODataTxRespRandomRangeMs_A9563
		{
			get
			{
				short num = (short)1728230542;
				short num2 = num;
				num = (short)1806939278;
				switch (num2 == num)
				{
				default:
				{
					num = (short)630128640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1525219329;
				if (num != 0)
				{
				}
				num = (short)2092761088;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxRespRandomRangeMs_A9563;
			}
		}

		// Token: 0x17005A6A RID: 23146
		// (get) Token: 0x0600B446 RID: 46150 RVA: 0x00A71924 File Offset: 0x00A6FB24
		// (set) Token: 0x0600B447 RID: 46151 RVA: 0x00A719D8 File Offset: 0x00A6FBD8
		public string CnvWideASTRODataTxRespRandomRangeMs_A9563_UIValue
		{
			get
			{
				short num = (short)912692491;
				short num2 = num;
				num = (short)706516235;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1755971584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)106823681;
				if (num != 0)
				{
				}
				num = (short)1323171840;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxRespRandomRangeMs_A9563.UIValue;
			}
			set
			{
				short num = (short)63708562;
				short num2 = num;
				num = (short)270867858;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1090846720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1645740033;
				if (num != 0)
				{
				}
				num = (short)2083979264;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxRespRandomRangeMs_A9563.UIValue = value;
			}
		}

		// Token: 0x17005A6B RID: 23147
		// (get) Token: 0x0600B448 RID: 46152 RVA: 0x00A71A90 File Offset: 0x00A6FC90
		// (set) Token: 0x0600B449 RID: 46153 RVA: 0x00A71B44 File Offset: 0x00A6FD44
		internal int CnvWideASTRODataTxRespRandomRangeMs_A9563Min
		{
			get
			{
				short num = (short)1325578297;
				short num2 = num;
				num = (short)91076665;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1424621568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)877789185;
				if (num != 0)
				{
				}
				num = (short)1652359168;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxRespRandomRangeMs_A9563.Min;
			}
			set
			{
				short num = (short)341049345;
				if (num != 0)
				{
				}
				num = (short)208011264;
				short num2 = num;
				num = (short)1571716051;
				short num3 = num;
				num = (short)318667731;
				switch (num3 == num)
				{
				}
				num = (short)1867055104;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxRespRandomRangeMs_A9563.Min = value;
			}
		}

		// Token: 0x17005A6C RID: 23148
		// (get) Token: 0x0600B44A RID: 46154 RVA: 0x00A71BFC File Offset: 0x00A6FDFC
		// (set) Token: 0x0600B44B RID: 46155 RVA: 0x00A71CB0 File Offset: 0x00A6FEB0
		internal int CnvWideASTRODataTxRespRandomRangeMs_A9563Max
		{
			get
			{
				short num = (short)1744629017;
				short num2 = num;
				num = (short)1451027737;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2037841920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1330708481;
				if (num != 0)
				{
				}
				num = (short)279314432;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxRespRandomRangeMs_A9563.Max;
			}
			set
			{
				short num = (short)269491506;
				short num2 = num;
				num = (short)251075890;
				switch (num2 == num)
				{
				default:
				{
					num = (short)485687296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)872808449;
				if (num != 0)
				{
				}
				num = (short)465043456;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxRespRandomRangeMs_A9563.Max = value;
			}
		}

		// Token: 0x17005A6D RID: 23149
		// (get) Token: 0x0600B44C RID: 46156 RVA: 0x00A71D64 File Offset: 0x00A6FF64
		// (set) Token: 0x0600B44D RID: 46157 RVA: 0x00A71E1C File Offset: 0x00A7001C
		internal int CnvWideASTRODataTxRespRandomRangeMs_A9563Step
		{
			get
			{
				short num = (short)1914645556;
				short num2 = num;
				num = (short)1764437044;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1771700224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1835204609;
				if (num != 0)
				{
				}
				num = (short)418971648;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxRespRandomRangeMs_A9563.StepSize;
			}
			set
			{
				short num = (short)2100332992;
				short num2 = num;
				num = (short)1684965824;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2003763200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)973340673;
				if (num != 0)
				{
				}
				num = (short)63766528;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxRespRandomRangeMs_A9563.StepSize = value;
			}
		}

		// Token: 0x17005A6E RID: 23150
		// (get) Token: 0x0600B44E RID: 46158 RVA: 0x00A71ED0 File Offset: 0x00A700D0
		// (set) Token: 0x0600B44F RID: 46159 RVA: 0x00A71F84 File Offset: 0x00A70184
		public bool CnvWideASTRODataTxRespRandomRangeMs_A9563_Applicable
		{
			get
			{
				short num = (short)910875953;
				short num2 = num;
				num = (short)1747901745;
				switch (num2 == num)
				{
				default:
				{
					num = (short)585695232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1609891840;
				if (num != 0)
				{
				}
				num = (short)924450817;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxRespRandomRangeMs_A9563.Applicable;
			}
			set
			{
				short num = (short)356385894;
				short num2 = num;
				num = (short)797836390;
				switch (num2 == num)
				{
				default:
				{
					num = (short)645595136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2132475905;
				if (num != 0)
				{
				}
				num = (short)201654272;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxRespRandomRangeMs_A9563.Applicable = value;
			}
		}

		// Token: 0x17005A6F RID: 23151
		// (get) Token: 0x0600B450 RID: 46160 RVA: 0x00A72038 File Offset: 0x00A70238
		// (set) Token: 0x0600B451 RID: 46161 RVA: 0x00A720EC File Offset: 0x00A702EC
		public bool CnvWideASTRODataTxRespRandomRangeMs_A9563_Valid
		{
			get
			{
				short num = (short)1373064641;
				short num2 = num;
				num = (short)1289440705;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1527971840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)860684288;
				if (num != 0)
				{
				}
				num = (short)2105540609;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxRespRandomRangeMs_A9563.Valid;
			}
			set
			{
				short num = (short)1732565927;
				short num2 = num;
				num = (short)1016716199;
				switch (num2 == num)
				{
				default:
				{
					num = (short)555352064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1209073664;
				if (num != 0)
				{
				}
				num = (short)229769217;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxRespRandomRangeMs_A9563.Valid = value;
			}
		}

		// Token: 0x17005A70 RID: 23152
		// (get) Token: 0x0600B452 RID: 46162 RVA: 0x00A721A0 File Offset: 0x00A703A0
		// (set) Token: 0x0600B453 RID: 46163 RVA: 0x00A72258 File Offset: 0x00A70458
		public bool CnvWideASTRODataTxRespRandomRangeMs_A9563_Visible
		{
			get
			{
				short num = (short)22609921;
				if (num != 0)
				{
				}
				num = (short)1209139200;
				short num2 = num;
				num = (short)51900545;
				short num3 = num;
				num = (short)1246556289;
				switch (num3 == num)
				{
				}
				num = (short)1350696960;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxRespRandomRangeMs_A9563.Visible;
			}
			set
			{
				short num = (short)786573532;
				short num2 = num;
				num = (short)116467932;
				switch (num2 == num)
				{
				default:
				{
					num = (short)447610880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)307363840;
				if (num != 0)
				{
				}
				num = (short)1870594049;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxRespRandomRangeMs_A9563.Visible = value;
			}
		}

		// Token: 0x17005A71 RID: 23153
		// (get) Token: 0x0600B454 RID: 46164 RVA: 0x00A7230C File Offset: 0x00A7050C
		// (set) Token: 0x0600B455 RID: 46165 RVA: 0x00A723C0 File Offset: 0x00A705C0
		public bool CnvWideASTRODataTxRespRandomRangeMs_A9563_Editable
		{
			get
			{
				short num = (short)16121857;
				if (num != 0)
				{
				}
				num = (short)1234042880;
				short num2 = num;
				num = (short)1190200329;
				short num3 = num;
				num = (short)2028274697;
				switch (num3 == num)
				{
				}
				num = (short)1916796928;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxRespRandomRangeMs_A9563.Editable;
			}
			set
			{
				short num = (short)550982169;
				short num2 = num;
				num = (short)1431720473;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1699282944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2118189057;
				if (num != 0)
				{
				}
				num = (short)423034880;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxRespRandomRangeMs_A9563.Editable = value;
			}
		}

		// Token: 0x17005A72 RID: 23154
		// (get) Token: 0x0600B456 RID: 46166 RVA: 0x00A72474 File Offset: 0x00A70674
		internal string CnvWideASTRODataTxRespRandomRangeMs_A9563_UILabel
		{
			get
			{
				short num = (short)1231496397;
				short num2 = num;
				num = (short)1242703053;
				switch (num2 == num)
				{
				default:
				{
					num = (short)305922048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)969015297;
				if (num != 0)
				{
				}
				num = (short)1817772032;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxRespRandomRangeMs_A9563.UIName;
			}
		}

		// Token: 0x17005A73 RID: 23155
		// (get) Token: 0x0600B457 RID: 46167 RVA: 0x00A7252C File Offset: 0x00A7072C
		// (set) Token: 0x0600B458 RID: 46168 RVA: 0x00A725E0 File Offset: 0x00A707E0
		internal bool CnvWideASTRODataTxRespRandomRangeMs_A9563_HiddenStatic
		{
			get
			{
				short num = (short)1121657750;
				short num2 = num;
				num = (short)428483478;
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
				num = (short)164036609;
				if (num != 0)
				{
				}
				num = (short)1739063296;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxRespRandomRangeMs_A9563.HiddenStatic;
			}
			set
			{
				short num = (short)2002248579;
				short num2 = num;
				num = (short)1342235523;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1967456256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1020067840;
				if (num != 0)
				{
				}
				num = (short)929038337;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxRespRandomRangeMs_A9563.HiddenStatic = value;
			}
		}

		// Token: 0x17005A74 RID: 23156
		// (get) Token: 0x0600B459 RID: 46169 RVA: 0x00A72698 File Offset: 0x00A70898
		// (set) Token: 0x0600B45A RID: 46170 RVA: 0x00A72750 File Offset: 0x00A70950
		internal bool CnvWideASTRODataTxRespRandomRangeMs_A9563_HiddenDynamic
		{
			get
			{
				short num = (short)1021178925;
				short num2 = num;
				num = (short)582677549;
				switch (num2 == num)
				{
				default:
				{
					num = (short)553451520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1479147521;
				if (num != 0)
				{
				}
				num = (short)1301938176;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxRespRandomRangeMs_A9563.HiddenDynamic;
			}
			set
			{
				short num = (short)2136083723;
				short num2 = num;
				num = (short)1221659915;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2132148224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1003749376;
				if (num != 0)
				{
				}
				num = (short)1921974273;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxRespRandomRangeMs_A9563.HiddenDynamic = value;
			}
		}

		// Token: 0x17005A75 RID: 23157
		// (get) Token: 0x0600B45B RID: 46171 RVA: 0x00A72808 File Offset: 0x00A70A08
		public bool CnvWideASTRODataTxRespRandomRangeMs_A9563_HasDiffs
		{
			get
			{
				short num = (short)689161299;
				short num2 = num;
				num = (short)168019027;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1660944384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)460390401;
				if (num != 0)
				{
				}
				num = (short)2013003776;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxRespRandomRangeMs_A9563._HasDiffs;
			}
		}

		// Token: 0x17005A76 RID: 23158
		// (get) Token: 0x0600B45C RID: 46172 RVA: 0x00A728BC File Offset: 0x00A70ABC
		// (set) Token: 0x0600B45D RID: 46173 RVA: 0x00A72974 File Offset: 0x00A70B74
		public int CnvWideASTRODataTxShortRandomRangeMs_A9565Value
		{
			get
			{
				short num = (short)1264336596;
				short num2 = num;
				num = (short)1153711828;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1691549696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1392508928;
				if (num != 0)
				{
				}
				num = (short)951582721;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxShortRandomRangeMs_A9565.Value;
			}
			set
			{
				short num = (short)414897523;
				short num2 = num;
				num = (short)1894045043;
				switch (num2 == num)
				{
				default:
				{
					num = (short)806748160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)84344832;
				if (num != 0)
				{
				}
				num = (short)1193279489;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxShortRandomRangeMs_A9565.Value = value;
			}
		}

		// Token: 0x17005A77 RID: 23159
		// (get) Token: 0x0600B45E RID: 46174 RVA: 0x00A72A28 File Offset: 0x00A70C28
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvWideASTRODataTxShortRandomRangeMs_A9565
		{
			get
			{
				short num = (short)1974010353;
				short num2 = num;
				num = (short)1660551665;
				switch (num2 == num)
				{
				default:
				{
					num = (short)700448768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2009399297;
				if (num != 0)
				{
				}
				num = (short)480837632;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxShortRandomRangeMs_A9565;
			}
		}

		// Token: 0x17005A78 RID: 23160
		// (get) Token: 0x0600B45F RID: 46175 RVA: 0x00A72AD8 File Offset: 0x00A70CD8
		// (set) Token: 0x0600B460 RID: 46176 RVA: 0x00A72B8C File Offset: 0x00A70D8C
		public string CnvWideASTRODataTxShortRandomRangeMs_A9565_UIValue
		{
			get
			{
				short num = (short)2001884663;
				short num2 = num;
				num = (short)1618499063;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2026045440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)44040193;
				if (num != 0)
				{
				}
				num = (short)1033306112;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxShortRandomRangeMs_A9565.UIValue;
			}
			set
			{
				short num = (short)395542367;
				short num2 = num;
				num = (short)1526824799;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1906180096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2052259841;
				if (num != 0)
				{
				}
				num = (short)1409875968;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxShortRandomRangeMs_A9565.UIValue = value;
			}
		}

		// Token: 0x17005A79 RID: 23161
		// (get) Token: 0x0600B461 RID: 46177 RVA: 0x00A72C40 File Offset: 0x00A70E40
		// (set) Token: 0x0600B462 RID: 46178 RVA: 0x00A72CF4 File Offset: 0x00A70EF4
		internal int CnvWideASTRODataTxShortRandomRangeMs_A9565Min
		{
			get
			{
				short num = (short)1187474927;
				short num2 = num;
				num = (short)668429807;
				switch (num2 == num)
				{
				default:
				{
					num = (short)133300224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1741815809;
				if (num != 0)
				{
				}
				num = (short)1608253440;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxShortRandomRangeMs_A9565.Min;
			}
			set
			{
				short num = (short)380732063;
				short num2 = num;
				num = (short)964330143;
				switch (num2 == num)
				{
				default:
				{
					num = (short)856096768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)198901761;
				if (num != 0)
				{
				}
				num = (short)1499332608;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxShortRandomRangeMs_A9565.Min = value;
			}
		}

		// Token: 0x17005A7A RID: 23162
		// (get) Token: 0x0600B463 RID: 46179 RVA: 0x00A72DA8 File Offset: 0x00A70FA8
		// (set) Token: 0x0600B464 RID: 46180 RVA: 0x00A72E5C File Offset: 0x00A7105C
		internal int CnvWideASTRODataTxShortRandomRangeMs_A9565Max
		{
			get
			{
				short num = (short)1761290849;
				short num2 = num;
				num = (short)237513313;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1850146816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2063466496;
				if (num != 0)
				{
				}
				num = (short)1916010497;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxShortRandomRangeMs_A9565.Max;
			}
			set
			{
				short num = (short)218840221;
				short num2 = num;
				num = (short)2089303197;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1302659072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)591396865;
				if (num != 0)
				{
				}
				num = (short)1142358016;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxShortRandomRangeMs_A9565.Max = value;
			}
		}

		// Token: 0x17005A7B RID: 23163
		// (get) Token: 0x0600B465 RID: 46181 RVA: 0x00A72F14 File Offset: 0x00A71114
		// (set) Token: 0x0600B466 RID: 46182 RVA: 0x00A72FC8 File Offset: 0x00A711C8
		internal int CnvWideASTRODataTxShortRandomRangeMs_A9565Step
		{
			get
			{
				short num = (short)489232508;
				short num2 = num;
				num = (short)151394428;
				switch (num2 == num)
				{
				default:
				{
					num = (short)5505024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)664928257;
				if (num != 0)
				{
				}
				num = (short)1188364288;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxShortRandomRangeMs_A9565.StepSize;
			}
			set
			{
				short num = (short)852726470;
				short num2 = num;
				num = (short)1078694598;
				switch (num2 == num)
				{
				default:
				{
					num = (short)507707392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)757727233;
				if (num != 0)
				{
				}
				num = (short)1294073856;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxShortRandomRangeMs_A9565.StepSize = value;
			}
		}

		// Token: 0x17005A7C RID: 23164
		// (get) Token: 0x0600B467 RID: 46183 RVA: 0x00A73080 File Offset: 0x00A71280
		// (set) Token: 0x0600B468 RID: 46184 RVA: 0x00A73134 File Offset: 0x00A71334
		public bool CnvWideASTRODataTxShortRandomRangeMs_A9565_Applicable
		{
			get
			{
				short num = (short)611717677;
				short num2 = num;
				num = (short)2124878381;
				switch (num2 == num)
				{
				default:
				{
					num = (short)288096256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)146079745;
				if (num != 0)
				{
				}
				num = (short)740229120;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxShortRandomRangeMs_A9565.Applicable;
			}
			set
			{
				short num = (short)398375300;
				short num2 = num;
				num = (short)348830084;
				switch (num2 == num)
				{
				}
				num = (short)1456472064;
				short num3 = num;
				num = (short)1344536576;
				if (num != 0)
				{
				}
				num = (short)1538916353;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxShortRandomRangeMs_A9565.Applicable = value;
			}
		}

		// Token: 0x17005A7D RID: 23165
		// (get) Token: 0x0600B469 RID: 46185 RVA: 0x00A731EC File Offset: 0x00A713EC
		// (set) Token: 0x0600B46A RID: 46186 RVA: 0x00A732A0 File Offset: 0x00A714A0
		public bool CnvWideASTRODataTxShortRandomRangeMs_A9565_Valid
		{
			get
			{
				short num = (short)1006721739;
				short num2 = num;
				num = (short)2089179851;
				switch (num2 == num)
				{
				}
				num = (short)544997376;
				short num3 = num;
				num = (short)298713089;
				if (num != 0)
				{
				}
				num = (short)250740736;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxShortRandomRangeMs_A9565.Valid;
			}
			set
			{
				short num = (short)2110586881;
				if (num != 0)
				{
				}
				num = (short)1851979818;
				short num2 = num;
				num = (short)458553386;
				switch (num2 == num)
				{
				default:
				{
					num = (short)775421952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1651834880;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxShortRandomRangeMs_A9565.Valid = value;
			}
		}

		// Token: 0x17005A7E RID: 23166
		// (get) Token: 0x0600B46B RID: 46187 RVA: 0x00A73358 File Offset: 0x00A71558
		// (set) Token: 0x0600B46C RID: 46188 RVA: 0x00A73410 File Offset: 0x00A71610
		public bool CnvWideASTRODataTxShortRandomRangeMs_A9565_Visible
		{
			get
			{
				short num = (short)653014370;
				short num2 = num;
				num = (short)621229410;
				switch (num2 == num)
				{
				}
				num = (short)1649278976;
				short num3 = num;
				num = (short)1903755264;
				if (num != 0)
				{
				}
				num = (short)1034158081;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxShortRandomRangeMs_A9565.Visible;
			}
			set
			{
				short num = (short)883017151;
				short num2 = num;
				num = (short)908641727;
				switch (num2 == num)
				{
				}
				num = (short)102760448;
				short num3 = num;
				num = (short)10878977;
				if (num != 0)
				{
				}
				num = (short)1625358336;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxShortRandomRangeMs_A9565.Visible = value;
			}
		}

		// Token: 0x17005A7F RID: 23167
		// (get) Token: 0x0600B46D RID: 46189 RVA: 0x00A734C4 File Offset: 0x00A716C4
		// (set) Token: 0x0600B46E RID: 46190 RVA: 0x00A73578 File Offset: 0x00A71778
		public bool CnvWideASTRODataTxShortRandomRangeMs_A9565_Editable
		{
			get
			{
				short num = (short)474321466;
				short num2 = num;
				num = (short)1636799034;
				switch (num2 == num)
				{
				}
				num = (short)1830813696;
				short num3 = num;
				num = (short)1805058049;
				if (num != 0)
				{
				}
				num = (short)1428815872;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxShortRandomRangeMs_A9565.Editable;
			}
			set
			{
				short num = (short)2062637748;
				short num2 = num;
				num = (short)44915380;
				switch (num2 == num)
				{
				}
				num = (short)1463812096;
				short num3 = num;
				num = (short)1843134464;
				if (num != 0)
				{
				}
				num = (short)2055012353;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxShortRandomRangeMs_A9565.Editable = value;
			}
		}

		// Token: 0x17005A80 RID: 23168
		// (get) Token: 0x0600B46F RID: 46191 RVA: 0x00A73630 File Offset: 0x00A71830
		internal string CnvWideASTRODataTxShortRandomRangeMs_A9565_UILabel
		{
			get
			{
				short num = (short)14044326;
				short num2 = num;
				num = (short)1086868646;
				switch (num2 == num)
				{
				}
				num = (short)877002752;
				short num3 = num;
				num = (short)848625665;
				if (num != 0)
				{
				}
				num = (short)701497344;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxShortRandomRangeMs_A9565.UIName;
			}
		}

		// Token: 0x17005A81 RID: 23169
		// (get) Token: 0x0600B470 RID: 46192 RVA: 0x00A736E4 File Offset: 0x00A718E4
		// (set) Token: 0x0600B471 RID: 46193 RVA: 0x00A7379C File Offset: 0x00A7199C
		internal bool CnvWideASTRODataTxShortRandomRangeMs_A9565_HiddenStatic
		{
			get
			{
				short num = (short)173779419;
				short num2 = num;
				num = (short)1918609883;
				switch (num2 == num)
				{
				}
				num = (short)324075520;
				short num3 = num;
				num = (short)334757889;
				if (num != 0)
				{
				}
				num = (short)1681457152;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxShortRandomRangeMs_A9565.HiddenStatic;
			}
			set
			{
				short num = (short)1815368642;
				short num2 = num;
				num = (short)458904514;
				switch (num2 == num)
				{
				}
				num = (short)1441071104;
				short num3 = num;
				num = (short)1728184320;
				if (num != 0)
				{
				}
				num = (short)1179582465;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxShortRandomRangeMs_A9565.HiddenStatic = value;
			}
		}

		// Token: 0x17005A82 RID: 23170
		// (get) Token: 0x0600B472 RID: 46194 RVA: 0x00A73854 File Offset: 0x00A71A54
		// (set) Token: 0x0600B473 RID: 46195 RVA: 0x00A73908 File Offset: 0x00A71B08
		internal bool CnvWideASTRODataTxShortRandomRangeMs_A9565_HiddenDynamic
		{
			get
			{
				short num = (short)1822851973;
				short num2 = num;
				num = (short)63538053;
				switch (num2 == num)
				{
				}
				num = (short)1964441600;
				short num3 = num;
				num = (short)1954283520;
				if (num != 0)
				{
				}
				num = (short)212533249;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxShortRandomRangeMs_A9565.HiddenDynamic;
			}
			set
			{
				short num = (short)425548940;
				short num2 = num;
				num = (short)1854168204;
				switch (num2 == num)
				{
				}
				num = (short)1085997056;
				short num3 = num;
				num = (short)1595080704;
				if (num != 0)
				{
				}
				num = (short)312737793;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataTxShortRandomRangeMs_A9565.HiddenDynamic = value;
			}
		}

		// Token: 0x17005A83 RID: 23171
		// (get) Token: 0x0600B474 RID: 46196 RVA: 0x00A739C0 File Offset: 0x00A71BC0
		public bool CnvWideASTRODataTxShortRandomRangeMs_A9565_HasDiffs
		{
			get
			{
				short num = (short)363532649;
				short num2 = num;
				num = (short)299176297;
				switch (num2 == num)
				{
				}
				num = (short)1544421376;
				short num3 = num;
				num = (short)1991901184;
				if (num != 0)
				{
				}
				num = (short)471072769;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataTxShortRandomRangeMs_A9565._HasDiffs;
			}
		}

		// Token: 0x17005A84 RID: 23172
		// (get) Token: 0x0600B475 RID: 46197 RVA: 0x00A73A74 File Offset: 0x00A71C74
		// (set) Token: 0x0600B476 RID: 46198 RVA: 0x00A73B28 File Offset: 0x00A71D28
		public int CnvWideASTRODataMaxPacketSizebytes_A8471Value
		{
			get
			{
				short num = (short)902496257;
				if (num != 0)
				{
				}
				num = (short)625045855;
				short num2 = num;
				num = (short)212234591;
				switch (num2 == num)
				{
				default:
				{
					num = (short)111214592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2019360768;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxPacketSizebytes_A8471.Value;
			}
			set
			{
				short num = (short)674345458;
				short num2 = num;
				num = (short)1272623602;
				switch (num2 == num)
				{
				}
				num = (short)269942784;
				short num3 = num;
				num = (short)1211695104;
				if (num != 0)
				{
				}
				num = (short)673841153;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMaxPacketSizebytes_A8471.Value = value;
			}
		}

		// Token: 0x17005A85 RID: 23173
		// (get) Token: 0x0600B477 RID: 46199 RVA: 0x00A73BE0 File Offset: 0x00A71DE0
		public global::AcpBusinessLayer.AcpRangeField<int, string> CnvWideASTRODataMaxPacketSizebytes_A8471
		{
			get
			{
				short num = (short)687308495;
				short num2 = num;
				num = (short)1253932751;
				switch (num2 == num)
				{
				}
				num = (short)1380581376;
				short num3 = num;
				num = (short)447479809;
				if (num != 0)
				{
				}
				num = (short)1323302912;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxPacketSizebytes_A8471;
			}
		}

		// Token: 0x17005A86 RID: 23174
		// (get) Token: 0x0600B478 RID: 46200 RVA: 0x00A73C90 File Offset: 0x00A71E90
		// (set) Token: 0x0600B479 RID: 46201 RVA: 0x00A73D44 File Offset: 0x00A71F44
		public string CnvWideASTRODataMaxPacketSizebytes_A8471_UIValue
		{
			get
			{
				short num = (short)580267138;
				short num2 = num;
				num = (short)561851522;
				switch (num2 == num)
				{
				}
				num = (short)992673792;
				short num3 = num;
				num = (short)1417543680;
				if (num != 0)
				{
				}
				num = (short)1657077761;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxPacketSizebytes_A8471.UIValue;
			}
			set
			{
				short num = (short)2099333721;
				short num2 = num;
				num = (short)33442393;
				switch (num2 == num)
				{
				}
				num = (short)1822883840;
				short num3 = num;
				num = (short)333512705;
				if (num != 0)
				{
				}
				num = (short)51576832;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMaxPacketSizebytes_A8471.UIValue = value;
			}
		}

		// Token: 0x17005A87 RID: 23175
		// (get) Token: 0x0600B47A RID: 46202 RVA: 0x00A73DFC File Offset: 0x00A71FFC
		// (set) Token: 0x0600B47B RID: 46203 RVA: 0x00A73EB4 File Offset: 0x00A720B4
		internal int CnvWideASTRODataMaxPacketSizebytes_A8471Min
		{
			get
			{
				short num = (short)1989604626;
				short num2 = num;
				num = (short)709489938;
				switch (num2 == num)
				{
				}
				num = (short)857473024;
				short num3 = num;
				num = (short)766836737;
				if (num != 0)
				{
				}
				num = (short)1222246400;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxPacketSizebytes_A8471.Min;
			}
			set
			{
				short num = (short)55021796;
				short num2 = num;
				num = (short)58953956;
				switch (num2 == num)
				{
				}
				num = (short)1135411200;
				short num3 = num;
				num = (short)1696989185;
				if (num != 0)
				{
				}
				num = (short)828309504;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMaxPacketSizebytes_A8471.Min = value;
			}
		}

		// Token: 0x17005A88 RID: 23176
		// (get) Token: 0x0600B47C RID: 46204 RVA: 0x00A73F6C File Offset: 0x00A7216C
		// (set) Token: 0x0600B47D RID: 46205 RVA: 0x00A74020 File Offset: 0x00A72220
		internal int CnvWideASTRODataMaxPacketSizebytes_A8471Max
		{
			get
			{
				short num = (short)1730258818;
				short num2 = num;
				num = (short)618243970;
				switch (num2 == num)
				{
				}
				num = (short)1471086592;
				short num3 = num;
				num = (short)463142913;
				if (num != 0)
				{
				}
				num = (short)801046528;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxPacketSizebytes_A8471.Max;
			}
			set
			{
				short num = (short)1888354305;
				if (num != 0)
				{
				}
				num = (short)1022349496;
				short num2 = num;
				num = (short)2079445176;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1517420544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)860291072;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMaxPacketSizebytes_A8471.Max = value;
			}
		}

		// Token: 0x17005A89 RID: 23177
		// (get) Token: 0x0600B47E RID: 46206 RVA: 0x00A740D4 File Offset: 0x00A722D4
		// (set) Token: 0x0600B47F RID: 46207 RVA: 0x00A74188 File Offset: 0x00A72388
		internal int CnvWideASTRODataMaxPacketSizebytes_A8471Step
		{
			get
			{
				short num = (short)826400446;
				short num2 = num;
				num = (short)1677319870;
				switch (num2 == num)
				{
				}
				num = (short)668008448;
				short num3 = num;
				num = (short)1292566529;
				if (num != 0)
				{
				}
				num = (short)330104832;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxPacketSizebytes_A8471.StepSize;
			}
			set
			{
				short num = (short)1181213382;
				short num2 = num;
				num = (short)600695494;
				switch (num2 == num)
				{
				}
				num = (short)999358464;
				short num3 = num;
				num = (short)13893633;
				if (num != 0)
				{
				}
				num = (short)1932197888;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMaxPacketSizebytes_A8471.StepSize = value;
			}
		}

		// Token: 0x17005A8A RID: 23178
		// (get) Token: 0x0600B480 RID: 46208 RVA: 0x00A7423C File Offset: 0x00A7243C
		// (set) Token: 0x0600B481 RID: 46209 RVA: 0x00A742F0 File Offset: 0x00A724F0
		public bool CnvWideASTRODataMaxPacketSizebytes_A8471_Applicable
		{
			get
			{
				short num = (short)1035696610;
				short num2 = num;
				num = (short)97810914;
				switch (num2 == num)
				{
				}
				num = (short)157089792;
				short num3 = num;
				num = (short)611319808;
				if (num != 0)
				{
				}
				num = (short)814415873;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxPacketSizebytes_A8471.Applicable;
			}
			set
			{
				short num = (short)172463906;
				short num2 = num;
				num = (short)989501218;
				switch (num2 == num)
				{
				}
				num = (short)1258029056;
				short num3 = num;
				num = (short)297467905;
				if (num != 0)
				{
				}
				num = (short)880607232;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMaxPacketSizebytes_A8471.Applicable = value;
			}
		}

		// Token: 0x17005A8B RID: 23179
		// (get) Token: 0x0600B482 RID: 46210 RVA: 0x00A743A8 File Offset: 0x00A725A8
		// (set) Token: 0x0600B483 RID: 46211 RVA: 0x00A74460 File Offset: 0x00A72660
		public bool CnvWideASTRODataMaxPacketSizebytes_A8471_Valid
		{
			get
			{
				short num = (short)1169620993;
				if (num != 0)
				{
				}
				num = (short)846831058;
				short num2 = num;
				num = (short)1098620370;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1399848960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1148977152;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxPacketSizebytes_A8471.Valid;
			}
			set
			{
				short num = (short)1374879745;
				if (num != 0)
				{
				}
				num = (short)377929284;
				short num2 = num;
				num = (short)1174453828;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1002635264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)451543040;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMaxPacketSizebytes_A8471.Valid = value;
			}
		}

		// Token: 0x17005A8C RID: 23180
		// (get) Token: 0x0600B484 RID: 46212 RVA: 0x00A74514 File Offset: 0x00A72714
		// (set) Token: 0x0600B485 RID: 46213 RVA: 0x00A745C8 File Offset: 0x00A727C8
		public bool CnvWideASTRODataMaxPacketSizebytes_A8471_Visible
		{
			get
			{
				short num = (short)1020987168;
				short num2 = num;
				num = (short)925501216;
				switch (num2 == num)
				{
				}
				num = (short)1263206400;
				short num3 = num;
				num = (short)562364416;
				if (num != 0)
				{
				}
				num = (short)1394606081;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxPacketSizebytes_A8471.Visible;
			}
			set
			{
				short num = (short)222278351;
				short num2 = num;
				num = (short)706523855;
				switch (num2 == num)
				{
				}
				num = (short)1881800704;
				short num3 = num;
				num = (short)1335099392;
				if (num != 0)
				{
				}
				num = (short)1627455489;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMaxPacketSizebytes_A8471.Visible = value;
			}
		}

		// Token: 0x17005A8D RID: 23181
		// (get) Token: 0x0600B486 RID: 46214 RVA: 0x00A7467C File Offset: 0x00A7287C
		// (set) Token: 0x0600B487 RID: 46215 RVA: 0x00A74730 File Offset: 0x00A72930
		public bool CnvWideASTRODataMaxPacketSizebytes_A8471_Editable
		{
			get
			{
				short num = (short)373082057;
				short num2 = num;
				num = (short)1346357193;
				switch (num2 == num)
				{
				}
				num = (short)297140224;
				short num3 = num;
				num = (short)1478754305;
				if (num != 0)
				{
				}
				num = (short)1189543936;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxPacketSizebytes_A8471.Editable;
			}
			set
			{
				short num = (short)2001338369;
				if (num != 0)
				{
				}
				num = (short)237909316;
				short num2 = num;
				num = (short)593769796;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1154023424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1270808576;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMaxPacketSizebytes_A8471.Editable = value;
			}
		}

		// Token: 0x17005A8E RID: 23182
		// (get) Token: 0x0600B488 RID: 46216 RVA: 0x00A747E8 File Offset: 0x00A729E8
		internal string CnvWideASTRODataMaxPacketSizebytes_A8471_UILabel
		{
			get
			{
				short num = (short)137316577;
				short num2 = num;
				num = (short)974801121;
				switch (num2 == num)
				{
				}
				num = (short)1229979648;
				short num3 = num;
				num = (short)668598273;
				if (num != 0)
				{
				}
				num = (short)652541952;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxPacketSizebytes_A8471.UIName;
			}
		}

		// Token: 0x17005A8F RID: 23183
		// (get) Token: 0x0600B489 RID: 46217 RVA: 0x00A74898 File Offset: 0x00A72A98
		// (set) Token: 0x0600B48A RID: 46218 RVA: 0x00A74950 File Offset: 0x00A72B50
		internal bool CnvWideASTRODataMaxPacketSizebytes_A8471_HiddenStatic
		{
			get
			{
				short num = (short)1401347667;
				short num2 = num;
				num = (short)1927667283;
				switch (num2 == num)
				{
				}
				num = (short)378404864;
				short num3 = num;
				num = (short)89849856;
				if (num != 0)
				{
				}
				num = (short)1474756609;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxPacketSizebytes_A8471.HiddenStatic;
			}
			set
			{
				short num = (short)983302144;
				short num2 = num;
				num = (short)1918594903;
				short num3 = num;
				num = (short)953118551;
				switch (num3 == num)
				{
				}
				num = (short)1171390464;
				if (num != 0)
				{
				}
				num = (short)162398209;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMaxPacketSizebytes_A8471.HiddenStatic = value;
			}
		}

		// Token: 0x17005A90 RID: 23184
		// (get) Token: 0x0600B48B RID: 46219 RVA: 0x00A74A04 File Offset: 0x00A72C04
		// (set) Token: 0x0600B48C RID: 46220 RVA: 0x00A74AB8 File Offset: 0x00A72CB8
		internal bool CnvWideASTRODataMaxPacketSizebytes_A8471_HiddenDynamic
		{
			get
			{
				short num = (short)935133184;
				short num2 = num;
				num = (short)966568253;
				short num3 = num;
				num = (short)1728424253;
				switch (num3 == num)
				{
				}
				num = (short)895811585;
				if (num != 0)
				{
				}
				num = (short)1265238016;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxPacketSizebytes_A8471.HiddenDynamic;
			}
			set
			{
				short num = (short)647299072;
				short num2 = num;
				num = (short)387078639;
				short num3 = num;
				num = (short)1814911471;
				switch (num3 == num)
				{
				}
				num = (short)1569259521;
				if (num != 0)
				{
				}
				num = (short)2069757952;
				if (num != 0)
				{
				}
				this.cnvWideASTRODataMaxPacketSizebytes_A8471.HiddenDynamic = value;
			}
		}

		// Token: 0x17005A91 RID: 23185
		// (get) Token: 0x0600B48D RID: 46221 RVA: 0x00A74B6C File Offset: 0x00A72D6C
		public bool CnvWideASTRODataMaxPacketSizebytes_A8471_HasDiffs
		{
			get
			{
				short num = (short)1434845184;
				short num2 = num;
				num = (short)1153036139;
				short num3 = num;
				num = (short)294186859;
				switch (num3 == num)
				{
				}
				num = (short)544145409;
				if (num != 0)
				{
				}
				num = (short)1173684224;
				if (num != 0)
				{
				}
				return this.cnvWideASTRODataMaxPacketSizebytes_A8471._HasDiffs;
			}
		}

		// Token: 0x17005A92 RID: 23186
		// (get) Token: 0x0600B48E RID: 46222 RVA: 0x00A74C20 File Offset: 0x00A72E20
		// (set) Token: 0x0600B48F RID: 46223 RVA: 0x00A74CD4 File Offset: 0x00A72ED4
		public int CnvWideConventionalCustomerID_41558Value
		{
			get
			{
				short num = (short)950206464;
				short num2 = num;
				num = (short)157113814;
				short num3 = num;
				num = (short)1641307606;
				switch (num3 == num)
				{
				}
				num = (short)605683712;
				if (num != 0)
				{
				}
				num = (short)1392836609;
				if (num != 0)
				{
				}
				return this.cnvWideConventionalCustomerID_41558.Value;
			}
			set
			{
				short num = (short)2084372480;
				short num2 = num;
				num = (short)2130006344;
				short num3 = num;
				num = (short)1075269960;
				switch (num3 == num)
				{
				}
				num = (short)1112604673;
				if (num != 0)
				{
				}
				num = (short)1468465152;
				if (num != 0)
				{
				}
				this.cnvWideConventionalCustomerID_41558.Value = value;
			}
		}

		// Token: 0x17005A93 RID: 23187
		// (get) Token: 0x0600B490 RID: 46224 RVA: 0x00A74D88 File Offset: 0x00A72F88
		public global::AcpBusinessLayer.AcpRangeField<int, string> CnvWideConventionalCustomerID_41558
		{
			get
			{
				short num = (short)95354880;
				short num2 = num;
				num = (short)1687591288;
				short num3 = num;
				num = (short)1579981176;
				switch (num3 == num)
				{
				}
				num = (short)2125594625;
				if (num != 0)
				{
				}
				num = (short)23330816;
				if (num != 0)
				{
				}
				return this.cnvWideConventionalCustomerID_41558;
			}
		}

		// Token: 0x17005A94 RID: 23188
		// (get) Token: 0x0600B491 RID: 46225 RVA: 0x00A74E38 File Offset: 0x00A73038
		// (set) Token: 0x0600B492 RID: 46226 RVA: 0x00A74EEC File Offset: 0x00A730EC
		public string CnvWideConventionalCustomerID_41558_UIValue
		{
			get
			{
				short num = (short)722010112;
				short num2 = num;
				num = (short)494387301;
				short num3 = num;
				num = (short)1759821925;
				switch (num3 == num)
				{
				}
				num = (short)2117337089;
				if (num != 0)
				{
				}
				num = (short)988348416;
				if (num != 0)
				{
				}
				return this.cnvWideConventionalCustomerID_41558.UIValue;
			}
			set
			{
				short num = (short)1531838464;
				short num2 = num;
				num = (short)1961892471;
				short num3 = num;
				num = (short)2040732279;
				switch (num3 == num)
				{
				}
				num = (short)1732837377;
				if (num != 0)
				{
				}
				num = (short)462946304;
				if (num != 0)
				{
				}
				this.cnvWideConventionalCustomerID_41558.UIValue = value;
			}
		}

		// Token: 0x17005A95 RID: 23189
		// (get) Token: 0x0600B493 RID: 46227 RVA: 0x00A74FA4 File Offset: 0x00A731A4
		// (set) Token: 0x0600B494 RID: 46228 RVA: 0x00A75058 File Offset: 0x00A73258
		internal int CnvWideConventionalCustomerID_41558Min
		{
			get
			{
				short num = (short)505413632;
				short num2 = num;
				num = (short)148040465;
				short num3 = num;
				num = (short)1884285713;
				switch (num3 == num)
				{
				}
				num = (short)1718091776;
				if (num != 0)
				{
				}
				num = (short)1481506817;
				if (num != 0)
				{
				}
				return this.cnvWideConventionalCustomerID_41558.Min;
			}
			set
			{
				short num = (short)357367808;
				short num2 = num;
				num = (short)252510209;
				if (num != 0)
				{
				}
				num = (short)689197549;
				short num3 = num;
				num = (short)732189165;
				switch (num3 == num)
				{
				}
				num = (short)1894645760;
				if (num != 0)
				{
				}
				this.cnvWideConventionalCustomerID_41558.Min = value;
			}
		}

		// Token: 0x17005A96 RID: 23190
		// (get) Token: 0x0600B495 RID: 46229 RVA: 0x00A75110 File Offset: 0x00A73310
		// (set) Token: 0x0600B496 RID: 46230 RVA: 0x00A751C4 File Offset: 0x00A733C4
		internal int CnvWideConventionalCustomerID_41558Max
		{
			get
			{
				short num = (short)1476896101;
				short num2 = num;
				num = (short)302228837;
				switch (num2 == num)
				{
				}
				num = (short)1563688961;
				if (num != 0)
				{
				}
				num = (short)1066663936;
				short num3 = num;
				num = (short)1604255744;
				if (num != 0)
				{
				}
				return this.cnvWideConventionalCustomerID_41558.Max;
			}
			set
			{
				short num = (short)550388877;
				short num2 = num;
				num = (short)105923725;
				switch (num2 == num)
				{
				}
				num = (short)1905655809;
				if (num != 0)
				{
				}
				num = (short)550699008;
				short num3 = num;
				num = (short)1836646400;
				if (num != 0)
				{
				}
				this.cnvWideConventionalCustomerID_41558.Max = value;
			}
		}

		// Token: 0x17005A97 RID: 23191
		// (get) Token: 0x0600B497 RID: 46231 RVA: 0x00A75278 File Offset: 0x00A73478
		// (set) Token: 0x0600B498 RID: 46232 RVA: 0x00A75330 File Offset: 0x00A73530
		internal int CnvWideConventionalCustomerID_41558Step
		{
			get
			{
				short num = (short)1697910272;
				short num2 = num;
				num = (short)187436544;
				switch (num2 == num)
				{
				}
				num = (short)719126529;
				if (num != 0)
				{
				}
				num = (short)1451491328;
				short num3 = num;
				num = (short)521207808;
				if (num != 0)
				{
				}
				return this.cnvWideConventionalCustomerID_41558.StepSize;
			}
			set
			{
				short num = (short)1191164925;
				short num2 = num;
				num = (short)1242086397;
				switch (num2 == num)
				{
				}
				num = (short)898236417;
				if (num != 0)
				{
				}
				num = (short)831324160;
				short num3 = num;
				num = (short)1682374656;
				if (num != 0)
				{
				}
				this.cnvWideConventionalCustomerID_41558.StepSize = value;
			}
		}

		// Token: 0x17005A98 RID: 23192
		// (get) Token: 0x0600B499 RID: 46233 RVA: 0x00A753E8 File Offset: 0x00A735E8
		// (set) Token: 0x0600B49A RID: 46234 RVA: 0x00A7549C File Offset: 0x00A7369C
		public bool CnvWideConventionalCustomerID_41558_Applicable
		{
			get
			{
				short num = (short)959579087;
				short num2 = num;
				num = (short)107152335;
				switch (num2 == num)
				{
				}
				num = (short)1358757889;
				if (num != 0)
				{
				}
				num = (short)748617728;
				short num3 = num;
				num = (short)37486592;
				if (num != 0)
				{
				}
				return this.cnvWideConventionalCustomerID_41558.Applicable;
			}
			set
			{
				short num = (short)1292369375;
				short num2 = num;
				num = (short)1166736863;
				switch (num2 == num)
				{
				}
				num = (short)1862991872;
				if (num != 0)
				{
				}
				num = (short)777781248;
				short num3 = num;
				num = (short)925171713;
				if (num != 0)
				{
				}
				this.cnvWideConventionalCustomerID_41558.Applicable = value;
			}
		}

		// Token: 0x17005A99 RID: 23193
		// (get) Token: 0x0600B49B RID: 46235 RVA: 0x00A75554 File Offset: 0x00A73754
		// (set) Token: 0x0600B49C RID: 46236 RVA: 0x00A75608 File Offset: 0x00A73808
		public bool CnvWideConventionalCustomerID_41558_Valid
		{
			get
			{
				short num = (short)502133315;
				short num2 = num;
				num = (short)4387395;
				switch (num2 == num)
				{
				}
				num = (short)563019777;
				if (num != 0)
				{
				}
				num = (short)610271232;
				short num3 = num;
				num = (short)814809088;
				if (num != 0)
				{
				}
				return this.cnvWideConventionalCustomerID_41558.Valid;
			}
			set
			{
				short num = (short)1710358529;
				if (num != 0)
				{
				}
				num = (short)840377194;
				short num2 = num;
				num = (short)958341994;
				switch (num2 == num)
				{
				}
				num = (short)736165888;
				short num3 = num;
				num = (short)280625152;
				if (num != 0)
				{
				}
				this.cnvWideConventionalCustomerID_41558.Valid = value;
			}
		}

		// Token: 0x17005A9A RID: 23194
		// (get) Token: 0x0600B49D RID: 46237 RVA: 0x00A756C0 File Offset: 0x00A738C0
		// (set) Token: 0x0600B49E RID: 46238 RVA: 0x00A75774 File Offset: 0x00A73974
		public bool CnvWideConventionalCustomerID_41558_Visible
		{
			get
			{
				short num = (short)885587969;
				if (num != 0)
				{
				}
				num = (short)970719714;
				short num2 = num;
				num = (short)241828322;
				switch (num2 == num)
				{
				}
				num = (short)362151936;
				short num3 = num;
				num = (short)1547239424;
				if (num != 0)
				{
				}
				return this.cnvWideConventionalCustomerID_41558.Visible;
			}
			set
			{
				short num = (short)2026465963;
				short num2 = num;
				num = (short)942172843;
				switch (num2 == num)
				{
				}
				num = (short)1258225665;
				if (num != 0)
				{
				}
				num = (short)1810169856;
				short num3 = num;
				num = (short)1338703872;
				if (num != 0)
				{
				}
				this.cnvWideConventionalCustomerID_41558.Visible = value;
			}
		}

		// Token: 0x17005A9B RID: 23195
		// (get) Token: 0x0600B49F RID: 46239 RVA: 0x00A7582C File Offset: 0x00A73A2C
		// (set) Token: 0x0600B4A0 RID: 46240 RVA: 0x00A758E0 File Offset: 0x00A73AE0
		public bool CnvWideConventionalCustomerID_41558_Editable
		{
			get
			{
				short num = (short)195422412;
				short num2 = num;
				num = (short)1260710092;
				switch (num2 == num)
				{
				}
				num = (short)894173184;
				if (num != 0)
				{
				}
				num = (short)880017408;
				short num3 = num;
				num = (short)1859780609;
				if (num != 0)
				{
				}
				return this.cnvWideConventionalCustomerID_41558.Editable;
			}
			set
			{
				short num = (short)752188429;
				short num2 = num;
				num = (short)1364098061;
				switch (num2 == num)
				{
				}
				num = (short)1041825792;
				if (num != 0)
				{
				}
				num = (short)967376896;
				short num3 = num;
				num = (short)1759576065;
				if (num != 0)
				{
				}
				this.cnvWideConventionalCustomerID_41558.Editable = value;
			}
		}

		// Token: 0x17005A9C RID: 23196
		// (get) Token: 0x0600B4A1 RID: 46241 RVA: 0x00A75998 File Offset: 0x00A73B98
		internal string CnvWideConventionalCustomerID_41558_UILabel
		{
			get
			{
				short num = (short)2096174435;
				short num2 = num;
				num = (short)12457315;
				switch (num2 == num)
				{
				}
				num = (short)580190209;
				if (num != 0)
				{
				}
				num = (short)1381236736;
				short num3 = num;
				num = (short)1582759936;
				if (num != 0)
				{
				}
				return this.cnvWideConventionalCustomerID_41558.UIName;
			}
		}

		// Token: 0x17005A9D RID: 23197
		// (get) Token: 0x0600B4A2 RID: 46242 RVA: 0x00A75A4C File Offset: 0x00A73C4C
		// (set) Token: 0x0600B4A3 RID: 46243 RVA: 0x00A75B04 File Offset: 0x00A73D04
		internal bool CnvWideConventionalCustomerID_41558_HiddenStatic
		{
			get
			{
				short num = (short)1118944127;
				short num2 = num;
				num = (short)1018870655;
				switch (num2 == num)
				{
				}
				num = (short)832110592;
				if (num != 0)
				{
				}
				num = (short)1279524864;
				short num3 = num;
				num = (short)1081802753;
				if (num != 0)
				{
				}
				return this.cnvWideConventionalCustomerID_41558.HiddenStatic;
			}
			set
			{
				short num = (short)967245825;
				if (num != 0)
				{
				}
				num = (short)515845789;
				short num2 = num;
				num = (short)1522871965;
				switch (num2 == num)
				{
				}
				num = (short)1013448704;
				short num3 = num;
				num = (short)1765670912;
				if (num != 0)
				{
				}
				this.cnvWideConventionalCustomerID_41558.HiddenStatic = value;
			}
		}

		// Token: 0x17005A9E RID: 23198
		// (get) Token: 0x0600B4A4 RID: 46244 RVA: 0x00A75BBC File Offset: 0x00A73DBC
		// (set) Token: 0x0600B4A5 RID: 46245 RVA: 0x00A75C70 File Offset: 0x00A73E70
		internal bool CnvWideConventionalCustomerID_41558_HiddenDynamic
		{
			get
			{
				short num = (short)1748038760;
				short num2 = num;
				num = (short)561181800;
				switch (num2 == num)
				{
				}
				num = (short)1323761665;
				if (num != 0)
				{
				}
				num = (short)1799618560;
				short num3 = num;
				num = (short)1864892416;
				if (num != 0)
				{
				}
				return this.cnvWideConventionalCustomerID_41558.HiddenDynamic;
			}
			set
			{
				short num = (short)603692144;
				short num2 = num;
				num = (short)581803120;
				switch (num2 == num)
				{
				}
				num = (short)523501568;
				if (num != 0)
				{
				}
				num = (short)886112256;
				short num3 = num;
				num = (short)2094399489;
				if (num != 0)
				{
				}
				this.cnvWideConventionalCustomerID_41558.HiddenDynamic = value;
			}
		}

		// Token: 0x17005A9F RID: 23199
		// (get) Token: 0x0600B4A6 RID: 46246 RVA: 0x00A75D24 File Offset: 0x00A73F24
		public bool CnvWideConventionalCustomerID_41558_HasDiffs
		{
			get
			{
				short num = (short)1440499077;
				short num2 = num;
				num = (short)1664370053;
				switch (num2 == num)
				{
				}
				num = (short)1655898113;
				if (num != 0)
				{
				}
				num = (short)2105868288;
				short num3 = num;
				num = (short)507510784;
				if (num != 0)
				{
				}
				return this.cnvWideConventionalCustomerID_41558._HasDiffs;
			}
		}

		// Token: 0x17005AA0 RID: 23200
		// (get) Token: 0x0600B4A7 RID: 46247 RVA: 0x00A75DD8 File Offset: 0x00A73FD8
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)2131949324;
				short num2 = num;
				num = (short)1103689484;
				switch (num2 == num)
				{
				}
				num = (short)46333953;
				if (num != 0)
				{
				}
				num = (short)401997824;
				short num3 = num;
				num = (short)301531136;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x0600B4A8 RID: 46248 RVA: 0x00A75E98 File Offset: 0x00A74098
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
						num2 = (short)45678593;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					for (;;)
					{
						num2 = (short)797740024;
						short num3 = num2;
						num2 = (short)252611576;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_BE;
						}
					}
					IL_BE:
					num2 = (short)384172033;
					if (num2 != 0)
					{
					}
					num2 = (short)1103167488;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)767754242;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return result;
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)462880772;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					num2 = (short)564133888;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			num2 = (short)1573978112;
			short num4 = num2;
			result = null;
			num2 = (short)447610883;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040057A8 RID: 22440
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvWideASTRODataARPCacheDepth_A7463;

		// Token: 0x040057A9 RID: 22441
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvWideASTRODataARPCacheTimehrs_A7464;

		// Token: 0x040057AA RID: 22442
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvWideASTRODataFrameSyncSeekPeriodms_A8145;

		// Token: 0x040057AB RID: 22443
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvWideASTRODataTxLimitedPatienceSec_A9544;

		// Token: 0x040057AC RID: 22444
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvWideASTRODataMaxTxAttempts_A8474;

		// Token: 0x040057AD RID: 22445
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvWideASTRODataMinResponseTimerms_A8514;

		// Token: 0x040057AE RID: 22446
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvWideASTRODataResponseTimerms_A8948;

		// Token: 0x040057AF RID: 22447
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvWideASTRODataTxLongRandomRangeMs_A9546;

		// Token: 0x040057B0 RID: 22448
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvWideASTRODataTxRespRandomRangeMs_A9563;

		// Token: 0x040057B1 RID: 22449
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvWideASTRODataTxShortRandomRangeMs_A9565;

		// Token: 0x040057B2 RID: 22450
		private global::AcpBusinessLayer.AcpRangeField<int, string> cnvWideASTRODataMaxPacketSizebytes_A8471;

		// Token: 0x040057B3 RID: 22451
		private global::AcpBusinessLayer.AcpRangeField<int, string> cnvWideConventionalCustomerID_41558;
	}
}
