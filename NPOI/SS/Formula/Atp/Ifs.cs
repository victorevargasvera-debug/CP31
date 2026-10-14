using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.Functions;

namespace NPOI.SS.Formula.Atp
{
	// Token: 0x02000232 RID: 562
	internal class Ifs : global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000DC0 RID: 3520 RVA: 0x0000253E File Offset: 0x0000073E
		private Ifs()
		{
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x000266A0 File Offset: 0x000248A0
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length % 2 != 0)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			for (int i = 0; i < args.Length; i += 2)
			{
				if (((global::NPOI.SS.Formula.Eval.BoolEval)args[i]).BooleanValue)
				{
					return args[i + 1];
				}
			}
			return global::NPOI.SS.Formula.Eval.ErrorEval.NA;
		}

		// Token: 0x04000621 RID: 1569
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction Instance = new global::NPOI.SS.Formula.Atp.Ifs();
	}
}
