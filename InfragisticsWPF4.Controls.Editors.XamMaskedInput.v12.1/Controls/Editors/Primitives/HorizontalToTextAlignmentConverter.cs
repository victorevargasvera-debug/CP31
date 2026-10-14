using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x0200004E RID: 78
	public class HorizontalToTextAlignmentConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000369 RID: 873 RVA: 0x000120BC File Offset: 0x000102BC
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

		// Token: 0x0600036A RID: 874 RVA: 0x00012100 File Offset: 0x00010300
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
