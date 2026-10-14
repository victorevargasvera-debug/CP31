using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000188 RID: 392
	public sealed class FormattableToStringConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000D1B RID: 3355 RVA: 0x0002B84C File Offset: 0x00029A4C
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

		// Token: 0x06000D1C RID: 3356 RVA: 0x0002B88A File Offset: 0x00029A8A
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return global::System.Windows.Data.Binding.DoNothing;
		}
	}
}
