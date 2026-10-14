using System;
using System.Globalization;
using NPOI.SS.Formula.Eval;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000156 RID: 342
	public class WeekNum : global::NPOI.SS.Formula.Functions.Fixed2ArgFunction, global::NPOI.SS.Formula.Functions.FreeRefFunction
	{
		// Token: 0x06000A9C RID: 2716 RVA: 0x0001CB84 File Offset: 0x0001AD84
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval serialNumVE, global::NPOI.SS.Formula.Eval.ValueEval returnTypeVE)
		{
			double date = 0.0;
			try
			{
				date = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(serialNumVE, srcRowIndex, srcColumnIndex);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			global::System.DateTime javaDate = global::NPOI.SS.UserModel.DateUtil.GetJavaDate(date, false);
			int num = 0;
			try
			{
				num = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToInt(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(returnTypeVE, srcRowIndex, srcColumnIndex));
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
			}
			if (num != 1 && num != 2)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval((double)this.getWeekNo(javaDate, num));
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x0001CC10 File Offset: 0x0001AE10
		public int getWeekNo(global::System.DateTime dt, int weekStartOn)
		{
			global::System.Globalization.GregorianCalendar gregorianCalendar = new global::System.Globalization.GregorianCalendar();
			int weekOfYear;
			if (weekStartOn == 1)
			{
				weekOfYear = gregorianCalendar.GetWeekOfYear(dt, global::System.Globalization.CalendarWeekRule.FirstDay, global::System.DayOfWeek.Sunday);
			}
			else
			{
				weekOfYear = gregorianCalendar.GetWeekOfYear(dt, global::System.Globalization.CalendarWeekRule.FirstDay, global::System.DayOfWeek.Monday);
			}
			return weekOfYear;
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x0001A72C File Offset: 0x0001892C
		public global::NPOI.SS.Formula.Eval.ValueEval Evaluate(global::NPOI.SS.Formula.Eval.ValueEval[] args, global::NPOI.SS.Formula.OperationEvaluationContext ec)
		{
			if (args.Length == 2)
			{
				return this.Evaluate(ec.RowIndex, ec.ColumnIndex, args[0], args[1]);
			}
			return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
		}

		// Token: 0x04000534 RID: 1332
		public static global::NPOI.SS.Formula.Functions.FreeRefFunction instance = new global::NPOI.SS.Formula.Functions.WeekNum();
	}
}
