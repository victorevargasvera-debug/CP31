using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200017E RID: 382
	internal class CountUtils
	{
		// Token: 0x06000B08 RID: 2824 RVA: 0x0000253E File Offset: 0x0000073E
		private CountUtils()
		{
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0001DCA0 File Offset: 0x0001BEA0
		public static int CountMatchingCellsInRef(global::NPOI.SS.Formula.Eval.RefEval refEval, global::NPOI.SS.Formula.Functions.IMatchPredicate criteriaPredicate)
		{
			int num = 0;
			int firstSheetIndex = refEval.FirstSheetIndex;
			int lastSheetIndex = refEval.LastSheetIndex;
			for (int i = firstSheetIndex; i <= lastSheetIndex; i++)
			{
				global::NPOI.SS.Formula.Eval.ValueEval innerValueEval = refEval.GetInnerValueEval(i);
				if (criteriaPredicate.Matches(innerValueEval))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0001DCE0 File Offset: 0x0001BEE0
		public static int CountArg(global::NPOI.SS.Formula.Eval.ValueEval eval, global::NPOI.SS.Formula.Functions.IMatchPredicate criteriaPredicate)
		{
			if (eval == null)
			{
				throw new global::System.ArgumentException("eval must not be null");
			}
			if (eval is global::NPOI.SS.Formula.ThreeDEval)
			{
				return global::NPOI.SS.Formula.Functions.CountUtils.CountMatchingCellsInArea((global::NPOI.SS.Formula.ThreeDEval)eval, criteriaPredicate);
			}
			if (eval is global::NPOI.SS.Formula.TwoDEval)
			{
				throw new global::System.ArgumentException("Count requires 3D Evals, 2D ones aren't supported");
			}
			if (eval is global::NPOI.SS.Formula.Eval.RefEval)
			{
				return global::NPOI.SS.Formula.Functions.CountUtils.CountMatchingCellsInRef((global::NPOI.SS.Formula.Eval.RefEval)eval, criteriaPredicate);
			}
			if (!criteriaPredicate.Matches(eval))
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0001DD44 File Offset: 0x0001BF44
		public static int CountMatchingCellsInArea(global::NPOI.SS.Formula.ThreeDEval areaEval, global::NPOI.SS.Formula.Functions.IMatchPredicate criteriaPredicate)
		{
			int num = 0;
			int firstSheetIndex = areaEval.FirstSheetIndex;
			int lastSheetIndex = areaEval.LastSheetIndex;
			for (int i = firstSheetIndex; i <= lastSheetIndex; i++)
			{
				int height = areaEval.Height;
				int width = areaEval.Width;
				for (int j = 0; j < height; j++)
				{
					for (int k = 0; k < width; k++)
					{
						global::NPOI.SS.Formula.Eval.ValueEval value = areaEval.GetValue(i, j, k);
						if ((!(criteriaPredicate is global::NPOI.SS.Formula.Functions.I_MatchAreaPredicate) || ((global::NPOI.SS.Formula.Functions.I_MatchAreaPredicate)criteriaPredicate).Matches(areaEval, j, k)) && criteriaPredicate.Matches(value))
						{
							num++;
						}
					}
				}
			}
			return num;
		}
	}
}
