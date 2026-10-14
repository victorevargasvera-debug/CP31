using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001DE RID: 478
	public class Row : global::NPOI.SS.Formula.Functions.Function0Arg, global::NPOI.SS.Formula.Functions.Function, global::NPOI.SS.Formula.Functions.Function1Arg
	{
		// Token: 0x06000C52 RID: 3154 RVA: 0x000217C6 File Offset: 0x0001F9C6
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex)
		{
			return new global::NPOI.SS.Formula.Eval.NumberEval((double)(srcRowIndex + 1));
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x000217D4 File Offset: 0x0001F9D4
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0)
		{
			int num;
			if (arg0 is global::NPOI.SS.Formula.Eval.AreaEval)
			{
				num = ((global::NPOI.SS.Formula.Eval.AreaEval)arg0).FirstRow;
			}
			else
			{
				if (!(arg0 is global::NPOI.SS.Formula.Eval.RefEval))
				{
					return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
				}
				num = ((global::NPOI.SS.Formula.Eval.RefEval)arg0).Row;
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval((double)(num + 1));
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x0002181C File Offset: 0x0001FA1C
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcRowIndex, int srcColumnIndex)
		{
			int num = args.Length;
			if (num == 0)
			{
				return new global::NPOI.SS.Formula.Eval.NumberEval((double)(srcRowIndex + 1));
			}
			if (num == 1)
			{
				return this.Evaluate(srcRowIndex, srcColumnIndex, args[0]);
			}
			return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
		}
	}
}
