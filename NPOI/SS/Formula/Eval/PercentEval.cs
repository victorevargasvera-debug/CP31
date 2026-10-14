using System;
using NPOI.SS.Formula.Functions;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x02000214 RID: 532
	public class PercentEval : global::NPOI.SS.Formula.Functions.Fixed1ArgFunction
	{
		// Token: 0x06000D3E RID: 3390 RVA: 0x00019F8B File Offset: 0x0001818B
		private PercentEval()
		{
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x000253D8 File Offset: 0x000235D8
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0)
		{
			double num;
			try
			{
				num = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg0, srcRowIndex, srcColumnIndex));
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			if (num == 0.0)
			{
				return global::NPOI.SS.Formula.Eval.NumberEval.ZERO;
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(num / 100.0);
		}

		// Token: 0x040005FC RID: 1532
		public static global::NPOI.SS.Formula.Functions.Function instance = new global::NPOI.SS.Formula.Eval.PercentEval();
	}
}
