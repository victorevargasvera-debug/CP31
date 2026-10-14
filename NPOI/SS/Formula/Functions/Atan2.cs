using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001C2 RID: 450
	public class Atan2 : global::NPOI.SS.Formula.Functions.TwoArg
	{
		// Token: 0x06000C04 RID: 3076 RVA: 0x00020E4F File Offset: 0x0001F04F
		public override double Evaluate(double d0, double d1)
		{
			if (d0 == 0.0 && d1 == 0.0)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.DIV_ZERO);
			}
			return global::System.Math.Atan2(d1, d0);
		}
	}
}
