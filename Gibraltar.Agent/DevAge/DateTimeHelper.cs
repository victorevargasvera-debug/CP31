using System;

namespace DevAge
{
	// Token: 0x0200029E RID: 670
	internal class DateTimeHelper
	{
		// Token: 0x0600219F RID: 8607 RVA: 0x00077BCC File Offset: 0x00075DCC
		public static int YearsDifference(global::System.DateTime dateA, global::System.DateTime dateB)
		{
			return global::DevAge.DateTimeHelper.MonthsDifference(dateA, dateB) / 12;
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x00077BD8 File Offset: 0x00075DD8
		public static int MonthsDifference(global::System.DateTime dateA, global::System.DateTime dateB)
		{
			if (dateA == dateB)
			{
				return 0;
			}
			if (!(dateA > dateB))
			{
				return -global::DevAge.DateTimeHelper.MonthsDifference(dateB, dateA);
			}
			int num = dateA.Year - dateB.Year;
			int num2 = num * 12 + (dateA.Month - dateB.Month);
			if (num2 == 0)
			{
				return num2;
			}
			global::System.DateTime d = dateB.AddMonths(num2);
			bool flag = (dateA - d).Ticks >= 0L;
			if (flag)
			{
				return num2;
			}
			return num2 - 1;
		}
	}
}
