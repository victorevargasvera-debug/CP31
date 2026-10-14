using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Features.Converters;

namespace Motorola.MackinawCPS.CoreFeatures.ScanList
{
	// Token: 0x0200010F RID: 271
	[global::System.Serializable]
	public class Advanced : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060027E4 RID: 10212 RVA: 0x0026B380 File Offset: 0x00269580
		public Advanced(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x0026B39C File Offset: 0x0026959C
		protected Advanced(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x0026B3B4 File Offset: 0x002695B4
		public override void Init()
		{
			int a_ = 1;
			short num = (short)1878917120;
			short num2 = num;
			num = (short)1623851009;
			if (num != 0)
			{
			}
			num = (short)1847115111;
			short num3 = num;
			num = (short)2049424743;
			switch (num3 == num)
			{
			}
			num = (short)1950941184;
			if (num != 0)
			{
			}
			this.scanLstAdvancedDisplayStrongestVotedChannel_A7884 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍量뛑ꋓ럕뛗맙맛뫝ꓟ诡韣雥蓧诩闫뷭蓯胱鯳飵鿷鿹迻諽囿洁瀃挅氇䤉搋漍縏簑焓稕䜗嬙⬛☝᠟ᘡ", a_), global::CommonResources.AcgResources.ID_DISPLAYSTRONGESTVOTEDCHANNEL);
			this.scanLstAdvancedDisplayStrongestVotedChannel_A7884.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.scanLstAdvancedDisplayStrongestVotedChannel_A7884.DataTransferOrder = 15;
			this.scanLstAdvancedTxSteering_A9572 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍量뛑ꋓ럕뛗맙맛뫝듟髡럣鋥跧迩黫蟭黯闱꯳럵쇷쿹쯻쳽", a_), global::CommonResources.AcgResources.ID_TXSTEERING);
			this.scanLstAdvancedTxSteering_A9572.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.scanLstAdvancedTxSteering_A9572.DataTransferOrder = 4;
			this.scanLstAdvancedVotingScanDelayTimerMs_A9657 = new global::AcpBusinessLayer.AcpRangeField<int, string>(0, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍量뛑ꋓ럕뛗맙맛뫝뛟跡郣迥蛧跩뿫跭釯鳱냳鏵铷鯹藻꫽槿漁愃琅䔇礉匋伍⤏␑ℓℕ", a_), global::CommonResources.AcgResources.ID_VOTINGSCANDELAYTIMER, 0, 255, 5);
			this.scanLstAdvancedVotingScanDelayTimerMs_A9657.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.scanLstAdvancedVotingScanDelayTimerMs_A9657.DataTransferOrder = 17;
			this.scanLstAdvancedVotingScanDelayTimerMs_A9657.ShowHexValue = false;
			this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍量뛑ꋓ럕뛗맙맛뫝ꓟ菡郣蟥볧鋩ꃫ蟭鷯鯱胳鏵鳷꫹鷻諽槿朁樃攅洇帉攋挍甏怑礓攕䜗嬙⬛⤝᤟ᬡ", a_), global::CommonResources.AcgResources.ID_DATATXLIMITEDPATIENCETIMERMS, 0, 255, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 1);
			this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.DataTransferOrder = 18;
			this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.ShowHexValue = false;
			this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍量뛑ꋓ럕뛗맙맛뫝귟诡鳣菥賧ꧩ菫胭蛯ꓱ鯳苵鷷꧹鿻鿽滿䬁樃朅欇縉攋砍礏昑洓䈕焗眙礛氝缟挡ᜣḥἧᠩᠫ", a_), global::CommonResources.AcgResources.ID_MIXEDCONVENTIONALVOTESCANINACTIVITYTIMERMIN, 1, 255, null, null, 0, 1);
			this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.DataTransferOrder = 25;
			this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菁ꃃ냅꧇꓉꿋ꯍ듏", a_);
			base.Id = 10130;
			base.UIName = global::CommonResources.AcgResources.ID_ADVANCED;
			base.DataTransferOrder = 2;
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x0026B600 File Offset: 0x00269800
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 9;
			short num = (short)854851592;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_9C;
				case 1:
					this.scanLstAdvancedVotingScanDelayTimerMs_A9657 = new global::AcpBusinessLayer.AcpRangeField<int, string>(0, new global::Features.Converters.UnpackAndPackRangeTextBoxSpinnerFields(), this, global::AllFeatures.CodeplugGuid.b("駉꿋꿍뻏黑ꟓꋕ駗뻙ꫛ뿝軟臡臣若뻧藩飫蟭黯闱ꟳ闵駷铹룻鯽泿持紃刅愇有椋簍崏愑䬓圕℗Ⱉ⤛⤝", a_), global::CommonResources.AcgResources.ID_VOTINGSCANDELAYTIMER);
					this.scanLstAdvancedVotingScanDelayTimerMs_A9657.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.scanLstAdvancedVotingScanDelayTimerMs_A9657.DataTransferOrder = 17;
					this.scanLstAdvancedVotingScanDelayTimerMs_A9657.ShowHexValue = false;
					num = (short)1169096705;
					if (num != 0)
					{
					}
					num = (short)1393491968;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)885850121;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_31E;
				case 4:
					goto IL_180;
				case 5:
				{
					num = (short)1074163151;
					short num3 = num;
					num = (short)127167951;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_199;
					default:
						num = (short)1550843904;
						if (num != 0)
						{
						}
						this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("駉꿋꿍뻏黑ꟓꋕ駗뻙ꫛ뿝軟臡臣若곧诩飫迭ꓯ諱룳鿵闷鏹裻鯽擿刁攃爅愇漉戋洍甏䘑紓笕紗栙焛洝缟挡ጣᄥᄧጩ", a_), global::CommonResources.AcgResources.ID_DATATXLIMITEDPATIENCETIMERMS, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 1);
						this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
						this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.DataTransferOrder = 18;
						this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.ShowHexValue = false;
						num = (short)1399717892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					goto IL_199;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駉꿋꿍뻏黑ꟓꋕ駗뻙ꫛ뿝軟臡臣若뻧藩飫蟭黯闱ꟳ闵駷铹룻鯽泿持紃刅愇有椋簍崏愑䬓圕℗Ⱉ⤛⤝", a_)))
					{
						num = (short)1035468801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9C;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_79;
					}
					continue;
				case 9:
					if (producerFields != null)
					{
						num = (short)423297038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4D5;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駉꿋꿍뻏黑ꟓꋕ駗뻙ꫛ뿝軟臡臣若곧菩鿫黭鳯鏱跳ꗵ賷裹鏻都柿朁眃爅帇攉砋欍琏儑簓眕瘗琙礛爝缟挡ጣḥဧḩ", a_)))
					{
						num = (short)13959181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_45D;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駉꿋꿍뻏黑ꟓꋕ駗뻙ꫛ뿝軟臡臣若곧诩飫迭ꓯ諱룳鿵闷鏹裻鯽擿刁攃爅愇漉戋洍甏䘑紓笕紗栙焛洝缟挡ጣᄥᄧጩ", a_)))
					{
						num = (short)1208221701;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_180;
				case 12:
					this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("駉꿋꿍뻏黑ꟓꋕ駗뻙ꫛ뿝軟臡臣若ꗧ菩铫语铯뇱鯳飵軷곹鏻諽旿儁會朅昇䌉戋漍猏昑紓怕焗渙攛䨝䤟伡䄣吥眧欩Ἣᘭܯ13", a_), global::CommonResources.AcgResources.ID_MIXEDCONVENTIONALVOTESCANINACTIVITYTIMERMIN, null, null, 0, 1);
					this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.DataTransferOrder = 25;
					this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.ShowHexValue = false;
					num = (short)654442499;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					this.scanLstAdvancedDisplayStrongestVotedChannel_A7884 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("駉꿋꿍뻏黑ꟓꋕ駗뻙ꫛ뿝軟臡臣若곧菩鿫黭鳯鏱跳ꗵ賷裹鏻都柿朁眃爅帇攉砋欍琏儑簓眕瘗琙礛爝缟挡ጣḥဧḩ", a_), global::CommonResources.AcgResources.ID_DISPLAYSTRONGESTVOTEDCHANNEL);
					this.scanLstAdvancedDisplayStrongestVotedChannel_A7884.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.scanLstAdvancedDisplayStrongestVotedChannel_A7884.DataTransferOrder = 15;
					num = (short)300810256;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					num = (short)1355481098;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_E9;
				case 16:
					goto IL_45D;
				case 17:
				{
					num = (short)559284224;
					short num4 = num;
					this.scanLstAdvancedTxSteering_A9572 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駉꿋꿍뻏黑ꟓꋕ駗뻙ꫛ뿝軟臡臣若볧鋩뿫髭闯韱蛳鿵雷鷹ꏻ뿽㧿㜁㌃㐅", a_), global::CommonResources.AcgResources.ID_TXSTEERING);
					this.scanLstAdvancedTxSteering_A9572.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.scanLstAdvancedTxSteering_A9572.DataTransferOrder = 4;
					num = (short)1776484367;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駉꿋꿍뻏黑ꟓꋕ駗뻙ꫛ뿝軟臡臣若볧鋩뿫髭闯韱蛳鿵雷鷹ꏻ뿽㧿㜁㌃㐅", a_)))
					{
						num = (short)35520529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E9;
				}
				IL_79:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)291635202;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9C:
				num = (short)671023115;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E9:
				num = (short)844890119;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_180:
				num = (short)569311238;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_199:
				if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駉꿋꿍뻏黑ꟓꋕ駗뻙ꫛ뿝軟臡臣若ꗧ菩铫语铯뇱鯳飵軷곹鏻諽旿儁會朅昇䌉戋漍猏昑紓怕焗渙攛䨝䤟伡䄣吥眧欩Ἣᘭܯ13", a_)))
				{
					num = (short)1109393420;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_45D:
				num = (short)1093074962;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_31E:
			IL_4D5:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("诉꣋룍뇏병럓돕볗", a_);
			base.Id = 10130;
			base.UIName = global::CommonResources.AcgResources.ID_ADVANCED;
			base.DataTransferOrder = 2;
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x0026BB14 File Offset: 0x00269D14
		public override void PopulateReferences()
		{
			short num = (short)1735878996;
			short num2 = num;
			num = (short)99051860;
			switch (num2 == num)
			{
			}
			num = (short)1603141633;
			if (num != 0)
			{
			}
			num = (short)367198208;
			if (num != 0)
			{
			}
			num = (short)1226047488;
			short num3 = num;
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x0026BBBC File Offset: 0x00269DBC
		public override void DropReferences()
		{
			short num = (short)1778875139;
			short num2 = num;
			num = (short)1701214979;
			switch (num2 == num)
			{
			}
			num = (short)1337720833;
			if (num != 0)
			{
			}
			num = (short)206110720;
			if (num != 0)
			{
			}
			num = (short)1162477568;
			short num3 = num;
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x0026BC68 File Offset: 0x00269E68
		public override void SetConstraints()
		{
			short num = (short)2081801341;
			short num2 = num;
			num = (short)1541850237;
			switch (num2 == num)
			{
			}
			num = (short)674955265;
			if (num != 0)
			{
			}
			num = (short)1141833728;
			if (num != 0)
			{
			}
			num = (short)1644036096;
			short num3 = num;
			this.scanLstAdvancedDisplayStrongestVotedChannel_A7884.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConScanLstTypeIsVotingScanORConvScan);
			this.scanLstAdvancedTxSteering_A9572.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConScanLstTypeIsVotingScanORConvScan);
			this.scanLstAdvancedTxSteering_A9572.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConIsTxSteeringVisible);
			this.scanLstAdvancedVotingScanDelayTimerMs_A9657.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConScanLstTypeIsVotingScanORConvScan);
			this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConScanLstTypeIsCnvAndDataTxRxTypeIsNotNone);
			this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConScanListTypeIsConventional);
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x0026BD9C File Offset: 0x00269F9C
		public override void SetupDependencies()
		{
			short num = (short)1686423343;
			short num2 = num;
			num = (short)3786543;
			switch (num2 == num)
			{
			}
			num = (short)1367277569;
			if (num != 0)
			{
			}
			num = (short)521666560;
			if (num != 0)
			{
			}
			num = (short)472252416;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList;
			scanList.General.ScanLstGeneralScanType_A9058.AddDependentObject(this.scanLstAdvancedDisplayStrongestVotedChannel_A7884);
			scanList.General.ScanLstGeneralScanType_A9058.AddDependentObject(this.scanLstAdvancedTxSteering_A9572);
			scanList.General.ScanLstGeneralScanType_A9058.AddDependentObject(this.scanLstAdvancedVotingScanDelayTimerMs_A9657);
			scanList.General.ScanLstGeneralDesignatedDataTxRxType_A21525.AddDependentObject(this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799);
			scanList.General.ScanLstGeneralScanType_A9058.AddDependentObject(this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799);
			scanList.General.ScanLstGeneralScanType_A9058.AddDependentObject(this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724);
		}

		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x060027EC RID: 10220 RVA: 0x0026BEDC File Offset: 0x0026A0DC
		public bool HasDiffs
		{
			get
			{
				short num = (short)284039936;
				short num2 = num;
				num = (short)1971133184;
				switch (num2 == num)
				{
				}
				num = (short)706412545;
				if (num != 0)
				{
				}
				num = (short)1682505728;
				if (num != 0)
				{
				}
				num = (short)1980432384;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x060027ED RID: 10221 RVA: 0x0026BF90 File Offset: 0x0026A190
		// (set) Token: 0x060027EE RID: 10222 RVA: 0x0026C044 File Offset: 0x0026A244
		public bool ScanLstAdvancedDisplayStrongestVotedChannel_A7884Value
		{
			get
			{
				short num = (short)1717308336;
				short num2 = num;
				num = (short)367594416;
				switch (num2 == num)
				{
				}
				num = (short)356319233;
				if (num != 0)
				{
				}
				num = (short)2143617024;
				if (num != 0)
				{
				}
				num = (short)324796416;
				short num3 = num;
				return this.scanLstAdvancedDisplayStrongestVotedChannel_A7884.Value;
			}
			set
			{
				short num = (short)2062384876;
				short num2 = num;
				num = (short)1126596332;
				switch (num2 == num)
				{
				}
				num = (short)1813250049;
				if (num != 0)
				{
				}
				num = (short)1020592128;
				if (num != 0)
				{
				}
				num = (short)439418880;
				short num3 = num;
				this.scanLstAdvancedDisplayStrongestVotedChannel_A7884.Value = value;
			}
		}

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x060027EF RID: 10223 RVA: 0x0026C0FC File Offset: 0x0026A2FC
		public global::AcpBusinessLayer.AcpField<bool> ScanLstAdvancedDisplayStrongestVotedChannel_A7884
		{
			get
			{
				short num = (short)1227768944;
				short num2 = num;
				num = (short)787760240;
				switch (num2 == num)
				{
				}
				num = (short)38993921;
				if (num != 0)
				{
				}
				num = (short)434700288;
				if (num != 0)
				{
				}
				num = (short)2127167488;
				short num3 = num;
				return this.scanLstAdvancedDisplayStrongestVotedChannel_A7884;
			}
		}

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x060027F0 RID: 10224 RVA: 0x0026C1AC File Offset: 0x0026A3AC
		// (set) Token: 0x060027F1 RID: 10225 RVA: 0x0026C264 File Offset: 0x0026A464
		public bool ScanLstAdvancedDisplayStrongestVotedChannel_A7884_UIValue
		{
			get
			{
				short num = (short)1876426213;
				short num2 = num;
				num = (short)377880037;
				switch (num2 == num)
				{
				}
				num = (short)144375809;
				if (num != 0)
				{
				}
				num = (short)870187008;
				if (num != 0)
				{
				}
				num = (short)1955725312;
				short num3 = num;
				return this.scanLstAdvancedDisplayStrongestVotedChannel_A7884.Value;
			}
			set
			{
				short num = (short)2121138177;
				if (num != 0)
				{
				}
				num = (short)1554100229;
				short num2 = num;
				num = (short)949530629;
				switch (num2 == num)
				{
				}
				num = (short)67698688;
				if (num != 0)
				{
				}
				num = (short)209584128;
				short num3 = num;
				this.scanLstAdvancedDisplayStrongestVotedChannel_A7884.Value = value;
			}
		}

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x060027F2 RID: 10226 RVA: 0x0026C318 File Offset: 0x0026A518
		// (set) Token: 0x060027F3 RID: 10227 RVA: 0x0026C3CC File Offset: 0x0026A5CC
		public bool ScanLstAdvancedDisplayStrongestVotedChannel_A7884_Applicable
		{
			get
			{
				short num = (short)1237449084;
				short num2 = num;
				num = (short)1776286076;
				switch (num2 == num)
				{
				}
				num = (short)954925056;
				if (num != 0)
				{
				}
				num = (short)257490945;
				if (num != 0)
				{
				}
				num = (short)388431872;
				short num3 = num;
				return this.scanLstAdvancedDisplayStrongestVotedChannel_A7884.Applicable;
			}
			set
			{
				short num = (short)1170062761;
				short num2 = num;
				num = (short)879607209;
				switch (num2 == num)
				{
				}
				num = (short)1106509824;
				if (num != 0)
				{
				}
				num = (short)1496186881;
				if (num != 0)
				{
				}
				num = (short)468647936;
				short num3 = num;
				this.scanLstAdvancedDisplayStrongestVotedChannel_A7884.Applicable = value;
			}
		}

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x060027F4 RID: 10228 RVA: 0x0026C484 File Offset: 0x0026A684
		// (set) Token: 0x060027F5 RID: 10229 RVA: 0x0026C53C File Offset: 0x0026A73C
		public bool ScanLstAdvancedDisplayStrongestVotedChannel_A7884_Valid
		{
			get
			{
				short num = (short)1086279311;
				short num2 = num;
				num = (short)1628589711;
				switch (num2 == num)
				{
				}
				num = (short)82968576;
				if (num != 0)
				{
				}
				num = (short)389677057;
				if (num != 0)
				{
				}
				num = (short)387579904;
				short num3 = num;
				return this.scanLstAdvancedDisplayStrongestVotedChannel_A7884.Valid;
			}
			set
			{
				short num = (short)434108165;
				short num2 = num;
				num = (short)815855365;
				switch (num2 == num)
				{
				}
				num = (short)168361985;
				if (num != 0)
				{
				}
				num = (short)1624506368;
				if (num != 0)
				{
				}
				num = (short)1423835136;
				short num3 = num;
				this.scanLstAdvancedDisplayStrongestVotedChannel_A7884.Valid = value;
			}
		}

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x060027F6 RID: 10230 RVA: 0x0026C5F0 File Offset: 0x0026A7F0
		// (set) Token: 0x060027F7 RID: 10231 RVA: 0x0026C6A8 File Offset: 0x0026A8A8
		public bool ScanLstAdvancedDisplayStrongestVotedChannel_A7884_Visible
		{
			get
			{
				short num = (short)1140593918;
				short num2 = num;
				num = (short)1694307582;
				switch (num2 == num)
				{
				}
				num = (short)1125974016;
				if (num != 0)
				{
				}
				num = (short)1854144513;
				if (num != 0)
				{
				}
				num = (short)922877952;
				short num3 = num;
				return this.scanLstAdvancedDisplayStrongestVotedChannel_A7884.Visible;
			}
			set
			{
				short num = (short)1877037381;
				short num2 = num;
				num = (short)475025733;
				switch (num2 == num)
				{
				}
				num = (short)1932787713;
				if (num != 0)
				{
				}
				num = (short)2041184256;
				if (num != 0)
				{
				}
				num = (short)1978597376;
				short num3 = num;
				this.scanLstAdvancedDisplayStrongestVotedChannel_A7884.Visible = value;
			}
		}

		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x060027F8 RID: 10232 RVA: 0x0026C760 File Offset: 0x0026A960
		// (set) Token: 0x060027F9 RID: 10233 RVA: 0x0026C818 File Offset: 0x0026AA18
		public bool ScanLstAdvancedDisplayStrongestVotedChannel_A7884_Editable
		{
			get
			{
				short num = (short)1699938305;
				if (num != 0)
				{
				}
				num = (short)105308354;
				short num2 = num;
				num = (short)1205461186;
				switch (num2 == num)
				{
				}
				num = (short)124583936;
				if (num != 0)
				{
				}
				num = (short)996999168;
				short num3 = num;
				return this.scanLstAdvancedDisplayStrongestVotedChannel_A7884.Editable;
			}
			set
			{
				short num = (short)293520279;
				short num2 = num;
				num = (short)525321111;
				switch (num2 == num)
				{
				}
				num = (short)1357774848;
				if (num != 0)
				{
				}
				num = (short)253034497;
				if (num != 0)
				{
				}
				num = (short)1368064000;
				short num3 = num;
				this.scanLstAdvancedDisplayStrongestVotedChannel_A7884.Editable = value;
			}
		}

		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x060027FA RID: 10234 RVA: 0x0026C8D0 File Offset: 0x0026AAD0
		internal string ScanLstAdvancedDisplayStrongestVotedChannel_A7884_UILabel
		{
			get
			{
				short num = (short)1065137225;
				short num2 = num;
				num = (short)1820898377;
				switch (num2 == num)
				{
				}
				num = (short)782761984;
				if (num != 0)
				{
				}
				num = (short)329580545;
				if (num != 0)
				{
				}
				num = (short)1921712128;
				short num3 = num;
				return this.scanLstAdvancedDisplayStrongestVotedChannel_A7884.UIName;
			}
		}

		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x060027FB RID: 10235 RVA: 0x0026C984 File Offset: 0x0026AB84
		// (set) Token: 0x060027FC RID: 10236 RVA: 0x0026CA38 File Offset: 0x0026AC38
		internal bool ScanLstAdvancedDisplayStrongestVotedChannel_A7884_HiddenStatic
		{
			get
			{
				short num = (short)1704085681;
				short num2 = num;
				num = (short)2108246193;
				switch (num2 == num)
				{
				}
				num = (short)1200226305;
				if (num != 0)
				{
				}
				num = (short)1301020672;
				if (num != 0)
				{
				}
				num = (short)680853504;
				short num3 = num;
				return this.scanLstAdvancedDisplayStrongestVotedChannel_A7884.HiddenStatic;
			}
			set
			{
				short num = (short)1432027137;
				if (num != 0)
				{
				}
				num = (short)2033322462;
				short num2 = num;
				num = (short)705497566;
				switch (num2 == num)
				{
				}
				num = (short)1440284672;
				if (num != 0)
				{
				}
				num = (short)1123614720;
				short num3 = num;
				this.scanLstAdvancedDisplayStrongestVotedChannel_A7884.HiddenStatic = value;
			}
		}

		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x060027FD RID: 10237 RVA: 0x0026CAEC File Offset: 0x0026ACEC
		// (set) Token: 0x060027FE RID: 10238 RVA: 0x0026CBA0 File Offset: 0x0026ADA0
		internal bool ScanLstAdvancedDisplayStrongestVotedChannel_A7884_HiddenDynamic
		{
			get
			{
				short num = (short)2030436353;
				if (num != 0)
				{
				}
				num = (short)391354687;
				short num2 = num;
				num = (short)1599510847;
				switch (num2 == num)
				{
				}
				num = (short)1784610816;
				if (num != 0)
				{
				}
				num = (short)604307456;
				short num3 = num;
				return this.scanLstAdvancedDisplayStrongestVotedChannel_A7884.HiddenDynamic;
			}
			set
			{
				short num = (short)1553193241;
				short num2 = num;
				num = (short)316987673;
				switch (num2 == num)
				{
				}
				num = (short)2068185089;
				if (num != 0)
				{
				}
				num = (short)861339648;
				if (num != 0)
				{
				}
				num = (short)511180800;
				short num3 = num;
				this.scanLstAdvancedDisplayStrongestVotedChannel_A7884.HiddenDynamic = value;
			}
		}

		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x060027FF RID: 10239 RVA: 0x0026CC54 File Offset: 0x0026AE54
		public bool ScanLstAdvancedDisplayStrongestVotedChannel_A7884_HasDiffs
		{
			get
			{
				short num = (short)573767681;
				if (num != 0)
				{
				}
				num = (short)1753248923;
				short num2 = num;
				num = (short)1063089307;
				switch (num2 == num)
				{
				}
				num = (short)861536256;
				if (num != 0)
				{
				}
				num = (short)1420361728;
				short num3 = num;
				return this.scanLstAdvancedDisplayStrongestVotedChannel_A7884._HasDiffs;
			}
		}

		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x06002800 RID: 10240 RVA: 0x0026CD0C File Offset: 0x0026AF0C
		// (set) Token: 0x06002801 RID: 10241 RVA: 0x0026CDC0 File Offset: 0x0026AFC0
		public bool ScanLstAdvancedTxSteering_A9572Value
		{
			get
			{
				short num = (short)707714591;
				short num2 = num;
				num = (short)1713823263;
				switch (num2 == num)
				{
				}
				num = (short)896860161;
				if (num != 0)
				{
				}
				num = (short)1865023488;
				if (num != 0)
				{
				}
				num = (short)1097859072;
				short num3 = num;
				return this.scanLstAdvancedTxSteering_A9572.Value;
			}
			set
			{
				short num = (short)1197137912;
				short num2 = num;
				num = (short)1990778872;
				switch (num2 == num)
				{
				}
				num = (short)40042497;
				if (num != 0)
				{
				}
				num = (short)1316093952;
				if (num != 0)
				{
				}
				num = (short)132972544;
				short num3 = num;
				this.scanLstAdvancedTxSteering_A9572.Value = value;
			}
		}

		// Token: 0x17001407 RID: 5127
		// (get) Token: 0x06002802 RID: 10242 RVA: 0x0026CE7C File Offset: 0x0026B07C
		public global::AcpBusinessLayer.AcpField<bool> ScanLstAdvancedTxSteering_A9572
		{
			get
			{
				short num = (short)1046925804;
				short num2 = num;
				num = (short)2114245100;
				switch (num2 == num)
				{
				}
				num = (short)1183776768;
				if (num != 0)
				{
				}
				num = (short)1491927041;
				if (num != 0)
				{
				}
				num = (short)1857748992;
				short num3 = num;
				return this.scanLstAdvancedTxSteering_A9572;
			}
		}

		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x06002803 RID: 10243 RVA: 0x0026CF28 File Offset: 0x0026B128
		// (set) Token: 0x06002804 RID: 10244 RVA: 0x0026CFE0 File Offset: 0x0026B1E0
		public bool ScanLstAdvancedTxSteering_A9572_UIValue
		{
			get
			{
				short num = (short)301757626;
				short num2 = num;
				num = (short)141784250;
				switch (num2 == num)
				{
				}
				num = (short)158334977;
				if (num != 0)
				{
				}
				num = (short)59768832;
				if (num != 0)
				{
				}
				num = (short)1421082624;
				short num3 = num;
				return this.scanLstAdvancedTxSteering_A9572.Value;
			}
			set
			{
				short num = (short)795302244;
				short num2 = num;
				num = (short)1868323172;
				switch (num2 == num)
				{
				}
				num = (short)1346895873;
				if (num != 0)
				{
				}
				num = (short)1166671872;
				if (num != 0)
				{
				}
				num = (short)1893597184;
				short num3 = num;
				this.scanLstAdvancedTxSteering_A9572.Value = value;
			}
		}

		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x06002805 RID: 10245 RVA: 0x0026D098 File Offset: 0x0026B298
		// (set) Token: 0x06002806 RID: 10246 RVA: 0x0026D14C File Offset: 0x0026B34C
		public bool ScanLstAdvancedTxSteering_A9572_Applicable
		{
			get
			{
				short num = (short)1622802433;
				if (num != 0)
				{
				}
				num = (short)1398769870;
				short num2 = num;
				num = (short)57968846;
				switch (num2 == num)
				{
				}
				num = (short)141230080;
				if (num != 0)
				{
				}
				num = (short)1727135744;
				short num3 = num;
				return this.scanLstAdvancedTxSteering_A9572.Applicable;
			}
			set
			{
				short num = (short)490033961;
				short num2 = num;
				num = (short)1136022313;
				switch (num2 == num)
				{
				}
				num = (short)1072562177;
				if (num != 0)
				{
				}
				num = (short)1201864704;
				if (num != 0)
				{
				}
				num = (short)1826684928;
				short num3 = num;
				this.scanLstAdvancedTxSteering_A9572.Applicable = value;
			}
		}

		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x06002807 RID: 10247 RVA: 0x0026D204 File Offset: 0x0026B404
		// (set) Token: 0x06002808 RID: 10248 RVA: 0x0026D2B8 File Offset: 0x0026B4B8
		public bool ScanLstAdvancedTxSteering_A9572_Valid
		{
			get
			{
				short num = (short)1420034049;
				if (num != 0)
				{
				}
				num = (short)1667042463;
				short num2 = num;
				num = (short)1972636831;
				switch (num2 == num)
				{
				}
				num = (short)854261760;
				if (num != 0)
				{
				}
				num = (short)2007433216;
				short num3 = num;
				return this.scanLstAdvancedTxSteering_A9572.Valid;
			}
			set
			{
				short num = (short)2061926354;
				short num2 = num;
				num = (short)433356754;
				switch (num2 == num)
				{
				}
				num = (short)1478295552;
				if (num != 0)
				{
				}
				num = (short)74514433;
				if (num != 0)
				{
				}
				num = (short)525074432;
				short num3 = num;
				this.scanLstAdvancedTxSteering_A9572.Valid = value;
			}
		}

		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x06002809 RID: 10249 RVA: 0x0026D370 File Offset: 0x0026B570
		// (set) Token: 0x0600280A RID: 10250 RVA: 0x0026D428 File Offset: 0x0026B628
		public bool ScanLstAdvancedTxSteering_A9572_Visible
		{
			get
			{
				short num = (short)1862008833;
				if (num != 0)
				{
				}
				num = (short)1347333342;
				short num2 = num;
				num = (short)337751262;
				switch (num2 == num)
				{
				}
				num = (short)1315438592;
				if (num != 0)
				{
				}
				num = (short)259719168;
				short num3 = num;
				return this.scanLstAdvancedTxSteering_A9572.Visible;
			}
			set
			{
				short num = (short)1669935444;
				short num2 = num;
				num = (short)717566292;
				switch (num2 == num)
				{
				}
				num = (short)2121924609;
				if (num != 0)
				{
				}
				num = (short)1504509952;
				if (num != 0)
				{
				}
				num = (short)290258944;
				short num3 = num;
				this.scanLstAdvancedTxSteering_A9572.Visible = value;
			}
		}

		// Token: 0x1700140C RID: 5132
		// (get) Token: 0x0600280B RID: 10251 RVA: 0x0026D4E0 File Offset: 0x0026B6E0
		// (set) Token: 0x0600280C RID: 10252 RVA: 0x0026D598 File Offset: 0x0026B798
		public bool ScanLstAdvancedTxSteering_A9572_Editable
		{
			get
			{
				short num = (short)1351986553;
				short num2 = num;
				num = (short)605597049;
				switch (num2 == num)
				{
				}
				num = (short)2005204993;
				if (num != 0)
				{
				}
				num = (short)2034106368;
				if (num != 0)
				{
				}
				num = (short)407961600;
				short num3 = num;
				return this.scanLstAdvancedTxSteering_A9572.Editable;
			}
			set
			{
				short num = (short)113662494;
				short num2 = num;
				num = (short)2012961310;
				switch (num2 == num)
				{
				}
				num = (short)1145372672;
				if (num != 0)
				{
				}
				num = (short)1174929409;
				if (num != 0)
				{
				}
				num = (short)1629552640;
				short num3 = num;
				this.scanLstAdvancedTxSteering_A9572.Editable = value;
			}
		}

		// Token: 0x1700140D RID: 5133
		// (get) Token: 0x0600280D RID: 10253 RVA: 0x0026D650 File Offset: 0x0026B850
		internal string ScanLstAdvancedTxSteering_A9572_UILabel
		{
			get
			{
				short num = (short)1492123649;
				if (num != 0)
				{
				}
				num = (short)659469522;
				short num2 = num;
				num = (short)1412019410;
				switch (num2 == num)
				{
				}
				num = (short)395247616;
				if (num != 0)
				{
				}
				num = (short)31981568;
				short num3 = num;
				return this.scanLstAdvancedTxSteering_A9572.UIName;
			}
		}

		// Token: 0x1700140E RID: 5134
		// (get) Token: 0x0600280E RID: 10254 RVA: 0x0026D704 File Offset: 0x0026B904
		// (set) Token: 0x0600280F RID: 10255 RVA: 0x0026D7B8 File Offset: 0x0026B9B8
		internal bool ScanLstAdvancedTxSteering_A9572_HiddenStatic
		{
			get
			{
				short num = (short)920382887;
				short num2 = num;
				num = (short)1374285223;
				switch (num2 == num)
				{
				}
				num = (short)26214401;
				if (num != 0)
				{
				}
				num = (short)822673408;
				if (num != 0)
				{
				}
				num = (short)641335296;
				short num3 = num;
				return this.scanLstAdvancedTxSteering_A9572.HiddenStatic;
			}
			set
			{
				short num = (short)1528011118;
				short num2 = num;
				num = (short)1918736750;
				switch (num2 == num)
				{
				}
				num = (short)1878720513;
				if (num != 0)
				{
				}
				num = (short)1834287104;
				if (num != 0)
				{
				}
				num = (short)1027342336;
				short num3 = num;
				this.scanLstAdvancedTxSteering_A9572.HiddenStatic = value;
			}
		}

		// Token: 0x1700140F RID: 5135
		// (get) Token: 0x06002810 RID: 10256 RVA: 0x0026D86C File Offset: 0x0026BA6C
		// (set) Token: 0x06002811 RID: 10257 RVA: 0x0026D920 File Offset: 0x0026BB20
		internal bool ScanLstAdvancedTxSteering_A9572_HiddenDynamic
		{
			get
			{
				short num = (short)915063844;
				short num2 = num;
				num = (short)1915667492;
				switch (num2 == num)
				{
				}
				num = (short)5505024;
				if (num != 0)
				{
				}
				num = (short)1515257857;
				if (num != 0)
				{
				}
				num = (short)415629312;
				short num3 = num;
				return this.scanLstAdvancedTxSteering_A9572.HiddenDynamic;
			}
			set
			{
				short num = (short)1580924929;
				if (num != 0)
				{
				}
				num = (short)2028308983;
				short num2 = num;
				num = (short)952797687;
				switch (num2 == num)
				{
				}
				num = (short)360316928;
				if (num != 0)
				{
				}
				num = (short)1302134784;
				short num3 = num;
				this.scanLstAdvancedTxSteering_A9572.HiddenDynamic = value;
			}
		}

		// Token: 0x17001410 RID: 5136
		// (get) Token: 0x06002812 RID: 10258 RVA: 0x0026D9D8 File Offset: 0x0026BBD8
		public bool ScanLstAdvancedTxSteering_A9572_HasDiffs
		{
			get
			{
				short num = (short)1502548743;
				short num2 = num;
				num = (short)1586762503;
				switch (num2 == num)
				{
				}
				num = (short)1509752833;
				if (num != 0)
				{
				}
				num = (short)1331036160;
				if (num != 0)
				{
				}
				num = (short)587595776;
				short num3 = num;
				return this.scanLstAdvancedTxSteering_A9572._HasDiffs;
			}
		}

		// Token: 0x17001411 RID: 5137
		// (get) Token: 0x06002813 RID: 10259 RVA: 0x0026DA8C File Offset: 0x0026BC8C
		// (set) Token: 0x06002814 RID: 10260 RVA: 0x0026DB40 File Offset: 0x0026BD40
		public int ScanLstAdvancedVotingScanDelayTimerMs_A9657Value
		{
			get
			{
				short num = (short)421028973;
				short num2 = num;
				num = (short)754476141;
				switch (num2 == num)
				{
				}
				num = (short)283115521;
				if (num != 0)
				{
				}
				num = (short)1607925760;
				if (num != 0)
				{
				}
				num = (short)1419902976;
				short num3 = num;
				return this.scanLstAdvancedVotingScanDelayTimerMs_A9657.Value;
			}
			set
			{
				short num = (short)555745281;
				if (num != 0)
				{
				}
				num = (short)1366157070;
				short num2 = num;
				num = (short)1137960718;
				switch (num2 == num)
				{
				}
				num = (short)667615232;
				if (num != 0)
				{
				}
				num = (short)827457536;
				short num3 = num;
				this.scanLstAdvancedVotingScanDelayTimerMs_A9657.Value = value;
			}
		}

		// Token: 0x17001412 RID: 5138
		// (get) Token: 0x06002815 RID: 10261 RVA: 0x0026DBF8 File Offset: 0x0026BDF8
		public global::AcpBusinessLayer.AcpRangeField<int, string> ScanLstAdvancedVotingScanDelayTimerMs_A9657
		{
			get
			{
				short num = (short)211484673;
				if (num != 0)
				{
				}
				num = (short)671832357;
				short num2 = num;
				num = (short)1159026981;
				switch (num2 == num)
				{
				}
				num = (short)2078932992;
				if (num != 0)
				{
				}
				num = (short)1598554112;
				short num3 = num;
				return this.scanLstAdvancedVotingScanDelayTimerMs_A9657;
			}
		}

		// Token: 0x17001413 RID: 5139
		// (get) Token: 0x06002816 RID: 10262 RVA: 0x0026DCA8 File Offset: 0x0026BEA8
		// (set) Token: 0x06002817 RID: 10263 RVA: 0x0026DD60 File Offset: 0x0026BF60
		public string ScanLstAdvancedVotingScanDelayTimerMs_A9657_UIValue
		{
			get
			{
				short num = (short)1557957611;
				short num2 = num;
				num = (short)2045348843;
				switch (num2 == num)
				{
				}
				num = (short)966262785;
				if (num != 0)
				{
				}
				num = (short)1768554496;
				if (num != 0)
				{
				}
				num = (short)290717696;
				short num3 = num;
				return this.scanLstAdvancedVotingScanDelayTimerMs_A9657.UIValue;
			}
			set
			{
				short num = (short)1163449947;
				short num2 = num;
				num = (short)518116955;
				switch (num2 == num)
				{
				}
				num = (short)955711489;
				if (num != 0)
				{
				}
				num = (short)2118975488;
				if (num != 0)
				{
				}
				num = (short)647299072;
				short num3 = num;
				this.scanLstAdvancedVotingScanDelayTimerMs_A9657.UIValue = value;
			}
		}

		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x06002818 RID: 10264 RVA: 0x0026DE14 File Offset: 0x0026C014
		// (set) Token: 0x06002819 RID: 10265 RVA: 0x0026DEC8 File Offset: 0x0026C0C8
		internal int ScanLstAdvancedVotingScanDelayTimerMs_A9657Min
		{
			get
			{
				short num = (short)803385198;
				short num2 = num;
				num = (short)1401728878;
				switch (num2 == num)
				{
				}
				num = (short)1312096257;
				if (num != 0)
				{
				}
				num = (short)1411383296;
				if (num != 0)
				{
				}
				num = (short)380895232;
				short num3 = num;
				return this.scanLstAdvancedVotingScanDelayTimerMs_A9657.Min;
			}
			set
			{
				short num = (short)1776222209;
				if (num != 0)
				{
				}
				num = (short)812148057;
				short num2 = num;
				num = (short)1700554073;
				switch (num2 == num)
				{
				}
				num = (short)1349451776;
				if (num != 0)
				{
				}
				num = (short)1428750336;
				short num3 = num;
				this.scanLstAdvancedVotingScanDelayTimerMs_A9657.Min = value;
			}
		}

		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x0600281A RID: 10266 RVA: 0x0026DF7C File Offset: 0x0026C17C
		// (set) Token: 0x0600281B RID: 10267 RVA: 0x0026E030 File Offset: 0x0026C230
		internal int ScanLstAdvancedVotingScanDelayTimerMs_A9657Max
		{
			get
			{
				short num = (short)1246442843;
				short num2 = num;
				num = (short)1799435611;
				switch (num2 == num)
				{
				}
				num = (short)305790977;
				if (num != 0)
				{
				}
				num = (short)104071168;
				if (num != 0)
				{
				}
				num = (short)700186624;
				short num3 = num;
				return this.scanLstAdvancedVotingScanDelayTimerMs_A9657.Max;
			}
			set
			{
				short num = (short)348846029;
				short num2 = num;
				num = (short)360904653;
				switch (num2 == num)
				{
				}
				num = (short)486670336;
				if (num != 0)
				{
				}
				num = (short)126943233;
				if (num != 0)
				{
				}
				num = (short)1694367744;
				short num3 = num;
				this.scanLstAdvancedVotingScanDelayTimerMs_A9657.Max = value;
			}
		}

		// Token: 0x17001416 RID: 5142
		// (get) Token: 0x0600281C RID: 10268 RVA: 0x0026E0E4 File Offset: 0x0026C2E4
		// (set) Token: 0x0600281D RID: 10269 RVA: 0x0026E198 File Offset: 0x0026C398
		internal int ScanLstAdvancedVotingScanDelayTimerMs_A9657Step
		{
			get
			{
				short num = (short)1144239673;
				short num2 = num;
				num = (short)633648697;
				switch (num2 == num)
				{
				}
				num = (short)341245953;
				if (num != 0)
				{
				}
				num = (short)384892928;
				if (num != 0)
				{
				}
				num = (short)747896832;
				short num3 = num;
				return this.scanLstAdvancedVotingScanDelayTimerMs_A9657.StepSize;
			}
			set
			{
				short num = (short)824538293;
				short num2 = num;
				num = (short)1696494773;
				switch (num2 == num)
				{
				}
				num = (short)1134821376;
				if (num != 0)
				{
				}
				num = (short)1694760961;
				if (num != 0)
				{
				}
				num = (short)377028608;
				short num3 = num;
				this.scanLstAdvancedVotingScanDelayTimerMs_A9657.StepSize = value;
			}
		}

		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x0600281E RID: 10270 RVA: 0x0026E24C File Offset: 0x0026C44C
		// (set) Token: 0x0600281F RID: 10271 RVA: 0x0026E300 File Offset: 0x0026C500
		public bool ScanLstAdvancedVotingScanDelayTimerMs_A9657_Applicable
		{
			get
			{
				short num = (short)116876272;
				short num2 = num;
				num = (short)1740268528;
				switch (num2 == num)
				{
				}
				num = (short)71368704;
				if (num != 0)
				{
				}
				num = (short)1532821505;
				if (num != 0)
				{
				}
				num = (short)6291456;
				short num3 = num;
				return this.scanLstAdvancedVotingScanDelayTimerMs_A9657.Applicable;
			}
			set
			{
				short num = (short)1935593493;
				short num2 = num;
				num = (short)617730069;
				switch (num2 == num)
				{
				}
				num = (short)1468727297;
				if (num != 0)
				{
				}
				num = (short)1390149632;
				if (num != 0)
				{
				}
				num = (short)1800929280;
				short num3 = num;
				this.scanLstAdvancedVotingScanDelayTimerMs_A9657.Applicable = value;
			}
		}

		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x06002820 RID: 10272 RVA: 0x0026E3B8 File Offset: 0x0026C5B8
		// (set) Token: 0x06002821 RID: 10273 RVA: 0x0026E46C File Offset: 0x0026C66C
		public bool ScanLstAdvancedVotingScanDelayTimerMs_A9657_Valid
		{
			get
			{
				short num = (short)6070761;
				short num2 = num;
				num = (short)1838129641;
				switch (num2 == num)
				{
				}
				num = (short)36110336;
				short num3 = num;
				num = (short)1656094721;
				if (num != 0)
				{
				}
				num = (short)495583232;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedVotingScanDelayTimerMs_A9657.Valid;
			}
			set
			{
				short num = (short)527192033;
				short num2 = num;
				num = (short)1785614305;
				switch (num2 == num)
				{
				}
				num = (short)476774400;
				short num3 = num;
				num = (short)1930493953;
				if (num != 0)
				{
				}
				num = (short)1060175872;
				if (num != 0)
				{
				}
				this.scanLstAdvancedVotingScanDelayTimerMs_A9657.Valid = value;
			}
		}

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x06002822 RID: 10274 RVA: 0x0026E524 File Offset: 0x0026C724
		// (set) Token: 0x06002823 RID: 10275 RVA: 0x0026E5D8 File Offset: 0x0026C7D8
		public bool ScanLstAdvancedVotingScanDelayTimerMs_A9657_Visible
		{
			get
			{
				short num = (short)295233808;
				short num2 = num;
				num = (short)510060816;
				switch (num2 == num)
				{
				}
				num = (short)1073610752;
				short num3 = num;
				num = (short)713031681;
				if (num != 0)
				{
				}
				num = (short)1869283328;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedVotingScanDelayTimerMs_A9657.Visible;
			}
			set
			{
				short num = (short)946486023;
				short num2 = num;
				num = (short)1012873991;
				switch (num2 == num)
				{
				}
				num = (short)863043584;
				short num3 = num;
				num = (short)445251585;
				if (num != 0)
				{
				}
				num = (short)294977536;
				if (num != 0)
				{
				}
				this.scanLstAdvancedVotingScanDelayTimerMs_A9657.Visible = value;
			}
		}

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x06002824 RID: 10276 RVA: 0x0026E68C File Offset: 0x0026C88C
		// (set) Token: 0x06002825 RID: 10277 RVA: 0x0026E740 File Offset: 0x0026C940
		public bool ScanLstAdvancedVotingScanDelayTimerMs_A9657_Editable
		{
			get
			{
				short num = (short)734149060;
				short num2 = num;
				num = (short)1100036548;
				switch (num2 == num)
				{
				}
				num = (short)1156186112;
				short num3 = num;
				num = (short)1649934336;
				if (num != 0)
				{
				}
				num = (short)1124925441;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedVotingScanDelayTimerMs_A9657.Editable;
			}
			set
			{
				short num = (short)1267075633;
				short num2 = num;
				num = (short)473893425;
				switch (num2 == num)
				{
				}
				num = (short)497483776;
				short num3 = num;
				num = (short)1275396096;
				if (num != 0)
				{
				}
				num = (short)2097676289;
				if (num != 0)
				{
				}
				this.scanLstAdvancedVotingScanDelayTimerMs_A9657.Editable = value;
			}
		}

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x06002826 RID: 10278 RVA: 0x0026E7F8 File Offset: 0x0026C9F8
		internal string ScanLstAdvancedVotingScanDelayTimerMs_A9657_UILabel
		{
			get
			{
				short num = (short)303885068;
				short num2 = num;
				num = (short)1042017036;
				switch (num2 == num)
				{
				}
				num = (short)1373765632;
				short num3 = num;
				num = (short)2122055681;
				if (num != 0)
				{
				}
				num = (short)628097024;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedVotingScanDelayTimerMs_A9657.UIName;
			}
		}

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x06002827 RID: 10279 RVA: 0x0026E8B0 File Offset: 0x0026CAB0
		// (set) Token: 0x06002828 RID: 10280 RVA: 0x0026E964 File Offset: 0x0026CB64
		internal bool ScanLstAdvancedVotingScanDelayTimerMs_A9657_HiddenStatic
		{
			get
			{
				short num = (short)2005991425;
				if (num != 0)
				{
				}
				num = (short)125138199;
				short num2 = num;
				num = (short)1712354583;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1389166592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1027604480;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedVotingScanDelayTimerMs_A9657.HiddenStatic;
			}
			set
			{
				short num = (short)1461542107;
				short num2 = num;
				num = (short)118840539;
				switch (num2 == num)
				{
				}
				num = (short)52428800;
				short num3 = num;
				num = (short)301793280;
				if (num != 0)
				{
				}
				num = (short)24182785;
				if (num != 0)
				{
				}
				this.scanLstAdvancedVotingScanDelayTimerMs_A9657.HiddenStatic = value;
			}
		}

		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x06002829 RID: 10281 RVA: 0x0026EA18 File Offset: 0x0026CC18
		// (set) Token: 0x0600282A RID: 10282 RVA: 0x0026EAD0 File Offset: 0x0026CCD0
		internal bool ScanLstAdvancedVotingScanDelayTimerMs_A9657_HiddenDynamic
		{
			get
			{
				short num = (short)1066331357;
				short num2 = num;
				num = (short)1306127581;
				switch (num2 == num)
				{
				}
				num = (short)590020608;
				short num3 = num;
				num = (short)1649278977;
				if (num != 0)
				{
				}
				num = (short)1300365312;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedVotingScanDelayTimerMs_A9657.HiddenDynamic;
			}
			set
			{
				short num = (short)877280727;
				short num2 = num;
				num = (short)1989557719;
				switch (num2 == num)
				{
				}
				num = (short)1872166912;
				short num3 = num;
				num = (short)1645477888;
				if (num != 0)
				{
				}
				num = (short)1809645569;
				if (num != 0)
				{
				}
				this.scanLstAdvancedVotingScanDelayTimerMs_A9657.HiddenDynamic = value;
			}
		}

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x0600282B RID: 10283 RVA: 0x0026EB84 File Offset: 0x0026CD84
		public bool ScanLstAdvancedVotingScanDelayTimerMs_A9657_HasDiffs
		{
			get
			{
				short num = (short)1953997233;
				short num2 = num;
				num = (short)1629069745;
				switch (num2 == num)
				{
				}
				num = (short)684589056;
				short num3 = num;
				num = (short)702152704;
				if (num != 0)
				{
				}
				num = (short)1171849217;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedVotingScanDelayTimerMs_A9657._HasDiffs;
			}
		}

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x0600282C RID: 10284 RVA: 0x0026EC38 File Offset: 0x0026CE38
		// (set) Token: 0x0600282D RID: 10285 RVA: 0x0026ECF0 File Offset: 0x0026CEF0
		public int ScanLstAdvancedDataTxLimitedPatienceTimerms_A7799Value
		{
			get
			{
				short num = (short)365020593;
				short num2 = num;
				num = (short)1617216945;
				switch (num2 == num)
				{
				}
				num = (short)1233715200;
				short num3 = num;
				num = (short)1241907201;
				if (num != 0)
				{
				}
				num = (short)2039349248;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.Value;
			}
			set
			{
				short num = (short)415983492;
				short num2 = num;
				num = (short)1385457540;
				switch (num2 == num)
				{
				}
				num = (short)1667825664;
				short num3 = num;
				num = (short)2105737217;
				if (num != 0)
				{
				}
				num = (short)1047658496;
				if (num != 0)
				{
				}
				this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.Value = value;
			}
		}

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x0600282E RID: 10286 RVA: 0x0026EDA8 File Offset: 0x0026CFA8
		public global::AcpBusinessLayer.AcpSimpleRangeField ScanLstAdvancedDataTxLimitedPatienceTimerms_A7799
		{
			get
			{
				short num = (short)2113009447;
				short num2 = num;
				num = (short)1089140519;
				switch (num2 == num)
				{
				}
				num = (short)888274944;
				short num3 = num;
				num = (short)1724776449;
				if (num != 0)
				{
				}
				num = (short)912195584;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799;
			}
		}

		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x0600282F RID: 10287 RVA: 0x0026EE54 File Offset: 0x0026D054
		// (set) Token: 0x06002830 RID: 10288 RVA: 0x0026EF08 File Offset: 0x0026D108
		public string ScanLstAdvancedDataTxLimitedPatienceTimerms_A7799_UIValue
		{
			get
			{
				short num = (short)1212951535;
				short num2 = num;
				num = (short)1599613935;
				switch (num2 == num)
				{
				}
				num = (short)1940062208;
				short num3 = num;
				num = (short)1147666432;
				if (num != 0)
				{
				}
				num = (short)1689976833;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.UIValue;
			}
			set
			{
				short num = (short)2144916975;
				short num2 = num;
				num = (short)1062786543;
				switch (num2 == num)
				{
				}
				num = (short)686686208;
				short num3 = num;
				num = (short)1036845057;
				if (num != 0)
				{
				}
				num = (short)2113732608;
				if (num != 0)
				{
				}
				this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.UIValue = value;
			}
		}

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x06002831 RID: 10289 RVA: 0x0026EFBC File Offset: 0x0026D1BC
		// (set) Token: 0x06002832 RID: 10290 RVA: 0x0026F070 File Offset: 0x0026D270
		internal int ScanLstAdvancedDataTxLimitedPatienceTimerms_A7799Min
		{
			get
			{
				short num = (short)4332250;
				short num2 = num;
				num = (short)962140890;
				switch (num2 == num)
				{
				}
				num = (short)977797120;
				short num3 = num;
				num = (short)2021588993;
				if (num != 0)
				{
				}
				num = (short)9699328;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.Min;
			}
			set
			{
				short num = (short)1971422348;
				short num2 = num;
				num = (short)1162380428;
				switch (num2 == num)
				{
				}
				num = (short)535232512;
				short num3 = num;
				num = (short)1630797825;
				if (num != 0)
				{
				}
				num = (short)189595648;
				if (num != 0)
				{
				}
				this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.Min = value;
			}
		}

		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x06002833 RID: 10291 RVA: 0x0026F124 File Offset: 0x0026D324
		// (set) Token: 0x06002834 RID: 10292 RVA: 0x0026F1D8 File Offset: 0x0026D3D8
		internal int ScanLstAdvancedDataTxLimitedPatienceTimerms_A7799Max
		{
			get
			{
				short num = (short)1033142246;
				short num2 = num;
				num = (short)553353190;
				switch (num2 == num)
				{
				}
				num = (short)1167392768;
				short num3 = num;
				num = (short)758579200;
				if (num != 0)
				{
				}
				num = (short)1495007233;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.Max;
			}
			set
			{
				short num = (short)1580828216;
				short num2 = num;
				num = (short)1120699960;
				switch (num2 == num)
				{
				}
				num = (short)1370488832;
				short num3 = num;
				num = (short)273547265;
				if (num != 0)
				{
				}
				num = (short)1551171584;
				if (num != 0)
				{
				}
				this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.Max = value;
			}
		}

		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x06002835 RID: 10293 RVA: 0x0026F28C File Offset: 0x0026D48C
		// (set) Token: 0x06002836 RID: 10294 RVA: 0x0026F344 File Offset: 0x0026D544
		internal int ScanLstAdvancedDataTxLimitedPatienceTimerms_A7799Step
		{
			get
			{
				short num = (short)567702700;
				short num2 = num;
				num = (short)1884910764;
				switch (num2 == num)
				{
				}
				num = (short)1699348480;
				short num3 = num;
				num = (short)35389440;
				if (num != 0)
				{
				}
				num = (short)969539585;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.StepSize;
			}
			set
			{
				short num = (short)1032883596;
				short num2 = num;
				num = (short)1184730508;
				switch (num2 == num)
				{
				}
				num = (short)363921408;
				short num3 = num;
				num = (short)336855040;
				if (num != 0)
				{
				}
				num = (short)2091712513;
				if (num != 0)
				{
				}
				this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.StepSize = value;
			}
		}

		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x06002837 RID: 10295 RVA: 0x0026F3FC File Offset: 0x0026D5FC
		// (set) Token: 0x06002838 RID: 10296 RVA: 0x0026F4B0 File Offset: 0x0026D6B0
		public bool ScanLstAdvancedDataTxLimitedPatienceTimerms_A7799_Applicable
		{
			get
			{
				short num = (short)1672740865;
				if (num != 0)
				{
				}
				num = (short)1890551033;
				short num2 = num;
				num = (short)1566868729;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1463549952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)297926656;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.Applicable;
			}
			set
			{
				short num = (short)940135436;
				short num2 = num;
				num = (short)1477792780;
				switch (num2 == num)
				{
				}
				num = (short)2007367680;
				short num3 = num;
				num = (short)727252992;
				if (num != 0)
				{
				}
				num = (short)1860960257;
				if (num != 0)
				{
				}
				this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.Applicable = value;
			}
		}

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x06002839 RID: 10297 RVA: 0x0026F568 File Offset: 0x0026D768
		// (set) Token: 0x0600283A RID: 10298 RVA: 0x0026F624 File Offset: 0x0026D824
		public bool ScanLstAdvancedDataTxLimitedPatienceTimerms_A7799_Valid
		{
			get
			{
				short num = (short)888601489;
				short num2 = num;
				num = (short)1316420497;
				switch (num2 == num)
				{
				}
				num = (short)644022272;
				short num3 = num;
				num = (short)1747124225;
				if (num != 0)
				{
				}
				num = (short)140378112;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.Valid;
			}
			set
			{
				short num = (short)460244299;
				short num2 = num;
				num = (short)1023788363;
				switch (num2 == num)
				{
				}
				num = (short)1653997568;
				short num3 = num;
				num = (short)343539712;
				if (num != 0)
				{
				}
				num = (short)160563201;
				if (num != 0)
				{
				}
				this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.Valid = value;
			}
		}

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x0600283B RID: 10299 RVA: 0x0026F6DC File Offset: 0x0026D8DC
		// (set) Token: 0x0600283C RID: 10300 RVA: 0x0026F794 File Offset: 0x0026D994
		public bool ScanLstAdvancedDataTxLimitedPatienceTimerms_A7799_Visible
		{
			get
			{
				short num = (short)707982347;
				short num2 = num;
				num = (short)1391719435;
				switch (num2 == num)
				{
				}
				num = (short)2000748544;
				short num3 = num;
				num = (short)1545011201;
				if (num != 0)
				{
				}
				num = (short)826212352;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.Visible;
			}
			set
			{
				short num = (short)910447474;
				short num2 = num;
				num = (short)554652530;
				switch (num2 == num)
				{
				}
				num = (short)109772800;
				short num3 = num;
				num = (short)63373312;
				if (num != 0)
				{
				}
				num = (short)152371201;
				if (num != 0)
				{
				}
				this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.Visible = value;
			}
		}

		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x0600283D RID: 10301 RVA: 0x0026F848 File Offset: 0x0026DA48
		// (set) Token: 0x0600283E RID: 10302 RVA: 0x0026F8FC File Offset: 0x0026DAFC
		public bool ScanLstAdvancedDataTxLimitedPatienceTimerms_A7799_Editable
		{
			get
			{
				short num = (short)2130533212;
				short num2 = num;
				num = (short)872962908;
				switch (num2 == num)
				{
				}
				num = (short)1620312064;
				short num3 = num;
				num = (short)1092878337;
				if (num != 0)
				{
				}
				num = (short)800129024;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.Editable;
			}
			set
			{
				short num = (short)1552569957;
				short num2 = num;
				num = (short)1711494757;
				switch (num2 == num)
				{
				}
				num = (short)891748352;
				short num3 = num;
				num = (short)1227882496;
				if (num != 0)
				{
				}
				num = (short)1637875713;
				if (num != 0)
				{
				}
				this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.Editable = value;
			}
		}

		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x0600283F RID: 10303 RVA: 0x0026F9B0 File Offset: 0x0026DBB0
		internal string ScanLstAdvancedDataTxLimitedPatienceTimerms_A7799_UILabel
		{
			get
			{
				short num = (short)282918913;
				if (num != 0)
				{
				}
				num = (short)476515100;
				short num2 = num;
				num = (short)558631708;
				switch (num2 == num)
				{
				default:
				{
					num = (short)356646912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1931214848;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.UIName;
			}
		}

		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x06002840 RID: 10304 RVA: 0x0026FA68 File Offset: 0x0026DC68
		// (set) Token: 0x06002841 RID: 10305 RVA: 0x0026FB1C File Offset: 0x0026DD1C
		internal bool ScanLstAdvancedDataTxLimitedPatienceTimerms_A7799_HiddenStatic
		{
			get
			{
				short num = (short)481839341;
				short num2 = num;
				num = (short)1568164077;
				switch (num2 == num)
				{
				}
				num = (short)1704460288;
				short num3 = num;
				num = (short)1159266305;
				if (num != 0)
				{
				}
				num = (short)137101312;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.HiddenStatic;
			}
			set
			{
				short num = (short)496984382;
				short num2 = num;
				num = (short)2058117438;
				switch (num2 == num)
				{
				}
				num = (short)447152128;
				short num3 = num;
				num = (short)1924595713;
				if (num != 0)
				{
				}
				num = (short)1159659520;
				if (num != 0)
				{
				}
				this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.HiddenStatic = value;
			}
		}

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x06002842 RID: 10306 RVA: 0x0026FBD0 File Offset: 0x0026DDD0
		// (set) Token: 0x06002843 RID: 10307 RVA: 0x0026FC88 File Offset: 0x0026DE88
		internal bool ScanLstAdvancedDataTxLimitedPatienceTimerms_A7799_HiddenDynamic
		{
			get
			{
				short num = (short)1881475984;
				short num2 = num;
				num = (short)36178832;
				switch (num2 == num)
				{
				}
				num = (short)1064960000;
				short num3 = num;
				num = (short)583925760;
				if (num != 0)
				{
				}
				num = (short)193331201;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.HiddenDynamic;
			}
			set
			{
				short num = (short)601492028;
				short num2 = num;
				num = (short)258935356;
				switch (num2 == num)
				{
				}
				num = (short)1626865664;
				short num3 = num;
				num = (short)290979841;
				if (num != 0)
				{
				}
				num = (short)764870656;
				if (num != 0)
				{
				}
				this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799.HiddenDynamic = value;
			}
		}

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x06002844 RID: 10308 RVA: 0x0026FD40 File Offset: 0x0026DF40
		public bool ScanLstAdvancedDataTxLimitedPatienceTimerms_A7799_HasDiffs
		{
			get
			{
				short num = (short)1862847426;
				short num2 = num;
				num = (short)1422904258;
				switch (num2 == num)
				{
				}
				num = (short)1184563200;
				short num3 = num;
				num = (short)676462592;
				if (num != 0)
				{
				}
				num = (short)1576468481;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedDataTxLimitedPatienceTimerms_A7799._HasDiffs;
			}
		}

		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x06002845 RID: 10309 RVA: 0x0026FDF4 File Offset: 0x0026DFF4
		// (set) Token: 0x06002846 RID: 10310 RVA: 0x0026FEA8 File Offset: 0x0026E0A8
		public int ScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724Value
		{
			get
			{
				short num = (short)528396960;
				short num2 = num;
				num = (short)1368044192;
				switch (num2 == num)
				{
				}
				num = (short)780140544;
				short num3 = num;
				num = (short)1532887041;
				if (num != 0)
				{
				}
				num = (short)85852160;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.Value;
			}
			set
			{
				short num = (short)295591850;
				short num2 = num;
				num = (short)1899847594;
				switch (num2 == num)
				{
				}
				num = (short)2091057152;
				short num3 = num;
				num = (short)239206401;
				if (num != 0)
				{
				}
				num = (short)1176895488;
				if (num != 0)
				{
				}
				this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.Value = value;
			}
		}

		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x06002847 RID: 10311 RVA: 0x0026FF5C File Offset: 0x0026E15C
		public global::AcpBusinessLayer.AcpSimpleRangeField ScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724
		{
			get
			{
				short num = (short)782416370;
				short num2 = num;
				num = (short)2015803890;
				switch (num2 == num)
				{
				}
				num = (short)1976041472;
				short num3 = num;
				num = (short)166461440;
				if (num != 0)
				{
				}
				num = (short)628293633;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724;
			}
		}

		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x06002848 RID: 10312 RVA: 0x0027000C File Offset: 0x0026E20C
		// (set) Token: 0x06002849 RID: 10313 RVA: 0x002700C0 File Offset: 0x0026E2C0
		public string ScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724_UIValue
		{
			get
			{
				short num = (short)1470865130;
				short num2 = num;
				num = (short)310812394;
				switch (num2 == num)
				{
				}
				num = (short)62980096;
				short num3 = num;
				num = (short)723779585;
				if (num != 0)
				{
				}
				num = (short)1392902144;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.UIValue;
			}
			set
			{
				short num = (short)2027789807;
				short num2 = num;
				num = (short)659529199;
				switch (num2 == num)
				{
				}
				num = (short)1252589568;
				short num3 = num;
				num = (short)1625227265;
				if (num != 0)
				{
				}
				num = (short)985923584;
				if (num != 0)
				{
				}
				this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.UIValue = value;
			}
		}

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x0600284A RID: 10314 RVA: 0x00270174 File Offset: 0x0026E374
		// (set) Token: 0x0600284B RID: 10315 RVA: 0x0027022C File Offset: 0x0026E42C
		internal int ScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724Min
		{
			get
			{
				short num = (short)2090338193;
				short num2 = num;
				num = (short)1741883281;
				switch (num2 == num)
				{
				}
				num = (short)1506344960;
				short num3 = num;
				num = (short)638779393;
				if (num != 0)
				{
				}
				num = (short)1435041792;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.Min;
			}
			set
			{
				short num = (short)1413478960;
				short num2 = num;
				num = (short)1343617584;
				switch (num2 == num)
				{
				}
				num = (short)1959198720;
				short num3 = num;
				num = (short)201654273;
				if (num != 0)
				{
				}
				num = (short)1167917056;
				if (num != 0)
				{
				}
				this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.Min = value;
			}
		}

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x0600284C RID: 10316 RVA: 0x002702E0 File Offset: 0x0026E4E0
		// (set) Token: 0x0600284D RID: 10317 RVA: 0x00270398 File Offset: 0x0026E598
		internal int ScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724Max
		{
			get
			{
				short num = (short)675879758;
				short num2 = num;
				num = (short)1260985166;
				switch (num2 == num)
				{
				}
				num = (short)61997056;
				short num3 = num;
				num = (short)1532297217;
				if (num != 0)
				{
				}
				num = (short)1832255488;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.Max;
			}
			set
			{
				short num = (short)1384513536;
				short num2 = num;
				num = (short)747563578;
				short num3 = num;
				num = (short)589883962;
				switch (num3 == num)
				{
				}
				num = (short)1747189761;
				if (num != 0)
				{
				}
				num = (short)430899200;
				if (num != 0)
				{
				}
				this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.Max = value;
			}
		}

		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x0600284E RID: 10318 RVA: 0x00270450 File Offset: 0x0026E650
		// (set) Token: 0x0600284F RID: 10319 RVA: 0x00270504 File Offset: 0x0026E704
		internal int ScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724Step
		{
			get
			{
				short num = (short)437256192;
				short num2 = num;
				num = (short)51974313;
				short num3 = num;
				num = (short)2147225769;
				switch (num3 == num)
				{
				}
				num = (short)2041446400;
				if (num != 0)
				{
				}
				num = (short)1910112257;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.StepSize;
			}
			set
			{
				short num = (short)874971136;
				short num2 = num;
				num = (short)1406468097;
				if (num != 0)
				{
				}
				num = (short)2041137130;
				short num3 = num;
				num = (short)537937898;
				switch (num3 == num)
				{
				}
				num = (short)1735720960;
				if (num != 0)
				{
				}
				this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.StepSize = value;
			}
		}

		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x06002850 RID: 10320 RVA: 0x002705C0 File Offset: 0x0026E7C0
		// (set) Token: 0x06002851 RID: 10321 RVA: 0x00270674 File Offset: 0x0026E874
		public bool ScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724_Applicable
		{
			get
			{
				short num = (short)68812800;
				short num2 = num;
				num = (short)1521774129;
				short num3 = num;
				num = (short)1745120817;
				switch (num3 == num)
				{
				}
				num = (short)61669377;
				if (num != 0)
				{
				}
				num = (short)63897600;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.Applicable;
			}
			set
			{
				short num = (short)999292928;
				short num2 = num;
				num = (short)235211115;
				short num3 = num;
				num = (short)1281755499;
				switch (num3 == num)
				{
				}
				num = (short)328204289;
				if (num != 0)
				{
				}
				num = (short)218103808;
				if (num != 0)
				{
				}
				this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.Applicable = value;
			}
		}

		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x06002852 RID: 10322 RVA: 0x0027072C File Offset: 0x0026E92C
		// (set) Token: 0x06002853 RID: 10323 RVA: 0x002707E0 File Offset: 0x0026E9E0
		public bool ScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724_Valid
		{
			get
			{
				short num = (short)21037056;
				short num2 = num;
				num = (short)172237277;
				short num3 = num;
				num = (short)361505245;
				switch (num3 == num)
				{
				}
				num = (short)827129857;
				if (num != 0)
				{
				}
				num = (short)429260800;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.Valid;
			}
			set
			{
				short num = (short)364773376;
				short num2 = num;
				num = (short)2093849438;
				short num3 = num;
				num = (short)594910046;
				switch (num3 == num)
				{
				}
				num = (short)577306624;
				if (num != 0)
				{
				}
				num = (short)384172033;
				if (num != 0)
				{
				}
				this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.Valid = value;
			}
		}

		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x06002854 RID: 10324 RVA: 0x00270898 File Offset: 0x0026EA98
		// (set) Token: 0x06002855 RID: 10325 RVA: 0x0027094C File Offset: 0x0026EB4C
		public bool ScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724_Visible
		{
			get
			{
				short num = (short)479199232;
				short num2 = num;
				num = (short)1906634792;
				short num3 = num;
				num = (short)2061692968;
				switch (num3 == num)
				{
				}
				num = (short)377356289;
				if (num != 0)
				{
				}
				num = (short)2120220672;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.Visible;
			}
			set
			{
				short num = (short)1527119872;
				short num2 = num;
				num = (short)1838539786;
				short num3 = num;
				num = (short)1259594762;
				switch (num3 == num)
				{
				}
				num = (short)1189347328;
				if (num != 0)
				{
				}
				num = (short)1856962561;
				if (num != 0)
				{
				}
				this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.Visible = value;
			}
		}

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x06002856 RID: 10326 RVA: 0x00270A04 File Offset: 0x0026EC04
		// (set) Token: 0x06002857 RID: 10327 RVA: 0x00270AB8 File Offset: 0x0026ECB8
		public bool ScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724_Editable
		{
			get
			{
				short num = (short)1690894336;
				short num2 = num;
				num = (short)442630145;
				if (num != 0)
				{
				}
				num = (short)2114341341;
				short num3 = num;
				num = (short)167791069;
				switch (num3 == num)
				{
				}
				num = (short)1479016448;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.Editable;
			}
			set
			{
				short num = (short)2066677760;
				short num2 = num;
				num = (short)635579709;
				short num3 = num;
				num = (short)1487023421;
				switch (num3 == num)
				{
				}
				num = (short)91553792;
				if (num != 0)
				{
				}
				num = (short)494796801;
				if (num != 0)
				{
				}
				this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.Editable = value;
			}
		}

		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x06002858 RID: 10328 RVA: 0x00270B70 File Offset: 0x0026ED70
		internal string ScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724_UILabel
		{
			get
			{
				short num = (short)642711552;
				short num2 = num;
				num = (short)2007614037;
				short num3 = num;
				num = (short)962773589;
				switch (num3 == num)
				{
				}
				num = (short)1079967745;
				if (num != 0)
				{
				}
				num = (short)351797248;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.UIName;
			}
		}

		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x06002859 RID: 10329 RVA: 0x00270C28 File Offset: 0x0026EE28
		// (set) Token: 0x0600285A RID: 10330 RVA: 0x00270CDC File Offset: 0x0026EEDC
		internal bool ScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724_HiddenStatic
		{
			get
			{
				short num = (short)1878720512;
				short num2 = num;
				num = (short)231302166;
				short num3 = num;
				num = (short)1129604118;
				switch (num3 == num)
				{
				}
				num = (short)617873409;
				if (num != 0)
				{
				}
				num = (short)1528037376;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.HiddenStatic;
			}
			set
			{
				short num = (short)1762394112;
				short num2 = num;
				num = (short)1711073018;
				short num3 = num;
				num = (short)292153082;
				switch (num3 == num)
				{
				}
				num = (short)960102401;
				if (num != 0)
				{
				}
				num = (short)212533248;
				if (num != 0)
				{
				}
				this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.HiddenStatic = value;
			}
		}

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x0600285B RID: 10331 RVA: 0x00270D94 File Offset: 0x0026EF94
		// (set) Token: 0x0600285C RID: 10332 RVA: 0x00270E48 File Offset: 0x0026F048
		internal bool ScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724_HiddenDynamic
		{
			get
			{
				short num = (short)517210112;
				short num2 = num;
				num = (short)1589379073;
				if (num != 0)
				{
				}
				num = (short)749420083;
				short num3 = num;
				num = (short)605109811;
				switch (num3 == num)
				{
				}
				num = (short)555679744;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.HiddenDynamic;
			}
			set
			{
				short num = (short)2117206016;
				short num2 = num;
				num = (short)1947336705;
				if (num != 0)
				{
				}
				num = (short)1705264358;
				short num3 = num;
				num = (short)246236390;
				switch (num3 == num)
				{
				}
				num = (short)1986658304;
				if (num != 0)
				{
				}
				this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.HiddenDynamic = value;
			}
		}

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x0600285D RID: 10333 RVA: 0x00270EFC File Offset: 0x0026F0FC
		public bool ScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724_HasDiffs
		{
			get
			{
				short num = (short)165675008;
				short num2 = num;
				num = (short)1641938945;
				if (num != 0)
				{
				}
				num = (short)1774712577;
				short num3 = num;
				num = (short)319289089;
				switch (num3 == num)
				{
				}
				num = (short)450625536;
				if (num != 0)
				{
				}
				return this.scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724._HasDiffs;
			}
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x00270FB0 File Offset: 0x0026F1B0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_BE;
			}
			short num;
			global::AcpCommonLib.IAcpRecordset result;
			int num4;
			for (;;)
			{
				IL_0A:
				num = (short)881271204;
				short num2 = num;
				num = (short)1299325348;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return result;
				default:
				{
					num = (short)466419712;
					short num3 = num;
					num = (short)521469953;
					if (num != 0)
					{
					}
					num = (short)532480000;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						if (base.ParentRecset != null)
						{
							num = (short)1194000385;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						num = (short)1028390915;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)1896218628;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)635633666;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						return result;
					}
					goto IL_BE;
				}
				}
			}
			return result;
			IL_BE:
			result = null;
			num = (short)1103757312;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04000ED1 RID: 3793
		private global::AcpBusinessLayer.AcpField<bool> scanLstAdvancedDisplayStrongestVotedChannel_A7884;

		// Token: 0x04000ED2 RID: 3794
		private global::AcpBusinessLayer.AcpField<bool> scanLstAdvancedTxSteering_A9572;

		// Token: 0x04000ED3 RID: 3795
		private global::AcpBusinessLayer.AcpRangeField<int, string> scanLstAdvancedVotingScanDelayTimerMs_A9657;

		// Token: 0x04000ED4 RID: 3796
		private global::AcpBusinessLayer.AcpSimpleRangeField scanLstAdvancedDataTxLimitedPatienceTimerms_A7799;

		// Token: 0x04000ED5 RID: 3797
		private global::AcpBusinessLayer.AcpSimpleRangeField scanLstAdvancedMixedConvVoteScanInactivityTimer_A38724;
	}
}
