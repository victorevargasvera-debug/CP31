using System;
using System.Globalization;

namespace NPOI.Util
{
	// Token: 0x0200027D RID: 637
	public class LocaleUtil
	{
		// Token: 0x06001113 RID: 4371 RVA: 0x00033E17 File Offset: 0x00032017
		public static void SetUserTimeZone(global::System.TimeZoneInfo timezone)
		{
			global::NPOI.Util.LocaleUtil.userTimeZone = timezone;
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00033E1F File Offset: 0x0003201F
		public static global::System.TimeZoneInfo GetUserTimeZoneInfo()
		{
			global::System.TimeZoneInfo result;
			if ((result = global::NPOI.Util.LocaleUtil.userTimeZone) == null)
			{
				result = (global::NPOI.Util.LocaleUtil.userTimeZone = global::System.TimeZoneInfo.Local);
			}
			return result;
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x00033E35 File Offset: 0x00032035
		public static void SetUserLocale(global::System.Globalization.CultureInfo locale)
		{
			global::NPOI.Util.LocaleUtil.userLocale = locale;
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x00033E3D File Offset: 0x0003203D
		public static global::System.Globalization.CultureInfo GetUserLocale()
		{
			global::System.Globalization.CultureInfo result;
			if ((result = global::NPOI.Util.LocaleUtil.userLocale) == null)
			{
				result = (global::NPOI.Util.LocaleUtil.userLocale = global::System.Globalization.CultureInfo.CurrentCulture);
			}
			return result;
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x00033E53 File Offset: 0x00032053
		public static global::System.DateTime GetLocaleCalendar()
		{
			return global::NPOI.Util.LocaleUtil.GetLocaleCalendar(global::NPOI.Util.LocaleUtil.GetUserTimeZoneInfo());
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x00033E5F File Offset: 0x0003205F
		public static global::System.DateTime GetLocaleCalendar(int year, int month, int day)
		{
			return global::NPOI.Util.LocaleUtil.GetLocaleCalendar(year, month, day, 0, 0, 0);
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x00033E6C File Offset: 0x0003206C
		public static global::System.DateTime GetLocaleCalendar(int year, int month, int day, int hour, int minute, int second)
		{
			if (month < 0 || day < 0)
			{
				throw new global::System.ArgumentOutOfRangeException();
			}
			global::System.DateTime result;
			if (day == 0)
			{
				result = new global::System.DateTime(year, month, 1, hour, minute, second);
				result = result.AddDays(-1.0);
			}
			else
			{
				result = new global::System.DateTime(year, month, day, hour, minute, second);
			}
			return result;
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x00033EBC File Offset: 0x000320BC
		public static global::System.DateTime GetLocaleCalendar(global::System.TimeZoneInfo timeZone)
		{
			return global::System.TimeZoneInfo.ConvertTime(global::System.DateTime.Now, timeZone);
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x00033EC9 File Offset: 0x000320C9
		[global::System.Obsolete("The class TimeZone was marked obsolete, Use the Overload using TimeZoneInfo instead.")]
		public static global::System.DateTime GetLocaleCalendar(global::System.TimeZone timeZone)
		{
			return timeZone.ToLocalTime(global::System.DateTime.Now);
		}

		// Token: 0x04000748 RID: 1864
		public static global::System.TimeZoneInfo TIMEZONE_UTC = global::System.TimeZoneInfo.Utc;

		// Token: 0x04000749 RID: 1865
		public static string CHARSET_1252 = global::NPOI.Util.CodePageUtil.CodepageToEncoding(1252);

		// Token: 0x0400074A RID: 1866
		[global::System.ThreadStatic]
		private static global::System.TimeZoneInfo userTimeZone;

		// Token: 0x0400074B RID: 1867
		[global::System.ThreadStatic]
		private static global::System.Globalization.CultureInfo userLocale;
	}
}
