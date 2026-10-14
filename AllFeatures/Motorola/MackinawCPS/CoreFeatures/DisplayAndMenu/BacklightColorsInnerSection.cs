using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu
{
	// Token: 0x02000274 RID: 628
	[global::System.Serializable]
	public class BacklightColorsInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600703A RID: 28730 RVA: 0x0063DBEC File Offset: 0x0063BDEC
		public BacklightColorsInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600703B RID: 28731 RVA: 0x0063DC08 File Offset: 0x0063BE08
		protected BacklightColorsInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600703C RID: 28732 RVA: 0x0063DC20 File Offset: 0x0063BE20
		public override void Init()
		{
			int a_ = 0;
			short num = (short)357376344;
			short num2 = num;
			num = (short)1627398488;
			switch (num2 == num)
			{
			}
			num = (short)463536128;
			short num3 = num;
			num = (short)1048641536;
			if (num != 0)
			{
			}
			num = (short)152633345;
			if (num != 0)
			{
			}
			this.dispMenuLabtoolBlue1_A7565 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("藀ꫂ뛄럆蓈껊ꏌ뫎鷐닒럔ꏖ뛘듚뇜鷞跠離胤훦뛨ꫪ\udaec\udaee쟰웲", a_), global::CommonResources.AcgResources.ID_BLUE, 0, 100, 5, null, null);
			this.dispMenuLabtoolBlue1_A7565.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dispMenuLabtoolBlue1_A7565.DataTransferOrder = -1;
			this.dispMenuLabtoolBlue1_A7565.ShowHexValue = false;
			this.dispMenuLabtoolColorText1_A7689 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("藀ꫂ뛄럆蓈껊ꏌ뫎鷐닒럔ꏖ뛘듚뇜鳞軠迢諤闦뷨軪闬鯮샰곲듴샶쿸쏺쓼", a_), global::CommonResources.AcgResources.ID_COLORTEXT, 14);
			this.dispMenuLabtoolColorText1_A7689.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dispMenuLabtoolColorText1_A7689.DataTransferOrder = 41;
			this.dispMenuLabtoolConfigurable1_A7700 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藀ꫂ뛄럆蓈껊ꏌ뫎鷐닒럔ꏖ뛘듚뇜鳞軠跢菤軦軨黪鿬軮鏰鿲郴웶꛸뫺쫼죾㄀㌂", a_), global::CommonResources.AcgResources.ID_CONFIGURABLE);
			this.dispMenuLabtoolConfigurable1_A7700.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dispMenuLabtoolConfigurable1_A7700.DataTransferOrder = -1;
			this.dispMenuLabtoolGreen1_A8172 = new global::AcpBusinessLayer.AcpCustomRangeField(40, this, global::AllFeatures.CodeplugGuid.b("藀ꫂ뛄럆蓈껊ꏌ뫎鷐닒럔ꏖ뛘듚뇜飞鏠蛢胤触\ud8e8듪곬ퟮ샰쓲쟴", a_), global::CommonResources.AcgResources.ID_GREEN, 0, 100, 5, null, null);
			this.dispMenuLabtoolGreen1_A8172.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dispMenuLabtoolGreen1_A8172.DataTransferOrder = 43;
			this.dispMenuLabtoolGreen1_A8172.ShowHexValue = false;
			this.dispMenuLabtoolRed1_A8923 = new global::AcpBusinessLayer.AcpCustomRangeField(100, this, global::AllFeatures.CodeplugGuid.b("藀ꫂ뛄럆蓈껊ꏌ뫎鷐닒럔ꏖ뛘듚뇜跞蓠蟢퓤룦꣨폪퓬\uddee싰", a_), global::CommonResources.AcgResources.ID_RED, 0, 100, 5, null, null);
			this.dispMenuLabtoolRed1_A8923.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dispMenuLabtoolRed1_A8923.DataTransferOrder = 42;
			this.dispMenuLabtoolRed1_A8923.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菀ꋂꛄ곆ꗈꋊ꫌꟎ꗐ雔룖뗘듚꿜", a_);
			base.Id = 10216;
			base.UIName = global::CommonResources.AcgResources.ID_BACKLIGHTCOLOR;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600703D RID: 28733 RVA: 0x0063DE58 File Offset: 0x0063C058
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 14;
			short num = (short)1905328128;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_7B;
					}
					continue;
				case 1:
					goto IL_1AA;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诎룐ꃒꗔ髖볘뗚꣜鏞胠臢釤裦蛨蟪뿬諮闰싲ꫴ뛶쇸싺쿼쳾", a_)))
					{
						num = (short)349437966;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4C5;
				case 3:
					this.dispMenuLabtoolConfigurable1_A7700 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("诎룐ꃒꗔ髖볘뗚꣜鏞胠臢釤裦蛨蟪껬胮鿰闲鳴郶賸觺鳼鷾洀昂㐄堆䠈㰊㨌㼎ℐ", a_), global::CommonResources.AcgResources.ID_CONFIGURABLE);
					this.dispMenuLabtoolConfigurable1_A7700.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dispMenuLabtoolConfigurable1_A7700.DataTransferOrder = -1;
					num = (short)2085027858;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_2F5;
				case 5:
					this.dispMenuLabtoolGreen1_A8172 = new global::AcpBusinessLayer.AcpCustomRangeField(40, this, global::AllFeatures.CodeplugGuid.b("诎룐ꃒꗔ髖볘뗚꣜鏞胠臢釤裦蛨蟪ꫬ鷮铰雲鯴웶꛸뫺염컾㘀㄂", a_), global::CommonResources.AcgResources.ID_GREEN, null, null);
					this.dispMenuLabtoolGreen1_A8172.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dispMenuLabtoolGreen1_A8172.DataTransferOrder = 43;
					this.dispMenuLabtoolGreen1_A8172.ShowHexValue = false;
					num = (short)1322975233;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)2037189901;
					short num3 = num;
					num = (short)1827802381;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_135;
					default:
						num = (short)902889473;
						if (num != 0)
						{
						}
						num = (short)323616768;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诎룐ꃒꗔ髖볘뗚꣜鏞胠臢釤裦蛨蟪껬胮鷰鳲蟴ꏶ鳸菺觼컾帀䈂㈄ㄆㄈ㈊", a_)))
						{
							num = (short)1208745996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EC;
					}
					break;
				}
				case 7:
					if (producerFields != null)
					{
						num = (short)1686372368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4C5;
				case 8:
					num = (short)1782382599;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诎룐ꃒꗔ髖볘뗚꣜鏞胠臢釤裦蛨蟪꿬菮蓰雲쓴ꣶ룸쳺주짾㐀", a_)))
					{
						num = (short)586678283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_405;
				case 10:
					goto IL_405;
				case 11:
					this.dispMenuLabtoolBlue1_A7565 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("诎룐ꃒꗔ髖볘뗚꣜鏞胠臢釤裦蛨蟪꿬菮蓰雲쓴ꣶ룸쳺주짾㐀", a_), global::CommonResources.AcgResources.ID_BLUE, null, null);
					this.dispMenuLabtoolBlue1_A7565.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dispMenuLabtoolBlue1_A7565.DataTransferOrder = -1;
					this.dispMenuLabtoolBlue1_A7565.ShowHexValue = false;
					num = (short)281018378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					this.dispMenuLabtoolColorText1_A7689 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("诎룐ꃒꗔ髖볘뗚꣜鏞胠臢釤裦蛨蟪껬胮鷰鳲蟴ꏶ鳸菺觼컾帀䈂㈄ㄆㄈ㈊", a_), global::CommonResources.AcgResources.ID_COLORTEXT, 14);
					this.dispMenuLabtoolColorText1_A7689.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dispMenuLabtoolColorText1_A7689.DataTransferOrder = 41;
					num = (short)1548419085;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_EC;
				case 14:
					this.dispMenuLabtoolRed1_A8923 = new global::AcpBusinessLayer.AcpCustomRangeField(100, this, global::AllFeatures.CodeplugGuid.b("诎룐ꃒꗔ髖볘뗚꣜鏞胠臢釤裦蛨蟪뿬諮闰싲ꫴ뛶쇸싺쿼쳾", a_), global::CommonResources.AcgResources.ID_RED, null, null);
					this.dispMenuLabtoolRed1_A8923.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dispMenuLabtoolRed1_A8923.DataTransferOrder = 42;
					this.dispMenuLabtoolRed1_A8923.ShowHexValue = false;
					num = (short)1977417732;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诎룐ꃒꗔ髖볘뗚꣜鏞胠臢釤裦蛨蟪껬胮鿰闲鳴郶賸觺鳼鷾洀昂㐄堆䠈㰊㨌㼎ℐ", a_)))
					{
						num = (short)1963589635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A0;
				case 16:
					goto IL_135;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诎룐ꃒꗔ髖볘뗚꣜鏞胠臢釤裦蛨蟪ꫬ鷮铰雲鯴웶꛸뫺염컾㘀㄂", a_)))
					{
						num = (short)2091188229;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AA;
				case 18:
					goto IL_A0;
				}
				IL_7B:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)916717576;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A0:
				num = (short)325845009;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EC:
				num = (short)1027407887;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_135:
				num = (short)1216086016;
				short num4 = num;
				num = (short)1727987721;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1AA:
				num = (short)969932802;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_405:
				num = (short)1451163654;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2F5:
			IL_4C5:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("跎냐냒뻔믖냘볚뗜ꯞ쇠ꃢ諤详蛨駪", a_);
			base.Id = 10216;
			base.UIName = global::CommonResources.AcgResources.ID_BACKLIGHTCOLOR;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600703E RID: 28734 RVA: 0x0063E35C File Offset: 0x0063C55C
		public override void PopulateReferences()
		{
			short num = (short)222892590;
			short num2 = num;
			num = (short)1051464238;
			switch (num2 == num)
			{
			default:
			{
				num = (short)385089536;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2069299200;
			if (num != 0)
			{
			}
			num = (short)1576861697;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600703F RID: 28735 RVA: 0x0063E404 File Offset: 0x0063C604
		public override void DropReferences()
		{
			short num = (short)146557078;
			short num2 = num;
			num = (short)1029064854;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1285095424;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2036400129;
			if (num != 0)
			{
			}
			num = (short)1599733760;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007040 RID: 28736 RVA: 0x0063E4AC File Offset: 0x0063C6AC
		public override void SetConstraints()
		{
			short num = (short)1983381505;
			if (num != 0)
			{
			}
			num = (short)1062666240;
			short num2 = num;
			num = (short)1117651866;
			short num3 = num;
			num = (short)1092092826;
			switch (num3 == num)
			{
			}
			num = (short)1720451072;
			if (num != 0)
			{
			}
			this.dispMenuLabtoolGreen1_A8172.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.ConPretendColorIsEditable);
			this.dispMenuLabtoolRed1_A8923.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.ConPretendColorIsEditable);
		}

		// Token: 0x06007041 RID: 28737 RVA: 0x0063E584 File Offset: 0x0063C784
		public override void SetupDependencies()
		{
			short num = (short)755897602;
			short num2 = num;
			num = (short)303961346;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1170604032;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1618739200;
			if (num != 0)
			{
			}
			num = (short)404815873;
			if (num != 0)
			{
			}
			this.dispMenuLabtoolColorText1_A7689.AddDependentObject(this.dispMenuLabtoolGreen1_A8172);
			this.dispMenuLabtoolColorText1_A7689.AddDependentObject(this.dispMenuLabtoolRed1_A8923);
		}

		// Token: 0x170039FD RID: 14845
		// (get) Token: 0x06007042 RID: 28738 RVA: 0x0063E650 File Offset: 0x0063C850
		public bool HasDiffs
		{
			get
			{
				short num = (short)2036830435;
				short num2 = num;
				num = (short)547852515;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1603141632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)534052865;
				if (num != 0)
				{
				}
				num = (short)2121138176;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170039FE RID: 14846
		// (get) Token: 0x06007043 RID: 28739 RVA: 0x0063E700 File Offset: 0x0063C900
		// (set) Token: 0x06007044 RID: 28740 RVA: 0x0063E7B4 File Offset: 0x0063C9B4
		public int DispMenuLabtoolBlue1_A7565Value
		{
			get
			{
				short num = (short)971941774;
				short num2 = num;
				num = (short)620734350;
				switch (num2 == num)
				{
				default:
				{
					num = (short)199491584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1554120704;
				if (num != 0)
				{
				}
				num = (short)1597505537;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolBlue1_A7565.Value;
			}
			set
			{
				short num = (short)971479776;
				short num2 = num;
				num = (short)963353312;
				switch (num2 == num)
				{
				default:
				{
					num = (short)642252800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1006305281;
				if (num != 0)
				{
				}
				num = (short)1510670336;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolBlue1_A7565.Value = value;
			}
		}

		// Token: 0x170039FF RID: 14847
		// (get) Token: 0x06007045 RID: 28741 RVA: 0x0063E864 File Offset: 0x0063CA64
		public global::AcpBusinessLayer.AcpCustomRangeField DispMenuLabtoolBlue1_A7565
		{
			get
			{
				short num = (short)993705530;
				short num2 = num;
				num = (short)112639546;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1210908672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)162660353;
				if (num != 0)
				{
				}
				num = (short)2052390912;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolBlue1_A7565;
			}
		}

		// Token: 0x17003A00 RID: 14848
		// (get) Token: 0x06007046 RID: 28742 RVA: 0x0063E918 File Offset: 0x0063CB18
		// (set) Token: 0x06007047 RID: 28743 RVA: 0x0063E9CC File Offset: 0x0063CBCC
		public string DispMenuLabtoolBlue1_A7565_UIValue
		{
			get
			{
				short num = (short)2002760324;
				short num2 = num;
				num = (short)1551348356;
				switch (num2 == num)
				{
				default:
				{
					num = (short)964624384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)355139584;
				if (num != 0)
				{
				}
				num = (short)1794834433;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolBlue1_A7565.UIValue;
			}
			set
			{
				short num = (short)1004256182;
				short num2 = num;
				num = (short)1692842934;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1394802688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)969080833;
				if (num != 0)
				{
				}
				num = (short)595329024;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolBlue1_A7565.UIValue = value;
			}
		}

		// Token: 0x17003A01 RID: 14849
		// (get) Token: 0x06007048 RID: 28744 RVA: 0x0063EA84 File Offset: 0x0063CC84
		// (set) Token: 0x06007049 RID: 28745 RVA: 0x0063EB38 File Offset: 0x0063CD38
		internal int DispMenuLabtoolBlue1_A7565Min
		{
			get
			{
				short num = (short)317754714;
				short num2 = num;
				num = (short)381455706;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1567227904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2049048577;
				if (num != 0)
				{
				}
				num = (short)324665344;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolBlue1_A7565.Min;
			}
			set
			{
				short num = (short)1488190060;
				short num2 = num;
				num = (short)1312422508;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1584398336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1768882176;
				if (num != 0)
				{
				}
				num = (short)801505281;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolBlue1_A7565.Min = value;
			}
		}

		// Token: 0x17003A02 RID: 14850
		// (get) Token: 0x0600704A RID: 28746 RVA: 0x0063EBEC File Offset: 0x0063CDEC
		// (set) Token: 0x0600704B RID: 28747 RVA: 0x0063ECA4 File Offset: 0x0063CEA4
		internal int DispMenuLabtoolBlue1_A7565Max
		{
			get
			{
				short num = (short)585302017;
				if (num != 0)
				{
				}
				num = (short)1303052288;
				short num2 = num;
				num = (short)1621097210;
				short num3 = num;
				num = (short)1400175354;
				switch (num3 == num)
				{
				}
				num = (short)562757632;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolBlue1_A7565.Max;
			}
			set
			{
				short num = (short)688390145;
				if (num != 0)
				{
				}
				num = (short)2126315520;
				short num2 = num;
				num = (short)357232109;
				short num3 = num;
				num = (short)79228397;
				switch (num3 == num)
				{
				}
				num = (short)1026490368;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolBlue1_A7565.Max = value;
			}
		}

		// Token: 0x17003A03 RID: 14851
		// (get) Token: 0x0600704C RID: 28748 RVA: 0x0063ED58 File Offset: 0x0063CF58
		// (set) Token: 0x0600704D RID: 28749 RVA: 0x0063EE0C File Offset: 0x0063D00C
		internal int DispMenuLabtoolBlue1_A7565Step
		{
			get
			{
				short num = (short)1602934979;
				short num2 = num;
				num = (short)987748547;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1970798592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)512360449;
				if (num != 0)
				{
				}
				num = (short)729219072;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolBlue1_A7565.StepSize;
			}
			set
			{
				short num = (short)1626931201;
				if (num != 0)
				{
				}
				num = (short)992804864;
				short num2 = num;
				num = (short)548411543;
				short num3 = num;
				num = (short)1123817623;
				switch (num3 == num)
				{
				}
				num = (short)1341128704;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolBlue1_A7565.StepSize = value;
			}
		}

		// Token: 0x17003A04 RID: 14852
		// (get) Token: 0x0600704E RID: 28750 RVA: 0x0063EEC4 File Offset: 0x0063D0C4
		// (set) Token: 0x0600704F RID: 28751 RVA: 0x0063EF78 File Offset: 0x0063D178
		public bool DispMenuLabtoolBlue1_A7565_Applicable
		{
			get
			{
				short num = (short)1074355719;
				short num2 = num;
				num = (short)1427791367;
				switch (num2 == num)
				{
				default:
				{
					num = (short)818216960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2023555073;
				if (num != 0)
				{
				}
				num = (short)2143551488;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolBlue1_A7565.Applicable;
			}
			set
			{
				short num = (short)1153331659;
				short num2 = num;
				num = (short)747794891;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1879244800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)871956480;
				if (num != 0)
				{
				}
				num = (short)746192897;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolBlue1_A7565.Applicable = value;
			}
		}

		// Token: 0x17003A05 RID: 14853
		// (get) Token: 0x06007050 RID: 28752 RVA: 0x0063F034 File Offset: 0x0063D234
		// (set) Token: 0x06007051 RID: 28753 RVA: 0x0063F0E8 File Offset: 0x0063D2E8
		public bool DispMenuLabtoolBlue1_A7565_Valid
		{
			get
			{
				short num = (short)1994846286;
				short num2 = num;
				num = (short)357101646;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1375404032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)777322497;
				if (num != 0)
				{
				}
				num = (short)881917952;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolBlue1_A7565.Valid;
			}
			set
			{
				short num = (short)1096206620;
				short num2 = num;
				num = (short)1604962588;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1049952256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1033437185;
				if (num != 0)
				{
				}
				num = (short)121765888;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolBlue1_A7565.Valid = value;
			}
		}

		// Token: 0x17003A06 RID: 14854
		// (get) Token: 0x06007052 RID: 28754 RVA: 0x0063F19C File Offset: 0x0063D39C
		// (set) Token: 0x06007053 RID: 28755 RVA: 0x0063F250 File Offset: 0x0063D450
		public bool DispMenuLabtoolBlue1_A7565_Visible
		{
			get
			{
				short num = (short)1139391593;
				short num2 = num;
				num = (short)611105897;
				switch (num2 == num)
				{
				default:
				{
					num = (short)156172288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)518193153;
				if (num != 0)
				{
				}
				num = (short)368902144;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolBlue1_A7565.Visible;
			}
			set
			{
				short num = (short)1570797489;
				short num2 = num;
				num = (short)1539995569;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1446445056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)47906817;
				if (num != 0)
				{
				}
				num = (short)2146828288;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolBlue1_A7565.Visible = value;
			}
		}

		// Token: 0x17003A07 RID: 14855
		// (get) Token: 0x06007054 RID: 28756 RVA: 0x0063F308 File Offset: 0x0063D508
		// (set) Token: 0x06007055 RID: 28757 RVA: 0x0063F3BC File Offset: 0x0063D5BC
		public bool DispMenuLabtoolBlue1_A7565_Editable
		{
			get
			{
				short num = (short)1237975041;
				if (num != 0)
				{
				}
				num = (short)1012858880;
				short num2 = num;
				num = (short)1338545055;
				short num3 = num;
				num = (short)1376752543;
				switch (num3 == num)
				{
				}
				num = (short)1022296064;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolBlue1_A7565.Editable;
			}
			set
			{
				short num = (short)1316167964;
				short num2 = num;
				num = (short)1219240220;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1196818432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1768423425;
				if (num != 0)
				{
				}
				num = (short)1880752128;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolBlue1_A7565.Editable = value;
			}
		}

		// Token: 0x17003A08 RID: 14856
		// (get) Token: 0x06007056 RID: 28758 RVA: 0x0063F474 File Offset: 0x0063D674
		internal string DispMenuLabtoolBlue1_A7565_UILabel
		{
			get
			{
				short num = (short)1401533540;
				short num2 = num;
				num = (short)137999460;
				switch (num2 == num)
				{
				default:
				{
					num = (short)961150976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1757741056;
				if (num != 0)
				{
				}
				num = (short)1421475841;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolBlue1_A7565.UIName;
			}
		}

		// Token: 0x17003A09 RID: 14857
		// (get) Token: 0x06007057 RID: 28759 RVA: 0x0063F530 File Offset: 0x0063D730
		// (set) Token: 0x06007058 RID: 28760 RVA: 0x0063F5E4 File Offset: 0x0063D7E4
		internal bool DispMenuLabtoolBlue1_A7565_HiddenStatic
		{
			get
			{
				short num = (short)323042266;
				short num2 = num;
				num = (short)1271544794;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1513947136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1956511744;
				if (num != 0)
				{
				}
				num = (short)1496449025;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolBlue1_A7565.HiddenStatic;
			}
			set
			{
				short num = (short)109314595;
				short num2 = num;
				num = (short)627704355;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1892941824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1636696065;
				if (num != 0)
				{
				}
				num = (short)1257963520;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolBlue1_A7565.HiddenStatic = value;
			}
		}

		// Token: 0x17003A0A RID: 14858
		// (get) Token: 0x06007059 RID: 28761 RVA: 0x0063F69C File Offset: 0x0063D89C
		// (set) Token: 0x0600705A RID: 28762 RVA: 0x0063F754 File Offset: 0x0063D954
		internal bool DispMenuLabtoolBlue1_A7565_HiddenDynamic
		{
			get
			{
				short num = (short)1116027987;
				short num2 = num;
				num = (short)1358511187;
				switch (num2 == num)
				{
				default:
				{
					num = (short)753074176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1918107649;
				if (num != 0)
				{
				}
				num = (short)505348096;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolBlue1_A7565.HiddenDynamic;
			}
			set
			{
				short num = (short)1652823117;
				short num2 = num;
				num = (short)1989940301;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2122907648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1195376640;
				if (num != 0)
				{
				}
				num = (short)1138950145;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolBlue1_A7565.HiddenDynamic = value;
			}
		}

		// Token: 0x17003A0B RID: 14859
		// (get) Token: 0x0600705B RID: 28763 RVA: 0x0063F808 File Offset: 0x0063DA08
		public bool DispMenuLabtoolBlue1_A7565_HasDiffs
		{
			get
			{
				short num = (short)1236676848;
				short num2 = num;
				num = (short)1265512688;
				switch (num2 == num)
				{
				default:
				{
					num = (short)362217472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1860042752;
				if (num != 0)
				{
				}
				num = (short)773062657;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolBlue1_A7565._HasDiffs;
			}
		}

		// Token: 0x17003A0C RID: 14860
		// (get) Token: 0x0600705C RID: 28764 RVA: 0x0063F8C0 File Offset: 0x0063DAC0
		// (set) Token: 0x0600705D RID: 28765 RVA: 0x0063F978 File Offset: 0x0063DB78
		public string DispMenuLabtoolColorText1_A7689Value
		{
			get
			{
				short num = (short)958595073;
				if (num != 0)
				{
				}
				num = (short)983760896;
				short num2 = num;
				num = (short)838651836;
				short num3 = num;
				num = (short)1012912060;
				switch (num3 == num)
				{
				}
				num = (short)456458240;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolColorText1_A7689.Value;
			}
			set
			{
				short num = (short)641859584;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1236074496;
					short num3 = num;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_5C;
						}
						continue;
					case 1:
						goto IL_A9;
					case 2:
						goto IL_CF;
					}
					IL_5C:
					num = (short)1750663169;
					if (num != 0)
					{
					}
					if (!string.IsNullOrEmpty(value.Trim()))
					{
						num = (short)1910964225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CF;
					IL_A9:
					this.dispMenuLabtoolColorText1_A7689.Value = value;
					num = (short)1866661890;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CF:
					num = (short)1457269747;
					short num4 = num;
					num = (short)1125395443;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A9;
					default:
						goto IL_106;
					}
				}
				IL_106:
				num = (short)222035968;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17003A0D RID: 14861
		// (get) Token: 0x0600705E RID: 28766 RVA: 0x0063FAA4 File Offset: 0x0063DCA4
		// (set) Token: 0x0600705F RID: 28767 RVA: 0x0063FB58 File Offset: 0x0063DD58
		public string DispMenuLabtoolColorText1_A7689_UIValue
		{
			get
			{
				short num = (short)550764545;
				if (num != 0)
				{
				}
				num = (short)807469056;
				short num2 = num;
				num = (short)703623750;
				short num3 = num;
				num = (short)835154502;
				switch (num3 == num)
				{
				}
				num = (short)554500096;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolColorText1_A7689.Value;
			}
			set
			{
				short num = (short)1974022562;
				short num2 = num;
				num = (short)1712664994;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1450311680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)483393537;
				if (num != 0)
				{
				}
				num = (short)1649147904;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolColorText1_A7689.Value = value;
			}
		}

		// Token: 0x17003A0E RID: 14862
		// (get) Token: 0x06007060 RID: 28768 RVA: 0x0063FC0C File Offset: 0x0063DE0C
		public global::AcpBusinessLayer.AcpKeyField DispMenuLabtoolColorText1_A7689
		{
			get
			{
				short num = (short)438189950;
				short num2 = num;
				num = (short)45956990;
				switch (num2 == num)
				{
				default:
				{
					num = (short)156565504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)334168064;
				if (num != 0)
				{
				}
				num = (short)1846738945;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolColorText1_A7689;
			}
		}

		// Token: 0x17003A0F RID: 14863
		// (get) Token: 0x06007061 RID: 28769 RVA: 0x0063FCBC File Offset: 0x0063DEBC
		// (set) Token: 0x06007062 RID: 28770 RVA: 0x0063FD70 File Offset: 0x0063DF70
		public bool DispMenuLabtoolColorText1_A7689_Applicable
		{
			get
			{
				short num = (short)76050405;
				short num2 = num;
				num = (short)1121939429;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1594228736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)657195009;
				if (num != 0)
				{
				}
				num = (short)1256652800;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolColorText1_A7689.Applicable;
			}
			set
			{
				short num = (short)30393998;
				short num2 = num;
				num = (short)707511950;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1902510080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1740505089;
				if (num != 0)
				{
				}
				num = (short)918552576;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolColorText1_A7689.Applicable = value;
			}
		}

		// Token: 0x17003A10 RID: 14864
		// (get) Token: 0x06007063 RID: 28771 RVA: 0x0063FE28 File Offset: 0x0063E028
		// (set) Token: 0x06007064 RID: 28772 RVA: 0x0063FEDC File Offset: 0x0063E0DC
		public bool DispMenuLabtoolColorText1_A7689_Valid
		{
			get
			{
				short num = (short)1365966849;
				if (num != 0)
				{
				}
				num = (short)64356352;
				short num2 = num;
				num = (short)1639714959;
				short num3 = num;
				num = (short)1860178063;
				switch (num3 == num)
				{
				}
				num = (short)1078984704;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolColorText1_A7689.Valid;
			}
			set
			{
				short num = (short)1206662563;
				short num2 = num;
				num = (short)1312372131;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1297874944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)984809473;
				if (num != 0)
				{
				}
				num = (short)1132855296;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolColorText1_A7689.Valid = value;
			}
		}

		// Token: 0x17003A11 RID: 14865
		// (get) Token: 0x06007065 RID: 28773 RVA: 0x0063FF90 File Offset: 0x0063E190
		// (set) Token: 0x06007066 RID: 28774 RVA: 0x00640044 File Offset: 0x0063E244
		public bool DispMenuLabtoolColorText1_A7689_Visible
		{
			get
			{
				short num = (short)860291073;
				if (num != 0)
				{
				}
				num = (short)1409548288;
				short num2 = num;
				num = (short)1310459931;
				short num3 = num;
				num = (short)550111259;
				switch (num3 == num)
				{
				}
				num = (short)1377632256;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolColorText1_A7689.Visible;
			}
			set
			{
				short num = (short)3090948;
				short num2 = num;
				num = (short)443820548;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1528233984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1666187265;
				if (num != 0)
				{
				}
				num = (short)1976827904;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolColorText1_A7689.Visible = value;
			}
		}

		// Token: 0x17003A12 RID: 14866
		// (get) Token: 0x06007067 RID: 28775 RVA: 0x006400F8 File Offset: 0x0063E2F8
		// (set) Token: 0x06007068 RID: 28776 RVA: 0x006401B0 File Offset: 0x0063E3B0
		public bool DispMenuLabtoolColorText1_A7689_Editable
		{
			get
			{
				short num = (short)1180443244;
				short num2 = num;
				num = (short)16982636;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2131034112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)655818752;
				if (num != 0)
				{
				}
				num = (short)862650369;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolColorText1_A7689.Editable;
			}
			set
			{
				short num = (short)376874311;
				short num2 = num;
				num = (short)1079092551;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1448738816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)153812992;
				if (num != 0)
				{
				}
				num = (short)93519873;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolColorText1_A7689.Editable = value;
			}
		}

		// Token: 0x17003A13 RID: 14867
		// (get) Token: 0x06007069 RID: 28777 RVA: 0x00640268 File Offset: 0x0063E468
		internal string DispMenuLabtoolColorText1_A7689_UILabel
		{
			get
			{
				short num = (short)615828478;
				short num2 = num;
				num = (short)1701301246;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1628700672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1638400001;
				if (num != 0)
				{
				}
				num = (short)1774321664;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolColorText1_A7689.UIName;
			}
		}

		// Token: 0x17003A14 RID: 14868
		// (get) Token: 0x0600706A RID: 28778 RVA: 0x0064031C File Offset: 0x0063E51C
		// (set) Token: 0x0600706B RID: 28779 RVA: 0x006403D0 File Offset: 0x0063E5D0
		internal bool DispMenuLabtoolColorText1_A7689_HiddenStatic
		{
			get
			{
				short num = (short)681138504;
				short num2 = num;
				num = (short)545216840;
				switch (num2 == num)
				{
				default:
				{
					num = (short)89522176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)794361856;
				if (num != 0)
				{
				}
				num = (short)1948254209;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolColorText1_A7689.HiddenStatic;
			}
			set
			{
				short num = (short)1840054273;
				if (num != 0)
				{
				}
				num = (short)1231618048;
				short num2 = num;
				num = (short)108557314;
				short num3 = num;
				num = (short)1368617986;
				switch (num3 == num)
				{
				}
				num = (short)821755904;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolColorText1_A7689.HiddenStatic = value;
			}
		}

		// Token: 0x17003A15 RID: 14869
		// (get) Token: 0x0600706C RID: 28780 RVA: 0x00640488 File Offset: 0x0063E688
		// (set) Token: 0x0600706D RID: 28781 RVA: 0x0064053C File Offset: 0x0063E73C
		internal bool DispMenuLabtoolColorText1_A7689_HiddenDynamic
		{
			get
			{
				short num = (short)966416811;
				short num2 = num;
				num = (short)678320555;
				switch (num2 == num)
				{
				default:
				{
					num = (short)927334400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)231014401;
				if (num != 0)
				{
				}
				num = (short)1164115968;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolColorText1_A7689.HiddenDynamic;
			}
			set
			{
				short num = (short)1739657734;
				short num2 = num;
				num = (short)765792774;
				switch (num2 == num)
				{
				default:
				{
					num = (short)656932864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1263403009;
				if (num != 0)
				{
				}
				num = (short)924057600;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolColorText1_A7689.HiddenDynamic = value;
			}
		}

		// Token: 0x17003A16 RID: 14870
		// (get) Token: 0x0600706E RID: 28782 RVA: 0x006405F4 File Offset: 0x0063E7F4
		public bool DispMenuLabtoolColorText1_A7689_HasDiffs
		{
			get
			{
				short num = (short)1064828929;
				if (num != 0)
				{
				}
				num = (short)1852178432;
				short num2 = num;
				num = (short)795475882;
				short num3 = num;
				num = (short)1947860906;
				switch (num3 == num)
				{
				}
				num = (short)2127953920;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolColorText1_A7689._HasDiffs;
			}
		}

		// Token: 0x17003A17 RID: 14871
		// (get) Token: 0x0600706F RID: 28783 RVA: 0x006406A8 File Offset: 0x0063E8A8
		// (set) Token: 0x06007070 RID: 28784 RVA: 0x0064075C File Offset: 0x0063E95C
		public bool DispMenuLabtoolConfigurable1_A7700Value
		{
			get
			{
				short num = (short)724978413;
				short num2 = num;
				num = (short)1555188461;
				switch (num2 == num)
				{
				}
				num = (short)695664640;
				short num3 = num;
				num = (short)2057895937;
				if (num != 0)
				{
				}
				num = (short)735576064;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolConfigurable1_A7700.Value;
			}
			set
			{
				short num = (short)1592908682;
				short num2 = num;
				num = (short)1964039050;
				switch (num2 == num)
				{
				}
				num = (short)1951137792;
				short num3 = num;
				num = (short)839712769;
				if (num != 0)
				{
				}
				num = (short)535035904;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolConfigurable1_A7700.Value = value;
			}
		}

		// Token: 0x17003A18 RID: 14872
		// (get) Token: 0x06007071 RID: 28785 RVA: 0x00640810 File Offset: 0x0063EA10
		public global::AcpBusinessLayer.AcpField<bool> DispMenuLabtoolConfigurable1_A7700
		{
			get
			{
				short num = (short)67854737;
				short num2 = num;
				num = (short)1684890001;
				switch (num2 == num)
				{
				}
				num = (short)662765568;
				short num3 = num;
				num = (short)1169817601;
				if (num != 0)
				{
				}
				num = (short)251002880;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolConfigurable1_A7700;
			}
		}

		// Token: 0x17003A19 RID: 14873
		// (get) Token: 0x06007072 RID: 28786 RVA: 0x006408C4 File Offset: 0x0063EAC4
		// (set) Token: 0x06007073 RID: 28787 RVA: 0x00640978 File Offset: 0x0063EB78
		public bool DispMenuLabtoolConfigurable1_A7700_UIValue
		{
			get
			{
				short num = (short)1627833266;
				short num2 = num;
				num = (short)466994098;
				switch (num2 == num)
				{
				}
				num = (short)1302134784;
				short num3 = num;
				num = (short)1618214913;
				if (num != 0)
				{
				}
				num = (short)1160380416;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolConfigurable1_A7700.Value;
			}
			set
			{
				short num = (short)818174012;
				short num2 = num;
				num = (short)982079548;
				switch (num2 == num)
				{
				}
				num = (short)1290076160;
				short num3 = num;
				num = (short)1180893184;
				if (num != 0)
				{
				}
				num = (short)1078132737;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolConfigurable1_A7700.Value = value;
			}
		}

		// Token: 0x17003A1A RID: 14874
		// (get) Token: 0x06007074 RID: 28788 RVA: 0x00640A2C File Offset: 0x0063EC2C
		// (set) Token: 0x06007075 RID: 28789 RVA: 0x00640AE0 File Offset: 0x0063ECE0
		public bool DispMenuLabtoolConfigurable1_A7700_Applicable
		{
			get
			{
				short num = (short)886198435;
				short num2 = num;
				num = (short)864833699;
				switch (num2 == num)
				{
				}
				num = (short)1156513792;
				short num3 = num;
				num = (short)344850433;
				if (num != 0)
				{
				}
				num = (short)1867644928;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolConfigurable1_A7700.Applicable;
			}
			set
			{
				short num = (short)340957820;
				short num2 = num;
				num = (short)1091476092;
				switch (num2 == num)
				{
				}
				num = (short)533069824;
				short num3 = num;
				num = (short)1825112065;
				if (num != 0)
				{
				}
				num = (short)1613889536;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolConfigurable1_A7700.Applicable = value;
			}
		}

		// Token: 0x17003A1B RID: 14875
		// (get) Token: 0x06007076 RID: 28790 RVA: 0x00640B94 File Offset: 0x0063ED94
		// (set) Token: 0x06007077 RID: 28791 RVA: 0x00640C44 File Offset: 0x0063EE44
		public bool DispMenuLabtoolConfigurable1_A7700_Valid
		{
			get
			{
				short num = (short)315359233;
				if (num != 0)
				{
				}
				num = (short)684897526;
				short num2 = num;
				num = (short)514766070;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1704067072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)30277632;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolConfigurable1_A7700.Valid;
			}
			set
			{
				short num = (short)31122045;
				short num2 = num;
				num = (short)1706091133;
				switch (num2 == num)
				{
				}
				num = (short)1013317632;
				short num3 = num;
				num = (short)884604928;
				if (num != 0)
				{
				}
				num = (short)953155585;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolConfigurable1_A7700.Valid = value;
			}
		}

		// Token: 0x17003A1C RID: 14876
		// (get) Token: 0x06007078 RID: 28792 RVA: 0x00640CF8 File Offset: 0x0063EEF8
		// (set) Token: 0x06007079 RID: 28793 RVA: 0x00640DAC File Offset: 0x0063EFAC
		public bool DispMenuLabtoolConfigurable1_A7700_Visible
		{
			get
			{
				short num = (short)1316839581;
				short num2 = num;
				num = (short)1442341021;
				switch (num2 == num)
				{
				}
				num = (short)1993605120;
				short num3 = num;
				num = (short)2061500417;
				if (num != 0)
				{
				}
				num = (short)1194196992;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolConfigurable1_A7700.Visible;
			}
			set
			{
				short num = (short)2101302537;
				short num2 = num;
				num = (short)211375369;
				switch (num2 == num)
				{
				}
				num = (short)940244992;
				short num3 = num;
				num = (short)675282945;
				if (num != 0)
				{
				}
				num = (short)773914624;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolConfigurable1_A7700.Visible = value;
			}
		}

		// Token: 0x17003A1D RID: 14877
		// (get) Token: 0x0600707A RID: 28794 RVA: 0x00640E64 File Offset: 0x0063F064
		// (set) Token: 0x0600707B RID: 28795 RVA: 0x00640F18 File Offset: 0x0063F118
		public bool DispMenuLabtoolConfigurable1_A7700_Editable
		{
			get
			{
				short num = (short)1682351467;
				short num2 = num;
				num = (short)1169139051;
				switch (num2 == num)
				{
				}
				num = (short)2123956224;
				short num3 = num;
				num = (short)2009530369;
				if (num != 0)
				{
				}
				num = (short)1748500480;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolConfigurable1_A7700.Editable;
			}
			set
			{
				short num = (short)477060749;
				short num2 = num;
				num = (short)1306353293;
				switch (num2 == num)
				{
				}
				num = (short)49479680;
				short num3 = num;
				num = (short)679018497;
				if (num != 0)
				{
				}
				num = (short)543490048;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolConfigurable1_A7700.Editable = value;
			}
		}

		// Token: 0x17003A1E RID: 14878
		// (get) Token: 0x0600707C RID: 28796 RVA: 0x00640FCC File Offset: 0x0063F1CC
		internal string DispMenuLabtoolConfigurable1_A7700_UILabel
		{
			get
			{
				short num = (short)1838393837;
				short num2 = num;
				num = (short)1327344109;
				switch (num2 == num)
				{
				}
				num = (short)1364721664;
				short num3 = num;
				num = (short)377749505;
				if (num != 0)
				{
				}
				num = (short)889978880;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolConfigurable1_A7700.UIName;
			}
		}

		// Token: 0x17003A1F RID: 14879
		// (get) Token: 0x0600707D RID: 28797 RVA: 0x00641080 File Offset: 0x0063F280
		// (set) Token: 0x0600707E RID: 28798 RVA: 0x00641134 File Offset: 0x0063F334
		internal bool DispMenuLabtoolConfigurable1_A7700_HiddenStatic
		{
			get
			{
				short num = (short)1098973185;
				if (num != 0)
				{
				}
				num = (short)1362002324;
				short num2 = num;
				num = (short)767328660;
				switch (num2 == num)
				{
				default:
				{
					num = (short)592707584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)389545984;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolConfigurable1_A7700.HiddenStatic;
			}
			set
			{
				short num = (short)1367010298;
				short num2 = num;
				num = (short)1711008762;
				switch (num2 == num)
				{
				}
				num = (short)313851904;
				short num3 = num;
				num = (short)127467521;
				if (num != 0)
				{
				}
				num = (short)1040908288;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolConfigurable1_A7700.HiddenStatic = value;
			}
		}

		// Token: 0x17003A20 RID: 14880
		// (get) Token: 0x0600707F RID: 28799 RVA: 0x006411E8 File Offset: 0x0063F3E8
		// (set) Token: 0x06007080 RID: 28800 RVA: 0x0064129C File Offset: 0x0063F49C
		internal bool DispMenuLabtoolConfigurable1_A7700_HiddenDynamic
		{
			get
			{
				short num = (short)1629970791;
				short num2 = num;
				num = (short)2018206055;
				switch (num2 == num)
				{
				}
				num = (short)397017088;
				short num3 = num;
				num = (short)608239617;
				if (num != 0)
				{
				}
				num = (short)1291255808;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolConfigurable1_A7700.HiddenDynamic;
			}
			set
			{
				short num = (short)17860645;
				short num2 = num;
				num = (short)163678245;
				switch (num2 == num)
				{
				}
				num = (short)272039936;
				short num3 = num;
				num = (short)1637285888;
				if (num != 0)
				{
				}
				num = (short)333185025;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolConfigurable1_A7700.HiddenDynamic = value;
			}
		}

		// Token: 0x17003A21 RID: 14881
		// (get) Token: 0x06007081 RID: 28801 RVA: 0x00641350 File Offset: 0x0063F550
		public bool DispMenuLabtoolConfigurable1_A7700_HasDiffs
		{
			get
			{
				short num = (short)1349634391;
				short num2 = num;
				num = (short)433637719;
				switch (num2 == num)
				{
				}
				num = (short)1640235008;
				short num3 = num;
				num = (short)2057830400;
				if (num != 0)
				{
				}
				num = (short)947257345;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolConfigurable1_A7700._HasDiffs;
			}
		}

		// Token: 0x17003A22 RID: 14882
		// (get) Token: 0x06007082 RID: 28802 RVA: 0x00641404 File Offset: 0x0063F604
		// (set) Token: 0x06007083 RID: 28803 RVA: 0x006414B8 File Offset: 0x0063F6B8
		public int DispMenuLabtoolGreen1_A8172Value
		{
			get
			{
				short num = (short)781299311;
				short num2 = num;
				num = (short)99200623;
				switch (num2 == num)
				{
				}
				num = (short)1228603392;
				short num3 = num;
				num = (short)392757249;
				if (num != 0)
				{
				}
				num = (short)782434304;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolGreen1_A8172.Value;
			}
			set
			{
				short num = (short)1408854238;
				short num2 = num;
				num = (short)292382942;
				switch (num2 == num)
				{
				}
				num = (short)1327759360;
				short num3 = num;
				num = (short)693698560;
				if (num != 0)
				{
				}
				num = (short)1722744833;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolGreen1_A8172.Value = value;
			}
		}

		// Token: 0x17003A23 RID: 14883
		// (get) Token: 0x06007084 RID: 28804 RVA: 0x0064156C File Offset: 0x0063F76C
		public global::AcpBusinessLayer.AcpCustomRangeField DispMenuLabtoolGreen1_A8172
		{
			get
			{
				short num = (short)403788296;
				short num2 = num;
				num = (short)1600016904;
				switch (num2 == num)
				{
				}
				num = (short)194707456;
				short num3 = num;
				num = (short)1419378688;
				if (num != 0)
				{
				}
				num = (short)1273888769;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolGreen1_A8172;
			}
		}

		// Token: 0x17003A24 RID: 14884
		// (get) Token: 0x06007085 RID: 28805 RVA: 0x0064161C File Offset: 0x0063F81C
		// (set) Token: 0x06007086 RID: 28806 RVA: 0x006416D0 File Offset: 0x0063F8D0
		public string DispMenuLabtoolGreen1_A8172_UIValue
		{
			get
			{
				short num = (short)1514491255;
				short num2 = num;
				num = (short)550063479;
				switch (num2 == num)
				{
				}
				num = (short)1683947520;
				short num3 = num;
				num = (short)512557057;
				if (num != 0)
				{
				}
				num = (short)420610048;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolGreen1_A8172.UIValue;
			}
			set
			{
				short num = (short)1712602151;
				short num2 = num;
				num = (short)1369127975;
				switch (num2 == num)
				{
				}
				num = (short)1385758720;
				short num3 = num;
				num = (short)248905729;
				if (num != 0)
				{
				}
				num = (short)100990976;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolGreen1_A8172.UIValue = value;
			}
		}

		// Token: 0x17003A25 RID: 14885
		// (get) Token: 0x06007087 RID: 28807 RVA: 0x00641784 File Offset: 0x0063F984
		// (set) Token: 0x06007088 RID: 28808 RVA: 0x00641838 File Offset: 0x0063FA38
		internal int DispMenuLabtoolGreen1_A8172Min
		{
			get
			{
				short num = (short)606726195;
				short num2 = num;
				num = (short)568518707;
				switch (num2 == num)
				{
				}
				num = (short)190054400;
				short num3 = num;
				num = (short)495190017;
				if (num != 0)
				{
				}
				num = (short)207880192;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolGreen1_A8172.Min;
			}
			set
			{
				short num = (short)1508548375;
				short num2 = num;
				num = (short)1312857879;
				switch (num2 == num)
				{
				}
				num = (short)905904128;
				short num3 = num;
				num = (short)808976384;
				if (num != 0)
				{
				}
				num = (short)907214849;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolGreen1_A8172.Min = value;
			}
		}

		// Token: 0x17003A26 RID: 14886
		// (get) Token: 0x06007089 RID: 28809 RVA: 0x006418F0 File Offset: 0x0063FAF0
		// (set) Token: 0x0600708A RID: 28810 RVA: 0x006419A4 File Offset: 0x0063FBA4
		internal int DispMenuLabtoolGreen1_A8172Max
		{
			get
			{
				short num = (short)316250620;
				short num2 = num;
				num = (short)1237817852;
				switch (num2 == num)
				{
				}
				num = (short)329187328;
				short num3 = num;
				num = (short)528613377;
				if (num != 0)
				{
				}
				num = (short)339673088;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolGreen1_A8172.Max;
			}
			set
			{
				short num = (short)147575402;
				short num2 = num;
				num = (short)1506005610;
				switch (num2 == num)
				{
				}
				num = (short)238157824;
				short num3 = num;
				num = (short)382074881;
				if (num != 0)
				{
				}
				num = (short)207421440;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolGreen1_A8172.Max = value;
			}
		}

		// Token: 0x17003A27 RID: 14887
		// (get) Token: 0x0600708B RID: 28811 RVA: 0x00641A58 File Offset: 0x0063FC58
		// (set) Token: 0x0600708C RID: 28812 RVA: 0x00641B0C File Offset: 0x0063FD0C
		internal int DispMenuLabtoolGreen1_A8172Step
		{
			get
			{
				short num = (short)1681573792;
				short num2 = num;
				num = (short)972474272;
				switch (num2 == num)
				{
				}
				num = (short)720044032;
				short num3 = num;
				num = (short)2104033280;
				if (num != 0)
				{
				}
				num = (short)1888223233;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolGreen1_A8172.StepSize;
			}
			set
			{
				short num = (short)1497155540;
				short num2 = num;
				num = (short)838715348;
				switch (num2 == num)
				{
				}
				num = (short)1397489664;
				short num3 = num;
				num = (short)1399259137;
				if (num != 0)
				{
				}
				num = (short)1310130176;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolGreen1_A8172.StepSize = value;
			}
		}

		// Token: 0x17003A28 RID: 14888
		// (get) Token: 0x0600708D RID: 28813 RVA: 0x00641BC0 File Offset: 0x0063FDC0
		// (set) Token: 0x0600708E RID: 28814 RVA: 0x00641C78 File Offset: 0x0063FE78
		public bool DispMenuLabtoolGreen1_A8172_Applicable
		{
			get
			{
				short num = (short)1934704738;
				short num2 = num;
				num = (short)1906983010;
				switch (num2 == num)
				{
				}
				num = (short)1449066496;
				short num3 = num;
				num = (short)1272315904;
				if (num != 0)
				{
				}
				num = (short)1877016577;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolGreen1_A8172.Applicable;
			}
			set
			{
				short num = (short)743170606;
				short num2 = num;
				num = (short)479912494;
				switch (num2 == num)
				{
				}
				num = (short)1296498688;
				short num3 = num;
				num = (short)954269697;
				if (num != 0)
				{
				}
				num = (short)503644160;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolGreen1_A8172.Applicable = value;
			}
		}

		// Token: 0x17003A29 RID: 14889
		// (get) Token: 0x0600708F RID: 28815 RVA: 0x00641D30 File Offset: 0x0063FF30
		// (set) Token: 0x06007090 RID: 28816 RVA: 0x00641DE8 File Offset: 0x0063FFE8
		public bool DispMenuLabtoolGreen1_A8172_Valid
		{
			get
			{
				short num = (short)925761537;
				if (num != 0)
				{
				}
				num = (short)85782556;
				short num2 = num;
				num = (short)1181544476;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1953628160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1178664960;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolGreen1_A8172.Valid;
			}
			set
			{
				short num = (short)1236090025;
				short num2 = num;
				num = (short)479280297;
				switch (num2 == num)
				{
				}
				num = (short)1054670848;
				short num3 = num;
				num = (short)1068105729;
				if (num != 0)
				{
				}
				num = (short)174522368;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolGreen1_A8172.Valid = value;
			}
		}

		// Token: 0x17003A2A RID: 14890
		// (get) Token: 0x06007091 RID: 28817 RVA: 0x00641E9C File Offset: 0x0064009C
		// (set) Token: 0x06007092 RID: 28818 RVA: 0x00641F54 File Offset: 0x00640154
		public bool DispMenuLabtoolGreen1_A8172_Visible
		{
			get
			{
				short num = (short)1099614559;
				short num2 = num;
				num = (short)2127612255;
				switch (num2 == num)
				{
				}
				num = (short)816119808;
				short num3 = num;
				num = (short)2133983233;
				if (num != 0)
				{
				}
				num = (short)514588672;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolGreen1_A8172.Visible;
			}
			set
			{
				short num = (short)1747408229;
				short num2 = num;
				num = (short)1684362597;
				switch (num2 == num)
				{
				}
				num = (short)1104740352;
				short num3 = num;
				num = (short)1408696321;
				if (num != 0)
				{
				}
				num = (short)1226637312;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolGreen1_A8172.Visible = value;
			}
		}

		// Token: 0x17003A2B RID: 14891
		// (get) Token: 0x06007093 RID: 28819 RVA: 0x0064200C File Offset: 0x0064020C
		// (set) Token: 0x06007094 RID: 28820 RVA: 0x006420C0 File Offset: 0x006402C0
		public bool DispMenuLabtoolGreen1_A8172_Editable
		{
			get
			{
				short num = (short)1788177962;
				short num2 = num;
				num = (short)1249996330;
				switch (num2 == num)
				{
				}
				num = (short)390201344;
				short num3 = num;
				num = (short)512163841;
				if (num != 0)
				{
				}
				num = (short)1123549184;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolGreen1_A8172.Editable;
			}
			set
			{
				short num = (short)1170368576;
				short num2 = num;
				num = (short)1595500608;
				switch (num2 == num)
				{
				}
				num = (short)1866334208;
				short num3 = num;
				num = (short)1449459713;
				if (num != 0)
				{
				}
				num = (short)1674379264;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolGreen1_A8172.Editable = value;
			}
		}

		// Token: 0x17003A2C RID: 14892
		// (get) Token: 0x06007095 RID: 28821 RVA: 0x00642174 File Offset: 0x00640374
		internal string DispMenuLabtoolGreen1_A8172_UILabel
		{
			get
			{
				short num = (short)1816599050;
				short num2 = num;
				num = (short)2067733002;
				switch (num2 == num)
				{
				}
				num = (short)1865089024;
				short num3 = num;
				num = (short)256180225;
				if (num != 0)
				{
				}
				num = (short)1101332480;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolGreen1_A8172.UIName;
			}
		}

		// Token: 0x17003A2D RID: 14893
		// (get) Token: 0x06007096 RID: 28822 RVA: 0x00642228 File Offset: 0x00640428
		// (set) Token: 0x06007097 RID: 28823 RVA: 0x006422DC File Offset: 0x006404DC
		internal bool DispMenuLabtoolGreen1_A8172_HiddenStatic
		{
			get
			{
				short num = (short)791011583;
				short num2 = num;
				num = (short)1498996991;
				switch (num2 == num)
				{
				}
				num = (short)1917452288;
				short num3 = num;
				num = (short)1944125441;
				if (num != 0)
				{
				}
				num = (short)1827209216;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolGreen1_A8172.HiddenStatic;
			}
			set
			{
				short num = (short)1878828289;
				short num2 = num;
				num = (short)161850625;
				switch (num2 == num)
				{
				}
				num = (short)1016135680;
				short num3 = num;
				num = (short)1714946049;
				if (num != 0)
				{
				}
				num = (short)807272448;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolGreen1_A8172.HiddenStatic = value;
			}
		}

		// Token: 0x17003A2E RID: 14894
		// (get) Token: 0x06007098 RID: 28824 RVA: 0x00642390 File Offset: 0x00640590
		// (set) Token: 0x06007099 RID: 28825 RVA: 0x00642444 File Offset: 0x00640644
		internal bool DispMenuLabtoolGreen1_A8172_HiddenDynamic
		{
			get
			{
				short num = (short)1438366446;
				short num2 = num;
				num = (short)1024572142;
				switch (num2 == num)
				{
				}
				num = (short)589627392;
				short num3 = num;
				num = (short)1599799297;
				if (num != 0)
				{
				}
				num = (short)1433600000;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolGreen1_A8172.HiddenDynamic;
			}
			set
			{
				short num = (short)2002641936;
				short num2 = num;
				num = (short)789636112;
				switch (num2 == num)
				{
				}
				num = (short)1845821440;
				short num3 = num;
				num = (short)807796737;
				if (num != 0)
				{
				}
				num = (short)284950528;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolGreen1_A8172.HiddenDynamic = value;
			}
		}

		// Token: 0x17003A2F RID: 14895
		// (get) Token: 0x0600709A RID: 28826 RVA: 0x006424F8 File Offset: 0x006406F8
		public bool DispMenuLabtoolGreen1_A8172_HasDiffs
		{
			get
			{
				short num = (short)168407026;
				short num2 = num;
				num = (short)506572786;
				switch (num2 == num)
				{
				}
				num = (short)976158720;
				short num3 = num;
				num = (short)1356070912;
				if (num != 0)
				{
				}
				num = (short)332529665;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolGreen1_A8172._HasDiffs;
			}
		}

		// Token: 0x17003A30 RID: 14896
		// (get) Token: 0x0600709B RID: 28827 RVA: 0x006425AC File Offset: 0x006407AC
		// (set) Token: 0x0600709C RID: 28828 RVA: 0x0064265C File Offset: 0x0064085C
		public int DispMenuLabtoolRed1_A8923Value
		{
			get
			{
				short num = (short)1639899290;
				short num2 = num;
				num = (short)1761337498;
				switch (num2 == num)
				{
				}
				num = (short)530055168;
				short num3 = num;
				num = (short)193396736;
				if (num != 0)
				{
				}
				num = (short)656736257;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolRed1_A8923.Value;
			}
			set
			{
				short num = (short)1044341423;
				short num2 = num;
				num = (short)1958896303;
				switch (num2 == num)
				{
				}
				num = (short)779681792;
				short num3 = num;
				num = (short)217120769;
				if (num != 0)
				{
				}
				num = (short)631111680;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolRed1_A8923.Value = value;
			}
		}

		// Token: 0x17003A31 RID: 14897
		// (get) Token: 0x0600709D RID: 28829 RVA: 0x00642714 File Offset: 0x00640914
		public global::AcpBusinessLayer.AcpCustomRangeField DispMenuLabtoolRed1_A8923
		{
			get
			{
				short num = (short)109955958;
				short num2 = num;
				num = (short)1678625654;
				switch (num2 == num)
				{
				}
				num = (short)1727987712;
				short num3 = num;
				num = (short)805175296;
				if (num != 0)
				{
				}
				num = (short)1553334273;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolRed1_A8923;
			}
		}

		// Token: 0x17003A32 RID: 14898
		// (get) Token: 0x0600709E RID: 28830 RVA: 0x006427C0 File Offset: 0x006409C0
		// (set) Token: 0x0600709F RID: 28831 RVA: 0x00642874 File Offset: 0x00640A74
		public string DispMenuLabtoolRed1_A8923_UIValue
		{
			get
			{
				short num = (short)266303615;
				short num2 = num;
				num = (short)965572735;
				switch (num2 == num)
				{
				}
				num = (short)2109276160;
				short num3 = num;
				num = (short)971374593;
				if (num != 0)
				{
				}
				num = (short)1185218560;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolRed1_A8923.UIValue;
			}
			set
			{
				short num = (short)1604658099;
				short num2 = num;
				num = (short)1748968371;
				switch (num2 == num)
				{
				}
				num = (short)260636672;
				short num3 = num;
				num = (short)459800577;
				if (num != 0)
				{
				}
				num = (short)915275776;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolRed1_A8923.UIValue = value;
			}
		}

		// Token: 0x17003A33 RID: 14899
		// (get) Token: 0x060070A0 RID: 28832 RVA: 0x0064292C File Offset: 0x00640B2C
		// (set) Token: 0x060070A1 RID: 28833 RVA: 0x006429E0 File Offset: 0x00640BE0
		internal int DispMenuLabtoolRed1_A8923Min
		{
			get
			{
				short num = (short)1328283649;
				if (num != 0)
				{
				}
				num = (short)1691803652;
				short num2 = num;
				num = (short)1408098308;
				switch (num2 == num)
				{
				default:
				{
					num = (short)917700608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1648427008;
				if (num != 0)
				{
				}
				return this.dispMenuLabtoolRed1_A8923.Min;
			}
			set
			{
				short num = (short)401602529;
				short num2 = num;
				num = (short)1232009185;
				switch (num2 == num)
				{
				}
				num = (short)1476984832;
				short num3 = num;
				num = (short)732430337;
				if (num != 0)
				{
				}
				num = (short)1268514816;
				if (num != 0)
				{
				}
				this.dispMenuLabtoolRed1_A8923.Min = value;
			}
		}

		// Token: 0x17003A34 RID: 14900
		// (get) Token: 0x060070A2 RID: 28834 RVA: 0x00642A98 File Offset: 0x00640C98
		// (set) Token: 0x060070A3 RID: 28835 RVA: 0x00642B50 File Offset: 0x00640D50
		internal int DispMenuLabtoolRed1_A8923Max
		{
			get
			{
				short num = (short)1793846237;
				short num2 = num;
				num = (short)1622731741;
				switch (num2 == num)
				{
				}
				num = (short)709296129;
				if (num != 0)
				{
				}
				num = (short)1175388160;
				if (num != 0)
				{
				}
				num = (short)1311834112;
				short num3 = num;
				return this.dispMenuLabtoolRed1_A8923.Max;
			}
			set
			{
				short num = (short)1423937619;
				short num2 = num;
				num = (short)1582993491;
				switch (num2 == num)
				{
				}
				num = (short)1616773121;
				if (num != 0)
				{
				}
				num = (short)1953431552;
				if (num != 0)
				{
				}
				num = (short)130285568;
				short num3 = num;
				this.dispMenuLabtoolRed1_A8923.Max = value;
			}
		}

		// Token: 0x17003A35 RID: 14901
		// (get) Token: 0x060070A4 RID: 28836 RVA: 0x00642C04 File Offset: 0x00640E04
		// (set) Token: 0x060070A5 RID: 28837 RVA: 0x00642CB4 File Offset: 0x00640EB4
		internal int DispMenuLabtoolRed1_A8923Step
		{
			get
			{
				short num = (short)519857047;
				short num2 = num;
				num = (short)412902295;
				switch (num2 == num)
				{
				}
				num = (short)10223616;
				if (num != 0)
				{
				}
				num = (short)476643329;
				if (num != 0)
				{
				}
				num = (short)1107558400;
				short num3 = num;
				return this.dispMenuLabtoolRed1_A8923.StepSize;
			}
			set
			{
				short num = (short)2092957697;
				if (num != 0)
				{
				}
				num = (short)2060031691;
				short num2 = num;
				num = (short)62297803;
				switch (num2 == num)
				{
				}
				num = (short)1510932480;
				if (num != 0)
				{
				}
				num = (short)112984064;
				short num3 = num;
				this.dispMenuLabtoolRed1_A8923.StepSize = value;
			}
		}

		// Token: 0x17003A36 RID: 14902
		// (get) Token: 0x060070A6 RID: 28838 RVA: 0x00642D6C File Offset: 0x00640F6C
		// (set) Token: 0x060070A7 RID: 28839 RVA: 0x00642E24 File Offset: 0x00641024
		public bool DispMenuLabtoolRed1_A8923_Applicable
		{
			get
			{
				short num = (short)1339816164;
				short num2 = num;
				num = (short)493287652;
				switch (num2 == num)
				{
				}
				num = (short)2027225089;
				if (num != 0)
				{
				}
				num = (short)2013724672;
				if (num != 0)
				{
				}
				num = (short)1564540928;
				short num3 = num;
				return this.dispMenuLabtoolRed1_A8923.Applicable;
			}
			set
			{
				short num = (short)1044709377;
				if (num != 0)
				{
				}
				num = (short)637636115;
				short num2 = num;
				num = (short)1881116179;
				switch (num2 == num)
				{
				}
				num = (short)1916928000;
				if (num != 0)
				{
				}
				num = (short)1992163328;
				short num3 = num;
				this.dispMenuLabtoolRed1_A8923.Applicable = value;
			}
		}

		// Token: 0x17003A37 RID: 14903
		// (get) Token: 0x060070A8 RID: 28840 RVA: 0x00642EDC File Offset: 0x006410DC
		// (set) Token: 0x060070A9 RID: 28841 RVA: 0x00642F90 File Offset: 0x00641190
		public bool DispMenuLabtoolRed1_A8923_Valid
		{
			get
			{
				short num = (short)292225025;
				if (num != 0)
				{
				}
				num = (short)1960584554;
				short num2 = num;
				num = (short)1189225834;
				switch (num2 == num)
				{
				}
				num = (short)47710208;
				if (num != 0)
				{
				}
				num = (short)1717501952;
				short num3 = num;
				return this.dispMenuLabtoolRed1_A8923.Valid;
			}
			set
			{
				short num = (short)1172102015;
				short num2 = num;
				num = (short)2002312063;
				switch (num2 == num)
				{
				}
				num = (short)1324482561;
				if (num != 0)
				{
				}
				num = (short)1733296128;
				if (num != 0)
				{
				}
				num = (short)369098752;
				short num3 = num;
				this.dispMenuLabtoolRed1_A8923.Valid = value;
			}
		}

		// Token: 0x17003A38 RID: 14904
		// (get) Token: 0x060070AA RID: 28842 RVA: 0x00643048 File Offset: 0x00641248
		// (set) Token: 0x060070AB RID: 28843 RVA: 0x006430FC File Offset: 0x006412FC
		public bool DispMenuLabtoolRed1_A8923_Visible
		{
			get
			{
				short num = (short)575781156;
				short num2 = num;
				num = (short)1215805732;
				switch (num2 == num)
				{
				}
				num = (short)203751424;
				if (num != 0)
				{
				}
				num = (short)970457089;
				if (num != 0)
				{
				}
				num = (short)1320353792;
				short num3 = num;
				return this.dispMenuLabtoolRed1_A8923.Visible;
			}
			set
			{
				short num = (short)1870575270;
				short num2 = num;
				num = (short)280802982;
				switch (num2 == num)
				{
				}
				num = (short)785514497;
				if (num != 0)
				{
				}
				num = (short)1051328512;
				if (num != 0)
				{
				}
				num = (short)1179058176;
				short num3 = num;
				this.dispMenuLabtoolRed1_A8923.Visible = value;
			}
		}

		// Token: 0x17003A39 RID: 14905
		// (get) Token: 0x060070AC RID: 28844 RVA: 0x006431B0 File Offset: 0x006413B0
		// (set) Token: 0x060070AD RID: 28845 RVA: 0x00643268 File Offset: 0x00641468
		public bool DispMenuLabtoolRed1_A8923_Editable
		{
			get
			{
				short num = (short)225757202;
				short num2 = num;
				num = (short)1893189650;
				switch (num2 == num)
				{
				}
				num = (short)1412825089;
				if (num != 0)
				{
				}
				num = (short)1235156992;
				if (num != 0)
				{
				}
				num = (short)1783693312;
				short num3 = num;
				return this.dispMenuLabtoolRed1_A8923.Editable;
			}
			set
			{
				short num = (short)874507606;
				short num2 = num;
				num = (short)1036381526;
				switch (num2 == num)
				{
				}
				num = (short)1256849409;
				if (num != 0)
				{
				}
				num = (short)1831993344;
				if (num != 0)
				{
				}
				num = (short)1074855936;
				short num3 = num;
				this.dispMenuLabtoolRed1_A8923.Editable = value;
			}
		}

		// Token: 0x17003A3A RID: 14906
		// (get) Token: 0x060070AE RID: 28846 RVA: 0x00643320 File Offset: 0x00641520
		internal string DispMenuLabtoolRed1_A8923_UILabel
		{
			get
			{
				short num = (short)2098600617;
				short num2 = num;
				num = (short)454367913;
				switch (num2 == num)
				{
				}
				num = (short)716177409;
				if (num != 0)
				{
				}
				num = (short)1493630976;
				if (num != 0)
				{
				}
				num = (short)923205632;
				short num3 = num;
				return this.dispMenuLabtoolRed1_A8923.UIName;
			}
		}

		// Token: 0x17003A3B RID: 14907
		// (get) Token: 0x060070AF RID: 28847 RVA: 0x006433D4 File Offset: 0x006415D4
		// (set) Token: 0x060070B0 RID: 28848 RVA: 0x00643488 File Offset: 0x00641688
		internal bool DispMenuLabtoolRed1_A8923_HiddenStatic
		{
			get
			{
				short num = (short)1661542459;
				short num2 = num;
				num = (short)1851596859;
				switch (num2 == num)
				{
				}
				num = (short)892928001;
				if (num != 0)
				{
				}
				num = (short)925564928;
				if (num != 0)
				{
				}
				num = (short)657129472;
				short num3 = num;
				return this.dispMenuLabtoolRed1_A8923.HiddenStatic;
			}
			set
			{
				short num = (short)1811611649;
				if (num != 0)
				{
				}
				num = (short)196702938;
				short num2 = num;
				num = (short)462648026;
				switch (num2 == num)
				{
				}
				num = (short)533004288;
				if (num != 0)
				{
				}
				num = (short)1243217920;
				short num3 = num;
				this.dispMenuLabtoolRed1_A8923.HiddenStatic = value;
			}
		}

		// Token: 0x17003A3C RID: 14908
		// (get) Token: 0x060070B1 RID: 28849 RVA: 0x0064353C File Offset: 0x0064173C
		// (set) Token: 0x060070B2 RID: 28850 RVA: 0x006435F4 File Offset: 0x006417F4
		internal bool DispMenuLabtoolRed1_A8923_HiddenDynamic
		{
			get
			{
				short num = (short)1727051086;
				short num2 = num;
				num = (short)886093134;
				switch (num2 == num)
				{
				}
				num = (short)1122107393;
				if (num != 0)
				{
				}
				num = (short)627376128;
				if (num != 0)
				{
				}
				num = (short)898236416;
				short num3 = num;
				return this.dispMenuLabtoolRed1_A8923.HiddenDynamic;
			}
			set
			{
				short num = (short)392176100;
				short num2 = num;
				num = (short)170467812;
				switch (num2 == num)
				{
				}
				num = (short)1133838337;
				if (num != 0)
				{
				}
				num = (short)1176961024;
				if (num != 0)
				{
				}
				num = (short)529399808;
				short num3 = num;
				this.dispMenuLabtoolRed1_A8923.HiddenDynamic = value;
			}
		}

		// Token: 0x17003A3D RID: 14909
		// (get) Token: 0x060070B3 RID: 28851 RVA: 0x006436A8 File Offset: 0x006418A8
		public bool DispMenuLabtoolRed1_A8923_HasDiffs
		{
			get
			{
				short num = (short)487383181;
				short num2 = num;
				num = (short)1399513229;
				switch (num2 == num)
				{
				}
				num = (short)624885761;
				if (num != 0)
				{
				}
				num = (short)738394112;
				if (num != 0)
				{
				}
				num = (short)373620736;
				short num3 = num;
				return this.dispMenuLabtoolRed1_A8923._HasDiffs;
			}
		}

		// Token: 0x060070B4 RID: 28852 RVA: 0x0064375C File Offset: 0x0064195C
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
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)710213636;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (base.ParentRecset != null)
					{
						num2 = (short)1352138754;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					num2 = (short)1086586883;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)2035351553;
					if (num2 != 0)
					{
					}
					num2 = (short)1669803055;
					short num3 = num2;
					num2 = (short)941239343;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1091895296;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)656080896;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				case 4:
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)277348352;
			short num4 = num2;
			num2 = (short)1825177601;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04002B4A RID: 11082
		private global::AcpBusinessLayer.AcpCustomRangeField dispMenuLabtoolBlue1_A7565;

		// Token: 0x04002B4B RID: 11083
		private global::AcpBusinessLayer.AcpKeyField dispMenuLabtoolColorText1_A7689;

		// Token: 0x04002B4C RID: 11084
		private global::AcpBusinessLayer.AcpField<bool> dispMenuLabtoolConfigurable1_A7700;

		// Token: 0x04002B4D RID: 11085
		private global::AcpBusinessLayer.AcpCustomRangeField dispMenuLabtoolGreen1_A8172;

		// Token: 0x04002B4E RID: 11086
		private global::AcpBusinessLayer.AcpCustomRangeField dispMenuLabtoolRed1_A8923;
	}
}
