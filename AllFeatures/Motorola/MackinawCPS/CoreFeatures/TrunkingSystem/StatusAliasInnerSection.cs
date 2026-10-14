using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x020000A8 RID: 168
	[global::System.Serializable]
	public class StatusAliasInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060014D2 RID: 5330 RVA: 0x00136924 File Offset: 0x00134B24
		public StatusAliasInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x00136940 File Offset: 0x00134B40
		protected StatusAliasInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x00136958 File Offset: 0x00134B58
		public override void Init()
		{
			int a_ = 10;
			short num = (short)1357337392;
			short num2 = num;
			num = (short)1601983280;
			switch (num2 == num)
			{
			}
			num = (short)188416000;
			short num3 = num;
			num = (short)1369505793;
			if (num != 0)
			{
			}
			num = (short)1961426944;
			if (num != 0)
			{
			}
			this.trkSysStatusAliasStatusAliasText_A9193 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_STATUS1, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ蓖귘뫚꧜꫞鋠ꋢ觤軦裨飪뻬鯮郰蟲胴蓶룸韺铼黾爀圂怄缆紈吊䰌㘎‐⨒☔", a_), global::CommonResources.AcgResources.ID_STATUSALIASTEXT, 14);
			this.trkSysStatusAliasStatusAliasText_A9193.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysStatusAliasStatusAliasText_A9193.DataTransferOrder = 73;
			this.trkSysStatusAlias_A24070 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ蓖귘뫚꧜꫞鋠ꋢ觤軦裨飪달껮쏰쟲열샶째", a_), global::CommonResources.AcgResources.ID_POSITION);
			this.trkSysStatusAlias_A24070.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysStatusAlias_A24070.DataTransferOrder = -1;
			this.trkSysStatusAliasStatusAliasNumber_A9190 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ蓖귘뫚꧜꫞鋠ꋢ觤軦裨飪뻬鯮郰蟲胴蓶룸韺铼黾爀䴂瀄樆欈渊缌倎倐⨒␔⸖⤘", a_), global::CommonResources.AcgResources.ID_STATUSALIASNUMBER, 1, 16, null, null, 0, 1);
			this.trkSysStatusAliasStatusAliasNumber_A9190.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysStatusAliasStatusAliasNumber_A9190.DataTransferOrder = 94;
			this.trkSysStatusAliasStatusAliasNumber_A9190.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("飊만껎ꗐꛒꛔ飘럚드뻞鋠", a_);
			base.Id = 10174;
			base.UIName = global::CommonResources.AcgResources.ID_STATUSALIAS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00136B00 File Offset: 0x00134D00
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)998113280;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				case 1:
					if (producerFields != null)
					{
						num = (short)279773190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_353;
				case 2:
					goto IL_223;
				case 3:
					this.trkSysStatusAliasStatusAliasNumber_A9190 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ蟓ꋕ맗껙꧛귝ꇟ軡跣蟥鯧맩飫迭蓯蟱蟳럵铷鏹鷻跽仿省椃搅洇砉匋伍⤏⌑ⴓ☕", a_), global::CommonResources.AcgResources.ID_STATUSALIASNUMBER, null, null, 0, 1);
					this.trkSysStatusAliasStatusAliasNumber_A9190.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysStatusAliasStatusAliasNumber_A9190.DataTransferOrder = 94;
					this.trkSysStatusAliasStatusAliasNumber_A9190.ShowHexValue = false;
					num = (short)1338179585;
					if (num != 0)
					{
					}
					num = (short)1055457282;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_D9;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ蟓ꋕ맗껙꧛귝ꇟ軡跣蟥鯧맩飫迭蓯蟱蟳럵铷鏹鷻跽哿朁簃爅圇䬉㔋㼍⤏ℑ", a_)))
					{
						num = (short)1256259594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D9;
				case 6:
					num = (short)2056585221;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ蟓ꋕ맗껙꧛귝ꇟ軡跣蟥鯧뗩귫\udced쓯싱쏳웵", a_)))
					{
						num = (short)1297154059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_262;
				case 8:
					num = (short)345112577;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_262;
				case 10:
					this.trkSysStatusAliasStatusAliasText_A9193 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_STATUS1, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ蟓ꋕ맗껙꧛귝ꇟ軡跣蟥鯧맩飫迭蓯蟱蟳럵铷鏹鷻跽哿朁簃爅圇䬉㔋㼍⤏ℑ", a_), global::CommonResources.AcgResources.ID_STATUSALIASTEXT, 14);
					this.trkSysStatusAliasStatusAliasText_A9193.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysStatusAliasStatusAliasText_A9193.DataTransferOrder = 73;
					num = (short)652410884;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					this.trkSysStatusAlias_A24070 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ蟓ꋕ맗껙꧛귝ꇟ軡跣蟥鯧뗩귫\udced쓯싱쏳웵", a_), global::CommonResources.AcgResources.ID_POSITION);
					this.trkSysStatusAlias_A24070.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysStatusAlias_A24070.DataTransferOrder = -1;
					num = (short)1495269385;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
				{
					num = (short)49716894;
					short num3 = num;
					num = (short)367763102;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1944059904;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ蟓ꋕ맗껙꧛귝ꇟ軡跣蟥鯧맩飫迭蓯蟱蟳럵铷鏹鷻跽仿省椃搅洇砉匋伍⤏⌑ⴓ☕", a_)))
						{
							num = (short)332398595;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_353;
					}
					break;
				}
				}
				IL_63:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)66912264;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_D9:
				num = (short)115015680;
				short num4 = num;
				num = (short)2012741639;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_262:
				num = (short)709623820;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_223:
			IL_353:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鯇뻉귋뫍ꗏꇑ韕듗동뷛귝", a_);
			base.Id = 10174;
			base.UIName = global::CommonResources.AcgResources.ID_STATUSALIAS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x00136E94 File Offset: 0x00135094
		public override void PopulateReferences()
		{
			short num = (short)1126916109;
			short num2 = num;
			num = (short)549347341;
			switch (num2 == num)
			{
			}
			num = (short)1292369920;
			short num3 = num;
			num = (short)1411776513;
			if (num != 0)
			{
			}
			num = (short)1071906816;
			if (num != 0)
			{
			}
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x00136F40 File Offset: 0x00135140
		public override void DropReferences()
		{
			short num = (short)1425464550;
			short num2 = num;
			num = (short)713678054;
			switch (num2 == num)
			{
			}
			num = (short)696254464;
			short num3 = num;
			num = (short)1276575745;
			if (num != 0)
			{
			}
			num = (short)112721920;
			if (num != 0)
			{
			}
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x00136FEC File Offset: 0x001351EC
		public override void SetConstraints()
		{
			short num = (short)937279895;
			short num2 = num;
			num = (short)1027850647;
			switch (num2 == num)
			{
			}
			num = (short)2099904512;
			short num3 = num;
			num = (short)1079902209;
			if (num != 0)
			{
			}
			num = (short)940441600;
			if (num != 0)
			{
			}
			this.trkSysStatusAliasStatusAliasText_A9193.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConBoolTrkSysTrkStsAlsIndicatorIsEnable);
			this.trkSysStatusAlias_A24070.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.trkSysStatusAliasStatusAliasNumber_A9190.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConBoolTrkSysTrkStsAlsIndicatorIsEnable);
			this.trkSysStatusAliasStatusAliasNumber_A9190.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conSetMinAndMaxForStatusNumBasedOnSystemType);
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x001370F4 File Offset: 0x001352F4
		public override void SetupDependencies()
		{
			short num = (short)1990137004;
			short num2 = num;
			num = (short)1611797676;
			switch (num2 == num)
			{
			}
			num = (short)103350272;
			short num3 = num;
			num = (short)1591345153;
			if (num != 0)
			{
			}
			num = (short)1491337216;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
			trunkingSystem.StatusAlias.TrkSysStatusAliasStatusAliasEnable_A9195.AddDependentObject(this.trkSysStatusAliasStatusAliasText_A9193);
			trunkingSystem.StatusAlias.TrkSysStatusAliasStatusAliasEnable_A9195.AddDependentObject(this.trkSysStatusAliasStatusAliasNumber_A9190);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysStatusAliasStatusAliasNumber_A9190);
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x060014DA RID: 5338 RVA: 0x001371F8 File Offset: 0x001353F8
		public bool HasDiffs
		{
			get
			{
				short num = (short)2001624990;
				short num2 = num;
				num = (short)133259166;
				switch (num2 == num)
				{
				}
				num = (short)1946419200;
				short num3 = num;
				num = (short)23592961;
				if (num != 0)
				{
				}
				num = (short)544669696;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x001372A8 File Offset: 0x001354A8
		// (set) Token: 0x060014DC RID: 5340 RVA: 0x0013735C File Offset: 0x0013555C
		public string TrkSysStatusAliasStatusAliasText_A9193Value
		{
			get
			{
				short num = (short)1729129034;
				short num2 = num;
				num = (short)1731095114;
				switch (num2 == num)
				{
				}
				num = (short)950534144;
				short num3 = num;
				num = (short)1218707457;
				if (num != 0)
				{
				}
				num = (short)1646067712;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasText_A9193.Value;
			}
			set
			{
				short num = (short)1027673448;
				short num2 = num;
				num = (short)1397099880;
				switch (num2 == num)
				{
				}
				num = (short)2105671680;
				short num3 = num;
				num = (short)1809514497;
				if (num != 0)
				{
				}
				num = (short)1865285632;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasText_A9193.Value = value;
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x00137410 File Offset: 0x00135610
		public global::AcpBusinessLayer.AcpField<string> TrkSysStatusAliasStatusAliasText_A9193
		{
			get
			{
				short num = (short)2120994757;
				short num2 = num;
				num = (short)181456837;
				switch (num2 == num)
				{
				}
				num = (short)527761408;
				short num3 = num;
				num = (short)1786380289;
				if (num != 0)
				{
				}
				num = (short)39518208;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasText_A9193;
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x060014DE RID: 5342 RVA: 0x001374C0 File Offset: 0x001356C0
		// (set) Token: 0x060014DF RID: 5343 RVA: 0x00137574 File Offset: 0x00135774
		public string TrkSysStatusAliasStatusAliasText_A9193_UIValue
		{
			get
			{
				short num = (short)410396145;
				short num2 = num;
				num = (short)75245041;
				switch (num2 == num)
				{
				}
				num = (short)1637810176;
				short num3 = num;
				num = (short)1716322304;
				if (num != 0)
				{
				}
				num = (short)2110193665;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasText_A9193.Value;
			}
			set
			{
				short num = (short)996892503;
				short num2 = num;
				num = (short)1986223959;
				switch (num2 == num)
				{
				}
				num = (short)1221459968;
				short num3 = num;
				num = (short)636551168;
				if (num != 0)
				{
				}
				num = (short)1205338113;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasText_A9193.Value = value;
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x060014E0 RID: 5344 RVA: 0x00137628 File Offset: 0x00135828
		// (set) Token: 0x060014E1 RID: 5345 RVA: 0x001376D8 File Offset: 0x001358D8
		public bool TrkSysStatusAliasStatusAliasText_A9193_Applicable
		{
			get
			{
				short num = (short)1794678998;
				short num2 = num;
				num = (short)914792662;
				switch (num2 == num)
				{
				}
				num = (short)1156907008;
				short num3 = num;
				num = (short)1981284353;
				if (num != 0)
				{
				}
				num = (short)434700288;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasText_A9193.Applicable;
			}
			set
			{
				short num = (short)921336411;
				short num2 = num;
				num = (short)793213531;
				switch (num2 == num)
				{
				}
				num = (short)768671744;
				short num3 = num;
				num = (short)1935212545;
				if (num != 0)
				{
				}
				num = (short)1763901440;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasText_A9193.Applicable = value;
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x060014E2 RID: 5346 RVA: 0x0013778C File Offset: 0x0013598C
		// (set) Token: 0x060014E3 RID: 5347 RVA: 0x00137840 File Offset: 0x00135A40
		public bool TrkSysStatusAliasStatusAliasText_A9193_Valid
		{
			get
			{
				short num = (short)550333253;
				short num2 = num;
				num = (short)1771924293;
				switch (num2 == num)
				{
				}
				num = (short)1091502080;
				short num3 = num;
				num = (short)1072758785;
				if (num != 0)
				{
				}
				num = (short)2101411840;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasText_A9193.Valid;
			}
			set
			{
				short num = (short)880345089;
				if (num != 0)
				{
				}
				num = (short)1490261005;
				short num2 = num;
				num = (short)173118477;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1934950400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1121386496;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasText_A9193.Valid = value;
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x060014E4 RID: 5348 RVA: 0x001378F8 File Offset: 0x00135AF8
		// (set) Token: 0x060014E5 RID: 5349 RVA: 0x001379AC File Offset: 0x00135BAC
		public bool TrkSysStatusAliasStatusAliasText_A9193_Visible
		{
			get
			{
				short num = (short)900726785;
				if (num != 0)
				{
				}
				num = (short)227670304;
				short num2 = num;
				num = (short)1052768544;
				switch (num2 == num)
				{
				default:
				{
					num = (short)149291008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)638779392;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasText_A9193.Visible;
			}
			set
			{
				short num = (short)1760404005;
				short num2 = num;
				num = (short)962961957;
				switch (num2 == num)
				{
				}
				num = (short)1774321664;
				short num3 = num;
				num = (short)476119040;
				if (num != 0)
				{
				}
				num = (short)42139649;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasText_A9193.Visible = value;
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x00137A64 File Offset: 0x00135C64
		// (set) Token: 0x060014E7 RID: 5351 RVA: 0x00137B1C File Offset: 0x00135D1C
		public bool TrkSysStatusAliasStatusAliasText_A9193_Editable
		{
			get
			{
				short num = (short)1301695156;
				short num2 = num;
				num = (short)1092307636;
				switch (num2 == num)
				{
				}
				num = (short)1067188224;
				short num3 = num;
				num = (short)559742977;
				if (num != 0)
				{
				}
				num = (short)872153088;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasText_A9193.Editable;
			}
			set
			{
				short num = (short)1699908873;
				short num2 = num;
				num = (short)485920009;
				switch (num2 == num)
				{
				}
				num = (short)493617152;
				short num3 = num;
				num = (short)1933180928;
				if (num != 0)
				{
				}
				num = (short)230752257;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasText_A9193.Editable = value;
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x060014E8 RID: 5352 RVA: 0x00137BD4 File Offset: 0x00135DD4
		internal string TrkSysStatusAliasStatusAliasText_A9193_UILabel
		{
			get
			{
				short num = (short)754312571;
				short num2 = num;
				num = (short)1680991611;
				switch (num2 == num)
				{
				}
				num = (short)752287744;
				short num3 = num;
				num = (short)1135411201;
				if (num != 0)
				{
				}
				num = (short)1809448960;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasText_A9193.UIName;
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x060014E9 RID: 5353 RVA: 0x00137C88 File Offset: 0x00135E88
		// (set) Token: 0x060014EA RID: 5354 RVA: 0x00137D3C File Offset: 0x00135F3C
		internal bool TrkSysStatusAliasStatusAliasText_A9193_HiddenStatic
		{
			get
			{
				short num = (short)1522932078;
				short num2 = num;
				num = (short)803674478;
				switch (num2 == num)
				{
				}
				num = (short)1684209664;
				short num3 = num;
				num = (short)1174732801;
				if (num != 0)
				{
				}
				num = (short)1105068032;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasText_A9193.HiddenStatic;
			}
			set
			{
				short num = (short)989732056;
				short num2 = num;
				num = (short)1587485912;
				switch (num2 == num)
				{
				default:
				{
					num = (short)833486848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)30736385;
				if (num != 0)
				{
				}
				num = (short)313327616;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasText_A9193.HiddenStatic = value;
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x060014EB RID: 5355 RVA: 0x00137DF4 File Offset: 0x00135FF4
		// (set) Token: 0x060014EC RID: 5356 RVA: 0x00137EAC File Offset: 0x001360AC
		internal bool TrkSysStatusAliasStatusAliasText_A9193_HiddenDynamic
		{
			get
			{
				short num = (short)1401677196;
				short num2 = num;
				num = (short)449045900;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1845690368;
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
				num = (short)1750794240;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasText_A9193.HiddenDynamic;
			}
			set
			{
				short num = (short)1432203285;
				short num2 = num;
				num = (short)1962192917;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2091450368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2094530560;
				if (num != 0)
				{
				}
				num = (short)1506279425;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasText_A9193.HiddenDynamic = value;
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x00137F64 File Offset: 0x00136164
		public bool TrkSysStatusAliasStatusAliasText_A9193_HasDiffs
		{
			get
			{
				short num = (short)1755113547;
				short num2 = num;
				num = (short)1185474635;
				switch (num2 == num)
				{
				default:
				{
					num = (short)236584960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)561774593;
				if (num != 0)
				{
				}
				num = (short)291897344;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasText_A9193._HasDiffs;
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x00138014 File Offset: 0x00136214
		// (set) Token: 0x060014EF RID: 5359 RVA: 0x001380C8 File Offset: 0x001362C8
		public string TrkSysStatusAlias_A24070Value
		{
			get
			{
				short num = (short)251572071;
				short num2 = num;
				num = (short)394899303;
				switch (num2 == num)
				{
				default:
				{
					num = (short)789315584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2008940544;
				if (num != 0)
				{
				}
				num = (short)1711734785;
				if (num != 0)
				{
				}
				return this.trkSysStatusAlias_A24070.Value;
			}
			set
			{
				short num = (short)255459328;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 1:
						this.trkSysStatusAlias_A24070.Value = value;
						num = (short)180420610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_C9;
					}
					IL_30:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						return;
					}
					num = (short)1495693288;
					short num3 = num;
					num = (short)834369512;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)2085683200;
						if (num != 0)
						{
						}
						num = (short)1555496961;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_C9:
				num = (short)140967937;
				if (num != 0)
				{
				}
				num = (short)618856448;
				short num4 = num;
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x001381F4 File Offset: 0x001363F4
		// (set) Token: 0x060014F1 RID: 5361 RVA: 0x001382A4 File Offset: 0x001364A4
		public string TrkSysStatusAlias_A24070_UIValue
		{
			get
			{
				short num = (short)1017656036;
				short num2 = num;
				num = (short)1212166884;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1987903488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)811794433;
				if (num != 0)
				{
				}
				num = (short)1274806272;
				if (num != 0)
				{
				}
				return this.trkSysStatusAlias_A24070.Value;
			}
			set
			{
				short num = (short)1389895617;
				short num2 = num;
				num = (short)166600641;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1451294720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)878903297;
				if (num != 0)
				{
				}
				num = (short)944766976;
				if (num != 0)
				{
				}
				this.trkSysStatusAlias_A24070.Value = value;
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x060014F2 RID: 5362 RVA: 0x00138358 File Offset: 0x00136558
		public global::AcpBusinessLayer.AcpKeyField TrkSysStatusAlias_A24070
		{
			get
			{
				short num = (short)1041442506;
				short num2 = num;
				num = (short)171452106;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1820393472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1974927360;
				if (num != 0)
				{
				}
				num = (short)308609025;
				if (num != 0)
				{
				}
				return this.trkSysStatusAlias_A24070;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x060014F3 RID: 5363 RVA: 0x00138408 File Offset: 0x00136608
		// (set) Token: 0x060014F4 RID: 5364 RVA: 0x001384C0 File Offset: 0x001366C0
		public bool TrkSysStatusAlias_A24070_Applicable
		{
			get
			{
				short num = (short)1717977279;
				short num2 = num;
				num = (short)1640251583;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1988624384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)678363137;
				if (num != 0)
				{
				}
				num = (short)1295581184;
				if (num != 0)
				{
				}
				return this.trkSysStatusAlias_A24070.Applicable;
			}
			set
			{
				short num = (short)1962147841;
				if (num != 0)
				{
				}
				num = (short)1568997376;
				short num2 = num;
				num = (short)1711086795;
				short num3 = num;
				num = (short)34348235;
				switch (num3 == num)
				{
				}
				num = (short)1515651072;
				if (num != 0)
				{
				}
				this.trkSysStatusAlias_A24070.Applicable = value;
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x00138574 File Offset: 0x00136774
		// (set) Token: 0x060014F6 RID: 5366 RVA: 0x00138628 File Offset: 0x00136828
		public bool TrkSysStatusAlias_A24070_Valid
		{
			get
			{
				short num = (short)1488965810;
				short num2 = num;
				num = (short)91082930;
				switch (num2 == num)
				{
				default:
				{
					num = (short)521469952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)966524929;
				if (num != 0)
				{
				}
				num = (short)364118016;
				if (num != 0)
				{
				}
				return this.trkSysStatusAlias_A24070.Valid;
			}
			set
			{
				short num = (short)1898840065;
				if (num != 0)
				{
				}
				num = (short)657129472;
				short num2 = num;
				num = (short)1938842973;
				short num3 = num;
				num = (short)952132957;
				switch (num3 == num)
				{
				}
				num = (short)1073938432;
				if (num != 0)
				{
				}
				this.trkSysStatusAlias_A24070.Valid = value;
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x060014F7 RID: 5367 RVA: 0x001386DC File Offset: 0x001368DC
		// (set) Token: 0x060014F8 RID: 5368 RVA: 0x00138790 File Offset: 0x00136990
		public bool TrkSysStatusAlias_A24070_Visible
		{
			get
			{
				short num = (short)711074341;
				short num2 = num;
				num = (short)1242505765;
				switch (num2 == num)
				{
				default:
				{
					num = (short)387448832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2110717953;
				if (num != 0)
				{
				}
				num = (short)137166848;
				if (num != 0)
				{
				}
				return this.trkSysStatusAlias_A24070.Visible;
			}
			set
			{
				short num = (short)1157744507;
				short num2 = num;
				num = (short)177391483;
				switch (num2 == num)
				{
				default:
				{
					num = (short)939261952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1057751040;
				if (num != 0)
				{
				}
				num = (short)881983489;
				if (num != 0)
				{
				}
				this.trkSysStatusAlias_A24070.Visible = value;
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x00138844 File Offset: 0x00136A44
		// (set) Token: 0x060014FA RID: 5370 RVA: 0x001388F8 File Offset: 0x00136AF8
		public bool TrkSysStatusAlias_A24070_Editable
		{
			get
			{
				short num = (short)492031961;
				short num2 = num;
				num = (short)1372704729;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1768488960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1169227777;
				if (num != 0)
				{
				}
				num = (short)93388800;
				if (num != 0)
				{
				}
				return this.trkSysStatusAlias_A24070.Editable;
			}
			set
			{
				short num = (short)236361479;
				short num2 = num;
				num = (short)1777506055;
				switch (num2 == num)
				{
				default:
				{
					num = (short)287047680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1178468353;
				if (num != 0)
				{
				}
				num = (short)1900019712;
				if (num != 0)
				{
				}
				this.trkSysStatusAlias_A24070.Editable = value;
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x001389AC File Offset: 0x00136BAC
		internal string TrkSysStatusAlias_A24070_UILabel
		{
			get
			{
				short num = (short)588168565;
				short num2 = num;
				num = (short)1069333877;
				switch (num2 == num)
				{
				default:
				{
					num = (short)794427392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1924202497;
				if (num != 0)
				{
				}
				num = (short)1144389632;
				if (num != 0)
				{
				}
				return this.trkSysStatusAlias_A24070.UIName;
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x00138A60 File Offset: 0x00136C60
		// (set) Token: 0x060014FD RID: 5373 RVA: 0x00138B18 File Offset: 0x00136D18
		internal bool TrkSysStatusAlias_A24070_HiddenStatic
		{
			get
			{
				short num = (short)252038420;
				short num2 = num;
				num = (short)1202703636;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1179516928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)565772288;
				if (num != 0)
				{
				}
				num = (short)708444161;
				if (num != 0)
				{
				}
				return this.trkSysStatusAlias_A24070.HiddenStatic;
			}
			set
			{
				short num = (short)386072577;
				if (num != 0)
				{
				}
				num = (short)973668352;
				short num2 = num;
				num = (short)1872848994;
				short num3 = num;
				num = (short)392718434;
				switch (num3 == num)
				{
				}
				num = (short)2096365568;
				if (num != 0)
				{
				}
				this.trkSysStatusAlias_A24070.HiddenStatic = value;
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x00138BD0 File Offset: 0x00136DD0
		// (set) Token: 0x060014FF RID: 5375 RVA: 0x00138C84 File Offset: 0x00136E84
		internal bool TrkSysStatusAlias_A24070_HiddenDynamic
		{
			get
			{
				short num = (short)76788507;
				short num2 = num;
				num = (short)1001698075;
				switch (num2 == num)
				{
				default:
				{
					num = (short)849084416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)95944705;
				if (num != 0)
				{
				}
				num = (short)1122369536;
				if (num != 0)
				{
				}
				return this.trkSysStatusAlias_A24070.HiddenDynamic;
			}
			set
			{
				short num = (short)1116773643;
				short num2 = num;
				num = (short)852532491;
				switch (num2 == num)
				{
				default:
				{
					num = (short)643760128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1901854721;
				if (num != 0)
				{
				}
				num = (short)475922432;
				if (num != 0)
				{
				}
				this.trkSysStatusAlias_A24070.HiddenDynamic = value;
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x00138D3C File Offset: 0x00136F3C
		public bool TrkSysStatusAlias_A24070_HasDiffs
		{
			get
			{
				short num = (short)90659914;
				short num2 = num;
				num = (short)1947294794;
				switch (num2 == num)
				{
				default:
				{
					num = (short)747503616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)883884033;
				if (num != 0)
				{
				}
				num = (short)922550272;
				if (num != 0)
				{
				}
				return this.trkSysStatusAlias_A24070._HasDiffs;
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06001501 RID: 5377 RVA: 0x00138DEC File Offset: 0x00136FEC
		// (set) Token: 0x06001502 RID: 5378 RVA: 0x00138EA8 File Offset: 0x001370A8
		public int TrkSysStatusAliasStatusAliasNumber_A9190Value
		{
			get
			{
				short num = (short)716008766;
				short num2 = num;
				num = (short)1531407678;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1487011840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1642725376;
				if (num != 0)
				{
				}
				num = (short)1946681345;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasNumber_A9190.Value;
			}
			set
			{
				short num = (short)2099317614;
				short num2 = num;
				num = (short)1893862254;
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
				num = (short)851969;
				if (num != 0)
				{
				}
				num = (short)509214720;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasNumber_A9190.Value = value;
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06001503 RID: 5379 RVA: 0x00138F5C File Offset: 0x0013715C
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysStatusAliasStatusAliasNumber_A9190
		{
			get
			{
				short num = (short)428802049;
				if (num != 0)
				{
				}
				num = (short)1298989056;
				short num2 = num;
				num = (short)2136107792;
				short num3 = num;
				num = (short)359623440;
				switch (num3 == num)
				{
				}
				num = (short)1463681024;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasNumber_A9190;
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x00139010 File Offset: 0x00137210
		// (set) Token: 0x06001505 RID: 5381 RVA: 0x001390C4 File Offset: 0x001372C4
		public string TrkSysStatusAliasStatusAliasNumber_A9190_UIValue
		{
			get
			{
				short num = (short)246055357;
				short num2 = num;
				num = (short)306807229;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1947402240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1794048001;
				if (num != 0)
				{
				}
				num = (short)517668864;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasNumber_A9190.UIValue;
			}
			set
			{
				short num = (short)1901293911;
				short num2 = num;
				num = (short)1046835543;
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
				num = (short)197787648;
				if (num != 0)
				{
				}
				num = (short)1886715905;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasNumber_A9190.UIValue = value;
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x0013917C File Offset: 0x0013737C
		// (set) Token: 0x06001507 RID: 5383 RVA: 0x00139230 File Offset: 0x00137430
		internal int TrkSysStatusAliasStatusAliasNumber_A9190Min
		{
			get
			{
				short num = (short)815581643;
				short num2 = num;
				num = (short)1066125771;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1826684928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)579272705;
				if (num != 0)
				{
				}
				num = (short)1063845888;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasNumber_A9190.Min;
			}
			set
			{
				short num = (short)824840548;
				short num2 = num;
				num = (short)863441252;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1256587264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)367722496;
				if (num != 0)
				{
				}
				num = (short)392626177;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasNumber_A9190.Min = value;
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x001392E8 File Offset: 0x001374E8
		// (set) Token: 0x06001509 RID: 5385 RVA: 0x001393A0 File Offset: 0x001375A0
		internal int TrkSysStatusAliasStatusAliasNumber_A9190Max
		{
			get
			{
				short num = (short)2053750904;
				short num2 = num;
				num = (short)1284423800;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1317011456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1958871041;
				if (num != 0)
				{
				}
				num = (short)1168572416;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasNumber_A9190.Max;
			}
			set
			{
				short num = (short)1612709889;
				if (num != 0)
				{
				}
				num = (short)1721958400;
				short num2 = num;
				num = (short)1484496898;
				short num3 = num;
				num = (short)650092546;
				switch (num3 == num)
				{
				}
				num = (short)431030272;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasNumber_A9190.Max = value;
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x00139454 File Offset: 0x00137654
		// (set) Token: 0x0600150B RID: 5387 RVA: 0x0013950C File Offset: 0x0013770C
		internal int TrkSysStatusAliasStatusAliasNumber_A9190Step
		{
			get
			{
				short num = (short)835125249;
				if (num != 0)
				{
				}
				num = (short)1677328384;
				short num2 = num;
				num = (short)141094349;
				short num3 = num;
				num = (short)829287885;
				switch (num3 == num)
				{
				}
				num = (short)734855168;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasNumber_A9190.StepSize;
			}
			set
			{
				short num = (short)607467970;
				short num2 = num;
				num = (short)127613378;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1627324416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)300482561;
				if (num != 0)
				{
				}
				num = (short)366280704;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasNumber_A9190.StepSize = value;
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x0600150C RID: 5388 RVA: 0x001395C0 File Offset: 0x001377C0
		// (set) Token: 0x0600150D RID: 5389 RVA: 0x00139674 File Offset: 0x00137874
		public bool TrkSysStatusAliasStatusAliasNumber_A9190_Applicable
		{
			get
			{
				short num = (short)249790917;
				short num2 = num;
				num = (short)501842373;
				switch (num2 == num)
				{
				default:
				{
					num = (short)303628288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1391525888;
				if (num != 0)
				{
				}
				num = (short)250150913;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasNumber_A9190.Applicable;
			}
			set
			{
				short num = (short)414415488;
				short num2 = num;
				num = (short)795179648;
				switch (num2 == num)
				{
				default:
				{
					num = (short)393478144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)291962880;
				if (num != 0)
				{
				}
				num = (short)1375797249;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasNumber_A9190.Applicable = value;
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x0600150E RID: 5390 RVA: 0x00139728 File Offset: 0x00137928
		// (set) Token: 0x0600150F RID: 5391 RVA: 0x001397E0 File Offset: 0x001379E0
		public bool TrkSysStatusAliasStatusAliasNumber_A9190_Valid
		{
			get
			{
				short num = (short)1349397713;
				short num2 = num;
				num = (short)1454976209;
				switch (num2 == num)
				{
				default:
				{
					num = (short)323551232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)667942913;
				if (num != 0)
				{
				}
				num = (short)1768226816;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasNumber_A9190.Valid;
			}
			set
			{
				short num = (short)1812987905;
				if (num != 0)
				{
				}
				num = (short)1414856704;
				short num2 = num;
				num = (short)935844171;
				short num3 = num;
				num = (short)823056715;
				switch (num3 == num)
				{
				}
				num = (short)1142226944;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasNumber_A9190.Valid = value;
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06001510 RID: 5392 RVA: 0x00139894 File Offset: 0x00137A94
		// (set) Token: 0x06001511 RID: 5393 RVA: 0x0013994C File Offset: 0x00137B4C
		public bool TrkSysStatusAliasStatusAliasNumber_A9190_Visible
		{
			get
			{
				short num = (short)1698325828;
				short num2 = num;
				num = (short)504784196;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1934295040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)941817857;
				if (num != 0)
				{
				}
				num = (short)1934753792;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasNumber_A9190.Visible;
			}
			set
			{
				short num = (short)1076881333;
				short num2 = num;
				num = (short)1426581429;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1990721536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1835925505;
				if (num != 0)
				{
				}
				num = (short)2097152;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasNumber_A9190.Visible = value;
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x00139A04 File Offset: 0x00137C04
		// (set) Token: 0x06001513 RID: 5395 RVA: 0x00139AB8 File Offset: 0x00137CB8
		public bool TrkSysStatusAliasStatusAliasNumber_A9190_Editable
		{
			get
			{
				short num = (short)1442512897;
				if (num != 0)
				{
				}
				num = (short)1171652608;
				short num2 = num;
				num = (short)2050373477;
				short num3 = num;
				num = (short)18823013;
				switch (num3 == num)
				{
				}
				num = (short)1255931904;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasNumber_A9190.Editable;
			}
			set
			{
				short num = (short)1039330726;
				short num2 = num;
				num = (short)615247270;
				switch (num2 == num)
				{
				default:
				{
					num = (short)507838464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)904790017;
				if (num != 0)
				{
				}
				num = (short)1976041472;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasNumber_A9190.Editable = value;
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06001514 RID: 5396 RVA: 0x00139B70 File Offset: 0x00137D70
		internal string TrkSysStatusAliasStatusAliasNumber_A9190_UILabel
		{
			get
			{
				short num = (short)1572055291;
				short num2 = num;
				num = (short)669100283;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1281163264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1811218433;
				if (num != 0)
				{
				}
				num = (short)1273626624;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasNumber_A9190.UIName;
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06001515 RID: 5397 RVA: 0x00139C24 File Offset: 0x00137E24
		// (set) Token: 0x06001516 RID: 5398 RVA: 0x00139CD8 File Offset: 0x00137ED8
		internal bool TrkSysStatusAliasStatusAliasNumber_A9190_HiddenStatic
		{
			get
			{
				short num = (short)2081547570;
				short num2 = num;
				num = (short)783607090;
				switch (num2 == num)
				{
				default:
				{
					num = (short)137035776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1363279873;
				if (num != 0)
				{
				}
				num = (short)758251520;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasNumber_A9190.HiddenStatic;
			}
			set
			{
				short num = (short)322257548;
				short num2 = num;
				num = (short)385368716;
				switch (num2 == num)
				{
				default:
				{
					num = (short)623575040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)583532544;
				if (num != 0)
				{
				}
				num = (short)966197249;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasNumber_A9190.HiddenStatic = value;
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x00139D8C File Offset: 0x00137F8C
		// (set) Token: 0x06001518 RID: 5400 RVA: 0x00139E40 File Offset: 0x00138040
		internal bool TrkSysStatusAliasStatusAliasNumber_A9190_HiddenDynamic
		{
			get
			{
				short num = (short)407621667;
				short num2 = num;
				num = (short)889180195;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2125332480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)250478593;
				if (num != 0)
				{
				}
				num = (short)710082560;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasNumber_A9190.HiddenDynamic;
			}
			set
			{
				short num = (short)2026181886;
				short num2 = num;
				num = (short)2040337662;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2025783296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1431961601;
				if (num != 0)
				{
				}
				num = (short)2144927744;
				if (num != 0)
				{
				}
				this.trkSysStatusAliasStatusAliasNumber_A9190.HiddenDynamic = value;
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x00139EFC File Offset: 0x001380FC
		public bool TrkSysStatusAliasStatusAliasNumber_A9190_HasDiffs
		{
			get
			{
				short num = (short)970148127;
				short num2 = num;
				num = (short)776423711;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1387593728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)742653952;
				if (num != 0)
				{
				}
				num = (short)1047199745;
				if (num != 0)
				{
				}
				return this.trkSysStatusAliasStatusAliasNumber_A9190._HasDiffs;
			}
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x00139FB0 File Offset: 0x001381B0
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
				{
					num2 = (short)1081737217;
					if (num2 != 0)
					{
					}
					num2 = (short)267439249;
					short num3 = num2;
					num2 = (short)1839516817;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
					{
						num2 = (short)619642880;
						if (num2 != 0)
						{
						}
						num2 = (short)351600640;
						short num4 = num2;
						num2 = (short)1191444484;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					return result;
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)1340342272;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)246349825;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1333002243;
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
			num2 = (short)1195245570;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400047B RID: 1147
		private global::AcpBusinessLayer.AcpField<string> trkSysStatusAliasStatusAliasText_A9193;

		// Token: 0x0400047C RID: 1148
		private global::AcpBusinessLayer.AcpKeyField trkSysStatusAlias_A24070;

		// Token: 0x0400047D RID: 1149
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysStatusAliasStatusAliasNumber_A9190;
	}
}
