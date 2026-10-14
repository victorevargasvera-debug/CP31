using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000158 RID: 344
	public class Iserr : global::NPOI.SS.Formula.Functions.LogicalFunction
	{
		// Token: 0x06000AA5 RID: 2725 RVA: 0x0001CD51 File Offset: 0x0001AF51
		protected override bool Evaluate(global::NPOI.SS.Formula.Eval.ValueEval arg)
		{
			return arg is global::NPOI.SS.Formula.Eval.ErrorEval && arg != global::NPOI.SS.Formula.Eval.ErrorEval.NA;
		}
	}
}
