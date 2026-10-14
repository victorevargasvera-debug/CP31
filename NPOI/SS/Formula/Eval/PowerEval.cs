using System;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x02000224 RID: 548
	public class PowerEval : global::NPOI.SS.Formula.Eval.TwoOperandNumericOperation
	{
		// Token: 0x06000D73 RID: 3443 RVA: 0x00021798 File Offset: 0x0001F998
		public override double Evaluate(double d0, double d1)
		{
			return global::System.Math.Pow(d0, d1);
		}
	}
}
