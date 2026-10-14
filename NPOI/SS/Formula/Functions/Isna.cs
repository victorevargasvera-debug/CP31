using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200019F RID: 415
	public class Isna : global::NPOI.SS.Formula.Functions.LogicalFunction
	{
		// Token: 0x06000B72 RID: 2930 RVA: 0x0001F164 File Offset: 0x0001D364
		protected override bool Evaluate(global::NPOI.SS.Formula.Eval.ValueEval arg)
		{
			return arg == global::NPOI.SS.Formula.Eval.ErrorEval.NA;
		}
	}
}
