using System;
using AcpBusinessLayer;
using AcpCommonLib;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;

namespace Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability
{
	// Token: 0x02000244 RID: 580
	public static class PersonnelAccountabilityConstraints
	{
		// Token: 0x0600684D RID: 26701 RVA: 0x005D5E44 File Offset: 0x005D4044
		internal static bool ConACListSelectionIsIndex(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			global::AcpBusinessLayer.AcpRecRefField radioErgoConfigACReference_A;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
				switch (num)
				{
				case 0:
					goto IL_12A;
				case 1:
					if (radioErgoConfigACReference_A.RefRecset != null)
					{
						num2 = (short)1203830788;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					num2 = (short)975896577;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_1B1;
				case 4:
					actionConsolidation = (radioErgoConfigACReference_A.RefRecset[index - 1] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation);
					num2 = (short)543031301;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (actionConsolidation == null)
					{
						num2 = (short)875298823;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1431502848;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					num2 = (short)1207845804;
					short num3 = num2;
					num2 = (short)139019180;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12A;
					default:
					{
						num2 = (short)1420361728;
						short num4 = num2;
						num2 = (short)1687027713;
						if (num2 != 0)
						{
						}
						num2 = (short)1386741760;
						if (num2 != 0)
						{
						}
						if (index != 0)
						{
							num2 = (short)1388576770;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					}
					break;
				}
				case 7:
					return false;
				case 8:
					result = false;
					num2 = (short)847118339;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_34;
				IL_12A:
				if (actionConsolidation.General.RadioErgoConfigACActionType_A42871.Value == 3)
				{
					break;
				}
				num2 = (short)856031240;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1B1:
			return result;
			IL_34:
			global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInnerSection perAccListTableInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInnerSection;
			result = true;
			radioErgoConfigACReference_A = perAccListTableInnerSection.RadioErgoConfigACReference_A42911;
			num2 = (short)1239547910;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
