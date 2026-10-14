using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001D8 RID: 472
	public class Odd : global::NPOI.SS.Formula.Functions.OneArg
	{
		// Token: 0x06000C40 RID: 3136 RVA: 0x000214A8 File Offset: 0x0001F6A8
		public override double Evaluate(double d)
		{
			if (d == 0.0)
			{
				return 1.0;
			}
			long num;
			if (d > 0.0)
			{
				num = global::NPOI.SS.Formula.Functions.Odd.CalcOdd(d);
			}
			else
			{
				num = -global::NPOI.SS.Formula.Functions.Odd.CalcOdd(-d);
			}
			return (double)num;
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x000214EC File Offset: 0x0001F6EC
		private static long CalcOdd(double d)
		{
			double num = d + 1.0;
			long num2 = (long)num & -2L;
			if ((double)num2 == num)
			{
				return num2 - 1L;
			}
			return num2 + 1L;
		}

		// Token: 0x040005B3 RID: 1459
		private const long PARITY_MASK = -2L;
	}
}
