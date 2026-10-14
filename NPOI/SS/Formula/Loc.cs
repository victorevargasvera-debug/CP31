using System;
using NPOI.Util;

namespace NPOI.SS.Formula
{
	// Token: 0x020000D9 RID: 217
	public class Loc
	{
		// Token: 0x0600074E RID: 1870 RVA: 0x00013506 File Offset: 0x00011706
		public Loc(int bookIndex, int sheetIndex, int rowIndex, int columnIndex)
		{
			this._bookSheetColumn = global::NPOI.SS.Formula.Loc.ToBookSheetColumn(bookIndex, sheetIndex, columnIndex);
			this._rowIndex = rowIndex;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00013524 File Offset: 0x00011724
		public static long ToBookSheetColumn(int bookIndex, int sheetIndex, int columnIndex)
		{
			return (((long)bookIndex & 65535L) << 48) + (((long)sheetIndex & 65535L) << 32) + ((long)columnIndex & 65535L);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00013549 File Offset: 0x00011749
		public Loc(int bookSheetColumn, int rowIndex)
		{
			this._bookSheetColumn = (long)bookSheetColumn;
			this._rowIndex = rowIndex;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00013560 File Offset: 0x00011760
		public override int GetHashCode()
		{
			return (int)(this._bookSheetColumn ^ global::NPOI.Util.Operator.UnsignedRightShift(this._bookSheetColumn, 32)) + 17 * this._rowIndex;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00013584 File Offset: 0x00011784
		public override bool Equals(object obj)
		{
			global::NPOI.SS.Formula.Loc loc = (global::NPOI.SS.Formula.Loc)obj;
			return this._bookSheetColumn == loc._bookSheetColumn && this._rowIndex == loc._rowIndex;
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x000135B6 File Offset: 0x000117B6
		public int RowIndex
		{
			get
			{
				return this._rowIndex;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x000135BE File Offset: 0x000117BE
		public int ColumnIndex
		{
			get
			{
				return (int)(this._bookSheetColumn & 65535L);
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x000135CE File Offset: 0x000117CE
		public int SheetIndex
		{
			get
			{
				return (int)(this._bookSheetColumn >> 32 & 65535L);
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x000135E1 File Offset: 0x000117E1
		public int BookIndex
		{
			get
			{
				return (int)(this._bookSheetColumn >> 48 & 65535L);
			}
		}

		// Token: 0x040003E1 RID: 993
		private long _bookSheetColumn;

		// Token: 0x040003E2 RID: 994
		private int _rowIndex;
	}
}
