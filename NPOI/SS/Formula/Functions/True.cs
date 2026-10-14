using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000171 RID: 369
	public class True : global::NPOI.SS.Formula.Functions.Fixed0ArgFunction
	{
		// Token: 0x06000ADE RID: 2782 RVA: 0x0001D4F5 File Offset: 0x0001B6F5
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex)
		{
			return global::NPOI.SS.Formula.Eval.BoolEval.TRUE;
		}
	}
}
