using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000087 RID: 135
	public class InverseBoolsToVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000199 RID: 409 RVA: 0x00015204 File Offset: 0x00013404
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			int num4;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1550057472;
					short num3 = num2;
					object obj;
					if ((bool)obj)
					{
						num2 = (short)1212088327;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num4++;
					num2 = (short)930807810;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					num2 = (short)263301802;
					short num5 = num2;
					num2 = (short)2007935658;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)99876864;
						if (num2 != 0)
						{
						}
						object obj;
						if (obj != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num2 = (short)1841364992;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					num2 = (short)1793785860;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_158;
				case 3:
					goto IL_1B8;
				case 4:
					goto IL_156;
				case 5:
				{
					num2 = (short)1378222081;
					if (num2 != 0)
					{
					}
					if (num4 >= values.Length)
					{
						num2 = (short)481558531;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					object obj = values[num4];
					num2 = (short)827916289;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					goto IL_158;
				case 7:
					goto IL_C8;
				}
				goto IL_30;
				IL_158:
				num2 = (short)60686341;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_C8:
			return global::System.Windows.Visibility.Collapsed;
			IL_156:
			return global::System.Windows.Visibility.Collapsed;
			IL_1B8:
			return global::System.Windows.Visibility.Visible;
			IL_30:
			num4 = 0;
			num2 = (short)558235654;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000153E0 File Offset: 0x000135E0
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1485915863;
			short num2 = num;
			num = (short)1312966359;
			switch (num2 == num)
			{
			default:
			{
				num = (short)126222336;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)335085568;
			if (num != 0)
			{
			}
			num = (short)1696792577;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
