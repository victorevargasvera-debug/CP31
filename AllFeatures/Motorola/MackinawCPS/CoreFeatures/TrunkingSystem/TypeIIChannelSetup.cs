using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x020000AC RID: 172
	[global::System.Serializable]
	public class TypeIIChannelSetup : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600154A RID: 5450 RVA: 0x00145848 File Offset: 0x00143A48
		public TypeIIChannelSetup(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x00145864 File Offset: 0x00143A64
		protected TypeIIChannelSetup(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x0014587C File Offset: 0x00143A7C
		public override void Init()
		{
			int a_ = 19;
			short num = (short)868351086;
			short num2 = num;
			num = (short)1919548526;
			switch (num2 == num)
			{
			}
			num = (short)201392129;
			if (num != 0)
			{
			}
			num = (short)2033975296;
			short num3 = num;
			num = (short)2061041664;
			if (num != 0)
			{
			}
			this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝듟鯡铣菥ꇧꏩ꿫蛭釯鳱髳鏵铷꧹駻諽痿爁䜃清椇搉戋欍簏匑朓攕焗紙爛猝䔟䰡倣爥儧娩䤫焭焯Աȳ̵਷", a_), global::CommonResources.AcgResources.ID_CHANNELASSIGNMENTTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysTypeIIChannelSetupChannelAssignmentType_A7652LovStrs);
			this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652.DataTransferOrder = 53;
			this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654 = new global::AcpBusinessLayer.AcpSparseLOVField(100, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.indexTrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.idTrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654LovStrs), this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝듟鯡铣菥ꇧꏩ꿫蛭釯鳱髳鏵铷꧹駻諽痿爁䜃清椇搉戋欍簏們甓砕簗洙甛稝吟䨡伣渥刧甩洫᤭دܱ3", a_), global::CommonResources.AcgResources.ID_CHANNELBANDWIDTHKHZ, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654LovStrs);
			this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.DataTransferOrder = 54;
			this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.EvaluateRecRefs = true;
			this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝듟鯡铣菥ꇧꏩ꿫蛭釯鳱髳鏵铷꧹駻諽痿爁䠃挅漇欉漋眍䐏怑甓砕欗猙栛䴝够儡倣䌥䔧甩洫ᘭЯ1ള", a_), global::CommonResources.AcgResources.ID_LEGACYTRANSITSYSTEM);
			this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429.DataTransferOrder = 38;
			this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝듟鯡铣菥ꇧꏩ꿫蛭釯鳱髳鏵铷꧹駻諽痿爁䨃嘅嬇娉䴋䴍匏稑甓砕瘗缙瀛尝䄟䰡䀣儥䄧丩堫䘭嬯稱丳椵礷ȹऻऽ焿", a_), global::CommonResources.AcgResources.ID_NPSPACCHANNELBANDWIDTHKHZ, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571LovStrs);
			this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571.DataTransferOrder = 42;
			this.trkSysTypeIIChannelSetupSplinterChannel_A9175 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝듟鯡铣菥ꇧꏩ꿫蛭釯鳱髳鏵铷꧹駻諽痿爁圃瘅搇按戋稍甏怑圓縕礗琙爛笝䰟紡攣ἥᤧᴩᤫ", a_), global::CommonResources.AcgResources.ID_SPLINTERCHANNEL);
			this.trkSysTypeIIChannelSetupSplinterChannel_A9175.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysTypeIIChannelSetupSplinterChannel_A9175.DataTransferOrder = 93;
			this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝듟鯡铣菥ꇧꏩ꿫蛭釯鳱髳鏵铷꧹駻諽痿爁圃清紇氉樋戍甏瘑嘓眕瘗縙䰛爝䄟䰡笣朥ᄧᬩḫᘭ", a_), global::CommonResources.AcgResources.ID_SHUFFLEDBANDPLAN);
			this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128.DataTransferOrder = 97;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胓꿕꣗뿙ﳛ韝꧟싡꟣軥觧蓩苫语鳯틱ꟳ鏵賷迹賻", a_);
			base.Id = 10155;
			base.UIName = global::CommonResources.AcgResources.ID_TYPEIICHANNELSETUP;
			base.DataTransferOrder = 12;
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x00145AE0 File Offset: 0x00143CE0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 19;
			short num = (short)568066069;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.trkSysTypeIIChannelSetupSplinterChannel_A9175 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝듟鯡铣菥ꇧꏩ꿫蛭釯鳱髳鏵铷꧹駻諽痿爁圃瘅搇按戋稍甏怑圓縕礗琙爛笝䰟紡攣ἥᤧᴩᤫ", a_), global::CommonResources.AcgResources.ID_SPLINTERCHANNEL);
					this.trkSysTypeIIChannelSetupSplinterChannel_A9175.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysTypeIIChannelSetupSplinterChannel_A9175.DataTransferOrder = 93;
					num = (short)1828454409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1939931136;
					short num3 = num;
					this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝듟鯡铣菥ꇧꏩ꿫蛭釯鳱髳鏵铷꧹駻諽痿爁䠃挅漇欉漋眍䐏怑甓砕欗猙栛䴝够儡倣䌥䔧甩洫ᘭЯ1ള", a_), global::CommonResources.AcgResources.ID_LEGACYTRANSITSYSTEM);
					this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429.DataTransferOrder = 38;
					num = (short)619249674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654 = new global::AcpBusinessLayer.AcpSparseLOVField(100, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.indexTrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.idTrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654LovStrs), this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝듟鯡铣菥ꇧꏩ꿫蛭釯鳱髳鏵铷꧹駻諽痿爁䜃清椇搉戋欍簏們甓砕簗洙甛稝吟䨡伣渥刧甩洫᤭دܱ3", a_), global::CommonResources.AcgResources.ID_CHANNELBANDWIDTHKHZ, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654LovStrs);
					this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.DataTransferOrder = 54;
					this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.EvaluateRecRefs = true;
					num = (short)1345060872;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝듟鯡铣菥ꇧꏩ꿫蛭釯鳱髳鏵铷꧹駻諽痿爁圃瘅搇按戋稍甏怑圓縕礗琙爛笝䰟紡攣ἥᤧᴩᤫ", a_)))
					{
						num = (short)1690042368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CF;
				case 4:
					goto IL_175;
				case 5:
					this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝듟鯡铣菥ꇧꏩ꿫蛭釯鳱髳鏵铷꧹駻諽痿爁圃清紇氉樋戍甏瘑嘓眕瘗縙䰛爝䄟䰡笣朥ᄧᬩḫᘭ", a_), global::CommonResources.AcgResources.ID_SHUFFLEDBANDPLAN);
					this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128.DataTransferOrder = 97;
					num = (short)20185095;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (producerFields != null)
					{
						num = (short)61276176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_57B;
				case 7:
					goto IL_33B;
				case 8:
					goto IL_340;
				case 9:
					goto IL_1CF;
				case 10:
					goto IL_47E;
				case 11:
					goto IL_38D;
				case 12:
					num = (short)682295302;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝듟鯡铣菥ꇧꏩ꿫蛭釯鳱髳鏵铷꧹駻諽痿爁䠃挅漇欉漋眍䐏怑甓砕欗猙栛䴝够儡倣䌥䔧甩洫ᘭЯ1ള", a_)))
					{
						num = (short)1213267969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_47E;
				case 14:
				{
					num = (short)9117933;
					short num4 = num;
					num = (short)1826627821;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_175;
					default:
						num = (short)58851328;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝듟鯡铣菥ꇧꏩ꿫蛭釯鳱髳鏵铷꧹駻諽痿爁䜃清椇搉戋欍簏們甓砕簗洙甛稝吟䨡伣渥刧甩洫᤭دܱ3", a_)))
						{
							num = (short)196214786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_340;
					}
					break;
				}
				case 15:
					num = (short)1812463617;
					if (num != 0)
					{
					}
					this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝듟鯡铣菥ꇧꏩ꿫蛭釯鳱髳鏵铷꧹駻諽痿爁䨃嘅嬇娉䴋䴍匏稑甓砕瘗缙瀛尝䄟䰡䀣儥䄧丩堫䘭嬯稱丳椵礷ȹऻऽ焿", a_), global::CommonResources.AcgResources.ID_NPSPACCHANNELBANDWIDTHKHZ, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571LovStrs);
					this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571.DataTransferOrder = 42;
					num = (short)141033489;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					num = (short)1533280274;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_AB;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝듟鯡铣菥ꇧꏩ꿫蛭釯鳱髳鏵铷꧹駻諽痿爁䜃清椇搉戋欍簏匑朓攕焗紙爛猝䔟䰡倣爥儧娩䤫焭焯Աȳ̵਷", a_)))
					{
						num = (short)391643140;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_38D;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝듟鯡铣菥ꇧꏩ꿫蛭釯鳱髳鏵铷꧹駻諽痿爁䨃嘅嬇娉䴋䴍匏稑甓砕瘗缙瀛尝䄟䰡䀣儥䄧丩堫䘭嬯稱丳椵礷ȹऻऽ焿", a_)))
					{
						num = (short)522977295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AB;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝듟鯡铣菥ꇧꏩ꿫蛭釯鳱髳鏵铷꧹駻諽痿爁圃清紇氉樋戍甏瘑嘓眕瘗縙䰛爝䄟䰡笣朥ᄧᬩḫᘭ", a_)))
					{
						num = (short)1288372229;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_57B;
				case 21:
					switch (0)
					{
					case 0:
						goto IL_87;
					}
					continue;
				}
				IL_87:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)76152844;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_AB:
				num = (short)353239043;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_175:
				this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝듟鯡铣菥ꇧꏩ꿫蛭釯鳱髳鏵铷꧹駻諽痿爁䜃清椇搉戋欍簏匑朓攕焗紙爛猝䔟䰡倣爥儧娩䤫焭焯Աȳ̵਷", a_), global::CommonResources.AcgResources.ID_CHANNELASSIGNMENTTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysTypeIIChannelSetupChannelAssignmentType_A7652LovStrs);
				this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
				this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652.DataTransferOrder = 53;
				num = (short)420085771;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1CF:
				num = (short)291831828;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_340:
				num = (short)1004666893;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_38D:
				num = (short)2122055694;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_47E:
				num = (short)600506387;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_33B:
			IL_57B:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胓꿕꣗뿙ﳛ韝꧟싡꟣軥觧蓩苫语鳯틱ꟳ鏵賷迹賻", a_);
			base.Id = 10155;
			base.UIName = global::CommonResources.AcgResources.ID_TYPEIICHANNELSETUP;
			base.DataTransferOrder = 12;
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x0014609C File Offset: 0x0014429C
		public override void PopulateReferences()
		{
			short num = (short)1487405057;
			if (num != 0)
			{
			}
			num = (short)1030353289;
			short num2 = num;
			num = (short)1565061513;
			switch (num2 == num)
			{
			}
			num = (short)1517158400;
			short num3 = num;
			num = (short)390463488;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x00146148 File Offset: 0x00144348
		public override void DropReferences()
		{
			short num = (short)2088793559;
			short num2 = num;
			num = (short)1372616151;
			switch (num2 == num)
			{
			}
			num = (short)851050497;
			if (num != 0)
			{
			}
			num = (short)542965760;
			short num3 = num;
			num = (short)1590231040;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x001461F0 File Offset: 0x001443F0
		public override void SetConstraints()
		{
			short num = (short)1776916400;
			short num2 = num;
			num = (short)256939952;
			switch (num2 == num)
			{
			}
			num = (short)937361408;
			if (num != 0)
			{
			}
			num = (short)352583680;
			short num3 = num;
			num = (short)507707393;
			if (num != 0)
			{
			}
			this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConBandSelIs700800Mhz);
			this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsII);
			this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConBandSelIsNot900MHz);
			this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConChannelBandwidthValid);
			this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsII);
			this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsII);
			this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConBandSelIs700800Mhz);
			this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsII);
			this.trkSysTypeIIChannelSetupSplinterChannel_A9175.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConBandSelIs700800Mhz);
			this.trkSysTypeIIChannelSetupSplinterChannel_A9175.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsII);
			this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsII);
			this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conReturnTrueIfViewSetToLabtoolOrDepot);
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x001463AC File Offset: 0x001445AC
		public override void SetupDependencies()
		{
			short num = (short)709399445;
			short num2 = num;
			num = (short)1406833557;
			switch (num2 == num)
			{
			}
			num = (short)1693515777;
			if (num != 0)
			{
			}
			num = (short)1738932224;
			short num3 = num;
			num = (short)1415249920;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652);
			trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491.AddDependentObject(this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654);
			trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491.AddDependentObject(this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654);
			this.RefRadioInformation.Labtool.RadInfoLabtoolQ507G507FCCMANDATE_A38198.AddDependentObject(this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654);
			this.RefRadioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987.AddDependentObject(this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654);
			this.RefRadioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988.AddDependentObject(this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654);
			this.RefRadioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986.AddDependentObject(this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandUHF2_A42547.AddDependentObject(this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571);
			trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491.AddDependentObject(this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysTypeIIChannelSetupSplinterChannel_A9175);
			trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491.AddDependentObject(this.trkSysTypeIIChannelSetupSplinterChannel_A9175);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128);
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06001552 RID: 5458 RVA: 0x001465D0 File Offset: 0x001447D0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1848796395;
				short num2 = num;
				num = (short)774464747;
				switch (num2 == num)
				{
				}
				num = (short)1525350401;
				if (num != 0)
				{
				}
				num = (short)988020736;
				short num3 = num;
				num = (short)948174848;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06001553 RID: 5459 RVA: 0x00146684 File Offset: 0x00144884
		// (set) Token: 0x06001554 RID: 5460 RVA: 0x00146738 File Offset: 0x00144938
		public int TrkSysTypeIIChannelSetupChannelAssignmentType_A7652Value
		{
			get
			{
				short num = (short)454346179;
				short num2 = num;
				num = (short)994690499;
				switch (num2 == num)
				{
				}
				num = (short)1967194112;
				if (num != 0)
				{
				}
				num = (short)1386479616;
				short num3 = num;
				num = (short)628752385;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652.Value;
			}
			set
			{
				short num = (short)65334590;
				short num2 = num;
				num = (short)438562110;
				switch (num2 == num)
				{
				}
				num = (short)1503461377;
				if (num != 0)
				{
				}
				num = (short)249823232;
				short num3 = num;
				num = (short)816906240;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652.Value = value;
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06001555 RID: 5461 RVA: 0x001467F0 File Offset: 0x001449F0
		// (set) Token: 0x06001556 RID: 5462 RVA: 0x001468A4 File Offset: 0x00144AA4
		public string TrkSysTypeIIChannelSetupChannelAssignmentType_A7652_UIValue
		{
			get
			{
				short num = (short)1077274978;
				short num2 = num;
				num = (short)1630464354;
				switch (num2 == num)
				{
				}
				num = (short)105316352;
				if (num != 0)
				{
				}
				num = (short)393084928;
				short num3 = num;
				num = (short)560005121;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652.UIValue;
			}
			set
			{
				short num = (short)1783867583;
				short num2 = num;
				num = (short)2132519103;
				switch (num2 == num)
				{
				}
				num = (short)1861943297;
				if (num != 0)
				{
				}
				num = (short)2087518208;
				short num3 = num;
				num = (short)1234042880;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652.UIValue = value;
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06001557 RID: 5463 RVA: 0x0014695C File Offset: 0x00144B5C
		public global::AcpBusinessLayer.AcpListField TrkSysTypeIIChannelSetupChannelAssignmentType_A7652
		{
			get
			{
				short num = (short)735805334;
				short num2 = num;
				num = (short)2000125846;
				switch (num2 == num)
				{
				}
				num = (short)397606913;
				if (num != 0)
				{
				}
				num = (short)387842048;
				short num3 = num;
				num = (short)1022296064;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652;
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06001558 RID: 5464 RVA: 0x00146A0C File Offset: 0x00144C0C
		// (set) Token: 0x06001559 RID: 5465 RVA: 0x00146AC0 File Offset: 0x00144CC0
		public bool TrkSysTypeIIChannelSetupChannelAssignmentType_A7652_Applicable
		{
			get
			{
				short num = (short)173835838;
				short num2 = num;
				num = (short)14583358;
				switch (num2 == num)
				{
				}
				num = (short)1377107969;
				if (num != 0)
				{
				}
				num = (short)967442432;
				short num3 = num;
				num = (short)981073920;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652.Applicable;
			}
			set
			{
				short num = (short)444943713;
				short num2 = num;
				num = (short)1295928673;
				switch (num2 == num)
				{
				}
				num = (short)463339520;
				if (num != 0)
				{
				}
				num = (short)1239482368;
				short num3 = num;
				num = (short)527237121;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652.Applicable = value;
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x0600155A RID: 5466 RVA: 0x00146B74 File Offset: 0x00144D74
		// (set) Token: 0x0600155B RID: 5467 RVA: 0x00146C2C File Offset: 0x00144E2C
		public bool TrkSysTypeIIChannelSetupChannelAssignmentType_A7652_Valid
		{
			get
			{
				short num = (short)541996301;
				short num2 = num;
				num = (short)82982157;
				switch (num2 == num)
				{
				}
				num = (short)481755137;
				if (num != 0)
				{
				}
				num = (short)2142961664;
				short num3 = num;
				num = (short)1661337600;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652.Valid;
			}
			set
			{
				short num = (short)1829296789;
				short num2 = num;
				num = (short)1500437141;
				switch (num2 == num)
				{
				}
				num = (short)328794113;
				if (num != 0)
				{
				}
				num = (short)613482496;
				short num3 = num;
				num = (short)761266176;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652.Valid = value;
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x0600155C RID: 5468 RVA: 0x00146CE0 File Offset: 0x00144EE0
		// (set) Token: 0x0600155D RID: 5469 RVA: 0x00146D94 File Offset: 0x00144F94
		public bool TrkSysTypeIIChannelSetupChannelAssignmentType_A7652_Visible
		{
			get
			{
				short num = (short)435047452;
				short num2 = num;
				num = (short)1314278428;
				switch (num2 == num)
				{
				}
				num = (short)416350209;
				if (num != 0)
				{
				}
				num = (short)1210318848;
				short num3 = num;
				num = (short)2026635264;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652.Visible;
			}
			set
			{
				short num = (short)250454237;
				short num2 = num;
				num = (short)1267114205;
				switch (num2 == num)
				{
				}
				num = (short)970063873;
				if (num != 0)
				{
				}
				num = (short)1222705152;
				short num3 = num;
				num = (short)1262747648;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652.Visible = value;
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x00146E4C File Offset: 0x0014504C
		// (set) Token: 0x0600155F RID: 5471 RVA: 0x00146F04 File Offset: 0x00145104
		public bool TrkSysTypeIIChannelSetupChannelAssignmentType_A7652_Editable
		{
			get
			{
				short num = (short)880643005;
				short num2 = num;
				num = (short)825658301;
				switch (num2 == num)
				{
				}
				num = (short)649330689;
				if (num != 0)
				{
				}
				num = (short)690487296;
				short num3 = num;
				num = (short)1672609792;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652.Editable;
			}
			set
			{
				short num = (short)1460998698;
				short num2 = num;
				num = (short)414585386;
				switch (num2 == num)
				{
				}
				num = (short)2004549632;
				if (num != 0)
				{
				}
				num = (short)1049952256;
				short num3 = num;
				num = (short)1403584513;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652.Editable = value;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x00146FB8 File Offset: 0x001451B8
		internal string TrkSysTypeIIChannelSetupChannelAssignmentType_A7652_UILabel
		{
			get
			{
				short num = (short)1360074788;
				short num2 = num;
				num = (short)262150180;
				switch (num2 == num)
				{
				}
				num = (short)102760449;
				if (num != 0)
				{
				}
				num = (short)1933836288;
				short num3 = num;
				num = (short)1786707968;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652.UIName;
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06001561 RID: 5473 RVA: 0x00147068 File Offset: 0x00145268
		// (set) Token: 0x06001562 RID: 5474 RVA: 0x00147120 File Offset: 0x00145320
		internal bool TrkSysTypeIIChannelSetupChannelAssignmentType_A7652_HiddenStatic
		{
			get
			{
				short num = (short)1504747922;
				short num2 = num;
				num = (short)1617797522;
				switch (num2 == num)
				{
				}
				num = (short)958857217;
				if (num != 0)
				{
				}
				num = (short)950403072;
				short num3 = num;
				num = (short)529661952;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652.HiddenStatic;
			}
			set
			{
				short num = (short)194375235;
				short num2 = num;
				num = (short)192933443;
				switch (num2 == num)
				{
				}
				num = (short)1716387841;
				if (num != 0)
				{
				}
				num = (short)1466826752;
				short num3 = num;
				num = (short)837877760;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652.HiddenStatic = value;
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06001563 RID: 5475 RVA: 0x001471D4 File Offset: 0x001453D4
		// (set) Token: 0x06001564 RID: 5476 RVA: 0x00147288 File Offset: 0x00145488
		internal bool TrkSysTypeIIChannelSetupChannelAssignmentType_A7652_HiddenDynamic
		{
			get
			{
				short num = (short)376880526;
				short num2 = num;
				num = (short)192986510;
				switch (num2 == num)
				{
				}
				num = (short)582156289;
				if (num != 0)
				{
				}
				num = (short)1785987072;
				short num3 = num;
				num = (short)244252672;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652.HiddenDynamic;
			}
			set
			{
				short num = (short)2000952520;
				short num2 = num;
				num = (short)1425677512;
				switch (num2 == num)
				{
				}
				num = (short)101318657;
				if (num != 0)
				{
				}
				num = (short)730202112;
				short num3 = num;
				num = (short)1402601472;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652.HiddenDynamic = value;
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06001565 RID: 5477 RVA: 0x00147340 File Offset: 0x00145540
		public bool TrkSysTypeIIChannelSetupChannelAssignmentType_A7652_HasDiffs
		{
			get
			{
				short num = (short)603829617;
				short num2 = num;
				num = (short)300070257;
				switch (num2 == num)
				{
				}
				num = (short)1313931265;
				if (num != 0)
				{
				}
				num = (short)2022965248;
				short num3 = num;
				num = (short)604962816;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupChannelAssignmentType_A7652._HasDiffs;
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x001473F8 File Offset: 0x001455F8
		// (set) Token: 0x06001567 RID: 5479 RVA: 0x001474AC File Offset: 0x001456AC
		public int TrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654Value
		{
			get
			{
				short num = (short)399445790;
				short num2 = num;
				num = (short)506072862;
				switch (num2 == num)
				{
				}
				num = (short)866385921;
				if (num != 0)
				{
				}
				num = (short)2005860352;
				short num3 = num;
				num = (short)1085800448;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.Value;
			}
			set
			{
				short num = (short)1272270092;
				short num2 = num;
				num = (short)655379724;
				switch (num2 == num)
				{
				}
				num = (short)140509185;
				if (num != 0)
				{
				}
				num = (short)1819410432;
				short num3 = num;
				num = (short)375652352;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.Value = value;
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06001568 RID: 5480 RVA: 0x00147560 File Offset: 0x00145760
		// (set) Token: 0x06001569 RID: 5481 RVA: 0x00147614 File Offset: 0x00145814
		public string TrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654_UIValue
		{
			get
			{
				short num = (short)1178770618;
				short num2 = num;
				num = (short)543857850;
				switch (num2 == num)
				{
				}
				num = (short)646905856;
				if (num != 0)
				{
				}
				num = (short)1208942592;
				short num3 = num;
				num = (short)875954177;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.UIValue;
			}
			set
			{
				short num = (short)1638298160;
				short num2 = num;
				num = (short)87126576;
				switch (num2 == num)
				{
				}
				num = (short)734265345;
				if (num != 0)
				{
				}
				num = (short)1486094336;
				short num3 = num;
				num = (short)1313800192;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.UIValue = value;
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x001476C8 File Offset: 0x001458C8
		public global::AcpBusinessLayer.AcpListField TrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654
		{
			get
			{
				short num = (short)1569521665;
				if (num != 0)
				{
				}
				num = (short)447436844;
				short num2 = num;
				num = (short)1387747372;
				switch (num2 == num)
				{
				}
				num = (short)711196672;
				short num3 = num;
				num = (short)693436416;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654;
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x0600156B RID: 5483 RVA: 0x00147778 File Offset: 0x00145978
		// (set) Token: 0x0600156C RID: 5484 RVA: 0x0014782C File Offset: 0x00145A2C
		public bool TrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654_Applicable
		{
			get
			{
				short num = (short)1091214951;
				short num2 = num;
				num = (short)849649255;
				switch (num2 == num)
				{
				}
				num = (short)109379584;
				if (num != 0)
				{
				}
				num = (short)1448738816;
				short num3 = num;
				num = (short)175439873;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.Applicable;
			}
			set
			{
				short num = (short)1538808764;
				short num2 = num;
				num = (short)2092981180;
				switch (num2 == num)
				{
				}
				num = (short)1154154497;
				if (num != 0)
				{
				}
				num = (short)1865744384;
				short num3 = num;
				num = (short)311558144;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.Applicable = value;
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x0600156D RID: 5485 RVA: 0x001478E4 File Offset: 0x00145AE4
		// (set) Token: 0x0600156E RID: 5486 RVA: 0x00147998 File Offset: 0x00145B98
		public bool TrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654_Valid
		{
			get
			{
				short num = (short)634697998;
				short num2 = num;
				num = (short)1020639502;
				switch (num2 == num)
				{
				}
				num = (short)1832124416;
				if (num != 0)
				{
				}
				num = (short)1123483648;
				short num3 = num;
				num = (short)482738177;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.Valid;
			}
			set
			{
				short num = (short)942473217;
				if (num != 0)
				{
				}
				num = (short)450806094;
				short num2 = num;
				num = (short)179683662;
				switch (num2 == num)
				{
				}
				num = (short)1559822336;
				short num3 = num;
				num = (short)533463040;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.Valid = value;
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x0600156F RID: 5487 RVA: 0x00147A4C File Offset: 0x00145C4C
		// (set) Token: 0x06001570 RID: 5488 RVA: 0x00147B04 File Offset: 0x00145D04
		public bool TrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654_Visible
		{
			get
			{
				short num = (short)888223555;
				short num2 = num;
				num = (short)1765685059;
				switch (num2 == num)
				{
				}
				num = (short)449970177;
				if (num != 0)
				{
				}
				num = (short)234356736;
				short num3 = num;
				num = (short)1046282240;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.Visible;
			}
			set
			{
				short num = (short)1197077461;
				short num2 = num;
				num = (short)1054143445;
				switch (num2 == num)
				{
				}
				num = (short)630718465;
				if (num != 0)
				{
				}
				num = (short)947126272;
				short num3 = num;
				num = (short)1696071680;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.Visible = value;
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x00147BB8 File Offset: 0x00145DB8
		// (set) Token: 0x06001572 RID: 5490 RVA: 0x00147C70 File Offset: 0x00145E70
		public bool TrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654_Editable
		{
			get
			{
				short num = (short)1800125221;
				short num2 = num;
				num = (short)617724709;
				switch (num2 == num)
				{
				}
				num = (short)69926913;
				if (num != 0)
				{
				}
				num = (short)1556152320;
				short num3 = num;
				num = (short)769982464;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.Editable;
			}
			set
			{
				short num = (short)1549544899;
				short num2 = num;
				num = (short)1158622659;
				switch (num2 == num)
				{
				}
				num = (short)1264517121;
				if (num != 0)
				{
				}
				num = (short)727908352;
				short num3 = num;
				num = (short)1767702528;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.Editable = value;
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x00147D28 File Offset: 0x00145F28
		internal string TrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654_UILabel
		{
			get
			{
				short num = (short)408969338;
				short num2 = num;
				num = (short)1429430394;
				switch (num2 == num)
				{
				}
				num = (short)173539329;
				if (num != 0)
				{
				}
				num = (short)2133262336;
				short num3 = num;
				num = (short)408289280;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.UIName;
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x00147DDC File Offset: 0x00145FDC
		// (set) Token: 0x06001575 RID: 5493 RVA: 0x00147E8C File Offset: 0x0014608C
		internal bool TrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654_HiddenStatic
		{
			get
			{
				short num = (short)641405484;
				short num2 = num;
				num = (short)1088950828;
				switch (num2 == num)
				{
				}
				num = (short)1048576000;
				if (num != 0)
				{
				}
				num = (short)883752960;
				short num3 = num;
				num = (short)1594753025;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.HiddenStatic;
			}
			set
			{
				short num = (short)279340270;
				short num2 = num;
				num = (short)1095525614;
				switch (num2 == num)
				{
				}
				num = (short)1386086400;
				if (num != 0)
				{
				}
				num = (short)273350656;
				short num3 = num;
				num = (short)1606811649;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.HiddenStatic = value;
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x00147F44 File Offset: 0x00146144
		// (set) Token: 0x06001577 RID: 5495 RVA: 0x00147FF8 File Offset: 0x001461F8
		internal bool TrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654_HiddenDynamic
		{
			get
			{
				short num = (short)484068876;
				short num2 = num;
				num = (short)2112310796;
				switch (num2 == num)
				{
				}
				num = (short)520749056;
				if (num != 0)
				{
				}
				num = (short)364773376;
				short num3 = num;
				num = (short)1874067457;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.HiddenDynamic;
			}
			set
			{
				short num = (short)895773872;
				short num2 = num;
				num = (short)1043426480;
				switch (num2 == num)
				{
				}
				num = (short)613220352;
				if (num != 0)
				{
				}
				num = (short)1095630848;
				short num3 = num;
				num = (short)1479933953;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.HiddenDynamic = value;
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x001480B0 File Offset: 0x001462B0
		public bool TrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654_HasDiffs
		{
			get
			{
				short num = (short)756715485;
				short num2 = num;
				num = (short)1884917725;
				switch (num2 == num)
				{
				}
				num = (short)1243414529;
				if (num != 0)
				{
				}
				num = (short)839712768;
				short num3 = num;
				num = (short)1728315392;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654._HasDiffs;
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06001579 RID: 5497 RVA: 0x00148164 File Offset: 0x00146364
		// (set) Token: 0x0600157A RID: 5498 RVA: 0x00148218 File Offset: 0x00146418
		public bool TrkSysTypeIIChannelSetupLegacyTransitSystem_A8429Value
		{
			get
			{
				short num = (short)1628448046;
				short num2 = num;
				num = (short)912401710;
				switch (num2 == num)
				{
				}
				num = (short)1912078337;
				if (num != 0)
				{
				}
				num = (short)1188495360;
				short num3 = num;
				num = (short)1291059200;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429.Value;
			}
			set
			{
				short num = (short)619321926;
				short num2 = num;
				num = (short)967318086;
				switch (num2 == num)
				{
				}
				num = (short)1761738752;
				if (num != 0)
				{
				}
				num = (short)92864512;
				short num3 = num;
				num = (short)1014497281;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429.Value = value;
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x001482D0 File Offset: 0x001464D0
		public global::AcpBusinessLayer.AcpField<bool> TrkSysTypeIIChannelSetupLegacyTransitSystem_A8429
		{
			get
			{
				short num = (short)1539225830;
				short num2 = num;
				num = (short)293255398;
				switch (num2 == num)
				{
				}
				num = (short)119406592;
				if (num != 0)
				{
				}
				num = (short)351141888;
				short num3 = num;
				num = (short)1433862145;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429;
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x0600157C RID: 5500 RVA: 0x00148380 File Offset: 0x00146580
		// (set) Token: 0x0600157D RID: 5501 RVA: 0x00148438 File Offset: 0x00146638
		public bool TrkSysTypeIIChannelSetupLegacyTransitSystem_A8429_UIValue
		{
			get
			{
				short num = (short)299630124;
				short num2 = num;
				num = (short)365231660;
				switch (num2 == num)
				{
				}
				num = (short)2144141313;
				if (num != 0)
				{
				}
				num = (short)292945920;
				short num3 = num;
				num = (short)465502208;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429.Value;
			}
			set
			{
				short num = (short)1617298808;
				short num2 = num;
				num = (short)1161954680;
				switch (num2 == num)
				{
				}
				num = (short)1599012864;
				if (num != 0)
				{
				}
				num = (short)1333919744;
				short num3 = num;
				num = (short)823984129;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429.Value = value;
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x0600157E RID: 5502 RVA: 0x001484F0 File Offset: 0x001466F0
		// (set) Token: 0x0600157F RID: 5503 RVA: 0x001485A4 File Offset: 0x001467A4
		public bool TrkSysTypeIIChannelSetupLegacyTransitSystem_A8429_Applicable
		{
			get
			{
				short num = (short)880288920;
				short num2 = num;
				num = (short)1833772184;
				switch (num2 == num)
				{
				}
				num = (short)2042101761;
				if (num != 0)
				{
				}
				num = (short)1833435136;
				short num3 = num;
				num = (short)1309278208;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429.Applicable;
			}
			set
			{
				short num = (short)392298496;
				short num2 = num;
				num = (short)54080145;
				short num3 = num;
				num = (short)1664168593;
				switch (num3 == num)
				{
				}
				num = (short)1476722688;
				if (num != 0)
				{
				}
				num = (short)1280704513;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429.Applicable = value;
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06001580 RID: 5504 RVA: 0x0014865C File Offset: 0x0014685C
		// (set) Token: 0x06001581 RID: 5505 RVA: 0x00148714 File Offset: 0x00146914
		public bool TrkSysTypeIIChannelSetupLegacyTransitSystem_A8429_Valid
		{
			get
			{
				short num = (short)61538304;
				short num2 = num;
				num = (short)926512698;
				short num3 = num;
				num = (short)861304378;
				switch (num3 == num)
				{
				}
				num = (short)347078657;
				if (num != 0)
				{
				}
				num = (short)1304166400;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429.Valid;
			}
			set
			{
				short num = (short)1720516608;
				short num2 = num;
				num = (short)582344468;
				short num3 = num;
				num = (short)1577836308;
				switch (num3 == num)
				{
				}
				num = (short)1973813248;
				if (num != 0)
				{
				}
				num = (short)2105212929;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429.Valid = value;
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x001487C8 File Offset: 0x001469C8
		// (set) Token: 0x06001583 RID: 5507 RVA: 0x0014887C File Offset: 0x00146A7C
		public bool TrkSysTypeIIChannelSetupLegacyTransitSystem_A8429_Visible
		{
			get
			{
				short num = (short)1271398400;
				short num2 = num;
				num = (short)926470613;
				short num3 = num;
				num = (short)706269653;
				switch (num3 == num)
				{
				}
				num = (short)621936640;
				if (num != 0)
				{
				}
				num = (short)1145765889;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429.Visible;
			}
			set
			{
				short num = (short)553910272;
				short num2 = num;
				num = (short)1538743003;
				short num3 = num;
				num = (short)82467547;
				switch (num3 == num)
				{
				}
				num = (short)769392640;
				if (num != 0)
				{
				}
				num = (short)1022230529;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429.Visible = value;
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06001584 RID: 5508 RVA: 0x00148934 File Offset: 0x00146B34
		// (set) Token: 0x06001585 RID: 5509 RVA: 0x001489E8 File Offset: 0x00146BE8
		public bool TrkSysTypeIIChannelSetupLegacyTransitSystem_A8429_Editable
		{
			get
			{
				short num = (short)1840971776;
				short num2 = num;
				num = (short)567816874;
				short num3 = num;
				num = (short)426586794;
				switch (num3 == num)
				{
				}
				num = (short)1460273153;
				if (num != 0)
				{
				}
				num = (short)1942552576;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429.Editable;
			}
			set
			{
				short num = (short)1344864256;
				short num2 = num;
				num = (short)1148990459;
				short num3 = num;
				num = (short)497693691;
				switch (num3 == num)
				{
				}
				num = (short)1022230529;
				if (num != 0)
				{
				}
				num = (short)1722023936;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429.Editable = value;
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x00148A9C File Offset: 0x00146C9C
		internal string TrkSysTypeIIChannelSetupLegacyTransitSystem_A8429_UILabel
		{
			get
			{
				short num = (short)886898688;
				short num2 = num;
				num = (short)96927745;
				if (num != 0)
				{
				}
				num = (short)1445681422;
				short num3 = num;
				num = (short)472144142;
				switch (num3 == num)
				{
				}
				num = (short)1175388160;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429.UIName;
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06001587 RID: 5511 RVA: 0x00148B50 File Offset: 0x00146D50
		// (set) Token: 0x06001588 RID: 5512 RVA: 0x00148C04 File Offset: 0x00146E04
		internal bool TrkSysTypeIIChannelSetupLegacyTransitSystem_A8429_HiddenStatic
		{
			get
			{
				short num = (short)56623104;
				short num2 = num;
				num = (short)2111300159;
				short num3 = num;
				num = (short)1002889791;
				switch (num3 == num)
				{
				}
				num = (short)821559297;
				if (num != 0)
				{
				}
				num = (short)991821824;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429.HiddenStatic;
			}
			set
			{
				short num = (short)1865482240;
				short num2 = num;
				num = (short)81854465;
				if (num != 0)
				{
				}
				num = (short)304252023;
				short num3 = num;
				num = (short)701072503;
				switch (num3 == num)
				{
				}
				num = (short)1684602880;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429.HiddenStatic = value;
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06001589 RID: 5513 RVA: 0x00148CBC File Offset: 0x00146EBC
		// (set) Token: 0x0600158A RID: 5514 RVA: 0x00148D70 File Offset: 0x00146F70
		internal bool TrkSysTypeIIChannelSetupLegacyTransitSystem_A8429_HiddenDynamic
		{
			get
			{
				short num = (short)154533888;
				short num2 = num;
				num = (short)1276123102;
				short num3 = num;
				num = (short)1164842974;
				switch (num3 == num)
				{
				}
				num = (short)712310784;
				if (num != 0)
				{
				}
				num = (short)1329725441;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429.HiddenDynamic;
			}
			set
			{
				short num = (short)498794496;
				short num2 = num;
				num = (short)1657678089;
				short num3 = num;
				num = (short)501033225;
				switch (num3 == num)
				{
				}
				num = (short)139395073;
				if (num != 0)
				{
				}
				num = (short)393347072;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429.HiddenDynamic = value;
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x0600158B RID: 5515 RVA: 0x00148E28 File Offset: 0x00147028
		public bool TrkSysTypeIIChannelSetupLegacyTransitSystem_A8429_HasDiffs
		{
			get
			{
				short num = (short)748421120;
				short num2 = num;
				num = (short)1693188097;
				if (num != 0)
				{
				}
				num = (short)5667597;
				short num3 = num;
				num = (short)373521165;
				switch (num3 == num)
				{
				}
				num = (short)620167168;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupLegacyTransitSystem_A8429._HasDiffs;
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x0600158C RID: 5516 RVA: 0x00148EDC File Offset: 0x001470DC
		// (set) Token: 0x0600158D RID: 5517 RVA: 0x00148F90 File Offset: 0x00147190
		public int TrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571Value
		{
			get
			{
				short num = (short)1613692928;
				short num2 = num;
				num = (short)1037144373;
				short num3 = num;
				num = (short)595562805;
				switch (num3 == num)
				{
				}
				num = (short)1231093760;
				if (num != 0)
				{
				}
				num = (short)32768001;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571.Value;
			}
			set
			{
				short num = (short)1168506880;
				short num2 = num;
				num = (short)373361239;
				short num3 = num;
				num = (short)1998457431;
				switch (num3 == num)
				{
				}
				num = (short)206831617;
				if (num != 0)
				{
				}
				num = (short)1280835584;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571.Value = value;
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x0600158E RID: 5518 RVA: 0x00149044 File Offset: 0x00147244
		// (set) Token: 0x0600158F RID: 5519 RVA: 0x001490FC File Offset: 0x001472FC
		public string TrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571_UIValue
		{
			get
			{
				short num = (short)1518010368;
				short num2 = num;
				num = (short)85205977;
				short num3 = num;
				num = (short)1063920601;
				switch (num3 == num)
				{
				}
				num = (short)2046951424;
				if (num != 0)
				{
				}
				num = (short)2109538305;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571.UIValue;
			}
			set
			{
				short num = (short)797900800;
				short num2 = num;
				num = (short)1561775407;
				short num3 = num;
				num = (short)363318575;
				switch (num3 == num)
				{
				}
				num = (short)1030619137;
				if (num != 0)
				{
				}
				num = (short)1905262592;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571.UIValue = value;
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06001590 RID: 5520 RVA: 0x001491B0 File Offset: 0x001473B0
		public global::AcpBusinessLayer.AcpListField TrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571
		{
			get
			{
				short num = (short)1636827136;
				short num2 = num;
				num = (short)1077513235;
				short num3 = num;
				num = (short)855870483;
				switch (num3 == num)
				{
				}
				num = (short)1825701889;
				if (num != 0)
				{
				}
				num = (short)1379074048;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571;
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x00149260 File Offset: 0x00147460
		// (set) Token: 0x06001592 RID: 5522 RVA: 0x00149314 File Offset: 0x00147514
		public bool TrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571_Applicable
		{
			get
			{
				short num = (short)1291386880;
				short num2 = num;
				num = (short)1813642698;
				short num3 = num;
				num = (short)403635658;
				switch (num3 == num)
				{
				}
				num = (short)1950416896;
				if (num != 0)
				{
				}
				num = (short)2087911425;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571.Applicable;
			}
			set
			{
				short num = (short)1796276224;
				short num2 = num;
				num = (short)1945233087;
				short num3 = num;
				num = (short)791144127;
				switch (num3 == num)
				{
				}
				num = (short)2124021760;
				if (num != 0)
				{
				}
				num = (short)1429274625;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571.Applicable = value;
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x001493CC File Offset: 0x001475CC
		// (set) Token: 0x06001594 RID: 5524 RVA: 0x00149480 File Offset: 0x00147680
		public bool TrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571_Valid
		{
			get
			{
				short num = (short)2098462720;
				short num2 = num;
				num = (short)1234276598;
				short num3 = num;
				num = (short)1463783670;
				switch (num3 == num)
				{
				}
				num = (short)748814336;
				if (num != 0)
				{
				}
				num = (short)661454849;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571.Valid;
			}
			set
			{
				short num = (short)104595456;
				short num2 = num;
				num = (short)1340568345;
				short num3 = num;
				num = (short)1805153049;
				switch (num3 == num)
				{
				}
				num = (short)131596288;
				if (num != 0)
				{
				}
				num = (short)749535233;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571.Valid = value;
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06001595 RID: 5525 RVA: 0x00149534 File Offset: 0x00147734
		// (set) Token: 0x06001596 RID: 5526 RVA: 0x001495E8 File Offset: 0x001477E8
		public bool TrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571_Visible
		{
			get
			{
				short num = (short)1721237504;
				short num2 = num;
				num = (short)936323907;
				short num3 = num;
				num = (short)1672162115;
				switch (num3 == num)
				{
				}
				num = (short)1467678721;
				if (num != 0)
				{
				}
				num = (short)697499648;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571.Visible;
			}
			set
			{
				short num = (short)841809920;
				short num2 = num;
				num = (short)959381501;
				short num3 = num;
				num = (short)1477902333;
				switch (num3 == num)
				{
				}
				num = (short)456589312;
				if (num != 0)
				{
				}
				num = (short)1997996033;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571.Visible = value;
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06001597 RID: 5527 RVA: 0x0014969C File Offset: 0x0014789C
		// (set) Token: 0x06001598 RID: 5528 RVA: 0x00149750 File Offset: 0x00147950
		public bool TrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571_Editable
		{
			get
			{
				short num = (short)1354432512;
				short num2 = num;
				num = (short)1139061558;
				short num3 = num;
				num = (short)1191031606;
				switch (num3 == num)
				{
				}
				num = (short)1127415809;
				if (num != 0)
				{
				}
				num = (short)940638208;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571.Editable;
			}
			set
			{
				short num = (short)81133568;
				short num2 = num;
				num = (short)1513116550;
				short num3 = num;
				num = (short)1419596678;
				switch (num3 == num)
				{
				}
				num = (short)898760704;
				if (num != 0)
				{
				}
				num = (short)947191809;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571.Editable = value;
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06001599 RID: 5529 RVA: 0x00149808 File Offset: 0x00147A08
		internal string TrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571_UILabel
		{
			get
			{
				short num = (short)2061107200;
				short num2 = num;
				num = (short)687833491;
				short num3 = num;
				num = (short)925860243;
				switch (num3 == num)
				{
				}
				num = (short)1975582721;
				if (num != 0)
				{
				}
				num = (short)96206848;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571.UIName;
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x001498BC File Offset: 0x00147ABC
		// (set) Token: 0x0600159B RID: 5531 RVA: 0x00149974 File Offset: 0x00147B74
		internal bool TrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571_HiddenStatic
		{
			get
			{
				short num = (short)1452933120;
				short num2 = num;
				num = (short)1783639472;
				short num3 = num;
				num = (short)1564290480;
				switch (num3 == num)
				{
				}
				num = (short)1370488833;
				if (num != 0)
				{
				}
				num = (short)276561920;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571.HiddenStatic;
			}
			set
			{
				short num = (short)1655898112;
				short num2 = num;
				num = (short)2025652225;
				if (num != 0)
				{
				}
				num = (short)1200551833;
				short num3 = num;
				num = (short)35649433;
				switch (num3 == num)
				{
				}
				num = (short)1503592448;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571.HiddenStatic = value;
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x00149A28 File Offset: 0x00147C28
		// (set) Token: 0x0600159D RID: 5533 RVA: 0x00149AE0 File Offset: 0x00147CE0
		internal bool TrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571_HiddenDynamic
		{
			get
			{
				short num = (short)839974912;
				short num2 = num;
				num = (short)1991875370;
				short num3 = num;
				num = (short)1756601130;
				switch (num3 == num)
				{
				}
				num = (short)1127546880;
				if (num != 0)
				{
				}
				num = (short)1629421569;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571.HiddenDynamic;
			}
			set
			{
				short num = (short)1455357952;
				short num2 = num;
				num = (short)2009945655;
				short num3 = num;
				num = (short)1066882615;
				switch (num3 == num)
				{
				}
				num = (short)482869249;
				if (num != 0)
				{
				}
				num = (short)2042888192;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571.HiddenDynamic = value;
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x0600159E RID: 5534 RVA: 0x00149B98 File Offset: 0x00147D98
		public bool TrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571_HasDiffs
		{
			get
			{
				short num = (short)1254424576;
				short num2 = num;
				num = (short)1099366401;
				if (num != 0)
				{
				}
				num = (short)703418079;
				short num3 = num;
				num = (short)1521897183;
				switch (num3 == num)
				{
				}
				num = (short)1777860608;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571._HasDiffs;
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x0600159F RID: 5535 RVA: 0x00149C50 File Offset: 0x00147E50
		// (set) Token: 0x060015A0 RID: 5536 RVA: 0x00149D08 File Offset: 0x00147F08
		public bool TrkSysTypeIIChannelSetupSplinterChannel_A9175Value
		{
			get
			{
				short num = (short)1668677632;
				short num2 = num;
				num = (short)370120513;
				short num3 = num;
				num = (short)1277335361;
				switch (num3 == num)
				{
				}
				num = (short)1622016000;
				if (num != 0)
				{
				}
				num = (short)867500033;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupSplinterChannel_A9175.Value;
			}
			set
			{
				short num = (short)1658257408;
				short num2 = num;
				num = (short)1019563416;
				short num3 = num;
				num = (short)1552829848;
				switch (num3 == num)
				{
				}
				num = (short)1689583616;
				if (num != 0)
				{
				}
				num = (short)277741569;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupSplinterChannel_A9175.Value = value;
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x060015A1 RID: 5537 RVA: 0x00149DC0 File Offset: 0x00147FC0
		public global::AcpBusinessLayer.AcpField<bool> TrkSysTypeIIChannelSetupSplinterChannel_A9175
		{
			get
			{
				short num = (short)1044512768;
				short num2 = num;
				num = (short)441525658;
				short num3 = num;
				num = (short)2008098202;
				switch (num3 == num)
				{
				}
				num = (short)550830081;
				if (num != 0)
				{
				}
				num = (short)123207680;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupSplinterChannel_A9175;
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x060015A2 RID: 5538 RVA: 0x00149E74 File Offset: 0x00148074
		// (set) Token: 0x060015A3 RID: 5539 RVA: 0x00149F28 File Offset: 0x00148128
		public bool TrkSysTypeIIChannelSetupSplinterChannel_A9175_UIValue
		{
			get
			{
				short num = (short)17367040;
				short num2 = num;
				num = (short)2035165229;
				short num3 = num;
				num = (short)1678977069;
				switch (num3 == num)
				{
				}
				num = (short)99811329;
				if (num != 0)
				{
				}
				num = (short)2104688640;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupSplinterChannel_A9175.Value;
			}
			set
			{
				short num = (short)1569160360;
				short num2 = num;
				num = (short)1117682856;
				switch (num2 == num)
				{
				default:
				{
					num = (short)35913728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1872363521;
				if (num != 0)
				{
				}
				num = (short)302710784;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupSplinterChannel_A9175.Value = value;
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x060015A4 RID: 5540 RVA: 0x00149FDC File Offset: 0x001481DC
		// (set) Token: 0x060015A5 RID: 5541 RVA: 0x0014A090 File Offset: 0x00148290
		public bool TrkSysTypeIIChannelSetupSplinterChannel_A9175_Applicable
		{
			get
			{
				short num = (short)1941563192;
				short num2 = num;
				num = (short)1067706168;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1841364992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2036203520;
				if (num != 0)
				{
				}
				num = (short)700907521;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupSplinterChannel_A9175.Applicable;
			}
			set
			{
				short num = (short)1990747762;
				short num2 = num;
				num = (short)565012082;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2037710848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1107558401;
				if (num != 0)
				{
				}
				num = (short)470679552;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupSplinterChannel_A9175.Applicable = value;
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x060015A6 RID: 5542 RVA: 0x0014A144 File Offset: 0x00148344
		// (set) Token: 0x060015A7 RID: 5543 RVA: 0x0014A1F8 File Offset: 0x001483F8
		public bool TrkSysTypeIIChannelSetupSplinterChannel_A9175_Valid
		{
			get
			{
				short num = (short)55706777;
				short num2 = num;
				num = (short)1811809433;
				switch (num2 == num)
				{
				default:
				{
					num = (short)93519872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)876937217;
				if (num != 0)
				{
				}
				num = (short)1177681920;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupSplinterChannel_A9175.Valid;
			}
			set
			{
				short num = (short)48742362;
				short num2 = num;
				num = (short)20561882;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1675231232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2029256704;
				if (num != 0)
				{
				}
				num = (short)951648257;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupSplinterChannel_A9175.Valid = value;
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x060015A8 RID: 5544 RVA: 0x0014A2AC File Offset: 0x001484AC
		// (set) Token: 0x060015A9 RID: 5545 RVA: 0x0014A360 File Offset: 0x00148560
		public bool TrkSysTypeIIChannelSetupSplinterChannel_A9175_Visible
		{
			get
			{
				short num = (short)1073373719;
				short num2 = num;
				num = (short)1208312343;
				switch (num2 == num)
				{
				default:
				{
					num = (short)701825024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)825229313;
				if (num != 0)
				{
				}
				num = (short)157483008;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupSplinterChannel_A9175.Visible;
			}
			set
			{
				short num = (short)34950020;
				short num2 = num;
				num = (short)881412996;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1838874624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)394526721;
				if (num != 0)
				{
				}
				num = (short)60948480;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupSplinterChannel_A9175.Visible = value;
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x060015AA RID: 5546 RVA: 0x0014A418 File Offset: 0x00148618
		// (set) Token: 0x060015AB RID: 5547 RVA: 0x0014A4CC File Offset: 0x001486CC
		public bool TrkSysTypeIIChannelSetupSplinterChannel_A9175_Editable
		{
			get
			{
				short num = (short)257219586;
				short num2 = num;
				num = (short)904125442;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1704591360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1264451585;
				if (num != 0)
				{
				}
				num = (short)82903040;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupSplinterChannel_A9175.Editable;
			}
			set
			{
				short num = (short)401145857;
				if (num != 0)
				{
				}
				num = (short)887095296;
				short num2 = num;
				num = (short)736819790;
				short num3 = num;
				num = (short)1778776654;
				switch (num3 == num)
				{
				}
				num = (short)1594032128;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupSplinterChannel_A9175.Editable = value;
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x060015AC RID: 5548 RVA: 0x0014A580 File Offset: 0x00148780
		internal string TrkSysTypeIIChannelSetupSplinterChannel_A9175_UILabel
		{
			get
			{
				short num = (short)283458532;
				short num2 = num;
				num = (short)705510372;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1864499200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)46792705;
				if (num != 0)
				{
				}
				num = (short)1197015040;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupSplinterChannel_A9175.UIName;
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x060015AD RID: 5549 RVA: 0x0014A634 File Offset: 0x00148834
		// (set) Token: 0x060015AE RID: 5550 RVA: 0x0014A6E8 File Offset: 0x001488E8
		internal bool TrkSysTypeIIChannelSetupSplinterChannel_A9175_HiddenStatic
		{
			get
			{
				short num = (short)1851970302;
				short num2 = num;
				num = (short)514642686;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1511849984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1005649920;
				if (num != 0)
				{
				}
				num = (short)701300737;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupSplinterChannel_A9175.HiddenStatic;
			}
			set
			{
				short num = (short)1027332986;
				short num2 = num;
				num = (short)2004081530;
				switch (num2 == num)
				{
				default:
				{
					num = (short)244776960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)878379008;
				if (num != 0)
				{
				}
				num = (short)136904705;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupSplinterChannel_A9175.HiddenStatic = value;
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x060015AF RID: 5551 RVA: 0x0014A79C File Offset: 0x0014899C
		// (set) Token: 0x060015B0 RID: 5552 RVA: 0x0014A850 File Offset: 0x00148A50
		internal bool TrkSysTypeIIChannelSetupSplinterChannel_A9175_HiddenDynamic
		{
			get
			{
				short num = (short)2028601345;
				if (num != 0)
				{
				}
				num = (short)1338703872;
				short num2 = num;
				num = (short)2059306373;
				short num3 = num;
				num = (short)1314358661;
				switch (num3 == num)
				{
				}
				num = (short)1947140096;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupSplinterChannel_A9175.HiddenDynamic;
			}
			set
			{
				short num = (short)640418132;
				short num2 = num;
				num = (short)694419796;
				switch (num2 == num)
				{
				default:
				{
					num = (short)118095872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1164771329;
				if (num != 0)
				{
				}
				num = (short)627572736;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupSplinterChannel_A9175.HiddenDynamic = value;
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x0014A904 File Offset: 0x00148B04
		public bool TrkSysTypeIIChannelSetupSplinterChannel_A9175_HasDiffs
		{
			get
			{
				short num = (short)1665158422;
				short num2 = num;
				num = (short)585256214;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1668153344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1502674945;
				if (num != 0)
				{
				}
				num = (short)162594816;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupSplinterChannel_A9175._HasDiffs;
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x060015B2 RID: 5554 RVA: 0x0014A9B8 File Offset: 0x00148BB8
		// (set) Token: 0x060015B3 RID: 5555 RVA: 0x0014AA6C File Offset: 0x00148C6C
		public bool TrkSysTypeIIChannelSetupShuffledBandPlan_A9128Value
		{
			get
			{
				short num = (short)496905427;
				short num2 = num;
				num = (short)1795173587;
				switch (num2 == num)
				{
				default:
				{
					num = (short)471990272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1062797313;
				if (num != 0)
				{
				}
				num = (short)1181876224;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128.Value;
			}
			set
			{
				short num = (short)383582306;
				short num2 = num;
				num = (short)1015808098;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1961492480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)897318913;
				if (num != 0)
				{
				}
				num = (short)1073676288;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128.Value = value;
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x060015B4 RID: 5556 RVA: 0x0014AB20 File Offset: 0x00148D20
		public global::AcpBusinessLayer.AcpField<bool> TrkSysTypeIIChannelSetupShuffledBandPlan_A9128
		{
			get
			{
				short num = (short)2087452673;
				if (num != 0)
				{
				}
				num = (short)264241152;
				short num2 = num;
				num = (short)1644240569;
				short num3 = num;
				num = (short)504372921;
				switch (num3 == num)
				{
				}
				num = (short)391577600;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128;
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x060015B5 RID: 5557 RVA: 0x0014ABCC File Offset: 0x00148DCC
		// (set) Token: 0x060015B6 RID: 5558 RVA: 0x0014AC84 File Offset: 0x00148E84
		public bool TrkSysTypeIIChannelSetupShuffledBandPlan_A9128_UIValue
		{
			get
			{
				short num = (short)1786155937;
				short num2 = num;
				num = (short)805213089;
				switch (num2 == num)
				{
				default:
				{
					num = (short)927006720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1090781185;
				if (num != 0)
				{
				}
				num = (short)1997668352;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128.Value;
			}
			set
			{
				short num = (short)364101495;
				short num2 = num;
				num = (short)1607516023;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1785069568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)216137728;
				if (num != 0)
				{
				}
				num = (short)1393295361;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128.Value = value;
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x060015B7 RID: 5559 RVA: 0x0014AD38 File Offset: 0x00148F38
		// (set) Token: 0x060015B8 RID: 5560 RVA: 0x0014ADEC File Offset: 0x00148FEC
		public bool TrkSysTypeIIChannelSetupShuffledBandPlan_A9128_Applicable
		{
			get
			{
				short num = (short)40960001;
				if (num != 0)
				{
				}
				num = (short)755236864;
				short num2 = num;
				num = (short)1985694455;
				short num3 = num;
				num = (short)63195895;
				switch (num3 == num)
				{
				}
				num = (short)755761152;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128.Applicable;
			}
			set
			{
				short num = (short)1126498305;
				if (num != 0)
				{
				}
				num = (short)587071488;
				short num2 = num;
				num = (short)1793580822;
				short num3 = num;
				num = (short)2097078038;
				switch (num3 == num)
				{
				}
				num = (short)205455360;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128.Applicable = value;
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x060015B9 RID: 5561 RVA: 0x0014AEA4 File Offset: 0x001490A4
		// (set) Token: 0x060015BA RID: 5562 RVA: 0x0014AF58 File Offset: 0x00149158
		public bool TrkSysTypeIIChannelSetupShuffledBandPlan_A9128_Valid
		{
			get
			{
				short num = (short)1362894494;
				short num2 = num;
				num = (short)457776798;
				switch (num2 == num)
				{
				default:
				{
					num = (short)516358144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1599143937;
				if (num != 0)
				{
				}
				num = (short)967770112;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128.Valid;
			}
			set
			{
				short num = (short)1550123009;
				if (num != 0)
				{
				}
				num = (short)559284224;
				short num2 = num;
				num = (short)1788413781;
				short num3 = num;
				num = (short)395904853;
				switch (num3 == num)
				{
				}
				num = (short)408944640;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128.Valid = value;
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x060015BB RID: 5563 RVA: 0x0014B00C File Offset: 0x0014920C
		// (set) Token: 0x060015BC RID: 5564 RVA: 0x0014B0C0 File Offset: 0x001492C0
		public bool TrkSysTypeIIChannelSetupShuffledBandPlan_A9128_Visible
		{
			get
			{
				short num = (short)398176535;
				short num2 = num;
				num = (short)1054912791;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1213661184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)227147777;
				if (num != 0)
				{
				}
				num = (short)690225152;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128.Visible;
			}
			set
			{
				short num = (short)92341835;
				short num2 = num;
				num = (short)1767966283;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1411448832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2048131073;
				if (num != 0)
				{
				}
				num = (short)678887424;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128.Visible = value;
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x060015BD RID: 5565 RVA: 0x0014B178 File Offset: 0x00149378
		// (set) Token: 0x060015BE RID: 5566 RVA: 0x0014B22C File Offset: 0x0014942C
		public bool TrkSysTypeIIChannelSetupShuffledBandPlan_A9128_Editable
		{
			get
			{
				short num = (short)702570868;
				short num2 = num;
				num = (short)2138661236;
				switch (num2 == num)
				{
				default:
				{
					num = (short)442499072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1284046848;
				if (num != 0)
				{
				}
				num = (short)1774321665;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128.Editable;
			}
			set
			{
				short num = (short)511526676;
				short num2 = num;
				num = (short)162154260;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1322844160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)702808065;
				if (num != 0)
				{
				}
				num = (short)390201344;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128.Editable = value;
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x060015BF RID: 5567 RVA: 0x0014B2E0 File Offset: 0x001494E0
		internal string TrkSysTypeIIChannelSetupShuffledBandPlan_A9128_UILabel
		{
			get
			{
				short num = (short)375795263;
				short num2 = num;
				num = (short)1456352831;
				switch (num2 == num)
				{
				default:
				{
					num = (short)639434752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)336723969;
				if (num != 0)
				{
				}
				num = (short)1877409792;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128.UIName;
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x060015C0 RID: 5568 RVA: 0x0014B394 File Offset: 0x00149594
		// (set) Token: 0x060015C1 RID: 5569 RVA: 0x0014B44C File Offset: 0x0014964C
		internal bool TrkSysTypeIIChannelSetupShuffledBandPlan_A9128_HiddenStatic
		{
			get
			{
				short num = (short)731171070;
				short num2 = num;
				num = (short)1897187582;
				switch (num2 == num)
				{
				default:
				{
					num = (short)682491904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1859321856;
				if (num != 0)
				{
				}
				num = (short)829685761;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128.HiddenStatic;
			}
			set
			{
				short num = (short)334401992;
				short num2 = num;
				num = (short)1627689416;
				switch (num2 == num)
				{
				default:
				{
					num = (short)264699904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)44564481;
				if (num != 0)
				{
				}
				num = (short)1567031296;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128.HiddenStatic = value;
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x060015C2 RID: 5570 RVA: 0x0014B500 File Offset: 0x00149700
		// (set) Token: 0x060015C3 RID: 5571 RVA: 0x0014B5B4 File Offset: 0x001497B4
		internal bool TrkSysTypeIIChannelSetupShuffledBandPlan_A9128_HiddenDynamic
		{
			get
			{
				short num = (short)1091764225;
				if (num != 0)
				{
				}
				num = (short)38404096;
				short num2 = num;
				num = (short)337587572;
				short num3 = num;
				num = (short)1107176820;
				switch (num3 == num)
				{
				}
				num = (short)1089667072;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128.HiddenDynamic;
			}
			set
			{
				short num = (short)1831889819;
				short num2 = num;
				num = (short)310143899;
				switch (num2 == num)
				{
				default:
				{
					num = (short)683802624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2082078721;
				if (num != 0)
				{
				}
				num = (short)240713728;
				if (num != 0)
				{
				}
				this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128.HiddenDynamic = value;
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x060015C4 RID: 5572 RVA: 0x0014B668 File Offset: 0x00149868
		public bool TrkSysTypeIIChannelSetupShuffledBandPlan_A9128_HasDiffs
		{
			get
			{
				short num = (short)1426522113;
				if (num != 0)
				{
				}
				num = (short)1159266304;
				short num2 = num;
				num = (short)1303962154;
				short num3 = num;
				num = (short)510911018;
				switch (num3 == num)
				{
				}
				num = (short)710213632;
				if (num != 0)
				{
				}
				return this.trkSysTypeIIChannelSetupShuffledBandPlan_A9128._HasDiffs;
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x060015C5 RID: 5573 RVA: 0x0014B71C File Offset: 0x0014991C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation RefRadioInformation
		{
			get
			{
				short num = (short)1065789233;
				short num2 = num;
				num = (short)760391473;
				switch (num2 == num)
				{
				default:
				{
					num = (short)228720640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1203306497;
				if (num != 0)
				{
				}
				num = (short)2022244352;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			}
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x0014B7D8 File Offset: 0x001499D8
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
					num2 = (short)204275713;
					if (num2 != 0)
					{
					}
					num2 = (short)647816695;
					short num3 = num2;
					num2 = (short)760735223;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)200540160;
						if (num2 != 0)
						{
						}
						num2 = (short)640876544;
						short num4 = num2;
						num2 = (short)1816068099;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1957363714;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return result;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1159200769;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)1349320704;
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
			num2 = (short)1165164548;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000858 RID: 2136
		private global::AcpBusinessLayer.AcpListField trkSysTypeIIChannelSetupChannelAssignmentType_A7652;

		// Token: 0x04000859 RID: 2137
		private global::AcpBusinessLayer.AcpListField trkSysTypeIIChannelSetupChannelBandwidthkHz_A7654;

		// Token: 0x0400085A RID: 2138
		private global::AcpBusinessLayer.AcpField<bool> trkSysTypeIIChannelSetupLegacyTransitSystem_A8429;

		// Token: 0x0400085B RID: 2139
		private global::AcpBusinessLayer.AcpListField trkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571;

		// Token: 0x0400085C RID: 2140
		private global::AcpBusinessLayer.AcpField<bool> trkSysTypeIIChannelSetupSplinterChannel_A9175;

		// Token: 0x0400085D RID: 2141
		private global::AcpBusinessLayer.AcpField<bool> trkSysTypeIIChannelSetupShuffledBandPlan_A9128;
	}
}
