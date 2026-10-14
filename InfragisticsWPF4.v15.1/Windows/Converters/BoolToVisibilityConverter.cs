using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Windows.Converters
{
	// Token: 0x02000112 RID: 274
	[global::System.Obsolete("This class is obsolete. The System.Windows.Controls.BooleanToVisibilityConverter should be used instead.", true)]
	public class BoolToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000979 RID: 2425 RVA: 0x000204E7 File Offset: 0x0001E6E7
		object global::System.Windows.Data.IValueConverter.Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value is bool)
			{
				return this.BoolToVisibility((bool)value);
			}
			return global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00020509 File Offset: 0x0001E709
		object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value is global::System.Windows.Visibility)
			{
				return this.VisibilityToBool((global::System.Windows.Visibility)value);
			}
			return false;
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0002052C File Offset: 0x0001E72C
		private bool VisibilityToBool(global::System.Windows.Visibility v)
		{
			return v == global::System.Windows.Visibility.Visible;
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00020542 File Offset: 0x0001E742
		private global::System.Windows.Visibility BoolToVisibility(bool b)
		{
			if (b)
			{
				return global::System.Windows.Visibility.Visible;
			}
			return global::System.Windows.Visibility.Collapsed;
		}
	}
}
