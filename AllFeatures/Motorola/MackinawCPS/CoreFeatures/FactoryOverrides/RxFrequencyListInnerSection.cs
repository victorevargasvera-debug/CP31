using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x02000455 RID: 1109
	[global::System.Serializable]
	public class RxFrequencyListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060093FD RID: 37885 RVA: 0x008B7358 File Offset: 0x008B5558
		public RxFrequencyListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060093FE RID: 37886 RVA: 0x008B7374 File Offset: 0x008B5574
		protected RxFrequencyListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060093FF RID: 37887 RVA: 0x008B738C File Offset: 0x008B558C
		public override void Init()
		{
			int a_ = 6;
			short num = (short)1332960329;
			short num2 = num;
			num = (short)2145737801;
			switch (num2 == num)
			{
			default:
			{
				num = (short)395902976;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1363214337;
			if (num != 0)
			{
			}
			num = (short)986578944;
			if (num != 0)
			{
			}
			this.fctOrdsRxFrequencyListRxFrequency = new global::AcpBusinessLayer.AcpFrequencyField(153800000, this, global::AllFeatures.CodeplugGuid.b("臆꫈뿊苌뷎뗐ꃒ蟔꿖鿘꧚룜껞铠蛢诤蓦部꟪蓬鳮藰ꇲ跴뇶诸黺購諾搀洂昄縆", a_), global::CommonResources.AcgResources.ID_RXFREQUENCYMHZ, 0, int.MaxValue, 1);
			this.fctOrdsRxFrequencyListRxFrequency.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.fctOrdsRxFrequencyListRxFrequency.DataTransferOrder = 11;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("闆뇈诌뷎듐ꋒꃔ닖럘룚ꓜ￞균諢雤鏦", a_);
			base.Id = 10906;
			base.UIName = global::CommonResources.AcgResources.ID_RXFREQUENCYLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06009400 RID: 37888 RVA: 0x008B74B4 File Offset: 0x008B56B4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 6;
			short num = (short)306970627;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1693319169;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臆꫈뿊苌뷎뗐ꃒ蟔꿖鿘꧚룜껞铠蛢诤蓦部꟪蓬鳮藰ꇲ跴뇶诸黺購諾搀洂昄縆", a_)))
					{
						num = (short)2107899906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D9;
				case 1:
					goto IL_15B;
				case 2:
				{
					this.fctOrdsRxFrequencyListRxFrequency = new global::AcpBusinessLayer.AcpFrequencyField(153800000, this, global::AllFeatures.CodeplugGuid.b("臆꫈뿊苌뷎뗐ꃒ蟔꿖鿘꧚룜껞铠蛢诤蓦部꟪蓬鳮藰ꇲ跴뇶诸黺購諾搀洂昄縆", a_), global::CommonResources.AcgResources.ID_RXFREQUENCYMHZ);
					this.fctOrdsRxFrequencyListRxFrequency.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.fctOrdsRxFrequencyListRxFrequency.DataTransferOrder = 11;
					num = (short)71199138;
					short num3 = num;
					num = (short)2144037282;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C0;
					default:
					{
						num = (short)362151936;
						short num4 = num;
						num = (short)545521664;
						if (num != 0)
						{
						}
						num = (short)472055809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_70;
					}
					continue;
				case 4:
					num = (short)2087518208;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields != null)
					{
						goto IL_1C0;
					}
					goto IL_1D9;
				case 6:
					num = (short)196804613;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_70:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)276889606;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1C0:
				num = (short)841547780;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_15B:
			IL_1D9:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("闆뇈诌뷎듐ꋒꃔ닖럘룚ꓜ￞균諢雤鏦", a_);
			base.Id = 10906;
			base.UIName = global::CommonResources.AcgResources.ID_RXFREQUENCYLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06009401 RID: 37889 RVA: 0x008B76CC File Offset: 0x008B58CC
		public override void PopulateReferences()
		{
			short num = (short)1385387865;
			short num2 = num;
			num = (short)853694297;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1645281280;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)362086401;
			if (num != 0)
			{
			}
			num = (short)1461649408;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009402 RID: 37890 RVA: 0x008B7778 File Offset: 0x008B5978
		public override void DropReferences()
		{
			short num = (short)617200437;
			short num2 = num;
			num = (short)2128853813;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1342177280;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1783365633;
			if (num != 0)
			{
			}
			num = (short)46792704;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009403 RID: 37891 RVA: 0x008B7820 File Offset: 0x008B5A20
		public override void SetConstraints()
		{
			short num = (short)336075828;
			short num2 = num;
			num = (short)1712921652;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2110062592;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1324023809;
			if (num != 0)
			{
			}
			num = (short)748093440;
			if (num != 0)
			{
			}
			this.fctOrdsRxFrequencyListRxFrequency.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverridesConstraints.ConFactoryOverridesEnableIsChecked);
			this.fctOrdsRxFrequencyListRxFrequency.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverridesConstraints.conFacOvrrdRxFrequencyIsValid);
		}

		// Token: 0x06009404 RID: 37892 RVA: 0x008B78F8 File Offset: 0x008B5AF8
		public override void SetupDependencies()
		{
			short num = (short)399088037;
			short num2 = num;
			num = (short)1309383077;
			switch (num2 == num)
			{
			default:
			{
				num = (short)652869632;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1401946113;
			if (num != 0)
			{
			}
			num = (short)442368000;
			if (num != 0)
			{
			}
			(base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverrides).General.RadWideAdvancedFactoryOverrides_A8004.AddDependentObject(this.fctOrdsRxFrequencyListRxFrequency);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.AddDependentObject(this.fctOrdsRxFrequencyListRxFrequency);
		}

		// Token: 0x17004A82 RID: 19074
		// (get) Token: 0x06009405 RID: 37893 RVA: 0x008B79E8 File Offset: 0x008B5BE8
		public bool HasDiffs
		{
			get
			{
				short num = (short)719978497;
				if (num != 0)
				{
				}
				num = (short)1329266688;
				short num2 = num;
				num = (short)2118016376;
				short num3 = num;
				num = (short)342646136;
				switch (num3 == num)
				{
				}
				num = (short)1489502208;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004A83 RID: 19075
		// (get) Token: 0x06009406 RID: 37894 RVA: 0x008B7A9C File Offset: 0x008B5C9C
		// (set) Token: 0x06009407 RID: 37895 RVA: 0x008B7B50 File Offset: 0x008B5D50
		public int FctOrdsRxFrequencyListRxFrequencyValue
		{
			get
			{
				short num = (short)682023857;
				short num2 = num;
				num = (short)2049039281;
				switch (num2 == num)
				{
				default:
				{
					num = (short)631832576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1806499840;
				if (num != 0)
				{
				}
				num = (short)2015297537;
				if (num != 0)
				{
				}
				return this.fctOrdsRxFrequencyListRxFrequency.Value;
			}
			set
			{
				short num = (short)621608961;
				if (num != 0)
				{
				}
				num = (short)1102315520;
				short num2 = num;
				num = (short)366586346;
				short num3 = num;
				num = (short)63810026;
				switch (num3 == num)
				{
				}
				num = (short)2050752512;
				if (num != 0)
				{
				}
				this.fctOrdsRxFrequencyListRxFrequency.Value = value;
			}
		}

		// Token: 0x17004A84 RID: 19076
		// (get) Token: 0x06009408 RID: 37896 RVA: 0x008B7C08 File Offset: 0x008B5E08
		// (set) Token: 0x06009409 RID: 37897 RVA: 0x008B7CBC File Offset: 0x008B5EBC
		public string FctOrdsRxFrequencyListRxFrequency_UIValue
		{
			get
			{
				short num = (short)837599540;
				short num2 = num;
				num = (short)367640884;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1769930752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)470810624;
				if (num != 0)
				{
				}
				num = (short)802095105;
				if (num != 0)
				{
				}
				return this.fctOrdsRxFrequencyListRxFrequency.UIValue;
			}
			set
			{
				short num = (short)190501106;
				short num2 = num;
				num = (short)601411826;
				switch (num2 == num)
				{
				default:
				{
					num = (short)946339840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1428357120;
				if (num != 0)
				{
				}
				num = (short)1133379585;
				if (num != 0)
				{
				}
				this.fctOrdsRxFrequencyListRxFrequency.UIValue = value;
			}
		}

		// Token: 0x17004A85 RID: 19077
		// (get) Token: 0x0600940A RID: 37898 RVA: 0x008B7D74 File Offset: 0x008B5F74
		public global::AcpBusinessLayer.AcpFrequencyField FctOrdsRxFrequencyListRxFrequency
		{
			get
			{
				short num = (short)1392902145;
				if (num != 0)
				{
				}
				num = (short)1723990016;
				short num2 = num;
				num = (short)593907125;
				short num3 = num;
				num = (short)564874677;
				switch (num3 == num)
				{
				}
				num = (short)1897398272;
				if (num != 0)
				{
				}
				return this.fctOrdsRxFrequencyListRxFrequency;
			}
		}

		// Token: 0x17004A86 RID: 19078
		// (get) Token: 0x0600940B RID: 37899 RVA: 0x008B7E24 File Offset: 0x008B6024
		// (set) Token: 0x0600940C RID: 37900 RVA: 0x008B7EDC File Offset: 0x008B60DC
		internal int FctOrdsRxFrequencyListRxFrequencyMin
		{
			get
			{
				short num = (short)1697175752;
				short num2 = num;
				num = (short)882956488;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2089156608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1915551745;
				if (num != 0)
				{
				}
				num = (short)1094582272;
				if (num != 0)
				{
				}
				return this.fctOrdsRxFrequencyListRxFrequency.Min;
			}
			set
			{
				short num = (short)917948875;
				short num2 = num;
				num = (short)610519499;
				switch (num2 == num)
				{
				default:
				{
					num = (short)286326784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)872218625;
				if (num != 0)
				{
				}
				num = (short)270073856;
				if (num != 0)
				{
				}
				this.fctOrdsRxFrequencyListRxFrequency.Min = value;
			}
		}

		// Token: 0x17004A87 RID: 19079
		// (get) Token: 0x0600940D RID: 37901 RVA: 0x008B7F94 File Offset: 0x008B6194
		// (set) Token: 0x0600940E RID: 37902 RVA: 0x008B8048 File Offset: 0x008B6248
		internal int FctOrdsRxFrequencyListRxFrequencyMax
		{
			get
			{
				short num = (short)1208906126;
				short num2 = num;
				num = (short)97481102;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1425473536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)723386369;
				if (num != 0)
				{
				}
				num = (short)1895038976;
				if (num != 0)
				{
				}
				return this.fctOrdsRxFrequencyListRxFrequency.Max;
			}
			set
			{
				short num = (short)422636352;
				short num2 = num;
				num = (short)2002971456;
				switch (num2 == num)
				{
				default:
				{
					num = (short)588513280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1713176577;
				if (num != 0)
				{
				}
				num = (short)506920960;
				if (num != 0)
				{
				}
				this.fctOrdsRxFrequencyListRxFrequency.Max = value;
			}
		}

		// Token: 0x17004A88 RID: 19080
		// (get) Token: 0x0600940F RID: 37903 RVA: 0x008B8100 File Offset: 0x008B6300
		// (set) Token: 0x06009410 RID: 37904 RVA: 0x008B81B4 File Offset: 0x008B63B4
		internal int FctOrdsRxFrequencyListRxFrequencyStep
		{
			get
			{
				short num = (short)171212733;
				short num2 = num;
				num = (short)939229117;
				switch (num2 == num)
				{
				default:
				{
					num = (short)23134208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)231800833;
				if (num != 0)
				{
				}
				num = (short)1836580864;
				if (num != 0)
				{
				}
				return this.fctOrdsRxFrequencyListRxFrequency.StepSize;
			}
			set
			{
				short num = (short)1980145107;
				short num2 = num;
				num = (short)1041079763;
				switch (num2 == num)
				{
				default:
				{
					num = (short)72024064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)335872001;
				if (num != 0)
				{
				}
				num = (short)353042432;
				if (num != 0)
				{
				}
				this.fctOrdsRxFrequencyListRxFrequency.StepSize = value;
			}
		}

		// Token: 0x17004A89 RID: 19081
		// (get) Token: 0x06009411 RID: 37905 RVA: 0x008B826C File Offset: 0x008B646C
		// (set) Token: 0x06009412 RID: 37906 RVA: 0x008B8320 File Offset: 0x008B6520
		public bool FctOrdsRxFrequencyListRxFrequency_Applicable
		{
			get
			{
				short num = (short)1829354502;
				short num2 = num;
				num = (short)2022423558;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2115436544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)280428545;
				if (num != 0)
				{
				}
				num = (short)1143341056;
				if (num != 0)
				{
				}
				return this.fctOrdsRxFrequencyListRxFrequency.Applicable;
			}
			set
			{
				short num = (short)913312026;
				short num2 = num;
				num = (short)404359450;
				switch (num2 == num)
				{
				default:
				{
					num = (short)70647808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)948305921;
				if (num != 0)
				{
				}
				num = (short)325976064;
				if (num != 0)
				{
				}
				this.fctOrdsRxFrequencyListRxFrequency.Applicable = value;
			}
		}

		// Token: 0x17004A8A RID: 19082
		// (get) Token: 0x06009413 RID: 37907 RVA: 0x008B83D4 File Offset: 0x008B65D4
		// (set) Token: 0x06009414 RID: 37908 RVA: 0x008B8488 File Offset: 0x008B6688
		public bool FctOrdsRxFrequencyListRxFrequency_Valid
		{
			get
			{
				short num = (short)1032474091;
				short num2 = num;
				num = (short)1835879915;
				switch (num2 == num)
				{
				default:
				{
					num = (short)825032704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)923926528;
				if (num != 0)
				{
				}
				num = (short)1708130305;
				if (num != 0)
				{
				}
				return this.fctOrdsRxFrequencyListRxFrequency.Valid;
			}
			set
			{
				short num = (short)1062680064;
				short num2 = num;
				num = (short)1468806656;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1387397120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1282080769;
				if (num != 0)
				{
				}
				num = (short)1114243072;
				if (num != 0)
				{
				}
				this.fctOrdsRxFrequencyListRxFrequency.Valid = value;
			}
		}

		// Token: 0x17004A8B RID: 19083
		// (get) Token: 0x06009415 RID: 37909 RVA: 0x008B853C File Offset: 0x008B673C
		// (set) Token: 0x06009416 RID: 37910 RVA: 0x008B85F0 File Offset: 0x008B67F0
		public bool FctOrdsRxFrequencyListRxFrequency_Visible
		{
			get
			{
				short num = (short)426442752;
				short num2 = num;
				num = (short)1421213697;
				if (num != 0)
				{
				}
				num = (short)2053587516;
				short num3 = num;
				num = (short)1012875836;
				switch (num3 == num)
				{
				}
				num = (short)659095552;
				if (num != 0)
				{
				}
				return this.fctOrdsRxFrequencyListRxFrequency.Visible;
			}
			set
			{
				short num = (short)824115200;
				short num2 = num;
				num = (short)517013177;
				short num3 = num;
				num = (short)1788346041;
				switch (num3 == num)
				{
				}
				num = (short)1435172864;
				if (num != 0)
				{
				}
				num = (short)776732673;
				if (num != 0)
				{
				}
				this.fctOrdsRxFrequencyListRxFrequency.Visible = value;
			}
		}

		// Token: 0x17004A8C RID: 19084
		// (get) Token: 0x06009417 RID: 37911 RVA: 0x008B86A4 File Offset: 0x008B68A4
		// (set) Token: 0x06009418 RID: 37912 RVA: 0x008B8758 File Offset: 0x008B6958
		public bool FctOrdsRxFrequencyListRxFrequency_Editable
		{
			get
			{
				short num = (short)1891303424;
				short num2 = num;
				num = (short)496616554;
				short num3 = num;
				num = (short)1912194154;
				switch (num3 == num)
				{
				}
				num = (short)440926208;
				if (num != 0)
				{
				}
				num = (short)2053636097;
				if (num != 0)
				{
				}
				return this.fctOrdsRxFrequencyListRxFrequency.Editable;
			}
			set
			{
				short num = (short)14811136;
				short num2 = num;
				num = (short)503963755;
				short num3 = num;
				num = (short)347398251;
				switch (num3 == num)
				{
				}
				num = (short)853082113;
				if (num != 0)
				{
				}
				num = (short)726859776;
				if (num != 0)
				{
				}
				this.fctOrdsRxFrequencyListRxFrequency.Editable = value;
			}
		}

		// Token: 0x17004A8D RID: 19085
		// (get) Token: 0x06009419 RID: 37913 RVA: 0x008B8810 File Offset: 0x008B6A10
		internal string FctOrdsRxFrequencyListRxFrequency_UILabel
		{
			get
			{
				short num = (short)1299120128;
				short num2 = num;
				num = (short)1701131222;
				short num3 = num;
				num = (short)1526608854;
				switch (num3 == num)
				{
				}
				num = (short)1712914433;
				if (num != 0)
				{
				}
				num = (short)1213661184;
				if (num != 0)
				{
				}
				return this.fctOrdsRxFrequencyListRxFrequency.UIName;
			}
		}

		// Token: 0x17004A8E RID: 19086
		// (get) Token: 0x0600941A RID: 37914 RVA: 0x008B88C4 File Offset: 0x008B6AC4
		// (set) Token: 0x0600941B RID: 37915 RVA: 0x008B897C File Offset: 0x008B6B7C
		internal bool FctOrdsRxFrequencyListRxFrequency_HiddenStatic
		{
			get
			{
				short num = (short)714604544;
				short num2 = num;
				num = (short)1036703874;
				short num3 = num;
				num = (short)960551042;
				switch (num3 == num)
				{
				}
				num = (short)1273167873;
				if (num != 0)
				{
				}
				num = (short)1405616128;
				if (num != 0)
				{
				}
				return this.fctOrdsRxFrequencyListRxFrequency.HiddenStatic;
			}
			set
			{
				short num = (short)1085014016;
				short num2 = num;
				num = (short)58209004;
				short num3 = num;
				num = (short)503984876;
				switch (num3 == num)
				{
				}
				num = (short)144769025;
				if (num != 0)
				{
				}
				num = (short)249757696;
				if (num != 0)
				{
				}
				this.fctOrdsRxFrequencyListRxFrequency.HiddenStatic = value;
			}
		}

		// Token: 0x17004A8F RID: 19087
		// (get) Token: 0x0600941C RID: 37916 RVA: 0x008B8A30 File Offset: 0x008B6C30
		// (set) Token: 0x0600941D RID: 37917 RVA: 0x008B8AE4 File Offset: 0x008B6CE4
		internal bool FctOrdsRxFrequencyListRxFrequency_HiddenDynamic
		{
			get
			{
				short num = (short)111542272;
				short num2 = num;
				num = (short)1906559927;
				short num3 = num;
				num = (short)423545783;
				switch (num3 == num)
				{
				}
				num = (short)620036096;
				if (num != 0)
				{
				}
				num = (short)923860993;
				if (num != 0)
				{
				}
				return this.fctOrdsRxFrequencyListRxFrequency.HiddenDynamic;
			}
			set
			{
				short num = (short)1528102912;
				short num2 = num;
				num = (short)495252784;
				short num3 = num;
				num = (short)228324656;
				switch (num3 == num)
				{
				}
				num = (short)362479617;
				if (num != 0)
				{
				}
				num = (short)607649792;
				if (num != 0)
				{
				}
				this.fctOrdsRxFrequencyListRxFrequency.HiddenDynamic = value;
			}
		}

		// Token: 0x17004A90 RID: 19088
		// (get) Token: 0x0600941E RID: 37918 RVA: 0x008B8B9C File Offset: 0x008B6D9C
		public bool FctOrdsRxFrequencyListRxFrequency_HasDiffs
		{
			get
			{
				short num = (short)2128871424;
				short num2 = num;
				num = (short)1941539166;
				short num3 = num;
				num = (short)1956809054;
				switch (num3 == num)
				{
				}
				num = (short)1569587200;
				if (num != 0)
				{
				}
				num = (short)506396673;
				if (num != 0)
				{
				}
				return this.fctOrdsRxFrequencyListRxFrequency._HasDiffs;
			}
		}

		// Token: 0x17004A91 RID: 19089
		// (get) Token: 0x0600941F RID: 37919 RVA: 0x008B8C54 File Offset: 0x008B6E54
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation RefRadioInformation
		{
			get
			{
				short num = (short)841285632;
				short num2 = num;
				num = (short)1336466820;
				short num3 = num;
				num = (short)786685316;
				switch (num3 == num)
				{
				}
				num = (short)636420097;
				if (num != 0)
				{
				}
				num = (short)1456078848;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			}
		}

		// Token: 0x06009420 RID: 37920 RVA: 0x008B8D14 File Offset: 0x008B6F14
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)1165492224;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_32:
				switch (num3)
				{
				case 0:
					if (base.ParentRecset != null)
					{
						num = (short)1748566018;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E7;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)1798963203;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E7;
				case 2:
					goto IL_AA;
				case 3:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1679949828;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_E7;
				}
				goto IL_4C;
				IL_AA:
				num = (short)1642266625;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_E7:
				num = (short)738195399;
				short num4 = num;
				num = (short)906819527;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AA;
				default:
					goto IL_11D;
				}
			}
			IL_11D:
			num = (short)1974206465;
			if (num != 0)
			{
			}
			num = (short)1649803264;
			if (num != 0)
			{
			}
			return result;
			IL_4C:
			result = null;
			num = (short)583008256;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x040049E3 RID: 18915
		private global::AcpBusinessLayer.AcpFrequencyField fctOrdsRxFrequencyListRxFrequency;
	}
}
