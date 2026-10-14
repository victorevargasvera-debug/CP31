using System;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x0200004F RID: 79
	public class MaskCharConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x0600036C RID: 876 RVA: 0x0001214A File Offset: 0x0001034A
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return typeof(string) == sourceType;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0001215C File Offset: 0x0001035C
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return typeof(char) == destinationType;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00012170 File Offset: 0x00010370
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			string value2 = (string)value;
			if (!string.IsNullOrEmpty(value2))
			{
				return global::System.Convert.ToChar(value2);
			}
			return '\0';
		}

		// Token: 0x0600036F RID: 879 RVA: 0x000121A0 File Offset: 0x000103A0
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
