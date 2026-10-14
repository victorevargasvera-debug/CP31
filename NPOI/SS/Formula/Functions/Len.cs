using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001EE RID: 494
	public class Len : global::NPOI.SS.Formula.Functions.SingleArgTextFunc
	{
		// Token: 0x06000C8E RID: 3214 RVA: 0x00022595 File Offset: 0x00020795
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(string arg)
		{
			return new global::NPOI.SS.Formula.Eval.NumberEval((double)arg.Length);
		}
	}
}
