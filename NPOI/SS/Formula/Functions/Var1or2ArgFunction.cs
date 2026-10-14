using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001FC RID: 508
	public abstract class Var1or2ArgFunction : global::NPOI.SS.Formula.Functions.Function1Arg, global::NPOI.SS.Formula.Functions.Function, global::NPOI.SS.Formula.Functions.Function2Arg
	{
		// Token: 0x06000CB9 RID: 3257 RVA: 0x00022EE8 File Offset: 0x000210E8
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcRowIndex, int srcColumnIndex)
		{
			int num = args.Length;
			if (num == 1)
			{
				return this.Evaluate(srcRowIndex, srcColumnIndex, args[0]);
			}
			if (num != 2)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			return this.Evaluate(srcRowIndex, srcColumnIndex, args[0], args[1]);
		}

		// Token: 0x06000CBA RID: 3258
		public abstract global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0);

		// Token: 0x06000CBB RID: 3259
		public abstract global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1);
	}
}
