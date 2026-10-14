using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000061 RID: 97
	public class DateUtil
	{
		// Token: 0x06000395 RID: 917 RVA: 0x0000C328 File Offset: 0x0000A528
		public static int absoluteDay(global::System.DateTime cal, bool use1904windowing)
		{
			int num = (cal - new global::System.DateTime(1899, 12, 31)).Days;
			if (cal > new global::System.DateTime(1900, 3, 1) && use1904windowing)
			{
				num++;
			}
			return num;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000C36D File Offset: 0x0000A56D
		public static int AbsoluteDay(global::System.DateTime cal, bool use1904windowing)
		{
			return cal.DayOfYear + global::NPOI.SS.UserModel.DateUtil.DaysInPriorYears(cal.Year, use1904windowing);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000C384 File Offset: 0x0000A584
		private static int DaysInPriorYears(int yr, bool use1904windowing)
		{
			if ((!use1904windowing && yr < 1900) || (use1904windowing && yr < 1904))
			{
				throw new global::System.ArgumentException("'year' must be 1900 or greater");
			}
			int num = yr - 1;
			int num2 = num / 4 - num / 100 + num / 400 - 460;
			return 365 * (yr - (use1904windowing ? 1904 : 1900)) + num2;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000C3E6 File Offset: 0x0000A5E6
		public static double GetExcelDate(global::System.DateTime date)
		{
			return global::NPOI.SS.UserModel.DateUtil.GetExcelDate(date, false);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000C3F0 File Offset: 0x0000A5F0
		public static double GetExcelDate(int year, int month, int day, int hour, int minute, int second, bool use1904windowing)
		{
			if ((!use1904windowing && year < 1900) || (use1904windowing && year < 1904))
			{
				return -1.0;
			}
			global::System.DateTime d;
			if (use1904windowing)
			{
				d = new global::System.DateTime(1904, 1, 1);
			}
			else
			{
				d = new global::System.DateTime(1900, 1, 1);
			}
			int months = 0;
			if (month > 12)
			{
				months = month - 12;
				month = 12;
			}
			int num = 0;
			if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
			{
				if (day > 31)
				{
					num = day - 31;
					day = 31;
				}
			}
			else if (month == 4 || month == 6 || month == 9 || month == 11)
			{
				if (day > 30)
				{
					num = day - 30;
					day = 30;
				}
			}
			else if (global::System.DateTime.IsLeapYear(year))
			{
				if (day > 29)
				{
					num = day - 29;
					day = 29;
				}
			}
			else if (day > 28)
			{
				num = day - 28;
				day = 28;
			}
			if (day <= 0)
			{
				num = day - 1;
				day = 1;
			}
			global::System.DateTime d2 = new global::System.DateTime(year, month, day, hour, minute, second);
			d2 = d2.AddMonths(months);
			d2 = d2.AddDays((double)num);
			double num2 = (d2 - d).TotalDays + 1.0;
			if (!use1904windowing && num2 >= 60.0)
			{
				num2 += 1.0;
			}
			else if (use1904windowing)
			{
				num2 -= 1.0;
			}
			return num2;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000C548 File Offset: 0x0000A748
		public static double GetExcelDate(global::System.DateTime date, bool use1904windowing)
		{
			if ((!use1904windowing && date.Year < 1900) || (use1904windowing && date.Year < 1904))
			{
				return -1.0;
			}
			global::System.DateTime d;
			if (use1904windowing)
			{
				d = new global::System.DateTime(1904, 1, 1);
			}
			else
			{
				d = new global::System.DateTime(1900, 1, 1);
			}
			double num = (date - d).TotalDays + 1.0;
			if (!use1904windowing && num >= 60.0)
			{
				num += 1.0;
			}
			else if (use1904windowing)
			{
				num -= 1.0;
			}
			return num;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000C5E9 File Offset: 0x0000A7E9
		public static global::System.DateTime GetJavaDate(double date)
		{
			return global::NPOI.SS.UserModel.DateUtil.GetJavaDate(date, false);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000C5F2 File Offset: 0x0000A7F2
		public static global::System.DateTime GetJavaDate(double date, global::System.TimeZoneInfo tz)
		{
			return global::NPOI.SS.UserModel.DateUtil.GetJavaDate(date, false, tz, false);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000C5FD File Offset: 0x0000A7FD
		[global::System.Obsolete("The class TimeZone was marked obsolete, Use the Overload using TimeZoneInfo instead.")]
		public static global::System.DateTime GetJavaDate(double date, global::System.TimeZone tz)
		{
			return global::NPOI.SS.UserModel.DateUtil.GetJavaDate(date, false, tz, false);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000C608 File Offset: 0x0000A808
		public static global::System.DateTime GetJavaDate(double date, bool use1904windowing)
		{
			return global::NPOI.SS.UserModel.DateUtil.GetJavaCalendar(date, use1904windowing, null, false);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000C613 File Offset: 0x0000A813
		public static global::System.DateTime GetJavaDate(double date, bool use1904windowing, global::System.TimeZoneInfo tz)
		{
			return global::NPOI.SS.UserModel.DateUtil.GetJavaCalendar(date, use1904windowing, tz, false);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000C61E File Offset: 0x0000A81E
		[global::System.Obsolete("The class TimeZone was marked obsolete, Use the Overload using TimeZoneInfo instead.")]
		public static global::System.DateTime GetJavaDate(double date, bool use1904windowing, global::System.TimeZone tz)
		{
			return global::NPOI.SS.UserModel.DateUtil.GetJavaCalendar(date, use1904windowing, tz, false);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000C629 File Offset: 0x0000A829
		public static global::System.DateTime GetJavaDate(double date, bool use1904windowing, global::System.TimeZoneInfo tz, bool roundSeconds)
		{
			return global::NPOI.SS.UserModel.DateUtil.GetJavaCalendar(date, use1904windowing, tz, roundSeconds);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000C634 File Offset: 0x0000A834
		[global::System.Obsolete("The class TimeZone was marked obsolete, Use the Overload using TimeZoneInfo instead.")]
		public static global::System.DateTime GetJavaDate(double date, bool use1904windowing, global::System.TimeZone tz, bool roundSeconds)
		{
			return global::NPOI.SS.UserModel.DateUtil.GetJavaCalendar(date, use1904windowing, tz, roundSeconds);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000C640 File Offset: 0x0000A840
		public static global::System.DateTime SetCalendar(int wholeDays, int millisecondsInDay, bool use1904windowing, bool roundSeconds)
		{
			int year = 1900;
			int num = -1;
			if (use1904windowing)
			{
				year = 1904;
				num = 1;
			}
			else if (wholeDays < 61)
			{
				num = 0;
			}
			global::System.DateTime result = new global::System.DateTime(year, 1, 1).AddDays((double)(wholeDays + num - 1)).AddMilliseconds((double)millisecondsInDay);
			if (roundSeconds)
			{
				result = result.AddMilliseconds(500.0);
				result = result.AddMilliseconds((double)(-(double)result.Millisecond));
			}
			return result;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000C6B0 File Offset: 0x0000A8B0
		public static global::System.DateTime GetJavaCalendar(double date)
		{
			return global::NPOI.SS.UserModel.DateUtil.GetJavaCalendar(date, false, null, false);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000C608 File Offset: 0x0000A808
		public static global::System.DateTime GetJavaCalendar(double date, bool use1904windowing)
		{
			return global::NPOI.SS.UserModel.DateUtil.GetJavaCalendar(date, use1904windowing, null, false);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000C6BB File Offset: 0x0000A8BB
		public static global::System.DateTime GetJavaCalendarUTC(double date, bool use1904windowing)
		{
			return global::System.TimeZoneInfo.ConvertTimeToUtc(global::NPOI.SS.UserModel.DateUtil.GetJavaCalendar(date, use1904windowing, null, false));
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000C613 File Offset: 0x0000A813
		public static global::System.DateTime GetJavaCalendar(double date, bool use1904windowing, global::System.TimeZoneInfo timeZone)
		{
			return global::NPOI.SS.UserModel.DateUtil.GetJavaCalendar(date, use1904windowing, timeZone, false);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000C6CC File Offset: 0x0000A8CC
		public static global::System.DateTime GetJavaCalendar(double date, bool use1904windowing, global::System.TimeZoneInfo timeZone, bool roundSeconds)
		{
			if (!global::NPOI.SS.UserModel.DateUtil.IsValidExcelDate(date))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Invalid Excel date double value: {0}", new object[]
				{
					date
				}));
			}
			int num = (int)global::System.Math.Floor(date);
			int millisecondsInDay = (int)((date - (double)num) * 86400000.0 + 0.5);
			global::System.DateTime now = global::System.DateTime.Now;
			return global::NPOI.SS.UserModel.DateUtil.SetCalendar(num, millisecondsInDay, use1904windowing, roundSeconds);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000C61E File Offset: 0x0000A81E
		[global::System.Obsolete("The class TimeZone was marked obsolete, Use the Overload using TimeZoneInfo instead.")]
		public static global::System.DateTime GetJavaCalendar(double date, bool use1904windowing, global::System.TimeZone timeZone)
		{
			return global::NPOI.SS.UserModel.DateUtil.GetJavaCalendar(date, use1904windowing, timeZone, false);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000C738 File Offset: 0x0000A938
		[global::System.Obsolete("The class TimeZone was marked obsolete, Use the Overload using TimeZoneInfo instead.")]
		public static global::System.DateTime GetJavaCalendar(double date, bool use1904windowing, global::System.TimeZone timeZone, bool roundSeconds)
		{
			if (!global::NPOI.SS.UserModel.DateUtil.IsValidExcelDate(date))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Invalid Excel date double value: {0}", new object[]
				{
					date
				}));
			}
			int num = (int)global::System.Math.Floor(date);
			int millisecondsInDay = (int)((date - (double)num) * 86400000.0 + 0.5);
			global::System.DateTime now = global::System.DateTime.Now;
			return global::NPOI.SS.UserModel.DateUtil.SetCalendar(num, millisecondsInDay, use1904windowing, roundSeconds);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000C7A4 File Offset: 0x0000A9A4
		public static double ConvertTime(string timeStr)
		{
			double result;
			try
			{
				result = global::NPOI.SS.UserModel.DateUtil.ConvertTimeInternal(timeStr);
			}
			catch (global::System.FormatException ex)
			{
				throw new global::System.ArgumentException("Bad time format '" + timeStr + "' expected 'HH:MM' or 'HH:MM:SS' - " + ex.Message);
			}
			return result;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000C7E8 File Offset: 0x0000A9E8
		private static double ConvertTimeInternal(string timeStr)
		{
			int length = timeStr.Length;
			if (length < 4 || length > 8)
			{
				throw new global::System.FormatException("Bad length");
			}
			string[] array = timeStr.Split(global::NPOI.SS.UserModel.DateUtil.TIME_SEPARATOR_PATTERN);
			int num = array.Length;
			string strVal;
			if (num != 2)
			{
				if (num != 3)
				{
					throw new global::System.FormatException("Expected 2 or 3 fields but got (" + array.Length.ToString() + ")");
				}
				strVal = array[2];
			}
			else
			{
				strVal = "00";
			}
			string strVal2 = array[0];
			string strVal3 = array[1];
			int num2 = global::NPOI.SS.UserModel.DateUtil.ParseInt(strVal2, "hour", 24);
			int num3 = global::NPOI.SS.UserModel.DateUtil.ParseInt(strVal3, "minute", 60);
			return (double)(global::NPOI.SS.UserModel.DateUtil.ParseInt(strVal, "second", 60) + (num3 + num2 * 60) * 60) / 86400.0;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000C8A4 File Offset: 0x0000AAA4
		public static bool IsADateFormat(int formatIndex, string formatString)
		{
			string obj = global::NPOI.SS.UserModel.DateUtil.syncIsADateFormat;
			bool result;
			lock (obj)
			{
				if (formatString != null && formatIndex == global::NPOI.SS.UserModel.DateUtil.lastFormatIndex && formatString.Equals(global::NPOI.SS.UserModel.DateUtil.lastFormatString))
				{
					result = global::NPOI.SS.UserModel.DateUtil.cached;
				}
				else if (global::NPOI.SS.UserModel.DateUtil.IsInternalDateFormat(formatIndex))
				{
					global::NPOI.SS.UserModel.DateUtil.lastFormatIndex = formatIndex;
					global::NPOI.SS.UserModel.DateUtil.lastFormatString = formatString;
					global::NPOI.SS.UserModel.DateUtil.cached = true;
					result = true;
				}
				else if (formatString == null || formatString.Length == 0)
				{
					global::NPOI.SS.UserModel.DateUtil.lastFormatIndex = formatIndex;
					global::NPOI.SS.UserModel.DateUtil.lastFormatString = formatString;
					global::NPOI.SS.UserModel.DateUtil.cached = false;
					result = false;
				}
				else
				{
					string text = global::System.Text.RegularExpressions.Regex.Replace(formatString, ";@", "");
					int length = text.Length;
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(length);
					int i = 0;
					while (i < length)
					{
						char c = text[i];
						if (i >= length - 1)
						{
							goto IL_FD;
						}
						char c2 = text[i + 1];
						if (c == '\\')
						{
							if (c2 != ' ')
							{
								switch (c2)
								{
								case ',':
								case '-':
								case '.':
									break;
								default:
									if (c2 != '\\')
									{
										goto IL_FD;
									}
									break;
								}
							}
						}
						else
						{
							if (c != ';' || c2 != '@')
							{
								goto IL_FD;
							}
							i++;
						}
						IL_107:
						i++;
						continue;
						IL_FD:
						stringBuilder.Append(c);
						goto IL_107;
					}
					text = stringBuilder.ToString();
					if (global::NPOI.SS.UserModel.DateUtil.date_ptrn4.IsMatch(text))
					{
						global::NPOI.SS.UserModel.DateUtil.lastFormatIndex = formatIndex;
						global::NPOI.SS.UserModel.DateUtil.lastFormatString = formatString;
						global::NPOI.SS.UserModel.DateUtil.cached = true;
						result = true;
					}
					else
					{
						text = global::NPOI.SS.UserModel.DateUtil.date_ptrn1.Replace(text, "");
						text = global::NPOI.SS.UserModel.DateUtil.date_ptrn2.Replace(text, "");
						int num = text.IndexOf(';');
						if (num > 0 && num < text.Length - 1)
						{
							text = text.Substring(0, num);
						}
						if (!global::NPOI.SS.UserModel.DateUtil.date_ptrn3a.Match(text).Success)
						{
							result = false;
						}
						else
						{
							text = global::System.Text.RegularExpressions.Regex.Replace(text, "\"[^\"\\\\]*(?:\\\\.[^\"\\\\]*)*\"", "");
							bool flag2 = global::NPOI.SS.UserModel.DateUtil.date_ptrn3b.IsMatch(text);
							global::NPOI.SS.UserModel.DateUtil.lastFormatIndex = formatIndex;
							global::NPOI.SS.UserModel.DateUtil.lastFormatString = formatString;
							global::NPOI.SS.UserModel.DateUtil.cached = flag2;
							result = flag2;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000CAAC File Offset: 0x0000ACAC
		public static global::System.DateTime ParseYYYYMMDDDate(string dateStr)
		{
			global::System.DateTime result;
			try
			{
				result = global::NPOI.SS.UserModel.DateUtil.ParseYYYYMMDDDateInternal(dateStr);
			}
			catch (global::System.FormatException ex)
			{
				throw new global::System.ArgumentException("Bad time format " + dateStr + " expected 'YYYY/MM/DD' - " + ex.Message);
			}
			return result;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000CAF0 File Offset: 0x0000ACF0
		private static global::System.DateTime ParseYYYYMMDDDateInternal(string timeStr)
		{
			if (timeStr.Length != 10)
			{
				throw new global::System.FormatException("Bad length");
			}
			string strVal = timeStr.Substring(0, 4);
			string strVal2 = timeStr.Substring(5, 2);
			string strVal3 = timeStr.Substring(8, 2);
			int year = global::NPOI.SS.UserModel.DateUtil.ParseInt(strVal, "year", -32768, 32767);
			int month = global::NPOI.SS.UserModel.DateUtil.ParseInt(strVal2, "month", 1, 12);
			int day = global::NPOI.SS.UserModel.DateUtil.ParseInt(strVal3, "day", 1, 31);
			return new global::System.DateTime(year, month, day, 0, 0, 0);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000CB6C File Offset: 0x0000AD6C
		private static int ParseInt(string strVal, string fieldName, int rangeMax)
		{
			return global::NPOI.SS.UserModel.DateUtil.ParseInt(strVal, fieldName, 0, rangeMax - 1);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000CB7C File Offset: 0x0000AD7C
		private static int ParseInt(string strVal, string fieldName, int lowerLimit, int upperLimit)
		{
			int num;
			try
			{
				num = int.Parse(strVal, global::System.Globalization.CultureInfo.InvariantCulture);
			}
			catch (global::System.FormatException)
			{
				throw new global::System.FormatException(string.Concat(new string[]
				{
					"Bad int format '",
					strVal,
					"' for ",
					fieldName,
					" field"
				}));
			}
			if (num < lowerLimit || num > upperLimit)
			{
				throw new global::System.FormatException(string.Concat(new string[]
				{
					fieldName,
					" value (",
					num.ToString(),
					") is outside the allowable range(0..",
					upperLimit.ToString(),
					")"
				}));
			}
			return num;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000CC24 File Offset: 0x0000AE24
		public static bool IsInternalDateFormat(int format)
		{
			return format - 14 <= 8 || format - 45 <= 2;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000CC48 File Offset: 0x0000AE48
		public static bool IsCellDateFormatted(global::NPOI.SS.UserModel.ICell cell)
		{
			if (cell == null)
			{
				return false;
			}
			bool result = false;
			if (global::NPOI.SS.UserModel.DateUtil.IsValidExcelDate(cell.NumericCellValue))
			{
				global::NPOI.SS.UserModel.ICellStyle cellStyle = cell.CellStyle;
				if (cellStyle == null)
				{
					return false;
				}
				int dataFormat = (int)cellStyle.DataFormat;
				string dataFormatString = cellStyle.GetDataFormatString();
				result = global::NPOI.SS.UserModel.DateUtil.IsADateFormat(dataFormat, dataFormatString);
			}
			return result;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000CC8C File Offset: 0x0000AE8C
		public static bool IsCellInternalDateFormatted(global::NPOI.SS.UserModel.ICell cell)
		{
			if (cell == null)
			{
				return false;
			}
			bool result = false;
			if (global::NPOI.SS.UserModel.DateUtil.IsValidExcelDate(cell.NumericCellValue))
			{
				result = global::NPOI.SS.UserModel.DateUtil.IsInternalDateFormat((int)cell.CellStyle.DataFormat);
			}
			return result;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000CCBF File Offset: 0x0000AEBF
		public static bool IsValidExcelDate(double value)
		{
			return value > -5E-324;
		}

		// Token: 0x040001A8 RID: 424
		public const int SECONDS_PER_MINUTE = 60;

		// Token: 0x040001A9 RID: 425
		public const int MINUTES_PER_HOUR = 60;

		// Token: 0x040001AA RID: 426
		public const int HOURS_PER_DAY = 24;

		// Token: 0x040001AB RID: 427
		public const int SECONDS_PER_DAY = 86400;

		// Token: 0x040001AC RID: 428
		private const int BAD_DATE = -1;

		// Token: 0x040001AD RID: 429
		public const long DAY_MILLISECONDS = 86400000L;

		// Token: 0x040001AE RID: 430
		private static readonly char[] TIME_SEPARATOR_PATTERN = new char[]
		{
			':'
		};

		// Token: 0x040001AF RID: 431
		private static global::System.Text.RegularExpressions.Regex date_ptrn1 = new global::System.Text.RegularExpressions.Regex("^\\[\\$\\-.*?\\]", global::System.Text.RegularExpressions.RegexOptions.Compiled);

		// Token: 0x040001B0 RID: 432
		private static global::System.Text.RegularExpressions.Regex date_ptrn2 = new global::System.Text.RegularExpressions.Regex("^\\[[a-zA-Z]+\\]", global::System.Text.RegularExpressions.RegexOptions.Compiled);

		// Token: 0x040001B1 RID: 433
		private static global::System.Text.RegularExpressions.Regex date_ptrn3a = new global::System.Text.RegularExpressions.Regex("[yYmMdDhHsS]", global::System.Text.RegularExpressions.RegexOptions.Compiled);

		// Token: 0x040001B2 RID: 434
		private static global::System.Text.RegularExpressions.Regex date_ptrn3b = new global::System.Text.RegularExpressions.Regex("^[\\[\\]yYmMdDhHsS\\-T/,. :\"\\\\]+0*[ampAMP/]*$", global::System.Text.RegularExpressions.RegexOptions.Compiled);

		// Token: 0x040001B3 RID: 435
		private static global::System.Text.RegularExpressions.Regex date_ptrn4 = new global::System.Text.RegularExpressions.Regex("^\\[([hH]+|[mM]+|[sS]+)\\]$", global::System.Text.RegularExpressions.RegexOptions.Compiled);

		// Token: 0x040001B4 RID: 436
		private static int lastFormatIndex = -1;

		// Token: 0x040001B5 RID: 437
		private static string lastFormatString = null;

		// Token: 0x040001B6 RID: 438
		private static bool cached = false;

		// Token: 0x040001B7 RID: 439
		private static string syncIsADateFormat = "IsADateFormat";
	}
}
