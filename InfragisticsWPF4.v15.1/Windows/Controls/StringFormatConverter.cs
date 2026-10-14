using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200020D RID: 525
	public sealed class StringFormatConverter : global::System.Windows.Data.IMultiValueConverter, global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600139C RID: 5020 RVA: 0x000454FC File Offset: 0x000436FC
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

		// Token: 0x0600139D RID: 5021 RVA: 0x00045564 File Offset: 0x00043764
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return new object[]
			{
				global::System.Windows.Data.Binding.DoNothing
			};
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x00045584 File Offset: 0x00043784
		object global::System.Windows.Data.IValueConverter.Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return this.Convert(new object[]
			{
				value
			}, targetType, parameter, culture);
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x000455A8 File Offset: 0x000437A8
		object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return this.ConvertBack(value, new global::System.Type[]
			{
				targetType
			}, parameter, culture);
		}
	}
}
