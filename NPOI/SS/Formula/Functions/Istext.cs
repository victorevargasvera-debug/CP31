using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001A3 RID: 419
	public class Istext : global::NPOI.SS.Formula.Functions.LogicalFunction
	{
		// Token: 0x06000B7A RID: 2938 RVA: 0x0001F1A4 File Offset: 0x0001D3A4
		protected override bool Evaluate(global::NPOI.SS.Formula.Eval.ValueEval arg)
		{
			return arg is global::NPOI.SS.Formula.Eval.StringEval;
		}
	}
}
