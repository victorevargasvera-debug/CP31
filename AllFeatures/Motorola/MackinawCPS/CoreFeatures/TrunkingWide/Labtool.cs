using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingWide
{
	// Token: 0x0200005F RID: 95
	[global::System.Serializable]
	public class Labtool : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060006E8 RID: 1768 RVA: 0x0006E2A0 File Offset: 0x0006C4A0
		public Labtool(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x0006E2BC File Offset: 0x0006C4BC
		protected Labtool(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x0006E2D4 File Offset: 0x0006C4D4
		public override void Init()
		{
			int a_ = 0;
			short num = (short)138477569;
			if (num != 0)
			{
			}
			num = (short)1224365603;
			short num2 = num;
			num = (short)1422087715;
			switch (num2 == num)
			{
			}
			num = (short)1447886848;
			if (num != 0)
			{
			}
			num = (short)1855324160;
			short num3 = num;
			this.trkWideLabtoolDesenseRSSIThreshold_A7827 = new global::AcpBusinessLayer.AcpSimpleRangeField(77, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚駜뫞鋠蛢诤铦賨맪뻬볮룰ꟲ鷴藶鳸裺闼郾洀朂娄䘆㸈㌊㼌㠎", a_), global::CommonResources.AcgResources.ID_DESENSERSSITHRESHOLD, 0, 255, null, null, 0, 1);
			this.trkWideLabtoolDesenseRSSIThreshold_A7827.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.trkWideLabtoolDesenseRSSIThreshold_A7827.DataTransferOrder = -1;
			this.trkWideLabtoolDesenseRSSIThreshold_A7827.ShowHexValue = true;
			this.trkWideLabtoolPhase2ScramblingDisable_A37983 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚跜럞胠郢胤헦뫨裪鿬軮鳰釲駴黶韸鳺맼雾爀戂朄欆氈吊䰌㰎☐⨒ⴔ␖", a_), global::CommonResources.AcgResources.ID_PHASE2SCRAMBLINGDISABLE);
			this.trkWideLabtoolPhase2ScramblingDisable_A37983.IgnoreOnCompare = true;
			this.trkWideLabtoolPhase2ScramblingDisable_A37983.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.trkWideLabtoolPhase2ScramblingDisable_A37983.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("跀ꋂꟄ돆ꛈ꓊ꇌ", a_);
			base.Id = 10060;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 6;
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x0006E448 File Offset: 0x0006C648
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)384892931;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					this.trkWideLabtoolDesenseRSSIThreshold_A7827 = new global::AcpBusinessLayer.AcpSimpleRangeField(77, this, global::AllFeatures.CodeplugGuid.b("鷈맊ꛌ风룐럒냔鯖룘맚꧜냞軠迢ꇤ苦髨軪菬鳮铰ꇲ꛴ꓶ냸꿺闼跾搀瀂洄栆攈漊刌与☐⬒✔‖", a_), global::CommonResources.AcgResources.ID_DESENSERSSITHRESHOLD, null, null, 0, 1);
					this.trkWideLabtoolDesenseRSSIThreshold_A7827.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.trkWideLabtoolDesenseRSSIThreshold_A7827.DataTransferOrder = -1;
					this.trkWideLabtoolDesenseRSSIThreshold_A7827.ShowHexValue = true;
					num = (short)277735959;
					short num3 = num;
					num = (short)1033431575;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1F;
					default:
					{
						num = (short)962134016;
						if (num != 0)
						{
						}
						num = (short)1941635073;
						if (num != 0)
						{
						}
						num = (short)538312704;
						short num4 = num;
						num = (short)297467905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					goto IL_7A;
				case 2:
					goto IL_254;
				case 3:
					goto IL_1F;
				case 4:
					this.trkWideLabtoolPhase2ScramblingDisable_A37983 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷈맊ꛌ风룐럒냔鯖룘맚꧜냞軠迢뗤迦裨飪裬\uddeeꋰ郲蟴零铸駺釼雾漀搂䄄渆稈樊漌挎琐䰒吔␖⸘√├Ⱎ", a_), global::CommonResources.AcgResources.ID_PHASE2SCRAMBLINGDISABLE);
					this.trkWideLabtoolPhase2ScramblingDisable_A37983.IgnoreOnCompare = true;
					this.trkWideLabtoolPhase2ScramblingDisable_A37983.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.trkWideLabtoolPhase2ScramblingDisable_A37983.DataTransferOrder = -1;
					num = (short)1129578498;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷈맊ꛌ风룐럒냔鯖룘맚꧜냞軠迢뗤迦裨飪裬\uddeeꋰ郲蟴零铸駺釼雾漀搂䄄渆稈樊漌挎琐䰒吔␖⸘√├Ⱎ", a_)))
					{
						num = (short)2063007748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A2;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷈맊ꛌ风룐럒냔鯖룘맚꧜냞軠迢ꇤ苦髨軪菬鳮铰ꇲ꛴ꓶ냸꿺闼跾搀瀂洄栆攈漊刌与☐⬒✔‖", a_)))
					{
						num = (short)55836672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7A;
				case 7:
					num = (short)466812936;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (producerFields != null)
					{
						num = (short)668925961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A2;
				case 9:
					num = (short)622264326;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_57;
				IL_1F:
				switch (0)
				{
				case 0:
					IL_57:
					if (!global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						goto IL_2A2;
					}
					num = (short)2044133383;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				continue;
				IL_7A:
				num = (short)1840840709;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_254:
			IL_2A2:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("藈꫊꿌믎뻐볒맔", a_);
			base.Id = 10060;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 6;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x0006E728 File Offset: 0x0006C928
		public override void PopulateReferences()
		{
			short num = (short)1354879781;
			short num2 = num;
			num = (short)1673450277;
			switch (num2 == num)
			{
			}
			num = (short)1662189569;
			if (num != 0)
			{
			}
			num = (short)261816320;
			if (num != 0)
			{
			}
			num = (short)891289600;
			short num3 = num;
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0006E7D4 File Offset: 0x0006C9D4
		public override void DropReferences()
		{
			short num = (short)408130385;
			short num2 = num;
			num = (short)704811857;
			switch (num2 == num)
			{
			}
			num = (short)1172570112;
			if (num != 0)
			{
			}
			num = (short)1021902849;
			if (num != 0)
			{
			}
			num = (short)1276248064;
			short num3 = num;
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0006E87C File Offset: 0x0006CA7C
		public override void SetConstraints()
		{
			short num = (short)1569766134;
			short num2 = num;
			num = (short)298892022;
			switch (num2 == num)
			{
			}
			num = (short)356843520;
			if (num != 0)
			{
			}
			num = (short)2138308609;
			if (num != 0)
			{
			}
			num = (short)398327808;
			short num3 = num;
			this.trkWideLabtoolPhase2ScramblingDisable_A37983.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.TrunkingWideConstraints.ConIsPhase2ScramblingDisableApplicable);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0006E938 File Offset: 0x0006CB38
		public override void SetupDependencies()
		{
			short num = (short)2076623727;
			short num2 = num;
			num = (short)1258210159;
			switch (num2 == num)
			{
			}
			num = (short)1748828160;
			if (num != 0)
			{
			}
			num = (short)1003814913;
			if (num != 0)
			{
			}
			num = (short)2106327040;
			short num3 = num;
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x0006E9E4 File Offset: 0x0006CBE4
		public bool HasDiffs
		{
			get
			{
				short num = (short)1223557121;
				if (num != 0)
				{
				}
				num = (short)1251325174;
				short num2 = num;
				num = (short)1125102838;
				switch (num2 == num)
				{
				}
				num = (short)1910964224;
				if (num != 0)
				{
				}
				num = (short)607387648;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x0006EA94 File Offset: 0x0006CC94
		// (set) Token: 0x060006F2 RID: 1778 RVA: 0x0006EB48 File Offset: 0x0006CD48
		public int TrkWideLabtoolDesenseRSSIThreshold_A7827Value
		{
			get
			{
				short num = (short)1495339578;
				short num2 = num;
				num = (short)1873023546;
				switch (num2 == num)
				{
				}
				num = (short)656080897;
				if (num != 0)
				{
				}
				num = (short)738066432;
				if (num != 0)
				{
				}
				num = (short)1030356992;
				short num3 = num;
				return this.trkWideLabtoolDesenseRSSIThreshold_A7827.Value;
			}
			set
			{
				short num = (short)680420726;
				short num2 = num;
				num = (short)968123766;
				switch (num2 == num)
				{
				}
				num = (short)993525760;
				if (num != 0)
				{
				}
				num = (short)1875968001;
				if (num != 0)
				{
				}
				num = (short)1940324352;
				short num3 = num;
				this.trkWideLabtoolDesenseRSSIThreshold_A7827.Value = value;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x0006EC00 File Offset: 0x0006CE00
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideLabtoolDesenseRSSIThreshold_A7827
		{
			get
			{
				short num = (short)1162957065;
				short num2 = num;
				num = (short)1090277641;
				switch (num2 == num)
				{
				}
				num = (short)1969750016;
				if (num != 0)
				{
				}
				num = (short)1688993793;
				if (num != 0)
				{
				}
				num = (short)346750976;
				short num3 = num;
				return this.trkWideLabtoolDesenseRSSIThreshold_A7827;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x0006ECB0 File Offset: 0x0006CEB0
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x0006ED64 File Offset: 0x0006CF64
		public string TrkWideLabtoolDesenseRSSIThreshold_A7827_UIValue
		{
			get
			{
				short num = (short)1412011331;
				short num2 = num;
				num = (short)1255511363;
				switch (num2 == num)
				{
				}
				num = (short)1869414401;
				if (num != 0)
				{
				}
				num = (short)1981087744;
				if (num != 0)
				{
				}
				num = (short)1191051264;
				short num3 = num;
				return this.trkWideLabtoolDesenseRSSIThreshold_A7827.UIValue;
			}
			set
			{
				short num = (short)1690216049;
				short num2 = num;
				num = (short)1808901745;
				switch (num2 == num)
				{
				}
				num = (short)1706557441;
				if (num != 0)
				{
				}
				num = (short)1325924352;
				if (num != 0)
				{
				}
				num = (short)660930560;
				short num3 = num;
				this.trkWideLabtoolDesenseRSSIThreshold_A7827.UIValue = value;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x0006EE18 File Offset: 0x0006D018
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x0006EECC File Offset: 0x0006D0CC
		public string TrkWideLabtoolDesenseRSSIThreshold_A7827_HexUIValue
		{
			get
			{
				short num = (short)370852049;
				short num2 = num;
				num = (short)1393803473;
				switch (num2 == num)
				{
				}
				num = (short)2037579777;
				if (num != 0)
				{
				}
				num = (short)1125974016;
				if (num != 0)
				{
				}
				num = (short)216072192;
				short num3 = num;
				return this.trkWideLabtoolDesenseRSSIThreshold_A7827.HexUIValue;
			}
			set
			{
				short num = (short)1291939335;
				short num2 = num;
				num = (short)912682503;
				switch (num2 == num)
				{
				}
				num = (short)950468609;
				if (num != 0)
				{
				}
				num = (short)1932328960;
				if (num != 0)
				{
				}
				num = (short)1280049152;
				short num3 = num;
				this.trkWideLabtoolDesenseRSSIThreshold_A7827.HexUIValue = value;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x0006EF84 File Offset: 0x0006D184
		// (set) Token: 0x060006F9 RID: 1785 RVA: 0x0006F03C File Offset: 0x0006D23C
		internal int TrkWideLabtoolDesenseRSSIThreshold_A7827Min
		{
			get
			{
				short num = (short)958201857;
				if (num != 0)
				{
				}
				num = (short)1163128567;
				short num2 = num;
				num = (short)1698688759;
				switch (num2 == num)
				{
				}
				num = (short)790167552;
				if (num != 0)
				{
				}
				num = (short)1530068992;
				short num3 = num;
				return this.trkWideLabtoolDesenseRSSIThreshold_A7827.Min;
			}
			set
			{
				short num = (short)2034367576;
				short num2 = num;
				num = (short)145357912;
				switch (num2 == num)
				{
				}
				num = (short)908853249;
				if (num != 0)
				{
				}
				num = (short)638779392;
				if (num != 0)
				{
				}
				num = (short)1575288832;
				short num3 = num;
				this.trkWideLabtoolDesenseRSSIThreshold_A7827.Min = value;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x0006F0F0 File Offset: 0x0006D2F0
		// (set) Token: 0x060006FB RID: 1787 RVA: 0x0006F1A4 File Offset: 0x0006D3A4
		internal int TrkWideLabtoolDesenseRSSIThreshold_A7827Max
		{
			get
			{
				short num = (short)328963997;
				short num2 = num;
				num = (short)1494521757;
				switch (num2 == num)
				{
				}
				num = (short)1066795009;
				if (num != 0)
				{
				}
				num = (short)1935933440;
				if (num != 0)
				{
				}
				num = (short)626655232;
				short num3 = num;
				return this.trkWideLabtoolDesenseRSSIThreshold_A7827.Max;
			}
			set
			{
				short num = (short)1008227556;
				short num2 = num;
				num = (short)1918784740;
				switch (num2 == num)
				{
				}
				num = (short)1423704065;
				if (num != 0)
				{
				}
				num = (short)1430978560;
				if (num != 0)
				{
				}
				num = (short)749142016;
				short num3 = num;
				this.trkWideLabtoolDesenseRSSIThreshold_A7827.Max = value;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x0006F25C File Offset: 0x0006D45C
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x0006F314 File Offset: 0x0006D514
		internal int TrkWideLabtoolDesenseRSSIThreshold_A7827Step
		{
			get
			{
				short num = (short)638520471;
				short num2 = num;
				num = (short)1121979543;
				switch (num2 == num)
				{
				}
				num = (short)418840576;
				if (num != 0)
				{
				}
				num = (short)1112801281;
				if (num != 0)
				{
				}
				num = (short)516620288;
				short num3 = num;
				return this.trkWideLabtoolDesenseRSSIThreshold_A7827.StepSize;
			}
			set
			{
				short num = (short)12758561;
				short num2 = num;
				num = (short)402435617;
				switch (num2 == num)
				{
				}
				num = (short)1322647553;
				if (num != 0)
				{
				}
				num = (short)1649016832;
				if (num != 0)
				{
				}
				num = (short)361365504;
				short num3 = num;
				this.trkWideLabtoolDesenseRSSIThreshold_A7827.StepSize = value;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x0006F3C8 File Offset: 0x0006D5C8
		// (set) Token: 0x060006FF RID: 1791 RVA: 0x0006F47C File Offset: 0x0006D67C
		public bool TrkWideLabtoolDesenseRSSIThreshold_A7827_Applicable
		{
			get
			{
				short num = (short)1602664865;
				short num2 = num;
				num = (short)1128446369;
				switch (num2 == num)
				{
				}
				num = (short)2045509632;
				if (num != 0)
				{
				}
				num = (short)1691222017;
				if (num != 0)
				{
				}
				num = (short)1443364864;
				short num3 = num;
				return this.trkWideLabtoolDesenseRSSIThreshold_A7827.Applicable;
			}
			set
			{
				short num = (short)813915562;
				short num2 = num;
				num = (short)1836080554;
				switch (num2 == num)
				{
				}
				num = (short)1380974592;
				if (num != 0)
				{
				}
				num = (short)1326841857;
				if (num != 0)
				{
				}
				num = (short)203751424;
				short num3 = num;
				this.trkWideLabtoolDesenseRSSIThreshold_A7827.Applicable = value;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x0006F530 File Offset: 0x0006D730
		// (set) Token: 0x06000701 RID: 1793 RVA: 0x0006F5E4 File Offset: 0x0006D7E4
		public bool TrkWideLabtoolDesenseRSSIThreshold_A7827_Valid
		{
			get
			{
				short num = (short)516685825;
				if (num != 0)
				{
				}
				num = (short)1133490538;
				short num2 = num;
				num = (short)668447082;
				switch (num2 == num)
				{
				}
				num = (short)1171652608;
				if (num != 0)
				{
				}
				num = (short)104857600;
				short num3 = num;
				return this.trkWideLabtoolDesenseRSSIThreshold_A7827.Valid;
			}
			set
			{
				short num = (short)480953428;
				short num2 = num;
				num = (short)571917396;
				switch (num2 == num)
				{
				}
				num = (short)342228992;
				if (num != 0)
				{
				}
				num = (short)2052390913;
				if (num != 0)
				{
				}
				num = (short)953090048;
				short num3 = num;
				this.trkWideLabtoolDesenseRSSIThreshold_A7827.Valid = value;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x0006F698 File Offset: 0x0006D898
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x0006F750 File Offset: 0x0006D950
		public bool TrkWideLabtoolDesenseRSSIThreshold_A7827_Visible
		{
			get
			{
				short num = (short)464254333;
				short num2 = num;
				num = (short)931460477;
				switch (num2 == num)
				{
				}
				num = (short)689176576;
				if (num != 0)
				{
				}
				num = (short)1620770817;
				if (num != 0)
				{
				}
				num = (short)491716608;
				short num3 = num;
				return this.trkWideLabtoolDesenseRSSIThreshold_A7827.Visible;
			}
			set
			{
				short num = (short)1280225340;
				short num2 = num;
				num = (short)440905788;
				switch (num2 == num)
				{
				}
				num = (short)1305935873;
				if (num != 0)
				{
				}
				num = (short)1870594048;
				if (num != 0)
				{
				}
				num = (short)264699904;
				short num3 = num;
				this.trkWideLabtoolDesenseRSSIThreshold_A7827.Visible = value;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x0006F804 File Offset: 0x0006DA04
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x0006F8BC File Offset: 0x0006DABC
		public bool TrkWideLabtoolDesenseRSSIThreshold_A7827_Editable
		{
			get
			{
				short num = (short)1481337991;
				short num2 = num;
				num = (short)551316615;
				switch (num2 == num)
				{
				}
				num = (short)1754791937;
				if (num != 0)
				{
				}
				num = (short)789970944;
				if (num != 0)
				{
				}
				num = (short)729612288;
				short num3 = num;
				return this.trkWideLabtoolDesenseRSSIThreshold_A7827.Editable;
			}
			set
			{
				short num = (short)925790108;
				short num2 = num;
				num = (short)751136668;
				switch (num2 == num)
				{
				}
				num = (short)1262813184;
				if (num != 0)
				{
				}
				num = (short)983629825;
				if (num != 0)
				{
				}
				num = (short)1685323776;
				short num3 = num;
				this.trkWideLabtoolDesenseRSSIThreshold_A7827.Editable = value;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x0006F970 File Offset: 0x0006DB70
		internal string TrkWideLabtoolDesenseRSSIThreshold_A7827_UILabel
		{
			get
			{
				short num = (short)1983774721;
				if (num != 0)
				{
				}
				num = (short)1209661916;
				short num2 = num;
				num = (short)1269037532;
				switch (num2 == num)
				{
				}
				num = (short)27918336;
				if (num != 0)
				{
				}
				num = (short)763363328;
				short num3 = num;
				return this.trkWideLabtoolDesenseRSSIThreshold_A7827.UIName;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x0006FA28 File Offset: 0x0006DC28
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x0006FADC File Offset: 0x0006DCDC
		internal bool TrkWideLabtoolDesenseRSSIThreshold_A7827_HiddenStatic
		{
			get
			{
				short num = (short)1252812009;
				short num2 = num;
				num = (short)756114665;
				switch (num2 == num)
				{
				}
				num = (short)958136321;
				if (num != 0)
				{
				}
				num = (short)1734344704;
				if (num != 0)
				{
				}
				num = (short)794361856;
				short num3 = num;
				return this.trkWideLabtoolDesenseRSSIThreshold_A7827.HiddenStatic;
			}
			set
			{
				short num = (short)208550680;
				short num2 = num;
				num = (short)875182872;
				switch (num2 == num)
				{
				}
				num = (short)736755713;
				if (num != 0)
				{
				}
				num = (short)817627136;
				if (num != 0)
				{
				}
				num = (short)2135031808;
				short num3 = num;
				this.trkWideLabtoolDesenseRSSIThreshold_A7827.HiddenStatic = value;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x0006FB90 File Offset: 0x0006DD90
		// (set) Token: 0x0600070A RID: 1802 RVA: 0x0006FC44 File Offset: 0x0006DE44
		internal bool TrkWideLabtoolDesenseRSSIThreshold_A7827_HiddenDynamic
		{
			get
			{
				short num = (short)63928785;
				short num2 = num;
				num = (short)249985489;
				switch (num2 == num)
				{
				}
				num = (short)1249640449;
				if (num != 0)
				{
				}
				num = (short)1766522880;
				if (num != 0)
				{
				}
				num = (short)1906573312;
				short num3 = num;
				return this.trkWideLabtoolDesenseRSSIThreshold_A7827.HiddenDynamic;
			}
			set
			{
				short num = (short)366576489;
				short num2 = num;
				num = (short)760578921;
				switch (num2 == num)
				{
				}
				num = (short)763756545;
				if (num != 0)
				{
				}
				num = (short)1368784896;
				if (num != 0)
				{
				}
				num = (short)1038090240;
				short num3 = num;
				this.trkWideLabtoolDesenseRSSIThreshold_A7827.HiddenDynamic = value;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x0006FCFC File Offset: 0x0006DEFC
		public bool TrkWideLabtoolDesenseRSSIThreshold_A7827_HasDiffs
		{
			get
			{
				short num = (short)1245185;
				if (num != 0)
				{
				}
				num = (short)1625069581;
				short num2 = num;
				num = (short)1094424589;
				switch (num2 == num)
				{
				}
				num = (short)663486464;
				if (num != 0)
				{
				}
				num = (short)218628096;
				short num3 = num;
				return this.trkWideLabtoolDesenseRSSIThreshold_A7827._HasDiffs;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x0006FDB0 File Offset: 0x0006DFB0
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x0006FE64 File Offset: 0x0006E064
		public bool TrkWideLabtoolPhase2ScramblingDisable_A37983Value
		{
			get
			{
				short num = (short)1459157883;
				short num2 = num;
				num = (short)1965685627;
				switch (num2 == num)
				{
				}
				num = (short)765984769;
				if (num != 0)
				{
				}
				num = (short)1585446912;
				if (num != 0)
				{
				}
				num = (short)759627776;
				short num3 = num;
				return this.trkWideLabtoolPhase2ScramblingDisable_A37983.Value;
			}
			set
			{
				short num = (short)1179441416;
				short num2 = num;
				num = (short)1292294408;
				switch (num2 == num)
				{
				}
				num = (short)969801728;
				if (num != 0)
				{
				}
				num = (short)650969089;
				if (num != 0)
				{
				}
				num = (short)1556873216;
				short num3 = num;
				this.trkWideLabtoolPhase2ScramblingDisable_A37983.Value = value;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x0006FF18 File Offset: 0x0006E118
		public global::AcpBusinessLayer.AcpField<bool> TrkWideLabtoolPhase2ScramblingDisable_A37983
		{
			get
			{
				short num = (short)391508021;
				short num2 = num;
				num = (short)1813311541;
				switch (num2 == num)
				{
				}
				num = (short)171376640;
				if (num != 0)
				{
				}
				num = (short)486604801;
				if (num != 0)
				{
				}
				num = (short)1607598080;
				short num3 = num;
				return this.trkWideLabtoolPhase2ScramblingDisable_A37983;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x0006FFC8 File Offset: 0x0006E1C8
		// (set) Token: 0x06000710 RID: 1808 RVA: 0x0007007C File Offset: 0x0006E27C
		public bool TrkWideLabtoolPhase2ScramblingDisable_A37983_UIValue
		{
			get
			{
				short num = (short)1809930399;
				short num2 = num;
				num = (short)414275743;
				switch (num2 == num)
				{
				}
				num = (short)490536961;
				if (num != 0)
				{
				}
				num = (short)818413568;
				if (num != 0)
				{
				}
				num = (short)817496064;
				short num3 = num;
				return this.trkWideLabtoolPhase2ScramblingDisable_A37983.Value;
			}
			set
			{
				short num = (short)1011180787;
				short num2 = num;
				num = (short)1577673971;
				switch (num2 == num)
				{
				}
				num = (short)917438465;
				if (num != 0)
				{
				}
				num = (short)1618673664;
				if (num != 0)
				{
				}
				num = (short)552534016;
				short num3 = num;
				this.trkWideLabtoolPhase2ScramblingDisable_A37983.Value = value;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x00070134 File Offset: 0x0006E334
		// (set) Token: 0x06000712 RID: 1810 RVA: 0x000701E8 File Offset: 0x0006E3E8
		public bool TrkWideLabtoolPhase2ScramblingDisable_A37983_Applicable
		{
			get
			{
				short num = (short)418850859;
				short num2 = num;
				num = (short)1003759659;
				switch (num2 == num)
				{
				}
				num = (short)130940928;
				if (num != 0)
				{
				}
				num = (short)284753921;
				if (num != 0)
				{
				}
				num = (short)1432354816;
				short num3 = num;
				return this.trkWideLabtoolPhase2ScramblingDisable_A37983.Applicable;
			}
			set
			{
				short num = (short)992133926;
				short num2 = num;
				num = (short)475120422;
				switch (num2 == num)
				{
				}
				num = (short)873398272;
				if (num != 0)
				{
				}
				num = (short)1986985985;
				if (num != 0)
				{
				}
				num = (short)104988672;
				short num3 = num;
				this.trkWideLabtoolPhase2ScramblingDisable_A37983.Applicable = value;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x000702A0 File Offset: 0x0006E4A0
		// (set) Token: 0x06000714 RID: 1812 RVA: 0x00070354 File Offset: 0x0006E554
		public bool TrkWideLabtoolPhase2ScramblingDisable_A37983_Valid
		{
			get
			{
				short num = (short)1931739136;
				short num2 = num;
				num = (short)579669765;
				short num3 = num;
				num = (short)1857097477;
				switch (num3 == num)
				{
				}
				num = (short)1530003457;
				if (num != 0)
				{
				}
				num = (short)1955987456;
				if (num != 0)
				{
				}
				return this.trkWideLabtoolPhase2ScramblingDisable_A37983.Valid;
			}
			set
			{
				short num = (short)996212736;
				short num2 = num;
				num = (short)1350784765;
				short num3 = num;
				num = (short)2132170493;
				switch (num3 == num)
				{
				}
				num = (short)75956225;
				if (num != 0)
				{
				}
				num = (short)1482948608;
				if (num != 0)
				{
				}
				this.trkWideLabtoolPhase2ScramblingDisable_A37983.Valid = value;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x0007040C File Offset: 0x0006E60C
		// (set) Token: 0x06000716 RID: 1814 RVA: 0x000704C4 File Offset: 0x0006E6C4
		public bool TrkWideLabtoolPhase2ScramblingDisable_A37983_Visible
		{
			get
			{
				short num = (short)1465188352;
				short num2 = num;
				num = (short)2041295644;
				short num3 = num;
				num = (short)685880092;
				switch (num3 == num)
				{
				}
				num = (short)55115777;
				if (num != 0)
				{
				}
				num = (short)75235328;
				if (num != 0)
				{
				}
				return this.trkWideLabtoolPhase2ScramblingDisable_A37983.Visible;
			}
			set
			{
				short num = (short)939196416;
				short num2 = num;
				num = (short)163938633;
				short num3 = num;
				num = (short)1252819273;
				switch (num3 == num)
				{
				}
				num = (short)1641218049;
				if (num != 0)
				{
				}
				num = (short)50331648;
				if (num != 0)
				{
				}
				this.trkWideLabtoolPhase2ScramblingDisable_A37983.Visible = value;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x00070580 File Offset: 0x0006E780
		// (set) Token: 0x06000718 RID: 1816 RVA: 0x00070634 File Offset: 0x0006E834
		public bool TrkWideLabtoolPhase2ScramblingDisable_A37983_Editable
		{
			get
			{
				short num = (short)519503872;
				short num2 = num;
				num = (short)1791143895;
				short num3 = num;
				num = (short)431271895;
				switch (num3 == num)
				{
				}
				num = (short)71630849;
				if (num != 0)
				{
				}
				num = (short)742850560;
				if (num != 0)
				{
				}
				return this.trkWideLabtoolPhase2ScramblingDisable_A37983.Editable;
			}
			set
			{
				short num = (short)869335040;
				short num2 = num;
				num = (short)87172187;
				short num3 = num;
				num = (short)693773403;
				switch (num3 == num)
				{
				}
				num = (short)1926889473;
				if (num != 0)
				{
				}
				num = (short)1331560448;
				if (num != 0)
				{
				}
				this.trkWideLabtoolPhase2ScramblingDisable_A37983.Editable = value;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x000706E8 File Offset: 0x0006E8E8
		internal string TrkWideLabtoolPhase2ScramblingDisable_A37983_UILabel
		{
			get
			{
				short num = (short)921239552;
				short num2 = num;
				num = (short)1891672533;
				short num3 = num;
				num = (short)376807893;
				switch (num3 == num)
				{
				}
				num = (short)195624961;
				if (num != 0)
				{
				}
				num = (short)851968;
				if (num != 0)
				{
				}
				return this.trkWideLabtoolPhase2ScramblingDisable_A37983.UIName;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x0007079C File Offset: 0x0006E99C
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x00070850 File Offset: 0x0006EA50
		internal bool TrkWideLabtoolPhase2ScramblingDisable_A37983_HiddenStatic
		{
			get
			{
				short num = (short)1864761344;
				short num2 = num;
				num = (short)1393011636;
				short num3 = num;
				num = (short)2035264436;
				switch (num3 == num)
				{
				}
				num = (short)227147776;
				if (num != 0)
				{
				}
				num = (short)1204551681;
				if (num != 0)
				{
				}
				return this.trkWideLabtoolPhase2ScramblingDisable_A37983.HiddenStatic;
			}
			set
			{
				short num = (short)718536704;
				short num2 = num;
				num = (short)442035662;
				short num3 = num;
				num = (short)1023733198;
				switch (num3 == num)
				{
				}
				num = (short)910819328;
				if (num != 0)
				{
				}
				num = (short)64290817;
				if (num != 0)
				{
				}
				this.trkWideLabtoolPhase2ScramblingDisable_A37983.HiddenStatic = value;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x00070908 File Offset: 0x0006EB08
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x000709C0 File Offset: 0x0006EBC0
		internal bool TrkWideLabtoolPhase2ScramblingDisable_A37983_HiddenDynamic
		{
			get
			{
				short num = (short)590217216;
				short num2 = num;
				num = (short)1063604740;
				short num3 = num;
				num = (short)1451381252;
				switch (num3 == num)
				{
				}
				num = (short)1884553217;
				if (num != 0)
				{
				}
				num = (short)121503744;
				if (num != 0)
				{
				}
				return this.trkWideLabtoolPhase2ScramblingDisable_A37983.HiddenDynamic;
			}
			set
			{
				short num = (short)1000144896;
				short num2 = num;
				num = (short)1691484161;
				if (num != 0)
				{
				}
				num = (short)130637314;
				short num3 = num;
				num = (short)744962;
				switch (num3 == num)
				{
				}
				num = (short)1229848576;
				if (num != 0)
				{
				}
				this.trkWideLabtoolPhase2ScramblingDisable_A37983.HiddenDynamic = value;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00070A78 File Offset: 0x0006EC78
		public bool TrkWideLabtoolPhase2ScramblingDisable_A37983_HasDiffs
		{
			get
			{
				short num = (short)1299578880;
				short num2 = num;
				num = (short)858752120;
				short num3 = num;
				num = (short)872776824;
				switch (num3 == num)
				{
				}
				num = (short)1375141888;
				if (num != 0)
				{
				}
				num = (short)568918017;
				if (num != 0)
				{
				}
				return this.trkWideLabtoolPhase2ScramblingDisable_A37983._HasDiffs;
			}
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00070B2C File Offset: 0x0006ED2C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)401473536;
			short num2 = num;
			num = (short)975836904;
			short num3 = num;
			num = (short)1963726568;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B9:
				num = (short)219086849;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1645543424;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_98;
				}
				break;
			}
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_7E:
				switch (num4)
				{
				case 0:
					goto IL_AE;
				case 1:
					num = (short)1038548995;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)19136513;
					if (num != 0)
					{
					}
					num = (short)155123716;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)496041986;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 4:
					return result;
				}
				goto IL_98;
			}
			IL_AE:
			if (base.ParentRecset != null)
			{
				goto IL_B9;
			}
			return result;
			IL_98:
			result = null;
			num = (short)1626079232;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_7E;
		}

		// Token: 0x0400020D RID: 525
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideLabtoolDesenseRSSIThreshold_A7827;

		// Token: 0x0400020E RID: 526
		private global::AcpBusinessLayer.AcpField<bool> trkWideLabtoolPhase2ScramblingDisable_A37983;
	}
}
