using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Features.Converters;

namespace Motorola.MackinawCPS.CoreFeatures.RepeaterIDList
{
	// Token: 0x02000522 RID: 1314
	[global::System.Serializable]
	public class SingletoneFrequencyTableInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600B188 RID: 45448 RVA: 0x00A48DCC File Offset: 0x00A46FCC
		public SingletoneFrequencyTableInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600B189 RID: 45449 RVA: 0x00A48DE8 File Offset: 0x00A46FE8
		protected SingletoneFrequencyTableInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600B18A RID: 45450 RVA: 0x00A48E00 File Offset: 0x00A47000
		public override void Init()
		{
			int a_ = 13;
			short num = (short)927047101;
			short num2 = num;
			num = (short)1681038781;
			switch (num2 == num)
			{
			}
			num = (short)763822081;
			if (num != 0)
			{
			}
			num = (short)1341390848;
			if (num != 0)
			{
			}
			num = (short)194248704;
			short num3 = num;
			this.cnvCfgSingletoneFrequencyListToneHz_A9385 = new global::AcpBusinessLayer.AcpCustomRangeField(3000, new global::Features.Converters.UnpackFactorDblAndPackFactorDblWith10ForCustomRange(), this, global::AllFeatures.CodeplugGuid.b("跍뻏ꓑ韓냕뿗觙뗛냝蟟軡臣鋥蟧蓩觫꣭苯韱藳菵鷷铹鿻蟽䳿欁眃爅將攉戋欍堏树䬓圕℗⤙␛⬝", a_), global::CommonResources.AcgResources.ID_TONEHZ, 3000, 30000, 1, null, null);
			this.cnvCfgSingletoneFrequencyListToneHz_A9385.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvCfgSingletoneFrequencyListToneHz_A9385.DataTransferOrder = 4;
			this.cnvCfgSingletoneFrequencyListToneHz_A9385.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鷍맏병돓뫕뷗껙돛냝藟싡ꋣ铥跧鯩駫语黯釱跳훵곷鯹黻鋽旿", a_);
			base.Id = 10213;
			base.UIName = global::CommonResources.AcgResources.ID_SINGLETONEFREQUENCYTABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600B18B RID: 45451 RVA: 0x00A48F3C File Offset: 0x00A4713C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 12;
			short num = (short)1582759940;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ郒돔냖諘닚돜룞跠蛢釤裦蟨軪꯬鷮铰苲胴鋶韸飺蓼돾栀瀂焄匆昈攊栌䜎欐䰒吔⸖⨘⌚⠜", a_)))
					{
						num = (short)1180762114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F6;
				case 1:
				{
					num = (short)1676612773;
					short num3 = num;
					num = (short)1954550949;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_131;
					}
					break;
				}
				case 2:
					num = (short)467009537;
					if (num != 0)
					{
					}
					this.cnvCfgSingletoneFrequencyListToneHz_A9385 = new global::AcpBusinessLayer.AcpCustomRangeField(3000, new global::Features.Converters.UnpackFactorDblAndPackFactorDblWith10ForCustomRange(), this, global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ郒돔냖諘닚돜룞跠蛢釤裦蟨軪꯬鷮铰苲胴鋶韸飺蓼돾栀瀂焄匆昈攊栌䜎欐䰒吔⸖⨘⌚⠜", a_), global::CommonResources.AcgResources.ID_TONEHZ, null, null);
					this.cnvCfgSingletoneFrequencyListToneHz_A9385.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvCfgSingletoneFrequencyListToneHz_A9385.DataTransferOrder = 4;
					this.cnvCfgSingletoneFrequencyListToneHz_A9385.ShowHexValue = false;
					num = (short)533921793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)43450368;
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
					if (producerFields != null)
					{
						num = (short)321847299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F6;
				case 6:
					num = (short)731578373;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_49:
				if (!global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					goto IL_1F6;
				}
				num = (short)1178271744;
				short num4 = num;
				num = (short)719585286;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_131:
			num = (short)1659305984;
			if (num != 0)
			{
			}
			IL_1F6:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("黌ꛎ뿐듒맔닖귘듚돜뫞쇠ꗢ韤苦飨黪裬臮鋰諲헴ꏶ飸駺釼髾", a_);
			base.Id = 10213;
			base.UIName = global::CommonResources.AcgResources.ID_SINGLETONEFREQUENCYTABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600B18C RID: 45452 RVA: 0x00A49170 File Offset: 0x00A47370
		public override void PopulateReferences()
		{
			short num = (short)306724119;
			short num2 = num;
			num = (short)1930378519;
			switch (num2 == num)
			{
			}
			num = (short)1592000512;
			if (num != 0)
			{
			}
			num = (short)927793153;
			if (num != 0)
			{
			}
			num = (short)2035744768;
			short num3 = num;
		}

		// Token: 0x0600B18D RID: 45453 RVA: 0x00A4921C File Offset: 0x00A4741C
		public override void DropReferences()
		{
			short num = (short)960458617;
			short num2 = num;
			num = (short)555839353;
			switch (num2 == num)
			{
			}
			num = (short)622067713;
			if (num != 0)
			{
			}
			num = (short)56033280;
			if (num != 0)
			{
			}
			num = (short)299565056;
			short num3 = num;
		}

		// Token: 0x0600B18E RID: 45454 RVA: 0x00A492C8 File Offset: 0x00A474C8
		public override void SetConstraints()
		{
			short num = (short)1430711638;
			short num2 = num;
			num = (short)962522454;
			switch (num2 == num)
			{
			}
			num = (short)1092091905;
			if (num != 0)
			{
			}
			num = (short)1572143104;
			if (num != 0)
			{
			}
			num = (short)581500928;
			short num3 = num;
		}

		// Token: 0x0600B18F RID: 45455 RVA: 0x00A49374 File Offset: 0x00A47574
		public override void SetupDependencies()
		{
			short num = (short)1846507705;
			short num2 = num;
			num = (short)113604793;
			switch (num2 == num)
			{
			}
			num = (short)2127429633;
			if (num != 0)
			{
			}
			num = (short)1844641792;
			if (num != 0)
			{
			}
			num = (short)2065367040;
			short num3 = num;
		}

		// Token: 0x1700590F RID: 22799
		// (get) Token: 0x0600B190 RID: 45456 RVA: 0x00A4941C File Offset: 0x00A4761C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1373294596;
				short num2 = num;
				num = (short)57921540;
				switch (num2 == num)
				{
				}
				num = (short)1033306112;
				if (num != 0)
				{
				}
				num = (short)682754049;
				if (num != 0)
				{
				}
				num = (short)2049769472;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17005910 RID: 22800
		// (get) Token: 0x0600B191 RID: 45457 RVA: 0x00A494C8 File Offset: 0x00A476C8
		// (set) Token: 0x0600B192 RID: 45458 RVA: 0x00A4957C File Offset: 0x00A4777C
		public int CnvCfgSingletoneFrequencyListToneHz_A9385Value
		{
			get
			{
				short num = (short)207749121;
				if (num != 0)
				{
				}
				num = (short)638952892;
				short num2 = num;
				num = (short)2038605244;
				switch (num2 == num)
				{
				}
				num = (short)1867120640;
				if (num != 0)
				{
				}
				num = (short)831651840;
				short num3 = num;
				return this.cnvCfgSingletoneFrequencyListToneHz_A9385.Value;
			}
			set
			{
				short num = (short)211138028;
				short num2 = num;
				num = (short)722712044;
				switch (num2 == num)
				{
				}
				num = (short)231211009;
				if (num != 0)
				{
				}
				num = (short)1607204864;
				if (num != 0)
				{
				}
				num = (short)58654720;
				short num3 = num;
				this.cnvCfgSingletoneFrequencyListToneHz_A9385.Value = value;
			}
		}

		// Token: 0x17005911 RID: 22801
		// (get) Token: 0x0600B193 RID: 45459 RVA: 0x00A49630 File Offset: 0x00A47830
		public global::AcpBusinessLayer.AcpCustomRangeField CnvCfgSingletoneFrequencyListToneHz_A9385
		{
			get
			{
				short num = (short)1344581426;
				short num2 = num;
				num = (short)1950789426;
				switch (num2 == num)
				{
				}
				num = (short)1504313345;
				if (num != 0)
				{
				}
				num = (short)1771700224;
				if (num != 0)
				{
				}
				num = (short)433192960;
				short num3 = num;
				return this.cnvCfgSingletoneFrequencyListToneHz_A9385;
			}
		}

		// Token: 0x17005912 RID: 22802
		// (get) Token: 0x0600B194 RID: 45460 RVA: 0x00A496E0 File Offset: 0x00A478E0
		// (set) Token: 0x0600B195 RID: 45461 RVA: 0x00A49794 File Offset: 0x00A47994
		public string CnvCfgSingletoneFrequencyListToneHz_A9385_UIValue
		{
			get
			{
				short num = (short)1016922113;
				if (num != 0)
				{
				}
				num = (short)1278587457;
				short num2 = num;
				num = (short)1843638849;
				switch (num2 == num)
				{
				}
				num = (short)9306112;
				if (num != 0)
				{
				}
				num = (short)1759510528;
				short num3 = num;
				return this.cnvCfgSingletoneFrequencyListToneHz_A9385.UIValue;
			}
			set
			{
				short num = (short)2136491381;
				short num2 = num;
				num = (short)1869432181;
				switch (num2 == num)
				{
				}
				num = (short)1654456321;
				if (num != 0)
				{
				}
				num = (short)1972240384;
				if (num != 0)
				{
				}
				num = (short)1511456768;
				short num3 = num;
				this.cnvCfgSingletoneFrequencyListToneHz_A9385.UIValue = value;
			}
		}

		// Token: 0x17005913 RID: 22803
		// (get) Token: 0x0600B196 RID: 45462 RVA: 0x00A49848 File Offset: 0x00A47A48
		// (set) Token: 0x0600B197 RID: 45463 RVA: 0x00A498FC File Offset: 0x00A47AFC
		internal int CnvCfgSingletoneFrequencyListToneHz_A9385Min
		{
			get
			{
				short num = (short)2035623103;
				short num2 = num;
				num = (short)584721599;
				switch (num2 == num)
				{
				}
				num = (short)38469632;
				if (num != 0)
				{
				}
				num = (short)216399873;
				if (num != 0)
				{
				}
				num = (short)1884028928;
				short num3 = num;
				return this.cnvCfgSingletoneFrequencyListToneHz_A9385.Min;
			}
			set
			{
				short num = (short)148854891;
				short num2 = num;
				num = (short)174282859;
				switch (num2 == num)
				{
				}
				num = (short)1376714753;
				if (num != 0)
				{
				}
				num = (short)376897536;
				if (num != 0)
				{
				}
				num = (short)1689255936;
				short num3 = num;
				this.cnvCfgSingletoneFrequencyListToneHz_A9385.Min = value;
			}
		}

		// Token: 0x17005914 RID: 22804
		// (get) Token: 0x0600B198 RID: 45464 RVA: 0x00A499B0 File Offset: 0x00A47BB0
		// (set) Token: 0x0600B199 RID: 45465 RVA: 0x00A49A64 File Offset: 0x00A47C64
		internal int CnvCfgSingletoneFrequencyListToneHz_A9385Max
		{
			get
			{
				short num = (short)919069570;
				short num2 = num;
				num = (short)2003428226;
				switch (num2 == num)
				{
				}
				num = (short)1767636993;
				if (num != 0)
				{
				}
				num = (short)840237056;
				if (num != 0)
				{
				}
				num = (short)1511391232;
				short num3 = num;
				return this.cnvCfgSingletoneFrequencyListToneHz_A9385.Max;
			}
			set
			{
				short num = (short)355672663;
				short num2 = num;
				num = (short)2013274711;
				switch (num2 == num)
				{
				}
				num = (short)1259143169;
				if (num != 0)
				{
				}
				num = (short)2026504192;
				if (num != 0)
				{
				}
				num = (short)1412104192;
				short num3 = num;
				this.cnvCfgSingletoneFrequencyListToneHz_A9385.Max = value;
			}
		}

		// Token: 0x17005915 RID: 22805
		// (get) Token: 0x0600B19A RID: 45466 RVA: 0x00A49B18 File Offset: 0x00A47D18
		// (set) Token: 0x0600B19B RID: 45467 RVA: 0x00A49BCC File Offset: 0x00A47DCC
		internal int CnvCfgSingletoneFrequencyListToneHz_A9385Step
		{
			get
			{
				short num = (short)1132310636;
				short num2 = num;
				num = (short)2043916396;
				switch (num2 == num)
				{
				}
				num = (short)1670840321;
				if (num != 0)
				{
				}
				num = (short)919863296;
				if (num != 0)
				{
				}
				num = (short)1635647488;
				short num3 = num;
				return this.cnvCfgSingletoneFrequencyListToneHz_A9385.StepSize;
			}
			set
			{
				short num = (short)512514574;
				short num2 = num;
				num = (short)1124948494;
				switch (num2 == num)
				{
				}
				num = (short)1971650560;
				if (num != 0)
				{
				}
				num = (short)971046913;
				if (num != 0)
				{
				}
				num = (short)1697841152;
				short num3 = num;
				this.cnvCfgSingletoneFrequencyListToneHz_A9385.StepSize = value;
			}
		}

		// Token: 0x17005916 RID: 22806
		// (get) Token: 0x0600B19C RID: 45468 RVA: 0x00A49C80 File Offset: 0x00A47E80
		// (set) Token: 0x0600B19D RID: 45469 RVA: 0x00A49D34 File Offset: 0x00A47F34
		public bool CnvCfgSingletoneFrequencyListToneHz_A9385_Applicable
		{
			get
			{
				short num = (short)1837536280;
				short num2 = num;
				num = (short)1676645400;
				switch (num2 == num)
				{
				}
				num = (short)1767178240;
				if (num != 0)
				{
				}
				num = (short)288292865;
				if (num != 0)
				{
				}
				num = (short)1975779328;
				short num3 = num;
				return this.cnvCfgSingletoneFrequencyListToneHz_A9385.Applicable;
			}
			set
			{
				short num = (short)991092054;
				short num2 = num;
				num = (short)756014422;
				switch (num2 == num)
				{
				}
				num = (short)1586495488;
				if (num != 0)
				{
				}
				num = (short)1959591937;
				if (num != 0)
				{
				}
				num = (short)1437794304;
				short num3 = num;
				this.cnvCfgSingletoneFrequencyListToneHz_A9385.Applicable = value;
			}
		}

		// Token: 0x17005917 RID: 22807
		// (get) Token: 0x0600B19E RID: 45470 RVA: 0x00A49DEC File Offset: 0x00A47FEC
		// (set) Token: 0x0600B19F RID: 45471 RVA: 0x00A49EA4 File Offset: 0x00A480A4
		public bool CnvCfgSingletoneFrequencyListToneHz_A9385_Valid
		{
			get
			{
				short num = (short)1308024026;
				short num2 = num;
				num = (short)660921562;
				switch (num2 == num)
				{
				}
				num = (short)742064128;
				if (num != 0)
				{
				}
				num = (short)179503105;
				if (num != 0)
				{
				}
				num = (short)756088832;
				short num3 = num;
				return this.cnvCfgSingletoneFrequencyListToneHz_A9385.Valid;
			}
			set
			{
				short num = (short)93716481;
				if (num != 0)
				{
				}
				num = (short)944752435;
				short num2 = num;
				num = (short)132368179;
				switch (num2 == num)
				{
				}
				num = (short)1923809280;
				if (num != 0)
				{
				}
				num = (short)2019360768;
				short num3 = num;
				this.cnvCfgSingletoneFrequencyListToneHz_A9385.Valid = value;
			}
		}

		// Token: 0x17005918 RID: 22808
		// (get) Token: 0x0600B1A0 RID: 45472 RVA: 0x00A49F58 File Offset: 0x00A48158
		// (set) Token: 0x0600B1A1 RID: 45473 RVA: 0x00A4A010 File Offset: 0x00A48210
		public bool CnvCfgSingletoneFrequencyListToneHz_A9385_Visible
		{
			get
			{
				short num = (short)311958800;
				short num2 = num;
				num = (short)1115364624;
				switch (num2 == num)
				{
				}
				num = (short)450232321;
				if (num != 0)
				{
				}
				num = (short)1319763968;
				if (num != 0)
				{
				}
				num = (short)1470431232;
				short num3 = num;
				return this.cnvCfgSingletoneFrequencyListToneHz_A9385.Visible;
			}
			set
			{
				short num = (short)1398406672;
				short num2 = num;
				num = (short)167706128;
				switch (num2 == num)
				{
				}
				num = (short)71041024;
				if (num != 0)
				{
				}
				num = (short)1957363713;
				if (num != 0)
				{
				}
				num = (short)656211968;
				short num3 = num;
				this.cnvCfgSingletoneFrequencyListToneHz_A9385.Visible = value;
			}
		}

		// Token: 0x17005919 RID: 22809
		// (get) Token: 0x0600B1A2 RID: 45474 RVA: 0x00A4A0C4 File Offset: 0x00A482C4
		// (set) Token: 0x0600B1A3 RID: 45475 RVA: 0x00A4A17C File Offset: 0x00A4837C
		public bool CnvCfgSingletoneFrequencyListToneHz_A9385_Editable
		{
			get
			{
				short num = (short)1433564445;
				short num2 = num;
				num = (short)356611357;
				switch (num2 == num)
				{
				}
				num = (short)1673068545;
				if (num != 0)
				{
				}
				num = (short)725876736;
				if (num != 0)
				{
				}
				num = (short)100597760;
				short num3 = num;
				return this.cnvCfgSingletoneFrequencyListToneHz_A9385.Editable;
			}
			set
			{
				short num = (short)1366491137;
				if (num != 0)
				{
				}
				num = (short)1640102199;
				short num2 = num;
				num = (short)2117925175;
				switch (num2 == num)
				{
				}
				num = (short)1088421888;
				if (num != 0)
				{
				}
				num = (short)1027014656;
				short num3 = num;
				this.cnvCfgSingletoneFrequencyListToneHz_A9385.Editable = value;
			}
		}

		// Token: 0x1700591A RID: 22810
		// (get) Token: 0x0600B1A4 RID: 45476 RVA: 0x00A4A234 File Offset: 0x00A48434
		internal string CnvCfgSingletoneFrequencyListToneHz_A9385_UILabel
		{
			get
			{
				short num = (short)620070284;
				short num2 = num;
				num = (short)991659404;
				switch (num2 == num)
				{
				}
				num = (short)747241473;
				if (num != 0)
				{
				}
				num = (short)977338368;
				if (num != 0)
				{
				}
				num = (short)491978752;
				short num3 = num;
				return this.cnvCfgSingletoneFrequencyListToneHz_A9385.UIName;
			}
		}

		// Token: 0x1700591B RID: 22811
		// (get) Token: 0x0600B1A5 RID: 45477 RVA: 0x00A4A2E8 File Offset: 0x00A484E8
		// (set) Token: 0x0600B1A6 RID: 45478 RVA: 0x00A4A3A0 File Offset: 0x00A485A0
		internal bool CnvCfgSingletoneFrequencyListToneHz_A9385_HiddenStatic
		{
			get
			{
				short num = (short)825325250;
				short num2 = num;
				num = (short)115701442;
				switch (num2 == num)
				{
				}
				num = (short)746520577;
				if (num != 0)
				{
				}
				num = (short)1543831552;
				if (num != 0)
				{
				}
				num = (short)1138688000;
				short num3 = num;
				return this.cnvCfgSingletoneFrequencyListToneHz_A9385.HiddenStatic;
			}
			set
			{
				short num = (short)1395979049;
				short num2 = num;
				num = (short)190378793;
				switch (num2 == num)
				{
				}
				num = (short)611450881;
				if (num != 0)
				{
				}
				num = (short)1752825856;
				if (num != 0)
				{
				}
				num = (short)1887764480;
				short num3 = num;
				this.cnvCfgSingletoneFrequencyListToneHz_A9385.HiddenStatic = value;
			}
		}

		// Token: 0x1700591C RID: 22812
		// (get) Token: 0x0600B1A7 RID: 45479 RVA: 0x00A4A458 File Offset: 0x00A48658
		// (set) Token: 0x0600B1A8 RID: 45480 RVA: 0x00A4A510 File Offset: 0x00A48710
		internal bool CnvCfgSingletoneFrequencyListToneHz_A9385_HiddenDynamic
		{
			get
			{
				short num = (short)191658032;
				short num2 = num;
				num = (short)443381808;
				switch (num2 == num)
				{
				}
				num = (short)1361444865;
				if (num != 0)
				{
				}
				num = (short)125632512;
				if (num != 0)
				{
				}
				num = (short)118554624;
				short num3 = num;
				return this.cnvCfgSingletoneFrequencyListToneHz_A9385.HiddenDynamic;
			}
			set
			{
				short num = (short)1640968957;
				short num2 = num;
				num = (short)313209597;
				switch (num2 == num)
				{
				}
				num = (short)657063937;
				if (num != 0)
				{
				}
				num = (short)1479081984;
				if (num != 0)
				{
				}
				num = (short)364445696;
				short num3 = num;
				this.cnvCfgSingletoneFrequencyListToneHz_A9385.HiddenDynamic = value;
			}
		}

		// Token: 0x1700591D RID: 22813
		// (get) Token: 0x0600B1A9 RID: 45481 RVA: 0x00A4A5C8 File Offset: 0x00A487C8
		public bool CnvCfgSingletoneFrequencyListToneHz_A9385_HasDiffs
		{
			get
			{
				short num = (short)738758512;
				short num2 = num;
				num = (short)910987120;
				switch (num2 == num)
				{
				}
				num = (short)1018757120;
				if (num != 0)
				{
				}
				num = (short)1372192769;
				if (num != 0)
				{
				}
				num = (short)1961558016;
				short num3 = num;
				return this.cnvCfgSingletoneFrequencyListToneHz_A9385._HasDiffs;
			}
		}

		// Token: 0x0600B1AA RID: 45482 RVA: 0x00A4A67C File Offset: 0x00A4887C
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
					goto IL_15E;
				case 1:
				{
					num2 = (short)1931214848;
					short num3 = num2;
					num2 = (short)235929604;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)1055588353;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					return result;
				case 4:
				{
					num2 = (short)122601989;
					short num4 = num2;
					num2 = (short)1157874181;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15E;
					default:
						num2 = (short)1093402624;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)2126118912;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				}
				goto IL_24;
				IL_15E:
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num2 = (short)280494081;
				if (num2 != 0)
				{
				}
				num2 = (short)1288306691;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)700776450;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04005428 RID: 21544
		private global::AcpBusinessLayer.AcpCustomRangeField cnvCfgSingletoneFrequencyListToneHz_A9385;
	}
}
