using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x0200018C RID: 396
	[global::System.Serializable]
	public class TxFrequencySplitFPPInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06003FDE RID: 16350 RVA: 0x003BF808 File Offset: 0x003BDA08
		public TxFrequencySplitFPPInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06003FDF RID: 16351 RVA: 0x003BF824 File Offset: 0x003BDA24
		protected TxFrequencySplitFPPInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06003FE0 RID: 16352 RVA: 0x003BF83C File Offset: 0x003BDA3C
		public override void Init()
		{
			int a_ = 12;
			short num = (short)1695923302;
			short num2 = num;
			num = (short)879279206;
			switch (num2 == num)
			{
			}
			num = (short)704577536;
			if (num != 0)
			{
			}
			num = (short)712310785;
			if (num != 0)
			{
			}
			num = (short)476905472;
			short num3 = num;
			this.radWideLabtoolTxEndFrequencySplit_A9532 = new global::AcpBusinessLayer.AcpFrequencyField(0, this, global::AllFeatures.CodeplugGuid.b("鿌껎뗐蓒볔돖볘韚볜뷞闠賢諤详뷨鏪꣬臮闰뗲蟴鋶裸軺飼釾戀稂嘄眆攈戊礌倎倐⨒—␖⬘", a_), global::CommonResources.AcgResources.ID_TXENDFREQUENCYSPLIT, 0, int.MaxValue, 1);
			this.radWideLabtoolTxEndFrequencySplit_A9532.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolTxEndFrequencySplit_A9532.DataTransferOrder = -1;
			this.radWideLabtoolTxStartFrequencySplit_A9571 = new global::AcpBusinessLayer.AcpFrequencyField(0, this, global::AllFeatures.CodeplugGuid.b("鿌껎뗐蓒볔돖볘韚볜뷞闠賢諤详뷨鏪뻬鯮郰臲致뇶诸黺購諾搀洂昄縆娈笊愌明攐䰒吔⸖ⰘⰚⰜ", a_), global::CommonResources.AcgResources.ID_TXSTARTFREQUENCYSPLIT, 0, int.MaxValue, 1);
			this.radWideLabtoolTxStartFrequencySplit_A9571.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolTxStartFrequencySplit_A9571.DataTransferOrder = -1;
			this.radWideLabtoolTxBandSplitName_A24799 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_VHF, this, global::AllFeatures.CodeplugGuid.b("鿌껎뗐蓒볔돖볘韚볜뷞闠賢諤详뷨鏪꿬軮鿰韲꛴蟶闸鋺觼뇾怀渂怄堆䠈㤊㤌㠎⠐⨒", a_), global::CommonResources.AcgResources.ID_TXBANDSPLITNAME, 100);
			this.radWideLabtoolTxBandSplitName_A24799.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolTxBandSplitName_A24799.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("駌럎闒꟔닖꣘껚룜뇞苠髢엤듦駨蟪蓬鯮퇰\udbf2돴ꟶ꧸틺", a_);
			base.Id = 10095;
			base.UIName = global::CommonResources.AcgResources.ID_TXFREQUENCYSPLITFPP;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06003FE1 RID: 16353 RVA: 0x003BF9DC File Offset: 0x003BDBDC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)1229193216;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 1:
					this.radWideLabtoolTxBandSplitName_A24799 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_VHF, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉鯋ꟍ듏럑飓럕뫗껙돛뇝賟뛡鳣ꓥ觧蓩裫뷭胯黱鷳苵뛷鯹釻鯽忿䌁㘃㈅㼇㌉㔋", a_), global::CommonResources.AcgResources.ID_TXBANDSPLITNAME, 100);
					this.radWideLabtoolTxBandSplitName_A24799.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolTxBandSplitName_A24799.DataTransferOrder = -1;
					num = (short)208535554;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_2CF;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("铅꧇껉鯋ꟍ듏럑飓럕뫗껙돛뇝賟뛡鳣뗥鳧诩黫髭뛯胱釳蟵跷鿹鋻鷽秿儁球樅愇縉匋伍⤏✑⌓✕", a_)))
					{
						num = (short)387514380;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_231;
				case 4:
					goto IL_102;
				case 5:
					num = (short)1955332107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_27A;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("铅꧇껉鯋ꟍ듏럑飓럕뫗껙돛뇝賟뛡鳣ꏥ蛧軩ꫫ鳭闯菱至鏵雷駹藻귽烿渁洃爅圇䬉㔋㬍⌏‑", a_)))
					{
						num = (short)1943339014;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_102;
				case 8:
					num = (short)791543815;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("铅꧇껉鯋ꟍ듏럑飓럕뫗껙돛뇝賟뛡鳣ꓥ觧蓩裫뷭胯黱鷳苵뛷鯹釻鯽忿䌁㘃㈅㼇㌉㔋", a_)))
					{
						num = (short)607977473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2CF;
				case 10:
				{
					num = (short)288292864;
					short num3 = num;
					goto IL_231;
				}
				case 11:
					if (producerFields != null)
					{
						num = (short)1111425032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2CF;
				case 12:
					this.radWideLabtoolTxStartFrequencySplit_A9571 = new global::AcpBusinessLayer.AcpFrequencyField(0, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉鯋ꟍ듏럑飓럕뫗껙돛뇝賟뛡鳣뗥鳧诩黫髭뛯胱釳蟵跷鿹鋻鷽秿儁球樅愇縉匋伍⤏✑⌓✕", a_), global::CommonResources.AcgResources.ID_TXSTARTFREQUENCYSPLIT);
					this.radWideLabtoolTxStartFrequencySplit_A9571.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolTxStartFrequencySplit_A9571.DataTransferOrder = -1;
					num = (short)180027402;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_61:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1081016325;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2CF;
				IL_102:
				num = (short)1576730627;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_231:
				num = (short)223084553;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_27A:
				this.radWideLabtoolTxEndFrequencySplit_A9532 = new global::AcpBusinessLayer.AcpFrequencyField(0, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉鯋ꟍ듏럑飓럕뫗껙돛뇝賟뛡鳣ꏥ蛧軩ꫫ鳭闯菱至鏵雷駹藻귽烿渁洃爅圇䬉㔋㬍⌏‑", a_), global::CommonResources.AcgResources.ID_TXENDFREQUENCYSPLIT);
				this.radWideLabtoolTxEndFrequencySplit_A9532.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
				this.radWideLabtoolTxEndFrequencySplit_A9532.DataTransferOrder = -1;
				num = (short)1367408644;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2CF:
				num = (short)2056160790;
				short num4 = num;
				num = (short)632391190;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_27A;
				default:
					goto IL_304;
				}
			}
			IL_304:
			num = (short)1137836033;
			if (num != 0)
			{
			}
			num = (short)1825570816;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鋅냇請볍뗏ꏑꇓ돕뛗맙ꗛﻝ돟鋡裣迥鳧쫩쓫꣭ꃯꋱ\uddf3", a_);
			base.Id = 10095;
			base.UIName = global::CommonResources.AcgResources.ID_TXFREQUENCYSPLITFPP;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06003FE2 RID: 16354 RVA: 0x003BFD5C File Offset: 0x003BDF5C
		public override void PopulateReferences()
		{
			short num = (short)125108225;
			if (num != 0)
			{
			}
			num = (short)729874432;
			short num2 = num;
			num = (short)34514255;
			short num3 = num;
			num = (short)495232335;
			switch (num3 == num)
			{
			}
			num = (short)901316608;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x003BFE04 File Offset: 0x003BE004
		public override void DropReferences()
		{
			short num = (short)2094596097;
			if (num != 0)
			{
			}
			num = (short)1713242112;
			short num2 = num;
			num = (short)200992516;
			short num3 = num;
			num = (short)1751181060;
			switch (num3 == num)
			{
			}
			num = (short)1855848448;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003FE4 RID: 16356 RVA: 0x003BFEB0 File Offset: 0x003BE0B0
		public override void SetConstraints()
		{
			short num = (short)1494939389;
			short num2 = num;
			num = (short)591722237;
			switch (num2 == num)
			{
			default:
			{
				num = (short)142475264;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)547880961;
			if (num != 0)
			{
			}
			num = (short)845348864;
			if (num != 0)
			{
			}
			this.radWideLabtoolTxBandSplitName_A24799.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x06003FE5 RID: 16357 RVA: 0x003BFF70 File Offset: 0x003BE170
		public override void SetupDependencies()
		{
			short num = (short)1007520337;
			short num2 = num;
			num = (short)1303153233;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1397096448;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2013069312;
			if (num != 0)
			{
			}
			num = (short)460259329;
			if (num != 0)
			{
			}
		}

		// Token: 0x170020B1 RID: 8369
		// (get) Token: 0x06003FE6 RID: 16358 RVA: 0x003C0018 File Offset: 0x003BE218
		public bool HasDiffs
		{
			get
			{
				short num = (short)2053360909;
				short num2 = num;
				num = (short)493931789;
				switch (num2 == num)
				{
				default:
				{
					num = (short)746127360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1989672961;
				if (num != 0)
				{
				}
				num = (short)463470592;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170020B2 RID: 8370
		// (get) Token: 0x06003FE7 RID: 16359 RVA: 0x003C00C8 File Offset: 0x003BE2C8
		// (set) Token: 0x06003FE8 RID: 16360 RVA: 0x003C017C File Offset: 0x003BE37C
		public int RadWideLabtoolTxEndFrequencySplit_A9532Value
		{
			get
			{
				short num = (short)304850950;
				short num2 = num;
				num = (short)748398598;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2075983872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)534511616;
				if (num != 0)
				{
				}
				num = (short)178323457;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxEndFrequencySplit_A9532.Value;
			}
			set
			{
				short num = (short)261230974;
				short num2 = num;
				num = (short)1146163582;
				switch (num2 == num)
				{
				default:
				{
					num = (short)242024448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)961740801;
				if (num != 0)
				{
				}
				num = (short)360054784;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxEndFrequencySplit_A9532.Value = value;
			}
		}

		// Token: 0x170020B3 RID: 8371
		// (get) Token: 0x06003FE9 RID: 16361 RVA: 0x003C0230 File Offset: 0x003BE430
		// (set) Token: 0x06003FEA RID: 16362 RVA: 0x003C02E4 File Offset: 0x003BE4E4
		public string RadWideLabtoolTxEndFrequencySplit_A9532_UIValue
		{
			get
			{
				short num = (short)670524258;
				short num2 = num;
				num = (short)1118069602;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1318256640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)939589633;
				if (num != 0)
				{
				}
				num = (short)1862664192;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxEndFrequencySplit_A9532.UIValue;
			}
			set
			{
				short num = (short)980574154;
				short num2 = num;
				num = (short)852516810;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1124139008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2018639873;
				if (num != 0)
				{
				}
				num = (short)751370240;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxEndFrequencySplit_A9532.UIValue = value;
			}
		}

		// Token: 0x170020B4 RID: 8372
		// (get) Token: 0x06003FEB RID: 16363 RVA: 0x003C0398 File Offset: 0x003BE598
		public global::AcpBusinessLayer.AcpFrequencyField RadWideLabtoolTxEndFrequencySplit_A9532
		{
			get
			{
				short num = (short)901987510;
				short num2 = num;
				num = (short)1547648182;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1570766848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)760676352;
				if (num != 0)
				{
				}
				num = (short)236781569;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxEndFrequencySplit_A9532;
			}
		}

		// Token: 0x170020B5 RID: 8373
		// (get) Token: 0x06003FEC RID: 16364 RVA: 0x003C0448 File Offset: 0x003BE648
		// (set) Token: 0x06003FED RID: 16365 RVA: 0x003C04FC File Offset: 0x003BE6FC
		internal int RadWideLabtoolTxEndFrequencySplit_A9532Min
		{
			get
			{
				short num = (short)53687518;
				short num2 = num;
				num = (short)771110110;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1384054784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)12124160;
				if (num != 0)
				{
				}
				num = (short)79626241;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxEndFrequencySplit_A9532.Min;
			}
			set
			{
				short num = (short)1964769281;
				if (num != 0)
				{
				}
				num = (short)150536192;
				short num2 = num;
				num = (short)1091234154;
				short num3 = num;
				num = (short)1330440554;
				switch (num3 == num)
				{
				}
				num = (short)1456930816;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxEndFrequencySplit_A9532.Min = value;
			}
		}

		// Token: 0x170020B6 RID: 8374
		// (get) Token: 0x06003FEE RID: 16366 RVA: 0x003C05B4 File Offset: 0x003BE7B4
		// (set) Token: 0x06003FEF RID: 16367 RVA: 0x003C0668 File Offset: 0x003BE868
		internal int RadWideLabtoolTxEndFrequencySplit_A9532Max
		{
			get
			{
				short num = (short)1246725121;
				short num2 = num;
				num = (short)1140556801;
				switch (num2 == num)
				{
				default:
				{
					num = (short)418381824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1866661888;
				if (num != 0)
				{
				}
				num = (short)168951809;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxEndFrequencySplit_A9532.Max;
			}
			set
			{
				short num = (short)381419532;
				short num2 = num;
				num = (short)597295116;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1843789824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1105461249;
				if (num != 0)
				{
				}
				num = (short)1812463616;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxEndFrequencySplit_A9532.Max = value;
			}
		}

		// Token: 0x170020B7 RID: 8375
		// (get) Token: 0x06003FF0 RID: 16368 RVA: 0x003C071C File Offset: 0x003BE91C
		// (set) Token: 0x06003FF1 RID: 16369 RVA: 0x003C07D4 File Offset: 0x003BE9D4
		internal int RadWideLabtoolTxEndFrequencySplit_A9532Step
		{
			get
			{
				short num = (short)808648216;
				short num2 = num;
				num = (short)1885339160;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1247739904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)647757825;
				if (num != 0)
				{
				}
				num = (short)1277558784;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxEndFrequencySplit_A9532.StepSize;
			}
			set
			{
				short num = (short)511489916;
				short num2 = num;
				num = (short)644200316;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1216741376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1579876353;
				if (num != 0)
				{
				}
				num = (short)759627776;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxEndFrequencySplit_A9532.StepSize = value;
			}
		}

		// Token: 0x170020B8 RID: 8376
		// (get) Token: 0x06003FF2 RID: 16370 RVA: 0x003C0888 File Offset: 0x003BEA88
		// (set) Token: 0x06003FF3 RID: 16371 RVA: 0x003C093C File Offset: 0x003BEB3C
		public bool RadWideLabtoolTxEndFrequencySplit_A9532_Applicable
		{
			get
			{
				short num = (short)1314762505;
				short num2 = num;
				num = (short)65908489;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2047279104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1850146817;
				if (num != 0)
				{
				}
				num = (short)566886400;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxEndFrequencySplit_A9532.Applicable;
			}
			set
			{
				short num = (short)1324938355;
				short num2 = num;
				num = (short)243659891;
				switch (num2 == num)
				{
				default:
				{
					num = (short)520093696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)341770241;
				if (num != 0)
				{
				}
				num = (short)148242432;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxEndFrequencySplit_A9532.Applicable = value;
			}
		}

		// Token: 0x170020B9 RID: 8377
		// (get) Token: 0x06003FF4 RID: 16372 RVA: 0x003C09F4 File Offset: 0x003BEBF4
		// (set) Token: 0x06003FF5 RID: 16373 RVA: 0x003C0AAC File Offset: 0x003BECAC
		public bool RadWideLabtoolTxEndFrequencySplit_A9532_Valid
		{
			get
			{
				short num = (short)2110521345;
				if (num != 0)
				{
				}
				num = (short)151846912;
				short num2 = num;
				num = (short)1490549933;
				short num3 = num;
				num = (short)84278445;
				switch (num3 == num)
				{
				}
				num = (short)1165754368;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxEndFrequencySplit_A9532.Valid;
			}
			set
			{
				short num = (short)195598269;
				short num2 = num;
				num = (short)501651389;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1629618176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)17563648;
				if (num != 0)
				{
				}
				num = (short)1780285441;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxEndFrequencySplit_A9532.Valid = value;
			}
		}

		// Token: 0x170020BA RID: 8378
		// (get) Token: 0x06003FF6 RID: 16374 RVA: 0x003C0B64 File Offset: 0x003BED64
		// (set) Token: 0x06003FF7 RID: 16375 RVA: 0x003C0C18 File Offset: 0x003BEE18
		public bool RadWideLabtoolTxEndFrequencySplit_A9532_Visible
		{
			get
			{
				short num = (short)796179304;
				short num2 = num;
				num = (short)87604072;
				switch (num2 == num)
				{
				default:
				{
					num = (short)761593856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1347223552;
				if (num != 0)
				{
				}
				num = (short)597360641;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxEndFrequencySplit_A9532.Visible;
			}
			set
			{
				short num = (short)1716072721;
				short num2 = num;
				num = (short)229388561;
				switch (num2 == num)
				{
				default:
				{
					num = (short)224919552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2020147201;
				if (num != 0)
				{
				}
				num = (short)1442643968;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxEndFrequencySplit_A9532.Visible = value;
			}
		}

		// Token: 0x170020BB RID: 8379
		// (get) Token: 0x06003FF8 RID: 16376 RVA: 0x003C0CD0 File Offset: 0x003BEED0
		// (set) Token: 0x06003FF9 RID: 16377 RVA: 0x003C0D84 File Offset: 0x003BEF84
		public bool RadWideLabtoolTxEndFrequencySplit_A9532_Editable
		{
			get
			{
				short num = (short)1686742236;
				short num2 = num;
				num = (short)1031775452;
				switch (num2 == num)
				{
				default:
				{
					num = (short)309460992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1261436929;
				if (num != 0)
				{
				}
				num = (short)442957824;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxEndFrequencySplit_A9532.Editable;
			}
			set
			{
				short num = (short)1102405418;
				short num2 = num;
				num = (short)1915510570;
				switch (num2 == num)
				{
				default:
				{
					num = (short)967835648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1533280257;
				if (num != 0)
				{
				}
				num = (short)655228928;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxEndFrequencySplit_A9532.Editable = value;
			}
		}

		// Token: 0x170020BC RID: 8380
		// (get) Token: 0x06003FFA RID: 16378 RVA: 0x003C0E38 File Offset: 0x003BF038
		internal string RadWideLabtoolTxEndFrequencySplit_A9532_UILabel
		{
			get
			{
				short num = (short)625903175;
				short num2 = num;
				num = (short)1285588551;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1236533248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1101463553;
				if (num != 0)
				{
				}
				num = (short)660275200;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxEndFrequencySplit_A9532.UIName;
			}
		}

		// Token: 0x170020BD RID: 8381
		// (get) Token: 0x06003FFB RID: 16379 RVA: 0x003C0EE8 File Offset: 0x003BF0E8
		// (set) Token: 0x06003FFC RID: 16380 RVA: 0x003C0F9C File Offset: 0x003BF19C
		internal bool RadWideLabtoolTxEndFrequencySplit_A9532_HiddenStatic
		{
			get
			{
				short num = (short)858663867;
				short num2 = num;
				num = (short)622996411;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1305280512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1370882049;
				if (num != 0)
				{
				}
				num = (short)12648448;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxEndFrequencySplit_A9532.HiddenStatic;
			}
			set
			{
				short num = (short)1482874521;
				short num2 = num;
				num = (short)173858457;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1968570368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)893517825;
				if (num != 0)
				{
				}
				num = (short)1108541440;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxEndFrequencySplit_A9532.HiddenStatic = value;
			}
		}

		// Token: 0x170020BE RID: 8382
		// (get) Token: 0x06003FFD RID: 16381 RVA: 0x003C1050 File Offset: 0x003BF250
		// (set) Token: 0x06003FFE RID: 16382 RVA: 0x003C1104 File Offset: 0x003BF304
		internal bool RadWideLabtoolTxEndFrequencySplit_A9532_HiddenDynamic
		{
			get
			{
				short num = (short)1841187164;
				short num2 = num;
				num = (short)1150634332;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1011089408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)451805185;
				if (num != 0)
				{
				}
				num = (short)1012203520;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxEndFrequencySplit_A9532.HiddenDynamic;
			}
			set
			{
				short num = (short)1149901708;
				short num2 = num;
				num = (short)812587916;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1131413504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1466564609;
				if (num != 0)
				{
				}
				num = (short)454885376;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxEndFrequencySplit_A9532.HiddenDynamic = value;
			}
		}

		// Token: 0x170020BF RID: 8383
		// (get) Token: 0x06003FFF RID: 16383 RVA: 0x003C11B8 File Offset: 0x003BF3B8
		public bool RadWideLabtoolTxEndFrequencySplit_A9532_HasDiffs
		{
			get
			{
				short num = (short)1809302733;
				short num2 = num;
				num = (short)538363085;
				switch (num2 == num)
				{
				default:
				{
					num = (short)117047296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1313931265;
				if (num != 0)
				{
				}
				num = (short)1860763648;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxEndFrequencySplit_A9532._HasDiffs;
			}
		}

		// Token: 0x170020C0 RID: 8384
		// (get) Token: 0x06004000 RID: 16384 RVA: 0x003C1268 File Offset: 0x003BF468
		// (set) Token: 0x06004001 RID: 16385 RVA: 0x003C131C File Offset: 0x003BF51C
		public int RadWideLabtoolTxStartFrequencySplit_A9571Value
		{
			get
			{
				short num = (short)942755972;
				short num2 = num;
				num = (short)865489028;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2081685504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1568079872;
				if (num != 0)
				{
				}
				num = (short)1604452353;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxStartFrequencySplit_A9571.Value;
			}
			set
			{
				short num = (short)300482561;
				if (num != 0)
				{
				}
				num = (short)1187708928;
				short num2 = num;
				num = (short)949822245;
				short num3 = num;
				num = (short)412885797;
				switch (num3 == num)
				{
				}
				num = (short)59506688;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxStartFrequencySplit_A9571.Value = value;
			}
		}

		// Token: 0x170020C1 RID: 8385
		// (get) Token: 0x06004002 RID: 16386 RVA: 0x003C13D4 File Offset: 0x003BF5D4
		// (set) Token: 0x06004003 RID: 16387 RVA: 0x003C148C File Offset: 0x003BF68C
		public string RadWideLabtoolTxStartFrequencySplit_A9571_UIValue
		{
			get
			{
				short num = (short)573389835;
				short num2 = num;
				num = (short)551173131;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1620115456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)576061440;
				if (num != 0)
				{
				}
				num = (short)2100559873;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxStartFrequencySplit_A9571.UIValue;
			}
			set
			{
				short num = (short)2120548353;
				if (num != 0)
				{
				}
				num = (short)1710620672;
				short num2 = num;
				num = (short)1410335936;
				short num3 = num;
				num = (short)1544684736;
				switch (num3 == num)
				{
				}
				num = (short)817299456;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxStartFrequencySplit_A9571.UIValue = value;
			}
		}

		// Token: 0x170020C2 RID: 8386
		// (get) Token: 0x06004004 RID: 16388 RVA: 0x003C1540 File Offset: 0x003BF740
		public global::AcpBusinessLayer.AcpFrequencyField RadWideLabtoolTxStartFrequencySplit_A9571
		{
			get
			{
				short num = (short)1612462679;
				short num2 = num;
				num = (short)567097943;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1448411136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1948909568;
				if (num != 0)
				{
				}
				num = (short)431751169;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxStartFrequencySplit_A9571;
			}
		}

		// Token: 0x170020C3 RID: 8387
		// (get) Token: 0x06004005 RID: 16389 RVA: 0x003C15F0 File Offset: 0x003BF7F0
		// (set) Token: 0x06004006 RID: 16390 RVA: 0x003C16A4 File Offset: 0x003BF8A4
		internal int RadWideLabtoolTxStartFrequencySplit_A9571Min
		{
			get
			{
				short num = (short)1969845530;
				short num2 = num;
				num = (short)1949463834;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2004942848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)760872961;
				if (num != 0)
				{
				}
				num = (short)772997120;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxStartFrequencySplit_A9571.Min;
			}
			set
			{
				short num = (short)1198548175;
				short num2 = num;
				num = (short)937780431;
				switch (num2 == num)
				{
				default:
				{
					num = (short)17825792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)788267008;
				if (num != 0)
				{
				}
				num = (short)876609537;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxStartFrequencySplit_A9571.Min = value;
			}
		}

		// Token: 0x170020C4 RID: 8388
		// (get) Token: 0x06004007 RID: 16391 RVA: 0x003C175C File Offset: 0x003BF95C
		// (set) Token: 0x06004008 RID: 16392 RVA: 0x003C1810 File Offset: 0x003BFA10
		internal int RadWideLabtoolTxStartFrequencySplit_A9571Max
		{
			get
			{
				short num = (short)248462791;
				short num2 = num;
				num = (short)1810644423;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1385824256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)420478977;
				if (num != 0)
				{
				}
				num = (short)2052784128;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxStartFrequencySplit_A9571.Max;
			}
			set
			{
				short num = (short)645881344;
				short num2 = num;
				num = (short)1575837184;
				switch (num2 == num)
				{
				default:
				{
					num = (short)996671488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)608305153;
				if (num != 0)
				{
				}
				num = (short)1609826304;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxStartFrequencySplit_A9571.Max = value;
			}
		}

		// Token: 0x170020C5 RID: 8389
		// (get) Token: 0x06004009 RID: 16393 RVA: 0x003C18C8 File Offset: 0x003BFAC8
		// (set) Token: 0x0600400A RID: 16394 RVA: 0x003C197C File Offset: 0x003BFB7C
		internal int RadWideLabtoolTxStartFrequencySplit_A9571Step
		{
			get
			{
				short num = (short)1845734918;
				short num2 = num;
				num = (short)1249881606;
				switch (num2 == num)
				{
				default:
				{
					num = (short)247726080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2036137985;
				if (num != 0)
				{
				}
				num = (short)1930821632;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxStartFrequencySplit_A9571.StepSize;
			}
			set
			{
				short num = (short)824547390;
				short num2 = num;
				num = (short)576624702;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1379991552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1815478273;
				if (num != 0)
				{
				}
				num = (short)608239616;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxStartFrequencySplit_A9571.StepSize = value;
			}
		}

		// Token: 0x170020C6 RID: 8390
		// (get) Token: 0x0600400B RID: 16395 RVA: 0x003C1A34 File Offset: 0x003BFC34
		// (set) Token: 0x0600400C RID: 16396 RVA: 0x003C1AE8 File Offset: 0x003BFCE8
		public bool RadWideLabtoolTxStartFrequencySplit_A9571_Applicable
		{
			get
			{
				short num = (short)945049359;
				short num2 = num;
				num = (short)1280855823;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1289748480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1753677825;
				if (num != 0)
				{
				}
				num = (short)1633681408;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxStartFrequencySplit_A9571.Applicable;
			}
			set
			{
				short num = (short)1599012865;
				if (num != 0)
				{
				}
				num = (short)533331968;
				short num2 = num;
				num = (short)1768547862;
				short num3 = num;
				num = (short)1575151126;
				switch (num3 == num)
				{
				}
				num = (short)1853685760;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxStartFrequencySplit_A9571.Applicable = value;
			}
		}

		// Token: 0x170020C7 RID: 8391
		// (get) Token: 0x0600400D RID: 16397 RVA: 0x003C1BA0 File Offset: 0x003BFDA0
		// (set) Token: 0x0600400E RID: 16398 RVA: 0x003C1C58 File Offset: 0x003BFE58
		public bool RadWideLabtoolTxStartFrequencySplit_A9571_Valid
		{
			get
			{
				short num = (short)1298601816;
				short num2 = num;
				num = (short)1090721624;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1505296384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)543031297;
				if (num != 0)
				{
				}
				num = (short)904003584;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxStartFrequencySplit_A9571.Valid;
			}
			set
			{
				short num = (short)1324896212;
				short num2 = num;
				num = (short)1571246036;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1570439168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)714997760;
				if (num != 0)
				{
				}
				num = (short)840761345;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxStartFrequencySplit_A9571.Valid = value;
			}
		}

		// Token: 0x170020C8 RID: 8392
		// (get) Token: 0x0600400F RID: 16399 RVA: 0x003C1D0C File Offset: 0x003BFF0C
		// (set) Token: 0x06004010 RID: 16400 RVA: 0x003C1DC4 File Offset: 0x003BFFC4
		public bool RadWideLabtoolTxStartFrequencySplit_A9571_Visible
		{
			get
			{
				short num = (short)1941916875;
				short num2 = num;
				num = (short)848776395;
				switch (num2 == num)
				{
				default:
				{
					num = (short)354484224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)938278913;
				if (num != 0)
				{
				}
				num = (short)1659764736;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxStartFrequencySplit_A9571.Visible;
			}
			set
			{
				short num = (short)703201281;
				if (num != 0)
				{
				}
				num = (short)891551744;
				short num2 = num;
				num = (short)1894395370;
				short num3 = num;
				num = (short)1378823658;
				switch (num3 == num)
				{
				}
				num = (short)1036779520;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxStartFrequencySplit_A9571.Visible = value;
			}
		}

		// Token: 0x170020C9 RID: 8393
		// (get) Token: 0x06004011 RID: 16401 RVA: 0x003C1E78 File Offset: 0x003C0078
		// (set) Token: 0x06004012 RID: 16402 RVA: 0x003C1F2C File Offset: 0x003C012C
		public bool RadWideLabtoolTxStartFrequencySplit_A9571_Editable
		{
			get
			{
				short num = (short)291962880;
				short num2 = num;
				num = (short)32935121;
				short num3 = num;
				num = (short)507481297;
				switch (num3 == num)
				{
				}
				num = (short)1572143104;
				if (num != 0)
				{
				}
				num = (short)382468097;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxStartFrequencySplit_A9571.Editable;
			}
			set
			{
				short num = (short)1397882880;
				short num2 = num;
				num = (short)2070347093;
				short num3 = num;
				num = (short)180550997;
				switch (num3 == num)
				{
				}
				num = (short)1994588161;
				if (num != 0)
				{
				}
				num = (short)1913389056;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxStartFrequencySplit_A9571.Editable = value;
			}
		}

		// Token: 0x170020CA RID: 8394
		// (get) Token: 0x06004013 RID: 16403 RVA: 0x003C1FE4 File Offset: 0x003C01E4
		internal string RadWideLabtoolTxStartFrequencySplit_A9571_UILabel
		{
			get
			{
				short num = (short)614006784;
				short num2 = num;
				num = (short)1219122905;
				short num3 = num;
				num = (short)1166628569;
				switch (num3 == num)
				{
				}
				num = (short)480313345;
				if (num != 0)
				{
				}
				num = (short)705888256;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxStartFrequencySplit_A9571.UIName;
			}
		}

		// Token: 0x170020CB RID: 8395
		// (get) Token: 0x06004014 RID: 16404 RVA: 0x003C2098 File Offset: 0x003C0298
		// (set) Token: 0x06004015 RID: 16405 RVA: 0x003C214C File Offset: 0x003C034C
		internal bool RadWideLabtoolTxStartFrequencySplit_A9571_HiddenStatic
		{
			get
			{
				short num = (short)641531904;
				short num2 = num;
				num = (short)49584747;
				short num3 = num;
				num = (short)287873643;
				switch (num3 == num)
				{
				}
				num = (short)1360658433;
				if (num != 0)
				{
				}
				num = (short)2144337920;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxStartFrequencySplit_A9571.HiddenStatic;
			}
			set
			{
				short num = (short)1894580224;
				short num2 = num;
				num = (short)940265163;
				short num3 = num;
				num = (short)2067025611;
				switch (num3 == num)
				{
				}
				num = (short)1306329089;
				if (num != 0)
				{
				}
				num = (short)1415118848;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxStartFrequencySplit_A9571.HiddenStatic = value;
			}
		}

		// Token: 0x170020CC RID: 8396
		// (get) Token: 0x06004016 RID: 16406 RVA: 0x003C2200 File Offset: 0x003C0400
		// (set) Token: 0x06004017 RID: 16407 RVA: 0x003C22B4 File Offset: 0x003C04B4
		internal bool RadWideLabtoolTxStartFrequencySplit_A9571_HiddenDynamic
		{
			get
			{
				short num = (short)1901264896;
				short num2 = num;
				num = (short)1835823314;
				short num3 = num;
				num = (short)1995731154;
				switch (num3 == num)
				{
				}
				num = (short)1282473985;
				if (num != 0)
				{
				}
				num = (short)1803550720;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxStartFrequencySplit_A9571.HiddenDynamic;
			}
			set
			{
				short num = (short)912326656;
				short num2 = num;
				num = (short)485369001;
				short num3 = num;
				num = (short)2078549161;
				switch (num3 == num)
				{
				}
				num = (short)1704656897;
				if (num != 0)
				{
				}
				num = (short)1651834880;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxStartFrequencySplit_A9571.HiddenDynamic = value;
			}
		}

		// Token: 0x170020CD RID: 8397
		// (get) Token: 0x06004018 RID: 16408 RVA: 0x003C2368 File Offset: 0x003C0568
		public bool RadWideLabtoolTxStartFrequencySplit_A9571_HasDiffs
		{
			get
			{
				short num = (short)873398272;
				short num2 = num;
				num = (short)1886374573;
				short num3 = num;
				num = (short)1593166509;
				switch (num3 == num)
				{
				}
				num = (short)1492975616;
				if (num != 0)
				{
				}
				num = (short)296747009;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxStartFrequencySplit_A9571._HasDiffs;
			}
		}

		// Token: 0x170020CE RID: 8398
		// (get) Token: 0x06004019 RID: 16409 RVA: 0x003C241C File Offset: 0x003C061C
		// (set) Token: 0x0600401A RID: 16410 RVA: 0x003C24D0 File Offset: 0x003C06D0
		public string RadWideLabtoolTxBandSplitName_A24799Value
		{
			get
			{
				short num = (short)491257856;
				short num2 = num;
				num = (short)1940288573;
				short num3 = num;
				num = (short)827618365;
				switch (num3 == num)
				{
				}
				num = (short)1145503745;
				if (num != 0)
				{
				}
				num = (short)1672544256;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxBandSplitName_A24799.Value;
			}
			set
			{
				short num = (short)583794688;
				short num2 = num;
				num = (short)931217960;
				short num3 = num;
				num = (short)462242344;
				switch (num3 == num)
				{
				}
				num = (short)1170997249;
				if (num != 0)
				{
				}
				num = (short)686948352;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxBandSplitName_A24799.Value = value;
			}
		}

		// Token: 0x170020CF RID: 8399
		// (get) Token: 0x0600401B RID: 16411 RVA: 0x003C2588 File Offset: 0x003C0788
		public global::AcpBusinessLayer.AcpField<string> RadWideLabtoolTxBandSplitName_A24799
		{
			get
			{
				short num = (short)806092800;
				short num2 = num;
				num = (short)442603475;
				short num3 = num;
				num = (short)1301387219;
				switch (num3 == num)
				{
				}
				num = (short)1551302656;
				if (num != 0)
				{
				}
				num = (short)1041825793;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxBandSplitName_A24799;
			}
		}

		// Token: 0x170020D0 RID: 8400
		// (get) Token: 0x0600401C RID: 16412 RVA: 0x003C2638 File Offset: 0x003C0838
		// (set) Token: 0x0600401D RID: 16413 RVA: 0x003C26F0 File Offset: 0x003C08F0
		public string RadWideLabtoolTxBandSplitName_A24799_UIValue
		{
			get
			{
				short num = (short)388038656;
				short num2 = num;
				num = (short)312869897;
				short num3 = num;
				num = (short)519046153;
				switch (num3 == num)
				{
				}
				num = (short)1645215745;
				if (num != 0)
				{
				}
				num = (short)913965056;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxBandSplitName_A24799.Value;
			}
			set
			{
				short num = (short)1821048832;
				short num2 = num;
				num = (short)679977298;
				short num3 = num;
				num = (short)502767954;
				switch (num3 == num)
				{
				}
				num = (short)563216385;
				if (num != 0)
				{
				}
				num = (short)99352576;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxBandSplitName_A24799.Value = value;
			}
		}

		// Token: 0x170020D1 RID: 8401
		// (get) Token: 0x0600401E RID: 16414 RVA: 0x003C27A8 File Offset: 0x003C09A8
		// (set) Token: 0x0600401F RID: 16415 RVA: 0x003C285C File Offset: 0x003C0A5C
		public bool RadWideLabtoolTxBandSplitName_A24799_Applicable
		{
			get
			{
				short num = (short)1055981568;
				short num2 = num;
				num = (short)700893548;
				short num3 = num;
				num = (short)1252051308;
				switch (num3 == num)
				{
				}
				num = (short)1906573313;
				if (num != 0)
				{
				}
				num = (short)586219520;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxBandSplitName_A24799.Applicable;
			}
			set
			{
				short num = (short)1349451776;
				short num2 = num;
				num = (short)1193723938;
				short num3 = num;
				num = (short)1532151842;
				switch (num3 == num)
				{
				}
				num = (short)1523777537;
				if (num != 0)
				{
				}
				num = (short)1608056832;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxBandSplitName_A24799.Applicable = value;
			}
		}

		// Token: 0x170020D2 RID: 8402
		// (get) Token: 0x06004020 RID: 16416 RVA: 0x003C2910 File Offset: 0x003C0B10
		// (set) Token: 0x06004021 RID: 16417 RVA: 0x003C29C4 File Offset: 0x003C0BC4
		public bool RadWideLabtoolTxBandSplitName_A24799_Valid
		{
			get
			{
				short num = (short)560332800;
				short num2 = num;
				num = (short)1478838229;
				short num3 = num;
				num = (short)1081624533;
				switch (num3 == num)
				{
				}
				num = (short)1329397761;
				if (num != 0)
				{
				}
				num = (short)1986134016;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxBandSplitName_A24799.Valid;
			}
			set
			{
				short num = (short)1156513792;
				short num2 = num;
				num = (short)1740898305;
				if (num != 0)
				{
				}
				num = (short)363633405;
				short num3 = num;
				num = (short)1506712317;
				switch (num3 == num)
				{
				}
				num = (short)1683292160;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxBandSplitName_A24799.Valid = value;
			}
		}

		// Token: 0x170020D3 RID: 8403
		// (get) Token: 0x06004022 RID: 16418 RVA: 0x003C2A7C File Offset: 0x003C0C7C
		// (set) Token: 0x06004023 RID: 16419 RVA: 0x003C2B34 File Offset: 0x003C0D34
		public bool RadWideLabtoolTxBandSplitName_A24799_Visible
		{
			get
			{
				short num = (short)874315776;
				short num2 = num;
				num = (short)1652948993;
				if (num != 0)
				{
				}
				num = (short)1680862258;
				short num3 = num;
				num = (short)679144498;
				switch (num3 == num)
				{
				}
				num = (short)1295450112;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxBandSplitName_A24799.Visible;
			}
			set
			{
				short num = (short)748748800;
				short num2 = num;
				num = (short)1035538872;
				short num3 = num;
				num = (short)1419448760;
				switch (num3 == num)
				{
				}
				num = (short)1689845760;
				if (num != 0)
				{
				}
				num = (short)403243009;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxBandSplitName_A24799.Visible = value;
			}
		}

		// Token: 0x170020D4 RID: 8404
		// (get) Token: 0x06004024 RID: 16420 RVA: 0x003C2BEC File Offset: 0x003C0DEC
		// (set) Token: 0x06004025 RID: 16421 RVA: 0x003C2CA4 File Offset: 0x003C0EA4
		public bool RadWideLabtoolTxBandSplitName_A24799_Editable
		{
			get
			{
				short num = (short)1178468352;
				short num2 = num;
				num = (short)437300574;
				short num3 = num;
				num = (short)1441508702;
				switch (num3 == num)
				{
				}
				num = (short)1432354817;
				if (num != 0)
				{
				}
				num = (short)600571904;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxBandSplitName_A24799.Editable;
			}
			set
			{
				short num = (short)1070006272;
				short num2 = num;
				num = (short)1206746944;
				short num3 = num;
				num = (short)757301056;
				switch (num3 == num)
				{
				}
				num = (short)342032385;
				if (num != 0)
				{
				}
				num = (short)950796288;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxBandSplitName_A24799.Editable = value;
			}
		}

		// Token: 0x170020D5 RID: 8405
		// (get) Token: 0x06004026 RID: 16422 RVA: 0x003C2D5C File Offset: 0x003C0F5C
		internal string RadWideLabtoolTxBandSplitName_A24799_UILabel
		{
			get
			{
				short num = (short)1440677888;
				short num2 = num;
				num = (short)1602733493;
				short num3 = num;
				num = (short)1300481461;
				switch (num3 == num)
				{
				}
				num = (short)459997185;
				if (num != 0)
				{
				}
				num = (short)2078408704;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxBandSplitName_A24799.UIName;
			}
		}

		// Token: 0x170020D6 RID: 8406
		// (get) Token: 0x06004027 RID: 16423 RVA: 0x003C2E10 File Offset: 0x003C1010
		// (set) Token: 0x06004028 RID: 16424 RVA: 0x003C2EC4 File Offset: 0x003C10C4
		internal bool RadWideLabtoolTxBandSplitName_A24799_HiddenStatic
		{
			get
			{
				short num = (short)1187708928;
				short num2 = num;
				num = (short)1118013694;
				short num3 = num;
				num = (short)932940030;
				switch (num3 == num)
				{
				}
				num = (short)644939777;
				if (num != 0)
				{
				}
				num = (short)1658585088;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxBandSplitName_A24799.HiddenStatic;
			}
			set
			{
				short num = (short)1731592192;
				short num2 = num;
				num = (short)1596871341;
				short num3 = num;
				num = (short)268718765;
				switch (num3 == num)
				{
				}
				num = (short)1753022465;
				if (num != 0)
				{
				}
				num = (short)1683095552;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxBandSplitName_A24799.HiddenStatic = value;
			}
		}

		// Token: 0x170020D7 RID: 8407
		// (get) Token: 0x06004029 RID: 16425 RVA: 0x003C2F78 File Offset: 0x003C1178
		// (set) Token: 0x0600402A RID: 16426 RVA: 0x003C302C File Offset: 0x003C122C
		internal bool RadWideLabtoolTxBandSplitName_A24799_HiddenDynamic
		{
			get
			{
				short num = (short)2108293120;
				short num2 = num;
				num = (short)1299054593;
				if (num != 0)
				{
				}
				num = (short)1176990018;
				short num3 = num;
				num = (short)311062850;
				switch (num3 == num)
				{
				}
				num = (short)1718681600;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxBandSplitName_A24799.HiddenDynamic;
			}
			set
			{
				short num = (short)1151598592;
				short num2 = num;
				num = (short)739743346;
				short num3 = num;
				num = (short)1600755314;
				switch (num3 == num)
				{
				}
				num = (short)1339949057;
				if (num != 0)
				{
				}
				num = (short)657063936;
				if (num != 0)
				{
				}
				this.radWideLabtoolTxBandSplitName_A24799.HiddenDynamic = value;
			}
		}

		// Token: 0x170020D8 RID: 8408
		// (get) Token: 0x0600402B RID: 16427 RVA: 0x003C30E4 File Offset: 0x003C12E4
		public bool RadWideLabtoolTxBandSplitName_A24799_HasDiffs
		{
			get
			{
				short num = (short)2109145088;
				short num2 = num;
				num = (short)1515212455;
				short num3 = num;
				num = (short)1920945831;
				switch (num3 == num)
				{
				}
				num = (short)351797248;
				if (num != 0)
				{
				}
				num = (short)478478337;
				if (num != 0)
				{
				}
				return this.radWideLabtoolTxBandSplitName_A24799._HasDiffs;
			}
		}

		// Token: 0x0600402C RID: 16428 RVA: 0x003C3198 File Offset: 0x003C1398
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)978124671;
						short num3 = num2;
						num2 = (short)860684159;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4D;
						default:
						{
							num2 = (short)668073984;
							if (num2 != 0)
							{
							}
							num2 = (short)2042757120;
							short num4 = num2;
							if (base.ParentRecset != null)
							{
								num2 = (short)822280193;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return result;
						}
						}
						break;
					}
					case 1:
						num2 = (short)2040659971;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1252065284;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)1272053762;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 4:
						return result;
					}
					goto IL_24;
				}
				return result;
			}
			IL_24:
			num2 = (short)1114243073;
			if (num2 != 0)
			{
			}
			result = null;
			IL_4D:
			num2 = (short)1617297408;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040019FE RID: 6654
		private global::AcpBusinessLayer.AcpFrequencyField radWideLabtoolTxEndFrequencySplit_A9532;

		// Token: 0x040019FF RID: 6655
		private global::AcpBusinessLayer.AcpFrequencyField radWideLabtoolTxStartFrequencySplit_A9571;

		// Token: 0x04001A00 RID: 6656
		private global::AcpBusinessLayer.AcpField<string> radWideLabtoolTxBandSplitName_A24799;
	}
}
