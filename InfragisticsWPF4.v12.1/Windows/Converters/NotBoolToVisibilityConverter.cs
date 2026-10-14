using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Windows.Converters
{
	// Token: 0x020000F5 RID: 245
	[global::System.Obsolete("This class is obsolete. The Infragistics.Windows.Controls.NotBoolToVisibilityConverter should be used instead.", true)]
	public class NotBoolToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600087F RID: 2175 RVA: 0x0001C98A File Offset: 0x0001AB8A
		object global::System.Windows.Data.IValueConverter.Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value is bool)
			{
				return this.BoolToVisibility(!(bool)value);
			}
			return global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x0001C9AF File Offset: 0x0001ABAF
		object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value is global::System.Windows.Visibility)
			{
				return !this.VisibilityToBool((global::System.Windows.Visibility)value);
			}
			return false;
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0001C9D4 File Offset: 0x0001ABD4
		private bool VisibilityToBool(global::System.Windows.Visibility v)
		{
			return v == global::System.Windows.Visibility.Visible;
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x0001C9EA File Offset: 0x0001ABEA
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
