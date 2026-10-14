using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200018D RID: 397
	public class Floor : global::NPOI.SS.Formula.Functions.TwoArg
	{
		// Token: 0x06000B43 RID: 2883 RVA: 0x0001E73D File Offset: 0x0001C93D
		public override double Evaluate(double d0, double d1)
		{
			if (d1 != global::NPOI.SS.Formula.Functions.Floor.ZERO)
			{
				return global::NPOI.SS.Formula.Functions.MathX.Floor(d0, d1);
			}
			if (d0 == global::NPOI.SS.Formula.Functions.Floor.ZERO)
			{
				return global::NPOI.SS.Formula.Functions.Floor.ZERO;
			}
			throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.DIV_ZERO);
		}

		// Token: 0x04000567 RID: 1383
		private static double ZERO;
	}
}
