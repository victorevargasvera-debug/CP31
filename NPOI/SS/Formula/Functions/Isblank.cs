using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200019C RID: 412
	public class Isblank : global::NPOI.SS.Formula.Functions.LogicalFunction
	{
		// Token: 0x06000B6C RID: 2924 RVA: 0x0001F143 File Offset: 0x0001D343
		protected override bool Evaluate(global::NPOI.SS.Formula.Eval.ValueEval arg)
		{
			return arg is global::NPOI.SS.Formula.Eval.BlankEval;
		}
	}
}
