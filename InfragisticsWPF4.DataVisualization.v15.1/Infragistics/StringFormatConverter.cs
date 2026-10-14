using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Data;

namespace Infragistics
{
	// Token: 0x02000068 RID: 104
	public class StringFormatConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060005E8 RID: 1512 RVA: 0x00016CFC File Offset: 0x00014EFC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value == null)
			{
				return string.Empty;
			}
			string text = parameter as string;
			string format;
			if (text == null)
			{
				format = "{0}";
			}
			else if (global::System.Text.RegularExpressions.Regex.IsMatch(text, "\\{.+\\}"))
			{
				format = text;
			}
			else
			{
				format = "{0:" + text + "}";
			}
			return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, new object[]
			{
				value
			});
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00016D5D File Offset: 0x00014F5D
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return value;
		}
	}
}
