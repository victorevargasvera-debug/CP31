using System;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020000F1 RID: 241
	public class NullToParameterConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600086D RID: 2157 RVA: 0x0001C7EF File Offset: 0x0001A9EF
		private static bool IsNullOrEmptyString(object value)
		{
			return value == null || (value is string && 0 == ((string)value).Length);
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x0001C80E File Offset: 0x0001AA0E
		object global::System.Windows.Data.IValueConverter.Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (!global::Infragistics.Windows.Controls.NullToParameterConverter.IsNullOrEmptyString(value))
			{
				return value;
			}
			return parameter;
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0001C81B File Offset: 0x0001AA1B
		object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return global::System.Windows.Data.Binding.DoNothing;
		}
	}
}
