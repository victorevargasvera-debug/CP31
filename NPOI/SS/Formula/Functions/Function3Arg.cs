using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000193 RID: 403
	public interface Function3Arg : global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000B4A RID: 2890
		global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.ValueEval arg2);
	}
}
