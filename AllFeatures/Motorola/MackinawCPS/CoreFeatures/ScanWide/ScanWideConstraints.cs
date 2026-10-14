using System;
using AcpCommonLib;

namespace Motorola.MackinawCPS.CoreFeatures.ScanWide
{
	// Token: 0x02000106 RID: 262
	public static class ScanWideConstraints
	{
		// Token: 0x0600264B RID: 9803 RVA: 0x0025744C File Offset: 0x0025564C
		internal static bool ConOffHookSuspScanEnIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1031012353;
			if (num != 0)
			{
			}
			num = (short)34799616;
			short num2 = num;
			num = (short)374814378;
			short num3 = num;
			num = (short)2129802922;
			switch (num3 == num)
			{
			}
			num = (short)404619264;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.ScanWide.General).ScanWideRadioWideHUBSuspendsScan_A8216.Value;
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x00257504 File Offset: 0x00255704
		internal static bool ConAlertToneInhIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)832155717;
			short num2 = num;
			num = (short)510373957;
			switch (num2 == num)
			{
			default:
			{
				num = (short)42598400;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)436994049;
			if (num != 0)
			{
			}
			num = (short)533856256;
			if (num != 0)
			{
			}
			return !(self as global::Motorola.MackinawCPS.CoreFeatures.ScanWide.General).RefRadioWide.AlertTones.RadProfAlertTonesAlertTones_A7428.Value;
		}
	}
}
