using System;
using System.Globalization;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001E9 RID: 489
	public class CHAR : global::NPOI.SS.Formula.Functions.Fixed1ArgFunction
	{
		// Token: 0x06000C82 RID: 3202 RVA: 0x000223BC File Offset: 0x000205BC
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0)
		{
			int num;
			try
			{
				num = global::NPOI.SS.Formula.Functions.TextFunction.EvaluateIntArg(arg0, srcRowIndex, srcColumnIndex);
				if (num < 0 || num >= 256)
				{
					throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
				}
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return new global::NPOI.SS.Formula.Eval.StringEval(global::System.Convert.ToString((char)num, global::System.Globalization.CultureInfo.CurrentCulture));
		}
	}
}
