using System;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using AcpBusinessLayer;
using AcpCommonLib;

namespace AcpUI.Common
{
	// Token: 0x0200009B RID: 155
	public static class StepUpDownUtility
	{
		// Token: 0x06000656 RID: 1622 RVA: 0x00082704 File Offset: 0x00080904
		internal static void a(object A_0, global::AcpBusinessLayer.AcpFieldBase A_1)
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			int num;
			global::System.Windows.Controls.Primitives.RepeatButton repeatButton;
			short num2;
			global::AcpCommonLib.IAcpRangeField acpRangeField;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_163;
				case 1:
					if (repeatButton != null)
					{
						num2 = (short)245825541;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					return;
				case 3:
					if (repeatButton.Name.Equals(global::AcpUI.Common.Utility.c("쪤킦잨솬욮튰\ud8b2", a_), global::System.StringComparison.Ordinal))
					{
						num2 = (short)1708523520;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					acpRangeField.StepUp();
					num2 = (short)2137325570;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (acpRangeField != null)
					{
						num2 = (short)763363334;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 5:
				{
					num2 = (short)309385996;
					short num3 = num2;
					num2 = (short)1754192652;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_116;
					default:
					{
						num2 = (short)1139802112;
						short num4 = num2;
						num2 = (short)1567817729;
						if (num2 != 0)
						{
						}
						num2 = (short)1162477568;
						if (num2 != 0)
						{
						}
						num2 = (short)323354628;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 6:
					goto IL_116;
				}
				goto IL_35;
				IL_116:
				num2 = (short)428802051;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_163:
			acpRangeField.StepDown();
			return;
			IL_35:
			repeatButton = (A_0 as global::System.Windows.Controls.Primitives.RepeatButton);
			acpRangeField = (A_1 as global::AcpCommonLib.IAcpRangeField);
			num2 = (short)1032781825;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x000828D0 File Offset: 0x00080AD0
		internal static void a(global::System.Windows.Input.KeyEventArgs A_0, global::AcpBusinessLayer.AcpFieldBase A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::System.Windows.Input.Key key;
			short num2;
			global::AcpCommonLib.IAcpRangeField acpRangeField;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (key != global::System.Windows.Input.Key.Up)
					{
						num2 = (short)628031491;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					acpRangeField.StepUp();
					A_0.Handled = true;
					num2 = (short)729874434;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (key == global::System.Windows.Input.Key.Down)
					{
						num2 = (short)37355524;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					goto IL_B5;
				case 3:
				{
					num2 = (short)630980608;
					short num3 = num2;
					num2 = (short)1838546945;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					goto IL_148;
				}
				goto IL_24;
			}
			IL_B5:
			return;
			IL_148:
			num2 = (short)1706033153;
			if (num2 != 0)
			{
			}
			num2 = (short)1150802773;
			short num4 = num2;
			num2 = (short)65264469;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			default:
				num2 = (short)41091072;
				if (num2 != 0)
				{
				}
				acpRangeField.StepDown();
				A_0.Handled = true;
				return;
			}
			IL_24:
			acpRangeField = (A_1 as global::AcpCommonLib.IAcpRangeField);
			key = A_0.Key;
			num2 = (short)1475674112;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
