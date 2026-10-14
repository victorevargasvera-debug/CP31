using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000152 RID: 338
	public class AverageIf : global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000A8B RID: 2699 RVA: 0x0001C74E File Offset: 0x0001A94E
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length > 3 || args.Length < 2)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			return global::NPOI.SS.Formula.Functions.AverageIfs.instance.Evaluate(new global::NPOI.SS.Formula.Eval.ValueEval[]
			{
				this.GetSumRange(args),
				args[0],
				args[1]
			}, ec);
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x0001C78C File Offset: 0x0001A98C
		private global::NPOI.SS.Formula.Eval.ValueEval GetSumRange(global::NPOI.SS.Formula.Eval.ValueEval[] args)
		{
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				result = args[2];
			}
			catch
			{
				result = args[0];
			}
			return result;
		}

		// Token: 0x04000531 RID: 1329
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction instance = new global::NPOI.SS.Formula.Functions.AverageIf();
	}
}
