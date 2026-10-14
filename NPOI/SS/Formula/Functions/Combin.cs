using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000177 RID: 375
	public class Combin : global::NPOI.SS.Formula.Functions.TwoArg
	{
		// Token: 0x06000AEF RID: 2799 RVA: 0x0001D7C8 File Offset: 0x0001B9C8
		public override double Evaluate(double d0, double d1)
		{
			if (d0 > 2147483647.0 || d1 > 2147483647.0)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR);
			}
			return global::NPOI.SS.Formula.Functions.MathX.NChooseK((int)d0, (int)d1);
		}
	}
}
