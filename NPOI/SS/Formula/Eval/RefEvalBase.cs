using System;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x02000217 RID: 535
	public abstract class RefEvalBase : global::NPOI.SS.Formula.Eval.RefEval, global::NPOI.SS.Formula.Eval.ValueEval, global::NPOI.SS.Formula.ISheetRange
	{
		// Token: 0x06000D4B RID: 3403 RVA: 0x00025563 File Offset: 0x00023763
		protected RefEvalBase(global::NPOI.SS.Formula.ISheetRange sheetRange, int rowIndex, int columnIndex)
		{
			if (sheetRange == null)
			{
				throw new global::System.ArgumentException("sheetRange must not be null");
			}
			this._firstSheetIndex = sheetRange.FirstSheetIndex;
			this._lastSheetIndex = sheetRange.LastSheetIndex;
			this._rowIndex = rowIndex;
			this._columnIndex = columnIndex;
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x0002559F File Offset: 0x0002379F
		protected RefEvalBase(int firstSheetIndex, int lastSheetIndex, int rowIndex, int columnIndex)
		{
			this._firstSheetIndex = firstSheetIndex;
			this._lastSheetIndex = lastSheetIndex;
			this._rowIndex = rowIndex;
			this._columnIndex = columnIndex;
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x000255C4 File Offset: 0x000237C4
		protected RefEvalBase(int onlySheetIndex, int rowIndex, int columnIndex) : this(onlySheetIndex, onlySheetIndex, rowIndex, columnIndex)
		{
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000D4E RID: 3406 RVA: 0x000255D0 File Offset: 0x000237D0
		public int NumberOfSheets
		{
			get
			{
				return this._lastSheetIndex - this._firstSheetIndex + 1;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000D4F RID: 3407 RVA: 0x000255E1 File Offset: 0x000237E1
		public int FirstSheetIndex
		{
			get
			{
				return this._firstSheetIndex;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000D50 RID: 3408 RVA: 0x000255E9 File Offset: 0x000237E9
		public int LastSheetIndex
		{
			get
			{
				return this._lastSheetIndex;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000D51 RID: 3409 RVA: 0x000255F1 File Offset: 0x000237F1
		public int Row
		{
			get
			{
				return this._rowIndex;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000D52 RID: 3410 RVA: 0x000255F9 File Offset: 0x000237F9
		public int Column
		{
			get
			{
				return this._columnIndex;
			}
		}

		// Token: 0x06000D53 RID: 3411
		public abstract global::NPOI.SS.Formula.Eval.ValueEval GetInnerValueEval(int sheetIndex);

		// Token: 0x06000D54 RID: 3412
		public abstract global::NPOI.SS.Formula.Eval.AreaEval Offset(int relFirstRowIx, int relLastRowIx, int relFirstColIx, int relLastColIx);

		// Token: 0x040005FE RID: 1534
		private int _firstSheetIndex;

		// Token: 0x040005FF RID: 1535
		private int _lastSheetIndex;

		// Token: 0x04000600 RID: 1536
		private int _rowIndex;

		// Token: 0x04000601 RID: 1537
		private int _columnIndex;
	}
}
