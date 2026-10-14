using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001CA RID: 458
	public abstract class TwoArg : global::NPOI.SS.Formula.Functions.Fixed2ArgFunction
	{
		// Token: 0x06000C18 RID: 3096 RVA: 0x00020FDC File Offset: 0x0001F1DC
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1)
		{
			double num;
			try
			{
				double d = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg0, srcRowIndex, srcColumnIndex);
				double d2 = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg1, srcRowIndex, srcColumnIndex);
				num = this.Evaluate(d, d2);
				global::NPOI.SS.Formula.Functions.NumericFunction.CheckValue(num);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(num);
		}

		// Token: 0x06000C19 RID: 3097
		public abstract double Evaluate(double d0, double d1);
	}
}
