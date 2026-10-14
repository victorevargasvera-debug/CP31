using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x02000070 RID: 112
	[global::System.Serializable]
	public class ControlChannelsInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06000C33 RID: 3123 RVA: 0x000CB73C File Offset: 0x000C993C
		public ControlChannelsInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x000CB758 File Offset: 0x000C9958
		protected ControlChannelsInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x000CB770 File Offset: 0x000C9970
		public override void Init()
		{
			int a_ = 11;
			short num = (short)1277215088;
			short num2 = num;
			num = (short)1979892080;
			switch (num2 == num)
			{
			}
			num = (short)1058668545;
			if (num != 0)
			{
			}
			num = (short)1955069952;
			short num3 = num;
			num = (short)11403264;
			if (num != 0)
			{
			}
			this.trkSysControlChannelsRxFrequencyMHz_A9018 = new global::AcpBusinessLayer.AcpFrequencyField(170202500, this, global::AllFeatures.CodeplugGuid.b("飋볍믏臑귓ꗕ鯗뗙닛ꫝ鋟跡裣ꗥ胧诩苫胭闯黱蟳ꓵ胷볹軻鯽燿省愃栅欇猉䄋䘍樏䴑唓⼕⠗⬙␛", a_), global::CommonResources.AcgResources.ID_RXFREQUENCYMHZ, 0, int.MaxValue, 1);
			this.trkSysControlChannelsRxFrequencyMHz_A9018.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysControlChannelsRxFrequencyMHz_A9018.DataTransferOrder = 23;
			this.trkSysControlChannelsTxFrequencyMHz_A9535 = new global::AcpBusinessLayer.AcpFrequencyField(161202500, this, global::AllFeatures.CodeplugGuid.b("飋볍믏臑귓ꗕ鯗뗙닛ꫝ鋟跡裣ꗥ胧诩苫胭闯黱蟳ꋵ胷볹軻鯽燿省愃栅欇猉䄋䘍樏䴑唓⼕ⴗ⤙⤛", a_), global::CommonResources.AcgResources.ID_TXFREQUENCYMHZ, 0, int.MaxValue, 1);
			this.trkSysControlChannelsTxFrequencyMHz_A9535.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysControlChannelsTxFrequencyMHz_A9535.DataTransferOrder = 101;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("迋ꇍ뻏ꛑꛓ맕듗龎鿛뛝臟賡諣菥蓧駩", a_);
			base.Id = 10170;
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLCHANNELS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x000CB8D8 File Offset: 0x000C9AD8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 2;
			short num = (short)26083328;
			short num2 = num;
			num = (short)946339433;
			short num3 = num;
			num = (short)41549417;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_104:
				if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌賎뻐뷒ꇔꗖ뛘럚黜럞胠跢诤苦藨飪맬韮런臲郴蛶賸黺鏼鳾砀丂䴄紆嘈䨊㐌㨎∐☒", a_)))
				{
					goto IL_295;
				}
				num = (short)1994588168;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1077608448;
				if (num != 0)
				{
				}
				num = (short)59310084;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					num = (short)626589701;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (producerFields != null)
					{
						num = (short)1371144192;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_295;
				case 2:
					goto IL_104;
				case 3:
					num = (short)1971978241;
					if (num != 0)
					{
					}
					this.trkSysControlChannelsRxFrequencyMHz_A9018 = new global::AcpBusinessLayer.AcpFrequencyField(170202500, this, global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌賎뻐뷒ꇔꗖ뛘럚黜럞胠跢诤苦藨飪뿬韮런臲郴蛶賸黺鏼鳾砀丂䴄紆嘈䨊㐌㼎‐⬒", a_), global::CommonResources.AcgResources.ID_RXFREQUENCYMHZ);
					this.trkSysControlChannelsRxFrequencyMHz_A9018.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysControlChannelsRxFrequencyMHz_A9018.DataTransferOrder = 23;
					num = (short)159449097;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_C9;
					}
					continue;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌賎뻐뷒ꇔꗖ뛘럚黜럞胠跢诤苦藨飪뿬韮런臲郴蛶賸黺鏼鳾砀丂䴄紆嘈䨊㐌㼎‐⬒", a_)))
					{
						num = (short)1862598659;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EE;
				case 6:
					num = (short)1374420993;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_246;
				case 8:
					this.trkSysControlChannelsTxFrequencyMHz_A9535 = new global::AcpBusinessLayer.AcpFrequencyField(161202500, this, global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌賎뻐뷒ꇔꗖ뛘럚黜럞胠跢诤苦藨飪맬韮런臲郴蛶賸黺鏼鳾砀丂䴄紆嘈䨊㐌㨎∐☒", a_), global::CommonResources.AcgResources.ID_TXFREQUENCYMHZ);
					this.trkSysControlChannelsTxFrequencyMHz_A9535.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysControlChannelsTxFrequencyMHz_A9535.DataTransferOrder = 101;
					num = (short)780402695;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_EE;
				}
				IL_C9:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)477167622;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_EE:
				num = (short)977600514;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_246:
			IL_295:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胂꫄꧆뷈맊ꋌꏎ郒뷔뛖럘뗚룜돞鋠", a_);
			base.Id = 10170;
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLCHANNELS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x000CBBAC File Offset: 0x000C9DAC
		public override void PopulateReferences()
		{
			short num = (short)1158650215;
			short num2 = num;
			num = (short)847878503;
			switch (num2 == num)
			{
			}
			num = (short)772145152;
			if (num != 0)
			{
			}
			num = (short)1119158272;
			short num3 = num;
			num = (short)1680605185;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x000CBC54 File Offset: 0x000C9E54
		public override void DropReferences()
		{
			short num = (short)434329404;
			short num2 = num;
			num = (short)707745596;
			switch (num2 == num)
			{
			}
			num = (short)2110914561;
			if (num != 0)
			{
			}
			num = (short)2122448896;
			short num3 = num;
			num = (short)989855744;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x000CBCFC File Offset: 0x000C9EFC
		public override void SetConstraints()
		{
			short num = (short)631701505;
			if (num != 0)
			{
			}
			num = (short)599458;
			short num2 = num;
			num = (short)1565336994;
			switch (num2 == num)
			{
			}
			num = (short)1195900928;
			short num3 = num;
			num = (short)205455360;
			if (num != 0)
			{
			}
			this.trkSysControlChannelsRxFrequencyMHz_A9018.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConIsSmartZoneOrSmartNet);
			this.trkSysControlChannelsRxFrequencyMHz_A9018.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conControlChannelRxFreqValidity);
			this.trkSysControlChannelsRxFrequencyMHz_A9018.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conSetValueTxFrequency);
			this.trkSysControlChannelsTxFrequencyMHz_A9535.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conCCTxFreqApplicability);
			this.trkSysControlChannelsTxFrequencyMHz_A9535.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conControlChannelTxFreqValidity);
			this.trkSysControlChannelsTxFrequencyMHz_A9535.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conCCTxFreqApplicabilityEditbl);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x000CBE30 File Offset: 0x000CA030
		public override void SetupDependencies()
		{
			short num = (short)741768373;
			short num2 = num;
			num = (short)1499823285;
			switch (num2 == num)
			{
			}
			num = (short)1533476865;
			if (num != 0)
			{
			}
			num = (short)296747008;
			short num3 = num;
			num = (short)2130116608;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.AddDependentObject(this.trkSysControlChannelsRxFrequencyMHz_A9018);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493.AddDependentObject(this.trkSysControlChannelsRxFrequencyMHz_A9018);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481.AddDependentObject(this.trkSysControlChannelsRxFrequencyMHz_A9018);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504.AddDependentObject(this.trkSysControlChannelsRxFrequencyMHz_A9018);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507.AddDependentObject(this.trkSysControlChannelsRxFrequencyMHz_A9018);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.AddDependentObject(this.trkSysControlChannelsRxFrequencyMHz_A9018);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516.AddDependentObject(this.trkSysControlChannelsRxFrequencyMHz_A9018);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysControlChannelsRxFrequencyMHz_A9018);
			trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491.AddDependentObject(this.trkSysControlChannelsRxFrequencyMHz_A9018);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.AddDependentObject(this.trkSysControlChannelsRxFrequencyMHz_A9018);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.AddDependentObject(this.trkSysControlChannelsRxFrequencyMHz_A9018);
			this.trkSysControlChannelsTxFrequencyMHz_A9535.AddDependentObject(this.trkSysControlChannelsRxFrequencyMHz_A9018);
			this.RefRadioInformation.Labtool.RadInfoLabtoolH38G51Smartzone_A8185.AddDependentObject(this.trkSysControlChannelsRxFrequencyMHz_A9018);
			this.RefRadioInformation.Labtool.RadInfoLabtoolH37G50Smartnet_A8184.AddDependentObject(this.trkSysControlChannelsRxFrequencyMHz_A9018);
			this.RefRadioInformation.Labtool.RadInfoLabtoolH38G51Smartzone_A8185.AddDependentObject(this.trkSysControlChannelsTxFrequencyMHz_A9535);
			this.RefRadioInformation.Labtool.RadInfoLabtoolH37G50Smartnet_A8184.AddDependentObject(this.trkSysControlChannelsTxFrequencyMHz_A9535);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysControlChannelsTxFrequencyMHz_A9535);
			trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491.AddDependentObject(this.trkSysControlChannelsTxFrequencyMHz_A9535);
			this.trkSysControlChannelsRxFrequencyMHz_A9018.AddDependentObject(this.trkSysControlChannelsTxFrequencyMHz_A9535);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.AddDependentObject(this.trkSysControlChannelsTxFrequencyMHz_A9535);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493.AddDependentObject(this.trkSysControlChannelsTxFrequencyMHz_A9535);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481.AddDependentObject(this.trkSysControlChannelsTxFrequencyMHz_A9535);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504.AddDependentObject(this.trkSysControlChannelsTxFrequencyMHz_A9535);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507.AddDependentObject(this.trkSysControlChannelsTxFrequencyMHz_A9535);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.AddDependentObject(this.trkSysControlChannelsTxFrequencyMHz_A9535);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516.AddDependentObject(this.trkSysControlChannelsTxFrequencyMHz_A9535);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.AddDependentObject(this.trkSysControlChannelsTxFrequencyMHz_A9535);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.AddDependentObject(this.trkSysControlChannelsTxFrequencyMHz_A9535);
			this.trkSysControlChannelsRxFrequencyMHz_A9018.AddDependentObject((base.ParentRecset.ParentSection.Parent[10157] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General).TrkSysGeneralConnectToneHz_A7710);
			this.trkSysControlChannelsRxFrequencyMHz_A9018.AddDependentObject((base.ParentRecset.ParentSection.Parent[10157] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General).TrkSysGeneralSystemID_A9239);
			this.trkSysControlChannelsRxFrequencyMHz_A9018.AddDependentObject((base.ParentRecset.ParentSection.Parent[10157] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General).TrkSysGeneralSystemType_A9252);
			this.trkSysControlChannelsRxFrequencyMHz_A9018.AddDependentObject((base.ParentRecset.ParentSection.Parent[10157] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General).TrkSysGeneralTypeIIFrequencyBand_A12491);
			this.trkSysControlChannelsTxFrequencyMHz_A9535.AddDependentObject((base.ParentRecset.ParentSection.Parent[10157] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General).TrkSysGeneralConnectToneHz_A7710);
			this.trkSysControlChannelsTxFrequencyMHz_A9535.AddDependentObject((base.ParentRecset.ParentSection.Parent[10157] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General).TrkSysGeneralSystemID_A9239);
			this.trkSysControlChannelsTxFrequencyMHz_A9535.AddDependentObject((base.ParentRecset.ParentSection.Parent[10157] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General).TrkSysGeneralSystemType_A9252);
			this.trkSysControlChannelsTxFrequencyMHz_A9535.AddDependentObject((base.ParentRecset.ParentSection.Parent[10157] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General).TrkSysGeneralTypeIIFrequencyBand_A12491);
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x000CC354 File Offset: 0x000CA554
		public bool HasDiffs
		{
			get
			{
				short num = (short)1875902465;
				if (num != 0)
				{
				}
				num = (short)855824191;
				short num2 = num;
				num = (short)504223551;
				switch (num2 == num)
				{
				}
				num = (short)546373632;
				short num3 = num;
				num = (short)651624448;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x000CC404 File Offset: 0x000CA604
		// (set) Token: 0x06000C3D RID: 3133 RVA: 0x000CC4BC File Offset: 0x000CA6BC
		public int TrkSysControlChannelsRxFrequencyMHz_A9018Value
		{
			get
			{
				short num = (short)802328902;
				short num2 = num;
				num = (short)1872138566;
				switch (num2 == num)
				{
				}
				num = (short)1167065089;
				if (num != 0)
				{
				}
				num = (short)1140719616;
				short num3 = num;
				num = (short)1421934592;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsRxFrequencyMHz_A9018.Value;
			}
			set
			{
				short num = (short)2135230087;
				short num2 = num;
				num = (short)1767048839;
				switch (num2 == num)
				{
				}
				num = (short)1276051457;
				if (num != 0)
				{
				}
				num = (short)1675689984;
				short num3 = num;
				num = (short)423559168;
				if (num != 0)
				{
				}
				this.trkSysControlChannelsRxFrequencyMHz_A9018.Value = value;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x000CC570 File Offset: 0x000CA770
		// (set) Token: 0x06000C3F RID: 3135 RVA: 0x000CC624 File Offset: 0x000CA824
		public string TrkSysControlChannelsRxFrequencyMHz_A9018_UIValue
		{
			get
			{
				short num = (short)228580165;
				short num2 = num;
				num = (short)125033285;
				switch (num2 == num)
				{
				}
				num = (short)466419712;
				if (num != 0)
				{
				}
				num = (short)1658781696;
				short num3 = num;
				num = (short)1585643521;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsRxFrequencyMHz_A9018.UIValue;
			}
			set
			{
				short num = (short)790073;
				short num2 = num;
				num = (short)88346169;
				switch (num2 == num)
				{
				}
				num = (short)1455882241;
				if (num != 0)
				{
				}
				num = (short)837222400;
				short num3 = num;
				num = (short)724107264;
				if (num != 0)
				{
				}
				this.trkSysControlChannelsRxFrequencyMHz_A9018.UIValue = value;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x000CC6DC File Offset: 0x000CA8DC
		public global::AcpBusinessLayer.AcpFrequencyField TrkSysControlChannelsRxFrequencyMHz_A9018
		{
			get
			{
				short num = (short)1655989123;
				short num2 = num;
				num = (short)362046339;
				switch (num2 == num)
				{
				}
				num = (short)1569325056;
				if (num != 0)
				{
				}
				num = (short)1711341568;
				short num3 = num;
				num = (short)1797128193;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsRxFrequencyMHz_A9018;
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x000CC78C File Offset: 0x000CA98C
		// (set) Token: 0x06000C42 RID: 3138 RVA: 0x000CC844 File Offset: 0x000CAA44
		internal int TrkSysControlChannelsRxFrequencyMHz_A9018Min
		{
			get
			{
				short num = (short)778435793;
				short num2 = num;
				num = (short)1661009105;
				switch (num2 == num)
				{
				}
				num = (short)1735655424;
				if (num != 0)
				{
				}
				num = (short)1281032192;
				short num3 = num;
				num = (short)1990131713;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsRxFrequencyMHz_A9018.Min;
			}
			set
			{
				short num = (short)1737493240;
				short num2 = num;
				num = (short)1821313784;
				switch (num2 == num)
				{
				}
				num = (short)1780547585;
				if (num != 0)
				{
				}
				num = (short)1621688320;
				short num3 = num;
				num = (short)1305935872;
				if (num != 0)
				{
				}
				this.trkSysControlChannelsRxFrequencyMHz_A9018.Min = value;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x000CC8FC File Offset: 0x000CAAFC
		// (set) Token: 0x06000C44 RID: 3140 RVA: 0x000CC9AC File Offset: 0x000CABAC
		internal int TrkSysControlChannelsRxFrequencyMHz_A9018Max
		{
			get
			{
				short num = (short)751595440;
				short num2 = num;
				num = (short)1972989872;
				switch (num2 == num)
				{
				}
				num = (short)2102984705;
				if (num != 0)
				{
				}
				num = (short)1197342720;
				short num3 = num;
				num = (short)1065287680;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsRxFrequencyMHz_A9018.Max;
			}
			set
			{
				short num = (short)1624743916;
				short num2 = num;
				num = (short)1282580460;
				switch (num2 == num)
				{
				}
				num = (short)1919680512;
				if (num != 0)
				{
				}
				num = (short)1760493568;
				short num3 = num;
				num = (short)1086390273;
				if (num != 0)
				{
				}
				this.trkSysControlChannelsRxFrequencyMHz_A9018.Max = value;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x000CCA64 File Offset: 0x000CAC64
		// (set) Token: 0x06000C46 RID: 3142 RVA: 0x000CCB18 File Offset: 0x000CAD18
		internal int TrkSysControlChannelsRxFrequencyMHz_A9018Step
		{
			get
			{
				short num = (short)452992682;
				short num2 = num;
				num = (short)223420074;
				switch (num2 == num)
				{
				}
				num = (short)398917632;
				short num3 = num;
				num = (short)523829249;
				if (num != 0)
				{
				}
				num = (short)1274216448;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsRxFrequencyMHz_A9018.StepSize;
			}
			set
			{
				short num = (short)219920198;
				short num2 = num;
				num = (short)135378758;
				switch (num2 == num)
				{
				}
				num = (short)1407516672;
				short num3 = num;
				num = (short)72679425;
				if (num != 0)
				{
				}
				num = (short)1788280832;
				if (num != 0)
				{
				}
				this.trkSysControlChannelsRxFrequencyMHz_A9018.StepSize = value;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06000C47 RID: 3143 RVA: 0x000CCBCC File Offset: 0x000CADCC
		// (set) Token: 0x06000C48 RID: 3144 RVA: 0x000CCC84 File Offset: 0x000CAE84
		public bool TrkSysControlChannelsRxFrequencyMHz_A9018_Applicable
		{
			get
			{
				short num = (short)1717865777;
				short num2 = num;
				num = (short)2091027761;
				switch (num2 == num)
				{
				}
				num = (short)997654528;
				short num3 = num;
				num = (short)2062483457;
				if (num != 0)
				{
				}
				num = (short)205848576;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsRxFrequencyMHz_A9018.Applicable;
			}
			set
			{
				short num = (short)1193655700;
				short num2 = num;
				num = (short)1302510996;
				switch (num2 == num)
				{
				}
				num = (short)999161856;
				short num3 = num;
				num = (short)1857814529;
				if (num != 0)
				{
				}
				num = (short)1189609472;
				if (num != 0)
				{
				}
				this.trkSysControlChannelsRxFrequencyMHz_A9018.Applicable = value;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x000CCD38 File Offset: 0x000CAF38
		// (set) Token: 0x06000C4A RID: 3146 RVA: 0x000CCDEC File Offset: 0x000CAFEC
		public bool TrkSysControlChannelsRxFrequencyMHz_A9018_Valid
		{
			get
			{
				short num = (short)1034437125;
				short num2 = num;
				num = (short)1614955013;
				switch (num2 == num)
				{
				}
				num = (short)1195311104;
				short num3 = num;
				num = (short)1149763585;
				if (num != 0)
				{
				}
				num = (short)735707136;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsRxFrequencyMHz_A9018.Valid;
			}
			set
			{
				short num = (short)1358954497;
				if (num != 0)
				{
				}
				num = (short)1194709138;
				short num2 = num;
				num = (short)748933266;
				switch (num2 == num)
				{
				default:
				{
					num = (short)932249600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)210894848;
				if (num != 0)
				{
				}
				this.trkSysControlChannelsRxFrequencyMHz_A9018.Valid = value;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x000CCEA0 File Offset: 0x000CB0A0
		// (set) Token: 0x06000C4C RID: 3148 RVA: 0x000CCF54 File Offset: 0x000CB154
		public bool TrkSysControlChannelsRxFrequencyMHz_A9018_Visible
		{
			get
			{
				short num = (short)1470234080;
				short num2 = num;
				num = (short)88800736;
				switch (num2 == num)
				{
				}
				num = (short)641990656;
				short num3 = num;
				num = (short)1339490304;
				if (num != 0)
				{
				}
				num = (short)1862074369;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsRxFrequencyMHz_A9018.Visible;
			}
			set
			{
				short num = (short)1378618551;
				short num2 = num;
				num = (short)1207504055;
				switch (num2 == num)
				{
				}
				num = (short)1213202432;
				short num3 = num;
				num = (short)1460404225;
				if (num != 0)
				{
				}
				num = (short)1639710720;
				if (num != 0)
				{
				}
				this.trkSysControlChannelsRxFrequencyMHz_A9018.Visible = value;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06000C4D RID: 3149 RVA: 0x000CD00C File Offset: 0x000CB20C
		// (set) Token: 0x06000C4E RID: 3150 RVA: 0x000CD0C0 File Offset: 0x000CB2C0
		public bool TrkSysControlChannelsRxFrequencyMHz_A9018_Editable
		{
			get
			{
				short num = (short)137736809;
				short num2 = num;
				num = (short)1853796969;
				switch (num2 == num)
				{
				}
				num = (short)1673789440;
				short num3 = num;
				num = (short)65994753;
				if (num != 0)
				{
				}
				num = (short)1762459648;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsRxFrequencyMHz_A9018.Editable;
			}
			set
			{
				short num = (short)916808020;
				short num2 = num;
				num = (short)1276207444;
				switch (num2 == num)
				{
				}
				num = (short)1450508288;
				short num3 = num;
				num = (short)1849622529;
				if (num != 0)
				{
				}
				num = (short)189267968;
				if (num != 0)
				{
				}
				this.trkSysControlChannelsRxFrequencyMHz_A9018.Editable = value;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x000CD178 File Offset: 0x000CB378
		internal string TrkSysControlChannelsRxFrequencyMHz_A9018_UILabel
		{
			get
			{
				short num = (short)887444753;
				short num2 = num;
				num = (short)1093227793;
				switch (num2 == num)
				{
				}
				num = (short)1799487488;
				short num3 = num;
				num = (short)134086656;
				if (num != 0)
				{
				}
				num = (short)147521537;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsRxFrequencyMHz_A9018.UIName;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06000C50 RID: 3152 RVA: 0x000CD22C File Offset: 0x000CB42C
		// (set) Token: 0x06000C51 RID: 3153 RVA: 0x000CD2E0 File Offset: 0x000CB4E0
		internal bool TrkSysControlChannelsRxFrequencyMHz_A9018_HiddenStatic
		{
			get
			{
				short num = (short)121946987;
				short num2 = num;
				num = (short)1802617707;
				switch (num2 == num)
				{
				}
				num = (short)1074266112;
				short num3 = num;
				num = (short)1409155073;
				if (num != 0)
				{
				}
				num = (short)840695808;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsRxFrequencyMHz_A9018.HiddenStatic;
			}
			set
			{
				short num = (short)1846117663;
				short num2 = num;
				num = (short)1506510111;
				switch (num2 == num)
				{
				}
				num = (short)334364672;
				short num3 = num;
				num = (short)1256062977;
				if (num != 0)
				{
				}
				num = (short)2055208960;
				if (num != 0)
				{
				}
				this.trkSysControlChannelsRxFrequencyMHz_A9018.HiddenStatic = value;
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x000CD398 File Offset: 0x000CB598
		// (set) Token: 0x06000C53 RID: 3155 RVA: 0x000CD44C File Offset: 0x000CB64C
		internal bool TrkSysControlChannelsRxFrequencyMHz_A9018_HiddenDynamic
		{
			get
			{
				short num = (short)1603417510;
				short num2 = num;
				num = (short)1426404774;
				switch (num2 == num)
				{
				}
				num = (short)589365248;
				short num3 = num;
				num = (short)1994981377;
				if (num != 0)
				{
				}
				num = (short)1771241472;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsRxFrequencyMHz_A9018.HiddenDynamic;
			}
			set
			{
				short num = (short)1981022209;
				if (num != 0)
				{
				}
				num = (short)1129420937;
				short num2 = num;
				num = (short)1297979529;
				switch (num2 == num)
				{
				default:
				{
					num = (short)37486592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1350893568;
				if (num != 0)
				{
				}
				this.trkSysControlChannelsRxFrequencyMHz_A9018.HiddenDynamic = value;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x000CD504 File Offset: 0x000CB704
		public bool TrkSysControlChannelsRxFrequencyMHz_A9018_HasDiffs
		{
			get
			{
				short num = (short)374026498;
				short num2 = num;
				num = (short)476852482;
				switch (num2 == num)
				{
				}
				num = (short)1242300416;
				short num3 = num;
				num = (short)1903624192;
				if (num != 0)
				{
				}
				num = (short)2126774273;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsRxFrequencyMHz_A9018._HasDiffs;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x000CD5BC File Offset: 0x000CB7BC
		// (set) Token: 0x06000C56 RID: 3158 RVA: 0x000CD670 File Offset: 0x000CB870
		public int TrkSysControlChannelsTxFrequencyMHz_A9535Value
		{
			get
			{
				short num = (short)393071175;
				short num2 = num;
				num = (short)353290823;
				switch (num2 == num)
				{
				}
				num = (short)1844838400;
				short num3 = num;
				num = (short)1214775296;
				if (num != 0)
				{
				}
				num = (short)1077346305;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsTxFrequencyMHz_A9535.Value;
			}
			set
			{
				short num = (short)317075173;
				short num2 = num;
				num = (short)653274853;
				switch (num2 == num)
				{
				}
				num = (short)642973696;
				short num3 = num;
				num = (short)1084555264;
				if (num != 0)
				{
				}
				num = (short)1162870785;
				if (num != 0)
				{
				}
				this.trkSysControlChannelsTxFrequencyMHz_A9535.Value = value;
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x000CD72C File Offset: 0x000CB92C
		// (set) Token: 0x06000C58 RID: 3160 RVA: 0x000CD7E4 File Offset: 0x000CB9E4
		public string TrkSysControlChannelsTxFrequencyMHz_A9535_UIValue
		{
			get
			{
				short num = (short)908012857;
				short num2 = num;
				num = (short)1975070009;
				switch (num2 == num)
				{
				}
				num = (short)1308164096;
				short num3 = num;
				num = (short)154075137;
				if (num != 0)
				{
				}
				num = (short)1373765632;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsTxFrequencyMHz_A9535.UIValue;
			}
			set
			{
				short num = (short)378779178;
				short num2 = num;
				num = (short)2031662634;
				switch (num2 == num)
				{
				}
				num = (short)1169424384;
				short num3 = num;
				num = (short)73007104;
				if (num != 0)
				{
				}
				num = (short)1608974337;
				if (num != 0)
				{
				}
				this.trkSysControlChannelsTxFrequencyMHz_A9535.UIValue = value;
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x000CD898 File Offset: 0x000CBA98
		public global::AcpBusinessLayer.AcpFrequencyField TrkSysControlChannelsTxFrequencyMHz_A9535
		{
			get
			{
				short num = (short)289613738;
				short num2 = num;
				num = (short)1434265514;
				switch (num2 == num)
				{
				}
				num = (short)793051136;
				short num3 = num;
				num = (short)1311506433;
				if (num != 0)
				{
				}
				num = (short)655163392;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsTxFrequencyMHz_A9535;
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x000CD948 File Offset: 0x000CBB48
		// (set) Token: 0x06000C5B RID: 3163 RVA: 0x000CD9FC File Offset: 0x000CBBFC
		internal int TrkSysControlChannelsTxFrequencyMHz_A9535Min
		{
			get
			{
				short num = (short)647495680;
				short num2 = num;
				num = (short)198391874;
				short num3 = num;
				num = (short)1872181314;
				switch (num3 == num)
				{
				}
				num = (short)1773731841;
				if (num != 0)
				{
				}
				num = (short)2120679424;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsTxFrequencyMHz_A9535.Min;
			}
			set
			{
				short num = (short)826408960;
				short num2 = num;
				num = (short)1857193512;
				short num3 = num;
				num = (short)1063487016;
				switch (num3 == num)
				{
				}
				num = (short)31784961;
				if (num != 0)
				{
				}
				num = (short)543817728;
				if (num != 0)
				{
				}
				this.trkSysControlChannelsTxFrequencyMHz_A9535.Min = value;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x000CDAB0 File Offset: 0x000CBCB0
		// (set) Token: 0x06000C5D RID: 3165 RVA: 0x000CDB64 File Offset: 0x000CBD64
		internal int TrkSysControlChannelsTxFrequencyMHz_A9535Max
		{
			get
			{
				short num = (short)2080047104;
				short num2 = num;
				num = (short)784697181;
				short num3 = num;
				num = (short)999065437;
				switch (num3 == num)
				{
				}
				num = (short)1659502593;
				if (num != 0)
				{
				}
				num = (short)2100756480;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsTxFrequencyMHz_A9535.Max;
			}
			set
			{
				short num = (short)254869504;
				short num2 = num;
				num = (short)487950860;
				short num3 = num;
				num = (short)1364494860;
				switch (num3 == num)
				{
				}
				num = (short)242155521;
				if (num != 0)
				{
				}
				num = (short)1226178560;
				if (num != 0)
				{
				}
				this.trkSysControlChannelsTxFrequencyMHz_A9535.Max = value;
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x000CDC20 File Offset: 0x000CBE20
		// (set) Token: 0x06000C5F RID: 3167 RVA: 0x000CDCD0 File Offset: 0x000CBED0
		internal int TrkSysControlChannelsTxFrequencyMHz_A9535Step
		{
			get
			{
				short num = (short)120848384;
				short num2 = num;
				num = (short)521207809;
				if (num != 0)
				{
				}
				num = (short)247855233;
				short num3 = num;
				num = (short)892991617;
				switch (num3 == num)
				{
				}
				num = (short)61931520;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsTxFrequencyMHz_A9535.StepSize;
			}
			set
			{
				short num = (short)1971847168;
				short num2 = num;
				num = (short)1734536928;
				short num3 = num;
				num = (short)1168568032;
				switch (num3 == num)
				{
				}
				num = (short)504430593;
				if (num != 0)
				{
				}
				num = (short)1494024192;
				if (num != 0)
				{
				}
				this.trkSysControlChannelsTxFrequencyMHz_A9535.StepSize = value;
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x000CDD84 File Offset: 0x000CBF84
		// (set) Token: 0x06000C61 RID: 3169 RVA: 0x000CDE38 File Offset: 0x000CC038
		public bool TrkSysControlChannelsTxFrequencyMHz_A9535_Applicable
		{
			get
			{
				short num = (short)1597964288;
				short num2 = num;
				num = (short)1196828776;
				short num3 = num;
				num = (short)2058823784;
				switch (num3 == num)
				{
				}
				num = (short)2127560704;
				if (num != 0)
				{
				}
				num = (short)836829185;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsTxFrequencyMHz_A9535.Applicable;
			}
			set
			{
				short num = (short)1743192064;
				short num2 = num;
				num = (short)48025355;
				short num3 = num;
				num = (short)1277677323;
				switch (num3 == num)
				{
				}
				num = (short)192086016;
				if (num != 0)
				{
				}
				num = (short)459931649;
				if (num != 0)
				{
				}
				this.trkSysControlChannelsTxFrequencyMHz_A9535.Applicable = value;
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x000CDEEC File Offset: 0x000CC0EC
		// (set) Token: 0x06000C63 RID: 3171 RVA: 0x000CDFA0 File Offset: 0x000CC1A0
		public bool TrkSysControlChannelsTxFrequencyMHz_A9535_Valid
		{
			get
			{
				short num = (short)544866304;
				short num2 = num;
				num = (short)1784669133;
				short num3 = num;
				num = (short)1340400589;
				switch (num3 == num)
				{
				}
				num = (short)852885505;
				if (num != 0)
				{
				}
				num = (short)17104896;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsTxFrequencyMHz_A9535.Valid;
			}
			set
			{
				short num = (short)1129644032;
				short num2 = num;
				num = (short)764580479;
				short num3 = num;
				num = (short)1219269247;
				switch (num3 == num)
				{
				}
				num = (short)1281884160;
				if (num != 0)
				{
				}
				num = (short)1242365953;
				if (num != 0)
				{
				}
				this.trkSysControlChannelsTxFrequencyMHz_A9535.Valid = value;
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06000C64 RID: 3172 RVA: 0x000CE058 File Offset: 0x000CC258
		// (set) Token: 0x06000C65 RID: 3173 RVA: 0x000CE10C File Offset: 0x000CC30C
		public bool TrkSysControlChannelsTxFrequencyMHz_A9535_Visible
		{
			get
			{
				short num = (short)495714304;
				short num2 = num;
				num = (short)726949766;
				short num3 = num;
				num = (short)1475829638;
				switch (num3 == num)
				{
				}
				num = (short)2114650112;
				if (num != 0)
				{
				}
				num = (short)1638793217;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsTxFrequencyMHz_A9535.Visible;
			}
			set
			{
				short num = (short)1374027776;
				short num2 = num;
				num = (short)63832065;
				if (num != 0)
				{
				}
				num = (short)232334858;
				short num3 = num;
				num = (short)920987146;
				switch (num3 == num)
				{
				}
				num = (short)849477632;
				if (num != 0)
				{
				}
				this.trkSysControlChannelsTxFrequencyMHz_A9535.Visible = value;
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x000CE1C4 File Offset: 0x000CC3C4
		// (set) Token: 0x06000C67 RID: 3175 RVA: 0x000CE278 File Offset: 0x000CC478
		public bool TrkSysControlChannelsTxFrequencyMHz_A9535_Editable
		{
			get
			{
				short num = (short)497221632;
				short num2 = num;
				num = (short)660610307;
				short num3 = num;
				num = (short)919477507;
				switch (num3 == num)
				{
				}
				num = (short)1504509952;
				if (num != 0)
				{
				}
				num = (short)1454899201;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsTxFrequencyMHz_A9535.Editable;
			}
			set
			{
				short num = (short)224591872;
				short num2 = num;
				num = (short)934842884;
				short num3 = num;
				num = (short)1328714244;
				switch (num3 == num)
				{
				}
				num = (short)787873793;
				if (num != 0)
				{
				}
				num = (short)1723531264;
				if (num != 0)
				{
				}
				this.trkSysControlChannelsTxFrequencyMHz_A9535.Editable = value;
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06000C68 RID: 3176 RVA: 0x000CE32C File Offset: 0x000CC52C
		internal string TrkSysControlChannelsTxFrequencyMHz_A9535_UILabel
		{
			get
			{
				short num = (short)1894318080;
				short num2 = num;
				num = (short)777511919;
				short num3 = num;
				num = (short)215999471;
				switch (num3 == num)
				{
				}
				num = (short)797638657;
				if (num != 0)
				{
				}
				num = (short)1760034816;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsTxFrequencyMHz_A9535.UIName;
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x000CE3DC File Offset: 0x000CC5DC
		// (set) Token: 0x06000C6A RID: 3178 RVA: 0x000CE490 File Offset: 0x000CC690
		internal bool TrkSysControlChannelsTxFrequencyMHz_A9535_HiddenStatic
		{
			get
			{
				short num = (short)2031091712;
				short num2 = num;
				num = (short)2004272630;
				short num3 = num;
				num = (short)1306314230;
				switch (num3 == num)
				{
				}
				num = (short)798425089;
				if (num != 0)
				{
				}
				num = (short)354484224;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsTxFrequencyMHz_A9535.HiddenStatic;
			}
			set
			{
				short num = (short)1136066560;
				short num2 = num;
				num = (short)1821966084;
				short num3 = num;
				num = (short)1445134084;
				switch (num3 == num)
				{
				}
				num = (short)1505230849;
				if (num != 0)
				{
				}
				num = (short)1849294848;
				if (num != 0)
				{
				}
				this.trkSysControlChannelsTxFrequencyMHz_A9535.HiddenStatic = value;
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x000CE544 File Offset: 0x000CC744
		// (set) Token: 0x06000C6C RID: 3180 RVA: 0x000CE5F4 File Offset: 0x000CC7F4
		internal bool TrkSysControlChannelsTxFrequencyMHz_A9535_HiddenDynamic
		{
			get
			{
				short num = (short)1999831040;
				short num2 = num;
				num = (short)1913748655;
				short num3 = num;
				num = (short)108887215;
				switch (num3 == num)
				{
				}
				num = (short)495976449;
				if (num != 0)
				{
				}
				num = (short)2045575168;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsTxFrequencyMHz_A9535.HiddenDynamic;
			}
			set
			{
				short num = (short)346226688;
				short num2 = num;
				num = (short)1916137694;
				short num3 = num;
				num = (short)1638396126;
				switch (num3 == num)
				{
				}
				num = (short)170459137;
				if (num != 0)
				{
				}
				num = (short)1745616896;
				if (num != 0)
				{
				}
				this.trkSysControlChannelsTxFrequencyMHz_A9535.HiddenDynamic = value;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x000CE6AC File Offset: 0x000CC8AC
		public bool TrkSysControlChannelsTxFrequencyMHz_A9535_HasDiffs
		{
			get
			{
				short num = (short)142278656;
				short num2 = num;
				num = (short)45678728;
				short num3 = num;
				num = (short)1480130696;
				switch (num3 == num)
				{
				}
				num = (short)733282305;
				if (num != 0)
				{
				}
				num = (short)674168832;
				if (num != 0)
				{
				}
				return this.trkSysControlChannelsTxFrequencyMHz_A9535._HasDiffs;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06000C6E RID: 3182 RVA: 0x000CE760 File Offset: 0x000CC960
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation RefRadioInformation
		{
			get
			{
				short num = (short)53775535;
				short num2 = num;
				num = (short)1142590639;
				switch (num2 == num)
				{
				default:
				{
					num = (short)216924160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)674496513;
				if (num != 0)
				{
				}
				num = (short)1578172416;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			}
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x000CE820 File Offset: 0x000CCA20
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
					num2 = (short)1004404736;
					short num3 = num2;
					num2 = (short)2014969857;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)824377345;
						if (num2 != 0)
						{
						}
						num2 = (short)709558275;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					return result;
				case 3:
				{
					num2 = (short)2105386194;
					short num4 = num2;
					num2 = (short)65578194;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3A;
					default:
						num2 = (short)1956315136;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)636682242;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					goto IL_3A;
				}
				goto IL_24;
				IL_3A:
				if (base.ParentRecset == null)
				{
					break;
				}
				num2 = (short)1462632448;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1160773636;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000358 RID: 856
		private global::AcpBusinessLayer.AcpFrequencyField trkSysControlChannelsRxFrequencyMHz_A9018;

		// Token: 0x04000359 RID: 857
		private global::AcpBusinessLayer.AcpFrequencyField trkSysControlChannelsTxFrequencyMHz_A9535;
	}
}
