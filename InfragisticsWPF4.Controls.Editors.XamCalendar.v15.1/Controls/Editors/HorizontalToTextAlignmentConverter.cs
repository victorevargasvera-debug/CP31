using System;
using System.Globalization;
using System.Windows;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200004D RID: 77
	public class HorizontalToTextAlignmentConverter : global::Infragistics.ValueConverterBase
	{
		// Token: 0x0600032B RID: 811 RVA: 0x0000F0C4 File Offset: 0x0000D2C4
		public override object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
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

		// Token: 0x0600032C RID: 812 RVA: 0x0000F108 File Offset: 0x0000D308
		public override object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
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
