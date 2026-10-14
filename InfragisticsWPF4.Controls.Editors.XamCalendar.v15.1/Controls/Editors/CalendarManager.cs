using System;
using System.Collections.Generic;
using System.Globalization;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000026 RID: 38
	internal class CalendarManager : global::Infragistics.Controls.CalendarHelper
	{
		// Token: 0x0600020C RID: 524 RVA: 0x0000B5ED File Offset: 0x000097ED
		internal CalendarManager() : base(global::System.Globalization.CultureInfo.CurrentCulture)
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000B601 File Offset: 0x00009801
		internal CalendarManager(global::System.Globalization.CultureInfo culture) : base(culture)
		{
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600020E RID: 526 RVA: 0x0000B611 File Offset: 0x00009811
		internal static global::Infragistics.Controls.Editors.CalendarManager CurrentCulture
		{
			get
			{
				if (global::Infragistics.Controls.Editors.CalendarManager.currentCulture == null)
				{
					global::Infragistics.Controls.Editors.CalendarManager.currentCulture = new global::Infragistics.Controls.Editors.CalendarManager();
				}
				return global::Infragistics.Controls.Editors.CalendarManager.currentCulture;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0000B629 File Offset: 0x00009829
		// (set) Token: 0x06000210 RID: 528 RVA: 0x0000B634 File Offset: 0x00009834
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

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0000B678 File Offset: 0x00009878
		// (set) Token: 0x06000212 RID: 530 RVA: 0x0000B680 File Offset: 0x00009880
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

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0000B68F File Offset: 0x0000988F
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

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000214 RID: 532 RVA: 0x0000B6B5 File Offset: 0x000098B5
		public int VisibleDayCount
		{
			get
			{
				return this._visibleDayCount;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000215 RID: 533 RVA: 0x0000B6BD File Offset: 0x000098BD
		// (set) Token: 0x06000216 RID: 534 RVA: 0x0000B6C5 File Offset: 0x000098C5
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

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000217 RID: 535 RVA: 0x0000B6D4 File Offset: 0x000098D4
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

		// Token: 0x06000218 RID: 536 RVA: 0x0000B6FC File Offset: 0x000098FC
		internal global::System.DateTime? TryAddGroupOffset(global::System.DateTime date, int offset, global::Infragistics.Controls.Editors.CalendarZoomMode mode, bool adjustForStart)
		{
			try
			{
				switch (mode)
				{
				default:
					date = base.Calendar.AddMonths(date, offset);
					break;
				case global::Infragistics.Controls.Editors.CalendarZoomMode.Months:
					date = base.Calendar.AddYears(date, offset);
					break;
				case global::Infragistics.Controls.Editors.CalendarZoomMode.Years:
				case global::Infragistics.Controls.Editors.CalendarZoomMode.Decades:
				case global::Infragistics.Controls.Editors.CalendarZoomMode.Centuries:
				{
					int num = (int)global::System.Math.Pow(10.0, (double)(1 + (mode - global::Infragistics.Controls.Editors.CalendarZoomMode.Years)));
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

		// Token: 0x06000219 RID: 537 RVA: 0x0000B838 File Offset: 0x00009A38
		internal global::System.DateTime AddGroupOffset(global::System.DateTime date, int offset, global::Infragistics.Controls.Editors.CalendarZoomMode mode, bool adjustForStart)
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

		// Token: 0x0600021A RID: 538 RVA: 0x0000B898 File Offset: 0x00009A98
		internal global::System.DateTime? TryAddItemOffset(global::System.DateTime date, int offset, global::Infragistics.Controls.Editors.CalendarZoomMode mode)
		{
			try
			{
				switch (mode)
				{
				default:
					date = base.Calendar.AddDays(date, offset);
					break;
				case global::Infragistics.Controls.Editors.CalendarZoomMode.Months:
					date = base.Calendar.AddMonths(date, offset);
					break;
				case global::Infragistics.Controls.Editors.CalendarZoomMode.Years:
				case global::Infragistics.Controls.Editors.CalendarZoomMode.Decades:
				case global::Infragistics.Controls.Editors.CalendarZoomMode.Centuries:
				{
					int num = (int)global::System.Math.Pow(10.0, (double)(mode - global::Infragistics.Controls.Editors.CalendarZoomMode.Years));
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

		// Token: 0x0600021B RID: 539 RVA: 0x0000B930 File Offset: 0x00009B30
		internal global::System.DateTime AddItemOffset(global::System.DateTime date, int offset, global::Infragistics.Controls.Editors.CalendarZoomMode mode)
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

		// Token: 0x0600021C RID: 540 RVA: 0x0000B994 File Offset: 0x00009B94
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

		// Token: 0x0600021D RID: 541 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		private int GetDateCount(global::Infragistics.Controls.Editors.CalendarZoomMode mode, bool includeLeadingDates, bool includeTrailingDates, ref global::System.DateTime firstDate)
		{
			global::System.DateTime dateTime = firstDate;
			global::System.Globalization.Calendar calendar = base.Calendar;
			global::System.DateTime groupStartDate = global::Infragistics.Controls.Editors.CalendarManager.GetGroupStartDate(dateTime, mode, calendar, global::Infragistics.Controls.DayOfWeekFlags.None);
			global::System.DateTime groupEndDate = global::Infragistics.Controls.Editors.CalendarManager.GetGroupEndDate(dateTime, mode, calendar, global::Infragistics.Controls.DayOfWeekFlags.None);
			int num;
			switch (mode)
			{
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Days:
				num = base.GetDaysInMonth(dateTime);
				goto IL_B2;
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Months:
			{
				int year = calendar.GetYear(dateTime);
				int era = calendar.GetEra(dateTime);
				num = calendar.GetMonthsInYear(year, era);
				goto IL_B2;
			}
			}
			double num2 = global::System.Math.Pow(10.0, (double)(mode - global::Infragistics.Controls.Editors.CalendarZoomMode.Years));
			int num3 = (int)global::System.Math.Floor((double)calendar.GetYear(groupEndDate) / num2);
			int num4 = (int)global::System.Math.Floor((double)calendar.GetYear(groupStartDate) / num2);
			num = 1 + num3 - num4;
			IL_B2:
			if (includeLeadingDates)
			{
				switch (mode)
				{
				case global::Infragistics.Controls.Editors.CalendarZoomMode.Days:
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
				case global::Infragistics.Controls.Editors.CalendarZoomMode.Years:
				case global::Infragistics.Controls.Editors.CalendarZoomMode.Decades:
				case global::Infragistics.Controls.Editors.CalendarZoomMode.Centuries:
				{
					int years = -(int)global::System.Math.Pow(10.0, (double)(mode - global::Infragistics.Controls.Editors.CalendarZoomMode.Years));
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
				case global::Infragistics.Controls.Editors.CalendarZoomMode.Days:
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
				case global::Infragistics.Controls.Editors.CalendarZoomMode.Months:
					break;
				default:
					num++;
					break;
				}
			}
			if (!includeLeadingDates && mode == global::Infragistics.Controls.Editors.CalendarZoomMode.Days && groupStartDate < firstDate)
			{
				num -= firstDate.Subtract(groupStartDate).Days;
			}
			return num;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000BC12 File Offset: 0x00009E12
		public int GetDayOfWeekNumber(global::System.DateTime date)
		{
			return base.GetDayOfWeekNumber(date, global::Infragistics.Controls.DayOfWeekFlags.None, this._firstDayOfWeek);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000BC24 File Offset: 0x00009E24
		public int GetDayOfWeekNumber(global::System.DateTime date, bool honorDisabledDays)
		{
			global::Infragistics.Controls.DayOfWeekFlags hiddenDays = honorDisabledDays ? this._hiddenDays : global::Infragistics.Controls.DayOfWeekFlags.None;
			return base.GetDayOfWeekNumber(date, hiddenDays, new global::System.DayOfWeek?(this.FirstDayOfWeekResolved));
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000BC51 File Offset: 0x00009E51
		internal static string GetString(string name)
		{
			return global::Infragistics.Controls.Editors.CalendarManager.GetString(name, null);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000BC5A File Offset: 0x00009E5A
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000BC64 File Offset: 0x00009E64
		internal static int GetItemColumnCount(global::Infragistics.Controls.Editors.CalendarZoomMode mode)
		{
			switch (mode)
			{
			default:
				return 7;
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Months:
				return 4;
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Years:
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Decades:
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Centuries:
				return 4;
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000BC94 File Offset: 0x00009E94
		internal global::System.DateTime[] GetItemDates(global::System.DateTime date, global::Infragistics.Controls.Editors.CalendarZoomMode mode, bool includeLeadingDates, bool includeTrailingDates, global::System.DateTime minDate, global::System.DateTime maxDate)
		{
			global::System.DateTime dateTime = date;
			global::System.Globalization.Calendar calendar = base.Calendar;
			int dateCount = this.GetDateCount(mode, includeLeadingDates, includeTrailingDates, ref dateTime);
			global::System.DateTime[] array = new global::System.DateTime[dateCount];
			global::System.DateTime dateTime2 = dateTime;
			global::Infragistics.Controls.DayOfWeekFlags dayOfWeekFlags = (mode == global::Infragistics.Controls.Editors.CalendarZoomMode.Days) ? this._hiddenDays : global::Infragistics.Controls.DayOfWeekFlags.None;
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

		// Token: 0x06000224 RID: 548 RVA: 0x0000BD94 File Offset: 0x00009F94
		internal void GetItemRowColumn(global::System.DateTime date, global::Infragistics.Controls.Editors.CalendarZoomMode mode, global::System.DateTime groupStartDate, bool showsLeadingDates, out int colOffset, out int rowOffset)
		{
			switch (mode)
			{
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Days:
			{
				rowOffset = 0;
				colOffset = this.GetDayOfWeekNumber(date, true);
				global::System.DateTime groupStartDate2 = global::Infragistics.Controls.Editors.CalendarManager.GetGroupStartDate(groupStartDate, mode, base.Calendar, global::Infragistics.Controls.DayOfWeekFlags.None);
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
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Months:
			{
				int num2 = base.Calendar.GetMonth(date) - 1;
				colOffset = num2 % 4;
				rowOffset = num2 / 4;
				return;
			}
			}
			double num3 = global::System.Math.Pow(10.0, (double)(mode - global::Infragistics.Controls.Editors.CalendarZoomMode.Years));
			int num4 = ((int)global::System.Math.Floor((double)base.Calendar.GetYear(date) / num3) + 1) % 10;
			colOffset = num4 % 4;
			rowOffset = num4 / 4;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000BE88 File Offset: 0x0000A088
		internal string GetDayOfWeekCaption(global::Infragistics.Controls.Editors.DayOfWeekHeaderFormat format, global::System.DayOfWeek day)
		{
			global::System.Globalization.DateTimeFormatInfo dateTimeFormat = base.DateTimeFormat;
			string text;
			if (format == global::Infragistics.Controls.Editors.DayOfWeekHeaderFormat.Abbreviated)
			{
				text = dateTimeFormat.AbbreviatedDayNames[(int)day];
			}
			else
			{
				text = dateTimeFormat.DayNames[(int)day];
				switch (format)
				{
				case global::Infragistics.Controls.Editors.DayOfWeekHeaderFormat.SingleCharacter:
					text = global::Infragistics.Controls.Editors.CalendarManager.GetShortDayOfWeekCaption(text, 1, dateTimeFormat);
					break;
				case global::Infragistics.Controls.Editors.DayOfWeekHeaderFormat.TwoCharacters:
					text = global::Infragistics.Controls.Editors.CalendarManager.GetShortDayOfWeekCaption(text, 2, dateTimeFormat);
					break;
				}
			}
			return text;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
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

		// Token: 0x06000227 RID: 551 RVA: 0x0000BF28 File Offset: 0x0000A128
		internal string[] GetDayOfWeekCaptions(global::Infragistics.Controls.Editors.DayOfWeekHeaderFormat format)
		{
			string[] array;
			switch (format)
			{
			case global::Infragistics.Controls.Editors.DayOfWeekHeaderFormat.SingleCharacter:
				array = this.GetShortDaysOfWeek(1);
				break;
			case global::Infragistics.Controls.Editors.DayOfWeekHeaderFormat.TwoCharacters:
				array = this.GetShortDaysOfWeek(2);
				break;
			default:
				array = base.DateTimeFormat.AbbreviatedDayNames;
				break;
			case global::Infragistics.Controls.Editors.DayOfWeekHeaderFormat.Full:
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

		// Token: 0x06000228 RID: 552 RVA: 0x0000BFB0 File Offset: 0x0000A1B0
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

		// Token: 0x06000229 RID: 553 RVA: 0x0000BFFD File Offset: 0x0000A1FD
		internal global::System.DateTime GetGroupEndDate(global::System.DateTime date, global::Infragistics.Controls.Editors.CalendarZoomMode mode)
		{
			return global::Infragistics.Controls.Editors.CalendarManager.GetGroupEndDate(date, mode, base.Calendar, this._hiddenDays);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000C014 File Offset: 0x0000A214
		internal static global::System.DateTime GetGroupEndDate(global::System.DateTime date, global::Infragistics.Controls.Editors.CalendarZoomMode mode, global::System.Globalization.Calendar calendar, global::Infragistics.Controls.DayOfWeekFlags hiddenDays)
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
				case global::Infragistics.Controls.Editors.CalendarZoomMode.Months:
					month = calendar.GetMonthsInYear(num, era);
					daysInMonth = calendar.GetDaysInMonth(num, month, era);
					break;
				case global::Infragistics.Controls.Editors.CalendarZoomMode.Years:
				case global::Infragistics.Controls.Editors.CalendarZoomMode.Decades:
				case global::Infragistics.Controls.Editors.CalendarZoomMode.Centuries:
				{
					int num2 = (int)global::System.Math.Pow(10.0, (double)(1 + (mode - global::Infragistics.Controls.Editors.CalendarZoomMode.Years)));
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
			return global::Infragistics.Controls.Editors.CalendarManager.FindVisibleDate(dateTime, hiddenDays, calendar, -1);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		internal global::System.DateTime GetItemEndDate(global::System.DateTime date, global::Infragistics.Controls.Editors.CalendarZoomMode mode)
		{
			return global::Infragistics.Controls.Editors.CalendarManager.GetItemEndDate(date, mode, base.Calendar);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000C100 File Offset: 0x0000A300
		internal static global::System.DateTime GetItemEndDate(global::System.DateTime date, global::Infragistics.Controls.Editors.CalendarZoomMode mode, global::System.Globalization.Calendar calendar)
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
				case global::Infragistics.Controls.Editors.CalendarZoomMode.Days:
					day = calendar.GetDayOfMonth(date);
					break;
				case global::Infragistics.Controls.Editors.CalendarZoomMode.Years:
					month = calendar.GetMonthsInYear(num, era);
					day = calendar.GetDaysInMonth(num, month, era);
					break;
				case global::Infragistics.Controls.Editors.CalendarZoomMode.Decades:
				case global::Infragistics.Controls.Editors.CalendarZoomMode.Centuries:
				{
					int num2 = (int)global::System.Math.Pow(10.0, (double)(1 + (mode - global::Infragistics.Controls.Editors.CalendarZoomMode.Decades)));
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

		// Token: 0x0600022D RID: 557 RVA: 0x0000C1D4 File Offset: 0x0000A3D4
		private string[] GetShortDaysOfWeek(int charCount)
		{
			string[] dayNames = base.DateTimeFormat.DayNames;
			string[] array = new string[7];
			for (int i = 0; i < 7; i++)
			{
				array[i] = global::Infragistics.Controls.Editors.CalendarManager.GetShortDayOfWeekCaption(dayNames[i], charCount, base.DateTimeFormat);
			}
			return array;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000C214 File Offset: 0x0000A414
		internal static string GetShortDayOfWeekCaption(string dayOfWeek, int preferredChars, global::System.Globalization.DateTimeFormatInfo dateTimeFormat)
		{
			int num = 0;
			string dayOfWeekCaption;
			do
			{
				dayOfWeekCaption = global::Infragistics.Controls.Editors.CalendarManager.GetDayOfWeekCaption(dayOfWeek, num, preferredChars);
				if (global::Infragistics.Controls.Editors.CalendarManager.InUniqueDayOfWeekCaption(num, dayOfWeek, dayOfWeekCaption, preferredChars, dateTimeFormat))
				{
					break;
				}
				num++;
			}
			while (dayOfWeekCaption != null);
			if (dayOfWeekCaption == null)
			{
				dayOfWeekCaption = global::Infragistics.Controls.Editors.CalendarManager.GetDayOfWeekCaption(dayOfWeek, num, preferredChars);
			}
			return dayOfWeekCaption;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000C250 File Offset: 0x0000A450
		internal global::System.DateTime GetGroupStartDate(global::System.DateTime date, global::Infragistics.Controls.Editors.CalendarZoomMode mode)
		{
			return global::Infragistics.Controls.Editors.CalendarManager.GetGroupStartDate(date, mode, base.Calendar, this._hiddenDays);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000C268 File Offset: 0x0000A468
		internal static global::System.DateTime GetGroupStartDate(global::System.DateTime date, global::Infragistics.Controls.Editors.CalendarZoomMode mode, global::System.Globalization.Calendar calendar, global::Infragistics.Controls.DayOfWeekFlags hiddenDays)
		{
			int month = 1;
			int num = calendar.GetYear(date);
			int era = calendar.GetEra(date);
			switch (mode)
			{
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Days:
				month = calendar.GetMonth(date);
				break;
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Years:
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Decades:
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Centuries:
			{
				int num2 = (int)global::System.Math.Pow(10.0, (double)(1 + (mode - global::Infragistics.Controls.Editors.CalendarZoomMode.Years)));
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
			return global::Infragistics.Controls.Editors.CalendarManager.FindVisibleDate(dateTime, hiddenDays, calendar, 1);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000C314 File Offset: 0x0000A514
		internal global::System.DateTime GetItemStartDate(global::System.DateTime date, global::Infragistics.Controls.Editors.CalendarZoomMode mode)
		{
			return global::Infragistics.Controls.Editors.CalendarManager.GetItemStartDate(date, mode, base.Calendar);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000C324 File Offset: 0x0000A524
		internal static global::System.DateTime GetItemStartDate(global::System.DateTime date, global::Infragistics.Controls.Editors.CalendarZoomMode mode, global::System.Globalization.Calendar calendar)
		{
			int month = 1;
			int num = calendar.GetYear(date);
			int era = calendar.GetEra(date);
			switch (mode)
			{
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Days:
				return date;
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Months:
				month = calendar.GetMonth(date);
				break;
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Years:
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Decades:
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Centuries:
			{
				int num2 = (int)global::System.Math.Pow(10.0, (double)(mode - global::Infragistics.Controls.Editors.CalendarZoomMode.Years));
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

		// Token: 0x06000233 RID: 563 RVA: 0x0000C3BC File Offset: 0x0000A5BC
		public int GetWeekNumberForDate(global::System.DateTime date)
		{
			int num;
			return base.GetWeekNumberForDate(date, this._weekRule, this._firstDayOfWeek, out num);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000C3DE File Offset: 0x0000A5DE
		internal void InitializeCalendarInfo(global::System.Globalization.Calendar calendar, global::System.Globalization.DateTimeFormatInfo dateTimeFormat)
		{
			this.VerifyCanChange();
			if (calendar == null)
			{
				calendar = global::System.Globalization.CultureInfo.CurrentCulture.Calendar;
			}
			if (dateTimeFormat == null)
			{
				dateTimeFormat = global::System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat;
			}
			base.Initialize(calendar, dateTimeFormat);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000C40C File Offset: 0x0000A60C
		private static bool InUniqueDayOfWeekCaption(int index, string dayOfWeek, string text, int length, global::System.Globalization.DateTimeFormatInfo dateTimeFormat)
		{
			foreach (string text2 in dateTimeFormat.DayNames)
			{
				if (!(text2 == dayOfWeek) && text != global::Infragistics.Controls.Editors.CalendarManager.GetDayOfWeekCaption(text2, index, length))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000C453 File Offset: 0x0000A653
		protected override void VerifyCanChange()
		{
			if (this == global::Infragistics.Controls.Editors.CalendarManager.currentCulture)
			{
				throw new global::System.InvalidOperationException("The shared current culture CalendarManager cannot be changed.");
			}
		}

		// Token: 0x040000CE RID: 206
		private global::System.DayOfWeek? _firstDayOfWeek;

		// Token: 0x040000CF RID: 207
		private global::System.Globalization.CalendarWeekRule? _weekRule;

		// Token: 0x040000D0 RID: 208
		private global::Infragistics.Controls.DayOfWeekFlags _hiddenDays;

		// Token: 0x040000D1 RID: 209
		private int _visibleDayCount = 7;

		// Token: 0x040000D2 RID: 210
		private static global::Infragistics.Controls.Editors.CalendarManager currentCulture;
	}
}
