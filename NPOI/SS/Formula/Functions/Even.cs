using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000183 RID: 387
	public class Even : global::NPOI.SS.Formula.Functions.OneArg
	{
		// Token: 0x06000B1F RID: 2847 RVA: 0x0001E1E0 File Offset: 0x0001C3E0
		public override double Evaluate(double d)
		{
			if (d == 0.0)
			{
				return 0.0;
			}
			long num;
			if (d > 0.0)
			{
				num = global::NPOI.SS.Formula.Functions.Even.calcEven(d);
			}
			else
			{
				num = -global::NPOI.SS.Formula.Functions.Even.calcEven(-d);
			}
			return (double)num;
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x0001E224 File Offset: 0x0001C424
		private static long calcEven(double d)
		{
			long num = (long)d & -2L;
			if ((double)num == d)
			{
				return num;
			}
			return num + 2L;
		}

		// Token: 0x04000560 RID: 1376
		private const long PARITY_MASK = -2L;
	}
}
