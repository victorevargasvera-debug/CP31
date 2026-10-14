using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000133 RID: 307
	public class Code : global::NPOI.SS.Formula.Functions.Fixed1ArgFunction
	{
		// Token: 0x06000A0B RID: 2571 RVA: 0x00019FA0 File Offset: 0x000181A0
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval textArg)
		{
			global::NPOI.SS.Formula.Eval.ValueEval singleValue;
			try
			{
				singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(textArg, srcRowIndex, srcColumnIndex);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			string text = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(singleValue);
			if (text.Length == 0)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			return new global::NPOI.SS.Formula.Eval.StringEval(((int)text[0]).ToString());
		}
	}
}
