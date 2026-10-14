using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200019E RID: 414
	public class Islogical : global::NPOI.SS.Formula.Functions.LogicalFunction
	{
		// Token: 0x06000B70 RID: 2928 RVA: 0x0001F159 File Offset: 0x0001D359
		protected override bool Evaluate(global::NPOI.SS.Formula.Eval.ValueEval arg)
		{
			return arg is global::NPOI.SS.Formula.Eval.BoolEval;
		}
	}
}
