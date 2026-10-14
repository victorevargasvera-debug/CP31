using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles
{
	// Token: 0x02000493 RID: 1171
	public static class ConventionalEmergencyProfilesConstraints
	{
		// Token: 0x06009A99 RID: 39577 RVA: 0x0090BCA4 File Offset: 0x00909EA4
		internal static bool ConEmergencyTypeisAlarmAndCall(global::AcpCommonLib.IAcpFeatureSection self)
		{
			while ((self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles).General.CnvEmerProfGeneralEmergencyType_A7960.Value == 1)
			{
				short num = (short)1527996002;
				short num2 = num;
				num = (short)1861508706;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)868548608;
					short num3 = num;
					num = (short)1897136129;
					if (num != 0)
					{
					}
					num = (short)853606400;
					if (num != 0)
					{
					}
					return true;
				}
				}
			}
			return false;
		}

		// Token: 0x06009A9A RID: 39578 RVA: 0x0090BD74 File Offset: 0x00909F74
		internal static bool conEmerTypeIsAlarmAndCallValidity(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			int num;
			bool result;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.General general;
			short num2;
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
						return result;
					case 1:
						if (general.CnvEmerProfGeneralEmergencyType_A7960.Value == 1)
						{
							num2 = (short)178520072;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = false;
						num2 = (short)430833667;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						if (index != 0)
						{
							num2 = (short)2030895110;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = true;
						num2 = (short)2044919817;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						return result;
					case 4:
						num2 = (short)254017536;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
					{
						num2 = (short)2048335190;
						short num3 = num2;
						num2 = (short)615849302;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_41;
						default:
						{
							num2 = (short)1728315392;
							if (num2 != 0)
							{
							}
							num2 = (short)1929838592;
							short num4 = num2;
							num2 = (short)1582628865;
							if (num2 != 0)
							{
							}
							if (index - 1 > 1)
							{
								num2 = (short)833159172;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)1990918145;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 6:
						num2 = (short)606339077;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
						return result;
					case 8:
						result = true;
						num2 = (short)1008271367;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 9:
						return result;
					}
					goto IL_38;
				}
				return result;
			}
			IL_38:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.General);
			result = true;
			IL_41:
			num2 = (short)1891041282;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06009A9B RID: 39579 RVA: 0x0090BF74 File Offset: 0x0090A174
		internal static bool conEmerTypeIsAlarmAndCallAndAutoModeIsHotMic(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.General general;
			short num;
			for (;;)
			{
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.General);
				if (general.CnvEmerProfGeneralEmergencyType_A7960.Value == 1)
				{
					num = (short)487325697;
					if (num != 0)
					{
					}
					num = (short)1764542813;
					short num2 = num;
					num = (short)1589496157;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_A0;
					}
					break;
				}
				return false;
			}
			num = (short)414777344;
			short num3 = num;
			IL_A0:
			num = (short)1371340800;
			if (num != 0)
			{
			}
			return general.ConEmerProEmergencyAutoTransmitMode_A22532.Value == 2;
		}

		// Token: 0x06009A9C RID: 39580 RVA: 0x0090C048 File Offset: 0x0090A248
		internal static bool conEmerTypeIsAlarmAndCallAndAutoModeIsSilentAudio(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.General general;
			short num;
			for (;;)
			{
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.General);
				if (general.CnvEmerProfGeneralEmergencyType_A7960.Value != 1)
				{
					return false;
				}
				num = (short)1730328641;
				short num2 = num;
				num = (short)405125185;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_4E;
				}
			}
			IL_4E:
			num = (short)1793654784;
			short num3 = num;
			num = (short)695468032;
			if (num != 0)
			{
			}
			num = (short)110886913;
			if (num != 0)
			{
			}
			return general.ConEmerProEmergencyAutoTransmitMode_A22532.Value == 1;
		}

		// Token: 0x06009A9D RID: 39581 RVA: 0x0090C118 File Offset: 0x0090A318
		internal static bool ConEmerRemoMonIsInvalidWhenEnabledAndTypeisNotAlarmAndCall(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_90;
			}
			short num;
			int num3;
			global::AcpBusinessLayer.AcpField<bool> cnvEmerProfMDCEnable2_A;
			for (;;)
			{
				IL_0A:
				num = (short)418887906;
				short num2 = num;
				num = (short)331725026;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)320929793;
					if (num != 0)
					{
					}
					num = (short)461701120;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						if (cnvEmerProfMDCEnable2_A.Value)
						{
							num = (short)2097348610;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E3;
					case 1:
						if (cnvEmerProfMDCEnable2_A.Value)
						{
							num = (short)480575491;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 2:
						goto IL_15B;
					case 3:
						goto IL_E1;
					}
					goto IL_90;
				}
				IL_E1:
				num = (short)297074688;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_E3:
			num = (short)62193664;
			short num4 = num;
			return false;
			IL_15B:
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles conventionalEmergencyProfiles;
			return conventionalEmergencyProfiles.General.CnvEmerProfGeneralEmergencyType_A7960.Value == 1;
			IL_90:
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.MDC mdc = self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.MDC;
			conventionalEmergencyProfiles = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles);
			cnvEmerProfMDCEnable2_A = mdc.CnvEmerProfMDCEnable2_A7924;
			num = (short)1285619713;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06009A9E RID: 39582 RVA: 0x0090C284 File Offset: 0x0090A484
		internal static bool ConPerEmerProfIsSelected(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.General general;
			short num;
			for (;;)
			{
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.General);
				if (general.RefEmergencyWide.ManDown.EmerWideManDownTrigger_A40001.Value == 0)
				{
					return false;
				}
				num = (short)1268764995;
				short num2 = num;
				num = (short)1622987075;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_57;
				}
			}
			IL_57:
			num = (short)273088512;
			short num3 = num;
			num = (short)279576577;
			if (num != 0)
			{
			}
			num = (short)1145044992;
			if (num != 0)
			{
			}
			return general.RefEmergencyWide.ManDown.ManDownConfigurabilityGranularityLevel_42057.Value == 1;
		}

		// Token: 0x06009A9F RID: 39583 RVA: 0x0090C368 File Offset: 0x0090A568
		internal static bool conTonePeriodInvalid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::AcpBusinessLayer.AcpSimpleRangeField emerTonePeriodSec_;
			short num;
			for (;;)
			{
				emerTonePeriodSec_ = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInnerSection).EmerTonePeriodSec_42048;
				if (emerTonePeriodSec_.Value < 1)
				{
					return true;
				}
				num = (short)219543586;
				short num2 = num;
				num = (short)1901525026;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_4E;
				}
			}
			IL_4E:
			num = (short)554237952;
			short num3 = num;
			num = (short)973930496;
			if (num != 0)
			{
			}
			num = (short)372637697;
			if (num != 0)
			{
			}
			return emerTonePeriodSec_.Value > 4;
		}

		// Token: 0x06009AA0 RID: 39584 RVA: 0x0090C434 File Offset: 0x0090A634
		internal static bool ConCnvLegacyToneNotSelected(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInnerSection emergencyToneTableInnerSection;
			short num2;
			global::AcpBusinessLayer.AcpListField emerTone_;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles conventionalEmergencyProfiles;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (emergencyToneTableInnerSection.RefEmergencyWide.ManDown.ManDownConfigurabilityGranularityLevel_42057.Value != 1)
					{
						num2 = (short)1184301066;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 1:
					if (emerTone_ != 0)
					{
						num2 = (short)1518927874;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_18D;
				case 2:
					num2 = (short)2040266758;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)1503920128;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_C4;
				case 5:
					if (emerTone_ != 0)
					{
						num2 = (short)1594621961;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 6:
					if (emergencyToneTableInnerSection.RefEmergencyWide.ManDown.EmerWideManDownTrigger_A40001.Value != 0)
					{
						num2 = (short)1306525699;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_18D;
				case 7:
					num2 = (short)442040325;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)1832386561;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_160;
				case 10:
					goto IL_2C1;
				case 11:
					if (conventionalEmergencyProfiles.General.CnvEmerProfImpactDetectionEn_A43391)
					{
						num2 = (short)1970012167;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_40;
			}
			IL_160:
			num2 = (short)422576129;
			if (num2 != 0)
			{
			}
			return emergencyToneTableInnerSection.RefEmergencyWide.EmergencyWideImpactDetection.EmerWideImpactDetectionConfigLevel_A43384.Value == 2;
			IL_2C1:
			goto IL_18D;
			IL_40:
			emergencyToneTableInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInnerSection);
			conventionalEmergencyProfiles = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles);
			emerTone_ = emergencyToneTableInnerSection.EmerTone_42046;
			num2 = (short)54791562;
			short num3 = num2;
			num2 = (short)1904414090;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_C4:
				num2 = (short)977600512;
				short num4 = num2;
				if (emergencyToneTableInnerSection.RefEmergencyWide.EmergencyToneTrigger.TriggedByManDown_42135)
				{
					num2 = (short)104792072;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			}
			default:
				num2 = (short)1851326464;
				if (num2 != 0)
				{
				}
				num2 = (short)530120708;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_18D:
			num2 = (short)98172939;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06009AA1 RID: 39585 RVA: 0x0090C708 File Offset: 0x0090A908
		internal static bool conTriggedByManDownEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInnerSection emergencyToneTableInnerSection;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles conventionalEmergencyProfiles;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (emergencyToneTableInnerSection.RefEmergencyWide.ManDown.ManDownConfigurabilityGranularityLevel_42057.Value == 1)
					{
						num2 = (short)1186725892;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D3;
				case 1:
					if (emergencyToneTableInnerSection.RefEmergencyWide.ManDown.EmerWideManDownTrigger_A40001.Value != 0)
					{
						goto IL_78;
					}
					goto IL_D3;
				case 2:
					goto IL_114;
				case 3:
					num2 = (short)421920769;
					if (num2 != 0)
					{
					}
					if (!emergencyToneTableInnerSection.RefEmergencyWide.EmergencyToneTrigger.TriggedByManDown_42135)
					{
						num2 = (short)2074411014;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 4:
					num2 = (short)1520697347;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)1884880896;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					num2 = (short)1602983944;
					short num3 = num2;
					num2 = (short)1135974408;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_78;
					default:
						num2 = (short)51052544;
						if (num2 != 0)
						{
						}
						goto IL_D3;
					}
					break;
				}
				case 7:
					if (conventionalEmergencyProfiles.General.CnvEmerProfImpactDetectionEn_A43391)
					{
						num2 = (short)662241282;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_30;
				IL_78:
				num2 = (short)667877376;
				short num4 = num2;
				num2 = (short)2049048581;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_D3:
				num2 = (short)1426456583;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_114:
			return emergencyToneTableInnerSection.RefEmergencyWide.EmergencyWideImpactDetection.EmerWideImpactDetectionConfigLevel_A43384.Value == 2;
			IL_30:
			emergencyToneTableInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInnerSection);
			conventionalEmergencyProfiles = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles);
			num2 = (short)133169153;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06009AA2 RID: 39586 RVA: 0x0090C934 File Offset: 0x0090AB34
		internal static bool conCnvAudioRoutingIsApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInnerSection emergencyToneTableInnerSection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)147914757;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_F5;
				case 2:
					if (emergencyToneTableInnerSection.RefEmergencyWide.EmergencyToneTrigger.TriggedByManDown_42135)
					{
						num2 = (short)1628635143;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C0;
				case 3:
					if (emergencyToneTableInnerSection.EmerTone_42046 != 0)
					{
						num2 = (short)219152384;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C0;
				case 4:
					if (emergencyToneTableInnerSection.RefEmergencyWide.ManDown.EmerWideManDownTrigger_A40001.Value != 0)
					{
						num2 = (short)384827393;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C0;
				case 5:
					if (emergencyToneTableInnerSection.EmerTonePeriodSec_42048 >= 5)
					{
						goto IL_148;
					}
					goto IL_1C0;
				case 6:
					num2 = (short)1555300356;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)540672003;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_30;
				IL_148:
				num2 = (short)422182918;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1C0:
				num2 = (short)1800511686;
				short num3 = num2;
				num2 = (short)965320902;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_148;
				default:
					goto IL_1F5;
				}
			}
			IL_F5:
			num2 = (short)553189376;
			short num4 = num2;
			return emergencyToneTableInnerSection.RefEmergencyWide.ManDown.ManDownConfigurabilityGranularityLevel_42057.Value == 1;
			IL_1F5:
			num2 = (short)1882062848;
			if (num2 != 0)
			{
			}
			return false;
			IL_30:
			emergencyToneTableInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInnerSection);
			num2 = (short)2100690945;
			if (num2 != 0)
			{
			}
			num2 = (short)991494146;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06009AA3 RID: 39587 RVA: 0x0090CB50 File Offset: 0x0090AD50
		internal static bool conAutoModeIsHotMicEmergencyForCVN(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)429620086;
			short num2 = num;
			num = (short)121338742;
			switch (num2 == num)
			{
			default:
			{
				num = (short)707657728;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1059323904;
			if (num != 0)
			{
			}
			num = (short)1223622657;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.General).ConEmerProEmergencyAutoTransmitMode_A22532.Value == 2;
		}

		// Token: 0x06009AA4 RID: 39588 RVA: 0x0090CC0C File Offset: 0x0090AE0C
		internal static bool conImpDetectApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)74719603;
			short num2 = num;
			num = (short)674963827;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1476853760;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1604714497;
			if (num != 0)
			{
			}
			num = (short)726532096;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.General).RefEmergencyWide.EmergencyWideImpactDetection.EmerWideImpactDetectionConfigLevel_A43384.Value == 2;
		}

		// Token: 0x06009AA5 RID: 39589 RVA: 0x0090CCD4 File Offset: 0x0090AED4
		internal static bool ConConvEmerHotMicRestartIsApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			if ((self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles).General.ConEmerProEmergencyAutoTransmitMode_A22532.Value != 2)
			{
				num = (short)1160403560;
				short num2 = num;
				num = (short)710498920;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)884211712;
					if (num != 0)
					{
					}
					num = (short)1242169344;
					short num3 = num;
					return false;
				}
				}
			}
			num = (short)1353908225;
			if (num != 0)
			{
			}
			return global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesConstraints.CheckConvEmergencyCompatibilityOptions(self);
		}

		// Token: 0x06009AA6 RID: 39590 RVA: 0x0090CDA4 File Offset: 0x0090AFA4
		internal static bool ConValidateConvSysConsoleEmergExitContr(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)963837955;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_7F;
				case 2:
					return result;
				case 3:
					num2 = (short)1089142785;
					if (num2 != 0)
					{
					}
					if (index == 2)
					{
						num2 = (short)771162113;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					if (index != 1)
					{
						num2 = (short)2007040000;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_7F;
				}
				goto IL_24;
				IL_7F:
				result = global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesConstraints.CheckConvEmergencyCompatibilityOptions(self);
				num2 = (short)1513262381;
				short num3 = num2;
				num2 = (short)382242093;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					return result;
				default:
					num2 = (short)1014890496;
					if (num2 != 0)
					{
					}
					num2 = (short)397279234;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
			}
			return result;
			IL_24:
			num2 = (short)2066874368;
			short num4 = num2;
			result = true;
			num2 = (short)886243332;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06009AA7 RID: 39591 RVA: 0x0090CF00 File Offset: 0x0090B100
		internal static bool CheckConvEmergencyCompatibilityOptions(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			for (;;)
			{
				num = (short)359792640;
				switch (num)
				{
				default:
				{
					num = (short)1400373248;
					short num2 = num;
					num = (short)1917380438;
					short num3 = num;
					num = (short)271443798;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_7E;
					}
					break;
				}
				}
			}
			IL_7E:
			num = (short)1588723713;
			if (num != 0)
			{
			}
			num = (short)909705216;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles conventionalEmergencyProfiles = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles;
			global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection = global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset;
			bool result = false;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = collection.GetEnumerator();
			bool result2;
			try
			{
				num = (short)79233036;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles conventionalEmergencyProfiles2;
						if (conventionalEmergencyProfiles2 != null)
						{
							num = (short)1981415441;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if (conventionalSystem != null)
						{
							num = (short)1977417732;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						num = (short)1092419599;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles conventionalEmergencyProfiles2 = conventionalSystem.General.CnvSysGeneralEmergencyProfileSelection_A19421.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles;
						num = (short)665124864;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 2)
						{
							num = (short)452263939;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_155;
					}
					case 6:
						goto IL_3CC;
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles conventionalEmergencyProfiles2;
						if (conventionalEmergencyProfiles2.NodeId == conventionalEmergencyProfiles.NodeId)
						{
							num = (short)394461194;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles conventionalEmergencyProfiles2;
						if (conventionalEmergencyProfiles2.General.CnvEmerProfGeneralEmergencyType_A7960.Value == 1)
						{
							num = (short)1405747209;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_155;
					}
					case 9:
						result = true;
						num = (short)1692598273;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)1334509573;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_16D;
					case 12:
						switch (0)
						{
						case 0:
							goto IL_150;
						}
						continue;
					case 13:
						num = (short)1871314950;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)277938189;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator.Current;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
						num = (short)243597314;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.Value == 1)
						{
							num = (short)628490256;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_155;
					}
					case 16:
						num = (short)1133182984;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)1990524935;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_150;
					IL_155:
					result2 = false;
					num = (short)162594827;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_211:
					num = (short)1464008718;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_150:
					goto IL_211;
				}
				IL_16D:
				return result2;
				IL_3CC:
				return result;
			}
			finally
			{
				num = (short)1290076160;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_404;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)1494286338;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_43B;
					}
					IL_404:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1593638913;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_43B:;
			}
			return result2;
		}

		// Token: 0x06009AA8 RID: 39592 RVA: 0x0090D36C File Offset: 0x0090B56C
		internal static void conSetValueCnvHotMicTxPeriod(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)771227648;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4F;
				}
				int num4;
				int num5;
				global::AcpBusinessLayer.AcpSimpleRangeField cnvEmerProfGeneralTxPeriodsec2_A;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						num = (short)1194917888;
						short num3 = num;
						num = (short)189661185;
						if (num != 0)
						{
						}
						goto IL_18D;
					}
					case 1:
						num = (short)1443430407;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_208;
					case 3:
						if (num4 >= num5)
						{
							num = (short)539099142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1002831877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_7B;
					case 5:
					{
						if (cnvEmerProfGeneralTxPeriodsec2_A <= num4 * 10)
						{
							goto IL_80;
						}
						num = (short)799343684;
						short num6 = num;
						num = (short)2044920900;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7B;
						default:
							num = (short)614793216;
							if (num != 0)
							{
							}
							num = (short)759889921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						return;
					case 7:
						if (cnvEmerProfGeneralTxPeriodsec2_A <= (num4 + 1) * 10)
						{
							num = (short)554369026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_80;
					}
					goto IL_4F;
					IL_80:
					num4++;
					num = (short)1754660864;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18D:
					num = (short)2030632963;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7B:
					goto IL_18D;
				}
				return;
				IL_208:
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.General general;
				general.CnvEmerProfGeneralTxPeriodsec1_A8212.Value = num4 + 1;
				return;
				IL_4F:
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.General);
				cnvEmerProfGeneralTxPeriodsec2_A = general.CnvEmerProfGeneralTxPeriodsec2_A43600;
				int num7 = 1;
				num5 = 12;
				num4 = num7 - 1;
				num = (short)72548356;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}
	}
}
