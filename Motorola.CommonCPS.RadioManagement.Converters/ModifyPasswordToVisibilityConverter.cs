using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000033 RID: 51
	public class ModifyPasswordToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600009B RID: 155 RVA: 0x000090B0 File Offset: 0x000072B0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value == global::System.Windows.DependencyProperty.UnsetValue)
			{
				short num;
				for (;;)
				{
					num = (short)838644372;
					short num2 = num;
					num = (short)1481552532;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_41;
					}
				}
				IL_41:
				num = (short)1410990081;
				if (num != 0)
				{
				}
				num = (short)229703680;
				if (num != 0)
				{
				}
				num = (short)1686241280;
				short num3 = num;
				return false;
			}
			return global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00009174 File Offset: 0x00007374
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1733999315;
			short num2 = num;
			num = (short)241416915;
			switch (num2 == num)
			{
			}
			num = (short)1564016641;
			if (num != 0)
			{
			}
			num = (short)1466499072;
			short num3 = num;
			num = (short)1325268992;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
