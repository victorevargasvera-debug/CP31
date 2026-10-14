using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;

namespace Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList
{
	// Token: 0x020005E3 RID: 1507
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600CF52 RID: 53074 RVA: 0x00C0FDA0 File Offset: 0x00C0DFA0
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600CF53 RID: 53075 RVA: 0x00C0FDBC File Offset: 0x00C0DFBC
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600CF54 RID: 53076 RVA: 0x00C0FDD4 File Offset: 0x00C0DFD4
		public override void Init()
		{
			int a_ = 1;
			short num = (short)1853324498;
			short num2 = num;
			num = (short)177437906;
			switch (num2 == num)
			{
			}
			num = (short)774766593;
			if (num != 0)
			{
			}
			num = (short)927399936;
			short num3 = num;
			num = (short)1033175040;
			if (num != 0)
			{
			}
			this.astTlkgrpLstGeneralKMFProfileIndex_A8380 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("菁럃닅鳇ꛉꟋ꧍ꋏꋑ飓ꗕ곗鷙맛냝藟郡藣諥ꏧ꟩ꫫ뻭苯鷱鋳鿵铷鿹뗻都擿朁簃夅䤇㈉㼋㘍‏", a_), global::CommonResources.AcgResources.ID_ASTROOTARPROFILEINDEX, new string[]
			{
				global::CommonResources.AcgResources.ID_DISABLED
			}, new int[1], true, false, new string[]
			{
				global::CommonResources.AcgResources.ID_KMFPROFILEINDEX
			});
			this.astTlkgrpLstGeneralKMFProfileIndex_A8380.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.astTlkgrpLstGeneralKMFProfileIndex_A8380.DataTransferOrder = 8;
			this.astTlkgrpLstGeneralKMFProfileIndex_A8380.EvaluateRecRefs = true;
			this.astTlkgrpLstGeneralTalkgroupAlias_A9277 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("菁럃닅鳇ꛉꟋ꧍ꋏꋑ飓ꗕ곗鷙맛냝藟郡藣諥볧诩胫藭韯胱鯳菵裷믹郻韽懿焁嬃䜅ㄇ㠉㬋㤍", a_), global::CommonResources.AcgResources.ID_TALKGROUPALIAS);
			this.astTlkgrpLstGeneralTalkgroupAlias_A9277.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.astTlkgrpLstGeneralTalkgroupAlias_A9277.DataTransferOrder = 2;
			this.astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("菁럃닅鳇ꛉꟋ꧍ꋏꋑ飓ꗕ곗鷙맛냝藟郡藣諥ꏧ迩闫臭雯돱ꟳꋵ꫷뗹ꣻ鿽泿椁挃琅朇缉簋䈍礏愑怓䤕夗⬙⸛⠝ᘟᜡ", a_), global::CommonResources.AcgResources.ID_ASTROTALKGROUPLISTNAME, 14);
			this.astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665.DataTransferOrder = 5;
			this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("菁럃닅鳇ꛉꟋ꧍ꋏꋑ飓ꗕ곗鷙맛냝藟郡藣諥ꧧ맩룫볭뿯꛱闳髵鏷鷹軻釽痿爁䠃朅笇縉夋納甏怑崓砕簗缙搛䄝感ጡᴣᄥဧᨩ", a_), global::CommonResources.AcgResources.ID_ASTROTALKGROUPLASTUSERINDEX, 0, 65535, null, null, 0, 1);
			this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.DataTransferOrder = -1;
			this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("藁ꇃꣅ귇룉귋ꋍ", a_);
			base.Id = 10151;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600CF55 RID: 53077 RVA: 0x00C0FFDC File Offset: 0x00C0E1DC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)1722548229;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)43581448;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裈룊만鯎뷐룒닔ꗖ꧘韚껜ꯞꛠ蛢诤苦鯨諪臬믮郰鿲黴郶诸铺裼迾䀀漂氄昆稈吊䰌㘎⌐␒∔", a_)))
					{
						num = (short)252248070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_238;
				case 2:
					goto IL_359;
				case 3:
				{
					this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("裈룊만鯎뷐룒닔ꗖ꧘韚껜ꯞꛠ蛢诤苦鯨諪臬껮ꋰꟲꟴ룶그髺釼链昀焂樄爆礈䜊氌簎攐䘒昔爖欘刚猜笞䐠嬢稤昦ᠨሪᨬᜮİ", a_), global::CommonResources.AcgResources.ID_ASTROTALKGROUPLASTUSERINDEX, null, null, 0, 1);
					this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.DataTransferOrder = -1;
					this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.ShowHexValue = false;
					num = (short)719126528;
					short num3 = num;
					num = (short)239992834;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_35E;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 6:
					this.astTlkgrpLstGeneralTalkgroupAlias_A9277 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("裈룊만鯎뷐룒닔ꗖ꧘韚껜ꯞꛠ蛢诤苦鯨諪臬믮郰鿲黴郶诸铺裼迾䀀漂氄昆稈吊䰌㘎⌐␒∔", a_), global::CommonResources.AcgResources.ID_TALKGROUPALIAS);
					this.astTlkgrpLstGeneralTalkgroupAlias_A9277.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.astTlkgrpLstGeneralTalkgroupAlias_A9277.DataTransferOrder = 2;
					num = (short)1251147786;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裈룊만鯎뷐룒닔ꗖ꧘韚껜ꯞꛠ蛢诤苦鯨諪臬껮ꋰꟲꟴ룶그髺釼链昀焂樄爆礈䜊氌簎攐䘒昔爖欘刚猜笞䐠嬢稤昦ᠨሪᨬᜮİ", a_)))
					{
						num = (short)568066051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_430;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裈룊만鯎뷐룒닔ꗖ꧘韚껜ꯞꛠ蛢诤苦鯨諪臬ꓮ볰뗲ꗴ藶雸鷺铼鏾搀䨂欄挆氈猊刌与⤐‒ⴔ✖", a_)))
					{
						num = (short)1584922633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_35E;
				case 9:
					this.astTlkgrpLstGeneralKMFProfileIndex_A8380 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("裈룊만鯎뷐룒닔ꗖ꧘韚껜ꯞꛠ蛢诤苦鯨諪臬ꓮ볰뗲ꗴ藶雸鷺铼鏾搀䨂欄挆氈猊刌与⤐‒ⴔ✖", a_), global::CommonResources.AcgResources.ID_ASTROOTARPROFILEINDEX, new string[]
					{
						global::CommonResources.AcgResources.ID_DISABLED
					}, new int[1], true, false, new string[]
					{
						global::CommonResources.AcgResources.ID_KMFPROFILEINDEX
					});
					this.astTlkgrpLstGeneralKMFProfileIndex_A8380.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.astTlkgrpLstGeneralKMFProfileIndex_A8380.DataTransferOrder = 8;
					this.astTlkgrpLstGeneralKMFProfileIndex_A8380.EvaluateRecRefs = true;
					num = (short)1446772740;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_238;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裈룊만鯎뷐룒닔ꗖ꧘韚껜ꯞꛠ蛢诤苦鯨諪臬ꓮ铰諲髴釶룸꣺ꧼ귾一圂搄欆戈氊缌怎搐挒夔縖樘漚䈜帞ဠᄢጤᄦᰨ", a_)))
					{
						num = (short)264765453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AF;
				case 12:
					if (producerFields != null)
					{
						num = (short)403767296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_430;
				case 13:
					goto IL_B9;
				case 14:
					goto IL_1AF;
				case 15:
					num = (short)434700289;
					if (num != 0)
					{
					}
					num = (short)426573836;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6D:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1536819215;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_B9:
				this.astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("裈룊만鯎뷐룒닔ꗖ꧘韚껜ꯞꛠ蛢诤苦鯨諪臬ꓮ铰諲髴釶룸꣺ꧼ귾一圂搄欆戈氊缌怎搐挒夔縖樘漚䈜帞ဠᄢጤᄦᰨ", a_), global::CommonResources.AcgResources.ID_ASTROTALKGROUPLISTNAME, 14);
				this.astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
				this.astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665.DataTransferOrder = 5;
				num = (short)249757710;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_238:
				num = (short)2001546646;
				short num4 = num;
				num = (short)1550527894;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B9;
				default:
					num = (short)1787691008;
					if (num != 0)
					{
					}
					num = (short)1959854091;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1AF:
				num = (short)296943623;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_35E:
				num = (short)378732545;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_359:
			IL_430:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軈껊ꏌ꫎ꏐ닒맔", a_);
			base.Id = 10151;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600CF56 RID: 53078 RVA: 0x00C1044C File Offset: 0x00C0E64C
		public override void PopulateReferences()
		{
			short num = (short)1491075073;
			if (num != 0)
			{
			}
			num = (short)883689959;
			short num2 = num;
			num = (short)1362430439;
			switch (num2 == num)
			{
			}
			num = (short)1774256128;
			short num3 = num;
			num = (short)2034892800;
			if (num != 0)
			{
			}
			this.astTlkgrpLstGeneralKMFProfileIndex_A8380.SetRecset(this.a(2055));
		}

		// Token: 0x0600CF57 RID: 53079 RVA: 0x00C10510 File Offset: 0x00C0E710
		public override void DropReferences()
		{
			short num = (short)1652139370;
			short num2 = num;
			num = (short)433694058;
			switch (num2 == num)
			{
			}
			num = (short)943587329;
			if (num != 0)
			{
			}
			num = (short)951582720;
			short num3 = num;
			num = (short)1763442688;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600CF58 RID: 53080 RVA: 0x00C105BC File Offset: 0x00C0E7BC
		public override void SetConstraints()
		{
			short num = (short)621140477;
			short num2 = num;
			num = (short)1255332349;
			switch (num2 == num)
			{
			}
			num = (short)876150785;
			if (num != 0)
			{
			}
			num = (short)2097872896;
			short num3 = num;
			num = (short)634257408;
			if (num != 0)
			{
			}
			this.astTlkgrpLstGeneralKMFProfileIndex_A8380.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListConstraints.ConSecKmfProfileEnAstroOtarOtarEmcEqpdExtIsEnableAndCfgSecTypeIsHW);
		}

		// Token: 0x0600CF59 RID: 53081 RVA: 0x00C1067C File Offset: 0x00C0E87C
		public override void SetupDependencies()
		{
			short num = (short)471901588;
			short num2 = num;
			num = (short)1421190548;
			switch (num2 == num)
			{
			}
			num = (short)520880128;
			if (num != 0)
			{
			}
			num = (short)2067202048;
			short num3 = num;
			num = (short)2062680065;
			if (num != 0)
			{
			}
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.astTlkgrpLstGeneralKMFProfileIndex_A8380);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.astTlkgrpLstGeneralKMFProfileIndex_A8380);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.astTlkgrpLstGeneralKMFProfileIndex_A8380);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.astTlkgrpLstGeneralKMFProfileIndex_A8380);
		}

		// Token: 0x17006823 RID: 26659
		// (get) Token: 0x0600CF5A RID: 53082 RVA: 0x00C10794 File Offset: 0x00C0E994
		public global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile SecureKMFProfileForAstTlkgrpLstGeneralKMFProfileIndex_A8380
		{
			get
			{
				short num = (short)672739958;
				short num2 = num;
				num = (short)150876790;
				switch (num2 == num)
				{
				}
				num = (short)893321217;
				if (num != 0)
				{
				}
				num = (short)1586954240;
				short num3 = num;
				num = (short)1996423168;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralKMFProfileIndex_A8380.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
			}
		}

		// Token: 0x17006824 RID: 26660
		// (get) Token: 0x0600CF5B RID: 53083 RVA: 0x00C10850 File Offset: 0x00C0EA50
		public bool HasDiffs
		{
			get
			{
				short num = (short)892903612;
				short num2 = num;
				num = (short)89235644;
				switch (num2 == num)
				{
				}
				num = (short)1806237697;
				if (num != 0)
				{
				}
				num = (short)1010761728;
				short num3 = num;
				num = (short)1124663296;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17006825 RID: 26661
		// (get) Token: 0x0600CF5C RID: 53084 RVA: 0x00C10904 File Offset: 0x00C0EB04
		// (set) Token: 0x0600CF5D RID: 53085 RVA: 0x00C109BC File Offset: 0x00C0EBBC
		public int AstTlkgrpLstGeneralKMFProfileIndex_A8380Value
		{
			get
			{
				short num = (short)1691389731;
				short num2 = num;
				num = (short)99061539;
				switch (num2 == num)
				{
				}
				num = (short)421789697;
				if (num != 0)
				{
				}
				num = (short)849281024;
				short num3 = num;
				num = (short)1882456064;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralKMFProfileIndex_A8380.Value;
			}
			set
			{
				short num = (short)755761153;
				if (num != 0)
				{
				}
				num = (short)1226335773;
				short num2 = num;
				num = (short)276325917;
				switch (num2 == num)
				{
				}
				num = (short)2041708544;
				short num3 = num;
				num = (short)2005860352;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralKMFProfileIndex_A8380.Value = value;
			}
		}

		// Token: 0x17006826 RID: 26662
		// (get) Token: 0x0600CF5E RID: 53086 RVA: 0x00C10A74 File Offset: 0x00C0EC74
		// (set) Token: 0x0600CF5F RID: 53087 RVA: 0x00C10B28 File Offset: 0x00C0ED28
		public string AstTlkgrpLstGeneralKMFProfileIndex_A8380_UIValue
		{
			get
			{
				short num = (short)481660597;
				short num2 = num;
				num = (short)1677954741;
				switch (num2 == num)
				{
				}
				num = (short)59703296;
				if (num != 0)
				{
				}
				num = (short)1684668416;
				short num3 = num;
				num = (short)374407169;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralKMFProfileIndex_A8380.UIValue;
			}
			set
			{
				short num = (short)190775297;
				if (num != 0)
				{
				}
				num = (short)1588507225;
				short num2 = num;
				num = (short)1617277529;
				switch (num2 == num)
				{
				}
				num = (short)171704320;
				short num3 = num;
				num = (short)1145307136;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralKMFProfileIndex_A8380.UIValue = value;
			}
		}

		// Token: 0x17006827 RID: 26663
		// (get) Token: 0x0600CF60 RID: 53088 RVA: 0x00C10BDC File Offset: 0x00C0EDDC
		public global::AcpBusinessLayer.AcpRecRefField AstTlkgrpLstGeneralKMFProfileIndex_A8380
		{
			get
			{
				short num = (short)1796603905;
				if (num != 0)
				{
				}
				num = (short)893728340;
				short num2 = num;
				num = (short)896939604;
				switch (num2 == num)
				{
				}
				num = (short)1868103680;
				short num3 = num;
				num = (short)648740864;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralKMFProfileIndex_A8380;
			}
		}

		// Token: 0x17006828 RID: 26664
		// (get) Token: 0x0600CF61 RID: 53089 RVA: 0x00C10C8C File Offset: 0x00C0EE8C
		// (set) Token: 0x0600CF62 RID: 53090 RVA: 0x00C10D40 File Offset: 0x00C0EF40
		public bool AstTlkgrpLstGeneralKMFProfileIndex_A8380_Applicable
		{
			get
			{
				short num = (short)881673771;
				short num2 = num;
				num = (short)1290290731;
				switch (num2 == num)
				{
				}
				num = (short)214171649;
				if (num != 0)
				{
				}
				num = (short)1482227712;
				short num3 = num;
				num = (short)318963712;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralKMFProfileIndex_A8380.Applicable;
			}
			set
			{
				short num = (short)724105013;
				short num2 = num;
				num = (short)66123573;
				switch (num2 == num)
				{
				}
				num = (short)611057665;
				if (num != 0)
				{
				}
				num = (short)528285696;
				short num3 = num;
				num = (short)1523056640;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralKMFProfileIndex_A8380.Applicable = value;
			}
		}

		// Token: 0x17006829 RID: 26665
		// (get) Token: 0x0600CF63 RID: 53091 RVA: 0x00C10DF4 File Offset: 0x00C0EFF4
		// (set) Token: 0x0600CF64 RID: 53092 RVA: 0x00C10EA8 File Offset: 0x00C0F0A8
		public bool AstTlkgrpLstGeneralKMFProfileIndex_A8380_Valid
		{
			get
			{
				short num = (short)1845959552;
				short num2 = num;
				num = (short)182000512;
				switch (num2 == num)
				{
				}
				num = (short)603455488;
				if (num != 0)
				{
				}
				num = (short)1022689280;
				short num3 = num;
				num = (short)967835649;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralKMFProfileIndex_A8380.Valid;
			}
			set
			{
				short num = (short)604438529;
				if (num != 0)
				{
				}
				num = (short)1102616898;
				short num2 = num;
				num = (short)1755158850;
				switch (num2 == num)
				{
				}
				num = (short)182452224;
				short num3 = num;
				num = (short)1020985344;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralKMFProfileIndex_A8380.Valid = value;
			}
		}

		// Token: 0x1700682A RID: 26666
		// (get) Token: 0x0600CF65 RID: 53093 RVA: 0x00C10F60 File Offset: 0x00C0F160
		// (set) Token: 0x0600CF66 RID: 53094 RVA: 0x00C11014 File Offset: 0x00C0F214
		public bool AstTlkgrpLstGeneralKMFProfileIndex_A8380_Visible
		{
			get
			{
				short num = (short)1472330478;
				short num2 = num;
				num = (short)934017774;
				switch (num2 == num)
				{
				}
				num = (short)1554907137;
				if (num != 0)
				{
				}
				num = (short)1595277312;
				short num3 = num;
				num = (short)722796544;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralKMFProfileIndex_A8380.Visible;
			}
			set
			{
				short num = (short)599259124;
				short num2 = num;
				num = (short)1057945588;
				switch (num2 == num)
				{
				}
				num = (short)1339228160;
				if (num != 0)
				{
				}
				num = (short)212992000;
				short num3 = num;
				num = (short)1272053761;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralKMFProfileIndex_A8380.Visible = value;
			}
		}

		// Token: 0x1700682B RID: 26667
		// (get) Token: 0x0600CF67 RID: 53095 RVA: 0x00C110CC File Offset: 0x00C0F2CC
		// (set) Token: 0x0600CF68 RID: 53096 RVA: 0x00C11184 File Offset: 0x00C0F384
		public bool AstTlkgrpLstGeneralKMFProfileIndex_A8380_Editable
		{
			get
			{
				short num = (short)363216031;
				short num2 = num;
				num = (short)70597791;
				switch (num2 == num)
				{
				}
				num = (short)1827340288;
				if (num != 0)
				{
				}
				num = (short)148373504;
				short num3 = num;
				num = (short)806813697;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralKMFProfileIndex_A8380.Editable;
			}
			set
			{
				short num = (short)1756345414;
				short num2 = num;
				num = (short)553301062;
				switch (num2 == num)
				{
				}
				num = (short)743440385;
				if (num != 0)
				{
				}
				num = (short)1224867840;
				short num3 = num;
				num = (short)1143799808;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralKMFProfileIndex_A8380.Editable = value;
			}
		}

		// Token: 0x1700682C RID: 26668
		// (get) Token: 0x0600CF69 RID: 53097 RVA: 0x00C11238 File Offset: 0x00C0F438
		internal string AstTlkgrpLstGeneralKMFProfileIndex_A8380_UILabel
		{
			get
			{
				short num = (short)649450573;
				short num2 = num;
				num = (short)590730317;
				switch (num2 == num)
				{
				}
				num = (short)25559041;
				if (num != 0)
				{
				}
				num = (short)617807872;
				short num3 = num;
				num = (short)1604648960;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralKMFProfileIndex_A8380.UIName;
			}
		}

		// Token: 0x1700682D RID: 26669
		// (get) Token: 0x0600CF6A RID: 53098 RVA: 0x00C112EC File Offset: 0x00C0F4EC
		// (set) Token: 0x0600CF6B RID: 53099 RVA: 0x00C113A0 File Offset: 0x00C0F5A0
		internal bool AstTlkgrpLstGeneralKMFProfileIndex_A8380_HiddenStatic
		{
			get
			{
				short num = (short)1225985110;
				short num2 = num;
				num = (short)1001720918;
				switch (num2 == num)
				{
				}
				num = (short)433913857;
				if (num != 0)
				{
				}
				num = (short)1981415424;
				short num3 = num;
				num = (short)2058944512;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralKMFProfileIndex_A8380.HiddenStatic;
			}
			set
			{
				short num = (short)463784127;
				short num2 = num;
				num = (short)1094371519;
				switch (num2 == num)
				{
				}
				num = (short)60948480;
				if (num != 0)
				{
				}
				num = (short)120782848;
				short num3 = num;
				num = (short)1476395009;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralKMFProfileIndex_A8380.HiddenStatic = value;
			}
		}

		// Token: 0x1700682E RID: 26670
		// (get) Token: 0x0600CF6C RID: 53100 RVA: 0x00C11454 File Offset: 0x00C0F654
		// (set) Token: 0x0600CF6D RID: 53101 RVA: 0x00C11508 File Offset: 0x00C0F708
		internal bool AstTlkgrpLstGeneralKMFProfileIndex_A8380_HiddenDynamic
		{
			get
			{
				short num = (short)306560624;
				short num2 = num;
				num = (short)1569963632;
				switch (num2 == num)
				{
				}
				num = (short)395902977;
				if (num != 0)
				{
				}
				num = (short)1286537216;
				short num3 = num;
				num = (short)750845952;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralKMFProfileIndex_A8380.HiddenDynamic;
			}
			set
			{
				short num = (short)2000304054;
				short num2 = num;
				num = (short)1702574006;
				switch (num2 == num)
				{
				}
				num = (short)413597696;
				if (num != 0)
				{
				}
				num = (short)890109952;
				short num3 = num;
				num = (short)511377409;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralKMFProfileIndex_A8380.HiddenDynamic = value;
			}
		}

		// Token: 0x1700682F RID: 26671
		// (get) Token: 0x0600CF6E RID: 53102 RVA: 0x00C115BC File Offset: 0x00C0F7BC
		public bool AstTlkgrpLstGeneralKMFProfileIndex_A8380_HasDiffs
		{
			get
			{
				short num = (short)1926746979;
				short num2 = num;
				num = (short)1533006691;
				switch (num2 == num)
				{
				}
				num = (short)281018369;
				if (num != 0)
				{
				}
				num = (short)860094464;
				short num3 = num;
				num = (short)1272446976;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralKMFProfileIndex_A8380._HasDiffs;
			}
		}

		// Token: 0x17006830 RID: 26672
		// (get) Token: 0x0600CF6F RID: 53103 RVA: 0x00C11670 File Offset: 0x00C0F870
		// (set) Token: 0x0600CF70 RID: 53104 RVA: 0x00C11724 File Offset: 0x00C0F924
		public bool AstTlkgrpLstGeneralTalkgroupAlias_A9277Value
		{
			get
			{
				short num = (short)2140596684;
				short num2 = num;
				num = (short)463006156;
				switch (num2 == num)
				{
				}
				num = (short)1438449665;
				if (num != 0)
				{
				}
				num = (short)1196425216;
				short num3 = num;
				num = (short)1086586880;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralTalkgroupAlias_A9277.Value;
			}
			set
			{
				short num = (short)69855395;
				short num2 = num;
				num = (short)1539500195;
				switch (num2 == num)
				{
				}
				num = (short)2143158273;
				if (num != 0)
				{
				}
				num = (short)701431808;
				short num3 = num;
				num = (short)964493312;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralTalkgroupAlias_A9277.Value = value;
			}
		}

		// Token: 0x17006831 RID: 26673
		// (get) Token: 0x0600CF71 RID: 53105 RVA: 0x00C117D8 File Offset: 0x00C0F9D8
		public global::AcpBusinessLayer.AcpField<bool> AstTlkgrpLstGeneralTalkgroupAlias_A9277
		{
			get
			{
				short num = (short)44505888;
				short num2 = num;
				num = (short)1776491296;
				switch (num2 == num)
				{
				}
				num = (short)390856705;
				if (num != 0)
				{
				}
				num = (short)1642463232;
				short num3 = num;
				num = (short)1511915520;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralTalkgroupAlias_A9277;
			}
		}

		// Token: 0x17006832 RID: 26674
		// (get) Token: 0x0600CF72 RID: 53106 RVA: 0x00C11888 File Offset: 0x00C0FA88
		// (set) Token: 0x0600CF73 RID: 53107 RVA: 0x00C11938 File Offset: 0x00C0FB38
		public bool AstTlkgrpLstGeneralTalkgroupAlias_A9277_UIValue
		{
			get
			{
				short num = (short)1765605377;
				if (num != 0)
				{
				}
				num = (short)875657159;
				short num2 = num;
				num = (short)2106292167;
				switch (num2 == num)
				{
				}
				num = (short)346619904;
				short num3 = num;
				num = (short)1947205632;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralTalkgroupAlias_A9277.Value;
			}
			set
			{
				short num = (short)889735610;
				short num2 = num;
				num = (short)859654586;
				switch (num2 == num)
				{
				}
				num = (short)646119425;
				if (num != 0)
				{
				}
				num = (short)1091436544;
				short num3 = num;
				num = (short)760807424;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralTalkgroupAlias_A9277.Value = value;
			}
		}

		// Token: 0x17006833 RID: 26675
		// (get) Token: 0x0600CF74 RID: 53108 RVA: 0x00C119EC File Offset: 0x00C0FBEC
		// (set) Token: 0x0600CF75 RID: 53109 RVA: 0x00C11AA0 File Offset: 0x00C0FCA0
		public bool AstTlkgrpLstGeneralTalkgroupAlias_A9277_Applicable
		{
			get
			{
				short num = (short)1024159666;
				short num2 = num;
				num = (short)2001629106;
				switch (num2 == num)
				{
				}
				num = (short)36110337;
				if (num != 0)
				{
				}
				num = (short)1421606912;
				short num3 = num;
				num = (short)390266880;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralTalkgroupAlias_A9277.Applicable;
			}
			set
			{
				short num = (short)2133557636;
				short num2 = num;
				num = (short)1126662532;
				switch (num2 == num)
				{
				}
				num = (short)1892679681;
				if (num != 0)
				{
				}
				num = (short)797048832;
				short num3 = num;
				num = (short)1492975616;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralTalkgroupAlias_A9277.Applicable = value;
			}
		}

		// Token: 0x17006834 RID: 26676
		// (get) Token: 0x0600CF76 RID: 53110 RVA: 0x00C11B58 File Offset: 0x00C0FD58
		// (set) Token: 0x0600CF77 RID: 53111 RVA: 0x00C11C10 File Offset: 0x00C0FE10
		public bool AstTlkgrpLstGeneralTalkgroupAlias_A9277_Valid
		{
			get
			{
				short num = (short)1908434714;
				short num2 = num;
				num = (short)270296858;
				switch (num2 == num)
				{
				}
				num = (short)1517682689;
				if (num != 0)
				{
				}
				num = (short)1011286016;
				short num3 = num;
				num = (short)1409286144;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralTalkgroupAlias_A9277.Valid;
			}
			set
			{
				short num = (short)872284157;
				short num2 = num;
				num = (short)335675389;
				switch (num2 == num)
				{
				}
				num = (short)756482049;
				if (num != 0)
				{
				}
				num = (short)1198325760;
				short num3 = num;
				num = (short)533069824;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralTalkgroupAlias_A9277.Valid = value;
			}
		}

		// Token: 0x17006835 RID: 26677
		// (get) Token: 0x0600CF78 RID: 53112 RVA: 0x00C11CC4 File Offset: 0x00C0FEC4
		// (set) Token: 0x0600CF79 RID: 53113 RVA: 0x00C11D78 File Offset: 0x00C0FF78
		public bool AstTlkgrpLstGeneralTalkgroupAlias_A9277_Visible
		{
			get
			{
				short num = (short)1741467494;
				short num2 = num;
				num = (short)1983819622;
				switch (num2 == num)
				{
				}
				num = (short)739115009;
				if (num != 0)
				{
				}
				num = (short)680067072;
				short num3 = num;
				num = (short)1800077312;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralTalkgroupAlias_A9277.Visible;
			}
			set
			{
				short num = (short)127378833;
				short num2 = num;
				num = (short)770352529;
				switch (num2 == num)
				{
				}
				num = (short)540278785;
				if (num != 0)
				{
				}
				num = (short)1594163200;
				short num3 = num;
				num = (short)813105152;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralTalkgroupAlias_A9277.Visible = value;
			}
		}

		// Token: 0x17006836 RID: 26678
		// (get) Token: 0x0600CF7A RID: 53114 RVA: 0x00C11E30 File Offset: 0x00C10030
		// (set) Token: 0x0600CF7B RID: 53115 RVA: 0x00C11EE8 File Offset: 0x00C100E8
		public bool AstTlkgrpLstGeneralTalkgroupAlias_A9277_Editable
		{
			get
			{
				short num = (short)769480400;
				short num2 = num;
				num = (short)482170576;
				switch (num2 == num)
				{
				}
				num = (short)1812594689;
				if (num != 0)
				{
				}
				num = (short)518324224;
				short num3 = num;
				num = (short)2057502720;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralTalkgroupAlias_A9277.Editable;
			}
			set
			{
				short num = (short)105775105;
				if (num != 0)
				{
				}
				num = (short)256081956;
				short num2 = num;
				num = (short)365723684;
				switch (num2 == num)
				{
				}
				num = (short)183631872;
				short num3 = num;
				num = (short)1554841600;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralTalkgroupAlias_A9277.Editable = value;
			}
		}

		// Token: 0x17006837 RID: 26679
		// (get) Token: 0x0600CF7C RID: 53116 RVA: 0x00C11F9C File Offset: 0x00C1019C
		internal string AstTlkgrpLstGeneralTalkgroupAlias_A9277_UILabel
		{
			get
			{
				short num = (short)580512412;
				short num2 = num;
				num = (short)1253108380;
				switch (num2 == num)
				{
				}
				num = (short)137363457;
				if (num != 0)
				{
				}
				num = (short)1924202496;
				short num3 = num;
				num = (short)1125187584;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralTalkgroupAlias_A9277.UIName;
			}
		}

		// Token: 0x17006838 RID: 26680
		// (get) Token: 0x0600CF7D RID: 53117 RVA: 0x00C1204C File Offset: 0x00C1024C
		// (set) Token: 0x0600CF7E RID: 53118 RVA: 0x00C12100 File Offset: 0x00C10300
		internal bool AstTlkgrpLstGeneralTalkgroupAlias_A9277_HiddenStatic
		{
			get
			{
				short num = (short)940590019;
				short num2 = num;
				num = (short)2117551043;
				switch (num2 == num)
				{
				}
				num = (short)1697972225;
				if (num != 0)
				{
				}
				num = (short)1876099072;
				short num3 = num;
				num = (short)697040896;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralTalkgroupAlias_A9277.HiddenStatic;
			}
			set
			{
				short num = (short)1840977074;
				short num2 = num;
				num = (short)1804539058;
				switch (num2 == num)
				{
				}
				num = (short)935264257;
				if (num != 0)
				{
				}
				num = (short)1344536576;
				short num3 = num;
				num = (short)410386432;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralTalkgroupAlias_A9277.HiddenStatic = value;
			}
		}

		// Token: 0x17006839 RID: 26681
		// (get) Token: 0x0600CF7F RID: 53119 RVA: 0x00C121B8 File Offset: 0x00C103B8
		// (set) Token: 0x0600CF80 RID: 53120 RVA: 0x00C1226C File Offset: 0x00C1046C
		internal bool AstTlkgrpLstGeneralTalkgroupAlias_A9277_HiddenDynamic
		{
			get
			{
				short num = (short)521676700;
				short num2 = num;
				num = (short)1495148444;
				switch (num2 == num)
				{
				}
				num = (short)863502336;
				if (num != 0)
				{
				}
				num = (short)1131544576;
				short num3 = num;
				num = (short)609550337;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralTalkgroupAlias_A9277.HiddenDynamic;
			}
			set
			{
				short num = (short)375730454;
				short num2 = num;
				num = (short)695611670;
				switch (num2 == num)
				{
				}
				num = (short)654180353;
				if (num != 0)
				{
				}
				num = (short)128712704;
				short num3 = num;
				num = (short)775028736;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralTalkgroupAlias_A9277.HiddenDynamic = value;
			}
		}

		// Token: 0x1700683A RID: 26682
		// (get) Token: 0x0600CF81 RID: 53121 RVA: 0x00C12320 File Offset: 0x00C10520
		public bool AstTlkgrpLstGeneralTalkgroupAlias_A9277_HasDiffs
		{
			get
			{
				short num = (short)480301481;
				short num2 = num;
				num = (short)1745801641;
				switch (num2 == num)
				{
				}
				num = (short)942276609;
				if (num != 0)
				{
				}
				num = (short)1737621504;
				short num3 = num;
				num = (short)227016704;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralTalkgroupAlias_A9277._HasDiffs;
			}
		}

		// Token: 0x1700683B RID: 26683
		// (get) Token: 0x0600CF82 RID: 53122 RVA: 0x00C123D4 File Offset: 0x00C105D4
		// (set) Token: 0x0600CF83 RID: 53123 RVA: 0x00C12484 File Offset: 0x00C10684
		public string AstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665Value
		{
			get
			{
				short num = (short)987947367;
				short num2 = num;
				num = (short)1150673255;
				switch (num2 == num)
				{
				}
				num = (short)1916993537;
				if (num != 0)
				{
				}
				num = (short)1068367872;
				short num3 = num;
				num = (short)349503488;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665.Value;
			}
			set
			{
				short num = (short)1773076481;
				if (num != 0)
				{
				}
				num = (short)63700992;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_3C;
					case 1:
						this.astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665.Value = value;
						num = (short)799277058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1000671438;
						short num3 = num;
						num = (short)566823118;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3C;
						default:
							goto IL_FC;
						}
						break;
					}
					}
					goto IL_81;
					IL_3C:
					num = (short)1317208064;
					short num4 = num;
					switch (0)
					{
					case 0:
						IL_81:
						if (string.IsNullOrEmpty(value.Trim()))
						{
							return;
						}
						num = (short)1937768449;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_FC:
				num = (short)192413696;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700683C RID: 26684
		// (get) Token: 0x0600CF84 RID: 53124 RVA: 0x00C125A4 File Offset: 0x00C107A4
		// (set) Token: 0x0600CF85 RID: 53125 RVA: 0x00C12658 File Offset: 0x00C10858
		public string AstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665_UIValue
		{
			get
			{
				short num = (short)1178858528;
				short num2 = num;
				num = (short)61731872;
				switch (num2 == num)
				{
				}
				num = (short)1588396033;
				if (num != 0)
				{
				}
				num = (short)398131200;
				short num3 = num;
				num = (short)177864704;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665.Value;
			}
			set
			{
				short num = (short)1528953592;
				short num2 = num;
				num = (short)1138752248;
				switch (num2 == num)
				{
				}
				num = (short)363921408;
				if (num != 0)
				{
				}
				num = (short)850657280;
				short num3 = num;
				num = (short)2079129601;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665.Value = value;
			}
		}

		// Token: 0x1700683D RID: 26685
		// (get) Token: 0x0600CF86 RID: 53126 RVA: 0x00C1270C File Offset: 0x00C1090C
		public global::AcpBusinessLayer.AcpKeyField AstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665
		{
			get
			{
				short num = (short)646009671;
				short num2 = num;
				num = (short)1787908935;
				switch (num2 == num)
				{
				}
				num = (short)1124401153;
				if (num != 0)
				{
				}
				num = (short)1561264128;
				short num3 = num;
				num = (short)1345191936;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665;
			}
		}

		// Token: 0x1700683E RID: 26686
		// (get) Token: 0x0600CF87 RID: 53127 RVA: 0x00C127C0 File Offset: 0x00C109C0
		// (set) Token: 0x0600CF88 RID: 53128 RVA: 0x00C12874 File Offset: 0x00C10A74
		public bool AstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665_Applicable
		{
			get
			{
				short num = (short)1814382079;
				short num2 = num;
				num = (short)1569015295;
				switch (num2 == num)
				{
				}
				num = (short)188809216;
				if (num != 0)
				{
				}
				num = (short)355270656;
				short num3 = num;
				num = (short)658964481;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665.Applicable;
			}
			set
			{
				short num = (short)1020706156;
				short num2 = num;
				num = (short)1472183660;
				switch (num2 == num)
				{
				}
				num = (short)2084372480;
				if (num != 0)
				{
				}
				num = (short)1336672256;
				short num3 = num;
				num = (short)806354945;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665.Applicable = value;
			}
		}

		// Token: 0x1700683F RID: 26687
		// (get) Token: 0x0600CF89 RID: 53129 RVA: 0x00C12928 File Offset: 0x00C10B28
		// (set) Token: 0x0600CF8A RID: 53130 RVA: 0x00C129DC File Offset: 0x00C10BDC
		public bool AstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665_Valid
		{
			get
			{
				short num = (short)1791412841;
				short num2 = num;
				num = (short)2018232937;
				switch (num2 == num)
				{
				}
				num = (short)1305542657;
				if (num != 0)
				{
				}
				num = (short)461045760;
				short num3 = num;
				num = (short)877395968;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665.Valid;
			}
			set
			{
				short num = (short)1159583861;
				short num2 = num;
				num = (short)1537726581;
				switch (num2 == num)
				{
				}
				num = (short)2119237633;
				if (num != 0)
				{
				}
				num = (short)937230336;
				short num3 = num;
				num = (short)1587019776;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665.Valid = value;
			}
		}

		// Token: 0x17006840 RID: 26688
		// (get) Token: 0x0600CF8B RID: 53131 RVA: 0x00C12A90 File Offset: 0x00C10C90
		// (set) Token: 0x0600CF8C RID: 53132 RVA: 0x00C12B48 File Offset: 0x00C10D48
		public bool AstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665_Visible
		{
			get
			{
				short num = (short)1160489092;
				short num2 = num;
				num = (short)41265284;
				switch (num2 == num)
				{
				}
				num = (short)586088449;
				if (num != 0)
				{
				}
				num = (short)1420165120;
				short num3 = num;
				num = (short)465108992;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665.Visible;
			}
			set
			{
				short num = (short)1453531456;
				short num2 = num;
				num = (short)508895552;
				switch (num2 == num)
				{
				}
				num = (short)2017525760;
				if (num != 0)
				{
				}
				num = (short)803995648;
				short num3 = num;
				num = (short)959643649;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665.Visible = value;
			}
		}

		// Token: 0x17006841 RID: 26689
		// (get) Token: 0x0600CF8D RID: 53133 RVA: 0x00C12BFC File Offset: 0x00C10DFC
		// (set) Token: 0x0600CF8E RID: 53134 RVA: 0x00C12CB0 File Offset: 0x00C10EB0
		public bool AstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665_Editable
		{
			get
			{
				short num = (short)524763432;
				short num2 = num;
				num = (short)1305952552;
				switch (num2 == num)
				{
				}
				num = (short)1432289281;
				if (num != 0)
				{
				}
				num = (short)1060241408;
				short num3 = num;
				num = (short)1553203200;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665.Editable;
			}
			set
			{
				short num = (short)1076160250;
				short num2 = num;
				num = (short)942466810;
				switch (num2 == num)
				{
				}
				num = (short)1195966465;
				if (num != 0)
				{
				}
				num = (short)2051211264;
				short num3 = num;
				num = (short)1028521984;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665.Editable = value;
			}
		}

		// Token: 0x17006842 RID: 26690
		// (get) Token: 0x0600CF8F RID: 53135 RVA: 0x00C12D68 File Offset: 0x00C10F68
		internal string AstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665_UILabel
		{
			get
			{
				short num = (short)2011996743;
				short num2 = num;
				num = (short)535208519;
				switch (num2 == num)
				{
				}
				num = (short)2134114305;
				if (num != 0)
				{
				}
				num = (short)1390411776;
				short num3 = num;
				num = (short)438894592;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665.UIName;
			}
		}

		// Token: 0x17006843 RID: 26691
		// (get) Token: 0x0600CF90 RID: 53136 RVA: 0x00C12E1C File Offset: 0x00C1101C
		// (set) Token: 0x0600CF91 RID: 53137 RVA: 0x00C12ED0 File Offset: 0x00C110D0
		internal bool AstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665_HiddenStatic
		{
			get
			{
				short num = (short)2091110961;
				short num2 = num;
				num = (short)497209905;
				switch (num2 == num)
				{
				}
				num = (short)930938881;
				if (num != 0)
				{
				}
				num = (short)333447168;
				short num3 = num;
				num = (short)28049408;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665.HiddenStatic;
			}
			set
			{
				short num = (short)1394100393;
				short num2 = num;
				num = (short)850741417;
				switch (num2 == num)
				{
				}
				num = (short)265289728;
				if (num != 0)
				{
				}
				num = (short)348913664;
				short num3 = num;
				num = (short)791805953;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665.HiddenStatic = value;
			}
		}

		// Token: 0x17006844 RID: 26692
		// (get) Token: 0x0600CF92 RID: 53138 RVA: 0x00C12F88 File Offset: 0x00C11188
		// (set) Token: 0x0600CF93 RID: 53139 RVA: 0x00C1303C File Offset: 0x00C1123C
		internal bool AstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665_HiddenDynamic
		{
			get
			{
				short num = (short)547600409;
				short num2 = num;
				num = (short)307869721;
				switch (num2 == num)
				{
				}
				num = (short)391380992;
				if (num != 0)
				{
				}
				num = (short)1347944448;
				short num3 = num;
				num = (short)1199308801;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665.HiddenDynamic;
			}
			set
			{
				short num = (short)813200387;
				short num2 = num;
				num = (short)381776899;
				switch (num2 == num)
				{
				}
				num = (short)1365377025;
				if (num != 0)
				{
				}
				num = (short)446889984;
				short num3 = num;
				num = (short)582025216;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665.HiddenDynamic = value;
			}
		}

		// Token: 0x17006845 RID: 26693
		// (get) Token: 0x0600CF94 RID: 53140 RVA: 0x00C130F0 File Offset: 0x00C112F0
		public bool AstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665_HasDiffs
		{
			get
			{
				short num = (short)322694741;
				short num2 = num;
				num = (short)774041173;
				switch (num2 == num)
				{
				}
				num = (short)1677066240;
				if (num != 0)
				{
				}
				num = (short)380698624;
				short num3 = num;
				num = (short)1633615873;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665._HasDiffs;
			}
		}

		// Token: 0x17006846 RID: 26694
		// (get) Token: 0x0600CF95 RID: 53141 RVA: 0x00C131A4 File Offset: 0x00C113A4
		// (set) Token: 0x0600CF96 RID: 53142 RVA: 0x00C1325C File Offset: 0x00C1145C
		public int AstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780Value
		{
			get
			{
				short num = (short)103761146;
				short num2 = num;
				num = (short)1158694138;
				switch (num2 == num)
				{
				}
				num = (short)1814757377;
				if (num != 0)
				{
				}
				num = (short)502661120;
				short num3 = num;
				num = (short)1208287232;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.Value;
			}
			set
			{
				short num = (short)1017856678;
				short num2 = num;
				num = (short)639713958;
				switch (num2 == num)
				{
				}
				num = (short)1311244289;
				if (num != 0)
				{
				}
				num = (short)981270528;
				short num3 = num;
				num = (short)42205184;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.Value = value;
			}
		}

		// Token: 0x17006847 RID: 26695
		// (get) Token: 0x0600CF97 RID: 53143 RVA: 0x00C13310 File Offset: 0x00C11510
		public global::AcpBusinessLayer.AcpSimpleRangeField AstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780
		{
			get
			{
				short num = (short)73249999;
				short num2 = num;
				num = (short)1301001423;
				switch (num2 == num)
				{
				}
				num = (short)1200553985;
				if (num != 0)
				{
				}
				num = (short)1795686400;
				short num3 = num;
				num = (short)464584704;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780;
			}
		}

		// Token: 0x17006848 RID: 26696
		// (get) Token: 0x0600CF98 RID: 53144 RVA: 0x00C133BC File Offset: 0x00C115BC
		// (set) Token: 0x0600CF99 RID: 53145 RVA: 0x00C13470 File Offset: 0x00C11670
		public string AstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780_UIValue
		{
			get
			{
				short num = (short)2105270032;
				short num2 = num;
				num = (short)1921965840;
				switch (num2 == num)
				{
				}
				num = (short)1191116800;
				if (num != 0)
				{
				}
				num = (short)1377501184;
				short num3 = num;
				num = (short)1555169281;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.UIValue;
			}
			set
			{
				short num = (short)1389232129;
				if (num != 0)
				{
				}
				num = (short)2054420280;
				short num2 = num;
				num = (short)1110439736;
				switch (num2 == num)
				{
				}
				num = (short)251330560;
				short num3 = num;
				num = (short)171704320;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.UIValue = value;
			}
		}

		// Token: 0x17006849 RID: 26697
		// (get) Token: 0x0600CF9A RID: 53146 RVA: 0x00C13524 File Offset: 0x00C11724
		// (set) Token: 0x0600CF9B RID: 53147 RVA: 0x00C135DC File Offset: 0x00C117DC
		internal int AstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780Min
		{
			get
			{
				short num = (short)2073586714;
				short num2 = num;
				num = (short)1438477338;
				switch (num2 == num)
				{
				}
				num = (short)1336082433;
				if (num != 0)
				{
				}
				num = (short)37486592;
				short num3 = num;
				num = (short)488505344;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.Min;
			}
			set
			{
				short num = (short)2048193457;
				short num2 = num;
				num = (short)254276529;
				switch (num2 == num)
				{
				}
				num = (short)2113601537;
				if (num != 0)
				{
				}
				num = (short)1843724288;
				short num3 = num;
				num = (short)250413056;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.Min = value;
			}
		}

		// Token: 0x1700684A RID: 26698
		// (get) Token: 0x0600CF9C RID: 53148 RVA: 0x00C13690 File Offset: 0x00C11890
		// (set) Token: 0x0600CF9D RID: 53149 RVA: 0x00C13744 File Offset: 0x00C11944
		internal int AstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780Max
		{
			get
			{
				short num = (short)72066077;
				short num2 = num;
				num = (short)2042143773;
				switch (num2 == num)
				{
				}
				num = (short)1759576065;
				if (num != 0)
				{
				}
				num = (short)1772027904;
				short num3 = num;
				num = (short)26279936;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.Max;
			}
			set
			{
				short num = (short)377321423;
				short num2 = num;
				num = (short)735344591;
				switch (num2 == num)
				{
				}
				num = (short)1236271104;
				if (num != 0)
				{
				}
				num = (short)2060845056;
				short num3 = num;
				num = (short)864288769;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.Max = value;
			}
		}

		// Token: 0x1700684B RID: 26699
		// (get) Token: 0x0600CF9E RID: 53150 RVA: 0x00C137F8 File Offset: 0x00C119F8
		// (set) Token: 0x0600CF9F RID: 53151 RVA: 0x00C138AC File Offset: 0x00C11AAC
		internal int AstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780Step
		{
			get
			{
				short num = (short)347492866;
				short num2 = num;
				num = (short)1978552834;
				switch (num2 == num)
				{
				}
				num = (short)151519233;
				if (num != 0)
				{
				}
				num = (short)1420361728;
				short num3 = num;
				num = (short)1315110912;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.StepSize;
			}
			set
			{
				short num = (short)75001987;
				short num2 = num;
				num = (short)933195907;
				switch (num2 == num)
				{
				}
				num = (short)1949630464;
				if (num != 0)
				{
				}
				num = (short)686096384;
				short num3 = num;
				num = (short)1157103617;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.StepSize = value;
			}
		}

		// Token: 0x1700684C RID: 26700
		// (get) Token: 0x0600CFA0 RID: 53152 RVA: 0x00C13964 File Offset: 0x00C11B64
		// (set) Token: 0x0600CFA1 RID: 53153 RVA: 0x00C13A14 File Offset: 0x00C11C14
		public bool AstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780_Applicable
		{
			get
			{
				short num = (short)1908539393;
				if (num != 0)
				{
				}
				num = (short)625852315;
				short num2 = num;
				num = (short)501661595;
				switch (num2 == num)
				{
				}
				num = (short)960430080;
				short num3 = num;
				num = (short)398655488;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.Applicable;
			}
			set
			{
				short num = (short)27452602;
				short num2 = num;
				num = (short)504423610;
				switch (num2 == num)
				{
				}
				num = (short)1697841153;
				if (num != 0)
				{
				}
				num = (short)539230208;
				short num3 = num;
				num = (short)743964672;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.Applicable = value;
			}
		}

		// Token: 0x1700684D RID: 26701
		// (get) Token: 0x0600CFA2 RID: 53154 RVA: 0x00C13AC8 File Offset: 0x00C11CC8
		// (set) Token: 0x0600CFA3 RID: 53155 RVA: 0x00C13B7C File Offset: 0x00C11D7C
		public bool AstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780_Valid
		{
			get
			{
				short num = (short)872454056;
				short num2 = num;
				num = (short)826513320;
				switch (num2 == num)
				{
				}
				num = (short)914292737;
				if (num != 0)
				{
				}
				num = (short)747372544;
				short num3 = num;
				num = (short)1050148864;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.Valid;
			}
			set
			{
				short num = (short)266464454;
				short num2 = num;
				num = (short)180939974;
				switch (num2 == num)
				{
				}
				num = (short)233766913;
				if (num != 0)
				{
				}
				num = (short)2097676288;
				short num3 = num;
				num = (short)263585792;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.Valid = value;
			}
		}

		// Token: 0x1700684E RID: 26702
		// (get) Token: 0x0600CFA4 RID: 53156 RVA: 0x00C13C30 File Offset: 0x00C11E30
		// (set) Token: 0x0600CFA5 RID: 53157 RVA: 0x00C13CE4 File Offset: 0x00C11EE4
		public bool AstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780_Visible
		{
			get
			{
				short num = (short)576345679;
				short num2 = num;
				num = (short)1957647951;
				switch (num2 == num)
				{
				}
				num = (short)589824001;
				if (num != 0)
				{
				}
				num = (short)1854865408;
				short num3 = num;
				num = (short)95551488;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.Visible;
			}
			set
			{
				short num = (short)409324181;
				short num2 = num;
				num = (short)1595853461;
				switch (num2 == num)
				{
				}
				num = (short)1964834817;
				if (num != 0)
				{
				}
				num = (short)1958412288;
				short num3 = num;
				num = (short)591200256;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.Visible = value;
			}
		}

		// Token: 0x1700684F RID: 26703
		// (get) Token: 0x0600CFA6 RID: 53158 RVA: 0x00C13D9C File Offset: 0x00C11F9C
		// (set) Token: 0x0600CFA7 RID: 53159 RVA: 0x00C13E50 File Offset: 0x00C12050
		public bool AstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780_Editable
		{
			get
			{
				short num = (short)843055105;
				if (num != 0)
				{
				}
				num = (short)1673393580;
				short num2 = num;
				num = (short)1010431404;
				switch (num2 == num)
				{
				}
				num = (short)610009088;
				short num3 = num;
				num = (short)631308288;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.Editable;
			}
			set
			{
				short num = (short)314305962;
				short num2 = num;
				num = (short)520351146;
				switch (num2 == num)
				{
				}
				num = (short)2007760897;
				if (num != 0)
				{
				}
				num = (short)2060058624;
				short num3 = num;
				num = (short)646316032;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.Editable = value;
			}
		}

		// Token: 0x17006850 RID: 26704
		// (get) Token: 0x0600CFA8 RID: 53160 RVA: 0x00C13F04 File Offset: 0x00C12104
		internal string AstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780_UILabel
		{
			get
			{
				short num = (short)20250625;
				if (num != 0)
				{
				}
				num = (short)788711384;
				short num2 = num;
				num = (short)40552408;
				switch (num2 == num)
				{
				}
				num = (short)38600704;
				short num3 = num;
				num = (short)572915712;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.UIName;
			}
		}

		// Token: 0x17006851 RID: 26705
		// (get) Token: 0x0600CFA9 RID: 53161 RVA: 0x00C13FB8 File Offset: 0x00C121B8
		// (set) Token: 0x0600CFAA RID: 53162 RVA: 0x00C14070 File Offset: 0x00C12270
		internal bool AstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780_HiddenStatic
		{
			get
			{
				short num = (short)196817352;
				short num2 = num;
				num = (short)1365979592;
				switch (num2 == num)
				{
				}
				num = (short)564789249;
				if (num != 0)
				{
				}
				num = (short)404094976;
				short num3 = num;
				num = (short)939720704;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.HiddenStatic;
			}
			set
			{
				short num = (short)1438944333;
				short num2 = num;
				num = (short)119966797;
				switch (num2 == num)
				{
				}
				num = (short)17629185;
				if (num != 0)
				{
				}
				num = (short)985399296;
				short num3 = num;
				num = (short)980746240;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.HiddenStatic = value;
			}
		}

		// Token: 0x17006852 RID: 26706
		// (get) Token: 0x0600CFAB RID: 53163 RVA: 0x00C14124 File Offset: 0x00C12324
		// (set) Token: 0x0600CFAC RID: 53164 RVA: 0x00C141D8 File Offset: 0x00C123D8
		internal bool AstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780_HiddenDynamic
		{
			get
			{
				short num = (short)1310785537;
				if (num != 0)
				{
				}
				num = (short)2036704585;
				short num2 = num;
				num = (short)645571913;
				switch (num2 == num)
				{
				}
				num = (short)1788084224;
				short num3 = num;
				num = (short)1868300288;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.HiddenDynamic;
			}
			set
			{
				short num = (short)1724360974;
				short num2 = num;
				num = (short)1571203342;
				switch (num2 == num)
				{
				}
				num = (short)955777025;
				if (num != 0)
				{
				}
				num = (short)1353777152;
				short num3 = num;
				num = (short)1603600384;
				if (num != 0)
				{
				}
				this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780.HiddenDynamic = value;
			}
		}

		// Token: 0x17006853 RID: 26707
		// (get) Token: 0x0600CFAD RID: 53165 RVA: 0x00C1428C File Offset: 0x00C1248C
		public bool AstTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780_HasDiffs
		{
			get
			{
				short num = (short)1381564417;
				if (num != 0)
				{
				}
				num = (short)1522908822;
				short num2 = num;
				num = (short)81444502;
				switch (num2 == num)
				{
				}
				num = (short)1568473088;
				short num3 = num;
				num = (short)1605435392;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780._HasDiffs;
			}
		}

		// Token: 0x17006854 RID: 26708
		// (get) Token: 0x0600CFAE RID: 53166 RVA: 0x00C14340 File Offset: 0x00C12540
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide RefSecureWide
		{
			get
			{
				short num = (short)30400189;
				short num2 = num;
				num = (short)1980948157;
				switch (num2 == num)
				{
				}
				num = (short)125435905;
				if (num != 0)
				{
				}
				num = (short)470220800;
				short num3 = num;
				num = (short)537919488;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			}
		}

		// Token: 0x0600CFAF RID: 53167 RVA: 0x00C14400 File Offset: 0x00C12600
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)206176260;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 1:
						num2 = (short)46202880;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
					{
						num2 = (short)1033764864;
						short num3 = num2;
						num2 = (short)2019098625;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset == null)
						{
							return result;
						}
						num2 = (short)754282046;
						short num4 = num2;
						num2 = (short)1520725566;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_26;
						default:
							num2 = (short)1874853888;
							if (num2 != 0)
							{
							}
							num2 = (short)1858863105;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 3:
						return result;
					case 4:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1980104707;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_24;
				}
				return result;
			}
			IL_24:
			result = null;
			IL_26:
			num2 = (short)2070151170;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040065A8 RID: 26024
		private global::AcpBusinessLayer.AcpRecRefField astTlkgrpLstGeneralKMFProfileIndex_A8380;

		// Token: 0x040065A9 RID: 26025
		private global::AcpBusinessLayer.AcpField<bool> astTlkgrpLstGeneralTalkgroupAlias_A9277;

		// Token: 0x040065AA RID: 26026
		private global::AcpBusinessLayer.AcpKeyField astTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665;

		// Token: 0x040065AB RID: 26027
		private global::AcpBusinessLayer.AcpSimpleRangeField astTlkgrpLstGeneralASTROTalkgroupLastUserIndex_A19780;
	}
}
