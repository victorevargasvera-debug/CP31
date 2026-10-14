using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.Functions;

namespace NPOI.SS.Formula.Atp
{
	// Token: 0x02000231 RID: 561
	public class IfNa : global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000DBD RID: 3517 RVA: 0x0000253E File Offset: 0x0000073E
		private IfNa()
		{
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00026610 File Offset: 0x00024810
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length != 2)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			try
			{
				return global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[0], ec.RowIndex, ec.ColumnIndex);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				global::NPOI.SS.Formula.Eval.ValueEval errorEval = ex.GetErrorEval();
				if (errorEval != global::NPOI.SS.Formula.Eval.ErrorEval.NA)
				{
					return errorEval;
				}
			}
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				result = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[1], ec.RowIndex, ec.ColumnIndex);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex2)
			{
				result = ex2.GetErrorEval();
			}
			return result;
		}

		// Token: 0x04000620 RID: 1568
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction instance = new global::NPOI.SS.Formula.Atp.IfNa();
	}
}
