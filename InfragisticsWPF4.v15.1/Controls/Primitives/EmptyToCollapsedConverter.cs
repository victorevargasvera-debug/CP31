using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x02000043 RID: 67
	public class EmptyToCollapsedConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060002AC RID: 684 RVA: 0x0000B6A7 File Offset: 0x000098A7
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value == null || (value is string && string.IsNullOrEmpty(value as string)))
			{
				return global::Infragistics.KnownBoxes.VisibilityCollapsedBox;
			}
			return global::Infragistics.KnownBoxes.VisibilityVisibleBox;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000B6CC File Offset: 0x000098CC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return global::System.Windows.DependencyProperty.UnsetValue;
		}
	}
}
