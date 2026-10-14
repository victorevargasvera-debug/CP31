using System;

namespace NPOI.HPSF
{
	// Token: 0x02000526 RID: 1318
	[global::System.Serializable]
	public class WritingNotSupportedException : global::NPOI.HPSF.UnsupportedVariantTypeException
	{
		// Token: 0x0600318B RID: 12683 RVA: 0x00093ED8 File Offset: 0x000920D8
		public WritingNotSupportedException(long variantType, object value) : base(variantType, value)
		{
		}
	}
}
