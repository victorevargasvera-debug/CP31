using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000086 RID: 134
	public class FlashCodeIndicatorVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000196 RID: 406 RVA: 0x00015094 File Offset: 0x00013294
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)308816330;
			short num2 = num;
			num = (short)1838164426;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1315766272;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1646329857;
			if (num != 0)
			{
			}
			num = (short)429522944;
			if (num != 0)
			{
			}
			return global::System.Windows.Visibility.Visible;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00015144 File Offset: 0x00013344
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)60212678;
			short num2 = num;
			num = (short)1355335110;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1602879488;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1211236353;
			if (num != 0)
			{
			}
			num = (short)2114191360;
			if (num != 0)
			{
			}
			return null;
		}
	}
}
