using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001BA RID: 442
	public class Nper : global::NPOI.SS.Formula.Functions.FinanceFunction
	{
		// Token: 0x06000BF0 RID: 3056 RVA: 0x00020C29 File Offset: 0x0001EE29
		public override double Evaluate(double rate, double arg1, double arg2, double arg3, bool type)
		{
			return global::NPOI.SS.Formula.Functions.FinanceLib.nper(rate, arg1, arg2, arg3, type);
		}
	}
}
