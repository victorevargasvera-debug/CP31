using System;
using System.ComponentModel;
using System.Globalization;

namespace System.Windows.Controls
{
	// Token: 0x0200000E RID: 14
	public class NullableConverter<T> : global::System.ComponentModel.TypeConverter where T : struct
	{
		// Token: 0x06000100 RID: 256 RVA: 0x0000592D File Offset: 0x00003B2D
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(T) || sourceType == typeof(string);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000594E File Offset: 0x00003B4E
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return destinationType == typeof(T);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00005960 File Offset: 0x00003B60
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			string text = value as string;
			if (value is T)
			{
				return new T?((T)((object)value));
			}
			if (string.IsNullOrEmpty(text) || string.Equals(text, "Auto", global::System.StringComparison.OrdinalIgnoreCase))
			{
				return null;
			}
			return new T?((T)((object)global::System.Convert.ChangeType(value, typeof(T), culture)));
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000059D2 File Offset: 0x00003BD2
		public override object ConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value, global::System.Type destinationType)
		{
			if (value == null)
			{
				return string.Empty;
			}
			if (destinationType == typeof(string))
			{
				return value.ToString();
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}
	}
}
