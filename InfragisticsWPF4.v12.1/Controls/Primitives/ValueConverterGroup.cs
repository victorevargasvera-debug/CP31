using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x02000087 RID: 135
	[global::System.Windows.Markup.ContentProperty("Converters")]
	public class ValueConverterGroup : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000549 RID: 1353 RVA: 0x000148A5 File Offset: 0x00012AA5
		public ValueConverterGroup()
		{
			this._converters = new global::System.Collections.Generic.List<global::System.Windows.Data.IValueConverter>();
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x000148B8 File Offset: 0x00012AB8
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public global::System.Collections.Generic.List<global::System.Windows.Data.IValueConverter> Converters
		{
			get
			{
				return this._converters;
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x000148C0 File Offset: 0x00012AC0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			object obj = global::System.Windows.DependencyProperty.UnsetValue;
			foreach (global::System.Windows.Data.IValueConverter valueConverter in this._converters)
			{
				obj = valueConverter.Convert(value, targetType, parameter, culture);
				if (obj != global::System.Windows.DependencyProperty.UnsetValue)
				{
					break;
				}
			}
			return obj;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00014928 File Offset: 0x00012B28
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			object obj = global::System.Windows.DependencyProperty.UnsetValue;
			foreach (global::System.Windows.Data.IValueConverter valueConverter in this._converters)
			{
				obj = valueConverter.ConvertBack(value, targetType, parameter, culture);
				if (obj != global::System.Windows.DependencyProperty.UnsetValue)
				{
					break;
				}
			}
			return obj;
		}

		// Token: 0x040001F3 RID: 499
		private global::System.Collections.Generic.List<global::System.Windows.Data.IValueConverter> _converters;
	}
}
