using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000174 RID: 372
	public class Choose : global::NPOI.SS.Formula.Functions.Function
	{
		// Token: 0x06000AE6 RID: 2790 RVA: 0x0001D684 File Offset: 0x0001B884
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcRowIndex, int srcColumnIndex)
		{
			if (args.Length < 2)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				int num = global::NPOI.SS.Formula.Functions.Choose.EvaluateFirstArg(args[0], srcRowIndex, srcColumnIndex);
				if (num < 1 || num >= args.Length)
				{
					result = global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
				}
				else
				{
					global::NPOI.SS.Formula.Eval.ValueEval singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[num], srcRowIndex, srcColumnIndex);
					if (singleValue == global::NPOI.SS.Formula.Eval.MissingArgEval.instance)
					{
						result = global::NPOI.SS.Formula.Eval.BlankEval.instance;
					}
					else
					{
						result = singleValue;
					}
				}
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0001D6F4 File Offset: 0x0001B8F4
		public static int EvaluateFirstArg(global::NPOI.SS.Formula.Eval.ValueEval arg0, int srcRowIndex, int srcColumnIndex)
		{
			return global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToInt(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg0, srcRowIndex, srcColumnIndex));
		}
	}
}
