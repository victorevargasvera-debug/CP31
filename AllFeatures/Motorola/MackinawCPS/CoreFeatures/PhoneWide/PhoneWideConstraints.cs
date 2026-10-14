using System;
using AcpBusinessLayer;
using AcpCommonLib;

namespace Motorola.MackinawCPS.CoreFeatures.PhoneWide
{
	// Token: 0x02000431 RID: 1073
	public static class PhoneWideConstraints
	{
		// Token: 0x0600920A RID: 37386 RVA: 0x0089A6A0 File Offset: 0x008988A0
		internal static bool ConVerifyDtmfCodesLengthForPhnDeaccessGui(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::AcpBusinessLayer.AcpFieldX<string, string> phnWideDTMFCodesDeaccess_A = (self as global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFCodesInnerSection).PhnWideDTMFCodesDeaccess_A7803;
			short num;
			if (phnWideDTMFCodesDeaccess_A.Value == null)
			{
				for (;;)
				{
					num = (short)1890058240;
					short num2 = num;
					num = (short)1671810387;
					short num3 = num;
					num = (short)1530187091;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_78;
					}
				}
				IL_78:
				num = (short)361365504;
				if (num != 0)
				{
				}
				return true;
			}
			num = (short)1326579713;
			if (num != 0)
			{
			}
			return phnWideDTMFCodesDeaccess_A.Value.Length <= 4;
		}
	}
}
