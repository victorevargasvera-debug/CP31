using System;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000291 RID: 657
	public class NullableFloatConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x06001619 RID: 5657 RVA: 0x0005427C File Offset: 0x0005247C
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return !(sourceType != typeof(string)) || typeof(float?).IsAssignableFrom(sourceType);
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x000542A4 File Offset: 0x000524A4
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			if (value is double)
			{
				return (float?)value;
			}
			if (value != null)
			{
				string text = value.ToString();
				if (text != null)
				{
					return (!string.IsNullOrEmpty(text)) ? new float?(float.Parse(text, global::System.Globalization.CultureInfo.InvariantCulture)) : null;
				}
			}
			return null;
		}
	}
}
