using System;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics
{
	// Token: 0x020000F8 RID: 248
	public class NullableEnumTypeConverter<T> : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x060008D8 RID: 2264 RVA: 0x0001EF1B File Offset: 0x0001D11B
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string) || sourceType == typeof(T) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x0001EF4C File Offset: 0x0001D14C
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
