using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001C7 RID: 455
	public class Log : global::NPOI.SS.Formula.Functions.Var1or2ArgFunction
	{
		// Token: 0x06000C0F RID: 3087 RVA: 0x00020E9C File Offset: 0x0001F09C
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0)
		{
			double num;
			try
			{
				num = global::System.Math.Log(global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg0, srcRowIndex, srcColumnIndex)) / global::NPOI.SS.Formula.Functions.NumericFunction.LOG_10_TO_BASE_e;
				global::NPOI.SS.Formula.Functions.NumericFunction.CheckValue(num);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(num);
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00020EE8 File Offset: 0x0001F0E8
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1)
		{
			double num4;
			try
			{
				double d = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg0, srcRowIndex, srcColumnIndex);
				double num = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg1, srcRowIndex, srcColumnIndex);
				double num2 = global::System.Math.Log(d);
				double num3 = num;
				if (num3 == 2.718281828459045)
				{
					num4 = num2;
				}
				else
				{
					num4 = num2 / global::System.Math.Log(num3);
				}
				global::NPOI.SS.Formula.Functions.NumericFunction.CheckValue(num4);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(num4);
		}
	}
}
