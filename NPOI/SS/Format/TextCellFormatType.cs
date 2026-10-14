using System;

namespace NPOI.SS.Format
{
	// Token: 0x0200024E RID: 590
	internal class TextCellFormatType : global::NPOI.SS.Format.CellFormatType
	{
		// Token: 0x06000E6A RID: 3690 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override bool IsSpecial(char ch)
		{
			return false;
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00029CB9 File Offset: 0x00027EB9
		public override global::NPOI.SS.Format.CellFormatter Formatter(string pattern)
		{
			return new global::NPOI.SS.Format.CellTextFormatter(pattern);
		}
	}
}
