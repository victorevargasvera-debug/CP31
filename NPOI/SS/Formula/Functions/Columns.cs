using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000176 RID: 374
	public class Columns : global::NPOI.SS.Formula.Functions.Fixed1ArgFunction
	{
		// Token: 0x06000AED RID: 2797 RVA: 0x0001D78C File Offset: 0x0001B98C
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0)
		{
			int num;
			if (arg0 is global::NPOI.SS.Formula.Eval.AreaEval)
			{
				num = ((global::NPOI.SS.Formula.Eval.AreaEval)arg0).Width;
			}
			else
			{
				if (!(arg0 is global::NPOI.SS.Formula.Eval.RefEval))
				{
					return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
				}
				num = 1;
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval((double)num);
		}
	}
}
