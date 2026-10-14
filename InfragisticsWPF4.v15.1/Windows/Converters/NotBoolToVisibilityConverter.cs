using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Windows.Converters
{
	// Token: 0x02000113 RID: 275
	[global::System.Obsolete("This class is obsolete. The Infragistics.Windows.Controls.NotBoolToVisibilityConverter should be used instead.", true)]
	public class NotBoolToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600097E RID: 2430 RVA: 0x00020552 File Offset: 0x0001E752
		object global::System.Windows.Data.IValueConverter.Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value is bool)
			{
				return this.BoolToVisibility(!(bool)value);
			}
			return global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00020577 File Offset: 0x0001E777
		object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value is global::System.Windows.Visibility)
			{
				return !this.VisibilityToBool((global::System.Windows.Visibility)value);
			}
			return false;
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0002059C File Offset: 0x0001E79C
		private bool VisibilityToBool(global::System.Windows.Visibility v)
		{
			return v == global::System.Windows.Visibility.Visible;
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x000205B2 File Offset: 0x0001E7B2
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
