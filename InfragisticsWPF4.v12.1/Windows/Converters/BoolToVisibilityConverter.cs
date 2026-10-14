using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Windows.Converters
{
	// Token: 0x020000F4 RID: 244
	[global::System.Obsolete("This class is obsolete. The System.Windows.Controls.BooleanToVisibilityConverter should be used instead.", true)]
	public class BoolToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600087A RID: 2170 RVA: 0x0001C91F File Offset: 0x0001AB1F
		object global::System.Windows.Data.IValueConverter.Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value is bool)
			{
				return this.BoolToVisibility((bool)value);
			}
			return global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0001C941 File Offset: 0x0001AB41
		object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value is global::System.Windows.Visibility)
			{
				return this.VisibilityToBool((global::System.Windows.Visibility)value);
			}
			return false;
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x0001C964 File Offset: 0x0001AB64
		private bool VisibilityToBool(global::System.Windows.Visibility v)
		{
			return v == global::System.Windows.Visibility.Visible;
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x0001C97A File Offset: 0x0001AB7A
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
