using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.EmergencyWide
{
	// Token: 0x0200048C RID: 1164
	[global::System.Serializable]
	public class EmergencyToneTrigger : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600987E RID: 39038 RVA: 0x008F1244 File Offset: 0x008EF444
		public EmergencyToneTrigger(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600987F RID: 39039 RVA: 0x008F1260 File Offset: 0x008EF460
		protected EmergencyToneTrigger(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06009880 RID: 39040 RVA: 0x008F1278 File Offset: 0x008EF478
		public override void Init()
		{
			int a_ = 7;
			short num = (short)1994805471;
			short num2 = num;
			num = (short)211243231;
			switch (num2 == num)
			{
			default:
			{
				num = (short)834666496;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)501350401;
			if (num != 0)
			{
			}
			num = (short)1197080576;
			if (num != 0)
			{
			}
			this.triggedByManDown_42135 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳇룉ꗋ꧍럏럑냓铕ꇗ韙뷛냝ꓟ跡鏣裥럧\udee9\udeeb\udfed쏯쟱", a_), global::CommonResources.AcgResources.ID_CUSTOMIZABLETONESPEREMERGENCYPROFILEMANDOWNEMERGENCYTONETRIGGER);
			this.triggedByManDown_42135.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.triggedByManDown_42135.DataTransferOrder = 14;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("诇뿉뿋뫍뿏뿑뷓곕맗룙냛믝샟꟡解菥髧跩觫胭鏯诱퓳ꋵ韷铹駻跽", a_);
			base.Id = 10778;
			base.UIName = global::CommonResources.AcgResources.ID_CUSTOMIZABLEEMERGENCYTONES;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06009881 RID: 39041 RVA: 0x008F1394 File Offset: 0x008EF594
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 12;
			short num = (short)795607046;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駌뷎룐듒닔닖뷘駚ꓜ鋞胠跢ꇤ裦黨藪달\udbee쏰싲웴싶", a_)))
					{
						num = (short)589234180;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B8;
				case 1:
					goto IL_E2;
				case 2:
					goto IL_67;
				case 3:
					if (producerFields != null)
					{
						num = (short)1627914245;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B8;
				case 4:
					this.triggedByManDown_42135 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駌뷎룐듒닔닖뷘駚ꓜ鋞胠跢ꇤ裦黨藪달\udbee쏰싲웴싶", a_), global::CommonResources.AcgResources.ID_CUSTOMIZABLETONESPEREMERGENCYPROFILEMANDOWNEMERGENCYTONETRIGGER);
					this.triggedByManDown_42135.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.triggedByManDown_42135.DataTransferOrder = 14;
					num = (short)2144534529;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)1838560470;
					short num3 = num;
					num = (short)929641686;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_67;
					default:
						num = (short)855834624;
						if (num != 0)
						{
						}
						num = (short)473169920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				}
				IL_49:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1887895554;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_67:
				num = (short)2074607617;
				if (num != 0)
				{
				}
				num = (short)1893531651;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E2:
			IL_1B8:
			num = (short)1374879744;
			short num4 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軌뫎ꋐ꟒뫔뫖냘ꇚ볜뷞跠蛢엤ꋦ蓨軪鿬裮铰鷲雴軶\ud9f8꿺鋼釾搀瀂", a_);
			base.Id = 10778;
			base.UIName = global::CommonResources.AcgResources.ID_CUSTOMIZABLEEMERGENCYTONES;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06009882 RID: 39042 RVA: 0x008F15B4 File Offset: 0x008EF7B4
		public override void PopulateReferences()
		{
			short num = (short)289035170;
			short num2 = num;
			num = (short)1875006370;
			switch (num2 == num)
			{
			default:
			{
				num = (short)461701120;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)837222400;
			if (num != 0)
			{
			}
			num = (short)814219265;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009883 RID: 39043 RVA: 0x008F165C File Offset: 0x008EF85C
		public override void DropReferences()
		{
			short num = (short)1996416011;
			short num2 = num;
			num = (short)1274078219;
			switch (num2 == num)
			{
			default:
			{
				num = (short)936902656;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)936574977;
			if (num != 0)
			{
			}
			num = (short)1734606848;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009884 RID: 39044 RVA: 0x008F1704 File Offset: 0x008EF904
		public override void SetConstraints()
		{
			short num = (short)625554321;
			short num2 = num;
			num = (short)952644497;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1557594112;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1593966592;
			if (num != 0)
			{
			}
			num = (short)1569849345;
			if (num != 0)
			{
			}
			this.triggedByManDown_42135.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideConstraints.ConPerEmerProfIsSelected);
		}

		// Token: 0x06009885 RID: 39045 RVA: 0x008F17C8 File Offset: 0x008EF9C8
		public override void SetupDependencies()
		{
			short num = (short)900498543;
			short num2 = num;
			num = (short)1685029999;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1903951872;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)645332992;
			if (num != 0)
			{
			}
			num = (short)1073283073;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide emergencyWide = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide;
			emergencyWide.ManDown.ManDownConfigurabilityGranularityLevel_42057.AddDependentObject(this.triggedByManDown_42135);
			emergencyWide.ManDown.EmerWideManDownTrigger_A40001.AddDependentObject(this.triggedByManDown_42135);
		}

		// Token: 0x17004C8E RID: 19598
		// (get) Token: 0x06009886 RID: 39046 RVA: 0x008F18A8 File Offset: 0x008EFAA8
		public bool HasDiffs
		{
			get
			{
				short num = (short)1791033345;
				if (num != 0)
				{
				}
				num = (short)2017329152;
				short num2 = num;
				num = (short)188910263;
				short num3 = num;
				num = (short)200837815;
				switch (num3 == num)
				{
				}
				num = (short)208797696;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004C8F RID: 19599
		// (get) Token: 0x06009887 RID: 39047 RVA: 0x008F195C File Offset: 0x008EFB5C
		// (set) Token: 0x06009888 RID: 39048 RVA: 0x008F1A14 File Offset: 0x008EFC14
		public bool TriggedByManDown_42135Value
		{
			get
			{
				short num = (short)149199618;
				short num2 = num;
				num = (short)868588290;
				switch (num2 == num)
				{
				default:
				{
					num = (short)579010560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)328204289;
				if (num != 0)
				{
				}
				num = (short)1744437248;
				if (num != 0)
				{
				}
				return this.triggedByManDown_42135.Value;
			}
			set
			{
				short num = (short)1819411265;
				short num2 = num;
				num = (short)543949633;
				switch (num2 == num)
				{
				default:
				{
					num = (short)499122176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)164233217;
				if (num != 0)
				{
				}
				num = (short)1815805952;
				if (num != 0)
				{
				}
				this.triggedByManDown_42135.Value = value;
			}
		}

		// Token: 0x17004C90 RID: 19600
		// (get) Token: 0x06009889 RID: 39049 RVA: 0x008F1AC8 File Offset: 0x008EFCC8
		public global::AcpBusinessLayer.AcpField<bool> TriggedByManDown_42135
		{
			get
			{
				short num = (short)1853340866;
				short num2 = num;
				num = (short)1102101698;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1009778688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)638255105;
				if (num != 0)
				{
				}
				num = (short)728891392;
				if (num != 0)
				{
				}
				return this.triggedByManDown_42135;
			}
		}

		// Token: 0x17004C91 RID: 19601
		// (get) Token: 0x0600988A RID: 39050 RVA: 0x008F1B78 File Offset: 0x008EFD78
		// (set) Token: 0x0600988B RID: 39051 RVA: 0x008F1C30 File Offset: 0x008EFE30
		public bool TriggedByManDown_42135_UIValue
		{
			get
			{
				short num = (short)692622058;
				short num2 = num;
				num = (short)1716294378;
				switch (num2 == num)
				{
				default:
				{
					num = (short)414646272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2118713345;
				if (num != 0)
				{
				}
				num = (short)600768512;
				if (num != 0)
				{
				}
				return this.triggedByManDown_42135.Value;
			}
			set
			{
				short num = (short)1834254544;
				short num2 = num;
				num = (short)1017544912;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1657012224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1487667200;
				if (num != 0)
				{
				}
				num = (short)365821953;
				if (num != 0)
				{
				}
				this.triggedByManDown_42135.Value = value;
			}
		}

		// Token: 0x17004C92 RID: 19602
		// (get) Token: 0x0600988C RID: 39052 RVA: 0x008F1CE4 File Offset: 0x008EFEE4
		// (set) Token: 0x0600988D RID: 39053 RVA: 0x008F1D98 File Offset: 0x008EFF98
		public bool TriggedByManDown_42135_Applicable
		{
			get
			{
				short num = (short)2006180526;
				short num2 = num;
				num = (short)235528878;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1654718464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1933967360;
				if (num != 0)
				{
				}
				num = (short)65601537;
				if (num != 0)
				{
				}
				return this.triggedByManDown_42135.Applicable;
			}
			set
			{
				short num = (short)165157802;
				short num2 = num;
				num = (short)1925585834;
				switch (num2 == num)
				{
				default:
				{
					num = (short)719323136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1130692609;
				if (num != 0)
				{
				}
				num = (short)1709834240;
				if (num != 0)
				{
				}
				this.triggedByManDown_42135.Applicable = value;
			}
		}

		// Token: 0x17004C93 RID: 19603
		// (get) Token: 0x0600988E RID: 39054 RVA: 0x008F1E54 File Offset: 0x008F0054
		// (set) Token: 0x0600988F RID: 39055 RVA: 0x008F1F0C File Offset: 0x008F010C
		public bool TriggedByManDown_42135_Valid
		{
			get
			{
				short num = (short)1092981261;
				short num2 = num;
				num = (short)387879437;
				switch (num2 == num)
				{
				}
				num = (short)1060503553;
				if (num != 0)
				{
				}
				num = (short)1916403712;
				short num3 = num;
				num = (short)58195968;
				if (num != 0)
				{
				}
				return this.triggedByManDown_42135.Valid;
			}
			set
			{
				short num = (short)185311667;
				short num2 = num;
				num = (short)1569104307;
				switch (num2 == num)
				{
				}
				num = (short)1697185793;
				if (num != 0)
				{
				}
				num = (short)825556992;
				short num3 = num;
				num = (short)1095761920;
				if (num != 0)
				{
				}
				this.triggedByManDown_42135.Valid = value;
			}
		}

		// Token: 0x17004C94 RID: 19604
		// (get) Token: 0x06009890 RID: 39056 RVA: 0x008F1FC4 File Offset: 0x008F01C4
		// (set) Token: 0x06009891 RID: 39057 RVA: 0x008F2074 File Offset: 0x008F0274
		public bool TriggedByManDown_42135_Visible
		{
			get
			{
				short num = (short)163129375;
				short num2 = num;
				num = (short)454567967;
				switch (num2 == num)
				{
				}
				num = (short)1461518336;
				if (num != 0)
				{
				}
				num = (short)356843520;
				short num3 = num;
				num = (short)1649410049;
				if (num != 0)
				{
				}
				return this.triggedByManDown_42135.Visible;
			}
			set
			{
				short num = (short)2023264081;
				short num2 = num;
				num = (short)1355190097;
				switch (num2 == num)
				{
				}
				num = (short)1536688129;
				if (num != 0)
				{
				}
				num = (short)1824456704;
				short num3 = num;
				num = (short)1315897344;
				if (num != 0)
				{
				}
				this.triggedByManDown_42135.Visible = value;
			}
		}

		// Token: 0x17004C95 RID: 19605
		// (get) Token: 0x06009892 RID: 39058 RVA: 0x008F2128 File Offset: 0x008F0328
		// (set) Token: 0x06009893 RID: 39059 RVA: 0x008F21DC File Offset: 0x008F03DC
		public bool TriggedByManDown_42135_Editable
		{
			get
			{
				short num = (short)151060580;
				short num2 = num;
				num = (short)37355620;
				switch (num2 == num)
				{
				}
				num = (short)525139969;
				if (num != 0)
				{
				}
				num = (short)1997340672;
				short num3 = num;
				num = (short)1379074048;
				if (num != 0)
				{
				}
				return this.triggedByManDown_42135.Editable;
			}
			set
			{
				short num = (short)1187673316;
				short num2 = num;
				num = (short)484996324;
				switch (num2 == num)
				{
				}
				num = (short)614596608;
				if (num != 0)
				{
				}
				num = (short)903151616;
				short num3 = num;
				num = (short)842989569;
				if (num != 0)
				{
				}
				this.triggedByManDown_42135.Editable = value;
			}
		}

		// Token: 0x17004C96 RID: 19606
		// (get) Token: 0x06009894 RID: 39060 RVA: 0x008F2294 File Offset: 0x008F0494
		internal string TriggedByManDown_42135_UILabel
		{
			get
			{
				short num = (short)981281734;
				short num2 = num;
				num = (short)79637446;
				switch (num2 == num)
				{
				}
				num = (short)1407713281;
				if (num != 0)
				{
				}
				num = (short)1733033984;
				short num3 = num;
				num = (short)35586048;
				if (num != 0)
				{
				}
				return this.triggedByManDown_42135.UIName;
			}
		}

		// Token: 0x17004C97 RID: 19607
		// (get) Token: 0x06009895 RID: 39061 RVA: 0x008F2348 File Offset: 0x008F0548
		// (set) Token: 0x06009896 RID: 39062 RVA: 0x008F23FC File Offset: 0x008F05FC
		internal bool TriggedByManDown_42135_HiddenStatic
		{
			get
			{
				short num = (short)293798214;
				short num2 = num;
				num = (short)2093285702;
				switch (num2 == num)
				{
				}
				num = (short)253820929;
				if (num != 0)
				{
				}
				num = (short)342818816;
				short num3 = num;
				num = (short)1657470976;
				if (num != 0)
				{
				}
				return this.triggedByManDown_42135.HiddenStatic;
			}
			set
			{
				short num = (short)868327553;
				short num2 = num;
				num = (short)760127617;
				switch (num2 == num)
				{
				}
				num = (short)2043346945;
				if (num != 0)
				{
				}
				num = (short)736362496;
				short num3 = num;
				num = (short)203816960;
				if (num != 0)
				{
				}
				this.triggedByManDown_42135.HiddenStatic = value;
			}
		}

		// Token: 0x17004C98 RID: 19608
		// (get) Token: 0x06009897 RID: 39063 RVA: 0x008F24B4 File Offset: 0x008F06B4
		// (set) Token: 0x06009898 RID: 39064 RVA: 0x008F2568 File Offset: 0x008F0768
		internal bool TriggedByManDown_42135_HiddenDynamic
		{
			get
			{
				short num = (short)1521368051;
				short num2 = num;
				num = (short)1991392243;
				switch (num2 == num)
				{
				}
				num = (short)1792999425;
				if (num != 0)
				{
				}
				num = (short)930414592;
				short num3 = num;
				num = (short)193724416;
				if (num != 0)
				{
				}
				return this.triggedByManDown_42135.HiddenDynamic;
			}
			set
			{
				short num = (short)1939891175;
				short num2 = num;
				num = (short)569992167;
				switch (num2 == num)
				{
				}
				num = (short)1699545088;
				if (num != 0)
				{
				}
				num = (short)2085879808;
				short num3 = num;
				num = (short)1511981057;
				if (num != 0)
				{
				}
				this.triggedByManDown_42135.HiddenDynamic = value;
			}
		}

		// Token: 0x17004C99 RID: 19609
		// (get) Token: 0x06009899 RID: 39065 RVA: 0x008F2620 File Offset: 0x008F0820
		public bool TriggedByManDown_42135_HasDiffs
		{
			get
			{
				short num = (short)584702056;
				short num2 = num;
				num = (short)707778664;
				switch (num2 == num)
				{
				}
				num = (short)1025638401;
				if (num != 0)
				{
				}
				num = (short)1979842560;
				short num3 = num;
				num = (short)1283129344;
				if (num != 0)
				{
				}
				return this.triggedByManDown_42135._HasDiffs;
			}
		}

		// Token: 0x0600989A RID: 39066 RVA: 0x008F26D8 File Offset: 0x008F08D8
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1283850244;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					if (base.ParentRecset != null)
					{
						num2 = (short)201195522;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					num2 = (short)935133184;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_FB;
				case 4:
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1989804032;
					short num3 = num2;
					num2 = (short)848625667;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				break;
			}
			IL_24:
			result = null;
			num2 = (short)166110868;
			short num4 = num2;
			num2 = (short)838117012;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_FB:
				num2 = (short)786759681;
				if (num2 != 0)
				{
				}
				break;
			default:
			{
				num2 = (short)850722816;
				if (num2 != 0)
				{
				}
				num2 = (short)774176769;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			return result;
		}

		// Token: 0x04004B33 RID: 19251
		private global::AcpBusinessLayer.AcpField<bool> triggedByManDown_42135;
	}
}
