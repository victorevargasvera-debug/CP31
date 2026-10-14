using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x02000022 RID: 34
	public class ColorBlendConverter : global::Infragistics.ValueConverterBase
	{
		// Token: 0x06000188 RID: 392 RVA: 0x00007790 File Offset: 0x00005990
		public override object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			global::System.Windows.Media.Color? color = global::Infragistics.ColorUtilities.ColorFromObject(parameter);
			if (color == null && parameter != null)
			{
				return global::System.Windows.DependencyProperty.UnsetValue;
			}
			global::System.Windows.Media.Color? color2 = global::Infragistics.ColorUtilities.ColorFromObject(value);
			if (color2 == null)
			{
				return global::System.Windows.DependencyProperty.UnsetValue;
			}
			global::System.Windows.Media.Color color3 = (color != null) ? global::Infragistics.ColorUtilities.Blend(color.Value, color2.Value, this.BlendMode) : color2.Value;
			if (targetType == typeof(global::System.Windows.Media.Brush))
			{
				return new global::System.Windows.Media.SolidColorBrush
				{
					Color = color3
				};
			}
			return color3;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000781F File Offset: 0x00005A1F
		public override object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return global::System.Windows.DependencyProperty.UnsetValue;
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00007826 File Offset: 0x00005A26
		// (set) Token: 0x0600018B RID: 395 RVA: 0x0000782E File Offset: 0x00005A2E
		public global::Infragistics.ColorBlendMode BlendMode { get; set; }
	}
}
