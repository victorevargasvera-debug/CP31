using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x020000A5 RID: 165
	[global::System.Serializable]
	public class StatusAlias : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060014A2 RID: 5282 RVA: 0x001344D0 File Offset: 0x001326D0
		public StatusAlias(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAliasInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x00134510 File Offset: 0x00132710
		protected StatusAlias(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x00134528 File Offset: 0x00132728
		public override void Init()
		{
			int a_ = 10;
			short num = (short)1409024000;
			short num2 = num;
			num = (short)1234186986;
			short num3 = num;
			num = (short)503984874;
			switch (num3 == num)
			{
			}
			num = (short)1925382145;
			if (num != 0)
			{
			}
			num = (short)1255866368;
			if (num != 0)
			{
			}
			this.trkSysStatusAliasStatusAliasEnable_A9195 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ蓖귘뫚꧜꫞鋠ꋢ觤軦裨飪뻬鯮郰蟲胴蓶룸韺铼黾爀䘂欄昆欈朊栌倎倐⨒␔⸖Ⱈ", a_), global::CommonResources.AcgResources.ID_STATUSALIASENABLE);
			this.trkSysStatusAliasStatusAliasEnable_A9195.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysStatusAliasStatusAliasEnable_A9195.DataTransferOrder = 14;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("飊만껎ꗐꛒꛔ飘럚드뻞鋠", a_);
			base.Id = 10173;
			base.UIName = global::CommonResources.AcgResources.ID_STATUSALIAS;
			base.DataTransferOrder = 7;
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x00134640 File Offset: 0x00132840
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)657402889;
			short num2 = num;
			num = (short)1248930825;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_95:
				num = (short)1549402112;
				short num3 = num;
				if (!global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					goto IL_1E1;
				}
				num = (short)1840513028;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)1064042496;
				if (num != 0)
				{
				}
				num = (short)1571291137;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					if (producerFields != null)
					{
						num = (short)1354891267;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E1;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_95;
					}
					continue;
				case 2:
					goto IL_132;
				case 3:
					num = (short)1554972678;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)760086528;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)22740993;
					if (num != 0)
					{
					}
					this.trkSysStatusAliasStatusAliasEnable_A9195 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷈맊ꛌ鳎꣐ꃒ蛔ꏖ룘꿚꣜곞ꃠ迢賤蛦髨룪駬軮藰蛲蛴뛶闸鋺鳼賾䐀洂搄攆攈渊刌与⠐−Ⱄ∖", a_), global::CommonResources.AcgResources.ID_STATUSALIASENABLE);
					this.trkSysStatusAliasStatusAliasEnable_A9195.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysStatusAliasStatusAliasEnable_A9195.DataTransferOrder = 14;
					num = (short)605356034;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷈맊ꛌ鳎꣐ꃒ蛔ꏖ룘꿚꣜곞ꃠ迢賤蛦髨룪駬軮藰蛲蛴뛶闸鋺鳼賾䐀洂搄攆攈渊刌与⠐−Ⱄ∖", a_)))
					{
						num = (short)1982398469;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E1;
				}
				goto IL_95;
			}
			IL_132:
			IL_1E1:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("髈뿊곌믎ꓐꃒ雖뗘닚볜곞", a_);
			base.Id = 10173;
			base.UIName = global::CommonResources.AcgResources.ID_STATUSALIAS;
			base.DataTransferOrder = 7;
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x00134860 File Offset: 0x00132A60
		public override void PopulateReferences()
		{
			short num = (short)439877632;
			short num2 = num;
			num = (short)1051704215;
			short num3 = num;
			num = (short)1959574423;
			switch (num3 == num)
			{
			}
			num = (short)1864564737;
			if (num != 0)
			{
			}
			num = (short)1206648832;
			if (num != 0)
			{
			}
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x0013490C File Offset: 0x00132B0C
		public override void DropReferences()
		{
			short num = (short)1594228736;
			short num2 = num;
			num = (short)775815169;
			if (num != 0)
			{
			}
			num = (short)477668832;
			short num3 = num;
			num = (short)1490134496;
			switch (num3 == num)
			{
			}
			num = (short)710410240;
			if (num != 0)
			{
			}
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x001349B8 File Offset: 0x00132BB8
		public override void SetConstraints()
		{
			short num = (short)933363712;
			short num2 = num;
			num = (short)1907882691;
			short num3 = num;
			num = (short)1375599299;
			switch (num3 == num)
			{
			}
			num = (short)1729757184;
			if (num != 0)
			{
			}
			num = (short)479592449;
			if (num != 0)
			{
			}
			this.trkSysStatusAliasStatusAliasEnable_A9195.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conSetMaxRecNumForTrunkingStatusAliasTable);
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x00134A78 File Offset: 0x00132C78
		public override void SetupDependencies()
		{
			short num = (short)635568128;
			short num2 = num;
			num = (short)700718294;
			short num3 = num;
			num = (short)1683954902;
			switch (num3 == num)
			{
			}
			num = (short)254279681;
			if (num != 0)
			{
			}
			num = (short)178651136;
			if (num != 0)
			{
			}
			(base.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysStatusAliasStatusAliasEnable_A9195);
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x060014AA RID: 5290 RVA: 0x00134B44 File Offset: 0x00132D44
		public bool HasDiffs
		{
			get
			{
				short num = (short)857604096;
				short num2 = num;
				num = (short)1305804801;
				if (num != 0)
				{
				}
				num = (short)1223932348;
				short num3 = num;
				num = (short)1086175676;
				switch (num3 == num)
				{
				}
				num = (short)686751744;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x00134BF4 File Offset: 0x00132DF4
		// (set) Token: 0x060014AC RID: 5292 RVA: 0x00134CAC File Offset: 0x00132EAC
		public bool TrkSysStatusAliasStatusAliasEnable_A9195Value
		{
			get
			{
				short num = (short)787152896;
				short num2 = num;
				num = (short)1485027368;
				short num3 = num;
				num = (short)46184488;
				switch (num3 == num)
				{
				}
				num = (short)531169280;
				if (num != 0)
				{
				}
				num = (short)1875443713;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasEnable_A9195.Value;
			}
			set
			{
				short num = (short)1054670848;
				short num2 = num;
				num = (short)54188530;
				short num3 = num;
				num = (short)50649586;
				switch (num3 == num)
				{
				}
				num = (short)1209925633;
				if (num != 0)
				{
				}
				num = (short)184287232;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasEnable_A9195.Value = value;
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x060014AD RID: 5293 RVA: 0x00134D64 File Offset: 0x00132F64
		public global::AcpBusinessLayer.AcpField<bool> TrkSysStatusAliasStatusAliasEnable_A9195
		{
			get
			{
				short num = (short)2136211456;
				short num2 = num;
				num = (short)590776746;
				short num3 = num;
				num = (short)571115946;
				switch (num3 == num)
				{
				}
				num = (short)1444610049;
				if (num != 0)
				{
				}
				num = (short)50659328;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasEnable_A9195;
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x060014AE RID: 5294 RVA: 0x00134E14 File Offset: 0x00133014
		// (set) Token: 0x060014AF RID: 5295 RVA: 0x00134ECC File Offset: 0x001330CC
		public bool TrkSysStatusAliasStatusAliasEnable_A9195_UIValue
		{
			get
			{
				short num = (short)1834876928;
				short num2 = num;
				num = (short)583165896;
				short num3 = num;
				num = (short)1164273608;
				switch (num3 == num)
				{
				}
				num = (short)743505920;
				if (num != 0)
				{
				}
				num = (short)370475009;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasEnable_A9195.Value;
			}
			set
			{
				short num = (short)606863360;
				short num2 = num;
				num = (short)885095594;
				short num3 = num;
				num = (short)197557418;
				switch (num3 == num)
				{
				}
				num = (short)1566179329;
				if (num != 0)
				{
				}
				num = (short)1529413632;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasEnable_A9195.Value = value;
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x00134F80 File Offset: 0x00133180
		// (set) Token: 0x060014B1 RID: 5297 RVA: 0x00135034 File Offset: 0x00133234
		public bool TrkSysStatusAliasStatusAliasEnable_A9195_Applicable
		{
			get
			{
				short num = (short)1951137792;
				short num2 = num;
				num = (short)921736336;
				short num3 = num;
				num = (short)714970256;
				switch (num3 == num)
				{
				}
				num = (short)544276480;
				if (num != 0)
				{
				}
				num = (short)516423681;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasEnable_A9195.Applicable;
			}
			set
			{
				short num = (short)68091904;
				short num2 = num;
				num = (short)2103809236;
				short num3 = num;
				num = (short)1781699796;
				switch (num3 == num)
				{
				}
				num = (short)387514369;
				if (num != 0)
				{
				}
				num = (short)363921408;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasEnable_A9195.Applicable = value;
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x060014B2 RID: 5298 RVA: 0x001350EC File Offset: 0x001332EC
		// (set) Token: 0x060014B3 RID: 5299 RVA: 0x001351A4 File Offset: 0x001333A4
		public bool TrkSysStatusAliasStatusAliasEnable_A9195_Valid
		{
			get
			{
				short num = (short)1758003200;
				short num2 = num;
				num = (short)455475201;
				if (num != 0)
				{
				}
				num = (short)1966695659;
				short num3 = num;
				num = (short)1634559211;
				switch (num3 == num)
				{
				}
				num = (short)937623552;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasEnable_A9195.Valid;
			}
			set
			{
				short num = (short)230359040;
				short num2 = num;
				num = (short)581777481;
				short num3 = num;
				num = (short)1736915017;
				switch (num3 == num)
				{
				}
				num = (short)370606081;
				if (num != 0)
				{
				}
				num = (short)750125056;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasEnable_A9195.Valid = value;
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x060014B4 RID: 5300 RVA: 0x0013525C File Offset: 0x0013345C
		// (set) Token: 0x060014B5 RID: 5301 RVA: 0x00135310 File Offset: 0x00133510
		public bool TrkSysStatusAliasStatusAliasEnable_A9195_Visible
		{
			get
			{
				short num = (short)298713088;
				short num2 = num;
				num = (short)2095178413;
				short num3 = num;
				num = (short)1184424621;
				switch (num3 == num)
				{
				}
				num = (short)1860567041;
				if (num != 0)
				{
				}
				num = (short)1137115136;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasEnable_A9195.Visible;
			}
			set
			{
				short num = (short)1393688576;
				short num2 = num;
				num = (short)732682836;
				short num3 = num;
				num = (short)527227476;
				switch (num3 == num)
				{
				}
				num = (short)743768065;
				if (num != 0)
				{
				}
				num = (short)1584070656;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasEnable_A9195.Visible = value;
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x060014B6 RID: 5302 RVA: 0x001353C4 File Offset: 0x001335C4
		// (set) Token: 0x060014B7 RID: 5303 RVA: 0x00135478 File Offset: 0x00133678
		public bool TrkSysStatusAliasStatusAliasEnable_A9195_Editable
		{
			get
			{
				short num = (short)1236533248;
				short num2 = num;
				num = (short)970542060;
				short num3 = num;
				num = (short)468470764;
				switch (num3 == num)
				{
				}
				num = (short)827064321;
				if (num != 0)
				{
				}
				num = (short)1906376704;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasEnable_A9195.Editable;
			}
			set
			{
				short num = (short)1001127936;
				short num2 = num;
				num = (short)449333719;
				short num3 = num;
				num = (short)457525719;
				switch (num3 == num)
				{
				}
				num = (short)1612251136;
				if (num != 0)
				{
				}
				num = (short)2119237633;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasEnable_A9195.Editable = value;
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x060014B8 RID: 5304 RVA: 0x0013552C File Offset: 0x0013372C
		internal string TrkSysStatusAliasStatusAliasEnable_A9195_UILabel
		{
			get
			{
				short num = (short)1833304064;
				short num2 = num;
				num = (short)231777276;
				short num3 = num;
				num = (short)659334140;
				switch (num3 == num)
				{
				}
				num = (short)440270849;
				if (num != 0)
				{
				}
				num = (short)280297472;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasEnable_A9195.UIName;
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x060014B9 RID: 5305 RVA: 0x001355DC File Offset: 0x001337DC
		// (set) Token: 0x060014BA RID: 5306 RVA: 0x00135690 File Offset: 0x00133890
		internal bool TrkSysStatusAliasStatusAliasEnable_A9195_HiddenStatic
		{
			get
			{
				short num = (short)744423424;
				short num2 = num;
				num = (short)1542305934;
				short num3 = num;
				num = (short)1402124430;
				switch (num3 == num)
				{
				}
				num = (short)61472769;
				if (num != 0)
				{
				}
				num = (short)556990464;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasEnable_A9195.HiddenStatic;
			}
			set
			{
				short num = (short)549257216;
				short num2 = num;
				num = (short)1325842627;
				short num3 = num;
				num = (short)124305603;
				switch (num3 == num)
				{
				}
				num = (short)226033665;
				if (num != 0)
				{
				}
				num = (short)1752236032;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasEnable_A9195.HiddenStatic = value;
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x060014BB RID: 5307 RVA: 0x00135748 File Offset: 0x00133948
		// (set) Token: 0x060014BC RID: 5308 RVA: 0x00135800 File Offset: 0x00133A00
		internal bool TrkSysStatusAliasStatusAliasEnable_A9195_HiddenDynamic
		{
			get
			{
				short num = (short)2130771968;
				short num2 = num;
				num = (short)295829505;
				if (num != 0)
				{
				}
				num = (short)1117136777;
				short num3 = num;
				num = (short)669067145;
				switch (num3 == num)
				{
				}
				num = (short)1336344576;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasEnable_A9195.HiddenDynamic;
			}
			set
			{
				short num = (short)2139095040;
				short num2 = num;
				num = (short)389917888;
				short num3 = num;
				num = (short)1522379968;
				switch (num3 == num)
				{
				}
				num = (short)1547501568;
				if (num != 0)
				{
				}
				num = (short)1943797761;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasEnable_A9195.HiddenDynamic = value;
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x060014BD RID: 5309 RVA: 0x001358B4 File Offset: 0x00133AB4
		public bool TrkSysStatusAliasStatusAliasEnable_A9195_HasDiffs
		{
			get
			{
				short num = (short)1489108992;
				short num2 = num;
				num = (short)396820481;
				if (num != 0)
				{
				}
				num = (short)508582046;
				short num3 = num;
				num = (short)1293572254;
				switch (num3 == num)
				{
				}
				num = (short)911736832;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasEnable_A9195._HasDiffs;
			}
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x00135968 File Offset: 0x00133B68
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)2001534976;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_33:
				switch (num3)
				{
				case 0:
					if (base.ParentRecset != null)
					{
						num = (short)1565917186;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)401539075;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					num = (short)948240385;
					if (num != 0)
					{
					}
					num = (short)813563905;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)810734114;
					short num4 = num;
					num = (short)1863504418;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)2109014016;
						if (num != 0)
						{
						}
						num = (short)1884487684;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					return result;
				}
				goto IL_4D;
			}
			return result;
			IL_4D:
			result = null;
			num = (short)1557725184;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x04000474 RID: 1140
		private global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAliasInnerRecset innerRecset;

		// Token: 0x04000475 RID: 1141
		private global::AcpBusinessLayer.AcpField<bool> trkSysStatusAliasStatusAliasEnable_A9195;
	}
}
