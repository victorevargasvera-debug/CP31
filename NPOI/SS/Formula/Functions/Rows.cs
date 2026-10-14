using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001DF RID: 479
	public class Rows : global::NPOI.SS.Formula.Functions.Fixed1ArgFunction
	{
		// Token: 0x06000C56 RID: 3158 RVA: 0x00021850 File Offset: 0x0001FA50
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0)
		{
			int num;
			if (arg0 is global::NPOI.SS.Formula.TwoDEval)
			{
				num = ((global::NPOI.SS.Formula.TwoDEval)arg0).Height;
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
