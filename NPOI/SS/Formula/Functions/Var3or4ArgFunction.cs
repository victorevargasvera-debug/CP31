using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001FE RID: 510
	public abstract class Var3or4ArgFunction : global::NPOI.SS.Formula.Functions.Function3Arg, global::NPOI.SS.Formula.Functions.Function, global::NPOI.SS.Formula.Functions.Function4Arg
	{
		// Token: 0x06000CC1 RID: 3265 RVA: 0x00022F68 File Offset: 0x00021168
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, int srcRowIndex, int srcColumnIndex)
		{
			int num = args.Length;
			if (num == 3)
			{
				return this.Evaluate(srcRowIndex, srcColumnIndex, args[0], args[1], args[2]);
			}
			if (num != 4)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			return this.Evaluate(srcRowIndex, srcColumnIndex, args[0], args[1], args[2], args[3]);
		}

		// Token: 0x06000CC2 RID: 3266
		public abstract global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.ValueEval arg2);

		// Token: 0x06000CC3 RID: 3267
		public abstract global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.ValueEval arg2, global::NPOI.SS.Formula.Eval.ValueEval arg3);
	}
}
