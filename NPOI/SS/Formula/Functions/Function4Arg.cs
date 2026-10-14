using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000194 RID: 404
	public interface Function4Arg : global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000B4B RID: 2891
		global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.ValueEval arg2, global::NPOI.SS.Formula.Eval.ValueEval arg3);
	}
}
