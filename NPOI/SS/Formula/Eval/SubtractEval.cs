using System;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x02000225 RID: 549
	public class SubtractEval : global::NPOI.SS.Formula.Eval.TwoOperandNumericOperation
	{
		// Token: 0x06000D75 RID: 3445 RVA: 0x00025951 File Offset: 0x00023B51
		public override double Evaluate(double d0, double d1)
		{
			return d0 - d1;
		}
	}
}
