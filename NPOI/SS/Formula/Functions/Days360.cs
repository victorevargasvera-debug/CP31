using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000180 RID: 384
	public class Days360 : global::NPOI.SS.Formula.Functions.Var2or3ArgFunction
	{
		// Token: 0x06000B11 RID: 2833 RVA: 0x0001DEEC File Offset: 0x0001C0EC
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1)
		{
			double value;
			try
			{
				double d = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg0, srcRowIndex, srcColumnIndex);
				double d2 = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg1, srcRowIndex, srcColumnIndex);
				value = this.Evaluate(d, d2, false);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(value);
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0001DF38 File Offset: 0x0001C138
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0, global::NPOI.SS.Formula.Eval.ValueEval arg1, global::NPOI.SS.Formula.Eval.ValueEval arg2)
		{
			double value;
			try
			{
				double d = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg0, srcRowIndex, srcColumnIndex);
				double d2 = global::NPOI.SS.Formula.Functions.NumericFunction.SingleOperandEvaluate(arg1, srcRowIndex, srcColumnIndex);
				bool? flag = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToBoolean(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg2, srcRowIndex, srcColumnIndex), false);
				value = this.Evaluate(d, d2, flag != null && flag.Value);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(value);
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0001DFA8 File Offset: 0x0001C1A8
		private double Evaluate(double d0, double d1, bool method)
		{
			global::System.DateTime date = this.GetDate(d0);
			global::System.DateTime date2 = this.GetDate(d1);
			int[] startingDate = this.GetStartingDate(date, method);
			int[] endingDate = global::NPOI.SS.Formula.Functions.Days360.GetEndingDate(date2, date, method);
			return (double)(endingDate[0] * 360 + endingDate[1] * 30 + endingDate[2] - (startingDate[0] * 360 + startingDate[1] * 30 + startingDate[2]));
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0001DFFF File Offset: 0x0001C1FF
		private global::System.DateTime GetDate(double date)
		{
			return global::NPOI.SS.UserModel.DateUtil.GetJavaDate(date);
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0001E008 File Offset: 0x0001C208
		private int[] GetStartingDate(global::System.DateTime realStart, bool method)
		{
			global::System.DateTime date = realStart;
			int num = global::System.Math.Min(30, date.Day);
			if (!method && this.IsLastDayOfMonth(date))
			{
				num = 30;
			}
			return new int[]
			{
				date.Year,
				date.Month,
				num
			};
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x0001E054 File Offset: 0x0001C254
		private static int[] GetEndingDate(global::System.DateTime realEnd, global::System.DateTime realStart, bool method)
		{
			global::System.DateTime dateTime = realEnd;
			int year = dateTime.Year;
			int month = dateTime.Month;
			int num = global::System.Math.Min(30, dateTime.Day);
			if (!method && realEnd.Day == 31)
			{
				if (realStart.Day < 30)
				{
					dateTime = new global::System.DateTime(dateTime.Year, dateTime.Month, 1);
					dateTime = dateTime.AddMonths(1);
					year = dateTime.Year;
					month = dateTime.Month;
					num = 1;
				}
				else
				{
					num = 30;
				}
			}
			return new int[]
			{
				year,
				month,
				num
			};
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x0001E0E4 File Offset: 0x0001C2E4
		private global::System.DateTime GetEndingDateAccordingToStartingDate(double date, global::System.DateTime startingDate, bool method)
		{
			global::System.DateTime dateTime = global::NPOI.SS.UserModel.DateUtil.GetJavaDate(date, false);
			if (this.IsLastDayOfMonth(dateTime) && startingDate.Day < 30)
			{
				dateTime = this.GetFirstDayOfNextMonth(dateTime);
			}
			return dateTime;
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x0001E118 File Offset: 0x0001C318
		private bool IsLastDayOfMonth(global::System.DateTime date)
		{
			return date.AddDays(1.0).Month != date.Month;
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0001E14C File Offset: 0x0001C34C
		private global::System.DateTime GetFirstDayOfNextMonth(global::System.DateTime date)
		{
			global::System.DateTime result;
			if (date.Month < 12)
			{
				result = new global::System.DateTime(date.Year, date.Month + 1, 1, date.Hour, date.Minute, date.Second);
			}
			else
			{
				result = new global::System.DateTime(date.Year + 1, 1, 1, date.Hour, date.Minute, date.Second);
			}
			return result;
		}
	}
}
