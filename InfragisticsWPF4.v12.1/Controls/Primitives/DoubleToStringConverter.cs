using System;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x020000B9 RID: 185
	public class DoubleToStringConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060006F6 RID: 1782 RVA: 0x00018A04 File Offset: 0x00016C04
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value is double)
			{
				return value.ToString();
			}
			if (!(value is double?))
			{
				return null;
			}
			double? num = value as double?;
			if (num != null)
			{
				return num.Value.ToString();
			}
			return null;
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00018A50 File Offset: 0x00016C50
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			double num;
			if (double.TryParse(value as string, out num))
			{
				return num;
			}
			return null;
		}
	}
}
