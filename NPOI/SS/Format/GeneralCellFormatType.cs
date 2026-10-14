using System;

namespace NPOI.SS.Format
{
	// Token: 0x0200024A RID: 586
	internal class GeneralCellFormatType : global::NPOI.SS.Format.CellFormatType
	{
		// Token: 0x06000E5E RID: 3678 RVA: 0x00029C7C File Offset: 0x00027E7C
		public override global::NPOI.SS.Format.CellFormatter Formatter(string pattern)
		{
			return new global::NPOI.SS.Format.CellGeneralFormatter();
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override bool IsSpecial(char ch)
		{
			return false;
		}
	}
}
