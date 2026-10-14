using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Microsoft.Windows.Controls
{
	// Token: 0x0200002F RID: 47
	[global::System.Windows.Localizability(global::System.Windows.LocalizationCategory.NeverLocalize)]
	internal sealed class DataGridHeadersVisibilityToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000280 RID: 640 RVA: 0x00009AF4 File Offset: 0x00007CF4
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			bool flag = false;
			if (value is global::Microsoft.Windows.Controls.DataGridHeadersVisibility && parameter is global::Microsoft.Windows.Controls.DataGridHeadersVisibility)
			{
				global::Microsoft.Windows.Controls.DataGridHeadersVisibility dataGridHeadersVisibility = (global::Microsoft.Windows.Controls.DataGridHeadersVisibility)value;
				global::Microsoft.Windows.Controls.DataGridHeadersVisibility dataGridHeadersVisibility2 = (global::Microsoft.Windows.Controls.DataGridHeadersVisibility)parameter;
				switch (dataGridHeadersVisibility)
				{
				case global::Microsoft.Windows.Controls.DataGridHeadersVisibility.Column:
					flag = (dataGridHeadersVisibility2 == global::Microsoft.Windows.Controls.DataGridHeadersVisibility.Column || dataGridHeadersVisibility2 == global::Microsoft.Windows.Controls.DataGridHeadersVisibility.None);
					break;
				case global::Microsoft.Windows.Controls.DataGridHeadersVisibility.Row:
					flag = (dataGridHeadersVisibility2 == global::Microsoft.Windows.Controls.DataGridHeadersVisibility.Row || dataGridHeadersVisibility2 == global::Microsoft.Windows.Controls.DataGridHeadersVisibility.None);
					break;
				case global::Microsoft.Windows.Controls.DataGridHeadersVisibility.All:
					flag = true;
					break;
				}
			}
			if (targetType == typeof(global::System.Windows.Visibility))
			{
				return flag ? global::System.Windows.Visibility.Visible : global::System.Windows.Visibility.Collapsed;
			}
			return global::System.Windows.DependencyProperty.UnsetValue;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00009B76 File Offset: 0x00007D76
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			throw new global::System.NotImplementedException();
		}
	}
}
