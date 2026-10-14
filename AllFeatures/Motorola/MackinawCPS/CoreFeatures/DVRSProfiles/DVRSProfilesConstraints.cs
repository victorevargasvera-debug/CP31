using System;
using AcpCommonLib;

namespace Motorola.MackinawCPS.CoreFeatures.DVRSProfiles
{
	// Token: 0x020004B1 RID: 1201
	public static class DVRSProfilesConstraints
	{
		// Token: 0x06009E49 RID: 40521 RVA: 0x0093C584 File Offset: 0x0093A784
		internal static bool ConDVRSHardWareIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)870497794;
			short num2 = num;
			num = (short)2027011586;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1023803392;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)84344833;
			if (num != 0)
			{
			}
			num = (short)54132736;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.General).RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value;
		}

		// Token: 0x06009E4A RID: 40522 RVA: 0x0093C644 File Offset: 0x0093A844
		internal static bool ConOutBoundSysRepLocalMode(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)405681409;
			short num2 = num;
			num = (short)2093757697;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2113929217;
				if (num != 0)
				{
				}
				num = (short)481558528;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.General general = self as global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.General;
				if (general.DVRSProfGeneralMSUSysPTTInLocalMode_A41803.Value)
				{
					return general.DVRSProfGeneralOutSysRepLocalMode_A41804.Value;
				}
				break;
			}
			}
			num = (short)781778944;
			short num3 = num;
			return true;
		}

		// Token: 0x06009E4B RID: 40523 RVA: 0x0093C710 File Offset: 0x0093A910
		internal static bool ConMSUSysPTTLocalMode(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)744256847;
			short num2 = num;
			num = (short)69170511;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2145517569;
				if (num != 0)
				{
				}
				num = (short)129433600;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.General general = self as global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.General;
				if (general.DVRSProfGeneralLocalTxFallback_A41806.Value)
				{
					return !general.DVRSProfGeneralMSUSysPTTInLocalMode_A41803.Value;
				}
				break;
			}
			}
			num = (short)2121203712;
			short num3 = num;
			return true;
		}

		// Token: 0x06009E4C RID: 40524 RVA: 0x0093C7E0 File Offset: 0x0093A9E0
		internal static bool ConDVRSHardWareIsEnabledAndHoldoffIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)418923006;
			short num2 = num;
			num = (short)1920156158;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1900412928;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.General general = self as global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.General;
				if (general.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value)
				{
					return general.DVRSProfGeneralGenStsOnDVRSModChg_A41801.Value;
				}
				break;
			}
			}
			num = (short)417595393;
			if (num != 0)
			{
			}
			num = (short)1113391104;
			short num3 = num;
			return false;
		}
	}
}
