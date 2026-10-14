using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000130 RID: 304
	public class AverageIfs : global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x060009FB RID: 2555 RVA: 0x00019AB8 File Offset: 0x00017CB8
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length < 3 || args.Length % 2 == 0)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				global::NPOI.SS.Formula.Eval.AreaEval areaEval = global::NPOI.SS.Formula.Functions.AverageIfs.ConvertRangeArg(args[0]);
				global::NPOI.SS.Formula.Eval.AreaEval[] array = new global::NPOI.SS.Formula.Eval.AreaEval[(args.Length - 1) / 2];
				global::NPOI.SS.Formula.Functions.IMatchPredicate[] array2 = new global::NPOI.SS.Formula.Functions.IMatchPredicate[array.Length];
				int i = 1;
				int num = 0;
				while (i < args.Length)
				{
					array[num] = global::NPOI.SS.Formula.Functions.AverageIfs.ConvertRangeArg(args[i]);
					array2[num] = global::NPOI.SS.Formula.Functions.Countif.CreateCriteriaPredicate(args[i + 1], ec.RowIndex, ec.ColumnIndex);
					i += 2;
					num++;
				}
				this.ValidateCriteriaRanges(array, areaEval);
				global::NPOI.SS.Formula.Functions.Sumifs.ValidateCriteria(array2);
				result = new global::NPOI.SS.Formula.Eval.NumberEval(global::NPOI.SS.Formula.Functions.AverageIfs.GetAvgFromMatchingCells(array, array2, areaEval));
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00019B70 File Offset: 0x00017D70
		private void ValidateCriteriaRanges(global::NPOI.SS.Formula.Eval.AreaEval[] criteriaRanges, global::NPOI.SS.Formula.Eval.AreaEval avgRange)
		{
			foreach (global::NPOI.SS.Formula.Eval.AreaEval areaEval in criteriaRanges)
			{
				if (areaEval.Height != avgRange.Height || areaEval.Width != avgRange.Width)
				{
					throw global::NPOI.SS.Formula.Eval.EvaluationException.InvalidValue();
				}
			}
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00019BB4 File Offset: 0x00017DB4
		private static double GetAvgFromMatchingCells(global::NPOI.SS.Formula.Eval.AreaEval[] ranges, global::NPOI.SS.Formula.Functions.IMatchPredicate[] predicates, global::NPOI.SS.Formula.Eval.AreaEval aeAvg)
		{
			int height = aeAvg.Height;
			int width = aeAvg.Width;
			double num = 0.0;
			int num2 = 0;
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
						double? num3 = global::NPOI.SS.Formula.Functions.AverageIfs.Accumulate(aeAvg, i, j);
						if (num3 != null)
						{
							num += num3.Value;
							num2++;
						}
					}
				}
			}
			if (num2 <= 0)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
			}
			return num / (double)num2;
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x00019C6C File Offset: 0x00017E6C
		private static double? Accumulate(global::NPOI.SS.Formula.Eval.AreaEval aeSum, int relRowIndex, int relColIndex)
		{
			global::NPOI.SS.Formula.Eval.ValueEval relativeValue = aeSum.GetRelativeValue(relRowIndex, relColIndex);
			if (relativeValue is global::NPOI.SS.Formula.Eval.NumberEval)
			{
				return new double?(((global::NPOI.SS.Formula.Eval.NumberEval)relativeValue).NumberValue);
			}
			return null;
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00019CA4 File Offset: 0x00017EA4
		private static global::NPOI.SS.Formula.Eval.AreaEval ConvertRangeArg(global::NPOI.SS.Formula.Eval.ValueEval eval)
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

		// Token: 0x04000502 RID: 1282
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction instance = new global::NPOI.SS.Formula.Functions.AverageIfs();
	}
}
