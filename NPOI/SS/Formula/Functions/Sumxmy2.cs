using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001E7 RID: 487
	public class Sumxmy2 : global::NPOI.SS.Formula.Functions.XYNumericFunction
	{
		// Token: 0x06000C7D RID: 3197 RVA: 0x0002234D File Offset: 0x0002054D
		public override global::NPOI.SS.Formula.Functions.Accumulator CreateAccumulator()
		{
			return global::NPOI.SS.Formula.Functions.Sumxmy2.XMinusYSquaredAccumulator;
		}

		// Token: 0x040005B8 RID: 1464
		private static global::NPOI.SS.Formula.Functions.Accumulator XMinusYSquaredAccumulator = new global::NPOI.SS.Formula.Functions.Sumxmy2.Accumulator1();

		// Token: 0x02000589 RID: 1417
		public class Accumulator1 : global::NPOI.SS.Formula.Functions.Accumulator
		{
			// Token: 0x06003436 RID: 13366 RVA: 0x000A2A78 File Offset: 0x000A0C78
			public double Accumulate(double x, double y)
			{
				double num = x - y;
				return num * num;
			}
		}
	}
}
