using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.PTG;
using NPOI.SS.Util;

namespace NPOI.SS.Formula
{
	// Token: 0x020000D4 RID: 212
	public class LazyRefEval : global::NPOI.SS.Formula.Eval.RefEvalBase
	{
		// Token: 0x06000713 RID: 1811 RVA: 0x00012272 File Offset: 0x00010472
		public LazyRefEval(int rowIndex, int columnIndex, global::NPOI.SS.Formula.SheetRangeEvaluator sre) : base(sre, rowIndex, columnIndex)
		{
			if (sre == null)
			{
				throw new global::System.ArgumentException("sre must not be null");
			}
			this._evaluator = sre;
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00012292 File Offset: 0x00010492
		public override global::NPOI.SS.Formula.Eval.ValueEval GetInnerValueEval(int sheetIndex)
		{
			return this._evaluator.GetEvalForCell(sheetIndex, base.Row, base.Column);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x000122AC File Offset: 0x000104AC
		public override global::NPOI.SS.Formula.Eval.AreaEval Offset(int relFirstRowIx, int relLastRowIx, int relFirstColIx, int relLastColIx)
		{
			return new global::NPOI.SS.Formula.LazyAreaEval(new global::NPOI.SS.Formula.PTG.OffsetArea(base.Row, base.Column, relFirstRowIx, relLastRowIx, relFirstColIx, relLastColIx), this._evaluator);
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x000122CF File Offset: 0x000104CF
		public bool IsSubTotal
		{
			get
			{
				return this._evaluator.GetSheetEvaluator(base.FirstSheetIndex).IsSubTotal(base.Row, base.Column);
			}
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x000122F4 File Offset: 0x000104F4
		public override string ToString()
		{
			global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(base.Row, base.Column);
			return string.Concat(new string[]
			{
				base.GetType().Name,
				"[",
				this._evaluator.SheetNameRange,
				"!",
				cellReference.FormatAsString(),
				"]"
			});
		}

		// Token: 0x040003D1 RID: 977
		private global::NPOI.SS.Formula.SheetRangeEvaluator _evaluator;
	}
}
