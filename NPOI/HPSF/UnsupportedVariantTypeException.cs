using System;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x02000521 RID: 1313
	[global::System.Serializable]
	public abstract class UnsupportedVariantTypeException : global::NPOI.HPSF.VariantTypeException
	{
		// Token: 0x0600316D RID: 12653 RVA: 0x00094C74 File Offset: 0x00092E74
		public UnsupportedVariantTypeException(long variantType, object value) : base(variantType, value, string.Concat(new string[]
		{
			"HPSF does not yet support the variant type ",
			variantType.ToString(),
			" (",
			global::NPOI.HPSF.Variant.GetVariantName(variantType),
			", ",
			global::NPOI.Util.HexDump.ToHex(variantType),
			"). If you want support for this variant type in one of the next POI releases please submit a request for enhancement (RFE) To <http://issues.apache.org/bugzilla/>! Thank you!"
		}))
		{
		}
	}
}
