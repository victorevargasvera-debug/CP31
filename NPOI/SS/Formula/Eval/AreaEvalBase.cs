using System;
using NPOI.SS.Formula.PTG;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x02000204 RID: 516
	public abstract class AreaEvalBase : global::NPOI.SS.Formula.Eval.AreaEval, global::NPOI.SS.Formula.TwoDEval, global::NPOI.SS.Formula.Eval.ValueEval, global::NPOI.SS.Formula.ThreeDEval, global::NPOI.SS.Formula.ISheetRange
	{
		// Token: 0x06000CE1 RID: 3297 RVA: 0x00023274 File Offset: 0x00021474
		protected AreaEvalBase(global::NPOI.SS.Formula.ISheetRange sheets, int firstRow, int firstColumn, int lastRow, int lastColumn)
		{
			this._firstColumn = firstColumn;
			this._firstRow = firstRow;
			this._lastColumn = lastColumn;
			this._lastRow = lastRow;
			this._nColumns = this._lastColumn - this._firstColumn + 1;
			this._nRows = this._lastRow - this._firstRow + 1;
			if (sheets != null)
			{
				this._firstSheet = sheets.FirstSheetIndex;
				this._lastSheet = sheets.LastSheetIndex;
				return;
			}
			this._firstSheet = -1;
			this._lastSheet = -1;
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x000232F9 File Offset: 0x000214F9
		protected AreaEvalBase(int firstRow, int firstColumn, int lastRow, int lastColumn) : this(null, firstRow, firstColumn, lastRow, lastColumn)
		{
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x00023307 File Offset: 0x00021507
		protected AreaEvalBase(global::NPOI.SS.Formula.PTG.AreaI ptg) : this(ptg, null)
		{
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x00023311 File Offset: 0x00021511
		protected AreaEvalBase(global::NPOI.SS.Formula.PTG.AreaI ptg, global::NPOI.SS.Formula.ISheetRange sheets) : this(sheets, ptg.FirstRow, ptg.FirstColumn, ptg.LastRow, ptg.LastColumn)
		{
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x00023332 File Offset: 0x00021532
		public int FirstColumn
		{
			get
			{
				return this._firstColumn;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x0002333A File Offset: 0x0002153A
		public int FirstRow
		{
			get
			{
				return this._firstRow;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x00023342 File Offset: 0x00021542
		public int LastColumn
		{
			get
			{
				return this._lastColumn;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x0002334A File Offset: 0x0002154A
		public int LastRow
		{
			get
			{
				return this._lastRow;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x00023352 File Offset: 0x00021552
		public int FirstSheetIndex
		{
			get
			{
				return this._firstSheet;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x0002335A File Offset: 0x0002155A
		public int LastSheetIndex
		{
			get
			{
				return this._lastSheet;
			}
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x00023362 File Offset: 0x00021562
		public global::NPOI.SS.Formula.Eval.ValueEval GetValue(int row, int col)
		{
			return this.GetRelativeValue(row, col);
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x0002336C File Offset: 0x0002156C
		public global::NPOI.SS.Formula.Eval.ValueEval GetValue(int sheetIndex, int row, int col)
		{
			return this.GetRelativeValue(sheetIndex, row, col);
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00023377 File Offset: 0x00021577
		public bool Contains(int row, int col)
		{
			return this._firstRow <= row && this._lastRow >= row && this._firstColumn <= col && this._lastColumn >= col;
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x000233A2 File Offset: 0x000215A2
		public bool ContainsRow(int row)
		{
			return this._firstRow <= row && this._lastRow >= row;
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x000233BB File Offset: 0x000215BB
		public bool ContainsColumn(int col)
		{
			return this._firstColumn <= col && this._lastColumn >= col;
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x000233D4 File Offset: 0x000215D4
		public bool IsColumn
		{
			get
			{
				return this._firstColumn == this._lastColumn;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x000233E4 File Offset: 0x000215E4
		public bool IsRow
		{
			get
			{
				return this._firstRow == this._lastRow;
			}
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x000233F4 File Offset: 0x000215F4
		public global::NPOI.SS.Formula.Eval.ValueEval GetAbsoluteValue(int row, int col)
		{
			int num = row - this._firstRow;
			int num2 = col - this._firstColumn;
			if (num < 0 || num >= this._nRows)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Specified row index (",
					row.ToString(),
					") is outside the allowed range (",
					this._firstRow.ToString(),
					"..",
					this._lastRow.ToString(),
					")"
				}));
			}
			if (num2 < 0 || num2 >= this._nColumns)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Specified column index (",
					col.ToString(),
					") is outside the allowed range (",
					this._firstColumn.ToString(),
					"..",
					col.ToString(),
					")"
				}));
			}
			return this.GetRelativeValue(num, num2);
		}

		// Token: 0x06000CF3 RID: 3315
		public abstract global::NPOI.SS.Formula.Eval.ValueEval GetRelativeValue(int relativeRowIndex, int relativeColumnIndex);

		// Token: 0x06000CF4 RID: 3316
		public abstract global::NPOI.SS.Formula.Eval.ValueEval GetRelativeValue(int sheetIndex, int relativeRowIndex, int relativeColumnIndex);

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x000234DF File Offset: 0x000216DF
		public int Width
		{
			get
			{
				return this._lastColumn - this._firstColumn + 1;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x000234F0 File Offset: 0x000216F0
		public int Height
		{
			get
			{
				return this._lastRow - this._firstRow + 1;
			}
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00006EB4 File Offset: 0x000050B4
		public virtual bool IsSubTotal(int rowIndex, int columnIndex)
		{
			return false;
		}

		// Token: 0x06000CF8 RID: 3320
		public abstract global::NPOI.SS.Formula.TwoDEval GetRow(int rowIndex);

		// Token: 0x06000CF9 RID: 3321
		public abstract global::NPOI.SS.Formula.TwoDEval GetColumn(int columnIndex);

		// Token: 0x06000CFA RID: 3322
		public abstract global::NPOI.SS.Formula.Eval.AreaEval Offset(int relFirstRowIx, int relLastRowIx, int relFirstColIx, int relLastColIx);

		// Token: 0x040005D7 RID: 1495
		private int _firstSheet;

		// Token: 0x040005D8 RID: 1496
		private int _firstColumn;

		// Token: 0x040005D9 RID: 1497
		private int _firstRow;

		// Token: 0x040005DA RID: 1498
		private int _lastSheet;

		// Token: 0x040005DB RID: 1499
		private int _lastColumn;

		// Token: 0x040005DC RID: 1500
		private int _lastRow;

		// Token: 0x040005DD RID: 1501
		private int _nColumns;

		// Token: 0x040005DE RID: 1502
		private int _nRows;
	}
}
