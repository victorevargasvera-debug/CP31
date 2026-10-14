using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000173 RID: 371
	public class Ceiling : global::NPOI.SS.Formula.Functions.TwoArg
	{
		// Token: 0x06000AE4 RID: 2788 RVA: 0x0001D673 File Offset: 0x0001B873
		public override double Evaluate(double d0, double d1)
		{
			return global::NPOI.SS.Formula.Functions.MathX.Ceiling(d0, d1);
		}
	}
}
