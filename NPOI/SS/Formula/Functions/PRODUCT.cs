using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000162 RID: 354
	public class PRODUCT : global::NPOI.SS.Formula.Functions.AggregateFunction
	{
		// Token: 0x06000AB9 RID: 2745 RVA: 0x0001CF8D File Offset: 0x0001B18D
		protected internal override double Evaluate(double[] values)
		{
			return global::NPOI.SS.Formula.Functions.MathX.Product(values);
		}
	}
}
