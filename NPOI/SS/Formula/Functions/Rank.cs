using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200014D RID: 333
	public class Rank : global::NPOI.SS.Formula.Functions.Var2or3ArgFunction
	{
		// Token: 0x06000A78 RID: 2680 RVA: 0x0001BE74 File Offset: 0x0001A074
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1)
		{
			double num;
			global::NPOI.SS.Formula.Eval.AreaEval aeRange;
			try
			{
				num = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg0, srcRowIndex, srcColumnIndex));
				if (double.IsNaN(num) || double.IsInfinity(num))
				{
					throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR);
				}
				aeRange = global::NPOI.SS.Formula.Functions.Rank.ConvertRangeArg(arg1);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return global::NPOI.SS.Formula.Functions.Rank.eval(srcRowIndex, srcColumnIndex, num, aeRange, true);
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0001BED8 File Offset: 0x0001A0D8
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.ValueEval arg2)
		{
			bool descending_order = false;
			double num;
			global::NPOI.SS.Formula.Eval.AreaEval aeRange;
			try
			{
				num = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg0, srcRowIndex, srcColumnIndex));
				if (double.IsNaN(num) || double.IsInfinity(num))
				{
					throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR);
				}
				aeRange = global::NPOI.SS.Formula.Functions.Rank.ConvertRangeArg(arg1);
				int num2 = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToInt(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg2, srcRowIndex, srcColumnIndex));
				if (num2 == 0)
				{
					descending_order = true;
				}
				else
				{
					if (num2 != 1)
					{
						throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR);
					}
					descending_order = false;
				}
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return global::NPOI.SS.Formula.Functions.Rank.eval(srcRowIndex, srcColumnIndex, num, aeRange, descending_order);
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0001BF6C File Offset: 0x0001A16C
		private static global::NPOI.SS.Formula.Eval.ValueEval eval(int srcRowIndex, int srcColumnIndex, double arg0, global::NPOI.SS.Formula.Eval.AreaEval aeRange, bool descending_order)
		{
			int num = 1;
			int height = aeRange.Height;
			int width = aeRange.Width;
			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					double value = global::NPOI.SS.Formula.Functions.Rank.GetValue(aeRange, i, j);
					if (!double.IsNaN(value) && ((descending_order && value > arg0) || (!descending_order && value < arg0)))
					{
						num++;
					}
				}
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval((double)num);
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x0001BFD8 File Offset: 0x0001A1D8
		private static double GetValue(global::NPOI.SS.Formula.Eval.AreaEval aeRange, int relRowIndex, int relColIndex)
		{
			global::NPOI.SS.Formula.Eval.ValueEval relativeValue = aeRange.GetRelativeValue(relRowIndex, relColIndex);
			if (relativeValue is global::NPOI.SS.Formula.Eval.NumberEval)
			{
				return ((global::NPOI.SS.Formula.Eval.NumberEval)relativeValue).NumberValue;
			}
			return double.NaN;
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00019CA4 File Offset: 0x00017EA4
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
