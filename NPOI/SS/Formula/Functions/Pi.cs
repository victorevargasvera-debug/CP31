using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001CC RID: 460
	public class Pi : global::NPOI.SS.Formula.Functions.Fixed0ArgFunction
	{
		// Token: 0x06000C20 RID: 3104 RVA: 0x00021206 File Offset: 0x0001F406
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex)
		{
			return global::NPOI.SS.Formula.Functions.Pi.PI_EVAL;
		}

		// Token: 0x040005AF RID: 1455
		private static readonly global::NPOI.SS.Formula.Eval.NumberEval PI_EVAL = new global::NPOI.SS.Formula.Eval.NumberEval(3.141592653589793);
	}
}
