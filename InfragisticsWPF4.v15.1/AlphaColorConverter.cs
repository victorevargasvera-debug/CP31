using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x02000024 RID: 36
	public class AlphaColorConverter : global::Infragistics.ValueConverterBase
	{
		// Token: 0x06000190 RID: 400 RVA: 0x000078CC File Offset: 0x00005ACC
		public override object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			global::System.Windows.Media.Color? color = global::Infragistics.ColorUtilities.ColorFromObject(value);
			if (color == null)
			{
				return global::System.Windows.DependencyProperty.UnsetValue;
			}
			global::System.Windows.Media.Color color2 = global::System.Windows.Media.Color.FromArgb((byte)global::Infragistics.CoreUtilities.Clamp((double)color.Value.A * this.Opacity, 0.0, 255.0), color.Value.R, color.Value.G, color.Value.B);
			if (targetType == typeof(global::System.Windows.Media.Brush))
			{
				return new global::System.Windows.Media.SolidColorBrush
				{
					Color = color2
				};
			}
			return color2;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000797B File Offset: 0x00005B7B
		public override object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return global::System.Windows.DependencyProperty.UnsetValue;
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00007982 File Offset: 0x00005B82
		// (set) Token: 0x06000193 RID: 403 RVA: 0x0000798A File Offset: 0x00005B8A
		public double Opacity { get; set; }
	}
}
