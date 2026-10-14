using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001F6 RID: 502
	public class TextAlignmentToHorizontalAlignmentConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06001F35 RID: 7989 RVA: 0x0008869C File Offset: 0x0008689C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (targetType == null || !typeof(global::System.Windows.HorizontalAlignment).IsAssignableFrom(targetType))
			{
				return global::System.Windows.DependencyProperty.UnsetValue;
			}
			if (!(value is global::System.Windows.TextAlignment))
			{
				return global::System.Windows.DependencyProperty.UnsetValue;
			}
			switch ((global::System.Windows.TextAlignment)value)
			{
			case global::System.Windows.TextAlignment.Left:
				return global::System.Windows.HorizontalAlignment.Left;
			case global::System.Windows.TextAlignment.Right:
				return global::System.Windows.HorizontalAlignment.Right;
			case global::System.Windows.TextAlignment.Center:
				return global::System.Windows.HorizontalAlignment.Center;
			case global::System.Windows.TextAlignment.Justify:
				return global::System.Windows.HorizontalAlignment.Stretch;
			default:
				return global::System.Windows.HorizontalAlignment.Left;
			}
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x0008871B File Offset: 0x0008691B
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return global::System.Windows.Data.Binding.DoNothing;
		}
	}
}
