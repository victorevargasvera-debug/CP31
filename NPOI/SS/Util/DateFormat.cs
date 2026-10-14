using System;
using System.Globalization;

namespace NPOI.SS.Util
{
	// Token: 0x02000021 RID: 33
	public abstract class DateFormat : global::NPOI.SS.Util.FormatBase
	{
		// Token: 0x0600016C RID: 364 RVA: 0x00006ECC File Offset: 0x000050CC
		public static string GetDateTimePattern(int dateStyle, int timeStyle, global::System.Globalization.CultureInfo locale)
		{
			global::System.Globalization.DateTimeFormatInfo dateTimeFormat = locale.DateTimeFormat;
			string datePattern = global::NPOI.SS.Util.DateFormat.GetDatePattern(dateStyle, locale);
			string timePattern = global::NPOI.SS.Util.DateFormat.GetTimePattern(timeStyle, locale);
			if (locale.TextInfo.IsRightToLeft)
			{
				return timePattern + " " + datePattern;
			}
			return datePattern + " " + timePattern;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00006F18 File Offset: 0x00005118
		public static string GetDatePattern(int dateStyle, global::System.Globalization.CultureInfo locale)
		{
			global::System.Globalization.DateTimeFormatInfo dateTimeFormat = locale.DateTimeFormat;
			switch (dateStyle)
			{
			case 0:
				return dateTimeFormat.LongDatePattern;
			case 1:
				return dateTimeFormat.LongDatePattern.Replace("dddd,", "").Trim();
			case 2:
				return dateTimeFormat.ShortDatePattern;
			case 3:
				return dateTimeFormat.ShortDatePattern.Replace("yyyy", "yy").Replace("YYYY", "YY");
			default:
				return dateTimeFormat.ShortDatePattern;
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00006F98 File Offset: 0x00005198
		public static string GetTimePattern(int timeStyle, global::System.Globalization.CultureInfo locale)
		{
			global::System.Globalization.DateTimeFormatInfo dateTimeFormat = locale.DateTimeFormat;
			if (timeStyle > 2 && timeStyle == 3)
			{
				return dateTimeFormat.ShortTimePattern;
			}
			return dateTimeFormat.LongTimePattern;
		}

		// Token: 0x04000075 RID: 117
		public const int FULL = 0;

		// Token: 0x04000076 RID: 118
		public const int LONG = 1;

		// Token: 0x04000077 RID: 119
		public const int MEDIUM = 2;

		// Token: 0x04000078 RID: 120
		public const int SHORT = 3;

		// Token: 0x04000079 RID: 121
		public const int DEFAULT = 2;
	}
}
