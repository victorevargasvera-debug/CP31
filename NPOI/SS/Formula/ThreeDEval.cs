using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula
{
	// Token: 0x020000B1 RID: 177
	public interface ThreeDEval : global::NPOI.SS.Formula.TwoDEval, global::NPOI.SS.Formula.Eval.ValueEval, global::NPOI.SS.Formula.ISheetRange
	{
		// Token: 0x06000617 RID: 1559
		global::NPOI.SS.Formula.Eval.ValueEval GetValue(int sheetIndex, int rowIndex, int columnIndex);
	}
}
