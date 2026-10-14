using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001B4 RID: 436
	public class Mod : global::NPOI.SS.Formula.Functions.TwoArg
	{
		// Token: 0x06000BD7 RID: 3031 RVA: 0x0002061A File Offset: 0x0001E81A
		public override double Evaluate(double d0, double d1)
		{
			if (d1 == 0.0)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.DIV_ZERO);
			}
			return global::NPOI.SS.Formula.Functions.MathX.Mod(d0, d1);
		}
	}
}
