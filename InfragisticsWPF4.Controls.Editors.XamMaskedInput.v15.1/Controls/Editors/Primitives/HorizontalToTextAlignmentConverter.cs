using System;
using System.Globalization;
using System.Windows;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x0200004D RID: 77
	public class HorizontalToTextAlignmentConverter : global::Infragistics.ValueConverterBase
	{
		// Token: 0x0600036E RID: 878 RVA: 0x00011FF4 File Offset: 0x000101F4
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

		// Token: 0x0600036F RID: 879 RVA: 0x00012038 File Offset: 0x00010238
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
