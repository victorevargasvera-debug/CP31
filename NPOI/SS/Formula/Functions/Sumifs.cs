using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000153 RID: 339
	public class Sumifs : global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000A8F RID: 2703 RVA: 0x0001C7C4 File Offset: 0x0001A9C4
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
				result = new global::NPOI.SS.Formula.Eval.NumberEval(global::NPOI.SS.Formula.Functions.Sumifs.CalcMatchingCells(array, array2, areaEval, 0.0, (double init, double? current) => init + ((current != null) ? current.Value : 0.0)));
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x0001C8A4 File Offset: 0x0001AAA4
		internal static void ValidateCriteria(global::NPOI.SS.Formula.Functions.IMatchPredicate[] criteria)
		{
			foreach (global::NPOI.SS.Formula.Functions.IMatchPredicate matchPredicate in criteria)
			{
				if (matchPredicate is global::NPOI.SS.Formula.Functions.Countif.ErrorMatcher)
				{
					throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.ValueOf(((global::NPOI.SS.Formula.Functions.Countif.ErrorMatcher)matchPredicate).Value));
				}
			}
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x0001C8E4 File Offset: 0x0001AAE4
		internal static void ValidateCriteriaRanges(global::NPOI.SS.Formula.Eval.AreaEval[] criteriaRanges, global::NPOI.SS.Formula.Eval.AreaEval sumRange)
		{
			foreach (global::NPOI.SS.Formula.Eval.AreaEval areaEval in criteriaRanges)
			{
				if (areaEval.Height != sumRange.Height || areaEval.Width != sumRange.Width)
				{
					throw global::NPOI.SS.Formula.Eval.EvaluationException.InvalidValue();
				}
			}
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x0001C928 File Offset: 0x0001AB28
		internal static double CalcMatchingCells(global::NPOI.SS.Formula.Eval.AreaEval[] ranges, global::NPOI.SS.Formula.Functions.IMatchPredicate[] predicates, global::NPOI.SS.Formula.Eval.AreaEval aeSum, double initialValue, global::System.Func<double, double?, double> calc)
		{
			int height = aeSum.Height;
			int width = aeSum.Width;
			double num = initialValue;
			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					bool flag = true;
					for (int k = 0; k < ranges.Length; k++)
					{
						global::NPOI.SS.Formula.Eval.AreaEval areaEval = ranges[k];
						if (!predicates[k].Matches(areaEval.GetRelativeValue(i, j)))
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						num = calc(num, global::NPOI.SS.Formula.Functions.Sumifs.ReadValue(aeSum, i, j));
					}
				}
			}
			return num;
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0001C9B0 File Offset: 0x0001ABB0
		private static double? ReadValue(global::NPOI.SS.Formula.Eval.AreaEval aeSum, int relRowIndex, int relColIndex)
		{
			global::NPOI.SS.Formula.Eval.ValueEval relativeValue = aeSum.GetRelativeValue(relRowIndex, relColIndex);
			if (relativeValue is global::NPOI.SS.Formula.Eval.NumberEval)
			{
				return new double?(((global::NPOI.SS.Formula.Eval.NumberEval)relativeValue).NumberValue);
			}
			return null;
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00019CA4 File Offset: 0x00017EA4
		internal static global::NPOI.SS.Formula.Eval.AreaEval ConvertRangeArg(global::NPOI.SS.Formula.Eval.ValueEval eval)
		{
			if (eval is global::NPOI.SS.Formula.Eval.AreaEval)
			{
				return (global::NPOI.SS.Formula.Eval.AreaEval)eval;
			}
			if (eval is global::NPOI.SS.Formula.Eval.RefEval)
			{
				return ((global::NPOI.SS.Formula.Eval.RefEval)eval).Offset(0, 0, 0, 0);
			}
			throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
		}

		// Token: 0x04000532 RID: 1330
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction instance = new global::NPOI.SS.Formula.Functions.Sumifs();
	}
}
