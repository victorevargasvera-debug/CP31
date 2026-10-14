using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200006D RID: 109
	public class HorizontalToTextAlignmentConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000628 RID: 1576 RVA: 0x00018FA8 File Offset: 0x000171A8
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

		// Token: 0x06000629 RID: 1577 RVA: 0x00018FEC File Offset: 0x000171EC
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
