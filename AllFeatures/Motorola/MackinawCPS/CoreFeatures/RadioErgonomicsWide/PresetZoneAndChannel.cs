using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide
{
	// Token: 0x0200023C RID: 572
	[global::System.Serializable]
	public class PresetZoneAndChannel : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600677F RID: 26495 RVA: 0x005C7884 File Offset: 0x005C5A84
		public PresetZoneAndChannel(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06006780 RID: 26496 RVA: 0x005C78C4 File Offset: 0x005C5AC4
		protected PresetZoneAndChannel(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06006781 RID: 26497 RVA: 0x005C78DC File Offset: 0x005C5ADC
		public override void Init()
		{
			int a_ = 12;
			short num = (short)913258954;
			short num2 = num;
			num = (short)1225931210;
			switch (num2 == num)
			{
			}
			num = (short)1553006593;
			if (num != 0)
			{
			}
			num = (short)1095041024;
			short num3 = num;
			num = (short)1271791616;
			if (num != 0)
			{
			}
			this.radWideGeneralConfigurablePresetZoneAndChannel_A44917 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鿌껎뗐蓒볔돖볘鳚룜뇞蓠釢蓤详ꫨ蓪菬觮飰铲胴藶飸駺釼髾儀焂怄理氈缊圌怎缐瘒吔礖紘堚甜縞传䴢䀤䬦瘨横᤬ᬮ࠰Ȳȴ", a_), global::CommonResources.AcgResources.ID_CONFIGURABLE_PRESET_ZONE_AND_CHANNEL);
			this.radWideGeneralConfigurablePresetZoneAndChannel_A44917.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideGeneralConfigurablePresetZoneAndChannel_A44917.DataTransferOrder = 1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鷌뷎듐ꃒ냔ꏖ律臚닜뇞蓠쏢蓤触跨쯪껬蟮郰鷲鯴鋶闸", a_);
			base.Id = 10640;
			base.UIName = global::CommonResources.AcgResources.ID_PRESETZONEANDCHANNEL;
			base.DataTransferOrder = 8;
		}

		// Token: 0x06006782 RID: 26498 RVA: 0x005C79F8 File Offset: 0x005C5BF8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 4;
			short num = (short)542310400;
			short num2 = num;
			num = (short)763822081;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					this.radWideGeneralConfigurablePresetZoneAndChannel_A44917 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈鳊꓌ꯎ듐铒냔맖볘꧚볜돞ꋠ賢诤臦胨質飬鷮郰釲駴鋶꧸觺飼賾搀眂弄栆月渊䰌愎甐倒純瘖眘甚砜猞縠戢ᄤጦဨᨪᨬ", a_), global::CommonResources.AcgResources.ID_CONFIGURABLE_PRESET_ZONE_AND_CHANNEL);
					this.radWideGeneralConfigurablePresetZoneAndChannel_A44917.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideGeneralConfigurablePresetZoneAndChannel_A44917.DataTransferOrder = 1;
					num = (short)65538;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_73;
					}
					continue;
				case 2:
					goto IL_E6;
				case 3:
				{
					num = (short)1412804542;
					short num4 = num;
					num = (short)1114025918;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_91;
					default:
						num = (short)2130051072;
						if (num != 0)
						{
						}
						num = (short)966000645;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_91;
				case 5:
					num = (short)185729025;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈鳊꓌ꯎ듐铒냔맖볘꧚볜돞ꋠ賢诤臦胨質飬鷮郰釲駴鋶꧸觺飼賾搀眂弄栆月渊䰌愎甐倒純瘖眘甚砜猞縠戢ᄤጦဨᨪᨬ", a_)))
					{
						num = (short)1118175232;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E1;
				case 6:
					if (producerFields != null)
					{
						num = (short)1150484483;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E1;
				}
				IL_73:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)2054356996;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_91:
				num = (short)1685585926;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_E6:
			IL_1E1:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("闄뗆곈룊꣌믎角뫔맖볘ﯚ볜뇞藠쏢ꛤ迦裨藪菬諮鷰", a_);
			base.Id = 10640;
			base.UIName = global::CommonResources.AcgResources.ID_PRESETZONEANDCHANNEL;
			base.DataTransferOrder = 8;
		}

		// Token: 0x06006783 RID: 26499 RVA: 0x005C7C18 File Offset: 0x005C5E18
		public override void PopulateReferences()
		{
			short num = (short)1375030573;
			short num2 = num;
			num = (short)1331252525;
			switch (num2 == num)
			{
			}
			num = (short)601882625;
			if (num != 0)
			{
			}
			num = (short)1608843264;
			short num3 = num;
			num = (short)1690173440;
			if (num != 0)
			{
			}
		}

		// Token: 0x06006784 RID: 26500 RVA: 0x005C7CC0 File Offset: 0x005C5EC0
		public override void DropReferences()
		{
			short num = (short)448159924;
			short num2 = num;
			num = (short)823812276;
			switch (num2 == num)
			{
			}
			num = (short)1082130432;
			if (num != 0)
			{
			}
			num = (short)1060372480;
			short num3 = num;
			num = (short)1976958977;
			if (num != 0)
			{
			}
		}

		// Token: 0x06006785 RID: 26501 RVA: 0x005C7D68 File Offset: 0x005C5F68
		public override void SetConstraints()
		{
			short num = (short)1431830956;
			short num2 = num;
			num = (short)2045051308;
			switch (num2 == num)
			{
			}
			num = (short)1544749056;
			if (num != 0)
			{
			}
			num = (short)627113984;
			short num3 = num;
			num = (short)924123137;
			if (num != 0)
			{
			}
		}

		// Token: 0x06006786 RID: 26502 RVA: 0x005C7E10 File Offset: 0x005C6010
		public override void SetupDependencies()
		{
			short num = (short)2338111;
			short num2 = num;
			num = (short)848211263;
			switch (num2 == num)
			{
			}
			num = (short)1566244864;
			if (num != 0)
			{
			}
			num = (short)1957560320;
			short num3 = num;
			num = (short)1157300225;
			if (num != 0)
			{
			}
		}

		// Token: 0x170035BC RID: 13756
		// (get) Token: 0x06006787 RID: 26503 RVA: 0x005C7EB8 File Offset: 0x005C60B8
		public bool HasDiffs
		{
			get
			{
				short num = (short)1631258414;
				short num2 = num;
				num = (short)2116290350;
				switch (num2 == num)
				{
				}
				num = (short)578355200;
				if (num != 0)
				{
				}
				num = (short)2027225088;
				short num3 = num;
				num = (short)1406074881;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170035BD RID: 13757
		// (get) Token: 0x06006788 RID: 26504 RVA: 0x005C7F68 File Offset: 0x005C6168
		// (set) Token: 0x06006789 RID: 26505 RVA: 0x005C801C File Offset: 0x005C621C
		public bool RadWideGeneralConfigurablePresetZoneAndChannel_A44917Value
		{
			get
			{
				short num = (short)781385729;
				if (num != 0)
				{
				}
				num = (short)965288335;
				short num2 = num;
				num = (short)1835606415;
				switch (num2 == num)
				{
				}
				num = (short)1548550144;
				short num3 = num;
				num = (short)1174929408;
				if (num != 0)
				{
				}
				return this.radWideGeneralConfigurablePresetZoneAndChannel_A44917.Value;
			}
			set
			{
				short num = (short)2014743138;
				short num2 = num;
				num = (short)844663394;
				switch (num2 == num)
				{
				}
				num = (short)25362433;
				if (num != 0)
				{
				}
				num = (short)201785344;
				short num3 = num;
				num = (short)1940914176;
				if (num != 0)
				{
				}
				this.radWideGeneralConfigurablePresetZoneAndChannel_A44917.Value = value;
			}
		}

		// Token: 0x170035BE RID: 13758
		// (get) Token: 0x0600678A RID: 26506 RVA: 0x005C80D4 File Offset: 0x005C62D4
		public global::AcpBusinessLayer.AcpField<bool> RadWideGeneralConfigurablePresetZoneAndChannel_A44917
		{
			get
			{
				short num = (short)1826432603;
				short num2 = num;
				num = (short)1436821083;
				switch (num2 == num)
				{
				}
				num = (short)1234829313;
				if (num != 0)
				{
				}
				num = (short)311754752;
				short num3 = num;
				num = (short)1577975808;
				if (num != 0)
				{
				}
				return this.radWideGeneralConfigurablePresetZoneAndChannel_A44917;
			}
		}

		// Token: 0x170035BF RID: 13759
		// (get) Token: 0x0600678B RID: 26507 RVA: 0x005C8188 File Offset: 0x005C6388
		// (set) Token: 0x0600678C RID: 26508 RVA: 0x005C823C File Offset: 0x005C643C
		public bool RadWideGeneralConfigurablePresetZoneAndChannel_A44917_UIValue
		{
			get
			{
				short num = (short)371160855;
				short num2 = num;
				num = (short)1575646999;
				switch (num2 == num)
				{
				}
				num = (short)960561153;
				if (num != 0)
				{
				}
				num = (short)18219008;
				short num3 = num;
				num = (short)1296236544;
				if (num != 0)
				{
				}
				return this.radWideGeneralConfigurablePresetZoneAndChannel_A44917.Value;
			}
			set
			{
				short num = (short)1341960438;
				short num2 = num;
				num = (short)575582454;
				switch (num2 == num)
				{
				}
				num = (short)2023948289;
				if (num != 0)
				{
				}
				num = (short)515440640;
				short num3 = num;
				num = (short)1098907648;
				if (num != 0)
				{
				}
				this.radWideGeneralConfigurablePresetZoneAndChannel_A44917.Value = value;
			}
		}

		// Token: 0x170035C0 RID: 13760
		// (get) Token: 0x0600678D RID: 26509 RVA: 0x005C82F0 File Offset: 0x005C64F0
		// (set) Token: 0x0600678E RID: 26510 RVA: 0x005C83A8 File Offset: 0x005C65A8
		public bool RadWideGeneralConfigurablePresetZoneAndChannel_A44917_Applicable
		{
			get
			{
				short num = (short)1154442162;
				short num2 = num;
				num = (short)963470258;
				switch (num2 == num)
				{
				}
				num = (short)1280966656;
				short num3 = num;
				num = (short)1832583169;
				if (num != 0)
				{
				}
				num = (short)2013396992;
				if (num != 0)
				{
				}
				return this.radWideGeneralConfigurablePresetZoneAndChannel_A44917.Applicable;
			}
			set
			{
				short num = (short)1458896897;
				if (num != 0)
				{
				}
				num = (short)1033853671;
				short num2 = num;
				num = (short)1097816807;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1395785728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2084241408;
				if (num != 0)
				{
				}
				this.radWideGeneralConfigurablePresetZoneAndChannel_A44917.Applicable = value;
			}
		}

		// Token: 0x170035C1 RID: 13761
		// (get) Token: 0x0600678F RID: 26511 RVA: 0x005C8460 File Offset: 0x005C6660
		// (set) Token: 0x06006790 RID: 26512 RVA: 0x005C8514 File Offset: 0x005C6714
		public bool RadWideGeneralConfigurablePresetZoneAndChannel_A44917_Valid
		{
			get
			{
				short num = (short)1971846340;
				short num2 = num;
				num = (short)288095428;
				switch (num2 == num)
				{
				}
				num = (short)1791557632;
				short num3 = num;
				num = (short)337838081;
				if (num != 0)
				{
				}
				num = (short)1897005056;
				if (num != 0)
				{
				}
				return this.radWideGeneralConfigurablePresetZoneAndChannel_A44917.Valid;
			}
			set
			{
				short num = (short)1061948824;
				short num2 = num;
				num = (short)739511704;
				switch (num2 == num)
				{
				}
				num = (short)1706622976;
				short num3 = num;
				num = (short)910884865;
				if (num != 0)
				{
				}
				num = (short)374996992;
				if (num != 0)
				{
				}
				this.radWideGeneralConfigurablePresetZoneAndChannel_A44917.Valid = value;
			}
		}

		// Token: 0x170035C2 RID: 13762
		// (get) Token: 0x06006791 RID: 26513 RVA: 0x005C85CC File Offset: 0x005C67CC
		// (set) Token: 0x06006792 RID: 26514 RVA: 0x005C8680 File Offset: 0x005C6880
		public bool RadWideGeneralConfigurablePresetZoneAndChannel_A44917_Visible
		{
			get
			{
				short num = (short)1565032870;
				short num2 = num;
				num = (short)175473062;
				switch (num2 == num)
				{
				}
				num = (short)1339686912;
				short num3 = num;
				num = (short)1582956545;
				if (num != 0)
				{
				}
				num = (short)637992960;
				if (num != 0)
				{
				}
				return this.radWideGeneralConfigurablePresetZoneAndChannel_A44917.Visible;
			}
			set
			{
				short num = (short)952413863;
				short num2 = num;
				num = (short)279293607;
				switch (num2 == num)
				{
				}
				num = (short)763035648;
				short num3 = num;
				num = (short)1867513857;
				if (num != 0)
				{
				}
				num = (short)1278869504;
				if (num != 0)
				{
				}
				this.radWideGeneralConfigurablePresetZoneAndChannel_A44917.Visible = value;
			}
		}

		// Token: 0x170035C3 RID: 13763
		// (get) Token: 0x06006793 RID: 26515 RVA: 0x005C8734 File Offset: 0x005C6934
		// (set) Token: 0x06006794 RID: 26516 RVA: 0x005C87E8 File Offset: 0x005C69E8
		public bool RadWideGeneralConfigurablePresetZoneAndChannel_A44917_Editable
		{
			get
			{
				short num = (short)1169420771;
				short num2 = num;
				num = (short)1196880355;
				switch (num2 == num)
				{
				}
				num = (short)1722613760;
				short num3 = num;
				num = (short)2015821825;
				if (num != 0)
				{
				}
				num = (short)671154176;
				if (num != 0)
				{
				}
				return this.radWideGeneralConfigurablePresetZoneAndChannel_A44917.Editable;
			}
			set
			{
				short num = (short)1289497982;
				short num2 = num;
				num = (short)613494142;
				switch (num2 == num)
				{
				}
				num = (short)1752170496;
				short num3 = num;
				num = (short)1612120065;
				if (num != 0)
				{
				}
				num = (short)1065549824;
				if (num != 0)
				{
				}
				this.radWideGeneralConfigurablePresetZoneAndChannel_A44917.Editable = value;
			}
		}

		// Token: 0x170035C4 RID: 13764
		// (get) Token: 0x06006795 RID: 26517 RVA: 0x005C88A0 File Offset: 0x005C6AA0
		internal string RadWideGeneralConfigurablePresetZoneAndChannel_A44917_UILabel
		{
			get
			{
				short num = (short)643761143;
				short num2 = num;
				num = (short)1639908343;
				switch (num2 == num)
				{
				}
				num = (short)1996685312;
				short num3 = num;
				num = (short)29229057;
				if (num != 0)
				{
				}
				num = (short)1636892672;
				if (num != 0)
				{
				}
				return this.radWideGeneralConfigurablePresetZoneAndChannel_A44917.UIName;
			}
		}

		// Token: 0x170035C5 RID: 13765
		// (get) Token: 0x06006796 RID: 26518 RVA: 0x005C8954 File Offset: 0x005C6B54
		// (set) Token: 0x06006797 RID: 26519 RVA: 0x005C8A0C File Offset: 0x005C6C0C
		internal bool RadWideGeneralConfigurablePresetZoneAndChannel_A44917_HiddenStatic
		{
			get
			{
				short num = (short)840861925;
				short num2 = num;
				num = (short)243435749;
				switch (num2 == num)
				{
				}
				num = (short)677576704;
				short num3 = num;
				num = (short)471531520;
				if (num != 0)
				{
				}
				num = (short)639762433;
				if (num != 0)
				{
				}
				return this.radWideGeneralConfigurablePresetZoneAndChannel_A44917.HiddenStatic;
			}
			set
			{
				short num = (short)620702115;
				short num2 = num;
				num = (short)2092181923;
				switch (num2 == num)
				{
				}
				num = (short)41615360;
				short num3 = num;
				num = (short)1165230081;
				if (num != 0)
				{
				}
				num = (short)857145344;
				if (num != 0)
				{
				}
				this.radWideGeneralConfigurablePresetZoneAndChannel_A44917.HiddenStatic = value;
			}
		}

		// Token: 0x170035C6 RID: 13766
		// (get) Token: 0x06006798 RID: 26520 RVA: 0x005C8AC0 File Offset: 0x005C6CC0
		// (set) Token: 0x06006799 RID: 26521 RVA: 0x005C8B74 File Offset: 0x005C6D74
		internal bool RadWideGeneralConfigurablePresetZoneAndChannel_A44917_HiddenDynamic
		{
			get
			{
				short num = (short)952718762;
				short num2 = num;
				num = (short)1513575850;
				switch (num2 == num)
				{
				}
				num = (short)29229056;
				short num3 = num;
				num = (short)679542785;
				if (num != 0)
				{
				}
				num = (short)248381440;
				if (num != 0)
				{
				}
				return this.radWideGeneralConfigurablePresetZoneAndChannel_A44917.HiddenDynamic;
			}
			set
			{
				short num = (short)1485599025;
				short num2 = num;
				num = (short)363622705;
				switch (num2 == num)
				{
				}
				num = (short)660930560;
				short num3 = num;
				num = (short)1581383681;
				if (num != 0)
				{
				}
				num = (short)1019412480;
				if (num != 0)
				{
				}
				this.radWideGeneralConfigurablePresetZoneAndChannel_A44917.HiddenDynamic = value;
			}
		}

		// Token: 0x170035C7 RID: 13767
		// (get) Token: 0x0600679A RID: 26522 RVA: 0x005C8C28 File Offset: 0x005C6E28
		public bool RadWideGeneralConfigurablePresetZoneAndChannel_A44917_HasDiffs
		{
			get
			{
				short num = (short)1214578689;
				if (num != 0)
				{
				}
				num = (short)1511967630;
				short num2 = num;
				num = (short)1095355278;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1597112320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1804206080;
				if (num != 0)
				{
				}
				return this.radWideGeneralConfigurablePresetZoneAndChannel_A44917._HasDiffs;
			}
		}

		// Token: 0x0600679B RID: 26523 RVA: 0x005C8CDC File Offset: 0x005C6EDC
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
					num2 = (short)487623505;
					short num3 = num2;
					num2 = (short)522750801;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6F;
					default:
						goto IL_BA;
					}
					break;
				}
				case 1:
				{
					num2 = (short)304873472;
					short num4 = num2;
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1124335619;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 2:
					num2 = (short)1772748801;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)67829761;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					goto IL_6F;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)460587010;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
				IL_6F:
				num2 = (short)350486528;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_BA:
			num2 = (short)1739849728;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)2017198084;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040026B8 RID: 9912
		private global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerRecset innerRecset;

		// Token: 0x040026B9 RID: 9913
		private global::AcpBusinessLayer.AcpField<bool> radWideGeneralConfigurablePresetZoneAndChannel_A44917;
	}
}
