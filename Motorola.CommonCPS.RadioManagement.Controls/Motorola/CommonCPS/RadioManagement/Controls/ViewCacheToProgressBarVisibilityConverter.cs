using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200003A RID: 58
	internal class ViewCacheToProgressBarVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x060000B2 RID: 178 RVA: 0x0000BF84 File Offset: 0x0000A184
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1715339268;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_65;
				case 1:
				{
					string value;
					if (!string.IsNullOrEmpty(value))
					{
						num = (short)568655879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)263454726;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					num = (short)1793327107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					int num3;
					if (num3 - 3 <= 3)
					{
						num = (short)1924268037;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D9;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 5:
					goto IL_99;
				case 6:
				{
					int num3;
					if (num3 != 1)
					{
						num = (short)247726082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A9;
				}
				case 7:
					goto IL_143;
				}
				IL_46:
				if (values[1] == global::System.Windows.DependencyProperty.UnsetValue)
				{
					num = (short)682033152;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					int num3 = (int)values[1];
					string value = values[2] as string;
					num = (short)305454359;
					short num4 = num;
					num = (short)964746519;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_65;
					default:
						num = (short)1593704448;
						if (num != 0)
						{
						}
						num = (short)986316801;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			IL_65:
			return global::System.Windows.Visibility.Collapsed;
			IL_99:
			IL_A9:
			return global::System.Windows.Visibility.Visible;
			IL_143:
			num = (short)1083834368;
			short num5 = num;
			num = (short)85000193;
			if (num != 0)
			{
			}
			return global::System.Windows.Visibility.Visible;
			IL_1D9:
			return global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000C170 File Offset: 0x0000A370
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)655505431;
			short num2 = num;
			num = (short)364066839;
			switch (num2 == num)
			{
			}
			num = (short)42598400;
			short num3 = num;
			num = (short)552206337;
			if (num != 0)
			{
			}
			num = (short)1499463680;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
