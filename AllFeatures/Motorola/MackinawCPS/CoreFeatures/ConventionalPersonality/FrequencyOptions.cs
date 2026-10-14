using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x020005BE RID: 1470
	[global::System.Serializable]
	public class FrequencyOptions : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600C48B RID: 50315 RVA: 0x00B84644 File Offset: 0x00B82844
		public FrequencyOptions(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600C48C RID: 50316 RVA: 0x00B84684 File Offset: 0x00B82884
		protected FrequencyOptions(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600C48D RID: 50317 RVA: 0x00B8469C File Offset: 0x00B8289C
		public override void Init()
		{
			int a_ = 11;
			short num = (short)187236353;
			if (num != 0)
			{
			}
			num = (short)971286830;
			short num2 = num;
			num = (short)790276398;
			switch (num2 == num)
			{
			}
			num = (short)1242234880;
			if (num != 0)
			{
			}
			num = (short)131465216;
			short num3 = num;
			this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉䔋怍搏眑易瀕紗栙礛瀝䌟䜡戣吥䴧嬩洫䈭尯崱䌳匵尷改紻਽爿灁煃煅", a_), global::CommonResources.AcgResources.ID_LTEINTERFERENCEFREQPRESENT);
			this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.DataTransferOrder = 175;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("請볍뗏ꏑꇓ돕뛗맙ꗛﻝ꿟鋡郣迥蟧蓩鿫", a_);
			base.Id = 10148;
			base.UIName = global::CommonResources.AcgResources.ID_FREQUENCYOPTIONS;
			base.DataTransferOrder = 14;
		}

		// Token: 0x0600C48E RID: 50318 RVA: 0x00B847C0 File Offset: 0x00B829C0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 11;
			short num = (short)1387069446;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1492910080;
					short num3 = num;
					num = (short)742391809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (producerFields != null)
					{
						num = (short)1355218946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E5;
				case 2:
					goto IL_1E0;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉䔋怍搏眑易瀕紗栙礛瀝䌟䜡戣吥䴧嬩洫䈭尯崱䌳匵尷改紻਽爿灁煃煅", a_)))
					{
						num = (short)1444020228;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E5;
				case 4:
					this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉䔋怍搏眑易瀕紗栙礛瀝䌟䜡戣吥䴧嬩洫䈭尯崱䌳匵尷改紻਽爿灁煃煅", a_), global::CommonResources.AcgResources.ID_LTEINTERFERENCEFREQPRESENT);
					this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.DataTransferOrder = 175;
					num = (short)1480654853;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_132;
				case 6:
				{
					num = (short)584086994;
					short num4 = num;
					num = (short)1651602898;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E0;
					default:
						num = (short)1618083840;
						if (num != 0)
						{
						}
						num = (short)1823735809;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_BB;
						}
						continue;
					}
					break;
				}
				}
				IL_BB:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)908918784;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1E0:
				num = (short)1986002947;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_132:
			IL_1E5:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("請볍뗏ꏑꇓ돕뛗맙ꗛﻝ꿟鋡郣迥蟧蓩鿫", a_);
			base.Id = 10148;
			base.UIName = global::CommonResources.AcgResources.ID_FREQUENCYOPTIONS;
			base.DataTransferOrder = 14;
		}

		// Token: 0x0600C48F RID: 50319 RVA: 0x00B849E4 File Offset: 0x00B82BE4
		public override void PopulateReferences()
		{
			short num = (short)140014262;
			short num2 = num;
			num = (short)593523382;
			switch (num2 == num)
			{
			}
			num = (short)1886846977;
			if (num != 0)
			{
			}
			num = (short)1207107584;
			if (num != 0)
			{
			}
			num = (short)81199104;
			short num3 = num;
		}

		// Token: 0x0600C490 RID: 50320 RVA: 0x00B84A8C File Offset: 0x00B82C8C
		public override void DropReferences()
		{
			short num = (short)1538996209;
			short num2 = num;
			num = (short)859191281;
			switch (num2 == num)
			{
			}
			num = (short)1990983680;
			if (num != 0)
			{
			}
			num = (short)104071169;
			if (num != 0)
			{
			}
			num = (short)1405616128;
			short num3 = num;
		}

		// Token: 0x0600C491 RID: 50321 RVA: 0x00B84B34 File Offset: 0x00B82D34
		public override void SetConstraints()
		{
			short num = (short)564684807;
			short num2 = num;
			num = (short)112814087;
			switch (num2 == num)
			{
			}
			num = (short)1249181697;
			if (num != 0)
			{
			}
			num = (short)961085440;
			if (num != 0)
			{
			}
			num = (short)1272381440;
			short num3 = num;
			this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConInterferenceFreqAllowedValid);
			this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConSetCnvLTEInterferenceFreqAllow);
		}

		// Token: 0x0600C492 RID: 50322 RVA: 0x00B84C08 File Offset: 0x00B82E08
		public override void SetupDependencies()
		{
			short num = (short)249149740;
			short num2 = num;
			num = (short)355383596;
			switch (num2 == num)
			{
			}
			num = (short)69730305;
			if (num != 0)
			{
			}
			num = (short)394657792;
			if (num != 0)
			{
			}
			num = (short)634912768;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257);
		}

		// Token: 0x1700626B RID: 25195
		// (get) Token: 0x0600C493 RID: 50323 RVA: 0x00B84CEC File Offset: 0x00B82EEC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1639628005;
				short num2 = num;
				num = (short)400866533;
				switch (num2 == num)
				{
				}
				num = (short)82575361;
				if (num != 0)
				{
				}
				num = (short)92536832;
				if (num != 0)
				{
				}
				num = (short)937885696;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x1700626C RID: 25196
		// (get) Token: 0x0600C494 RID: 50324 RVA: 0x00B84D98 File Offset: 0x00B82F98
		// (set) Token: 0x0600C495 RID: 50325 RVA: 0x00B84E50 File Offset: 0x00B83050
		public bool CnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257Value
		{
			get
			{
				short num = (short)423627783;
				short num2 = num;
				num = (short)235080711;
				switch (num2 == num)
				{
				}
				num = (short)997261313;
				if (num != 0)
				{
				}
				num = (short)618659840;
				if (num != 0)
				{
				}
				num = (short)1964507136;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.Value;
			}
			set
			{
				short num = (short)88875543;
				short num2 = num;
				num = (short)1378165271;
				switch (num2 == num)
				{
				}
				num = (short)1862336512;
				if (num != 0)
				{
				}
				num = (short)284557313;
				if (num != 0)
				{
				}
				num = (short)773128192;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.Value = value;
			}
		}

		// Token: 0x1700626D RID: 25197
		// (get) Token: 0x0600C496 RID: 50326 RVA: 0x00B84F04 File Offset: 0x00B83104
		public global::AcpBusinessLayer.AcpField<bool> CnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257
		{
			get
			{
				short num = (short)201261057;
				if (num != 0)
				{
				}
				num = (short)552114027;
				short num2 = num;
				num = (short)759469931;
				switch (num2 == num)
				{
				}
				num = (short)1998979072;
				if (num != 0)
				{
				}
				num = (short)365035520;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257;
			}
		}

		// Token: 0x1700626E RID: 25198
		// (get) Token: 0x0600C497 RID: 50327 RVA: 0x00B84FB8 File Offset: 0x00B831B8
		// (set) Token: 0x0600C498 RID: 50328 RVA: 0x00B8506C File Offset: 0x00B8326C
		public bool CnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257_UIValue
		{
			get
			{
				short num = (short)301592633;
				short num2 = num;
				num = (short)1501687865;
				switch (num2 == num)
				{
				}
				num = (short)748552193;
				if (num != 0)
				{
				}
				num = (short)29360128;
				if (num != 0)
				{
				}
				num = (short)1307508736;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.Value;
			}
			set
			{
				short num = (short)871410460;
				short num2 = num;
				num = (short)252881692;
				switch (num2 == num)
				{
				}
				num = (short)2111438848;
				if (num != 0)
				{
				}
				num = (short)259457025;
				if (num != 0)
				{
				}
				num = (short)115998720;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.Value = value;
			}
		}

		// Token: 0x1700626F RID: 25199
		// (get) Token: 0x0600C499 RID: 50329 RVA: 0x00B85124 File Offset: 0x00B83324
		// (set) Token: 0x0600C49A RID: 50330 RVA: 0x00B851D8 File Offset: 0x00B833D8
		public bool CnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257_Applicable
		{
			get
			{
				short num = (short)392924881;
				short num2 = num;
				num = (short)390893265;
				switch (num2 == num)
				{
				}
				num = (short)1872232449;
				if (num != 0)
				{
				}
				num = (short)41484288;
				if (num != 0)
				{
				}
				num = (short)432799744;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.Applicable;
			}
			set
			{
				short num = (short)598147073;
				if (num != 0)
				{
				}
				num = (short)634246393;
				short num2 = num;
				num = (short)249091321;
				switch (num2 == num)
				{
				}
				num = (short)1182138368;
				if (num != 0)
				{
				}
				num = (short)369557504;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.Applicable = value;
			}
		}

		// Token: 0x17006270 RID: 25200
		// (get) Token: 0x0600C49B RID: 50331 RVA: 0x00B8528C File Offset: 0x00B8348C
		// (set) Token: 0x0600C49C RID: 50332 RVA: 0x00B85344 File Offset: 0x00B83544
		public bool CnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257_Valid
		{
			get
			{
				short num = (short)1638920803;
				short num2 = num;
				num = (short)1303835235;
				switch (num2 == num)
				{
				}
				num = (short)490340353;
				if (num != 0)
				{
				}
				num = (short)1370030080;
				if (num != 0)
				{
				}
				num = (short)380436480;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.Valid;
			}
			set
			{
				short num = (short)817688864;
				short num2 = num;
				num = (short)1124987168;
				switch (num2 == num)
				{
				}
				num = (short)1549795328;
				if (num != 0)
				{
				}
				num = (short)43712513;
				if (num != 0)
				{
				}
				num = (short)563937280;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.Valid = value;
			}
		}

		// Token: 0x17006271 RID: 25201
		// (get) Token: 0x0600C49D RID: 50333 RVA: 0x00B853FC File Offset: 0x00B835FC
		// (set) Token: 0x0600C49E RID: 50334 RVA: 0x00B854B0 File Offset: 0x00B836B0
		public bool CnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257_Visible
		{
			get
			{
				short num = (short)34441537;
				short num2 = num;
				num = (short)1212057921;
				switch (num2 == num)
				{
				}
				num = (short)1279328257;
				if (num != 0)
				{
				}
				num = (short)1899954176;
				if (num != 0)
				{
				}
				num = (short)1038680064;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.Visible;
			}
			set
			{
				short num = (short)476192041;
				short num2 = num;
				num = (short)1809194281;
				switch (num2 == num)
				{
				}
				num = (short)1830486017;
				if (num != 0)
				{
				}
				num = (short)1820917760;
				if (num != 0)
				{
				}
				num = (short)565313536;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.Visible = value;
			}
		}

		// Token: 0x17006272 RID: 25202
		// (get) Token: 0x0600C49F RID: 50335 RVA: 0x00B85564 File Offset: 0x00B83764
		// (set) Token: 0x0600C4A0 RID: 50336 RVA: 0x00B85618 File Offset: 0x00B83818
		public bool CnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257_Editable
		{
			get
			{
				short num = (short)1249247233;
				if (num != 0)
				{
				}
				num = (short)584903656;
				short num2 = num;
				num = (short)798551016;
				switch (num2 == num)
				{
				}
				num = (short)281935872;
				if (num != 0)
				{
				}
				num = (short)486604800;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.Editable;
			}
			set
			{
				short num = (short)104626275;
				short num2 = num;
				num = (short)2093185123;
				switch (num2 == num)
				{
				}
				num = (short)925761536;
				if (num != 0)
				{
				}
				num = (short)2026373121;
				if (num != 0)
				{
				}
				num = (short)389087232;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.Editable = value;
			}
		}

		// Token: 0x17006273 RID: 25203
		// (get) Token: 0x0600C4A1 RID: 50337 RVA: 0x00B856CC File Offset: 0x00B838CC
		internal string CnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257_UILabel
		{
			get
			{
				short num = (short)151341597;
				short num2 = num;
				num = (short)2137999901;
				switch (num2 == num)
				{
				}
				num = (short)1579679745;
				if (num != 0)
				{
				}
				num = (short)606601216;
				if (num != 0)
				{
				}
				num = (short)563478528;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.UIName;
			}
		}

		// Token: 0x17006274 RID: 25204
		// (get) Token: 0x0600C4A2 RID: 50338 RVA: 0x00B85784 File Offset: 0x00B83984
		// (set) Token: 0x0600C4A3 RID: 50339 RVA: 0x00B85838 File Offset: 0x00B83A38
		internal bool CnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257_HiddenStatic
		{
			get
			{
				short num = (short)411788854;
				short num2 = num;
				num = (short)652961334;
				switch (num2 == num)
				{
				}
				num = (short)877920257;
				if (num != 0)
				{
				}
				num = (short)1885798400;
				if (num != 0)
				{
				}
				num = (short)137297920;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.HiddenStatic;
			}
			set
			{
				short num = (short)502256645;
				short num2 = num;
				num = (short)2112476165;
				switch (num2 == num)
				{
				}
				num = (short)690683905;
				if (num != 0)
				{
				}
				num = (short)790691840;
				if (num != 0)
				{
				}
				num = (short)294780928;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.HiddenStatic = value;
			}
		}

		// Token: 0x17006275 RID: 25205
		// (get) Token: 0x0600C4A4 RID: 50340 RVA: 0x00B858EC File Offset: 0x00B83AEC
		// (set) Token: 0x0600C4A5 RID: 50341 RVA: 0x00B859A4 File Offset: 0x00B83BA4
		internal bool CnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257_HiddenDynamic
		{
			get
			{
				short num = (short)310491394;
				short num2 = num;
				num = (short)1981069570;
				switch (num2 == num)
				{
				}
				num = (short)1633353729;
				if (num != 0)
				{
				}
				num = (short)1021837312;
				if (num != 0)
				{
				}
				num = (short)815661056;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.HiddenDynamic;
			}
			set
			{
				short num = (short)331808769;
				if (num != 0)
				{
				}
				num = (short)939249861;
				short num2 = num;
				num = (short)974770373;
				switch (num2 == num)
				{
				}
				num = (short)1891958784;
				if (num != 0)
				{
				}
				num = (short)1359085568;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.HiddenDynamic = value;
			}
		}

		// Token: 0x17006276 RID: 25206
		// (get) Token: 0x0600C4A6 RID: 50342 RVA: 0x00B85A5C File Offset: 0x00B83C5C
		public bool CnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257_HasDiffs
		{
			get
			{
				short num = (short)1561027322;
				short num2 = num;
				num = (short)1626563322;
				switch (num2 == num)
				{
				}
				num = (short)1496383489;
				if (num != 0)
				{
				}
				num = (short)878051328;
				if (num != 0)
				{
				}
				num = (short)1628504064;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257._HasDiffs;
			}
		}

		// Token: 0x0600C4A7 RID: 50343 RVA: 0x00B85B10 File Offset: 0x00B83D10
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
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)894276474;
					short num3 = num2;
					num2 = (short)1574933370;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AF;
					default:
						num2 = (short)1551761408;
						if (num2 != 0)
						{
						}
						num2 = (short)1538260994;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)2078736384;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					return result;
				case 3:
					goto IL_AF;
				case 4:
				{
					num2 = (short)68288512;
					short num4 = num2;
					num2 = (short)1265434625;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset != null)
					{
						num2 = (short)709230595;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				}
				goto IL_24;
				IL_AF:
				num2 = (short)661127169;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1129906180;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04006488 RID: 25736
		private global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset innerRecset;

		// Token: 0x04006489 RID: 25737
		private global::AcpBusinessLayer.AcpField<bool> cnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257;
	}
}
