using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.Functions;

namespace NPOI.SS.Formula.Atp
{
	// Token: 0x02000230 RID: 560
	internal class IfError : global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000DB9 RID: 3513 RVA: 0x0000253E File Offset: 0x0000073E
		private IfError()
		{
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00026588 File Offset: 0x00024788
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length != 2)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				result = global::NPOI.SS.Formula.Atp.IfError.EvaluateInternal(args[0], args[1], ec.RowIndex, ec.ColumnIndex);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x000265D8 File Offset: 0x000247D8
		private static global::NPOI.SS.Formula.Eval.ValueEval EvaluateInternal(global::NPOI.SS.Formula.Eval.ValueEval arg, global::NPOI.SS.Formula.Eval.ValueEval iferror, int srcCellRow, int srcCellCol)
		{
			arg = global::NPOI.SS.Formula.WorkbookEvaluator.DereferenceResult(arg, srcCellRow, srcCellCol);
			if (!(arg is global::NPOI.SS.Formula.Eval.ErrorEval))
			{
				return arg;
			}
			if (iferror is global::NPOI.SS.Formula.Eval.MissingArgEval)
			{
				return new global::NPOI.SS.Formula.Eval.StringEval(string.Empty);
			}
			return iferror;
		}

		// Token: 0x0400061F RID: 1567
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction Instance = new global::NPOI.SS.Formula.Atp.IfError();
	}
}
