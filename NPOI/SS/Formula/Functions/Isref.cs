using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001A2 RID: 418
	public class Isref : global::NPOI.SS.Formula.Functions.Fixed1ArgFunction
	{
		// Token: 0x06000B78 RID: 2936 RVA: 0x0001F187 File Offset: 0x0001D387
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0)
		{
			if (arg0 is global::NPOI.SS.Formula.Eval.RefEval || arg0 is global::NPOI.SS.Formula.Eval.AreaEval)
			{
				return global::NPOI.SS.Formula.Eval.BoolEval.TRUE;
			}
			return global::NPOI.SS.Formula.Eval.BoolEval.FALSE;
		}
	}
}
