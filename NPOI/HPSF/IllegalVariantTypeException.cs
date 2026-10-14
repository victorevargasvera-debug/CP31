using System;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x0200050E RID: 1294
	[global::System.Serializable]
	public class IllegalVariantTypeException : global::NPOI.HPSF.VariantTypeException
	{
		// Token: 0x06003076 RID: 12406 RVA: 0x00092583 File Offset: 0x00090783
		public IllegalVariantTypeException(long variantType, object value, string msg) : base(variantType, value, msg)
		{
		}

		// Token: 0x06003077 RID: 12407 RVA: 0x00092590 File Offset: 0x00090790
		public IllegalVariantTypeException(long variantType, object value) : this(variantType, value, string.Concat(new string[]
		{
			"The variant type ",
			variantType.ToString(),
			" (",
			global::NPOI.HPSF.Variant.GetVariantName(variantType),
			", ",
			global::NPOI.Util.HexDump.ToHex(variantType),
			") is illegal in this context."
		}))
		{
		}
	}
}
