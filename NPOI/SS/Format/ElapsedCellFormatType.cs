using System;

namespace NPOI.SS.Format
{
	// Token: 0x0200024D RID: 589
	internal class ElapsedCellFormatType : global::NPOI.SS.Format.CellFormatType
	{
		// Token: 0x06000E67 RID: 3687 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override bool IsSpecial(char ch)
		{
			return false;
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x00029CB1 File Offset: 0x00027EB1
		public override global::NPOI.SS.Format.CellFormatter Formatter(string pattern)
		{
			return new global::NPOI.SS.Format.CellElapsedFormatter(pattern);
		}
	}
}
