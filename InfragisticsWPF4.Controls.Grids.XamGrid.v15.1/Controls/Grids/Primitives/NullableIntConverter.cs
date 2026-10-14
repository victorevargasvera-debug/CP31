using System;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000292 RID: 658
	public class NullableIntConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x0600161C RID: 5660 RVA: 0x00054304 File Offset: 0x00052504
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return !(sourceType != typeof(string)) || typeof(int?).IsAssignableFrom(sourceType);
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x0005432C File Offset: 0x0005252C
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			if (value is int)
			{
				return (int?)value;
			}
			if (value != null)
			{
				string text = value.ToString();
				if (text != null)
				{
					return (!string.IsNullOrEmpty(text)) ? new int?(int.Parse(text, global::System.Globalization.CultureInfo.InvariantCulture)) : null;
				}
			}
			return null;
		}
	}
}
