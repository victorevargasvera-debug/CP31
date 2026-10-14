using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Features.Converters;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;

namespace Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile
{
	// Token: 0x020000F8 RID: 248
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060024AD RID: 9389 RVA: 0x0023F62C File Offset: 0x0023D82C
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x0023F648 File Offset: 0x0023D848
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			this.b(info, context);
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x0023F668 File Offset: 0x0023D868
		public override void Init()
		{
			int a_ = 6;
			short num = (short)1136486177;
			short num2 = num;
			num = (short)1799317281;
			switch (num2 == num)
			{
			}
			num = (short)1704198144;
			if (num != 0)
			{
			}
			num = (short)892862464;
			short num3 = num;
			num = (short)575668225;
			if (num != 0)
			{
			}
			this.secKmfProfGenIndependentKeyList_43597 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("铆곈꣊蛌ꋎ럐菒꟔룖뿘鳚룜뇞꣠跢臤苦駨軪菬诮铰鷲致볶鳸苺뇼雾爀眂娄㌆㨈㸊㐌㠎", a_), global::CommonResources.AcgResources.ID_INDEPENDENTKEYLIST);
			this.secKmfProfGenIndependentKeyList_43597.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.secKmfProfGenIndependentKeyList_43597.DataTransferOrder = 19;
			this.secKmfProfGenIndependentKeyList_43597.ValidateAcrossRecset = true;
			this.secKmfProfKeyListMgmtEraseAllKeys_43650 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("铆곈꣊蛌ꋎ럐菒꟔룖뿘郚룜ꛞ균諢雤鏦ꓨ質胬鯮듰臲铴蓶鳸뫺釼鏾䨀昂簄理嘈㼊㸌㤎␐⌒", a_), global::CommonResources.AcgResources.ID_KEYLISTMANAGEMENTERASEALLKEYS);
			this.secKmfProfKeyListMgmtEraseAllKeys_43650.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secKmfProfKeyListMgmtEraseAllKeys_43650.DataTransferOrder = 66;
			this.secKmfProfileInfiniteUKEKRetention_43651 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("铆곈꣊蛌ꋎ럐菒꟔룖뿘닚뇜뫞꣠跢菤軦蟨苪駬諮ꓰ룲냴볶꯸黺觼髾漀眂氄栆月吊㤌㰎✐☒␔", a_), global::CommonResources.AcgResources.ID_KEYLISTMANAGEMENTINFINITEUKEKRETENTION);
			this.secKmfProfileInfiniteUKEKRetention_43651.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secKmfProfileInfiniteUKEKRetention_43651.DataTransferOrder = 67;
			this.secKmfProfOTARGenerateKeyLossKey_43652 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("铆곈꣊蛌ꋎ럐菒꟔룖뿘铚觜點돠ꓢ胤触賨駪賬鯮铰룲郴軶뗸铺軼賾䨀昂簄堆㴈㠊㬌㨎⌐", a_), global::CommonResources.AcgResources.ID_KEYLISTMANAGEMENTOTARGENERATEKEYLOSSKEY);
			this.secKmfProfOTARGenerateKeyLossKey_43652.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secKmfProfOTARGenerateKeyLossKey_43652.DataTransferOrder = 68;
			this.secKmfProfKVLFIPSLevel3ApprovedMode_43653 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("铆곈꣊蛌ꋎ럐菒꟔룖뿘郚诜鏞꟠ꫢ뗤듦ꗨ軪鯬諮鷰샲듴蟶觸觺鋼觾搀朂䠄栆洈渊刌㬎∐┒—␖", a_), global::CommonResources.AcgResources.ID_KEYLISTMANAGEMENTKVLFIPSLEVEL3APPROVEDMODE);
			this.secKmfProfKVLFIPSLevel3ApprovedMode_43653.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secKmfProfKVLFIPSLevel3ApprovedMode_43653.DataTransferOrder = 69;
			this.secKmfProfUserSelectable_43657 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("铆곈꣊蛌ꋎ럐菒꟔룖뿘軚껜뫞鏠냢胤详賨裪駬軮鏰鿲郴ꣶ췸죺쯼쫾㘀", a_), global::CommonResources.AcgResources.ID_KEYSETUSERSELECTABLE);
			this.secKmfProfUserSelectable_43657.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secKmfProfUserSelectable_43657.DataTransferOrder = 78;
			this.secKmfProfErasePreviousOnUserChange_43658 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("铆곈꣊蛌ꋎ럐菒꟔룖뿘黚꿜뻞鋠蛢뗤闦賨鷪蓬胮蓰胲뫴駶곸裺飼跾䈀欂搄椆済渊刌㬎∐┒—⼖", a_), global::CommonResources.AcgResources.ID_KEYSETERASEPREVIOUSONUSERCHANGE);
			this.secKmfProfErasePreviousOnUserChange_43658.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secKmfProfErasePreviousOnUserChange_43658.DataTransferOrder = 79;
			this.secKmfProfileSecureProfileGUID_43662 = new global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureProfileGUIDField<string>(global::AllFeatures.CodeplugGuid.NewGuid(), new global::Features.Converters.PackUnpackBigEndianUUID(), this, global::AllFeatures.CodeplugGuid.b("铆곈꣊蛌ꋎ럐菒꟔룖뿘닚뇜뫞닠蛢蛤鋦鯨軪뷬鷮黰闲鳴鯶鳸볺꣼뛾䔀専㄄㐆㼈㴊㼌", a_), global::CommonResources.AcgResources.ID_SECUREPROFILEGUID);
			this.secKmfProfileSecureProfileGUID_43662.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.secKmfProfileSecureProfileGUID_43662.DataTransferOrder = 89;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胆곈ꗊ꣌뷎냐뿒", a_);
			base.Id = 10883;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 5;
			this.c();
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x0023F930 File Offset: 0x0023DB30
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 12;
			short num = (short)1418330133;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_139;
				case 1:
					goto IL_4D2;
				case 2:
					this.secKmfProfileInfiniteUKEKRetention_43651 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("黌꫎닐飒룔뇖觘꧚닜맞裠迢胤껦蟨跪蓬臮飰蟲郴ꋶ닸뻺뛼귾搀眂怄椆紈戊戌愎丐✒☔№Ⱈ⨚", a_), global::CommonResources.AcgResources.ID_KEYLISTMANAGEMENTINFINITEUKEKRETENTION);
					this.secKmfProfileInfiniteUKEKRetention_43651.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secKmfProfileInfiniteUKEKRetention_43651.DataTransferOrder = 67;
					num = (short)643235851;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					this.secKmfProfKVLFIPSLevel3ApprovedMode_43653 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("黌꫎닐飒룔뇖觘꧚닜맞ꫠ뗢ꧤꇦꃨ믪뻬ꏮ铰藲郴鯶쫸뫺跼迾猀氂猄戆洈䘊戌欎琐䰒℔␖⼘⸚⸜", a_), global::CommonResources.AcgResources.ID_KEYLISTMANAGEMENTKVLFIPSLEVEL3APPROVEDMODE);
					this.secKmfProfKVLFIPSLevel3ApprovedMode_43653.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secKmfProfKVLFIPSLevel3ApprovedMode_43653.DataTransferOrder = 69;
					num = (short)717553664;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.secKmfProfUserSelectable_43657 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("黌꫎닐飒룔뇖觘꧚닜맞든郢胤闦뫨軪臬諮鋰蟲铴闶闸黺ꋼ쯾㈀㔂〄〆", a_), global::CommonResources.AcgResources.ID_KEYSETUSERSELECTABLE);
					this.secKmfProfUserSelectable_43657.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secKmfProfUserSelectable_43657.DataTransferOrder = 78;
					num = (short)1798897676;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_186;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("黌꫎닐飒룔뇖觘꧚닜맞ꓠ釢蓤铦賨믪鿬諮蟰髲髴苶諸듺鏼꫾爀昂眄䐆愈樊挌栎琐䰒℔␖⼘⸚├", a_)))
					{
						num = (short)1638662162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_342;
				case 7:
					this.secKmfProfGenIndependentKeyList_43597 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("黌꫎닐飒룔뇖觘꧚닜맞ꛠ蛢诤껦蟨迪裬鿮铰鷲釴鋶韸迺뛼髾砀伂氄理紈吊㤌㰎␐⨒∔", a_), global::CommonResources.AcgResources.ID_INDEPENDENTKEYLIST);
					this.secKmfProfGenIndependentKeyList_43597.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.secKmfProfGenIndependentKeyList_43597.DataTransferOrder = 19;
					this.secKmfProfGenIndependentKeyList_43597.ValidateAcrossRecset = true;
					num = (short)1750073360;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					this.secKmfProfKeyListMgmtEraseAllKeys_43650 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("黌꫎닐飒룔뇖觘꧚닜맞ꫠ蛢鳤ꯦ胨飪駬ꋮ雰黲致닶诸髺軼髾䀀漂椄䰆氈爊縌倎┐‒⌔∖⤘", a_), global::CommonResources.AcgResources.ID_KEYLISTMANAGEMENTERASEALLKEYS);
					this.secKmfProfKeyListMgmtEraseAllKeys_43650.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secKmfProfKeyListMgmtEraseAllKeys_43650.DataTransferOrder = 66;
					num = (short)1355284490;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("黌꫎닐飒룔뇖觘꧚닜맞ꫠ뗢ꧤꇦꃨ믪뻬ꏮ铰藲郴鯶쫸뫺跼迾猀氂猄戆洈䘊戌欎琐䰒℔␖⼘⸚⸜", a_)))
					{
						num = (short)1723138051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_139;
				case 10:
					goto IL_4D7;
				case 11:
					goto IL_38E;
				case 12:
					goto IL_431;
				case 13:
					num = (short)767885334;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("黌꫎닐飒룔뇖觘꧚닜맞ꫠ蛢鳤ꯦ胨飪駬ꋮ雰黲致닶诸髺軼髾䀀漂椄䰆氈爊縌倎┐‒⌔∖⤘", a_)))
					{
						goto IL_203;
					}
					goto IL_4D7;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("黌꫎닐飒룔뇖觘꧚닜맞껠럢ꓤ뗦껨軪菬諮菰鋲致鋶닸黺蓼돾渀瀂瘄䰆氈爊刌㬎∐┒—┖", a_)))
					{
						num = (short)1104150552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_186;
				case 16:
					goto IL_1D3;
				case 17:
					goto IL_342;
				case 18:
					this.secKmfProfErasePreviousOnUserChange_43658 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("黌꫎닐飒룔뇖觘꧚닜맞ꓠ釢蓤铦賨믪鿬諮蟰髲髴苶諸듺鏼꫾爀昂眄䐆愈樊挌栎琐䰒℔␖⼘⸚├", a_), global::CommonResources.AcgResources.ID_KEYSETERASEPREVIOUSONUSERCHANGE);
					this.secKmfProfErasePreviousOnUserChange_43658.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secKmfProfErasePreviousOnUserChange_43658.DataTransferOrder = 79;
					num = (short)838533137;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("黌꫎닐飒룔뇖觘꧚닜맞든郢胤闦뫨軪臬諮鋰蟲铴闶闸黺ꋼ쯾㈀㔂〄〆", a_)))
					{
						num = (short)298516484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_431;
				case 20:
					if (producerFields != null)
					{
						num = (short)1669726221;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6C1;
				case 21:
					switch (0)
					{
					case 0:
						goto IL_9D;
					}
					continue;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("黌꫎닐飒룔뇖觘꧚닜맞ꛠ蛢诤껦蟨迪裬鿮铰鷲釴鋶韸迺뛼髾砀伂氄理紈吊㤌㰎␐⨒∔", a_)))
					{
						num = (short)1710161927;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D3;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("黌꫎닐飒룔뇖觘꧚닜맞裠迢胤듦賨裪飬鷮铰ꏲ蟴飶鿸鋺釼髾䘀嘂䰄䌆嘈㼊㸌㤎✐ℒ", a_)))
					{
						num = (short)1604845595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6C1;
				case 24:
					this.secKmfProfOTARGenerateKeyLossKey_43652 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("黌꫎닐飒룔뇖觘꧚닜맞껠럢ꓤ뗦껨軪菬諮菰鋲致鋶닸黺蓼돾渀瀂瘄䰆氈爊刌㬎∐┒—┖", a_), global::CommonResources.AcgResources.ID_KEYLISTMANAGEMENTOTARGENERATEKEYLOSSKEY);
					this.secKmfProfOTARGenerateKeyLossKey_43652.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secKmfProfOTARGenerateKeyLossKey_43652.DataTransferOrder = 68;
					num = (short)1638531077;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("黌꫎닐飒룔뇖觘꧚닜맞裠迢胤껦蟨跪蓬臮飰蟲郴ꋶ닸뻺뛼귾搀眂怄椆紈戊戌愎丐✒☔№Ⱈ⨚", a_)))
					{
						num = (short)1877147650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_38E;
				case 26:
					num = (short)823656468;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					this.secKmfProfileSecureProfileGUID_43662 = new global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureProfileGUIDField<string>(new global::Features.Converters.PackUnpackBigEndianUUID(), this, global::AllFeatures.CodeplugGuid.b("黌꫎닐飒룔뇖觘꧚닜맞裠迢胤듦賨裪飬鷮铰ꏲ蟴飶鿸鋺釼髾䘀嘂䰄䌆嘈㼊㸌㤎✐ℒ", a_), global::CommonResources.AcgResources.ID_SECUREPROFILEGUID);
					this.secKmfProfileSecureProfileGUID_43662.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.secKmfProfileSecureProfileGUID_43662.DataTransferOrder = 89;
					num = (short)1321533441;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_9D:
				num = (short)720764929;
				if (num != 0)
				{
				}
				num = (short)4626728;
				short num3 = num;
				num = (short)683841832;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_203:
					num = (short)1580269568;
					short num4 = num;
					num = (short)676855816;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				default:
					num = (short)1963982848;
					if (num != 0)
					{
					}
					if (global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						num = (short)1205338138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6C1;
				}
				IL_139:
				num = (short)78970899;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_186:
				num = (short)1353580553;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D3:
				num = (short)1138884622;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_342:
				num = (short)1725825047;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_38E:
				num = (short)869007375;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_431:
				num = (short)2125660166;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4D7:
				num = (short)1213857817;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4D2:
			IL_6C1:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諌꫎뿐뛒꟔뛖뗘", a_);
			base.Id = 10883;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 5;
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x00240030 File Offset: 0x0023E230
		public override void PopulateReferences()
		{
			short num = (short)430351102;
			short num2 = num;
			num = (short)942711550;
			switch (num2 == num)
			{
			}
			num = (short)1843003393;
			if (num != 0)
			{
			}
			num = (short)1811611648;
			short num3 = num;
			num = (short)1994194944;
			if (num != 0)
			{
			}
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x002400DC File Offset: 0x0023E2DC
		public override void DropReferences()
		{
			short num = (short)284407065;
			short num2 = num;
			num = (short)230798617;
			switch (num2 == num)
			{
			}
			num = (short)1640562689;
			if (num != 0)
			{
			}
			num = (short)685768704;
			short num3 = num;
			num = (short)722141184;
			if (num != 0)
			{
			}
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x00240184 File Offset: 0x0023E384
		public override void SetConstraints()
		{
			short num = (short)1380450305;
			if (num != 0)
			{
			}
			num = (short)1983129313;
			short num2 = num;
			num = (short)638789345;
			switch (num2 == num)
			{
			}
			num = (short)521797632;
			short num3 = num;
			num = (short)1569062912;
			if (num != 0)
			{
			}
			this.secKmfProfGenIndependentKeyList_43597.ValidateAcrossRecset = true;
			this.secKmfProfGenIndependentKeyList_43597.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConSecOperationIsHardware);
			this.secKmfProfGenIndependentKeyList_43597.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConIndependentKeyListValueSetter);
			this.secKmfProfKeyListMgmtEraseAllKeys_43650.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConHwSecIndependentKeyListOtarEnable);
			this.secKmfProfileInfiniteUKEKRetention_43651.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConHwSecIndependentKeyListOtarEnable);
			this.secKmfProfileInfiniteUKEKRetention_43651.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConASTROOTARInfiniteUKEKRetentionIsValid);
			this.secKmfProfOTARGenerateKeyLossKey_43652.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConHwSecIndependentKeyListOtarEnable);
			this.secKmfProfKVLFIPSLevel3ApprovedMode_43653.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConHwSecIndependentKeyListOtarEnable);
			this.secKmfProfUserSelectable_43657.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConHwSecIndependentKeyListAstroOtarEnable);
			this.secKmfProfErasePreviousOnUserChange_43658.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConHwSecIndependentKeyListAstroOtarEnable);
			this.secKmfProfileSecureProfileGUID_43662.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConSecureProfileGUIDIsValid);
			this.secKmfProfileSecureProfileGUID_43662.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConSecureProfileGUIDIsEditable);
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x00240338 File Offset: 0x0023E538
		public override void SetupDependencies()
		{
			short num = (short)63612337;
			short num2 = num;
			num = (short)1608492465;
			switch (num2 == num)
			{
			}
			num = (short)1339949057;
			if (num != 0)
			{
			}
			num = (short)165347328;
			short num3 = num;
			num = (short)1170735104;
			if (num != 0)
			{
			}
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secKmfProfGenIndependentKeyList_43597);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secKmfProfileSecureProfileGUID_43662);
			this.RefSecureWide.Features.SecWideFeaturesInfiniteKeyRetention_A8292.AddDependentObject(this.secKmfProfileInfiniteUKEKRetention_43651);
		}

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x060024B5 RID: 9397 RVA: 0x00240434 File Offset: 0x0023E634
		public bool HasDiffs
		{
			get
			{
				short num = (short)162479738;
				short num2 = num;
				num = (short)2122595962;
				switch (num2 == num)
				{
				}
				num = (short)403505153;
				if (num != 0)
				{
				}
				num = (short)1578565632;
				short num3 = num;
				num = (short)1417936896;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x060024B6 RID: 9398 RVA: 0x002404E4 File Offset: 0x0023E6E4
		// (set) Token: 0x060024B7 RID: 9399 RVA: 0x00240598 File Offset: 0x0023E798
		public bool SecKmfProfGenIndependentKeyList_43597Value
		{
			get
			{
				short num = (short)2107286167;
				short num2 = num;
				num = (short)1629921943;
				switch (num2 == num)
				{
				}
				num = (short)563085312;
				if (num != 0)
				{
				}
				num = (short)289800192;
				short num3 = num;
				num = (short)2049966081;
				if (num != 0)
				{
				}
				return this.secKmfProfGenIndependentKeyList_43597.Value;
			}
			set
			{
				short num = (short)1278632235;
				short num2 = num;
				num = (short)527393067;
				switch (num2 == num)
				{
				}
				num = (short)724172801;
				if (num != 0)
				{
				}
				num = (short)1914830848;
				short num3 = num;
				num = (short)1018167296;
				if (num != 0)
				{
				}
				this.secKmfProfGenIndependentKeyList_43597.Value = value;
			}
		}

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x060024B8 RID: 9400 RVA: 0x00240650 File Offset: 0x0023E850
		public global::AcpBusinessLayer.AcpField<bool> SecKmfProfGenIndependentKeyList_43597
		{
			get
			{
				short num = (short)1037950280;
				short num2 = num;
				num = (short)201055560;
				switch (num2 == num)
				{
				}
				num = (short)2089680896;
				if (num != 0)
				{
				}
				num = (short)1570308096;
				short num3 = num;
				num = (short)774373377;
				if (num != 0)
				{
				}
				return this.secKmfProfGenIndependentKeyList_43597;
			}
		}

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x060024B9 RID: 9401 RVA: 0x00240700 File Offset: 0x0023E900
		// (set) Token: 0x060024BA RID: 9402 RVA: 0x002407B4 File Offset: 0x0023E9B4
		public bool SecKmfProfGenIndependentKeyList_43597_UIValue
		{
			get
			{
				short num = (short)1290996862;
				short num2 = num;
				num = (short)646581374;
				switch (num2 == num)
				{
				}
				num = (short)1724710913;
				if (num != 0)
				{
				}
				num = (short)247201792;
				short num3 = num;
				num = (short)1090715648;
				if (num != 0)
				{
				}
				return this.secKmfProfGenIndependentKeyList_43597.Value;
			}
			set
			{
				short num = (short)1061010847;
				short num2 = num;
				num = (short)1281801631;
				switch (num2 == num)
				{
				}
				num = (short)978780160;
				short num3 = num;
				num = (short)871235584;
				if (num != 0)
				{
				}
				num = (short)1051787265;
				if (num != 0)
				{
				}
				this.secKmfProfGenIndependentKeyList_43597.Value = value;
			}
		}

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x060024BB RID: 9403 RVA: 0x00240868 File Offset: 0x0023EA68
		// (set) Token: 0x060024BC RID: 9404 RVA: 0x00240920 File Offset: 0x0023EB20
		public bool SecKmfProfGenIndependentKeyList_43597_Applicable
		{
			get
			{
				short num = (short)552211870;
				short num2 = num;
				num = (short)1590891934;
				switch (num2 == num)
				{
				}
				num = (short)2079195136;
				short num3 = num;
				num = (short)245956608;
				if (num != 0)
				{
				}
				num = (short)411041793;
				if (num != 0)
				{
				}
				return this.secKmfProfGenIndependentKeyList_43597.Applicable;
			}
			set
			{
				short num = (short)2075551993;
				short num2 = num;
				num = (short)514222329;
				switch (num2 == num)
				{
				}
				num = (short)267583488;
				short num3 = num;
				num = (short)1148059648;
				if (num != 0)
				{
				}
				num = (short)236257281;
				if (num != 0)
				{
				}
				this.secKmfProfGenIndependentKeyList_43597.Applicable = value;
			}
		}

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x060024BD RID: 9405 RVA: 0x002409D8 File Offset: 0x0023EBD8
		// (set) Token: 0x060024BE RID: 9406 RVA: 0x00240A90 File Offset: 0x0023EC90
		public bool SecKmfProfGenIndependentKeyList_43597_Valid
		{
			get
			{
				short num = (short)1882621775;
				short num2 = num;
				num = (short)1836812111;
				switch (num2 == num)
				{
				}
				num = (short)789118976;
				short num3 = num;
				num = (short)348192769;
				if (num != 0)
				{
				}
				num = (short)782172160;
				if (num != 0)
				{
				}
				return this.secKmfProfGenIndependentKeyList_43597.Valid;
			}
			set
			{
				short num = (short)1585530170;
				short num2 = num;
				num = (short)137512250;
				switch (num2 == num)
				{
				}
				num = (short)474742784;
				short num3 = num;
				num = (short)1897267200;
				if (num != 0)
				{
				}
				num = (short)733478913;
				if (num != 0)
				{
				}
				this.secKmfProfGenIndependentKeyList_43597.Valid = value;
			}
		}

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x060024BF RID: 9407 RVA: 0x00240B48 File Offset: 0x0023ED48
		// (set) Token: 0x060024C0 RID: 9408 RVA: 0x00240BFC File Offset: 0x0023EDFC
		public bool SecKmfProfGenIndependentKeyList_43597_Visible
		{
			get
			{
				short num = (short)2066732166;
				short num2 = num;
				num = (short)758764678;
				switch (num2 == num)
				{
				}
				num = (short)745406464;
				short num3 = num;
				num = (short)424411137;
				if (num != 0)
				{
				}
				num = (short)1522466816;
				if (num != 0)
				{
				}
				return this.secKmfProfGenIndependentKeyList_43597.Visible;
			}
			set
			{
				short num = (short)30307863;
				short num2 = num;
				num = (short)1415476759;
				switch (num2 == num)
				{
				}
				num = (short)1908408320;
				short num3 = num;
				num = (short)1600454657;
				if (num != 0)
				{
				}
				num = (short)2020212736;
				if (num != 0)
				{
				}
				this.secKmfProfGenIndependentKeyList_43597.Visible = value;
			}
		}

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x060024C1 RID: 9409 RVA: 0x00240CB0 File Offset: 0x0023EEB0
		// (set) Token: 0x060024C2 RID: 9410 RVA: 0x00240D68 File Offset: 0x0023EF68
		public bool SecKmfProfGenIndependentKeyList_43597_Editable
		{
			get
			{
				short num = (short)444563240;
				short num2 = num;
				num = (short)588152616;
				switch (num2 == num)
				{
				}
				num = (short)1052180480;
				short num3 = num;
				num = (short)860291073;
				if (num != 0)
				{
				}
				num = (short)381157376;
				if (num != 0)
				{
				}
				return this.secKmfProfGenIndependentKeyList_43597.Editable;
			}
			set
			{
				short num = (short)1864265437;
				short num2 = num;
				num = (short)1435332317;
				switch (num2 == num)
				{
				}
				num = (short)753664000;
				short num3 = num;
				num = (short)1289224192;
				if (num != 0)
				{
				}
				num = (short)1295515649;
				if (num != 0)
				{
				}
				this.secKmfProfGenIndependentKeyList_43597.Editable = value;
			}
		}

		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x060024C3 RID: 9411 RVA: 0x00240E1C File Offset: 0x0023F01C
		internal string SecKmfProfGenIndependentKeyList_43597_UILabel
		{
			get
			{
				short num = (short)890572263;
				short num2 = num;
				num = (short)1107627495;
				switch (num2 == num)
				{
				}
				num = (short)1013383168;
				short num3 = num;
				num = (short)1016659969;
				if (num != 0)
				{
				}
				num = (short)796917760;
				if (num != 0)
				{
				}
				return this.secKmfProfGenIndependentKeyList_43597.UIName;
			}
		}

		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x060024C4 RID: 9412 RVA: 0x00240ED0 File Offset: 0x0023F0D0
		// (set) Token: 0x060024C5 RID: 9413 RVA: 0x00240F84 File Offset: 0x0023F184
		internal bool SecKmfProfGenIndependentKeyList_43597_HiddenStatic
		{
			get
			{
				short num = (short)1768943807;
				short num2 = num;
				num = (short)1493889215;
				switch (num2 == num)
				{
				}
				num = (short)1721499648;
				short num3 = num;
				num = (short)1028390912;
				if (num != 0)
				{
				}
				num = (short)1019871233;
				if (num != 0)
				{
				}
				return this.secKmfProfGenIndependentKeyList_43597.HiddenStatic;
			}
			set
			{
				short num = (short)901032064;
				short num2 = num;
				num = (short)791849088;
				switch (num2 == num)
				{
				}
				num = (short)3866624;
				short num3 = num;
				num = (short)439353345;
				if (num != 0)
				{
				}
				num = (short)1035272192;
				if (num != 0)
				{
				}
				this.secKmfProfGenIndependentKeyList_43597.HiddenStatic = value;
			}
		}

		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x060024C6 RID: 9414 RVA: 0x00241038 File Offset: 0x0023F238
		// (set) Token: 0x060024C7 RID: 9415 RVA: 0x002410F0 File Offset: 0x0023F2F0
		internal bool SecKmfProfGenIndependentKeyList_43597_HiddenDynamic
		{
			get
			{
				short num = (short)313969959;
				short num2 = num;
				num = (short)18926887;
				switch (num2 == num)
				{
				}
				num = (short)1298399232;
				short num3 = num;
				num = (short)76546049;
				if (num != 0)
				{
				}
				num = (short)1694892032;
				if (num != 0)
				{
				}
				return this.secKmfProfGenIndependentKeyList_43597.HiddenDynamic;
			}
			set
			{
				short num = (short)2029237585;
				short num2 = num;
				num = (short)197637457;
				switch (num2 == num)
				{
				}
				num = (short)10878976;
				short num3 = num;
				num = (short)1125515264;
				if (num != 0)
				{
				}
				num = (short)2027749377;
				if (num != 0)
				{
				}
				this.secKmfProfGenIndependentKeyList_43597.HiddenDynamic = value;
			}
		}

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x060024C8 RID: 9416 RVA: 0x002411A8 File Offset: 0x0023F3A8
		public bool SecKmfProfGenIndependentKeyList_43597_HasDiffs
		{
			get
			{
				short num = (short)925973569;
				short num2 = num;
				num = (short)1119501377;
				switch (num2 == num)
				{
				}
				num = (short)413990912;
				short num3 = num;
				num = (short)455868416;
				if (num != 0)
				{
				}
				num = (short)980090881;
				if (num != 0)
				{
				}
				return this.secKmfProfGenIndependentKeyList_43597._HasDiffs;
			}
		}

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x060024C9 RID: 9417 RVA: 0x0024125C File Offset: 0x0023F45C
		// (set) Token: 0x060024CA RID: 9418 RVA: 0x00241314 File Offset: 0x0023F514
		public bool SecKmfProfKeyListMgmtEraseAllKeys_43650Value
		{
			get
			{
				short num = (short)1664942081;
				if (num != 0)
				{
				}
				num = (short)1535676217;
				short num2 = num;
				num = (short)1059032889;
				switch (num2 == num)
				{
				default:
				{
					num = (short)912785408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)756416512;
				if (num != 0)
				{
				}
				return this.secKmfProfKeyListMgmtEraseAllKeys_43650.Value;
			}
			set
			{
				short num = (short)1875780126;
				short num2 = num;
				num = (short)1960190494;
				switch (num2 == num)
				{
				}
				num = (short)2061959168;
				short num3 = num;
				num = (short)2005139456;
				if (num != 0)
				{
				}
				num = (short)1919942657;
				if (num != 0)
				{
				}
				this.secKmfProfKeyListMgmtEraseAllKeys_43650.Value = value;
			}
		}

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x060024CB RID: 9419 RVA: 0x002413CC File Offset: 0x0023F5CC
		public global::AcpBusinessLayer.AcpField<bool> SecKmfProfKeyListMgmtEraseAllKeys_43650
		{
			get
			{
				short num = (short)1538064385;
				if (num != 0)
				{
				}
				num = (short)1835499893;
				short num2 = num;
				num = (short)738820469;
				switch (num2 == num)
				{
				default:
				{
					num = (short)537067520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1692270592;
				if (num != 0)
				{
				}
				return this.secKmfProfKeyListMgmtEraseAllKeys_43650;
			}
		}

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x060024CC RID: 9420 RVA: 0x00241478 File Offset: 0x0023F678
		// (set) Token: 0x060024CD RID: 9421 RVA: 0x00241530 File Offset: 0x0023F730
		public bool SecKmfProfKeyListMgmtEraseAllKeys_43650_UIValue
		{
			get
			{
				short num = (short)37463065;
				short num2 = num;
				num = (short)1649452057;
				switch (num2 == num)
				{
				}
				num = (short)1783562240;
				short num3 = num;
				num = (short)794820609;
				if (num != 0)
				{
				}
				num = (short)27066368;
				if (num != 0)
				{
				}
				return this.secKmfProfKeyListMgmtEraseAllKeys_43650.Value;
			}
			set
			{
				short num = (short)1135280129;
				if (num != 0)
				{
				}
				num = (short)1431703921;
				short num2 = num;
				num = (short)699273585;
				switch (num2 == num)
				{
				default:
				{
					num = (short)363462656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1252458496;
				if (num != 0)
				{
				}
				this.secKmfProfKeyListMgmtEraseAllKeys_43650.Value = value;
			}
		}

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x060024CE RID: 9422 RVA: 0x002415E4 File Offset: 0x0023F7E4
		// (set) Token: 0x060024CF RID: 9423 RVA: 0x00241698 File Offset: 0x0023F898
		public bool SecKmfProfKeyListMgmtEraseAllKeys_43650_Applicable
		{
			get
			{
				short num = (short)1015743963;
				short num2 = num;
				num = (short)1334248923;
				switch (num2 == num)
				{
				}
				num = (short)1342636032;
				short num3 = num;
				num = (short)476839937;
				if (num != 0)
				{
				}
				num = (short)1691615232;
				if (num != 0)
				{
				}
				return this.secKmfProfKeyListMgmtEraseAllKeys_43650.Applicable;
			}
			set
			{
				short num = (short)1200440656;
				short num2 = num;
				num = (short)648627536;
				switch (num2 == num)
				{
				}
				num = (short)155516928;
				short num3 = num;
				num = (short)1221656577;
				if (num != 0)
				{
				}
				num = (short)128843776;
				if (num != 0)
				{
				}
				this.secKmfProfKeyListMgmtEraseAllKeys_43650.Applicable = value;
			}
		}

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x060024D0 RID: 9424 RVA: 0x0024174C File Offset: 0x0023F94C
		// (set) Token: 0x060024D1 RID: 9425 RVA: 0x00241800 File Offset: 0x0023FA00
		public bool SecKmfProfKeyListMgmtEraseAllKeys_43650_Valid
		{
			get
			{
				short num = (short)697201826;
				short num2 = num;
				num = (short)762606754;
				switch (num2 == num)
				{
				}
				num = (short)111607808;
				short num3 = num;
				num = (short)1508179968;
				if (num != 0)
				{
				}
				num = (short)229703681;
				if (num != 0)
				{
				}
				return this.secKmfProfKeyListMgmtEraseAllKeys_43650.Valid;
			}
			set
			{
				short num = (short)194732294;
				short num2 = num;
				num = (short)751329542;
				switch (num2 == num)
				{
				}
				num = (short)2003959808;
				short num3 = num;
				num = (short)1252327424;
				if (num != 0)
				{
				}
				num = (short)952762369;
				if (num != 0)
				{
				}
				this.secKmfProfKeyListMgmtEraseAllKeys_43650.Valid = value;
			}
		}

		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x060024D2 RID: 9426 RVA: 0x002418B8 File Offset: 0x0023FAB8
		// (set) Token: 0x060024D3 RID: 9427 RVA: 0x0024196C File Offset: 0x0023FB6C
		public bool SecKmfProfKeyListMgmtEraseAllKeys_43650_Visible
		{
			get
			{
				short num = (short)229914377;
				short num2 = num;
				num = (short)1605973769;
				switch (num2 == num)
				{
				}
				num = (short)1923284992;
				short num3 = num;
				num = (short)445775872;
				if (num != 0)
				{
				}
				num = (short)519503873;
				if (num != 0)
				{
				}
				return this.secKmfProfKeyListMgmtEraseAllKeys_43650.Visible;
			}
			set
			{
				short num = (short)1528102913;
				if (num != 0)
				{
				}
				num = (short)221761524;
				short num2 = num;
				num = (short)493735924;
				switch (num2 == num)
				{
				default:
				{
					num = (short)398458880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)242024448;
				if (num != 0)
				{
				}
				this.secKmfProfKeyListMgmtEraseAllKeys_43650.Visible = value;
			}
		}

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x060024D4 RID: 9428 RVA: 0x00241A24 File Offset: 0x0023FC24
		// (set) Token: 0x060024D5 RID: 9429 RVA: 0x00241AD8 File Offset: 0x0023FCD8
		public bool SecKmfProfKeyListMgmtEraseAllKeys_43650_Editable
		{
			get
			{
				short num = (short)1287593150;
				short num2 = num;
				num = (short)1771838654;
				switch (num2 == num)
				{
				}
				num = (short)1497759744;
				short num3 = num;
				num = (short)986578944;
				if (num != 0)
				{
				}
				num = (short)1273364481;
				if (num != 0)
				{
				}
				return this.secKmfProfKeyListMgmtEraseAllKeys_43650.Editable;
			}
			set
			{
				short num = (short)649516720;
				short num2 = num;
				num = (short)43439792;
				switch (num2 == num)
				{
				}
				num = (short)1206910976;
				short num3 = num;
				num = (short)1852243969;
				if (num != 0)
				{
				}
				num = (short)1701838848;
				if (num != 0)
				{
				}
				this.secKmfProfKeyListMgmtEraseAllKeys_43650.Editable = value;
			}
		}

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x060024D6 RID: 9430 RVA: 0x00241B90 File Offset: 0x0023FD90
		internal string SecKmfProfKeyListMgmtEraseAllKeys_43650_UILabel
		{
			get
			{
				short num = (short)1398943513;
				short num2 = num;
				num = (short)2061184793;
				switch (num2 == num)
				{
				}
				num = (short)903413760;
				short num3 = num;
				num = (short)1572339713;
				if (num != 0)
				{
				}
				num = (short)1610350592;
				if (num != 0)
				{
				}
				return this.secKmfProfKeyListMgmtEraseAllKeys_43650.UIName;
			}
		}

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x060024D7 RID: 9431 RVA: 0x00241C44 File Offset: 0x0023FE44
		// (set) Token: 0x060024D8 RID: 9432 RVA: 0x00241CF8 File Offset: 0x0023FEF8
		internal bool SecKmfProfKeyListMgmtEraseAllKeys_43650_HiddenStatic
		{
			get
			{
				short num = (short)865477550;
				short num2 = num;
				num = (short)863118254;
				switch (num2 == num)
				{
				}
				num = (short)151257088;
				short num3 = num;
				num = (short)1568604160;
				if (num != 0)
				{
				}
				num = (short)1899954177;
				if (num != 0)
				{
				}
				return this.secKmfProfKeyListMgmtEraseAllKeys_43650.HiddenStatic;
			}
			set
			{
				short num = (short)186449921;
				if (num != 0)
				{
				}
				num = (short)1792529484;
				short num2 = num;
				num = (short)1355797580;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1544945664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1287847936;
				if (num != 0)
				{
				}
				this.secKmfProfKeyListMgmtEraseAllKeys_43650.HiddenStatic = value;
			}
		}

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x060024D9 RID: 9433 RVA: 0x00241DAC File Offset: 0x0023FFAC
		// (set) Token: 0x060024DA RID: 9434 RVA: 0x00241E60 File Offset: 0x00240060
		internal bool SecKmfProfKeyListMgmtEraseAllKeys_43650_HiddenDynamic
		{
			get
			{
				short num = (short)1084387566;
				short num2 = num;
				num = (short)878014702;
				switch (num2 == num)
				{
				}
				num = (short)1328152576;
				short num3 = num;
				num = (short)841089024;
				if (num != 0)
				{
				}
				num = (short)1062404097;
				if (num != 0)
				{
				}
				return this.secKmfProfKeyListMgmtEraseAllKeys_43650.HiddenDynamic;
			}
			set
			{
				short num = (short)1523280911;
				short num2 = num;
				num = (short)520449039;
				switch (num2 == num)
				{
				}
				num = (short)1536688128;
				short num3 = num;
				num = (short)943259648;
				if (num != 0)
				{
				}
				num = (short)352452609;
				if (num != 0)
				{
				}
				this.secKmfProfKeyListMgmtEraseAllKeys_43650.HiddenDynamic = value;
			}
		}

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x060024DB RID: 9435 RVA: 0x00241F14 File Offset: 0x00240114
		public bool SecKmfProfKeyListMgmtEraseAllKeys_43650_HasDiffs
		{
			get
			{
				short num = (short)369672605;
				short num2 = num;
				num = (short)296010141;
				switch (num2 == num)
				{
				}
				num = (short)1758593024;
				short num3 = num;
				num = (short)2024931329;
				if (num != 0)
				{
				}
				num = (short)1243217920;
				if (num != 0)
				{
				}
				return this.secKmfProfKeyListMgmtEraseAllKeys_43650._HasDiffs;
			}
		}

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x060024DC RID: 9436 RVA: 0x00241FCC File Offset: 0x002401CC
		// (set) Token: 0x060024DD RID: 9437 RVA: 0x00242080 File Offset: 0x00240280
		public bool SecKmfProfileInfiniteUKEKRetention_43651Value
		{
			get
			{
				short num = (short)1577936959;
				short num2 = num;
				num = (short)394160191;
				switch (num2 == num)
				{
				}
				num = (short)1549795328;
				short num3 = num;
				num = (short)1936588801;
				if (num != 0)
				{
				}
				num = (short)724762624;
				if (num != 0)
				{
				}
				return this.secKmfProfileInfiniteUKEKRetention_43651.Value;
			}
			set
			{
				short num = (short)1536048866;
				short num2 = num;
				num = (short)1613315810;
				switch (num2 == num)
				{
				}
				num = (short)581304320;
				short num3 = num;
				num = (short)1108803585;
				if (num != 0)
				{
				}
				num = (short)1463287808;
				if (num != 0)
				{
				}
				this.secKmfProfileInfiniteUKEKRetention_43651.Value = value;
			}
		}

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x060024DE RID: 9438 RVA: 0x00242138 File Offset: 0x00240338
		public global::AcpBusinessLayer.AcpField<bool> SecKmfProfileInfiniteUKEKRetention_43651
		{
			get
			{
				short num = (short)1901103498;
				short num2 = num;
				num = (short)1170770314;
				switch (num2 == num)
				{
				}
				num = (short)781451264;
				short num3 = num;
				num = (short)515244032;
				if (num != 0)
				{
				}
				num = (short)572850177;
				if (num != 0)
				{
				}
				return this.secKmfProfileInfiniteUKEKRetention_43651;
			}
		}

		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x060024DF RID: 9439 RVA: 0x002421EC File Offset: 0x002403EC
		// (set) Token: 0x060024E0 RID: 9440 RVA: 0x002422A0 File Offset: 0x002404A0
		public bool SecKmfProfileInfiniteUKEKRetention_43651_UIValue
		{
			get
			{
				short num = (short)1110872717;
				short num2 = num;
				num = (short)812028557;
				switch (num2 == num)
				{
				}
				num = (short)1933246464;
				short num3 = num;
				num = (short)417988608;
				if (num != 0)
				{
				}
				num = (short)548208641;
				if (num != 0)
				{
				}
				return this.secKmfProfileInfiniteUKEKRetention_43651.Value;
			}
			set
			{
				short num = (short)1206379771;
				short num2 = num;
				num = (short)1572201723;
				switch (num2 == num)
				{
				}
				num = (short)1911160832;
				short num3 = num;
				num = (short)1984036865;
				if (num != 0)
				{
				}
				num = (short)287244288;
				if (num != 0)
				{
				}
				this.secKmfProfileInfiniteUKEKRetention_43651.Value = value;
			}
		}

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x060024E1 RID: 9441 RVA: 0x00242358 File Offset: 0x00240558
		// (set) Token: 0x060024E2 RID: 9442 RVA: 0x00242408 File Offset: 0x00240608
		public bool SecKmfProfileInfiniteUKEKRetention_43651_Applicable
		{
			get
			{
				short num = (short)735439030;
				short num2 = num;
				num = (short)196536502;
				switch (num2 == num)
				{
				}
				num = (short)1408237568;
				short num3 = num;
				num = (short)571080705;
				if (num != 0)
				{
				}
				num = (short)1259601920;
				if (num != 0)
				{
				}
				return this.secKmfProfileInfiniteUKEKRetention_43651.Applicable;
			}
			set
			{
				short num = (short)935800720;
				short num2 = num;
				num = (short)1930964880;
				switch (num2 == num)
				{
				}
				num = (short)718602240;
				short num3 = num;
				num = (short)508035073;
				if (num != 0)
				{
				}
				num = (short)951779328;
				if (num != 0)
				{
				}
				this.secKmfProfileInfiniteUKEKRetention_43651.Applicable = value;
			}
		}

		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x060024E3 RID: 9443 RVA: 0x002424C4 File Offset: 0x002406C4
		// (set) Token: 0x060024E4 RID: 9444 RVA: 0x00242578 File Offset: 0x00240778
		public bool SecKmfProfileInfiniteUKEKRetention_43651_Valid
		{
			get
			{
				short num = (short)688914011;
				short num2 = num;
				num = (short)1524170331;
				switch (num2 == num)
				{
				}
				num = (short)1709834240;
				short num3 = num;
				num = (short)591069184;
				if (num != 0)
				{
				}
				num = (short)289341441;
				if (num != 0)
				{
				}
				return this.secKmfProfileInfiniteUKEKRetention_43651.Valid;
			}
			set
			{
				short num = (short)1696490858;
				short num2 = num;
				num = (short)684287338;
				switch (num2 == num)
				{
				}
				num = (short)1334706176;
				short num3 = num;
				num = (short)1273430017;
				if (num != 0)
				{
				}
				num = (short)956497920;
				if (num != 0)
				{
				}
				this.secKmfProfileInfiniteUKEKRetention_43651.Valid = value;
			}
		}

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x060024E5 RID: 9445 RVA: 0x0024262C File Offset: 0x0024082C
		// (set) Token: 0x060024E6 RID: 9446 RVA: 0x002426E0 File Offset: 0x002408E0
		public bool SecKmfProfileInfiniteUKEKRetention_43651_Visible
		{
			get
			{
				short num = (short)1531453872;
				short num2 = num;
				num = (short)4727216;
				switch (num2 == num)
				{
				}
				num = (short)2121924608;
				short num3 = num;
				num = (short)715390976;
				if (num != 0)
				{
				}
				num = (short)1430913025;
				if (num != 0)
				{
				}
				return this.secKmfProfileInfiniteUKEKRetention_43651.Visible;
			}
			set
			{
				short num = (short)764180066;
				short num2 = num;
				num = (short)2078242402;
				switch (num2 == num)
				{
				}
				num = (short)1669136384;
				short num3 = num;
				num = (short)1524826113;
				if (num != 0)
				{
				}
				num = (short)487653376;
				if (num != 0)
				{
				}
				this.secKmfProfileInfiniteUKEKRetention_43651.Visible = value;
			}
		}

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x060024E7 RID: 9447 RVA: 0x00242798 File Offset: 0x00240998
		// (set) Token: 0x060024E8 RID: 9448 RVA: 0x0024284C File Offset: 0x00240A4C
		public bool SecKmfProfileInfiniteUKEKRetention_43651_Editable
		{
			get
			{
				short num = (short)712962216;
				short num2 = num;
				num = (short)210104488;
				switch (num2 == num)
				{
				}
				num = (short)365297664;
				short num3 = num;
				num = (short)1427898368;
				if (num != 0)
				{
				}
				num = (short)905117697;
				if (num != 0)
				{
				}
				return this.secKmfProfileInfiniteUKEKRetention_43651.Editable;
			}
			set
			{
				short num = (short)1329845718;
				short num2 = num;
				num = (short)415225302;
				switch (num2 == num)
				{
				}
				num = (short)1297022976;
				short num3 = num;
				num = (short)612368385;
				if (num != 0)
				{
				}
				num = (short)1989214208;
				if (num != 0)
				{
				}
				this.secKmfProfileInfiniteUKEKRetention_43651.Editable = value;
			}
		}

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x060024E9 RID: 9449 RVA: 0x00242904 File Offset: 0x00240B04
		internal string SecKmfProfileInfiniteUKEKRetention_43651_UILabel
		{
			get
			{
				short num = (short)1001390024;
				short num2 = num;
				num = (short)897318856;
				switch (num2 == num)
				{
				}
				num = (short)830013440;
				short num3 = num;
				num = (short)782303233;
				if (num != 0)
				{
				}
				num = (short)2046230528;
				if (num != 0)
				{
				}
				return this.secKmfProfileInfiniteUKEKRetention_43651.UIName;
			}
		}

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x060024EA RID: 9450 RVA: 0x002429BC File Offset: 0x00240BBC
		// (set) Token: 0x060024EB RID: 9451 RVA: 0x00242A74 File Offset: 0x00240C74
		internal bool SecKmfProfileInfiniteUKEKRetention_43651_HiddenStatic
		{
			get
			{
				short num = (short)1776872096;
				short num2 = num;
				num = (short)1160243872;
				switch (num2 == num)
				{
				}
				num = (short)642056192;
				short num3 = num;
				num = (short)184352769;
				if (num != 0)
				{
				}
				num = (short)1936326656;
				if (num != 0)
				{
				}
				return this.secKmfProfileInfiniteUKEKRetention_43651.HiddenStatic;
			}
			set
			{
				short num = (short)1740052087;
				short num2 = num;
				num = (short)1872172663;
				switch (num2 == num)
				{
				}
				num = (short)672268288;
				short num3 = num;
				num = (short)678821889;
				if (num != 0)
				{
				}
				num = (short)1635254272;
				if (num != 0)
				{
				}
				this.secKmfProfileInfiniteUKEKRetention_43651.HiddenStatic = value;
			}
		}

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x060024EC RID: 9452 RVA: 0x00242B28 File Offset: 0x00240D28
		// (set) Token: 0x060024ED RID: 9453 RVA: 0x00242BDC File Offset: 0x00240DDC
		internal bool SecKmfProfileInfiniteUKEKRetention_43651_HiddenDynamic
		{
			get
			{
				short num = (short)1963793499;
				short num2 = num;
				num = (short)591404123;
				switch (num2 == num)
				{
				}
				num = (short)1502609408;
				short num3 = num;
				num = (short)1127088129;
				if (num != 0)
				{
				}
				num = (short)1187905536;
				if (num != 0)
				{
				}
				return this.secKmfProfileInfiniteUKEKRetention_43651.HiddenDynamic;
			}
			set
			{
				short num = (short)1405493537;
				short num2 = num;
				num = (short)1257840929;
				switch (num2 == num)
				{
				}
				num = (short)58785792;
				short num3 = num;
				num = (short)441581568;
				if (num != 0)
				{
				}
				num = (short)1873739777;
				if (num != 0)
				{
				}
				this.secKmfProfileInfiniteUKEKRetention_43651.HiddenDynamic = value;
			}
		}

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x060024EE RID: 9454 RVA: 0x00242C90 File Offset: 0x00240E90
		public bool SecKmfProfileInfiniteUKEKRetention_43651_HasDiffs
		{
			get
			{
				short num = (short)799325458;
				short num2 = num;
				num = (short)1598995730;
				switch (num2 == num)
				{
				}
				num = (short)1950154752;
				short num3 = num;
				num = (short)118489089;
				if (num != 0)
				{
				}
				num = (short)645136384;
				if (num != 0)
				{
				}
				return this.secKmfProfileInfiniteUKEKRetention_43651._HasDiffs;
			}
		}

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x060024EF RID: 9455 RVA: 0x00242D44 File Offset: 0x00240F44
		// (set) Token: 0x060024F0 RID: 9456 RVA: 0x00242DF8 File Offset: 0x00240FF8
		public bool SecKmfProfOTARGenerateKeyLossKey_43652Value
		{
			get
			{
				short num = (short)1303759830;
				short num2 = num;
				num = (short)636079062;
				switch (num2 == num)
				{
				}
				num = (short)519241728;
				short num3 = num;
				num = (short)1232338944;
				if (num != 0)
				{
				}
				num = (short)316669953;
				if (num != 0)
				{
				}
				return this.secKmfProfOTARGenerateKeyLossKey_43652.Value;
			}
			set
			{
				short num = (short)192544769;
				if (num != 0)
				{
				}
				num = (short)1508443811;
				short num2 = num;
				num = (short)1405486755;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2127429632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1152122880;
				if (num != 0)
				{
				}
				this.secKmfProfOTARGenerateKeyLossKey_43652.Value = value;
			}
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x060024F1 RID: 9457 RVA: 0x00242EAC File Offset: 0x002410AC
		public global::AcpBusinessLayer.AcpField<bool> SecKmfProfOTARGenerateKeyLossKey_43652
		{
			get
			{
				short num = (short)1483700303;
				short num2 = num;
				num = (short)1126266959;
				switch (num2 == num)
				{
				}
				num = (short)1679884288;
				short num3 = num;
				num = (short)1299316737;
				if (num != 0)
				{
				}
				num = (short)1189675008;
				if (num != 0)
				{
				}
				return this.secKmfProfOTARGenerateKeyLossKey_43652;
			}
		}

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x060024F2 RID: 9458 RVA: 0x00242F5C File Offset: 0x0024115C
		// (set) Token: 0x060024F3 RID: 9459 RVA: 0x00243010 File Offset: 0x00241210
		public bool SecKmfProfOTARGenerateKeyLossKey_43652_UIValue
		{
			get
			{
				short num = (short)941465852;
				short num2 = num;
				num = (short)1155440892;
				switch (num2 == num)
				{
				}
				num = (short)334168064;
				short num3 = num;
				num = (short)1195966465;
				if (num != 0)
				{
				}
				num = (short)760020992;
				if (num != 0)
				{
				}
				return this.secKmfProfOTARGenerateKeyLossKey_43652.Value;
			}
			set
			{
				short num = (short)812976115;
				short num2 = num;
				num = (short)1723336691;
				switch (num2 == num)
				{
				}
				num = (short)2044264448;
				short num3 = num;
				num = (short)566296576;
				if (num != 0)
				{
				}
				num = (short)1930035201;
				if (num != 0)
				{
				}
				this.secKmfProfOTARGenerateKeyLossKey_43652.Value = value;
			}
		}

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x060024F4 RID: 9460 RVA: 0x002430C8 File Offset: 0x002412C8
		// (set) Token: 0x060024F5 RID: 9461 RVA: 0x0024317C File Offset: 0x0024137C
		public bool SecKmfProfOTARGenerateKeyLossKey_43652_Applicable
		{
			get
			{
				short num = (short)671567942;
				short num2 = num;
				num = (short)1796689990;
				switch (num2 == num)
				{
				}
				num = (short)313131008;
				short num3 = num;
				num = (short)1625817088;
				if (num != 0)
				{
				}
				num = (short)510722049;
				if (num != 0)
				{
				}
				return this.secKmfProfOTARGenerateKeyLossKey_43652.Applicable;
			}
			set
			{
				short num = (short)1131181382;
				short num2 = num;
				num = (short)517436742;
				switch (num2 == num)
				{
				}
				num = (short)1756758016;
				short num3 = num;
				num = (short)1022361600;
				if (num != 0)
				{
				}
				num = (short)470351873;
				if (num != 0)
				{
				}
				this.secKmfProfOTARGenerateKeyLossKey_43652.Applicable = value;
			}
		}

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x060024F6 RID: 9462 RVA: 0x00243230 File Offset: 0x00241430
		// (set) Token: 0x060024F7 RID: 9463 RVA: 0x002432E4 File Offset: 0x002414E4
		public bool SecKmfProfOTARGenerateKeyLossKey_43652_Valid
		{
			get
			{
				short num = (short)1002092488;
				short num2 = num;
				num = (short)1729738696;
				switch (num2 == num)
				{
				}
				num = (short)155582464;
				short num3 = num;
				num = (short)701497345;
				if (num != 0)
				{
				}
				num = (short)549978112;
				if (num != 0)
				{
				}
				return this.secKmfProfOTARGenerateKeyLossKey_43652.Valid;
			}
			set
			{
				short num = (short)2113642343;
				short num2 = num;
				num = (short)1430429543;
				switch (num2 == num)
				{
				}
				num = (short)2144337920;
				short num3 = num;
				num = (short)1068892161;
				if (num != 0)
				{
				}
				num = (short)1567227904;
				if (num != 0)
				{
				}
				this.secKmfProfOTARGenerateKeyLossKey_43652.Valid = value;
			}
		}

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x060024F8 RID: 9464 RVA: 0x00243398 File Offset: 0x00241598
		// (set) Token: 0x060024F9 RID: 9465 RVA: 0x0024344C File Offset: 0x0024164C
		public bool SecKmfProfOTARGenerateKeyLossKey_43652_Visible
		{
			get
			{
				short num = (short)1337020430;
				short num2 = num;
				num = (short)950685710;
				switch (num2 == num)
				{
				}
				num = (short)828964864;
				short num3 = num;
				num = (short)1324875776;
				if (num != 0)
				{
				}
				num = (short)975437825;
				if (num != 0)
				{
				}
				return this.secKmfProfOTARGenerateKeyLossKey_43652.Visible;
			}
			set
			{
				short num = (short)1600847873;
				if (num != 0)
				{
				}
				num = (short)1895713582;
				short num2 = num;
				num = (short)2065386286;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1089208320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)355270656;
				if (num != 0)
				{
				}
				this.secKmfProfOTARGenerateKeyLossKey_43652.Visible = value;
			}
		}

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x060024FA RID: 9466 RVA: 0x00243504 File Offset: 0x00241704
		// (set) Token: 0x060024FB RID: 9467 RVA: 0x002435B8 File Offset: 0x002417B8
		public bool SecKmfProfOTARGenerateKeyLossKey_43652_Editable
		{
			get
			{
				short num = (short)644888987;
				short num2 = num;
				num = (short)1280457115;
				switch (num2 == num)
				{
				}
				num = (short)970129408;
				short num3 = num;
				num = (short)1987837953;
				if (num != 0)
				{
				}
				num = (short)797245440;
				if (num != 0)
				{
				}
				return this.secKmfProfOTARGenerateKeyLossKey_43652.Editable;
			}
			set
			{
				short num = (short)1640988625;
				short num2 = num;
				num = (short)871399377;
				switch (num2 == num)
				{
				}
				num = (short)2121138176;
				short num3 = num;
				num = (short)262209536;
				if (num != 0)
				{
				}
				num = (short)739246081;
				if (num != 0)
				{
				}
				this.secKmfProfOTARGenerateKeyLossKey_43652.Editable = value;
			}
		}

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x060024FC RID: 9468 RVA: 0x0024366C File Offset: 0x0024186C
		internal string SecKmfProfOTARGenerateKeyLossKey_43652_UILabel
		{
			get
			{
				short num = (short)1564359793;
				short num2 = num;
				num = (short)1849048177;
				switch (num2 == num)
				{
				}
				num = (short)224591872;
				short num3 = num;
				num = (short)141033473;
				if (num != 0)
				{
				}
				num = (short)193069056;
				if (num != 0)
				{
				}
				return this.secKmfProfOTARGenerateKeyLossKey_43652.UIName;
			}
		}

		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x060024FD RID: 9469 RVA: 0x00243720 File Offset: 0x00241920
		// (set) Token: 0x060024FE RID: 9470 RVA: 0x002437D4 File Offset: 0x002419D4
		internal bool SecKmfProfOTARGenerateKeyLossKey_43652_HiddenStatic
		{
			get
			{
				short num = (short)1115818890;
				short num2 = num;
				num = (short)2016349066;
				switch (num2 == num)
				{
				}
				num = (short)1594753024;
				short num3 = num;
				num = (short)509542401;
				if (num != 0)
				{
				}
				num = (short)1927413760;
				if (num != 0)
				{
				}
				return this.secKmfProfOTARGenerateKeyLossKey_43652.HiddenStatic;
			}
			set
			{
				short num = (short)2019314961;
				short num2 = num;
				num = (short)2080591121;
				switch (num2 == num)
				{
				}
				num = (short)586809344;
				short num3 = num;
				num = (short)1874132993;
				if (num != 0)
				{
				}
				num = (short)1523580928;
				if (num != 0)
				{
				}
				this.secKmfProfOTARGenerateKeyLossKey_43652.HiddenStatic = value;
			}
		}

		// Token: 0x170012A9 RID: 4777
		// (get) Token: 0x060024FF RID: 9471 RVA: 0x0024388C File Offset: 0x00241A8C
		// (set) Token: 0x06002500 RID: 9472 RVA: 0x00243940 File Offset: 0x00241B40
		internal bool SecKmfProfOTARGenerateKeyLossKey_43652_HiddenDynamic
		{
			get
			{
				short num = (short)1051197441;
				if (num != 0)
				{
				}
				num = (short)1757543774;
				short num2 = num;
				num = (short)1268645214;
				switch (num2 == num)
				{
				default:
				{
					num = (short)413073408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)850657280;
				if (num != 0)
				{
				}
				return this.secKmfProfOTARGenerateKeyLossKey_43652.HiddenDynamic;
			}
			set
			{
				short num = (short)1370817967;
				short num2 = num;
				num = (short)1358824879;
				switch (num2 == num)
				{
				}
				num = (short)174194688;
				short num3 = num;
				num = (short)196608001;
				if (num != 0)
				{
				}
				num = (short)2087518208;
				if (num != 0)
				{
				}
				this.secKmfProfOTARGenerateKeyLossKey_43652.HiddenDynamic = value;
			}
		}

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x06002501 RID: 9473 RVA: 0x002439F4 File Offset: 0x00241BF4
		public bool SecKmfProfOTARGenerateKeyLossKey_43652_HasDiffs
		{
			get
			{
				short num = (short)589860753;
				short num2 = num;
				num = (short)559124369;
				switch (num2 == num)
				{
				}
				num = (short)1916928000;
				short num3 = num;
				num = (short)1744568321;
				if (num != 0)
				{
				}
				num = (short)1679294464;
				if (num != 0)
				{
				}
				return this.secKmfProfOTARGenerateKeyLossKey_43652._HasDiffs;
			}
		}

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x06002502 RID: 9474 RVA: 0x00243AAC File Offset: 0x00241CAC
		// (set) Token: 0x06002503 RID: 9475 RVA: 0x00243B60 File Offset: 0x00241D60
		public bool SecKmfProfKVLFIPSLevel3ApprovedMode_43653Value
		{
			get
			{
				short num = (short)1813093497;
				short num2 = num;
				num = (short)463772793;
				switch (num2 == num)
				{
				}
				num = (short)1326383104;
				short num3 = num;
				num = (short)730202113;
				if (num != 0)
				{
				}
				num = (short)681312256;
				if (num != 0)
				{
				}
				return this.secKmfProfKVLFIPSLevel3ApprovedMode_43653.Value;
			}
			set
			{
				short num = (short)951892834;
				short num2 = num;
				num = (short)1551678306;
				switch (num2 == num)
				{
				}
				num = (short)723910656;
				short num3 = num;
				num = (short)1007681537;
				if (num != 0)
				{
				}
				num = (short)1628176384;
				if (num != 0)
				{
				}
				this.secKmfProfKVLFIPSLevel3ApprovedMode_43653.Value = value;
			}
		}

		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x06002504 RID: 9476 RVA: 0x00243C18 File Offset: 0x00241E18
		public global::AcpBusinessLayer.AcpField<bool> SecKmfProfKVLFIPSLevel3ApprovedMode_43653
		{
			get
			{
				short num = (short)756867553;
				short num2 = num;
				num = (short)1503060449;
				switch (num2 == num)
				{
				}
				num = (short)1975123968;
				short num3 = num;
				num = (short)2143748096;
				if (num != 0)
				{
				}
				num = (short)1481834497;
				if (num != 0)
				{
				}
				return this.secKmfProfKVLFIPSLevel3ApprovedMode_43653;
			}
		}

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x06002505 RID: 9477 RVA: 0x00243CC8 File Offset: 0x00241EC8
		// (set) Token: 0x06002506 RID: 9478 RVA: 0x00243D7C File Offset: 0x00241F7C
		public bool SecKmfProfKVLFIPSLevel3ApprovedMode_43653_UIValue
		{
			get
			{
				short num = (short)1170605951;
				short num2 = num;
				num = (short)95094655;
				switch (num2 == num)
				{
				}
				num = (short)990838784;
				short num3 = num;
				num = (short)459341825;
				if (num != 0)
				{
				}
				num = (short)1825243136;
				if (num != 0)
				{
				}
				return this.secKmfProfKVLFIPSLevel3ApprovedMode_43653.Value;
			}
			set
			{
				short num = (short)1618927589;
				short num2 = num;
				num = (short)1900863461;
				switch (num2 == num)
				{
				}
				num = (short)1705639936;
				short num3 = num;
				num = (short)111149057;
				if (num != 0)
				{
				}
				num = (short)1488125952;
				if (num != 0)
				{
				}
				this.secKmfProfKVLFIPSLevel3ApprovedMode_43653.Value = value;
			}
		}

		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x06002507 RID: 9479 RVA: 0x00243E30 File Offset: 0x00242030
		// (set) Token: 0x06002508 RID: 9480 RVA: 0x00243EE4 File Offset: 0x002420E4
		public bool SecKmfProfKVLFIPSLevel3ApprovedMode_43653_Applicable
		{
			get
			{
				short num = (short)782783217;
				short num2 = num;
				num = (short)801264369;
				switch (num2 == num)
				{
				}
				num = (short)597557248;
				short num3 = num;
				num = (short)268500992;
				if (num != 0)
				{
				}
				num = (short)1330642945;
				if (num != 0)
				{
				}
				return this.secKmfProfKVLFIPSLevel3ApprovedMode_43653.Applicable;
			}
			set
			{
				short num = (short)1547365027;
				short num2 = num;
				num = (short)1908140707;
				switch (num2 == num)
				{
				}
				num = (short)1959460864;
				short num3 = num;
				num = (short)1405943808;
				if (num != 0)
				{
				}
				num = (short)1671692289;
				if (num != 0)
				{
				}
				this.secKmfProfKVLFIPSLevel3ApprovedMode_43653.Applicable = value;
			}
		}

		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x06002509 RID: 9481 RVA: 0x00243F98 File Offset: 0x00242198
		// (set) Token: 0x0600250A RID: 9482 RVA: 0x0024404C File Offset: 0x0024224C
		public bool SecKmfProfKVLFIPSLevel3ApprovedMode_43653_Valid
		{
			get
			{
				short num = (short)711804512;
				short num2 = num;
				num = (short)917259872;
				switch (num2 == num)
				{
				}
				num = (short)419233792;
				short num3 = num;
				num = (short)92733441;
				if (num != 0)
				{
				}
				num = (short)1956315136;
				if (num != 0)
				{
				}
				return this.secKmfProfKVLFIPSLevel3ApprovedMode_43653.Valid;
			}
			set
			{
				short num = (short)210172446;
				short num2 = num;
				num = (short)1722546718;
				switch (num2 == num)
				{
				}
				num = (short)752680960;
				short num3 = num;
				num = (short)869400577;
				if (num != 0)
				{
				}
				num = (short)1085603840;
				if (num != 0)
				{
				}
				this.secKmfProfKVLFIPSLevel3ApprovedMode_43653.Valid = value;
			}
		}

		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x0600250B RID: 9483 RVA: 0x00244104 File Offset: 0x00242304
		// (set) Token: 0x0600250C RID: 9484 RVA: 0x002441BC File Offset: 0x002423BC
		public bool SecKmfProfKVLFIPSLevel3ApprovedMode_43653_Visible
		{
			get
			{
				short num = (short)1703156982;
				short num2 = num;
				num = (short)1782127862;
				switch (num2 == num)
				{
				}
				num = (short)2077818880;
				short num3 = num;
				num = (short)1108279297;
				if (num != 0)
				{
				}
				num = (short)1506672640;
				if (num != 0)
				{
				}
				return this.secKmfProfKVLFIPSLevel3ApprovedMode_43653.Visible;
			}
			set
			{
				short num = (short)1567484944;
				short num2 = num;
				num = (short)1329851408;
				switch (num2 == num)
				{
				}
				num = (short)1295908864;
				short num3 = num;
				num = (short)371851265;
				if (num != 0)
				{
				}
				num = (short)2079391744;
				if (num != 0)
				{
				}
				this.secKmfProfKVLFIPSLevel3ApprovedMode_43653.Visible = value;
			}
		}

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x0600250D RID: 9485 RVA: 0x00244274 File Offset: 0x00242474
		// (set) Token: 0x0600250E RID: 9486 RVA: 0x0024432C File Offset: 0x0024252C
		public bool SecKmfProfKVLFIPSLevel3ApprovedMode_43653_Editable
		{
			get
			{
				short num = (short)236263586;
				short num2 = num;
				num = (short)256907426;
				switch (num2 == num)
				{
				}
				num = (short)1919680512;
				short num3 = num;
				num = (short)1518600193;
				if (num != 0)
				{
				}
				num = (short)1249837056;
				if (num != 0)
				{
				}
				return this.secKmfProfKVLFIPSLevel3ApprovedMode_43653.Editable;
			}
			set
			{
				short num = (short)227280723;
				short num2 = num;
				num = (short)1520371539;
				switch (num2 == num)
				{
				}
				num = (short)439484416;
				short num3 = num;
				num = (short)183238657;
				if (num != 0)
				{
				}
				num = (short)504954880;
				if (num != 0)
				{
				}
				this.secKmfProfKVLFIPSLevel3ApprovedMode_43653.Editable = value;
			}
		}

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x0600250F RID: 9487 RVA: 0x002443E0 File Offset: 0x002425E0
		internal string SecKmfProfKVLFIPSLevel3ApprovedMode_43653_UILabel
		{
			get
			{
				short num = (short)424325931;
				short num2 = num;
				num = (short)240956203;
				switch (num2 == num)
				{
				}
				num = (short)1564016640;
				short num3 = num;
				num = (short)1002176513;
				if (num != 0)
				{
				}
				num = (short)457637888;
				if (num != 0)
				{
				}
				return this.secKmfProfKVLFIPSLevel3ApprovedMode_43653.UIName;
			}
		}

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x06002510 RID: 9488 RVA: 0x00244494 File Offset: 0x00242694
		// (set) Token: 0x06002511 RID: 9489 RVA: 0x0024454C File Offset: 0x0024274C
		internal bool SecKmfProfKVLFIPSLevel3ApprovedMode_43653_HiddenStatic
		{
			get
			{
				short num = (short)893170652;
				short num2 = num;
				num = (short)1029223388;
				switch (num2 == num)
				{
				}
				num = (short)576323584;
				short num3 = num;
				num = (short)337051649;
				if (num != 0)
				{
				}
				num = (short)1569062912;
				if (num != 0)
				{
				}
				return this.secKmfProfKVLFIPSLevel3ApprovedMode_43653.HiddenStatic;
			}
			set
			{
				short num = (short)1971953720;
				short num2 = num;
				num = (short)1660723256;
				switch (num2 == num)
				{
				}
				num = (short)327942144;
				short num3 = num;
				num = (short)1306001409;
				if (num != 0)
				{
				}
				num = (short)1722417152;
				if (num != 0)
				{
				}
				this.secKmfProfKVLFIPSLevel3ApprovedMode_43653.HiddenStatic = value;
			}
		}

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x06002512 RID: 9490 RVA: 0x00244604 File Offset: 0x00242804
		// (set) Token: 0x06002513 RID: 9491 RVA: 0x002446B8 File Offset: 0x002428B8
		internal bool SecKmfProfKVLFIPSLevel3ApprovedMode_43653_HiddenDynamic
		{
			get
			{
				short num = (short)1412562945;
				if (num != 0)
				{
				}
				num = (short)465484537;
				short num2 = num;
				num = (short)852933369;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1296367616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1451098112;
				if (num != 0)
				{
				}
				return this.secKmfProfKVLFIPSLevel3ApprovedMode_43653.HiddenDynamic;
			}
			set
			{
				short num = (short)1669656560;
				short num2 = num;
				num = (short)1465380848;
				switch (num2 == num)
				{
				}
				num = (short)531955712;
				short num3 = num;
				num = (short)290848768;
				if (num != 0)
				{
				}
				num = (short)1190658049;
				if (num != 0)
				{
				}
				this.secKmfProfKVLFIPSLevel3ApprovedMode_43653.HiddenDynamic = value;
			}
		}

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x06002514 RID: 9492 RVA: 0x0024476C File Offset: 0x0024296C
		public bool SecKmfProfKVLFIPSLevel3ApprovedMode_43653_HasDiffs
		{
			get
			{
				short num = (short)154312165;
				short num2 = num;
				num = (short)795319781;
				switch (num2 == num)
				{
				}
				num = (short)390856704;
				short num3 = num;
				num = (short)1741029377;
				if (num != 0)
				{
				}
				num = (short)1208877056;
				if (num != 0)
				{
				}
				return this.secKmfProfKVLFIPSLevel3ApprovedMode_43653._HasDiffs;
			}
		}

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x06002515 RID: 9493 RVA: 0x00244824 File Offset: 0x00242A24
		// (set) Token: 0x06002516 RID: 9494 RVA: 0x002448D8 File Offset: 0x00242AD8
		public bool SecKmfProfUserSelectable_43657Value
		{
			get
			{
				short num = (short)203063702;
				short num2 = num;
				num = (short)2117894550;
				switch (num2 == num)
				{
				}
				num = (short)38273024;
				short num3 = num;
				num = (short)1804730368;
				if (num != 0)
				{
				}
				num = (short)850788353;
				if (num != 0)
				{
				}
				return this.secKmfProfUserSelectable_43657.Value;
			}
			set
			{
				short num = (short)1660371527;
				short num2 = num;
				num = (short)1225671239;
				switch (num2 == num)
				{
				}
				num = (short)1698889728;
				short num3 = num;
				num = (short)1887698944;
				if (num != 0)
				{
				}
				num = (short)1576271873;
				if (num != 0)
				{
				}
				this.secKmfProfUserSelectable_43657.Value = value;
			}
		}

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x06002517 RID: 9495 RVA: 0x0024498C File Offset: 0x00242B8C
		public global::AcpBusinessLayer.AcpField<bool> SecKmfProfUserSelectable_43657
		{
			get
			{
				short num = (short)1996582837;
				short num2 = num;
				num = (short)710242229;
				switch (num2 == num)
				{
				}
				num = (short)1789591552;
				short num3 = num;
				num = (short)1667497985;
				if (num != 0)
				{
				}
				num = (short)1254424576;
				if (num != 0)
				{
				}
				return this.secKmfProfUserSelectable_43657;
			}
		}

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x06002518 RID: 9496 RVA: 0x00244A3C File Offset: 0x00242C3C
		// (set) Token: 0x06002519 RID: 9497 RVA: 0x00244AF0 File Offset: 0x00242CF0
		public bool SecKmfProfUserSelectable_43657_UIValue
		{
			get
			{
				short num = (short)1965633774;
				short num2 = num;
				num = (short)755511534;
				switch (num2 == num)
				{
				}
				num = (short)1487273984;
				short num3 = num;
				num = (short)1950875648;
				if (num != 0)
				{
				}
				num = (short)1426391041;
				if (num != 0)
				{
				}
				return this.secKmfProfUserSelectable_43657.Value;
			}
			set
			{
				short num = (short)800952360;
				short num2 = num;
				num = (short)1660653608;
				switch (num2 == num)
				{
				}
				num = (short)760807424;
				short num3 = num;
				num = (short)830275585;
				if (num != 0)
				{
				}
				num = (short)1928658944;
				if (num != 0)
				{
				}
				this.secKmfProfUserSelectable_43657.Value = value;
			}
		}

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x0600251A RID: 9498 RVA: 0x00244BA8 File Offset: 0x00242DA8
		// (set) Token: 0x0600251B RID: 9499 RVA: 0x00244C5C File Offset: 0x00242E5C
		public bool SecKmfProfUserSelectable_43657_Applicable
		{
			get
			{
				short num = (short)1902706689;
				if (num != 0)
				{
				}
				num = (short)1032171085;
				short num2 = num;
				num = (short)1283436109;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1286930432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2111242240;
				if (num != 0)
				{
				}
				return this.secKmfProfUserSelectable_43657.Applicable;
			}
			set
			{
				short num = (short)1537284667;
				short num2 = num;
				num = (short)155720251;
				switch (num2 == num)
				{
				}
				num = (short)583729152;
				short num3 = num;
				num = (short)1514668033;
				if (num != 0)
				{
				}
				num = (short)1981218816;
				if (num != 0)
				{
				}
				this.secKmfProfUserSelectable_43657.Applicable = value;
			}
		}

		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x0600251C RID: 9500 RVA: 0x00244D14 File Offset: 0x00242F14
		// (set) Token: 0x0600251D RID: 9501 RVA: 0x00244DC4 File Offset: 0x00242FC4
		public bool SecKmfProfUserSelectable_43657_Valid
		{
			get
			{
				short num = (short)981133333;
				short num2 = num;
				num = (short)505407509;
				switch (num2 == num)
				{
				}
				num = (short)1438449664;
				short num3 = num;
				num = (short)297336833;
				if (num != 0)
				{
				}
				num = (short)901775360;
				if (num != 0)
				{
				}
				return this.secKmfProfUserSelectable_43657.Valid;
			}
			set
			{
				short num = (short)1010497169;
				short num2 = num;
				num = (short)2025191057;
				switch (num2 == num)
				{
				}
				num = (short)2132344832;
				short num3 = num;
				num = (short)1560412161;
				if (num != 0)
				{
				}
				num = (short)1123745792;
				if (num != 0)
				{
				}
				this.secKmfProfUserSelectable_43657.Valid = value;
			}
		}

		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x0600251E RID: 9502 RVA: 0x00244E78 File Offset: 0x00243078
		// (set) Token: 0x0600251F RID: 9503 RVA: 0x00244F2C File Offset: 0x0024312C
		public bool SecKmfProfUserSelectable_43657_Visible
		{
			get
			{
				short num = (short)509129782;
				short num2 = num;
				num = (short)323597366;
				switch (num2 == num)
				{
				}
				num = (short)1663696896;
				short num3 = num;
				num = (short)1096941569;
				if (num != 0)
				{
				}
				num = (short)1712783360;
				if (num != 0)
				{
				}
				return this.secKmfProfUserSelectable_43657.Visible;
			}
			set
			{
				short num = (short)1766588417;
				if (num != 0)
				{
				}
				num = (short)30329420;
				short num2 = num;
				num = (short)250333772;
				switch (num2 == num)
				{
				default:
				{
					num = (short)660602880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1802698752;
				if (num != 0)
				{
				}
				this.secKmfProfUserSelectable_43657.Visible = value;
			}
		}

		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x06002520 RID: 9504 RVA: 0x00244FE0 File Offset: 0x002431E0
		// (set) Token: 0x06002521 RID: 9505 RVA: 0x00245094 File Offset: 0x00243294
		public bool SecKmfProfUserSelectable_43657_Editable
		{
			get
			{
				short num = (short)1751954102;
				short num2 = num;
				num = (short)1633923766;
				switch (num2 == num)
				{
				}
				num = (short)1318780928;
				short num3 = num;
				num = (short)1406205952;
				if (num != 0)
				{
				}
				num = (short)1109131265;
				if (num != 0)
				{
				}
				return this.secKmfProfUserSelectable_43657.Editable;
			}
			set
			{
				short num = (short)311487809;
				short num2 = num;
				num = (short)1882320193;
				switch (num2 == num)
				{
				}
				num = (short)1672544256;
				short num3 = num;
				num = (short)623378433;
				if (num != 0)
				{
				}
				num = (short)1838612480;
				if (num != 0)
				{
				}
				this.secKmfProfUserSelectable_43657.Editable = value;
			}
		}

		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x06002522 RID: 9506 RVA: 0x0024514C File Offset: 0x0024334C
		internal string SecKmfProfUserSelectable_43657_UILabel
		{
			get
			{
				short num = (short)273027271;
				short num2 = num;
				num = (short)988549319;
				switch (num2 == num)
				{
				}
				num = (short)503840768;
				short num3 = num;
				num = (short)4849664;
				if (num != 0)
				{
				}
				num = (short)1409482753;
				if (num != 0)
				{
				}
				return this.secKmfProfUserSelectable_43657.UIName;
			}
		}

		// Token: 0x170012BE RID: 4798
		// (get) Token: 0x06002523 RID: 9507 RVA: 0x00245204 File Offset: 0x00243404
		// (set) Token: 0x06002524 RID: 9508 RVA: 0x002452B8 File Offset: 0x002434B8
		internal bool SecKmfProfUserSelectable_43657_HiddenStatic
		{
			get
			{
				short num = (short)337022153;
				short num2 = num;
				num = (short)789810377;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1227030528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1841496065;
				if (num != 0)
				{
				}
				num = (short)1760690176;
				if (num != 0)
				{
				}
				return this.secKmfProfUserSelectable_43657.HiddenStatic;
			}
			set
			{
				short num = (short)363855873;
				if (num != 0)
				{
				}
				num = (short)433258496;
				short num2 = num;
				num = (short)1966179495;
				short num3 = num;
				num = (short)982484135;
				switch (num3 == num)
				{
				}
				num = (short)874315776;
				if (num != 0)
				{
				}
				this.secKmfProfUserSelectable_43657.HiddenStatic = value;
			}
		}

		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x06002525 RID: 9509 RVA: 0x00245374 File Offset: 0x00243574
		// (set) Token: 0x06002526 RID: 9510 RVA: 0x00245428 File Offset: 0x00243628
		internal bool SecKmfProfUserSelectable_43657_HiddenDynamic
		{
			get
			{
				short num = (short)463929775;
				short num2 = num;
				num = (short)1506869679;
				switch (num2 == num)
				{
				default:
				{
					num = (short)911474688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1197998081;
				if (num != 0)
				{
				}
				num = (short)1365311488;
				if (num != 0)
				{
				}
				return this.secKmfProfUserSelectable_43657.HiddenDynamic;
			}
			set
			{
				short num = (short)1445259765;
				short num2 = num;
				num = (short)5368309;
				switch (num2 == num)
				{
				default:
				{
					num = (short)770048000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1840447488;
				if (num != 0)
				{
				}
				num = (short)1730019329;
				if (num != 0)
				{
				}
				this.secKmfProfUserSelectable_43657.HiddenDynamic = value;
			}
		}

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x06002527 RID: 9511 RVA: 0x002454DC File Offset: 0x002436DC
		public bool SecKmfProfUserSelectable_43657_HasDiffs
		{
			get
			{
				short num = (short)764739364;
				short num2 = num;
				num = (short)974389028;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1248198656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)787873793;
				if (num != 0)
				{
				}
				num = (short)1564082176;
				if (num != 0)
				{
				}
				return this.secKmfProfUserSelectable_43657._HasDiffs;
			}
		}

		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x06002528 RID: 9512 RVA: 0x00245590 File Offset: 0x00243790
		// (set) Token: 0x06002529 RID: 9513 RVA: 0x00245644 File Offset: 0x00243844
		public bool SecKmfProfErasePreviousOnUserChange_43658Value
		{
			get
			{
				short num = (short)520224769;
				if (num != 0)
				{
				}
				num = (short)1197867008;
				short num2 = num;
				num = (short)517380201;
				short num3 = num;
				num = (short)892442729;
				switch (num3 == num)
				{
				}
				num = (short)78577664;
				if (num != 0)
				{
				}
				return this.secKmfProfErasePreviousOnUserChange_43658.Value;
			}
			set
			{
				short num = (short)2004569610;
				short num2 = num;
				num = (short)1768181258;
				switch (num2 == num)
				{
				default:
				{
					num = (short)847183872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)265879553;
				if (num != 0)
				{
				}
				num = (short)16777216;
				if (num != 0)
				{
				}
				this.secKmfProfErasePreviousOnUserChange_43658.Value = value;
			}
		}

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x0600252A RID: 9514 RVA: 0x002456FC File Offset: 0x002438FC
		public global::AcpBusinessLayer.AcpField<bool> SecKmfProfErasePreviousOnUserChange_43658
		{
			get
			{
				short num = (short)381485057;
				if (num != 0)
				{
				}
				num = (short)1183711232;
				short num2 = num;
				num = (short)630463823;
				short num3 = num;
				num = (short)287841615;
				switch (num3 == num)
				{
				}
				num = (short)975110144;
				if (num != 0)
				{
				}
				return this.secKmfProfErasePreviousOnUserChange_43658;
			}
		}

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x0600252B RID: 9515 RVA: 0x002457AC File Offset: 0x002439AC
		// (set) Token: 0x0600252C RID: 9516 RVA: 0x00245860 File Offset: 0x00243A60
		public bool SecKmfProfErasePreviousOnUserChange_43658_UIValue
		{
			get
			{
				short num = (short)788138469;
				short num2 = num;
				num = (short)778635749;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1574699008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1001521153;
				if (num != 0)
				{
				}
				num = (short)338231296;
				if (num != 0)
				{
				}
				return this.secKmfProfErasePreviousOnUserChange_43658.Value;
			}
			set
			{
				short num = (short)1798208295;
				short num2 = num;
				num = (short)129399591;
				switch (num2 == num)
				{
				default:
				{
					num = (short)143458304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)881328129;
				if (num != 0)
				{
				}
				num = (short)1667432448;
				if (num != 0)
				{
				}
				this.secKmfProfErasePreviousOnUserChange_43658.Value = value;
			}
		}

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x0600252D RID: 9517 RVA: 0x00245914 File Offset: 0x00243B14
		// (set) Token: 0x0600252E RID: 9518 RVA: 0x002459C8 File Offset: 0x00243BC8
		public bool SecKmfProfErasePreviousOnUserChange_43658_Applicable
		{
			get
			{
				short num = (short)104241873;
				short num2 = num;
				num = (short)550804177;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1049034752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1622671360;
				if (num != 0)
				{
				}
				num = (short)281411585;
				if (num != 0)
				{
				}
				return this.secKmfProfErasePreviousOnUserChange_43658.Applicable;
			}
			set
			{
				short num = (short)860861271;
				short num2 = num;
				num = (short)798405463;
				switch (num2 == num)
				{
				default:
				{
					num = (short)582746112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)879230977;
				if (num != 0)
				{
				}
				num = (short)1835466752;
				if (num != 0)
				{
				}
				this.secKmfProfErasePreviousOnUserChange_43658.Applicable = value;
			}
		}

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x0600252F RID: 9519 RVA: 0x00245A80 File Offset: 0x00243C80
		// (set) Token: 0x06002530 RID: 9520 RVA: 0x00245B34 File Offset: 0x00243D34
		public bool SecKmfProfErasePreviousOnUserChange_43658_Valid
		{
			get
			{
				short num = (short)1795241836;
				short num2 = num;
				num = (short)1694513004;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1919352832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1949827073;
				if (num != 0)
				{
				}
				num = (short)1689255936;
				if (num != 0)
				{
				}
				return this.secKmfProfErasePreviousOnUserChange_43658.Valid;
			}
			set
			{
				short num = (short)1024279515;
				short num2 = num;
				num = (short)2096055259;
				switch (num2 == num)
				{
				default:
				{
					num = (short)863109120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)649723904;
				if (num != 0)
				{
				}
				num = (short)633470977;
				if (num != 0)
				{
				}
				this.secKmfProfErasePreviousOnUserChange_43658.Valid = value;
			}
		}

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x06002531 RID: 9521 RVA: 0x00245BE8 File Offset: 0x00243DE8
		// (set) Token: 0x06002532 RID: 9522 RVA: 0x00245C9C File Offset: 0x00243E9C
		public bool SecKmfProfErasePreviousOnUserChange_43658_Visible
		{
			get
			{
				short num = (short)668370544;
				short num2 = num;
				num = (short)1812366960;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1465450496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1401683969;
				if (num != 0)
				{
				}
				num = (short)32505856;
				if (num != 0)
				{
				}
				return this.secKmfProfErasePreviousOnUserChange_43658.Visible;
			}
			set
			{
				short num = (short)484625397;
				short num2 = num;
				num = (short)508414965;
				switch (num2 == num)
				{
				default:
				{
					num = (short)914817024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1418657793;
				if (num != 0)
				{
				}
				num = (short)1735327744;
				if (num != 0)
				{
				}
				this.secKmfProfErasePreviousOnUserChange_43658.Visible = value;
			}
		}

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x06002533 RID: 9523 RVA: 0x00245D50 File Offset: 0x00243F50
		// (set) Token: 0x06002534 RID: 9524 RVA: 0x00245E04 File Offset: 0x00244004
		public bool SecKmfProfErasePreviousOnUserChange_43658_Editable
		{
			get
			{
				short num = (short)406781953;
				if (num != 0)
				{
				}
				num = (short)821362688;
				short num2 = num;
				num = (short)1349098553;
				short num3 = num;
				num = (short)2050006073;
				switch (num3 == num)
				{
				}
				num = (short)801964032;
				if (num != 0)
				{
				}
				return this.secKmfProfErasePreviousOnUserChange_43658.Editable;
			}
			set
			{
				short num = (short)376459408;
				short num2 = num;
				num = (short)150622352;
				switch (num2 == num)
				{
				default:
				{
					num = (short)918421504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)94896129;
				if (num != 0)
				{
				}
				num = (short)1526530048;
				if (num != 0)
				{
				}
				this.secKmfProfErasePreviousOnUserChange_43658.Editable = value;
			}
		}

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x06002535 RID: 9525 RVA: 0x00245EBC File Offset: 0x002440BC
		internal string SecKmfProfErasePreviousOnUserChange_43658_UILabel
		{
			get
			{
				short num = (short)1325030688;
				short num2 = num;
				num = (short)784096544;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2055864320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1682964480;
				if (num != 0)
				{
				}
				num = (short)139395073;
				if (num != 0)
				{
				}
				return this.secKmfProfErasePreviousOnUserChange_43658.UIName;
			}
		}

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x06002536 RID: 9526 RVA: 0x00245F70 File Offset: 0x00244170
		// (set) Token: 0x06002537 RID: 9527 RVA: 0x00246020 File Offset: 0x00244220
		internal bool SecKmfProfErasePreviousOnUserChange_43658_HiddenStatic
		{
			get
			{
				short num = (short)676028280;
				short num2 = num;
				num = (short)1403608952;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1825439744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)76808193;
				if (num != 0)
				{
				}
				num = (short)312737792;
				if (num != 0)
				{
				}
				return this.secKmfProfErasePreviousOnUserChange_43658.HiddenStatic;
			}
			set
			{
				short num = (short)992969752;
				short num2 = num;
				num = (short)412648472;
				switch (num2 == num)
				{
				default:
				{
					num = (short)727187456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)759037953;
				if (num != 0)
				{
				}
				num = (short)334102528;
				if (num != 0)
				{
				}
				this.secKmfProfErasePreviousOnUserChange_43658.HiddenStatic = value;
			}
		}

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x06002538 RID: 9528 RVA: 0x002460D8 File Offset: 0x002442D8
		// (set) Token: 0x06002539 RID: 9529 RVA: 0x0024618C File Offset: 0x0024438C
		internal bool SecKmfProfErasePreviousOnUserChange_43658_HiddenDynamic
		{
			get
			{
				short num = (short)183258442;
				short num2 = num;
				num = (short)1539067210;
				switch (num2 == num)
				{
				default:
				{
					num = (short)191496192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1576468481;
				if (num != 0)
				{
				}
				num = (short)433127424;
				if (num != 0)
				{
				}
				return this.secKmfProfErasePreviousOnUserChange_43658.HiddenDynamic;
			}
			set
			{
				short num = (short)550174721;
				if (num != 0)
				{
				}
				num = (short)177733632;
				short num2 = num;
				num = (short)1804283076;
				short num3 = num;
				num = (short)1429482692;
				switch (num3 == num)
				{
				}
				num = (short)60358656;
				if (num != 0)
				{
				}
				this.secKmfProfErasePreviousOnUserChange_43658.HiddenDynamic = value;
			}
		}

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x0600253A RID: 9530 RVA: 0x00246244 File Offset: 0x00244444
		public bool SecKmfProfErasePreviousOnUserChange_43658_HasDiffs
		{
			get
			{
				short num = (short)534219380;
				short num2 = num;
				num = (short)2102889076;
				switch (num2 == num)
				{
				default:
				{
					num = (short)387252224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)231211009;
				if (num != 0)
				{
				}
				num = (short)1744830464;
				if (num != 0)
				{
				}
				return this.secKmfProfErasePreviousOnUserChange_43658._HasDiffs;
			}
		}

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x0600253B RID: 9531 RVA: 0x002462F8 File Offset: 0x002444F8
		// (set) Token: 0x0600253C RID: 9532 RVA: 0x002463AC File Offset: 0x002445AC
		public string SecKmfProfileSecureProfileGUID_43662Value
		{
			get
			{
				short num = (short)1646547384;
				short num2 = num;
				num = (short)23613880;
				switch (num2 == num)
				{
				default:
				{
					num = (short)214761472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2141126657;
				if (num != 0)
				{
				}
				num = (short)1540816896;
				if (num != 0)
				{
				}
				return this.secKmfProfileSecureProfileGUID_43662.Value;
			}
			set
			{
				short num = (short)431118642;
				short num2 = num;
				num = (short)596990258;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1934491648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)324599809;
				if (num != 0)
				{
				}
				num = (short)187891712;
				if (num != 0)
				{
				}
				this.secKmfProfileSecureProfileGUID_43662.Value = value;
			}
		}

		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x0600253D RID: 9533 RVA: 0x00246464 File Offset: 0x00244664
		public global::AcpBusinessLayer.AcpFieldX<string, string> SecKmfProfileSecureProfileGUID_43662
		{
			get
			{
				short num = (short)344901034;
				short num2 = num;
				num = (short)1960428970;
				switch (num2 == num)
				{
				default:
				{
					num = (short)824442880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1770651648;
				if (num != 0)
				{
				}
				num = (short)2067922945;
				if (num != 0)
				{
				}
				return this.secKmfProfileSecureProfileGUID_43662;
			}
		}

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x0600253E RID: 9534 RVA: 0x00246518 File Offset: 0x00244718
		// (set) Token: 0x0600253F RID: 9535 RVA: 0x002465CC File Offset: 0x002447CC
		public string SecKmfProfileSecureProfileGUID_43662_UIValue
		{
			get
			{
				short num = (short)8612572;
				short num2 = num;
				num = (short)1177905884;
				switch (num2 == num)
				{
				default:
				{
					num = (short)796786688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1558315009;
				if (num != 0)
				{
				}
				num = (short)680460288;
				if (num != 0)
				{
				}
				return this.secKmfProfileSecureProfileGUID_43662.UIValue;
			}
			set
			{
				short num = (short)1426912274;
				short num2 = num;
				num = (short)911275026;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1932787712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)390201345;
				if (num != 0)
				{
				}
				num = (short)279707648;
				if (num != 0)
				{
				}
				this.secKmfProfileSecureProfileGUID_43662.UIValue = value;
			}
		}

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x06002540 RID: 9536 RVA: 0x00246684 File Offset: 0x00244884
		// (set) Token: 0x06002541 RID: 9537 RVA: 0x0024673C File Offset: 0x0024493C
		public bool SecKmfProfileSecureProfileGUID_43662_Applicable
		{
			get
			{
				short num = (short)888181289;
				short num2 = num;
				num = (short)1808896553;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1088749568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)989724672;
				if (num != 0)
				{
				}
				num = (short)212926465;
				if (num != 0)
				{
				}
				return this.secKmfProfileSecureProfileGUID_43662.Applicable;
			}
			set
			{
				short num = (short)1159737297;
				short num2 = num;
				num = (short)279064529;
				switch (num2 == num)
				{
				default:
				{
					num = (short)640942080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)964493313;
				if (num != 0)
				{
				}
				num = (short)1578565632;
				if (num != 0)
				{
				}
				this.secKmfProfileSecureProfileGUID_43662.Applicable = value;
			}
		}

		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x06002542 RID: 9538 RVA: 0x002467F0 File Offset: 0x002449F0
		// (set) Token: 0x06002543 RID: 9539 RVA: 0x002468A8 File Offset: 0x00244AA8
		public bool SecKmfProfileSecureProfileGUID_43662_Valid
		{
			get
			{
				short num = (short)9005631;
				short num2 = num;
				num = (short)1058630207;
				switch (num2 == num)
				{
				default:
				{
					num = (short)237436928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)532086785;
				if (num != 0)
				{
				}
				num = (short)629342208;
				if (num != 0)
				{
				}
				return this.secKmfProfileSecureProfileGUID_43662.Valid;
			}
			set
			{
				short num = (short)478478337;
				if (num != 0)
				{
				}
				num = (short)965935104;
				short num2 = num;
				num = (short)847642318;
				short num3 = num;
				num = (short)298385102;
				switch (num3 == num)
				{
				}
				num = (short)196214784;
				if (num != 0)
				{
				}
				this.secKmfProfileSecureProfileGUID_43662.Valid = value;
			}
		}

		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x06002544 RID: 9540 RVA: 0x0024695C File Offset: 0x00244B5C
		// (set) Token: 0x06002545 RID: 9541 RVA: 0x00246A10 File Offset: 0x00244C10
		public bool SecKmfProfileSecureProfileGUID_43662_Visible
		{
			get
			{
				short num = (short)758646746;
				short num2 = num;
				num = (short)114886618;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2034630656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)231866369;
				if (num != 0)
				{
				}
				num = (short)1865875456;
				if (num != 0)
				{
				}
				return this.secKmfProfileSecureProfileGUID_43662.Visible;
			}
			set
			{
				short num = (short)821852809;
				short num2 = num;
				num = (short)920615561;
				switch (num2 == num)
				{
				default:
				{
					num = (short)860553216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1989541889;
				if (num != 0)
				{
				}
				num = (short)1536229376;
				if (num != 0)
				{
				}
				this.secKmfProfileSecureProfileGUID_43662.Visible = value;
			}
		}

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x06002546 RID: 9542 RVA: 0x00246AC4 File Offset: 0x00244CC4
		// (set) Token: 0x06002547 RID: 9543 RVA: 0x00246B78 File Offset: 0x00244D78
		public bool SecKmfProfileSecureProfileGUID_43662_Editable
		{
			get
			{
				short num = (short)1942236803;
				short num2 = num;
				num = (short)1309814403;
				switch (num2 == num)
				{
				default:
				{
					num = (short)789774336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)108134401;
				if (num != 0)
				{
				}
				num = (short)1409351680;
				if (num != 0)
				{
				}
				return this.secKmfProfileSecureProfileGUID_43662.Editable;
			}
			set
			{
				short num = (short)396669484;
				short num2 = num;
				num = (short)1781117484;
				switch (num2 == num)
				{
				default:
				{
					num = (short)929366016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1840119808;
				if (num != 0)
				{
				}
				num = (short)875036673;
				if (num != 0)
				{
				}
				this.secKmfProfileSecureProfileGUID_43662.Editable = value;
			}
		}

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x06002548 RID: 9544 RVA: 0x00246C30 File Offset: 0x00244E30
		internal string SecKmfProfileSecureProfileGUID_43662_UILabel
		{
			get
			{
				short num = (short)1491187266;
				short num2 = num;
				num = (short)81704514;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1955201024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)902692865;
				if (num != 0)
				{
				}
				num = (short)261947392;
				if (num != 0)
				{
				}
				return this.secKmfProfileSecureProfileGUID_43662.UIName;
			}
		}

		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x06002549 RID: 9545 RVA: 0x00246CE8 File Offset: 0x00244EE8
		// (set) Token: 0x0600254A RID: 9546 RVA: 0x00246D9C File Offset: 0x00244F9C
		internal bool SecKmfProfileSecureProfileGUID_43662_HiddenStatic
		{
			get
			{
				short num = (short)292338645;
				short num2 = num;
				num = (short)296336341;
				switch (num2 == num)
				{
				default:
				{
					num = (short)898629632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)348192769;
				if (num != 0)
				{
				}
				num = (short)1852637184;
				if (num != 0)
				{
				}
				return this.secKmfProfileSecureProfileGUID_43662.HiddenStatic;
			}
			set
			{
				short num = (short)933582727;
				short num2 = num;
				num = (short)1798133639;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1795031040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)573112321;
				if (num != 0)
				{
				}
				num = (short)1013907456;
				if (num != 0)
				{
				}
				this.secKmfProfileSecureProfileGUID_43662.HiddenStatic = value;
			}
		}

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x0600254B RID: 9547 RVA: 0x00246E50 File Offset: 0x00245050
		// (set) Token: 0x0600254C RID: 9548 RVA: 0x00246F04 File Offset: 0x00245104
		internal bool SecKmfProfileSecureProfileGUID_43662_HiddenDynamic
		{
			get
			{
				short num = (short)320294875;
				short num2 = num;
				num = (short)1075597275;
				switch (num2 == num)
				{
				default:
				{
					num = (short)263585792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2092761089;
				if (num != 0)
				{
				}
				num = (short)1189019648;
				if (num != 0)
				{
				}
				return this.secKmfProfileSecureProfileGUID_43662.HiddenDynamic;
			}
			set
			{
				short num = (short)2044617799;
				short num2 = num;
				num = (short)1317364807;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1376387072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)471662592;
				if (num != 0)
				{
				}
				num = (short)183238657;
				if (num != 0)
				{
				}
				this.secKmfProfileSecureProfileGUID_43662.HiddenDynamic = value;
			}
		}

		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x0600254D RID: 9549 RVA: 0x00246FB8 File Offset: 0x002451B8
		public bool SecKmfProfileSecureProfileGUID_43662_HasDiffs
		{
			get
			{
				short num = (short)1871853665;
				short num2 = num;
				num = (short)2126264417;
				switch (num2 == num)
				{
				default:
				{
					num = (short)751763456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)892076033;
				if (num != 0)
				{
				}
				num = (short)55115776;
				if (num != 0)
				{
				}
				return this.secKmfProfileSecureProfileGUID_43662._HasDiffs;
			}
		}

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x0600254E RID: 9550 RVA: 0x00247070 File Offset: 0x00245270
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide RefSecureWide
		{
			get
			{
				short num = (short)1035859085;
				short num2 = num;
				num = (short)919401613;
				switch (num2 == num)
				{
				default:
				{
					num = (short)514850816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1681850369;
				if (num != 0)
				{
				}
				num = (short)1249181696;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			}
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x00247130 File Offset: 0x00245330
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_75;
				}
				short num;
				for (;;)
				{
					IL_0A:
					num = (short)451543040;
					short num2 = num;
					num = (short)589234177;
					if (num != 0)
					{
					}
					int num3;
					switch (num3)
					{
					case 0:
						num = (short)157024258;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (base.ParentRecset != null)
						{
							num = (short)1344405504;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)1779761155;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 3:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)474218500;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return result;
					}
					break;
				}
				IL_75:
				num = (short)480155164;
				short num4 = num;
				num = (short)58299932;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)854523904;
					if (num != 0)
					{
					}
					result = null;
					num = (short)1979973633;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_0A;
				}
				}
			}
			return result;
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x002472A8 File Offset: 0x002454A8
		private void b(global::System.Runtime.Serialization.SerializationInfo A_0, global::System.Runtime.Serialization.StreamingContext A_1)
		{
			short num = (short)1387584721;
			short num2 = num;
			num = (short)841866449;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1148452864;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1750401025;
			if (num != 0)
			{
			}
			num = (short)1148256256;
			if (num != 0)
			{
			}
			this.a(A_0, A_1);
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x00247360 File Offset: 0x00245560
		private void c()
		{
			short num = (short)661681888;
			short num2 = num;
			num = (short)1434482400;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1767374848;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)873988097;
			if (num != 0)
			{
			}
			num = (short)1556938752;
			if (num != 0)
			{
			}
			this.b();
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x0024740C File Offset: 0x0024560C
		private void b()
		{
			short num = (short)776722016;
			short num2 = num;
			num = (short)283104864;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1281490944;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)199491584;
			if (num != 0)
			{
			}
			num = (short)718864385;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x002474BC File Offset: 0x002456BC
		private void a()
		{
			short num = (short)7077889;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)543555584;
				short num3 = num;
				switch (num2)
				{
				case 0:
				{
					this.SecKmfProfileSecureProfileGUID_43662.Value = global::AllFeatures.CodeplugGuid.NewGuid();
					num = (short)555114916;
					short num4 = num;
					num = (short)1941987748;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F6;
					default:
						num = (short)194445312;
						if (num != 0)
						{
						}
						num = (short)1722220546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 2:
					goto IL_F4;
				}
				IL_58:
				if (!string.IsNullOrEmpty(this.SecKmfProfileSecureProfileGUID_43662.Value))
				{
					break;
				}
				num = (short)183566336;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F4:
			IL_F6:
			num = (short)887619585;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x002475E8 File Offset: 0x002457E8
		private void a(global::System.Runtime.Serialization.SerializationInfo A_0, global::System.Runtime.Serialization.StreamingContext A_1)
		{
			short num = (short)31992475;
			short num2 = num;
			num = (short)99035803;
			switch (num2 == num)
			{
			}
			num = (short)511770624;
			short num3 = num;
			num = (short)72155137;
			if (num != 0)
			{
			}
			num = (short)1091043328;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x04000D5C RID: 3420
		private global::AcpBusinessLayer.AcpField<bool> secKmfProfGenIndependentKeyList_43597;

		// Token: 0x04000D5D RID: 3421
		private global::AcpBusinessLayer.AcpField<bool> secKmfProfKeyListMgmtEraseAllKeys_43650;

		// Token: 0x04000D5E RID: 3422
		private global::AcpBusinessLayer.AcpField<bool> secKmfProfileInfiniteUKEKRetention_43651;

		// Token: 0x04000D5F RID: 3423
		private global::AcpBusinessLayer.AcpField<bool> secKmfProfOTARGenerateKeyLossKey_43652;

		// Token: 0x04000D60 RID: 3424
		private global::AcpBusinessLayer.AcpField<bool> secKmfProfKVLFIPSLevel3ApprovedMode_43653;

		// Token: 0x04000D61 RID: 3425
		private global::AcpBusinessLayer.AcpField<bool> secKmfProfUserSelectable_43657;

		// Token: 0x04000D62 RID: 3426
		private global::AcpBusinessLayer.AcpField<bool> secKmfProfErasePreviousOnUserChange_43658;

		// Token: 0x04000D63 RID: 3427
		private global::AcpBusinessLayer.AcpFieldX<string, string> secKmfProfileSecureProfileGUID_43662;
	}
}
