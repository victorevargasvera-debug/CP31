using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality
{
	// Token: 0x020000C8 RID: 200
	[global::System.Serializable]
	public class Labtool : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001B70 RID: 7024 RVA: 0x001BAD4C File Offset: 0x001B8F4C
		public Labtool(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x001BAD68 File Offset: 0x001B8F68
		protected Labtool(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x001BAD80 File Offset: 0x001B8F80
		public override void Init()
		{
			int a_ = 10;
			short num = (short)651312099;
			short num2 = num;
			num = (short)1132936163;
			switch (num2 == num)
			{
			}
			num = (short)594280449;
			if (num != 0)
			{
			}
			num = (short)636551168;
			short num3 = num;
			num = (short)568066048;
			if (num != 0)
			{
			}
			this.trkPerLabtoolSystemKey_A9242 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔鯖룘맚꧜냞軠迢뛤黦髨鿪裬苮뫰雲賴ꣶ룸싺쿼쯾㌀", a_), global::CommonResources.AcgResources.ID_SYSTEMKEY);
			this.trkPerLabtoolSystemKey_A9242.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.trkPerLabtoolSystemKey_A9242.DataTransferOrder = -1;
			this.trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔鯖룘맚꧜냞軠迢뇤闦鳨藪蛬蛮鿰铲ꗴ鋶诸裺鋼釾怀漂氄猆瀈弊氌挎稐吒朔砖氘欚尜猞䠠䈢嘤欦䀨堪夬昮䔰嘲場縶紸携簼฾础穂獄睆", a_), global::CommonResources.AcgResources.ID_TRUNKINGPERSONALITYTALKGROUPALIASLISTITEMID, null, null, true, false);
			this.trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960.DataTransferOrder = -1;
			this.trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔鯖룘맚꧜냞軠迢뇤闦鳨藪蛬蛮鿰铲ꗴ鋶诸裺鋼釾怀漂氄猆瀈嬊缌樎眐瘒朔攖簘缚东瘞唠䘢瘤匦䠨弪堬尮細娲䘴䌶瀸伺堼刾ࡀ݂ᩄن硈牊瑌祎捐", a_), global::CommonResources.AcgResources.ID_TRUNKINGPERSONALITYPREFERREDSITESTATUSLISTITEMID, null, null, true, false);
			this.trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962.DataTransferOrder = -1;
			this.trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎臐뛒꟔鯖룘맚꧜냞軠迢뇤闦鳨藪蛬蛮鿰铲ꗴ鋶诸裺鋼釾怀漂氄猆瀈䨊䨌嬎嘐唒䘔嬖瀘栚検嘞唠䘢䠤渦洨琪氬ᴮ0زԴ༶", a_), global::CommonResources.AcgResources.ID_TRUNKINGPERSONALITYAGTGFSLISTITEMID, null, null, true, false);
			this.trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟊곌귎ꗐ볒뫔믖", a_);
			base.Id = 10177;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 7;
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x001BAF4C File Offset: 0x001B914C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 0;
			short num = (short)1158873093;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_351;
				case 1:
				{
					num = (short)2060741217;
					short num3 = num;
					num = (short)1667197537;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_77;
					default:
						num = (short)2124677120;
						if (num != 0)
						{
						}
						goto IL_1FE;
					}
					break;
				}
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊臌껎돐꟒뫔룖뗘迚꿜꫞迠裢賤触軨믪裬鷮苰鳲鯴零闸鋺觼蛾唀戂椄氆丈礊戌税愐划礔縖砘栚儜瘞删圢氤匦䰨䘪搬欮渰爲дึ8ഺ഼", a_)))
					{
						num = (short)18415631;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AC;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊臌껎돐꟒뫔룖뗘迚꿜꫞迠裢賤触軨믪裬鷮苰鳲鯴零闸鋺觼蛾儀焂怄愆氈礊缌樎甐䀒簔挖簘䠚検縞唠嘢嘤欦䀨堪夬昮䔰嘲場縶紸携簼฾础穂獄畆", a_)))
					{
						num = (short)50659337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FE;
				case 4:
					goto IL_34C;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 6:
					goto IL_2AC;
				case 7:
					num = (short)485097485;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊臌껎돐꟒뫔룖뗘迚꿜꫞迠裢賤触軨믪裬鷮苰鳲鯴零闸鋺觼蛾䀀䐂億䀆伈堊䄌明成朒尔挖簘瘚吜嬞縠戢ᜤᘦᰨᬪᔬ", a_)))
					{
						num = (short)1563426826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3F3;
				case 9:
				{
					num = (short)29622272;
					short num4 = num;
					this.trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊臌껎돐꟒뫔룖뗘迚꿜꫞迠裢賤触軨믪裬鷮苰鳲鯴零闸鋺觼蛾儀焂怄愆氈礊缌樎甐䀒簔挖簘䠚検縞唠嘢嘤欦䀨堪夬昮䔰嘲場縶紸携簼฾础穂獄畆", a_), global::CommonResources.AcgResources.ID_TRUNKINGPERSONALITYPREFERREDSITESTATUSLISTITEMID, null, null, true, false);
					this.trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962.DataTransferOrder = -1;
					num = (short)1387331585;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
					this.trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊臌껎돐꟒뫔룖뗘迚꿜꫞迠裢賤触軨믪裬鷮苰鳲鯴零闸鋺觼蛾䀀䐂億䀆伈堊䄌明成朒尔挖簘瘚吜嬞縠戢ᜤᘦᰨᬪᔬ", a_), global::CommonResources.AcgResources.ID_TRUNKINGPERSONALITYAGTGFSLISTITEMID, null, null, true, false);
					this.trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508.DataTransferOrder = -1;
					num = (short)1490288644;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊臌껎돐꟒뫔룖뗘裚ꓜ곞闠蛢裤곦賨鋪달껮죰쇲쇴엶", a_)))
					{
						num = (short)555876364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_351;
				case 12:
					this.trkPerLabtoolSystemKey_A9242 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊臌껎돐꟒뫔룖뗘裚ꓜ곞闠蛢裤곦賨鋪달껮죰쇲쇴엶", a_), global::CommonResources.AcgResources.ID_SYSTEMKEY);
					this.trkPerLabtoolSystemKey_A9242.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.trkPerLabtoolSystemKey_A9242.DataTransferOrder = -1;
					num = (short)868089856;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (producerFields != null)
					{
						num = (short)813694990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3F3;
				case 14:
					num = (short)876544011;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					this.trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("闀뇂껄韆곈맊臌껎돐꟒뫔룖뗘迚꿜꫞迠裢賤触軨믪裬鷮苰鳲鯴零闸鋺觼蛾唀戂椄氆丈礊戌税愐划礔縖砘栚儜瘞删圢氤匦䰨䘪搬欮渰爲дึ8ഺ഼", a_), global::CommonResources.AcgResources.ID_TRUNKINGPERSONALITYTALKGROUPALIASLISTITEMID, null, null, true, false);
					this.trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960.DataTransferOrder = -1;
					num = (short)1858732038;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_6D;
				IL_77:
				num = (short)1872232455;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6D:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					goto IL_77;
				}
				break;
				IL_1FE:
				num = (short)1709047809;
				if (num != 0)
				{
				}
				num = (short)1612775432;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2AC:
				num = (short)1576861699;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_351:
				num = (short)1844707330;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_34C:
			IL_3F3:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("跀ꋂꟄ돆ꛈ꓊ꇌ", a_);
			base.Id = 10177;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 7;
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x001BB380 File Offset: 0x001B9580
		public override void PopulateReferences()
		{
			short num = (short)30611404;
			short num2 = num;
			num = (short)777918412;
			switch (num2 == num)
			{
			}
			num = (short)1616314369;
			if (num != 0)
			{
			}
			num = (short)1121976320;
			short num3 = num;
			num = (short)2052849664;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x001BB42C File Offset: 0x001B962C
		public override void DropReferences()
		{
			short num = (short)883126358;
			short num2 = num;
			num = (short)1067151446;
			switch (num2 == num)
			{
			}
			num = (short)1180172289;
			if (num != 0)
			{
			}
			num = (short)1285619712;
			short num3 = num;
			num = (short)828243968;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x001BB4D8 File Offset: 0x001B96D8
		public override void SetConstraints()
		{
			short num = (short)966009727;
			short num2 = num;
			num = (short)911352703;
			switch (num2 == num)
			{
			}
			num = (short)839254016;
			if (num != 0)
			{
			}
			num = (short)1833566208;
			short num3 = num;
			num = (short)1889402881;
			if (num != 0)
			{
			}
			this.trkPerLabtoolSystemKey_A9242.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x001BB59C File Offset: 0x001B979C
		public override void SetupDependencies()
		{
			short num = (short)860030244;
			short num2 = num;
			num = (short)1736705316;
			switch (num2 == num)
			{
			}
			num = (short)1273102337;
			if (num != 0)
			{
			}
			num = (short)1907621888;
			short num3 = num;
			num = (short)1670184960;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x06001B78 RID: 7032 RVA: 0x001BB648 File Offset: 0x001B9848
		public bool HasDiffs
		{
			get
			{
				short num = (short)385784227;
				short num2 = num;
				num = (short)1442748835;
				switch (num2 == num)
				{
				}
				num = (short)607846400;
				if (num != 0)
				{
				}
				num = (short)25165824;
				short num3 = num;
				num = (short)938868737;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06001B79 RID: 7033 RVA: 0x001BB6F8 File Offset: 0x001B98F8
		// (set) Token: 0x06001B7A RID: 7034 RVA: 0x001BB7B0 File Offset: 0x001B99B0
		public bool TrkPerLabtoolSystemKey_A9242Value
		{
			get
			{
				short num = (short)1942359609;
				short num2 = num;
				num = (short)1527909945;
				switch (num2 == num)
				{
				}
				num = (short)1450508289;
				if (num != 0)
				{
				}
				num = (short)540475392;
				short num3 = num;
				num = (short)97910784;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolSystemKey_A9242.Value;
			}
			set
			{
				short num = (short)1947240594;
				short num2 = num;
				num = (short)324503698;
				switch (num2 == num)
				{
				}
				num = (short)1069809664;
				if (num != 0)
				{
				}
				num = (short)1960837120;
				short num3 = num;
				num = (short)1472200705;
				if (num != 0)
				{
				}
				this.trkPerLabtoolSystemKey_A9242.Value = value;
			}
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x06001B7B RID: 7035 RVA: 0x001BB864 File Offset: 0x001B9A64
		public global::AcpBusinessLayer.AcpField<bool> TrkPerLabtoolSystemKey_A9242
		{
			get
			{
				short num = (short)1717894652;
				short num2 = num;
				num = (short)465829372;
				switch (num2 == num)
				{
				}
				num = (short)1616969729;
				if (num != 0)
				{
				}
				num = (short)1940520960;
				short num3 = num;
				num = (short)519307264;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolSystemKey_A9242;
			}
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06001B7C RID: 7036 RVA: 0x001BB914 File Offset: 0x001B9B14
		// (set) Token: 0x06001B7D RID: 7037 RVA: 0x001BB9C8 File Offset: 0x001B9BC8
		public bool TrkPerLabtoolSystemKey_A9242_UIValue
		{
			get
			{
				short num = (short)1765101315;
				short num2 = num;
				num = (short)1731415811;
				switch (num2 == num)
				{
				}
				num = (short)919666688;
				if (num != 0)
				{
				}
				num = (short)118947840;
				short num3 = num;
				num = (short)2119434241;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolSystemKey_A9242.Value;
			}
			set
			{
				short num = (short)1255754182;
				short num2 = num;
				num = (short)1034045894;
				switch (num2 == num)
				{
				}
				num = (short)865599489;
				if (num != 0)
				{
				}
				num = (short)463142912;
				short num3 = num;
				num = (short)539164672;
				if (num != 0)
				{
				}
				this.trkPerLabtoolSystemKey_A9242.Value = value;
			}
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x06001B7E RID: 7038 RVA: 0x001BBA7C File Offset: 0x001B9C7C
		// (set) Token: 0x06001B7F RID: 7039 RVA: 0x001BBB34 File Offset: 0x001B9D34
		public bool TrkPerLabtoolSystemKey_A9242_Applicable
		{
			get
			{
				short num = (short)1586816303;
				short num2 = num;
				num = (short)1886381359;
				switch (num2 == num)
				{
				}
				num = (short)1961492481;
				if (num != 0)
				{
				}
				num = (short)15794176;
				short num3 = num;
				num = (short)355598336;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolSystemKey_A9242.Applicable;
			}
			set
			{
				short num = (short)25713721;
				short num2 = num;
				num = (short)1827560505;
				switch (num2 == num)
				{
				}
				num = (short)1939013633;
				if (num != 0)
				{
				}
				num = (short)2127495168;
				short num3 = num;
				num = (short)888012800;
				if (num != 0)
				{
				}
				this.trkPerLabtoolSystemKey_A9242.Applicable = value;
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x06001B80 RID: 7040 RVA: 0x001BBBE8 File Offset: 0x001B9DE8
		// (set) Token: 0x06001B81 RID: 7041 RVA: 0x001BBC9C File Offset: 0x001B9E9C
		public bool TrkPerLabtoolSystemKey_A9242_Valid
		{
			get
			{
				short num = (short)1052305452;
				short num2 = num;
				num = (short)1312876588;
				switch (num2 == num)
				{
				}
				num = (short)849215489;
				if (num != 0)
				{
				}
				num = (short)1302986752;
				short num3 = num;
				num = (short)532021248;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolSystemKey_A9242.Valid;
			}
			set
			{
				short num = (short)1958818571;
				short num2 = num;
				num = (short)1097741067;
				switch (num2 == num)
				{
				}
				num = (short)1026555904;
				if (num != 0)
				{
				}
				num = (short)1568669696;
				short num3 = num;
				num = (short)2087780353;
				if (num != 0)
				{
				}
				this.trkPerLabtoolSystemKey_A9242.Valid = value;
			}
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x06001B82 RID: 7042 RVA: 0x001BBD54 File Offset: 0x001B9F54
		// (set) Token: 0x06001B83 RID: 7043 RVA: 0x001BBE08 File Offset: 0x001BA008
		public bool TrkPerLabtoolSystemKey_A9242_Visible
		{
			get
			{
				short num = (short)1214639557;
				short num2 = num;
				num = (short)1310453189;
				switch (num2 == num)
				{
				}
				num = (short)619446273;
				if (num != 0)
				{
				}
				num = (short)669450240;
				short num3 = num;
				num = (short)725352448;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolSystemKey_A9242.Visible;
			}
			set
			{
				short num = (short)498214031;
				short num2 = num;
				num = (short)1518347407;
				switch (num2 == num)
				{
				}
				num = (short)1158283264;
				if (num != 0)
				{
				}
				num = (short)839385088;
				short num3 = num;
				num = (short)1906049025;
				if (num != 0)
				{
				}
				this.trkPerLabtoolSystemKey_A9242.Visible = value;
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x06001B84 RID: 7044 RVA: 0x001BBEC0 File Offset: 0x001BA0C0
		// (set) Token: 0x06001B85 RID: 7045 RVA: 0x001BBF78 File Offset: 0x001BA178
		public bool TrkPerLabtoolSystemKey_A9242_Editable
		{
			get
			{
				short num = (short)999315114;
				short num2 = num;
				num = (short)1221678762;
				switch (num2 == num)
				{
				}
				num = (short)1286078465;
				if (num != 0)
				{
				}
				num = (short)573702144;
				short num3 = num;
				num = (short)302514176;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolSystemKey_A9242.Editable;
			}
			set
			{
				short num = (short)977971419;
				short num2 = num;
				num = (short)1456974043;
				switch (num2 == num)
				{
				}
				num = (short)941948929;
				if (num != 0)
				{
				}
				num = (short)920584192;
				short num3 = num;
				num = (short)398589952;
				if (num != 0)
				{
				}
				this.trkPerLabtoolSystemKey_A9242.Editable = value;
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06001B86 RID: 7046 RVA: 0x001BC02C File Offset: 0x001BA22C
		internal string TrkPerLabtoolSystemKey_A9242_UILabel
		{
			get
			{
				short num = (short)1389425959;
				short num2 = num;
				num = (short)552203559;
				switch (num2 == num)
				{
				}
				num = (short)1456209920;
				if (num != 0)
				{
				}
				num = (short)944832512;
				short num3 = num;
				num = (short)127664129;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolSystemKey_A9242.UIName;
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06001B87 RID: 7047 RVA: 0x001BC0E4 File Offset: 0x001BA2E4
		// (set) Token: 0x06001B88 RID: 7048 RVA: 0x001BC19C File Offset: 0x001BA39C
		internal bool TrkPerLabtoolSystemKey_A9242_HiddenStatic
		{
			get
			{
				short num = (short)69754125;
				short num2 = num;
				num = (short)1767398669;
				switch (num2 == num)
				{
				}
				num = (short)1813381121;
				if (num != 0)
				{
				}
				num = (short)1856634880;
				short num3 = num;
				num = (short)1519910912;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolSystemKey_A9242.HiddenStatic;
			}
			set
			{
				short num = (short)1084925633;
				short num2 = num;
				num = (short)280471233;
				switch (num2 == num)
				{
				}
				num = (short)1419771905;
				if (num != 0)
				{
				}
				num = (short)276955136;
				short num3 = num;
				num = (short)1153171456;
				if (num != 0)
				{
				}
				this.trkPerLabtoolSystemKey_A9242.HiddenStatic = value;
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06001B89 RID: 7049 RVA: 0x001BC254 File Offset: 0x001BA454
		// (set) Token: 0x06001B8A RID: 7050 RVA: 0x001BC308 File Offset: 0x001BA508
		internal bool TrkPerLabtoolSystemKey_A9242_HiddenDynamic
		{
			get
			{
				short num = (short)889847809;
				if (num != 0)
				{
				}
				num = (short)979673783;
				short num2 = num;
				num = (short)932750007;
				switch (num2 == num)
				{
				}
				num = (short)1673396224;
				short num3 = num;
				num = (short)2099511296;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolSystemKey_A9242.HiddenDynamic;
			}
			set
			{
				short num = (short)253689857;
				if (num != 0)
				{
				}
				num = (short)721696323;
				short num2 = num;
				num = (short)510998083;
				switch (num2 == num)
				{
				}
				num = (short)443678720;
				short num3 = num;
				num = (short)1857683456;
				if (num != 0)
				{
				}
				this.trkPerLabtoolSystemKey_A9242.HiddenDynamic = value;
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x06001B8B RID: 7051 RVA: 0x001BC3BC File Offset: 0x001BA5BC
		public bool TrkPerLabtoolSystemKey_A9242_HasDiffs
		{
			get
			{
				short num = (short)1105264641;
				if (num != 0)
				{
				}
				num = (short)66823513;
				short num2 = num;
				num = (short)1265739097;
				switch (num2 == num)
				{
				}
				num = (short)739246080;
				short num3 = num;
				num = (short)123338752;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolSystemKey_A9242._HasDiffs;
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x06001B8C RID: 7052 RVA: 0x001BC470 File Offset: 0x001BA670
		// (set) Token: 0x06001B8D RID: 7053 RVA: 0x001BC528 File Offset: 0x001BA728
		public int TrkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960Value
		{
			get
			{
				short num = (short)169491658;
				short num2 = num;
				num = (short)442514634;
				switch (num2 == num)
				{
				}
				num = (short)44695552;
				if (num != 0)
				{
				}
				num = (short)797376512;
				short num3 = num;
				num = (short)990707713;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960.Value;
			}
			set
			{
				short num = (short)832821447;
				short num2 = num;
				num = (short)321902791;
				switch (num2 == num)
				{
				}
				num = (short)408420353;
				if (num != 0)
				{
				}
				num = (short)1261633536;
				short num3 = num;
				num = (short)1434845184;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960.Value = value;
			}
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x06001B8E RID: 7054 RVA: 0x001BC5DC File Offset: 0x001BA7DC
		// (set) Token: 0x06001B8F RID: 7055 RVA: 0x001BC690 File Offset: 0x001BA890
		public string TrkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960_UIValue
		{
			get
			{
				short num = (short)1778506493;
				short num2 = num;
				num = (short)811850493;
				switch (num2 == num)
				{
				}
				num = (short)513736705;
				if (num != 0)
				{
				}
				num = (short)1746337792;
				short num3 = num;
				num = (short)1280049152;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960.UIValue;
			}
			set
			{
				short num = (short)1645964844;
				short num2 = num;
				num = (short)1872129580;
				switch (num2 == num)
				{
				}
				num = (short)864550913;
				if (num != 0)
				{
				}
				num = (short)1739063296;
				short num3 = num;
				num = (short)1110376448;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960.UIValue = value;
			}
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x06001B90 RID: 7056 RVA: 0x001BC744 File Offset: 0x001BA944
		public global::AcpBusinessLayer.AcpRecRefField TrkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960
		{
			get
			{
				short num = (short)1754533800;
				short num2 = num;
				num = 4008;
				switch (num2 == num)
				{
				}
				num = (short)2069495808;
				if (num != 0)
				{
				}
				num = (short)1826619392;
				short num3 = num;
				num = (short)674168833;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960;
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x06001B91 RID: 7057 RVA: 0x001BC7F4 File Offset: 0x001BA9F4
		// (set) Token: 0x06001B92 RID: 7058 RVA: 0x001BC8AC File Offset: 0x001BAAAC
		public bool TrkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960_Applicable
		{
			get
			{
				short num = (short)893648291;
				short num2 = num;
				num = (short)1446444451;
				switch (num2 == num)
				{
				}
				num = (short)1818689537;
				if (num != 0)
				{
				}
				num = (short)14024704;
				short num3 = num;
				num = (short)1621688320;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960.Applicable;
			}
			set
			{
				short num = (short)1379888545;
				short num2 = num;
				num = (short)946040225;
				switch (num2 == num)
				{
				}
				num = (short)1201209345;
				if (num != 0)
				{
				}
				num = (short)1161166848;
				short num3 = num;
				num = (short)2035613696;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960.Applicable = value;
			}
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x06001B93 RID: 7059 RVA: 0x001BC964 File Offset: 0x001BAB64
		// (set) Token: 0x06001B94 RID: 7060 RVA: 0x001BCA18 File Offset: 0x001BAC18
		public bool TrkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960_Valid
		{
			get
			{
				short num = (short)149595842;
				short num2 = num;
				num = (short)35497666;
				switch (num2 == num)
				{
				}
				num = (short)915013633;
				if (num != 0)
				{
				}
				num = (short)2021588992;
				short num3 = num;
				num = (short)997130240;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960.Valid;
			}
			set
			{
				short num = (short)874032059;
				short num2 = num;
				num = (short)274901947;
				switch (num2 == num)
				{
				}
				num = (short)743178241;
				if (num != 0)
				{
				}
				num = (short)213909504;
				short num3 = num;
				num = (short)1255211008;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960.Valid = value;
			}
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x06001B95 RID: 7061 RVA: 0x001BCACC File Offset: 0x001BACCC
		// (set) Token: 0x06001B96 RID: 7062 RVA: 0x001BCB80 File Offset: 0x001BAD80
		public bool TrkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960_Visible
		{
			get
			{
				short num = (short)571480253;
				short num2 = num;
				num = (short)257235133;
				switch (num2 == num)
				{
				}
				num = (short)2056454144;
				if (num != 0)
				{
				}
				num = (short)1133772800;
				short num3 = num;
				num = (short)1570635777;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960.Visible;
			}
			set
			{
				short num = (short)1186447364;
				short num2 = num;
				num = (short)2145501188;
				switch (num2 == num)
				{
				}
				num = (short)886767617;
				if (num != 0)
				{
				}
				num = (short)935591936;
				short num3 = num;
				num = (short)1247215616;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960.Visible = value;
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x06001B97 RID: 7063 RVA: 0x001BCC38 File Offset: 0x001BAE38
		// (set) Token: 0x06001B98 RID: 7064 RVA: 0x001BCCEC File Offset: 0x001BAEEC
		public bool TrkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960_Editable
		{
			get
			{
				short num = (short)1127038522;
				short num2 = num;
				num = (short)1619738170;
				switch (num2 == num)
				{
				}
				num = (short)1250754561;
				if (num != 0)
				{
				}
				num = (short)1810432000;
				short num3 = num;
				num = (short)601882624;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960.Editable;
			}
			set
			{
				short num = (short)326351154;
				short num2 = num;
				num = (short)1542568242;
				switch (num2 == num)
				{
				}
				num = (short)1560215553;
				if (num != 0)
				{
				}
				num = (short)406323200;
				short num3 = num;
				num = (short)1884422144;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960.Editable = value;
			}
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x06001B99 RID: 7065 RVA: 0x001BCDA4 File Offset: 0x001BAFA4
		internal string TrkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960_UILabel
		{
			get
			{
				short num = (short)1844230017;
				short num2 = num;
				num = (short)409712513;
				switch (num2 == num)
				{
				}
				num = (short)1749286913;
				if (num != 0)
				{
				}
				num = (short)65339392;
				short num3 = num;
				num = (short)1846935552;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960.UIName;
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06001B9A RID: 7066 RVA: 0x001BCE58 File Offset: 0x001BB058
		// (set) Token: 0x06001B9B RID: 7067 RVA: 0x001BCF08 File Offset: 0x001BB108
		internal bool TrkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960_HiddenStatic
		{
			get
			{
				short num = (short)80819569;
				short num2 = num;
				num = (short)1872246129;
				switch (num2 == num)
				{
				}
				num = (short)74907648;
				if (num != 0)
				{
				}
				num = (short)2093547520;
				short num3 = num;
				num = (short)1042612225;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960.HiddenStatic;
			}
			set
			{
				short num = (short)1155980602;
				short num2 = num;
				num = (short)1745673530;
				switch (num2 == num)
				{
				}
				num = (short)848429056;
				if (num != 0)
				{
				}
				num = (short)461045760;
				short num3 = num;
				num = (short)1031208961;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960.HiddenStatic = value;
			}
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x06001B9C RID: 7068 RVA: 0x001BCFC0 File Offset: 0x001BB1C0
		// (set) Token: 0x06001B9D RID: 7069 RVA: 0x001BD074 File Offset: 0x001BB274
		internal bool TrkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960_HiddenDynamic
		{
			get
			{
				short num = (short)1747795017;
				short num2 = num;
				num = (short)1419656265;
				switch (num2 == num)
				{
				}
				num = (short)1733951488;
				if (num != 0)
				{
				}
				num = (short)414449664;
				short num3 = num;
				num = (short)2053439489;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960.HiddenDynamic;
			}
			set
			{
				short num = (short)509140716;
				short num2 = num;
				num = (short)1464065772;
				switch (num2 == num)
				{
				}
				num = (short)1966735361;
				if (num != 0)
				{
				}
				num = (short)805437440;
				short num3 = num;
				num = (short)174522368;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960.HiddenDynamic = value;
			}
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x06001B9E RID: 7070 RVA: 0x001BD12C File Offset: 0x001BB32C
		public bool TrkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960_HasDiffs
		{
			get
			{
				short num = (short)1046478848;
				short num2 = num;
				num = (short)1472169359;
				short num3 = num;
				num = (short)904562063;
				switch (num3 == num)
				{
				}
				num = (short)290979841;
				if (num != 0)
				{
				}
				num = (short)567934976;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960._HasDiffs;
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x06001B9F RID: 7071 RVA: 0x001BD1E0 File Offset: 0x001BB3E0
		// (set) Token: 0x06001BA0 RID: 7072 RVA: 0x001BD294 File Offset: 0x001BB494
		public int TrkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962Value
		{
			get
			{
				short num = (short)55902208;
				short num2 = num;
				num = (short)1692794881;
				if (num != 0)
				{
				}
				num = (short)854047025;
				short num3 = num;
				num = (short)613792049;
				switch (num3 == num)
				{
				}
				num = (short)2137718784;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962.Value;
			}
			set
			{
				short num = (short)94765056;
				short num2 = num;
				num = (short)1724464791;
				short num3 = num;
				num = (short)119488151;
				switch (num3 == num)
				{
				}
				num = (short)1599143936;
				if (num != 0)
				{
				}
				num = (short)1696530433;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962.Value = value;
			}
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x001BD348 File Offset: 0x001BB548
		// (set) Token: 0x06001BA2 RID: 7074 RVA: 0x001BD400 File Offset: 0x001BB600
		public string TrkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962_UIValue
		{
			get
			{
				short num = (short)2136735744;
				short num2 = num;
				num = (short)2127227736;
				short num3 = num;
				num = (short)226487128;
				switch (num3 == num)
				{
				}
				num = (short)1800536065;
				if (num != 0)
				{
				}
				num = (short)404881408;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962.UIValue;
			}
			set
			{
				short num = (short)2103836672;
				short num2 = num;
				num = (short)2141792825;
				short num3 = num;
				num = (short)503851577;
				switch (num3 == num)
				{
				}
				num = (short)1920860160;
				if (num != 0)
				{
				}
				num = (short)1044185089;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962.UIValue = value;
			}
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x001BD4B8 File Offset: 0x001BB6B8
		public global::AcpBusinessLayer.AcpRecRefField TrkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962
		{
			get
			{
				short num = (short)1022296064;
				short num2 = num;
				num = (short)1585313157;
				short num3 = num;
				num = (short)1843262853;
				switch (num3 == num)
				{
				}
				num = (short)1606287360;
				if (num != 0)
				{
				}
				num = (short)172752897;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962;
			}
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x001BD568 File Offset: 0x001BB768
		// (set) Token: 0x06001BA5 RID: 7077 RVA: 0x001BD61C File Offset: 0x001BB81C
		public bool TrkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962_Applicable
		{
			get
			{
				short num = (short)2034958336;
				short num2 = num;
				num = (short)396079644;
				short num3 = num;
				num = (short)706916892;
				switch (num3 == num)
				{
				}
				num = (short)1163198465;
				if (num != 0)
				{
				}
				num = (short)31260672;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962.Applicable;
			}
			set
			{
				short num = (short)1966145536;
				short num2 = num;
				num = (short)1933917762;
				short num3 = num;
				num = (short)243678786;
				switch (num3 == num)
				{
				}
				num = (short)1015676929;
				if (num != 0)
				{
				}
				num = (short)1852571648;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962.Applicable = value;
			}
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x001BD6D4 File Offset: 0x001BB8D4
		// (set) Token: 0x06001BA7 RID: 7079 RVA: 0x001BD788 File Offset: 0x001BB988
		public bool TrkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962_Valid
		{
			get
			{
				short num = (short)573964288;
				short num2 = num;
				num = (short)653561600;
				short num3 = num;
				num = (short)92901120;
				switch (num3 == num)
				{
				}
				num = (short)1922695169;
				if (num != 0)
				{
				}
				num = (short)1776418816;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962.Valid;
			}
			set
			{
				short num = (short)70123520;
				short num2 = num;
				num = (short)694747137;
				if (num != 0)
				{
				}
				num = (short)1427313820;
				short num3 = num;
				num = (short)1515197596;
				switch (num3 == num)
				{
				}
				num = (short)555679744;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962.Valid = value;
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x001BD83C File Offset: 0x001BBA3C
		// (set) Token: 0x06001BA9 RID: 7081 RVA: 0x001BD8EC File Offset: 0x001BBAEC
		public bool TrkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962_Visible
		{
			get
			{
				short num = (short)1582956544;
				short num2 = num;
				num = (short)1391021405;
				short num3 = num;
				num = (short)665996637;
				switch (num3 == num)
				{
				}
				num = (short)230424576;
				if (num != 0)
				{
				}
				num = (short)2056060929;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962.Visible;
			}
			set
			{
				short num = (short)1192558592;
				short num2 = num;
				num = (short)1463148246;
				short num3 = num;
				num = (short)955178710;
				switch (num3 == num)
				{
				}
				num = (short)759234561;
				if (num != 0)
				{
				}
				num = (short)1104805888;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962.Visible = value;
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x06001BAA RID: 7082 RVA: 0x001BD9A4 File Offset: 0x001BBBA4
		// (set) Token: 0x06001BAB RID: 7083 RVA: 0x001BDA58 File Offset: 0x001BBC58
		public bool TrkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962_Editable
		{
			get
			{
				short num = (short)1751842816;
				short num2 = num;
				num = (short)289457055;
				short num3 = num;
				num = (short)984269727;
				switch (num3 == num)
				{
				}
				num = (short)750125057;
				if (num != 0)
				{
				}
				num = (short)1341390848;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962.Editable;
			}
			set
			{
				short num = (short)449773568;
				short num2 = num;
				num = (short)477590805;
				short num3 = num;
				num = (short)1047164181;
				switch (num3 == num)
				{
				}
				num = (short)1571094529;
				if (num != 0)
				{
				}
				num = (short)1044185088;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962.Editable = value;
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x06001BAC RID: 7084 RVA: 0x001BDB0C File Offset: 0x001BBD0C
		internal string TrkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962_UILabel
		{
			get
			{
				short num = (short)1918828544;
				short num2 = num;
				num = (short)1196964371;
				short num3 = num;
				num = (short)1830697491;
				switch (num3 == num)
				{
				}
				num = (short)1351090177;
				if (num != 0)
				{
				}
				num = (short)1087569920;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962.UIName;
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x06001BAD RID: 7085 RVA: 0x001BDBC0 File Offset: 0x001BBDC0
		// (set) Token: 0x06001BAE RID: 7086 RVA: 0x001BDC74 File Offset: 0x001BBE74
		internal bool TrkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962_HiddenStatic
		{
			get
			{
				short num = (short)1111293952;
				short num2 = num;
				num = (short)1829076517;
				short num3 = num;
				num = (short)524320293;
				switch (num3 == num)
				{
				}
				num = (short)1946812416;
				if (num != 0)
				{
				}
				num = (short)1428750337;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962.HiddenStatic;
			}
			set
			{
				short num = (short)595394560;
				short num2 = num;
				num = (short)402507866;
				short num3 = num;
				num = (short)1772013658;
				switch (num3 == num)
				{
				}
				num = (short)987889665;
				if (num != 0)
				{
				}
				num = (short)389611520;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962.HiddenStatic = value;
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x06001BAF RID: 7087 RVA: 0x001BDD28 File Offset: 0x001BBF28
		// (set) Token: 0x06001BB0 RID: 7088 RVA: 0x001BDDD8 File Offset: 0x001BBFD8
		internal bool TrkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962_HiddenDynamic
		{
			get
			{
				short num = (short)1280376832;
				short num2 = num;
				num = (short)1795801308;
				short num3 = num;
				num = (short)443138268;
				switch (num3 == num)
				{
				}
				num = (short)1111097345;
				if (num != 0)
				{
				}
				num = (short)1992425472;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962.HiddenDynamic;
			}
			set
			{
				short num = (short)1220149248;
				short num2 = num;
				num = (short)420675585;
				if (num != 0)
				{
				}
				num = (short)713372475;
				short num3 = num;
				num = (short)1620063035;
				switch (num3 == num)
				{
				}
				num = (short)666238976;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962.HiddenDynamic = value;
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06001BB1 RID: 7089 RVA: 0x001BDE90 File Offset: 0x001BC090
		public bool TrkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962_HasDiffs
		{
			get
			{
				short num = (short)203489280;
				short num2 = num;
				num = (short)1265310309;
				short num3 = num;
				num = (short)464460389;
				switch (num3 == num)
				{
				}
				num = (short)521535489;
				if (num != 0)
				{
				}
				num = (short)1865678848;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962._HasDiffs;
			}
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06001BB2 RID: 7090 RVA: 0x001BDF44 File Offset: 0x001BC144
		// (set) Token: 0x06001BB3 RID: 7091 RVA: 0x001BDFF8 File Offset: 0x001BC1F8
		public int TrkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508Value
		{
			get
			{
				short num = (short)817889280;
				short num2 = num;
				num = (short)1655631444;
				short num3 = num;
				num = (short)1405611604;
				switch (num3 == num)
				{
				}
				num = (short)1591476225;
				if (num != 0)
				{
				}
				num = (short)1932328960;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508.Value;
			}
			set
			{
				short num = (short)710868992;
				short num2 = num;
				num = (short)1259688287;
				short num3 = num;
				num = (short)398807391;
				switch (num3 == num)
				{
				}
				num = (short)652935169;
				if (num != 0)
				{
				}
				num = (short)230031360;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508.Value = value;
			}
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x001BE0B0 File Offset: 0x001BC2B0
		// (set) Token: 0x06001BB5 RID: 7093 RVA: 0x001BE168 File Offset: 0x001BC368
		public string TrkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508_UIValue
		{
			get
			{
				short num = (short)675807232;
				short num2 = num;
				num = (short)2089475108;
				short num3 = num;
				num = (short)56417316;
				switch (num3 == num)
				{
				}
				num = (short)1021706240;
				if (num != 0)
				{
				}
				num = (short)1439694849;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508.UIValue;
			}
			set
			{
				short num = (short)2029060096;
				short num2 = num;
				num = (short)690356225;
				if (num != 0)
				{
				}
				num = (short)1839677037;
				short num3 = num;
				num = (short)28524141;
				switch (num3 == num)
				{
				}
				num = (short)458293248;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508.UIValue = value;
			}
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x001BE21C File Offset: 0x001BC41C
		public global::AcpBusinessLayer.AcpRecRefField TrkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508
		{
			get
			{
				short num = (short)1762197504;
				short num2 = num;
				num = (short)689221757;
				short num3 = num;
				num = (short)2052829309;
				switch (num3 == num)
				{
				}
				num = (short)30146560;
				if (num != 0)
				{
				}
				num = (short)1439170561;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508;
			}
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x001BE2D0 File Offset: 0x001BC4D0
		// (set) Token: 0x06001BB8 RID: 7096 RVA: 0x001BE384 File Offset: 0x001BC584
		public bool TrkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508_Applicable
		{
			get
			{
				short num = (short)1926299648;
				short num2 = num;
				num = (short)901107567;
				short num3 = num;
				num = (short)1317785455;
				switch (num3 == num)
				{
				}
				num = (short)1690959872;
				if (num != 0)
				{
				}
				num = (short)651755521;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508.Applicable;
			}
			set
			{
				short num = (short)2052849664;
				short num2 = num;
				num = (short)1316188934;
				short num3 = num;
				num = (short)444232454;
				switch (num3 == num)
				{
				}
				num = (short)83230720;
				if (num != 0)
				{
				}
				num = (short)1541996545;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508.Applicable = value;
			}
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x001BE43C File Offset: 0x001BC63C
		// (set) Token: 0x06001BBA RID: 7098 RVA: 0x001BE4F0 File Offset: 0x001BC6F0
		public bool TrkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508_Valid
		{
			get
			{
				short num = (short)390397952;
				short num2 = num;
				num = (short)1445506955;
				short num3 = num;
				num = (short)53981067;
				switch (num3 == num)
				{
				}
				num = (short)1139343361;
				if (num != 0)
				{
				}
				num = (short)233046016;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508.Valid;
			}
			set
			{
				short num = (short)3014656;
				short num2 = num;
				num = (short)223963996;
				short num3 = num;
				num = (short)1151691612;
				switch (num3 == num)
				{
				}
				num = (short)2070413313;
				if (num != 0)
				{
				}
				num = (short)344784896;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508.Valid = value;
			}
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06001BBB RID: 7099 RVA: 0x001BE5A4 File Offset: 0x001BC7A4
		// (set) Token: 0x06001BBC RID: 7100 RVA: 0x001BE658 File Offset: 0x001BC858
		public bool TrkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508_Visible
		{
			get
			{
				short num = (short)1215234048;
				short num2 = num;
				num = (short)1013358376;
				short num3 = num;
				num = (short)859676456;
				switch (num3 == num)
				{
				}
				num = (short)1550188544;
				if (num != 0)
				{
				}
				num = (short)1887109121;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508.Visible;
			}
			set
			{
				short num = (short)1328807936;
				short num2 = num;
				num = (short)739079017;
				short num3 = num;
				num = (short)1571320681;
				switch (num3 == num)
				{
				}
				num = (short)1763704833;
				if (num != 0)
				{
				}
				num = (short)592248832;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508.Visible = value;
			}
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06001BBD RID: 7101 RVA: 0x001BE708 File Offset: 0x001BC908
		// (set) Token: 0x06001BBE RID: 7102 RVA: 0x001BE7BC File Offset: 0x001BC9BC
		public bool TrkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508_Editable
		{
			get
			{
				short num = (short)479002624;
				short num2 = num;
				num = (short)1866471404;
				short num3 = num;
				num = (short)1028855788;
				switch (num3 == num)
				{
				}
				num = (short)1672216576;
				if (num != 0)
				{
				}
				num = (short)132448257;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508.Editable;
			}
			set
			{
				short num = (short)1103822848;
				short num2 = num;
				num = (short)691216580;
				short num3 = num;
				num = (short)941367492;
				switch (num3 == num)
				{
				}
				num = (short)1182859265;
				if (num != 0)
				{
				}
				num = (short)366739456;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508.Editable = value;
			}
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06001BBF RID: 7103 RVA: 0x001BE874 File Offset: 0x001BCA74
		internal string TrkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508_UILabel
		{
			get
			{
				short num = (short)1615200256;
				short num2 = num;
				num = (short)988792788;
				short num3 = num;
				num = (short)1717028820;
				switch (num3 == num)
				{
				}
				num = (short)927006720;
				if (num != 0)
				{
				}
				num = (short)282394625;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508.UIName;
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06001BC0 RID: 7104 RVA: 0x001BE92C File Offset: 0x001BCB2C
		// (set) Token: 0x06001BC1 RID: 7105 RVA: 0x001BE9E0 File Offset: 0x001BCBE0
		internal bool TrkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508_HiddenStatic
		{
			get
			{
				short num = (short)2103640064;
				short num2 = num;
				num = (short)894442791;
				short num3 = num;
				num = (short)445324583;
				switch (num3 == num)
				{
				}
				num = (short)1468923904;
				if (num != 0)
				{
				}
				num = (short)342556673;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508.HiddenStatic;
			}
			set
			{
				short num = (short)683540480;
				short num2 = num;
				num = (short)1867513857;
				if (num != 0)
				{
				}
				num = (short)1104510226;
				short num3 = num;
				num = (short)2105376018;
				switch (num3 == num)
				{
				}
				num = (short)1740439552;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508.HiddenStatic = value;
			}
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x001BEA98 File Offset: 0x001BCC98
		// (set) Token: 0x06001BC3 RID: 7107 RVA: 0x001BEB4C File Offset: 0x001BCD4C
		internal bool TrkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508_HiddenDynamic
		{
			get
			{
				short num = (short)1959854080;
				short num2 = num;
				num = (short)656303810;
				short num3 = num;
				num = (short)445146818;
				switch (num3 == num)
				{
				}
				num = (short)506331137;
				if (num != 0)
				{
				}
				num = (short)1052835840;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508.HiddenDynamic;
			}
			set
			{
				short num = (short)1233190912;
				short num2 = num;
				num = (short)340152689;
				short num3 = num;
				num = (short)1860915569;
				switch (num3 == num)
				{
				}
				num = (short)1146093568;
				if (num != 0)
				{
				}
				num = (short)1526202369;
				if (num != 0)
				{
				}
				this.trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508.HiddenDynamic = value;
			}
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x001BEC00 File Offset: 0x001BCE00
		public bool TrkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508_HasDiffs
		{
			get
			{
				short num = (short)686882816;
				short num2 = num;
				num = (short)1365487245;
				short num3 = num;
				num = (short)888319629;
				switch (num3 == num)
				{
				}
				num = (short)1240727553;
				if (num != 0)
				{
				}
				num = (short)274923520;
				if (num != 0)
				{
				}
				return this.trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508._HasDiffs;
			}
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x001BECB8 File Offset: 0x001BCEB8
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
					if (base.ParentRecset != null)
					{
						num2 = (short)1525350401;
						if (num2 != 0)
						{
						}
						num2 = (short)392101892;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1812594691;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					goto IL_124;
				case 3:
					goto IL_165;
				case 4:
				{
					num2 = (short)1943601152;
					short num3 = num2;
					num2 = (short)555286529;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_24;
			}
			IL_124:
			return result;
			IL_165:
			goto IL_FA;
			IL_24:
			result = null;
			num2 = (short)286188919;
			short num4 = num2;
			num2 = (short)49145207;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_FA:
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num2 = (short)1928331266;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1622540288;
				if (num2 != 0)
				{
				}
				num2 = (short)1238695936;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x040008F2 RID: 2290
		private global::AcpBusinessLayer.AcpField<bool> trkPerLabtoolSystemKey_A9242;

		// Token: 0x040008F3 RID: 2291
		private global::AcpBusinessLayer.AcpRecRefField trkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960;

		// Token: 0x040008F4 RID: 2292
		private global::AcpBusinessLayer.AcpRecRefField trkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962;

		// Token: 0x040008F5 RID: 2293
		private global::AcpBusinessLayer.AcpRecRefField trkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508;
	}
}
