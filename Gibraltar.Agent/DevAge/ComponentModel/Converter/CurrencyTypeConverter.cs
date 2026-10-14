using System;
using System.Globalization;

namespace DevAge.ComponentModel.Converter
{
	// Token: 0x0200029D RID: 669
	internal class CurrencyTypeConverter : global::DevAge.ComponentModel.Converter.NumberTypeConverter
	{
		// Token: 0x0600219D RID: 8605 RVA: 0x00077B9C File Offset: 0x00075D9C
		public CurrencyTypeConverter(global::System.Type p_BaseType) : base(p_BaseType)
		{
			base.Format = "C";
			base.NumberStyles = global::System.Globalization.NumberStyles.Currency;
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x00077BBC File Offset: 0x00075DBC
		public CurrencyTypeConverter(global::System.Type p_BaseType, string p_Format) : this(p_BaseType)
		{
			base.Format = p_Format;
		}
	}
}
