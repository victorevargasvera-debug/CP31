using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200016E RID: 366
	public class False : global::NPOI.SS.Formula.Functions.Fixed0ArgFunction
	{
		// Token: 0x06000AD7 RID: 2775 RVA: 0x0001D488 File Offset: 0x0001B688
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex)
		{
			return global::NPOI.SS.Formula.Eval.BoolEval.FALSE;
		}
	}
}
