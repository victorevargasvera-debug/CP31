using System;
using System.Globalization;
using System.Windows;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x020000D4 RID: 212
	public class BoolToVisibilityConverter : global::Infragistics.ValueConverterBase
	{
		// Token: 0x060007DE RID: 2014 RVA: 0x0001C0F8 File Offset: 0x0001A2F8
		public override object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
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

		// Token: 0x060007DF RID: 2015 RVA: 0x0001C160 File Offset: 0x0001A360
		public override object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
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
