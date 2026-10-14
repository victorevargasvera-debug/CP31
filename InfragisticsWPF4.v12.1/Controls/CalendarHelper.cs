using System;
using System.Globalization;

namespace Infragistics.Controls
{
	// Token: 0x02000018 RID: 24
	internal class CalendarHelper
	{
		// Token: 0x06000111 RID: 273 RVA: 0x00006341 File Offset: 0x00004541
		public CalendarHelper(global::System.Globalization.CultureInfo culture) : this(culture.Calendar, culture.DateTimeFormat)
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00006355 File Offset: 0x00004555
		public CalendarHelper(global::System.Globalization.Calendar calendar, global::System.Globalization.DateTimeFormatInfo formatInfo)
		{
			this.Initialize(calendar, formatInfo);
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00006365 File Offset: 0x00004565
		public global::System.Globalization.Calendar Calendar
		{
			get
			{
				return this._calendar;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000114 RID: 276 RVA: 0x0000636D File Offset: 0x0000456D
		public global::System.Globalization.DateTimeFormatInfo DateTimeFormat
		{
			get
			{
				return this._dateTimeFormat;
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00006375 File Offset: 0x00004575
		protected virtual void VerifyCanChange()
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00006377 File Offset: 0x00004577
		protected void Initialize(global::System.Globalization.Calendar calendar, global::System.Globalization.DateTimeFormatInfo formatInfo)
		{
			if (this._calendar != null)
			{
				this.VerifyCanChange();
			}
			global::Infragistics.CoreUtilities.ValidateNotNull(calendar, "calendar");
			global::Infragistics.CoreUtilities.ValidateNotNull(formatInfo, "formatInfo");
			this._calendar = calendar;
			this._dateTimeFormat = formatInfo;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000063AC File Offset: 0x000045AC
		internal global::System.DateTime CoerceMinMaxDate(global::System.DateTime date)
		{
			date = date.Date;
			if (date < this._calendar.MinSupportedDateTime)
			{
				date = this._calendar.MinSupportedDateTime;
			}
			else if (date > this._calendar.MaxSupportedDateTime)
			{
				date = this._calendar.MaxSupportedDateTime;
			}
			return date;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00006405 File Offset: 0x00004605
		internal static global::System.DateTime GetMinMax(global::System.Globalization.Calendar calendar, bool min)
		{
			if (!min)
			{
				return calendar.MaxSupportedDateTime;
			}
			return calendar.MinSupportedDateTime;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00006418 File Offset: 0x00004618
		internal static int GetVisibleDayCount(global::Infragistics.Controls.DayOfWeekFlags hiddenDays, global::System.DayOfWeek firstDayOfWeek, global::System.DayOfWeek dayOfWeek)
		{
			int i = (int)dayOfWeek;
			int num = 0;
			if (firstDayOfWeek > (global::System.DayOfWeek)i)
			{
				i += 7;
			}
			while (i >= (int)firstDayOfWeek)
			{
				if (!global::Infragistics.Controls.CalendarHelper.IsSet(hiddenDays, (global::System.DayOfWeek)i))
				{
					num++;
				}
				i--;
			}
			return num - 1;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00006450 File Offset: 0x00004650
		internal bool IsSameMonth(global::System.DateTime date1, global::System.DateTime date2)
		{
			global::System.Globalization.Calendar calendar = this._calendar;
			return calendar.GetEra(date1) == calendar.GetEra(date2) && calendar.GetYear(date1) == calendar.GetYear(date2) && calendar.GetMonth(date1) == calendar.GetMonth(date2);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000649B File Offset: 0x0000469B
		internal static bool IsSet(global::Infragistics.Controls.DayOfWeekFlags days, global::System.DayOfWeek day)
		{
			return 0 != (1 << (int)day & (int)days);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000064AB File Offset: 0x000046AB
		public global::System.DateTime AddDays(global::System.DateTime date, int days)
		{
			return global::Infragistics.Controls.CalendarHelper.AddDays(date, days, this._calendar);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000064BC File Offset: 0x000046BC
		internal static global::System.DateTime AddDays(global::System.DateTime date, int days, global::System.Globalization.Calendar calendar)
		{
			global::System.DateTime result;
			try
			{
				result = calendar.AddDays(date, days);
			}
			catch (global::System.ArgumentException)
			{
				result = global::Infragistics.Controls.CalendarHelper.GetMinMax(calendar, days < 0);
			}
			return result;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000064F4 File Offset: 0x000046F4
		internal global::System.DateTime AddHours(global::System.DateTime date, int hours)
		{
			return global::Infragistics.Controls.CalendarHelper.AddHours(date, hours, this._calendar);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00006504 File Offset: 0x00004704
		internal static global::System.DateTime AddHours(global::System.DateTime date, int hours, global::System.Globalization.Calendar calendar)
		{
			global::System.DateTime result;
			try
			{
				result = calendar.AddHours(date, hours);
			}
			catch (global::System.ArgumentOutOfRangeException)
			{
				result = global::Infragistics.Controls.CalendarHelper.GetMinMax(calendar, hours < 0);
			}
			return result;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000653C File Offset: 0x0000473C
		public global::System.DateTime AddMinutes(global::System.DateTime date, int minutes)
		{
			return global::Infragistics.Controls.CalendarHelper.AddMinutes(date, minutes, this._calendar);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000654C File Offset: 0x0000474C
		internal static global::System.DateTime AddMinutes(global::System.DateTime date, int minutes, global::System.Globalization.Calendar calendar)
		{
			global::System.DateTime result;
			try
			{
				result = calendar.AddMinutes(date, minutes);
			}
			catch (global::System.ArgumentOutOfRangeException)
			{
				result = global::Infragistics.Controls.CalendarHelper.GetMinMax(calendar, minutes < 0);
			}
			return result;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00006584 File Offset: 0x00004784
		public global::System.DateTime AddMonths(global::System.DateTime date, int months)
		{
			return global::Infragistics.Controls.CalendarHelper.AddMonths(date, months, this._calendar);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00006594 File Offset: 0x00004794
		internal static global::System.DateTime AddMonths(global::System.DateTime date, int months, global::System.Globalization.Calendar calendar)
		{
			global::System.DateTime result;
			try
			{
				result = calendar.AddMonths(date, months);
			}
			catch (global::System.ArgumentOutOfRangeException)
			{
				result = global::Infragistics.Controls.CalendarHelper.GetMinMax(calendar, months < 0);
			}
			return result;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000065CC File Offset: 0x000047CC
		public global::System.DateTime AddSeconds(global::System.DateTime date, int seconds)
		{
			return global::Infragistics.Controls.CalendarHelper.AddSeconds(date, seconds, this._calendar);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000065DC File Offset: 0x000047DC
		internal static global::System.DateTime AddSeconds(global::System.DateTime date, int seconds, global::System.Globalization.Calendar calendar)
		{
			global::System.DateTime result;
			try
			{
				result = calendar.AddSeconds(date, seconds);
			}
			catch (global::System.ArgumentOutOfRangeException)
			{
				result = global::Infragistics.Controls.CalendarHelper.GetMinMax(calendar, seconds < 0);
			}
			return result;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00006614 File Offset: 0x00004814
		public global::System.DateTime AddWeeks(global::System.DateTime date, int weeks)
		{
			return global::Infragistics.Controls.CalendarHelper.AddWeeks(date, weeks, this._calendar);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00006624 File Offset: 0x00004824
		internal static global::System.DateTime AddWeeks(global::System.DateTime date, int weeks, global::System.Globalization.Calendar calendar)
		{
			global::System.DateTime result;
			try
			{
				result = calendar.AddWeeks(date, weeks);
			}
			catch (global::System.ArgumentOutOfRangeException)
			{
				result = global::Infragistics.Controls.CalendarHelper.GetMinMax(calendar, weeks < 0);
			}
			return result;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000665C File Offset: 0x0000485C
		public global::System.DateTime AddYears(global::System.DateTime date, int years)
		{
			return global::Infragistics.Controls.CalendarHelper.AddYears(date, years, this._calendar);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000666C File Offset: 0x0000486C
		internal static global::System.DateTime AddYears(global::System.DateTime date, int years, global::System.Globalization.Calendar calendar)
		{
			global::System.DateTime result;
			try
			{
				result = calendar.AddYears(date, years);
			}
			catch (global::System.ArgumentOutOfRangeException)
			{
				result = global::Infragistics.Controls.CalendarHelper.GetMinMax(calendar, years < 0);
			}
			return result;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000066A4 File Offset: 0x000048A4
		public global::System.DateTime GetFirstDayOfWeekForDate(global::System.DateTime date, global::System.DayOfWeek? firstDayOfWeek, out int additionalOffset)
		{
			int dayOfWeekNumber = this.GetDayOfWeekNumber(date, global::Infragistics.Controls.DayOfWeekFlags.None, firstDayOfWeek);
			try
			{
				date = this._calendar.AddDays(date, -dayOfWeekNumber);
				additionalOffset = 0;
			}
			catch
			{
				additionalOffset = dayOfWeekNumber - date.Subtract(this._calendar.MinSupportedDateTime).Days;
				date = this._calendar.MinSupportedDateTime;
			}
			return date;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00006710 File Offset: 0x00004910
		public int GetDaysInMonth(global::System.DateTime date)
		{
			return global::Infragistics.Controls.CalendarHelper.GetDaysInMonth(date, this._calendar);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00006720 File Offset: 0x00004920
		internal static int GetDaysInMonth(global::System.DateTime date, global::System.Globalization.Calendar calendar)
		{
			int month = calendar.GetMonth(date);
			int year = calendar.GetYear(date);
			int era = calendar.GetEra(date);
			return calendar.GetDaysInMonth(year, month, era);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000674E File Offset: 0x0000494E
		public int GetDaysInYear(global::System.DateTime date)
		{
			return global::Infragistics.Controls.CalendarHelper.GetDaysInYear(date, this._calendar);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000675C File Offset: 0x0000495C
		internal static int GetDaysInYear(global::System.DateTime date, global::System.Globalization.Calendar calendar)
		{
			int year = calendar.GetYear(date);
			int era = calendar.GetEra(date);
			return calendar.GetDaysInYear(year, era);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00006781 File Offset: 0x00004981
		public int GetDayOfMonth(global::System.DateTime date)
		{
			return this._calendar.GetDayOfMonth(date);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000678F File Offset: 0x0000498F
		public global::System.DayOfWeek GetDayOfWeek(global::System.DateTime date)
		{
			return this._calendar.GetDayOfWeek(date);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000067A0 File Offset: 0x000049A0
		public int GetDayOfWeekNumber(global::System.DateTime date, global::Infragistics.Controls.DayOfWeekFlags hiddenDays, global::System.DayOfWeek? firstDayOfWeek)
		{
			return global::Infragistics.Controls.CalendarHelper.GetDayOfWeekNumber(date, hiddenDays, firstDayOfWeek ?? this._dateTimeFormat.FirstDayOfWeek, this._calendar);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000067DC File Offset: 0x000049DC
		internal static int GetDayOfWeekNumber(global::System.DateTime date, global::Infragistics.Controls.DayOfWeekFlags hiddenDays, global::System.DayOfWeek firstDayOfWeek, global::System.Globalization.Calendar calendar)
		{
			if (hiddenDays != global::Infragistics.Controls.DayOfWeekFlags.None)
			{
				return global::Infragistics.Controls.CalendarHelper.GetVisibleDayCount(hiddenDays, firstDayOfWeek, calendar.GetDayOfWeek(date));
			}
			global::System.DayOfWeek dayOfWeek = calendar.GetDayOfWeek(date);
			return (dayOfWeek - firstDayOfWeek + 7) % 7;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000680A File Offset: 0x00004A0A
		internal int GetDayOfYear(global::System.DateTime date)
		{
			return this._calendar.GetDayOfYear(date);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00006818 File Offset: 0x00004A18
		internal static global::System.DateTime GetFirstWeekOfYearDate(int year, int? era, global::System.Globalization.CalendarWeekRule weekRule, global::System.DayOfWeek firstDayOfWeek, global::System.Globalization.Calendar calendar, out int additionalOffset)
		{
			global::System.DateTime dateTime = (era == null) ? calendar.ToDateTime(year, 1, 1, 0, 0, 0, 0) : calendar.ToDateTime(year, 1, 1, 0, 0, 0, 0, era.Value);
			global::System.DayOfWeek dayOfWeek = calendar.GetDayOfWeek(dateTime);
			int num = dayOfWeek - firstDayOfWeek;
			int num2 = 0;
			switch (weekRule)
			{
			case global::System.Globalization.CalendarWeekRule.FirstFullWeek:
				if (num > 0)
				{
					num2 = 7 - num;
					goto IL_92;
				}
				if (num < 0)
				{
					num2 = -num;
					goto IL_92;
				}
				goto IL_92;
			case global::System.Globalization.CalendarWeekRule.FirstFourDayWeek:
				if (num > 3)
				{
					num2 = 7 - num;
					goto IL_92;
				}
				if (num < -3)
				{
					num2 = -(7 + num);
					goto IL_92;
				}
				num2 = -num;
				goto IL_92;
			}
			if (num < 0)
			{
				num2 = -(7 + num);
			}
			else
			{
				num2 = -num;
			}
			try
			{
				IL_92:
				dateTime = dateTime.AddDays((double)num2);
				additionalOffset = 0;
			}
			catch
			{
				additionalOffset = num2 - calendar.MinSupportedDateTime.Subtract(dateTime).Days;
				dateTime = calendar.MinSupportedDateTime;
			}
			return dateTime;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00006904 File Offset: 0x00004B04
		public int GetMonthNumber(global::System.DateTime date)
		{
			return this._calendar.GetMonth(date);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00006914 File Offset: 0x00004B14
		public int GetWeekNumberForDate(global::System.DateTime date, global::System.Globalization.CalendarWeekRule? weekRule, global::System.DayOfWeek? firstDayOfWeek, out int yearContainingWeek)
		{
			return global::Infragistics.Controls.CalendarHelper.GetWeekNumberForDate(date, weekRule ?? this._dateTimeFormat.CalendarWeekRule, firstDayOfWeek ?? this._dateTimeFormat.FirstDayOfWeek, this._calendar, out yearContainingWeek);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00006970 File Offset: 0x00004B70
		internal static int GetWeekNumberForDate(global::System.DateTime date, global::System.Globalization.CalendarWeekRule weekRule, global::System.DayOfWeek firstDayOfWeek, global::System.Globalization.Calendar calendar, out int yearContainingWeek)
		{
			int num = calendar.GetYear(date);
			if (num < calendar.GetYear(calendar.MaxSupportedDateTime))
			{
				num++;
			}
			int era = calendar.GetEra(date);
			int num2;
			global::System.DateTime firstWeekOfYearDate = global::Infragistics.Controls.CalendarHelper.GetFirstWeekOfYearDate(num, new int?(era), weekRule, firstDayOfWeek, calendar, out num2);
			while (firstWeekOfYearDate > date)
			{
				if (num == 1)
				{
					yearContainingWeek = 0;
					return 0;
				}
				firstWeekOfYearDate = global::Infragistics.Controls.CalendarHelper.GetFirstWeekOfYearDate(--num, new int?(era), weekRule, firstDayOfWeek, calendar, out num2);
			}
			yearContainingWeek = num;
			return (date.Subtract(firstWeekOfYearDate).Days - num2) / 7 + 1;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000069F8 File Offset: 0x00004BF8
		public int GetYear(global::System.DateTime date)
		{
			return this._calendar.GetYear(date);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00006A08 File Offset: 0x00004C08
		public bool TryAddOffset(global::System.DateTime date, int offset, global::Infragistics.Controls.CalendarHelper.DateTimeOffsetType offsetType, out global::System.DateTime adjustedDate)
		{
			bool result;
			try
			{
				switch (offsetType)
				{
				case global::Infragistics.Controls.CalendarHelper.DateTimeOffsetType.Days:
					adjustedDate = this._calendar.AddDays(date, offset);
					break;
				case global::Infragistics.Controls.CalendarHelper.DateTimeOffsetType.Weeks:
					adjustedDate = this._calendar.AddWeeks(date, offset);
					break;
				case global::Infragistics.Controls.CalendarHelper.DateTimeOffsetType.Months:
					adjustedDate = this._calendar.AddMonths(date, offset);
					break;
				case global::Infragistics.Controls.CalendarHelper.DateTimeOffsetType.Years:
					adjustedDate = this._calendar.AddYears(date, offset);
					break;
				case global::Infragistics.Controls.CalendarHelper.DateTimeOffsetType.Hours:
					adjustedDate = this._calendar.AddHours(date, offset);
					break;
				case global::Infragistics.Controls.CalendarHelper.DateTimeOffsetType.Minutes:
					adjustedDate = this._calendar.AddMinutes(date, offset);
					break;
				case global::Infragistics.Controls.CalendarHelper.DateTimeOffsetType.Seconds:
					adjustedDate = this._calendar.AddSeconds(date, offset);
					break;
				default:
					throw new global::System.ArgumentException();
				}
				result = true;
			}
			catch (global::System.ArgumentException)
			{
				adjustedDate = global::Infragistics.Controls.CalendarHelper.GetMinMax(this._calendar, offset < 0);
				result = false;
			}
			return result;
		}

		// Token: 0x04000051 RID: 81
		internal const global::Infragistics.Controls.DayOfWeekFlags AllDays = global::Infragistics.Controls.DayOfWeekFlags.Sunday | global::Infragistics.Controls.DayOfWeekFlags.Monday | global::Infragistics.Controls.DayOfWeekFlags.Tuesday | global::Infragistics.Controls.DayOfWeekFlags.Wednesday | global::Infragistics.Controls.DayOfWeekFlags.Thursday | global::Infragistics.Controls.DayOfWeekFlags.Friday | global::Infragistics.Controls.DayOfWeekFlags.Saturday;

		// Token: 0x04000052 RID: 82
		private global::System.Globalization.Calendar _calendar;

		// Token: 0x04000053 RID: 83
		private global::System.Globalization.DateTimeFormatInfo _dateTimeFormat;

		// Token: 0x02000019 RID: 25
		internal enum DateTimeOffsetType : byte
		{
			// Token: 0x04000055 RID: 85
			Days,
			// Token: 0x04000056 RID: 86
			Weeks,
			// Token: 0x04000057 RID: 87
			Months,
			// Token: 0x04000058 RID: 88
			Years,
			// Token: 0x04000059 RID: 89
			Hours,
			// Token: 0x0400005A RID: 90
			Minutes,
			// Token: 0x0400005B RID: 91
			Seconds
		}
	}
}
