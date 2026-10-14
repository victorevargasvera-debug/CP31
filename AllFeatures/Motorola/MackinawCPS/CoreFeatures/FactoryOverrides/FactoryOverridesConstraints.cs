using System;
using AcpCommonLib;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x02000447 RID: 1095
	public static class FactoryOverridesConstraints
	{
		// Token: 0x0600939C RID: 37788 RVA: 0x008AF104 File Offset: 0x008AD304
		internal static bool ConFactoryOverridesEnableIsChecked(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)553713665;
			if (num != 0)
			{
			}
			num = (short)652345344;
			short num2 = num;
			num = (short)36442210;
			short num3 = num;
			num = (short)1027215458;
			switch (num3 == num)
			{
			}
			num = (short)1833041920;
			if (num != 0)
			{
			}
			return (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverrides).General.RadWideAdvancedFactoryOverrides_A8004.Value;
		}

		// Token: 0x0600939D RID: 37789 RVA: 0x008AF1D4 File Offset: 0x008AD3D4
		internal static bool conFacOvrrdRxFreqMHzIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1021771777;
			if (num != 0)
			{
			}
			num = (short)74514433;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int inputFrequency;
				switch (num2)
				{
				case 0:
				{
					num = (short)265687383;
					short num3 = num;
					num = (short)268898647;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_91;
					default:
						goto IL_118;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				case 2:
					return true;
				case 3:
					return false;
				case 4:
					if (!global::ConstraintHelper.UtilityMack.IsRxFrequencyBandEnabled(inputFrequency, false))
					{
						num = (short)1509621763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1280507909;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!global::ConstraintHelper.UtilityMack.IsConRxFrequencyBandOnStep(inputFrequency, self))
					{
						num = (short)154075136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				goto IL_64;
				IL_91:
				num = (short)1340342274;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_64:
				global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSynthesizerReferenceDividerListInnerSection rxSynthesizerReferenceDividerListInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSynthesizerReferenceDividerListInnerSection;
				inputFrequency = rxSynthesizerReferenceDividerListInnerSection.FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.Value * 5;
				if (rxSynthesizerReferenceDividerListInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.Value)
				{
					goto IL_91;
				}
				num = (short)2000486400;
				short num4 = num;
				num = (short)256049156;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_118:
			num = (short)722206720;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x0600939E RID: 37790 RVA: 0x008AF380 File Offset: 0x008AD580
		internal static bool conFacOvrrdSecLOInjFreqIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1144848385;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int inputFrequency;
				switch (num2)
				{
				case 0:
				{
					num = (short)1801809161;
					short num3 = num;
					num = (short)1670540553;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_69;
					default:
						goto IL_11A;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 2:
					return true;
				case 3:
					return false;
				case 4:
					if (!global::ConstraintHelper.UtilityMack.IsRxFrequencyBandEnabled(inputFrequency, true))
					{
						num = (short)2117730307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)47251461;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!global::ConstraintHelper.UtilityMack.IsConRxFrequencyBandOnStep(inputFrequency, self))
					{
						num = (short)1013383168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				goto IL_3C;
				IL_69:
				num = (short)627769345;
				if (num != 0)
				{
				}
				num = (short)1053032450;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3C:
				global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.SecondLOInjectionFrequencyListInnerSection secondLOInjectionFrequencyListInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.SecondLOInjectionFrequencyListInnerSection;
				inputFrequency = secondLOInjectionFrequencyListInnerSection.FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.Value * 5;
				if (secondLOInjectionFrequencyListInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.Value)
				{
					goto IL_69;
				}
				num = (short)1980104704;
				short num4 = num;
				num = (short)1377107972;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_11A:
			num = (short)1008533504;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x0600939F RID: 37791 RVA: 0x008AF52C File Offset: 0x008AD72C
		internal static bool conFacOvrrdRxFrequencyIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)289931265;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int inputFrequency;
				switch (num2)
				{
				case 0:
				{
					num = (short)229082811;
					short num3 = num;
					num = (short)677807803;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_69;
					default:
						goto IL_EE;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 2:
					return true;
				case 3:
					return false;
				case 4:
					if (!global::ConstraintHelper.UtilityMack.IsRxFrequencyBandEnabled(inputFrequency, true))
					{
						num = (short)646840323;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1995177989;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!global::ConstraintHelper.UtilityMack.IsConRxFrequencyBandOnStep(inputFrequency, self))
					{
						num = (short)1519386624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				goto IL_3C;
				IL_69:
				num = (short)1563885570;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3C:
				global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxFrequencyListInnerSection rxFrequencyListInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxFrequencyListInnerSection;
				inputFrequency = rxFrequencyListInnerSection.FctOrdsRxFrequencyListRxFrequency.Value * 5;
				if (rxFrequencyListInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.Value)
				{
					goto IL_69;
				}
				num = (short)906952704;
				short num4 = num;
				num = (short)2112815108;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_EE:
			num = (short)1476591617;
			if (num != 0)
			{
			}
			num = (short)877854720;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x060093A0 RID: 37792 RVA: 0x008AF6D4 File Offset: 0x008AD8D4
		public static bool conFacOvrrdTxFreqMHzIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2062680065;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int inputFrequency;
				switch (num2)
				{
				case 0:
				{
					num = (short)259637657;
					short num3 = num;
					num = (short)1537524121;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_91;
					default:
						goto IL_120;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 2:
					return true;
				case 3:
					return false;
				case 4:
					if (!global::ConstraintHelper.UtilityMack.IsTxFrequencyBandEnabled(inputFrequency))
					{
						num = (short)1068433411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)705167365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!global::ConstraintHelper.UtilityMack.IsConTxFrequencyBandOnStep(inputFrequency, self))
					{
						num = (short)1341652992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				goto IL_3C;
				IL_91:
				num = (short)890437634;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3C:
				num = (short)1322057729;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSynthesizerReferenceDividerListInnerSection txSynthesizerReferenceDividerListInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSynthesizerReferenceDividerListInnerSection;
				inputFrequency = txSynthesizerReferenceDividerListInnerSection.FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.Value * 5;
				if (txSynthesizerReferenceDividerListInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.Value)
				{
					goto IL_91;
				}
				num = (short)1014890496;
				short num4 = num;
				num = (short)729743364;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_120:
			num = (short)2126381056;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x060093A1 RID: 37793 RVA: 0x008AF888 File Offset: 0x008ADA88
		public static bool ConFacOvrrdTxSSITxFreqMHzIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSSIClockRateListInnerSection txSSIClockRateListInnerSection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return true;
				case 1:
				{
					num2 = (short)838591482;
					short num3 = num2;
					num2 = (short)2055201786;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_52;
					default:
						goto IL_16B;
					}
					break;
				}
				case 2:
				{
					int inputFrequency = txSSIClockRateListInnerSection.FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.Value * 5;
					num2 = (short)1220673542;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (txSSIClockRateListInnerSection != null)
					{
						goto IL_52;
					}
					return true;
				case 4:
				{
					int inputFrequency;
					if (!global::ConstraintHelper.UtilityMack.IsConTxFrequencyBandOnStep(inputFrequency, self))
					{
						num2 = (short)1231421440;
						short num4 = num2;
						num2 = (short)451346439;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 5:
				{
					num2 = (short)1990787073;
					if (num2 != 0)
					{
					}
					int inputFrequency;
					if (!global::ConstraintHelper.UtilityMack.IsTxFrequencyBandEnabled(inputFrequency))
					{
						num2 = (short)1899233281;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1890254852;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					if (txSSIClockRateListInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.Value)
					{
						num2 = (short)819658752;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)367460357;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					return false;
				}
				goto IL_30;
				IL_52:
				num2 = (short)869597186;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_16B:
			num2 = (short)1736376320;
			if (num2 != 0)
			{
			}
			return false;
			IL_30:
			txSSIClockRateListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSSIClockRateListInnerSection);
			num2 = (short)194510851;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060093A2 RID: 37794 RVA: 0x008AFA78 File Offset: 0x008ADC78
		public static bool ConFacOvrrdRxSSIRxFreqMHzIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateListInnerSection rxSSIClockRateListInnerSection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return true;
				case 1:
				{
					num2 = (short)2184378;
					short num3 = num2;
					num2 = (short)1181570234;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_51;
					default:
						goto IL_141;
					}
					break;
				}
				case 2:
				{
					int inputFrequency = rxSSIClockRateListInnerSection.FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.Value * 5;
					num2 = (short)479395846;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (rxSSIClockRateListInnerSection != null)
					{
						goto IL_51;
					}
					return true;
				case 4:
				{
					int inputFrequency;
					if (!global::ConstraintHelper.UtilityMack.IsConRxFrequencyBandOnStep(inputFrequency, self))
					{
						num2 = (short)756088832;
						short num4 = num2;
						num2 = (short)1140916231;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 5:
				{
					int inputFrequency;
					if (!global::ConstraintHelper.UtilityMack.IsRxFrequencyBandEnabled(inputFrequency, true))
					{
						num2 = (short)1248854017;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1206845444;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					if (rxSSIClockRateListInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.Value)
					{
						num2 = (short)1356988416;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)809304069;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					return false;
				}
				goto IL_30;
				IL_51:
				num2 = (short)743505922;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_141:
			num2 = (short)160825344;
			if (num2 != 0)
			{
			}
			num2 = (short)195493889;
			if (num2 != 0)
			{
			}
			return false;
			IL_30:
			rxSSIClockRateListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateListInnerSection);
			num2 = (short)790691843;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060093A3 RID: 37795 RVA: 0x008AFC64 File Offset: 0x008ADE64
		internal static bool ConFacOvrrdRxSSITXModeTxFreqMHzIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateTXModeInnerSection rxSSIClockRateTXModeInnerSection;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return false;
				case 1:
				{
					int inputFrequency = rxSSIClockRateTXModeInnerSection.FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.Value * 5;
					num2 = (short)1685520393;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (rxSSIClockRateTXModeInnerSection != null)
					{
						num2 = (short)146407429;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 3:
					if (radioInformation != null)
					{
						num2 = (short)1289748481;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 4:
				{
					num2 = (short)850820348;
					short num3 = num2;
					num2 = (short)1348697340;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)236781568;
						if (num2 != 0)
						{
						}
						int inputFrequency;
						if (global::ConstraintHelper.UtilityMack.IsTxFrequencyBandEnabled(inputFrequency))
						{
							num2 = (short)537788416;
							short num4 = num2;
							num2 = (short)1361510408;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					num2 = (short)1090584582;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					num2 = (short)900792323;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					return false;
				case 7:
					return true;
				case 8:
				{
					int inputFrequency;
					if (!global::ConstraintHelper.UtilityMack.IsConTxFrequencyBandOnStep(inputFrequency, self))
					{
						num2 = (short)1145503744;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 9:
					num2 = (short)740491265;
					if (num2 != 0)
					{
					}
					if (radioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.Value)
					{
						num2 = (short)1147273223;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1664286724;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_38;
			}
			return false;
			IL_38:
			rxSSIClockRateTXModeInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateTXModeInnerSection);
			radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
			num2 = (short)1580924930;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
