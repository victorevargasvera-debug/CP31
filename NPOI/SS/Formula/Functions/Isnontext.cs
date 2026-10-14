using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001A0 RID: 416
	public class Isnontext : global::NPOI.SS.Formula.Functions.LogicalFunction
	{
		// Token: 0x06000B74 RID: 2932 RVA: 0x0001F16E File Offset: 0x0001D36E
		protected override bool Evaluate(global::NPOI.SS.Formula.Eval.ValueEval arg)
		{
			return !(arg is global::NPOI.SS.Formula.Eval.StringEval);
		}
	}
}
