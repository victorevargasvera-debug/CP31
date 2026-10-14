using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000142 RID: 322
	public class Hyperlink : global::NPOI.SS.Formula.Functions.Var1or2ArgFunction
	{
		// Token: 0x06000A55 RID: 2645 RVA: 0x0001B48E File Offset: 0x0001968E
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0)
		{
			return arg0;
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0001B491 File Offset: 0x00019691
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1)
		{
			return arg1;
		}
	}
}
