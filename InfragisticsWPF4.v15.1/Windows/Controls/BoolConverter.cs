using System;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200010A RID: 266
	public class BoolConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000960 RID: 2400 RVA: 0x000202E2 File Offset: 0x0001E4E2
		object global::System.Windows.Data.IValueConverter.Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value is bool && (bool)value)
			{
				return this.trueValue;
			}
			return this.falseValue;
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00020301 File Offset: 0x0001E501
		object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (object.Equals(this.trueValue, value))
			{
				return global::Infragistics.KnownBoxes.TrueBox;
			}
			return global::Infragistics.KnownBoxes.FalseBox;
		}

		// Token: 0x04000448 RID: 1096
		protected object trueValue = global::Infragistics.KnownBoxes.TrueBox;

		// Token: 0x04000449 RID: 1097
		protected object falseValue = global::Infragistics.KnownBoxes.FalseBox;
	}
}
