using System;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000294 RID: 660
	public class TypeTypeConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x06001624 RID: 5668 RVA: 0x00054480 File Offset: 0x00052680
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string);
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x00054494 File Offset: 0x00052694
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			global::System.Type type = global::System.Type.GetType((string)value);
			if (type == null)
			{
				throw new global::Infragistics.Controls.Grids.TypeResolutionException();
			}
			return type;
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x000544BD File Offset: 0x000526BD
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return false;
		}
	}
}
