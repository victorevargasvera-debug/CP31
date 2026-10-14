using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020001DB RID: 475
	public class VisibilityToBoolValueConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000C9B RID: 3227 RVA: 0x0002C6F8 File Offset: 0x0002A8F8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			bool flag = false;
			if (value is global::System.Windows.Visibility)
			{
				global::System.Windows.Visibility visibility = (global::System.Windows.Visibility)value;
				flag = (visibility == global::System.Windows.Visibility.Visible);
			}
			return flag;
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x0002C724 File Offset: 0x0002A924
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Collapsed;
			if (value is bool)
			{
				visibility = (((bool)value) ? global::System.Windows.Visibility.Visible : global::System.Windows.Visibility.Collapsed);
			}
			return visibility;
		}
	}
}
