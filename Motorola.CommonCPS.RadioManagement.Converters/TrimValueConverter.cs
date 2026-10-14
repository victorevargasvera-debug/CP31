using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x020000A9 RID: 169
	public class TrimValueConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001FF RID: 511 RVA: 0x0001B100 File Offset: 0x00019300
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1266941952;
			short num2 = num;
			num = (short)2058944513;
			if (num != 0)
			{
			}
			if (value != null)
			{
				num = (short)293056221;
				short num3 = num;
				num = (short)761900765;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1398341632;
					if (num != 0)
					{
					}
					break;
				}
				return value.ToString().Trim();
			}
			return string.Empty;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0001B1C0 File Offset: 0x000193C0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1134886913;
			if (num != 0)
			{
			}
			num = (short)1246531445;
			short num2 = num;
			num = (short)849252213;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1646854144;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1991639040;
			if (num != 0)
			{
			}
			return value;
		}
	}
}
