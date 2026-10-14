using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020001DF RID: 479
	public sealed class StringFormatConverter : global::System.Windows.Data.IMultiValueConverter, global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060011C8 RID: 4552 RVA: 0x0003FC54 File Offset: 0x0003DE54
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (values == null)
			{
				return global::System.Windows.DependencyProperty.UnsetValue;
			}
			if (!(parameter is string))
			{
				if (values.Length == 1 || !(values[0] is string))
				{
					return global::System.Windows.DependencyProperty.UnsetValue;
				}
				parameter = values[0];
				object[] array = new object[values.Length - 1];
				global::System.Array.Copy(values, 1, array, 0, values.Length - 1);
				values = array;
			}
			string format = (string)parameter;
			return string.Format(culture, format, values);
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x0003FCBC File Offset: 0x0003DEBC
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return new object[]
			{
				global::System.Windows.Data.Binding.DoNothing
			};
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x0003FCDC File Offset: 0x0003DEDC
		object global::System.Windows.Data.IValueConverter.Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return this.Convert(new object[]
			{
				value
			}, targetType, parameter, culture);
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x0003FD00 File Offset: 0x0003DF00
		object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return this.ConvertBack(value, new global::System.Type[]
			{
				targetType
			}, parameter, culture);
		}
	}
}
