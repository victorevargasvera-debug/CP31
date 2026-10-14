using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000151 RID: 337
	public class Slope : global::NPOI.SS.Formula.Functions.Fixed2ArgFunction
	{
		// Token: 0x06000A89 RID: 2697 RVA: 0x0001C728 File Offset: 0x0001A928
		public Slope()
		{
			this.func = new global::NPOI.SS.Formula.Functions.LinearRegressionFunction(global::NPOI.SS.Formula.Functions.LinearRegressionFunction.FUNCTION.SLOPE);
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x0001C73C File Offset: 0x0001A93C
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1)
		{
			return this.func.Evaluate(srcRowIndex, srcColumnIndex, arg0, arg1);
		}

		// Token: 0x04000530 RID: 1328
		private global::NPOI.SS.Formula.Functions.LinearRegressionFunction func;
	}
}
