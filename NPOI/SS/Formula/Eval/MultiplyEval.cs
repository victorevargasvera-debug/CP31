using System;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x02000223 RID: 547
	public class MultiplyEval : global::NPOI.SS.Formula.Eval.TwoOperandNumericOperation
	{
		// Token: 0x06000D71 RID: 3441 RVA: 0x0002594C File Offset: 0x00023B4C
		public override double Evaluate(double d0, double d1)
		{
			return d0 * d1;
		}
	}
}
