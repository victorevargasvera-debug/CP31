using System;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics
{
	// Token: 0x02000069 RID: 105
	public class TimeSpanConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x060005EC RID: 1516 RVA: 0x00016D70 File Offset: 0x00014F70
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00016D8E File Offset: 0x00014F8E
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return base.CanConvertTo(context, destinationType);
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00016D98 File Offset: 0x00014F98
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
				return global::System.TimeSpan.Zero;
			}
			global::System.TimeSpan timeSpan = global::System.TimeSpan.Parse(text2);
			return timeSpan;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00016DE0 File Offset: 0x00014FE0
		public override object ConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value, global::System.Type destinationType)
		{
			if (!(value is global::System.TimeSpan))
			{
				return base.ConvertTo(context, culture, value, destinationType);
			}
			global::System.TimeSpan t = (global::System.TimeSpan)value;
			if (t == global::System.TimeSpan.Zero)
			{
				return string.Empty;
			}
			return t.ToString();
		}
	}
}
