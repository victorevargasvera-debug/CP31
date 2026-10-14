using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Features.Converters;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide
{
	// Token: 0x02000238 RID: 568
	[global::System.Serializable]
	public class HomeMode : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06006569 RID: 25961 RVA: 0x005AE028 File Offset: 0x005AC228
		public HomeMode(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600656A RID: 25962 RVA: 0x005AE044 File Offset: 0x005AC244
		protected HomeMode(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600656B RID: 25963 RVA: 0x005AE05C File Offset: 0x005AC25C
		public override void Init()
		{
			int a_ = 8;
			short num = (short)621125961;
			short num2 = num;
			num = (short)1621991753;
			switch (num2 == num)
			{
			}
			num = (short)774832128;
			if (num != 0)
			{
			}
			num = (short)422313985;
			if (num != 0)
			{
			}
			num = (short)255459328;
			short num3 = num;
			this.radErgoWideHomeModeHomeModeSelection_A8202 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔胖냘뿚룜韞軠転胤ꫦ蛨迪裬꟮黰黲郴뫶雸鿺飼곾搀漂怄搆紈戊戌愎丐划ⴔ┖⤘⤚", a_), global::CommonResources.AcgResources.ID_HOMEMODE);
			this.radErgoWideHomeModeHomeModeSelection_A8202.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideHomeModeHomeModeSelection_A8202.DataTransferOrder = 1;
			this.radErgoWideHomeModeZone_A9691 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔胖냘뿚룜韞軠転胤ꫦ蛨迪裬뗮黰鷲郴ꣶ룸싺쯼웾\u3000", a_), global::CommonResources.AcgResources.ID_ZONE, new string[]
			{
				global::CommonResources.AcgResources.ID_SELECTED
			}, new int[1], true, true);
			this.radErgoWideHomeModeZone_A9691.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideHomeModeZone_A9691.DataTransferOrder = 2;
			this.homeModeChannel = new global::AcpBusinessLayer.AcpRangeField<int, string>(1, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("臈꓊ꃌ꫎鳐볒뇔닖高돚볜뇞迠蛢觤", a_), global::CommonResources.AcgResources.ID_CHANNEL, 1, 625, 1);
			this.homeModeChannel.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.homeModeChannel.DataTransferOrder = 3;
			this.homeModeChannel.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臈꓊ꃌ꫎黒뫔돖볘", a_);
			base.Id = 10076;
			base.UIName = global::CommonResources.AcgResources.ID_HOMEMODE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600656C RID: 25964 RVA: 0x005AE214 File Offset: 0x005AC414
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 9;
			short num = (short)263323655;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_2C1;
				case 1:
					this.radErgoWideHomeModeZone_A9691 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("飉귋꫍闏ꃑ돓맕迗동룛믝꣟跡解菥ꗧ藩裫语ꫯ鷱髳鏵ꟷ믹엻죽㧿㌁", a_), global::CommonResources.AcgResources.ID_ZONE, new string[]
					{
						global::CommonResources.AcgResources.ID_SELECTED
					}, new int[1], true, true);
					this.radErgoWideHomeModeZone_A9691.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideHomeModeZone_A9691.DataTransferOrder = 2;
					goto IL_D1;
				case 2:
					goto IL_EE;
				case 3:
				{
					num = (short)1950110736;
					short num3 = num;
					num = (short)1256215568;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D1;
					default:
					{
						num = (short)1412562944;
						short num4 = num;
						num = (short)704446464;
						if (num != 0)
						{
						}
						if (producerFields != null)
						{
							num = (short)448593929;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_360;
					}
					}
					break;
				}
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苉ꏋꏍ뗏鿑믓닕뷗駙듛뿝軟賡臣諥", a_)))
					{
						num = (short)889782277;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_360;
				case 5:
					this.homeModeChannel = new global::AcpBusinessLayer.AcpRangeField<int, string>(1, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("苉ꏋꏍ뗏鿑믓닕뷗駙듛뿝軟賡臣諥", a_), global::CommonResources.AcgResources.ID_CHANNEL);
					this.homeModeChannel.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.homeModeChannel.DataTransferOrder = 3;
					this.homeModeChannel.ShowHexValue = false;
					num = (short)434110475;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)835780609;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍闏ꃑ돓맕迗동룛믝꣟跡解菥ꗧ藩裫语룯鷱駳鏵뗷闹飻鯽叿朁栃挅欇縉攋愍縏䴑唓⸕⨗⨙⸛", a_)))
					{
						num = (short)2010710026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EE;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍闏ꃑ돓맕迗동룛믝꣟跡解菥ꗧ藩裫语ꫯ鷱髳鏵ꟷ믹엻죽㧿㌁", a_)))
					{
						num = (short)1868431361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C1;
				case 9:
					num = (short)593362950;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					this.radErgoWideHomeModeHomeModeSelection_A8202 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍闏ꃑ돓맕迗동룛믝꣟跡解菥ꗧ藩裫语룯鷱駳鏵뗷闹飻鯽叿朁栃挅欇縉攋愍縏䴑唓⸕⨗⨙⸛", a_), global::CommonResources.AcgResources.ID_HOMEMODE);
					this.radErgoWideHomeModeHomeModeSelection_A8202.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideHomeModeHomeModeSelection_A8202.DataTransferOrder = 1;
					num = (short)1267728386;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_20E;
				case 12:
					num = (short)1225588739;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_61:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1092812812;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_D1:
				num = (short)1477771264;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EE:
				num = (short)2012282888;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2C1:
				num = (short)1016135684;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_20E:
			IL_360:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苉ꏋꏍ뗏駓맕볗뿙", a_);
			base.Id = 10076;
			base.UIName = global::CommonResources.AcgResources.ID_HOMEMODE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600656D RID: 25965 RVA: 0x005AE5B4 File Offset: 0x005AC7B4
		public override void PopulateReferences()
		{
			short num = (short)1322599788;
			short num2 = num;
			num = (short)709838188;
			switch (num2 == num)
			{
			}
			num = (short)1648492545;
			if (num != 0)
			{
			}
			num = (short)1014497280;
			if (num != 0)
			{
			}
			num = (short)1935802368;
			short num3 = num;
			this.radErgoWideHomeModeZone_A9691.SetRecset(this.a(2051));
		}

		// Token: 0x0600656E RID: 25966 RVA: 0x005AE674 File Offset: 0x005AC874
		public override void DropReferences()
		{
			short num = (short)2095552981;
			short num2 = num;
			num = (short)586848725;
			switch (num2 == num)
			{
			}
			num = (short)406388737;
			if (num != 0)
			{
			}
			num = (short)1215561728;
			if (num != 0)
			{
			}
			num = (short)1416691712;
			short num3 = num;
		}

		// Token: 0x0600656F RID: 25967 RVA: 0x005AE71C File Offset: 0x005AC91C
		public override void SetConstraints()
		{
			short num = (short)2005387929;
			short num2 = num;
			num = (short)2069875353;
			switch (num2 == num)
			{
			}
			num = (short)663683073;
			if (num != 0)
			{
			}
			num = (short)1066074112;
			if (num != 0)
			{
			}
			num = (short)575275008;
			short num3 = num;
			this.RadErgoWideHomeModeHomeModeSelection_A8202.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConRadWideHomeModSelIsApplicable);
			this.radErgoWideHomeModeZone_A9691.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConRadWideHomeModSelIsEnabled);
			this.radErgoWideHomeModeZone_A9691.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConZoneReferencedIsNormalOrDynamicOneBased);
			this.homeModeChannel.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConRadWideHomeModSelIsEnabledAndNonDynamicZone);
			this.homeModeChannel.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConRadWideHomeModSelChannelIsValid);
		}

		// Token: 0x06006570 RID: 25968 RVA: 0x005AE838 File Offset: 0x005ACA38
		public override void SetupDependencies()
		{
			short num = (short)540754077;
			short num2 = num;
			num = (short)1197752477;
			switch (num2 == num)
			{
			}
			num = (short)500563968;
			if (num != 0)
			{
			}
			num = (short)356319233;
			if (num != 0)
			{
			}
			num = (short)1851719680;
			short num3 = num;
			this.radErgoWideHomeModeHomeModeSelection_A8202.AddDependentObject(this.radErgoWideHomeModeZone_A9691);
			this.homeModeChannel.AddDependentObject(this.radErgoWideHomeModeZone_A9691);
			this.RefRadioWide.Features.RadWideFeaturesNFPACompliant.AddDependentObject(this.RadErgoWideHomeModeHomeModeSelection_A8202);
		}

		// Token: 0x17003499 RID: 13465
		// (get) Token: 0x06006571 RID: 25969 RVA: 0x005AE920 File Offset: 0x005ACB20
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment ZoneChannelAssignmentForRadErgoWideHomeModeZone_A9691
		{
			get
			{
				short num = (short)1428210215;
				short num2 = num;
				num = (short)10863143;
				switch (num2 == num)
				{
				}
				num = (short)394199041;
				if (num != 0)
				{
				}
				num = (short)2042363904;
				if (num != 0)
				{
				}
				num = (short)374538240;
				short num3 = num;
				return this.radErgoWideHomeModeZone_A9691.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
			}
		}

		// Token: 0x1700349A RID: 13466
		// (get) Token: 0x06006572 RID: 25970 RVA: 0x005AE9D8 File Offset: 0x005ACBD8
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)671362710;
				short num2 = num;
				num = (short)1291529878;
				switch (num2 == num)
				{
				}
				num = (short)139984897;
				if (num != 0)
				{
				}
				num = (short)77791232;
				if (num != 0)
				{
				}
				num = (short)546308096;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x1700349B RID: 13467
		// (get) Token: 0x06006573 RID: 25971 RVA: 0x005AEA98 File Offset: 0x005ACC98
		public bool HasDiffs
		{
			get
			{
				short num = (short)1286547869;
				short num2 = num;
				num = (short)799091101;
				switch (num2 == num)
				{
				}
				num = (short)8454145;
				if (num != 0)
				{
				}
				num = (short)1398210560;
				if (num != 0)
				{
				}
				num = (short)1977286656;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x1700349C RID: 13468
		// (get) Token: 0x06006574 RID: 25972 RVA: 0x005AEB48 File Offset: 0x005ACD48
		// (set) Token: 0x06006575 RID: 25973 RVA: 0x005AEBFC File Offset: 0x005ACDFC
		public bool RadErgoWideHomeModeHomeModeSelection_A8202Value
		{
			get
			{
				short num = (short)45522957;
				short num2 = num;
				num = (short)196583437;
				switch (num2 == num)
				{
				}
				num = (short)1231159296;
				if (num != 0)
				{
				}
				num = (short)890896385;
				if (num != 0)
				{
				}
				num = (short)342884352;
				short num3 = num;
				return this.radErgoWideHomeModeHomeModeSelection_A8202.Value;
			}
			set
			{
				short num = (short)103909279;
				short num2 = num;
				num = (short)504137631;
				switch (num2 == num)
				{
				}
				num = (short)1888419840;
				if (num != 0)
				{
				}
				num = (short)1518993409;
				if (num != 0)
				{
				}
				num = (short)1093926912;
				short num3 = num;
				this.radErgoWideHomeModeHomeModeSelection_A8202.Value = value;
			}
		}

		// Token: 0x1700349D RID: 13469
		// (get) Token: 0x06006576 RID: 25974 RVA: 0x005AECB4 File Offset: 0x005ACEB4
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWideHomeModeHomeModeSelection_A8202
		{
			get
			{
				short num = (short)1539309569;
				if (num != 0)
				{
				}
				num = (short)1114930747;
				short num2 = num;
				num = (short)1011777083;
				switch (num2 == num)
				{
				}
				num = (short)1775632384;
				if (num != 0)
				{
				}
				num = (short)988086272;
				short num3 = num;
				return this.radErgoWideHomeModeHomeModeSelection_A8202;
			}
		}

		// Token: 0x1700349E RID: 13470
		// (get) Token: 0x06006577 RID: 25975 RVA: 0x005AED64 File Offset: 0x005ACF64
		// (set) Token: 0x06006578 RID: 25976 RVA: 0x005AEE18 File Offset: 0x005AD018
		public bool RadErgoWideHomeModeHomeModeSelection_A8202_UIValue
		{
			get
			{
				short num = (short)1941375270;
				short num2 = num;
				num = (short)1694566694;
				switch (num2 == num)
				{
				}
				num = (short)153354241;
				if (num != 0)
				{
				}
				num = (short)338100224;
				if (num != 0)
				{
				}
				num = (short)132775936;
				short num3 = num;
				return this.radErgoWideHomeModeHomeModeSelection_A8202.Value;
			}
			set
			{
				short num = (short)243151557;
				short num2 = num;
				num = (short)957166277;
				switch (num2 == num)
				{
				}
				num = (short)1635319809;
				if (num != 0)
				{
				}
				num = (short)1486618624;
				if (num != 0)
				{
				}
				num = (short)95158272;
				short num3 = num;
				this.radErgoWideHomeModeHomeModeSelection_A8202.Value = value;
			}
		}

		// Token: 0x1700349F RID: 13471
		// (get) Token: 0x06006579 RID: 25977 RVA: 0x005AEED0 File Offset: 0x005AD0D0
		// (set) Token: 0x0600657A RID: 25978 RVA: 0x005AEF84 File Offset: 0x005AD184
		public bool RadErgoWideHomeModeHomeModeSelection_A8202_Applicable
		{
			get
			{
				short num = (short)736224958;
				short num2 = num;
				num = (short)859956926;
				switch (num2 == num)
				{
				default:
				{
					num = (short)532873216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)692977664;
				if (num != 0)
				{
				}
				num = (short)1964113921;
				if (num != 0)
				{
				}
				return this.radErgoWideHomeModeHomeModeSelection_A8202.Applicable;
			}
			set
			{
				short num = (short)1739762470;
				short num2 = num;
				num = (short)254716710;
				switch (num2 == num)
				{
				default:
				{
					num = (short)177209344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1953955841;
				if (num != 0)
				{
				}
				num = (short)1164705792;
				if (num != 0)
				{
				}
				this.radErgoWideHomeModeHomeModeSelection_A8202.Applicable = value;
			}
		}

		// Token: 0x170034A0 RID: 13472
		// (get) Token: 0x0600657B RID: 25979 RVA: 0x005AF03C File Offset: 0x005AD23C
		// (set) Token: 0x0600657C RID: 25980 RVA: 0x005AF0F0 File Offset: 0x005AD2F0
		public bool RadErgoWideHomeModeHomeModeSelection_A8202_Valid
		{
			get
			{
				short num = (short)223843749;
				short num2 = num;
				num = (short)293770661;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1569914880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)369688577;
				if (num != 0)
				{
				}
				num = (short)1054670848;
				if (num != 0)
				{
				}
				return this.radErgoWideHomeModeHomeModeSelection_A8202.Valid;
			}
			set
			{
				short num = (short)1222049793;
				if (num != 0)
				{
				}
				num = (short)953483264;
				short num2 = num;
				num = (short)1535770629;
				short num3 = num;
				num = (short)1077673989;
				switch (num3 == num)
				{
				}
				num = (short)1467088896;
				if (num != 0)
				{
				}
				this.radErgoWideHomeModeHomeModeSelection_A8202.Valid = value;
			}
		}

		// Token: 0x170034A1 RID: 13473
		// (get) Token: 0x0600657D RID: 25981 RVA: 0x005AF1A4 File Offset: 0x005AD3A4
		// (set) Token: 0x0600657E RID: 25982 RVA: 0x005AF25C File Offset: 0x005AD45C
		public bool RadErgoWideHomeModeHomeModeSelection_A8202_Visible
		{
			get
			{
				short num = (short)876618704;
				short num2 = num;
				num = (short)456139728;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1593245696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)625868801;
				if (num != 0)
				{
				}
				num = (short)704380928;
				if (num != 0)
				{
				}
				return this.radErgoWideHomeModeHomeModeSelection_A8202.Visible;
			}
			set
			{
				short num = (short)364075883;
				short num2 = num;
				num = (short)1921866603;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1777205248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1422458880;
				if (num != 0)
				{
				}
				num = (short)148307969;
				if (num != 0)
				{
				}
				this.radErgoWideHomeModeHomeModeSelection_A8202.Visible = value;
			}
		}

		// Token: 0x170034A2 RID: 13474
		// (get) Token: 0x0600657F RID: 25983 RVA: 0x005AF314 File Offset: 0x005AD514
		// (set) Token: 0x06006580 RID: 25984 RVA: 0x005AF3C4 File Offset: 0x005AD5C4
		public bool RadErgoWideHomeModeHomeModeSelection_A8202_Editable
		{
			get
			{
				short num = (short)10447829;
				short num2 = num;
				num = (short)881880021;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1364393984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1234894848;
				if (num != 0)
				{
				}
				num = (short)546832385;
				if (num != 0)
				{
				}
				return this.radErgoWideHomeModeHomeModeSelection_A8202.Editable;
			}
			set
			{
				short num = (short)1840119809;
				if (num != 0)
				{
				}
				num = (short)518127616;
				short num2 = num;
				num = (short)653995594;
				short num3 = num;
				num = (short)1535520330;
				switch (num3 == num)
				{
				}
				num = (short)1129447424;
				if (num != 0)
				{
				}
				this.radErgoWideHomeModeHomeModeSelection_A8202.Editable = value;
			}
		}

		// Token: 0x170034A3 RID: 13475
		// (get) Token: 0x06006581 RID: 25985 RVA: 0x005AF47C File Offset: 0x005AD67C
		internal string RadErgoWideHomeModeHomeModeSelection_A8202_UILabel
		{
			get
			{
				short num = (short)150607016;
				short num2 = num;
				num = (short)1980241064;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1800667136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1589444609;
				if (num != 0)
				{
				}
				num = (short)2133000192;
				if (num != 0)
				{
				}
				return this.radErgoWideHomeModeHomeModeSelection_A8202.UIName;
			}
		}

		// Token: 0x170034A4 RID: 13476
		// (get) Token: 0x06006582 RID: 25986 RVA: 0x005AF530 File Offset: 0x005AD730
		// (set) Token: 0x06006583 RID: 25987 RVA: 0x005AF5E8 File Offset: 0x005AD7E8
		internal bool RadErgoWideHomeModeHomeModeSelection_A8202_HiddenStatic
		{
			get
			{
				short num = (short)810714879;
				short num2 = num;
				num = (short)828278527;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1689124864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1218445313;
				if (num != 0)
				{
				}
				num = (short)84934656;
				if (num != 0)
				{
				}
				return this.radErgoWideHomeModeHomeModeSelection_A8202.HiddenStatic;
			}
			set
			{
				short num = (short)222341867;
				short num2 = num;
				num = (short)691514091;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1941045248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1247150081;
				if (num != 0)
				{
				}
				num = (short)12517376;
				if (num != 0)
				{
				}
				this.radErgoWideHomeModeHomeModeSelection_A8202.HiddenStatic = value;
			}
		}

		// Token: 0x170034A5 RID: 13477
		// (get) Token: 0x06006584 RID: 25988 RVA: 0x005AF69C File Offset: 0x005AD89C
		// (set) Token: 0x06006585 RID: 25989 RVA: 0x005AF750 File Offset: 0x005AD950
		internal bool RadErgoWideHomeModeHomeModeSelection_A8202_HiddenDynamic
		{
			get
			{
				short num = (short)1152340152;
				short num2 = num;
				num = (short)1480282296;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1352728576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)748945408;
				if (num != 0)
				{
				}
				num = (short)2135752705;
				if (num != 0)
				{
				}
				return this.radErgoWideHomeModeHomeModeSelection_A8202.HiddenDynamic;
			}
			set
			{
				short num = (short)67951622;
				short num2 = num;
				num = (short)140368902;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1971257344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)754515969;
				if (num != 0)
				{
				}
				num = (short)316669952;
				if (num != 0)
				{
				}
				this.radErgoWideHomeModeHomeModeSelection_A8202.HiddenDynamic = value;
			}
		}

		// Token: 0x170034A6 RID: 13478
		// (get) Token: 0x06006586 RID: 25990 RVA: 0x005AF808 File Offset: 0x005ADA08
		public bool RadErgoWideHomeModeHomeModeSelection_A8202_HasDiffs
		{
			get
			{
				short num = (short)1637618639;
				short num2 = num;
				num = (short)1686246351;
				switch (num2 == num)
				{
				default:
				{
					num = (short)891486208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1653407745;
				if (num != 0)
				{
				}
				num = (short)962265088;
				if (num != 0)
				{
				}
				return this.radErgoWideHomeModeHomeModeSelection_A8202._HasDiffs;
			}
		}

		// Token: 0x170034A7 RID: 13479
		// (get) Token: 0x06006587 RID: 25991 RVA: 0x005AF8C0 File Offset: 0x005ADAC0
		// (set) Token: 0x06006588 RID: 25992 RVA: 0x005AF978 File Offset: 0x005ADB78
		public int RadErgoWideHomeModeZone_A9691Value
		{
			get
			{
				short num = (short)877085644;
				short num2 = num;
				num = (short)1741439948;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2019622912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2127822849;
				if (num != 0)
				{
				}
				num = (short)868024320;
				if (num != 0)
				{
				}
				return this.radErgoWideHomeModeZone_A9691.Value;
			}
			set
			{
				short num = (short)942640299;
				short num2 = num;
				num = (short)1744538795;
				switch (num2 == num)
				{
				default:
				{
					num = (short)601227264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1769275392;
				if (num != 0)
				{
				}
				num = (short)1157693441;
				if (num != 0)
				{
				}
				this.radErgoWideHomeModeZone_A9691.Value = value;
			}
		}

		// Token: 0x170034A8 RID: 13480
		// (get) Token: 0x06006589 RID: 25993 RVA: 0x005AFA30 File Offset: 0x005ADC30
		// (set) Token: 0x0600658A RID: 25994 RVA: 0x005AFAE4 File Offset: 0x005ADCE4
		public string RadErgoWideHomeModeZone_A9691_UIValue
		{
			get
			{
				short num = (short)2138428568;
				short num2 = num;
				num = (short)1820120216;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1624047616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1999044609;
				if (num != 0)
				{
				}
				num = (short)1757806592;
				if (num != 0)
				{
				}
				return this.radErgoWideHomeModeZone_A9691.UIValue;
			}
			set
			{
				short num = (short)1567227905;
				if (num != 0)
				{
				}
				num = (short)13238272;
				short num2 = num;
				num = (short)1815178391;
				short num3 = num;
				num = (short)1609788567;
				switch (num3 == num)
				{
				}
				num = (short)1794310144;
				if (num != 0)
				{
				}
				this.radErgoWideHomeModeZone_A9691.UIValue = value;
			}
		}

		// Token: 0x170034A9 RID: 13481
		// (get) Token: 0x0600658B RID: 25995 RVA: 0x005AFB9C File Offset: 0x005ADD9C
		public global::AcpBusinessLayer.AcpRecRefField RadErgoWideHomeModeZone_A9691
		{
			get
			{
				short num = (short)288662526;
				short num2 = num;
				num = (short)2049811454;
				switch (num2 == num)
				{
				default:
				{
					num = (short)624689152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)831848449;
				if (num != 0)
				{
				}
				num = (short)493223936;
				if (num != 0)
				{
				}
				return this.radErgoWideHomeModeZone_A9691;
			}
		}

		// Token: 0x170034AA RID: 13482
		// (get) Token: 0x0600658C RID: 25996 RVA: 0x005AFC4C File Offset: 0x005ADE4C
		// (set) Token: 0x0600658D RID: 25997 RVA: 0x005AFD00 File Offset: 0x005ADF00
		public bool RadErgoWideHomeModeZone_A9691_Applicable
		{
			get
			{
				short num = (short)686703117;
				short num2 = num;
				num = (short)846479885;
				switch (num2 == num)
				{
				default:
				{
					num = (short)180289536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1975779329;
				if (num != 0)
				{
				}
				num = (short)584974336;
				if (num != 0)
				{
				}
				return this.radErgoWideHomeModeZone_A9691.Applicable;
			}
			set
			{
				short num = (short)1513424815;
				short num2 = num;
				num = (short)1784678319;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1389428736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)933167105;
				if (num != 0)
				{
				}
				num = (short)1234698240;
				if (num != 0)
				{
				}
				this.radErgoWideHomeModeZone_A9691.Applicable = value;
			}
		}

		// Token: 0x170034AB RID: 13483
		// (get) Token: 0x0600658E RID: 25998 RVA: 0x005AFDB4 File Offset: 0x005ADFB4
		// (set) Token: 0x0600658F RID: 25999 RVA: 0x005AFE68 File Offset: 0x005AE068
		public bool RadErgoWideHomeModeZone_A9691_Valid
		{
			get
			{
				short num = (short)7602177;
				if (num != 0)
				{
				}
				num = (short)507838464;
				short num2 = num;
				num = (short)205306858;
				short num3 = num;
				num = (short)823376874;
				switch (num3 == num)
				{
				}
				num = (short)65339392;
				if (num != 0)
				{
				}
				return this.radErgoWideHomeModeZone_A9691.Valid;
			}
			set
			{
				short num = (short)1952484805;
				short num2 = num;
				num = (short)1567067589;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1388511232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2110324737;
				if (num != 0)
				{
				}
				num = (short)924123136;
				if (num != 0)
				{
				}
				this.radErgoWideHomeModeZone_A9691.Valid = value;
			}
		}

		// Token: 0x170034AC RID: 13484
		// (get) Token: 0x06006590 RID: 26000 RVA: 0x005AFF1C File Offset: 0x005AE11C
		// (set) Token: 0x06006591 RID: 26001 RVA: 0x005AFFD0 File Offset: 0x005AE1D0
		public bool RadErgoWideHomeModeZone_A9691_Visible
		{
			get
			{
				short num = (short)1283254108;
				short num2 = num;
				num = (short)371124060;
				switch (num2 == num)
				{
				default:
				{
					num = (short)448069632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1347485696;
				if (num != 0)
				{
				}
				num = (short)1649737729;
				if (num != 0)
				{
				}
				return this.radErgoWideHomeModeZone_A9691.Visible;
			}
			set
			{
				short num = (short)1471425452;
				short num2 = num;
				num = (short)571550636;
				switch (num2 == num)
				{
				default:
				{
					num = (short)46333952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)737214465;
				if (num != 0)
				{
				}
				num = (short)1947926528;
				if (num != 0)
				{
				}
				this.radErgoWideHomeModeZone_A9691.Visible = value;
			}
		}

		// Token: 0x170034AD RID: 13485
		// (get) Token: 0x06006592 RID: 26002 RVA: 0x005B0088 File Offset: 0x005AE288
		// (set) Token: 0x06006593 RID: 26003 RVA: 0x005B013C File Offset: 0x005AE33C
		public bool RadErgoWideHomeModeZone_A9691_Editable
		{
			get
			{
				short num = (short)1694554147;
				short num2 = num;
				num = (short)1620760611;
				switch (num2 == num)
				{
				default:
				{
					num = (short)735313920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)567214080;
				if (num != 0)
				{
				}
				num = (short)257556481;
				if (num != 0)
				{
				}
				return this.radErgoWideHomeModeZone_A9691.Editable;
			}
			set
			{
				short num = (short)274234010;
				short num2 = num;
				num = (short)1728739994;
				switch (num2 == num)
				{
				default:
				{
					num = (short)212140032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1481506817;
				if (num != 0)
				{
				}
				num = (short)574160896;
				if (num != 0)
				{
				}
				this.radErgoWideHomeModeZone_A9691.Editable = value;
			}
		}

		// Token: 0x170034AE RID: 13486
		// (get) Token: 0x06006594 RID: 26004 RVA: 0x005B01F4 File Offset: 0x005AE3F4
		internal string RadErgoWideHomeModeZone_A9691_UILabel
		{
			get
			{
				short num = (short)408420353;
				if (num != 0)
				{
				}
				num = (short)1547173888;
				short num2 = num;
				num = (short)1756567679;
				short num3 = num;
				num = (short)1672288383;
				switch (num3 == num)
				{
				}
				num = (short)131858432;
				if (num != 0)
				{
				}
				return this.radErgoWideHomeModeZone_A9691.UIName;
			}
		}

		// Token: 0x170034AF RID: 13487
		// (get) Token: 0x06006595 RID: 26005 RVA: 0x005B02A8 File Offset: 0x005AE4A8
		// (set) Token: 0x06006596 RID: 26006 RVA: 0x005B0360 File Offset: 0x005AE560
		internal bool RadErgoWideHomeModeZone_A9691_HiddenStatic
		{
			get
			{
				short num = (short)931045794;
				short num2 = num;
				num = (short)1561895330;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1747517440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1416757248;
				if (num != 0)
				{
				}
				num = (short)118751233;
				if (num != 0)
				{
				}
				return this.radErgoWideHomeModeZone_A9691.HiddenStatic;
			}
			set
			{
				short num = (short)122096207;
				short num2 = num;
				num = (short)1154419279;
				switch (num2 == num)
				{
				default:
				{
					num = (short)758251520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1703084032;
				if (num != 0)
				{
				}
				num = (short)1407582209;
				if (num != 0)
				{
				}
				this.radErgoWideHomeModeZone_A9691.HiddenStatic = value;
			}
		}

		// Token: 0x170034B0 RID: 13488
		// (get) Token: 0x06006597 RID: 26007 RVA: 0x005B0414 File Offset: 0x005AE614
		// (set) Token: 0x06006598 RID: 26008 RVA: 0x005B04C8 File Offset: 0x005AE6C8
		internal bool RadErgoWideHomeModeZone_A9691_HiddenDynamic
		{
			get
			{
				short num = (short)589954283;
				short num2 = num;
				num = (short)247856363;
				switch (num2 == num)
				{
				default:
				{
					num = (short)515112960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)611319808;
				if (num != 0)
				{
				}
				num = (short)500039681;
				if (num != 0)
				{
				}
				return this.radErgoWideHomeModeZone_A9691.HiddenDynamic;
			}
			set
			{
				short num = (short)430366326;
				short num2 = num;
				num = (short)465165942;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1863581696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1566179329;
				if (num != 0)
				{
				}
				num = (short)1043070976;
				if (num != 0)
				{
				}
				this.radErgoWideHomeModeZone_A9691.HiddenDynamic = value;
			}
		}

		// Token: 0x170034B1 RID: 13489
		// (get) Token: 0x06006599 RID: 26009 RVA: 0x005B057C File Offset: 0x005AE77C
		public bool RadErgoWideHomeModeZone_A9691_HasDiffs
		{
			get
			{
				short num = (short)1902897497;
				short num2 = num;
				num = (short)1826679129;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1309671424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)344981505;
				if (num != 0)
				{
				}
				num = (short)1598423040;
				if (num != 0)
				{
				}
				return this.radErgoWideHomeModeZone_A9691._HasDiffs;
			}
		}

		// Token: 0x170034B2 RID: 13490
		// (get) Token: 0x0600659A RID: 26010 RVA: 0x005B0630 File Offset: 0x005AE830
		// (set) Token: 0x0600659B RID: 26011 RVA: 0x005B06E0 File Offset: 0x005AE8E0
		public int HomeModeChannelValue
		{
			get
			{
				short num = (short)733347841;
				if (num != 0)
				{
				}
				num = (short)1706622976;
				short num2 = num;
				num = (short)511400487;
				short num3 = num;
				num = (short)1438931495;
				switch (num3 == num)
				{
				}
				num = (short)1363476480;
				if (num != 0)
				{
				}
				return this.homeModeChannel.Value;
			}
			set
			{
				short num = (short)1022906654;
				short num2 = num;
				num = (short)1163153694;
				switch (num2 == num)
				{
				default:
				{
					num = (short)667156480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)193593345;
				if (num != 0)
				{
				}
				num = (short)1330642944;
				if (num != 0)
				{
				}
				this.homeModeChannel.Value = value;
			}
		}

		// Token: 0x170034B3 RID: 13491
		// (get) Token: 0x0600659C RID: 26012 RVA: 0x005B0794 File Offset: 0x005AE994
		public global::AcpBusinessLayer.AcpRangeField<int, string> HomeModeChannel
		{
			get
			{
				short num = (short)1415079143;
				short num2 = num;
				num = (short)1877566695;
				switch (num2 == num)
				{
				default:
				{
					num = (short)678690816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2113470465;
				if (num != 0)
				{
				}
				num = (short)1536229376;
				if (num != 0)
				{
				}
				return this.homeModeChannel;
			}
		}

		// Token: 0x170034B4 RID: 13492
		// (get) Token: 0x0600659D RID: 26013 RVA: 0x005B0844 File Offset: 0x005AEA44
		// (set) Token: 0x0600659E RID: 26014 RVA: 0x005B08F8 File Offset: 0x005AEAF8
		public string HomeModeChannel_UIValue
		{
			get
			{
				short num = (short)1887109121;
				if (num != 0)
				{
				}
				num = (short)1635057664;
				short num2 = num;
				num = (short)1670635221;
				short num3 = num;
				num = (short)1209327317;
				switch (num3 == num)
				{
				}
				num = (short)104988672;
				if (num != 0)
				{
				}
				return this.homeModeChannel.UIValue;
			}
			set
			{
				short num = (short)542042291;
				short num2 = num;
				num = (short)1712384179;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1313931264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1532362752;
				if (num != 0)
				{
				}
				num = (short)71761921;
				if (num != 0)
				{
				}
				this.homeModeChannel.UIValue = value;
			}
		}

		// Token: 0x170034B5 RID: 13493
		// (get) Token: 0x0600659F RID: 26015 RVA: 0x005B09AC File Offset: 0x005AEBAC
		// (set) Token: 0x060065A0 RID: 26016 RVA: 0x005B0A64 File Offset: 0x005AEC64
		internal int HomeModeChannelMin
		{
			get
			{
				short num = (short)276584607;
				short num2 = num;
				num = (short)1776375967;
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
				num = (short)1810497536;
				if (num != 0)
				{
				}
				num = (short)2038038529;
				if (num != 0)
				{
				}
				return this.homeModeChannel.Min;
			}
			set
			{
				short num = (short)1933532398;
				short num2 = num;
				num = (short)1019960558;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1519321088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1588658177;
				if (num != 0)
				{
				}
				num = (short)2137391104;
				if (num != 0)
				{
				}
				this.homeModeChannel.Min = value;
			}
		}

		// Token: 0x170034B6 RID: 13494
		// (get) Token: 0x060065A1 RID: 26017 RVA: 0x005B0B18 File Offset: 0x005AED18
		// (set) Token: 0x060065A2 RID: 26018 RVA: 0x005B0BCC File Offset: 0x005AEDCC
		internal int HomeModeChannelMax
		{
			get
			{
				short num = (short)55811133;
				short num2 = num;
				num = (short)233544765;
				switch (num2 == num)
				{
				default:
				{
					num = (short)210829312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1938751488;
				if (num != 0)
				{
				}
				num = (short)82706433;
				if (num != 0)
				{
				}
				return this.homeModeChannel.Max;
			}
			set
			{
				short num = (short)2088203006;
				short num2 = num;
				num = (short)1401189118;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1449590784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)879886336;
				if (num != 0)
				{
				}
				num = (short)1108803585;
				if (num != 0)
				{
				}
				this.homeModeChannel.Max = value;
			}
		}

		// Token: 0x170034B7 RID: 13495
		// (get) Token: 0x060065A3 RID: 26019 RVA: 0x005B0C84 File Offset: 0x005AEE84
		// (set) Token: 0x060065A4 RID: 26020 RVA: 0x005B0D38 File Offset: 0x005AEF38
		internal int HomeModeChannelStep
		{
			get
			{
				short num = (short)149815297;
				if (num != 0)
				{
				}
				num = (short)377487360;
				short num2 = num;
				num = (short)361971559;
				short num3 = num;
				num = (short)1540964199;
				switch (num3 == num)
				{
				}
				num = (short)605749248;
				if (num != 0)
				{
				}
				return this.homeModeChannel.StepSize;
			}
			set
			{
				short num = (short)217431661;
				short num2 = num;
				num = (short)1772076653;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1188364288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)148176897;
				if (num != 0)
				{
				}
				num = (short)1981284352;
				if (num != 0)
				{
				}
				this.homeModeChannel.StepSize = value;
			}
		}

		// Token: 0x170034B8 RID: 13496
		// (get) Token: 0x060065A5 RID: 26021 RVA: 0x005B0DEC File Offset: 0x005AEFEC
		// (set) Token: 0x060065A6 RID: 26022 RVA: 0x005B0EA0 File Offset: 0x005AF0A0
		public bool HomeModeChannel_Applicable
		{
			get
			{
				short num = (short)504491753;
				short num2 = num;
				num = (short)1894772457;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1553465344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)693501953;
				if (num != 0)
				{
				}
				num = (short)1265369088;
				if (num != 0)
				{
				}
				return this.homeModeChannel.Applicable;
			}
			set
			{
				short num = (short)1296529889;
				short num2 = num;
				num = (short)1172535777;
				switch (num2 == num)
				{
				default:
				{
					num = (short)768999424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1044709377;
				if (num != 0)
				{
				}
				num = (short)1957101568;
				if (num != 0)
				{
				}
				this.homeModeChannel.Applicable = value;
			}
		}

		// Token: 0x170034B9 RID: 13497
		// (get) Token: 0x060065A7 RID: 26023 RVA: 0x005B0F58 File Offset: 0x005AF158
		// (set) Token: 0x060065A8 RID: 26024 RVA: 0x005B1010 File Offset: 0x005AF210
		public bool HomeModeChannel_Valid
		{
			get
			{
				short num = (short)1612276887;
				short num2 = num;
				num = (short)206267543;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1110179840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)263323649;
				if (num != 0)
				{
				}
				num = (short)1995898880;
				if (num != 0)
				{
				}
				return this.homeModeChannel.Valid;
			}
			set
			{
				short num = (short)1507176023;
				short num2 = num;
				num = (short)848866903;
				switch (num2 == num)
				{
				default:
				{
					num = (short)470679552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)947978241;
				if (num != 0)
				{
				}
				num = (short)529334272;
				if (num != 0)
				{
				}
				this.homeModeChannel.Valid = value;
			}
		}

		// Token: 0x170034BA RID: 13498
		// (get) Token: 0x060065A9 RID: 26025 RVA: 0x005B10C4 File Offset: 0x005AF2C4
		// (set) Token: 0x060065AA RID: 26026 RVA: 0x005B1178 File Offset: 0x005AF378
		public bool HomeModeChannel_Visible
		{
			get
			{
				short num = (short)1762192074;
				short num2 = num;
				num = (short)615181002;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1885405184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)166199297;
				if (num != 0)
				{
				}
				num = (short)826343424;
				if (num != 0)
				{
				}
				return this.homeModeChannel.Visible;
			}
			set
			{
				short num = (short)1509924082;
				short num2 = num;
				num = (short)1938201842;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1578500096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1068171265;
				if (num != 0)
				{
				}
				num = (short)1498808320;
				if (num != 0)
				{
				}
				this.homeModeChannel.Visible = value;
			}
		}

		// Token: 0x170034BB RID: 13499
		// (get) Token: 0x060065AB RID: 26027 RVA: 0x005B122C File Offset: 0x005AF42C
		// (set) Token: 0x060065AC RID: 26028 RVA: 0x005B12E0 File Offset: 0x005AF4E0
		public bool HomeModeChannel_Editable
		{
			get
			{
				short num = (short)1902103412;
				short num2 = num;
				num = (short)1468058484;
				switch (num2 == num)
				{
				default:
				{
					num = (short)177143808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)532807681;
				if (num != 0)
				{
				}
				num = (short)1798569984;
				if (num != 0)
				{
				}
				return this.homeModeChannel.Editable;
			}
			set
			{
				short num = (short)95623944;
				short num2 = num;
				num = (short)1979390728;
				switch (num2 == num)
				{
				}
				num = (short)1039794176;
				short num3 = num;
				num = (short)213843969;
				if (num != 0)
				{
				}
				num = (short)683147264;
				if (num != 0)
				{
				}
				this.homeModeChannel.Editable = value;
			}
		}

		// Token: 0x170034BC RID: 13500
		// (get) Token: 0x060065AD RID: 26029 RVA: 0x005B1398 File Offset: 0x005AF598
		internal string HomeModeChannel_UILabel
		{
			get
			{
				short num = (short)1053809212;
				short num2 = num;
				num = (short)1815468604;
				switch (num2 == num)
				{
				}
				num = (short)1768095744;
				short num3 = num;
				num = (short)1654194176;
				if (num != 0)
				{
				}
				num = (short)1726349313;
				if (num != 0)
				{
				}
				return this.homeModeChannel.UIName;
			}
		}

		// Token: 0x170034BD RID: 13501
		// (get) Token: 0x060065AE RID: 26030 RVA: 0x005B1450 File Offset: 0x005AF650
		// (set) Token: 0x060065AF RID: 26031 RVA: 0x005B1508 File Offset: 0x005AF708
		internal bool HomeModeChannel_HiddenStatic
		{
			get
			{
				short num = (short)1641334552;
				short num2 = num;
				num = (short)982107928;
				switch (num2 == num)
				{
				}
				num = (short)822804480;
				short num3 = num;
				num = (short)1709506561;
				if (num != 0)
				{
				}
				num = (short)919535616;
				if (num != 0)
				{
				}
				return this.homeModeChannel.HiddenStatic;
			}
			set
			{
				short num = (short)1806510869;
				short num2 = num;
				num = (short)1497115413;
				switch (num2 == num)
				{
				}
				num = (short)1725431808;
				short num3 = num;
				num = (short)1561133057;
				if (num != 0)
				{
				}
				num = (short)2111373312;
				if (num != 0)
				{
				}
				this.homeModeChannel.HiddenStatic = value;
			}
		}

		// Token: 0x170034BE RID: 13502
		// (get) Token: 0x060065B0 RID: 26032 RVA: 0x005B15BC File Offset: 0x005AF7BC
		// (set) Token: 0x060065B1 RID: 26033 RVA: 0x005B1670 File Offset: 0x005AF870
		internal bool HomeModeChannel_HiddenDynamic
		{
			get
			{
				short num = (short)1293757140;
				short num2 = num;
				num = (short)1703029460;
				switch (num2 == num)
				{
				}
				num = (short)2022244352;
				short num3 = num;
				num = (short)1699676161;
				if (num != 0)
				{
				}
				num = (short)226557952;
				if (num != 0)
				{
				}
				return this.homeModeChannel.HiddenDynamic;
			}
			set
			{
				short num = (short)1894325601;
				short num2 = num;
				num = (short)278666593;
				switch (num2 == num)
				{
				}
				num = (short)235864064;
				short num3 = num;
				num = (short)122486784;
				if (num != 0)
				{
				}
				num = (short)1511653377;
				if (num != 0)
				{
				}
				this.homeModeChannel.HiddenDynamic = value;
			}
		}

		// Token: 0x170034BF RID: 13503
		// (get) Token: 0x060065B2 RID: 26034 RVA: 0x005B1728 File Offset: 0x005AF928
		public bool HomeModeChannel_HasDiffs
		{
			get
			{
				short num = (short)503230024;
				short num2 = num;
				num = (short)693218888;
				switch (num2 == num)
				{
				}
				num = (short)1825177600;
				short num3 = num;
				num = (short)1597374465;
				if (num != 0)
				{
				}
				num = (short)1972830208;
				if (num != 0)
				{
				}
				return this.homeModeChannel._HasDiffs;
			}
		}

		// Token: 0x060065B3 RID: 26035 RVA: 0x005B17DC File Offset: 0x005AF9DC
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return result;
					case 1:
					{
						num2 = (short)110034945;
						if (num2 != 0)
						{
						}
						num2 = (short)254465113;
						short num3 = num2;
						num2 = (short)276091993;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)724369408;
							if (num2 != 0)
							{
							}
							result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
							num2 = (short)626982912;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						if (base.ParentRecset != null)
						{
							num2 = (short)1205010436;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 3:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)1498284032;
							short num4 = num2;
							num2 = (short)1743126529;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 4:
						num2 = (short)1757544451;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				IL_24:
				result = null;
				num2 = (short)1086652418;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return result;
		}

		// Token: 0x040026A0 RID: 9888
		private global::AcpBusinessLayer.AcpField<bool> radErgoWideHomeModeHomeModeSelection_A8202;

		// Token: 0x040026A1 RID: 9889
		private global::AcpBusinessLayer.AcpRecRefField radErgoWideHomeModeZone_A9691;

		// Token: 0x040026A2 RID: 9890
		private global::AcpBusinessLayer.AcpRangeField<int, string> homeModeChannel;
	}
}
