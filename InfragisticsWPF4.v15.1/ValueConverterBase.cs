using System;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics
{
	// Token: 0x02000021 RID: 33
	public abstract class ValueConverterBase : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000185 RID: 389
		public abstract object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture);

		// Token: 0x06000186 RID: 390
		public abstract object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture);
	}
}
