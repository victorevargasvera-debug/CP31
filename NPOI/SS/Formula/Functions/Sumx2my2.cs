using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001E5 RID: 485
	public class Sumx2my2 : global::NPOI.SS.Formula.Functions.XYNumericFunction
	{
		// Token: 0x06000C77 RID: 3191 RVA: 0x0002231F File Offset: 0x0002051F
		public override global::NPOI.SS.Formula.Functions.Accumulator CreateAccumulator()
		{
			return global::NPOI.SS.Formula.Functions.Sumx2my2.XSquaredMinusYSquaredAccumulator;
		}

		// Token: 0x040005B6 RID: 1462
		private static global::NPOI.SS.Formula.Functions.Accumulator XSquaredMinusYSquaredAccumulator = new global::NPOI.SS.Formula.Functions.Sumx2my2.Accumulator2();

		// Token: 0x02000587 RID: 1415
		public class Accumulator2 : global::NPOI.SS.Formula.Functions.Accumulator
		{
			// Token: 0x06003432 RID: 13362 RVA: 0x000A2A66 File Offset: 0x000A0C66
			public double Accumulate(double x, double y)
			{
				return x * x - y * y;
			}
		}
	}
}
