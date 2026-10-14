using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001F4 RID: 500
	public class Text : global::NPOI.SS.Formula.Functions.Fixed2ArgFunction
	{
		// Token: 0x06000C9E RID: 3230 RVA: 0x0002295C File Offset: 0x00020B5C
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1)
		{
			double value;
			string formatString;
			try
			{
				value = global::NPOI.SS.Formula.Functions.TextFunction.EvaluateDoubleArg(arg0, srcRowIndex, srcColumnIndex);
				formatString = global::NPOI.SS.Formula.Functions.TextFunction.EvaluateStringArg(arg1, srcRowIndex, srcColumnIndex);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				result = new global::NPOI.SS.Formula.Eval.StringEval(global::NPOI.SS.Formula.Functions.Text.Formatter.FormatRawCellContents(value, -1, formatString));
			}
			catch (global::System.Exception)
			{
				result = global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			return result;
		}

		// Token: 0x040005BC RID: 1468
		public static global::NPOI.SS.UserModel.DataFormatter Formatter = new global::NPOI.SS.UserModel.DataFormatter();
	}
}
