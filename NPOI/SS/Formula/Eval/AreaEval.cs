using System;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x02000203 RID: 515
	public interface AreaEval : global::NPOI.SS.Formula.TwoDEval, global::NPOI.SS.Formula.Eval.ValueEval, global::NPOI.SS.Formula.ThreeDEval, global::NPOI.SS.Formula.ISheetRange
	{
		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000CD7 RID: 3287
		int FirstRow { get; }

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000CD8 RID: 3288
		int LastRow { get; }

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000CD9 RID: 3289
		int FirstColumn { get; }

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000CDA RID: 3290
		int LastColumn { get; }

		// Token: 0x06000CDB RID: 3291
		bool Contains(int row, int col);

		// Token: 0x06000CDC RID: 3292
		bool ContainsColumn(int col);

		// Token: 0x06000CDD RID: 3293
		bool ContainsRow(int row);

		// Token: 0x06000CDE RID: 3294
		global::NPOI.SS.Formula.Eval.ValueEval GetAbsoluteValue(int row, int col);

		// Token: 0x06000CDF RID: 3295
		global::NPOI.SS.Formula.Eval.ValueEval GetRelativeValue(int relativeRowIndex, int relativeColumnIndex);

		// Token: 0x06000CE0 RID: 3296
		global::NPOI.SS.Formula.Eval.AreaEval Offset(int relFirstRowIx, int relLastRowIx, int relFirstColIx, int relLastColIx);
	}
}
