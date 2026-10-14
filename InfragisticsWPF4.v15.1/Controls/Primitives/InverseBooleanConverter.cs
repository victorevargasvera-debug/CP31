using System;
using System.Globalization;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x020000DC RID: 220
	public class InverseBooleanConverter : global::Infragistics.ValueConverterBase
	{
		// Token: 0x06000815 RID: 2069 RVA: 0x0001C818 File Offset: 0x0001AA18
		public override object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
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

		// Token: 0x06000816 RID: 2070 RVA: 0x0001C889 File Offset: 0x0001AA89
		public override object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return this.Convert(value, targetType, parameter, culture);
		}
	}
}
