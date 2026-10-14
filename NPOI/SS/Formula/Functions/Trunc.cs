using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001D7 RID: 471
	public class Trunc : global::NPOI.SS.Formula.Functions.Var1or2ArgFunction
	{
		// Token: 0x06000C3C RID: 3132 RVA: 0x000213FF File Offset: 0x0001F5FF
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0)
		{
			return this.Evaluate(srcRowIndex, srcColumnIndex, arg0, global::NPOI.SS.Formula.Functions.Trunc.TRUNC_ARG2_DEFAULT);
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00021410 File Offset: 0x0001F610
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1)
		{
			double num3;
			try
			{
				double num = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg0, srcRowIndex, srcColumnIndex);
				double y = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg1, srcRowIndex, srcColumnIndex);
				double num2 = global::System.Math.Pow(10.0, y);
				if (num < 0.0)
				{
					num3 = -global::System.Math.Floor(-num * num2) / num2;
				}
				else
				{
					num3 = global::System.Math.Floor(num * num2) / num2;
				}
				global::NPOI.SS.Formula.Functions.NumericFunction.CheckValue(num3);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(num3);
		}

		// Token: 0x040005B2 RID: 1458
		private static global::NPOI.SS.Formula.Eval.NumberEval TRUNC_ARG2_DEFAULT = new global::NPOI.SS.Formula.Eval.NumberEval(0.0);
	}
}
