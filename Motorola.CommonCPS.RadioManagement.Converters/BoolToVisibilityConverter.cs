using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200008E RID: 142
	public class BoolToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001AE RID: 430 RVA: 0x0001616C File Offset: 0x0001436C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1414201346;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1836441778;
					short num3 = num;
					num = (short)2028855474;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						goto IL_E1;
					}
					break;
				}
				case 1:
					goto IL_66;
				case 2:
					goto IL_14;
				case 3:
				{
					num = (short)1064042496;
					short num4 = num;
					num = (short)1490026496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_34;
				IL_14:
				switch (0)
				{
				case 0:
					IL_34:
					if (!(bool)value)
					{
						num = (short)198377475;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1312882689;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_66:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Visible;
			goto IL_121;
			IL_E1:
			num = (short)512425985;
			if (num != 0)
			{
			}
			num = (short)1415708672;
			if (num != 0)
			{
			}
			visibility = global::System.Windows.Visibility.Collapsed;
			IL_121:
			return visibility;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000162A0 File Offset: 0x000144A0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1686814700;
			short num2 = num;
			num = (short)393723884;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1223688192;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)48300033;
			if (num != 0)
			{
			}
			num = (short)33030144;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
