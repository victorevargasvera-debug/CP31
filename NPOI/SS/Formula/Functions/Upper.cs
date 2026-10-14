using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001F8 RID: 504
	public class Upper : global::NPOI.SS.Formula.Functions.SingleArgTextFunc
	{
		// Token: 0x06000CAE RID: 3246 RVA: 0x00022B1A File Offset: 0x00020D1A
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(string arg)
		{
			return new global::NPOI.SS.Formula.Eval.StringEval(arg.ToUpper());
		}
	}
}
