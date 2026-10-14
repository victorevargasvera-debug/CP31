using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x0200016F RID: 367
	[global::System.Serializable]
	public class FCCNarrowBandingFrequencySplitInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06002FD9 RID: 12249 RVA: 0x002EDAF8 File Offset: 0x002EBCF8
		public FCCNarrowBandingFrequencySplitInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06002FDA RID: 12250 RVA: 0x002EDB14 File Offset: 0x002EBD14
		protected FCCNarrowBandingFrequencySplitInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06002FDB RID: 12251 RVA: 0x002EDB2C File Offset: 0x002EBD2C
		public override void Init()
		{
			int a_ = 10;
			short num = (short)1610416128;
			short num2 = num;
			num = (short)1878622644;
			short num3 = num;
			num = (short)1397981620;
			switch (num3 == num)
			{
			}
			num = (short)450822145;
			if (num != 0)
			{
			}
			num = (short)1488257024;
			if (num != 0)
			{
			}
			this.radWideLabtoolFCCNarrowBandStartFrequency_A38270 = new global::AcpBusinessLayer.AcpFrequencyField(0, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖闘뫚뿜ꯞ軠賢觤ꇦꫨ꣪ꏬ軮菰臲髴胶미髺鏼鯾刀眂搄甆紈䴊缌樎怐昒瀔礖稘戚䈜帞ሠᬢᜤဦᤨ", a_), global::CommonResources.AcgResources.ID_STARTFREQUENCYSPLITMHZ, 0, int.MaxValue, 1);
			this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.DataTransferOrder = -1;
			this.radWideLabtoolFCCNarrowBandEndFrequency_A38271 = new global::AcpBusinessLayer.AcpFrequencyField(0, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖闘뫚뿜ꯞ軠賢觤ꇦꫨ꣪ꏬ軮菰臲髴胶미髺鏼鯾䐀洂愄䄆笈渊簌税琐紒瘔渖䘘娚⸜✞ጠᐢᐤ", a_), global::CommonResources.AcgResources.ID_ENDFREQUENCYSPLITMHZ, 0, int.MaxValue, 1);
			this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("跊軌賎鷒듔ꗖꯘ듚ꫜ￞ꏠ苢诤菦胨藪諬쿮런臲郴蛶賸黺鏼鳾砀⌂嘄眆攈戊礌", a_);
			base.Id = 10635;
			base.UIName = global::CommonResources.AcgResources.ID_FCCNARROWBANDINGFREQUENCYSPLIT;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06002FDC RID: 12252 RVA: 0x002EDC90 File Offset: 0x002EBE90
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 2;
			short num = (short)496041987;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1991966721;
					if (num != 0)
					{
					}
					num = (short)871170048;
					short num3 = num;
					num = (short)2004287495;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					this.radWideLabtoolFCCNarrowBandStartFrequency_A38270 = new global::AcpBusinessLayer.AcpFrequencyField(0, this, global::AllFeatures.CodeplugGuid.b("釂꓄ꏆ黈ꋊ꧌꫎鷐닒럔ꏖ뛘듚뇜駞ꋠꃢꯤ蛦鯨駪苬飮돰鋲鯴鏶꫸迺鳼跾甀䔂眄戆砈縊栌愎爐樒䨔嘖⨘⌚⼜⠞ᄠ", a_), global::CommonResources.AcgResources.ID_STARTFREQUENCYSPLITMHZ);
					this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.DataTransferOrder = -1;
					num = (short)783286276;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1448920120;
					short num4 = num;
					num = (short)1846264888;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)595329024;
						if (num != 0)
						{
						}
						this.radWideLabtoolFCCNarrowBandEndFrequency_A38271 = new global::AcpBusinessLayer.AcpFrequencyField(0, this, global::AllFeatures.CodeplugGuid.b("釂꓄ꏆ黈ꋊ꧌꫎鷐닒럔ꏖ뛘듚뇜駞ꋠꃢꯤ蛦鯨駪苬飮돰鋲鯴鏶본闺駼맾猀昂琄爆氈攊渌瘎丐划☔⼖⬘ⰚⰜ", a_), global::CommonResources.AcgResources.ID_ENDFREQUENCYSPLITMHZ);
						this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
						this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.DataTransferOrder = -1;
						num = (short)948895750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 4:
					goto IL_9F;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釂꓄ꏆ黈ꋊ꧌꫎鷐닒럔ꏖ뛘듚뇜駞ꋠꃢꯤ蛦鯨駪苬飮돰鋲鯴鏶꫸迺鳼跾甀䔂眄戆砈縊栌愎爐樒䨔嘖⨘⌚⼜⠞ᄠ", a_)))
					{
						num = (short)388628481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9F;
				case 6:
					goto IL_240;
				case 7:
					if (producerFields != null)
					{
						num = (short)575602697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_28E;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釂꓄ꏆ黈ꋊ꧌꫎鷐닒럔ꏖ뛘듚뇜駞ꋠꃢꯤ蛦鯨駪苬飮돰鋲鯴鏶본闺駼맾猀昂琄爆氈攊渌瘎丐划☔⼖⬘ⰚⰜ", a_)))
					{
						num = (short)1725497346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_28E;
				case 9:
					num = (short)1285554181;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_56:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)173146112;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9F:
				num = (short)1913651208;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_240:
			IL_28E:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("藂蛄蓆藊곌뷎ꏐ볒ꋔ鯘뫚돜믞裠跢苤쟦꿨駪裬黮蓰雲鯴银胸\udbfa껼迾洀樂焄", a_);
			base.Id = 10635;
			base.UIName = global::CommonResources.AcgResources.ID_FCCNARROWBANDINGFREQUENCYSPLIT;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x002EDF5C File Offset: 0x002EC15C
		public override void PopulateReferences()
		{
			short num = (short)1651585103;
			short num2 = num;
			num = (short)1266233423;
			switch (num2 == num)
			{
			default:
			{
				num = (short)697958400;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)478871552;
			if (num != 0)
			{
			}
			num = (short)1597112321;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002FDE RID: 12254 RVA: 0x002EE008 File Offset: 0x002EC208
		public override void DropReferences()
		{
			short num = (short)682598126;
			short num2 = num;
			num = (short)1809620718;
			switch (num2 == num)
			{
			default:
			{
				num = (short)226754560;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)817889281;
			if (num != 0)
			{
			}
			num = (short)194183168;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002FDF RID: 12255 RVA: 0x002EE0B0 File Offset: 0x002EC2B0
		public override void SetConstraints()
		{
			short num = (short)1419733825;
			short num2 = num;
			num = (short)1660513089;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2050818048;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1769865217;
			if (num != 0)
			{
			}
			num = (short)93782016;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002FE0 RID: 12256 RVA: 0x002EE158 File Offset: 0x002EC358
		public override void SetupDependencies()
		{
			short num = (short)260255847;
			short num2 = num;
			num = (short)741355623;
			switch (num2 == num)
			{
			default:
			{
				num = (short)758317056;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)47448065;
			if (num != 0)
			{
			}
			num = (short)1218314240;
			if (num != 0)
			{
			}
		}

		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x06002FE1 RID: 12257 RVA: 0x002EE204 File Offset: 0x002EC404
		public bool HasDiffs
		{
			get
			{
				short num = (short)1226570830;
				short num2 = num;
				num = (short)139066446;
				switch (num2 == num)
				{
				default:
				{
					num = (short)81592320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)755236865;
				if (num != 0)
				{
				}
				num = (short)458424320;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170017E7 RID: 6119
		// (get) Token: 0x06002FE2 RID: 12258 RVA: 0x002EE2B4 File Offset: 0x002EC4B4
		// (set) Token: 0x06002FE3 RID: 12259 RVA: 0x002EE370 File Offset: 0x002EC570
		public int RadWideLabtoolFCCNarrowBandStartFrequency_A38270Value
		{
			get
			{
				short num = (short)72253290;
				short num2 = num;
				num = (short)2077458282;
				switch (num2 == num)
				{
				default:
				{
					num = (short)59834368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)53739521;
				if (num != 0)
				{
				}
				num = (short)1197408256;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.Value;
			}
			set
			{
				short num = (short)370207980;
				short num2 = num;
				num = (short)2091707628;
				switch (num2 == num)
				{
				default:
				{
					num = (short)95944704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)110493697;
				if (num != 0)
				{
				}
				num = (short)851181568;
				if (num != 0)
				{
				}
				this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.Value = value;
			}
		}

		// Token: 0x170017E8 RID: 6120
		// (get) Token: 0x06002FE4 RID: 12260 RVA: 0x002EE428 File Offset: 0x002EC628
		// (set) Token: 0x06002FE5 RID: 12261 RVA: 0x002EE4E0 File Offset: 0x002EC6E0
		public string RadWideLabtoolFCCNarrowBandStartFrequency_A38270_UIValue
		{
			get
			{
				short num = (short)241947894;
				short num2 = num;
				num = (short)961402102;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1813708800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)452788225;
				if (num != 0)
				{
				}
				num = (short)185466880;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.UIValue;
			}
			set
			{
				short num = (short)1615623357;
				short num2 = num;
				num = (short)321156285;
				switch (num2 == num)
				{
				default:
				{
					num = (short)804651008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)851378176;
				if (num != 0)
				{
				}
				num = (short)1086783489;
				if (num != 0)
				{
				}
				this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.UIValue = value;
			}
		}

		// Token: 0x170017E9 RID: 6121
		// (get) Token: 0x06002FE6 RID: 12262 RVA: 0x002EE594 File Offset: 0x002EC794
		public global::AcpBusinessLayer.AcpFrequencyField RadWideLabtoolFCCNarrowBandStartFrequency_A38270
		{
			get
			{
				short num = (short)1123856684;
				short num2 = num;
				num = (short)1011593516;
				switch (num2 == num)
				{
				default:
				{
					num = (short)712572928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1738604545;
				if (num != 0)
				{
				}
				num = (short)1845493760;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandStartFrequency_A38270;
			}
		}

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x06002FE7 RID: 12263 RVA: 0x002EE644 File Offset: 0x002EC844
		// (set) Token: 0x06002FE8 RID: 12264 RVA: 0x002EE6F8 File Offset: 0x002EC8F8
		internal int RadWideLabtoolFCCNarrowBandStartFrequency_A38270Min
		{
			get
			{
				short num = (short)62023342;
				short num2 = num;
				num = (short)297952942;
				switch (num2 == num)
				{
				default:
				{
					num = (short)7536640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1328545792;
				if (num != 0)
				{
				}
				num = (short)60620801;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.Min;
			}
			set
			{
				short num = (short)1516863944;
				short num2 = num;
				num = (short)447971784;
				switch (num2 == num)
				{
				default:
				{
					num = (short)686948352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1841102849;
				if (num != 0)
				{
				}
				num = (short)1769013248;
				if (num != 0)
				{
				}
				this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.Min = value;
			}
		}

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x06002FE9 RID: 12265 RVA: 0x002EE7B0 File Offset: 0x002EC9B0
		// (set) Token: 0x06002FEA RID: 12266 RVA: 0x002EE860 File Offset: 0x002ECA60
		internal int RadWideLabtoolFCCNarrowBandStartFrequency_A38270Max
		{
			get
			{
				short num = (short)843867782;
				short num2 = num;
				num = (short)778856070;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1638793216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1608253441;
				if (num != 0)
				{
				}
				num = (short)29294592;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.Max;
			}
			set
			{
				short num = (short)612478274;
				short num2 = num;
				num = (short)600616258;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1952317440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1992228864;
				if (num != 0)
				{
				}
				num = (short)574423041;
				if (num != 0)
				{
				}
				this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.Max = value;
			}
		}

		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x06002FEB RID: 12267 RVA: 0x002EE918 File Offset: 0x002ECB18
		// (set) Token: 0x06002FEC RID: 12268 RVA: 0x002EE9CC File Offset: 0x002ECBCC
		internal int RadWideLabtoolFCCNarrowBandStartFrequency_A38270Step
		{
			get
			{
				short num = (short)720000712;
				short num2 = num;
				num = (short)1859344072;
				switch (num2 == num)
				{
				default:
				{
					num = (short)448790528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2141454336;
				if (num != 0)
				{
				}
				num = (short)2040004609;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.StepSize;
			}
			set
			{
				short num = (short)1977752554;
				short num2 = num;
				num = (short)1531780074;
				switch (num2 == num)
				{
				default:
				{
					num = (short)697892864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)773652481;
				if (num != 0)
				{
				}
				num = (short)330629120;
				if (num != 0)
				{
				}
				this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.StepSize = value;
			}
		}

		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x06002FED RID: 12269 RVA: 0x002EEA80 File Offset: 0x002ECC80
		// (set) Token: 0x06002FEE RID: 12270 RVA: 0x002EEB34 File Offset: 0x002ECD34
		public bool RadWideLabtoolFCCNarrowBandStartFrequency_A38270_Applicable
		{
			get
			{
				short num = (short)2069663295;
				short num2 = num;
				num = (short)1205767743;
				switch (num2 == num)
				{
				default:
				{
					num = (short)398852096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1358233600;
				if (num != 0)
				{
				}
				num = (short)2003828737;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.Applicable;
			}
			set
			{
				short num = (short)1707278337;
				if (num != 0)
				{
				}
				num = (short)1593311232;
				short num2 = num;
				num = (short)2136558249;
				short num3 = num;
				num = (short)2009090729;
				switch (num3 == num)
				{
				}
				num = (short)60030976;
				if (num != 0)
				{
				}
				this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.Applicable = value;
			}
		}

		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x06002FEF RID: 12271 RVA: 0x002EEBE8 File Offset: 0x002ECDE8
		// (set) Token: 0x06002FF0 RID: 12272 RVA: 0x002EEC9C File Offset: 0x002ECE9C
		public bool RadWideLabtoolFCCNarrowBandStartFrequency_A38270_Valid
		{
			get
			{
				short num = (short)769987032;
				short num2 = num;
				num = (short)1202196952;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1306591232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)626786304;
				if (num != 0)
				{
				}
				num = (short)1333592065;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.Valid;
			}
			set
			{
				short num = (short)1321798947;
				short num2 = num;
				num = (short)556207395;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1586298880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1253048321;
				if (num != 0)
				{
				}
				num = (short)1751252992;
				if (num != 0)
				{
				}
				this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.Valid = value;
			}
		}

		// Token: 0x170017EF RID: 6127
		// (get) Token: 0x06002FF1 RID: 12273 RVA: 0x002EED50 File Offset: 0x002ECF50
		// (set) Token: 0x06002FF2 RID: 12274 RVA: 0x002EEE00 File Offset: 0x002ED000
		public bool RadWideLabtoolFCCNarrowBandStartFrequency_A38270_Visible
		{
			get
			{
				short num = (short)755271;
				short num2 = num;
				num = (short)367691335;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1167851520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1706885121;
				if (num != 0)
				{
				}
				num = (short)41418752;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.Visible;
			}
			set
			{
				short num = (short)1798755517;
				short num2 = num;
				num = (short)22860989;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2061959168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1642528769;
				if (num != 0)
				{
				}
				num = (short)655425536;
				if (num != 0)
				{
				}
				this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.Visible = value;
			}
		}

		// Token: 0x170017F0 RID: 6128
		// (get) Token: 0x06002FF3 RID: 12275 RVA: 0x002EEEB4 File Offset: 0x002ED0B4
		// (set) Token: 0x06002FF4 RID: 12276 RVA: 0x002EEF68 File Offset: 0x002ED168
		public bool RadWideLabtoolFCCNarrowBandStartFrequency_A38270_Editable
		{
			get
			{
				short num = (short)193623546;
				short num2 = num;
				num = (short)1413576186;
				switch (num2 == num)
				{
				default:
				{
					num = (short)345440256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1911226368;
				if (num != 0)
				{
				}
				num = (short)1886453761;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.Editable;
			}
			set
			{
				short num = (short)1919600829;
				short num2 = num;
				num = (short)564578493;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1581842432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)159121409;
				if (num != 0)
				{
				}
				num = (short)1261699072;
				if (num != 0)
				{
				}
				this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.Editable = value;
			}
		}

		// Token: 0x170017F1 RID: 6129
		// (get) Token: 0x06002FF5 RID: 12277 RVA: 0x002EF020 File Offset: 0x002ED220
		internal string RadWideLabtoolFCCNarrowBandStartFrequency_A38270_UILabel
		{
			get
			{
				short num = (short)1031645739;
				short num2 = num;
				num = (short)915647019;
				switch (num2 == num)
				{
				default:
				{
					num = (short)888602624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)904986625;
				if (num != 0)
				{
				}
				num = (short)502267904;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.UIName;
			}
		}

		// Token: 0x170017F2 RID: 6130
		// (get) Token: 0x06002FF6 RID: 12278 RVA: 0x002EF0D8 File Offset: 0x002ED2D8
		// (set) Token: 0x06002FF7 RID: 12279 RVA: 0x002EF190 File Offset: 0x002ED390
		internal bool RadWideLabtoolFCCNarrowBandStartFrequency_A38270_HiddenStatic
		{
			get
			{
				short num = (short)1718051669;
				short num2 = num;
				num = (short)580805461;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2144731136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)966262785;
				if (num != 0)
				{
				}
				num = (short)1367670784;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.HiddenStatic;
			}
			set
			{
				short num = (short)1382350849;
				if (num != 0)
				{
				}
				num = (short)483459072;
				short num2 = num;
				num = (short)1904984423;
				short num3 = num;
				num = (short)1314701671;
				switch (num3 == num)
				{
				}
				num = (short)615710720;
				if (num != 0)
				{
				}
				this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.HiddenStatic = value;
			}
		}

		// Token: 0x170017F3 RID: 6131
		// (get) Token: 0x06002FF8 RID: 12280 RVA: 0x002EF248 File Offset: 0x002ED448
		// (set) Token: 0x06002FF9 RID: 12281 RVA: 0x002EF2FC File Offset: 0x002ED4FC
		internal bool RadWideLabtoolFCCNarrowBandStartFrequency_A38270_HiddenDynamic
		{
			get
			{
				short num = (short)1781049695;
				short num2 = num;
				num = (short)874490207;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1030356992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2139291649;
				if (num != 0)
				{
				}
				num = (short)1931804672;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.HiddenDynamic;
			}
			set
			{
				short num = (short)253407852;
				short num2 = num;
				num = (short)1651290732;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1486553088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1120010241;
				if (num != 0)
				{
				}
				num = (short)1431240704;
				if (num != 0)
				{
				}
				this.radWideLabtoolFCCNarrowBandStartFrequency_A38270.HiddenDynamic = value;
			}
		}

		// Token: 0x170017F4 RID: 6132
		// (get) Token: 0x06002FFA RID: 12282 RVA: 0x002EF3B0 File Offset: 0x002ED5B0
		public bool RadWideLabtoolFCCNarrowBandStartFrequency_A38270_HasDiffs
		{
			get
			{
				short num = (short)1553445442;
				short num2 = num;
				num = (short)2006430274;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1283588096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2135228417;
				if (num != 0)
				{
				}
				num = (short)189136896;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandStartFrequency_A38270._HasDiffs;
			}
		}

		// Token: 0x170017F5 RID: 6133
		// (get) Token: 0x06002FFB RID: 12283 RVA: 0x002EF460 File Offset: 0x002ED660
		// (set) Token: 0x06002FFC RID: 12284 RVA: 0x002EF514 File Offset: 0x002ED714
		public int RadWideLabtoolFCCNarrowBandEndFrequency_A38271Value
		{
			get
			{
				short num = (short)412569355;
				short num2 = num;
				num = (short)1704218379;
				switch (num2 == num)
				{
				default:
				{
					num = (short)481099776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)552075265;
				if (num != 0)
				{
				}
				num = (short)657850368;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.Value;
			}
			set
			{
				short num = (short)796107055;
				short num2 = num;
				num = (short)987734319;
				switch (num2 == num)
				{
				default:
				{
					num = (short)150339584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)29491201;
				if (num != 0)
				{
				}
				num = (short)785842176;
				if (num != 0)
				{
				}
				this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.Value = value;
			}
		}

		// Token: 0x170017F6 RID: 6134
		// (get) Token: 0x06002FFD RID: 12285 RVA: 0x002EF5CC File Offset: 0x002ED7CC
		// (set) Token: 0x06002FFE RID: 12286 RVA: 0x002EF67C File Offset: 0x002ED87C
		public string RadWideLabtoolFCCNarrowBandEndFrequency_A38271_UIValue
		{
			get
			{
				short num = (short)1299613986;
				short num2 = num;
				num = (short)922913058;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1534656512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2129592320;
				if (num != 0)
				{
				}
				num = (short)1268645889;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.UIValue;
			}
			set
			{
				short num = (short)877310244;
				short num2 = num;
				num = (short)162443556;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1665990656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)310247425;
				if (num != 0)
				{
				}
				num = (short)645398528;
				if (num != 0)
				{
				}
				this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.UIValue = value;
			}
		}

		// Token: 0x170017F7 RID: 6135
		// (get) Token: 0x06002FFF RID: 12287 RVA: 0x002EF734 File Offset: 0x002ED934
		public global::AcpBusinessLayer.AcpFrequencyField RadWideLabtoolFCCNarrowBandEndFrequency_A38271
		{
			get
			{
				short num = (short)1476654848;
				short num2 = num;
				num = (short)724629248;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2131361792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)338362369;
				if (num != 0)
				{
				}
				num = (short)111673344;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandEndFrequency_A38271;
			}
		}

		// Token: 0x170017F8 RID: 6136
		// (get) Token: 0x06003000 RID: 12288 RVA: 0x002EF7E4 File Offset: 0x002ED9E4
		// (set) Token: 0x06003001 RID: 12289 RVA: 0x002EF898 File Offset: 0x002EDA98
		internal int RadWideLabtoolFCCNarrowBandEndFrequency_A38271Min
		{
			get
			{
				short num = (short)876544001;
				if (num != 0)
				{
				}
				num = (short)1893007360;
				short num2 = num;
				num = (short)1135658012;
				short num3 = num;
				num = (short)171623452;
				switch (num3 == num)
				{
				}
				num = (short)2134441984;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.Min;
			}
			set
			{
				short num = (short)613107663;
				short num2 = num;
				num = (short)73222095;
				switch (num2 == num)
				{
				default:
				{
					num = (short)790953984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)815005697;
				if (num != 0)
				{
				}
				num = (short)471400448;
				if (num != 0)
				{
				}
				this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.Min = value;
			}
		}

		// Token: 0x170017F9 RID: 6137
		// (get) Token: 0x06003002 RID: 12290 RVA: 0x002EF950 File Offset: 0x002EDB50
		// (set) Token: 0x06003003 RID: 12291 RVA: 0x002EFA04 File Offset: 0x002EDC04
		internal int RadWideLabtoolFCCNarrowBandEndFrequency_A38271Max
		{
			get
			{
				short num = (short)774655511;
				short num2 = num;
				num = (short)2040745495;
				switch (num2 == num)
				{
				default:
				{
					num = (short)192479232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)388759553;
				if (num != 0)
				{
				}
				num = (short)1437466624;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.Max;
			}
			set
			{
				short num = (short)576698654;
				short num2 = num;
				num = (short)1674098974;
				switch (num2 == num)
				{
				default:
				{
					num = (short)19464192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1815871489;
				if (num != 0)
				{
				}
				num = (short)1230372864;
				if (num != 0)
				{
				}
				this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.Max = value;
			}
		}

		// Token: 0x170017FA RID: 6138
		// (get) Token: 0x06003004 RID: 12292 RVA: 0x002EFABC File Offset: 0x002EDCBC
		// (set) Token: 0x06003005 RID: 12293 RVA: 0x002EFB70 File Offset: 0x002EDD70
		internal int RadWideLabtoolFCCNarrowBandEndFrequency_A38271Step
		{
			get
			{
				short num = (short)2006258424;
				short num2 = num;
				num = (short)1933382392;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1908211712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)521928704;
				if (num != 0)
				{
				}
				num = (short)1792475137;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.StepSize;
			}
			set
			{
				short num = (short)281611990;
				short num2 = num;
				num = (short)856821462;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2143420416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1094778881;
				if (num != 0)
				{
				}
				num = (short)90505216;
				if (num != 0)
				{
				}
				this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.StepSize = value;
			}
		}

		// Token: 0x170017FB RID: 6139
		// (get) Token: 0x06003006 RID: 12294 RVA: 0x002EFC28 File Offset: 0x002EDE28
		// (set) Token: 0x06003007 RID: 12295 RVA: 0x002EFCDC File Offset: 0x002EDEDC
		public bool RadWideLabtoolFCCNarrowBandEndFrequency_A38271_Applicable
		{
			get
			{
				short num = (short)1839754940;
				short num2 = num;
				num = (short)478637756;
				switch (num2 == num)
				{
				default:
				{
					num = (short)692125696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2081423361;
				if (num != 0)
				{
				}
				num = (short)1388773376;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.Applicable;
			}
			set
			{
				short num = (short)455336816;
				short num2 = num;
				num = (short)487842672;
				switch (num2 == num)
				{
				default:
				{
					num = (short)529137664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2045247488;
				if (num != 0)
				{
				}
				num = (short)1668677633;
				if (num != 0)
				{
				}
				this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.Applicable = value;
			}
		}

		// Token: 0x170017FC RID: 6140
		// (get) Token: 0x06003008 RID: 12296 RVA: 0x002EFD94 File Offset: 0x002EDF94
		// (set) Token: 0x06003009 RID: 12297 RVA: 0x002EFE48 File Offset: 0x002EE048
		public bool RadWideLabtoolFCCNarrowBandEndFrequency_A38271_Valid
		{
			get
			{
				short num = (short)1377567088;
				short num2 = num;
				num = (short)1433207152;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1550319616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)945750016;
				if (num != 0)
				{
				}
				num = (short)2052259841;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.Valid;
			}
			set
			{
				short num = (short)1163968917;
				short num2 = num;
				num = (short)786874773;
				switch (num2 == num)
				{
				default:
				{
					num = (short)448200704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1262878720;
				if (num != 0)
				{
				}
				num = (short)1632305153;
				if (num != 0)
				{
				}
				this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.Valid = value;
			}
		}

		// Token: 0x170017FD RID: 6141
		// (get) Token: 0x0600300A RID: 12298 RVA: 0x002EFEFC File Offset: 0x002EE0FC
		// (set) Token: 0x0600300B RID: 12299 RVA: 0x002EFFB0 File Offset: 0x002EE1B0
		public bool RadWideLabtoolFCCNarrowBandEndFrequency_A38271_Visible
		{
			get
			{
				short num = (short)300941313;
				if (num != 0)
				{
				}
				num = (short)1463746560;
				short num2 = num;
				num = (short)1938482941;
				short num3 = num;
				num = (short)153020157;
				switch (num3 == num)
				{
				}
				num = (short)1219559424;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.Visible;
			}
			set
			{
				short num = (short)956694529;
				if (num != 0)
				{
				}
				num = (short)2121990144;
				short num2 = num;
				num = (short)1749809108;
				short num3 = num;
				num = (short)1000667092;
				switch (num3 == num)
				{
				}
				num = (short)920518656;
				if (num != 0)
				{
				}
				this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.Visible = value;
			}
		}

		// Token: 0x170017FE RID: 6142
		// (get) Token: 0x0600300C RID: 12300 RVA: 0x002F0068 File Offset: 0x002EE268
		// (set) Token: 0x0600300D RID: 12301 RVA: 0x002F0120 File Offset: 0x002EE320
		public bool RadWideLabtoolFCCNarrowBandEndFrequency_A38271_Editable
		{
			get
			{
				short num = (short)1426878791;
				short num2 = num;
				num = (short)39088455;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1788084224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1485963265;
				if (num != 0)
				{
				}
				num = (short)1215889408;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.Editable;
			}
			set
			{
				short num = (short)1144379679;
				short num2 = num;
				num = (short)389077279;
				switch (num2 == num)
				{
				default:
				{
					num = (short)584581120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)198574081;
				if (num != 0)
				{
				}
				num = (short)532086784;
				if (num != 0)
				{
				}
				this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.Editable = value;
			}
		}

		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x0600300E RID: 12302 RVA: 0x002F01D8 File Offset: 0x002EE3D8
		internal string RadWideLabtoolFCCNarrowBandEndFrequency_A38271_UILabel
		{
			get
			{
				short num = (short)1796919353;
				short num2 = num;
				num = (short)1799606329;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1163329536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1199112193;
				if (num != 0)
				{
				}
				num = (short)1545338880;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.UIName;
			}
		}

		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x0600300F RID: 12303 RVA: 0x002F028C File Offset: 0x002EE48C
		// (set) Token: 0x06003010 RID: 12304 RVA: 0x002F0344 File Offset: 0x002EE544
		internal bool RadWideLabtoolFCCNarrowBandEndFrequency_A38271_HiddenStatic
		{
			get
			{
				short num = (short)1521063864;
				short num2 = num;
				num = (short)1516541880;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1547370496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)36765696;
				if (num != 0)
				{
				}
				num = (short)1832976385;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.HiddenStatic;
			}
			set
			{
				short num = (short)101722346;
				short num2 = num;
				num = (short)35334378;
				switch (num2 == num)
				{
				default:
				{
					num = (short)212729856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)322306049;
				if (num != 0)
				{
				}
				num = (short)409272320;
				if (num != 0)
				{
				}
				this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.HiddenStatic = value;
			}
		}

		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x06003011 RID: 12305 RVA: 0x002F03F8 File Offset: 0x002EE5F8
		// (set) Token: 0x06003012 RID: 12306 RVA: 0x002F04B0 File Offset: 0x002EE6B0
		internal bool RadWideLabtoolFCCNarrowBandEndFrequency_A38271_HiddenDynamic
		{
			get
			{
				short num = (short)2015542067;
				short num2 = num;
				num = (short)1575729971;
				switch (num2 == num)
				{
				default:
				{
					num = (short)454623232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)169345024;
				if (num != 0)
				{
				}
				num = (short)1284964353;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.HiddenDynamic;
			}
			set
			{
				short num = (short)2117104784;
				short num2 = num;
				num = (short)346125456;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1610678272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1526333441;
				if (num != 0)
				{
				}
				num = (short)1640693760;
				if (num != 0)
				{
				}
				this.radWideLabtoolFCCNarrowBandEndFrequency_A38271.HiddenDynamic = value;
			}
		}

		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x06003013 RID: 12307 RVA: 0x002F0568 File Offset: 0x002EE768
		public bool RadWideLabtoolFCCNarrowBandEndFrequency_A38271_HasDiffs
		{
			get
			{
				short num = (short)742931952;
				short num2 = num;
				num = (short)504511984;
				switch (num2 == num)
				{
				default:
				{
					num = (short)887619584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1420034049;
				if (num != 0)
				{
				}
				num = (short)1574109184;
				if (num != 0)
				{
				}
				return this.radWideLabtoolFCCNarrowBandEndFrequency_A38271._HasDiffs;
			}
		}

		// Token: 0x06003014 RID: 12308 RVA: 0x002F061C File Offset: 0x002EE81C
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
				{
					num2 = (short)1690000273;
					short num3 = num2;
					num2 = (short)2064866193;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3A;
					default:
						num2 = (short)1051918336;
						if (num2 != 0)
						{
						}
						num2 = (short)1897332739;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)139329536;
					short num4 = num2;
					num2 = (short)938147842;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_FA;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)2119696385;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					goto IL_3A;
				}
				goto IL_24;
				IL_3A:
				if (base.ParentRecset == null)
				{
					return result;
				}
				num2 = (short)165806080;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_FA:
			num2 = (short)340459521;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)832962564;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04001169 RID: 4457
		private global::AcpBusinessLayer.AcpFrequencyField radWideLabtoolFCCNarrowBandStartFrequency_A38270;

		// Token: 0x0400116A RID: 4458
		private global::AcpBusinessLayer.AcpFrequencyField radWideLabtoolFCCNarrowBandEndFrequency_A38271;
	}
}
