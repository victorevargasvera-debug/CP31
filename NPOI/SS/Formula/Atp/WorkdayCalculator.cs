using System;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula.Atp
{
	// Token: 0x02000238 RID: 568
	public class WorkdayCalculator
	{
		// Token: 0x06000DD4 RID: 3540 RVA: 0x0000253E File Offset: 0x0000073E
		private WorkdayCalculator()
		{
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00026D64 File Offset: 0x00024F64
		public int CalculateWorkdays(double start, double end, double[] holidays)
		{
			int num = this.PastDaysOfWeek(start, end, global::System.DayOfWeek.Saturday);
			int num2 = this.PastDaysOfWeek(start, end, global::System.DayOfWeek.Sunday);
			int num3 = this.CalculateNonWeekendHolidays(start, end, holidays);
			return (int)(end - start + 1.0) - num - num2 - num3;
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00026DA4 File Offset: 0x00024FA4
		public global::System.DateTime CalculateWorkdays(double start, int workdays, double[] holidays)
		{
			global::System.DateTime javaDate = global::NPOI.SS.UserModel.DateUtil.GetJavaDate(start);
			int num = (workdays < 0) ? -1 : 1;
			global::System.DateTime dateTime = javaDate;
			double num2 = global::NPOI.SS.UserModel.DateUtil.GetExcelDate(dateTime);
			while (workdays != 0)
			{
				dateTime = dateTime.AddDays((double)num);
				num2 += (double)num;
				if (dateTime.DayOfWeek != global::System.DayOfWeek.Saturday && dateTime.DayOfWeek != global::System.DayOfWeek.Sunday && !this.IsHoliday(num2, holidays))
				{
					workdays -= num;
				}
			}
			return dateTime;
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00026E00 File Offset: 0x00025000
		public int PastDaysOfWeek(double start, double end, global::System.DayOfWeek dayOfWeek)
		{
			int num = 0;
			int i = (int)global::System.Math.Floor((start < end) ? start : end);
			int num2 = (int)global::System.Math.Floor((end > start) ? end : start);
			while (i <= num2)
			{
				if (global::NPOI.SS.UserModel.DateUtil.GetJavaDate((double)i).DayOfWeek == dayOfWeek)
				{
					num++;
				}
				i++;
			}
			if (start >= end)
			{
				return -num;
			}
			return num;
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00026E58 File Offset: 0x00025058
		private int CalculateNonWeekendHolidays(double start, double end, double[] holidays)
		{
			int num = 0;
			double start2 = (start < end) ? start : end;
			double end2 = (end > start) ? end : start;
			for (int i = 0; i < holidays.Length; i++)
			{
				if (this.IsInARange(start2, end2, holidays[i]) && !this.IsWeekend(holidays[i]))
				{
					num++;
				}
			}
			if (start >= end)
			{
				return -num;
			}
			return num;
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00026EAC File Offset: 0x000250AC
		private bool IsWeekend(double aDate)
		{
			global::System.DateTime javaDate = global::NPOI.SS.UserModel.DateUtil.GetJavaDate(aDate);
			return javaDate.DayOfWeek == global::System.DayOfWeek.Saturday || javaDate.DayOfWeek == global::System.DayOfWeek.Sunday;
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00026ED8 File Offset: 0x000250D8
		private bool IsHoliday(double aDate, double[] holidays)
		{
			for (int i = 0; i < holidays.Length; i++)
			{
				if (global::System.Math.Round(holidays[i]) == global::System.Math.Round(aDate))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00026F06 File Offset: 0x00025106
		private int IsNonWorkday(double aDate, double[] holidays)
		{
			if (!this.IsWeekend(aDate) && !this.IsHoliday(aDate, holidays))
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x00026F1E File Offset: 0x0002511E
		private bool IsInARange(double start, double end, double aDate)
		{
			return aDate >= start && aDate <= end;
		}

		// Token: 0x04000629 RID: 1577
		public static global::NPOI.SS.Formula.Atp.WorkdayCalculator instance = new global::NPOI.SS.Formula.Atp.WorkdayCalculator();
	}
}
