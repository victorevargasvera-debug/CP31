using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000160 RID: 352
	public class MIN : global::NPOI.SS.Formula.Functions.AggregateFunction
	{
		// Token: 0x06000AB5 RID: 2741 RVA: 0x0001CF6F File Offset: 0x0001B16F
		protected internal override double Evaluate(double[] values)
		{
			if (values.Length == 0)
			{
				return 0.0;
			}
			return global::NPOI.SS.Formula.Functions.MathX.Min(values);
		}
	}
}
