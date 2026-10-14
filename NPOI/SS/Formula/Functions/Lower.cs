using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001EF RID: 495
	public class Lower : global::NPOI.SS.Formula.Functions.SingleArgTextFunc
	{
		// Token: 0x06000C90 RID: 3216 RVA: 0x000225A3 File Offset: 0x000207A3
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(string arg)
		{
			return new global::NPOI.SS.Formula.Eval.StringEval(arg.ToLower());
		}
	}
}
