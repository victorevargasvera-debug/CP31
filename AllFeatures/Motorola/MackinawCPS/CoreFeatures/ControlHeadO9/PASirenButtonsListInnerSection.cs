using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x0200037D RID: 893
	[global::System.Serializable]
	public class PASirenButtonsListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060083CF RID: 33743 RVA: 0x007A83D8 File Offset: 0x007A65D8
		public PASirenButtonsListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060083D0 RID: 33744 RVA: 0x007A83F4 File Offset: 0x007A65F4
		protected PASirenButtonsListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060083D1 RID: 33745 RVA: 0x007A840C File Offset: 0x007A660C
		public override void Init()
		{
			int a_ = 10;
			short num = (short)1453522944;
			short num2 = num;
			num = (short)1198452685;
			short num3 = num;
			num = (short)1756229581;
			switch (num3 == num)
			{
			}
			num = (short)384499713;
			if (num != 0)
			{
			}
			num = (short)2017591296;
			if (num != 0)
			{
			}
			this.cHO9PASirenButtonsName_A41537 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_SIRENAIRHORN, this, global::AllFeatures.CodeplugGuid.b("裊藌胎菒铔蓖냘꧚룜뇞ꏠ離釤鏦蛨藪黬ꇮ郰黲郴ꣶ룸쿺쳼쫾㈀㐂", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.cHO9PASirenButtonsName_A41537.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cHO9PASirenButtonsName_A41537.DataTransferOrder = -1;
			this.cHO9PASirenButtonsBCO_A41538 = new global::AcpBusinessLayer.AcpSparseLOVField(117, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexCHO9PASirenButtonsBCO_A41538LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idCHO9PASirenButtonsBCO_A41538LovStrs), this, global::AllFeatures.CodeplugGuid.b("裊藌胎菒铔蓖냘꧚룜뇞ꏠ離釤鏦蛨藪黬귮닰볲ꫴ뛶췸쫺주쳾㤀", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.CHO9PASirenButtonsBCO_A41538LovStrs);
			this.cHO9PASirenButtonsBCO_A41538.IgnoreOnCompare = true;
			this.cHO9PASirenButtonsBCO_A41538.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cHO9PASirenButtonsBCO_A41538.DataTransferOrder = -1;
			this.cHO9PASirenButtonsFeature_A41540 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexCHO9PASirenButtonsFeature_A41540LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idCHO9PASirenButtonsFeature_A41540LovStrs), this, global::AllFeatures.CodeplugGuid.b("裊藌胎菒铔蓖냘꧚룜뇞ꏠ離釤鏦蛨藪黬ꧮ铰鋲致苶诸黺ꋼ뻾㔀㈂〄㌆㤈", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.CHO9PASirenButtonsFeature_A41540LovStrs);
			this.cHO9PASirenButtonsFeature_A41540.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cHO9PASirenButtonsFeature_A41540.DataTransferOrder = 21;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鯊賌ﻐ蛔뻖ꯘ뻚돜￞ꏠ離釤鏦蛨藪黬", a_);
			base.Id = 10744;
			base.UIName = global::CommonResources.AcgResources.ID_PASIRENBUTTONS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060083D2 RID: 33746 RVA: 0x007A85D8 File Offset: 0x007A67D8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)1453916162;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诇苉菋胏鏑蟓뿕꫗뿙닛鳝闟雡郣觥蛧駩ꋫ迭鷯韱꯳럵쳷쯹짻췽㟿", a_)))
					{
						num = (short)1065549831;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_123;
				case 1:
					this.cHO9PASirenButtonsBCO_A41538 = new global::AcpBusinessLayer.AcpSparseLOVField(117, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexCHO9PASirenButtonsBCO_A41538LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idCHO9PASirenButtonsBCO_A41538LovStrs), this, global::AllFeatures.CodeplugGuid.b("诇苉菋胏鏑蟓뿕꫗뿙닛鳝闟雡郣觥蛧駩껫귭뿯귱뗳싵짷쿹쿻웽", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.CHO9PASirenButtonsBCO_A41538LovStrs);
					this.cHO9PASirenButtonsBCO_A41538.IgnoreOnCompare = true;
					this.cHO9PASirenButtonsBCO_A41538.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cHO9PASirenButtonsBCO_A41538.DataTransferOrder = -1;
					num = (short)1837826054;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 3:
					if (producerFields != null)
					{
						num = (short)2081095692;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37A;
				case 4:
				{
					num = (short)267583488;
					short num3 = num;
					num = (short)1132724227;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诇苉菋胏鏑蟓뿕꫗뿙닛鳝闟雡郣觥蛧駩껫귭뿯귱뗳싵짷쿹쿻웽", a_)))
					{
						num = (short)647823361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AC;
				case 6:
					goto IL_2AC;
				case 7:
					this.cHO9PASirenButtonsName_A41537 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_SIRENAIRHORN, this, global::AllFeatures.CodeplugGuid.b("诇苉菋胏鏑蟓뿕꫗뿙닛鳝闟雡郣觥蛧駩ꋫ迭鷯韱꯳럵쳷쯹짻췽㟿", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.cHO9PASirenButtonsName_A41537.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cHO9PASirenButtonsName_A41537.DataTransferOrder = -1;
					num = (short)670760970;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_26E;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诇苉菋胏鏑蟓뿕꫗뿙닛鳝闟雡郣觥蛧駩ꫫ语釯蛱至蓵鷷ꗹ뷻쫽ㇿ㜁〃㘅", a_)))
					{
						num = (short)756219915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37A;
				case 10:
					goto IL_123;
				case 11:
					num = (short)26869761;
					if (num != 0)
					{
					}
					for (;;)
					{
						this.cHO9PASirenButtonsFeature_A41540 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexCHO9PASirenButtonsFeature_A41540LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idCHO9PASirenButtonsFeature_A41540LovStrs), this, global::AllFeatures.CodeplugGuid.b("诇苉菋胏鏑蟓뿕꫗뿙닛鳝闟雡郣觥蛧駩ꫫ语釯蛱至蓵鷷ꗹ뷻쫽ㇿ㜁〃㘅", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.CHO9PASirenButtonsFeature_A41540LovStrs);
						this.cHO9PASirenButtonsFeature_A41540.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.cHO9PASirenButtonsFeature_A41540.DataTransferOrder = 21;
						num = (short)1652658309;
						short num4 = num;
						num = (short)123703429;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_23F;
						}
					}
					IL_23F:
					num = (short)1034223616;
					if (num != 0)
					{
					}
					num = (short)845676552;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					num = (short)854196224;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_61:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1436680196;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_123:
				num = (short)2001076229;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2AC:
				num = (short)348848137;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_26E:
			IL_37A:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("飇诉臑뷓ꓕ뷗듙ﳛ鳝闟雡郣觥蛧駩", a_);
			base.Id = 10744;
			base.UIName = global::CommonResources.AcgResources.ID_PASIRENBUTTONS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060083D3 RID: 33747 RVA: 0x007A8990 File Offset: 0x007A6B90
		public override void PopulateReferences()
		{
			short num = (short)561971200;
			short num2 = num;
			num = (short)1014104065;
			if (num != 0)
			{
			}
			num = (short)426950619;
			short num3 = num;
			num = (short)297517019;
			switch (num3 == num)
			{
			}
			num = (short)72744960;
			if (num != 0)
			{
			}
		}

		// Token: 0x060083D4 RID: 33748 RVA: 0x007A8A3C File Offset: 0x007A6C3C
		public override void DropReferences()
		{
			short num = (short)112590848;
			short num2 = num;
			num = (short)1235352218;
			short num3 = num;
			num = (short)1706752666;
			switch (num3 == num)
			{
			}
			num = (short)1820262400;
			if (num != 0)
			{
			}
			num = (short)1327169537;
			if (num != 0)
			{
			}
		}

		// Token: 0x060083D5 RID: 33749 RVA: 0x007A8AE8 File Offset: 0x007A6CE8
		public override void SetConstraints()
		{
			short num = (short)1746206720;
			short num2 = num;
			num = (short)1831389810;
			short num3 = num;
			num = (short)128698994;
			switch (num3 == num)
			{
			}
			num = (short)109117441;
			if (num != 0)
			{
			}
			num = (short)479920128;
			if (num != 0)
			{
			}
			this.cHO9PASirenButtonsName_A41537.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.cHO9PASirenButtonsFeature_A41540.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConStandaloneRadioSystemEnableApp);
			this.cHO9PASirenButtonsFeature_A41540.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConPASirenFeatureIsValid);
			this.cHO9PASirenButtonsFeature_A41540.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConStandaloneRadioSystemEnableEditable);
			this.cHO9PASirenButtonsFeature_A41540.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConSynSirenPAtoShepherd);
		}

		// Token: 0x060083D6 RID: 33750 RVA: 0x007A8C08 File Offset: 0x007A6E08
		public override void SetupDependencies()
		{
			short num = (short)975306752;
			short num2 = num;
			num = (short)1881936062;
			short num3 = num;
			num = (short)1611862206;
			switch (num3 == num)
			{
			}
			num = (short)800718849;
			if (num != 0)
			{
			}
			num = (short)1329070080;
			if (num != 0)
			{
			}
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.cHO9PASirenButtonsFeature_A41540);
			this.RefRadioErgonomicsWide.PASiren.RadErgoWidePASirenSirenOperation_A9139.AddDependentObject(this.cHO9PASirenButtonsFeature_A41540);
			this.RefRadioErgonomicsWide.PASiren.RadErgoWidePASirenHiLoAirhornTones_A8200.AddDependentObject(this.cHO9PASirenButtonsFeature_A41540);
		}

		// Token: 0x1700431A RID: 17178
		// (get) Token: 0x060083D7 RID: 33751 RVA: 0x007A8D04 File Offset: 0x007A6F04
		public bool HasDiffs
		{
			get
			{
				short num = (short)1451032576;
				short num2 = num;
				num = (short)1358145796;
				short num3 = num;
				num = (short)1221110020;
				switch (num3 == num)
				{
				}
				num = (short)1856962561;
				if (num != 0)
				{
				}
				num = (short)1720909824;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700431B RID: 17179
		// (get) Token: 0x060083D8 RID: 33752 RVA: 0x007A8DB8 File Offset: 0x007A6FB8
		// (set) Token: 0x060083D9 RID: 33753 RVA: 0x007A8E6C File Offset: 0x007A706C
		public string CHO9PASirenButtonsName_A41537Value
		{
			get
			{
				short num = (short)1138425856;
				short num2 = num;
				num = (short)1195974039;
				short num3 = num;
				num = (short)1484594583;
				switch (num3 == num)
				{
				}
				num = (short)2115567617;
				if (num != 0)
				{
				}
				num = (short)594739200;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsName_A41537.Value;
			}
			set
			{
				short num = (short)52428800;
				short num2 = num;
				num = (short)16274870;
				short num3 = num;
				num = (short)1116951990;
				switch (num3 == num)
				{
				}
				num = (short)1465319425;
				if (num != 0)
				{
				}
				num = (short)587399168;
				if (num != 0)
				{
				}
				this.cHO9PASirenButtonsName_A41537.Value = value;
			}
		}

		// Token: 0x1700431C RID: 17180
		// (get) Token: 0x060083DA RID: 33754 RVA: 0x007A8F20 File Offset: 0x007A7120
		public global::AcpBusinessLayer.AcpField<string> CHO9PASirenButtonsName_A41537
		{
			get
			{
				short num = (short)1836187648;
				short num2 = num;
				num = (short)439182573;
				short num3 = num;
				num = (short)1573283053;
				switch (num3 == num)
				{
				}
				num = (short)157417472;
				if (num != 0)
				{
				}
				num = (short)1965424641;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsName_A41537;
			}
		}

		// Token: 0x1700431D RID: 17181
		// (get) Token: 0x060083DB RID: 33755 RVA: 0x007A8FCC File Offset: 0x007A71CC
		// (set) Token: 0x060083DC RID: 33756 RVA: 0x007A9084 File Offset: 0x007A7284
		public string CHO9PASirenButtonsName_A41537_UIValue
		{
			get
			{
				short num = (short)1626406912;
				short num2 = num;
				num = (short)2039110109;
				short num3 = num;
				num = (short)965106141;
				switch (num3 == num)
				{
				}
				num = (short)48300033;
				if (num != 0)
				{
				}
				num = (short)337641472;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsName_A41537.Value;
			}
			set
			{
				short num = (short)761397248;
				short num2 = num;
				num = (short)285321779;
				short num3 = num;
				num = (short)1118939699;
				switch (num3 == num)
				{
				}
				num = (short)2146172929;
				if (num != 0)
				{
				}
				num = (short)1132789760;
				if (num != 0)
				{
				}
				this.cHO9PASirenButtonsName_A41537.Value = value;
			}
		}

		// Token: 0x1700431E RID: 17182
		// (get) Token: 0x060083DD RID: 33757 RVA: 0x007A9138 File Offset: 0x007A7338
		// (set) Token: 0x060083DE RID: 33758 RVA: 0x007A91EC File Offset: 0x007A73EC
		public bool CHO9PASirenButtonsName_A41537_Applicable
		{
			get
			{
				short num = (short)1790377984;
				short num2 = num;
				num = (short)1626811657;
				short num3 = num;
				num = (short)568339721;
				switch (num3 == num)
				{
				}
				num = (short)22347776;
				if (num != 0)
				{
				}
				num = (short)606011393;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsName_A41537.Applicable;
			}
			set
			{
				short num = (short)896270336;
				short num2 = num;
				num = (short)1044250625;
				if (num != 0)
				{
				}
				num = (short)1460720141;
				short num3 = num;
				num = (short)1314640397;
				switch (num3 == num)
				{
				}
				num = (short)267845632;
				if (num != 0)
				{
				}
				this.cHO9PASirenButtonsName_A41537.Applicable = value;
			}
		}

		// Token: 0x1700431F RID: 17183
		// (get) Token: 0x060083DF RID: 33759 RVA: 0x007A92A0 File Offset: 0x007A74A0
		// (set) Token: 0x060083E0 RID: 33760 RVA: 0x007A9358 File Offset: 0x007A7558
		public bool CHO9PASirenButtonsName_A41537_Valid
		{
			get
			{
				short num = (short)171900928;
				short num2 = num;
				num = (short)377421157;
				short num3 = num;
				num = (short)623246693;
				switch (num3 == num)
				{
				}
				num = (short)1563492352;
				if (num != 0)
				{
				}
				num = (short)825163777;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsName_A41537.Valid;
			}
			set
			{
				short num = (short)543031296;
				short num2 = num;
				num = (short)894719526;
				short num3 = num;
				num = (short)556029478;
				switch (num3 == num)
				{
				}
				num = (short)759169025;
				if (num != 0)
				{
				}
				num = (short)1787559936;
				if (num != 0)
				{
				}
				this.cHO9PASirenButtonsName_A41537.Valid = value;
			}
		}

		// Token: 0x17004320 RID: 17184
		// (get) Token: 0x060083E1 RID: 33761 RVA: 0x007A940C File Offset: 0x007A760C
		// (set) Token: 0x060083E2 RID: 33762 RVA: 0x007A94C4 File Offset: 0x007A76C4
		public bool CHO9PASirenButtonsName_A41537_Visible
		{
			get
			{
				short num = (short)977076224;
				short num2 = num;
				num = (short)1858017735;
				short num3 = num;
				num = (short)622860743;
				switch (num3 == num)
				{
				}
				num = (short)1899233281;
				if (num != 0)
				{
				}
				num = (short)930676736;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsName_A41537.Visible;
			}
			set
			{
				short num = (short)217710592;
				short num2 = num;
				num = (short)271059728;
				short num3 = num;
				num = (short)747375376;
				switch (num3 == num)
				{
				}
				num = (short)1577320448;
				if (num != 0)
				{
				}
				num = (short)1159659521;
				if (num != 0)
				{
				}
				this.cHO9PASirenButtonsName_A41537.Visible = value;
			}
		}

		// Token: 0x17004321 RID: 17185
		// (get) Token: 0x060083E3 RID: 33763 RVA: 0x007A9578 File Offset: 0x007A7778
		// (set) Token: 0x060083E4 RID: 33764 RVA: 0x007A962C File Offset: 0x007A782C
		public bool CHO9PASirenButtonsName_A41537_Editable
		{
			get
			{
				short num = (short)1234436096;
				short num2 = num;
				num = (short)29421994;
				short num3 = num;
				num = (short)160035242;
				switch (num3 == num)
				{
				}
				num = (short)1273561088;
				if (num != 0)
				{
				}
				num = (short)147718145;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsName_A41537.Editable;
			}
			set
			{
				short num = (short)754436188;
				short num2 = num;
				num = (short)1285343324;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1696661504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)781975552;
				if (num != 0)
				{
				}
				num = (short)1117847553;
				if (num != 0)
				{
				}
				this.cHO9PASirenButtonsName_A41537.Editable = value;
			}
		}

		// Token: 0x17004322 RID: 17186
		// (get) Token: 0x060083E5 RID: 33765 RVA: 0x007A96E0 File Offset: 0x007A78E0
		internal string CHO9PASirenButtonsName_A41537_UILabel
		{
			get
			{
				short num = (short)154144027;
				short num2 = num;
				num = (short)1081543963;
				switch (num2 == num)
				{
				default:
				{
					num = (short)915996672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)205586432;
				if (num != 0)
				{
				}
				num = (short)1587740673;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsName_A41537.UIName;
			}
		}

		// Token: 0x17004323 RID: 17187
		// (get) Token: 0x060083E6 RID: 33766 RVA: 0x007A9794 File Offset: 0x007A7994
		// (set) Token: 0x060083E7 RID: 33767 RVA: 0x007A9848 File Offset: 0x007A7A48
		internal bool CHO9PASirenButtonsName_A41537_HiddenStatic
		{
			get
			{
				short num = (short)1722348844;
				short num2 = num;
				num = (short)130938156;
				switch (num2 == num)
				{
				default:
				{
					num = (short)185204736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1269891072;
				if (num != 0)
				{
				}
				num = (short)46923777;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsName_A41537.HiddenStatic;
			}
			set
			{
				short num = (short)108462081;
				if (num != 0)
				{
				}
				num = (short)1926561792;
				short num2 = num;
				num = (short)1084524036;
				short num3 = num;
				num = (short)1437697540;
				switch (num3 == num)
				{
				}
				num = (short)69206016;
				if (num != 0)
				{
				}
				this.cHO9PASirenButtonsName_A41537.HiddenStatic = value;
			}
		}

		// Token: 0x17004324 RID: 17188
		// (get) Token: 0x060083E8 RID: 33768 RVA: 0x007A98FC File Offset: 0x007A7AFC
		// (set) Token: 0x060083E9 RID: 33769 RVA: 0x007A99B0 File Offset: 0x007A7BB0
		internal bool CHO9PASirenButtonsName_A41537_HiddenDynamic
		{
			get
			{
				short num = (short)1593049089;
				if (num != 0)
				{
				}
				num = (short)1924726784;
				short num2 = num;
				num = (short)908464300;
				short num3 = num;
				num = (short)1443958956;
				switch (num3 == num)
				{
				}
				num = (short)1803157504;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsName_A41537.HiddenDynamic;
			}
			set
			{
				short num = (short)610260207;
				short num2 = num;
				num = (short)1900401903;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1704198144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1625751553;
				if (num != 0)
				{
				}
				num = (short)305201152;
				if (num != 0)
				{
				}
				this.cHO9PASirenButtonsName_A41537.HiddenDynamic = value;
			}
		}

		// Token: 0x17004325 RID: 17189
		// (get) Token: 0x060083EA RID: 33770 RVA: 0x007A9A64 File Offset: 0x007A7C64
		public bool CHO9PASirenButtonsName_A41537_HasDiffs
		{
			get
			{
				short num = (short)1506242781;
				short num2 = num;
				num = (short)314667229;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1545076736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)717488129;
				if (num != 0)
				{
				}
				num = (short)1246363648;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsName_A41537._HasDiffs;
			}
		}

		// Token: 0x17004326 RID: 17190
		// (get) Token: 0x060083EB RID: 33771 RVA: 0x007A9B18 File Offset: 0x007A7D18
		// (set) Token: 0x060083EC RID: 33772 RVA: 0x007A9BD0 File Offset: 0x007A7DD0
		public int CHO9PASirenButtonsBCO_A41538Value
		{
			get
			{
				short num = (short)2003874153;
				short num2 = num;
				num = (short)1179627881;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1971781632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)5373953;
				if (num != 0)
				{
				}
				num = (short)1278869504;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsBCO_A41538.Value;
			}
			set
			{
				short num = (short)899208948;
				short num2 = num;
				num = (short)513136372;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1561395200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)814219264;
				if (num != 0)
				{
				}
				num = (short)980549633;
				if (num != 0)
				{
				}
				this.cHO9PASirenButtonsBCO_A41538.Value = value;
			}
		}

		// Token: 0x17004327 RID: 17191
		// (get) Token: 0x060083ED RID: 33773 RVA: 0x007A9C84 File Offset: 0x007A7E84
		// (set) Token: 0x060083EE RID: 33774 RVA: 0x007A9D3C File Offset: 0x007A7F3C
		public string CHO9PASirenButtonsBCO_A41538_UIValue
		{
			get
			{
				short num = (short)1119736849;
				short num2 = num;
				num = (short)1492767761;
				switch (num2 == num)
				{
				default:
				{
					num = (short)23658496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)35848193;
				if (num != 0)
				{
				}
				num = (short)1603665920;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsBCO_A41538.UIValue;
			}
			set
			{
				short num = (short)1214015619;
				short num2 = num;
				num = (short)622028931;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1851588608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1205207040;
				if (num != 0)
				{
				}
				num = (short)1712717825;
				if (num != 0)
				{
				}
				this.cHO9PASirenButtonsBCO_A41538.UIValue = value;
			}
		}

		// Token: 0x17004328 RID: 17192
		// (get) Token: 0x060083EF RID: 33775 RVA: 0x007A9DF0 File Offset: 0x007A7FF0
		public global::AcpBusinessLayer.AcpListField CHO9PASirenButtonsBCO_A41538
		{
			get
			{
				short num = (short)1968236971;
				short num2 = num;
				num = (short)1468721579;
				switch (num2 == num)
				{
				default:
				{
					num = (short)559480832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1268056065;
				if (num != 0)
				{
				}
				num = (short)1255079936;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsBCO_A41538;
			}
		}

		// Token: 0x17004329 RID: 17193
		// (get) Token: 0x060083F0 RID: 33776 RVA: 0x007A9EA0 File Offset: 0x007A80A0
		// (set) Token: 0x060083F1 RID: 33777 RVA: 0x007A9F58 File Offset: 0x007A8158
		public bool CHO9PASirenButtonsBCO_A41538_Applicable
		{
			get
			{
				short num = (short)514160257;
				short num2 = num;
				num = (short)967669377;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1086849024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)158924801;
				if (num != 0)
				{
				}
				num = (short)1211105280;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsBCO_A41538.Applicable;
			}
			set
			{
				short num = (short)356569579;
				short num2 = num;
				num = (short)1826935275;
				switch (num2 == num)
				{
				default:
				{
					num = (short)612761600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)148242432;
				if (num != 0)
				{
				}
				num = (short)2039808001;
				if (num != 0)
				{
				}
				this.cHO9PASirenButtonsBCO_A41538.Applicable = value;
			}
		}

		// Token: 0x1700432A RID: 17194
		// (get) Token: 0x060083F2 RID: 33778 RVA: 0x007AA010 File Offset: 0x007A8210
		// (set) Token: 0x060083F3 RID: 33779 RVA: 0x007AA0C8 File Offset: 0x007A82C8
		public bool CHO9PASirenButtonsBCO_A41538_Valid
		{
			get
			{
				short num = (short)674633768;
				short num2 = num;
				num = (short)2092767272;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1368981504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1361117185;
				if (num != 0)
				{
				}
				num = (short)124256256;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsBCO_A41538.Valid;
			}
			set
			{
				short num = (short)285480259;
				short num2 = num;
				num = (short)162534723;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1881931776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)125632512;
				if (num != 0)
				{
				}
				num = (short)1026424833;
				if (num != 0)
				{
				}
				this.cHO9PASirenButtonsBCO_A41538.Valid = value;
			}
		}

		// Token: 0x1700432B RID: 17195
		// (get) Token: 0x060083F4 RID: 33780 RVA: 0x007AA180 File Offset: 0x007A8380
		// (set) Token: 0x060083F5 RID: 33781 RVA: 0x007AA234 File Offset: 0x007A8434
		public bool CHO9PASirenButtonsBCO_A41538_Visible
		{
			get
			{
				short num = (short)167948943;
				short num2 = num;
				num = (short)702198415;
				switch (num2 == num)
				{
				default:
				{
					num = (short)206438400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)405405697;
				if (num != 0)
				{
				}
				num = (short)1505165312;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsBCO_A41538.Visible;
			}
			set
			{
				short num = (short)1177550849;
				if (num != 0)
				{
				}
				num = (short)1610416128;
				short num2 = num;
				num = (short)135865064;
				short num3 = num;
				num = (short)1976115944;
				switch (num3 == num)
				{
				}
				num = (short)891682816;
				if (num != 0)
				{
				}
				this.cHO9PASirenButtonsBCO_A41538.Visible = value;
			}
		}

		// Token: 0x1700432C RID: 17196
		// (get) Token: 0x060083F6 RID: 33782 RVA: 0x007AA2EC File Offset: 0x007A84EC
		// (set) Token: 0x060083F7 RID: 33783 RVA: 0x007AA3A0 File Offset: 0x007A85A0
		public bool CHO9PASirenButtonsBCO_A41538_Editable
		{
			get
			{
				short num = (short)1398587253;
				short num2 = num;
				num = (short)953466741;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1251213312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2127167489;
				if (num != 0)
				{
				}
				num = (short)423690240;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsBCO_A41538.Editable;
			}
			set
			{
				short num = (short)1187698544;
				short num2 = num;
				num = (short)750376816;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1745485824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1825767425;
				if (num != 0)
				{
				}
				num = (short)538181632;
				if (num != 0)
				{
				}
				this.cHO9PASirenButtonsBCO_A41538.Editable = value;
			}
		}

		// Token: 0x1700432D RID: 17197
		// (get) Token: 0x060083F8 RID: 33784 RVA: 0x007AA458 File Offset: 0x007A8658
		internal string CHO9PASirenButtonsBCO_A41538_UILabel
		{
			get
			{
				short num = (short)369379452;
				short num2 = num;
				num = (short)1176717436;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1796931584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1703215104;
				if (num != 0)
				{
				}
				num = (short)877723649;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsBCO_A41538.UIName;
			}
		}

		// Token: 0x1700432E RID: 17198
		// (get) Token: 0x060083F9 RID: 33785 RVA: 0x007AA510 File Offset: 0x007A8710
		// (set) Token: 0x060083FA RID: 33786 RVA: 0x007AA5C4 File Offset: 0x007A87C4
		internal bool CHO9PASirenButtonsBCO_A41538_HiddenStatic
		{
			get
			{
				short num = (short)625133167;
				short num2 = num;
				num = (short)265602671;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1701445632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)635568129;
				if (num != 0)
				{
				}
				num = (short)1327955968;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsBCO_A41538.HiddenStatic;
			}
			set
			{
				short num = (short)1742603846;
				short num2 = num;
				num = (short)1831011910;
				switch (num2 == num)
				{
				default:
				{
					num = (short)323485696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2018443265;
				if (num != 0)
				{
				}
				num = (short)64815104;
				if (num != 0)
				{
				}
				this.cHO9PASirenButtonsBCO_A41538.HiddenStatic = value;
			}
		}

		// Token: 0x1700432F RID: 17199
		// (get) Token: 0x060083FB RID: 33787 RVA: 0x007AA67C File Offset: 0x007A887C
		// (set) Token: 0x060083FC RID: 33788 RVA: 0x007AA72C File Offset: 0x007A892C
		internal bool CHO9PASirenButtonsBCO_A41538_HiddenDynamic
		{
			get
			{
				short num = (short)580564573;
				short num2 = num;
				num = (short)766096989;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2104688640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)826605568;
				if (num != 0)
				{
				}
				num = (short)1664090113;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsBCO_A41538.HiddenDynamic;
			}
			set
			{
				short num = (short)1403137715;
				short num2 = num;
				num = (short)1457008307;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1813970944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1164115969;
				if (num != 0)
				{
				}
				num = (short)1128267776;
				if (num != 0)
				{
				}
				this.cHO9PASirenButtonsBCO_A41538.HiddenDynamic = value;
			}
		}

		// Token: 0x17004330 RID: 17200
		// (get) Token: 0x060083FD RID: 33789 RVA: 0x007AA7E0 File Offset: 0x007A89E0
		public bool CHO9PASirenButtonsBCO_A41538_HasDiffs
		{
			get
			{
				short num = (short)100215828;
				short num2 = num;
				num = (short)1059269652;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1521221632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)477626369;
				if (num != 0)
				{
				}
				num = (short)534642688;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsBCO_A41538._HasDiffs;
			}
		}

		// Token: 0x17004331 RID: 17201
		// (get) Token: 0x060083FE RID: 33790 RVA: 0x007AA894 File Offset: 0x007A8A94
		// (set) Token: 0x060083FF RID: 33791 RVA: 0x007AA948 File Offset: 0x007A8B48
		public int CHO9PASirenButtonsFeature_A41540Value
		{
			get
			{
				short num = (short)194915337;
				short num2 = num;
				num = (short)824060937;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2028535808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2075197441;
				if (num != 0)
				{
				}
				num = (short)343670784;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsFeature_A41540.Value;
			}
			set
			{
				short num = (short)1186460834;
				short num2 = num;
				num = (short)203748514;
				switch (num2 == num)
				{
				default:
				{
					num = (short)489619456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)406061056;
				if (num != 0)
				{
				}
				num = (short)1246691329;
				if (num != 0)
				{
				}
				this.cHO9PASirenButtonsFeature_A41540.Value = value;
			}
		}

		// Token: 0x17004332 RID: 17202
		// (get) Token: 0x06008400 RID: 33792 RVA: 0x007AAA00 File Offset: 0x007A8C00
		// (set) Token: 0x06008401 RID: 33793 RVA: 0x007AAAB8 File Offset: 0x007A8CB8
		public string CHO9PASirenButtonsFeature_A41540_UIValue
		{
			get
			{
				short num = (short)470370278;
				short num2 = num;
				num = (short)297879526;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1356857344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1338769408;
				if (num != 0)
				{
				}
				num = (short)1937506305;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsFeature_A41540.UIValue;
			}
			set
			{
				short num = (short)1070904400;
				short num2 = num;
				num = (short)290960464;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1471152128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1995374592;
				if (num != 0)
				{
				}
				num = (short)846200833;
				if (num != 0)
				{
				}
				this.cHO9PASirenButtonsFeature_A41540.UIValue = value;
			}
		}

		// Token: 0x17004333 RID: 17203
		// (get) Token: 0x06008402 RID: 33794 RVA: 0x007AAB70 File Offset: 0x007A8D70
		public global::AcpBusinessLayer.AcpListField CHO9PASirenButtonsFeature_A41540
		{
			get
			{
				short num = (short)725757905;
				short num2 = num;
				num = (short)453783505;
				switch (num2 == num)
				{
				default:
				{
					num = (short)773193728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)430178304;
				if (num != 0)
				{
				}
				num = (short)192937985;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsFeature_A41540;
			}
		}

		// Token: 0x17004334 RID: 17204
		// (get) Token: 0x06008403 RID: 33795 RVA: 0x007AAC20 File Offset: 0x007A8E20
		// (set) Token: 0x06008404 RID: 33796 RVA: 0x007AACD4 File Offset: 0x007A8ED4
		public bool CHO9PASirenButtonsFeature_A41540_Applicable
		{
			get
			{
				short num = (short)1302173621;
				short num2 = num;
				num = (short)1599051701;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1238368256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1153695744;
				if (num != 0)
				{
				}
				num = (short)1995112449;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsFeature_A41540.Applicable;
			}
			set
			{
				short num = (short)360107377;
				short num2 = num;
				num = (short)1884212593;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1661206528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)758513665;
				if (num != 0)
				{
				}
				num = (short)2044657664;
				if (num != 0)
				{
				}
				this.cHO9PASirenButtonsFeature_A41540.Applicable = value;
			}
		}

		// Token: 0x17004335 RID: 17205
		// (get) Token: 0x06008405 RID: 33797 RVA: 0x007AAD8C File Offset: 0x007A8F8C
		// (set) Token: 0x06008406 RID: 33798 RVA: 0x007AAE40 File Offset: 0x007A9040
		public bool CHO9PASirenButtonsFeature_A41540_Valid
		{
			get
			{
				short num = (short)2072386407;
				short num2 = num;
				num = (short)1300765543;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1469513728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1719533569;
				if (num != 0)
				{
				}
				num = (short)1042284544;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsFeature_A41540.Valid;
			}
			set
			{
				short num = (short)1814488941;
				short num2 = num;
				num = (short)273934189;
				switch (num2 == num)
				{
				default:
				{
					num = (short)898891776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)394264576;
				if (num != 0)
				{
				}
				num = (short)911015937;
				if (num != 0)
				{
				}
				this.cHO9PASirenButtonsFeature_A41540.Valid = value;
			}
		}

		// Token: 0x17004336 RID: 17206
		// (get) Token: 0x06008407 RID: 33799 RVA: 0x007AAEF4 File Offset: 0x007A90F4
		// (set) Token: 0x06008408 RID: 33800 RVA: 0x007AAFA8 File Offset: 0x007A91A8
		public bool CHO9PASirenButtonsFeature_A41540_Visible
		{
			get
			{
				short num = (short)1819980002;
				short num2 = num;
				num = (short)518303970;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1076428800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1173094401;
				if (num != 0)
				{
				}
				num = (short)413597696;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsFeature_A41540.Visible;
			}
			set
			{
				short num = (short)1381628577;
				short num2 = num;
				num = (short)203225761;
				switch (num2 == num)
				{
				default:
				{
					num = (short)850788352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)455999489;
				if (num != 0)
				{
				}
				num = (short)779747328;
				if (num != 0)
				{
				}
				this.cHO9PASirenButtonsFeature_A41540.Visible = value;
			}
		}

		// Token: 0x17004337 RID: 17207
		// (get) Token: 0x06008409 RID: 33801 RVA: 0x007AB05C File Offset: 0x007A925C
		// (set) Token: 0x0600840A RID: 33802 RVA: 0x007AB110 File Offset: 0x007A9310
		public bool CHO9PASirenButtonsFeature_A41540_Editable
		{
			get
			{
				short num = (short)458361473;
				short num2 = num;
				num = (short)392759937;
				switch (num2 == num)
				{
				default:
				{
					num = (short)550895616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)790822912;
				if (num != 0)
				{
				}
				num = (short)1536884737;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsFeature_A41540.Editable;
			}
			set
			{
				short num = (short)2095230766;
				short num2 = num;
				num = (short)948743982;
				switch (num2 == num)
				{
				default:
				{
					num = (short)682557440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1865416704;
				if (num != 0)
				{
				}
				num = (short)1635844097;
				if (num != 0)
				{
				}
				this.cHO9PASirenButtonsFeature_A41540.Editable = value;
			}
		}

		// Token: 0x17004338 RID: 17208
		// (get) Token: 0x0600840B RID: 33803 RVA: 0x007AB1C4 File Offset: 0x007A93C4
		internal string CHO9PASirenButtonsFeature_A41540_UILabel
		{
			get
			{
				short num = (short)2036868522;
				short num2 = num;
				num = (short)690824618;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2143485952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)265158657;
				if (num != 0)
				{
				}
				num = (short)1689911296;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsFeature_A41540.UIName;
			}
		}

		// Token: 0x17004339 RID: 17209
		// (get) Token: 0x0600840C RID: 33804 RVA: 0x007AB278 File Offset: 0x007A9478
		// (set) Token: 0x0600840D RID: 33805 RVA: 0x007AB330 File Offset: 0x007A9530
		internal bool CHO9PASirenButtonsFeature_A41540_HiddenStatic
		{
			get
			{
				short num = (short)532306324;
				short num2 = num;
				num = (short)312564116;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1440677888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)761397248;
				if (num != 0)
				{
				}
				num = (short)645922817;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsFeature_A41540.HiddenStatic;
			}
			set
			{
				short num = (short)547422209;
				if (num != 0)
				{
				}
				num = (short)391905280;
				short num2 = num;
				num = (short)1934516052;
				short num3 = num;
				num = (short)1275748180;
				switch (num3 == num)
				{
				}
				num = (short)1815805952;
				if (num != 0)
				{
				}
				this.cHO9PASirenButtonsFeature_A41540.HiddenStatic = value;
			}
		}

		// Token: 0x1700433A RID: 17210
		// (get) Token: 0x0600840E RID: 33806 RVA: 0x007AB3E4 File Offset: 0x007A95E4
		// (set) Token: 0x0600840F RID: 33807 RVA: 0x007AB498 File Offset: 0x007A9698
		internal bool CHO9PASirenButtonsFeature_A41540_HiddenDynamic
		{
			get
			{
				short num = (short)1530057231;
				short num2 = num;
				num = (short)1507840527;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1977745408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1096417281;
				if (num != 0)
				{
				}
				num = (short)2089943040;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsFeature_A41540.HiddenDynamic;
			}
			set
			{
				short num = (short)402409862;
				short num2 = num;
				num = (short)1250707846;
				switch (num2 == num)
				{
				default:
				{
					num = (short)244121600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)770965504;
				if (num != 0)
				{
				}
				num = (short)1850474497;
				if (num != 0)
				{
				}
				this.cHO9PASirenButtonsFeature_A41540.HiddenDynamic = value;
			}
		}

		// Token: 0x1700433B RID: 17211
		// (get) Token: 0x06008410 RID: 33808 RVA: 0x007AB550 File Offset: 0x007A9750
		public bool CHO9PASirenButtonsFeature_A41540_HasDiffs
		{
			get
			{
				short num = (short)377023794;
				short num2 = num;
				num = (short)496037170;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1085079552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)358678528;
				if (num != 0)
				{
				}
				num = (short)1364066305;
				if (num != 0)
				{
				}
				return this.cHO9PASirenButtonsFeature_A41540._HasDiffs;
			}
		}

		// Token: 0x1700433C RID: 17212
		// (get) Token: 0x06008411 RID: 33809 RVA: 0x007AB604 File Offset: 0x007A9804
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)842989569;
				if (num != 0)
				{
				}
				num = (short)1021247488;
				short num2 = num;
				num = (short)3373890;
				short num3 = num;
				num = (short)1330150210;
				switch (num3 == num)
				{
				}
				num = (short)1448935424;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x1700433D RID: 17213
		// (get) Token: 0x06008412 RID: 33810 RVA: 0x007AB6C0 File Offset: 0x007A98C0
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide RefRadioErgonomicsWide
		{
			get
			{
				short num = (short)706805761;
				if (num != 0)
				{
				}
				num = (short)1306656768;
				short num2 = num;
				num = (short)2120934235;
				short num3 = num;
				num = (short)1265427291;
				switch (num3 == num)
				{
				}
				num = (short)768475136;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			}
		}

		// Token: 0x06008413 RID: 33811 RVA: 0x007AB780 File Offset: 0x007A9980
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
					num2 = (short)520028161;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1562247168;
						short num3 = num2;
						num2 = (short)1749549058;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)661192707;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return result;
				case 4:
					goto IL_85;
				}
				goto IL_24;
			}
			IL_85:
			num2 = (short)422838273;
			if (num2 != 0)
			{
			}
			if (base.ParentRecset != null)
			{
				goto IL_B7;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1101256776;
			short num4 = num2;
			num2 = (short)1398069320;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_B7:
				num2 = (short)681836544;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)895746048;
				if (num2 != 0)
				{
				}
				num2 = (short)575930372;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x04003E67 RID: 15975
		private global::AcpBusinessLayer.AcpField<string> cHO9PASirenButtonsName_A41537;

		// Token: 0x04003E68 RID: 15976
		private global::AcpBusinessLayer.AcpListField cHO9PASirenButtonsBCO_A41538;

		// Token: 0x04003E69 RID: 15977
		private global::AcpBusinessLayer.AcpListField cHO9PASirenButtonsFeature_A41540;
	}
}
