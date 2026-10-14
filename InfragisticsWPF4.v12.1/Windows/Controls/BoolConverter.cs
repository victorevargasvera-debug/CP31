using System;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020000EC RID: 236
	public class BoolConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000861 RID: 2145 RVA: 0x0001C71A File Offset: 0x0001A91A
		object global::System.Windows.Data.IValueConverter.Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value is bool && (bool)value)
			{
				return this.trueValue;
			}
			return this.falseValue;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x0001C739 File Offset: 0x0001A939
		object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (object.Equals(this.trueValue, value))
			{
				return global::Infragistics.KnownBoxes.TrueBox;
			}
			return global::Infragistics.KnownBoxes.FalseBox;
		}

		// Token: 0x04000395 RID: 917
		protected object trueValue = global::Infragistics.KnownBoxes.TrueBox;

		// Token: 0x04000396 RID: 918
		protected object falseValue = global::Infragistics.KnownBoxes.FalseBox;
	}
}
