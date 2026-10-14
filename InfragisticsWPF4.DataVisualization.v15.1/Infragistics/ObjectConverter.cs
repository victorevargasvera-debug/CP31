using System;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics
{
	// Token: 0x02000066 RID: 102
	public class ObjectConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x060005E1 RID: 1505 RVA: 0x00016BF2 File Offset: 0x00014DF2
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00016C10 File Offset: 0x00014E10
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return base.CanConvertTo(context, destinationType);
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00016C1C File Offset: 0x00014E1C
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			if (value == null)
			{
				return string.Empty;
			}
			string text = value as string;
			if (text != null)
			{
				return text;
			}
			return base.ConvertFrom(context, culture, value);
		}
	}
}
