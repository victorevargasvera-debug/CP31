using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x0200006B RID: 107
	[global::System.Serializable]
	public class ChannelRangesMHzInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06000A8F RID: 2703 RVA: 0x0009C18C File Offset: 0x0009A38C
		public ChannelRangesMHzInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x0009C1A8 File Offset: 0x0009A3A8
		protected ChannelRangesMHzInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x0009C1C0 File Offset: 0x0009A3C0
		public override void Init()
		{
			int a_ = 3;
			short num = (short)956150331;
			short num2 = num;
			num = (short)463516219;
			switch (num2 == num)
			{
			}
			num = (short)1921318913;
			if (num != 0)
			{
			}
			num = (short)1835925504;
			short num3 = num;
			num = (short)200015872;
			if (num != 0)
			{
			}
			this.trkSysOBTChannelAssignmentListRxEnable_A9001 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("郃듅ꏇ駉뗋뷍鿏郑胓闕냗믙닛냝藟軡ꗣ闥鯧菩诫胭鷯韱髳苵듷鏹迻諽勿稁䄃栅椇栉怋欍伏匑ⴓ☕⠗⬙", a_), global::CommonResources.AcgResources.ID_RXENABLE);
			this.trkSysOBTChannelAssignmentListRxEnable_A9001.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysOBTChannelAssignmentListRxEnable_A9001.DataTransferOrder = 18;
			this.trkSysOBTChannelAssignmentListRxEnable_A9001.ValidateAcrossRecset = true;
			this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004 = new global::AcpBusinessLayer.AcpSparseLOVField(1250, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.indexTrkSysOBTChannelAssignmentListRxSpacingKHz_A9004LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.idTrkSysOBTChannelAssignmentListRxSpacingKHz_A9004LovStrs), this, global::AllFeatures.CodeplugGuid.b("郃듅ꏇ駉뗋뷍鿏郑胓闕냗믙닛냝藟軡ꗣ闥鯧菩诫胭鷯韱髳苵듷鏹迻諽勿稁圃瘅椇椉攋怍眏夑尓氕䜗嬙┛⸝ဟᘡ", a_), global::CommonResources.AcgResources.ID_RXSPACINGKHZ, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004LovStrs);
			this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.DataTransferOrder = 19;
			this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012 = new global::AcpBusinessLayer.AcpFrequencyField(27200000, this, global::AllFeatures.CodeplugGuid.b("郃듅ꏇ駉뗋뷍鿏郑胓闕냗믙닛냝藟軡ꗣ闥鯧菩诫胭鷯韱髳苵듷鏹迻諽勿稁䄃栅氇䰉縋欍意朑焓砕笗挙儛嘝娟紡攣ἥᠧᬩḫ", a_), global::CommonResources.AcgResources.ID_RXENDFREQUENCYMHZ, 0, int.MaxValue, 1);
			this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.DataTransferOrder = 22;
			this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029 = new global::AcpBusinessLayer.AcpFrequencyField(27200000, this, global::AllFeatures.CodeplugGuid.b("郃듅ꏇ駉뗋뷍鿏郑胓闕냗믙닛냝藟軡ꗣ闥鯧菩诫胭鷯韱髳苵듷鏹迻諽勿稁圃爅椇砉砋䠍戏眑攓挕紗琙缛朝洟模帣礥椧ጩᰫᰭय", a_), global::CommonResources.AcgResources.ID_RXSTARTFREQUENCYMHZ, 0, int.MaxValue, 1);
			this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.DataTransferOrder = 21;
			this.trkSysOBTChannelAssignmentListTxEnable_A9517 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("郃듅ꏇ駉뗋뷍鿏郑胓闕냗믙닛냝藟軡ꗣ闥鯧菩诫胭鷯韱髳苵듷鏹迻諽哿稁䄃栅椇栉怋欍伏匑ⴓ⌕⤗ⴙ", a_), global::CommonResources.AcgResources.ID_TXENABLE);
			this.trkSysOBTChannelAssignmentListTxEnable_A9517.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysOBTChannelAssignmentListTxEnable_A9517.DataTransferOrder = 24;
			this.trkSysOBTChannelAssignmentListTxEnable_A9517.ValidateAcrossRecset = true;
			this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520 = new global::AcpBusinessLayer.AcpSparseLOVField(1250, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.indexTrkSysOBTChannelAssignmentListTxSpacingKHz_A9520LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.idTrkSysOBTChannelAssignmentListTxSpacingKHz_A9520LovStrs), this, global::AllFeatures.CodeplugGuid.b("郃듅ꏇ駉뗋뷍鿏郑胓闕냗믙닛냝藟軡ꗣ闥鯧菩诫胭鷯韱髳苵듷鏹迻諽哿稁圃瘅椇椉攋怍眏夑尓氕䜗嬙┛⬝ሟሡ", a_), global::CommonResources.AcgResources.ID_TXSPACINGKHZ, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520LovStrs);
			this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.DataTransferOrder = 26;
			this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529 = new global::AcpBusinessLayer.AcpFrequencyField(27200000, this, global::AllFeatures.CodeplugGuid.b("郃듅ꏇ駉뗋뷍鿏郑胓闕냗믙닛냝藟軡ꗣ闥鯧菩诫胭鷯韱髳苵듷鏹迻諽哿稁䄃栅氇䰉縋欍意朑焓砕笗挙儛嘝娟紡攣ἥᴧᠩᔫ", a_), global::CommonResources.AcgResources.ID_TXENDFREQUENCYMHZ, 0, int.MaxValue, 1);
			this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.DataTransferOrder = 28;
			this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568 = new global::AcpBusinessLayer.AcpFrequencyField(27200000, this, global::AllFeatures.CodeplugGuid.b("郃듅ꏇ駉뗋뷍鿏郑胓闕냗믙닛냝藟軡ꗣ闥鯧菩诫胭鷯韱髳苵듷鏹迻諽哿稁圃爅椇砉砋䠍戏眑攓挕紗琙缛朝洟模帣礥椧ጩᤫᠭ࠯", a_), global::CommonResources.AcgResources.ID_TXSTARTFREQUENCYMHZ, 0, int.MaxValue, 1);
			this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.DataTransferOrder = 27;
			this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478 = new global::AcpBusinessLayer.AcpSimpleRangeField(380, this, global::AllFeatures.CodeplugGuid.b("郃듅ꏇ駉뗋뷍鿏郑胓闕냗믙닛냝藟軡ꗣ闥鯧菩诫胭鷯韱髳苵듷鏹迻諽勿稁圃爅椇砉砋䴍砏猑稓砕紗瘙创欝䴟䀡䄣吥眧欩ḫḭЯԱళ", a_), global::CommonResources.AcgResources.ID_RXSTARTCHANNELNUMBER, 0, 65535, null, null, 0, 1);
			this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.DataTransferOrder = -1;
			this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.ShowHexValue = true;
			this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("郃듅ꏇ駉뗋뷍鿏郑胓闕냗믙닛냝藟軡ꗣ闥鯧菩诫胭鷯韱髳苵듷鏹迻諽哿稁圃爅椇砉砋䴍砏猑稓砕紗瘙创欝䴟䀡䄣吥眧欩ḫḭЯԱള", a_), global::CommonResources.AcgResources.ID_TXSTARTCHANNELNUMBER, 0, 65535, null, null, 0, 1);
			this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.DataTransferOrder = -1;
			this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.ShowHexValue = true;
			this.trkSysOBTChannelRange_A24072 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("郃듅ꏇ駉뗋뷍鿏郑胓闕냗믙닛냝藟軡뛣蟥蛧跩觫뇭뇯샱샳웵쿷죹", a_), global::CommonResources.AcgResources.ID_RANGE, 100);
			this.trkSysOBTChannelRange_A24072.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysOBTChannelRange_A24072.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟃껅꧇꓉ꋋꯍ볏蛓럕뛗뷙맛귝샟쫡ꧣ껥鋧쏩", a_);
			base.Id = 10168;
			base.UIName = global::CommonResources.AcgResources.ID_CHANNELRANGESMHZ;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x0009C5B8 File Offset: 0x0009A7B8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 2;
			short num = (short)1829044224;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_C2;
					}
					continue;
				case 1:
					this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478 = new global::AcpBusinessLayer.AcpSimpleRangeField(380, this, global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌胎鏐蟒雔뿖룘뗚돜뫞跠ꋢ雤铦胨質菬苮铰鷲致믶郸裺觼귾礀倂焄昆笈缊丌朎瀐紒笔爖甘唚栜爞䌠䘢圤砦栨ᤪᴬᬮذଲ", a_), global::CommonResources.AcgResources.ID_RXSTARTCHANNELNUMBER, null, null, 0, 1);
					this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.DataTransferOrder = -1;
					this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.ShowHexValue = true;
					num = (short)1253179396;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_2CC;
				case 3:
					this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029 = new global::AcpBusinessLayer.AcpFrequencyField(27200000, this, global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌胎鏐蟒雔뿖룘뗚돜뫞跠ꋢ雤铦胨質菬苮铰鷲致믶郸裺觼귾礀倂焄昆笈缊䬌紎琐戒怔爖眘砚搜刞椠夢稤昦ဨᬪἬᘮ", a_), global::CommonResources.AcgResources.ID_RXSTARTFREQUENCYMHZ);
					this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.DataTransferOrder = 21;
					num = (short)1036845066;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_21E;
				case 5:
					this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520 = new global::AcpBusinessLayer.AcpSparseLOVField(1250, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.indexTrkSysOBTChannelAssignmentListTxSpacingKHz_A9520LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.idTrkSysOBTChannelAssignmentListTxSpacingKHz_A9520LovStrs), this, global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌胎鏐蟒雔뿖룘뗚돜뫞跠ꋢ雤铦胨質菬苮铰鷲致믶郸裺觼꯾礀倂甄昆樈戊挌栎娐嬒演䠖堘√⠜ⴞᄠ", a_), global::CommonResources.AcgResources.ID_TXSPACINGKHZ, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520LovStrs);
					this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.DataTransferOrder = 26;
					num = (short)445644817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					if (producerFields == null)
					{
						goto IL_92D;
					}
					num = (short)294620859;
					short num3 = num;
					num = (short)317623995;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_672;
					default:
						num = (short)437321728;
						if (num != 0)
						{
						}
						num = (short)1140260875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					goto IL_3DE;
				case 8:
					goto IL_5E7;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌胎鏐蟒雔뿖룘뗚돜뫞跠뇢蓤触軨軪달껮쏰쟲열샶쯸", a_)))
					{
						num = (short)1720123428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_92D;
				case 10:
					goto IL_79C;
				case 11:
					num = (short)563347468;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌胎鏐蟒雔뿖룘뗚돜뫞跠ꋢ雤铦胨質菬苮铰鷲致믶郸裺觼귾礀䘂欄昆欈朊栌倎倐⨒└✖⠘", a_)))
					{
						num = (short)61931541;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5E7;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌胎鏐蟒雔뿖룘뗚돜뫞跠ꋢ雤铦胨質菬苮铰鷲致믶郸裺觼귾礀倂甄昆樈戊挌栎娐嬒演䠖堘√ⴜ⼞ᔠ", a_)))
					{
						num = (short)2031353882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3DE;
				case 14:
					this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012 = new global::AcpBusinessLayer.AcpFrequencyField(27200000, this, global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌胎鏐蟒雔뿖룘뗚돜뫞跠ꋢ雤铦胨質菬苮铰鷲致믶郸裺觼귾礀䘂欄挆伈礊栌縎搐瘒笔琖怘嘚唜攞縠戢ᰤᜦᠨᤪ", a_), global::CommonResources.AcgResources.ID_RXENDFREQUENCYMHZ);
					this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.DataTransferOrder = 22;
					goto IL_672;
				case 15:
					goto IL_344;
				case 16:
					goto IL_506;
				case 17:
					goto IL_847;
				case 18:
					this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌胎鏐蟒雔뿖룘뗚돜뫞跠ꋢ雤铦胨質菬苮铰鷲致믶郸裺觼꯾礀倂焄昆笈缊丌朎瀐紒笔爖甘唚栜爞䌠䘢圤砦栨ᤪᴬᬮذਲ", a_), global::CommonResources.AcgResources.ID_TXSTARTCHANNELNUMBER, null, null, 0, 1);
					this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.DataTransferOrder = -1;
					this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.ShowHexValue = true;
					num = (short)318046223;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					num = (short)569835526;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568 = new global::AcpBusinessLayer.AcpFrequencyField(27200000, this, global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌胎鏐蟒雔뿖룘뗚돜뫞跠ꋢ雤铦胨質菬苮铰鷲致믶郸裺觼꯾礀倂焄昆笈缊䬌紎琐戒怔爖眘砚搜刞椠夢稤昦ဨḪᬬᜮ", a_), global::CommonResources.AcgResources.ID_TXSTARTFREQUENCYMHZ);
					this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.DataTransferOrder = 27;
					num = (short)868089883;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					this.trkSysOBTChannelAssignmentListRxEnable_A9001 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌胎鏐蟒雔뿖룘뗚돜뫞跠ꋢ雤铦胨質菬苮铰鷲致믶郸裺觼귾礀䘂欄昆欈朊栌倎倐⨒└✖⠘", a_), global::CommonResources.AcgResources.ID_RXENABLE);
					this.trkSysOBTChannelAssignmentListRxEnable_A9001.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysOBTChannelAssignmentListRxEnable_A9001.DataTransferOrder = 18;
					this.trkSysOBTChannelAssignmentListRxEnable_A9001.ValidateAcrossRecset = true;
					num = (short)1103101960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529 = new global::AcpBusinessLayer.AcpFrequencyField(27200000, this, global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌胎鏐蟒雔뿖룘뗚돜뫞跠ꋢ雤铦胨質菬苮铰鷲致믶郸裺觼꯾礀䘂欄挆伈礊栌縎搐瘒笔琖怘嘚唜攞縠戢ᰤሦᬨሪ", a_), global::CommonResources.AcgResources.ID_TXENDFREQUENCYMHZ);
					this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.DataTransferOrder = 28;
					num = (short)442040322;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌胎鏐蟒雔뿖룘뗚돜뫞跠ꋢ雤铦胨質菬苮铰鷲致믶郸裺觼꯾礀䘂欄昆欈朊栌倎倐⨒—☖⸘", a_)))
					{
						num = (short)370081821;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_391;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌胎鏐蟒雔뿖룘뗚돜뫞跠ꋢ雤铦胨質菬苮铰鷲致믶郸裺觼꯾礀倂焄昆笈缊丌朎瀐紒笔爖甘唚栜爞䌠䘢圤砦栨ᤪᴬᬮذਲ", a_)))
					{
						num = (short)1098448914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_344;
				case 25:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌胎鏐蟒雔뿖룘뗚돜뫞跠ꋢ雤铦胨質菬苮铰鷲致믶郸裺觼귾礀䘂欄挆伈礊栌縎搐瘒笔琖怘嘚唜攞縠戢ᰤᜦᠨᤪ", a_)))
					{
						num = (short)1371734030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_68B;
				case 26:
					this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004 = new global::AcpBusinessLayer.AcpSparseLOVField(1250, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.indexTrkSysOBTChannelAssignmentListRxSpacingKHz_A9004LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.idTrkSysOBTChannelAssignmentListRxSpacingKHz_A9004LovStrs), this, global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌胎鏐蟒雔뿖룘뗚돜뫞跠ꋢ雤铦胨質菬苮铰鷲致믶郸裺觼귾礀倂甄昆樈戊挌栎娐嬒演䠖堘√ⴜ⼞ᔠ", a_), global::CommonResources.AcgResources.ID_RXSPACINGKHZ, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004LovStrs);
					this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.DataTransferOrder = 19;
					num = (short)1366949895;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					goto IL_8E1;
				case 28:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌胎鏐蟒雔뿖룘뗚돜뫞跠ꋢ雤铦胨質菬苮铰鷲致믶郸裺觼귾礀倂焄昆笈缊丌朎瀐紒笔爖甘唚栜爞䌠䘢圤砦栨ᤪᴬᬮذଲ", a_)))
					{
						num = (short)868417537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_21E;
				case 29:
					this.trkSysOBTChannelAssignmentListTxEnable_A9517 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌胎鏐蟒雔뿖룘뗚돜뫞跠ꋢ雤铦胨質菬苮铰鷲致믶郸裺觼꯾礀䘂欄昆欈朊栌倎倐⨒—☖⸘", a_), global::CommonResources.AcgResources.ID_TXENABLE);
					this.trkSysOBTChannelAssignmentListTxEnable_A9517.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysOBTChannelAssignmentListTxEnable_A9517.DataTransferOrder = 24;
					this.trkSysOBTChannelAssignmentListTxEnable_A9517.ValidateAcrossRecset = true;
					num = (short)2049376290;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌胎鏐蟒雔뿖룘뗚돜뫞跠ꋢ雤铦胨質菬苮铰鷲致믶郸裺觼꯾礀䘂欄挆伈礊栌縎搐瘒笔琖怘嘚唜攞縠戢ᰤሦᬨሪ", a_)))
					{
						num = (short)729088022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2CC;
				case 31:
					goto IL_68B;
				case 32:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌胎鏐蟒雔뿖룘뗚돜뫞跠ꋢ雤铦胨質菬苮铰鷲致믶郸裺觼꯾礀倂甄昆樈戊挌栎娐嬒演䠖堘√⠜ⴞᄠ", a_)))
					{
						num = (short)1264517125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_847;
				case 33:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌胎鏐蟒雔뿖룘뗚돜뫞跠ꋢ雤铦胨質菬苮铰鷲致믶郸裺觼귾礀倂焄昆笈缊䬌紎琐戒怔爖眘砚搜刞椠夢稤昦ဨᬪἬᘮ", a_)))
					{
						num = (short)699006979;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_79C;
				case 34:
					goto IL_391;
				case 35:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌胎鏐蟒雔뿖룘뗚돜뫞跠ꋢ雤铦胨質菬苮铰鷲致믶郸裺觼꯾礀倂焄昆笈缊䬌紎琐戒怔爖眘砚搜刞椠夢稤昦ဨḪᬬᜮ", a_)))
					{
						num = (short)1665728512;
						short num4 = num;
						num = (short)910032916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8E1;
				case 36:
					this.trkSysOBTChannelRange_A24072 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌胎鏐蟒雔뿖룘뗚돜뫞跠뇢蓤触軨軪달껮쏰쟲열샶쯸", a_), global::CommonResources.AcgResources.ID_RANGE, 100);
					this.trkSysOBTChannelRange_A24072.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysOBTChannelRange_A24072.DataTransferOrder = -1;
					num = (short)609746945;
					if (num != 0)
					{
					}
					num = (short)194248720;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C2:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)365101075;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_21E:
				num = (short)1011744792;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2CC:
				num = (short)674168867;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_344:
				num = (short)697696265;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_391:
				num = (short)407568416;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3DE:
				num = (short)796131353;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5E7:
				num = (short)1910112269;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_672:
				num = (short)1887764511;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_68B:
				num = (short)1777205281;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_79C:
				num = (short)1164443671;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_847:
				num = (short)586743838;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8E1:
				num = (short)1603797020;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_506:
			IL_92D:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胂귄ꛆꟈꗊ꣌ꏎ臒듔맖뻘뻚껜￞짠껢귤鷦샨", a_);
			base.Id = 10168;
			base.UIName = global::CommonResources.AcgResources.ID_CHANNELRANGESMHZ;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0009CF24 File Offset: 0x0009B124
		public override void PopulateReferences()
		{
			short num = (short)1321327930;
			short num2 = num;
			num = (short)363584826;
			switch (num2 == num)
			{
			default:
			{
				num = (short)220594176;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1902182401;
			if (num != 0)
			{
			}
			num = (short)1216413696;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x0009CFCC File Offset: 0x0009B1CC
		public override void DropReferences()
		{
			short num = (short)1416036353;
			if (num != 0)
			{
			}
			num = (short)249167872;
			short num2 = num;
			num = (short)7444359;
			short num3 = num;
			num = (short)1045796743;
			switch (num3 == num)
			{
			}
			num = (short)1428619264;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x0009D074 File Offset: 0x0009B274
		public override void SetConstraints()
		{
			short num = (short)1760474587;
			short num2 = num;
			num = (short)502576603;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1794768896;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)665059328;
			if (num != 0)
			{
			}
			num = (short)1307181057;
			if (num != 0)
			{
			}
			this.trkSysOBTChannelAssignmentListRxEnable_A9001.ValidateAcrossRecset = true;
			this.trkSysOBTChannelAssignmentListRxEnable_A9001.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conTrkSysChanAssignRxEnApp);
			this.trkSysOBTChannelAssignmentListRxEnable_A9001.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conRxEnableOnFirstRowMustBeEnabled);
			this.trkSysOBTChannelAssignmentListRxEnable_A9001.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conSetValueOfRxStartChannelNumber);
			this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysChanAssignRxSpacingApp);
			this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conExecuteValidityOfDependentFieldsOf9004);
			this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conSetValueOfRxStartChannelNumber);
			this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conTrkSysChanAssignRxEndFreqApp);
			this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysOBTRxEndFreqIsValid);
			this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conSetValueOfRxStartChannelNumber);
			this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conTrkSysChanAssignRxStartFreqApp);
			this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysOBTRxStartFreq1IsValid);
			this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conSetValueOfRxStartChannelNumber);
			this.trkSysOBTChannelAssignmentListTxEnable_A9517.ValidateAcrossRecset = true;
			this.trkSysOBTChannelAssignmentListTxEnable_A9517.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conTrkSysChanAssignTxEnApp);
			this.trkSysOBTChannelAssignmentListTxEnable_A9517.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conTxEnableOnFirstRowMustBeEnabled);
			this.trkSysOBTChannelAssignmentListTxEnable_A9517.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conSetValueOfTxStartChannelNumber);
			this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conTrkSysChanAssignTxSpacingApp);
			this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conExecuteValidityOfDependentFieldsOf9520);
			this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conSetValueOfTxStartChannelNumber);
			this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conTrkSysChanAssignTxEndFreqApp);
			this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysOBTTxEndFreqIsValid);
			this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conSetValueOfTxStartChannelNumber);
			this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conTrkSysChanAssignTxStartFreqApp);
			this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysOBTTxStartFreq1IsValid);
			this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conSetValueOfTxStartChannelNumber);
			this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conTrkSysTypeIsIIAndOBTEnabled);
			this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conTrkSysTypeIsIIAndOBTEnabledEdtbl);
			this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conTrkSysTypeIsIIAndOBTEnabled);
			this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conTrkSysTypeIsIIAndOBTEnabledEdtbl);
			this.trkSysOBTChannelRange_A24072.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conTrkSysTypeIsIIAndOBTEnabled);
			this.trkSysOBTChannelRange_A24072.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x0009D3E8 File Offset: 0x0009B5E8
		public override void SetupDependencies()
		{
			short num = (short)2029104699;
			short num2 = num;
			num = (short)57912891;
			switch (num2 == num)
			{
			default:
			{
				num = (short)34996224;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)392691713;
			if (num != 0)
			{
			}
			num = (short)265814016;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
			trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491.AddDependentObject(this.trkSysOBTChannelAssignmentListRxEnable_A9001);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysOBTChannelAssignmentListRxEnable_A9001);
			this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.AddDependentObject(this.trkSysOBTChannelAssignmentListRxEnable_A9001);
			this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.AddDependentObject(this.trkSysOBTChannelAssignmentListRxEnable_A9001);
			this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.AddDependentObject(this.trkSysOBTChannelAssignmentListRxEnable_A9001);
			this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.AddDependentObject(this.trkSysOBTChannelAssignmentListRxEnable_A9001);
			this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.AddDependentObject(this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004);
			this.trkSysOBTChannelAssignmentListRxEnable_A9001.AddDependentObject(this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004);
			this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.AddDependentObject(this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004);
			this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.AddDependentObject(this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004);
			trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491.AddDependentObject(this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004);
			this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.AddDependentObject(this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012);
			this.trkSysOBTChannelAssignmentListRxEnable_A9001.AddDependentObject(this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012);
			this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.AddDependentObject(this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012);
			this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.AddDependentObject(this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012);
			trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491.AddDependentObject(this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012);
			this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.AddDependentObject(this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029);
			this.trkSysOBTChannelAssignmentListRxEnable_A9001.AddDependentObject(this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029);
			this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.AddDependentObject(this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029);
			this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.AddDependentObject(this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029);
			trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491.AddDependentObject(this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029);
			trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491.AddDependentObject(this.trkSysOBTChannelAssignmentListTxEnable_A9517);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysOBTChannelAssignmentListTxEnable_A9517);
			this.trkSysOBTChannelAssignmentListTxEnable_A9517.AddDependentObject(this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520);
			trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491.AddDependentObject(this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520);
			trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491.AddDependentObject(this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529);
			this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.AddDependentObject(this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529);
			this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.AddDependentObject(this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529);
			this.trkSysOBTChannelAssignmentListTxEnable_A9517.AddDependentObject(this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529);
			trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491.AddDependentObject(this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568);
			this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.AddDependentObject(this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568);
			this.trkSysOBTChannelAssignmentListTxEnable_A9517.AddDependentObject(this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568);
			trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491.AddDependentObject(this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478);
			trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491.AddDependentObject(this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479);
			trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491.AddDependentObject(this.trkSysOBTChannelRange_A24072);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysOBTChannelRange_A24072);
			this.trkSysOBTChannelAssignmentListTxEnable_A9517.AddDependentObject((base.ParentRecset.ParentSection.Parent[10155] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TypeIIChannelSetup).TrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654);
			this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.AddDependentObject((base.ParentRecset.ParentSection.Parent[10155] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TypeIIChannelSetup).TrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654);
			this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.AddDependentObject((base.ParentRecset.ParentSection.Parent[10155] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TypeIIChannelSetup).TrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654);
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x0009D8BC File Offset: 0x0009BABC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1573674813;
				short num2 = num;
				num = (short)672030525;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1640235008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1260584961;
				if (num != 0)
				{
				}
				num = (short)1130299392;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x0009D96C File Offset: 0x0009BB6C
		// (set) Token: 0x06000A99 RID: 2713 RVA: 0x0009DA20 File Offset: 0x0009BC20
		public bool TrkSysOBTChannelAssignmentListRxEnable_A9001Value
		{
			get
			{
				short num = (short)189117782;
				short num2 = num;
				num = (short)123254102;
				switch (num2 == num)
				{
				default:
				{
					num = (short)167510016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1101594625;
				if (num != 0)
				{
				}
				num = (short)116719616;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxEnable_A9001.Value;
			}
			set
			{
				short num = (short)2057447369;
				short num2 = num;
				num = (short)495790025;
				switch (num2 == num)
				{
				default:
				{
					num = (short)823590912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)687538177;
				if (num != 0)
				{
				}
				num = (short)542507008;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxEnable_A9001.Value = value;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x0009DAD8 File Offset: 0x0009BCD8
		public global::AcpBusinessLayer.AcpField<bool> TrkSysOBTChannelAssignmentListRxEnable_A9001
		{
			get
			{
				short num = (short)2107826008;
				short num2 = num;
				num = (short)1473961816;
				switch (num2 == num)
				{
				default:
				{
					num = (short)574423040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)331939841;
				if (num != 0)
				{
				}
				num = (short)572719104;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxEnable_A9001;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x0009DB88 File Offset: 0x0009BD88
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x0009DC40 File Offset: 0x0009BE40
		public bool TrkSysOBTChannelAssignmentListRxEnable_A9001_UIValue
		{
			get
			{
				short num = (short)1150350911;
				short num2 = num;
				num = (short)375649855;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1009909760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2035351553;
				if (num != 0)
				{
				}
				num = (short)1612578816;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxEnable_A9001.Value;
			}
			set
			{
				short num = (short)341737544;
				short num2 = num;
				num = (short)372080712;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1926758400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1139081217;
				if (num != 0)
				{
				}
				num = (short)1261830144;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxEnable_A9001.Value = value;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x0009DCF4 File Offset: 0x0009BEF4
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x0009DDA8 File Offset: 0x0009BFA8
		public bool TrkSysOBTChannelAssignmentListRxEnable_A9001_Applicable
		{
			get
			{
				short num = (short)2054844921;
				short num2 = num;
				num = (short)953446905;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1843331072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1997471745;
				if (num != 0)
				{
				}
				num = (short)861339648;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxEnable_A9001.Applicable;
			}
			set
			{
				short num = (short)6399662;
				short num2 = num;
				num = (short)674670254;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1891237888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1655832577;
				if (num != 0)
				{
				}
				num = (short)1889206272;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxEnable_A9001.Applicable = value;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x0009DE5C File Offset: 0x0009C05C
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x0009DF10 File Offset: 0x0009C110
		public bool TrkSysOBTChannelAssignmentListRxEnable_A9001_Valid
		{
			get
			{
				short num = (short)1339532758;
				short num2 = num;
				num = (short)2098111958;
				switch (num2 == num)
				{
				default:
				{
					num = (short)710213632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1033502720;
				if (num != 0)
				{
				}
				num = (short)418709505;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxEnable_A9001.Valid;
			}
			set
			{
				short num = (short)1311503295;
				short num2 = num;
				num = (short)1576006591;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1696727040;
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
				num = (short)1250099200;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxEnable_A9001.Valid = value;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x0009DFC8 File Offset: 0x0009C1C8
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x0009E080 File Offset: 0x0009C280
		public bool TrkSysOBTChannelAssignmentListRxEnable_A9001_Visible
		{
			get
			{
				short num = (short)336396289;
				if (num != 0)
				{
				}
				num = (short)273154048;
				short num2 = num;
				num = (short)134822130;
				short num3 = num;
				num = (short)951204082;
				switch (num3 == num)
				{
				}
				num = (short)1842413568;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxEnable_A9001.Visible;
			}
			set
			{
				short num = (short)1553540884;
				short num2 = num;
				num = (short)628565780;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1305411584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)291307521;
				if (num != 0)
				{
				}
				num = (short)236060672;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxEnable_A9001.Visible = value;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x0009E134 File Offset: 0x0009C334
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x0009E1E8 File Offset: 0x0009C3E8
		public bool TrkSysOBTChannelAssignmentListRxEnable_A9001_Editable
		{
			get
			{
				short num = (short)725190880;
				short num2 = num;
				num = (short)1112180960;
				switch (num2 == num)
				{
				default:
				{
					num = (short)41680896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1074069504;
				if (num != 0)
				{
				}
				num = (short)907870209;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxEnable_A9001.Editable;
			}
			set
			{
				short num = (short)542113793;
				if (num != 0)
				{
				}
				num = (short)232194048;
				short num2 = num;
				num = (short)1416858235;
				short num3 = num;
				num = (short)822643323;
				switch (num3 == num)
				{
				}
				num = (short)1463812096;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxEnable_A9001.Editable = value;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x0009E29C File Offset: 0x0009C49C
		internal string TrkSysOBTChannelAssignmentListRxEnable_A9001_UILabel
		{
			get
			{
				short num = (short)1822930698;
				short num2 = num;
				num = (short)707573514;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1005649920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1697841153;
				if (num != 0)
				{
				}
				num = (short)1287061504;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxEnable_A9001.UIName;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x0009E350 File Offset: 0x0009C550
		// (set) Token: 0x06000AA7 RID: 2727 RVA: 0x0009E404 File Offset: 0x0009C604
		internal bool TrkSysOBTChannelAssignmentListRxEnable_A9001_HiddenStatic
		{
			get
			{
				short num = (short)375284189;
				short num2 = num;
				num = (short)1795318237;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1849098240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1798766593;
				if (num != 0)
				{
				}
				num = (short)1892745216;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxEnable_A9001.HiddenStatic;
			}
			set
			{
				short num = (short)1207238657;
				if (num != 0)
				{
				}
				num = (short)2034040832;
				short num2 = num;
				num = (short)376588807;
				short num3 = num;
				num = (short)1653426695;
				switch (num3 == num)
				{
				}
				num = (short)224985088;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxEnable_A9001.HiddenStatic = value;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x0009E4B8 File Offset: 0x0009C6B8
		// (set) Token: 0x06000AA9 RID: 2729 RVA: 0x0009E56C File Offset: 0x0009C76C
		internal bool TrkSysOBTChannelAssignmentListRxEnable_A9001_HiddenDynamic
		{
			get
			{
				short num = (short)154796033;
				if (num != 0)
				{
				}
				num = (short)2034434048;
				short num2 = num;
				num = (short)1896737379;
				short num3 = num;
				num = (short)484436579;
				switch (num3 == num)
				{
				}
				num = (short)113836032;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxEnable_A9001.HiddenDynamic;
			}
			set
			{
				short num = (short)1941173316;
				short num2 = num;
				num = (short)1770845252;
				switch (num2 == num)
				{
				default:
				{
					num = (short)888930304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1325727745;
				if (num != 0)
				{
				}
				num = (short)201523200;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxEnable_A9001.HiddenDynamic = value;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x0009E624 File Offset: 0x0009C824
		public bool TrkSysOBTChannelAssignmentListRxEnable_A9001_HasDiffs
		{
			get
			{
				short num = (short)138617301;
				short num2 = num;
				num = (short)237445589;
				switch (num2 == num)
				{
				default:
				{
					num = (short)682688512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1182203905;
				if (num != 0)
				{
				}
				num = (short)1978335232;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxEnable_A9001._HasDiffs;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x0009E6D8 File Offset: 0x0009C8D8
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x0009E790 File Offset: 0x0009C990
		public int TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004Value
		{
			get
			{
				short num = (short)781097073;
				short num2 = num;
				num = (short)280402033;
				switch (num2 == num)
				{
				default:
				{
					num = (short)308936704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1188298753;
				if (num != 0)
				{
				}
				num = (short)291504128;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.Value;
			}
			set
			{
				short num = (short)1521835744;
				short num2 = num;
				num = (short)715218656;
				switch (num2 == num)
				{
				default:
				{
					num = (short)161480704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)941293568;
				if (num != 0)
				{
				}
				num = (short)2024734721;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.Value = value;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0009E848 File Offset: 0x0009CA48
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x0009E8F8 File Offset: 0x0009CAF8
		public string TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004_UIValue
		{
			get
			{
				short num = (short)754332408;
				short num2 = num;
				num = (short)233583352;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2052325376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)970391552;
				if (num != 0)
				{
				}
				num = (short)1690697729;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.UIValue;
			}
			set
			{
				short num = (short)500039681;
				if (num != 0)
				{
				}
				num = (short)174325760;
				short num2 = num;
				num = (short)1281688526;
				short num3 = num;
				num = (short)379061198;
				switch (num3 == num)
				{
				}
				num = (short)449839104;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.UIValue = value;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0009E9B0 File Offset: 0x0009CBB0
		public global::AcpBusinessLayer.AcpListField TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004
		{
			get
			{
				short num = (short)526003796;
				short num2 = num;
				num = (short)1710173780;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1939144704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1645543425;
				if (num != 0)
				{
				}
				num = (short)1545469952;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x0009EA60 File Offset: 0x0009CC60
		// (set) Token: 0x06000AB1 RID: 2737 RVA: 0x0009EB14 File Offset: 0x0009CD14
		public bool TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004_Applicable
		{
			get
			{
				short num = (short)113270832;
				short num2 = num;
				num = (short)1774673968;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1398472704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1590427649;
				if (num != 0)
				{
				}
				num = (short)1949302784;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.Applicable;
			}
			set
			{
				short num = (short)828112897;
				if (num != 0)
				{
				}
				num = (short)1081409536;
				short num2 = num;
				num = (short)298950461;
				short num3 = num;
				num = (short)663723837;
				switch (num3 == num)
				{
				}
				num = (short)1083703296;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.Applicable = value;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x0009EBC8 File Offset: 0x0009CDC8
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x0009EC7C File Offset: 0x0009CE7C
		public bool TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004_Valid
		{
			get
			{
				short num = (short)1357017809;
				short num2 = num;
				num = (short)2116514513;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1115947008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1505886209;
				if (num != 0)
				{
				}
				num = (short)288030720;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.Valid;
			}
			set
			{
				short num = (short)1323377333;
				short num2 = num;
				num = (short)1038230197;
				switch (num2 == num)
				{
				default:
				{
					num = (short)554958848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)35258369;
				if (num != 0)
				{
				}
				num = (short)1968963584;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.Valid = value;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x0009ED30 File Offset: 0x0009CF30
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x0009EDE4 File Offset: 0x0009CFE4
		public bool TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004_Visible
		{
			get
			{
				short num = (short)946872021;
				short num2 = num;
				num = (short)706879189;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1843200000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2143485952;
				if (num != 0)
				{
				}
				num = (short)86638593;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.Visible;
			}
			set
			{
				short num = (short)877533162;
				short num2 = num;
				num = (short)1655773162;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1290993664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2090860545;
				if (num != 0)
				{
				}
				num = (short)1675624448;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.Visible = value;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x0009EE9C File Offset: 0x0009D09C
		// (set) Token: 0x06000AB7 RID: 2743 RVA: 0x0009EF54 File Offset: 0x0009D154
		public bool TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004_Editable
		{
			get
			{
				short num = (short)327540642;
				short num2 = num;
				num = (short)856678306;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1101725696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1847459841;
				if (num != 0)
				{
				}
				num = (short)274268160;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.Editable;
			}
			set
			{
				short num = (short)1198692875;
				short num2 = num;
				num = (short)461806091;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1091108864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)809566209;
				if (num != 0)
				{
				}
				num = (short)1802174464;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.Editable = value;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x0009F00C File Offset: 0x0009D20C
		internal string TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004_UILabel
		{
			get
			{
				short num = (short)1487610070;
				short num2 = num;
				num = (short)1851138262;
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
				num = (short)2131623936;
				if (num != 0)
				{
				}
				num = (short)2007760897;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.UIName;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0009F0BC File Offset: 0x0009D2BC
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x0009F174 File Offset: 0x0009D374
		internal bool TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004_HiddenStatic
		{
			get
			{
				short num = (short)1840971777;
				if (num != 0)
				{
				}
				num = (short)1423310848;
				short num2 = num;
				num = (short)162484111;
				short num3 = num;
				num = (short)2092191631;
				switch (num3 == num)
				{
				}
				num = (short)117374976;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.HiddenStatic;
			}
			set
			{
				short num = (short)1586565672;
				short num2 = num;
				num = (short)1403392552;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1419771904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1973878785;
				if (num != 0)
				{
				}
				num = (short)1416364032;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.HiddenStatic = value;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0009F22C File Offset: 0x0009D42C
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x0009F2E0 File Offset: 0x0009D4E0
		internal bool TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004_HiddenDynamic
		{
			get
			{
				short num = (short)1118109697;
				if (num != 0)
				{
				}
				num = (short)287768576;
				short num2 = num;
				num = (short)1798643123;
				short num3 = num;
				num = (short)1965039027;
				switch (num3 == num)
				{
				}
				num = (short)845414400;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.HiddenDynamic;
			}
			set
			{
				short num = (short)69540834;
				short num2 = num;
				num = (short)1129651170;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1472135168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)276168704;
				if (num != 0)
				{
				}
				num = (short)48955393;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004.HiddenDynamic = value;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x0009F398 File Offset: 0x0009D598
		public bool TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004_HasDiffs
		{
			get
			{
				short num = (short)1367394136;
				short num2 = num;
				num = (short)236832600;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1387266048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)729743361;
				if (num != 0)
				{
				}
				num = (short)1960247296;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxSpacingKHz_A9004._HasDiffs;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x0009F44C File Offset: 0x0009D64C
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x0009F504 File Offset: 0x0009D704
		public int TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012Value
		{
			get
			{
				short num = (short)1700222175;
				short num2 = num;
				num = (short)2065257695;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1427832832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)803012608;
				if (num != 0)
				{
				}
				num = (short)1987575809;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.Value;
			}
			set
			{
				short num = (short)1570374094;
				short num2 = num;
				num = (short)1572995534;
				switch (num2 == num)
				{
				default:
				{
					num = (short)746258432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)461045760;
				if (num != 0)
				{
				}
				num = (short)1576075265;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.Value = value;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x0009F5B8 File Offset: 0x0009D7B8
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x0009F66C File Offset: 0x0009D86C
		public string TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012_UIValue
		{
			get
			{
				short num = (short)1225326593;
				if (num != 0)
				{
				}
				num = (short)178176402;
				short num2 = num;
				num = (short)1204273554;
				switch (num2 == num)
				{
				}
				num = (short)1098973184;
				short num3 = num;
				num = (short)98762752;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.UIValue;
			}
			set
			{
				short num = (short)1695437485;
				short num2 = num;
				num = (short)277435053;
				switch (num2 == num)
				{
				}
				num = (short)49152001;
				if (num != 0)
				{
				}
				num = (short)1188757504;
				short num3 = num;
				num = (short)128974848;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.UIValue = value;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x0009F720 File Offset: 0x0009D920
		public global::AcpBusinessLayer.AcpFrequencyField TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012
		{
			get
			{
				short num = (short)1566590541;
				short num2 = num;
				num = (short)1082410573;
				switch (num2 == num)
				{
				}
				num = (short)1082916865;
				if (num != 0)
				{
				}
				num = (short)1208156160;
				short num3 = num;
				num = (short)1789067264;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x0009F7D0 File Offset: 0x0009D9D0
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x0009F884 File Offset: 0x0009DA84
		internal int TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012Min
		{
			get
			{
				short num = (short)1278845743;
				short num2 = num;
				num = (short)1670816559;
				switch (num2 == num)
				{
				}
				num = (short)346619905;
				if (num != 0)
				{
				}
				num = (short)1463287808;
				short num3 = num;
				num = (short)1657077760;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.Min;
			}
			set
			{
				short num = (short)1173487617;
				if (num != 0)
				{
				}
				num = (short)2090036363;
				short num2 = num;
				num = (short)1112763531;
				switch (num2 == num)
				{
				}
				num = (short)2047606784;
				short num3 = num;
				num = (short)1000538112;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.Min = value;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x0009F938 File Offset: 0x0009DB38
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x0009F9EC File Offset: 0x0009DBEC
		internal int TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012Max
		{
			get
			{
				short num = (short)999556851;
				short num2 = num;
				num = (short)1345193715;
				switch (num2 == num)
				{
				}
				num = (short)610336769;
				if (num != 0)
				{
				}
				num = (short)1018494976;
				short num3 = num;
				num = (short)1398210560;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.Max;
			}
			set
			{
				short num = (short)1623824424;
				short num2 = num;
				num = (short)1770690600;
				switch (num2 == num)
				{
				}
				num = (short)483590145;
				if (num != 0)
				{
				}
				num = (short)76939264;
				short num3 = num;
				num = (short)1607925760;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.Max = value;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x0009FAA0 File Offset: 0x0009DCA0
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x0009FB58 File Offset: 0x0009DD58
		internal int TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012Step
		{
			get
			{
				short num = (short)1953234945;
				if (num != 0)
				{
				}
				num = (short)778088266;
				short num2 = num;
				num = (short)1627893578;
				switch (num2 == num)
				{
				}
				num = (short)1873936384;
				short num3 = num;
				num = (short)258670592;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.StepSize;
			}
			set
			{
				short num = (short)1188364289;
				if (num != 0)
				{
				}
				num = (short)1001541726;
				short num2 = num;
				num = (short)734416990;
				switch (num2 == num)
				{
				}
				num = (short)1995177984;
				short num3 = num;
				num = (short)527106048;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.StepSize = value;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x0009FC0C File Offset: 0x0009DE0C
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x0009FCBC File Offset: 0x0009DEBC
		public bool TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012_Applicable
		{
			get
			{
				short num = (short)1241466035;
				short num2 = num;
				num = (short)922502323;
				switch (num2 == num)
				{
				}
				num = (short)1302528001;
				if (num != 0)
				{
				}
				num = (short)1060700160;
				short num3 = num;
				num = (short)1020723200;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.Applicable;
			}
			set
			{
				short num = (short)1605366486;
				short num2 = num;
				num = (short)579597014;
				switch (num2 == num)
				{
				}
				num = (short)30605313;
				if (num != 0)
				{
				}
				num = (short)99418112;
				short num3 = num;
				num = (short)986906624;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.Applicable = value;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x0009FD70 File Offset: 0x0009DF70
		// (set) Token: 0x06000ACC RID: 2764 RVA: 0x0009FE24 File Offset: 0x0009E024
		public bool TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012_Valid
		{
			get
			{
				short num = (short)686793539;
				short num2 = num;
				num = (short)1655612227;
				switch (num2 == num)
				{
				}
				num = (short)1718091777;
				if (num != 0)
				{
				}
				num = (short)787873792;
				short num3 = num;
				num = (short)1065353216;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.Valid;
			}
			set
			{
				short num = (short)1099142150;
				short num2 = num;
				num = (short)397054982;
				switch (num2 == num)
				{
				}
				num = (short)1815347201;
				if (num != 0)
				{
				}
				num = (short)274595840;
				short num3 = num;
				num = (short)1272250368;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.Valid = value;
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x0009FED8 File Offset: 0x0009E0D8
		// (set) Token: 0x06000ACE RID: 2766 RVA: 0x0009FF8C File Offset: 0x0009E18C
		public bool TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012_Visible
		{
			get
			{
				short num = (short)1137513930;
				short num2 = num;
				num = (short)2066027978;
				switch (num2 == num)
				{
				}
				num = (short)2132475905;
				if (num != 0)
				{
				}
				num = (short)499318784;
				short num3 = num;
				num = (short)977993728;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.Visible;
			}
			set
			{
				short num = (short)1149501532;
				short num2 = num;
				num = (short)820183132;
				switch (num2 == num)
				{
				}
				num = (short)1119289345;
				if (num != 0)
				{
				}
				num = (short)1562771456;
				short num3 = num;
				num = (short)1361575936;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.Visible = value;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x000A0040 File Offset: 0x0009E240
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x000A00F4 File Offset: 0x0009E2F4
		public bool TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012_Editable
		{
			get
			{
				short num = (short)1417183837;
				short num2 = num;
				num = (short)2006155869;
				switch (num2 == num)
				{
				}
				num = (short)419102721;
				if (num != 0)
				{
				}
				num = (short)619839488;
				short num3 = num;
				num = (short)153419776;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.Editable;
			}
			set
			{
				short num = (short)1545085946;
				short num2 = num;
				num = (short)1053107194;
				switch (num2 == num)
				{
				}
				num = (short)621805569;
				if (num != 0)
				{
				}
				num = (short)572588032;
				short num3 = num;
				num = (short)288620544;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.Editable = value;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x000A01AC File Offset: 0x0009E3AC
		internal string TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012_UILabel
		{
			get
			{
				short num = (short)695533569;
				if (num != 0)
				{
				}
				num = (short)223064324;
				short num2 = num;
				num = (short)1520939268;
				switch (num2 == num)
				{
				}
				num = (short)173342720;
				short num3 = num;
				num = (short)1024262144;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.UIName;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x000A0260 File Offset: 0x0009E460
		// (set) Token: 0x06000AD3 RID: 2771 RVA: 0x000A0314 File Offset: 0x0009E514
		internal bool TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012_HiddenStatic
		{
			get
			{
				short num = (short)125670927;
				short num2 = num;
				num = (short)893425167;
				switch (num2 == num)
				{
				}
				num = (short)683606017;
				if (num != 0)
				{
				}
				num = (short)693043200;
				short num3 = num;
				num = (short)1610678272;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.HiddenStatic;
			}
			set
			{
				short num = (short)2013978891;
				short num2 = num;
				num = (short)2048909579;
				switch (num2 == num)
				{
				}
				num = (short)2011103233;
				if (num != 0)
				{
				}
				num = (short)1618935808;
				short num3 = num;
				num = (short)610533376;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.HiddenStatic = value;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x000A03C8 File Offset: 0x0009E5C8
		// (set) Token: 0x06000AD5 RID: 2773 RVA: 0x000A047C File Offset: 0x0009E67C
		internal bool TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012_HiddenDynamic
		{
			get
			{
				short num = (short)727318312;
				short num2 = num;
				num = (short)662765352;
				switch (num2 == num)
				{
				}
				num = (short)1661927425;
				if (num != 0)
				{
				}
				num = (short)827457536;
				short num3 = num;
				num = (short)160366592;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.HiddenDynamic;
			}
			set
			{
				short num = (short)1643642881;
				if (num != 0)
				{
				}
				num = (short)1580041208;
				short num2 = num;
				num = (short)586318840;
				switch (num2 == num)
				{
				}
				num = (short)1798963200;
				short num3 = num;
				num = (short)831651840;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.HiddenDynamic = value;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x000A0534 File Offset: 0x0009E734
		public bool TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012_HasDiffs
		{
			get
			{
				short num = (short)2004221953;
				if (num != 0)
				{
				}
				num = (short)1757579008;
				short num2 = num;
				num = (short)1332184832;
				switch (num2 == num)
				{
				}
				num = (short)631767040;
				short num3 = num;
				num = (short)1872429056;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012._HasDiffs;
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x000A05E8 File Offset: 0x0009E7E8
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x000A069C File Offset: 0x0009E89C
		public int TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029Value
		{
			get
			{
				short num = (short)66575317;
				short num2 = num;
				num = (short)1539562453;
				switch (num2 == num)
				{
				}
				num = (short)2111438848;
				if (num != 0)
				{
				}
				num = (short)1400569856;
				short num3 = num;
				num = (short)844038145;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Value;
			}
			set
			{
				short num = (short)1143036239;
				short num2 = num;
				num = (short)540170575;
				switch (num2 == num)
				{
				}
				num = (short)1360199681;
				if (num != 0)
				{
				}
				num = (short)1876819968;
				short num3 = num;
				num = (short)455213056;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Value = value;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x000A0750 File Offset: 0x0009E950
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x000A0804 File Offset: 0x0009EA04
		public string TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029_UIValue
		{
			get
			{
				short num = (short)1014926601;
				short num2 = num;
				num = (short)1382911241;
				switch (num2 == num)
				{
				}
				num = (short)740622337;
				if (num != 0)
				{
				}
				num = (short)1823932416;
				short num3 = num;
				num = (short)1940914176;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.UIValue;
			}
			set
			{
				short num = (short)1248133121;
				if (num != 0)
				{
				}
				num = (short)1820485641;
				short num2 = num;
				num = (short)484272137;
				switch (num2 == num)
				{
				}
				num = (short)172490752;
				short num3 = num;
				num = (short)1643053056;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.UIValue = value;
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x000A08BC File Offset: 0x0009EABC
		public global::AcpBusinessLayer.AcpFrequencyField TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029
		{
			get
			{
				short num = (short)40501249;
				if (num != 0)
				{
				}
				num = (short)701119211;
				short num2 = num;
				num = (short)1730296555;
				switch (num2 == num)
				{
				}
				num = (short)1727332352;
				short num3 = num;
				num = (short)579010560;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x000A096C File Offset: 0x0009EB6C
		// (set) Token: 0x06000ADD RID: 2781 RVA: 0x000A0A24 File Offset: 0x0009EC24
		internal int TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029Min
		{
			get
			{
				short num = (short)1908974818;
				short num2 = num;
				num = (short)2035590370;
				switch (num2 == num)
				{
				}
				num = (short)123076609;
				if (num != 0)
				{
				}
				num = (short)1619001344;
				short num3 = num;
				num = (short)454885376;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Min;
			}
			set
			{
				short num = (short)2088649769;
				short num2 = num;
				num = (short)1537819689;
				switch (num2 == num)
				{
				}
				num = (short)1667629057;
				if (num != 0)
				{
				}
				num = (short)104857600;
				short num3 = num;
				num = (short)615120896;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Min = value;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x000A0ADC File Offset: 0x0009ECDC
		// (set) Token: 0x06000ADF RID: 2783 RVA: 0x000A0B90 File Offset: 0x0009ED90
		internal int TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029Max
		{
			get
			{
				short num = (short)1008730113;
				if (num != 0)
				{
				}
				num = (short)1872965157;
				short num2 = num;
				num = (short)553397797;
				switch (num2 == num)
				{
				}
				num = (short)723058688;
				short num3 = num;
				num = (short)1333854208;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Max;
			}
			set
			{
				short num = (short)1449665291;
				short num2 = num;
				num = (short)792929035;
				switch (num2 == num)
				{
				}
				num = (short)896729088;
				if (num != 0)
				{
				}
				num = (short)899547136;
				short num3 = num;
				num = (short)1562771457;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Max = value;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x000A0C44 File Offset: 0x0009EE44
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x000A0CF4 File Offset: 0x0009EEF4
		internal int TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029Step
		{
			get
			{
				short num = (short)1643880292;
				short num2 = num;
				num = (short)574398308;
				switch (num2 == num)
				{
				}
				num = (short)1378156545;
				if (num != 0)
				{
				}
				num = (short)349372416;
				short num3 = num;
				num = (short)1050411008;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.StepSize;
			}
			set
			{
				short num = (short)272769031;
				short num2 = num;
				num = (short)2096701447;
				switch (num2 == num)
				{
				}
				num = (short)363266048;
				if (num != 0)
				{
				}
				num = (short)528809984;
				short num3 = num;
				num = (short)964820993;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.StepSize = value;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x000A0DAC File Offset: 0x0009EFAC
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x000A0E60 File Offset: 0x0009F060
		public bool TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029_Applicable
		{
			get
			{
				short num = (short)1813108446;
				short num2 = num;
				num = (short)1369298654;
				switch (num2 == num)
				{
				}
				num = (short)1813839873;
				if (num != 0)
				{
				}
				num = (short)1021444096;
				short num3 = num;
				num = (short)1670447104;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Applicable;
			}
			set
			{
				short num = (short)1545145394;
				short num2 = num;
				num = (short)464391218;
				switch (num2 == num)
				{
				}
				num = (short)302776321;
				if (num != 0)
				{
				}
				num = (short)927334400;
				short num3 = num;
				num = (short)1811808256;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Applicable = value;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x000A0F14 File Offset: 0x0009F114
		// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x000A0FC4 File Offset: 0x0009F1C4
		public bool TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029_Valid
		{
			get
			{
				short num = (short)1478487211;
				short num2 = num;
				num = (short)1353772203;
				switch (num2 == num)
				{
				}
				num = (short)741015552;
				if (num != 0)
				{
				}
				num = (short)1712390144;
				short num3 = num;
				num = (short)286588929;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Valid;
			}
			set
			{
				short num = (short)1437294750;
				short num2 = num;
				num = (short)408248478;
				switch (num2 == num)
				{
				}
				num = (short)256770049;
				if (num != 0)
				{
				}
				num = (short)1962606592;
				short num3 = num;
				num = (short)34537472;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Valid = value;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x000A1078 File Offset: 0x0009F278
		// (set) Token: 0x06000AE7 RID: 2791 RVA: 0x000A112C File Offset: 0x0009F32C
		public bool TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029_Visible
		{
			get
			{
				short num = (short)252821960;
				short num2 = num;
				num = (short)2064892360;
				switch (num2 == num)
				{
				}
				num = (short)636026881;
				if (num != 0)
				{
				}
				num = (short)52887552;
				short num3 = num;
				num = (short)2101280768;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Visible;
			}
			set
			{
				short num = (short)2078497085;
				short num2 = num;
				num = (short)1376934205;
				switch (num2 == num)
				{
				}
				num = (short)2048983041;
				if (num != 0)
				{
				}
				num = (short)805568512;
				short num3 = num;
				num = (short)1991311360;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Visible = value;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x000A11E4 File Offset: 0x0009F3E4
		// (set) Token: 0x06000AE9 RID: 2793 RVA: 0x000A1298 File Offset: 0x0009F498
		public bool TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029_Editable
		{
			get
			{
				short num = (short)974325524;
				short num2 = num;
				num = (short)959842068;
				switch (num2 == num)
				{
				}
				num = (short)995622912;
				if (num != 0)
				{
				}
				num = (short)2137587712;
				short num3 = num;
				num = (short)1718681601;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Editable;
			}
			set
			{
				short num = (short)1824375687;
				short num2 = num;
				num = (short)1727710087;
				switch (num2 == num)
				{
				}
				num = (short)371720193;
				if (num != 0)
				{
				}
				num = (short)699138048;
				short num3 = num;
				num = (short)1811152896;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Editable = value;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x000A1350 File Offset: 0x0009F550
		internal string TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029_UILabel
		{
			get
			{
				short num = (short)1836831319;
				short num2 = num;
				num = (short)966120023;
				switch (num2 == num)
				{
				}
				num = (short)1371471873;
				if (num != 0)
				{
				}
				num = (short)1810432000;
				short num3 = num;
				num = (short)1535049728;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.UIName;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x000A1408 File Offset: 0x0009F608
		// (set) Token: 0x06000AEC RID: 2796 RVA: 0x000A14BC File Offset: 0x0009F6BC
		internal bool TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029_HiddenStatic
		{
			get
			{
				short num = (short)764336674;
				short num2 = num;
				num = (short)1762122274;
				switch (num2 == num)
				{
				}
				num = (short)887554049;
				if (num != 0)
				{
				}
				num = (short)1283719168;
				short num3 = num;
				num = (short)2124480512;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.HiddenStatic;
			}
			set
			{
				short num = (short)1170875667;
				short num2 = num;
				num = (short)574825747;
				switch (num2 == num)
				{
				}
				num = (short)570425344;
				if (num != 0)
				{
				}
				num = (short)1636696064;
				short num3 = num;
				num = (short)1746599937;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.HiddenStatic = value;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x000A1570 File Offset: 0x0009F770
		// (set) Token: 0x06000AEE RID: 2798 RVA: 0x000A1628 File Offset: 0x0009F828
		internal bool TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029_HiddenDynamic
		{
			get
			{
				short num = (short)1823554655;
				short num2 = num;
				num = (short)1062747231;
				switch (num2 == num)
				{
				}
				num = (short)466944000;
				if (num != 0)
				{
				}
				num = (short)519569408;
				short num3 = num;
				num = (short)1355612161;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.HiddenDynamic;
			}
			set
			{
				short num = (short)659555844;
				short num2 = num;
				num = (short)1639940;
				switch (num2 == num)
				{
				}
				num = (short)10813441;
				if (num != 0)
				{
				}
				num = (short)636092416;
				short num3 = num;
				num = (short)215678976;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.HiddenDynamic = value;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x000A16E0 File Offset: 0x0009F8E0
		public bool TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029_HasDiffs
		{
			get
			{
				short num = (short)147720972;
				short num2 = num;
				num = (short)224529164;
				switch (num2 == num)
				{
				}
				num = (short)1792081921;
				if (num != 0)
				{
				}
				num = (short)1815937024;
				short num3 = num;
				num = (short)86245376;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029._HasDiffs;
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x000A1794 File Offset: 0x0009F994
		// (set) Token: 0x06000AF1 RID: 2801 RVA: 0x000A1848 File Offset: 0x0009FA48
		public bool TrkSysOBTChannelAssignmentListTxEnable_A9517Value
		{
			get
			{
				short num = (short)830558003;
				short num2 = num;
				num = (short)1753108275;
				switch (num2 == num)
				{
				}
				num = (short)2081947649;
				if (num != 0)
				{
				}
				num = (short)1688403968;
				short num3 = num;
				num = (short)1263927296;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxEnable_A9517.Value;
			}
			set
			{
				short num = (short)1813352395;
				short num2 = num;
				num = (short)512987083;
				switch (num2 == num)
				{
				}
				num = (short)1892876288;
				if (num != 0)
				{
				}
				num = (short)103153664;
				short num3 = num;
				num = (short)670760961;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListTxEnable_A9517.Value = value;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x000A1900 File Offset: 0x0009FB00
		public global::AcpBusinessLayer.AcpField<bool> TrkSysOBTChannelAssignmentListTxEnable_A9517
		{
			get
			{
				short num = (short)825489849;
				short num2 = num;
				num = (short)1306130873;
				switch (num2 == num)
				{
				}
				num = (short)1375535105;
				if (num != 0)
				{
				}
				num = (short)979173376;
				short num3 = num;
				num = (short)1544028160;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxEnable_A9517;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x000A19B0 File Offset: 0x0009FBB0
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x000A1A64 File Offset: 0x0009FC64
		public bool TrkSysOBTChannelAssignmentListTxEnable_A9517_UIValue
		{
			get
			{
				short num = (short)1526426333;
				short num2 = num;
				num = (short)708405981;
				switch (num2 == num)
				{
				}
				num = (short)2099380224;
				if (num != 0)
				{
				}
				num = (short)895090688;
				short num3 = num;
				num = (short)1081409537;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxEnable_A9517.Value;
			}
			set
			{
				short num = (short)638595401;
				short num2 = num;
				num = (short)1112944969;
				switch (num2 == num)
				{
				}
				num = (short)1410138112;
				if (num != 0)
				{
				}
				num = (short)1563885568;
				short num3 = num;
				num = (short)2059337729;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListTxEnable_A9517.Value = value;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x000A1B1C File Offset: 0x0009FD1C
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x000A1BD0 File Offset: 0x0009FDD0
		public bool TrkSysOBTChannelAssignmentListTxEnable_A9517_Applicable
		{
			get
			{
				short num = (short)1079276499;
				short num2 = num;
				num = (short)230323155;
				switch (num2 == num)
				{
				}
				num = (short)438632449;
				if (num != 0)
				{
				}
				num = (short)280756224;
				short num3 = num;
				num = (short)661848064;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxEnable_A9517.Applicable;
			}
			set
			{
				short num = (short)2048459429;
				short num2 = num;
				num = (short)375456421;
				switch (num2 == num)
				{
				}
				num = (short)1629159425;
				if (num != 0)
				{
				}
				num = (short)1001455616;
				short num3 = num;
				num = (short)1225654272;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListTxEnable_A9517.Applicable = value;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x000A1C8C File Offset: 0x0009FE8C
		// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x000A1D40 File Offset: 0x0009FF40
		public bool TrkSysOBTChannelAssignmentListTxEnable_A9517_Valid
		{
			get
			{
				short num = (short)1861369242;
				short num2 = num;
				num = (short)1245527450;
				switch (num2 == num)
				{
				}
				num = (short)467009536;
				if (num != 0)
				{
				}
				num = (short)71958528;
				short num3 = num;
				num = (short)568590337;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxEnable_A9517.Valid;
			}
			set
			{
				short num = (short)691981229;
				short num2 = num;
				num = (short)331074477;
				switch (num2 == num)
				{
				}
				num = (short)554303489;
				if (num != 0)
				{
				}
				num = (short)852492288;
				short num3 = num;
				num = (short)875954176;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListTxEnable_A9517.Valid = value;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x000A1DF4 File Offset: 0x0009FFF4
		// (set) Token: 0x06000AFA RID: 2810 RVA: 0x000A1EA8 File Offset: 0x000A00A8
		public bool TrkSysOBTChannelAssignmentListTxEnable_A9517_Visible
		{
			get
			{
				short num = (short)1936091768;
				short num2 = num;
				num = (short)1892772472;
				switch (num2 == num)
				{
				}
				num = (short)1041760257;
				if (num != 0)
				{
				}
				num = (short)1757216768;
				short num3 = num;
				num = (short)457244672;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxEnable_A9517.Visible;
			}
			set
			{
				short num = (short)804407775;
				short num2 = num;
				num = (short)1258572255;
				switch (num2 == num)
				{
				}
				num = (short)159449088;
				if (num != 0)
				{
				}
				num = (short)1073872896;
				short num3 = num;
				num = (short)397541377;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListTxEnable_A9517.Visible = value;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x000A1F60 File Offset: 0x000A0160
		// (set) Token: 0x06000AFC RID: 2812 RVA: 0x000A2014 File Offset: 0x000A0214
		public bool TrkSysOBTChannelAssignmentListTxEnable_A9517_Editable
		{
			get
			{
				short num = (short)1371135874;
				short num2 = num;
				num = (short)568582018;
				switch (num2 == num)
				{
				}
				num = (short)567934977;
				if (num != 0)
				{
				}
				num = (short)1521418240;
				short num3 = num;
				num = (short)1802698752;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxEnable_A9517.Editable;
			}
			set
			{
				short num = (short)1647706113;
				if (num != 0)
				{
				}
				num = (short)1057136361;
				short num2 = num;
				num = (short)495165161;
				switch (num2 == num)
				{
				}
				num = (short)385220608;
				short num3 = num;
				num = (short)23199744;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListTxEnable_A9517.Editable = value;
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x000A20C8 File Offset: 0x000A02C8
		internal string TrkSysOBTChannelAssignmentListTxEnable_A9517_UILabel
		{
			get
			{
				short num = (short)946101565;
				short num2 = num;
				num = (short)546200893;
				switch (num2 == num)
				{
				}
				num = (short)1013514241;
				if (num != 0)
				{
				}
				num = (short)502726656;
				short num3 = num;
				num = (short)707723264;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxEnable_A9517.UIName;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x000A2178 File Offset: 0x000A0378
		// (set) Token: 0x06000AFF RID: 2815 RVA: 0x000A2228 File Offset: 0x000A0428
		internal bool TrkSysOBTChannelAssignmentListTxEnable_A9517_HiddenStatic
		{
			get
			{
				short num = (short)1394018920;
				short num2 = num;
				num = (short)237767272;
				switch (num2 == num)
				{
				}
				num = (short)354091008;
				if (num != 0)
				{
				}
				num = (short)1094320128;
				short num3 = num;
				num = (short)745799681;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxEnable_A9517.HiddenStatic;
			}
			set
			{
				short num = (short)1197280308;
				short num2 = num;
				num = (short)396626996;
				switch (num2 == num)
				{
				}
				num = (short)202178560;
				if (num != 0)
				{
				}
				num = (short)733282304;
				short num3 = num;
				num = (short)357892097;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListTxEnable_A9517.HiddenStatic = value;
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06000B00 RID: 2816 RVA: 0x000A22DC File Offset: 0x000A04DC
		// (set) Token: 0x06000B01 RID: 2817 RVA: 0x000A2394 File Offset: 0x000A0594
		internal bool TrkSysOBTChannelAssignmentListTxEnable_A9517_HiddenDynamic
		{
			get
			{
				short num = (short)1280054925;
				short num2 = num;
				num = (short)1747457677;
				switch (num2 == num)
				{
				}
				num = (short)1013121025;
				if (num != 0)
				{
				}
				num = (short)827588608;
				short num3 = num;
				num = (short)864747520;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxEnable_A9517.HiddenDynamic;
			}
			set
			{
				short num = (short)956944331;
				short num2 = num;
				num = (short)1920389067;
				switch (num2 == num)
				{
				}
				num = (short)1749286912;
				if (num != 0)
				{
				}
				num = (short)402849792;
				short num3 = num;
				num = (short)779747329;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListTxEnable_A9517.HiddenDynamic = value;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06000B02 RID: 2818 RVA: 0x000A244C File Offset: 0x000A064C
		public bool TrkSysOBTChannelAssignmentListTxEnable_A9517_HasDiffs
		{
			get
			{
				short num = (short)1784741889;
				if (num != 0)
				{
				}
				num = (short)1487995870;
				short num2 = num;
				num = (short)1892484062;
				switch (num2 == num)
				{
				}
				num = (short)717619200;
				short num3 = num;
				num = (short)813105152;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxEnable_A9517._HasDiffs;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x000A2500 File Offset: 0x000A0700
		// (set) Token: 0x06000B04 RID: 2820 RVA: 0x000A25B4 File Offset: 0x000A07B4
		public int TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520Value
		{
			get
			{
				short num = (short)1844868095;
				short num2 = num;
				num = (short)729445375;
				switch (num2 == num)
				{
				}
				num = (short)1909063681;
				if (num != 0)
				{
				}
				num = (short)726204416;
				short num3 = num;
				num = (short)525991936;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.Value;
			}
			set
			{
				short num = (short)833617921;
				if (num != 0)
				{
				}
				num = (short)701120235;
				short num2 = num;
				num = (short)2133016299;
				switch (num2 == num)
				{
				}
				num = (short)1522139136;
				short num3 = num;
				num = (short)508952576;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.Value = value;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x000A2668 File Offset: 0x000A0868
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x000A2718 File Offset: 0x000A0918
		public string TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520_UIValue
		{
			get
			{
				short num = (short)300875777;
				if (num != 0)
				{
				}
				num = (short)853603370;
				short num2 = num;
				num = (short)1840378922;
				switch (num2 == num)
				{
				}
				num = (short)983498752;
				short num3 = num;
				num = (short)888078336;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.UIValue;
			}
			set
			{
				short num = (short)368088497;
				short num2 = num;
				num = (short)1521325489;
				switch (num2 == num)
				{
				}
				num = (short)1179844609;
				if (num != 0)
				{
				}
				num = (short)58589184;
				short num3 = num;
				num = (short)178847744;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.UIValue = value;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x000A27CC File Offset: 0x000A09CC
		public global::AcpBusinessLayer.AcpListField TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520
		{
			get
			{
				short num = (short)1413742593;
				if (num != 0)
				{
				}
				num = (short)828031836;
				short num2 = num;
				num = (short)1758577500;
				switch (num2 == num)
				{
				}
				num = (short)833290240;
				short num3 = num;
				num = (short)489684992;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x000A287C File Offset: 0x000A0A7C
		// (set) Token: 0x06000B09 RID: 2825 RVA: 0x000A2934 File Offset: 0x000A0B34
		public bool TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520_Applicable
		{
			get
			{
				short num = (short)556592955;
				short num2 = num;
				num = (short)1787555643;
				switch (num2 == num)
				{
				}
				num = (short)935198721;
				if (num != 0)
				{
				}
				num = (short)2011168768;
				short num3 = num;
				num = (short)300744704;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.Applicable;
			}
			set
			{
				short num = (short)2085043409;
				short num2 = num;
				num = (short)1261583569;
				switch (num2 == num)
				{
				}
				num = (short)142344193;
				if (num != 0)
				{
				}
				num = (short)1850736640;
				short num3 = num;
				num = (short)120848384;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.Applicable = value;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x000A29E8 File Offset: 0x000A0BE8
		// (set) Token: 0x06000B0B RID: 2827 RVA: 0x000A2A9C File Offset: 0x000A0C9C
		public bool TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520_Valid
		{
			get
			{
				short num = (short)1186060791;
				short num2 = num;
				num = (short)1615714807;
				switch (num2 == num)
				{
				}
				num = (short)2071265281;
				if (num != 0)
				{
				}
				num = (short)722403328;
				short num3 = num;
				num = (short)83558400;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.Valid;
			}
			set
			{
				short num = (short)1378827169;
				short num2 = num;
				num = (short)1969896353;
				switch (num2 == num)
				{
				}
				num = (short)1386283009;
				if (num != 0)
				{
				}
				num = (short)948436992;
				short num3 = num;
				num = (short)813432832;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.Valid = value;
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x000A2B50 File Offset: 0x000A0D50
		// (set) Token: 0x06000B0D RID: 2829 RVA: 0x000A2C04 File Offset: 0x000A0E04
		public bool TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520_Visible
		{
			get
			{
				short num = (short)1432400288;
				short num2 = num;
				num = (short)11973024;
				switch (num2 == num)
				{
				}
				num = (short)1990918145;
				if (num != 0)
				{
				}
				num = (short)671023104;
				short num3 = num;
				num = (short)381747200;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.Visible;
			}
			set
			{
				short num = (short)1899670750;
				short num2 = num;
				num = (short)132099294;
				switch (num2 == num)
				{
				}
				num = (short)780468225;
				if (num != 0)
				{
				}
				num = (short)1307443200;
				short num3 = num;
				num = (short)102236160;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.Visible = value;
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x000A2CB8 File Offset: 0x000A0EB8
		// (set) Token: 0x06000B0F RID: 2831 RVA: 0x000A2D70 File Offset: 0x000A0F70
		public bool TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520_Editable
		{
			get
			{
				short num = (short)330348225;
				short num2 = num;
				num = (short)642823873;
				switch (num2 == num)
				{
				}
				num = (short)35454976;
				if (num != 0)
				{
				}
				num = (short)1308622848;
				short num3 = num;
				num = (short)1115160577;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.Editable;
			}
			set
			{
				short num = (short)1845763312;
				short num2 = num;
				num = (short)694164720;
				switch (num2 == num)
				{
				}
				num = (short)663683072;
				if (num != 0)
				{
				}
				num = (short)1490944000;
				short num3 = num;
				num = (short)1265172481;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.Editable = value;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x000A2E24 File Offset: 0x000A1024
		internal string TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520_UILabel
		{
			get
			{
				short num = (short)911509253;
				short num2 = num;
				num = (short)814712581;
				switch (num2 == num)
				{
				}
				num = (short)1770192897;
				if (num != 0)
				{
				}
				num = (short)64815104;
				short num3 = num;
				num = (short)726532096;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.UIName;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x000A2ED8 File Offset: 0x000A10D8
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x000A2F8C File Offset: 0x000A118C
		internal bool TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520_HiddenStatic
		{
			get
			{
				short num = (short)180313341;
				short num2 = num;
				num = (short)1814060285;
				switch (num2 == num)
				{
				}
				num = (short)720699392;
				if (num != 0)
				{
				}
				num = (short)341311488;
				short num3 = num;
				num = (short)1478950913;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.HiddenStatic;
			}
			set
			{
				short num = (short)1123740600;
				short num2 = num;
				num = (short)209251256;
				switch (num2 == num)
				{
				}
				num = (short)938606593;
				if (num != 0)
				{
				}
				num = (short)1640300544;
				short num3 = num;
				num = (short)1596588032;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.HiddenStatic = value;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x000A3044 File Offset: 0x000A1244
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x000A30F8 File Offset: 0x000A12F8
		internal bool TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520_HiddenDynamic
		{
			get
			{
				short num = (short)1074992406;
				short num2 = num;
				num = (short)1473254678;
				switch (num2 == num)
				{
				}
				num = (short)1840381953;
				if (num != 0)
				{
				}
				num = (short)1966997504;
				short num3 = num;
				num = (short)2124087296;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.HiddenDynamic;
			}
			set
			{
				short num = (short)678709872;
				short num2 = num;
				num = (short)1725844080;
				switch (num2 == num)
				{
				}
				num = (short)779288576;
				if (num != 0)
				{
				}
				num = (short)96206848;
				short num3 = num;
				num = (short)836042753;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520.HiddenDynamic = value;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x000A31AC File Offset: 0x000A13AC
		public bool TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520_HasDiffs
		{
			get
			{
				short num = (short)1967783937;
				if (num != 0)
				{
				}
				num = (short)328778567;
				short num2 = num;
				num = (short)858440519;
				switch (num2 == num)
				{
				}
				num = (short)1944453120;
				short num3 = num;
				num = (short)1179123712;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxSpacingKHz_A9520._HasDiffs;
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x000A3260 File Offset: 0x000A1460
		// (set) Token: 0x06000B17 RID: 2839 RVA: 0x000A3314 File Offset: 0x000A1514
		public int TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529Value
		{
			get
			{
				short num = (short)171766209;
				short num2 = num;
				num = (short)595194305;
				switch (num2 == num)
				{
				}
				num = (short)608960512;
				if (num != 0)
				{
				}
				num = (short)791281664;
				short num3 = num;
				num = (short)833748993;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.Value;
			}
			set
			{
				short num = (short)2072587152;
				short num2 = num;
				num = (short)758066064;
				switch (num2 == num)
				{
				}
				num = (short)535232513;
				if (num != 0)
				{
				}
				num = (short)2103902208;
				short num3 = num;
				num = (short)1829240832;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.Value = value;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x000A33C8 File Offset: 0x000A15C8
		// (set) Token: 0x06000B19 RID: 2841 RVA: 0x000A347C File Offset: 0x000A167C
		public string TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529_UIValue
		{
			get
			{
				short num = (short)74456417;
				short num2 = num;
				num = (short)404299105;
				switch (num2 == num)
				{
				}
				num = (short)2124546049;
				if (num != 0)
				{
				}
				num = (short)1460666368;
				short num3 = num;
				num = (short)73007104;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.UIValue;
			}
			set
			{
				short num = (short)737188163;
				short num2 = num;
				num = (short)1664915779;
				switch (num2 == num)
				{
				}
				num = (short)1775435777;
				if (num != 0)
				{
				}
				num = (short)230293504;
				short num3 = num;
				num = (short)1764360192;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.UIValue = value;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x000A3530 File Offset: 0x000A1730
		public global::AcpBusinessLayer.AcpFrequencyField TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529
		{
			get
			{
				short num = (short)1883652229;
				short num2 = num;
				num = (short)1387479173;
				switch (num2 == num)
				{
				}
				num = (short)1892155392;
				if (num != 0)
				{
				}
				num = (short)1537998848;
				short num3 = num;
				num = (short)1715208193;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x000A35E4 File Offset: 0x000A17E4
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x000A3694 File Offset: 0x000A1894
		internal int TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529Min
		{
			get
			{
				short num = (short)99582514;
				short num2 = num;
				num = (short)1639481906;
				switch (num2 == num)
				{
				}
				num = (short)2023292929;
				if (num != 0)
				{
				}
				num = (short)1869742080;
				short num3 = num;
				num = (short)1547173888;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.Min;
			}
			set
			{
				short num = (short)1645876927;
				short num2 = num;
				num = (short)1685984959;
				switch (num2 == num)
				{
				}
				num = (short)1836449793;
				if (num != 0)
				{
				}
				num = (short)1261699072;
				short num3 = num;
				num = (short)2023948288;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.Min = value;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x000A374C File Offset: 0x000A194C
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x000A3800 File Offset: 0x000A1A00
		internal int TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529Max
		{
			get
			{
				short num = (short)561373766;
				short num2 = num;
				num = (short)1379328582;
				switch (num2 == num)
				{
				}
				num = (short)1128136705;
				if (num != 0)
				{
				}
				num = (short)1857683456;
				short num3 = num;
				num = (short)1302003712;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.Max;
			}
			set
			{
				short num = (short)1792278529;
				if (num != 0)
				{
				}
				num = (short)1377548883;
				short num2 = num;
				num = (short)1299036755;
				switch (num2 == num)
				{
				}
				num = (short)1135804416;
				short num3 = num;
				num = (short)432668672;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.Max = value;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x000A38B4 File Offset: 0x000A1AB4
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x000A396C File Offset: 0x000A1B6C
		internal int TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529Step
		{
			get
			{
				short num = (short)1470343639;
				short num2 = num;
				num = (short)1464314327;
				switch (num2 == num)
				{
				}
				num = (short)414777345;
				if (num != 0)
				{
				}
				num = (short)1088815104;
				short num3 = num;
				num = (short)88408064;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.StepSize;
			}
			set
			{
				short num = (short)348895519;
				short num2 = num;
				num = (short)907262239;
				switch (num2 == num)
				{
				}
				num = (short)1289682945;
				if (num != 0)
				{
				}
				num = (short)458620928;
				short num3 = num;
				num = (short)1553203200;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.StepSize = value;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x000A3A20 File Offset: 0x000A1C20
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x000A3AD4 File Offset: 0x000A1CD4
		public bool TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529_Applicable
		{
			get
			{
				short num = (short)2073740834;
				short num2 = num;
				num = (short)2032977442;
				switch (num2 == num)
				{
				}
				num = (short)1698234369;
				if (num != 0)
				{
				}
				num = (short)1207435264;
				short num3 = num;
				num = (short)1908801536;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.Applicable;
			}
			set
			{
				short num = (short)177864705;
				if (num != 0)
				{
				}
				num = (short)1355400084;
				short num2 = num;
				num = (short)655999892;
				switch (num2 == num)
				{
				}
				num = (short)36175872;
				short num3 = num;
				num = (short)1542062080;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.Applicable = value;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x000A3B88 File Offset: 0x000A1D88
		// (set) Token: 0x06000B24 RID: 2852 RVA: 0x000A3C3C File Offset: 0x000A1E3C
		public bool TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529_Valid
		{
			get
			{
				short num = (short)1774714881;
				if (num != 0)
				{
				}
				num = (short)949114183;
				short num2 = num;
				num = (short)2010076487;
				switch (num2 == num)
				{
				}
				num = (short)851574784;
				short num3 = num;
				num = (short)246808576;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.Valid;
			}
			set
			{
				short num = (short)1692874881;
				short num2 = num;
				num = (short)1587034241;
				switch (num2 == num)
				{
				}
				num = (short)126615552;
				if (num != 0)
				{
				}
				num = (short)239927296;
				short num3 = num;
				num = (short)670695425;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.Valid = value;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x000A3CF0 File Offset: 0x000A1EF0
		// (set) Token: 0x06000B26 RID: 2854 RVA: 0x000A3DA8 File Offset: 0x000A1FA8
		public bool TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529_Visible
		{
			get
			{
				short num = (short)1396412933;
				short num2 = num;
				num = (short)897946117;
				switch (num2 == num)
				{
				}
				num = (short)1976041473;
				if (num != 0)
				{
				}
				num = (short)778436608;
				short num3 = num;
				num = (short)576389120;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.Visible;
			}
			set
			{
				short num = (short)636865568;
				short num2 = num;
				num = (short)1836764192;
				switch (num2 == num)
				{
				}
				num = (short)751239169;
				if (num != 0)
				{
				}
				num = (short)1127088128;
				short num3 = num;
				num = (short)107479040;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.Visible = value;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x000A3E60 File Offset: 0x000A2060
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x000A3F14 File Offset: 0x000A2114
		public bool TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529_Editable
		{
			get
			{
				short num = (short)2034588424;
				short num2 = num;
				num = (short)1977899784;
				switch (num2 == num)
				{
				}
				num = (short)402915329;
				if (num != 0)
				{
				}
				num = (short)409600000;
				short num3 = num;
				num = (short)240123904;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.Editable;
			}
			set
			{
				short num = (short)1438841369;
				short num2 = num;
				num = (short)1349188121;
				switch (num2 == num)
				{
				}
				num = (short)555941889;
				if (num != 0)
				{
				}
				num = (short)141361152;
				short num3 = num;
				num = (short)1621164032;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.Editable = value;
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x000A3FC8 File Offset: 0x000A21C8
		internal string TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529_UILabel
		{
			get
			{
				short num = (short)1733965404;
				short num2 = num;
				num = (short)1379481180;
				switch (num2 == num)
				{
				}
				num = (short)320602113;
				if (num != 0)
				{
				}
				num = (short)237502464;
				short num3 = num;
				num = (short)1228341248;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.UIName;
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06000B2A RID: 2858 RVA: 0x000A407C File Offset: 0x000A227C
		// (set) Token: 0x06000B2B RID: 2859 RVA: 0x000A4130 File Offset: 0x000A2330
		internal bool TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529_HiddenStatic
		{
			get
			{
				short num = (short)733576097;
				short num2 = num;
				num = (short)145980321;
				switch (num2 == num)
				{
				}
				num = (short)1868627969;
				if (num != 0)
				{
				}
				num = (short)187760640;
				short num3 = num;
				num = (short)1871249408;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.HiddenStatic;
			}
			set
			{
				short num = (short)38466679;
				short num2 = num;
				num = (short)1593308279;
				switch (num2 == num)
				{
				}
				num = (short)401211392;
				if (num != 0)
				{
				}
				num = (short)1219624961;
				if (num != 0)
				{
				}
				num = (short)446234624;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.HiddenStatic = value;
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x000A41E4 File Offset: 0x000A23E4
		// (set) Token: 0x06000B2D RID: 2861 RVA: 0x000A4298 File Offset: 0x000A2498
		internal bool TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529_HiddenDynamic
		{
			get
			{
				short num = (short)768514524;
				short num2 = num;
				num = (short)483170780;
				switch (num2 == num)
				{
				}
				num = (short)1493172225;
				if (num != 0)
				{
				}
				num = (short)1420886016;
				if (num != 0)
				{
				}
				num = (short)604962816;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.HiddenDynamic;
			}
			set
			{
				short num = (short)1236059908;
				short num2 = num;
				num = (short)338413316;
				switch (num2 == num)
				{
				}
				num = (short)961806337;
				if (num != 0)
				{
				}
				num = (short)693698560;
				if (num != 0)
				{
				}
				num = (short)1928396800;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.HiddenDynamic = value;
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x000A434C File Offset: 0x000A254C
		public bool TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529_HasDiffs
		{
			get
			{
				short num = (short)343772153;
				short num2 = num;
				num = (short)1148816377;
				switch (num2 == num)
				{
				}
				num = (short)1505558529;
				if (num != 0)
				{
				}
				num = (short)100007936;
				if (num != 0)
				{
				}
				num = (short)1849163776;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529._HasDiffs;
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x000A4400 File Offset: 0x000A2600
		// (set) Token: 0x06000B30 RID: 2864 RVA: 0x000A44B4 File Offset: 0x000A26B4
		public int TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568Value
		{
			get
			{
				short num = (short)181739214;
				short num2 = num;
				num = (short)1280646862;
				switch (num2 == num)
				{
				}
				num = (short)1307836416;
				if (num != 0)
				{
				}
				num = (short)734134273;
				if (num != 0)
				{
				}
				num = (short)1931149312;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Value;
			}
			set
			{
				short num = (short)767865783;
				short num2 = num;
				num = (short)618378167;
				switch (num2 == num)
				{
				}
				num = (short)1419837441;
				if (num != 0)
				{
				}
				num = (short)1114570752;
				if (num != 0)
				{
				}
				num = (short)597032960;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Value = value;
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x000A4568 File Offset: 0x000A2768
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x000A4620 File Offset: 0x000A2820
		public string TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568_UIValue
		{
			get
			{
				short num = (short)407710959;
				short num2 = num;
				num = (short)851455215;
				switch (num2 == num)
				{
				}
				num = (short)1084882945;
				if (num != 0)
				{
				}
				num = (short)592904192;
				if (num != 0)
				{
				}
				num = (short)10420224;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.UIValue;
			}
			set
			{
				short num = (short)745756796;
				short num2 = num;
				num = (short)1180129404;
				switch (num2 == num)
				{
				}
				num = (short)1267924992;
				if (num != 0)
				{
				}
				num = (short)1689714689;
				if (num != 0)
				{
				}
				num = (short)1282211840;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.UIValue = value;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x000A46D4 File Offset: 0x000A28D4
		public global::AcpBusinessLayer.AcpFrequencyField TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568
		{
			get
			{
				short num = (short)1691959788;
				short num2 = num;
				num = (short)1202799084;
				switch (num2 == num)
				{
				}
				num = (short)1066729473;
				if (num != 0)
				{
				}
				num = (short)607584256;
				if (num != 0)
				{
				}
				num = (short)962265088;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568;
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x000A4784 File Offset: 0x000A2984
		// (set) Token: 0x06000B35 RID: 2869 RVA: 0x000A4838 File Offset: 0x000A2A38
		internal int TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568Min
		{
			get
			{
				short num = (short)756183428;
				short num2 = num;
				num = (short)240611716;
				switch (num2 == num)
				{
				}
				num = (short)2099380224;
				if (num != 0)
				{
				}
				num = (short)1746665473;
				if (num != 0)
				{
				}
				num = (short)395771904;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Min;
			}
			set
			{
				short num = (short)802878801;
				short num2 = num;
				num = (short)1168569681;
				switch (num2 == num)
				{
				}
				num = (short)695140353;
				if (num != 0)
				{
				}
				num = (short)1780088832;
				if (num != 0)
				{
				}
				num = (short)1810694144;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Min = value;
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x000A48EC File Offset: 0x000A2AEC
		// (set) Token: 0x06000B37 RID: 2871 RVA: 0x000A49A0 File Offset: 0x000A2BA0
		internal int TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568Max
		{
			get
			{
				short num = (short)799982019;
				short num2 = num;
				num = (short)845070787;
				switch (num2 == num)
				{
				}
				num = (short)1086717952;
				if (num != 0)
				{
				}
				num = (short)682295297;
				if (num != 0)
				{
				}
				num = (short)1220083712;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Max;
			}
			set
			{
				short num = (short)1952600901;
				short num2 = num;
				num = (short)1075073861;
				switch (num2 == num)
				{
				}
				num = (short)251527169;
				if (num != 0)
				{
				}
				num = (short)1557528576;
				if (num != 0)
				{
				}
				num = (short)1880817664;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Max = value;
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x000A4A58 File Offset: 0x000A2C58
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x000A4B0C File Offset: 0x000A2D0C
		internal int TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568Step
		{
			get
			{
				short num = (short)1130889217;
				if (num != 0)
				{
				}
				num = (short)45997578;
				short num2 = num;
				num = (short)1640816138;
				switch (num2 == num)
				{
				}
				num = (short)1310851072;
				if (num != 0)
				{
				}
				num = (short)1520435200;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.StepSize;
			}
			set
			{
				short num = (short)898357325;
				short num2 = num;
				num = (short)1805637709;
				switch (num2 == num)
				{
				}
				num = (short)1183252481;
				if (num != 0)
				{
				}
				num = (short)815988736;
				if (num != 0)
				{
				}
				num = (short)999292928;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.StepSize = value;
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x000A4BC4 File Offset: 0x000A2DC4
		// (set) Token: 0x06000B3B RID: 2875 RVA: 0x000A4C7C File Offset: 0x000A2E7C
		public bool TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568_Applicable
		{
			get
			{
				short num = (short)607540894;
				short num2 = num;
				num = (short)1675843230;
				switch (num2 == num)
				{
				}
				num = (short)937820161;
				if (num != 0)
				{
				}
				num = (short)81920000;
				if (num != 0)
				{
				}
				num = (short)234553344;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Applicable;
			}
			set
			{
				short num = (short)153396647;
				short num2 = num;
				num = (short)1258005927;
				switch (num2 == num)
				{
				}
				num = (short)48037889;
				if (num != 0)
				{
				}
				num = (short)44761088;
				if (num != 0)
				{
				}
				num = (short)1380909056;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Applicable = value;
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x000A4D30 File Offset: 0x000A2F30
		// (set) Token: 0x06000B3D RID: 2877 RVA: 0x000A4DE8 File Offset: 0x000A2FE8
		public bool TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568_Valid
		{
			get
			{
				short num = (short)1284374529;
				if (num != 0)
				{
				}
				num = (short)774878117;
				short num2 = num;
				num = (short)1352840101;
				switch (num2 == num)
				{
				}
				num = (short)1340932096;
				if (num != 0)
				{
				}
				num = (short)423034880;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Valid;
			}
			set
			{
				short num = (short)502928255;
				short num2 = num;
				num = (short)760615807;
				switch (num2 == num)
				{
				}
				num = (short)1939800065;
				if (num != 0)
				{
				}
				num = (short)2059468800;
				if (num != 0)
				{
				}
				num = (short)860291072;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Valid = value;
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06000B3E RID: 2878 RVA: 0x000A4EA0 File Offset: 0x000A30A0
		// (set) Token: 0x06000B3F RID: 2879 RVA: 0x000A4F58 File Offset: 0x000A3158
		public bool TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568_Visible
		{
			get
			{
				short num = (short)2090970268;
				short num2 = num;
				num = (short)58371228;
				switch (num2 == num)
				{
				}
				num = (short)330301441;
				if (num != 0)
				{
				}
				num = (short)1480458240;
				if (num != 0)
				{
				}
				num = (short)1702887424;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Visible;
			}
			set
			{
				short num = (short)858721525;
				short num2 = num;
				num = (short)570887413;
				switch (num2 == num)
				{
				}
				num = (short)739377153;
				if (num != 0)
				{
				}
				num = (short)2046099456;
				if (num != 0)
				{
				}
				num = (short)673710080;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Visible = value;
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x000A500C File Offset: 0x000A320C
		// (set) Token: 0x06000B41 RID: 2881 RVA: 0x000A50C0 File Offset: 0x000A32C0
		public bool TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568_Editable
		{
			get
			{
				short num = (short)541426301;
				short num2 = num;
				num = (short)1173455485;
				switch (num2 == num)
				{
				}
				num = (short)1881735169;
				if (num != 0)
				{
				}
				num = (short)2066087936;
				if (num != 0)
				{
				}
				num = (short)463863808;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Editable;
			}
			set
			{
				short num = (short)1474179104;
				short num2 = num;
				num = (short)1990078496;
				switch (num2 == num)
				{
				}
				num = (short)40632320;
				if (num != 0)
				{
				}
				num = (short)1165099009;
				if (num != 0)
				{
				}
				num = (short)679673856;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Editable = value;
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x000A5178 File Offset: 0x000A3378
		internal string TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568_UILabel
		{
			get
			{
				short num = (short)1833730690;
				short num2 = num;
				num = (short)1462993538;
				switch (num2 == num)
				{
				}
				num = (short)1597833216;
				if (num != 0)
				{
				}
				num = (short)1914306561;
				if (num != 0)
				{
				}
				num = (short)783220736;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.UIName;
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x000A522C File Offset: 0x000A342C
		// (set) Token: 0x06000B44 RID: 2884 RVA: 0x000A52E0 File Offset: 0x000A34E0
		internal bool TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568_HiddenStatic
		{
			get
			{
				short num = (short)1310976893;
				short num2 = num;
				num = (short)668789629;
				switch (num2 == num)
				{
				}
				num = (short)411762688;
				if (num != 0)
				{
				}
				num = (short)467795969;
				if (num != 0)
				{
				}
				num = (short)1753808896;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.HiddenStatic;
			}
			set
			{
				short num = (short)1664411978;
				short num2 = num;
				num = (short)548661578;
				switch (num2 == num)
				{
				}
				num = (short)1200816129;
				if (num != 0)
				{
				}
				num = (short)1768030208;
				if (num != 0)
				{
				}
				num = (short)1475149824;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.HiddenStatic = value;
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x000A5394 File Offset: 0x000A3594
		// (set) Token: 0x06000B46 RID: 2886 RVA: 0x000A544C File Offset: 0x000A364C
		internal bool TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568_HiddenDynamic
		{
			get
			{
				short num = (short)1053909369;
				short num2 = num;
				num = (short)452354425;
				switch (num2 == num)
				{
				}
				num = (short)1719468033;
				if (num != 0)
				{
				}
				num = (short)1225261056;
				if (num != 0)
				{
				}
				num = (short)2089287680;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.HiddenDynamic;
			}
			set
			{
				short num = (short)1444144238;
				short num2 = num;
				num = (short)1092543598;
				switch (num2 == num)
				{
				}
				num = (short)1154809856;
				if (num != 0)
				{
				}
				num = (short)444203009;
				if (num != 0)
				{
				}
				num = (short)638517248;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.HiddenDynamic = value;
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x000A5504 File Offset: 0x000A3704
		public bool TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568_HasDiffs
		{
			get
			{
				short num = (short)988935423;
				short num2 = num;
				num = (short)1444148479;
				switch (num2 == num)
				{
				}
				num = (short)218103808;
				if (num != 0)
				{
				}
				num = (short)1383202817;
				if (num != 0)
				{
				}
				num = (short)1714356224;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568._HasDiffs;
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x000A55B8 File Offset: 0x000A37B8
		// (set) Token: 0x06000B49 RID: 2889 RVA: 0x000A5670 File Offset: 0x000A3870
		public int TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478Value
		{
			get
			{
				short num = (short)814256348;
				short num2 = num;
				num = (short)1818398940;
				switch (num2 == num)
				{
				}
				num = (short)401866753;
				if (num != 0)
				{
				}
				num = (short)769785856;
				if (num != 0)
				{
				}
				num = (short)336265216;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.Value;
			}
			set
			{
				short num = (short)1110347951;
				short num2 = num;
				num = (short)20549807;
				switch (num2 == num)
				{
				}
				num = (short)1193869312;
				if (num != 0)
				{
				}
				num = (short)747700225;
				if (num != 0)
				{
				}
				num = (short)1916010496;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.Value = value;
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06000B4A RID: 2890 RVA: 0x000A5728 File Offset: 0x000A3928
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478
		{
			get
			{
				short num = (short)308019201;
				if (num != 0)
				{
				}
				num = (short)1611340541;
				short num2 = num;
				num = (short)1371478781;
				switch (num2 == num)
				{
				}
				num = (short)1814036480;
				if (num != 0)
				{
				}
				num = (short)591069184;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478;
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x000A57D8 File Offset: 0x000A39D8
		// (set) Token: 0x06000B4C RID: 2892 RVA: 0x000A5890 File Offset: 0x000A3A90
		public string TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478_UIValue
		{
			get
			{
				short num = (short)1060377619;
				short num2 = num;
				num = (short)363074579;
				switch (num2 == num)
				{
				}
				num = (short)96010241;
				if (num != 0)
				{
				}
				num = (short)620756992;
				if (num != 0)
				{
				}
				num = (short)391380992;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.UIValue;
			}
			set
			{
				short num = (short)1962559398;
				short num2 = num;
				num = (short)2097629094;
				switch (num2 == num)
				{
				}
				num = (short)1399455745;
				if (num != 0)
				{
				}
				num = (short)20316160;
				if (num != 0)
				{
				}
				num = (short)1163526144;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.UIValue = value;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x000A5944 File Offset: 0x000A3B44
		// (set) Token: 0x06000B4E RID: 2894 RVA: 0x000A59F8 File Offset: 0x000A3BF8
		public string TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478_HexUIValue
		{
			get
			{
				short num = (short)1837825353;
				short num2 = num;
				num = (short)1073937737;
				switch (num2 == num)
				{
				}
				num = (short)1668087808;
				if (num != 0)
				{
				}
				num = (short)136970241;
				if (num != 0)
				{
				}
				num = (short)1792081920;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.HexUIValue;
			}
			set
			{
				short num = (short)1988989364;
				short num2 = num;
				num = (short)1556976052;
				switch (num2 == num)
				{
				}
				num = (short)1933115393;
				if (num != 0)
				{
				}
				num = (short)397017088;
				if (num != 0)
				{
				}
				num = (short)1759051776;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.HexUIValue = value;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x000A5AAC File Offset: 0x000A3CAC
		// (set) Token: 0x06000B50 RID: 2896 RVA: 0x000A5B5C File Offset: 0x000A3D5C
		internal int TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478Min
		{
			get
			{
				short num = (short)682317404;
				short num2 = num;
				num = (short)647059036;
				switch (num2 == num)
				{
				}
				num = (short)63635456;
				if (num != 0)
				{
				}
				num = (short)1081802753;
				if (num != 0)
				{
				}
				num = (short)866385920;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.Min;
			}
			set
			{
				short num = (short)148507978;
				short num2 = num;
				num = (short)1184304458;
				switch (num2 == num)
				{
				}
				num = (short)2063466497;
				if (num != 0)
				{
				}
				num = (short)290193408;
				if (num != 0)
				{
				}
				num = (short)1675886592;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.Min = value;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x000A5C14 File Offset: 0x000A3E14
		// (set) Token: 0x06000B52 RID: 2898 RVA: 0x000A5CCC File Offset: 0x000A3ECC
		internal int TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478Max
		{
			get
			{
				short num = (short)520823222;
				short num2 = num;
				num = (short)1412047286;
				switch (num2 == num)
				{
				}
				num = (short)926089217;
				if (num != 0)
				{
				}
				num = (short)918028288;
				if (num != 0)
				{
				}
				num = (short)1739653120;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.Max;
			}
			set
			{
				short num = (short)961203835;
				short num2 = num;
				num = (short)120966779;
				switch (num2 == num)
				{
				}
				num = (short)1902772224;
				if (num != 0)
				{
				}
				num = (short)1347813377;
				if (num != 0)
				{
				}
				num = (short)1234305024;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.Max = value;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x000A5D84 File Offset: 0x000A3F84
		// (set) Token: 0x06000B54 RID: 2900 RVA: 0x000A5E34 File Offset: 0x000A4034
		internal int TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478Step
		{
			get
			{
				short num = (short)89909711;
				short num2 = num;
				num = (short)1876093391;
				switch (num2 == num)
				{
				}
				num = (short)1723990017;
				if (num != 0)
				{
				}
				num = (short)1728774144;
				if (num != 0)
				{
				}
				num = (short)1986723840;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.StepSize;
			}
			set
			{
				short num = (short)948799945;
				short num2 = num;
				num = (short)250317257;
				switch (num2 == num)
				{
				}
				num = (short)998309889;
				if (num != 0)
				{
				}
				num = (short)1208614912;
				if (num != 0)
				{
				}
				num = (short)468844544;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.StepSize = value;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x000A5EEC File Offset: 0x000A40EC
		// (set) Token: 0x06000B56 RID: 2902 RVA: 0x000A5FA0 File Offset: 0x000A41A0
		public bool TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478_Applicable
		{
			get
			{
				short num = (short)811300967;
				short num2 = num;
				num = (short)1754822759;
				switch (num2 == num)
				{
				}
				num = (short)689963009;
				if (num != 0)
				{
				}
				num = (short)99745792;
				if (num != 0)
				{
				}
				num = (short)731054080;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.Applicable;
			}
			set
			{
				short num = (short)899823698;
				short num2 = num;
				num = (short)1004746834;
				switch (num2 == num)
				{
				}
				num = (short)1479540736;
				if (num != 0)
				{
				}
				num = (short)261095425;
				if (num != 0)
				{
				}
				num = (short)2113994752;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.Applicable = value;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x000A6054 File Offset: 0x000A4254
		// (set) Token: 0x06000B58 RID: 2904 RVA: 0x000A6108 File Offset: 0x000A4308
		public bool TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478_Valid
		{
			get
			{
				short num = (short)1790034893;
				short num2 = num;
				num = (short)576373709;
				switch (num2 == num)
				{
				}
				num = (short)187891712;
				if (num != 0)
				{
				}
				num = (short)918814721;
				if (num != 0)
				{
				}
				num = (short)1643708416;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.Valid;
			}
			set
			{
				short num = (short)362153054;
				short num2 = num;
				num = (short)1603732574;
				switch (num2 == num)
				{
				}
				num = (short)749928449;
				if (num != 0)
				{
				}
				num = (short)739311616;
				if (num != 0)
				{
				}
				num = (short)1465516032;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.Valid = value;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x000A61BC File Offset: 0x000A43BC
		// (set) Token: 0x06000B5A RID: 2906 RVA: 0x000A6278 File Offset: 0x000A4478
		public bool TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478_Visible
		{
			get
			{
				short num = (short)462647374;
				short num2 = num;
				num = (short)417689678;
				switch (num2 == num)
				{
				}
				num = (short)1006895104;
				if (num != 0)
				{
				}
				num = (short)1122697217;
				if (num != 0)
				{
				}
				num = (short)203489280;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.Visible;
			}
			set
			{
				short num = (short)1670381569;
				if (num != 0)
				{
				}
				num = (short)1230141245;
				short num2 = num;
				num = (short)2146400061;
				switch (num2 == num)
				{
				}
				num = (short)1220935680;
				if (num != 0)
				{
				}
				num = (short)328138752;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.Visible = value;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x000A6330 File Offset: 0x000A4530
		// (set) Token: 0x06000B5C RID: 2908 RVA: 0x000A63E4 File Offset: 0x000A45E4
		public bool TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478_Editable
		{
			get
			{
				short num = (short)480968705;
				if (num != 0)
				{
				}
				num = (short)615735347;
				short num2 = num;
				num = (short)28270643;
				switch (num2 == num)
				{
				}
				num = (short)374800384;
				if (num != 0)
				{
				}
				num = (short)986382336;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.Editable;
			}
			set
			{
				short num = (short)1626028903;
				short num2 = num;
				num = (short)768686951;
				switch (num2 == num)
				{
				}
				num = (short)1302855681;
				if (num != 0)
				{
				}
				num = (short)328204288;
				if (num != 0)
				{
				}
				num = (short)907804672;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.Editable = value;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x000A649C File Offset: 0x000A469C
		internal string TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478_UILabel
		{
			get
			{
				short num = (short)629810808;
				short num2 = num;
				num = (short)1531520632;
				switch (num2 == num)
				{
				}
				num = (short)623575040;
				if (num != 0)
				{
				}
				num = (short)1009188865;
				if (num != 0)
				{
				}
				num = (short)1084424192;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.UIName;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x000A6554 File Offset: 0x000A4754
		// (set) Token: 0x06000B5F RID: 2911 RVA: 0x000A6608 File Offset: 0x000A4808
		internal bool TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478_HiddenStatic
		{
			get
			{
				short num = (short)2001381219;
				short num2 = num;
				num = (short)1319610211;
				switch (num2 == num)
				{
				}
				num = (short)865337345;
				if (num != 0)
				{
				}
				num = (short)1588002816;
				if (num != 0)
				{
				}
				num = (short)86114304;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.HiddenStatic;
			}
			set
			{
				short num = (short)587137025;
				if (num != 0)
				{
				}
				num = (short)1522853530;
				short num2 = num;
				num = (short)1243997850;
				switch (num2 == num)
				{
				}
				num = (short)1068105728;
				if (num != 0)
				{
				}
				num = (short)967770112;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.HiddenStatic = value;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x000A66C0 File Offset: 0x000A48C0
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x000A6774 File Offset: 0x000A4974
		internal bool TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478_HiddenDynamic
		{
			get
			{
				short num = (short)1273364481;
				if (num != 0)
				{
				}
				num = (short)841910720;
				short num2 = num;
				num = (short)141593024;
				switch (num2 == num)
				{
				}
				num = (short)177274880;
				if (num != 0)
				{
				}
				num = (short)1614282752;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.HiddenDynamic;
			}
			set
			{
				short num = (short)276459180;
				short num2 = num;
				num = (short)623996588;
				switch (num2 == num)
				{
				}
				num = (short)1762394113;
				if (num != 0)
				{
				}
				num = (short)1212088320;
				if (num != 0)
				{
				}
				num = (short)263847936;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.HiddenDynamic = value;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x000A6828 File Offset: 0x000A4A28
		public bool TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478_HasDiffs
		{
			get
			{
				short num = (short)452227578;
				short num2 = num;
				num = (short)757363194;
				switch (num2 == num)
				{
				}
				num = (short)1353056257;
				if (num != 0)
				{
				}
				num = (short)765526016;
				if (num != 0)
				{
				}
				num = (short)975765504;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478._HasDiffs;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x000A68DC File Offset: 0x000A4ADC
		// (set) Token: 0x06000B64 RID: 2916 RVA: 0x000A6990 File Offset: 0x000A4B90
		public int TrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479Value
		{
			get
			{
				short num = (short)777284027;
				short num2 = num;
				num = (short)1196517819;
				switch (num2 == num)
				{
				}
				num = (short)1860501504;
				if (num != 0)
				{
				}
				num = (short)1994850305;
				if (num != 0)
				{
				}
				num = (short)1466236928;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.Value;
			}
			set
			{
				short num = (short)2033665154;
				short num2 = num;
				num = (short)1878803586;
				switch (num2 == num)
				{
				}
				num = (short)72286209;
				if (num != 0)
				{
				}
				num = (short)561971200;
				if (num != 0)
				{
				}
				num = (short)1430061056;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.Value = value;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x000A6A4C File Offset: 0x000A4C4C
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479
		{
			get
			{
				short num = (short)2127863932;
				short num2 = num;
				num = (short)400138364;
				switch (num2 == num)
				{
				}
				num = (short)79233025;
				if (num != 0)
				{
				}
				num = (short)1120927744;
				if (num != 0)
				{
				}
				num = (short)2063073280;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x000A6AFC File Offset: 0x000A4CFC
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x000A6BB4 File Offset: 0x000A4DB4
		public string TrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479_UIValue
		{
			get
			{
				short num = (short)1091581316;
				short num2 = num;
				num = (short)510473604;
				switch (num2 == num)
				{
				}
				num = (short)1152450561;
				if (num != 0)
				{
				}
				num = (short)1686896640;
				if (num != 0)
				{
				}
				num = (short)974192640;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.UIValue;
			}
			set
			{
				short num = (short)133976637;
				short num2 = num;
				num = (short)446190141;
				switch (num2 == num)
				{
				}
				num = (short)1212284928;
				if (num != 0)
				{
				}
				num = (short)623312897;
				if (num != 0)
				{
				}
				num = (short)21823488;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.UIValue = value;
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x000A6C68 File Offset: 0x000A4E68
		// (set) Token: 0x06000B69 RID: 2921 RVA: 0x000A6D1C File Offset: 0x000A4F1C
		public string TrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479_HexUIValue
		{
			get
			{
				short num = (short)792021120;
				short num2 = num;
				num = (short)1732855936;
				switch (num2 == num)
				{
				}
				num = (short)959971329;
				if (num != 0)
				{
				}
				num = (short)766181376;
				if (num != 0)
				{
				}
				num = (short)214040576;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.HexUIValue;
			}
			set
			{
				short num = (short)1242824705;
				if (num != 0)
				{
				}
				num = (short)1214473084;
				short num2 = num;
				num = (short)172450684;
				switch (num2 == num)
				{
				}
				num = (short)418185216;
				if (num != 0)
				{
				}
				num = (short)2108358656;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.HexUIValue = value;
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x000A6DD4 File Offset: 0x000A4FD4
		// (set) Token: 0x06000B6B RID: 2923 RVA: 0x000A6E88 File Offset: 0x000A5088
		internal int TrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479Min
		{
			get
			{
				short num = (short)1949675791;
				short num2 = num;
				num = (short)785428751;
				switch (num2 == num)
				{
				}
				num = (short)1864105984;
				if (num != 0)
				{
				}
				num = (short)824639489;
				if (num != 0)
				{
				}
				num = (short)1439498240;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.Min;
			}
			set
			{
				short num = (short)575725780;
				short num2 = num;
				num = (short)1206575316;
				switch (num2 == num)
				{
				}
				num = (short)1375862784;
				if (num != 0)
				{
				}
				num = (short)1382875137;
				if (num != 0)
				{
				}
				num = (short)1955725312;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.Min = value;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x000A6F40 File Offset: 0x000A5140
		// (set) Token: 0x06000B6D RID: 2925 RVA: 0x000A6FF8 File Offset: 0x000A51F8
		internal int TrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479Max
		{
			get
			{
				short num = (short)1204804180;
				short num2 = num;
				num = (short)666753620;
				switch (num2 == num)
				{
				}
				num = (short)1113456641;
				if (num != 0)
				{
				}
				num = (short)1880948736;
				if (num != 0)
				{
				}
				num = (short)859504640;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.Max;
			}
			set
			{
				short num = (short)1673637296;
				short num2 = num;
				num = (short)845262256;
				switch (num2 == num)
				{
				}
				num = (short)1508900864;
				if (num != 0)
				{
				}
				num = (short)111804417;
				if (num != 0)
				{
				}
				num = (short)433717248;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.Max = value;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x000A70B0 File Offset: 0x000A52B0
		// (set) Token: 0x06000B6F RID: 2927 RVA: 0x000A7164 File Offset: 0x000A5364
		internal int TrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479Step
		{
			get
			{
				short num = (short)1714555807;
				short num2 = num;
				num = (short)88869791;
				switch (num2 == num)
				{
				}
				num = (short)921960449;
				if (num != 0)
				{
				}
				num = (short)983891968;
				if (num != 0)
				{
				}
				num = (short)999817216;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.StepSize;
			}
			set
			{
				short num = (short)147914753;
				if (num != 0)
				{
				}
				num = (short)1009180864;
				short num2 = num;
				num = (short)486727872;
				switch (num2 == num)
				{
				}
				num = (short)523108352;
				if (num != 0)
				{
				}
				num = (short)1712193536;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.StepSize = value;
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x000A721C File Offset: 0x000A541C
		// (set) Token: 0x06000B71 RID: 2929 RVA: 0x000A72D4 File Offset: 0x000A54D4
		public bool TrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479_Applicable
		{
			get
			{
				short num = (short)1954152449;
				if (num != 0)
				{
				}
				num = (short)1629963929;
				short num2 = num;
				num = (short)1635927705;
				switch (num2 == num)
				{
				}
				num = (short)2060386304;
				if (num != 0)
				{
				}
				num = (short)939786240;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.Applicable;
			}
			set
			{
				short num = (short)947781697;
				short num2 = num;
				num = (short)1476264001;
				switch (num2 == num)
				{
				}
				num = (short)27721729;
				if (num != 0)
				{
				}
				num = (short)1609302016;
				if (num != 0)
				{
				}
				num = (short)2023882752;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.Applicable = value;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06000B72 RID: 2930 RVA: 0x000A7388 File Offset: 0x000A5588
		// (set) Token: 0x06000B73 RID: 2931 RVA: 0x000A7440 File Offset: 0x000A5640
		public bool TrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479_Valid
		{
			get
			{
				short num = (short)1426757725;
				short num2 = num;
				num = (short)1664915549;
				switch (num2 == num)
				{
				}
				num = (short)756154368;
				if (num != 0)
				{
				}
				num = (short)708640769;
				if (num != 0)
				{
				}
				num = (short)114360320;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.Valid;
			}
			set
			{
				short num = (short)1133548014;
				short num2 = num;
				num = (short)87069166;
				switch (num2 == num)
				{
				}
				num = (short)1984888832;
				if (num != 0)
				{
				}
				num = (short)885981185;
				if (num != 0)
				{
				}
				num = (short)1913716736;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.Valid = value;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06000B74 RID: 2932 RVA: 0x000A74F8 File Offset: 0x000A56F8
		// (set) Token: 0x06000B75 RID: 2933 RVA: 0x000A75AC File Offset: 0x000A57AC
		public bool TrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479_Visible
		{
			get
			{
				short num = (short)1462519044;
				short num2 = num;
				num = (short)1436894468;
				switch (num2 == num)
				{
				}
				num = (short)1042022401;
				if (num != 0)
				{
				}
				num = (short)918749184;
				if (num != 0)
				{
				}
				num = (short)483786752;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.Visible;
			}
			set
			{
				short num = (short)1414251213;
				short num2 = num;
				num = (short)1503969997;
				switch (num2 == num)
				{
				}
				num = (short)1949564929;
				if (num != 0)
				{
				}
				num = (short)432275456;
				if (num != 0)
				{
				}
				num = (short)169017344;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.Visible = value;
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x000A7664 File Offset: 0x000A5864
		// (set) Token: 0x06000B77 RID: 2935 RVA: 0x000A7718 File Offset: 0x000A5918
		public bool TrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479_Editable
		{
			get
			{
				short num = (short)1700462593;
				if (num != 0)
				{
				}
				num = (short)39486252;
				short num2 = num;
				num = (short)1230471980;
				switch (num2 == num)
				{
				}
				num = (short)963837952;
				if (num != 0)
				{
				}
				num = (short)2024341504;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.Editable;
			}
			set
			{
				short num = (short)1429801494;
				short num2 = num;
				num = (short)1448872470;
				switch (num2 == num)
				{
				}
				num = (short)960299009;
				if (num != 0)
				{
				}
				num = (short)189202432;
				if (num != 0)
				{
				}
				num = (short)129368064;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.Editable = value;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x000A77CC File Offset: 0x000A59CC
		internal string TrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479_UILabel
		{
			get
			{
				short num = (short)981006285;
				short num2 = num;
				num = (short)1907357645;
				switch (num2 == num)
				{
				}
				num = (short)1057685504;
				if (num != 0)
				{
				}
				num = (short)1158676481;
				if (num != 0)
				{
				}
				num = (short)181469184;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.UIName;
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x000A7880 File Offset: 0x000A5A80
		// (set) Token: 0x06000B7A RID: 2938 RVA: 0x000A7934 File Offset: 0x000A5B34
		internal bool TrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479_HiddenStatic
		{
			get
			{
				short num = (short)1552400052;
				short num2 = num;
				num = (short)1108655796;
				switch (num2 == num)
				{
				}
				num = (short)1581711360;
				if (num != 0)
				{
				}
				num = (short)768409601;
				if (num != 0)
				{
				}
				num = (short)39518208;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.HiddenStatic;
			}
			set
			{
				short num = (short)148891422;
				short num2 = num;
				num = (short)2029578014;
				switch (num2 == num)
				{
				}
				num = (short)1593901057;
				if (num != 0)
				{
				}
				num = (short)1591541760;
				if (num != 0)
				{
				}
				num = (short)1415708672;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.HiddenStatic = value;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x000A79E8 File Offset: 0x000A5BE8
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x000A7A9C File Offset: 0x000A5C9C
		internal bool TrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479_HiddenDynamic
		{
			get
			{
				short num = (short)1215265019;
				short num2 = num;
				num = (short)1352562939;
				switch (num2 == num)
				{
				}
				num = (short)479657985;
				if (num != 0)
				{
				}
				num = (short)1068630016;
				if (num != 0)
				{
				}
				num = (short)1917321216;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.HiddenDynamic;
			}
			set
			{
				short num = (short)1108273723;
				short num2 = num;
				num = (short)1128000059;
				switch (num2 == num)
				{
				}
				num = (short)1783824385;
				if (num != 0)
				{
				}
				num = (short)807600128;
				if (num != 0)
				{
				}
				num = (short)1779957760;
				short num3 = num;
				this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.HiddenDynamic = value;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x000A7B50 File Offset: 0x000A5D50
		public bool TrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479_HasDiffs
		{
			get
			{
				short num = (short)1910408251;
				short num2 = num;
				num = (short)12682299;
				switch (num2 == num)
				{
				}
				num = (short)287506432;
				if (num != 0)
				{
				}
				num = (short)1995636737;
				if (num != 0)
				{
				}
				num = (short)614531072;
				short num3 = num;
				return this.trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479._HasDiffs;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06000B7E RID: 2942 RVA: 0x000A7C04 File Offset: 0x000A5E04
		// (set) Token: 0x06000B7F RID: 2943 RVA: 0x000A7CB8 File Offset: 0x000A5EB8
		public string TrkSysOBTChannelRange_A24072Value
		{
			get
			{
				short num = (short)342735256;
				short num2 = num;
				num = (short)1259911576;
				switch (num2 == num)
				{
				}
				num = (short)1233059841;
				if (num != 0)
				{
				}
				num = (short)331743232;
				if (num != 0)
				{
				}
				num = (short)1202454528;
				short num3 = num;
				return this.trkSysOBTChannelRange_A24072.Value;
			}
			set
			{
				short num = (short)1679228929;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)792723456;
					short num3 = num;
					num = (short)1295346275;
					short num4 = num;
					num = (short)1492150883;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)68222976;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							return;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_A6;
							}
							continue;
						case 2:
							goto IL_F5;
						}
						IL_A6:
						if (!string.IsNullOrEmpty(value.Trim()))
						{
							num = (short)1074462721;
							if (num != 0)
							{
							}
							num = (short)1250099202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_F5:
					this.trkSysOBTChannelRange_A24072.Value = value;
					num = (short)1870528512;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06000B80 RID: 2944 RVA: 0x000A7DE0 File Offset: 0x000A5FE0
		// (set) Token: 0x06000B81 RID: 2945 RVA: 0x000A7E98 File Offset: 0x000A6098
		public string TrkSysOBTChannelRange_A24072_UIValue
		{
			get
			{
				short num = (short)1749805388;
				short num2 = num;
				num = (short)23390540;
				switch (num2 == num)
				{
				}
				num = (short)1767047169;
				if (num != 0)
				{
				}
				num = (short)1328742400;
				if (num != 0)
				{
				}
				num = (short)1172176896;
				short num3 = num;
				return this.trkSysOBTChannelRange_A24072.Value;
			}
			set
			{
				short num = (short)2064384001;
				if (num != 0)
				{
				}
				num = (short)1667380323;
				short num2 = num;
				num = (short)664613987;
				switch (num2 == num)
				{
				}
				num = (short)1982922752;
				if (num != 0)
				{
				}
				num = (short)1696202752;
				short num3 = num;
				this.trkSysOBTChannelRange_A24072.Value = value;
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x000A7F50 File Offset: 0x000A6150
		public global::AcpBusinessLayer.AcpKeyField TrkSysOBTChannelRange_A24072
		{
			get
			{
				short num = (short)824836097;
				if (num != 0)
				{
				}
				num = (short)591301203;
				short num2 = num;
				num = (short)636258899;
				switch (num2 == num)
				{
				}
				num = (short)499253248;
				if (num != 0)
				{
				}
				num = (short)2035679232;
				short num3 = num;
				return this.trkSysOBTChannelRange_A24072;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x000A8004 File Offset: 0x000A6204
		// (set) Token: 0x06000B84 RID: 2948 RVA: 0x000A80BC File Offset: 0x000A62BC
		public bool TrkSysOBTChannelRange_A24072_Applicable
		{
			get
			{
				short num = (short)867948793;
				short num2 = num;
				num = (short)972019961;
				switch (num2 == num)
				{
				}
				num = (short)1787232257;
				if (num != 0)
				{
				}
				num = (short)1734541312;
				if (num != 0)
				{
				}
				num = (short)47775744;
				short num3 = num;
				return this.trkSysOBTChannelRange_A24072.Applicable;
			}
			set
			{
				short num = (short)237538127;
				short num2 = num;
				num = (short)1365609295;
				switch (num2 == num)
				{
				}
				num = (short)1616117761;
				if (num != 0)
				{
				}
				num = (short)276758528;
				if (num != 0)
				{
				}
				num = (short)1404502016;
				short num3 = num;
				this.trkSysOBTChannelRange_A24072.Applicable = value;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x000A8170 File Offset: 0x000A6370
		// (set) Token: 0x06000B86 RID: 2950 RVA: 0x000A8224 File Offset: 0x000A6424
		public bool TrkSysOBTChannelRange_A24072_Valid
		{
			get
			{
				short num = (short)1766139896;
				short num2 = num;
				num = (short)363145208;
				switch (num2 == num)
				{
				}
				num = (short)677838848;
				if (num != 0)
				{
				}
				num = (short)1642659841;
				if (num != 0)
				{
				}
				num = (short)1173880832;
				short num3 = num;
				return this.trkSysOBTChannelRange_A24072.Valid;
			}
			set
			{
				short num = (short)1945899482;
				short num2 = num;
				num = (short)805245402;
				switch (num2 == num)
				{
				}
				num = (short)827719681;
				if (num != 0)
				{
				}
				num = (short)869990400;
				if (num != 0)
				{
				}
				num = (short)824967168;
				short num3 = num;
				this.trkSysOBTChannelRange_A24072.Valid = value;
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x000A82D8 File Offset: 0x000A64D8
		// (set) Token: 0x06000B88 RID: 2952 RVA: 0x000A8390 File Offset: 0x000A6590
		public bool TrkSysOBTChannelRange_A24072_Visible
		{
			get
			{
				short num = (short)369164288;
				short num2 = num;
				num = (short)763297793;
				if (num != 0)
				{
				}
				num = (short)684551374;
				short num3 = num;
				num = (short)1441688782;
				switch (num3 == num)
				{
				}
				num = (short)513277952;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelRange_A24072.Visible;
			}
			set
			{
				short num = (short)1741750272;
				short num2 = num;
				num = (short)450096177;
				short num3 = num;
				num = (short)1757604913;
				switch (num3 == num)
				{
				}
				num = (short)586743808;
				if (num != 0)
				{
				}
				num = (short)401211393;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelRange_A24072.Visible = value;
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x000A8444 File Offset: 0x000A6644
		// (set) Token: 0x06000B8A RID: 2954 RVA: 0x000A84F8 File Offset: 0x000A66F8
		public bool TrkSysOBTChannelRange_A24072_Editable
		{
			get
			{
				short num = (short)464912384;
				short num2 = num;
				num = (short)1668709437;
				short num3 = num;
				num = (short)742816829;
				switch (num3 == num)
				{
				}
				num = (short)930545664;
				if (num != 0)
				{
				}
				num = (short)1278279681;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelRange_A24072.Editable;
			}
			set
			{
				short num = (short)1337982976;
				short num2 = num;
				num = (short)762249217;
				if (num != 0)
				{
				}
				num = (short)739942734;
				short num3 = num;
				num = (short)796500302;
				switch (num3 == num)
				{
				}
				num = (short)615186432;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelRange_A24072.Editable = value;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x000A85B0 File Offset: 0x000A67B0
		internal string TrkSysOBTChannelRange_A24072_UILabel
		{
			get
			{
				short num = (short)2135556096;
				short num2 = num;
				num = (short)811017804;
				short num3 = num;
				num = (short)1000351308;
				switch (num3 == num)
				{
				}
				num = (short)2061107201;
				if (num != 0)
				{
				}
				num = (short)1221853184;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelRange_A24072.UIName;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x000A8668 File Offset: 0x000A6868
		// (set) Token: 0x06000B8D RID: 2957 RVA: 0x000A871C File Offset: 0x000A691C
		internal bool TrkSysOBTChannelRange_A24072_HiddenStatic
		{
			get
			{
				short num = (short)1792868352;
				short num2 = num;
				num = (short)737068887;
				short num3 = num;
				num = (short)1123600215;
				switch (num3 == num)
				{
				}
				num = (short)310575104;
				if (num != 0)
				{
				}
				num = (short)764805121;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelRange_A24072.HiddenStatic;
			}
			set
			{
				short num = (short)1444741120;
				short num2 = num;
				num = (short)1375797249;
				if (num != 0)
				{
				}
				num = (short)165828478;
				short num3 = num;
				num = (short)700995454;
				switch (num3 == num)
				{
				}
				num = (short)1181810688;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelRange_A24072.HiddenStatic = value;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x000A87D4 File Offset: 0x000A69D4
		// (set) Token: 0x06000B8F RID: 2959 RVA: 0x000A8888 File Offset: 0x000A6A88
		internal bool TrkSysOBTChannelRange_A24072_HiddenDynamic
		{
			get
			{
				short num = (short)1867186176;
				short num2 = num;
				num = (short)866183545;
				short num3 = num;
				num = (short)220588409;
				switch (num3 == num)
				{
				}
				num = (short)1270480897;
				if (num != 0)
				{
				}
				num = (short)849412096;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelRange_A24072.HiddenDynamic;
			}
			set
			{
				short num = (short)1864892416;
				short num2 = num;
				num = (short)653022894;
				short num3 = num;
				num = (short)751392430;
				switch (num3 == num)
				{
				}
				num = (short)400621568;
				if (num != 0)
				{
				}
				num = (short)1542127617;
				if (num != 0)
				{
				}
				this.trkSysOBTChannelRange_A24072.HiddenDynamic = value;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x000A8940 File Offset: 0x000A6B40
		public bool TrkSysOBTChannelRange_A24072_HasDiffs
		{
			get
			{
				short num = (short)297271296;
				short num2 = num;
				num = (short)355034287;
				short num3 = num;
				num = (short)2134140079;
				switch (num3 == num)
				{
				}
				num = (short)2071592961;
				if (num != 0)
				{
				}
				num = (short)1522794496;
				if (num != 0)
				{
				}
				return this.trkSysOBTChannelRange_A24072._HasDiffs;
			}
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x000A89F4 File Offset: 0x000A6BF4
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)148701185;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4B;
			}
			int num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_31:
				switch (num2)
				{
				case 0:
					if (base.ParentRecset != null)
					{
						goto IL_95;
					}
					return result;
				case 1:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)733216772;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)33003132;
					short num3 = num;
					num = (short)326669948;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_95;
					default:
						num = (short)1701249024;
						if (num != 0)
						{
						}
						num = (short)1186463747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)360120321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 4:
					return result;
				}
				goto IL_4B;
				IL_95:
				num = (short)1900675074;
				num2 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_4B:
			result = null;
			num = (short)1258160128;
			short num4 = num;
			num = (short)560070656;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_31;
		}

		// Token: 0x04000347 RID: 839
		private global::AcpBusinessLayer.AcpField<bool> trkSysOBTChannelAssignmentListRxEnable_A9001;

		// Token: 0x04000348 RID: 840
		private global::AcpBusinessLayer.AcpListField trkSysOBTChannelAssignmentListRxSpacingKHz_A9004;

		// Token: 0x04000349 RID: 841
		private global::AcpBusinessLayer.AcpFrequencyField trkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012;

		// Token: 0x0400034A RID: 842
		private global::AcpBusinessLayer.AcpFrequencyField trkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029;

		// Token: 0x0400034B RID: 843
		private global::AcpBusinessLayer.AcpField<bool> trkSysOBTChannelAssignmentListTxEnable_A9517;

		// Token: 0x0400034C RID: 844
		private global::AcpBusinessLayer.AcpListField trkSysOBTChannelAssignmentListTxSpacingKHz_A9520;

		// Token: 0x0400034D RID: 845
		private global::AcpBusinessLayer.AcpFrequencyField trkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529;

		// Token: 0x0400034E RID: 846
		private global::AcpBusinessLayer.AcpFrequencyField trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568;

		// Token: 0x0400034F RID: 847
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysOBTChannelAssignmentListRxStartChannelNumber_A20478;

		// Token: 0x04000350 RID: 848
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysOBTChannelAssignmentListTxStartChannelNumber_A20479;

		// Token: 0x04000351 RID: 849
		private global::AcpBusinessLayer.AcpKeyField trkSysOBTChannelRange_A24072;
	}
}
