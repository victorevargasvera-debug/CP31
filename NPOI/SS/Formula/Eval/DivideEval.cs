using System;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x02000222 RID: 546
	public class DivideEval : global::NPOI.SS.Formula.Eval.TwoOperandNumericOperation
	{
		// Token: 0x06000D6F RID: 3439 RVA: 0x00025930 File Offset: 0x00023B30
		public override double Evaluate(double d0, double d1)
		{
			if (d1 == 0.0)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.DIV_ZERO);
			}
			return d0 / d1;
		}
	}
}
