using System;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200010F RID: 271
	public class NullToParameterConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600096C RID: 2412 RVA: 0x000203B7 File Offset: 0x0001E5B7
		private static bool IsNullOrEmptyString(object value)
		{
			return value == null || (value is string && 0 == ((string)value).Length);
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x000203D6 File Offset: 0x0001E5D6
		object global::System.Windows.Data.IValueConverter.Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (!global::Infragistics.Windows.Controls.NullToParameterConverter.IsNullOrEmptyString(value))
			{
				return value;
			}
			return parameter;
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x000203E3 File Offset: 0x0001E5E3
		object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return global::System.Windows.Data.Binding.DoNothing;
		}
	}
}
