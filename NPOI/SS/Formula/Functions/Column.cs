using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000175 RID: 373
	public class Column : global::NPOI.SS.Formula.Functions.Function0Arg, global::NPOI.SS.Formula.Functions.Function, global::NPOI.SS.Formula.Functions.Function1Arg
	{
		// Token: 0x06000AE9 RID: 2793 RVA: 0x0001D703 File Offset: 0x0001B903
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex)
		{
			return new global::NPOI.SS.Formula.Eval.NumberEval((double)(srcColumnIndex + 1));
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0001D710 File Offset: 0x0001B910
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0)
		{
			int num;
			if (arg0 is global::NPOI.SS.Formula.Eval.AreaEval)
			{
				num = ((global::NPOI.SS.Formula.Eval.AreaEval)arg0).FirstColumn;
			}
			else
			{
				if (!(arg0 is global::NPOI.SS.Formula.Eval.RefEval))
				{
					return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
				}
				num = ((global::NPOI.SS.Formula.Eval.RefEval)arg0).Column;
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval((double)(num + 1));
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0001D758 File Offset: 0x0001B958
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcRowIndex, int srcColumnIndex)
		{
			int num = args.Length;
			if (num == 0)
			{
				return new global::NPOI.SS.Formula.Eval.NumberEval((double)(srcColumnIndex + 1));
			}
			if (num == 1)
			{
				return this.Evaluate(srcRowIndex, srcColumnIndex, args[0]);
			}
			return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
		}
	}
}
