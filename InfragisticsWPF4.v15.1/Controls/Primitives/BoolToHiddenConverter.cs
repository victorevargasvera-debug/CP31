using System;
using System.Globalization;
using System.Windows;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x020001C2 RID: 450
	public class BoolToHiddenConverter : global::Infragistics.ValueConverterBase
	{
		// Token: 0x06000F48 RID: 3912 RVA: 0x00032A1C File Offset: 0x00030C1C
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
			return (flag == !flag3) ? global::System.Windows.Visibility.Visible : global::System.Windows.Visibility.Hidden;
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00032A84 File Offset: 0x00030C84
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
