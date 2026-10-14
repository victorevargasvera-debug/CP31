using System;
using System.Collections.Generic;
using System.Globalization;
using Infragistics.Controls;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200003D RID: 61
	internal class CalendarManager : global::Infragistics.Controls.CalendarHelper
	{
		// Token: 0x0600040B RID: 1035 RVA: 0x000114B6 File Offset: 0x0000F6B6
		internal CalendarManager() : base(global::System.Globalization.CultureInfo.CurrentCulture)
		{
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x000114CA File Offset: 0x0000F6CA
		internal CalendarManager(global::System.Globalization.CultureInfo culture) : base(culture)
		{
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x000114DA File Offset: 0x0000F6DA
		internal static global::Infragistics.Windows.Editors.CalendarManager CurrentCulture
		{
			get
			{
				if (global::Infragistics.Windows.Editors.CalendarManager.currentCulture == null)
				{
					global::Infragistics.Windows.Editors.CalendarManager.currentCulture = new global::Infragistics.Windows.Editors.CalendarManager();
				}
				return global::Infragistics.Windows.Editors.CalendarManager.currentCulture;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x000114F2 File Offset: 0x0000F6F2
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x000114FC File Offset: 0x0000F6FC
		public global::Infragistics.Controls.DayOfWeekFlags HiddenDays
		{
			get
			{
				return this._hiddenDays;
			}
			set
			{
				this.VerifyCanChange();
				this._hiddenDays = value;
				this._visibleDayCount = 0;
				for (int i = 0; i < 7; i++)
				{
					if (!global::Infragistics.Controls.CalendarHelper.IsSet(value, (global::System.DayOfWeek)i))
					{
						this._visibleDayCount++;
					}
				}
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x00011540 File Offset: 0x0000F740
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x00011548 File Offset: 0x0000F748
		public global::System.DayOfWeek? FirstDayOfWeek
		{
			get
			{
				return this._firstDayOfWeek;
			}
			set
			{
				this.VerifyCanChange();
				this._firstDayOfWeek = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x00011557 File Offset: 0x0000F757
		internal global::System.DayOfWeek FirstDayOfWeekResolved
		{
			get
			{
				if (this._firstDayOfWeek == null)
				{
					return base.DateTimeFormat.FirstDayOfWeek;
				}
				return this._firstDayOfWeek.Value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0001157D File Offset: 0x0000F77D
		public int VisibleDayCount
		{
			get
			{
				return this._visibleDayCount;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x00011585 File Offset: 0x0000F785
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x0001158D File Offset: 0x0000F78D
		public global::System.Globalization.CalendarWeekRule? WeekRule
		{
			get
			{
				return this._weekRule;
			}
			set
			{
				this.VerifyCanChange();
				this._weekRule = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x0001159C File Offset: 0x0000F79C
		internal global::System.Globalization.CalendarWeekRule WeekRuleResolved
		{
			get
			{
				if (this._weekRule == null)
				{
					return base.DateTimeFormat.CalendarWeekRule;
				}
				return this._weekRule.Value;
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000115C4 File Offset: 0x0000F7C4
		internal global::System.DateTime? TryAddGroupOffset(global::System.DateTime date, int offset, global::Infragistics.Windows.Editors.CalendarMode mode, bool adjustForStart)
		{
			try
			{
				switch (mode)
				{
				default:
					date = base.Calendar.AddMonths(date, offset);
					break;
				case global::Infragistics.Windows.Editors.CalendarMode.Months:
					date = base.Calendar.AddYears(date, offset);
					break;
				case global::Infragistics.Windows.Editors.CalendarMode.Years:
				case global::Infragistics.Windows.Editors.CalendarMode.Decades:
				case global::Infragistics.Windows.Editors.CalendarMode.Centuries:
				{
					int num = (int)global::System.Math.Pow(10.0, (double)(1 + (mode - global::Infragistics.Windows.Editors.CalendarMode.Years)));
					date = base.Calendar.AddYears(date, offset * num);
					break;
				}
				}
			}
			catch (global::System.ArgumentException)
			{
				if (offset < 0)
				{
					global::System.DateTime? dateTime = this.TryAddGroupOffset(date, offset + 1, mode, false);
					if (dateTime != null && dateTime > base.Calendar.MinSupportedDateTime && dateTime <= date)
					{
						date = base.Calendar.MinSupportedDateTime;
						if (adjustForStart)
						{
							date = this.GetGroupStartDate(date, mode);
						}
						return new global::System.DateTime?(date);
					}
				}
				return null;
			}
			if (adjustForStart)
			{
				date = this.GetGroupStartDate(date, mode);
			}
			return new global::System.DateTime?(date);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00011700 File Offset: 0x0000F900
		internal global::System.DateTime AddGroupOffset(global::System.DateTime date, int offset, global::Infragistics.Windows.Editors.CalendarMode mode, bool adjustForStart)
		{
			global::System.DateTime? dateTime = this.TryAddGroupOffset(date, offset, mode, adjustForStart);
			if (dateTime == null)
			{
				dateTime = new global::System.DateTime?(global::Infragistics.Controls.CalendarHelper.GetMinMax(base.Calendar, offset < 0).Date);
				if (adjustForStart)
				{
					dateTime = new global::System.DateTime?(this.GetGroupStartDate(dateTime.Value, mode));
				}
			}
			return dateTime.Value;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00011760 File Offset: 0x0000F960
		internal global::System.DateTime? TryAddItemOffset(global::System.DateTime date, int offset, global::Infragistics.Windows.Editors.CalendarMode mode)
		{
			try
			{
				switch (mode)
				{
				default:
					date = base.Calendar.AddDays(date, offset);
					break;
				case global::Infragistics.Windows.Editors.CalendarMode.Months:
					date = base.Calendar.AddMonths(date, offset);
					break;
				case global::Infragistics.Windows.Editors.CalendarMode.Years:
				case global::Infragistics.Windows.Editors.CalendarMode.Decades:
				case global::Infragistics.Windows.Editors.CalendarMode.Centuries:
				{
					int num = (int)global::System.Math.Pow(10.0, (double)(mode - global::Infragistics.Windows.Editors.CalendarMode.Years));
					date = base.Calendar.AddYears(date, offset * num);
					break;
				}
				}
			}
			catch (global::System.ArgumentException)
			{
				return null;
			}
			return new global::System.DateTime?(date);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000117F8 File Offset: 0x0000F9F8
		internal global::System.DateTime AddItemOffset(global::System.DateTime date, int offset, global::Infragistics.Windows.Editors.CalendarMode mode)
		{
			global::System.DateTime? dateTime = this.TryAddItemOffset(date, offset, mode);
			if (dateTime == null)
			{
				if (offset < 0)
				{
					dateTime = new global::System.DateTime?(base.Calendar.MinSupportedDateTime.Date);
				}
				else
				{
					dateTime = new global::System.DateTime?(base.Calendar.MaxSupportedDateTime.Date);
				}
			}
			return dateTime.Value;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0001185C File Offset: 0x0000FA5C
		private static global::System.DateTime FindVisibleDate(global::System.DateTime date, global::Infragistics.Controls.DayOfWeekFlags hiddenDays, global::System.Globalization.Calendar calendar, int offset)
		{
			try
			{
				while (global::Infragistics.Controls.CalendarHelper.IsSet(hiddenDays, calendar.GetDayOfWeek(date)))
				{
					date = calendar.AddDays(date, offset);
				}
			}
			catch (global::System.ArgumentException)
			{
				if (offset > 0)
				{
					date = calendar.MaxSupportedDateTime;
				}
				else
				{
					date = calendar.MinSupportedDateTime;
				}
			}
			return date;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000118B0 File Offset: 0x0000FAB0
		private int GetDateCount(global::Infragistics.Windows.Editors.CalendarMode mode, bool includeLeadingDates, bool includeTrailingDates, ref global::System.DateTime firstDate)
		{
			global::System.DateTime dateTime = firstDate;
			global::System.Globalization.Calendar calendar = base.Calendar;
			global::System.DateTime groupStartDate = global::Infragistics.Windows.Editors.CalendarManager.GetGroupStartDate(dateTime, mode, calendar, global::Infragistics.Controls.DayOfWeekFlags.None);
			global::System.DateTime groupEndDate = global::Infragistics.Windows.Editors.CalendarManager.GetGroupEndDate(dateTime, mode, calendar, global::Infragistics.Controls.DayOfWeekFlags.None);
			int num;
			switch (mode)
			{
			case global::Infragistics.Windows.Editors.CalendarMode.Days:
				num = base.GetDaysInMonth(dateTime);
				goto IL_B2;
			case global::Infragistics.Windows.Editors.CalendarMode.Months:
			{
				int year = calendar.GetYear(dateTime);
				int era = calendar.GetEra(dateTime);
				num = calendar.GetMonthsInYear(year, era);
				goto IL_B2;
			}
			}
			double num2 = global::System.Math.Pow(10.0, (double)(mode - global::Infragistics.Windows.Editors.CalendarMode.Years));
			int num3 = (int)global::System.Math.Floor((double)calendar.GetYear(groupEndDate) / num2);
			int num4 = (int)global::System.Math.Floor((double)calendar.GetYear(groupStartDate) / num2);
			num = 1 + num3 - num4;
			IL_B2:
			if (includeLeadingDates)
			{
				switch (mode)
				{
				case global::Infragistics.Windows.Editors.CalendarMode.Days:
				{
					int num5 = this.GetDayOfWeekNumber(groupStartDate, false);
					if (num5 == 0 && global::System.Math.Ceiling((double)base.GetDaysInMonth(dateTime) / 7.0) <= 5.0)
					{
						num5 += 7;
					}
					firstDate = base.AddDays(groupStartDate, -num5).Date;
					num += groupStartDate.Subtract(firstDate).Days;
					break;
				}
				case global::Infragistics.Windows.Editors.CalendarMode.Years:
				case global::Infragistics.Windows.Editors.CalendarMode.Decades:
				case global::Infragistics.Windows.Editors.CalendarMode.Centuries:
				{
					int years = -(int)global::System.Math.Pow(10.0, (double)(mode - global::Infragistics.Windows.Editors.CalendarMode.Years));
					firstDate = base.AddYears(groupStartDate, years).Date;
					if (firstDate < dateTime)
					{
						num++;
					}
					break;
				}
				}
			}
			if (includeTrailingDates)
			{
				switch (mode)
				{
				case global::Infragistics.Windows.Editors.CalendarMode.Days:
				{
					int num6 = num;
					num += 6 - this.GetDayOfWeekNumber(groupEndDate, false);
					if (num6 == 35 || this.GetDayOfWeekNumber(groupStartDate, false) != 0)
					{
						int num7 = (int)global::System.Math.Ceiling((double)num / 7.0);
						num += 7 * (6 - num7);
					}
					break;
				}
				case global::Infragistics.Windows.Editors.CalendarMode.Months:
					break;
				default:
					num++;
					break;
				}
			}
			if (!includeLeadingDates && mode == global::Infragistics.Windows.Editors.CalendarMode.Days && groupStartDate < firstDate)
			{
				num -= firstDate.Subtract(groupStartDate).Days;
			}
			return num;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00011ADA File Offset: 0x0000FCDA
		public int GetDayOfWeekNumber(global::System.DateTime date)
		{
			return base.GetDayOfWeekNumber(date, global::Infragistics.Controls.DayOfWeekFlags.None, this._firstDayOfWeek);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00011AEC File Offset: 0x0000FCEC
		public int GetDayOfWeekNumber(global::System.DateTime date, bool honorDisabledDays)
		{
			global::Infragistics.Controls.DayOfWeekFlags hiddenDays = honorDisabledDays ? this._hiddenDays : global::Infragistics.Controls.DayOfWeekFlags.None;
			return base.GetDayOfWeekNumber(date, hiddenDays, this._firstDayOfWeek);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00011B14 File Offset: 0x0000FD14
		internal static string GetString(string name)
		{
			return global::Infragistics.Windows.Editors.CalendarManager.GetString(name, null);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00011B1D File Offset: 0x0000FD1D
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00011B28 File Offset: 0x0000FD28
		internal static int GetItemColumnCount(global::Infragistics.Windows.Editors.CalendarMode mode)
		{
			switch (mode)
			{
			default:
				return 7;
			case global::Infragistics.Windows.Editors.CalendarMode.Months:
				return 4;
			case global::Infragistics.Windows.Editors.CalendarMode.Years:
			case global::Infragistics.Windows.Editors.CalendarMode.Decades:
			case global::Infragistics.Windows.Editors.CalendarMode.Centuries:
				return 4;
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00011B58 File Offset: 0x0000FD58
		internal global::System.DateTime[] GetItemDates(global::System.DateTime date, global::Infragistics.Windows.Editors.CalendarMode mode, bool includeLeadingDates, bool includeTrailingDates, global::System.DateTime minDate, global::System.DateTime maxDate)
		{
			global::System.DateTime dateTime = date;
			global::System.Globalization.Calendar calendar = base.Calendar;
			int dateCount = this.GetDateCount(mode, includeLeadingDates, includeTrailingDates, ref dateTime);
			global::System.DateTime[] array = new global::System.DateTime[dateCount];
			global::System.DateTime dateTime2 = dateTime;
			global::Infragistics.Controls.DayOfWeekFlags dayOfWeekFlags = (mode == global::Infragistics.Windows.Editors.CalendarMode.Days) ? this._hiddenDays : global::Infragistics.Controls.DayOfWeekFlags.None;
			int num = 0;
			for (int i = 0; i < dateCount; i++)
			{
				if (dayOfWeekFlags == global::Infragistics.Controls.DayOfWeekFlags.None || !global::Infragistics.Controls.CalendarHelper.IsSet(dayOfWeekFlags, calendar.GetDayOfWeek(dateTime2)))
				{
					global::System.DateTime itemEndDate = this.GetItemEndDate(dateTime2, mode);
					if (!(itemEndDate < minDate) && !(dateTime2 > maxDate))
					{
						array[num] = dateTime2;
						num++;
					}
				}
				dateTime2 = this.AddItemOffset(dateTime2, 1, mode);
				dateTime2 = this.GetItemStartDate(dateTime2, mode);
				if ((num == 0 && dateTime2 <= this.GetItemEndDate(dateTime, mode)) || (num > 0 && dateTime2 <= this.GetItemEndDate(array[num - 1], mode)))
				{
					break;
				}
			}
			if (array.Length > num)
			{
				global::System.Array.Resize<global::System.DateTime>(ref array, num);
			}
			return array;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00011C58 File Offset: 0x0000FE58
		internal void GetItemRowColumn(global::System.DateTime date, global::Infragistics.Windows.Editors.CalendarMode mode, global::System.DateTime groupStartDate, bool showsLeadingDates, out int colOffset, out int rowOffset)
		{
			switch (mode)
			{
			case global::Infragistics.Windows.Editors.CalendarMode.Days:
			{
				rowOffset = 0;
				colOffset = this.GetDayOfWeekNumber(date, true);
				global::System.DateTime groupStartDate2 = global::Infragistics.Windows.Editors.CalendarManager.GetGroupStartDate(groupStartDate, mode, base.Calendar, global::Infragistics.Controls.DayOfWeekFlags.None);
				int dayOfWeekNumber = this.GetDayOfWeekNumber(groupStartDate2, false);
				if (dayOfWeekNumber == 0 && (!showsLeadingDates || date >= groupStartDate2) && base.GetDaysInMonth(groupStartDate2) < 35)
				{
					rowOffset = 1;
				}
				if (date > groupStartDate2)
				{
					int num = base.GetDayOfMonth(date) - 1;
					num += dayOfWeekNumber;
					rowOffset += num / 7;
					return;
				}
				return;
			}
			case global::Infragistics.Windows.Editors.CalendarMode.Months:
			{
				int num2 = base.Calendar.GetMonth(date) - 1;
				colOffset = num2 % 4;
				rowOffset = num2 / 4;
				return;
			}
			}
			double num3 = global::System.Math.Pow(10.0, (double)(mode - global::Infragistics.Windows.Editors.CalendarMode.Years));
			int num4 = ((int)global::System.Math.Floor((double)base.Calendar.GetYear(date) / num3) + 1) % 10;
			colOffset = num4 % 4;
			rowOffset = num4 / 4;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00011D4C File Offset: 0x0000FF4C
		internal static string GetDayOfWeekCaption(global::Infragistics.Windows.Editors.DayOfWeekHeaderFormat format, global::System.DayOfWeek day, global::System.Globalization.DateTimeFormatInfo formatInfo)
		{
			formatInfo = (formatInfo ?? global::System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat);
			string text;
			if (format == global::Infragistics.Windows.Editors.DayOfWeekHeaderFormat.Abbreviated)
			{
				text = formatInfo.AbbreviatedDayNames[(int)day];
			}
			else
			{
				text = formatInfo.DayNames[(int)day];
				switch (format)
				{
				case global::Infragistics.Windows.Editors.DayOfWeekHeaderFormat.SingleCharacter:
					text = global::Infragistics.Windows.Editors.CalendarManager.GetShortDayOfWeekCaption(text, 1, formatInfo);
					break;
				case global::Infragistics.Windows.Editors.DayOfWeekHeaderFormat.TwoCharacters:
					text = global::Infragistics.Windows.Editors.CalendarManager.GetShortDayOfWeekCaption(text, 2, formatInfo);
					break;
				}
			}
			return text;
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00011DAC File Offset: 0x0000FFAC
		private static string GetDayOfWeekCaption(string dayOfWeek, int index, int length)
		{
			int[] array = global::System.Globalization.StringInfo.ParseCombiningCharacters(dayOfWeek);
			int num = array.Length;
			if (index >= array.Length)
			{
				return null;
			}
			if (num <= length)
			{
				return dayOfWeek;
			}
			if (num == index + length)
			{
				return dayOfWeek.Substring(array[index]);
			}
			return dayOfWeek.Substring(array[index], array[index + length] - array[index]);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00011DF4 File Offset: 0x0000FFF4
		internal string[] GetDayOfWeekCaptions(global::Infragistics.Windows.Editors.DayOfWeekHeaderFormat format)
		{
			string[] array;
			switch (format)
			{
			case global::Infragistics.Windows.Editors.DayOfWeekHeaderFormat.SingleCharacter:
				array = this.GetShortDaysOfWeek(1);
				break;
			case global::Infragistics.Windows.Editors.DayOfWeekHeaderFormat.TwoCharacters:
				array = this.GetShortDaysOfWeek(2);
				break;
			default:
				array = base.DateTimeFormat.AbbreviatedDayNames;
				break;
			case global::Infragistics.Windows.Editors.DayOfWeekHeaderFormat.Full:
				array = base.DateTimeFormat.DayNames;
				break;
			}
			int firstDayOfWeekResolved = (int)this.FirstDayOfWeekResolved;
			if (firstDayOfWeekResolved > 0)
			{
				string[] array2 = new string[firstDayOfWeekResolved];
				global::System.Array.Copy(array, 0, array2, 0, firstDayOfWeekResolved);
				global::System.Array.Copy(array, firstDayOfWeekResolved, array, 0, 7 - firstDayOfWeekResolved);
				global::System.Array.Copy(array2, 0, array, 7 - firstDayOfWeekResolved, firstDayOfWeekResolved);
			}
			return array;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00011E7C File Offset: 0x0001007C
		internal global::System.DayOfWeek[] GetDaysOfWeek()
		{
			int firstDayOfWeekResolved = (int)this.FirstDayOfWeekResolved;
			global::System.Collections.Generic.List<global::System.DayOfWeek> list = new global::System.Collections.Generic.List<global::System.DayOfWeek>(this.VisibleDayCount);
			for (int i = 0; i < 7; i++)
			{
				global::System.DayOfWeek dayOfWeek = (global::System.DayOfWeek)((i + firstDayOfWeekResolved) % 7);
				if (!global::Infragistics.Controls.CalendarHelper.IsSet(this.HiddenDays, dayOfWeek))
				{
					list.Add(dayOfWeek);
				}
			}
			return list.ToArray();
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00011EC9 File Offset: 0x000100C9
		internal global::System.DateTime GetGroupEndDate(global::System.DateTime date, global::Infragistics.Windows.Editors.CalendarMode mode)
		{
			return global::Infragistics.Windows.Editors.CalendarManager.GetGroupEndDate(date, mode, base.Calendar, this._hiddenDays);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00011EE0 File Offset: 0x000100E0
		internal static global::System.DateTime GetGroupEndDate(global::System.DateTime date, global::Infragistics.Windows.Editors.CalendarMode mode, global::System.Globalization.Calendar calendar, global::Infragistics.Controls.DayOfWeekFlags hiddenDays)
		{
			int month = calendar.GetMonth(date);
			int num = calendar.GetYear(date);
			int era = calendar.GetEra(date);
			int daysInMonth = calendar.GetDaysInMonth(num, month, era);
			global::System.DateTime dateTime;
			try
			{
				switch (mode)
				{
				case global::Infragistics.Windows.Editors.CalendarMode.Months:
					month = calendar.GetMonthsInYear(num, era);
					daysInMonth = calendar.GetDaysInMonth(num, month, era);
					break;
				case global::Infragistics.Windows.Editors.CalendarMode.Years:
				case global::Infragistics.Windows.Editors.CalendarMode.Decades:
				case global::Infragistics.Windows.Editors.CalendarMode.Centuries:
				{
					int num2 = (int)global::System.Math.Pow(10.0, (double)(1 + (mode - global::Infragistics.Windows.Editors.CalendarMode.Years)));
					num += num2 - 1 - num % num2;
					month = calendar.GetMonthsInYear(num, era);
					daysInMonth = calendar.GetDaysInMonth(num, month, era);
					break;
				}
				}
				dateTime = calendar.ToDateTime(num, month, daysInMonth, 0, 0, 0, 0, era);
			}
			catch (global::System.ArgumentException)
			{
				dateTime = calendar.MaxSupportedDateTime;
			}
			if (hiddenDays == (global::Infragistics.Controls.DayOfWeekFlags.Sunday | global::Infragistics.Controls.DayOfWeekFlags.Monday | global::Infragistics.Controls.DayOfWeekFlags.Tuesday | global::Infragistics.Controls.DayOfWeekFlags.Wednesday | global::Infragistics.Controls.DayOfWeekFlags.Thursday | global::Infragistics.Controls.DayOfWeekFlags.Friday | global::Infragistics.Controls.DayOfWeekFlags.Saturday))
			{
				return dateTime;
			}
			return global::Infragistics.Windows.Editors.CalendarManager.FindVisibleDate(dateTime, hiddenDays, calendar, -1);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00011FBC File Offset: 0x000101BC
		internal global::System.DateTime GetItemEndDate(global::System.DateTime date, global::Infragistics.Windows.Editors.CalendarMode mode)
		{
			return global::Infragistics.Windows.Editors.CalendarManager.GetItemEndDate(date, mode, base.Calendar);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00011FCC File Offset: 0x000101CC
		internal static global::System.DateTime GetItemEndDate(global::System.DateTime date, global::Infragistics.Windows.Editors.CalendarMode mode, global::System.Globalization.Calendar calendar)
		{
			int month = calendar.GetMonth(date);
			int num = calendar.GetYear(date);
			int era = calendar.GetEra(date);
			int day = calendar.GetDaysInMonth(num, month, era);
			global::System.DateTime result;
			try
			{
				switch (mode)
				{
				case global::Infragistics.Windows.Editors.CalendarMode.Days:
					day = calendar.GetDayOfMonth(date);
					break;
				case global::Infragistics.Windows.Editors.CalendarMode.Years:
					month = calendar.GetMonthsInYear(num, era);
					day = calendar.GetDaysInMonth(num, month, era);
					break;
				case global::Infragistics.Windows.Editors.CalendarMode.Decades:
				case global::Infragistics.Windows.Editors.CalendarMode.Centuries:
				{
					int num2 = (int)global::System.Math.Pow(10.0, (double)(1 + (mode - global::Infragistics.Windows.Editors.CalendarMode.Decades)));
					num += num2 - 1 - num % num2;
					month = calendar.GetMonthsInYear(num, era);
					day = calendar.GetDaysInMonth(num, month, era);
					break;
				}
				}
				result = calendar.ToDateTime(num, month, day, 0, 0, 0, 0, era);
			}
			catch (global::System.ArgumentException)
			{
				result = calendar.MaxSupportedDateTime;
			}
			return result;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x000120A0 File Offset: 0x000102A0
		private string[] GetShortDaysOfWeek(int charCount)
		{
			string[] dayNames = base.DateTimeFormat.DayNames;
			string[] array = new string[7];
			for (int i = 0; i < 7; i++)
			{
				array[i] = global::Infragistics.Windows.Editors.CalendarManager.GetShortDayOfWeekCaption(dayNames[i], charCount, base.DateTimeFormat);
			}
			return array;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x000120E0 File Offset: 0x000102E0
		internal static string GetShortDayOfWeekCaption(string dayOfWeek, int preferredChars, global::System.Globalization.DateTimeFormatInfo dateTimeFormat)
		{
			int num = 0;
			string dayOfWeekCaption;
			do
			{
				dayOfWeekCaption = global::Infragistics.Windows.Editors.CalendarManager.GetDayOfWeekCaption(dayOfWeek, num, preferredChars);
				if (global::Infragistics.Windows.Editors.CalendarManager.InUniqueDayOfWeekCaption(num, dayOfWeek, dayOfWeekCaption, preferredChars, dateTimeFormat))
				{
					break;
				}
				num++;
			}
			while (dayOfWeekCaption != null);
			if (dayOfWeekCaption == null)
			{
				dayOfWeekCaption = global::Infragistics.Windows.Editors.CalendarManager.GetDayOfWeekCaption(dayOfWeek, num, preferredChars);
			}
			return dayOfWeekCaption;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0001211C File Offset: 0x0001031C
		internal global::System.DateTime GetGroupStartDate(global::System.DateTime date, global::Infragistics.Windows.Editors.CalendarMode mode)
		{
			return global::Infragistics.Windows.Editors.CalendarManager.GetGroupStartDate(date, mode, base.Calendar, this._hiddenDays);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00012134 File Offset: 0x00010334
		internal static global::System.DateTime GetGroupStartDate(global::System.DateTime date, global::Infragistics.Windows.Editors.CalendarMode mode, global::System.Globalization.Calendar calendar, global::Infragistics.Controls.DayOfWeekFlags hiddenDays)
		{
			int month = 1;
			int num = calendar.GetYear(date);
			int era = calendar.GetEra(date);
			switch (mode)
			{
			case global::Infragistics.Windows.Editors.CalendarMode.Days:
				month = calendar.GetMonth(date);
				break;
			case global::Infragistics.Windows.Editors.CalendarMode.Years:
			case global::Infragistics.Windows.Editors.CalendarMode.Decades:
			case global::Infragistics.Windows.Editors.CalendarMode.Centuries:
			{
				int num2 = (int)global::System.Math.Pow(10.0, (double)(1 + (mode - global::Infragistics.Windows.Editors.CalendarMode.Years)));
				num -= num % num2;
				if (num < 1)
				{
					num = 1;
				}
				break;
			}
			}
			global::System.DateTime dateTime;
			try
			{
				dateTime = calendar.ToDateTime(num, month, 1, 0, 0, 0, 0, era);
			}
			catch (global::System.ArgumentException)
			{
				dateTime = calendar.MinSupportedDateTime;
			}
			if (hiddenDays == (global::Infragistics.Controls.DayOfWeekFlags.Sunday | global::Infragistics.Controls.DayOfWeekFlags.Monday | global::Infragistics.Controls.DayOfWeekFlags.Tuesday | global::Infragistics.Controls.DayOfWeekFlags.Wednesday | global::Infragistics.Controls.DayOfWeekFlags.Thursday | global::Infragistics.Controls.DayOfWeekFlags.Friday | global::Infragistics.Controls.DayOfWeekFlags.Saturday))
			{
				return dateTime;
			}
			return global::Infragistics.Windows.Editors.CalendarManager.FindVisibleDate(dateTime, hiddenDays, calendar, 1);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x000121E0 File Offset: 0x000103E0
		internal global::System.DateTime GetItemStartDate(global::System.DateTime date, global::Infragistics.Windows.Editors.CalendarMode mode)
		{
			return global::Infragistics.Windows.Editors.CalendarManager.GetItemStartDate(date, mode, base.Calendar);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x000121F0 File Offset: 0x000103F0
		internal static global::System.DateTime GetItemStartDate(global::System.DateTime date, global::Infragistics.Windows.Editors.CalendarMode mode, global::System.Globalization.Calendar calendar)
		{
			int month = 1;
			int num = calendar.GetYear(date);
			int era = calendar.GetEra(date);
			switch (mode)
			{
			case global::Infragistics.Windows.Editors.CalendarMode.Days:
				return date;
			case global::Infragistics.Windows.Editors.CalendarMode.Months:
				month = calendar.GetMonth(date);
				break;
			case global::Infragistics.Windows.Editors.CalendarMode.Years:
			case global::Infragistics.Windows.Editors.CalendarMode.Decades:
			case global::Infragistics.Windows.Editors.CalendarMode.Centuries:
			{
				int num2 = (int)global::System.Math.Pow(10.0, (double)(mode - global::Infragistics.Windows.Editors.CalendarMode.Years));
				num -= num % num2;
				break;
			}
			}
			global::System.DateTime result;
			try
			{
				result = calendar.ToDateTime(num, month, 1, 0, 0, 0, 0, era);
			}
			catch (global::System.ArgumentException)
			{
				result = calendar.MinSupportedDateTime;
			}
			return result;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00012288 File Offset: 0x00010488
		public int GetWeekNumberForDate(global::System.DateTime date)
		{
			int num;
			return base.GetWeekNumberForDate(date, this._weekRule, this._firstDayOfWeek, out num);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x000122AA File Offset: 0x000104AA
		internal void InitializeCulture(global::System.Globalization.CultureInfo cultureInfo)
		{
			if (cultureInfo == null)
			{
				cultureInfo = global::System.Globalization.CultureInfo.CurrentCulture;
			}
			base.Initialize(cultureInfo.Calendar, cultureInfo.DateTimeFormat);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x000122C8 File Offset: 0x000104C8
		private static bool InUniqueDayOfWeekCaption(int index, string dayOfWeek, string text, int length, global::System.Globalization.DateTimeFormatInfo dateTimeFormat)
		{
			foreach (string text2 in dateTimeFormat.DayNames)
			{
				if (!(text2 == dayOfWeek) && text != global::Infragistics.Windows.Editors.CalendarManager.GetDayOfWeekCaption(text2, index, length))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0001230F File Offset: 0x0001050F
		protected override void VerifyCanChange()
		{
			if (this == global::Infragistics.Windows.Editors.CalendarManager.currentCulture)
			{
				throw new global::System.InvalidOperationException("The shared current culture CalendarManager cannot be changed.");
			}
		}

		// Token: 0x04000188 RID: 392
		private global::System.DayOfWeek? _firstDayOfWeek;

		// Token: 0x04000189 RID: 393
		private global::System.Globalization.CalendarWeekRule? _weekRule;

		// Token: 0x0400018A RID: 394
		private global::Infragistics.Controls.DayOfWeekFlags _hiddenDays;

		// Token: 0x0400018B RID: 395
		private int _visibleDayCount = 7;

		// Token: 0x0400018C RID: 396
		private static global::Infragistics.Windows.Editors.CalendarManager currentCulture;
	}
}
