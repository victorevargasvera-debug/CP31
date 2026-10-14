using System;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000290 RID: 656
	public class NullableDoubleConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x06001616 RID: 5654 RVA: 0x000541F5 File Offset: 0x000523F5
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return !(sourceType != typeof(string)) || typeof(double?).IsAssignableFrom(sourceType);
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x0005421C File Offset: 0x0005241C
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			if (value is double)
			{
				return (double?)value;
			}
			if (value != null)
			{
				string text = value.ToString();
				if (text != null)
				{
					return (!string.IsNullOrEmpty(text)) ? new double?(double.Parse(text, global::System.Globalization.CultureInfo.InvariantCulture)) : null;
				}
			}
			return null;
		}
	}
}
