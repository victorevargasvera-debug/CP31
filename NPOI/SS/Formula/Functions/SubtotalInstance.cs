using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000168 RID: 360
	public class SubtotalInstance : global::NPOI.SS.Formula.Functions.AggregateFunction
	{
		// Token: 0x06000AC5 RID: 2757 RVA: 0x0001D030 File Offset: 0x0001B230
		public SubtotalInstance(global::NPOI.SS.Formula.Functions.AggregateFunction func)
		{
			this._func = func;
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0001D03F File Offset: 0x0001B23F
		protected internal override double Evaluate(double[] values)
		{
			return this._func.Evaluate(values);
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override bool IsSubtotalCounted
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0400053A RID: 1338
		private global::NPOI.SS.Formula.Functions.AggregateFunction _func;
	}
}
