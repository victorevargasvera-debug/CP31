using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x02000023 RID: 35
	public class CalculatedForegroundConverter : global::Infragistics.ValueConverterBase
	{
		// Token: 0x0600018D RID: 397 RVA: 0x00007840 File Offset: 0x00005A40
		public override object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			global::System.Windows.Media.Color? color = global::Infragistics.ColorUtilities.ColorFromObject(value);
			if (color == null)
			{
				return global::System.Windows.DependencyProperty.UnsetValue;
			}
			global::System.Windows.Media.Color color2 = global::Infragistics.ColorUtilities.CalculateForeground(color.Value);
			if (!(targetType == typeof(global::System.Windows.Media.Brush)))
			{
				return color2;
			}
			if (color2 == global::System.Windows.Media.Colors.White)
			{
				return global::System.Windows.Media.Brushes.White;
			}
			if (color2 == global::System.Windows.Media.Colors.Black)
			{
				return global::System.Windows.Media.Brushes.Black;
			}
			return new global::System.Windows.Media.SolidColorBrush
			{
				Color = color2
			};
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000078BD File Offset: 0x00005ABD
		public override object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return global::System.Windows.DependencyProperty.UnsetValue;
		}
	}
}
