using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x02000034 RID: 52
	public class FixedValueConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000232 RID: 562 RVA: 0x0000A137 File Offset: 0x00008337
		public FixedValueConverter()
		{
			this.SourceValue = global::Infragistics.Controls.Primitives.FixedValueConverter.UnsetValue;
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0000A14A File Offset: 0x0000834A
		// (set) Token: 0x06000234 RID: 564 RVA: 0x0000A152 File Offset: 0x00008352
		public object SourceValue { get; set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000235 RID: 565 RVA: 0x0000A15B File Offset: 0x0000835B
		// (set) Token: 0x06000236 RID: 566 RVA: 0x0000A163 File Offset: 0x00008363
		public object DestinationValue { get; set; }

		// Token: 0x06000237 RID: 567 RVA: 0x0000A16C File Offset: 0x0000836C
		private static object ConvertHelper(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture, object source, object destination)
		{
			if (destination == global::Infragistics.Controls.Primitives.FixedValueConverter.UnsetValue)
			{
				return global::System.Windows.DependencyProperty.UnsetValue;
			}
			if (source == global::Infragistics.Controls.Primitives.FixedValueConverter.UnsetValue)
			{
				return destination;
			}
			if (object.Equals(source, value))
			{
				return destination;
			}
			return global::System.Windows.DependencyProperty.UnsetValue;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000A19B File Offset: 0x0000839B
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return global::Infragistics.Controls.Primitives.FixedValueConverter.ConvertHelper(value, targetType, parameter, culture, this.SourceValue, this.DestinationValue);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000A1B3 File Offset: 0x000083B3
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return global::Infragistics.Controls.Primitives.FixedValueConverter.ConvertHelper(value, targetType, parameter, culture, this.DestinationValue, this.SourceValue);
		}

		// Token: 0x04000085 RID: 133
		private static readonly object UnsetValue = new object();
	}
}
