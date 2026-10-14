using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000146 RID: 326
	public class Intercept : global::NPOI.SS.Formula.Functions.Fixed2ArgFunction
	{
		// Token: 0x06000A62 RID: 2658 RVA: 0x0001B7B0 File Offset: 0x000199B0
		public Intercept()
		{
			this.func = new global::NPOI.SS.Formula.Functions.LinearRegressionFunction(global::NPOI.SS.Formula.Functions.LinearRegressionFunction.FUNCTION.INTERCEPT);
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x0001B7C4 File Offset: 0x000199C4
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1)
		{
			return this.func.Evaluate(srcRowIndex, srcColumnIndex, arg0, arg1);
		}

		// Token: 0x04000528 RID: 1320
		private global::NPOI.SS.Formula.Functions.LinearRegressionFunction func;
	}
}
