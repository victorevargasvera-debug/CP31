using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200017A RID: 378
	public class Countblank : global::NPOI.SS.Formula.Functions.Fixed1ArgFunction
	{
		// Token: 0x06000AFB RID: 2811 RVA: 0x0001D918 File Offset: 0x0001BB18
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0)
		{
			double value;
			if (arg0 is global::NPOI.SS.Formula.Eval.RefEval)
			{
				value = (double)global::NPOI.SS.Formula.Functions.CountUtils.CountMatchingCellsInRef((global::NPOI.SS.Formula.Eval.RefEval)arg0, global::NPOI.SS.Formula.Functions.Countblank.predicate);
			}
			else
			{
				if (!(arg0 is global::NPOI.SS.Formula.ThreeDEval))
				{
					throw new global::System.ArgumentException("Bad range arg type (" + arg0.GetType().Name + ")");
				}
				value = (double)global::NPOI.SS.Formula.Functions.CountUtils.CountMatchingCellsInArea((global::NPOI.SS.Formula.ThreeDEval)arg0, global::NPOI.SS.Formula.Functions.Countblank.predicate);
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(value);
		}

		// Token: 0x0400055E RID: 1374
		private static global::NPOI.SS.Formula.Functions.IMatchPredicate predicate = new global::NPOI.SS.Formula.Functions.Countblank.BlankPredicate();

		// Token: 0x02000576 RID: 1398
		private class BlankPredicate : global::NPOI.SS.Formula.Functions.IMatchPredicate
		{
			// Token: 0x060033E9 RID: 13289 RVA: 0x000A1C47 File Offset: 0x0009FE47
			public bool Matches(global::NPOI.SS.Formula.Eval.ValueEval valueEval)
			{
				return valueEval == global::NPOI.SS.Formula.Eval.BlankEval.instance || (valueEval is global::NPOI.SS.Formula.Eval.StringEval && "".Equals(((global::NPOI.SS.Formula.Eval.StringEval)valueEval).StringValue));
			}
		}
	}
}
