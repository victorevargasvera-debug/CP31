using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x020000A0 RID: 160
	[global::System.Windows.Markup.ContentProperty("Converters")]
	public class ValueConverterGroup : global::Infragistics.ValueConverterBase
	{
		// Token: 0x06000626 RID: 1574 RVA: 0x00017F1A File Offset: 0x0001611A
		public ValueConverterGroup()
		{
			this._converters = new global::System.Collections.Generic.List<global::System.Windows.Data.IValueConverter>();
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x00017F2D File Offset: 0x0001612D
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public global::System.Collections.Generic.List<global::System.Windows.Data.IValueConverter> Converters
		{
			get
			{
				return this._converters;
			}
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00017F38 File Offset: 0x00016138
		public override object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
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

		// Token: 0x06000629 RID: 1577 RVA: 0x00017FA0 File Offset: 0x000161A0
		public override object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
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

		// Token: 0x04000275 RID: 629
		private global::System.Collections.Generic.List<global::System.Windows.Data.IValueConverter> _converters;
	}
}
