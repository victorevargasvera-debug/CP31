using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001E6 RID: 486
	public class Sumx2py2 : global::NPOI.SS.Formula.Functions.XYNumericFunction
	{
		// Token: 0x06000C7A RID: 3194 RVA: 0x0002233A File Offset: 0x0002053A
		public override global::NPOI.SS.Formula.Functions.Accumulator CreateAccumulator()
		{
			return global::NPOI.SS.Formula.Functions.Sumx2py2.XSquaredPlusYSquaredAccumulator;
		}

		// Token: 0x040005B7 RID: 1463
		private static global::NPOI.SS.Formula.Functions.Accumulator XSquaredPlusYSquaredAccumulator = new global::NPOI.SS.Formula.Functions.Sumx2py2.Accumulator3();

		// Token: 0x02000588 RID: 1416
		public class Accumulator3 : global::NPOI.SS.Formula.Functions.Accumulator
		{
			// Token: 0x06003434 RID: 13364 RVA: 0x000A2A6F File Offset: 0x000A0C6F
			public double Accumulate(double x, double y)
			{
				return x * x + y * y;
			}
		}
	}
}
