using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001B1 RID: 433
	public class Maxa : global::NPOI.SS.Formula.Functions.MinaMaxa
	{
		// Token: 0x06000BD1 RID: 3025 RVA: 0x0001CF59 File Offset: 0x0001B159
		protected internal override double Evaluate(double[] values)
		{
			if (values.Length == 0)
			{
				return 0.0;
			}
			return global::NPOI.SS.Formula.Functions.MathX.Max(values);
		}
	}
}
