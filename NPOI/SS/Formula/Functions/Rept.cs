using System;
using System.Text;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200014F RID: 335
	public class Rept : global::NPOI.SS.Formula.Functions.Fixed2ArgFunction
	{
		// Token: 0x06000A82 RID: 2690 RVA: 0x0001C2F8 File Offset: 0x0001A4F8
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval text, global::NPOI.SS.Formula.Eval.ValueEval number_times)
		{
			global::NPOI.SS.Formula.Eval.ValueEval singleValue;
			try
			{
				singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(text, srcRowIndex, srcColumnIndex);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			string text2 = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(singleValue);
			double num = 0.0;
			try
			{
				num = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(number_times);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			int num2 = (int)num;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(text2.Length * num2);
			for (int i = 0; i < num2; i++)
			{
				stringBuilder.Append(text2);
			}
			if (stringBuilder.ToString().Length > 32767)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			return new global::NPOI.SS.Formula.Eval.StringEval(stringBuilder.ToString());
		}
	}
}
