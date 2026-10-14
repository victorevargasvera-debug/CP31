using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001A1 RID: 417
	public class Isnumber : global::NPOI.SS.Formula.Functions.LogicalFunction
	{
		// Token: 0x06000B76 RID: 2934 RVA: 0x0001F17C File Offset: 0x0001D37C
		protected override bool Evaluate(global::NPOI.SS.Formula.Eval.ValueEval arg)
		{
			return arg is global::NPOI.SS.Formula.Eval.NumberEval;
		}
	}
}
