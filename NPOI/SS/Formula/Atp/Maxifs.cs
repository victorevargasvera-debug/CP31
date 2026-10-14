using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.Functions;

namespace NPOI.SS.Formula.Atp
{
	// Token: 0x02000233 RID: 563
	public class Maxifs : global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000DC3 RID: 3523 RVA: 0x000266F0 File Offset: 0x000248F0
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length < 3 || args.Length % 2 == 0)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				global::NPOI.SS.Formula.Eval.AreaEval areaEval = global::NPOI.SS.Formula.Functions.Sumifs.ConvertRangeArg(args[0]);
				global::NPOI.SS.Formula.Eval.AreaEval[] array = new global::NPOI.SS.Formula.Eval.AreaEval[(args.Length - 1) / 2];
				global::NPOI.SS.Formula.Functions.IMatchPredicate[] array2 = new global::NPOI.SS.Formula.Functions.IMatchPredicate[array.Length];
				int i = 1;
				int num = 0;
				while (i < args.Length)
				{
					array[num] = global::NPOI.SS.Formula.Functions.Sumifs.ConvertRangeArg(args[i]);
					array2[num] = global::NPOI.SS.Formula.Functions.Countif.CreateCriteriaPredicate(args[i + 1], ec.RowIndex, ec.ColumnIndex);
					i += 2;
					num++;
				}
				global::NPOI.SS.Formula.Functions.Sumifs.ValidateCriteriaRanges(array, areaEval);
				global::NPOI.SS.Formula.Functions.Sumifs.ValidateCriteria(array2);
				result = new global::NPOI.SS.Formula.Eval.NumberEval(global::NPOI.SS.Formula.Functions.Sumifs.CalcMatchingCells(array, array2, areaEval, double.NaN, delegate(double init, double? current)
				{
					if (current == null)
					{
						return init;
					}
					if (double.IsNaN(init))
					{
						return current.Value;
					}
					if (current.Value <= init)
					{
						return init;
					}
					return current.Value;
				}));
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x04000622 RID: 1570
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction instance = new global::NPOI.SS.Formula.Atp.Maxifs();
	}
}
