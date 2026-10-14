using System;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x02000221 RID: 545
	public class AddEval : global::NPOI.SS.Formula.Eval.TwoOperandNumericOperation
	{
		// Token: 0x06000D6D RID: 3437 RVA: 0x00025923 File Offset: 0x00023B23
		public override double Evaluate(double d0, double d1)
		{
			return d0 + d1;
		}
	}
}
