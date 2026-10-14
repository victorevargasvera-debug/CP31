using System;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200010E RID: 270
	public class NullToFalseConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000969 RID: 2409 RVA: 0x00020382 File Offset: 0x0001E582
		object global::System.Windows.Data.IValueConverter.Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value == null || (value is string && ((string)value).Length <= 0))
			{
				return global::Infragistics.KnownBoxes.FalseBox;
			}
			return global::Infragistics.KnownBoxes.TrueBox;
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x000203A8 File Offset: 0x0001E5A8
		object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return global::System.Windows.Data.Binding.DoNothing;
		}
	}
}
