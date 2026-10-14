using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001DA RID: 474
	public class Pmt : global::NPOI.SS.Formula.Functions.FinanceFunction
	{
		// Token: 0x06000C4A RID: 3146 RVA: 0x0002178A File Offset: 0x0001F98A
		public override double Evaluate(double rate, double arg1, double arg2, double arg3, bool type)
		{
			return global::NPOI.SS.Formula.Functions.FinanceLib.pmt(rate, arg1, arg2, arg3, type);
		}
	}
}
