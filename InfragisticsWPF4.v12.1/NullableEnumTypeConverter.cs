using System;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics
{
	// Token: 0x020000DA RID: 218
	public class NullableEnumTypeConverter<T> : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x060007D9 RID: 2009 RVA: 0x0001B353 File Offset: 0x00019553
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string) || sourceType == typeof(T) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x0001B384 File Offset: 0x00019584
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			if (global::System.Enum.IsDefined(typeof(T), value))
			{
				return global::System.Enum.Parse(typeof(T), value.ToString(), true);
			}
			string text = value as string;
			if (text != null)
			{
				int num = -1;
				if (int.TryParse(text, out num))
				{
					return global::System.Enum.Parse(typeof(T), value.ToString(), true);
				}
			}
			return null;
		}
	}
}
