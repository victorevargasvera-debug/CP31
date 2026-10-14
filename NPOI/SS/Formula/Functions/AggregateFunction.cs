using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200016B RID: 363
	public abstract class AggregateFunction : global::NPOI.SS.Formula.Functions.MultiOperandNumericFunction
	{
		// Token: 0x06000ACC RID: 2764 RVA: 0x0001D21C File Offset: 0x0001B41C
		public static global::NPOI.SS.Formula.Functions.Function SubtotalInstance(global::NPOI.SS.Formula.Functions.Function func)
		{
			return new global::NPOI.SS.Formula.Functions.SubtotalInstance((global::NPOI.SS.Formula.Functions.AggregateFunction)func);
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0001BB03 File Offset: 0x00019D03
		protected AggregateFunction() : base(false, false)
		{
		}

		// Token: 0x0400053C RID: 1340
		public static readonly global::NPOI.SS.Formula.Functions.Function AVEDEV = new global::NPOI.SS.Formula.Functions.AVEDEV();

		// Token: 0x0400053D RID: 1341
		public static readonly global::NPOI.SS.Formula.Functions.Function AVERAGE = new global::NPOI.SS.Formula.Functions.AVERAGE();

		// Token: 0x0400053E RID: 1342
		public static readonly global::NPOI.SS.Formula.Functions.Function DEVSQ = new global::NPOI.SS.Formula.Functions.DEVSQ();

		// Token: 0x0400053F RID: 1343
		public static readonly global::NPOI.SS.Formula.Functions.Function LARGE = new global::NPOI.SS.Formula.Functions.LARGE();

		// Token: 0x04000540 RID: 1344
		public static readonly global::NPOI.SS.Formula.Functions.Function MAX = new global::NPOI.SS.Formula.Functions.MAX();

		// Token: 0x04000541 RID: 1345
		public static readonly global::NPOI.SS.Formula.Functions.Function MEDIAN = new global::NPOI.SS.Formula.Functions.MEDIAN();

		// Token: 0x04000542 RID: 1346
		public static readonly global::NPOI.SS.Formula.Functions.Function MIN = new global::NPOI.SS.Formula.Functions.MIN();

		// Token: 0x04000543 RID: 1347
		public static readonly global::NPOI.SS.Formula.Functions.Function PRODUCT = new global::NPOI.SS.Formula.Functions.PRODUCT();

		// Token: 0x04000544 RID: 1348
		public static readonly global::NPOI.SS.Formula.Functions.Function SMALL = new global::NPOI.SS.Formula.Functions.SMALL();

		// Token: 0x04000545 RID: 1349
		public static readonly global::NPOI.SS.Formula.Functions.Function STDEV = new global::NPOI.SS.Formula.Functions.STDEV();

		// Token: 0x04000546 RID: 1350
		public static readonly global::NPOI.SS.Formula.Functions.Function SUM = new global::NPOI.SS.Formula.Functions.SUM();

		// Token: 0x04000547 RID: 1351
		public static readonly global::NPOI.SS.Formula.Functions.Function SUMSQ = new global::NPOI.SS.Formula.Functions.SUMSQ();

		// Token: 0x04000548 RID: 1352
		public static readonly global::NPOI.SS.Formula.Functions.Function VAR = new global::NPOI.SS.Formula.Functions.VAR();

		// Token: 0x04000549 RID: 1353
		public static readonly global::NPOI.SS.Formula.Functions.Function VARP = new global::NPOI.SS.Formula.Functions.VARP();

		// Token: 0x0400054A RID: 1354
		public static readonly global::NPOI.SS.Formula.Functions.Function PERCENTILE = new global::NPOI.SS.Formula.Functions.Percentile();

		// Token: 0x02000571 RID: 1393
		internal class ValueCollector : global::NPOI.SS.Formula.Functions.MultiOperandNumericFunction
		{
			// Token: 0x060033DB RID: 13275 RVA: 0x0001BB03 File Offset: 0x00019D03
			public ValueCollector() : base(false, false)
			{
			}

			// Token: 0x060033DC RID: 13276 RVA: 0x000A1BD7 File Offset: 0x0009FDD7
			public static double[] CollectValues(params global::NPOI.SS.Formula.Eval.ValueEval[] operands)
			{
				return global::NPOI.SS.Formula.Functions.AggregateFunction.ValueCollector.instance.GetNumberArray(operands);
			}

			// Token: 0x060033DD RID: 13277 RVA: 0x000A1BE4 File Offset: 0x0009FDE4
			protected internal override double Evaluate(double[] values)
			{
				throw new global::System.InvalidOperationException("should not be called");
			}

			// Token: 0x040018BA RID: 6330
			private static global::NPOI.SS.Formula.Functions.AggregateFunction.ValueCollector instance = new global::NPOI.SS.Formula.Functions.AggregateFunction.ValueCollector();
		}
	}
}
