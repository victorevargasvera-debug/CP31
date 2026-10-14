using System;
using AcpCommonLib;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;

namespace Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert
{
	// Token: 0x020001B4 RID: 436
	public static class VirtualPartnerConstraints
	{
		// Token: 0x06005183 RID: 20867 RVA: 0x004A17FC File Offset: 0x0049F9FC
		internal static bool conVPAlertActionValidityACActionType(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1583022081;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4B;
			}
			int num2;
			bool result;
			for (;;)
			{
				IL_31:
				switch (num2)
				{
				case 0:
				{
					num = (short)1769930752;
					short num3 = num;
					num = (short)126288853;
					short num4 = num;
					num = (short)797049813;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_61;
					default:
						goto IL_D9;
					}
					break;
				}
				case 1:
					return result;
				case 2:
					goto IL_61;
				case 3:
					if ((global::AcpCommonLib.FeatureManager.GetFeature(4008)[index - 1] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation).General.RadioErgoConfigACActionType_A42871.Value != 4)
					{
						num = (short)1789001732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 4:
					result = false;
					num = (short)971571201;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4B;
				IL_61:
				if (index == 0)
				{
					num = (short)1319829504;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1550057475;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_D9:
			num = (short)1581776896;
			if (num != 0)
			{
			}
			return result;
			IL_4B:
			result = true;
			num = (short)1813905410;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_31;
		}
	}
}
