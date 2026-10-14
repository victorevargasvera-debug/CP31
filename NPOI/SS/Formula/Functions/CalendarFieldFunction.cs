using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000172 RID: 370
	public class CalendarFieldFunction : global::NPOI.SS.Formula.Functions.Fixed1ArgFunction
	{
		// Token: 0x06000AE0 RID: 2784 RVA: 0x0001D4FC File Offset: 0x0001B6FC
		private CalendarFieldFunction(int dateFieldId)
		{
			this._dateFieldId = dateFieldId;
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0001D50C File Offset: 0x0001B70C
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0)
		{
			double num;
			try
			{
				num = global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToDouble(global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg0, srcRowIndex, srcColumnIndex));
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			if (num < 0.0)
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR;
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval((double)this.GetCalField(num));
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x0001D564 File Offset: 0x0001B764
		private int GetCalField(double serialDate)
		{
			if ((int)serialDate == 0)
			{
				switch (this._dateFieldId)
				{
				case 1:
					return 1900;
				case 2:
					return 1;
				case 3:
					return 0;
				}
			}
			global::System.DateTime javaCalendar = global::NPOI.SS.UserModel.DateUtil.GetJavaCalendar(serialDate + 5.78125E-06, false);
			int result = 0;
			if (this._dateFieldId == 1)
			{
				result = javaCalendar.Year;
			}
			else if (this._dateFieldId == 2)
			{
				result = javaCalendar.Month;
			}
			else if (this._dateFieldId == 3)
			{
				result = javaCalendar.Day;
			}
			else if (this._dateFieldId == 4)
			{
				result = javaCalendar.Hour;
			}
			else if (this._dateFieldId == 5)
			{
				result = javaCalendar.Minute;
			}
			else if (this._dateFieldId == 6)
			{
				result = javaCalendar.Second;
			}
			return result;
		}

		// Token: 0x0400054B RID: 1355
		public const int YEAR_ID = 1;

		// Token: 0x0400054C RID: 1356
		public const int MONTH_ID = 2;

		// Token: 0x0400054D RID: 1357
		public const int DAY_OF_MONTH_ID = 3;

		// Token: 0x0400054E RID: 1358
		public const int HOUR_OF_DAY_ID = 4;

		// Token: 0x0400054F RID: 1359
		public const int MINUTE_ID = 5;

		// Token: 0x04000550 RID: 1360
		public const int SECOND_ID = 6;

		// Token: 0x04000551 RID: 1361
		public static readonly global::NPOI.SS.Formula.Functions.Function YEAR = new global::NPOI.SS.Formula.Functions.CalendarFieldFunction(1);

		// Token: 0x04000552 RID: 1362
		public static readonly global::NPOI.SS.Formula.Functions.Function MONTH = new global::NPOI.SS.Formula.Functions.CalendarFieldFunction(2);

		// Token: 0x04000553 RID: 1363
		public static readonly global::NPOI.SS.Formula.Functions.Function DAY = new global::NPOI.SS.Formula.Functions.CalendarFieldFunction(3);

		// Token: 0x04000554 RID: 1364
		public static readonly global::NPOI.SS.Formula.Functions.Function HOUR = new global::NPOI.SS.Formula.Functions.CalendarFieldFunction(4);

		// Token: 0x04000555 RID: 1365
		public static readonly global::NPOI.SS.Formula.Functions.Function MINUTE = new global::NPOI.SS.Formula.Functions.CalendarFieldFunction(5);

		// Token: 0x04000556 RID: 1366
		public static readonly global::NPOI.SS.Formula.Functions.Function SECOND = new global::NPOI.SS.Formula.Functions.CalendarFieldFunction(6);

		// Token: 0x04000557 RID: 1367
		private int _dateFieldId;
	}
}
