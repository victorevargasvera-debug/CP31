using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Features.Converters;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x02000092 RID: 146
	[global::System.Serializable]
	public class Digital : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06000C7A RID: 3194 RVA: 0x000CFCBC File Offset: 0x000CDEBC
		public Digital(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x000CFCD8 File Offset: 0x000CDED8
		protected Digital(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x000CFCF0 File Offset: 0x000CDEF0
		public override void Init()
		{
			int a_ = 19;
			short num = (short)445225276;
			short num2 = num;
			num = (short)604019004;
			switch (num2 == num)
			{
			default:
			{
				num = (short)271581184;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)809369600;
			if (num != 0)
			{
			}
			num = (short)553648129;
			if (num != 0)
			{
			}
			this.trkSysDigitalAdaptivePower_A7509 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝ꓟ诡菣迥鳧诩胫꿭铯鏱蓳苵釷賹駻껽濿甁愃琅圇䬉㬋㬍‏⬑", a_), global::CommonResources.AcgResources.ID_ADAPTIVEPOWER);
			this.trkSysDigitalAdaptivePower_A7509.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysDigitalAdaptivePower_A7509.DataTransferOrder = 34;
			this.trkSysDigitalDigitalModulatorType_A7858 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝ꓟ诡菣迥鳧诩胫ꫭ駯闱鷳苵駷雹뇻釽擿省栃朅簇攉縋娍椏我焓䤕夗ⴙ␛⬝᠟", a_), global::CommonResources.AcgResources.ID_DIGITALMODULATORTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysDigitalDigitalModulatorType_A7858LovStrs);
			this.trkSysDigitalDigitalModulatorType_A7858.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysDigitalDigitalModulatorType_A7858.DataTransferOrder = 29;
			this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159 = new global::AcpBusinessLayer.AcpCustomRangeField(40, new global::Features.Converters.UnpackFactorDblAndPackFactorDblWith10ForCustomRange(), this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝ꓟ诡菣迥鳧诩胫꣭듯뿱뗳냵諷鯹釻鯽叿笁樃攅䘇䌉䠋䰍唏䀑䀓縕樗缙漛瘝伟両䀣礥椧ሩᴫᬭय", a_), global::CommonResources.AcgResources.ID_FDMAFRAMESYNCNIDBERTHRESHOLD, 0, 254, 1, global::CommonResources.AcgResources.ID_DISABLED, null);
			this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.DataTransferOrder = 59;
			this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.ShowHexValue = false;
			this.trkSysDigitalPreambleLength_A8722 = new global::AcpBusinessLayer.AcpSimpleRangeField(120, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝ꓟ诡菣迥鳧诩胫뻭苯韱闳鯵髷雹駻닽旿氁挃爅怇唉䴋㘍✏‑☓", a_), global::CommonResources.AcgResources.ID_PREAMBLELENGTH, 0, 255, null, null, 0, 1);
			this.trkSysDigitalPreambleLength_A8722.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkSysDigitalPreambleLength_A8722.DataTransferOrder = 44;
			this.trkSysDigitalPreambleLength_A8722.ShowHexValue = false;
			this.trkSysDigitalHighDeviationTx_A19314 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝ꓟ诡菣迥鳧诩胫ꛭ駯闱鳳답鷷賹闻鿽瓿欁欃栅將爉匋伍ℏ⬑✓✕Ⱇ", a_), global::CommonResources.AcgResources.ID_HIGHDEVIATIONTX);
			this.trkSysDigitalHighDeviationTx_A19314.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkSysDigitalHighDeviationTx_A19314.DataTransferOrder = 47;
			this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396 = new global::AcpBusinessLayer.AcpCustomRangeField(40, new global::Features.Converters.UnpackFactorDblAndPackFactorDblWith10ForCustomRange(), this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝ꓟ诡菣迥鳧诩胫꣭싯꛱냳믵맷볹軻鿽淿朁圃缅昇椉下䬍䈏䘑簓搕紗椙琛焝䰟䘡笣朥ᤧᤩᔫᠭ", a_), global::CommonResources.AcgResources.ID_X2TDMAFRAMESYNCBERTHRESHOLD, 0, 254, 1, global::CommonResources.AcgResources.ID_DISABLED, null);
			this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.DataTransferOrder = 81;
			this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("郓뿕뿗동꣛뿝賟", a_);
			base.Id = 10159;
			base.UIName = global::CommonResources.AcgResources.ID_DIGITAL;
			base.DataTransferOrder = 11;
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x000CFF88 File Offset: 0x000CE188
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)1908408321;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛髝觟藡跣鋥觧蛩ꓫ蟭韯髱냳鏵軷鏹鷻諽槿洁樃刅瀇唉䴋㼍⤏ℑ┓∕", a_)))
					{
						num = (short)353042436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B9;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_85;
					}
					continue;
				case 2:
					goto IL_3BF;
				case 3:
					num = (short)1483079690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.trkSysDigitalHighDeviationTx_A19314 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛髝觟藡跣鋥觧蛩ꓫ蟭韯髱냳鏵軷鏹鷻諽槿洁樃刅瀇唉䴋㼍⤏ℑ┓∕", a_), global::CommonResources.AcgResources.ID_HIGHDEVIATIONTX);
					this.trkSysDigitalHighDeviationTx_A19314.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkSysDigitalHighDeviationTx_A19314.DataTransferOrder = 47;
					num = (short)1422262280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_A8;
				case 6:
					num = (short)1195245579;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛髝觟藡跣鋥觧蛩꣫蟭韯鯱胳韵铷럹鏻髽痿渁攃爅朇砉堋眍怏眑䬓圕⼗∙⤛☝", a_)))
					{
						num = (short)1352400911;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_372;
				case 8:
					goto IL_1B9;
				case 9:
				{
					num = (short)1512820203;
					short num3 = num;
					num = (short)1800916459;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_36D;
					default:
						num = (short)2131165184;
						if (num != 0)
						{
						}
						this.trkSysDigitalAdaptivePower_A7509 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛髝觟藡跣鋥觧蛩귫諭釯英胳鿵軷鿹곻釽矿朁瘃夅䤇㴉㤋㸍⤏", a_), global::CommonResources.AcgResources.ID_ADAPTIVEPOWER);
						this.trkSysDigitalAdaptivePower_A7509.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
						this.trkSysDigitalAdaptivePower_A7509.DataTransferOrder = 34;
						num = (short)1273888770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛髝觟藡跣鋥觧蛩귫諭釯英胳鿵軷鿹곻釽矿朁瘃夅䤇㴉㤋㸍⤏", a_)))
					{
						num = (short)633470985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3BF;
				case 11:
					if (producerFields != null)
					{
						num = (short)1943601152;
						short num4 = num;
						num = (short)1420034051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_592;
				case 12:
					goto IL_372;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛髝觟藡跣鋥觧蛩볫鳭闯鏱駳铵铷鿹냻鯽滿攁瀃清圇䬉㐋㤍∏‑", a_)))
					{
						num = (short)522649621;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A8;
				case 14:
					this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159 = new global::AcpBusinessLayer.AcpCustomRangeField(40, new global::Features.Converters.UnpackFactorDblAndPackFactorDblWith10ForCustomRange(), this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛髝觟藡跣鋥觧蛩ꫫꫭ뷯돱닳蓵駷韹駻귽秿氁會䠅䄇三下䬍䈏䘑簓搕紗椙琛焝䰟䘡笣朥ဧᬩᤫᜭ", a_), global::CommonResources.AcgResources.ID_FDMAFRAMESYNCNIDBERTHRESHOLD, global::CommonResources.AcgResources.ID_DISABLED, null);
					this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.DataTransferOrder = 59;
					this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.ShowHexValue = false;
					num = (short)1237909520;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					this.trkSysDigitalDigitalModulatorType_A7858 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛髝觟藡跣鋥觧蛩꣫蟭韯鯱胳韵铷럹鏻髽痿渁攃爅朇砉堋眍怏眑䬓圕⼗∙⤛☝", a_), global::CommonResources.AcgResources.ID_DIGITALMODULATORTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysDigitalDigitalModulatorType_A7858LovStrs);
					this.trkSysDigitalDigitalModulatorType_A7858.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysDigitalDigitalModulatorType_A7858.DataTransferOrder = 29;
					num = (short)2008875009;
					if (num != 0)
					{
					}
					num = (short)695795724;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					goto IL_45E;
				case 17:
					goto IL_36D;
				case 18:
					this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396 = new global::AcpBusinessLayer.AcpCustomRangeField(40, new global::Features.Converters.UnpackFactorDblAndPackFactorDblWith10ForCustomRange(), this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛髝觟藡跣鋥觧蛩ꫫ\udcedꓯ뛱맳럵뻷裹鷻鏽旿儁紃栅欇䠉䤋對䐏稑易猕欗爙猛爝䐟紡攣ᜥᬧጩᨫ", a_), global::CommonResources.AcgResources.ID_X2TDMAFRAMESYNCBERTHRESHOLD, global::CommonResources.AcgResources.ID_DISABLED, null);
					this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.DataTransferOrder = 81;
					this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.ShowHexValue = false;
					num = (short)1656619025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛髝觟藡跣鋥觧蛩ꫫ\udcedꓯ뛱맳럵뻷裹鷻鏽旿儁紃栅欇䠉䤋對䐏稑易猕欗爙猛爝䐟紡攣ᜥᬧጩᨫ", a_)))
					{
						num = (short)1637810194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_592;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛髝觟藡跣鋥觧蛩ꫫꫭ뷯돱닳蓵駷韹駻귽秿氁會䠅䄇三下䬍䈏䘑簓搕紗椙琛焝䰟䘡笣朥ဧᬩᤫᜭ", a_)))
					{
						num = (short)1774649358;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_45E;
				case 21:
					this.trkSysDigitalPreambleLength_A8722 = new global::AcpBusinessLayer.AcpSimpleRangeField(120, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛髝觟藡跣鋥觧蛩볫鳭闯鏱駳铵铷鿹냻鯽滿攁瀃清圇䬉㐋㤍∏‑", a_), global::CommonResources.AcgResources.ID_PREAMBLELENGTH, null, null, 0, 1);
					this.trkSysDigitalPreambleLength_A8722.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkSysDigitalPreambleLength_A8722.DataTransferOrder = 44;
					this.trkSysDigitalPreambleLength_A8722.ShowHexValue = false;
					num = (short)1264648197;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_85:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)704577542;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A8:
				num = (short)274202624;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B9:
				num = (short)1013383187;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_372:
				num = (short)100728852;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3BF:
				num = (short)1661403143;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_45E:
				num = (short)959512589;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_36D:
			IL_592:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("雑뷓뇕뇗껙뷛닝", a_);
			base.Id = 10159;
			base.UIName = global::CommonResources.AcgResources.ID_DIGITAL;
			base.DataTransferOrder = 11;
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x000D055C File Offset: 0x000CE75C
		public override void PopulateReferences()
		{
			short num = (short)1678171582;
			short num2 = num;
			num = (short)1528356286;
			switch (num2 == num)
			{
			default:
			{
				num = (short)640286720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1492647937;
			if (num != 0)
			{
			}
			num = (short)238157824;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x000D0604 File Offset: 0x000CE804
		public override void DropReferences()
		{
			short num = (short)825276805;
			short num2 = num;
			num = (short)629782917;
			switch (num2 == num)
			{
			default:
			{
				num = (short)561053696;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1645412353;
			if (num != 0)
			{
			}
			num = (short)274268160;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x000D06AC File Offset: 0x000CE8AC
		public override void SetConstraints()
		{
			short num = (short)465598529;
			short num2 = num;
			num = (short)220690497;
			switch (num2 == num)
			{
			default:
			{
				num = (short)546177024;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)584187905;
			if (num != 0)
			{
			}
			num = (short)1329070080;
			if (num != 0)
			{
			}
			this.trkSysDigitalAdaptivePower_A7509.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTxPwrSelIsHigh);
			this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysAmssSelIsSmartZone);
			this.trkSysDigitalHighDeviationTx_A19314.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsII);
			this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConIsTDMAFrameSyncBERThresholdApplicable);
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x000D07B4 File Offset: 0x000CE9B4
		public override void SetupDependencies()
		{
			short num = (short)1897260647;
			short num2 = num;
			num = (short)2023679591;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1136066560;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1834418177;
			if (num != 0)
			{
			}
			num = (short)1103167488;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
			trunkingSystem.Features.TrkSysFeaturesTxPowerLevel_A9557.AddDependentObject(this.trkSysDigitalAdaptivePower_A7509);
			trunkingSystem.General.TrkSysGeneralCoverageType_A7782.AddDependentObject(this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysDigitalHighDeviationTx_A19314);
			trunkingSystem.ASTRO26.TrkSysASTRO25F2VoiceCapable_A1395.AddDependentObject(this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396);
			trunkingSystem.ASTRO26.TrkSysASTRO25Phase2VoiceCapable_A37972.AddDependentObject(this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396);
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06000C82 RID: 3202 RVA: 0x000D08F4 File Offset: 0x000CEAF4
		public bool HasDiffs
		{
			get
			{
				short num = (short)1626812702;
				short num2 = num;
				num = (short)629354782;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1818820608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)852164608;
				if (num != 0)
				{
				}
				num = (short)435748865;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x000D09A4 File Offset: 0x000CEBA4
		// (set) Token: 0x06000C84 RID: 3204 RVA: 0x000D0A58 File Offset: 0x000CEC58
		public bool TrkSysDigitalAdaptivePower_A7509Value
		{
			get
			{
				short num = (short)816252371;
				short num2 = num;
				num = (short)144115155;
				switch (num2 == num)
				{
				default:
				{
					num = (short)7405568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1123614720;
				if (num != 0)
				{
				}
				num = (short)972619777;
				if (num != 0)
				{
				}
				return this.trkSysDigitalAdaptivePower_A7509.Value;
			}
			set
			{
				short num = (short)689648519;
				short num2 = num;
				num = (short)1311126407;
				switch (num2 == num)
				{
				default:
				{
					num = (short)19398656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1047527425;
				if (num != 0)
				{
				}
				num = (short)1892614144;
				if (num != 0)
				{
				}
				this.trkSysDigitalAdaptivePower_A7509.Value = value;
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x000D0B0C File Offset: 0x000CED0C
		public global::AcpBusinessLayer.AcpField<bool> TrkSysDigitalAdaptivePower_A7509
		{
			get
			{
				short num = (short)2115455363;
				short num2 = num;
				num = (short)1977174403;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1239220224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)913965057;
				if (num != 0)
				{
				}
				num = (short)2032074752;
				if (num != 0)
				{
				}
				return this.trkSysDigitalAdaptivePower_A7509;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06000C86 RID: 3206 RVA: 0x000D0BBC File Offset: 0x000CEDBC
		// (set) Token: 0x06000C87 RID: 3207 RVA: 0x000D0C70 File Offset: 0x000CEE70
		public bool TrkSysDigitalAdaptivePower_A7509_UIValue
		{
			get
			{
				short num = (short)1887691186;
				short num2 = num;
				num = (short)1330373042;
				switch (num2 == num)
				{
				}
				num = (short)167903232;
				if (num != 0)
				{
				}
				num = (short)357367809;
				if (num != 0)
				{
				}
				num = (short)1275854848;
				short num3 = num;
				return this.trkSysDigitalAdaptivePower_A7509.Value;
			}
			set
			{
				short num = (short)1241109879;
				short num2 = num;
				num = (short)742249847;
				switch (num2 == num)
				{
				}
				num = (short)878313472;
				if (num != 0)
				{
				}
				num = (short)480903169;
				if (num != 0)
				{
				}
				num = (short)1844707328;
				short num3 = num;
				this.trkSysDigitalAdaptivePower_A7509.Value = value;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06000C88 RID: 3208 RVA: 0x000D0D24 File Offset: 0x000CEF24
		// (set) Token: 0x06000C89 RID: 3209 RVA: 0x000D0DD8 File Offset: 0x000CEFD8
		public bool TrkSysDigitalAdaptivePower_A7509_Applicable
		{
			get
			{
				short num = (short)891829675;
				short num2 = num;
				num = (short)645217707;
				switch (num2 == num)
				{
				}
				num = (short)666042369;
				if (num != 0)
				{
				}
				num = (short)1513422848;
				if (num != 0)
				{
				}
				num = (short)1680080896;
				short num3 = num;
				return this.trkSysDigitalAdaptivePower_A7509.Applicable;
			}
			set
			{
				short num = (short)853331612;
				short num2 = num;
				num = (short)1049349788;
				switch (num2 == num)
				{
				}
				num = (short)1930231809;
				if (num != 0)
				{
				}
				num = (short)241369088;
				if (num != 0)
				{
				}
				num = (short)1997340672;
				short num3 = num;
				this.trkSysDigitalAdaptivePower_A7509.Applicable = value;
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06000C8A RID: 3210 RVA: 0x000D0E90 File Offset: 0x000CF090
		// (set) Token: 0x06000C8B RID: 3211 RVA: 0x000D0F48 File Offset: 0x000CF148
		public bool TrkSysDigitalAdaptivePower_A7509_Valid
		{
			get
			{
				short num = (short)908906196;
				short num2 = num;
				num = (short)2031734484;
				switch (num2 == num)
				{
				}
				num = (short)1744896000;
				if (num != 0)
				{
				}
				num = (short)1736769537;
				if (num != 0)
				{
				}
				num = (short)1440546816;
				short num3 = num;
				return this.trkSysDigitalAdaptivePower_A7509.Valid;
			}
			set
			{
				short num = (short)1086128129;
				if (num != 0)
				{
				}
				num = (short)109180299;
				short num2 = num;
				num = (short)503838091;
				switch (num2 == num)
				{
				}
				num = (short)801177600;
				if (num != 0)
				{
				}
				num = (short)556204032;
				short num3 = num;
				this.trkSysDigitalAdaptivePower_A7509.Valid = value;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06000C8C RID: 3212 RVA: 0x000D1000 File Offset: 0x000CF200
		// (set) Token: 0x06000C8D RID: 3213 RVA: 0x000D10B4 File Offset: 0x000CF2B4
		public bool TrkSysDigitalAdaptivePower_A7509_Visible
		{
			get
			{
				short num = (short)488480096;
				short num2 = num;
				num = (short)130456928;
				switch (num2 == num)
				{
				}
				num = (short)29687809;
				if (num != 0)
				{
				}
				num = (short)1592131584;
				if (num != 0)
				{
				}
				num = (short)676724736;
				short num3 = num;
				return this.trkSysDigitalAdaptivePower_A7509.Visible;
			}
			set
			{
				short num = (short)1438803996;
				short num2 = num;
				num = (short)1865377820;
				switch (num2 == num)
				{
				}
				num = (short)1526071297;
				if (num != 0)
				{
				}
				num = (short)548143104;
				if (num != 0)
				{
				}
				num = (short)1893007360;
				short num3 = num;
				this.trkSysDigitalAdaptivePower_A7509.Visible = value;
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06000C8E RID: 3214 RVA: 0x000D1168 File Offset: 0x000CF368
		// (set) Token: 0x06000C8F RID: 3215 RVA: 0x000D121C File Offset: 0x000CF41C
		public bool TrkSysDigitalAdaptivePower_A7509_Editable
		{
			get
			{
				short num = (short)1879965697;
				if (num != 0)
				{
				}
				num = (short)85631905;
				short num2 = num;
				num = (short)701670305;
				switch (num2 == num)
				{
				}
				num = (short)1784414208;
				if (num != 0)
				{
				}
				num = (short)819724288;
				short num3 = num;
				return this.trkSysDigitalAdaptivePower_A7509.Editable;
			}
			set
			{
				short num = (short)1891742874;
				short num2 = num;
				num = (short)225752218;
				switch (num2 == num)
				{
				}
				num = (short)1911750657;
				if (num != 0)
				{
				}
				num = (short)560005120;
				if (num != 0)
				{
				}
				num = (short)448987136;
				short num3 = num;
				this.trkSysDigitalAdaptivePower_A7509.Editable = value;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x000D12D4 File Offset: 0x000CF4D4
		internal string TrkSysDigitalAdaptivePower_A7509_UILabel
		{
			get
			{
				short num = (short)556231435;
				short num2 = num;
				num = (short)1209821963;
				switch (num2 == num)
				{
				}
				num = (short)1125187585;
				if (num != 0)
				{
				}
				num = (short)1350565888;
				if (num != 0)
				{
				}
				num = (short)42336256;
				short num3 = num;
				return this.trkSysDigitalAdaptivePower_A7509.UIName;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x000D138C File Offset: 0x000CF58C
		// (set) Token: 0x06000C92 RID: 3218 RVA: 0x000D1440 File Offset: 0x000CF640
		internal bool TrkSysDigitalAdaptivePower_A7509_HiddenStatic
		{
			get
			{
				short num = (short)1856962561;
				if (num != 0)
				{
				}
				num = (short)1469762370;
				short num2 = num;
				num = (short)855034690;
				switch (num2 == num)
				{
				}
				num = (short)870580224;
				if (num != 0)
				{
				}
				num = (short)279314432;
				short num3 = num;
				return this.trkSysDigitalAdaptivePower_A7509.HiddenStatic;
			}
			set
			{
				short num = (short)2081010230;
				short num2 = num;
				num = (short)710324790;
				switch (num2 == num)
				{
				}
				num = (short)647954433;
				if (num != 0)
				{
				}
				num = (short)89456640;
				if (num != 0)
				{
				}
				num = (short)404946944;
				short num3 = num;
				this.trkSysDigitalAdaptivePower_A7509.HiddenStatic = value;
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x000D14F4 File Offset: 0x000CF6F4
		// (set) Token: 0x06000C94 RID: 3220 RVA: 0x000D15A8 File Offset: 0x000CF7A8
		internal bool TrkSysDigitalAdaptivePower_A7509_HiddenDynamic
		{
			get
			{
				short num = (short)2142387290;
				short num2 = num;
				num = (short)1285700698;
				switch (num2 == num)
				{
				}
				num = (short)778698752;
				if (num != 0)
				{
				}
				num = (short)897318913;
				if (num != 0)
				{
				}
				num = (short)432996352;
				short num3 = num;
				return this.trkSysDigitalAdaptivePower_A7509.HiddenDynamic;
			}
			set
			{
				short num = (short)1975451649;
				if (num != 0)
				{
				}
				num = (short)938128801;
				short num2 = num;
				num = (short)906081697;
				switch (num2 == num)
				{
				}
				num = (short)2068185088;
				if (num != 0)
				{
				}
				num = (short)230752256;
				short num3 = num;
				this.trkSysDigitalAdaptivePower_A7509.HiddenDynamic = value;
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x000D1660 File Offset: 0x000CF860
		public bool TrkSysDigitalAdaptivePower_A7509_HasDiffs
		{
			get
			{
				short num = (short)1911462650;
				short num2 = num;
				num = (short)383228666;
				switch (num2 == num)
				{
				}
				num = (short)235864065;
				if (num != 0)
				{
				}
				num = (short)666435584;
				if (num != 0)
				{
				}
				num = (short)1629290496;
				short num3 = num;
				return this.trkSysDigitalAdaptivePower_A7509._HasDiffs;
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x000D1714 File Offset: 0x000CF914
		// (set) Token: 0x06000C97 RID: 3223 RVA: 0x000D17CC File Offset: 0x000CF9CC
		public int TrkSysDigitalDigitalModulatorType_A7858Value
		{
			get
			{
				short num = (short)970363760;
				short num2 = num;
				num = (short)1918079856;
				switch (num2 == num)
				{
				}
				num = (short)846594049;
				if (num != 0)
				{
				}
				num = (short)1763639296;
				if (num != 0)
				{
				}
				num = (short)1763704832;
				short num3 = num;
				return this.trkSysDigitalDigitalModulatorType_A7858.Value;
			}
			set
			{
				short num = (short)436978137;
				short num2 = num;
				num = (short)242139609;
				switch (num2 == num)
				{
				}
				num = (short)1031340032;
				if (num != 0)
				{
				}
				num = (short)2102263809;
				if (num != 0)
				{
				}
				num = (short)654049280;
				short num3 = num;
				this.trkSysDigitalDigitalModulatorType_A7858.Value = value;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x000D1884 File Offset: 0x000CFA84
		// (set) Token: 0x06000C99 RID: 3225 RVA: 0x000D1938 File Offset: 0x000CFB38
		public string TrkSysDigitalDigitalModulatorType_A7858_UIValue
		{
			get
			{
				short num = (short)1357668281;
				short num2 = num;
				num = (short)2116771769;
				switch (num2 == num)
				{
				}
				num = (short)491061248;
				if (num != 0)
				{
				}
				num = (short)988020737;
				if (num != 0)
				{
				}
				num = (short)1342504960;
				short num3 = num;
				return this.trkSysDigitalDigitalModulatorType_A7858.UIValue;
			}
			set
			{
				short num = (short)883455544;
				short num2 = num;
				num = (short)37320248;
				switch (num2 == num)
				{
				}
				num = (short)1931870208;
				if (num != 0)
				{
				}
				num = (short)180355073;
				if (num != 0)
				{
				}
				num = (short)1066729472;
				short num3 = num;
				this.trkSysDigitalDigitalModulatorType_A7858.UIValue = value;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06000C9A RID: 3226 RVA: 0x000D19EC File Offset: 0x000CFBEC
		public global::AcpBusinessLayer.AcpListField TrkSysDigitalDigitalModulatorType_A7858
		{
			get
			{
				short num = (short)1906371674;
				short num2 = num;
				num = (short)1649273946;
				switch (num2 == num)
				{
				}
				num = (short)186843136;
				if (num != 0)
				{
				}
				num = (short)48693249;
				if (num != 0)
				{
				}
				num = (short)98172928;
				short num3 = num;
				return this.trkSysDigitalDigitalModulatorType_A7858;
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x000D1AA0 File Offset: 0x000CFCA0
		// (set) Token: 0x06000C9C RID: 3228 RVA: 0x000D1B58 File Offset: 0x000CFD58
		public bool TrkSysDigitalDigitalModulatorType_A7858_Applicable
		{
			get
			{
				short num = (short)1541603329;
				if (num != 0)
				{
				}
				num = (short)1956519423;
				short num2 = num;
				num = (short)528489983;
				switch (num2 == num)
				{
				}
				num = (short)1505492992;
				if (num != 0)
				{
				}
				num = (short)1623654400;
				short num3 = num;
				return this.trkSysDigitalDigitalModulatorType_A7858.Applicable;
			}
			set
			{
				short num = (short)529072129;
				if (num != 0)
				{
				}
				num = (short)1740760492;
				short num2 = num;
				num = (short)1797842348;
				switch (num2 == num)
				{
				}
				num = (short)1037762560;
				if (num != 0)
				{
				}
				num = (short)233439232;
				short num3 = num;
				this.trkSysDigitalDigitalModulatorType_A7858.Applicable = value;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x000D1C10 File Offset: 0x000CFE10
		// (set) Token: 0x06000C9E RID: 3230 RVA: 0x000D1CC4 File Offset: 0x000CFEC4
		public bool TrkSysDigitalDigitalModulatorType_A7858_Valid
		{
			get
			{
				short num = (short)1968370132;
				short num2 = num;
				num = (short)1373434324;
				switch (num2 == num)
				{
				}
				num = (short)1069613057;
				if (num != 0)
				{
				}
				num = (short)1713963008;
				if (num != 0)
				{
				}
				num = (short)969474048;
				short num3 = num;
				return this.trkSysDigitalDigitalModulatorType_A7858.Valid;
			}
			set
			{
				short num = (short)372263569;
				short num2 = num;
				num = (short)1434602129;
				switch (num2 == num)
				{
				}
				num = (short)1611137025;
				if (num != 0)
				{
				}
				num = (short)1616904192;
				if (num != 0)
				{
				}
				num = (short)1012727808;
				short num3 = num;
				this.trkSysDigitalDigitalModulatorType_A7858.Valid = value;
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x000D1D78 File Offset: 0x000CFF78
		// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x000D1E30 File Offset: 0x000D0030
		public bool TrkSysDigitalDigitalModulatorType_A7858_Visible
		{
			get
			{
				short num = (short)1655227540;
				short num2 = num;
				num = (short)289391764;
				switch (num2 == num)
				{
				}
				num = (short)217972736;
				if (num != 0)
				{
				}
				num = (short)1281359873;
				if (num != 0)
				{
				}
				num = (short)1167392768;
				short num3 = num;
				return this.trkSysDigitalDigitalModulatorType_A7858.Visible;
			}
			set
			{
				short num = (short)124551623;
				short num2 = num;
				num = (short)2130608583;
				switch (num2 == num)
				{
				default:
				{
					num = (short)681115648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)566034433;
				if (num != 0)
				{
				}
				num = (short)1418723328;
				if (num != 0)
				{
				}
				this.trkSysDigitalDigitalModulatorType_A7858.Visible = value;
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x000D1EE8 File Offset: 0x000D00E8
		// (set) Token: 0x06000CA2 RID: 3234 RVA: 0x000D1F9C File Offset: 0x000D019C
		public bool TrkSysDigitalDigitalModulatorType_A7858_Editable
		{
			get
			{
				short num = (short)2118937732;
				short num2 = num;
				num = (short)1307208836;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1244397568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)634388481;
				if (num != 0)
				{
				}
				num = (short)927531008;
				if (num != 0)
				{
				}
				return this.trkSysDigitalDigitalModulatorType_A7858.Editable;
			}
			set
			{
				short num = (short)1247257793;
				short num2 = num;
				num = (short)1210819777;
				switch (num2 == num)
				{
				default:
				{
					num = (short)100597760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1382481921;
				if (num != 0)
				{
				}
				num = (short)114884608;
				if (num != 0)
				{
				}
				this.trkSysDigitalDigitalModulatorType_A7858.Editable = value;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x000D2054 File Offset: 0x000D0254
		internal string TrkSysDigitalDigitalModulatorType_A7858_UILabel
		{
			get
			{
				short num = (short)2029715457;
				if (num != 0)
				{
				}
				num = (short)1633484800;
				short num2 = num;
				num = (short)1764076445;
				short num3 = num;
				num = (short)1743235997;
				switch (num3 == num)
				{
				}
				num = (short)1996554240;
				if (num != 0)
				{
				}
				return this.trkSysDigitalDigitalModulatorType_A7858.UIName;
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x000D210C File Offset: 0x000D030C
		// (set) Token: 0x06000CA5 RID: 3237 RVA: 0x000D21BC File Offset: 0x000D03BC
		internal bool TrkSysDigitalDigitalModulatorType_A7858_HiddenStatic
		{
			get
			{
				short num = (short)557888209;
				short num2 = num;
				num = (short)1778365137;
				switch (num2 == num)
				{
				default:
				{
					num = (short)564789248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1113587713;
				if (num != 0)
				{
				}
				num = (short)578813952;
				if (num != 0)
				{
				}
				return this.trkSysDigitalDigitalModulatorType_A7858.HiddenStatic;
			}
			set
			{
				short num = (short)933281827;
				short num2 = num;
				num = (short)1570488355;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2067398656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)771817472;
				if (num != 0)
				{
				}
				num = (short)1559625729;
				if (num != 0)
				{
				}
				this.trkSysDigitalDigitalModulatorType_A7858.HiddenStatic = value;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x000D2270 File Offset: 0x000D0470
		// (set) Token: 0x06000CA7 RID: 3239 RVA: 0x000D2324 File Offset: 0x000D0524
		internal bool TrkSysDigitalDigitalModulatorType_A7858_HiddenDynamic
		{
			get
			{
				short num = (short)1042546689;
				if (num != 0)
				{
				}
				num = (short)360120320;
				short num2 = num;
				num = (short)387238781;
				short num3 = num;
				num = (short)744082301;
				switch (num3 == num)
				{
				}
				num = (short)1162280960;
				if (num != 0)
				{
				}
				return this.trkSysDigitalDigitalModulatorType_A7858.HiddenDynamic;
			}
			set
			{
				short num = (short)1326841857;
				if (num != 0)
				{
				}
				num = (short)79626240;
				short num2 = num;
				num = (short)183644971;
				short num3 = num;
				num = (short)1116287787;
				switch (num3 == num)
				{
				}
				num = (short)479920128;
				if (num != 0)
				{
				}
				this.trkSysDigitalDigitalModulatorType_A7858.HiddenDynamic = value;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x000D23D8 File Offset: 0x000D05D8
		public bool TrkSysDigitalDigitalModulatorType_A7858_HasDiffs
		{
			get
			{
				short num = (short)1467158316;
				short num2 = num;
				num = (short)504565548;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1616904192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1012269057;
				if (num != 0)
				{
				}
				num = (short)2140274688;
				if (num != 0)
				{
				}
				return this.trkSysDigitalDigitalModulatorType_A7858._HasDiffs;
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x000D2490 File Offset: 0x000D0690
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x000D2544 File Offset: 0x000D0744
		public int TrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159Value
		{
			get
			{
				short num = (short)1271671569;
				short num2 = num;
				num = (short)451554065;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1699807232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1717108736;
				if (num != 0)
				{
				}
				num = (short)855572481;
				if (num != 0)
				{
				}
				return this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.Value;
			}
			set
			{
				short num = (short)1440763651;
				short num2 = num;
				num = (short)1158762243;
				switch (num2 == num)
				{
				default:
				{
					num = (short)7798784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)138543105;
				if (num != 0)
				{
				}
				num = (short)142213120;
				if (num != 0)
				{
				}
				this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.Value = value;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x000D25FC File Offset: 0x000D07FC
		public global::AcpBusinessLayer.AcpCustomRangeField TrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159
		{
			get
			{
				short num = (short)50386486;
				short num2 = num;
				num = (short)828692022;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1711013888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1690107905;
				if (num != 0)
				{
				}
				num = (short)1244397568;
				if (num != 0)
				{
				}
				return this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x000D26AC File Offset: 0x000D08AC
		// (set) Token: 0x06000CAD RID: 3245 RVA: 0x000D2760 File Offset: 0x000D0960
		public string TrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159_UIValue
		{
			get
			{
				short num = (short)649917818;
				short num2 = num;
				num = (short)1934030202;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1529806848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)868614144;
				if (num != 0)
				{
				}
				num = (short)1973026817;
				if (num != 0)
				{
				}
				return this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.UIValue;
			}
			set
			{
				short num = (short)1102393881;
				short num2 = num;
				num = (short)50410009;
				switch (num2 == num)
				{
				}
				num = (short)1504968705;
				if (num != 0)
				{
				}
				num = (short)1556021248;
				short num3 = num;
				num = (short)692125696;
				if (num != 0)
				{
				}
				this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.UIValue = value;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06000CAE RID: 3246 RVA: 0x000D2818 File Offset: 0x000D0A18
		// (set) Token: 0x06000CAF RID: 3247 RVA: 0x000D28D0 File Offset: 0x000D0AD0
		internal int TrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159Min
		{
			get
			{
				short num = (short)2076276339;
				short num2 = num;
				num = (short)729314931;
				switch (num2 == num)
				{
				}
				num = (short)2949121;
				if (num != 0)
				{
				}
				num = (short)1844248576;
				short num3 = num;
				num = (short)1802698752;
				if (num != 0)
				{
				}
				return this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.Min;
			}
			set
			{
				short num = (short)516400138;
				short num2 = num;
				num = (short)1348576266;
				switch (num2 == num)
				{
				}
				num = (short)267124737;
				if (num != 0)
				{
				}
				num = (short)588447744;
				short num3 = num;
				num = (short)1760231424;
				if (num != 0)
				{
				}
				this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.Min = value;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x000D2988 File Offset: 0x000D0B88
		// (set) Token: 0x06000CB1 RID: 3249 RVA: 0x000D2A3C File Offset: 0x000D0C3C
		internal int TrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159Max
		{
			get
			{
				short num = (short)1456680255;
				short num2 = num;
				num = (short)910437695;
				switch (num2 == num)
				{
				}
				num = (short)1266679808;
				if (num != 0)
				{
				}
				num = (short)770310144;
				short num3 = num;
				num = (short)857014273;
				if (num != 0)
				{
				}
				return this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.Max;
			}
			set
			{
				short num = (short)1035599873;
				if (num != 0)
				{
				}
				num = (short)919440929;
				short num2 = num;
				num = (short)1919389217;
				switch (num2 == num)
				{
				}
				num = (short)209256448;
				short num3 = num;
				num = (short)1277100032;
				if (num != 0)
				{
				}
				this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.Max = value;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x000D2AF0 File Offset: 0x000D0CF0
		// (set) Token: 0x06000CB3 RID: 3251 RVA: 0x000D2BA8 File Offset: 0x000D0DA8
		internal int TrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159Step
		{
			get
			{
				short num = (short)1563492353;
				if (num != 0)
				{
				}
				num = (short)933065259;
				short num2 = num;
				num = (short)827159083;
				switch (num2 == num)
				{
				}
				num = (short)1402929152;
				short num3 = num;
				num = (short)1756168192;
				if (num != 0)
				{
				}
				return this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.StepSize;
			}
			set
			{
				short num = (short)2065681914;
				short num2 = num;
				num = (short)1659686394;
				switch (num2 == num)
				{
				}
				num = (short)310444032;
				if (num != 0)
				{
				}
				num = (short)1305346048;
				short num3 = num;
				num = (short)573046785;
				if (num != 0)
				{
				}
				this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.StepSize = value;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x000D2C60 File Offset: 0x000D0E60
		// (set) Token: 0x06000CB5 RID: 3253 RVA: 0x000D2D14 File Offset: 0x000D0F14
		public bool TrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159_Applicable
		{
			get
			{
				short num = (short)88349621;
				short num2 = num;
				num = (short)759241653;
				switch (num2 == num)
				{
				}
				num = (short)900726785;
				if (num != 0)
				{
				}
				num = (short)1936457728;
				short num3 = num;
				num = (short)1024720896;
				if (num != 0)
				{
				}
				return this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.Applicable;
			}
			set
			{
				short num = (short)1901371748;
				short num2 = num;
				num = (short)1204658532;
				switch (num2 == num)
				{
				}
				num = (short)1243873281;
				if (num != 0)
				{
				}
				num = (short)583532544;
				short num3 = num;
				num = (short)1959526400;
				if (num != 0)
				{
				}
				this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.Applicable = value;
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x000D2DC8 File Offset: 0x000D0FC8
		// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x000D2E80 File Offset: 0x000D1080
		public bool TrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159_Valid
		{
			get
			{
				short num = (short)1787364324;
				short num2 = num;
				num = (short)1210975204;
				switch (num2 == num)
				{
				}
				num = (short)546045953;
				if (num != 0)
				{
				}
				num = (short)393871360;
				short num3 = num;
				num = (short)342753280;
				if (num != 0)
				{
				}
				return this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.Valid;
			}
			set
			{
				short num = (short)1842928967;
				short num2 = num;
				num = (short)729668935;
				switch (num2 == num)
				{
				}
				num = (short)1415380992;
				if (num != 0)
				{
				}
				num = (short)1698627584;
				short num3 = num;
				num = (short)1487273985;
				if (num != 0)
				{
				}
				this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.Valid = value;
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x000D2F38 File Offset: 0x000D1138
		// (set) Token: 0x06000CB9 RID: 3257 RVA: 0x000D2FEC File Offset: 0x000D11EC
		public bool TrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159_Visible
		{
			get
			{
				short num = (short)293819127;
				short num2 = num;
				num = (short)1397641975;
				switch (num2 == num)
				{
				}
				num = (short)1254359040;
				if (num != 0)
				{
				}
				num = (short)1785790464;
				short num3 = num;
				num = (short)1251278849;
				if (num != 0)
				{
				}
				return this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.Visible;
			}
			set
			{
				short num = (short)1381920580;
				short num2 = num;
				num = (short)1221160772;
				switch (num2 == num)
				{
				}
				num = (short)32964608;
				if (num != 0)
				{
				}
				num = (short)1680211968;
				short num3 = num;
				num = (short)874053633;
				if (num != 0)
				{
				}
				this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.Visible = value;
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x000D30A0 File Offset: 0x000D12A0
		// (set) Token: 0x06000CBB RID: 3259 RVA: 0x000D3154 File Offset: 0x000D1354
		public bool TrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159_Editable
		{
			get
			{
				short num = (short)1694475801;
				short num2 = num;
				num = (short)1560454681;
				switch (num2 == num)
				{
				}
				num = (short)1045430272;
				if (num != 0)
				{
				}
				num = (short)404094976;
				short num3 = num;
				num = (short)569311233;
				if (num != 0)
				{
				}
				return this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.Editable;
			}
			set
			{
				short num = (short)238271822;
				short num2 = num;
				num = (short)1094499662;
				switch (num2 == num)
				{
				}
				num = (short)902168576;
				if (num != 0)
				{
				}
				num = (short)1643642880;
				short num3 = num;
				num = (short)626786305;
				if (num != 0)
				{
				}
				this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.Editable = value;
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x000D320C File Offset: 0x000D140C
		internal string TrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159_UILabel
		{
			get
			{
				short num = (short)2015452456;
				short num2 = num;
				num = (short)842226984;
				switch (num2 == num)
				{
				}
				num = (short)1413480449;
				if (num != 0)
				{
				}
				num = (short)1186529280;
				short num3 = num;
				num = (short)2002386944;
				if (num != 0)
				{
				}
				return this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.UIName;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x000D32C4 File Offset: 0x000D14C4
		// (set) Token: 0x06000CBE RID: 3262 RVA: 0x000D3378 File Offset: 0x000D1578
		internal bool TrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159_HiddenStatic
		{
			get
			{
				short num = (short)438223794;
				short num2 = num;
				num = (short)1040237490;
				switch (num2 == num)
				{
				}
				num = (short)1652359168;
				if (num != 0)
				{
				}
				num = (short)137953280;
				short num3 = num;
				num = (short)2019426305;
				if (num != 0)
				{
				}
				return this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.HiddenStatic;
			}
			set
			{
				short num = (short)698675146;
				short num2 = num;
				num = (short)732426186;
				switch (num2 == num)
				{
				}
				num = (short)221904896;
				if (num != 0)
				{
				}
				num = (short)797900800;
				short num3 = num;
				num = (short)545128449;
				if (num != 0)
				{
				}
				this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.HiddenStatic = value;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x000D3430 File Offset: 0x000D1630
		// (set) Token: 0x06000CC0 RID: 3264 RVA: 0x000D34E4 File Offset: 0x000D16E4
		internal bool TrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159_HiddenDynamic
		{
			get
			{
				short num = (short)1206668247;
				short num2 = num;
				num = (short)1925467095;
				switch (num2 == num)
				{
				}
				num = (short)1343946752;
				if (num != 0)
				{
				}
				num = (short)1073545216;
				short num3 = num;
				num = (short)1111949313;
				if (num != 0)
				{
				}
				return this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.HiddenDynamic;
			}
			set
			{
				short num = (short)2071823371;
				short num2 = num;
				num = (short)697336843;
				switch (num2 == num)
				{
				}
				num = (short)816971776;
				if (num != 0)
				{
				}
				num = (short)1440481280;
				short num3 = num;
				num = (short)293076993;
				if (num != 0)
				{
				}
				this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.HiddenDynamic = value;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x000D359C File Offset: 0x000D179C
		public bool TrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159_HasDiffs
		{
			get
			{
				short num = (short)77531711;
				short num2 = num;
				num = (short)486476351;
				switch (num2 == num)
				{
				}
				num = (short)1982267392;
				if (num != 0)
				{
				}
				num = (short)1845100544;
				short num3 = num;
				num = (short)394919937;
				if (num != 0)
				{
				}
				return this.trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159._HasDiffs;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x000D3650 File Offset: 0x000D1850
		// (set) Token: 0x06000CC3 RID: 3267 RVA: 0x000D3704 File Offset: 0x000D1904
		public int TrkSysDigitalPreambleLength_A8722Value
		{
			get
			{
				short num = (short)1091924932;
				short num2 = num;
				num = (short)757035972;
				switch (num2 == num)
				{
				}
				num = (short)628097025;
				if (num != 0)
				{
				}
				num = (short)1823670272;
				short num3 = num;
				num = (short)830734336;
				if (num != 0)
				{
				}
				return this.trkSysDigitalPreambleLength_A8722.Value;
			}
			set
			{
				short num = (short)51720412;
				short num2 = num;
				num = (short)2006855900;
				switch (num2 == num)
				{
				}
				num = (short)32702464;
				if (num != 0)
				{
				}
				num = (short)2037252096;
				short num3 = num;
				num = (short)56819713;
				if (num != 0)
				{
				}
				this.trkSysDigitalPreambleLength_A8722.Value = value;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x000D37C0 File Offset: 0x000D19C0
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysDigitalPreambleLength_A8722
		{
			get
			{
				short num = (short)979485531;
				short num2 = num;
				num = (short)1519502171;
				switch (num2 == num)
				{
				}
				num = (short)1749417985;
				if (num != 0)
				{
				}
				num = (short)1978204160;
				short num3 = num;
				num = (short)584712192;
				if (num != 0)
				{
				}
				return this.trkSysDigitalPreambleLength_A8722;
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x000D3870 File Offset: 0x000D1A70
		// (set) Token: 0x06000CC6 RID: 3270 RVA: 0x000D3928 File Offset: 0x000D1B28
		public string TrkSysDigitalPreambleLength_A8722_UIValue
		{
			get
			{
				short num = (short)554762241;
				if (num != 0)
				{
				}
				num = (short)73922564;
				short num2 = num;
				num = (short)2133915652;
				switch (num2 == num)
				{
				}
				num = (short)436535296;
				if (num != 0)
				{
				}
				num = (short)1081409536;
				short num3 = num;
				return this.trkSysDigitalPreambleLength_A8722.UIValue;
			}
			set
			{
				short num = (short)981598209;
				if (num != 0)
				{
				}
				num = (short)385745353;
				short num2 = num;
				num = (short)1783497161;
				switch (num2 == num)
				{
				}
				num = (short)131399680;
				if (num != 0)
				{
				}
				num = (short)827457536;
				short num3 = num;
				this.trkSysDigitalPreambleLength_A8722.UIValue = value;
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x000D39E0 File Offset: 0x000D1BE0
		// (set) Token: 0x06000CC8 RID: 3272 RVA: 0x000D3A94 File Offset: 0x000D1C94
		internal int TrkSysDigitalPreambleLength_A8722Min
		{
			get
			{
				short num = (short)1726327528;
				short num2 = num;
				num = (short)2043980520;
				switch (num2 == num)
				{
				}
				num = (short)1766129665;
				if (num != 0)
				{
				}
				num = (short)1412169728;
				if (num != 0)
				{
				}
				num = (short)1136984064;
				short num3 = num;
				return this.trkSysDigitalPreambleLength_A8722.Min;
			}
			set
			{
				short num = (short)2105212929;
				if (num != 0)
				{
				}
				num = (short)697630660;
				short num2 = num;
				num = (short)1431896004;
				switch (num2 == num)
				{
				}
				num = (short)813891584;
				if (num != 0)
				{
				}
				num = (short)1942749184;
				short num3 = num;
				this.trkSysDigitalPreambleLength_A8722.Min = value;
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x000D3B48 File Offset: 0x000D1D48
		// (set) Token: 0x06000CCA RID: 3274 RVA: 0x000D3BFC File Offset: 0x000D1DFC
		internal int TrkSysDigitalPreambleLength_A8722Max
		{
			get
			{
				short num = (short)713391882;
				short num2 = num;
				num = (short)327319306;
				switch (num2 == num)
				{
				}
				num = (short)1919287297;
				if (num != 0)
				{
				}
				num = (short)664666112;
				if (num != 0)
				{
				}
				num = (short)1342767104;
				short num3 = num;
				return this.trkSysDigitalPreambleLength_A8722.Max;
			}
			set
			{
				short num = (short)231931905;
				if (num != 0)
				{
				}
				num = (short)636693806;
				short num2 = num;
				num = (short)1422273838;
				switch (num2 == num)
				{
				}
				num = (short)253624320;
				if (num != 0)
				{
				}
				num = (short)19529728;
				short num3 = num;
				this.trkSysDigitalPreambleLength_A8722.Max = value;
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x000D3CB4 File Offset: 0x000D1EB4
		// (set) Token: 0x06000CCC RID: 3276 RVA: 0x000D3D6C File Offset: 0x000D1F6C
		internal int TrkSysDigitalPreambleLength_A8722Step
		{
			get
			{
				short num = (short)696748688;
				short num2 = num;
				num = (short)1999800976;
				switch (num2 == num)
				{
				}
				num = (short)2125266945;
				if (num != 0)
				{
				}
				num = (short)121438208;
				if (num != 0)
				{
				}
				num = (short)1690763264;
				short num3 = num;
				return this.trkSysDigitalPreambleLength_A8722.StepSize;
			}
			set
			{
				short num = (short)872500214;
				short num2 = num;
				num = (short)254561270;
				switch (num2 == num)
				{
				}
				num = (short)2146500609;
				if (num != 0)
				{
				}
				num = (short)935002112;
				if (num != 0)
				{
				}
				num = (short)1486880768;
				short num3 = num;
				this.trkSysDigitalPreambleLength_A8722.StepSize = value;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x000D3E24 File Offset: 0x000D2024
		// (set) Token: 0x06000CCE RID: 3278 RVA: 0x000D3ED8 File Offset: 0x000D20D8
		public bool TrkSysDigitalPreambleLength_A8722_Applicable
		{
			get
			{
				short num = (short)1879489849;
				short num2 = num;
				num = (short)870890809;
				switch (num2 == num)
				{
				}
				num = (short)1350631424;
				if (num != 0)
				{
				}
				num = (short)1462894593;
				if (num != 0)
				{
				}
				num = (short)934543360;
				short num3 = num;
				return this.trkSysDigitalPreambleLength_A8722.Applicable;
			}
			set
			{
				short num = (short)1031720030;
				short num2 = num;
				num = (short)762104926;
				switch (num2 == num)
				{
				}
				num = (short)1680670721;
				if (num != 0)
				{
				}
				num = (short)1134755840;
				if (num != 0)
				{
				}
				num = (short)144506880;
				short num3 = num;
				this.trkSysDigitalPreambleLength_A8722.Applicable = value;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x000D3F8C File Offset: 0x000D218C
		// (set) Token: 0x06000CD0 RID: 3280 RVA: 0x000D4040 File Offset: 0x000D2240
		public bool TrkSysDigitalPreambleLength_A8722_Valid
		{
			get
			{
				short num = (short)2121870752;
				short num2 = num;
				num = (short)255602080;
				switch (num2 == num)
				{
				}
				num = (short)1623916545;
				if (num != 0)
				{
				}
				num = (short)966131712;
				if (num != 0)
				{
				}
				num = (short)1290928128;
				short num3 = num;
				return this.trkSysDigitalPreambleLength_A8722.Valid;
			}
			set
			{
				short num = (short)608829381;
				short num2 = num;
				num = (short)1093074885;
				switch (num2 == num)
				{
				}
				num = (short)303890433;
				if (num != 0)
				{
				}
				num = (short)291962880;
				if (num != 0)
				{
				}
				num = (short)1346306048;
				short num3 = num;
				this.trkSysDigitalPreambleLength_A8722.Valid = value;
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x000D40F4 File Offset: 0x000D22F4
		// (set) Token: 0x06000CD2 RID: 3282 RVA: 0x000D41A8 File Offset: 0x000D23A8
		public bool TrkSysDigitalPreambleLength_A8722_Visible
		{
			get
			{
				short num = (short)1749829712;
				short num2 = num;
				num = (short)1595099216;
				switch (num2 == num)
				{
				}
				num = (short)1568669697;
				if (num != 0)
				{
				}
				num = (short)1190854656;
				if (num != 0)
				{
				}
				num = (short)864354304;
				short num3 = num;
				return this.trkSysDigitalPreambleLength_A8722.Visible;
			}
			set
			{
				short num = (short)197722113;
				if (num != 0)
				{
				}
				num = (short)2106585280;
				short num2 = num;
				num = (short)1889071296;
				switch (num2 == num)
				{
				}
				num = (short)14483456;
				if (num != 0)
				{
				}
				num = (short)339214336;
				short num3 = num;
				this.trkSysDigitalPreambleLength_A8722.Visible = value;
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x000D425C File Offset: 0x000D245C
		// (set) Token: 0x06000CD4 RID: 3284 RVA: 0x000D4310 File Offset: 0x000D2510
		public bool TrkSysDigitalPreambleLength_A8722_Editable
		{
			get
			{
				short num = (short)217601931;
				short num2 = num;
				num = (short)580081547;
				switch (num2 == num)
				{
				}
				num = (short)1913716736;
				short num3 = num;
				num = (short)88539136;
				if (num != 0)
				{
				}
				num = (short)561119233;
				if (num != 0)
				{
				}
				return this.trkSysDigitalPreambleLength_A8722.Editable;
			}
			set
			{
				short num = (short)351829929;
				short num2 = num;
				num = (short)1930854313;
				switch (num2 == num)
				{
				}
				num = (short)2131689472;
				short num3 = num;
				num = (short)1106575361;
				if (num != 0)
				{
				}
				num = (short)1228931072;
				if (num != 0)
				{
				}
				this.trkSysDigitalPreambleLength_A8722.Editable = value;
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x000D43C4 File Offset: 0x000D25C4
		internal string TrkSysDigitalPreambleLength_A8722_UILabel
		{
			get
			{
				short num = (short)1018395798;
				short num2 = num;
				num = (short)1530821782;
				switch (num2 == num)
				{
				}
				num = (short)1847853056;
				short num3 = num;
				num = (short)683016193;
				if (num != 0)
				{
				}
				num = (short)1759969280;
				if (num != 0)
				{
				}
				return this.trkSysDigitalPreambleLength_A8722.UIName;
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x000D447C File Offset: 0x000D267C
		// (set) Token: 0x06000CD7 RID: 3287 RVA: 0x000D4530 File Offset: 0x000D2730
		internal bool TrkSysDigitalPreambleLength_A8722_HiddenStatic
		{
			get
			{
				short num = (short)541698270;
				short num2 = num;
				num = (short)1397926110;
				switch (num2 == num)
				{
				}
				num = (short)656343040;
				short num3 = num;
				num = (short)768475137;
				if (num != 0)
				{
				}
				num = (short)1853816832;
				if (num != 0)
				{
				}
				return this.trkSysDigitalPreambleLength_A8722.HiddenStatic;
			}
			set
			{
				short num = (short)2087772258;
				short num2 = num;
				num = (short)1617092706;
				switch (num2 == num)
				{
				}
				num = (short)237109248;
				short num3 = num;
				num = (short)280494080;
				if (num != 0)
				{
				}
				num = (short)1454309377;
				if (num != 0)
				{
				}
				this.trkSysDigitalPreambleLength_A8722.HiddenStatic = value;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x000D45E4 File Offset: 0x000D27E4
		// (set) Token: 0x06000CD9 RID: 3289 RVA: 0x000D4698 File Offset: 0x000D2898
		internal bool TrkSysDigitalPreambleLength_A8722_HiddenDynamic
		{
			get
			{
				short num = (short)807626912;
				short num2 = num;
				num = (short)875391136;
				switch (num2 == num)
				{
				}
				num = (short)1059979264;
				short num3 = num;
				num = (short)855703553;
				if (num != 0)
				{
				}
				num = (short)1118240768;
				if (num != 0)
				{
				}
				return this.trkSysDigitalPreambleLength_A8722.HiddenDynamic;
			}
			set
			{
				short num = (short)1416284026;
				short num2 = num;
				num = (short)454018938;
				switch (num2 == num)
				{
				}
				num = (short)844627968;
				short num3 = num;
				num = (short)1504247809;
				if (num != 0)
				{
				}
				num = (short)493486080;
				if (num != 0)
				{
				}
				this.trkSysDigitalPreambleLength_A8722.HiddenDynamic = value;
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x000D4750 File Offset: 0x000D2950
		public bool TrkSysDigitalPreambleLength_A8722_HasDiffs
		{
			get
			{
				short num = (short)1822054565;
				short num2 = num;
				num = (short)1128618149;
				switch (num2 == num)
				{
				}
				num = (short)450035712;
				short num3 = num;
				num = (short)172621825;
				if (num != 0)
				{
				}
				num = (short)307822592;
				if (num != 0)
				{
				}
				return this.trkSysDigitalPreambleLength_A8722._HasDiffs;
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x000D4804 File Offset: 0x000D2A04
		// (set) Token: 0x06000CDC RID: 3292 RVA: 0x000D48B8 File Offset: 0x000D2AB8
		public bool TrkSysDigitalHighDeviationTx_A19314Value
		{
			get
			{
				short num = (short)897532812;
				short num2 = num;
				num = (short)1076904844;
				switch (num2 == num)
				{
				}
				num = (short)1768357888;
				short num3 = num;
				num = (short)615448576;
				if (num != 0)
				{
				}
				num = (short)536018945;
				if (num != 0)
				{
				}
				return this.trkSysDigitalHighDeviationTx_A19314.Value;
			}
			set
			{
				short num = (short)956045833;
				short num2 = num;
				num = (short)1122310665;
				switch (num2 == num)
				{
				}
				num = (short)1692270592;
				short num3 = num;
				num = (short)1315307520;
				if (num != 0)
				{
				}
				num = (short)42532865;
				if (num != 0)
				{
				}
				this.trkSysDigitalHighDeviationTx_A19314.Value = value;
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x000D496C File Offset: 0x000D2B6C
		public global::AcpBusinessLayer.AcpField<bool> TrkSysDigitalHighDeviationTx_A19314
		{
			get
			{
				short num = (short)1256459822;
				short num2 = num;
				num = (short)850726446;
				switch (num2 == num)
				{
				}
				num = (short)916193280;
				short num3 = num;
				num = (short)36372481;
				if (num != 0)
				{
				}
				num = (short)1520566272;
				if (num != 0)
				{
				}
				return this.trkSysDigitalHighDeviationTx_A19314;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x000D4A1C File Offset: 0x000D2C1C
		// (set) Token: 0x06000CDF RID: 3295 RVA: 0x000D4AD0 File Offset: 0x000D2CD0
		public bool TrkSysDigitalHighDeviationTx_A19314_UIValue
		{
			get
			{
				short num = (short)1073665539;
				short num2 = num;
				num = (short)1208997379;
				switch (num2 == num)
				{
				}
				num = (short)480182272;
				short num3 = num;
				num = (short)984612864;
				if (num != 0)
				{
				}
				num = (short)1933967361;
				if (num != 0)
				{
				}
				return this.trkSysDigitalHighDeviationTx_A19314.Value;
			}
			set
			{
				short num = (short)723471225;
				short num2 = num;
				num = (short)690441081;
				switch (num2 == num)
				{
				}
				num = (short)1693777920;
				short num3 = num;
				num = (short)151650304;
				if (num != 0)
				{
				}
				num = (short)1207042049;
				if (num != 0)
				{
				}
				this.trkSysDigitalHighDeviationTx_A19314.Value = value;
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x000D4B88 File Offset: 0x000D2D88
		// (set) Token: 0x06000CE1 RID: 3297 RVA: 0x000D4C3C File Offset: 0x000D2E3C
		public bool TrkSysDigitalHighDeviationTx_A19314_Applicable
		{
			get
			{
				short num = (short)582892358;
				short num2 = num;
				num = (short)1028340550;
				switch (num2 == num)
				{
				}
				num = (short)1889796096;
				short num3 = num;
				num = (short)2139422720;
				if (num != 0)
				{
				}
				num = (short)980221953;
				if (num != 0)
				{
				}
				return this.trkSysDigitalHighDeviationTx_A19314.Applicable;
			}
			set
			{
				short num = (short)1709245228;
				short num2 = num;
				num = (short)52101932;
				switch (num2 == num)
				{
				}
				num = (short)1999306752;
				short num3 = num;
				num = (short)1381040129;
				if (num != 0)
				{
				}
				num = (short)80281600;
				if (num != 0)
				{
				}
				this.trkSysDigitalHighDeviationTx_A19314.Applicable = value;
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x000D4CF0 File Offset: 0x000D2EF0
		// (set) Token: 0x06000CE3 RID: 3299 RVA: 0x000D4DA4 File Offset: 0x000D2FA4
		public bool TrkSysDigitalHighDeviationTx_A19314_Valid
		{
			get
			{
				short num = (short)1186484779;
				short num2 = num;
				num = (short)1808749099;
				switch (num2 == num)
				{
				}
				num = (short)2142568448;
				short num3 = num;
				num = (short)2082013185;
				if (num != 0)
				{
				}
				num = (short)120913920;
				if (num != 0)
				{
				}
				return this.trkSysDigitalHighDeviationTx_A19314.Valid;
			}
			set
			{
				short num = (short)540863290;
				short num2 = num;
				num = (short)1852762938;
				switch (num2 == num)
				{
				}
				num = (short)40435712;
				short num3 = num;
				num = (short)1840185344;
				if (num != 0)
				{
				}
				num = (short)1234239489;
				if (num != 0)
				{
				}
				this.trkSysDigitalHighDeviationTx_A19314.Valid = value;
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x000D4E58 File Offset: 0x000D3058
		// (set) Token: 0x06000CE5 RID: 3301 RVA: 0x000D4F0C File Offset: 0x000D310C
		public bool TrkSysDigitalHighDeviationTx_A19314_Visible
		{
			get
			{
				short num = (short)1451212372;
				short num2 = num;
				num = (short)2053029460;
				switch (num2 == num)
				{
				}
				num = (short)1627389952;
				short num3 = num;
				num = (short)72155136;
				if (num != 0)
				{
				}
				num = (short)807796737;
				if (num != 0)
				{
				}
				return this.trkSysDigitalHighDeviationTx_A19314.Visible;
			}
			set
			{
				short num = (short)487736727;
				short num2 = num;
				num = (short)778782103;
				switch (num2 == num)
				{
				}
				num = (short)1684144128;
				short num3 = num;
				num = (short)236978177;
				if (num != 0)
				{
				}
				num = (short)1375404032;
				if (num != 0)
				{
				}
				this.trkSysDigitalHighDeviationTx_A19314.Visible = value;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x000D4FC4 File Offset: 0x000D31C4
		// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x000D507C File Offset: 0x000D327C
		public bool TrkSysDigitalHighDeviationTx_A19314_Editable
		{
			get
			{
				short num = (short)624418991;
				short num2 = num;
				num = (short)2108940463;
				switch (num2 == num)
				{
				}
				num = (short)28180480;
				short num3 = num;
				num = (short)1541865473;
				if (num != 0)
				{
				}
				num = (short)425197568;
				if (num != 0)
				{
				}
				return this.trkSysDigitalHighDeviationTx_A19314.Editable;
			}
			set
			{
				short num = (short)1306146106;
				short num2 = num;
				num = (short)1560687930;
				switch (num2 == num)
				{
				}
				num = (short)1647116288;
				short num3 = num;
				num = (short)1587085312;
				if (num != 0)
				{
				}
				num = (short)1684078593;
				if (num != 0)
				{
				}
				this.trkSysDigitalHighDeviationTx_A19314.Editable = value;
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x000D5134 File Offset: 0x000D3334
		internal string TrkSysDigitalHighDeviationTx_A19314_UILabel
		{
			get
			{
				short num = (short)1133117441;
				if (num != 0)
				{
				}
				num = (short)657886295;
				short num2 = num;
				num = (short)1229163607;
				switch (num2 == num)
				{
				}
				num = (short)142802944;
				short num3 = num;
				num = (short)2145386496;
				if (num != 0)
				{
				}
				return this.trkSysDigitalHighDeviationTx_A19314.UIName;
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x000D51E8 File Offset: 0x000D33E8
		// (set) Token: 0x06000CEA RID: 3306 RVA: 0x000D529C File Offset: 0x000D349C
		internal bool TrkSysDigitalHighDeviationTx_A19314_HiddenStatic
		{
			get
			{
				short num = (short)210618179;
				short num2 = num;
				num = (short)1166788419;
				switch (num2 == num)
				{
				}
				num = (short)730202113;
				if (num != 0)
				{
				}
				num = (short)104923136;
				short num3 = num;
				num = (short)1007157248;
				if (num != 0)
				{
				}
				return this.trkSysDigitalHighDeviationTx_A19314.HiddenStatic;
			}
			set
			{
				short num = (short)329371190;
				short num2 = num;
				num = (short)1700056630;
				switch (num2 == num)
				{
				}
				num = (short)2024210432;
				if (num != 0)
				{
				}
				num = (short)290324480;
				short num3 = num;
				num = (short)950140929;
				if (num != 0)
				{
				}
				this.trkSysDigitalHighDeviationTx_A19314.HiddenStatic = value;
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x000D5350 File Offset: 0x000D3550
		// (set) Token: 0x06000CEC RID: 3308 RVA: 0x000D5404 File Offset: 0x000D3604
		internal bool TrkSysDigitalHighDeviationTx_A19314_HiddenDynamic
		{
			get
			{
				short num = (short)780967083;
				short num2 = num;
				num = (short)1978703019;
				switch (num2 == num)
				{
				}
				num = (short)131792896;
				if (num != 0)
				{
				}
				num = (short)562429952;
				short num3 = num;
				num = (short)2120876033;
				if (num != 0)
				{
				}
				return this.trkSysDigitalHighDeviationTx_A19314.HiddenDynamic;
			}
			set
			{
				short num = (short)1961980981;
				short num2 = num;
				num = (short)1614509109;
				switch (num2 == num)
				{
				}
				num = (short)911343617;
				if (num != 0)
				{
				}
				num = (short)508493824;
				short num3 = num;
				num = (short)1680539648;
				if (num != 0)
				{
				}
				this.trkSysDigitalHighDeviationTx_A19314.HiddenDynamic = value;
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x000D54BC File Offset: 0x000D36BC
		public bool TrkSysDigitalHighDeviationTx_A19314_HasDiffs
		{
			get
			{
				short num = (short)912292179;
				short num2 = num;
				num = (short)243759443;
				switch (num2 == num)
				{
				}
				num = (short)562167809;
				if (num != 0)
				{
				}
				num = (short)680001536;
				short num3 = num;
				num = (short)1209729024;
				if (num != 0)
				{
				}
				return this.trkSysDigitalHighDeviationTx_A19314._HasDiffs;
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x000D5574 File Offset: 0x000D3774
		// (set) Token: 0x06000CEF RID: 3311 RVA: 0x000D5628 File Offset: 0x000D3828
		public int TrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396Value
		{
			get
			{
				short num = (short)222925136;
				short num2 = num;
				num = (short)1724682576;
				switch (num2 == num)
				{
				}
				num = (short)1364328449;
				if (num != 0)
				{
				}
				num = (short)1123155968;
				short num3 = num;
				num = (short)1564147712;
				if (num != 0)
				{
				}
				return this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.Value;
			}
			set
			{
				short num = (short)580556221;
				short num2 = num;
				num = (short)245994941;
				switch (num2 == num)
				{
				}
				num = (short)1392902144;
				if (num != 0)
				{
				}
				num = (short)152567808;
				short num3 = num;
				num = (short)1246167041;
				if (num != 0)
				{
				}
				this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.Value = value;
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x000D56E0 File Offset: 0x000D38E0
		public global::AcpBusinessLayer.AcpCustomRangeField TrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396
		{
			get
			{
				short num = (short)1265935077;
				short num2 = num;
				num = (short)1467982565;
				switch (num2 == num)
				{
				}
				num = (short)1731919873;
				if (num != 0)
				{
				}
				num = (short)1120993280;
				short num3 = num;
				num = (short)1046872064;
				if (num != 0)
				{
				}
				return this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396;
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x000D5790 File Offset: 0x000D3990
		// (set) Token: 0x06000CF2 RID: 3314 RVA: 0x000D5840 File Offset: 0x000D3A40
		public string TrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396_UIValue
		{
			get
			{
				short num = (short)823359609;
				short num2 = num;
				num = (short)306739321;
				switch (num2 == num)
				{
				}
				num = (short)1102512129;
				if (num != 0)
				{
				}
				num = (short)55377920;
				short num3 = num;
				num = (short)2049310720;
				if (num != 0)
				{
				}
				return this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.UIValue;
			}
			set
			{
				short num = (short)498253193;
				short num2 = num;
				num = (short)828751241;
				switch (num2 == num)
				{
				}
				num = (short)1153826817;
				if (num != 0)
				{
				}
				num = (short)1012334592;
				short num3 = num;
				num = (short)1865482240;
				if (num != 0)
				{
				}
				this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.UIValue = value;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x000D58F4 File Offset: 0x000D3AF4
		// (set) Token: 0x06000CF4 RID: 3316 RVA: 0x000D59A8 File Offset: 0x000D3BA8
		internal int TrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396Min
		{
			get
			{
				short num = (short)262345944;
				short num2 = num;
				num = (short)1536759000;
				switch (num2 == num)
				{
				}
				num = (short)394330112;
				if (num != 0)
				{
				}
				num = (short)962134016;
				short num3 = num;
				num = (short)1071579137;
				if (num != 0)
				{
				}
				return this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.Min;
			}
			set
			{
				short num = (short)1217188594;
				short num2 = num;
				num = (short)317379314;
				switch (num2 == num)
				{
				}
				num = (short)825360385;
				if (num != 0)
				{
				}
				num = (short)1069088768;
				short num3 = num;
				num = (short)939065344;
				if (num != 0)
				{
				}
				this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.Min = value;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x000D5A5C File Offset: 0x000D3C5C
		// (set) Token: 0x06000CF6 RID: 3318 RVA: 0x000D5B14 File Offset: 0x000D3D14
		internal int TrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396Max
		{
			get
			{
				short num = (short)606771263;
				short num2 = num;
				num = (short)831821887;
				switch (num2 == num)
				{
				}
				num = (short)1425145856;
				if (num != 0)
				{
				}
				num = (short)262930432;
				short num3 = num;
				num = (short)1929707521;
				if (num != 0)
				{
				}
				return this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.Max;
			}
			set
			{
				short num = (short)893832238;
				short num2 = num;
				num = (short)2098056238;
				switch (num2 == num)
				{
				}
				num = (short)268959745;
				if (num != 0)
				{
				}
				num = (short)1323499520;
				short num3 = num;
				num = (short)959119360;
				if (num != 0)
				{
				}
				this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.Max = value;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x000D5BD0 File Offset: 0x000D3DD0
		// (set) Token: 0x06000CF8 RID: 3320 RVA: 0x000D5C84 File Offset: 0x000D3E84
		internal int TrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396Step
		{
			get
			{
				short num = (short)1615464308;
				short num2 = num;
				num = (short)1403783028;
				switch (num2 == num)
				{
				}
				num = (short)584908801;
				if (num != 0)
				{
				}
				num = (short)1986920448;
				short num3 = num;
				num = (short)1062600704;
				if (num != 0)
				{
				}
				return this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.StepSize;
			}
			set
			{
				short num = (short)1922457953;
				short num2 = num;
				num = (short)121332065;
				switch (num2 == num)
				{
				}
				num = (short)668336129;
				if (num != 0)
				{
				}
				num = (short)1275068416;
				short num3 = num;
				num = (short)1481310208;
				if (num != 0)
				{
				}
				this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.StepSize = value;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x000D5D38 File Offset: 0x000D3F38
		// (set) Token: 0x06000CFA RID: 3322 RVA: 0x000D5DE8 File Offset: 0x000D3FE8
		public bool TrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396_Applicable
		{
			get
			{
				short num = (short)1508217697;
				short num2 = num;
				num = (short)1945932641;
				switch (num2 == num)
				{
				}
				num = (short)1654325248;
				if (num != 0)
				{
				}
				num = (short)1911947264;
				short num3 = num;
				num = (short)435224577;
				if (num != 0)
				{
				}
				return this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.Applicable;
			}
			set
			{
				short num = (short)632539195;
				short num2 = num;
				num = (short)817875003;
				switch (num2 == num)
				{
				}
				num = (short)639434753;
				if (num != 0)
				{
				}
				num = (short)1815937024;
				short num3 = num;
				num = (short)2017722368;
				if (num != 0)
				{
				}
				this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.Applicable = value;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x000D5EA0 File Offset: 0x000D40A0
		// (set) Token: 0x06000CFC RID: 3324 RVA: 0x000D5F54 File Offset: 0x000D4154
		public bool TrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396_Valid
		{
			get
			{
				short num = (short)485751777;
				short num2 = num;
				num = (short)1353579489;
				switch (num2 == num)
				{
				}
				num = (short)1697251329;
				if (num != 0)
				{
				}
				num = (short)1947271168;
				short num3 = num;
				num = (short)1402535936;
				if (num != 0)
				{
				}
				return this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.Valid;
			}
			set
			{
				short num = (short)1851236190;
				short num2 = num;
				num = (short)989765470;
				switch (num2 == num)
				{
				}
				num = (short)596574208;
				if (num != 0)
				{
				}
				num = (short)795607040;
				short num3 = num;
				num = (short)63438849;
				if (num != 0)
				{
				}
				this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.Valid = value;
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x000D6008 File Offset: 0x000D4208
		// (set) Token: 0x06000CFE RID: 3326 RVA: 0x000D60BC File Offset: 0x000D42BC
		public bool TrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396_Visible
		{
			get
			{
				short num = (short)238354433;
				if (num != 0)
				{
				}
				num = (short)204062269;
				short num2 = num;
				num = (short)1283833405;
				switch (num2 == num)
				{
				}
				num = (short)382074880;
				short num3 = num;
				num = (short)113115136;
				if (num != 0)
				{
				}
				return this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.Visible;
			}
			set
			{
				short num = (short)855806174;
				short num2 = num;
				num = (short)1317310686;
				switch (num2 == num)
				{
				default:
				{
					num = (short)991232000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)239271936;
				if (num != 0)
				{
				}
				num = (short)2095316993;
				if (num != 0)
				{
				}
				this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.Visible = value;
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x000D6174 File Offset: 0x000D4374
		// (set) Token: 0x06000D00 RID: 3328 RVA: 0x000D6224 File Offset: 0x000D4424
		public bool TrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396_Editable
		{
			get
			{
				short num = (short)1184231829;
				short num2 = num;
				num = (short)281145749;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1032912896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)412483584;
				if (num != 0)
				{
				}
				num = (short)1809514497;
				if (num != 0)
				{
				}
				return this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.Editable;
			}
			set
			{
				short num = (short)1627891975;
				short num2 = num;
				num = (short)1915791623;
				switch (num2 == num)
				{
				default:
				{
					num = (short)640548864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)762839040;
				if (num != 0)
				{
				}
				num = (short)1764687873;
				if (num != 0)
				{
				}
				this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.Editable = value;
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06000D01 RID: 3329 RVA: 0x000D62DC File Offset: 0x000D44DC
		internal string TrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396_UILabel
		{
			get
			{
				short num = (short)363192756;
				short num2 = num;
				num = (short)588833204;
				switch (num2 == num)
				{
				default:
				{
					num = (short)809238528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2122252289;
				if (num != 0)
				{
				}
				num = (short)542375936;
				if (num != 0)
				{
				}
				return this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.UIName;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x000D6390 File Offset: 0x000D4590
		// (set) Token: 0x06000D03 RID: 3331 RVA: 0x000D6440 File Offset: 0x000D4640
		internal bool TrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396_HiddenStatic
		{
			get
			{
				short num = (short)883445577;
				short num2 = num;
				num = (short)33902409;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2041118720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1461780481;
				if (num != 0)
				{
				}
				num = (short)1626275840;
				if (num != 0)
				{
				}
				return this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.HiddenStatic;
			}
			set
			{
				short num = (short)531515593;
				short num2 = num;
				num = (short)2052737225;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1776091136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2055798784;
				if (num != 0)
				{
				}
				num = (short)146735105;
				if (num != 0)
				{
				}
				this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.HiddenStatic = value;
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x000D64F4 File Offset: 0x000D46F4
		// (set) Token: 0x06000D05 RID: 3333 RVA: 0x000D65AC File Offset: 0x000D47AC
		internal bool TrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396_HiddenDynamic
		{
			get
			{
				short num = (short)1169320718;
				short num2 = num;
				num = (short)703359758;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1460994048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)900202497;
				if (num != 0)
				{
				}
				num = (short)895156224;
				if (num != 0)
				{
				}
				return this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.HiddenDynamic;
			}
			set
			{
				short num = (short)1947263268;
				short num2 = num;
				num = (short)1209590052;
				switch (num2 == num)
				{
				default:
				{
					num = (short)749993984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)988020737;
				if (num != 0)
				{
				}
				num = (short)1334837248;
				if (num != 0)
				{
				}
				this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.HiddenDynamic = value;
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x000D6664 File Offset: 0x000D4864
		public bool TrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396_HasDiffs
		{
			get
			{
				short num = (short)2048028491;
				short num2 = num;
				num = (short)1456762699;
				switch (num2 == num)
				{
				default:
				{
					num = (short)178126848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1554251777;
				if (num != 0)
				{
				}
				num = (short)1169620992;
				if (num != 0)
				{
				}
				return this.trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396._HasDiffs;
			}
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x000D671C File Offset: 0x000D491C
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
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						num2 = (short)1668481027;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						num2 = (short)487391233;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)986644482;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						goto IL_AD;
					case 3:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)334626817;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_115;
					case 4:
						if (base.ParentRecset != null)
						{
							num2 = (short)374800384;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_115;
					}
					goto IL_24;
				}
				IL_AD:
				IL_115:
				num2 = (short)1124121133;
				short num3 = num2;
				num2 = (short)1362213421;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_4E;
				default:
					num2 = (short)291176448;
					if (num2 != 0)
					{
					}
					return result;
				}
				break;
			}
			}
			IL_24:
			num2 = (short)729153536;
			short num4 = num2;
			result = null;
			IL_4E:
			num2 = (short)1522597892;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000405 RID: 1029
		private global::AcpBusinessLayer.AcpField<bool> trkSysDigitalAdaptivePower_A7509;

		// Token: 0x04000406 RID: 1030
		private global::AcpBusinessLayer.AcpListField trkSysDigitalDigitalModulatorType_A7858;

		// Token: 0x04000407 RID: 1031
		private global::AcpBusinessLayer.AcpCustomRangeField trkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159;

		// Token: 0x04000408 RID: 1032
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysDigitalPreambleLength_A8722;

		// Token: 0x04000409 RID: 1033
		private global::AcpBusinessLayer.AcpField<bool> trkSysDigitalHighDeviationTx_A19314;

		// Token: 0x0400040A RID: 1034
		private global::AcpBusinessLayer.AcpCustomRangeField trkSysDigitalF2TDMAFrameSyncBERThreshold_A1396;
	}
}
