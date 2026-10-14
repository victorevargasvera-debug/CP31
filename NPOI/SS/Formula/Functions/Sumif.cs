using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001E3 RID: 483
	public class Sumif : global::NPOI.SS.Formula.Functions.Var2or3ArgFunction
	{
		// Token: 0x06000C67 RID: 3175 RVA: 0x00021D74 File Offset: 0x0001FF74
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1)
		{
			global::NPOI.SS.Formula.Eval.AreaEval areaEval;
			try
			{
				areaEval = global::NPOI.SS.Formula.Functions.Sumif.ConvertRangeArg(arg0);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return global::NPOI.SS.Formula.Functions.Sumif.Eval(srcRowIndex, srcColumnIndex, arg1, areaEval, areaEval);
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x00021DB0 File Offset: 0x0001FFB0
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.ValueEval arg2)
		{
			global::NPOI.SS.Formula.Eval.AreaEval aeRange;
			global::NPOI.SS.Formula.Eval.AreaEval aeSum;
			try
			{
				aeRange = global::NPOI.SS.Formula.Functions.Sumif.ConvertRangeArg(arg0);
				aeSum = global::NPOI.SS.Formula.Functions.Sumif.CreateSumRange(arg2, aeRange);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return global::NPOI.SS.Formula.Functions.Sumif.Eval(srcRowIndex, srcColumnIndex, arg1, aeRange, aeSum);
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00021DF4 File Offset: 0x0001FFF4
		private static global::NPOI.SS.Formula.Eval.ValueEval Eval(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.AreaEval aeRange, global::NPOI.SS.Formula.Eval.AreaEval aeSum)
		{
			global::NPOI.SS.Formula.Functions.IMatchPredicate matchPredicate = global::NPOI.SS.Formula.Functions.Countif.CreateCriteriaPredicate(arg1, srcRowIndex, srcColumnIndex);
			if (matchPredicate == null)
			{
				return global::NPOI.SS.Formula.Eval.NumberEval.ZERO;
			}
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				result = new global::NPOI.SS.Formula.Eval.NumberEval(global::NPOI.SS.Formula.Functions.Sumif.SumMatchingCells(aeRange, matchPredicate, aeSum));
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x00021E40 File Offset: 0x00020040
		private static double SumMatchingCells(global::NPOI.SS.Formula.Eval.AreaEval aeRange, global::NPOI.SS.Formula.Functions.IMatchPredicate mp, global::NPOI.SS.Formula.Eval.AreaEval aeSum)
		{
			int height = aeRange.Height;
			int width = aeRange.Width;
			double num = 0.0;
			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					num += global::NPOI.SS.Formula.Functions.Sumif.Accumulate(aeRange, mp, aeSum, i, j);
				}
			}
			return num;
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x00021E90 File Offset: 0x00020090
		private static double Accumulate(global::NPOI.SS.Formula.Eval.AreaEval aeRange, global::NPOI.SS.Formula.Functions.IMatchPredicate mp, global::NPOI.SS.Formula.Eval.AreaEval aeSum, int relRowIndex, int relColIndex)
		{
			if (!mp.Matches(aeRange.GetRelativeValue(relRowIndex, relColIndex)))
			{
				return 0.0;
			}
			global::NPOI.SS.Formula.Eval.ValueEval relativeValue = aeSum.GetRelativeValue(relRowIndex, relColIndex);
			if (relativeValue is global::NPOI.SS.Formula.Eval.NumberEval)
			{
				return ((global::NPOI.SS.Formula.Eval.NumberEval)relativeValue).NumberValue;
			}
			if (relativeValue is global::NPOI.SS.Formula.Eval.ErrorEval)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException((global::NPOI.SS.Formula.Eval.ErrorEval)relativeValue);
			}
			return 0.0;
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x00021EF4 File Offset: 0x000200F4
		private static global::NPOI.SS.Formula.Eval.AreaEval CreateSumRange(global::NPOI.SS.Formula.Eval.ValueEval eval, global::NPOI.SS.Formula.Eval.AreaEval aeRange)
		{
			if (eval is global::NPOI.SS.Formula.Eval.AreaEval)
			{
				return ((global::NPOI.SS.Formula.Eval.AreaEval)eval).Offset(0, aeRange.Height - 1, 0, aeRange.Width - 1);
			}
			if (eval is global::NPOI.SS.Formula.Eval.RefEval)
			{
				return ((global::NPOI.SS.Formula.Eval.RefEval)eval).Offset(0, aeRange.Height - 1, 0, aeRange.Width - 1);
			}
			throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID);
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00019CA4 File Offset: 0x00017EA4
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
	}
}
