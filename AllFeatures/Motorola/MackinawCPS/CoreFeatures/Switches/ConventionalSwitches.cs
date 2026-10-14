using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.MenuItems;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.Switches
{
	// Token: 0x02000294 RID: 660
	[global::System.Serializable]
	public class ConventionalSwitches : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060073C7 RID: 29639 RVA: 0x0068632C File Offset: 0x0068452C
		public ConventionalSwitches(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060073C8 RID: 29640 RVA: 0x00686348 File Offset: 0x00684548
		protected ConventionalSwitches(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060073C9 RID: 29641 RVA: 0x00686360 File Offset: 0x00684560
		public override void Init()
		{
			int a_ = 9;
			short num = (short)955641270;
			short num2 = num;
			num = (short)347729334;
			switch (num2 == num)
			{
			}
			num = (short)667418625;
			if (num != 0)
			{
			}
			num = (short)318636032;
			if (num != 0)
			{
			}
			num = (short)864550912;
			short num3 = num;
			this.switchConventionalSwitchesPosition1_A7734 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchConventionalSwitchesPosition1_A7734LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchConventionalSwitchesPosition1_A7734LovStrs), this, global::AllFeatures.CodeplugGuid.b("駉믋ꟍ꓏뇑볓闕럗듙ꫛ믝軟雡跣觥蛧诩胫뷭蟯鯱胳闵郷鿹迻껽濿焁洃爅愇攉戋㼍伏匑⌓ℕ⬗⸙", a_), global::CommonResources.AcgResources.ID_CONCENTRICSWITCHPOSITIONA, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchConventionalSwitchesPosition1_A7734LovStrs);
			this.switchConventionalSwitchesPosition1_A7734.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.switchConventionalSwitchesPosition1_A7734.DataTransferOrder = 6;
			this.switchConventionalSwitchesPosition2_A7735 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchConventionalSwitchesPosition2_A7735LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchConventionalSwitchesPosition2_A7735LovStrs), this, global::AllFeatures.CodeplugGuid.b("駉믋ꟍ꓏뇑볓闕럗듙ꫛ믝軟雡跣觥蛧诩胫뷭蟯鯱胳闵郷鿹迻껽濿焁洃爅愇攉戋㰍伏匑⌓ℕ⬗⼙", a_), global::CommonResources.AcgResources.ID_CONCENTRICSWITCHPOSITIONB, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchConventionalSwitchesPosition2_A7735LovStrs);
			this.switchConventionalSwitchesPosition2_A7735.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.switchConventionalSwitchesPosition2_A7735.DataTransferOrder = 7;
			this.switchConventionalSwitchesPosition3_A7737 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchConventionalSwitchesPosition3_A7737LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchConventionalSwitchesPosition3_A7737LovStrs), this, global::AllFeatures.CodeplugGuid.b("駉믋ꟍ꓏뇑볓闕럗듙ꫛ믝軟雡跣觥蛧诩胫뷭蟯鯱胳闵郷鿹迻껽濿焁洃爅愇攉戋㴍伏匑⌓ℕ⬗ⴙ", a_), global::CommonResources.AcgResources.ID_TOGGLESWITCHPOSITIONA, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchConventionalSwitchesPosition3_A7737LovStrs);
			this.switchConventionalSwitchesPosition3_A7737.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.switchConventionalSwitchesPosition3_A7737.DataTransferOrder = 8;
			this.switchConventionalSwitchesPosition4_A21530 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchConventionalSwitchesPosition4_A21530LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchConventionalSwitchesPosition4_A21530LovStrs), this, global::AllFeatures.CodeplugGuid.b("駉믋ꟍ꓏뇑볓闕럗듙ꫛ믝軟雡跣觥蛧诩胫뷭蟯鯱胳闵郷鿹迻껽濿焁洃爅愇攉戋㨍伏匑☓✕ⴗ⤙Ⱋ", a_), global::CommonResources.AcgResources.ID_TOGGLESWITCHPOSITIONB, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchConventionalSwitchesPosition4_A21530LovStrs);
			this.switchConventionalSwitchesPosition4_A21530.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.switchConventionalSwitchesPosition4_A21530.DataTransferOrder = 9;
			this.switchConventionalSwitchesPosition5_A21531 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchConventionalSwitchesPosition5_A21531LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchConventionalSwitchesPosition5_A21531LovStrs), this, global::AllFeatures.CodeplugGuid.b("駉믋ꟍ꓏뇑볓闕럗듙ꫛ믝軟雡跣觥蛧诩胫뷭蟯鯱胳闵郷鿹迻껽濿焁洃爅愇攉戋㬍伏匑☓✕ⴗ⤙ⴛ", a_), global::CommonResources.AcgResources.ID_TOGGLESWITCHPOSITIONC, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchConventionalSwitchesPosition5_A21531LovStrs);
			this.switchConventionalSwitchesPosition5_A21531.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.switchConventionalSwitchesPosition5_A21531.DataTransferOrder = 10;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("觉ꏋꃍꛏ럑뫓ꋕ뇗뗙닛뿝賟싡럣釥臧黩迫蛭闯臱", a_);
			base.Id = 10087;
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALSWITCHES;
			base.DataTransferOrder = 3;
		}

		// Token: 0x060073CA RID: 29642 RVA: 0x006865CC File Offset: 0x006847CC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)1276248076;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1F6;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髈볊꓌믎닐믒雔룖럘귚룜뇞闠諢諤触裨蟪뻬飮飰蟲雴鿶鳸裺근郾爀樂焄渆昈攊㼌倎倐␒∔␖Ⱈ", a_)))
					{
						num = (short)56885252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_112;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髈볊꓌믎닐믒雔룖럘귚룜뇞闠諢諤触裨蟪뻬飮飰蟲雴鿶鳸裺근郾爀樂焄渆昈攊㠌倎倐ℒ␔∖⨘⨚", a_)))
					{
						num = (short)191561743;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_501;
				case 3:
					num = (short)630980625;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.switchConventionalSwitchesPosition2_A7735 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchConventionalSwitchesPosition2_A7735LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchConventionalSwitchesPosition2_A7735LovStrs), this, global::AllFeatures.CodeplugGuid.b("髈볊꓌믎닐믒雔룖럘귚룜뇞闠諢諤触裨蟪뻬飮飰蟲雴鿶鳸裺근郾爀樂焄渆昈攊㼌倎倐␒∔␖Ⱈ", a_), global::CommonResources.AcgResources.ID_CONCENTRICSWITCHPOSITIONB, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchConventionalSwitchesPosition2_A7735LovStrs);
					this.switchConventionalSwitchesPosition2_A7735.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.switchConventionalSwitchesPosition2_A7735.DataTransferOrder = 7;
					num = (short)1534918661;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_112;
				case 6:
				{
					num = (short)1747906154;
					short num3 = num;
					num = (short)1774644842;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_422;
					default:
						num = (short)1807417344;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髈볊꓌믎닐믒雔룖럘귚룜뇞闠諢諤触裨蟪뻬飮飰蟲雴鿶鳸裺근郾爀樂焄渆昈攊㸌倎倐␒∔␖⸘", a_)))
						{
							num = (short)1141768205;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9C;
					}
					break;
				}
				case 7:
					goto IL_9C;
				case 8:
				{
					num = (short)1427701760;
					short num4 = num;
					this.switchConventionalSwitchesPosition4_A21530 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchConventionalSwitchesPosition4_A21530LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchConventionalSwitchesPosition4_A21530LovStrs), this, global::AllFeatures.CodeplugGuid.b("髈볊꓌믎닐믒雔룖럘귚룜뇞闠諢諤触裨蟪뻬飮飰蟲雴鿶鳸裺근郾爀樂焄渆昈攊㤌倎倐ℒ␔∖⨘⬚", a_), global::CommonResources.AcgResources.ID_TOGGLESWITCHPOSITIONB, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchConventionalSwitchesPosition4_A21530LovStrs);
					this.switchConventionalSwitchesPosition4_A21530.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.switchConventionalSwitchesPosition4_A21530.DataTransferOrder = 9;
					num = (short)1417543680;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					goto IL_422;
				case 10:
					goto IL_34D;
				case 11:
					this.switchConventionalSwitchesPosition1_A7734 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchConventionalSwitchesPosition1_A7734LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchConventionalSwitchesPosition1_A7734LovStrs), this, global::AllFeatures.CodeplugGuid.b("髈볊꓌믎닐믒雔룖럘귚룜뇞闠諢諤触裨蟪뻬飮飰蟲雴鿶鳸裺근郾爀樂焄渆昈攊㰌倎倐␒∔␖ⴘ", a_), global::CommonResources.AcgResources.ID_CONCENTRICSWITCHPOSITIONA, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchConventionalSwitchesPosition1_A7734LovStrs);
					this.switchConventionalSwitchesPosition1_A7734.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.switchConventionalSwitchesPosition1_A7734.DataTransferOrder = 6;
					num = (short)2116943881;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_79;
					}
					continue;
				case 13:
					this.switchConventionalSwitchesPosition3_A7737 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchConventionalSwitchesPosition3_A7737LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchConventionalSwitchesPosition3_A7737LovStrs), this, global::AllFeatures.CodeplugGuid.b("髈볊꓌믎닐믒雔룖럘귚룜뇞闠諢諤触裨蟪뻬飮飰蟲雴鿶鳸裺근郾爀樂焄渆昈攊㸌倎倐␒∔␖⸘", a_), global::CommonResources.AcgResources.ID_TOGGLESWITCHPOSITIONA, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchConventionalSwitchesPosition3_A7737LovStrs);
					this.switchConventionalSwitchesPosition3_A7737.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.switchConventionalSwitchesPosition3_A7737.DataTransferOrder = 8;
					num = (short)534839303;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					num = (short)674430992;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					this.switchConventionalSwitchesPosition5_A21531 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchConventionalSwitchesPosition5_A21531LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchConventionalSwitchesPosition5_A21531LovStrs), this, global::AllFeatures.CodeplugGuid.b("髈볊꓌믎닐믒雔룖럘귚룜뇞闠諢諤触裨蟪뻬飮飰蟲雴鿶鳸裺근郾爀樂焄渆昈攊㠌倎倐ℒ␔∖⨘⨚", a_), global::CommonResources.AcgResources.ID_TOGGLESWITCHPOSITIONC, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchConventionalSwitchesPosition5_A21531LovStrs);
					this.switchConventionalSwitchesPosition5_A21531.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.switchConventionalSwitchesPosition5_A21531.DataTransferOrder = 10;
					num = (short)2113994762;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (producerFields != null)
					{
						num = (short)1969684483;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_501;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髈볊꓌믎닐믒雔룖럘귚룜뇞闠諢諤触裨蟪뻬飮飰蟲雴鿶鳸裺근郾爀樂焄渆昈攊㰌倎倐␒∔␖ⴘ", a_)))
					{
						num = (short)655491083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_48E;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髈볊꓌믎닐믒雔룖럘귚룜뇞闠諢諤触裨蟪뻬飮飰蟲雴鿶鳸裺근郾爀樂焄渆昈攊㤌倎倐ℒ␔∖⨘⬚", a_)))
					{
						num = (short)2075328520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F6;
				}
				IL_79:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1014169614;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9C:
				num = (short)1786249234;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_112:
				num = (short)36896774;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F6:
				num = (short)1344274434;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_48E:
				num = (short)1849229313;
				if (num != 0)
				{
				}
				num = (short)802488321;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_422:
				goto IL_48E;
			}
			IL_34D:
			IL_501:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諈꓊ꏌ많듐뷒ꇔ뻖뛘뗚볜돞쇠냢鋤軦鷨裪藬諮苰", a_);
			base.Id = 10087;
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALSWITCHES;
			base.DataTransferOrder = 3;
		}

		// Token: 0x060073CB RID: 29643 RVA: 0x00686B0C File Offset: 0x00684D0C
		public override void PopulateReferences()
		{
			short num = (short)872721749;
			short num2 = num;
			num = (short)1874832725;
			switch (num2 == num)
			{
			}
			num = (short)2135097344;
			if (num != 0)
			{
			}
			num = (short)656277505;
			if (num != 0)
			{
			}
			num = (short)1535901696;
			short num3 = num;
		}

		// Token: 0x060073CC RID: 29644 RVA: 0x00686BB8 File Offset: 0x00684DB8
		public override void DropReferences()
		{
			short num = (short)644182597;
			short num2 = num;
			num = (short)1779135045;
			switch (num2 == num)
			{
			}
			num = (short)1904607233;
			if (num != 0)
			{
			}
			num = (short)1241513984;
			if (num != 0)
			{
			}
			num = (short)1816788992;
			short num3 = num;
		}

		// Token: 0x060073CD RID: 29645 RVA: 0x00686C60 File Offset: 0x00684E60
		public override void SetConstraints()
		{
			short num = (short)358607007;
			short num2 = num;
			num = (short)745662623;
			switch (num2 == num)
			{
			}
			num = (short)2010972161;
			if (num != 0)
			{
			}
			num = (short)1628897280;
			if (num != 0)
			{
			}
			num = (short)621543424;
			short num3 = num;
			this.switchConventionalSwitchesPosition1_A7734.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.ConSwitchesCnvPos1);
			this.switchConventionalSwitchesPosition1_A7734.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.ConSyncPosAToSwitchTblAndDriveCnvPosBAndTrkPosAPosB);
			this.switchConventionalSwitchesPosition2_A7735.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.ConSwitchesCnvPos2);
			this.switchConventionalSwitchesPosition2_A7735.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.conSetEditabilityConcentricSwitches);
			this.switchConventionalSwitchesPosition2_A7735.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.ConSyncPositionBInFirstRecCnvSwitches);
			this.switchConventionalSwitchesPosition3_A7737.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.ConSwitchesCnvPos3);
			this.switchConventionalSwitchesPosition3_A7737.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.conSetEditabilityCnvTogglePosA);
			this.switchConventionalSwitchesPosition3_A7737.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.ConSyncPosAToSwitchTblAndCnvPosBCAndTrkPosABC);
			this.switchConventionalSwitchesPosition4_A21530.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.ConSwitchesCnvPos4);
			this.switchConventionalSwitchesPosition4_A21530.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.conSetEditabilityToggleSwitches);
			this.switchConventionalSwitchesPosition4_A21530.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.ConSyncPositionBInFourthRecCnvSwitches);
			this.switchConventionalSwitchesPosition5_A21531.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.ConSwitchesCnvPos5);
			this.switchConventionalSwitchesPosition5_A21531.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.conSetEditabilityToggleSwitches);
			this.switchConventionalSwitchesPosition5_A21531.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.ConSyncPositionCInFourthRecCnvSwitches);
		}

		// Token: 0x060073CE RID: 29646 RVA: 0x00686E50 File Offset: 0x00685050
		public override void SetupDependencies()
		{
			short num = (short)1808915981;
			short num2 = num;
			num = (short)306961933;
			switch (num2 == num)
			{
			}
			num = (short)1170538497;
			if (num != 0)
			{
			}
			num = (short)808255488;
			if (num != 0)
			{
			}
			num = (short)1318060032;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches;
			this.switchConventionalSwitchesPosition2_A7735.AddDependentObject(this.switchConventionalSwitchesPosition1_A7734);
			this.switchConventionalSwitchesPosition3_A7737.AddDependentObject(this.switchConventionalSwitchesPosition1_A7734);
			this.switchConventionalSwitchesPosition4_A21530.AddDependentObject(this.switchConventionalSwitchesPosition1_A7734);
			this.switchConventionalSwitchesPosition5_A21531.AddDependentObject(this.switchConventionalSwitchesPosition1_A7734);
			switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.AddDependentObject(this.switchConventionalSwitchesPosition1_A7734);
			switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.AddDependentObject(this.switchConventionalSwitchesPosition1_A7734);
			this.RefMenuItems.General.DispMenuConventionalSelectedMenuItems_A21736.AddDependentObject(this.switchConventionalSwitchesPosition1_A7734);
			this.RefMenuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.AddDependentObject(this.switchConventionalSwitchesPosition1_A7734);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.AddDependentObject(this.switchConventionalSwitchesPosition1_A7734);
			switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.AddDependentObject(this.switchConventionalSwitchesPosition1_A7734);
			switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.AddDependentObject(this.switchConventionalSwitchesPosition1_A7734);
			switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.AddDependentObject(this.switchConventionalSwitchesPosition1_A7734);
			this.RefRadioWide.Labtool.RadWideLabtoolZoneSelectorOnSwitch_A19550.AddDependentObject(this.switchConventionalSwitchesPosition1_A7734);
			this.RefRadioWide.Labtool.RadWideLabtoolChannelSelectorOnSwitch_A19551.AddDependentObject(this.switchConventionalSwitchesPosition1_A7734);
			this.switchConventionalSwitchesPosition1_A7734.AddDependentObject(this.switchConventionalSwitchesPosition2_A7735);
			this.switchConventionalSwitchesPosition3_A7737.AddDependentObject(this.switchConventionalSwitchesPosition2_A7735);
			this.switchConventionalSwitchesPosition4_A21530.AddDependentObject(this.switchConventionalSwitchesPosition2_A7735);
			this.switchConventionalSwitchesPosition5_A21531.AddDependentObject(this.switchConventionalSwitchesPosition2_A7735);
			switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.AddDependentObject(this.switchConventionalSwitchesPosition2_A7735);
			switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.AddDependentObject(this.switchConventionalSwitchesPosition2_A7735);
			this.RefMenuItems.General.DispMenuConventionalSelectedMenuItems_A21736.AddDependentObject(this.switchConventionalSwitchesPosition2_A7735);
			this.RefMenuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.AddDependentObject(this.switchConventionalSwitchesPosition2_A7735);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.AddDependentObject(this.switchConventionalSwitchesPosition2_A7735);
			this.switchConventionalSwitchesPosition1_A7734.AddDependentObject(this.switchConventionalSwitchesPosition3_A7737);
			this.switchConventionalSwitchesPosition2_A7735.AddDependentObject(this.switchConventionalSwitchesPosition3_A7737);
			this.switchConventionalSwitchesPosition4_A21530.AddDependentObject(this.switchConventionalSwitchesPosition3_A7737);
			this.switchConventionalSwitchesPosition5_A21531.AddDependentObject(this.switchConventionalSwitchesPosition3_A7737);
			switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.AddDependentObject(this.switchConventionalSwitchesPosition3_A7737);
			switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.AddDependentObject(this.switchConventionalSwitchesPosition3_A7737);
			switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.AddDependentObject(this.switchConventionalSwitchesPosition3_A7737);
			this.RefMenuItems.General.DispMenuConventionalSelectedMenuItems_A21736.AddDependentObject(this.switchConventionalSwitchesPosition3_A7737);
			this.RefMenuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.AddDependentObject(this.switchConventionalSwitchesPosition3_A7737);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.AddDependentObject(this.switchConventionalSwitchesPosition3_A7737);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedToggleSwitchLockEnable_43773.AddDependentObject(this.switchConventionalSwitchesPosition3_A7737);
			switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.AddDependentObject(this.switchConventionalSwitchesPosition3_A7737);
			switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.AddDependentObject(this.switchConventionalSwitchesPosition3_A7737);
			this.RefRadioWide.Labtool.RadWideLabtoolZoneSelectorOnSwitch_A19550.AddDependentObject(this.switchConventionalSwitchesPosition3_A7737);
			this.RefRadioWide.Labtool.RadWideLabtoolChannelSelectorOnSwitch_A19551.AddDependentObject(this.switchConventionalSwitchesPosition3_A7737);
			this.switchConventionalSwitchesPosition3_A7737.AddDependentObject(this.switchConventionalSwitchesPosition4_A21530);
			this.switchConventionalSwitchesPosition1_A7734.AddDependentObject(this.switchConventionalSwitchesPosition4_A21530);
			this.switchConventionalSwitchesPosition2_A7735.AddDependentObject(this.switchConventionalSwitchesPosition4_A21530);
			this.switchConventionalSwitchesPosition5_A21531.AddDependentObject(this.switchConventionalSwitchesPosition4_A21530);
			switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.AddDependentObject(this.switchConventionalSwitchesPosition4_A21530);
			switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.AddDependentObject(this.switchConventionalSwitchesPosition4_A21530);
			switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.AddDependentObject(this.switchConventionalSwitchesPosition4_A21530);
			this.RefMenuItems.General.DispMenuConventionalSelectedMenuItems_A21736.AddDependentObject(this.switchConventionalSwitchesPosition4_A21530);
			this.RefMenuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.AddDependentObject(this.switchConventionalSwitchesPosition4_A21530);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.AddDependentObject(this.switchConventionalSwitchesPosition4_A21530);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedToggleSwitchLockEnable_43773.AddDependentObject(this.switchConventionalSwitchesPosition4_A21530);
			this.switchConventionalSwitchesPosition3_A7737.AddDependentObject(this.switchConventionalSwitchesPosition5_A21531);
			this.switchConventionalSwitchesPosition1_A7734.AddDependentObject(this.switchConventionalSwitchesPosition5_A21531);
			this.switchConventionalSwitchesPosition2_A7735.AddDependentObject(this.switchConventionalSwitchesPosition5_A21531);
			this.switchConventionalSwitchesPosition4_A21530.AddDependentObject(this.switchConventionalSwitchesPosition5_A21531);
			switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.AddDependentObject(this.switchConventionalSwitchesPosition5_A21531);
			switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.AddDependentObject(this.switchConventionalSwitchesPosition5_A21531);
			switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.AddDependentObject(this.switchConventionalSwitchesPosition5_A21531);
			this.RefMenuItems.General.DispMenuConventionalSelectedMenuItems_A21736.AddDependentObject(this.switchConventionalSwitchesPosition5_A21531);
			this.RefMenuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.AddDependentObject(this.switchConventionalSwitchesPosition5_A21531);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.AddDependentObject(this.switchConventionalSwitchesPosition5_A21531);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedToggleSwitchLockEnable_43773.AddDependentObject(this.switchConventionalSwitchesPosition5_A21531);
			this.RefRadioWide.Features.RadWideFeaturesNFPACompliant.AddDependentObject(this.switchConventionalSwitchesPosition1_A7734);
			this.RefRadioWide.Features.RadWideFeaturesNFPACompliant.AddDependentObject(this.switchConventionalSwitchesPosition2_A7735);
		}

		// Token: 0x17003BAE RID: 15278
		// (get) Token: 0x060073CF RID: 29647 RVA: 0x006874A8 File Offset: 0x006856A8
		public bool HasDiffs
		{
			get
			{
				short num = (short)1762069670;
				short num2 = num;
				num = (short)1300958374;
				switch (num2 == num)
				{
				}
				num = (short)1031864321;
				if (num != 0)
				{
				}
				num = (short)1930428416;
				if (num != 0)
				{
				}
				num = (short)873594880;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17003BAF RID: 15279
		// (get) Token: 0x060073D0 RID: 29648 RVA: 0x00687558 File Offset: 0x00685758
		// (set) Token: 0x060073D1 RID: 29649 RVA: 0x00687610 File Offset: 0x00685810
		public int SwitchConventionalSwitchesPosition1_A7734Value
		{
			get
			{
				short num = (short)113930092;
				short num2 = num;
				num = (short)1454141292;
				switch (num2 == num)
				{
				}
				num = (short)1513619457;
				if (num != 0)
				{
				}
				num = (short)1604976640;
				if (num != 0)
				{
				}
				num = (short)621477888;
				short num3 = num;
				return this.switchConventionalSwitchesPosition1_A7734.Value;
			}
			set
			{
				short num = (short)1022899012;
				short num2 = num;
				num = (short)1942827844;
				switch (num2 == num)
				{
				}
				num = (short)765853697;
				if (num != 0)
				{
				}
				num = (short)248774656;
				if (num != 0)
				{
				}
				num = (short)1119879168;
				short num3 = num;
				this.switchConventionalSwitchesPosition1_A7734.Value = value;
			}
		}

		// Token: 0x17003BB0 RID: 15280
		// (get) Token: 0x060073D2 RID: 29650 RVA: 0x006876C8 File Offset: 0x006858C8
		// (set) Token: 0x060073D3 RID: 29651 RVA: 0x0068777C File Offset: 0x0068597C
		public string SwitchConventionalSwitchesPosition1_A7734_UIValue
		{
			get
			{
				short num = (short)90155512;
				short num2 = num;
				num = (short)579971576;
				switch (num2 == num)
				{
				}
				num = (short)749993984;
				if (num != 0)
				{
				}
				num = (short)1933770753;
				if (num != 0)
				{
				}
				num = (short)1884356608;
				short num3 = num;
				return this.switchConventionalSwitchesPosition1_A7734.UIValue;
			}
			set
			{
				short num = (short)258850973;
				short num2 = num;
				num = (short)54116509;
				switch (num2 == num)
				{
				}
				num = (short)254803969;
				if (num != 0)
				{
				}
				num = (short)1648230400;
				if (num != 0)
				{
				}
				num = (short)1657012224;
				short num3 = num;
				this.switchConventionalSwitchesPosition1_A7734.UIValue = value;
			}
		}

		// Token: 0x17003BB1 RID: 15281
		// (get) Token: 0x060073D4 RID: 29652 RVA: 0x00687834 File Offset: 0x00685A34
		public global::AcpBusinessLayer.AcpListField SwitchConventionalSwitchesPosition1_A7734
		{
			get
			{
				short num = (short)1373437724;
				short num2 = num;
				num = (short)1454898972;
				switch (num2 == num)
				{
				}
				num = (short)1719140353;
				if (num != 0)
				{
				}
				num = (short)56033280;
				if (num != 0)
				{
				}
				num = (short)439877632;
				short num3 = num;
				return this.switchConventionalSwitchesPosition1_A7734;
			}
		}

		// Token: 0x17003BB2 RID: 15282
		// (get) Token: 0x060073D5 RID: 29653 RVA: 0x006878E4 File Offset: 0x00685AE4
		// (set) Token: 0x060073D6 RID: 29654 RVA: 0x00687998 File Offset: 0x00685B98
		public bool SwitchConventionalSwitchesPosition1_A7734_Applicable
		{
			get
			{
				short num = (short)1285645487;
				short num2 = num;
				num = (short)570713263;
				switch (num2 == num)
				{
				}
				num = (short)596901888;
				if (num != 0)
				{
				}
				num = (short)561643521;
				if (num != 0)
				{
				}
				num = (short)106692608;
				short num3 = num;
				return this.switchConventionalSwitchesPosition1_A7734.Applicable;
			}
			set
			{
				short num = (short)1450919109;
				short num2 = num;
				num = (short)1041122501;
				switch (num2 == num)
				{
				}
				num = (short)242221056;
				if (num != 0)
				{
				}
				num = (short)1496055809;
				if (num != 0)
				{
				}
				num = (short)1757741056;
				short num3 = num;
				this.switchConventionalSwitchesPosition1_A7734.Applicable = value;
			}
		}

		// Token: 0x17003BB3 RID: 15283
		// (get) Token: 0x060073D7 RID: 29655 RVA: 0x00687A4C File Offset: 0x00685C4C
		// (set) Token: 0x060073D8 RID: 29656 RVA: 0x00687B00 File Offset: 0x00685D00
		public bool SwitchConventionalSwitchesPosition1_A7734_Valid
		{
			get
			{
				short num = (short)1447307635;
				short num2 = num;
				num = (short)1866344819;
				switch (num2 == num)
				{
				}
				num = (short)2138439681;
				if (num != 0)
				{
				}
				num = (short)1952710656;
				if (num != 0)
				{
				}
				num = (short)1120600064;
				short num3 = num;
				return this.switchConventionalSwitchesPosition1_A7734.Valid;
			}
			set
			{
				short num = (short)1879158889;
				short num2 = num;
				num = (short)805154921;
				switch (num2 == num)
				{
				}
				num = (short)553189377;
				if (num != 0)
				{
				}
				num = (short)1255604224;
				if (num != 0)
				{
				}
				num = (short)2084306944;
				short num3 = num;
				this.switchConventionalSwitchesPosition1_A7734.Valid = value;
			}
		}

		// Token: 0x17003BB4 RID: 15284
		// (get) Token: 0x060073D9 RID: 29657 RVA: 0x00687BB4 File Offset: 0x00685DB4
		// (set) Token: 0x060073DA RID: 29658 RVA: 0x00687C68 File Offset: 0x00685E68
		public bool SwitchConventionalSwitchesPosition1_A7734_Visible
		{
			get
			{
				short num = (short)1991597308;
				short num2 = num;
				num = (short)712465660;
				switch (num2 == num)
				{
				}
				num = (short)1037238272;
				if (num != 0)
				{
				}
				num = (short)2077491201;
				if (num != 0)
				{
				}
				num = (short)987693056;
				short num3 = num;
				return this.switchConventionalSwitchesPosition1_A7734.Visible;
			}
			set
			{
				short num = (short)927795332;
				short num2 = num;
				num = (short)1339230340;
				switch (num2 == num)
				{
				}
				num = (short)1180172289;
				if (num != 0)
				{
				}
				num = (short)1330249728;
				if (num != 0)
				{
				}
				num = (short)441122816;
				short num3 = num;
				this.switchConventionalSwitchesPosition1_A7734.Visible = value;
			}
		}

		// Token: 0x17003BB5 RID: 15285
		// (get) Token: 0x060073DB RID: 29659 RVA: 0x00687D1C File Offset: 0x00685F1C
		// (set) Token: 0x060073DC RID: 29660 RVA: 0x00687DD0 File Offset: 0x00685FD0
		public bool SwitchConventionalSwitchesPosition1_A7734_Editable
		{
			get
			{
				short num = (short)2101430789;
				short num2 = num;
				num = (short)125061637;
				switch (num2 == num)
				{
				}
				num = (short)660930561;
				if (num != 0)
				{
				}
				num = (short)910229504;
				if (num != 0)
				{
				}
				num = (short)643563520;
				short num3 = num;
				return this.switchConventionalSwitchesPosition1_A7734.Editable;
			}
			set
			{
				short num = (short)857267761;
				short num2 = num;
				num = (short)2134957617;
				switch (num2 == num)
				{
				}
				num = (short)1993801728;
				short num3 = num;
				num = (short)533004288;
				if (num != 0)
				{
				}
				num = (short)677117953;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition1_A7734.Editable = value;
			}
		}

		// Token: 0x17003BB6 RID: 15286
		// (get) Token: 0x060073DD RID: 29661 RVA: 0x00687E88 File Offset: 0x00686088
		internal string SwitchConventionalSwitchesPosition1_A7734_UILabel
		{
			get
			{
				short num = (short)1718541830;
				short num2 = num;
				num = (short)546496006;
				switch (num2 == num)
				{
				}
				num = (short)325320704;
				short num3 = num;
				num = (short)1430978561;
				if (num != 0)
				{
				}
				num = (short)1964834816;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition1_A7734.UIName;
			}
		}

		// Token: 0x17003BB7 RID: 15287
		// (get) Token: 0x060073DE RID: 29662 RVA: 0x00687F40 File Offset: 0x00686140
		// (set) Token: 0x060073DF RID: 29663 RVA: 0x00687FF4 File Offset: 0x006861F4
		internal bool SwitchConventionalSwitchesPosition1_A7734_HiddenStatic
		{
			get
			{
				short num = (short)702742529;
				if (num != 0)
				{
				}
				num = (short)759072156;
				short num2 = num;
				num = (short)1311671708;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1558380544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)3276800;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition1_A7734.HiddenStatic;
			}
			set
			{
				short num = (short)1605828609;
				if (num != 0)
				{
				}
				num = (short)1017619510;
				short num2 = num;
				num = (short)894870582;
				switch (num2 == num)
				{
				default:
				{
					num = (short)227147776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1736179712;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition1_A7734.HiddenStatic = value;
			}
		}

		// Token: 0x17003BB8 RID: 15288
		// (get) Token: 0x060073E0 RID: 29664 RVA: 0x006880AC File Offset: 0x006862AC
		// (set) Token: 0x060073E1 RID: 29665 RVA: 0x00688160 File Offset: 0x00686360
		internal bool SwitchConventionalSwitchesPosition1_A7734_HiddenDynamic
		{
			get
			{
				short num = (short)940752035;
				short num2 = num;
				num = (short)1185660067;
				switch (num2 == num)
				{
				}
				num = (short)1719992320;
				short num3 = num;
				num = (short)619446273;
				if (num != 0)
				{
				}
				num = (short)42729472;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition1_A7734.HiddenDynamic;
			}
			set
			{
				short num = (short)1294901730;
				short num2 = num;
				num = (short)1906942434;
				switch (num2 == num)
				{
				}
				num = (short)895483904;
				short num3 = num;
				num = (short)758448129;
				if (num != 0)
				{
				}
				num = (short)272039936;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition1_A7734.HiddenDynamic = value;
			}
		}

		// Token: 0x17003BB9 RID: 15289
		// (get) Token: 0x060073E2 RID: 29666 RVA: 0x00688214 File Offset: 0x00686414
		public bool SwitchConventionalSwitchesPosition1_A7734_HasDiffs
		{
			get
			{
				short num = (short)347475972;
				short num2 = num;
				num = (short)1736642564;
				switch (num2 == num)
				{
				}
				num = (short)1268187136;
				short num3 = num;
				num = (short)522059777;
				if (num != 0)
				{
				}
				num = (short)164757504;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition1_A7734._HasDiffs;
			}
		}

		// Token: 0x17003BBA RID: 15290
		// (get) Token: 0x060073E3 RID: 29667 RVA: 0x006882C8 File Offset: 0x006864C8
		// (set) Token: 0x060073E4 RID: 29668 RVA: 0x0068837C File Offset: 0x0068657C
		public int SwitchConventionalSwitchesPosition2_A7735Value
		{
			get
			{
				short num = (short)510023129;
				short num2 = num;
				num = (short)52712921;
				switch (num2 == num)
				{
				}
				num = (short)282001408;
				short num3 = num;
				num = (short)1093468161;
				if (num != 0)
				{
				}
				num = (short)298647552;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition2_A7735.Value;
			}
			set
			{
				short num = (short)1153656507;
				short num2 = num;
				num = (short)1219126971;
				switch (num2 == num)
				{
				}
				num = (short)510328832;
				short num3 = num;
				num = (short)1869152257;
				if (num != 0)
				{
				}
				num = (short)1577254912;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition2_A7735.Value = value;
			}
		}

		// Token: 0x17003BBB RID: 15291
		// (get) Token: 0x060073E5 RID: 29669 RVA: 0x00688430 File Offset: 0x00686630
		// (set) Token: 0x060073E6 RID: 29670 RVA: 0x006884E8 File Offset: 0x006866E8
		public string SwitchConventionalSwitchesPosition2_A7735_UIValue
		{
			get
			{
				short num = (short)362610689;
				if (num != 0)
				{
				}
				num = (short)1960044989;
				short num2 = num;
				num = (short)1196943805;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1581252608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)752484352;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition2_A7735.UIValue;
			}
			set
			{
				short num = (short)791347201;
				if (num != 0)
				{
				}
				num = (short)1918721902;
				short num2 = num;
				num = (short)559243118;
				switch (num2 == num)
				{
				default:
				{
					num = (short)12058624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1470103552;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition2_A7735.UIValue = value;
			}
		}

		// Token: 0x17003BBC RID: 15292
		// (get) Token: 0x060073E7 RID: 29671 RVA: 0x006885A0 File Offset: 0x006867A0
		public global::AcpBusinessLayer.AcpListField SwitchConventionalSwitchesPosition2_A7735
		{
			get
			{
				short num = (short)1593678190;
				short num2 = num;
				num = (short)21797230;
				switch (num2 == num)
				{
				}
				num = (short)1521942528;
				short num3 = num;
				num = (short)2050883585;
				if (num != 0)
				{
				}
				num = (short)1600126976;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition2_A7735;
			}
		}

		// Token: 0x17003BBD RID: 15293
		// (get) Token: 0x060073E8 RID: 29672 RVA: 0x0068864C File Offset: 0x0068684C
		// (set) Token: 0x060073E9 RID: 29673 RVA: 0x00688700 File Offset: 0x00686900
		public bool SwitchConventionalSwitchesPosition2_A7735_Applicable
		{
			get
			{
				short num = (short)526329385;
				short num2 = num;
				num = (short)1295787561;
				switch (num2 == num)
				{
				}
				num = (short)445448192;
				short num3 = num;
				num = (short)1592131585;
				if (num != 0)
				{
				}
				num = (short)330170368;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition2_A7735.Applicable;
			}
			set
			{
				short num = (short)1002399185;
				short num2 = num;
				num = (short)747267537;
				switch (num2 == num)
				{
				}
				num = (short)660799488;
				short num3 = num;
				num = (short)164429825;
				if (num != 0)
				{
				}
				num = (short)479068160;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition2_A7735.Applicable = value;
			}
		}

		// Token: 0x17003BBE RID: 15294
		// (get) Token: 0x060073EA RID: 29674 RVA: 0x006887B4 File Offset: 0x006869B4
		// (set) Token: 0x060073EB RID: 29675 RVA: 0x00688868 File Offset: 0x00686A68
		public bool SwitchConventionalSwitchesPosition2_A7735_Valid
		{
			get
			{
				short num = (short)1021417708;
				short num2 = num;
				num = (short)2089457900;
				switch (num2 == num)
				{
				}
				num = (short)1034158080;
				short num3 = num;
				num = (short)784596993;
				if (num != 0)
				{
				}
				num = (short)562954240;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition2_A7735.Valid;
			}
			set
			{
				short num = (short)11207627;
				short num2 = num;
				num = (short)987038667;
				switch (num2 == num)
				{
				}
				num = (short)1586364416;
				short num3 = num;
				num = (short)1103429632;
				if (num != 0)
				{
				}
				num = (short)99876865;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition2_A7735.Valid = value;
			}
		}

		// Token: 0x17003BBF RID: 15295
		// (get) Token: 0x060073EC RID: 29676 RVA: 0x00688920 File Offset: 0x00686B20
		// (set) Token: 0x060073ED RID: 29677 RVA: 0x006889D4 File Offset: 0x00686BD4
		public bool SwitchConventionalSwitchesPosition2_A7735_Visible
		{
			get
			{
				short num = (short)1525244511;
				short num2 = num;
				num = (short)324690527;
				switch (num2 == num)
				{
				}
				num = (short)1294532608;
				short num3 = num;
				num = (short)1684275201;
				if (num != 0)
				{
				}
				num = (short)1052377088;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition2_A7735.Visible;
			}
			set
			{
				short num = (short)1984105608;
				short num2 = num;
				num = (short)473173128;
				switch (num2 == num)
				{
				}
				num = (short)775946240;
				short num3 = num;
				num = (short)734396417;
				if (num != 0)
				{
				}
				num = (short)2097676288;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition2_A7735.Visible = value;
			}
		}

		// Token: 0x17003BC0 RID: 15296
		// (get) Token: 0x060073EE RID: 29678 RVA: 0x00688A88 File Offset: 0x00686C88
		// (set) Token: 0x060073EF RID: 29679 RVA: 0x00688B3C File Offset: 0x00686D3C
		public bool SwitchConventionalSwitchesPosition2_A7735_Editable
		{
			get
			{
				short num = (short)471004491;
				short num2 = num;
				num = (short)108655947;
				switch (num2 == num)
				{
				}
				num = (short)1232863232;
				short num3 = num;
				num = (short)1667235841;
				if (num != 0)
				{
				}
				num = (short)810614784;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition2_A7735.Editable;
			}
			set
			{
				short num = (short)184089057;
				short num2 = num;
				num = (short)2118515169;
				switch (num2 == num)
				{
				}
				num = (short)1966211072;
				short num3 = num;
				num = (short)2113536001;
				if (num != 0)
				{
				}
				num = (short)1939734528;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition2_A7735.Editable = value;
			}
		}

		// Token: 0x17003BC1 RID: 15297
		// (get) Token: 0x060073F0 RID: 29680 RVA: 0x00688BF0 File Offset: 0x00686DF0
		internal string SwitchConventionalSwitchesPosition2_A7735_UILabel
		{
			get
			{
				short num = (short)468284668;
				short num2 = num;
				num = (short)2117432572;
				switch (num2 == num)
				{
				}
				num = (short)851705856;
				short num3 = num;
				num = (short)876675073;
				if (num != 0)
				{
				}
				num = (short)1243348992;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition2_A7735.UIName;
			}
		}

		// Token: 0x17003BC2 RID: 15298
		// (get) Token: 0x060073F1 RID: 29681 RVA: 0x00688CA4 File Offset: 0x00686EA4
		// (set) Token: 0x060073F2 RID: 29682 RVA: 0x00688D58 File Offset: 0x00686F58
		internal bool SwitchConventionalSwitchesPosition2_A7735_HiddenStatic
		{
			get
			{
				short num = (short)1415249921;
				if (num != 0)
				{
				}
				num = (short)446982501;
				short num2 = num;
				num = (short)1175087461;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1519386624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1794441216;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition2_A7735.HiddenStatic;
			}
			set
			{
				short num = (short)415083690;
				short num2 = num;
				num = (short)1569959082;
				switch (num2 == num)
				{
				}
				num = (short)1864499200;
				short num3 = num;
				num = (short)1998913537;
				if (num != 0)
				{
				}
				num = (short)2089811968;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition2_A7735.HiddenStatic = value;
			}
		}

		// Token: 0x17003BC3 RID: 15299
		// (get) Token: 0x060073F3 RID: 29683 RVA: 0x00688E0C File Offset: 0x0068700C
		// (set) Token: 0x060073F4 RID: 29684 RVA: 0x00688EC4 File Offset: 0x006870C4
		internal bool SwitchConventionalSwitchesPosition2_A7735_HiddenDynamic
		{
			get
			{
				short num = (short)1968587152;
				short num2 = num;
				num = (short)342835600;
				switch (num2 == num)
				{
				}
				num = (short)1357512704;
				short num3 = num;
				num = (short)2129002497;
				if (num != 0)
				{
				}
				num = (short)1848573952;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition2_A7735.HiddenDynamic;
			}
			set
			{
				short num = (short)566605311;
				short num2 = num;
				num = (short)319665663;
				switch (num2 == num)
				{
				}
				num = (short)610336768;
				short num3 = num;
				num = (short)2119696385;
				if (num != 0)
				{
				}
				num = (short)577568768;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition2_A7735.HiddenDynamic = value;
			}
		}

		// Token: 0x17003BC4 RID: 15300
		// (get) Token: 0x060073F5 RID: 29685 RVA: 0x00688F7C File Offset: 0x0068717C
		public bool SwitchConventionalSwitchesPosition2_A7735_HasDiffs
		{
			get
			{
				short num = (short)895506936;
				short num2 = num;
				num = (short)170678776;
				switch (num2 == num)
				{
				}
				num = (short)413597696;
				short num3 = num;
				num = (short)88276993;
				if (num != 0)
				{
				}
				num = (short)1559232512;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition2_A7735._HasDiffs;
			}
		}

		// Token: 0x17003BC5 RID: 15301
		// (get) Token: 0x060073F6 RID: 29686 RVA: 0x00689034 File Offset: 0x00687234
		// (set) Token: 0x060073F7 RID: 29687 RVA: 0x006890E8 File Offset: 0x006872E8
		public int SwitchConventionalSwitchesPosition3_A7737Value
		{
			get
			{
				short num = (short)1493765818;
				short num2 = num;
				num = (short)1107693242;
				switch (num2 == num)
				{
				}
				num = (short)121110528;
				short num3 = num;
				num = (short)2083848193;
				if (num != 0)
				{
				}
				num = (short)414056448;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition3_A7737.Value;
			}
			set
			{
				short num = (short)1589630349;
				short num2 = num;
				num = (short)33740173;
				switch (num2 == num)
				{
				}
				num = (short)592117760;
				short num3 = num;
				num = (short)954859521;
				if (num != 0)
				{
				}
				num = (short)1497628672;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition3_A7737.Value = value;
			}
		}

		// Token: 0x17003BC6 RID: 15302
		// (get) Token: 0x060073F8 RID: 29688 RVA: 0x0068919C File Offset: 0x0068739C
		// (set) Token: 0x060073F9 RID: 29689 RVA: 0x00689250 File Offset: 0x00687450
		public string SwitchConventionalSwitchesPosition3_A7737_UIValue
		{
			get
			{
				short num = (short)412707719;
				short num2 = num;
				num = (short)1312975751;
				switch (num2 == num)
				{
				}
				num = (short)583991296;
				short num3 = num;
				num = (short)75366401;
				if (num != 0)
				{
				}
				num = (short)350945280;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition3_A7737.UIValue;
			}
			set
			{
				short num = (short)2024748868;
				short num2 = num;
				num = (short)1583429444;
				switch (num2 == num)
				{
				}
				num = (short)2035220480;
				short num3 = num;
				num = (short)2029191169;
				if (num != 0)
				{
				}
				num = (short)406192128;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition3_A7737.UIValue = value;
			}
		}

		// Token: 0x17003BC7 RID: 15303
		// (get) Token: 0x060073FA RID: 29690 RVA: 0x00689308 File Offset: 0x00687508
		public global::AcpBusinessLayer.AcpListField SwitchConventionalSwitchesPosition3_A7737
		{
			get
			{
				short num = (short)2090359783;
				short num2 = num;
				num = (short)423713767;
				switch (num2 == num)
				{
				}
				num = (short)367067136;
				short num3 = num;
				num = (short)264896512;
				if (num != 0)
				{
				}
				num = (short)2110980097;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition3_A7737;
			}
		}

		// Token: 0x17003BC8 RID: 15304
		// (get) Token: 0x060073FB RID: 29691 RVA: 0x006893B8 File Offset: 0x006875B8
		// (set) Token: 0x060073FC RID: 29692 RVA: 0x00689470 File Offset: 0x00687670
		public bool SwitchConventionalSwitchesPosition3_A7737_Applicable
		{
			get
			{
				short num = (short)213433186;
				short num2 = num;
				num = (short)152484706;
				switch (num2 == num)
				{
				}
				num = (short)2064121856;
				short num3 = num;
				num = (short)2076770305;
				if (num != 0)
				{
				}
				num = (short)1077149696;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition3_A7737.Applicable;
			}
			set
			{
				short num = (short)257299084;
				short num2 = num;
				num = (short)2118390412;
				switch (num2 == num)
				{
				}
				num = (short)2049245184;
				short num3 = num;
				num = (short)183173121;
				if (num != 0)
				{
				}
				num = (short)805240832;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition3_A7737.Applicable = value;
			}
		}

		// Token: 0x17003BC9 RID: 15305
		// (get) Token: 0x060073FD RID: 29693 RVA: 0x00689524 File Offset: 0x00687724
		// (set) Token: 0x060073FE RID: 29694 RVA: 0x006895D8 File Offset: 0x006877D8
		public bool SwitchConventionalSwitchesPosition3_A7737_Valid
		{
			get
			{
				short num = (short)1020773270;
				short num2 = num;
				num = (short)952157078;
				switch (num2 == num)
				{
				}
				num = (short)678363136;
				short num3 = num;
				num = (short)1937375232;
				if (num != 0)
				{
				}
				num = (short)754778113;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition3_A7737.Valid;
			}
			set
			{
				short num = (short)981786347;
				short num2 = num;
				num = (short)1819598571;
				switch (num2 == num)
				{
				}
				num = (short)398196736;
				short num3 = num;
				num = (short)887750657;
				if (num != 0)
				{
				}
				num = (short)2144010240;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition3_A7737.Valid = value;
			}
		}

		// Token: 0x17003BCA RID: 15306
		// (get) Token: 0x060073FF RID: 29695 RVA: 0x0068968C File Offset: 0x0068788C
		// (set) Token: 0x06007400 RID: 29696 RVA: 0x00689740 File Offset: 0x00687940
		public bool SwitchConventionalSwitchesPosition3_A7737_Visible
		{
			get
			{
				short num = (short)1073469153;
				short num2 = num;
				num = (short)763811553;
				switch (num2 == num)
				{
				}
				num = (short)1066860544;
				short num3 = num;
				num = (short)1355939841;
				if (num != 0)
				{
				}
				num = (short)1247412224;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition3_A7737.Visible;
			}
			set
			{
				short num = (short)503539737;
				short num2 = num;
				num = (short)446130201;
				switch (num2 == num)
				{
				}
				num = (short)900595712;
				short num3 = num;
				num = (short)295632897;
				if (num != 0)
				{
				}
				num = (short)892534784;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition3_A7737.Visible = value;
			}
		}

		// Token: 0x17003BCB RID: 15307
		// (get) Token: 0x06007401 RID: 29697 RVA: 0x006897F4 File Offset: 0x006879F4
		// (set) Token: 0x06007402 RID: 29698 RVA: 0x006898A8 File Offset: 0x00687AA8
		public bool SwitchConventionalSwitchesPosition3_A7737_Editable
		{
			get
			{
				short num = (short)305613364;
				short num2 = num;
				num = (short)435505716;
				switch (num2 == num)
				{
				}
				num = (short)880803840;
				short num3 = num;
				num = (short)610992128;
				if (num != 0)
				{
				}
				num = (short)1867579393;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition3_A7737.Editable;
			}
			set
			{
				short num = (short)1749414066;
				short num2 = num;
				num = (short)1495920818;
				switch (num2 == num)
				{
				}
				num = (short)65208320;
				short num3 = num;
				num = (short)486014977;
				if (num != 0)
				{
				}
				num = (short)1828519936;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition3_A7737.Editable = value;
			}
		}

		// Token: 0x17003BCC RID: 15308
		// (get) Token: 0x06007403 RID: 29699 RVA: 0x0068995C File Offset: 0x00687B5C
		internal string SwitchConventionalSwitchesPosition3_A7737_UILabel
		{
			get
			{
				short num = (short)1194131457;
				if (num != 0)
				{
				}
				num = (short)392876131;
				short num2 = num;
				num = (short)478662755;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1338572800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)6488064;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition3_A7737.UIName;
			}
		}

		// Token: 0x17003BCD RID: 15309
		// (get) Token: 0x06007404 RID: 29700 RVA: 0x00689A14 File Offset: 0x00687C14
		// (set) Token: 0x06007405 RID: 29701 RVA: 0x00689AC8 File Offset: 0x00687CC8
		internal bool SwitchConventionalSwitchesPosition3_A7737_HiddenStatic
		{
			get
			{
				short num = (short)708368539;
				short num2 = num;
				num = (short)460773531;
				switch (num2 == num)
				{
				}
				num = (short)2017918976;
				short num3 = num;
				num = (short)1828192256;
				if (num != 0)
				{
				}
				num = (short)1294991361;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition3_A7737.HiddenStatic;
			}
			set
			{
				short num = (short)2089977908;
				short num2 = num;
				num = (short)879659060;
				switch (num2 == num)
				{
				}
				num = (short)708313088;
				short num3 = num;
				num = (short)952565760;
				if (num != 0)
				{
				}
				num = (short)603062273;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition3_A7737.HiddenStatic = value;
			}
		}

		// Token: 0x17003BCE RID: 15310
		// (get) Token: 0x06007406 RID: 29702 RVA: 0x00689B80 File Offset: 0x00687D80
		// (set) Token: 0x06007407 RID: 29703 RVA: 0x00689C30 File Offset: 0x00687E30
		internal bool SwitchConventionalSwitchesPosition3_A7737_HiddenDynamic
		{
			get
			{
				short num = (short)468362731;
				short num2 = num;
				num = (short)1908254187;
				switch (num2 == num)
				{
				}
				num = (short)109445120;
				short num3 = num;
				num = (short)2102591488;
				if (num != 0)
				{
				}
				num = (short)1974140929;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition3_A7737.HiddenDynamic;
			}
			set
			{
				short num = (short)251265025;
				if (num != 0)
				{
				}
				num = (short)111183278;
				short num2 = num;
				num = (short)600475054;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1913716736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1069481984;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition3_A7737.HiddenDynamic = value;
			}
		}

		// Token: 0x17003BCF RID: 15311
		// (get) Token: 0x06007408 RID: 29704 RVA: 0x00689CE8 File Offset: 0x00687EE8
		public bool SwitchConventionalSwitchesPosition3_A7737_HasDiffs
		{
			get
			{
				short num = (short)104256470;
				short num2 = num;
				num = (short)1276040150;
				switch (num2 == num)
				{
				}
				num = (short)349831168;
				short num3 = num;
				num = (short)1954152449;
				if (num != 0)
				{
				}
				num = (short)750714880;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition3_A7737._HasDiffs;
			}
		}

		// Token: 0x17003BD0 RID: 15312
		// (get) Token: 0x06007409 RID: 29705 RVA: 0x00689D9C File Offset: 0x00687F9C
		// (set) Token: 0x0600740A RID: 29706 RVA: 0x00689E50 File Offset: 0x00688050
		public int SwitchConventionalSwitchesPosition4_A21530Value
		{
			get
			{
				short num = (short)1811157130;
				short num2 = num;
				num = (short)657199242;
				switch (num2 == num)
				{
				}
				num = (short)982253568;
				short num3 = num;
				num = (short)863043585;
				if (num != 0)
				{
				}
				num = (short)1095696384;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition4_A21530.Value;
			}
			set
			{
				short num = (short)1272315905;
				if (num != 0)
				{
				}
				num = (short)1872468595;
				short num2 = num;
				num = (short)692558451;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2056912896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)191561728;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition4_A21530.Value = value;
			}
		}

		// Token: 0x17003BD1 RID: 15313
		// (get) Token: 0x0600740B RID: 29707 RVA: 0x00689F08 File Offset: 0x00688108
		// (set) Token: 0x0600740C RID: 29708 RVA: 0x00689FBC File Offset: 0x006881BC
		public string SwitchConventionalSwitchesPosition4_A21530_UIValue
		{
			get
			{
				short num = (short)1549533185;
				if (num != 0)
				{
				}
				num = (short)1986697546;
				short num2 = num;
				num = (short)1407162698;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1497038848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)876216320;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition4_A21530.UIValue;
			}
			set
			{
				short num = (short)1366608835;
				short num2 = num;
				num = (short)2030685123;
				switch (num2 == num)
				{
				}
				num = (short)1061224448;
				short num3 = num;
				num = (short)1281032193;
				if (num != 0)
				{
				}
				num = (short)606076928;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition4_A21530.UIValue = value;
			}
		}

		// Token: 0x17003BD2 RID: 15314
		// (get) Token: 0x0600740D RID: 29709 RVA: 0x0068A070 File Offset: 0x00688270
		public global::AcpBusinessLayer.AcpListField SwitchConventionalSwitchesPosition4_A21530
		{
			get
			{
				short num = (short)1265696769;
				if (num != 0)
				{
				}
				num = (short)705183994;
				short num2 = num;
				num = (short)2056929530;
				switch (num2 == num)
				{
				}
				num = (short)1739325440;
				short num3 = num;
				num = (short)1953366016;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition4_A21530;
			}
		}

		// Token: 0x17003BD3 RID: 15315
		// (get) Token: 0x0600740E RID: 29710 RVA: 0x0068A11C File Offset: 0x0068831C
		// (set) Token: 0x0600740F RID: 29711 RVA: 0x0068A1D4 File Offset: 0x006883D4
		public bool SwitchConventionalSwitchesPosition4_A21530_Applicable
		{
			get
			{
				short num = (short)756270867;
				short num2 = num;
				num = (short)1903871763;
				switch (num2 == num)
				{
				}
				num = (short)973733889;
				if (num != 0)
				{
				}
				num = (short)1661861888;
				short num3 = num;
				num = (short)1476263936;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition4_A21530.Applicable;
			}
			set
			{
				short num = (short)929890305;
				if (num != 0)
				{
				}
				num = (short)1036166113;
				short num2 = num;
				num = (short)2146083809;
				switch (num2 == num)
				{
				}
				num = (short)399179776;
				short num3 = num;
				num = (short)478412800;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition4_A21530.Applicable = value;
			}
		}

		// Token: 0x17003BD4 RID: 15316
		// (get) Token: 0x06007410 RID: 29712 RVA: 0x0068A28C File Offset: 0x0068848C
		// (set) Token: 0x06007411 RID: 29713 RVA: 0x0068A340 File Offset: 0x00688540
		public bool SwitchConventionalSwitchesPosition4_A21530_Valid
		{
			get
			{
				short num = (short)1842571184;
				short num2 = num;
				num = (short)1214015408;
				switch (num2 == num)
				{
				}
				num = (short)680263681;
				if (num != 0)
				{
				}
				num = (short)1140326400;
				short num3 = num;
				num = (short)401932288;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition4_A21530.Valid;
			}
			set
			{
				short num = (short)1142558370;
				short num2 = num;
				num = (short)809045666;
				switch (num2 == num)
				{
				}
				num = (short)1224933376;
				if (num != 0)
				{
				}
				num = (short)542441472;
				short num3 = num;
				num = (short)238747649;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition4_A21530.Valid = value;
			}
		}

		// Token: 0x17003BD5 RID: 15317
		// (get) Token: 0x06007412 RID: 29714 RVA: 0x0068A3F8 File Offset: 0x006885F8
		// (set) Token: 0x06007413 RID: 29715 RVA: 0x0068A4AC File Offset: 0x006886AC
		public bool SwitchConventionalSwitchesPosition4_A21530_Visible
		{
			get
			{
				short num = (short)491246856;
				short num2 = num;
				num = (short)129684744;
				switch (num2 == num)
				{
				}
				num = (short)1591214081;
				if (num != 0)
				{
				}
				num = (short)1197080576;
				short num3 = num;
				num = (short)1166934016;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition4_A21530.Visible;
			}
			set
			{
				short num = (short)32142539;
				short num2 = num;
				num = (short)661288139;
				switch (num2 == num)
				{
				}
				num = (short)96010241;
				if (num != 0)
				{
				}
				num = (short)2120220672;
				short num3 = num;
				num = (short)1683030016;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition4_A21530.Visible = value;
			}
		}

		// Token: 0x17003BD6 RID: 15318
		// (get) Token: 0x06007414 RID: 29716 RVA: 0x0068A560 File Offset: 0x00688760
		// (set) Token: 0x06007415 RID: 29717 RVA: 0x0068A618 File Offset: 0x00688818
		public bool SwitchConventionalSwitchesPosition4_A21530_Editable
		{
			get
			{
				short num = (short)1710960988;
				short num2 = num;
				num = (short)1130443100;
				switch (num2 == num)
				{
				}
				num = (short)1441136640;
				if (num != 0)
				{
				}
				num = (short)1209860096;
				short num3 = num;
				num = (short)1768226817;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition4_A21530.Editable;
			}
			set
			{
				short num = (short)1993753612;
				short num2 = num;
				num = (short)713966604;
				switch (num2 == num)
				{
				}
				num = (short)271056896;
				if (num != 0)
				{
				}
				num = (short)1969487872;
				short num3 = num;
				num = (short)1961426945;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition4_A21530.Editable = value;
			}
		}

		// Token: 0x17003BD7 RID: 15319
		// (get) Token: 0x06007416 RID: 29718 RVA: 0x0068A6D0 File Offset: 0x006888D0
		internal string SwitchConventionalSwitchesPosition4_A21530_UILabel
		{
			get
			{
				short num = (short)777580087;
				short num2 = num;
				num = (short)592506423;
				switch (num2 == num)
				{
				}
				num = (short)1739063296;
				if (num != 0)
				{
				}
				num = (short)228458496;
				short num3 = num;
				num = (short)684851201;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition4_A21530.UIName;
			}
		}

		// Token: 0x17003BD8 RID: 15320
		// (get) Token: 0x06007417 RID: 29719 RVA: 0x0068A784 File Offset: 0x00688984
		// (set) Token: 0x06007418 RID: 29720 RVA: 0x0068A834 File Offset: 0x00688A34
		internal bool SwitchConventionalSwitchesPosition4_A21530_HiddenStatic
		{
			get
			{
				short num = (short)996147201;
				if (num != 0)
				{
				}
				num = (short)1266639530;
				short num2 = num;
				num = (short)409756330;
				switch (num2 == num)
				{
				}
				num = (short)1257373696;
				short num3 = num;
				num = (short)1239351296;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition4_A21530.HiddenStatic;
			}
			set
			{
				short num = (short)114529063;
				short num2 = num;
				num = (short)196645671;
				switch (num2 == num)
				{
				}
				num = (short)738852865;
				if (num != 0)
				{
				}
				num = (short)1715470336;
				short num3 = num;
				num = (short)1877999616;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition4_A21530.HiddenStatic = value;
			}
		}

		// Token: 0x17003BD9 RID: 15321
		// (get) Token: 0x06007419 RID: 29721 RVA: 0x0068A8EC File Offset: 0x00688AEC
		// (set) Token: 0x0600741A RID: 29722 RVA: 0x0068A9A0 File Offset: 0x00688BA0
		internal bool SwitchConventionalSwitchesPosition4_A21530_HiddenDynamic
		{
			get
			{
				short num = (short)1368981505;
				if (num != 0)
				{
				}
				num = (short)889862774;
				short num2 = num;
				num = (short)1406417526;
				switch (num2 == num)
				{
				}
				num = (short)805240832;
				short num3 = num;
				num = (short)847904768;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition4_A21530.HiddenDynamic;
			}
			set
			{
				short num = (short)1564606465;
				if (num != 0)
				{
				}
				num = (short)61401681;
				short num2 = num;
				num = (short)745466449;
				switch (num2 == num)
				{
				}
				num = (short)1814298624;
				short num3 = num;
				num = (short)1436024832;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition4_A21530.HiddenDynamic = value;
			}
		}

		// Token: 0x17003BDA RID: 15322
		// (get) Token: 0x0600741B RID: 29723 RVA: 0x0068AA58 File Offset: 0x00688C58
		public bool SwitchConventionalSwitchesPosition4_A21530_HasDiffs
		{
			get
			{
				short num = (short)1757491062;
				short num2 = num;
				num = (short)2032807798;
				switch (num2 == num)
				{
				}
				num = (short)1762787329;
				if (num != 0)
				{
				}
				num = (short)1280966656;
				short num3 = num;
				num = (short)471924736;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition4_A21530._HasDiffs;
			}
		}

		// Token: 0x17003BDB RID: 15323
		// (get) Token: 0x0600741C RID: 29724 RVA: 0x0068AB0C File Offset: 0x00688D0C
		// (set) Token: 0x0600741D RID: 29725 RVA: 0x0068ABC0 File Offset: 0x00688DC0
		public int SwitchConventionalSwitchesPosition5_A21531Value
		{
			get
			{
				short num = (short)120688085;
				short num2 = num;
				num = (short)1666616789;
				switch (num2 == num)
				{
				}
				num = (short)1722417153;
				if (num != 0)
				{
				}
				num = (short)95944704;
				short num3 = num;
				num = (short)743571456;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition5_A21531.Value;
			}
			set
			{
				short num = (short)541303820;
				short num2 = num;
				num = (short)1532339212;
				switch (num2 == num)
				{
				}
				num = (short)1916862464;
				if (num != 0)
				{
				}
				num = (short)1604648960;
				short num3 = num;
				num = (short)910688257;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition5_A21531.Value = value;
			}
		}

		// Token: 0x17003BDC RID: 15324
		// (get) Token: 0x0600741E RID: 29726 RVA: 0x0068AC78 File Offset: 0x00688E78
		// (set) Token: 0x0600741F RID: 29727 RVA: 0x0068AD30 File Offset: 0x00688F30
		public string SwitchConventionalSwitchesPosition5_A21531_UIValue
		{
			get
			{
				short num = (short)1538916353;
				if (num != 0)
				{
				}
				num = (short)1800242913;
				short num2 = num;
				num = (short)96372449;
				switch (num2 == num)
				{
				}
				num = (short)176750592;
				short num3 = num;
				num = (short)546897920;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition5_A21531.UIValue;
			}
			set
			{
				short num = (short)1726309011;
				short num2 = num;
				num = (short)445604499;
				switch (num2 == num)
				{
				}
				num = (short)922550273;
				if (num != 0)
				{
				}
				num = (short)1572601856;
				short num3 = num;
				num = (short)936247296;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition5_A21531.UIValue = value;
			}
		}

		// Token: 0x17003BDD RID: 15325
		// (get) Token: 0x06007420 RID: 29728 RVA: 0x0068ADE8 File Offset: 0x00688FE8
		public global::AcpBusinessLayer.AcpListField SwitchConventionalSwitchesPosition5_A21531
		{
			get
			{
				short num = (short)270894822;
				short num2 = num;
				num = (short)1453229798;
				switch (num2 == num)
				{
				}
				num = (short)496435200;
				if (num != 0)
				{
				}
				num = (short)464650240;
				short num3 = num;
				num = (short)1758068737;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition5_A21531;
			}
		}

		// Token: 0x17003BDE RID: 15326
		// (get) Token: 0x06007421 RID: 29729 RVA: 0x0068AE98 File Offset: 0x00689098
		// (set) Token: 0x06007422 RID: 29730 RVA: 0x0068AF4C File Offset: 0x0068914C
		public bool SwitchConventionalSwitchesPosition5_A21531_Applicable
		{
			get
			{
				short num = (short)854966794;
				short num2 = num;
				num = (short)186237450;
				switch (num2 == num)
				{
				}
				num = (short)141164545;
				if (num != 0)
				{
				}
				num = (short)1736769536;
				short num3 = num;
				num = (short)1923088384;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition5_A21531.Applicable;
			}
			set
			{
				short num = (short)963287985;
				short num2 = num;
				num = (short)871865265;
				switch (num2 == num)
				{
				}
				num = (short)382337025;
				if (num != 0)
				{
				}
				num = (short)55967744;
				short num3 = num;
				num = (short)1964441600;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition5_A21531.Applicable = value;
			}
		}

		// Token: 0x17003BDF RID: 15327
		// (get) Token: 0x06007423 RID: 29731 RVA: 0x0068B000 File Offset: 0x00689200
		// (set) Token: 0x06007424 RID: 29732 RVA: 0x0068B0B4 File Offset: 0x006892B4
		public bool SwitchConventionalSwitchesPosition5_A21531_Valid
		{
			get
			{
				short num = (short)1414207531;
				short num2 = num;
				num = (short)824186923;
				switch (num2 == num)
				{
				}
				num = (short)1140850689;
				if (num != 0)
				{
				}
				num = (short)1841889280;
				short num3 = num;
				num = (short)767426560;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition5_A21531.Valid;
			}
			set
			{
				short num = (short)1903427585;
				if (num != 0)
				{
				}
				num = (short)602282965;
				short num2 = num;
				num = (short)554703829;
				switch (num2 == num)
				{
				}
				num = (short)441122816;
				short num3 = num;
				num = (short)343539712;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition5_A21531.Valid = value;
			}
		}

		// Token: 0x17003BE0 RID: 15328
		// (get) Token: 0x06007425 RID: 29733 RVA: 0x0068B168 File Offset: 0x00689368
		// (set) Token: 0x06007426 RID: 29734 RVA: 0x0068B21C File Offset: 0x0068941C
		public bool SwitchConventionalSwitchesPosition5_A21531_Visible
		{
			get
			{
				short num = (short)1720853736;
				short num2 = num;
				num = (short)1790059752;
				switch (num2 == num)
				{
				}
				num = (short)428933121;
				if (num != 0)
				{
				}
				num = (short)2058027008;
				short num3 = num;
				num = (short)2041053184;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition5_A21531.Visible;
			}
			set
			{
				short num = (short)1569661254;
				short num2 = num;
				num = (short)1621565766;
				switch (num2 == num)
				{
				}
				num = (short)41484288;
				if (num != 0)
				{
				}
				num = (short)1376256;
				short num3 = num;
				num = (short)1956052993;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition5_A21531.Visible = value;
			}
		}

		// Token: 0x17003BE1 RID: 15329
		// (get) Token: 0x06007427 RID: 29735 RVA: 0x0068B2D4 File Offset: 0x006894D4
		// (set) Token: 0x06007428 RID: 29736 RVA: 0x0068B38C File Offset: 0x0068958C
		public bool SwitchConventionalSwitchesPosition5_A21531_Editable
		{
			get
			{
				short num = (short)1135144136;
				short num2 = num;
				num = (short)75951304;
				switch (num2 == num)
				{
				}
				num = (short)82247680;
				if (num != 0)
				{
				}
				num = (short)1102446592;
				short num3 = num;
				num = (short)200802305;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition5_A21531.Editable;
			}
			set
			{
				short num = (short)1258749953;
				if (num != 0)
				{
				}
				num = (short)1498530682;
				short num2 = num;
				num = (short)1603912570;
				switch (num2 == num)
				{
				}
				num = (short)2066087936;
				short num3 = num;
				num = (short)1436418048;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition5_A21531.Editable = value;
			}
		}

		// Token: 0x17003BE2 RID: 15330
		// (get) Token: 0x06007429 RID: 29737 RVA: 0x0068B444 File Offset: 0x00689644
		internal string SwitchConventionalSwitchesPosition5_A21531_UILabel
		{
			get
			{
				short num = (short)1297229564;
				short num2 = num;
				num = (short)1365452540;
				switch (num2 == num)
				{
				}
				num = (short)980746241;
				if (num != 0)
				{
				}
				num = (short)466223104;
				short num3 = num;
				num = (short)316276736;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition5_A21531.UIName;
			}
		}

		// Token: 0x17003BE3 RID: 15331
		// (get) Token: 0x0600742A RID: 29738 RVA: 0x0068B4FC File Offset: 0x006896FC
		// (set) Token: 0x0600742B RID: 29739 RVA: 0x0068B5B0 File Offset: 0x006897B0
		internal bool SwitchConventionalSwitchesPosition5_A21531_HiddenStatic
		{
			get
			{
				short num = (short)1336110521;
				short num2 = num;
				num = (short)424046009;
				switch (num2 == num)
				{
				}
				num = (short)1440153600;
				if (num != 0)
				{
				}
				num = (short)182779904;
				short num3 = num;
				num = (short)1473445889;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition5_A21531.HiddenStatic;
			}
			set
			{
				short num = (short)749184372;
				short num2 = num;
				num = (short)1406772596;
				switch (num2 == num)
				{
				}
				num = (short)1818492929;
				if (num != 0)
				{
				}
				num = (short)1332871168;
				short num3 = num;
				num = (short)1125384192;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition5_A21531.HiddenStatic = value;
			}
		}

		// Token: 0x17003BE4 RID: 15332
		// (get) Token: 0x0600742C RID: 29740 RVA: 0x0068B664 File Offset: 0x00689864
		// (set) Token: 0x0600742D RID: 29741 RVA: 0x0068B718 File Offset: 0x00689918
		internal bool SwitchConventionalSwitchesPosition5_A21531_HiddenDynamic
		{
			get
			{
				short num = (short)1366753281;
				if (num != 0)
				{
				}
				num = (short)1129365380;
				short num2 = num;
				num = (short)1112522628;
				switch (num2 == num)
				{
				}
				num = (short)1285029888;
				short num3 = num;
				num = (short)183631872;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition5_A21531.HiddenDynamic;
			}
			set
			{
				short num = (short)1271362928;
				short num2 = num;
				num = (short)567506288;
				switch (num2 == num)
				{
				}
				num = (short)1073414145;
				if (num != 0)
				{
				}
				num = (short)727187456;
				short num3 = num;
				num = (short)1709703168;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchesPosition5_A21531.HiddenDynamic = value;
			}
		}

		// Token: 0x17003BE5 RID: 15333
		// (get) Token: 0x0600742E RID: 29742 RVA: 0x0068B7CC File Offset: 0x006899CC
		public bool SwitchConventionalSwitchesPosition5_A21531_HasDiffs
		{
			get
			{
				short num = (short)1059260874;
				short num2 = num;
				num = (short)2002454986;
				switch (num2 == num)
				{
				}
				num = (short)326696960;
				if (num != 0)
				{
				}
				num = (short)338231296;
				short num3 = num;
				num = (short)1960968193;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchesPosition5_A21531._HasDiffs;
			}
		}

		// Token: 0x17003BE6 RID: 15334
		// (get) Token: 0x0600742F RID: 29743 RVA: 0x0068B880 File Offset: 0x00689A80
		public global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems RefMenuItems
		{
			get
			{
				short num = (short)1891838605;
				short num2 = num;
				num = (short)987376269;
				switch (num2 == num)
				{
				}
				num = (short)1412300801;
				if (num != 0)
				{
				}
				num = (short)1718747136;
				short num3 = num;
				num = (short)1748631552;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2088)[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
			}
		}

		// Token: 0x17003BE7 RID: 15335
		// (get) Token: 0x06007430 RID: 29744 RVA: 0x0068B93C File Offset: 0x00689B3C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide RefRadioErgonomicsWide
		{
			get
			{
				short num = (short)2037542960;
				short num2 = num;
				num = (short)1337094192;
				switch (num2 == num)
				{
				}
				num = (short)119996417;
				if (num != 0)
				{
				}
				num = (short)2041577472;
				short num3 = num;
				num = (short)1709703168;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			}
		}

		// Token: 0x17003BE8 RID: 15336
		// (get) Token: 0x06007431 RID: 29745 RVA: 0x0068B9F8 File Offset: 0x00689BF8
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1213315078;
				short num2 = num;
				num = (short)1384560646;
				switch (num2 == num)
				{
				}
				num = (short)134873088;
				if (num != 0)
				{
				}
				num = (short)394461184;
				short num3 = num;
				num = (short)250806273;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06007432 RID: 29746 RVA: 0x0068BAB4 File Offset: 0x00689CB4
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
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1919090691;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
				{
					num2 = (short)2026656689;
					short num3 = num2;
					num2 = (short)473322417;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F9;
					default:
						goto IL_E2;
					}
					break;
				}
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)68222976;
						short num4 = num2;
						num2 = (short)1494941700;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)669319169;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_F9;
				}
				goto IL_24;
				IL_F9:
				num2 = (short)1717960705;
				if (num2 != 0)
				{
				}
				num2 = (short)1657667584;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_E2:
			num2 = (short)187367424;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1567490050;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04002D0B RID: 11531
		private global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition1_A7734;

		// Token: 0x04002D0C RID: 11532
		private global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition2_A7735;

		// Token: 0x04002D0D RID: 11533
		private global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition3_A7737;

		// Token: 0x04002D0E RID: 11534
		private global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition4_A21530;

		// Token: 0x04002D0F RID: 11535
		private global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition5_A21531;
	}
}
