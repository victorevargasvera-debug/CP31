using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000166 RID: 358
	public sealed class FormattableToStringConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000C06 RID: 3078 RVA: 0x000276C4 File Offset: 0x000258C4
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			global::System.IFormattable formattable = value as global::System.IFormattable;
			if (formattable == null)
			{
				return global::System.Windows.DependencyProperty.UnsetValue;
			}
			if (!(parameter is string) && parameter != null)
			{
				return global::System.Windows.DependencyProperty.UnsetValue;
			}
			string format = parameter as string;
			return formattable.ToString(format, culture);
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x00027702 File Offset: 0x00025902
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return global::System.Windows.Data.Binding.DoNothing;
		}
	}
}
