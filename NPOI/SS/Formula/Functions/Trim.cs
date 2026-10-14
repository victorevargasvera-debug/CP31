using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001F7 RID: 503
	public class Trim : global::NPOI.SS.Formula.Functions.SingleArgTextFunc
	{
		// Token: 0x06000CAC RID: 3244 RVA: 0x00022B0D File Offset: 0x00020D0D
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(string arg)
		{
			return new global::NPOI.SS.Formula.Eval.StringEval(arg.Trim());
		}
	}
}
