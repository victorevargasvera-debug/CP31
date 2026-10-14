using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.Functions;

namespace NPOI.SS.Formula.Atp
{
	// Token: 0x0200023E RID: 574
	internal class RandBetween : global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000DF3 RID: 3571 RVA: 0x000279C1 File Offset: 0x00025BC1
		private RandBetween()
		{
			this._rnd = new global::System.Random();
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x000279D4 File Offset: 0x00025BD4
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length != 2)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			double num;
			double num2;
			try
			{
				num = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[0], ec.RowIndex, ec.ColumnIndex));
				num2 = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[1], ec.RowIndex, ec.ColumnIndex));
				if (num > num2)
				{
					return global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
				}
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			num = global::System.Math.Ceiling(num);
			num2 = global::System.Math.Floor(num2);
			if (num > num2)
			{
				num2 = num;
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(num + (double)((int)(this._rnd.NextDouble() * (num2 - num + 1.0))));
		}

		// Token: 0x04000633 RID: 1587
		private global::System.Random _rnd;

		// Token: 0x04000634 RID: 1588
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction Instance = new global::NPOI.SS.Formula.Atp.RandBetween();
	}
}
