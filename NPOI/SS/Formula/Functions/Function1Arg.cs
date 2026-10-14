using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000191 RID: 401
	public interface Function1Arg : global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000B48 RID: 2888
		global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0);
	}
}
