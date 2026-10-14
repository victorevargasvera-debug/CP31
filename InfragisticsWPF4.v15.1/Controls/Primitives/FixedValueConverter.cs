using System;
using System.Globalization;
using System.Windows;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x02000046 RID: 70
	public class FixedValueConverter : global::Infragistics.ValueConverterBase
	{
		// Token: 0x060002BD RID: 701 RVA: 0x0000BAFE File Offset: 0x00009CFE
		public FixedValueConverter()
		{
			this.SourceValue = global::Infragistics.Controls.Primitives.FixedValueConverter.UnsetValue;
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060002BE RID: 702 RVA: 0x0000BB11 File Offset: 0x00009D11
		// (set) Token: 0x060002BF RID: 703 RVA: 0x0000BB19 File Offset: 0x00009D19
		public object SourceValue { get; set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000BB22 File Offset: 0x00009D22
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x0000BB2A File Offset: 0x00009D2A
		public object DestinationValue { get; set; }

		// Token: 0x060002C2 RID: 706 RVA: 0x0000BB33 File Offset: 0x00009D33
		private static object ConvertHelper(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture, object source, object destination)
		{
			if (destination == global::Infragistics.Controls.Primitives.FixedValueConverter.UnsetValue)
			{
				return global::System.Windows.DependencyProperty.UnsetValue;
			}
			if (source == global::Infragistics.Controls.Primitives.FixedValueConverter.UnsetValue || object.Equals(source, value))
			{
				return destination;
			}
			return global::System.Windows.DependencyProperty.UnsetValue;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000BB5F File Offset: 0x00009D5F
		public override object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return global::Infragistics.Controls.Primitives.FixedValueConverter.ConvertHelper(value, targetType, parameter, culture, this.SourceValue, this.DestinationValue);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000BB77 File Offset: 0x00009D77
		public override object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return global::Infragistics.Controls.Primitives.FixedValueConverter.ConvertHelper(value, targetType, parameter, culture, this.DestinationValue, this.SourceValue);
		}

		// Token: 0x040000DF RID: 223
		private static readonly object UnsetValue = new object();
	}
}
