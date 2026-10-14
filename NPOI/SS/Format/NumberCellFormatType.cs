using System;

namespace NPOI.SS.Format
{
	// Token: 0x0200024B RID: 587
	internal class NumberCellFormatType : global::NPOI.SS.Format.CellFormatType
	{
		// Token: 0x06000E61 RID: 3681 RVA: 0x00029C8B File Offset: 0x00027E8B
		public override global::NPOI.SS.Format.CellFormatter Formatter(string pattern)
		{
			return new global::NPOI.SS.Format.CellNumberFormatter(pattern);
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override bool IsSpecial(char ch)
		{
			return false;
		}
	}
}
