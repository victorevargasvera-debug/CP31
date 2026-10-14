using System;
using NPOI.SS.Formula.Eval;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula.Atp
{
	// Token: 0x02000240 RID: 576
	public class YearFracCalculator
	{
		// Token: 0x06000DFB RID: 3579 RVA: 0x00027B74 File Offset: 0x00025D74
		public static double Calculate(double pStartDateVal, double pEndDateVal, int basis)
		{
			if (basis < 0 || basis >= 5)
			{
				throw new global::NPOI.SS.Formula.Eval.EvaluationException(global::NPOI.SS.Formula.Eval.ErrorEval.NUM_ERROR);
			}
			int num = (int)global::System.Math.Floor(pStartDateVal);
			int num2 = (int)global::System.Math.Floor(pEndDateVal);
			if (num == num2)
			{
				return 0.0;
			}
			if (num > num2)
			{
				int num3 = num;
				num = num2;
				num2 = num3;
			}
			switch (basis)
			{
			case 0:
				return global::NPOI.SS.Formula.Atp.YearFracCalculator.Basis0(num, num2);
			case 1:
				return global::NPOI.SS.Formula.Atp.YearFracCalculator.Basis1(num, num2);
			case 2:
				return global::NPOI.SS.Formula.Atp.YearFracCalculator.Basis2(num, num2);
			case 3:
				return global::NPOI.SS.Formula.Atp.YearFracCalculator.Basis3((double)num, (double)num2);
			case 4:
				return global::NPOI.SS.Formula.Atp.YearFracCalculator.Basis4(num, num2);
			default:
				throw new global::System.InvalidOperationException("cannot happen");
			}
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00027C0C File Offset: 0x00025E0C
		public static double Basis0(int startDateVal, int endDateVal)
		{
			global::NPOI.SS.Formula.Atp.YearFracCalculator.SimpleDate simpleDate = global::NPOI.SS.Formula.Atp.YearFracCalculator.CreateDate(startDateVal);
			global::NPOI.SS.Formula.Atp.YearFracCalculator.SimpleDate simpleDate2 = global::NPOI.SS.Formula.Atp.YearFracCalculator.CreateDate(endDateVal);
			int num = simpleDate.day;
			int num2 = simpleDate2.day;
			if (num == 31 && num2 == 31)
			{
				num = 30;
				num2 = 30;
			}
			else if (num == 31)
			{
				num = 30;
			}
			else if (num == 30 && num2 == 31)
			{
				num2 = 30;
			}
			else if (simpleDate.month == 2 && global::NPOI.SS.Formula.Atp.YearFracCalculator.IsLastDayOfMonth(simpleDate))
			{
				num = 30;
				if (simpleDate2.month == 2 && global::NPOI.SS.Formula.Atp.YearFracCalculator.IsLastDayOfMonth(simpleDate2))
				{
					num2 = 30;
				}
			}
			return global::NPOI.SS.Formula.Atp.YearFracCalculator.CalculateAdjusted(simpleDate, simpleDate2, num, num2);
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00027C94 File Offset: 0x00025E94
		public static double Basis1(int startDateVal, int endDateVal)
		{
			global::NPOI.SS.Formula.Atp.YearFracCalculator.SimpleDate simpleDate = global::NPOI.SS.Formula.Atp.YearFracCalculator.CreateDate(startDateVal);
			global::NPOI.SS.Formula.Atp.YearFracCalculator.SimpleDate simpleDate2 = global::NPOI.SS.Formula.Atp.YearFracCalculator.CreateDate(endDateVal);
			double num;
			if (global::NPOI.SS.Formula.Atp.YearFracCalculator.IsGreaterThanOneYear(simpleDate, simpleDate2))
			{
				num = global::NPOI.SS.Formula.Atp.YearFracCalculator.AverageYearLength(simpleDate.year, simpleDate2.year);
			}
			else if (global::NPOI.SS.Formula.Atp.YearFracCalculator.ShouldCountFeb29(simpleDate, simpleDate2))
			{
				num = 366.0;
			}
			else
			{
				num = 365.0;
			}
			return global::NPOI.SS.Formula.Atp.YearFracCalculator.DateDiff(simpleDate.ticks, simpleDate2.ticks) / num;
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x00027CFE File Offset: 0x00025EFE
		public static double Basis2(int startDateVal, int endDateVal)
		{
			return (double)(endDateVal - startDateVal) / 360.0;
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00027D0E File Offset: 0x00025F0E
		public static double Basis3(double startDateVal, double endDateVal)
		{
			return (endDateVal - startDateVal) / 365.0;
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00027D20 File Offset: 0x00025F20
		public static double Basis4(int startDateVal, int endDateVal)
		{
			global::NPOI.SS.Formula.Atp.YearFracCalculator.SimpleDate simpleDate = global::NPOI.SS.Formula.Atp.YearFracCalculator.CreateDate(startDateVal);
			global::NPOI.SS.Formula.Atp.YearFracCalculator.SimpleDate simpleDate2 = global::NPOI.SS.Formula.Atp.YearFracCalculator.CreateDate(endDateVal);
			int num = simpleDate.day;
			int num2 = simpleDate2.day;
			if (num == 31)
			{
				num = 30;
			}
			if (num2 == 31)
			{
				num2 = 30;
			}
			return global::NPOI.SS.Formula.Atp.YearFracCalculator.CalculateAdjusted(simpleDate, simpleDate2, num, num2);
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00027D60 File Offset: 0x00025F60
		private static double CalculateAdjusted(global::NPOI.SS.Formula.Atp.YearFracCalculator.SimpleDate startDate, global::NPOI.SS.Formula.Atp.YearFracCalculator.SimpleDate endDate, int date1day, int date2day)
		{
			return (double)((endDate.year - startDate.year) * 360 + (endDate.month - startDate.month) * 30 + (date2day - date1day)) / 360.0;
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x00027D95 File Offset: 0x00025F95
		private static bool IsLastDayOfMonth(global::NPOI.SS.Formula.Atp.YearFracCalculator.SimpleDate date)
		{
			return date.day >= 28 && date.day == global::NPOI.SS.Formula.Atp.YearFracCalculator.GetLastDayOfMonth(date);
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x00027DB4 File Offset: 0x00025FB4
		private static int GetLastDayOfMonth(global::NPOI.SS.Formula.Atp.YearFracCalculator.SimpleDate date)
		{
			switch (date.month)
			{
			case 1:
			case 3:
			case 5:
			case 7:
			case 8:
			case 10:
			case 12:
				return 31;
			case 4:
			case 6:
			case 9:
			case 11:
				return 30;
			}
			if (global::NPOI.SS.Formula.Atp.YearFracCalculator.IsLeapYear(date.year))
			{
				return 29;
			}
			return 28;
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00027E1C File Offset: 0x0002601C
		private static bool ShouldCountFeb29(global::NPOI.SS.Formula.Atp.YearFracCalculator.SimpleDate start, global::NPOI.SS.Formula.Atp.YearFracCalculator.SimpleDate end)
		{
			bool flag = global::NPOI.SS.Formula.Atp.YearFracCalculator.IsLeapYear(start.year);
			if (flag && start.year == end.year)
			{
				return true;
			}
			bool flag2 = global::NPOI.SS.Formula.Atp.YearFracCalculator.IsLeapYear(end.year);
			if (!flag && !flag2)
			{
				return false;
			}
			if (flag)
			{
				int month = start.month;
				return month - 1 <= 1;
			}
			if (flag2)
			{
				int month = end.month;
				return month != 1 && (month != 2 || end.day == 29);
			}
			return false;
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00027E94 File Offset: 0x00026094
		private static double DateDiff(long startDateTicks, long endDateTicks)
		{
			return new global::System.TimeSpan(endDateTicks - startDateTicks).TotalDays;
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00027EB4 File Offset: 0x000260B4
		private static double AverageYearLength(int startYear, int endYear)
		{
			int num = 0;
			for (int i = startYear; i <= endYear; i++)
			{
				num += 365;
				if (global::NPOI.SS.Formula.Atp.YearFracCalculator.IsLeapYear(i))
				{
					num++;
				}
			}
			double num2 = (double)(endYear - startYear + 1);
			return (double)num / num2;
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00027EEE File Offset: 0x000260EE
		private static bool IsLeapYear(int i)
		{
			return i % 4 == 0 && (i % 400 == 0 || i % 100 != 0);
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00027F0C File Offset: 0x0002610C
		private static bool IsGreaterThanOneYear(global::NPOI.SS.Formula.Atp.YearFracCalculator.SimpleDate start, global::NPOI.SS.Formula.Atp.YearFracCalculator.SimpleDate end)
		{
			return start.year != end.year && (start.year + 1 != end.year || (start.month <= end.month && (start.month < end.month || start.day < end.day)));
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00027F69 File Offset: 0x00026169
		private static global::NPOI.SS.Formula.Atp.YearFracCalculator.SimpleDate CreateDate(int dayCount)
		{
			return new global::NPOI.SS.Formula.Atp.YearFracCalculator.SimpleDate(global::NPOI.SS.UserModel.DateUtil.SetCalendar(dayCount, 0, false, false));
		}

		// Token: 0x04000636 RID: 1590
		private const int MS_PER_HOUR = 3600000;

		// Token: 0x04000637 RID: 1591
		private const int MS_PER_DAY = 86400000;

		// Token: 0x04000638 RID: 1592
		private const int DAYS_PER_NORMAL_YEAR = 365;

		// Token: 0x04000639 RID: 1593
		private const int DAYS_PER_LEAP_YEAR = 366;

		// Token: 0x0400063A RID: 1594
		private const int LONG_MONTH_LEN = 31;

		// Token: 0x0400063B RID: 1595
		private const int SHORT_MONTH_LEN = 30;

		// Token: 0x0400063C RID: 1596
		private const int SHORT_FEB_LEN = 28;

		// Token: 0x0400063D RID: 1597
		private const int LONG_FEB_LEN = 29;

		// Token: 0x02000593 RID: 1427
		private class SimpleDate
		{
			// Token: 0x06003452 RID: 13394 RVA: 0x000A2CF1 File Offset: 0x000A0EF1
			public SimpleDate(global::System.DateTime date)
			{
				this.year = date.Year;
				this.month = date.Month;
				this.day = date.Day;
				this.ticks = date.Ticks;
			}

			// Token: 0x04001902 RID: 6402
			public const int JANUARY = 1;

			// Token: 0x04001903 RID: 6403
			public const int FEBRUARY = 2;

			// Token: 0x04001904 RID: 6404
			public int year;

			// Token: 0x04001905 RID: 6405
			public int month;

			// Token: 0x04001906 RID: 6406
			public int day;

			// Token: 0x04001907 RID: 6407
			public long ticks;
		}
	}
}
