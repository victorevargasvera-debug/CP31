using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200019D RID: 413
	public class Iserror : global::NPOI.SS.Formula.Functions.LogicalFunction
	{
		// Token: 0x06000B6E RID: 2926 RVA: 0x0001F14E File Offset: 0x0001D34E
		protected override bool Evaluate(global::NPOI.SS.Formula.Eval.ValueEval arg)
		{
			return arg is global::NPOI.SS.Formula.Eval.ErrorEval;
		}
	}
}
