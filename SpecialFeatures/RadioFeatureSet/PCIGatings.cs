using System;
using System.Collections.Generic;
using System.Linq;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO2;
using Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;
using Motorola.MackinawCPS.CoreFeatures.ConventionalWide;
using Motorola.MackinawCPS.CoreFeatures.DataProfiles;
using Motorola.MackinawCPS.CoreFeatures.DVRSProfiles;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.EmergencyWide;
using Motorola.MackinawCPS.CoreFeatures.MPLConfiguration;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioProfiles;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.ScanList;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;
using Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles;
using Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.RadioFeatureSet
{
	// Token: 0x0200007F RID: 127
	internal class PCIGatings
	{
		// Token: 0x060009F5 RID: 2549 RVA: 0x000AF474 File Offset: 0x000AD674
		internal static bool AlwaysExcised()
		{
			short num = (short)1327693824;
			short num2 = num;
			num = (short)65196980;
			short num3 = num;
			num = (short)291427252;
			switch (num3 == num)
			{
			}
			num = (short)728629249;
			if (num != 0)
			{
			}
			num = (short)740032512;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x000AF51C File Offset: 0x000AD71C
		internal static bool ExpandedMDC1200Excised()
		{
			short num = (short)599457792;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					goto IL_2B1;
				case 2:
					return false;
				}
				IL_30:
				if (!(global::AcpCommonLib.FeatureManager.GetFeature(2024)[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWide).Labtool.CnvWideLabtoolExpandedMDCID_A41790.Value)
				{
					num = (short)943683132;
					short num3 = num;
					num = (short)535787068;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1907949568;
						short num4 = num;
						num = (short)1286668288;
						if (num != 0)
						{
						}
						num = (short)1827536898;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				else
				{
					num = (short)871890945;
					if (num != 0)
					{
					}
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset).GetEnumerator();
					num = (short)490799105;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return false;
			IL_2B1:
			try
			{
				num = (short)393609217;
				num2 = (int)((global::System.IntPtr)num);
				bool result;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)1548746754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1451163652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_12D;
						}
						continue;
					case 2:
						num = (short)685899781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						result = true;
						num = (short)701890566;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						if ((((global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem)enumerator.Current)[10118] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General).CnvSysGeneralAdditionalMDCPID_A41761)
						{
							num = (short)699596803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						goto IL_1EF;
					case 6:
						goto IL_179;
					}
					IL_12F:
					num = (short)1858404352;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12D:
					goto IL_12F;
				}
				IL_179:
				return result;
				IL_1EF:
				return false;
			}
			finally
			{
				num = (short)620953600;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_221;
						}
						continue;
					case 1:
						goto IL_256;
					case 2:
						enumerator.Dispose();
						num = (short)123928577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_221:
					if (enumerator == null)
					{
						break;
					}
					num = (short)523173890;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_256:;
			}
			return false;
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x000AF7FC File Offset: 0x000AD9FC
		internal static bool DisableEmergencyCallIndicationsExcised()
		{
			switch (0)
			{
			case 0:
				goto IL_60;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide emergencyWide;
					if (emergencyWide.General.EmerWideGeneralSuppressEmergencyCall_A42142.Value)
					{
						num2 = (short)1122369552;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 1:
					if (radioWide.Labtool.RadWideLabtoolSuppressEmergencyCallCapability_A42143 != null)
					{
						num2 = (short)1417609231;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
					num2 = (short)1949696018;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide emergencyWide;
					if (emergencyWide.General.EmerWideGeneralSilentAlarm_A9130 != null)
					{
						num2 = (short)1590034445;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 4:
					num2 = (short)475070467;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_2B3;
				case 6:
				{
					num2 = (short)1573105002;
					short num3 = num2;
					num2 = (short)2126622058;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2B3;
					default:
					{
						num2 = (short)1198194688;
						if (num2 != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide emergencyWide;
						if (emergencyWide.General.EmerWideGeneralSilentAlarm_A9130.Value)
						{
							num2 = (short)450625555;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					}
					}
					break;
				}
				case 7:
					num2 = (short)1702166540;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					return false;
				case 9:
				{
					global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide emergencyWide;
					if (emergencyWide != null)
					{
						num2 = (short)263716864;
						short num4 = num2;
						num2 = (short)334692359;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 10:
					if (radioWide != null)
					{
						num2 = (short)678625291;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 11:
					num2 = (short)1654587397;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
				{
					global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide emergencyWide;
					if (emergencyWide.General != null)
					{
						num2 = (short)2070347778;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 13:
					num2 = (short)357826560;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
				{
					if (!radioWide.Labtool.RadWideLabtoolSuppressEmergencyCallCapability_A42143.Value)
					{
						num2 = (short)341639176;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide emergencyWide = global::AcpCommonLib.FeatureManager.GetFeature(2032)[0] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide;
					num2 = (short)217448457;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 15:
					num2 = (short)1253703694;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					num2 = (short)1538457601;
					if (num2 != 0)
					{
					}
					num2 = (short)2011824134;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					num2 = (short)966590465;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
				{
					global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide emergencyWide;
					if (emergencyWide.General.EmerWideGeneralSuppressEmergencyCall_A42142 != null)
					{
						num2 = (short)456261636;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 19:
					return true;
				}
				goto IL_60;
				IL_2B3:
				if (radioWide.Labtool == null)
				{
					return false;
				}
				num2 = (short)785973265;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_60:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)2137260042;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x000AFBCC File Offset: 0x000ADDCC
		internal static bool IsBeaconRoutingUsed()
		{
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (radioWide.Labtool.RadWideLabtoolAudibleBeaconRoutingCapable_A41974 != null)
					{
						num2 = (short)665452559;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
					num2 = (short)1382416396;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)587988996;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (radioWide.TPS.RadWideTPSAudibleEmergencyBeaconRouting_A41972.Value != 0)
					{
						num2 = (short)788529165;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 4:
					if (radioWide.Labtool.RadWideLabtoolAudibleBeaconRoutingCapable_A41974.Value)
					{
						num2 = (short)632356874;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 5:
					if (radioWide.TPS != null)
					{
						num2 = (short)941228033;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 6:
					if (radioWide != null)
					{
						num2 = (short)1152909319;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 7:
					num2 = (short)1668743179;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_E3;
				case 9:
					if (radioWide.TPS.RadWideTPSAudibleEmergencyBeaconRouting_A41972.Applicable)
					{
						num2 = (short)195231752;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 10:
					radioWide.TPS.RadWideTPSAudibleEmergencyBeaconRouting_A41972.CalculateApplicability();
					num2 = (short)904986627;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (radioWide.Labtool != null)
					{
						num2 = (short)437977102;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 12:
				{
					num2 = (short)1804510413;
					short num3 = num2;
					num2 = (short)1994433741;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)25821185;
						if (num2 != 0)
						{
						}
						num2 = (short)954990592;
						if (num2 != 0)
						{
						}
						if (radioWide.TPS.RadWideTPSAudibleEmergencyBeaconRouting_A41972 != null)
						{
							num2 = (short)781778946;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					}
					break;
				}
				case 13:
					num2 = (short)37814281;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					num2 = (short)1324613632;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
				{
					num2 = (short)1940652032;
					short num4 = num2;
					num2 = (short)296484869;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_50;
			}
			IL_E3:
			return !radioWide.TPS.RadWideTPSAudibleEmergencyBeaconRouting_A41972.HiddenStatic;
			IL_50:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)1660682246;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x000AFF14 File Offset: 0x000AE114
		internal static bool IsMFKEmergencyAccessUsed()
		{
			switch (0)
			{
			case 0:
				goto IL_69;
			}
			short num;
			int num3;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MultiFunctionKnob o2MultiFunctionKnob;
			for (;;)
			{
				IL_0A:
				num = (short)1282998272;
				short num2 = num;
				switch (num3)
				{
				case 0:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset controlHeadO2Recset;
					if (controlHeadO2Recset != null)
					{
						num = (short)42270722;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 1:
					if (radioWide != null)
					{
						num = (short)44695559;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
				{
					num = (short)248327601;
					short num4 = num;
					num = (short)755314097;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A1;
					default:
						num = (short)193855488;
						if (num != 0)
						{
						}
						num = (short)728367112;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset controlHeadO2Recset;
					o2MultiFunctionKnob = (controlHeadO2Recset[0][10721] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MultiFunctionKnob);
					num = (short)1913585669;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					num = (short)1568604161;
					if (num != 0)
					{
					}
					num = (short)1016004609;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (o2MultiFunctionKnob != null)
					{
						num = (short)206241802;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 6:
					if (radioWide.Labtool.RadWideLabtoolMFKEmergencyAccess_A42216.Value)
					{
						num = (short)206307339;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 7:
					num = (short)535494662;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset controlHeadO2Recset;
					if (controlHeadO2Recset[0] != null)
					{
						num = (short)1659961347;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 9:
					if (global::ConstraintHelper.UtilityMack.IsMobile())
					{
						goto IL_A1;
					}
					return false;
				case 10:
					goto IL_130;
				case 11:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset controlHeadO2Recset = global::AcpCommonLib.FeatureManager.GetFeature(4115) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset;
					num = (short)618135552;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_69;
				IL_A1:
				num = (short)243073028;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_130:
			return o2MultiFunctionKnob.RadErgoControlO2MFKButtonPress_A42217.Value == 31;
			IL_69:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num = (short)421199881;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x000B01B8 File Offset: 0x000AE3B8
		internal static bool IsMulitEmergencyRevertUsed()
		{
			short num = (short)713687040;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_56;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset trunkingPersonalityRecset;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
					switch (num2)
					{
					case 0:
						if (trunkingPersonalityRecset != null)
						{
							num = (short)1665990661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_40C;
					case 1:
						trunkingPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2072) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset);
						num = (short)942407680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						try
						{
							num = (short)827850762;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									if (trunkingPersonality.General.TrkPerGeneralRevertChannel_A41917.Applicable)
									{
										num = (short)683802629;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									trunkingPersonality.General.TrkPerGeneralRevertChannel_A41917.CalculateApplicability();
									goto IL_5D9;
								}
								case 2:
									result = true;
									num = (short)1277231113;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									if (trunkingPersonality != null)
									{
										num = (short)404750342;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_7C1;
								case 5:
									num = (short)1764229132;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)1716060171;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)2077884420;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1637416967;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
									num = (short)1249443843;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_640;
								case 10:
									switch (0)
									{
									case 0:
										goto IL_5C3;
									}
									continue;
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									if (trunkingPersonality.General.TrkPerGeneralRevertChannel_A41917 != null)
									{
										num = (short)735051777;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
								{
									num = (short)1674434871;
									short num3 = num;
									num = (short)44489015;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_5D9;
									default:
									{
										num = (short)1462894592;
										if (num != 0)
										{
										}
										global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
										if (trunkingPersonality.General.TrkPerGeneralRevertChannel_A41917.ReferencedNode is global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner)
										{
											num = (short)1622867970;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									break;
								}
								}
								goto IL_5C3;
								IL_5D9:
								num = (short)1890975744;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6CF:
								num = (short)1255931912;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5C3:
								goto IL_6CF;
							}
							IL_640:
							return result;
							IL_7C1:
							goto IL_40C;
						}
						finally
						{
							num = (short)141164545;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)178257922;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_7F9;
									}
									continue;
								case 2:
									goto IL_82F;
								}
								IL_7F9:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1336934400;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_82F:;
						}
						goto IL_832;
					case 3:
						num = (short)1255997444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (radioWide.Labtool.RadWideLabtoolEmergencyRevertCapable_A41918.Value)
						{
							num = (short)88014849;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_53E;
					case 5:
						goto IL_832;
					case 6:
						if (conventionalPersonalityRecset != null)
						{
							num = (short)201654280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_53E;
					case 7:
						if (radioWide != null)
						{
							num = (short)645595139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_53E;
					case 8:
						enumerator = conventionalPersonalityRecset.GetEnumerator();
						num = (short)1589706761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						try
						{
							num = (short)2076704784;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
									if (channelAssignmentListInner != null)
									{
										num = (short)1199439883;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									conventionalPersonality.Signaling.CnvPerSignalingRevertChannel_A13267.CalculateApplicability();
									num = (short)1711538179;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)311492613;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality.Signaling.CnvPerSignalingRevertChannel_A13267.Applicable)
									{
										num = (short)2105344007;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
									if (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value == 1)
									{
										num = (short)144244754;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
									if (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241 != null)
									{
										num = (short)475725837;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
									if (channelAssignmentListInner.ChannelAssignmentListInnerSection != null)
									{
										num = (short)950468610;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = conventionalPersonality.Signaling.CnvPerSignalingRevertChannel_A13267.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
									num = (short)1037828096;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)2112946188;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality.Signaling.CnvPerSignalingRevertChannel_A13267 != null)
									{
										num = (short)1603469313;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1190723592;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
									num = (short)813367311;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									num = (short)1134559238;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									goto IL_39C;
								case 13:
									num = (short)1731788804;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									goto IL_2EE;
								case 15:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality != null)
									{
										num = (short)1440153617;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 16:
									switch (0)
									{
									case 0:
										goto IL_115;
									}
									continue;
								case 17:
									num = (short)1638596617;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									result = true;
									num = (short)1514799118;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_11A:
								num = (short)332791818;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_115:
								goto IL_11A;
							}
							IL_2EE:
							return result;
							IL_39C:
							goto IL_53E;
						}
						finally
						{
							num = (short)827588609;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)852099074;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_3D3;
									}
									continue;
								case 2:
									goto IL_409;
								}
								IL_3D3:
								if (enumerator == null)
								{
									break;
								}
								num = (short)370933760;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_409:;
						}
						goto IL_40C;
					}
					goto IL_56;
					IL_40C:
					num = (short)1708130305;
					if (num != 0)
					{
					}
					conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
					num = (short)1356857350;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_832:
					enumerator = trunkingPersonalityRecset.GetEnumerator();
					num = (short)195100674;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_53E:
				num = (short)440270848;
				short num4 = num;
				return false;
				IL_56:
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num = (short)1296760839;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x000B0A54 File Offset: 0x000AEC54
		internal static bool IsManDownPerCfgCapUsed()
		{
			switch (0)
			{
			case 0:
				goto IL_69;
			}
			short num;
			int num3;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide emergencyWide;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
			for (;;)
			{
				IL_0A:
				num = (short)72810496;
				short num2 = num;
				switch (num3)
				{
				case 0:
					if (radioWide.Labtool.ManDownPersonalityConfigurableCapable_42082.Value)
					{
						num = (short)1823014914;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					goto IL_190;
				case 2:
					num = (short)541589512;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)191692805;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)1728315393;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (emergencyWide.ManDown.ManDownConfigurabilityGranularityLevel_42057.Value == 1)
					{
						num = (short)1898315786;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 6:
				{
					num = (short)1892709422;
					short num4 = num;
					num = (short)958297134;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_190;
					default:
						num = (short)1406533632;
						if (num != 0)
						{
						}
						num = (short)1299447809;
						if (num != 0)
						{
						}
						if (radioWide != null)
						{
							num = (short)1190658059;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					break;
				}
				case 7:
					num = (short)1961820166;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (emergencyWide != null)
					{
						num = (short)195297283;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 9:
					if (radioInformation != null)
					{
						num = (short)1257046020;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 10:
					goto IL_12B;
				case 11:
					num = (short)2066153472;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_69;
				IL_190:
				if (!radioInformation.Labtool.RadInfoLabtoolManDown_A40006.Value)
				{
					return false;
				}
				num = (short)794624007;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_12B:
			return emergencyWide.ManDown.EmerWideManDownTrigger_A40001.Value != 0;
			IL_69:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			emergencyWide = (global::AcpCommonLib.FeatureManager.GetFeature(2032)[0] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide);
			radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
			num = (short)129302537;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x000B0D18 File Offset: 0x000AEF18
		internal static bool IsToneEmerCfgCapUsed()
		{
			switch (0)
			{
			case 0:
				goto IL_BD;
			}
			short num;
			int num4;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide emergencyWide;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
			for (;;)
			{
				IL_0A:
				num = (short)456575182;
				short num2 = num;
				num = (short)128174286;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1BA;
				case 1:
					break;
				default:
				{
					num = (short)439222272;
					short num3 = num;
					break;
				}
				}
				num = (short)881262592;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					IL_1BA:
					num = (short)78970881;
					if (num != 0)
					{
					}
					num = (short)1928593414;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (radioWide != null)
					{
						num = (short)2096758786;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
					num = (short)1531969540;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)420282375;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (radioWide.Labtool.ToneEmergencyConfigurableCapable_42083.Value)
					{
						num = (short)1646723077;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
					num = (short)1536163852;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (emergencyWide.ManDown.ManDownConfigurabilityGranularityLevel_42057.Value == 1)
					{
						num = (short)746913802;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 7:
					if (radioInformation.Labtool.RadInfoLabtoolManDown_A40006.Value)
					{
						num = (short)2000289801;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 8:
					if (emergencyWide.ManDown.EmerWideManDownTrigger_A40001.Value != 0)
					{
						num = (short)1094057997;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 9:
					num = (short)33030145;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)1553137672;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (radioInformation != null)
					{
						num = (short)78118915;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 12:
					if (emergencyWide != null)
					{
						num = (short)446627840;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 13:
					goto IL_2BF;
				}
				goto IL_BD;
			}
			IL_2BF:
			return emergencyWide.EmergencyToneTrigger.TriggedByManDown_42135.Value;
			IL_BD:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			emergencyWide = (global::AcpCommonLib.FeatureManager.GetFeature(2032)[0] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide);
			radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
			num = (short)882376715;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x000B1034 File Offset: 0x000AF234
		internal static bool IsPassAlarmFilterUsed()
		{
			short num = (short)1730215936;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4A;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (radioWide.Labtool.PASSAlarmFilterCapable_A42387.Value)
						{
							num = (short)412483585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FE;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset = global::AcpCommonLib.FeatureManager.GetFeature(2077) as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset;
						num = (short)775880710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
						enumerator = radioProfilesRecset.GetEnumerator();
						num = (short)286261253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)1645936640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (radioWide != null)
						{
							num = (short)1444216835;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FE;
					case 5:
						goto IL_B2;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
						if (radioProfilesRecset != null)
						{
							num = (short)1691680768;
							short num3 = num;
							num = (short)1478950914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FE;
					}
					}
					goto IL_4A;
				}
				IL_B2:
				bool result;
				try
				{
					num = (short)1504378899;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)1394999298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1052180480;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles;
							num = (short)453181452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_54E;
						case 3:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
							if (radioProfiles.AudioSettings.RadProfAudioSettingsIntMicPassAlarmFilter_A42382)
							{
								num = (short)1637941258;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_23C;
						}
						case 4:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
							if (radioProfiles != null)
							{
								num = (short)1208418315;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							num = (short)248971273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
							if (radioProfiles.AudioSettings.RadProfAudioSettingsIntMicPassAlarmFilter_A42382.Applicable)
							{
								num = (short)2040791054;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_23C;
						}
						case 7:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
							radioProfiles.AudioSettings.RadProfAudioSettingsIntMicPassAlarmFilter_A42382.CalculateApplicability();
							num = (short)2053963782;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
							if (radioProfiles.AudioSettings.RadProfAudioSettingsExternalMicPassAlarmFilter_A42386.Applicable)
							{
								goto IL_519;
							}
							break;
						}
						case 9:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
							if (radioProfiles.AudioSettings.RadProfAudioSettingsIntMicPassAlarmFilter_A42382 != null)
							{
								num = (short)1871970311;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_23C;
						}
						case 10:
							result = true;
							num = (short)1939734545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							num = (short)1980432399;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
						{
							num = (short)914165088;
							short num4 = num;
							num = (short)64490848;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_519;
							default:
							{
								num = (short)280494080;
								if (num != 0)
								{
								}
								global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
								if (radioProfiles != null)
								{
									num = (short)453509125;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_23C;
							}
							}
							break;
						}
						case 13:
							goto IL_237;
						case 14:
							num = (short)332791811;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
							if (radioProfiles.AudioSettings.RadProfAudioSettingsExternalMicPassAlarmFilter_A42386 != null)
							{
								num = (short)970522645;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 16:
							num = (short)1797849106;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							goto IL_495;
						case 18:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
							if (radioProfiles.AudioSettings.RadProfAudioSettingsExternalMicPassAlarmFilter_A42386)
							{
								num = (short)251789332;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 19:
							switch (0)
							{
							case 0:
								goto IL_219;
							}
							continue;
						case 20:
							result = true;
							num = (short)367788045;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
							radioProfiles.AudioSettings.RadProfAudioSettingsExternalMicPassAlarmFilter_A42386.CalculateApplicability();
							num = (short)1336279048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_219;
						IL_23C:
						num = (short)111017988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_31A:
						num = (short)64356353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_219:
						goto IL_31A;
						IL_519:
						num = (short)1575878672;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_237:
					IL_495:
					return result;
					IL_54E:
					goto IL_FE;
				}
				finally
				{
					num = (short)1126170626;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)520749057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_5BB;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_585;
							}
							continue;
						}
						IL_585:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1753153536;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_5BB:;
				}
				return result;
				IL_FE:
				num = (short)1382612993;
				if (num != 0)
				{
				}
				return false;
				IL_4A:
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num = (short)378404868;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x000B1620 File Offset: 0x000AF820
		internal static bool IsEmergencyHotMicAvailable()
		{
			switch (0)
			{
			case 0:
				goto IL_58;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesRecset conventionalEmergencyProfilesRecset;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (radioWide.Labtool == null)
					{
						return false;
					}
					num2 = (short)82500473;
					short num3 = num2;
					num2 = (short)533584761;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_358;
					default:
						num2 = (short)570032128;
						if (num2 != 0)
						{
						}
						num2 = (short)1413545998;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					if (radioWide.Labtool.RadWideLabtoolSuppressEmergencyCallCapability_A42143 != null)
					{
						num2 = (short)1814560779;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
					num2 = (short)1631715341;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (!(conventionalEmergencyProfilesRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles).General.CnvEmerProfEmergencyHotAuxMic_A42296.HiddenStatic)
					{
						num2 = (short)660144132;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 4:
					return true;
				case 5:
				{
					num2 = (short)561577984;
					short num4 = num2;
					num2 = (short)1415053322;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					if ((conventionalEmergencyProfilesRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles).General != null)
					{
						num2 = (short)1980891138;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 7:
					goto IL_358;
				case 8:
					if (conventionalEmergencyProfilesRecset[0] != null)
					{
						num2 = (short)1427308549;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 9:
					num2 = (short)643366912;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (conventionalEmergencyProfilesRecset[0] is global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles)
					{
						num2 = (short)308346892;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 11:
					num2 = (short)1784807431;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					num2 = (short)1110310918;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (radioWide.Labtool.EmergencyHotAuxMicConfigurability_A42301.Value)
					{
						num2 = (short)1616052241;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 14:
					num2 = (short)1095237633;
					if (num2 != 0)
					{
					}
					num2 = (short)2102525953;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					num2 = (short)1170341896;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					if (radioWide != null)
					{
						num2 = (short)478674953;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 17:
					num2 = (short)1552482307;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_58;
				IL_358:
				if (conventionalEmergencyProfilesRecset == null)
				{
					return false;
				}
				num2 = (short)725614607;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_58:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			conventionalEmergencyProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2075) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesRecset);
			num2 = (short)344129552;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x000B19A8 File Offset: 0x000AFBA8
		internal static bool IsEmergencyHotMicUsed()
		{
			short num = (short)1436680192;
			switch (num)
			{
			default:
			{
				num = (short)2087124998;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						bool result;
						try
						{
							num = (short)657391625;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2138898439;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)663158792;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)165740550;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									result = true;
									num = (short)52232195;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_589;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles).General.CnvEmerProfEmergencyHotAuxMic_A42296.Value != 0)
									{
										num = (short)293994497;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_5F4;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles).General.CnvEmerProfEmergencyHotAuxMic_A42296.Applicable)
									{
										num = (short)27328514;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									num = (short)1061748741;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (acpFeatureNode is global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles)
									{
										num = (short)857079818;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									switch (0)
									{
									case 0:
										goto IL_490;
									}
									continue;
								case 10:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									(acpFeatureNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles).General.CnvEmerProfEmergencyHotAuxMic_A42296.CalculateApplicability();
									num = (short)1951137796;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_530:
								num = (short)905838592;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_490:
								goto IL_530;
							}
							IL_589:
							return result;
							IL_5F4:
							goto IL_313;
						}
						finally
						{
							num = (short)1272381442;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1214513153;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_660;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_62B;
									}
									continue;
								}
								IL_62B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1435238400;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_660:;
						}
						return result;
					}
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset trunkingEmergencyProfilesRecset;
						if (trunkingEmergencyProfilesRecset != null)
						{
							num = (short)698810372;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesRecset conventionalEmergencyProfilesRecset;
						if (conventionalEmergencyProfilesRecset != null)
						{
							num = (short)844890115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_313;
					}
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesRecset conventionalEmergencyProfilesRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = conventionalEmergencyProfilesRecset.GetEnumerator();
						num = (short)976814080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset trunkingEmergencyProfilesRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = trunkingEmergencyProfilesRecset.GetEnumerator();
						num = (short)811663365;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						num = (short)370278400;
						short num3 = num;
						num = (short)1415380993;
						if (num != 0)
						{
						}
						try
						{
							num = (short)888602633;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1024327686;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2 as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles).General.TrkEmerProfEmergencyHotAuxMic_A42300.Value != 0)
									{
										num = (short)737607680;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									result = true;
									num = (short)1747451908;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									(acpFeatureNode2 as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles).General.TrkEmerProfEmergencyHotAuxMic_A42300.CalculateApplicability();
									num = (short)1469841409;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_135;
								case 5:
									goto IL_255;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2 as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles).General.TrkEmerProfEmergencyHotAuxMic_A42300.Applicable)
									{
										num = (short)253296642;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (acpFeatureNode2 is global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles)
									{
										num = (short)700973059;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)746913802;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1390936071;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									switch (0)
									{
									case 0:
										goto IL_DB;
									}
									continue;
								case 10:
									num = (short)1624702981;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_DD:
								num = (short)1575682056;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_DB:
								goto IL_DD;
							}
							IL_135:
							return result;
							IL_255:
							return false;
						}
						finally
						{
							num = (short)850001922;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2F2;
								case 1:
									goto IL_310;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_28D;
									}
									continue;
								}
								IL_28D:
								num = (short)292887525;
								short num4 = num;
								num = (short)2123373541;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
								{
									IL_2F2:
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									enumerator.Dispose();
									num = (short)628752385;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
								default:
								{
									num = (short)246349824;
									if (num != 0)
									{
									}
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (enumerator == null)
									{
										goto IL_312;
									}
									num = (short)2122907648;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
								}
							}
							IL_310:
							IL_312:;
						}
						goto IL_313;
					}
					case 6:
						switch (0)
						{
						case 0:
							goto IL_64;
						}
						continue;
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesRecset conventionalEmergencyProfilesRecset = global::AcpCommonLib.FeatureManager.GetFeature(2075) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesRecset;
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset trunkingEmergencyProfilesRecset = global::AcpCommonLib.FeatureManager.GetFeature(2076) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset;
						num = (short)12058626;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_64:
					if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsEmergencyHotMicAvailable())
					{
						num = (short)386596871;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_313:
					num = (short)1549795329;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
			}
			}
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x000B2050 File Offset: 0x000B0250
		internal static bool IsAudibleEmergencyBeaconAvailable()
		{
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)938606592;
					short num3 = num2;
					if (radioWide.Labtool != null)
					{
						num2 = (short)769064972;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 1:
					if (radioWide.TPS.RadWideTPSAudibleEmergencyBeaconsec_A7502 != null)
					{
						num2 = (short)660865027;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
					goto IL_28A;
				case 3:
					num2 = (short)1825636362;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (!radioWide.TPS.RadWideTPSAudibleEmergencyBeaconsec_A7502.HiddenStatic)
					{
						num2 = (short)1861091330;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 5:
					num2 = (short)221118465;
					if (num2 != 0)
					{
					}
					num2 = (short)1366687751;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)1296039949;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (radioWide.TPS != null)
					{
						num2 = (short)1003356168;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 8:
					num2 = (short)919011329;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (radioWide.Labtool.TPSCapable_A42312 != null)
					{
						num2 = (short)799932421;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 10:
					if (radioWide.Labtool.TPSCapable_A42312.Value)
					{
						num2 = (short)2062090246;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 11:
					num2 = (short)333185024;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					num2 = (short)1015414793;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (global::ConstraintHelper.UtilityMack.IsMobile())
					{
						num2 = (short)1450508303;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 14:
					if (radioWide != null)
					{
						num2 = (short)176685067;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 15:
					num2 = (short)1972699140;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_50;
			}
			for (;;)
			{
				IL_28A:
				num2 = (short)1638899065;
				short num4 = num2;
				num2 = (short)1482792313;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_1C6;
				}
			}
			IL_1C6:
			num2 = (short)696385536;
			if (num2 != 0)
			{
			}
			return true;
			IL_50:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)108068878;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x000B2368 File Offset: 0x000B0568
		internal static bool IsAudibleEmergencyBeaconUsed()
		{
			short num;
			if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsAudibleEmergencyBeaconAvailable())
			{
				num = (short)1806726292;
				short num2 = num;
				num = (short)1862694036;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)312606720;
					if (num != 0)
					{
					}
					num = (short)866975744;
					short num3 = num;
					break;
				}
				}
				return (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).TPS.RadWideTPSAudibleEmergencyBeaconsec_A7502.Value != 0;
			}
			num = (short)1421606913;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x000B2444 File Offset: 0x000B0644
		internal static bool IsAudioEnhacementUsed()
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_DE;
				case 1:
					if (radioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value == 1)
					{
						num2 = (short)1113980932;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
					num2 = (short)1623326721;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (radioWide.DigitalAudioOptions != null)
					{
						num2 = (short)1167392773;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 4:
					return true;
				case 5:
				{
					num2 = (short)942324106;
					short num3 = num2;
					num2 = (short)746699146;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DE;
					default:
					{
						num2 = (short)94240768;
						if (num2 != 0)
						{
						}
						num2 = (short)1727201280;
						short num4 = num2;
						num2 = (short)1969356801;
						if (num2 != 0)
						{
						}
						num2 = (short)1248198656;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 6:
					if (radioWide != null)
					{
						num2 = (short)544604167;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 7:
					num2 = (short)132841475;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_30;
				IL_DE:
				if (radioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.HiddenStatic)
				{
					return false;
				}
				num2 = (short)320667650;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_30:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)1595342854;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x000B2640 File Offset: 0x000B0840
		internal static bool IsDynamicZoneScanCapabilityUsed()
		{
			short num = (short)1881276416;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2057) as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset).GetEnumerator();
				bool result;
				try
				{
					num = (short)974061580;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset scanListInnerRecset;
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = scanListInnerRecset.GetEnumerator();
							num = (short)1503264777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1908080647;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList;
							num = (short)355205123;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_3F6;
						case 3:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList;
							if (scanList != null)
							{
								num = (short)653197318;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList;
							if (scanList.ScanListMembers.EmbeddedRecset != null)
							{
								num = (short)588316677;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList;
							global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset scanListInnerRecset = scanList.ScanListMembers.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset;
							num = (short)2055012363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							num = (short)2052849674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							num = (short)1930231810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							num = (short)424869892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							try
							{
								num = (short)7602184;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)1395523586;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
										if (zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
										{
											num = (short)126681091;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										goto IL_23A;
									case 3:
										result = true;
										num = (short)1365049349;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1129906176;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = (enumerator2.Current as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner).ScanListInnerSection.ScanLstScanListZone_A9718.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
										num = (short)1739390983;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										goto IL_1DE;
									case 6:
										num = (short)2116288513;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
										if (zoneChannelAssignment != null)
										{
											num = (short)76939270;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 8:
										switch (0)
										{
										case 0:
											goto IL_122;
										}
										continue;
									}
									IL_1E3:
									num = (short)1958805508;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_122:
									goto IL_1E3;
								}
								IL_1DE:
								goto IL_4DC;
								IL_23A:;
							}
							finally
							{
								num = (short)77791234;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									switch (num2)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)205586433;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_2A6;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_270;
										}
										continue;
									}
									IL_270:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1761542144;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2A6:;
							}
							break;
						case 10:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList;
							if (scanList.ScanListMembers != null)
							{
								num = (short)1249116168;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 11:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset scanListInnerRecset;
							if (scanListInnerRecset != null)
							{
								num = (short)898957312;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 12:
							switch (0)
							{
							case 0:
								goto IL_91;
							}
							continue;
						}
						IL_2A9:
						num = (short)1377042433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_91:
						goto IL_2A9;
					}
					IL_3F6:
					return false;
				}
				finally
				{
					num = (short)412221442;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)781451265;
							if (num != 0)
							{
							}
							enumerator.Dispose();
							num = (short)1578565633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_48C;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_42D;
							}
							continue;
						}
						IL_42D:
						if (enumerator == null)
						{
							break;
						}
						num = (short)44761088;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_48C:
					num = (short)453070243;
					short num3 = num;
					num = (short)916082083;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_48C;
					default:
						num = (short)368115712;
						if (num != 0)
						{
						}
						break;
					}
				}
				IL_4DC:
				num = (short)1199112192;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x000B2B88 File Offset: 0x000B0D88
		internal static bool IsDynamicZoneScanCapabilityAvailable()
		{
			short num = (short)677576704;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3B;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_2DB;
					case 1:
						try
						{
							num = (short)1616314376;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								bool flag;
								switch (num2)
								{
								case 0:
									flag = false;
									goto IL_1C7;
								case 1:
									goto IL_124;
								case 2:
									goto IL_26B;
								case 3:
									num = (short)1905459207;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									num = (short)1146643986;
									short num3 = num;
									num = (short)731604498;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_124;
									default:
										goto IL_219;
									}
									break;
								}
								case 5:
									num = (short)1812332546;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (!enumerator.MoveNext())
									{
										num = (short)1331298309;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1454178305;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									flag = radioWide.Labtool.RadWideLabtoolDynamicZoneScanCapability_42749.Value;
									goto IL_1C7;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_10D;
									}
									continue;
								}
								IL_10D:
								num = (short)1156513798;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_124:
								if (!((global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment)enumerator.Current).Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.HiddenStatic)
								{
									num = (short)843120643;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)233308160;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1C7:
								result = flag;
								num = (short)596705284;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_219:
							num = (short)184156160;
							if (num != 0)
							{
							}
							return result;
							IL_26B:
							return false;
						}
						finally
						{
							num = (short)89128962;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)689242113;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_2D8;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2A2;
									}
									continue;
								}
								IL_2A2:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2108030976;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2D8:;
						}
						goto IL_2DB;
					case 2:
						if (zoneChannelAssignmentRecset != null)
						{
							num = (short)344326144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_3B;
					IL_2DB:
					enumerator = zoneChannelAssignmentRecset.GetEnumerator();
					num = (short)1129185281;
					if (num != 0)
					{
					}
					num = (short)1754660865;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_3B:
				num = (short)1150812160;
				short num4 = num;
				zoneChannelAssignmentRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset);
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num = (short)272891906;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x000B2EDC File Offset: 0x000B10DC
		internal static bool IsDVRSTRKStatusCapabilityUsed()
		{
			short num = (short)386793473;
			if (num != 0)
			{
			}
			num = (short)1964900352;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset).GetEnumerator();
				bool result;
				try
				{
					num = (short)632684577;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							if ((global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide).General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value)
							{
								num = (short)529465353;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 1:
							goto IL_4C3;
						case 2:
							num = (short)419364877;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)589496325;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1001783323;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
							num = (short)809893910;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfiles dvrsprofiles;
							if (dvrsprofiles.General.DVRSProfGeneralGenStsOnDVRSModChg_A41801.Value)
							{
								num = (short)877330453;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							num = (short)272957471;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
							global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfiles dvrsprofiles2 = conventionalPersonality.General.CnvPerFeaturesDVRSProf_A41794.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfiles;
							num = (short)950534163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfiles dvrsprofiles;
							if (dvrsprofiles != null)
							{
								num = (short)320208899;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
							global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfiles dvrsprofiles = conventionalPersonality.General.CnvPerFeaturesDVRSProf_A41794.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfiles;
							num = (short)1828651016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							goto IL_610;
						case 11:
							result = true;
							num = (short)141426706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							num = (short)130351121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
						{
							global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfiles dvrsprofiles2;
							if (dvrsprofiles2.General.DVRSProfGeneralGenStsOnDVRSModChg_A41801.Value)
							{
								num = (short)386072588;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 14:
							result = true;
							num = (short)2039349249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
							if (conventionalSystem.Features.CnvSysFeaturesStatus_A9186.Value)
							{
								num = (short)1835991054;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 16:
							num = (short)2055143454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem2;
							if (conventionalSystem2.Features.CnvSysFeaturesStatus_A9186.Value)
							{
								num = (short)753139723;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 18:
							goto IL_142;
						case 19:
						{
							global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfiles dvrsprofiles2;
							if (dvrsprofiles2 != null)
							{
								num = (short)576978946;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 20:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
							if (conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.Value == 0)
							{
								num = (short)1006567447;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 21:
							num = (short)293535759;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
							if (conventionalPersonality != null)
							{
								num = (short)1295187984;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4C8;
						}
						case 23:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem2 = conventionalPersonality.Signaling.CnvPerSignalingSystemNumber_A9243.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
							num = (short)294780957;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 24:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
							num = (short)401932320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 25:
							num = (short)1469644820;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
							if (conventionalPersonality != null)
							{
								num = (short)2031157273;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 27:
							num = (short)1068498954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
							num = (short)1243873280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 29:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem2;
							if (conventionalSystem2 != null)
							{
								num = (short)1941110790;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 30:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
							if (conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.Value == 1)
							{
								num = (short)1291780120;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4C8;
						}
						case 31:
							if ((global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide).General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value)
							{
								num = (short)1135149063;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 32:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
							if (conventionalSystem != null)
							{
								num = (short)993198108;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 33:
							switch (0)
							{
							case 0:
								goto IL_122;
							}
							continue;
						}
						IL_23B:
						num = (short)810549252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_122:
						goto IL_23B;
						IL_4C8:
						num = (short)687800346;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_142:
					IL_4C3:
					goto IL_9A3;
					IL_610:
					goto IL_5A;
				}
				finally
				{
					num = (short)2097610754;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)315817985;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_680;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_649;
							}
							continue;
						}
						IL_649:
						if (enumerator == null)
						{
							break;
						}
						num = (short)206897152;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_680:;
				}
				return false;
				IL_5A:
				enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2072) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset).GetEnumerator();
				try
				{
					num = (short)238419982;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_704;
						case 1:
						{
							global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfiles dvrsprofiles3;
							if (dvrsprofiles3 != null)
							{
								num = (short)313458697;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
						{
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
							global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfiles dvrsprofiles3 = trunkingPersonality.General.TrkPerFeaturesDVRSProf_A41796.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfiles;
							num = (short)1626603521;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							result = true;
							num = (short)568721408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_8E7;
						case 5:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)69206022;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
							num = (short)1399848973;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							num = (short)246874116;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							num = (short)1951924232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
							if (trunkingPersonality != null)
							{
								num = (short)346095618;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
							num = (short)1356005386;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfiles dvrsprofiles3;
							if (dvrsprofiles3.General.DVRSProfGeneralGenStsOnDVRSModChg_A41801.Value)
							{
								num = (short)459669515;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 11:
							num = (short)1711800332;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
						{
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
							if (trunkingPersonality.Features.TrkPerFeaturesStatusEnable_A9188.Value)
							{
								num = (short)308609027;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 13:
							if ((global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide).General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value)
							{
								num = (short)23265287;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 14:
							switch (0)
							{
							case 0:
								goto IL_6E7;
							}
							continue;
						}
						IL_892:
						num = (short)669515781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_6E7:
						goto IL_892;
					}
					IL_704:
					goto IL_9A3;
					IL_8E7:
					return false;
				}
				finally
				{
					num = (short)252772354;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)883425281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_954;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_91E;
							}
							continue;
						}
						IL_91E:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1318125568;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_954:
					num = (short)337917188;
					short num3 = num;
					num = (short)973092100;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_954;
					default:
						num = (short)577306624;
						if (num != 0)
						{
						}
						break;
					}
				}
				IL_9A3:
				num = (short)1294532608;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x000B38F0 File Offset: 0x000B1AF0
		internal static bool IsMOSCADIsUsed()
		{
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced advanced = global::AcpCommonLib.FeatureManager.GetFeature(2033)[0][10075] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced;
			if (advanced != null)
			{
				short num = (short)1625554944;
				short num2 = num;
				num = (short)300969978;
				short num3 = num;
				num = (short)1508143098;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)535560192;
					if (num != 0)
					{
					}
					num = (short)1996292097;
					if (num != 0)
					{
					}
					return advanced.RadErgoWideMOSCADDataEnable_A8545.Value;
				}
			}
			return false;
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x000B39D0 File Offset: 0x000B1BD0
		internal static bool IsPersonnelAccountabilityAlertUsed()
		{
			short num = (short)359989248;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_57;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_251;
					case 1:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset).GetEnumerator();
						num = (short)376307716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (radioInformation.Labtool.RadInfoLabtoolQ445FiregroundSupport_A8796.Value)
						{
							num = (short)1282539520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
						if (radioWide.Labtool.RadWideLabtoolPAAlertCapability_A42944.Value)
						{
							num = (short)2116091905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 4:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						bool result;
						try
						{
							num = (short)1871380485;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_4B4;
								case 1:
									goto IL_458;
								case 2:
									num = (short)1801322496;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if ((enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem).Features.CnvSysFeaturesPASelection_A42880.ReferencedNode != null)
									{
										num = (short)1290338310;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)625278978;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1136001027;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_3F2;
									}
									continue;
								case 6:
									result = true;
									num = (short)459735041;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_45D:
								num = (short)1488584708;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3F2:
								goto IL_45D;
							}
							IL_458:
							return result;
							IL_4B4:
							goto IL_2D7;
						}
						finally
						{
							num = (short)1789984769;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_573;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_4EC;
									}
									continue;
								case 2:
								{
									num = (short)961357251;
									short num3 = num;
									num = (short)2027890115;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_575;
									default:
										num = (short)1234894848;
										if (num != 0)
										{
										}
										enumerator.Dispose();
										num = (short)1165099008;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_4EC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1149698050;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_573:
							IL_575:;
						}
						return result;
						IL_2D7:
						enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset).GetEnumerator();
						num = (short)235995143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)2068512769;
						if (num != 0)
						{
						}
						if (radioInformation != null)
						{
							num = (short)1206779912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 6:
						if (radioWide != null)
						{
							num = (short)1651965961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 7:
					{
						num = (short)407633920;
						short num4 = num;
						try
						{
							num = (short)1721892869;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1DF;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if ((enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).Features.TrkSysFeaturesPASelection_A42882.ReferencedNode != null)
									{
										num = (short)2125594628;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_1C2;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)901382150;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)982450177;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									result = true;
									num = (short)359202818;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_124;
									}
									continue;
								case 6:
									num = (short)78905344;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_126:
								num = (short)2144796675;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_124:
								goto IL_126;
							}
							IL_1C2:
							return result;
							IL_1DF:
							return false;
						}
						finally
						{
							num = (short)1487011841;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_24E;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_216;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1129906176;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_216:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2120679426;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_24E:;
						}
						goto IL_251;
					}
					case 8:
						num = (short)485163010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)343539715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_57;
					IL_251:
					num = (short)1894318086;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_57:
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num = (short)992739333;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x000B3F88 File Offset: 0x000B2188
		internal static bool IsUserSelectablePLEnhancementUsed()
		{
			short num = (short)412811264;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1623326720;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_73;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				for (;;)
				{
					IL_50:
					switch (num2)
					{
					case 0:
						goto IL_ED;
					case 1:
						enumerator = conventionalPersonalityRecset.GetEnumerator();
						num = (short)1633353728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1255407619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (radioWide != null)
						{
							num = (short)561709061;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 4:
						if (conventionalPersonalityRecset != null)
						{
							num = (short)837156866;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						num = (short)2105737222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (radioWide.Labtool.RadWideLabtoolUserSelectablePLEnhancement_43031.Value)
						{
							num = (short)1729953793;
							if (num != 0)
							{
							}
							num = (short)1283653633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_73;
				}
				IL_ED:
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset frequencyOptionsInnerRecset;
				bool result;
				try
				{
					num = (short)263192582;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						switch (num2)
						{
						case 0:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = frequencyOptionsInnerRecset.GetEnumerator();
							num = (short)234684418;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							num = (short)763756551;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							try
							{
								num = (short)778567688;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
										if (frequencyOptionsInner != null)
										{
											num = (short)1313603590;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 1:
										goto IL_46F;
									case 2:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
										if (frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.Value == 2)
										{
											num = (short)1749745671;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
										num = (short)1147469826;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
										if (frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.Value != 1)
										{
											num = (short)1331888131;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_410;
									}
									case 5:
										goto IL_42B;
									case 6:
									{
										num = (short)1694815202;
										short num4 = num;
										num = (short)867685346;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_46F;
										default:
											num = (short)1708523520;
											if (num != 0)
											{
											}
											num = (short)1011941380;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 7:
										goto IL_410;
									case 8:
										switch (0)
										{
										case 0:
											goto IL_2EB;
										}
										continue;
									case 9:
										goto IL_489;
									case 10:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)2048983041;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner)enumerator2.Current;
										num = (short)1133641728;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									goto IL_2EB;
									IL_410:
									result = true;
									num = (short)856358917;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_430:
									num = (short)1043660810;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_2EB:
									goto IL_430;
									IL_46F:
									num = (short)1547173897;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_42B:
								return result;
								IL_489:
								break;
							}
							finally
							{
								num = (short)430637056;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_4C0;
										}
										continue;
									case 1:
										enumerator2.Dispose();
										num = (short)1808531458;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_4F8;
									}
									IL_4C0:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)924712961;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_4F8:;
							}
							goto IL_4FB;
						case 3:
							goto IL_4FB;
						case 4:
							if (!enumerator.MoveNext())
							{
								num = (short)927924225;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							conventionalPersonality = (enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality);
							num = (short)43712517;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (conventionalPersonality != null)
							{
								num = (short)808583171;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_1ED;
							}
							continue;
						case 7:
							goto IL_56F;
						case 8:
							if (frequencyOptionsInnerRecset != null)
							{
								num = (short)1599471616;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						IL_1F2:
						num = (short)1705115652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1ED:
						goto IL_1F2;
						IL_4FB:
						frequencyOptionsInnerRecset = (conventionalPersonality.Features.Parent[10148].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset);
						num = (short)906756104;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_56F:
					return false;
				}
				finally
				{
					num = (short)1080688640;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_5A6;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)691732482;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_5DD;
						}
						IL_5A6:
						if (enumerator == null)
						{
							break;
						}
						num = (short)810680321;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_5DD:;
				}
				return result;
				IL_73:
				conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
				frequencyOptionsInnerRecset = null;
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num = (short)226557956;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_50;
			}
			}
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x000B45AC File Offset: 0x000B27AC
		internal static bool IsConsolidatedActionsEnhancementUsed()
		{
			short num = (short)638320640;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)374239685;
				short num3 = num;
				num = (short)1362391493;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)346357760;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_95;
					}
					global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					for (;;)
					{
						IL_72:
						switch (num2)
						{
						case 0:
							goto IL_10F;
						case 1:
							if (actionConsolidationRecset != null)
							{
								num = (short)1039728642;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						case 2:
							num = (short)1741094913;
							if (num != 0)
							{
							}
							num = (short)1488715781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							enumerator = actionConsolidationRecset.GetEnumerator();
							num = (short)1346699264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)1879965702;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (radioWide != null)
							{
								num = (short)995491844;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						case 6:
							if (radioWide.Labtool.RadWideLabtoolConsolidatedActionEnhancement_A43036.Value)
							{
								num = (short)1800863747;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						}
						goto IL_95;
					}
					IL_10F:
					bool result;
					try
					{
						num = (short)1451556865;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1343094789;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation;
								num = (short)1055981577;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_20E;
								}
								continue;
							case 2:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset consolidatedActionsInnerRecset;
								if (consolidatedActionsInnerRecset.Count > 13)
								{
									num = (short)413007878;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								goto IL_364;
							case 4:
								num = (short)19136514;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								num = (short)1929379843;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								result = true;
								num = (short)1997471752;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
								global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset consolidatedActionsInnerRecset = actionConsolidation.General.Parent[10615].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset;
								num = (short)62980106;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
								goto IL_2EB;
							case 9:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
								if (actionConsolidation != null)
								{
									num = (short)1233256455;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 10:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset consolidatedActionsInnerRecset;
								if (consolidatedActionsInnerRecset != null)
								{
									num = (short)398196740;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_210:
							num = (short)1643970560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_20E:
							goto IL_210;
						}
						IL_2EB:
						goto IL_3D4;
						IL_364:
						break;
					}
					finally
					{
						num = (short)89325568;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_39C;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)1235353602;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_3D1;
							}
							IL_39C:
							if (enumerator == null)
							{
								break;
							}
							num = (short)630521857;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_3D1:;
					}
					IL_3D4:
					num = (short)1188626432;
					short num4 = num;
					return result;
					IL_95:
					radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					actionConsolidationRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4008) as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset);
					num = (short)2057109505;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_72;
				}
				}
				return false;
			}
			}
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x000B49D8 File Offset: 0x000B2BD8
		internal static bool IsLimitedISSIDVRSOperationCapableUsed()
		{
			short num = (short)1255014400;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide dvrswide;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_A7;
					case 1:
					{
						num = (short)565683432;
						short num3 = num;
						num = (short)1168090344;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A7;
						default:
							num = (short)513998848;
							if (num != 0)
							{
							}
							goto IL_2B3;
						}
						break;
					}
					case 2:
					{
						bool value = dvrswide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = trunkingSystemRecset.GetEnumerator();
						num = (short)989724676;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (trunkingSystemRecset != null)
						{
							num = (short)1231683586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 4:
						try
						{
							num = (short)1074003969;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)633339907;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_157;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)524877824;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1195507716;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_21B;
								case 4:
								{
									bool value;
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if ((enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).General.TrkSysGeneralCoverageType_A7782.Value == 6 && value)
									{
										num = (short)54001670;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_1A7;
								case 6:
									result = true;
									num = (short)45678597;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_159:
								num = (short)443023362;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_157:
								goto IL_159;
							}
							IL_1A7:
							return result;
							IL_21B:
							return false;
						}
						finally
						{
							num = (short)2114060288;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)1847328769;
								if (num != 0)
								{
								}
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_279;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)950730754;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_2B0;
								}
								IL_279:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1877671937;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2B0:;
						}
						goto IL_2B3;
					}
					goto IL_43;
					IL_A7:
					if (dvrswide != null)
					{
						num = (short)1053622273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_2B3:
					num = (short)553254915;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_43:
				num = (short)1168965632;
				short num4 = num;
				dvrswide = (global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide);
				trunkingSystemRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset);
				num = (short)1547370496;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x000B4D24 File Offset: 0x000B2F24
		internal static bool IsActiveMicForPTTUsed()
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_69;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캎손쮒ꚔꞖꦘꮚ", a_)))
					{
						goto IL_368;
					}
					num2 = (short)1283522568;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return true;
				case 2:
					num2 = (short)350224397;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
					if (radioErgonomicsWide.Advanced.RadErgoWideAdvancedActiveMicForBTPTT_43051.Value == 2)
					{
						num2 = (short)849281034;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 4:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide = global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
					num2 = (short)1526923269;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
					if (radioErgonomicsWide != null)
					{
						num2 = (short)1452277771;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 6:
					num2 = (short)2060189705;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
					if (radioErgonomicsWide.Advanced.RadErgoWideAdvancedActiveMicForBTPTT_43051.Value == 3)
					{
						num2 = (short)1561198607;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 8:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
					if (radioErgonomicsWide.Advanced.RadErgoWideAdvancedActiveMicForRSMPTT_43050.Value == 1)
					{
						num2 = (short)868614163;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 9:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
					if (radioErgonomicsWide.Advanced.RadErgoWideAdvancedActiveMicForRSMPTT_43050.Value == 1)
					{
						num2 = (short)12779536;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 10:
					num2 = (short)1242300434;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					num2 = (short)867696641;
					if (num2 != 0)
					{
					}
					num2 = (short)726663168;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
					if (radioErgonomicsWide.Advanced.RadErgoWideAdvancedBTReceiveAudio_43052.Value != 0)
					{
						num2 = (short)1967390721;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 13:
					if (radioWide.Labtool.RadWideLabtoolActiveMicForBTPTTCapable_43053.Value)
					{
						num2 = (short)1127546884;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 14:
					goto IL_197;
				case 15:
					num2 = (short)1681063948;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
				{
					num2 = (short)1011875840;
					short num3 = num2;
					num2 = (short)577175555;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 17:
					if (radioWide != null)
					{
						num2 = (short)1297350658;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 18:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
					if (radioErgonomicsWide.Advanced.RadErgoWideAdvancedBTReceiveAudio_43052.Value == 0)
					{
						return false;
					}
					num2 = (short)397163240;
					short num4 = num2;
					num2 = (short)1912683240;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_368;
					default:
						num2 = (short)995622912;
						if (num2 != 0)
						{
						}
						num2 = (short)869203982;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 19:
					num2 = (short)1854865415;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_69;
				IL_368:
				num2 = (short)2038366214;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_197:
			return true;
			IL_69:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)1948516369;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x000B5128 File Offset: 0x000B3328
		internal static bool IsAPXSingletoneCapableUsed()
		{
			short num = (short)72810496;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3B;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_30E;
					case 1:
						try
						{
							num = (short)729546760;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality.RAC.CnvPerRACCodeType1_A7680.Value != 2)
									{
										num = (short)689438725;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_116;
								}
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)670236678;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
									num = (short)114884618;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									num = (short)1983767634;
									short num3 = num;
									num = (short)632546386;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_118;
									default:
										num = (short)2103771136;
										if (num != 0)
										{
										}
										goto IL_116;
									}
									break;
								}
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality.RAC.CnvPerRACCodeType2_A8817.Value == 2)
									{
										num = (short)1728839682;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_131;
								case 5:
									num = (short)169672707;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)1461977095;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_274;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_D5;
									}
									continue;
								case 9:
									num = (short)282918912;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality != null)
									{
										num = (short)746061833;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_D5;
								IL_118:
								num = (short)722272260;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_116:
								result = true;
								goto IL_118;
								IL_136:
								num = (short)398983169;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D5:
								goto IL_136;
							}
							IL_131:
							return result;
							IL_274:
							return false;
						}
						finally
						{
							num = (short)212336641;
							if (num != 0)
							{
							}
							num = (short)1187577858;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1298530305;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_30B;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2D2;
									}
									continue;
								}
								IL_2D2:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2036465664;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_30B:;
						}
						goto IL_30E;
					case 2:
						if (conventionalPersonalityRecset != null)
						{
							num = (short)1971060736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_3B;
					IL_30E:
					enumerator = conventionalPersonalityRecset.GetEnumerator();
					num = (short)1540882432;
					short num4 = num;
					num = (short)604766209;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_3B:
				conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
				num = (short)1306329090;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x000B54B0 File Offset: 0x000B36B0
		internal static bool IsIPSCapableUsed()
		{
			short num = (short)1084948480;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3A;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset scanListRecset;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)1032388608;
						short num3 = num;
						goto IL_2B2;
					}
					case 1:
						num = (short)1835466753;
						if (num != 0)
						{
						}
						try
						{
							num = (short)307298310;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList;
									if (scanList.General.ScanLstGeneralScanType_A9058.Value == 1)
									{
										goto IL_20C;
									}
									break;
								}
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)277217284;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList;
									num = (short)1947533320;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)1093337088;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_1D8;
								case 4:
								{
									num = (short)89105854;
									short num4 = num;
									num = (short)615687614;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_20C;
									default:
										num = (short)229048320;
										if (num != 0)
										{
										}
										num = (short)1170014215;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									result = true;
									num = (short)560398339;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_F6;
									}
									continue;
								case 7:
									goto IL_23F;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList;
									if (scanList != null)
									{
										num = (short)1598488578;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_137:
								num = (short)875167745;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F6:
								goto IL_137;
								IL_20C:
								num = (short)314900485;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1D8:
							return result;
							IL_23F:
							return false;
						}
						finally
						{
							num = (short)1918763010;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)2091712513;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_2AF;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_277;
									}
									continue;
								}
								IL_277:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1418199040;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2AF:;
						}
						goto IL_2B2;
					case 2:
						if (scanListRecset != null)
						{
							num = (short)557318144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_3A;
					IL_2B2:
					enumerator = scanListRecset.GetEnumerator();
					num = (short)1113653249;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_3A:
				scanListRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2057) as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset);
				num = (short)873857026;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x000B57DC File Offset: 0x000B39DC
		internal static bool IsRadioLockExtensionCapableUsed()
		{
			switch (0)
			{
			case 0:
				goto IL_5E;
			}
			short num;
			int num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
			for (;;)
			{
				IL_0A:
				num = (short)737345537;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)1058013184;
					short num3 = num;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords = radioWideRecset[0][10102] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords;
					num = (short)510197763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords;
					if (userInformationAndPasswords.RadWideUserInformationandPasswordsMaximumPasswordLength_A8477.Value <= 8)
					{
						num = (short)800129029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_170;
				}
				case 2:
					goto IL_ED;
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords;
					if (userInformationAndPasswords.RadWideUserInformationandPasswordsRadioLock_A8836.Value)
					{
						num = (short)251527174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 4:
					if (radioWideRecset.Count > 0)
					{
						num = (short)792068096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
					num = (short)805634056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)708837377;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (radioWideRecset != null)
					{
						num = (short)968359945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 8:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords;
					if (userInformationAndPasswords.RadWideUserInformationandPasswordsUnlockPassword_A8690.Value.Length > 8)
					{
						num = (short)881721346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 9:
					num = (short)7733252;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_5E;
			}
			IL_ED:
			IL_170:
			num = (short)855625685;
			short num4 = num;
			num = (short)881446869;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_ED;
			default:
				num = (short)1351942144;
				if (num != 0)
				{
				}
				return true;
			}
			return false;
			IL_5E:
			radioWideRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset);
			num = (short)1264451591;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x000B5A2C File Offset: 0x000B3C2C
		internal static bool IsEnhancedARSUsed()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset dataProfilesRecset;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num)
				{
				case 0:
					goto IL_208;
				case 1:
				{
					num2 = (short)1025441792;
					short num3 = num2;
					try
					{
						num2 = (short)1309540356;
						num = (int)((global::System.IntPtr)num2);
						bool result;
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_137;
							case 1:
								if (!enumerator.MoveNext())
								{
									num2 = (short)2034499587;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								num2 = (short)1707081734;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_11E;
							case 3:
								num2 = (short)298319877;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_9F;
								}
								continue;
							case 5:
							{
								num2 = (short)982130529;
								short num4 = num2;
								num2 = (short)1736449889;
								switch ((num4 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_11E;
								default:
									goto IL_188;
								}
								break;
							}
							case 6:
								if ((enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles).Features.DataProfFeaturesARSMode_A7465.Value == 5)
								{
									num2 = (short)1869479938;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							IL_E8:
							num2 = (short)1769668609;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_9F:
							goto IL_E8;
							IL_11E:
							result = true;
							num2 = (short)1866465280;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_137:
						return result;
						IL_188:
						num2 = (short)818085888;
						if (num2 != 0)
						{
						}
						goto IL_256;
					}
					finally
					{
						num2 = (short)1634336770;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								enumerator.Dispose();
								num2 = (short)1314521089;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								goto IL_205;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1D2;
								}
								continue;
							}
							IL_1D2:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)345702400;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_205:;
					}
					goto IL_208;
				}
				case 2:
					if (dataProfilesRecset != null)
					{
						num2 = (short)1132462080;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_256;
				}
				goto IL_1C;
				IL_208:
				enumerator = dataProfilesRecset.GetEnumerator();
				num2 = (short)1918304257;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_256:
			num2 = (short)1446379521;
			if (num2 != 0)
			{
			}
			return false;
			IL_1C:
			dataProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset);
			num2 = (short)2100232194;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x000B5CD4 File Offset: 0x000B3ED4
		internal static bool IsZoneCloneCapableUsed()
		{
			short num = (short)889520128;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_62;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
					switch (num2)
					{
					case 0:
					{
						num = (short)371982336;
						short num3 = num;
						if (radioWide.Features.RadWideFeaturesZoneCloneEnable_43130.Value)
						{
							num = (short)565051393;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_332;
					}
					case 1:
						return true;
					case 2:
						num = (short)1953824771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!radioInformation.Labtool.RadInfoLabtoolQ52FEDFPPAndZoneClone_A8798.Value)
						{
							num = (short)2113208328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B1;
					case 4:
						try
						{
							num = (short)1529610248;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									result = true;
									num = (short)341180421;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)1199308802;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
									if (zoneChannelAssignment.Zone.ZnChanCfgZoneZoneCloningEnable_43119.Value)
									{
										num = (short)2085345071;
										short num4 = num;
										num = (short)1475532591;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_189;
										default:
											num = (short)478478336;
											if (num != 0)
											{
											}
											num = (short)538181632;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
									}
									break;
								}
								case 3:
									num = (short)1906573316;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
									if (zoneChannelAssignment.Zone != null)
									{
										goto IL_189;
									}
									break;
								}
								case 5:
									goto IL_2A4;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
									if (zoneChannelAssignment != null)
									{
										num = (short)409075715;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									goto IL_2C2;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_12D;
									}
									continue;
								case 9:
									num = (short)2118451207;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)70713353;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment)enumerator.Current;
									num = (short)166133766;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_12F:
								num = (short)1115160586;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_12D:
								goto IL_12F;
								IL_189:
								num = (short)435617793;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2A4:
							return result;
							IL_2C2:
							return false;
						}
						finally
						{
							num = (short)761397250;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1642856449;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_32F;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2F9;
									}
									continue;
								}
								IL_2F9:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1217200128;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_32F:;
						}
						goto IL_332;
					case 5:
						if (radioInformation.Labtool.RadInfoLabtoolQ53NonFEDFPPAndZoneClone_A8799.Value)
						{
							num = (short)1482752006;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 6:
						goto IL_4B1;
					case 7:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = zoneChannelAssignmentRecset.GetEnumerator();
						num = (short)608698372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						num = (short)2102263813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (radioWide != null)
						{
							num = (short)1530658827;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_332;
					case 10:
						if (radioInformation != null)
						{
							num = (short)1175257090;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 11:
						num = (short)1985871872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (zoneChannelAssignmentRecset != null)
						{
							num = (short)178716679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_62;
					IL_332:
					zoneChannelAssignmentRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset);
					num = (short)1596653580;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4B1:
					radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					num = (short)412811273;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_62:
				num = (short)910884865;
				if (num != 0)
				{
				}
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num = (short)933298186;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x000B6204 File Offset: 0x000B4404
		internal static bool IsEmergencyCallOnlywithHotMicCapableUsed()
		{
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2076) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset).GetEnumerator();
			short num;
			bool result;
			try
			{
				num = (short)693436424;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1853578937;
					short num3 = num;
					num = (short)1375952569;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1928724480;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
						{
							global::AcpBusinessLayer.AcpListField trkEmerProEmergencyAutoTransmitMode_A;
							if (trkEmerProEmergencyAutoTransmitMode_A.Value != 2)
							{
								num = (short)182255621;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1A7;
						}
						case 1:
							num = (short)1442643968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_1A7;
						case 3:
						{
							global::AcpBusinessLayer.AcpListField trkEmerProEmergencyAutoTransmitMode_A;
							if (trkEmerProEmergencyAutoTransmitMode_A.Value == 1)
							{
								num = (short)2123038722;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.General general = ((global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles)enumerator.Current).General;
							global::AcpBusinessLayer.AcpListField trkEmerProEmergencyAutoTransmitMode_A = general.TrkEmerProEmergencyAutoTransmitMode_A22567;
							if (general.RefRadioWide.Labtool.RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.Value)
							{
								num = (short)1721499649;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							goto IL_1C5;
						case 6:
							goto IL_1C0;
						case 7:
							goto IL_253;
						case 8:
							switch (0)
							{
							case 0:
								goto IL_107;
							}
							continue;
						case 9:
							num = (short)845742087;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							if (!enumerator.MoveNext())
							{
								num = (short)542113801;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)583008260;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_109:
						num = (short)1334444042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_107:
						goto IL_109;
						IL_1A7:
						result = true;
						num = (short)176029702;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1C5:
					num = (short)1763246083;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1C0:
				return result;
				IL_253:
				goto IL_17;
			}
			finally
			{
				num = (short)276430850;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)225181697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_2BB;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_288;
						}
						continue;
					}
					IL_288:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1083047936;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2BB:;
			}
			return result;
			IL_17:
			num = (short)1170735104;
			short num4 = num;
			num = (short)480313345;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x000B64EC File Offset: 0x000B46EC
		internal static bool IsEmergencyCallTerminationCapableUsed()
		{
			if (global::SpecialFeatures.RadioFeatureSet.PCIGatings.a())
			{
				short num = (short)1776096493;
				short num2 = num;
				num = (short)748426477;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2011234304;
					short num3 = num;
					num = (short)491257857;
					if (num != 0)
					{
					}
					num = (short)805765120;
					if (num != 0)
					{
					}
					return true;
				}
				}
			}
			return global::SpecialFeatures.RadioFeatureSet.PCIGatings.b();
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x000B65A4 File Offset: 0x000B47A4
		private static bool b()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			bool result;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesRecset conventionalEmergencyProfilesRecset;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num)
				{
				case 0:
					try
					{
						num2 = (short)2041053190;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_179;
							case 1:
								num2 = (short)1589051392;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_15B;
							case 3:
								if (((global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles)enumerator.Current).EmergencyCompatibilityOptionsConventional.EmergencyExitControl_43344Value > 0)
								{
									num2 = (short)210370564;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							case 4:
								result = true;
								num2 = (short)1379598338;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 5:
								if (!enumerator.MoveNext())
								{
									num2 = (short)1497497601;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								num2 = (short)976683011;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 6:
								switch (0)
								{
								case 0:
									goto IL_C7;
								}
								continue;
							}
							IL_10D:
							num2 = (short)386859013;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_C7:
							goto IL_10D;
						}
						IL_15B:
						goto IL_25E;
						IL_179:
						return false;
					}
					finally
					{
						num2 = (short)1221853186;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_236;
							case 1:
							{
								enumerator.Dispose();
								num2 = (short)937097952;
								short num3 = num2;
								num2 = (short)832633568;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_236;
								default:
									num2 = (short)286457856;
									if (num2 != 0)
									{
									}
									num2 = (short)1260519424;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1AE;
								}
								continue;
							}
							IL_1AE:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)869859329;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_236:;
					}
					goto IL_239;
				case 1:
					num2 = (short)1131544577;
					if (num2 != 0)
					{
					}
					goto IL_239;
				case 2:
					if (conventionalEmergencyProfilesRecset != null)
					{
						num2 = (short)632815617;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_1C;
				IL_239:
				enumerator = conventionalEmergencyProfilesRecset.GetEnumerator();
				num2 = (short)1393033216;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_25E:
			num2 = (short)658767872;
			short num4 = num2;
			return result;
			IL_1C:
			conventionalEmergencyProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2075) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesRecset);
			num2 = (short)1115226114;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x000B684C File Offset: 0x000B4A4C
		private static bool a()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			bool result;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset trunkingEmergencyProfilesRecset;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num)
				{
				case 0:
					num2 = (short)1614479361;
					if (num2 != 0)
					{
					}
					try
					{
						num2 = (short)951189510;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_152;
							case 1:
								num2 = (short)1174929408;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_136;
							case 3:
								if (((global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles)enumerator.Current).EmergencyCompatibilityOptionsTrunking.EmergencyExitControl_43341Value > 0)
								{
									num2 = (short)1476657156;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							case 4:
								result = true;
								num2 = (short)566231042;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 5:
								if (!enumerator.MoveNext())
								{
									num2 = (short)846200833;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								num2 = (short)989200387;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 6:
								switch (0)
								{
								case 0:
									goto IL_A1;
								}
								continue;
							}
							IL_E6:
							num2 = (short)177078277;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_A1:
							goto IL_E6;
						}
						IL_136:
						goto IL_25E;
						IL_152:
						return false;
					}
					finally
					{
						num2 = (short)1536753666;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_20D;
							case 1:
							{
								enumerator.Dispose();
								num2 = (short)403578451;
								short num3 = num2;
								num2 = (short)2056592979;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_20D;
								default:
									num2 = (short)2123038720;
									if (num2 != 0)
									{
									}
									num2 = (short)152436736;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_187;
								}
								continue;
							}
							IL_187:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)1166475265;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_20D:;
					}
					goto IL_210;
				case 1:
					goto IL_210;
				case 2:
					if (trunkingEmergencyProfilesRecset != null)
					{
						num2 = (short)1988755457;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_1C;
				IL_210:
				enumerator = trunkingEmergencyProfilesRecset.GetEnumerator();
				num2 = (short)361824256;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_25E:
			num2 = (short)1752825856;
			short num4 = num2;
			return result;
			IL_1C:
			trunkingEmergencyProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2076) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset);
			num2 = (short)336986114;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x000B6AF4 File Offset: 0x000B4CF4
		internal static bool IsExtendedPLToneSetUsed()
		{
			short num = (short)292618240;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4E;
				}
				string[] source;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
						if (conventionalPersonalityRecset != null)
						{
							num = (short)1024327683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D2;
					}
					case 1:
						try
						{
							num = (short)1740177424;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								global::AcpCommonLib.IAcpRecordset acpRecordset;
								global::AcpCommonLib.IAcpRecordset acpRecordset2;
								switch (num2)
								{
								case 0:
									goto IL_462;
								case 1:
									num = (short)536412160;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInner mpllistInner;
									if (source.Contains(mpllistInner.MPLListInnerSection.MplCfgMPLListTxPLCode_A9555_UIValue))
									{
										num = (short)483524617;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_3D2;
								case 4:
									num = (short)1471086602;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)1445593090;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)1267138575;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfiguration mplconfiguration = (global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfiguration)enumerator.Current;
									if (mplconfiguration == null)
									{
										num = (short)206700552;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpRecordset = mplconfiguration.MPLList.EmbeddedRecset;
									goto IL_2EF;
								}
								case 8:
									acpRecordset = null;
									goto IL_2EF;
								case 9:
									goto IL_3B7;
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInner mpllistInner;
									if (!source.Contains(mpllistInner.MPLListInnerSection.MplCfgMPLListTAPLCode_A9262_UIValue))
									{
										num = (short)1556676613;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3B7;
								}
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInner mpllistInner;
									if (mpllistInner != null)
									{
										num = (short)931397638;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1934229505;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1415249927;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
									if (acpRecordset2 != null)
									{
										num = (short)264175630;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 14:
								{
									global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInner mpllistInner = ((global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerRecset)acpRecordset2)[0] as global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInner;
									num = (short)1250689035;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
								{
									global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInner mpllistInner;
									if (!source.Contains(mpllistInner.MPLListInnerSection.MplCfgMPLListRxPLCode_A9026_UIValue))
									{
										num = (short)1114308612;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3B7;
								}
								case 16:
									switch (0)
									{
									case 0:
										goto IL_21A;
									}
									continue;
								}
								goto IL_21A;
								IL_2EF:
								acpRecordset2 = acpRecordset;
								num = (short)633536525;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_32C:
								num = (short)1201537036;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_21A:
								goto IL_32C;
								IL_3B7:
								result = true;
								num = (short)133693443;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3D2:
							return result;
							IL_462:
							return false;
						}
						finally
						{
							num = (short)1190920194;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_4CF;
								case 1:
									enumerator.Dispose();
									num = (short)1656684544;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_499;
									}
									continue;
								}
								IL_499:
								if (enumerator == null)
								{
									break;
								}
								num = (short)444465153;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4CF:;
						}
						goto IL_4D2;
					case 2:
						num = (short)2101739520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = conventionalPersonalityRecset.GetEnumerator();
						num = (short)1448935425;
						if (num != 0)
						{
						}
						num = (short)1721630726;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationRecset mplconfigurationRecset;
						if (mplconfigurationRecset != null)
						{
							num = (short)2093875205;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 5:
					{
						num = (short)1610547200;
						short num3 = num;
						global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationRecset mplconfigurationRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = mplconfigurationRecset.GetEnumerator();
						num = (short)2111832065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						bool result;
						try
						{
							num = (short)15728648;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset frequencyOptionsInnerRecset;
								global::AcpCommonLib.IAcpRecordset acpRecordset3;
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = frequencyOptionsInnerRecset.GetEnumerator();
									num = (short)622854151;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_9B6;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator.Current;
									if (conventionalPersonality == null)
									{
										num = (short)1226244101;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpRecordset3 = conventionalPersonality.Features.Parent[10148].EmbeddedRecset;
									goto IL_691;
								}
								case 3:
									num = (short)1471348737;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)859308035;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1179650;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									acpRecordset3 = null;
									goto IL_691;
								case 6:
									if (frequencyOptionsInnerRecset != null)
									{
										num = (short)1590493184;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 7:
									try
									{
										num = (short)2047148044;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_8F1;
											case 1:
												num = (short)1595080714;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												num = (short)1028194315;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												num = (short)1661927429;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
												goto IL_86E;
											case 5:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
												if (source.Contains(frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxPLCode_A9418_UIValue))
												{
													num = (short)1182466052;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 6:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)1507262473;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner)enumerator2.Current;
												num = (short)1904869384;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 7:
												goto IL_889;
											case 8:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
												if (frequencyOptionsInner != null)
												{
													num = (short)367722497;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 9:
												num = (short)1857945600;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 10:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
												if (!source.Contains(frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsRxPLCode_A8917_UIValue))
												{
													num = (short)1625620482;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_86E;
											}
											case 11:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
												if (!source.Contains(frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTAPLCode_A9261_UIValue))
												{
													num = (short)1023934467;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_86E;
											}
											case 12:
												switch (0)
												{
												case 0:
													goto IL_751;
												}
												continue;
											}
											IL_79A:
											num = (short)158990342;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_751:
											goto IL_79A;
											IL_86E:
											result = true;
											num = (short)1889271815;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_889:
										return result;
										IL_8F1:;
									}
									finally
									{
										num = (short)1180237826;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
											switch (num2)
											{
											case 0:
												goto IL_95D;
											case 1:
												enumerator2.Dispose();
												num = (short)643039232;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_925;
												}
												continue;
											}
											IL_925:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)1701707777;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_95D:;
									}
									break;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_632;
									}
									continue;
								}
								goto IL_632;
								IL_691:
								frequencyOptionsInnerRecset = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset)acpRecordset3;
								num = (short)968556550;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_960:
								num = (short)595132420;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_632:
								goto IL_960;
							}
							IL_9B6:
							goto IL_4D2;
						}
						finally
						{
							num = (short)1495531522;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_A77;
								case 1:
								{
									enumerator.Dispose();
									num = (short)756003774;
									short num4 = num;
									num = (short)592229310;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_A77;
									default:
										num = (short)1518927872;
										if (num != 0)
										{
										}
										num = (short)243400704;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_9EF;
									}
									continue;
								}
								IL_9EF:
								if (enumerator == null)
								{
									break;
								}
								num = (short)530317313;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_A77:;
						}
						return result;
					}
					case 7:
					{
						bool flag = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] is global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset)global::AcpCommonLib.FeatureManager.GetFeature(2059);
						global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationRecset mplconfigurationRecset = (global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationRecset)global::AcpCommonLib.FeatureManager.GetFeature(2078);
						if (flag)
						{
							num = (short)362151938;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					}
					goto IL_4E;
					IL_4D2:
					num = (short)625541124;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_4E:
				source = new string[]
				{
					global::CommonResources.AcgResources.ID_P_1054,
					global::CommonResources.AcgResources.ID_P_1091,
					global::CommonResources.AcgResources.ID_P_1296,
					global::CommonResources.AcgResources.ID_P_1342,
					global::CommonResources.AcgResources.ID_P_1389,
					global::CommonResources.AcgResources.ID_P_1438,
					global::CommonResources.AcgResources.ID_P_1488,
					global::CommonResources.AcgResources.ID_P_1500,
					global::CommonResources.AcgResources.ID_P_1595,
					global::CommonResources.AcgResources.ID_P_1598,
					global::CommonResources.AcgResources.ID_P_1651,
					global::CommonResources.AcgResources.ID_P_1655,
					global::CommonResources.AcgResources.ID_P_1709,
					global::CommonResources.AcgResources.ID_P_1713,
					global::CommonResources.AcgResources.ID_P_1769,
					global::CommonResources.AcgResources.ID_P_1773,
					global::CommonResources.AcgResources.ID_P_1831,
					global::CommonResources.AcgResources.ID_P_1835,
					global::CommonResources.AcgResources.ID_P_1895,
					global::CommonResources.AcgResources.ID_P_1899,
					global::CommonResources.AcgResources.ID_P_1966,
					global::CommonResources.AcgResources.ID_P_1982,
					global::CommonResources.AcgResources.ID_P_1995,
					global::CommonResources.AcgResources.ID_P_2138,
					global::CommonResources.AcgResources.ID_P_2213,
					global::CommonResources.AcgResources.ID_P_2371,
					global::CommonResources.AcgResources.ID_P_2455
				};
				num = (short)1353711623;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x000B75CC File Offset: 0x000B57CC
		internal static bool IsAllowPSUSecureUsed()
		{
			short num = (short)292093952;
			short num2 = num;
			num = (short)532611072;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset).GetEnumerator();
				bool result;
				try
				{
					num = (short)1052049409;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
							if (dataProfiles != null)
							{
								num = (short)61145100;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_C3;
							}
							continue;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1610874884;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem)enumerator.Current;
							num = (short)2058813445;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
							global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = conventionalSystem.General.CnvSysGeneralDataProfileSelection_A13266.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
							num = (short)908722176;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							num = (short)896401416;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
							if (conventionalSystem != null)
							{
								num = (short)159514630;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							num = (short)1143209995;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_E0;
						case 8:
							goto IL_2B3;
						case 9:
							num = (short)420478989;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
							if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 1)
							{
								num = (short)1588330505;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 11:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
							if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 2)
							{
								num = (short)2031550467;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 12:
							num = (short)267911178;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
						{
							global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
							if (dataProfiles.NetworkLayerSecurity.DataProfNLSSecClrStrp_A36415.Value == 1)
							{
								num = (short)979238926;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 14:
							result = true;
							num = (short)1212612615;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_174:
						num = (short)1480589314;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_C3:
						goto IL_174;
					}
					IL_E0:
					return result;
					IL_2B3:
					return false;
				}
				finally
				{
					num = (short)108134401;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_36D;
						case 1:
						{
							num = (short)418833203;
							short num4 = num;
							num = (short)778560307;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_36D;
							default:
								num = (short)1922170880;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_337;
								}
								continue;
							}
							break;
						}
						case 2:
							enumerator.Dispose();
							num = (short)641859584;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_337:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1636761602;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_36D:
					num = (short)1224540161;
					if (num != 0)
					{
					}
				}
				return result;
			}
			}
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x000B7990 File Offset: 0x000B5B90
		internal static bool IsUCLContactsLimitationEnhancementUsed()
		{
			int a_ = 5;
			short num = (short)948699136;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.Dictionary<global::System.Collections.Generic.List<string>, int> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Collections.Generic.List<string>, int>();
				dictionary.Add(new global::System.Collections.Generic.List<string>
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉붋\uda8d힏횑궓욕쾗꾙\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉붋\uda8d힏횑궓욕쾗겙\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉붋\uda8d힏횑궓욕쾗궙\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉붋\uda8d힏횑궓욕쾗ꊙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉붋\uda8d힏횑궓욕쾗ꎙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉붋\uda8d힏횑궓욕쾗꺙\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉뮋\uda8d힏횑궓욕쾗ꮙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뺉떋\uda8d힏횑궓욕쾗ꮙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뾉릋\uda8d힏욑궓욕쾗ꊙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뾉릋\uda8d힏욑궓쒕쾗ꊙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뺉릋\uda8d힏욑궓욕쾗ꊙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얇릉벋얍쎏솑궓욕쾗ꮙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얇릉벋얍쒏솑궓욕쾗ꮙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얇릉벋\udb8d슏솑궓욕쾗ꮙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얇릉벋\uda8d쎏솑궓욕쾗ꮙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얇릉벋\uda8d좏솑궓욕쾗ꮙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얇릉벋\udf8d쎏솑궓욕쾗ꮙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얇릉벋\udf8d쒏솑궓욕쾗ꮙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얇릉벋\udd8d쎏솑궓욕쾗ꮙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒇릉벋\udb8d슏솑궓욕쾗ꮙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒇릉벋얍쎏솑궓욕쾗ꮙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒇릉벋\udf8d쎏솑궓욕쾗ꮙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒇릉벋\udd8d쎏솑궓욕쾗ꮙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒇릉벋\uda8d쎏솑궓욕쾗ꮙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒇릉벋\ud98d슏솑궓욕쾗ꮙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얇릉뮋\uda8d쎏솑궓욕쾗ꮙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얇릉뮋\uda8d좏솑궓욕쾗ꮙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒇릉뮋\uda8d쎏솑궓욕쾗ꮙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc87몉릋\uda8d쎏솑궓욕쾗ꮙ\udd9b킝", a_)
				}, 2500);
				dictionary.Add(new global::System.Collections.Generic.List<string>
				{
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉뒋\udb8d펏횑궓욕쾗꾙\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉뒋\udf8d풏횑궓욕쾗꾙\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉뒋\udd8d풏횑궓욕쾗꾙\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉뒋얍힏횑궓욕쾗꾙\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉뒋\udb8d펏풑궓욕쾗겙\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉뒋\udf8d풏풑궓욕쾗겙\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉뒋\udd8d풏풑궓욕쾗겙\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉뒋얍힏풑궓욕쾗겙\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉뒋\udb8d펏\uda91궓욕쾗궙\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉뒋\udf8d풏\uda91궓욕쾗궙\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉뒋\udd8d풏\uda91궓욕쾗궙\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉뒋얍힏\uda91궓욕쾗궙\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉뒋\udb8d펏횑궓욕쾗꾙\ude9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉뒋\udf8d풏횑궓욕쾗꾙\ude9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉뒋\udd8d풏횑궓욕쾗꾙\ude9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉뒋얍힏횑궓욕쾗꾙\ude9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉뒋\udb8d펏풑궓욕쾗겙\ude9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉뒋\udf8d풏풑궓욕쾗겙\ude9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉뒋\udd8d풏풑궓욕쾗겙\ude9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉뒋얍힏풑궓욕쾗겙\ude9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉뒋\udb8d펏\uda91궓욕쾗궙\ude9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉뒋\udf8d풏\uda91궓욕쾗궙\ude9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉뒋\udd8d풏\uda91궓욕쾗궙\ude9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉뒋얍힏\uda91궓욕쾗궙\ude9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉떋\udf8d풏횑궓욕쾗꾙\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉떋얍힏횑궓욕쾗꾙\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉떋\udb8d펏횑궓욕쾗꾙\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉떋\udf8d풏\uda91궓욕쾗궙\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉떋얍힏\uda91궓욕쾗궙\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉떋\udb8d펏\uda91궓욕쾗궙\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉떋\udf8d풏횑궓욕쾗꾙\ude9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉떋얍힏횑궓욕쾗꾙\ude9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉떋\udb8d펏횑궓욕쾗꾙\ude9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉떋\udf8d풏\uda91궓욕쾗궙\ude9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉떋얍힏\uda91궓욕쾗궙\ude9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇뎉떋\udb8d펏\uda91궓욕쾗궙\ude9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얇뢉릋얍쎏솑궓욕쾗ꮙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얇뢉릋얍쒏솑궓욕쾗ꮙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얇뢉릋\udb8d슏솑궓욕쾗ꮙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얇뢉릋\udf8d쎏솑궓욕쾗ꮙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얇뢉릋\udf8d쒏솑궓욕쾗ꮙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얇뢉릋\udd8d쎏솑궓욕쾗ꮙ\udd9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얇뢉릋\udb8d슏솑궓욕쾗ꮙ\ude9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얇뢉릋얍쎏솑궓욕쾗ꮙ\ude9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얇뢉릋\udf8d쎏솑궓욕쾗ꮙ\ude9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얇뢉릋\udd8d쎏솑궓욕쾗ꮙ\ude9b킝", a_),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얇뢉릋\ud88d슏솑궓욕쾗ꮙ\udf9b킝", a_)
				}, 1500);
				global::AcpBusinessLayer.Recordset recordset = global::AcpCommonLib.FeatureManager.GetFeature(2049) as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset;
				int count = global::AcpCommonLib.FeatureManager.GetFeature(2200).Count;
				int num2 = 1000;
				string radInfoGeneralModelNumber_A8539Value = (recordset[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralModelNumber_A8539Value;
				using (global::System.Collections.Generic.Dictionary<global::System.Collections.Generic.List<string>, int>.Enumerator enumerator = dictionary.GetEnumerator())
				{
					num = (short)1119223809;
					if (num != 0)
					{
					}
					num = (short)255590401;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							global::System.Collections.Generic.KeyValuePair<global::System.Collections.Generic.List<string>, int> keyValuePair;
							if (keyValuePair.Key.Contains(radInfoGeneralModelNumber_A8539Value))
							{
								num = (short)1317470214;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
						{
							num = (short)1785636804;
							short num4 = num;
							num = (short)1902487492;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1921908736;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_737;
								}
								continue;
							}
							break;
						}
						case 2:
							goto IL_7D8;
						case 3:
							num = (short)1371734021;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)241762307;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::System.Collections.Generic.List<string>, int> keyValuePair = enumerator.Current;
							num = (short)1385627648;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_7F2;
						case 6:
						{
							global::System.Collections.Generic.KeyValuePair<global::System.Collections.Generic.List<string>, int> keyValuePair;
							num2 = keyValuePair.Value;
							num = (short)234291202;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_77F:
						num = (short)795934724;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_737:
						goto IL_77F;
					}
					IL_7D8:
					IL_7F2:;
				}
				num = (short)350945280;
				short num5 = num;
				return count > num2;
			}
			}
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x000B81E8 File Offset: 0x000B63E8
		internal static bool IsRemoteMountO3Capable()
		{
			int a_ = 9;
			short num = (short)1185742848;
			short num2 = num;
			num = (short)879583317;
			short num3 = num;
			num = (short)751329365;
			switch (num3 == num)
			{
			}
			num = (short)1195769857;
			if (num != 0)
			{
			}
			num = (short)1807548416;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솋붍ꚏ작욓얕ꆗ쪙쮛꾝", a_));
			list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솋붍ꚏ쎑잓얕ꆗ쪙쮛꾝", a_));
			list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솋붍ꚏ\ud991잓얕ꆗ쪙쮛꾝", a_));
			list.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솋붍ꚏ솑잓얕ꆗ쪙쮛꾝", a_));
			string radInfoGeneralModelNumber_A8539Value = ((global::AcpCommonLib.FeatureManager.GetFeature(2049) as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralModelNumber_A8539Value;
			return list.Contains(radInfoGeneralModelNumber_A8539Value);
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x000B8320 File Offset: 0x000B6520
		internal static bool IsDVRSRangeExtUsed()
		{
			short num = (short)522061013;
			short num2 = num;
			num = (short)820315349;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return false;
			case 1:
				break;
			default:
			{
				num = (short)492437504;
				short num3 = num;
				break;
			}
			}
			num = (short)939851776;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_95;
			}
			int num4;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
			bool value2;
			bool value3;
			for (;;)
			{
				IL_7F:
				switch (num4)
				{
				case 0:
					if (radioInformation != null)
					{
						num = (short)815923203;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
				{
					num = (short)1712783361;
					if (num != 0)
					{
					}
					bool value = radioInformation.Labtool.RadioInfoLabToolGA00631DvrsMsuOperation_A41827.Value;
					value2 = radioInformation.Labtool.RadInfoLabtoolMotoVMLDataModemTethering_A42852.Value;
					value3 = radioInformation.Labtool.RadInfoLabtoolThirdPartyModemTethering_A43043.Value;
					if (value)
					{
						num = (short)1538523138;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 2:
					goto IL_16A;
				case 3:
					num = (short)903348225;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_95;
			}
			return false;
			IL_16A:
			return value2 || value3;
			IL_95:
			radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
			num = (short)128188416;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_7F;
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x000B84A0 File Offset: 0x000B66A0
		internal static bool IsIndirectPTTAudioRoutingUsed()
		{
			short num = (short)1597243392;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)332870454;
					short num3 = num;
					num = (short)596128566;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_158;
					default:
						num = (short)997261312;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_86;
						}
						continue;
					}
					break;
				}
				case 1:
					if (radioErgonomicsWide != null)
					{
						num = (short)1767112707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
					goto IL_16F;
				case 3:
				{
					num = (short)1848115200;
					short num4 = num;
					num = (short)79233029;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					radioErgonomicsWide = (global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide);
					num = (short)2098462721;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if ((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Labtool.RadWideLabtoolIndirectPTTAudioRoutingPCI_44817.Value)
					{
						goto IL_158;
					}
					return false;
				}
				IL_86:
				if (!global::ConstraintHelper.UtilityMack.IsMobile())
				{
					num = (short)1438908417;
					if (num != 0)
					{
					}
					num = (short)1324744708;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_158:
				num = (short)1126957058;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_16F:
			return radioErgonomicsWide.Advanced.RadErgoWideAdvancedActiveMicForIndirectPTT_44816Value != radioErgonomicsWide.Advanced.RadErgoWideAdvancedActiveMicForIndirectPTT_44816.DefaultValue;
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x000B8670 File Offset: 0x000B6870
		internal static bool IsAnalogWidebandDataPCIRoutingUsed()
		{
			short num = (short)1615921152;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)506196324;
					short num3 = num;
					num = (short)1201664356;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_115;
					default:
						num = (short)1606877184;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_88;
						}
						continue;
					}
					break;
				}
				case 1:
					if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
					{
						num = (short)1946419203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
					goto IL_141;
				case 3:
				{
					radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					num = (short)184811520;
					short num4 = num;
					num = (short)95551493;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					num = (short)579993601;
					if (num != 0)
					{
					}
					num = (short)1569456129;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_115;
				}
				IL_88:
				if (global::ConstraintHelper.UtilityMack.IsMobile())
				{
					num = (short)814153732;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_115:
				if (!radioWide.Labtool.RadWideLabtoolAnalogWideBandDataPCIBit_44885.Value)
				{
					return false;
				}
				num = (short)1113784322;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_141:
			return radioWide.Features.RadWideFeatureAnalogWidebandData.Value;
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x000B882C File Offset: 0x000B6A2C
		internal static bool IsADPUsedInHighOrMidTierDevice()
		{
			int a_ = 13;
			short num = (short)114688000;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_60;
			}
			int num3;
			string radInfoGeneralModelNumber_A8539Value;
			bool result;
			for (;;)
			{
				IL_3E:
				global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
				bool flag;
				switch (num3)
				{
				case 0:
					secureWide = (global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
					num = (short)1616576515;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (new global::System.Collections.Generic.List<string>
					{
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑꖓ슕\udf97\ude99ꖛ캝鞡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑꖓ슕\udf97\ude99ꖛ캝钡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑꖓ슕\udf97\ude99ꖛ캝閡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑꖓ슕\udf97\ude99ꖛ캝骡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑꖓ슕\udf97\ude99ꖛ캝鮡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑꖓ슕\udf97\ude99ꖛ캝隡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑꎓ슕\udf97\ude99ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꚑ궓슕\udf97\ude99ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꞑꆓ슕\udf97캙ꖛ캝骡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꞑꆓ슕\udf97캙ꖛ첝骡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꚑꆓ슕\udf97캙ꖛ캝骡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8fꆑ꒓\udd95쮗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8fꆑ꒓\udd95첗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8fꆑ꒓쎕쪗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8fꆑ꒓슕쮗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8fꆑ꒓슕삗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8fꆑ꒓잕쮗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8fꆑ꒓잕첗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8fꆑ꒓얕쮗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8fꆑ꒓쎕쪗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8fꆑ꒓\udd95쮗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8fꆑ꒓잕쮗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8fꆑ꒓얕쮗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8fꆑ꒓슕쮗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8fꆑ꒓솕쪗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8fꆑꎓ슕쮗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8fꆑꎓ슕삗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8fꆑꎓ슕쮗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒏ꊑꆓ슕쮗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ겓쎕\udb97\ude99ꖛ캝鞡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ겓잕\udc97\ude99ꖛ캝鞡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ겓얕\udc97\ude99ꖛ캝鞡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ겓\udd95\udf97\ude99ꖛ캝鞡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ겓쎕\udb97\udc99ꖛ캝钡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ겓잕\udc97\udc99ꖛ캝钡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ겓얕\udc97\udc99ꖛ캝钡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ겓\udd95\udf97\udc99ꖛ캝钡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ겓쎕\udb97튙ꖛ캝閡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ겓잕\udc97튙ꖛ캝閡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ겓얕\udc97튙ꖛ캝閡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ겓\udd95\udf97튙ꖛ캝閡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ겓쎕\udb97\ude99ꖛ캝鞡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ겓잕\udc97\ude99ꖛ캝鞡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ겓얕\udc97\ude99ꖛ캝鞡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ겓\udd95\udf97\ude99ꖛ캝鞡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ겓쎕\udb97\udc99ꖛ캝钡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ겓잕\udc97\udc99ꖛ캝钡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ겓얕\udc97\udc99ꖛ캝钡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ겓\udd95\udf97\udc99ꖛ캝钡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ겓쎕\udb97튙ꖛ캝閡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ겓잕\udc97튙ꖛ캝閡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ겓얕\udc97튙ꖛ캝閡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ겓\udd95\udf97튙ꖛ캝閡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ궓잕\udc97\ude99ꖛ캝鞡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ궓\udd95\udf97\ude99ꖛ캝鞡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ궓쎕\udb97\ude99ꖛ캝鞡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ궓잕\udc97튙ꖛ캝閡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ궓\udd95\udf97튙ꖛ캝閡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ궓쎕\udb97튙ꖛ캝閡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ궓잕\udc97\ude99ꖛ캝鞡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ궓\udd95\udf97\ude99ꖛ캝鞡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ궓쎕\udb97\ude99ꖛ캝鞡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ궓잕\udc97튙ꖛ캝閡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ궓\udd95\udf97튙ꖛ캝閡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88fꮑ궓쎕\udb97튙ꖛ캝閡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8fꂑꆓ\udd95쮗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8fꂑꆓ\udd95첗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8fꂑꆓ쎕쪗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8fꂑꆓ잕쮗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8fꂑꆓ잕첗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8fꂑꆓ얕쮗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8fꂑꆓ쎕쪗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8fꂑꆓ\udd95쮗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8fꂑꆓ잕쮗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8fꂑꆓ얕쮗즙ꖛ캝鎡", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8fꂑꆓ삕쪗즙ꖛ캝鎡", a_)
					}.Contains(radInfoGeneralModelNumber_A8539Value))
					{
						num = (short)1391788032;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					num = (short)23527428;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (secureWide.General.SecureWideADPAlgorithmEnable_43200Value)
					{
						num = (short)848101378;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)963117062;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_767;
				case 5:
					return result;
				case 6:
				{
					num = (short)465371550;
					short num4 = num;
					num = (short)1859649950;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_767;
					default:
						num = (short)152043520;
						if (num != 0)
						{
						}
						flag = false;
						goto IL_7D5;
					}
					break;
				}
				}
				goto IL_60;
				IL_7D5:
				result = flag;
				num = (short)805109765;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_767:
				flag = (secureWide.General.SecWideGeneralSecureOperation_A9067.Value == 3);
				goto IL_7D5;
			}
			return result;
			IL_60:
			num = (short)289603585;
			if (num != 0)
			{
			}
			result = false;
			radInfoGeneralModelNumber_A8539Value = ((global::AcpCommonLib.FeatureManager.GetFeature(2049) as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralModelNumber_A8539Value;
			num = (short)232194049;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_3E;
		}
	}
}
