using System;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO3;
using Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;

namespace Motorola.MackinawCPS.CoreFeatures.EmergencyWide
{
	// Token: 0x02000483 RID: 1155
	public static class EmergencyWideConstraints
	{
		// Token: 0x0600986C RID: 39020 RVA: 0x008F00EC File Offset: 0x008EE2EC
		internal static bool ConMCHAndIgnitionNotInhibit(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition1_A;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					IL_132:
					if (switchConventionalSwitchesPosition1_A.Value == 71)
					{
						num2 = (short)225378306;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 1:
					num2 = (short)948764672;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_99;
				case 3:
					if (switchConventionalSwitchesPosition1_A.Value != 27)
					{
						num2 = (short)1980039169;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_99;
				}
				goto IL_20;
				IL_99:
				num2 = (short)2021785600;
				short num3 = num2;
				num2 = (short)381826581;
				short num4 = num2;
				num2 = (short)489305621;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_132;
				default:
					goto IL_F7;
				}
			}
			IL_F7:
			num2 = (short)1472724992;
			if (num2 != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.General general;
			return !general.EmerWideGeneralEmergencyPowerUp_A7942.Value;
			IL_20:
			num2 = (short)22478849;
			if (num2 != 0)
			{
			}
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.General);
			switchConventionalSwitchesPosition1_A = general.RefRadioWide.Features.SwitchConventionalSwitchesPosition1_A12643;
			num2 = (short)441057283;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600986D RID: 39021 RVA: 0x008F0254 File Offset: 0x008EE454
		internal static bool conEmerSilentAlarmIsDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)602540567;
			short num2 = num;
			num = (short)1631914519;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1360855040;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1615462400;
			if (num != 0)
			{
			}
			num = (short)956104705;
			if (num != 0)
			{
			}
			return !(self as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.General).EmerWideGeneralSilentAlarm_A9130.Value;
		}

		// Token: 0x0600986E RID: 39022 RVA: 0x008F0310 File Offset: 0x008EE510
		internal static bool conRXIndIsDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)649310033;
			short num2 = num;
			num = (short)500084561;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1776746496;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1845297153;
			if (num != 0)
			{
			}
			num = (short)866516992;
			if (num != 0)
			{
			}
			return !(self as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.General).EmerWideGeneralEmergencyCallReceive_A7937.Value;
		}

		// Token: 0x0600986F RID: 39023 RVA: 0x008F03CC File Offset: 0x008EE5CC
		internal static bool ConUnmuteOptionValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.General general = self as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.General;
			if (!general.EmerWideGeneralUnmuteOption_A9598.Value)
			{
				short num;
				for (;;)
				{
					num = (short)1941176320;
					short num2 = num;
					num = (short)258890978;
					short num3 = num;
					num = (short)1180523746;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_75;
					}
				}
				IL_75:
				num = (short)923533313;
				if (num != 0)
				{
				}
				num = (short)803078144;
				if (num != 0)
				{
				}
				return !general.EmerWideGeneralSuppressEmergencyCall_A42142.Value;
			}
			return true;
		}

		// Token: 0x06009870 RID: 39024 RVA: 0x008F049C File Offset: 0x008EE69C
		internal static bool SetEditabilityAlwaysFalse(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)824895098;
			short num2 = num;
			num = (short)1756751482;
			switch (num2 == num)
			{
			default:
			{
				num = (short)547356672;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)977207296;
			if (num != 0)
			{
			}
			num = (short)1237909505;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06009871 RID: 39025 RVA: 0x008F0544 File Offset: 0x008EE744
		internal static bool ConManDownTriggerIsNotDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)347822826;
			short num2 = num;
			num = (short)1446861546;
			switch (num2 == num)
			{
			default:
			{
				num = (short)124321792;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)500498432;
			if (num != 0)
			{
			}
			num = (short)2102394881;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.ManDown).EmerWideManDownTrigger_A40001.Value != 0;
		}

		// Token: 0x06009872 RID: 39026 RVA: 0x008F0600 File Offset: 0x008EE800
		internal static bool ConPerEmerProfIsSelected(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide emergencyWide = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide;
			if (emergencyWide.ManDown.EmerWideManDownTrigger_A40001.Value != 0)
			{
				short num;
				for (;;)
				{
					num = (short)1413939200;
					short num2 = num;
					num = (short)1853510928;
					short num3 = num;
					num = (short)1545688336;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_81;
					}
				}
				IL_81:
				num = (short)1745682432;
				if (num != 0)
				{
				}
				num = (short)1303707649;
				if (num != 0)
				{
				}
				return emergencyWide.ManDown.ManDownConfigurabilityGranularityLevel_42057.Value == 1;
			}
			return false;
		}

		// Token: 0x06009873 RID: 39027 RVA: 0x008F06E4 File Offset: 0x008EE8E4
		internal static void conSetTriggedByManDownValue(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.ManDown manDown = self as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.ManDown;
			global::AcpBusinessLayer.AcpField<bool> triggedByManDown_ = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide).EmergencyToneTrigger.TriggedByManDown_42135;
			if (manDown.ManDownConfigurabilityGranularityLevel_42057.Value == 1)
			{
				short num;
				for (;;)
				{
					num = (short)469630976;
					short num2 = num;
					num = (short)1109768355;
					short num3 = num;
					num = (short)802535587;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_8B;
					}
				}
				IL_8B:
				num = (short)345047040;
				if (num != 0)
				{
				}
				num = (short)1477509121;
				if (num != 0)
				{
				}
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(triggedByManDown_, true));
				return;
			}
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(triggedByManDown_, false));
		}

		// Token: 0x06009874 RID: 39028 RVA: 0x008F07D8 File Offset: 0x008EE9D8
		internal static bool ConSilientAlarmEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)102055415;
			short num2 = num;
			num = (short)2006597111;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2032992256;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1427177473;
			if (num != 0)
			{
			}
			num = (short)1067712512;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.General).EmerWideGeneralSilentAlarm_A9130.Value;
		}

		// Token: 0x06009875 RID: 39029 RVA: 0x008F0890 File Offset: 0x008EEA90
		internal static bool ConDisableEmergencyCallIndicationsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.General general;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1961295874;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)935725468;
					short num3 = num2;
					num2 = (short)1442384284;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_53;
					default:
						num2 = (short)1417936896;
						if (num2 != 0)
						{
						}
						if (general.RefRadioWide.TPS.RadWideTPSAudibleEmergencyBeaconsec_A7502.Value == 0)
						{
							num2 = (short)557973507;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					}
					break;
				}
				case 2:
					if (general.EmerWideGeneralSilentAlarm_A9130.Value)
					{
						num2 = (short)167903236;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
					goto IL_140;
				case 4:
					num2 = (short)1217200129;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (general.EmerWideGeneralSuppressEmergencyCall_A42142.Value)
					{
						goto IL_53;
					}
					goto IL_189;
				}
				goto IL_28;
				IL_53:
				num2 = (short)1336868865;
				if (num2 != 0)
				{
				}
				num2 = (short)187695104;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_140:
			return !general.RefRadioWide.TPS.RadWideTPSFiregroundEmergencyCallDekeySidetone_A7936.Value;
			IL_189:
			num2 = (short)871694336;
			short num4 = num2;
			return true;
			IL_28:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.General);
			num2 = (short)179175429;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06009876 RID: 39030 RVA: 0x008F0A50 File Offset: 0x008EEC50
		internal static bool DisableEmergencyCallIndicationsApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.General general = self as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.General;
			if (!general.EmerWideGeneralSilentAlarm_A9130.Value)
			{
				short num;
				for (;;)
				{
					num = (short)1179779072;
					short num2 = num;
					num = (short)809514430;
					short num3 = num;
					num = (short)145569214;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_77;
					}
				}
				IL_77:
				num = (short)1797980161;
				if (num != 0)
				{
				}
				num = (short)1871052800;
				if (num != 0)
				{
				}
				return general.EmerWideGeneralSuppressEmergencyCall_A42142.Value;
			}
			return true;
		}

		// Token: 0x06009877 RID: 39031 RVA: 0x008F0B1C File Offset: 0x008EED1C
		internal static bool ConDualRadioSystemIsNOTSecondaryApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1663579122;
			short num2 = num;
			num = (short)2076390386;
			switch (num2 == num)
			{
			default:
			{
				num = (short)36241408;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)569114625;
			if (num != 0)
			{
			}
			num = (short)846135296;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.General).RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 2;
		}

		// Token: 0x06009878 RID: 39032 RVA: 0x008F0BE8 File Offset: 0x008EEDE8
		internal static bool ConConfigLevelIsNotDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)800750577;
			short num2 = num;
			num = (short)1209629681;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1818296320;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)709951489;
			if (num != 0)
			{
			}
			num = (short)767950848;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideImpactDetection emergencyWideImpactDetection = self as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideImpactDetection;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset controlHeadO3Recset = global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset;
			global::AcpBusinessLayer.Recordset recordset = global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset;
			controlHeadO3Recset.CalculateValidity();
			recordset.CalculateValidity();
			return emergencyWideImpactDetection.EmerWideImpactDetectionConfigLevel_A43384.Value != 0;
		}

		// Token: 0x06009879 RID: 39033 RVA: 0x008F0CCC File Offset: 0x008EEECC
		internal static bool conImpDetectApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)484811060;
			short num2 = num;
			num = (short)1185653044;
			switch (num2 == num)
			{
			default:
			{
				num = (short)944635904;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1351352321;
			if (num != 0)
			{
			}
			num = (short)1393229824;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideImpactDetection).EmerWideImpactDetectionConfigLevel_A43384.Value == 2;
		}

		// Token: 0x0600987A RID: 39034 RVA: 0x008F0D88 File Offset: 0x008EEF88
		internal static void conSetTriggedByImpDetectValue(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideImpactDetection emergencyWideImpactDetection = self as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideImpactDetection;
			global::AcpBusinessLayer.AcpField<bool> emerWideImpDectToneTrigger_A = emergencyWideImpactDetection.EmerWideImpDectToneTrigger_A43386;
			if (emergencyWideImpactDetection.EmerWideImpactDetectionConfigLevel_A43384.Value == 2)
			{
				short num;
				for (;;)
				{
					num = (short)226361344;
					short num2 = num;
					num = (short)190312203;
					short num3 = num;
					num = (short)1094774539;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_7F;
					}
				}
				IL_7F:
				num = (short)1900806144;
				if (num != 0)
				{
				}
				num = (short)1128464385;
				if (num != 0)
				{
				}
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(emerWideImpDectToneTrigger_A, true));
				return;
			}
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(emerWideImpDectToneTrigger_A, false));
		}

		// Token: 0x0600987B RID: 39035 RVA: 0x008F0E70 File Offset: 0x008EF070
		internal static bool ConEmerConfEmerWideDistingEmerTypeAllow(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)307167233;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.General general = self as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.General;
			if (general.EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933.Value != 2)
			{
				for (;;)
				{
					num = (short)125173760;
					short num2 = num;
					num = (short)1844571286;
					short num3 = num;
					num = (short)140897430;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_9E;
					}
				}
				IL_9E:
				num = (short)176488448;
				if (num != 0)
				{
				}
				return general.EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933.Value == 3;
			}
			return true;
		}

		// Token: 0x0600987C RID: 39036 RVA: 0x008F0F44 File Offset: 0x008EF144
		internal static bool ConEmerWideKeepAliveValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1724186624;
					short num3 = num2;
					if (radioErgonomicsWide.Advanced.RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451Value != 0)
					{
						return true;
					}
					num2 = (short)575541594;
					short num4 = num2;
					num2 = (short)1465192794;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_83;
					default:
						num2 = (short)1603862529;
						if (num2 != 0)
						{
						}
						num2 = (short)75104256;
						if (num2 != 0)
						{
						}
						num2 = (short)1418133506;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					return true;
				case 2:
					goto IL_15E;
				case 3:
					if (radioErgonomicsWide.Advanced.RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451 == null)
					{
						num2 = (short)452329473;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_83;
				}
				goto IL_20;
				IL_83:
				num2 = (short)190578688;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_15E:
			global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.General general;
			return !general.EmerWideGeneralKeepAlive_A8360Value;
			IL_20:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.General);
			radioErgonomicsWide = (global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide);
			num2 = (short)155254787;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
