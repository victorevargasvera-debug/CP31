using System;
using NPOI.SS.Formula.Functions;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x0200020C RID: 524
	public class IntersectionEval : global::NPOI.SS.Formula.Functions.Fixed2ArgFunction
	{
		// Token: 0x06000D1D RID: 3357 RVA: 0x0001A752 File Offset: 0x00018952
		private IntersectionEval()
		{
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x00024D10 File Offset: 0x00022F10
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1)
		{
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				global::NPOI.SS.Formula.Eval.AreaEval aeA = this.EvaluateRef(arg0);
				global::NPOI.SS.Formula.Eval.AreaEval aeB = this.EvaluateRef(arg1);
				global::NPOI.SS.Formula.Eval.AreaEval areaEval = global::NPOI.SS.Formula.Eval.IntersectionEval.ResolveRange(aeA, aeB);
				if (areaEval == null)
				{
					result = global::NPOI.SS.Formula.Eval.ErrorEval.NULL_INTERSECTION;
				}
				else
				{
					result = areaEval;
				}
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x00024D5C File Offset: 0x00022F5C
		private static global::NPOI.SS.Formula.Eval.AreaEval ResolveRange(global::NPOI.SS.Formula.Eval.AreaEval aeA, global::NPOI.SS.Formula.Eval.AreaEval aeB)
		{
			int firstRow = aeA.FirstRow;
			int firstColumn = aeA.FirstColumn;
			int lastColumn = aeB.LastColumn;
			if (firstColumn > lastColumn)
			{
				return null;
			}
			int firstColumn2 = aeB.FirstColumn;
			if (firstColumn2 > aeA.LastColumn)
			{
				return null;
			}
			int lastRow = aeB.LastRow;
			if (firstRow > lastRow)
			{
				return null;
			}
			int firstRow2 = aeB.FirstRow;
			int lastRow2 = aeA.LastRow;
			if (firstRow2 > lastRow2)
			{
				return null;
			}
			int num = global::System.Math.Max(firstRow, firstRow2);
			int num2 = global::System.Math.Min(lastRow2, lastRow);
			int num3 = global::System.Math.Max(firstColumn, firstColumn2);
			int num4 = global::System.Math.Min(aeA.LastColumn, lastColumn);
			return aeA.Offset(num - firstRow, num2 - firstRow, num3 - firstColumn, num4 - firstColumn);
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x00024E00 File Offset: 0x00023000
		private global::NPOI.SS.Formula.Eval.AreaEval EvaluateRef(global::NPOI.SS.Formula.Eval.ValueEval arg)
		{
			if (arg is global::NPOI.SS.Formula.Eval.AreaEval)
			{
				return (global::NPOI.SS.Formula.Eval.AreaEval)arg;
			}
			if (arg is global::NPOI.SS.Formula.Eval.RefEval)
			{
				return ((global::NPOI.SS.Formula.Eval.RefEval)arg).Offset(0, 0, 0, 0);
			}
			if (arg is global::NPOI.SS.Formula.Eval.ErrorEval)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException((global::NPOI.SS.Formula.Eval.ErrorEval)arg);
			}
			throw new global::System.ArgumentException("Unexpected ref arg class (" + arg.GetType().Name + ")");
		}

		// Token: 0x040005F2 RID: 1522
		public static global::NPOI.SS.Formula.Functions.Function instance = new global::NPOI.SS.Formula.Eval.IntersectionEval();
	}
}
