using System;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x020000BF RID: 191
	public class InverseBooleanConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000722 RID: 1826 RVA: 0x00018FC0 File Offset: 0x000171C0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value is bool)
			{
				return !(bool)value;
			}
			if (!(value is bool?))
			{
				throw new global::System.NotSupportedException("Trying to convert a non boolean value with the InverseBooleanConverter");
			}
			bool? flag = (bool?)value;
			if (flag != null)
			{
				return !flag.Value;
			}
			if (typeof(bool?).Equals(targetType))
			{
				return null;
			}
			return true;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00019031 File Offset: 0x00017231
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return this.Convert(value, targetType, parameter, culture);
		}
	}
}
