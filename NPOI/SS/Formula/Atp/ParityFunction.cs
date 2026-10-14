using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.Functions;

namespace NPOI.SS.Formula.Atp
{
	// Token: 0x0200023D RID: 573
	public class ParityFunction : global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000DEF RID: 3567 RVA: 0x00027908 File Offset: 0x00025B08
		private ParityFunction(int desiredParity)
		{
			this._desiredParity = desiredParity;
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00027918 File Offset: 0x00025B18
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length != 1)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			int num;
			try
			{
				num = global::NPOI.SS.Formula.Atp.ParityFunction.EvaluateArgParity(args[0], ec.RowIndex, ec.ColumnIndex);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return global::NPOI.SS.Formula.Eval.BoolEval.ValueOf(num == this._desiredParity);
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00027974 File Offset: 0x00025B74
		private static int EvaluateArgParity(global::NPOI.SS.Formula.Eval.ValueEval arg, int srcCellRow, int srcCellCol)
		{
			double num = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg, srcCellRow, srcCellCol));
			if (num < 0.0)
			{
				num = -num;
			}
			return (int)((long)global::System.Math.Floor(num) & 1L);
		}

		// Token: 0x04000630 RID: 1584
		public static readonly global::NPOI.SS.Formula.Functions.FreeRefFunction IS_EVEN = new global::NPOI.SS.Formula.Atp.ParityFunction(0);

		// Token: 0x04000631 RID: 1585
		public static readonly global::NPOI.SS.Formula.Functions.FreeRefFunction IS_ODD = new global::NPOI.SS.Formula.Atp.ParityFunction(1);

		// Token: 0x04000632 RID: 1586
		private int _desiredParity;
	}
}
