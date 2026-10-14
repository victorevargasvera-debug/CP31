using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001F2 RID: 498
	public class SearchFind : global::NPOI.SS.Formula.Functions.Var2or3ArgFunction
	{
		// Token: 0x06000C96 RID: 3222 RVA: 0x000226E7 File Offset: 0x000208E7
		public SearchFind(bool isCaseSensitive)
		{
			this._isCaseSensitive = isCaseSensitive;
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x000226F8 File Offset: 0x000208F8
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1)
		{
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				string needle = global::NPOI.SS.Formula.Functions.TextFunction.EvaluateStringArg(arg0, srcRowIndex, srcColumnIndex);
				string haystack = global::NPOI.SS.Formula.Functions.TextFunction.EvaluateStringArg(arg1, srcRowIndex, srcColumnIndex);
				result = this.Eval(haystack, needle, 0);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00022740 File Offset: 0x00020940
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.ValueEval arg2)
		{
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				string needle = global::NPOI.SS.Formula.Functions.TextFunction.EvaluateStringArg(arg0, srcRowIndex, srcColumnIndex);
				string haystack = global::NPOI.SS.Formula.Functions.TextFunction.EvaluateStringArg(arg1, srcRowIndex, srcColumnIndex);
				int num = global::NPOI.SS.Formula.Functions.TextFunction.EvaluateIntArg(arg2, srcRowIndex, srcColumnIndex) - 1;
				if (num < 0)
				{
					result = global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
				}
				else
				{
					result = this.Eval(haystack, needle, num);
				}
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x000227A0 File Offset: 0x000209A0
		private global::NPOI.SS.Formula.Eval.ValueEval Eval(string haystack, string needle, int startIndex)
		{
			int num;
			if (this._isCaseSensitive)
			{
				num = haystack.IndexOf(needle, startIndex, global::System.StringComparison.CurrentCulture);
			}
			else
			{
				num = haystack.IndexOf(needle, startIndex, global::System.StringComparison.CurrentCultureIgnoreCase);
			}
			if (num == -1)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval((double)(num + 1));
		}

		// Token: 0x040005BB RID: 1467
		private bool _isCaseSensitive;
	}
}
