using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x020000B8 RID: 184
	public class BoolToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060006F3 RID: 1779 RVA: 0x00018950 File Offset: 0x00016B50
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			bool flag = false;
			if (value is bool)
			{
				flag = (bool)value;
			}
			else if (value is bool?)
			{
				bool? flag2 = (bool?)value;
				flag = (flag2 != null && flag2.Value);
			}
			bool flag3 = parameter is bool && (bool)parameter;
			return (flag == !flag3) ? global::System.Windows.Visibility.Visible : global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x000189B8 File Offset: 0x00016BB8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value is global::System.Windows.Visibility)
			{
				bool flag = (global::System.Windows.Visibility)value == global::System.Windows.Visibility.Visible;
				bool flag2 = parameter is bool && (bool)parameter;
				return flag == !flag2;
			}
			return false;
		}
	}
}
