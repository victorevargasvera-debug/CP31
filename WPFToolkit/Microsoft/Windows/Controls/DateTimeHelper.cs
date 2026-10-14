using System;
using System.Globalization;
using System.Windows;
using System.Windows.Markup;

namespace Microsoft.Windows.Controls
{
	// Token: 0x0200007F RID: 127
	internal static class DateTimeHelper
	{
		// Token: 0x060008DC RID: 2268 RVA: 0x00027EC8 File Offset: 0x000260C8
		public static global::System.DateTime? AddDays(global::System.DateTime time, int days)
		{
			global::System.DateTime? result;
			try
			{
				result = new global::System.DateTime?(global::Microsoft.Windows.Controls.DateTimeHelper.cal.AddDays(time, days));
			}
			catch (global::System.ArgumentException)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00027F08 File Offset: 0x00026108
		public static global::System.DateTime? AddMonths(global::System.DateTime time, int months)
		{
			global::System.DateTime? result;
			try
			{
				result = new global::System.DateTime?(global::Microsoft.Windows.Controls.DateTimeHelper.cal.AddMonths(time, months));
			}
			catch (global::System.ArgumentException)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00027F48 File Offset: 0x00026148
		public static global::System.DateTime? AddYears(global::System.DateTime time, int years)
		{
			global::System.DateTime? result;
			try
			{
				result = new global::System.DateTime?(global::Microsoft.Windows.Controls.DateTimeHelper.cal.AddYears(time, years));
			}
			catch (global::System.ArgumentException)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00027F88 File Offset: 0x00026188
		public static global::System.DateTime? SetYear(global::System.DateTime date, int year)
		{
			return global::Microsoft.Windows.Controls.DateTimeHelper.AddYears(date, year - date.Year);
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00027F9C File Offset: 0x0002619C
		public static global::System.DateTime? SetYearMonth(global::System.DateTime date, global::System.DateTime yearMonth)
		{
			global::System.DateTime? result = global::Microsoft.Windows.Controls.DateTimeHelper.SetYear(date, yearMonth.Year);
			if (result != null)
			{
				result = global::Microsoft.Windows.Controls.DateTimeHelper.AddMonths(result.Value, yearMonth.Month - date.Month);
			}
			return result;
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00027FE0 File Offset: 0x000261E0
		public static int CompareDays(global::System.DateTime dt1, global::System.DateTime dt2)
		{
			return global::System.DateTime.Compare(global::Microsoft.Windows.Controls.DateTimeHelper.DiscardTime(new global::System.DateTime?(dt1)).Value, global::Microsoft.Windows.Controls.DateTimeHelper.DiscardTime(new global::System.DateTime?(dt2)).Value);
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00028018 File Offset: 0x00026218
		public static int CompareYearMonth(global::System.DateTime dt1, global::System.DateTime dt2)
		{
			return (dt1.Year - dt2.Year) * 12 + (dt1.Month - dt2.Month);
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0002803C File Offset: 0x0002623C
		public static int DecadeOfDate(global::System.DateTime date)
		{
			return date.Year - date.Year % 10;
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00028050 File Offset: 0x00026250
		public static global::System.DateTime DiscardDayTime(global::System.DateTime d)
		{
			return new global::System.DateTime(d.Year, d.Month, 1, 0, 0, 0);
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0002806C File Offset: 0x0002626C
		public static global::System.DateTime? DiscardTime(global::System.DateTime? d)
		{
			if (d == null)
			{
				return null;
			}
			return new global::System.DateTime?(d.Value.Date);
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x000280A0 File Offset: 0x000262A0
		public static int EndOfDecade(global::System.DateTime date)
		{
			return global::Microsoft.Windows.Controls.DateTimeHelper.DecadeOfDate(date) + 9;
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x000280AB File Offset: 0x000262AB
		public static global::System.Globalization.DateTimeFormatInfo GetCurrentDateFormat()
		{
			return global::Microsoft.Windows.Controls.DateTimeHelper.GetDateFormat(global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x000280B8 File Offset: 0x000262B8
		internal static global::System.Globalization.CultureInfo GetCulture(global::System.Windows.FrameworkElement element)
		{
			global::System.Globalization.CultureInfo result;
			if (global::System.Windows.DependencyPropertyHelper.GetValueSource(element, global::System.Windows.FrameworkElement.LanguageProperty).BaseValueSource != global::System.Windows.BaseValueSource.Default)
			{
				result = global::Microsoft.Windows.Controls.DateTimeHelper.GetCultureInfo(element);
			}
			else
			{
				result = global::System.Globalization.CultureInfo.CurrentCulture;
			}
			return result;
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x000280EC File Offset: 0x000262EC
		internal static global::System.Globalization.CultureInfo GetCultureInfo(global::System.Windows.DependencyObject element)
		{
			global::System.Windows.Markup.XmlLanguage xmlLanguage = (global::System.Windows.Markup.XmlLanguage)element.GetValue(global::System.Windows.FrameworkElement.LanguageProperty);
			global::System.Globalization.CultureInfo result;
			try
			{
				result = xmlLanguage.GetSpecificCulture();
			}
			catch (global::System.InvalidOperationException)
			{
				result = global::System.Globalization.CultureInfo.ReadOnly(new global::System.Globalization.CultureInfo("en-us", false));
			}
			return result;
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00028138 File Offset: 0x00026338
		internal static global::System.Globalization.DateTimeFormatInfo GetDateFormat(global::System.Globalization.CultureInfo culture)
		{
			if (culture.Calendar is global::System.Globalization.GregorianCalendar)
			{
				return culture.DateTimeFormat;
			}
			global::System.Globalization.GregorianCalendar gregorianCalendar = null;
			foreach (global::System.Globalization.Calendar calendar in culture.OptionalCalendars)
			{
				if (calendar is global::System.Globalization.GregorianCalendar)
				{
					if (gregorianCalendar == null)
					{
						gregorianCalendar = (calendar as global::System.Globalization.GregorianCalendar);
					}
					if (((global::System.Globalization.GregorianCalendar)calendar).CalendarType == global::System.Globalization.GregorianCalendarTypes.Localized)
					{
						gregorianCalendar = (calendar as global::System.Globalization.GregorianCalendar);
						break;
					}
				}
			}
			global::System.Globalization.DateTimeFormatInfo dateTimeFormat;
			if (gregorianCalendar == null)
			{
				dateTimeFormat = ((global::System.Globalization.CultureInfo)global::System.Globalization.CultureInfo.InvariantCulture.Clone()).DateTimeFormat;
				dateTimeFormat.Calendar = new global::System.Globalization.GregorianCalendar();
			}
			else
			{
				dateTimeFormat = ((global::System.Globalization.CultureInfo)culture.Clone()).DateTimeFormat;
				dateTimeFormat.Calendar = gregorianCalendar;
			}
			return dateTimeFormat;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x000281E2 File Offset: 0x000263E2
		public static bool InRange(global::System.DateTime date, global::Microsoft.Windows.Controls.CalendarDateRange range)
		{
			return global::Microsoft.Windows.Controls.DateTimeHelper.InRange(date, range.Start, range.End);
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x000281F6 File Offset: 0x000263F6
		public static bool InRange(global::System.DateTime date, global::System.DateTime start, global::System.DateTime end)
		{
			return global::Microsoft.Windows.Controls.DateTimeHelper.CompareDays(date, start) > -1 && global::Microsoft.Windows.Controls.DateTimeHelper.CompareDays(date, end) < 1;
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00028210 File Offset: 0x00026410
		public static string ToDayString(global::System.DateTime? date, global::System.Globalization.CultureInfo culture)
		{
			string result = string.Empty;
			global::System.Globalization.DateTimeFormatInfo dateFormat = global::Microsoft.Windows.Controls.DateTimeHelper.GetDateFormat(culture);
			if (date != null && dateFormat != null)
			{
				result = date.Value.Day.ToString(dateFormat);
			}
			return result;
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00028250 File Offset: 0x00026450
		public static string ToDecadeRangeString(int decade, global::System.Globalization.CultureInfo culture)
		{
			string result = string.Empty;
			global::System.Globalization.DateTimeFormatInfo dateTimeFormat = culture.DateTimeFormat;
			if (dateTimeFormat != null)
			{
				int num = decade + 9;
				result = decade.ToString(dateTimeFormat) + "-" + num.ToString(dateTimeFormat);
			}
			return result;
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00028290 File Offset: 0x00026490
		public static string ToYearMonthPatternString(global::System.DateTime? date, global::System.Globalization.CultureInfo culture)
		{
			string result = string.Empty;
			global::System.Globalization.DateTimeFormatInfo dateFormat = global::Microsoft.Windows.Controls.DateTimeHelper.GetDateFormat(culture);
			if (date != null && dateFormat != null)
			{
				result = date.Value.ToString(dateFormat.YearMonthPattern, dateFormat);
			}
			return result;
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x000282D0 File Offset: 0x000264D0
		public static string ToYearString(global::System.DateTime? date, global::System.Globalization.CultureInfo culture)
		{
			string result = string.Empty;
			global::System.Globalization.DateTimeFormatInfo dateFormat = global::Microsoft.Windows.Controls.DateTimeHelper.GetDateFormat(culture);
			if (date != null && dateFormat != null)
			{
				result = date.Value.Year.ToString(dateFormat);
			}
			return result;
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00028310 File Offset: 0x00026510
		public static string ToAbbreviatedMonthString(global::System.DateTime? date, global::System.Globalization.CultureInfo culture)
		{
			string result = string.Empty;
			global::System.Globalization.DateTimeFormatInfo dateFormat = global::Microsoft.Windows.Controls.DateTimeHelper.GetDateFormat(culture);
			if (date != null && dateFormat != null)
			{
				string[] abbreviatedMonthNames = dateFormat.AbbreviatedMonthNames;
				if (abbreviatedMonthNames != null && abbreviatedMonthNames.Length > 0)
				{
					result = abbreviatedMonthNames[(date.Value.Month - 1) % abbreviatedMonthNames.Length];
				}
			}
			return result;
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00028360 File Offset: 0x00026560
		public static string ToLongDateString(global::System.DateTime? date, global::System.Globalization.CultureInfo culture)
		{
			string result = string.Empty;
			global::System.Globalization.DateTimeFormatInfo dateFormat = global::Microsoft.Windows.Controls.DateTimeHelper.GetDateFormat(culture);
			if (date != null && dateFormat != null)
			{
				result = date.Value.Date.ToString(dateFormat.LongDatePattern, dateFormat);
			}
			return result;
		}

		// Token: 0x040002BC RID: 700
		private static global::System.Globalization.Calendar cal = new global::System.Globalization.GregorianCalendar();
	}
}
