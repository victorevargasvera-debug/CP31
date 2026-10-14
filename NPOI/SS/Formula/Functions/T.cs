using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001E8 RID: 488
	public class T : global::NPOI.SS.Formula.Functions.Fixed1ArgFunction
	{
		// Token: 0x06000C80 RID: 3200 RVA: 0x00022360 File Offset: 0x00020560
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0)
		{
			global::NPOI.SS.Formula.Eval.ValueEval valueEval = arg0;
			if (valueEval is global::NPOI.SS.Formula.Eval.RefEval)
			{
				global::NPOI.SS.Formula.Eval.RefEval refEval = (global::NPOI.SS.Formula.Eval.RefEval)valueEval;
				valueEval = refEval.GetInnerValueEval(refEval.FirstSheetIndex);
			}
			else if (valueEval is global::NPOI.SS.Formula.Eval.AreaEval)
			{
				valueEval = ((global::NPOI.SS.Formula.Eval.AreaEval)valueEval).GetRelativeValue(0, 0);
			}
			if (valueEval is global::NPOI.SS.Formula.Eval.StringEval)
			{
				return valueEval;
			}
			if (valueEval is global::NPOI.SS.Formula.Eval.ErrorEval)
			{
				return valueEval;
			}
			return global::NPOI.SS.Formula.Eval.StringEval.EMPTY_INSTANCE;
		}
	}
}
