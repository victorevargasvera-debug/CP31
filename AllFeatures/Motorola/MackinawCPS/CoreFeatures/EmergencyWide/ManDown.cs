using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.EmergencyWide
{
	// Token: 0x02000492 RID: 1170
	[global::System.Serializable]
	public class ManDown : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06009A11 RID: 39441 RVA: 0x0090554C File Offset: 0x0090374C
		public ManDown(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06009A12 RID: 39442 RVA: 0x00905568 File Offset: 0x00903768
		protected ManDown(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06009A13 RID: 39443 RVA: 0x00905580 File Offset: 0x00903780
		public override void Init()
		{
			int a_ = 14;
			short num = (short)314000483;
			short num2 = num;
			num = (short)2117682275;
			switch (num2 == num)
			{
			}
			num = (short)1454243841;
			if (num != 0)
			{
			}
			num = (short)305004544;
			if (num != 0)
			{
			}
			num = (short)563412992;
			short num3 = num;
			this.emerWideManDownTrigger_A40001 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("諎볐뛒꟔胖냘뿚룜鋞胠跢ꇤ裦黨藪맬鷮飰铲鋴鋶诸ꓺ볼쯾㄀㌂㔄㘆", a_), global::CommonResources.AcgResources.ID_MANDOWNTRIGGER, global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.LOVs.EmerWideManDownTrigger_A40001LovStrs);
			this.emerWideManDownTrigger_A40001.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.emerWideManDownTrigger_A40001.DataTransferOrder = 8;
			this.emerWideManDownMotionlessSensitivity_A40002 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("諎볐뛒꟔胖냘뿚룜鋞胠跢ꇤ裦黨藪ꃬ胮藰髲髴駶闸黺軼賾刀昂欄理怈缊搌礎砐朒气䠖堘⼚ⴜ⼞ᄠᄢ", a_), global::CommonResources.AcgResources.ID_MOTIONSENSITIVITY, global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.LOVs.EmerWideManDownMotionlessSensitivity_A40002LovStrs);
			this.emerWideManDownMotionlessSensitivity_A40002.IgnoreOnCompare = true;
			this.emerWideManDownMotionlessSensitivity_A40002.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.emerWideManDownMotionlessSensitivity_A40002.DataTransferOrder = -1;
			this.emerWideManDownPreAlertTimer_A40003 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("諎볐뛒꟔胖냘뿚룜鋞胠跢ꇤ裦黨藪뷬鷮铰닲駴鋶诸迺ꧼ雾氀昂眄堆䠈㼊㴌㼎ℐ‒", a_), global::CommonResources.AcgResources.ID_PREALERTTIMERSEC, 5, 120, null, null, 0, 1);
			this.emerWideManDownPreAlertTimer_A40003.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.emerWideManDownPreAlertTimer_A40003.DataTransferOrder = 10;
			this.emerWideManDownPreAlertTimer_A40003.ShowHexValue = false;
			this.emerWideManDownPostAlertTimer_A40004 = new global::AcpBusinessLayer.AcpSimpleRangeField(30, this, global::AllFeatures.CodeplugGuid.b("諎볐뛒꟔胖냘뿚룜鋞胠跢ꇤ裦黨藪뷬胮苰蟲듴鯶鳸觺觼꯾栀渂怄甆嘈䨊㤌㼎ℐ⌒℔", a_), global::CommonResources.AcgResources.ID_POSTALERTTIMERSEC, 1, 120, null, null, 0, 1);
			this.emerWideManDownPostAlertTimer_A40004.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.emerWideManDownPostAlertTimer_A40004.DataTransferOrder = 11;
			this.emerWideManDownPostAlertTimer_A40004.ShowHexValue = false;
			this.emerWidePostAlertTone_A41191 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("諎볐뛒꟔胖냘뿚룜连軠郢釤ꛦ藨軪鿬鯮ꗰ鳲鯴鋶꛸뫺짼컾\u3000㨂㐄", a_), global::CommonResources.AcgResources.ID_PREALERTTONE, global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.LOVs.EmerWidePostAlertTone_A41191LovStrs);
			this.emerWidePostAlertTone_A41191.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.emerWidePostAlertTone_A41191.DataTransferOrder = 12;
			this.manDownConfigurabilityGranularityLevel_42057 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苎냐뷒釔룖께뗚黜냞迠藢賤胦鳨駪賬跮飰鿲鳴菶胸볺迼黾漀瘂椄昆笈戊礌瘎崐瘒挔爖甘䐚⤜ⴞᄠᘢሤ", a_), global::CommonResources.AcgResources.ID_MANDOWNCONFIGURABILITYLEVEL, global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.LOVs.ManDownConfigurabilityGranularityLevel_42057LovStrs);
			this.manDownConfigurabilityGranularityLevel_42057.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.manDownConfigurabilityGranularityLevel_42057.DataTransferOrder = 13;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苎냐뷒鏖뛘곚돜", a_);
			base.Id = 10639;
			base.UIName = global::CommonResources.AcgResources.ID_MANDOWN;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06009A14 RID: 39444 RVA: 0x00905800 File Offset: 0x00903A00
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)1215561729;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓈꫊ꏌ诎뻐ꓒ믔铖뛘뗚믜뛞蛠離韤蛦诨苪臬蛮藰諲담藶飸闺裼鏾怀焂氄猆瀈䜊栌礎琐缒䨔⌖⬘⬚⠜⠞", a_)))
					{
						num = (short)2070478862;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_592;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_86;
					}
					continue;
				case 2:
					this.emerWideManDownMotionlessSensitivity_A40002 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("賈ꛊ꣌뷎蛐뫒뇔닖铘뫚돜鯞軠铢诤ꫦ蛨鿪蓬胮鿰鿲郴蓶諸꣺飼釾爀樂焄渆缈戊礌瘎丐划℔✖⤘⬚⼜", a_), global::CommonResources.AcgResources.ID_MOTIONSENSITIVITY, global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.LOVs.EmerWideManDownMotionlessSensitivity_A40002LovStrs);
					this.emerWideManDownMotionlessSensitivity_A40002.IgnoreOnCompare = true;
					this.emerWideManDownMotionlessSensitivity_A40002.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.emerWideManDownMotionlessSensitivity_A40002.DataTransferOrder = -1;
					num = (short)1964900355;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_3B2;
				case 4:
					goto IL_3AD;
				case 5:
				{
					num = (short)1027753259;
					short num3 = num;
					num = (short)1752843563;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3AD;
					default:
						num = (short)1369047040;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賈ꛊ꣌뷎蛐뫒뇔닖觘듚껜ꯞꃠ迢胤闦鷨뿪苬臮铰곲듴쏶죸쫺쓼컾", a_)))
						{
							num = (short)1325793298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_256;
					}
					break;
				}
				case 6:
					goto IL_4A6;
				case 7:
					goto IL_256;
				case 8:
					num = (short)2124021772;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_D3;
				case 10:
				{
					num = (short)17760256;
					short num4 = num;
					num = (short)1116667921;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
					this.emerWideManDownPostAlertTimer_A40004 = new global::AcpBusinessLayer.AcpSimpleRangeField(30, this, global::AllFeatures.CodeplugGuid.b("賈ꛊ꣌뷎蛐뫒뇔닖铘뫚돜鯞軠铢诤럦蛨飪駬껮鷰雲蟴菶그鋺郼髾猀専䐄㌆㤈㬊㴌㬎", a_), global::CommonResources.AcgResources.ID_POSTALERTTIMERSEC, null, null, 0, 1);
					this.emerWideManDownPostAlertTimer_A40004.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.emerWideManDownPostAlertTimer_A40004.DataTransferOrder = 11;
					this.emerWideManDownPostAlertTimer_A40004.ShowHexValue = false;
					num = (short)111804425;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賈ꛊ꣌뷎蛐뫒뇔닖铘뫚돜鯞軠铢诤돦鯨苪諬裮铰臲ꫴ뛶췸쯺췼쿾\u3000", a_)))
					{
						num = (short)1948647443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_402;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賈ꛊ꣌뷎蛐뫒뇔닖铘뫚돜鯞軠铢诤럦鯨軪곬菮铰臲致ꏶ郸雺飼跾帀䈂㄄㜆㤈㬊㸌", a_)))
					{
						num = (short)1958608916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4A6;
				case 14:
					this.manDownConfigurabilityGranularityLevel_42057 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蓈꫊ꏌ诎뻐ꓒ믔铖뛘뗚믜뛞蛠離韤蛦诨苪臬蛮藰諲담藶飸闺裼鏾怀焂氄猆瀈䜊栌礎琐缒䨔⌖⬘⬚⠜⠞", a_), global::CommonResources.AcgResources.ID_MANDOWNCONFIGURABILITYLEVEL, global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.LOVs.ManDownConfigurabilityGranularityLevel_42057LovStrs);
					this.manDownConfigurabilityGranularityLevel_42057.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.manDownConfigurabilityGranularityLevel_42057.DataTransferOrder = 13;
					num = (short)554172420;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_402;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賈ꛊ꣌뷎蛐뫒뇔닖铘뫚돜鯞軠铢诤ꫦ蛨鿪蓬胮鿰鿲郴蓶諸꣺飼釾爀樂焄渆缈戊礌瘎丐划℔✖⤘⬚⼜", a_)))
					{
						num = (short)804978690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3B2;
				case 17:
					if (producerFields != null)
					{
						num = (short)1712455688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_592;
				case 18:
					this.emerWidePostAlertTone_A41191 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("賈ꛊ꣌뷎蛐뫒뇔닖觘듚껜ꯞꃠ迢胤闦鷨뿪苬臮铰곲듴쏶죸쫺쓼컾", a_), global::CommonResources.AcgResources.ID_PREALERTTONE, global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.LOVs.EmerWidePostAlertTone_A41191LovStrs);
					this.emerWidePostAlertTone_A41191.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.emerWidePostAlertTone_A41191.DataTransferOrder = 12;
					num = (short)491585543;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					this.emerWideManDownTrigger_A40001 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("賈ꛊ꣌뷎蛐뫒뇔닖铘뫚돜鯞軠铢诤돦鯨苪諬裮铰臲ꫴ뛶췸쯺췼쿾\u3000", a_), global::CommonResources.AcgResources.ID_MANDOWNTRIGGER, global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.LOVs.EmerWideManDownTrigger_A40001LovStrs);
					this.emerWideManDownTrigger_A40001.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.emerWideManDownTrigger_A40001.DataTransferOrder = 8;
					num = (short)989200399;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					this.emerWideManDownPreAlertTimer_A40003 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("賈ꛊ꣌뷎蛐뫒뇔닖铘뫚돜鯞軠铢诤럦鯨軪곬菮铰臲致ꏶ郸雺飼跾帀䈂㄄㜆㤈㬊㸌", a_), global::CommonResources.AcgResources.ID_PREALERTTIMERSEC, null, null, 0, 1);
					this.emerWideManDownPreAlertTimer_A40003.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.emerWideManDownPreAlertTimer_A40003.DataTransferOrder = 10;
					this.emerWideManDownPreAlertTimer_A40003.ShowHexValue = false;
					num = (short)995426310;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賈ꛊ꣌뷎蛐뫒뇔닖铘뫚돜鯞軠铢诤럦蛨飪駬껮鷰雲蟴菶그鋺郼髾猀専䐄㌆㤈㬊㴌㬎", a_)))
					{
						num = (short)2126249995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D3;
				}
				IL_86:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)239271946;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_D3:
				num = (short)703922177;
				if (num != 0)
				{
				}
				num = (short)152961029;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_256:
				num = (short)1104478208;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3B2:
				num = (short)220200973;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_402:
				num = (short)127664144;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4A6:
				num = (short)354156565;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_3AD:
			IL_592:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蓈꫊ꏌ闐볒ꋔ맖", a_);
			base.Id = 10639;
			base.UIName = global::CommonResources.AcgResources.ID_MANDOWN;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06009A15 RID: 39445 RVA: 0x00905DD0 File Offset: 0x00903FD0
		public override void PopulateReferences()
		{
			short num = (short)1427297847;
			short num2 = num;
			num = (short)83088951;
			switch (num2 == num)
			{
			}
			num = (short)902168577;
			if (num != 0)
			{
			}
			num = (short)525860864;
			if (num != 0)
			{
			}
			num = (short)1177092096;
			short num3 = num;
		}

		// Token: 0x06009A16 RID: 39446 RVA: 0x00905E7C File Offset: 0x0090407C
		public override void DropReferences()
		{
			short num = (short)56492033;
			if (num != 0)
			{
			}
			num = (short)1144258560;
			short num2 = num;
			num = (short)1671243134;
			short num3 = num;
			num = (short)825238910;
			switch (num3 == num)
			{
			}
			num = (short)768868352;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009A17 RID: 39447 RVA: 0x00905F28 File Offset: 0x00904128
		public override void SetConstraints()
		{
			short num = (short)789481151;
			short num2 = num;
			num = (short)975406783;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2051801088;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1241645057;
			if (num != 0)
			{
			}
			num = (short)863961088;
			if (num != 0)
			{
			}
			this.emerWideManDownPreAlertTimer_A40003.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideConstraints.ConManDownTriggerIsNotDisabled);
			this.emerWideManDownPostAlertTimer_A40004.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideConstraints.ConManDownTriggerIsNotDisabled);
			this.emerWidePostAlertTone_A41191.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideConstraints.ConManDownTriggerIsNotDisabled);
			this.manDownConfigurabilityGranularityLevel_42057.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideConstraints.ConManDownTriggerIsNotDisabled);
			this.manDownConfigurabilityGranularityLevel_42057.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideConstraints.conSetTriggedByManDownValue);
		}

		// Token: 0x06009A18 RID: 39448 RVA: 0x00906044 File Offset: 0x00904244
		public override void SetupDependencies()
		{
			short num = (short)1448804353;
			if (num != 0)
			{
			}
			num = (short)1055916032;
			short num2 = num;
			num = (short)906466935;
			short num3 = num;
			num = (short)530159223;
			switch (num3 == num)
			{
			}
			num = (short)58458112;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide emergencyWide = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide;
			this.emerWideManDownTrigger_A40001.AddDependentObject(this.emerWideManDownPreAlertTimer_A40003);
			this.emerWideManDownTrigger_A40001.AddDependentObject(this.emerWideManDownPostAlertTimer_A40004);
			this.emerWideManDownTrigger_A40001.AddDependentObject(this.emerWidePostAlertTone_A41191);
			this.emerWideManDownTrigger_A40001.AddDependentObject(this.manDownConfigurabilityGranularityLevel_42057);
			emergencyWide.EmergencyToneTrigger.TriggedByManDown_42135.AddDependentObject(this.manDownConfigurabilityGranularityLevel_42057);
		}

		// Token: 0x17004D60 RID: 19808
		// (get) Token: 0x06009A19 RID: 39449 RVA: 0x00906154 File Offset: 0x00904354
		public bool HasDiffs
		{
			get
			{
				short num = (short)578503540;
				short num2 = num;
				num = (short)1398883188;
				switch (num2 == num)
				{
				default:
				{
					num = (short)20709376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1635713025;
				if (num != 0)
				{
				}
				num = (short)1569652736;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004D61 RID: 19809
		// (get) Token: 0x06009A1A RID: 39450 RVA: 0x00906204 File Offset: 0x00904404
		// (set) Token: 0x06009A1B RID: 39451 RVA: 0x009062BC File Offset: 0x009044BC
		public int EmerWideManDownTrigger_A40001Value
		{
			get
			{
				short num = (short)1528793294;
				short num2 = num;
				num = (short)1371244750;
				switch (num2 == num)
				{
				default:
				{
					num = (short)358547456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)700317696;
				if (num != 0)
				{
				}
				num = (short)1622736897;
				if (num != 0)
				{
				}
				return this.emerWideManDownTrigger_A40001.Value;
			}
			set
			{
				short num = (short)1677417146;
				short num2 = num;
				num = (short)1976523450;
				switch (num2 == num)
				{
				default:
				{
					num = (short)123535360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)80216064;
				if (num != 0)
				{
				}
				num = (short)705888257;
				if (num != 0)
				{
				}
				this.emerWideManDownTrigger_A40001.Value = value;
			}
		}

		// Token: 0x17004D62 RID: 19810
		// (get) Token: 0x06009A1C RID: 39452 RVA: 0x00906370 File Offset: 0x00904570
		// (set) Token: 0x06009A1D RID: 39453 RVA: 0x00906424 File Offset: 0x00904624
		public string EmerWideManDownTrigger_A40001_UIValue
		{
			get
			{
				short num = (short)1529832806;
				short num2 = num;
				num = (short)1841653094;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1916534784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2044067840;
				if (num != 0)
				{
				}
				num = (short)951910401;
				if (num != 0)
				{
				}
				return this.emerWideManDownTrigger_A40001.UIValue;
			}
			set
			{
				short num = (short)1866682572;
				short num2 = num;
				num = (short)1470582988;
				switch (num2 == num)
				{
				default:
				{
					num = (short)908984320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1937440769;
				if (num != 0)
				{
				}
				num = (short)197066752;
				if (num != 0)
				{
				}
				this.emerWideManDownTrigger_A40001.UIValue = value;
			}
		}

		// Token: 0x17004D63 RID: 19811
		// (get) Token: 0x06009A1E RID: 39454 RVA: 0x009064DC File Offset: 0x009046DC
		public global::AcpBusinessLayer.AcpListField EmerWideManDownTrigger_A40001
		{
			get
			{
				short num = (short)2029912065;
				if (num != 0)
				{
				}
				num = (short)764870656;
				short num2 = num;
				num = (short)1496254775;
				short num3 = num;
				num = (short)548407607;
				switch (num3 == num)
				{
				}
				num = (short)1662058496;
				if (num != 0)
				{
				}
				return this.emerWideManDownTrigger_A40001;
			}
		}

		// Token: 0x17004D64 RID: 19812
		// (get) Token: 0x06009A1F RID: 39455 RVA: 0x0090658C File Offset: 0x0090478C
		// (set) Token: 0x06009A20 RID: 39456 RVA: 0x00906644 File Offset: 0x00904844
		public bool EmerWideManDownTrigger_A40001_Applicable
		{
			get
			{
				short num = (short)1964471028;
				short num2 = num;
				num = (short)1527804660;
				switch (num2 == num)
				{
				default:
				{
					num = (short)287834112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)752091137;
				if (num != 0)
				{
				}
				num = (short)114229248;
				if (num != 0)
				{
				}
				return this.emerWideManDownTrigger_A40001.Applicable;
			}
			set
			{
				short num = (short)1992687617;
				if (num != 0)
				{
				}
				num = (short)76742656;
				short num2 = num;
				num = (short)7779781;
				short num3 = num;
				num = (short)2004268485;
				switch (num3 == num)
				{
				}
				num = (short)1097072640;
				if (num != 0)
				{
				}
				this.emerWideManDownTrigger_A40001.Applicable = value;
			}
		}

		// Token: 0x17004D65 RID: 19813
		// (get) Token: 0x06009A21 RID: 39457 RVA: 0x009066F8 File Offset: 0x009048F8
		// (set) Token: 0x06009A22 RID: 39458 RVA: 0x009067B0 File Offset: 0x009049B0
		public bool EmerWideManDownTrigger_A40001_Valid
		{
			get
			{
				short num = (short)205535271;
				short num2 = num;
				num = (short)1838299175;
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
				num = (short)416743425;
				if (num != 0)
				{
				}
				num = (short)1289158656;
				if (num != 0)
				{
				}
				return this.emerWideManDownTrigger_A40001.Valid;
			}
			set
			{
				short num = (short)1969750017;
				if (num != 0)
				{
				}
				num = (short)1727070208;
				short num2 = num;
				num = (short)757131145;
				short num3 = num;
				num = (short)222881673;
				switch (num3 == num)
				{
				}
				num = (short)820969472;
				if (num != 0)
				{
				}
				this.emerWideManDownTrigger_A40001.Valid = value;
			}
		}

		// Token: 0x17004D66 RID: 19814
		// (get) Token: 0x06009A23 RID: 39459 RVA: 0x00906864 File Offset: 0x00904A64
		// (set) Token: 0x06009A24 RID: 39460 RVA: 0x00906918 File Offset: 0x00904B18
		public bool EmerWideManDownTrigger_A40001_Visible
		{
			get
			{
				short num = (short)1136159012;
				short num2 = num;
				num = (short)1540253988;
				switch (num2 == num)
				{
				default:
				{
					num = (short)714080256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)633274369;
				if (num != 0)
				{
				}
				num = (short)930480128;
				if (num != 0)
				{
				}
				return this.emerWideManDownTrigger_A40001.Visible;
			}
			set
			{
				short num = (short)1354847223;
				short num2 = num;
				num = (short)291460087;
				switch (num2 == num)
				{
				default:
				{
					num = (short)15138816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1238499329;
				if (num != 0)
				{
				}
				num = (short)861863936;
				if (num != 0)
				{
				}
				this.emerWideManDownTrigger_A40001.Visible = value;
			}
		}

		// Token: 0x17004D67 RID: 19815
		// (get) Token: 0x06009A25 RID: 39461 RVA: 0x009069CC File Offset: 0x00904BCC
		// (set) Token: 0x06009A26 RID: 39462 RVA: 0x00906A80 File Offset: 0x00904C80
		public bool EmerWideManDownTrigger_A40001_Editable
		{
			get
			{
				short num = (short)1757612661;
				short num2 = num;
				num = (short)1539312245;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1522335744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)877199361;
				if (num != 0)
				{
				}
				num = (short)1823866880;
				if (num != 0)
				{
				}
				return this.emerWideManDownTrigger_A40001.Editable;
			}
			set
			{
				short num = (short)368771073;
				if (num != 0)
				{
				}
				num = (short)1982398464;
				short num2 = num;
				num = (short)1927272856;
				short num3 = num;
				num = (short)1002035608;
				switch (num3 == num)
				{
				}
				num = (short)2130313216;
				if (num != 0)
				{
				}
				this.emerWideManDownTrigger_A40001.Editable = value;
			}
		}

		// Token: 0x17004D68 RID: 19816
		// (get) Token: 0x06009A27 RID: 39463 RVA: 0x00906B34 File Offset: 0x00904D34
		internal string EmerWideManDownTrigger_A40001_UILabel
		{
			get
			{
				short num = (short)105366355;
				short num2 = num;
				num = (short)926204755;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2127101952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)623640577;
				if (num != 0)
				{
				}
				num = (short)68354048;
				if (num != 0)
				{
				}
				return this.emerWideManDownTrigger_A40001.UIName;
			}
		}

		// Token: 0x17004D69 RID: 19817
		// (get) Token: 0x06009A28 RID: 39464 RVA: 0x00906BE8 File Offset: 0x00904DE8
		// (set) Token: 0x06009A29 RID: 39465 RVA: 0x00906C9C File Offset: 0x00904E9C
		internal bool EmerWideManDownTrigger_A40001_HiddenStatic
		{
			get
			{
				short num = (short)582867473;
				short num2 = num;
				num = (short)515955217;
				switch (num2 == num)
				{
				default:
				{
					num = (short)980418560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)390594560;
				if (num != 0)
				{
				}
				num = (short)1116405761;
				if (num != 0)
				{
				}
				return this.emerWideManDownTrigger_A40001.HiddenStatic;
			}
			set
			{
				short num = (short)881788778;
				short num2 = num;
				num = (short)431490922;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1660354560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)155779073;
				if (num != 0)
				{
				}
				num = (short)1977090048;
				if (num != 0)
				{
				}
				this.emerWideManDownTrigger_A40001.HiddenStatic = value;
			}
		}

		// Token: 0x17004D6A RID: 19818
		// (get) Token: 0x06009A2A RID: 39466 RVA: 0x00906D54 File Offset: 0x00904F54
		// (set) Token: 0x06009A2B RID: 39467 RVA: 0x00906E08 File Offset: 0x00905008
		internal bool EmerWideManDownTrigger_A40001_HiddenDynamic
		{
			get
			{
				short num = (short)180111660;
				short num2 = num;
				num = (short)1938573612;
				switch (num2 == num)
				{
				default:
				{
					num = (short)243204096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1336803328;
				if (num != 0)
				{
				}
				num = (short)1741422593;
				if (num != 0)
				{
				}
				return this.emerWideManDownTrigger_A40001.HiddenDynamic;
			}
			set
			{
				short num = (short)1046539943;
				short num2 = num;
				num = (short)1419636391;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1450901504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1424687105;
				if (num != 0)
				{
				}
				num = (short)364576768;
				if (num != 0)
				{
				}
				this.emerWideManDownTrigger_A40001.HiddenDynamic = value;
			}
		}

		// Token: 0x17004D6B RID: 19819
		// (get) Token: 0x06009A2C RID: 39468 RVA: 0x00906EC0 File Offset: 0x009050C0
		public bool EmerWideManDownTrigger_A40001_HasDiffs
		{
			get
			{
				short num = (short)1821824418;
				short num2 = num;
				num = (short)947901858;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1892679680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)113180673;
				if (num != 0)
				{
				}
				num = (short)230555648;
				if (num != 0)
				{
				}
				return this.emerWideManDownTrigger_A40001._HasDiffs;
			}
		}

		// Token: 0x17004D6C RID: 19820
		// (get) Token: 0x06009A2D RID: 39469 RVA: 0x00906F70 File Offset: 0x00905170
		// (set) Token: 0x06009A2E RID: 39470 RVA: 0x00907024 File Offset: 0x00905224
		public int EmerWideManDownMotionlessSensitivity_A40002Value
		{
			get
			{
				short num = (short)169280538;
				short num2 = num;
				num = (short)881263642;
				switch (num2 == num)
				{
				default:
				{
					num = (short)416481280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)330694656;
				if (num != 0)
				{
				}
				num = (short)745340929;
				if (num != 0)
				{
				}
				return this.emerWideManDownMotionlessSensitivity_A40002.Value;
			}
			set
			{
				short num = (short)41626037;
				short num2 = num;
				num = (short)1821583797;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1146945536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)227409921;
				if (num != 0)
				{
				}
				num = (short)1388642304;
				if (num != 0)
				{
				}
				this.emerWideManDownMotionlessSensitivity_A40002.Value = value;
			}
		}

		// Token: 0x17004D6D RID: 19821
		// (get) Token: 0x06009A2F RID: 39471 RVA: 0x009070D8 File Offset: 0x009052D8
		// (set) Token: 0x06009A30 RID: 39472 RVA: 0x00907190 File Offset: 0x00905390
		public string EmerWideManDownMotionlessSensitivity_A40002_UIValue
		{
			get
			{
				short num = (short)1606090753;
				if (num != 0)
				{
				}
				num = (short)1762328576;
				short num2 = num;
				num = (short)537667057;
				short num3 = num;
				num = (short)1495344625;
				switch (num3 == num)
				{
				}
				num = (short)1355612160;
				if (num != 0)
				{
				}
				return this.emerWideManDownMotionlessSensitivity_A40002.UIValue;
			}
			set
			{
				short num = (short)172905621;
				short num2 = num;
				num = (short)2054706325;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2007760896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1288175616;
				if (num != 0)
				{
				}
				num = (short)1300758529;
				if (num != 0)
				{
				}
				this.emerWideManDownMotionlessSensitivity_A40002.UIValue = value;
			}
		}

		// Token: 0x17004D6E RID: 19822
		// (get) Token: 0x06009A31 RID: 39473 RVA: 0x00907248 File Offset: 0x00905448
		public global::AcpBusinessLayer.AcpListField EmerWideManDownMotionlessSensitivity_A40002
		{
			get
			{
				short num = (short)1072966933;
				short num2 = num;
				num = (short)1723215125;
				switch (num2 == num)
				{
				default:
				{
					num = (short)549322752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1250361345;
				if (num != 0)
				{
				}
				num = (short)692125696;
				if (num != 0)
				{
				}
				return this.emerWideManDownMotionlessSensitivity_A40002;
			}
		}

		// Token: 0x17004D6F RID: 19823
		// (get) Token: 0x06009A32 RID: 39474 RVA: 0x009072F4 File Offset: 0x009054F4
		// (set) Token: 0x06009A33 RID: 39475 RVA: 0x009073AC File Offset: 0x009055AC
		public bool EmerWideManDownMotionlessSensitivity_A40002_Applicable
		{
			get
			{
				short num = (short)2009108775;
				short num2 = num;
				num = (short)571117863;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1913585664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)995688448;
				if (num != 0)
				{
				}
				num = (short)751566849;
				if (num != 0)
				{
				}
				return this.emerWideManDownMotionlessSensitivity_A40002.Applicable;
			}
			set
			{
				short num = (short)1100997576;
				short num2 = num;
				num = (short)588112840;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2140798976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2107179009;
				if (num != 0)
				{
				}
				num = (short)73924608;
				if (num != 0)
				{
				}
				this.emerWideManDownMotionlessSensitivity_A40002.Applicable = value;
			}
		}

		// Token: 0x17004D70 RID: 19824
		// (get) Token: 0x06009A34 RID: 39476 RVA: 0x00907464 File Offset: 0x00905664
		// (set) Token: 0x06009A35 RID: 39477 RVA: 0x0090751C File Offset: 0x0090571C
		public bool EmerWideManDownMotionlessSensitivity_A40002_Valid
		{
			get
			{
				short num = (short)1326897026;
				short num2 = num;
				num = (short)1126684546;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1014956032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)577568769;
				if (num != 0)
				{
				}
				num = (short)66650112;
				if (num != 0)
				{
				}
				return this.emerWideManDownMotionlessSensitivity_A40002.Valid;
			}
			set
			{
				short num = (short)334878834;
				short num2 = num;
				num = (short)1401477234;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1772814336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1495072768;
				if (num != 0)
				{
				}
				num = (short)784400385;
				if (num != 0)
				{
				}
				this.emerWideManDownMotionlessSensitivity_A40002.Valid = value;
			}
		}

		// Token: 0x17004D71 RID: 19825
		// (get) Token: 0x06009A36 RID: 39478 RVA: 0x009075D4 File Offset: 0x009057D4
		// (set) Token: 0x06009A37 RID: 39479 RVA: 0x0090768C File Offset: 0x0090588C
		public bool EmerWideManDownMotionlessSensitivity_A40002_Visible
		{
			get
			{
				short num = (short)1514548471;
				short num2 = num;
				num = (short)272510199;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1615593472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)660602880;
				if (num != 0)
				{
				}
				num = (short)1424293889;
				if (num != 0)
				{
				}
				return this.emerWideManDownMotionlessSensitivity_A40002.Visible;
			}
			set
			{
				short num = (short)2141325220;
				short num2 = num;
				num = (short)1128990628;
				switch (num2 == num)
				{
				default:
				{
					num = (short)981794816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2038038529;
				if (num != 0)
				{
				}
				num = (short)599654400;
				if (num != 0)
				{
				}
				this.emerWideManDownMotionlessSensitivity_A40002.Visible = value;
			}
		}

		// Token: 0x17004D72 RID: 19826
		// (get) Token: 0x06009A38 RID: 39480 RVA: 0x00907744 File Offset: 0x00905944
		// (set) Token: 0x06009A39 RID: 39481 RVA: 0x009077FC File Offset: 0x009059FC
		public bool EmerWideManDownMotionlessSensitivity_A40002_Editable
		{
			get
			{
				short num = (short)931522318;
				short num2 = num;
				num = (short)574351118;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1300955136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)386662400;
				if (num != 0)
				{
				}
				num = (short)1741553665;
				if (num != 0)
				{
				}
				return this.emerWideManDownMotionlessSensitivity_A40002.Editable;
			}
			set
			{
				short num = (short)171245569;
				if (num != 0)
				{
				}
				num = (short)1023541248;
				short num2 = num;
				num = (short)135765452;
				short num3 = num;
				num = (short)994352588;
				switch (num3 == num)
				{
				}
				num = (short)1544486912;
				if (num != 0)
				{
				}
				this.emerWideManDownMotionlessSensitivity_A40002.Editable = value;
			}
		}

		// Token: 0x17004D73 RID: 19827
		// (get) Token: 0x06009A3A RID: 39482 RVA: 0x009078B0 File Offset: 0x00905AB0
		internal string EmerWideManDownMotionlessSensitivity_A40002_UILabel
		{
			get
			{
				short num = (short)484552940;
				short num2 = num;
				num = (short)1818603756;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1983119360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)619577344;
				if (num != 0)
				{
				}
				num = (short)896794625;
				if (num != 0)
				{
				}
				return this.emerWideManDownMotionlessSensitivity_A40002.UIName;
			}
		}

		// Token: 0x17004D74 RID: 19828
		// (get) Token: 0x06009A3B RID: 39483 RVA: 0x00907964 File Offset: 0x00905B64
		// (set) Token: 0x06009A3C RID: 39484 RVA: 0x00907A18 File Offset: 0x00905C18
		internal bool EmerWideManDownMotionlessSensitivity_A40002_HiddenStatic
		{
			get
			{
				short num = (short)1136605164;
				short num2 = num;
				num = (short)890320876;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1059454976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1522466817;
				if (num != 0)
				{
				}
				num = (short)47251456;
				if (num != 0)
				{
				}
				return this.emerWideManDownMotionlessSensitivity_A40002.HiddenStatic;
			}
			set
			{
				short num = (short)1911723286;
				short num2 = num;
				num = (short)184325398;
				switch (num2 == num)
				{
				default:
				{
					num = (short)323616768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1885274113;
				if (num != 0)
				{
				}
				num = (short)365494272;
				if (num != 0)
				{
				}
				this.emerWideManDownMotionlessSensitivity_A40002.HiddenStatic = value;
			}
		}

		// Token: 0x17004D75 RID: 19829
		// (get) Token: 0x06009A3D RID: 39485 RVA: 0x00907ACC File Offset: 0x00905CCC
		// (set) Token: 0x06009A3E RID: 39486 RVA: 0x00907B80 File Offset: 0x00905D80
		internal bool EmerWideManDownMotionlessSensitivity_A40002_HiddenDynamic
		{
			get
			{
				short num = (short)1403715585;
				if (num != 0)
				{
				}
				num = (short)89980928;
				short num2 = num;
				num = (short)797991530;
				short num3 = num;
				num = (short)796746346;
				switch (num3 == num)
				{
				}
				num = (short)711524352;
				if (num != 0)
				{
				}
				return this.emerWideManDownMotionlessSensitivity_A40002.HiddenDynamic;
			}
			set
			{
				short num = (short)2027984746;
				short num2 = num;
				num = (short)1306433386;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1893597184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1541865472;
				if (num != 0)
				{
				}
				num = (short)729808897;
				if (num != 0)
				{
				}
				this.emerWideManDownMotionlessSensitivity_A40002.HiddenDynamic = value;
			}
		}

		// Token: 0x17004D76 RID: 19830
		// (get) Token: 0x06009A3F RID: 39487 RVA: 0x00907C34 File Offset: 0x00905E34
		public bool EmerWideManDownMotionlessSensitivity_A40002_HasDiffs
		{
			get
			{
				short num = (short)2070797394;
				short num2 = num;
				num = (short)561306706;
				switch (num2 == num)
				{
				default:
				{
					num = (short)68091904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)929431553;
				if (num != 0)
				{
				}
				num = (short)956170240;
				if (num != 0)
				{
				}
				return this.emerWideManDownMotionlessSensitivity_A40002._HasDiffs;
			}
		}

		// Token: 0x17004D77 RID: 19831
		// (get) Token: 0x06009A40 RID: 39488 RVA: 0x00907CE8 File Offset: 0x00905EE8
		// (set) Token: 0x06009A41 RID: 39489 RVA: 0x00907D9C File Offset: 0x00905F9C
		public int EmerWideManDownPreAlertTimer_A40003Value
		{
			get
			{
				short num = (short)1230691034;
				short num2 = num;
				num = (short)1782635226;
				switch (num2 == num)
				{
				default:
				{
					num = (short)658505728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)625016833;
				if (num != 0)
				{
				}
				num = (short)1132462080;
				if (num != 0)
				{
				}
				return this.emerWideManDownPreAlertTimer_A40003.Value;
			}
			set
			{
				short num = (short)922888671;
				short num2 = num;
				num = (short)1325345247;
				switch (num2 == num)
				{
				default:
				{
					num = (short)800915456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)219348993;
				if (num != 0)
				{
				}
				num = (short)1335623680;
				if (num != 0)
				{
				}
				this.emerWideManDownPreAlertTimer_A40003.Value = value;
			}
		}

		// Token: 0x17004D78 RID: 19832
		// (get) Token: 0x06009A42 RID: 39490 RVA: 0x00907E50 File Offset: 0x00906050
		public global::AcpBusinessLayer.AcpSimpleRangeField EmerWideManDownPreAlertTimer_A40003
		{
			get
			{
				short num = (short)1119617025;
				if (num != 0)
				{
				}
				num = (short)1263534080;
				short num2 = num;
				num = (short)277908488;
				short num3 = num;
				num = (short)1293323272;
				switch (num3 == num)
				{
				}
				num = (short)737083392;
				if (num != 0)
				{
				}
				return this.emerWideManDownPreAlertTimer_A40003;
			}
		}

		// Token: 0x17004D79 RID: 19833
		// (get) Token: 0x06009A43 RID: 39491 RVA: 0x00907F00 File Offset: 0x00906100
		// (set) Token: 0x06009A44 RID: 39492 RVA: 0x00907FB8 File Offset: 0x009061B8
		public string EmerWideManDownPreAlertTimer_A40003_UIValue
		{
			get
			{
				short num = (short)1365884498;
				short num2 = num;
				num = (short)1734983250;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1872101376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1178730496;
				if (num != 0)
				{
				}
				num = (short)1774518273;
				if (num != 0)
				{
				}
				return this.emerWideManDownPreAlertTimer_A40003.UIValue;
			}
			set
			{
				short num = (short)1006151290;
				short num2 = num;
				num = (short)1142793850;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1241710592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)956760065;
				if (num != 0)
				{
				}
				num = (short)312279040;
				if (num != 0)
				{
				}
				this.emerWideManDownPreAlertTimer_A40003.UIValue = value;
			}
		}

		// Token: 0x17004D7A RID: 19834
		// (get) Token: 0x06009A45 RID: 39493 RVA: 0x0090806C File Offset: 0x0090626C
		// (set) Token: 0x06009A46 RID: 39494 RVA: 0x00908120 File Offset: 0x00906320
		internal int EmerWideManDownPreAlertTimer_A40003Min
		{
			get
			{
				short num = (short)656605875;
				short num2 = num;
				num = (short)1560478387;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1297481728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)469958656;
				if (num != 0)
				{
				}
				num = (short)796852225;
				if (num != 0)
				{
				}
				return this.emerWideManDownPreAlertTimer_A40003.Min;
			}
			set
			{
				short num = (short)339801487;
				short num2 = num;
				num = (short)2112157071;
				switch (num2 == num)
				{
				default:
				{
					num = (short)851902464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1882259457;
				if (num != 0)
				{
				}
				num = (short)1100611584;
				if (num != 0)
				{
				}
				this.emerWideManDownPreAlertTimer_A40003.Min = value;
			}
		}

		// Token: 0x17004D7B RID: 19835
		// (get) Token: 0x06009A47 RID: 39495 RVA: 0x009081D4 File Offset: 0x009063D4
		// (set) Token: 0x06009A48 RID: 39496 RVA: 0x00908288 File Offset: 0x00906488
		internal int EmerWideManDownPreAlertTimer_A40003Max
		{
			get
			{
				short num = (short)334261906;
				short num2 = num;
				num = (short)364605074;
				switch (num2 == num)
				{
				default:
				{
					num = (short)534118400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1414725632;
				if (num != 0)
				{
				}
				num = (short)1977483265;
				if (num != 0)
				{
				}
				return this.emerWideManDownPreAlertTimer_A40003.Max;
			}
			set
			{
				short num = (short)1981612033;
				if (num != 0)
				{
				}
				num = (short)1075642368;
				short num2 = num;
				num = (short)171144886;
				short num3 = num;
				num = (short)236615350;
				switch (num3 == num)
				{
				}
				num = (short)947650560;
				if (num != 0)
				{
				}
				this.emerWideManDownPreAlertTimer_A40003.Max = value;
			}
		}

		// Token: 0x17004D7C RID: 19836
		// (get) Token: 0x06009A49 RID: 39497 RVA: 0x0090833C File Offset: 0x0090653C
		// (set) Token: 0x06009A4A RID: 39498 RVA: 0x009083F0 File Offset: 0x009065F0
		internal int EmerWideManDownPreAlertTimer_A40003Step
		{
			get
			{
				short num = (short)1876275836;
				short num2 = num;
				num = (short)1108259452;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1061748736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1763115009;
				if (num != 0)
				{
				}
				num = (short)689766400;
				if (num != 0)
				{
				}
				return this.emerWideManDownPreAlertTimer_A40003.StepSize;
			}
			set
			{
				short num = (short)460745297;
				short num2 = num;
				num = (short)206924369;
				switch (num2 == num)
				{
				}
				num = (short)1591148544;
				if (num != 0)
				{
				}
				num = (short)2085814272;
				short num3 = num;
				num = (short)51970049;
				if (num != 0)
				{
				}
				this.emerWideManDownPreAlertTimer_A40003.StepSize = value;
			}
		}

		// Token: 0x17004D7D RID: 19837
		// (get) Token: 0x06009A4B RID: 39499 RVA: 0x009084AC File Offset: 0x009066AC
		// (set) Token: 0x06009A4C RID: 39500 RVA: 0x00908560 File Offset: 0x00906760
		public bool EmerWideManDownPreAlertTimer_A40003_Applicable
		{
			get
			{
				short num = (short)871316929;
				short num2 = num;
				num = (short)1607024065;
				switch (num2 == num)
				{
				}
				num = (short)549978113;
				if (num != 0)
				{
				}
				num = (short)273416192;
				short num3 = num;
				num = (short)37093376;
				if (num != 0)
				{
				}
				return this.emerWideManDownPreAlertTimer_A40003.Applicable;
			}
			set
			{
				short num = (short)2081459467;
				short num2 = num;
				num = (short)289574155;
				switch (num2 == num)
				{
				}
				num = (short)992280577;
				if (num != 0)
				{
				}
				num = (short)1898971136;
				short num3 = num;
				num = (short)1791885312;
				if (num != 0)
				{
				}
				this.emerWideManDownPreAlertTimer_A40003.Applicable = value;
			}
		}

		// Token: 0x17004D7E RID: 19838
		// (get) Token: 0x06009A4D RID: 39501 RVA: 0x00908614 File Offset: 0x00906814
		// (set) Token: 0x06009A4E RID: 39502 RVA: 0x009086CC File Offset: 0x009068CC
		public bool EmerWideManDownPreAlertTimer_A40003_Valid
		{
			get
			{
				short num = (short)1358575318;
				short num2 = num;
				num = (short)1176581846;
				switch (num2 == num)
				{
				}
				num = (short)542507009;
				if (num != 0)
				{
				}
				num = (short)228982784;
				short num3 = num;
				num = (short)2040528896;
				if (num != 0)
				{
				}
				return this.emerWideManDownPreAlertTimer_A40003.Valid;
			}
			set
			{
				short num = (short)448573724;
				short num2 = num;
				num = (short)1776464156;
				switch (num2 == num)
				{
				}
				num = (short)527761408;
				if (num != 0)
				{
				}
				num = (short)694550528;
				short num3 = num;
				num = (short)418381825;
				if (num != 0)
				{
				}
				this.emerWideManDownPreAlertTimer_A40003.Valid = value;
			}
		}

		// Token: 0x17004D7F RID: 19839
		// (get) Token: 0x06009A4F RID: 39503 RVA: 0x00908784 File Offset: 0x00906984
		// (set) Token: 0x06009A50 RID: 39504 RVA: 0x00908838 File Offset: 0x00906A38
		public bool EmerWideManDownPreAlertTimer_A40003_Visible
		{
			get
			{
				short num = (short)1083413085;
				short num2 = num;
				num = (short)160076381;
				switch (num2 == num)
				{
				}
				num = (short)261488641;
				if (num != 0)
				{
				}
				num = (short)1966080;
				short num3 = num;
				num = (short)600965120;
				if (num != 0)
				{
				}
				return this.emerWideManDownPreAlertTimer_A40003.Visible;
			}
			set
			{
				short num = (short)898898367;
				short num2 = num;
				num = (short)179378623;
				switch (num2 == num)
				{
				}
				num = (short)1903558656;
				if (num != 0)
				{
				}
				num = (short)69140480;
				short num3 = num;
				num = (short)1020526593;
				if (num != 0)
				{
				}
				this.emerWideManDownPreAlertTimer_A40003.Visible = value;
			}
		}

		// Token: 0x17004D80 RID: 19840
		// (get) Token: 0x06009A51 RID: 39505 RVA: 0x009088EC File Offset: 0x00906AEC
		// (set) Token: 0x06009A52 RID: 39506 RVA: 0x009089A0 File Offset: 0x00906BA0
		public bool EmerWideManDownPreAlertTimer_A40003_Editable
		{
			get
			{
				short num = (short)1043161821;
				short num2 = num;
				num = (short)2097111773;
				switch (num2 == num)
				{
				}
				num = (short)1001455616;
				if (num != 0)
				{
				}
				num = (short)1708326912;
				short num3 = num;
				num = (short)136970241;
				if (num != 0)
				{
				}
				return this.emerWideManDownPreAlertTimer_A40003.Editable;
			}
			set
			{
				short num = (short)246875684;
				short num2 = num;
				num = (short)1226769956;
				switch (num2 == num)
				{
				}
				num = (short)1249247232;
				if (num != 0)
				{
				}
				num = (short)1250164736;
				short num3 = num;
				num = (short)152043521;
				if (num != 0)
				{
				}
				this.emerWideManDownPreAlertTimer_A40003.Editable = value;
			}
		}

		// Token: 0x17004D81 RID: 19841
		// (get) Token: 0x06009A53 RID: 39507 RVA: 0x00908A54 File Offset: 0x00906C54
		internal string EmerWideManDownPreAlertTimer_A40003_UILabel
		{
			get
			{
				short num = (short)2080389201;
				short num2 = num;
				num = (short)1472936017;
				switch (num2 == num)
				{
				}
				num = (short)1189740545;
				if (num != 0)
				{
				}
				num = (short)1843003392;
				short num3 = num;
				num = (short)1753612288;
				if (num != 0)
				{
				}
				return this.emerWideManDownPreAlertTimer_A40003.UIName;
			}
		}

		// Token: 0x17004D82 RID: 19842
		// (get) Token: 0x06009A54 RID: 39508 RVA: 0x00908B0C File Offset: 0x00906D0C
		// (set) Token: 0x06009A55 RID: 39509 RVA: 0x00908BC4 File Offset: 0x00906DC4
		internal bool EmerWideManDownPreAlertTimer_A40003_HiddenStatic
		{
			get
			{
				short num = (short)1339539364;
				short num2 = num;
				num = (short)516538276;
				switch (num2 == num)
				{
				}
				num = (short)1638334465;
				if (num != 0)
				{
				}
				num = (short)1574830080;
				short num3 = num;
				num = (short)1359609856;
				if (num != 0)
				{
				}
				return this.emerWideManDownPreAlertTimer_A40003.HiddenStatic;
			}
			set
			{
				short num = (short)1246045551;
				short num2 = num;
				num = (short)1924408687;
				switch (num2 == num)
				{
				}
				num = (short)1343619073;
				if (num != 0)
				{
				}
				num = (short)711196672;
				short num3 = num;
				num = (short)1304690688;
				if (num != 0)
				{
				}
				this.emerWideManDownPreAlertTimer_A40003.HiddenStatic = value;
			}
		}

		// Token: 0x17004D83 RID: 19843
		// (get) Token: 0x06009A56 RID: 39510 RVA: 0x00908C78 File Offset: 0x00906E78
		// (set) Token: 0x06009A57 RID: 39511 RVA: 0x00908D2C File Offset: 0x00906F2C
		internal bool EmerWideManDownPreAlertTimer_A40003_HiddenDynamic
		{
			get
			{
				short num = (short)1789303665;
				short num2 = num;
				num = (short)1833081713;
				switch (num2 == num)
				{
				}
				num = (short)2021326848;
				if (num != 0)
				{
				}
				num = (short)1088880640;
				short num3 = num;
				num = (short)1633026049;
				if (num != 0)
				{
				}
				return this.emerWideManDownPreAlertTimer_A40003.HiddenDynamic;
			}
			set
			{
				short num = (short)720887123;
				short num2 = num;
				num = (short)1968168275;
				switch (num2 == num)
				{
				}
				num = (short)1773076481;
				if (num != 0)
				{
				}
				num = (short)1476591616;
				short num3 = num;
				num = (short)499253248;
				if (num != 0)
				{
				}
				this.emerWideManDownPreAlertTimer_A40003.HiddenDynamic = value;
			}
		}

		// Token: 0x17004D84 RID: 19844
		// (get) Token: 0x06009A58 RID: 39512 RVA: 0x00908DE4 File Offset: 0x00906FE4
		public bool EmerWideManDownPreAlertTimer_A40003_HasDiffs
		{
			get
			{
				short num = (short)1166543664;
				short num2 = num;
				num = (short)1531054896;
				switch (num2 == num)
				{
				}
				num = (short)1803550720;
				if (num != 0)
				{
				}
				num = (short)747569152;
				short num3 = num;
				num = (short)1248526337;
				if (num != 0)
				{
				}
				return this.emerWideManDownPreAlertTimer_A40003._HasDiffs;
			}
		}

		// Token: 0x17004D85 RID: 19845
		// (get) Token: 0x06009A59 RID: 39513 RVA: 0x00908E98 File Offset: 0x00907098
		// (set) Token: 0x06009A5A RID: 39514 RVA: 0x00908F50 File Offset: 0x00907150
		public int EmerWideManDownPostAlertTimer_A40004Value
		{
			get
			{
				short num = (short)896524261;
				short num2 = num;
				num = (short)1066983397;
				switch (num2 == num)
				{
				}
				num = (short)129302529;
				if (num != 0)
				{
				}
				num = (short)1781071872;
				short num3 = num;
				num = (short)757661696;
				if (num != 0)
				{
				}
				return this.emerWideManDownPostAlertTimer_A40004.Value;
			}
			set
			{
				short num = (short)1211269654;
				short num2 = num;
				num = (short)950501910;
				switch (num2 == num)
				{
				}
				num = (short)1028063233;
				if (num != 0)
				{
				}
				num = (short)561905664;
				short num3 = num;
				num = (short)506134528;
				if (num != 0)
				{
				}
				this.emerWideManDownPostAlertTimer_A40004.Value = value;
			}
		}

		// Token: 0x17004D86 RID: 19846
		// (get) Token: 0x06009A5B RID: 39515 RVA: 0x00909004 File Offset: 0x00907204
		public global::AcpBusinessLayer.AcpSimpleRangeField EmerWideManDownPostAlertTimer_A40004
		{
			get
			{
				short num = (short)477410859;
				short num2 = num;
				num = (short)450016811;
				switch (num2 == num)
				{
				}
				num = (short)1220345857;
				if (num != 0)
				{
				}
				num = (short)194641920;
				short num3 = num;
				num = (short)161742848;
				if (num != 0)
				{
				}
				return this.emerWideManDownPostAlertTimer_A40004;
			}
		}

		// Token: 0x17004D87 RID: 19847
		// (get) Token: 0x06009A5C RID: 39516 RVA: 0x009090B4 File Offset: 0x009072B4
		// (set) Token: 0x06009A5D RID: 39517 RVA: 0x00909168 File Offset: 0x00907368
		public string EmerWideManDownPostAlertTimer_A40004_UIValue
		{
			get
			{
				short num = (short)1898731912;
				short num2 = num;
				num = (short)114645384;
				switch (num2 == num)
				{
				}
				num = (short)631963649;
				if (num != 0)
				{
				}
				num = (short)892076032;
				short num3 = num;
				num = (short)1996750848;
				if (num != 0)
				{
				}
				return this.emerWideManDownPostAlertTimer_A40004.UIValue;
			}
			set
			{
				short num = (short)574202284;
				short num2 = num;
				num = (short)1199874476;
				switch (num2 == num)
				{
				}
				num = (short)2072182785;
				if (num != 0)
				{
				}
				num = (short)467664896;
				short num3 = num;
				num = (short)1537015808;
				if (num != 0)
				{
				}
				this.emerWideManDownPostAlertTimer_A40004.UIValue = value;
			}
		}

		// Token: 0x17004D88 RID: 19848
		// (get) Token: 0x06009A5E RID: 39518 RVA: 0x0090921C File Offset: 0x0090741C
		// (set) Token: 0x06009A5F RID: 39519 RVA: 0x009092D0 File Offset: 0x009074D0
		internal int EmerWideManDownPostAlertTimer_A40004Min
		{
			get
			{
				short num = (short)1559834173;
				short num2 = num;
				num = (short)1232219709;
				switch (num2 == num)
				{
				}
				num = (short)257884161;
				if (num != 0)
				{
				}
				num = (short)792068096;
				short num3 = num;
				num = (short)1919680512;
				if (num != 0)
				{
				}
				return this.emerWideManDownPostAlertTimer_A40004.Min;
			}
			set
			{
				short num = (short)451049383;
				short num2 = num;
				num = (short)1041266599;
				switch (num2 == num)
				{
				}
				num = (short)874446848;
				if (num != 0)
				{
				}
				num = (short)693043200;
				short num3 = num;
				num = (short)1258160129;
				if (num != 0)
				{
				}
				this.emerWideManDownPostAlertTimer_A40004.Min = value;
			}
		}

		// Token: 0x17004D89 RID: 19849
		// (get) Token: 0x06009A60 RID: 39520 RVA: 0x00909388 File Offset: 0x00907588
		// (set) Token: 0x06009A61 RID: 39521 RVA: 0x0090943C File Offset: 0x0090763C
		internal int EmerWideManDownPostAlertTimer_A40004Max
		{
			get
			{
				short num = (short)1062236159;
				short num2 = num;
				num = (short)608399359;
				switch (num2 == num)
				{
				}
				num = (short)1310720000;
				if (num != 0)
				{
				}
				num = (short)993591296;
				short num3 = num;
				num = (short)274399233;
				if (num != 0)
				{
				}
				return this.emerWideManDownPostAlertTimer_A40004.Max;
			}
			set
			{
				short num = (short)2095607002;
				short num2 = num;
				num = (short)1302883546;
				switch (num2 == num)
				{
				}
				num = (short)2078736385;
				if (num != 0)
				{
				}
				num = (short)2103312384;
				short num3 = num;
				num = (short)622854144;
				if (num != 0)
				{
				}
				this.emerWideManDownPostAlertTimer_A40004.Max = value;
			}
		}

		// Token: 0x17004D8A RID: 19850
		// (get) Token: 0x06009A62 RID: 39522 RVA: 0x009094F4 File Offset: 0x009076F4
		// (set) Token: 0x06009A63 RID: 39523 RVA: 0x009095AC File Offset: 0x009077AC
		internal int EmerWideManDownPostAlertTimer_A40004Step
		{
			get
			{
				short num = (short)52822017;
				if (num != 0)
				{
				}
				num = (short)972297165;
				short num2 = num;
				num = (short)1774785485;
				switch (num2 == num)
				{
				}
				num = (short)2008350720;
				short num3 = num;
				num = (short)1984430080;
				if (num != 0)
				{
				}
				return this.emerWideManDownPostAlertTimer_A40004.StepSize;
			}
			set
			{
				short num = (short)664600577;
				if (num != 0)
				{
				}
				num = (short)1127721923;
				short num2 = num;
				num = (short)682011587;
				switch (num2 == num)
				{
				}
				num = (short)362938368;
				short num3 = num;
				num = (short)168230912;
				if (num != 0)
				{
				}
				this.emerWideManDownPostAlertTimer_A40004.StepSize = value;
			}
		}

		// Token: 0x17004D8B RID: 19851
		// (get) Token: 0x06009A64 RID: 39524 RVA: 0x00909660 File Offset: 0x00907860
		// (set) Token: 0x06009A65 RID: 39525 RVA: 0x00909714 File Offset: 0x00907914
		public bool EmerWideManDownPostAlertTimer_A40004_Applicable
		{
			get
			{
				short num = (short)1995864082;
				short num2 = num;
				num = (short)1984067602;
				switch (num2 == num)
				{
				}
				num = (short)1562771456;
				if (num != 0)
				{
				}
				num = (short)149487616;
				short num3 = num;
				num = (short)1477902337;
				if (num != 0)
				{
				}
				return this.emerWideManDownPostAlertTimer_A40004.Applicable;
			}
			set
			{
				short num = (short)2048551779;
				short num2 = num;
				num = (short)1082551139;
				switch (num2 == num)
				{
				}
				num = (short)1605173249;
				if (num != 0)
				{
				}
				num = (short)613679104;
				short num3 = num;
				num = (short)1233518592;
				if (num != 0)
				{
				}
				this.emerWideManDownPostAlertTimer_A40004.Applicable = value;
			}
		}

		// Token: 0x17004D8C RID: 19852
		// (get) Token: 0x06009A66 RID: 39526 RVA: 0x009097C8 File Offset: 0x009079C8
		// (set) Token: 0x06009A67 RID: 39527 RVA: 0x00909880 File Offset: 0x00907A80
		public bool EmerWideManDownPostAlertTimer_A40004_Valid
		{
			get
			{
				short num = (short)1110409079;
				short num2 = num;
				num = (short)1555201911;
				switch (num2 == num)
				{
				}
				num = (short)135659520;
				if (num != 0)
				{
				}
				num = (short)1397293056;
				short num3 = num;
				num = (short)1563033601;
				if (num != 0)
				{
				}
				return this.emerWideManDownPostAlertTimer_A40004.Valid;
			}
			set
			{
				short num = (short)1562399201;
				short num2 = num;
				num = (short)1355502049;
				switch (num2 == num)
				{
				}
				num = (short)847249408;
				if (num != 0)
				{
				}
				num = (short)1524170752;
				short num3 = num;
				num = (short)1808334849;
				if (num != 0)
				{
				}
				this.emerWideManDownPostAlertTimer_A40004.Valid = value;
			}
		}

		// Token: 0x17004D8D RID: 19853
		// (get) Token: 0x06009A68 RID: 39528 RVA: 0x00909938 File Offset: 0x00907B38
		// (set) Token: 0x06009A69 RID: 39529 RVA: 0x009099EC File Offset: 0x00907BEC
		public bool EmerWideManDownPostAlertTimer_A40004_Visible
		{
			get
			{
				short num = (short)1801795462;
				short num2 = num;
				num = (short)456275846;
				switch (num2 == num)
				{
				}
				num = (short)256180224;
				if (num != 0)
				{
				}
				num = (short)976224256;
				short num3 = num;
				num = (short)860291073;
				if (num != 0)
				{
				}
				return this.emerWideManDownPostAlertTimer_A40004.Visible;
			}
			set
			{
				short num = (short)939270804;
				short num2 = num;
				num = (short)405611156;
				switch (num2 == num)
				{
				}
				num = (short)1901264896;
				if (num != 0)
				{
				}
				num = (short)568197120;
				short num3 = num;
				num = (short)2080309249;
				if (num != 0)
				{
				}
				this.emerWideManDownPostAlertTimer_A40004.Visible = value;
			}
		}

		// Token: 0x17004D8E RID: 19854
		// (get) Token: 0x06009A6A RID: 39530 RVA: 0x00909AA4 File Offset: 0x00907CA4
		// (set) Token: 0x06009A6B RID: 39531 RVA: 0x00909B58 File Offset: 0x00907D58
		public bool EmerWideManDownPostAlertTimer_A40004_Editable
		{
			get
			{
				short num = (short)1851878673;
				short num2 = num;
				num = (short)1564699921;
				switch (num2 == num)
				{
				}
				num = (short)124387329;
				if (num != 0)
				{
				}
				num = (short)530120704;
				short num3 = num;
				num = (short)1460535296;
				if (num != 0)
				{
				}
				return this.emerWideManDownPostAlertTimer_A40004.Editable;
			}
			set
			{
				short num = (short)1909400838;
				short num2 = num;
				num = (short)394274054;
				switch (num2 == num)
				{
				}
				num = (short)1303642113;
				if (num != 0)
				{
				}
				num = (short)968294400;
				short num3 = num;
				num = (short)1275592704;
				if (num != 0)
				{
				}
				this.emerWideManDownPostAlertTimer_A40004.Editable = value;
			}
		}

		// Token: 0x17004D8F RID: 19855
		// (get) Token: 0x06009A6C RID: 39532 RVA: 0x00909C0C File Offset: 0x00907E0C
		internal string EmerWideManDownPostAlertTimer_A40004_UILabel
		{
			get
			{
				short num = (short)2128309792;
				short num2 = num;
				num = (short)1873636896;
				switch (num2 == num)
				{
				}
				num = (short)1826226176;
				if (num != 0)
				{
				}
				num = (short)1806172160;
				short num3 = num;
				num = (short)495517697;
				if (num != 0)
				{
				}
				return this.emerWideManDownPostAlertTimer_A40004.UIName;
			}
		}

		// Token: 0x17004D90 RID: 19856
		// (get) Token: 0x06009A6D RID: 39533 RVA: 0x00909CC0 File Offset: 0x00907EC0
		// (set) Token: 0x06009A6E RID: 39534 RVA: 0x00909D74 File Offset: 0x00907F74
		internal bool EmerWideManDownPostAlertTimer_A40004_HiddenStatic
		{
			get
			{
				short num = (short)1972498229;
				short num2 = num;
				num = (short)896003893;
				switch (num2 == num)
				{
				}
				num = (short)834928641;
				if (num != 0)
				{
				}
				num = (short)1761345536;
				short num3 = num;
				num = (short)2127429632;
				if (num != 0)
				{
				}
				return this.emerWideManDownPostAlertTimer_A40004.HiddenStatic;
			}
			set
			{
				short num = (short)706312857;
				short num2 = num;
				num = (short)609319577;
				switch (num2 == num)
				{
				}
				num = (short)1085145089;
				if (num != 0)
				{
				}
				num = (short)917962752;
				short num3 = num;
				num = (short)1944190976;
				if (num != 0)
				{
				}
				this.emerWideManDownPostAlertTimer_A40004.HiddenStatic = value;
			}
		}

		// Token: 0x17004D91 RID: 19857
		// (get) Token: 0x06009A6F RID: 39535 RVA: 0x00909E28 File Offset: 0x00908028
		// (set) Token: 0x06009A70 RID: 39536 RVA: 0x00909EE0 File Offset: 0x009080E0
		internal bool EmerWideManDownPostAlertTimer_A40004_HiddenDynamic
		{
			get
			{
				short num = (short)1687859255;
				short num2 = num;
				num = (short)926134327;
				switch (num2 == num)
				{
				}
				num = (short)1702494209;
				if (num != 0)
				{
				}
				num = (short)194707456;
				short num3 = num;
				num = (short)1184956416;
				if (num != 0)
				{
				}
				return this.emerWideManDownPostAlertTimer_A40004.HiddenDynamic;
			}
			set
			{
				short num = (short)247393455;
				short num2 = num;
				num = (short)539946159;
				switch (num2 == num)
				{
				}
				num = (short)1492713473;
				if (num != 0)
				{
				}
				num = (short)1601634304;
				short num3 = num;
				num = (short)1502216192;
				if (num != 0)
				{
				}
				this.emerWideManDownPostAlertTimer_A40004.HiddenDynamic = value;
			}
		}

		// Token: 0x17004D92 RID: 19858
		// (get) Token: 0x06009A71 RID: 39537 RVA: 0x00909F98 File Offset: 0x00908198
		public bool EmerWideManDownPostAlertTimer_A40004_HasDiffs
		{
			get
			{
				short num = (short)316219023;
				short num2 = num;
				num = (short)85008015;
				switch (num2 == num)
				{
				}
				num = (short)751304705;
				if (num != 0)
				{
				}
				num = (short)422576128;
				short num3 = num;
				num = (short)220987392;
				if (num != 0)
				{
				}
				return this.emerWideManDownPostAlertTimer_A40004._HasDiffs;
			}
		}

		// Token: 0x17004D93 RID: 19859
		// (get) Token: 0x06009A72 RID: 39538 RVA: 0x0090A048 File Offset: 0x00908248
		// (set) Token: 0x06009A73 RID: 39539 RVA: 0x0090A0F8 File Offset: 0x009082F8
		public int EmerWidePostAlertTone_A41191Value
		{
			get
			{
				short num = (short)62201388;
				short num2 = num;
				num = (short)85138988;
				switch (num2 == num)
				{
				}
				num = (short)2069561345;
				if (num != 0)
				{
				}
				num = (short)826474496;
				short num3 = num;
				num = (short)389480448;
				if (num != 0)
				{
				}
				return this.emerWidePostAlertTone_A41191.Value;
			}
			set
			{
				short num = (short)597963321;
				short num2 = num;
				num = (short)1189032505;
				switch (num2 == num)
				{
				}
				num = (short)347471873;
				if (num != 0)
				{
				}
				num = (short)2075852800;
				short num3 = num;
				num = (short)984743936;
				if (num != 0)
				{
				}
				this.emerWidePostAlertTone_A41191.Value = value;
			}
		}

		// Token: 0x17004D94 RID: 19860
		// (get) Token: 0x06009A74 RID: 39540 RVA: 0x0090A1AC File Offset: 0x009083AC
		// (set) Token: 0x06009A75 RID: 39541 RVA: 0x0090A264 File Offset: 0x00908464
		public string EmerWidePostAlertTone_A41191_UIValue
		{
			get
			{
				short num = (short)602734593;
				if (num != 0)
				{
				}
				num = (short)1919048773;
				short num2 = num;
				num = (short)947346501;
				switch (num2 == num)
				{
				}
				num = (short)1464139776;
				short num3 = num;
				num = (short)228261888;
				if (num != 0)
				{
				}
				return this.emerWidePostAlertTone_A41191.UIValue;
			}
			set
			{
				short num = (short)1575903001;
				short num2 = num;
				num = (short)400187161;
				switch (num2 == num)
				{
				}
				num = (short)2074083329;
				if (num != 0)
				{
				}
				num = (short)309133312;
				short num3 = num;
				num = (short)982712320;
				if (num != 0)
				{
				}
				this.emerWidePostAlertTone_A41191.UIValue = value;
			}
		}

		// Token: 0x17004D95 RID: 19861
		// (get) Token: 0x06009A76 RID: 39542 RVA: 0x0090A318 File Offset: 0x00908518
		public global::AcpBusinessLayer.AcpListField EmerWidePostAlertTone_A41191
		{
			get
			{
				short num = (short)564337837;
				short num2 = num;
				num = (short)287055021;
				switch (num2 == num)
				{
				}
				num = (short)1998061568;
				if (num != 0)
				{
				}
				num = (short)1600258048;
				short num3 = num;
				num = (short)239861761;
				if (num != 0)
				{
				}
				return this.emerWidePostAlertTone_A41191;
			}
		}

		// Token: 0x17004D96 RID: 19862
		// (get) Token: 0x06009A77 RID: 39543 RVA: 0x0090A3C8 File Offset: 0x009085C8
		// (set) Token: 0x06009A78 RID: 39544 RVA: 0x0090A47C File Offset: 0x0090867C
		public bool EmerWidePostAlertTone_A41191_Applicable
		{
			get
			{
				short num = (short)1207612778;
				short num2 = num;
				num = (short)328316266;
				switch (num2 == num)
				{
				}
				num = (short)1756168193;
				if (num != 0)
				{
				}
				num = (short)120586240;
				short num3 = num;
				num = (short)73138176;
				if (num != 0)
				{
				}
				return this.emerWidePostAlertTone_A41191.Applicable;
			}
			set
			{
				short num = (short)1962774125;
				short num2 = num;
				num = (short)1014271597;
				switch (num2 == num)
				{
				}
				num = (short)42860545;
				if (num != 0)
				{
				}
				num = (short)1366622208;
				short num3 = num;
				num = (short)1302265856;
				if (num != 0)
				{
				}
				this.emerWidePostAlertTone_A41191.Applicable = value;
			}
		}

		// Token: 0x17004D97 RID: 19863
		// (get) Token: 0x06009A79 RID: 39545 RVA: 0x0090A534 File Offset: 0x00908734
		// (set) Token: 0x06009A7A RID: 39546 RVA: 0x0090A5E8 File Offset: 0x009087E8
		public bool EmerWidePostAlertTone_A41191_Valid
		{
			get
			{
				short num = (short)815312564;
				short num2 = num;
				num = (short)1415294644;
				switch (num2 == num)
				{
				}
				num = (short)1707212800;
				if (num != 0)
				{
				}
				num = (short)287440896;
				short num3 = num;
				num = (short)1721565185;
				if (num != 0)
				{
				}
				return this.emerWidePostAlertTone_A41191.Valid;
			}
			set
			{
				short num = (short)1781707553;
				short num2 = num;
				num = (short)659731233;
				switch (num2 == num)
				{
				}
				num = (short)783155200;
				if (num != 0)
				{
				}
				num = (short)784334848;
				short num3 = num;
				num = (short)1256259585;
				if (num != 0)
				{
				}
				this.emerWidePostAlertTone_A41191.Valid = value;
			}
		}

		// Token: 0x17004D98 RID: 19864
		// (get) Token: 0x06009A7B RID: 39547 RVA: 0x0090A69C File Offset: 0x0090889C
		// (set) Token: 0x06009A7C RID: 39548 RVA: 0x0090A754 File Offset: 0x00908954
		public bool EmerWidePostAlertTone_A41191_Visible
		{
			get
			{
				short num = (short)740279956;
				short num2 = num;
				num = (short)1607124628;
				switch (num2 == num)
				{
				}
				num = (short)1534590977;
				if (num != 0)
				{
				}
				num = (short)988872704;
				short num3 = num;
				num = (short)1692532736;
				if (num != 0)
				{
				}
				return this.emerWidePostAlertTone_A41191.Visible;
			}
			set
			{
				short num = (short)132219037;
				short num2 = num;
				num = (short)338002077;
				switch (num2 == num)
				{
				}
				num = (short)1396244481;
				if (num != 0)
				{
				}
				num = (short)2044133376;
				short num3 = num;
				num = (short)255524864;
				if (num != 0)
				{
				}
				this.emerWidePostAlertTone_A41191.Visible = value;
			}
		}

		// Token: 0x17004D99 RID: 19865
		// (get) Token: 0x06009A7D RID: 39549 RVA: 0x0090A808 File Offset: 0x00908A08
		// (set) Token: 0x06009A7E RID: 39550 RVA: 0x0090A8BC File Offset: 0x00908ABC
		public bool EmerWidePostAlertTone_A41191_Editable
		{
			get
			{
				short num = (short)1423654755;
				short num2 = num;
				num = (short)170475363;
				switch (num2 == num)
				{
				}
				num = (short)1914175489;
				if (num != 0)
				{
				}
				num = (short)1652097024;
				short num3 = num;
				num = (short)1690107904;
				if (num != 0)
				{
				}
				return this.emerWidePostAlertTone_A41191.Editable;
			}
			set
			{
				short num = (short)762123529;
				short num2 = num;
				num = (short)1391006985;
				switch (num2 == num)
				{
				}
				num = (short)837353473;
				if (num != 0)
				{
				}
				num = (short)781123584;
				short num3 = num;
				num = (short)1276837888;
				if (num != 0)
				{
				}
				this.emerWidePostAlertTone_A41191.Editable = value;
			}
		}

		// Token: 0x17004D9A RID: 19866
		// (get) Token: 0x06009A7F RID: 39551 RVA: 0x0090A974 File Offset: 0x00908B74
		internal string EmerWidePostAlertTone_A41191_UILabel
		{
			get
			{
				short num = (short)807458057;
				short num2 = num;
				num = (short)527357193;
				switch (num2 == num)
				{
				}
				num = (short)283705345;
				if (num != 0)
				{
				}
				num = (short)1252786176;
				short num3 = num;
				num = (short)1949171712;
				if (num != 0)
				{
				}
				return this.emerWidePostAlertTone_A41191.UIName;
			}
		}

		// Token: 0x17004D9B RID: 19867
		// (get) Token: 0x06009A80 RID: 39552 RVA: 0x0090AA28 File Offset: 0x00908C28
		// (set) Token: 0x06009A81 RID: 39553 RVA: 0x0090AADC File Offset: 0x00908CDC
		internal bool EmerWidePostAlertTone_A41191_HiddenStatic
		{
			get
			{
				short num = (short)202637313;
				if (num != 0)
				{
				}
				num = (short)365855807;
				short num2 = num;
				num = (short)1298498623;
				switch (num2 == num)
				{
				}
				num = (short)76677120;
				short num3 = num;
				num = (short)1826029568;
				if (num != 0)
				{
				}
				return this.emerWidePostAlertTone_A41191.HiddenStatic;
			}
			set
			{
				short num = (short)1331953665;
				if (num != 0)
				{
				}
				num = (short)1670967978;
				short num2 = num;
				num = (short)238875306;
				switch (num2 == num)
				{
				}
				num = (short)1375993856;
				short num3 = num;
				num = (short)535494656;
				if (num != 0)
				{
				}
				this.emerWidePostAlertTone_A41191.HiddenStatic = value;
			}
		}

		// Token: 0x17004D9C RID: 19868
		// (get) Token: 0x06009A82 RID: 39554 RVA: 0x0090AB94 File Offset: 0x00908D94
		// (set) Token: 0x06009A83 RID: 39555 RVA: 0x0090AC48 File Offset: 0x00908E48
		internal bool EmerWidePostAlertTone_A41191_HiddenDynamic
		{
			get
			{
				short num = (short)1486409153;
				short num2 = num;
				num = (short)1635634625;
				switch (num2 == num)
				{
				}
				num = (short)1772748801;
				if (num != 0)
				{
				}
				num = (short)1820131328;
				short num3 = num;
				num = (short)1165885440;
				if (num != 0)
				{
				}
				return this.emerWidePostAlertTone_A41191.HiddenDynamic;
			}
			set
			{
				short num = (short)295510064;
				short num2 = num;
				num = (short)1718100016;
				switch (num2 == num)
				{
				}
				num = (short)712048641;
				if (num != 0)
				{
				}
				num = (short)1208483840;
				short num3 = num;
				num = (short)1728708608;
				if (num != 0)
				{
				}
				this.emerWidePostAlertTone_A41191.HiddenDynamic = value;
			}
		}

		// Token: 0x17004D9D RID: 19869
		// (get) Token: 0x06009A84 RID: 39556 RVA: 0x0090AD00 File Offset: 0x00908F00
		public bool EmerWidePostAlertTone_A41191_HasDiffs
		{
			get
			{
				short num = (short)1453728521;
				short num2 = num;
				num = (short)941368073;
				switch (num2 == num)
				{
				}
				num = (short)1397096449;
				if (num != 0)
				{
				}
				num = (short)1013252096;
				short num3 = num;
				num = (short)1754857472;
				if (num != 0)
				{
				}
				return this.emerWidePostAlertTone_A41191._HasDiffs;
			}
		}

		// Token: 0x17004D9E RID: 19870
		// (get) Token: 0x06009A85 RID: 39557 RVA: 0x0090ADB4 File Offset: 0x00908FB4
		// (set) Token: 0x06009A86 RID: 39558 RVA: 0x0090AE68 File Offset: 0x00909068
		public int ManDownConfigurabilityGranularityLevel_42057Value
		{
			get
			{
				short num = (short)316671320;
				short num2 = num;
				num = (short)468321624;
				switch (num2 == num)
				{
				}
				num = (short)157679616;
				if (num != 0)
				{
				}
				num = (short)402784256;
				short num3 = num;
				num = (short)1654456321;
				if (num != 0)
				{
				}
				return this.manDownConfigurabilityGranularityLevel_42057.Value;
			}
			set
			{
				short num = (short)147200586;
				short num2 = num;
				num = (short)2039552586;
				switch (num2 == num)
				{
				}
				num = (short)655949825;
				if (num != 0)
				{
				}
				num = (short)1122238464;
				short num3 = num;
				num = (short)966787072;
				if (num != 0)
				{
				}
				this.manDownConfigurabilityGranularityLevel_42057.Value = value;
			}
		}

		// Token: 0x17004D9F RID: 19871
		// (get) Token: 0x06009A87 RID: 39559 RVA: 0x0090AF20 File Offset: 0x00909120
		// (set) Token: 0x06009A88 RID: 39560 RVA: 0x0090AFD4 File Offset: 0x009091D4
		public string ManDownConfigurabilityGranularityLevel_42057_UIValue
		{
			get
			{
				short num = (short)549519361;
				if (num != 0)
				{
				}
				num = (short)2082319964;
				short num2 = num;
				num = (short)894545500;
				switch (num2 == num)
				{
				}
				num = (short)1390804992;
				short num3 = num;
				num = (short)437125120;
				if (num != 0)
				{
				}
				return this.manDownConfigurabilityGranularityLevel_42057.UIValue;
			}
			set
			{
				short num = (short)1367277569;
				if (num != 0)
				{
				}
				num = (short)2144723813;
				short num2 = num;
				num = (short)1555882853;
				switch (num2 == num)
				{
				}
				num = (short)596770816;
				short num3 = num;
				num = (short)2013528064;
				if (num != 0)
				{
				}
				this.manDownConfigurabilityGranularityLevel_42057.UIValue = value;
			}
		}

		// Token: 0x17004DA0 RID: 19872
		// (get) Token: 0x06009A89 RID: 39561 RVA: 0x0090B08C File Offset: 0x0090928C
		public global::AcpBusinessLayer.AcpListField ManDownConfigurabilityGranularityLevel_42057
		{
			get
			{
				short num = (short)550305793;
				if (num != 0)
				{
				}
				num = (short)351253571;
				short num2 = num;
				num = (short)1198502979;
				switch (num2 == num)
				{
				}
				num = (short)891420672;
				short num3 = num;
				num = (short)561119232;
				if (num != 0)
				{
				}
				return this.manDownConfigurabilityGranularityLevel_42057;
			}
		}

		// Token: 0x17004DA1 RID: 19873
		// (get) Token: 0x06009A8A RID: 39562 RVA: 0x0090B13C File Offset: 0x0090933C
		// (set) Token: 0x06009A8B RID: 39563 RVA: 0x0090B1F0 File Offset: 0x009093F0
		public bool ManDownConfigurabilityGranularityLevel_42057_Applicable
		{
			get
			{
				short num = (short)1711603915;
				short num2 = num;
				num = (short)1329397963;
				switch (num2 == num)
				{
				}
				num = (short)890568705;
				if (num != 0)
				{
				}
				num = (short)1896022016;
				short num3 = num;
				num = (short)1026621440;
				if (num != 0)
				{
				}
				return this.manDownConfigurabilityGranularityLevel_42057.Applicable;
			}
			set
			{
				short num = (short)1192533264;
				short num2 = num;
				num = (short)273915152;
				switch (num2 == num)
				{
				}
				num = (short)1680998400;
				if (num != 0)
				{
				}
				num = (short)1185677312;
				short num3 = num;
				num = (short)1058275329;
				if (num != 0)
				{
				}
				this.manDownConfigurabilityGranularityLevel_42057.Applicable = value;
			}
		}

		// Token: 0x17004DA2 RID: 19874
		// (get) Token: 0x06009A8C RID: 39564 RVA: 0x0090B2A8 File Offset: 0x009094A8
		// (set) Token: 0x06009A8D RID: 39565 RVA: 0x0090B35C File Offset: 0x0090955C
		public bool ManDownConfigurabilityGranularityLevel_42057_Valid
		{
			get
			{
				short num = (short)651212893;
				short num2 = num;
				num = (short)1484372061;
				switch (num2 == num)
				{
				}
				num = (short)502136833;
				if (num != 0)
				{
				}
				num = (short)1072168960;
				short num3 = num;
				num = (short)1199570944;
				if (num != 0)
				{
				}
				return this.manDownConfigurabilityGranularityLevel_42057.Valid;
			}
			set
			{
				short num = (short)795833963;
				short num2 = num;
				num = (short)1875277419;
				switch (num2 == num)
				{
				}
				num = (short)911671297;
				if (num != 0)
				{
				}
				num = (short)1710817280;
				short num3 = num;
				num = (short)2949120;
				if (num != 0)
				{
				}
				this.manDownConfigurabilityGranularityLevel_42057.Valid = value;
			}
		}

		// Token: 0x17004DA3 RID: 19875
		// (get) Token: 0x06009A8E RID: 39566 RVA: 0x0090B414 File Offset: 0x00909614
		// (set) Token: 0x06009A8F RID: 39567 RVA: 0x0090B4CC File Offset: 0x009096CC
		public bool ManDownConfigurabilityGranularityLevel_42057_Visible
		{
			get
			{
				short num = (short)2044489522;
				short num2 = num;
				num = (short)1487302450;
				switch (num2 == num)
				{
				}
				num = (short)528809985;
				if (num != 0)
				{
				}
				num = (short)1561985024;
				short num3 = num;
				num = (short)1977548800;
				if (num != 0)
				{
				}
				return this.manDownConfigurabilityGranularityLevel_42057.Visible;
			}
			set
			{
				short num = (short)1389829114;
				short num2 = num;
				num = (short)1147345914;
				switch (num2 == num)
				{
				}
				num = (short)1428881409;
				if (num != 0)
				{
				}
				num = (short)1776812032;
				short num3 = num;
				num = (short)780468224;
				if (num != 0)
				{
				}
				this.manDownConfigurabilityGranularityLevel_42057.Visible = value;
			}
		}

		// Token: 0x17004DA4 RID: 19876
		// (get) Token: 0x06009A90 RID: 39568 RVA: 0x0090B580 File Offset: 0x00909780
		// (set) Token: 0x06009A91 RID: 39569 RVA: 0x0090B634 File Offset: 0x00909834
		public bool ManDownConfigurabilityGranularityLevel_42057_Editable
		{
			get
			{
				short num = (short)353239041;
				if (num != 0)
				{
				}
				num = (short)1427137868;
				short num2 = num;
				num = (short)133653836;
				switch (num2 == num)
				{
				}
				num = (short)78839808;
				short num3 = num;
				num = (short)487456768;
				if (num != 0)
				{
				}
				return this.manDownConfigurabilityGranularityLevel_42057.Editable;
			}
			set
			{
				short num = (short)537711071;
				short num2 = num;
				num = (short)969134559;
				switch (num2 == num)
				{
				}
				num = (short)2127560705;
				if (num != 0)
				{
				}
				num = (short)1638858752;
				short num3 = num;
				num = (short)1529282560;
				if (num != 0)
				{
				}
				this.manDownConfigurabilityGranularityLevel_42057.Editable = value;
			}
		}

		// Token: 0x17004DA5 RID: 19877
		// (get) Token: 0x06009A92 RID: 39570 RVA: 0x0090B6EC File Offset: 0x009098EC
		internal string ManDownConfigurabilityGranularityLevel_42057_UILabel
		{
			get
			{
				short num = (short)1998506363;
				short num2 = num;
				num = (short)1413073275;
				switch (num2 == num)
				{
				}
				num = (short)553517057;
				if (num != 0)
				{
				}
				num = (short)1448607744;
				short num3 = num;
				num = (short)326238208;
				if (num != 0)
				{
				}
				return this.manDownConfigurabilityGranularityLevel_42057.UIName;
			}
		}

		// Token: 0x17004DA6 RID: 19878
		// (get) Token: 0x06009A93 RID: 39571 RVA: 0x0090B7A0 File Offset: 0x009099A0
		// (set) Token: 0x06009A94 RID: 39572 RVA: 0x0090B858 File Offset: 0x00909A58
		internal bool ManDownConfigurabilityGranularityLevel_42057_HiddenStatic
		{
			get
			{
				short num = (short)2071739129;
				short num2 = num;
				num = (short)1074543353;
				switch (num2 == num)
				{
				}
				num = (short)1180172288;
				if (num != 0)
				{
				}
				num = (short)1533345792;
				short num3 = num;
				num = (short)766967809;
				if (num != 0)
				{
				}
				return this.manDownConfigurabilityGranularityLevel_42057.HiddenStatic;
			}
			set
			{
				short num = (short)1016365951;
				short num2 = num;
				num = (short)1826980735;
				switch (num2 == num)
				{
				}
				num = (short)2056323072;
				if (num != 0)
				{
				}
				num = (short)1919877120;
				short num3 = num;
				num = (short)153812993;
				if (num != 0)
				{
				}
				this.manDownConfigurabilityGranularityLevel_42057.HiddenStatic = value;
			}
		}

		// Token: 0x17004DA7 RID: 19879
		// (get) Token: 0x06009A95 RID: 39573 RVA: 0x0090B910 File Offset: 0x00909B10
		// (set) Token: 0x06009A96 RID: 39574 RVA: 0x0090B9C8 File Offset: 0x00909BC8
		internal bool ManDownConfigurabilityGranularityLevel_42057_HiddenDynamic
		{
			get
			{
				short num = (short)2056125443;
				short num2 = num;
				num = (short)1715796995;
				switch (num2 == num)
				{
				}
				num = (short)993984513;
				if (num != 0)
				{
				}
				num = (short)1121976320;
				short num3 = num;
				num = (short)773521408;
				if (num != 0)
				{
				}
				return this.manDownConfigurabilityGranularityLevel_42057.HiddenDynamic;
			}
			set
			{
				short num = (short)270277473;
				short num2 = num;
				num = (short)723393377;
				switch (num2 == num)
				{
				}
				num = (short)1677328385;
				if (num != 0)
				{
				}
				num = (short)796065792;
				short num3 = num;
				num = (short)1886126080;
				if (num != 0)
				{
				}
				this.manDownConfigurabilityGranularityLevel_42057.HiddenDynamic = value;
			}
		}

		// Token: 0x17004DA8 RID: 19880
		// (get) Token: 0x06009A97 RID: 39575 RVA: 0x0090BA7C File Offset: 0x00909C7C
		public bool ManDownConfigurabilityGranularityLevel_42057_HasDiffs
		{
			get
			{
				short num = (short)1000280294;
				short num2 = num;
				num = (short)1529155814;
				switch (num2 == num)
				{
				}
				num = (short)1439105025;
				if (num != 0)
				{
				}
				num = (short)557776896;
				short num3 = num;
				num = (short)1210056704;
				if (num != 0)
				{
				}
				return this.manDownConfigurabilityGranularityLevel_42057._HasDiffs;
			}
		}

		// Token: 0x06009A98 RID: 39576 RVA: 0x0090BB30 File Offset: 0x00909D30
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
					num2 = (short)318373888;
					short num3 = num2;
					num2 = (short)35213356;
					short num4 = num2;
					num2 = (short)171135020;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_81;
					default:
						num2 = (short)2015428608;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)1924005891;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				case 1:
					return result;
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)866516996;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					goto IL_81;
				case 4:
					num2 = (short)1538457601;
					if (num2 != 0)
					{
					}
					num2 = (short)496238592;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_81:
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num2 = (short)1439236097;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1826816002;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04004BDE RID: 19422
		private global::AcpBusinessLayer.AcpListField emerWideManDownTrigger_A40001;

		// Token: 0x04004BDF RID: 19423
		private global::AcpBusinessLayer.AcpListField emerWideManDownMotionlessSensitivity_A40002;

		// Token: 0x04004BE0 RID: 19424
		private global::AcpBusinessLayer.AcpSimpleRangeField emerWideManDownPreAlertTimer_A40003;

		// Token: 0x04004BE1 RID: 19425
		private global::AcpBusinessLayer.AcpSimpleRangeField emerWideManDownPostAlertTimer_A40004;

		// Token: 0x04004BE2 RID: 19426
		private global::AcpBusinessLayer.AcpListField emerWidePostAlertTone_A41191;

		// Token: 0x04004BE3 RID: 19427
		private global::AcpBusinessLayer.AcpListField manDownConfigurabilityGranularityLevel_42057;
	}
}
