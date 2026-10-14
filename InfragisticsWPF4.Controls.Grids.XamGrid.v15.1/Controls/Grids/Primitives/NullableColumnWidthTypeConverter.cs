using System;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200028E RID: 654
	public class NullableColumnWidthTypeConverter : global::Infragistics.Controls.Grids.Primitives.ColumnWidthTypeConverter
	{
		// Token: 0x06001611 RID: 5649 RVA: 0x000541A4 File Offset: 0x000523A4
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			object obj = base.ConvertFrom(context, culture, value);
			if (obj != null)
			{
				return (global::Infragistics.Controls.Grids.ColumnWidth?)obj;
			}
			return null;
		}
	}
}
