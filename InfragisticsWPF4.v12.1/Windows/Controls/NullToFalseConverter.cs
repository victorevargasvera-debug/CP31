using System;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020000F0 RID: 240
	public class NullToFalseConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600086A RID: 2154 RVA: 0x0001C7BA File Offset: 0x0001A9BA
		object global::System.Windows.Data.IValueConverter.Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value == null || (value is string && ((string)value).Length <= 0))
			{
				return global::Infragistics.KnownBoxes.FalseBox;
			}
			return global::Infragistics.KnownBoxes.TrueBox;
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x0001C7E0 File Offset: 0x0001A9E0
		object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return global::System.Windows.Data.Binding.DoNothing;
		}
	}
}
