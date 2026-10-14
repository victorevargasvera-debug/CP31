using System;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics
{
	// Token: 0x02000065 RID: 101
	public class DateTimeConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x060005DC RID: 1500 RVA: 0x00016ADC File Offset: 0x00014CDC
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00016AFA File Offset: 0x00014CFA
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return base.CanConvertTo(context, destinationType);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00016B04 File Offset: 0x00014D04
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			string text = value as string;
			if (text == null)
			{
				return base.ConvertFrom(context, culture, value);
			}
			string text2 = text.Trim();
			if (text2.Length == 0)
			{
				return global::System.DateTime.MinValue;
			}
			culture = global::System.Globalization.CultureInfo.InvariantCulture;
			global::System.Globalization.DateTimeFormatInfo dateTimeFormatInfo = (global::System.Globalization.DateTimeFormatInfo)culture.GetFormat(typeof(global::System.Globalization.DateTimeFormatInfo));
			if (dateTimeFormatInfo != null)
			{
				return global::System.DateTime.Parse(text2, dateTimeFormatInfo);
			}
			return global::System.DateTime.Parse(text2, culture);
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00016B78 File Offset: 0x00014D78
		public override object ConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value, global::System.Type destinationType)
		{
			if (!(value is global::System.DateTime))
			{
				return base.ConvertTo(context, culture, value, destinationType);
			}
			global::System.DateTime d = (global::System.DateTime)value;
			if (d == global::System.DateTime.MinValue)
			{
				return string.Empty;
			}
			culture = global::System.Globalization.CultureInfo.InvariantCulture;
			if (d.TimeOfDay.TotalSeconds == 0.0)
			{
				return d.ToString("yyyy-MM-dd", culture);
			}
			return d.ToString(culture);
		}
	}
}
