using System;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x02000216 RID: 534
	public interface RefEval : global::NPOI.SS.Formula.Eval.ValueEval, global::NPOI.SS.Formula.ISheetRange
	{
		// Token: 0x06000D46 RID: 3398
		global::NPOI.SS.Formula.Eval.ValueEval GetInnerValueEval(int sheetIndex);

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000D47 RID: 3399
		int Column { get; }

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000D48 RID: 3400
		int Row { get; }

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000D49 RID: 3401
		int NumberOfSheets { get; }

		// Token: 0x06000D4A RID: 3402
		global::NPOI.SS.Formula.Eval.AreaEval Offset(int relFirstRowIx, int relLastRowIx, int relFirstColIx, int relLastColIx);
	}
}
