using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x020000A1 RID: 161
	[global::System.Serializable]
	public class SiteAlias : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060013C8 RID: 5064 RVA: 0x00129ECC File Offset: 0x001280CC
		public SiteAlias(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x00129F0C File Offset: 0x0012810C
		protected SiteAlias(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x00129F24 File Offset: 0x00128124
		public override void Init()
		{
			int a_ = 18;
			short num = (short)1398380548;
			short num2 = num;
			num = (short)80844804;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1783824384;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1170997248;
			if (num != 0)
			{
			}
			num = (short)932249601;
			if (num != 0)
			{
			}
			this.trkSysSiteAliasSiteAliasEnable_A9148 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖諘ꋚ껜賞裠韢胤ꛦ藨苪賬鳮ꋰ髲致鋶룸韺铼黾爀䘂欄昆欈朊栌倎倐⨒␔⌖℘", a_), global::CommonResources.AcgResources.ID_SITEALIASENABLE);
			this.trkSysSiteAliasSiteAliasEnable_A9148.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysSiteAliasSiteAliasEnable_A9148.DataTransferOrder = 7;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胒볔ꏖ볘ﯚ鳜돞裠苢雤", a_);
			base.Id = 10171;
			base.UIName = global::CommonResources.AcgResources.ID_SITEALIAS;
			base.DataTransferOrder = 4;
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x0012A044 File Offset: 0x00128244
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 10;
			short num = (short)1504116740;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1195835393;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					IL_100:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ蓖냘꿚룜點跠諢蓤铦뫨苪駬諮냰鿲鳴零諸뻺鏼黾挀漂怄堆䠈㈊㰌㬎⤐", a_)))
					{
						num = (short)2044919811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_168;
				case 2:
					goto IL_168;
				case 3:
					this.trkSysSiteAliasSiteAliasEnable_A9148 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ蓖냘꿚룜點跠諢蓤铦뫨苪駬諮냰鿲鳴零諸뻺鏼黾挀漂怄堆䠈㈊㰌㬎⤐", a_), global::CommonResources.AcgResources.ID_SITEALIASENABLE);
					this.trkSysSiteAliasSiteAliasEnable_A9148.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysSiteAliasSiteAliasEnable_A9148.DataTransferOrder = 7;
					num = (short)640679938;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 5:
					num = (short)1285029889;
					if (num != 0)
					{
					}
					num = (short)1260912646;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (producerFields != null)
					{
						num = (short)695205888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_168;
				}
				IL_49:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1518403589;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_168:
				num = (short)1403840673;
				short num3 = num;
				num = (short)956819617;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_100;
				default:
					goto IL_19E;
				}
			}
			IL_19E:
			num = (short)1337720832;
			short num4 = num;
			num = (short)1078788096;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("飊꓌믎듐铔믖냘뫚껜", a_);
			base.Id = 10171;
			base.UIName = global::CommonResources.AcgResources.ID_SITEALIAS;
			base.DataTransferOrder = 4;
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x0012A260 File Offset: 0x00128460
		public override void PopulateReferences()
		{
			short num = (short)1307749112;
			short num2 = num;
			num = (short)1299426040;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1862860800;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1156055040;
			if (num != 0)
			{
			}
			num = (short)1588920321;
			if (num != 0)
			{
			}
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x0012A308 File Offset: 0x00128508
		public override void DropReferences()
		{
			short num = (short)247201793;
			if (num != 0)
			{
			}
			num = (short)670367744;
			short num2 = num;
			num = (short)382610902;
			short num3 = num;
			num = (short)1853042134;
			switch (num3 == num)
			{
			}
			num = (short)688062464;
			if (num != 0)
			{
			}
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x0012A3B0 File Offset: 0x001285B0
		public override void SetConstraints()
		{
			short num = (short)807322214;
			short num2 = num;
			num = (short)531874406;
			switch (num2 == num)
			{
			default:
			{
				num = (short)684326912;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2128412673;
			if (num != 0)
			{
			}
			num = (short)1518469120;
			if (num != 0)
			{
			}
			this.trkSysSiteAliasSiteAliasEnable_A9148.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConDependOnTrkSysTypeAndAmssSelect);
			this.trkSysSiteAliasSiteAliasEnable_A9148.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConSiteAliasInvalidWhenEnabledAndInapplicable);
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x0012A488 File Offset: 0x00128688
		public override void SetupDependencies()
		{
			short num = (short)1475863538;
			short num2 = num;
			num = (short)972809202;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1041104896;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2126512128;
			if (num != 0)
			{
			}
			num = (short)1940586497;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
			trunkingSystem.General.TrkSysGeneralCoverageType_A7782.AddDependentObject(this.trkSysSiteAliasSiteAliasEnable_A9148);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysSiteAliasSiteAliasEnable_A9148);
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x060013D0 RID: 5072 RVA: 0x0012A568 File Offset: 0x00128768
		public bool HasDiffs
		{
			get
			{
				short num = (short)201746012;
				short num2 = num;
				num = (short)859661916;
				switch (num2 == num)
				{
				default:
				{
					num = (short)601096192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1594687489;
				if (num != 0)
				{
				}
				num = (short)1094713344;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x0012A618 File Offset: 0x00128818
		// (set) Token: 0x060013D2 RID: 5074 RVA: 0x0012A6CC File Offset: 0x001288CC
		public bool TrkSysSiteAliasSiteAliasEnable_A9148Value
		{
			get
			{
				short num = (short)475430395;
				short num2 = num;
				num = (short)2137095675;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1365966848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1521156097;
				if (num != 0)
				{
				}
				num = (short)1956315136;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasEnable_A9148.Value;
			}
			set
			{
				short num = (short)1664352257;
				if (num != 0)
				{
				}
				num = (short)1507654880;
				short num2 = num;
				num = (short)1092091104;
				switch (num2 == num)
				{
				}
				num = (short)1600520192;
				short num3 = num;
				num = (short)762576896;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasSiteAliasEnable_A9148.Value = value;
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x0012A780 File Offset: 0x00128980
		public global::AcpBusinessLayer.AcpField<bool> TrkSysSiteAliasSiteAliasEnable_A9148
		{
			get
			{
				short num = (short)1192600678;
				short num2 = num;
				num = (short)543204454;
				switch (num2 == num)
				{
				}
				num = (short)1080623105;
				if (num != 0)
				{
				}
				num = (short)1052114944;
				short num3 = num;
				num = (short)378535936;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasEnable_A9148;
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x0012A830 File Offset: 0x00128A30
		// (set) Token: 0x060013D5 RID: 5077 RVA: 0x0012A8E4 File Offset: 0x00128AE4
		public bool TrkSysSiteAliasSiteAliasEnable_A9148_UIValue
		{
			get
			{
				short num = (short)1916151737;
				short num2 = num;
				num = (short)852305849;
				switch (num2 == num)
				{
				}
				num = (short)636289024;
				if (num != 0)
				{
				}
				num = (short)317194240;
				short num3 = num;
				num = (short)247529473;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasEnable_A9148.Value;
			}
			set
			{
				short num = (short)233830694;
				short num2 = num;
				num = (short)798554406;
				switch (num2 == num)
				{
				}
				num = (short)1288372225;
				if (num != 0)
				{
				}
				num = (short)510590976;
				short num3 = num;
				num = (short)562364416;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasSiteAliasEnable_A9148.Value = value;
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x0012A99C File Offset: 0x00128B9C
		// (set) Token: 0x060013D7 RID: 5079 RVA: 0x0012AA4C File Offset: 0x00128C4C
		public bool TrkSysSiteAliasSiteAliasEnable_A9148_Applicable
		{
			get
			{
				short num = (short)1357471553;
				short num2 = num;
				num = (short)86925121;
				switch (num2 == num)
				{
				}
				num = (short)587071489;
				if (num != 0)
				{
				}
				num = (short)42467328;
				short num3 = num;
				num = (short)605552640;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasEnable_A9148.Applicable;
			}
			set
			{
				short num = (short)523042817;
				if (num != 0)
				{
				}
				num = (short)257028121;
				short num2 = num;
				num = (short)215019545;
				switch (num2 == num)
				{
				}
				num = (short)1856241664;
				short num3 = num;
				num = (short)837025792;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasSiteAliasEnable_A9148.Applicable = value;
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x060013D8 RID: 5080 RVA: 0x0012AB00 File Offset: 0x00128D00
		// (set) Token: 0x060013D9 RID: 5081 RVA: 0x0012ABB4 File Offset: 0x00128DB4
		public bool TrkSysSiteAliasSiteAliasEnable_A9148_Valid
		{
			get
			{
				short num = (short)241696769;
				if (num != 0)
				{
				}
				num = (short)1683790885;
				short num2 = num;
				num = (short)980392997;
				switch (num2 == num)
				{
				}
				num = (short)1322713088;
				short num3 = num;
				num = (short)1509752832;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasEnable_A9148.Valid;
			}
			set
			{
				short num = (short)827311390;
				short num2 = num;
				num = (short)1151452446;
				switch (num2 == num)
				{
				}
				num = (short)433061889;
				if (num != 0)
				{
				}
				num = (short)1145634816;
				short num3 = num;
				num = (short)96534528;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasSiteAliasEnable_A9148.Valid = value;
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x060013DA RID: 5082 RVA: 0x0012AC68 File Offset: 0x00128E68
		// (set) Token: 0x060013DB RID: 5083 RVA: 0x0012AD1C File Offset: 0x00128F1C
		public bool TrkSysSiteAliasSiteAliasEnable_A9148_Visible
		{
			get
			{
				short num = (short)298844416;
				short num2 = num;
				num = (short)1807286528;
				switch (num2 == num)
				{
				}
				num = (short)9568257;
				if (num != 0)
				{
				}
				num = (short)985792512;
				short num3 = num;
				num = (short)894107648;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasEnable_A9148.Visible;
			}
			set
			{
				short num = (short)491565610;
				short num2 = num;
				num = (short)163623466;
				switch (num2 == num)
				{
				}
				num = (short)1113784321;
				if (num != 0)
				{
				}
				num = (short)417464320;
				short num3 = num;
				num = (short)643891200;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasSiteAliasEnable_A9148.Visible = value;
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x060013DC RID: 5084 RVA: 0x0012ADD4 File Offset: 0x00128FD4
		// (set) Token: 0x060013DD RID: 5085 RVA: 0x0012AE88 File Offset: 0x00129088
		public bool TrkSysSiteAliasSiteAliasEnable_A9148_Editable
		{
			get
			{
				short num = (short)43885183;
				short num2 = num;
				num = (short)181903999;
				switch (num2 == num)
				{
				}
				num = (short)1679884289;
				if (num != 0)
				{
				}
				num = (short)2073624576;
				short num3 = num;
				num = (short)1155661824;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasEnable_A9148.Editable;
			}
			set
			{
				short num = (short)164206655;
				short num2 = num;
				num = (short)1668978751;
				switch (num2 == num)
				{
				}
				num = (short)2084831233;
				if (num != 0)
				{
				}
				num = (short)1853423616;
				short num3 = num;
				num = (short)1243873280;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasSiteAliasEnable_A9148.Editable = value;
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x0012AF40 File Offset: 0x00129140
		internal string TrkSysSiteAliasSiteAliasEnable_A9148_UILabel
		{
			get
			{
				short num = (short)1368448139;
				short num2 = num;
				num = (short)1779293323;
				switch (num2 == num)
				{
				}
				num = (short)1789001729;
				if (num != 0)
				{
				}
				num = (short)496107520;
				short num3 = num;
				num = (short)677773312;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasEnable_A9148.UIName;
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x0012AFF4 File Offset: 0x001291F4
		// (set) Token: 0x060013E0 RID: 5088 RVA: 0x0012B0A8 File Offset: 0x001292A8
		internal bool TrkSysSiteAliasSiteAliasEnable_A9148_HiddenStatic
		{
			get
			{
				short num = (short)1356426770;
				short num2 = num;
				num = (short)591621650;
				switch (num2 == num)
				{
				}
				num = (short)2093088769;
				if (num != 0)
				{
				}
				num = (short)1690107904;
				short num3 = num;
				num = (short)1726218240;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasEnable_A9148.HiddenStatic;
			}
			set
			{
				short num = (short)1250736854;
				short num2 = num;
				num = (short)129415894;
				switch (num2 == num)
				{
				}
				num = (short)1632829441;
				if (num != 0)
				{
				}
				num = (short)1644363776;
				short num3 = num;
				num = (short)32571392;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasSiteAliasEnable_A9148.HiddenStatic = value;
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x0012B160 File Offset: 0x00129360
		// (set) Token: 0x060013E2 RID: 5090 RVA: 0x0012B214 File Offset: 0x00129414
		internal bool TrkSysSiteAliasSiteAliasEnable_A9148_HiddenDynamic
		{
			get
			{
				short num = (short)500366868;
				short num2 = num;
				num = (short)727645716;
				switch (num2 == num)
				{
				}
				num = (short)554827777;
				if (num != 0)
				{
				}
				num = (short)632619008;
				short num3 = num;
				num = (short)1164902400;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasEnable_A9148.HiddenDynamic;
			}
			set
			{
				short num = (short)223504577;
				short num2 = num;
				num = (short)393570497;
				switch (num2 == num)
				{
				}
				num = (short)1370357761;
				if (num != 0)
				{
				}
				num = (short)2076049408;
				short num3 = num;
				num = (short)1071185920;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasSiteAliasEnable_A9148.HiddenDynamic = value;
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x0012B2C8 File Offset: 0x001294C8
		public bool TrkSysSiteAliasSiteAliasEnable_A9148_HasDiffs
		{
			get
			{
				short num = (short)1155408171;
				short num2 = num;
				num = (short)329195819;
				switch (num2 == num)
				{
				}
				num = (short)1551171585;
				if (num != 0)
				{
				}
				num = (short)166658048;
				short num3 = num;
				num = (short)1938489344;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasEnable_A9148._HasDiffs;
			}
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x0012B37C File Offset: 0x0012957C
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
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num2 = (short)1486946304;
					short num3 = num2;
					num2 = (short)798315700;
					short num4 = num2;
					num2 = (short)1000821940;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)1771700224;
						if (num2 != 0)
						{
						}
						num2 = (short)633077762;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					num2 = (short)1131675648;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)715587585;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1707540483;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return result;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)1137836033;
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
			num2 = (short)152371204;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000466 RID: 1126
		private global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerRecset innerRecset;

		// Token: 0x04000467 RID: 1127
		private global::AcpBusinessLayer.AcpField<bool> trkSysSiteAliasSiteAliasEnable_A9148;
	}
}
