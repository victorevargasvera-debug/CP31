using System;

namespace NPOI.SS.Format
{
	// Token: 0x0200024C RID: 588
	internal class DateCellFormatType : global::NPOI.SS.Format.CellFormatType
	{
		// Token: 0x06000E64 RID: 3684 RVA: 0x00029C93 File Offset: 0x00027E93
		public override bool IsSpecial(char ch)
		{
			return ch == '\'' || (ch <= '\u007f' && char.IsLetter(ch));
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x00029CA9 File Offset: 0x00027EA9
		public override global::NPOI.SS.Format.CellFormatter Formatter(string pattern)
		{
			return new global::NPOI.SS.Format.CellDateFormatter(pattern);
		}
	}
}
