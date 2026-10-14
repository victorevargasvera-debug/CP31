using System;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x0200004E RID: 78
	public class MaskCharConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x06000371 RID: 881 RVA: 0x00012082 File Offset: 0x00010282
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return typeof(string) == sourceType;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00012094 File Offset: 0x00010294
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return typeof(char) == destinationType;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x000120A8 File Offset: 0x000102A8
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			string value2 = (string)value;
			if (!string.IsNullOrEmpty(value2))
			{
				return global::System.Convert.ToChar(value2);
			}
			return '\0';
		}

		// Token: 0x06000374 RID: 884 RVA: 0x000120D8 File Offset: 0x000102D8
		public override object ConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value, global::System.Type destinationType)
		{
			char c = (char)value;
			if (c != '\0')
			{
				return global::System.Convert.ToString(c);
			}
			return string.Empty;
		}
	}
}
