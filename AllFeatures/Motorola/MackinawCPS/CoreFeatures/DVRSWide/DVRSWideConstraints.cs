using System;
using AcpBusinessLayer;
using AcpCommonLib;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.RadioVIPs;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.DVRSWide
{
	// Token: 0x020004A9 RID: 1193
	public static class DVRSWideConstraints
	{
		// Token: 0x06009DA3 RID: 40355 RVA: 0x00933D0C File Offset: 0x00931F0C
		internal static bool ConDVRSHardWareIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)196565475;
			short num2 = num;
			num = (short)1626364387;
			switch (num2 == num)
			{
			}
			num = (short)77660160;
			if (num != 0)
			{
			}
			num = (short)625082368;
			short num3 = num;
			num = (short)722206721;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.General).RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value;
		}

		// Token: 0x06009DA4 RID: 40356 RVA: 0x00933DC4 File Offset: 0x00931FC4
		public static bool ConDVRSHardWareIsApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int num;
			short num2;
			global::AcpBusinessLayer.AcpField<bool> radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A;
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
						return true;
					case 1:
					{
						num2 = (short)875081679;
						short num3 = num2;
						num2 = (short)1372630991;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4D;
						default:
						{
							num2 = (short)2100756480;
							if (num2 != 0)
							{
							}
							global::ConstraintHelper.UtilityMack.IsDVRSHwEnabled = radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A.Value;
							num2 = (short)1150156800;
							short num4 = num2;
							num2 = (short)463339520;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 2:
						num2 = (short)1255997441;
						if (num2 != 0)
						{
						}
						if (global::ConstraintHelper.UtilityMack.IsDVRSHwEnabled != radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A.Value)
						{
							num2 = (short)452329473;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					}
					goto IL_1C;
				}
				return true;
			}
			IL_1C:
			global::AcpCommonLib.IAcpRecordset embeddedRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2125) as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsRecset)[0][10797].EmbeddedRecset;
			radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A = (self as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.General).RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911;
			IL_4D:
			num2 = (short)1848311810;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06009DA5 RID: 40357 RVA: 0x00933F20 File Offset: 0x00932120
		public static bool ConDVRSHardWareIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1462108160;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.General general;
				int num3;
				bool flag;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						num = (short)30539789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_290;
					case 2:
						goto IL_290;
					case 3:
						goto IL_BC;
					case 4:
						if (general.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value)
						{
							num = (short)1540882432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BC;
					case 5:
						if (num3 < 0)
						{
							num = (short)1317470216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = (global::AcpCommonLib.FeatureManager.GetFeature(2059)[num3][10140] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Advanced).CnvPerAdvancedAnalogFlatAudio_A7443.Value;
						num = (short)835321867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1549795337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						num = (short)1311506432;
						short num4 = num;
						if (flag)
						{
							num = (short)1341259786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 8:
						goto IL_24A;
					case 9:
						if (radioWide.Features.RadWideAdvancedRFModem_A8972.Value == 0)
						{
							num = (short)1924005891;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 10:
						goto IL_11C;
					case 11:
						if (!flag)
						{
							num = (short)1901461516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24A;
					case 12:
						num3--;
						num = (short)233963522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (!radioWide.Labtool.DVRSRangeExt_44809.Value)
						{
							num = (short)939130886;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BC;
					}
					goto IL_67;
					IL_BC:
					num = (short)1482686471;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24A:
					num = (short)986185732;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_290:
					num = (short)1024740162;
					short num5 = num;
					num = (short)1439648578;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						num = (short)1180958721;
						if (num != 0)
						{
						}
						num = (short)121307136;
						if (num != 0)
						{
						}
						num = (short)232456197;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_11C:
				return !general.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value;
				IL_67:
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.General);
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				flag = false;
				num3 = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset).Count - 1;
				num = (short)1827012609;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}
	}
}
