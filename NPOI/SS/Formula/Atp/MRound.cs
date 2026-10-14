using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.Functions;

namespace NPOI.SS.Formula.Atp
{
	// Token: 0x0200023C RID: 572
	internal class MRound : global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000DEC RID: 3564 RVA: 0x0000253E File Offset: 0x0000073E
		private MRound()
		{
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00027848 File Offset: 0x00025A48
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length != 2)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			global::NPOI.SS.Formula.Eval.ValueEval result;
			try
			{
				double num = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[0], ec.RowIndex, ec.ColumnIndex));
				double num2 = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(args[1], ec.RowIndex, ec.ColumnIndex));
				double num3;
				if (num2 == 0.0)
				{
					num3 = 0.0;
				}
				else
				{
					if (num * num2 < 0.0)
					{
						throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR);
					}
					num3 = num2 * global::System.Math.Round(num / num2, global::System.MidpointRounding.AwayFromZero);
				}
				global::NPOI.SS.Formula.Functions.NumericFunction.CheckValue(num3);
				result = new global::NPOI.SS.Formula.Eval.NumberEval(num3);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				result = ex.GetErrorEval();
			}
			return result;
		}

		// Token: 0x0400062F RID: 1583
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction Instance = new global::NPOI.SS.Formula.Atp.MRound();
	}
}
