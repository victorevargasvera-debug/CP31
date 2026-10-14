using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide
{
	// Token: 0x02000243 RID: 579
	[global::System.Serializable]
	public class Stealth : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600680A RID: 26634 RVA: 0x005D2BB8 File Offset: 0x005D0DB8
		public Stealth(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600680B RID: 26635 RVA: 0x005D2BD4 File Offset: 0x005D0DD4
		protected Stealth(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600680C RID: 26636 RVA: 0x005D2BEC File Offset: 0x005D0DEC
		public override void Init()
		{
			int a_ = 16;
			short num = (short)1801023458;
			short num2 = num;
			num = (short)1873965026;
			switch (num2 == num)
			{
			}
			num = (short)878510081;
			if (num != 0)
			{
			}
			num = (short)1160183808;
			if (num != 0)
			{
			}
			num = (short)1160314880;
			short num3 = num;
			this.radErgoWideStealthDisableLightLED_A36482 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("菐닒뇔鋖ꯘ볚닜裞裠蟢胤듦鷨軪賬菮藰鯲뇴黶諸髺鿼鏾搀伂氄怆愈缊䄌䨎唐䰒吔␖⼘⼚├ⴞ", a_), global::CommonResources.AcgResources.ID_STEALTHMODEDISABLELIGHTSLEDS);
			this.radErgoWideStealthDisableLightLED_A36482.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideStealthDisableLightLED_A36482.DataTransferOrder = -1;
			this.radErgoWideStealthDisableTones_A36487 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("菐닒뇔鋖ꯘ볚닜裞裠蟢胤듦鷨軪賬菮藰鯲뇴黶諸髺鿼鏾搀圂樄椆氈砊刌与∐┒℔⼖⸘", a_), global::CommonResources.AcgResources.ID_STEALTHMODEDISABLETONES);
			this.radErgoWideStealthDisableTones_A36487.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideStealthDisableTones_A36487.DataTransferOrder = -1;
			this.radErgoWideStealthSaveStealthMode_A36491 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("菐닒뇔鋖ꯘ볚닜裞裠蟢胤듦鷨軪賬菮藰鯲꛴零迸黺껼课搀戂椄猆愈䘊戌欎琐䰒吔␖⼘⼚␜⸞", a_), global::CommonResources.AcgResources.ID_SAVESTEALTHMODE);
			this.radErgoWideStealthSaveStealthMode_A36491.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideStealthSaveStealthMode_A36491.DataTransferOrder = 59;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苐꟒냔뛖뗘꿚뗜", a_);
			base.Id = 10603;
			base.UIName = global::CommonResources.AcgResources.ID_STEALTH;
			base.DataTransferOrder = 6;
		}

		// Token: 0x0600680D RID: 26637 RVA: 0x005D2D78 File Offset: 0x005D0F78
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 15;
			short num = (short)2108948491;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.radErgoWideStealthSaveStealthMode_A36491 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("苏돑냓鏕꫗뷙돛觝觟蛡臣뗥鳧迩跫苭蓯髱ꟳ韵軷鿹꿻諽旿持栃爅怇䜉挋樍甏䴑唓┕⸗⸙┛⼝", a_), global::CommonResources.AcgResources.ID_SAVESTEALTHMODE);
					this.radErgoWideStealthSaveStealthMode_A36491.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideStealthSaveStealthMode_A36491.DataTransferOrder = 59;
					num = (short)1340735500;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					this.radErgoWideStealthDisableLightLED_A36482 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("苏돑냓鏕꫗뷙돛觝觟蛡臣뗥鳧迩跫苭蓯髱냳鿵请鯹黻鋽旿丁洃愅怇縉䀋䬍吏䴑唓┕⸗⸙␛Ⱍ", a_), global::CommonResources.AcgResources.ID_STEALTHMODEDISABLELIGHTSLEDS);
					this.radErgoWideStealthDisableLightLED_A36482.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideStealthDisableLightLED_A36482.DataTransferOrder = -1;
					num = (short)537591816;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_215;
				case 3:
					goto IL_29C;
				case 4:
					num = (short)2109800458;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)1312751616;
					short num3 = num;
					this.radErgoWideStealthDisableTones_A36487 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("苏돑냓鏕꫗뷙돛觝觟蛡臣뗥鳧迩跫苭蓯髱냳鿵请鯹黻鋽旿嘁欃栅洇礉匋伍⌏␑–⸕⼗", a_), global::CommonResources.AcgResources.ID_STEALTHMODEDISABLETONES);
					this.radErgoWideStealthDisableTones_A36487.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideStealthDisableTones_A36487.DataTransferOrder = -1;
					num = (short)922812419;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苏돑냓鏕꫗뷙돛觝觟蛡臣뗥鳧迩跫苭蓯髱ꟳ韵軷鿹꿻諽旿持栃爅怇䜉挋樍甏䴑唓┕⸗⸙┛⼝", a_)))
					{
						num = (short)325713920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_339;
				case 7:
				{
					if (producerFields == null)
					{
						goto IL_339;
					}
					num = (short)378073846;
					short num4 = num;
					num = (short)1464595190;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_215;
					default:
						num = (short)859373568;
						if (num != 0)
						{
						}
						num = (short)188022788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					goto IL_12A;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苏돑냓鏕꫗뷙돛觝觟蛡臣뗥鳧迩跫苭蓯髱냳鿵请鯹黻鋽旿嘁欃栅洇礉匋伍⌏␑–⸕⼗", a_)))
					{
						num = (short)1143996421;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_29C;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苏돑냓鏕꫗뷙돛觝觟蛡臣뗥鳧迩跫苭蓯髱냳鿵请鯹黻鋽旿丁洃愅怇縉䀋䬍吏䴑唓┕⸗⸙␛Ⱍ", a_)))
					{
						num = (short)380239873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12A;
				case 11:
					num = (short)191627265;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_89;
					}
					continue;
				case 12:
					goto IL_210;
				}
				IL_89:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1366163458;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_12A:
				num = (short)692256777;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_215:
				num = (short)1841954823;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_29C:
				num = (short)2146631686;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_210:
			IL_339:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菏ꛑ뇓럕듗껙듛", a_);
			base.Id = 10603;
			base.UIName = global::CommonResources.AcgResources.ID_STEALTH;
			base.DataTransferOrder = 6;
		}

		// Token: 0x0600680E RID: 26638 RVA: 0x005D30F0 File Offset: 0x005D12F0
		public override void PopulateReferences()
		{
			short num = (short)1915581717;
			short num2 = num;
			num = (short)1018393877;
			switch (num2 == num)
			{
			}
			num = (short)566886400;
			if (num != 0)
			{
			}
			num = (short)1805058049;
			if (num != 0)
			{
			}
			num = (short)1465122816;
			short num3 = num;
		}

		// Token: 0x0600680F RID: 26639 RVA: 0x005D319C File Offset: 0x005D139C
		public override void DropReferences()
		{
			short num = (short)1802301205;
			short num2 = num;
			num = (short)1616703253;
			switch (num2 == num)
			{
			}
			num = (short)1266024449;
			if (num != 0)
			{
			}
			num = (short)1937178624;
			if (num != 0)
			{
			}
			num = (short)1698758656;
			short num3 = num;
		}

		// Token: 0x06006810 RID: 26640 RVA: 0x005D3244 File Offset: 0x005D1444
		public override void SetConstraints()
		{
			short num = (short)1044749628;
			short num2 = num;
			num = (short)1912839484;
			switch (num2 == num)
			{
			}
			num = (short)1703870465;
			if (num != 0)
			{
			}
			num = (short)743047168;
			if (num != 0)
			{
			}
			num = (short)1311047680;
			short num3 = num;
			this.radErgoWideStealthDisableLightLED_A36482.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConFieldsAlwaysNonEditable);
			this.radErgoWideStealthDisableTones_A36487.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConFieldsAlwaysNonEditable);
		}

		// Token: 0x06006811 RID: 26641 RVA: 0x005D331C File Offset: 0x005D151C
		public override void SetupDependencies()
		{
			short num = (short)866046515;
			short num2 = num;
			num = (short)254530099;
			switch (num2 == num)
			{
			}
			num = (short)1618673664;
			if (num != 0)
			{
			}
			num = (short)2095120385;
			if (num != 0)
			{
			}
			num = (short)2008809472;
			short num3 = num;
		}

		// Token: 0x170035F4 RID: 13812
		// (get) Token: 0x06006812 RID: 26642 RVA: 0x005D33C8 File Offset: 0x005D15C8
		public bool HasDiffs
		{
			get
			{
				short num = (short)403378633;
				short num2 = num;
				num = (short)369824201;
				switch (num2 == num)
				{
				}
				num = (short)195559425;
				if (num != 0)
				{
				}
				num = (short)654835712;
				if (num != 0)
				{
				}
				num = (short)1813970944;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x170035F5 RID: 13813
		// (get) Token: 0x06006813 RID: 26643 RVA: 0x005D3478 File Offset: 0x005D1678
		// (set) Token: 0x06006814 RID: 26644 RVA: 0x005D352C File Offset: 0x005D172C
		public bool RadErgoWideStealthDisableLightLED_A36482Value
		{
			get
			{
				short num = (short)1876361045;
				short num2 = num;
				num = (short)1153498965;
				switch (num2 == num)
				{
				}
				num = (short)256901120;
				if (num != 0)
				{
				}
				num = (short)861011969;
				if (num != 0)
				{
				}
				num = (short)775487488;
				short num3 = num;
				return this.radErgoWideStealthDisableLightLED_A36482.Value;
			}
			set
			{
				short num = (short)1368657609;
				short num2 = num;
				num = (short)1448087241;
				switch (num2 == num)
				{
				}
				num = (short)1042546689;
				if (num != 0)
				{
				}
				num = (short)1271857152;
				if (num != 0)
				{
				}
				num = (short)136249344;
				short num3 = num;
				this.radErgoWideStealthDisableLightLED_A36482.Value = value;
			}
		}

		// Token: 0x170035F6 RID: 13814
		// (get) Token: 0x06006815 RID: 26645 RVA: 0x005D35E0 File Offset: 0x005D17E0
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWideStealthDisableLightLED_A36482
		{
			get
			{
				short num = (short)2008850645;
				short num2 = num;
				num = (short)2002624725;
				switch (num2 == num)
				{
				}
				num = (short)1573781505;
				if (num != 0)
				{
				}
				num = (short)906493952;
				if (num != 0)
				{
				}
				num = (short)1945894912;
				short num3 = num;
				return this.radErgoWideStealthDisableLightLED_A36482;
			}
		}

		// Token: 0x170035F7 RID: 13815
		// (get) Token: 0x06006816 RID: 26646 RVA: 0x005D3690 File Offset: 0x005D1890
		// (set) Token: 0x06006817 RID: 26647 RVA: 0x005D3744 File Offset: 0x005D1944
		public bool RadErgoWideStealthDisableLightLED_A36482_UIValue
		{
			get
			{
				short num = (short)994049107;
				short num2 = num;
				num = (short)811203667;
				switch (num2 == num)
				{
				}
				num = (short)242745344;
				if (num != 0)
				{
				}
				num = (short)1950089217;
				if (num != 0)
				{
				}
				num = (short)549257216;
				short num3 = num;
				return this.radErgoWideStealthDisableLightLED_A36482.Value;
			}
			set
			{
				short num = (short)797163253;
				short num2 = num;
				num = (short)1326038773;
				switch (num2 == num)
				{
				}
				num = (short)560857089;
				if (num != 0)
				{
				}
				num = (short)2010972160;
				if (num != 0)
				{
				}
				num = (short)922157056;
				short num3 = num;
				this.radErgoWideStealthDisableLightLED_A36482.Value = value;
			}
		}

		// Token: 0x170035F8 RID: 13816
		// (get) Token: 0x06006818 RID: 26648 RVA: 0x005D37FC File Offset: 0x005D19FC
		// (set) Token: 0x06006819 RID: 26649 RVA: 0x005D38B0 File Offset: 0x005D1AB0
		public bool RadErgoWideStealthDisableLightLED_A36482_Applicable
		{
			get
			{
				short num = (short)1672060648;
				short num2 = num;
				num = (short)1384685288;
				switch (num2 == num)
				{
				}
				num = (short)2133262337;
				if (num != 0)
				{
				}
				num = (short)120586240;
				if (num != 0)
				{
				}
				num = (short)1332477952;
				short num3 = num;
				return this.radErgoWideStealthDisableLightLED_A36482.Applicable;
			}
			set
			{
				short num = (short)1253425064;
				short num2 = num;
				num = (short)920108968;
				switch (num2 == num)
				{
				}
				num = (short)653393920;
				if (num != 0)
				{
				}
				num = (short)1584332801;
				if (num != 0)
				{
				}
				num = (short)496173056;
				short num3 = num;
				this.radErgoWideStealthDisableLightLED_A36482.Applicable = value;
			}
		}

		// Token: 0x170035F9 RID: 13817
		// (get) Token: 0x0600681A RID: 26650 RVA: 0x005D3968 File Offset: 0x005D1B68
		// (set) Token: 0x0600681B RID: 26651 RVA: 0x005D3A1C File Offset: 0x005D1C1C
		public bool RadErgoWideStealthDisableLightLED_A36482_Valid
		{
			get
			{
				short num = (short)1217745068;
				short num2 = num;
				num = (short)1047941292;
				switch (num2 == num)
				{
				}
				num = (short)1333460993;
				if (num != 0)
				{
				}
				num = (short)1045102592;
				if (num != 0)
				{
				}
				num = (short)1225261056;
				short num3 = num;
				return this.radErgoWideStealthDisableLightLED_A36482.Valid;
			}
			set
			{
				short num = (short)1179633119;
				short num2 = num;
				num = (short)1951057375;
				switch (num2 == num)
				{
				}
				num = (short)424804353;
				if (num != 0)
				{
				}
				num = (short)478478336;
				if (num != 0)
				{
				}
				num = (short)233635840;
				short num3 = num;
				this.radErgoWideStealthDisableLightLED_A36482.Valid = value;
			}
		}

		// Token: 0x170035FA RID: 13818
		// (get) Token: 0x0600681C RID: 26652 RVA: 0x005D3AD4 File Offset: 0x005D1CD4
		// (set) Token: 0x0600681D RID: 26653 RVA: 0x005D3B8C File Offset: 0x005D1D8C
		public bool RadErgoWideStealthDisableLightLED_A36482_Visible
		{
			get
			{
				short num = (short)1140473642;
				short num2 = num;
				num = (short)1139621674;
				switch (num2 == num)
				{
				}
				num = (short)781320193;
				if (num != 0)
				{
				}
				num = (short)464650240;
				if (num != 0)
				{
				}
				num = (short)1512833024;
				short num3 = num;
				return this.radErgoWideStealthDisableLightLED_A36482.Visible;
			}
			set
			{
				short num = (short)423369297;
				short num2 = num;
				num = (short)294394449;
				switch (num2 == num)
				{
				}
				num = (short)1650720769;
				if (num != 0)
				{
				}
				num = (short)646971392;
				if (num != 0)
				{
				}
				num = (short)1648230400;
				short num3 = num;
				this.radErgoWideStealthDisableLightLED_A36482.Visible = value;
			}
		}

		// Token: 0x170035FB RID: 13819
		// (get) Token: 0x0600681E RID: 26654 RVA: 0x005D3C40 File Offset: 0x005D1E40
		// (set) Token: 0x0600681F RID: 26655 RVA: 0x005D3CF4 File Offset: 0x005D1EF4
		public bool RadErgoWideStealthDisableLightLED_A36482_Editable
		{
			get
			{
				short num = (short)1246858837;
				short num2 = num;
				num = (short)1213566549;
				switch (num2 == num)
				{
				}
				num = (short)1907818497;
				if (num != 0)
				{
				}
				num = (short)1447231488;
				if (num != 0)
				{
				}
				num = (short)1744240640;
				short num3 = num;
				return this.radErgoWideStealthDisableLightLED_A36482.Editable;
			}
			set
			{
				short num = (short)1057398461;
				short num2 = num;
				num = (short)152542909;
				switch (num2 == num)
				{
				}
				num = (short)1985544193;
				if (num != 0)
				{
				}
				num = (short)208797696;
				if (num != 0)
				{
				}
				num = (short)2137194496;
				short num3 = num;
				this.radErgoWideStealthDisableLightLED_A36482.Editable = value;
			}
		}

		// Token: 0x170035FC RID: 13820
		// (get) Token: 0x06006820 RID: 26656 RVA: 0x005D3DAC File Offset: 0x005D1FAC
		internal string RadErgoWideStealthDisableLightLED_A36482_UILabel
		{
			get
			{
				short num = (short)645715127;
				short num2 = num;
				num = (short)85447863;
				switch (num2 == num)
				{
				}
				num = (short)473628673;
				if (num != 0)
				{
				}
				num = (short)1495465984;
				if (num != 0)
				{
				}
				num = (short)1389232128;
				short num3 = num;
				return this.radErgoWideStealthDisableLightLED_A36482.UIName;
			}
		}

		// Token: 0x170035FD RID: 13821
		// (get) Token: 0x06006821 RID: 26657 RVA: 0x005D3E60 File Offset: 0x005D2060
		// (set) Token: 0x06006822 RID: 26658 RVA: 0x005D3F14 File Offset: 0x005D2114
		internal bool RadErgoWideStealthDisableLightLED_A36482_HiddenStatic
		{
			get
			{
				short num = (short)299533074;
				short num2 = num;
				num = (short)1908310802;
				switch (num2 == num)
				{
				}
				num = (short)482017281;
				if (num != 0)
				{
				}
				num = (short)1880424448;
				if (num != 0)
				{
				}
				num = (short)944701440;
				short num3 = num;
				return this.radErgoWideStealthDisableLightLED_A36482.HiddenStatic;
			}
			set
			{
				short num = (short)615120897;
				if (num != 0)
				{
				}
				num = (short)1234775599;
				short num2 = num;
				num = (short)1741106735;
				switch (num2 == num)
				{
				}
				num = (short)631963648;
				if (num != 0)
				{
				}
				num = (short)1292763136;
				short num3 = num;
				this.radErgoWideStealthDisableLightLED_A36482.HiddenStatic = value;
			}
		}

		// Token: 0x170035FE RID: 13822
		// (get) Token: 0x06006823 RID: 26659 RVA: 0x005D3FC8 File Offset: 0x005D21C8
		// (set) Token: 0x06006824 RID: 26660 RVA: 0x005D407C File Offset: 0x005D227C
		internal bool RadErgoWideStealthDisableLightLED_A36482_HiddenDynamic
		{
			get
			{
				short num = (short)1317462592;
				short num2 = num;
				num = (short)1055515200;
				switch (num2 == num)
				{
				}
				num = (short)735838208;
				if (num != 0)
				{
				}
				num = (short)1721040897;
				if (num != 0)
				{
				}
				num = (short)1368326144;
				short num3 = num;
				return this.radErgoWideStealthDisableLightLED_A36482.HiddenDynamic;
			}
			set
			{
				short num = (short)116281663;
				short num2 = num;
				num = (short)951144767;
				switch (num2 == num)
				{
				}
				num = (short)823525377;
				if (num != 0)
				{
				}
				num = (short)74776576;
				if (num != 0)
				{
				}
				num = (short)1376976896;
				short num3 = num;
				this.radErgoWideStealthDisableLightLED_A36482.HiddenDynamic = value;
			}
		}

		// Token: 0x170035FF RID: 13823
		// (get) Token: 0x06006825 RID: 26661 RVA: 0x005D4130 File Offset: 0x005D2330
		public bool RadErgoWideStealthDisableLightLED_A36482_HasDiffs
		{
			get
			{
				short num = (short)1304812746;
				short num2 = num;
				num = (short)872930506;
				switch (num2 == num)
				{
				}
				num = (short)1491468289;
				if (num != 0)
				{
				}
				num = (short)1273298944;
				if (num != 0)
				{
				}
				num = (short)1102774272;
				short num3 = num;
				return this.radErgoWideStealthDisableLightLED_A36482._HasDiffs;
			}
		}

		// Token: 0x17003600 RID: 13824
		// (get) Token: 0x06006826 RID: 26662 RVA: 0x005D41E4 File Offset: 0x005D23E4
		// (set) Token: 0x06006827 RID: 26663 RVA: 0x005D4298 File Offset: 0x005D2498
		public bool RadErgoWideStealthDisableTones_A36487Value
		{
			get
			{
				short num = (short)1507557341;
				short num2 = num;
				num = (short)1348567005;
				switch (num2 == num)
				{
				}
				num = (short)1121648641;
				if (num != 0)
				{
				}
				num = (short)823787520;
				if (num != 0)
				{
				}
				num = (short)209125376;
				short num3 = num;
				return this.radErgoWideStealthDisableTones_A36487.Value;
			}
			set
			{
				short num = (short)1765391380;
				short num2 = num;
				num = (short)1997126676;
				switch (num2 == num)
				{
				}
				num = (short)1746862081;
				if (num != 0)
				{
				}
				num = (short)1454833664;
				if (num != 0)
				{
				}
				num = (short)144506880;
				short num3 = num;
				this.radErgoWideStealthDisableTones_A36487.Value = value;
			}
		}

		// Token: 0x17003601 RID: 13825
		// (get) Token: 0x06006828 RID: 26664 RVA: 0x005D434C File Offset: 0x005D254C
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWideStealthDisableTones_A36487
		{
			get
			{
				short num = (short)1031603002;
				short num2 = num;
				num = (short)322241338;
				switch (num2 == num)
				{
				}
				num = (short)1030815744;
				if (num != 0)
				{
				}
				num = (short)1925906433;
				if (num != 0)
				{
				}
				num = (short)761069568;
				short num3 = num;
				return this.radErgoWideStealthDisableTones_A36487;
			}
		}

		// Token: 0x17003602 RID: 13826
		// (get) Token: 0x06006829 RID: 26665 RVA: 0x005D4400 File Offset: 0x005D2600
		// (set) Token: 0x0600682A RID: 26666 RVA: 0x005D44B4 File Offset: 0x005D26B4
		public bool RadErgoWideStealthDisableTones_A36487_UIValue
		{
			get
			{
				short num = (short)1083461168;
				short num2 = num;
				num = (short)288116272;
				switch (num2 == num)
				{
				}
				num = (short)566820864;
				if (num != 0)
				{
				}
				num = (short)570818561;
				if (num != 0)
				{
				}
				num = (short)1589313536;
				short num3 = num;
				return this.radErgoWideStealthDisableTones_A36487.Value;
			}
			set
			{
				short num = (short)1252333813;
				short num2 = num;
				num = (short)995891445;
				switch (num2 == num)
				{
				}
				num = (short)353107969;
				if (num != 0)
				{
				}
				num = (short)215547904;
				if (num != 0)
				{
				}
				num = (short)438829056;
				short num3 = num;
				this.radErgoWideStealthDisableTones_A36487.Value = value;
			}
		}

		// Token: 0x17003603 RID: 13827
		// (get) Token: 0x0600682B RID: 26667 RVA: 0x005D456C File Offset: 0x005D276C
		// (set) Token: 0x0600682C RID: 26668 RVA: 0x005D4624 File Offset: 0x005D2824
		public bool RadErgoWideStealthDisableTones_A36487_Applicable
		{
			get
			{
				short num = (short)1690155175;
				short num2 = num;
				num = (short)539867303;
				switch (num2 == num)
				{
				}
				num = (short)1025048577;
				if (num != 0)
				{
				}
				num = (short)1022099456;
				if (num != 0)
				{
				}
				num = (short)1597440000;
				short num3 = num;
				return this.radErgoWideStealthDisableTones_A36487.Applicable;
			}
			set
			{
				short num = (short)1378512237;
				short num2 = num;
				num = (short)192834925;
				switch (num2 == num)
				{
				}
				num = (short)708837376;
				if (num != 0)
				{
				}
				num = (short)526516225;
				if (num != 0)
				{
				}
				num = (short)150798336;
				short num3 = num;
				this.radErgoWideStealthDisableTones_A36487.Applicable = value;
			}
		}

		// Token: 0x17003604 RID: 13828
		// (get) Token: 0x0600682D RID: 26669 RVA: 0x005D46DC File Offset: 0x005D28DC
		// (set) Token: 0x0600682E RID: 26670 RVA: 0x005D4794 File Offset: 0x005D2994
		public bool RadErgoWideStealthDisableTones_A36487_Valid
		{
			get
			{
				short num = (short)1685966190;
				short num2 = num;
				num = (short)1991691630;
				switch (num2 == num)
				{
				}
				num = (short)1793458177;
				if (num != 0)
				{
				}
				num = (short)1301544960;
				if (num != 0)
				{
				}
				num = (short)2042494976;
				short num3 = num;
				return this.radErgoWideStealthDisableTones_A36487.Valid;
			}
			set
			{
				short num = (short)670208043;
				short num2 = num;
				num = (short)1731301419;
				switch (num2 == num)
				{
				}
				num = (short)445710336;
				if (num != 0)
				{
				}
				num = (short)585105409;
				if (num != 0)
				{
				}
				num = (short)1476198400;
				short num3 = num;
				this.radErgoWideStealthDisableTones_A36487.Valid = value;
			}
		}

		// Token: 0x17003605 RID: 13829
		// (get) Token: 0x0600682F RID: 26671 RVA: 0x005D4848 File Offset: 0x005D2A48
		// (set) Token: 0x06006830 RID: 26672 RVA: 0x005D48F8 File Offset: 0x005D2AF8
		public bool RadErgoWideStealthDisableTones_A36487_Visible
		{
			get
			{
				short num = (short)187156803;
				short num2 = num;
				num = (short)1756678467;
				switch (num2 == num)
				{
				}
				num = (short)1378222081;
				if (num != 0)
				{
				}
				num = (short)2006515712;
				if (num != 0)
				{
				}
				num = (short)1914109952;
				short num3 = num;
				return this.radErgoWideStealthDisableTones_A36487.Visible;
			}
			set
			{
				short num = (short)132933239;
				short num2 = num;
				num = (short)358442615;
				switch (num2 == num)
				{
				}
				num = (short)678690816;
				if (num != 0)
				{
				}
				num = (short)1269628929;
				if (num != 0)
				{
				}
				num = (short)2143092736;
				short num3 = num;
				this.radErgoWideStealthDisableTones_A36487.Visible = value;
			}
		}

		// Token: 0x17003606 RID: 13830
		// (get) Token: 0x06006831 RID: 26673 RVA: 0x005D49AC File Offset: 0x005D2BAC
		// (set) Token: 0x06006832 RID: 26674 RVA: 0x005D4A60 File Offset: 0x005D2C60
		public bool RadErgoWideStealthDisableTones_A36487_Editable
		{
			get
			{
				short num = (short)1696787063;
				short num2 = num;
				num = (short)701753975;
				switch (num2 == num)
				{
				}
				num = (short)1766195201;
				if (num != 0)
				{
				}
				num = (short)78053376;
				if (num != 0)
				{
				}
				num = (short)2006253568;
				short num3 = num;
				return this.radErgoWideStealthDisableTones_A36487.Editable;
			}
			set
			{
				short num = (short)228624777;
				short num2 = num;
				num = (short)671058313;
				switch (num2 == num)
				{
				}
				num = (short)231669761;
				if (num != 0)
				{
				}
				num = (short)863174656;
				if (num != 0)
				{
				}
				num = (short)75563008;
				short num3 = num;
				this.radErgoWideStealthDisableTones_A36487.Editable = value;
			}
		}

		// Token: 0x17003607 RID: 13831
		// (get) Token: 0x06006833 RID: 26675 RVA: 0x005D4B18 File Offset: 0x005D2D18
		internal string RadErgoWideStealthDisableTones_A36487_UILabel
		{
			get
			{
				short num = (short)950087468;
				short num2 = num;
				num = (short)273231660;
				switch (num2 == num)
				{
				}
				num = (short)1089339393;
				if (num != 0)
				{
				}
				num = (short)2095382528;
				if (num != 0)
				{
				}
				num = (short)597819392;
				short num3 = num;
				return this.radErgoWideStealthDisableTones_A36487.UIName;
			}
		}

		// Token: 0x17003608 RID: 13832
		// (get) Token: 0x06006834 RID: 26676 RVA: 0x005D4BCC File Offset: 0x005D2DCC
		// (set) Token: 0x06006835 RID: 26677 RVA: 0x005D4C80 File Offset: 0x005D2E80
		internal bool RadErgoWideStealthDisableTones_A36487_HiddenStatic
		{
			get
			{
				short num = (short)600758336;
				short num2 = num;
				num = (short)1715722304;
				switch (num2 == num)
				{
				}
				num = (short)428736512;
				if (num != 0)
				{
				}
				num = (short)730988545;
				if (num != 0)
				{
				}
				num = (short)45809664;
				short num3 = num;
				return this.radErgoWideStealthDisableTones_A36487.HiddenStatic;
			}
			set
			{
				short num = (short)1302112842;
				short num2 = num;
				num = (short)1911401034;
				switch (num2 == num)
				{
				}
				num = (short)1524695041;
				if (num != 0)
				{
				}
				num = (short)1388707840;
				if (num != 0)
				{
				}
				num = (short)691077120;
				short num3 = num;
				this.radErgoWideStealthDisableTones_A36487.HiddenStatic = value;
			}
		}

		// Token: 0x17003609 RID: 13833
		// (get) Token: 0x06006836 RID: 26678 RVA: 0x005D4D38 File Offset: 0x005D2F38
		// (set) Token: 0x06006837 RID: 26679 RVA: 0x005D4DEC File Offset: 0x005D2FEC
		internal bool RadErgoWideStealthDisableTones_A36487_HiddenDynamic
		{
			get
			{
				short num = (short)770667127;
				short num2 = num;
				num = (short)823358071;
				switch (num2 == num)
				{
				}
				num = (short)1923809281;
				if (num != 0)
				{
				}
				num = (short)1502347264;
				if (num != 0)
				{
				}
				num = (short)338558976;
				short num3 = num;
				return this.radErgoWideStealthDisableTones_A36487.HiddenDynamic;
			}
			set
			{
				short num = (short)1071423354;
				short num2 = num;
				num = (short)1433509754;
				switch (num2 == num)
				{
				}
				num = (short)1771241473;
				if (num != 0)
				{
				}
				num = (short)701104128;
				if (num != 0)
				{
				}
				num = (short)738787328;
				short num3 = num;
				this.radErgoWideStealthDisableTones_A36487.HiddenDynamic = value;
			}
		}

		// Token: 0x1700360A RID: 13834
		// (get) Token: 0x06006838 RID: 26680 RVA: 0x005D4EA4 File Offset: 0x005D30A4
		public bool RadErgoWideStealthDisableTones_A36487_HasDiffs
		{
			get
			{
				short num = (short)1892678545;
				short num2 = num;
				num = (short)370539409;
				switch (num2 == num)
				{
				}
				num = (short)1674641409;
				if (num != 0)
				{
				}
				num = (short)469630976;
				if (num != 0)
				{
				}
				num = (short)1194983424;
				short num3 = num;
				return this.radErgoWideStealthDisableTones_A36487._HasDiffs;
			}
		}

		// Token: 0x1700360B RID: 13835
		// (get) Token: 0x06006839 RID: 26681 RVA: 0x005D4F5C File Offset: 0x005D315C
		// (set) Token: 0x0600683A RID: 26682 RVA: 0x005D5010 File Offset: 0x005D3210
		public bool RadErgoWideStealthSaveStealthMode_A36491Value
		{
			get
			{
				short num = (short)512950665;
				short num2 = num;
				num = (short)2128413065;
				switch (num2 == num)
				{
				}
				num = (short)457375745;
				if (num != 0)
				{
				}
				num = (short)1291649024;
				if (num != 0)
				{
				}
				num = (short)59179008;
				short num3 = num;
				return this.radErgoWideStealthSaveStealthMode_A36491.Value;
			}
			set
			{
				short num = (short)312045871;
				short num2 = num;
				num = (short)2112778543;
				switch (num2 == num)
				{
				}
				num = (short)1911881729;
				if (num != 0)
				{
				}
				num = (short)1128529920;
				if (num != 0)
				{
				}
				num = (short)943194112;
				short num3 = num;
				this.radErgoWideStealthSaveStealthMode_A36491.Value = value;
			}
		}

		// Token: 0x1700360C RID: 13836
		// (get) Token: 0x0600683B RID: 26683 RVA: 0x005D50C8 File Offset: 0x005D32C8
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWideStealthSaveStealthMode_A36491
		{
			get
			{
				short num = (short)1430745857;
				short num2 = num;
				num = (short)1272607489;
				switch (num2 == num)
				{
				}
				num = (short)435093505;
				if (num != 0)
				{
				}
				num = (short)409468928;
				if (num != 0)
				{
				}
				num = (short)1416495104;
				short num3 = num;
				return this.radErgoWideStealthSaveStealthMode_A36491;
			}
		}

		// Token: 0x1700360D RID: 13837
		// (get) Token: 0x0600683C RID: 26684 RVA: 0x005D5178 File Offset: 0x005D3378
		// (set) Token: 0x0600683D RID: 26685 RVA: 0x005D5230 File Offset: 0x005D3430
		public bool RadErgoWideStealthSaveStealthMode_A36491_UIValue
		{
			get
			{
				short num = (short)1370943214;
				short num2 = num;
				num = (short)187231982;
				switch (num2 == num)
				{
				}
				num = (short)2030895105;
				if (num != 0)
				{
				}
				num = (short)1933508608;
				if (num != 0)
				{
				}
				num = (short)423624704;
				short num3 = num;
				return this.radErgoWideStealthSaveStealthMode_A36491.Value;
			}
			set
			{
				short num = (short)1282178419;
				short num2 = num;
				num = (short)587496819;
				switch (num2 == num)
				{
				}
				num = (short)738983937;
				if (num != 0)
				{
				}
				num = (short)254214144;
				if (num != 0)
				{
				}
				num = (short)45613056;
				short num3 = num;
				this.radErgoWideStealthSaveStealthMode_A36491.Value = value;
			}
		}

		// Token: 0x1700360E RID: 13838
		// (get) Token: 0x0600683E RID: 26686 RVA: 0x005D52E4 File Offset: 0x005D34E4
		// (set) Token: 0x0600683F RID: 26687 RVA: 0x005D5398 File Offset: 0x005D3598
		public bool RadErgoWideStealthSaveStealthMode_A36491_Applicable
		{
			get
			{
				short num = (short)135665849;
				short num2 = num;
				num = (short)1054873785;
				switch (num2 == num)
				{
				}
				num = (short)80478208;
				if (num != 0)
				{
				}
				num = (short)1533935617;
				if (num != 0)
				{
				}
				num = (short)1772355584;
				short num3 = num;
				return this.radErgoWideStealthSaveStealthMode_A36491.Applicable;
			}
			set
			{
				short num = (short)1754729858;
				short num2 = num;
				num = (short)952110466;
				switch (num2 == num)
				{
				}
				num = (short)1864368129;
				if (num != 0)
				{
				}
				num = (short)845086720;
				if (num != 0)
				{
				}
				num = (short)345702400;
				short num3 = num;
				this.radErgoWideStealthSaveStealthMode_A36491.Applicable = value;
			}
		}

		// Token: 0x1700360F RID: 13839
		// (get) Token: 0x06006840 RID: 26688 RVA: 0x005D544C File Offset: 0x005D364C
		// (set) Token: 0x06006841 RID: 26689 RVA: 0x005D5500 File Offset: 0x005D3700
		public bool RadErgoWideStealthSaveStealthMode_A36491_Valid
		{
			get
			{
				short num = (short)1728039144;
				short num2 = num;
				num = (short)1754581224;
				switch (num2 == num)
				{
				}
				num = (short)1116864513;
				if (num != 0)
				{
				}
				num = (short)535166976;
				if (num != 0)
				{
				}
				num = (short)712572928;
				short num3 = num;
				return this.radErgoWideStealthSaveStealthMode_A36491.Valid;
			}
			set
			{
				short num = (short)2091607496;
				short num2 = num;
				num = (short)984049096;
				switch (num2 == num)
				{
				}
				num = (short)1029898241;
				if (num != 0)
				{
				}
				num = (short)1222115328;
				if (num != 0)
				{
				}
				num = (short)1797980160;
				short num3 = num;
				this.radErgoWideStealthSaveStealthMode_A36491.Valid = value;
			}
		}

		// Token: 0x17003610 RID: 13840
		// (get) Token: 0x06006842 RID: 26690 RVA: 0x005D55B8 File Offset: 0x005D37B8
		// (set) Token: 0x06006843 RID: 26691 RVA: 0x005D5670 File Offset: 0x005D3870
		public bool RadErgoWideStealthSaveStealthMode_A36491_Visible
		{
			get
			{
				short num = (short)377536701;
				short num2 = num;
				num = (short)599179453;
				switch (num2 == num)
				{
				}
				num = (short)585891841;
				if (num != 0)
				{
				}
				num = (short)1661796352;
				if (num != 0)
				{
				}
				num = (short)1578237952;
				short num3 = num;
				return this.radErgoWideStealthSaveStealthMode_A36491.Visible;
			}
			set
			{
				short num = (short)1639902416;
				short num2 = num;
				num = (short)551283920;
				switch (num2 == num)
				{
				}
				num = (short)401473536;
				if (num != 0)
				{
				}
				num = (short)842268673;
				if (num != 0)
				{
				}
				num = (short)340983808;
				short num3 = num;
				this.radErgoWideStealthSaveStealthMode_A36491.Visible = value;
			}
		}

		// Token: 0x17003611 RID: 13841
		// (get) Token: 0x06006844 RID: 26692 RVA: 0x005D5724 File Offset: 0x005D3924
		// (set) Token: 0x06006845 RID: 26693 RVA: 0x005D57DC File Offset: 0x005D39DC
		public bool RadErgoWideStealthSaveStealthMode_A36491_Editable
		{
			get
			{
				short num = (short)583925761;
				if (num != 0)
				{
				}
				num = (short)1151190215;
				short num2 = num;
				num = (short)1069532359;
				switch (num2 == num)
				{
				}
				num = (short)2101346304;
				if (num != 0)
				{
				}
				num = (short)1755643904;
				short num3 = num;
				return this.radErgoWideStealthSaveStealthMode_A36491.Editable;
			}
			set
			{
				short num = (short)525374165;
				short num2 = num;
				num = (short)1194496725;
				switch (num2 == num)
				{
				}
				num = (short)54919168;
				if (num != 0)
				{
				}
				num = (short)1390608385;
				if (num != 0)
				{
				}
				num = (short)345964544;
				short num3 = num;
				this.radErgoWideStealthSaveStealthMode_A36491.Editable = value;
			}
		}

		// Token: 0x17003612 RID: 13842
		// (get) Token: 0x06006846 RID: 26694 RVA: 0x005D5890 File Offset: 0x005D3A90
		internal string RadErgoWideStealthSaveStealthMode_A36491_UILabel
		{
			get
			{
				short num = (short)1850777045;
				short num2 = num;
				num = (short)1466342869;
				switch (num2 == num)
				{
				}
				num = (short)1187708929;
				if (num != 0)
				{
				}
				num = (short)1544617984;
				if (num != 0)
				{
				}
				num = (short)1429340160;
				short num3 = num;
				return this.radErgoWideStealthSaveStealthMode_A36491.UIName;
			}
		}

		// Token: 0x17003613 RID: 13843
		// (get) Token: 0x06006847 RID: 26695 RVA: 0x005D5948 File Offset: 0x005D3B48
		// (set) Token: 0x06006848 RID: 26696 RVA: 0x005D59FC File Offset: 0x005D3BFC
		internal bool RadErgoWideStealthSaveStealthMode_A36491_HiddenStatic
		{
			get
			{
				short num = (short)2038284402;
				short num2 = num;
				num = (short)140886130;
				switch (num2 == num)
				{
				}
				num = (short)245366784;
				if (num != 0)
				{
				}
				num = (short)1728839681;
				if (num != 0)
				{
				}
				num = (short)1125449728;
				short num3 = num;
				return this.radErgoWideStealthSaveStealthMode_A36491.HiddenStatic;
			}
			set
			{
				short num = (short)1255232085;
				short num2 = num;
				num = (short)310989397;
				switch (num2 == num)
				{
				}
				num = (short)1656553473;
				if (num != 0)
				{
				}
				num = (short)908656640;
				if (num != 0)
				{
				}
				num = (short)693305344;
				short num3 = num;
				this.radErgoWideStealthSaveStealthMode_A36491.HiddenStatic = value;
			}
		}

		// Token: 0x17003614 RID: 13844
		// (get) Token: 0x06006849 RID: 26697 RVA: 0x005D5AB0 File Offset: 0x005D3CB0
		// (set) Token: 0x0600684A RID: 26698 RVA: 0x005D5B68 File Offset: 0x005D3D68
		internal bool RadErgoWideStealthSaveStealthMode_A36491_HiddenDynamic
		{
			get
			{
				short num = (short)1141003701;
				short num2 = num;
				num = (short)1206015413;
				switch (num2 == num)
				{
				}
				num = (short)1103691777;
				if (num != 0)
				{
				}
				num = (short)1173815296;
				if (num != 0)
				{
				}
				num = (short)521338880;
				short num3 = num;
				return this.radErgoWideStealthSaveStealthMode_A36491.HiddenDynamic;
			}
			set
			{
				short num = (short)1823013914;
				short num2 = num;
				num = (short)2136603674;
				switch (num2 == num)
				{
				}
				num = (short)962920448;
				if (num != 0)
				{
				}
				num = (short)1719533569;
				if (num != 0)
				{
				}
				num = (short)365035520;
				short num3 = num;
				this.radErgoWideStealthSaveStealthMode_A36491.HiddenDynamic = value;
			}
		}

		// Token: 0x17003615 RID: 13845
		// (get) Token: 0x0600684B RID: 26699 RVA: 0x005D5C1C File Offset: 0x005D3E1C
		public bool RadErgoWideStealthSaveStealthMode_A36491_HasDiffs
		{
			get
			{
				short num = (short)1650442392;
				short num2 = num;
				num = (short)1328005272;
				switch (num2 == num)
				{
				}
				num = (short)1617887232;
				if (num != 0)
				{
				}
				num = (short)1418002433;
				if (num != 0)
				{
				}
				num = (short)824508416;
				short num3 = num;
				return this.radErgoWideStealthSaveStealthMode_A36491._HasDiffs;
			}
		}

		// Token: 0x0600684C RID: 26700 RVA: 0x005D5CCC File Offset: 0x005D3ECC
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num;
			int num4;
			global::AcpCommonLib.IAcpRecordset result;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)853182432;
					short num2 = num;
					num = (short)1740802016;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C2;
					default:
					{
						num = (short)533528577;
						if (num != 0)
						{
						}
						num = (short)1035862016;
						if (num != 0)
						{
						}
						num = (short)903348224;
						short num3 = num;
						switch (num4)
						{
						case 0:
							result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
							num = (short)497090564;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (base.ParentRecset.ContainerDoc != null)
							{
								num = (short)2077622272;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 2:
							if (base.ParentRecset != null)
							{
								num = (short)235208707;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 3:
							num = (short)59703297;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							return result;
						}
						goto IL_C0;
					}
					}
				}
				return result;
			}
			IL_C0:
			result = null;
			IL_C2:
			num = (short)1481572354;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0400290D RID: 10509
		private global::AcpBusinessLayer.AcpField<bool> radErgoWideStealthDisableLightLED_A36482;

		// Token: 0x0400290E RID: 10510
		private global::AcpBusinessLayer.AcpField<bool> radErgoWideStealthDisableTones_A36487;

		// Token: 0x0400290F RID: 10511
		private global::AcpBusinessLayer.AcpField<bool> radErgoWideStealthSaveStealthMode_A36491;
	}
}
