using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace AcpUI.Common
{
	// Token: 0x0200007C RID: 124
	public class CellVisibilityStausConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x060005E3 RID: 1507 RVA: 0x00078860 File Offset: 0x00076A60
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)952762377;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1543372807;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_234;
				case 1:
				{
					num = (short)1976303617;
					if (num != 0)
					{
					}
					bool flag = (bool)values[0];
					bool flag2 = (bool)values[1];
					if (flag)
					{
						num = (short)596705286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12F;
				}
				case 2:
				{
					bool flag2;
					if (!flag2)
					{
						num = (short)1617297412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_234;
				}
				case 3:
					if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)893583365;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_234;
				case 4:
					goto IL_E8;
				case 5:
					num = (short)1031143425;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)441993045;
					short num3 = num;
					num = (short)293488469;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AF;
					default:
						num = (short)638582784;
						if (num != 0)
						{
						}
						num = (short)1732116482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					num = (short)1016659971;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_AF;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				}
				IL_4C:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)1540423680;
					short num4 = num;
					num = (short)869400584;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)122159104;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_AF:
			return false;
			IL_E8:
			IL_12F:
			return false;
			IL_234:
			return true;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00078AA8 File Offset: 0x00076CA8
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)591551786;
			short num2 = num;
			num = (short)2118212906;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1235156992;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)932380673;
			if (num != 0)
			{
			}
			num = (short)1669005312;
			if (num != 0)
			{
			}
			return null;
		}
	}
}
