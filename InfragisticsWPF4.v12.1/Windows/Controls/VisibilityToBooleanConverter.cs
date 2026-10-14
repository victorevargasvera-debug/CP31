using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020000F3 RID: 243
	public class VisibilityToBooleanConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000876 RID: 2166 RVA: 0x0001C8A0 File Offset: 0x0001AAA0
		object global::System.Windows.Data.IValueConverter.Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			global::System.Windows.Visibility? visibility = new global::System.Windows.Visibility?((global::System.Windows.Visibility)value);
			if (visibility != null && visibility.Value == global::System.Windows.Visibility.Visible)
			{
				return global::Infragistics.KnownBoxes.TrueBox;
			}
			return global::Infragistics.KnownBoxes.FalseBox;
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x0001C8D8 File Offset: 0x0001AAD8
		object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			bool? flag = new bool?((bool)value);
			if (flag != null && flag.Value)
			{
				return global::Infragistics.KnownBoxes.VisibilityVisibleBox;
			}
			return global::Infragistics.KnownBoxes.VisibilityCollapsedBox;
		}
	}
}
