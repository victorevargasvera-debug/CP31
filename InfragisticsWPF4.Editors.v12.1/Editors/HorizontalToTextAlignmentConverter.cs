using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000067 RID: 103
	public class HorizontalToTextAlignmentConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060005D0 RID: 1488 RVA: 0x000178EC File Offset: 0x00015AEC
		object global::System.Windows.Data.IValueConverter.Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value is global::System.Windows.HorizontalAlignment)
			{
				switch ((global::System.Windows.HorizontalAlignment)value)
				{
				case global::System.Windows.HorizontalAlignment.Center:
					return global::System.Windows.TextAlignment.Center;
				case global::System.Windows.HorizontalAlignment.Right:
					return global::System.Windows.TextAlignment.Right;
				}
			}
			return global::System.Windows.TextAlignment.Left;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00017930 File Offset: 0x00015B30
		object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value is global::System.Windows.TextAlignment)
			{
				switch ((global::System.Windows.TextAlignment)value)
				{
				case global::System.Windows.TextAlignment.Right:
					return global::System.Windows.HorizontalAlignment.Right;
				case global::System.Windows.TextAlignment.Center:
					return global::System.Windows.HorizontalAlignment.Center;
				}
			}
			return global::System.Windows.HorizontalAlignment.Left;
		}
	}
}
