using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalSystem
{
	// Token: 0x02000576 RID: 1398
	[global::System.Serializable]
	public class QuikCallII : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600BEBA RID: 48826 RVA: 0x00B02850 File Offset: 0x00B00A50
		public QuikCallII(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600BEBB RID: 48827 RVA: 0x00B02890 File Offset: 0x00B00A90
		protected QuikCallII(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600BEBC RID: 48828 RVA: 0x00B028A8 File Offset: 0x00B00AA8
		public override void Init()
		{
			int a_ = 2;
			short num = (short)1454088460;
			short num2 = num;
			num = (short)694460684;
			switch (num2 == num)
			{
			default:
			{
				num = (short)500498432;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)567541761;
			if (num != 0)
			{
			}
			num = (short)1082458112;
			if (num != 0)
			{
			}
			this.cnvSysGeneralQc2CallFormat_A42230 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆髈닊뻌裎듐뷒냔ꗖ룘럚賜볞폠ꃢ蓤详藨귪苬鷮鳰鋲致ꣶ룸쿺쿼췾㈀㌂", a_), global::CommonResources.AcgResources.ID_CALLFORMAT, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.CnvSysGeneralQc2CallFormat_A42230LovStrs);
			this.cnvSysGeneralQc2CallFormat_A42230.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvSysGeneralQc2CallFormat_A42230.DataTransferOrder = 200;
			this.cnvSysQCIIDecode = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胂ꯄ뇆髈닊뻌黎鋐髒鳔鏖볘룚닜믞蓠", a_), global::CommonResources.AcgResources.ID_QCIIDECODE);
			this.cnvSysQCIIDecode.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvSysQCIIDecode.DataTransferOrder = 201;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鋂냄껆ꋈ軌껎뷐뿒黖郘", a_);
			base.Id = 10785;
			base.UIName = global::CommonResources.AcgResources.ID_QUIKCALLII;
			base.DataTransferOrder = 10;
		}

		// Token: 0x0600BEBD RID: 48829 RVA: 0x00B02A08 File Offset: 0x00B00C08
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 12;
			short num = (short)1805189129;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.cnvSysGeneralQc2CallFormat_A42230 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ胒곔ꓖ默뻚돜뫞鏠苢觤뛦諨\ud9ea껬軮鷰鿲돴飶诸雺鳼课帀䈂㄄㔆㬈㠊㴌", a_), global::CommonResources.AcgResources.ID_CALLFORMAT, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.CnvSysGeneralQc2CallFormat_A42230LovStrs);
					this.cnvSysGeneralQc2CallFormat_A42230.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvSysGeneralQc2CallFormat_A42230.DataTransferOrder = 200;
					num = (short)1921581060;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)73990145;
					if (num != 0)
					{
					}
					num = (short)978190338;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ胒곔ꓖ默뻚돜뫞鏠苢觤뛦諨\ud9ea껬軮鷰鿲돴飶诸雺鳼课帀䈂㄄㔆㬈㠊㴌", a_)))
					{
						num = (short)1215823872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_79;
				case 3:
					for (;;)
					{
						num = (short)573294007;
						short num3 = num;
						num = (short)212714935;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_1DF;
						}
					}
					IL_1DF:
					num = (short)1870790656;
					if (num != 0)
					{
					}
					this.cnvSysQCIIDecode = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ胒곔ꓖ裘飚铜雞ꗠ蛢蛤裦跨軪", a_), global::CommonResources.AcgResources.ID_QCIIDECODE);
					this.cnvSysQCIIDecode.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvSysQCIIDecode.DataTransferOrder = 201;
					num = (short)1860239367;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)1943732224;
					short num4 = num;
					goto IL_79;
				}
				case 5:
					if (producerFields != null)
					{
						num = (short)1650786305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_298;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ胒곔ꓖ裘飚铜雞ꗠ蛢蛤裦跨軪", a_)))
					{
						num = (short)1760493571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_298;
				case 7:
					goto IL_249;
				case 8:
					num = (short)30212101;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				}
				IL_55:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)417005576;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_79:
				num = (short)950206470;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_249:
			IL_298:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鳌뫎룐룒铖룘럚뇜￞꣠ꫢ", a_);
			base.Id = 10785;
			base.UIName = global::CommonResources.AcgResources.ID_QUIKCALLII;
			base.DataTransferOrder = 10;
		}

		// Token: 0x0600BEBE RID: 48830 RVA: 0x00B02CE0 File Offset: 0x00B00EE0
		public override void PopulateReferences()
		{
			short num = (short)318381115;
			short num2 = num;
			num = (short)10165307;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1920270336;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)736231425;
			if (num != 0)
			{
			}
			num = (short)20054016;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600BEBF RID: 48831 RVA: 0x00B02D88 File Offset: 0x00B00F88
		public override void DropReferences()
		{
			short num = (short)1041238326;
			short num2 = num;
			num = (short)1959659830;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1942945792;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2077818880;
			if (num != 0)
			{
			}
			num = (short)105250817;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600BEC0 RID: 48832 RVA: 0x00B02E34 File Offset: 0x00B01034
		public override void SetConstraints()
		{
			short num = (short)572325889;
			if (num != 0)
			{
			}
			num = (short)63963136;
			short num2 = num;
			num = (short)1277580326;
			short num3 = num;
			num = (short)1645171750;
			switch (num3 == num)
			{
			}
			num = (short)6815744;
			if (num != 0)
			{
			}
			this.cnvSysGeneralQc2CallFormat_A42230.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsQC2ORMDCWithQCIIDecodeEnable);
			this.cnvSysGeneralQc2CallFormat_A42230.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConIsVisibleSystemTypeIsQC2ORMDC);
			this.CnvSysQCIIDecode.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConIsVisibleSystemTypeIsQC2ORMDC);
			this.CnvSysQCIIDecode.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsMDC);
		}

		// Token: 0x0600BEC1 RID: 48833 RVA: 0x00B02F3C File Offset: 0x00B0113C
		public override void SetupDependencies()
		{
			short num = (short)425590785;
			if (num != 0)
			{
			}
			num = (short)582877184;
			short num2 = num;
			num = (short)1095980558;
			short num3 = num;
			num = (short)407590414;
			switch (num3 == num)
			{
			}
			num = (short)935591936;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysGeneralQc2CallFormat_A42230);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.CnvSysQCIIDecode);
		}

		// Token: 0x17005FC1 RID: 24513
		// (get) Token: 0x0600BEC2 RID: 48834 RVA: 0x00B03020 File Offset: 0x00B01220
		public bool HasDiffs
		{
			get
			{
				short num = (short)326632757;
				short num2 = num;
				num = (short)974980405;
				switch (num2 == num)
				{
				default:
				{
					num = (short)720437248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)621019137;
				if (num != 0)
				{
				}
				num = (short)1982136320;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17005FC2 RID: 24514
		// (get) Token: 0x0600BEC3 RID: 48835 RVA: 0x00B030D0 File Offset: 0x00B012D0
		// (set) Token: 0x0600BEC4 RID: 48836 RVA: 0x00B03184 File Offset: 0x00B01384
		public bool CnvSysQCIIDecodeValue
		{
			get
			{
				short num = (short)998428638;
				short num2 = num;
				num = (short)1089261534;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1197211648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)366608385;
				if (num != 0)
				{
				}
				num = (short)1998782464;
				if (num != 0)
				{
				}
				return this.cnvSysQCIIDecode.Value;
			}
			set
			{
				short num = (short)1380835033;
				short num2 = num;
				num = (short)1755897561;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1499070464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1178599425;
				if (num != 0)
				{
				}
				num = (short)614268928;
				if (num != 0)
				{
				}
				this.cnvSysQCIIDecode.Value = value;
			}
		}

		// Token: 0x17005FC3 RID: 24515
		// (get) Token: 0x0600BEC5 RID: 48837 RVA: 0x00B0323C File Offset: 0x00B0143C
		public global::AcpBusinessLayer.AcpField<bool> CnvSysQCIIDecode
		{
			get
			{
				short num = (short)1057395354;
				short num2 = num;
				num = (short)2049086106;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1079115776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1141768193;
				if (num != 0)
				{
				}
				num = (short)804061184;
				if (num != 0)
				{
				}
				return this.cnvSysQCIIDecode;
			}
		}

		// Token: 0x17005FC4 RID: 24516
		// (get) Token: 0x0600BEC6 RID: 48838 RVA: 0x00B032E8 File Offset: 0x00B014E8
		// (set) Token: 0x0600BEC7 RID: 48839 RVA: 0x00B0339C File Offset: 0x00B0159C
		public bool CnvSysQCIIDecode_UIValue
		{
			get
			{
				short num = (short)651100161;
				if (num != 0)
				{
				}
				num = (short)19005440;
				short num2 = num;
				num = (short)349275512;
				short num3 = num;
				num = (short)788628856;
				switch (num3 == num)
				{
				}
				num = (short)1074724864;
				if (num != 0)
				{
				}
				return this.cnvSysQCIIDecode.Value;
			}
			set
			{
				short num = (short)1951913068;
				short num2 = num;
				num = (short)2126304364;
				switch (num2 == num)
				{
				default:
				{
					num = (short)561119232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)729743360;
				if (num != 0)
				{
				}
				num = (short)1405616129;
				if (num != 0)
				{
				}
				this.cnvSysQCIIDecode.Value = value;
			}
		}

		// Token: 0x17005FC5 RID: 24517
		// (get) Token: 0x0600BEC8 RID: 48840 RVA: 0x00B03450 File Offset: 0x00B01650
		// (set) Token: 0x0600BEC9 RID: 48841 RVA: 0x00B03508 File Offset: 0x00B01708
		public bool CnvSysQCIIDecode_Applicable
		{
			get
			{
				short num = (short)745537537;
				if (num != 0)
				{
				}
				num = (short)1725628416;
				short num2 = num;
				num = (short)1571541399;
				short num3 = num;
				num = (short)1843057047;
				switch (num3 == num)
				{
				}
				num = (short)154140672;
				if (num != 0)
				{
				}
				return this.cnvSysQCIIDecode.Applicable;
			}
			set
			{
				short num = (short)436251274;
				short num2 = num;
				num = (short)34843274;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1847984128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)52625409;
				if (num != 0)
				{
				}
				num = (short)850788352;
				if (num != 0)
				{
				}
				this.cnvSysQCIIDecode.Applicable = value;
			}
		}

		// Token: 0x17005FC6 RID: 24518
		// (get) Token: 0x0600BECA RID: 48842 RVA: 0x00B035BC File Offset: 0x00B017BC
		// (set) Token: 0x0600BECB RID: 48843 RVA: 0x00B03670 File Offset: 0x00B01870
		public bool CnvSysQCIIDecode_Valid
		{
			get
			{
				short num = (short)44860353;
				short num2 = num;
				num = (short)215712705;
				switch (num2 == num)
				{
				}
				num = (short)1514340352;
				short num3 = num;
				num = (short)961347585;
				if (num != 0)
				{
				}
				num = (short)994508800;
				if (num != 0)
				{
				}
				return this.cnvSysQCIIDecode.Valid;
			}
			set
			{
				short num = (short)292725215;
				short num2 = num;
				num = (short)1843110367;
				switch (num2 == num)
				{
				}
				num = (short)1944649728;
				short num3 = num;
				num = (short)12124160;
				if (num != 0)
				{
				}
				num = (short)1304035329;
				if (num != 0)
				{
				}
				this.cnvSysQCIIDecode.Valid = value;
			}
		}

		// Token: 0x17005FC7 RID: 24519
		// (get) Token: 0x0600BECC RID: 48844 RVA: 0x00B03728 File Offset: 0x00B01928
		// (set) Token: 0x0600BECD RID: 48845 RVA: 0x00B037E0 File Offset: 0x00B019E0
		public bool CnvSysQCIIDecode_Visible
		{
			get
			{
				short num = (short)1113502856;
				short num2 = num;
				num = (short)1441969288;
				switch (num2 == num)
				{
				}
				num = (short)1315635200;
				short num3 = num;
				num = (short)1405943808;
				if (num != 0)
				{
				}
				num = (short)1704722433;
				if (num != 0)
				{
				}
				return this.cnvSysQCIIDecode.Visible;
			}
			set
			{
				short num = (short)108195785;
				short num2 = num;
				num = (short)146468809;
				switch (num2 == num)
				{
				}
				num = (short)35586048;
				short num3 = num;
				num = (short)836894721;
				if (num != 0)
				{
				}
				num = (short)347406336;
				if (num != 0)
				{
				}
				this.cnvSysQCIIDecode.Visible = value;
			}
		}

		// Token: 0x17005FC8 RID: 24520
		// (get) Token: 0x0600BECE RID: 48846 RVA: 0x00B03898 File Offset: 0x00B01A98
		// (set) Token: 0x0600BECF RID: 48847 RVA: 0x00B0394C File Offset: 0x00B01B4C
		public bool CnvSysQCIIDecode_Editable
		{
			get
			{
				short num = (short)369924396;
				short num2 = num;
				num = (short)1565104428;
				switch (num2 == num)
				{
				}
				num = (short)1617625088;
				short num3 = num;
				num = (short)1330642945;
				if (num != 0)
				{
				}
				num = (short)53411840;
				if (num != 0)
				{
				}
				return this.cnvSysQCIIDecode.Editable;
			}
			set
			{
				short num = (short)1385294255;
				short num2 = num;
				num = (short)569043375;
				switch (num2 == num)
				{
				}
				num = (short)2123825152;
				short num3 = num;
				num = (short)65011712;
				if (num != 0)
				{
				}
				num = (short)869924865;
				if (num != 0)
				{
				}
				this.cnvSysQCIIDecode.Editable = value;
			}
		}

		// Token: 0x17005FC9 RID: 24521
		// (get) Token: 0x0600BED0 RID: 48848 RVA: 0x00B03A00 File Offset: 0x00B01C00
		internal string CnvSysQCIIDecode_UILabel
		{
			get
			{
				short num = (short)862788696;
				short num2 = num;
				num = (short)1966152792;
				switch (num2 == num)
				{
				}
				num = (short)106037248;
				short num3 = num;
				num = (short)1733623809;
				if (num != 0)
				{
				}
				num = (short)729808896;
				if (num != 0)
				{
				}
				return this.cnvSysQCIIDecode.UIName;
			}
		}

		// Token: 0x17005FCA RID: 24522
		// (get) Token: 0x0600BED1 RID: 48849 RVA: 0x00B03AB4 File Offset: 0x00B01CB4
		// (set) Token: 0x0600BED2 RID: 48850 RVA: 0x00B03B68 File Offset: 0x00B01D68
		internal bool CnvSysQCIIDecode_HiddenStatic
		{
			get
			{
				short num = (short)622394686;
				short num2 = num;
				num = (short)1453587774;
				switch (num2 == num)
				{
				}
				num = (short)1796669440;
				short num3 = num;
				num = (short)935395329;
				if (num != 0)
				{
				}
				num = (short)109838336;
				if (num != 0)
				{
				}
				return this.cnvSysQCIIDecode.HiddenStatic;
			}
			set
			{
				short num = (short)217968940;
				short num2 = num;
				num = (short)1847324972;
				switch (num2 == num)
				{
				}
				num = (short)1694564352;
				short num3 = num;
				num = (short)1170145281;
				if (num != 0)
				{
				}
				num = (short)1638727680;
				if (num != 0)
				{
				}
				this.cnvSysQCIIDecode.HiddenStatic = value;
			}
		}

		// Token: 0x17005FCB RID: 24523
		// (get) Token: 0x0600BED3 RID: 48851 RVA: 0x00B03C1C File Offset: 0x00B01E1C
		// (set) Token: 0x0600BED4 RID: 48852 RVA: 0x00B03CD0 File Offset: 0x00B01ED0
		internal bool CnvSysQCIIDecode_HiddenDynamic
		{
			get
			{
				short num = (short)1636027591;
				short num2 = num;
				num = (short)95603911;
				switch (num2 == num)
				{
				}
				num = (short)1557331968;
				short num3 = num;
				num = (short)1533739009;
				if (num != 0)
				{
				}
				num = (short)367067136;
				if (num != 0)
				{
				}
				return this.cnvSysQCIIDecode.HiddenDynamic;
			}
			set
			{
				short num = (short)2129639238;
				short num2 = num;
				num = (short)1868085062;
				switch (num2 == num)
				{
				}
				num = (short)467009536;
				short num3 = num;
				num = (short)1977417729;
				if (num != 0)
				{
				}
				num = (short)4325376;
				if (num != 0)
				{
				}
				this.cnvSysQCIIDecode.HiddenDynamic = value;
			}
		}

		// Token: 0x17005FCC RID: 24524
		// (get) Token: 0x0600BED5 RID: 48853 RVA: 0x00B03D88 File Offset: 0x00B01F88
		public bool CnvSysQCIIDecode_HasDiffs
		{
			get
			{
				short num = (short)83965148;
				short num2 = num;
				num = (short)130888924;
				switch (num2 == num)
				{
				}
				num = (short)1728839680;
				short num3 = num;
				num = (short)1070006272;
				if (num != 0)
				{
				}
				num = (short)915341313;
				if (num != 0)
				{
				}
				return this.cnvSysQCIIDecode._HasDiffs;
			}
		}

		// Token: 0x17005FCD RID: 24525
		// (get) Token: 0x0600BED6 RID: 48854 RVA: 0x00B03E3C File Offset: 0x00B0203C
		// (set) Token: 0x0600BED7 RID: 48855 RVA: 0x00B03EF0 File Offset: 0x00B020F0
		public int CnvSysGeneralQc2CallFormat_A42230Value
		{
			get
			{
				short num = (short)1639120897;
				if (num != 0)
				{
				}
				num = (short)69222182;
				short num2 = num;
				num = (short)115359526;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1574895616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1990197248;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2CallFormat_A42230.Value;
			}
			set
			{
				short num = (short)1856241665;
				if (num != 0)
				{
				}
				num = (short)2082470848;
				short num2 = num;
				num = (short)174259136;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1718157312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1834024960;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2CallFormat_A42230.Value = value;
			}
		}

		// Token: 0x17005FCE RID: 24526
		// (get) Token: 0x0600BED8 RID: 48856 RVA: 0x00B03FA4 File Offset: 0x00B021A4
		// (set) Token: 0x0600BED9 RID: 48857 RVA: 0x00B04060 File Offset: 0x00B02260
		public string CnvSysGeneralQc2CallFormat_A42230_UIValue
		{
			get
			{
				short num = (short)1376714753;
				if (num != 0)
				{
				}
				num = (short)162925592;
				short num2 = num;
				num = (short)2028211224;
				switch (num2 == num)
				{
				default:
				{
					num = (short)742981632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1127743488;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2CallFormat_A42230.UIValue;
			}
			set
			{
				short num = (short)181701740;
				short num2 = num;
				num = (short)1137675372;
				switch (num2 == num)
				{
				}
				num = (short)753729536;
				short num3 = num;
				num = (short)1663762433;
				if (num != 0)
				{
				}
				num = (short)1077608448;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2CallFormat_A42230.UIValue = value;
			}
		}

		// Token: 0x17005FCF RID: 24527
		// (get) Token: 0x0600BEDA RID: 48858 RVA: 0x00B04114 File Offset: 0x00B02314
		public global::AcpBusinessLayer.AcpListField CnvSysGeneralQc2CallFormat_A42230
		{
			get
			{
				short num = (short)1563616214;
				short num2 = num;
				num = (short)281273302;
				switch (num2 == num)
				{
				}
				num = (short)785055744;
				short num3 = num;
				num = (short)1020067840;
				if (num != 0)
				{
				}
				num = (short)857210881;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2CallFormat_A42230;
			}
		}

		// Token: 0x17005FD0 RID: 24528
		// (get) Token: 0x0600BEDB RID: 48859 RVA: 0x00B041C0 File Offset: 0x00B023C0
		// (set) Token: 0x0600BEDC RID: 48860 RVA: 0x00B04278 File Offset: 0x00B02478
		public bool CnvSysGeneralQc2CallFormat_A42230_Applicable
		{
			get
			{
				short num = (short)1685531195;
				short num2 = num;
				num = (short)1630415419;
				switch (num2 == num)
				{
				}
				num = (short)1452408832;
				short num3 = num;
				num = (short)991297537;
				if (num != 0)
				{
				}
				num = (short)919076864;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2CallFormat_A42230.Applicable;
			}
			set
			{
				short num = (short)899312522;
				short num2 = num;
				num = (short)594111370;
				switch (num2 == num)
				{
				}
				num = (short)1538260992;
				short num3 = num;
				num = (short)207159297;
				if (num != 0)
				{
				}
				num = (short)931397632;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2CallFormat_A42230.Applicable = value;
			}
		}

		// Token: 0x17005FD1 RID: 24529
		// (get) Token: 0x0600BEDD RID: 48861 RVA: 0x00B04330 File Offset: 0x00B02530
		// (set) Token: 0x0600BEDE RID: 48862 RVA: 0x00B043E8 File Offset: 0x00B025E8
		public bool CnvSysGeneralQc2CallFormat_A42230_Valid
		{
			get
			{
				short num = (short)659039838;
				short num2 = num;
				num = (short)629024350;
				switch (num2 == num)
				{
				}
				num = (short)1251278848;
				short num3 = num;
				num = (short)1585381376;
				if (num != 0)
				{
				}
				num = (short)306184193;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2CallFormat_A42230.Valid;
			}
			set
			{
				short num = (short)2027770255;
				short num2 = num;
				num = (short)779833743;
				switch (num2 == num)
				{
				}
				num = (short)899940352;
				short num3 = num;
				num = (short)1369309185;
				if (num != 0)
				{
				}
				num = (short)476643328;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2CallFormat_A42230.Valid = value;
			}
		}

		// Token: 0x17005FD2 RID: 24530
		// (get) Token: 0x0600BEDF RID: 48863 RVA: 0x00B044A0 File Offset: 0x00B026A0
		// (set) Token: 0x0600BEE0 RID: 48864 RVA: 0x00B04550 File Offset: 0x00B02750
		public bool CnvSysGeneralQc2CallFormat_A42230_Visible
		{
			get
			{
				short num = (short)756548143;
				short num2 = num;
				num = (short)13238831;
				switch (num2 == num)
				{
				}
				num = (short)707395584;
				short num3 = num;
				num = (short)896663553;
				if (num != 0)
				{
				}
				num = (short)803012608;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2CallFormat_A42230.Visible;
			}
			set
			{
				short num = (short)1739457880;
				short num2 = num;
				num = (short)1136985432;
				switch (num2 == num)
				{
				}
				num = (short)832634880;
				short num3 = num;
				num = (short)660996096;
				if (num != 0)
				{
				}
				num = (short)1678442497;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2CallFormat_A42230.Visible = value;
			}
		}

		// Token: 0x17005FD3 RID: 24531
		// (get) Token: 0x0600BEE1 RID: 48865 RVA: 0x00B04604 File Offset: 0x00B02804
		// (set) Token: 0x0600BEE2 RID: 48866 RVA: 0x00B046B8 File Offset: 0x00B028B8
		public bool CnvSysGeneralQc2CallFormat_A42230_Editable
		{
			get
			{
				short num = (short)1923814301;
				short num2 = num;
				num = (short)1369838493;
				switch (num2 == num)
				{
				}
				num = (short)379912192;
				short num3 = num;
				num = (short)1821769729;
				if (num != 0)
				{
				}
				num = (short)880148480;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2CallFormat_A42230.Editable;
			}
			set
			{
				short num = (short)751433744;
				short num2 = num;
				num = (short)1648556048;
				switch (num2 == num)
				{
				}
				num = (short)557842432;
				short num3 = num;
				num = (short)1597177856;
				if (num != 0)
				{
				}
				num = (short)1758265345;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2CallFormat_A42230.Editable = value;
			}
		}

		// Token: 0x17005FD4 RID: 24532
		// (get) Token: 0x0600BEE3 RID: 48867 RVA: 0x00B0476C File Offset: 0x00B0296C
		internal string CnvSysGeneralQc2CallFormat_A42230_UILabel
		{
			get
			{
				short num = (short)412769920;
				short num2 = num;
				num = (short)941383296;
				switch (num2 == num)
				{
				}
				num = (short)586612736;
				short num3 = num;
				num = (short)1357185025;
				if (num != 0)
				{
				}
				num = (short)315293696;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2CallFormat_A42230.UIName;
			}
		}

		// Token: 0x17005FD5 RID: 24533
		// (get) Token: 0x0600BEE4 RID: 48868 RVA: 0x00B04820 File Offset: 0x00B02A20
		// (set) Token: 0x0600BEE5 RID: 48869 RVA: 0x00B048D8 File Offset: 0x00B02AD8
		internal bool CnvSysGeneralQc2CallFormat_A42230_HiddenStatic
		{
			get
			{
				short num = (short)676263745;
				short num2 = num;
				num = (short)410056513;
				switch (num2 == num)
				{
				}
				num = (short)1325793280;
				short num3 = num;
				num = (short)898695169;
				if (num != 0)
				{
				}
				num = (short)17301504;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2CallFormat_A42230.HiddenStatic;
			}
			set
			{
				short num = (short)286130177;
				if (num != 0)
				{
				}
				num = (short)1018266680;
				short num2 = num;
				num = (short)1371767864;
				switch (num2 == num)
				{
				default:
				{
					num = (short)630063104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1637548032;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2CallFormat_A42230.HiddenStatic = value;
			}
		}

		// Token: 0x17005FD6 RID: 24534
		// (get) Token: 0x0600BEE6 RID: 48870 RVA: 0x00B0498C File Offset: 0x00B02B8C
		// (set) Token: 0x0600BEE7 RID: 48871 RVA: 0x00B04A40 File Offset: 0x00B02C40
		internal bool CnvSysGeneralQc2CallFormat_A42230_HiddenDynamic
		{
			get
			{
				short num = (short)1409179715;
				short num2 = num;
				num = (short)2125881411;
				switch (num2 == num)
				{
				}
				num = (short)1628962816;
				short num3 = num;
				num = (short)1683619840;
				if (num != 0)
				{
				}
				num = (short)652935169;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2CallFormat_A42230.HiddenDynamic;
			}
			set
			{
				short num = (short)1390870529;
				if (num != 0)
				{
				}
				num = (short)1164399670;
				short num2 = num;
				num = (short)1009800246;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2120417280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1638006784;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2CallFormat_A42230.HiddenDynamic = value;
			}
		}

		// Token: 0x17005FD7 RID: 24535
		// (get) Token: 0x0600BEE8 RID: 48872 RVA: 0x00B04AF8 File Offset: 0x00B02CF8
		public bool CnvSysGeneralQc2CallFormat_A42230_HasDiffs
		{
			get
			{
				short num = (short)246973346;
				short num2 = num;
				num = (short)1850377122;
				switch (num2 == num)
				{
				}
				num = (short)1430781952;
				short num3 = num;
				num = (short)1175912449;
				if (num != 0)
				{
				}
				num = (short)2110717952;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2CallFormat_A42230._HasDiffs;
			}
		}

		// Token: 0x0600BEE9 RID: 48873 RVA: 0x00B04BAC File Offset: 0x00B02DAC
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
					return result;
				case 1:
				{
					num2 = (short)386072576;
					short num3 = num2;
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)76677120;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)1968373764;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num2 = (short)133556146;
					short num4 = num2;
					num2 = (short)1485039538;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)343867393;
						if (num2 != 0)
						{
						}
						num2 = (short)1018494976;
						if (num2 != 0)
						{
						}
						num2 = (short)1664483329;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					num2 = (short)1947533315;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)393281538;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04005C36 RID: 23606
		private global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerRecset innerRecset;

		// Token: 0x04005C37 RID: 23607
		private global::AcpBusinessLayer.AcpField<bool> cnvSysQCIIDecode;

		// Token: 0x04005C38 RID: 23608
		private global::AcpBusinessLayer.AcpListField cnvSysGeneralQc2CallFormat_A42230;
	}
}
