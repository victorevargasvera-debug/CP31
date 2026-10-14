using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001DC RID: 476
	public class Pv : global::NPOI.SS.Formula.Functions.FinanceFunction
	{
		// Token: 0x06000C4E RID: 3150 RVA: 0x000217A1 File Offset: 0x0001F9A1
		public override double Evaluate(double rate, double arg1, double arg2, double arg3, bool type)
		{
			return global::NPOI.SS.Formula.Functions.FinanceLib.pv(rate, arg1, arg2, arg3, type);
		}
	}
}
