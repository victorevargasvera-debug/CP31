using System;

namespace NPOI.HPSF
{
	// Token: 0x0200051A RID: 1306
	[global::System.Serializable]
	public class ReadingNotSupportedException : global::NPOI.HPSF.UnsupportedVariantTypeException
	{
		// Token: 0x060030EC RID: 12524 RVA: 0x00093ED8 File Offset: 0x000920D8
		public ReadingNotSupportedException(long variantType, object value) : base(variantType, value)
		{
		}
	}
}
