using System;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x020000D5 RID: 213
	public class DoubleToStringConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060007E1 RID: 2017 RVA: 0x0001C1AC File Offset: 0x0001A3AC
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

		// Token: 0x060007E2 RID: 2018 RVA: 0x0001C1F8 File Offset: 0x0001A3F8
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
