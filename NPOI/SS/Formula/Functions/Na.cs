using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001B7 RID: 439
	public class Na : global::NPOI.SS.Formula.Functions.Fixed0ArgFunction
	{
		// Token: 0x06000BE8 RID: 3048 RVA: 0x00020BD4 File Offset: 0x0001EDD4
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcCellRow, int srcCellCol)
		{
			return global::NPOI.SS.Formula.Eval.ErrorEval.NA;
		}
	}
}
