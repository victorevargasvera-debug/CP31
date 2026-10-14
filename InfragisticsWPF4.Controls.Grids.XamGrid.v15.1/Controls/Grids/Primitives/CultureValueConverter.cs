using System;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000159 RID: 345
	public class CultureValueConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000B24 RID: 2852 RVA: 0x00029EEC File Offset: 0x000280EC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value is global::System.IConvertible)
			{
				return global::System.Convert.ChangeType(value, targetType, global::System.Globalization.CultureInfo.CurrentCulture);
			}
			return value;
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00029F04 File Offset: 0x00028104
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return value;
		}
	}
}
