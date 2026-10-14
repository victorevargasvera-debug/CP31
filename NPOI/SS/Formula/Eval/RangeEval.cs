using System;
using NPOI.SS.Formula.Functions;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x02000215 RID: 533
	public class RangeEval : global::NPOI.SS.Formula.Functions.Fixed2ArgFunction
	{
		// Token: 0x06000D41 RID: 3393 RVA: 0x0001A752 File Offset: 0x00018952
		private RangeEval()
		{
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x00025440 File Offset: 0x00023640
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1)
		{
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				global::NPOI.SS.Formula.Eval.AreaEval aeA = global::NPOI.SS.Formula.Eval.RangeEval.EvaluateRef(arg0);
				global::NPOI.SS.Formula.Eval.AreaEval aeB = global::NPOI.SS.Formula.Eval.RangeEval.EvaluateRef(arg1);
				result = global::NPOI.SS.Formula.Eval.RangeEval.ResolveRange(aeA, aeB);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x00025480 File Offset: 0x00023680
		private static global::NPOI.SS.Formula.Eval.AreaEval ResolveRange(global::NPOI.SS.Formula.Eval.AreaEval aeA, global::NPOI.SS.Formula.Eval.AreaEval aeB)
		{
			int firstRow = aeA.FirstRow;
			int firstColumn = aeA.FirstColumn;
			int num = global::System.Math.Min(firstRow, aeB.FirstRow);
			int num2 = global::System.Math.Max(aeA.LastRow, aeB.LastRow);
			int num3 = global::System.Math.Min(firstColumn, aeB.FirstColumn);
			int num4 = global::System.Math.Max(aeA.LastColumn, aeB.LastColumn);
			return aeA.Offset(num - firstRow, num2 - firstRow, num3 - firstColumn, num4 - firstColumn);
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x000254F0 File Offset: 0x000236F0
		private static global::NPOI.SS.Formula.Eval.AreaEval EvaluateRef(global::NPOI.SS.Formula.Eval.ValueEval arg)
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

		// Token: 0x040005FD RID: 1533
		public static global::NPOI.SS.Formula.Functions.Function instance = new global::NPOI.SS.Formula.Eval.RangeEval();
	}
}
