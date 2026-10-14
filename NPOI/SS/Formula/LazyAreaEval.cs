using System;
using System.Text;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.PTG;
using NPOI.SS.Util;

namespace NPOI.SS.Formula
{
	// Token: 0x020000D3 RID: 211
	public class LazyAreaEval : global::NPOI.SS.Formula.Eval.AreaEvalBase
	{
		// Token: 0x0600070A RID: 1802 RVA: 0x00012020 File Offset: 0x00010220
		public LazyAreaEval(global::NPOI.SS.Formula.PTG.AreaI ptg, global::NPOI.SS.Formula.SheetRangeEvaluator evaluator) : base(ptg, evaluator)
		{
			this._evaluator = evaluator;
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00012031 File Offset: 0x00010231
		public LazyAreaEval(int firstRowIndex, int firstColumnIndex, int lastRowIndex, int lastColumnIndex, global::NPOI.SS.Formula.SheetRangeEvaluator evaluator) : base(evaluator, firstRowIndex, firstColumnIndex, lastRowIndex, lastColumnIndex)
		{
			this._evaluator = evaluator;
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00012048 File Offset: 0x00010248
		public override global::NPOI.SS.Formula.Eval.ValueEval GetRelativeValue(int relativeRowIndex, int relativeColumnIndex)
		{
			return this.GetRelativeValue(base.FirstSheetIndex, relativeRowIndex, relativeColumnIndex);
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00012058 File Offset: 0x00010258
		public override global::NPOI.SS.Formula.Eval.ValueEval GetRelativeValue(int sheetIndex, int relativeRowIndex, int relativeColumnIndex)
		{
			int rowIndex = relativeRowIndex + base.FirstRow;
			int columnIndex = relativeColumnIndex + base.FirstColumn;
			return this._evaluator.GetEvalForCell(sheetIndex, rowIndex, columnIndex);
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00012088 File Offset: 0x00010288
		public override global::NPOI.SS.Formula.TwoDEval GetRow(int rowIndex)
		{
			if (rowIndex >= base.Height)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Invalid rowIndex ",
					rowIndex.ToString(),
					".  Allowable range is (0..",
					base.Height.ToString(),
					")."
				}));
			}
			int num = base.FirstRow + rowIndex;
			return new global::NPOI.SS.Formula.LazyAreaEval(num, base.FirstColumn, num, base.LastColumn, this._evaluator);
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00012104 File Offset: 0x00010304
		public override global::NPOI.SS.Formula.TwoDEval GetColumn(int columnIndex)
		{
			if (columnIndex >= base.Width)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Invalid columnIndex ",
					columnIndex.ToString(),
					".  Allowable range is (0..",
					base.Width.ToString(),
					")."
				}));
			}
			int num = base.FirstColumn + columnIndex;
			return new global::NPOI.SS.Formula.LazyAreaEval(base.FirstRow, num, base.LastRow, num, this._evaluator);
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00012180 File Offset: 0x00010380
		public override global::NPOI.SS.Formula.Eval.AreaEval Offset(int relFirstRowIx, int relLastRowIx, int relFirstColIx, int relLastColIx)
		{
			return new global::NPOI.SS.Formula.LazyAreaEval(new global::NPOI.SS.Formula.PTG.OffsetArea(base.FirstRow, base.FirstColumn, relFirstRowIx, relLastRowIx, relFirstColIx, relLastColIx), this._evaluator);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x000121A4 File Offset: 0x000103A4
		public override string ToString()
		{
			global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(base.FirstRow, base.FirstColumn);
			global::NPOI.SS.Util.CellReference cellReference2 = new global::NPOI.SS.Util.CellReference(base.LastRow, base.LastColumn);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(base.GetType().Name).Append("[");
			stringBuilder.Append(this._evaluator.SheetNameRange);
			stringBuilder.Append('!');
			stringBuilder.Append(cellReference.FormatAsString());
			stringBuilder.Append(':');
			stringBuilder.Append(cellReference2.FormatAsString());
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00012245 File Offset: 0x00010445
		public override bool IsSubTotal(int rowIndex, int columnIndex)
		{
			return this._evaluator.GetSheetEvaluator(this._evaluator.FirstSheetIndex).IsSubTotal(base.FirstRow + rowIndex, base.FirstColumn + columnIndex);
		}

		// Token: 0x040003D0 RID: 976
		private global::NPOI.SS.Formula.SheetRangeEvaluator _evaluator;
	}
}
