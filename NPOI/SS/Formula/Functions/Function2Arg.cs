using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000192 RID: 402
	public interface Function2Arg : global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000B49 RID: 2889
		global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1);
	}
}
