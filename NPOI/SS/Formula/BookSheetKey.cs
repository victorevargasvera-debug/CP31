using System;

namespace NPOI.SS.Formula
{
	// Token: 0x020000CD RID: 205
	public class BookSheetKey
	{
		// Token: 0x060006F3 RID: 1779 RVA: 0x00011F10 File Offset: 0x00010110
		public BookSheetKey(int bookIndex, int sheetIndex)
		{
			this._bookIndex = bookIndex;
			this._sheetIndex = sheetIndex;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00011F26 File Offset: 0x00010126
		public override int GetHashCode()
		{
			return this._bookIndex * 17 + this._sheetIndex;
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00011F38 File Offset: 0x00010138
		public override bool Equals(object obj)
		{
			global::NPOI.SS.Formula.BookSheetKey bookSheetKey = (global::NPOI.SS.Formula.BookSheetKey)obj;
			return this._bookIndex == bookSheetKey._bookIndex && this._sheetIndex == bookSheetKey._sheetIndex;
		}

		// Token: 0x040003CC RID: 972
		private int _bookIndex;

		// Token: 0x040003CD RID: 973
		private int _sheetIndex;
	}
}
