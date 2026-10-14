using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x020005C3 RID: 1475
	[global::System.Serializable]
	public class Labtool : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600C78D RID: 51085 RVA: 0x00BAAC84 File Offset: 0x00BA8E84
		public Labtool(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600C78E RID: 51086 RVA: 0x00BAACA0 File Offset: 0x00BA8EA0
		protected Labtool(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600C78F RID: 51087 RVA: 0x00BAACB8 File Offset: 0x00BA8EB8
		public override void Init()
		{
			int a_ = 10;
			short num = (short)725756536;
			short num2 = num;
			num = (short)1166027384;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1137377280;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)170393600;
			if (num != 0)
			{
			}
			num = (short)793772033;
			if (num != 0)
			{
			}
			this.conPerMDCRunMDCDemodulator_A8494 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("裊ꋌꇎ臐뛒꟔髖鷘飚远꫞迠껢ꇤꓦ귨軪胬胮闰蛲駴零跸铺迼ꃾ䀀㬂㄄㸆㴈", a_), global::CommonResources.AcgResources.ID_MDCRUNMDCDEMODULATOR);
			this.conPerMDCRunMDCDemodulator_A8494.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.conPerMDCRunMDCDemodulator_A8494.DataTransferOrder = -1;
			this.cnvPerLabtoolSyncMode_A19308 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많臐뛒꟔鯖룘맚꧜냞軠迢뛤黦蟨裪ꃬ胮闰雲ꫴ뛶죸싺컼쿾㤀", a_), global::CommonResources.AcgResources.ID_SYNCMODE);
			this.cnvPerLabtoolSyncMode_A19308.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cnvPerLabtoolSyncMode_A19308.DataTransferOrder = -1;
			this.cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많臐뛒꟔鯖룘맚꧜냞軠迢ꛤ裦蟨鷪裬臮藰髲髴駶飸韺근髾猀瀂樄椆栈朊搌笎栐倒純瘖眘甚砜猞渠匢儤並䘨䔪帬挮堰䀲䄴縶䴸帺值瘾Հ᱂ф畆祈罊穌筎", a_), global::CommonResources.AcgResources.ID_CONVENTIONALPERSONALITYCHANNELOPTIONSLISTITEMID, null, null, true, false);
			this.cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474.DataTransferOrder = -1;
			this.cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많臐뛒꟔鯖룘맚꧜냞軠迢ꛤ裦蟨鷪裬臮藰髲髴駶飸韺근髾猀瀂樄椆栈朊搌笎栐尒笔爖䴘琚栜簞䤠漢䰤否崨截夬䨮尰稲焴栶砸ऺ༼ा牀獂", a_), global::CommonResources.AcgResources.ID_CONVENTIONALPERSONALITYONETOUCHLISTITEMNAMEID, null, null, true, false);
			this.cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟊곌귎ꗐ볒뫔믖", a_);
			base.Id = 10134;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 15;
		}

		// Token: 0x0600C790 RID: 51088 RVA: 0x00BAAE80 File Offset: 0x00BA9080
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)1021050882;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)636181598;
				short num3 = num;
				num = (short)495803486;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)510132225;
					if (num != 0)
					{
					}
					num = (short)681443328;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_286;
					case 1:
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诇꓉뫋黍뗏ꃑ飓럕뫗껙돛뇝賟ꇡ诣裥黧迩苫髭駯鷱髳韵铷꫹駻賽珿洁樃朅搇按砋眍式簑焓䈕眗漙缛瘝氟䬡圣別愧帩䤫䌭礯瘱欳眵਷࠹਻ഽ瀿", a_)))
						{
							num = (short)188284931;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F5;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_DD;
						}
						continue;
					case 3:
						goto IL_247;
					case 4:
						if (producerFields != null)
						{
							num = (short)1943207951;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F5;
					case 5:
						this.cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("诇꓉뫋黍뗏ꃑ飓럕뫗껙돛뇝賟ꇡ诣裥黧迩苫髭駯鷱髳韵铷꫹駻賽珿洁樃朅搇按砋眍匏稑甓砕瘗缙瀛儝借嘡䴣䤥䘧天怫䜭䌯䘱紳䈵崷圹画稽Ἷ́癃癅籇絉硋", a_), global::CommonResources.AcgResources.ID_CONVENTIONALPERSONALITYCHANNELOPTIONSLISTITEMID, null, null, true, false);
						this.cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
						this.cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474.DataTransferOrder = -1;
						num = (short)312410125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						this.conPerMDCRunMDCDemodulator_A8494 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("诇ꗉꋋ黍뗏ꃑ駓鋕鯗裙꧛냝귟ꛡ꟣ꋥ跧蟩菫諭藯黱闳苵韷裹ꏻ뿽㣿㘁㴃㈅", a_), global::CommonResources.AcgResources.ID_MDCRUNMDCDEMODULATOR);
						this.conPerMDCRunMDCDemodulator_A8494.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
						this.conPerMDCRunMDCDemodulator_A8494.DataTransferOrder = -1;
						num = (short)876544010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_325;
					case 8:
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诇꓉뫋黍뗏ꃑ飓럕뫗껙돛뇝賟뇡鷣裥诧꟩菫諭闯귱뗳쟵쇷짹쳻웽", a_)))
						{
							num = (short)1148059657;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_286;
					case 9:
						this.cnvPerLabtoolSyncMode_A19308 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("诇꓉뫋黍뗏ꃑ飓럕뫗껙돛뇝賟뇡鷣裥诧꟩菫諭闯귱뗳쟵쇷짹쳻웽", a_), global::CommonResources.AcgResources.ID_SYNCMODE);
						this.cnvPerLabtoolSyncMode_A19308.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
						this.cnvPerLabtoolSyncMode_A19308.DataTransferOrder = -1;
						num = (short)1385627648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_32A;
					case 11:
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诇꓉뫋黍뗏ꃑ飓럕뫗껙돛뇝賟ꇡ诣裥黧迩苫髭駯鷱髳韵铷꫹駻賽珿洁樃朅搇按砋眍匏稑甓砕瘗缙瀛儝借嘡䴣䤥䘧天怫䜭䌯䘱紳䈵崷圹画稽Ἷ́癃癅籇絉硋", a_)))
						{
							num = (short)1934098437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FE;
					case 12:
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诇ꗉꋋ黍뗏ꃑ駓鋕鯗裙꧛냝귟ꛡ꟣ꋥ跧蟩菫諭藯黱闳苵韷裹ꏻ뿽㣿㘁㴃㈅", a_)))
						{
							num = (short)1617887238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32A;
					case 13:
						goto IL_1FE;
					case 14:
						num = (short)1418723332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)388366348;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_DD:
					if (global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						num = (short)102891534;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3F5;
					IL_1FE:
					num = (short)883359745;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_286:
					num = (short)1753350155;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32A:
					num = (short)1105068032;
					short num4 = num;
					num = (short)1199112200;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_247:
				this.cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("诇꓉뫋黍뗏ꃑ飓럕뫗껙돛뇝賟ꇡ诣裥黧迩苫髭駯鷱髳韵铷꫹駻賽珿洁樃朅搇按砋眍式簑焓䈕眗漙缛瘝氟䬡圣別愧帩䤫䌭礯瘱欳眵਷࠹਻ഽ瀿", a_), global::CommonResources.AcgResources.ID_CONVENTIONALPERSONALITYONETOUCHLISTITEMNAMEID, null, null, true, false);
				this.cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
				this.cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630.DataTransferOrder = -1;
				num = (short)166658055;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_325:
			IL_3F5:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蓇ꯉ껋뫍뿏뷑룓", a_);
			base.Id = 10134;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 15;
		}

		// Token: 0x0600C791 RID: 51089 RVA: 0x00BAB2B4 File Offset: 0x00BA94B4
		public override void PopulateReferences()
		{
			short num = (short)546875998;
			short num2 = num;
			num = (short)225487454;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1346109440;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1909587969;
			if (num != 0)
			{
			}
			num = (short)1018757120;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600C792 RID: 51090 RVA: 0x00BAB360 File Offset: 0x00BA9560
		public override void DropReferences()
		{
			short num = (short)104053146;
			short num2 = num;
			num = (short)610580890;
			switch (num2 == num)
			{
			default:
			{
				num = (short)557252608;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1880752128;
			if (num != 0)
			{
			}
			num = (short)1467940865;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600C793 RID: 51091 RVA: 0x00BAB408 File Offset: 0x00BA9608
		public override void SetConstraints()
		{
			short num = (short)390576771;
			short num2 = num;
			num = (short)1285667459;
			switch (num2 == num)
			{
			default:
			{
				num = (short)542834688;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1311899649;
			if (num != 0)
			{
			}
			num = (short)2066022400;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600C794 RID: 51092 RVA: 0x00BAB4B4 File Offset: 0x00BA96B4
		public override void SetupDependencies()
		{
			short num = (short)1708234609;
			short num2 = num;
			num = (short)2132449137;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2058616832;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)366280705;
			if (num != 0)
			{
			}
			num = (short)651755520;
			if (num != 0)
			{
			}
		}

		// Token: 0x17006412 RID: 25618
		// (get) Token: 0x0600C795 RID: 51093 RVA: 0x00BAB560 File Offset: 0x00BA9760
		public bool HasDiffs
		{
			get
			{
				short num = (short)1525113512;
				short num2 = num;
				num = (short)1616405160;
				switch (num2 == num)
				{
				default:
				{
					num = (short)744947712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1439170560;
				if (num != 0)
				{
				}
				num = (short)1615069185;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17006413 RID: 25619
		// (get) Token: 0x0600C796 RID: 51094 RVA: 0x00BAB610 File Offset: 0x00BA9810
		// (set) Token: 0x0600C797 RID: 51095 RVA: 0x00BAB6C4 File Offset: 0x00BA98C4
		public bool ConPerMDCRunMDCDemodulator_A8494Value
		{
			get
			{
				short num = (short)683737089;
				if (num != 0)
				{
				}
				num = (short)1192820736;
				short num2 = num;
				num = (short)1084841567;
				short num3 = num;
				num = (short)1439129183;
				switch (num3 == num)
				{
				}
				num = (short)207945728;
				if (num != 0)
				{
				}
				return this.conPerMDCRunMDCDemodulator_A8494.Value;
			}
			set
			{
				short num = (short)1904641498;
				short num2 = num;
				num = (short)778012122;
				switch (num2 == num)
				{
				default:
				{
					num = (short)878641152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)595197952;
				if (num != 0)
				{
				}
				num = (short)2076639233;
				if (num != 0)
				{
				}
				this.conPerMDCRunMDCDemodulator_A8494.Value = value;
			}
		}

		// Token: 0x17006414 RID: 25620
		// (get) Token: 0x0600C798 RID: 51096 RVA: 0x00BAB778 File Offset: 0x00BA9978
		public global::AcpBusinessLayer.AcpField<bool> ConPerMDCRunMDCDemodulator_A8494
		{
			get
			{
				short num = (short)522584065;
				if (num != 0)
				{
				}
				num = (short)194445312;
				short num2 = num;
				num = (short)711146222;
				short num3 = num;
				num = (short)630799086;
				switch (num3 == num)
				{
				}
				num = (short)1987510272;
				if (num != 0)
				{
				}
				return this.conPerMDCRunMDCDemodulator_A8494;
			}
		}

		// Token: 0x17006415 RID: 25621
		// (get) Token: 0x0600C799 RID: 51097 RVA: 0x00BAB828 File Offset: 0x00BA9A28
		// (set) Token: 0x0600C79A RID: 51098 RVA: 0x00BAB8DC File Offset: 0x00BA9ADC
		public bool ConPerMDCRunMDCDemodulator_A8494_UIValue
		{
			get
			{
				short num = (short)2100531140;
				short num2 = num;
				num = (short)84250564;
				switch (num2 == num)
				{
				default:
				{
					num = (short)88604672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1187250177;
				if (num != 0)
				{
				}
				num = (short)1841102848;
				if (num != 0)
				{
				}
				return this.conPerMDCRunMDCDemodulator_A8494.Value;
			}
			set
			{
				short num = (short)1568156157;
				short num2 = num;
				num = (short)1228351997;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1784676352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1521614849;
				if (num != 0)
				{
				}
				num = (short)1586626560;
				if (num != 0)
				{
				}
				this.conPerMDCRunMDCDemodulator_A8494.Value = value;
			}
		}

		// Token: 0x17006416 RID: 25622
		// (get) Token: 0x0600C79B RID: 51099 RVA: 0x00BAB990 File Offset: 0x00BA9B90
		// (set) Token: 0x0600C79C RID: 51100 RVA: 0x00BABA44 File Offset: 0x00BA9C44
		public bool ConPerMDCRunMDCDemodulator_A8494_Applicable
		{
			get
			{
				short num = (short)1887981160;
				short num2 = num;
				num = (short)926502504;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1961558016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)903479297;
				if (num != 0)
				{
				}
				num = (short)1702756352;
				if (num != 0)
				{
				}
				return this.conPerMDCRunMDCDemodulator_A8494.Applicable;
			}
			set
			{
				short num = (short)1010106369;
				if (num != 0)
				{
				}
				num = (short)819658752;
				short num2 = num;
				num = (short)29966307;
				short num3 = num;
				num = (short)1807237091;
				switch (num3 == num)
				{
				}
				num = (short)1796734976;
				if (num != 0)
				{
				}
				this.conPerMDCRunMDCDemodulator_A8494.Applicable = value;
			}
		}

		// Token: 0x17006417 RID: 25623
		// (get) Token: 0x0600C79D RID: 51101 RVA: 0x00BABAF8 File Offset: 0x00BA9CF8
		// (set) Token: 0x0600C79E RID: 51102 RVA: 0x00BABBAC File Offset: 0x00BA9DAC
		public bool ConPerMDCRunMDCDemodulator_A8494_Valid
		{
			get
			{
				short num = (short)1973111968;
				short num2 = num;
				num = (short)2144947360;
				switch (num2 == num)
				{
				default:
				{
					num = (short)417726464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)548864001;
				if (num != 0)
				{
				}
				num = (short)2138636288;
				if (num != 0)
				{
				}
				return this.conPerMDCRunMDCDemodulator_A8494.Valid;
			}
			set
			{
				short num = (short)710096633;
				short num2 = num;
				num = (short)1376728825;
				switch (num2 == num)
				{
				default:
				{
					num = (short)796983296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)934936576;
				if (num != 0)
				{
				}
				num = (short)1577385985;
				if (num != 0)
				{
				}
				this.conPerMDCRunMDCDemodulator_A8494.Valid = value;
			}
		}

		// Token: 0x17006418 RID: 25624
		// (get) Token: 0x0600C79F RID: 51103 RVA: 0x00BABC60 File Offset: 0x00BA9E60
		// (set) Token: 0x0600C7A0 RID: 51104 RVA: 0x00BABD14 File Offset: 0x00BA9F14
		public bool ConPerMDCRunMDCDemodulator_A8494_Visible
		{
			get
			{
				short num = (short)1826488321;
				if (num != 0)
				{
				}
				num = (short)1729232896;
				short num2 = num;
				num = (short)1256484185;
				short num3 = num;
				num = (short)1156738393;
				switch (num3 == num)
				{
				}
				num = (short)1575747584;
				if (num != 0)
				{
				}
				return this.conPerMDCRunMDCDemodulator_A8494.Visible;
			}
			set
			{
				short num = (short)850166796;
				short num2 = num;
				num = (short)2033288204;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1727528960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1348009985;
				if (num != 0)
				{
				}
				num = (short)1043333120;
				if (num != 0)
				{
				}
				this.conPerMDCRunMDCDemodulator_A8494.Visible = value;
			}
		}

		// Token: 0x17006419 RID: 25625
		// (get) Token: 0x0600C7A1 RID: 51105 RVA: 0x00BABDCC File Offset: 0x00BA9FCC
		// (set) Token: 0x0600C7A2 RID: 51106 RVA: 0x00BABE84 File Offset: 0x00BAA084
		public bool ConPerMDCRunMDCDemodulator_A8494_Editable
		{
			get
			{
				short num = (short)374328507;
				short num2 = num;
				num = (short)1974389947;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1438187520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)313393153;
				if (num != 0)
				{
				}
				num = (short)984350720;
				if (num != 0)
				{
				}
				return this.conPerMDCRunMDCDemodulator_A8494.Editable;
			}
			set
			{
				short num = (short)1991573505;
				if (num != 0)
				{
				}
				num = (short)304545792;
				short num2 = num;
				num = (short)2811071;
				short num3 = num;
				num = (short)1763959999;
				switch (num3 == num)
				{
				}
				num = (short)146210816;
				if (num != 0)
				{
				}
				this.conPerMDCRunMDCDemodulator_A8494.Editable = value;
			}
		}

		// Token: 0x1700641A RID: 25626
		// (get) Token: 0x0600C7A3 RID: 51107 RVA: 0x00BABF38 File Offset: 0x00BAA138
		internal string ConPerMDCRunMDCDemodulator_A8494_UILabel
		{
			get
			{
				short num = (short)1037677893;
				short num2 = num;
				num = (short)1895281989;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1742536704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1766916097;
				if (num != 0)
				{
				}
				num = (short)1569193984;
				if (num != 0)
				{
				}
				return this.conPerMDCRunMDCDemodulator_A8494.UIName;
			}
		}

		// Token: 0x1700641B RID: 25627
		// (get) Token: 0x0600C7A4 RID: 51108 RVA: 0x00BABFEC File Offset: 0x00BAA1EC
		// (set) Token: 0x0600C7A5 RID: 51109 RVA: 0x00BAC0A0 File Offset: 0x00BAA2A0
		internal bool ConPerMDCRunMDCDemodulator_A8494_HiddenStatic
		{
			get
			{
				short num = (short)1399394955;
				short num2 = num;
				num = (short)379851403;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1868562432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)150011905;
				if (num != 0)
				{
				}
				num = (short)1727856640;
				if (num != 0)
				{
				}
				return this.conPerMDCRunMDCDemodulator_A8494.HiddenStatic;
			}
			set
			{
				short num = (short)1764101159;
				short num2 = num;
				num = (short)1526991911;
				switch (num2 == num)
				{
				default:
				{
					num = (short)228524032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)266338304;
				if (num != 0)
				{
				}
				num = (short)1538523137;
				if (num != 0)
				{
				}
				this.conPerMDCRunMDCDemodulator_A8494.HiddenStatic = value;
			}
		}

		// Token: 0x1700641C RID: 25628
		// (get) Token: 0x0600C7A6 RID: 51110 RVA: 0x00BAC158 File Offset: 0x00BAA358
		// (set) Token: 0x0600C7A7 RID: 51111 RVA: 0x00BAC20C File Offset: 0x00BAA40C
		internal bool ConPerMDCRunMDCDemodulator_A8494_HiddenDynamic
		{
			get
			{
				short num = (short)1920991232;
				short num2 = num;
				num = (short)1427640459;
				short num3 = num;
				num = (short)1451561099;
				switch (num3 == num)
				{
				}
				num = (short)1146224640;
				if (num != 0)
				{
				}
				num = (short)790757377;
				if (num != 0)
				{
				}
				return this.conPerMDCRunMDCDemodulator_A8494.HiddenDynamic;
			}
			set
			{
				short num = (short)1666514944;
				short num2 = num;
				num = (short)1475451931;
				short num3 = num;
				num = (short)570268699;
				switch (num3 == num)
				{
				}
				num = (short)1831403521;
				if (num != 0)
				{
				}
				num = (short)810876928;
				if (num != 0)
				{
				}
				this.conPerMDCRunMDCDemodulator_A8494.HiddenDynamic = value;
			}
		}

		// Token: 0x1700641D RID: 25629
		// (get) Token: 0x0600C7A8 RID: 51112 RVA: 0x00BAC2C4 File Offset: 0x00BAA4C4
		public bool ConPerMDCRunMDCDemodulator_A8494_HasDiffs
		{
			get
			{
				short num = (short)1001783296;
				short num2 = num;
				num = (short)132317185;
				if (num != 0)
				{
				}
				num = (short)1049512404;
				short num3 = num;
				num = (short)1376537044;
				switch (num3 == num)
				{
				}
				num = (short)1046282240;
				if (num != 0)
				{
				}
				return this.conPerMDCRunMDCDemodulator_A8494._HasDiffs;
			}
		}

		// Token: 0x1700641E RID: 25630
		// (get) Token: 0x0600C7A9 RID: 51113 RVA: 0x00BAC37C File Offset: 0x00BAA57C
		// (set) Token: 0x0600C7AA RID: 51114 RVA: 0x00BAC430 File Offset: 0x00BAA630
		public bool CnvPerLabtoolSyncMode_A19308Value
		{
			get
			{
				short num = (short)1449984000;
				short num2 = num;
				num = (short)1238421768;
				short num3 = num;
				num = (short)719245576;
				switch (num3 == num)
				{
				}
				num = (short)532414465;
				if (num != 0)
				{
				}
				num = (short)338296832;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolSyncMode_A19308.Value;
			}
			set
			{
				short num = (short)652541952;
				short num2 = num;
				num = (short)50375407;
				short num3 = num;
				num = (short)1113500399;
				switch (num3 == num)
				{
				}
				num = (short)1972830208;
				if (num != 0)
				{
				}
				num = (short)2106064897;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolSyncMode_A19308.Value = value;
			}
		}

		// Token: 0x1700641F RID: 25631
		// (get) Token: 0x0600C7AB RID: 51115 RVA: 0x00BAC4E8 File Offset: 0x00BAA6E8
		public global::AcpBusinessLayer.AcpField<bool> CnvPerLabtoolSyncMode_A19308
		{
			get
			{
				short num = (short)1899823104;
				short num2 = num;
				num = (short)759436567;
				short num3 = num;
				num = (short)30741783;
				switch (num3 == num)
				{
				}
				num = (short)126287873;
				if (num != 0)
				{
				}
				num = (short)1468268544;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolSyncMode_A19308;
			}
		}

		// Token: 0x17006420 RID: 25632
		// (get) Token: 0x0600C7AC RID: 51116 RVA: 0x00BAC598 File Offset: 0x00BAA798
		// (set) Token: 0x0600C7AD RID: 51117 RVA: 0x00BAC650 File Offset: 0x00BAA850
		public bool CnvPerLabtoolSyncMode_A19308_UIValue
		{
			get
			{
				short num = (short)1230766080;
				short num2 = num;
				num = (short)352059393;
				if (num != 0)
				{
				}
				num = (short)1386884512;
				short num3 = num;
				num = (short)413937056;
				switch (num3 == num)
				{
				}
				num = (short)1084686336;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolSyncMode_A19308.Value;
			}
			set
			{
				short num = (short)542048256;
				short num2 = num;
				num = (short)1640428956;
				short num3 = num;
				num = (short)1576727964;
				switch (num3 == num)
				{
				}
				num = (short)1004732417;
				if (num != 0)
				{
				}
				num = (short)1500053504;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolSyncMode_A19308.Value = value;
			}
		}

		// Token: 0x17006421 RID: 25633
		// (get) Token: 0x0600C7AE RID: 51118 RVA: 0x00BAC704 File Offset: 0x00BAA904
		// (set) Token: 0x0600C7AF RID: 51119 RVA: 0x00BAC7B4 File Offset: 0x00BAA9B4
		public bool CnvPerLabtoolSyncMode_A19308_Applicable
		{
			get
			{
				short num = (short)2068381696;
				short num2 = num;
				num = (short)2098369819;
				short num3 = num;
				num = (short)457282843;
				switch (num3 == num)
				{
				}
				num = (short)1170538497;
				if (num != 0)
				{
				}
				num = (short)1181024256;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolSyncMode_A19308.Applicable;
			}
			set
			{
				short num = (short)2074279936;
				short num2 = num;
				num = (short)89991955;
				short num3 = num;
				num = (short)1401432851;
				switch (num3 == num)
				{
				}
				num = (short)1397686273;
				if (num != 0)
				{
				}
				num = (short)2027618304;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolSyncMode_A19308.Applicable = value;
			}
		}

		// Token: 0x17006422 RID: 25634
		// (get) Token: 0x0600C7B0 RID: 51120 RVA: 0x00BAC868 File Offset: 0x00BAAA68
		// (set) Token: 0x0600C7B1 RID: 51121 RVA: 0x00BAC91C File Offset: 0x00BAAB1C
		public bool CnvPerLabtoolSyncMode_A19308_Valid
		{
			get
			{
				short num = (short)1575682048;
				short num2 = num;
				num = (short)546701313;
				if (num != 0)
				{
				}
				num = (short)681956146;
				short num3 = num;
				num = (short)242602802;
				switch (num3 == num)
				{
				}
				num = (short)967114752;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolSyncMode_A19308.Valid;
			}
			set
			{
				short num = (short)2117468160;
				short num2 = num;
				num = (short)353187507;
				short num3 = num;
				num = (short)595211955;
				switch (num3 == num)
				{
				}
				num = (short)476315649;
				if (num != 0)
				{
				}
				num = (short)513867776;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolSyncMode_A19308.Valid = value;
			}
		}

		// Token: 0x17006423 RID: 25635
		// (get) Token: 0x0600C7B2 RID: 51122 RVA: 0x00BAC9D0 File Offset: 0x00BAABD0
		// (set) Token: 0x0600C7B3 RID: 51123 RVA: 0x00BACA84 File Offset: 0x00BAAC84
		public bool CnvPerLabtoolSyncMode_A19308_Visible
		{
			get
			{
				short num = (short)939327488;
				short num2 = num;
				num = (short)838918590;
				short num3 = num;
				num = (short)1525866942;
				switch (num3 == num)
				{
				}
				num = (short)615710721;
				if (num != 0)
				{
				}
				num = (short)1090387968;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolSyncMode_A19308.Visible;
			}
			set
			{
				short num = (short)1355874304;
				short num2 = num;
				num = (short)1086329738;
				short num3 = num;
				num = (short)1244730250;
				switch (num3 == num)
				{
				}
				num = (short)213581825;
				if (num != 0)
				{
				}
				num = (short)277872640;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolSyncMode_A19308.Visible = value;
			}
		}

		// Token: 0x17006424 RID: 25636
		// (get) Token: 0x0600C7B4 RID: 51124 RVA: 0x00BACB3C File Offset: 0x00BAAD3C
		// (set) Token: 0x0600C7B5 RID: 51125 RVA: 0x00BACBF0 File Offset: 0x00BAADF0
		public bool CnvPerLabtoolSyncMode_A19308_Editable
		{
			get
			{
				short num = (short)1992032256;
				short num2 = num;
				num = (short)456313467;
				short num3 = num;
				num = (short)839043707;
				switch (num3 == num)
				{
				}
				num = (short)113573889;
				if (num != 0)
				{
				}
				num = (short)1878523904;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolSyncMode_A19308.Editable;
			}
			set
			{
				short num = (short)649330688;
				short num2 = num;
				num = (short)1706241418;
				short num3 = num;
				num = (short)550645130;
				switch (num3 == num)
				{
				}
				num = (short)657981441;
				if (num != 0)
				{
				}
				num = (short)1366097920;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolSyncMode_A19308.Editable = value;
			}
		}

		// Token: 0x17006425 RID: 25637
		// (get) Token: 0x0600C7B6 RID: 51126 RVA: 0x00BACCA8 File Offset: 0x00BAAEA8
		internal string CnvPerLabtoolSyncMode_A19308_UILabel
		{
			get
			{
				short num = (short)1636171776;
				short num2 = num;
				num = (short)1469317296;
				short num3 = num;
				num = (short)447414448;
				switch (num3 == num)
				{
				}
				num = (short)1043005441;
				if (num != 0)
				{
				}
				num = (short)1025048576;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolSyncMode_A19308.UIName;
			}
		}

		// Token: 0x17006426 RID: 25638
		// (get) Token: 0x0600C7B7 RID: 51127 RVA: 0x00BACD5C File Offset: 0x00BAAF5C
		// (set) Token: 0x0600C7B8 RID: 51128 RVA: 0x00BACE14 File Offset: 0x00BAB014
		internal bool CnvPerLabtoolSyncMode_A19308_HiddenStatic
		{
			get
			{
				short num = (short)1862729728;
				short num2 = num;
				num = (short)803934497;
				short num3 = num;
				num = (short)1123422497;
				switch (num3 == num)
				{
				}
				num = (short)1049821185;
				if (num != 0)
				{
				}
				num = (short)809959424;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolSyncMode_A19308.HiddenStatic;
			}
			set
			{
				short num = (short)1744371712;
				short num2 = num;
				num = (short)1860042753;
				if (num != 0)
				{
				}
				num = (short)933901595;
				short num3 = num;
				num = (short)2137535771;
				switch (num3 == num)
				{
				}
				num = (short)947453952;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolSyncMode_A19308.HiddenStatic = value;
			}
		}

		// Token: 0x17006427 RID: 25639
		// (get) Token: 0x0600C7B9 RID: 51129 RVA: 0x00BACECC File Offset: 0x00BAB0CC
		// (set) Token: 0x0600C7BA RID: 51130 RVA: 0x00BACF7C File Offset: 0x00BAB17C
		internal bool CnvPerLabtoolSyncMode_A19308_HiddenDynamic
		{
			get
			{
				short num = (short)590544896;
				short num2 = num;
				num = (short)771973281;
				short num3 = num;
				num = (short)1862361249;
				switch (num3 == num)
				{
				}
				num = (short)695402497;
				if (num != 0)
				{
				}
				num = (short)278921216;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolSyncMode_A19308.HiddenDynamic;
			}
			set
			{
				short num = (short)339279872;
				short num2 = num;
				num = (short)1595120576;
				short num3 = num;
				num = (short)314284992;
				switch (num3 == num)
				{
				}
				num = (short)1112539137;
				if (num != 0)
				{
				}
				num = (short)1480589312;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolSyncMode_A19308.HiddenDynamic = value;
			}
		}

		// Token: 0x17006428 RID: 25640
		// (get) Token: 0x0600C7BB RID: 51131 RVA: 0x00BAD034 File Offset: 0x00BAB234
		public bool CnvPerLabtoolSyncMode_A19308_HasDiffs
		{
			get
			{
				short num = (short)1675689984;
				short num2 = num;
				num = (short)2144091974;
				short num3 = num;
				num = (short)633159494;
				switch (num3 == num)
				{
				}
				num = (short)869597184;
				if (num != 0)
				{
				}
				num = (short)326369281;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolSyncMode_A19308._HasDiffs;
			}
		}

		// Token: 0x17006429 RID: 25641
		// (get) Token: 0x0600C7BC RID: 51132 RVA: 0x00BAD0E8 File Offset: 0x00BAB2E8
		// (set) Token: 0x0600C7BD RID: 51133 RVA: 0x00BAD19C File Offset: 0x00BAB39C
		public int CnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474Value
		{
			get
			{
				short num = (short)1051721728;
				short num2 = num;
				num = (short)1798019994;
				short num3 = num;
				num = (short)255957914;
				switch (num3 == num)
				{
				}
				num = (short)45875200;
				if (num != 0)
				{
				}
				num = (short)355532801;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474.Value;
			}
			set
			{
				short num = (short)1866334208;
				short num2 = num;
				num = (short)1936995912;
				short num3 = num;
				num = (short)1900426824;
				switch (num3 == num)
				{
				}
				num = (short)1663369216;
				if (num != 0)
				{
				}
				num = (short)299171841;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474.Value = value;
			}
		}

		// Token: 0x1700642A RID: 25642
		// (get) Token: 0x0600C7BE RID: 51134 RVA: 0x00BAD24C File Offset: 0x00BAB44C
		// (set) Token: 0x0600C7BF RID: 51135 RVA: 0x00BAD300 File Offset: 0x00BAB500
		public string CnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474_UIValue
		{
			get
			{
				short num = (short)1555824640;
				short num2 = num;
				num = (short)1884928085;
				short num3 = num;
				num = (short)371570773;
				switch (num3 == num)
				{
				}
				num = (short)544407552;
				if (num != 0)
				{
				}
				num = (short)1386545153;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474.UIValue;
			}
			set
			{
				short num = (short)1837563904;
				short num2 = num;
				num = (short)316767065;
				short num3 = num;
				num = (short)1283291993;
				switch (num3 == num)
				{
				}
				num = (short)783351808;
				if (num != 0)
				{
				}
				num = (short)2126446593;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474.UIValue = value;
			}
		}

		// Token: 0x1700642B RID: 25643
		// (get) Token: 0x0600C7C0 RID: 51136 RVA: 0x00BAD3B4 File Offset: 0x00BAB5B4
		public global::AcpBusinessLayer.AcpRecRefField CnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474
		{
			get
			{
				short num = (short)615055360;
				short num2 = num;
				num = (short)345833473;
				if (num != 0)
				{
				}
				num = (short)1367331474;
				short num3 = num;
				num = (short)635097746;
				switch (num3 == num)
				{
				}
				num = (short)586219520;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474;
			}
		}

		// Token: 0x1700642C RID: 25644
		// (get) Token: 0x0600C7C1 RID: 51137 RVA: 0x00BAD464 File Offset: 0x00BAB664
		// (set) Token: 0x0600C7C2 RID: 51138 RVA: 0x00BAD518 File Offset: 0x00BAB718
		public bool CnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474_Applicable
		{
			get
			{
				short num = (short)126353408;
				short num2 = num;
				num = (short)1602801387;
				short num3 = num;
				num = (short)1607323371;
				switch (num3 == num)
				{
				}
				num = (short)280100864;
				if (num != 0)
				{
				}
				num = (short)1681195009;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474.Applicable;
			}
			set
			{
				short num = (short)2010251264;
				short num2 = num;
				num = (short)1547845050;
				short num3 = num;
				num = (short)817970618;
				switch (num3 == num)
				{
				}
				num = (short)2032205825;
				if (num != 0)
				{
				}
				num = (short)1181548544;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474.Applicable = value;
			}
		}

		// Token: 0x1700642D RID: 25645
		// (get) Token: 0x0600C7C3 RID: 51139 RVA: 0x00BAD5CC File Offset: 0x00BAB7CC
		// (set) Token: 0x0600C7C4 RID: 51140 RVA: 0x00BAD680 File Offset: 0x00BAB880
		public bool CnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474_Valid
		{
			get
			{
				short num = (short)595001344;
				short num2 = num;
				num = (short)510935367;
				short num3 = num;
				num = (short)1233273159;
				switch (num3 == num)
				{
				}
				num = (short)830799872;
				if (num != 0)
				{
				}
				num = (short)669581313;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474.Valid;
			}
			set
			{
				short num = (short)21102592;
				short num2 = num;
				num = (short)1990931804;
				short num3 = num;
				num = (short)1316828508;
				switch (num3 == num)
				{
				}
				num = (short)1521418241;
				if (num != 0)
				{
				}
				num = (short)1938292736;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474.Valid = value;
			}
		}

		// Token: 0x1700642E RID: 25646
		// (get) Token: 0x0600C7C5 RID: 51141 RVA: 0x00BAD738 File Offset: 0x00BAB938
		// (set) Token: 0x0600C7C6 RID: 51142 RVA: 0x00BAD7E8 File Offset: 0x00BAB9E8
		public bool CnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474_Visible
		{
			get
			{
				short num = (short)1904476160;
				short num2 = num;
				num = (short)882708404;
				short num3 = num;
				num = (short)754913204;
				switch (num3 == num)
				{
				}
				num = (short)1433141248;
				if (num != 0)
				{
				}
				num = (short)1871839233;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474.Visible;
			}
			set
			{
				short num = (short)1611268096;
				short num2 = num;
				num = (short)819402733;
				short num3 = num;
				num = (short)626989037;
				switch (num3 == num)
				{
				}
				num = (short)1590362113;
				if (num != 0)
				{
				}
				num = (short)908263424;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474.Visible = value;
			}
		}

		// Token: 0x1700642F RID: 25647
		// (get) Token: 0x0600C7C7 RID: 51143 RVA: 0x00BAD8A0 File Offset: 0x00BABAA0
		// (set) Token: 0x0600C7C8 RID: 51144 RVA: 0x00BAD954 File Offset: 0x00BABB54
		public bool CnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474_Editable
		{
			get
			{
				short num = (short)747896832;
				short num2 = num;
				num = (short)837701687;
				short num3 = num;
				num = (short)1559777335;
				switch (num3 == num)
				{
				}
				num = (short)446824449;
				if (num != 0)
				{
				}
				num = (short)1159200768;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474.Editable;
			}
			set
			{
				short num = (short)2129002496;
				short num2 = num;
				num = (short)654678483;
				short num3 = num;
				num = (short)594188755;
				switch (num3 == num)
				{
				}
				num = (short)699465728;
				if (num != 0)
				{
				}
				num = (short)2062745601;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474.Editable = value;
			}
		}

		// Token: 0x17006430 RID: 25648
		// (get) Token: 0x0600C7C9 RID: 51145 RVA: 0x00BADA08 File Offset: 0x00BABC08
		internal string CnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474_UILabel
		{
			get
			{
				short num = (short)291897344;
				short num2 = num;
				num = (short)1415323007;
				short num3 = num;
				num = (short)529800575;
				switch (num3 == num)
				{
				}
				num = (short)251265025;
				if (num != 0)
				{
				}
				num = (short)262340608;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474.UIName;
			}
		}

		// Token: 0x17006431 RID: 25649
		// (get) Token: 0x0600C7CA RID: 51146 RVA: 0x00BADAC0 File Offset: 0x00BABCC0
		// (set) Token: 0x0600C7CB RID: 51147 RVA: 0x00BADB74 File Offset: 0x00BABD74
		internal bool CnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474_HiddenStatic
		{
			get
			{
				short num = (short)199163904;
				short num2 = num;
				num = (short)1929510913;
				if (num != 0)
				{
				}
				num = (short)1079079086;
				short num3 = num;
				num = (short)1649635502;
				switch (num3 == num)
				{
				}
				num = (short)783941632;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474.HiddenStatic;
			}
			set
			{
				short num = (short)678625280;
				short num2 = num;
				num = (short)403031657;
				short num3 = num;
				num = (short)1582679657;
				switch (num3 == num)
				{
				}
				num = (short)776536065;
				if (num != 0)
				{
				}
				num = (short)829292544;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474.HiddenStatic = value;
			}
		}

		// Token: 0x17006432 RID: 25650
		// (get) Token: 0x0600C7CC RID: 51148 RVA: 0x00BADC28 File Offset: 0x00BABE28
		// (set) Token: 0x0600C7CD RID: 51149 RVA: 0x00BADCDC File Offset: 0x00BABEDC
		internal bool CnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474_HiddenDynamic
		{
			get
			{
				short num = (short)1812201472;
				short num2 = num;
				num = (short)1877850041;
				short num3 = num;
				num = (short)911128505;
				switch (num3 == num)
				{
				}
				num = (short)1861615616;
				if (num != 0)
				{
				}
				num = (short)1704787969;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474.HiddenDynamic;
			}
			set
			{
				short num = (short)1818296320;
				short num2 = num;
				num = (short)1867401543;
				short num3 = num;
				num = (short)454641991;
				switch (num3 == num)
				{
				}
				num = (short)21561345;
				if (num != 0)
				{
				}
				num = (short)2125266944;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474.HiddenDynamic = value;
			}
		}

		// Token: 0x17006433 RID: 25651
		// (get) Token: 0x0600C7CE RID: 51150 RVA: 0x00BADD90 File Offset: 0x00BABF90
		public bool CnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474_HasDiffs
		{
			get
			{
				short num = (short)497090560;
				short num2 = num;
				num = (short)1221089338;
				short num3 = num;
				num = (short)1455511610;
				switch (num3 == num)
				{
				}
				num = (short)1249443841;
				if (num != 0)
				{
				}
				num = (short)577044480;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474._HasDiffs;
			}
		}

		// Token: 0x17006434 RID: 25652
		// (get) Token: 0x0600C7CF RID: 51151 RVA: 0x00BADE48 File Offset: 0x00BAC048
		// (set) Token: 0x0600C7D0 RID: 51152 RVA: 0x00BADEFC File Offset: 0x00BAC0FC
		public int CnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630Value
		{
			get
			{
				short num = (short)2057371648;
				short num2 = num;
				num = (short)188302674;
				short num3 = num;
				num = (short)1929332050;
				switch (num3 == num)
				{
				}
				num = (short)2020933633;
				if (num != 0)
				{
				}
				num = (short)1985478656;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630.Value;
			}
			set
			{
				short num = (short)1978728448;
				short num2 = num;
				num = (short)1019804329;
				short num3 = num;
				num = (short)1530526377;
				switch (num3 == num)
				{
				}
				num = (short)739442688;
				if (num != 0)
				{
				}
				num = (short)159645697;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630.Value = value;
			}
		}

		// Token: 0x17006435 RID: 25653
		// (get) Token: 0x0600C7D1 RID: 51153 RVA: 0x00BADFB0 File Offset: 0x00BAC1B0
		// (set) Token: 0x0600C7D2 RID: 51154 RVA: 0x00BAE068 File Offset: 0x00BAC268
		public string CnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630_UIValue
		{
			get
			{
				short num = (short)102694912;
				short num2 = num;
				num = (short)912654058;
				short num3 = num;
				num = (short)1068957418;
				switch (num3 == num)
				{
				}
				num = (short)784924673;
				if (num != 0)
				{
				}
				num = (short)190775296;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630.UIValue;
			}
			set
			{
				short num = (short)1545338880;
				short num2 = num;
				num = (short)600144693;
				short num3 = num;
				num = (short)1320516405;
				switch (num3 == num)
				{
				}
				num = (short)927334401;
				if (num != 0)
				{
				}
				num = (short)2056650752;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630.UIValue = value;
			}
		}

		// Token: 0x17006436 RID: 25654
		// (get) Token: 0x0600C7D3 RID: 51155 RVA: 0x00BAE11C File Offset: 0x00BAC31C
		public global::AcpBusinessLayer.AcpRecRefField CnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630
		{
			get
			{
				short num = (short)79167488;
				short num2 = num;
				num = (short)1667369264;
				short num3 = num;
				num = (short)670435632;
				switch (num3 == num)
				{
				}
				num = (short)1258946561;
				if (num != 0)
				{
				}
				num = (short)1957363712;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630;
			}
		}

		// Token: 0x17006437 RID: 25655
		// (get) Token: 0x0600C7D4 RID: 51156 RVA: 0x00BAE1C8 File Offset: 0x00BAC3C8
		// (set) Token: 0x0600C7D5 RID: 51157 RVA: 0x00BAE27C File Offset: 0x00BAC47C
		public bool CnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630_Applicable
		{
			get
			{
				short num = (short)1766064128;
				short num2 = num;
				num = (short)1569286881;
				short num3 = num;
				num = (short)388459233;
				switch (num3 == num)
				{
				}
				num = (short)761593856;
				if (num != 0)
				{
				}
				num = (short)317456385;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630.Applicable;
			}
			set
			{
				short num = (short)810876928;
				short num2 = num;
				num = (short)5907310;
				short num3 = num;
				num = (short)838017902;
				switch (num3 == num)
				{
				}
				num = (short)1125187584;
				if (num != 0)
				{
				}
				num = (short)593756161;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630.Applicable = value;
			}
		}

		// Token: 0x17006438 RID: 25656
		// (get) Token: 0x0600C7D6 RID: 51158 RVA: 0x00BAE330 File Offset: 0x00BAC530
		// (set) Token: 0x0600C7D7 RID: 51159 RVA: 0x00BAE3E8 File Offset: 0x00BAC5E8
		public bool CnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630_Valid
		{
			get
			{
				short num = (short)1986854912;
				short num2 = num;
				num = (short)222012125;
				short num3 = num;
				num = (short)1154065117;
				switch (num3 == num)
				{
				}
				num = (short)1017970689;
				if (num != 0)
				{
				}
				num = (short)641728512;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630.Valid;
			}
			set
			{
				short num = (short)2066874368;
				short num2 = num;
				num = (short)82794114;
				short num3 = num;
				num = (short)122640002;
				switch (num3 == num)
				{
				}
				num = (short)1491140608;
				if (num != 0)
				{
				}
				num = (short)119799809;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630.Valid = value;
			}
		}

		// Token: 0x17006439 RID: 25657
		// (get) Token: 0x0600C7D8 RID: 51160 RVA: 0x00BAE4A0 File Offset: 0x00BAC6A0
		// (set) Token: 0x0600C7D9 RID: 51161 RVA: 0x00BAE554 File Offset: 0x00BAC754
		public bool CnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630_Visible
		{
			get
			{
				short num = (short)1132003328;
				short num2 = num;
				num = (short)495701003;
				short num3 = num;
				num = (short)873253899;
				switch (num3 == num)
				{
				}
				num = (short)1735720961;
				if (num != 0)
				{
				}
				num = (short)2135490560;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630.Visible;
			}
			set
			{
				short num = (short)2087387136;
				short num2 = num;
				num = (short)257217438;
				short num3 = num;
				num = (short)157406110;
				switch (num3 == num)
				{
				}
				num = (short)740032512;
				if (num != 0)
				{
				}
				num = (short)538312705;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630.Visible = value;
			}
		}

		// Token: 0x1700643A RID: 25658
		// (get) Token: 0x0600C7DA RID: 51162 RVA: 0x00BAE608 File Offset: 0x00BAC808
		// (set) Token: 0x0600C7DB RID: 51163 RVA: 0x00BAE6C0 File Offset: 0x00BAC8C0
		public bool CnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630_Editable
		{
			get
			{
				short num = (short)279707648;
				short num2 = num;
				num = (short)246317097;
				short num3 = num;
				num = (short)1397850153;
				switch (num3 == num)
				{
				}
				num = (short)385220609;
				if (num != 0)
				{
				}
				num = (short)1115226112;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630.Editable;
			}
			set
			{
				short num = (short)1436614656;
				short num2 = num;
				num = (short)291221993;
				short num3 = num;
				num = (short)1560392169;
				switch (num3 == num)
				{
				}
				num = (short)802160641;
				if (num != 0)
				{
				}
				num = (short)35913728;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630.Editable = value;
			}
		}

		// Token: 0x1700643B RID: 25659
		// (get) Token: 0x0600C7DC RID: 51164 RVA: 0x00BAE774 File Offset: 0x00BAC974
		internal string CnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630_UILabel
		{
			get
			{
				short num = (short)1447559168;
				short num2 = num;
				num = (short)1824747622;
				short num3 = num;
				num = (short)2037477478;
				switch (num3 == num)
				{
				}
				num = (short)1793392641;
				if (num != 0)
				{
				}
				num = (short)1734279168;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630.UIName;
			}
		}

		// Token: 0x1700643C RID: 25660
		// (get) Token: 0x0600C7DD RID: 51165 RVA: 0x00BAE828 File Offset: 0x00BACA28
		// (set) Token: 0x0600C7DE RID: 51166 RVA: 0x00BAE8DC File Offset: 0x00BACADC
		internal bool CnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630_HiddenStatic
		{
			get
			{
				short num = (short)1450442752;
				short num2 = num;
				num = (short)242143556;
				short num3 = num;
				num = (short)928698692;
				switch (num3 == num)
				{
				}
				num = (short)219152384;
				if (num != 0)
				{
				}
				num = (short)1529413633;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630.HiddenStatic;
			}
			set
			{
				short num = (short)1521287168;
				short num2 = num;
				num = (short)1399128192;
				short num3 = num;
				num = (short)590807168;
				switch (num3 == num)
				{
				}
				num = (short)575799296;
				if (num != 0)
				{
				}
				num = (short)177471489;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630.HiddenStatic = value;
			}
		}

		// Token: 0x1700643D RID: 25661
		// (get) Token: 0x0600C7DF RID: 51167 RVA: 0x00BAE990 File Offset: 0x00BACB90
		// (set) Token: 0x0600C7E0 RID: 51168 RVA: 0x00BAEA44 File Offset: 0x00BACC44
		internal bool CnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630_HiddenDynamic
		{
			get
			{
				short num = (short)1861746688;
				short num2 = num;
				num = (short)1406997388;
				short num3 = num;
				num = (short)1705776012;
				switch (num3 == num)
				{
				}
				num = (short)533266433;
				if (num != 0)
				{
				}
				num = (short)1332805632;
				if (num != 0)
				{
				}
				return this.cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630.HiddenDynamic;
			}
			set
			{
				short num = (short)1793261568;
				short num2 = num;
				num = (short)324802738;
				short num3 = num;
				num = (short)1540757682;
				switch (num3 == num)
				{
				}
				num = (short)1124663297;
				if (num != 0)
				{
				}
				num = (short)1887633408;
				if (num != 0)
				{
				}
				this.cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630.HiddenDynamic = value;
			}
		}

		// Token: 0x1700643E RID: 25662
		// (get) Token: 0x0600C7E1 RID: 51169 RVA: 0x00BAEAF8 File Offset: 0x00BACCF8
		public bool CnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630_HasDiffs
		{
			get
			{
				short num = (short)1556348929;
				if (num != 0)
				{
				}
				num = (short)123613077;
				short num2 = num;
				num = (short)1217671061;
				switch (num2 == num)
				{
				}
				num = (short)79757312;
				if (num != 0)
				{
				}
				num = (short)734724096;
				short num3 = num;
				return this.cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630._HasDiffs;
			}
		}

		// Token: 0x0600C7E2 RID: 51170 RVA: 0x00BAEBAC File Offset: 0x00BACDAC
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
					num2 = (short)2123956224;
					short num3 = num2;
					num2 = (short)1603731457;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1011941378;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					num2 = (short)768933892;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return result;
				case 3:
					while (base.ParentRecset != null)
					{
						num2 = (short)490029701;
						short num4 = num2;
						num2 = (short)2076131973;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)1265106944;
							if (num2 != 0)
							{
							}
							num2 = (short)261619713;
							num = (int)((global::System.IntPtr)num2);
							goto IL_0A;
						}
					}
					return result;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)469434368;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1906245635;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040064B1 RID: 25777
		private global::AcpBusinessLayer.AcpField<bool> conPerMDCRunMDCDemodulator_A8494;

		// Token: 0x040064B2 RID: 25778
		private global::AcpBusinessLayer.AcpField<bool> cnvPerLabtoolSyncMode_A19308;

		// Token: 0x040064B3 RID: 25779
		private global::AcpBusinessLayer.AcpRecRefField cnvPerLabtoolConventionalPersonalityChannelOptionsListItemID_A20474;

		// Token: 0x040064B4 RID: 25780
		private global::AcpBusinessLayer.AcpRecRefField cnvPerLabtoolConventionalPersonalityOneTouchListItemID_A22630;
	}
}
