using System;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200028F RID: 655
	public class IComparableTypeConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x06001613 RID: 5651 RVA: 0x000541D3 File Offset: 0x000523D3
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType.IsAssignableFrom(typeof(global::System.IComparable));
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x000541E5 File Offset: 0x000523E5
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			return value as global::System.IComparable;
		}
	}
}
