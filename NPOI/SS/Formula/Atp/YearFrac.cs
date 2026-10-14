using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula.Atp
{
	// Token: 0x0200023F RID: 575
	internal class YearFrac : global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000DF6 RID: 3574 RVA: 0x0000253E File Offset: 0x0000073E
		private YearFrac()
		{
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00027A90 File Offset: 0x00025C90
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			int rowIndex = ec.RowIndex;
			int columnIndex = ec.ColumnIndex;
			double value;
			try
			{
				int basis = 0;
				int num = args.Length;
				if (num != 2)
				{
					if (num != 3)
					{
						return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
					}
					basis = global::NPOI.SS.Formula.Atp.YearFrac.EvaluateIntArg(args[2], rowIndex, columnIndex);
				}
				double pStartDateVal = global::NPOI.SS.Formula.Atp.YearFrac.EvaluateDateArg(args[0], rowIndex, columnIndex);
				double pEndDateVal = global::NPOI.SS.Formula.Atp.YearFrac.EvaluateDateArg(args[1], rowIndex, columnIndex);
				value = global::NPOI.SS.Formula.Atp.YearFracCalculator.Calculate(pStartDateVal, pEndDateVal, basis);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(value);
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00027B18 File Offset: 0x00025D18
		private static double EvaluateDateArg(global::NPOI.SS.Formula.Eval.ValueEval arg, int srcCellRow, int srcCellCol)
		{
			global::NPOI.SS.Formula.Eval.ValueEval singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg, srcCellRow, (int)((short)srcCellCol));
			if (!(singleValue is global::NPOI.SS.Formula.Eval.StringEval))
			{
				return global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(singleValue);
			}
			string stringValue = ((global::NPOI.SS.Formula.Eval.StringEval)singleValue).StringValue;
			double num = global::NPOI.SS.Formula.Eval.OperandResolver.ParseDouble(stringValue);
			if (!double.IsNaN(num))
			{
				return num;
			}
			return global::NPOI.SS.UserModel.DateUtil.GetExcelDate(global::NPOI.SS.Formula.Atp.DateParser.ParseDate(stringValue), false);
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x0001D6F4 File Offset: 0x0001B8F4
		private static int EvaluateIntArg(global::NPOI.SS.Formula.Eval.ValueEval arg, int srcCellRow, int srcCellCol)
		{
			return global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToInt(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg, srcCellRow, srcCellCol));
		}

		// Token: 0x04000635 RID: 1589
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction instance = new global::NPOI.SS.Formula.Atp.YearFrac();
	}
}
