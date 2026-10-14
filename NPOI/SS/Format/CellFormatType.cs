using System;

namespace NPOI.SS.Format
{
	// Token: 0x0200024F RID: 591
	public abstract class CellFormatType
	{
		// Token: 0x06000E6D RID: 3693
		public abstract bool IsSpecial(char ch);

		// Token: 0x06000E6E RID: 3694
		public abstract global::NPOI.SS.Format.CellFormatter Formatter(string pattern);

		// Token: 0x04000686 RID: 1670
		public static readonly global::NPOI.SS.Format.CellFormatType GENERAL = new global::NPOI.SS.Format.GeneralCellFormatType();

		// Token: 0x04000687 RID: 1671
		public static readonly global::NPOI.SS.Format.CellFormatType NUMBER = new global::NPOI.SS.Format.NumberCellFormatType();

		// Token: 0x04000688 RID: 1672
		public static readonly global::NPOI.SS.Format.CellFormatType DATE = new global::NPOI.SS.Format.DateCellFormatType();

		// Token: 0x04000689 RID: 1673
		public static readonly global::NPOI.SS.Format.CellFormatType ELAPSED = new global::NPOI.SS.Format.ElapsedCellFormatType();

		// Token: 0x0400068A RID: 1674
		public static readonly global::NPOI.SS.Format.CellFormatType TEXT = new global::NPOI.SS.Format.TextCellFormatType();
	}
}
