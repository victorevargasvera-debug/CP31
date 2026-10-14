using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000098 RID: 152
	public class RadiosCountToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001CC RID: 460 RVA: 0x00017DC8 File Offset: 0x00015FC8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num;
			if ((int)value != 1)
			{
				num = (short)1871457524;
				short num2 = num;
				num = (short)673197300;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)311296001;
					if (num != 0)
					{
					}
					num = (short)623706112;
					if (num != 0)
					{
					}
					return global::System.Windows.Visibility.Visible;
				}
			}
			num = (short)681377792;
			short num3 = num;
			return global::System.Windows.Visibility.Hidden;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00017E8C File Offset: 0x0001608C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)636113213;
			short num2 = num;
			num = (short)1800950077;
			switch (num2 == num)
			{
			}
			num = (short)539099137;
			if (num != 0)
			{
			}
			num = (short)222298112;
			if (num != 0)
			{
			}
			num = (short)1927806976;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
