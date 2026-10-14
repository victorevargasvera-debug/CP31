using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000195 RID: 405
	public class Fv : global::NPOI.SS.Formula.Functions.FinanceFunction
	{
		// Token: 0x06000B4C RID: 2892 RVA: 0x0001E767 File Offset: 0x0001C967
		public override double Evaluate(double rate, double arg1, double arg2, double arg3, bool type)
		{
			return global::NPOI.SS.Formula.Functions.FinanceLib.fv(rate, arg1, arg2, arg3, type);
		}
	}
}
