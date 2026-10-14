using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000078 RID: 120
	public class ReadOnlyToCellBackGroundConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600016C RID: 364 RVA: 0x00013478 File Offset: 0x00011678
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (!(bool)value)
			{
				short num = (short)1288216185;
				short num2 = num;
				num = (short)222338681;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1102381056;
					if (num != 0)
					{
					}
					num = (short)387055617;
					if (num != 0)
					{
					}
					num = (short)57147392;
					short num3 = num;
					return new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.DarkGray);
				}
				}
			}
			return new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.Black);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00013540 File Offset: 0x00011740
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)130679994;
			short num2 = num;
			num = (short)1637221562;
			switch (num2 == num)
			{
			}
			num = (short)46792705;
			if (num != 0)
			{
			}
			num = (short)949682176;
			if (num != 0)
			{
			}
			num = (short)2046623744;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
