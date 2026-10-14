using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001CE RID: 462
	public class Rand : global::NPOI.SS.Formula.Functions.Fixed0ArgFunction
	{
		// Token: 0x06000C2A RID: 3114 RVA: 0x000213A8 File Offset: 0x0001F5A8
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex)
		{
			return new global::NPOI.SS.Formula.Eval.NumberEval(new global::System.Random().NextDouble());
		}
	}
}
